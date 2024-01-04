using System.Runtime.InteropServices;

public unsafe class kernel32
{
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsEnclaveTypeSupported(int flEnclaveType);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateEnclave(cpointer hProcess, cpointer lpAddress, cpointer dwSize, cpointer dwInitialCommitment, int flEnclaveType, cpointer lpEnclaveInformation, int dwInfoLength, cpointer unfoundType_LPDWORD_lpEnclaveError);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int LoadEnclaveData(cpointer hProcess, cpointer lpAddress, cpointer lpBuffer, cpointer nSize, int flProtect, cpointer lpPageInformation, int dwInfoLength, cpointer unfoundType_PSIZE_T_lpNumberOfBytesWritten, cpointer unfoundType_LPDWORD_lpEnclaveError);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int InitializeEnclave(cpointer hProcess, cpointer lpAddress, cpointer lpEnclaveInformation, int dwInfoLength, cpointer unfoundType_LPDWORD_lpEnclaveError);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer VirtualAlloc(cpointer lpAddress, cpointer dwSize, int flAllocationType, int flProtect);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int VirtualProtect(cpointer lpAddress, cpointer dwSize, int flNewProtect, cpointer unfoundType_PDWORD_lpflOldProtect);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int VirtualFree(cpointer lpAddress, cpointer dwSize, int dwFreeType);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint* VirtualQuery(cpointer lpAddress, cpointer unfoundType_PMEMORY_BASIC_INFORMATION_lpBuffer, cpointer dwLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer VirtualAllocEx(cpointer hProcess, cpointer lpAddress, cpointer dwSize, int flAllocationType, int flProtect);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int VirtualProtectEx(cpointer hProcess, cpointer lpAddress, cpointer dwSize, int flNewProtect, cpointer unfoundType_PDWORD_lpflOldProtect);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint* VirtualQueryEx(cpointer hProcess, cpointer lpAddress, cpointer unfoundType_PMEMORY_BASIC_INFORMATION_lpBuffer, cpointer dwLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ReadProcessMemory(cpointer hProcess, cpointer lpBaseAddress, cpointer lpBuffer, cpointer nSize, cpointer lpNumberOfBytesRead);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteProcessMemory(cpointer hProcess, cpointer lpBaseAddress, cpointer lpBuffer, cpointer nSize, cpointer lpNumberOfBytesWritten);
    [DllImport("kernel32", EntryPoint="CreateFileMappingW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateFileMapping(cpointer hFile, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpFileMappingAttributes, int flProtect, int dwMaximumSizeHigh, int dwMaximumSizeLow, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport("kernel32", EntryPoint="CreateFileMappingW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateFileMapping(cpointer hFile, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpFileMappingAttributes, int flProtect, int dwMaximumSizeHigh, int dwMaximumSizeLow, char* lpName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateFileMappingW(cpointer hFile, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpFileMappingAttributes, int flProtect, int dwMaximumSizeHigh, int dwMaximumSizeLow, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateFileMappingW(cpointer hFile, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpFileMappingAttributes, int flProtect, int dwMaximumSizeHigh, int dwMaximumSizeLow, char* lpName);
    [DllImport("kernel32", EntryPoint="OpenFileMappingW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenFileMapping(int dwDesiredAccess, int bInheritHandle, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport("kernel32", EntryPoint="OpenFileMappingW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenFileMapping(int dwDesiredAccess, int bInheritHandle, char* lpName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenFileMappingW(int dwDesiredAccess, int bInheritHandle, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenFileMappingW(int dwDesiredAccess, int bInheritHandle, char* lpName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer MapViewOfFile(cpointer hFileMappingObject, int dwDesiredAccess, int dwFileOffsetHigh, int dwFileOffsetLow, cpointer dwNumberOfBytesToMap);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer MapViewOfFileEx(cpointer hFileMappingObject, int dwDesiredAccess, int dwFileOffsetHigh, int dwFileOffsetLow, cpointer dwNumberOfBytesToMap, cpointer lpBaseAddress);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int VirtualFreeEx(cpointer hProcess, cpointer lpAddress, cpointer dwSize, int dwFreeType);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FlushViewOfFile(cpointer lpBaseAddress, cpointer dwNumberOfBytesToFlush);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int UnmapViewOfFile(cpointer lpBaseAddress);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint* GetLargePageMinimum();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProcessWorkingSetSize(cpointer hProcess, cpointer unfoundType_PSIZE_T_lpMinimumWorkingSetSize, cpointer unfoundType_PSIZE_T_lpMaximumWorkingSetSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProcessWorkingSetSizeEx(cpointer hProcess, cpointer unfoundType_PSIZE_T_lpMinimumWorkingSetSize, cpointer unfoundType_PSIZE_T_lpMaximumWorkingSetSize, cpointer unfoundType_PDWORD_Flags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetProcessWorkingSetSize(cpointer hProcess, cpointer dwMinimumWorkingSetSize, cpointer dwMaximumWorkingSetSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetProcessWorkingSetSizeEx(cpointer hProcess, cpointer dwMinimumWorkingSetSize, cpointer dwMaximumWorkingSetSize, int Flags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int VirtualLock(cpointer lpAddress, cpointer dwSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int VirtualUnlock(cpointer lpAddress, cpointer dwSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetWriteWatch(int dwFlags, cpointer lpBaseAddress, cpointer dwRegionSize, cpointer lpAddresses, cpointer unfoundType_ULONG_PTR_lpdwCount, cpointer unfoundType_LPDWORD_lpdwGranularity);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint ResetWriteWatch(cpointer lpBaseAddress, cpointer dwRegionSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateMemoryResourceNotification(cpointer unfoundType_MEMORY_RESOURCE_NOTIFICATION_TYPE_NotificationType);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryMemoryResourceNotification(cpointer ResourceNotificationHandle, cpointer ResourceState);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetSystemFileCacheSize(cpointer unfoundType_PSIZE_T_lpMinimumFileCacheSize, cpointer unfoundType_PSIZE_T_lpMaximumFileCacheSize, cpointer unfoundType_PDWORD_lpFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetSystemFileCacheSize(cpointer MinimumFileCacheSize, cpointer MaximumFileCacheSize, int Flags);
    [DllImport("kernel32", EntryPoint="CreateFileMappingNumaW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateFileMappingNuma(cpointer hFile, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpFileMappingAttributes, int flProtect, int dwMaximumSizeHigh, int dwMaximumSizeLow, [MarshalAs(UnmanagedType.LPWStr)] string lpName, int nndPreferred);
    [DllImport("kernel32", EntryPoint="CreateFileMappingNumaW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateFileMappingNuma(cpointer hFile, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpFileMappingAttributes, int flProtect, int dwMaximumSizeHigh, int dwMaximumSizeLow, char* lpName, int nndPreferred);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateFileMappingNumaW(cpointer hFile, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpFileMappingAttributes, int flProtect, int dwMaximumSizeHigh, int dwMaximumSizeLow, [MarshalAs(UnmanagedType.LPWStr)] string lpName, int nndPreferred);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateFileMappingNumaW(cpointer hFile, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpFileMappingAttributes, int flProtect, int dwMaximumSizeHigh, int dwMaximumSizeLow, char* lpName, int nndPreferred);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int PrefetchVirtualMemory(cpointer hProcess, cpointer unfoundType_ULONG_PTR_NumberOfEntries, cpointer unfoundType_PWIN32_MEMORY_RANGE_ENTRY_VirtualAddresses, uint Flags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateFileMappingFromApp(cpointer hFile, cpointer unfoundType_PSECURITY_ATTRIBUTES_SecurityAttributes, uint PageProtection, cpointer unfoundType_ULONG64_MaximumSize, [MarshalAs(UnmanagedType.LPWStr)] string Name);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateFileMappingFromApp(cpointer hFile, cpointer unfoundType_PSECURITY_ATTRIBUTES_SecurityAttributes, uint PageProtection, cpointer unfoundType_ULONG64_MaximumSize, char* Name);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer MapViewOfFileFromApp(cpointer hFileMappingObject, uint DesiredAccess, cpointer unfoundType_ULONG64_FileOffset, cpointer NumberOfBytesToMap);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int UnmapViewOfFileEx(cpointer BaseAddress, uint UnmapFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AllocateUserPhysicalPages(cpointer hProcess, cpointer NumberOfPages, cpointer PageArray);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FreeUserPhysicalPages(cpointer hProcess, cpointer NumberOfPages, cpointer PageArray);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int MapUserPhysicalPages(cpointer VirtualAddress, cpointer unfoundType_ULONG_PTR_NumberOfPages, cpointer PageArray);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AllocateUserPhysicalPagesNuma(cpointer hProcess, cpointer NumberOfPages, cpointer PageArray, int nndPreferred);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer VirtualAllocExNuma(cpointer hProcess, cpointer lpAddress, cpointer dwSize, int flAllocationType, int flProtect, int nndPreferred);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetMemoryErrorHandlingCapabilities(cpointer unfoundType_PULONG_Capabilities);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegisterBadMemoryNotification(cpointer unfoundType_PBAD_MEMORY_CALLBACK_ROUTINE_Callback);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int UnregisterBadMemoryNotification(cpointer RegistrationHandle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int OfferVirtualMemory(cpointer VirtualAddress, cpointer Size, cpointer unfoundType_OFFER_PRIORITY_Priority);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ReclaimVirtualMemory(cpointer VirtualAddress, cpointer Size);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DiscardVirtualMemory(cpointer VirtualAddress, cpointer Size);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void RaiseException(int dwExceptionCode, int dwExceptionFlags, int nNumberOfArguments, cpointer unfoundType_ULONG_PTR_lpArguments);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int UnhandledExceptionFilter(cpointer unfoundType__EXCEPTION_POINTERS_ExceptionInfo);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer SetUnhandledExceptionFilter(cpointer unfoundType_LPTOP_LEVEL_EXCEPTION_FILTER_lpTopLevelExceptionFilter);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLastError();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void SetLastError(int dwErrCode);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetErrorMode();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint SetErrorMode(uint uMode);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer AddVectoredExceptionHandler(uint First, cpointer unfoundType_PVECTORED_EXCEPTION_HANDLER_Handler);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint RemoveVectoredExceptionHandler(cpointer Handle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer AddVectoredContinueHandler(uint First, cpointer unfoundType_PVECTORED_EXCEPTION_HANDLER_Handler);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint RemoveVectoredContinueHandler(cpointer Handle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void RestoreLastError(int dwErrCode);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void RaiseFailFastException(cpointer unfoundType_PEXCEPTION_RECORD_pExceptionRecord, cpointer unfoundType_PCONTEXT_pContextRecord, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void FatalAppExitA(uint uAction, cpointer unfoundType_LPCSTR_lpMessageText);
    [DllImport("kernel32", EntryPoint="FatalAppExitW", SetLastError=true, ExactSpelling=true)] public static extern
        void FatalAppExit(uint uAction, [MarshalAs(UnmanagedType.LPWStr)] string lpMessageText);
    [DllImport("kernel32", EntryPoint="FatalAppExitW", SetLastError=true, ExactSpelling=true)] public static extern
        void FatalAppExit(uint uAction, char* lpMessageText);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void FatalAppExitW(uint uAction, [MarshalAs(UnmanagedType.LPWStr)] string lpMessageText);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void FatalAppExitW(uint uAction, char* lpMessageText);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetThreadErrorMode();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetThreadErrorMode(int dwNewMode, cpointer unfoundType_LPDWORD_lpOldMode);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void InitializeSListHead(cpointer unfoundType_PSLIST_HEADER_ListHead);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer InterlockedPopEntrySList(cpointer unfoundType_PSLIST_HEADER_ListHead);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer InterlockedPushEntrySList(cpointer unfoundType_PSLIST_HEADER_ListHead, cpointer unfoundType_PSLIST_ENTRY_ListEntry);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer InterlockedPushListSListEx(cpointer unfoundType_PSLIST_HEADER_ListHead, cpointer unfoundType_PSLIST_ENTRY_List, cpointer unfoundType_PSLIST_ENTRY_ListEnd, uint Count);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer InterlockedFlushSList(cpointer unfoundType_PSLIST_HEADER_ListHead);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        ushort QueryDepthSList(cpointer unfoundType_PSLIST_HEADER_ListHead);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateIoCompletionPort(cpointer FileHandle, cpointer ExistingCompletionPort, cpointer unfoundType_ULONG_PTR_CompletionKey, int NumberOfConcurrentThreads);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetQueuedCompletionStatus(cpointer CompletionPort, cpointer unfoundType_LPDWORD_lpNumberOfBytesTransferred, cpointer lpCompletionKey, cpointer unfoundType_LPOVERLAPPED_lpOverlapped, int dwMilliseconds);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetQueuedCompletionStatusEx(cpointer CompletionPort, cpointer unfoundType_LPOVERLAPPED_ENTRY_lpCompletionPortEntries, uint ulCount, cpointer unfoundType_PULONG_ulNumEntriesRemoved, int dwMilliseconds, int fAlertable);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int PostQueuedCompletionStatus(cpointer CompletionPort, int dwNumberOfBytesTransferred, cpointer unfoundType_ULONG_PTR_dwCompletionKey, cpointer unfoundType_LPOVERLAPPED_lpOverlapped);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DeviceIoControl(cpointer hDevice, int dwIoControlCode, cpointer lpInBuffer, int nInBufferSize, cpointer lpOutBuffer, int nOutBufferSize, cpointer unfoundType_LPDWORD_lpBytesReturned, cpointer unfoundType_LPOVERLAPPED_lpOverlapped);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetOverlappedResult(cpointer hFile, cpointer unfoundType_LPOVERLAPPED_lpOverlapped, cpointer unfoundType_LPDWORD_lpNumberOfBytesTransferred, int bWait);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CancelIoEx(cpointer hFile, cpointer unfoundType_LPOVERLAPPED_lpOverlapped);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CancelIo(cpointer hFile);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetOverlappedResultEx(cpointer hFile, cpointer unfoundType_LPOVERLAPPED_lpOverlapped, cpointer unfoundType_LPDWORD_lpNumberOfBytesTransferred, int dwMilliseconds, int bAlertable);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CancelSynchronousIo(cpointer hThread);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateIoRing(cpointer unfoundType_IORING_VERSION_ioringVersion, cpointer unfoundType_IORING_CREATE_FLAGS_flags, uint submissionQueueSize, uint completionQueueSize, cpointer unfoundType_HIORING_h);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer BuildIoRingReadFile(cpointer unfoundType_HIORING_ioRing, cpointer unfoundType_IORING_HANDLE_REF_fileRef, cpointer unfoundType_IORING_BUFFER_REF_dataRef, uint numberOfBytesToRead, cpointer unfoundType_UINT64_fileOffset, ulong userData, cpointer unfoundType_IORING_SQE_FLAGS_sqeFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer BuildIoRingRegisterFileHandles(cpointer unfoundType_HIORING_ioRing, uint count, cpointer handles, ulong userData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer BuildIoRingRegisterBuffers(cpointer unfoundType_HIORING_ioRing, uint count, cpointer unfoundType_IORING_BUFFER_INFO_buffers, ulong userData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer BuildIoRingWriteFile(cpointer unfoundType_HIORING_ioRing, cpointer unfoundType_IORING_HANDLE_REF_fileRef, cpointer unfoundType_IORING_BUFFER_REF_bufferRef, uint numberOfBytesToWrite, cpointer unfoundType_UINT64_fileOffset, cpointer unfoundType_FILE_WRITE_FLAGS_writeFlags, ulong userData, cpointer unfoundType_IORING_SQE_FLAGS_sqeFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer BuildIoRingFlushFile(cpointer unfoundType_HIORING_ioRing, cpointer unfoundType_IORING_HANDLE_REF_fileRef, cpointer unfoundType_FILE_FLUSH_MODE_flushMode, ulong userData, cpointer unfoundType_IORING_SQE_FLAGS_sqeFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CloseHandle(cpointer hObject);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DuplicateHandle(cpointer hSourceProcessHandle, cpointer hSourceHandle, cpointer hTargetProcessHandle, cpointer unfoundType_LPHANDLE_lpTargetHandle, int dwDesiredAccess, int bInheritHandle, int dwOptions);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetHandleInformation(cpointer hObject, cpointer unfoundType_LPDWORD_lpdwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetHandleInformation(cpointer hObject, int dwMask, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer HeapCreate(int flOptions, cpointer dwInitialSize, cpointer dwMaximumSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int HeapDestroy(cpointer hHeap);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer HeapAlloc(cpointer hHeap, int dwFlags, cpointer dwBytes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer HeapReAlloc(cpointer hHeap, int dwFlags, cpointer lpMem, cpointer dwBytes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int HeapFree(cpointer hHeap, int dwFlags, cpointer lpMem);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint* HeapSize(cpointer hHeap, int dwFlags, cpointer lpMem);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetProcessHeap();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint* HeapCompact(cpointer hHeap, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int HeapSetInformation(cpointer HeapHandle, cpointer unfoundType_HEAP_INFORMATION_CLASS_HeapInformationClass, cpointer HeapInformation, cpointer HeapInformationLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int HeapValidate(cpointer hHeap, int dwFlags, cpointer lpMem);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int HeapSummary(cpointer hHeap, int dwFlags, cpointer unfoundType_LPHEAP_SUMMARY_lpSummary);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProcessHeaps(int NumberOfHeaps, cpointer unfoundType_PHANDLE_ProcessHeaps);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int HeapLock(cpointer hHeap);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int HeapUnlock(cpointer hHeap);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int HeapWalk(cpointer hHeap, cpointer unfoundType_LPPROCESS_HEAP_ENTRY_lpEntry);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int HeapQueryInformation(cpointer HeapHandle, cpointer unfoundType_HEAP_INFORMATION_CLASS_HeapInformationClass, cpointer HeapInformation, cpointer HeapInformationLength, cpointer unfoundType_PSIZE_T_ReturnLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsProcessInJob(cpointer ProcessHandle, cpointer JobHandle, cpointer Result);
    [DllImport("kernel32", EntryPoint="CreateJobObjectW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateJobObject(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpJobAttributes, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport("kernel32", EntryPoint="CreateJobObjectW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateJobObject(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpJobAttributes, char* lpName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateJobObjectW(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpJobAttributes, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateJobObjectW(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpJobAttributes, char* lpName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void FreeMemoryJobObject(cpointer Buffer);
    [DllImport("kernel32", EntryPoint="OpenJobObjectW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenJobObject(int dwDesiredAccess, int bInheritHandle, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport("kernel32", EntryPoint="OpenJobObjectW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenJobObject(int dwDesiredAccess, int bInheritHandle, char* lpName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenJobObjectW(int dwDesiredAccess, int bInheritHandle, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenJobObjectW(int dwDesiredAccess, int bInheritHandle, char* lpName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AssignProcessToJobObject(cpointer hJob, cpointer hProcess);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int TerminateJobObject(cpointer hJob, uint uExitCode);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetInformationJobObject(cpointer hJob, cpointer unfoundType_JOBOBJECTINFOCLASS_JobObjectInformationClass, cpointer lpJobObjectInformation, int cbJobObjectInformationLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetIoRateControlInformationJobObject(cpointer hJob, cpointer unfoundType_JOBOBJECT_IO_RATE_CONTROL_INFORMATION_IoRateControlInfo);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryInformationJobObject(cpointer hJob, cpointer unfoundType_JOBOBJECTINFOCLASS_JobObjectInformationClass, cpointer lpJobObjectInformation, int cbJobObjectInformationLength, cpointer unfoundType_LPDWORD_lpReturnLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryIoRateControlInformationJobObject(cpointer hJob, [MarshalAs(UnmanagedType.LPWStr)] string VolumeName, cpointer unfoundType_JOBOBJECT_IO_RATE_CONTROL_INFORMATION_InfoBlocks, cpointer InfoBlockCount);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryIoRateControlInformationJobObject(cpointer hJob, char* VolumeName, cpointer unfoundType_JOBOBJECT_IO_RATE_CONTROL_INFORMATION_InfoBlocks, cpointer InfoBlockCount);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DisableThreadLibraryCalls(cpointer unfoundType_HMODULE_hLibModule);
    [DllImport("kernel32", EntryPoint="FindResourceExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindResourceEx(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, short wLanguage);
    [DllImport("kernel32", EntryPoint="FindResourceExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindResourceEx(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, char* lpName, short wLanguage);
    [DllImport("kernel32", EntryPoint="FindResourceExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindResourceEx(cpointer unfoundType_HMODULE_hModule, char* lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, short wLanguage);
    [DllImport("kernel32", EntryPoint="FindResourceExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindResourceEx(cpointer unfoundType_HMODULE_hModule, char* lpType, char* lpName, short wLanguage);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindResourceExW(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, short wLanguage);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindResourceExW(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, char* lpName, short wLanguage);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindResourceExW(cpointer unfoundType_HMODULE_hModule, char* lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, short wLanguage);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindResourceExW(cpointer unfoundType_HMODULE_hModule, char* lpType, char* lpName, short wLanguage);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindStringOrdinal(int dwFindStringOrdinalFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpStringSource, int cchSource, [MarshalAs(UnmanagedType.LPWStr)] string lpStringValue, int cchValue, int bIgnoreCase);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindStringOrdinal(int dwFindStringOrdinalFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpStringSource, int cchSource, char* lpStringValue, int cchValue, int bIgnoreCase);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindStringOrdinal(int dwFindStringOrdinalFlags, char* lpStringSource, int cchSource, [MarshalAs(UnmanagedType.LPWStr)] string lpStringValue, int cchValue, int bIgnoreCase);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindStringOrdinal(int dwFindStringOrdinalFlags, char* lpStringSource, int cchSource, char* lpStringValue, int cchValue, int bIgnoreCase);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FreeLibrary(cpointer unfoundType_HMODULE_hLibModule);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void FreeLibraryAndExitThread(cpointer unfoundType_HMODULE_hLibModule, int dwExitCode);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FreeResource(cpointer unfoundType_HGLOBAL_hResData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetModuleFileNameA(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPStr)] string lpFilename, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetModuleFileNameA(cpointer unfoundType_HMODULE_hModule, ReadOnlySpan<byte> lpFilename, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetModuleFileNameA(cpointer unfoundType_HMODULE_hModule, byte* lpFilename, int nSize);
    [DllImport("kernel32", EntryPoint="GetModuleFileNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetModuleFileName(cpointer unfoundType_HMODULE_hModule, string lpFilename, int nSize);
    [DllImport("kernel32", EntryPoint="GetModuleFileNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetModuleFileName(cpointer unfoundType_HMODULE_hModule, char* lpFilename, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetModuleFileNameW(cpointer unfoundType_HMODULE_hModule, string lpFilename, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetModuleFileNameW(cpointer unfoundType_HMODULE_hModule, char* lpFilename, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetModuleHandleA(cpointer unfoundType_LPCSTR_lpModuleName);
    [DllImport("kernel32", EntryPoint="GetModuleHandleW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetModuleHandle([MarshalAs(UnmanagedType.LPWStr)] string lpModuleName);
    [DllImport("kernel32", EntryPoint="GetModuleHandleW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetModuleHandle(char* lpModuleName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetModuleHandleW([MarshalAs(UnmanagedType.LPWStr)] string lpModuleName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetModuleHandleW(char* lpModuleName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetModuleHandleExA(int dwFlags, cpointer unfoundType_LPCSTR_lpModuleName, cpointer unfoundType_HMODULE_phModule);
    [DllImport("kernel32", EntryPoint="GetModuleHandleExW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetModuleHandleEx(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpModuleName, cpointer unfoundType_HMODULE_phModule);
    [DllImport("kernel32", EntryPoint="GetModuleHandleExW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetModuleHandleEx(int dwFlags, char* lpModuleName, cpointer unfoundType_HMODULE_phModule);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetModuleHandleExW(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpModuleName, cpointer unfoundType_HMODULE_phModule);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetModuleHandleExW(int dwFlags, char* lpModuleName, cpointer unfoundType_HMODULE_phModule);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetProcAddress(cpointer unfoundType_HMODULE_hModule, cpointer unfoundType_LPCSTR_lpProcName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadLibraryExA(cpointer unfoundType_LPCSTR_lpLibFileName, cpointer hFile, int dwFlags);
    [DllImport("kernel32", EntryPoint="LoadLibraryExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadLibraryEx([MarshalAs(UnmanagedType.LPWStr)] string lpLibFileName, cpointer hFile, int dwFlags);
    [DllImport("kernel32", EntryPoint="LoadLibraryExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadLibraryEx(char* lpLibFileName, cpointer hFile, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadLibraryExW([MarshalAs(UnmanagedType.LPWStr)] string lpLibFileName, cpointer hFile, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadLibraryExW(char* lpLibFileName, cpointer hFile, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadResource(cpointer unfoundType_HMODULE_hModule, cpointer unfoundType_HRSRC_hResInfo);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LockResource(cpointer unfoundType_HGLOBAL_hResData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SizeofResource(cpointer unfoundType_HMODULE_hModule, cpointer unfoundType_HRSRC_hResInfo);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer AddDllDirectory([MarshalAs(UnmanagedType.LPWStr)] string NewDirectory);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer AddDllDirectory(char* NewDirectory);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int RemoveDllDirectory(cpointer unfoundType_DLL_DIRECTORY_COOKIE_Cookie);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetDefaultDllDirectories(int DirectoryFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumResourceLanguagesExA(cpointer unfoundType_HMODULE_hModule, cpointer unfoundType_LPCSTR_lpType, cpointer unfoundType_LPCSTR_lpName, cpointer unfoundType_ENUMRESLANGPROCA_lpEnumFunc, long lParam, int dwFlags, cpointer unfoundType_LANGID_LangId);
    [DllImport("kernel32", EntryPoint="EnumResourceLanguagesExW", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumResourceLanguagesEx(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, cpointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam, int dwFlags, cpointer unfoundType_LANGID_LangId);
    [DllImport("kernel32", EntryPoint="EnumResourceLanguagesExW", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumResourceLanguagesEx(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, char* lpName, cpointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam, int dwFlags, cpointer unfoundType_LANGID_LangId);
    [DllImport("kernel32", EntryPoint="EnumResourceLanguagesExW", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumResourceLanguagesEx(cpointer unfoundType_HMODULE_hModule, char* lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, cpointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam, int dwFlags, cpointer unfoundType_LANGID_LangId);
    [DllImport("kernel32", EntryPoint="EnumResourceLanguagesExW", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumResourceLanguagesEx(cpointer unfoundType_HMODULE_hModule, char* lpType, char* lpName, cpointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam, int dwFlags, cpointer unfoundType_LANGID_LangId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumResourceLanguagesExW(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, cpointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam, int dwFlags, cpointer unfoundType_LANGID_LangId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumResourceLanguagesExW(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, char* lpName, cpointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam, int dwFlags, cpointer unfoundType_LANGID_LangId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumResourceLanguagesExW(cpointer unfoundType_HMODULE_hModule, char* lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, cpointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam, int dwFlags, cpointer unfoundType_LANGID_LangId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumResourceLanguagesExW(cpointer unfoundType_HMODULE_hModule, char* lpType, char* lpName, cpointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam, int dwFlags, cpointer unfoundType_LANGID_LangId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumResourceNamesExA(cpointer unfoundType_HMODULE_hModule, cpointer unfoundType_LPCSTR_lpType, cpointer unfoundType_ENUMRESNAMEPROCA_lpEnumFunc, long lParam, int dwFlags, cpointer unfoundType_LANGID_LangId);
    [DllImport("kernel32", EntryPoint="EnumResourceNamesExW", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumResourceNamesEx(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, cpointer unfoundType_ENUMRESNAMEPROCW_lpEnumFunc, long lParam, int dwFlags, cpointer unfoundType_LANGID_LangId);
    [DllImport("kernel32", EntryPoint="EnumResourceNamesExW", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumResourceNamesEx(cpointer unfoundType_HMODULE_hModule, char* lpType, cpointer unfoundType_ENUMRESNAMEPROCW_lpEnumFunc, long lParam, int dwFlags, cpointer unfoundType_LANGID_LangId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumResourceNamesExW(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, cpointer unfoundType_ENUMRESNAMEPROCW_lpEnumFunc, long lParam, int dwFlags, cpointer unfoundType_LANGID_LangId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumResourceNamesExW(cpointer unfoundType_HMODULE_hModule, char* lpType, cpointer unfoundType_ENUMRESNAMEPROCW_lpEnumFunc, long lParam, int dwFlags, cpointer unfoundType_LANGID_LangId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumResourceTypesExA(cpointer unfoundType_HMODULE_hModule, cpointer unfoundType_ENUMRESTYPEPROCA_lpEnumFunc, long lParam, int dwFlags, cpointer unfoundType_LANGID_LangId);
    [DllImport("kernel32", EntryPoint="EnumResourceTypesExW", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumResourceTypesEx(cpointer unfoundType_HMODULE_hModule, cpointer unfoundType_ENUMRESTYPEPROCW_lpEnumFunc, long lParam, int dwFlags, cpointer unfoundType_LANGID_LangId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumResourceTypesExW(cpointer unfoundType_HMODULE_hModule, cpointer unfoundType_ENUMRESTYPEPROCW_lpEnumFunc, long lParam, int dwFlags, cpointer unfoundType_LANGID_LangId);
    [DllImport("kernel32", EntryPoint="FindResourceW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindResource(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpType);
    [DllImport("kernel32", EntryPoint="FindResourceW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindResource(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpName, char* lpType);
    [DllImport("kernel32", EntryPoint="FindResourceW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindResource(cpointer unfoundType_HMODULE_hModule, char* lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpType);
    [DllImport("kernel32", EntryPoint="FindResourceW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindResource(cpointer unfoundType_HMODULE_hModule, char* lpName, char* lpType);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindResourceW(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpType);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindResourceW(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpName, char* lpType);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindResourceW(cpointer unfoundType_HMODULE_hModule, char* lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpType);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindResourceW(cpointer unfoundType_HMODULE_hModule, char* lpName, char* lpType);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadLibraryA(cpointer unfoundType_LPCSTR_lpLibFileName);
    [DllImport("kernel32", EntryPoint="LoadLibraryW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadLibrary([MarshalAs(UnmanagedType.LPWStr)] string lpLibFileName);
    [DllImport("kernel32", EntryPoint="LoadLibraryW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadLibrary(char* lpLibFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadLibraryW([MarshalAs(UnmanagedType.LPWStr)] string lpLibFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadLibraryW(char* lpLibFileName);
    [DllImport("kernel32", EntryPoint="EnumResourceNamesW", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumResourceNames(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, cpointer unfoundType_ENUMRESNAMEPROCW_lpEnumFunc, long lParam);
    [DllImport("kernel32", EntryPoint="EnumResourceNamesW", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumResourceNames(cpointer unfoundType_HMODULE_hModule, char* lpType, cpointer unfoundType_ENUMRESNAMEPROCW_lpEnumFunc, long lParam);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumResourceNamesW(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, cpointer unfoundType_ENUMRESNAMEPROCW_lpEnumFunc, long lParam);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumResourceNamesW(cpointer unfoundType_HMODULE_hModule, char* lpType, cpointer unfoundType_ENUMRESNAMEPROCW_lpEnumFunc, long lParam);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumResourceNamesA(cpointer unfoundType_HMODULE_hModule, cpointer unfoundType_LPCSTR_lpType, cpointer unfoundType_ENUMRESNAMEPROCA_lpEnumFunc, long lParam);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadPackagedLibrary([MarshalAs(UnmanagedType.LPWStr)] string lpwLibFileName, int Reserved);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadPackagedLibrary(char* lpwLibFileName, int Reserved);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int LZStart();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void LZDone();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CopyLZFile(int hfSource, int hfDest);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int LZCopy(int hfSource, int hfDest);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int LZInit(int hfSource);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetExpandedNameA([MarshalAs(UnmanagedType.LPStr)] string lpszSource, [MarshalAs(UnmanagedType.LPStr)] string lpszBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetExpandedNameA([MarshalAs(UnmanagedType.LPStr)] string lpszSource, ReadOnlySpan<byte> lpszBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetExpandedNameA([MarshalAs(UnmanagedType.LPStr)] string lpszSource, byte* lpszBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetExpandedNameA(ReadOnlySpan<byte> lpszSource, [MarshalAs(UnmanagedType.LPStr)] string lpszBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetExpandedNameA(ReadOnlySpan<byte> lpszSource, ReadOnlySpan<byte> lpszBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetExpandedNameA(ReadOnlySpan<byte> lpszSource, byte* lpszBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetExpandedNameA(byte* lpszSource, [MarshalAs(UnmanagedType.LPStr)] string lpszBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetExpandedNameA(byte* lpszSource, ReadOnlySpan<byte> lpszBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetExpandedNameA(byte* lpszSource, byte* lpszBuffer);
    [DllImport("kernel32", EntryPoint="GetExpandedNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetExpandedName(string lpszSource, string lpszBuffer);
    [DllImport("kernel32", EntryPoint="GetExpandedNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetExpandedName(string lpszSource, char* lpszBuffer);
    [DllImport("kernel32", EntryPoint="GetExpandedNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetExpandedName(char* lpszSource, string lpszBuffer);
    [DllImport("kernel32", EntryPoint="GetExpandedNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetExpandedName(char* lpszSource, char* lpszBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetExpandedNameW(string lpszSource, string lpszBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetExpandedNameW(string lpszSource, char* lpszBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetExpandedNameW(char* lpszSource, string lpszBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetExpandedNameW(char* lpszSource, char* lpszBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int LZOpenFileA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, cpointer unfoundType_LPOFSTRUCT_lpReOpenBuf, short wStyle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int LZOpenFileA(ReadOnlySpan<byte> lpFileName, cpointer unfoundType_LPOFSTRUCT_lpReOpenBuf, short wStyle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int LZOpenFileA(byte* lpFileName, cpointer unfoundType_LPOFSTRUCT_lpReOpenBuf, short wStyle);
    [DllImport("kernel32", EntryPoint="LZOpenFileW", SetLastError=true, ExactSpelling=true)] public static extern
        int LZOpenFile(string lpFileName, cpointer unfoundType_LPOFSTRUCT_lpReOpenBuf, short wStyle);
    [DllImport("kernel32", EntryPoint="LZOpenFileW", SetLastError=true, ExactSpelling=true)] public static extern
        int LZOpenFile(char* lpFileName, cpointer unfoundType_LPOFSTRUCT_lpReOpenBuf, short wStyle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int LZOpenFileW(string lpFileName, cpointer unfoundType_LPOFSTRUCT_lpReOpenBuf, short wStyle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int LZOpenFileW(char* lpFileName, cpointer unfoundType_LPOFSTRUCT_lpReOpenBuf, short wStyle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int LZSeek(int hFile, int lOffset, int iOrigin);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int LZRead(int hFile, cpointer lpBuffer, int cbRead);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void LZClose(int hFile);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FlsAlloc(cpointer unfoundType_PFLS_CALLBACK_FUNCTION_lpCallback);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FlsGetValue(int dwFlsIndex);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FlsSetValue(int dwFlsIndex, cpointer lpFlsData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FlsFree(int dwFlsIndex);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsThreadAFiber();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CompareFileTime(cpointer unfoundType_FILETIME_lpFileTime1, cpointer unfoundType_FILETIME_lpFileTime2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateDirectoryA(cpointer unfoundType_LPCSTR_lpPathName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport("kernel32", EntryPoint="CreateDirectoryW", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateDirectory([MarshalAs(UnmanagedType.LPWStr)] string lpPathName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport("kernel32", EntryPoint="CreateDirectoryW", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateDirectory(char* lpPathName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateDirectoryW([MarshalAs(UnmanagedType.LPWStr)] string lpPathName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateDirectoryW(char* lpPathName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateFileA(cpointer unfoundType_LPCSTR_lpFileName, int dwDesiredAccess, int dwShareMode, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, cpointer hTemplateFile);
    [DllImport("kernel32", EntryPoint="CreateFileW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateFile([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwDesiredAccess, int dwShareMode, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, cpointer hTemplateFile);
    [DllImport("kernel32", EntryPoint="CreateFileW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateFile(char* lpFileName, int dwDesiredAccess, int dwShareMode, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, cpointer hTemplateFile);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateFileW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwDesiredAccess, int dwShareMode, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, cpointer hTemplateFile);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateFileW(char* lpFileName, int dwDesiredAccess, int dwShareMode, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, cpointer hTemplateFile);
    [DllImport("kernel32", EntryPoint="DefineDosDeviceW", SetLastError=true, ExactSpelling=true)] public static extern
        int DefineDosDevice(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpDeviceName, [MarshalAs(UnmanagedType.LPWStr)] string lpTargetPath);
    [DllImport("kernel32", EntryPoint="DefineDosDeviceW", SetLastError=true, ExactSpelling=true)] public static extern
        int DefineDosDevice(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpDeviceName, char* lpTargetPath);
    [DllImport("kernel32", EntryPoint="DefineDosDeviceW", SetLastError=true, ExactSpelling=true)] public static extern
        int DefineDosDevice(int dwFlags, char* lpDeviceName, [MarshalAs(UnmanagedType.LPWStr)] string lpTargetPath);
    [DllImport("kernel32", EntryPoint="DefineDosDeviceW", SetLastError=true, ExactSpelling=true)] public static extern
        int DefineDosDevice(int dwFlags, char* lpDeviceName, char* lpTargetPath);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DefineDosDeviceW(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpDeviceName, [MarshalAs(UnmanagedType.LPWStr)] string lpTargetPath);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DefineDosDeviceW(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpDeviceName, char* lpTargetPath);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DefineDosDeviceW(int dwFlags, char* lpDeviceName, [MarshalAs(UnmanagedType.LPWStr)] string lpTargetPath);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DefineDosDeviceW(int dwFlags, char* lpDeviceName, char* lpTargetPath);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DeleteFileA(cpointer unfoundType_LPCSTR_lpFileName);
    [DllImport("kernel32", EntryPoint="DeleteFileW", SetLastError=true, ExactSpelling=true)] public static extern
        int DeleteFile([MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", EntryPoint="DeleteFileW", SetLastError=true, ExactSpelling=true)] public static extern
        int DeleteFile(char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DeleteFileW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DeleteFileW(char* lpFileName);
    [DllImport("kernel32", EntryPoint="DeleteVolumeMountPointW", SetLastError=true, ExactSpelling=true)] public static extern
        int DeleteVolumeMountPoint([MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeMountPoint);
    [DllImport("kernel32", EntryPoint="DeleteVolumeMountPointW", SetLastError=true, ExactSpelling=true)] public static extern
        int DeleteVolumeMountPoint(char* lpszVolumeMountPoint);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DeleteVolumeMountPointW([MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeMountPoint);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DeleteVolumeMountPointW(char* lpszVolumeMountPoint);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FileTimeToLocalFileTime(cpointer unfoundType_FILETIME_lpFileTime, cpointer unfoundType_LPFILETIME_lpLocalFileTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindClose(cpointer hFindFile);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindCloseChangeNotification(cpointer hChangeHandle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstChangeNotificationA(cpointer unfoundType_LPCSTR_lpPathName, int bWatchSubtree, int dwNotifyFilter);
    [DllImport("kernel32", EntryPoint="FindFirstChangeNotificationW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstChangeNotification([MarshalAs(UnmanagedType.LPWStr)] string lpPathName, int bWatchSubtree, int dwNotifyFilter);
    [DllImport("kernel32", EntryPoint="FindFirstChangeNotificationW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstChangeNotification(char* lpPathName, int bWatchSubtree, int dwNotifyFilter);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstChangeNotificationW([MarshalAs(UnmanagedType.LPWStr)] string lpPathName, int bWatchSubtree, int dwNotifyFilter);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstChangeNotificationW(char* lpPathName, int bWatchSubtree, int dwNotifyFilter);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstFileA(cpointer unfoundType_LPCSTR_lpFileName, cpointer unfoundType_LPWIN32_FIND_DATAA_lpFindFileData);
    [DllImport("kernel32", EntryPoint="FindFirstFileW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstFile([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, cpointer unfoundType_LPWIN32_FIND_DATAW_lpFindFileData);
    [DllImport("kernel32", EntryPoint="FindFirstFileW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstFile(char* lpFileName, cpointer unfoundType_LPWIN32_FIND_DATAW_lpFindFileData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstFileW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, cpointer unfoundType_LPWIN32_FIND_DATAW_lpFindFileData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstFileW(char* lpFileName, cpointer unfoundType_LPWIN32_FIND_DATAW_lpFindFileData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstFileExA(cpointer unfoundType_LPCSTR_lpFileName, cpointer unfoundType_FINDEX_INFO_LEVELS_fInfoLevelId, cpointer lpFindFileData, cpointer unfoundType_FINDEX_SEARCH_OPS_fSearchOp, cpointer lpSearchFilter, int dwAdditionalFlags);
    [DllImport("kernel32", EntryPoint="FindFirstFileExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstFileEx([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, cpointer unfoundType_FINDEX_INFO_LEVELS_fInfoLevelId, cpointer lpFindFileData, cpointer unfoundType_FINDEX_SEARCH_OPS_fSearchOp, cpointer lpSearchFilter, int dwAdditionalFlags);
    [DllImport("kernel32", EntryPoint="FindFirstFileExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstFileEx(char* lpFileName, cpointer unfoundType_FINDEX_INFO_LEVELS_fInfoLevelId, cpointer lpFindFileData, cpointer unfoundType_FINDEX_SEARCH_OPS_fSearchOp, cpointer lpSearchFilter, int dwAdditionalFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstFileExW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, cpointer unfoundType_FINDEX_INFO_LEVELS_fInfoLevelId, cpointer lpFindFileData, cpointer unfoundType_FINDEX_SEARCH_OPS_fSearchOp, cpointer lpSearchFilter, int dwAdditionalFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstFileExW(char* lpFileName, cpointer unfoundType_FINDEX_INFO_LEVELS_fInfoLevelId, cpointer lpFindFileData, cpointer unfoundType_FINDEX_SEARCH_OPS_fSearchOp, cpointer lpSearchFilter, int dwAdditionalFlags);
    [DllImport("kernel32", EntryPoint="FindFirstVolumeW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstVolume(string lpszVolumeName, int cchBufferLength);
    [DllImport("kernel32", EntryPoint="FindFirstVolumeW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstVolume(char* lpszVolumeName, int cchBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstVolumeW(string lpszVolumeName, int cchBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstVolumeW(char* lpszVolumeName, int cchBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindNextChangeNotification(cpointer hChangeHandle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindNextFileA(cpointer hFindFile, cpointer unfoundType_LPWIN32_FIND_DATAA_lpFindFileData);
    [DllImport("kernel32", EntryPoint="FindNextFileW", SetLastError=true, ExactSpelling=true)] public static extern
        int FindNextFile(cpointer hFindFile, cpointer unfoundType_LPWIN32_FIND_DATAW_lpFindFileData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindNextFileW(cpointer hFindFile, cpointer unfoundType_LPWIN32_FIND_DATAW_lpFindFileData);
    [DllImport("kernel32", EntryPoint="FindNextVolumeW", SetLastError=true, ExactSpelling=true)] public static extern
        int FindNextVolume(cpointer hFindVolume, string lpszVolumeName, int cchBufferLength);
    [DllImport("kernel32", EntryPoint="FindNextVolumeW", SetLastError=true, ExactSpelling=true)] public static extern
        int FindNextVolume(cpointer hFindVolume, char* lpszVolumeName, int cchBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindNextVolumeW(cpointer hFindVolume, string lpszVolumeName, int cchBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindNextVolumeW(cpointer hFindVolume, char* lpszVolumeName, int cchBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindVolumeClose(cpointer hFindVolume);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FlushFileBuffers(cpointer hFile);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDiskFreeSpaceA(cpointer unfoundType_LPCSTR_lpRootPathName, cpointer unfoundType_LPDWORD_lpSectorsPerCluster, cpointer unfoundType_LPDWORD_lpBytesPerSector, cpointer unfoundType_LPDWORD_lpNumberOfFreeClusters, cpointer unfoundType_LPDWORD_lpTotalNumberOfClusters);
    [DllImport("kernel32", EntryPoint="GetDiskFreeSpaceW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDiskFreeSpace([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, cpointer unfoundType_LPDWORD_lpSectorsPerCluster, cpointer unfoundType_LPDWORD_lpBytesPerSector, cpointer unfoundType_LPDWORD_lpNumberOfFreeClusters, cpointer unfoundType_LPDWORD_lpTotalNumberOfClusters);
    [DllImport("kernel32", EntryPoint="GetDiskFreeSpaceW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDiskFreeSpace(char* lpRootPathName, cpointer unfoundType_LPDWORD_lpSectorsPerCluster, cpointer unfoundType_LPDWORD_lpBytesPerSector, cpointer unfoundType_LPDWORD_lpNumberOfFreeClusters, cpointer unfoundType_LPDWORD_lpTotalNumberOfClusters);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDiskFreeSpaceW([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, cpointer unfoundType_LPDWORD_lpSectorsPerCluster, cpointer unfoundType_LPDWORD_lpBytesPerSector, cpointer unfoundType_LPDWORD_lpNumberOfFreeClusters, cpointer unfoundType_LPDWORD_lpTotalNumberOfClusters);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDiskFreeSpaceW(char* lpRootPathName, cpointer unfoundType_LPDWORD_lpSectorsPerCluster, cpointer unfoundType_LPDWORD_lpBytesPerSector, cpointer unfoundType_LPDWORD_lpNumberOfFreeClusters, cpointer unfoundType_LPDWORD_lpTotalNumberOfClusters);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDiskFreeSpaceExA(cpointer unfoundType_LPCSTR_lpDirectoryName, cpointer unfoundType_PULARGE_INTEGER_lpFreeBytesAvailableToCaller, cpointer unfoundType_PULARGE_INTEGER_lpTotalNumberOfBytes, cpointer unfoundType_PULARGE_INTEGER_lpTotalNumberOfFreeBytes);
    [DllImport("kernel32", EntryPoint="GetDiskFreeSpaceExW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDiskFreeSpaceEx([MarshalAs(UnmanagedType.LPWStr)] string lpDirectoryName, cpointer unfoundType_PULARGE_INTEGER_lpFreeBytesAvailableToCaller, cpointer unfoundType_PULARGE_INTEGER_lpTotalNumberOfBytes, cpointer unfoundType_PULARGE_INTEGER_lpTotalNumberOfFreeBytes);
    [DllImport("kernel32", EntryPoint="GetDiskFreeSpaceExW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDiskFreeSpaceEx(char* lpDirectoryName, cpointer unfoundType_PULARGE_INTEGER_lpFreeBytesAvailableToCaller, cpointer unfoundType_PULARGE_INTEGER_lpTotalNumberOfBytes, cpointer unfoundType_PULARGE_INTEGER_lpTotalNumberOfFreeBytes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDiskFreeSpaceExW([MarshalAs(UnmanagedType.LPWStr)] string lpDirectoryName, cpointer unfoundType_PULARGE_INTEGER_lpFreeBytesAvailableToCaller, cpointer unfoundType_PULARGE_INTEGER_lpTotalNumberOfBytes, cpointer unfoundType_PULARGE_INTEGER_lpTotalNumberOfFreeBytes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDiskFreeSpaceExW(char* lpDirectoryName, cpointer unfoundType_PULARGE_INTEGER_lpFreeBytesAvailableToCaller, cpointer unfoundType_PULARGE_INTEGER_lpTotalNumberOfBytes, cpointer unfoundType_PULARGE_INTEGER_lpTotalNumberOfFreeBytes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetDiskSpaceInformationA(cpointer unfoundType_LPCSTR_rootPath, cpointer unfoundType_DISK_SPACE_INFORMATION_diskSpaceInfo);
    [DllImport("kernel32", EntryPoint="GetDiskSpaceInformationW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetDiskSpaceInformation([MarshalAs(UnmanagedType.LPWStr)] string rootPath, cpointer unfoundType_DISK_SPACE_INFORMATION_diskSpaceInfo);
    [DllImport("kernel32", EntryPoint="GetDiskSpaceInformationW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetDiskSpaceInformation(char* rootPath, cpointer unfoundType_DISK_SPACE_INFORMATION_diskSpaceInfo);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetDiskSpaceInformationW([MarshalAs(UnmanagedType.LPWStr)] string rootPath, cpointer unfoundType_DISK_SPACE_INFORMATION_diskSpaceInfo);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetDiskSpaceInformationW(char* rootPath, cpointer unfoundType_DISK_SPACE_INFORMATION_diskSpaceInfo);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetDriveTypeA(cpointer unfoundType_LPCSTR_lpRootPathName);
    [DllImport("kernel32", EntryPoint="GetDriveTypeW", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetDriveType([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName);
    [DllImport("kernel32", EntryPoint="GetDriveTypeW", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetDriveType(char* lpRootPathName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetDriveTypeW([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetDriveTypeW(char* lpRootPathName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFileAttributesA(cpointer unfoundType_LPCSTR_lpFileName);
    [DllImport("kernel32", EntryPoint="GetFileAttributesW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFileAttributes([MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", EntryPoint="GetFileAttributesW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFileAttributes(char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFileAttributesW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFileAttributesW(char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFileAttributesExA(cpointer unfoundType_LPCSTR_lpFileName, cpointer unfoundType_GET_FILEEX_INFO_LEVELS_fInfoLevelId, cpointer lpFileInformation);
    [DllImport("kernel32", EntryPoint="GetFileAttributesExW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFileAttributesEx([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, cpointer unfoundType_GET_FILEEX_INFO_LEVELS_fInfoLevelId, cpointer lpFileInformation);
    [DllImport("kernel32", EntryPoint="GetFileAttributesExW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFileAttributesEx(char* lpFileName, cpointer unfoundType_GET_FILEEX_INFO_LEVELS_fInfoLevelId, cpointer lpFileInformation);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFileAttributesExW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, cpointer unfoundType_GET_FILEEX_INFO_LEVELS_fInfoLevelId, cpointer lpFileInformation);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFileAttributesExW(char* lpFileName, cpointer unfoundType_GET_FILEEX_INFO_LEVELS_fInfoLevelId, cpointer lpFileInformation);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFileInformationByHandle(cpointer hFile, cpointer unfoundType_LPBY_HANDLE_FILE_INFORMATION_lpFileInformation);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFileSize(cpointer hFile, cpointer unfoundType_LPDWORD_lpFileSizeHigh);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFileSizeEx(cpointer hFile, cpointer unfoundType_PLARGE_INTEGER_lpFileSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFileType(cpointer hFile);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFinalPathNameByHandleA(cpointer hFile, [MarshalAs(UnmanagedType.LPStr)] string lpszFilePath, int cchFilePath, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFinalPathNameByHandleA(cpointer hFile, ReadOnlySpan<byte> lpszFilePath, int cchFilePath, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFinalPathNameByHandleA(cpointer hFile, byte* lpszFilePath, int cchFilePath, int dwFlags);
    [DllImport("kernel32", EntryPoint="GetFinalPathNameByHandleW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFinalPathNameByHandle(cpointer hFile, string lpszFilePath, int cchFilePath, int dwFlags);
    [DllImport("kernel32", EntryPoint="GetFinalPathNameByHandleW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFinalPathNameByHandle(cpointer hFile, char* lpszFilePath, int cchFilePath, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFinalPathNameByHandleW(cpointer hFile, string lpszFilePath, int cchFilePath, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFinalPathNameByHandleW(cpointer hFile, char* lpszFilePath, int cchFilePath, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFileTime(cpointer hFile, cpointer unfoundType_LPFILETIME_lpCreationTime, cpointer unfoundType_LPFILETIME_lpLastAccessTime, cpointer unfoundType_LPFILETIME_lpLastWriteTime);
    [DllImport("kernel32", EntryPoint="GetFullPathNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFullPathName([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int nBufferLength, string lpBuffer, string lpFilePart);
    [DllImport("kernel32", EntryPoint="GetFullPathNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFullPathName([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int nBufferLength, string lpBuffer, char** lpFilePart);
    [DllImport("kernel32", EntryPoint="GetFullPathNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFullPathName([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int nBufferLength, char* lpBuffer, string lpFilePart);
    [DllImport("kernel32", EntryPoint="GetFullPathNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFullPathName([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int nBufferLength, char* lpBuffer, char** lpFilePart);
    [DllImport("kernel32", EntryPoint="GetFullPathNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFullPathName(char* lpFileName, int nBufferLength, string lpBuffer, string lpFilePart);
    [DllImport("kernel32", EntryPoint="GetFullPathNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFullPathName(char* lpFileName, int nBufferLength, string lpBuffer, char** lpFilePart);
    [DllImport("kernel32", EntryPoint="GetFullPathNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFullPathName(char* lpFileName, int nBufferLength, char* lpBuffer, string lpFilePart);
    [DllImport("kernel32", EntryPoint="GetFullPathNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFullPathName(char* lpFileName, int nBufferLength, char* lpBuffer, char** lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFullPathNameW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int nBufferLength, string lpBuffer, string lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFullPathNameW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int nBufferLength, string lpBuffer, char** lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFullPathNameW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int nBufferLength, char* lpBuffer, string lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFullPathNameW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int nBufferLength, char* lpBuffer, char** lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFullPathNameW(char* lpFileName, int nBufferLength, string lpBuffer, string lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFullPathNameW(char* lpFileName, int nBufferLength, string lpBuffer, char** lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFullPathNameW(char* lpFileName, int nBufferLength, char* lpBuffer, string lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFullPathNameW(char* lpFileName, int nBufferLength, char* lpBuffer, char** lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFullPathNameA(cpointer unfoundType_LPCSTR_lpFileName, int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, [MarshalAs(UnmanagedType.LPStr)] string lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFullPathNameA(cpointer unfoundType_LPCSTR_lpFileName, int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, ReadOnlySpan<byte> lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFullPathNameA(cpointer unfoundType_LPCSTR_lpFileName, int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, byte** lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFullPathNameA(cpointer unfoundType_LPCSTR_lpFileName, int nBufferLength, ReadOnlySpan<byte> lpBuffer, [MarshalAs(UnmanagedType.LPStr)] string lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFullPathNameA(cpointer unfoundType_LPCSTR_lpFileName, int nBufferLength, ReadOnlySpan<byte> lpBuffer, ReadOnlySpan<byte> lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFullPathNameA(cpointer unfoundType_LPCSTR_lpFileName, int nBufferLength, ReadOnlySpan<byte> lpBuffer, byte** lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFullPathNameA(cpointer unfoundType_LPCSTR_lpFileName, int nBufferLength, byte* lpBuffer, [MarshalAs(UnmanagedType.LPStr)] string lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFullPathNameA(cpointer unfoundType_LPCSTR_lpFileName, int nBufferLength, byte* lpBuffer, ReadOnlySpan<byte> lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFullPathNameA(cpointer unfoundType_LPCSTR_lpFileName, int nBufferLength, byte* lpBuffer, byte** lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLogicalDrives();
    [DllImport("kernel32", EntryPoint="GetLogicalDriveStringsW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLogicalDriveStrings(int nBufferLength, string lpBuffer);
    [DllImport("kernel32", EntryPoint="GetLogicalDriveStringsW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLogicalDriveStrings(int nBufferLength, char* lpBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLogicalDriveStringsW(int nBufferLength, string lpBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLogicalDriveStringsW(int nBufferLength, char* lpBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLongPathNameA(cpointer unfoundType_LPCSTR_lpszShortPath, [MarshalAs(UnmanagedType.LPStr)] string lpszLongPath, int cchBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLongPathNameA(cpointer unfoundType_LPCSTR_lpszShortPath, ReadOnlySpan<byte> lpszLongPath, int cchBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLongPathNameA(cpointer unfoundType_LPCSTR_lpszShortPath, byte* lpszLongPath, int cchBuffer);
    [DllImport("kernel32", EntryPoint="GetLongPathNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLongPathName([MarshalAs(UnmanagedType.LPWStr)] string lpszShortPath, string lpszLongPath, int cchBuffer);
    [DllImport("kernel32", EntryPoint="GetLongPathNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLongPathName([MarshalAs(UnmanagedType.LPWStr)] string lpszShortPath, char* lpszLongPath, int cchBuffer);
    [DllImport("kernel32", EntryPoint="GetLongPathNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLongPathName(char* lpszShortPath, string lpszLongPath, int cchBuffer);
    [DllImport("kernel32", EntryPoint="GetLongPathNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLongPathName(char* lpszShortPath, char* lpszLongPath, int cchBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLongPathNameW([MarshalAs(UnmanagedType.LPWStr)] string lpszShortPath, string lpszLongPath, int cchBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLongPathNameW([MarshalAs(UnmanagedType.LPWStr)] string lpszShortPath, char* lpszLongPath, int cchBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLongPathNameW(char* lpszShortPath, string lpszLongPath, int cchBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLongPathNameW(char* lpszShortPath, char* lpszLongPath, int cchBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AreShortNamesEnabled(cpointer Handle, cpointer Enabled);
    [DllImport("kernel32", EntryPoint="GetShortPathNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetShortPathName([MarshalAs(UnmanagedType.LPWStr)] string lpszLongPath, string lpszShortPath, int cchBuffer);
    [DllImport("kernel32", EntryPoint="GetShortPathNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetShortPathName([MarshalAs(UnmanagedType.LPWStr)] string lpszLongPath, char* lpszShortPath, int cchBuffer);
    [DllImport("kernel32", EntryPoint="GetShortPathNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetShortPathName(char* lpszLongPath, string lpszShortPath, int cchBuffer);
    [DllImport("kernel32", EntryPoint="GetShortPathNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetShortPathName(char* lpszLongPath, char* lpszShortPath, int cchBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetShortPathNameW([MarshalAs(UnmanagedType.LPWStr)] string lpszLongPath, string lpszShortPath, int cchBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetShortPathNameW([MarshalAs(UnmanagedType.LPWStr)] string lpszLongPath, char* lpszShortPath, int cchBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetShortPathNameW(char* lpszLongPath, string lpszShortPath, int cchBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetShortPathNameW(char* lpszLongPath, char* lpszShortPath, int cchBuffer);
    [DllImport("kernel32", EntryPoint="GetTempFileNameW", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetTempFileName([MarshalAs(UnmanagedType.LPWStr)] string lpPathName, [MarshalAs(UnmanagedType.LPWStr)] string lpPrefixString, uint uUnique, string lpTempFileName);
    [DllImport("kernel32", EntryPoint="GetTempFileNameW", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetTempFileName([MarshalAs(UnmanagedType.LPWStr)] string lpPathName, [MarshalAs(UnmanagedType.LPWStr)] string lpPrefixString, uint uUnique, char* lpTempFileName);
    [DllImport("kernel32", EntryPoint="GetTempFileNameW", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetTempFileName([MarshalAs(UnmanagedType.LPWStr)] string lpPathName, char* lpPrefixString, uint uUnique, string lpTempFileName);
    [DllImport("kernel32", EntryPoint="GetTempFileNameW", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetTempFileName([MarshalAs(UnmanagedType.LPWStr)] string lpPathName, char* lpPrefixString, uint uUnique, char* lpTempFileName);
    [DllImport("kernel32", EntryPoint="GetTempFileNameW", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetTempFileName(char* lpPathName, [MarshalAs(UnmanagedType.LPWStr)] string lpPrefixString, uint uUnique, string lpTempFileName);
    [DllImport("kernel32", EntryPoint="GetTempFileNameW", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetTempFileName(char* lpPathName, [MarshalAs(UnmanagedType.LPWStr)] string lpPrefixString, uint uUnique, char* lpTempFileName);
    [DllImport("kernel32", EntryPoint="GetTempFileNameW", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetTempFileName(char* lpPathName, char* lpPrefixString, uint uUnique, string lpTempFileName);
    [DllImport("kernel32", EntryPoint="GetTempFileNameW", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetTempFileName(char* lpPathName, char* lpPrefixString, uint uUnique, char* lpTempFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetTempFileNameW([MarshalAs(UnmanagedType.LPWStr)] string lpPathName, [MarshalAs(UnmanagedType.LPWStr)] string lpPrefixString, uint uUnique, string lpTempFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetTempFileNameW([MarshalAs(UnmanagedType.LPWStr)] string lpPathName, [MarshalAs(UnmanagedType.LPWStr)] string lpPrefixString, uint uUnique, char* lpTempFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetTempFileNameW([MarshalAs(UnmanagedType.LPWStr)] string lpPathName, char* lpPrefixString, uint uUnique, string lpTempFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetTempFileNameW([MarshalAs(UnmanagedType.LPWStr)] string lpPathName, char* lpPrefixString, uint uUnique, char* lpTempFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetTempFileNameW(char* lpPathName, [MarshalAs(UnmanagedType.LPWStr)] string lpPrefixString, uint uUnique, string lpTempFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetTempFileNameW(char* lpPathName, [MarshalAs(UnmanagedType.LPWStr)] string lpPrefixString, uint uUnique, char* lpTempFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetTempFileNameW(char* lpPathName, char* lpPrefixString, uint uUnique, string lpTempFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetTempFileNameW(char* lpPathName, char* lpPrefixString, uint uUnique, char* lpTempFileName);
    [DllImport("kernel32", EntryPoint="GetVolumeInformationByHandleW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeInformationByHandle(cpointer hFile, string lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport("kernel32", EntryPoint="GetVolumeInformationByHandleW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeInformationByHandle(cpointer hFile, string lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport("kernel32", EntryPoint="GetVolumeInformationByHandleW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeInformationByHandle(cpointer hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport("kernel32", EntryPoint="GetVolumeInformationByHandleW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeInformationByHandle(cpointer hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeInformationByHandleW(cpointer hFile, string lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeInformationByHandleW(cpointer hFile, string lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeInformationByHandleW(cpointer hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeInformationByHandleW(cpointer hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport("kernel32", EntryPoint="GetVolumeInformationW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeInformation([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, string lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport("kernel32", EntryPoint="GetVolumeInformationW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeInformation([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, string lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport("kernel32", EntryPoint="GetVolumeInformationW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeInformation([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport("kernel32", EntryPoint="GetVolumeInformationW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeInformation([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport("kernel32", EntryPoint="GetVolumeInformationW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeInformation(char* lpRootPathName, string lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport("kernel32", EntryPoint="GetVolumeInformationW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeInformation(char* lpRootPathName, string lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport("kernel32", EntryPoint="GetVolumeInformationW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeInformation(char* lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport("kernel32", EntryPoint="GetVolumeInformationW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeInformation(char* lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeInformationW([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, string lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeInformationW([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, string lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeInformationW([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeInformationW([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeInformationW(char* lpRootPathName, string lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeInformationW(char* lpRootPathName, string lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeInformationW(char* lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeInformationW(char* lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport("kernel32", EntryPoint="GetVolumePathNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumePathName([MarshalAs(UnmanagedType.LPWStr)] string lpszFileName, string lpszVolumePathName, int cchBufferLength);
    [DllImport("kernel32", EntryPoint="GetVolumePathNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumePathName([MarshalAs(UnmanagedType.LPWStr)] string lpszFileName, char* lpszVolumePathName, int cchBufferLength);
    [DllImport("kernel32", EntryPoint="GetVolumePathNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumePathName(char* lpszFileName, string lpszVolumePathName, int cchBufferLength);
    [DllImport("kernel32", EntryPoint="GetVolumePathNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumePathName(char* lpszFileName, char* lpszVolumePathName, int cchBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumePathNameW([MarshalAs(UnmanagedType.LPWStr)] string lpszFileName, string lpszVolumePathName, int cchBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumePathNameW([MarshalAs(UnmanagedType.LPWStr)] string lpszFileName, char* lpszVolumePathName, int cchBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumePathNameW(char* lpszFileName, string lpszVolumePathName, int cchBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumePathNameW(char* lpszFileName, char* lpszVolumePathName, int cchBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int LocalFileTimeToFileTime(cpointer unfoundType_FILETIME_lpLocalFileTime, cpointer unfoundType_LPFILETIME_lpFileTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int LockFile(cpointer hFile, int dwFileOffsetLow, int dwFileOffsetHigh, int nNumberOfBytesToLockLow, int nNumberOfBytesToLockHigh);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int LockFileEx(cpointer hFile, int dwFlags, int dwReserved, int nNumberOfBytesToLockLow, int nNumberOfBytesToLockHigh, cpointer unfoundType_LPOVERLAPPED_lpOverlapped);
    [DllImport("kernel32", EntryPoint="QueryDosDeviceW", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryDosDevice([MarshalAs(UnmanagedType.LPWStr)] string lpDeviceName, string lpTargetPath, int ucchMax);
    [DllImport("kernel32", EntryPoint="QueryDosDeviceW", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryDosDevice([MarshalAs(UnmanagedType.LPWStr)] string lpDeviceName, char* lpTargetPath, int ucchMax);
    [DllImport("kernel32", EntryPoint="QueryDosDeviceW", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryDosDevice(char* lpDeviceName, string lpTargetPath, int ucchMax);
    [DllImport("kernel32", EntryPoint="QueryDosDeviceW", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryDosDevice(char* lpDeviceName, char* lpTargetPath, int ucchMax);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryDosDeviceW([MarshalAs(UnmanagedType.LPWStr)] string lpDeviceName, string lpTargetPath, int ucchMax);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryDosDeviceW([MarshalAs(UnmanagedType.LPWStr)] string lpDeviceName, char* lpTargetPath, int ucchMax);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryDosDeviceW(char* lpDeviceName, string lpTargetPath, int ucchMax);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryDosDeviceW(char* lpDeviceName, char* lpTargetPath, int ucchMax);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ReadFile(cpointer hFile, cpointer lpBuffer, int nNumberOfBytesToRead, cpointer unfoundType_LPDWORD_lpNumberOfBytesRead, cpointer unfoundType_LPOVERLAPPED_lpOverlapped);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ReadFileEx(cpointer hFile, cpointer lpBuffer, int nNumberOfBytesToRead, cpointer unfoundType_LPOVERLAPPED_lpOverlapped, cpointer unfoundType_LPOVERLAPPED_COMPLETION_ROUTINE_lpCompletionRoutine);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ReadFileScatter(cpointer hFile, cpointer unfoundType_FILE_SEGMENT_ELEMENT_aSegmentArray, int nNumberOfBytesToRead, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPOVERLAPPED_lpOverlapped);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int RemoveDirectoryA(cpointer unfoundType_LPCSTR_lpPathName);
    [DllImport("kernel32", EntryPoint="RemoveDirectoryW", SetLastError=true, ExactSpelling=true)] public static extern
        int RemoveDirectory([MarshalAs(UnmanagedType.LPWStr)] string lpPathName);
    [DllImport("kernel32", EntryPoint="RemoveDirectoryW", SetLastError=true, ExactSpelling=true)] public static extern
        int RemoveDirectory(char* lpPathName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int RemoveDirectoryW([MarshalAs(UnmanagedType.LPWStr)] string lpPathName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int RemoveDirectoryW(char* lpPathName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetEndOfFile(cpointer hFile);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetFileAttributesA(cpointer unfoundType_LPCSTR_lpFileName, int dwFileAttributes);
    [DllImport("kernel32", EntryPoint="SetFileAttributesW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetFileAttributes([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwFileAttributes);
    [DllImport("kernel32", EntryPoint="SetFileAttributesW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetFileAttributes(char* lpFileName, int dwFileAttributes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetFileAttributesW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwFileAttributes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetFileAttributesW(char* lpFileName, int dwFileAttributes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetFileInformationByHandle(cpointer hFile, cpointer unfoundType_FILE_INFO_BY_HANDLE_CLASS_FileInformationClass, cpointer lpFileInformation, int dwBufferSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetFilePointer(cpointer hFile, int lDistanceToMove, cpointer lpDistanceToMoveHigh, int dwMoveMethod);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetFilePointerEx(cpointer hFile, cpointer unfoundType_LARGE_INTEGER_liDistanceToMove, cpointer unfoundType_PLARGE_INTEGER_lpNewFilePointer, int dwMoveMethod);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetFileTime(cpointer hFile, cpointer unfoundType_FILETIME_lpCreationTime, cpointer unfoundType_FILETIME_lpLastAccessTime, cpointer unfoundType_FILETIME_lpLastWriteTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetFileValidData(cpointer hFile, cpointer unfoundType_LONGLONG_ValidDataLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int UnlockFile(cpointer hFile, int dwFileOffsetLow, int dwFileOffsetHigh, int nNumberOfBytesToUnlockLow, int nNumberOfBytesToUnlockHigh);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int UnlockFileEx(cpointer hFile, int dwReserved, int nNumberOfBytesToUnlockLow, int nNumberOfBytesToUnlockHigh, cpointer unfoundType_LPOVERLAPPED_lpOverlapped);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteFile(cpointer hFile, cpointer lpBuffer, int nNumberOfBytesToWrite, cpointer unfoundType_LPDWORD_lpNumberOfBytesWritten, cpointer unfoundType_LPOVERLAPPED_lpOverlapped);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteFileEx(cpointer hFile, cpointer lpBuffer, int nNumberOfBytesToWrite, cpointer unfoundType_LPOVERLAPPED_lpOverlapped, cpointer unfoundType_LPOVERLAPPED_COMPLETION_ROUTINE_lpCompletionRoutine);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteFileGather(cpointer hFile, cpointer unfoundType_FILE_SEGMENT_ELEMENT_aSegmentArray, int nNumberOfBytesToWrite, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPOVERLAPPED_lpOverlapped);
    [DllImport("kernel32", EntryPoint="GetTempPathW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTempPath(int nBufferLength, string lpBuffer);
    [DllImport("kernel32", EntryPoint="GetTempPathW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTempPath(int nBufferLength, char* lpBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTempPathW(int nBufferLength, string lpBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTempPathW(int nBufferLength, char* lpBuffer);
    [DllImport("kernel32", EntryPoint="GetVolumeNameForVolumeMountPointW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeNameForVolumeMountPoint([MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeMountPoint, string lpszVolumeName, int cchBufferLength);
    [DllImport("kernel32", EntryPoint="GetVolumeNameForVolumeMountPointW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeNameForVolumeMountPoint([MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeMountPoint, char* lpszVolumeName, int cchBufferLength);
    [DllImport("kernel32", EntryPoint="GetVolumeNameForVolumeMountPointW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeNameForVolumeMountPoint(char* lpszVolumeMountPoint, string lpszVolumeName, int cchBufferLength);
    [DllImport("kernel32", EntryPoint="GetVolumeNameForVolumeMountPointW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeNameForVolumeMountPoint(char* lpszVolumeMountPoint, char* lpszVolumeName, int cchBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeNameForVolumeMountPointW([MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeMountPoint, string lpszVolumeName, int cchBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeNameForVolumeMountPointW([MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeMountPoint, char* lpszVolumeName, int cchBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeNameForVolumeMountPointW(char* lpszVolumeMountPoint, string lpszVolumeName, int cchBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeNameForVolumeMountPointW(char* lpszVolumeMountPoint, char* lpszVolumeName, int cchBufferLength);
    [DllImport("kernel32", EntryPoint="GetVolumePathNamesForVolumeNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumePathNamesForVolumeName([MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeName, string lpszVolumePathNames, int cchBufferLength, cpointer unfoundType_PDWORD_lpcchReturnLength);
    [DllImport("kernel32", EntryPoint="GetVolumePathNamesForVolumeNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumePathNamesForVolumeName([MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeName, char* lpszVolumePathNames, int cchBufferLength, cpointer unfoundType_PDWORD_lpcchReturnLength);
    [DllImport("kernel32", EntryPoint="GetVolumePathNamesForVolumeNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumePathNamesForVolumeName(char* lpszVolumeName, string lpszVolumePathNames, int cchBufferLength, cpointer unfoundType_PDWORD_lpcchReturnLength);
    [DllImport("kernel32", EntryPoint="GetVolumePathNamesForVolumeNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumePathNamesForVolumeName(char* lpszVolumeName, char* lpszVolumePathNames, int cchBufferLength, cpointer unfoundType_PDWORD_lpcchReturnLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumePathNamesForVolumeNameW([MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeName, string lpszVolumePathNames, int cchBufferLength, cpointer unfoundType_PDWORD_lpcchReturnLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumePathNamesForVolumeNameW([MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeName, char* lpszVolumePathNames, int cchBufferLength, cpointer unfoundType_PDWORD_lpcchReturnLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumePathNamesForVolumeNameW(char* lpszVolumeName, string lpszVolumePathNames, int cchBufferLength, cpointer unfoundType_PDWORD_lpcchReturnLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumePathNamesForVolumeNameW(char* lpszVolumeName, char* lpszVolumePathNames, int cchBufferLength, cpointer unfoundType_PDWORD_lpcchReturnLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateFile2([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwDesiredAccess, int dwShareMode, int dwCreationDisposition, cpointer unfoundType_LPCREATEFILE2_EXTENDED_PARAMETERS_pCreateExParams);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateFile2(char* lpFileName, int dwDesiredAccess, int dwShareMode, int dwCreationDisposition, cpointer unfoundType_LPCREATEFILE2_EXTENDED_PARAMETERS_pCreateExParams);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetFileIoOverlappedRange(cpointer FileHandle, cpointer unfoundType_PUCHAR_OverlappedRangeStart, uint Length);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCompressedFileSizeA(cpointer unfoundType_LPCSTR_lpFileName, cpointer unfoundType_LPDWORD_lpFileSizeHigh);
    [DllImport("kernel32", EntryPoint="GetCompressedFileSizeW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCompressedFileSize([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, cpointer unfoundType_LPDWORD_lpFileSizeHigh);
    [DllImport("kernel32", EntryPoint="GetCompressedFileSizeW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCompressedFileSize(char* lpFileName, cpointer unfoundType_LPDWORD_lpFileSizeHigh);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCompressedFileSizeW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, cpointer unfoundType_LPDWORD_lpFileSizeHigh);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCompressedFileSizeW(char* lpFileName, cpointer unfoundType_LPDWORD_lpFileSizeHigh);
    [DllImport("kernel32", EntryPoint="FindFirstStreamW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstStream([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, cpointer unfoundType_STREAM_INFO_LEVELS_InfoLevel, cpointer lpFindStreamData, int dwFlags);
    [DllImport("kernel32", EntryPoint="FindFirstStreamW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstStream(char* lpFileName, cpointer unfoundType_STREAM_INFO_LEVELS_InfoLevel, cpointer lpFindStreamData, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstStreamW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, cpointer unfoundType_STREAM_INFO_LEVELS_InfoLevel, cpointer lpFindStreamData, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstStreamW(char* lpFileName, cpointer unfoundType_STREAM_INFO_LEVELS_InfoLevel, cpointer lpFindStreamData, int dwFlags);
    [DllImport("kernel32", EntryPoint="FindNextStreamW", SetLastError=true, ExactSpelling=true)] public static extern
        int FindNextStream(cpointer hFindStream, cpointer lpFindStreamData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindNextStreamW(cpointer hFindStream, cpointer lpFindStreamData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AreFileApisANSI();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTempPathA(int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTempPathA(int nBufferLength, ReadOnlySpan<byte> lpBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTempPathA(int nBufferLength, byte* lpBuffer);
    [DllImport("kernel32", EntryPoint="FindFirstFileNameW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstFileName([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwFlags, cpointer unfoundType_LPDWORD_StringLength, [MarshalAs(UnmanagedType.LPWStr)] string LinkName);
    [DllImport("kernel32", EntryPoint="FindFirstFileNameW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstFileName([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwFlags, cpointer unfoundType_LPDWORD_StringLength, char* LinkName);
    [DllImport("kernel32", EntryPoint="FindFirstFileNameW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstFileName(char* lpFileName, int dwFlags, cpointer unfoundType_LPDWORD_StringLength, [MarshalAs(UnmanagedType.LPWStr)] string LinkName);
    [DllImport("kernel32", EntryPoint="FindFirstFileNameW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstFileName(char* lpFileName, int dwFlags, cpointer unfoundType_LPDWORD_StringLength, char* LinkName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstFileNameW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwFlags, cpointer unfoundType_LPDWORD_StringLength, [MarshalAs(UnmanagedType.LPWStr)] string LinkName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstFileNameW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwFlags, cpointer unfoundType_LPDWORD_StringLength, char* LinkName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstFileNameW(char* lpFileName, int dwFlags, cpointer unfoundType_LPDWORD_StringLength, [MarshalAs(UnmanagedType.LPWStr)] string LinkName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstFileNameW(char* lpFileName, int dwFlags, cpointer unfoundType_LPDWORD_StringLength, char* LinkName);
    [DllImport("kernel32", EntryPoint="FindNextFileNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int FindNextFileName(cpointer hFindStream, cpointer unfoundType_LPDWORD_StringLength, [MarshalAs(UnmanagedType.LPWStr)] string LinkName);
    [DllImport("kernel32", EntryPoint="FindNextFileNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int FindNextFileName(cpointer hFindStream, cpointer unfoundType_LPDWORD_StringLength, char* LinkName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindNextFileNameW(cpointer hFindStream, cpointer unfoundType_LPDWORD_StringLength, [MarshalAs(UnmanagedType.LPWStr)] string LinkName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindNextFileNameW(cpointer hFindStream, cpointer unfoundType_LPDWORD_StringLength, char* LinkName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeInformationA(cpointer unfoundType_LPCSTR_lpRootPathName, [MarshalAs(UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, [MarshalAs(UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeInformationA(cpointer unfoundType_LPCSTR_lpRootPathName, [MarshalAs(UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, ReadOnlySpan<byte> lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeInformationA(cpointer unfoundType_LPCSTR_lpRootPathName, [MarshalAs(UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeInformationA(cpointer unfoundType_LPCSTR_lpRootPathName, ReadOnlySpan<byte> lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, [MarshalAs(UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeInformationA(cpointer unfoundType_LPCSTR_lpRootPathName, ReadOnlySpan<byte> lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, ReadOnlySpan<byte> lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeInformationA(cpointer unfoundType_LPCSTR_lpRootPathName, ReadOnlySpan<byte> lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeInformationA(cpointer unfoundType_LPCSTR_lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, [MarshalAs(UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeInformationA(cpointer unfoundType_LPCSTR_lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, ReadOnlySpan<byte> lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeInformationA(cpointer unfoundType_LPCSTR_lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, cpointer unfoundType_LPDWORD_lpVolumeSerialNumber, cpointer unfoundType_LPDWORD_lpMaximumComponentLength, cpointer unfoundType_LPDWORD_lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetTempFileNameA(cpointer unfoundType_LPCSTR_lpPathName, cpointer unfoundType_LPCSTR_lpPrefixString, uint uUnique, [MarshalAs(UnmanagedType.LPStr)] string lpTempFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetTempFileNameA(cpointer unfoundType_LPCSTR_lpPathName, cpointer unfoundType_LPCSTR_lpPrefixString, uint uUnique, ReadOnlySpan<byte> lpTempFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetTempFileNameA(cpointer unfoundType_LPCSTR_lpPathName, cpointer unfoundType_LPCSTR_lpPrefixString, uint uUnique, byte* lpTempFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void SetFileApisToOEM();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void SetFileApisToANSI();
    [DllImport("kernel32", EntryPoint="GetTempPath2W", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTempPath2(int BufferLength, string Buffer);
    [DllImport("kernel32", EntryPoint="GetTempPath2W", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTempPath2(int BufferLength, char* Buffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTempPath2W(int BufferLength, string Buffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTempPath2W(int BufferLength, char* Buffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTempPath2A(int BufferLength, [MarshalAs(UnmanagedType.LPStr)] string Buffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTempPath2A(int BufferLength, ReadOnlySpan<byte> Buffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTempPath2A(int BufferLength, byte* Buffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrentPackageId(cpointer bufferLength, cpointer buffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrentPackageFullName(cpointer packageFullNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageFullName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrentPackageFullName(cpointer packageFullNameLength, char* packageFullName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrentPackageFamilyName(cpointer packageFamilyNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrentPackageFamilyName(cpointer packageFamilyNameLength, char* packageFamilyName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrentPackagePath(cpointer pathLength, [MarshalAs(UnmanagedType.LPWStr)] string path);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrentPackagePath(cpointer pathLength, char* path);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPackageId(cpointer hProcess, cpointer bufferLength, cpointer buffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPackageFullName(cpointer hProcess, cpointer packageFullNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageFullName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPackageFullName(cpointer hProcess, cpointer packageFullNameLength, char* packageFullName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPackageFamilyName(cpointer hProcess, cpointer packageFamilyNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPackageFamilyName(cpointer hProcess, cpointer packageFamilyNameLength, char* packageFamilyName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPackagePath(cpointer unfoundType_PACKAGE_ID_packageId, uint reserved, cpointer pathLength, [MarshalAs(UnmanagedType.LPWStr)] string path);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPackagePath(cpointer unfoundType_PACKAGE_ID_packageId, uint reserved, cpointer pathLength, char* path);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPackagePathByFullName([MarshalAs(UnmanagedType.LPWStr)] string packageFullName, cpointer pathLength, [MarshalAs(UnmanagedType.LPWStr)] string path);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPackagePathByFullName([MarshalAs(UnmanagedType.LPWStr)] string packageFullName, cpointer pathLength, char* path);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPackagePathByFullName(char* packageFullName, cpointer pathLength, [MarshalAs(UnmanagedType.LPWStr)] string path);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPackagePathByFullName(char* packageFullName, cpointer pathLength, char* path);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetStagedPackagePathByFullName([MarshalAs(UnmanagedType.LPWStr)] string packageFullName, cpointer pathLength, [MarshalAs(UnmanagedType.LPWStr)] string path);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetStagedPackagePathByFullName([MarshalAs(UnmanagedType.LPWStr)] string packageFullName, cpointer pathLength, char* path);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetStagedPackagePathByFullName(char* packageFullName, cpointer pathLength, [MarshalAs(UnmanagedType.LPWStr)] string path);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetStagedPackagePathByFullName(char* packageFullName, cpointer pathLength, char* path);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrentApplicationUserModelId(cpointer applicationUserModelIdLength, [MarshalAs(UnmanagedType.LPWStr)] string applicationUserModelId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrentApplicationUserModelId(cpointer applicationUserModelIdLength, char* applicationUserModelId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetApplicationUserModelId(cpointer hProcess, cpointer applicationUserModelIdLength, [MarshalAs(UnmanagedType.LPWStr)] string applicationUserModelId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetApplicationUserModelId(cpointer hProcess, cpointer applicationUserModelIdLength, char* applicationUserModelId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int PackageIdFromFullName([MarshalAs(UnmanagedType.LPWStr)] string packageFullName, uint flags, cpointer bufferLength, cpointer buffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int PackageIdFromFullName(char* packageFullName, uint flags, cpointer bufferLength, cpointer buffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int PackageFullNameFromId(cpointer unfoundType_PACKAGE_ID_packageId, cpointer packageFullNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageFullName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int PackageFullNameFromId(cpointer unfoundType_PACKAGE_ID_packageId, cpointer packageFullNameLength, char* packageFullName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int PackageFamilyNameFromId(cpointer unfoundType_PACKAGE_ID_packageId, cpointer packageFamilyNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int PackageFamilyNameFromId(cpointer unfoundType_PACKAGE_ID_packageId, cpointer packageFamilyNameLength, char* packageFamilyName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int PackageFamilyNameFromFullName([MarshalAs(UnmanagedType.LPWStr)] string packageFullName, cpointer packageFamilyNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int PackageFamilyNameFromFullName([MarshalAs(UnmanagedType.LPWStr)] string packageFullName, cpointer packageFamilyNameLength, char* packageFamilyName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int PackageFamilyNameFromFullName(char* packageFullName, cpointer packageFamilyNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int PackageFamilyNameFromFullName(char* packageFullName, cpointer packageFamilyNameLength, char* packageFamilyName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int PackageNameAndPublisherIdFromFamilyName([MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, cpointer packageNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageName, cpointer packagePublisherIdLength, [MarshalAs(UnmanagedType.LPWStr)] string packagePublisherId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int PackageNameAndPublisherIdFromFamilyName([MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, cpointer packageNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageName, cpointer packagePublisherIdLength, char* packagePublisherId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int PackageNameAndPublisherIdFromFamilyName([MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, cpointer packageNameLength, char* packageName, cpointer packagePublisherIdLength, [MarshalAs(UnmanagedType.LPWStr)] string packagePublisherId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int PackageNameAndPublisherIdFromFamilyName([MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, cpointer packageNameLength, char* packageName, cpointer packagePublisherIdLength, char* packagePublisherId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int PackageNameAndPublisherIdFromFamilyName(char* packageFamilyName, cpointer packageNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageName, cpointer packagePublisherIdLength, [MarshalAs(UnmanagedType.LPWStr)] string packagePublisherId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int PackageNameAndPublisherIdFromFamilyName(char* packageFamilyName, cpointer packageNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageName, cpointer packagePublisherIdLength, char* packagePublisherId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int PackageNameAndPublisherIdFromFamilyName(char* packageFamilyName, cpointer packageNameLength, char* packageName, cpointer packagePublisherIdLength, [MarshalAs(UnmanagedType.LPWStr)] string packagePublisherId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int PackageNameAndPublisherIdFromFamilyName(char* packageFamilyName, cpointer packageNameLength, char* packageName, cpointer packagePublisherIdLength, char* packagePublisherId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FormatApplicationUserModelId([MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, [MarshalAs(UnmanagedType.LPWStr)] string packageRelativeApplicationId, cpointer applicationUserModelIdLength, [MarshalAs(UnmanagedType.LPWStr)] string applicationUserModelId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FormatApplicationUserModelId([MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, [MarshalAs(UnmanagedType.LPWStr)] string packageRelativeApplicationId, cpointer applicationUserModelIdLength, char* applicationUserModelId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FormatApplicationUserModelId([MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, char* packageRelativeApplicationId, cpointer applicationUserModelIdLength, [MarshalAs(UnmanagedType.LPWStr)] string applicationUserModelId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FormatApplicationUserModelId([MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, char* packageRelativeApplicationId, cpointer applicationUserModelIdLength, char* applicationUserModelId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FormatApplicationUserModelId(char* packageFamilyName, [MarshalAs(UnmanagedType.LPWStr)] string packageRelativeApplicationId, cpointer applicationUserModelIdLength, [MarshalAs(UnmanagedType.LPWStr)] string applicationUserModelId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FormatApplicationUserModelId(char* packageFamilyName, [MarshalAs(UnmanagedType.LPWStr)] string packageRelativeApplicationId, cpointer applicationUserModelIdLength, char* applicationUserModelId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FormatApplicationUserModelId(char* packageFamilyName, char* packageRelativeApplicationId, cpointer applicationUserModelIdLength, [MarshalAs(UnmanagedType.LPWStr)] string applicationUserModelId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FormatApplicationUserModelId(char* packageFamilyName, char* packageRelativeApplicationId, cpointer applicationUserModelIdLength, char* applicationUserModelId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ParseApplicationUserModelId([MarshalAs(UnmanagedType.LPWStr)] string applicationUserModelId, cpointer packageFamilyNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, cpointer packageRelativeApplicationIdLength, [MarshalAs(UnmanagedType.LPWStr)] string packageRelativeApplicationId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ParseApplicationUserModelId([MarshalAs(UnmanagedType.LPWStr)] string applicationUserModelId, cpointer packageFamilyNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, cpointer packageRelativeApplicationIdLength, char* packageRelativeApplicationId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ParseApplicationUserModelId([MarshalAs(UnmanagedType.LPWStr)] string applicationUserModelId, cpointer packageFamilyNameLength, char* packageFamilyName, cpointer packageRelativeApplicationIdLength, [MarshalAs(UnmanagedType.LPWStr)] string packageRelativeApplicationId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ParseApplicationUserModelId([MarshalAs(UnmanagedType.LPWStr)] string applicationUserModelId, cpointer packageFamilyNameLength, char* packageFamilyName, cpointer packageRelativeApplicationIdLength, char* packageRelativeApplicationId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ParseApplicationUserModelId(char* applicationUserModelId, cpointer packageFamilyNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, cpointer packageRelativeApplicationIdLength, [MarshalAs(UnmanagedType.LPWStr)] string packageRelativeApplicationId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ParseApplicationUserModelId(char* applicationUserModelId, cpointer packageFamilyNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, cpointer packageRelativeApplicationIdLength, char* packageRelativeApplicationId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ParseApplicationUserModelId(char* applicationUserModelId, cpointer packageFamilyNameLength, char* packageFamilyName, cpointer packageRelativeApplicationIdLength, [MarshalAs(UnmanagedType.LPWStr)] string packageRelativeApplicationId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ParseApplicationUserModelId(char* applicationUserModelId, cpointer packageFamilyNameLength, char* packageFamilyName, cpointer packageRelativeApplicationIdLength, char* packageRelativeApplicationId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPackagesByPackageFamily([MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, cpointer count, [MarshalAs(UnmanagedType.LPWStr)] string packageFullNames, cpointer bufferLength, cpointer buffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPackagesByPackageFamily([MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, cpointer count, char** packageFullNames, cpointer bufferLength, cpointer buffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPackagesByPackageFamily(char* packageFamilyName, cpointer count, [MarshalAs(UnmanagedType.LPWStr)] string packageFullNames, cpointer bufferLength, cpointer buffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPackagesByPackageFamily(char* packageFamilyName, cpointer count, char** packageFullNames, cpointer bufferLength, cpointer buffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindPackagesByPackageFamily([MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, uint packageFilters, cpointer count, [MarshalAs(UnmanagedType.LPWStr)] string packageFullNames, cpointer bufferLength, cpointer buffer, cpointer packageProperties);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindPackagesByPackageFamily([MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, uint packageFilters, cpointer count, char** packageFullNames, cpointer bufferLength, cpointer buffer, cpointer packageProperties);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindPackagesByPackageFamily(char* packageFamilyName, uint packageFilters, cpointer count, [MarshalAs(UnmanagedType.LPWStr)] string packageFullNames, cpointer bufferLength, cpointer buffer, cpointer packageProperties);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindPackagesByPackageFamily(char* packageFamilyName, uint packageFilters, cpointer count, char** packageFullNames, cpointer bufferLength, cpointer buffer, cpointer packageProperties);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrentPackageInfo(uint flags, cpointer bufferLength, cpointer buffer, cpointer count);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int OpenPackageInfoByFullName([MarshalAs(UnmanagedType.LPWStr)] string packageFullName, uint reserved, cpointer unfoundType_PACKAGE_INFO_REFERENCE_packageInfoReference);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int OpenPackageInfoByFullName(char* packageFullName, uint reserved, cpointer unfoundType_PACKAGE_INFO_REFERENCE_packageInfoReference);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ClosePackageInfo(cpointer unfoundType_PACKAGE_INFO_REFERENCE_packageInfoReference);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPackageInfo(cpointer unfoundType_PACKAGE_INFO_REFERENCE_packageInfoReference, uint flags, cpointer bufferLength, cpointer buffer, cpointer count);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPackageApplicationIds(cpointer unfoundType_PACKAGE_INFO_REFERENCE_packageInfoReference, cpointer bufferLength, cpointer buffer, cpointer count);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AppPolicyGetLifecycleManagement(cpointer processToken, cpointer unfoundType_AppPolicyLifecycleManagement_policy);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AppPolicyGetWindowingModel(cpointer processToken, cpointer unfoundType_AppPolicyWindowingModel_policy);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AppPolicyGetMediaFoundationCodecLoading(cpointer processToken, cpointer unfoundType_AppPolicyMediaFoundationCodecLoading_policy);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AppPolicyGetClrCompat(cpointer processToken, cpointer unfoundType_AppPolicyClrCompat_policy);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AppPolicyGetThreadInitializationType(cpointer processToken, cpointer unfoundType_AppPolicyThreadInitializationType_policy);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AppPolicyGetShowDeveloperDiagnostic(cpointer processToken, cpointer unfoundType_AppPolicyShowDeveloperDiagnostic_policy);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AppPolicyGetProcessTerminationMethod(cpointer processToken, cpointer unfoundType_AppPolicyProcessTerminationMethod_policy);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AppPolicyGetCreateFileAccess(cpointer processToken, cpointer unfoundType_AppPolicyCreateFileAccess_policy);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ClearCommBreak(cpointer hFile);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ClearCommError(cpointer hFile, cpointer unfoundType_LPDWORD_lpErrors, cpointer unfoundType_LPCOMSTAT_lpStat);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetupComm(cpointer hFile, int dwInQueue, int dwOutQueue);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EscapeCommFunction(cpointer hFile, int dwFunc);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCommConfig(cpointer hCommDev, cpointer unfoundType_LPCOMMCONFIG_lpCC, cpointer unfoundType_LPDWORD_lpdwSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCommMask(cpointer hFile, cpointer unfoundType_LPDWORD_lpEvtMask);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCommModemStatus(cpointer hFile, cpointer unfoundType_LPDWORD_lpModemStat);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCommProperties(cpointer hFile, cpointer unfoundType_LPCOMMPROP_lpCommProp);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCommState(cpointer hFile, cpointer unfoundType_LPDCB_lpDCB);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCommTimeouts(cpointer hFile, cpointer unfoundType_LPCOMMTIMEOUTS_lpCommTimeouts);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int PurgeComm(cpointer hFile, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetCommBreak(cpointer hFile);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetCommConfig(cpointer hCommDev, cpointer unfoundType_LPCOMMCONFIG_lpCC, int dwSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetCommMask(cpointer hFile, int dwEvtMask);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetCommState(cpointer hFile, cpointer unfoundType_LPDCB_lpDCB);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetCommTimeouts(cpointer hFile, cpointer unfoundType_LPCOMMTIMEOUTS_lpCommTimeouts);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int TransmitCommChar(cpointer hFile, byte cChar);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WaitCommEvent(cpointer hFile, cpointer unfoundType_LPDWORD_lpEvtMask, cpointer unfoundType_LPOVERLAPPED_lpOverlapped);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDateFormatA(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, cpointer unfoundType_LPCSTR_lpFormat, [MarshalAs(UnmanagedType.LPStr)] string lpDateStr, int cchDate);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDateFormatA(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, cpointer unfoundType_LPCSTR_lpFormat, ReadOnlySpan<byte> lpDateStr, int cchDate);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDateFormatA(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, cpointer unfoundType_LPCSTR_lpFormat, byte* lpDateStr, int cchDate);
    [DllImport("kernel32", EntryPoint="GetDateFormatW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDateFormat(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, string lpDateStr, int cchDate);
    [DllImport("kernel32", EntryPoint="GetDateFormatW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDateFormat(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, char* lpDateStr, int cchDate);
    [DllImport("kernel32", EntryPoint="GetDateFormatW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDateFormat(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, char* lpFormat, string lpDateStr, int cchDate);
    [DllImport("kernel32", EntryPoint="GetDateFormatW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDateFormat(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, char* lpFormat, char* lpDateStr, int cchDate);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDateFormatW(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, string lpDateStr, int cchDate);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDateFormatW(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, char* lpDateStr, int cchDate);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDateFormatW(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, char* lpFormat, string lpDateStr, int cchDate);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDateFormatW(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, char* lpFormat, char* lpDateStr, int cchDate);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTimeFormatA(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpTime, cpointer unfoundType_LPCSTR_lpFormat, [MarshalAs(UnmanagedType.LPStr)] string lpTimeStr, int cchTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTimeFormatA(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpTime, cpointer unfoundType_LPCSTR_lpFormat, ReadOnlySpan<byte> lpTimeStr, int cchTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTimeFormatA(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpTime, cpointer unfoundType_LPCSTR_lpFormat, byte* lpTimeStr, int cchTime);
    [DllImport("kernel32", EntryPoint="GetTimeFormatW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTimeFormat(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpTime, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, string lpTimeStr, int cchTime);
    [DllImport("kernel32", EntryPoint="GetTimeFormatW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTimeFormat(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpTime, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, char* lpTimeStr, int cchTime);
    [DllImport("kernel32", EntryPoint="GetTimeFormatW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTimeFormat(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpTime, char* lpFormat, string lpTimeStr, int cchTime);
    [DllImport("kernel32", EntryPoint="GetTimeFormatW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTimeFormat(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpTime, char* lpFormat, char* lpTimeStr, int cchTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTimeFormatW(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpTime, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, string lpTimeStr, int cchTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTimeFormatW(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpTime, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, char* lpTimeStr, int cchTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTimeFormatW(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpTime, char* lpFormat, string lpTimeStr, int cchTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTimeFormatW(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpTime, char* lpFormat, char* lpTimeStr, int cchTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTimeFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpTime, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, string lpTimeStr, int cchTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTimeFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpTime, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, char* lpTimeStr, int cchTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTimeFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpTime, char* lpFormat, string lpTimeStr, int cchTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTimeFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpTime, char* lpFormat, char* lpTimeStr, int cchTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTimeFormatEx(char* lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpTime, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, string lpTimeStr, int cchTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTimeFormatEx(char* lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpTime, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, char* lpTimeStr, int cchTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTimeFormatEx(char* lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpTime, char* lpFormat, string lpTimeStr, int cchTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTimeFormatEx(char* lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpTime, char* lpFormat, char* lpTimeStr, int cchTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDateFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, string lpDateStr, int cchDate, [MarshalAs(UnmanagedType.LPWStr)] string lpCalendar);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDateFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, string lpDateStr, int cchDate, char* lpCalendar);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDateFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, char* lpDateStr, int cchDate, [MarshalAs(UnmanagedType.LPWStr)] string lpCalendar);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDateFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, char* lpDateStr, int cchDate, char* lpCalendar);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDateFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, char* lpFormat, string lpDateStr, int cchDate, [MarshalAs(UnmanagedType.LPWStr)] string lpCalendar);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDateFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, char* lpFormat, string lpDateStr, int cchDate, char* lpCalendar);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDateFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, char* lpFormat, char* lpDateStr, int cchDate, [MarshalAs(UnmanagedType.LPWStr)] string lpCalendar);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDateFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, char* lpFormat, char* lpDateStr, int cchDate, char* lpCalendar);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDateFormatEx(char* lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, string lpDateStr, int cchDate, [MarshalAs(UnmanagedType.LPWStr)] string lpCalendar);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDateFormatEx(char* lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, string lpDateStr, int cchDate, char* lpCalendar);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDateFormatEx(char* lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, char* lpDateStr, int cchDate, [MarshalAs(UnmanagedType.LPWStr)] string lpCalendar);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDateFormatEx(char* lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, char* lpDateStr, int cchDate, char* lpCalendar);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDateFormatEx(char* lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, char* lpFormat, string lpDateStr, int cchDate, [MarshalAs(UnmanagedType.LPWStr)] string lpCalendar);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDateFormatEx(char* lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, char* lpFormat, string lpDateStr, int cchDate, char* lpCalendar);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDateFormatEx(char* lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, char* lpFormat, char* lpDateStr, int cchDate, [MarshalAs(UnmanagedType.LPWStr)] string lpCalendar);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDateFormatEx(char* lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDate, char* lpFormat, char* lpDateStr, int cchDate, char* lpCalendar);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDurationFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDuration, cpointer unfoundType_ULONGLONG_ullDuration, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, string lpDurationStr, int cchDuration);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDurationFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDuration, cpointer unfoundType_ULONGLONG_ullDuration, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, char* lpDurationStr, int cchDuration);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDurationFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDuration, cpointer unfoundType_ULONGLONG_ullDuration, char* lpFormat, string lpDurationStr, int cchDuration);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDurationFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDuration, cpointer unfoundType_ULONGLONG_ullDuration, char* lpFormat, char* lpDurationStr, int cchDuration);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDurationFormatEx(char* lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDuration, cpointer unfoundType_ULONGLONG_ullDuration, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, string lpDurationStr, int cchDuration);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDurationFormatEx(char* lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDuration, cpointer unfoundType_ULONGLONG_ullDuration, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, char* lpDurationStr, int cchDuration);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDurationFormatEx(char* lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDuration, cpointer unfoundType_ULONGLONG_ullDuration, char* lpFormat, string lpDurationStr, int cchDuration);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDurationFormatEx(char* lpLocaleName, int dwFlags, cpointer unfoundType_SYSTEMTIME_lpDuration, cpointer unfoundType_ULONGLONG_ullDuration, char* lpFormat, char* lpDurationStr, int cchDuration);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AllocConsole();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FreeConsole();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AttachConsole(int dwProcessId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetConsoleCP();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetConsoleOutputCP();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleMode(cpointer hConsoleHandle, cpointer unfoundType_LPDWORD_lpMode);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetConsoleMode(cpointer hConsoleHandle, int dwMode);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNumberOfConsoleInputEvents(cpointer hConsoleInput, cpointer unfoundType_LPDWORD_lpNumberOfEvents);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ReadConsoleInputA(cpointer hConsoleInput, cpointer unfoundType_PINPUT_RECORD_lpBuffer, int nLength, cpointer unfoundType_LPDWORD_lpNumberOfEventsRead);
    [DllImport("kernel32", EntryPoint="ReadConsoleInputW", SetLastError=true, ExactSpelling=true)] public static extern
        int ReadConsoleInput(cpointer hConsoleInput, cpointer unfoundType_PINPUT_RECORD_lpBuffer, int nLength, cpointer unfoundType_LPDWORD_lpNumberOfEventsRead);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ReadConsoleInputW(cpointer hConsoleInput, cpointer unfoundType_PINPUT_RECORD_lpBuffer, int nLength, cpointer unfoundType_LPDWORD_lpNumberOfEventsRead);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int PeekConsoleInputA(cpointer hConsoleInput, cpointer unfoundType_PINPUT_RECORD_lpBuffer, int nLength, cpointer unfoundType_LPDWORD_lpNumberOfEventsRead);
    [DllImport("kernel32", EntryPoint="PeekConsoleInputW", SetLastError=true, ExactSpelling=true)] public static extern
        int PeekConsoleInput(cpointer hConsoleInput, cpointer unfoundType_PINPUT_RECORD_lpBuffer, int nLength, cpointer unfoundType_LPDWORD_lpNumberOfEventsRead);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int PeekConsoleInputW(cpointer hConsoleInput, cpointer unfoundType_PINPUT_RECORD_lpBuffer, int nLength, cpointer unfoundType_LPDWORD_lpNumberOfEventsRead);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ReadConsoleA(cpointer hConsoleInput, cpointer lpBuffer, int nNumberOfCharsToRead, cpointer unfoundType_LPDWORD_lpNumberOfCharsRead, cpointer unfoundType_PCONSOLE_READCONSOLE_CONTROL_pInputControl);
    [DllImport("kernel32", EntryPoint="ReadConsoleW", SetLastError=true, ExactSpelling=true)] public static extern
        int ReadConsole(cpointer hConsoleInput, cpointer lpBuffer, int nNumberOfCharsToRead, cpointer unfoundType_LPDWORD_lpNumberOfCharsRead, cpointer unfoundType_PCONSOLE_READCONSOLE_CONTROL_pInputControl);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ReadConsoleW(cpointer hConsoleInput, cpointer lpBuffer, int nNumberOfCharsToRead, cpointer unfoundType_LPDWORD_lpNumberOfCharsRead, cpointer unfoundType_PCONSOLE_READCONSOLE_CONTROL_pInputControl);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteConsoleA(cpointer hConsoleOutput, cpointer lpBuffer, int nNumberOfCharsToWrite, cpointer unfoundType_LPDWORD_lpNumberOfCharsWritten, cpointer lpReserved);
    [DllImport("kernel32", EntryPoint="WriteConsoleW", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteConsole(cpointer hConsoleOutput, cpointer lpBuffer, int nNumberOfCharsToWrite, cpointer unfoundType_LPDWORD_lpNumberOfCharsWritten, cpointer lpReserved);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteConsoleW(cpointer hConsoleOutput, cpointer lpBuffer, int nNumberOfCharsToWrite, cpointer unfoundType_LPDWORD_lpNumberOfCharsWritten, cpointer lpReserved);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetConsoleCtrlHandler(cpointer unfoundType_PHANDLER_ROUTINE_HandlerRoutine, int Add);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreatePseudoConsole(cpointer unfoundType_COORD_size, cpointer hInput, cpointer hOutput, int dwFlags, cpointer unfoundType_HPCON_phPC);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer ResizePseudoConsole(cpointer unfoundType_HPCON_hPC, cpointer unfoundType_COORD_size);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void ClosePseudoConsole(cpointer unfoundType_HPCON_hPC);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FillConsoleOutputCharacterA(cpointer hConsoleOutput, byte cCharacter, int nLength, cpointer unfoundType_COORD_dwWriteCoord, cpointer unfoundType_LPDWORD_lpNumberOfCharsWritten);
    [DllImport("kernel32", EntryPoint="FillConsoleOutputCharacterW", SetLastError=true, ExactSpelling=true)] public static extern
        int FillConsoleOutputCharacter(cpointer hConsoleOutput, char cCharacter, int nLength, cpointer unfoundType_COORD_dwWriteCoord, cpointer unfoundType_LPDWORD_lpNumberOfCharsWritten);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FillConsoleOutputCharacterW(cpointer hConsoleOutput, char cCharacter, int nLength, cpointer unfoundType_COORD_dwWriteCoord, cpointer unfoundType_LPDWORD_lpNumberOfCharsWritten);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FillConsoleOutputAttribute(cpointer hConsoleOutput, short wAttribute, int nLength, cpointer unfoundType_COORD_dwWriteCoord, cpointer unfoundType_LPDWORD_lpNumberOfAttrsWritten);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GenerateConsoleCtrlEvent(int dwCtrlEvent, int dwProcessGroupId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateConsoleScreenBuffer(int dwDesiredAccess, int dwShareMode, cpointer unfoundType_SECURITY_ATTRIBUTES_lpSecurityAttributes, int dwFlags, cpointer lpScreenBufferData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetConsoleActiveScreenBuffer(cpointer hConsoleOutput);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FlushConsoleInputBuffer(cpointer hConsoleInput);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetConsoleCP(uint wCodePageID);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetConsoleOutputCP(uint wCodePageID);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleCursorInfo(cpointer hConsoleOutput, cpointer unfoundType_PCONSOLE_CURSOR_INFO_lpConsoleCursorInfo);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetConsoleCursorInfo(cpointer hConsoleOutput, cpointer unfoundType_CONSOLE_CURSOR_INFO_lpConsoleCursorInfo);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleScreenBufferInfo(cpointer hConsoleOutput, cpointer unfoundType_PCONSOLE_SCREEN_BUFFER_INFO_lpConsoleScreenBufferInfo);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleScreenBufferInfoEx(cpointer hConsoleOutput, cpointer unfoundType_PCONSOLE_SCREEN_BUFFER_INFOEX_lpConsoleScreenBufferInfoEx);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetConsoleScreenBufferInfoEx(cpointer hConsoleOutput, cpointer unfoundType_PCONSOLE_SCREEN_BUFFER_INFOEX_lpConsoleScreenBufferInfoEx);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetConsoleScreenBufferSize(cpointer hConsoleOutput, cpointer unfoundType_COORD_dwSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetConsoleCursorPosition(cpointer hConsoleOutput, cpointer unfoundType_COORD_dwCursorPosition);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetLargestConsoleWindowSize(cpointer hConsoleOutput);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetConsoleTextAttribute(cpointer hConsoleOutput, short wAttributes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetConsoleWindowInfo(cpointer hConsoleOutput, int bAbsolute, cpointer unfoundType_SMALL_RECT_lpConsoleWindow);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteConsoleOutputCharacterA(cpointer hConsoleOutput, cpointer unfoundType_LPCSTR_lpCharacter, int nLength, cpointer unfoundType_COORD_dwWriteCoord, cpointer unfoundType_LPDWORD_lpNumberOfCharsWritten);
    [DllImport("kernel32", EntryPoint="WriteConsoleOutputCharacterW", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteConsoleOutputCharacter(cpointer hConsoleOutput, [MarshalAs(UnmanagedType.LPWStr)] string lpCharacter, int nLength, cpointer unfoundType_COORD_dwWriteCoord, cpointer unfoundType_LPDWORD_lpNumberOfCharsWritten);
    [DllImport("kernel32", EntryPoint="WriteConsoleOutputCharacterW", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteConsoleOutputCharacter(cpointer hConsoleOutput, char* lpCharacter, int nLength, cpointer unfoundType_COORD_dwWriteCoord, cpointer unfoundType_LPDWORD_lpNumberOfCharsWritten);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteConsoleOutputCharacterW(cpointer hConsoleOutput, [MarshalAs(UnmanagedType.LPWStr)] string lpCharacter, int nLength, cpointer unfoundType_COORD_dwWriteCoord, cpointer unfoundType_LPDWORD_lpNumberOfCharsWritten);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteConsoleOutputCharacterW(cpointer hConsoleOutput, char* lpCharacter, int nLength, cpointer unfoundType_COORD_dwWriteCoord, cpointer unfoundType_LPDWORD_lpNumberOfCharsWritten);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteConsoleOutputAttribute(cpointer hConsoleOutput, cpointer lpAttribute, int nLength, cpointer unfoundType_COORD_dwWriteCoord, cpointer unfoundType_LPDWORD_lpNumberOfAttrsWritten);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ReadConsoleOutputCharacterA(cpointer hConsoleOutput, [MarshalAs(UnmanagedType.LPStr)] string lpCharacter, int nLength, cpointer unfoundType_COORD_dwReadCoord, cpointer unfoundType_LPDWORD_lpNumberOfCharsRead);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ReadConsoleOutputCharacterA(cpointer hConsoleOutput, ReadOnlySpan<byte> lpCharacter, int nLength, cpointer unfoundType_COORD_dwReadCoord, cpointer unfoundType_LPDWORD_lpNumberOfCharsRead);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ReadConsoleOutputCharacterA(cpointer hConsoleOutput, byte* lpCharacter, int nLength, cpointer unfoundType_COORD_dwReadCoord, cpointer unfoundType_LPDWORD_lpNumberOfCharsRead);
    [DllImport("kernel32", EntryPoint="ReadConsoleOutputCharacterW", SetLastError=true, ExactSpelling=true)] public static extern
        int ReadConsoleOutputCharacter(cpointer hConsoleOutput, string lpCharacter, int nLength, cpointer unfoundType_COORD_dwReadCoord, cpointer unfoundType_LPDWORD_lpNumberOfCharsRead);
    [DllImport("kernel32", EntryPoint="ReadConsoleOutputCharacterW", SetLastError=true, ExactSpelling=true)] public static extern
        int ReadConsoleOutputCharacter(cpointer hConsoleOutput, char* lpCharacter, int nLength, cpointer unfoundType_COORD_dwReadCoord, cpointer unfoundType_LPDWORD_lpNumberOfCharsRead);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ReadConsoleOutputCharacterW(cpointer hConsoleOutput, string lpCharacter, int nLength, cpointer unfoundType_COORD_dwReadCoord, cpointer unfoundType_LPDWORD_lpNumberOfCharsRead);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ReadConsoleOutputCharacterW(cpointer hConsoleOutput, char* lpCharacter, int nLength, cpointer unfoundType_COORD_dwReadCoord, cpointer unfoundType_LPDWORD_lpNumberOfCharsRead);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ReadConsoleOutputAttribute(cpointer hConsoleOutput, cpointer unfoundType_LPWORD_lpAttribute, int nLength, cpointer unfoundType_COORD_dwReadCoord, cpointer unfoundType_LPDWORD_lpNumberOfAttrsRead);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteConsoleInputA(cpointer hConsoleInput, cpointer unfoundType_INPUT_RECORD_lpBuffer, int nLength, cpointer unfoundType_LPDWORD_lpNumberOfEventsWritten);
    [DllImport("kernel32", EntryPoint="WriteConsoleInputW", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteConsoleInput(cpointer hConsoleInput, cpointer unfoundType_INPUT_RECORD_lpBuffer, int nLength, cpointer unfoundType_LPDWORD_lpNumberOfEventsWritten);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteConsoleInputW(cpointer hConsoleInput, cpointer unfoundType_INPUT_RECORD_lpBuffer, int nLength, cpointer unfoundType_LPDWORD_lpNumberOfEventsWritten);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ScrollConsoleScreenBufferA(cpointer hConsoleOutput, cpointer unfoundType_SMALL_RECT_lpScrollRectangle, cpointer unfoundType_SMALL_RECT_lpClipRectangle, cpointer unfoundType_COORD_dwDestinationOrigin, cpointer unfoundType_CHAR_INFO_lpFill);
    [DllImport("kernel32", EntryPoint="ScrollConsoleScreenBufferW", SetLastError=true, ExactSpelling=true)] public static extern
        int ScrollConsoleScreenBuffer(cpointer hConsoleOutput, cpointer unfoundType_SMALL_RECT_lpScrollRectangle, cpointer unfoundType_SMALL_RECT_lpClipRectangle, cpointer unfoundType_COORD_dwDestinationOrigin, cpointer unfoundType_CHAR_INFO_lpFill);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ScrollConsoleScreenBufferW(cpointer hConsoleOutput, cpointer unfoundType_SMALL_RECT_lpScrollRectangle, cpointer unfoundType_SMALL_RECT_lpClipRectangle, cpointer unfoundType_COORD_dwDestinationOrigin, cpointer unfoundType_CHAR_INFO_lpFill);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteConsoleOutputA(cpointer hConsoleOutput, cpointer unfoundType_CHAR_INFO_lpBuffer, cpointer unfoundType_COORD_dwBufferSize, cpointer unfoundType_COORD_dwBufferCoord, cpointer unfoundType_PSMALL_RECT_lpWriteRegion);
    [DllImport("kernel32", EntryPoint="WriteConsoleOutputW", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteConsoleOutput(cpointer hConsoleOutput, cpointer unfoundType_CHAR_INFO_lpBuffer, cpointer unfoundType_COORD_dwBufferSize, cpointer unfoundType_COORD_dwBufferCoord, cpointer unfoundType_PSMALL_RECT_lpWriteRegion);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteConsoleOutputW(cpointer hConsoleOutput, cpointer unfoundType_CHAR_INFO_lpBuffer, cpointer unfoundType_COORD_dwBufferSize, cpointer unfoundType_COORD_dwBufferCoord, cpointer unfoundType_PSMALL_RECT_lpWriteRegion);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ReadConsoleOutputA(cpointer hConsoleOutput, cpointer unfoundType_PCHAR_INFO_lpBuffer, cpointer unfoundType_COORD_dwBufferSize, cpointer unfoundType_COORD_dwBufferCoord, cpointer unfoundType_PSMALL_RECT_lpReadRegion);
    [DllImport("kernel32", EntryPoint="ReadConsoleOutputW", SetLastError=true, ExactSpelling=true)] public static extern
        int ReadConsoleOutput(cpointer hConsoleOutput, cpointer unfoundType_PCHAR_INFO_lpBuffer, cpointer unfoundType_COORD_dwBufferSize, cpointer unfoundType_COORD_dwBufferCoord, cpointer unfoundType_PSMALL_RECT_lpReadRegion);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ReadConsoleOutputW(cpointer hConsoleOutput, cpointer unfoundType_PCHAR_INFO_lpBuffer, cpointer unfoundType_COORD_dwBufferSize, cpointer unfoundType_COORD_dwBufferCoord, cpointer unfoundType_PSMALL_RECT_lpReadRegion);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleTitleA([MarshalAs(UnmanagedType.LPStr)] string lpConsoleTitle, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleTitleA(ReadOnlySpan<byte> lpConsoleTitle, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleTitleA(byte* lpConsoleTitle, int nSize);
    [DllImport("kernel32", EntryPoint="GetConsoleTitleW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleTitle(string lpConsoleTitle, int nSize);
    [DllImport("kernel32", EntryPoint="GetConsoleTitleW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleTitle(char* lpConsoleTitle, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleTitleW(string lpConsoleTitle, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleTitleW(char* lpConsoleTitle, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleOriginalTitleA([MarshalAs(UnmanagedType.LPStr)] string lpConsoleTitle, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleOriginalTitleA(ReadOnlySpan<byte> lpConsoleTitle, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleOriginalTitleA(byte* lpConsoleTitle, int nSize);
    [DllImport("kernel32", EntryPoint="GetConsoleOriginalTitleW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleOriginalTitle(string lpConsoleTitle, int nSize);
    [DllImport("kernel32", EntryPoint="GetConsoleOriginalTitleW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleOriginalTitle(char* lpConsoleTitle, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleOriginalTitleW(string lpConsoleTitle, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleOriginalTitleW(char* lpConsoleTitle, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetConsoleTitleA(cpointer unfoundType_LPCSTR_lpConsoleTitle);
    [DllImport("kernel32", EntryPoint="SetConsoleTitleW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetConsoleTitle([MarshalAs(UnmanagedType.LPWStr)] string lpConsoleTitle);
    [DllImport("kernel32", EntryPoint="SetConsoleTitleW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetConsoleTitle(char* lpConsoleTitle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetConsoleTitleW([MarshalAs(UnmanagedType.LPWStr)] string lpConsoleTitle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetConsoleTitleW(char* lpConsoleTitle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNumberOfConsoleMouseButtons(cpointer unfoundType_LPDWORD_lpNumberOfMouseButtons);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetConsoleFontSize(cpointer hConsoleOutput, int nFont);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrentConsoleFont(cpointer hConsoleOutput, int bMaximumWindow, cpointer unfoundType_PCONSOLE_FONT_INFO_lpConsoleCurrentFont);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrentConsoleFontEx(cpointer hConsoleOutput, int bMaximumWindow, cpointer unfoundType_PCONSOLE_FONT_INFOEX_lpConsoleCurrentFontEx);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetCurrentConsoleFontEx(cpointer hConsoleOutput, int bMaximumWindow, cpointer unfoundType_PCONSOLE_FONT_INFOEX_lpConsoleCurrentFontEx);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleSelectionInfo(cpointer unfoundType_PCONSOLE_SELECTION_INFO_lpConsoleSelectionInfo);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleHistoryInfo(cpointer unfoundType_PCONSOLE_HISTORY_INFO_lpConsoleHistoryInfo);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetConsoleHistoryInfo(cpointer unfoundType_PCONSOLE_HISTORY_INFO_lpConsoleHistoryInfo);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleDisplayMode(cpointer unfoundType_LPDWORD_lpModeFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetConsoleDisplayMode(cpointer hConsoleOutput, int dwFlags, cpointer unfoundType_PCOORD_lpNewScreenBufferDimensions);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetConsoleWindow();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAliasA([MarshalAs(UnmanagedType.LPStr)] string Source, [MarshalAs(UnmanagedType.LPStr)] string Target, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAliasA([MarshalAs(UnmanagedType.LPStr)] string Source, [MarshalAs(UnmanagedType.LPStr)] string Target, ReadOnlySpan<byte> ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAliasA([MarshalAs(UnmanagedType.LPStr)] string Source, [MarshalAs(UnmanagedType.LPStr)] string Target, byte* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAliasA([MarshalAs(UnmanagedType.LPStr)] string Source, ReadOnlySpan<byte> Target, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAliasA([MarshalAs(UnmanagedType.LPStr)] string Source, ReadOnlySpan<byte> Target, ReadOnlySpan<byte> ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAliasA([MarshalAs(UnmanagedType.LPStr)] string Source, ReadOnlySpan<byte> Target, byte* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAliasA([MarshalAs(UnmanagedType.LPStr)] string Source, byte* Target, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAliasA([MarshalAs(UnmanagedType.LPStr)] string Source, byte* Target, ReadOnlySpan<byte> ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAliasA([MarshalAs(UnmanagedType.LPStr)] string Source, byte* Target, byte* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAliasA(ReadOnlySpan<byte> Source, [MarshalAs(UnmanagedType.LPStr)] string Target, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAliasA(ReadOnlySpan<byte> Source, [MarshalAs(UnmanagedType.LPStr)] string Target, ReadOnlySpan<byte> ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAliasA(ReadOnlySpan<byte> Source, [MarshalAs(UnmanagedType.LPStr)] string Target, byte* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAliasA(ReadOnlySpan<byte> Source, ReadOnlySpan<byte> Target, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAliasA(ReadOnlySpan<byte> Source, ReadOnlySpan<byte> Target, ReadOnlySpan<byte> ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAliasA(ReadOnlySpan<byte> Source, ReadOnlySpan<byte> Target, byte* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAliasA(ReadOnlySpan<byte> Source, byte* Target, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAliasA(ReadOnlySpan<byte> Source, byte* Target, ReadOnlySpan<byte> ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAliasA(ReadOnlySpan<byte> Source, byte* Target, byte* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAliasA(byte* Source, [MarshalAs(UnmanagedType.LPStr)] string Target, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAliasA(byte* Source, [MarshalAs(UnmanagedType.LPStr)] string Target, ReadOnlySpan<byte> ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAliasA(byte* Source, [MarshalAs(UnmanagedType.LPStr)] string Target, byte* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAliasA(byte* Source, ReadOnlySpan<byte> Target, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAliasA(byte* Source, ReadOnlySpan<byte> Target, ReadOnlySpan<byte> ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAliasA(byte* Source, ReadOnlySpan<byte> Target, byte* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAliasA(byte* Source, byte* Target, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAliasA(byte* Source, byte* Target, ReadOnlySpan<byte> ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAliasA(byte* Source, byte* Target, byte* ExeName);
    [DllImport("kernel32", EntryPoint="AddConsoleAliasW", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAlias(string Source, string Target, string ExeName);
    [DllImport("kernel32", EntryPoint="AddConsoleAliasW", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAlias(string Source, string Target, char* ExeName);
    [DllImport("kernel32", EntryPoint="AddConsoleAliasW", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAlias(string Source, char* Target, string ExeName);
    [DllImport("kernel32", EntryPoint="AddConsoleAliasW", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAlias(string Source, char* Target, char* ExeName);
    [DllImport("kernel32", EntryPoint="AddConsoleAliasW", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAlias(char* Source, string Target, string ExeName);
    [DllImport("kernel32", EntryPoint="AddConsoleAliasW", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAlias(char* Source, string Target, char* ExeName);
    [DllImport("kernel32", EntryPoint="AddConsoleAliasW", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAlias(char* Source, char* Target, string ExeName);
    [DllImport("kernel32", EntryPoint="AddConsoleAliasW", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAlias(char* Source, char* Target, char* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAliasW(string Source, string Target, string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAliasW(string Source, string Target, char* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAliasW(string Source, char* Target, string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAliasW(string Source, char* Target, char* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAliasW(char* Source, string Target, string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAliasW(char* Source, string Target, char* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAliasW(char* Source, char* Target, string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AddConsoleAliasW(char* Source, char* Target, char* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasA([MarshalAs(UnmanagedType.LPStr)] string Source, [MarshalAs(UnmanagedType.LPStr)] string TargetBuffer, int TargetBufferLength, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasA([MarshalAs(UnmanagedType.LPStr)] string Source, [MarshalAs(UnmanagedType.LPStr)] string TargetBuffer, int TargetBufferLength, ReadOnlySpan<byte> ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasA([MarshalAs(UnmanagedType.LPStr)] string Source, [MarshalAs(UnmanagedType.LPStr)] string TargetBuffer, int TargetBufferLength, byte* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasA([MarshalAs(UnmanagedType.LPStr)] string Source, ReadOnlySpan<byte> TargetBuffer, int TargetBufferLength, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasA([MarshalAs(UnmanagedType.LPStr)] string Source, ReadOnlySpan<byte> TargetBuffer, int TargetBufferLength, ReadOnlySpan<byte> ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasA([MarshalAs(UnmanagedType.LPStr)] string Source, ReadOnlySpan<byte> TargetBuffer, int TargetBufferLength, byte* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasA([MarshalAs(UnmanagedType.LPStr)] string Source, byte* TargetBuffer, int TargetBufferLength, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasA([MarshalAs(UnmanagedType.LPStr)] string Source, byte* TargetBuffer, int TargetBufferLength, ReadOnlySpan<byte> ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasA([MarshalAs(UnmanagedType.LPStr)] string Source, byte* TargetBuffer, int TargetBufferLength, byte* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasA(ReadOnlySpan<byte> Source, [MarshalAs(UnmanagedType.LPStr)] string TargetBuffer, int TargetBufferLength, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasA(ReadOnlySpan<byte> Source, [MarshalAs(UnmanagedType.LPStr)] string TargetBuffer, int TargetBufferLength, ReadOnlySpan<byte> ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasA(ReadOnlySpan<byte> Source, [MarshalAs(UnmanagedType.LPStr)] string TargetBuffer, int TargetBufferLength, byte* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasA(ReadOnlySpan<byte> Source, ReadOnlySpan<byte> TargetBuffer, int TargetBufferLength, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasA(ReadOnlySpan<byte> Source, ReadOnlySpan<byte> TargetBuffer, int TargetBufferLength, ReadOnlySpan<byte> ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasA(ReadOnlySpan<byte> Source, ReadOnlySpan<byte> TargetBuffer, int TargetBufferLength, byte* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasA(ReadOnlySpan<byte> Source, byte* TargetBuffer, int TargetBufferLength, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasA(ReadOnlySpan<byte> Source, byte* TargetBuffer, int TargetBufferLength, ReadOnlySpan<byte> ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasA(ReadOnlySpan<byte> Source, byte* TargetBuffer, int TargetBufferLength, byte* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasA(byte* Source, [MarshalAs(UnmanagedType.LPStr)] string TargetBuffer, int TargetBufferLength, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasA(byte* Source, [MarshalAs(UnmanagedType.LPStr)] string TargetBuffer, int TargetBufferLength, ReadOnlySpan<byte> ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasA(byte* Source, [MarshalAs(UnmanagedType.LPStr)] string TargetBuffer, int TargetBufferLength, byte* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasA(byte* Source, ReadOnlySpan<byte> TargetBuffer, int TargetBufferLength, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasA(byte* Source, ReadOnlySpan<byte> TargetBuffer, int TargetBufferLength, ReadOnlySpan<byte> ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasA(byte* Source, ReadOnlySpan<byte> TargetBuffer, int TargetBufferLength, byte* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasA(byte* Source, byte* TargetBuffer, int TargetBufferLength, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasA(byte* Source, byte* TargetBuffer, int TargetBufferLength, ReadOnlySpan<byte> ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasA(byte* Source, byte* TargetBuffer, int TargetBufferLength, byte* ExeName);
    [DllImport("kernel32", EntryPoint="GetConsoleAliasW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAlias(string Source, string TargetBuffer, int TargetBufferLength, string ExeName);
    [DllImport("kernel32", EntryPoint="GetConsoleAliasW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAlias(string Source, string TargetBuffer, int TargetBufferLength, char* ExeName);
    [DllImport("kernel32", EntryPoint="GetConsoleAliasW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAlias(string Source, char* TargetBuffer, int TargetBufferLength, string ExeName);
    [DllImport("kernel32", EntryPoint="GetConsoleAliasW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAlias(string Source, char* TargetBuffer, int TargetBufferLength, char* ExeName);
    [DllImport("kernel32", EntryPoint="GetConsoleAliasW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAlias(char* Source, string TargetBuffer, int TargetBufferLength, string ExeName);
    [DllImport("kernel32", EntryPoint="GetConsoleAliasW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAlias(char* Source, string TargetBuffer, int TargetBufferLength, char* ExeName);
    [DllImport("kernel32", EntryPoint="GetConsoleAliasW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAlias(char* Source, char* TargetBuffer, int TargetBufferLength, string ExeName);
    [DllImport("kernel32", EntryPoint="GetConsoleAliasW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAlias(char* Source, char* TargetBuffer, int TargetBufferLength, char* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasW(string Source, string TargetBuffer, int TargetBufferLength, string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasW(string Source, string TargetBuffer, int TargetBufferLength, char* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasW(string Source, char* TargetBuffer, int TargetBufferLength, string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasW(string Source, char* TargetBuffer, int TargetBufferLength, char* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasW(char* Source, string TargetBuffer, int TargetBufferLength, string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasW(char* Source, string TargetBuffer, int TargetBufferLength, char* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasW(char* Source, char* TargetBuffer, int TargetBufferLength, string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasW(char* Source, char* TargetBuffer, int TargetBufferLength, char* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasesLengthA([MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasesLengthA(ReadOnlySpan<byte> ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasesLengthA(byte* ExeName);
    [DllImport("kernel32", EntryPoint="GetConsoleAliasesLengthW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasesLength(string ExeName);
    [DllImport("kernel32", EntryPoint="GetConsoleAliasesLengthW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasesLength(char* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasesLengthW(string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasesLengthW(char* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasExesLengthA();
    [DllImport("kernel32", EntryPoint="GetConsoleAliasExesLengthW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasExesLength();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasExesLengthW();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasesA([MarshalAs(UnmanagedType.LPStr)] string AliasBuffer, int AliasBufferLength, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasesA([MarshalAs(UnmanagedType.LPStr)] string AliasBuffer, int AliasBufferLength, ReadOnlySpan<byte> ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasesA([MarshalAs(UnmanagedType.LPStr)] string AliasBuffer, int AliasBufferLength, byte* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasesA(ReadOnlySpan<byte> AliasBuffer, int AliasBufferLength, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasesA(ReadOnlySpan<byte> AliasBuffer, int AliasBufferLength, ReadOnlySpan<byte> ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasesA(ReadOnlySpan<byte> AliasBuffer, int AliasBufferLength, byte* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasesA(byte* AliasBuffer, int AliasBufferLength, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasesA(byte* AliasBuffer, int AliasBufferLength, ReadOnlySpan<byte> ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasesA(byte* AliasBuffer, int AliasBufferLength, byte* ExeName);
    [DllImport("kernel32", EntryPoint="GetConsoleAliasesW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliases(string AliasBuffer, int AliasBufferLength, string ExeName);
    [DllImport("kernel32", EntryPoint="GetConsoleAliasesW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliases(string AliasBuffer, int AliasBufferLength, char* ExeName);
    [DllImport("kernel32", EntryPoint="GetConsoleAliasesW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliases(char* AliasBuffer, int AliasBufferLength, string ExeName);
    [DllImport("kernel32", EntryPoint="GetConsoleAliasesW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliases(char* AliasBuffer, int AliasBufferLength, char* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasesW(string AliasBuffer, int AliasBufferLength, string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasesW(string AliasBuffer, int AliasBufferLength, char* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasesW(char* AliasBuffer, int AliasBufferLength, string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasesW(char* AliasBuffer, int AliasBufferLength, char* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasExesA([MarshalAs(UnmanagedType.LPStr)] string ExeNameBuffer, int ExeNameBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasExesA(ReadOnlySpan<byte> ExeNameBuffer, int ExeNameBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasExesA(byte* ExeNameBuffer, int ExeNameBufferLength);
    [DllImport("kernel32", EntryPoint="GetConsoleAliasExesW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasExes(string ExeNameBuffer, int ExeNameBufferLength);
    [DllImport("kernel32", EntryPoint="GetConsoleAliasExesW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasExes(char* ExeNameBuffer, int ExeNameBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasExesW(string ExeNameBuffer, int ExeNameBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleAliasExesW(char* ExeNameBuffer, int ExeNameBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void ExpungeConsoleCommandHistoryA([MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void ExpungeConsoleCommandHistoryA(ReadOnlySpan<byte> ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void ExpungeConsoleCommandHistoryA(byte* ExeName);
    [DllImport("kernel32", EntryPoint="ExpungeConsoleCommandHistoryW", SetLastError=true, ExactSpelling=true)] public static extern
        void ExpungeConsoleCommandHistory(string ExeName);
    [DllImport("kernel32", EntryPoint="ExpungeConsoleCommandHistoryW", SetLastError=true, ExactSpelling=true)] public static extern
        void ExpungeConsoleCommandHistory(char* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void ExpungeConsoleCommandHistoryW(string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void ExpungeConsoleCommandHistoryW(char* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetConsoleNumberOfCommandsA(int Number, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetConsoleNumberOfCommandsA(int Number, ReadOnlySpan<byte> ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetConsoleNumberOfCommandsA(int Number, byte* ExeName);
    [DllImport("kernel32", EntryPoint="SetConsoleNumberOfCommandsW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetConsoleNumberOfCommands(int Number, string ExeName);
    [DllImport("kernel32", EntryPoint="SetConsoleNumberOfCommandsW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetConsoleNumberOfCommands(int Number, char* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetConsoleNumberOfCommandsW(int Number, string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetConsoleNumberOfCommandsW(int Number, char* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleCommandHistoryLengthA([MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleCommandHistoryLengthA(ReadOnlySpan<byte> ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleCommandHistoryLengthA(byte* ExeName);
    [DllImport("kernel32", EntryPoint="GetConsoleCommandHistoryLengthW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleCommandHistoryLength(string ExeName);
    [DllImport("kernel32", EntryPoint="GetConsoleCommandHistoryLengthW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleCommandHistoryLength(char* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleCommandHistoryLengthW(string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleCommandHistoryLengthW(char* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleCommandHistoryA([MarshalAs(UnmanagedType.LPStr)] string Commands, int CommandBufferLength, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleCommandHistoryA([MarshalAs(UnmanagedType.LPStr)] string Commands, int CommandBufferLength, ReadOnlySpan<byte> ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleCommandHistoryA([MarshalAs(UnmanagedType.LPStr)] string Commands, int CommandBufferLength, byte* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleCommandHistoryA(ReadOnlySpan<byte> Commands, int CommandBufferLength, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleCommandHistoryA(ReadOnlySpan<byte> Commands, int CommandBufferLength, ReadOnlySpan<byte> ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleCommandHistoryA(ReadOnlySpan<byte> Commands, int CommandBufferLength, byte* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleCommandHistoryA(byte* Commands, int CommandBufferLength, [MarshalAs(UnmanagedType.LPStr)] string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleCommandHistoryA(byte* Commands, int CommandBufferLength, ReadOnlySpan<byte> ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleCommandHistoryA(byte* Commands, int CommandBufferLength, byte* ExeName);
    [DllImport("kernel32", EntryPoint="GetConsoleCommandHistoryW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleCommandHistory(string Commands, int CommandBufferLength, string ExeName);
    [DllImport("kernel32", EntryPoint="GetConsoleCommandHistoryW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleCommandHistory(string Commands, int CommandBufferLength, char* ExeName);
    [DllImport("kernel32", EntryPoint="GetConsoleCommandHistoryW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleCommandHistory(char* Commands, int CommandBufferLength, string ExeName);
    [DllImport("kernel32", EntryPoint="GetConsoleCommandHistoryW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleCommandHistory(char* Commands, int CommandBufferLength, char* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleCommandHistoryW(string Commands, int CommandBufferLength, string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleCommandHistoryW(string Commands, int CommandBufferLength, char* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleCommandHistoryW(char* Commands, int CommandBufferLength, string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleCommandHistoryW(char* Commands, int CommandBufferLength, char* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetConsoleProcessList(cpointer unfoundType_LPDWORD_lpdwProcessList, int dwProcessCount);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreatePipe(cpointer unfoundType_PHANDLE_hReadPipe, cpointer unfoundType_PHANDLE_hWritePipe, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpPipeAttributes, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ConnectNamedPipe(cpointer hNamedPipe, cpointer unfoundType_LPOVERLAPPED_lpOverlapped);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DisconnectNamedPipe(cpointer hNamedPipe);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetNamedPipeHandleState(cpointer hNamedPipe, cpointer unfoundType_LPDWORD_lpMode, cpointer unfoundType_LPDWORD_lpMaxCollectionCount, cpointer unfoundType_LPDWORD_lpCollectDataTimeout);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int PeekNamedPipe(cpointer hNamedPipe, cpointer lpBuffer, int nBufferSize, cpointer unfoundType_LPDWORD_lpBytesRead, cpointer unfoundType_LPDWORD_lpTotalBytesAvail, cpointer unfoundType_LPDWORD_lpBytesLeftThisMessage);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int TransactNamedPipe(cpointer hNamedPipe, cpointer lpInBuffer, int nInBufferSize, cpointer lpOutBuffer, int nOutBufferSize, cpointer unfoundType_LPDWORD_lpBytesRead, cpointer unfoundType_LPOVERLAPPED_lpOverlapped);
    [DllImport("kernel32", EntryPoint="CreateNamedPipeW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateNamedPipe([MarshalAs(UnmanagedType.LPWStr)] string lpName, int dwOpenMode, int dwPipeMode, int nMaxInstances, int nOutBufferSize, int nInBufferSize, int nDefaultTimeOut, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport("kernel32", EntryPoint="CreateNamedPipeW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateNamedPipe(char* lpName, int dwOpenMode, int dwPipeMode, int nMaxInstances, int nOutBufferSize, int nInBufferSize, int nDefaultTimeOut, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateNamedPipeW([MarshalAs(UnmanagedType.LPWStr)] string lpName, int dwOpenMode, int dwPipeMode, int nMaxInstances, int nOutBufferSize, int nInBufferSize, int nDefaultTimeOut, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateNamedPipeW(char* lpName, int dwOpenMode, int dwPipeMode, int nMaxInstances, int nOutBufferSize, int nInBufferSize, int nDefaultTimeOut, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport("kernel32", EntryPoint="WaitNamedPipeW", SetLastError=true, ExactSpelling=true)] public static extern
        int WaitNamedPipe([MarshalAs(UnmanagedType.LPWStr)] string lpNamedPipeName, int nTimeOut);
    [DllImport("kernel32", EntryPoint="WaitNamedPipeW", SetLastError=true, ExactSpelling=true)] public static extern
        int WaitNamedPipe(char* lpNamedPipeName, int nTimeOut);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WaitNamedPipeW([MarshalAs(UnmanagedType.LPWStr)] string lpNamedPipeName, int nTimeOut);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WaitNamedPipeW(char* lpNamedPipeName, int nTimeOut);
    [DllImport("kernel32", EntryPoint="GetNamedPipeClientComputerNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNamedPipeClientComputerName(cpointer Pipe, string ClientComputerName, uint ClientComputerNameLength);
    [DllImport("kernel32", EntryPoint="GetNamedPipeClientComputerNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNamedPipeClientComputerName(cpointer Pipe, char* ClientComputerName, uint ClientComputerNameLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNamedPipeClientComputerNameW(cpointer Pipe, string ClientComputerName, uint ClientComputerNameLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNamedPipeClientComputerNameW(cpointer Pipe, char* ClientComputerName, uint ClientComputerNameLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNamedPipeInfo(cpointer hNamedPipe, cpointer unfoundType_LPDWORD_lpFlags, cpointer unfoundType_LPDWORD_lpOutBufferSize, cpointer unfoundType_LPDWORD_lpInBufferSize, cpointer unfoundType_LPDWORD_lpMaxInstances);
    [DllImport("kernel32", EntryPoint="GetNamedPipeHandleStateW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNamedPipeHandleState(cpointer hNamedPipe, cpointer unfoundType_LPDWORD_lpState, cpointer unfoundType_LPDWORD_lpCurInstances, cpointer unfoundType_LPDWORD_lpMaxCollectionCount, cpointer unfoundType_LPDWORD_lpCollectDataTimeout, string lpUserName, int nMaxUserNameSize);
    [DllImport("kernel32", EntryPoint="GetNamedPipeHandleStateW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNamedPipeHandleState(cpointer hNamedPipe, cpointer unfoundType_LPDWORD_lpState, cpointer unfoundType_LPDWORD_lpCurInstances, cpointer unfoundType_LPDWORD_lpMaxCollectionCount, cpointer unfoundType_LPDWORD_lpCollectDataTimeout, char* lpUserName, int nMaxUserNameSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNamedPipeHandleStateW(cpointer hNamedPipe, cpointer unfoundType_LPDWORD_lpState, cpointer unfoundType_LPDWORD_lpCurInstances, cpointer unfoundType_LPDWORD_lpMaxCollectionCount, cpointer unfoundType_LPDWORD_lpCollectDataTimeout, string lpUserName, int nMaxUserNameSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNamedPipeHandleStateW(cpointer hNamedPipe, cpointer unfoundType_LPDWORD_lpState, cpointer unfoundType_LPDWORD_lpCurInstances, cpointer unfoundType_LPDWORD_lpMaxCollectionCount, cpointer unfoundType_LPDWORD_lpCollectDataTimeout, char* lpUserName, int nMaxUserNameSize);
    [DllImport("kernel32", EntryPoint="CallNamedPipeW", SetLastError=true, ExactSpelling=true)] public static extern
        int CallNamedPipe([MarshalAs(UnmanagedType.LPWStr)] string lpNamedPipeName, cpointer lpInBuffer, int nInBufferSize, cpointer lpOutBuffer, int nOutBufferSize, cpointer unfoundType_LPDWORD_lpBytesRead, int nTimeOut);
    [DllImport("kernel32", EntryPoint="CallNamedPipeW", SetLastError=true, ExactSpelling=true)] public static extern
        int CallNamedPipe(char* lpNamedPipeName, cpointer lpInBuffer, int nInBufferSize, cpointer lpOutBuffer, int nOutBufferSize, cpointer unfoundType_LPDWORD_lpBytesRead, int nTimeOut);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CallNamedPipeW([MarshalAs(UnmanagedType.LPWStr)] string lpNamedPipeName, cpointer lpInBuffer, int nInBufferSize, cpointer lpOutBuffer, int nOutBufferSize, cpointer unfoundType_LPDWORD_lpBytesRead, int nTimeOut);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CallNamedPipeW(char* lpNamedPipeName, cpointer lpInBuffer, int nInBufferSize, cpointer lpOutBuffer, int nOutBufferSize, cpointer unfoundType_LPDWORD_lpBytesRead, int nTimeOut);
    [DllImport("kernel32", EntryPoint="CreatePrivateNamespaceW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreatePrivateNamespace(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpPrivateNamespaceAttributes, cpointer lpBoundaryDescriptor, [MarshalAs(UnmanagedType.LPWStr)] string lpAliasPrefix);
    [DllImport("kernel32", EntryPoint="CreatePrivateNamespaceW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreatePrivateNamespace(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpPrivateNamespaceAttributes, cpointer lpBoundaryDescriptor, char* lpAliasPrefix);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreatePrivateNamespaceW(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpPrivateNamespaceAttributes, cpointer lpBoundaryDescriptor, [MarshalAs(UnmanagedType.LPWStr)] string lpAliasPrefix);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreatePrivateNamespaceW(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpPrivateNamespaceAttributes, cpointer lpBoundaryDescriptor, char* lpAliasPrefix);
    [DllImport("kernel32", EntryPoint="OpenPrivateNamespaceW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenPrivateNamespace(cpointer lpBoundaryDescriptor, [MarshalAs(UnmanagedType.LPWStr)] string lpAliasPrefix);
    [DllImport("kernel32", EntryPoint="OpenPrivateNamespaceW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenPrivateNamespace(cpointer lpBoundaryDescriptor, char* lpAliasPrefix);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenPrivateNamespaceW(cpointer lpBoundaryDescriptor, [MarshalAs(UnmanagedType.LPWStr)] string lpAliasPrefix);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenPrivateNamespaceW(cpointer lpBoundaryDescriptor, char* lpAliasPrefix);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer ClosePrivateNamespace(cpointer Handle, uint Flags);
    [DllImport("kernel32", EntryPoint="CreateBoundaryDescriptorW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateBoundaryDescriptor([MarshalAs(UnmanagedType.LPWStr)] string Name, uint Flags);
    [DllImport("kernel32", EntryPoint="CreateBoundaryDescriptorW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateBoundaryDescriptor(char* Name, uint Flags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateBoundaryDescriptorW([MarshalAs(UnmanagedType.LPWStr)] string Name, uint Flags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateBoundaryDescriptorW(char* Name, uint Flags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AddSIDToBoundaryDescriptor(cpointer BoundaryDescriptor, cpointer unfoundType_PSID_RequiredSid);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void DeleteBoundaryDescriptor(cpointer BoundaryDescriptor);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreatePackageVirtualizationContext([MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, cpointer unfoundType_PACKAGE_VIRTUALIZATION_CONTEXT_HANDLE_context);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreatePackageVirtualizationContext(char* packageFamilyName, cpointer unfoundType_PACKAGE_VIRTUALIZATION_CONTEXT_HANDLE_context);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer ActivatePackageVirtualizationContext(cpointer unfoundType_PACKAGE_VIRTUALIZATION_CONTEXT_HANDLE_context, cpointer unfoundType_ULONG_PTR_cookie);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void ReleasePackageVirtualizationContext(cpointer unfoundType_PACKAGE_VIRTUALIZATION_CONTEXT_HANDLE_context);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void DeactivatePackageVirtualizationContext(cpointer unfoundType_ULONG_PTR_cookie);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer DuplicatePackageVirtualizationContext(cpointer unfoundType_PACKAGE_VIRTUALIZATION_CONTEXT_HANDLE_sourceContext, cpointer unfoundType_PACKAGE_VIRTUALIZATION_CONTEXT_HANDLE_destContext);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetCurrentPackageVirtualizationContext();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetProcessesInVirtualizationContext([MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, cpointer count, cpointer processes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetProcessesInVirtualizationContext(char* packageFamilyName, cpointer count, cpointer processes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsDebuggerPresent();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void DebugBreak();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void OutputDebugStringA(cpointer unfoundType_LPCSTR_lpOutputString);
    [DllImport("kernel32", EntryPoint="OutputDebugStringW", SetLastError=true, ExactSpelling=true)] public static extern
        void OutputDebugString([MarshalAs(UnmanagedType.LPWStr)] string lpOutputString);
    [DllImport("kernel32", EntryPoint="OutputDebugStringW", SetLastError=true, ExactSpelling=true)] public static extern
        void OutputDebugString(char* lpOutputString);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void OutputDebugStringW([MarshalAs(UnmanagedType.LPWStr)] string lpOutputString);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void OutputDebugStringW(char* lpOutputString);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ContinueDebugEvent(int dwProcessId, int dwThreadId, int dwContinueStatus);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WaitForDebugEvent(cpointer unfoundType_LPDEBUG_EVENT_lpDebugEvent, int dwMilliseconds);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DebugActiveProcess(int dwProcessId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DebugActiveProcessStop(int dwProcessId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CheckRemoteDebuggerPresent(cpointer hProcess, cpointer pbDebuggerPresent);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WaitForDebugEventEx(cpointer unfoundType_LPDEBUG_EVENT_lpDebugEvent, int dwMilliseconds);
    [DllImport("kernel32", EntryPoint="SetEnvironmentStringsW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetEnvironmentStrings(string NewEnvironment);
    [DllImport("kernel32", EntryPoint="SetEnvironmentStringsW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetEnvironmentStrings(char* NewEnvironment);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetEnvironmentStringsW(string NewEnvironment);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetEnvironmentStringsW(char* NewEnvironment);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetStdHandle(int nStdHandle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetStdHandle(int nStdHandle, cpointer hHandle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetStdHandleEx(int nStdHandle, cpointer hHandle, cpointer unfoundType_PHANDLE_phPrevValue);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        byte* GetCommandLineA_();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        ReadOnlySpan<byte> GetCommandLineA();
    [DllImport("kernel32", EntryPoint="GetCommandLineW", SetLastError=true, ExactSpelling=true)] public static extern
        char* GetCommandLine_();
    [DllImport("kernel32", EntryPoint="GetCommandLineW", SetLastError=true, ExactSpelling=true)] public static extern
        string GetCommandLine();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        char* GetCommandLineW_();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        string GetCommandLineW();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetEnvironmentStrings();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        char* GetEnvironmentStringsW_();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        string GetEnvironmentStringsW();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FreeEnvironmentStringsA(cpointer unfoundType_LPCH_penv);
    [DllImport("kernel32", EntryPoint="FreeEnvironmentStringsW", SetLastError=true, ExactSpelling=true)] public static extern
        int FreeEnvironmentStrings(string penv);
    [DllImport("kernel32", EntryPoint="FreeEnvironmentStringsW", SetLastError=true, ExactSpelling=true)] public static extern
        int FreeEnvironmentStrings(char* penv);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FreeEnvironmentStringsW(string penv);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FreeEnvironmentStringsW(char* penv);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetEnvironmentVariableA(cpointer unfoundType_LPCSTR_lpName, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetEnvironmentVariableA(cpointer unfoundType_LPCSTR_lpName, ReadOnlySpan<byte> lpBuffer, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetEnvironmentVariableA(cpointer unfoundType_LPCSTR_lpName, byte* lpBuffer, int nSize);
    [DllImport("kernel32", EntryPoint="GetEnvironmentVariableW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetEnvironmentVariable([MarshalAs(UnmanagedType.LPWStr)] string lpName, string lpBuffer, int nSize);
    [DllImport("kernel32", EntryPoint="GetEnvironmentVariableW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetEnvironmentVariable([MarshalAs(UnmanagedType.LPWStr)] string lpName, char* lpBuffer, int nSize);
    [DllImport("kernel32", EntryPoint="GetEnvironmentVariableW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetEnvironmentVariable(char* lpName, string lpBuffer, int nSize);
    [DllImport("kernel32", EntryPoint="GetEnvironmentVariableW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetEnvironmentVariable(char* lpName, char* lpBuffer, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetEnvironmentVariableW([MarshalAs(UnmanagedType.LPWStr)] string lpName, string lpBuffer, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetEnvironmentVariableW([MarshalAs(UnmanagedType.LPWStr)] string lpName, char* lpBuffer, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetEnvironmentVariableW(char* lpName, string lpBuffer, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetEnvironmentVariableW(char* lpName, char* lpBuffer, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetEnvironmentVariableA(cpointer unfoundType_LPCSTR_lpName, cpointer unfoundType_LPCSTR_lpValue);
    [DllImport("kernel32", EntryPoint="SetEnvironmentVariableW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetEnvironmentVariable([MarshalAs(UnmanagedType.LPWStr)] string lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpValue);
    [DllImport("kernel32", EntryPoint="SetEnvironmentVariableW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetEnvironmentVariable([MarshalAs(UnmanagedType.LPWStr)] string lpName, char* lpValue);
    [DllImport("kernel32", EntryPoint="SetEnvironmentVariableW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetEnvironmentVariable(char* lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpValue);
    [DllImport("kernel32", EntryPoint="SetEnvironmentVariableW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetEnvironmentVariable(char* lpName, char* lpValue);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetEnvironmentVariableW([MarshalAs(UnmanagedType.LPWStr)] string lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpValue);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetEnvironmentVariableW([MarshalAs(UnmanagedType.LPWStr)] string lpName, char* lpValue);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetEnvironmentVariableW(char* lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpValue);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetEnvironmentVariableW(char* lpName, char* lpValue);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ExpandEnvironmentStringsA(cpointer unfoundType_LPCSTR_lpSrc, [MarshalAs(UnmanagedType.LPStr)] string lpDst, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ExpandEnvironmentStringsA(cpointer unfoundType_LPCSTR_lpSrc, ReadOnlySpan<byte> lpDst, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ExpandEnvironmentStringsA(cpointer unfoundType_LPCSTR_lpSrc, byte* lpDst, int nSize);
    [DllImport("kernel32", EntryPoint="ExpandEnvironmentStringsW", SetLastError=true, ExactSpelling=true)] public static extern
        int ExpandEnvironmentStrings([MarshalAs(UnmanagedType.LPWStr)] string lpSrc, string lpDst, int nSize);
    [DllImport("kernel32", EntryPoint="ExpandEnvironmentStringsW", SetLastError=true, ExactSpelling=true)] public static extern
        int ExpandEnvironmentStrings([MarshalAs(UnmanagedType.LPWStr)] string lpSrc, char* lpDst, int nSize);
    [DllImport("kernel32", EntryPoint="ExpandEnvironmentStringsW", SetLastError=true, ExactSpelling=true)] public static extern
        int ExpandEnvironmentStrings(char* lpSrc, string lpDst, int nSize);
    [DllImport("kernel32", EntryPoint="ExpandEnvironmentStringsW", SetLastError=true, ExactSpelling=true)] public static extern
        int ExpandEnvironmentStrings(char* lpSrc, char* lpDst, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ExpandEnvironmentStringsW([MarshalAs(UnmanagedType.LPWStr)] string lpSrc, string lpDst, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ExpandEnvironmentStringsW([MarshalAs(UnmanagedType.LPWStr)] string lpSrc, char* lpDst, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ExpandEnvironmentStringsW(char* lpSrc, string lpDst, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ExpandEnvironmentStringsW(char* lpSrc, char* lpDst, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetCurrentDirectoryA(cpointer unfoundType_LPCSTR_lpPathName);
    [DllImport("kernel32", EntryPoint="SetCurrentDirectoryW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetCurrentDirectory([MarshalAs(UnmanagedType.LPWStr)] string lpPathName);
    [DllImport("kernel32", EntryPoint="SetCurrentDirectoryW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetCurrentDirectory(char* lpPathName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetCurrentDirectoryW([MarshalAs(UnmanagedType.LPWStr)] string lpPathName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetCurrentDirectoryW(char* lpPathName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrentDirectoryA(int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrentDirectoryA(int nBufferLength, ReadOnlySpan<byte> lpBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrentDirectoryA(int nBufferLength, byte* lpBuffer);
    [DllImport("kernel32", EntryPoint="GetCurrentDirectoryW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrentDirectory(int nBufferLength, string lpBuffer);
    [DllImport("kernel32", EntryPoint="GetCurrentDirectoryW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrentDirectory(int nBufferLength, char* lpBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrentDirectoryW(int nBufferLength, string lpBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrentDirectoryW(int nBufferLength, char* lpBuffer);
    [DllImport("kernel32", EntryPoint="SearchPathW", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPath([MarshalAs(UnmanagedType.LPWStr)] string lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, string lpBuffer, string lpFilePart);
    [DllImport("kernel32", EntryPoint="SearchPathW", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPath([MarshalAs(UnmanagedType.LPWStr)] string lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, string lpBuffer, char** lpFilePart);
    [DllImport("kernel32", EntryPoint="SearchPathW", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPath([MarshalAs(UnmanagedType.LPWStr)] string lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, char* lpBuffer, string lpFilePart);
    [DllImport("kernel32", EntryPoint="SearchPathW", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPath([MarshalAs(UnmanagedType.LPWStr)] string lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, char* lpBuffer, char** lpFilePart);
    [DllImport("kernel32", EntryPoint="SearchPathW", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPath([MarshalAs(UnmanagedType.LPWStr)] string lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExtension, int nBufferLength, string lpBuffer, string lpFilePart);
    [DllImport("kernel32", EntryPoint="SearchPathW", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPath([MarshalAs(UnmanagedType.LPWStr)] string lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExtension, int nBufferLength, string lpBuffer, char** lpFilePart);
    [DllImport("kernel32", EntryPoint="SearchPathW", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPath([MarshalAs(UnmanagedType.LPWStr)] string lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExtension, int nBufferLength, char* lpBuffer, string lpFilePart);
    [DllImport("kernel32", EntryPoint="SearchPathW", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPath([MarshalAs(UnmanagedType.LPWStr)] string lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExtension, int nBufferLength, char* lpBuffer, char** lpFilePart);
    [DllImport("kernel32", EntryPoint="SearchPathW", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPath([MarshalAs(UnmanagedType.LPWStr)] string lpPath, char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, string lpBuffer, string lpFilePart);
    [DllImport("kernel32", EntryPoint="SearchPathW", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPath([MarshalAs(UnmanagedType.LPWStr)] string lpPath, char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, string lpBuffer, char** lpFilePart);
    [DllImport("kernel32", EntryPoint="SearchPathW", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPath([MarshalAs(UnmanagedType.LPWStr)] string lpPath, char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, char* lpBuffer, string lpFilePart);
    [DllImport("kernel32", EntryPoint="SearchPathW", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPath([MarshalAs(UnmanagedType.LPWStr)] string lpPath, char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, char* lpBuffer, char** lpFilePart);
    [DllImport("kernel32", EntryPoint="SearchPathW", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPath([MarshalAs(UnmanagedType.LPWStr)] string lpPath, char* lpFileName, char* lpExtension, int nBufferLength, string lpBuffer, string lpFilePart);
    [DllImport("kernel32", EntryPoint="SearchPathW", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPath([MarshalAs(UnmanagedType.LPWStr)] string lpPath, char* lpFileName, char* lpExtension, int nBufferLength, string lpBuffer, char** lpFilePart);
    [DllImport("kernel32", EntryPoint="SearchPathW", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPath([MarshalAs(UnmanagedType.LPWStr)] string lpPath, char* lpFileName, char* lpExtension, int nBufferLength, char* lpBuffer, string lpFilePart);
    [DllImport("kernel32", EntryPoint="SearchPathW", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPath([MarshalAs(UnmanagedType.LPWStr)] string lpPath, char* lpFileName, char* lpExtension, int nBufferLength, char* lpBuffer, char** lpFilePart);
    [DllImport("kernel32", EntryPoint="SearchPathW", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPath(char* lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, string lpBuffer, string lpFilePart);
    [DllImport("kernel32", EntryPoint="SearchPathW", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPath(char* lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, string lpBuffer, char** lpFilePart);
    [DllImport("kernel32", EntryPoint="SearchPathW", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPath(char* lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, char* lpBuffer, string lpFilePart);
    [DllImport("kernel32", EntryPoint="SearchPathW", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPath(char* lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, char* lpBuffer, char** lpFilePart);
    [DllImport("kernel32", EntryPoint="SearchPathW", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPath(char* lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExtension, int nBufferLength, string lpBuffer, string lpFilePart);
    [DllImport("kernel32", EntryPoint="SearchPathW", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPath(char* lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExtension, int nBufferLength, string lpBuffer, char** lpFilePart);
    [DllImport("kernel32", EntryPoint="SearchPathW", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPath(char* lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExtension, int nBufferLength, char* lpBuffer, string lpFilePart);
    [DllImport("kernel32", EntryPoint="SearchPathW", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPath(char* lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExtension, int nBufferLength, char* lpBuffer, char** lpFilePart);
    [DllImport("kernel32", EntryPoint="SearchPathW", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPath(char* lpPath, char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, string lpBuffer, string lpFilePart);
    [DllImport("kernel32", EntryPoint="SearchPathW", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPath(char* lpPath, char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, string lpBuffer, char** lpFilePart);
    [DllImport("kernel32", EntryPoint="SearchPathW", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPath(char* lpPath, char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, char* lpBuffer, string lpFilePart);
    [DllImport("kernel32", EntryPoint="SearchPathW", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPath(char* lpPath, char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, char* lpBuffer, char** lpFilePart);
    [DllImport("kernel32", EntryPoint="SearchPathW", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPath(char* lpPath, char* lpFileName, char* lpExtension, int nBufferLength, string lpBuffer, string lpFilePart);
    [DllImport("kernel32", EntryPoint="SearchPathW", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPath(char* lpPath, char* lpFileName, char* lpExtension, int nBufferLength, string lpBuffer, char** lpFilePart);
    [DllImport("kernel32", EntryPoint="SearchPathW", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPath(char* lpPath, char* lpFileName, char* lpExtension, int nBufferLength, char* lpBuffer, string lpFilePart);
    [DllImport("kernel32", EntryPoint="SearchPathW", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPath(char* lpPath, char* lpFileName, char* lpExtension, int nBufferLength, char* lpBuffer, char** lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPathW([MarshalAs(UnmanagedType.LPWStr)] string lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, string lpBuffer, string lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPathW([MarshalAs(UnmanagedType.LPWStr)] string lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, string lpBuffer, char** lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPathW([MarshalAs(UnmanagedType.LPWStr)] string lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, char* lpBuffer, string lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPathW([MarshalAs(UnmanagedType.LPWStr)] string lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, char* lpBuffer, char** lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPathW([MarshalAs(UnmanagedType.LPWStr)] string lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExtension, int nBufferLength, string lpBuffer, string lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPathW([MarshalAs(UnmanagedType.LPWStr)] string lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExtension, int nBufferLength, string lpBuffer, char** lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPathW([MarshalAs(UnmanagedType.LPWStr)] string lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExtension, int nBufferLength, char* lpBuffer, string lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPathW([MarshalAs(UnmanagedType.LPWStr)] string lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExtension, int nBufferLength, char* lpBuffer, char** lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPathW([MarshalAs(UnmanagedType.LPWStr)] string lpPath, char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, string lpBuffer, string lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPathW([MarshalAs(UnmanagedType.LPWStr)] string lpPath, char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, string lpBuffer, char** lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPathW([MarshalAs(UnmanagedType.LPWStr)] string lpPath, char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, char* lpBuffer, string lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPathW([MarshalAs(UnmanagedType.LPWStr)] string lpPath, char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, char* lpBuffer, char** lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPathW([MarshalAs(UnmanagedType.LPWStr)] string lpPath, char* lpFileName, char* lpExtension, int nBufferLength, string lpBuffer, string lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPathW([MarshalAs(UnmanagedType.LPWStr)] string lpPath, char* lpFileName, char* lpExtension, int nBufferLength, string lpBuffer, char** lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPathW([MarshalAs(UnmanagedType.LPWStr)] string lpPath, char* lpFileName, char* lpExtension, int nBufferLength, char* lpBuffer, string lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPathW([MarshalAs(UnmanagedType.LPWStr)] string lpPath, char* lpFileName, char* lpExtension, int nBufferLength, char* lpBuffer, char** lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPathW(char* lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, string lpBuffer, string lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPathW(char* lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, string lpBuffer, char** lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPathW(char* lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, char* lpBuffer, string lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPathW(char* lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, char* lpBuffer, char** lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPathW(char* lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExtension, int nBufferLength, string lpBuffer, string lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPathW(char* lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExtension, int nBufferLength, string lpBuffer, char** lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPathW(char* lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExtension, int nBufferLength, char* lpBuffer, string lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPathW(char* lpPath, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExtension, int nBufferLength, char* lpBuffer, char** lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPathW(char* lpPath, char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, string lpBuffer, string lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPathW(char* lpPath, char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, string lpBuffer, char** lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPathW(char* lpPath, char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, char* lpBuffer, string lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPathW(char* lpPath, char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, int nBufferLength, char* lpBuffer, char** lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPathW(char* lpPath, char* lpFileName, char* lpExtension, int nBufferLength, string lpBuffer, string lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPathW(char* lpPath, char* lpFileName, char* lpExtension, int nBufferLength, string lpBuffer, char** lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPathW(char* lpPath, char* lpFileName, char* lpExtension, int nBufferLength, char* lpBuffer, string lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPathW(char* lpPath, char* lpFileName, char* lpExtension, int nBufferLength, char* lpBuffer, char** lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPathA(cpointer unfoundType_LPCSTR_lpPath, cpointer unfoundType_LPCSTR_lpFileName, cpointer unfoundType_LPCSTR_lpExtension, int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, [MarshalAs(UnmanagedType.LPStr)] string lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPathA(cpointer unfoundType_LPCSTR_lpPath, cpointer unfoundType_LPCSTR_lpFileName, cpointer unfoundType_LPCSTR_lpExtension, int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, ReadOnlySpan<byte> lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPathA(cpointer unfoundType_LPCSTR_lpPath, cpointer unfoundType_LPCSTR_lpFileName, cpointer unfoundType_LPCSTR_lpExtension, int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, byte** lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPathA(cpointer unfoundType_LPCSTR_lpPath, cpointer unfoundType_LPCSTR_lpFileName, cpointer unfoundType_LPCSTR_lpExtension, int nBufferLength, ReadOnlySpan<byte> lpBuffer, [MarshalAs(UnmanagedType.LPStr)] string lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPathA(cpointer unfoundType_LPCSTR_lpPath, cpointer unfoundType_LPCSTR_lpFileName, cpointer unfoundType_LPCSTR_lpExtension, int nBufferLength, ReadOnlySpan<byte> lpBuffer, ReadOnlySpan<byte> lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPathA(cpointer unfoundType_LPCSTR_lpPath, cpointer unfoundType_LPCSTR_lpFileName, cpointer unfoundType_LPCSTR_lpExtension, int nBufferLength, ReadOnlySpan<byte> lpBuffer, byte** lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPathA(cpointer unfoundType_LPCSTR_lpPath, cpointer unfoundType_LPCSTR_lpFileName, cpointer unfoundType_LPCSTR_lpExtension, int nBufferLength, byte* lpBuffer, [MarshalAs(UnmanagedType.LPStr)] string lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPathA(cpointer unfoundType_LPCSTR_lpPath, cpointer unfoundType_LPCSTR_lpFileName, cpointer unfoundType_LPCSTR_lpExtension, int nBufferLength, byte* lpBuffer, ReadOnlySpan<byte> lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SearchPathA(cpointer unfoundType_LPCSTR_lpPath, cpointer unfoundType_LPCSTR_lpFileName, cpointer unfoundType_LPCSTR_lpExtension, int nBufferLength, byte* lpBuffer, byte** lpFilePart);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int NeedCurrentDirectoryForExePathA(cpointer unfoundType_LPCSTR_ExeName);
    [DllImport("kernel32", EntryPoint="NeedCurrentDirectoryForExePathW", SetLastError=true, ExactSpelling=true)] public static extern
        int NeedCurrentDirectoryForExePath([MarshalAs(UnmanagedType.LPWStr)] string ExeName);
    [DllImport("kernel32", EntryPoint="NeedCurrentDirectoryForExePathW", SetLastError=true, ExactSpelling=true)] public static extern
        int NeedCurrentDirectoryForExePath(char* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int NeedCurrentDirectoryForExePathW([MarshalAs(UnmanagedType.LPWStr)] string ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int NeedCurrentDirectoryForExePathW(char* ExeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int PssCaptureSnapshot(cpointer ProcessHandle, cpointer unfoundType_PSS_CAPTURE_FLAGS_CaptureFlags, int ThreadContextFlags, cpointer unfoundType_HPSS_SnapshotHandle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int PssFreeSnapshot(cpointer ProcessHandle, cpointer unfoundType_HPSS_SnapshotHandle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int PssQuerySnapshot(cpointer unfoundType_HPSS_SnapshotHandle, cpointer unfoundType_PSS_QUERY_INFORMATION_CLASS_InformationClass, cpointer Buffer, int BufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int PssWalkSnapshot(cpointer unfoundType_HPSS_SnapshotHandle, cpointer unfoundType_PSS_WALK_INFORMATION_CLASS_InformationClass, cpointer unfoundType_HPSSWALK_WalkMarkerHandle, cpointer Buffer, int BufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int PssDuplicateSnapshot(cpointer SourceProcessHandle, cpointer unfoundType_HPSS_SnapshotHandle, cpointer TargetProcessHandle, cpointer unfoundType_HPSS_TargetSnapshotHandle, cpointer unfoundType_PSS_DUPLICATE_FLAGS_Flags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int PssWalkMarkerCreate(cpointer unfoundType_PSS_ALLOCATORAllocatorAllocator_unnamed_0, cpointer unfoundType_HPSSWALK_WalkMarkerHandle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int PssWalkMarkerFree(cpointer unfoundType_HPSSWALK_WalkMarkerHandle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int PssWalkMarkerGetPosition(cpointer unfoundType_HPSSWALK_WalkMarkerHandle, cpointer unfoundType_ULONG_PTRPositionPosition_unnamed_1);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int PssWalkMarkerSetPosition(cpointer unfoundType_HPSSWALK_WalkMarkerHandle, cpointer unfoundType_ULONG_PTR_Position);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int PssWalkMarkerSeekToBeginning(cpointer unfoundType_HPSSWALK_WalkMarkerHandle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int QueueUserAPC(cpointer unfoundType_PAPCFUNC_pfnAPC, cpointer hThread, cpointer unfoundType_ULONG_PTR_dwData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int QueueUserAPC2(cpointer unfoundType_PAPCFUNC_ApcRoutine, cpointer Thread, cpointer unfoundType_ULONG_PTR_Data, cpointer unfoundType_QUEUE_USER_APC_FLAGS_Flags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProcessTimes(cpointer hProcess, cpointer unfoundType_LPFILETIME_lpCreationTime, cpointer unfoundType_LPFILETIME_lpExitTime, cpointer unfoundType_LPFILETIME_lpKernelTime, cpointer unfoundType_LPFILETIME_lpUserTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetCurrentProcess();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrentProcessId();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void ExitProcess(uint uExitCode);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int TerminateProcess(cpointer hProcess, uint uExitCode);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetExitCodeProcess(cpointer hProcess, cpointer unfoundType_LPDWORD_lpExitCode);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SwitchToThread();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateThread(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, cpointer dwStackSize, cpointer unfoundType_LPTHREAD_START_ROUTINE_lpStartAddress, cpointer lpParameter, int dwCreationFlags, cpointer unfoundType_LPDWORD_lpThreadId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateRemoteThread(cpointer hProcess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, cpointer dwStackSize, cpointer unfoundType_LPTHREAD_START_ROUTINE_lpStartAddress, cpointer lpParameter, int dwCreationFlags, cpointer unfoundType_LPDWORD_lpThreadId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetCurrentThread();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrentThreadId();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenThread(int dwDesiredAccess, int bInheritHandle, int dwThreadId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetThreadPriority(cpointer hThread, int nPriority);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetThreadPriorityBoost(cpointer hThread, int bDisablePriorityBoost);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetThreadPriorityBoost(cpointer hThread, cpointer pDisablePriorityBoost);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetThreadPriority(cpointer hThread);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void ExitThread(int dwExitCode);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int TerminateThread(cpointer hThread, int dwExitCode);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetExitCodeThread(cpointer hThread, cpointer unfoundType_LPDWORD_lpExitCode);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SuspendThread(cpointer hThread);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ResumeThread(cpointer hThread);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int TlsAlloc();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer TlsGetValue(int dwTlsIndex);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int TlsSetValue(int dwTlsIndex, cpointer lpTlsValue);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int TlsFree(int dwTlsIndex);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateProcessA(cpointer unfoundType_LPCSTR_lpApplicationName, [MarshalAs(UnmanagedType.LPStr)] string lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, int bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, cpointer unfoundType_LPCSTR_lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateProcessA(cpointer unfoundType_LPCSTR_lpApplicationName, ReadOnlySpan<byte> lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, int bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, cpointer unfoundType_LPCSTR_lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateProcessA(cpointer unfoundType_LPCSTR_lpApplicationName, byte* lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, int bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, cpointer unfoundType_LPCSTR_lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport("kernel32", EntryPoint="CreateProcessW", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateProcess([MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, string lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, int bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport("kernel32", EntryPoint="CreateProcessW", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateProcess([MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, string lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, int bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, char* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport("kernel32", EntryPoint="CreateProcessW", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateProcess([MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, char* lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, int bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport("kernel32", EntryPoint="CreateProcessW", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateProcess([MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, char* lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, int bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, char* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport("kernel32", EntryPoint="CreateProcessW", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateProcess(char* lpApplicationName, string lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, int bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport("kernel32", EntryPoint="CreateProcessW", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateProcess(char* lpApplicationName, string lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, int bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, char* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport("kernel32", EntryPoint="CreateProcessW", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateProcess(char* lpApplicationName, char* lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, int bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport("kernel32", EntryPoint="CreateProcessW", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateProcess(char* lpApplicationName, char* lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, int bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, char* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateProcessW([MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, string lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, int bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateProcessW([MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, string lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, int bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, char* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateProcessW([MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, char* lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, int bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateProcessW([MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, char* lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, int bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, char* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateProcessW(char* lpApplicationName, string lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, int bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateProcessW(char* lpApplicationName, string lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, int bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, char* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateProcessW(char* lpApplicationName, char* lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, int bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateProcessW(char* lpApplicationName, char* lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, int bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, char* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetProcessShutdownParameters(int dwLevel, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProcessVersion(int ProcessId);
    [DllImport("kernel32", EntryPoint="GetStartupInfoW", SetLastError=true, ExactSpelling=true)] public static extern
        void GetStartupInfo(cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void GetStartupInfoW(cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo);
    [DllImport("kernel32", EntryPoint="CreateProcessAsUserW", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateProcessAsUser(cpointer hToken, [MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, string lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, int bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport("kernel32", EntryPoint="CreateProcessAsUserW", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateProcessAsUser(cpointer hToken, [MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, string lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, int bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, char* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport("kernel32", EntryPoint="CreateProcessAsUserW", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateProcessAsUser(cpointer hToken, [MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, char* lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, int bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport("kernel32", EntryPoint="CreateProcessAsUserW", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateProcessAsUser(cpointer hToken, [MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, char* lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, int bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, char* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport("kernel32", EntryPoint="CreateProcessAsUserW", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateProcessAsUser(cpointer hToken, char* lpApplicationName, string lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, int bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport("kernel32", EntryPoint="CreateProcessAsUserW", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateProcessAsUser(cpointer hToken, char* lpApplicationName, string lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, int bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, char* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport("kernel32", EntryPoint="CreateProcessAsUserW", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateProcessAsUser(cpointer hToken, char* lpApplicationName, char* lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, int bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport("kernel32", EntryPoint="CreateProcessAsUserW", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateProcessAsUser(cpointer hToken, char* lpApplicationName, char* lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, int bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, char* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateProcessAsUserW(cpointer hToken, [MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, string lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, int bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateProcessAsUserW(cpointer hToken, [MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, string lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, int bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, char* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateProcessAsUserW(cpointer hToken, [MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, char* lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, int bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateProcessAsUserW(cpointer hToken, [MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, char* lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, int bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, char* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateProcessAsUserW(cpointer hToken, char* lpApplicationName, string lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, int bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateProcessAsUserW(cpointer hToken, char* lpApplicationName, string lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, int bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, char* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateProcessAsUserW(cpointer hToken, char* lpApplicationName, char* lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, int bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateProcessAsUserW(cpointer hToken, char* lpApplicationName, char* lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, int bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, char* lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetThreadToken(cpointer unfoundType_PHANDLE_Thread, cpointer Token);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int OpenProcessToken(cpointer ProcessHandle, int DesiredAccess, cpointer unfoundType_PHANDLE_TokenHandle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int OpenThreadToken(cpointer ThreadHandle, int DesiredAccess, int OpenAsSelf, cpointer unfoundType_PHANDLE_TokenHandle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetPriorityClass(cpointer hProcess, int dwPriorityClass);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPriorityClass(cpointer hProcess);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetThreadStackGuarantee(cpointer unfoundType_PULONG_StackSizeInBytes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ProcessIdToSessionId(int dwProcessId, cpointer pSessionId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProcessId(cpointer Process);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetThreadId(cpointer Thread);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void FlushProcessWriteBuffers();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProcessIdOfThread(cpointer Thread);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int InitializeProcThreadAttributeList(cpointer unfoundType_LPPROC_THREAD_ATTRIBUTE_LIST_lpAttributeList, int dwAttributeCount, int dwFlags, cpointer unfoundType_PSIZE_T_lpSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void DeleteProcThreadAttributeList(cpointer unfoundType_LPPROC_THREAD_ATTRIBUTE_LIST_lpAttributeList);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int UpdateProcThreadAttribute(cpointer unfoundType_LPPROC_THREAD_ATTRIBUTE_LIST_lpAttributeList, int dwFlags, cpointer unfoundType_DWORD_PTR_Attribute, cpointer lpValue, cpointer cbSize, cpointer lpPreviousValue, cpointer unfoundType_PSIZE_T_lpReturnSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetProcessDynamicEHContinuationTargets(cpointer Process, ushort NumberOfTargets, cpointer unfoundType_PPROCESS_DYNAMIC_EH_CONTINUATION_TARGET_Targets);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetProcessDynamicEnforcedCetCompatibleRanges(cpointer Process, ushort NumberOfRanges, cpointer unfoundType_PPROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGE_Ranges);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetProcessAffinityUpdateMode(cpointer hProcess, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryProcessAffinityUpdateMode(cpointer hProcess, cpointer unfoundType_LPDWORD_lpdwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateRemoteThreadEx(cpointer hProcess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, cpointer dwStackSize, cpointer unfoundType_LPTHREAD_START_ROUTINE_lpStartAddress, cpointer lpParameter, int dwCreationFlags, cpointer unfoundType_LPPROC_THREAD_ATTRIBUTE_LIST_lpAttributeList, cpointer unfoundType_LPDWORD_lpThreadId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void GetCurrentThreadStackLimits(cpointer LowLimit, cpointer HighLimit);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetThreadContext(cpointer hThread, cpointer unfoundType_LPCONTEXT_lpContext);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProcessMitigationPolicy(cpointer hProcess, cpointer unfoundType_PROCESS_MITIGATION_POLICY_MitigationPolicy, cpointer lpBuffer, cpointer dwLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetThreadContext(cpointer hThread, cpointer unfoundType_CONTEXT_lpContext);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetProcessMitigationPolicy(cpointer unfoundType_PROCESS_MITIGATION_POLICY_MitigationPolicy, cpointer lpBuffer, cpointer dwLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FlushInstructionCache(cpointer hProcess, cpointer lpBaseAddress, cpointer dwSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetThreadTimes(cpointer hThread, cpointer unfoundType_LPFILETIME_lpCreationTime, cpointer unfoundType_LPFILETIME_lpExitTime, cpointer unfoundType_LPFILETIME_lpKernelTime, cpointer unfoundType_LPFILETIME_lpUserTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenProcess(int dwDesiredAccess, int bInheritHandle, int dwProcessId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsProcessorFeaturePresent(int ProcessorFeature);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProcessHandleCount(cpointer hProcess, cpointer unfoundType_PDWORD_pdwHandleCount);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrentProcessorNumber();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetThreadIdealProcessorEx(cpointer hThread, cpointer unfoundType_PPROCESSOR_NUMBER_lpIdealProcessor, cpointer unfoundType_PPROCESSOR_NUMBER_lpPreviousIdealProcessor);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetThreadIdealProcessorEx(cpointer hThread, cpointer unfoundType_PPROCESSOR_NUMBER_lpIdealProcessor);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void GetCurrentProcessorNumberEx(cpointer unfoundType_PPROCESSOR_NUMBER_ProcNumber);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProcessPriorityBoost(cpointer hProcess, cpointer pDisablePriorityBoost);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetProcessPriorityBoost(cpointer hProcess, int bDisablePriorityBoost);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetThreadIOPendingFlag(cpointer hThread, cpointer lpIOIsPending);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetSystemTimes(cpointer unfoundType_PFILETIME_lpIdleTime, cpointer unfoundType_PFILETIME_lpKernelTime, cpointer unfoundType_PFILETIME_lpUserTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetThreadInformation(cpointer hThread, cpointer unfoundType_THREAD_INFORMATION_CLASS_ThreadInformationClass, cpointer ThreadInformation, int ThreadInformationSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetThreadInformation(cpointer hThread, cpointer unfoundType_THREAD_INFORMATION_CLASS_ThreadInformationClass, cpointer ThreadInformation, int ThreadInformationSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsProcessCritical(cpointer hProcess, cpointer Critical);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetProtectedPolicy(cpointer unfoundType_LPCGUID_PolicyGuid, cpointer unfoundType_ULONG_PTR_PolicyValue, cpointer OldPolicyValue);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryProtectedPolicy(cpointer unfoundType_LPCGUID_PolicyGuid, cpointer PolicyValue);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetThreadIdealProcessor(cpointer hThread, int dwIdealProcessor);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetProcessInformation(cpointer hProcess, cpointer unfoundType_PROCESS_INFORMATION_CLASS_ProcessInformationClass, cpointer ProcessInformation, int ProcessInformationSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProcessInformation(cpointer hProcess, cpointer unfoundType_PROCESS_INFORMATION_CLASS_ProcessInformationClass, cpointer ProcessInformation, int ProcessInformationSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetSystemCpuSetInformation(cpointer unfoundType_PSYSTEM_CPU_SET_INFORMATION_Information, uint BufferLength, cpointer unfoundType_PULONG_ReturnedLength, cpointer Process, uint Flags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProcessDefaultCpuSets(cpointer Process, cpointer unfoundType_PULONG_CpuSetIds, uint CpuSetIdCount, cpointer unfoundType_PULONG_RequiredIdCount);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetProcessDefaultCpuSets(cpointer Process, cpointer CpuSetIds, uint CpuSetIdCount);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetThreadSelectedCpuSets(cpointer Thread, cpointer unfoundType_PULONG_CpuSetIds, uint CpuSetIdCount, cpointer unfoundType_PULONG_RequiredIdCount);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetThreadSelectedCpuSets(cpointer Thread, cpointer CpuSetIds, uint CpuSetIdCount);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateProcessAsUserA(cpointer hToken, cpointer unfoundType_LPCSTR_lpApplicationName, [MarshalAs(UnmanagedType.LPStr)] string lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, int bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, cpointer unfoundType_LPCSTR_lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateProcessAsUserA(cpointer hToken, cpointer unfoundType_LPCSTR_lpApplicationName, ReadOnlySpan<byte> lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, int bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, cpointer unfoundType_LPCSTR_lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateProcessAsUserA(cpointer hToken, cpointer unfoundType_LPCSTR_lpApplicationName, byte* lpCommandLine, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, int bInheritHandles, int dwCreationFlags, cpointer lpEnvironment, cpointer unfoundType_LPCSTR_lpCurrentDirectory, cpointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, cpointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProcessShutdownParameters(cpointer unfoundType_LPDWORD_lpdwLevel, cpointer unfoundType_LPDWORD_lpdwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProcessDefaultCpuSetMasks(cpointer Process, cpointer unfoundType_PGROUP_AFFINITY_CpuSetMasks, ushort CpuSetMaskCount, cpointer unfoundType_PUSHORT_RequiredMaskCount);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetProcessDefaultCpuSetMasks(cpointer Process, cpointer unfoundType_PGROUP_AFFINITY_CpuSetMasks, ushort CpuSetMaskCount);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetThreadSelectedCpuSetMasks(cpointer Thread, cpointer unfoundType_PGROUP_AFFINITY_CpuSetMasks, ushort CpuSetMaskCount, cpointer unfoundType_PUSHORT_RequiredMaskCount);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetThreadSelectedCpuSetMasks(cpointer Thread, cpointer unfoundType_PGROUP_AFFINITY_CpuSetMasks, ushort CpuSetMaskCount);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetMachineTypeAttributes(ushort Machine, cpointer unfoundType_MACHINE_ATTRIBUTES_MachineTypeAttributes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer SetThreadDescription(cpointer hThread, [MarshalAs(UnmanagedType.LPWStr)] string lpThreadDescription);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer SetThreadDescription(cpointer hThread, char* lpThreadDescription);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetThreadDescription(cpointer hThread, [MarshalAs(UnmanagedType.LPWStr)] string ppszThreadDescription);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetThreadDescription(cpointer hThread, char** ppszThreadDescription);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProcessGroupAffinity(cpointer hProcess, cpointer unfoundType_PUSHORT_GroupCount, cpointer unfoundType_PUSHORT_GroupArray);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetThreadGroupAffinity(cpointer hThread, cpointer unfoundType_PGROUP_AFFINITY_GroupAffinity);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetThreadGroupAffinity(cpointer hThread, cpointer unfoundType_GROUP_AFFINITY_GroupAffinity, cpointer unfoundType_PGROUP_AFFINITY_PreviousGroupAffinity);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryPerformanceCounter(cpointer unfoundType_LARGE_INTEGER_lpPerformanceCount);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryPerformanceFrequency(cpointer unfoundType_LARGE_INTEGER_lpFrequency);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int OOBEComplete(cpointer isOOBEComplete);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int RegisterWaitUntilOOBECompleted(cpointer unfoundType_OOBE_COMPLETED_CALLBACK_OOBECompletedCallback, cpointer CallbackContext, cpointer WaitHandle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int UnregisterWaitUntilOOBECompleted(cpointer WaitHandle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetAppContainerNamedObjectPath(cpointer Token, cpointer unfoundType_PSID_AppContainerSid, uint ObjectPathLength, string ObjectPath, cpointer unfoundType_PULONG_ReturnLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetAppContainerNamedObjectPath(cpointer Token, cpointer unfoundType_PSID_AppContainerSid, uint ObjectPathLength, char* ObjectPath, cpointer unfoundType_PULONG_ReturnLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AddResourceAttributeAce(cpointer unfoundType_PACL_pAcl, int dwAceRevision, int AceFlags, int AccessMask, cpointer unfoundType_PSID_pSid, cpointer unfoundType_PCLAIM_SECURITY_ATTRIBUTES_INFORMATION_pAttributeInfo, cpointer unfoundType_PDWORD_pReturnLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AddScopedPolicyIDAce(cpointer unfoundType_PACL_pAcl, int dwAceRevision, int AceFlags, int AccessMask, cpointer unfoundType_PSID_pSid);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CheckTokenCapability(cpointer TokenHandle, cpointer unfoundType_PSID_CapabilitySidToCheck, cpointer HasCapability);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetAppContainerAce(cpointer unfoundType_PACL_Acl, int StartingAceIndex, cpointer AppContainerAce, cpointer AppContainerAceIndex);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CheckTokenMembershipEx(cpointer TokenHandle, cpointer unfoundType_PSID_SidToCheck, int Flags, cpointer IsMember);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetCachedSigningLevel(cpointer unfoundType_PHANDLE_SourceFiles, uint SourceFileCount, uint Flags, cpointer TargetFile);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCachedSigningLevel(cpointer File, cpointer unfoundType_PULONG_Flags, cpointer unfoundType_PULONG_SigningLevel, cpointer unfoundType_PUCHAR_Thumbprint, cpointer unfoundType_PULONG_ThumbprintSize, cpointer unfoundType_PULONG_ThumbprintAlgorithm);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryThreadCycleTime(cpointer ThreadHandle, cpointer unfoundType_PULONG64_CycleTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryProcessCycleTime(cpointer ProcessHandle, cpointer unfoundType_PULONG64_CycleTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryIdleProcessorCycleTime(cpointer unfoundType_PULONG_BufferLength, cpointer unfoundType_PULONG64_ProcessorIdleCycleTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryIdleProcessorCycleTimeEx(ushort Group, cpointer unfoundType_PULONG_BufferLength, cpointer unfoundType_PULONG64_ProcessorIdleCycleTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryUnbiasedInterruptTime(cpointer unfoundType_PULONGLONG_UnbiasedTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CompareStringEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwCmpFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpString1, int cchCount1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2, int cchCount2, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long lParam);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CompareStringEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwCmpFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpString1, int cchCount1, char* lpString2, int cchCount2, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long lParam);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CompareStringEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwCmpFlags, char* lpString1, int cchCount1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2, int cchCount2, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long lParam);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CompareStringEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwCmpFlags, char* lpString1, int cchCount1, char* lpString2, int cchCount2, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long lParam);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CompareStringEx(char* lpLocaleName, int dwCmpFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpString1, int cchCount1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2, int cchCount2, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long lParam);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CompareStringEx(char* lpLocaleName, int dwCmpFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpString1, int cchCount1, char* lpString2, int cchCount2, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long lParam);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CompareStringEx(char* lpLocaleName, int dwCmpFlags, char* lpString1, int cchCount1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2, int cchCount2, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long lParam);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CompareStringEx(char* lpLocaleName, int dwCmpFlags, char* lpString1, int cchCount1, char* lpString2, int cchCount2, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long lParam);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CompareStringOrdinal([MarshalAs(UnmanagedType.LPWStr)] string lpString1, int cchCount1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2, int cchCount2, int bIgnoreCase);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CompareStringOrdinal([MarshalAs(UnmanagedType.LPWStr)] string lpString1, int cchCount1, char* lpString2, int cchCount2, int bIgnoreCase);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CompareStringOrdinal(char* lpString1, int cchCount1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2, int cchCount2, int bIgnoreCase);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CompareStringOrdinal(char* lpString1, int cchCount1, char* lpString2, int cchCount2, int bIgnoreCase);
    [DllImport("kernel32", EntryPoint="CompareStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int CompareString(cpointer unfoundType_LCID_Locale, int dwCmpFlags, string lpString1, int cchCount1, string lpString2, int cchCount2);
    [DllImport("kernel32", EntryPoint="CompareStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int CompareString(cpointer unfoundType_LCID_Locale, int dwCmpFlags, string lpString1, int cchCount1, char* lpString2, int cchCount2);
    [DllImport("kernel32", EntryPoint="CompareStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int CompareString(cpointer unfoundType_LCID_Locale, int dwCmpFlags, char* lpString1, int cchCount1, string lpString2, int cchCount2);
    [DllImport("kernel32", EntryPoint="CompareStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int CompareString(cpointer unfoundType_LCID_Locale, int dwCmpFlags, char* lpString1, int cchCount1, char* lpString2, int cchCount2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CompareStringW(cpointer unfoundType_LCID_Locale, int dwCmpFlags, string lpString1, int cchCount1, string lpString2, int cchCount2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CompareStringW(cpointer unfoundType_LCID_Locale, int dwCmpFlags, string lpString1, int cchCount1, char* lpString2, int cchCount2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CompareStringW(cpointer unfoundType_LCID_Locale, int dwCmpFlags, char* lpString1, int cchCount1, string lpString2, int cchCount2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CompareStringW(cpointer unfoundType_LCID_Locale, int dwCmpFlags, char* lpString1, int cchCount1, char* lpString2, int cchCount2);
    [DllImport("kernel32", EntryPoint="FoldStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int FoldString(int dwMapFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, string lpDestStr, int cchDest);
    [DllImport("kernel32", EntryPoint="FoldStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int FoldString(int dwMapFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, char* lpDestStr, int cchDest);
    [DllImport("kernel32", EntryPoint="FoldStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int FoldString(int dwMapFlags, char* lpSrcStr, int cchSrc, string lpDestStr, int cchDest);
    [DllImport("kernel32", EntryPoint="FoldStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int FoldString(int dwMapFlags, char* lpSrcStr, int cchSrc, char* lpDestStr, int cchDest);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FoldStringW(int dwMapFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, string lpDestStr, int cchDest);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FoldStringW(int dwMapFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, char* lpDestStr, int cchDest);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FoldStringW(int dwMapFlags, char* lpSrcStr, int cchSrc, string lpDestStr, int cchDest);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FoldStringW(int dwMapFlags, char* lpSrcStr, int cchSrc, char* lpDestStr, int cchDest);
    [DllImport("kernel32", EntryPoint="GetStringTypeExW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetStringTypeEx(cpointer unfoundType_LCID_Locale, int dwInfoType, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, cpointer unfoundType_LPWORD_lpCharType);
    [DllImport("kernel32", EntryPoint="GetStringTypeExW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetStringTypeEx(cpointer unfoundType_LCID_Locale, int dwInfoType, char* lpSrcStr, int cchSrc, cpointer unfoundType_LPWORD_lpCharType);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetStringTypeExW(cpointer unfoundType_LCID_Locale, int dwInfoType, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, cpointer unfoundType_LPWORD_lpCharType);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetStringTypeExW(cpointer unfoundType_LCID_Locale, int dwInfoType, char* lpSrcStr, int cchSrc, cpointer unfoundType_LPWORD_lpCharType);
    [DllImport("kernel32", EntryPoint="GetStringTypeW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetStringType(int dwInfoType, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, cpointer unfoundType_LPWORD_lpCharType);
    [DllImport("kernel32", EntryPoint="GetStringTypeW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetStringType(int dwInfoType, char* lpSrcStr, int cchSrc, cpointer unfoundType_LPWORD_lpCharType);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetStringTypeW(int dwInfoType, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, cpointer unfoundType_LPWORD_lpCharType);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetStringTypeW(int dwInfoType, char* lpSrcStr, int cchSrc, cpointer unfoundType_LPWORD_lpCharType);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int MultiByteToWideChar(uint CodePage, int dwFlags, cpointer unfoundType_LPCCH_lpMultiByteStr, int cbMultiByte, string lpWideCharStr, int cchWideChar);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int MultiByteToWideChar(uint CodePage, int dwFlags, cpointer unfoundType_LPCCH_lpMultiByteStr, int cbMultiByte, char* lpWideCharStr, int cchWideChar);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WideCharToMultiByte(uint CodePage, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpWideCharStr, int cchWideChar, [MarshalAs(UnmanagedType.LPStr)] string lpMultiByteStr, int cbMultiByte, cpointer unfoundType_LPCCH_lpDefaultChar, cpointer unfoundType_LPBOOL_lpUsedDefaultChar);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WideCharToMultiByte(uint CodePage, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpWideCharStr, int cchWideChar, ReadOnlySpan<byte> lpMultiByteStr, int cbMultiByte, cpointer unfoundType_LPCCH_lpDefaultChar, cpointer unfoundType_LPBOOL_lpUsedDefaultChar);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WideCharToMultiByte(uint CodePage, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpWideCharStr, int cchWideChar, byte* lpMultiByteStr, int cbMultiByte, cpointer unfoundType_LPCCH_lpDefaultChar, cpointer unfoundType_LPBOOL_lpUsedDefaultChar);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WideCharToMultiByte(uint CodePage, int dwFlags, char* lpWideCharStr, int cchWideChar, [MarshalAs(UnmanagedType.LPStr)] string lpMultiByteStr, int cbMultiByte, cpointer unfoundType_LPCCH_lpDefaultChar, cpointer unfoundType_LPBOOL_lpUsedDefaultChar);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WideCharToMultiByte(uint CodePage, int dwFlags, char* lpWideCharStr, int cchWideChar, ReadOnlySpan<byte> lpMultiByteStr, int cbMultiByte, cpointer unfoundType_LPCCH_lpDefaultChar, cpointer unfoundType_LPBOOL_lpUsedDefaultChar);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WideCharToMultiByte(uint CodePage, int dwFlags, char* lpWideCharStr, int cchWideChar, byte* lpMultiByteStr, int cbMultiByte, cpointer unfoundType_LPCCH_lpDefaultChar, cpointer unfoundType_LPBOOL_lpUsedDefaultChar);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNumaHighestNodeNumber(cpointer unfoundType_PULONG_HighestNodeNumber);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNumaNodeProcessorMaskEx(ushort Node, cpointer unfoundType_PGROUP_AFFINITY_ProcessorMask);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNumaNodeProcessorMask2(ushort NodeNumber, cpointer unfoundType_PGROUP_AFFINITY_ProcessorMasks, ushort ProcessorMaskCount, cpointer unfoundType_PUSHORT_RequiredMaskCount);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNumaProximityNodeEx(uint ProximityId, cpointer unfoundType_PUSHORT_NodeNumber);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        ushort RtlCaptureStackBackTrace(uint FramesToSkip, uint FramesToCapture, cpointer BackTrace, cpointer unfoundType_PULONG_BackTraceHash);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void RtlCaptureContext(cpointer unfoundType_PCONTEXT_ContextRecord);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void RtlUnwind(cpointer TargetFrame, cpointer TargetIp, cpointer unfoundType_PEXCEPTION_RECORD_ExceptionRecord, cpointer ReturnValue);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true, CallingConvention=CallingConvention.Cdecl)] public static extern
        cpointer RtlAddFunctionTable(cpointer unfoundType_PRUNTIME_FUNCTION_FunctionTable, uint EntryCount, cpointer unfoundType_ULONG64_BaseAddress);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true, CallingConvention=CallingConvention.Cdecl)] public static extern
        cpointer RtlDeleteFunctionTable(cpointer unfoundType_PRUNTIME_FUNCTION_FunctionTable);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true, CallingConvention=CallingConvention.Cdecl)] public static extern
        cpointer RtlInstallFunctionTableCallback(cpointer unfoundType_ULONG64_TableIdentifier, cpointer unfoundType_ULONG64_BaseAddress, uint Length, cpointer unfoundType_PGET_RUNTIME_FUNCTION_CALLBACK_Callback, cpointer Context, [MarshalAs(UnmanagedType.LPWStr)] string OutOfProcessCallbackDll);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true, CallingConvention=CallingConvention.Cdecl)] public static extern
        cpointer RtlInstallFunctionTableCallback(cpointer unfoundType_ULONG64_TableIdentifier, cpointer unfoundType_ULONG64_BaseAddress, uint Length, cpointer unfoundType_PGET_RUNTIME_FUNCTION_CALLBACK_Callback, cpointer Context, char* OutOfProcessCallbackDll);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RtlLookupFunctionEntry(cpointer unfoundType_ULONG64_ControlPc, cpointer unfoundType_PULONG64_ImageBase, cpointer unfoundType_PUNWIND_HISTORY_TABLE_HistoryTable);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true, CallingConvention=CallingConvention.Cdecl)] public static extern
        void RtlRestoreContext(cpointer unfoundType_PCONTEXT_ContextRecord, cpointer unfoundType__EXCEPTION_RECORD_ExceptionRecord);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void RtlUnwindEx(cpointer TargetFrame, cpointer TargetIp, cpointer unfoundType_PEXCEPTION_RECORD_ExceptionRecord, cpointer ReturnValue, cpointer unfoundType_PCONTEXT_ContextRecord, cpointer unfoundType_PUNWIND_HISTORY_TABLE_HistoryTable);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RtlVirtualUnwind(uint HandlerType, cpointer unfoundType_ULONG64_ImageBase, cpointer unfoundType_ULONG64_ControlPc, cpointer unfoundType_PRUNTIME_FUNCTION_FunctionEntry, cpointer unfoundType_PCONTEXT_ContextRecord, cpointer HandlerData, cpointer unfoundType_PULONG64_EstablisherFrame, cpointer unfoundType_PKNONVOLATILE_CONTEXT_POINTERS_ContextPointers);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RtlVirtualUnwind2(uint HandlerType, cpointer unfoundType_ULONG64_ImageBase, cpointer unfoundType_ULONG64_ControlPc, cpointer unfoundType_PRUNTIME_FUNCTION_FunctionEntry, cpointer unfoundType_PCONTEXT_ContextRecord, cpointer unfoundType_PBOOLEAN_MachineFrameUnwound, cpointer HandlerData, cpointer unfoundType_PULONG64_EstablisherFrame, cpointer unfoundType_PKNONVOLATILE_CONTEXT_POINTERS_ContextPointers, cpointer unfoundType_PULONG64_LowLimit, cpointer unfoundType_PULONG64_HighLimit, cpointer unfoundType_PEXCEPTION_ROUTINE_HandlerRoutine, uint UnwindFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RtlIsEcCode(cpointer unfoundType_ULONG64_CodePointer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void RtlRaiseException(cpointer unfoundType_PEXCEPTION_RECORD_ExceptionRecord);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RtlPcToFileHeader(cpointer PcValue, cpointer BaseOfImage);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint* RtlCompareMemory(cpointer Source1, cpointer Source2, cpointer Length);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void InitializeSRWLock(cpointer unfoundType_PSRWLOCK_SRWLock);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void ReleaseSRWLockExclusive(cpointer unfoundType_PSRWLOCK_SRWLock);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void ReleaseSRWLockShared(cpointer unfoundType_PSRWLOCK_SRWLock);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void AcquireSRWLockExclusive(cpointer unfoundType_PSRWLOCK_SRWLock);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void AcquireSRWLockShared(cpointer unfoundType_PSRWLOCK_SRWLock);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer TryAcquireSRWLockExclusive(cpointer unfoundType_PSRWLOCK_SRWLock);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer TryAcquireSRWLockShared(cpointer unfoundType_PSRWLOCK_SRWLock);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void InitializeCriticalSection(cpointer unfoundType_LPCRITICAL_SECTION_lpCriticalSection);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void EnterCriticalSection(cpointer unfoundType_LPCRITICAL_SECTION_lpCriticalSection);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void LeaveCriticalSection(cpointer unfoundType_LPCRITICAL_SECTION_lpCriticalSection);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int InitializeCriticalSectionAndSpinCount(cpointer unfoundType_LPCRITICAL_SECTION_lpCriticalSection, int dwSpinCount);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int InitializeCriticalSectionEx(cpointer unfoundType_LPCRITICAL_SECTION_lpCriticalSection, int dwSpinCount, int Flags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetCriticalSectionSpinCount(cpointer unfoundType_LPCRITICAL_SECTION_lpCriticalSection, int dwSpinCount);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int TryEnterCriticalSection(cpointer unfoundType_LPCRITICAL_SECTION_lpCriticalSection);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void DeleteCriticalSection(cpointer unfoundType_LPCRITICAL_SECTION_lpCriticalSection);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void InitOnceInitialize(cpointer unfoundType_PINIT_ONCE_InitOnce);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int InitOnceExecuteOnce(cpointer unfoundType_PINIT_ONCE_InitOnce, cpointer unfoundType_PINIT_ONCE_FN_InitFn, cpointer Parameter, cpointer Context);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int InitOnceBeginInitialize(cpointer unfoundType_LPINIT_ONCE_lpInitOnce, int dwFlags, cpointer fPending, cpointer lpContext);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int InitOnceComplete(cpointer unfoundType_LPINIT_ONCE_lpInitOnce, int dwFlags, cpointer lpContext);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void InitializeConditionVariable(cpointer unfoundType_PCONDITION_VARIABLE_ConditionVariable);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void WakeConditionVariable(cpointer unfoundType_PCONDITION_VARIABLE_ConditionVariable);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void WakeAllConditionVariable(cpointer unfoundType_PCONDITION_VARIABLE_ConditionVariable);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SleepConditionVariableCS(cpointer unfoundType_PCONDITION_VARIABLE_ConditionVariable, cpointer unfoundType_PCRITICAL_SECTION_CriticalSection, int dwMilliseconds);
    [DllImport("kernel32", EntryPoint="SleepConditionVariableSRW", SetLastError=true, ExactSpelling=true)] public static extern
        int SleepConditionVariableSR(cpointer unfoundType_PCONDITION_VARIABLE_ConditionVariable, cpointer unfoundType_PSRWLOCK_SRWLock, int dwMilliseconds, uint Flags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SleepConditionVariableSRW(cpointer unfoundType_PCONDITION_VARIABLE_ConditionVariable, cpointer unfoundType_PSRWLOCK_SRWLock, int dwMilliseconds, uint Flags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetEvent(cpointer hEvent);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ResetEvent(cpointer hEvent);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ReleaseSemaphore(cpointer hSemaphore, int lReleaseCount, cpointer unfoundType_LPLONG_lpPreviousCount);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ReleaseMutex(cpointer hMutex);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WaitForSingleObject(cpointer hHandle, int dwMilliseconds);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SleepEx(int dwMilliseconds, int bAlertable);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WaitForSingleObjectEx(cpointer hHandle, int dwMilliseconds, int bAlertable);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WaitForMultipleObjectsEx(int nCount, cpointer lpHandles, int bWaitAll, int dwMilliseconds, int bAlertable);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateMutexA(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpMutexAttributes, int bInitialOwner, cpointer unfoundType_LPCSTR_lpName);
    [DllImport("kernel32", EntryPoint="CreateMutexW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateMutex(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpMutexAttributes, int bInitialOwner, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport("kernel32", EntryPoint="CreateMutexW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateMutex(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpMutexAttributes, int bInitialOwner, char* lpName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateMutexW(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpMutexAttributes, int bInitialOwner, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateMutexW(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpMutexAttributes, int bInitialOwner, char* lpName);
    [DllImport("kernel32", EntryPoint="OpenMutexW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenMutex(int dwDesiredAccess, int bInheritHandle, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport("kernel32", EntryPoint="OpenMutexW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenMutex(int dwDesiredAccess, int bInheritHandle, char* lpName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenMutexW(int dwDesiredAccess, int bInheritHandle, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenMutexW(int dwDesiredAccess, int bInheritHandle, char* lpName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateEventA(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpEventAttributes, int bManualReset, int bInitialState, cpointer unfoundType_LPCSTR_lpName);
    [DllImport("kernel32", EntryPoint="CreateEventW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateEvent(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpEventAttributes, int bManualReset, int bInitialState, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport("kernel32", EntryPoint="CreateEventW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateEvent(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpEventAttributes, int bManualReset, int bInitialState, char* lpName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateEventW(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpEventAttributes, int bManualReset, int bInitialState, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateEventW(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpEventAttributes, int bManualReset, int bInitialState, char* lpName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenEventA(int dwDesiredAccess, int bInheritHandle, cpointer unfoundType_LPCSTR_lpName);
    [DllImport("kernel32", EntryPoint="OpenEventW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenEvent(int dwDesiredAccess, int bInheritHandle, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport("kernel32", EntryPoint="OpenEventW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenEvent(int dwDesiredAccess, int bInheritHandle, char* lpName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenEventW(int dwDesiredAccess, int bInheritHandle, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenEventW(int dwDesiredAccess, int bInheritHandle, char* lpName);
    [DllImport("kernel32", EntryPoint="OpenSemaphoreW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenSemaphore(int dwDesiredAccess, int bInheritHandle, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport("kernel32", EntryPoint="OpenSemaphoreW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenSemaphore(int dwDesiredAccess, int bInheritHandle, char* lpName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenSemaphoreW(int dwDesiredAccess, int bInheritHandle, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenSemaphoreW(int dwDesiredAccess, int bInheritHandle, char* lpName);
    [DllImport("kernel32", EntryPoint="OpenWaitableTimerW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenWaitableTimer(int dwDesiredAccess, int bInheritHandle, [MarshalAs(UnmanagedType.LPWStr)] string lpTimerName);
    [DllImport("kernel32", EntryPoint="OpenWaitableTimerW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenWaitableTimer(int dwDesiredAccess, int bInheritHandle, char* lpTimerName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenWaitableTimerW(int dwDesiredAccess, int bInheritHandle, [MarshalAs(UnmanagedType.LPWStr)] string lpTimerName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenWaitableTimerW(int dwDesiredAccess, int bInheritHandle, char* lpTimerName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetWaitableTimerEx(cpointer hTimer, cpointer unfoundType_LARGE_INTEGER_lpDueTime, int lPeriod, cpointer unfoundType_PTIMERAPCROUTINE_pfnCompletionRoutine, cpointer lpArgToCompletionRoutine, cpointer unfoundType_PREASON_CONTEXT_WakeContext, uint TolerableDelay);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetWaitableTimer(cpointer hTimer, cpointer unfoundType_LARGE_INTEGER_lpDueTime, int lPeriod, cpointer unfoundType_PTIMERAPCROUTINE_pfnCompletionRoutine, cpointer lpArgToCompletionRoutine, int fResume);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CancelWaitableTimer(cpointer hTimer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateMutexExA(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpMutexAttributes, cpointer unfoundType_LPCSTR_lpName, int dwFlags, int dwDesiredAccess);
    [DllImport("kernel32", EntryPoint="CreateMutexExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateMutexEx(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpMutexAttributes, [MarshalAs(UnmanagedType.LPWStr)] string lpName, int dwFlags, int dwDesiredAccess);
    [DllImport("kernel32", EntryPoint="CreateMutexExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateMutexEx(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpMutexAttributes, char* lpName, int dwFlags, int dwDesiredAccess);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateMutexExW(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpMutexAttributes, [MarshalAs(UnmanagedType.LPWStr)] string lpName, int dwFlags, int dwDesiredAccess);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateMutexExW(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpMutexAttributes, char* lpName, int dwFlags, int dwDesiredAccess);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateEventExA(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpEventAttributes, cpointer unfoundType_LPCSTR_lpName, int dwFlags, int dwDesiredAccess);
    [DllImport("kernel32", EntryPoint="CreateEventExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateEventEx(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpEventAttributes, [MarshalAs(UnmanagedType.LPWStr)] string lpName, int dwFlags, int dwDesiredAccess);
    [DllImport("kernel32", EntryPoint="CreateEventExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateEventEx(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpEventAttributes, char* lpName, int dwFlags, int dwDesiredAccess);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateEventExW(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpEventAttributes, [MarshalAs(UnmanagedType.LPWStr)] string lpName, int dwFlags, int dwDesiredAccess);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateEventExW(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpEventAttributes, char* lpName, int dwFlags, int dwDesiredAccess);
    [DllImport("kernel32", EntryPoint="CreateSemaphoreExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateSemaphoreEx(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, [MarshalAs(UnmanagedType.LPWStr)] string lpName, int dwFlags, int dwDesiredAccess);
    [DllImport("kernel32", EntryPoint="CreateSemaphoreExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateSemaphoreEx(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, char* lpName, int dwFlags, int dwDesiredAccess);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateSemaphoreExW(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, [MarshalAs(UnmanagedType.LPWStr)] string lpName, int dwFlags, int dwDesiredAccess);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateSemaphoreExW(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, char* lpName, int dwFlags, int dwDesiredAccess);
    [DllImport("kernel32", EntryPoint="CreateWaitableTimerExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateWaitableTimerEx(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpTimerAttributes, [MarshalAs(UnmanagedType.LPWStr)] string lpTimerName, int dwFlags, int dwDesiredAccess);
    [DllImport("kernel32", EntryPoint="CreateWaitableTimerExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateWaitableTimerEx(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpTimerAttributes, char* lpTimerName, int dwFlags, int dwDesiredAccess);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateWaitableTimerExW(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpTimerAttributes, [MarshalAs(UnmanagedType.LPWStr)] string lpTimerName, int dwFlags, int dwDesiredAccess);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateWaitableTimerExW(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpTimerAttributes, char* lpTimerName, int dwFlags, int dwDesiredAccess);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnterSynchronizationBarrier(cpointer unfoundType_LPSYNCHRONIZATION_BARRIER_lpBarrier, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int InitializeSynchronizationBarrier(cpointer unfoundType_LPSYNCHRONIZATION_BARRIER_lpBarrier, int lTotalThreads, int lSpinCount);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DeleteSynchronizationBarrier(cpointer unfoundType_LPSYNCHRONIZATION_BARRIER_lpBarrier);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void Sleep(int dwMilliseconds);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SignalObjectAndWait(cpointer hObjectToSignal, cpointer hObjectToWaitOn, int dwMilliseconds, int bAlertable);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WaitForMultipleObjects(int nCount, cpointer lpHandles, int bWaitAll, int dwMilliseconds);
    [DllImport("kernel32", EntryPoint="CreateSemaphoreW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateSemaphore(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport("kernel32", EntryPoint="CreateSemaphoreW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateSemaphore(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, char* lpName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateSemaphoreW(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateSemaphoreW(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, char* lpName);
    [DllImport("kernel32", EntryPoint="CreateWaitableTimerW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateWaitableTimer(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpTimerAttributes, int bManualReset, [MarshalAs(UnmanagedType.LPWStr)] string lpTimerName);
    [DllImport("kernel32", EntryPoint="CreateWaitableTimerW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateWaitableTimer(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpTimerAttributes, int bManualReset, char* lpTimerName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateWaitableTimerW(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpTimerAttributes, int bManualReset, [MarshalAs(UnmanagedType.LPWStr)] string lpTimerName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateWaitableTimerW(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpTimerAttributes, int bManualReset, char* lpTimerName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateThreadpool(cpointer reserved);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void SetThreadpoolThreadMaximum(cpointer unfoundType_PTP_POOL_ptpp, int cthrdMost);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetThreadpoolThreadMinimum(cpointer unfoundType_PTP_POOL_ptpp, int cthrdMic);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetThreadpoolStackInformation(cpointer unfoundType_PTP_POOL_ptpp, cpointer unfoundType_PTP_POOL_STACK_INFORMATION_ptpsi);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryThreadpoolStackInformation(cpointer unfoundType_PTP_POOL_ptpp, cpointer unfoundType_PTP_POOL_STACK_INFORMATION_ptpsi);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void CloseThreadpool(cpointer unfoundType_PTP_POOL_ptpp);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateThreadpoolCleanupGroup();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void CloseThreadpoolCleanupGroupMembers(cpointer unfoundType_PTP_CLEANUP_GROUP_ptpcg, int fCancelPendingCallbacks, cpointer pvCleanupContext);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void CloseThreadpoolCleanupGroup(cpointer unfoundType_PTP_CLEANUP_GROUP_ptpcg);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void SetEventWhenCallbackReturns(cpointer unfoundType_PTP_CALLBACK_INSTANCE_pci, cpointer evt);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void ReleaseSemaphoreWhenCallbackReturns(cpointer unfoundType_PTP_CALLBACK_INSTANCE_pci, cpointer sem, int crel);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void ReleaseMutexWhenCallbackReturns(cpointer unfoundType_PTP_CALLBACK_INSTANCE_pci, cpointer mut);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void LeaveCriticalSectionWhenCallbackReturns(cpointer unfoundType_PTP_CALLBACK_INSTANCE_pci, cpointer unfoundType_PCRITICAL_SECTION_pcs);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void FreeLibraryWhenCallbackReturns(cpointer unfoundType_PTP_CALLBACK_INSTANCE_pci, cpointer unfoundType_HMODULE_mod);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CallbackMayRunLong(cpointer unfoundType_PTP_CALLBACK_INSTANCE_pci);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void DisassociateCurrentThreadFromCallback(cpointer unfoundType_PTP_CALLBACK_INSTANCE_pci);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int TrySubmitThreadpoolCallback(cpointer unfoundType_PTP_SIMPLE_CALLBACK_pfns, cpointer pv, cpointer unfoundType_PTP_CALLBACK_ENVIRON_pcbe);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateThreadpoolWork(cpointer unfoundType_PTP_WORK_CALLBACK_pfnwk, cpointer pv, cpointer unfoundType_PTP_CALLBACK_ENVIRON_pcbe);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void SubmitThreadpoolWork(cpointer unfoundType_PTP_WORK_pwk);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void WaitForThreadpoolWorkCallbacks(cpointer unfoundType_PTP_WORK_pwk, int fCancelPendingCallbacks);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void CloseThreadpoolWork(cpointer unfoundType_PTP_WORK_pwk);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateThreadpoolTimer(cpointer unfoundType_PTP_TIMER_CALLBACK_pfnti, cpointer pv, cpointer unfoundType_PTP_CALLBACK_ENVIRON_pcbe);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void SetThreadpoolTimer(cpointer unfoundType_PTP_TIMER_pti, cpointer unfoundType_PFILETIME_pftDueTime, int msPeriod, int msWindowLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsThreadpoolTimerSet(cpointer unfoundType_PTP_TIMER_pti);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void WaitForThreadpoolTimerCallbacks(cpointer unfoundType_PTP_TIMER_pti, int fCancelPendingCallbacks);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void CloseThreadpoolTimer(cpointer unfoundType_PTP_TIMER_pti);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateThreadpoolWait(cpointer unfoundType_PTP_WAIT_CALLBACK_pfnwa, cpointer pv, cpointer unfoundType_PTP_CALLBACK_ENVIRON_pcbe);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void SetThreadpoolWait(cpointer unfoundType_PTP_WAIT_pwa, cpointer h, cpointer unfoundType_PFILETIME_pftTimeout);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void WaitForThreadpoolWaitCallbacks(cpointer unfoundType_PTP_WAIT_pwa, int fCancelPendingCallbacks);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void CloseThreadpoolWait(cpointer unfoundType_PTP_WAIT_pwa);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateThreadpoolIo(cpointer fl, cpointer unfoundType_PTP_WIN32_IO_CALLBACK_pfnio, cpointer pv, cpointer unfoundType_PTP_CALLBACK_ENVIRON_pcbe);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void StartThreadpoolIo(cpointer unfoundType_PTP_IO_pio);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void CancelThreadpoolIo(cpointer unfoundType_PTP_IO_pio);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void WaitForThreadpoolIoCallbacks(cpointer unfoundType_PTP_IO_pio, int fCancelPendingCallbacks);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void CloseThreadpoolIo(cpointer unfoundType_PTP_IO_pio);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetThreadpoolTimerEx(cpointer unfoundType_PTP_TIMER_pti, cpointer unfoundType_PFILETIME_pftDueTime, int msPeriod, int msWindowLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetThreadpoolWaitEx(cpointer unfoundType_PTP_WAIT_pwa, cpointer h, cpointer unfoundType_PFILETIME_pftTimeout, cpointer Reserved);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int QueueUserWorkItem(cpointer unfoundType_LPTHREAD_START_ROUTINE_Function, cpointer Context, uint Flags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int UnregisterWaitEx(cpointer WaitHandle, cpointer CompletionEvent);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateTimerQueue();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateTimerQueueTimer(cpointer unfoundType_PHANDLE_phNewTimer, cpointer TimerQueue, cpointer unfoundType_WAITORTIMERCALLBACK_Callback, cpointer Parameter, int DueTime, int Period, uint Flags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ChangeTimerQueueTimer(cpointer TimerQueue, cpointer Timer, uint DueTime, uint Period);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DeleteTimerQueueTimer(cpointer TimerQueue, cpointer Timer, cpointer CompletionEvent);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DeleteTimerQueue(cpointer TimerQueue);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DeleteTimerQueueEx(cpointer TimerQueue, cpointer CompletionEvent);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GlobalMemoryStatusEx(cpointer unfoundType_LPMEMORYSTATUSEX_lpBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void GetSystemInfo(cpointer unfoundType_LPSYSTEM_INFO_lpSystemInfo);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void GetSystemTime(cpointer unfoundType_LPSYSTEMTIME_lpSystemTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void GetSystemTimeAsFileTime(cpointer unfoundType_LPFILETIME_lpSystemTimeAsFileTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void GetLocalTime(cpointer unfoundType_LPSYSTEMTIME_lpSystemTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsUserCetAvailableInEnvironment(int UserCetEnvironment);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVersion();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetLocalTime(cpointer unfoundType_SYSTEMTIME_lpSystemTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTickCount();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetTickCount64();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetSystemTimeAdjustment(cpointer unfoundType_PDWORD_lpTimeAdjustment, cpointer unfoundType_PDWORD_lpTimeIncrement, cpointer lpTimeAdjustmentDisabled);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetSystemDirectoryA([MarshalAs(UnmanagedType.LPStr)] string lpBuffer, uint uSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetSystemDirectoryA(ReadOnlySpan<byte> lpBuffer, uint uSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetSystemDirectoryA(byte* lpBuffer, uint uSize);
    [DllImport("kernel32", EntryPoint="GetSystemDirectoryW", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetSystemDirectory(string lpBuffer, uint uSize);
    [DllImport("kernel32", EntryPoint="GetSystemDirectoryW", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetSystemDirectory(char* lpBuffer, uint uSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetSystemDirectoryW(string lpBuffer, uint uSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetSystemDirectoryW(char* lpBuffer, uint uSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetWindowsDirectoryA([MarshalAs(UnmanagedType.LPStr)] string lpBuffer, uint uSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetWindowsDirectoryA(ReadOnlySpan<byte> lpBuffer, uint uSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetWindowsDirectoryA(byte* lpBuffer, uint uSize);
    [DllImport("kernel32", EntryPoint="GetWindowsDirectoryW", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetWindowsDirectory(string lpBuffer, uint uSize);
    [DllImport("kernel32", EntryPoint="GetWindowsDirectoryW", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetWindowsDirectory(char* lpBuffer, uint uSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetWindowsDirectoryW(string lpBuffer, uint uSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetWindowsDirectoryW(char* lpBuffer, uint uSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetSystemWindowsDirectoryA([MarshalAs(UnmanagedType.LPStr)] string lpBuffer, uint uSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetSystemWindowsDirectoryA(ReadOnlySpan<byte> lpBuffer, uint uSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetSystemWindowsDirectoryA(byte* lpBuffer, uint uSize);
    [DllImport("kernel32", EntryPoint="GetSystemWindowsDirectoryW", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetSystemWindowsDirectory(string lpBuffer, uint uSize);
    [DllImport("kernel32", EntryPoint="GetSystemWindowsDirectoryW", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetSystemWindowsDirectory(char* lpBuffer, uint uSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetSystemWindowsDirectoryW(string lpBuffer, uint uSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetSystemWindowsDirectoryW(char* lpBuffer, uint uSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetComputerNameExA(cpointer unfoundType_COMPUTER_NAME_FORMAT_NameType, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, cpointer unfoundType_LPDWORD_nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetComputerNameExA(cpointer unfoundType_COMPUTER_NAME_FORMAT_NameType, ReadOnlySpan<byte> lpBuffer, cpointer unfoundType_LPDWORD_nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetComputerNameExA(cpointer unfoundType_COMPUTER_NAME_FORMAT_NameType, byte* lpBuffer, cpointer unfoundType_LPDWORD_nSize);
    [DllImport("kernel32", EntryPoint="GetComputerNameExW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetComputerNameEx(cpointer unfoundType_COMPUTER_NAME_FORMAT_NameType, string lpBuffer, cpointer unfoundType_LPDWORD_nSize);
    [DllImport("kernel32", EntryPoint="GetComputerNameExW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetComputerNameEx(cpointer unfoundType_COMPUTER_NAME_FORMAT_NameType, char* lpBuffer, cpointer unfoundType_LPDWORD_nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetComputerNameExW(cpointer unfoundType_COMPUTER_NAME_FORMAT_NameType, string lpBuffer, cpointer unfoundType_LPDWORD_nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetComputerNameExW(cpointer unfoundType_COMPUTER_NAME_FORMAT_NameType, char* lpBuffer, cpointer unfoundType_LPDWORD_nSize);
    [DllImport("kernel32", EntryPoint="SetComputerNameExW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetComputerNameEx(cpointer unfoundType_COMPUTER_NAME_FORMAT_NameType, [MarshalAs(UnmanagedType.LPWStr)] string lpBuffer);
    [DllImport("kernel32", EntryPoint="SetComputerNameExW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetComputerNameEx(cpointer unfoundType_COMPUTER_NAME_FORMAT_NameType, char* lpBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetComputerNameExW(cpointer unfoundType_COMPUTER_NAME_FORMAT_NameType, [MarshalAs(UnmanagedType.LPWStr)] string lpBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetComputerNameExW(cpointer unfoundType_COMPUTER_NAME_FORMAT_NameType, char* lpBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetSystemTime(cpointer unfoundType_SYSTEMTIME_lpSystemTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVersionExA(cpointer unfoundType_LPOSVERSIONINFOA_lpVersionInformation);
    [DllImport("kernel32", EntryPoint="GetVersionExW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVersionEx(cpointer unfoundType_LPOSVERSIONINFOW_lpVersionInformation);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVersionExW(cpointer unfoundType_LPOSVERSIONINFOW_lpVersionInformation);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLogicalProcessorInformation(cpointer unfoundType_PSYSTEM_LOGICAL_PROCESSOR_INFORMATION_Buffer, cpointer unfoundType_PDWORD_ReturnedLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLogicalProcessorInformationEx(cpointer unfoundType_LOGICAL_PROCESSOR_RELATIONSHIP_RelationshipType, cpointer unfoundType_PSYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX_Buffer, cpointer unfoundType_PDWORD_ReturnedLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void GetNativeSystemInfo(cpointer unfoundType_LPSYSTEM_INFO_lpSystemInfo);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void GetSystemTimePreciseAsFileTime(cpointer unfoundType_LPFILETIME_lpSystemTimeAsFileTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProductInfo(int dwOSMajorVersion, int dwOSMinorVersion, int dwSpMajorVersion, int dwSpMinorVersion, cpointer unfoundType_PDWORD_pdwReturnedProductType);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer VerSetConditionMask(cpointer unfoundType_ULONGLONG_ConditionMask, uint TypeMask, byte Condition);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint EnumSystemFirmwareTables(int FirmwareTableProviderSignature, cpointer pFirmwareTableEnumBuffer, int BufferSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetSystemFirmwareTable(int FirmwareTableProviderSignature, int FirmwareTableID, cpointer pFirmwareTableBuffer, int BufferSize);
    [DllImport("kernel32", EntryPoint="DnsHostnameToComputerNameExW", SetLastError=true, ExactSpelling=true)] public static extern
        int DnsHostnameToComputerNameEx([MarshalAs(UnmanagedType.LPWStr)] string Hostname, string ComputerName, cpointer unfoundType_LPDWORD_nSize);
    [DllImport("kernel32", EntryPoint="DnsHostnameToComputerNameExW", SetLastError=true, ExactSpelling=true)] public static extern
        int DnsHostnameToComputerNameEx([MarshalAs(UnmanagedType.LPWStr)] string Hostname, char* ComputerName, cpointer unfoundType_LPDWORD_nSize);
    [DllImport("kernel32", EntryPoint="DnsHostnameToComputerNameExW", SetLastError=true, ExactSpelling=true)] public static extern
        int DnsHostnameToComputerNameEx(char* Hostname, string ComputerName, cpointer unfoundType_LPDWORD_nSize);
    [DllImport("kernel32", EntryPoint="DnsHostnameToComputerNameExW", SetLastError=true, ExactSpelling=true)] public static extern
        int DnsHostnameToComputerNameEx(char* Hostname, char* ComputerName, cpointer unfoundType_LPDWORD_nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DnsHostnameToComputerNameExW([MarshalAs(UnmanagedType.LPWStr)] string Hostname, string ComputerName, cpointer unfoundType_LPDWORD_nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DnsHostnameToComputerNameExW([MarshalAs(UnmanagedType.LPWStr)] string Hostname, char* ComputerName, cpointer unfoundType_LPDWORD_nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DnsHostnameToComputerNameExW(char* Hostname, string ComputerName, cpointer unfoundType_LPDWORD_nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DnsHostnameToComputerNameExW(char* Hostname, char* ComputerName, cpointer unfoundType_LPDWORD_nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPhysicallyInstalledSystemMemory(cpointer unfoundType_PULONGLONG_TotalMemoryInKilobytes);
    [DllImport("kernel32", EntryPoint="SetComputerNameEx2W", SetLastError=true, ExactSpelling=true)] public static extern
        int SetComputerNameEx2(cpointer unfoundType_COMPUTER_NAME_FORMAT_NameType, int Flags, [MarshalAs(UnmanagedType.LPWStr)] string lpBuffer);
    [DllImport("kernel32", EntryPoint="SetComputerNameEx2W", SetLastError=true, ExactSpelling=true)] public static extern
        int SetComputerNameEx2(cpointer unfoundType_COMPUTER_NAME_FORMAT_NameType, int Flags, char* lpBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetComputerNameEx2W(cpointer unfoundType_COMPUTER_NAME_FORMAT_NameType, int Flags, [MarshalAs(UnmanagedType.LPWStr)] string lpBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetComputerNameEx2W(cpointer unfoundType_COMPUTER_NAME_FORMAT_NameType, int Flags, char* lpBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetSystemTimeAdjustment(int dwTimeAdjustment, int bTimeAdjustmentDisabled);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int InstallELAMCertificateInfo(cpointer ELAMFile);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProcessorSystemCycleTime(ushort Group, cpointer unfoundType_PSYSTEM_PROCESSOR_CYCLE_TIME_INFORMATION_Buffer, cpointer unfoundType_PDWORD_ReturnedLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetComputerNameA(cpointer unfoundType_LPCSTR_lpComputerName);
    [DllImport("kernel32", EntryPoint="SetComputerNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetComputerName([MarshalAs(UnmanagedType.LPWStr)] string lpComputerName);
    [DllImport("kernel32", EntryPoint="SetComputerNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetComputerName(char* lpComputerName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetComputerNameW([MarshalAs(UnmanagedType.LPWStr)] string lpComputerName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetComputerNameW(char* lpComputerName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetComputerNameExA(cpointer unfoundType_COMPUTER_NAME_FORMAT_NameType, cpointer unfoundType_LPCSTR_lpBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer timeGetSystemTime(cpointer unfoundType_LPMMTIME_pmmt, uint cbmmt);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int timeGetTime();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer timeGetDevCaps(cpointer unfoundType_LPTIMECAPS_ptc, uint cbtc);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer timeBeginPeriod(uint uPeriod);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer timeEndPeriod(uint uPeriod);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SystemTimeToTzSpecificLocalTime(cpointer unfoundType_TIME_ZONE_INFORMATION_lpTimeZoneInformation, cpointer unfoundType_SYSTEMTIME_lpUniversalTime, cpointer unfoundType_LPSYSTEMTIME_lpLocalTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int TzSpecificLocalTimeToSystemTime(cpointer unfoundType_TIME_ZONE_INFORMATION_lpTimeZoneInformation, cpointer unfoundType_SYSTEMTIME_lpLocalTime, cpointer unfoundType_LPSYSTEMTIME_lpUniversalTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FileTimeToSystemTime(cpointer unfoundType_FILETIME_lpFileTime, cpointer unfoundType_LPSYSTEMTIME_lpSystemTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SystemTimeToFileTime(cpointer unfoundType_SYSTEMTIME_lpSystemTime, cpointer unfoundType_LPFILETIME_lpFileTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTimeZoneInformation(cpointer unfoundType_LPTIME_ZONE_INFORMATION_lpTimeZoneInformation);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetTimeZoneInformation(cpointer unfoundType_TIME_ZONE_INFORMATION_lpTimeZoneInformation);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetDynamicTimeZoneInformation(cpointer unfoundType_DYNAMIC_TIME_ZONE_INFORMATION_lpTimeZoneInformation);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDynamicTimeZoneInformation(cpointer unfoundType_PDYNAMIC_TIME_ZONE_INFORMATION_pTimeZoneInformation);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTimeZoneInformationForYear(ushort wYear, cpointer unfoundType_PDYNAMIC_TIME_ZONE_INFORMATION_pdtzi, cpointer unfoundType_LPTIME_ZONE_INFORMATION_ptzi);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SystemTimeToTzSpecificLocalTimeEx(cpointer unfoundType_DYNAMIC_TIME_ZONE_INFORMATION_lpTimeZoneInformation, cpointer unfoundType_SYSTEMTIME_lpUniversalTime, cpointer unfoundType_LPSYSTEMTIME_lpLocalTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int TzSpecificLocalTimeToSystemTimeEx(cpointer unfoundType_DYNAMIC_TIME_ZONE_INFORMATION_lpTimeZoneInformation, cpointer unfoundType_SYSTEMTIME_lpLocalTime, cpointer unfoundType_LPSYSTEMTIME_lpUniversalTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int LocalFileTimeToLocalSystemTime(cpointer unfoundType_TIME_ZONE_INFORMATION_timeZoneInformation, cpointer unfoundType_FILETIME_localFileTime, cpointer unfoundType_SYSTEMTIME_localSystemTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int LocalSystemTimeToLocalFileTime(cpointer unfoundType_TIME_ZONE_INFORMATION_timeZoneInformation, cpointer unfoundType_SYSTEMTIME_localSystemTime, cpointer unfoundType_FILETIME_localFileTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateToolhelp32Snapshot(int dwFlags, int th32ProcessID);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int Heap32ListFirst(cpointer hSnapshot, cpointer unfoundType_LPHEAPLIST32_lphl);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int Heap32ListNext(cpointer hSnapshot, cpointer unfoundType_LPHEAPLIST32_lphl);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int Heap32First(cpointer unfoundType_LPHEAPENTRY32_lphe, int th32ProcessID, cpointer unfoundType_ULONG_PTR_th32HeapID);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int Heap32Next(cpointer unfoundType_LPHEAPENTRY32_lphe);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int Toolhelp32ReadProcessMemory(int th32ProcessID, cpointer lpBaseAddress, cpointer lpBuffer, cpointer cbRead, cpointer lpNumberOfBytesRead);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int Process32FirstW(cpointer hSnapshot, cpointer unfoundType_LPPROCESSENTRY32W_lppe);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int Process32NextW(cpointer hSnapshot, cpointer unfoundType_LPPROCESSENTRY32W_lppe);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int Process32First(cpointer hSnapshot, cpointer unfoundType_LPPROCESSENTRY32_lppe);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int Process32Next(cpointer hSnapshot, cpointer unfoundType_LPPROCESSENTRY32_lppe);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int Thread32First(cpointer hSnapshot, cpointer unfoundType_LPTHREADENTRY32_lpte);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int Thread32Next(cpointer hSnapshot, cpointer unfoundType_LPTHREADENTRY32_lpte);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int Module32FirstW(cpointer hSnapshot, cpointer unfoundType_LPMODULEENTRY32W_lpme);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int Module32NextW(cpointer hSnapshot, cpointer unfoundType_LPMODULEENTRY32W_lpme);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int Module32First(cpointer hSnapshot, cpointer unfoundType_LPMODULEENTRY32_lpme);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int Module32Next(cpointer hSnapshot, cpointer unfoundType_LPMODULEENTRY32_lpme);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer EncodePointer(cpointer Ptr);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer DecodePointer(cpointer Ptr);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer EncodeSystemPointer(cpointer Ptr);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer DecodeSystemPointer(cpointer Ptr);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int Beep(int dwFreq, int dwDuration);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CeipIsOptedIn();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegCloseKey(nint hKey);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegOpenUserClassesRoot(cpointer hToken, int dwOptions, cpointer unfoundType_REGSAM_samDesired, cpointer phkResult);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegOpenCurrentUser(cpointer unfoundType_REGSAM_samDesired, cpointer phkResult);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegDisablePredefinedCacheEx();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegCreateKeyExA(nint hKey, cpointer unfoundType_LPCSTR_lpSubKey, int Reserved, [MarshalAs(UnmanagedType.LPStr)] string lpClass, int dwOptions, cpointer unfoundType_REGSAM_samDesired, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer phkResult, cpointer unfoundType_LPDWORD_lpdwDisposition);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegCreateKeyExA(nint hKey, cpointer unfoundType_LPCSTR_lpSubKey, int Reserved, ReadOnlySpan<byte> lpClass, int dwOptions, cpointer unfoundType_REGSAM_samDesired, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer phkResult, cpointer unfoundType_LPDWORD_lpdwDisposition);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegCreateKeyExA(nint hKey, cpointer unfoundType_LPCSTR_lpSubKey, int Reserved, byte* lpClass, int dwOptions, cpointer unfoundType_REGSAM_samDesired, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer phkResult, cpointer unfoundType_LPDWORD_lpdwDisposition);
    [DllImport("kernel32", EntryPoint="RegCreateKeyExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegCreateKeyEx(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, int Reserved, string lpClass, int dwOptions, cpointer unfoundType_REGSAM_samDesired, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer phkResult, cpointer unfoundType_LPDWORD_lpdwDisposition);
    [DllImport("kernel32", EntryPoint="RegCreateKeyExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegCreateKeyEx(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, int Reserved, char* lpClass, int dwOptions, cpointer unfoundType_REGSAM_samDesired, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer phkResult, cpointer unfoundType_LPDWORD_lpdwDisposition);
    [DllImport("kernel32", EntryPoint="RegCreateKeyExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegCreateKeyEx(nint hKey, char* lpSubKey, int Reserved, string lpClass, int dwOptions, cpointer unfoundType_REGSAM_samDesired, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer phkResult, cpointer unfoundType_LPDWORD_lpdwDisposition);
    [DllImport("kernel32", EntryPoint="RegCreateKeyExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegCreateKeyEx(nint hKey, char* lpSubKey, int Reserved, char* lpClass, int dwOptions, cpointer unfoundType_REGSAM_samDesired, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer phkResult, cpointer unfoundType_LPDWORD_lpdwDisposition);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegCreateKeyExW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, int Reserved, string lpClass, int dwOptions, cpointer unfoundType_REGSAM_samDesired, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer phkResult, cpointer unfoundType_LPDWORD_lpdwDisposition);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegCreateKeyExW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, int Reserved, char* lpClass, int dwOptions, cpointer unfoundType_REGSAM_samDesired, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer phkResult, cpointer unfoundType_LPDWORD_lpdwDisposition);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegCreateKeyExW(nint hKey, char* lpSubKey, int Reserved, string lpClass, int dwOptions, cpointer unfoundType_REGSAM_samDesired, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer phkResult, cpointer unfoundType_LPDWORD_lpdwDisposition);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegCreateKeyExW(nint hKey, char* lpSubKey, int Reserved, char* lpClass, int dwOptions, cpointer unfoundType_REGSAM_samDesired, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer phkResult, cpointer unfoundType_LPDWORD_lpdwDisposition);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegDeleteKeyExA(nint hKey, cpointer unfoundType_LPCSTR_lpSubKey, cpointer unfoundType_REGSAM_samDesired, int Reserved);
    [DllImport("kernel32", EntryPoint="RegDeleteKeyExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegDeleteKeyEx(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, cpointer unfoundType_REGSAM_samDesired, int Reserved);
    [DllImport("kernel32", EntryPoint="RegDeleteKeyExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegDeleteKeyEx(nint hKey, char* lpSubKey, cpointer unfoundType_REGSAM_samDesired, int Reserved);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegDeleteKeyExW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, cpointer unfoundType_REGSAM_samDesired, int Reserved);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegDeleteKeyExW(nint hKey, char* lpSubKey, cpointer unfoundType_REGSAM_samDesired, int Reserved);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegDeleteValueA(nint hKey, cpointer unfoundType_LPCSTR_lpValueName);
    [DllImport("kernel32", EntryPoint="RegDeleteValueW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegDeleteValue(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpValueName);
    [DllImport("kernel32", EntryPoint="RegDeleteValueW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegDeleteValue(nint hKey, char* lpValueName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegDeleteValueW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpValueName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegDeleteValueW(nint hKey, char* lpValueName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegEnumKeyExA(nint hKey, int dwIndex, [MarshalAs(UnmanagedType.LPStr)] string lpName, cpointer unfoundType_LPDWORD_lpcchName, cpointer unfoundType_LPDWORD_lpReserved, [MarshalAs(UnmanagedType.LPStr)] string lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegEnumKeyExA(nint hKey, int dwIndex, [MarshalAs(UnmanagedType.LPStr)] string lpName, cpointer unfoundType_LPDWORD_lpcchName, cpointer unfoundType_LPDWORD_lpReserved, ReadOnlySpan<byte> lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegEnumKeyExA(nint hKey, int dwIndex, [MarshalAs(UnmanagedType.LPStr)] string lpName, cpointer unfoundType_LPDWORD_lpcchName, cpointer unfoundType_LPDWORD_lpReserved, byte* lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegEnumKeyExA(nint hKey, int dwIndex, ReadOnlySpan<byte> lpName, cpointer unfoundType_LPDWORD_lpcchName, cpointer unfoundType_LPDWORD_lpReserved, [MarshalAs(UnmanagedType.LPStr)] string lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegEnumKeyExA(nint hKey, int dwIndex, ReadOnlySpan<byte> lpName, cpointer unfoundType_LPDWORD_lpcchName, cpointer unfoundType_LPDWORD_lpReserved, ReadOnlySpan<byte> lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegEnumKeyExA(nint hKey, int dwIndex, ReadOnlySpan<byte> lpName, cpointer unfoundType_LPDWORD_lpcchName, cpointer unfoundType_LPDWORD_lpReserved, byte* lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegEnumKeyExA(nint hKey, int dwIndex, byte* lpName, cpointer unfoundType_LPDWORD_lpcchName, cpointer unfoundType_LPDWORD_lpReserved, [MarshalAs(UnmanagedType.LPStr)] string lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegEnumKeyExA(nint hKey, int dwIndex, byte* lpName, cpointer unfoundType_LPDWORD_lpcchName, cpointer unfoundType_LPDWORD_lpReserved, ReadOnlySpan<byte> lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegEnumKeyExA(nint hKey, int dwIndex, byte* lpName, cpointer unfoundType_LPDWORD_lpcchName, cpointer unfoundType_LPDWORD_lpReserved, byte* lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport("kernel32", EntryPoint="RegEnumKeyExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegEnumKeyEx(nint hKey, int dwIndex, string lpName, cpointer unfoundType_LPDWORD_lpcchName, cpointer unfoundType_LPDWORD_lpReserved, string lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport("kernel32", EntryPoint="RegEnumKeyExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegEnumKeyEx(nint hKey, int dwIndex, string lpName, cpointer unfoundType_LPDWORD_lpcchName, cpointer unfoundType_LPDWORD_lpReserved, char* lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport("kernel32", EntryPoint="RegEnumKeyExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegEnumKeyEx(nint hKey, int dwIndex, char* lpName, cpointer unfoundType_LPDWORD_lpcchName, cpointer unfoundType_LPDWORD_lpReserved, string lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport("kernel32", EntryPoint="RegEnumKeyExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegEnumKeyEx(nint hKey, int dwIndex, char* lpName, cpointer unfoundType_LPDWORD_lpcchName, cpointer unfoundType_LPDWORD_lpReserved, char* lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegEnumKeyExW(nint hKey, int dwIndex, string lpName, cpointer unfoundType_LPDWORD_lpcchName, cpointer unfoundType_LPDWORD_lpReserved, string lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegEnumKeyExW(nint hKey, int dwIndex, string lpName, cpointer unfoundType_LPDWORD_lpcchName, cpointer unfoundType_LPDWORD_lpReserved, char* lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegEnumKeyExW(nint hKey, int dwIndex, char* lpName, cpointer unfoundType_LPDWORD_lpcchName, cpointer unfoundType_LPDWORD_lpReserved, string lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegEnumKeyExW(nint hKey, int dwIndex, char* lpName, cpointer unfoundType_LPDWORD_lpcchName, cpointer unfoundType_LPDWORD_lpReserved, char* lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegEnumValueA(nint hKey, int dwIndex, [MarshalAs(UnmanagedType.LPStr)] string lpValueName, cpointer unfoundType_LPDWORD_lpcchValueName, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPDWORD_lpType, cpointer unfoundType_LPBYTE_lpData, cpointer unfoundType_LPDWORD_lpcbData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegEnumValueA(nint hKey, int dwIndex, ReadOnlySpan<byte> lpValueName, cpointer unfoundType_LPDWORD_lpcchValueName, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPDWORD_lpType, cpointer unfoundType_LPBYTE_lpData, cpointer unfoundType_LPDWORD_lpcbData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegEnumValueA(nint hKey, int dwIndex, byte* lpValueName, cpointer unfoundType_LPDWORD_lpcchValueName, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPDWORD_lpType, cpointer unfoundType_LPBYTE_lpData, cpointer unfoundType_LPDWORD_lpcbData);
    [DllImport("kernel32", EntryPoint="RegEnumValueW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegEnumValue(nint hKey, int dwIndex, string lpValueName, cpointer unfoundType_LPDWORD_lpcchValueName, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPDWORD_lpType, cpointer unfoundType_LPBYTE_lpData, cpointer unfoundType_LPDWORD_lpcbData);
    [DllImport("kernel32", EntryPoint="RegEnumValueW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegEnumValue(nint hKey, int dwIndex, char* lpValueName, cpointer unfoundType_LPDWORD_lpcchValueName, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPDWORD_lpType, cpointer unfoundType_LPBYTE_lpData, cpointer unfoundType_LPDWORD_lpcbData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegEnumValueW(nint hKey, int dwIndex, string lpValueName, cpointer unfoundType_LPDWORD_lpcchValueName, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPDWORD_lpType, cpointer unfoundType_LPBYTE_lpData, cpointer unfoundType_LPDWORD_lpcbData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegEnumValueW(nint hKey, int dwIndex, char* lpValueName, cpointer unfoundType_LPDWORD_lpcchValueName, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPDWORD_lpType, cpointer unfoundType_LPBYTE_lpData, cpointer unfoundType_LPDWORD_lpcbData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegFlushKey(nint hKey);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegGetKeySecurity(nint hKey, cpointer unfoundType_SECURITY_INFORMATION_SecurityInformation, cpointer unfoundType_PSECURITY_DESCRIPTOR_pSecurityDescriptor, cpointer unfoundType_LPDWORD_lpcbSecurityDescriptor);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegLoadKeyA(nint hKey, cpointer unfoundType_LPCSTR_lpSubKey, cpointer unfoundType_LPCSTR_lpFile);
    [DllImport("kernel32", EntryPoint="RegLoadKeyW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegLoadKey(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, [MarshalAs(UnmanagedType.LPWStr)] string lpFile);
    [DllImport("kernel32", EntryPoint="RegLoadKeyW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegLoadKey(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, char* lpFile);
    [DllImport("kernel32", EntryPoint="RegLoadKeyW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegLoadKey(nint hKey, char* lpSubKey, [MarshalAs(UnmanagedType.LPWStr)] string lpFile);
    [DllImport("kernel32", EntryPoint="RegLoadKeyW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegLoadKey(nint hKey, char* lpSubKey, char* lpFile);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegLoadKeyW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, [MarshalAs(UnmanagedType.LPWStr)] string lpFile);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegLoadKeyW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, char* lpFile);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegLoadKeyW(nint hKey, char* lpSubKey, [MarshalAs(UnmanagedType.LPWStr)] string lpFile);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegLoadKeyW(nint hKey, char* lpSubKey, char* lpFile);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegNotifyChangeKeyValue(nint hKey, int bWatchSubtree, int dwNotifyFilter, cpointer hEvent, int fAsynchronous);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegOpenKeyExA(nint hKey, cpointer unfoundType_LPCSTR_lpSubKey, int ulOptions, cpointer unfoundType_REGSAM_samDesired, cpointer phkResult);
    [DllImport("kernel32", EntryPoint="RegOpenKeyExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegOpenKeyEx(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, int ulOptions, cpointer unfoundType_REGSAM_samDesired, cpointer phkResult);
    [DllImport("kernel32", EntryPoint="RegOpenKeyExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegOpenKeyEx(nint hKey, char* lpSubKey, int ulOptions, cpointer unfoundType_REGSAM_samDesired, cpointer phkResult);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegOpenKeyExW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, int ulOptions, cpointer unfoundType_REGSAM_samDesired, cpointer phkResult);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegOpenKeyExW(nint hKey, char* lpSubKey, int ulOptions, cpointer unfoundType_REGSAM_samDesired, cpointer phkResult);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegQueryInfoKeyA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPDWORD_lpcSubKeys, cpointer unfoundType_LPDWORD_lpcbMaxSubKeyLen, cpointer unfoundType_LPDWORD_lpcbMaxClassLen, cpointer unfoundType_LPDWORD_lpcValues, cpointer unfoundType_LPDWORD_lpcbMaxValueNameLen, cpointer unfoundType_LPDWORD_lpcbMaxValueLen, cpointer unfoundType_LPDWORD_lpcbSecurityDescriptor, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegQueryInfoKeyA(nint hKey, ReadOnlySpan<byte> lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPDWORD_lpcSubKeys, cpointer unfoundType_LPDWORD_lpcbMaxSubKeyLen, cpointer unfoundType_LPDWORD_lpcbMaxClassLen, cpointer unfoundType_LPDWORD_lpcValues, cpointer unfoundType_LPDWORD_lpcbMaxValueNameLen, cpointer unfoundType_LPDWORD_lpcbMaxValueLen, cpointer unfoundType_LPDWORD_lpcbSecurityDescriptor, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegQueryInfoKeyA(nint hKey, byte* lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPDWORD_lpcSubKeys, cpointer unfoundType_LPDWORD_lpcbMaxSubKeyLen, cpointer unfoundType_LPDWORD_lpcbMaxClassLen, cpointer unfoundType_LPDWORD_lpcValues, cpointer unfoundType_LPDWORD_lpcbMaxValueNameLen, cpointer unfoundType_LPDWORD_lpcbMaxValueLen, cpointer unfoundType_LPDWORD_lpcbSecurityDescriptor, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport("kernel32", EntryPoint="RegQueryInfoKeyW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegQueryInfoKey(nint hKey, string lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPDWORD_lpcSubKeys, cpointer unfoundType_LPDWORD_lpcbMaxSubKeyLen, cpointer unfoundType_LPDWORD_lpcbMaxClassLen, cpointer unfoundType_LPDWORD_lpcValues, cpointer unfoundType_LPDWORD_lpcbMaxValueNameLen, cpointer unfoundType_LPDWORD_lpcbMaxValueLen, cpointer unfoundType_LPDWORD_lpcbSecurityDescriptor, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport("kernel32", EntryPoint="RegQueryInfoKeyW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegQueryInfoKey(nint hKey, char* lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPDWORD_lpcSubKeys, cpointer unfoundType_LPDWORD_lpcbMaxSubKeyLen, cpointer unfoundType_LPDWORD_lpcbMaxClassLen, cpointer unfoundType_LPDWORD_lpcValues, cpointer unfoundType_LPDWORD_lpcbMaxValueNameLen, cpointer unfoundType_LPDWORD_lpcbMaxValueLen, cpointer unfoundType_LPDWORD_lpcbSecurityDescriptor, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegQueryInfoKeyW(nint hKey, string lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPDWORD_lpcSubKeys, cpointer unfoundType_LPDWORD_lpcbMaxSubKeyLen, cpointer unfoundType_LPDWORD_lpcbMaxClassLen, cpointer unfoundType_LPDWORD_lpcValues, cpointer unfoundType_LPDWORD_lpcbMaxValueNameLen, cpointer unfoundType_LPDWORD_lpcbMaxValueLen, cpointer unfoundType_LPDWORD_lpcbSecurityDescriptor, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegQueryInfoKeyW(nint hKey, char* lpClass, cpointer unfoundType_LPDWORD_lpcchClass, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPDWORD_lpcSubKeys, cpointer unfoundType_LPDWORD_lpcbMaxSubKeyLen, cpointer unfoundType_LPDWORD_lpcbMaxClassLen, cpointer unfoundType_LPDWORD_lpcValues, cpointer unfoundType_LPDWORD_lpcbMaxValueNameLen, cpointer unfoundType_LPDWORD_lpcbMaxValueLen, cpointer unfoundType_LPDWORD_lpcbSecurityDescriptor, cpointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegQueryValueExA(nint hKey, cpointer unfoundType_LPCSTR_lpValueName, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPDWORD_lpType, cpointer unfoundType_LPBYTE_lpData, cpointer unfoundType_LPDWORD_lpcbData);
    [DllImport("kernel32", EntryPoint="RegQueryValueExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegQueryValueEx(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpValueName, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPDWORD_lpType, cpointer unfoundType_LPBYTE_lpData, cpointer unfoundType_LPDWORD_lpcbData);
    [DllImport("kernel32", EntryPoint="RegQueryValueExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegQueryValueEx(nint hKey, char* lpValueName, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPDWORD_lpType, cpointer unfoundType_LPBYTE_lpData, cpointer unfoundType_LPDWORD_lpcbData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegQueryValueExW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpValueName, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPDWORD_lpType, cpointer unfoundType_LPBYTE_lpData, cpointer unfoundType_LPDWORD_lpcbData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegQueryValueExW(nint hKey, char* lpValueName, cpointer unfoundType_LPDWORD_lpReserved, cpointer unfoundType_LPDWORD_lpType, cpointer unfoundType_LPBYTE_lpData, cpointer unfoundType_LPDWORD_lpcbData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegRestoreKeyA(nint hKey, cpointer unfoundType_LPCSTR_lpFile, int dwFlags);
    [DllImport("kernel32", EntryPoint="RegRestoreKeyW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegRestoreKey(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpFile, int dwFlags);
    [DllImport("kernel32", EntryPoint="RegRestoreKeyW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegRestoreKey(nint hKey, char* lpFile, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegRestoreKeyW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpFile, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegRestoreKeyW(nint hKey, char* lpFile, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegSetKeySecurity(nint hKey, cpointer unfoundType_SECURITY_INFORMATION_SecurityInformation, cpointer unfoundType_PSECURITY_DESCRIPTOR_pSecurityDescriptor);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegSetValueExA(nint hKey, cpointer unfoundType_LPCSTR_lpValueName, int Reserved, int dwType, cpointer lpData, int cbData);
    [DllImport("kernel32", EntryPoint="RegSetValueExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegSetValueEx(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpValueName, int Reserved, int dwType, cpointer lpData, int cbData);
    [DllImport("kernel32", EntryPoint="RegSetValueExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegSetValueEx(nint hKey, char* lpValueName, int Reserved, int dwType, cpointer lpData, int cbData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegSetValueExW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpValueName, int Reserved, int dwType, cpointer lpData, int cbData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegSetValueExW(nint hKey, char* lpValueName, int Reserved, int dwType, cpointer lpData, int cbData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegUnLoadKeyA(nint hKey, cpointer unfoundType_LPCSTR_lpSubKey);
    [DllImport("kernel32", EntryPoint="RegUnLoadKeyW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegUnLoadKey(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey);
    [DllImport("kernel32", EntryPoint="RegUnLoadKeyW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegUnLoadKey(nint hKey, char* lpSubKey);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegUnLoadKeyW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegUnLoadKeyW(nint hKey, char* lpSubKey);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegDeleteTreeA(nint hKey, cpointer unfoundType_LPCSTR_lpSubKey);
    [DllImport("kernel32", EntryPoint="RegDeleteTreeW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegDeleteTree(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey);
    [DllImport("kernel32", EntryPoint="RegDeleteTreeW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegDeleteTree(nint hKey, char* lpSubKey);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegDeleteTreeW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegDeleteTreeW(nint hKey, char* lpSubKey);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegGetValueA(nint hkey, cpointer unfoundType_LPCSTR_lpSubKey, cpointer unfoundType_LPCSTR_lpValue, int dwFlags, cpointer unfoundType_LPDWORD_pdwType, cpointer pvData, cpointer unfoundType_LPDWORD_pcbData);
    [DllImport("kernel32", EntryPoint="RegGetValueW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegGetValue(nint hkey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, int dwFlags, cpointer unfoundType_LPDWORD_pdwType, cpointer pvData, cpointer unfoundType_LPDWORD_pcbData);
    [DllImport("kernel32", EntryPoint="RegGetValueW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegGetValue(nint hkey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, char* lpValue, int dwFlags, cpointer unfoundType_LPDWORD_pdwType, cpointer pvData, cpointer unfoundType_LPDWORD_pcbData);
    [DllImport("kernel32", EntryPoint="RegGetValueW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegGetValue(nint hkey, char* lpSubKey, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, int dwFlags, cpointer unfoundType_LPDWORD_pdwType, cpointer pvData, cpointer unfoundType_LPDWORD_pcbData);
    [DllImport("kernel32", EntryPoint="RegGetValueW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegGetValue(nint hkey, char* lpSubKey, char* lpValue, int dwFlags, cpointer unfoundType_LPDWORD_pdwType, cpointer pvData, cpointer unfoundType_LPDWORD_pcbData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegGetValueW(nint hkey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, int dwFlags, cpointer unfoundType_LPDWORD_pdwType, cpointer pvData, cpointer unfoundType_LPDWORD_pcbData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegGetValueW(nint hkey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, char* lpValue, int dwFlags, cpointer unfoundType_LPDWORD_pdwType, cpointer pvData, cpointer unfoundType_LPDWORD_pcbData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegGetValueW(nint hkey, char* lpSubKey, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, int dwFlags, cpointer unfoundType_LPDWORD_pdwType, cpointer pvData, cpointer unfoundType_LPDWORD_pcbData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegGetValueW(nint hkey, char* lpSubKey, char* lpValue, int dwFlags, cpointer unfoundType_LPDWORD_pdwType, cpointer pvData, cpointer unfoundType_LPDWORD_pcbData);
    [DllImport("kernel32", EntryPoint="RegCopyTreeW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegCopyTree(nint hKeySrc, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, nint hKeyDest);
    [DllImport("kernel32", EntryPoint="RegCopyTreeW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegCopyTree(nint hKeySrc, char* lpSubKey, nint hKeyDest);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegCopyTreeW(nint hKeySrc, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, nint hKeyDest);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegCopyTreeW(nint hKeySrc, char* lpSubKey, nint hKeyDest);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegLoadMUIStringA(nint hKey, cpointer unfoundType_LPCSTR_pszValue, [MarshalAs(UnmanagedType.LPStr)] string pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, cpointer unfoundType_LPCSTR_pszDirectory);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegLoadMUIStringA(nint hKey, cpointer unfoundType_LPCSTR_pszValue, ReadOnlySpan<byte> pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, cpointer unfoundType_LPCSTR_pszDirectory);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegLoadMUIStringA(nint hKey, cpointer unfoundType_LPCSTR_pszValue, byte* pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, cpointer unfoundType_LPCSTR_pszDirectory);
    [DllImport("kernel32", EntryPoint="RegLoadMUIStringW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegLoadMUIString(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string pszValue, string pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, [MarshalAs(UnmanagedType.LPWStr)] string pszDirectory);
    [DllImport("kernel32", EntryPoint="RegLoadMUIStringW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegLoadMUIString(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string pszValue, string pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, char* pszDirectory);
    [DllImport("kernel32", EntryPoint="RegLoadMUIStringW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegLoadMUIString(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string pszValue, char* pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, [MarshalAs(UnmanagedType.LPWStr)] string pszDirectory);
    [DllImport("kernel32", EntryPoint="RegLoadMUIStringW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegLoadMUIString(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string pszValue, char* pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, char* pszDirectory);
    [DllImport("kernel32", EntryPoint="RegLoadMUIStringW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegLoadMUIString(nint hKey, char* pszValue, string pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, [MarshalAs(UnmanagedType.LPWStr)] string pszDirectory);
    [DllImport("kernel32", EntryPoint="RegLoadMUIStringW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegLoadMUIString(nint hKey, char* pszValue, string pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, char* pszDirectory);
    [DllImport("kernel32", EntryPoint="RegLoadMUIStringW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegLoadMUIString(nint hKey, char* pszValue, char* pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, [MarshalAs(UnmanagedType.LPWStr)] string pszDirectory);
    [DllImport("kernel32", EntryPoint="RegLoadMUIStringW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegLoadMUIString(nint hKey, char* pszValue, char* pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, char* pszDirectory);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegLoadMUIStringW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string pszValue, string pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, [MarshalAs(UnmanagedType.LPWStr)] string pszDirectory);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegLoadMUIStringW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string pszValue, string pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, char* pszDirectory);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegLoadMUIStringW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string pszValue, char* pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, [MarshalAs(UnmanagedType.LPWStr)] string pszDirectory);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegLoadMUIStringW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string pszValue, char* pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, char* pszDirectory);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegLoadMUIStringW(nint hKey, char* pszValue, string pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, [MarshalAs(UnmanagedType.LPWStr)] string pszDirectory);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegLoadMUIStringW(nint hKey, char* pszValue, string pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, char* pszDirectory);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegLoadMUIStringW(nint hKey, char* pszValue, char* pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, [MarshalAs(UnmanagedType.LPWStr)] string pszDirectory);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegLoadMUIStringW(nint hKey, char* pszValue, char* pszOutBuf, int cbOutBuf, cpointer unfoundType_LPDWORD_pcbData, int Flags, char* pszDirectory);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegSaveKeyExA(nint hKey, cpointer unfoundType_LPCSTR_lpFile, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int Flags);
    [DllImport("kernel32", EntryPoint="RegSaveKeyExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegSaveKeyEx(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpFile, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int Flags);
    [DllImport("kernel32", EntryPoint="RegSaveKeyExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegSaveKeyEx(nint hKey, char* lpFile, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int Flags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegSaveKeyExW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpFile, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int Flags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegSaveKeyExW(nint hKey, char* lpFile, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int Flags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GlobalAlloc(uint uFlags, cpointer dwBytes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GlobalReAlloc(cpointer unfoundType_HGLOBAL_hMem, cpointer dwBytes, uint uFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint* GlobalSize(cpointer unfoundType_HGLOBAL_hMem);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GlobalUnlock(cpointer unfoundType_HGLOBAL_hMem);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GlobalLock(cpointer unfoundType_HGLOBAL_hMem);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GlobalFlags(cpointer unfoundType_HGLOBAL_hMem);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GlobalHandle(cpointer pMem);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GlobalFree(cpointer unfoundType_HGLOBAL_hMem);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint* GlobalCompact(int dwMinFree);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void GlobalFix(cpointer unfoundType_HGLOBAL_hMem);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void GlobalUnfix(cpointer unfoundType_HGLOBAL_hMem);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GlobalWire(cpointer unfoundType_HGLOBAL_hMem);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GlobalUnWire(cpointer unfoundType_HGLOBAL_hMem);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void GlobalMemoryStatus(cpointer unfoundType_LPMEMORYSTATUS_lpBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LocalAlloc(uint uFlags, cpointer uBytes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LocalReAlloc(cpointer unfoundType_HLOCAL_hMem, cpointer uBytes, uint uFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LocalLock(cpointer unfoundType_HLOCAL_hMem);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LocalHandle(cpointer pMem);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int LocalUnlock(cpointer unfoundType_HLOCAL_hMem);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint* LocalSize(cpointer unfoundType_HLOCAL_hMem);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint LocalFlags(cpointer unfoundType_HLOCAL_hMem);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LocalFree(cpointer unfoundType_HLOCAL_hMem);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint* LocalShrink(cpointer unfoundType_HLOCAL_hMem, uint cbNewSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint* LocalCompact(uint uMinFree);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetBinaryTypeA(cpointer unfoundType_LPCSTR_lpApplicationName, cpointer unfoundType_LPDWORD_lpBinaryType);
    [DllImport("kernel32", EntryPoint="GetBinaryTypeW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetBinaryType([MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, cpointer unfoundType_LPDWORD_lpBinaryType);
    [DllImport("kernel32", EntryPoint="GetBinaryTypeW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetBinaryType(char* lpApplicationName, cpointer unfoundType_LPDWORD_lpBinaryType);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetBinaryTypeW([MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, cpointer unfoundType_LPDWORD_lpBinaryType);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetBinaryTypeW(char* lpApplicationName, cpointer unfoundType_LPDWORD_lpBinaryType);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetShortPathNameA(cpointer unfoundType_LPCSTR_lpszLongPath, [MarshalAs(UnmanagedType.LPStr)] string lpszShortPath, int cchBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetShortPathNameA(cpointer unfoundType_LPCSTR_lpszLongPath, ReadOnlySpan<byte> lpszShortPath, int cchBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetShortPathNameA(cpointer unfoundType_LPCSTR_lpszLongPath, byte* lpszShortPath, int cchBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLongPathNameTransactedA(cpointer unfoundType_LPCSTR_lpszShortPath, [MarshalAs(UnmanagedType.LPStr)] string lpszLongPath, int cchBuffer, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLongPathNameTransactedA(cpointer unfoundType_LPCSTR_lpszShortPath, ReadOnlySpan<byte> lpszLongPath, int cchBuffer, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLongPathNameTransactedA(cpointer unfoundType_LPCSTR_lpszShortPath, byte* lpszLongPath, int cchBuffer, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="GetLongPathNameTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLongPathNameTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpszShortPath, string lpszLongPath, int cchBuffer, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="GetLongPathNameTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLongPathNameTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpszShortPath, char* lpszLongPath, int cchBuffer, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="GetLongPathNameTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLongPathNameTransacted(char* lpszShortPath, string lpszLongPath, int cchBuffer, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="GetLongPathNameTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLongPathNameTransacted(char* lpszShortPath, char* lpszLongPath, int cchBuffer, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLongPathNameTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpszShortPath, string lpszLongPath, int cchBuffer, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLongPathNameTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpszShortPath, char* lpszLongPath, int cchBuffer, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLongPathNameTransactedW(char* lpszShortPath, string lpszLongPath, int cchBuffer, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLongPathNameTransactedW(char* lpszShortPath, char* lpszLongPath, int cchBuffer, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProcessAffinityMask(cpointer hProcess, cpointer unfoundType_PDWORD_PTR_lpProcessAffinityMask, cpointer unfoundType_PDWORD_PTR_lpSystemAffinityMask);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetProcessAffinityMask(cpointer hProcess, cpointer unfoundType_DWORD_PTR_dwProcessAffinityMask);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProcessIoCounters(cpointer hProcess, cpointer unfoundType_PIO_COUNTERS_lpIoCounters);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void FatalExit(int ExitCode);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetEnvironmentStringsA(cpointer unfoundType_LPCH_NewEnvironment);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void SwitchToFiber(cpointer lpFiber);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void DeleteFiber(cpointer lpFiber);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ConvertFiberToThread();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateFiberEx(cpointer dwStackCommitSize, cpointer dwStackReserveSize, int dwFlags, cpointer unfoundType_LPFIBER_START_ROUTINE_lpStartAddress, cpointer lpParameter);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer ConvertThreadToFiberEx(cpointer lpParameter, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateFiber(cpointer dwStackSize, cpointer unfoundType_LPFIBER_START_ROUTINE_lpStartAddress, cpointer lpParameter);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer ConvertThreadToFiber(cpointer lpParameter);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateUmsCompletionList(cpointer unfoundType_PUMS_COMPLETION_LIST_UmsCompletionList);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DequeueUmsCompletionListItems(cpointer unfoundType_PUMS_COMPLETION_LIST_UmsCompletionList, int WaitTimeOut, cpointer unfoundType_PUMS_CONTEXT_UmsThreadList);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetUmsCompletionListEvent(cpointer unfoundType_PUMS_COMPLETION_LIST_UmsCompletionList, cpointer unfoundType_PHANDLE_UmsCompletionEvent);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ExecuteUmsThread(cpointer unfoundType_PUMS_CONTEXT_UmsThread);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int UmsThreadYield(cpointer SchedulerParam);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DeleteUmsCompletionList(cpointer unfoundType_PUMS_COMPLETION_LIST_UmsCompletionList);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetCurrentUmsThread();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetNextUmsListItem(cpointer unfoundType_PUMS_CONTEXT_UmsContext);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryUmsThreadInformation(cpointer unfoundType_PUMS_CONTEXT_UmsThread, cpointer unfoundType_UMS_THREAD_INFO_CLASS_UmsThreadInfoClass, cpointer UmsThreadInformation, uint UmsThreadInformationLength, cpointer unfoundType_PULONG_ReturnLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetUmsThreadInformation(cpointer unfoundType_PUMS_CONTEXT_UmsThread, cpointer unfoundType_UMS_THREAD_INFO_CLASS_UmsThreadInfoClass, cpointer UmsThreadInformation, uint UmsThreadInformationLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DeleteUmsThreadContext(cpointer unfoundType_PUMS_CONTEXT_UmsThread);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateUmsThreadContext(cpointer unfoundType_PUMS_CONTEXTlpUmsThreadlpUmsThread_unnamed_0);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnterUmsSchedulingMode(cpointer unfoundType_PUMS_SCHEDULER_STARTUP_INFO_SchedulerStartupInfo);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetUmsSystemThreadInformation(cpointer ThreadHandle, cpointer unfoundType_PUMS_SYSTEM_THREAD_INFORMATION_SystemThreadInfo);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer SetThreadAffinityMask(cpointer hThread, cpointer unfoundType_DWORD_PTR_dwThreadAffinityMask);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetProcessDEPPolicy(int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProcessDEPPolicy(cpointer hProcess, cpointer unfoundType_LPDWORD_lpFlags, cpointer lpPermanent);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int RequestWakeupLatency(cpointer unfoundType_LATENCY_TIME_latency);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsSystemResumeAutomatic();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetThreadSelectorEntry(cpointer hThread, int dwSelector, cpointer unfoundType_LPLDT_ENTRY_lpSelectorEntry);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer SetThreadExecutionState(cpointer unfoundType_EXECUTION_STATE_esFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer PowerCreateRequest(cpointer unfoundType_PREASON_CONTEXT_Context);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int PowerSetRequest(cpointer PowerRequest, cpointer unfoundType_POWER_REQUEST_TYPE_RequestType);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int PowerClearRequest(cpointer PowerRequest, cpointer unfoundType_POWER_REQUEST_TYPE_RequestType);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetFileCompletionNotificationModes(cpointer FileHandle, byte Flags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int Wow64GetThreadSelectorEntry(cpointer hThread, int dwSelector, cpointer unfoundType_PWOW64_LDT_ENTRY_lpSelectorEntry);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DebugSetProcessKillOnExit(int KillOnExit);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DebugBreakProcess(cpointer Process);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int PulseEvent(cpointer hEvent);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        short GlobalDeleteAtom(short nAtom);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int InitAtomTable(int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        short DeleteAtom(short nAtom);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint SetHandleCount(uint uNumber);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int RequestDeviceWakeup(cpointer hDevice);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CancelDeviceWakeupRequest(cpointer hDevice);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDevicePowerState(cpointer hDevice, cpointer unfoundType_BOOLpfOnpfOn_unnamed_1);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetMessageWaitingIndicator(cpointer hMsgIndicator, uint ulMsgCount);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetFileShortNameA(cpointer hFile, cpointer unfoundType_LPCSTR_lpShortName);
    [DllImport("kernel32", EntryPoint="SetFileShortNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetFileShortName(cpointer hFile, [MarshalAs(UnmanagedType.LPWStr)] string lpShortName);
    [DllImport("kernel32", EntryPoint="SetFileShortNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetFileShortName(cpointer hFile, char* lpShortName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetFileShortNameW(cpointer hFile, [MarshalAs(UnmanagedType.LPWStr)] string lpShortName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetFileShortNameW(cpointer hFile, char* lpShortName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int LoadModule(cpointer unfoundType_LPCSTR_lpModuleName, cpointer lpParameterBlock);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint WinExec(cpointer unfoundType_LPCSTR_lpCmdLine, uint uCmdShow);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetTapePosition(cpointer hDevice, int dwPositionMethod, int dwPartition, int dwOffsetLow, int dwOffsetHigh, int bImmediate);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTapePosition(cpointer hDevice, int dwPositionType, cpointer unfoundType_LPDWORD_lpdwPartition, cpointer unfoundType_LPDWORD_lpdwOffsetLow, cpointer unfoundType_LPDWORD_lpdwOffsetHigh);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int PrepareTape(cpointer hDevice, int dwOperation, int bImmediate);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EraseTape(cpointer hDevice, int dwEraseType, int bImmediate);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateTapePartition(cpointer hDevice, int dwPartitionMethod, int dwCount, int dwSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteTapemark(cpointer hDevice, int dwTapemarkType, int dwTapemarkCount, int bImmediate);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTapeStatus(cpointer hDevice);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTapeParameters(cpointer hDevice, int dwOperation, cpointer unfoundType_LPDWORD_lpdwSize, cpointer lpTapeInformation);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetTapeParameters(cpointer hDevice, int dwOperation, cpointer lpTapeInformation);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int MulDiv(int nNumber, int nNumerator, int nDenominator);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetSystemDEPPolicy();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetSystemRegistryQuota(cpointer unfoundType_PDWORD_pdwQuotaAllowed, cpointer unfoundType_PDWORD_pdwQuotaUsed);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FileTimeToDosDateTime(cpointer unfoundType_FILETIMElpFileTimelpFileTime_unnamed_0, cpointer unfoundType_LPWORD_lpFatDate, cpointer unfoundType_LPWORD_lpFatTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DosDateTimeToFileTime(short wFatDate, short wFatTime, cpointer unfoundType_LPFILETIME_lpFileTime);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FormatMessageA(int dwFlags, cpointer lpSource, int dwMessageId, int dwLanguageId, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, int nSize, cpointer unfoundType_va_listArgumentsArguments_unnamed_6);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FormatMessageA(int dwFlags, cpointer lpSource, int dwMessageId, int dwLanguageId, ReadOnlySpan<byte> lpBuffer, int nSize, cpointer unfoundType_va_listArgumentsArguments_unnamed_6);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FormatMessageA(int dwFlags, cpointer lpSource, int dwMessageId, int dwLanguageId, byte* lpBuffer, int nSize, cpointer unfoundType_va_listArgumentsArguments_unnamed_6);
    [DllImport("kernel32", EntryPoint="FormatMessageW", SetLastError=true, ExactSpelling=true)] public static extern
        int FormatMessage(int dwFlags, cpointer lpSource, int dwMessageId, int dwLanguageId, string lpBuffer, int nSize, cpointer unfoundType_va_listArgumentsArguments_unnamed_6);
    [DllImport("kernel32", EntryPoint="FormatMessageW", SetLastError=true, ExactSpelling=true)] public static extern
        int FormatMessage(int dwFlags, cpointer lpSource, int dwMessageId, int dwLanguageId, char* lpBuffer, int nSize, cpointer unfoundType_va_listArgumentsArguments_unnamed_6);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FormatMessageW(int dwFlags, cpointer lpSource, int dwMessageId, int dwLanguageId, string lpBuffer, int nSize, cpointer unfoundType_va_listArgumentsArguments_unnamed_6);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FormatMessageW(int dwFlags, cpointer lpSource, int dwMessageId, int dwLanguageId, char* lpBuffer, int nSize, cpointer unfoundType_va_listArgumentsArguments_unnamed_6);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateMailslotA(cpointer unfoundType_LPCSTR_lpName, int nMaxMessageSize, int lReadTimeout, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport("kernel32", EntryPoint="CreateMailslotW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateMailslot([MarshalAs(UnmanagedType.LPWStr)] string lpName, int nMaxMessageSize, int lReadTimeout, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport("kernel32", EntryPoint="CreateMailslotW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateMailslot(char* lpName, int nMaxMessageSize, int lReadTimeout, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateMailslotW([MarshalAs(UnmanagedType.LPWStr)] string lpName, int nMaxMessageSize, int lReadTimeout, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateMailslotW(char* lpName, int nMaxMessageSize, int lReadTimeout, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetMailslotInfo(cpointer hMailslot, cpointer unfoundType_LPDWORD_lpMaxMessageSize, cpointer unfoundType_LPDWORD_lpNextSize, cpointer unfoundType_LPDWORD_lpMessageCount, cpointer unfoundType_LPDWORD_lpReadTimeout);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetMailslotInfo(cpointer hMailslot, int lReadTimeout);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int lstrcmpA(cpointer unfoundType_LPCSTR_lpString1, cpointer unfoundType_LPCSTR_lpString2);
    [DllImport("kernel32", EntryPoint="lstrcmpW", SetLastError=true, ExactSpelling=true)] public static extern
        int lstrcmp([MarshalAs(UnmanagedType.LPWStr)] string lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport("kernel32", EntryPoint="lstrcmpW", SetLastError=true, ExactSpelling=true)] public static extern
        int lstrcmp([MarshalAs(UnmanagedType.LPWStr)] string lpString1, char* lpString2);
    [DllImport("kernel32", EntryPoint="lstrcmpW", SetLastError=true, ExactSpelling=true)] public static extern
        int lstrcmp(char* lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport("kernel32", EntryPoint="lstrcmpW", SetLastError=true, ExactSpelling=true)] public static extern
        int lstrcmp(char* lpString1, char* lpString2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int lstrcmpW([MarshalAs(UnmanagedType.LPWStr)] string lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int lstrcmpW([MarshalAs(UnmanagedType.LPWStr)] string lpString1, char* lpString2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int lstrcmpW(char* lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int lstrcmpW(char* lpString1, char* lpString2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int lstrcmpiA(cpointer unfoundType_LPCSTR_lpString1, cpointer unfoundType_LPCSTR_lpString2);
    [DllImport("kernel32", EntryPoint="lstrcmpiW", SetLastError=true, ExactSpelling=true)] public static extern
        int lstrcmpi([MarshalAs(UnmanagedType.LPWStr)] string lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport("kernel32", EntryPoint="lstrcmpiW", SetLastError=true, ExactSpelling=true)] public static extern
        int lstrcmpi([MarshalAs(UnmanagedType.LPWStr)] string lpString1, char* lpString2);
    [DllImport("kernel32", EntryPoint="lstrcmpiW", SetLastError=true, ExactSpelling=true)] public static extern
        int lstrcmpi(char* lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport("kernel32", EntryPoint="lstrcmpiW", SetLastError=true, ExactSpelling=true)] public static extern
        int lstrcmpi(char* lpString1, char* lpString2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int lstrcmpiW([MarshalAs(UnmanagedType.LPWStr)] string lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int lstrcmpiW([MarshalAs(UnmanagedType.LPWStr)] string lpString1, char* lpString2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int lstrcmpiW(char* lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int lstrcmpiW(char* lpString1, char* lpString2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        byte* lstrcpynA_([MarshalAs(UnmanagedType.LPStr)] string lpString1, cpointer unfoundType_LPCSTR_lpString2, int iMaxLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        byte* lstrcpynA_(ReadOnlySpan<byte> lpString1, cpointer unfoundType_LPCSTR_lpString2, int iMaxLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        byte* lstrcpynA_(byte* lpString1, cpointer unfoundType_LPCSTR_lpString2, int iMaxLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        ReadOnlySpan<byte> lstrcpynA([MarshalAs(UnmanagedType.LPStr)] string lpString1, cpointer unfoundType_LPCSTR_lpString2, int iMaxLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        ReadOnlySpan<byte> lstrcpynA(ReadOnlySpan<byte> lpString1, cpointer unfoundType_LPCSTR_lpString2, int iMaxLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        ReadOnlySpan<byte> lstrcpynA(byte* lpString1, cpointer unfoundType_LPCSTR_lpString2, int iMaxLength);
    [DllImport("kernel32", EntryPoint="lstrcpynW", SetLastError=true, ExactSpelling=true)] public static extern
        char* lstrcpyn_(string lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2, int iMaxLength);
    [DllImport("kernel32", EntryPoint="lstrcpynW", SetLastError=true, ExactSpelling=true)] public static extern
        char* lstrcpyn_(string lpString1, char* lpString2, int iMaxLength);
    [DllImport("kernel32", EntryPoint="lstrcpynW", SetLastError=true, ExactSpelling=true)] public static extern
        char* lstrcpyn_(char* lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2, int iMaxLength);
    [DllImport("kernel32", EntryPoint="lstrcpynW", SetLastError=true, ExactSpelling=true)] public static extern
        char* lstrcpyn_(char* lpString1, char* lpString2, int iMaxLength);
    [DllImport("kernel32", EntryPoint="lstrcpynW", SetLastError=true, ExactSpelling=true)] public static extern
        string lstrcpyn(string lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2, int iMaxLength);
    [DllImport("kernel32", EntryPoint="lstrcpynW", SetLastError=true, ExactSpelling=true)] public static extern
        string lstrcpyn(string lpString1, char* lpString2, int iMaxLength);
    [DllImport("kernel32", EntryPoint="lstrcpynW", SetLastError=true, ExactSpelling=true)] public static extern
        string lstrcpyn(char* lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2, int iMaxLength);
    [DllImport("kernel32", EntryPoint="lstrcpynW", SetLastError=true, ExactSpelling=true)] public static extern
        string lstrcpyn(char* lpString1, char* lpString2, int iMaxLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        char* lstrcpynW_(string lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2, int iMaxLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        char* lstrcpynW_(string lpString1, char* lpString2, int iMaxLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        char* lstrcpynW_(char* lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2, int iMaxLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        char* lstrcpynW_(char* lpString1, char* lpString2, int iMaxLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        string lstrcpynW(string lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2, int iMaxLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        string lstrcpynW(string lpString1, char* lpString2, int iMaxLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        string lstrcpynW(char* lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2, int iMaxLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        string lstrcpynW(char* lpString1, char* lpString2, int iMaxLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        byte* lstrcpyA_([MarshalAs(UnmanagedType.LPStr)] string lpString1, cpointer unfoundType_LPCSTR_lpString2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        byte* lstrcpyA_(ReadOnlySpan<byte> lpString1, cpointer unfoundType_LPCSTR_lpString2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        byte* lstrcpyA_(byte* lpString1, cpointer unfoundType_LPCSTR_lpString2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        ReadOnlySpan<byte> lstrcpyA([MarshalAs(UnmanagedType.LPStr)] string lpString1, cpointer unfoundType_LPCSTR_lpString2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        ReadOnlySpan<byte> lstrcpyA(ReadOnlySpan<byte> lpString1, cpointer unfoundType_LPCSTR_lpString2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        ReadOnlySpan<byte> lstrcpyA(byte* lpString1, cpointer unfoundType_LPCSTR_lpString2);
    [DllImport("kernel32", EntryPoint="lstrcpyW", SetLastError=true, ExactSpelling=true)] public static extern
        char* lstrcpy_(string lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport("kernel32", EntryPoint="lstrcpyW", SetLastError=true, ExactSpelling=true)] public static extern
        char* lstrcpy_(string lpString1, char* lpString2);
    [DllImport("kernel32", EntryPoint="lstrcpyW", SetLastError=true, ExactSpelling=true)] public static extern
        char* lstrcpy_(char* lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport("kernel32", EntryPoint="lstrcpyW", SetLastError=true, ExactSpelling=true)] public static extern
        char* lstrcpy_(char* lpString1, char* lpString2);
    [DllImport("kernel32", EntryPoint="lstrcpyW", SetLastError=true, ExactSpelling=true)] public static extern
        string lstrcpy(string lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport("kernel32", EntryPoint="lstrcpyW", SetLastError=true, ExactSpelling=true)] public static extern
        string lstrcpy(string lpString1, char* lpString2);
    [DllImport("kernel32", EntryPoint="lstrcpyW", SetLastError=true, ExactSpelling=true)] public static extern
        string lstrcpy(char* lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport("kernel32", EntryPoint="lstrcpyW", SetLastError=true, ExactSpelling=true)] public static extern
        string lstrcpy(char* lpString1, char* lpString2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        char* lstrcpyW_(string lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        char* lstrcpyW_(string lpString1, char* lpString2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        char* lstrcpyW_(char* lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        char* lstrcpyW_(char* lpString1, char* lpString2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        string lstrcpyW(string lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        string lstrcpyW(string lpString1, char* lpString2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        string lstrcpyW(char* lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        string lstrcpyW(char* lpString1, char* lpString2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        byte* lstrcatA_([MarshalAs(UnmanagedType.LPStr)] string lpString1, cpointer unfoundType_LPCSTR_lpString2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        byte* lstrcatA_(ReadOnlySpan<byte> lpString1, cpointer unfoundType_LPCSTR_lpString2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        byte* lstrcatA_(byte* lpString1, cpointer unfoundType_LPCSTR_lpString2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        ReadOnlySpan<byte> lstrcatA([MarshalAs(UnmanagedType.LPStr)] string lpString1, cpointer unfoundType_LPCSTR_lpString2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        ReadOnlySpan<byte> lstrcatA(ReadOnlySpan<byte> lpString1, cpointer unfoundType_LPCSTR_lpString2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        ReadOnlySpan<byte> lstrcatA(byte* lpString1, cpointer unfoundType_LPCSTR_lpString2);
    [DllImport("kernel32", EntryPoint="lstrcatW", SetLastError=true, ExactSpelling=true)] public static extern
        char* lstrcat_(string lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport("kernel32", EntryPoint="lstrcatW", SetLastError=true, ExactSpelling=true)] public static extern
        char* lstrcat_(string lpString1, char* lpString2);
    [DllImport("kernel32", EntryPoint="lstrcatW", SetLastError=true, ExactSpelling=true)] public static extern
        char* lstrcat_(char* lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport("kernel32", EntryPoint="lstrcatW", SetLastError=true, ExactSpelling=true)] public static extern
        char* lstrcat_(char* lpString1, char* lpString2);
    [DllImport("kernel32", EntryPoint="lstrcatW", SetLastError=true, ExactSpelling=true)] public static extern
        string lstrcat(string lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport("kernel32", EntryPoint="lstrcatW", SetLastError=true, ExactSpelling=true)] public static extern
        string lstrcat(string lpString1, char* lpString2);
    [DllImport("kernel32", EntryPoint="lstrcatW", SetLastError=true, ExactSpelling=true)] public static extern
        string lstrcat(char* lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport("kernel32", EntryPoint="lstrcatW", SetLastError=true, ExactSpelling=true)] public static extern
        string lstrcat(char* lpString1, char* lpString2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        char* lstrcatW_(string lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        char* lstrcatW_(string lpString1, char* lpString2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        char* lstrcatW_(char* lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        char* lstrcatW_(char* lpString1, char* lpString2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        string lstrcatW(string lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        string lstrcatW(string lpString1, char* lpString2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        string lstrcatW(char* lpString1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        string lstrcatW(char* lpString1, char* lpString2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int lstrlenA(cpointer unfoundType_LPCSTR_lpString);
    [DllImport("kernel32", EntryPoint="lstrlenW", SetLastError=true, ExactSpelling=true)] public static extern
        int lstrlen([MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport("kernel32", EntryPoint="lstrlenW", SetLastError=true, ExactSpelling=true)] public static extern
        int lstrlen(char* lpString);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int lstrlenW([MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int lstrlenW(char* lpString);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int OpenFile(cpointer unfoundType_LPCSTR_lpFileName, cpointer unfoundType_LPOFSTRUCT_lpReOpenBuff, uint uStyle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int _lopen(cpointer unfoundType_LPCSTR_lpPathName, int iReadWrite);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int _lcreat(cpointer unfoundType_LPCSTR_lpPathName, int iAttribute);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint _lread(int hFile, cpointer lpBuffer, uint uBytes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint _lwrite(int hFile, cpointer unfoundType_LPCCH_lpBuffer, uint uBytes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int _hread(int hFile, cpointer lpBuffer, int lBytes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int _hwrite(int hFile, cpointer unfoundType_LPCCH_lpBuffer, int lBytes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int _lclose(int hFile);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int _llseek(int hFile, int lOffset, int iOrigin);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int BackupRead(cpointer hFile, cpointer unfoundType_LPBYTE_lpBuffer, int nNumberOfBytesToRead, cpointer unfoundType_LPDWORD_lpNumberOfBytesRead, int bAbort, int bProcessSecurity, cpointer unfoundType_LPVOIDlpContextlpContext_unnamed_6);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int BackupSeek(cpointer hFile, int dwLowBytesToSeek, int dwHighBytesToSeek, cpointer unfoundType_LPDWORD_lpdwLowByteSeeked, cpointer unfoundType_LPDWORD_lpdwHighByteSeeked, cpointer unfoundType_LPVOIDlpContextlpContext_unnamed_5);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int BackupWrite(cpointer hFile, cpointer unfoundType_LPBYTE_lpBuffer, int nNumberOfBytesToWrite, cpointer unfoundType_LPDWORD_lpNumberOfBytesWritten, int bAbort, int bProcessSecurity, cpointer unfoundType_LPVOIDlpContextlpContext_unnamed_6);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenMutexA(int dwDesiredAccess, int bInheritHandle, cpointer unfoundType_LPCSTR_lpName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateSemaphoreA(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, cpointer unfoundType_LPCSTR_lpName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenSemaphoreA(int dwDesiredAccess, int bInheritHandle, cpointer unfoundType_LPCSTR_lpName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateWaitableTimerA(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpTimerAttributes, int bManualReset, cpointer unfoundType_LPCSTR_lpTimerName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenWaitableTimerA(int dwDesiredAccess, int bInheritHandle, cpointer unfoundType_LPCSTR_lpTimerName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateSemaphoreExA(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, cpointer unfoundType_LPCSTR_lpName, int dwFlags, int dwDesiredAccess);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateWaitableTimerExA(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpTimerAttributes, cpointer unfoundType_LPCSTR_lpTimerName, int dwFlags, int dwDesiredAccess);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateFileMappingA(cpointer hFile, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpFileMappingAttributes, int flProtect, int dwMaximumSizeHigh, int dwMaximumSizeLow, cpointer unfoundType_LPCSTR_lpName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateFileMappingNumaA(cpointer hFile, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpFileMappingAttributes, int flProtect, int dwMaximumSizeHigh, int dwMaximumSizeLow, cpointer unfoundType_LPCSTR_lpName, int nndPreferred);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenFileMappingA(int dwDesiredAccess, int bInheritHandle, cpointer unfoundType_LPCSTR_lpName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLogicalDriveStringsA(int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLogicalDriveStringsA(int nBufferLength, ReadOnlySpan<byte> lpBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLogicalDriveStringsA(int nBufferLength, byte* lpBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryFullProcessImageNameA(cpointer hProcess, int dwFlags, [MarshalAs(UnmanagedType.LPStr)] string lpExeName, cpointer unfoundType_PDWORD_lpdwSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryFullProcessImageNameA(cpointer hProcess, int dwFlags, ReadOnlySpan<byte> lpExeName, cpointer unfoundType_PDWORD_lpdwSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryFullProcessImageNameA(cpointer hProcess, int dwFlags, byte* lpExeName, cpointer unfoundType_PDWORD_lpdwSize);
    [DllImport("kernel32", EntryPoint="QueryFullProcessImageNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryFullProcessImageName(cpointer hProcess, int dwFlags, string lpExeName, cpointer unfoundType_PDWORD_lpdwSize);
    [DllImport("kernel32", EntryPoint="QueryFullProcessImageNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryFullProcessImageName(cpointer hProcess, int dwFlags, char* lpExeName, cpointer unfoundType_PDWORD_lpdwSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryFullProcessImageNameW(cpointer hProcess, int dwFlags, string lpExeName, cpointer unfoundType_PDWORD_lpdwSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryFullProcessImageNameW(cpointer hProcess, int dwFlags, char* lpExeName, cpointer unfoundType_PDWORD_lpdwSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void GetStartupInfoA(cpointer unfoundType_LPSTARTUPINFOA_lpStartupInfo);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFirmwareEnvironmentVariableA(cpointer unfoundType_LPCSTR_lpName, cpointer unfoundType_LPCSTR_lpGuid, cpointer pBuffer, int nSize);
    [DllImport("kernel32", EntryPoint="GetFirmwareEnvironmentVariableW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFirmwareEnvironmentVariable([MarshalAs(UnmanagedType.LPWStr)] string lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, cpointer pBuffer, int nSize);
    [DllImport("kernel32", EntryPoint="GetFirmwareEnvironmentVariableW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFirmwareEnvironmentVariable([MarshalAs(UnmanagedType.LPWStr)] string lpName, char* lpGuid, cpointer pBuffer, int nSize);
    [DllImport("kernel32", EntryPoint="GetFirmwareEnvironmentVariableW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFirmwareEnvironmentVariable(char* lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, cpointer pBuffer, int nSize);
    [DllImport("kernel32", EntryPoint="GetFirmwareEnvironmentVariableW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFirmwareEnvironmentVariable(char* lpName, char* lpGuid, cpointer pBuffer, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFirmwareEnvironmentVariableW([MarshalAs(UnmanagedType.LPWStr)] string lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, cpointer pBuffer, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFirmwareEnvironmentVariableW([MarshalAs(UnmanagedType.LPWStr)] string lpName, char* lpGuid, cpointer pBuffer, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFirmwareEnvironmentVariableW(char* lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, cpointer pBuffer, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFirmwareEnvironmentVariableW(char* lpName, char* lpGuid, cpointer pBuffer, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFirmwareEnvironmentVariableExA(cpointer unfoundType_LPCSTR_lpName, cpointer unfoundType_LPCSTR_lpGuid, cpointer pBuffer, int nSize, cpointer unfoundType_PDWORD_pdwAttribubutes);
    [DllImport("kernel32", EntryPoint="GetFirmwareEnvironmentVariableExW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFirmwareEnvironmentVariableEx([MarshalAs(UnmanagedType.LPWStr)] string lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, cpointer pBuffer, int nSize, cpointer unfoundType_PDWORD_pdwAttribubutes);
    [DllImport("kernel32", EntryPoint="GetFirmwareEnvironmentVariableExW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFirmwareEnvironmentVariableEx([MarshalAs(UnmanagedType.LPWStr)] string lpName, char* lpGuid, cpointer pBuffer, int nSize, cpointer unfoundType_PDWORD_pdwAttribubutes);
    [DllImport("kernel32", EntryPoint="GetFirmwareEnvironmentVariableExW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFirmwareEnvironmentVariableEx(char* lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, cpointer pBuffer, int nSize, cpointer unfoundType_PDWORD_pdwAttribubutes);
    [DllImport("kernel32", EntryPoint="GetFirmwareEnvironmentVariableExW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFirmwareEnvironmentVariableEx(char* lpName, char* lpGuid, cpointer pBuffer, int nSize, cpointer unfoundType_PDWORD_pdwAttribubutes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFirmwareEnvironmentVariableExW([MarshalAs(UnmanagedType.LPWStr)] string lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, cpointer pBuffer, int nSize, cpointer unfoundType_PDWORD_pdwAttribubutes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFirmwareEnvironmentVariableExW([MarshalAs(UnmanagedType.LPWStr)] string lpName, char* lpGuid, cpointer pBuffer, int nSize, cpointer unfoundType_PDWORD_pdwAttribubutes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFirmwareEnvironmentVariableExW(char* lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, cpointer pBuffer, int nSize, cpointer unfoundType_PDWORD_pdwAttribubutes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFirmwareEnvironmentVariableExW(char* lpName, char* lpGuid, cpointer pBuffer, int nSize, cpointer unfoundType_PDWORD_pdwAttribubutes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetFirmwareEnvironmentVariableA(cpointer unfoundType_LPCSTR_lpName, cpointer unfoundType_LPCSTR_lpGuid, cpointer pValue, int nSize);
    [DllImport("kernel32", EntryPoint="SetFirmwareEnvironmentVariableW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetFirmwareEnvironmentVariable([MarshalAs(UnmanagedType.LPWStr)] string lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, cpointer pValue, int nSize);
    [DllImport("kernel32", EntryPoint="SetFirmwareEnvironmentVariableW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetFirmwareEnvironmentVariable([MarshalAs(UnmanagedType.LPWStr)] string lpName, char* lpGuid, cpointer pValue, int nSize);
    [DllImport("kernel32", EntryPoint="SetFirmwareEnvironmentVariableW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetFirmwareEnvironmentVariable(char* lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, cpointer pValue, int nSize);
    [DllImport("kernel32", EntryPoint="SetFirmwareEnvironmentVariableW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetFirmwareEnvironmentVariable(char* lpName, char* lpGuid, cpointer pValue, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetFirmwareEnvironmentVariableW([MarshalAs(UnmanagedType.LPWStr)] string lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, cpointer pValue, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetFirmwareEnvironmentVariableW([MarshalAs(UnmanagedType.LPWStr)] string lpName, char* lpGuid, cpointer pValue, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetFirmwareEnvironmentVariableW(char* lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, cpointer pValue, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetFirmwareEnvironmentVariableW(char* lpName, char* lpGuid, cpointer pValue, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetFirmwareEnvironmentVariableExA(cpointer unfoundType_LPCSTR_lpName, cpointer unfoundType_LPCSTR_lpGuid, cpointer pValue, int nSize, int dwAttributes);
    [DllImport("kernel32", EntryPoint="SetFirmwareEnvironmentVariableExW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetFirmwareEnvironmentVariableEx([MarshalAs(UnmanagedType.LPWStr)] string lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, cpointer pValue, int nSize, int dwAttributes);
    [DllImport("kernel32", EntryPoint="SetFirmwareEnvironmentVariableExW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetFirmwareEnvironmentVariableEx([MarshalAs(UnmanagedType.LPWStr)] string lpName, char* lpGuid, cpointer pValue, int nSize, int dwAttributes);
    [DllImport("kernel32", EntryPoint="SetFirmwareEnvironmentVariableExW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetFirmwareEnvironmentVariableEx(char* lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, cpointer pValue, int nSize, int dwAttributes);
    [DllImport("kernel32", EntryPoint="SetFirmwareEnvironmentVariableExW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetFirmwareEnvironmentVariableEx(char* lpName, char* lpGuid, cpointer pValue, int nSize, int dwAttributes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetFirmwareEnvironmentVariableExW([MarshalAs(UnmanagedType.LPWStr)] string lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, cpointer pValue, int nSize, int dwAttributes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetFirmwareEnvironmentVariableExW([MarshalAs(UnmanagedType.LPWStr)] string lpName, char* lpGuid, cpointer pValue, int nSize, int dwAttributes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetFirmwareEnvironmentVariableExW(char* lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, cpointer pValue, int nSize, int dwAttributes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetFirmwareEnvironmentVariableExW(char* lpName, char* lpGuid, cpointer pValue, int nSize, int dwAttributes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFirmwareType(cpointer unfoundType_PFIRMWARE_TYPE_FirmwareType);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsNativeVhdBoot(cpointer NativeVhdBoot);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindResourceA(cpointer unfoundType_HMODULE_hModule, cpointer unfoundType_LPCSTR_lpName, cpointer unfoundType_LPCSTR_lpType);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindResourceExA(cpointer unfoundType_HMODULE_hModule, cpointer unfoundType_LPCSTR_lpType, cpointer unfoundType_LPCSTR_lpName, short wLanguage);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumResourceTypesA(cpointer unfoundType_HMODULE_hModule, cpointer unfoundType_ENUMRESTYPEPROCA_lpEnumFunc, long lParam);
    [DllImport("kernel32", EntryPoint="EnumResourceTypesW", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumResourceTypes(cpointer unfoundType_HMODULE_hModule, cpointer unfoundType_ENUMRESTYPEPROCW_lpEnumFunc, long lParam);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumResourceTypesW(cpointer unfoundType_HMODULE_hModule, cpointer unfoundType_ENUMRESTYPEPROCW_lpEnumFunc, long lParam);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumResourceLanguagesA(cpointer unfoundType_HMODULE_hModule, cpointer unfoundType_LPCSTR_lpType, cpointer unfoundType_LPCSTR_lpName, cpointer unfoundType_ENUMRESLANGPROCA_lpEnumFunc, long lParam);
    [DllImport("kernel32", EntryPoint="EnumResourceLanguagesW", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumResourceLanguages(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, cpointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam);
    [DllImport("kernel32", EntryPoint="EnumResourceLanguagesW", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumResourceLanguages(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, char* lpName, cpointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam);
    [DllImport("kernel32", EntryPoint="EnumResourceLanguagesW", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumResourceLanguages(cpointer unfoundType_HMODULE_hModule, char* lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, cpointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam);
    [DllImport("kernel32", EntryPoint="EnumResourceLanguagesW", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumResourceLanguages(cpointer unfoundType_HMODULE_hModule, char* lpType, char* lpName, cpointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumResourceLanguagesW(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, cpointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumResourceLanguagesW(cpointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, char* lpName, cpointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumResourceLanguagesW(cpointer unfoundType_HMODULE_hModule, char* lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, cpointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumResourceLanguagesW(cpointer unfoundType_HMODULE_hModule, char* lpType, char* lpName, cpointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer BeginUpdateResourceA(cpointer unfoundType_LPCSTR_pFileName, int bDeleteExistingResources);
    [DllImport("kernel32", EntryPoint="BeginUpdateResourceW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer BeginUpdateResource([MarshalAs(UnmanagedType.LPWStr)] string pFileName, int bDeleteExistingResources);
    [DllImport("kernel32", EntryPoint="BeginUpdateResourceW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer BeginUpdateResource(char* pFileName, int bDeleteExistingResources);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer BeginUpdateResourceW([MarshalAs(UnmanagedType.LPWStr)] string pFileName, int bDeleteExistingResources);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer BeginUpdateResourceW(char* pFileName, int bDeleteExistingResources);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int UpdateResourceA(cpointer hUpdate, cpointer unfoundType_LPCSTR_lpType, cpointer unfoundType_LPCSTR_lpName, short wLanguage, cpointer lpData, int cb);
    [DllImport("kernel32", EntryPoint="UpdateResourceW", SetLastError=true, ExactSpelling=true)] public static extern
        int UpdateResource(cpointer hUpdate, [MarshalAs(UnmanagedType.LPWStr)] string lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, short wLanguage, cpointer lpData, int cb);
    [DllImport("kernel32", EntryPoint="UpdateResourceW", SetLastError=true, ExactSpelling=true)] public static extern
        int UpdateResource(cpointer hUpdate, [MarshalAs(UnmanagedType.LPWStr)] string lpType, char* lpName, short wLanguage, cpointer lpData, int cb);
    [DllImport("kernel32", EntryPoint="UpdateResourceW", SetLastError=true, ExactSpelling=true)] public static extern
        int UpdateResource(cpointer hUpdate, char* lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, short wLanguage, cpointer lpData, int cb);
    [DllImport("kernel32", EntryPoint="UpdateResourceW", SetLastError=true, ExactSpelling=true)] public static extern
        int UpdateResource(cpointer hUpdate, char* lpType, char* lpName, short wLanguage, cpointer lpData, int cb);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int UpdateResourceW(cpointer hUpdate, [MarshalAs(UnmanagedType.LPWStr)] string lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, short wLanguage, cpointer lpData, int cb);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int UpdateResourceW(cpointer hUpdate, [MarshalAs(UnmanagedType.LPWStr)] string lpType, char* lpName, short wLanguage, cpointer lpData, int cb);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int UpdateResourceW(cpointer hUpdate, char* lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, short wLanguage, cpointer lpData, int cb);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int UpdateResourceW(cpointer hUpdate, char* lpType, char* lpName, short wLanguage, cpointer lpData, int cb);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EndUpdateResourceA(cpointer hUpdate, int fDiscard);
    [DllImport("kernel32", EntryPoint="EndUpdateResourceW", SetLastError=true, ExactSpelling=true)] public static extern
        int EndUpdateResource(cpointer hUpdate, int fDiscard);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EndUpdateResourceW(cpointer hUpdate, int fDiscard);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        short GlobalAddAtomA(cpointer unfoundType_LPCSTR_lpString);
    [DllImport("kernel32", EntryPoint="GlobalAddAtomW", SetLastError=true, ExactSpelling=true)] public static extern
        short GlobalAddAtom([MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport("kernel32", EntryPoint="GlobalAddAtomW", SetLastError=true, ExactSpelling=true)] public static extern
        short GlobalAddAtom(char* lpString);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        short GlobalAddAtomW([MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        short GlobalAddAtomW(char* lpString);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        short GlobalAddAtomExA(cpointer unfoundType_LPCSTR_lpString, int Flags);
    [DllImport("kernel32", EntryPoint="GlobalAddAtomExW", SetLastError=true, ExactSpelling=true)] public static extern
        short GlobalAddAtomEx([MarshalAs(UnmanagedType.LPWStr)] string lpString, int Flags);
    [DllImport("kernel32", EntryPoint="GlobalAddAtomExW", SetLastError=true, ExactSpelling=true)] public static extern
        short GlobalAddAtomEx(char* lpString, int Flags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        short GlobalAddAtomExW([MarshalAs(UnmanagedType.LPWStr)] string lpString, int Flags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        short GlobalAddAtomExW(char* lpString, int Flags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        short GlobalFindAtomA(cpointer unfoundType_LPCSTR_lpString);
    [DllImport("kernel32", EntryPoint="GlobalFindAtomW", SetLastError=true, ExactSpelling=true)] public static extern
        short GlobalFindAtom([MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport("kernel32", EntryPoint="GlobalFindAtomW", SetLastError=true, ExactSpelling=true)] public static extern
        short GlobalFindAtom(char* lpString);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        short GlobalFindAtomW([MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        short GlobalFindAtomW(char* lpString);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GlobalGetAtomNameA(short nAtom, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GlobalGetAtomNameA(short nAtom, ReadOnlySpan<byte> lpBuffer, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GlobalGetAtomNameA(short nAtom, byte* lpBuffer, int nSize);
    [DllImport("kernel32", EntryPoint="GlobalGetAtomNameW", SetLastError=true, ExactSpelling=true)] public static extern
        uint GlobalGetAtomName(short nAtom, string lpBuffer, int nSize);
    [DllImport("kernel32", EntryPoint="GlobalGetAtomNameW", SetLastError=true, ExactSpelling=true)] public static extern
        uint GlobalGetAtomName(short nAtom, char* lpBuffer, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GlobalGetAtomNameW(short nAtom, string lpBuffer, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GlobalGetAtomNameW(short nAtom, char* lpBuffer, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        short AddAtomA(cpointer unfoundType_LPCSTR_lpString);
    [DllImport("kernel32", EntryPoint="AddAtomW", SetLastError=true, ExactSpelling=true)] public static extern
        short AddAtom([MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport("kernel32", EntryPoint="AddAtomW", SetLastError=true, ExactSpelling=true)] public static extern
        short AddAtom(char* lpString);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        short AddAtomW([MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        short AddAtomW(char* lpString);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        short FindAtomA(cpointer unfoundType_LPCSTR_lpString);
    [DllImport("kernel32", EntryPoint="FindAtomW", SetLastError=true, ExactSpelling=true)] public static extern
        short FindAtom([MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport("kernel32", EntryPoint="FindAtomW", SetLastError=true, ExactSpelling=true)] public static extern
        short FindAtom(char* lpString);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        short FindAtomW([MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        short FindAtomW(char* lpString);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetAtomNameA(short nAtom, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetAtomNameA(short nAtom, ReadOnlySpan<byte> lpBuffer, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetAtomNameA(short nAtom, byte* lpBuffer, int nSize);
    [DllImport("kernel32", EntryPoint="GetAtomNameW", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetAtomName(short nAtom, string lpBuffer, int nSize);
    [DllImport("kernel32", EntryPoint="GetAtomNameW", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetAtomName(short nAtom, char* lpBuffer, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetAtomNameW(short nAtom, string lpBuffer, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetAtomNameW(short nAtom, char* lpBuffer, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetProfileIntA(cpointer unfoundType_LPCSTR_lpAppName, cpointer unfoundType_LPCSTR_lpKeyName, int nDefault);
    [DllImport("kernel32", EntryPoint="GetProfileIntW", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetProfileInt([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, int nDefault);
    [DllImport("kernel32", EntryPoint="GetProfileIntW", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetProfileInt([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, int nDefault);
    [DllImport("kernel32", EntryPoint="GetProfileIntW", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetProfileInt(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, int nDefault);
    [DllImport("kernel32", EntryPoint="GetProfileIntW", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetProfileInt(char* lpAppName, char* lpKeyName, int nDefault);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetProfileIntW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, int nDefault);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetProfileIntW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, int nDefault);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetProfileIntW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, int nDefault);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetProfileIntW(char* lpAppName, char* lpKeyName, int nDefault);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileStringA(cpointer unfoundType_LPCSTR_lpAppName, cpointer unfoundType_LPCSTR_lpKeyName, cpointer unfoundType_LPCSTR_lpDefault, [MarshalAs(UnmanagedType.LPStr)] string lpReturnedString, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileStringA(cpointer unfoundType_LPCSTR_lpAppName, cpointer unfoundType_LPCSTR_lpKeyName, cpointer unfoundType_LPCSTR_lpDefault, ReadOnlySpan<byte> lpReturnedString, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileStringA(cpointer unfoundType_LPCSTR_lpAppName, cpointer unfoundType_LPCSTR_lpKeyName, cpointer unfoundType_LPCSTR_lpDefault, byte* lpReturnedString, int nSize);
    [DllImport("kernel32", EntryPoint="GetProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize);
    [DllImport("kernel32", EntryPoint="GetProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize);
    [DllImport("kernel32", EntryPoint="GetProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, string lpReturnedString, int nSize);
    [DllImport("kernel32", EntryPoint="GetProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, char* lpReturnedString, int nSize);
    [DllImport("kernel32", EntryPoint="GetProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize);
    [DllImport("kernel32", EntryPoint="GetProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize);
    [DllImport("kernel32", EntryPoint="GetProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, char* lpDefault, string lpReturnedString, int nSize);
    [DllImport("kernel32", EntryPoint="GetProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, char* lpDefault, char* lpReturnedString, int nSize);
    [DllImport("kernel32", EntryPoint="GetProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileString(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize);
    [DllImport("kernel32", EntryPoint="GetProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileString(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize);
    [DllImport("kernel32", EntryPoint="GetProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileString(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, string lpReturnedString, int nSize);
    [DllImport("kernel32", EntryPoint="GetProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileString(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, char* lpReturnedString, int nSize);
    [DllImport("kernel32", EntryPoint="GetProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileString(char* lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize);
    [DllImport("kernel32", EntryPoint="GetProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileString(char* lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize);
    [DllImport("kernel32", EntryPoint="GetProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileString(char* lpAppName, char* lpKeyName, char* lpDefault, string lpReturnedString, int nSize);
    [DllImport("kernel32", EntryPoint="GetProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileString(char* lpAppName, char* lpKeyName, char* lpDefault, char* lpReturnedString, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, string lpReturnedString, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, char* lpReturnedString, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, char* lpDefault, string lpReturnedString, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, char* lpDefault, char* lpReturnedString, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileStringW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileStringW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileStringW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, string lpReturnedString, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileStringW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, char* lpReturnedString, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileStringW(char* lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileStringW(char* lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileStringW(char* lpAppName, char* lpKeyName, char* lpDefault, string lpReturnedString, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileStringW(char* lpAppName, char* lpKeyName, char* lpDefault, char* lpReturnedString, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteProfileStringA(cpointer unfoundType_LPCSTR_lpAppName, cpointer unfoundType_LPCSTR_lpKeyName, cpointer unfoundType_LPCSTR_lpString);
    [DllImport("kernel32", EntryPoint="WriteProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport("kernel32", EntryPoint="WriteProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpString);
    [DllImport("kernel32", EntryPoint="WriteProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport("kernel32", EntryPoint="WriteProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, char* lpString);
    [DllImport("kernel32", EntryPoint="WriteProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteProfileString(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport("kernel32", EntryPoint="WriteProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteProfileString(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpString);
    [DllImport("kernel32", EntryPoint="WriteProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteProfileString(char* lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport("kernel32", EntryPoint="WriteProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteProfileString(char* lpAppName, char* lpKeyName, char* lpString);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpString);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, char* lpString);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteProfileStringW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteProfileStringW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpString);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteProfileStringW(char* lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteProfileStringW(char* lpAppName, char* lpKeyName, char* lpString);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileSectionA(cpointer unfoundType_LPCSTR_lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpReturnedString, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileSectionA(cpointer unfoundType_LPCSTR_lpAppName, ReadOnlySpan<byte> lpReturnedString, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileSectionA(cpointer unfoundType_LPCSTR_lpAppName, byte* lpReturnedString, int nSize);
    [DllImport("kernel32", EntryPoint="GetProfileSectionW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileSection([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, string lpReturnedString, int nSize);
    [DllImport("kernel32", EntryPoint="GetProfileSectionW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileSection([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpReturnedString, int nSize);
    [DllImport("kernel32", EntryPoint="GetProfileSectionW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileSection(char* lpAppName, string lpReturnedString, int nSize);
    [DllImport("kernel32", EntryPoint="GetProfileSectionW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileSection(char* lpAppName, char* lpReturnedString, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileSectionW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, string lpReturnedString, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileSectionW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpReturnedString, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileSectionW(char* lpAppName, string lpReturnedString, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProfileSectionW(char* lpAppName, char* lpReturnedString, int nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteProfileSectionA(cpointer unfoundType_LPCSTR_lpAppName, cpointer unfoundType_LPCSTR_lpString);
    [DllImport("kernel32", EntryPoint="WriteProfileSectionW", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteProfileSection([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport("kernel32", EntryPoint="WriteProfileSectionW", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteProfileSection([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpString);
    [DllImport("kernel32", EntryPoint="WriteProfileSectionW", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteProfileSection(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport("kernel32", EntryPoint="WriteProfileSectionW", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteProfileSection(char* lpAppName, char* lpString);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteProfileSectionW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteProfileSectionW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpString);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteProfileSectionW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WriteProfileSectionW(char* lpAppName, char* lpString);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetPrivateProfileIntA(cpointer unfoundType_LPCSTR_lpAppName, cpointer unfoundType_LPCSTR_lpKeyName, int nDefault, cpointer unfoundType_LPCSTR_lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileIntW", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetPrivateProfileInt([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, int nDefault, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileIntW", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetPrivateProfileInt([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, int nDefault, char* lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileIntW", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetPrivateProfileInt([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, int nDefault, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileIntW", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetPrivateProfileInt([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, int nDefault, char* lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileIntW", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetPrivateProfileInt(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, int nDefault, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileIntW", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetPrivateProfileInt(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, int nDefault, char* lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileIntW", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetPrivateProfileInt(char* lpAppName, char* lpKeyName, int nDefault, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileIntW", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetPrivateProfileInt(char* lpAppName, char* lpKeyName, int nDefault, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetPrivateProfileIntW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, int nDefault, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetPrivateProfileIntW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, int nDefault, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetPrivateProfileIntW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, int nDefault, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetPrivateProfileIntW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, int nDefault, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetPrivateProfileIntW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, int nDefault, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetPrivateProfileIntW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, int nDefault, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetPrivateProfileIntW(char* lpAppName, char* lpKeyName, int nDefault, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetPrivateProfileIntW(char* lpAppName, char* lpKeyName, int nDefault, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStringA(cpointer unfoundType_LPCSTR_lpAppName, cpointer unfoundType_LPCSTR_lpKeyName, cpointer unfoundType_LPCSTR_lpDefault, [MarshalAs(UnmanagedType.LPStr)] string lpReturnedString, int nSize, cpointer unfoundType_LPCSTR_lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStringA(cpointer unfoundType_LPCSTR_lpAppName, cpointer unfoundType_LPCSTR_lpKeyName, cpointer unfoundType_LPCSTR_lpDefault, ReadOnlySpan<byte> lpReturnedString, int nSize, cpointer unfoundType_LPCSTR_lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStringA(cpointer unfoundType_LPCSTR_lpAppName, cpointer unfoundType_LPCSTR_lpKeyName, cpointer unfoundType_LPCSTR_lpDefault, byte* lpReturnedString, int nSize, cpointer unfoundType_LPCSTR_lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize, char* lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize, char* lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, string lpReturnedString, int nSize, char* lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, char* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, char* lpReturnedString, int nSize, char* lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize, char* lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize, char* lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, char* lpDefault, string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, char* lpDefault, string lpReturnedString, int nSize, char* lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, char* lpDefault, char* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, char* lpDefault, char* lpReturnedString, int nSize, char* lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileString(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileString(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize, char* lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileString(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileString(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize, char* lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileString(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileString(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, string lpReturnedString, int nSize, char* lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileString(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, char* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileString(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, char* lpReturnedString, int nSize, char* lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileString(char* lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileString(char* lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize, char* lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileString(char* lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileString(char* lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize, char* lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileString(char* lpAppName, char* lpKeyName, char* lpDefault, string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileString(char* lpAppName, char* lpKeyName, char* lpDefault, string lpReturnedString, int nSize, char* lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileString(char* lpAppName, char* lpKeyName, char* lpDefault, char* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileString(char* lpAppName, char* lpKeyName, char* lpDefault, char* lpReturnedString, int nSize, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, string lpReturnedString, int nSize, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, char* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, char* lpReturnedString, int nSize, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, char* lpDefault, string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, char* lpDefault, string lpReturnedString, int nSize, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, char* lpDefault, char* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, char* lpDefault, char* lpReturnedString, int nSize, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStringW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStringW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStringW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStringW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStringW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStringW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, string lpReturnedString, int nSize, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStringW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, char* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStringW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpDefault, char* lpReturnedString, int nSize, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStringW(char* lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStringW(char* lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, string lpReturnedString, int nSize, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStringW(char* lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStringW(char* lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, char* lpReturnedString, int nSize, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStringW(char* lpAppName, char* lpKeyName, char* lpDefault, string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStringW(char* lpAppName, char* lpKeyName, char* lpDefault, string lpReturnedString, int nSize, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStringW(char* lpAppName, char* lpKeyName, char* lpDefault, char* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStringW(char* lpAppName, char* lpKeyName, char* lpDefault, char* lpReturnedString, int nSize, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileStringA(cpointer unfoundType_LPCSTR_lpAppName, cpointer unfoundType_LPCSTR_lpKeyName, cpointer unfoundType_LPCSTR_lpString, cpointer unfoundType_LPCSTR_lpFileName);
    [DllImport("kernel32", EntryPoint="WritePrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", EntryPoint="WritePrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, char* lpFileName);
    [DllImport("kernel32", EntryPoint="WritePrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", EntryPoint="WritePrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpString, char* lpFileName);
    [DllImport("kernel32", EntryPoint="WritePrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", EntryPoint="WritePrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, char* lpFileName);
    [DllImport("kernel32", EntryPoint="WritePrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, char* lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", EntryPoint="WritePrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileString([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, char* lpString, char* lpFileName);
    [DllImport("kernel32", EntryPoint="WritePrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileString(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", EntryPoint="WritePrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileString(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, char* lpFileName);
    [DllImport("kernel32", EntryPoint="WritePrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileString(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", EntryPoint="WritePrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileString(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpString, char* lpFileName);
    [DllImport("kernel32", EntryPoint="WritePrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileString(char* lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", EntryPoint="WritePrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileString(char* lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, char* lpFileName);
    [DllImport("kernel32", EntryPoint="WritePrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileString(char* lpAppName, char* lpKeyName, char* lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", EntryPoint="WritePrivateProfileStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileString(char* lpAppName, char* lpKeyName, char* lpString, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpString, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, char* lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileStringW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpKeyName, char* lpString, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileStringW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileStringW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileStringW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileStringW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, char* lpString, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileStringW(char* lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileStringW(char* lpAppName, char* lpKeyName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileStringW(char* lpAppName, char* lpKeyName, char* lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileStringW(char* lpAppName, char* lpKeyName, char* lpString, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileSectionA(cpointer unfoundType_LPCSTR_lpAppName, [MarshalAs(UnmanagedType.LPStr)] string lpReturnedString, int nSize, cpointer unfoundType_LPCSTR_lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileSectionA(cpointer unfoundType_LPCSTR_lpAppName, ReadOnlySpan<byte> lpReturnedString, int nSize, cpointer unfoundType_LPCSTR_lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileSectionA(cpointer unfoundType_LPCSTR_lpAppName, byte* lpReturnedString, int nSize, cpointer unfoundType_LPCSTR_lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileSectionW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileSection([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileSectionW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileSection([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, string lpReturnedString, int nSize, char* lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileSectionW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileSection([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileSectionW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileSection([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpReturnedString, int nSize, char* lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileSectionW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileSection(char* lpAppName, string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileSectionW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileSection(char* lpAppName, string lpReturnedString, int nSize, char* lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileSectionW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileSection(char* lpAppName, char* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileSectionW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileSection(char* lpAppName, char* lpReturnedString, int nSize, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileSectionW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileSectionW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, string lpReturnedString, int nSize, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileSectionW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileSectionW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpReturnedString, int nSize, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileSectionW(char* lpAppName, string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileSectionW(char* lpAppName, string lpReturnedString, int nSize, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileSectionW(char* lpAppName, char* lpReturnedString, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileSectionW(char* lpAppName, char* lpReturnedString, int nSize, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileSectionA(cpointer unfoundType_LPCSTR_lpAppName, cpointer unfoundType_LPCSTR_lpString, cpointer unfoundType_LPCSTR_lpFileName);
    [DllImport("kernel32", EntryPoint="WritePrivateProfileSectionW", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileSection([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", EntryPoint="WritePrivateProfileSectionW", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileSection([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, char* lpFileName);
    [DllImport("kernel32", EntryPoint="WritePrivateProfileSectionW", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileSection([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", EntryPoint="WritePrivateProfileSectionW", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileSection([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpString, char* lpFileName);
    [DllImport("kernel32", EntryPoint="WritePrivateProfileSectionW", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileSection(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", EntryPoint="WritePrivateProfileSectionW", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileSection(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, char* lpFileName);
    [DllImport("kernel32", EntryPoint="WritePrivateProfileSectionW", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileSection(char* lpAppName, char* lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", EntryPoint="WritePrivateProfileSectionW", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileSection(char* lpAppName, char* lpString, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileSectionW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileSectionW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileSectionW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileSectionW([MarshalAs(UnmanagedType.LPWStr)] string lpAppName, char* lpString, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileSectionW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileSectionW(char* lpAppName, [MarshalAs(UnmanagedType.LPWStr)] string lpString, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileSectionW(char* lpAppName, char* lpString, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileSectionW(char* lpAppName, char* lpString, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileSectionNamesA([MarshalAs(UnmanagedType.LPStr)] string lpszReturnBuffer, int nSize, cpointer unfoundType_LPCSTR_lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileSectionNamesA(ReadOnlySpan<byte> lpszReturnBuffer, int nSize, cpointer unfoundType_LPCSTR_lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileSectionNamesA(byte* lpszReturnBuffer, int nSize, cpointer unfoundType_LPCSTR_lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileSectionNamesW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileSectionNames(string lpszReturnBuffer, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileSectionNamesW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileSectionNames(string lpszReturnBuffer, int nSize, char* lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileSectionNamesW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileSectionNames(char* lpszReturnBuffer, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileSectionNamesW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileSectionNames(char* lpszReturnBuffer, int nSize, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileSectionNamesW(string lpszReturnBuffer, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileSectionNamesW(string lpszReturnBuffer, int nSize, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileSectionNamesW(char* lpszReturnBuffer, int nSize, [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileSectionNamesW(char* lpszReturnBuffer, int nSize, char* lpFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStructA(cpointer unfoundType_LPCSTR_lpszSection, cpointer unfoundType_LPCSTR_lpszKey, cpointer lpStruct, uint uSizeStruct, cpointer unfoundType_LPCSTR_szFile);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileStructW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStruct([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, cpointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileStructW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStruct([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, cpointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileStructW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStruct([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, char* lpszKey, cpointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileStructW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStruct([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, char* lpszKey, cpointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileStructW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStruct(char* lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, cpointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileStructW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStruct(char* lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, cpointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileStructW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStruct(char* lpszSection, char* lpszKey, cpointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport("kernel32", EntryPoint="GetPrivateProfileStructW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStruct(char* lpszSection, char* lpszKey, cpointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStructW([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, cpointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStructW([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, cpointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStructW([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, char* lpszKey, cpointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStructW([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, char* lpszKey, cpointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStructW(char* lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, cpointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStructW(char* lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, cpointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStructW(char* lpszSection, char* lpszKey, cpointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPrivateProfileStructW(char* lpszSection, char* lpszKey, cpointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileStructA(cpointer unfoundType_LPCSTR_lpszSection, cpointer unfoundType_LPCSTR_lpszKey, cpointer lpStruct, uint uSizeStruct, cpointer unfoundType_LPCSTR_szFile);
    [DllImport("kernel32", EntryPoint="WritePrivateProfileStructW", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileStruct([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, cpointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport("kernel32", EntryPoint="WritePrivateProfileStructW", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileStruct([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, cpointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport("kernel32", EntryPoint="WritePrivateProfileStructW", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileStruct([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, char* lpszKey, cpointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport("kernel32", EntryPoint="WritePrivateProfileStructW", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileStruct([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, char* lpszKey, cpointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport("kernel32", EntryPoint="WritePrivateProfileStructW", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileStruct(char* lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, cpointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport("kernel32", EntryPoint="WritePrivateProfileStructW", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileStruct(char* lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, cpointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport("kernel32", EntryPoint="WritePrivateProfileStructW", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileStruct(char* lpszSection, char* lpszKey, cpointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport("kernel32", EntryPoint="WritePrivateProfileStructW", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileStruct(char* lpszSection, char* lpszKey, cpointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileStructW([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, cpointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileStructW([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, cpointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileStructW([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, char* lpszKey, cpointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileStructW([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, char* lpszKey, cpointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileStructW(char* lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, cpointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileStructW(char* lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, cpointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileStructW(char* lpszSection, char* lpszKey, cpointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WritePrivateProfileStructW(char* lpszSection, char* lpszKey, cpointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetDllDirectoryA(cpointer unfoundType_LPCSTR_lpPathName);
    [DllImport("kernel32", EntryPoint="SetDllDirectoryW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetDllDirectory([MarshalAs(UnmanagedType.LPWStr)] string lpPathName);
    [DllImport("kernel32", EntryPoint="SetDllDirectoryW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetDllDirectory(char* lpPathName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetDllDirectoryW([MarshalAs(UnmanagedType.LPWStr)] string lpPathName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetDllDirectoryW(char* lpPathName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDllDirectoryA(int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDllDirectoryA(int nBufferLength, ReadOnlySpan<byte> lpBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDllDirectoryA(int nBufferLength, byte* lpBuffer);
    [DllImport("kernel32", EntryPoint="GetDllDirectoryW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDllDirectory(int nBufferLength, string lpBuffer);
    [DllImport("kernel32", EntryPoint="GetDllDirectoryW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDllDirectory(int nBufferLength, char* lpBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDllDirectoryW(int nBufferLength, string lpBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDllDirectoryW(int nBufferLength, char* lpBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetSearchPathMode(int Flags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateDirectoryExA(cpointer unfoundType_LPCSTR_lpTemplateDirectory, cpointer unfoundType_LPCSTR_lpNewDirectory, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport("kernel32", EntryPoint="CreateDirectoryExW", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateDirectoryEx([MarshalAs(UnmanagedType.LPWStr)] string lpTemplateDirectory, [MarshalAs(UnmanagedType.LPWStr)] string lpNewDirectory, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport("kernel32", EntryPoint="CreateDirectoryExW", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateDirectoryEx([MarshalAs(UnmanagedType.LPWStr)] string lpTemplateDirectory, char* lpNewDirectory, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport("kernel32", EntryPoint="CreateDirectoryExW", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateDirectoryEx(char* lpTemplateDirectory, [MarshalAs(UnmanagedType.LPWStr)] string lpNewDirectory, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport("kernel32", EntryPoint="CreateDirectoryExW", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateDirectoryEx(char* lpTemplateDirectory, char* lpNewDirectory, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateDirectoryExW([MarshalAs(UnmanagedType.LPWStr)] string lpTemplateDirectory, [MarshalAs(UnmanagedType.LPWStr)] string lpNewDirectory, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateDirectoryExW([MarshalAs(UnmanagedType.LPWStr)] string lpTemplateDirectory, char* lpNewDirectory, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateDirectoryExW(char* lpTemplateDirectory, [MarshalAs(UnmanagedType.LPWStr)] string lpNewDirectory, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateDirectoryExW(char* lpTemplateDirectory, char* lpNewDirectory, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateDirectoryTransactedA(cpointer unfoundType_LPCSTR_lpTemplateDirectory, cpointer unfoundType_LPCSTR_lpNewDirectory, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="CreateDirectoryTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateDirectoryTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpTemplateDirectory, [MarshalAs(UnmanagedType.LPWStr)] string lpNewDirectory, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="CreateDirectoryTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateDirectoryTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpTemplateDirectory, char* lpNewDirectory, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="CreateDirectoryTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateDirectoryTransacted(char* lpTemplateDirectory, [MarshalAs(UnmanagedType.LPWStr)] string lpNewDirectory, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="CreateDirectoryTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateDirectoryTransacted(char* lpTemplateDirectory, char* lpNewDirectory, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateDirectoryTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpTemplateDirectory, [MarshalAs(UnmanagedType.LPWStr)] string lpNewDirectory, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateDirectoryTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpTemplateDirectory, char* lpNewDirectory, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateDirectoryTransactedW(char* lpTemplateDirectory, [MarshalAs(UnmanagedType.LPWStr)] string lpNewDirectory, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateDirectoryTransactedW(char* lpTemplateDirectory, char* lpNewDirectory, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int RemoveDirectoryTransactedA(cpointer unfoundType_LPCSTR_lpPathName, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="RemoveDirectoryTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        int RemoveDirectoryTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpPathName, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="RemoveDirectoryTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        int RemoveDirectoryTransacted(char* lpPathName, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int RemoveDirectoryTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpPathName, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int RemoveDirectoryTransactedW(char* lpPathName, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFullPathNameTransactedA(cpointer unfoundType_LPCSTR_lpFileName, int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, cpointer unfoundType_LPSTRlpFilePartlpFilePart_unnamed_3, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFullPathNameTransactedA(cpointer unfoundType_LPCSTR_lpFileName, int nBufferLength, ReadOnlySpan<byte> lpBuffer, cpointer unfoundType_LPSTRlpFilePartlpFilePart_unnamed_3, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFullPathNameTransactedA(cpointer unfoundType_LPCSTR_lpFileName, int nBufferLength, byte* lpBuffer, cpointer unfoundType_LPSTRlpFilePartlpFilePart_unnamed_3, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="GetFullPathNameTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFullPathNameTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int nBufferLength, string lpBuffer, cpointer unfoundType_LPWSTRlpFilePartlpFilePart_unnamed_3, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="GetFullPathNameTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFullPathNameTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int nBufferLength, char* lpBuffer, cpointer unfoundType_LPWSTRlpFilePartlpFilePart_unnamed_3, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="GetFullPathNameTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFullPathNameTransacted(char* lpFileName, int nBufferLength, string lpBuffer, cpointer unfoundType_LPWSTRlpFilePartlpFilePart_unnamed_3, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="GetFullPathNameTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFullPathNameTransacted(char* lpFileName, int nBufferLength, char* lpBuffer, cpointer unfoundType_LPWSTRlpFilePartlpFilePart_unnamed_3, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFullPathNameTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int nBufferLength, string lpBuffer, cpointer unfoundType_LPWSTRlpFilePartlpFilePart_unnamed_3, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFullPathNameTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int nBufferLength, char* lpBuffer, cpointer unfoundType_LPWSTRlpFilePartlpFilePart_unnamed_3, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFullPathNameTransactedW(char* lpFileName, int nBufferLength, string lpBuffer, cpointer unfoundType_LPWSTRlpFilePartlpFilePart_unnamed_3, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFullPathNameTransactedW(char* lpFileName, int nBufferLength, char* lpBuffer, cpointer unfoundType_LPWSTRlpFilePartlpFilePart_unnamed_3, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DefineDosDeviceA(int dwFlags, cpointer unfoundType_LPCSTR_lpDeviceName, cpointer unfoundType_LPCSTR_lpTargetPath);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryDosDeviceA(cpointer unfoundType_LPCSTR_lpDeviceName, [MarshalAs(UnmanagedType.LPStr)] string lpTargetPath, int ucchMax);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryDosDeviceA(cpointer unfoundType_LPCSTR_lpDeviceName, ReadOnlySpan<byte> lpTargetPath, int ucchMax);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryDosDeviceA(cpointer unfoundType_LPCSTR_lpDeviceName, byte* lpTargetPath, int ucchMax);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateFileTransactedA(cpointer unfoundType_LPCSTR_lpFileName, int dwDesiredAccess, int dwShareMode, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, cpointer hTemplateFile, cpointer hTransaction, cpointer unfoundType_PUSHORT_pusMiniVersion, cpointer lpExtendedParameter);
    [DllImport("kernel32", EntryPoint="CreateFileTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateFileTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwDesiredAccess, int dwShareMode, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, cpointer hTemplateFile, cpointer hTransaction, cpointer unfoundType_PUSHORT_pusMiniVersion, cpointer lpExtendedParameter);
    [DllImport("kernel32", EntryPoint="CreateFileTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateFileTransacted(char* lpFileName, int dwDesiredAccess, int dwShareMode, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, cpointer hTemplateFile, cpointer hTransaction, cpointer unfoundType_PUSHORT_pusMiniVersion, cpointer lpExtendedParameter);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateFileTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwDesiredAccess, int dwShareMode, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, cpointer hTemplateFile, cpointer hTransaction, cpointer unfoundType_PUSHORT_pusMiniVersion, cpointer lpExtendedParameter);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateFileTransactedW(char* lpFileName, int dwDesiredAccess, int dwShareMode, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, cpointer hTemplateFile, cpointer hTransaction, cpointer unfoundType_PUSHORT_pusMiniVersion, cpointer lpExtendedParameter);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer ReOpenFile(cpointer hOriginalFile, int dwDesiredAccess, int dwShareMode, int dwFlagsAndAttributes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetFileAttributesTransactedA(cpointer unfoundType_LPCSTR_lpFileName, int dwFileAttributes, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="SetFileAttributesTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetFileAttributesTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwFileAttributes, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="SetFileAttributesTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetFileAttributesTransacted(char* lpFileName, int dwFileAttributes, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetFileAttributesTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwFileAttributes, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetFileAttributesTransactedW(char* lpFileName, int dwFileAttributes, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFileAttributesTransactedA(cpointer unfoundType_LPCSTR_lpFileName, cpointer unfoundType_GET_FILEEX_INFO_LEVELS_fInfoLevelId, cpointer lpFileInformation, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="GetFileAttributesTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFileAttributesTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, cpointer unfoundType_GET_FILEEX_INFO_LEVELS_fInfoLevelId, cpointer lpFileInformation, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="GetFileAttributesTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFileAttributesTransacted(char* lpFileName, cpointer unfoundType_GET_FILEEX_INFO_LEVELS_fInfoLevelId, cpointer lpFileInformation, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFileAttributesTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, cpointer unfoundType_GET_FILEEX_INFO_LEVELS_fInfoLevelId, cpointer lpFileInformation, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFileAttributesTransactedW(char* lpFileName, cpointer unfoundType_GET_FILEEX_INFO_LEVELS_fInfoLevelId, cpointer lpFileInformation, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCompressedFileSizeTransactedA(cpointer unfoundType_LPCSTR_lpFileName, cpointer unfoundType_LPDWORD_lpFileSizeHigh, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="GetCompressedFileSizeTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCompressedFileSizeTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, cpointer unfoundType_LPDWORD_lpFileSizeHigh, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="GetCompressedFileSizeTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCompressedFileSizeTransacted(char* lpFileName, cpointer unfoundType_LPDWORD_lpFileSizeHigh, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCompressedFileSizeTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, cpointer unfoundType_LPDWORD_lpFileSizeHigh, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCompressedFileSizeTransactedW(char* lpFileName, cpointer unfoundType_LPDWORD_lpFileSizeHigh, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DeleteFileTransactedA(cpointer unfoundType_LPCSTR_lpFileName, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="DeleteFileTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        int DeleteFileTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="DeleteFileTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        int DeleteFileTransacted(char* lpFileName, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DeleteFileTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DeleteFileTransactedW(char* lpFileName, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CheckNameLegalDOS8Dot3A(cpointer unfoundType_LPCSTR_lpName, [MarshalAs(UnmanagedType.LPStr)] string lpOemName, int OemNameSize, cpointer pbNameContainsSpaces, cpointer pbNameLegal);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CheckNameLegalDOS8Dot3A(cpointer unfoundType_LPCSTR_lpName, ReadOnlySpan<byte> lpOemName, int OemNameSize, cpointer pbNameContainsSpaces, cpointer pbNameLegal);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CheckNameLegalDOS8Dot3A(cpointer unfoundType_LPCSTR_lpName, byte* lpOemName, int OemNameSize, cpointer pbNameContainsSpaces, cpointer pbNameLegal);
    [DllImport("kernel32", EntryPoint="CheckNameLegalDOS8Dot3W", SetLastError=true, ExactSpelling=true)] public static extern
        int CheckNameLegalDOS8Dot3([MarshalAs(UnmanagedType.LPWStr)] string lpName, [MarshalAs(UnmanagedType.LPStr)] string lpOemName, int OemNameSize, cpointer pbNameContainsSpaces, cpointer pbNameLegal);
    [DllImport("kernel32", EntryPoint="CheckNameLegalDOS8Dot3W", SetLastError=true, ExactSpelling=true)] public static extern
        int CheckNameLegalDOS8Dot3([MarshalAs(UnmanagedType.LPWStr)] string lpName, ReadOnlySpan<byte> lpOemName, int OemNameSize, cpointer pbNameContainsSpaces, cpointer pbNameLegal);
    [DllImport("kernel32", EntryPoint="CheckNameLegalDOS8Dot3W", SetLastError=true, ExactSpelling=true)] public static extern
        int CheckNameLegalDOS8Dot3([MarshalAs(UnmanagedType.LPWStr)] string lpName, byte* lpOemName, int OemNameSize, cpointer pbNameContainsSpaces, cpointer pbNameLegal);
    [DllImport("kernel32", EntryPoint="CheckNameLegalDOS8Dot3W", SetLastError=true, ExactSpelling=true)] public static extern
        int CheckNameLegalDOS8Dot3(char* lpName, [MarshalAs(UnmanagedType.LPStr)] string lpOemName, int OemNameSize, cpointer pbNameContainsSpaces, cpointer pbNameLegal);
    [DllImport("kernel32", EntryPoint="CheckNameLegalDOS8Dot3W", SetLastError=true, ExactSpelling=true)] public static extern
        int CheckNameLegalDOS8Dot3(char* lpName, ReadOnlySpan<byte> lpOemName, int OemNameSize, cpointer pbNameContainsSpaces, cpointer pbNameLegal);
    [DllImport("kernel32", EntryPoint="CheckNameLegalDOS8Dot3W", SetLastError=true, ExactSpelling=true)] public static extern
        int CheckNameLegalDOS8Dot3(char* lpName, byte* lpOemName, int OemNameSize, cpointer pbNameContainsSpaces, cpointer pbNameLegal);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CheckNameLegalDOS8Dot3W([MarshalAs(UnmanagedType.LPWStr)] string lpName, [MarshalAs(UnmanagedType.LPStr)] string lpOemName, int OemNameSize, cpointer pbNameContainsSpaces, cpointer pbNameLegal);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CheckNameLegalDOS8Dot3W([MarshalAs(UnmanagedType.LPWStr)] string lpName, ReadOnlySpan<byte> lpOemName, int OemNameSize, cpointer pbNameContainsSpaces, cpointer pbNameLegal);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CheckNameLegalDOS8Dot3W([MarshalAs(UnmanagedType.LPWStr)] string lpName, byte* lpOemName, int OemNameSize, cpointer pbNameContainsSpaces, cpointer pbNameLegal);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CheckNameLegalDOS8Dot3W(char* lpName, [MarshalAs(UnmanagedType.LPStr)] string lpOemName, int OemNameSize, cpointer pbNameContainsSpaces, cpointer pbNameLegal);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CheckNameLegalDOS8Dot3W(char* lpName, ReadOnlySpan<byte> lpOemName, int OemNameSize, cpointer pbNameContainsSpaces, cpointer pbNameLegal);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CheckNameLegalDOS8Dot3W(char* lpName, byte* lpOemName, int OemNameSize, cpointer pbNameContainsSpaces, cpointer pbNameLegal);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstFileTransactedA(cpointer unfoundType_LPCSTR_lpFileName, cpointer unfoundType_FINDEX_INFO_LEVELS_fInfoLevelId, cpointer lpFindFileData, cpointer unfoundType_FINDEX_SEARCH_OPS_fSearchOp, cpointer lpSearchFilter, int dwAdditionalFlags, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="FindFirstFileTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstFileTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, cpointer unfoundType_FINDEX_INFO_LEVELS_fInfoLevelId, cpointer lpFindFileData, cpointer unfoundType_FINDEX_SEARCH_OPS_fSearchOp, cpointer lpSearchFilter, int dwAdditionalFlags, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="FindFirstFileTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstFileTransacted(char* lpFileName, cpointer unfoundType_FINDEX_INFO_LEVELS_fInfoLevelId, cpointer lpFindFileData, cpointer unfoundType_FINDEX_SEARCH_OPS_fSearchOp, cpointer lpSearchFilter, int dwAdditionalFlags, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstFileTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, cpointer unfoundType_FINDEX_INFO_LEVELS_fInfoLevelId, cpointer lpFindFileData, cpointer unfoundType_FINDEX_SEARCH_OPS_fSearchOp, cpointer lpSearchFilter, int dwAdditionalFlags, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstFileTransactedW(char* lpFileName, cpointer unfoundType_FINDEX_INFO_LEVELS_fInfoLevelId, cpointer lpFindFileData, cpointer unfoundType_FINDEX_SEARCH_OPS_fSearchOp, cpointer lpSearchFilter, int dwAdditionalFlags, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CopyFileA(cpointer unfoundType_LPCSTR_lpExistingFileName, cpointer unfoundType_LPCSTR_lpNewFileName, int bFailIfExists);
    [DllImport("kernel32", EntryPoint="CopyFileW", SetLastError=true, ExactSpelling=true)] public static extern
        int CopyFile([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, int bFailIfExists);
    [DllImport("kernel32", EntryPoint="CopyFileW", SetLastError=true, ExactSpelling=true)] public static extern
        int CopyFile([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, char* lpNewFileName, int bFailIfExists);
    [DllImport("kernel32", EntryPoint="CopyFileW", SetLastError=true, ExactSpelling=true)] public static extern
        int CopyFile(char* lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, int bFailIfExists);
    [DllImport("kernel32", EntryPoint="CopyFileW", SetLastError=true, ExactSpelling=true)] public static extern
        int CopyFile(char* lpExistingFileName, char* lpNewFileName, int bFailIfExists);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CopyFileW([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, int bFailIfExists);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CopyFileW([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, char* lpNewFileName, int bFailIfExists);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CopyFileW(char* lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, int bFailIfExists);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CopyFileW(char* lpExistingFileName, char* lpNewFileName, int bFailIfExists);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CopyFileExA(cpointer unfoundType_LPCSTR_lpExistingFileName, cpointer unfoundType_LPCSTR_lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, cpointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags);
    [DllImport("kernel32", EntryPoint="CopyFileExW", SetLastError=true, ExactSpelling=true)] public static extern
        int CopyFileEx([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, cpointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags);
    [DllImport("kernel32", EntryPoint="CopyFileExW", SetLastError=true, ExactSpelling=true)] public static extern
        int CopyFileEx([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, char* lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, cpointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags);
    [DllImport("kernel32", EntryPoint="CopyFileExW", SetLastError=true, ExactSpelling=true)] public static extern
        int CopyFileEx(char* lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, cpointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags);
    [DllImport("kernel32", EntryPoint="CopyFileExW", SetLastError=true, ExactSpelling=true)] public static extern
        int CopyFileEx(char* lpExistingFileName, char* lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, cpointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CopyFileExW([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, cpointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CopyFileExW([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, char* lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, cpointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CopyFileExW(char* lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, cpointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CopyFileExW(char* lpExistingFileName, char* lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, cpointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CopyFileTransactedA(cpointer unfoundType_LPCSTR_lpExistingFileName, cpointer unfoundType_LPCSTR_lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, cpointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="CopyFileTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        int CopyFileTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, cpointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="CopyFileTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        int CopyFileTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, char* lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, cpointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="CopyFileTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        int CopyFileTransacted(char* lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, cpointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="CopyFileTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        int CopyFileTransacted(char* lpExistingFileName, char* lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, cpointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CopyFileTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, cpointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CopyFileTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, char* lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, cpointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CopyFileTransactedW(char* lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, cpointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CopyFileTransactedW(char* lpExistingFileName, char* lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, cpointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CopyFile2([MarshalAs(UnmanagedType.LPWStr)] string pwszExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string pwszNewFileName, cpointer unfoundType_COPYFILE2_EXTENDED_PARAMETERSpExtendedParameterspExtendedParameters_unnamed_2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CopyFile2([MarshalAs(UnmanagedType.LPWStr)] string pwszExistingFileName, char* pwszNewFileName, cpointer unfoundType_COPYFILE2_EXTENDED_PARAMETERSpExtendedParameterspExtendedParameters_unnamed_2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CopyFile2(char* pwszExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string pwszNewFileName, cpointer unfoundType_COPYFILE2_EXTENDED_PARAMETERSpExtendedParameterspExtendedParameters_unnamed_2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CopyFile2(char* pwszExistingFileName, char* pwszNewFileName, cpointer unfoundType_COPYFILE2_EXTENDED_PARAMETERSpExtendedParameterspExtendedParameters_unnamed_2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int MoveFileA(cpointer unfoundType_LPCSTR_lpExistingFileName, cpointer unfoundType_LPCSTR_lpNewFileName);
    [DllImport("kernel32", EntryPoint="MoveFileW", SetLastError=true, ExactSpelling=true)] public static extern
        int MoveFile([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName);
    [DllImport("kernel32", EntryPoint="MoveFileW", SetLastError=true, ExactSpelling=true)] public static extern
        int MoveFile([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, char* lpNewFileName);
    [DllImport("kernel32", EntryPoint="MoveFileW", SetLastError=true, ExactSpelling=true)] public static extern
        int MoveFile(char* lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName);
    [DllImport("kernel32", EntryPoint="MoveFileW", SetLastError=true, ExactSpelling=true)] public static extern
        int MoveFile(char* lpExistingFileName, char* lpNewFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int MoveFileW([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int MoveFileW([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, char* lpNewFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int MoveFileW(char* lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int MoveFileW(char* lpExistingFileName, char* lpNewFileName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int MoveFileExA(cpointer unfoundType_LPCSTR_lpExistingFileName, cpointer unfoundType_LPCSTR_lpNewFileName, int dwFlags);
    [DllImport("kernel32", EntryPoint="MoveFileExW", SetLastError=true, ExactSpelling=true)] public static extern
        int MoveFileEx([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, int dwFlags);
    [DllImport("kernel32", EntryPoint="MoveFileExW", SetLastError=true, ExactSpelling=true)] public static extern
        int MoveFileEx([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, char* lpNewFileName, int dwFlags);
    [DllImport("kernel32", EntryPoint="MoveFileExW", SetLastError=true, ExactSpelling=true)] public static extern
        int MoveFileEx(char* lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, int dwFlags);
    [DllImport("kernel32", EntryPoint="MoveFileExW", SetLastError=true, ExactSpelling=true)] public static extern
        int MoveFileEx(char* lpExistingFileName, char* lpNewFileName, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int MoveFileExW([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int MoveFileExW([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, char* lpNewFileName, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int MoveFileExW(char* lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int MoveFileExW(char* lpExistingFileName, char* lpNewFileName, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int MoveFileWithProgressA(cpointer unfoundType_LPCSTR_lpExistingFileName, cpointer unfoundType_LPCSTR_lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, int dwFlags);
    [DllImport("kernel32", EntryPoint="MoveFileWithProgressW", SetLastError=true, ExactSpelling=true)] public static extern
        int MoveFileWithProgress([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, int dwFlags);
    [DllImport("kernel32", EntryPoint="MoveFileWithProgressW", SetLastError=true, ExactSpelling=true)] public static extern
        int MoveFileWithProgress([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, char* lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, int dwFlags);
    [DllImport("kernel32", EntryPoint="MoveFileWithProgressW", SetLastError=true, ExactSpelling=true)] public static extern
        int MoveFileWithProgress(char* lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, int dwFlags);
    [DllImport("kernel32", EntryPoint="MoveFileWithProgressW", SetLastError=true, ExactSpelling=true)] public static extern
        int MoveFileWithProgress(char* lpExistingFileName, char* lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int MoveFileWithProgressW([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int MoveFileWithProgressW([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, char* lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int MoveFileWithProgressW(char* lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int MoveFileWithProgressW(char* lpExistingFileName, char* lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int MoveFileTransactedA(cpointer unfoundType_LPCSTR_lpExistingFileName, cpointer unfoundType_LPCSTR_lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, int dwFlags, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="MoveFileTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        int MoveFileTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, int dwFlags, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="MoveFileTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        int MoveFileTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, char* lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, int dwFlags, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="MoveFileTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        int MoveFileTransacted(char* lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, int dwFlags, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="MoveFileTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        int MoveFileTransacted(char* lpExistingFileName, char* lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, int dwFlags, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int MoveFileTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, int dwFlags, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int MoveFileTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, char* lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, int dwFlags, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int MoveFileTransactedW(char* lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, int dwFlags, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int MoveFileTransactedW(char* lpExistingFileName, char* lpNewFileName, cpointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, cpointer lpData, int dwFlags, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ReplaceFileA(cpointer unfoundType_LPCSTR_lpReplacedFileName, cpointer unfoundType_LPCSTR_lpReplacementFileName, cpointer unfoundType_LPCSTR_lpBackupFileName, int dwReplaceFlags, cpointer lpExclude, cpointer lpReserved);
    [DllImport("kernel32", EntryPoint="ReplaceFileW", SetLastError=true, ExactSpelling=true)] public static extern
        int ReplaceFile([MarshalAs(UnmanagedType.LPWStr)] string lpReplacedFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpReplacementFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpBackupFileName, int dwReplaceFlags, cpointer lpExclude, cpointer lpReserved);
    [DllImport("kernel32", EntryPoint="ReplaceFileW", SetLastError=true, ExactSpelling=true)] public static extern
        int ReplaceFile([MarshalAs(UnmanagedType.LPWStr)] string lpReplacedFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpReplacementFileName, char* lpBackupFileName, int dwReplaceFlags, cpointer lpExclude, cpointer lpReserved);
    [DllImport("kernel32", EntryPoint="ReplaceFileW", SetLastError=true, ExactSpelling=true)] public static extern
        int ReplaceFile([MarshalAs(UnmanagedType.LPWStr)] string lpReplacedFileName, char* lpReplacementFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpBackupFileName, int dwReplaceFlags, cpointer lpExclude, cpointer lpReserved);
    [DllImport("kernel32", EntryPoint="ReplaceFileW", SetLastError=true, ExactSpelling=true)] public static extern
        int ReplaceFile([MarshalAs(UnmanagedType.LPWStr)] string lpReplacedFileName, char* lpReplacementFileName, char* lpBackupFileName, int dwReplaceFlags, cpointer lpExclude, cpointer lpReserved);
    [DllImport("kernel32", EntryPoint="ReplaceFileW", SetLastError=true, ExactSpelling=true)] public static extern
        int ReplaceFile(char* lpReplacedFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpReplacementFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpBackupFileName, int dwReplaceFlags, cpointer lpExclude, cpointer lpReserved);
    [DllImport("kernel32", EntryPoint="ReplaceFileW", SetLastError=true, ExactSpelling=true)] public static extern
        int ReplaceFile(char* lpReplacedFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpReplacementFileName, char* lpBackupFileName, int dwReplaceFlags, cpointer lpExclude, cpointer lpReserved);
    [DllImport("kernel32", EntryPoint="ReplaceFileW", SetLastError=true, ExactSpelling=true)] public static extern
        int ReplaceFile(char* lpReplacedFileName, char* lpReplacementFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpBackupFileName, int dwReplaceFlags, cpointer lpExclude, cpointer lpReserved);
    [DllImport("kernel32", EntryPoint="ReplaceFileW", SetLastError=true, ExactSpelling=true)] public static extern
        int ReplaceFile(char* lpReplacedFileName, char* lpReplacementFileName, char* lpBackupFileName, int dwReplaceFlags, cpointer lpExclude, cpointer lpReserved);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ReplaceFileW([MarshalAs(UnmanagedType.LPWStr)] string lpReplacedFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpReplacementFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpBackupFileName, int dwReplaceFlags, cpointer lpExclude, cpointer lpReserved);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ReplaceFileW([MarshalAs(UnmanagedType.LPWStr)] string lpReplacedFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpReplacementFileName, char* lpBackupFileName, int dwReplaceFlags, cpointer lpExclude, cpointer lpReserved);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ReplaceFileW([MarshalAs(UnmanagedType.LPWStr)] string lpReplacedFileName, char* lpReplacementFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpBackupFileName, int dwReplaceFlags, cpointer lpExclude, cpointer lpReserved);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ReplaceFileW([MarshalAs(UnmanagedType.LPWStr)] string lpReplacedFileName, char* lpReplacementFileName, char* lpBackupFileName, int dwReplaceFlags, cpointer lpExclude, cpointer lpReserved);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ReplaceFileW(char* lpReplacedFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpReplacementFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpBackupFileName, int dwReplaceFlags, cpointer lpExclude, cpointer lpReserved);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ReplaceFileW(char* lpReplacedFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpReplacementFileName, char* lpBackupFileName, int dwReplaceFlags, cpointer lpExclude, cpointer lpReserved);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ReplaceFileW(char* lpReplacedFileName, char* lpReplacementFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpBackupFileName, int dwReplaceFlags, cpointer lpExclude, cpointer lpReserved);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ReplaceFileW(char* lpReplacedFileName, char* lpReplacementFileName, char* lpBackupFileName, int dwReplaceFlags, cpointer lpExclude, cpointer lpReserved);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateHardLinkA(cpointer unfoundType_LPCSTR_lpFileName, cpointer unfoundType_LPCSTR_lpExistingFileName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport("kernel32", EntryPoint="CreateHardLinkW", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateHardLink([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport("kernel32", EntryPoint="CreateHardLinkW", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateHardLink([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExistingFileName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport("kernel32", EntryPoint="CreateHardLinkW", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateHardLink(char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport("kernel32", EntryPoint="CreateHardLinkW", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateHardLink(char* lpFileName, char* lpExistingFileName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateHardLinkW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateHardLinkW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExistingFileName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateHardLinkW(char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateHardLinkW(char* lpFileName, char* lpExistingFileName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateHardLinkTransactedA(cpointer unfoundType_LPCSTR_lpFileName, cpointer unfoundType_LPCSTR_lpExistingFileName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="CreateHardLinkTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateHardLinkTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="CreateHardLinkTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateHardLinkTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExistingFileName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="CreateHardLinkTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateHardLinkTransacted(char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="CreateHardLinkTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateHardLinkTransacted(char* lpFileName, char* lpExistingFileName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateHardLinkTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateHardLinkTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExistingFileName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateHardLinkTransactedW(char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateHardLinkTransactedW(char* lpFileName, char* lpExistingFileName, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="FindFirstStreamTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstStreamTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, cpointer unfoundType_STREAM_INFO_LEVELS_InfoLevel, cpointer lpFindStreamData, int dwFlags, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="FindFirstStreamTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstStreamTransacted(char* lpFileName, cpointer unfoundType_STREAM_INFO_LEVELS_InfoLevel, cpointer lpFindStreamData, int dwFlags, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstStreamTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, cpointer unfoundType_STREAM_INFO_LEVELS_InfoLevel, cpointer lpFindStreamData, int dwFlags, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstStreamTransactedW(char* lpFileName, cpointer unfoundType_STREAM_INFO_LEVELS_InfoLevel, cpointer lpFindStreamData, int dwFlags, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="FindFirstFileNameTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstFileNameTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwFlags, cpointer unfoundType_LPDWORD_StringLength, [MarshalAs(UnmanagedType.LPWStr)] string LinkName, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="FindFirstFileNameTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstFileNameTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwFlags, cpointer unfoundType_LPDWORD_StringLength, char* LinkName, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="FindFirstFileNameTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstFileNameTransacted(char* lpFileName, int dwFlags, cpointer unfoundType_LPDWORD_StringLength, [MarshalAs(UnmanagedType.LPWStr)] string LinkName, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="FindFirstFileNameTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstFileNameTransacted(char* lpFileName, int dwFlags, cpointer unfoundType_LPDWORD_StringLength, char* LinkName, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstFileNameTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwFlags, cpointer unfoundType_LPDWORD_StringLength, [MarshalAs(UnmanagedType.LPWStr)] string LinkName, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstFileNameTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwFlags, cpointer unfoundType_LPDWORD_StringLength, char* LinkName, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstFileNameTransactedW(char* lpFileName, int dwFlags, cpointer unfoundType_LPDWORD_StringLength, [MarshalAs(UnmanagedType.LPWStr)] string LinkName, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstFileNameTransactedW(char* lpFileName, int dwFlags, cpointer unfoundType_LPDWORD_StringLength, char* LinkName, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateNamedPipeA(cpointer unfoundType_LPCSTR_lpName, int dwOpenMode, int dwPipeMode, int nMaxInstances, int nOutBufferSize, int nInBufferSize, int nDefaultTimeOut, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNamedPipeHandleStateA(cpointer hNamedPipe, cpointer unfoundType_LPDWORD_lpState, cpointer unfoundType_LPDWORD_lpCurInstances, cpointer unfoundType_LPDWORD_lpMaxCollectionCount, cpointer unfoundType_LPDWORD_lpCollectDataTimeout, [MarshalAs(UnmanagedType.LPStr)] string lpUserName, int nMaxUserNameSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNamedPipeHandleStateA(cpointer hNamedPipe, cpointer unfoundType_LPDWORD_lpState, cpointer unfoundType_LPDWORD_lpCurInstances, cpointer unfoundType_LPDWORD_lpMaxCollectionCount, cpointer unfoundType_LPDWORD_lpCollectDataTimeout, ReadOnlySpan<byte> lpUserName, int nMaxUserNameSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNamedPipeHandleStateA(cpointer hNamedPipe, cpointer unfoundType_LPDWORD_lpState, cpointer unfoundType_LPDWORD_lpCurInstances, cpointer unfoundType_LPDWORD_lpMaxCollectionCount, cpointer unfoundType_LPDWORD_lpCollectDataTimeout, byte* lpUserName, int nMaxUserNameSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CallNamedPipeA(cpointer unfoundType_LPCSTR_lpNamedPipeName, cpointer lpInBuffer, int nInBufferSize, cpointer lpOutBuffer, int nOutBufferSize, cpointer unfoundType_LPDWORD_lpBytesRead, int nTimeOut);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WaitNamedPipeA(cpointer unfoundType_LPCSTR_lpNamedPipeName, int nTimeOut);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNamedPipeClientComputerNameA(cpointer Pipe, [MarshalAs(UnmanagedType.LPStr)] string ClientComputerName, uint ClientComputerNameLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNamedPipeClientComputerNameA(cpointer Pipe, ReadOnlySpan<byte> ClientComputerName, uint ClientComputerNameLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNamedPipeClientComputerNameA(cpointer Pipe, byte* ClientComputerName, uint ClientComputerNameLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNamedPipeClientProcessId(cpointer Pipe, cpointer unfoundType_PULONG_ClientProcessId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNamedPipeClientSessionId(cpointer Pipe, cpointer unfoundType_PULONG_ClientSessionId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNamedPipeServerProcessId(cpointer Pipe, cpointer unfoundType_PULONG_ServerProcessId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNamedPipeServerSessionId(cpointer Pipe, cpointer unfoundType_PULONG_ServerSessionId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetVolumeLabelA(cpointer unfoundType_LPCSTR_lpRootPathName, cpointer unfoundType_LPCSTR_lpVolumeName);
    [DllImport("kernel32", EntryPoint="SetVolumeLabelW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetVolumeLabel([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, [MarshalAs(UnmanagedType.LPWStr)] string lpVolumeName);
    [DllImport("kernel32", EntryPoint="SetVolumeLabelW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetVolumeLabel([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, char* lpVolumeName);
    [DllImport("kernel32", EntryPoint="SetVolumeLabelW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetVolumeLabel(char* lpRootPathName, [MarshalAs(UnmanagedType.LPWStr)] string lpVolumeName);
    [DllImport("kernel32", EntryPoint="SetVolumeLabelW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetVolumeLabel(char* lpRootPathName, char* lpVolumeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetVolumeLabelW([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, [MarshalAs(UnmanagedType.LPWStr)] string lpVolumeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetVolumeLabelW([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, char* lpVolumeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetVolumeLabelW(char* lpRootPathName, [MarshalAs(UnmanagedType.LPWStr)] string lpVolumeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetVolumeLabelW(char* lpRootPathName, char* lpVolumeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetFileBandwidthReservation(cpointer hFile, int nPeriodMilliseconds, int nBytesPerPeriod, int bDiscardable, cpointer unfoundType_LPDWORD_lpTransferSize, cpointer unfoundType_LPDWORD_lpNumOutstandingRequests);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFileBandwidthReservation(cpointer hFile, cpointer unfoundType_LPDWORD_lpPeriodMilliseconds, cpointer unfoundType_LPDWORD_lpBytesPerPeriod, cpointer unfoundType_LPBOOL_pDiscardable, cpointer unfoundType_LPDWORD_lpTransferSize, cpointer unfoundType_LPDWORD_lpNumOutstandingRequests);
    [DllImport("kernel32", EntryPoint="ReadDirectoryChangesW", SetLastError=true, ExactSpelling=true)] public static extern
        int ReadDirectoryChanges(cpointer hDirectory, cpointer lpBuffer, int nBufferLength, int bWatchSubtree, int dwNotifyFilter, cpointer unfoundType_LPDWORD_lpBytesReturned, cpointer unfoundType_LPOVERLAPPED_lpOverlapped, cpointer unfoundType_LPOVERLAPPED_COMPLETION_ROUTINE_lpCompletionRoutine);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ReadDirectoryChangesW(cpointer hDirectory, cpointer lpBuffer, int nBufferLength, int bWatchSubtree, int dwNotifyFilter, cpointer unfoundType_LPDWORD_lpBytesReturned, cpointer unfoundType_LPOVERLAPPED_lpOverlapped, cpointer unfoundType_LPOVERLAPPED_COMPLETION_ROUTINE_lpCompletionRoutine);
    [DllImport("kernel32", EntryPoint="ReadDirectoryChangesExW", SetLastError=true, ExactSpelling=true)] public static extern
        int ReadDirectoryChangesEx(cpointer hDirectory, cpointer lpBuffer, int nBufferLength, int bWatchSubtree, int dwNotifyFilter, cpointer unfoundType_LPDWORD_lpBytesReturned, cpointer unfoundType_LPOVERLAPPED_lpOverlapped, cpointer unfoundType_LPOVERLAPPED_COMPLETION_ROUTINE_lpCompletionRoutine, cpointer unfoundType_READ_DIRECTORY_NOTIFY_INFORMATION_CLASS_ReadDirectoryNotifyInformationClass);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ReadDirectoryChangesExW(cpointer hDirectory, cpointer lpBuffer, int nBufferLength, int bWatchSubtree, int dwNotifyFilter, cpointer unfoundType_LPDWORD_lpBytesReturned, cpointer unfoundType_LPOVERLAPPED_lpOverlapped, cpointer unfoundType_LPOVERLAPPED_COMPLETION_ROUTINE_lpCompletionRoutine, cpointer unfoundType_READ_DIRECTORY_NOTIFY_INFORMATION_CLASS_ReadDirectoryNotifyInformationClass);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer MapViewOfFileExNuma(cpointer hFileMappingObject, int dwDesiredAccess, int dwFileOffsetHigh, int dwFileOffsetLow, cpointer dwNumberOfBytesToMap, cpointer lpBaseAddress, int nndPreferred);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsBadReadPtr(cpointer unfoundType_VOIDlplp_unnamed_0, ulong ucb);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsBadWritePtr(cpointer lp, ulong ucb);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsBadHugeReadPtr(cpointer unfoundType_VOIDlplp_unnamed_0, ulong ucb);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsBadHugeWritePtr(cpointer lp, ulong ucb);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsBadCodePtr(cpointer unfoundType__In_opt_PROC_lpfn);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsBadStringPtrA(cpointer unfoundType_LPCSTR_lpsz, ulong ucchMax);
    [DllImport("kernel32", EntryPoint="IsBadStringPtrW", SetLastError=true, ExactSpelling=true)] public static extern
        int IsBadStringPtr([MarshalAs(UnmanagedType.LPWStr)] string lpsz, ulong ucchMax);
    [DllImport("kernel32", EntryPoint="IsBadStringPtrW", SetLastError=true, ExactSpelling=true)] public static extern
        int IsBadStringPtr(char* lpsz, ulong ucchMax);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsBadStringPtrW([MarshalAs(UnmanagedType.LPWStr)] string lpsz, ulong ucchMax);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsBadStringPtrW(char* lpsz, ulong ucchMax);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int BuildCommDCBA(cpointer unfoundType_LPCSTR_lpDef, cpointer unfoundType_LPDCB_lpDCB);
    [DllImport("kernel32", EntryPoint="BuildCommDCBW", SetLastError=true, ExactSpelling=true)] public static extern
        int BuildCommDCB([MarshalAs(UnmanagedType.LPWStr)] string lpDef, cpointer unfoundType_LPDCB_lpDCB);
    [DllImport("kernel32", EntryPoint="BuildCommDCBW", SetLastError=true, ExactSpelling=true)] public static extern
        int BuildCommDCB(char* lpDef, cpointer unfoundType_LPDCB_lpDCB);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int BuildCommDCBW([MarshalAs(UnmanagedType.LPWStr)] string lpDef, cpointer unfoundType_LPDCB_lpDCB);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int BuildCommDCBW(char* lpDef, cpointer unfoundType_LPDCB_lpDCB);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int BuildCommDCBAndTimeoutsA(cpointer unfoundType_LPCSTR_lpDef, cpointer unfoundType_LPDCB_lpDCB, cpointer unfoundType_LPCOMMTIMEOUTS_lpCommTimeouts);
    [DllImport("kernel32", EntryPoint="BuildCommDCBAndTimeoutsW", SetLastError=true, ExactSpelling=true)] public static extern
        int BuildCommDCBAndTimeouts([MarshalAs(UnmanagedType.LPWStr)] string lpDef, cpointer unfoundType_LPDCB_lpDCB, cpointer unfoundType_LPCOMMTIMEOUTS_lpCommTimeouts);
    [DllImport("kernel32", EntryPoint="BuildCommDCBAndTimeoutsW", SetLastError=true, ExactSpelling=true)] public static extern
        int BuildCommDCBAndTimeouts(char* lpDef, cpointer unfoundType_LPDCB_lpDCB, cpointer unfoundType_LPCOMMTIMEOUTS_lpCommTimeouts);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int BuildCommDCBAndTimeoutsW([MarshalAs(UnmanagedType.LPWStr)] string lpDef, cpointer unfoundType_LPDCB_lpDCB, cpointer unfoundType_LPCOMMTIMEOUTS_lpCommTimeouts);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int BuildCommDCBAndTimeoutsW(char* lpDef, cpointer unfoundType_LPDCB_lpDCB, cpointer unfoundType_LPCOMMTIMEOUTS_lpCommTimeouts);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CommConfigDialogA(cpointer unfoundType_LPCSTR_lpszName, cpointer hWnd, cpointer unfoundType_LPCOMMCONFIG_lpCC);
    [DllImport("kernel32", EntryPoint="CommConfigDialogW", SetLastError=true, ExactSpelling=true)] public static extern
        int CommConfigDialog([MarshalAs(UnmanagedType.LPWStr)] string lpszName, cpointer hWnd, cpointer unfoundType_LPCOMMCONFIG_lpCC);
    [DllImport("kernel32", EntryPoint="CommConfigDialogW", SetLastError=true, ExactSpelling=true)] public static extern
        int CommConfigDialog(char* lpszName, cpointer hWnd, cpointer unfoundType_LPCOMMCONFIG_lpCC);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CommConfigDialogW([MarshalAs(UnmanagedType.LPWStr)] string lpszName, cpointer hWnd, cpointer unfoundType_LPCOMMCONFIG_lpCC);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CommConfigDialogW(char* lpszName, cpointer hWnd, cpointer unfoundType_LPCOMMCONFIG_lpCC);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDefaultCommConfigA(cpointer unfoundType_LPCSTR_lpszName, cpointer unfoundType_LPCOMMCONFIG_lpCC, cpointer unfoundType_LPDWORD_lpdwSize);
    [DllImport("kernel32", EntryPoint="GetDefaultCommConfigW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDefaultCommConfig([MarshalAs(UnmanagedType.LPWStr)] string lpszName, cpointer unfoundType_LPCOMMCONFIG_lpCC, cpointer unfoundType_LPDWORD_lpdwSize);
    [DllImport("kernel32", EntryPoint="GetDefaultCommConfigW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDefaultCommConfig(char* lpszName, cpointer unfoundType_LPCOMMCONFIG_lpCC, cpointer unfoundType_LPDWORD_lpdwSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDefaultCommConfigW([MarshalAs(UnmanagedType.LPWStr)] string lpszName, cpointer unfoundType_LPCOMMCONFIG_lpCC, cpointer unfoundType_LPDWORD_lpdwSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDefaultCommConfigW(char* lpszName, cpointer unfoundType_LPCOMMCONFIG_lpCC, cpointer unfoundType_LPDWORD_lpdwSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetDefaultCommConfigA(cpointer unfoundType_LPCSTR_lpszName, cpointer unfoundType_LPCOMMCONFIG_lpCC, int dwSize);
    [DllImport("kernel32", EntryPoint="SetDefaultCommConfigW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetDefaultCommConfig([MarshalAs(UnmanagedType.LPWStr)] string lpszName, cpointer unfoundType_LPCOMMCONFIG_lpCC, int dwSize);
    [DllImport("kernel32", EntryPoint="SetDefaultCommConfigW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetDefaultCommConfig(char* lpszName, cpointer unfoundType_LPCOMMCONFIG_lpCC, int dwSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetDefaultCommConfigW([MarshalAs(UnmanagedType.LPWStr)] string lpszName, cpointer unfoundType_LPCOMMCONFIG_lpCC, int dwSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetDefaultCommConfigW(char* lpszName, cpointer unfoundType_LPCOMMCONFIG_lpCC, int dwSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetComputerNameA([MarshalAs(UnmanagedType.LPStr)] string lpBuffer, cpointer unfoundType_LPDWORD_nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetComputerNameA(ReadOnlySpan<byte> lpBuffer, cpointer unfoundType_LPDWORD_nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetComputerNameA(byte* lpBuffer, cpointer unfoundType_LPDWORD_nSize);
    [DllImport("kernel32", EntryPoint="GetComputerNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetComputerName(string lpBuffer, cpointer unfoundType_LPDWORD_nSize);
    [DllImport("kernel32", EntryPoint="GetComputerNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetComputerName(char* lpBuffer, cpointer unfoundType_LPDWORD_nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetComputerNameW(string lpBuffer, cpointer unfoundType_LPDWORD_nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetComputerNameW(char* lpBuffer, cpointer unfoundType_LPDWORD_nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DnsHostnameToComputerNameA(cpointer unfoundType_LPCSTR_Hostname, [MarshalAs(UnmanagedType.LPStr)] string ComputerName, cpointer unfoundType_LPDWORD_nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DnsHostnameToComputerNameA(cpointer unfoundType_LPCSTR_Hostname, ReadOnlySpan<byte> ComputerName, cpointer unfoundType_LPDWORD_nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DnsHostnameToComputerNameA(cpointer unfoundType_LPCSTR_Hostname, byte* ComputerName, cpointer unfoundType_LPDWORD_nSize);
    [DllImport("kernel32", EntryPoint="DnsHostnameToComputerNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int DnsHostnameToComputerName([MarshalAs(UnmanagedType.LPWStr)] string Hostname, string ComputerName, cpointer unfoundType_LPDWORD_nSize);
    [DllImport("kernel32", EntryPoint="DnsHostnameToComputerNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int DnsHostnameToComputerName([MarshalAs(UnmanagedType.LPWStr)] string Hostname, char* ComputerName, cpointer unfoundType_LPDWORD_nSize);
    [DllImport("kernel32", EntryPoint="DnsHostnameToComputerNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int DnsHostnameToComputerName(char* Hostname, string ComputerName, cpointer unfoundType_LPDWORD_nSize);
    [DllImport("kernel32", EntryPoint="DnsHostnameToComputerNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int DnsHostnameToComputerName(char* Hostname, char* ComputerName, cpointer unfoundType_LPDWORD_nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DnsHostnameToComputerNameW([MarshalAs(UnmanagedType.LPWStr)] string Hostname, string ComputerName, cpointer unfoundType_LPDWORD_nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DnsHostnameToComputerNameW([MarshalAs(UnmanagedType.LPWStr)] string Hostname, char* ComputerName, cpointer unfoundType_LPDWORD_nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DnsHostnameToComputerNameW(char* Hostname, string ComputerName, cpointer unfoundType_LPDWORD_nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DnsHostnameToComputerNameW(char* Hostname, char* ComputerName, cpointer unfoundType_LPDWORD_nSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int RegisterWaitForSingleObject(cpointer unfoundType_PHANDLE_phNewWaitObject, cpointer hObject, cpointer unfoundType_WAITORTIMERCALLBACK_Callback, cpointer Context, uint dwMilliseconds, uint dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int UnregisterWait(cpointer WaitHandle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int BindIoCompletionCallback(cpointer FileHandle, cpointer unfoundType_LPOVERLAPPED_COMPLETION_ROUTINE_Function, uint Flags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer SetTimerQueueTimer(cpointer TimerQueue, cpointer unfoundType_WAITORTIMERCALLBACK_Callback, cpointer Parameter, int DueTime, int Period, int PreferIo);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CancelTimerQueueTimer(cpointer TimerQueue, cpointer Timer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreatePrivateNamespaceA(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpPrivateNamespaceAttributes, cpointer lpBoundaryDescriptor, cpointer unfoundType_LPCSTR_lpAliasPrefix);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenPrivateNamespaceA(cpointer lpBoundaryDescriptor, cpointer unfoundType_LPCSTR_lpAliasPrefix);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateBoundaryDescriptorA(cpointer unfoundType_LPCSTR_Name, uint Flags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AddIntegrityLabelToBoundaryDescriptor(cpointer BoundaryDescriptor, cpointer unfoundType_PSID_IntegrityLabel);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int VerifyVersionInfoA(cpointer unfoundType_LPOSVERSIONINFOEXA_lpVersionInformation, int dwTypeMask, cpointer unfoundType_DWORDLONG_dwlConditionMask);
    [DllImport("kernel32", EntryPoint="VerifyVersionInfoW", SetLastError=true, ExactSpelling=true)] public static extern
        int VerifyVersionInfo(cpointer unfoundType_LPOSVERSIONINFOEXW_lpVersionInformation, int dwTypeMask, cpointer unfoundType_DWORDLONG_dwlConditionMask);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int VerifyVersionInfoW(cpointer unfoundType_LPOSVERSIONINFOEXW_lpVersionInformation, int dwTypeMask, cpointer unfoundType_DWORDLONG_dwlConditionMask);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetSystemPowerState(int fSuspend, int fForce);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetSystemPowerStatus(cpointer unfoundType_LPSYSTEM_POWER_STATUS_lpSystemPowerStatus);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int MapUserPhysicalPagesScatter(cpointer unfoundType_PVOIDVirtualAddressesVirtualAddresses_unnamed_0, cpointer unfoundType_ULONG_PTR_NumberOfPages, cpointer PageArray);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateJobObjectA(cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpJobAttributes, cpointer unfoundType_LPCSTR_lpName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenJobObjectA(int dwDesiredAccess, int bInheritHandle, cpointer unfoundType_LPCSTR_lpName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateJobSet(uint NumJob, cpointer unfoundType_PJOB_SET_ARRAY_UserJobSet, uint Flags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstVolumeA([MarshalAs(UnmanagedType.LPStr)] string lpszVolumeName, int cchBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstVolumeA(ReadOnlySpan<byte> lpszVolumeName, int cchBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstVolumeA(byte* lpszVolumeName, int cchBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindNextVolumeA(cpointer hFindVolume, [MarshalAs(UnmanagedType.LPStr)] string lpszVolumeName, int cchBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindNextVolumeA(cpointer hFindVolume, ReadOnlySpan<byte> lpszVolumeName, int cchBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindNextVolumeA(cpointer hFindVolume, byte* lpszVolumeName, int cchBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstVolumeMountPointA(cpointer unfoundType_LPCSTR_lpszRootPathName, [MarshalAs(UnmanagedType.LPStr)] string lpszVolumeMountPoint, int cchBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstVolumeMountPointA(cpointer unfoundType_LPCSTR_lpszRootPathName, ReadOnlySpan<byte> lpszVolumeMountPoint, int cchBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstVolumeMountPointA(cpointer unfoundType_LPCSTR_lpszRootPathName, byte* lpszVolumeMountPoint, int cchBufferLength);
    [DllImport("kernel32", EntryPoint="FindFirstVolumeMountPointW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstVolumeMountPoint([MarshalAs(UnmanagedType.LPWStr)] string lpszRootPathName, string lpszVolumeMountPoint, int cchBufferLength);
    [DllImport("kernel32", EntryPoint="FindFirstVolumeMountPointW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstVolumeMountPoint([MarshalAs(UnmanagedType.LPWStr)] string lpszRootPathName, char* lpszVolumeMountPoint, int cchBufferLength);
    [DllImport("kernel32", EntryPoint="FindFirstVolumeMountPointW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstVolumeMountPoint(char* lpszRootPathName, string lpszVolumeMountPoint, int cchBufferLength);
    [DllImport("kernel32", EntryPoint="FindFirstVolumeMountPointW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstVolumeMountPoint(char* lpszRootPathName, char* lpszVolumeMountPoint, int cchBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstVolumeMountPointW([MarshalAs(UnmanagedType.LPWStr)] string lpszRootPathName, string lpszVolumeMountPoint, int cchBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstVolumeMountPointW([MarshalAs(UnmanagedType.LPWStr)] string lpszRootPathName, char* lpszVolumeMountPoint, int cchBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstVolumeMountPointW(char* lpszRootPathName, string lpszVolumeMountPoint, int cchBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindFirstVolumeMountPointW(char* lpszRootPathName, char* lpszVolumeMountPoint, int cchBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindNextVolumeMountPointA(cpointer hFindVolumeMountPoint, [MarshalAs(UnmanagedType.LPStr)] string lpszVolumeMountPoint, int cchBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindNextVolumeMountPointA(cpointer hFindVolumeMountPoint, ReadOnlySpan<byte> lpszVolumeMountPoint, int cchBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindNextVolumeMountPointA(cpointer hFindVolumeMountPoint, byte* lpszVolumeMountPoint, int cchBufferLength);
    [DllImport("kernel32", EntryPoint="FindNextVolumeMountPointW", SetLastError=true, ExactSpelling=true)] public static extern
        int FindNextVolumeMountPoint(cpointer hFindVolumeMountPoint, string lpszVolumeMountPoint, int cchBufferLength);
    [DllImport("kernel32", EntryPoint="FindNextVolumeMountPointW", SetLastError=true, ExactSpelling=true)] public static extern
        int FindNextVolumeMountPoint(cpointer hFindVolumeMountPoint, char* lpszVolumeMountPoint, int cchBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindNextVolumeMountPointW(cpointer hFindVolumeMountPoint, string lpszVolumeMountPoint, int cchBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindNextVolumeMountPointW(cpointer hFindVolumeMountPoint, char* lpszVolumeMountPoint, int cchBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindVolumeMountPointClose(cpointer hFindVolumeMountPoint);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetVolumeMountPointA(cpointer unfoundType_LPCSTR_lpszVolumeMountPoint, cpointer unfoundType_LPCSTR_lpszVolumeName);
    [DllImport("kernel32", EntryPoint="SetVolumeMountPointW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetVolumeMountPoint([MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeMountPoint, [MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeName);
    [DllImport("kernel32", EntryPoint="SetVolumeMountPointW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetVolumeMountPoint([MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeMountPoint, char* lpszVolumeName);
    [DllImport("kernel32", EntryPoint="SetVolumeMountPointW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetVolumeMountPoint(char* lpszVolumeMountPoint, [MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeName);
    [DllImport("kernel32", EntryPoint="SetVolumeMountPointW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetVolumeMountPoint(char* lpszVolumeMountPoint, char* lpszVolumeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetVolumeMountPointW([MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeMountPoint, [MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetVolumeMountPointW([MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeMountPoint, char* lpszVolumeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetVolumeMountPointW(char* lpszVolumeMountPoint, [MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetVolumeMountPointW(char* lpszVolumeMountPoint, char* lpszVolumeName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DeleteVolumeMountPointA(cpointer unfoundType_LPCSTR_lpszVolumeMountPoint);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeNameForVolumeMountPointA(cpointer unfoundType_LPCSTR_lpszVolumeMountPoint, [MarshalAs(UnmanagedType.LPStr)] string lpszVolumeName, int cchBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeNameForVolumeMountPointA(cpointer unfoundType_LPCSTR_lpszVolumeMountPoint, ReadOnlySpan<byte> lpszVolumeName, int cchBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumeNameForVolumeMountPointA(cpointer unfoundType_LPCSTR_lpszVolumeMountPoint, byte* lpszVolumeName, int cchBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumePathNameA(cpointer unfoundType_LPCSTR_lpszFileName, [MarshalAs(UnmanagedType.LPStr)] string lpszVolumePathName, int cchBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumePathNameA(cpointer unfoundType_LPCSTR_lpszFileName, ReadOnlySpan<byte> lpszVolumePathName, int cchBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumePathNameA(cpointer unfoundType_LPCSTR_lpszFileName, byte* lpszVolumePathName, int cchBufferLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetVolumePathNamesForVolumeNameA(cpointer unfoundType_LPCSTR_lpszVolumeName, cpointer unfoundType_LPCH_lpszVolumePathNames, int cchBufferLength, cpointer unfoundType_PDWORD_lpcchReturnLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateActCtxA(cpointer unfoundType_PCACTCTXA_pActCtx);
    [DllImport("kernel32", EntryPoint="CreateActCtxW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateActCtx(cpointer unfoundType_PCACTCTXW_pActCtx);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateActCtxW(cpointer unfoundType_PCACTCTXW_pActCtx);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void AddRefActCtx(cpointer hActCtx);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void ReleaseActCtx(cpointer hActCtx);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ZombifyActCtx(cpointer hActCtx);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ActivateActCtx(cpointer hActCtx, cpointer unfoundType_ULONG_PTRlpCookielpCookie_unnamed_1);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DeactivateActCtx(int dwFlags, cpointer unfoundType_ULONG_PTR_ulCookie);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrentActCtx(cpointer unfoundType_HANDLElphActCtxlphActCtx_unnamed_0);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindActCtxSectionStringA(int dwFlags, cpointer unfoundType_GUIDlpExtensionGuidlpExtensionGuid_unnamed_1, uint ulSectionId, cpointer unfoundType_LPCSTR_lpStringToFind, cpointer unfoundType_PACTCTX_SECTION_KEYED_DATA_ReturnedData);
    [DllImport("kernel32", EntryPoint="FindActCtxSectionStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int FindActCtxSectionString(int dwFlags, cpointer unfoundType_GUIDlpExtensionGuidlpExtensionGuid_unnamed_1, uint ulSectionId, [MarshalAs(UnmanagedType.LPWStr)] string lpStringToFind, cpointer unfoundType_PACTCTX_SECTION_KEYED_DATA_ReturnedData);
    [DllImport("kernel32", EntryPoint="FindActCtxSectionStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int FindActCtxSectionString(int dwFlags, cpointer unfoundType_GUIDlpExtensionGuidlpExtensionGuid_unnamed_1, uint ulSectionId, char* lpStringToFind, cpointer unfoundType_PACTCTX_SECTION_KEYED_DATA_ReturnedData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindActCtxSectionStringW(int dwFlags, cpointer unfoundType_GUIDlpExtensionGuidlpExtensionGuid_unnamed_1, uint ulSectionId, [MarshalAs(UnmanagedType.LPWStr)] string lpStringToFind, cpointer unfoundType_PACTCTX_SECTION_KEYED_DATA_ReturnedData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindActCtxSectionStringW(int dwFlags, cpointer unfoundType_GUIDlpExtensionGuidlpExtensionGuid_unnamed_1, uint ulSectionId, char* lpStringToFind, cpointer unfoundType_PACTCTX_SECTION_KEYED_DATA_ReturnedData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindActCtxSectionGuid(int dwFlags, cpointer unfoundType_GUIDlpExtensionGuidlpExtensionGuid_unnamed_1, uint ulSectionId, cpointer unfoundType_GUIDlpGuidToFindlpGuidToFind_unnamed_3, cpointer unfoundType_PACTCTX_SECTION_KEYED_DATA_ReturnedData);
    [DllImport("kernel32", EntryPoint="QueryActCtxW", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryActCtx(int dwFlags, cpointer hActCtx, cpointer pvSubInstance, uint ulInfoClass, cpointer pvBuffer, cpointer cbBuffer, cpointer unfoundType_SIZE_TpcbWrittenOrRequiredpcbWrittenOrRequired_unnamed_6);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryActCtxW(int dwFlags, cpointer hActCtx, cpointer pvSubInstance, uint ulInfoClass, cpointer pvBuffer, cpointer cbBuffer, cpointer unfoundType_SIZE_TpcbWrittenOrRequiredpcbWrittenOrRequired_unnamed_6);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int WTSGetActiveConsoleSessionId();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        short GetActiveProcessorGroupCount();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        short GetMaximumProcessorGroupCount();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetActiveProcessorCount(short GroupNumber);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetMaximumProcessorCount(short GroupNumber);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNumaProcessorNode(byte Processor, cpointer unfoundType_PUCHAR_NodeNumber);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNumaNodeNumberFromHandle(cpointer hFile, cpointer unfoundType_PUSHORT_NodeNumber);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNumaProcessorNodeEx(cpointer unfoundType_PPROCESSOR_NUMBER_Processor, cpointer unfoundType_PUSHORT_NodeNumber);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNumaNodeProcessorMask(byte Node, cpointer unfoundType_PULONGLONG_ProcessorMask);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNumaAvailableMemoryNode(byte Node, cpointer unfoundType_PULONGLONG_AvailableBytes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNumaAvailableMemoryNodeEx(ushort Node, cpointer unfoundType_PULONGLONG_AvailableBytes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNumaProximityNode(uint ProximityId, cpointer unfoundType_PUCHAR_NodeNumber);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegisterApplicationRecoveryCallback(cpointer unfoundType_APPLICATION_RECOVERY_CALLBACK_pRecoveyCallback, cpointer pvParameter, int dwPingInterval, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer UnregisterApplicationRecoveryCallback();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegisterApplicationRestart([MarshalAs(UnmanagedType.LPWStr)] string pwzCommandline, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegisterApplicationRestart(char* pwzCommandline, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer UnregisterApplicationRestart();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetApplicationRecoveryCallback(cpointer hProcess, cpointer unfoundType_APPLICATION_RECOVERY_CALLBACK_pRecoveryCallback, cpointer ppvParameter, cpointer unfoundType_PDWORD_pdwPingInterval, cpointer unfoundType_PDWORD_pdwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetApplicationRestartSettings(cpointer hProcess, [MarshalAs(UnmanagedType.LPWStr)] string pwzCommandline, cpointer unfoundType_PDWORD_pcchSize, cpointer unfoundType_PDWORD_pdwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetApplicationRestartSettings(cpointer hProcess, char* pwzCommandline, cpointer unfoundType_PDWORD_pcchSize, cpointer unfoundType_PDWORD_pdwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer ApplicationRecoveryInProgress(cpointer pbCancelled);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        void ApplicationRecoveryFinished(int bSuccess);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFileInformationByHandleEx(cpointer hFile, cpointer unfoundType_FILE_INFO_BY_HANDLE_CLASS_FileInformationClass, cpointer lpFileInformation, int dwBufferSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenFileById(cpointer hVolumeHint, cpointer unfoundType_LPFILE_ID_DESCRIPTOR_lpFileId, int dwDesiredAccess, int dwShareMode, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int dwFlagsAndAttributes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateSymbolicLinkA(cpointer unfoundType_LPCSTR_lpSymlinkFileName, cpointer unfoundType_LPCSTR_lpTargetFileName, int dwFlags);
    [DllImport("kernel32", EntryPoint="CreateSymbolicLinkW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateSymbolicLink([MarshalAs(UnmanagedType.LPWStr)] string lpSymlinkFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpTargetFileName, int dwFlags);
    [DllImport("kernel32", EntryPoint="CreateSymbolicLinkW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateSymbolicLink([MarshalAs(UnmanagedType.LPWStr)] string lpSymlinkFileName, char* lpTargetFileName, int dwFlags);
    [DllImport("kernel32", EntryPoint="CreateSymbolicLinkW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateSymbolicLink(char* lpSymlinkFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpTargetFileName, int dwFlags);
    [DllImport("kernel32", EntryPoint="CreateSymbolicLinkW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateSymbolicLink(char* lpSymlinkFileName, char* lpTargetFileName, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateSymbolicLinkW([MarshalAs(UnmanagedType.LPWStr)] string lpSymlinkFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpTargetFileName, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateSymbolicLinkW([MarshalAs(UnmanagedType.LPWStr)] string lpSymlinkFileName, char* lpTargetFileName, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateSymbolicLinkW(char* lpSymlinkFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpTargetFileName, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateSymbolicLinkW(char* lpSymlinkFileName, char* lpTargetFileName, int dwFlags);
    [DllImport("kernel32", EntryPoint="QueryActCtxSettingsW", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryActCtxSettings(int dwFlags, cpointer hActCtx, [MarshalAs(UnmanagedType.LPWStr)] string settingsNameSpace, [MarshalAs(UnmanagedType.LPWStr)] string settingName, [MarshalAs(UnmanagedType.LPWStr)] string pvBuffer, cpointer dwBuffer, cpointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport("kernel32", EntryPoint="QueryActCtxSettingsW", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryActCtxSettings(int dwFlags, cpointer hActCtx, [MarshalAs(UnmanagedType.LPWStr)] string settingsNameSpace, [MarshalAs(UnmanagedType.LPWStr)] string settingName, char* pvBuffer, cpointer dwBuffer, cpointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport("kernel32", EntryPoint="QueryActCtxSettingsW", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryActCtxSettings(int dwFlags, cpointer hActCtx, [MarshalAs(UnmanagedType.LPWStr)] string settingsNameSpace, char* settingName, [MarshalAs(UnmanagedType.LPWStr)] string pvBuffer, cpointer dwBuffer, cpointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport("kernel32", EntryPoint="QueryActCtxSettingsW", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryActCtxSettings(int dwFlags, cpointer hActCtx, [MarshalAs(UnmanagedType.LPWStr)] string settingsNameSpace, char* settingName, char* pvBuffer, cpointer dwBuffer, cpointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport("kernel32", EntryPoint="QueryActCtxSettingsW", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryActCtxSettings(int dwFlags, cpointer hActCtx, char* settingsNameSpace, [MarshalAs(UnmanagedType.LPWStr)] string settingName, [MarshalAs(UnmanagedType.LPWStr)] string pvBuffer, cpointer dwBuffer, cpointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport("kernel32", EntryPoint="QueryActCtxSettingsW", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryActCtxSettings(int dwFlags, cpointer hActCtx, char* settingsNameSpace, [MarshalAs(UnmanagedType.LPWStr)] string settingName, char* pvBuffer, cpointer dwBuffer, cpointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport("kernel32", EntryPoint="QueryActCtxSettingsW", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryActCtxSettings(int dwFlags, cpointer hActCtx, char* settingsNameSpace, char* settingName, [MarshalAs(UnmanagedType.LPWStr)] string pvBuffer, cpointer dwBuffer, cpointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport("kernel32", EntryPoint="QueryActCtxSettingsW", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryActCtxSettings(int dwFlags, cpointer hActCtx, char* settingsNameSpace, char* settingName, char* pvBuffer, cpointer dwBuffer, cpointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryActCtxSettingsW(int dwFlags, cpointer hActCtx, [MarshalAs(UnmanagedType.LPWStr)] string settingsNameSpace, [MarshalAs(UnmanagedType.LPWStr)] string settingName, [MarshalAs(UnmanagedType.LPWStr)] string pvBuffer, cpointer dwBuffer, cpointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryActCtxSettingsW(int dwFlags, cpointer hActCtx, [MarshalAs(UnmanagedType.LPWStr)] string settingsNameSpace, [MarshalAs(UnmanagedType.LPWStr)] string settingName, char* pvBuffer, cpointer dwBuffer, cpointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryActCtxSettingsW(int dwFlags, cpointer hActCtx, [MarshalAs(UnmanagedType.LPWStr)] string settingsNameSpace, char* settingName, [MarshalAs(UnmanagedType.LPWStr)] string pvBuffer, cpointer dwBuffer, cpointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryActCtxSettingsW(int dwFlags, cpointer hActCtx, [MarshalAs(UnmanagedType.LPWStr)] string settingsNameSpace, char* settingName, char* pvBuffer, cpointer dwBuffer, cpointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryActCtxSettingsW(int dwFlags, cpointer hActCtx, char* settingsNameSpace, [MarshalAs(UnmanagedType.LPWStr)] string settingName, [MarshalAs(UnmanagedType.LPWStr)] string pvBuffer, cpointer dwBuffer, cpointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryActCtxSettingsW(int dwFlags, cpointer hActCtx, char* settingsNameSpace, [MarshalAs(UnmanagedType.LPWStr)] string settingName, char* pvBuffer, cpointer dwBuffer, cpointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryActCtxSettingsW(int dwFlags, cpointer hActCtx, char* settingsNameSpace, char* settingName, [MarshalAs(UnmanagedType.LPWStr)] string pvBuffer, cpointer dwBuffer, cpointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryActCtxSettingsW(int dwFlags, cpointer hActCtx, char* settingsNameSpace, char* settingName, char* pvBuffer, cpointer dwBuffer, cpointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateSymbolicLinkTransactedA(cpointer unfoundType_LPCSTR_lpSymlinkFileName, cpointer unfoundType_LPCSTR_lpTargetFileName, int dwFlags, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="CreateSymbolicLinkTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateSymbolicLinkTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpSymlinkFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpTargetFileName, int dwFlags, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="CreateSymbolicLinkTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateSymbolicLinkTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpSymlinkFileName, char* lpTargetFileName, int dwFlags, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="CreateSymbolicLinkTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateSymbolicLinkTransacted(char* lpSymlinkFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpTargetFileName, int dwFlags, cpointer hTransaction);
    [DllImport("kernel32", EntryPoint="CreateSymbolicLinkTransactedW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateSymbolicLinkTransacted(char* lpSymlinkFileName, char* lpTargetFileName, int dwFlags, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateSymbolicLinkTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpSymlinkFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpTargetFileName, int dwFlags, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateSymbolicLinkTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpSymlinkFileName, char* lpTargetFileName, int dwFlags, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateSymbolicLinkTransactedW(char* lpSymlinkFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpTargetFileName, int dwFlags, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateSymbolicLinkTransactedW(char* lpSymlinkFileName, char* lpTargetFileName, int dwFlags, cpointer hTransaction);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ReplacePartitionUnit([MarshalAs(UnmanagedType.LPWStr)] string TargetPartition, [MarshalAs(UnmanagedType.LPWStr)] string SparePartition, uint Flags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ReplacePartitionUnit([MarshalAs(UnmanagedType.LPWStr)] string TargetPartition, char* SparePartition, uint Flags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ReplacePartitionUnit(char* TargetPartition, [MarshalAs(UnmanagedType.LPWStr)] string SparePartition, uint Flags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ReplacePartitionUnit(char* TargetPartition, char* SparePartition, uint Flags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int AddSecureMemoryCacheCallback(cpointer unfoundType_PSECURE_MEMORY_CACHE_CALLBACK_pfnCallBack);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int RemoveSecureMemoryCacheCallback(cpointer unfoundType_PSECURE_MEMORY_CACHE_CALLBACK_pfnCallBack);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CopyContext(cpointer unfoundType_PCONTEXT_Destination, int ContextFlags, cpointer unfoundType_PCONTEXT_Source);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int InitializeContext(cpointer Buffer, int ContextFlags, cpointer unfoundType_PCONTEXT_Context, cpointer unfoundType_PDWORD_ContextLength);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int InitializeContext2(cpointer Buffer, int ContextFlags, cpointer unfoundType_PCONTEXT_Context, cpointer unfoundType_PDWORD_ContextLength, cpointer unfoundType_ULONG64_XStateCompactionMask);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetEnabledXStateFeatures();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetXStateFeaturesMask(cpointer unfoundType_PCONTEXT_Context, cpointer unfoundType_PDWORD64_FeatureMask);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LocateXStateFeature(cpointer unfoundType_PCONTEXT_Context, int FeatureId, cpointer unfoundType_PDWORD_Length);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetXStateFeaturesMask(cpointer unfoundType_PCONTEXT_Context, cpointer unfoundType_DWORD64_FeatureMask);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetThreadEnabledXStateFeatures();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnableProcessOptionalXStateFeatures(cpointer unfoundType_DWORD64_Features);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnableThreadProfiling(cpointer ThreadHandle, int Flags, cpointer unfoundType_DWORD64_HardwareCounters, cpointer unfoundType_HANDLEPerformanceDataHandlePerformanceDataHandle_unnamed_3);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int DisableThreadProfiling(cpointer PerformanceDataHandle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryThreadProfiling(cpointer ThreadHandle, cpointer unfoundType_PBOOLEAN_Enabled);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ReadThreadProfilingData(cpointer PerformanceDataHandle, int Flags, cpointer unfoundType_PPERFORMANCE_DATA_PerformanceData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer WerRegisterFile([MarshalAs(UnmanagedType.LPWStr)] string pwzFile, cpointer unfoundType_WER_REGISTER_FILE_TYPE_regFileType, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer WerRegisterFile(char* pwzFile, cpointer unfoundType_WER_REGISTER_FILE_TYPE_regFileType, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer WerUnregisterFile([MarshalAs(UnmanagedType.LPWStr)] string pwzFilePath);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer WerUnregisterFile(char* pwzFilePath);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer WerRegisterMemoryBlock(cpointer pvAddress, int dwSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer WerUnregisterMemoryBlock(cpointer pvAddress);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer WerRegisterExcludedMemoryBlock(cpointer address, int size);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer WerUnregisterExcludedMemoryBlock(cpointer address);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer WerRegisterCustomMetadata([MarshalAs(UnmanagedType.LPWStr)] string key, [MarshalAs(UnmanagedType.LPWStr)] string value);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer WerRegisterCustomMetadata([MarshalAs(UnmanagedType.LPWStr)] string key, char* value);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer WerRegisterCustomMetadata(char* key, [MarshalAs(UnmanagedType.LPWStr)] string value);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer WerRegisterCustomMetadata(char* key, char* value);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer WerUnregisterCustomMetadata([MarshalAs(UnmanagedType.LPWStr)] string key);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer WerUnregisterCustomMetadata(char* key);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer WerRegisterAdditionalProcess(int processId, int captureExtraInfoForThreadId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer WerUnregisterAdditionalProcess(int processId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer WerRegisterAppLocalDump([MarshalAs(UnmanagedType.LPWStr)] string localAppDataRelativePath);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer WerRegisterAppLocalDump(char* localAppDataRelativePath);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer WerUnregisterAppLocalDump();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer WerSetFlags(int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer WerGetFlags(cpointer hProcess, cpointer unfoundType_PDWORD_pdwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer WerRegisterRuntimeExceptionModule([MarshalAs(UnmanagedType.LPWStr)] string pwszOutOfProcessCallbackDll, cpointer pContext);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer WerRegisterRuntimeExceptionModule(char* pwszOutOfProcessCallbackDll, cpointer pContext);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer WerUnregisterRuntimeExceptionModule([MarshalAs(UnmanagedType.LPWStr)] string pwszOutOfProcessCallbackDll, cpointer pContext);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer WerUnregisterRuntimeExceptionModule(char* pwszOutOfProcessCallbackDll, cpointer pContext);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer Wow64EnableWow64FsRedirection(cpointer unfoundType_BOOLEAN_Wow64FsEnableRedirection);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int Wow64DisableWow64FsRedirection(cpointer OldValue);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int Wow64RevertWow64FsRedirection(cpointer OlValue);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsWow64Process(cpointer hProcess, cpointer Wow64Process);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetSystemWow64DirectoryA([MarshalAs(UnmanagedType.LPStr)] string lpBuffer, uint uSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetSystemWow64DirectoryA(ReadOnlySpan<byte> lpBuffer, uint uSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetSystemWow64DirectoryA(byte* lpBuffer, uint uSize);
    [DllImport("kernel32", EntryPoint="GetSystemWow64DirectoryW", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetSystemWow64Directory(string lpBuffer, uint uSize);
    [DllImport("kernel32", EntryPoint="GetSystemWow64DirectoryW", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetSystemWow64Directory(char* lpBuffer, uint uSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetSystemWow64DirectoryW(string lpBuffer, uint uSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetSystemWow64DirectoryW(char* lpBuffer, uint uSize);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsWow64Process2(cpointer hProcess, cpointer pProcessMachine, cpointer pNativeMachine);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer IsWow64GuestMachineSupported(ushort WowGuestMachine, cpointer MachineIsSupported);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int Wow64GetThreadContext(cpointer hThread, cpointer unfoundType_PWOW64_CONTEXT_lpContext);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int Wow64SetThreadContext(cpointer hThread, cpointer unfoundType_WOW64_CONTEXT_lpContext);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int Wow64SuspendThread(cpointer hThread);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int VerLanguageNameA(int wLang, [MarshalAs(UnmanagedType.LPStr)] string szLang, int cchLang);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int VerLanguageNameA(int wLang, ReadOnlySpan<byte> szLang, int cchLang);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int VerLanguageNameA(int wLang, byte* szLang, int cchLang);
    [DllImport("kernel32", EntryPoint="VerLanguageNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int VerLanguageName(int wLang, string szLang, int cchLang);
    [DllImport("kernel32", EntryPoint="VerLanguageNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int VerLanguageName(int wLang, char* szLang, int cchLang);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int VerLanguageNameW(int wLang, string szLang, int cchLang);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int VerLanguageNameW(int wLang, char* szLang, int cchLang);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsValidCodePage(uint CodePage);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetACP();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetOEMCP();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCPInfo(uint CodePage, cpointer unfoundType_LPCPINFO_lpCPInfo);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCPInfoExA(uint CodePage, int dwFlags, cpointer unfoundType_LPCPINFOEXA_lpCPInfoEx);
    [DllImport("kernel32", EntryPoint="GetCPInfoExW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCPInfoEx(uint CodePage, int dwFlags, cpointer unfoundType_LPCPINFOEXW_lpCPInfoEx);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCPInfoExW(uint CodePage, int dwFlags, cpointer unfoundType_LPCPINFOEXW_lpCPInfoEx);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int CompareStringA(cpointer unfoundType_LCID_Locale, int dwCmpFlags, cpointer unfoundType_PCNZCH_lpString1, int cchCount1, cpointer unfoundType_PCNZCH_lpString2, int cchCount2);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindNLSString(cpointer unfoundType_LCID_Locale, int dwFindNLSStringFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpStringSource, int cchSource, [MarshalAs(UnmanagedType.LPWStr)] string lpStringValue, int cchValue, cpointer unfoundType_LPINT_pcchFound);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindNLSString(cpointer unfoundType_LCID_Locale, int dwFindNLSStringFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpStringSource, int cchSource, char* lpStringValue, int cchValue, cpointer unfoundType_LPINT_pcchFound);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindNLSString(cpointer unfoundType_LCID_Locale, int dwFindNLSStringFlags, char* lpStringSource, int cchSource, [MarshalAs(UnmanagedType.LPWStr)] string lpStringValue, int cchValue, cpointer unfoundType_LPINT_pcchFound);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindNLSString(cpointer unfoundType_LCID_Locale, int dwFindNLSStringFlags, char* lpStringSource, int cchSource, char* lpStringValue, int cchValue, cpointer unfoundType_LPINT_pcchFound);
    [DllImport("kernel32", EntryPoint="LCMapStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int LCMapString(cpointer unfoundType_LCID_Locale, int dwMapFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, string lpDestStr, int cchDest);
    [DllImport("kernel32", EntryPoint="LCMapStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int LCMapString(cpointer unfoundType_LCID_Locale, int dwMapFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, char* lpDestStr, int cchDest);
    [DllImport("kernel32", EntryPoint="LCMapStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int LCMapString(cpointer unfoundType_LCID_Locale, int dwMapFlags, char* lpSrcStr, int cchSrc, string lpDestStr, int cchDest);
    [DllImport("kernel32", EntryPoint="LCMapStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int LCMapString(cpointer unfoundType_LCID_Locale, int dwMapFlags, char* lpSrcStr, int cchSrc, char* lpDestStr, int cchDest);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int LCMapStringW(cpointer unfoundType_LCID_Locale, int dwMapFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, string lpDestStr, int cchDest);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int LCMapStringW(cpointer unfoundType_LCID_Locale, int dwMapFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, char* lpDestStr, int cchDest);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int LCMapStringW(cpointer unfoundType_LCID_Locale, int dwMapFlags, char* lpSrcStr, int cchSrc, string lpDestStr, int cchDest);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int LCMapStringW(cpointer unfoundType_LCID_Locale, int dwMapFlags, char* lpSrcStr, int cchSrc, char* lpDestStr, int cchDest);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int LCMapStringA(cpointer unfoundType_LCID_Locale, int dwMapFlags, cpointer unfoundType_LPCSTR_lpSrcStr, int cchSrc, [MarshalAs(UnmanagedType.LPStr)] string lpDestStr, int cchDest);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int LCMapStringA(cpointer unfoundType_LCID_Locale, int dwMapFlags, cpointer unfoundType_LPCSTR_lpSrcStr, int cchSrc, ReadOnlySpan<byte> lpDestStr, int cchDest);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int LCMapStringA(cpointer unfoundType_LCID_Locale, int dwMapFlags, cpointer unfoundType_LPCSTR_lpSrcStr, int cchSrc, byte* lpDestStr, int cchDest);
    [DllImport("kernel32", EntryPoint="GetLocaleInfoW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLocaleInfo(cpointer unfoundType_LCID_Locale, cpointer unfoundType_LCTYPE_LCType, string lpLCData, int cchData);
    [DllImport("kernel32", EntryPoint="GetLocaleInfoW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLocaleInfo(cpointer unfoundType_LCID_Locale, cpointer unfoundType_LCTYPE_LCType, char* lpLCData, int cchData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLocaleInfoW(cpointer unfoundType_LCID_Locale, cpointer unfoundType_LCTYPE_LCType, string lpLCData, int cchData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLocaleInfoW(cpointer unfoundType_LCID_Locale, cpointer unfoundType_LCTYPE_LCType, char* lpLCData, int cchData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLocaleInfoA(cpointer unfoundType_LCID_Locale, cpointer unfoundType_LCTYPE_LCType, [MarshalAs(UnmanagedType.LPStr)] string lpLCData, int cchData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLocaleInfoA(cpointer unfoundType_LCID_Locale, cpointer unfoundType_LCTYPE_LCType, ReadOnlySpan<byte> lpLCData, int cchData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLocaleInfoA(cpointer unfoundType_LCID_Locale, cpointer unfoundType_LCTYPE_LCType, byte* lpLCData, int cchData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetLocaleInfoA(cpointer unfoundType_LCID_Locale, cpointer unfoundType_LCTYPE_LCType, cpointer unfoundType_LPCSTR_lpLCData);
    [DllImport("kernel32", EntryPoint="SetLocaleInfoW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetLocaleInfo(cpointer unfoundType_LCID_Locale, cpointer unfoundType_LCTYPE_LCType, [MarshalAs(UnmanagedType.LPWStr)] string lpLCData);
    [DllImport("kernel32", EntryPoint="SetLocaleInfoW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetLocaleInfo(cpointer unfoundType_LCID_Locale, cpointer unfoundType_LCTYPE_LCType, char* lpLCData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetLocaleInfoW(cpointer unfoundType_LCID_Locale, cpointer unfoundType_LCTYPE_LCType, [MarshalAs(UnmanagedType.LPWStr)] string lpLCData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetLocaleInfoW(cpointer unfoundType_LCID_Locale, cpointer unfoundType_LCTYPE_LCType, char* lpLCData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCalendarInfoA(cpointer unfoundType_LCID_Locale, cpointer unfoundType_CALID_Calendar, cpointer unfoundType_CALTYPE_CalType, [MarshalAs(UnmanagedType.LPStr)] string lpCalData, int cchData, cpointer unfoundType_LPDWORD_lpValue);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCalendarInfoA(cpointer unfoundType_LCID_Locale, cpointer unfoundType_CALID_Calendar, cpointer unfoundType_CALTYPE_CalType, ReadOnlySpan<byte> lpCalData, int cchData, cpointer unfoundType_LPDWORD_lpValue);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCalendarInfoA(cpointer unfoundType_LCID_Locale, cpointer unfoundType_CALID_Calendar, cpointer unfoundType_CALTYPE_CalType, byte* lpCalData, int cchData, cpointer unfoundType_LPDWORD_lpValue);
    [DllImport("kernel32", EntryPoint="GetCalendarInfoW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCalendarInfo(cpointer unfoundType_LCID_Locale, cpointer unfoundType_CALID_Calendar, cpointer unfoundType_CALTYPE_CalType, string lpCalData, int cchData, cpointer unfoundType_LPDWORD_lpValue);
    [DllImport("kernel32", EntryPoint="GetCalendarInfoW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCalendarInfo(cpointer unfoundType_LCID_Locale, cpointer unfoundType_CALID_Calendar, cpointer unfoundType_CALTYPE_CalType, char* lpCalData, int cchData, cpointer unfoundType_LPDWORD_lpValue);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCalendarInfoW(cpointer unfoundType_LCID_Locale, cpointer unfoundType_CALID_Calendar, cpointer unfoundType_CALTYPE_CalType, string lpCalData, int cchData, cpointer unfoundType_LPDWORD_lpValue);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCalendarInfoW(cpointer unfoundType_LCID_Locale, cpointer unfoundType_CALID_Calendar, cpointer unfoundType_CALTYPE_CalType, char* lpCalData, int cchData, cpointer unfoundType_LPDWORD_lpValue);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetCalendarInfoA(cpointer unfoundType_LCID_Locale, cpointer unfoundType_CALID_Calendar, cpointer unfoundType_CALTYPE_CalType, cpointer unfoundType_LPCSTR_lpCalData);
    [DllImport("kernel32", EntryPoint="SetCalendarInfoW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetCalendarInfo(cpointer unfoundType_LCID_Locale, cpointer unfoundType_CALID_Calendar, cpointer unfoundType_CALTYPE_CalType, [MarshalAs(UnmanagedType.LPWStr)] string lpCalData);
    [DllImport("kernel32", EntryPoint="SetCalendarInfoW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetCalendarInfo(cpointer unfoundType_LCID_Locale, cpointer unfoundType_CALID_Calendar, cpointer unfoundType_CALTYPE_CalType, char* lpCalData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetCalendarInfoW(cpointer unfoundType_LCID_Locale, cpointer unfoundType_CALID_Calendar, cpointer unfoundType_CALTYPE_CalType, [MarshalAs(UnmanagedType.LPWStr)] string lpCalData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetCalendarInfoW(cpointer unfoundType_LCID_Locale, cpointer unfoundType_CALID_Calendar, cpointer unfoundType_CALTYPE_CalType, char* lpCalData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsDBCSLeadByte(byte TestChar);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsDBCSLeadByteEx(uint CodePage, byte TestChar);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LocaleNameToLCID([MarshalAs(UnmanagedType.LPWStr)] string lpName, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LocaleNameToLCID(char* lpName, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int LCIDToLocaleName(cpointer unfoundType_LCID_Locale, string lpName, int cchName, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int LCIDToLocaleName(cpointer unfoundType_LCID_Locale, char* lpName, int cchName, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDurationFormat(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIMElpDurationlpDuration_unnamed_2, cpointer unfoundType_ULONGLONG_ullDuration, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, string lpDurationStr, int cchDuration);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDurationFormat(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIMElpDurationlpDuration_unnamed_2, cpointer unfoundType_ULONGLONG_ullDuration, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, char* lpDurationStr, int cchDuration);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDurationFormat(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIMElpDurationlpDuration_unnamed_2, cpointer unfoundType_ULONGLONG_ullDuration, char* lpFormat, string lpDurationStr, int cchDuration);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDurationFormat(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_SYSTEMTIMElpDurationlpDuration_unnamed_2, cpointer unfoundType_ULONGLONG_ullDuration, char* lpFormat, char* lpDurationStr, int cchDuration);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNumberFormatA(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_LPCSTR_lpValue, cpointer unfoundType_NUMBERFMTAlpFormatlpFormat_unnamed_3, [MarshalAs(UnmanagedType.LPStr)] string lpNumberStr, int cchNumber);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNumberFormatA(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_LPCSTR_lpValue, cpointer unfoundType_NUMBERFMTAlpFormatlpFormat_unnamed_3, ReadOnlySpan<byte> lpNumberStr, int cchNumber);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNumberFormatA(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_LPCSTR_lpValue, cpointer unfoundType_NUMBERFMTAlpFormatlpFormat_unnamed_3, byte* lpNumberStr, int cchNumber);
    [DllImport("kernel32", EntryPoint="GetNumberFormatW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNumberFormat(cpointer unfoundType_LCID_Locale, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, cpointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, string lpNumberStr, int cchNumber);
    [DllImport("kernel32", EntryPoint="GetNumberFormatW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNumberFormat(cpointer unfoundType_LCID_Locale, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, cpointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, char* lpNumberStr, int cchNumber);
    [DllImport("kernel32", EntryPoint="GetNumberFormatW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNumberFormat(cpointer unfoundType_LCID_Locale, int dwFlags, char* lpValue, cpointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, string lpNumberStr, int cchNumber);
    [DllImport("kernel32", EntryPoint="GetNumberFormatW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNumberFormat(cpointer unfoundType_LCID_Locale, int dwFlags, char* lpValue, cpointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, char* lpNumberStr, int cchNumber);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNumberFormatW(cpointer unfoundType_LCID_Locale, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, cpointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, string lpNumberStr, int cchNumber);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNumberFormatW(cpointer unfoundType_LCID_Locale, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, cpointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, char* lpNumberStr, int cchNumber);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNumberFormatW(cpointer unfoundType_LCID_Locale, int dwFlags, char* lpValue, cpointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, string lpNumberStr, int cchNumber);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNumberFormatW(cpointer unfoundType_LCID_Locale, int dwFlags, char* lpValue, cpointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, char* lpNumberStr, int cchNumber);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrencyFormatA(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_LPCSTR_lpValue, cpointer unfoundType_CURRENCYFMTAlpFormatlpFormat_unnamed_3, [MarshalAs(UnmanagedType.LPStr)] string lpCurrencyStr, int cchCurrency);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrencyFormatA(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_LPCSTR_lpValue, cpointer unfoundType_CURRENCYFMTAlpFormatlpFormat_unnamed_3, ReadOnlySpan<byte> lpCurrencyStr, int cchCurrency);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrencyFormatA(cpointer unfoundType_LCID_Locale, int dwFlags, cpointer unfoundType_LPCSTR_lpValue, cpointer unfoundType_CURRENCYFMTAlpFormatlpFormat_unnamed_3, byte* lpCurrencyStr, int cchCurrency);
    [DllImport("kernel32", EntryPoint="GetCurrencyFormatW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrencyFormat(cpointer unfoundType_LCID_Locale, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, cpointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, string lpCurrencyStr, int cchCurrency);
    [DllImport("kernel32", EntryPoint="GetCurrencyFormatW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrencyFormat(cpointer unfoundType_LCID_Locale, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, cpointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, char* lpCurrencyStr, int cchCurrency);
    [DllImport("kernel32", EntryPoint="GetCurrencyFormatW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrencyFormat(cpointer unfoundType_LCID_Locale, int dwFlags, char* lpValue, cpointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, string lpCurrencyStr, int cchCurrency);
    [DllImport("kernel32", EntryPoint="GetCurrencyFormatW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrencyFormat(cpointer unfoundType_LCID_Locale, int dwFlags, char* lpValue, cpointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, char* lpCurrencyStr, int cchCurrency);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrencyFormatW(cpointer unfoundType_LCID_Locale, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, cpointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, string lpCurrencyStr, int cchCurrency);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrencyFormatW(cpointer unfoundType_LCID_Locale, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, cpointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, char* lpCurrencyStr, int cchCurrency);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrencyFormatW(cpointer unfoundType_LCID_Locale, int dwFlags, char* lpValue, cpointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, string lpCurrencyStr, int cchCurrency);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrencyFormatW(cpointer unfoundType_LCID_Locale, int dwFlags, char* lpValue, cpointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, char* lpCurrencyStr, int cchCurrency);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumCalendarInfoA(cpointer unfoundType_CALINFO_ENUMPROCA_lpCalInfoEnumProc, cpointer unfoundType_LCID_Locale, cpointer unfoundType_CALID_Calendar, cpointer unfoundType_CALTYPE_CalType);
    [DllImport("kernel32", EntryPoint="EnumCalendarInfoW", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumCalendarInfo(cpointer unfoundType_CALINFO_ENUMPROCW_lpCalInfoEnumProc, cpointer unfoundType_LCID_Locale, cpointer unfoundType_CALID_Calendar, cpointer unfoundType_CALTYPE_CalType);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumCalendarInfoW(cpointer unfoundType_CALINFO_ENUMPROCW_lpCalInfoEnumProc, cpointer unfoundType_LCID_Locale, cpointer unfoundType_CALID_Calendar, cpointer unfoundType_CALTYPE_CalType);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumCalendarInfoExA(cpointer unfoundType_CALINFO_ENUMPROCEXA_lpCalInfoEnumProcEx, cpointer unfoundType_LCID_Locale, cpointer unfoundType_CALID_Calendar, cpointer unfoundType_CALTYPE_CalType);
    [DllImport("kernel32", EntryPoint="EnumCalendarInfoExW", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumCalendarInfoEx(cpointer unfoundType_CALINFO_ENUMPROCEXW_lpCalInfoEnumProcEx, cpointer unfoundType_LCID_Locale, cpointer unfoundType_CALID_Calendar, cpointer unfoundType_CALTYPE_CalType);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumCalendarInfoExW(cpointer unfoundType_CALINFO_ENUMPROCEXW_lpCalInfoEnumProcEx, cpointer unfoundType_LCID_Locale, cpointer unfoundType_CALID_Calendar, cpointer unfoundType_CALTYPE_CalType);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumTimeFormatsA(cpointer unfoundType_TIMEFMT_ENUMPROCA_lpTimeFmtEnumProc, cpointer unfoundType_LCID_Locale, int dwFlags);
    [DllImport("kernel32", EntryPoint="EnumTimeFormatsW", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumTimeFormats(cpointer unfoundType_TIMEFMT_ENUMPROCW_lpTimeFmtEnumProc, cpointer unfoundType_LCID_Locale, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumTimeFormatsW(cpointer unfoundType_TIMEFMT_ENUMPROCW_lpTimeFmtEnumProc, cpointer unfoundType_LCID_Locale, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumDateFormatsA(cpointer unfoundType_DATEFMT_ENUMPROCA_lpDateFmtEnumProc, cpointer unfoundType_LCID_Locale, int dwFlags);
    [DllImport("kernel32", EntryPoint="EnumDateFormatsW", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumDateFormats(cpointer unfoundType_DATEFMT_ENUMPROCW_lpDateFmtEnumProc, cpointer unfoundType_LCID_Locale, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumDateFormatsW(cpointer unfoundType_DATEFMT_ENUMPROCW_lpDateFmtEnumProc, cpointer unfoundType_LCID_Locale, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumDateFormatsExA(cpointer unfoundType_DATEFMT_ENUMPROCEXA_lpDateFmtEnumProcEx, cpointer unfoundType_LCID_Locale, int dwFlags);
    [DllImport("kernel32", EntryPoint="EnumDateFormatsExW", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumDateFormatsEx(cpointer unfoundType_DATEFMT_ENUMPROCEXW_lpDateFmtEnumProcEx, cpointer unfoundType_LCID_Locale, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumDateFormatsExW(cpointer unfoundType_DATEFMT_ENUMPROCEXW_lpDateFmtEnumProcEx, cpointer unfoundType_LCID_Locale, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsValidLanguageGroup(cpointer unfoundType_LGRPID_LanguageGroup, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNLSVersion(cpointer unfoundType_NLS_FUNCTION_Function, cpointer unfoundType_LCID_Locale, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsValidLocale(cpointer unfoundType_LCID_Locale, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetGeoInfoA(cpointer unfoundType_GEOID_Location, cpointer unfoundType_GEOTYPE_GeoType, [MarshalAs(UnmanagedType.LPStr)] string lpGeoData, int cchData, cpointer unfoundType_LANGID_LangId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetGeoInfoA(cpointer unfoundType_GEOID_Location, cpointer unfoundType_GEOTYPE_GeoType, ReadOnlySpan<byte> lpGeoData, int cchData, cpointer unfoundType_LANGID_LangId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetGeoInfoA(cpointer unfoundType_GEOID_Location, cpointer unfoundType_GEOTYPE_GeoType, byte* lpGeoData, int cchData, cpointer unfoundType_LANGID_LangId);
    [DllImport("kernel32", EntryPoint="GetGeoInfoW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetGeoInfo(cpointer unfoundType_GEOID_Location, cpointer unfoundType_GEOTYPE_GeoType, string lpGeoData, int cchData, cpointer unfoundType_LANGID_LangId);
    [DllImport("kernel32", EntryPoint="GetGeoInfoW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetGeoInfo(cpointer unfoundType_GEOID_Location, cpointer unfoundType_GEOTYPE_GeoType, char* lpGeoData, int cchData, cpointer unfoundType_LANGID_LangId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetGeoInfoW(cpointer unfoundType_GEOID_Location, cpointer unfoundType_GEOTYPE_GeoType, string lpGeoData, int cchData, cpointer unfoundType_LANGID_LangId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetGeoInfoW(cpointer unfoundType_GEOID_Location, cpointer unfoundType_GEOTYPE_GeoType, char* lpGeoData, int cchData, cpointer unfoundType_LANGID_LangId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetGeoInfoEx([MarshalAs(UnmanagedType.LPWStr)] string location, cpointer unfoundType_GEOTYPE_geoType, [MarshalAs(UnmanagedType.LPWStr)] string geoData, int geoDataCount);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetGeoInfoEx([MarshalAs(UnmanagedType.LPWStr)] string location, cpointer unfoundType_GEOTYPE_geoType, char* geoData, int geoDataCount);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetGeoInfoEx(char* location, cpointer unfoundType_GEOTYPE_geoType, [MarshalAs(UnmanagedType.LPWStr)] string geoData, int geoDataCount);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetGeoInfoEx(char* location, cpointer unfoundType_GEOTYPE_geoType, char* geoData, int geoDataCount);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumSystemGeoID(cpointer unfoundType_GEOCLASS_GeoClass, cpointer unfoundType_GEOID_ParentGeoId, cpointer unfoundType_GEO_ENUMPROC_lpGeoEnumProc);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumSystemGeoNames(cpointer unfoundType_GEOCLASS_geoClass, cpointer unfoundType_GEO_ENUMNAMEPROC_geoEnumProc, long data);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetUserGeoID(cpointer unfoundType_GEOCLASS_GeoClass);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetUserDefaultGeoName(string geoName, int geoNameCount);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetUserDefaultGeoName(char* geoName, int geoNameCount);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetUserGeoID(cpointer unfoundType_GEOID_GeoId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetUserGeoName([MarshalAs(UnmanagedType.LPWStr)] string geoName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetUserGeoName(char* geoName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer ConvertDefaultLocale(cpointer unfoundType_LCID_Locale);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetSystemDefaultUILanguage();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetThreadLocale();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetThreadLocale(cpointer unfoundType_LCID_Locale);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetUserDefaultUILanguage();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetUserDefaultLangID();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetSystemDefaultLangID();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetSystemDefaultLCID();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetUserDefaultLCID();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer SetThreadUILanguage(cpointer unfoundType_LANGID_LangId);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetThreadUILanguage();
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProcessPreferredUILanguages(int dwFlags, cpointer unfoundType_PULONG_pulNumLanguages, cpointer unfoundType_PZZWSTR_pwszLanguagesBuffer, cpointer unfoundType_PULONG_pcchLanguagesBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetProcessPreferredUILanguages(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pwszLanguagesBuffer, cpointer unfoundType_PULONG_pulNumLanguages);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetProcessPreferredUILanguages(int dwFlags, char* pwszLanguagesBuffer, cpointer unfoundType_PULONG_pulNumLanguages);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetUserPreferredUILanguages(int dwFlags, cpointer unfoundType_PULONG_pulNumLanguages, cpointer unfoundType_PZZWSTR_pwszLanguagesBuffer, cpointer unfoundType_PULONG_pcchLanguagesBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetSystemPreferredUILanguages(int dwFlags, cpointer unfoundType_PULONG_pulNumLanguages, cpointer unfoundType_PZZWSTR_pwszLanguagesBuffer, cpointer unfoundType_PULONG_pcchLanguagesBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetThreadPreferredUILanguages(int dwFlags, cpointer unfoundType_PULONG_pulNumLanguages, cpointer unfoundType_PZZWSTR_pwszLanguagesBuffer, cpointer unfoundType_PULONG_pcchLanguagesBuffer);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetThreadPreferredUILanguages(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pwszLanguagesBuffer, cpointer unfoundType_PULONG_pulNumLanguages);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetThreadPreferredUILanguages(int dwFlags, char* pwszLanguagesBuffer, cpointer unfoundType_PULONG_pulNumLanguages);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFileMUIInfo(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pcwszFilePath, cpointer unfoundType_PFILEMUIINFO_pFileMUIInfo, cpointer pcbFileMUIInfo);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFileMUIInfo(int dwFlags, char* pcwszFilePath, cpointer unfoundType_PFILEMUIINFO_pFileMUIInfo, cpointer pcbFileMUIInfo);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFileMUIPath(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pcwszFilePath, [MarshalAs(UnmanagedType.LPWStr)] string pwszLanguage, cpointer unfoundType_PULONG_pcchLanguage, [MarshalAs(UnmanagedType.LPWStr)] string pwszFileMUIPath, cpointer unfoundType_PULONG_pcchFileMUIPath, cpointer unfoundType_PULONGLONG_pululEnumerator);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFileMUIPath(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pcwszFilePath, [MarshalAs(UnmanagedType.LPWStr)] string pwszLanguage, cpointer unfoundType_PULONG_pcchLanguage, char* pwszFileMUIPath, cpointer unfoundType_PULONG_pcchFileMUIPath, cpointer unfoundType_PULONGLONG_pululEnumerator);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFileMUIPath(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pcwszFilePath, char* pwszLanguage, cpointer unfoundType_PULONG_pcchLanguage, [MarshalAs(UnmanagedType.LPWStr)] string pwszFileMUIPath, cpointer unfoundType_PULONG_pcchFileMUIPath, cpointer unfoundType_PULONGLONG_pululEnumerator);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFileMUIPath(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pcwszFilePath, char* pwszLanguage, cpointer unfoundType_PULONG_pcchLanguage, char* pwszFileMUIPath, cpointer unfoundType_PULONG_pcchFileMUIPath, cpointer unfoundType_PULONGLONG_pululEnumerator);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFileMUIPath(int dwFlags, char* pcwszFilePath, [MarshalAs(UnmanagedType.LPWStr)] string pwszLanguage, cpointer unfoundType_PULONG_pcchLanguage, [MarshalAs(UnmanagedType.LPWStr)] string pwszFileMUIPath, cpointer unfoundType_PULONG_pcchFileMUIPath, cpointer unfoundType_PULONGLONG_pululEnumerator);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFileMUIPath(int dwFlags, char* pcwszFilePath, [MarshalAs(UnmanagedType.LPWStr)] string pwszLanguage, cpointer unfoundType_PULONG_pcchLanguage, char* pwszFileMUIPath, cpointer unfoundType_PULONG_pcchFileMUIPath, cpointer unfoundType_PULONGLONG_pululEnumerator);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFileMUIPath(int dwFlags, char* pcwszFilePath, char* pwszLanguage, cpointer unfoundType_PULONG_pcchLanguage, [MarshalAs(UnmanagedType.LPWStr)] string pwszFileMUIPath, cpointer unfoundType_PULONG_pcchFileMUIPath, cpointer unfoundType_PULONGLONG_pululEnumerator);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetFileMUIPath(int dwFlags, char* pcwszFilePath, char* pwszLanguage, cpointer unfoundType_PULONG_pcchLanguage, char* pwszFileMUIPath, cpointer unfoundType_PULONG_pcchFileMUIPath, cpointer unfoundType_PULONGLONG_pululEnumerator);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetUILanguageInfo(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pwmszLanguage, cpointer unfoundType_PZZWSTR_pwszFallbackLanguages, cpointer unfoundType_PDWORD_pcchFallbackLanguages, cpointer unfoundType_PDWORD_pAttributes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetUILanguageInfo(int dwFlags, char* pwmszLanguage, cpointer unfoundType_PZZWSTR_pwszFallbackLanguages, cpointer unfoundType_PDWORD_pcchFallbackLanguages, cpointer unfoundType_PDWORD_pAttributes);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int NotifyUILanguageChange(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pcwstrNewLanguage, [MarshalAs(UnmanagedType.LPWStr)] string pcwstrPreviousLanguage, int dwReserved, cpointer unfoundType_PDWORD_pdwStatusRtrn);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int NotifyUILanguageChange(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pcwstrNewLanguage, char* pcwstrPreviousLanguage, int dwReserved, cpointer unfoundType_PDWORD_pdwStatusRtrn);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int NotifyUILanguageChange(int dwFlags, char* pcwstrNewLanguage, [MarshalAs(UnmanagedType.LPWStr)] string pcwstrPreviousLanguage, int dwReserved, cpointer unfoundType_PDWORD_pdwStatusRtrn);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int NotifyUILanguageChange(int dwFlags, char* pcwstrNewLanguage, char* pcwstrPreviousLanguage, int dwReserved, cpointer unfoundType_PDWORD_pdwStatusRtrn);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetStringTypeExA(cpointer unfoundType_LCID_Locale, int dwInfoType, cpointer unfoundType_LPCSTR_lpSrcStr, int cchSrc, cpointer unfoundType_LPWORD_lpCharType);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetStringTypeA(cpointer unfoundType_LCID_Locale, int dwInfoType, cpointer unfoundType_LPCSTR_lpSrcStr, int cchSrc, cpointer unfoundType_LPWORD_lpCharType);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FoldStringA(int dwMapFlags, cpointer unfoundType_LPCSTR_lpSrcStr, int cchSrc, [MarshalAs(UnmanagedType.LPStr)] string lpDestStr, int cchDest);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FoldStringA(int dwMapFlags, cpointer unfoundType_LPCSTR_lpSrcStr, int cchSrc, ReadOnlySpan<byte> lpDestStr, int cchDest);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FoldStringA(int dwMapFlags, cpointer unfoundType_LPCSTR_lpSrcStr, int cchSrc, byte* lpDestStr, int cchDest);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumSystemLocalesA(cpointer unfoundType_LOCALE_ENUMPROCA_lpLocaleEnumProc, int dwFlags);
    [DllImport("kernel32", EntryPoint="EnumSystemLocalesW", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumSystemLocales(cpointer unfoundType_LOCALE_ENUMPROCW_lpLocaleEnumProc, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumSystemLocalesW(cpointer unfoundType_LOCALE_ENUMPROCW_lpLocaleEnumProc, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumSystemLanguageGroupsA(cpointer unfoundType_LANGUAGEGROUP_ENUMPROCA_lpLanguageGroupEnumProc, int dwFlags, long lParam);
    [DllImport("kernel32", EntryPoint="EnumSystemLanguageGroupsW", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumSystemLanguageGroups(cpointer unfoundType_LANGUAGEGROUP_ENUMPROCW_lpLanguageGroupEnumProc, int dwFlags, long lParam);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumSystemLanguageGroupsW(cpointer unfoundType_LANGUAGEGROUP_ENUMPROCW_lpLanguageGroupEnumProc, int dwFlags, long lParam);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumLanguageGroupLocalesA(cpointer unfoundType_LANGGROUPLOCALE_ENUMPROCA_lpLangGroupLocaleEnumProc, cpointer unfoundType_LGRPID_LanguageGroup, int dwFlags, long lParam);
    [DllImport("kernel32", EntryPoint="EnumLanguageGroupLocalesW", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumLanguageGroupLocales(cpointer unfoundType_LANGGROUPLOCALE_ENUMPROCW_lpLangGroupLocaleEnumProc, cpointer unfoundType_LGRPID_LanguageGroup, int dwFlags, long lParam);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumLanguageGroupLocalesW(cpointer unfoundType_LANGGROUPLOCALE_ENUMPROCW_lpLangGroupLocaleEnumProc, cpointer unfoundType_LGRPID_LanguageGroup, int dwFlags, long lParam);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumUILanguagesA(cpointer unfoundType_UILANGUAGE_ENUMPROCA_lpUILanguageEnumProc, int dwFlags, long lParam);
    [DllImport("kernel32", EntryPoint="EnumUILanguagesW", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumUILanguages(cpointer unfoundType_UILANGUAGE_ENUMPROCW_lpUILanguageEnumProc, int dwFlags, long lParam);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumUILanguagesW(cpointer unfoundType_UILANGUAGE_ENUMPROCW_lpUILanguageEnumProc, int dwFlags, long lParam);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumSystemCodePagesA(cpointer unfoundType_CODEPAGE_ENUMPROCA_lpCodePageEnumProc, int dwFlags);
    [DllImport("kernel32", EntryPoint="EnumSystemCodePagesW", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumSystemCodePages(cpointer unfoundType_CODEPAGE_ENUMPROCW_lpCodePageEnumProc, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumSystemCodePagesW(cpointer unfoundType_CODEPAGE_ENUMPROCW_lpCodePageEnumProc, int dwFlags);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLocaleInfoEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, cpointer unfoundType_LCTYPE_LCType, string lpLCData, int cchData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLocaleInfoEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, cpointer unfoundType_LCTYPE_LCType, char* lpLCData, int cchData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLocaleInfoEx(char* lpLocaleName, cpointer unfoundType_LCTYPE_LCType, string lpLCData, int cchData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLocaleInfoEx(char* lpLocaleName, cpointer unfoundType_LCTYPE_LCType, char* lpLCData, int cchData);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCalendarInfoEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, cpointer unfoundType_CALID_Calendar, [MarshalAs(UnmanagedType.LPWStr)] string lpReserved, cpointer unfoundType_CALTYPE_CalType, string lpCalData, int cchData, cpointer unfoundType_LPDWORD_lpValue);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCalendarInfoEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, cpointer unfoundType_CALID_Calendar, [MarshalAs(UnmanagedType.LPWStr)] string lpReserved, cpointer unfoundType_CALTYPE_CalType, char* lpCalData, int cchData, cpointer unfoundType_LPDWORD_lpValue);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCalendarInfoEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, cpointer unfoundType_CALID_Calendar, char* lpReserved, cpointer unfoundType_CALTYPE_CalType, string lpCalData, int cchData, cpointer unfoundType_LPDWORD_lpValue);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCalendarInfoEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, cpointer unfoundType_CALID_Calendar, char* lpReserved, cpointer unfoundType_CALTYPE_CalType, char* lpCalData, int cchData, cpointer unfoundType_LPDWORD_lpValue);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCalendarInfoEx(char* lpLocaleName, cpointer unfoundType_CALID_Calendar, [MarshalAs(UnmanagedType.LPWStr)] string lpReserved, cpointer unfoundType_CALTYPE_CalType, string lpCalData, int cchData, cpointer unfoundType_LPDWORD_lpValue);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCalendarInfoEx(char* lpLocaleName, cpointer unfoundType_CALID_Calendar, [MarshalAs(UnmanagedType.LPWStr)] string lpReserved, cpointer unfoundType_CALTYPE_CalType, char* lpCalData, int cchData, cpointer unfoundType_LPDWORD_lpValue);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCalendarInfoEx(char* lpLocaleName, cpointer unfoundType_CALID_Calendar, char* lpReserved, cpointer unfoundType_CALTYPE_CalType, string lpCalData, int cchData, cpointer unfoundType_LPDWORD_lpValue);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCalendarInfoEx(char* lpLocaleName, cpointer unfoundType_CALID_Calendar, char* lpReserved, cpointer unfoundType_CALTYPE_CalType, char* lpCalData, int cchData, cpointer unfoundType_LPDWORD_lpValue);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNumberFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, cpointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, string lpNumberStr, int cchNumber);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNumberFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, cpointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, char* lpNumberStr, int cchNumber);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNumberFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, char* lpValue, cpointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, string lpNumberStr, int cchNumber);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNumberFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, char* lpValue, cpointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, char* lpNumberStr, int cchNumber);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNumberFormatEx(char* lpLocaleName, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, cpointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, string lpNumberStr, int cchNumber);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNumberFormatEx(char* lpLocaleName, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, cpointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, char* lpNumberStr, int cchNumber);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNumberFormatEx(char* lpLocaleName, int dwFlags, char* lpValue, cpointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, string lpNumberStr, int cchNumber);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNumberFormatEx(char* lpLocaleName, int dwFlags, char* lpValue, cpointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, char* lpNumberStr, int cchNumber);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrencyFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, cpointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, string lpCurrencyStr, int cchCurrency);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrencyFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, cpointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, char* lpCurrencyStr, int cchCurrency);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrencyFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, char* lpValue, cpointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, string lpCurrencyStr, int cchCurrency);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrencyFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, char* lpValue, cpointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, char* lpCurrencyStr, int cchCurrency);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrencyFormatEx(char* lpLocaleName, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, cpointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, string lpCurrencyStr, int cchCurrency);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrencyFormatEx(char* lpLocaleName, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, cpointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, char* lpCurrencyStr, int cchCurrency);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrencyFormatEx(char* lpLocaleName, int dwFlags, char* lpValue, cpointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, string lpCurrencyStr, int cchCurrency);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrencyFormatEx(char* lpLocaleName, int dwFlags, char* lpValue, cpointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, char* lpCurrencyStr, int cchCurrency);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetUserDefaultLocaleName(string lpLocaleName, int cchLocaleName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetUserDefaultLocaleName(char* lpLocaleName, int cchLocaleName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetSystemDefaultLocaleName(string lpLocaleName, int cchLocaleName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetSystemDefaultLocaleName(char* lpLocaleName, int cchLocaleName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsNLSDefinedString(cpointer unfoundType_NLS_FUNCTION_Function, int dwFlags, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, [MarshalAs(UnmanagedType.LPWStr)] string lpString, int cchStr);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsNLSDefinedString(cpointer unfoundType_NLS_FUNCTION_Function, int dwFlags, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, char* lpString, int cchStr);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNLSVersionEx(cpointer unfoundType_NLS_FUNCTION_function, [MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, cpointer unfoundType_LPNLSVERSIONINFOEX_lpVersionInformation);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetNLSVersionEx(cpointer unfoundType_NLS_FUNCTION_function, char* lpLocaleName, cpointer unfoundType_LPNLSVERSIONINFOEX_lpVersionInformation);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsValidNLSVersion(cpointer unfoundType_NLS_FUNCTION_function, [MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, cpointer unfoundType_LPNLSVERSIONINFOEX_lpVersionInformation);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsValidNLSVersion(cpointer unfoundType_NLS_FUNCTION_function, char* lpLocaleName, cpointer unfoundType_LPNLSVERSIONINFOEX_lpVersionInformation);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindNLSStringEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFindNLSStringFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpStringSource, int cchSource, [MarshalAs(UnmanagedType.LPWStr)] string lpStringValue, int cchValue, cpointer unfoundType_LPINT_pcchFound, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long sortHandle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindNLSStringEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFindNLSStringFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpStringSource, int cchSource, char* lpStringValue, int cchValue, cpointer unfoundType_LPINT_pcchFound, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long sortHandle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindNLSStringEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFindNLSStringFlags, char* lpStringSource, int cchSource, [MarshalAs(UnmanagedType.LPWStr)] string lpStringValue, int cchValue, cpointer unfoundType_LPINT_pcchFound, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long sortHandle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindNLSStringEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFindNLSStringFlags, char* lpStringSource, int cchSource, char* lpStringValue, int cchValue, cpointer unfoundType_LPINT_pcchFound, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long sortHandle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindNLSStringEx(char* lpLocaleName, int dwFindNLSStringFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpStringSource, int cchSource, [MarshalAs(UnmanagedType.LPWStr)] string lpStringValue, int cchValue, cpointer unfoundType_LPINT_pcchFound, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long sortHandle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindNLSStringEx(char* lpLocaleName, int dwFindNLSStringFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpStringSource, int cchSource, char* lpStringValue, int cchValue, cpointer unfoundType_LPINT_pcchFound, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long sortHandle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindNLSStringEx(char* lpLocaleName, int dwFindNLSStringFlags, char* lpStringSource, int cchSource, [MarshalAs(UnmanagedType.LPWStr)] string lpStringValue, int cchValue, cpointer unfoundType_LPINT_pcchFound, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long sortHandle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int FindNLSStringEx(char* lpLocaleName, int dwFindNLSStringFlags, char* lpStringSource, int cchSource, char* lpStringValue, int cchValue, cpointer unfoundType_LPINT_pcchFound, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long sortHandle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int LCMapStringEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwMapFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, string lpDestStr, int cchDest, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long sortHandle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int LCMapStringEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwMapFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, char* lpDestStr, int cchDest, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long sortHandle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int LCMapStringEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwMapFlags, char* lpSrcStr, int cchSrc, string lpDestStr, int cchDest, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long sortHandle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int LCMapStringEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwMapFlags, char* lpSrcStr, int cchSrc, char* lpDestStr, int cchDest, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long sortHandle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int LCMapStringEx(char* lpLocaleName, int dwMapFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, string lpDestStr, int cchDest, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long sortHandle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int LCMapStringEx(char* lpLocaleName, int dwMapFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, char* lpDestStr, int cchDest, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long sortHandle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int LCMapStringEx(char* lpLocaleName, int dwMapFlags, char* lpSrcStr, int cchSrc, string lpDestStr, int cchDest, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long sortHandle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int LCMapStringEx(char* lpLocaleName, int dwMapFlags, char* lpSrcStr, int cchSrc, char* lpDestStr, int cchDest, cpointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, cpointer lpReserved, long sortHandle);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsValidLocaleName([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsValidLocaleName(char* lpLocaleName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumCalendarInfoExEx(cpointer unfoundType_CALINFO_ENUMPROCEXEX_pCalInfoEnumProcExEx, [MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, cpointer unfoundType_CALID_Calendar, [MarshalAs(UnmanagedType.LPWStr)] string lpReserved, cpointer unfoundType_CALTYPE_CalType, long lParam);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumCalendarInfoExEx(cpointer unfoundType_CALINFO_ENUMPROCEXEX_pCalInfoEnumProcExEx, [MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, cpointer unfoundType_CALID_Calendar, char* lpReserved, cpointer unfoundType_CALTYPE_CalType, long lParam);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumCalendarInfoExEx(cpointer unfoundType_CALINFO_ENUMPROCEXEX_pCalInfoEnumProcExEx, char* lpLocaleName, cpointer unfoundType_CALID_Calendar, [MarshalAs(UnmanagedType.LPWStr)] string lpReserved, cpointer unfoundType_CALTYPE_CalType, long lParam);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumCalendarInfoExEx(cpointer unfoundType_CALINFO_ENUMPROCEXEX_pCalInfoEnumProcExEx, char* lpLocaleName, cpointer unfoundType_CALID_Calendar, char* lpReserved, cpointer unfoundType_CALTYPE_CalType, long lParam);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumDateFormatsExEx(cpointer unfoundType_DATEFMT_ENUMPROCEXEX_lpDateFmtEnumProcExEx, [MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, long lParam);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumDateFormatsExEx(cpointer unfoundType_DATEFMT_ENUMPROCEXEX_lpDateFmtEnumProcExEx, char* lpLocaleName, int dwFlags, long lParam);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumTimeFormatsEx(cpointer unfoundType_TIMEFMT_ENUMPROCEX_lpTimeFmtEnumProcEx, [MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, long lParam);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumTimeFormatsEx(cpointer unfoundType_TIMEFMT_ENUMPROCEX_lpTimeFmtEnumProcEx, char* lpLocaleName, int dwFlags, long lParam);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumSystemLocalesEx(cpointer unfoundType_LOCALE_ENUMPROCEX_lpLocaleEnumProcEx, int dwFlags, long lParam, cpointer lpReserved);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ResolveLocaleName([MarshalAs(UnmanagedType.LPWStr)] string lpNameToResolve, string lpLocaleName, int cchLocaleName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ResolveLocaleName([MarshalAs(UnmanagedType.LPWStr)] string lpNameToResolve, char* lpLocaleName, int cchLocaleName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ResolveLocaleName(char* lpNameToResolve, string lpLocaleName, int cchLocaleName);
    [DllImport("kernel32", SetLastError=true, ExactSpelling=true)] public static extern
        int ResolveLocaleName(char* lpNameToResolve, char* lpLocaleName, int cchLocaleName);
}