namespace Korn.Analyzer.Utils;
public unsafe class PEEditor : IDisposable
{
    public PEEditor(byte[] bytes)
    {
        Length = bytes.Length;
        Image = (PEImage*)Marshal.AllocCoTaskMem(Length);
        fixed (byte* ptr = bytes)
            Buffer.MemoryCopy(ptr, Image, Length, Length);
    }

    public PEEditor(string path) : this(File.ReadAllBytes(path)) { }

    public readonly PEImage* Image;
    readonly int Length;

    public uint EntryPoint { get => Image->optionalHeader->AddressOfEntryPoint; set => Image->optionalHeader->AddressOfEntryPoint = value; }

    public void RemoveExportFunction(ReadOnlySpan<byte> nameToRemove)
    {
        var functionIndex = Image->GetEATFuncIndex(nameToRemove);
        if (functionIndex != -1)
        {
            Image->ShiftTableEntries((uint*)(Image->ptr + Image->enptOffset), Image->exportDirectory->NumberOfNames, (uint)functionIndex);

            ushort ordinal = *((ushort*)(Image->ptr + Image->eotOffset) + functionIndex);
            Image->ShiftOrdinalTableEntries((ushort*)(Image->ptr + Image->eotOffset), Image->exportDirectory->NumberOfNames, (uint)functionIndex);

            Image->ShiftTableEntries((uint*)(Image->ptr + Image->eatOffset), Image->exportDirectory->NumberOfFunctions, ordinal);

            Image->exportDirectory->NumberOfNames--;
            Image->exportDirectory->NumberOfFunctions--;
        }
    }

    public uint GetExportFunctionAddress(ReadOnlySpan<byte> name) => Image->GetEATFunc(name);

    public long CalculateFunctionSize(nint start, byte[] pattern)
    {
        var ptr = (byte*)start;
        var step = 0;
        for (uint i = 0; ;)
        {
            if (i > 0x1000)
                return -1;

            if (ptr[i + step] == pattern[step])
            {
                step++;
                if (step == pattern.Length)
                    return i;
            }
            else
            {
                step = 0;
                i++;
            }
        }
    }

    public void Save(string path)
    {
        var bytes = new byte[Length];
        Marshal.Copy((nint)Image, bytes, 0, Length);
        File.WriteAllBytes(path, bytes);
    }

    public void Dispose() => Marshal.FreeCoTaskMem((nint)Image);
}

[StructLayout(LayoutKind.Explicit)]
public unsafe struct PEImage
{
    [FieldOffset(0x3C)]
    public uint e_lfanew;

    public nint ptr { get { fixed (PEImage* p = &this) return (nint)p; } }
    public uint peHeader => *(uint*)(ptr + e_lfanew);
    public ImageFileHeader* fileHeader => (ImageFileHeader*)(ptr + e_lfanew + 4);
    public ImageOptionalHeader64* optionalHeader => (ImageOptionalHeader64*)(ptr + e_lfanew + 4 + 20);
    public ImageSectionHeader* sectionHeaders => (ImageSectionHeader*)(ptr + e_lfanew + 4 + sizeof(ImageFileHeader) + fileHeader->SizeOfOptionalHeader);
    public uint exportDirectoryRVA => optionalHeader->ExportTable.VirtualAddress;
    public uint exportDirectorySize => optionalHeader->ExportTable.Size;
    public uint exportDirectoryOffset => RvaToFileOffset(exportDirectoryRVA);
    public ImageExportDirectory* exportDirectory => (ImageExportDirectory*)(ptr + exportDirectoryOffset);
    public uint eatOffset => RvaToFileOffset(exportDirectory->AddressOfFunctions);
    public uint enptOffset => RvaToFileOffset(exportDirectory->AddressOfNames);
    public uint eotOffset => RvaToFileOffset(exportDirectory->AddressOfNameOrdinals);

    public uint RvaToFileOffset(uint rva)
    {
        var e_lfanew = *(uint*)(ptr + 0x3C);
        var fileHeader = (ImageFileHeader*)(ptr + e_lfanew + 4);
        var sectionHeaders = (ImageSectionHeader*)(ptr + e_lfanew + 4 + sizeof(ImageFileHeader) + fileHeader->SizeOfOptionalHeader);

        for (int i = 0; i < fileHeader->NumberOfSections; i++)
        {
            var section = sectionHeaders[i];
            if (rva >= section.VirtualAddress && rva < section.VirtualAddress + section.SizeOfRawData)
                return rva - section.VirtualAddress + section.PointerToRawData;
        }
        return 0;
    }

    public uint GetEATFunc(ReadOnlySpan<byte> targetName)
    {
        var index = GetEATFuncIndex(targetName);
        if (index == -1)
            return 0;
        else return *((uint*)(ptr + eatOffset) + index);
    }

