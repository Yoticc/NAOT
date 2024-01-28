using System.Runtime.InteropServices;

public unsafe class kernel32
{
    const string lib = "kernel32";
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer VirtualAlloc(cpointer lpAddress, cpointer dwSize, int flAllocationType, int flProtect);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool VirtualProtect(cpointer lpAddress, cpointer dwSize, int flNewProtect, cpointer unfoundType_PDWORD_lpflOldProtect);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool VirtualFree(cpointer lpAddress, cpointer dwSize, int dwFreeType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint* VirtualQuery(cpointer lpAddress, cpointer unfoundType_PMEMORY_BASIC_INFORMATION_lpBuffer, cpointer dwLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer VirtualAllocEx(cpointer hProcess, cpointer lpAddress, cpointer dwSize, int flAllocationType, int flProtect);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool VirtualProtectEx(cpointer hProcess, cpointer lpAddress, cpointer dwSize, int flNewProtect, cpointer unfoundType_PDWORD_lpflOldProtect);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint* VirtualQueryEx(cpointer hProcess, cpointer lpAddress, cpointer unfoundType_PMEMORY_BASIC_INFORMATION_lpBuffer, cpointer dwLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadProcessMemory(cpointer hProcess, cpointer lpBaseAddress, cpointer lpBuffer, cpointer nSize, cpointer lpNumberOfBytesRead);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteProcessMemory(cpointer hProcess, cpointer lpBaseAddress, cpointer lpBuffer, cpointer nSize, cpointer lpNumberOfBytesWritten);
    [DllImport(lib, EntryPoint = "CreateFileMappingW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateFileMapping(cpointer hFile, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpFileMappingAttributes, int flProtect, int dwMaximumSizeHigh, int dwMaximumSizeLow, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport(lib, EntryPoint = "CreateFileMappingW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateFileMapping(cpointer hFile, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpFileMappingAttributes, int flProtect, int dwMaximumSizeHigh, int dwMaximumSizeLow, char* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateFileMappingW(cpointer hFile, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpFileMappingAttributes, int flProtect, int dwMaximumSizeHigh, int dwMaximumSizeLow, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateFileMappingW(cpointer hFile, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpFileMappingAttributes, int flProtect, int dwMaximumSizeHigh, int dwMaximumSizeLow, char* lpName);
    [DllImport(lib, EntryPoint = "OpenFileMappingW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenFileMapping(int dwDesiredAccess, bool bInheritHandle, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport(lib, EntryPoint = "OpenFileMappingW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenFileMapping(int dwDesiredAccess, bool bInheritHandle, char* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenFileMappingW(int dwDesiredAccess, bool bInheritHandle, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenFileMappingW(int dwDesiredAccess, bool bInheritHandle, char* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer MapViewOfFile(cpointer hFileMappingObject, int dwDesiredAccess, int dwFileOffsetHigh, int dwFileOffsetLow, cpointer dwNumberOfBytesToMap);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer MapViewOfFileEx(cpointer hFileMappingObject, int dwDesiredAccess, int dwFileOffsetHigh, int dwFileOffsetLow, cpointer dwNumberOfBytesToMap, cpointer lpBaseAddress);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool VirtualFreeEx(cpointer hProcess, cpointer lpAddress, cpointer dwSize, int dwFreeType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FlushViewOfFile(cpointer lpBaseAddress, cpointer dwNumberOfBytesToFlush);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UnmapViewOfFile(cpointer lpBaseAddress);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint* GetLargePageMinimum();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetProcessWorkingSetSize(cpointer hProcess, cpointer unfoundType_PSIZE_T_lpMinimumWorkingSetSize, cpointer unfoundType_PSIZE_T_lpMaximumWorkingSetSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetProcessWorkingSetSizeEx(cpointer hProcess, cpointer unfoundType_PSIZE_T_lpMinimumWorkingSetSize, cpointer unfoundType_PSIZE_T_lpMaximumWorkingSetSize, cpointer unfoundType_PDWORD_Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetProcessWorkingSetSize(cpointer hProcess, cpointer dwMinimumWorkingSetSize, cpointer dwMaximumWorkingSetSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetProcessWorkingSetSizeEx(cpointer hProcess, cpointer dwMinimumWorkingSetSize, cpointer dwMaximumWorkingSetSize, int Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool VirtualLock(cpointer lpAddress, cpointer dwSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool VirtualUnlock(cpointer lpAddress, cpointer dwSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetWriteWatch(int dwFlags, cpointer lpBaseAddress, cpointer dwRegionSize, cpointer lpAddresses, cpointer unfoundType_ULONG_PTR_lpdwCount, cpointer unfoundType_LPDWORD_lpdwGranularity);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint ResetWriteWatch(cpointer lpBaseAddress, cpointer dwRegionSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateMemoryResourceNotification(cpointer unfoundType_MEMORY_RESOURCE_NOTIFICATION_TYPE_NotificationType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryMemoryResourceNotification(cpointer ResourceNotificationHandle, cpointer ResourceState);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetSystemFileCacheSize(cpointer unfoundType_PSIZE_T_lpMinimumFileCacheSize, cpointer unfoundType_PSIZE_T_lpMaximumFileCacheSize, cpointer unfoundType_PDWORD_lpFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetSystemFileCacheSize(cpointer MinimumFileCacheSize, cpointer MaximumFileCacheSize, int Flags);
    [DllImport(lib, EntryPoint = "CreateFileMappingNumaW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateFileMappingNuma(cpointer hFile, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpFileMappingAttributes, int flProtect, int dwMaximumSizeHigh, int dwMaximumSizeLow, [MarshalAs(UnmanagedType.LPWStr)] string lpName, int nndPreferred);
    [DllImport(lib, EntryPoint = "CreateFileMappingNumaW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateFileMappingNuma(cpointer hFile, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpFileMappingAttributes, int flProtect, int dwMaximumSizeHigh, int dwMaximumSizeLow, char* lpName, int nndPreferred);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateFileMappingNumaW(cpointer hFile, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpFileMappingAttributes, int flProtect, int dwMaximumSizeHigh, int dwMaximumSizeLow, [MarshalAs(UnmanagedType.LPWStr)] string lpName, int nndPreferred);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateFileMappingNumaW(cpointer hFile, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpFileMappingAttributes, int flProtect, int dwMaximumSizeHigh, int dwMaximumSizeLow, char* lpName, int nndPreferred);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool PrefetchVirtualMemory(cpointer hProcess, cpointer unfoundType_ULONG_PTR_NumberOfEntries, cpointer unfoundType_PWIN32_MEMORY_RANGE_ENTRY_VirtualAddresses, uint Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateFileMappingFromApp(cpointer hFile, cpointer unfoundType_PSECURITY_ATTRIBUTES_SecurityAttributes, uint PageProtection, cpointer unfoundType_ULONG64_MaximumSize, [MarshalAs(UnmanagedType.LPWStr)] string Name);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateFileMappingFromApp(cpointer hFile, cpointer unfoundType_PSECURITY_ATTRIBUTES_SecurityAttributes, uint PageProtection, cpointer unfoundType_ULONG64_MaximumSize, char* Name);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer MapViewOfFileFromApp(cpointer hFileMappingObject, uint DesiredAccess, cpointer unfoundType_ULONG64_FileOffset, cpointer NumberOfBytesToMap);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UnmapViewOfFileEx(cpointer BaseAddress, uint UnmapFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AllocateUserPhysicalPages(cpointer hProcess, cpointer NumberOfPages, cpointer PageArray);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FreeUserPhysicalPages(cpointer hProcess, cpointer NumberOfPages, cpointer PageArray);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MapUserPhysicalPages(cpointer VirtualAddress, cpointer unfoundType_ULONG_PTR_NumberOfPages, cpointer PageArray);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AllocateUserPhysicalPagesNuma(cpointer hProcess, cpointer NumberOfPages, cpointer PageArray, int nndPreferred);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer VirtualAllocExNuma(cpointer hProcess, cpointer lpAddress, cpointer dwSize, int flAllocationType, int flProtect, int nndPreferred);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetMemoryErrorHandlingCapabilities(cpointer unfoundType_PULONG_Capabilities);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegisterBadMemoryNotification(cpointer unfoundType_PBAD_MEMORY_CALLBACK_ROUTINE_Callback);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UnregisterBadMemoryNotification(cpointer RegistrationHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int OfferVirtualMemory(cpointer VirtualAddress, cpointer Size, cpointer unfoundType_OFFER_PRIORITY_Priority);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ReclaimVirtualMemory(cpointer VirtualAddress, cpointer Size);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int DiscardVirtualMemory(cpointer VirtualAddress, cpointer Size);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsEnclaveTypeSupported(int flEnclaveType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateEnclave(cpointer hProcess, cpointer lpAddress, cpointer dwSize, cpointer dwInitialCommitment, int flEnclaveType, cpointer lpEnclaveInformation, int dwInfoLength, cpointer unfoundType_LPDWORD_lpEnclaveError);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool LoadEnclaveData(cpointer hProcess, cpointer lpAddress, cpointer lpBuffer, cpointer nSize, int flProtect, cpointer lpPageInformation, int dwInfoLength, cpointer unfoundType_PSIZE_T_lpNumberOfBytesWritten, cpointer unfoundType_LPDWORD_lpEnclaveError);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool InitializeEnclave(cpointer hProcess, cpointer lpAddress, cpointer lpEnclaveInformation, int dwInfoLength, cpointer unfoundType_LPDWORD_lpEnclaveError);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void RaiseException(int dwExceptionCode, int dwExceptionFlags, int nNumberOfArguments, cpointer unfoundType_ULONG_PTR_lpArguments);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int UnhandledExceptionFilter(cpointer unfoundType__EXCEPTION_POINTERS_ExceptionInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer SetUnhandledExceptionFilter(cpointer unfoundType_LPTOP_LEVEL_EXCEPTION_FILTER_lpTopLevelExceptionFilter);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLastError();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void SetLastError(int dwErrCode);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetErrorMode();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint SetErrorMode(uint uMode);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer AddVectoredExceptionHandler(uint First, cpointer unfoundType_PVECTORED_EXCEPTION_HANDLER_Handler);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint RemoveVectoredExceptionHandler(cpointer Handle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer AddVectoredContinueHandler(uint First, cpointer unfoundType_PVECTORED_EXCEPTION_HANDLER_Handler);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint RemoveVectoredContinueHandler(cpointer Handle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void RestoreLastError(int dwErrCode);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void RaiseFailFastException(cpointer unfoundType_PEXCEPTION_RECORD_pExceptionRecord, cpointer unfoundType_PCONTEXT_pContextRecord, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void FatalAppExitA(uint uAction, [MarshalAs(UnmanagedType.LPStr)] string lpMessageText);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void FatalAppExitA(uint uAction, byte* lpMessageText);
    [DllImport(lib, EntryPoint = "FatalAppExitW", SetLastError = true, ExactSpelling = true)]
    public static extern
        void FatalAppExit(uint uAction, [MarshalAs(UnmanagedType.LPWStr)] string lpMessageText);
    [DllImport(lib, EntryPoint = "FatalAppExitW", SetLastError = true, ExactSpelling = true)]
    public static extern
        void FatalAppExit(uint uAction, char* lpMessageText);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void FatalAppExitW(uint uAction, [MarshalAs(UnmanagedType.LPWStr)] string lpMessageText);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void FatalAppExitW(uint uAction, char* lpMessageText);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetThreadErrorMode();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetThreadErrorMode(int dwNewMode, cpointer unfoundType_LPDWORD_lpOldMode);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void InitializeSListHead(cpointer unfoundType_PSLIST_HEADER_ListHead);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer InterlockedPopEntrySList(cpointer unfoundType_PSLIST_HEADER_ListHead);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer InterlockedPushEntrySList(cpointer unfoundType_PSLIST_HEADER_ListHead, cpointer unfoundType_PSLIST_ENTRY_ListEntry);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer InterlockedPushListSListEx(cpointer unfoundType_PSLIST_HEADER_ListHead, cpointer unfoundType_PSLIST_ENTRY_List, cpointer unfoundType_PSLIST_ENTRY_ListEnd, uint Count);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer InterlockedFlushSList(cpointer unfoundType_PSLIST_HEADER_ListHead);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ushort QueryDepthSList(cpointer unfoundType_PSLIST_HEADER_ListHead);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateIoCompletionPort(cpointer FileHandle, cpointer ExistingCompletionPort, cpointer unfoundType_ULONG_PTR_CompletionKey, int NumberOfConcurrentThreads);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetQueuedCompletionStatus(cpointer CompletionPort, cpointer unfoundType_LPDWORD_lpNumberOfBytesTransferred, cpointer lpCompletionKey, cpointer unfoundType_LPOVERLAPPED_lpOverlapped, int dwMilliseconds);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetQueuedCompletionStatusEx(cpointer CompletionPort, cpointer unfoundType_LPOVERLAPPED_ENTRY_lpCompletionPortEntries, uint ulCount, cpointer unfoundType_PULONG_ulNumEntriesRemoved, int dwMilliseconds, bool fAlertable);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool PostQueuedCompletionStatus(cpointer CompletionPort, int dwNumberOfBytesTransferred, cpointer unfoundType_ULONG_PTR_dwCompletionKey, cpointer unfoundType_LPOVERLAPPED_lpOverlapped);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DeviceIoControl(cpointer hDevice, int dwIoControlCode, cpointer lpInBuffer, int nInBufferSize, cpointer lpOutBuffer, int nOutBufferSize, cpointer unfoundType_LPDWORD_lpBytesReturned, cpointer unfoundType_LPOVERLAPPED_lpOverlapped);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetOverlappedResult(cpointer hFile, cpointer unfoundType_LPOVERLAPPED_lpOverlapped, cpointer unfoundType_LPDWORD_lpNumberOfBytesTransferred, bool bWait);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CancelIoEx(cpointer hFile, cpointer unfoundType_LPOVERLAPPED_lpOverlapped);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CancelIo(cpointer hFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetOverlappedResultEx(cpointer hFile, cpointer unfoundType_LPOVERLAPPED_lpOverlapped, cpointer unfoundType_LPDWORD_lpNumberOfBytesTransferred, int dwMilliseconds, bool bAlertable);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CancelSynchronousIo(cpointer hThread);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateIoRing(cpointer unfoundType_IORING_VERSION_ioringVersion, cpointer unfoundType_IORING_CREATE_FLAGS_flags, uint submissionQueueSize, uint completionQueueSize, cpointer unfoundType_HIORING_h);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer BuildIoRingReadFile(cpointer unfoundType_HIORING_ioRing, cpointer unfoundType_IORING_HANDLE_REF_fileRef, cpointer unfoundType_IORING_BUFFER_REF_dataRef, uint numberOfBytesToRead, cpointer unfoundType_UINT64_fileOffset, ulong userData, cpointer unfoundType_IORING_SQE_FLAGS_sqeFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer BuildIoRingRegisterFileHandles(cpointer unfoundType_HIORING_ioRing, uint count, cpointer handles, ulong userData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer BuildIoRingRegisterBuffers(cpointer unfoundType_HIORING_ioRing, uint count, cpointer unfoundType_IORING_BUFFER_INFO_buffers, ulong userData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer BuildIoRingWriteFile(cpointer unfoundType_HIORING_ioRing, cpointer unfoundType_IORING_HANDLE_REF_fileRef, cpointer unfoundType_IORING_BUFFER_REF_bufferRef, uint numberOfBytesToWrite, cpointer unfoundType_UINT64_fileOffset, cpointer unfoundType_FILE_WRITE_FLAGS_writeFlags, ulong userData, cpointer unfoundType_IORING_SQE_FLAGS_sqeFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer BuildIoRingFlushFile(cpointer unfoundType_HIORING_ioRing, cpointer unfoundType_IORING_HANDLE_REF_fileRef, cpointer unfoundType_FILE_FLUSH_MODE_flushMode, ulong userData, cpointer unfoundType_IORING_SQE_FLAGS_sqeFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CloseHandle(cpointer hObject);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DuplicateHandle(cpointer hSourceProcessHandle, cpointer hSourceHandle, cpointer hTargetProcessHandle, cpointer unfoundType_LPHANDLE_lpTargetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetHandleInformation(cpointer hObject, cpointer unfoundType_LPDWORD_lpdwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetHandleInformation(cpointer hObject, int dwMask, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer HeapCreate(int flOptions, cpointer dwInitialSize, cpointer dwMaximumSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool HeapDestroy(cpointer hHeap);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer HeapAlloc(cpointer hHeap, int dwFlags, cpointer dwBytes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer HeapReAlloc(cpointer hHeap, int dwFlags, cpointer lpMem, cpointer dwBytes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool HeapFree(cpointer hHeap, int dwFlags, cpointer lpMem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint* HeapSize(cpointer hHeap, int dwFlags, cpointer lpMem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetProcessHeap();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint* HeapCompact(cpointer hHeap, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool HeapSetInformation(cpointer HeapHandle, cpointer unfoundType_HEAP_INFORMATION_CLASS_HeapInformationClass, cpointer HeapInformation, cpointer HeapInformationLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool HeapValidate(cpointer hHeap, int dwFlags, cpointer lpMem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool HeapSummary(cpointer hHeap, int dwFlags, cpointer unfoundType_LPHEAP_SUMMARY_lpSummary);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProcessHeaps(int NumberOfHeaps, cpointer unfoundType_PHANDLE_ProcessHeaps);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool HeapLock(cpointer hHeap);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool HeapUnlock(cpointer hHeap);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool HeapWalk(cpointer hHeap, cpointer unfoundType_LPPROCESS_HEAP_ENTRY_lpEntry);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool HeapQueryInformation(cpointer HeapHandle, cpointer unfoundType_HEAP_INFORMATION_CLASS_HeapInformationClass, cpointer HeapInformation, cpointer HeapInformationLength, cpointer unfoundType_PSIZE_T_ReturnLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsProcessInJob(cpointer ProcessHandle, cpointer JobHandle, cpointer Result);
    [DllImport(lib, EntryPoint = "CreateJobObjectW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateJobObject(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpJobAttributes, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport(lib, EntryPoint = "CreateJobObjectW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateJobObject(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpJobAttributes, char* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateJobObjectW(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpJobAttributes, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateJobObjectW(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpJobAttributes, char* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void FreeMemoryJobObject(cpointer Buffer);
    [DllImport(lib, EntryPoint = "OpenJobObjectW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenJobObject(int dwDesiredAccess, bool bInheritHandle, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport(lib, EntryPoint = "OpenJobObjectW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenJobObject(int dwDesiredAccess, bool bInheritHandle, char* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenJobObjectW(int dwDesiredAccess, bool bInheritHandle, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenJobObjectW(int dwDesiredAccess, bool bInheritHandle, char* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AssignProcessToJobObject(cpointer hJob, cpointer hProcess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool TerminateJobObject(cpointer hJob, uint uExitCode);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetInformationJobObject(cpointer hJob, cpointer unfoundType_JOBOBJECTINFOCLASS_JobObjectInformationClass, cpointer lpJobObjectInformation, int cbJobObjectInformationLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SetIoRateControlInformationJobObject(cpointer hJob, cpointer unfoundType_JOBOBJECT_IO_RATE_CONTROL_INFORMATION_IoRateControlInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryInformationJobObject(cpointer hJob, cpointer unfoundType_JOBOBJECTINFOCLASS_JobObjectInformationClass, cpointer lpJobObjectInformation, int cbJobObjectInformationLength, cpointer unfoundType_LPDWORD_lpReturnLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int QueryIoRateControlInformationJobObject(cpointer hJob, [MarshalAs(UnmanagedType.LPWStr)] string VolumeName, cpointer unfoundType_JOBOBJECT_IO_RATE_CONTROL_INFORMATION_InfoBlocks, cpointer InfoBlockCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int QueryIoRateControlInformationJobObject(cpointer hJob, char* VolumeName, cpointer unfoundType_JOBOBJECT_IO_RATE_CONTROL_INFORMATION_InfoBlocks, cpointer InfoBlockCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DisableThreadLibraryCalls(cpointer unfoundType_HMODULE_hLibModule);
    [DllImport(lib, EntryPoint = "FindResourceExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindResourceEx(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, short wLanguage);
    [DllImport(lib, EntryPoint = "FindResourceExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindResourceEx(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, char* lpName, short wLanguage);
    [DllImport(lib, EntryPoint = "FindResourceExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindResourceEx(cpointer unfoundType_HMODULE_hModule, char* lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, short wLanguage);
    [DllImport(lib, EntryPoint = "FindResourceExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindResourceEx(cpointer unfoundType_HMODULE_hModule, char* lpType, char* lpName, short wLanguage);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindResourceExW(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, short wLanguage);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindResourceExW(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, char* lpName, short wLanguage);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindResourceExW(cpointer unfoundType_HMODULE_hModule, char* lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, short wLanguage);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindResourceExW(cpointer unfoundType_HMODULE_hModule, char* lpType, char* lpName, short wLanguage);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FindStringOrdinal(int dwFindStringOrdinalFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpStringSource, int cchSource, [MarshalAs(UnmanagedType.LPWStr)] string lpStringValue, int cchValue, bool bIgnoreCase);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FindStringOrdinal(int dwFindStringOrdinalFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpStringSource, int cchSource, char* lpStringValue, int cchValue, bool bIgnoreCase);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FindStringOrdinal(int dwFindStringOrdinalFlags, char* lpStringSource, int cchSource, [MarshalAs(UnmanagedType.LPWStr)] string lpStringValue, int cchValue, bool bIgnoreCase);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FindStringOrdinal(int dwFindStringOrdinalFlags, char* lpStringSource, int cchSource, char* lpStringValue, int cchValue, bool bIgnoreCase);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FreeLibrary(cpointer unfoundType_HMODULE_hLibModule);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void FreeLibraryAndExitThread(cpointer unfoundType_HMODULE_hLibModule, int dwExitCode);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FreeResource(cpointer unfoundType_HGLOBAL_hResData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetModuleFileNameA(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPStr)] string lpFilename, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetModuleFileNameA(cpointer unfoundType_HMODULE_hModule, ReadOnlySpan<byte> lpFilename, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetModuleFileNameA(cpointer unfoundType_HMODULE_hModule, byte* lpFilename, int nSize);
    [DllImport(lib, EntryPoint = "GetModuleFileNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetModuleFileName(cpointer unfoundType_HMODULE_hModule, string lpFilename, int nSize);
    [DllImport(lib, EntryPoint = "GetModuleFileNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetModuleFileName(cpointer unfoundType_HMODULE_hModule, char* lpFilename, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetModuleFileNameW(cpointer unfoundType_HMODULE_hModule, string lpFilename, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetModuleFileNameW(cpointer unfoundType_HMODULE_hModule, char* lpFilename, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetModuleHandleA([MarshalAs(UnmanagedType.LPStr)] string lpModuleName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetModuleHandleA(byte* lpModuleName);
    [DllImport(lib, EntryPoint = "GetModuleHandleW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetModuleHandle([MarshalAs(UnmanagedType.LPWStr)] string lpModuleName);
    [DllImport(lib, EntryPoint = "GetModuleHandleW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetModuleHandle(char* lpModuleName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetModuleHandleW([MarshalAs(UnmanagedType.LPWStr)] string lpModuleName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetModuleHandleW(char* lpModuleName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetModuleHandleExA(int dwFlags, [MarshalAs(UnmanagedType.LPStr)] string lpModuleName, cpointer unfoundType_HMODULE_phModule);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetModuleHandleExA(int dwFlags, byte* lpModuleName, cpointer unfoundType_HMODULE_phModule);
    [DllImport(lib, EntryPoint = "GetModuleHandleExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetModuleHandleEx(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpModuleName, cpointer unfoundType_HMODULE_phModule);
    [DllImport(lib, EntryPoint = "GetModuleHandleExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetModuleHandleEx(int dwFlags, char* lpModuleName, cpointer unfoundType_HMODULE_phModule);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetModuleHandleExW(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpModuleName, cpointer unfoundType_HMODULE_phModule);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetModuleHandleExW(int dwFlags, char* lpModuleName, cpointer unfoundType_HMODULE_phModule);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetProcAddress(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPStr)] string lpProcName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetProcAddress(cpointer unfoundType_HMODULE_hModule, byte* lpProcName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer LoadLibraryExA([MarshalAs(UnmanagedType.LPStr)] string lpLibFileName, cpointer hFile, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer LoadLibraryExA(byte* lpLibFileName, cpointer hFile, int dwFlags);
    [DllImport(lib, EntryPoint = "LoadLibraryExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer LoadLibraryEx([MarshalAs(UnmanagedType.LPWStr)] string lpLibFileName, cpointer hFile, int dwFlags);
    [DllImport(lib, EntryPoint = "LoadLibraryExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer LoadLibraryEx(char* lpLibFileName, cpointer hFile, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer LoadLibraryExW([MarshalAs(UnmanagedType.LPWStr)] string lpLibFileName, cpointer hFile, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer LoadLibraryExW(char* lpLibFileName, cpointer hFile, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer LoadResource(cpointer unfoundType_HMODULE_hModule, cpointer unfoundType_HRSRC_hResInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer LockResource(cpointer unfoundType_HGLOBAL_hResData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SizeofResource(cpointer unfoundType_HMODULE_hModule, cpointer unfoundType_HRSRC_hResInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer AddDllDirectory([MarshalAs(UnmanagedType.LPWStr)] string NewDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer AddDllDirectory(char* NewDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool RemoveDllDirectory(cpointer unfoundType_DLL_DIRECTORY_COOKIE_Cookie);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetDefaultDllDirectories(int DirectoryFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguagesExA(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPStr)] string lpType, [MarshalAs(UnmanagedType.LPStr)] string lpName, cpointer unfoundType_ENUMRESLANGPROCA_lpEnumFunc, long lParam, int dwFlags, cpointer unfoundType_LANGID_LangId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguagesExA(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPStr)] string lpType, byte* lpName, cpointer unfoundType_ENUMRESLANGPROCA_lpEnumFunc, long lParam, int dwFlags, cpointer unfoundType_LANGID_LangId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguagesExA(cpointer unfoundType_HMODULE_hModule, byte* lpType, [MarshalAs(UnmanagedType.LPStr)] string lpName, cpointer unfoundType_ENUMRESLANGPROCA_lpEnumFunc, long lParam, int dwFlags, cpointer unfoundType_LANGID_LangId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguagesExA(cpointer unfoundType_HMODULE_hModule, byte* lpType, byte* lpName, cpointer unfoundType_ENUMRESLANGPROCA_lpEnumFunc, long lParam, int dwFlags, cpointer unfoundType_LANGID_LangId);
    [DllImport(lib, EntryPoint = "EnumResourceLanguagesExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguagesEx(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, cpointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam, int dwFlags, cpointer unfoundType_LANGID_LangId);
    [DllImport(lib, EntryPoint = "EnumResourceLanguagesExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguagesEx(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, char* lpName, cpointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam, int dwFlags, cpointer unfoundType_LANGID_LangId);
    [DllImport(lib, EntryPoint = "EnumResourceLanguagesExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguagesEx(cpointer unfoundType_HMODULE_hModule, char* lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, cpointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam, int dwFlags, cpointer unfoundType_LANGID_LangId);
    [DllImport(lib, EntryPoint = "EnumResourceLanguagesExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguagesEx(cpointer unfoundType_HMODULE_hModule, char* lpType, char* lpName, cpointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam, int dwFlags, cpointer unfoundType_LANGID_LangId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguagesExW(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, cpointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam, int dwFlags, cpointer unfoundType_LANGID_LangId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguagesExW(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, char* lpName, cpointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam, int dwFlags, cpointer unfoundType_LANGID_LangId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguagesExW(cpointer unfoundType_HMODULE_hModule, char* lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, cpointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam, int dwFlags, cpointer unfoundType_LANGID_LangId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguagesExW(cpointer unfoundType_HMODULE_hModule, char* lpType, char* lpName, cpointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam, int dwFlags, cpointer unfoundType_LANGID_LangId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceNamesExA(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPStr)] string lpType, cpointer unfoundType_ENUMRESNAMEPROCA_lpEnumFunc, long lParam, int dwFlags, cpointer unfoundType_LANGID_LangId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceNamesExA(cpointer unfoundType_HMODULE_hModule, byte* lpType, cpointer unfoundType_ENUMRESNAMEPROCA_lpEnumFunc, long lParam, int dwFlags, cpointer unfoundType_LANGID_LangId);
    [DllImport(lib, EntryPoint = "EnumResourceNamesExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceNamesEx(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, cpointer unfoundType_ENUMRESNAMEPROCW_lpEnumFunc, long lParam, int dwFlags, cpointer unfoundType_LANGID_LangId);
    [DllImport(lib, EntryPoint = "EnumResourceNamesExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceNamesEx(cpointer unfoundType_HMODULE_hModule, char* lpType, cpointer unfoundType_ENUMRESNAMEPROCW_lpEnumFunc, long lParam, int dwFlags, cpointer unfoundType_LANGID_LangId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceNamesExW(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, cpointer unfoundType_ENUMRESNAMEPROCW_lpEnumFunc, long lParam, int dwFlags, cpointer unfoundType_LANGID_LangId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceNamesExW(cpointer unfoundType_HMODULE_hModule, char* lpType, cpointer unfoundType_ENUMRESNAMEPROCW_lpEnumFunc, long lParam, int dwFlags, cpointer unfoundType_LANGID_LangId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceTypesExA(cpointer unfoundType_HMODULE_hModule, cpointer unfoundType_ENUMRESTYPEPROCA_lpEnumFunc, long lParam, int dwFlags, cpointer unfoundType_LANGID_LangId);
    [DllImport(lib, EntryPoint = "EnumResourceTypesExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceTypesEx(cpointer unfoundType_HMODULE_hModule, cpointer unfoundType_ENUMRESTYPEPROCW_lpEnumFunc, long lParam, int dwFlags, cpointer unfoundType_LANGID_LangId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceTypesExW(cpointer unfoundType_HMODULE_hModule, cpointer unfoundType_ENUMRESTYPEPROCW_lpEnumFunc, long lParam, int dwFlags, cpointer unfoundType_LANGID_LangId);
    [DllImport(lib, EntryPoint = "FindResourceW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindResource(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpType);
    [DllImport(lib, EntryPoint = "FindResourceW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindResource(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpName, char* lpType);
    [DllImport(lib, EntryPoint = "FindResourceW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindResource(cpointer unfoundType_HMODULE_hModule, char* lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpType);
    [DllImport(lib, EntryPoint = "FindResourceW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindResource(cpointer unfoundType_HMODULE_hModule, char* lpName, char* lpType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindResourceW(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindResourceW(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpName, char* lpType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindResourceW(cpointer unfoundType_HMODULE_hModule, char* lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindResourceW(cpointer unfoundType_HMODULE_hModule, char* lpName, char* lpType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer LoadLibraryA([MarshalAs(UnmanagedType.LPStr)] string lpLibFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer LoadLibraryA(byte* lpLibFileName);
    [DllImport(lib, EntryPoint = "LoadLibraryW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer LoadLibrary([MarshalAs(UnmanagedType.LPWStr)] string lpLibFileName);
    [DllImport(lib, EntryPoint = "LoadLibraryW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer LoadLibrary(char* lpLibFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer LoadLibraryW([MarshalAs(UnmanagedType.LPWStr)] string lpLibFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer LoadLibraryW(char* lpLibFileName);
    [DllImport(lib, EntryPoint = "EnumResourceNamesW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceNames(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, cpointer unfoundType_ENUMRESNAMEPROCW_lpEnumFunc, long lParam);
    [DllImport(lib, EntryPoint = "EnumResourceNamesW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceNames(cpointer unfoundType_HMODULE_hModule, char* lpType, cpointer unfoundType_ENUMRESNAMEPROCW_lpEnumFunc, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceNamesW(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, cpointer unfoundType_ENUMRESNAMEPROCW_lpEnumFunc, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceNamesW(cpointer unfoundType_HMODULE_hModule, char* lpType, cpointer unfoundType_ENUMRESNAMEPROCW_lpEnumFunc, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceNamesA(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPStr)] string lpType, cpointer unfoundType_ENUMRESNAMEPROCA_lpEnumFunc, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceNamesA(cpointer unfoundType_HMODULE_hModule, byte* lpType, cpointer unfoundType_ENUMRESNAMEPROCA_lpEnumFunc, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer LoadPackagedLibrary([MarshalAs(UnmanagedType.LPWStr)] string lpwLibFileName, int Reserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer LoadPackagedLibrary(char* lpwLibFileName, int Reserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FlsAlloc(cpointer unfoundType_PFLS_CALLBACK_FUNCTION_lpCallback);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FlsGetValue(int dwFlsIndex);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FlsSetValue(int dwFlsIndex, cpointer lpFlsData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FlsFree(int dwFlsIndex);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsThreadAFiber();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CompareFileTime(cpointer unfoundType_FILETIME_lpFileTime1, cpointer unfoundType_FILETIME_lpFileTime2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryA([MarshalAs(UnmanagedType.LPStr)] string lpPathName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryA(byte* lpPathName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, EntryPoint = "CreateDirectoryW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectory([MarshalAs(UnmanagedType.LPWStr)] string lpPathName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, EntryPoint = "CreateDirectoryW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectory(char* lpPathName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryW([MarshalAs(UnmanagedType.LPWStr)] string lpPathName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryW(char* lpPathName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateFileA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, int dwDesiredAccess, int dwShareMode, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, cpointer hTemplateFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateFileA(byte* lpFileName, int dwDesiredAccess, int dwShareMode, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, cpointer hTemplateFile);
    [DllImport(lib, EntryPoint = "CreateFileW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateFile([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwDesiredAccess, int dwShareMode, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, cpointer hTemplateFile);
    [DllImport(lib, EntryPoint = "CreateFileW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateFile(char* lpFileName, int dwDesiredAccess, int dwShareMode, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, cpointer hTemplateFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateFileW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwDesiredAccess, int dwShareMode, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, cpointer hTemplateFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateFileW(char* lpFileName, int dwDesiredAccess, int dwShareMode, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, cpointer hTemplateFile);
    [DllImport(lib, EntryPoint = "DefineDosDeviceW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DefineDosDevice(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpDeviceName, [MarshalAs(UnmanagedType.LPWStr)] string lpTargetPath);
    [DllImport(lib, EntryPoint = "DefineDosDeviceW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DefineDosDevice(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpDeviceName, char* lpTargetPath);
    [DllImport(lib, EntryPoint = "DefineDosDeviceW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DefineDosDevice(int dwFlags, char* lpDeviceName, [MarshalAs(UnmanagedType.LPWStr)] string lpTargetPath);
    [DllImport(lib, EntryPoint = "DefineDosDeviceW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DefineDosDevice(int dwFlags, char* lpDeviceName, char* lpTargetPath);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DefineDosDeviceW(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpDeviceName, [MarshalAs(UnmanagedType.LPWStr)] string lpTargetPath);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DefineDosDeviceW(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpDeviceName, char* lpTargetPath);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DefineDosDeviceW(int dwFlags, char* lpDeviceName, [MarshalAs(UnmanagedType.LPWStr)] string lpTargetPath);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DefineDosDeviceW(int dwFlags, char* lpDeviceName, char* lpTargetPath);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DeleteFileA([MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DeleteFileA(byte* lpFileName);
    [DllImport(lib, EntryPoint = "DeleteFileW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DeleteFile([MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, EntryPoint = "DeleteFileW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DeleteFile(char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DeleteFileW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DeleteFileW(char* lpFileName);
    [DllImport(lib, EntryPoint = "DeleteVolumeMountPointW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DeleteVolumeMountPoint([MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeMountPoint);
    [DllImport(lib, EntryPoint = "DeleteVolumeMountPointW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DeleteVolumeMountPoint(char* lpszVolumeMountPoint);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DeleteVolumeMountPointW([MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeMountPoint);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DeleteVolumeMountPointW(char* lpszVolumeMountPoint);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FileTimeToLocalFileTime(cpointer unfoundType_FILETIME_lpFileTime, cpointer unfoundType_LPFILETIME_lpLocalFileTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindClose(cpointer hFindFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindCloseChangeNotification(cpointer hChangeHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstChangeNotificationA([MarshalAs(UnmanagedType.LPStr)] string lpPathName, bool bWatchSubtree, int dwNotifyFilter);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstChangeNotificationA(byte* lpPathName, bool bWatchSubtree, int dwNotifyFilter);
    [DllImport(lib, EntryPoint = "FindFirstChangeNotificationW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstChangeNotification([MarshalAs(UnmanagedType.LPWStr)] string lpPathName, bool bWatchSubtree, int dwNotifyFilter);
    [DllImport(lib, EntryPoint = "FindFirstChangeNotificationW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstChangeNotification(char* lpPathName, bool bWatchSubtree, int dwNotifyFilter);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstChangeNotificationW([MarshalAs(UnmanagedType.LPWStr)] string lpPathName, bool bWatchSubtree, int dwNotifyFilter);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstChangeNotificationW(char* lpPathName, bool bWatchSubtree, int dwNotifyFilter);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstFileA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, cpointer unfoundType_LPWIN32_FIND_DATAA_lpFindFileData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstFileA(byte* lpFileName, cpointer unfoundType_LPWIN32_FIND_DATAA_lpFindFileData);
    [DllImport(lib, EntryPoint = "FindFirstFileW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstFile([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, cpointer unfoundType_LPWIN32_FIND_DATAW_lpFindFileData);
    [DllImport(lib, EntryPoint = "FindFirstFileW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstFile(char* lpFileName, cpointer unfoundType_LPWIN32_FIND_DATAW_lpFindFileData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstFileW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, cpointer unfoundType_LPWIN32_FIND_DATAW_lpFindFileData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstFileW(char* lpFileName, cpointer unfoundType_LPWIN32_FIND_DATAW_lpFindFileData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstFileExA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, cpointer unfoundType_FINDEX_INFO_LEVELS_fInfoLevelId, cpointer lpFindFileData, cpointer unfoundType_FINDEX_SEARCH_OPS_fSearchOp, cpointer lpSearchFilter, int dwAdditionalFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstFileExA(byte* lpFileName, cpointer unfoundType_FINDEX_INFO_LEVELS_fInfoLevelId, cpointer lpFindFileData, cpointer unfoundType_FINDEX_SEARCH_OPS_fSearchOp, cpointer lpSearchFilter, int dwAdditionalFlags);
    [DllImport(lib, EntryPoint = "FindFirstFileExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstFileEx([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, cpointer unfoundType_FINDEX_INFO_LEVELS_fInfoLevelId, cpointer lpFindFileData, cpointer unfoundType_FINDEX_SEARCH_OPS_fSearchOp, cpointer lpSearchFilter, int dwAdditionalFlags);
    [DllImport(lib, EntryPoint = "FindFirstFileExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstFileEx(char* lpFileName, cpointer unfoundType_FINDEX_INFO_LEVELS_fInfoLevelId, cpointer lpFindFileData, cpointer unfoundType_FINDEX_SEARCH_OPS_fSearchOp, cpointer lpSearchFilter, int dwAdditionalFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstFileExW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, cpointer unfoundType_FINDEX_INFO_LEVELS_fInfoLevelId, cpointer lpFindFileData, cpointer unfoundType_FINDEX_SEARCH_OPS_fSearchOp, cpointer lpSearchFilter, int dwAdditionalFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstFileExW(char* lpFileName, cpointer unfoundType_FINDEX_INFO_LEVELS_fInfoLevelId, cpointer lpFindFileData, cpointer unfoundType_FINDEX_SEARCH_OPS_fSearchOp, cpointer lpSearchFilter, int dwAdditionalFlags);
    [DllImport(lib, EntryPoint = "FindFirstVolumeW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstVolume(string lpszVolumeName, int cchBufferLength);
    [DllImport(lib, EntryPoint = "FindFirstVolumeW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstVolume(char* lpszVolumeName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstVolumeW(string lpszVolumeName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstVolumeW(char* lpszVolumeName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextChangeNotification(cpointer hChangeHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextFileA(cpointer hFindFile, cpointer unfoundType_LPWIN32_FIND_DATAA_lpFindFileData);
    [DllImport(lib, EntryPoint = "FindNextFileW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextFile(cpointer hFindFile, cpointer unfoundType_LPWIN32_FIND_DATAW_lpFindFileData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextFileW(cpointer hFindFile, cpointer unfoundType_LPWIN32_FIND_DATAW_lpFindFileData);
    [DllImport(lib, EntryPoint = "FindNextVolumeW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextVolume(cpointer hFindVolume, string lpszVolumeName, int cchBufferLength);
    [DllImport(lib, EntryPoint = "FindNextVolumeW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextVolume(cpointer hFindVolume, char* lpszVolumeName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextVolumeW(cpointer hFindVolume, string lpszVolumeName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextVolumeW(cpointer hFindVolume, char* lpszVolumeName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindVolumeClose(cpointer hFindVolume);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FlushFileBuffers(cpointer hFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetDiskFreeSpaceA([MarshalAs(UnmanagedType.LPStr)] string lpRootPathName, cpointer unfoundType_LPDWORD_lpSectorsPerCluster, cpointer unfoundType_LPDWORD_lpBytesPerSector, cpointer unfoundType_LPDWORD_lpNumberOfFreeClusters, cpointer unfoundType_LPDWORD_lpTotalNumberOfClusters);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetDiskFreeSpaceA(byte* lpRootPathName, cpointer unfoundType_LPDWORD_lpSectorsPerCluster, cpointer unfoundType_LPDWORD_lpBytesPerSector, cpointer unfoundType_LPDWORD_lpNumberOfFreeClusters, cpointer unfoundType_LPDWORD_lpTotalNumberOfClusters);
    [DllImport(lib, EntryPoint = "GetDiskFreeSpaceW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetDiskFreeSpace([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, cpointer unfoundType_LPDWORD_lpSectorsPerCluster, cpointer unfoundType_LPDWORD_lpBytesPerSector, cpointer unfoundType_LPDWORD_lpNumberOfFreeClusters, cpointer unfoundType_LPDWORD_lpTotalNumberOfClusters);
    [DllImport(lib, EntryPoint = "GetDiskFreeSpaceW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetDiskFreeSpace(char* lpRootPathName, cpointer unfoundType_LPDWORD_lpSectorsPerCluster, cpointer unfoundType_LPDWORD_lpBytesPerSector, cpointer unfoundType_LPDWORD_lpNumberOfFreeClusters, cpointer unfoundType_LPDWORD_lpTotalNumberOfClusters);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetDiskFreeSpaceW([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, cpointer unfoundType_LPDWORD_lpSectorsPerCluster, cpointer unfoundType_LPDWORD_lpBytesPerSector, cpointer unfoundType_LPDWORD_lpNumberOfFreeClusters, cpointer unfoundType_LPDWORD_lpTotalNumberOfClusters);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetDiskFreeSpaceW(char* lpRootPathName, cpointer unfoundType_LPDWORD_lpSectorsPerCluster, cpointer unfoundType_LPDWORD_lpBytesPerSector, cpointer unfoundType_LPDWORD_lpNumberOfFreeClusters, cpointer unfoundType_LPDWORD_lpTotalNumberOfClusters);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetDiskFreeSpaceExA([MarshalAs(UnmanagedType.LPStr)] string lpDirectoryName, cpointer unfoundType_PULARGE_INTEGER_lpFreeBytesAvailableToCaller, cpointer unfoundType_PULARGE_INTEGER_lpTotalNumberOfBytes, cpointer unfoundType_PULARGE_INTEGER_lpTotalNumberOfFreeBytes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetDiskFreeSpaceExA(byte* lpDirectoryName, cpointer unfoundType_PULARGE_INTEGER_lpFreeBytesAvailableToCaller, cpointer unfoundType_PULARGE_INTEGER_lpTotalNumberOfBytes, cpointer unfoundType_PULARGE_INTEGER_lpTotalNumberOfFreeBytes);
    [DllImport(lib, EntryPoint = "GetDiskFreeSpaceExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetDiskFreeSpaceEx([MarshalAs(UnmanagedType.LPWStr)] string lpDirectoryName, cpointer unfoundType_PULARGE_INTEGER_lpFreeBytesAvailableToCaller, cpointer unfoundType_PULARGE_INTEGER_lpTotalNumberOfBytes, cpointer unfoundType_PULARGE_INTEGER_lpTotalNumberOfFreeBytes);
    [DllImport(lib, EntryPoint = "GetDiskFreeSpaceExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetDiskFreeSpaceEx(char* lpDirectoryName, cpointer unfoundType_PULARGE_INTEGER_lpFreeBytesAvailableToCaller, cpointer unfoundType_PULARGE_INTEGER_lpTotalNumberOfBytes, cpointer unfoundType_PULARGE_INTEGER_lpTotalNumberOfFreeBytes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetDiskFreeSpaceExW([MarshalAs(UnmanagedType.LPWStr)] string lpDirectoryName, cpointer unfoundType_PULARGE_INTEGER_lpFreeBytesAvailableToCaller, cpointer unfoundType_PULARGE_INTEGER_lpTotalNumberOfBytes, cpointer unfoundType_PULARGE_INTEGER_lpTotalNumberOfFreeBytes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetDiskFreeSpaceExW(char* lpDirectoryName, cpointer unfoundType_PULARGE_INTEGER_lpFreeBytesAvailableToCaller, cpointer unfoundType_PULARGE_INTEGER_lpTotalNumberOfBytes, cpointer unfoundType_PULARGE_INTEGER_lpTotalNumberOfFreeBytes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetDiskSpaceInformationA([MarshalAs(UnmanagedType.LPStr)] string rootPath, cpointer unfoundType_DISK_SPACE_INFORMATION_diskSpaceInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetDiskSpaceInformationA(byte* rootPath, cpointer unfoundType_DISK_SPACE_INFORMATION_diskSpaceInfo);
    [DllImport(lib, EntryPoint = "GetDiskSpaceInformationW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetDiskSpaceInformation([MarshalAs(UnmanagedType.LPWStr)] string rootPath, cpointer unfoundType_DISK_SPACE_INFORMATION_diskSpaceInfo);
    [DllImport(lib, EntryPoint = "GetDiskSpaceInformationW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetDiskSpaceInformation(char* rootPath, cpointer unfoundType_DISK_SPACE_INFORMATION_diskSpaceInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetDiskSpaceInformationW([MarshalAs(UnmanagedType.LPWStr)] string rootPath, cpointer unfoundType_DISK_SPACE_INFORMATION_diskSpaceInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetDiskSpaceInformationW(char* rootPath, cpointer unfoundType_DISK_SPACE_INFORMATION_diskSpaceInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetDriveTypeA([MarshalAs(UnmanagedType.LPStr)] string lpRootPathName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetDriveTypeA(byte* lpRootPathName);
    [DllImport(lib, EntryPoint = "GetDriveTypeW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetDriveType([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName);
    [DllImport(lib, EntryPoint = "GetDriveTypeW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetDriveType(char* lpRootPathName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetDriveTypeW([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetDriveTypeW(char* lpRootPathName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFileAttributesA([MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFileAttributesA(byte* lpFileName);
    [DllImport(lib, EntryPoint = "GetFileAttributesW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFileAttributes([MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, EntryPoint = "GetFileAttributesW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFileAttributes(char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFileAttributesW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFileAttributesW(char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileAttributesExA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, cpointer unfoundType_GET_FILEEX_INFO_LEVELS_fInfoLevelId, cpointer lpFileInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileAttributesExA(byte* lpFileName, cpointer unfoundType_GET_FILEEX_INFO_LEVELS_fInfoLevelId, cpointer lpFileInformation);
    [DllImport(lib, EntryPoint = "GetFileAttributesExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileAttributesEx([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, cpointer unfoundType_GET_FILEEX_INFO_LEVELS_fInfoLevelId, cpointer lpFileInformation);
    [DllImport(lib, EntryPoint = "GetFileAttributesExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileAttributesEx(char* lpFileName, cpointer unfoundType_GET_FILEEX_INFO_LEVELS_fInfoLevelId, cpointer lpFileInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileAttributesExW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, cpointer unfoundType_GET_FILEEX_INFO_LEVELS_fInfoLevelId, cpointer lpFileInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileAttributesExW(char* lpFileName, cpointer unfoundType_GET_FILEEX_INFO_LEVELS_fInfoLevelId, cpointer lpFileInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileInformationByHandle(cpointer hFile, cpointer unfoundType_LPBY_HANDLE_FILE_INFORMATION_lpFileInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFileSize(cpointer hFile, cpointer unfoundType_LPDWORD_lpFileSizeHigh);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileSizeEx(cpointer hFile, cpointer unfoundType_PLARGE_INTEGER_lpFileSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFileType(cpointer hFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFinalPathNameByHandleA(cpointer hFile, [MarshalAs(UnmanagedType.LPStr)] string lpszFilePath, int cchFilePath, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFinalPathNameByHandleA(cpointer hFile, ReadOnlySpan<byte> lpszFilePath, int cchFilePath, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFinalPathNameByHandleA(cpointer hFile, byte* lpszFilePath, int cchFilePath, int dwFlags);
    [DllImport(lib, EntryPoint = "GetFinalPathNameByHandleW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFinalPathNameByHandle(cpointer hFile, string lpszFilePath, int cchFilePath, int dwFlags);
    [DllImport(lib, EntryPoint = "GetFinalPathNameByHandleW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFinalPathNameByHandle(cpointer hFile, char* lpszFilePath, int cchFilePath, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFinalPathNameByHandleW(cpointer hFile, string lpszFilePath, int cchFilePath, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFinalPathNameByHandleW(cpointer hFile, char* lpszFilePath, int cchFilePath, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileTime(cpointer hFile, cpointer unfoundType_LPFILETIME_lpCreationTime, cpointer unfoundType_LPFILETIME_lpLastAccessTime, cpointer unfoundType_LPFILETIME_lpLastWriteTime);
    [DllImport(lib, EntryPoint = "GetFullPathNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathName([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int nBufferLength, string lpBuffer, string lpFilePart);
    [DllImport(lib, EntryPoint = "GetFullPathNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathName([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int nBufferLength, string lpBuffer, char** lpFilePart);
    [DllImport(lib, EntryPoint = "GetFullPathNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathName([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int nBufferLength, char* lpBuffer, string lpFilePart);
    [DllImport(lib, EntryPoint = "GetFullPathNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathName([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int nBufferLength, char* lpBuffer, char** lpFilePart);
    [DllImport(lib, EntryPoint = "GetFullPathNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathName(char* lpFileName, int nBufferLength, string lpBuffer, string lpFilePart);
    [DllImport(lib, EntryPoint = "GetFullPathNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathName(char* lpFileName, int nBufferLength, string lpBuffer, char** lpFilePart);
    [DllImport(lib, EntryPoint = "GetFullPathNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathName(char* lpFileName, int nBufferLength, char* lpBuffer, string lpFilePart);
    [DllImport(lib, EntryPoint = "GetFullPathNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathName(char* lpFileName, int nBufferLength, char* lpBuffer, char** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int nBufferLength, string lpBuffer, string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int nBufferLength, string lpBuffer, char** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int nBufferLength, char* lpBuffer, string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int nBufferLength, char* lpBuffer, char** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameW(char* lpFileName, int nBufferLength, string lpBuffer, string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameW(char* lpFileName, int nBufferLength, string lpBuffer, char** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameW(char* lpFileName, int nBufferLength, char* lpBuffer, string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameW(char* lpFileName, int nBufferLength, char* lpBuffer, char** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, [MarshalAs(UnmanagedType.LPStr)] string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, ReadOnlySpan<byte> lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, byte** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, int nBufferLength, ReadOnlySpan<byte> lpBuffer, [MarshalAs(UnmanagedType.LPStr)] string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, int nBufferLength, ReadOnlySpan<byte> lpBuffer, ReadOnlySpan<byte> lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, int nBufferLength, ReadOnlySpan<byte> lpBuffer, byte** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, int nBufferLength, byte* lpBuffer, [MarshalAs(UnmanagedType.LPStr)] string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, int nBufferLength, byte* lpBuffer, ReadOnlySpan<byte> lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, int nBufferLength, byte* lpBuffer, byte** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameA(byte* lpFileName, int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, [MarshalAs(UnmanagedType.LPStr)] string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameA(byte* lpFileName, int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, ReadOnlySpan<byte> lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameA(byte* lpFileName, int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, byte** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameA(byte* lpFileName, int nBufferLength, ReadOnlySpan<byte> lpBuffer, [MarshalAs(UnmanagedType.LPStr)] string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameA(byte* lpFileName, int nBufferLength, ReadOnlySpan<byte> lpBuffer, ReadOnlySpan<byte> lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameA(byte* lpFileName, int nBufferLength, ReadOnlySpan<byte> lpBuffer, byte** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameA(byte* lpFileName, int nBufferLength, byte* lpBuffer, [MarshalAs(UnmanagedType.LPStr)] string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameA(byte* lpFileName, int nBufferLength, byte* lpBuffer, ReadOnlySpan<byte> lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameA(byte* lpFileName, int nBufferLength, byte* lpBuffer, byte** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLogicalDrives();
    [DllImport(lib, EntryPoint = "GetLogicalDriveStringsW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLogicalDriveStrings(int nBufferLength, string lpBuffer);
    [DllImport(lib, EntryPoint = "GetLogicalDriveStringsW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLogicalDriveStrings(int nBufferLength, char* lpBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLogicalDriveStringsW(int nBufferLength, string lpBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLogicalDriveStringsW(int nBufferLength, char* lpBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLongPathNameA([MarshalAs(UnmanagedType.LPStr)] string lpszShortPath, [MarshalAs(UnmanagedType.LPStr)] string lpszLongPath, int cchBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLongPathNameA([MarshalAs(UnmanagedType.LPStr)] string lpszShortPath, ReadOnlySpan<byte> lpszLongPath, int cchBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLongPathNameA([MarshalAs(UnmanagedType.LPStr)] string lpszShortPath, byte* lpszLongPath, int cchBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLongPathNameA(byte* lpszShortPath, [MarshalAs(UnmanagedType.LPStr)] string lpszLongPath, int cchBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLongPathNameA(byte* lpszShortPath, ReadOnlySpan<byte> lpszLongPath, int cchBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLongPathNameA(byte* lpszShortPath, byte* lpszLongPath, int cchBuffer);
    [DllImport(lib, EntryPoint = "GetLongPathNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLongPathName([MarshalAs(UnmanagedType.LPWStr)] string lpszShortPath, string lpszLongPath, int cchBuffer);
    [DllImport(lib, EntryPoint = "GetLongPathNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLongPathName([MarshalAs(UnmanagedType.LPWStr)] string lpszShortPath, char* lpszLongPath, int cchBuffer);
    [DllImport(lib, EntryPoint = "GetLongPathNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLongPathName(char* lpszShortPath, string lpszLongPath, int cchBuffer);
    [DllImport(lib, EntryPoint = "GetLongPathNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLongPathName(char* lpszShortPath, char* lpszLongPath, int cchBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLongPathNameW([MarshalAs(UnmanagedType.LPWStr)] string lpszShortPath, string lpszLongPath, int cchBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLongPathNameW([MarshalAs(UnmanagedType.LPWStr)] string lpszShortPath, char* lpszLongPath, int cchBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLongPathNameW(char* lpszShortPath, string lpszLongPath, int cchBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLongPathNameW(char* lpszShortPath, char* lpszLongPath, int cchBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AreShortNamesEnabled(cpointer Handle, cpointer Enabled);
    [DllImport(lib, EntryPoint = "GetShortPathNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetShortPathName([MarshalAs(UnmanagedType.LPWStr)] string lpszLongPath, string lpszShortPath, int cchBuffer);
    [DllImport(lib, EntryPoint = "GetShortPathNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetShortPathName([MarshalAs(UnmanagedType.LPWStr)] string lpszLongPath, char* lpszShortPath, int cchBuffer);
    [DllImport(lib, EntryPoint = "GetShortPathNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetShortPathName(char* lpszLongPath, string lpszShortPath, int cchBuffer);
    [DllImport(lib, EntryPoint = "GetShortPathNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetShortPathName(char* lpszLongPath, char* lpszShortPath, int cchBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetShortPathNameW([MarshalAs(UnmanagedType.LPWStr)] string lpszLongPath, string lpszShortPath, int cchBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetShortPathNameW([MarshalAs(UnmanagedType.LPWStr)] string lpszLongPath, char* lpszShortPath, int cchBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetShortPathNameW(char* lpszLongPath, string lpszShortPath, int cchBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetShortPathNameW(char* lpszLongPath, char* lpszShortPath, int cchBuffer);
    [DllImport(lib, EntryPoint = "GetTempFileNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetTempFileName([MarshalAs(UnmanagedType.LPWStr)] string lpPathName, [MarshalAs(UnmanagedType.LPWStr)] string lpPrefixString, uint uUnique, string lpTempFileName);
    [DllImport(lib, EntryPoint = "GetTempFileNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetTempFileName([MarshalAs(UnmanagedType.LPWStr)] string lpPathName, [MarshalAs(UnmanagedType.LPWStr)] string lpPrefixString, uint uUnique, char* lpTempFileName);
    [DllImport(lib, EntryPoint = "GetTempFileNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetTempFileName([MarshalAs(UnmanagedType.LPWStr)] string lpPathName, char* lpPrefixString, uint uUnique, string lpTempFileName);
    [DllImport(lib, EntryPoint = "GetTempFileNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetTempFileName([MarshalAs(UnmanagedType.LPWStr)] string lpPathName, char* lpPrefixString, uint uUnique, char* lpTempFileName);
    [DllImport(lib, EntryPoint = "GetTempFileNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetTempFileName(char* lpPathName, [MarshalAs(UnmanagedType.LPWStr)] string lpPrefixString, uint uUnique, string lpTempFileName);
    [DllImport(lib, EntryPoint = "GetTempFileNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetTempFileName(char* lpPathName, [MarshalAs(UnmanagedType.LPWStr)] string lpPrefixString, uint uUnique, char* lpTempFileName);
    [DllImport(lib, EntryPoint = "GetTempFileNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetTempFileName(char* lpPathName, char* lpPrefixString, uint uUnique, string lpTempFileName);
    [DllImport(lib, EntryPoint = "GetTempFileNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetTempFileName(char* lpPathName, char* lpPrefixString, uint uUnique, char* lpTempFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetTempFileNameW([MarshalAs(UnmanagedType.LPWStr)] string lpPathName, [MarshalAs(UnmanagedType.LPWStr)] string lpPrefixString, uint uUnique, string lpTempFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetTempFileNameW([MarshalAs(UnmanagedType.LPWStr)] string lpPathName, [MarshalAs(UnmanagedType.LPWStr)] string lpPrefixString, uint uUnique, char* lpTempFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetTempFileNameW([MarshalAs(UnmanagedType.LPWStr)] string lpPathName, char* lpPrefixString, uint uUnique, string lpTempFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetTempFileNameW([MarshalAs(UnmanagedType.LPWStr)] string lpPathName, char* lpPrefixString, uint uUnique, char* lpTempFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetTempFileNameW(char* lpPathName, [MarshalAs(UnmanagedType.LPWStr)] string lpPrefixString, uint uUnique, string lpTempFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetTempFileNameW(char* lpPathName, [MarshalAs(UnmanagedType.LPWStr)] string lpPrefixString, uint uUnique, char* lpTempFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetTempFileNameW(char* lpPathName, char* lpPrefixString, uint uUnique, string lpTempFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetTempFileNameW(char* lpPathName, char* lpPrefixString, uint uUnique, char* lpTempFileName);
    [DllImport(lib, EntryPoint = "GetVolumeInformationByHandleW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationByHandle(cpointer hFile, string lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, EntryPoint = "GetVolumeInformationByHandleW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationByHandle(cpointer hFile, string lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, EntryPoint = "GetVolumeInformationByHandleW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationByHandle(cpointer hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, EntryPoint = "GetVolumeInformationByHandleW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationByHandle(cpointer hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationByHandleW(cpointer hFile, string lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationByHandleW(cpointer hFile, string lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationByHandleW(cpointer hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationByHandleW(cpointer hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, EntryPoint = "GetVolumeInformationW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformation([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, string lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, EntryPoint = "GetVolumeInformationW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformation([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, string lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, EntryPoint = "GetVolumeInformationW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformation([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, EntryPoint = "GetVolumeInformationW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformation([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, EntryPoint = "GetVolumeInformationW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformation(char* lpRootPathName, string lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, EntryPoint = "GetVolumeInformationW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformation(char* lpRootPathName, string lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, EntryPoint = "GetVolumeInformationW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformation(char* lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, EntryPoint = "GetVolumeInformationW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformation(char* lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationW([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, string lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationW([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, string lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationW([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationW([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationW(char* lpRootPathName, string lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationW(char* lpRootPathName, string lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationW(char* lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationW(char* lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, EntryPoint = "GetVolumePathNameW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumePathName([MarshalAs(UnmanagedType.LPWStr)] string lpszFileName, string lpszVolumePathName, int cchBufferLength);
    [DllImport(lib, EntryPoint = "GetVolumePathNameW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumePathName([MarshalAs(UnmanagedType.LPWStr)] string lpszFileName, char* lpszVolumePathName, int cchBufferLength);
    [DllImport(lib, EntryPoint = "GetVolumePathNameW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumePathName(char* lpszFileName, string lpszVolumePathName, int cchBufferLength);
    [DllImport(lib, EntryPoint = "GetVolumePathNameW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumePathName(char* lpszFileName, char* lpszVolumePathName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumePathNameW([MarshalAs(UnmanagedType.LPWStr)] string lpszFileName, string lpszVolumePathName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumePathNameW([MarshalAs(UnmanagedType.LPWStr)] string lpszFileName, char* lpszVolumePathName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumePathNameW(char* lpszFileName, string lpszVolumePathName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumePathNameW(char* lpszFileName, char* lpszVolumePathName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool LocalFileTimeToFileTime(cpointer unfoundType_FILETIME_lpLocalFileTime, cpointer unfoundType_LPFILETIME_lpFileTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool LockFile(cpointer hFile, int dwFileOffsetLow, int dwFileOffsetHigh, int nNumberOfBytesToLockLow, int nNumberOfBytesToLockHigh);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool LockFileEx(cpointer hFile, int dwFlags, int dwReserved, int nNumberOfBytesToLockLow, int nNumberOfBytesToLockHigh, cpointer unfoundType_LPOVERLAPPED_lpOverlapped);
    [DllImport(lib, EntryPoint = "QueryDosDeviceW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int QueryDosDevice([MarshalAs(UnmanagedType.LPWStr)] string lpDeviceName, string lpTargetPath, int ucchMax);
    [DllImport(lib, EntryPoint = "QueryDosDeviceW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int QueryDosDevice([MarshalAs(UnmanagedType.LPWStr)] string lpDeviceName, char* lpTargetPath, int ucchMax);
    [DllImport(lib, EntryPoint = "QueryDosDeviceW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int QueryDosDevice(char* lpDeviceName, string lpTargetPath, int ucchMax);
    [DllImport(lib, EntryPoint = "QueryDosDeviceW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int QueryDosDevice(char* lpDeviceName, char* lpTargetPath, int ucchMax);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int QueryDosDeviceW([MarshalAs(UnmanagedType.LPWStr)] string lpDeviceName, string lpTargetPath, int ucchMax);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int QueryDosDeviceW([MarshalAs(UnmanagedType.LPWStr)] string lpDeviceName, char* lpTargetPath, int ucchMax);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int QueryDosDeviceW(char* lpDeviceName, string lpTargetPath, int ucchMax);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int QueryDosDeviceW(char* lpDeviceName, char* lpTargetPath, int ucchMax);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadFile(cpointer hFile, cpointer lpBuffer, int nNumberOfBytesToRead, cpointer unfoundType_LPDWORD_lpNumberOfBytesRead, cpointer unfoundType_LPOVERLAPPED_lpOverlapped);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadFileEx(cpointer hFile, cpointer lpBuffer, int nNumberOfBytesToRead, cpointer unfoundType_LPOVERLAPPED_lpOverlapped, cpointer unfoundType_LPOVERLAPPED_COMPLETION_ROUTINE_lpCompletionRoutine);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadFileScatter(cpointer hFile, cpointer unfoundType_FILE_SEGMENT_ELEMENT_aSegmentArray, int nNumberOfBytesToRead, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPOVERLAPPED_lpOverlapped);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool RemoveDirectoryA([MarshalAs(UnmanagedType.LPStr)] string lpPathName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool RemoveDirectoryA(byte* lpPathName);
    [DllImport(lib, EntryPoint = "RemoveDirectoryW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool RemoveDirectory([MarshalAs(UnmanagedType.LPWStr)] string lpPathName);
    [DllImport(lib, EntryPoint = "RemoveDirectoryW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool RemoveDirectory(char* lpPathName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool RemoveDirectoryW([MarshalAs(UnmanagedType.LPWStr)] string lpPathName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool RemoveDirectoryW(char* lpPathName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetEndOfFile(cpointer hFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFileAttributesA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, int dwFileAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFileAttributesA(byte* lpFileName, int dwFileAttributes);
    [DllImport(lib, EntryPoint = "SetFileAttributesW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFileAttributes([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwFileAttributes);
    [DllImport(lib, EntryPoint = "SetFileAttributesW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFileAttributes(char* lpFileName, int dwFileAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFileAttributesW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwFileAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFileAttributesW(char* lpFileName, int dwFileAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFileInformationByHandle(cpointer hFile, cpointer unfoundType_FILE_INFO_BY_HANDLE_CLASS_FileInformationClass, cpointer lpFileInformation, int dwBufferSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SetFilePointer(cpointer hFile, int lDistanceToMove, cpointer lpDistanceToMoveHigh, int dwMoveMethod);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFilePointerEx(cpointer hFile, cpointer unfoundType_LARGE_INTEGER_liDistanceToMove, cpointer unfoundType_PLARGE_INTEGER_lpNewFilePointer, int dwMoveMethod);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFileTime(cpointer hFile, cpointer unfoundType_FILETIME_lpCreationTime, cpointer unfoundType_FILETIME_lpLastAccessTime, cpointer unfoundType_FILETIME_lpLastWriteTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFileValidData(cpointer hFile, cpointer unfoundType_LONGLONG_ValidDataLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UnlockFile(cpointer hFile, int dwFileOffsetLow, int dwFileOffsetHigh, int nNumberOfBytesToUnlockLow, int nNumberOfBytesToUnlockHigh);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UnlockFileEx(cpointer hFile, int dwReserved, int nNumberOfBytesToUnlockLow, int nNumberOfBytesToUnlockHigh, cpointer unfoundType_LPOVERLAPPED_lpOverlapped);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteFile(cpointer hFile, cpointer lpBuffer, int nNumberOfBytesToWrite, cpointer unfoundType_LPDWORD_lpNumberOfBytesWritten, cpointer unfoundType_LPOVERLAPPED_lpOverlapped);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteFileEx(cpointer hFile, cpointer lpBuffer, int nNumberOfBytesToWrite, cpointer unfoundType_LPOVERLAPPED_lpOverlapped, cpointer unfoundType_LPOVERLAPPED_COMPLETION_ROUTINE_lpCompletionRoutine);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteFileGather(cpointer hFile, cpointer unfoundType_FILE_SEGMENT_ELEMENT_aSegmentArray, int nNumberOfBytesToWrite, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPOVERLAPPED_lpOverlapped);
    [DllImport(lib, EntryPoint = "GetTempPathW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTempPath(int nBufferLength, string lpBuffer);
    [DllImport(lib, EntryPoint = "GetTempPathW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTempPath(int nBufferLength, char* lpBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTempPathW(int nBufferLength, string lpBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTempPathW(int nBufferLength, char* lpBuffer);
    [DllImport(lib, EntryPoint = "GetVolumeNameForVolumeMountPointW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeNameForVolumeMountPoint([MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeMountPoint, string lpszVolumeName, int cchBufferLength);
    [DllImport(lib, EntryPoint = "GetVolumeNameForVolumeMountPointW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeNameForVolumeMountPoint([MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeMountPoint, char* lpszVolumeName, int cchBufferLength);
    [DllImport(lib, EntryPoint = "GetVolumeNameForVolumeMountPointW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeNameForVolumeMountPoint(char* lpszVolumeMountPoint, string lpszVolumeName, int cchBufferLength);
    [DllImport(lib, EntryPoint = "GetVolumeNameForVolumeMountPointW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeNameForVolumeMountPoint(char* lpszVolumeMountPoint, char* lpszVolumeName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeNameForVolumeMountPointW([MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeMountPoint, string lpszVolumeName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeNameForVolumeMountPointW([MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeMountPoint, char* lpszVolumeName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeNameForVolumeMountPointW(char* lpszVolumeMountPoint, string lpszVolumeName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeNameForVolumeMountPointW(char* lpszVolumeMountPoint, char* lpszVolumeName, int cchBufferLength);
    [DllImport(lib, EntryPoint = "GetVolumePathNamesForVolumeNameW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumePathNamesForVolumeName([MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeName, string lpszVolumePathNames, int cchBufferLength, cpointer unfoundType_PDWORD_lpcchReturnLength);
    [DllImport(lib, EntryPoint = "GetVolumePathNamesForVolumeNameW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumePathNamesForVolumeName([MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeName, char* lpszVolumePathNames, int cchBufferLength, cpointer unfoundType_PDWORD_lpcchReturnLength);
    [DllImport(lib, EntryPoint = "GetVolumePathNamesForVolumeNameW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumePathNamesForVolumeName(char* lpszVolumeName, string lpszVolumePathNames, int cchBufferLength, cpointer unfoundType_PDWORD_lpcchReturnLength);
    [DllImport(lib, EntryPoint = "GetVolumePathNamesForVolumeNameW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumePathNamesForVolumeName(char* lpszVolumeName, char* lpszVolumePathNames, int cchBufferLength, cpointer unfoundType_PDWORD_lpcchReturnLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumePathNamesForVolumeNameW([MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeName, string lpszVolumePathNames, int cchBufferLength, cpointer unfoundType_PDWORD_lpcchReturnLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumePathNamesForVolumeNameW([MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeName, char* lpszVolumePathNames, int cchBufferLength, cpointer unfoundType_PDWORD_lpcchReturnLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumePathNamesForVolumeNameW(char* lpszVolumeName, string lpszVolumePathNames, int cchBufferLength, cpointer unfoundType_PDWORD_lpcchReturnLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumePathNamesForVolumeNameW(char* lpszVolumeName, char* lpszVolumePathNames, int cchBufferLength, cpointer unfoundType_PDWORD_lpcchReturnLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateFile2([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwDesiredAccess, int dwShareMode, int dwCreationDisposition, cpointer unfoundType_LPCREATEFILE2_EXTENDED_PARAMETERS_pCreateExParams);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateFile2(char* lpFileName, int dwDesiredAccess, int dwShareMode, int dwCreationDisposition, cpointer unfoundType_LPCREATEFILE2_EXTENDED_PARAMETERS_pCreateExParams);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFileIoOverlappedRange(cpointer FileHandle, cpointer unfoundType_PUCHAR_OverlappedRangeStart, uint Length);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCompressedFileSizeA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, cpointer unfoundType_LPDWORD_lpFileSizeHigh);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCompressedFileSizeA(byte* lpFileName, cpointer unfoundType_LPDWORD_lpFileSizeHigh);
    [DllImport(lib, EntryPoint = "GetCompressedFileSizeW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCompressedFileSize([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, cpointer unfoundType_LPDWORD_lpFileSizeHigh);
    [DllImport(lib, EntryPoint = "GetCompressedFileSizeW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCompressedFileSize(char* lpFileName, cpointer unfoundType_LPDWORD_lpFileSizeHigh);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCompressedFileSizeW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, cpointer unfoundType_LPDWORD_lpFileSizeHigh);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCompressedFileSizeW(char* lpFileName, cpointer unfoundType_LPDWORD_lpFileSizeHigh);
    [DllImport(lib, EntryPoint = "FindFirstStreamW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstStream([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, cpointer unfoundType_STREAM_INFO_LEVELS_InfoLevel, cpointer lpFindStreamData, int dwFlags);
    [DllImport(lib, EntryPoint = "FindFirstStreamW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstStream(char* lpFileName, cpointer unfoundType_STREAM_INFO_LEVELS_InfoLevel, cpointer lpFindStreamData, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstStreamW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, cpointer unfoundType_STREAM_INFO_LEVELS_InfoLevel, cpointer lpFindStreamData, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstStreamW(char* lpFileName, cpointer unfoundType_STREAM_INFO_LEVELS_InfoLevel, cpointer lpFindStreamData, int dwFlags);
    [DllImport(lib, EntryPoint = "FindNextStreamW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextStream(cpointer hFindStream, cpointer lpFindStreamData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextStreamW(cpointer hFindStream, cpointer lpFindStreamData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AreFileApisANSI();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTempPathA(int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTempPathA(int nBufferLength, ReadOnlySpan<byte> lpBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTempPathA(int nBufferLength, byte* lpBuffer);
    [DllImport(lib, EntryPoint = "FindFirstFileNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstFileName([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwFlags, cpointer unfoundType_LPDWORD_StringLength, [MarshalAs(UnmanagedType.LPWStr)] string LinkName);
    [DllImport(lib, EntryPoint = "FindFirstFileNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstFileName([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwFlags, cpointer unfoundType_LPDWORD_StringLength, char* LinkName);
    [DllImport(lib, EntryPoint = "FindFirstFileNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstFileName(char* lpFileName, int dwFlags, cpointer unfoundType_LPDWORD_StringLength, [MarshalAs(UnmanagedType.LPWStr)] string LinkName);
    [DllImport(lib, EntryPoint = "FindFirstFileNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstFileName(char* lpFileName, int dwFlags, cpointer unfoundType_LPDWORD_StringLength, char* LinkName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstFileNameW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwFlags, cpointer unfoundType_LPDWORD_StringLength, [MarshalAs(UnmanagedType.LPWStr)] string LinkName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstFileNameW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwFlags, cpointer unfoundType_LPDWORD_StringLength, char* LinkName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstFileNameW(char* lpFileName, int dwFlags, cpointer unfoundType_LPDWORD_StringLength, [MarshalAs(UnmanagedType.LPWStr)] string LinkName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstFileNameW(char* lpFileName, int dwFlags, cpointer unfoundType_LPDWORD_StringLength, char* LinkName);
    [DllImport(lib, EntryPoint = "FindNextFileNameW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextFileName(cpointer hFindStream, cpointer unfoundType_LPDWORD_StringLength, [MarshalAs(UnmanagedType.LPWStr)] string LinkName);
    [DllImport(lib, EntryPoint = "FindNextFileNameW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextFileName(cpointer hFindStream, cpointer unfoundType_LPDWORD_StringLength, char* LinkName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextFileNameW(cpointer hFindStream, cpointer unfoundType_LPDWORD_StringLength, [MarshalAs(UnmanagedType.LPWStr)] string LinkName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextFileNameW(cpointer hFindStream, cpointer unfoundType_LPDWORD_StringLength, char* LinkName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationA([MarshalAs(UnmanagedType.LPStr)] string lpRootPathName, [MarshalAs(UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, [MarshalAs(UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationA([MarshalAs(UnmanagedType.LPStr)] string lpRootPathName, [MarshalAs(UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, ReadOnlySpan<byte> lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationA([MarshalAs(UnmanagedType.LPStr)] string lpRootPathName, [MarshalAs(UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationA([MarshalAs(UnmanagedType.LPStr)] string lpRootPathName, ReadOnlySpan<byte> lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, [MarshalAs(UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationA([MarshalAs(UnmanagedType.LPStr)] string lpRootPathName, ReadOnlySpan<byte> lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, ReadOnlySpan<byte> lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationA([MarshalAs(UnmanagedType.LPStr)] string lpRootPathName, ReadOnlySpan<byte> lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationA([MarshalAs(UnmanagedType.LPStr)] string lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, [MarshalAs(UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationA([MarshalAs(UnmanagedType.LPStr)] string lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, ReadOnlySpan<byte> lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationA([MarshalAs(UnmanagedType.LPStr)] string lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationA(byte* lpRootPathName, [MarshalAs(UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, [MarshalAs(UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationA(byte* lpRootPathName, [MarshalAs(UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, ReadOnlySpan<byte> lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationA(byte* lpRootPathName, [MarshalAs(UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationA(byte* lpRootPathName, ReadOnlySpan<byte> lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, [MarshalAs(UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationA(byte* lpRootPathName, ReadOnlySpan<byte> lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, ReadOnlySpan<byte> lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationA(byte* lpRootPathName, ReadOnlySpan<byte> lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationA(byte* lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, [MarshalAs(UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationA(byte* lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, ReadOnlySpan<byte> lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationA(byte* lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetTempFileNameA([MarshalAs(UnmanagedType.LPStr)] string lpPathName, [MarshalAs(UnmanagedType.LPStr)] string lpPrefixString, uint uUnique, [MarshalAs(UnmanagedType.LPStr)] string lpTempFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetTempFileNameA([MarshalAs(UnmanagedType.LPStr)] string lpPathName, [MarshalAs(UnmanagedType.LPStr)] string lpPrefixString, uint uUnique, ReadOnlySpan<byte> lpTempFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetTempFileNameA([MarshalAs(UnmanagedType.LPStr)] string lpPathName, [MarshalAs(UnmanagedType.LPStr)] string lpPrefixString, uint uUnique, byte* lpTempFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetTempFileNameA([MarshalAs(UnmanagedType.LPStr)] string lpPathName, byte* lpPrefixString, uint uUnique, [MarshalAs(UnmanagedType.LPStr)] string lpTempFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetTempFileNameA([MarshalAs(UnmanagedType.LPStr)] string lpPathName, byte* lpPrefixString, uint uUnique, ReadOnlySpan<byte> lpTempFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetTempFileNameA([MarshalAs(UnmanagedType.LPStr)] string lpPathName, byte* lpPrefixString, uint uUnique, byte* lpTempFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetTempFileNameA(byte* lpPathName, [MarshalAs(UnmanagedType.LPStr)] string lpPrefixString, uint uUnique, [MarshalAs(UnmanagedType.LPStr)] string lpTempFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetTempFileNameA(byte* lpPathName, [MarshalAs(UnmanagedType.LPStr)] string lpPrefixString, uint uUnique, ReadOnlySpan<byte> lpTempFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetTempFileNameA(byte* lpPathName, [MarshalAs(UnmanagedType.LPStr)] string lpPrefixString, uint uUnique, byte* lpTempFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetTempFileNameA(byte* lpPathName, byte* lpPrefixString, uint uUnique, [MarshalAs(UnmanagedType.LPStr)] string lpTempFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetTempFileNameA(byte* lpPathName, byte* lpPrefixString, uint uUnique, ReadOnlySpan<byte> lpTempFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetTempFileNameA(byte* lpPathName, byte* lpPrefixString, uint uUnique, byte* lpTempFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void SetFileApisToOEM();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void SetFileApisToANSI();
    [DllImport(lib, EntryPoint = "GetTempPath2W", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTempPath2(int BufferLength, string Buffer);
    [DllImport(lib, EntryPoint = "GetTempPath2W", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTempPath2(int BufferLength, char* Buffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTempPath2W(int BufferLength, string Buffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTempPath2W(int BufferLength, char* Buffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTempPath2A(int BufferLength, [MarshalAs(UnmanagedType.LPStr)] string Buffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTempPath2A(int BufferLength, ReadOnlySpan<byte> Buffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTempPath2A(int BufferLength, byte* Buffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LZStart();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void LZDone();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CopyLZFile(int hfSource, int hfDest);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LZCopy(int hfSource, int hfDest);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LZInit(int hfSource);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetExpandedNameA([MarshalAs(UnmanagedType.LPStr)] string lpszSource, [MarshalAs(UnmanagedType.LPStr)] string lpszBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetExpandedNameA([MarshalAs(UnmanagedType.LPStr)] string lpszSource, ReadOnlySpan<byte> lpszBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetExpandedNameA([MarshalAs(UnmanagedType.LPStr)] string lpszSource, byte* lpszBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetExpandedNameA(ReadOnlySpan<byte> lpszSource, [MarshalAs(UnmanagedType.LPStr)] string lpszBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetExpandedNameA(ReadOnlySpan<byte> lpszSource, ReadOnlySpan<byte> lpszBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetExpandedNameA(ReadOnlySpan<byte> lpszSource, byte* lpszBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetExpandedNameA(byte* lpszSource, [MarshalAs(UnmanagedType.LPStr)] string lpszBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetExpandedNameA(byte* lpszSource, ReadOnlySpan<byte> lpszBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetExpandedNameA(byte* lpszSource, byte* lpszBuffer);
    [DllImport(lib, EntryPoint = "GetExpandedNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetExpandedName(string lpszSource, string lpszBuffer);
    [DllImport(lib, EntryPoint = "GetExpandedNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetExpandedName(string lpszSource, char* lpszBuffer);
    [DllImport(lib, EntryPoint = "GetExpandedNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetExpandedName(char* lpszSource, string lpszBuffer);
    [DllImport(lib, EntryPoint = "GetExpandedNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetExpandedName(char* lpszSource, char* lpszBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetExpandedNameW(string lpszSource, string lpszBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetExpandedNameW(string lpszSource, char* lpszBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetExpandedNameW(char* lpszSource, string lpszBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetExpandedNameW(char* lpszSource, char* lpszBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LZOpenFileA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, cpointer unfoundType_LPOFSTRUCT_lpReOpenBuf, short wStyle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LZOpenFileA(ReadOnlySpan<byte> lpFileName, cpointer unfoundType_LPOFSTRUCT_lpReOpenBuf, short wStyle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LZOpenFileA(byte* lpFileName, cpointer unfoundType_LPOFSTRUCT_lpReOpenBuf, short wStyle);
    [DllImport(lib, EntryPoint = "LZOpenFileW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int LZOpenFile(string lpFileName, cpointer unfoundType_LPOFSTRUCT_lpReOpenBuf, short wStyle);
    [DllImport(lib, EntryPoint = "LZOpenFileW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int LZOpenFile(char* lpFileName, cpointer unfoundType_LPOFSTRUCT_lpReOpenBuf, short wStyle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LZOpenFileW(string lpFileName, cpointer unfoundType_LPOFSTRUCT_lpReOpenBuf, short wStyle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LZOpenFileW(char* lpFileName, cpointer unfoundType_LPOFSTRUCT_lpReOpenBuf, short wStyle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LZSeek(int hFile, int lOffset, int iOrigin);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LZRead(int hFile, cpointer lpBuffer, int cbRead);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void LZClose(int hFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrentPackageId(cpointer bufferLength, cpointer buffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrentPackageFullName(cpointer packageFullNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageFullName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrentPackageFullName(cpointer packageFullNameLength, char* packageFullName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrentPackageFamilyName(cpointer packageFamilyNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrentPackageFamilyName(cpointer packageFamilyNameLength, char* packageFamilyName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrentPackagePath(cpointer pathLength, [MarshalAs(UnmanagedType.LPWStr)] string path);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrentPackagePath(cpointer pathLength, char* path);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPackageId(cpointer hProcess, cpointer bufferLength, cpointer buffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPackageFullName(cpointer hProcess, cpointer packageFullNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageFullName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPackageFullName(cpointer hProcess, cpointer packageFullNameLength, char* packageFullName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPackageFamilyName(cpointer hProcess, cpointer packageFamilyNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPackageFamilyName(cpointer hProcess, cpointer packageFamilyNameLength, char* packageFamilyName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPackagePath(cpointer unfoundType_PACKAGE_ID_packageId, uint reserved, cpointer pathLength, [MarshalAs(UnmanagedType.LPWStr)] string path);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPackagePath(cpointer unfoundType_PACKAGE_ID_packageId, uint reserved, cpointer pathLength, char* path);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPackagePathByFullName([MarshalAs(UnmanagedType.LPWStr)] string packageFullName, cpointer pathLength, [MarshalAs(UnmanagedType.LPWStr)] string path);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPackagePathByFullName([MarshalAs(UnmanagedType.LPWStr)] string packageFullName, cpointer pathLength, char* path);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPackagePathByFullName(char* packageFullName, cpointer pathLength, [MarshalAs(UnmanagedType.LPWStr)] string path);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPackagePathByFullName(char* packageFullName, cpointer pathLength, char* path);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetStagedPackagePathByFullName([MarshalAs(UnmanagedType.LPWStr)] string packageFullName, cpointer pathLength, [MarshalAs(UnmanagedType.LPWStr)] string path);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetStagedPackagePathByFullName([MarshalAs(UnmanagedType.LPWStr)] string packageFullName, cpointer pathLength, char* path);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetStagedPackagePathByFullName(char* packageFullName, cpointer pathLength, [MarshalAs(UnmanagedType.LPWStr)] string path);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetStagedPackagePathByFullName(char* packageFullName, cpointer pathLength, char* path);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrentApplicationUserModelId(cpointer applicationUserModelIdLength, [MarshalAs(UnmanagedType.LPWStr)] string applicationUserModelId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrentApplicationUserModelId(cpointer applicationUserModelIdLength, char* applicationUserModelId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetApplicationUserModelId(cpointer hProcess, cpointer applicationUserModelIdLength, [MarshalAs(UnmanagedType.LPWStr)] string applicationUserModelId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetApplicationUserModelId(cpointer hProcess, cpointer applicationUserModelIdLength, char* applicationUserModelId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PackageIdFromFullName([MarshalAs(UnmanagedType.LPWStr)] string packageFullName, uint flags, cpointer bufferLength, cpointer buffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PackageIdFromFullName(char* packageFullName, uint flags, cpointer bufferLength, cpointer buffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PackageFullNameFromId(cpointer unfoundType_PACKAGE_ID_packageId, cpointer packageFullNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageFullName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PackageFullNameFromId(cpointer unfoundType_PACKAGE_ID_packageId, cpointer packageFullNameLength, char* packageFullName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PackageFamilyNameFromId(cpointer unfoundType_PACKAGE_ID_packageId, cpointer packageFamilyNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PackageFamilyNameFromId(cpointer unfoundType_PACKAGE_ID_packageId, cpointer packageFamilyNameLength, char* packageFamilyName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PackageFamilyNameFromFullName([MarshalAs(UnmanagedType.LPWStr)] string packageFullName, cpointer packageFamilyNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PackageFamilyNameFromFullName([MarshalAs(UnmanagedType.LPWStr)] string packageFullName, cpointer packageFamilyNameLength, char* packageFamilyName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PackageFamilyNameFromFullName(char* packageFullName, cpointer packageFamilyNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PackageFamilyNameFromFullName(char* packageFullName, cpointer packageFamilyNameLength, char* packageFamilyName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PackageNameAndPublisherIdFromFamilyName([MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, cpointer packageNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageName, cpointer packagePublisherIdLength, [MarshalAs(UnmanagedType.LPWStr)] string packagePublisherId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PackageNameAndPublisherIdFromFamilyName([MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, cpointer packageNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageName, cpointer packagePublisherIdLength, char* packagePublisherId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PackageNameAndPublisherIdFromFamilyName([MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, cpointer packageNameLength, char* packageName, cpointer packagePublisherIdLength, [MarshalAs(UnmanagedType.LPWStr)] string packagePublisherId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PackageNameAndPublisherIdFromFamilyName([MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, cpointer packageNameLength, char* packageName, cpointer packagePublisherIdLength, char* packagePublisherId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PackageNameAndPublisherIdFromFamilyName(char* packageFamilyName, cpointer packageNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageName, cpointer packagePublisherIdLength, [MarshalAs(UnmanagedType.LPWStr)] string packagePublisherId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PackageNameAndPublisherIdFromFamilyName(char* packageFamilyName, cpointer packageNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageName, cpointer packagePublisherIdLength, char* packagePublisherId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PackageNameAndPublisherIdFromFamilyName(char* packageFamilyName, cpointer packageNameLength, char* packageName, cpointer packagePublisherIdLength, [MarshalAs(UnmanagedType.LPWStr)] string packagePublisherId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PackageNameAndPublisherIdFromFamilyName(char* packageFamilyName, cpointer packageNameLength, char* packageName, cpointer packagePublisherIdLength, char* packagePublisherId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FormatApplicationUserModelId([MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, [MarshalAs(UnmanagedType.LPWStr)] string packageRelativeApplicationId, cpointer applicationUserModelIdLength, [MarshalAs(UnmanagedType.LPWStr)] string applicationUserModelId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FormatApplicationUserModelId([MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, [MarshalAs(UnmanagedType.LPWStr)] string packageRelativeApplicationId, cpointer applicationUserModelIdLength, char* applicationUserModelId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FormatApplicationUserModelId([MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, char* packageRelativeApplicationId, cpointer applicationUserModelIdLength, [MarshalAs(UnmanagedType.LPWStr)] string applicationUserModelId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FormatApplicationUserModelId([MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, char* packageRelativeApplicationId, cpointer applicationUserModelIdLength, char* applicationUserModelId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FormatApplicationUserModelId(char* packageFamilyName, [MarshalAs(UnmanagedType.LPWStr)] string packageRelativeApplicationId, cpointer applicationUserModelIdLength, [MarshalAs(UnmanagedType.LPWStr)] string applicationUserModelId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FormatApplicationUserModelId(char* packageFamilyName, [MarshalAs(UnmanagedType.LPWStr)] string packageRelativeApplicationId, cpointer applicationUserModelIdLength, char* applicationUserModelId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FormatApplicationUserModelId(char* packageFamilyName, char* packageRelativeApplicationId, cpointer applicationUserModelIdLength, [MarshalAs(UnmanagedType.LPWStr)] string applicationUserModelId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FormatApplicationUserModelId(char* packageFamilyName, char* packageRelativeApplicationId, cpointer applicationUserModelIdLength, char* applicationUserModelId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ParseApplicationUserModelId([MarshalAs(UnmanagedType.LPWStr)] string applicationUserModelId, cpointer packageFamilyNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, cpointer packageRelativeApplicationIdLength, [MarshalAs(UnmanagedType.LPWStr)] string packageRelativeApplicationId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ParseApplicationUserModelId([MarshalAs(UnmanagedType.LPWStr)] string applicationUserModelId, cpointer packageFamilyNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, cpointer packageRelativeApplicationIdLength, char* packageRelativeApplicationId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ParseApplicationUserModelId([MarshalAs(UnmanagedType.LPWStr)] string applicationUserModelId, cpointer packageFamilyNameLength, char* packageFamilyName, cpointer packageRelativeApplicationIdLength, [MarshalAs(UnmanagedType.LPWStr)] string packageRelativeApplicationId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ParseApplicationUserModelId([MarshalAs(UnmanagedType.LPWStr)] string applicationUserModelId, cpointer packageFamilyNameLength, char* packageFamilyName, cpointer packageRelativeApplicationIdLength, char* packageRelativeApplicationId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ParseApplicationUserModelId(char* applicationUserModelId, cpointer packageFamilyNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, cpointer packageRelativeApplicationIdLength, [MarshalAs(UnmanagedType.LPWStr)] string packageRelativeApplicationId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ParseApplicationUserModelId(char* applicationUserModelId, cpointer packageFamilyNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, cpointer packageRelativeApplicationIdLength, char* packageRelativeApplicationId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ParseApplicationUserModelId(char* applicationUserModelId, cpointer packageFamilyNameLength, char* packageFamilyName, cpointer packageRelativeApplicationIdLength, [MarshalAs(UnmanagedType.LPWStr)] string packageRelativeApplicationId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ParseApplicationUserModelId(char* applicationUserModelId, cpointer packageFamilyNameLength, char* packageFamilyName, cpointer packageRelativeApplicationIdLength, char* packageRelativeApplicationId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPackagesByPackageFamily([MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, cpointer count, [MarshalAs(UnmanagedType.LPWStr)] string packageFullNames, cpointer bufferLength, cpointer buffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPackagesByPackageFamily([MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, cpointer count, char** packageFullNames, cpointer bufferLength, cpointer buffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPackagesByPackageFamily(char* packageFamilyName, cpointer count, [MarshalAs(UnmanagedType.LPWStr)] string packageFullNames, cpointer bufferLength, cpointer buffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPackagesByPackageFamily(char* packageFamilyName, cpointer count, char** packageFullNames, cpointer bufferLength, cpointer buffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FindPackagesByPackageFamily([MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, uint packageFilters, cpointer count, [MarshalAs(UnmanagedType.LPWStr)] string packageFullNames, cpointer bufferLength, cpointer buffer, cpointer packageProperties);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FindPackagesByPackageFamily([MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, uint packageFilters, cpointer count, char** packageFullNames, cpointer bufferLength, cpointer buffer, cpointer packageProperties);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FindPackagesByPackageFamily(char* packageFamilyName, uint packageFilters, cpointer count, [MarshalAs(UnmanagedType.LPWStr)] string packageFullNames, cpointer bufferLength, cpointer buffer, cpointer packageProperties);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FindPackagesByPackageFamily(char* packageFamilyName, uint packageFilters, cpointer count, char** packageFullNames, cpointer bufferLength, cpointer buffer, cpointer packageProperties);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrentPackageInfo(uint flags, cpointer bufferLength, cpointer buffer, cpointer count);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int OpenPackageInfoByFullName([MarshalAs(UnmanagedType.LPWStr)] string packageFullName, uint reserved, cpointer unfoundType_PACKAGE_INFO_REFERENCE_packageInfoReference);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int OpenPackageInfoByFullName(char* packageFullName, uint reserved, cpointer unfoundType_PACKAGE_INFO_REFERENCE_packageInfoReference);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ClosePackageInfo(cpointer unfoundType_PACKAGE_INFO_REFERENCE_packageInfoReference);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPackageInfo(cpointer unfoundType_PACKAGE_INFO_REFERENCE_packageInfoReference, uint flags, cpointer bufferLength, cpointer buffer, cpointer count);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPackageApplicationIds(cpointer unfoundType_PACKAGE_INFO_REFERENCE_packageInfoReference, cpointer bufferLength, cpointer buffer, cpointer count);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int AppPolicyGetLifecycleManagement(cpointer processToken, cpointer unfoundType_AppPolicyLifecycleManagement_policy);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int AppPolicyGetWindowingModel(cpointer processToken, cpointer unfoundType_AppPolicyWindowingModel_policy);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int AppPolicyGetMediaFoundationCodecLoading(cpointer processToken, cpointer unfoundType_AppPolicyMediaFoundationCodecLoading_policy);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int AppPolicyGetClrCompat(cpointer processToken, cpointer unfoundType_AppPolicyClrCompat_policy);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int AppPolicyGetThreadInitializationType(cpointer processToken, cpointer unfoundType_AppPolicyThreadInitializationType_policy);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int AppPolicyGetShowDeveloperDiagnostic(cpointer processToken, cpointer unfoundType_AppPolicyShowDeveloperDiagnostic_policy);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int AppPolicyGetProcessTerminationMethod(cpointer processToken, cpointer unfoundType_AppPolicyProcessTerminationMethod_policy);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int AppPolicyGetCreateFileAccess(cpointer processToken, cpointer unfoundType_AppPolicyCreateFileAccess_policy);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ClearCommBreak(cpointer hFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ClearCommError(cpointer hFile, cpointer unfoundType_LPDWORD_lpErrors, cpointer unfoundType_LPCOMSTAT_lpStat);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetupComm(cpointer hFile, int dwInQueue, int dwOutQueue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EscapeCommFunction(cpointer hFile, int dwFunc);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetCommConfig(cpointer hCommDev, cpointer unfoundType_LPCOMMCONFIG_lpCC, cpointer unfoundType_LPDWORD_lpdwSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetCommMask(cpointer hFile, cpointer unfoundType_LPDWORD_lpEvtMask);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetCommModemStatus(cpointer hFile, cpointer unfoundType_LPDWORD_lpModemStat);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetCommProperties(cpointer hFile, cpointer unfoundType_LPCOMMPROP_lpCommProp);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetCommState(cpointer hFile, cpointer unfoundType_LPDCB_lpDCB);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetCommTimeouts(cpointer hFile, cpointer unfoundType_LPCOMMTIMEOUTS_lpCommTimeouts);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool PurgeComm(cpointer hFile, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetCommBreak(cpointer hFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetCommConfig(cpointer hCommDev, cpointer unfoundType_LPCOMMCONFIG_lpCC, int dwSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetCommMask(cpointer hFile, int dwEvtMask);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetCommState(cpointer hFile, cpointer unfoundType_LPDCB_lpDCB);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetCommTimeouts(cpointer hFile, cpointer unfoundType_LPCOMMTIMEOUTS_lpCommTimeouts);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool TransmitCommChar(cpointer hFile, byte cChar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WaitCommEvent(cpointer hFile, cpointer unfoundType_LPDWORD_lpEvtMask, cpointer unfoundType_LPOVERLAPPED_lpOverlapped);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatA(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, [MarshalAs(UnmanagedType.LPStr)] string lpFormat, [MarshalAs(UnmanagedType.LPStr)] string lpDateStr, int cchDate);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatA(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, [MarshalAs(UnmanagedType.LPStr)] string lpFormat, ReadOnlySpan<byte> lpDateStr, int cchDate);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatA(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, [MarshalAs(UnmanagedType.LPStr)] string lpFormat, byte* lpDateStr, int cchDate);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatA(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, byte* lpFormat, [MarshalAs(UnmanagedType.LPStr)] string lpDateStr, int cchDate);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatA(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, byte* lpFormat, ReadOnlySpan<byte> lpDateStr, int cchDate);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatA(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, byte* lpFormat, byte* lpDateStr, int cchDate);
    [DllImport(lib, EntryPoint = "GetDateFormatW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormat(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, string lpDateStr, int cchDate);
    [DllImport(lib, EntryPoint = "GetDateFormatW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormat(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, char* lpDateStr, int cchDate);
    [DllImport(lib, EntryPoint = "GetDateFormatW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormat(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, char* lpFormat, string lpDateStr, int cchDate);
    [DllImport(lib, EntryPoint = "GetDateFormatW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormat(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, char* lpFormat, char* lpDateStr, int cchDate);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatW(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, string lpDateStr, int cchDate);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatW(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, char* lpDateStr, int cchDate);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatW(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, char* lpFormat, string lpDateStr, int cchDate);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatW(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, char* lpFormat, char* lpDateStr, int cchDate);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormatA(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpTime, [MarshalAs(UnmanagedType.LPStr)] string lpFormat, [MarshalAs(UnmanagedType.LPStr)] string lpTimeStr, int cchTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormatA(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpTime, [MarshalAs(UnmanagedType.LPStr)] string lpFormat, ReadOnlySpan<byte> lpTimeStr, int cchTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormatA(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpTime, [MarshalAs(UnmanagedType.LPStr)] string lpFormat, byte* lpTimeStr, int cchTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormatA(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpTime, byte* lpFormat, [MarshalAs(UnmanagedType.LPStr)] string lpTimeStr, int cchTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormatA(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpTime, byte* lpFormat, ReadOnlySpan<byte> lpTimeStr, int cchTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormatA(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpTime, byte* lpFormat, byte* lpTimeStr, int cchTime);
    [DllImport(lib, EntryPoint = "GetTimeFormatW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormat(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpTime, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, string lpTimeStr, int cchTime);
    [DllImport(lib, EntryPoint = "GetTimeFormatW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormat(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpTime, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, char* lpTimeStr, int cchTime);
    [DllImport(lib, EntryPoint = "GetTimeFormatW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormat(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpTime, char* lpFormat, string lpTimeStr, int cchTime);
    [DllImport(lib, EntryPoint = "GetTimeFormatW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormat(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpTime, char* lpFormat, char* lpTimeStr, int cchTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormatW(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpTime, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, string lpTimeStr, int cchTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormatW(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpTime, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, char* lpTimeStr, int cchTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormatW(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpTime, char* lpFormat, string lpTimeStr, int cchTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormatW(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpTime, char* lpFormat, char* lpTimeStr, int cchTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpTime, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, string lpTimeStr, int cchTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpTime, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, char* lpTimeStr, int cchTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpTime, char* lpFormat, string lpTimeStr, int cchTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpTime, char* lpFormat, char* lpTimeStr, int cchTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormatEx(char* lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpTime, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, string lpTimeStr, int cchTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormatEx(char* lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpTime, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, char* lpTimeStr, int cchTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormatEx(char* lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpTime, char* lpFormat, string lpTimeStr, int cchTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormatEx(char* lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpTime, char* lpFormat, char* lpTimeStr, int cchTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, string lpDateStr, int cchDate, [MarshalAs(UnmanagedType.LPWStr)] string lpCalendar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, string lpDateStr, int cchDate, char* lpCalendar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, char* lpDateStr, int cchDate, [MarshalAs(UnmanagedType.LPWStr)] string lpCalendar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, char* lpDateStr, int cchDate, char* lpCalendar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, char* lpFormat, string lpDateStr, int cchDate, [MarshalAs(UnmanagedType.LPWStr)] string lpCalendar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, char* lpFormat, string lpDateStr, int cchDate, char* lpCalendar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, char* lpFormat, char* lpDateStr, int cchDate, [MarshalAs(UnmanagedType.LPWStr)] string lpCalendar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, char* lpFormat, char* lpDateStr, int cchDate, char* lpCalendar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatEx(char* lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, string lpDateStr, int cchDate, [MarshalAs(UnmanagedType.LPWStr)] string lpCalendar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatEx(char* lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, string lpDateStr, int cchDate, char* lpCalendar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatEx(char* lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, char* lpDateStr, int cchDate, [MarshalAs(UnmanagedType.LPWStr)] string lpCalendar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatEx(char* lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, char* lpDateStr, int cchDate, char* lpCalendar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatEx(char* lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, char* lpFormat, string lpDateStr, int cchDate, [MarshalAs(UnmanagedType.LPWStr)] string lpCalendar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatEx(char* lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, char* lpFormat, string lpDateStr, int cchDate, char* lpCalendar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatEx(char* lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, char* lpFormat, char* lpDateStr, int cchDate, [MarshalAs(UnmanagedType.LPWStr)] string lpCalendar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatEx(char* lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, char* lpFormat, char* lpDateStr, int cchDate, char* lpCalendar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDurationFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDuration, cpointer unfoundType_ULONGLONG_ullDuration, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, string lpDurationStr, int cchDuration);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDurationFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDuration, cpointer unfoundType_ULONGLONG_ullDuration, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, char* lpDurationStr, int cchDuration);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDurationFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDuration, cpointer unfoundType_ULONGLONG_ullDuration, char* lpFormat, string lpDurationStr, int cchDuration);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDurationFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDuration, cpointer unfoundType_ULONGLONG_ullDuration, char* lpFormat, char* lpDurationStr, int cchDuration);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDurationFormatEx(char* lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDuration, cpointer unfoundType_ULONGLONG_ullDuration, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, string lpDurationStr, int cchDuration);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDurationFormatEx(char* lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDuration, cpointer unfoundType_ULONGLONG_ullDuration, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, char* lpDurationStr, int cchDuration);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDurationFormatEx(char* lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDuration, cpointer unfoundType_ULONGLONG_ullDuration, char* lpFormat, string lpDurationStr, int cchDuration);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDurationFormatEx(char* lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDuration, cpointer unfoundType_ULONGLONG_ullDuration, char* lpFormat, char* lpDurationStr, int cchDuration);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AllocConsole();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FreeConsole();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AttachConsole(int dwProcessId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetConsoleCP();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetConsoleOutputCP();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetConsoleMode(cpointer hConsoleHandle, cpointer unfoundType_LPDWORD_lpMode);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetConsoleMode(cpointer hConsoleHandle, int dwMode);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNumberOfConsoleInputEvents(cpointer hConsoleInput, cpointer unfoundType_LPDWORD_lpNumberOfEvents);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadConsoleInputA(cpointer hConsoleInput, cpointer unfoundType_PINPUT_RECORD_lpBuffer, int nLength, cpointer unfoundType_LPDWORD_lpNumberOfEventsRead);
    [DllImport(lib, EntryPoint = "ReadConsoleInputW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadConsoleInput(cpointer hConsoleInput, cpointer unfoundType_PINPUT_RECORD_lpBuffer, int nLength, cpointer unfoundType_LPDWORD_lpNumberOfEventsRead);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadConsoleInputW(cpointer hConsoleInput, cpointer unfoundType_PINPUT_RECORD_lpBuffer, int nLength, cpointer unfoundType_LPDWORD_lpNumberOfEventsRead);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool PeekConsoleInputA(cpointer hConsoleInput, cpointer unfoundType_PINPUT_RECORD_lpBuffer, int nLength, cpointer unfoundType_LPDWORD_lpNumberOfEventsRead);
    [DllImport(lib, EntryPoint = "PeekConsoleInputW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool PeekConsoleInput(cpointer hConsoleInput, cpointer unfoundType_PINPUT_RECORD_lpBuffer, int nLength, cpointer unfoundType_LPDWORD_lpNumberOfEventsRead);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool PeekConsoleInputW(cpointer hConsoleInput, cpointer unfoundType_PINPUT_RECORD_lpBuffer, int nLength, cpointer unfoundType_LPDWORD_lpNumberOfEventsRead);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadConsoleA(cpointer hConsoleInput, cpointer lpBuffer, int nNumberOfCharsToRead, cpointer unfoundType_LPDWORD_lpNumberOfCharsRead, cpointer unfoundType_PCONSOLE_READCONSOLE_CONTROL_pInputControl);
    [DllImport(lib, EntryPoint = "ReadConsoleW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadConsole(cpointer hConsoleInput, cpointer lpBuffer, int nNumberOfCharsToRead, cpointer unfoundType_LPDWORD_lpNumberOfCharsRead, cpointer unfoundType_PCONSOLE_READCONSOLE_CONTROL_pInputControl);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadConsoleW(cpointer hConsoleInput, cpointer lpBuffer, int nNumberOfCharsToRead, cpointer unfoundType_LPDWORD_lpNumberOfCharsRead, cpointer unfoundType_PCONSOLE_READCONSOLE_CONTROL_pInputControl);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteConsoleA(cpointer hConsoleOutput, cpointer lpBuffer, int nNumberOfCharsToWrite, cpointer unfoundType_LPDWORD_lpNumberOfCharsWritten, cpointer lpReserved);
    [DllImport(lib, EntryPoint = "WriteConsoleW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteConsole(cpointer hConsoleOutput, cpointer lpBuffer, int nNumberOfCharsToWrite, cpointer unfoundType_LPDWORD_lpNumberOfCharsWritten, cpointer lpReserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteConsoleW(cpointer hConsoleOutput, cpointer lpBuffer, int nNumberOfCharsToWrite, cpointer unfoundType_LPDWORD_lpNumberOfCharsWritten, cpointer lpReserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetConsoleCtrlHandler(cpointer unfoundType_PHANDLER_ROUTINE_HandlerRoutine, bool Add);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreatePseudoConsole(cpointer unfoundType_COORD_size, cpointer hInput, cpointer hOutput, int dwFlags, cpointer unfoundType_HPCON_phPC);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer ResizePseudoConsole(cpointer unfoundType_HPCON_hPC, cpointer unfoundType_COORD_size);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void ClosePseudoConsole(cpointer unfoundType_HPCON_hPC);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FillConsoleOutputCharacterA(cpointer hConsoleOutput, byte cCharacter, int nLength, cpointer unfoundType_COORD_dwWriteCoord, cpointer unfoundType_LPDWORD_lpNumberOfCharsWritten);
    [DllImport(lib, EntryPoint = "FillConsoleOutputCharacterW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FillConsoleOutputCharacter(cpointer hConsoleOutput, char cCharacter, int nLength, cpointer unfoundType_COORD_dwWriteCoord, cpointer unfoundType_LPDWORD_lpNumberOfCharsWritten);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FillConsoleOutputCharacterW(cpointer hConsoleOutput, char cCharacter, int nLength, cpointer unfoundType_COORD_dwWriteCoord, cpointer unfoundType_LPDWORD_lpNumberOfCharsWritten);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FillConsoleOutputAttribute(cpointer hConsoleOutput, short wAttribute, int nLength, cpointer unfoundType_COORD_dwWriteCoord, cpointer unfoundType_LPDWORD_lpNumberOfAttrsWritten);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GenerateConsoleCtrlEvent(int dwCtrlEvent, int dwProcessGroupId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateConsoleScreenBuffer(int dwDesiredAccess, int dwShareMode, cpointer unfoundType_SECURITY_ATTRIBUTES_lpSecurityAttributes, int dwFlags, cpointer lpScreenBufferData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetConsoleActiveScreenBuffer(cpointer hConsoleOutput);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FlushConsoleInputBuffer(cpointer hConsoleInput);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetConsoleCP(uint wCodePageID);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetConsoleOutputCP(uint wCodePageID);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetConsoleCursorInfo(cpointer hConsoleOutput, cpointer unfoundType_PCONSOLE_CURSOR_INFO_lpConsoleCursorInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetConsoleCursorInfo(cpointer hConsoleOutput, cpointer unfoundType_CONSOLE_CURSOR_INFO_lpConsoleCursorInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetConsoleScreenBufferInfo(cpointer hConsoleOutput, cpointer unfoundType_PCONSOLE_SCREEN_BUFFER_INFO_lpConsoleScreenBufferInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetConsoleScreenBufferInfoEx(cpointer hConsoleOutput, cpointer unfoundType_PCONSOLE_SCREEN_BUFFER_INFOEX_lpConsoleScreenBufferInfoEx);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetConsoleScreenBufferInfoEx(cpointer hConsoleOutput, cpointer unfoundType_PCONSOLE_SCREEN_BUFFER_INFOEX_lpConsoleScreenBufferInfoEx);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetConsoleScreenBufferSize(cpointer hConsoleOutput, cpointer unfoundType_COORD_dwSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetConsoleCursorPosition(cpointer hConsoleOutput, cpointer unfoundType_COORD_dwCursorPosition);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetLargestConsoleWindowSize(cpointer hConsoleOutput);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetConsoleTextAttribute(cpointer hConsoleOutput, short wAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetConsoleWindowInfo(cpointer hConsoleOutput, bool bAbsolute, cpointer unfoundType_SMALL_RECT_lpConsoleWindow);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteConsoleOutputCharacterA(cpointer hConsoleOutput, [MarshalAs(UnmanagedType.LPStr)] string lpCharacter, int nLength, cpointer unfoundType_COORD_dwWriteCoord, cpointer unfoundType_LPDWORD_lpNumberOfCharsWritten);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteConsoleOutputCharacterA(cpointer hConsoleOutput, byte* lpCharacter, int nLength, cpointer unfoundType_COORD_dwWriteCoord, cpointer unfoundType_LPDWORD_lpNumberOfCharsWritten);
    [DllImport(lib, EntryPoint = "WriteConsoleOutputCharacterW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteConsoleOutputCharacter(cpointer hConsoleOutput, [MarshalAs(UnmanagedType.LPWStr)] string lpCharacter, int nLength, cpointer unfoundType_COORD_dwWriteCoord, cpointer unfoundType_LPDWORD_lpNumberOfCharsWritten);
    [DllImport(lib, EntryPoint = "WriteConsoleOutputCharacterW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteConsoleOutputCharacter(cpointer hConsoleOutput, char* lpCharacter, int nLength, cpointer unfoundType_COORD_dwWriteCoord, cpointer unfoundType_LPDWORD_lpNumberOfCharsWritten);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteConsoleOutputCharacterW(cpointer hConsoleOutput, [MarshalAs(UnmanagedType.LPWStr)] string lpCharacter, int nLength, cpointer unfoundType_COORD_dwWriteCoord, cpointer unfoundType_LPDWORD_lpNumberOfCharsWritten);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteConsoleOutputCharacterW(cpointer hConsoleOutput, char* lpCharacter, int nLength, cpointer unfoundType_COORD_dwWriteCoord, cpointer unfoundType_LPDWORD_lpNumberOfCharsWritten);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteConsoleOutputAttribute(cpointer hConsoleOutput, cpointer lpAttribute, int nLength, cpointer unfoundType_COORD_dwWriteCoord, cpointer unfoundType_LPDWORD_lpNumberOfAttrsWritten);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadConsoleOutputCharacterA(cpointer hConsoleOutput, [MarshalAs(UnmanagedType.LPStr)] string lpCharacter, int nLength, cpointer unfoundType_COORD_dwReadCoord, cpointer unfoundType_LPDWORD_lpNumberOfCharsRead);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadConsoleOutputCharacterA(cpointer hConsoleOutput, ReadOnlySpan<byte> lpCharacter, int nLength, cpointer unfoundType_COORD_dwReadCoord, cpointer unfoundType_LPDWORD_lpNumberOfCharsRead);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadConsoleOutputCharacterA(cpointer hConsoleOutput, byte* lpCharacter, int nLength, cpointer unfoundType_COORD_dwReadCoord, cpointer unfoundType_LPDWORD_lpNumberOfCharsRead);
    [DllImport(lib, EntryPoint = "ReadConsoleOutputCharacterW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadConsoleOutputCharacter(cpointer hConsoleOutput, string lpCharacter, int nLength, cpointer unfoundType_COORD_dwReadCoord, cpointer unfoundType_LPDWORD_lpNumberOfCharsRead);
    [DllImport(lib, EntryPoint = "ReadConsoleOutputCharacterW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadConsoleOutputCharacter(cpointer hConsoleOutput, char* lpCharacter, int nLength, cpointer unfoundType_COORD_dwReadCoord, cpointer unfoundType_LPDWORD_lpNumberOfCharsRead);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadConsoleOutputCharacterW(cpointer hConsoleOutput, string lpCharacter, int nLength, cpointer unfoundType_COORD_dwReadCoord, cpointer unfoundType_LPDWORD_lpNumberOfCharsRead);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadConsoleOutputCharacterW(cpointer hConsoleOutput, char* lpCharacter, int nLength, cpointer unfoundType_COORD_dwReadCoord, cpointer unfoundType_LPDWORD_lpNumberOfCharsRead);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadConsoleOutputAttribute(cpointer hConsoleOutput, cpointer unfoundType_LPWORD_lpAttribute, int nLength, cpointer unfoundType_COORD_dwReadCoord, cpointer unfoundType_LPDWORD_lpNumberOfAttrsRead);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteConsoleInputA(cpointer hConsoleInput, cpointer unfoundType_INPUT_RECORD_lpBuffer, int nLength, cpointer unfoundType_LPDWORD_lpNumberOfEventsWritten);
    [DllImport(lib, EntryPoint = "WriteConsoleInputW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteConsoleInput(cpointer hConsoleInput, cpointer unfoundType_INPUT_RECORD_lpBuffer, int nLength, cpointer unfoundType_LPDWORD_lpNumberOfEventsWritten);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteConsoleInputW(cpointer hConsoleInput, cpointer unfoundType_INPUT_RECORD_lpBuffer, int nLength, cpointer unfoundType_LPDWORD_lpNumberOfEventsWritten);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ScrollConsoleScreenBufferA(cpointer hConsoleOutput, cpointer unfoundType_SMALL_RECT_lpScrollRectangle, cpointer unfoundType_SMALL_RECT_lpClipRectangle, cpointer unfoundType_COORD_dwDestinationOrigin, cpointer unfoundType_CHAR_INFO_lpFill);
    [DllImport(lib, EntryPoint = "ScrollConsoleScreenBufferW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ScrollConsoleScreenBuffer(cpointer hConsoleOutput, cpointer unfoundType_SMALL_RECT_lpScrollRectangle, cpointer unfoundType_SMALL_RECT_lpClipRectangle, cpointer unfoundType_COORD_dwDestinationOrigin, cpointer unfoundType_CHAR_INFO_lpFill);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ScrollConsoleScreenBufferW(cpointer hConsoleOutput, cpointer unfoundType_SMALL_RECT_lpScrollRectangle, cpointer unfoundType_SMALL_RECT_lpClipRectangle, cpointer unfoundType_COORD_dwDestinationOrigin, cpointer unfoundType_CHAR_INFO_lpFill);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteConsoleOutputA(cpointer hConsoleOutput, cpointer unfoundType_CHAR_INFO_lpBuffer, cpointer unfoundType_COORD_dwBufferSize, cpointer unfoundType_COORD_dwBufferCoord, cpointer unfoundType_PSMALL_RECT_lpWriteRegion);
    [DllImport(lib, EntryPoint = "WriteConsoleOutputW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteConsoleOutput(cpointer hConsoleOutput, cpointer unfoundType_CHAR_INFO_lpBuffer, cpointer unfoundType_COORD_dwBufferSize, cpointer unfoundType_COORD_dwBufferCoord, cpointer unfoundType_PSMALL_RECT_lpWriteRegion);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteConsoleOutputW(cpointer hConsoleOutput, cpointer unfoundType_CHAR_INFO_lpBuffer, cpointer unfoundType_COORD_dwBufferSize, cpointer unfoundType_COORD_dwBufferCoord, cpointer unfoundType_PSMALL_RECT_lpWriteRegion);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadConsoleOutputA(cpointer hConsoleOutput, cpointer unfoundType_PCHAR_INFO_lpBuffer, cpointer unfoundType_COORD_dwBufferSize, cpointer unfoundType_COORD_dwBufferCoord, cpointer unfoundType_PSMALL_RECT_lpReadRegion);
    [DllImport(lib, EntryPoint = "ReadConsoleOutputW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadConsoleOutput(cpointer hConsoleOutput, cpointer unfoundType_PCHAR_INFO_lpBuffer, cpointer unfoundType_COORD_dwBufferSize, cpointer unfoundType_COORD_dwBufferCoord, cpointer unfoundType_PSMALL_RECT_lpReadRegion);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadConsoleOutputW(cpointer hConsoleOutput, cpointer unfoundType_PCHAR_INFO_lpBuffer, cpointer unfoundType_COORD_dwBufferSize, cpointer unfoundType_COORD_dwBufferCoord, cpointer unfoundType_PSMALL_RECT_lpReadRegion);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleTitleA([MarshalAs(UnmanagedType.LPStr)] string lpConsoleTitle, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleTitleA(ReadOnlySpan<byte> lpConsoleTitle, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleTitleA(byte* lpConsoleTitle, int nSize);
    [DllImport(lib, EntryPoint = "GetConsoleTitleW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleTitle(string lpConsoleTitle, int nSize);
    [DllImport(lib, EntryPoint = "GetConsoleTitleW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleTitle(char* lpConsoleTitle, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleTitleW(string lpConsoleTitle, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleTitleW(char* lpConsoleTitle, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleOriginalTitleA([MarshalAs(UnmanagedType.LPStr)] string lpConsoleTitle, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleOriginalTitleA(ReadOnlySpan<byte> lpConsoleTitle, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleOriginalTitleA(byte* lpConsoleTitle, int nSize);
    [DllImport(lib, EntryPoint = "GetConsoleOriginalTitleW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleOriginalTitle(string lpConsoleTitle, int nSize);
    [DllImport(lib, EntryPoint = "GetConsoleOriginalTitleW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleOriginalTitle(char* lpConsoleTitle, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleOriginalTitleW(string lpConsoleTitle, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleOriginalTitleW(char* lpConsoleTitle, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetConsoleTitleA([MarshalAs(UnmanagedType.LPStr)] string lpConsoleTitle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetConsoleTitleA(byte* lpConsoleTitle);
    [DllImport(lib, EntryPoint = "SetConsoleTitleW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetConsoleTitle([MarshalAs(UnmanagedType.LPWStr)] string lpConsoleTitle);
    [DllImport(lib, EntryPoint = "SetConsoleTitleW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetConsoleTitle(char* lpConsoleTitle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetConsoleTitleW([MarshalAs(UnmanagedType.LPWStr)] string lpConsoleTitle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetConsoleTitleW(char* lpConsoleTitle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNumberOfConsoleMouseButtons(cpointer unfoundType_LPDWORD_lpNumberOfMouseButtons);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetConsoleFontSize(cpointer hConsoleOutput, int nFont);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetCurrentConsoleFont(cpointer hConsoleOutput, bool bMaximumWindow, cpointer unfoundType_PCONSOLE_FONT_INFO_lpConsoleCurrentFont);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetCurrentConsoleFontEx(cpointer hConsoleOutput, bool bMaximumWindow, cpointer unfoundType_PCONSOLE_FONT_INFOEX_lpConsoleCurrentFontEx);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetCurrentConsoleFontEx(cpointer hConsoleOutput, bool bMaximumWindow, cpointer unfoundType_PCONSOLE_FONT_INFOEX_lpConsoleCurrentFontEx);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetConsoleSelectionInfo(cpointer unfoundType_PCONSOLE_SELECTION_INFO_lpConsoleSelectionInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetConsoleHistoryInfo(cpointer unfoundType_PCONSOLE_HISTORY_INFO_lpConsoleHistoryInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetConsoleHistoryInfo(cpointer unfoundType_PCONSOLE_HISTORY_INFO_lpConsoleHistoryInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetConsoleDisplayMode(cpointer unfoundType_LPDWORD_lpModeFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetConsoleDisplayMode(cpointer hConsoleOutput, int dwFlags, cpointer unfoundType_PCOORD_lpNewScreenBufferDimensions);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetConsoleWindow();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAliasA([MarshalAs(UnmanagedType.LPStr)] string Source, [MarshalAs(UnmanagedType.LPStr)] string Target, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAliasA([MarshalAs(UnmanagedType.LPStr)] string Source, [MarshalAs(UnmanagedType.LPStr)] string Target, ReadOnlySpan<byte> ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAliasA([MarshalAs(UnmanagedType.LPStr)] string Source, [MarshalAs(UnmanagedType.LPStr)] string Target, byte* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAliasA([MarshalAs(UnmanagedType.LPStr)] string Source, ReadOnlySpan<byte> Target, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAliasA([MarshalAs(UnmanagedType.LPStr)] string Source, ReadOnlySpan<byte> Target, ReadOnlySpan<byte> ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAliasA([MarshalAs(UnmanagedType.LPStr)] string Source, ReadOnlySpan<byte> Target, byte* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAliasA([MarshalAs(UnmanagedType.LPStr)] string Source, byte* Target, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAliasA([MarshalAs(UnmanagedType.LPStr)] string Source, byte* Target, ReadOnlySpan<byte> ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAliasA([MarshalAs(UnmanagedType.LPStr)] string Source, byte* Target, byte* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAliasA(ReadOnlySpan<byte> Source, [MarshalAs(UnmanagedType.LPStr)] string Target, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAliasA(ReadOnlySpan<byte> Source, [MarshalAs(UnmanagedType.LPStr)] string Target, ReadOnlySpan<byte> ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAliasA(ReadOnlySpan<byte> Source, [MarshalAs(UnmanagedType.LPStr)] string Target, byte* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAliasA(ReadOnlySpan<byte> Source, ReadOnlySpan<byte> Target, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAliasA(ReadOnlySpan<byte> Source, ReadOnlySpan<byte> Target, ReadOnlySpan<byte> ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAliasA(ReadOnlySpan<byte> Source, ReadOnlySpan<byte> Target, byte* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAliasA(ReadOnlySpan<byte> Source, byte* Target, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAliasA(ReadOnlySpan<byte> Source, byte* Target, ReadOnlySpan<byte> ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAliasA(ReadOnlySpan<byte> Source, byte* Target, byte* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAliasA(byte* Source, [MarshalAs(UnmanagedType.LPStr)] string Target, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAliasA(byte* Source, [MarshalAs(UnmanagedType.LPStr)] string Target, ReadOnlySpan<byte> ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAliasA(byte* Source, [MarshalAs(UnmanagedType.LPStr)] string Target, byte* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAliasA(byte* Source, ReadOnlySpan<byte> Target, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAliasA(byte* Source, ReadOnlySpan<byte> Target, ReadOnlySpan<byte> ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAliasA(byte* Source, ReadOnlySpan<byte> Target, byte* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAliasA(byte* Source, byte* Target, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAliasA(byte* Source, byte* Target, ReadOnlySpan<byte> ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAliasA(byte* Source, byte* Target, byte* ExeName);
    [DllImport(lib, EntryPoint = "AddConsoleAliasW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAlias(string Source, string Target, string ExeName);
    [DllImport(lib, EntryPoint = "AddConsoleAliasW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAlias(string Source, string Target, char* ExeName);
    [DllImport(lib, EntryPoint = "AddConsoleAliasW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAlias(string Source, char* Target, string ExeName);
    [DllImport(lib, EntryPoint = "AddConsoleAliasW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAlias(string Source, char* Target, char* ExeName);
    [DllImport(lib, EntryPoint = "AddConsoleAliasW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAlias(char* Source, string Target, string ExeName);
    [DllImport(lib, EntryPoint = "AddConsoleAliasW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAlias(char* Source, string Target, char* ExeName);
    [DllImport(lib, EntryPoint = "AddConsoleAliasW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAlias(char* Source, char* Target, string ExeName);
    [DllImport(lib, EntryPoint = "AddConsoleAliasW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAlias(char* Source, char* Target, char* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAliasW(string Source, string Target, string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAliasW(string Source, string Target, char* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAliasW(string Source, char* Target, string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAliasW(string Source, char* Target, char* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAliasW(char* Source, string Target, string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAliasW(char* Source, string Target, char* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAliasW(char* Source, char* Target, string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddConsoleAliasW(char* Source, char* Target, char* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasA([MarshalAs(UnmanagedType.LPStr)] string Source, [MarshalAs(UnmanagedType.LPStr)] string TargetBuffer, int TargetBufferLength, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasA([MarshalAs(UnmanagedType.LPStr)] string Source, [MarshalAs(UnmanagedType.LPStr)] string TargetBuffer, int TargetBufferLength, ReadOnlySpan<byte> ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasA([MarshalAs(UnmanagedType.LPStr)] string Source, [MarshalAs(UnmanagedType.LPStr)] string TargetBuffer, int TargetBufferLength, byte* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasA([MarshalAs(UnmanagedType.LPStr)] string Source, ReadOnlySpan<byte> TargetBuffer, int TargetBufferLength, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasA([MarshalAs(UnmanagedType.LPStr)] string Source, ReadOnlySpan<byte> TargetBuffer, int TargetBufferLength, ReadOnlySpan<byte> ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasA([MarshalAs(UnmanagedType.LPStr)] string Source, ReadOnlySpan<byte> TargetBuffer, int TargetBufferLength, byte* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasA([MarshalAs(UnmanagedType.LPStr)] string Source, byte* TargetBuffer, int TargetBufferLength, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasA([MarshalAs(UnmanagedType.LPStr)] string Source, byte* TargetBuffer, int TargetBufferLength, ReadOnlySpan<byte> ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasA([MarshalAs(UnmanagedType.LPStr)] string Source, byte* TargetBuffer, int TargetBufferLength, byte* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasA(ReadOnlySpan<byte> Source, [MarshalAs(UnmanagedType.LPStr)] string TargetBuffer, int TargetBufferLength, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasA(ReadOnlySpan<byte> Source, [MarshalAs(UnmanagedType.LPStr)] string TargetBuffer, int TargetBufferLength, ReadOnlySpan<byte> ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasA(ReadOnlySpan<byte> Source, [MarshalAs(UnmanagedType.LPStr)] string TargetBuffer, int TargetBufferLength, byte* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasA(ReadOnlySpan<byte> Source, ReadOnlySpan<byte> TargetBuffer, int TargetBufferLength, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasA(ReadOnlySpan<byte> Source, ReadOnlySpan<byte> TargetBuffer, int TargetBufferLength, ReadOnlySpan<byte> ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasA(ReadOnlySpan<byte> Source, ReadOnlySpan<byte> TargetBuffer, int TargetBufferLength, byte* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasA(ReadOnlySpan<byte> Source, byte* TargetBuffer, int TargetBufferLength, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasA(ReadOnlySpan<byte> Source, byte* TargetBuffer, int TargetBufferLength, ReadOnlySpan<byte> ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasA(ReadOnlySpan<byte> Source, byte* TargetBuffer, int TargetBufferLength, byte* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasA(byte* Source, [MarshalAs(UnmanagedType.LPStr)] string TargetBuffer, int TargetBufferLength, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasA(byte* Source, [MarshalAs(UnmanagedType.LPStr)] string TargetBuffer, int TargetBufferLength, ReadOnlySpan<byte> ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasA(byte* Source, [MarshalAs(UnmanagedType.LPStr)] string TargetBuffer, int TargetBufferLength, byte* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasA(byte* Source, ReadOnlySpan<byte> TargetBuffer, int TargetBufferLength, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasA(byte* Source, ReadOnlySpan<byte> TargetBuffer, int TargetBufferLength, ReadOnlySpan<byte> ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasA(byte* Source, ReadOnlySpan<byte> TargetBuffer, int TargetBufferLength, byte* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasA(byte* Source, byte* TargetBuffer, int TargetBufferLength, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasA(byte* Source, byte* TargetBuffer, int TargetBufferLength, ReadOnlySpan<byte> ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasA(byte* Source, byte* TargetBuffer, int TargetBufferLength, byte* ExeName);
    [DllImport(lib, EntryPoint = "GetConsoleAliasW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAlias(string Source, string TargetBuffer, int TargetBufferLength, string ExeName);
    [DllImport(lib, EntryPoint = "GetConsoleAliasW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAlias(string Source, string TargetBuffer, int TargetBufferLength, char* ExeName);
    [DllImport(lib, EntryPoint = "GetConsoleAliasW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAlias(string Source, char* TargetBuffer, int TargetBufferLength, string ExeName);
    [DllImport(lib, EntryPoint = "GetConsoleAliasW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAlias(string Source, char* TargetBuffer, int TargetBufferLength, char* ExeName);
    [DllImport(lib, EntryPoint = "GetConsoleAliasW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAlias(char* Source, string TargetBuffer, int TargetBufferLength, string ExeName);
    [DllImport(lib, EntryPoint = "GetConsoleAliasW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAlias(char* Source, string TargetBuffer, int TargetBufferLength, char* ExeName);
    [DllImport(lib, EntryPoint = "GetConsoleAliasW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAlias(char* Source, char* TargetBuffer, int TargetBufferLength, string ExeName);
    [DllImport(lib, EntryPoint = "GetConsoleAliasW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAlias(char* Source, char* TargetBuffer, int TargetBufferLength, char* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasW(string Source, string TargetBuffer, int TargetBufferLength, string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasW(string Source, string TargetBuffer, int TargetBufferLength, char* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasW(string Source, char* TargetBuffer, int TargetBufferLength, string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasW(string Source, char* TargetBuffer, int TargetBufferLength, char* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasW(char* Source, string TargetBuffer, int TargetBufferLength, string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasW(char* Source, string TargetBuffer, int TargetBufferLength, char* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasW(char* Source, char* TargetBuffer, int TargetBufferLength, string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasW(char* Source, char* TargetBuffer, int TargetBufferLength, char* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasesLengthA([MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasesLengthA(ReadOnlySpan<byte> ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasesLengthA(byte* ExeName);
    [DllImport(lib, EntryPoint = "GetConsoleAliasesLengthW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasesLength(string ExeName);
    [DllImport(lib, EntryPoint = "GetConsoleAliasesLengthW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasesLength(char* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasesLengthW(string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasesLengthW(char* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasExesLengthA();
    [DllImport(lib, EntryPoint = "GetConsoleAliasExesLengthW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasExesLength();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasExesLengthW();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasesA([MarshalAs(UnmanagedType.LPStr)] string AliasBuffer, int AliasBufferLength, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasesA([MarshalAs(UnmanagedType.LPStr)] string AliasBuffer, int AliasBufferLength, ReadOnlySpan<byte> ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasesA([MarshalAs(UnmanagedType.LPStr)] string AliasBuffer, int AliasBufferLength, byte* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasesA(ReadOnlySpan<byte> AliasBuffer, int AliasBufferLength, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasesA(ReadOnlySpan<byte> AliasBuffer, int AliasBufferLength, ReadOnlySpan<byte> ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasesA(ReadOnlySpan<byte> AliasBuffer, int AliasBufferLength, byte* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasesA(byte* AliasBuffer, int AliasBufferLength, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasesA(byte* AliasBuffer, int AliasBufferLength, ReadOnlySpan<byte> ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasesA(byte* AliasBuffer, int AliasBufferLength, byte* ExeName);
    [DllImport(lib, EntryPoint = "GetConsoleAliasesW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliases(string AliasBuffer, int AliasBufferLength, string ExeName);
    [DllImport(lib, EntryPoint = "GetConsoleAliasesW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliases(string AliasBuffer, int AliasBufferLength, char* ExeName);
    [DllImport(lib, EntryPoint = "GetConsoleAliasesW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliases(char* AliasBuffer, int AliasBufferLength, string ExeName);
    [DllImport(lib, EntryPoint = "GetConsoleAliasesW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliases(char* AliasBuffer, int AliasBufferLength, char* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasesW(string AliasBuffer, int AliasBufferLength, string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasesW(string AliasBuffer, int AliasBufferLength, char* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasesW(char* AliasBuffer, int AliasBufferLength, string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasesW(char* AliasBuffer, int AliasBufferLength, char* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasExesA([MarshalAs(UnmanagedType.LPStr)] string ExeNameBuffer, int ExeNameBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasExesA(ReadOnlySpan<byte> ExeNameBuffer, int ExeNameBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasExesA(byte* ExeNameBuffer, int ExeNameBufferLength);
    [DllImport(lib, EntryPoint = "GetConsoleAliasExesW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasExes(string ExeNameBuffer, int ExeNameBufferLength);
    [DllImport(lib, EntryPoint = "GetConsoleAliasExesW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasExes(char* ExeNameBuffer, int ExeNameBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasExesW(string ExeNameBuffer, int ExeNameBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleAliasExesW(char* ExeNameBuffer, int ExeNameBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void ExpungeConsoleCommandHistoryA([MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void ExpungeConsoleCommandHistoryA(ReadOnlySpan<byte> ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void ExpungeConsoleCommandHistoryA(byte* ExeName);
    [DllImport(lib, EntryPoint = "ExpungeConsoleCommandHistoryW", SetLastError = true, ExactSpelling = true)]
    public static extern
        void ExpungeConsoleCommandHistory(string ExeName);
    [DllImport(lib, EntryPoint = "ExpungeConsoleCommandHistoryW", SetLastError = true, ExactSpelling = true)]
    public static extern
        void ExpungeConsoleCommandHistory(char* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void ExpungeConsoleCommandHistoryW(string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void ExpungeConsoleCommandHistoryW(char* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetConsoleNumberOfCommandsA(int Number, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetConsoleNumberOfCommandsA(int Number, ReadOnlySpan<byte> ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetConsoleNumberOfCommandsA(int Number, byte* ExeName);
    [DllImport(lib, EntryPoint = "SetConsoleNumberOfCommandsW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetConsoleNumberOfCommands(int Number, string ExeName);
    [DllImport(lib, EntryPoint = "SetConsoleNumberOfCommandsW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetConsoleNumberOfCommands(int Number, char* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetConsoleNumberOfCommandsW(int Number, string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetConsoleNumberOfCommandsW(int Number, char* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleCommandHistoryLengthA([MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleCommandHistoryLengthA(ReadOnlySpan<byte> ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleCommandHistoryLengthA(byte* ExeName);
    [DllImport(lib, EntryPoint = "GetConsoleCommandHistoryLengthW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleCommandHistoryLength(string ExeName);
    [DllImport(lib, EntryPoint = "GetConsoleCommandHistoryLengthW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleCommandHistoryLength(char* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleCommandHistoryLengthW(string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleCommandHistoryLengthW(char* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleCommandHistoryA([MarshalAs(UnmanagedType.LPStr)] string Commands, int CommandBufferLength, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleCommandHistoryA([MarshalAs(UnmanagedType.LPStr)] string Commands, int CommandBufferLength, ReadOnlySpan<byte> ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleCommandHistoryA([MarshalAs(UnmanagedType.LPStr)] string Commands, int CommandBufferLength, byte* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleCommandHistoryA(ReadOnlySpan<byte> Commands, int CommandBufferLength, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleCommandHistoryA(ReadOnlySpan<byte> Commands, int CommandBufferLength, ReadOnlySpan<byte> ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleCommandHistoryA(ReadOnlySpan<byte> Commands, int CommandBufferLength, byte* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleCommandHistoryA(byte* Commands, int CommandBufferLength, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleCommandHistoryA(byte* Commands, int CommandBufferLength, ReadOnlySpan<byte> ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleCommandHistoryA(byte* Commands, int CommandBufferLength, byte* ExeName);
    [DllImport(lib, EntryPoint = "GetConsoleCommandHistoryW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleCommandHistory(string Commands, int CommandBufferLength, string ExeName);
    [DllImport(lib, EntryPoint = "GetConsoleCommandHistoryW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleCommandHistory(string Commands, int CommandBufferLength, char* ExeName);
    [DllImport(lib, EntryPoint = "GetConsoleCommandHistoryW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleCommandHistory(char* Commands, int CommandBufferLength, string ExeName);
    [DllImport(lib, EntryPoint = "GetConsoleCommandHistoryW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleCommandHistory(char* Commands, int CommandBufferLength, char* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleCommandHistoryW(string Commands, int CommandBufferLength, string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleCommandHistoryW(string Commands, int CommandBufferLength, char* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleCommandHistoryW(char* Commands, int CommandBufferLength, string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleCommandHistoryW(char* Commands, int CommandBufferLength, char* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetConsoleProcessList(cpointer unfoundType_LPDWORD_lpdwProcessList, int dwProcessCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreatePipe(cpointer unfoundType_PHANDLE_hReadPipe, cpointer unfoundType_PHANDLE_hWritePipe, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpPipeAttributes, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ConnectNamedPipe(cpointer hNamedPipe, cpointer unfoundType_LPOVERLAPPED_lpOverlapped);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DisconnectNamedPipe(cpointer hNamedPipe);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetNamedPipeHandleState(cpointer hNamedPipe, cpointer unfoundType_LPDWORD_lpMode, cpointer unfoundType_LPDWORD_lpMaxCollectionCount, cpointer unfoundType_LPDWORD_lpCollectDataTimeout);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool PeekNamedPipe(cpointer hNamedPipe, cpointer lpBuffer, int nBufferSize, cpointer unfoundType_LPDWORD_lpBytesRead, cpointer unfoundType_LPDWORD_lpTotalBytesAvail, cpointer unfoundType_LPDWORD_lpBytesLeftThisMessage);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool TransactNamedPipe(cpointer hNamedPipe, cpointer lpInBuffer, int nInBufferSize, cpointer lpOutBuffer, int nOutBufferSize, cpointer unfoundType_LPDWORD_lpBytesRead, cpointer unfoundType_LPOVERLAPPED_lpOverlapped);
    [DllImport(lib, EntryPoint = "CreateNamedPipeW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateNamedPipe([MarshalAs(UnmanagedType.LPWStr)] string lpName, int dwOpenMode, int dwPipeMode, int nMaxInstances, int nOutBufferSize, int nInBufferSize, int nDefaultTimeOut, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, EntryPoint = "CreateNamedPipeW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateNamedPipe(char* lpName, int dwOpenMode, int dwPipeMode, int nMaxInstances, int nOutBufferSize, int nInBufferSize, int nDefaultTimeOut, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateNamedPipeW([MarshalAs(UnmanagedType.LPWStr)] string lpName, int dwOpenMode, int dwPipeMode, int nMaxInstances, int nOutBufferSize, int nInBufferSize, int nDefaultTimeOut, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateNamedPipeW(char* lpName, int dwOpenMode, int dwPipeMode, int nMaxInstances, int nOutBufferSize, int nInBufferSize, int nDefaultTimeOut, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, EntryPoint = "WaitNamedPipeW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WaitNamedPipe([MarshalAs(UnmanagedType.LPWStr)] string lpNamedPipeName, int nTimeOut);
    [DllImport(lib, EntryPoint = "WaitNamedPipeW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WaitNamedPipe(char* lpNamedPipeName, int nTimeOut);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WaitNamedPipeW([MarshalAs(UnmanagedType.LPWStr)] string lpNamedPipeName, int nTimeOut);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WaitNamedPipeW(char* lpNamedPipeName, int nTimeOut);
    [DllImport(lib, EntryPoint = "GetNamedPipeClientComputerNameW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNamedPipeClientComputerName(cpointer Pipe, string ClientComputerName, uint ClientComputerNameLength);
    [DllImport(lib, EntryPoint = "GetNamedPipeClientComputerNameW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNamedPipeClientComputerName(cpointer Pipe, char* ClientComputerName, uint ClientComputerNameLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNamedPipeClientComputerNameW(cpointer Pipe, string ClientComputerName, uint ClientComputerNameLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNamedPipeClientComputerNameW(cpointer Pipe, char* ClientComputerName, uint ClientComputerNameLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNamedPipeInfo(cpointer hNamedPipe, cpointer unfoundType_LPDWORD_lpFlags, cpointer unfoundType_LPDWORD_lpOutBufferSize, cpointer unfoundType_LPDWORD_lpInBufferSize, cpointer unfoundType_LPDWORD_lpMaxInstances);
    [DllImport(lib, EntryPoint = "GetNamedPipeHandleStateW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNamedPipeHandleState(cpointer hNamedPipe, cpointer unfoundType_LPDWORD_lpState, cpointer unfoundType_LPDWORD_lpCurInstances, cpointer unfoundType_LPDWORD_lpMaxCollectionCount, cpointer unfoundType_LPDWORD_lpCollectDataTimeout, string lpUserName, int nMaxUserNameSize);
    [DllImport(lib, EntryPoint = "GetNamedPipeHandleStateW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNamedPipeHandleState(cpointer hNamedPipe, cpointer unfoundType_LPDWORD_lpState, cpointer unfoundType_LPDWORD_lpCurInstances, cpointer unfoundType_LPDWORD_lpMaxCollectionCount, cpointer unfoundType_LPDWORD_lpCollectDataTimeout, char* lpUserName, int nMaxUserNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNamedPipeHandleStateW(cpointer hNamedPipe, cpointer unfoundType_LPDWORD_lpState, cpointer unfoundType_LPDWORD_lpCurInstances, cpointer unfoundType_LPDWORD_lpMaxCollectionCount, cpointer unfoundType_LPDWORD_lpCollectDataTimeout, string lpUserName, int nMaxUserNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNamedPipeHandleStateW(cpointer hNamedPipe, cpointer unfoundType_LPDWORD_lpState, cpointer unfoundType_LPDWORD_lpCurInstances, cpointer unfoundType_LPDWORD_lpMaxCollectionCount, cpointer unfoundType_LPDWORD_lpCollectDataTimeout, char* lpUserName, int nMaxUserNameSize);
    [DllImport(lib, EntryPoint = "CallNamedPipeW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CallNamedPipe([MarshalAs(UnmanagedType.LPWStr)] string lpNamedPipeName, cpointer lpInBuffer, int nInBufferSize, cpointer lpOutBuffer, int nOutBufferSize, cpointer unfoundType_LPDWORD_lpBytesRead, int nTimeOut);
    [DllImport(lib, EntryPoint = "CallNamedPipeW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CallNamedPipe(char* lpNamedPipeName, cpointer lpInBuffer, int nInBufferSize, cpointer lpOutBuffer, int nOutBufferSize, cpointer unfoundType_LPDWORD_lpBytesRead, int nTimeOut);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CallNamedPipeW([MarshalAs(UnmanagedType.LPWStr)] string lpNamedPipeName, cpointer lpInBuffer, int nInBufferSize, cpointer lpOutBuffer, int nOutBufferSize, cpointer unfoundType_LPDWORD_lpBytesRead, int nTimeOut);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CallNamedPipeW(char* lpNamedPipeName, cpointer lpInBuffer, int nInBufferSize, cpointer lpOutBuffer, int nOutBufferSize, cpointer unfoundType_LPDWORD_lpBytesRead, int nTimeOut);
    [DllImport(lib, EntryPoint = "CreatePrivateNamespaceW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreatePrivateNamespace(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpPrivateNamespaceAttributes, cpointer lpBoundaryDescriptor, [MarshalAs(UnmanagedType.LPWStr)] string lpAliasPrefix);
    [DllImport(lib, EntryPoint = "CreatePrivateNamespaceW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreatePrivateNamespace(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpPrivateNamespaceAttributes, cpointer lpBoundaryDescriptor, char* lpAliasPrefix);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreatePrivateNamespaceW(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpPrivateNamespaceAttributes, cpointer lpBoundaryDescriptor, [MarshalAs(UnmanagedType.LPWStr)] string lpAliasPrefix);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreatePrivateNamespaceW(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpPrivateNamespaceAttributes, cpointer lpBoundaryDescriptor, char* lpAliasPrefix);
    [DllImport(lib, EntryPoint = "OpenPrivateNamespaceW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenPrivateNamespace(cpointer lpBoundaryDescriptor, [MarshalAs(UnmanagedType.LPWStr)] string lpAliasPrefix);
    [DllImport(lib, EntryPoint = "OpenPrivateNamespaceW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenPrivateNamespace(cpointer lpBoundaryDescriptor, char* lpAliasPrefix);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenPrivateNamespaceW(cpointer lpBoundaryDescriptor, [MarshalAs(UnmanagedType.LPWStr)] string lpAliasPrefix);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenPrivateNamespaceW(cpointer lpBoundaryDescriptor, char* lpAliasPrefix);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer ClosePrivateNamespace(cpointer Handle, uint Flags);
    [DllImport(lib, EntryPoint = "CreateBoundaryDescriptorW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateBoundaryDescriptor([MarshalAs(UnmanagedType.LPWStr)] string Name, uint Flags);
    [DllImport(lib, EntryPoint = "CreateBoundaryDescriptorW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateBoundaryDescriptor(char* Name, uint Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateBoundaryDescriptorW([MarshalAs(UnmanagedType.LPWStr)] string Name, uint Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateBoundaryDescriptorW(char* Name, uint Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddSIDToBoundaryDescriptor(cpointer BoundaryDescriptor, cpointer unfoundType_PSID_RequiredSid);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void DeleteBoundaryDescriptor(cpointer BoundaryDescriptor);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreatePackageVirtualizationContext([MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, cpointer unfoundType_PACKAGE_VIRTUALIZATION_CONTEXT_HANDLE_context);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreatePackageVirtualizationContext(char* packageFamilyName, cpointer unfoundType_PACKAGE_VIRTUALIZATION_CONTEXT_HANDLE_context);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer ActivatePackageVirtualizationContext(cpointer unfoundType_PACKAGE_VIRTUALIZATION_CONTEXT_HANDLE_context, cpointer unfoundType_ULONG_PTR_cookie);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void ReleasePackageVirtualizationContext(cpointer unfoundType_PACKAGE_VIRTUALIZATION_CONTEXT_HANDLE_context);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void DeactivatePackageVirtualizationContext(cpointer unfoundType_ULONG_PTR_cookie);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer DuplicatePackageVirtualizationContext(cpointer unfoundType_PACKAGE_VIRTUALIZATION_CONTEXT_HANDLE_sourceContext, cpointer unfoundType_PACKAGE_VIRTUALIZATION_CONTEXT_HANDLE_destContext);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetCurrentPackageVirtualizationContext();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetProcessesInVirtualizationContext([MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, cpointer count, cpointer processes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetProcessesInVirtualizationContext(char* packageFamilyName, cpointer count, cpointer processes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsDebuggerPresent();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void DebugBreak();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void OutputDebugStringA([MarshalAs(UnmanagedType.LPStr)] string lpOutputString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void OutputDebugStringA(byte* lpOutputString);
    [DllImport(lib, EntryPoint = "OutputDebugStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        void OutputDebugString([MarshalAs(UnmanagedType.LPWStr)] string lpOutputString);
    [DllImport(lib, EntryPoint = "OutputDebugStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        void OutputDebugString(char* lpOutputString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void OutputDebugStringW([MarshalAs(UnmanagedType.LPWStr)] string lpOutputString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void OutputDebugStringW(char* lpOutputString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ContinueDebugEvent(int dwProcessId, int dwThreadId, int dwContinueStatus);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WaitForDebugEvent(cpointer unfoundType_LPDEBUG_EVENT_lpDebugEvent, int dwMilliseconds);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DebugActiveProcess(int dwProcessId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DebugActiveProcessStop(int dwProcessId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckRemoteDebuggerPresent(cpointer hProcess, cpointer pbDebuggerPresent);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WaitForDebugEventEx(cpointer unfoundType_LPDEBUG_EVENT_lpDebugEvent, int dwMilliseconds);
    [DllImport(lib, EntryPoint = "SetEnvironmentStringsW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetEnvironmentStrings(string NewEnvironment);
    [DllImport(lib, EntryPoint = "SetEnvironmentStringsW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetEnvironmentStrings(char* NewEnvironment);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetEnvironmentStringsW(string NewEnvironment);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetEnvironmentStringsW(char* NewEnvironment);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetStdHandle(int nStdHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetStdHandle(int nStdHandle, cpointer hHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetStdHandleEx(int nStdHandle, cpointer hHandle, cpointer unfoundType_PHANDLE_phPrevValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        byte* GetCommandLineA_();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ReadOnlySpan<byte> GetCommandLineA();
    [DllImport(lib, EntryPoint = "GetCommandLineW", SetLastError = true, ExactSpelling = true)]
    public static extern
        char* GetCommandLine_();
    [DllImport(lib, EntryPoint = "GetCommandLineW", SetLastError = true, ExactSpelling = true)]
    public static extern
        string GetCommandLine();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        char* GetCommandLineW_();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        string GetCommandLineW();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetEnvironmentStrings();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        char* GetEnvironmentStringsW_();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        string GetEnvironmentStringsW();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FreeEnvironmentStringsA(cpointer unfoundType_LPCH_penv);
    [DllImport(lib, EntryPoint = "FreeEnvironmentStringsW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FreeEnvironmentStrings(string penv);
    [DllImport(lib, EntryPoint = "FreeEnvironmentStringsW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FreeEnvironmentStrings(char* penv);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FreeEnvironmentStringsW(string penv);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FreeEnvironmentStringsW(char* penv);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetEnvironmentVariableA([MarshalAs(UnmanagedType.LPStr)] string lpName, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetEnvironmentVariableA([MarshalAs(UnmanagedType.LPStr)] string lpName, ReadOnlySpan<byte> lpBuffer, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetEnvironmentVariableA([MarshalAs(UnmanagedType.LPStr)] string lpName, byte* lpBuffer, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetEnvironmentVariableA(byte* lpName, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetEnvironmentVariableA(byte* lpName, ReadOnlySpan<byte> lpBuffer, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetEnvironmentVariableA(byte* lpName, byte* lpBuffer, int nSize);
    [DllImport(lib, EntryPoint = "GetEnvironmentVariableW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetEnvironmentVariable([MarshalAs(UnmanagedType.LPWStr)] string lpName, string lpBuffer, int nSize);
    [DllImport(lib, EntryPoint = "GetEnvironmentVariableW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetEnvironmentVariable([MarshalAs(UnmanagedType.LPWStr)] string lpName, char* lpBuffer, int nSize);
    [DllImport(lib, EntryPoint = "GetEnvironmentVariableW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetEnvironmentVariable(char* lpName, string lpBuffer, int nSize);
    [DllImport(lib, EntryPoint = "GetEnvironmentVariableW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetEnvironmentVariable(char* lpName, char* lpBuffer, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetEnvironmentVariableW([MarshalAs(UnmanagedType.LPWStr)] string lpName, string lpBuffer, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetEnvironmentVariableW([MarshalAs(UnmanagedType.LPWStr)] string lpName, char* lpBuffer, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetEnvironmentVariableW(char* lpName, string lpBuffer, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetEnvironmentVariableW(char* lpName, char* lpBuffer, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetEnvironmentVariableA([MarshalAs(UnmanagedType.LPStr)] string lpName, [MarshalAs(UnmanagedType.LPStr)] string lpValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetEnvironmentVariableA([MarshalAs(UnmanagedType.LPStr)] string lpName, byte* lpValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetEnvironmentVariableA(byte* lpName, [MarshalAs(UnmanagedType.LPStr)] string lpValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetEnvironmentVariableA(byte* lpName, byte* lpValue);
    [DllImport(lib, EntryPoint = "SetEnvironmentVariableW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetEnvironmentVariable([MarshalAs(UnmanagedType.LPWStr)] string lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpValue);
    [DllImport(lib, EntryPoint = "SetEnvironmentVariableW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetEnvironmentVariable([MarshalAs(UnmanagedType.LPWStr)] string lpName, char* lpValue);
    [DllImport(lib, EntryPoint = "SetEnvironmentVariableW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetEnvironmentVariable(char* lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpValue);
    [DllImport(lib, EntryPoint = "SetEnvironmentVariableW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetEnvironmentVariable(char* lpName, char* lpValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetEnvironmentVariableW([MarshalAs(UnmanagedType.LPWStr)] string lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetEnvironmentVariableW([MarshalAs(UnmanagedType.LPWStr)] string lpName, char* lpValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetEnvironmentVariableW(char* lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetEnvironmentVariableW(char* lpName, char* lpValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ExpandEnvironmentStringsA([MarshalAs(UnmanagedType.LPStr)] string lpSrc, [MarshalAs(UnmanagedType.LPStr)] string lpDst, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ExpandEnvironmentStringsA([MarshalAs(UnmanagedType.LPStr)] string lpSrc, ReadOnlySpan<byte> lpDst, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ExpandEnvironmentStringsA([MarshalAs(UnmanagedType.LPStr)] string lpSrc, byte* lpDst, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ExpandEnvironmentStringsA(byte* lpSrc, [MarshalAs(UnmanagedType.LPStr)] string lpDst, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ExpandEnvironmentStringsA(byte* lpSrc, ReadOnlySpan<byte> lpDst, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ExpandEnvironmentStringsA(byte* lpSrc, byte* lpDst, int nSize);
    [DllImport(lib, EntryPoint = "ExpandEnvironmentStringsW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int ExpandEnvironmentStrings([MarshalAs(UnmanagedType.LPWStr)] string lpSrc, string lpDst, int nSize);
    [DllImport(lib, EntryPoint = "ExpandEnvironmentStringsW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int ExpandEnvironmentStrings([MarshalAs(UnmanagedType.LPWStr)] string lpSrc, char* lpDst, int nSize);
    [DllImport(lib, EntryPoint = "ExpandEnvironmentStringsW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int ExpandEnvironmentStrings(char* lpSrc, string lpDst, int nSize);
    [DllImport(lib, EntryPoint = "ExpandEnvironmentStringsW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int ExpandEnvironmentStrings(char* lpSrc, char* lpDst, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ExpandEnvironmentStringsW([MarshalAs(UnmanagedType.LPWStr)] string lpSrc, string lpDst, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ExpandEnvironmentStringsW([MarshalAs(UnmanagedType.LPWStr)] string lpSrc, char* lpDst, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ExpandEnvironmentStringsW(char* lpSrc, string lpDst, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ExpandEnvironmentStringsW(char* lpSrc, char* lpDst, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetCurrentDirectoryA([MarshalAs(UnmanagedType.LPStr)] string lpPathName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetCurrentDirectoryA(byte* lpPathName);
    [DllImport(lib, EntryPoint = "SetCurrentDirectoryW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetCurrentDirectory([MarshalAs(UnmanagedType.LPWStr)] string lpPathName);
    [DllImport(lib, EntryPoint = "SetCurrentDirectoryW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetCurrentDirectory(char* lpPathName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetCurrentDirectoryW([MarshalAs(UnmanagedType.LPWStr)] string lpPathName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetCurrentDirectoryW(char* lpPathName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrentDirectoryA(int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrentDirectoryA(int nBufferLength, ReadOnlySpan<byte> lpBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrentDirectoryA(int nBufferLength, byte* lpBuffer);
    [DllImport(lib, EntryPoint = "GetCurrentDirectoryW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrentDirectory(int nBufferLength, string lpBuffer);
    [DllImport(lib, EntryPoint = "GetCurrentDirectoryW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrentDirectory(int nBufferLength, char* lpBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrentDirectoryW(int nBufferLength, string lpBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrentDirectoryW(int nBufferLength, char* lpBuffer);
    [DllImport(lib, EntryPoint = "SearchPathW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPath([MarshalAs(UnmanagedType.LPWStr)] string lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, string lpBuffer, string lpFilePart);
    [DllImport(lib, EntryPoint = "SearchPathW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPath([MarshalAs(UnmanagedType.LPWStr)] string lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, string lpBuffer, char** lpFilePart);
    [DllImport(lib, EntryPoint = "SearchPathW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPath([MarshalAs(UnmanagedType.LPWStr)] string lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, char* lpBuffer, string lpFilePart);
    [DllImport(lib, EntryPoint = "SearchPathW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPath([MarshalAs(UnmanagedType.LPWStr)] string lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, char* lpBuffer, char** lpFilePart);
    [DllImport(lib, EntryPoint = "SearchPathW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPath([MarshalAs(UnmanagedType.LPWStr)] string lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExtension, int nBufferLength, string lpBuffer, string lpFilePart);
    [DllImport(lib, EntryPoint = "SearchPathW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPath([MarshalAs(UnmanagedType.LPWStr)] string lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExtension, int nBufferLength, string lpBuffer, char** lpFilePart);
    [DllImport(lib, EntryPoint = "SearchPathW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPath([MarshalAs(UnmanagedType.LPWStr)] string lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExtension, int nBufferLength, char* lpBuffer, string lpFilePart);
    [DllImport(lib, EntryPoint = "SearchPathW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPath([MarshalAs(UnmanagedType.LPWStr)] string lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExtension, int nBufferLength, char* lpBuffer, char** lpFilePart);
    [DllImport(lib, EntryPoint = "SearchPathW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPath([MarshalAs(UnmanagedType.LPWStr)] string lpPath, char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, string lpBuffer, string lpFilePart);
    [DllImport(lib, EntryPoint = "SearchPathW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPath([MarshalAs(UnmanagedType.LPWStr)] string lpPath, char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, string lpBuffer, char** lpFilePart);
    [DllImport(lib, EntryPoint = "SearchPathW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPath([MarshalAs(UnmanagedType.LPWStr)] string lpPath, char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, char* lpBuffer, string lpFilePart);
    [DllImport(lib, EntryPoint = "SearchPathW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPath([MarshalAs(UnmanagedType.LPWStr)] string lpPath, char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, char* lpBuffer, char** lpFilePart);
    [DllImport(lib, EntryPoint = "SearchPathW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPath([MarshalAs(UnmanagedType.LPWStr)] string lpPath, char* lpFileName, char* lpExtension, int nBufferLength, string lpBuffer, string lpFilePart);
    [DllImport(lib, EntryPoint = "SearchPathW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPath([MarshalAs(UnmanagedType.LPWStr)] string lpPath, char* lpFileName, char* lpExtension, int nBufferLength, string lpBuffer, char** lpFilePart);
    [DllImport(lib, EntryPoint = "SearchPathW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPath([MarshalAs(UnmanagedType.LPWStr)] string lpPath, char* lpFileName, char* lpExtension, int nBufferLength, char* lpBuffer, string lpFilePart);
    [DllImport(lib, EntryPoint = "SearchPathW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPath([MarshalAs(UnmanagedType.LPWStr)] string lpPath, char* lpFileName, char* lpExtension, int nBufferLength, char* lpBuffer, char** lpFilePart);
    [DllImport(lib, EntryPoint = "SearchPathW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPath(char* lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, string lpBuffer, string lpFilePart);
    [DllImport(lib, EntryPoint = "SearchPathW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPath(char* lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, string lpBuffer, char** lpFilePart);
    [DllImport(lib, EntryPoint = "SearchPathW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPath(char* lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, char* lpBuffer, string lpFilePart);
    [DllImport(lib, EntryPoint = "SearchPathW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPath(char* lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, char* lpBuffer, char** lpFilePart);
    [DllImport(lib, EntryPoint = "SearchPathW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPath(char* lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExtension, int nBufferLength, string lpBuffer, string lpFilePart);
    [DllImport(lib, EntryPoint = "SearchPathW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPath(char* lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExtension, int nBufferLength, string lpBuffer, char** lpFilePart);
    [DllImport(lib, EntryPoint = "SearchPathW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPath(char* lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExtension, int nBufferLength, char* lpBuffer, string lpFilePart);
    [DllImport(lib, EntryPoint = "SearchPathW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPath(char* lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExtension, int nBufferLength, char* lpBuffer, char** lpFilePart);
    [DllImport(lib, EntryPoint = "SearchPathW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPath(char* lpPath, char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, string lpBuffer, string lpFilePart);
    [DllImport(lib, EntryPoint = "SearchPathW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPath(char* lpPath, char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, string lpBuffer, char** lpFilePart);
    [DllImport(lib, EntryPoint = "SearchPathW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPath(char* lpPath, char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, char* lpBuffer, string lpFilePart);
    [DllImport(lib, EntryPoint = "SearchPathW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPath(char* lpPath, char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, char* lpBuffer, char** lpFilePart);
    [DllImport(lib, EntryPoint = "SearchPathW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPath(char* lpPath, char* lpFileName, char* lpExtension, int nBufferLength, string lpBuffer, string lpFilePart);
    [DllImport(lib, EntryPoint = "SearchPathW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPath(char* lpPath, char* lpFileName, char* lpExtension, int nBufferLength, string lpBuffer, char** lpFilePart);
    [DllImport(lib, EntryPoint = "SearchPathW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPath(char* lpPath, char* lpFileName, char* lpExtension, int nBufferLength, char* lpBuffer, string lpFilePart);
    [DllImport(lib, EntryPoint = "SearchPathW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPath(char* lpPath, char* lpFileName, char* lpExtension, int nBufferLength, char* lpBuffer, char** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathW([MarshalAs(UnmanagedType.LPWStr)] string lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, string lpBuffer, string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathW([MarshalAs(UnmanagedType.LPWStr)] string lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, string lpBuffer, char** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathW([MarshalAs(UnmanagedType.LPWStr)] string lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, char* lpBuffer, string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathW([MarshalAs(UnmanagedType.LPWStr)] string lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, char* lpBuffer, char** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathW([MarshalAs(UnmanagedType.LPWStr)] string lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExtension, int nBufferLength, string lpBuffer, string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathW([MarshalAs(UnmanagedType.LPWStr)] string lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExtension, int nBufferLength, string lpBuffer, char** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathW([MarshalAs(UnmanagedType.LPWStr)] string lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExtension, int nBufferLength, char* lpBuffer, string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathW([MarshalAs(UnmanagedType.LPWStr)] string lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExtension, int nBufferLength, char* lpBuffer, char** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathW([MarshalAs(UnmanagedType.LPWStr)] string lpPath, char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, string lpBuffer, string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathW([MarshalAs(UnmanagedType.LPWStr)] string lpPath, char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, string lpBuffer, char** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathW([MarshalAs(UnmanagedType.LPWStr)] string lpPath, char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, char* lpBuffer, string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathW([MarshalAs(UnmanagedType.LPWStr)] string lpPath, char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, char* lpBuffer, char** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathW([MarshalAs(UnmanagedType.LPWStr)] string lpPath, char* lpFileName, char* lpExtension, int nBufferLength, string lpBuffer, string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathW([MarshalAs(UnmanagedType.LPWStr)] string lpPath, char* lpFileName, char* lpExtension, int nBufferLength, string lpBuffer, char** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathW([MarshalAs(UnmanagedType.LPWStr)] string lpPath, char* lpFileName, char* lpExtension, int nBufferLength, char* lpBuffer, string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathW([MarshalAs(UnmanagedType.LPWStr)] string lpPath, char* lpFileName, char* lpExtension, int nBufferLength, char* lpBuffer, char** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathW(char* lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, string lpBuffer, string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathW(char* lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, string lpBuffer, char** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathW(char* lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, char* lpBuffer, string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathW(char* lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, char* lpBuffer, char** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathW(char* lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExtension, int nBufferLength, string lpBuffer, string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathW(char* lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExtension, int nBufferLength, string lpBuffer, char** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathW(char* lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExtension, int nBufferLength, char* lpBuffer, string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathW(char* lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExtension, int nBufferLength, char* lpBuffer, char** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathW(char* lpPath, char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, string lpBuffer, string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathW(char* lpPath, char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, string lpBuffer, char** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathW(char* lpPath, char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, char* lpBuffer, string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathW(char* lpPath, char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, char* lpBuffer, char** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathW(char* lpPath, char* lpFileName, char* lpExtension, int nBufferLength, string lpBuffer, string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathW(char* lpPath, char* lpFileName, char* lpExtension, int nBufferLength, string lpBuffer, char** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathW(char* lpPath, char* lpFileName, char* lpExtension, int nBufferLength, char* lpBuffer, string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathW(char* lpPath, char* lpFileName, char* lpExtension, int nBufferLength, char* lpBuffer, char** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA([MarshalAs(UnmanagedType.LPStr)] string lpPath, [MarshalAs(UnmanagedType.LPStr)] string lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExtension, int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, [MarshalAs(UnmanagedType.LPStr)] string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA([MarshalAs(UnmanagedType.LPStr)] string lpPath, [MarshalAs(UnmanagedType.LPStr)] string lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExtension, int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, ReadOnlySpan<byte> lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA([MarshalAs(UnmanagedType.LPStr)] string lpPath, [MarshalAs(UnmanagedType.LPStr)] string lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExtension, int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, byte** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA([MarshalAs(UnmanagedType.LPStr)] string lpPath, [MarshalAs(UnmanagedType.LPStr)] string lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExtension, int nBufferLength, ReadOnlySpan<byte> lpBuffer, [MarshalAs(UnmanagedType.LPStr)] string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA([MarshalAs(UnmanagedType.LPStr)] string lpPath, [MarshalAs(UnmanagedType.LPStr)] string lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExtension, int nBufferLength, ReadOnlySpan<byte> lpBuffer, ReadOnlySpan<byte> lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA([MarshalAs(UnmanagedType.LPStr)] string lpPath, [MarshalAs(UnmanagedType.LPStr)] string lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExtension, int nBufferLength, ReadOnlySpan<byte> lpBuffer, byte** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA([MarshalAs(UnmanagedType.LPStr)] string lpPath, [MarshalAs(UnmanagedType.LPStr)] string lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExtension, int nBufferLength, byte* lpBuffer, [MarshalAs(UnmanagedType.LPStr)] string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA([MarshalAs(UnmanagedType.LPStr)] string lpPath, [MarshalAs(UnmanagedType.LPStr)] string lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExtension, int nBufferLength, byte* lpBuffer, ReadOnlySpan<byte> lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA([MarshalAs(UnmanagedType.LPStr)] string lpPath, [MarshalAs(UnmanagedType.LPStr)] string lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExtension, int nBufferLength, byte* lpBuffer, byte** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA([MarshalAs(UnmanagedType.LPStr)] string lpPath, [MarshalAs(UnmanagedType.LPStr)] string lpFileName, byte* lpExtension, int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, [MarshalAs(UnmanagedType.LPStr)] string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA([MarshalAs(UnmanagedType.LPStr)] string lpPath, [MarshalAs(UnmanagedType.LPStr)] string lpFileName, byte* lpExtension, int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, ReadOnlySpan<byte> lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA([MarshalAs(UnmanagedType.LPStr)] string lpPath, [MarshalAs(UnmanagedType.LPStr)] string lpFileName, byte* lpExtension, int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, byte** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA([MarshalAs(UnmanagedType.LPStr)] string lpPath, [MarshalAs(UnmanagedType.LPStr)] string lpFileName, byte* lpExtension, int nBufferLength, ReadOnlySpan<byte> lpBuffer, [MarshalAs(UnmanagedType.LPStr)] string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA([MarshalAs(UnmanagedType.LPStr)] string lpPath, [MarshalAs(UnmanagedType.LPStr)] string lpFileName, byte* lpExtension, int nBufferLength, ReadOnlySpan<byte> lpBuffer, ReadOnlySpan<byte> lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA([MarshalAs(UnmanagedType.LPStr)] string lpPath, [MarshalAs(UnmanagedType.LPStr)] string lpFileName, byte* lpExtension, int nBufferLength, ReadOnlySpan<byte> lpBuffer, byte** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA([MarshalAs(UnmanagedType.LPStr)] string lpPath, [MarshalAs(UnmanagedType.LPStr)] string lpFileName, byte* lpExtension, int nBufferLength, byte* lpBuffer, [MarshalAs(UnmanagedType.LPStr)] string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA([MarshalAs(UnmanagedType.LPStr)] string lpPath, [MarshalAs(UnmanagedType.LPStr)] string lpFileName, byte* lpExtension, int nBufferLength, byte* lpBuffer, ReadOnlySpan<byte> lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA([MarshalAs(UnmanagedType.LPStr)] string lpPath, [MarshalAs(UnmanagedType.LPStr)] string lpFileName, byte* lpExtension, int nBufferLength, byte* lpBuffer, byte** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA([MarshalAs(UnmanagedType.LPStr)] string lpPath, byte* lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExtension, int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, [MarshalAs(UnmanagedType.LPStr)] string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA([MarshalAs(UnmanagedType.LPStr)] string lpPath, byte* lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExtension, int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, ReadOnlySpan<byte> lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA([MarshalAs(UnmanagedType.LPStr)] string lpPath, byte* lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExtension, int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, byte** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA([MarshalAs(UnmanagedType.LPStr)] string lpPath, byte* lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExtension, int nBufferLength, ReadOnlySpan<byte> lpBuffer, [MarshalAs(UnmanagedType.LPStr)] string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA([MarshalAs(UnmanagedType.LPStr)] string lpPath, byte* lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExtension, int nBufferLength, ReadOnlySpan<byte> lpBuffer, ReadOnlySpan<byte> lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA([MarshalAs(UnmanagedType.LPStr)] string lpPath, byte* lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExtension, int nBufferLength, ReadOnlySpan<byte> lpBuffer, byte** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA([MarshalAs(UnmanagedType.LPStr)] string lpPath, byte* lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExtension, int nBufferLength, byte* lpBuffer, [MarshalAs(UnmanagedType.LPStr)] string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA([MarshalAs(UnmanagedType.LPStr)] string lpPath, byte* lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExtension, int nBufferLength, byte* lpBuffer, ReadOnlySpan<byte> lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA([MarshalAs(UnmanagedType.LPStr)] string lpPath, byte* lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExtension, int nBufferLength, byte* lpBuffer, byte** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA([MarshalAs(UnmanagedType.LPStr)] string lpPath, byte* lpFileName, byte* lpExtension, int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, [MarshalAs(UnmanagedType.LPStr)] string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA([MarshalAs(UnmanagedType.LPStr)] string lpPath, byte* lpFileName, byte* lpExtension, int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, ReadOnlySpan<byte> lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA([MarshalAs(UnmanagedType.LPStr)] string lpPath, byte* lpFileName, byte* lpExtension, int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, byte** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA([MarshalAs(UnmanagedType.LPStr)] string lpPath, byte* lpFileName, byte* lpExtension, int nBufferLength, ReadOnlySpan<byte> lpBuffer, [MarshalAs(UnmanagedType.LPStr)] string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA([MarshalAs(UnmanagedType.LPStr)] string lpPath, byte* lpFileName, byte* lpExtension, int nBufferLength, ReadOnlySpan<byte> lpBuffer, ReadOnlySpan<byte> lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA([MarshalAs(UnmanagedType.LPStr)] string lpPath, byte* lpFileName, byte* lpExtension, int nBufferLength, ReadOnlySpan<byte> lpBuffer, byte** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA([MarshalAs(UnmanagedType.LPStr)] string lpPath, byte* lpFileName, byte* lpExtension, int nBufferLength, byte* lpBuffer, [MarshalAs(UnmanagedType.LPStr)] string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA([MarshalAs(UnmanagedType.LPStr)] string lpPath, byte* lpFileName, byte* lpExtension, int nBufferLength, byte* lpBuffer, ReadOnlySpan<byte> lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA([MarshalAs(UnmanagedType.LPStr)] string lpPath, byte* lpFileName, byte* lpExtension, int nBufferLength, byte* lpBuffer, byte** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA(byte* lpPath, [MarshalAs(UnmanagedType.LPStr)] string lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExtension, int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, [MarshalAs(UnmanagedType.LPStr)] string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA(byte* lpPath, [MarshalAs(UnmanagedType.LPStr)] string lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExtension, int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, ReadOnlySpan<byte> lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA(byte* lpPath, [MarshalAs(UnmanagedType.LPStr)] string lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExtension, int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, byte** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA(byte* lpPath, [MarshalAs(UnmanagedType.LPStr)] string lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExtension, int nBufferLength, ReadOnlySpan<byte> lpBuffer, [MarshalAs(UnmanagedType.LPStr)] string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA(byte* lpPath, [MarshalAs(UnmanagedType.LPStr)] string lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExtension, int nBufferLength, ReadOnlySpan<byte> lpBuffer, ReadOnlySpan<byte> lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA(byte* lpPath, [MarshalAs(UnmanagedType.LPStr)] string lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExtension, int nBufferLength, ReadOnlySpan<byte> lpBuffer, byte** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA(byte* lpPath, [MarshalAs(UnmanagedType.LPStr)] string lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExtension, int nBufferLength, byte* lpBuffer, [MarshalAs(UnmanagedType.LPStr)] string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA(byte* lpPath, [MarshalAs(UnmanagedType.LPStr)] string lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExtension, int nBufferLength, byte* lpBuffer, ReadOnlySpan<byte> lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA(byte* lpPath, [MarshalAs(UnmanagedType.LPStr)] string lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExtension, int nBufferLength, byte* lpBuffer, byte** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA(byte* lpPath, [MarshalAs(UnmanagedType.LPStr)] string lpFileName, byte* lpExtension, int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, [MarshalAs(UnmanagedType.LPStr)] string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA(byte* lpPath, [MarshalAs(UnmanagedType.LPStr)] string lpFileName, byte* lpExtension, int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, ReadOnlySpan<byte> lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA(byte* lpPath, [MarshalAs(UnmanagedType.LPStr)] string lpFileName, byte* lpExtension, int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, byte** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA(byte* lpPath, [MarshalAs(UnmanagedType.LPStr)] string lpFileName, byte* lpExtension, int nBufferLength, ReadOnlySpan<byte> lpBuffer, [MarshalAs(UnmanagedType.LPStr)] string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA(byte* lpPath, [MarshalAs(UnmanagedType.LPStr)] string lpFileName, byte* lpExtension, int nBufferLength, ReadOnlySpan<byte> lpBuffer, ReadOnlySpan<byte> lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA(byte* lpPath, [MarshalAs(UnmanagedType.LPStr)] string lpFileName, byte* lpExtension, int nBufferLength, ReadOnlySpan<byte> lpBuffer, byte** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA(byte* lpPath, [MarshalAs(UnmanagedType.LPStr)] string lpFileName, byte* lpExtension, int nBufferLength, byte* lpBuffer, [MarshalAs(UnmanagedType.LPStr)] string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA(byte* lpPath, [MarshalAs(UnmanagedType.LPStr)] string lpFileName, byte* lpExtension, int nBufferLength, byte* lpBuffer, ReadOnlySpan<byte> lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA(byte* lpPath, [MarshalAs(UnmanagedType.LPStr)] string lpFileName, byte* lpExtension, int nBufferLength, byte* lpBuffer, byte** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA(byte* lpPath, byte* lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExtension, int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, [MarshalAs(UnmanagedType.LPStr)] string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA(byte* lpPath, byte* lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExtension, int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, ReadOnlySpan<byte> lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA(byte* lpPath, byte* lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExtension, int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, byte** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA(byte* lpPath, byte* lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExtension, int nBufferLength, ReadOnlySpan<byte> lpBuffer, [MarshalAs(UnmanagedType.LPStr)] string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA(byte* lpPath, byte* lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExtension, int nBufferLength, ReadOnlySpan<byte> lpBuffer, ReadOnlySpan<byte> lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA(byte* lpPath, byte* lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExtension, int nBufferLength, ReadOnlySpan<byte> lpBuffer, byte** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA(byte* lpPath, byte* lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExtension, int nBufferLength, byte* lpBuffer, [MarshalAs(UnmanagedType.LPStr)] string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA(byte* lpPath, byte* lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExtension, int nBufferLength, byte* lpBuffer, ReadOnlySpan<byte> lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA(byte* lpPath, byte* lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExtension, int nBufferLength, byte* lpBuffer, byte** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA(byte* lpPath, byte* lpFileName, byte* lpExtension, int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, [MarshalAs(UnmanagedType.LPStr)] string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA(byte* lpPath, byte* lpFileName, byte* lpExtension, int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, ReadOnlySpan<byte> lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA(byte* lpPath, byte* lpFileName, byte* lpExtension, int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, byte** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA(byte* lpPath, byte* lpFileName, byte* lpExtension, int nBufferLength, ReadOnlySpan<byte> lpBuffer, [MarshalAs(UnmanagedType.LPStr)] string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA(byte* lpPath, byte* lpFileName, byte* lpExtension, int nBufferLength, ReadOnlySpan<byte> lpBuffer, ReadOnlySpan<byte> lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA(byte* lpPath, byte* lpFileName, byte* lpExtension, int nBufferLength, ReadOnlySpan<byte> lpBuffer, byte** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA(byte* lpPath, byte* lpFileName, byte* lpExtension, int nBufferLength, byte* lpBuffer, [MarshalAs(UnmanagedType.LPStr)] string lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA(byte* lpPath, byte* lpFileName, byte* lpExtension, int nBufferLength, byte* lpBuffer, ReadOnlySpan<byte> lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SearchPathA(byte* lpPath, byte* lpFileName, byte* lpExtension, int nBufferLength, byte* lpBuffer, byte** lpFilePart);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool NeedCurrentDirectoryForExePathA([MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool NeedCurrentDirectoryForExePathA(byte* ExeName);
    [DllImport(lib, EntryPoint = "NeedCurrentDirectoryForExePathW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool NeedCurrentDirectoryForExePath([MarshalAs(UnmanagedType.LPWStr)] string ExeName);
    [DllImport(lib, EntryPoint = "NeedCurrentDirectoryForExePathW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool NeedCurrentDirectoryForExePath(char* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool NeedCurrentDirectoryForExePathW([MarshalAs(UnmanagedType.LPWStr)] string ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool NeedCurrentDirectoryForExePathW(char* ExeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PssCaptureSnapshot(cpointer ProcessHandle, cpointer unfoundType_PSS_CAPTURE_FLAGS_CaptureFlags, int ThreadContextFlags, cpointer unfoundType_HPSS_SnapshotHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PssFreeSnapshot(cpointer ProcessHandle, cpointer unfoundType_HPSS_SnapshotHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PssQuerySnapshot(cpointer unfoundType_HPSS_SnapshotHandle, cpointer unfoundType_PSS_QUERY_INFORMATION_CLASS_InformationClass, cpointer Buffer, int BufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PssWalkSnapshot(cpointer unfoundType_HPSS_SnapshotHandle, cpointer unfoundType_PSS_WALK_INFORMATION_CLASS_InformationClass, cpointer unfoundType_HPSSWALK_WalkMarkerHandle, cpointer Buffer, int BufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PssDuplicateSnapshot(cpointer SourceProcessHandle, cpointer unfoundType_HPSS_SnapshotHandle, cpointer TargetProcessHandle, cpointer unfoundType_HPSS_TargetSnapshotHandle, cpointer unfoundType_PSS_DUPLICATE_FLAGS_Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PssWalkMarkerCreate(cpointer unfoundType_PSS_ALLOCATORAllocatorAllocator_unnamed_0, cpointer unfoundType_HPSSWALK_WalkMarkerHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PssWalkMarkerFree(cpointer unfoundType_HPSSWALK_WalkMarkerHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PssWalkMarkerGetPosition(cpointer unfoundType_HPSSWALK_WalkMarkerHandle, cpointer unfoundType_ULONG_PTRPositionPosition_unnamed_1);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PssWalkMarkerSetPosition(cpointer unfoundType_HPSSWALK_WalkMarkerHandle, cpointer unfoundType_ULONG_PTR_Position);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PssWalkMarkerSeekToBeginning(cpointer unfoundType_HPSSWALK_WalkMarkerHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int QueueUserAPC(cpointer unfoundType_PAPCFUNC_pfnAPC, cpointer hThread, cpointer unfoundType_ULONG_PTR_dwData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueueUserAPC2(cpointer unfoundType_PAPCFUNC_ApcRoutine, cpointer Thread, cpointer unfoundType_ULONG_PTR_Data, cpointer unfoundType_QUEUE_USER_APC_FLAGS_Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetProcessTimes(cpointer hProcess, cpointer unfoundType_LPFILETIME_lpCreationTime, cpointer unfoundType_LPFILETIME_lpExitTime, cpointer unfoundType_LPFILETIME_lpKernelTime, cpointer unfoundType_LPFILETIME_lpUserTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetCurrentProcess();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrentProcessId();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void ExitProcess(uint uExitCode);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool TerminateProcess(cpointer hProcess, uint uExitCode);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetExitCodeProcess(cpointer hProcess, cpointer unfoundType_LPDWORD_lpExitCode);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SwitchToThread();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateThread(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, cpointer dwStackSize, cpointer unfoundType_LPTHREAD_START_ROUTINE_lpStartAddress, cpointer lpParameter, int dwCreationFlags, cpointer unfoundType_LPDWORD_lpThreadId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateRemoteThread(cpointer hProcess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, cpointer dwStackSize, cpointer unfoundType_LPTHREAD_START_ROUTINE_lpStartAddress, cpointer lpParameter, int dwCreationFlags, cpointer unfoundType_LPDWORD_lpThreadId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetCurrentThread();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrentThreadId();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenThread(int dwDesiredAccess, bool bInheritHandle, int dwThreadId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetThreadPriority(cpointer hThread, int nPriority);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetThreadPriorityBoost(cpointer hThread, bool bDisablePriorityBoost);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetThreadPriorityBoost(cpointer hThread, cpointer pDisablePriorityBoost);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetThreadPriority(cpointer hThread);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void ExitThread(int dwExitCode);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool TerminateThread(cpointer hThread, int dwExitCode);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetExitCodeThread(cpointer hThread, cpointer unfoundType_LPDWORD_lpExitCode);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SuspendThread(cpointer hThread);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ResumeThread(cpointer hThread);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int TlsAlloc();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer TlsGetValue(int dwTlsIndex);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool TlsSetValue(int dwTlsIndex, cpointer lpTlsValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool TlsFree(int dwTlsIndex);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessA([MarshalAs(UnmanagedType.LPStr)] string lpApplicationName, [MarshalAs(UnmanagedType.LPStr)] string lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessA([MarshalAs(UnmanagedType.LPStr)] string lpApplicationName, [MarshalAs(UnmanagedType.LPStr)] string lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, byte* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessA([MarshalAs(UnmanagedType.LPStr)] string lpApplicationName, ReadOnlySpan<byte> lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessA([MarshalAs(UnmanagedType.LPStr)] string lpApplicationName, ReadOnlySpan<byte> lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, byte* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessA([MarshalAs(UnmanagedType.LPStr)] string lpApplicationName, byte* lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessA([MarshalAs(UnmanagedType.LPStr)] string lpApplicationName, byte* lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, byte* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessA(byte* lpApplicationName, [MarshalAs(UnmanagedType.LPStr)] string lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessA(byte* lpApplicationName, [MarshalAs(UnmanagedType.LPStr)] string lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, byte* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessA(byte* lpApplicationName, ReadOnlySpan<byte> lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessA(byte* lpApplicationName, ReadOnlySpan<byte> lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, byte* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessA(byte* lpApplicationName, byte* lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessA(byte* lpApplicationName, byte* lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, byte* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, EntryPoint = "CreateProcessW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcess([MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, string lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, EntryPoint = "CreateProcessW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcess([MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, string lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, char* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, EntryPoint = "CreateProcessW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcess([MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, char* lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, EntryPoint = "CreateProcessW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcess([MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, char* lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, char* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, EntryPoint = "CreateProcessW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcess(char* lpApplicationName, string lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, EntryPoint = "CreateProcessW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcess(char* lpApplicationName, string lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, char* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, EntryPoint = "CreateProcessW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcess(char* lpApplicationName, char* lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, EntryPoint = "CreateProcessW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcess(char* lpApplicationName, char* lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, char* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessW([MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, string lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessW([MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, string lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, char* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessW([MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, char* lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessW([MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, char* lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, char* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessW(char* lpApplicationName, string lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessW(char* lpApplicationName, string lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, char* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessW(char* lpApplicationName, char* lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessW(char* lpApplicationName, char* lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, char* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetProcessShutdownParameters(int dwLevel, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProcessVersion(int ProcessId);
    [DllImport(lib, EntryPoint = "GetStartupInfoW", SetLastError = true, ExactSpelling = true)]
    public static extern
        void GetStartupInfo(cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void GetStartupInfoW(cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo);
    [DllImport(lib, EntryPoint = "CreateProcessAsUserW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUser(cpointer hToken, [MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, string lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, EntryPoint = "CreateProcessAsUserW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUser(cpointer hToken, [MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, string lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, char* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, EntryPoint = "CreateProcessAsUserW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUser(cpointer hToken, [MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, char* lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, EntryPoint = "CreateProcessAsUserW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUser(cpointer hToken, [MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, char* lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, char* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, EntryPoint = "CreateProcessAsUserW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUser(cpointer hToken, char* lpApplicationName, string lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, EntryPoint = "CreateProcessAsUserW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUser(cpointer hToken, char* lpApplicationName, string lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, char* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, EntryPoint = "CreateProcessAsUserW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUser(cpointer hToken, char* lpApplicationName, char* lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, EntryPoint = "CreateProcessAsUserW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUser(cpointer hToken, char* lpApplicationName, char* lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, char* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUserW(cpointer hToken, [MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, string lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUserW(cpointer hToken, [MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, string lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, char* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUserW(cpointer hToken, [MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, char* lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUserW(cpointer hToken, [MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, char* lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, char* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUserW(cpointer hToken, char* lpApplicationName, string lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUserW(cpointer hToken, char* lpApplicationName, string lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, char* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUserW(cpointer hToken, char* lpApplicationName, char* lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUserW(cpointer hToken, char* lpApplicationName, char* lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, char* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetThreadToken(cpointer unfoundType_PHANDLE_Thread, cpointer Token);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool OpenProcessToken(cpointer ProcessHandle, int DesiredAccess, cpointer unfoundType_PHANDLE_TokenHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool OpenThreadToken(cpointer ThreadHandle, int DesiredAccess, bool OpenAsSelf, cpointer unfoundType_PHANDLE_TokenHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetPriorityClass(cpointer hProcess, int dwPriorityClass);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPriorityClass(cpointer hProcess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetThreadStackGuarantee(cpointer unfoundType_PULONG_StackSizeInBytes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ProcessIdToSessionId(int dwProcessId, cpointer pSessionId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProcessId(cpointer Process);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetThreadId(cpointer Thread);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void FlushProcessWriteBuffers();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProcessIdOfThread(cpointer Thread);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool InitializeProcThreadAttributeList(cpointer unfoundType_LPPROC_THREAD_ATTRIBUTE_LIST_lpAttributeList, int dwAttributeCount, int dwFlags, cpointer unfoundType_PSIZE_T_lpSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void DeleteProcThreadAttributeList(cpointer unfoundType_LPPROC_THREAD_ATTRIBUTE_LIST_lpAttributeList);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UpdateProcThreadAttribute(cpointer unfoundType_LPPROC_THREAD_ATTRIBUTE_LIST_lpAttributeList, int dwFlags, cpointer unfoundType_DWORD_PTR_Attribute, cpointer lpValue, cpointer cbSize, cpointer lpPreviousValue, cpointer unfoundType_PSIZE_T_lpReturnSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetProcessDynamicEHContinuationTargets(cpointer Process, ushort NumberOfTargets, cpointer unfoundType_PPROCESS_DYNAMIC_EH_CONTINUATION_TARGET_Targets);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetProcessDynamicEnforcedCetCompatibleRanges(cpointer Process, ushort NumberOfRanges, cpointer unfoundType_PPROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGE_Ranges);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetProcessAffinityUpdateMode(cpointer hProcess, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryProcessAffinityUpdateMode(cpointer hProcess, cpointer unfoundType_LPDWORD_lpdwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateRemoteThreadEx(cpointer hProcess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, cpointer dwStackSize, cpointer unfoundType_LPTHREAD_START_ROUTINE_lpStartAddress, cpointer lpParameter, int dwCreationFlags, cpointer unfoundType_LPPROC_THREAD_ATTRIBUTE_LIST_lpAttributeList, cpointer unfoundType_LPDWORD_lpThreadId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void GetCurrentThreadStackLimits(cpointer LowLimit, cpointer HighLimit);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetThreadContext(cpointer hThread, cpointer unfoundType_LPCONTEXT_lpContext);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetProcessMitigationPolicy(cpointer hProcess, cpointer unfoundType_PROCESS_MITIGATION_POLICY_MitigationPolicy, cpointer lpBuffer, cpointer dwLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetThreadContext(cpointer hThread, cpointer unfoundType_CONTEXT_lpContext);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetProcessMitigationPolicy(cpointer unfoundType_PROCESS_MITIGATION_POLICY_MitigationPolicy, cpointer lpBuffer, cpointer dwLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FlushInstructionCache(cpointer hProcess, cpointer lpBaseAddress, cpointer dwSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetThreadTimes(cpointer hThread, cpointer unfoundType_LPFILETIME_lpCreationTime, cpointer unfoundType_LPFILETIME_lpExitTime, cpointer unfoundType_LPFILETIME_lpKernelTime, cpointer unfoundType_LPFILETIME_lpUserTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsProcessorFeaturePresent(int ProcessorFeature);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetProcessHandleCount(cpointer hProcess, cpointer unfoundType_PDWORD_pdwHandleCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrentProcessorNumber();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetThreadIdealProcessorEx(cpointer hThread, cpointer unfoundType_PPROCESSOR_NUMBER_lpIdealProcessor, cpointer unfoundType_PPROCESSOR_NUMBER_lpPreviousIdealProcessor);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetThreadIdealProcessorEx(cpointer hThread, cpointer unfoundType_PPROCESSOR_NUMBER_lpIdealProcessor);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void GetCurrentProcessorNumberEx(cpointer unfoundType_PPROCESSOR_NUMBER_ProcNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetProcessPriorityBoost(cpointer hProcess, cpointer pDisablePriorityBoost);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetProcessPriorityBoost(cpointer hProcess, bool bDisablePriorityBoost);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetThreadIOPendingFlag(cpointer hThread, cpointer lpIOIsPending);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetSystemTimes(cpointer unfoundType_PFILETIME_lpIdleTime, cpointer unfoundType_PFILETIME_lpKernelTime, cpointer unfoundType_PFILETIME_lpUserTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetThreadInformation(cpointer hThread, cpointer unfoundType_THREAD_INFORMATION_CLASS_ThreadInformationClass, cpointer ThreadInformation, int ThreadInformationSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetThreadInformation(cpointer hThread, cpointer unfoundType_THREAD_INFORMATION_CLASS_ThreadInformationClass, cpointer ThreadInformation, int ThreadInformationSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsProcessCritical(cpointer hProcess, cpointer Critical);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetProtectedPolicy(cpointer unfoundType_LPCGUID_PolicyGuid, cpointer unfoundType_ULONG_PTR_PolicyValue, cpointer OldPolicyValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryProtectedPolicy(cpointer unfoundType_LPCGUID_PolicyGuid, cpointer PolicyValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SetThreadIdealProcessor(cpointer hThread, int dwIdealProcessor);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetProcessInformation(cpointer hProcess, cpointer unfoundType_PROCESS_INFORMATION_CLASS_ProcessInformationClass, cpointer ProcessInformation, int ProcessInformationSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetProcessInformation(cpointer hProcess, cpointer unfoundType_PROCESS_INFORMATION_CLASS_ProcessInformationClass, cpointer ProcessInformation, int ProcessInformationSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetSystemCpuSetInformation(cpointer unfoundType_PSYSTEM_CPU_SET_INFORMATION_Information, uint BufferLength, cpointer unfoundType_PULONG_ReturnedLength, cpointer Process, uint Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetProcessDefaultCpuSets(cpointer Process, cpointer unfoundType_PULONG_CpuSetIds, uint CpuSetIdCount, cpointer unfoundType_PULONG_RequiredIdCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetProcessDefaultCpuSets(cpointer Process, cpointer CpuSetIds, uint CpuSetIdCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetThreadSelectedCpuSets(cpointer Thread, cpointer unfoundType_PULONG_CpuSetIds, uint CpuSetIdCount, cpointer unfoundType_PULONG_RequiredIdCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetThreadSelectedCpuSets(cpointer Thread, cpointer CpuSetIds, uint CpuSetIdCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUserA(cpointer hToken, [MarshalAs(UnmanagedType.LPStr)] string lpApplicationName, [MarshalAs(UnmanagedType.LPStr)] string lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUserA(cpointer hToken, [MarshalAs(UnmanagedType.LPStr)] string lpApplicationName, [MarshalAs(UnmanagedType.LPStr)] string lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, byte* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUserA(cpointer hToken, [MarshalAs(UnmanagedType.LPStr)] string lpApplicationName, ReadOnlySpan<byte> lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUserA(cpointer hToken, [MarshalAs(UnmanagedType.LPStr)] string lpApplicationName, ReadOnlySpan<byte> lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, byte* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUserA(cpointer hToken, [MarshalAs(UnmanagedType.LPStr)] string lpApplicationName, byte* lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUserA(cpointer hToken, [MarshalAs(UnmanagedType.LPStr)] string lpApplicationName, byte* lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, byte* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUserA(cpointer hToken, byte* lpApplicationName, [MarshalAs(UnmanagedType.LPStr)] string lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUserA(cpointer hToken, byte* lpApplicationName, [MarshalAs(UnmanagedType.LPStr)] string lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, byte* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUserA(cpointer hToken, byte* lpApplicationName, ReadOnlySpan<byte> lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUserA(cpointer hToken, byte* lpApplicationName, ReadOnlySpan<byte> lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, byte* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUserA(cpointer hToken, byte* lpApplicationName, byte* lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUserA(cpointer hToken, byte* lpApplicationName, byte* lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, byte* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetProcessShutdownParameters(cpointer unfoundType_LPDWORD_lpdwLevel, cpointer unfoundType_LPDWORD_lpdwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetProcessDefaultCpuSetMasks(cpointer Process, cpointer unfoundType_PGROUP_AFFINITY_CpuSetMasks, ushort CpuSetMaskCount, cpointer unfoundType_PUSHORT_RequiredMaskCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetProcessDefaultCpuSetMasks(cpointer Process, cpointer unfoundType_PGROUP_AFFINITY_CpuSetMasks, ushort CpuSetMaskCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetThreadSelectedCpuSetMasks(cpointer Thread, cpointer unfoundType_PGROUP_AFFINITY_CpuSetMasks, ushort CpuSetMaskCount, cpointer unfoundType_PUSHORT_RequiredMaskCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetThreadSelectedCpuSetMasks(cpointer Thread, cpointer unfoundType_PGROUP_AFFINITY_CpuSetMasks, ushort CpuSetMaskCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetMachineTypeAttributes(ushort Machine, cpointer unfoundType_MACHINE_ATTRIBUTES_MachineTypeAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer SetThreadDescription(cpointer hThread, [MarshalAs(UnmanagedType.LPWStr)] string lpThreadDescription);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer SetThreadDescription(cpointer hThread, char* lpThreadDescription);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetThreadDescription(cpointer hThread, [MarshalAs(UnmanagedType.LPWStr)] string ppszThreadDescription);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetThreadDescription(cpointer hThread, char** ppszThreadDescription);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetProcessGroupAffinity(cpointer hProcess, cpointer unfoundType_PUSHORT_GroupCount, cpointer unfoundType_PUSHORT_GroupArray);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetThreadGroupAffinity(cpointer hThread, cpointer unfoundType_PGROUP_AFFINITY_GroupAffinity);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetThreadGroupAffinity(cpointer hThread, cpointer unfoundType_GROUP_AFFINITY_GroupAffinity, cpointer unfoundType_PGROUP_AFFINITY_PreviousGroupAffinity);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryPerformanceCounter(cpointer unfoundType_LARGE_INTEGER_lpPerformanceCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryPerformanceFrequency(cpointer unfoundType_LARGE_INTEGER_lpFrequency);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryThreadCycleTime(cpointer ThreadHandle, cpointer unfoundType_PULONG64_CycleTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryProcessCycleTime(cpointer ProcessHandle, cpointer unfoundType_PULONG64_CycleTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryIdleProcessorCycleTime(cpointer unfoundType_PULONG_BufferLength, cpointer unfoundType_PULONG64_ProcessorIdleCycleTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryIdleProcessorCycleTimeEx(ushort Group, cpointer unfoundType_PULONG_BufferLength, cpointer unfoundType_PULONG64_ProcessorIdleCycleTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryUnbiasedInterruptTime(cpointer unfoundType_PULONGLONG_UnbiasedTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool OOBEComplete(cpointer isOOBEComplete);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool RegisterWaitUntilOOBECompleted(cpointer unfoundType_OOBE_COMPLETED_CALLBACK_OOBECompletedCallback, cpointer CallbackContext, cpointer WaitHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UnregisterWaitUntilOOBECompleted(cpointer WaitHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetAppContainerNamedObjectPath(cpointer Token, cpointer unfoundType_PSID_AppContainerSid, uint ObjectPathLength, string ObjectPath, cpointer unfoundType_PULONG_ReturnLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetAppContainerNamedObjectPath(cpointer Token, cpointer unfoundType_PSID_AppContainerSid, uint ObjectPathLength, char* ObjectPath, cpointer unfoundType_PULONG_ReturnLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddResourceAttributeAce(cpointer unfoundType_PACL_pAcl, int dwAceRevision, int AceFlags, int AccessMask, cpointer unfoundType_PSID_pSid, cpointer unfoundType_PCLAIM_SECURITY_ATTRIBUTES_INFORMATION_pAttributeInfo, cpointer unfoundType_PDWORD_pReturnLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddScopedPolicyIDAce(cpointer unfoundType_PACL_pAcl, int dwAceRevision, int AceFlags, int AccessMask, cpointer unfoundType_PSID_pSid);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckTokenCapability(cpointer TokenHandle, cpointer unfoundType_PSID_CapabilitySidToCheck, cpointer HasCapability);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetAppContainerAce(cpointer unfoundType_PACL_Acl, int StartingAceIndex, cpointer AppContainerAce, cpointer AppContainerAceIndex);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckTokenMembershipEx(cpointer TokenHandle, cpointer unfoundType_PSID_SidToCheck, int Flags, cpointer IsMember);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetCachedSigningLevel(cpointer unfoundType_PHANDLE_SourceFiles, uint SourceFileCount, uint Flags, cpointer TargetFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetCachedSigningLevel(cpointer File, cpointer unfoundType_PULONG_Flags, cpointer unfoundType_PULONG_SigningLevel, cpointer unfoundType_PUCHAR_Thumbprint, cpointer unfoundType_PULONG_ThumbprintSize, cpointer unfoundType_PULONG_ThumbprintAlgorithm);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CompareStringEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwCmpFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpString1, int cchCount1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2, int cchCount2, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CompareStringEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwCmpFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpString1, int cchCount1, char* lpString2, int cchCount2, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CompareStringEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwCmpFlags, char* lpString1, int cchCount1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2, int cchCount2, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CompareStringEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwCmpFlags, char* lpString1, int cchCount1, char* lpString2, int cchCount2, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CompareStringEx(char* lpLocaleName, int dwCmpFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpString1, int cchCount1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2, int cchCount2, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CompareStringEx(char* lpLocaleName, int dwCmpFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpString1, int cchCount1, char* lpString2, int cchCount2, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CompareStringEx(char* lpLocaleName, int dwCmpFlags, char* lpString1, int cchCount1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2, int cchCount2, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CompareStringEx(char* lpLocaleName, int dwCmpFlags, char* lpString1, int cchCount1, char* lpString2, int cchCount2, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CompareStringOrdinal([MarshalAs(UnmanagedType.LPWStr)] string lpString1, int cchCount1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2, int cchCount2, bool bIgnoreCase);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CompareStringOrdinal([MarshalAs(UnmanagedType.LPWStr)] string lpString1, int cchCount1, char* lpString2, int cchCount2, bool bIgnoreCase);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CompareStringOrdinal(char* lpString1, int cchCount1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2, int cchCount2, bool bIgnoreCase);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CompareStringOrdinal(char* lpString1, int cchCount1, char* lpString2, int cchCount2, bool bIgnoreCase);
    [DllImport(lib, EntryPoint = "CompareStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int CompareString(cpointer unfoundType_LCID_Locale, int dwCmpFlags, string lpString1, int cchCount1, string lpString2, int cchCount2);
    [DllImport(lib, EntryPoint = "CompareStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int CompareString(cpointer unfoundType_LCID_Locale, int dwCmpFlags, string lpString1, int cchCount1, char* lpString2, int cchCount2);
    [DllImport(lib, EntryPoint = "CompareStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int CompareString(cpointer unfoundType_LCID_Locale, int dwCmpFlags, char* lpString1, int cchCount1, string lpString2, int cchCount2);
    [DllImport(lib, EntryPoint = "CompareStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int CompareString(cpointer unfoundType_LCID_Locale, int dwCmpFlags, char* lpString1, int cchCount1, char* lpString2, int cchCount2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CompareStringW(cpointer unfoundType_LCID_Locale, int dwCmpFlags, string lpString1, int cchCount1, string lpString2, int cchCount2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CompareStringW(cpointer unfoundType_LCID_Locale, int dwCmpFlags, string lpString1, int cchCount1, char* lpString2, int cchCount2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CompareStringW(cpointer unfoundType_LCID_Locale, int dwCmpFlags, char* lpString1, int cchCount1, string lpString2, int cchCount2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CompareStringW(cpointer unfoundType_LCID_Locale, int dwCmpFlags, char* lpString1, int cchCount1, char* lpString2, int cchCount2);
    [DllImport(lib, EntryPoint = "FoldStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int FoldString(int dwMapFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, string lpDestStr, int cchDest);
    [DllImport(lib, EntryPoint = "FoldStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int FoldString(int dwMapFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, char* lpDestStr, int cchDest);
    [DllImport(lib, EntryPoint = "FoldStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int FoldString(int dwMapFlags, char* lpSrcStr, int cchSrc, string lpDestStr, int cchDest);
    [DllImport(lib, EntryPoint = "FoldStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int FoldString(int dwMapFlags, char* lpSrcStr, int cchSrc, char* lpDestStr, int cchDest);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FoldStringW(int dwMapFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, string lpDestStr, int cchDest);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FoldStringW(int dwMapFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, char* lpDestStr, int cchDest);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FoldStringW(int dwMapFlags, char* lpSrcStr, int cchSrc, string lpDestStr, int cchDest);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FoldStringW(int dwMapFlags, char* lpSrcStr, int cchSrc, char* lpDestStr, int cchDest);
    [DllImport(lib, EntryPoint = "GetStringTypeExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetStringTypeEx(cpointer unfoundType_LCID_Locale, int dwInfoType, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, cpointer unfoundType_LPWORD_lpCharType);
    [DllImport(lib, EntryPoint = "GetStringTypeExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetStringTypeEx(cpointer unfoundType_LCID_Locale, int dwInfoType, char* lpSrcStr, int cchSrc, cpointer unfoundType_LPWORD_lpCharType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetStringTypeExW(cpointer unfoundType_LCID_Locale, int dwInfoType, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, cpointer unfoundType_LPWORD_lpCharType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetStringTypeExW(cpointer unfoundType_LCID_Locale, int dwInfoType, char* lpSrcStr, int cchSrc, cpointer unfoundType_LPWORD_lpCharType);
    [DllImport(lib, EntryPoint = "GetStringTypeW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetStringType(int dwInfoType, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, cpointer unfoundType_LPWORD_lpCharType);
    [DllImport(lib, EntryPoint = "GetStringTypeW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetStringType(int dwInfoType, char* lpSrcStr, int cchSrc, cpointer unfoundType_LPWORD_lpCharType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetStringTypeW(int dwInfoType, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, cpointer unfoundType_LPWORD_lpCharType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetStringTypeW(int dwInfoType, char* lpSrcStr, int cchSrc, cpointer unfoundType_LPWORD_lpCharType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int MultiByteToWideChar(uint CodePage, int dwFlags, cpointer unfoundType_LPCCH_lpMultiByteStr, int cbMultiByte, string lpWideCharStr, int cchWideChar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int MultiByteToWideChar(uint CodePage, int dwFlags, cpointer unfoundType_LPCCH_lpMultiByteStr, int cbMultiByte, char* lpWideCharStr, int cchWideChar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int WideCharToMultiByte(uint CodePage, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpWideCharStr, int cchWideChar, [MarshalAs(UnmanagedType.LPStr)] string lpMultiByteStr, int cbMultiByte, cpointer unfoundType_LPCCH_lpDefaultChar, cpointer unfoundType_LPBOOL_lpUsedDefaultChar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int WideCharToMultiByte(uint CodePage, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpWideCharStr, int cchWideChar, ReadOnlySpan<byte> lpMultiByteStr, int cbMultiByte, cpointer unfoundType_LPCCH_lpDefaultChar, cpointer unfoundType_LPBOOL_lpUsedDefaultChar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int WideCharToMultiByte(uint CodePage, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpWideCharStr, int cchWideChar, byte* lpMultiByteStr, int cbMultiByte, cpointer unfoundType_LPCCH_lpDefaultChar, cpointer unfoundType_LPBOOL_lpUsedDefaultChar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int WideCharToMultiByte(uint CodePage, int dwFlags, char* lpWideCharStr, int cchWideChar, [MarshalAs(UnmanagedType.LPStr)] string lpMultiByteStr, int cbMultiByte, cpointer unfoundType_LPCCH_lpDefaultChar, cpointer unfoundType_LPBOOL_lpUsedDefaultChar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int WideCharToMultiByte(uint CodePage, int dwFlags, char* lpWideCharStr, int cchWideChar, ReadOnlySpan<byte> lpMultiByteStr, int cbMultiByte, cpointer unfoundType_LPCCH_lpDefaultChar, cpointer unfoundType_LPBOOL_lpUsedDefaultChar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int WideCharToMultiByte(uint CodePage, int dwFlags, char* lpWideCharStr, int cchWideChar, byte* lpMultiByteStr, int cbMultiByte, cpointer unfoundType_LPCCH_lpDefaultChar, cpointer unfoundType_LPBOOL_lpUsedDefaultChar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ushort RtlCaptureStackBackTrace(uint FramesToSkip, uint FramesToCapture, cpointer BackTrace, cpointer unfoundType_PULONG_BackTraceHash);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void RtlCaptureContext(cpointer unfoundType_PCONTEXT_ContextRecord);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void RtlUnwind(cpointer TargetFrame, cpointer TargetIp, cpointer unfoundType_PEXCEPTION_RECORD_ExceptionRecord, cpointer ReturnValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
    public static extern
        cpointer RtlAddFunctionTable(cpointer unfoundType_PRUNTIME_FUNCTION_FunctionTable, uint EntryCount, cpointer unfoundType_ULONG64_BaseAddress);
    [DllImport(lib, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
    public static extern
        cpointer RtlDeleteFunctionTable(cpointer unfoundType_PRUNTIME_FUNCTION_FunctionTable);
    [DllImport(lib, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
    public static extern
        cpointer RtlInstallFunctionTableCallback(cpointer unfoundType_ULONG64_TableIdentifier, cpointer unfoundType_ULONG64_BaseAddress, uint Length, cpointer unfoundType_PGET_RUNTIME_FUNCTION_CALLBACK_Callback, cpointer Context, [MarshalAs(UnmanagedType.LPWStr)] string OutOfProcessCallbackDll);
    [DllImport(lib, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
    public static extern
        cpointer RtlInstallFunctionTableCallback(cpointer unfoundType_ULONG64_TableIdentifier, cpointer unfoundType_ULONG64_BaseAddress, uint Length, cpointer unfoundType_PGET_RUNTIME_FUNCTION_CALLBACK_Callback, cpointer Context, char* OutOfProcessCallbackDll);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RtlLookupFunctionEntry(cpointer unfoundType_ULONG64_ControlPc, cpointer unfoundType_PULONG64_ImageBase, cpointer unfoundType_PUNWIND_HISTORY_TABLE_HistoryTable);
    [DllImport(lib, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
    public static extern
        void RtlRestoreContext(cpointer unfoundType_PCONTEXT_ContextRecord, cpointer unfoundType__EXCEPTION_RECORD_ExceptionRecord);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void RtlUnwindEx(cpointer TargetFrame, cpointer TargetIp, cpointer unfoundType_PEXCEPTION_RECORD_ExceptionRecord, cpointer ReturnValue, cpointer unfoundType_PCONTEXT_ContextRecord, cpointer unfoundType_PUNWIND_HISTORY_TABLE_HistoryTable);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RtlVirtualUnwind(uint HandlerType, cpointer unfoundType_ULONG64_ImageBase, cpointer unfoundType_ULONG64_ControlPc, cpointer unfoundType_PRUNTIME_FUNCTION_FunctionEntry, cpointer unfoundType_PCONTEXT_ContextRecord, cpointer HandlerData, cpointer unfoundType_PULONG64_EstablisherFrame, cpointer unfoundType_PKNONVOLATILE_CONTEXT_POINTERS_ContextPointers);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RtlVirtualUnwind2(uint HandlerType, cpointer unfoundType_ULONG64_ImageBase, cpointer unfoundType_ULONG64_ControlPc, cpointer unfoundType_PRUNTIME_FUNCTION_FunctionEntry, cpointer unfoundType_PCONTEXT_ContextRecord, cpointer unfoundType_PBOOLEAN_MachineFrameUnwound, cpointer HandlerData, cpointer unfoundType_PULONG64_EstablisherFrame, cpointer unfoundType_PKNONVOLATILE_CONTEXT_POINTERS_ContextPointers, cpointer unfoundType_PULONG64_LowLimit, cpointer unfoundType_PULONG64_HighLimit, cpointer unfoundType_PEXCEPTION_ROUTINE_HandlerRoutine, uint UnwindFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RtlIsEcCode(cpointer unfoundType_ULONG64_CodePointer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void RtlRaiseException(cpointer unfoundType_PEXCEPTION_RECORD_ExceptionRecord);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RtlPcToFileHeader(cpointer PcValue, cpointer BaseOfImage);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint* RtlCompareMemory(cpointer Source1, cpointer Source2, cpointer Length);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNumaHighestNodeNumber(cpointer unfoundType_PULONG_HighestNodeNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNumaNodeProcessorMaskEx(ushort Node, cpointer unfoundType_PGROUP_AFFINITY_ProcessorMask);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNumaNodeProcessorMask2(ushort NodeNumber, cpointer unfoundType_PGROUP_AFFINITY_ProcessorMasks, ushort ProcessorMaskCount, cpointer unfoundType_PUSHORT_RequiredMaskCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNumaProximityNodeEx(uint ProximityId, cpointer unfoundType_PUSHORT_NodeNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateThreadpool(cpointer reserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void SetThreadpoolThreadMaximum(cpointer unfoundType_PTP_POOL_ptpp, int cthrdMost);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetThreadpoolThreadMinimum(cpointer unfoundType_PTP_POOL_ptpp, int cthrdMic);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetThreadpoolStackInformation(cpointer unfoundType_PTP_POOL_ptpp, cpointer unfoundType_PTP_POOL_STACK_INFORMATION_ptpsi);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryThreadpoolStackInformation(cpointer unfoundType_PTP_POOL_ptpp, cpointer unfoundType_PTP_POOL_STACK_INFORMATION_ptpsi);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void CloseThreadpool(cpointer unfoundType_PTP_POOL_ptpp);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateThreadpoolCleanupGroup();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void CloseThreadpoolCleanupGroupMembers(cpointer unfoundType_PTP_CLEANUP_GROUP_ptpcg, bool fCancelPendingCallbacks, cpointer pvCleanupContext);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void CloseThreadpoolCleanupGroup(cpointer unfoundType_PTP_CLEANUP_GROUP_ptpcg);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void SetEventWhenCallbackReturns(cpointer unfoundType_PTP_CALLBACK_INSTANCE_pci, cpointer evt);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void ReleaseSemaphoreWhenCallbackReturns(cpointer unfoundType_PTP_CALLBACK_INSTANCE_pci, cpointer sem, int crel);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void ReleaseMutexWhenCallbackReturns(cpointer unfoundType_PTP_CALLBACK_INSTANCE_pci, cpointer mut);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void LeaveCriticalSectionWhenCallbackReturns(cpointer unfoundType_PTP_CALLBACK_INSTANCE_pci, cpointer unfoundType_PCRITICAL_SECTION_pcs);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void FreeLibraryWhenCallbackReturns(cpointer unfoundType_PTP_CALLBACK_INSTANCE_pci, cpointer unfoundType_HMODULE_mod);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CallbackMayRunLong(cpointer unfoundType_PTP_CALLBACK_INSTANCE_pci);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void DisassociateCurrentThreadFromCallback(cpointer unfoundType_PTP_CALLBACK_INSTANCE_pci);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool TrySubmitThreadpoolCallback(cpointer unfoundType_PTP_SIMPLE_CALLBACK_pfns, cpointer pv, cpointer unfoundType_PTP_CALLBACK_ENVIRON_pcbe);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateThreadpoolWork(cpointer unfoundType_PTP_WORK_CALLBACK_pfnwk, cpointer pv, cpointer unfoundType_PTP_CALLBACK_ENVIRON_pcbe);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void SubmitThreadpoolWork(cpointer unfoundType_PTP_WORK_pwk);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void WaitForThreadpoolWorkCallbacks(cpointer unfoundType_PTP_WORK_pwk, bool fCancelPendingCallbacks);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void CloseThreadpoolWork(cpointer unfoundType_PTP_WORK_pwk);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateThreadpoolTimer(cpointer unfoundType_PTP_TIMER_CALLBACK_pfnti, cpointer pv, cpointer unfoundType_PTP_CALLBACK_ENVIRON_pcbe);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void SetThreadpoolTimer(cpointer unfoundType_PTP_TIMER_pti, cpointer unfoundType_PFILETIME_pftDueTime, int msPeriod, int msWindowLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsThreadpoolTimerSet(cpointer unfoundType_PTP_TIMER_pti);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void WaitForThreadpoolTimerCallbacks(cpointer unfoundType_PTP_TIMER_pti, bool fCancelPendingCallbacks);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void CloseThreadpoolTimer(cpointer unfoundType_PTP_TIMER_pti);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateThreadpoolWait(cpointer unfoundType_PTP_WAIT_CALLBACK_pfnwa, cpointer pv, cpointer unfoundType_PTP_CALLBACK_ENVIRON_pcbe);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void SetThreadpoolWait(cpointer unfoundType_PTP_WAIT_pwa, cpointer h, cpointer unfoundType_PFILETIME_pftTimeout);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void WaitForThreadpoolWaitCallbacks(cpointer unfoundType_PTP_WAIT_pwa, bool fCancelPendingCallbacks);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void CloseThreadpoolWait(cpointer unfoundType_PTP_WAIT_pwa);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateThreadpoolIo(cpointer fl, cpointer unfoundType_PTP_WIN32_IO_CALLBACK_pfnio, cpointer pv, cpointer unfoundType_PTP_CALLBACK_ENVIRON_pcbe);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void StartThreadpoolIo(cpointer unfoundType_PTP_IO_pio);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void CancelThreadpoolIo(cpointer unfoundType_PTP_IO_pio);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void WaitForThreadpoolIoCallbacks(cpointer unfoundType_PTP_IO_pio, bool fCancelPendingCallbacks);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void CloseThreadpoolIo(cpointer unfoundType_PTP_IO_pio);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetThreadpoolTimerEx(cpointer unfoundType_PTP_TIMER_pti, cpointer unfoundType_PFILETIME_pftDueTime, int msPeriod, int msWindowLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetThreadpoolWaitEx(cpointer unfoundType_PTP_WAIT_pwa, cpointer h, cpointer unfoundType_PFILETIME_pftTimeout, cpointer Reserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueueUserWorkItem(cpointer unfoundType_LPTHREAD_START_ROUTINE_Function, cpointer Context, uint Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UnregisterWaitEx(cpointer WaitHandle, cpointer CompletionEvent);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateTimerQueue();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateTimerQueueTimer(cpointer unfoundType_PHANDLE_phNewTimer, cpointer TimerQueue, cpointer unfoundType_WAITORTIMERCALLBACK_Callback, cpointer Parameter, int DueTime, int Period, uint Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ChangeTimerQueueTimer(cpointer TimerQueue, cpointer Timer, uint DueTime, uint Period);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DeleteTimerQueueTimer(cpointer TimerQueue, cpointer Timer, cpointer CompletionEvent);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DeleteTimerQueue(cpointer TimerQueue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DeleteTimerQueueEx(cpointer TimerQueue, cpointer CompletionEvent);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer timeGetSystemTime(cpointer unfoundType_LPMMTIME_pmmt, uint cbmmt);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int timeGetTime();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer timeGetDevCaps(cpointer unfoundType_LPTIMECAPS_ptc, uint cbtc);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer timeBeginPeriod(uint uPeriod);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer timeEndPeriod(uint uPeriod);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SystemTimeToTzSpecificLocalTime(cpointer unfoundType_TIME_ZONE_INFORMATION_lpTimeZoneInformation, cpointer unfoundType_SYSTEMTIME_lpUniversalTime, cpointer unfoundType_LPSYSTEMTIME_lpLocalTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool TzSpecificLocalTimeToSystemTime(cpointer unfoundType_TIME_ZONE_INFORMATION_lpTimeZoneInformation, cpointer unfoundType_SYSTEMTIME_lpLocalTime, cpointer unfoundType_LPSYSTEMTIME_lpUniversalTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FileTimeToSystemTime(cpointer unfoundType_FILETIME_lpFileTime, cpointer unfoundType_LPSYSTEMTIME_lpSystemTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SystemTimeToFileTime(cpointer unfoundType_SYSTEMTIME_lpSystemTime, cpointer unfoundType_LPFILETIME_lpFileTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeZoneInformation(cpointer unfoundType_LPTIME_ZONE_INFORMATION_lpTimeZoneInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetTimeZoneInformation(cpointer unfoundType_TIME_ZONE_INFORMATION_lpTimeZoneInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetDynamicTimeZoneInformation(cpointer unfoundType_DYNAMIC_TIME_ZONE_INFORMATION_lpTimeZoneInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDynamicTimeZoneInformation(cpointer unfoundType_PDYNAMIC_TIME_ZONE_INFORMATION_pTimeZoneInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetTimeZoneInformationForYear(ushort wYear, cpointer unfoundType_PDYNAMIC_TIME_ZONE_INFORMATION_pdtzi, cpointer unfoundType_LPTIME_ZONE_INFORMATION_ptzi);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SystemTimeToTzSpecificLocalTimeEx(cpointer unfoundType_DYNAMIC_TIME_ZONE_INFORMATION_lpTimeZoneInformation, cpointer unfoundType_SYSTEMTIME_lpUniversalTime, cpointer unfoundType_LPSYSTEMTIME_lpLocalTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool TzSpecificLocalTimeToSystemTimeEx(cpointer unfoundType_DYNAMIC_TIME_ZONE_INFORMATION_lpTimeZoneInformation, cpointer unfoundType_SYSTEMTIME_lpLocalTime, cpointer unfoundType_LPSYSTEMTIME_lpUniversalTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool LocalFileTimeToLocalSystemTime(cpointer unfoundType_TIME_ZONE_INFORMATION_timeZoneInformation, cpointer unfoundType_FILETIME_localFileTime, cpointer unfoundType_SYSTEMTIME_localSystemTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool LocalSystemTimeToLocalFileTime(cpointer unfoundType_TIME_ZONE_INFORMATION_timeZoneInformation, cpointer unfoundType_SYSTEMTIME_localSystemTime, cpointer unfoundType_FILETIME_localFileTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateToolhelp32Snapshot(int dwFlags, int th32ProcessID);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool Heap32ListFirst(cpointer hSnapshot, cpointer unfoundType_LPHEAPLIST32_lphl);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool Heap32ListNext(cpointer hSnapshot, cpointer unfoundType_LPHEAPLIST32_lphl);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool Heap32First(cpointer unfoundType_LPHEAPENTRY32_lphe, int th32ProcessID, cpointer unfoundType_ULONG_PTR_th32HeapID);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool Heap32Next(cpointer unfoundType_LPHEAPENTRY32_lphe);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool Toolhelp32ReadProcessMemory(int th32ProcessID, cpointer lpBaseAddress, cpointer lpBuffer, cpointer cbRead, cpointer lpNumberOfBytesRead);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool Process32FirstW(cpointer hSnapshot, cpointer unfoundType_LPPROCESSENTRY32W_lppe);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool Process32NextW(cpointer hSnapshot, cpointer unfoundType_LPPROCESSENTRY32W_lppe);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool Process32First(cpointer hSnapshot, cpointer unfoundType_LPPROCESSENTRY32_lppe);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool Process32Next(cpointer hSnapshot, cpointer unfoundType_LPPROCESSENTRY32_lppe);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool Thread32First(cpointer hSnapshot, cpointer unfoundType_LPTHREADENTRY32_lpte);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool Thread32Next(cpointer hSnapshot, cpointer unfoundType_LPTHREADENTRY32_lpte);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool Module32FirstW(cpointer hSnapshot, cpointer unfoundType_LPMODULEENTRY32W_lpme);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool Module32NextW(cpointer hSnapshot, cpointer unfoundType_LPMODULEENTRY32W_lpme);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool Module32First(cpointer hSnapshot, cpointer unfoundType_LPMODULEENTRY32_lpme);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool Module32Next(cpointer hSnapshot, cpointer unfoundType_LPMODULEENTRY32_lpme);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void InitializeSRWLock(cpointer unfoundType_PSRWLOCK_SRWLock);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void ReleaseSRWLockExclusive(cpointer unfoundType_PSRWLOCK_SRWLock);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void ReleaseSRWLockShared(cpointer unfoundType_PSRWLOCK_SRWLock);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void AcquireSRWLockExclusive(cpointer unfoundType_PSRWLOCK_SRWLock);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void AcquireSRWLockShared(cpointer unfoundType_PSRWLOCK_SRWLock);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer TryAcquireSRWLockExclusive(cpointer unfoundType_PSRWLOCK_SRWLock);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer TryAcquireSRWLockShared(cpointer unfoundType_PSRWLOCK_SRWLock);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void InitializeCriticalSection(cpointer unfoundType_LPCRITICAL_SECTION_lpCriticalSection);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void EnterCriticalSection(cpointer unfoundType_LPCRITICAL_SECTION_lpCriticalSection);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void LeaveCriticalSection(cpointer unfoundType_LPCRITICAL_SECTION_lpCriticalSection);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool InitializeCriticalSectionAndSpinCount(cpointer unfoundType_LPCRITICAL_SECTION_lpCriticalSection, int dwSpinCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool InitializeCriticalSectionEx(cpointer unfoundType_LPCRITICAL_SECTION_lpCriticalSection, int dwSpinCount, int Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SetCriticalSectionSpinCount(cpointer unfoundType_LPCRITICAL_SECTION_lpCriticalSection, int dwSpinCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool TryEnterCriticalSection(cpointer unfoundType_LPCRITICAL_SECTION_lpCriticalSection);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void DeleteCriticalSection(cpointer unfoundType_LPCRITICAL_SECTION_lpCriticalSection);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void InitOnceInitialize(cpointer unfoundType_PINIT_ONCE_InitOnce);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool InitOnceExecuteOnce(cpointer unfoundType_PINIT_ONCE_InitOnce, cpointer unfoundType_PINIT_ONCE_FN_InitFn, cpointer Parameter, cpointer Context);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool InitOnceBeginInitialize(cpointer unfoundType_LPINIT_ONCE_lpInitOnce, int dwFlags, cpointer fPending, cpointer lpContext);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool InitOnceComplete(cpointer unfoundType_LPINIT_ONCE_lpInitOnce, int dwFlags, cpointer lpContext);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void InitializeConditionVariable(cpointer unfoundType_PCONDITION_VARIABLE_ConditionVariable);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void WakeConditionVariable(cpointer unfoundType_PCONDITION_VARIABLE_ConditionVariable);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void WakeAllConditionVariable(cpointer unfoundType_PCONDITION_VARIABLE_ConditionVariable);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SleepConditionVariableCS(cpointer unfoundType_PCONDITION_VARIABLE_ConditionVariable, cpointer unfoundType_PCRITICAL_SECTION_CriticalSection, int dwMilliseconds);
    [DllImport(lib, EntryPoint = "SleepConditionVariableSRW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SleepConditionVariableSR(cpointer unfoundType_PCONDITION_VARIABLE_ConditionVariable, cpointer unfoundType_PSRWLOCK_SRWLock, int dwMilliseconds, uint Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SleepConditionVariableSRW(cpointer unfoundType_PCONDITION_VARIABLE_ConditionVariable, cpointer unfoundType_PSRWLOCK_SRWLock, int dwMilliseconds, uint Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetEvent(cpointer hEvent);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ResetEvent(cpointer hEvent);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReleaseSemaphore(cpointer hSemaphore, int lReleaseCount, cpointer unfoundType_LPLONG_lpPreviousCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReleaseMutex(cpointer hMutex);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int WaitForSingleObject(cpointer hHandle, int dwMilliseconds);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SleepEx(int dwMilliseconds, bool bAlertable);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int WaitForSingleObjectEx(cpointer hHandle, int dwMilliseconds, bool bAlertable);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int WaitForMultipleObjectsEx(int nCount, cpointer lpHandles, bool bWaitAll, int dwMilliseconds, bool bAlertable);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateMutexA(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpMutexAttributes, bool bInitialOwner, [MarshalAs(UnmanagedType.LPStr)] string lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateMutexA(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpMutexAttributes, bool bInitialOwner, byte* lpName);
    [DllImport(lib, EntryPoint = "CreateMutexW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateMutex(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpMutexAttributes, bool bInitialOwner, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport(lib, EntryPoint = "CreateMutexW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateMutex(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpMutexAttributes, bool bInitialOwner, char* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateMutexW(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpMutexAttributes, bool bInitialOwner, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateMutexW(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpMutexAttributes, bool bInitialOwner, char* lpName);
    [DllImport(lib, EntryPoint = "OpenMutexW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenMutex(int dwDesiredAccess, bool bInheritHandle, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport(lib, EntryPoint = "OpenMutexW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenMutex(int dwDesiredAccess, bool bInheritHandle, char* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenMutexW(int dwDesiredAccess, bool bInheritHandle, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenMutexW(int dwDesiredAccess, bool bInheritHandle, char* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateEventA(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpEventAttributes, bool bManualReset, bool bInitialState, [MarshalAs(UnmanagedType.LPStr)] string lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateEventA(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpEventAttributes, bool bManualReset, bool bInitialState, byte* lpName);
    [DllImport(lib, EntryPoint = "CreateEventW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateEvent(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpEventAttributes, bool bManualReset, bool bInitialState, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport(lib, EntryPoint = "CreateEventW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateEvent(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpEventAttributes, bool bManualReset, bool bInitialState, char* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateEventW(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpEventAttributes, bool bManualReset, bool bInitialState, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateEventW(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpEventAttributes, bool bManualReset, bool bInitialState, char* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenEventA(int dwDesiredAccess, bool bInheritHandle, [MarshalAs(UnmanagedType.LPStr)] string lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenEventA(int dwDesiredAccess, bool bInheritHandle, byte* lpName);
    [DllImport(lib, EntryPoint = "OpenEventW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenEvent(int dwDesiredAccess, bool bInheritHandle, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport(lib, EntryPoint = "OpenEventW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenEvent(int dwDesiredAccess, bool bInheritHandle, char* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenEventW(int dwDesiredAccess, bool bInheritHandle, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenEventW(int dwDesiredAccess, bool bInheritHandle, char* lpName);
    [DllImport(lib, EntryPoint = "OpenSemaphoreW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenSemaphore(int dwDesiredAccess, bool bInheritHandle, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport(lib, EntryPoint = "OpenSemaphoreW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenSemaphore(int dwDesiredAccess, bool bInheritHandle, char* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenSemaphoreW(int dwDesiredAccess, bool bInheritHandle, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenSemaphoreW(int dwDesiredAccess, bool bInheritHandle, char* lpName);
    [DllImport(lib, EntryPoint = "OpenWaitableTimerW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenWaitableTimer(int dwDesiredAccess, bool bInheritHandle, [MarshalAs(UnmanagedType.LPWStr)] string lpTimerName);
    [DllImport(lib, EntryPoint = "OpenWaitableTimerW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenWaitableTimer(int dwDesiredAccess, bool bInheritHandle, char* lpTimerName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenWaitableTimerW(int dwDesiredAccess, bool bInheritHandle, [MarshalAs(UnmanagedType.LPWStr)] string lpTimerName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenWaitableTimerW(int dwDesiredAccess, bool bInheritHandle, char* lpTimerName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetWaitableTimerEx(cpointer hTimer, cpointer unfoundType_LARGE_INTEGER_lpDueTime, int lPeriod, cpointer unfoundType_PTIMERAPCROUTINE_pfnCompletionRoutine, cpointer lpArgToCompletionRoutine, cpointer unfoundType_PREASON_CONTEXT_WakeContext, uint TolerableDelay);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetWaitableTimer(cpointer hTimer, cpointer unfoundType_LARGE_INTEGER_lpDueTime, int lPeriod, cpointer unfoundType_PTIMERAPCROUTINE_pfnCompletionRoutine, cpointer lpArgToCompletionRoutine, bool fResume);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CancelWaitableTimer(cpointer hTimer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateMutexExA(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpMutexAttributes, [MarshalAs(UnmanagedType.LPStr)] string lpName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateMutexExA(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpMutexAttributes, byte* lpName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, EntryPoint = "CreateMutexExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateMutexEx(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpMutexAttributes, [MarshalAs(UnmanagedType.LPWStr)] string lpName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, EntryPoint = "CreateMutexExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateMutexEx(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpMutexAttributes, char* lpName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateMutexExW(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpMutexAttributes, [MarshalAs(UnmanagedType.LPWStr)] string lpName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateMutexExW(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpMutexAttributes, char* lpName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateEventExA(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpEventAttributes, [MarshalAs(UnmanagedType.LPStr)] string lpName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateEventExA(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpEventAttributes, byte* lpName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, EntryPoint = "CreateEventExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateEventEx(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpEventAttributes, [MarshalAs(UnmanagedType.LPWStr)] string lpName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, EntryPoint = "CreateEventExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateEventEx(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpEventAttributes, char* lpName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateEventExW(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpEventAttributes, [MarshalAs(UnmanagedType.LPWStr)] string lpName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateEventExW(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpEventAttributes, char* lpName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, EntryPoint = "CreateSemaphoreExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateSemaphoreEx(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, [MarshalAs(UnmanagedType.LPWStr)] string lpName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, EntryPoint = "CreateSemaphoreExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateSemaphoreEx(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, char* lpName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateSemaphoreExW(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, [MarshalAs(UnmanagedType.LPWStr)] string lpName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateSemaphoreExW(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, char* lpName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, EntryPoint = "CreateWaitableTimerExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateWaitableTimerEx(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpTimerAttributes, [MarshalAs(UnmanagedType.LPWStr)] string lpTimerName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, EntryPoint = "CreateWaitableTimerExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateWaitableTimerEx(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpTimerAttributes, char* lpTimerName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateWaitableTimerExW(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpTimerAttributes, [MarshalAs(UnmanagedType.LPWStr)] string lpTimerName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateWaitableTimerExW(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpTimerAttributes, char* lpTimerName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnterSynchronizationBarrier(cpointer unfoundType_LPSYNCHRONIZATION_BARRIER_lpBarrier, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool InitializeSynchronizationBarrier(cpointer unfoundType_LPSYNCHRONIZATION_BARRIER_lpBarrier, int lTotalThreads, int lSpinCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DeleteSynchronizationBarrier(cpointer unfoundType_LPSYNCHRONIZATION_BARRIER_lpBarrier);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void Sleep(int dwMilliseconds);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SignalObjectAndWait(cpointer hObjectToSignal, cpointer hObjectToWaitOn, int dwMilliseconds, bool bAlertable);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int WaitForMultipleObjects(int nCount, cpointer lpHandles, bool bWaitAll, int dwMilliseconds);
    [DllImport(lib, EntryPoint = "CreateSemaphoreW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateSemaphore(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport(lib, EntryPoint = "CreateSemaphoreW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateSemaphore(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, char* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateSemaphoreW(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateSemaphoreW(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, char* lpName);
    [DllImport(lib, EntryPoint = "CreateWaitableTimerW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateWaitableTimer(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpTimerAttributes, bool bManualReset, [MarshalAs(UnmanagedType.LPWStr)] string lpTimerName);
    [DllImport(lib, EntryPoint = "CreateWaitableTimerW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateWaitableTimer(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpTimerAttributes, bool bManualReset, char* lpTimerName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateWaitableTimerW(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpTimerAttributes, bool bManualReset, [MarshalAs(UnmanagedType.LPWStr)] string lpTimerName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateWaitableTimerW(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpTimerAttributes, bool bManualReset, char* lpTimerName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GlobalMemoryStatusEx(cpointer unfoundType_LPMEMORYSTATUSEX_lpBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void GetSystemInfo(cpointer unfoundType_LPSYSTEM_INFO_lpSystemInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void GetSystemTime(cpointer unfoundType_LPSYSTEMTIME_lpSystemTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void GetSystemTimeAsFileTime(cpointer unfoundType_LPFILETIME_lpSystemTimeAsFileTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void GetLocalTime(cpointer unfoundType_LPSYSTEMTIME_lpSystemTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsUserCetAvailableInEnvironment(int UserCetEnvironment);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetVersion();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetLocalTime(cpointer unfoundType_SYSTEMTIME_lpSystemTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTickCount();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetTickCount64();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetSystemTimeAdjustment(cpointer unfoundType_PDWORD_lpTimeAdjustment, cpointer unfoundType_PDWORD_lpTimeIncrement, cpointer lpTimeAdjustmentDisabled);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetSystemDirectoryA([MarshalAs(UnmanagedType.LPStr)] string lpBuffer, uint uSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetSystemDirectoryA(ReadOnlySpan<byte> lpBuffer, uint uSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetSystemDirectoryA(byte* lpBuffer, uint uSize);
    [DllImport(lib, EntryPoint = "GetSystemDirectoryW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetSystemDirectory(string lpBuffer, uint uSize);
    [DllImport(lib, EntryPoint = "GetSystemDirectoryW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetSystemDirectory(char* lpBuffer, uint uSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetSystemDirectoryW(string lpBuffer, uint uSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetSystemDirectoryW(char* lpBuffer, uint uSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetWindowsDirectoryA([MarshalAs(UnmanagedType.LPStr)] string lpBuffer, uint uSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetWindowsDirectoryA(ReadOnlySpan<byte> lpBuffer, uint uSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetWindowsDirectoryA(byte* lpBuffer, uint uSize);
    [DllImport(lib, EntryPoint = "GetWindowsDirectoryW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetWindowsDirectory(string lpBuffer, uint uSize);
    [DllImport(lib, EntryPoint = "GetWindowsDirectoryW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetWindowsDirectory(char* lpBuffer, uint uSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetWindowsDirectoryW(string lpBuffer, uint uSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetWindowsDirectoryW(char* lpBuffer, uint uSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetSystemWindowsDirectoryA([MarshalAs(UnmanagedType.LPStr)] string lpBuffer, uint uSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetSystemWindowsDirectoryA(ReadOnlySpan<byte> lpBuffer, uint uSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetSystemWindowsDirectoryA(byte* lpBuffer, uint uSize);
    [DllImport(lib, EntryPoint = "GetSystemWindowsDirectoryW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetSystemWindowsDirectory(string lpBuffer, uint uSize);
    [DllImport(lib, EntryPoint = "GetSystemWindowsDirectoryW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetSystemWindowsDirectory(char* lpBuffer, uint uSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetSystemWindowsDirectoryW(string lpBuffer, uint uSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetSystemWindowsDirectoryW(char* lpBuffer, uint uSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetComputerNameExA(cpointer unfoundType_COMPUTER_NAME_FORMAT_NameType, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, cpointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetComputerNameExA(cpointer unfoundType_COMPUTER_NAME_FORMAT_NameType, ReadOnlySpan<byte> lpBuffer, cpointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetComputerNameExA(cpointer unfoundType_COMPUTER_NAME_FORMAT_NameType, byte* lpBuffer, cpointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, EntryPoint = "GetComputerNameExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetComputerNameEx(cpointer unfoundType_COMPUTER_NAME_FORMAT_NameType, string lpBuffer, cpointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, EntryPoint = "GetComputerNameExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetComputerNameEx(cpointer unfoundType_COMPUTER_NAME_FORMAT_NameType, char* lpBuffer, cpointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetComputerNameExW(cpointer unfoundType_COMPUTER_NAME_FORMAT_NameType, string lpBuffer, cpointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetComputerNameExW(cpointer unfoundType_COMPUTER_NAME_FORMAT_NameType, char* lpBuffer, cpointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, EntryPoint = "SetComputerNameExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetComputerNameEx(cpointer unfoundType_COMPUTER_NAME_FORMAT_NameType, [MarshalAs(UnmanagedType.LPWStr)] string lpBuffer);
    [DllImport(lib, EntryPoint = "SetComputerNameExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetComputerNameEx(cpointer unfoundType_COMPUTER_NAME_FORMAT_NameType, char* lpBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetComputerNameExW(cpointer unfoundType_COMPUTER_NAME_FORMAT_NameType, [MarshalAs(UnmanagedType.LPWStr)] string lpBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetComputerNameExW(cpointer unfoundType_COMPUTER_NAME_FORMAT_NameType, char* lpBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetSystemTime(cpointer unfoundType_SYSTEMTIME_lpSystemTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVersionExA(cpointer unfoundType_LPOSVERSIONINFOA_lpVersionInformation);
    [DllImport(lib, EntryPoint = "GetVersionExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVersionEx(cpointer unfoundType_LPOSVERSIONINFOW_lpVersionInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVersionExW(cpointer unfoundType_LPOSVERSIONINFOW_lpVersionInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetLogicalProcessorInformation(cpointer unfoundType_PSYSTEM_LOGICAL_PROCESSOR_INFORMATION_Buffer, cpointer unfoundType_PDWORD_ReturnedLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetLogicalProcessorInformationEx(cpointer unfoundType_LOGICAL_PROCESSOR_RELATIONSHIP_RelationshipType, cpointer unfoundType_PSYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX_Buffer, cpointer unfoundType_PDWORD_ReturnedLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void GetNativeSystemInfo(cpointer unfoundType_LPSYSTEM_INFO_lpSystemInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void GetSystemTimePreciseAsFileTime(cpointer unfoundType_LPFILETIME_lpSystemTimeAsFileTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetProductInfo(int dwOSMajorVersion, int dwOSMinorVersion, int dwSpMajorVersion, int dwSpMinorVersion, cpointer unfoundType_PDWORD_pdwReturnedProductType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer VerSetConditionMask(cpointer unfoundType_ULONGLONG_ConditionMask, uint TypeMask, byte Condition);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint EnumSystemFirmwareTables(int FirmwareTableProviderSignature, cpointer pFirmwareTableEnumBuffer, int BufferSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetSystemFirmwareTable(int FirmwareTableProviderSignature, int FirmwareTableID, cpointer pFirmwareTableBuffer, int BufferSize);
    [DllImport(lib, EntryPoint = "DnsHostnameToComputerNameExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerNameEx([MarshalAs(UnmanagedType.LPWStr)] string Hostname, string ComputerName, cpointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, EntryPoint = "DnsHostnameToComputerNameExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerNameEx([MarshalAs(UnmanagedType.LPWStr)] string Hostname, char* ComputerName, cpointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, EntryPoint = "DnsHostnameToComputerNameExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerNameEx(char* Hostname, string ComputerName, cpointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, EntryPoint = "DnsHostnameToComputerNameExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerNameEx(char* Hostname, char* ComputerName, cpointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerNameExW([MarshalAs(UnmanagedType.LPWStr)] string Hostname, string ComputerName, cpointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerNameExW([MarshalAs(UnmanagedType.LPWStr)] string Hostname, char* ComputerName, cpointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerNameExW(char* Hostname, string ComputerName, cpointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerNameExW(char* Hostname, char* ComputerName, cpointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPhysicallyInstalledSystemMemory(cpointer unfoundType_PULONGLONG_TotalMemoryInKilobytes);
    [DllImport(lib, EntryPoint = "SetComputerNameEx2W", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetComputerNameEx2(cpointer unfoundType_COMPUTER_NAME_FORMAT_NameType, int Flags, [MarshalAs(UnmanagedType.LPWStr)] string lpBuffer);
    [DllImport(lib, EntryPoint = "SetComputerNameEx2W", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetComputerNameEx2(cpointer unfoundType_COMPUTER_NAME_FORMAT_NameType, int Flags, char* lpBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetComputerNameEx2W(cpointer unfoundType_COMPUTER_NAME_FORMAT_NameType, int Flags, [MarshalAs(UnmanagedType.LPWStr)] string lpBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetComputerNameEx2W(cpointer unfoundType_COMPUTER_NAME_FORMAT_NameType, int Flags, char* lpBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetSystemTimeAdjustment(int dwTimeAdjustment, bool bTimeAdjustmentDisabled);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool InstallELAMCertificateInfo(cpointer ELAMFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetProcessorSystemCycleTime(ushort Group, cpointer unfoundType_PSYSTEM_PROCESSOR_CYCLE_TIME_INFORMATION_Buffer, cpointer unfoundType_PDWORD_ReturnedLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetComputerNameA([MarshalAs(UnmanagedType.LPStr)] string lpComputerName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetComputerNameA(byte* lpComputerName);
    [DllImport(lib, EntryPoint = "SetComputerNameW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetComputerName([MarshalAs(UnmanagedType.LPWStr)] string lpComputerName);
    [DllImport(lib, EntryPoint = "SetComputerNameW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetComputerName(char* lpComputerName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetComputerNameW([MarshalAs(UnmanagedType.LPWStr)] string lpComputerName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetComputerNameW(char* lpComputerName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetComputerNameExA(cpointer unfoundType_COMPUTER_NAME_FORMAT_NameType, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetComputerNameExA(cpointer unfoundType_COMPUTER_NAME_FORMAT_NameType, byte* lpBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer EncodePointer(cpointer Ptr);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer DecodePointer(cpointer Ptr);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer EncodeSystemPointer(cpointer Ptr);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer DecodeSystemPointer(cpointer Ptr);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool Beep(int dwFreq, int dwDuration);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer WerRegisterFile([MarshalAs(UnmanagedType.LPWStr)] string pwzFile, cpointer unfoundType_WER_REGISTER_FILE_TYPE_regFileType, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer WerRegisterFile(char* pwzFile, cpointer unfoundType_WER_REGISTER_FILE_TYPE_regFileType, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer WerUnregisterFile([MarshalAs(UnmanagedType.LPWStr)] string pwzFilePath);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer WerUnregisterFile(char* pwzFilePath);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer WerRegisterMemoryBlock(cpointer pvAddress, int dwSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer WerUnregisterMemoryBlock(cpointer pvAddress);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer WerRegisterExcludedMemoryBlock(cpointer address, int size);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer WerUnregisterExcludedMemoryBlock(cpointer address);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer WerRegisterCustomMetadata([MarshalAs(UnmanagedType.LPWStr)] string key, [MarshalAs(UnmanagedType.LPWStr)] string value);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer WerRegisterCustomMetadata([MarshalAs(UnmanagedType.LPWStr)] string key, char* value);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer WerRegisterCustomMetadata(char* key, [MarshalAs(UnmanagedType.LPWStr)] string value);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer WerRegisterCustomMetadata(char* key, char* value);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer WerUnregisterCustomMetadata([MarshalAs(UnmanagedType.LPWStr)] string key);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer WerUnregisterCustomMetadata(char* key);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer WerRegisterAdditionalProcess(int processId, int captureExtraInfoForThreadId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer WerUnregisterAdditionalProcess(int processId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer WerRegisterAppLocalDump([MarshalAs(UnmanagedType.LPWStr)] string localAppDataRelativePath);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer WerRegisterAppLocalDump(char* localAppDataRelativePath);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer WerUnregisterAppLocalDump();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer WerSetFlags(int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer WerGetFlags(cpointer hProcess, cpointer unfoundType_PDWORD_pdwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer WerRegisterRuntimeExceptionModule([MarshalAs(UnmanagedType.LPWStr)] string pwszOutOfProcessCallbackDll, cpointer pContext);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer WerRegisterRuntimeExceptionModule(char* pwszOutOfProcessCallbackDll, cpointer pContext);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer WerUnregisterRuntimeExceptionModule([MarshalAs(UnmanagedType.LPWStr)] string pwszOutOfProcessCallbackDll, cpointer pContext);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer WerUnregisterRuntimeExceptionModule(char* pwszOutOfProcessCallbackDll, cpointer pContext);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GlobalAlloc(uint uFlags, cpointer dwBytes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GlobalReAlloc(cpointer unfoundType_HGLOBAL_hMem, cpointer dwBytes, uint uFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint* GlobalSize(cpointer unfoundType_HGLOBAL_hMem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GlobalUnlock(cpointer unfoundType_HGLOBAL_hMem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GlobalLock(cpointer unfoundType_HGLOBAL_hMem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GlobalFlags(cpointer unfoundType_HGLOBAL_hMem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GlobalHandle(cpointer pMem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GlobalFree(cpointer unfoundType_HGLOBAL_hMem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint* GlobalCompact(int dwMinFree);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void GlobalFix(cpointer unfoundType_HGLOBAL_hMem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void GlobalUnfix(cpointer unfoundType_HGLOBAL_hMem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GlobalWire(cpointer unfoundType_HGLOBAL_hMem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GlobalUnWire(cpointer unfoundType_HGLOBAL_hMem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void GlobalMemoryStatus(cpointer unfoundType_LPMEMORYSTATUS_lpBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer LocalAlloc(uint uFlags, cpointer uBytes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer LocalReAlloc(cpointer unfoundType_HLOCAL_hMem, cpointer uBytes, uint uFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer LocalLock(cpointer unfoundType_HLOCAL_hMem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer LocalHandle(cpointer pMem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool LocalUnlock(cpointer unfoundType_HLOCAL_hMem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint* LocalSize(cpointer unfoundType_HLOCAL_hMem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint LocalFlags(cpointer unfoundType_HLOCAL_hMem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer LocalFree(cpointer unfoundType_HLOCAL_hMem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint* LocalShrink(cpointer unfoundType_HLOCAL_hMem, uint cbNewSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint* LocalCompact(uint uMinFree);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetBinaryTypeA([MarshalAs(UnmanagedType.LPStr)] string lpApplicationName, cpointer unfoundType_LPDWORD_lpBinaryType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetBinaryTypeA(byte* lpApplicationName, cpointer unfoundType_LPDWORD_lpBinaryType);
    [DllImport(lib, EntryPoint = "GetBinaryTypeW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetBinaryType([MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, cpointer unfoundType_LPDWORD_lpBinaryType);
    [DllImport(lib, EntryPoint = "GetBinaryTypeW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetBinaryType(char* lpApplicationName, cpointer unfoundType_LPDWORD_lpBinaryType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetBinaryTypeW([MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, cpointer unfoundType_LPDWORD_lpBinaryType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetBinaryTypeW(char* lpApplicationName, cpointer unfoundType_LPDWORD_lpBinaryType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetShortPathNameA([MarshalAs(UnmanagedType.LPStr)] string lpszLongPath, [MarshalAs(UnmanagedType.LPStr)] string lpszShortPath, int cchBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetShortPathNameA([MarshalAs(UnmanagedType.LPStr)] string lpszLongPath, ReadOnlySpan<byte> lpszShortPath, int cchBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetShortPathNameA([MarshalAs(UnmanagedType.LPStr)] string lpszLongPath, byte* lpszShortPath, int cchBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetShortPathNameA(byte* lpszLongPath, [MarshalAs(UnmanagedType.LPStr)] string lpszShortPath, int cchBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetShortPathNameA(byte* lpszLongPath, ReadOnlySpan<byte> lpszShortPath, int cchBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetShortPathNameA(byte* lpszLongPath, byte* lpszShortPath, int cchBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLongPathNameTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpszShortPath, [MarshalAs(UnmanagedType.LPStr)] string lpszLongPath, int cchBuffer, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLongPathNameTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpszShortPath, ReadOnlySpan<byte> lpszLongPath, int cchBuffer, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLongPathNameTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpszShortPath, byte* lpszLongPath, int cchBuffer, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLongPathNameTransactedA(byte* lpszShortPath, [MarshalAs(UnmanagedType.LPStr)] string lpszLongPath, int cchBuffer, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLongPathNameTransactedA(byte* lpszShortPath, ReadOnlySpan<byte> lpszLongPath, int cchBuffer, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLongPathNameTransactedA(byte* lpszShortPath, byte* lpszLongPath, int cchBuffer, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "GetLongPathNameTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLongPathNameTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpszShortPath, string lpszLongPath, int cchBuffer, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "GetLongPathNameTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLongPathNameTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpszShortPath, char* lpszLongPath, int cchBuffer, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "GetLongPathNameTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLongPathNameTransacted(char* lpszShortPath, string lpszLongPath, int cchBuffer, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "GetLongPathNameTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLongPathNameTransacted(char* lpszShortPath, char* lpszLongPath, int cchBuffer, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLongPathNameTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpszShortPath, string lpszLongPath, int cchBuffer, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLongPathNameTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpszShortPath, char* lpszLongPath, int cchBuffer, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLongPathNameTransactedW(char* lpszShortPath, string lpszLongPath, int cchBuffer, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLongPathNameTransactedW(char* lpszShortPath, char* lpszLongPath, int cchBuffer, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetProcessAffinityMask(cpointer hProcess, cpointer unfoundType_PDWORD_PTR_lpProcessAffinityMask, cpointer unfoundType_PDWORD_PTR_lpSystemAffinityMask);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetProcessAffinityMask(cpointer hProcess, cpointer unfoundType_DWORD_PTR_dwProcessAffinityMask);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetProcessIoCounters(cpointer hProcess, cpointer unfoundType_PIO_COUNTERS_lpIoCounters);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void FatalExit(int ExitCode);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetEnvironmentStringsA(cpointer unfoundType_LPCH_NewEnvironment);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void SwitchToFiber(cpointer lpFiber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void DeleteFiber(cpointer lpFiber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ConvertFiberToThread();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateFiberEx(cpointer dwStackCommitSize, cpointer dwStackReserveSize, int dwFlags, cpointer unfoundType_LPFIBER_START_ROUTINE_lpStartAddress, cpointer lpParameter);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer ConvertThreadToFiberEx(cpointer lpParameter, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateFiber(cpointer dwStackSize, cpointer unfoundType_LPFIBER_START_ROUTINE_lpStartAddress, cpointer lpParameter);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer ConvertThreadToFiber(cpointer lpParameter);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateUmsCompletionList(cpointer unfoundType_PUMS_COMPLETION_LIST_UmsCompletionList);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DequeueUmsCompletionListItems(cpointer unfoundType_PUMS_COMPLETION_LIST_UmsCompletionList, int WaitTimeOut, cpointer unfoundType_PUMS_CONTEXT_UmsThreadList);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetUmsCompletionListEvent(cpointer unfoundType_PUMS_COMPLETION_LIST_UmsCompletionList, cpointer unfoundType_PHANDLE_UmsCompletionEvent);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ExecuteUmsThread(cpointer unfoundType_PUMS_CONTEXT_UmsThread);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UmsThreadYield(cpointer SchedulerParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DeleteUmsCompletionList(cpointer unfoundType_PUMS_COMPLETION_LIST_UmsCompletionList);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetCurrentUmsThread();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetNextUmsListItem(cpointer unfoundType_PUMS_CONTEXT_UmsContext);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryUmsThreadInformation(cpointer unfoundType_PUMS_CONTEXT_UmsThread, cpointer unfoundType_UMS_THREAD_INFO_CLASS_UmsThreadInfoClass, cpointer UmsThreadInformation, uint UmsThreadInformationLength, cpointer unfoundType_PULONG_ReturnLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetUmsThreadInformation(cpointer unfoundType_PUMS_CONTEXT_UmsThread, cpointer unfoundType_UMS_THREAD_INFO_CLASS_UmsThreadInfoClass, cpointer UmsThreadInformation, uint UmsThreadInformationLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DeleteUmsThreadContext(cpointer unfoundType_PUMS_CONTEXT_UmsThread);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateUmsThreadContext(cpointer unfoundType_PUMS_CONTEXTlpUmsThreadlpUmsThread_unnamed_0);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnterUmsSchedulingMode(cpointer unfoundType_PUMS_SCHEDULER_STARTUP_INFO_SchedulerStartupInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetUmsSystemThreadInformation(cpointer ThreadHandle, cpointer unfoundType_PUMS_SYSTEM_THREAD_INFORMATION_SystemThreadInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer SetThreadAffinityMask(cpointer hThread, cpointer unfoundType_DWORD_PTR_dwThreadAffinityMask);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetProcessDEPPolicy(int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetProcessDEPPolicy(cpointer hProcess, cpointer unfoundType_LPDWORD_lpFlags, cpointer lpPermanent);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool RequestWakeupLatency(cpointer unfoundType_LATENCY_TIME_latency);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsSystemResumeAutomatic();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetThreadSelectorEntry(cpointer hThread, int dwSelector, cpointer unfoundType_LPLDT_ENTRY_lpSelectorEntry);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer SetThreadExecutionState(cpointer unfoundType_EXECUTION_STATE_esFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer PowerCreateRequest(cpointer unfoundType_PREASON_CONTEXT_Context);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool PowerSetRequest(cpointer PowerRequest, cpointer unfoundType_POWER_REQUEST_TYPE_RequestType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool PowerClearRequest(cpointer PowerRequest, cpointer unfoundType_POWER_REQUEST_TYPE_RequestType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFileCompletionNotificationModes(cpointer FileHandle, byte Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool Wow64GetThreadSelectorEntry(cpointer hThread, int dwSelector, cpointer unfoundType_PWOW64_LDT_ENTRY_lpSelectorEntry);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DebugSetProcessKillOnExit(bool KillOnExit);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DebugBreakProcess(cpointer Process);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool PulseEvent(cpointer hEvent);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        short GlobalDeleteAtom(short nAtom);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool InitAtomTable(int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        short DeleteAtom(short nAtom);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint SetHandleCount(uint uNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool RequestDeviceWakeup(cpointer hDevice);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CancelDeviceWakeupRequest(cpointer hDevice);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetDevicePowerState(cpointer hDevice, cpointer unfoundType_BOOLpfOnpfOn_unnamed_1);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetMessageWaitingIndicator(cpointer hMsgIndicator, uint ulMsgCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFileShortNameA(cpointer hFile, [MarshalAs(UnmanagedType.LPStr)] string lpShortName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFileShortNameA(cpointer hFile, byte* lpShortName);
    [DllImport(lib, EntryPoint = "SetFileShortNameW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFileShortName(cpointer hFile, [MarshalAs(UnmanagedType.LPWStr)] string lpShortName);
    [DllImport(lib, EntryPoint = "SetFileShortNameW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFileShortName(cpointer hFile, char* lpShortName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFileShortNameW(cpointer hFile, [MarshalAs(UnmanagedType.LPWStr)] string lpShortName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFileShortNameW(cpointer hFile, char* lpShortName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LoadModule([MarshalAs(UnmanagedType.LPStr)] string lpModuleName, cpointer lpParameterBlock);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LoadModule(byte* lpModuleName, cpointer lpParameterBlock);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint WinExec([MarshalAs(UnmanagedType.LPStr)] string lpCmdLine, uint uCmdShow);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint WinExec(byte* lpCmdLine, uint uCmdShow);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SetTapePosition(cpointer hDevice, int dwPositionMethod, int dwPartition, int dwOffsetLow, int dwOffsetHigh, bool bImmediate);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTapePosition(cpointer hDevice, int dwPositionType, cpointer unfoundType_LPDWORD_lpdwPartition, cpointer unfoundType_LPDWORD_lpdwOffsetLow, cpointer unfoundType_LPDWORD_lpdwOffsetHigh);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PrepareTape(cpointer hDevice, int dwOperation, bool bImmediate);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int EraseTape(cpointer hDevice, int dwEraseType, bool bImmediate);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CreateTapePartition(cpointer hDevice, int dwPartitionMethod, int dwCount, int dwSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int WriteTapemark(cpointer hDevice, int dwTapemarkType, int dwTapemarkCount, bool bImmediate);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTapeStatus(cpointer hDevice);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTapeParameters(cpointer hDevice, int dwOperation, cpointer unfoundType_LPDWORD_lpdwSize, cpointer lpTapeInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SetTapeParameters(cpointer hDevice, int dwOperation, cpointer lpTapeInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int MulDiv(int nNumber, int nNumerator, int nDenominator);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetSystemDEPPolicy();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetSystemRegistryQuota(cpointer unfoundType_PDWORD_pdwQuotaAllowed, cpointer unfoundType_PDWORD_pdwQuotaUsed);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FileTimeToDosDateTime(cpointer unfoundType_FILETIMElpFileTimelpFileTime_unnamed_0, cpointer unfoundType_LPWORD_lpFatDate, cpointer unfoundType_LPWORD_lpFatTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DosDateTimeToFileTime(short wFatDate, short wFatTime, cpointer unfoundType_LPFILETIME_lpFileTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FormatMessageA(int dwFlags, cpointer lpSource, int dwMessageId, int dwLanguageId, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, int nSize, cpointer unfoundType_va_listArgumentsArguments_unnamed_6);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FormatMessageA(int dwFlags, cpointer lpSource, int dwMessageId, int dwLanguageId, ReadOnlySpan<byte> lpBuffer, int nSize, cpointer unfoundType_va_listArgumentsArguments_unnamed_6);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FormatMessageA(int dwFlags, cpointer lpSource, int dwMessageId, int dwLanguageId, byte* lpBuffer, int nSize, cpointer unfoundType_va_listArgumentsArguments_unnamed_6);
    [DllImport(lib, EntryPoint = "FormatMessageW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int FormatMessage(int dwFlags, cpointer lpSource, int dwMessageId, int dwLanguageId, string lpBuffer, int nSize, cpointer unfoundType_va_listArgumentsArguments_unnamed_6);
    [DllImport(lib, EntryPoint = "FormatMessageW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int FormatMessage(int dwFlags, cpointer lpSource, int dwMessageId, int dwLanguageId, char* lpBuffer, int nSize, cpointer unfoundType_va_listArgumentsArguments_unnamed_6);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FormatMessageW(int dwFlags, cpointer lpSource, int dwMessageId, int dwLanguageId, string lpBuffer, int nSize, cpointer unfoundType_va_listArgumentsArguments_unnamed_6);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FormatMessageW(int dwFlags, cpointer lpSource, int dwMessageId, int dwLanguageId, char* lpBuffer, int nSize, cpointer unfoundType_va_listArgumentsArguments_unnamed_6);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateMailslotA([MarshalAs(UnmanagedType.LPStr)] string lpName, int nMaxMessageSize, int lReadTimeout, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateMailslotA(byte* lpName, int nMaxMessageSize, int lReadTimeout, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, EntryPoint = "CreateMailslotW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateMailslot([MarshalAs(UnmanagedType.LPWStr)] string lpName, int nMaxMessageSize, int lReadTimeout, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, EntryPoint = "CreateMailslotW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateMailslot(char* lpName, int nMaxMessageSize, int lReadTimeout, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateMailslotW([MarshalAs(UnmanagedType.LPWStr)] string lpName, int nMaxMessageSize, int lReadTimeout, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateMailslotW(char* lpName, int nMaxMessageSize, int lReadTimeout, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetMailslotInfo(cpointer hMailslot, cpointer unfoundType_LPDWORD_lpMaxMessageSize, cpointer unfoundType_LPDWORD_lpNextSize, cpointer unfoundType_LPDWORD_lpMessageCount, cpointer unfoundType_LPDWORD_lpReadTimeout);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetMailslotInfo(cpointer hMailslot, int lReadTimeout);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int lstrcmpA([MarshalAs(UnmanagedType.LPStr)] string lpString1, [MarshalAs(UnmanagedType.LPStr)] string lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int lstrcmpA([MarshalAs(UnmanagedType.LPStr)] string lpString1, byte* lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int lstrcmpA(byte* lpString1, [MarshalAs(UnmanagedType.LPStr)] string lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int lstrcmpA(byte* lpString1, byte* lpString2);
    [DllImport(lib, EntryPoint = "lstrcmpW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int lstrcmp([MarshalAs(UnmanagedType.LPWStr)] string lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport(lib, EntryPoint = "lstrcmpW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int lstrcmp([MarshalAs(UnmanagedType.LPWStr)] string lpString1, char* lpString2);
    [DllImport(lib, EntryPoint = "lstrcmpW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int lstrcmp(char* lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport(lib, EntryPoint = "lstrcmpW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int lstrcmp(char* lpString1, char* lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int lstrcmpW([MarshalAs(UnmanagedType.LPWStr)] string lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int lstrcmpW([MarshalAs(UnmanagedType.LPWStr)] string lpString1, char* lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int lstrcmpW(char* lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int lstrcmpW(char* lpString1, char* lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int lstrcmpiA([MarshalAs(UnmanagedType.LPStr)] string lpString1, [MarshalAs(UnmanagedType.LPStr)] string lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int lstrcmpiA([MarshalAs(UnmanagedType.LPStr)] string lpString1, byte* lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int lstrcmpiA(byte* lpString1, [MarshalAs(UnmanagedType.LPStr)] string lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int lstrcmpiA(byte* lpString1, byte* lpString2);
    [DllImport(lib, EntryPoint = "lstrcmpiW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int lstrcmpi([MarshalAs(UnmanagedType.LPWStr)] string lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport(lib, EntryPoint = "lstrcmpiW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int lstrcmpi([MarshalAs(UnmanagedType.LPWStr)] string lpString1, char* lpString2);
    [DllImport(lib, EntryPoint = "lstrcmpiW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int lstrcmpi(char* lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport(lib, EntryPoint = "lstrcmpiW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int lstrcmpi(char* lpString1, char* lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int lstrcmpiW([MarshalAs(UnmanagedType.LPWStr)] string lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int lstrcmpiW([MarshalAs(UnmanagedType.LPWStr)] string lpString1, char* lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int lstrcmpiW(char* lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int lstrcmpiW(char* lpString1, char* lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        byte* lstrcpynA_([MarshalAs(UnmanagedType.LPStr)] string lpString1, [MarshalAs(UnmanagedType.LPStr)] string lpString2, int iMaxLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        byte* lstrcpynA_([MarshalAs(UnmanagedType.LPStr)] string lpString1, byte* lpString2, int iMaxLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        byte* lstrcpynA_(ReadOnlySpan<byte> lpString1, [MarshalAs(UnmanagedType.LPStr)] string lpString2, int iMaxLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        byte* lstrcpynA_(ReadOnlySpan<byte> lpString1, byte* lpString2, int iMaxLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        byte* lstrcpynA_(byte* lpString1, [MarshalAs(UnmanagedType.LPStr)] string lpString2, int iMaxLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        byte* lstrcpynA_(byte* lpString1, byte* lpString2, int iMaxLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ReadOnlySpan<byte> lstrcpynA([MarshalAs(UnmanagedType.LPStr)] string lpString1, [MarshalAs(UnmanagedType.LPStr)] string lpString2, int iMaxLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ReadOnlySpan<byte> lstrcpynA([MarshalAs(UnmanagedType.LPStr)] string lpString1, byte* lpString2, int iMaxLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ReadOnlySpan<byte> lstrcpynA(ReadOnlySpan<byte> lpString1, [MarshalAs(UnmanagedType.LPStr)] string lpString2, int iMaxLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ReadOnlySpan<byte> lstrcpynA(ReadOnlySpan<byte> lpString1, byte* lpString2, int iMaxLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ReadOnlySpan<byte> lstrcpynA(byte* lpString1, [MarshalAs(UnmanagedType.LPStr)] string lpString2, int iMaxLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ReadOnlySpan<byte> lstrcpynA(byte* lpString1, byte* lpString2, int iMaxLength);
    [DllImport(lib, EntryPoint = "lstrcpynW", SetLastError = true, ExactSpelling = true)]
    public static extern
        char* lstrcpyn_(string lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2, int iMaxLength);
    [DllImport(lib, EntryPoint = "lstrcpynW", SetLastError = true, ExactSpelling = true)]
    public static extern
        char* lstrcpyn_(string lpString1, char* lpString2, int iMaxLength);
    [DllImport(lib, EntryPoint = "lstrcpynW", SetLastError = true, ExactSpelling = true)]
    public static extern
        char* lstrcpyn_(char* lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2, int iMaxLength);
    [DllImport(lib, EntryPoint = "lstrcpynW", SetLastError = true, ExactSpelling = true)]
    public static extern
        char* lstrcpyn_(char* lpString1, char* lpString2, int iMaxLength);
    [DllImport(lib, EntryPoint = "lstrcpynW", SetLastError = true, ExactSpelling = true)]
    public static extern
        string lstrcpyn(string lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2, int iMaxLength);
    [DllImport(lib, EntryPoint = "lstrcpynW", SetLastError = true, ExactSpelling = true)]
    public static extern
        string lstrcpyn(string lpString1, char* lpString2, int iMaxLength);
    [DllImport(lib, EntryPoint = "lstrcpynW", SetLastError = true, ExactSpelling = true)]
    public static extern
        string lstrcpyn(char* lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2, int iMaxLength);
    [DllImport(lib, EntryPoint = "lstrcpynW", SetLastError = true, ExactSpelling = true)]
    public static extern
        string lstrcpyn(char* lpString1, char* lpString2, int iMaxLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        char* lstrcpynW_(string lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2, int iMaxLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        char* lstrcpynW_(string lpString1, char* lpString2, int iMaxLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        char* lstrcpynW_(char* lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2, int iMaxLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        char* lstrcpynW_(char* lpString1, char* lpString2, int iMaxLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        string lstrcpynW(string lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2, int iMaxLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        string lstrcpynW(string lpString1, char* lpString2, int iMaxLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        string lstrcpynW(char* lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2, int iMaxLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        string lstrcpynW(char* lpString1, char* lpString2, int iMaxLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        byte* lstrcpyA_([MarshalAs(UnmanagedType.LPStr)] string lpString1, [MarshalAs(UnmanagedType.LPStr)] string lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        byte* lstrcpyA_([MarshalAs(UnmanagedType.LPStr)] string lpString1, byte* lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        byte* lstrcpyA_(ReadOnlySpan<byte> lpString1, [MarshalAs(UnmanagedType.LPStr)] string lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        byte* lstrcpyA_(ReadOnlySpan<byte> lpString1, byte* lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        byte* lstrcpyA_(byte* lpString1, [MarshalAs(UnmanagedType.LPStr)] string lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        byte* lstrcpyA_(byte* lpString1, byte* lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ReadOnlySpan<byte> lstrcpyA([MarshalAs(UnmanagedType.LPStr)] string lpString1, [MarshalAs(UnmanagedType.LPStr)] string lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ReadOnlySpan<byte> lstrcpyA([MarshalAs(UnmanagedType.LPStr)] string lpString1, byte* lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ReadOnlySpan<byte> lstrcpyA(ReadOnlySpan<byte> lpString1, [MarshalAs(UnmanagedType.LPStr)] string lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ReadOnlySpan<byte> lstrcpyA(ReadOnlySpan<byte> lpString1, byte* lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ReadOnlySpan<byte> lstrcpyA(byte* lpString1, [MarshalAs(UnmanagedType.LPStr)] string lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ReadOnlySpan<byte> lstrcpyA(byte* lpString1, byte* lpString2);
    [DllImport(lib, EntryPoint = "lstrcpyW", SetLastError = true, ExactSpelling = true)]
    public static extern
        char* lstrcpy_(string lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport(lib, EntryPoint = "lstrcpyW", SetLastError = true, ExactSpelling = true)]
    public static extern
        char* lstrcpy_(string lpString1, char* lpString2);
    [DllImport(lib, EntryPoint = "lstrcpyW", SetLastError = true, ExactSpelling = true)]
    public static extern
        char* lstrcpy_(char* lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport(lib, EntryPoint = "lstrcpyW", SetLastError = true, ExactSpelling = true)]
    public static extern
        char* lstrcpy_(char* lpString1, char* lpString2);
    [DllImport(lib, EntryPoint = "lstrcpyW", SetLastError = true, ExactSpelling = true)]
    public static extern
        string lstrcpy(string lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport(lib, EntryPoint = "lstrcpyW", SetLastError = true, ExactSpelling = true)]
    public static extern
        string lstrcpy(string lpString1, char* lpString2);
    [DllImport(lib, EntryPoint = "lstrcpyW", SetLastError = true, ExactSpelling = true)]
    public static extern
        string lstrcpy(char* lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport(lib, EntryPoint = "lstrcpyW", SetLastError = true, ExactSpelling = true)]
    public static extern
        string lstrcpy(char* lpString1, char* lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        char* lstrcpyW_(string lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        char* lstrcpyW_(string lpString1, char* lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        char* lstrcpyW_(char* lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        char* lstrcpyW_(char* lpString1, char* lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        string lstrcpyW(string lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        string lstrcpyW(string lpString1, char* lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        string lstrcpyW(char* lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        string lstrcpyW(char* lpString1, char* lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        byte* lstrcatA_([MarshalAs(UnmanagedType.LPStr)] string lpString1, [MarshalAs(UnmanagedType.LPStr)] string lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        byte* lstrcatA_([MarshalAs(UnmanagedType.LPStr)] string lpString1, byte* lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        byte* lstrcatA_(ReadOnlySpan<byte> lpString1, [MarshalAs(UnmanagedType.LPStr)] string lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        byte* lstrcatA_(ReadOnlySpan<byte> lpString1, byte* lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        byte* lstrcatA_(byte* lpString1, [MarshalAs(UnmanagedType.LPStr)] string lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        byte* lstrcatA_(byte* lpString1, byte* lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ReadOnlySpan<byte> lstrcatA([MarshalAs(UnmanagedType.LPStr)] string lpString1, [MarshalAs(UnmanagedType.LPStr)] string lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ReadOnlySpan<byte> lstrcatA([MarshalAs(UnmanagedType.LPStr)] string lpString1, byte* lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ReadOnlySpan<byte> lstrcatA(ReadOnlySpan<byte> lpString1, [MarshalAs(UnmanagedType.LPStr)] string lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ReadOnlySpan<byte> lstrcatA(ReadOnlySpan<byte> lpString1, byte* lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ReadOnlySpan<byte> lstrcatA(byte* lpString1, [MarshalAs(UnmanagedType.LPStr)] string lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ReadOnlySpan<byte> lstrcatA(byte* lpString1, byte* lpString2);
    [DllImport(lib, EntryPoint = "lstrcatW", SetLastError = true, ExactSpelling = true)]
    public static extern
        char* lstrcat_(string lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport(lib, EntryPoint = "lstrcatW", SetLastError = true, ExactSpelling = true)]
    public static extern
        char* lstrcat_(string lpString1, char* lpString2);
    [DllImport(lib, EntryPoint = "lstrcatW", SetLastError = true, ExactSpelling = true)]
    public static extern
        char* lstrcat_(char* lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport(lib, EntryPoint = "lstrcatW", SetLastError = true, ExactSpelling = true)]
    public static extern
        char* lstrcat_(char* lpString1, char* lpString2);
    [DllImport(lib, EntryPoint = "lstrcatW", SetLastError = true, ExactSpelling = true)]
    public static extern
        string lstrcat(string lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport(lib, EntryPoint = "lstrcatW", SetLastError = true, ExactSpelling = true)]
    public static extern
        string lstrcat(string lpString1, char* lpString2);
    [DllImport(lib, EntryPoint = "lstrcatW", SetLastError = true, ExactSpelling = true)]
    public static extern
        string lstrcat(char* lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport(lib, EntryPoint = "lstrcatW", SetLastError = true, ExactSpelling = true)]
    public static extern
        string lstrcat(char* lpString1, char* lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        char* lstrcatW_(string lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        char* lstrcatW_(string lpString1, char* lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        char* lstrcatW_(char* lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        char* lstrcatW_(char* lpString1, char* lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        string lstrcatW(string lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        string lstrcatW(string lpString1, char* lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        string lstrcatW(char* lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        string lstrcatW(char* lpString1, char* lpString2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int lstrlenA([MarshalAs(UnmanagedType.LPStr)] string lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int lstrlenA(byte* lpString);
    [DllImport(lib, EntryPoint = "lstrlenW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int lstrlen([MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport(lib, EntryPoint = "lstrlenW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int lstrlen(char* lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int lstrlenW([MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int lstrlenW(char* lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int OpenFile([MarshalAs(UnmanagedType.LPStr)] string lpFileName, cpointer unfoundType_LPOFSTRUCT_lpReOpenBuff, uint uStyle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int OpenFile(byte* lpFileName, cpointer unfoundType_LPOFSTRUCT_lpReOpenBuff, uint uStyle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int _lopen([MarshalAs(UnmanagedType.LPStr)] string lpPathName, int iReadWrite);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int _lopen(byte* lpPathName, int iReadWrite);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int _lcreat([MarshalAs(UnmanagedType.LPStr)] string lpPathName, int iAttribute);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int _lcreat(byte* lpPathName, int iAttribute);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint _lread(int hFile, cpointer lpBuffer, uint uBytes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint _lwrite(int hFile, cpointer unfoundType_LPCCH_lpBuffer, uint uBytes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int _hread(int hFile, cpointer lpBuffer, int lBytes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int _hwrite(int hFile, cpointer unfoundType_LPCCH_lpBuffer, int lBytes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int _lclose(int hFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int _llseek(int hFile, int lOffset, int iOrigin);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool BackupRead(cpointer hFile, cpointer unfoundType_LPBYTE_lpBuffer, int nNumberOfBytesToRead, cpointer unfoundType_LPDWORD_lpNumberOfBytesRead, bool bAbort, bool bProcessSecurity, cpointer unfoundType_LPVOIDlpContextlpContext_unnamed_6);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool BackupSeek(cpointer hFile, int dwLowBytesToSeek, int dwHighBytesToSeek, cpointer unfoundType_LPDWORD_lpdwLowByteSeeked, cpointer unfoundType_LPDWORD_lpdwHighByteSeeked, cpointer unfoundType_LPVOIDlpContextlpContext_unnamed_5);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool BackupWrite(cpointer hFile, cpointer unfoundType_LPBYTE_lpBuffer, int nNumberOfBytesToWrite, cpointer unfoundType_LPDWORD_lpNumberOfBytesWritten, bool bAbort, bool bProcessSecurity, cpointer unfoundType_LPVOIDlpContextlpContext_unnamed_6);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenMutexA(int dwDesiredAccess, bool bInheritHandle, [MarshalAs(UnmanagedType.LPStr)] string lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenMutexA(int dwDesiredAccess, bool bInheritHandle, byte* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateSemaphoreA(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, [MarshalAs(UnmanagedType.LPStr)] string lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateSemaphoreA(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, byte* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenSemaphoreA(int dwDesiredAccess, bool bInheritHandle, [MarshalAs(UnmanagedType.LPStr)] string lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenSemaphoreA(int dwDesiredAccess, bool bInheritHandle, byte* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateWaitableTimerA(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpTimerAttributes, bool bManualReset, [MarshalAs(UnmanagedType.LPStr)] string lpTimerName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateWaitableTimerA(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpTimerAttributes, bool bManualReset, byte* lpTimerName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenWaitableTimerA(int dwDesiredAccess, bool bInheritHandle, [MarshalAs(UnmanagedType.LPStr)] string lpTimerName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenWaitableTimerA(int dwDesiredAccess, bool bInheritHandle, byte* lpTimerName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateSemaphoreExA(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, [MarshalAs(UnmanagedType.LPStr)] string lpName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateSemaphoreExA(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, byte* lpName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateWaitableTimerExA(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpTimerAttributes, [MarshalAs(UnmanagedType.LPStr)] string lpTimerName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateWaitableTimerExA(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpTimerAttributes, byte* lpTimerName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateFileMappingA(cpointer hFile, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpFileMappingAttributes, int flProtect, int dwMaximumSizeHigh, int dwMaximumSizeLow, [MarshalAs(UnmanagedType.LPStr)] string lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateFileMappingA(cpointer hFile, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpFileMappingAttributes, int flProtect, int dwMaximumSizeHigh, int dwMaximumSizeLow, byte* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateFileMappingNumaA(cpointer hFile, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpFileMappingAttributes, int flProtect, int dwMaximumSizeHigh, int dwMaximumSizeLow, [MarshalAs(UnmanagedType.LPStr)] string lpName, int nndPreferred);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateFileMappingNumaA(cpointer hFile, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpFileMappingAttributes, int flProtect, int dwMaximumSizeHigh, int dwMaximumSizeLow, byte* lpName, int nndPreferred);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenFileMappingA(int dwDesiredAccess, bool bInheritHandle, [MarshalAs(UnmanagedType.LPStr)] string lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenFileMappingA(int dwDesiredAccess, bool bInheritHandle, byte* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLogicalDriveStringsA(int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLogicalDriveStringsA(int nBufferLength, ReadOnlySpan<byte> lpBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLogicalDriveStringsA(int nBufferLength, byte* lpBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryFullProcessImageNameA(cpointer hProcess, int dwFlags, [MarshalAs(UnmanagedType.LPStr)] string lpExeName, cpointer unfoundType_PDWORD_lpdwSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryFullProcessImageNameA(cpointer hProcess, int dwFlags, ReadOnlySpan<byte> lpExeName, cpointer unfoundType_PDWORD_lpdwSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryFullProcessImageNameA(cpointer hProcess, int dwFlags, byte* lpExeName, cpointer unfoundType_PDWORD_lpdwSize);
    [DllImport(lib, EntryPoint = "QueryFullProcessImageNameW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryFullProcessImageName(cpointer hProcess, int dwFlags, string lpExeName, cpointer unfoundType_PDWORD_lpdwSize);
    [DllImport(lib, EntryPoint = "QueryFullProcessImageNameW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryFullProcessImageName(cpointer hProcess, int dwFlags, char* lpExeName, cpointer unfoundType_PDWORD_lpdwSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryFullProcessImageNameW(cpointer hProcess, int dwFlags, string lpExeName, cpointer unfoundType_PDWORD_lpdwSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryFullProcessImageNameW(cpointer hProcess, int dwFlags, char* lpExeName, cpointer unfoundType_PDWORD_lpdwSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void GetStartupInfoA(cpointer unfoundType_LPSTARTUPINFOA_lpStartupInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariableA([MarshalAs(UnmanagedType.LPStr)] string lpName, [MarshalAs(UnmanagedType.LPStr)] string lpGuid, cpointer pBuffer, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariableA([MarshalAs(UnmanagedType.LPStr)] string lpName, byte* lpGuid, cpointer pBuffer, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariableA(byte* lpName, [MarshalAs(UnmanagedType.LPStr)] string lpGuid, cpointer pBuffer, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariableA(byte* lpName, byte* lpGuid, cpointer pBuffer, int nSize);
    [DllImport(lib, EntryPoint = "GetFirmwareEnvironmentVariableW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariable([MarshalAs(UnmanagedType.LPWStr)] string lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, cpointer pBuffer, int nSize);
    [DllImport(lib, EntryPoint = "GetFirmwareEnvironmentVariableW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariable([MarshalAs(UnmanagedType.LPWStr)] string lpName, char* lpGuid, cpointer pBuffer, int nSize);
    [DllImport(lib, EntryPoint = "GetFirmwareEnvironmentVariableW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariable(char* lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, cpointer pBuffer, int nSize);
    [DllImport(lib, EntryPoint = "GetFirmwareEnvironmentVariableW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariable(char* lpName, char* lpGuid, cpointer pBuffer, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariableW([MarshalAs(UnmanagedType.LPWStr)] string lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, cpointer pBuffer, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariableW([MarshalAs(UnmanagedType.LPWStr)] string lpName, char* lpGuid, cpointer pBuffer, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariableW(char* lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, cpointer pBuffer, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariableW(char* lpName, char* lpGuid, cpointer pBuffer, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariableExA([MarshalAs(UnmanagedType.LPStr)] string lpName, [MarshalAs(UnmanagedType.LPStr)] string lpGuid, cpointer pBuffer, int nSize, cpointer unfoundType_PDWORD_pdwAttribubutes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariableExA([MarshalAs(UnmanagedType.LPStr)] string lpName, byte* lpGuid, cpointer pBuffer, int nSize, cpointer unfoundType_PDWORD_pdwAttribubutes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariableExA(byte* lpName, [MarshalAs(UnmanagedType.LPStr)] string lpGuid, cpointer pBuffer, int nSize, cpointer unfoundType_PDWORD_pdwAttribubutes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariableExA(byte* lpName, byte* lpGuid, cpointer pBuffer, int nSize, cpointer unfoundType_PDWORD_pdwAttribubutes);
    [DllImport(lib, EntryPoint = "GetFirmwareEnvironmentVariableExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariableEx([MarshalAs(UnmanagedType.LPWStr)] string lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, cpointer pBuffer, int nSize, cpointer unfoundType_PDWORD_pdwAttribubutes);
    [DllImport(lib, EntryPoint = "GetFirmwareEnvironmentVariableExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariableEx([MarshalAs(UnmanagedType.LPWStr)] string lpName, char* lpGuid, cpointer pBuffer, int nSize, cpointer unfoundType_PDWORD_pdwAttribubutes);
    [DllImport(lib, EntryPoint = "GetFirmwareEnvironmentVariableExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariableEx(char* lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, cpointer pBuffer, int nSize, cpointer unfoundType_PDWORD_pdwAttribubutes);
    [DllImport(lib, EntryPoint = "GetFirmwareEnvironmentVariableExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariableEx(char* lpName, char* lpGuid, cpointer pBuffer, int nSize, cpointer unfoundType_PDWORD_pdwAttribubutes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariableExW([MarshalAs(UnmanagedType.LPWStr)] string lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, cpointer pBuffer, int nSize, cpointer unfoundType_PDWORD_pdwAttribubutes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariableExW([MarshalAs(UnmanagedType.LPWStr)] string lpName, char* lpGuid, cpointer pBuffer, int nSize, cpointer unfoundType_PDWORD_pdwAttribubutes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariableExW(char* lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, cpointer pBuffer, int nSize, cpointer unfoundType_PDWORD_pdwAttribubutes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariableExW(char* lpName, char* lpGuid, cpointer pBuffer, int nSize, cpointer unfoundType_PDWORD_pdwAttribubutes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariableA([MarshalAs(UnmanagedType.LPStr)] string lpName, [MarshalAs(UnmanagedType.LPStr)] string lpGuid, cpointer pValue, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariableA([MarshalAs(UnmanagedType.LPStr)] string lpName, byte* lpGuid, cpointer pValue, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariableA(byte* lpName, [MarshalAs(UnmanagedType.LPStr)] string lpGuid, cpointer pValue, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariableA(byte* lpName, byte* lpGuid, cpointer pValue, int nSize);
    [DllImport(lib, EntryPoint = "SetFirmwareEnvironmentVariableW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariable([MarshalAs(UnmanagedType.LPWStr)] string lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, cpointer pValue, int nSize);
    [DllImport(lib, EntryPoint = "SetFirmwareEnvironmentVariableW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariable([MarshalAs(UnmanagedType.LPWStr)] string lpName, char* lpGuid, cpointer pValue, int nSize);
    [DllImport(lib, EntryPoint = "SetFirmwareEnvironmentVariableW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariable(char* lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, cpointer pValue, int nSize);
    [DllImport(lib, EntryPoint = "SetFirmwareEnvironmentVariableW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariable(char* lpName, char* lpGuid, cpointer pValue, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariableW([MarshalAs(UnmanagedType.LPWStr)] string lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, cpointer pValue, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariableW([MarshalAs(UnmanagedType.LPWStr)] string lpName, char* lpGuid, cpointer pValue, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariableW(char* lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, cpointer pValue, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariableW(char* lpName, char* lpGuid, cpointer pValue, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariableExA([MarshalAs(UnmanagedType.LPStr)] string lpName, [MarshalAs(UnmanagedType.LPStr)] string lpGuid, cpointer pValue, int nSize, int dwAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariableExA([MarshalAs(UnmanagedType.LPStr)] string lpName, byte* lpGuid, cpointer pValue, int nSize, int dwAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariableExA(byte* lpName, [MarshalAs(UnmanagedType.LPStr)] string lpGuid, cpointer pValue, int nSize, int dwAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariableExA(byte* lpName, byte* lpGuid, cpointer pValue, int nSize, int dwAttributes);
    [DllImport(lib, EntryPoint = "SetFirmwareEnvironmentVariableExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariableEx([MarshalAs(UnmanagedType.LPWStr)] string lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, cpointer pValue, int nSize, int dwAttributes);
    [DllImport(lib, EntryPoint = "SetFirmwareEnvironmentVariableExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariableEx([MarshalAs(UnmanagedType.LPWStr)] string lpName, char* lpGuid, cpointer pValue, int nSize, int dwAttributes);
    [DllImport(lib, EntryPoint = "SetFirmwareEnvironmentVariableExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariableEx(char* lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, cpointer pValue, int nSize, int dwAttributes);
    [DllImport(lib, EntryPoint = "SetFirmwareEnvironmentVariableExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariableEx(char* lpName, char* lpGuid, cpointer pValue, int nSize, int dwAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariableExW([MarshalAs(UnmanagedType.LPWStr)] string lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, cpointer pValue, int nSize, int dwAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariableExW([MarshalAs(UnmanagedType.LPWStr)] string lpName, char* lpGuid, cpointer pValue, int nSize, int dwAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariableExW(char* lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, cpointer pValue, int nSize, int dwAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariableExW(char* lpName, char* lpGuid, cpointer pValue, int nSize, int dwAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFirmwareType(cpointer unfoundType_PFIRMWARE_TYPE_FirmwareType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsNativeVhdBoot(cpointer NativeVhdBoot);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindResourceA(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPStr)] string lpName, [MarshalAs(UnmanagedType.LPStr)] string lpType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindResourceA(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPStr)] string lpName, byte* lpType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindResourceA(cpointer unfoundType_HMODULE_hModule, byte* lpName, [MarshalAs(UnmanagedType.LPStr)] string lpType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindResourceA(cpointer unfoundType_HMODULE_hModule, byte* lpName, byte* lpType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindResourceExA(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPStr)] string lpType, [MarshalAs(UnmanagedType.LPStr)] string lpName, short wLanguage);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindResourceExA(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPStr)] string lpType, byte* lpName, short wLanguage);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindResourceExA(cpointer unfoundType_HMODULE_hModule, byte* lpType, [MarshalAs(UnmanagedType.LPStr)] string lpName, short wLanguage);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindResourceExA(cpointer unfoundType_HMODULE_hModule, byte* lpType, byte* lpName, short wLanguage);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceTypesA(cpointer unfoundType_HMODULE_hModule, cpointer unfoundType_ENUMRESTYPEPROCA_lpEnumFunc, long lParam);
    [DllImport(lib, EntryPoint = "EnumResourceTypesW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceTypes(cpointer unfoundType_HMODULE_hModule, cpointer unfoundType_ENUMRESTYPEPROCW_lpEnumFunc, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceTypesW(cpointer unfoundType_HMODULE_hModule, cpointer unfoundType_ENUMRESTYPEPROCW_lpEnumFunc, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguagesA(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPStr)] string lpType, [MarshalAs(UnmanagedType.LPStr)] string lpName, cpointer unfoundType_ENUMRESLANGPROCA_lpEnumFunc, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguagesA(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPStr)] string lpType, byte* lpName, cpointer unfoundType_ENUMRESLANGPROCA_lpEnumFunc, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguagesA(cpointer unfoundType_HMODULE_hModule, byte* lpType, [MarshalAs(UnmanagedType.LPStr)] string lpName, cpointer unfoundType_ENUMRESLANGPROCA_lpEnumFunc, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguagesA(cpointer unfoundType_HMODULE_hModule, byte* lpType, byte* lpName, cpointer unfoundType_ENUMRESLANGPROCA_lpEnumFunc, long lParam);
    [DllImport(lib, EntryPoint = "EnumResourceLanguagesW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguages(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, cpointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam);
    [DllImport(lib, EntryPoint = "EnumResourceLanguagesW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguages(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, char* lpName, cpointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam);
    [DllImport(lib, EntryPoint = "EnumResourceLanguagesW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguages(cpointer unfoundType_HMODULE_hModule, char* lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, cpointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam);
    [DllImport(lib, EntryPoint = "EnumResourceLanguagesW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguages(cpointer unfoundType_HMODULE_hModule, char* lpType, char* lpName, cpointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguagesW(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, cpointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguagesW(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, char* lpName, cpointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguagesW(cpointer unfoundType_HMODULE_hModule, char* lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, cpointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguagesW(cpointer unfoundType_HMODULE_hModule, char* lpType, char* lpName, cpointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer BeginUpdateResourceA([MarshalAs(UnmanagedType.LPStr)] string pFileName, bool bDeleteExistingResources);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer BeginUpdateResourceA(byte* pFileName, bool bDeleteExistingResources);
    [DllImport(lib, EntryPoint = "BeginUpdateResourceW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer BeginUpdateResource([MarshalAs(UnmanagedType.LPWStr)] string pFileName, bool bDeleteExistingResources);
    [DllImport(lib, EntryPoint = "BeginUpdateResourceW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer BeginUpdateResource(char* pFileName, bool bDeleteExistingResources);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer BeginUpdateResourceW([MarshalAs(UnmanagedType.LPWStr)] string pFileName, bool bDeleteExistingResources);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer BeginUpdateResourceW(char* pFileName, bool bDeleteExistingResources);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UpdateResourceA(cpointer hUpdate, [MarshalAs(UnmanagedType.LPStr)] string lpType, [MarshalAs(UnmanagedType.LPStr)] string lpName, short wLanguage, cpointer lpData, int cb);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UpdateResourceA(cpointer hUpdate, [MarshalAs(UnmanagedType.LPStr)] string lpType, byte* lpName, short wLanguage, cpointer lpData, int cb);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UpdateResourceA(cpointer hUpdate, byte* lpType, [MarshalAs(UnmanagedType.LPStr)] string lpName, short wLanguage, cpointer lpData, int cb);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UpdateResourceA(cpointer hUpdate, byte* lpType, byte* lpName, short wLanguage, cpointer lpData, int cb);
    [DllImport(lib, EntryPoint = "UpdateResourceW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UpdateResource(cpointer hUpdate, [MarshalAs(UnmanagedType.LPWStr)] string lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, short wLanguage, cpointer lpData, int cb);
    [DllImport(lib, EntryPoint = "UpdateResourceW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UpdateResource(cpointer hUpdate, [MarshalAs(UnmanagedType.LPWStr)] string lpType, char* lpName, short wLanguage, cpointer lpData, int cb);
    [DllImport(lib, EntryPoint = "UpdateResourceW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UpdateResource(cpointer hUpdate, char* lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, short wLanguage, cpointer lpData, int cb);
    [DllImport(lib, EntryPoint = "UpdateResourceW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UpdateResource(cpointer hUpdate, char* lpType, char* lpName, short wLanguage, cpointer lpData, int cb);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UpdateResourceW(cpointer hUpdate, [MarshalAs(UnmanagedType.LPWStr)] string lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, short wLanguage, cpointer lpData, int cb);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UpdateResourceW(cpointer hUpdate, [MarshalAs(UnmanagedType.LPWStr)] string lpType, char* lpName, short wLanguage, cpointer lpData, int cb);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UpdateResourceW(cpointer hUpdate, char* lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, short wLanguage, cpointer lpData, int cb);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UpdateResourceW(cpointer hUpdate, char* lpType, char* lpName, short wLanguage, cpointer lpData, int cb);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EndUpdateResourceA(cpointer hUpdate, bool fDiscard);
    [DllImport(lib, EntryPoint = "EndUpdateResourceW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EndUpdateResource(cpointer hUpdate, bool fDiscard);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EndUpdateResourceW(cpointer hUpdate, bool fDiscard);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        short GlobalAddAtomA([MarshalAs(UnmanagedType.LPStr)] string lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        short GlobalAddAtomA(byte* lpString);
    [DllImport(lib, EntryPoint = "GlobalAddAtomW", SetLastError = true, ExactSpelling = true)]
    public static extern
        short GlobalAddAtom([MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport(lib, EntryPoint = "GlobalAddAtomW", SetLastError = true, ExactSpelling = true)]
    public static extern
        short GlobalAddAtom(char* lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        short GlobalAddAtomW([MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        short GlobalAddAtomW(char* lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        short GlobalAddAtomExA([MarshalAs(UnmanagedType.LPStr)] string lpString, int Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        short GlobalAddAtomExA(byte* lpString, int Flags);
    [DllImport(lib, EntryPoint = "GlobalAddAtomExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        short GlobalAddAtomEx([MarshalAs(UnmanagedType.LPWStr)] string lpString, int Flags);
    [DllImport(lib, EntryPoint = "GlobalAddAtomExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        short GlobalAddAtomEx(char* lpString, int Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        short GlobalAddAtomExW([MarshalAs(UnmanagedType.LPWStr)] string lpString, int Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        short GlobalAddAtomExW(char* lpString, int Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        short GlobalFindAtomA([MarshalAs(UnmanagedType.LPStr)] string lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        short GlobalFindAtomA(byte* lpString);
    [DllImport(lib, EntryPoint = "GlobalFindAtomW", SetLastError = true, ExactSpelling = true)]
    public static extern
        short GlobalFindAtom([MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport(lib, EntryPoint = "GlobalFindAtomW", SetLastError = true, ExactSpelling = true)]
    public static extern
        short GlobalFindAtom(char* lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        short GlobalFindAtomW([MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        short GlobalFindAtomW(char* lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GlobalGetAtomNameA(short nAtom, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GlobalGetAtomNameA(short nAtom, ReadOnlySpan<byte> lpBuffer, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GlobalGetAtomNameA(short nAtom, byte* lpBuffer, int nSize);
    [DllImport(lib, EntryPoint = "GlobalGetAtomNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GlobalGetAtomName(short nAtom, string lpBuffer, int nSize);
    [DllImport(lib, EntryPoint = "GlobalGetAtomNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GlobalGetAtomName(short nAtom, char* lpBuffer, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GlobalGetAtomNameW(short nAtom, string lpBuffer, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GlobalGetAtomNameW(short nAtom, char* lpBuffer, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        short AddAtomA([MarshalAs(UnmanagedType.LPStr)] string lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        short AddAtomA(byte* lpString);
    [DllImport(lib, EntryPoint = "AddAtomW", SetLastError = true, ExactSpelling = true)]
    public static extern
        short AddAtom([MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport(lib, EntryPoint = "AddAtomW", SetLastError = true, ExactSpelling = true)]
    public static extern
        short AddAtom(char* lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        short AddAtomW([MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        short AddAtomW(char* lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        short FindAtomA([MarshalAs(UnmanagedType.LPStr)] string lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        short FindAtomA(byte* lpString);
    [DllImport(lib, EntryPoint = "FindAtomW", SetLastError = true, ExactSpelling = true)]
    public static extern
        short FindAtom([MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport(lib, EntryPoint = "FindAtomW", SetLastError = true, ExactSpelling = true)]
    public static extern
        short FindAtom(char* lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        short FindAtomW([MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        short FindAtomW(char* lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetAtomNameA(short nAtom, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetAtomNameA(short nAtom, ReadOnlySpan<byte> lpBuffer, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetAtomNameA(short nAtom, byte* lpBuffer, int nSize);
    [DllImport(lib, EntryPoint = "GetAtomNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetAtomName(short nAtom, string lpBuffer, int nSize);
    [DllImport(lib, EntryPoint = "GetAtomNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetAtomName(short nAtom, char* lpBuffer, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetAtomNameW(short nAtom, string lpBuffer, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetAtomNameW(short nAtom, char* lpBuffer, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetProfileIntA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, int nDefault);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetProfileIntA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, byte* lpKeyName, int nDefault);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetProfileIntA(byte* lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, int nDefault);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetProfileIntA(byte* lpAppName, byte* lpKeyName, int nDefault);
    [DllImport(lib, EntryPoint = "GetProfileIntW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetProfileInt([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, int nDefault);
    [DllImport(lib, EntryPoint = "GetProfileIntW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetProfileInt([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, int nDefault);
    [DllImport(lib, EntryPoint = "GetProfileIntW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetProfileInt(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, int nDefault);
    [DllImport(lib, EntryPoint = "GetProfileIntW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetProfileInt(char* lpAppName, char* lpKeyName, int nDefault);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetProfileIntW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, int nDefault);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetProfileIntW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, int nDefault);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetProfileIntW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, int nDefault);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetProfileIntW(char* lpAppName, char* lpKeyName, int nDefault);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpDefault, [MarshalAs(UnmanagedType.LPStr)] string lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpDefault, ReadOnlySpan<byte> lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpDefault, byte* lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, byte* lpDefault, [MarshalAs(UnmanagedType.LPStr)] string lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, byte* lpDefault, ReadOnlySpan<byte> lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, byte* lpDefault, byte* lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, byte* lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpDefault, [MarshalAs(UnmanagedType.LPStr)] string lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, byte* lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpDefault, ReadOnlySpan<byte> lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, byte* lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpDefault, byte* lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, byte* lpKeyName, byte* lpDefault, [MarshalAs(UnmanagedType.LPStr)] string lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, byte* lpKeyName, byte* lpDefault, ReadOnlySpan<byte> lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, byte* lpKeyName, byte* lpDefault, byte* lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileStringA(byte* lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpDefault, [MarshalAs(UnmanagedType.LPStr)] string lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileStringA(byte* lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpDefault, ReadOnlySpan<byte> lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileStringA(byte* lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpDefault, byte* lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileStringA(byte* lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, byte* lpDefault, [MarshalAs(UnmanagedType.LPStr)] string lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileStringA(byte* lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, byte* lpDefault, ReadOnlySpan<byte> lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileStringA(byte* lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, byte* lpDefault, byte* lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileStringA(byte* lpAppName, byte* lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpDefault, [MarshalAs(UnmanagedType.LPStr)] string lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileStringA(byte* lpAppName, byte* lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpDefault, ReadOnlySpan<byte> lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileStringA(byte* lpAppName, byte* lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpDefault, byte* lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileStringA(byte* lpAppName, byte* lpKeyName, byte* lpDefault, [MarshalAs(UnmanagedType.LPStr)] string lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileStringA(byte* lpAppName, byte* lpKeyName, byte* lpDefault, ReadOnlySpan<byte> lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileStringA(byte* lpAppName, byte* lpKeyName, byte* lpDefault, byte* lpReturnedString, int nSize);
    [DllImport(lib, EntryPoint = "GetProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize);
    [DllImport(lib, EntryPoint = "GetProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize);
    [DllImport(lib, EntryPoint = "GetProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, string lpReturnedString, int nSize);
    [DllImport(lib, EntryPoint = "GetProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, char* lpReturnedString, int nSize);
    [DllImport(lib, EntryPoint = "GetProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize);
    [DllImport(lib, EntryPoint = "GetProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize);
    [DllImport(lib, EntryPoint = "GetProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, char* lpDefault, string lpReturnedString, int nSize);
    [DllImport(lib, EntryPoint = "GetProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, char* lpDefault, char* lpReturnedString, int nSize);
    [DllImport(lib, EntryPoint = "GetProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileString(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize);
    [DllImport(lib, EntryPoint = "GetProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileString(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize);
    [DllImport(lib, EntryPoint = "GetProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileString(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, string lpReturnedString, int nSize);
    [DllImport(lib, EntryPoint = "GetProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileString(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, char* lpReturnedString, int nSize);
    [DllImport(lib, EntryPoint = "GetProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileString(char* lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize);
    [DllImport(lib, EntryPoint = "GetProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileString(char* lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize);
    [DllImport(lib, EntryPoint = "GetProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileString(char* lpAppName, char* lpKeyName, char* lpDefault, string lpReturnedString, int nSize);
    [DllImport(lib, EntryPoint = "GetProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileString(char* lpAppName, char* lpKeyName, char* lpDefault, char* lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, string lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, char* lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, char* lpDefault, string lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, char* lpDefault, char* lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileStringW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileStringW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileStringW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, string lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileStringW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, char* lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileStringW(char* lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileStringW(char* lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileStringW(char* lpAppName, char* lpKeyName, char* lpDefault, string lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileStringW(char* lpAppName, char* lpKeyName, char* lpDefault, char* lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, byte* lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, byte* lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, byte* lpKeyName, byte* lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteProfileStringA(byte* lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteProfileStringA(byte* lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, byte* lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteProfileStringA(byte* lpAppName, byte* lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteProfileStringA(byte* lpAppName, byte* lpKeyName, byte* lpString);
    [DllImport(lib, EntryPoint = "WriteProfileStringW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport(lib, EntryPoint = "WriteProfileStringW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpString);
    [DllImport(lib, EntryPoint = "WriteProfileStringW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport(lib, EntryPoint = "WriteProfileStringW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, char* lpString);
    [DllImport(lib, EntryPoint = "WriteProfileStringW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteProfileString(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport(lib, EntryPoint = "WriteProfileStringW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteProfileString(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpString);
    [DllImport(lib, EntryPoint = "WriteProfileStringW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteProfileString(char* lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport(lib, EntryPoint = "WriteProfileStringW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteProfileString(char* lpAppName, char* lpKeyName, char* lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, char* lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteProfileStringW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteProfileStringW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteProfileStringW(char* lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteProfileStringW(char* lpAppName, char* lpKeyName, char* lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileSectionA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileSectionA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, ReadOnlySpan<byte> lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileSectionA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, byte* lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileSectionA(byte* lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileSectionA(byte* lpAppName, ReadOnlySpan<byte> lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileSectionA(byte* lpAppName, byte* lpReturnedString, int nSize);
    [DllImport(lib, EntryPoint = "GetProfileSectionW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileSection([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, string lpReturnedString, int nSize);
    [DllImport(lib, EntryPoint = "GetProfileSectionW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileSection([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpReturnedString, int nSize);
    [DllImport(lib, EntryPoint = "GetProfileSectionW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileSection(char* lpAppName, string lpReturnedString, int nSize);
    [DllImport(lib, EntryPoint = "GetProfileSectionW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileSection(char* lpAppName, char* lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileSectionW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, string lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileSectionW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileSectionW(char* lpAppName, string lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProfileSectionW(char* lpAppName, char* lpReturnedString, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteProfileSectionA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteProfileSectionA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, byte* lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteProfileSectionA(byte* lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteProfileSectionA(byte* lpAppName, byte* lpString);
    [DllImport(lib, EntryPoint = "WriteProfileSectionW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteProfileSection([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport(lib, EntryPoint = "WriteProfileSectionW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteProfileSection([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpString);
    [DllImport(lib, EntryPoint = "WriteProfileSectionW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteProfileSection(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport(lib, EntryPoint = "WriteProfileSectionW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteProfileSection(char* lpAppName, char* lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteProfileSectionW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteProfileSectionW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteProfileSectionW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteProfileSectionW(char* lpAppName, char* lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetPrivateProfileIntA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, int nDefault, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetPrivateProfileIntA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, int nDefault, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetPrivateProfileIntA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, byte* lpKeyName, int nDefault, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetPrivateProfileIntA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, byte* lpKeyName, int nDefault, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetPrivateProfileIntA(byte* lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, int nDefault, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetPrivateProfileIntA(byte* lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, int nDefault, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetPrivateProfileIntA(byte* lpAppName, byte* lpKeyName, int nDefault, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetPrivateProfileIntA(byte* lpAppName, byte* lpKeyName, int nDefault, byte* lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileIntW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetPrivateProfileInt([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, int nDefault, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileIntW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetPrivateProfileInt([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, int nDefault, char* lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileIntW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetPrivateProfileInt([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, int nDefault, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileIntW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetPrivateProfileInt([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, int nDefault, char* lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileIntW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetPrivateProfileInt(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, int nDefault, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileIntW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetPrivateProfileInt(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, int nDefault, char* lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileIntW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetPrivateProfileInt(char* lpAppName, char* lpKeyName, int nDefault, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileIntW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetPrivateProfileInt(char* lpAppName, char* lpKeyName, int nDefault, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetPrivateProfileIntW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, int nDefault, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetPrivateProfileIntW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, int nDefault, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetPrivateProfileIntW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, int nDefault, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetPrivateProfileIntW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, int nDefault, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetPrivateProfileIntW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, int nDefault, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetPrivateProfileIntW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, int nDefault, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetPrivateProfileIntW(char* lpAppName, char* lpKeyName, int nDefault, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetPrivateProfileIntW(char* lpAppName, char* lpKeyName, int nDefault, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpDefault, [MarshalAs(UnmanagedType.LPStr)] string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpDefault, [MarshalAs(UnmanagedType.LPStr)] string lpReturnedString, int nSize, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpDefault, ReadOnlySpan<byte> lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpDefault, ReadOnlySpan<byte> lpReturnedString, int nSize, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpDefault, byte* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpDefault, byte* lpReturnedString, int nSize, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, byte* lpDefault, [MarshalAs(UnmanagedType.LPStr)] string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, byte* lpDefault, [MarshalAs(UnmanagedType.LPStr)] string lpReturnedString, int nSize, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, byte* lpDefault, ReadOnlySpan<byte> lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, byte* lpDefault, ReadOnlySpan<byte> lpReturnedString, int nSize, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, byte* lpDefault, byte* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, byte* lpDefault, byte* lpReturnedString, int nSize, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, byte* lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpDefault, [MarshalAs(UnmanagedType.LPStr)] string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, byte* lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpDefault, [MarshalAs(UnmanagedType.LPStr)] string lpReturnedString, int nSize, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, byte* lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpDefault, ReadOnlySpan<byte> lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, byte* lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpDefault, ReadOnlySpan<byte> lpReturnedString, int nSize, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, byte* lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpDefault, byte* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, byte* lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpDefault, byte* lpReturnedString, int nSize, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, byte* lpKeyName, byte* lpDefault, [MarshalAs(UnmanagedType.LPStr)] string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, byte* lpKeyName, byte* lpDefault, [MarshalAs(UnmanagedType.LPStr)] string lpReturnedString, int nSize, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, byte* lpKeyName, byte* lpDefault, ReadOnlySpan<byte> lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, byte* lpKeyName, byte* lpDefault, ReadOnlySpan<byte> lpReturnedString, int nSize, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, byte* lpKeyName, byte* lpDefault, byte* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, byte* lpKeyName, byte* lpDefault, byte* lpReturnedString, int nSize, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA(byte* lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpDefault, [MarshalAs(UnmanagedType.LPStr)] string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA(byte* lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpDefault, [MarshalAs(UnmanagedType.LPStr)] string lpReturnedString, int nSize, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA(byte* lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpDefault, ReadOnlySpan<byte> lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA(byte* lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpDefault, ReadOnlySpan<byte> lpReturnedString, int nSize, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA(byte* lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpDefault, byte* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA(byte* lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpDefault, byte* lpReturnedString, int nSize, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA(byte* lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, byte* lpDefault, [MarshalAs(UnmanagedType.LPStr)] string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA(byte* lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, byte* lpDefault, [MarshalAs(UnmanagedType.LPStr)] string lpReturnedString, int nSize, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA(byte* lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, byte* lpDefault, ReadOnlySpan<byte> lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA(byte* lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, byte* lpDefault, ReadOnlySpan<byte> lpReturnedString, int nSize, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA(byte* lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, byte* lpDefault, byte* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA(byte* lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, byte* lpDefault, byte* lpReturnedString, int nSize, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA(byte* lpAppName, byte* lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpDefault, [MarshalAs(UnmanagedType.LPStr)] string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA(byte* lpAppName, byte* lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpDefault, [MarshalAs(UnmanagedType.LPStr)] string lpReturnedString, int nSize, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA(byte* lpAppName, byte* lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpDefault, ReadOnlySpan<byte> lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA(byte* lpAppName, byte* lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpDefault, ReadOnlySpan<byte> lpReturnedString, int nSize, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA(byte* lpAppName, byte* lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpDefault, byte* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA(byte* lpAppName, byte* lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpDefault, byte* lpReturnedString, int nSize, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA(byte* lpAppName, byte* lpKeyName, byte* lpDefault, [MarshalAs(UnmanagedType.LPStr)] string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA(byte* lpAppName, byte* lpKeyName, byte* lpDefault, [MarshalAs(UnmanagedType.LPStr)] string lpReturnedString, int nSize, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA(byte* lpAppName, byte* lpKeyName, byte* lpDefault, ReadOnlySpan<byte> lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA(byte* lpAppName, byte* lpKeyName, byte* lpDefault, ReadOnlySpan<byte> lpReturnedString, int nSize, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA(byte* lpAppName, byte* lpKeyName, byte* lpDefault, byte* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringA(byte* lpAppName, byte* lpKeyName, byte* lpDefault, byte* lpReturnedString, int nSize, byte* lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize, char* lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize, char* lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, string lpReturnedString, int nSize, char* lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, char* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, char* lpReturnedString, int nSize, char* lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize, char* lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize, char* lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, char* lpDefault, string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, char* lpDefault, string lpReturnedString, int nSize, char* lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, char* lpDefault, char* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, char* lpDefault, char* lpReturnedString, int nSize, char* lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileString(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileString(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize, char* lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileString(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileString(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize, char* lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileString(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileString(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, string lpReturnedString, int nSize, char* lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileString(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, char* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileString(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, char* lpReturnedString, int nSize, char* lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileString(char* lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileString(char* lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize, char* lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileString(char* lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileString(char* lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize, char* lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileString(char* lpAppName, char* lpKeyName, char* lpDefault, string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileString(char* lpAppName, char* lpKeyName, char* lpDefault, string lpReturnedString, int nSize, char* lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileString(char* lpAppName, char* lpKeyName, char* lpDefault, char* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileString(char* lpAppName, char* lpKeyName, char* lpDefault, char* lpReturnedString, int nSize, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, string lpReturnedString, int nSize, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, char* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, char* lpReturnedString, int nSize, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, char* lpDefault, string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, char* lpDefault, string lpReturnedString, int nSize, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, char* lpDefault, char* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, char* lpDefault, char* lpReturnedString, int nSize, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, string lpReturnedString, int nSize, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, char* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, char* lpReturnedString, int nSize, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringW(char* lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringW(char* lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringW(char* lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringW(char* lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringW(char* lpAppName, char* lpKeyName, char* lpDefault, string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringW(char* lpAppName, char* lpKeyName, char* lpDefault, string lpReturnedString, int nSize, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringW(char* lpAppName, char* lpKeyName, char* lpDefault, char* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileStringW(char* lpAppName, char* lpKeyName, char* lpDefault, char* lpReturnedString, int nSize, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpString, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpString, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, byte* lpString, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, byte* lpString, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, byte* lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpString, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, byte* lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpString, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, byte* lpKeyName, byte* lpString, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStringA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, byte* lpKeyName, byte* lpString, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStringA(byte* lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpString, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStringA(byte* lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpString, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStringA(byte* lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, byte* lpString, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStringA(byte* lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, byte* lpString, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStringA(byte* lpAppName, byte* lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpString, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStringA(byte* lpAppName, byte* lpKeyName, [MarshalAs(UnmanagedType.LPStr)] string lpString, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStringA(byte* lpAppName, byte* lpKeyName, byte* lpString, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStringA(byte* lpAppName, byte* lpKeyName, byte* lpString, byte* lpFileName);
    [DllImport(lib, EntryPoint = "WritePrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, EntryPoint = "WritePrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, char* lpFileName);
    [DllImport(lib, EntryPoint = "WritePrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, EntryPoint = "WritePrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpString, char* lpFileName);
    [DllImport(lib, EntryPoint = "WritePrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, EntryPoint = "WritePrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, char* lpFileName);
    [DllImport(lib, EntryPoint = "WritePrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, char* lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, EntryPoint = "WritePrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, char* lpString, char* lpFileName);
    [DllImport(lib, EntryPoint = "WritePrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileString(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, EntryPoint = "WritePrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileString(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, char* lpFileName);
    [DllImport(lib, EntryPoint = "WritePrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileString(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, EntryPoint = "WritePrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileString(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpString, char* lpFileName);
    [DllImport(lib, EntryPoint = "WritePrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileString(char* lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, EntryPoint = "WritePrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileString(char* lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, char* lpFileName);
    [DllImport(lib, EntryPoint = "WritePrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileString(char* lpAppName, char* lpKeyName, char* lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, EntryPoint = "WritePrivateProfileStringW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileString(char* lpAppName, char* lpKeyName, char* lpString, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpString, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, char* lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, char* lpString, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStringW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStringW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStringW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStringW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpString, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStringW(char* lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStringW(char* lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStringW(char* lpAppName, char* lpKeyName, char* lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStringW(char* lpAppName, char* lpKeyName, char* lpString, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileSectionA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileSectionA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpReturnedString, int nSize, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileSectionA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, ReadOnlySpan<byte> lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileSectionA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, ReadOnlySpan<byte> lpReturnedString, int nSize, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileSectionA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, byte* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileSectionA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, byte* lpReturnedString, int nSize, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileSectionA(byte* lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileSectionA(byte* lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpReturnedString, int nSize, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileSectionA(byte* lpAppName, ReadOnlySpan<byte> lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileSectionA(byte* lpAppName, ReadOnlySpan<byte> lpReturnedString, int nSize, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileSectionA(byte* lpAppName, byte* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileSectionA(byte* lpAppName, byte* lpReturnedString, int nSize, byte* lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileSectionW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileSection([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileSectionW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileSection([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, string lpReturnedString, int nSize, char* lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileSectionW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileSection([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileSectionW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileSection([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpReturnedString, int nSize, char* lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileSectionW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileSection(char* lpAppName, string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileSectionW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileSection(char* lpAppName, string lpReturnedString, int nSize, char* lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileSectionW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileSection(char* lpAppName, char* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileSectionW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileSection(char* lpAppName, char* lpReturnedString, int nSize, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileSectionW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileSectionW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, string lpReturnedString, int nSize, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileSectionW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileSectionW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpReturnedString, int nSize, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileSectionW(char* lpAppName, string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileSectionW(char* lpAppName, string lpReturnedString, int nSize, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileSectionW(char* lpAppName, char* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileSectionW(char* lpAppName, char* lpReturnedString, int nSize, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileSectionA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpString, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileSectionA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpString, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileSectionA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, byte* lpString, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileSectionA([MarshalAs(UnmanagedType.LPStr)] string lpAppName, byte* lpString, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileSectionA(byte* lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpString, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileSectionA(byte* lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpString, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileSectionA(byte* lpAppName, byte* lpString, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileSectionA(byte* lpAppName, byte* lpString, byte* lpFileName);
    [DllImport(lib, EntryPoint = "WritePrivateProfileSectionW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileSection([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, EntryPoint = "WritePrivateProfileSectionW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileSection([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, char* lpFileName);
    [DllImport(lib, EntryPoint = "WritePrivateProfileSectionW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileSection([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, EntryPoint = "WritePrivateProfileSectionW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileSection([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpString, char* lpFileName);
    [DllImport(lib, EntryPoint = "WritePrivateProfileSectionW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileSection(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, EntryPoint = "WritePrivateProfileSectionW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileSection(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, char* lpFileName);
    [DllImport(lib, EntryPoint = "WritePrivateProfileSectionW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileSection(char* lpAppName, char* lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, EntryPoint = "WritePrivateProfileSectionW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileSection(char* lpAppName, char* lpString, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileSectionW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileSectionW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileSectionW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileSectionW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpString, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileSectionW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileSectionW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileSectionW(char* lpAppName, char* lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileSectionW(char* lpAppName, char* lpString, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileSectionNamesA([MarshalAs(UnmanagedType.LPStr)] string lpszReturnBuffer, int nSize, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileSectionNamesA([MarshalAs(UnmanagedType.LPStr)] string lpszReturnBuffer, int nSize, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileSectionNamesA(ReadOnlySpan<byte> lpszReturnBuffer, int nSize, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileSectionNamesA(ReadOnlySpan<byte> lpszReturnBuffer, int nSize, byte* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileSectionNamesA(byte* lpszReturnBuffer, int nSize, [MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileSectionNamesA(byte* lpszReturnBuffer, int nSize, byte* lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileSectionNamesW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileSectionNames(string lpszReturnBuffer, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileSectionNamesW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileSectionNames(string lpszReturnBuffer, int nSize, char* lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileSectionNamesW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileSectionNames(char* lpszReturnBuffer, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, EntryPoint = "GetPrivateProfileSectionNamesW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileSectionNames(char* lpszReturnBuffer, int nSize, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileSectionNamesW(string lpszReturnBuffer, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileSectionNamesW(string lpszReturnBuffer, int nSize, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileSectionNamesW(char* lpszReturnBuffer, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPrivateProfileSectionNamesW(char* lpszReturnBuffer, int nSize, char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStructA([MarshalAs(UnmanagedType.LPStr)] string lpszSection, [MarshalAs(UnmanagedType.LPStr)] string lpszKey, cpointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPStr)] string szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStructA([MarshalAs(UnmanagedType.LPStr)] string lpszSection, [MarshalAs(UnmanagedType.LPStr)] string lpszKey, cpointer lpStruct, uint uSizeStruct, byte* szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStructA([MarshalAs(UnmanagedType.LPStr)] string lpszSection, byte* lpszKey, cpointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPStr)] string szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStructA([MarshalAs(UnmanagedType.LPStr)] string lpszSection, byte* lpszKey, cpointer lpStruct, uint uSizeStruct, byte* szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStructA(byte* lpszSection, [MarshalAs(UnmanagedType.LPStr)] string lpszKey, cpointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPStr)] string szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStructA(byte* lpszSection, [MarshalAs(UnmanagedType.LPStr)] string lpszKey, cpointer lpStruct, uint uSizeStruct, byte* szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStructA(byte* lpszSection, byte* lpszKey, cpointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPStr)] string szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStructA(byte* lpszSection, byte* lpszKey, cpointer lpStruct, uint uSizeStruct, byte* szFile);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStructW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStruct([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, cpointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStructW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStruct([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, cpointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStructW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStruct([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, char* lpszKey, cpointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStructW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStruct([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, char* lpszKey, cpointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStructW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStruct(char* lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, cpointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStructW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStruct(char* lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, cpointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStructW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStruct(char* lpszSection, char* lpszKey, cpointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStructW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStruct(char* lpszSection, char* lpszKey, cpointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStructW([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, cpointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStructW([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, cpointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStructW([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, char* lpszKey, cpointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStructW([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, char* lpszKey, cpointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStructW(char* lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, cpointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStructW(char* lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, cpointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStructW(char* lpszSection, char* lpszKey, cpointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStructW(char* lpszSection, char* lpszKey, cpointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStructA([MarshalAs(UnmanagedType.LPStr)] string lpszSection, [MarshalAs(UnmanagedType.LPStr)] string lpszKey, cpointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPStr)] string szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStructA([MarshalAs(UnmanagedType.LPStr)] string lpszSection, [MarshalAs(UnmanagedType.LPStr)] string lpszKey, cpointer lpStruct, uint uSizeStruct, byte* szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStructA([MarshalAs(UnmanagedType.LPStr)] string lpszSection, byte* lpszKey, cpointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPStr)] string szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStructA([MarshalAs(UnmanagedType.LPStr)] string lpszSection, byte* lpszKey, cpointer lpStruct, uint uSizeStruct, byte* szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStructA(byte* lpszSection, [MarshalAs(UnmanagedType.LPStr)] string lpszKey, cpointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPStr)] string szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStructA(byte* lpszSection, [MarshalAs(UnmanagedType.LPStr)] string lpszKey, cpointer lpStruct, uint uSizeStruct, byte* szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStructA(byte* lpszSection, byte* lpszKey, cpointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPStr)] string szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStructA(byte* lpszSection, byte* lpszKey, cpointer lpStruct, uint uSizeStruct, byte* szFile);
    [DllImport(lib, EntryPoint = "WritePrivateProfileStructW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStruct([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, cpointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport(lib, EntryPoint = "WritePrivateProfileStructW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStruct([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, cpointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport(lib, EntryPoint = "WritePrivateProfileStructW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStruct([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, char* lpszKey, cpointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport(lib, EntryPoint = "WritePrivateProfileStructW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStruct([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, char* lpszKey, cpointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport(lib, EntryPoint = "WritePrivateProfileStructW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStruct(char* lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, cpointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport(lib, EntryPoint = "WritePrivateProfileStructW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStruct(char* lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, cpointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport(lib, EntryPoint = "WritePrivateProfileStructW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStruct(char* lpszSection, char* lpszKey, cpointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport(lib, EntryPoint = "WritePrivateProfileStructW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStruct(char* lpszSection, char* lpszKey, cpointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStructW([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, cpointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStructW([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, cpointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStructW([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, char* lpszKey, cpointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStructW([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, char* lpszKey, cpointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStructW(char* lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, cpointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStructW(char* lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, cpointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStructW(char* lpszSection, char* lpszKey, cpointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStructW(char* lpszSection, char* lpszKey, cpointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetDllDirectoryA([MarshalAs(UnmanagedType.LPStr)] string lpPathName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetDllDirectoryA(byte* lpPathName);
    [DllImport(lib, EntryPoint = "SetDllDirectoryW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetDllDirectory([MarshalAs(UnmanagedType.LPWStr)] string lpPathName);
    [DllImport(lib, EntryPoint = "SetDllDirectoryW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetDllDirectory(char* lpPathName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetDllDirectoryW([MarshalAs(UnmanagedType.LPWStr)] string lpPathName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetDllDirectoryW(char* lpPathName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDllDirectoryA(int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDllDirectoryA(int nBufferLength, ReadOnlySpan<byte> lpBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDllDirectoryA(int nBufferLength, byte* lpBuffer);
    [DllImport(lib, EntryPoint = "GetDllDirectoryW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDllDirectory(int nBufferLength, string lpBuffer);
    [DllImport(lib, EntryPoint = "GetDllDirectoryW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDllDirectory(int nBufferLength, char* lpBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDllDirectoryW(int nBufferLength, string lpBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDllDirectoryW(int nBufferLength, char* lpBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetSearchPathMode(int Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryExA([MarshalAs(UnmanagedType.LPStr)] string lpTemplateDirectory, [MarshalAs(UnmanagedType.LPStr)] string lpNewDirectory, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryExA([MarshalAs(UnmanagedType.LPStr)] string lpTemplateDirectory, byte* lpNewDirectory, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryExA(byte* lpTemplateDirectory, [MarshalAs(UnmanagedType.LPStr)] string lpNewDirectory, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryExA(byte* lpTemplateDirectory, byte* lpNewDirectory, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, EntryPoint = "CreateDirectoryExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryEx([MarshalAs(UnmanagedType.LPWStr)] string lpTemplateDirectory, [MarshalAs(UnmanagedType.LPWStr)] string lpNewDirectory, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, EntryPoint = "CreateDirectoryExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryEx([MarshalAs(UnmanagedType.LPWStr)] string lpTemplateDirectory, char* lpNewDirectory, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, EntryPoint = "CreateDirectoryExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryEx(char* lpTemplateDirectory, [MarshalAs(UnmanagedType.LPWStr)] string lpNewDirectory, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, EntryPoint = "CreateDirectoryExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryEx(char* lpTemplateDirectory, char* lpNewDirectory, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryExW([MarshalAs(UnmanagedType.LPWStr)] string lpTemplateDirectory, [MarshalAs(UnmanagedType.LPWStr)] string lpNewDirectory, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryExW([MarshalAs(UnmanagedType.LPWStr)] string lpTemplateDirectory, char* lpNewDirectory, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryExW(char* lpTemplateDirectory, [MarshalAs(UnmanagedType.LPWStr)] string lpNewDirectory, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryExW(char* lpTemplateDirectory, char* lpNewDirectory, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpTemplateDirectory, [MarshalAs(UnmanagedType.LPStr)] string lpNewDirectory, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpTemplateDirectory, byte* lpNewDirectory, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryTransactedA(byte* lpTemplateDirectory, [MarshalAs(UnmanagedType.LPStr)] string lpNewDirectory, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryTransactedA(byte* lpTemplateDirectory, byte* lpNewDirectory, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "CreateDirectoryTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpTemplateDirectory, [MarshalAs(UnmanagedType.LPWStr)] string lpNewDirectory, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "CreateDirectoryTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpTemplateDirectory, char* lpNewDirectory, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "CreateDirectoryTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryTransacted(char* lpTemplateDirectory, [MarshalAs(UnmanagedType.LPWStr)] string lpNewDirectory, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "CreateDirectoryTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryTransacted(char* lpTemplateDirectory, char* lpNewDirectory, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpTemplateDirectory, [MarshalAs(UnmanagedType.LPWStr)] string lpNewDirectory, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpTemplateDirectory, char* lpNewDirectory, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryTransactedW(char* lpTemplateDirectory, [MarshalAs(UnmanagedType.LPWStr)] string lpNewDirectory, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryTransactedW(char* lpTemplateDirectory, char* lpNewDirectory, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool RemoveDirectoryTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpPathName, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool RemoveDirectoryTransactedA(byte* lpPathName, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "RemoveDirectoryTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool RemoveDirectoryTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpPathName, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "RemoveDirectoryTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool RemoveDirectoryTransacted(char* lpPathName, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool RemoveDirectoryTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpPathName, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool RemoveDirectoryTransactedW(char* lpPathName, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, cpointer unfoundType_LPSTRlpFilePartlpFilePart_unnamed_3, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, int nBufferLength, ReadOnlySpan<byte> lpBuffer, cpointer unfoundType_LPSTRlpFilePartlpFilePart_unnamed_3, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, int nBufferLength, byte* lpBuffer, cpointer unfoundType_LPSTRlpFilePartlpFilePart_unnamed_3, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameTransactedA(byte* lpFileName, int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, cpointer unfoundType_LPSTRlpFilePartlpFilePart_unnamed_3, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameTransactedA(byte* lpFileName, int nBufferLength, ReadOnlySpan<byte> lpBuffer, cpointer unfoundType_LPSTRlpFilePartlpFilePart_unnamed_3, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameTransactedA(byte* lpFileName, int nBufferLength, byte* lpBuffer, cpointer unfoundType_LPSTRlpFilePartlpFilePart_unnamed_3, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "GetFullPathNameTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int nBufferLength, string lpBuffer, cpointer unfoundType_LPWSTRlpFilePartlpFilePart_unnamed_3, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "GetFullPathNameTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int nBufferLength, char* lpBuffer, cpointer unfoundType_LPWSTRlpFilePartlpFilePart_unnamed_3, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "GetFullPathNameTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameTransacted(char* lpFileName, int nBufferLength, string lpBuffer, cpointer unfoundType_LPWSTRlpFilePartlpFilePart_unnamed_3, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "GetFullPathNameTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameTransacted(char* lpFileName, int nBufferLength, char* lpBuffer, cpointer unfoundType_LPWSTRlpFilePartlpFilePart_unnamed_3, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int nBufferLength, string lpBuffer, cpointer unfoundType_LPWSTRlpFilePartlpFilePart_unnamed_3, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int nBufferLength, char* lpBuffer, cpointer unfoundType_LPWSTRlpFilePartlpFilePart_unnamed_3, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameTransactedW(char* lpFileName, int nBufferLength, string lpBuffer, cpointer unfoundType_LPWSTRlpFilePartlpFilePart_unnamed_3, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameTransactedW(char* lpFileName, int nBufferLength, char* lpBuffer, cpointer unfoundType_LPWSTRlpFilePartlpFilePart_unnamed_3, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DefineDosDeviceA(int dwFlags, [MarshalAs(UnmanagedType.LPStr)] string lpDeviceName, [MarshalAs(UnmanagedType.LPStr)] string lpTargetPath);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DefineDosDeviceA(int dwFlags, [MarshalAs(UnmanagedType.LPStr)] string lpDeviceName, byte* lpTargetPath);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DefineDosDeviceA(int dwFlags, byte* lpDeviceName, [MarshalAs(UnmanagedType.LPStr)] string lpTargetPath);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DefineDosDeviceA(int dwFlags, byte* lpDeviceName, byte* lpTargetPath);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int QueryDosDeviceA([MarshalAs(UnmanagedType.LPStr)] string lpDeviceName, [MarshalAs(UnmanagedType.LPStr)] string lpTargetPath, int ucchMax);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int QueryDosDeviceA([MarshalAs(UnmanagedType.LPStr)] string lpDeviceName, ReadOnlySpan<byte> lpTargetPath, int ucchMax);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int QueryDosDeviceA([MarshalAs(UnmanagedType.LPStr)] string lpDeviceName, byte* lpTargetPath, int ucchMax);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int QueryDosDeviceA(byte* lpDeviceName, [MarshalAs(UnmanagedType.LPStr)] string lpTargetPath, int ucchMax);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int QueryDosDeviceA(byte* lpDeviceName, ReadOnlySpan<byte> lpTargetPath, int ucchMax);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int QueryDosDeviceA(byte* lpDeviceName, byte* lpTargetPath, int ucchMax);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateFileTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, int dwDesiredAccess, int dwShareMode, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, cpointer hTemplateFile, cpointer hTransaction, cpointer unfoundType_PUSHORT_pusMiniVersion, cpointer lpExtendedParameter);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateFileTransactedA(byte* lpFileName, int dwDesiredAccess, int dwShareMode, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, cpointer hTemplateFile, cpointer hTransaction, cpointer unfoundType_PUSHORT_pusMiniVersion, cpointer lpExtendedParameter);
    [DllImport(lib, EntryPoint = "CreateFileTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateFileTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwDesiredAccess, int dwShareMode, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, cpointer hTemplateFile, cpointer hTransaction, cpointer unfoundType_PUSHORT_pusMiniVersion, cpointer lpExtendedParameter);
    [DllImport(lib, EntryPoint = "CreateFileTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateFileTransacted(char* lpFileName, int dwDesiredAccess, int dwShareMode, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, cpointer hTemplateFile, cpointer hTransaction, cpointer unfoundType_PUSHORT_pusMiniVersion, cpointer lpExtendedParameter);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateFileTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwDesiredAccess, int dwShareMode, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, cpointer hTemplateFile, cpointer hTransaction, cpointer unfoundType_PUSHORT_pusMiniVersion, cpointer lpExtendedParameter);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateFileTransactedW(char* lpFileName, int dwDesiredAccess, int dwShareMode, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, cpointer hTemplateFile, cpointer hTransaction, cpointer unfoundType_PUSHORT_pusMiniVersion, cpointer lpExtendedParameter);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer ReOpenFile(cpointer hOriginalFile, int dwDesiredAccess, int dwShareMode, int dwFlagsAndAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFileAttributesTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, int dwFileAttributes, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFileAttributesTransactedA(byte* lpFileName, int dwFileAttributes, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "SetFileAttributesTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFileAttributesTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwFileAttributes, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "SetFileAttributesTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFileAttributesTransacted(char* lpFileName, int dwFileAttributes, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFileAttributesTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwFileAttributes, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFileAttributesTransactedW(char* lpFileName, int dwFileAttributes, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileAttributesTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, cpointer unfoundType_GET_FILEEX_INFO_LEVELS_fInfoLevelId, cpointer lpFileInformation, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileAttributesTransactedA(byte* lpFileName, cpointer unfoundType_GET_FILEEX_INFO_LEVELS_fInfoLevelId, cpointer lpFileInformation, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "GetFileAttributesTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileAttributesTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, cpointer unfoundType_GET_FILEEX_INFO_LEVELS_fInfoLevelId, cpointer lpFileInformation, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "GetFileAttributesTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileAttributesTransacted(char* lpFileName, cpointer unfoundType_GET_FILEEX_INFO_LEVELS_fInfoLevelId, cpointer lpFileInformation, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileAttributesTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, cpointer unfoundType_GET_FILEEX_INFO_LEVELS_fInfoLevelId, cpointer lpFileInformation, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileAttributesTransactedW(char* lpFileName, cpointer unfoundType_GET_FILEEX_INFO_LEVELS_fInfoLevelId, cpointer lpFileInformation, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCompressedFileSizeTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, cpointer unfoundType_LPDWORD_lpFileSizeHigh, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCompressedFileSizeTransactedA(byte* lpFileName, cpointer unfoundType_LPDWORD_lpFileSizeHigh, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "GetCompressedFileSizeTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCompressedFileSizeTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, cpointer unfoundType_LPDWORD_lpFileSizeHigh, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "GetCompressedFileSizeTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCompressedFileSizeTransacted(char* lpFileName, cpointer unfoundType_LPDWORD_lpFileSizeHigh, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCompressedFileSizeTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, cpointer unfoundType_LPDWORD_lpFileSizeHigh, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCompressedFileSizeTransactedW(char* lpFileName, cpointer unfoundType_LPDWORD_lpFileSizeHigh, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DeleteFileTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DeleteFileTransactedA(byte* lpFileName, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "DeleteFileTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DeleteFileTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "DeleteFileTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DeleteFileTransacted(char* lpFileName, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DeleteFileTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DeleteFileTransactedW(char* lpFileName, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckNameLegalDOS8Dot3A([MarshalAs(UnmanagedType.LPStr)] string lpName, [MarshalAs(UnmanagedType.LPStr)] string lpOemName, int OemNameSize, cpointer pbNameContainsSpaces, cpointer pbNameLegal);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckNameLegalDOS8Dot3A([MarshalAs(UnmanagedType.LPStr)] string lpName, ReadOnlySpan<byte> lpOemName, int OemNameSize, cpointer pbNameContainsSpaces, cpointer pbNameLegal);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckNameLegalDOS8Dot3A([MarshalAs(UnmanagedType.LPStr)] string lpName, byte* lpOemName, int OemNameSize, cpointer pbNameContainsSpaces, cpointer pbNameLegal);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckNameLegalDOS8Dot3A(byte* lpName, [MarshalAs(UnmanagedType.LPStr)] string lpOemName, int OemNameSize, cpointer pbNameContainsSpaces, cpointer pbNameLegal);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckNameLegalDOS8Dot3A(byte* lpName, ReadOnlySpan<byte> lpOemName, int OemNameSize, cpointer pbNameContainsSpaces, cpointer pbNameLegal);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckNameLegalDOS8Dot3A(byte* lpName, byte* lpOemName, int OemNameSize, cpointer pbNameContainsSpaces, cpointer pbNameLegal);
    [DllImport(lib, EntryPoint = "CheckNameLegalDOS8Dot3W", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckNameLegalDOS8Dot3([MarshalAs(UnmanagedType.LPWStr)] string lpName, [MarshalAs(UnmanagedType.LPStr)] string lpOemName, int OemNameSize, cpointer pbNameContainsSpaces, cpointer pbNameLegal);
    [DllImport(lib, EntryPoint = "CheckNameLegalDOS8Dot3W", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckNameLegalDOS8Dot3([MarshalAs(UnmanagedType.LPWStr)] string lpName, ReadOnlySpan<byte> lpOemName, int OemNameSize, cpointer pbNameContainsSpaces, cpointer pbNameLegal);
    [DllImport(lib, EntryPoint = "CheckNameLegalDOS8Dot3W", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckNameLegalDOS8Dot3([MarshalAs(UnmanagedType.LPWStr)] string lpName, byte* lpOemName, int OemNameSize, cpointer pbNameContainsSpaces, cpointer pbNameLegal);
    [DllImport(lib, EntryPoint = "CheckNameLegalDOS8Dot3W", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckNameLegalDOS8Dot3(char* lpName, [MarshalAs(UnmanagedType.LPStr)] string lpOemName, int OemNameSize, cpointer pbNameContainsSpaces, cpointer pbNameLegal);
    [DllImport(lib, EntryPoint = "CheckNameLegalDOS8Dot3W", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckNameLegalDOS8Dot3(char* lpName, ReadOnlySpan<byte> lpOemName, int OemNameSize, cpointer pbNameContainsSpaces, cpointer pbNameLegal);
    [DllImport(lib, EntryPoint = "CheckNameLegalDOS8Dot3W", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckNameLegalDOS8Dot3(char* lpName, byte* lpOemName, int OemNameSize, cpointer pbNameContainsSpaces, cpointer pbNameLegal);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckNameLegalDOS8Dot3W([MarshalAs(UnmanagedType.LPWStr)] string lpName, [MarshalAs(UnmanagedType.LPStr)] string lpOemName, int OemNameSize, cpointer pbNameContainsSpaces, cpointer pbNameLegal);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckNameLegalDOS8Dot3W([MarshalAs(UnmanagedType.LPWStr)] string lpName, ReadOnlySpan<byte> lpOemName, int OemNameSize, cpointer pbNameContainsSpaces, cpointer pbNameLegal);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckNameLegalDOS8Dot3W([MarshalAs(UnmanagedType.LPWStr)] string lpName, byte* lpOemName, int OemNameSize, cpointer pbNameContainsSpaces, cpointer pbNameLegal);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckNameLegalDOS8Dot3W(char* lpName, [MarshalAs(UnmanagedType.LPStr)] string lpOemName, int OemNameSize, cpointer pbNameContainsSpaces, cpointer pbNameLegal);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckNameLegalDOS8Dot3W(char* lpName, ReadOnlySpan<byte> lpOemName, int OemNameSize, cpointer pbNameContainsSpaces, cpointer pbNameLegal);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckNameLegalDOS8Dot3W(char* lpName, byte* lpOemName, int OemNameSize, cpointer pbNameContainsSpaces, cpointer pbNameLegal);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstFileTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, cpointer unfoundType_FINDEX_INFO_LEVELS_fInfoLevelId, cpointer lpFindFileData, cpointer unfoundType_FINDEX_SEARCH_OPS_fSearchOp, cpointer lpSearchFilter, int dwAdditionalFlags, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstFileTransactedA(byte* lpFileName, cpointer unfoundType_FINDEX_INFO_LEVELS_fInfoLevelId, cpointer lpFindFileData, cpointer unfoundType_FINDEX_SEARCH_OPS_fSearchOp, cpointer lpSearchFilter, int dwAdditionalFlags, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "FindFirstFileTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstFileTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, cpointer unfoundType_FINDEX_INFO_LEVELS_fInfoLevelId, cpointer lpFindFileData, cpointer unfoundType_FINDEX_SEARCH_OPS_fSearchOp, cpointer lpSearchFilter, int dwAdditionalFlags, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "FindFirstFileTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstFileTransacted(char* lpFileName, cpointer unfoundType_FINDEX_INFO_LEVELS_fInfoLevelId, cpointer lpFindFileData, cpointer unfoundType_FINDEX_SEARCH_OPS_fSearchOp, cpointer lpSearchFilter, int dwAdditionalFlags, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstFileTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, cpointer unfoundType_FINDEX_INFO_LEVELS_fInfoLevelId, cpointer lpFindFileData, cpointer unfoundType_FINDEX_SEARCH_OPS_fSearchOp, cpointer lpSearchFilter, int dwAdditionalFlags, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstFileTransactedW(char* lpFileName, cpointer unfoundType_FINDEX_INFO_LEVELS_fInfoLevelId, cpointer lpFindFileData, cpointer unfoundType_FINDEX_SEARCH_OPS_fSearchOp, cpointer lpSearchFilter, int dwAdditionalFlags, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileA([MarshalAs(UnmanagedType.LPStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPStr)] string lpNewFileName, bool bFailIfExists);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileA([MarshalAs(UnmanagedType.LPStr)] string lpExistingFileName, byte* lpNewFileName, bool bFailIfExists);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileA(byte* lpExistingFileName, [MarshalAs(UnmanagedType.LPStr)] string lpNewFileName, bool bFailIfExists);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileA(byte* lpExistingFileName, byte* lpNewFileName, bool bFailIfExists);
    [DllImport(lib, EntryPoint = "CopyFileW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFile([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, bool bFailIfExists);
    [DllImport(lib, EntryPoint = "CopyFileW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFile([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, char* lpNewFileName, bool bFailIfExists);
    [DllImport(lib, EntryPoint = "CopyFileW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFile(char* lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, bool bFailIfExists);
    [DllImport(lib, EntryPoint = "CopyFileW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFile(char* lpExistingFileName, char* lpNewFileName, bool bFailIfExists);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileW([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, bool bFailIfExists);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileW([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, char* lpNewFileName, bool bFailIfExists);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileW(char* lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, bool bFailIfExists);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileW(char* lpExistingFileName, char* lpNewFileName, bool bFailIfExists);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileExA([MarshalAs(UnmanagedType.LPStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPStr)] string lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, cpointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileExA([MarshalAs(UnmanagedType.LPStr)] string lpExistingFileName, byte* lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, cpointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileExA(byte* lpExistingFileName, [MarshalAs(UnmanagedType.LPStr)] string lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, cpointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileExA(byte* lpExistingFileName, byte* lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, cpointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags);
    [DllImport(lib, EntryPoint = "CopyFileExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileEx([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, cpointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags);
    [DllImport(lib, EntryPoint = "CopyFileExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileEx([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, char* lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, cpointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags);
    [DllImport(lib, EntryPoint = "CopyFileExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileEx(char* lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, cpointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags);
    [DllImport(lib, EntryPoint = "CopyFileExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileEx(char* lpExistingFileName, char* lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, cpointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileExW([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, cpointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileExW([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, char* lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, cpointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileExW(char* lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, cpointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileExW(char* lpExistingFileName, char* lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, cpointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPStr)] string lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, cpointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpExistingFileName, byte* lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, cpointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileTransactedA(byte* lpExistingFileName, [MarshalAs(UnmanagedType.LPStr)] string lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, cpointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileTransactedA(byte* lpExistingFileName, byte* lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, cpointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "CopyFileTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, cpointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "CopyFileTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, char* lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, cpointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "CopyFileTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileTransacted(char* lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, cpointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "CopyFileTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileTransacted(char* lpExistingFileName, char* lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, cpointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, cpointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, char* lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, cpointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileTransactedW(char* lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, cpointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileTransactedW(char* lpExistingFileName, char* lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, cpointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CopyFile2([MarshalAs(UnmanagedType.LPWStr)] string pwszExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string pwszNewFileName, cpointer unfoundType_COPYFILE2_EXTENDED_PARAMETERSpExtendedParameterspExtendedParameters_unnamed_2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CopyFile2([MarshalAs(UnmanagedType.LPWStr)] string pwszExistingFileName, char* pwszNewFileName, cpointer unfoundType_COPYFILE2_EXTENDED_PARAMETERSpExtendedParameterspExtendedParameters_unnamed_2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CopyFile2(char* pwszExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string pwszNewFileName, cpointer unfoundType_COPYFILE2_EXTENDED_PARAMETERSpExtendedParameterspExtendedParameters_unnamed_2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CopyFile2(char* pwszExistingFileName, char* pwszNewFileName, cpointer unfoundType_COPYFILE2_EXTENDED_PARAMETERSpExtendedParameterspExtendedParameters_unnamed_2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileA([MarshalAs(UnmanagedType.LPStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPStr)] string lpNewFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileA([MarshalAs(UnmanagedType.LPStr)] string lpExistingFileName, byte* lpNewFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileA(byte* lpExistingFileName, [MarshalAs(UnmanagedType.LPStr)] string lpNewFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileA(byte* lpExistingFileName, byte* lpNewFileName);
    [DllImport(lib, EntryPoint = "MoveFileW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFile([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName);
    [DllImport(lib, EntryPoint = "MoveFileW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFile([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, char* lpNewFileName);
    [DllImport(lib, EntryPoint = "MoveFileW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFile(char* lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName);
    [DllImport(lib, EntryPoint = "MoveFileW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFile(char* lpExistingFileName, char* lpNewFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileW([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileW([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, char* lpNewFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileW(char* lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileW(char* lpExistingFileName, char* lpNewFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileExA([MarshalAs(UnmanagedType.LPStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPStr)] string lpNewFileName, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileExA([MarshalAs(UnmanagedType.LPStr)] string lpExistingFileName, byte* lpNewFileName, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileExA(byte* lpExistingFileName, [MarshalAs(UnmanagedType.LPStr)] string lpNewFileName, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileExA(byte* lpExistingFileName, byte* lpNewFileName, int dwFlags);
    [DllImport(lib, EntryPoint = "MoveFileExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileEx([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, int dwFlags);
    [DllImport(lib, EntryPoint = "MoveFileExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileEx([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, char* lpNewFileName, int dwFlags);
    [DllImport(lib, EntryPoint = "MoveFileExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileEx(char* lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, int dwFlags);
    [DllImport(lib, EntryPoint = "MoveFileExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileEx(char* lpExistingFileName, char* lpNewFileName, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileExW([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileExW([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, char* lpNewFileName, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileExW(char* lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileExW(char* lpExistingFileName, char* lpNewFileName, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileWithProgressA([MarshalAs(UnmanagedType.LPStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPStr)] string lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileWithProgressA([MarshalAs(UnmanagedType.LPStr)] string lpExistingFileName, byte* lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileWithProgressA(byte* lpExistingFileName, [MarshalAs(UnmanagedType.LPStr)] string lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileWithProgressA(byte* lpExistingFileName, byte* lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, int dwFlags);
    [DllImport(lib, EntryPoint = "MoveFileWithProgressW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileWithProgress([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, int dwFlags);
    [DllImport(lib, EntryPoint = "MoveFileWithProgressW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileWithProgress([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, char* lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, int dwFlags);
    [DllImport(lib, EntryPoint = "MoveFileWithProgressW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileWithProgress(char* lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, int dwFlags);
    [DllImport(lib, EntryPoint = "MoveFileWithProgressW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileWithProgress(char* lpExistingFileName, char* lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileWithProgressW([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileWithProgressW([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, char* lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileWithProgressW(char* lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileWithProgressW(char* lpExistingFileName, char* lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPStr)] string lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, int dwFlags, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpExistingFileName, byte* lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, int dwFlags, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileTransactedA(byte* lpExistingFileName, [MarshalAs(UnmanagedType.LPStr)] string lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, int dwFlags, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileTransactedA(byte* lpExistingFileName, byte* lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, int dwFlags, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "MoveFileTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, int dwFlags, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "MoveFileTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, char* lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, int dwFlags, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "MoveFileTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileTransacted(char* lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, int dwFlags, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "MoveFileTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileTransacted(char* lpExistingFileName, char* lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, int dwFlags, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, int dwFlags, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, char* lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, int dwFlags, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileTransactedW(char* lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, int dwFlags, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileTransactedW(char* lpExistingFileName, char* lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, int dwFlags, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFileA([MarshalAs(UnmanagedType.LPStr)] string lpReplacedFileName, [MarshalAs(UnmanagedType.LPStr)] string lpReplacementFileName, [MarshalAs(UnmanagedType.LPStr)] string lpBackupFileName, int dwReplaceFlags, cpointer lpExclude, cpointer lpReserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFileA([MarshalAs(UnmanagedType.LPStr)] string lpReplacedFileName, [MarshalAs(UnmanagedType.LPStr)] string lpReplacementFileName, byte* lpBackupFileName, int dwReplaceFlags, cpointer lpExclude, cpointer lpReserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFileA([MarshalAs(UnmanagedType.LPStr)] string lpReplacedFileName, byte* lpReplacementFileName, [MarshalAs(UnmanagedType.LPStr)] string lpBackupFileName, int dwReplaceFlags, cpointer lpExclude, cpointer lpReserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFileA([MarshalAs(UnmanagedType.LPStr)] string lpReplacedFileName, byte* lpReplacementFileName, byte* lpBackupFileName, int dwReplaceFlags, cpointer lpExclude, cpointer lpReserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFileA(byte* lpReplacedFileName, [MarshalAs(UnmanagedType.LPStr)] string lpReplacementFileName, [MarshalAs(UnmanagedType.LPStr)] string lpBackupFileName, int dwReplaceFlags, cpointer lpExclude, cpointer lpReserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFileA(byte* lpReplacedFileName, [MarshalAs(UnmanagedType.LPStr)] string lpReplacementFileName, byte* lpBackupFileName, int dwReplaceFlags, cpointer lpExclude, cpointer lpReserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFileA(byte* lpReplacedFileName, byte* lpReplacementFileName, [MarshalAs(UnmanagedType.LPStr)] string lpBackupFileName, int dwReplaceFlags, cpointer lpExclude, cpointer lpReserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFileA(byte* lpReplacedFileName, byte* lpReplacementFileName, byte* lpBackupFileName, int dwReplaceFlags, cpointer lpExclude, cpointer lpReserved);
    [DllImport(lib, EntryPoint = "ReplaceFileW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFile([MarshalAs(UnmanagedType.LPWStr)] string lpReplacedFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpReplacementFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpBackupFileName, int dwReplaceFlags, cpointer lpExclude, cpointer lpReserved);
    [DllImport(lib, EntryPoint = "ReplaceFileW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFile([MarshalAs(UnmanagedType.LPWStr)] string lpReplacedFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpReplacementFileName, char* lpBackupFileName, int dwReplaceFlags, cpointer lpExclude, cpointer lpReserved);
    [DllImport(lib, EntryPoint = "ReplaceFileW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFile([MarshalAs(UnmanagedType.LPWStr)] string lpReplacedFileName, char* lpReplacementFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpBackupFileName, int dwReplaceFlags, cpointer lpExclude, cpointer lpReserved);
    [DllImport(lib, EntryPoint = "ReplaceFileW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFile([MarshalAs(UnmanagedType.LPWStr)] string lpReplacedFileName, char* lpReplacementFileName, char* lpBackupFileName, int dwReplaceFlags, cpointer lpExclude, cpointer lpReserved);
    [DllImport(lib, EntryPoint = "ReplaceFileW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFile(char* lpReplacedFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpReplacementFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpBackupFileName, int dwReplaceFlags, cpointer lpExclude, cpointer lpReserved);
    [DllImport(lib, EntryPoint = "ReplaceFileW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFile(char* lpReplacedFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpReplacementFileName, char* lpBackupFileName, int dwReplaceFlags, cpointer lpExclude, cpointer lpReserved);
    [DllImport(lib, EntryPoint = "ReplaceFileW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFile(char* lpReplacedFileName, char* lpReplacementFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpBackupFileName, int dwReplaceFlags, cpointer lpExclude, cpointer lpReserved);
    [DllImport(lib, EntryPoint = "ReplaceFileW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFile(char* lpReplacedFileName, char* lpReplacementFileName, char* lpBackupFileName, int dwReplaceFlags, cpointer lpExclude, cpointer lpReserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFileW([MarshalAs(UnmanagedType.LPWStr)] string lpReplacedFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpReplacementFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpBackupFileName, int dwReplaceFlags, cpointer lpExclude, cpointer lpReserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFileW([MarshalAs(UnmanagedType.LPWStr)] string lpReplacedFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpReplacementFileName, char* lpBackupFileName, int dwReplaceFlags, cpointer lpExclude, cpointer lpReserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFileW([MarshalAs(UnmanagedType.LPWStr)] string lpReplacedFileName, char* lpReplacementFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpBackupFileName, int dwReplaceFlags, cpointer lpExclude, cpointer lpReserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFileW([MarshalAs(UnmanagedType.LPWStr)] string lpReplacedFileName, char* lpReplacementFileName, char* lpBackupFileName, int dwReplaceFlags, cpointer lpExclude, cpointer lpReserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFileW(char* lpReplacedFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpReplacementFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpBackupFileName, int dwReplaceFlags, cpointer lpExclude, cpointer lpReserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFileW(char* lpReplacedFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpReplacementFileName, char* lpBackupFileName, int dwReplaceFlags, cpointer lpExclude, cpointer lpReserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFileW(char* lpReplacedFileName, char* lpReplacementFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpBackupFileName, int dwReplaceFlags, cpointer lpExclude, cpointer lpReserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFileW(char* lpReplacedFileName, char* lpReplacementFileName, char* lpBackupFileName, int dwReplaceFlags, cpointer lpExclude, cpointer lpReserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLinkA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExistingFileName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLinkA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, byte* lpExistingFileName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLinkA(byte* lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExistingFileName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLinkA(byte* lpFileName, byte* lpExistingFileName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, EntryPoint = "CreateHardLinkW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLink([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, EntryPoint = "CreateHardLinkW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLink([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExistingFileName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, EntryPoint = "CreateHardLinkW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLink(char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, EntryPoint = "CreateHardLinkW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLink(char* lpFileName, char* lpExistingFileName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLinkW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLinkW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExistingFileName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLinkW(char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLinkW(char* lpFileName, char* lpExistingFileName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLinkTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExistingFileName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLinkTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, byte* lpExistingFileName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLinkTransactedA(byte* lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExistingFileName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLinkTransactedA(byte* lpFileName, byte* lpExistingFileName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "CreateHardLinkTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLinkTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "CreateHardLinkTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLinkTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExistingFileName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "CreateHardLinkTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLinkTransacted(char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "CreateHardLinkTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLinkTransacted(char* lpFileName, char* lpExistingFileName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLinkTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLinkTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExistingFileName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLinkTransactedW(char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLinkTransactedW(char* lpFileName, char* lpExistingFileName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "FindFirstStreamTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstStreamTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, cpointer unfoundType_STREAM_INFO_LEVELS_InfoLevel, cpointer lpFindStreamData, int dwFlags, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "FindFirstStreamTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstStreamTransacted(char* lpFileName, cpointer unfoundType_STREAM_INFO_LEVELS_InfoLevel, cpointer lpFindStreamData, int dwFlags, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstStreamTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, cpointer unfoundType_STREAM_INFO_LEVELS_InfoLevel, cpointer lpFindStreamData, int dwFlags, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstStreamTransactedW(char* lpFileName, cpointer unfoundType_STREAM_INFO_LEVELS_InfoLevel, cpointer lpFindStreamData, int dwFlags, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "FindFirstFileNameTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstFileNameTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwFlags, cpointer unfoundType_LPDWORD_StringLength, [MarshalAs(UnmanagedType.LPWStr)] string LinkName, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "FindFirstFileNameTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstFileNameTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwFlags, cpointer unfoundType_LPDWORD_StringLength, char* LinkName, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "FindFirstFileNameTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstFileNameTransacted(char* lpFileName, int dwFlags, cpointer unfoundType_LPDWORD_StringLength, [MarshalAs(UnmanagedType.LPWStr)] string LinkName, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "FindFirstFileNameTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstFileNameTransacted(char* lpFileName, int dwFlags, cpointer unfoundType_LPDWORD_StringLength, char* LinkName, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstFileNameTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwFlags, cpointer unfoundType_LPDWORD_StringLength, [MarshalAs(UnmanagedType.LPWStr)] string LinkName, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstFileNameTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwFlags, cpointer unfoundType_LPDWORD_StringLength, char* LinkName, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstFileNameTransactedW(char* lpFileName, int dwFlags, cpointer unfoundType_LPDWORD_StringLength, [MarshalAs(UnmanagedType.LPWStr)] string LinkName, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstFileNameTransactedW(char* lpFileName, int dwFlags, cpointer unfoundType_LPDWORD_StringLength, char* LinkName, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateNamedPipeA([MarshalAs(UnmanagedType.LPStr)] string lpName, int dwOpenMode, int dwPipeMode, int nMaxInstances, int nOutBufferSize, int nInBufferSize, int nDefaultTimeOut, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateNamedPipeA(byte* lpName, int dwOpenMode, int dwPipeMode, int nMaxInstances, int nOutBufferSize, int nInBufferSize, int nDefaultTimeOut, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNamedPipeHandleStateA(cpointer hNamedPipe, cpointer unfoundType_LPDWORD_lpState, cpointer unfoundType_LPDWORD_lpCurInstances, cpointer unfoundType_LPDWORD_lpMaxCollectionCount, cpointer unfoundType_LPDWORD_lpCollectDataTimeout, [MarshalAs(UnmanagedType.LPStr)] string lpUserName, int nMaxUserNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNamedPipeHandleStateA(cpointer hNamedPipe, cpointer unfoundType_LPDWORD_lpState, cpointer unfoundType_LPDWORD_lpCurInstances, cpointer unfoundType_LPDWORD_lpMaxCollectionCount, cpointer unfoundType_LPDWORD_lpCollectDataTimeout, ReadOnlySpan<byte> lpUserName, int nMaxUserNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNamedPipeHandleStateA(cpointer hNamedPipe, cpointer unfoundType_LPDWORD_lpState, cpointer unfoundType_LPDWORD_lpCurInstances, cpointer unfoundType_LPDWORD_lpMaxCollectionCount, cpointer unfoundType_LPDWORD_lpCollectDataTimeout, byte* lpUserName, int nMaxUserNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CallNamedPipeA([MarshalAs(UnmanagedType.LPStr)] string lpNamedPipeName, cpointer lpInBuffer, int nInBufferSize, cpointer lpOutBuffer, int nOutBufferSize, cpointer unfoundType_LPDWORD_lpBytesRead, int nTimeOut);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CallNamedPipeA(byte* lpNamedPipeName, cpointer lpInBuffer, int nInBufferSize, cpointer lpOutBuffer, int nOutBufferSize, cpointer unfoundType_LPDWORD_lpBytesRead, int nTimeOut);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WaitNamedPipeA([MarshalAs(UnmanagedType.LPStr)] string lpNamedPipeName, int nTimeOut);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WaitNamedPipeA(byte* lpNamedPipeName, int nTimeOut);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNamedPipeClientComputerNameA(cpointer Pipe, [MarshalAs(UnmanagedType.LPStr)] string ClientComputerName, uint ClientComputerNameLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNamedPipeClientComputerNameA(cpointer Pipe, ReadOnlySpan<byte> ClientComputerName, uint ClientComputerNameLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNamedPipeClientComputerNameA(cpointer Pipe, byte* ClientComputerName, uint ClientComputerNameLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNamedPipeClientProcessId(cpointer Pipe, cpointer unfoundType_PULONG_ClientProcessId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNamedPipeClientSessionId(cpointer Pipe, cpointer unfoundType_PULONG_ClientSessionId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNamedPipeServerProcessId(cpointer Pipe, cpointer unfoundType_PULONG_ServerProcessId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNamedPipeServerSessionId(cpointer Pipe, cpointer unfoundType_PULONG_ServerSessionId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetVolumeLabelA([MarshalAs(UnmanagedType.LPStr)] string lpRootPathName, [MarshalAs(UnmanagedType.LPStr)] string lpVolumeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetVolumeLabelA([MarshalAs(UnmanagedType.LPStr)] string lpRootPathName, byte* lpVolumeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetVolumeLabelA(byte* lpRootPathName, [MarshalAs(UnmanagedType.LPStr)] string lpVolumeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetVolumeLabelA(byte* lpRootPathName, byte* lpVolumeName);
    [DllImport(lib, EntryPoint = "SetVolumeLabelW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetVolumeLabel([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, [MarshalAs(UnmanagedType.LPWStr)] string lpVolumeName);
    [DllImport(lib, EntryPoint = "SetVolumeLabelW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetVolumeLabel([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, char* lpVolumeName);
    [DllImport(lib, EntryPoint = "SetVolumeLabelW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetVolumeLabel(char* lpRootPathName, [MarshalAs(UnmanagedType.LPWStr)] string lpVolumeName);
    [DllImport(lib, EntryPoint = "SetVolumeLabelW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetVolumeLabel(char* lpRootPathName, char* lpVolumeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetVolumeLabelW([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, [MarshalAs(UnmanagedType.LPWStr)] string lpVolumeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetVolumeLabelW([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, char* lpVolumeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetVolumeLabelW(char* lpRootPathName, [MarshalAs(UnmanagedType.LPWStr)] string lpVolumeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetVolumeLabelW(char* lpRootPathName, char* lpVolumeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFileBandwidthReservation(cpointer hFile, int nPeriodMilliseconds, int nBytesPerPeriod, bool bDiscardable, cpointer unfoundType_LPDWORD_lpTransferSize, cpointer unfoundType_LPDWORD_lpNumOutstandingRequests);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileBandwidthReservation(cpointer hFile, cpointer unfoundType_LPDWORD_lpPeriodMilliseconds, cpointer unfoundType_LPDWORD_lpBytesPerPeriod, cpointer unfoundType_LPBOOL_pDiscardable, cpointer unfoundType_LPDWORD_lpTransferSize, cpointer unfoundType_LPDWORD_lpNumOutstandingRequests);
    [DllImport(lib, EntryPoint = "ReadDirectoryChangesW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadDirectoryChanges(cpointer hDirectory, cpointer lpBuffer, int nBufferLength, bool bWatchSubtree, int dwNotifyFilter, cpointer unfoundType_LPDWORD_lpBytesReturned, cpointer unfoundType_LPOVERLAPPED_lpOverlapped, cpointer unfoundType_LPOVERLAPPED_COMPLETION_ROUTINE_lpCompletionRoutine);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadDirectoryChangesW(cpointer hDirectory, cpointer lpBuffer, int nBufferLength, bool bWatchSubtree, int dwNotifyFilter, cpointer unfoundType_LPDWORD_lpBytesReturned, cpointer unfoundType_LPOVERLAPPED_lpOverlapped, cpointer unfoundType_LPOVERLAPPED_COMPLETION_ROUTINE_lpCompletionRoutine);
    [DllImport(lib, EntryPoint = "ReadDirectoryChangesExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadDirectoryChangesEx(cpointer hDirectory, cpointer lpBuffer, int nBufferLength, bool bWatchSubtree, int dwNotifyFilter, cpointer unfoundType_LPDWORD_lpBytesReturned, cpointer unfoundType_LPOVERLAPPED_lpOverlapped, cpointer unfoundType_LPOVERLAPPED_COMPLETION_ROUTINE_lpCompletionRoutine, cpointer unfoundType_READ_DIRECTORY_NOTIFY_INFORMATION_CLASS_ReadDirectoryNotifyInformationClass);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadDirectoryChangesExW(cpointer hDirectory, cpointer lpBuffer, int nBufferLength, bool bWatchSubtree, int dwNotifyFilter, cpointer unfoundType_LPDWORD_lpBytesReturned, cpointer unfoundType_LPOVERLAPPED_lpOverlapped, cpointer unfoundType_LPOVERLAPPED_COMPLETION_ROUTINE_lpCompletionRoutine, cpointer unfoundType_READ_DIRECTORY_NOTIFY_INFORMATION_CLASS_ReadDirectoryNotifyInformationClass);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer MapViewOfFileExNuma(cpointer hFileMappingObject, int dwDesiredAccess, int dwFileOffsetHigh, int dwFileOffsetLow, cpointer dwNumberOfBytesToMap, cpointer lpBaseAddress, int nndPreferred);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsBadReadPtr(cpointer unfoundType_VOIDlplp_unnamed_0, ulong ucb);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsBadWritePtr(cpointer lp, ulong ucb);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsBadHugeReadPtr(cpointer unfoundType_VOIDlplp_unnamed_0, ulong ucb);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsBadHugeWritePtr(cpointer lp, ulong ucb);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsBadCodePtr(cpointer unfoundType__In_opt_PROC_lpfn);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsBadStringPtrA([MarshalAs(UnmanagedType.LPStr)] string lpsz, ulong ucchMax);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsBadStringPtrA(byte* lpsz, ulong ucchMax);
    [DllImport(lib, EntryPoint = "IsBadStringPtrW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsBadStringPtr([MarshalAs(UnmanagedType.LPWStr)] string lpsz, ulong ucchMax);
    [DllImport(lib, EntryPoint = "IsBadStringPtrW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsBadStringPtr(char* lpsz, ulong ucchMax);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsBadStringPtrW([MarshalAs(UnmanagedType.LPWStr)] string lpsz, ulong ucchMax);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsBadStringPtrW(char* lpsz, ulong ucchMax);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool BuildCommDCBA([MarshalAs(UnmanagedType.LPStr)] string lpDef, cpointer unfoundType_LPDCB_lpDCB);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool BuildCommDCBA(byte* lpDef, cpointer unfoundType_LPDCB_lpDCB);
    [DllImport(lib, EntryPoint = "BuildCommDCBW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool BuildCommDCB([MarshalAs(UnmanagedType.LPWStr)] string lpDef, cpointer unfoundType_LPDCB_lpDCB);
    [DllImport(lib, EntryPoint = "BuildCommDCBW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool BuildCommDCB(char* lpDef, cpointer unfoundType_LPDCB_lpDCB);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool BuildCommDCBW([MarshalAs(UnmanagedType.LPWStr)] string lpDef, cpointer unfoundType_LPDCB_lpDCB);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool BuildCommDCBW(char* lpDef, cpointer unfoundType_LPDCB_lpDCB);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool BuildCommDCBAndTimeoutsA([MarshalAs(UnmanagedType.LPStr)] string lpDef, cpointer unfoundType_LPDCB_lpDCB, cpointer unfoundType_LPCOMMTIMEOUTS_lpCommTimeouts);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool BuildCommDCBAndTimeoutsA(byte* lpDef, cpointer unfoundType_LPDCB_lpDCB, cpointer unfoundType_LPCOMMTIMEOUTS_lpCommTimeouts);
    [DllImport(lib, EntryPoint = "BuildCommDCBAndTimeoutsW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool BuildCommDCBAndTimeouts([MarshalAs(UnmanagedType.LPWStr)] string lpDef, cpointer unfoundType_LPDCB_lpDCB, cpointer unfoundType_LPCOMMTIMEOUTS_lpCommTimeouts);
    [DllImport(lib, EntryPoint = "BuildCommDCBAndTimeoutsW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool BuildCommDCBAndTimeouts(char* lpDef, cpointer unfoundType_LPDCB_lpDCB, cpointer unfoundType_LPCOMMTIMEOUTS_lpCommTimeouts);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool BuildCommDCBAndTimeoutsW([MarshalAs(UnmanagedType.LPWStr)] string lpDef, cpointer unfoundType_LPDCB_lpDCB, cpointer unfoundType_LPCOMMTIMEOUTS_lpCommTimeouts);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool BuildCommDCBAndTimeoutsW(char* lpDef, cpointer unfoundType_LPDCB_lpDCB, cpointer unfoundType_LPCOMMTIMEOUTS_lpCommTimeouts);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CommConfigDialogA([MarshalAs(UnmanagedType.LPStr)] string lpszName, cpointer hWnd, cpointer unfoundType_LPCOMMCONFIG_lpCC);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CommConfigDialogA(byte* lpszName, cpointer hWnd, cpointer unfoundType_LPCOMMCONFIG_lpCC);
    [DllImport(lib, EntryPoint = "CommConfigDialogW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CommConfigDialog([MarshalAs(UnmanagedType.LPWStr)] string lpszName, cpointer hWnd, cpointer unfoundType_LPCOMMCONFIG_lpCC);
    [DllImport(lib, EntryPoint = "CommConfigDialogW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CommConfigDialog(char* lpszName, cpointer hWnd, cpointer unfoundType_LPCOMMCONFIG_lpCC);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CommConfigDialogW([MarshalAs(UnmanagedType.LPWStr)] string lpszName, cpointer hWnd, cpointer unfoundType_LPCOMMCONFIG_lpCC);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CommConfigDialogW(char* lpszName, cpointer hWnd, cpointer unfoundType_LPCOMMCONFIG_lpCC);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetDefaultCommConfigA([MarshalAs(UnmanagedType.LPStr)] string lpszName, cpointer unfoundType_LPCOMMCONFIG_lpCC, cpointer unfoundType_LPDWORD_lpdwSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetDefaultCommConfigA(byte* lpszName, cpointer unfoundType_LPCOMMCONFIG_lpCC, cpointer unfoundType_LPDWORD_lpdwSize);
    [DllImport(lib, EntryPoint = "GetDefaultCommConfigW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetDefaultCommConfig([MarshalAs(UnmanagedType.LPWStr)] string lpszName, cpointer unfoundType_LPCOMMCONFIG_lpCC, cpointer unfoundType_LPDWORD_lpdwSize);
    [DllImport(lib, EntryPoint = "GetDefaultCommConfigW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetDefaultCommConfig(char* lpszName, cpointer unfoundType_LPCOMMCONFIG_lpCC, cpointer unfoundType_LPDWORD_lpdwSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetDefaultCommConfigW([MarshalAs(UnmanagedType.LPWStr)] string lpszName, cpointer unfoundType_LPCOMMCONFIG_lpCC, cpointer unfoundType_LPDWORD_lpdwSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetDefaultCommConfigW(char* lpszName, cpointer unfoundType_LPCOMMCONFIG_lpCC, cpointer unfoundType_LPDWORD_lpdwSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetDefaultCommConfigA([MarshalAs(UnmanagedType.LPStr)] string lpszName, cpointer unfoundType_LPCOMMCONFIG_lpCC, int dwSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetDefaultCommConfigA(byte* lpszName, cpointer unfoundType_LPCOMMCONFIG_lpCC, int dwSize);
    [DllImport(lib, EntryPoint = "SetDefaultCommConfigW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetDefaultCommConfig([MarshalAs(UnmanagedType.LPWStr)] string lpszName, cpointer unfoundType_LPCOMMCONFIG_lpCC, int dwSize);
    [DllImport(lib, EntryPoint = "SetDefaultCommConfigW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetDefaultCommConfig(char* lpszName, cpointer unfoundType_LPCOMMCONFIG_lpCC, int dwSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetDefaultCommConfigW([MarshalAs(UnmanagedType.LPWStr)] string lpszName, cpointer unfoundType_LPCOMMCONFIG_lpCC, int dwSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetDefaultCommConfigW(char* lpszName, cpointer unfoundType_LPCOMMCONFIG_lpCC, int dwSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetComputerNameA([MarshalAs(UnmanagedType.LPStr)] string lpBuffer, cpointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetComputerNameA(ReadOnlySpan<byte> lpBuffer, cpointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetComputerNameA(byte* lpBuffer, cpointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, EntryPoint = "GetComputerNameW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetComputerName(string lpBuffer, cpointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, EntryPoint = "GetComputerNameW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetComputerName(char* lpBuffer, cpointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetComputerNameW(string lpBuffer, cpointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetComputerNameW(char* lpBuffer, cpointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerNameA([MarshalAs(UnmanagedType.LPStr)] string Hostname, [MarshalAs(UnmanagedType.LPStr)] string ComputerName, cpointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerNameA([MarshalAs(UnmanagedType.LPStr)] string Hostname, ReadOnlySpan<byte> ComputerName, cpointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerNameA([MarshalAs(UnmanagedType.LPStr)] string Hostname, byte* ComputerName, cpointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerNameA(byte* Hostname, [MarshalAs(UnmanagedType.LPStr)] string ComputerName, cpointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerNameA(byte* Hostname, ReadOnlySpan<byte> ComputerName, cpointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerNameA(byte* Hostname, byte* ComputerName, cpointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, EntryPoint = "DnsHostnameToComputerNameW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerName([MarshalAs(UnmanagedType.LPWStr)] string Hostname, string ComputerName, cpointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, EntryPoint = "DnsHostnameToComputerNameW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerName([MarshalAs(UnmanagedType.LPWStr)] string Hostname, char* ComputerName, cpointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, EntryPoint = "DnsHostnameToComputerNameW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerName(char* Hostname, string ComputerName, cpointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, EntryPoint = "DnsHostnameToComputerNameW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerName(char* Hostname, char* ComputerName, cpointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerNameW([MarshalAs(UnmanagedType.LPWStr)] string Hostname, string ComputerName, cpointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerNameW([MarshalAs(UnmanagedType.LPWStr)] string Hostname, char* ComputerName, cpointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerNameW(char* Hostname, string ComputerName, cpointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerNameW(char* Hostname, char* ComputerName, cpointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool RegisterWaitForSingleObject(cpointer unfoundType_PHANDLE_phNewWaitObject, cpointer hObject, cpointer unfoundType_WAITORTIMERCALLBACK_Callback, cpointer Context, uint dwMilliseconds, uint dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UnregisterWait(cpointer WaitHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool BindIoCompletionCallback(cpointer FileHandle, cpointer unfoundType_LPOVERLAPPED_COMPLETION_ROUTINE_Function, uint Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer SetTimerQueueTimer(cpointer TimerQueue, cpointer unfoundType_WAITORTIMERCALLBACK_Callback, cpointer Parameter, int DueTime, int Period, bool PreferIo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CancelTimerQueueTimer(cpointer TimerQueue, cpointer Timer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreatePrivateNamespaceA(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpPrivateNamespaceAttributes, cpointer lpBoundaryDescriptor, [MarshalAs(UnmanagedType.LPStr)] string lpAliasPrefix);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreatePrivateNamespaceA(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpPrivateNamespaceAttributes, cpointer lpBoundaryDescriptor, byte* lpAliasPrefix);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenPrivateNamespaceA(cpointer lpBoundaryDescriptor, [MarshalAs(UnmanagedType.LPStr)] string lpAliasPrefix);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenPrivateNamespaceA(cpointer lpBoundaryDescriptor, byte* lpAliasPrefix);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateBoundaryDescriptorA([MarshalAs(UnmanagedType.LPStr)] string Name, uint Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateBoundaryDescriptorA(byte* Name, uint Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddIntegrityLabelToBoundaryDescriptor(cpointer BoundaryDescriptor, cpointer unfoundType_PSID_IntegrityLabel);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool VerifyVersionInfoA(cpointer unfoundType_LPOSVERSIONINFOEXA_lpVersionInformation, int dwTypeMask, cpointer unfoundType_DWORDLONG_dwlConditionMask);
    [DllImport(lib, EntryPoint = "VerifyVersionInfoW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool VerifyVersionInfo(cpointer unfoundType_LPOSVERSIONINFOEXW_lpVersionInformation, int dwTypeMask, cpointer unfoundType_DWORDLONG_dwlConditionMask);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool VerifyVersionInfoW(cpointer unfoundType_LPOSVERSIONINFOEXW_lpVersionInformation, int dwTypeMask, cpointer unfoundType_DWORDLONG_dwlConditionMask);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetSystemPowerState(bool fSuspend, bool fForce);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetSystemPowerStatus(cpointer unfoundType_LPSYSTEM_POWER_STATUS_lpSystemPowerStatus);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MapUserPhysicalPagesScatter(cpointer unfoundType_PVOIDVirtualAddressesVirtualAddresses_unnamed_0, cpointer unfoundType_ULONG_PTR_NumberOfPages, cpointer PageArray);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateJobObjectA(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpJobAttributes, [MarshalAs(UnmanagedType.LPStr)] string lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateJobObjectA(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpJobAttributes, byte* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenJobObjectA(int dwDesiredAccess, bool bInheritHandle, [MarshalAs(UnmanagedType.LPStr)] string lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenJobObjectA(int dwDesiredAccess, bool bInheritHandle, byte* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateJobSet(uint NumJob, cpointer unfoundType_PJOB_SET_ARRAY_UserJobSet, uint Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstVolumeA([MarshalAs(UnmanagedType.LPStr)] string lpszVolumeName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstVolumeA(ReadOnlySpan<byte> lpszVolumeName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstVolumeA(byte* lpszVolumeName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextVolumeA(cpointer hFindVolume, [MarshalAs(UnmanagedType.LPStr)] string lpszVolumeName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextVolumeA(cpointer hFindVolume, ReadOnlySpan<byte> lpszVolumeName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextVolumeA(cpointer hFindVolume, byte* lpszVolumeName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstVolumeMountPointA([MarshalAs(UnmanagedType.LPStr)] string lpszRootPathName, [MarshalAs(UnmanagedType.LPStr)] string lpszVolumeMountPoint, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstVolumeMountPointA([MarshalAs(UnmanagedType.LPStr)] string lpszRootPathName, ReadOnlySpan<byte> lpszVolumeMountPoint, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstVolumeMountPointA([MarshalAs(UnmanagedType.LPStr)] string lpszRootPathName, byte* lpszVolumeMountPoint, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstVolumeMountPointA(byte* lpszRootPathName, [MarshalAs(UnmanagedType.LPStr)] string lpszVolumeMountPoint, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstVolumeMountPointA(byte* lpszRootPathName, ReadOnlySpan<byte> lpszVolumeMountPoint, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstVolumeMountPointA(byte* lpszRootPathName, byte* lpszVolumeMountPoint, int cchBufferLength);
    [DllImport(lib, EntryPoint = "FindFirstVolumeMountPointW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstVolumeMountPoint([MarshalAs(UnmanagedType.LPWStr)] string lpszRootPathName, string lpszVolumeMountPoint, int cchBufferLength);
    [DllImport(lib, EntryPoint = "FindFirstVolumeMountPointW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstVolumeMountPoint([MarshalAs(UnmanagedType.LPWStr)] string lpszRootPathName, char* lpszVolumeMountPoint, int cchBufferLength);
    [DllImport(lib, EntryPoint = "FindFirstVolumeMountPointW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstVolumeMountPoint(char* lpszRootPathName, string lpszVolumeMountPoint, int cchBufferLength);
    [DllImport(lib, EntryPoint = "FindFirstVolumeMountPointW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstVolumeMountPoint(char* lpszRootPathName, char* lpszVolumeMountPoint, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstVolumeMountPointW([MarshalAs(UnmanagedType.LPWStr)] string lpszRootPathName, string lpszVolumeMountPoint, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstVolumeMountPointW([MarshalAs(UnmanagedType.LPWStr)] string lpszRootPathName, char* lpszVolumeMountPoint, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstVolumeMountPointW(char* lpszRootPathName, string lpszVolumeMountPoint, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer FindFirstVolumeMountPointW(char* lpszRootPathName, char* lpszVolumeMountPoint, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextVolumeMountPointA(cpointer hFindVolumeMountPoint, [MarshalAs(UnmanagedType.LPStr)] string lpszVolumeMountPoint, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextVolumeMountPointA(cpointer hFindVolumeMountPoint, ReadOnlySpan<byte> lpszVolumeMountPoint, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextVolumeMountPointA(cpointer hFindVolumeMountPoint, byte* lpszVolumeMountPoint, int cchBufferLength);
    [DllImport(lib, EntryPoint = "FindNextVolumeMountPointW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextVolumeMountPoint(cpointer hFindVolumeMountPoint, string lpszVolumeMountPoint, int cchBufferLength);
    [DllImport(lib, EntryPoint = "FindNextVolumeMountPointW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextVolumeMountPoint(cpointer hFindVolumeMountPoint, char* lpszVolumeMountPoint, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextVolumeMountPointW(cpointer hFindVolumeMountPoint, string lpszVolumeMountPoint, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextVolumeMountPointW(cpointer hFindVolumeMountPoint, char* lpszVolumeMountPoint, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindVolumeMountPointClose(cpointer hFindVolumeMountPoint);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetVolumeMountPointA([MarshalAs(UnmanagedType.LPStr)] string lpszVolumeMountPoint, [MarshalAs(UnmanagedType.LPStr)] string lpszVolumeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetVolumeMountPointA([MarshalAs(UnmanagedType.LPStr)] string lpszVolumeMountPoint, byte* lpszVolumeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetVolumeMountPointA(byte* lpszVolumeMountPoint, [MarshalAs(UnmanagedType.LPStr)] string lpszVolumeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetVolumeMountPointA(byte* lpszVolumeMountPoint, byte* lpszVolumeName);
    [DllImport(lib, EntryPoint = "SetVolumeMountPointW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetVolumeMountPoint([MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeMountPoint, [MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeName);
    [DllImport(lib, EntryPoint = "SetVolumeMountPointW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetVolumeMountPoint([MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeMountPoint, char* lpszVolumeName);
    [DllImport(lib, EntryPoint = "SetVolumeMountPointW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetVolumeMountPoint(char* lpszVolumeMountPoint, [MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeName);
    [DllImport(lib, EntryPoint = "SetVolumeMountPointW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetVolumeMountPoint(char* lpszVolumeMountPoint, char* lpszVolumeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetVolumeMountPointW([MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeMountPoint, [MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetVolumeMountPointW([MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeMountPoint, char* lpszVolumeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetVolumeMountPointW(char* lpszVolumeMountPoint, [MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetVolumeMountPointW(char* lpszVolumeMountPoint, char* lpszVolumeName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DeleteVolumeMountPointA([MarshalAs(UnmanagedType.LPStr)] string lpszVolumeMountPoint);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DeleteVolumeMountPointA(byte* lpszVolumeMountPoint);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeNameForVolumeMountPointA([MarshalAs(UnmanagedType.LPStr)] string lpszVolumeMountPoint, [MarshalAs(UnmanagedType.LPStr)] string lpszVolumeName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeNameForVolumeMountPointA([MarshalAs(UnmanagedType.LPStr)] string lpszVolumeMountPoint, ReadOnlySpan<byte> lpszVolumeName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeNameForVolumeMountPointA([MarshalAs(UnmanagedType.LPStr)] string lpszVolumeMountPoint, byte* lpszVolumeName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeNameForVolumeMountPointA(byte* lpszVolumeMountPoint, [MarshalAs(UnmanagedType.LPStr)] string lpszVolumeName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeNameForVolumeMountPointA(byte* lpszVolumeMountPoint, ReadOnlySpan<byte> lpszVolumeName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeNameForVolumeMountPointA(byte* lpszVolumeMountPoint, byte* lpszVolumeName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumePathNameA([MarshalAs(UnmanagedType.LPStr)] string lpszFileName, [MarshalAs(UnmanagedType.LPStr)] string lpszVolumePathName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumePathNameA([MarshalAs(UnmanagedType.LPStr)] string lpszFileName, ReadOnlySpan<byte> lpszVolumePathName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumePathNameA([MarshalAs(UnmanagedType.LPStr)] string lpszFileName, byte* lpszVolumePathName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumePathNameA(byte* lpszFileName, [MarshalAs(UnmanagedType.LPStr)] string lpszVolumePathName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumePathNameA(byte* lpszFileName, ReadOnlySpan<byte> lpszVolumePathName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumePathNameA(byte* lpszFileName, byte* lpszVolumePathName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumePathNamesForVolumeNameA([MarshalAs(UnmanagedType.LPStr)] string lpszVolumeName, cpointer unfoundType_LPCH_lpszVolumePathNames, int cchBufferLength, cpointer unfoundType_PDWORD_lpcchReturnLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumePathNamesForVolumeNameA(byte* lpszVolumeName, cpointer unfoundType_LPCH_lpszVolumePathNames, int cchBufferLength, cpointer unfoundType_PDWORD_lpcchReturnLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateActCtxA(cpointer unfoundType_PCACTCTXA_pActCtx);
    [DllImport(lib, EntryPoint = "CreateActCtxW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateActCtx(cpointer unfoundType_PCACTCTXW_pActCtx);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateActCtxW(cpointer unfoundType_PCACTCTXW_pActCtx);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void AddRefActCtx(cpointer hActCtx);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void ReleaseActCtx(cpointer hActCtx);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ZombifyActCtx(cpointer hActCtx);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ActivateActCtx(cpointer hActCtx, cpointer unfoundType_ULONG_PTRlpCookielpCookie_unnamed_1);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DeactivateActCtx(int dwFlags, cpointer unfoundType_ULONG_PTR_ulCookie);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetCurrentActCtx(cpointer unfoundType_HANDLElphActCtxlphActCtx_unnamed_0);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindActCtxSectionStringA(int dwFlags, cpointer unfoundType_GUIDlpExtensionGuidlpExtensionGuid_unnamed_1, uint ulSectionId, [MarshalAs(UnmanagedType.LPStr)] string lpStringToFind, cpointer unfoundType_PACTCTX_SECTION_KEYED_DATA_ReturnedData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindActCtxSectionStringA(int dwFlags, cpointer unfoundType_GUIDlpExtensionGuidlpExtensionGuid_unnamed_1, uint ulSectionId, byte* lpStringToFind, cpointer unfoundType_PACTCTX_SECTION_KEYED_DATA_ReturnedData);
    [DllImport(lib, EntryPoint = "FindActCtxSectionStringW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindActCtxSectionString(int dwFlags, cpointer unfoundType_GUIDlpExtensionGuidlpExtensionGuid_unnamed_1, uint ulSectionId, [MarshalAs(UnmanagedType.LPWStr)] string lpStringToFind, cpointer unfoundType_PACTCTX_SECTION_KEYED_DATA_ReturnedData);
    [DllImport(lib, EntryPoint = "FindActCtxSectionStringW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindActCtxSectionString(int dwFlags, cpointer unfoundType_GUIDlpExtensionGuidlpExtensionGuid_unnamed_1, uint ulSectionId, char* lpStringToFind, cpointer unfoundType_PACTCTX_SECTION_KEYED_DATA_ReturnedData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindActCtxSectionStringW(int dwFlags, cpointer unfoundType_GUIDlpExtensionGuidlpExtensionGuid_unnamed_1, uint ulSectionId, [MarshalAs(UnmanagedType.LPWStr)] string lpStringToFind, cpointer unfoundType_PACTCTX_SECTION_KEYED_DATA_ReturnedData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindActCtxSectionStringW(int dwFlags, cpointer unfoundType_GUIDlpExtensionGuidlpExtensionGuid_unnamed_1, uint ulSectionId, char* lpStringToFind, cpointer unfoundType_PACTCTX_SECTION_KEYED_DATA_ReturnedData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindActCtxSectionGuid(int dwFlags, cpointer unfoundType_GUIDlpExtensionGuidlpExtensionGuid_unnamed_1, uint ulSectionId, cpointer unfoundType_GUIDlpGuidToFindlpGuidToFind_unnamed_3, cpointer unfoundType_PACTCTX_SECTION_KEYED_DATA_ReturnedData);
    [DllImport(lib, EntryPoint = "QueryActCtxW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryActCtx(int dwFlags, cpointer hActCtx, cpointer pvSubInstance, uint ulInfoClass, cpointer pvBuffer, cpointer cbBuffer, cpointer unfoundType_SIZE_TpcbWrittenOrRequiredpcbWrittenOrRequired_unnamed_6);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryActCtxW(int dwFlags, cpointer hActCtx, cpointer pvSubInstance, uint ulInfoClass, cpointer pvBuffer, cpointer cbBuffer, cpointer unfoundType_SIZE_TpcbWrittenOrRequiredpcbWrittenOrRequired_unnamed_6);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int WTSGetActiveConsoleSessionId();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        short GetActiveProcessorGroupCount();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        short GetMaximumProcessorGroupCount();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetActiveProcessorCount(short GroupNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetMaximumProcessorCount(short GroupNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNumaProcessorNode(byte Processor, cpointer unfoundType_PUCHAR_NodeNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNumaNodeNumberFromHandle(cpointer hFile, cpointer unfoundType_PUSHORT_NodeNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNumaProcessorNodeEx(cpointer unfoundType_PPROCESSOR_NUMBER_Processor, cpointer unfoundType_PUSHORT_NodeNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNumaNodeProcessorMask(byte Node, cpointer unfoundType_PULONGLONG_ProcessorMask);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNumaAvailableMemoryNode(byte Node, cpointer unfoundType_PULONGLONG_AvailableBytes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNumaAvailableMemoryNodeEx(ushort Node, cpointer unfoundType_PULONGLONG_AvailableBytes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNumaProximityNode(uint ProximityId, cpointer unfoundType_PUCHAR_NodeNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegisterApplicationRecoveryCallback(cpointer unfoundType_APPLICATION_RECOVERY_CALLBACK_pRecoveyCallback, cpointer pvParameter, int dwPingInterval, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer UnregisterApplicationRecoveryCallback();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegisterApplicationRestart([MarshalAs(UnmanagedType.LPWStr)] string pwzCommandline, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegisterApplicationRestart(char* pwzCommandline, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer UnregisterApplicationRestart();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetApplicationRecoveryCallback(cpointer hProcess, cpointer unfoundType_APPLICATION_RECOVERY_CALLBACK_pRecoveryCallback, cpointer ppvParameter, cpointer unfoundType_PDWORD_pdwPingInterval, cpointer unfoundType_PDWORD_pdwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetApplicationRestartSettings(cpointer hProcess, [MarshalAs(UnmanagedType.LPWStr)] string pwzCommandline, cpointer unfoundType_PDWORD_pcchSize, cpointer unfoundType_PDWORD_pdwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetApplicationRestartSettings(cpointer hProcess, char* pwzCommandline, cpointer unfoundType_PDWORD_pcchSize, cpointer unfoundType_PDWORD_pdwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer ApplicationRecoveryInProgress(cpointer pbCancelled);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void ApplicationRecoveryFinished(bool bSuccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileInformationByHandleEx(cpointer hFile, cpointer unfoundType_FILE_INFO_BY_HANDLE_CLASS_FileInformationClass, cpointer lpFileInformation, int dwBufferSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer OpenFileById(cpointer hVolumeHint, cpointer unfoundType_LPFILE_ID_DESCRIPTOR_lpFileId, int dwDesiredAccess, int dwShareMode, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int dwFlagsAndAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateSymbolicLinkA([MarshalAs(UnmanagedType.LPStr)] string lpSymlinkFileName, [MarshalAs(UnmanagedType.LPStr)] string lpTargetFileName, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateSymbolicLinkA([MarshalAs(UnmanagedType.LPStr)] string lpSymlinkFileName, byte* lpTargetFileName, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateSymbolicLinkA(byte* lpSymlinkFileName, [MarshalAs(UnmanagedType.LPStr)] string lpTargetFileName, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateSymbolicLinkA(byte* lpSymlinkFileName, byte* lpTargetFileName, int dwFlags);
    [DllImport(lib, EntryPoint = "CreateSymbolicLinkW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateSymbolicLink([MarshalAs(UnmanagedType.LPWStr)] string lpSymlinkFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpTargetFileName, int dwFlags);
    [DllImport(lib, EntryPoint = "CreateSymbolicLinkW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateSymbolicLink([MarshalAs(UnmanagedType.LPWStr)] string lpSymlinkFileName, char* lpTargetFileName, int dwFlags);
    [DllImport(lib, EntryPoint = "CreateSymbolicLinkW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateSymbolicLink(char* lpSymlinkFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpTargetFileName, int dwFlags);
    [DllImport(lib, EntryPoint = "CreateSymbolicLinkW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateSymbolicLink(char* lpSymlinkFileName, char* lpTargetFileName, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateSymbolicLinkW([MarshalAs(UnmanagedType.LPWStr)] string lpSymlinkFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpTargetFileName, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateSymbolicLinkW([MarshalAs(UnmanagedType.LPWStr)] string lpSymlinkFileName, char* lpTargetFileName, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateSymbolicLinkW(char* lpSymlinkFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpTargetFileName, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateSymbolicLinkW(char* lpSymlinkFileName, char* lpTargetFileName, int dwFlags);
    [DllImport(lib, EntryPoint = "QueryActCtxSettingsW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryActCtxSettings(int dwFlags, cpointer hActCtx, [MarshalAs(UnmanagedType.LPWStr)] string settingsNameSpace, [MarshalAs(UnmanagedType.LPWStr)] string settingName, [MarshalAs(UnmanagedType.LPWStr)] string pvBuffer, cpointer dwBuffer, cpointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport(lib, EntryPoint = "QueryActCtxSettingsW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryActCtxSettings(int dwFlags, cpointer hActCtx, [MarshalAs(UnmanagedType.LPWStr)] string settingsNameSpace, [MarshalAs(UnmanagedType.LPWStr)] string settingName, char* pvBuffer, cpointer dwBuffer, cpointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport(lib, EntryPoint = "QueryActCtxSettingsW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryActCtxSettings(int dwFlags, cpointer hActCtx, [MarshalAs(UnmanagedType.LPWStr)] string settingsNameSpace, char* settingName, [MarshalAs(UnmanagedType.LPWStr)] string pvBuffer, cpointer dwBuffer, cpointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport(lib, EntryPoint = "QueryActCtxSettingsW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryActCtxSettings(int dwFlags, cpointer hActCtx, [MarshalAs(UnmanagedType.LPWStr)] string settingsNameSpace, char* settingName, char* pvBuffer, cpointer dwBuffer, cpointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport(lib, EntryPoint = "QueryActCtxSettingsW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryActCtxSettings(int dwFlags, cpointer hActCtx, char* settingsNameSpace, [MarshalAs(UnmanagedType.LPWStr)] string settingName, [MarshalAs(UnmanagedType.LPWStr)] string pvBuffer, cpointer dwBuffer, cpointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport(lib, EntryPoint = "QueryActCtxSettingsW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryActCtxSettings(int dwFlags, cpointer hActCtx, char* settingsNameSpace, [MarshalAs(UnmanagedType.LPWStr)] string settingName, char* pvBuffer, cpointer dwBuffer, cpointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport(lib, EntryPoint = "QueryActCtxSettingsW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryActCtxSettings(int dwFlags, cpointer hActCtx, char* settingsNameSpace, char* settingName, [MarshalAs(UnmanagedType.LPWStr)] string pvBuffer, cpointer dwBuffer, cpointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport(lib, EntryPoint = "QueryActCtxSettingsW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryActCtxSettings(int dwFlags, cpointer hActCtx, char* settingsNameSpace, char* settingName, char* pvBuffer, cpointer dwBuffer, cpointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryActCtxSettingsW(int dwFlags, cpointer hActCtx, [MarshalAs(UnmanagedType.LPWStr)] string settingsNameSpace, [MarshalAs(UnmanagedType.LPWStr)] string settingName, [MarshalAs(UnmanagedType.LPWStr)] string pvBuffer, cpointer dwBuffer, cpointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryActCtxSettingsW(int dwFlags, cpointer hActCtx, [MarshalAs(UnmanagedType.LPWStr)] string settingsNameSpace, [MarshalAs(UnmanagedType.LPWStr)] string settingName, char* pvBuffer, cpointer dwBuffer, cpointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryActCtxSettingsW(int dwFlags, cpointer hActCtx, [MarshalAs(UnmanagedType.LPWStr)] string settingsNameSpace, char* settingName, [MarshalAs(UnmanagedType.LPWStr)] string pvBuffer, cpointer dwBuffer, cpointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryActCtxSettingsW(int dwFlags, cpointer hActCtx, [MarshalAs(UnmanagedType.LPWStr)] string settingsNameSpace, char* settingName, char* pvBuffer, cpointer dwBuffer, cpointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryActCtxSettingsW(int dwFlags, cpointer hActCtx, char* settingsNameSpace, [MarshalAs(UnmanagedType.LPWStr)] string settingName, [MarshalAs(UnmanagedType.LPWStr)] string pvBuffer, cpointer dwBuffer, cpointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryActCtxSettingsW(int dwFlags, cpointer hActCtx, char* settingsNameSpace, [MarshalAs(UnmanagedType.LPWStr)] string settingName, char* pvBuffer, cpointer dwBuffer, cpointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryActCtxSettingsW(int dwFlags, cpointer hActCtx, char* settingsNameSpace, char* settingName, [MarshalAs(UnmanagedType.LPWStr)] string pvBuffer, cpointer dwBuffer, cpointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryActCtxSettingsW(int dwFlags, cpointer hActCtx, char* settingsNameSpace, char* settingName, char* pvBuffer, cpointer dwBuffer, cpointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateSymbolicLinkTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpSymlinkFileName, [MarshalAs(UnmanagedType.LPStr)] string lpTargetFileName, int dwFlags, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateSymbolicLinkTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpSymlinkFileName, byte* lpTargetFileName, int dwFlags, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateSymbolicLinkTransactedA(byte* lpSymlinkFileName, [MarshalAs(UnmanagedType.LPStr)] string lpTargetFileName, int dwFlags, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateSymbolicLinkTransactedA(byte* lpSymlinkFileName, byte* lpTargetFileName, int dwFlags, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "CreateSymbolicLinkTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateSymbolicLinkTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpSymlinkFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpTargetFileName, int dwFlags, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "CreateSymbolicLinkTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateSymbolicLinkTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpSymlinkFileName, char* lpTargetFileName, int dwFlags, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "CreateSymbolicLinkTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateSymbolicLinkTransacted(char* lpSymlinkFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpTargetFileName, int dwFlags, cpointer hTransaction);
    [DllImport(lib, EntryPoint = "CreateSymbolicLinkTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateSymbolicLinkTransacted(char* lpSymlinkFileName, char* lpTargetFileName, int dwFlags, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateSymbolicLinkTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpSymlinkFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpTargetFileName, int dwFlags, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateSymbolicLinkTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpSymlinkFileName, char* lpTargetFileName, int dwFlags, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateSymbolicLinkTransactedW(char* lpSymlinkFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpTargetFileName, int dwFlags, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer CreateSymbolicLinkTransactedW(char* lpSymlinkFileName, char* lpTargetFileName, int dwFlags, cpointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplacePartitionUnit([MarshalAs(UnmanagedType.LPWStr)] string TargetPartition, [MarshalAs(UnmanagedType.LPWStr)] string SparePartition, uint Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplacePartitionUnit([MarshalAs(UnmanagedType.LPWStr)] string TargetPartition, char* SparePartition, uint Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplacePartitionUnit(char* TargetPartition, [MarshalAs(UnmanagedType.LPWStr)] string SparePartition, uint Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplacePartitionUnit(char* TargetPartition, char* SparePartition, uint Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddSecureMemoryCacheCallback(cpointer unfoundType_PSECURE_MEMORY_CACHE_CALLBACK_pfnCallBack);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool RemoveSecureMemoryCacheCallback(cpointer unfoundType_PSECURE_MEMORY_CACHE_CALLBACK_pfnCallBack);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyContext(cpointer unfoundType_PCONTEXT_Destination, int ContextFlags, cpointer unfoundType_PCONTEXT_Source);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool InitializeContext(cpointer Buffer, int ContextFlags, cpointer unfoundType_PCONTEXT_Context, cpointer unfoundType_PDWORD_ContextLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool InitializeContext2(cpointer Buffer, int ContextFlags, cpointer unfoundType_PCONTEXT_Context, cpointer unfoundType_PDWORD_ContextLength, cpointer unfoundType_ULONG64_XStateCompactionMask);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetEnabledXStateFeatures();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetXStateFeaturesMask(cpointer unfoundType_PCONTEXT_Context, cpointer unfoundType_PDWORD64_FeatureMask);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer LocateXStateFeature(cpointer unfoundType_PCONTEXT_Context, int FeatureId, cpointer unfoundType_PDWORD_Length);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetXStateFeaturesMask(cpointer unfoundType_PCONTEXT_Context, cpointer unfoundType_DWORD64_FeatureMask);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetThreadEnabledXStateFeatures();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnableProcessOptionalXStateFeatures(cpointer unfoundType_DWORD64_Features);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int EnableThreadProfiling(cpointer ThreadHandle, int Flags, cpointer unfoundType_DWORD64_HardwareCounters, cpointer unfoundType_HANDLEPerformanceDataHandlePerformanceDataHandle_unnamed_3);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int DisableThreadProfiling(cpointer PerformanceDataHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int QueryThreadProfiling(cpointer ThreadHandle, cpointer unfoundType_PBOOLEAN_Enabled);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ReadThreadProfilingData(cpointer PerformanceDataHandle, int Flags, cpointer unfoundType_PPERFORMANCE_DATA_PerformanceData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CeipIsOptedIn();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegCloseKey(nint hKey);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegOpenUserClassesRoot(cpointer hToken, int dwOptions, cpointer unfoundType_REGSAM_samDesired, cpointer phkResult);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegOpenCurrentUser(cpointer unfoundType_REGSAM_samDesired, cpointer phkResult);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegDisablePredefinedCacheEx();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegCreateKeyExA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string lpSubKey, int Reserved, [MarshalAs(UnmanagedType.LPStr)] string lpClass, int dwOptions, cpointer unfoundType_REGSAM_samDesired, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer phkResult, cpointer unfoundType_LPDWORD_lpdwDisposition);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegCreateKeyExA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string lpSubKey, int Reserved, ReadOnlySpan<byte> lpClass, int dwOptions, cpointer unfoundType_REGSAM_samDesired, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer phkResult, cpointer unfoundType_LPDWORD_lpdwDisposition);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegCreateKeyExA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string lpSubKey, int Reserved, byte* lpClass, int dwOptions, cpointer unfoundType_REGSAM_samDesired, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer phkResult, cpointer unfoundType_LPDWORD_lpdwDisposition);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegCreateKeyExA(nint hKey, byte* lpSubKey, int Reserved, [MarshalAs(UnmanagedType.LPStr)] string lpClass, int dwOptions, cpointer unfoundType_REGSAM_samDesired, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer phkResult, cpointer unfoundType_LPDWORD_lpdwDisposition);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegCreateKeyExA(nint hKey, byte* lpSubKey, int Reserved, ReadOnlySpan<byte> lpClass, int dwOptions, cpointer unfoundType_REGSAM_samDesired, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer phkResult, cpointer unfoundType_LPDWORD_lpdwDisposition);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegCreateKeyExA(nint hKey, byte* lpSubKey, int Reserved, byte* lpClass, int dwOptions, cpointer unfoundType_REGSAM_samDesired, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer phkResult, cpointer unfoundType_LPDWORD_lpdwDisposition);
    [DllImport(lib, EntryPoint = "RegCreateKeyExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegCreateKeyEx(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, int Reserved, string lpClass, int dwOptions, cpointer unfoundType_REGSAM_samDesired, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer phkResult, cpointer unfoundType_LPDWORD_lpdwDisposition);
    [DllImport(lib, EntryPoint = "RegCreateKeyExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegCreateKeyEx(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, int Reserved, char* lpClass, int dwOptions, cpointer unfoundType_REGSAM_samDesired, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer phkResult, cpointer unfoundType_LPDWORD_lpdwDisposition);
    [DllImport(lib, EntryPoint = "RegCreateKeyExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegCreateKeyEx(nint hKey, char* lpSubKey, int Reserved, string lpClass, int dwOptions, cpointer unfoundType_REGSAM_samDesired, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer phkResult, cpointer unfoundType_LPDWORD_lpdwDisposition);
    [DllImport(lib, EntryPoint = "RegCreateKeyExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegCreateKeyEx(nint hKey, char* lpSubKey, int Reserved, char* lpClass, int dwOptions, cpointer unfoundType_REGSAM_samDesired, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer phkResult, cpointer unfoundType_LPDWORD_lpdwDisposition);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegCreateKeyExW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, int Reserved, string lpClass, int dwOptions, cpointer unfoundType_REGSAM_samDesired, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer phkResult, cpointer unfoundType_LPDWORD_lpdwDisposition);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegCreateKeyExW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, int Reserved, char* lpClass, int dwOptions, cpointer unfoundType_REGSAM_samDesired, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer phkResult, cpointer unfoundType_LPDWORD_lpdwDisposition);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegCreateKeyExW(nint hKey, char* lpSubKey, int Reserved, string lpClass, int dwOptions, cpointer unfoundType_REGSAM_samDesired, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer phkResult, cpointer unfoundType_LPDWORD_lpdwDisposition);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegCreateKeyExW(nint hKey, char* lpSubKey, int Reserved, char* lpClass, int dwOptions, cpointer unfoundType_REGSAM_samDesired, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer phkResult, cpointer unfoundType_LPDWORD_lpdwDisposition);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegDeleteKeyExA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string lpSubKey, cpointer unfoundType_REGSAM_samDesired, int Reserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegDeleteKeyExA(nint hKey, byte* lpSubKey, cpointer unfoundType_REGSAM_samDesired, int Reserved);
    [DllImport(lib, EntryPoint = "RegDeleteKeyExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegDeleteKeyEx(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, cpointer unfoundType_REGSAM_samDesired, int Reserved);
    [DllImport(lib, EntryPoint = "RegDeleteKeyExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegDeleteKeyEx(nint hKey, char* lpSubKey, cpointer unfoundType_REGSAM_samDesired, int Reserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegDeleteKeyExW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, cpointer unfoundType_REGSAM_samDesired, int Reserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegDeleteKeyExW(nint hKey, char* lpSubKey, cpointer unfoundType_REGSAM_samDesired, int Reserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegDeleteValueA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string lpValueName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegDeleteValueA(nint hKey, byte* lpValueName);
    [DllImport(lib, EntryPoint = "RegDeleteValueW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegDeleteValue(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpValueName);
    [DllImport(lib, EntryPoint = "RegDeleteValueW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegDeleteValue(nint hKey, char* lpValueName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegDeleteValueW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpValueName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegDeleteValueW(nint hKey, char* lpValueName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegEnumKeyExA(nint hKey, int dwIndex, [MarshalAs(UnmanagedType.LPStr)] string lpName, cpointer unfoundType_LPDWORD_lpcchName, cpointer unfoundType_LPDWORD_lpReserved, [MarshalAs(UnmanagedType.LPStr)] string lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegEnumKeyExA(nint hKey, int dwIndex, [MarshalAs(UnmanagedType.LPStr)] string lpName, cpointer unfoundType_LPDWORD_lpcchName, cpointer unfoundType_LPDWORD_lpReserved, ReadOnlySpan<byte> lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegEnumKeyExA(nint hKey, int dwIndex, [MarshalAs(UnmanagedType.LPStr)] string lpName, cpointer unfoundType_LPDWORD_lpcchName, cpointer unfoundType_LPDWORD_lpReserved, byte* lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegEnumKeyExA(nint hKey, int dwIndex, ReadOnlySpan<byte> lpName, cpointer unfoundType_LPDWORD_lpcchName, cpointer unfoundType_LPDWORD_lpReserved, [MarshalAs(UnmanagedType.LPStr)] string lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegEnumKeyExA(nint hKey, int dwIndex, ReadOnlySpan<byte> lpName, cpointer unfoundType_LPDWORD_lpcchName, cpointer unfoundType_LPDWORD_lpReserved, ReadOnlySpan<byte> lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegEnumKeyExA(nint hKey, int dwIndex, ReadOnlySpan<byte> lpName, cpointer unfoundType_LPDWORD_lpcchName, cpointer unfoundType_LPDWORD_lpReserved, byte* lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegEnumKeyExA(nint hKey, int dwIndex, byte* lpName, cpointer unfoundType_LPDWORD_lpcchName, cpointer unfoundType_LPDWORD_lpReserved, [MarshalAs(UnmanagedType.LPStr)] string lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegEnumKeyExA(nint hKey, int dwIndex, byte* lpName, cpointer unfoundType_LPDWORD_lpcchName, cpointer unfoundType_LPDWORD_lpReserved, ReadOnlySpan<byte> lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegEnumKeyExA(nint hKey, int dwIndex, byte* lpName, cpointer unfoundType_LPDWORD_lpcchName, cpointer unfoundType_LPDWORD_lpReserved, byte* lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, EntryPoint = "RegEnumKeyExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegEnumKeyEx(nint hKey, int dwIndex, string lpName, cpointer unfoundType_LPDWORD_lpcchName, cpointer unfoundType_LPDWORD_lpReserved, string lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, EntryPoint = "RegEnumKeyExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegEnumKeyEx(nint hKey, int dwIndex, string lpName, cpointer unfoundType_LPDWORD_lpcchName, cpointer unfoundType_LPDWORD_lpReserved, char* lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, EntryPoint = "RegEnumKeyExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegEnumKeyEx(nint hKey, int dwIndex, char* lpName, cpointer unfoundType_LPDWORD_lpcchName, cpointer unfoundType_LPDWORD_lpReserved, string lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, EntryPoint = "RegEnumKeyExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegEnumKeyEx(nint hKey, int dwIndex, char* lpName, cpointer unfoundType_LPDWORD_lpcchName, cpointer unfoundType_LPDWORD_lpReserved, char* lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegEnumKeyExW(nint hKey, int dwIndex, string lpName, cpointer unfoundType_LPDWORD_lpcchName, cpointer unfoundType_LPDWORD_lpReserved, string lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegEnumKeyExW(nint hKey, int dwIndex, string lpName, cpointer unfoundType_LPDWORD_lpcchName, cpointer unfoundType_LPDWORD_lpReserved, char* lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegEnumKeyExW(nint hKey, int dwIndex, char* lpName, cpointer unfoundType_LPDWORD_lpcchName, cpointer unfoundType_LPDWORD_lpReserved, string lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegEnumKeyExW(nint hKey, int dwIndex, char* lpName, cpointer unfoundType_LPDWORD_lpcchName, cpointer unfoundType_LPDWORD_lpReserved, char* lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegEnumValueA(nint hKey, int dwIndex, [MarshalAs(UnmanagedType.LPStr)] string lpValueName, cpointer unfoundType_LPDWORD_lpcchValueName, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPDWORD_lpType, cpointer unfoundType_LPBYTE_lpData, cpointer unfoundType_LPDWORD_lpcbData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegEnumValueA(nint hKey, int dwIndex, ReadOnlySpan<byte> lpValueName, cpointer unfoundType_LPDWORD_lpcchValueName, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPDWORD_lpType, cpointer unfoundType_LPBYTE_lpData, cpointer unfoundType_LPDWORD_lpcbData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegEnumValueA(nint hKey, int dwIndex, byte* lpValueName, cpointer unfoundType_LPDWORD_lpcchValueName, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPDWORD_lpType, cpointer unfoundType_LPBYTE_lpData, cpointer unfoundType_LPDWORD_lpcbData);
    [DllImport(lib, EntryPoint = "RegEnumValueW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegEnumValue(nint hKey, int dwIndex, string lpValueName, cpointer unfoundType_LPDWORD_lpcchValueName, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPDWORD_lpType, cpointer unfoundType_LPBYTE_lpData, cpointer unfoundType_LPDWORD_lpcbData);
    [DllImport(lib, EntryPoint = "RegEnumValueW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegEnumValue(nint hKey, int dwIndex, char* lpValueName, cpointer unfoundType_LPDWORD_lpcchValueName, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPDWORD_lpType, cpointer unfoundType_LPBYTE_lpData, cpointer unfoundType_LPDWORD_lpcbData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegEnumValueW(nint hKey, int dwIndex, string lpValueName, cpointer unfoundType_LPDWORD_lpcchValueName, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPDWORD_lpType, cpointer unfoundType_LPBYTE_lpData, cpointer unfoundType_LPDWORD_lpcbData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegEnumValueW(nint hKey, int dwIndex, char* lpValueName, cpointer unfoundType_LPDWORD_lpcchValueName, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPDWORD_lpType, cpointer unfoundType_LPBYTE_lpData, cpointer unfoundType_LPDWORD_lpcbData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegFlushKey(nint hKey);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegGetKeySecurity(nint hKey, cpointer unfoundType_SECURITY_INFORMATION_SecurityInformation, cpointer unfoundType_PSECURITY_DESCRIPTOR_pSecurityDescriptor, cpointer unfoundType_LPDWORD_lpcbSecurityDescriptor);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegLoadKeyA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string lpSubKey, [MarshalAs(UnmanagedType.LPStr)] string lpFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegLoadKeyA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string lpSubKey, byte* lpFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegLoadKeyA(nint hKey, byte* lpSubKey, [MarshalAs(UnmanagedType.LPStr)] string lpFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegLoadKeyA(nint hKey, byte* lpSubKey, byte* lpFile);
    [DllImport(lib, EntryPoint = "RegLoadKeyW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegLoadKey(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, [MarshalAs(UnmanagedType.LPWStr)] string lpFile);
    [DllImport(lib, EntryPoint = "RegLoadKeyW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegLoadKey(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, char* lpFile);
    [DllImport(lib, EntryPoint = "RegLoadKeyW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegLoadKey(nint hKey, char* lpSubKey, [MarshalAs(UnmanagedType.LPWStr)] string lpFile);
    [DllImport(lib, EntryPoint = "RegLoadKeyW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegLoadKey(nint hKey, char* lpSubKey, char* lpFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegLoadKeyW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, [MarshalAs(UnmanagedType.LPWStr)] string lpFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegLoadKeyW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, char* lpFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegLoadKeyW(nint hKey, char* lpSubKey, [MarshalAs(UnmanagedType.LPWStr)] string lpFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegLoadKeyW(nint hKey, char* lpSubKey, char* lpFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegNotifyChangeKeyValue(nint hKey, bool bWatchSubtree, int dwNotifyFilter, cpointer hEvent, bool fAsynchronous);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegOpenKeyExA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string lpSubKey, int ulOptions, cpointer unfoundType_REGSAM_samDesired, cpointer phkResult);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegOpenKeyExA(nint hKey, byte* lpSubKey, int ulOptions, cpointer unfoundType_REGSAM_samDesired, cpointer phkResult);
    [DllImport(lib, EntryPoint = "RegOpenKeyExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegOpenKeyEx(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, int ulOptions, cpointer unfoundType_REGSAM_samDesired, cpointer phkResult);
    [DllImport(lib, EntryPoint = "RegOpenKeyExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegOpenKeyEx(nint hKey, char* lpSubKey, int ulOptions, cpointer unfoundType_REGSAM_samDesired, cpointer phkResult);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegOpenKeyExW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, int ulOptions, cpointer unfoundType_REGSAM_samDesired, cpointer phkResult);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegOpenKeyExW(nint hKey, char* lpSubKey, int ulOptions, cpointer unfoundType_REGSAM_samDesired, cpointer phkResult);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegQueryInfoKeyA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPDWORD_lpcSubKeys, cpointer unfoundType_LPDWORD_lpcbMaxSubKeyLen, cpointer unfoundType_LPDWORD_lpcbMaxClassLen, cpointer unfoundType_LPDWORD_lpcValues, cpointer unfoundType_LPDWORD_lpcbMaxValueNameLen, cpointer unfoundType_LPDWORD_lpcbMaxValueLen, cpointer unfoundType_LPDWORD_lpcbSecurityDescriptor, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegQueryInfoKeyA(nint hKey, ReadOnlySpan<byte> lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPDWORD_lpcSubKeys, cpointer unfoundType_LPDWORD_lpcbMaxSubKeyLen, cpointer unfoundType_LPDWORD_lpcbMaxClassLen, cpointer unfoundType_LPDWORD_lpcValues, cpointer unfoundType_LPDWORD_lpcbMaxValueNameLen, cpointer unfoundType_LPDWORD_lpcbMaxValueLen, cpointer unfoundType_LPDWORD_lpcbSecurityDescriptor, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegQueryInfoKeyA(nint hKey, byte* lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPDWORD_lpcSubKeys, cpointer unfoundType_LPDWORD_lpcbMaxSubKeyLen, cpointer unfoundType_LPDWORD_lpcbMaxClassLen, cpointer unfoundType_LPDWORD_lpcValues, cpointer unfoundType_LPDWORD_lpcbMaxValueNameLen, cpointer unfoundType_LPDWORD_lpcbMaxValueLen, cpointer unfoundType_LPDWORD_lpcbSecurityDescriptor, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, EntryPoint = "RegQueryInfoKeyW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegQueryInfoKey(nint hKey, string lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPDWORD_lpcSubKeys, cpointer unfoundType_LPDWORD_lpcbMaxSubKeyLen, cpointer unfoundType_LPDWORD_lpcbMaxClassLen, cpointer unfoundType_LPDWORD_lpcValues, cpointer unfoundType_LPDWORD_lpcbMaxValueNameLen, cpointer unfoundType_LPDWORD_lpcbMaxValueLen, cpointer unfoundType_LPDWORD_lpcbSecurityDescriptor, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, EntryPoint = "RegQueryInfoKeyW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegQueryInfoKey(nint hKey, char* lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPDWORD_lpcSubKeys, cpointer unfoundType_LPDWORD_lpcbMaxSubKeyLen, cpointer unfoundType_LPDWORD_lpcbMaxClassLen, cpointer unfoundType_LPDWORD_lpcValues, cpointer unfoundType_LPDWORD_lpcbMaxValueNameLen, cpointer unfoundType_LPDWORD_lpcbMaxValueLen, cpointer unfoundType_LPDWORD_lpcbSecurityDescriptor, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegQueryInfoKeyW(nint hKey, string lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPDWORD_lpcSubKeys, cpointer unfoundType_LPDWORD_lpcbMaxSubKeyLen, cpointer unfoundType_LPDWORD_lpcbMaxClassLen, cpointer unfoundType_LPDWORD_lpcValues, cpointer unfoundType_LPDWORD_lpcbMaxValueNameLen, cpointer unfoundType_LPDWORD_lpcbMaxValueLen, cpointer unfoundType_LPDWORD_lpcbSecurityDescriptor, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegQueryInfoKeyW(nint hKey, char* lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPDWORD_lpcSubKeys, cpointer unfoundType_LPDWORD_lpcbMaxSubKeyLen, cpointer unfoundType_LPDWORD_lpcbMaxClassLen, cpointer unfoundType_LPDWORD_lpcValues, cpointer unfoundType_LPDWORD_lpcbMaxValueNameLen, cpointer unfoundType_LPDWORD_lpcbMaxValueLen, cpointer unfoundType_LPDWORD_lpcbSecurityDescriptor, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegQueryValueExA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string lpValueName, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPDWORD_lpType, cpointer unfoundType_LPBYTE_lpData, cpointer unfoundType_LPDWORD_lpcbData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegQueryValueExA(nint hKey, byte* lpValueName, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPDWORD_lpType, cpointer unfoundType_LPBYTE_lpData, cpointer unfoundType_LPDWORD_lpcbData);
    [DllImport(lib, EntryPoint = "RegQueryValueExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegQueryValueEx(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpValueName, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPDWORD_lpType, cpointer unfoundType_LPBYTE_lpData, cpointer unfoundType_LPDWORD_lpcbData);
    [DllImport(lib, EntryPoint = "RegQueryValueExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegQueryValueEx(nint hKey, char* lpValueName, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPDWORD_lpType, cpointer unfoundType_LPBYTE_lpData, cpointer unfoundType_LPDWORD_lpcbData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegQueryValueExW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpValueName, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPDWORD_lpType, cpointer unfoundType_LPBYTE_lpData, cpointer unfoundType_LPDWORD_lpcbData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegQueryValueExW(nint hKey, char* lpValueName, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPDWORD_lpType, cpointer unfoundType_LPBYTE_lpData, cpointer unfoundType_LPDWORD_lpcbData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegRestoreKeyA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string lpFile, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegRestoreKeyA(nint hKey, byte* lpFile, int dwFlags);
    [DllImport(lib, EntryPoint = "RegRestoreKeyW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegRestoreKey(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpFile, int dwFlags);
    [DllImport(lib, EntryPoint = "RegRestoreKeyW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegRestoreKey(nint hKey, char* lpFile, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegRestoreKeyW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpFile, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegRestoreKeyW(nint hKey, char* lpFile, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegSetKeySecurity(nint hKey, cpointer unfoundType_SECURITY_INFORMATION_SecurityInformation, cpointer unfoundType_PSECURITY_DESCRIPTOR_pSecurityDescriptor);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegSetValueExA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string lpValueName, int Reserved, int dwType, cpointer lpData, int cbData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegSetValueExA(nint hKey, byte* lpValueName, int Reserved, int dwType, cpointer lpData, int cbData);
    [DllImport(lib, EntryPoint = "RegSetValueExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegSetValueEx(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpValueName, int Reserved, int dwType, cpointer lpData, int cbData);
    [DllImport(lib, EntryPoint = "RegSetValueExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegSetValueEx(nint hKey, char* lpValueName, int Reserved, int dwType, cpointer lpData, int cbData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegSetValueExW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpValueName, int Reserved, int dwType, cpointer lpData, int cbData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegSetValueExW(nint hKey, char* lpValueName, int Reserved, int dwType, cpointer lpData, int cbData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegUnLoadKeyA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string lpSubKey);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegUnLoadKeyA(nint hKey, byte* lpSubKey);
    [DllImport(lib, EntryPoint = "RegUnLoadKeyW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegUnLoadKey(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey);
    [DllImport(lib, EntryPoint = "RegUnLoadKeyW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegUnLoadKey(nint hKey, char* lpSubKey);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegUnLoadKeyW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegUnLoadKeyW(nint hKey, char* lpSubKey);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegDeleteTreeA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string lpSubKey);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegDeleteTreeA(nint hKey, byte* lpSubKey);
    [DllImport(lib, EntryPoint = "RegDeleteTreeW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegDeleteTree(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey);
    [DllImport(lib, EntryPoint = "RegDeleteTreeW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegDeleteTree(nint hKey, char* lpSubKey);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegDeleteTreeW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegDeleteTreeW(nint hKey, char* lpSubKey);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegGetValueA(nint hkey, [MarshalAs(UnmanagedType.LPStr)] string lpSubKey, [MarshalAs(UnmanagedType.LPStr)] string lpValue, int dwFlags, cpointer unfoundType_LPDWORD_pdwType, cpointer pvData, cpointer unfoundType_LPDWORD_pcbData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegGetValueA(nint hkey, [MarshalAs(UnmanagedType.LPStr)] string lpSubKey, byte* lpValue, int dwFlags, cpointer unfoundType_LPDWORD_pdwType, cpointer pvData, cpointer unfoundType_LPDWORD_pcbData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegGetValueA(nint hkey, byte* lpSubKey, [MarshalAs(UnmanagedType.LPStr)] string lpValue, int dwFlags, cpointer unfoundType_LPDWORD_pdwType, cpointer pvData, cpointer unfoundType_LPDWORD_pcbData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegGetValueA(nint hkey, byte* lpSubKey, byte* lpValue, int dwFlags, cpointer unfoundType_LPDWORD_pdwType, cpointer pvData, cpointer unfoundType_LPDWORD_pcbData);
    [DllImport(lib, EntryPoint = "RegGetValueW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegGetValue(nint hkey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, int dwFlags, cpointer unfoundType_LPDWORD_pdwType, cpointer pvData, cpointer unfoundType_LPDWORD_pcbData);
    [DllImport(lib, EntryPoint = "RegGetValueW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegGetValue(nint hkey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, char* lpValue, int dwFlags, cpointer unfoundType_LPDWORD_pdwType, cpointer pvData, cpointer unfoundType_LPDWORD_pcbData);
    [DllImport(lib, EntryPoint = "RegGetValueW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegGetValue(nint hkey, char* lpSubKey, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, int dwFlags, cpointer unfoundType_LPDWORD_pdwType, cpointer pvData, cpointer unfoundType_LPDWORD_pcbData);
    [DllImport(lib, EntryPoint = "RegGetValueW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegGetValue(nint hkey, char* lpSubKey, char* lpValue, int dwFlags, cpointer unfoundType_LPDWORD_pdwType, cpointer pvData, cpointer unfoundType_LPDWORD_pcbData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegGetValueW(nint hkey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, int dwFlags, cpointer unfoundType_LPDWORD_pdwType, cpointer pvData, cpointer unfoundType_LPDWORD_pcbData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegGetValueW(nint hkey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, char* lpValue, int dwFlags, cpointer unfoundType_LPDWORD_pdwType, cpointer pvData, cpointer unfoundType_LPDWORD_pcbData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegGetValueW(nint hkey, char* lpSubKey, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, int dwFlags, cpointer unfoundType_LPDWORD_pdwType, cpointer pvData, cpointer unfoundType_LPDWORD_pcbData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegGetValueW(nint hkey, char* lpSubKey, char* lpValue, int dwFlags, cpointer unfoundType_LPDWORD_pdwType, cpointer pvData, cpointer unfoundType_LPDWORD_pcbData);
    [DllImport(lib, EntryPoint = "RegCopyTreeW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegCopyTree(nint hKeySrc, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, nint hKeyDest);
    [DllImport(lib, EntryPoint = "RegCopyTreeW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegCopyTree(nint hKeySrc, char* lpSubKey, nint hKeyDest);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegCopyTreeW(nint hKeySrc, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, nint hKeyDest);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegCopyTreeW(nint hKeySrc, char* lpSubKey, nint hKeyDest);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegLoadMUIStringA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string pszValue, [MarshalAs(UnmanagedType.LPStr)] string pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, [MarshalAs(UnmanagedType.LPStr)] string pszDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegLoadMUIStringA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string pszValue, [MarshalAs(UnmanagedType.LPStr)] string pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, byte* pszDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegLoadMUIStringA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string pszValue, ReadOnlySpan<byte> pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, [MarshalAs(UnmanagedType.LPStr)] string pszDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegLoadMUIStringA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string pszValue, ReadOnlySpan<byte> pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, byte* pszDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegLoadMUIStringA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string pszValue, byte* pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, [MarshalAs(UnmanagedType.LPStr)] string pszDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegLoadMUIStringA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string pszValue, byte* pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, byte* pszDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegLoadMUIStringA(nint hKey, byte* pszValue, [MarshalAs(UnmanagedType.LPStr)] string pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, [MarshalAs(UnmanagedType.LPStr)] string pszDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegLoadMUIStringA(nint hKey, byte* pszValue, [MarshalAs(UnmanagedType.LPStr)] string pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, byte* pszDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegLoadMUIStringA(nint hKey, byte* pszValue, ReadOnlySpan<byte> pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, [MarshalAs(UnmanagedType.LPStr)] string pszDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegLoadMUIStringA(nint hKey, byte* pszValue, ReadOnlySpan<byte> pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, byte* pszDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegLoadMUIStringA(nint hKey, byte* pszValue, byte* pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, [MarshalAs(UnmanagedType.LPStr)] string pszDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegLoadMUIStringA(nint hKey, byte* pszValue, byte* pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, byte* pszDirectory);
    [DllImport(lib, EntryPoint = "RegLoadMUIStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegLoadMUIString(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string pszValue, string pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, [MarshalAs(UnmanagedType.LPWStr)] string pszDirectory);
    [DllImport(lib, EntryPoint = "RegLoadMUIStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegLoadMUIString(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string pszValue, string pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, char* pszDirectory);
    [DllImport(lib, EntryPoint = "RegLoadMUIStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegLoadMUIString(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string pszValue, char* pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, [MarshalAs(UnmanagedType.LPWStr)] string pszDirectory);
    [DllImport(lib, EntryPoint = "RegLoadMUIStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegLoadMUIString(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string pszValue, char* pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, char* pszDirectory);
    [DllImport(lib, EntryPoint = "RegLoadMUIStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegLoadMUIString(nint hKey, char* pszValue, string pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, [MarshalAs(UnmanagedType.LPWStr)] string pszDirectory);
    [DllImport(lib, EntryPoint = "RegLoadMUIStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegLoadMUIString(nint hKey, char* pszValue, string pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, char* pszDirectory);
    [DllImport(lib, EntryPoint = "RegLoadMUIStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegLoadMUIString(nint hKey, char* pszValue, char* pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, [MarshalAs(UnmanagedType.LPWStr)] string pszDirectory);
    [DllImport(lib, EntryPoint = "RegLoadMUIStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegLoadMUIString(nint hKey, char* pszValue, char* pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, char* pszDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegLoadMUIStringW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string pszValue, string pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, [MarshalAs(UnmanagedType.LPWStr)] string pszDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegLoadMUIStringW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string pszValue, string pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, char* pszDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegLoadMUIStringW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string pszValue, char* pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, [MarshalAs(UnmanagedType.LPWStr)] string pszDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegLoadMUIStringW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string pszValue, char* pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, char* pszDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegLoadMUIStringW(nint hKey, char* pszValue, string pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, [MarshalAs(UnmanagedType.LPWStr)] string pszDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegLoadMUIStringW(nint hKey, char* pszValue, string pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, char* pszDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegLoadMUIStringW(nint hKey, char* pszValue, char* pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, [MarshalAs(UnmanagedType.LPWStr)] string pszDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegLoadMUIStringW(nint hKey, char* pszValue, char* pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, char* pszDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegSaveKeyExA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string lpFile, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegSaveKeyExA(nint hKey, byte* lpFile, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int Flags);
    [DllImport(lib, EntryPoint = "RegSaveKeyExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegSaveKeyEx(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpFile, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int Flags);
    [DllImport(lib, EntryPoint = "RegSaveKeyExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegSaveKeyEx(nint hKey, char* lpFile, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegSaveKeyExW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpFile, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer RegSaveKeyExW(nint hKey, char* lpFile, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer Wow64EnableWow64FsRedirection(cpointer unfoundType_BOOLEAN_Wow64FsEnableRedirection);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool Wow64DisableWow64FsRedirection(cpointer OldValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool Wow64RevertWow64FsRedirection(cpointer OlValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsWow64Process(cpointer hProcess, cpointer Wow64Process);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetSystemWow64DirectoryA([MarshalAs(UnmanagedType.LPStr)] string lpBuffer, uint uSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetSystemWow64DirectoryA(ReadOnlySpan<byte> lpBuffer, uint uSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetSystemWow64DirectoryA(byte* lpBuffer, uint uSize);
    [DllImport(lib, EntryPoint = "GetSystemWow64DirectoryW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetSystemWow64Directory(string lpBuffer, uint uSize);
    [DllImport(lib, EntryPoint = "GetSystemWow64DirectoryW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetSystemWow64Directory(char* lpBuffer, uint uSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetSystemWow64DirectoryW(string lpBuffer, uint uSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetSystemWow64DirectoryW(char* lpBuffer, uint uSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsWow64Process2(cpointer hProcess, cpointer pProcessMachine, cpointer pNativeMachine);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer IsWow64GuestMachineSupported(ushort WowGuestMachine, cpointer MachineIsSupported);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool Wow64GetThreadContext(cpointer hThread, cpointer unfoundType_PWOW64_CONTEXT_lpContext);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool Wow64SetThreadContext(cpointer hThread, cpointer unfoundType_WOW64_CONTEXT_lpContext);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int Wow64SuspendThread(cpointer hThread);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int VerLanguageNameA(int wLang, [MarshalAs(UnmanagedType.LPStr)] string szLang, int cchLang);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int VerLanguageNameA(int wLang, ReadOnlySpan<byte> szLang, int cchLang);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int VerLanguageNameA(int wLang, byte* szLang, int cchLang);
    [DllImport(lib, EntryPoint = "VerLanguageNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int VerLanguageName(int wLang, string szLang, int cchLang);
    [DllImport(lib, EntryPoint = "VerLanguageNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int VerLanguageName(int wLang, char* szLang, int cchLang);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int VerLanguageNameW(int wLang, string szLang, int cchLang);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int VerLanguageNameW(int wLang, char* szLang, int cchLang);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsValidCodePage(uint CodePage);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetACP();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetOEMCP();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetCPInfo(uint CodePage, cpointer unfoundType_LPCPINFO_lpCPInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetCPInfoExA(uint CodePage, int dwFlags, cpointer unfoundType_LPCPINFOEXA_lpCPInfoEx);
    [DllImport(lib, EntryPoint = "GetCPInfoExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetCPInfoEx(uint CodePage, int dwFlags, cpointer unfoundType_LPCPINFOEXW_lpCPInfoEx);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetCPInfoExW(uint CodePage, int dwFlags, cpointer unfoundType_LPCPINFOEXW_lpCPInfoEx);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CompareStringA(cpointer unfoundType_LCID_Locale, int dwCmpFlags, cpointer unfoundType_PCNZCH_lpString1, int cchCount1, cpointer unfoundType_PCNZCH_lpString2, int cchCount2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FindNLSString(cpointer unfoundType_LCID_Locale, int dwFindNLSStringFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpStringSource, int cchSource, [MarshalAs(UnmanagedType.LPWStr)] string lpStringValue, int cchValue, cpointer unfoundType_LPINT_pcchFound);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FindNLSString(cpointer unfoundType_LCID_Locale, int dwFindNLSStringFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpStringSource, int cchSource, char* lpStringValue, int cchValue, cpointer unfoundType_LPINT_pcchFound);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FindNLSString(cpointer unfoundType_LCID_Locale, int dwFindNLSStringFlags, char* lpStringSource, int cchSource, [MarshalAs(UnmanagedType.LPWStr)] string lpStringValue, int cchValue, cpointer unfoundType_LPINT_pcchFound);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FindNLSString(cpointer unfoundType_LCID_Locale, int dwFindNLSStringFlags, char* lpStringSource, int cchSource, char* lpStringValue, int cchValue, cpointer unfoundType_LPINT_pcchFound);
    [DllImport(lib, EntryPoint = "LCMapStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapString(cpointer unfoundType_LCID_Locale, int dwMapFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, string lpDestStr, int cchDest);
    [DllImport(lib, EntryPoint = "LCMapStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapString(cpointer unfoundType_LCID_Locale, int dwMapFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, char* lpDestStr, int cchDest);
    [DllImport(lib, EntryPoint = "LCMapStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapString(cpointer unfoundType_LCID_Locale, int dwMapFlags, char* lpSrcStr, int cchSrc, string lpDestStr, int cchDest);
    [DllImport(lib, EntryPoint = "LCMapStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapString(cpointer unfoundType_LCID_Locale, int dwMapFlags, char* lpSrcStr, int cchSrc, char* lpDestStr, int cchDest);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapStringW(cpointer unfoundType_LCID_Locale, int dwMapFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, string lpDestStr, int cchDest);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapStringW(cpointer unfoundType_LCID_Locale, int dwMapFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, char* lpDestStr, int cchDest);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapStringW(cpointer unfoundType_LCID_Locale, int dwMapFlags, char* lpSrcStr, int cchSrc, string lpDestStr, int cchDest);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapStringW(cpointer unfoundType_LCID_Locale, int dwMapFlags, char* lpSrcStr, int cchSrc, char* lpDestStr, int cchDest);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapStringA(cpointer unfoundType_LCID_Locale, int dwMapFlags, [MarshalAs(UnmanagedType.LPStr)] string lpSrcStr, int cchSrc, [MarshalAs(UnmanagedType.LPStr)] string lpDestStr, int cchDest);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapStringA(cpointer unfoundType_LCID_Locale, int dwMapFlags, [MarshalAs(UnmanagedType.LPStr)] string lpSrcStr, int cchSrc, ReadOnlySpan<byte> lpDestStr, int cchDest);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapStringA(cpointer unfoundType_LCID_Locale, int dwMapFlags, [MarshalAs(UnmanagedType.LPStr)] string lpSrcStr, int cchSrc, byte* lpDestStr, int cchDest);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapStringA(cpointer unfoundType_LCID_Locale, int dwMapFlags, byte* lpSrcStr, int cchSrc, [MarshalAs(UnmanagedType.LPStr)] string lpDestStr, int cchDest);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapStringA(cpointer unfoundType_LCID_Locale, int dwMapFlags, byte* lpSrcStr, int cchSrc, ReadOnlySpan<byte> lpDestStr, int cchDest);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapStringA(cpointer unfoundType_LCID_Locale, int dwMapFlags, byte* lpSrcStr, int cchSrc, byte* lpDestStr, int cchDest);
    [DllImport(lib, EntryPoint = "GetLocaleInfoW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLocaleInfo(cpointer unfoundType_LCID_Locale, cpointer unfoundType_LCTYPE_LCType, string lpLCData, int cchData);
    [DllImport(lib, EntryPoint = "GetLocaleInfoW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLocaleInfo(cpointer unfoundType_LCID_Locale, cpointer unfoundType_LCTYPE_LCType, char* lpLCData, int cchData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLocaleInfoW(cpointer unfoundType_LCID_Locale, cpointer unfoundType_LCTYPE_LCType, string lpLCData, int cchData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLocaleInfoW(cpointer unfoundType_LCID_Locale, cpointer unfoundType_LCTYPE_LCType, char* lpLCData, int cchData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLocaleInfoA(cpointer unfoundType_LCID_Locale, cpointer unfoundType_LCTYPE_LCType, [MarshalAs(UnmanagedType.LPStr)] string lpLCData, int cchData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLocaleInfoA(cpointer unfoundType_LCID_Locale, cpointer unfoundType_LCTYPE_LCType, ReadOnlySpan<byte> lpLCData, int cchData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLocaleInfoA(cpointer unfoundType_LCID_Locale, cpointer unfoundType_LCTYPE_LCType, byte* lpLCData, int cchData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetLocaleInfoA(cpointer unfoundType_LCID_Locale, cpointer unfoundType_LCTYPE_LCType, [MarshalAs(UnmanagedType.LPStr)] string lpLCData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetLocaleInfoA(cpointer unfoundType_LCID_Locale, cpointer unfoundType_LCTYPE_LCType, byte* lpLCData);
    [DllImport(lib, EntryPoint = "SetLocaleInfoW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetLocaleInfo(cpointer unfoundType_LCID_Locale, cpointer unfoundType_LCTYPE_LCType, [MarshalAs(UnmanagedType.LPWStr)] string lpLCData);
    [DllImport(lib, EntryPoint = "SetLocaleInfoW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetLocaleInfo(cpointer unfoundType_LCID_Locale, cpointer unfoundType_LCTYPE_LCType, char* lpLCData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetLocaleInfoW(cpointer unfoundType_LCID_Locale, cpointer unfoundType_LCTYPE_LCType, [MarshalAs(UnmanagedType.LPWStr)] string lpLCData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetLocaleInfoW(cpointer unfoundType_LCID_Locale, cpointer unfoundType_LCTYPE_LCType, char* lpLCData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCalendarInfoA(cpointer unfoundType_LCID_Locale, cpointer unfoundType_CALID_Calendar, cpointer unfoundType_CALTYPE_CalType, [MarshalAs(UnmanagedType.LPStr)] string lpCalData, int cchData, cpointer unfoundType_LPDWORD_lpValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCalendarInfoA(cpointer unfoundType_LCID_Locale, cpointer unfoundType_CALID_Calendar, cpointer unfoundType_CALTYPE_CalType, ReadOnlySpan<byte> lpCalData, int cchData, cpointer unfoundType_LPDWORD_lpValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCalendarInfoA(cpointer unfoundType_LCID_Locale, cpointer unfoundType_CALID_Calendar, cpointer unfoundType_CALTYPE_CalType, byte* lpCalData, int cchData, cpointer unfoundType_LPDWORD_lpValue);
    [DllImport(lib, EntryPoint = "GetCalendarInfoW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCalendarInfo(cpointer unfoundType_LCID_Locale, cpointer unfoundType_CALID_Calendar, cpointer unfoundType_CALTYPE_CalType, string lpCalData, int cchData, cpointer unfoundType_LPDWORD_lpValue);
    [DllImport(lib, EntryPoint = "GetCalendarInfoW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCalendarInfo(cpointer unfoundType_LCID_Locale, cpointer unfoundType_CALID_Calendar, cpointer unfoundType_CALTYPE_CalType, char* lpCalData, int cchData, cpointer unfoundType_LPDWORD_lpValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCalendarInfoW(cpointer unfoundType_LCID_Locale, cpointer unfoundType_CALID_Calendar, cpointer unfoundType_CALTYPE_CalType, string lpCalData, int cchData, cpointer unfoundType_LPDWORD_lpValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCalendarInfoW(cpointer unfoundType_LCID_Locale, cpointer unfoundType_CALID_Calendar, cpointer unfoundType_CALTYPE_CalType, char* lpCalData, int cchData, cpointer unfoundType_LPDWORD_lpValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetCalendarInfoA(cpointer unfoundType_LCID_Locale, cpointer unfoundType_CALID_Calendar, cpointer unfoundType_CALTYPE_CalType, [MarshalAs(UnmanagedType.LPStr)] string lpCalData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetCalendarInfoA(cpointer unfoundType_LCID_Locale, cpointer unfoundType_CALID_Calendar, cpointer unfoundType_CALTYPE_CalType, byte* lpCalData);
    [DllImport(lib, EntryPoint = "SetCalendarInfoW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetCalendarInfo(cpointer unfoundType_LCID_Locale, cpointer unfoundType_CALID_Calendar, cpointer unfoundType_CALTYPE_CalType, [MarshalAs(UnmanagedType.LPWStr)] string lpCalData);
    [DllImport(lib, EntryPoint = "SetCalendarInfoW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetCalendarInfo(cpointer unfoundType_LCID_Locale, cpointer unfoundType_CALID_Calendar, cpointer unfoundType_CALTYPE_CalType, char* lpCalData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetCalendarInfoW(cpointer unfoundType_LCID_Locale, cpointer unfoundType_CALID_Calendar, cpointer unfoundType_CALTYPE_CalType, [MarshalAs(UnmanagedType.LPWStr)] string lpCalData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetCalendarInfoW(cpointer unfoundType_LCID_Locale, cpointer unfoundType_CALID_Calendar, cpointer unfoundType_CALTYPE_CalType, char* lpCalData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsDBCSLeadByte(byte TestChar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsDBCSLeadByteEx(uint CodePage, byte TestChar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer LocaleNameToLCID([MarshalAs(UnmanagedType.LPWStr)] string lpName, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer LocaleNameToLCID(char* lpName, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCIDToLocaleName(cpointer unfoundType_LCID_Locale, string lpName, int cchName, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCIDToLocaleName(cpointer unfoundType_LCID_Locale, char* lpName, int cchName, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDurationFormat(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIMElpDurationlpDuration_unnamed_2, cpointer unfoundType_ULONGLONG_ullDuration, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, string lpDurationStr, int cchDuration);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDurationFormat(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIMElpDurationlpDuration_unnamed_2, cpointer unfoundType_ULONGLONG_ullDuration, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, char* lpDurationStr, int cchDuration);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDurationFormat(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIMElpDurationlpDuration_unnamed_2, cpointer unfoundType_ULONGLONG_ullDuration, char* lpFormat, string lpDurationStr, int cchDuration);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDurationFormat(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIMElpDurationlpDuration_unnamed_2, cpointer unfoundType_ULONGLONG_ullDuration, char* lpFormat, char* lpDurationStr, int cchDuration);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormatA(cpointer unfoundType_LCID_Locale, int dwFlags, [MarshalAs(UnmanagedType.LPStr)] string lpValue, cpointer unfoundType_NUMBERFMTAlpFormatlpFormat_unnamed_3, [MarshalAs(UnmanagedType.LPStr)] string lpNumberStr, int cchNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormatA(cpointer unfoundType_LCID_Locale, int dwFlags, [MarshalAs(UnmanagedType.LPStr)] string lpValue, cpointer unfoundType_NUMBERFMTAlpFormatlpFormat_unnamed_3, ReadOnlySpan<byte> lpNumberStr, int cchNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormatA(cpointer unfoundType_LCID_Locale, int dwFlags, [MarshalAs(UnmanagedType.LPStr)] string lpValue, cpointer unfoundType_NUMBERFMTAlpFormatlpFormat_unnamed_3, byte* lpNumberStr, int cchNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormatA(cpointer unfoundType_LCID_Locale, int dwFlags, byte* lpValue, cpointer unfoundType_NUMBERFMTAlpFormatlpFormat_unnamed_3, [MarshalAs(UnmanagedType.LPStr)] string lpNumberStr, int cchNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormatA(cpointer unfoundType_LCID_Locale, int dwFlags, byte* lpValue, cpointer unfoundType_NUMBERFMTAlpFormatlpFormat_unnamed_3, ReadOnlySpan<byte> lpNumberStr, int cchNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormatA(cpointer unfoundType_LCID_Locale, int dwFlags, byte* lpValue, cpointer unfoundType_NUMBERFMTAlpFormatlpFormat_unnamed_3, byte* lpNumberStr, int cchNumber);
    [DllImport(lib, EntryPoint = "GetNumberFormatW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormat(cpointer unfoundType_LCID_Locale, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, cpointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, string lpNumberStr, int cchNumber);
    [DllImport(lib, EntryPoint = "GetNumberFormatW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormat(cpointer unfoundType_LCID_Locale, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, cpointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, char* lpNumberStr, int cchNumber);
    [DllImport(lib, EntryPoint = "GetNumberFormatW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormat(cpointer unfoundType_LCID_Locale, int dwFlags, char* lpValue, cpointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, string lpNumberStr, int cchNumber);
    [DllImport(lib, EntryPoint = "GetNumberFormatW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormat(cpointer unfoundType_LCID_Locale, int dwFlags, char* lpValue, cpointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, char* lpNumberStr, int cchNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormatW(cpointer unfoundType_LCID_Locale, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, cpointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, string lpNumberStr, int cchNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormatW(cpointer unfoundType_LCID_Locale, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, cpointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, char* lpNumberStr, int cchNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormatW(cpointer unfoundType_LCID_Locale, int dwFlags, char* lpValue, cpointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, string lpNumberStr, int cchNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormatW(cpointer unfoundType_LCID_Locale, int dwFlags, char* lpValue, cpointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, char* lpNumberStr, int cchNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormatA(cpointer unfoundType_LCID_Locale, int dwFlags, [MarshalAs(UnmanagedType.LPStr)] string lpValue, cpointer unfoundType_CURRENCYFMTAlpFormatlpFormat_unnamed_3, [MarshalAs(UnmanagedType.LPStr)] string lpCurrencyStr, int cchCurrency);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormatA(cpointer unfoundType_LCID_Locale, int dwFlags, [MarshalAs(UnmanagedType.LPStr)] string lpValue, cpointer unfoundType_CURRENCYFMTAlpFormatlpFormat_unnamed_3, ReadOnlySpan<byte> lpCurrencyStr, int cchCurrency);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormatA(cpointer unfoundType_LCID_Locale, int dwFlags, [MarshalAs(UnmanagedType.LPStr)] string lpValue, cpointer unfoundType_CURRENCYFMTAlpFormatlpFormat_unnamed_3, byte* lpCurrencyStr, int cchCurrency);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormatA(cpointer unfoundType_LCID_Locale, int dwFlags, byte* lpValue, cpointer unfoundType_CURRENCYFMTAlpFormatlpFormat_unnamed_3, [MarshalAs(UnmanagedType.LPStr)] string lpCurrencyStr, int cchCurrency);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormatA(cpointer unfoundType_LCID_Locale, int dwFlags, byte* lpValue, cpointer unfoundType_CURRENCYFMTAlpFormatlpFormat_unnamed_3, ReadOnlySpan<byte> lpCurrencyStr, int cchCurrency);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormatA(cpointer unfoundType_LCID_Locale, int dwFlags, byte* lpValue, cpointer unfoundType_CURRENCYFMTAlpFormatlpFormat_unnamed_3, byte* lpCurrencyStr, int cchCurrency);
    [DllImport(lib, EntryPoint = "GetCurrencyFormatW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormat(cpointer unfoundType_LCID_Locale, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, cpointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, string lpCurrencyStr, int cchCurrency);
    [DllImport(lib, EntryPoint = "GetCurrencyFormatW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormat(cpointer unfoundType_LCID_Locale, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, cpointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, char* lpCurrencyStr, int cchCurrency);
    [DllImport(lib, EntryPoint = "GetCurrencyFormatW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormat(cpointer unfoundType_LCID_Locale, int dwFlags, char* lpValue, cpointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, string lpCurrencyStr, int cchCurrency);
    [DllImport(lib, EntryPoint = "GetCurrencyFormatW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormat(cpointer unfoundType_LCID_Locale, int dwFlags, char* lpValue, cpointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, char* lpCurrencyStr, int cchCurrency);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormatW(cpointer unfoundType_LCID_Locale, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, cpointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, string lpCurrencyStr, int cchCurrency);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormatW(cpointer unfoundType_LCID_Locale, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, cpointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, char* lpCurrencyStr, int cchCurrency);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormatW(cpointer unfoundType_LCID_Locale, int dwFlags, char* lpValue, cpointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, string lpCurrencyStr, int cchCurrency);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormatW(cpointer unfoundType_LCID_Locale, int dwFlags, char* lpValue, cpointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, char* lpCurrencyStr, int cchCurrency);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumCalendarInfoA(cpointer unfoundType_CALINFO_ENUMPROCA_lpCalInfoEnumProc, cpointer unfoundType_LCID_Locale, cpointer unfoundType_CALID_Calendar, cpointer unfoundType_CALTYPE_CalType);
    [DllImport(lib, EntryPoint = "EnumCalendarInfoW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumCalendarInfo(cpointer unfoundType_CALINFO_ENUMPROCW_lpCalInfoEnumProc, cpointer unfoundType_LCID_Locale, cpointer unfoundType_CALID_Calendar, cpointer unfoundType_CALTYPE_CalType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumCalendarInfoW(cpointer unfoundType_CALINFO_ENUMPROCW_lpCalInfoEnumProc, cpointer unfoundType_LCID_Locale, cpointer unfoundType_CALID_Calendar, cpointer unfoundType_CALTYPE_CalType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumCalendarInfoExA(cpointer unfoundType_CALINFO_ENUMPROCEXA_lpCalInfoEnumProcEx, cpointer unfoundType_LCID_Locale, cpointer unfoundType_CALID_Calendar, cpointer unfoundType_CALTYPE_CalType);
    [DllImport(lib, EntryPoint = "EnumCalendarInfoExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumCalendarInfoEx(cpointer unfoundType_CALINFO_ENUMPROCEXW_lpCalInfoEnumProcEx, cpointer unfoundType_LCID_Locale, cpointer unfoundType_CALID_Calendar, cpointer unfoundType_CALTYPE_CalType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumCalendarInfoExW(cpointer unfoundType_CALINFO_ENUMPROCEXW_lpCalInfoEnumProcEx, cpointer unfoundType_LCID_Locale, cpointer unfoundType_CALID_Calendar, cpointer unfoundType_CALTYPE_CalType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumTimeFormatsA(cpointer unfoundType_TIMEFMT_ENUMPROCA_lpTimeFmtEnumProc, cpointer unfoundType_LCID_Locale, int dwFlags);
    [DllImport(lib, EntryPoint = "EnumTimeFormatsW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumTimeFormats(cpointer unfoundType_TIMEFMT_ENUMPROCW_lpTimeFmtEnumProc, cpointer unfoundType_LCID_Locale, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumTimeFormatsW(cpointer unfoundType_TIMEFMT_ENUMPROCW_lpTimeFmtEnumProc, cpointer unfoundType_LCID_Locale, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumDateFormatsA(cpointer unfoundType_DATEFMT_ENUMPROCA_lpDateFmtEnumProc, cpointer unfoundType_LCID_Locale, int dwFlags);
    [DllImport(lib, EntryPoint = "EnumDateFormatsW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumDateFormats(cpointer unfoundType_DATEFMT_ENUMPROCW_lpDateFmtEnumProc, cpointer unfoundType_LCID_Locale, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumDateFormatsW(cpointer unfoundType_DATEFMT_ENUMPROCW_lpDateFmtEnumProc, cpointer unfoundType_LCID_Locale, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumDateFormatsExA(cpointer unfoundType_DATEFMT_ENUMPROCEXA_lpDateFmtEnumProcEx, cpointer unfoundType_LCID_Locale, int dwFlags);
    [DllImport(lib, EntryPoint = "EnumDateFormatsExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumDateFormatsEx(cpointer unfoundType_DATEFMT_ENUMPROCEXW_lpDateFmtEnumProcEx, cpointer unfoundType_LCID_Locale, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumDateFormatsExW(cpointer unfoundType_DATEFMT_ENUMPROCEXW_lpDateFmtEnumProcEx, cpointer unfoundType_LCID_Locale, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsValidLanguageGroup(cpointer unfoundType_LGRPID_LanguageGroup, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNLSVersion(cpointer unfoundType_NLS_FUNCTION_Function, cpointer unfoundType_LCID_Locale, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsValidLocale(cpointer unfoundType_LCID_Locale, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetGeoInfoA(cpointer unfoundType_GEOID_Location, cpointer unfoundType_GEOTYPE_GeoType, [MarshalAs(UnmanagedType.LPStr)] string lpGeoData, int cchData, cpointer unfoundType_LANGID_LangId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetGeoInfoA(cpointer unfoundType_GEOID_Location, cpointer unfoundType_GEOTYPE_GeoType, ReadOnlySpan<byte> lpGeoData, int cchData, cpointer unfoundType_LANGID_LangId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetGeoInfoA(cpointer unfoundType_GEOID_Location, cpointer unfoundType_GEOTYPE_GeoType, byte* lpGeoData, int cchData, cpointer unfoundType_LANGID_LangId);
    [DllImport(lib, EntryPoint = "GetGeoInfoW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetGeoInfo(cpointer unfoundType_GEOID_Location, cpointer unfoundType_GEOTYPE_GeoType, string lpGeoData, int cchData, cpointer unfoundType_LANGID_LangId);
    [DllImport(lib, EntryPoint = "GetGeoInfoW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetGeoInfo(cpointer unfoundType_GEOID_Location, cpointer unfoundType_GEOTYPE_GeoType, char* lpGeoData, int cchData, cpointer unfoundType_LANGID_LangId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetGeoInfoW(cpointer unfoundType_GEOID_Location, cpointer unfoundType_GEOTYPE_GeoType, string lpGeoData, int cchData, cpointer unfoundType_LANGID_LangId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetGeoInfoW(cpointer unfoundType_GEOID_Location, cpointer unfoundType_GEOTYPE_GeoType, char* lpGeoData, int cchData, cpointer unfoundType_LANGID_LangId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetGeoInfoEx([MarshalAs(UnmanagedType.LPWStr)] string location, cpointer unfoundType_GEOTYPE_geoType, [MarshalAs(UnmanagedType.LPWStr)] string geoData, int geoDataCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetGeoInfoEx([MarshalAs(UnmanagedType.LPWStr)] string location, cpointer unfoundType_GEOTYPE_geoType, char* geoData, int geoDataCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetGeoInfoEx(char* location, cpointer unfoundType_GEOTYPE_geoType, [MarshalAs(UnmanagedType.LPWStr)] string geoData, int geoDataCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetGeoInfoEx(char* location, cpointer unfoundType_GEOTYPE_geoType, char* geoData, int geoDataCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumSystemGeoID(cpointer unfoundType_GEOCLASS_GeoClass, cpointer unfoundType_GEOID_ParentGeoId, cpointer unfoundType_GEO_ENUMPROC_lpGeoEnumProc);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumSystemGeoNames(cpointer unfoundType_GEOCLASS_geoClass, cpointer unfoundType_GEO_ENUMNAMEPROC_geoEnumProc, long data);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetUserGeoID(cpointer unfoundType_GEOCLASS_GeoClass);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetUserDefaultGeoName(string geoName, int geoNameCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetUserDefaultGeoName(char* geoName, int geoNameCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetUserGeoID(cpointer unfoundType_GEOID_GeoId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetUserGeoName([MarshalAs(UnmanagedType.LPWStr)] string geoName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetUserGeoName(char* geoName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer ConvertDefaultLocale(cpointer unfoundType_LCID_Locale);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetSystemDefaultUILanguage();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetThreadLocale();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetThreadLocale(cpointer unfoundType_LCID_Locale);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetUserDefaultUILanguage();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetUserDefaultLangID();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetSystemDefaultLangID();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetSystemDefaultLCID();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetUserDefaultLCID();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer SetThreadUILanguage(cpointer unfoundType_LANGID_LangId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        cpointer GetThreadUILanguage();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetProcessPreferredUILanguages(int dwFlags, cpointer unfoundType_PULONG_pulNumLanguages, cpointer unfoundType_PZZWSTR_pwszLanguagesBuffer, cpointer unfoundType_PULONG_pcchLanguagesBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetProcessPreferredUILanguages(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pwszLanguagesBuffer, cpointer unfoundType_PULONG_pulNumLanguages);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetProcessPreferredUILanguages(int dwFlags, char* pwszLanguagesBuffer, cpointer unfoundType_PULONG_pulNumLanguages);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetUserPreferredUILanguages(int dwFlags, cpointer unfoundType_PULONG_pulNumLanguages, cpointer unfoundType_PZZWSTR_pwszLanguagesBuffer, cpointer unfoundType_PULONG_pcchLanguagesBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetSystemPreferredUILanguages(int dwFlags, cpointer unfoundType_PULONG_pulNumLanguages, cpointer unfoundType_PZZWSTR_pwszLanguagesBuffer, cpointer unfoundType_PULONG_pcchLanguagesBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetThreadPreferredUILanguages(int dwFlags, cpointer unfoundType_PULONG_pulNumLanguages, cpointer unfoundType_PZZWSTR_pwszLanguagesBuffer, cpointer unfoundType_PULONG_pcchLanguagesBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetThreadPreferredUILanguages(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pwszLanguagesBuffer, cpointer unfoundType_PULONG_pulNumLanguages);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetThreadPreferredUILanguages(int dwFlags, char* pwszLanguagesBuffer, cpointer unfoundType_PULONG_pulNumLanguages);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileMUIInfo(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pcwszFilePath, cpointer unfoundType_PFILEMUIINFO_pFileMUIInfo, cpointer pcbFileMUIInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileMUIInfo(int dwFlags, char* pcwszFilePath, cpointer unfoundType_PFILEMUIINFO_pFileMUIInfo, cpointer pcbFileMUIInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileMUIPath(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pcwszFilePath, [MarshalAs(UnmanagedType.LPWStr)] string pwszLanguage, cpointer unfoundType_PULONG_pcchLanguage, [MarshalAs(UnmanagedType.LPWStr)] string pwszFileMUIPath, cpointer unfoundType_PULONG_pcchFileMUIPath, cpointer unfoundType_PULONGLONG_pululEnumerator);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileMUIPath(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pcwszFilePath, [MarshalAs(UnmanagedType.LPWStr)] string pwszLanguage, cpointer unfoundType_PULONG_pcchLanguage, char* pwszFileMUIPath, cpointer unfoundType_PULONG_pcchFileMUIPath, cpointer unfoundType_PULONGLONG_pululEnumerator);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileMUIPath(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pcwszFilePath, char* pwszLanguage, cpointer unfoundType_PULONG_pcchLanguage, [MarshalAs(UnmanagedType.LPWStr)] string pwszFileMUIPath, cpointer unfoundType_PULONG_pcchFileMUIPath, cpointer unfoundType_PULONGLONG_pululEnumerator);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileMUIPath(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pcwszFilePath, char* pwszLanguage, cpointer unfoundType_PULONG_pcchLanguage, char* pwszFileMUIPath, cpointer unfoundType_PULONG_pcchFileMUIPath, cpointer unfoundType_PULONGLONG_pululEnumerator);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileMUIPath(int dwFlags, char* pcwszFilePath, [MarshalAs(UnmanagedType.LPWStr)] string pwszLanguage, cpointer unfoundType_PULONG_pcchLanguage, [MarshalAs(UnmanagedType.LPWStr)] string pwszFileMUIPath, cpointer unfoundType_PULONG_pcchFileMUIPath, cpointer unfoundType_PULONGLONG_pululEnumerator);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileMUIPath(int dwFlags, char* pcwszFilePath, [MarshalAs(UnmanagedType.LPWStr)] string pwszLanguage, cpointer unfoundType_PULONG_pcchLanguage, char* pwszFileMUIPath, cpointer unfoundType_PULONG_pcchFileMUIPath, cpointer unfoundType_PULONGLONG_pululEnumerator);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileMUIPath(int dwFlags, char* pcwszFilePath, char* pwszLanguage, cpointer unfoundType_PULONG_pcchLanguage, [MarshalAs(UnmanagedType.LPWStr)] string pwszFileMUIPath, cpointer unfoundType_PULONG_pcchFileMUIPath, cpointer unfoundType_PULONGLONG_pululEnumerator);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileMUIPath(int dwFlags, char* pcwszFilePath, char* pwszLanguage, cpointer unfoundType_PULONG_pcchLanguage, char* pwszFileMUIPath, cpointer unfoundType_PULONG_pcchFileMUIPath, cpointer unfoundType_PULONGLONG_pululEnumerator);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetUILanguageInfo(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pwmszLanguage, cpointer unfoundType_PZZWSTR_pwszFallbackLanguages, cpointer unfoundType_PDWORD_pcchFallbackLanguages, cpointer unfoundType_PDWORD_pAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetUILanguageInfo(int dwFlags, char* pwmszLanguage, cpointer unfoundType_PZZWSTR_pwszFallbackLanguages, cpointer unfoundType_PDWORD_pcchFallbackLanguages, cpointer unfoundType_PDWORD_pAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool NotifyUILanguageChange(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pcwstrNewLanguage, [MarshalAs(UnmanagedType.LPWStr)] string pcwstrPreviousLanguage, int dwReserved, cpointer unfoundType_PDWORD_pdwStatusRtrn);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool NotifyUILanguageChange(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pcwstrNewLanguage, char* pcwstrPreviousLanguage, int dwReserved, cpointer unfoundType_PDWORD_pdwStatusRtrn);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool NotifyUILanguageChange(int dwFlags, char* pcwstrNewLanguage, [MarshalAs(UnmanagedType.LPWStr)] string pcwstrPreviousLanguage, int dwReserved, cpointer unfoundType_PDWORD_pdwStatusRtrn);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool NotifyUILanguageChange(int dwFlags, char* pcwstrNewLanguage, char* pcwstrPreviousLanguage, int dwReserved, cpointer unfoundType_PDWORD_pdwStatusRtrn);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetStringTypeExA(cpointer unfoundType_LCID_Locale, int dwInfoType, [MarshalAs(UnmanagedType.LPStr)] string lpSrcStr, int cchSrc, cpointer unfoundType_LPWORD_lpCharType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetStringTypeExA(cpointer unfoundType_LCID_Locale, int dwInfoType, byte* lpSrcStr, int cchSrc, cpointer unfoundType_LPWORD_lpCharType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetStringTypeA(cpointer unfoundType_LCID_Locale, int dwInfoType, [MarshalAs(UnmanagedType.LPStr)] string lpSrcStr, int cchSrc, cpointer unfoundType_LPWORD_lpCharType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetStringTypeA(cpointer unfoundType_LCID_Locale, int dwInfoType, byte* lpSrcStr, int cchSrc, cpointer unfoundType_LPWORD_lpCharType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FoldStringA(int dwMapFlags, [MarshalAs(UnmanagedType.LPStr)] string lpSrcStr, int cchSrc, [MarshalAs(UnmanagedType.LPStr)] string lpDestStr, int cchDest);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FoldStringA(int dwMapFlags, [MarshalAs(UnmanagedType.LPStr)] string lpSrcStr, int cchSrc, ReadOnlySpan<byte> lpDestStr, int cchDest);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FoldStringA(int dwMapFlags, [MarshalAs(UnmanagedType.LPStr)] string lpSrcStr, int cchSrc, byte* lpDestStr, int cchDest);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FoldStringA(int dwMapFlags, byte* lpSrcStr, int cchSrc, [MarshalAs(UnmanagedType.LPStr)] string lpDestStr, int cchDest);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FoldStringA(int dwMapFlags, byte* lpSrcStr, int cchSrc, ReadOnlySpan<byte> lpDestStr, int cchDest);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FoldStringA(int dwMapFlags, byte* lpSrcStr, int cchSrc, byte* lpDestStr, int cchDest);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumSystemLocalesA(cpointer unfoundType_LOCALE_ENUMPROCA_lpLocaleEnumProc, int dwFlags);
    [DllImport(lib, EntryPoint = "EnumSystemLocalesW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumSystemLocales(cpointer unfoundType_LOCALE_ENUMPROCW_lpLocaleEnumProc, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumSystemLocalesW(cpointer unfoundType_LOCALE_ENUMPROCW_lpLocaleEnumProc, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumSystemLanguageGroupsA(cpointer unfoundType_LANGUAGEGROUP_ENUMPROCA_lpLanguageGroupEnumProc, int dwFlags, long lParam);
    [DllImport(lib, EntryPoint = "EnumSystemLanguageGroupsW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumSystemLanguageGroups(cpointer unfoundType_LANGUAGEGROUP_ENUMPROCW_lpLanguageGroupEnumProc, int dwFlags, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumSystemLanguageGroupsW(cpointer unfoundType_LANGUAGEGROUP_ENUMPROCW_lpLanguageGroupEnumProc, int dwFlags, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumLanguageGroupLocalesA(cpointer unfoundType_LANGGROUPLOCALE_ENUMPROCA_lpLangGroupLocaleEnumProc, cpointer unfoundType_LGRPID_LanguageGroup, int dwFlags, long lParam);
    [DllImport(lib, EntryPoint = "EnumLanguageGroupLocalesW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumLanguageGroupLocales(cpointer unfoundType_LANGGROUPLOCALE_ENUMPROCW_lpLangGroupLocaleEnumProc, cpointer unfoundType_LGRPID_LanguageGroup, int dwFlags, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumLanguageGroupLocalesW(cpointer unfoundType_LANGGROUPLOCALE_ENUMPROCW_lpLangGroupLocaleEnumProc, cpointer unfoundType_LGRPID_LanguageGroup, int dwFlags, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumUILanguagesA(cpointer unfoundType_UILANGUAGE_ENUMPROCA_lpUILanguageEnumProc, int dwFlags, long lParam);
    [DllImport(lib, EntryPoint = "EnumUILanguagesW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumUILanguages(cpointer unfoundType_UILANGUAGE_ENUMPROCW_lpUILanguageEnumProc, int dwFlags, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumUILanguagesW(cpointer unfoundType_UILANGUAGE_ENUMPROCW_lpUILanguageEnumProc, int dwFlags, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumSystemCodePagesA(cpointer unfoundType_CODEPAGE_ENUMPROCA_lpCodePageEnumProc, int dwFlags);
    [DllImport(lib, EntryPoint = "EnumSystemCodePagesW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumSystemCodePages(cpointer unfoundType_CODEPAGE_ENUMPROCW_lpCodePageEnumProc, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumSystemCodePagesW(cpointer unfoundType_CODEPAGE_ENUMPROCW_lpCodePageEnumProc, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLocaleInfoEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, cpointer unfoundType_LCTYPE_LCType, string lpLCData, int cchData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLocaleInfoEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, cpointer unfoundType_LCTYPE_LCType, char* lpLCData, int cchData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLocaleInfoEx(char* lpLocaleName, cpointer unfoundType_LCTYPE_LCType, string lpLCData, int cchData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLocaleInfoEx(char* lpLocaleName, cpointer unfoundType_LCTYPE_LCType, char* lpLCData, int cchData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCalendarInfoEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, cpointer unfoundType_CALID_Calendar, [MarshalAs(UnmanagedType.LPWStr)] string lpReserved, cpointer unfoundType_CALTYPE_CalType, string lpCalData, int cchData, cpointer unfoundType_LPDWORD_lpValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCalendarInfoEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, cpointer unfoundType_CALID_Calendar, [MarshalAs(UnmanagedType.LPWStr)] string lpReserved, cpointer unfoundType_CALTYPE_CalType, char* lpCalData, int cchData, cpointer unfoundType_LPDWORD_lpValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCalendarInfoEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, cpointer unfoundType_CALID_Calendar, char* lpReserved, cpointer unfoundType_CALTYPE_CalType, string lpCalData, int cchData, cpointer unfoundType_LPDWORD_lpValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCalendarInfoEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, cpointer unfoundType_CALID_Calendar, char* lpReserved, cpointer unfoundType_CALTYPE_CalType, char* lpCalData, int cchData, cpointer unfoundType_LPDWORD_lpValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCalendarInfoEx(char* lpLocaleName, cpointer unfoundType_CALID_Calendar, [MarshalAs(UnmanagedType.LPWStr)] string lpReserved, cpointer unfoundType_CALTYPE_CalType, string lpCalData, int cchData, cpointer unfoundType_LPDWORD_lpValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCalendarInfoEx(char* lpLocaleName, cpointer unfoundType_CALID_Calendar, [MarshalAs(UnmanagedType.LPWStr)] string lpReserved, cpointer unfoundType_CALTYPE_CalType, char* lpCalData, int cchData, cpointer unfoundType_LPDWORD_lpValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCalendarInfoEx(char* lpLocaleName, cpointer unfoundType_CALID_Calendar, char* lpReserved, cpointer unfoundType_CALTYPE_CalType, string lpCalData, int cchData, cpointer unfoundType_LPDWORD_lpValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCalendarInfoEx(char* lpLocaleName, cpointer unfoundType_CALID_Calendar, char* lpReserved, cpointer unfoundType_CALTYPE_CalType, char* lpCalData, int cchData, cpointer unfoundType_LPDWORD_lpValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, cpointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, string lpNumberStr, int cchNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, cpointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, char* lpNumberStr, int cchNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, char* lpValue, cpointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, string lpNumberStr, int cchNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, char* lpValue, cpointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, char* lpNumberStr, int cchNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormatEx(char* lpLocaleName, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, cpointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, string lpNumberStr, int cchNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormatEx(char* lpLocaleName, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, cpointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, char* lpNumberStr, int cchNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormatEx(char* lpLocaleName, int dwFlags, char* lpValue, cpointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, string lpNumberStr, int cchNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormatEx(char* lpLocaleName, int dwFlags, char* lpValue, cpointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, char* lpNumberStr, int cchNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, cpointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, string lpCurrencyStr, int cchCurrency);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, cpointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, char* lpCurrencyStr, int cchCurrency);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, char* lpValue, cpointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, string lpCurrencyStr, int cchCurrency);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, char* lpValue, cpointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, char* lpCurrencyStr, int cchCurrency);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormatEx(char* lpLocaleName, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, cpointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, string lpCurrencyStr, int cchCurrency);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormatEx(char* lpLocaleName, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, cpointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, char* lpCurrencyStr, int cchCurrency);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormatEx(char* lpLocaleName, int dwFlags, char* lpValue, cpointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, string lpCurrencyStr, int cchCurrency);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormatEx(char* lpLocaleName, int dwFlags, char* lpValue, cpointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, char* lpCurrencyStr, int cchCurrency);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetUserDefaultLocaleName(string lpLocaleName, int cchLocaleName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetUserDefaultLocaleName(char* lpLocaleName, int cchLocaleName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetSystemDefaultLocaleName(string lpLocaleName, int cchLocaleName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetSystemDefaultLocaleName(char* lpLocaleName, int cchLocaleName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsNLSDefinedString(cpointer unfoundType_NLS_FUNCTION_Function, int dwFlags, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, [MarshalAs(UnmanagedType.LPWStr)] string lpString, int cchStr);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsNLSDefinedString(cpointer unfoundType_NLS_FUNCTION_Function, int dwFlags, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, char* lpString, int cchStr);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNLSVersionEx(cpointer unfoundType_NLS_FUNCTION_function, [MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, cpointer unfoundType_LPNLSVERSIONINFOEX_lpVersionInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNLSVersionEx(cpointer unfoundType_NLS_FUNCTION_function, char* lpLocaleName, cpointer unfoundType_LPNLSVERSIONINFOEX_lpVersionInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int IsValidNLSVersion(cpointer unfoundType_NLS_FUNCTION_function, [MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, cpointer unfoundType_LPNLSVERSIONINFOEX_lpVersionInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int IsValidNLSVersion(cpointer unfoundType_NLS_FUNCTION_function, char* lpLocaleName, cpointer unfoundType_LPNLSVERSIONINFOEX_lpVersionInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FindNLSStringEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFindNLSStringFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpStringSource, int cchSource, [MarshalAs(UnmanagedType.LPWStr)] string lpStringValue, int cchValue, cpointer unfoundType_LPINT_pcchFound, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long sortHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FindNLSStringEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFindNLSStringFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpStringSource, int cchSource, char* lpStringValue, int cchValue, cpointer unfoundType_LPINT_pcchFound, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long sortHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FindNLSStringEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFindNLSStringFlags, char* lpStringSource, int cchSource, [MarshalAs(UnmanagedType.LPWStr)] string lpStringValue, int cchValue, cpointer unfoundType_LPINT_pcchFound, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long sortHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FindNLSStringEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFindNLSStringFlags, char* lpStringSource, int cchSource, char* lpStringValue, int cchValue, cpointer unfoundType_LPINT_pcchFound, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long sortHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FindNLSStringEx(char* lpLocaleName, int dwFindNLSStringFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpStringSource, int cchSource, [MarshalAs(UnmanagedType.LPWStr)] string lpStringValue, int cchValue, cpointer unfoundType_LPINT_pcchFound, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long sortHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FindNLSStringEx(char* lpLocaleName, int dwFindNLSStringFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpStringSource, int cchSource, char* lpStringValue, int cchValue, cpointer unfoundType_LPINT_pcchFound, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long sortHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FindNLSStringEx(char* lpLocaleName, int dwFindNLSStringFlags, char* lpStringSource, int cchSource, [MarshalAs(UnmanagedType.LPWStr)] string lpStringValue, int cchValue, cpointer unfoundType_LPINT_pcchFound, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long sortHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FindNLSStringEx(char* lpLocaleName, int dwFindNLSStringFlags, char* lpStringSource, int cchSource, char* lpStringValue, int cchValue, cpointer unfoundType_LPINT_pcchFound, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long sortHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapStringEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwMapFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, string lpDestStr, int cchDest, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long sortHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapStringEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwMapFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, char* lpDestStr, int cchDest, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long sortHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapStringEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwMapFlags, char* lpSrcStr, int cchSrc, string lpDestStr, int cchDest, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long sortHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapStringEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwMapFlags, char* lpSrcStr, int cchSrc, char* lpDestStr, int cchDest, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long sortHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapStringEx(char* lpLocaleName, int dwMapFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, string lpDestStr, int cchDest, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long sortHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapStringEx(char* lpLocaleName, int dwMapFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, char* lpDestStr, int cchDest, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long sortHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapStringEx(char* lpLocaleName, int dwMapFlags, char* lpSrcStr, int cchSrc, string lpDestStr, int cchDest, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long sortHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapStringEx(char* lpLocaleName, int dwMapFlags, char* lpSrcStr, int cchSrc, char* lpDestStr, int cchDest, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long sortHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsValidLocaleName([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsValidLocaleName(char* lpLocaleName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumCalendarInfoExEx(cpointer unfoundType_CALINFO_ENUMPROCEXEX_pCalInfoEnumProcExEx, [MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, cpointer unfoundType_CALID_Calendar, [MarshalAs(UnmanagedType.LPWStr)] string lpReserved, cpointer unfoundType_CALTYPE_CalType, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumCalendarInfoExEx(cpointer unfoundType_CALINFO_ENUMPROCEXEX_pCalInfoEnumProcExEx, [MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, cpointer unfoundType_CALID_Calendar, char* lpReserved, cpointer unfoundType_CALTYPE_CalType, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumCalendarInfoExEx(cpointer unfoundType_CALINFO_ENUMPROCEXEX_pCalInfoEnumProcExEx, char* lpLocaleName, cpointer unfoundType_CALID_Calendar, [MarshalAs(UnmanagedType.LPWStr)] string lpReserved, cpointer unfoundType_CALTYPE_CalType, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumCalendarInfoExEx(cpointer unfoundType_CALINFO_ENUMPROCEXEX_pCalInfoEnumProcExEx, char* lpLocaleName, cpointer unfoundType_CALID_Calendar, char* lpReserved, cpointer unfoundType_CALTYPE_CalType, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumDateFormatsExEx(cpointer unfoundType_DATEFMT_ENUMPROCEXEX_lpDateFmtEnumProcExEx, [MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumDateFormatsExEx(cpointer unfoundType_DATEFMT_ENUMPROCEXEX_lpDateFmtEnumProcExEx, char* lpLocaleName, int dwFlags, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumTimeFormatsEx(cpointer unfoundType_TIMEFMT_ENUMPROCEX_lpTimeFmtEnumProcEx, [MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumTimeFormatsEx(cpointer unfoundType_TIMEFMT_ENUMPROCEX_lpTimeFmtEnumProcEx, char* lpLocaleName, int dwFlags, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumSystemLocalesEx(cpointer unfoundType_LOCALE_ENUMPROCEX_lpLocaleEnumProcEx, int dwFlags, long lParam, cpointer lpReserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ResolveLocaleName([MarshalAs(UnmanagedType.LPWStr)] string lpNameToResolve, string lpLocaleName, int cchLocaleName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ResolveLocaleName([MarshalAs(UnmanagedType.LPWStr)] string lpNameToResolve, char* lpLocaleName, int cchLocaleName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ResolveLocaleName(char* lpNameToResolve, string lpLocaleName, int cchLocaleName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ResolveLocaleName(char* lpNameToResolve, char* lpLocaleName, int cchLocaleName);

}