    public long GetEATFuncIndex(ReadOnlySpan<byte> targetName)
    {
        for (uint i = 0; i < exportDirectory->NumberOfNames; i++)
        {
            uint nameRva = *((uint*)(ptr + enptOffset) + i);
            var nameOffset = RvaToFileOffset(nameRva);
            var name = ptr + nameOffset;
            var good = true;
            for (var o = 0; o < targetName.Length; o++)
                if (((byte*)name)[o] != targetName[o])
                {
                    good = false;
                    break;
                }
            if (good)
                return i;
        }
        return -1;
    }

    public void ShiftTableEntries<T>(T* table, uint count, uint indexToRemove) where T : unmanaged
    {
        for (uint i = indexToRemove; i < count - 1; i++)
            table[i] = table[i + 1];
    }

    public void ShiftOrdinalTableEntries(ushort* table, uint count, uint indexToRemove)
    {
        for (uint i = indexToRemove; i < count - 1; i++)
            table[i] = (ushort)(table[i + 1] - 1);
    }

    public nint GetCalledFuncAddress(byte* inst)
    {
        if (*inst == 0xE9 || *inst == 0xE8)
        {
            int offset = *(int*)(inst + 1) - 5;
            return (nint)(inst + offset);
        }
        else throw new Exception($"Can't get original DllMain functions. An unexpected instruction \'0x{*inst}\'");
    }
}

[StructLayout(LayoutKind.Sequential)]
public struct ImageExportDirectory
{
    public uint Characteristics;
    public uint TimeDateStamp;
    public ushort MajorVersion;
    public ushort MinorVersion;
    public uint Name;
    public uint Base;
    public uint NumberOfFunctions;
    public uint NumberOfNames;
    public uint AddressOfFunctions;
    public uint AddressOfNames;
    public uint AddressOfNameOrdinals;
}

[StructLayout(LayoutKind.Sequential)]
public struct ImageFileHeader
{
    public ushort Machine;
    public ushort NumberOfSections;
    public uint TimeDateStamp;
    public uint PointerToSymbolTable;
    public uint NumberOfSymbols;
    public ushort SizeOfOptionalHeader;
    public ushort Characteristics;
}

[StructLayout(LayoutKind.Sequential)]
public struct ImageOptionalHeader64
{
    public ushort Magic;
    public byte MajorLinkerVersion;
    public byte MinorLinkerVersion;
    public uint SizeOfCode;
    public uint SizeOfInitializedData;
    public uint SizeOfUninitializedData;
    public uint AddressOfEntryPoint;
    public uint BaseOfCode;
    public ulong ImageBase;
    public uint SectionAlignment;
    public uint FileAlignment;
    public ushort MajorOperatingSystemVersion;
    public ushort MinorOperatingSystemVersion;
    public ushort MajorImageVersion;
    public ushort MinorImageVersion;
    public ushort MajorSubsystemVersion;
    public ushort MinorSubsystemVersion;
    public uint Win32VersionValue;
    public uint SizeOfImage;
    public uint SizeOfHeaders;
    public uint CheckSum;
    public ushort Subsystem;
    public ushort DllCharacteristics;
    public ulong SizeOfStackReserve;
    public ulong SizeOfStackCommit;
    public ulong SizeOfHeapReserve;
    public ulong SizeOfHeapCommit;
    public uint LoaderFlags;
    public uint NumberOfRvaAndSizes;

    public ImageDataDirectory ExportTable;
    public ImageDataDirectory ImportTable;
    public ImageDataDirectory ResourceTable;
    public ImageDataDirectory ExceptionTable;
    public ImageDataDirectory CertificateTable;
    public ImageDataDirectory BaseRelocationTable;
    public ImageDataDirectory Debug;
    public ImageDataDirectory Architecture;
    public ImageDataDirectory GlobalPtr;
    public ImageDataDirectory TLSTable;
    public ImageDataDirectory LoadConfigTable;
    public ImageDataDirectory BoundImport;
    public ImageDataDirectory IAT;
    public ImageDataDirectory DelayImportDescriptor;
    public ImageDataDirectory CLRRuntimeHeader;
    public ImageDataDirectory Reserved;
}

[StructLayout(LayoutKind.Sequential)]
public struct ImageDataDirectory
{
    public uint VirtualAddress;
    public uint Size;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct ImageSectionHeader
{
    public fixed byte Name[8];
    public uint VirtualSize;
    public uint VirtualAddress;
    public uint SizeOfRawData;
    public uint PointerToRawData;
    public uint PointerToRelocations;
    public uint PointerToLinenumbers;
    public ushort NumberOfRelocations;
    public ushort NumberOfLinenumbers;
    public uint Characteristics;
}