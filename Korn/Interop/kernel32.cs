public unsafe class kernel32
{
    const string lib = "kernel32";
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer VirtualAlloc(pointer lpAddress, pointer dwSize, int flAllocationType, int flProtect);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool VirtualProtect(pointer lpAddress, pointer dwSize, int flNewProtect, pointer unfoundType_PDWORD_lpflOldProtect);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool VirtualFree(pointer lpAddress, pointer dwSize, int dwFreeType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint* VirtualQuery(pointer lpAddress, pointer unfoundType_PMEMORY_BASIC_INFORMATION_lpBuffer, pointer dwLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer VirtualAllocEx(pointer hProcess, pointer lpAddress, pointer dwSize, int flAllocationType, int flProtect);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool VirtualProtectEx(pointer hProcess, pointer lpAddress, pointer dwSize, int flNewProtect, pointer unfoundType_PDWORD_lpflOldProtect);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint* VirtualQueryEx(pointer hProcess, pointer lpAddress, pointer unfoundType_PMEMORY_BASIC_INFORMATION_lpBuffer, pointer dwLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadProcessMemory(pointer hProcess, pointer lpBaseAddress, pointer lpBuffer, pointer nSize, pointer lpNumberOfBytesRead);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteProcessMemory(pointer hProcess, pointer lpBaseAddress, pointer lpBuffer, pointer nSize, pointer lpNumberOfBytesWritten);
    [DllImport(lib, EntryPoint = "CreateFileMappingW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateFileMapping(pointer hFile, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpFileMappingAttributes, int flProtect, int dwMaximumSizeHigh, int dwMaximumSizeLow, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport(lib, EntryPoint = "CreateFileMappingW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateFileMapping(pointer hFile, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpFileMappingAttributes, int flProtect, int dwMaximumSizeHigh, int dwMaximumSizeLow, char* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateFileMappingW(pointer hFile, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpFileMappingAttributes, int flProtect, int dwMaximumSizeHigh, int dwMaximumSizeLow, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateFileMappingW(pointer hFile, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpFileMappingAttributes, int flProtect, int dwMaximumSizeHigh, int dwMaximumSizeLow, char* lpName);
    [DllImport(lib, EntryPoint = "OpenFileMappingW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenFileMapping(int dwDesiredAccess, bool bInheritHandle, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport(lib, EntryPoint = "OpenFileMappingW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenFileMapping(int dwDesiredAccess, bool bInheritHandle, char* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenFileMappingW(int dwDesiredAccess, bool bInheritHandle, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenFileMappingW(int dwDesiredAccess, bool bInheritHandle, char* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer MapViewOfFile(pointer hFileMappingObject, int dwDesiredAccess, int dwFileOffsetHigh, int dwFileOffsetLow, pointer dwNumberOfBytesToMap);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer MapViewOfFileEx(pointer hFileMappingObject, int dwDesiredAccess, int dwFileOffsetHigh, int dwFileOffsetLow, pointer dwNumberOfBytesToMap, pointer lpBaseAddress);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool VirtualFreeEx(pointer hProcess, pointer lpAddress, pointer dwSize, int dwFreeType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FlushViewOfFile(pointer lpBaseAddress, pointer dwNumberOfBytesToFlush);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UnmapViewOfFile(pointer lpBaseAddress);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint* GetLargePageMinimum();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetProcessWorkingSetSize(pointer hProcess, pointer unfoundType_PSIZE_T_lpMinimumWorkingSetSize, pointer unfoundType_PSIZE_T_lpMaximumWorkingSetSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetProcessWorkingSetSizeEx(pointer hProcess, pointer unfoundType_PSIZE_T_lpMinimumWorkingSetSize, pointer unfoundType_PSIZE_T_lpMaximumWorkingSetSize, pointer unfoundType_PDWORD_Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetProcessWorkingSetSize(pointer hProcess, pointer dwMinimumWorkingSetSize, pointer dwMaximumWorkingSetSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetProcessWorkingSetSizeEx(pointer hProcess, pointer dwMinimumWorkingSetSize, pointer dwMaximumWorkingSetSize, int Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool VirtualLock(pointer lpAddress, pointer dwSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool VirtualUnlock(pointer lpAddress, pointer dwSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetWriteWatch(int dwFlags, pointer lpBaseAddress, pointer dwRegionSize, pointer lpAddresses, pointer unfoundType_ULONG_PTR_lpdwCount, pointer unfoundType_LPDWORD_lpdwGranularity);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint ResetWriteWatch(pointer lpBaseAddress, pointer dwRegionSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateMemoryResourceNotification(pointer unfoundType_MEMORY_RESOURCE_NOTIFICATION_TYPE_NotificationType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryMemoryResourceNotification(pointer ResourceNotificationHandle, pointer ResourceState);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetSystemFileCacheSize(pointer unfoundType_PSIZE_T_lpMinimumFileCacheSize, pointer unfoundType_PSIZE_T_lpMaximumFileCacheSize, pointer unfoundType_PDWORD_lpFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetSystemFileCacheSize(pointer MinimumFileCacheSize, pointer MaximumFileCacheSize, int Flags);
    [DllImport(lib, EntryPoint = "CreateFileMappingNumaW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateFileMappingNuma(pointer hFile, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpFileMappingAttributes, int flProtect, int dwMaximumSizeHigh, int dwMaximumSizeLow, [MarshalAs(UnmanagedType.LPWStr)] string lpName, int nndPreferred);
    [DllImport(lib, EntryPoint = "CreateFileMappingNumaW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateFileMappingNuma(pointer hFile, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpFileMappingAttributes, int flProtect, int dwMaximumSizeHigh, int dwMaximumSizeLow, char* lpName, int nndPreferred);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateFileMappingNumaW(pointer hFile, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpFileMappingAttributes, int flProtect, int dwMaximumSizeHigh, int dwMaximumSizeLow, [MarshalAs(UnmanagedType.LPWStr)] string lpName, int nndPreferred);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateFileMappingNumaW(pointer hFile, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpFileMappingAttributes, int flProtect, int dwMaximumSizeHigh, int dwMaximumSizeLow, char* lpName, int nndPreferred);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool PrefetchVirtualMemory(pointer hProcess, pointer unfoundType_ULONG_PTR_NumberOfEntries, pointer unfoundType_PWIN32_MEMORY_RANGE_ENTRY_VirtualAddresses, uint Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateFileMappingFromApp(pointer hFile, pointer unfoundType_PSECURITY_ATTRIBUTES_SecurityAttributes, uint PageProtection, pointer unfoundType_ULONG64_MaximumSize, [MarshalAs(UnmanagedType.LPWStr)] string Name);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateFileMappingFromApp(pointer hFile, pointer unfoundType_PSECURITY_ATTRIBUTES_SecurityAttributes, uint PageProtection, pointer unfoundType_ULONG64_MaximumSize, char* Name);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer MapViewOfFileFromApp(pointer hFileMappingObject, uint DesiredAccess, pointer unfoundType_ULONG64_FileOffset, pointer NumberOfBytesToMap);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UnmapViewOfFileEx(pointer BaseAddress, uint UnmapFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AllocateUserPhysicalPages(pointer hProcess, pointer NumberOfPages, pointer PageArray);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FreeUserPhysicalPages(pointer hProcess, pointer NumberOfPages, pointer PageArray);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MapUserPhysicalPages(pointer VirtualAddress, pointer unfoundType_ULONG_PTR_NumberOfPages, pointer PageArray);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AllocateUserPhysicalPagesNuma(pointer hProcess, pointer NumberOfPages, pointer PageArray, int nndPreferred);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer VirtualAllocExNuma(pointer hProcess, pointer lpAddress, pointer dwSize, int flAllocationType, int flProtect, int nndPreferred);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetMemoryErrorHandlingCapabilities(pointer unfoundType_PULONG_Capabilities);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegisterBadMemoryNotification(pointer unfoundType_PBAD_MEMORY_CALLBACK_ROUTINE_Callback);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UnregisterBadMemoryNotification(pointer RegistrationHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int OfferVirtualMemory(pointer VirtualAddress, pointer Size, pointer unfoundType_OFFER_PRIORITY_Priority);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ReclaimVirtualMemory(pointer VirtualAddress, pointer Size);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int DiscardVirtualMemory(pointer VirtualAddress, pointer Size);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsEnclaveTypeSupported(int flEnclaveType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateEnclave(pointer hProcess, pointer lpAddress, pointer dwSize, pointer dwInitialCommitment, int flEnclaveType, pointer lpEnclaveInformation, int dwInfoLength, pointer unfoundType_LPDWORD_lpEnclaveError);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool LoadEnclaveData(pointer hProcess, pointer lpAddress, pointer lpBuffer, pointer nSize, int flProtect, pointer lpPageInformation, int dwInfoLength, pointer unfoundType_PSIZE_T_lpNumberOfBytesWritten, pointer unfoundType_LPDWORD_lpEnclaveError);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool InitializeEnclave(pointer hProcess, pointer lpAddress, pointer lpEnclaveInformation, int dwInfoLength, pointer unfoundType_LPDWORD_lpEnclaveError);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void RaiseException(int dwExceptionCode, int dwExceptionFlags, int nNumberOfArguments, pointer unfoundType_ULONG_PTR_lpArguments);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int UnhandledExceptionFilter(pointer unfoundType__EXCEPTION_POINTERS_ExceptionInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer SetUnhandledExceptionFilter(pointer unfoundType_LPTOP_LEVEL_EXCEPTION_FILTER_lpTopLevelExceptionFilter);
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
        pointer AddVectoredExceptionHandler(uint First, pointer unfoundType_PVECTORED_EXCEPTION_HANDLER_Handler);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint RemoveVectoredExceptionHandler(pointer Handle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer AddVectoredContinueHandler(uint First, pointer unfoundType_PVECTORED_EXCEPTION_HANDLER_Handler);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint RemoveVectoredContinueHandler(pointer Handle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void RestoreLastError(int dwErrCode);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void RaiseFailFastException(pointer unfoundType_PEXCEPTION_RECORD_pExceptionRecord, pointer unfoundType_PCONTEXT_pContextRecord, int dwFlags);
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
        bool SetThreadErrorMode(int dwNewMode, pointer unfoundType_LPDWORD_lpOldMode);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void InitializeSListHead(pointer unfoundType_PSLIST_HEADER_ListHead);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer InterlockedPopEntrySList(pointer unfoundType_PSLIST_HEADER_ListHead);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer InterlockedPushEntrySList(pointer unfoundType_PSLIST_HEADER_ListHead, pointer unfoundType_PSLIST_ENTRY_ListEntry);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer InterlockedPushListSListEx(pointer unfoundType_PSLIST_HEADER_ListHead, pointer unfoundType_PSLIST_ENTRY_List, pointer unfoundType_PSLIST_ENTRY_ListEnd, uint Count);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer InterlockedFlushSList(pointer unfoundType_PSLIST_HEADER_ListHead);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ushort QueryDepthSList(pointer unfoundType_PSLIST_HEADER_ListHead);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateIoCompletionPort(pointer FileHandle, pointer ExistingCompletionPort, pointer unfoundType_ULONG_PTR_CompletionKey, int NumberOfConcurrentThreads);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetQueuedCompletionStatus(pointer CompletionPort, pointer unfoundType_LPDWORD_lpNumberOfBytesTransferred, pointer lpCompletionKey, pointer unfoundType_LPOVERLAPPED_lpOverlapped, int dwMilliseconds);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetQueuedCompletionStatusEx(pointer CompletionPort, pointer unfoundType_LPOVERLAPPED_ENTRY_lpCompletionPortEntries, uint ulCount, pointer unfoundType_PULONG_ulNumEntriesRemoved, int dwMilliseconds, bool fAlertable);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool PostQueuedCompletionStatus(pointer CompletionPort, int dwNumberOfBytesTransferred, pointer unfoundType_ULONG_PTR_dwCompletionKey, pointer unfoundType_LPOVERLAPPED_lpOverlapped);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DeviceIoControl(pointer hDevice, int dwIoControlCode, pointer lpInBuffer, int nInBufferSize, pointer lpOutBuffer, int nOutBufferSize, pointer unfoundType_LPDWORD_lpBytesReturned, pointer unfoundType_LPOVERLAPPED_lpOverlapped);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetOverlappedResult(pointer hFile, pointer unfoundType_LPOVERLAPPED_lpOverlapped, pointer unfoundType_LPDWORD_lpNumberOfBytesTransferred, bool bWait);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CancelIoEx(pointer hFile, pointer unfoundType_LPOVERLAPPED_lpOverlapped);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CancelIo(pointer hFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetOverlappedResultEx(pointer hFile, pointer unfoundType_LPOVERLAPPED_lpOverlapped, pointer unfoundType_LPDWORD_lpNumberOfBytesTransferred, int dwMilliseconds, bool bAlertable);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CancelSynchronousIo(pointer hThread);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateIoRing(pointer unfoundType_IORING_VERSION_ioringVersion, pointer unfoundType_IORING_CREATE_FLAGS_flags, uint submissionQueueSize, uint completionQueueSize, pointer unfoundType_HIORING_h);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer BuildIoRingReadFile(pointer unfoundType_HIORING_ioRing, pointer unfoundType_IORING_HANDLE_REF_fileRef, pointer unfoundType_IORING_BUFFER_REF_dataRef, uint numberOfBytesToRead, pointer unfoundType_UINT64_fileOffset, ulong userData, pointer unfoundType_IORING_SQE_FLAGS_sqeFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer BuildIoRingRegisterFileHandles(pointer unfoundType_HIORING_ioRing, uint count, pointer handles, ulong userData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer BuildIoRingRegisterBuffers(pointer unfoundType_HIORING_ioRing, uint count, pointer unfoundType_IORING_BUFFER_INFO_buffers, ulong userData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer BuildIoRingWriteFile(pointer unfoundType_HIORING_ioRing, pointer unfoundType_IORING_HANDLE_REF_fileRef, pointer unfoundType_IORING_BUFFER_REF_bufferRef, uint numberOfBytesToWrite, pointer unfoundType_UINT64_fileOffset, pointer unfoundType_FILE_WRITE_FLAGS_writeFlags, ulong userData, pointer unfoundType_IORING_SQE_FLAGS_sqeFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer BuildIoRingFlushFile(pointer unfoundType_HIORING_ioRing, pointer unfoundType_IORING_HANDLE_REF_fileRef, pointer unfoundType_FILE_FLUSH_MODE_flushMode, ulong userData, pointer unfoundType_IORING_SQE_FLAGS_sqeFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CloseHandle(pointer hObject);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DuplicateHandle(pointer hSourceProcessHandle, pointer hSourceHandle, pointer hTargetProcessHandle, pointer unfoundType_LPHANDLE_lpTargetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetHandleInformation(pointer hObject, pointer unfoundType_LPDWORD_lpdwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetHandleInformation(pointer hObject, int dwMask, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer HeapCreate(int flOptions, pointer dwInitialSize, pointer dwMaximumSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool HeapDestroy(pointer hHeap);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer HeapAlloc(pointer hHeap, int dwFlags, pointer dwBytes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer HeapReAlloc(pointer hHeap, int dwFlags, pointer lpMem, pointer dwBytes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool HeapFree(pointer hHeap, int dwFlags, pointer lpMem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint* HeapSize(pointer hHeap, int dwFlags, pointer lpMem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetProcessHeap();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint* HeapCompact(pointer hHeap, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool HeapSetInformation(pointer HeapHandle, pointer unfoundType_HEAP_INFORMATION_CLASS_HeapInformationClass, pointer HeapInformation, pointer HeapInformationLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool HeapValidate(pointer hHeap, int dwFlags, pointer lpMem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool HeapSummary(pointer hHeap, int dwFlags, pointer unfoundType_LPHEAP_SUMMARY_lpSummary);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProcessHeaps(int NumberOfHeaps, pointer unfoundType_PHANDLE_ProcessHeaps);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool HeapLock(pointer hHeap);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool HeapUnlock(pointer hHeap);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool HeapWalk(pointer hHeap, pointer unfoundType_LPPROCESS_HEAP_ENTRY_lpEntry);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool HeapQueryInformation(pointer HeapHandle, pointer unfoundType_HEAP_INFORMATION_CLASS_HeapInformationClass, pointer HeapInformation, pointer HeapInformationLength, pointer unfoundType_PSIZE_T_ReturnLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsProcessInJob(pointer ProcessHandle, pointer JobHandle, pointer Result);
    [DllImport(lib, EntryPoint = "CreateJobObjectW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateJobObject(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpJobAttributes, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport(lib, EntryPoint = "CreateJobObjectW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateJobObject(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpJobAttributes, char* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateJobObjectW(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpJobAttributes, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateJobObjectW(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpJobAttributes, char* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void FreeMemoryJobObject(pointer Buffer);
    [DllImport(lib, EntryPoint = "OpenJobObjectW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenJobObject(int dwDesiredAccess, bool bInheritHandle, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport(lib, EntryPoint = "OpenJobObjectW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenJobObject(int dwDesiredAccess, bool bInheritHandle, char* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenJobObjectW(int dwDesiredAccess, bool bInheritHandle, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenJobObjectW(int dwDesiredAccess, bool bInheritHandle, char* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AssignProcessToJobObject(pointer hJob, pointer hProcess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool TerminateJobObject(pointer hJob, uint uExitCode);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetInformationJobObject(pointer hJob, pointer unfoundType_JOBOBJECTINFOCLASS_JobObjectInformationClass, pointer lpJobObjectInformation, int cbJobObjectInformationLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SetIoRateControlInformationJobObject(pointer hJob, pointer unfoundType_JOBOBJECT_IO_RATE_CONTROL_INFORMATION_IoRateControlInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryInformationJobObject(pointer hJob, pointer unfoundType_JOBOBJECTINFOCLASS_JobObjectInformationClass, pointer lpJobObjectInformation, int cbJobObjectInformationLength, pointer unfoundType_LPDWORD_lpReturnLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int QueryIoRateControlInformationJobObject(pointer hJob, [MarshalAs(UnmanagedType.LPWStr)] string VolumeName, pointer unfoundType_JOBOBJECT_IO_RATE_CONTROL_INFORMATION_InfoBlocks, pointer InfoBlockCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int QueryIoRateControlInformationJobObject(pointer hJob, char* VolumeName, pointer unfoundType_JOBOBJECT_IO_RATE_CONTROL_INFORMATION_InfoBlocks, pointer InfoBlockCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DisableThreadLibraryCalls(pointer unfoundType_HMODULE_hLibModule);
    [DllImport(lib, EntryPoint = "FindResourceExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindResourceEx(pointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, short wLanguage);
    [DllImport(lib, EntryPoint = "FindResourceExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindResourceEx(pointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, char* lpName, short wLanguage);
    [DllImport(lib, EntryPoint = "FindResourceExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindResourceEx(pointer unfoundType_HMODULE_hModule, char* lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, short wLanguage);
    [DllImport(lib, EntryPoint = "FindResourceExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindResourceEx(pointer unfoundType_HMODULE_hModule, char* lpType, char* lpName, short wLanguage);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindResourceExW(pointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, short wLanguage);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindResourceExW(pointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, char* lpName, short wLanguage);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindResourceExW(pointer unfoundType_HMODULE_hModule, char* lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, short wLanguage);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindResourceExW(pointer unfoundType_HMODULE_hModule, char* lpType, char* lpName, short wLanguage);
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
        bool FreeLibrary(pointer unfoundType_HMODULE_hLibModule);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void FreeLibraryAndExitThread(pointer unfoundType_HMODULE_hLibModule, int dwExitCode);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FreeResource(pointer unfoundType_HGLOBAL_hResData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetModuleFileNameA(pointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPStr)] string lpFilename, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetModuleFileNameA(pointer unfoundType_HMODULE_hModule, ReadOnlySpan<byte> lpFilename, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetModuleFileNameA(pointer unfoundType_HMODULE_hModule, byte* lpFilename, int nSize);
    [DllImport(lib, EntryPoint = "GetModuleFileNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetModuleFileName(pointer unfoundType_HMODULE_hModule, string lpFilename, int nSize);
    [DllImport(lib, EntryPoint = "GetModuleFileNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetModuleFileName(pointer unfoundType_HMODULE_hModule, char* lpFilename, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetModuleFileNameW(pointer unfoundType_HMODULE_hModule, string lpFilename, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetModuleFileNameW(pointer unfoundType_HMODULE_hModule, char* lpFilename, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetModuleHandleA([MarshalAs(UnmanagedType.LPStr)] string lpModuleName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetModuleHandleA(byte* lpModuleName);
    [DllImport(lib, EntryPoint = "GetModuleHandleW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetModuleHandle([MarshalAs(UnmanagedType.LPWStr)] string lpModuleName);
    [DllImport(lib, EntryPoint = "GetModuleHandleW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetModuleHandle(char* lpModuleName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetModuleHandleW([MarshalAs(UnmanagedType.LPWStr)] string lpModuleName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetModuleHandleW(char* lpModuleName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetModuleHandleExA(int dwFlags, [MarshalAs(UnmanagedType.LPStr)] string lpModuleName, pointer unfoundType_HMODULE_phModule);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetModuleHandleExA(int dwFlags, byte* lpModuleName, pointer unfoundType_HMODULE_phModule);
    [DllImport(lib, EntryPoint = "GetModuleHandleExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetModuleHandleEx(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpModuleName, pointer unfoundType_HMODULE_phModule);
    [DllImport(lib, EntryPoint = "GetModuleHandleExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetModuleHandleEx(int dwFlags, char* lpModuleName, pointer unfoundType_HMODULE_phModule);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetModuleHandleExW(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpModuleName, pointer unfoundType_HMODULE_phModule);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetModuleHandleExW(int dwFlags, char* lpModuleName, pointer unfoundType_HMODULE_phModule);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetProcAddress(pointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPStr)] string lpProcName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetProcAddress(pointer unfoundType_HMODULE_hModule, byte* lpProcName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadLibraryExA([MarshalAs(UnmanagedType.LPStr)] string lpLibFileName, pointer hFile, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadLibraryExA(byte* lpLibFileName, pointer hFile, int dwFlags);
    [DllImport(lib, EntryPoint = "LoadLibraryExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadLibraryEx([MarshalAs(UnmanagedType.LPWStr)] string lpLibFileName, pointer hFile, int dwFlags);
    [DllImport(lib, EntryPoint = "LoadLibraryExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadLibraryEx(char* lpLibFileName, pointer hFile, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadLibraryExW([MarshalAs(UnmanagedType.LPWStr)] string lpLibFileName, pointer hFile, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadLibraryExW(char* lpLibFileName, pointer hFile, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadResource(pointer unfoundType_HMODULE_hModule, pointer unfoundType_HRSRC_hResInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LockResource(pointer unfoundType_HGLOBAL_hResData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SizeofResource(pointer unfoundType_HMODULE_hModule, pointer unfoundType_HRSRC_hResInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer AddDllDirectory([MarshalAs(UnmanagedType.LPWStr)] string NewDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer AddDllDirectory(char* NewDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool RemoveDllDirectory(pointer unfoundType_DLL_DIRECTORY_COOKIE_Cookie);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetDefaultDllDirectories(int DirectoryFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguagesExA(pointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPStr)] string lpType, [MarshalAs(UnmanagedType.LPStr)] string lpName, pointer unfoundType_ENUMRESLANGPROCA_lpEnumFunc, long lParam, int dwFlags, pointer unfoundType_LANGID_LangId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguagesExA(pointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPStr)] string lpType, byte* lpName, pointer unfoundType_ENUMRESLANGPROCA_lpEnumFunc, long lParam, int dwFlags, pointer unfoundType_LANGID_LangId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguagesExA(pointer unfoundType_HMODULE_hModule, byte* lpType, [MarshalAs(UnmanagedType.LPStr)] string lpName, pointer unfoundType_ENUMRESLANGPROCA_lpEnumFunc, long lParam, int dwFlags, pointer unfoundType_LANGID_LangId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguagesExA(pointer unfoundType_HMODULE_hModule, byte* lpType, byte* lpName, pointer unfoundType_ENUMRESLANGPROCA_lpEnumFunc, long lParam, int dwFlags, pointer unfoundType_LANGID_LangId);
    [DllImport(lib, EntryPoint = "EnumResourceLanguagesExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguagesEx(pointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, pointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam, int dwFlags, pointer unfoundType_LANGID_LangId);
    [DllImport(lib, EntryPoint = "EnumResourceLanguagesExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguagesEx(pointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, char* lpName, pointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam, int dwFlags, pointer unfoundType_LANGID_LangId);
    [DllImport(lib, EntryPoint = "EnumResourceLanguagesExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguagesEx(pointer unfoundType_HMODULE_hModule, char* lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, pointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam, int dwFlags, pointer unfoundType_LANGID_LangId);
    [DllImport(lib, EntryPoint = "EnumResourceLanguagesExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguagesEx(pointer unfoundType_HMODULE_hModule, char* lpType, char* lpName, pointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam, int dwFlags, pointer unfoundType_LANGID_LangId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguagesExW(pointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, pointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam, int dwFlags, pointer unfoundType_LANGID_LangId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguagesExW(pointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, char* lpName, pointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam, int dwFlags, pointer unfoundType_LANGID_LangId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguagesExW(pointer unfoundType_HMODULE_hModule, char* lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, pointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam, int dwFlags, pointer unfoundType_LANGID_LangId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguagesExW(pointer unfoundType_HMODULE_hModule, char* lpType, char* lpName, pointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam, int dwFlags, pointer unfoundType_LANGID_LangId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceNamesExA(pointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPStr)] string lpType, pointer unfoundType_ENUMRESNAMEPROCA_lpEnumFunc, long lParam, int dwFlags, pointer unfoundType_LANGID_LangId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceNamesExA(pointer unfoundType_HMODULE_hModule, byte* lpType, pointer unfoundType_ENUMRESNAMEPROCA_lpEnumFunc, long lParam, int dwFlags, pointer unfoundType_LANGID_LangId);
    [DllImport(lib, EntryPoint = "EnumResourceNamesExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceNamesEx(pointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, pointer unfoundType_ENUMRESNAMEPROCW_lpEnumFunc, long lParam, int dwFlags, pointer unfoundType_LANGID_LangId);
    [DllImport(lib, EntryPoint = "EnumResourceNamesExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceNamesEx(pointer unfoundType_HMODULE_hModule, char* lpType, pointer unfoundType_ENUMRESNAMEPROCW_lpEnumFunc, long lParam, int dwFlags, pointer unfoundType_LANGID_LangId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceNamesExW(pointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, pointer unfoundType_ENUMRESNAMEPROCW_lpEnumFunc, long lParam, int dwFlags, pointer unfoundType_LANGID_LangId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceNamesExW(pointer unfoundType_HMODULE_hModule, char* lpType, pointer unfoundType_ENUMRESNAMEPROCW_lpEnumFunc, long lParam, int dwFlags, pointer unfoundType_LANGID_LangId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceTypesExA(pointer unfoundType_HMODULE_hModule, pointer unfoundType_ENUMRESTYPEPROCA_lpEnumFunc, long lParam, int dwFlags, pointer unfoundType_LANGID_LangId);
    [DllImport(lib, EntryPoint = "EnumResourceTypesExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceTypesEx(pointer unfoundType_HMODULE_hModule, pointer unfoundType_ENUMRESTYPEPROCW_lpEnumFunc, long lParam, int dwFlags, pointer unfoundType_LANGID_LangId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceTypesExW(pointer unfoundType_HMODULE_hModule, pointer unfoundType_ENUMRESTYPEPROCW_lpEnumFunc, long lParam, int dwFlags, pointer unfoundType_LANGID_LangId);
    [DllImport(lib, EntryPoint = "FindResourceW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindResource(pointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpType);
    [DllImport(lib, EntryPoint = "FindResourceW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindResource(pointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpName, char* lpType);
    [DllImport(lib, EntryPoint = "FindResourceW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindResource(pointer unfoundType_HMODULE_hModule, char* lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpType);
    [DllImport(lib, EntryPoint = "FindResourceW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindResource(pointer unfoundType_HMODULE_hModule, char* lpName, char* lpType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindResourceW(pointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindResourceW(pointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpName, char* lpType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindResourceW(pointer unfoundType_HMODULE_hModule, char* lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindResourceW(pointer unfoundType_HMODULE_hModule, char* lpName, char* lpType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadLibraryA([MarshalAs(UnmanagedType.LPStr)] string lpLibFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadLibraryA(byte* lpLibFileName);
    [DllImport(lib, EntryPoint = "LoadLibraryW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadLibrary([MarshalAs(UnmanagedType.LPWStr)] string lpLibFileName);
    [DllImport(lib, EntryPoint = "LoadLibraryW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadLibrary(char* lpLibFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadLibraryW([MarshalAs(UnmanagedType.LPWStr)] string lpLibFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadLibraryW(char* lpLibFileName);
    [DllImport(lib, EntryPoint = "EnumResourceNamesW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceNames(pointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, pointer unfoundType_ENUMRESNAMEPROCW_lpEnumFunc, long lParam);
    [DllImport(lib, EntryPoint = "EnumResourceNamesW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceNames(pointer unfoundType_HMODULE_hModule, char* lpType, pointer unfoundType_ENUMRESNAMEPROCW_lpEnumFunc, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceNamesW(pointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, pointer unfoundType_ENUMRESNAMEPROCW_lpEnumFunc, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceNamesW(pointer unfoundType_HMODULE_hModule, char* lpType, pointer unfoundType_ENUMRESNAMEPROCW_lpEnumFunc, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceNamesA(pointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPStr)] string lpType, pointer unfoundType_ENUMRESNAMEPROCA_lpEnumFunc, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceNamesA(pointer unfoundType_HMODULE_hModule, byte* lpType, pointer unfoundType_ENUMRESNAMEPROCA_lpEnumFunc, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadPackagedLibrary([MarshalAs(UnmanagedType.LPWStr)] string lpwLibFileName, int Reserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadPackagedLibrary(char* lpwLibFileName, int Reserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FlsAlloc(pointer unfoundType_PFLS_CALLBACK_FUNCTION_lpCallback);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FlsGetValue(int dwFlsIndex);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FlsSetValue(int dwFlsIndex, pointer lpFlsData);
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
        int CompareFileTime(pointer unfoundType_FILETIME_lpFileTime1, pointer unfoundType_FILETIME_lpFileTime2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryA([MarshalAs(UnmanagedType.LPStr)] string lpPathName, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryA(byte* lpPathName, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, EntryPoint = "CreateDirectoryW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectory([MarshalAs(UnmanagedType.LPWStr)] string lpPathName, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, EntryPoint = "CreateDirectoryW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectory(char* lpPathName, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryW([MarshalAs(UnmanagedType.LPWStr)] string lpPathName, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryW(char* lpPathName, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateFileA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, int dwDesiredAccess, int dwShareMode, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, pointer hTemplateFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateFileA(byte* lpFileName, int dwDesiredAccess, int dwShareMode, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, pointer hTemplateFile);
    [DllImport(lib, EntryPoint = "CreateFileW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateFile([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwDesiredAccess, int dwShareMode, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, pointer hTemplateFile);
    [DllImport(lib, EntryPoint = "CreateFileW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateFile(char* lpFileName, int dwDesiredAccess, int dwShareMode, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, pointer hTemplateFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateFileW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwDesiredAccess, int dwShareMode, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, pointer hTemplateFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateFileW(char* lpFileName, int dwDesiredAccess, int dwShareMode, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, pointer hTemplateFile);
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
        bool FileTimeToLocalFileTime(pointer unfoundType_FILETIME_lpFileTime, pointer unfoundType_LPFILETIME_lpLocalFileTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindClose(pointer hFindFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindCloseChangeNotification(pointer hChangeHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstChangeNotificationA([MarshalAs(UnmanagedType.LPStr)] string lpPathName, bool bWatchSubtree, int dwNotifyFilter);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstChangeNotificationA(byte* lpPathName, bool bWatchSubtree, int dwNotifyFilter);
    [DllImport(lib, EntryPoint = "FindFirstChangeNotificationW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstChangeNotification([MarshalAs(UnmanagedType.LPWStr)] string lpPathName, bool bWatchSubtree, int dwNotifyFilter);
    [DllImport(lib, EntryPoint = "FindFirstChangeNotificationW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstChangeNotification(char* lpPathName, bool bWatchSubtree, int dwNotifyFilter);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstChangeNotificationW([MarshalAs(UnmanagedType.LPWStr)] string lpPathName, bool bWatchSubtree, int dwNotifyFilter);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstChangeNotificationW(char* lpPathName, bool bWatchSubtree, int dwNotifyFilter);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstFileA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, pointer unfoundType_LPWIN32_FIND_DATAA_lpFindFileData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstFileA(byte* lpFileName, pointer unfoundType_LPWIN32_FIND_DATAA_lpFindFileData);
    [DllImport(lib, EntryPoint = "FindFirstFileW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstFile([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, pointer unfoundType_LPWIN32_FIND_DATAW_lpFindFileData);
    [DllImport(lib, EntryPoint = "FindFirstFileW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstFile(char* lpFileName, pointer unfoundType_LPWIN32_FIND_DATAW_lpFindFileData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstFileW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, pointer unfoundType_LPWIN32_FIND_DATAW_lpFindFileData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstFileW(char* lpFileName, pointer unfoundType_LPWIN32_FIND_DATAW_lpFindFileData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstFileExA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, pointer unfoundType_FINDEX_INFO_LEVELS_fInfoLevelId, pointer lpFindFileData, pointer unfoundType_FINDEX_SEARCH_OPS_fSearchOp, pointer lpSearchFilter, int dwAdditionalFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstFileExA(byte* lpFileName, pointer unfoundType_FINDEX_INFO_LEVELS_fInfoLevelId, pointer lpFindFileData, pointer unfoundType_FINDEX_SEARCH_OPS_fSearchOp, pointer lpSearchFilter, int dwAdditionalFlags);
    [DllImport(lib, EntryPoint = "FindFirstFileExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstFileEx([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, pointer unfoundType_FINDEX_INFO_LEVELS_fInfoLevelId, pointer lpFindFileData, pointer unfoundType_FINDEX_SEARCH_OPS_fSearchOp, pointer lpSearchFilter, int dwAdditionalFlags);
    [DllImport(lib, EntryPoint = "FindFirstFileExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstFileEx(char* lpFileName, pointer unfoundType_FINDEX_INFO_LEVELS_fInfoLevelId, pointer lpFindFileData, pointer unfoundType_FINDEX_SEARCH_OPS_fSearchOp, pointer lpSearchFilter, int dwAdditionalFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstFileExW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, pointer unfoundType_FINDEX_INFO_LEVELS_fInfoLevelId, pointer lpFindFileData, pointer unfoundType_FINDEX_SEARCH_OPS_fSearchOp, pointer lpSearchFilter, int dwAdditionalFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstFileExW(char* lpFileName, pointer unfoundType_FINDEX_INFO_LEVELS_fInfoLevelId, pointer lpFindFileData, pointer unfoundType_FINDEX_SEARCH_OPS_fSearchOp, pointer lpSearchFilter, int dwAdditionalFlags);
    [DllImport(lib, EntryPoint = "FindFirstVolumeW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstVolume(string lpszVolumeName, int cchBufferLength);
    [DllImport(lib, EntryPoint = "FindFirstVolumeW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstVolume(char* lpszVolumeName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstVolumeW(string lpszVolumeName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstVolumeW(char* lpszVolumeName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextChangeNotification(pointer hChangeHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextFileA(pointer hFindFile, pointer unfoundType_LPWIN32_FIND_DATAA_lpFindFileData);
    [DllImport(lib, EntryPoint = "FindNextFileW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextFile(pointer hFindFile, pointer unfoundType_LPWIN32_FIND_DATAW_lpFindFileData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextFileW(pointer hFindFile, pointer unfoundType_LPWIN32_FIND_DATAW_lpFindFileData);
    [DllImport(lib, EntryPoint = "FindNextVolumeW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextVolume(pointer hFindVolume, string lpszVolumeName, int cchBufferLength);
    [DllImport(lib, EntryPoint = "FindNextVolumeW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextVolume(pointer hFindVolume, char* lpszVolumeName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextVolumeW(pointer hFindVolume, string lpszVolumeName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextVolumeW(pointer hFindVolume, char* lpszVolumeName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindVolumeClose(pointer hFindVolume);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FlushFileBuffers(pointer hFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetDiskFreeSpaceA([MarshalAs(UnmanagedType.LPStr)] string lpRootPathName, pointer unfoundType_LPDWORD_lpSectorsPerCluster, pointer unfoundType_LPDWORD_lpBytesPerSector, pointer unfoundType_LPDWORD_lpNumberOfFreeClusters, pointer unfoundType_LPDWORD_lpTotalNumberOfClusters);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetDiskFreeSpaceA(byte* lpRootPathName, pointer unfoundType_LPDWORD_lpSectorsPerCluster, pointer unfoundType_LPDWORD_lpBytesPerSector, pointer unfoundType_LPDWORD_lpNumberOfFreeClusters, pointer unfoundType_LPDWORD_lpTotalNumberOfClusters);
    [DllImport(lib, EntryPoint = "GetDiskFreeSpaceW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetDiskFreeSpace([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, pointer unfoundType_LPDWORD_lpSectorsPerCluster, pointer unfoundType_LPDWORD_lpBytesPerSector, pointer unfoundType_LPDWORD_lpNumberOfFreeClusters, pointer unfoundType_LPDWORD_lpTotalNumberOfClusters);
    [DllImport(lib, EntryPoint = "GetDiskFreeSpaceW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetDiskFreeSpace(char* lpRootPathName, pointer unfoundType_LPDWORD_lpSectorsPerCluster, pointer unfoundType_LPDWORD_lpBytesPerSector, pointer unfoundType_LPDWORD_lpNumberOfFreeClusters, pointer unfoundType_LPDWORD_lpTotalNumberOfClusters);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetDiskFreeSpaceW([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, pointer unfoundType_LPDWORD_lpSectorsPerCluster, pointer unfoundType_LPDWORD_lpBytesPerSector, pointer unfoundType_LPDWORD_lpNumberOfFreeClusters, pointer unfoundType_LPDWORD_lpTotalNumberOfClusters);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetDiskFreeSpaceW(char* lpRootPathName, pointer unfoundType_LPDWORD_lpSectorsPerCluster, pointer unfoundType_LPDWORD_lpBytesPerSector, pointer unfoundType_LPDWORD_lpNumberOfFreeClusters, pointer unfoundType_LPDWORD_lpTotalNumberOfClusters);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetDiskFreeSpaceExA([MarshalAs(UnmanagedType.LPStr)] string lpDirectoryName, pointer unfoundType_PULARGE_INTEGER_lpFreeBytesAvailableToCaller, pointer unfoundType_PULARGE_INTEGER_lpTotalNumberOfBytes, pointer unfoundType_PULARGE_INTEGER_lpTotalNumberOfFreeBytes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetDiskFreeSpaceExA(byte* lpDirectoryName, pointer unfoundType_PULARGE_INTEGER_lpFreeBytesAvailableToCaller, pointer unfoundType_PULARGE_INTEGER_lpTotalNumberOfBytes, pointer unfoundType_PULARGE_INTEGER_lpTotalNumberOfFreeBytes);
    [DllImport(lib, EntryPoint = "GetDiskFreeSpaceExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetDiskFreeSpaceEx([MarshalAs(UnmanagedType.LPWStr)] string lpDirectoryName, pointer unfoundType_PULARGE_INTEGER_lpFreeBytesAvailableToCaller, pointer unfoundType_PULARGE_INTEGER_lpTotalNumberOfBytes, pointer unfoundType_PULARGE_INTEGER_lpTotalNumberOfFreeBytes);
    [DllImport(lib, EntryPoint = "GetDiskFreeSpaceExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetDiskFreeSpaceEx(char* lpDirectoryName, pointer unfoundType_PULARGE_INTEGER_lpFreeBytesAvailableToCaller, pointer unfoundType_PULARGE_INTEGER_lpTotalNumberOfBytes, pointer unfoundType_PULARGE_INTEGER_lpTotalNumberOfFreeBytes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetDiskFreeSpaceExW([MarshalAs(UnmanagedType.LPWStr)] string lpDirectoryName, pointer unfoundType_PULARGE_INTEGER_lpFreeBytesAvailableToCaller, pointer unfoundType_PULARGE_INTEGER_lpTotalNumberOfBytes, pointer unfoundType_PULARGE_INTEGER_lpTotalNumberOfFreeBytes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetDiskFreeSpaceExW(char* lpDirectoryName, pointer unfoundType_PULARGE_INTEGER_lpFreeBytesAvailableToCaller, pointer unfoundType_PULARGE_INTEGER_lpTotalNumberOfBytes, pointer unfoundType_PULARGE_INTEGER_lpTotalNumberOfFreeBytes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetDiskSpaceInformationA([MarshalAs(UnmanagedType.LPStr)] string rootPath, pointer unfoundType_DISK_SPACE_INFORMATION_diskSpaceInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetDiskSpaceInformationA(byte* rootPath, pointer unfoundType_DISK_SPACE_INFORMATION_diskSpaceInfo);
    [DllImport(lib, EntryPoint = "GetDiskSpaceInformationW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetDiskSpaceInformation([MarshalAs(UnmanagedType.LPWStr)] string rootPath, pointer unfoundType_DISK_SPACE_INFORMATION_diskSpaceInfo);
    [DllImport(lib, EntryPoint = "GetDiskSpaceInformationW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetDiskSpaceInformation(char* rootPath, pointer unfoundType_DISK_SPACE_INFORMATION_diskSpaceInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetDiskSpaceInformationW([MarshalAs(UnmanagedType.LPWStr)] string rootPath, pointer unfoundType_DISK_SPACE_INFORMATION_diskSpaceInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetDiskSpaceInformationW(char* rootPath, pointer unfoundType_DISK_SPACE_INFORMATION_diskSpaceInfo);
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
        bool GetFileAttributesExA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, pointer unfoundType_GET_FILEEX_INFO_LEVELS_fInfoLevelId, pointer lpFileInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileAttributesExA(byte* lpFileName, pointer unfoundType_GET_FILEEX_INFO_LEVELS_fInfoLevelId, pointer lpFileInformation);
    [DllImport(lib, EntryPoint = "GetFileAttributesExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileAttributesEx([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, pointer unfoundType_GET_FILEEX_INFO_LEVELS_fInfoLevelId, pointer lpFileInformation);
    [DllImport(lib, EntryPoint = "GetFileAttributesExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileAttributesEx(char* lpFileName, pointer unfoundType_GET_FILEEX_INFO_LEVELS_fInfoLevelId, pointer lpFileInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileAttributesExW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, pointer unfoundType_GET_FILEEX_INFO_LEVELS_fInfoLevelId, pointer lpFileInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileAttributesExW(char* lpFileName, pointer unfoundType_GET_FILEEX_INFO_LEVELS_fInfoLevelId, pointer lpFileInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileInformationByHandle(pointer hFile, pointer unfoundType_LPBY_HANDLE_FILE_INFORMATION_lpFileInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFileSize(pointer hFile, pointer unfoundType_LPDWORD_lpFileSizeHigh);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileSizeEx(pointer hFile, pointer unfoundType_PLARGE_INTEGER_lpFileSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFileType(pointer hFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFinalPathNameByHandleA(pointer hFile, [MarshalAs(UnmanagedType.LPStr)] string lpszFilePath, int cchFilePath, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFinalPathNameByHandleA(pointer hFile, ReadOnlySpan<byte> lpszFilePath, int cchFilePath, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFinalPathNameByHandleA(pointer hFile, byte* lpszFilePath, int cchFilePath, int dwFlags);
    [DllImport(lib, EntryPoint = "GetFinalPathNameByHandleW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFinalPathNameByHandle(pointer hFile, string lpszFilePath, int cchFilePath, int dwFlags);
    [DllImport(lib, EntryPoint = "GetFinalPathNameByHandleW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFinalPathNameByHandle(pointer hFile, char* lpszFilePath, int cchFilePath, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFinalPathNameByHandleW(pointer hFile, string lpszFilePath, int cchFilePath, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFinalPathNameByHandleW(pointer hFile, char* lpszFilePath, int cchFilePath, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileTime(pointer hFile, pointer unfoundType_LPFILETIME_lpCreationTime, pointer unfoundType_LPFILETIME_lpLastAccessTime, pointer unfoundType_LPFILETIME_lpLastWriteTime);
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
        bool AreShortNamesEnabled(pointer Handle, pointer Enabled);
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
        bool GetVolumeInformationByHandle(pointer hFile, string lpVolumeNameBuffer, int nVolumeNameSize, pointer unfoundType_LPDWORD_lpVolumeSerialNumber, pointer unfoundType_LPDWORD_lpMaximumComponentLength, pointer unfoundType_LPDWORD_lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, EntryPoint = "GetVolumeInformationByHandleW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationByHandle(pointer hFile, string lpVolumeNameBuffer, int nVolumeNameSize, pointer unfoundType_LPDWORD_lpVolumeSerialNumber, pointer unfoundType_LPDWORD_lpMaximumComponentLength, pointer unfoundType_LPDWORD_lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, EntryPoint = "GetVolumeInformationByHandleW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationByHandle(pointer hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, pointer unfoundType_LPDWORD_lpVolumeSerialNumber, pointer unfoundType_LPDWORD_lpMaximumComponentLength, pointer unfoundType_LPDWORD_lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, EntryPoint = "GetVolumeInformationByHandleW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationByHandle(pointer hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, pointer unfoundType_LPDWORD_lpVolumeSerialNumber, pointer unfoundType_LPDWORD_lpMaximumComponentLength, pointer unfoundType_LPDWORD_lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationByHandleW(pointer hFile, string lpVolumeNameBuffer, int nVolumeNameSize, pointer unfoundType_LPDWORD_lpVolumeSerialNumber, pointer unfoundType_LPDWORD_lpMaximumComponentLength, pointer unfoundType_LPDWORD_lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationByHandleW(pointer hFile, string lpVolumeNameBuffer, int nVolumeNameSize, pointer unfoundType_LPDWORD_lpVolumeSerialNumber, pointer unfoundType_LPDWORD_lpMaximumComponentLength, pointer unfoundType_LPDWORD_lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationByHandleW(pointer hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, pointer unfoundType_LPDWORD_lpVolumeSerialNumber, pointer unfoundType_LPDWORD_lpMaximumComponentLength, pointer unfoundType_LPDWORD_lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationByHandleW(pointer hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, pointer unfoundType_LPDWORD_lpVolumeSerialNumber, pointer unfoundType_LPDWORD_lpMaximumComponentLength, pointer unfoundType_LPDWORD_lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, EntryPoint = "GetVolumeInformationW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformation([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, string lpVolumeNameBuffer, int nVolumeNameSize, pointer unfoundType_LPDWORD_lpVolumeSerialNumber, pointer unfoundType_LPDWORD_lpMaximumComponentLength, pointer unfoundType_LPDWORD_lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, EntryPoint = "GetVolumeInformationW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformation([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, string lpVolumeNameBuffer, int nVolumeNameSize, pointer unfoundType_LPDWORD_lpVolumeSerialNumber, pointer unfoundType_LPDWORD_lpMaximumComponentLength, pointer unfoundType_LPDWORD_lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, EntryPoint = "GetVolumeInformationW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformation([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, pointer unfoundType_LPDWORD_lpVolumeSerialNumber, pointer unfoundType_LPDWORD_lpMaximumComponentLength, pointer unfoundType_LPDWORD_lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, EntryPoint = "GetVolumeInformationW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformation([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, pointer unfoundType_LPDWORD_lpVolumeSerialNumber, pointer unfoundType_LPDWORD_lpMaximumComponentLength, pointer unfoundType_LPDWORD_lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, EntryPoint = "GetVolumeInformationW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformation(char* lpRootPathName, string lpVolumeNameBuffer, int nVolumeNameSize, pointer unfoundType_LPDWORD_lpVolumeSerialNumber, pointer unfoundType_LPDWORD_lpMaximumComponentLength, pointer unfoundType_LPDWORD_lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, EntryPoint = "GetVolumeInformationW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformation(char* lpRootPathName, string lpVolumeNameBuffer, int nVolumeNameSize, pointer unfoundType_LPDWORD_lpVolumeSerialNumber, pointer unfoundType_LPDWORD_lpMaximumComponentLength, pointer unfoundType_LPDWORD_lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, EntryPoint = "GetVolumeInformationW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformation(char* lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, pointer unfoundType_LPDWORD_lpVolumeSerialNumber, pointer unfoundType_LPDWORD_lpMaximumComponentLength, pointer unfoundType_LPDWORD_lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, EntryPoint = "GetVolumeInformationW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformation(char* lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, pointer unfoundType_LPDWORD_lpVolumeSerialNumber, pointer unfoundType_LPDWORD_lpMaximumComponentLength, pointer unfoundType_LPDWORD_lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationW([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, string lpVolumeNameBuffer, int nVolumeNameSize, pointer unfoundType_LPDWORD_lpVolumeSerialNumber, pointer unfoundType_LPDWORD_lpMaximumComponentLength, pointer unfoundType_LPDWORD_lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationW([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, string lpVolumeNameBuffer, int nVolumeNameSize, pointer unfoundType_LPDWORD_lpVolumeSerialNumber, pointer unfoundType_LPDWORD_lpMaximumComponentLength, pointer unfoundType_LPDWORD_lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationW([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, pointer unfoundType_LPDWORD_lpVolumeSerialNumber, pointer unfoundType_LPDWORD_lpMaximumComponentLength, pointer unfoundType_LPDWORD_lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationW([MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, pointer unfoundType_LPDWORD_lpVolumeSerialNumber, pointer unfoundType_LPDWORD_lpMaximumComponentLength, pointer unfoundType_LPDWORD_lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationW(char* lpRootPathName, string lpVolumeNameBuffer, int nVolumeNameSize, pointer unfoundType_LPDWORD_lpVolumeSerialNumber, pointer unfoundType_LPDWORD_lpMaximumComponentLength, pointer unfoundType_LPDWORD_lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationW(char* lpRootPathName, string lpVolumeNameBuffer, int nVolumeNameSize, pointer unfoundType_LPDWORD_lpVolumeSerialNumber, pointer unfoundType_LPDWORD_lpMaximumComponentLength, pointer unfoundType_LPDWORD_lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationW(char* lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, pointer unfoundType_LPDWORD_lpVolumeSerialNumber, pointer unfoundType_LPDWORD_lpMaximumComponentLength, pointer unfoundType_LPDWORD_lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationW(char* lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, pointer unfoundType_LPDWORD_lpVolumeSerialNumber, pointer unfoundType_LPDWORD_lpMaximumComponentLength, pointer unfoundType_LPDWORD_lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize);
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
        bool LocalFileTimeToFileTime(pointer unfoundType_FILETIME_lpLocalFileTime, pointer unfoundType_LPFILETIME_lpFileTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool LockFile(pointer hFile, int dwFileOffsetLow, int dwFileOffsetHigh, int nNumberOfBytesToLockLow, int nNumberOfBytesToLockHigh);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool LockFileEx(pointer hFile, int dwFlags, int dwReserved, int nNumberOfBytesToLockLow, int nNumberOfBytesToLockHigh, pointer unfoundType_LPOVERLAPPED_lpOverlapped);
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
        bool ReadFile(pointer hFile, pointer lpBuffer, int nNumberOfBytesToRead, pointer unfoundType_LPDWORD_lpNumberOfBytesRead, pointer unfoundType_LPOVERLAPPED_lpOverlapped);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadFileEx(pointer hFile, pointer lpBuffer, int nNumberOfBytesToRead, pointer unfoundType_LPOVERLAPPED_lpOverlapped, pointer unfoundType_LPOVERLAPPED_COMPLETION_ROUTINE_lpCompletionRoutine);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadFileScatter(pointer hFile, pointer unfoundType_FILE_SEGMENT_ELEMENT_aSegmentArray, int nNumberOfBytesToRead, pointer unfoundType_LPDWORD_lpReserved, pointer unfoundType_LPOVERLAPPED_lpOverlapped);
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
        bool SetEndOfFile(pointer hFile);
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
        bool SetFileInformationByHandle(pointer hFile, pointer unfoundType_FILE_INFO_BY_HANDLE_CLASS_FileInformationClass, pointer lpFileInformation, int dwBufferSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SetFilePointer(pointer hFile, int lDistanceToMove, pointer lpDistanceToMoveHigh, int dwMoveMethod);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFilePointerEx(pointer hFile, pointer unfoundType_LARGE_INTEGER_liDistanceToMove, pointer unfoundType_PLARGE_INTEGER_lpNewFilePointer, int dwMoveMethod);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFileTime(pointer hFile, pointer unfoundType_FILETIME_lpCreationTime, pointer unfoundType_FILETIME_lpLastAccessTime, pointer unfoundType_FILETIME_lpLastWriteTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFileValidData(pointer hFile, pointer unfoundType_LONGLONG_ValidDataLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UnlockFile(pointer hFile, int dwFileOffsetLow, int dwFileOffsetHigh, int nNumberOfBytesToUnlockLow, int nNumberOfBytesToUnlockHigh);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UnlockFileEx(pointer hFile, int dwReserved, int nNumberOfBytesToUnlockLow, int nNumberOfBytesToUnlockHigh, pointer unfoundType_LPOVERLAPPED_lpOverlapped);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteFile(pointer hFile, pointer lpBuffer, int nNumberOfBytesToWrite, pointer unfoundType_LPDWORD_lpNumberOfBytesWritten, pointer unfoundType_LPOVERLAPPED_lpOverlapped);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteFileEx(pointer hFile, pointer lpBuffer, int nNumberOfBytesToWrite, pointer unfoundType_LPOVERLAPPED_lpOverlapped, pointer unfoundType_LPOVERLAPPED_COMPLETION_ROUTINE_lpCompletionRoutine);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteFileGather(pointer hFile, pointer unfoundType_FILE_SEGMENT_ELEMENT_aSegmentArray, int nNumberOfBytesToWrite, pointer unfoundType_LPDWORD_lpReserved, pointer unfoundType_LPOVERLAPPED_lpOverlapped);
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
        bool GetVolumePathNamesForVolumeName([MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeName, string lpszVolumePathNames, int cchBufferLength, pointer unfoundType_PDWORD_lpcchReturnLength);
    [DllImport(lib, EntryPoint = "GetVolumePathNamesForVolumeNameW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumePathNamesForVolumeName([MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeName, char* lpszVolumePathNames, int cchBufferLength, pointer unfoundType_PDWORD_lpcchReturnLength);
    [DllImport(lib, EntryPoint = "GetVolumePathNamesForVolumeNameW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumePathNamesForVolumeName(char* lpszVolumeName, string lpszVolumePathNames, int cchBufferLength, pointer unfoundType_PDWORD_lpcchReturnLength);
    [DllImport(lib, EntryPoint = "GetVolumePathNamesForVolumeNameW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumePathNamesForVolumeName(char* lpszVolumeName, char* lpszVolumePathNames, int cchBufferLength, pointer unfoundType_PDWORD_lpcchReturnLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumePathNamesForVolumeNameW([MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeName, string lpszVolumePathNames, int cchBufferLength, pointer unfoundType_PDWORD_lpcchReturnLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumePathNamesForVolumeNameW([MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeName, char* lpszVolumePathNames, int cchBufferLength, pointer unfoundType_PDWORD_lpcchReturnLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumePathNamesForVolumeNameW(char* lpszVolumeName, string lpszVolumePathNames, int cchBufferLength, pointer unfoundType_PDWORD_lpcchReturnLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumePathNamesForVolumeNameW(char* lpszVolumeName, char* lpszVolumePathNames, int cchBufferLength, pointer unfoundType_PDWORD_lpcchReturnLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateFile2([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwDesiredAccess, int dwShareMode, int dwCreationDisposition, pointer unfoundType_LPCREATEFILE2_EXTENDED_PARAMETERS_pCreateExParams);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateFile2(char* lpFileName, int dwDesiredAccess, int dwShareMode, int dwCreationDisposition, pointer unfoundType_LPCREATEFILE2_EXTENDED_PARAMETERS_pCreateExParams);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFileIoOverlappedRange(pointer FileHandle, pointer unfoundType_PUCHAR_OverlappedRangeStart, uint Length);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCompressedFileSizeA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, pointer unfoundType_LPDWORD_lpFileSizeHigh);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCompressedFileSizeA(byte* lpFileName, pointer unfoundType_LPDWORD_lpFileSizeHigh);
    [DllImport(lib, EntryPoint = "GetCompressedFileSizeW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCompressedFileSize([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, pointer unfoundType_LPDWORD_lpFileSizeHigh);
    [DllImport(lib, EntryPoint = "GetCompressedFileSizeW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCompressedFileSize(char* lpFileName, pointer unfoundType_LPDWORD_lpFileSizeHigh);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCompressedFileSizeW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, pointer unfoundType_LPDWORD_lpFileSizeHigh);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCompressedFileSizeW(char* lpFileName, pointer unfoundType_LPDWORD_lpFileSizeHigh);
    [DllImport(lib, EntryPoint = "FindFirstStreamW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstStream([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, pointer unfoundType_STREAM_INFO_LEVELS_InfoLevel, pointer lpFindStreamData, int dwFlags);
    [DllImport(lib, EntryPoint = "FindFirstStreamW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstStream(char* lpFileName, pointer unfoundType_STREAM_INFO_LEVELS_InfoLevel, pointer lpFindStreamData, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstStreamW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, pointer unfoundType_STREAM_INFO_LEVELS_InfoLevel, pointer lpFindStreamData, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstStreamW(char* lpFileName, pointer unfoundType_STREAM_INFO_LEVELS_InfoLevel, pointer lpFindStreamData, int dwFlags);
    [DllImport(lib, EntryPoint = "FindNextStreamW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextStream(pointer hFindStream, pointer lpFindStreamData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextStreamW(pointer hFindStream, pointer lpFindStreamData);
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
        pointer FindFirstFileName([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwFlags, pointer unfoundType_LPDWORD_StringLength, [MarshalAs(UnmanagedType.LPWStr)] string LinkName);
    [DllImport(lib, EntryPoint = "FindFirstFileNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstFileName([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwFlags, pointer unfoundType_LPDWORD_StringLength, char* LinkName);
    [DllImport(lib, EntryPoint = "FindFirstFileNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstFileName(char* lpFileName, int dwFlags, pointer unfoundType_LPDWORD_StringLength, [MarshalAs(UnmanagedType.LPWStr)] string LinkName);
    [DllImport(lib, EntryPoint = "FindFirstFileNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstFileName(char* lpFileName, int dwFlags, pointer unfoundType_LPDWORD_StringLength, char* LinkName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstFileNameW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwFlags, pointer unfoundType_LPDWORD_StringLength, [MarshalAs(UnmanagedType.LPWStr)] string LinkName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstFileNameW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwFlags, pointer unfoundType_LPDWORD_StringLength, char* LinkName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstFileNameW(char* lpFileName, int dwFlags, pointer unfoundType_LPDWORD_StringLength, [MarshalAs(UnmanagedType.LPWStr)] string LinkName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstFileNameW(char* lpFileName, int dwFlags, pointer unfoundType_LPDWORD_StringLength, char* LinkName);
    [DllImport(lib, EntryPoint = "FindNextFileNameW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextFileName(pointer hFindStream, pointer unfoundType_LPDWORD_StringLength, [MarshalAs(UnmanagedType.LPWStr)] string LinkName);
    [DllImport(lib, EntryPoint = "FindNextFileNameW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextFileName(pointer hFindStream, pointer unfoundType_LPDWORD_StringLength, char* LinkName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextFileNameW(pointer hFindStream, pointer unfoundType_LPDWORD_StringLength, [MarshalAs(UnmanagedType.LPWStr)] string LinkName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextFileNameW(pointer hFindStream, pointer unfoundType_LPDWORD_StringLength, char* LinkName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationA([MarshalAs(UnmanagedType.LPStr)] string lpRootPathName, [MarshalAs(UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, pointer unfoundType_LPDWORD_lpVolumeSerialNumber, pointer unfoundType_LPDWORD_lpMaximumComponentLength, pointer unfoundType_LPDWORD_lpFileSystemFlags, [MarshalAs(UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationA([MarshalAs(UnmanagedType.LPStr)] string lpRootPathName, [MarshalAs(UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, pointer unfoundType_LPDWORD_lpVolumeSerialNumber, pointer unfoundType_LPDWORD_lpMaximumComponentLength, pointer unfoundType_LPDWORD_lpFileSystemFlags, ReadOnlySpan<byte> lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationA([MarshalAs(UnmanagedType.LPStr)] string lpRootPathName, [MarshalAs(UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, pointer unfoundType_LPDWORD_lpVolumeSerialNumber, pointer unfoundType_LPDWORD_lpMaximumComponentLength, pointer unfoundType_LPDWORD_lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationA([MarshalAs(UnmanagedType.LPStr)] string lpRootPathName, ReadOnlySpan<byte> lpVolumeNameBuffer, int nVolumeNameSize, pointer unfoundType_LPDWORD_lpVolumeSerialNumber, pointer unfoundType_LPDWORD_lpMaximumComponentLength, pointer unfoundType_LPDWORD_lpFileSystemFlags, [MarshalAs(UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationA([MarshalAs(UnmanagedType.LPStr)] string lpRootPathName, ReadOnlySpan<byte> lpVolumeNameBuffer, int nVolumeNameSize, pointer unfoundType_LPDWORD_lpVolumeSerialNumber, pointer unfoundType_LPDWORD_lpMaximumComponentLength, pointer unfoundType_LPDWORD_lpFileSystemFlags, ReadOnlySpan<byte> lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationA([MarshalAs(UnmanagedType.LPStr)] string lpRootPathName, ReadOnlySpan<byte> lpVolumeNameBuffer, int nVolumeNameSize, pointer unfoundType_LPDWORD_lpVolumeSerialNumber, pointer unfoundType_LPDWORD_lpMaximumComponentLength, pointer unfoundType_LPDWORD_lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationA([MarshalAs(UnmanagedType.LPStr)] string lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, pointer unfoundType_LPDWORD_lpVolumeSerialNumber, pointer unfoundType_LPDWORD_lpMaximumComponentLength, pointer unfoundType_LPDWORD_lpFileSystemFlags, [MarshalAs(UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationA([MarshalAs(UnmanagedType.LPStr)] string lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, pointer unfoundType_LPDWORD_lpVolumeSerialNumber, pointer unfoundType_LPDWORD_lpMaximumComponentLength, pointer unfoundType_LPDWORD_lpFileSystemFlags, ReadOnlySpan<byte> lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationA([MarshalAs(UnmanagedType.LPStr)] string lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, pointer unfoundType_LPDWORD_lpVolumeSerialNumber, pointer unfoundType_LPDWORD_lpMaximumComponentLength, pointer unfoundType_LPDWORD_lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationA(byte* lpRootPathName, [MarshalAs(UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, pointer unfoundType_LPDWORD_lpVolumeSerialNumber, pointer unfoundType_LPDWORD_lpMaximumComponentLength, pointer unfoundType_LPDWORD_lpFileSystemFlags, [MarshalAs(UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationA(byte* lpRootPathName, [MarshalAs(UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, pointer unfoundType_LPDWORD_lpVolumeSerialNumber, pointer unfoundType_LPDWORD_lpMaximumComponentLength, pointer unfoundType_LPDWORD_lpFileSystemFlags, ReadOnlySpan<byte> lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationA(byte* lpRootPathName, [MarshalAs(UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, pointer unfoundType_LPDWORD_lpVolumeSerialNumber, pointer unfoundType_LPDWORD_lpMaximumComponentLength, pointer unfoundType_LPDWORD_lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationA(byte* lpRootPathName, ReadOnlySpan<byte> lpVolumeNameBuffer, int nVolumeNameSize, pointer unfoundType_LPDWORD_lpVolumeSerialNumber, pointer unfoundType_LPDWORD_lpMaximumComponentLength, pointer unfoundType_LPDWORD_lpFileSystemFlags, [MarshalAs(UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationA(byte* lpRootPathName, ReadOnlySpan<byte> lpVolumeNameBuffer, int nVolumeNameSize, pointer unfoundType_LPDWORD_lpVolumeSerialNumber, pointer unfoundType_LPDWORD_lpMaximumComponentLength, pointer unfoundType_LPDWORD_lpFileSystemFlags, ReadOnlySpan<byte> lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationA(byte* lpRootPathName, ReadOnlySpan<byte> lpVolumeNameBuffer, int nVolumeNameSize, pointer unfoundType_LPDWORD_lpVolumeSerialNumber, pointer unfoundType_LPDWORD_lpMaximumComponentLength, pointer unfoundType_LPDWORD_lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationA(byte* lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, pointer unfoundType_LPDWORD_lpVolumeSerialNumber, pointer unfoundType_LPDWORD_lpMaximumComponentLength, pointer unfoundType_LPDWORD_lpFileSystemFlags, [MarshalAs(UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationA(byte* lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, pointer unfoundType_LPDWORD_lpVolumeSerialNumber, pointer unfoundType_LPDWORD_lpMaximumComponentLength, pointer unfoundType_LPDWORD_lpFileSystemFlags, ReadOnlySpan<byte> lpFileSystemNameBuffer, int nFileSystemNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumeInformationA(byte* lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, pointer unfoundType_LPDWORD_lpVolumeSerialNumber, pointer unfoundType_LPDWORD_lpMaximumComponentLength, pointer unfoundType_LPDWORD_lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize);
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
        int LZOpenFileA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, pointer unfoundType_LPOFSTRUCT_lpReOpenBuf, short wStyle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LZOpenFileA(ReadOnlySpan<byte> lpFileName, pointer unfoundType_LPOFSTRUCT_lpReOpenBuf, short wStyle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LZOpenFileA(byte* lpFileName, pointer unfoundType_LPOFSTRUCT_lpReOpenBuf, short wStyle);
    [DllImport(lib, EntryPoint = "LZOpenFileW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int LZOpenFile(string lpFileName, pointer unfoundType_LPOFSTRUCT_lpReOpenBuf, short wStyle);
    [DllImport(lib, EntryPoint = "LZOpenFileW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int LZOpenFile(char* lpFileName, pointer unfoundType_LPOFSTRUCT_lpReOpenBuf, short wStyle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LZOpenFileW(string lpFileName, pointer unfoundType_LPOFSTRUCT_lpReOpenBuf, short wStyle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LZOpenFileW(char* lpFileName, pointer unfoundType_LPOFSTRUCT_lpReOpenBuf, short wStyle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LZSeek(int hFile, int lOffset, int iOrigin);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LZRead(int hFile, pointer lpBuffer, int cbRead);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void LZClose(int hFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrentPackageId(pointer bufferLength, pointer buffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrentPackageFullName(pointer packageFullNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageFullName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrentPackageFullName(pointer packageFullNameLength, char* packageFullName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrentPackageFamilyName(pointer packageFamilyNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrentPackageFamilyName(pointer packageFamilyNameLength, char* packageFamilyName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrentPackagePath(pointer pathLength, [MarshalAs(UnmanagedType.LPWStr)] string path);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrentPackagePath(pointer pathLength, char* path);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPackageId(pointer hProcess, pointer bufferLength, pointer buffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPackageFullName(pointer hProcess, pointer packageFullNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageFullName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPackageFullName(pointer hProcess, pointer packageFullNameLength, char* packageFullName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPackageFamilyName(pointer hProcess, pointer packageFamilyNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPackageFamilyName(pointer hProcess, pointer packageFamilyNameLength, char* packageFamilyName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPackagePath(pointer unfoundType_PACKAGE_ID_packageId, uint reserved, pointer pathLength, [MarshalAs(UnmanagedType.LPWStr)] string path);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPackagePath(pointer unfoundType_PACKAGE_ID_packageId, uint reserved, pointer pathLength, char* path);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPackagePathByFullName([MarshalAs(UnmanagedType.LPWStr)] string packageFullName, pointer pathLength, [MarshalAs(UnmanagedType.LPWStr)] string path);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPackagePathByFullName([MarshalAs(UnmanagedType.LPWStr)] string packageFullName, pointer pathLength, char* path);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPackagePathByFullName(char* packageFullName, pointer pathLength, [MarshalAs(UnmanagedType.LPWStr)] string path);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPackagePathByFullName(char* packageFullName, pointer pathLength, char* path);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetStagedPackagePathByFullName([MarshalAs(UnmanagedType.LPWStr)] string packageFullName, pointer pathLength, [MarshalAs(UnmanagedType.LPWStr)] string path);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetStagedPackagePathByFullName([MarshalAs(UnmanagedType.LPWStr)] string packageFullName, pointer pathLength, char* path);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetStagedPackagePathByFullName(char* packageFullName, pointer pathLength, [MarshalAs(UnmanagedType.LPWStr)] string path);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetStagedPackagePathByFullName(char* packageFullName, pointer pathLength, char* path);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrentApplicationUserModelId(pointer applicationUserModelIdLength, [MarshalAs(UnmanagedType.LPWStr)] string applicationUserModelId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrentApplicationUserModelId(pointer applicationUserModelIdLength, char* applicationUserModelId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetApplicationUserModelId(pointer hProcess, pointer applicationUserModelIdLength, [MarshalAs(UnmanagedType.LPWStr)] string applicationUserModelId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetApplicationUserModelId(pointer hProcess, pointer applicationUserModelIdLength, char* applicationUserModelId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PackageIdFromFullName([MarshalAs(UnmanagedType.LPWStr)] string packageFullName, uint flags, pointer bufferLength, pointer buffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PackageIdFromFullName(char* packageFullName, uint flags, pointer bufferLength, pointer buffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PackageFullNameFromId(pointer unfoundType_PACKAGE_ID_packageId, pointer packageFullNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageFullName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PackageFullNameFromId(pointer unfoundType_PACKAGE_ID_packageId, pointer packageFullNameLength, char* packageFullName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PackageFamilyNameFromId(pointer unfoundType_PACKAGE_ID_packageId, pointer packageFamilyNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PackageFamilyNameFromId(pointer unfoundType_PACKAGE_ID_packageId, pointer packageFamilyNameLength, char* packageFamilyName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PackageFamilyNameFromFullName([MarshalAs(UnmanagedType.LPWStr)] string packageFullName, pointer packageFamilyNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PackageFamilyNameFromFullName([MarshalAs(UnmanagedType.LPWStr)] string packageFullName, pointer packageFamilyNameLength, char* packageFamilyName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PackageFamilyNameFromFullName(char* packageFullName, pointer packageFamilyNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PackageFamilyNameFromFullName(char* packageFullName, pointer packageFamilyNameLength, char* packageFamilyName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PackageNameAndPublisherIdFromFamilyName([MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, pointer packageNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageName, pointer packagePublisherIdLength, [MarshalAs(UnmanagedType.LPWStr)] string packagePublisherId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PackageNameAndPublisherIdFromFamilyName([MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, pointer packageNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageName, pointer packagePublisherIdLength, char* packagePublisherId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PackageNameAndPublisherIdFromFamilyName([MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, pointer packageNameLength, char* packageName, pointer packagePublisherIdLength, [MarshalAs(UnmanagedType.LPWStr)] string packagePublisherId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PackageNameAndPublisherIdFromFamilyName([MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, pointer packageNameLength, char* packageName, pointer packagePublisherIdLength, char* packagePublisherId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PackageNameAndPublisherIdFromFamilyName(char* packageFamilyName, pointer packageNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageName, pointer packagePublisherIdLength, [MarshalAs(UnmanagedType.LPWStr)] string packagePublisherId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PackageNameAndPublisherIdFromFamilyName(char* packageFamilyName, pointer packageNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageName, pointer packagePublisherIdLength, char* packagePublisherId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PackageNameAndPublisherIdFromFamilyName(char* packageFamilyName, pointer packageNameLength, char* packageName, pointer packagePublisherIdLength, [MarshalAs(UnmanagedType.LPWStr)] string packagePublisherId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PackageNameAndPublisherIdFromFamilyName(char* packageFamilyName, pointer packageNameLength, char* packageName, pointer packagePublisherIdLength, char* packagePublisherId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FormatApplicationUserModelId([MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, [MarshalAs(UnmanagedType.LPWStr)] string packageRelativeApplicationId, pointer applicationUserModelIdLength, [MarshalAs(UnmanagedType.LPWStr)] string applicationUserModelId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FormatApplicationUserModelId([MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, [MarshalAs(UnmanagedType.LPWStr)] string packageRelativeApplicationId, pointer applicationUserModelIdLength, char* applicationUserModelId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FormatApplicationUserModelId([MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, char* packageRelativeApplicationId, pointer applicationUserModelIdLength, [MarshalAs(UnmanagedType.LPWStr)] string applicationUserModelId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FormatApplicationUserModelId([MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, char* packageRelativeApplicationId, pointer applicationUserModelIdLength, char* applicationUserModelId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FormatApplicationUserModelId(char* packageFamilyName, [MarshalAs(UnmanagedType.LPWStr)] string packageRelativeApplicationId, pointer applicationUserModelIdLength, [MarshalAs(UnmanagedType.LPWStr)] string applicationUserModelId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FormatApplicationUserModelId(char* packageFamilyName, [MarshalAs(UnmanagedType.LPWStr)] string packageRelativeApplicationId, pointer applicationUserModelIdLength, char* applicationUserModelId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FormatApplicationUserModelId(char* packageFamilyName, char* packageRelativeApplicationId, pointer applicationUserModelIdLength, [MarshalAs(UnmanagedType.LPWStr)] string applicationUserModelId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FormatApplicationUserModelId(char* packageFamilyName, char* packageRelativeApplicationId, pointer applicationUserModelIdLength, char* applicationUserModelId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ParseApplicationUserModelId([MarshalAs(UnmanagedType.LPWStr)] string applicationUserModelId, pointer packageFamilyNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, pointer packageRelativeApplicationIdLength, [MarshalAs(UnmanagedType.LPWStr)] string packageRelativeApplicationId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ParseApplicationUserModelId([MarshalAs(UnmanagedType.LPWStr)] string applicationUserModelId, pointer packageFamilyNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, pointer packageRelativeApplicationIdLength, char* packageRelativeApplicationId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ParseApplicationUserModelId([MarshalAs(UnmanagedType.LPWStr)] string applicationUserModelId, pointer packageFamilyNameLength, char* packageFamilyName, pointer packageRelativeApplicationIdLength, [MarshalAs(UnmanagedType.LPWStr)] string packageRelativeApplicationId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ParseApplicationUserModelId([MarshalAs(UnmanagedType.LPWStr)] string applicationUserModelId, pointer packageFamilyNameLength, char* packageFamilyName, pointer packageRelativeApplicationIdLength, char* packageRelativeApplicationId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ParseApplicationUserModelId(char* applicationUserModelId, pointer packageFamilyNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, pointer packageRelativeApplicationIdLength, [MarshalAs(UnmanagedType.LPWStr)] string packageRelativeApplicationId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ParseApplicationUserModelId(char* applicationUserModelId, pointer packageFamilyNameLength, [MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, pointer packageRelativeApplicationIdLength, char* packageRelativeApplicationId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ParseApplicationUserModelId(char* applicationUserModelId, pointer packageFamilyNameLength, char* packageFamilyName, pointer packageRelativeApplicationIdLength, [MarshalAs(UnmanagedType.LPWStr)] string packageRelativeApplicationId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ParseApplicationUserModelId(char* applicationUserModelId, pointer packageFamilyNameLength, char* packageFamilyName, pointer packageRelativeApplicationIdLength, char* packageRelativeApplicationId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPackagesByPackageFamily([MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, pointer count, [MarshalAs(UnmanagedType.LPWStr)] string packageFullNames, pointer bufferLength, pointer buffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPackagesByPackageFamily([MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, pointer count, char** packageFullNames, pointer bufferLength, pointer buffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPackagesByPackageFamily(char* packageFamilyName, pointer count, [MarshalAs(UnmanagedType.LPWStr)] string packageFullNames, pointer bufferLength, pointer buffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPackagesByPackageFamily(char* packageFamilyName, pointer count, char** packageFullNames, pointer bufferLength, pointer buffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FindPackagesByPackageFamily([MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, uint packageFilters, pointer count, [MarshalAs(UnmanagedType.LPWStr)] string packageFullNames, pointer bufferLength, pointer buffer, pointer packageProperties);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FindPackagesByPackageFamily([MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, uint packageFilters, pointer count, char** packageFullNames, pointer bufferLength, pointer buffer, pointer packageProperties);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FindPackagesByPackageFamily(char* packageFamilyName, uint packageFilters, pointer count, [MarshalAs(UnmanagedType.LPWStr)] string packageFullNames, pointer bufferLength, pointer buffer, pointer packageProperties);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FindPackagesByPackageFamily(char* packageFamilyName, uint packageFilters, pointer count, char** packageFullNames, pointer bufferLength, pointer buffer, pointer packageProperties);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrentPackageInfo(uint flags, pointer bufferLength, pointer buffer, pointer count);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int OpenPackageInfoByFullName([MarshalAs(UnmanagedType.LPWStr)] string packageFullName, uint reserved, pointer unfoundType_PACKAGE_INFO_REFERENCE_packageInfoReference);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int OpenPackageInfoByFullName(char* packageFullName, uint reserved, pointer unfoundType_PACKAGE_INFO_REFERENCE_packageInfoReference);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ClosePackageInfo(pointer unfoundType_PACKAGE_INFO_REFERENCE_packageInfoReference);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPackageInfo(pointer unfoundType_PACKAGE_INFO_REFERENCE_packageInfoReference, uint flags, pointer bufferLength, pointer buffer, pointer count);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPackageApplicationIds(pointer unfoundType_PACKAGE_INFO_REFERENCE_packageInfoReference, pointer bufferLength, pointer buffer, pointer count);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int AppPolicyGetLifecycleManagement(pointer processToken, pointer unfoundType_AppPolicyLifecycleManagement_policy);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int AppPolicyGetWindowingModel(pointer processToken, pointer unfoundType_AppPolicyWindowingModel_policy);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int AppPolicyGetMediaFoundationCodecLoading(pointer processToken, pointer unfoundType_AppPolicyMediaFoundationCodecLoading_policy);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int AppPolicyGetClrCompat(pointer processToken, pointer unfoundType_AppPolicyClrCompat_policy);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int AppPolicyGetThreadInitializationType(pointer processToken, pointer unfoundType_AppPolicyThreadInitializationType_policy);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int AppPolicyGetShowDeveloperDiagnostic(pointer processToken, pointer unfoundType_AppPolicyShowDeveloperDiagnostic_policy);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int AppPolicyGetProcessTerminationMethod(pointer processToken, pointer unfoundType_AppPolicyProcessTerminationMethod_policy);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int AppPolicyGetCreateFileAccess(pointer processToken, pointer unfoundType_AppPolicyCreateFileAccess_policy);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ClearCommBreak(pointer hFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ClearCommError(pointer hFile, pointer unfoundType_LPDWORD_lpErrors, pointer unfoundType_LPCOMSTAT_lpStat);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetupComm(pointer hFile, int dwInQueue, int dwOutQueue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EscapeCommFunction(pointer hFile, int dwFunc);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetCommConfig(pointer hCommDev, pointer unfoundType_LPCOMMCONFIG_lpCC, pointer unfoundType_LPDWORD_lpdwSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetCommMask(pointer hFile, pointer unfoundType_LPDWORD_lpEvtMask);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetCommModemStatus(pointer hFile, pointer unfoundType_LPDWORD_lpModemStat);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetCommProperties(pointer hFile, pointer unfoundType_LPCOMMPROP_lpCommProp);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetCommState(pointer hFile, pointer unfoundType_LPDCB_lpDCB);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetCommTimeouts(pointer hFile, pointer unfoundType_LPCOMMTIMEOUTS_lpCommTimeouts);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool PurgeComm(pointer hFile, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetCommBreak(pointer hFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetCommConfig(pointer hCommDev, pointer unfoundType_LPCOMMCONFIG_lpCC, int dwSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetCommMask(pointer hFile, int dwEvtMask);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetCommState(pointer hFile, pointer unfoundType_LPDCB_lpDCB);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetCommTimeouts(pointer hFile, pointer unfoundType_LPCOMMTIMEOUTS_lpCommTimeouts);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool TransmitCommChar(pointer hFile, byte cChar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WaitCommEvent(pointer hFile, pointer unfoundType_LPDWORD_lpEvtMask, pointer unfoundType_LPOVERLAPPED_lpOverlapped);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatA(pointer unfoundType_LCID_Locale, int dwFlags, pointer unfoundType_SYSTEMTIME_lpDate, [MarshalAs(UnmanagedType.LPStr)] string lpFormat, [MarshalAs(UnmanagedType.LPStr)] string lpDateStr, int cchDate);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatA(pointer unfoundType_LCID_Locale, int dwFlags, pointer unfoundType_SYSTEMTIME_lpDate, [MarshalAs(UnmanagedType.LPStr)] string lpFormat, ReadOnlySpan<byte> lpDateStr, int cchDate);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatA(pointer unfoundType_LCID_Locale, int dwFlags, pointer unfoundType_SYSTEMTIME_lpDate, [MarshalAs(UnmanagedType.LPStr)] string lpFormat, byte* lpDateStr, int cchDate);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatA(pointer unfoundType_LCID_Locale, int dwFlags, pointer unfoundType_SYSTEMTIME_lpDate, byte* lpFormat, [MarshalAs(UnmanagedType.LPStr)] string lpDateStr, int cchDate);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatA(pointer unfoundType_LCID_Locale, int dwFlags, pointer unfoundType_SYSTEMTIME_lpDate, byte* lpFormat, ReadOnlySpan<byte> lpDateStr, int cchDate);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatA(pointer unfoundType_LCID_Locale, int dwFlags, pointer unfoundType_SYSTEMTIME_lpDate, byte* lpFormat, byte* lpDateStr, int cchDate);
    [DllImport(lib, EntryPoint = "GetDateFormatW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormat(pointer unfoundType_LCID_Locale, int dwFlags, pointer unfoundType_SYSTEMTIME_lpDate, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, string lpDateStr, int cchDate);
    [DllImport(lib, EntryPoint = "GetDateFormatW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormat(pointer unfoundType_LCID_Locale, int dwFlags, pointer unfoundType_SYSTEMTIME_lpDate, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, char* lpDateStr, int cchDate);
    [DllImport(lib, EntryPoint = "GetDateFormatW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormat(pointer unfoundType_LCID_Locale, int dwFlags, pointer unfoundType_SYSTEMTIME_lpDate, char* lpFormat, string lpDateStr, int cchDate);
    [DllImport(lib, EntryPoint = "GetDateFormatW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormat(pointer unfoundType_LCID_Locale, int dwFlags, pointer unfoundType_SYSTEMTIME_lpDate, char* lpFormat, char* lpDateStr, int cchDate);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatW(pointer unfoundType_LCID_Locale, int dwFlags, pointer unfoundType_SYSTEMTIME_lpDate, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, string lpDateStr, int cchDate);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatW(pointer unfoundType_LCID_Locale, int dwFlags, pointer unfoundType_SYSTEMTIME_lpDate, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, char* lpDateStr, int cchDate);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatW(pointer unfoundType_LCID_Locale, int dwFlags, pointer unfoundType_SYSTEMTIME_lpDate, char* lpFormat, string lpDateStr, int cchDate);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatW(pointer unfoundType_LCID_Locale, int dwFlags, pointer unfoundType_SYSTEMTIME_lpDate, char* lpFormat, char* lpDateStr, int cchDate);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormatA(pointer unfoundType_LCID_Locale, int dwFlags, pointer unfoundType_SYSTEMTIME_lpTime, [MarshalAs(UnmanagedType.LPStr)] string lpFormat, [MarshalAs(UnmanagedType.LPStr)] string lpTimeStr, int cchTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormatA(pointer unfoundType_LCID_Locale, int dwFlags, pointer unfoundType_SYSTEMTIME_lpTime, [MarshalAs(UnmanagedType.LPStr)] string lpFormat, ReadOnlySpan<byte> lpTimeStr, int cchTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormatA(pointer unfoundType_LCID_Locale, int dwFlags, pointer unfoundType_SYSTEMTIME_lpTime, [MarshalAs(UnmanagedType.LPStr)] string lpFormat, byte* lpTimeStr, int cchTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormatA(pointer unfoundType_LCID_Locale, int dwFlags, pointer unfoundType_SYSTEMTIME_lpTime, byte* lpFormat, [MarshalAs(UnmanagedType.LPStr)] string lpTimeStr, int cchTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormatA(pointer unfoundType_LCID_Locale, int dwFlags, pointer unfoundType_SYSTEMTIME_lpTime, byte* lpFormat, ReadOnlySpan<byte> lpTimeStr, int cchTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormatA(pointer unfoundType_LCID_Locale, int dwFlags, pointer unfoundType_SYSTEMTIME_lpTime, byte* lpFormat, byte* lpTimeStr, int cchTime);
    [DllImport(lib, EntryPoint = "GetTimeFormatW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormat(pointer unfoundType_LCID_Locale, int dwFlags, pointer unfoundType_SYSTEMTIME_lpTime, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, string lpTimeStr, int cchTime);
    [DllImport(lib, EntryPoint = "GetTimeFormatW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormat(pointer unfoundType_LCID_Locale, int dwFlags, pointer unfoundType_SYSTEMTIME_lpTime, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, char* lpTimeStr, int cchTime);
    [DllImport(lib, EntryPoint = "GetTimeFormatW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormat(pointer unfoundType_LCID_Locale, int dwFlags, pointer unfoundType_SYSTEMTIME_lpTime, char* lpFormat, string lpTimeStr, int cchTime);
    [DllImport(lib, EntryPoint = "GetTimeFormatW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormat(pointer unfoundType_LCID_Locale, int dwFlags, pointer unfoundType_SYSTEMTIME_lpTime, char* lpFormat, char* lpTimeStr, int cchTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormatW(pointer unfoundType_LCID_Locale, int dwFlags, pointer unfoundType_SYSTEMTIME_lpTime, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, string lpTimeStr, int cchTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormatW(pointer unfoundType_LCID_Locale, int dwFlags, pointer unfoundType_SYSTEMTIME_lpTime, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, char* lpTimeStr, int cchTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormatW(pointer unfoundType_LCID_Locale, int dwFlags, pointer unfoundType_SYSTEMTIME_lpTime, char* lpFormat, string lpTimeStr, int cchTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormatW(pointer unfoundType_LCID_Locale, int dwFlags, pointer unfoundType_SYSTEMTIME_lpTime, char* lpFormat, char* lpTimeStr, int cchTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, pointer unfoundType_SYSTEMTIME_lpTime, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, string lpTimeStr, int cchTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, pointer unfoundType_SYSTEMTIME_lpTime, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, char* lpTimeStr, int cchTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, pointer unfoundType_SYSTEMTIME_lpTime, char* lpFormat, string lpTimeStr, int cchTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, pointer unfoundType_SYSTEMTIME_lpTime, char* lpFormat, char* lpTimeStr, int cchTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormatEx(char* lpLocaleName, int dwFlags, pointer unfoundType_SYSTEMTIME_lpTime, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, string lpTimeStr, int cchTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormatEx(char* lpLocaleName, int dwFlags, pointer unfoundType_SYSTEMTIME_lpTime, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, char* lpTimeStr, int cchTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormatEx(char* lpLocaleName, int dwFlags, pointer unfoundType_SYSTEMTIME_lpTime, char* lpFormat, string lpTimeStr, int cchTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeFormatEx(char* lpLocaleName, int dwFlags, pointer unfoundType_SYSTEMTIME_lpTime, char* lpFormat, char* lpTimeStr, int cchTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, pointer unfoundType_SYSTEMTIME_lpDate, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, string lpDateStr, int cchDate, [MarshalAs(UnmanagedType.LPWStr)] string lpCalendar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, pointer unfoundType_SYSTEMTIME_lpDate, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, string lpDateStr, int cchDate, char* lpCalendar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, pointer unfoundType_SYSTEMTIME_lpDate, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, char* lpDateStr, int cchDate, [MarshalAs(UnmanagedType.LPWStr)] string lpCalendar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, pointer unfoundType_SYSTEMTIME_lpDate, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, char* lpDateStr, int cchDate, char* lpCalendar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, pointer unfoundType_SYSTEMTIME_lpDate, char* lpFormat, string lpDateStr, int cchDate, [MarshalAs(UnmanagedType.LPWStr)] string lpCalendar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, pointer unfoundType_SYSTEMTIME_lpDate, char* lpFormat, string lpDateStr, int cchDate, char* lpCalendar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, pointer unfoundType_SYSTEMTIME_lpDate, char* lpFormat, char* lpDateStr, int cchDate, [MarshalAs(UnmanagedType.LPWStr)] string lpCalendar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, pointer unfoundType_SYSTEMTIME_lpDate, char* lpFormat, char* lpDateStr, int cchDate, char* lpCalendar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatEx(char* lpLocaleName, int dwFlags, pointer unfoundType_SYSTEMTIME_lpDate, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, string lpDateStr, int cchDate, [MarshalAs(UnmanagedType.LPWStr)] string lpCalendar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatEx(char* lpLocaleName, int dwFlags, pointer unfoundType_SYSTEMTIME_lpDate, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, string lpDateStr, int cchDate, char* lpCalendar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatEx(char* lpLocaleName, int dwFlags, pointer unfoundType_SYSTEMTIME_lpDate, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, char* lpDateStr, int cchDate, [MarshalAs(UnmanagedType.LPWStr)] string lpCalendar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatEx(char* lpLocaleName, int dwFlags, pointer unfoundType_SYSTEMTIME_lpDate, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, char* lpDateStr, int cchDate, char* lpCalendar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatEx(char* lpLocaleName, int dwFlags, pointer unfoundType_SYSTEMTIME_lpDate, char* lpFormat, string lpDateStr, int cchDate, [MarshalAs(UnmanagedType.LPWStr)] string lpCalendar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatEx(char* lpLocaleName, int dwFlags, pointer unfoundType_SYSTEMTIME_lpDate, char* lpFormat, string lpDateStr, int cchDate, char* lpCalendar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatEx(char* lpLocaleName, int dwFlags, pointer unfoundType_SYSTEMTIME_lpDate, char* lpFormat, char* lpDateStr, int cchDate, [MarshalAs(UnmanagedType.LPWStr)] string lpCalendar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDateFormatEx(char* lpLocaleName, int dwFlags, pointer unfoundType_SYSTEMTIME_lpDate, char* lpFormat, char* lpDateStr, int cchDate, char* lpCalendar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDurationFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, pointer unfoundType_SYSTEMTIME_lpDuration, pointer unfoundType_ULONGLONG_ullDuration, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, string lpDurationStr, int cchDuration);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDurationFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, pointer unfoundType_SYSTEMTIME_lpDuration, pointer unfoundType_ULONGLONG_ullDuration, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, char* lpDurationStr, int cchDuration);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDurationFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, pointer unfoundType_SYSTEMTIME_lpDuration, pointer unfoundType_ULONGLONG_ullDuration, char* lpFormat, string lpDurationStr, int cchDuration);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDurationFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, pointer unfoundType_SYSTEMTIME_lpDuration, pointer unfoundType_ULONGLONG_ullDuration, char* lpFormat, char* lpDurationStr, int cchDuration);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDurationFormatEx(char* lpLocaleName, int dwFlags, pointer unfoundType_SYSTEMTIME_lpDuration, pointer unfoundType_ULONGLONG_ullDuration, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, string lpDurationStr, int cchDuration);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDurationFormatEx(char* lpLocaleName, int dwFlags, pointer unfoundType_SYSTEMTIME_lpDuration, pointer unfoundType_ULONGLONG_ullDuration, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, char* lpDurationStr, int cchDuration);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDurationFormatEx(char* lpLocaleName, int dwFlags, pointer unfoundType_SYSTEMTIME_lpDuration, pointer unfoundType_ULONGLONG_ullDuration, char* lpFormat, string lpDurationStr, int cchDuration);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDurationFormatEx(char* lpLocaleName, int dwFlags, pointer unfoundType_SYSTEMTIME_lpDuration, pointer unfoundType_ULONGLONG_ullDuration, char* lpFormat, char* lpDurationStr, int cchDuration);
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
        bool GetConsoleMode(pointer hConsoleHandle, pointer unfoundType_LPDWORD_lpMode);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetConsoleMode(pointer hConsoleHandle, int dwMode);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNumberOfConsoleInputEvents(pointer hConsoleInput, pointer unfoundType_LPDWORD_lpNumberOfEvents);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadConsoleInputA(pointer hConsoleInput, pointer unfoundType_PINPUT_RECORD_lpBuffer, int nLength, pointer unfoundType_LPDWORD_lpNumberOfEventsRead);
    [DllImport(lib, EntryPoint = "ReadConsoleInputW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadConsoleInput(pointer hConsoleInput, pointer unfoundType_PINPUT_RECORD_lpBuffer, int nLength, pointer unfoundType_LPDWORD_lpNumberOfEventsRead);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadConsoleInputW(pointer hConsoleInput, pointer unfoundType_PINPUT_RECORD_lpBuffer, int nLength, pointer unfoundType_LPDWORD_lpNumberOfEventsRead);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool PeekConsoleInputA(pointer hConsoleInput, pointer unfoundType_PINPUT_RECORD_lpBuffer, int nLength, pointer unfoundType_LPDWORD_lpNumberOfEventsRead);
    [DllImport(lib, EntryPoint = "PeekConsoleInputW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool PeekConsoleInput(pointer hConsoleInput, pointer unfoundType_PINPUT_RECORD_lpBuffer, int nLength, pointer unfoundType_LPDWORD_lpNumberOfEventsRead);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool PeekConsoleInputW(pointer hConsoleInput, pointer unfoundType_PINPUT_RECORD_lpBuffer, int nLength, pointer unfoundType_LPDWORD_lpNumberOfEventsRead);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadConsoleA(pointer hConsoleInput, pointer lpBuffer, int nNumberOfCharsToRead, pointer unfoundType_LPDWORD_lpNumberOfCharsRead, pointer unfoundType_PCONSOLE_READCONSOLE_CONTROL_pInputControl);
    [DllImport(lib, EntryPoint = "ReadConsoleW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadConsole(pointer hConsoleInput, pointer lpBuffer, int nNumberOfCharsToRead, pointer unfoundType_LPDWORD_lpNumberOfCharsRead, pointer unfoundType_PCONSOLE_READCONSOLE_CONTROL_pInputControl);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadConsoleW(pointer hConsoleInput, pointer lpBuffer, int nNumberOfCharsToRead, pointer unfoundType_LPDWORD_lpNumberOfCharsRead, pointer unfoundType_PCONSOLE_READCONSOLE_CONTROL_pInputControl);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteConsoleA(pointer hConsoleOutput, pointer lpBuffer, int nNumberOfCharsToWrite, pointer unfoundType_LPDWORD_lpNumberOfCharsWritten, pointer lpReserved);
    [DllImport(lib, EntryPoint = "WriteConsoleW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteConsole(pointer hConsoleOutput, pointer lpBuffer, int nNumberOfCharsToWrite, pointer unfoundType_LPDWORD_lpNumberOfCharsWritten, pointer lpReserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteConsoleW(pointer hConsoleOutput, pointer lpBuffer, int nNumberOfCharsToWrite, pointer unfoundType_LPDWORD_lpNumberOfCharsWritten, pointer lpReserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetConsoleCtrlHandler(pointer unfoundType_PHANDLER_ROUTINE_HandlerRoutine, bool Add);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreatePseudoConsole(pointer unfoundType_COORD_size, pointer hInput, pointer hOutput, int dwFlags, pointer unfoundType_HPCON_phPC);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer ResizePseudoConsole(pointer unfoundType_HPCON_hPC, pointer unfoundType_COORD_size);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void ClosePseudoConsole(pointer unfoundType_HPCON_hPC);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FillConsoleOutputCharacterA(pointer hConsoleOutput, byte cCharacter, int nLength, pointer unfoundType_COORD_dwWriteCoord, pointer unfoundType_LPDWORD_lpNumberOfCharsWritten);
    [DllImport(lib, EntryPoint = "FillConsoleOutputCharacterW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FillConsoleOutputCharacter(pointer hConsoleOutput, char cCharacter, int nLength, pointer unfoundType_COORD_dwWriteCoord, pointer unfoundType_LPDWORD_lpNumberOfCharsWritten);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FillConsoleOutputCharacterW(pointer hConsoleOutput, char cCharacter, int nLength, pointer unfoundType_COORD_dwWriteCoord, pointer unfoundType_LPDWORD_lpNumberOfCharsWritten);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FillConsoleOutputAttribute(pointer hConsoleOutput, short wAttribute, int nLength, pointer unfoundType_COORD_dwWriteCoord, pointer unfoundType_LPDWORD_lpNumberOfAttrsWritten);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GenerateConsoleCtrlEvent(int dwCtrlEvent, int dwProcessGroupId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateConsoleScreenBuffer(int dwDesiredAccess, int dwShareMode, pointer unfoundType_SECURITY_ATTRIBUTES_lpSecurityAttributes, int dwFlags, pointer lpScreenBufferData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetConsoleActiveScreenBuffer(pointer hConsoleOutput);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FlushConsoleInputBuffer(pointer hConsoleInput);
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
        bool GetConsoleCursorInfo(pointer hConsoleOutput, pointer unfoundType_PCONSOLE_CURSOR_INFO_lpConsoleCursorInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetConsoleCursorInfo(pointer hConsoleOutput, pointer unfoundType_CONSOLE_CURSOR_INFO_lpConsoleCursorInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetConsoleScreenBufferInfo(pointer hConsoleOutput, pointer unfoundType_PCONSOLE_SCREEN_BUFFER_INFO_lpConsoleScreenBufferInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetConsoleScreenBufferInfoEx(pointer hConsoleOutput, pointer unfoundType_PCONSOLE_SCREEN_BUFFER_INFOEX_lpConsoleScreenBufferInfoEx);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetConsoleScreenBufferInfoEx(pointer hConsoleOutput, pointer unfoundType_PCONSOLE_SCREEN_BUFFER_INFOEX_lpConsoleScreenBufferInfoEx);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetConsoleScreenBufferSize(pointer hConsoleOutput, pointer unfoundType_COORD_dwSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetConsoleCursorPosition(pointer hConsoleOutput, pointer unfoundType_COORD_dwCursorPosition);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetLargestConsoleWindowSize(pointer hConsoleOutput);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetConsoleTextAttribute(pointer hConsoleOutput, short wAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetConsoleWindowInfo(pointer hConsoleOutput, bool bAbsolute, pointer unfoundType_SMALL_RECT_lpConsoleWindow);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteConsoleOutputCharacterA(pointer hConsoleOutput, [MarshalAs(UnmanagedType.LPStr)] string lpCharacter, int nLength, pointer unfoundType_COORD_dwWriteCoord, pointer unfoundType_LPDWORD_lpNumberOfCharsWritten);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteConsoleOutputCharacterA(pointer hConsoleOutput, byte* lpCharacter, int nLength, pointer unfoundType_COORD_dwWriteCoord, pointer unfoundType_LPDWORD_lpNumberOfCharsWritten);
    [DllImport(lib, EntryPoint = "WriteConsoleOutputCharacterW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteConsoleOutputCharacter(pointer hConsoleOutput, [MarshalAs(UnmanagedType.LPWStr)] string lpCharacter, int nLength, pointer unfoundType_COORD_dwWriteCoord, pointer unfoundType_LPDWORD_lpNumberOfCharsWritten);
    [DllImport(lib, EntryPoint = "WriteConsoleOutputCharacterW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteConsoleOutputCharacter(pointer hConsoleOutput, char* lpCharacter, int nLength, pointer unfoundType_COORD_dwWriteCoord, pointer unfoundType_LPDWORD_lpNumberOfCharsWritten);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteConsoleOutputCharacterW(pointer hConsoleOutput, [MarshalAs(UnmanagedType.LPWStr)] string lpCharacter, int nLength, pointer unfoundType_COORD_dwWriteCoord, pointer unfoundType_LPDWORD_lpNumberOfCharsWritten);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteConsoleOutputCharacterW(pointer hConsoleOutput, char* lpCharacter, int nLength, pointer unfoundType_COORD_dwWriteCoord, pointer unfoundType_LPDWORD_lpNumberOfCharsWritten);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteConsoleOutputAttribute(pointer hConsoleOutput, pointer lpAttribute, int nLength, pointer unfoundType_COORD_dwWriteCoord, pointer unfoundType_LPDWORD_lpNumberOfAttrsWritten);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadConsoleOutputCharacterA(pointer hConsoleOutput, [MarshalAs(UnmanagedType.LPStr)] string lpCharacter, int nLength, pointer unfoundType_COORD_dwReadCoord, pointer unfoundType_LPDWORD_lpNumberOfCharsRead);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadConsoleOutputCharacterA(pointer hConsoleOutput, ReadOnlySpan<byte> lpCharacter, int nLength, pointer unfoundType_COORD_dwReadCoord, pointer unfoundType_LPDWORD_lpNumberOfCharsRead);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadConsoleOutputCharacterA(pointer hConsoleOutput, byte* lpCharacter, int nLength, pointer unfoundType_COORD_dwReadCoord, pointer unfoundType_LPDWORD_lpNumberOfCharsRead);
    [DllImport(lib, EntryPoint = "ReadConsoleOutputCharacterW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadConsoleOutputCharacter(pointer hConsoleOutput, string lpCharacter, int nLength, pointer unfoundType_COORD_dwReadCoord, pointer unfoundType_LPDWORD_lpNumberOfCharsRead);
    [DllImport(lib, EntryPoint = "ReadConsoleOutputCharacterW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadConsoleOutputCharacter(pointer hConsoleOutput, char* lpCharacter, int nLength, pointer unfoundType_COORD_dwReadCoord, pointer unfoundType_LPDWORD_lpNumberOfCharsRead);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadConsoleOutputCharacterW(pointer hConsoleOutput, string lpCharacter, int nLength, pointer unfoundType_COORD_dwReadCoord, pointer unfoundType_LPDWORD_lpNumberOfCharsRead);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadConsoleOutputCharacterW(pointer hConsoleOutput, char* lpCharacter, int nLength, pointer unfoundType_COORD_dwReadCoord, pointer unfoundType_LPDWORD_lpNumberOfCharsRead);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadConsoleOutputAttribute(pointer hConsoleOutput, pointer unfoundType_LPWORD_lpAttribute, int nLength, pointer unfoundType_COORD_dwReadCoord, pointer unfoundType_LPDWORD_lpNumberOfAttrsRead);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteConsoleInputA(pointer hConsoleInput, pointer unfoundType_INPUT_RECORD_lpBuffer, int nLength, pointer unfoundType_LPDWORD_lpNumberOfEventsWritten);
    [DllImport(lib, EntryPoint = "WriteConsoleInputW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteConsoleInput(pointer hConsoleInput, pointer unfoundType_INPUT_RECORD_lpBuffer, int nLength, pointer unfoundType_LPDWORD_lpNumberOfEventsWritten);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteConsoleInputW(pointer hConsoleInput, pointer unfoundType_INPUT_RECORD_lpBuffer, int nLength, pointer unfoundType_LPDWORD_lpNumberOfEventsWritten);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ScrollConsoleScreenBufferA(pointer hConsoleOutput, pointer unfoundType_SMALL_RECT_lpScrollRectangle, pointer unfoundType_SMALL_RECT_lpClipRectangle, pointer unfoundType_COORD_dwDestinationOrigin, pointer unfoundType_CHAR_INFO_lpFill);
    [DllImport(lib, EntryPoint = "ScrollConsoleScreenBufferW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ScrollConsoleScreenBuffer(pointer hConsoleOutput, pointer unfoundType_SMALL_RECT_lpScrollRectangle, pointer unfoundType_SMALL_RECT_lpClipRectangle, pointer unfoundType_COORD_dwDestinationOrigin, pointer unfoundType_CHAR_INFO_lpFill);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ScrollConsoleScreenBufferW(pointer hConsoleOutput, pointer unfoundType_SMALL_RECT_lpScrollRectangle, pointer unfoundType_SMALL_RECT_lpClipRectangle, pointer unfoundType_COORD_dwDestinationOrigin, pointer unfoundType_CHAR_INFO_lpFill);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteConsoleOutputA(pointer hConsoleOutput, pointer unfoundType_CHAR_INFO_lpBuffer, pointer unfoundType_COORD_dwBufferSize, pointer unfoundType_COORD_dwBufferCoord, pointer unfoundType_PSMALL_RECT_lpWriteRegion);
    [DllImport(lib, EntryPoint = "WriteConsoleOutputW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteConsoleOutput(pointer hConsoleOutput, pointer unfoundType_CHAR_INFO_lpBuffer, pointer unfoundType_COORD_dwBufferSize, pointer unfoundType_COORD_dwBufferCoord, pointer unfoundType_PSMALL_RECT_lpWriteRegion);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WriteConsoleOutputW(pointer hConsoleOutput, pointer unfoundType_CHAR_INFO_lpBuffer, pointer unfoundType_COORD_dwBufferSize, pointer unfoundType_COORD_dwBufferCoord, pointer unfoundType_PSMALL_RECT_lpWriteRegion);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadConsoleOutputA(pointer hConsoleOutput, pointer unfoundType_PCHAR_INFO_lpBuffer, pointer unfoundType_COORD_dwBufferSize, pointer unfoundType_COORD_dwBufferCoord, pointer unfoundType_PSMALL_RECT_lpReadRegion);
    [DllImport(lib, EntryPoint = "ReadConsoleOutputW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadConsoleOutput(pointer hConsoleOutput, pointer unfoundType_PCHAR_INFO_lpBuffer, pointer unfoundType_COORD_dwBufferSize, pointer unfoundType_COORD_dwBufferCoord, pointer unfoundType_PSMALL_RECT_lpReadRegion);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadConsoleOutputW(pointer hConsoleOutput, pointer unfoundType_PCHAR_INFO_lpBuffer, pointer unfoundType_COORD_dwBufferSize, pointer unfoundType_COORD_dwBufferCoord, pointer unfoundType_PSMALL_RECT_lpReadRegion);
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
        bool GetNumberOfConsoleMouseButtons(pointer unfoundType_LPDWORD_lpNumberOfMouseButtons);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetConsoleFontSize(pointer hConsoleOutput, int nFont);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetCurrentConsoleFont(pointer hConsoleOutput, bool bMaximumWindow, pointer unfoundType_PCONSOLE_FONT_INFO_lpConsoleCurrentFont);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetCurrentConsoleFontEx(pointer hConsoleOutput, bool bMaximumWindow, pointer unfoundType_PCONSOLE_FONT_INFOEX_lpConsoleCurrentFontEx);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetCurrentConsoleFontEx(pointer hConsoleOutput, bool bMaximumWindow, pointer unfoundType_PCONSOLE_FONT_INFOEX_lpConsoleCurrentFontEx);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetConsoleSelectionInfo(pointer unfoundType_PCONSOLE_SELECTION_INFO_lpConsoleSelectionInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetConsoleHistoryInfo(pointer unfoundType_PCONSOLE_HISTORY_INFO_lpConsoleHistoryInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetConsoleHistoryInfo(pointer unfoundType_PCONSOLE_HISTORY_INFO_lpConsoleHistoryInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetConsoleDisplayMode(pointer unfoundType_LPDWORD_lpModeFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetConsoleDisplayMode(pointer hConsoleOutput, int dwFlags, pointer unfoundType_PCOORD_lpNewScreenBufferDimensions);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetConsoleWindow();
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
        int GetConsoleProcessList(pointer unfoundType_LPDWORD_lpdwProcessList, int dwProcessCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreatePipe(pointer unfoundType_PHANDLE_hReadPipe, pointer unfoundType_PHANDLE_hWritePipe, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpPipeAttributes, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ConnectNamedPipe(pointer hNamedPipe, pointer unfoundType_LPOVERLAPPED_lpOverlapped);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DisconnectNamedPipe(pointer hNamedPipe);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetNamedPipeHandleState(pointer hNamedPipe, pointer unfoundType_LPDWORD_lpMode, pointer unfoundType_LPDWORD_lpMaxCollectionCount, pointer unfoundType_LPDWORD_lpCollectDataTimeout);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool PeekNamedPipe(pointer hNamedPipe, pointer lpBuffer, int nBufferSize, pointer unfoundType_LPDWORD_lpBytesRead, pointer unfoundType_LPDWORD_lpTotalBytesAvail, pointer unfoundType_LPDWORD_lpBytesLeftThisMessage);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool TransactNamedPipe(pointer hNamedPipe, pointer lpInBuffer, int nInBufferSize, pointer lpOutBuffer, int nOutBufferSize, pointer unfoundType_LPDWORD_lpBytesRead, pointer unfoundType_LPOVERLAPPED_lpOverlapped);
    [DllImport(lib, EntryPoint = "CreateNamedPipeW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateNamedPipe([MarshalAs(UnmanagedType.LPWStr)] string lpName, int dwOpenMode, int dwPipeMode, int nMaxInstances, int nOutBufferSize, int nInBufferSize, int nDefaultTimeOut, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, EntryPoint = "CreateNamedPipeW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateNamedPipe(char* lpName, int dwOpenMode, int dwPipeMode, int nMaxInstances, int nOutBufferSize, int nInBufferSize, int nDefaultTimeOut, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateNamedPipeW([MarshalAs(UnmanagedType.LPWStr)] string lpName, int dwOpenMode, int dwPipeMode, int nMaxInstances, int nOutBufferSize, int nInBufferSize, int nDefaultTimeOut, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateNamedPipeW(char* lpName, int dwOpenMode, int dwPipeMode, int nMaxInstances, int nOutBufferSize, int nInBufferSize, int nDefaultTimeOut, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
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
        bool GetNamedPipeClientComputerName(pointer Pipe, string ClientComputerName, uint ClientComputerNameLength);
    [DllImport(lib, EntryPoint = "GetNamedPipeClientComputerNameW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNamedPipeClientComputerName(pointer Pipe, char* ClientComputerName, uint ClientComputerNameLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNamedPipeClientComputerNameW(pointer Pipe, string ClientComputerName, uint ClientComputerNameLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNamedPipeClientComputerNameW(pointer Pipe, char* ClientComputerName, uint ClientComputerNameLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNamedPipeInfo(pointer hNamedPipe, pointer unfoundType_LPDWORD_lpFlags, pointer unfoundType_LPDWORD_lpOutBufferSize, pointer unfoundType_LPDWORD_lpInBufferSize, pointer unfoundType_LPDWORD_lpMaxInstances);
    [DllImport(lib, EntryPoint = "GetNamedPipeHandleStateW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNamedPipeHandleState(pointer hNamedPipe, pointer unfoundType_LPDWORD_lpState, pointer unfoundType_LPDWORD_lpCurInstances, pointer unfoundType_LPDWORD_lpMaxCollectionCount, pointer unfoundType_LPDWORD_lpCollectDataTimeout, string lpUserName, int nMaxUserNameSize);
    [DllImport(lib, EntryPoint = "GetNamedPipeHandleStateW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNamedPipeHandleState(pointer hNamedPipe, pointer unfoundType_LPDWORD_lpState, pointer unfoundType_LPDWORD_lpCurInstances, pointer unfoundType_LPDWORD_lpMaxCollectionCount, pointer unfoundType_LPDWORD_lpCollectDataTimeout, char* lpUserName, int nMaxUserNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNamedPipeHandleStateW(pointer hNamedPipe, pointer unfoundType_LPDWORD_lpState, pointer unfoundType_LPDWORD_lpCurInstances, pointer unfoundType_LPDWORD_lpMaxCollectionCount, pointer unfoundType_LPDWORD_lpCollectDataTimeout, string lpUserName, int nMaxUserNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNamedPipeHandleStateW(pointer hNamedPipe, pointer unfoundType_LPDWORD_lpState, pointer unfoundType_LPDWORD_lpCurInstances, pointer unfoundType_LPDWORD_lpMaxCollectionCount, pointer unfoundType_LPDWORD_lpCollectDataTimeout, char* lpUserName, int nMaxUserNameSize);
    [DllImport(lib, EntryPoint = "CallNamedPipeW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CallNamedPipe([MarshalAs(UnmanagedType.LPWStr)] string lpNamedPipeName, pointer lpInBuffer, int nInBufferSize, pointer lpOutBuffer, int nOutBufferSize, pointer unfoundType_LPDWORD_lpBytesRead, int nTimeOut);
    [DllImport(lib, EntryPoint = "CallNamedPipeW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CallNamedPipe(char* lpNamedPipeName, pointer lpInBuffer, int nInBufferSize, pointer lpOutBuffer, int nOutBufferSize, pointer unfoundType_LPDWORD_lpBytesRead, int nTimeOut);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CallNamedPipeW([MarshalAs(UnmanagedType.LPWStr)] string lpNamedPipeName, pointer lpInBuffer, int nInBufferSize, pointer lpOutBuffer, int nOutBufferSize, pointer unfoundType_LPDWORD_lpBytesRead, int nTimeOut);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CallNamedPipeW(char* lpNamedPipeName, pointer lpInBuffer, int nInBufferSize, pointer lpOutBuffer, int nOutBufferSize, pointer unfoundType_LPDWORD_lpBytesRead, int nTimeOut);
    [DllImport(lib, EntryPoint = "CreatePrivateNamespaceW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreatePrivateNamespace(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpPrivateNamespaceAttributes, pointer lpBoundaryDescriptor, [MarshalAs(UnmanagedType.LPWStr)] string lpAliasPrefix);
    [DllImport(lib, EntryPoint = "CreatePrivateNamespaceW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreatePrivateNamespace(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpPrivateNamespaceAttributes, pointer lpBoundaryDescriptor, char* lpAliasPrefix);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreatePrivateNamespaceW(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpPrivateNamespaceAttributes, pointer lpBoundaryDescriptor, [MarshalAs(UnmanagedType.LPWStr)] string lpAliasPrefix);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreatePrivateNamespaceW(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpPrivateNamespaceAttributes, pointer lpBoundaryDescriptor, char* lpAliasPrefix);
    [DllImport(lib, EntryPoint = "OpenPrivateNamespaceW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenPrivateNamespace(pointer lpBoundaryDescriptor, [MarshalAs(UnmanagedType.LPWStr)] string lpAliasPrefix);
    [DllImport(lib, EntryPoint = "OpenPrivateNamespaceW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenPrivateNamespace(pointer lpBoundaryDescriptor, char* lpAliasPrefix);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenPrivateNamespaceW(pointer lpBoundaryDescriptor, [MarshalAs(UnmanagedType.LPWStr)] string lpAliasPrefix);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenPrivateNamespaceW(pointer lpBoundaryDescriptor, char* lpAliasPrefix);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer ClosePrivateNamespace(pointer Handle, uint Flags);
    [DllImport(lib, EntryPoint = "CreateBoundaryDescriptorW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateBoundaryDescriptor([MarshalAs(UnmanagedType.LPWStr)] string Name, uint Flags);
    [DllImport(lib, EntryPoint = "CreateBoundaryDescriptorW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateBoundaryDescriptor(char* Name, uint Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateBoundaryDescriptorW([MarshalAs(UnmanagedType.LPWStr)] string Name, uint Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateBoundaryDescriptorW(char* Name, uint Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddSIDToBoundaryDescriptor(pointer BoundaryDescriptor, pointer unfoundType_PSID_RequiredSid);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void DeleteBoundaryDescriptor(pointer BoundaryDescriptor);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreatePackageVirtualizationContext([MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, pointer unfoundType_PACKAGE_VIRTUALIZATION_CONTEXT_HANDLE_context);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreatePackageVirtualizationContext(char* packageFamilyName, pointer unfoundType_PACKAGE_VIRTUALIZATION_CONTEXT_HANDLE_context);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer ActivatePackageVirtualizationContext(pointer unfoundType_PACKAGE_VIRTUALIZATION_CONTEXT_HANDLE_context, pointer unfoundType_ULONG_PTR_cookie);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void ReleasePackageVirtualizationContext(pointer unfoundType_PACKAGE_VIRTUALIZATION_CONTEXT_HANDLE_context);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void DeactivatePackageVirtualizationContext(pointer unfoundType_ULONG_PTR_cookie);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer DuplicatePackageVirtualizationContext(pointer unfoundType_PACKAGE_VIRTUALIZATION_CONTEXT_HANDLE_sourceContext, pointer unfoundType_PACKAGE_VIRTUALIZATION_CONTEXT_HANDLE_destContext);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetCurrentPackageVirtualizationContext();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetProcessesInVirtualizationContext([MarshalAs(UnmanagedType.LPWStr)] string packageFamilyName, pointer count, pointer processes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetProcessesInVirtualizationContext(char* packageFamilyName, pointer count, pointer processes);
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
        bool WaitForDebugEvent(pointer unfoundType_LPDEBUG_EVENT_lpDebugEvent, int dwMilliseconds);
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
        bool CheckRemoteDebuggerPresent(pointer hProcess, pointer pbDebuggerPresent);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WaitForDebugEventEx(pointer unfoundType_LPDEBUG_EVENT_lpDebugEvent, int dwMilliseconds);
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
        pointer GetStdHandle(int nStdHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetStdHandle(int nStdHandle, pointer hHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetStdHandleEx(int nStdHandle, pointer hHandle, pointer unfoundType_PHANDLE_phPrevValue);
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
        pointer GetEnvironmentStrings();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        char* GetEnvironmentStringsW_();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        string GetEnvironmentStringsW();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FreeEnvironmentStringsA(pointer unfoundType_LPCH_penv);
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
        int PssCaptureSnapshot(pointer ProcessHandle, pointer unfoundType_PSS_CAPTURE_FLAGS_CaptureFlags, int ThreadContextFlags, pointer unfoundType_HPSS_SnapshotHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PssFreeSnapshot(pointer ProcessHandle, pointer unfoundType_HPSS_SnapshotHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PssQuerySnapshot(pointer unfoundType_HPSS_SnapshotHandle, pointer unfoundType_PSS_QUERY_INFORMATION_CLASS_InformationClass, pointer Buffer, int BufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PssWalkSnapshot(pointer unfoundType_HPSS_SnapshotHandle, pointer unfoundType_PSS_WALK_INFORMATION_CLASS_InformationClass, pointer unfoundType_HPSSWALK_WalkMarkerHandle, pointer Buffer, int BufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PssDuplicateSnapshot(pointer SourceProcessHandle, pointer unfoundType_HPSS_SnapshotHandle, pointer TargetProcessHandle, pointer unfoundType_HPSS_TargetSnapshotHandle, pointer unfoundType_PSS_DUPLICATE_FLAGS_Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PssWalkMarkerCreate(pointer unfoundType_PSS_ALLOCATORAllocatorAllocator_unnamed_0, pointer unfoundType_HPSSWALK_WalkMarkerHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PssWalkMarkerFree(pointer unfoundType_HPSSWALK_WalkMarkerHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PssWalkMarkerGetPosition(pointer unfoundType_HPSSWALK_WalkMarkerHandle, pointer unfoundType_ULONG_PTRPositionPosition_unnamed_1);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PssWalkMarkerSetPosition(pointer unfoundType_HPSSWALK_WalkMarkerHandle, pointer unfoundType_ULONG_PTR_Position);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PssWalkMarkerSeekToBeginning(pointer unfoundType_HPSSWALK_WalkMarkerHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int QueueUserAPC(pointer unfoundType_PAPCFUNC_pfnAPC, pointer hThread, pointer unfoundType_ULONG_PTR_dwData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueueUserAPC2(pointer unfoundType_PAPCFUNC_ApcRoutine, pointer Thread, pointer unfoundType_ULONG_PTR_Data, pointer unfoundType_QUEUE_USER_APC_FLAGS_Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetProcessTimes(pointer hProcess, pointer unfoundType_LPFILETIME_lpCreationTime, pointer unfoundType_LPFILETIME_lpExitTime, pointer unfoundType_LPFILETIME_lpKernelTime, pointer unfoundType_LPFILETIME_lpUserTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetCurrentProcess();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrentProcessId();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void ExitProcess(uint uExitCode);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool TerminateProcess(pointer hProcess, uint uExitCode);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetExitCodeProcess(pointer hProcess, pointer unfoundType_LPDWORD_lpExitCode);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SwitchToThread();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateThread(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, pointer dwStackSize, pointer unfoundType_LPTHREAD_START_ROUTINE_lpStartAddress, pointer lpParameter, int dwCreationFlags, pointer unfoundType_LPDWORD_lpThreadId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateRemoteThread(pointer hProcess, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, pointer dwStackSize, pointer unfoundType_LPTHREAD_START_ROUTINE_lpStartAddress, pointer lpParameter, int dwCreationFlags, pointer unfoundType_LPDWORD_lpThreadId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetCurrentThread();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrentThreadId();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenThread(int dwDesiredAccess, bool bInheritHandle, int dwThreadId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetThreadPriority(pointer hThread, int nPriority);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetThreadPriorityBoost(pointer hThread, bool bDisablePriorityBoost);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetThreadPriorityBoost(pointer hThread, pointer pDisablePriorityBoost);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetThreadPriority(pointer hThread);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void ExitThread(int dwExitCode);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool TerminateThread(pointer hThread, int dwExitCode);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetExitCodeThread(pointer hThread, pointer unfoundType_LPDWORD_lpExitCode);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SuspendThread(pointer hThread);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ResumeThread(pointer hThread);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int TlsAlloc();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer TlsGetValue(int dwTlsIndex);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool TlsSetValue(int dwTlsIndex, pointer lpTlsValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool TlsFree(int dwTlsIndex);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessA([MarshalAs(UnmanagedType.LPStr)] string lpApplicationName, [MarshalAs(UnmanagedType.LPStr)] string lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, [MarshalAs(UnmanagedType.LPStr)] string lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessA([MarshalAs(UnmanagedType.LPStr)] string lpApplicationName, [MarshalAs(UnmanagedType.LPStr)] string lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, byte* lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessA([MarshalAs(UnmanagedType.LPStr)] string lpApplicationName, ReadOnlySpan<byte> lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, [MarshalAs(UnmanagedType.LPStr)] string lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessA([MarshalAs(UnmanagedType.LPStr)] string lpApplicationName, ReadOnlySpan<byte> lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, byte* lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessA([MarshalAs(UnmanagedType.LPStr)] string lpApplicationName, byte* lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, [MarshalAs(UnmanagedType.LPStr)] string lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessA([MarshalAs(UnmanagedType.LPStr)] string lpApplicationName, byte* lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, byte* lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessA(byte* lpApplicationName, [MarshalAs(UnmanagedType.LPStr)] string lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, [MarshalAs(UnmanagedType.LPStr)] string lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessA(byte* lpApplicationName, [MarshalAs(UnmanagedType.LPStr)] string lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, byte* lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessA(byte* lpApplicationName, ReadOnlySpan<byte> lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, [MarshalAs(UnmanagedType.LPStr)] string lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessA(byte* lpApplicationName, ReadOnlySpan<byte> lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, byte* lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessA(byte* lpApplicationName, byte* lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, [MarshalAs(UnmanagedType.LPStr)] string lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessA(byte* lpApplicationName, byte* lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, byte* lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, EntryPoint = "CreateProcessW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcess([MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, string lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, EntryPoint = "CreateProcessW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcess([MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, string lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, char* lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, EntryPoint = "CreateProcessW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcess([MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, char* lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, EntryPoint = "CreateProcessW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcess([MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, char* lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, char* lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, EntryPoint = "CreateProcessW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcess(char* lpApplicationName, string lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, EntryPoint = "CreateProcessW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcess(char* lpApplicationName, string lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, char* lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, EntryPoint = "CreateProcessW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcess(char* lpApplicationName, char* lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, EntryPoint = "CreateProcessW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcess(char* lpApplicationName, char* lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, char* lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessW([MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, string lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessW([MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, string lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, char* lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessW([MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, char* lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessW([MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, char* lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, char* lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessW(char* lpApplicationName, string lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessW(char* lpApplicationName, string lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, char* lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessW(char* lpApplicationName, char* lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessW(char* lpApplicationName, char* lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, char* lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetProcessShutdownParameters(int dwLevel, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProcessVersion(int ProcessId);
    [DllImport(lib, EntryPoint = "GetStartupInfoW", SetLastError = true, ExactSpelling = true)]
    public static extern
        void GetStartupInfo(pointer unfoundType_LPSTARTUPINFOW_lpStartupInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void GetStartupInfoW(pointer unfoundType_LPSTARTUPINFOW_lpStartupInfo);
    [DllImport(lib, EntryPoint = "CreateProcessAsUserW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUser(pointer hToken, [MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, string lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, EntryPoint = "CreateProcessAsUserW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUser(pointer hToken, [MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, string lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, char* lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, EntryPoint = "CreateProcessAsUserW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUser(pointer hToken, [MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, char* lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, EntryPoint = "CreateProcessAsUserW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUser(pointer hToken, [MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, char* lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, char* lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, EntryPoint = "CreateProcessAsUserW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUser(pointer hToken, char* lpApplicationName, string lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, EntryPoint = "CreateProcessAsUserW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUser(pointer hToken, char* lpApplicationName, string lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, char* lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, EntryPoint = "CreateProcessAsUserW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUser(pointer hToken, char* lpApplicationName, char* lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, EntryPoint = "CreateProcessAsUserW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUser(pointer hToken, char* lpApplicationName, char* lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, char* lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUserW(pointer hToken, [MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, string lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUserW(pointer hToken, [MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, string lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, char* lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUserW(pointer hToken, [MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, char* lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUserW(pointer hToken, [MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, char* lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, char* lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUserW(pointer hToken, char* lpApplicationName, string lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUserW(pointer hToken, char* lpApplicationName, string lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, char* lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUserW(pointer hToken, char* lpApplicationName, char* lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUserW(pointer hToken, char* lpApplicationName, char* lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, char* lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOW_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetThreadToken(pointer unfoundType_PHANDLE_Thread, pointer Token);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool OpenProcessToken(pointer ProcessHandle, int DesiredAccess, pointer unfoundType_PHANDLE_TokenHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool OpenThreadToken(pointer ThreadHandle, int DesiredAccess, bool OpenAsSelf, pointer unfoundType_PHANDLE_TokenHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetPriorityClass(pointer hProcess, int dwPriorityClass);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPriorityClass(pointer hProcess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetThreadStackGuarantee(pointer unfoundType_PULONG_StackSizeInBytes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ProcessIdToSessionId(int dwProcessId, pointer pSessionId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProcessId(pointer Process);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetThreadId(pointer Thread);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void FlushProcessWriteBuffers();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetProcessIdOfThread(pointer Thread);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool InitializeProcThreadAttributeList(pointer unfoundType_LPPROC_THREAD_ATTRIBUTE_LIST_lpAttributeList, int dwAttributeCount, int dwFlags, pointer unfoundType_PSIZE_T_lpSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void DeleteProcThreadAttributeList(pointer unfoundType_LPPROC_THREAD_ATTRIBUTE_LIST_lpAttributeList);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UpdateProcThreadAttribute(pointer unfoundType_LPPROC_THREAD_ATTRIBUTE_LIST_lpAttributeList, int dwFlags, pointer unfoundType_DWORD_PTR_Attribute, pointer lpValue, pointer cbSize, pointer lpPreviousValue, pointer unfoundType_PSIZE_T_lpReturnSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetProcessDynamicEHContinuationTargets(pointer Process, ushort NumberOfTargets, pointer unfoundType_PPROCESS_DYNAMIC_EH_CONTINUATION_TARGET_Targets);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetProcessDynamicEnforcedCetCompatibleRanges(pointer Process, ushort NumberOfRanges, pointer unfoundType_PPROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGE_Ranges);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetProcessAffinityUpdateMode(pointer hProcess, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryProcessAffinityUpdateMode(pointer hProcess, pointer unfoundType_LPDWORD_lpdwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateRemoteThreadEx(pointer hProcess, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, pointer dwStackSize, pointer unfoundType_LPTHREAD_START_ROUTINE_lpStartAddress, pointer lpParameter, int dwCreationFlags, pointer unfoundType_LPPROC_THREAD_ATTRIBUTE_LIST_lpAttributeList, pointer unfoundType_LPDWORD_lpThreadId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void GetCurrentThreadStackLimits(pointer LowLimit, pointer HighLimit);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetThreadContext(pointer hThread, pointer unfoundType_LPCONTEXT_lpContext);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetProcessMitigationPolicy(pointer hProcess, pointer unfoundType_PROCESS_MITIGATION_POLICY_MitigationPolicy, pointer lpBuffer, pointer dwLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetThreadContext(pointer hThread, pointer unfoundType_CONTEXT_lpContext);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetProcessMitigationPolicy(pointer unfoundType_PROCESS_MITIGATION_POLICY_MitigationPolicy, pointer lpBuffer, pointer dwLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FlushInstructionCache(pointer hProcess, pointer lpBaseAddress, pointer dwSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetThreadTimes(pointer hThread, pointer unfoundType_LPFILETIME_lpCreationTime, pointer unfoundType_LPFILETIME_lpExitTime, pointer unfoundType_LPFILETIME_lpKernelTime, pointer unfoundType_LPFILETIME_lpUserTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsProcessorFeaturePresent(int ProcessorFeature);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetProcessHandleCount(pointer hProcess, pointer unfoundType_PDWORD_pdwHandleCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrentProcessorNumber();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetThreadIdealProcessorEx(pointer hThread, pointer unfoundType_PPROCESSOR_NUMBER_lpIdealProcessor, pointer unfoundType_PPROCESSOR_NUMBER_lpPreviousIdealProcessor);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetThreadIdealProcessorEx(pointer hThread, pointer unfoundType_PPROCESSOR_NUMBER_lpIdealProcessor);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void GetCurrentProcessorNumberEx(pointer unfoundType_PPROCESSOR_NUMBER_ProcNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetProcessPriorityBoost(pointer hProcess, pointer pDisablePriorityBoost);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetProcessPriorityBoost(pointer hProcess, bool bDisablePriorityBoost);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetThreadIOPendingFlag(pointer hThread, pointer lpIOIsPending);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetSystemTimes(pointer unfoundType_PFILETIME_lpIdleTime, pointer unfoundType_PFILETIME_lpKernelTime, pointer unfoundType_PFILETIME_lpUserTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetThreadInformation(pointer hThread, pointer unfoundType_THREAD_INFORMATION_CLASS_ThreadInformationClass, pointer ThreadInformation, int ThreadInformationSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetThreadInformation(pointer hThread, pointer unfoundType_THREAD_INFORMATION_CLASS_ThreadInformationClass, pointer ThreadInformation, int ThreadInformationSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsProcessCritical(pointer hProcess, pointer Critical);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetProtectedPolicy(pointer unfoundType_LPCGUID_PolicyGuid, pointer unfoundType_ULONG_PTR_PolicyValue, pointer OldPolicyValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryProtectedPolicy(pointer unfoundType_LPCGUID_PolicyGuid, pointer PolicyValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SetThreadIdealProcessor(pointer hThread, int dwIdealProcessor);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetProcessInformation(pointer hProcess, pointer unfoundType_PROCESS_INFORMATION_CLASS_ProcessInformationClass, pointer ProcessInformation, int ProcessInformationSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetProcessInformation(pointer hProcess, pointer unfoundType_PROCESS_INFORMATION_CLASS_ProcessInformationClass, pointer ProcessInformation, int ProcessInformationSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetSystemCpuSetInformation(pointer unfoundType_PSYSTEM_CPU_SET_INFORMATION_Information, uint BufferLength, pointer unfoundType_PULONG_ReturnedLength, pointer Process, uint Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetProcessDefaultCpuSets(pointer Process, pointer unfoundType_PULONG_CpuSetIds, uint CpuSetIdCount, pointer unfoundType_PULONG_RequiredIdCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetProcessDefaultCpuSets(pointer Process, pointer CpuSetIds, uint CpuSetIdCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetThreadSelectedCpuSets(pointer Thread, pointer unfoundType_PULONG_CpuSetIds, uint CpuSetIdCount, pointer unfoundType_PULONG_RequiredIdCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetThreadSelectedCpuSets(pointer Thread, pointer CpuSetIds, uint CpuSetIdCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUserA(pointer hToken, [MarshalAs(UnmanagedType.LPStr)] string lpApplicationName, [MarshalAs(UnmanagedType.LPStr)] string lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, [MarshalAs(UnmanagedType.LPStr)] string lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUserA(pointer hToken, [MarshalAs(UnmanagedType.LPStr)] string lpApplicationName, [MarshalAs(UnmanagedType.LPStr)] string lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, byte* lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUserA(pointer hToken, [MarshalAs(UnmanagedType.LPStr)] string lpApplicationName, ReadOnlySpan<byte> lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, [MarshalAs(UnmanagedType.LPStr)] string lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUserA(pointer hToken, [MarshalAs(UnmanagedType.LPStr)] string lpApplicationName, ReadOnlySpan<byte> lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, byte* lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUserA(pointer hToken, [MarshalAs(UnmanagedType.LPStr)] string lpApplicationName, byte* lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, [MarshalAs(UnmanagedType.LPStr)] string lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUserA(pointer hToken, [MarshalAs(UnmanagedType.LPStr)] string lpApplicationName, byte* lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, byte* lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUserA(pointer hToken, byte* lpApplicationName, [MarshalAs(UnmanagedType.LPStr)] string lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, [MarshalAs(UnmanagedType.LPStr)] string lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUserA(pointer hToken, byte* lpApplicationName, [MarshalAs(UnmanagedType.LPStr)] string lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, byte* lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUserA(pointer hToken, byte* lpApplicationName, ReadOnlySpan<byte> lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, [MarshalAs(UnmanagedType.LPStr)] string lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUserA(pointer hToken, byte* lpApplicationName, ReadOnlySpan<byte> lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, byte* lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUserA(pointer hToken, byte* lpApplicationName, byte* lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, [MarshalAs(UnmanagedType.LPStr)] string lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateProcessAsUserA(pointer hToken, byte* lpApplicationName, byte* lpCommandLine, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpProcessAttributes, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, pointer lpEnvironment, byte* lpCurrentDirectory, pointer unfoundType_LPSTARTUPINFOA_lpStartupInfo, pointer unfoundType_LPPROCESS_INFORMATION_lpProcessInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetProcessShutdownParameters(pointer unfoundType_LPDWORD_lpdwLevel, pointer unfoundType_LPDWORD_lpdwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetProcessDefaultCpuSetMasks(pointer Process, pointer unfoundType_PGROUP_AFFINITY_CpuSetMasks, ushort CpuSetMaskCount, pointer unfoundType_PUSHORT_RequiredMaskCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetProcessDefaultCpuSetMasks(pointer Process, pointer unfoundType_PGROUP_AFFINITY_CpuSetMasks, ushort CpuSetMaskCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetThreadSelectedCpuSetMasks(pointer Thread, pointer unfoundType_PGROUP_AFFINITY_CpuSetMasks, ushort CpuSetMaskCount, pointer unfoundType_PUSHORT_RequiredMaskCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetThreadSelectedCpuSetMasks(pointer Thread, pointer unfoundType_PGROUP_AFFINITY_CpuSetMasks, ushort CpuSetMaskCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetMachineTypeAttributes(ushort Machine, pointer unfoundType_MACHINE_ATTRIBUTES_MachineTypeAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer SetThreadDescription(pointer hThread, [MarshalAs(UnmanagedType.LPWStr)] string lpThreadDescription);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer SetThreadDescription(pointer hThread, char* lpThreadDescription);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetThreadDescription(pointer hThread, [MarshalAs(UnmanagedType.LPWStr)] string ppszThreadDescription);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetThreadDescription(pointer hThread, char** ppszThreadDescription);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetProcessGroupAffinity(pointer hProcess, pointer unfoundType_PUSHORT_GroupCount, pointer unfoundType_PUSHORT_GroupArray);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetThreadGroupAffinity(pointer hThread, pointer unfoundType_PGROUP_AFFINITY_GroupAffinity);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetThreadGroupAffinity(pointer hThread, pointer unfoundType_GROUP_AFFINITY_GroupAffinity, pointer unfoundType_PGROUP_AFFINITY_PreviousGroupAffinity);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryPerformanceCounter(pointer unfoundType_LARGE_INTEGER_lpPerformanceCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryPerformanceFrequency(pointer unfoundType_LARGE_INTEGER_lpFrequency);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryThreadCycleTime(pointer ThreadHandle, pointer unfoundType_PULONG64_CycleTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryProcessCycleTime(pointer ProcessHandle, pointer unfoundType_PULONG64_CycleTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryIdleProcessorCycleTime(pointer unfoundType_PULONG_BufferLength, pointer unfoundType_PULONG64_ProcessorIdleCycleTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryIdleProcessorCycleTimeEx(ushort Group, pointer unfoundType_PULONG_BufferLength, pointer unfoundType_PULONG64_ProcessorIdleCycleTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryUnbiasedInterruptTime(pointer unfoundType_PULONGLONG_UnbiasedTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool OOBEComplete(pointer isOOBEComplete);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool RegisterWaitUntilOOBECompleted(pointer unfoundType_OOBE_COMPLETED_CALLBACK_OOBECompletedCallback, pointer CallbackContext, pointer WaitHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UnregisterWaitUntilOOBECompleted(pointer WaitHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetAppContainerNamedObjectPath(pointer Token, pointer unfoundType_PSID_AppContainerSid, uint ObjectPathLength, string ObjectPath, pointer unfoundType_PULONG_ReturnLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetAppContainerNamedObjectPath(pointer Token, pointer unfoundType_PSID_AppContainerSid, uint ObjectPathLength, char* ObjectPath, pointer unfoundType_PULONG_ReturnLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddResourceAttributeAce(pointer unfoundType_PACL_pAcl, int dwAceRevision, int AceFlags, int AccessMask, pointer unfoundType_PSID_pSid, pointer unfoundType_PCLAIM_SECURITY_ATTRIBUTES_INFORMATION_pAttributeInfo, pointer unfoundType_PDWORD_pReturnLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddScopedPolicyIDAce(pointer unfoundType_PACL_pAcl, int dwAceRevision, int AceFlags, int AccessMask, pointer unfoundType_PSID_pSid);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckTokenCapability(pointer TokenHandle, pointer unfoundType_PSID_CapabilitySidToCheck, pointer HasCapability);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetAppContainerAce(pointer unfoundType_PACL_Acl, int StartingAceIndex, pointer AppContainerAce, pointer AppContainerAceIndex);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckTokenMembershipEx(pointer TokenHandle, pointer unfoundType_PSID_SidToCheck, int Flags, pointer IsMember);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetCachedSigningLevel(pointer unfoundType_PHANDLE_SourceFiles, uint SourceFileCount, uint Flags, pointer TargetFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetCachedSigningLevel(pointer File, pointer unfoundType_PULONG_Flags, pointer unfoundType_PULONG_SigningLevel, pointer unfoundType_PUCHAR_Thumbprint, pointer unfoundType_PULONG_ThumbprintSize, pointer unfoundType_PULONG_ThumbprintAlgorithm);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CompareStringEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwCmpFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpString1, int cchCount1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2, int cchCount2, pointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, pointer lpReserved, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CompareStringEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwCmpFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpString1, int cchCount1, char* lpString2, int cchCount2, pointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, pointer lpReserved, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CompareStringEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwCmpFlags, char* lpString1, int cchCount1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2, int cchCount2, pointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, pointer lpReserved, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CompareStringEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwCmpFlags, char* lpString1, int cchCount1, char* lpString2, int cchCount2, pointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, pointer lpReserved, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CompareStringEx(char* lpLocaleName, int dwCmpFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpString1, int cchCount1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2, int cchCount2, pointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, pointer lpReserved, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CompareStringEx(char* lpLocaleName, int dwCmpFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpString1, int cchCount1, char* lpString2, int cchCount2, pointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, pointer lpReserved, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CompareStringEx(char* lpLocaleName, int dwCmpFlags, char* lpString1, int cchCount1, [MarshalAs(UnmanagedType.LPWStr)] string lpString2, int cchCount2, pointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, pointer lpReserved, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CompareStringEx(char* lpLocaleName, int dwCmpFlags, char* lpString1, int cchCount1, char* lpString2, int cchCount2, pointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, pointer lpReserved, long lParam);
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
        int CompareString(pointer unfoundType_LCID_Locale, int dwCmpFlags, string lpString1, int cchCount1, string lpString2, int cchCount2);
    [DllImport(lib, EntryPoint = "CompareStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int CompareString(pointer unfoundType_LCID_Locale, int dwCmpFlags, string lpString1, int cchCount1, char* lpString2, int cchCount2);
    [DllImport(lib, EntryPoint = "CompareStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int CompareString(pointer unfoundType_LCID_Locale, int dwCmpFlags, char* lpString1, int cchCount1, string lpString2, int cchCount2);
    [DllImport(lib, EntryPoint = "CompareStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int CompareString(pointer unfoundType_LCID_Locale, int dwCmpFlags, char* lpString1, int cchCount1, char* lpString2, int cchCount2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CompareStringW(pointer unfoundType_LCID_Locale, int dwCmpFlags, string lpString1, int cchCount1, string lpString2, int cchCount2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CompareStringW(pointer unfoundType_LCID_Locale, int dwCmpFlags, string lpString1, int cchCount1, char* lpString2, int cchCount2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CompareStringW(pointer unfoundType_LCID_Locale, int dwCmpFlags, char* lpString1, int cchCount1, string lpString2, int cchCount2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CompareStringW(pointer unfoundType_LCID_Locale, int dwCmpFlags, char* lpString1, int cchCount1, char* lpString2, int cchCount2);
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
        bool GetStringTypeEx(pointer unfoundType_LCID_Locale, int dwInfoType, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, pointer unfoundType_LPWORD_lpCharType);
    [DllImport(lib, EntryPoint = "GetStringTypeExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetStringTypeEx(pointer unfoundType_LCID_Locale, int dwInfoType, char* lpSrcStr, int cchSrc, pointer unfoundType_LPWORD_lpCharType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetStringTypeExW(pointer unfoundType_LCID_Locale, int dwInfoType, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, pointer unfoundType_LPWORD_lpCharType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetStringTypeExW(pointer unfoundType_LCID_Locale, int dwInfoType, char* lpSrcStr, int cchSrc, pointer unfoundType_LPWORD_lpCharType);
    [DllImport(lib, EntryPoint = "GetStringTypeW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetStringType(int dwInfoType, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, pointer unfoundType_LPWORD_lpCharType);
    [DllImport(lib, EntryPoint = "GetStringTypeW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetStringType(int dwInfoType, char* lpSrcStr, int cchSrc, pointer unfoundType_LPWORD_lpCharType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetStringTypeW(int dwInfoType, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, pointer unfoundType_LPWORD_lpCharType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetStringTypeW(int dwInfoType, char* lpSrcStr, int cchSrc, pointer unfoundType_LPWORD_lpCharType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int MultiByteToWideChar(uint CodePage, int dwFlags, pointer unfoundType_LPCCH_lpMultiByteStr, int cbMultiByte, string lpWideCharStr, int cchWideChar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int MultiByteToWideChar(uint CodePage, int dwFlags, pointer unfoundType_LPCCH_lpMultiByteStr, int cbMultiByte, char* lpWideCharStr, int cchWideChar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int WideCharToMultiByte(uint CodePage, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpWideCharStr, int cchWideChar, [MarshalAs(UnmanagedType.LPStr)] string lpMultiByteStr, int cbMultiByte, pointer unfoundType_LPCCH_lpDefaultChar, pointer unfoundType_LPBOOL_lpUsedDefaultChar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int WideCharToMultiByte(uint CodePage, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpWideCharStr, int cchWideChar, ReadOnlySpan<byte> lpMultiByteStr, int cbMultiByte, pointer unfoundType_LPCCH_lpDefaultChar, pointer unfoundType_LPBOOL_lpUsedDefaultChar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int WideCharToMultiByte(uint CodePage, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpWideCharStr, int cchWideChar, byte* lpMultiByteStr, int cbMultiByte, pointer unfoundType_LPCCH_lpDefaultChar, pointer unfoundType_LPBOOL_lpUsedDefaultChar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int WideCharToMultiByte(uint CodePage, int dwFlags, char* lpWideCharStr, int cchWideChar, [MarshalAs(UnmanagedType.LPStr)] string lpMultiByteStr, int cbMultiByte, pointer unfoundType_LPCCH_lpDefaultChar, pointer unfoundType_LPBOOL_lpUsedDefaultChar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int WideCharToMultiByte(uint CodePage, int dwFlags, char* lpWideCharStr, int cchWideChar, ReadOnlySpan<byte> lpMultiByteStr, int cbMultiByte, pointer unfoundType_LPCCH_lpDefaultChar, pointer unfoundType_LPBOOL_lpUsedDefaultChar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int WideCharToMultiByte(uint CodePage, int dwFlags, char* lpWideCharStr, int cchWideChar, byte* lpMultiByteStr, int cbMultiByte, pointer unfoundType_LPCCH_lpDefaultChar, pointer unfoundType_LPBOOL_lpUsedDefaultChar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ushort RtlCaptureStackBackTrace(uint FramesToSkip, uint FramesToCapture, pointer BackTrace, pointer unfoundType_PULONG_BackTraceHash);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void RtlCaptureContext(pointer unfoundType_PCONTEXT_ContextRecord);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void RtlUnwind(pointer TargetFrame, pointer TargetIp, pointer unfoundType_PEXCEPTION_RECORD_ExceptionRecord, pointer ReturnValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
    public static extern
        pointer RtlAddFunctionTable(pointer unfoundType_PRUNTIME_FUNCTION_FunctionTable, uint EntryCount, pointer unfoundType_ULONG64_BaseAddress);
    [DllImport(lib, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
    public static extern
        pointer RtlDeleteFunctionTable(pointer unfoundType_PRUNTIME_FUNCTION_FunctionTable);
    [DllImport(lib, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
    public static extern
        pointer RtlInstallFunctionTableCallback(pointer unfoundType_ULONG64_TableIdentifier, pointer unfoundType_ULONG64_BaseAddress, uint Length, pointer unfoundType_PGET_RUNTIME_FUNCTION_CALLBACK_Callback, pointer Context, [MarshalAs(UnmanagedType.LPWStr)] string OutOfProcessCallbackDll);
    [DllImport(lib, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
    public static extern
        pointer RtlInstallFunctionTableCallback(pointer unfoundType_ULONG64_TableIdentifier, pointer unfoundType_ULONG64_BaseAddress, uint Length, pointer unfoundType_PGET_RUNTIME_FUNCTION_CALLBACK_Callback, pointer Context, char* OutOfProcessCallbackDll);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RtlLookupFunctionEntry(pointer unfoundType_ULONG64_ControlPc, pointer unfoundType_PULONG64_ImageBase, pointer unfoundType_PUNWIND_HISTORY_TABLE_HistoryTable);
    [DllImport(lib, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
    public static extern
        void RtlRestoreContext(pointer unfoundType_PCONTEXT_ContextRecord, pointer unfoundType__EXCEPTION_RECORD_ExceptionRecord);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void RtlUnwindEx(pointer TargetFrame, pointer TargetIp, pointer unfoundType_PEXCEPTION_RECORD_ExceptionRecord, pointer ReturnValue, pointer unfoundType_PCONTEXT_ContextRecord, pointer unfoundType_PUNWIND_HISTORY_TABLE_HistoryTable);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RtlVirtualUnwind(uint HandlerType, pointer unfoundType_ULONG64_ImageBase, pointer unfoundType_ULONG64_ControlPc, pointer unfoundType_PRUNTIME_FUNCTION_FunctionEntry, pointer unfoundType_PCONTEXT_ContextRecord, pointer HandlerData, pointer unfoundType_PULONG64_EstablisherFrame, pointer unfoundType_PKNONVOLATILE_CONTEXT_POINTERS_ContextPointers);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RtlVirtualUnwind2(uint HandlerType, pointer unfoundType_ULONG64_ImageBase, pointer unfoundType_ULONG64_ControlPc, pointer unfoundType_PRUNTIME_FUNCTION_FunctionEntry, pointer unfoundType_PCONTEXT_ContextRecord, pointer unfoundType_PBOOLEAN_MachineFrameUnwound, pointer HandlerData, pointer unfoundType_PULONG64_EstablisherFrame, pointer unfoundType_PKNONVOLATILE_CONTEXT_POINTERS_ContextPointers, pointer unfoundType_PULONG64_LowLimit, pointer unfoundType_PULONG64_HighLimit, pointer unfoundType_PEXCEPTION_ROUTINE_HandlerRoutine, uint UnwindFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RtlIsEcCode(pointer unfoundType_ULONG64_CodePointer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void RtlRaiseException(pointer unfoundType_PEXCEPTION_RECORD_ExceptionRecord);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RtlPcToFileHeader(pointer PcValue, pointer BaseOfImage);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint* RtlCompareMemory(pointer Source1, pointer Source2, pointer Length);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNumaHighestNodeNumber(pointer unfoundType_PULONG_HighestNodeNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNumaNodeProcessorMaskEx(ushort Node, pointer unfoundType_PGROUP_AFFINITY_ProcessorMask);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNumaNodeProcessorMask2(ushort NodeNumber, pointer unfoundType_PGROUP_AFFINITY_ProcessorMasks, ushort ProcessorMaskCount, pointer unfoundType_PUSHORT_RequiredMaskCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNumaProximityNodeEx(uint ProximityId, pointer unfoundType_PUSHORT_NodeNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateThreadpool(pointer reserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void SetThreadpoolThreadMaximum(pointer unfoundType_PTP_POOL_ptpp, int cthrdMost);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetThreadpoolThreadMinimum(pointer unfoundType_PTP_POOL_ptpp, int cthrdMic);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetThreadpoolStackInformation(pointer unfoundType_PTP_POOL_ptpp, pointer unfoundType_PTP_POOL_STACK_INFORMATION_ptpsi);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryThreadpoolStackInformation(pointer unfoundType_PTP_POOL_ptpp, pointer unfoundType_PTP_POOL_STACK_INFORMATION_ptpsi);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void CloseThreadpool(pointer unfoundType_PTP_POOL_ptpp);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateThreadpoolCleanupGroup();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void CloseThreadpoolCleanupGroupMembers(pointer unfoundType_PTP_CLEANUP_GROUP_ptpcg, bool fCancelPendingCallbacks, pointer pvCleanupContext);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void CloseThreadpoolCleanupGroup(pointer unfoundType_PTP_CLEANUP_GROUP_ptpcg);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void SetEventWhenCallbackReturns(pointer unfoundType_PTP_CALLBACK_INSTANCE_pci, pointer evt);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void ReleaseSemaphoreWhenCallbackReturns(pointer unfoundType_PTP_CALLBACK_INSTANCE_pci, pointer sem, int crel);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void ReleaseMutexWhenCallbackReturns(pointer unfoundType_PTP_CALLBACK_INSTANCE_pci, pointer mut);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void LeaveCriticalSectionWhenCallbackReturns(pointer unfoundType_PTP_CALLBACK_INSTANCE_pci, pointer unfoundType_PCRITICAL_SECTION_pcs);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void FreeLibraryWhenCallbackReturns(pointer unfoundType_PTP_CALLBACK_INSTANCE_pci, pointer unfoundType_HMODULE_mod);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CallbackMayRunLong(pointer unfoundType_PTP_CALLBACK_INSTANCE_pci);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void DisassociateCurrentThreadFromCallback(pointer unfoundType_PTP_CALLBACK_INSTANCE_pci);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool TrySubmitThreadpoolCallback(pointer unfoundType_PTP_SIMPLE_CALLBACK_pfns, pointer pv, pointer unfoundType_PTP_CALLBACK_ENVIRON_pcbe);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateThreadpoolWork(pointer unfoundType_PTP_WORK_CALLBACK_pfnwk, pointer pv, pointer unfoundType_PTP_CALLBACK_ENVIRON_pcbe);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void SubmitThreadpoolWork(pointer unfoundType_PTP_WORK_pwk);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void WaitForThreadpoolWorkCallbacks(pointer unfoundType_PTP_WORK_pwk, bool fCancelPendingCallbacks);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void CloseThreadpoolWork(pointer unfoundType_PTP_WORK_pwk);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateThreadpoolTimer(pointer unfoundType_PTP_TIMER_CALLBACK_pfnti, pointer pv, pointer unfoundType_PTP_CALLBACK_ENVIRON_pcbe);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void SetThreadpoolTimer(pointer unfoundType_PTP_TIMER_pti, pointer unfoundType_PFILETIME_pftDueTime, int msPeriod, int msWindowLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsThreadpoolTimerSet(pointer unfoundType_PTP_TIMER_pti);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void WaitForThreadpoolTimerCallbacks(pointer unfoundType_PTP_TIMER_pti, bool fCancelPendingCallbacks);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void CloseThreadpoolTimer(pointer unfoundType_PTP_TIMER_pti);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateThreadpoolWait(pointer unfoundType_PTP_WAIT_CALLBACK_pfnwa, pointer pv, pointer unfoundType_PTP_CALLBACK_ENVIRON_pcbe);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void SetThreadpoolWait(pointer unfoundType_PTP_WAIT_pwa, pointer h, pointer unfoundType_PFILETIME_pftTimeout);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void WaitForThreadpoolWaitCallbacks(pointer unfoundType_PTP_WAIT_pwa, bool fCancelPendingCallbacks);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void CloseThreadpoolWait(pointer unfoundType_PTP_WAIT_pwa);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateThreadpoolIo(pointer fl, pointer unfoundType_PTP_WIN32_IO_CALLBACK_pfnio, pointer pv, pointer unfoundType_PTP_CALLBACK_ENVIRON_pcbe);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void StartThreadpoolIo(pointer unfoundType_PTP_IO_pio);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void CancelThreadpoolIo(pointer unfoundType_PTP_IO_pio);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void WaitForThreadpoolIoCallbacks(pointer unfoundType_PTP_IO_pio, bool fCancelPendingCallbacks);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void CloseThreadpoolIo(pointer unfoundType_PTP_IO_pio);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetThreadpoolTimerEx(pointer unfoundType_PTP_TIMER_pti, pointer unfoundType_PFILETIME_pftDueTime, int msPeriod, int msWindowLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetThreadpoolWaitEx(pointer unfoundType_PTP_WAIT_pwa, pointer h, pointer unfoundType_PFILETIME_pftTimeout, pointer Reserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueueUserWorkItem(pointer unfoundType_LPTHREAD_START_ROUTINE_Function, pointer Context, uint Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UnregisterWaitEx(pointer WaitHandle, pointer CompletionEvent);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateTimerQueue();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateTimerQueueTimer(pointer unfoundType_PHANDLE_phNewTimer, pointer TimerQueue, pointer unfoundType_WAITORTIMERCALLBACK_Callback, pointer Parameter, int DueTime, int Period, uint Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ChangeTimerQueueTimer(pointer TimerQueue, pointer Timer, uint DueTime, uint Period);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DeleteTimerQueueTimer(pointer TimerQueue, pointer Timer, pointer CompletionEvent);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DeleteTimerQueue(pointer TimerQueue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DeleteTimerQueueEx(pointer TimerQueue, pointer CompletionEvent);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer timeGetSystemTime(pointer unfoundType_LPMMTIME_pmmt, uint cbmmt);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int timeGetTime();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer timeGetDevCaps(pointer unfoundType_LPTIMECAPS_ptc, uint cbtc);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer timeBeginPeriod(uint uPeriod);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer timeEndPeriod(uint uPeriod);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SystemTimeToTzSpecificLocalTime(pointer unfoundType_TIME_ZONE_INFORMATION_lpTimeZoneInformation, pointer unfoundType_SYSTEMTIME_lpUniversalTime, pointer unfoundType_LPSYSTEMTIME_lpLocalTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool TzSpecificLocalTimeToSystemTime(pointer unfoundType_TIME_ZONE_INFORMATION_lpTimeZoneInformation, pointer unfoundType_SYSTEMTIME_lpLocalTime, pointer unfoundType_LPSYSTEMTIME_lpUniversalTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FileTimeToSystemTime(pointer unfoundType_FILETIME_lpFileTime, pointer unfoundType_LPSYSTEMTIME_lpSystemTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SystemTimeToFileTime(pointer unfoundType_SYSTEMTIME_lpSystemTime, pointer unfoundType_LPFILETIME_lpFileTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTimeZoneInformation(pointer unfoundType_LPTIME_ZONE_INFORMATION_lpTimeZoneInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetTimeZoneInformation(pointer unfoundType_TIME_ZONE_INFORMATION_lpTimeZoneInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetDynamicTimeZoneInformation(pointer unfoundType_DYNAMIC_TIME_ZONE_INFORMATION_lpTimeZoneInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDynamicTimeZoneInformation(pointer unfoundType_PDYNAMIC_TIME_ZONE_INFORMATION_pTimeZoneInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetTimeZoneInformationForYear(ushort wYear, pointer unfoundType_PDYNAMIC_TIME_ZONE_INFORMATION_pdtzi, pointer unfoundType_LPTIME_ZONE_INFORMATION_ptzi);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SystemTimeToTzSpecificLocalTimeEx(pointer unfoundType_DYNAMIC_TIME_ZONE_INFORMATION_lpTimeZoneInformation, pointer unfoundType_SYSTEMTIME_lpUniversalTime, pointer unfoundType_LPSYSTEMTIME_lpLocalTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool TzSpecificLocalTimeToSystemTimeEx(pointer unfoundType_DYNAMIC_TIME_ZONE_INFORMATION_lpTimeZoneInformation, pointer unfoundType_SYSTEMTIME_lpLocalTime, pointer unfoundType_LPSYSTEMTIME_lpUniversalTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool LocalFileTimeToLocalSystemTime(pointer unfoundType_TIME_ZONE_INFORMATION_timeZoneInformation, pointer unfoundType_FILETIME_localFileTime, pointer unfoundType_SYSTEMTIME_localSystemTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool LocalSystemTimeToLocalFileTime(pointer unfoundType_TIME_ZONE_INFORMATION_timeZoneInformation, pointer unfoundType_SYSTEMTIME_localSystemTime, pointer unfoundType_FILETIME_localFileTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateToolhelp32Snapshot(int dwFlags, int th32ProcessID);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool Heap32ListFirst(pointer hSnapshot, pointer unfoundType_LPHEAPLIST32_lphl);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool Heap32ListNext(pointer hSnapshot, pointer unfoundType_LPHEAPLIST32_lphl);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool Heap32First(pointer unfoundType_LPHEAPENTRY32_lphe, int th32ProcessID, pointer unfoundType_ULONG_PTR_th32HeapID);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool Heap32Next(pointer unfoundType_LPHEAPENTRY32_lphe);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool Toolhelp32ReadProcessMemory(int th32ProcessID, pointer lpBaseAddress, pointer lpBuffer, pointer cbRead, pointer lpNumberOfBytesRead);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool Process32FirstW(pointer hSnapshot, pointer unfoundType_LPPROCESSENTRY32W_lppe);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool Process32NextW(pointer hSnapshot, pointer unfoundType_LPPROCESSENTRY32W_lppe);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool Process32First(pointer hSnapshot, pointer unfoundType_LPPROCESSENTRY32_lppe);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool Process32Next(pointer hSnapshot, pointer unfoundType_LPPROCESSENTRY32_lppe);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool Thread32First(pointer hSnapshot, pointer unfoundType_LPTHREADENTRY32_lpte);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool Thread32Next(pointer hSnapshot, pointer unfoundType_LPTHREADENTRY32_lpte);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool Module32FirstW(pointer hSnapshot, pointer unfoundType_LPMODULEENTRY32W_lpme);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool Module32NextW(pointer hSnapshot, pointer unfoundType_LPMODULEENTRY32W_lpme);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool Module32First(pointer hSnapshot, pointer unfoundType_LPMODULEENTRY32_lpme);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool Module32Next(pointer hSnapshot, pointer unfoundType_LPMODULEENTRY32_lpme);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void InitializeSRWLock(pointer unfoundType_PSRWLOCK_SRWLock);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void ReleaseSRWLockExclusive(pointer unfoundType_PSRWLOCK_SRWLock);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void ReleaseSRWLockShared(pointer unfoundType_PSRWLOCK_SRWLock);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void AcquireSRWLockExclusive(pointer unfoundType_PSRWLOCK_SRWLock);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void AcquireSRWLockShared(pointer unfoundType_PSRWLOCK_SRWLock);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer TryAcquireSRWLockExclusive(pointer unfoundType_PSRWLOCK_SRWLock);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer TryAcquireSRWLockShared(pointer unfoundType_PSRWLOCK_SRWLock);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void InitializeCriticalSection(pointer unfoundType_LPCRITICAL_SECTION_lpCriticalSection);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void EnterCriticalSection(pointer unfoundType_LPCRITICAL_SECTION_lpCriticalSection);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void LeaveCriticalSection(pointer unfoundType_LPCRITICAL_SECTION_lpCriticalSection);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool InitializeCriticalSectionAndSpinCount(pointer unfoundType_LPCRITICAL_SECTION_lpCriticalSection, int dwSpinCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool InitializeCriticalSectionEx(pointer unfoundType_LPCRITICAL_SECTION_lpCriticalSection, int dwSpinCount, int Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SetCriticalSectionSpinCount(pointer unfoundType_LPCRITICAL_SECTION_lpCriticalSection, int dwSpinCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool TryEnterCriticalSection(pointer unfoundType_LPCRITICAL_SECTION_lpCriticalSection);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void DeleteCriticalSection(pointer unfoundType_LPCRITICAL_SECTION_lpCriticalSection);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void InitOnceInitialize(pointer unfoundType_PINIT_ONCE_InitOnce);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool InitOnceExecuteOnce(pointer unfoundType_PINIT_ONCE_InitOnce, pointer unfoundType_PINIT_ONCE_FN_InitFn, pointer Parameter, pointer Context);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool InitOnceBeginInitialize(pointer unfoundType_LPINIT_ONCE_lpInitOnce, int dwFlags, pointer fPending, pointer lpContext);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool InitOnceComplete(pointer unfoundType_LPINIT_ONCE_lpInitOnce, int dwFlags, pointer lpContext);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void InitializeConditionVariable(pointer unfoundType_PCONDITION_VARIABLE_ConditionVariable);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void WakeConditionVariable(pointer unfoundType_PCONDITION_VARIABLE_ConditionVariable);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void WakeAllConditionVariable(pointer unfoundType_PCONDITION_VARIABLE_ConditionVariable);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SleepConditionVariableCS(pointer unfoundType_PCONDITION_VARIABLE_ConditionVariable, pointer unfoundType_PCRITICAL_SECTION_CriticalSection, int dwMilliseconds);
    [DllImport(lib, EntryPoint = "SleepConditionVariableSRW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SleepConditionVariableSR(pointer unfoundType_PCONDITION_VARIABLE_ConditionVariable, pointer unfoundType_PSRWLOCK_SRWLock, int dwMilliseconds, uint Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SleepConditionVariableSRW(pointer unfoundType_PCONDITION_VARIABLE_ConditionVariable, pointer unfoundType_PSRWLOCK_SRWLock, int dwMilliseconds, uint Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetEvent(pointer hEvent);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ResetEvent(pointer hEvent);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReleaseSemaphore(pointer hSemaphore, int lReleaseCount, pointer unfoundType_LPLONG_lpPreviousCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReleaseMutex(pointer hMutex);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int WaitForSingleObject(pointer hHandle, int dwMilliseconds);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SleepEx(int dwMilliseconds, bool bAlertable);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int WaitForSingleObjectEx(pointer hHandle, int dwMilliseconds, bool bAlertable);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int WaitForMultipleObjectsEx(int nCount, pointer lpHandles, bool bWaitAll, int dwMilliseconds, bool bAlertable);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateMutexA(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpMutexAttributes, bool bInitialOwner, [MarshalAs(UnmanagedType.LPStr)] string lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateMutexA(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpMutexAttributes, bool bInitialOwner, byte* lpName);
    [DllImport(lib, EntryPoint = "CreateMutexW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateMutex(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpMutexAttributes, bool bInitialOwner, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport(lib, EntryPoint = "CreateMutexW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateMutex(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpMutexAttributes, bool bInitialOwner, char* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateMutexW(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpMutexAttributes, bool bInitialOwner, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateMutexW(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpMutexAttributes, bool bInitialOwner, char* lpName);
    [DllImport(lib, EntryPoint = "OpenMutexW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenMutex(int dwDesiredAccess, bool bInheritHandle, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport(lib, EntryPoint = "OpenMutexW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenMutex(int dwDesiredAccess, bool bInheritHandle, char* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenMutexW(int dwDesiredAccess, bool bInheritHandle, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenMutexW(int dwDesiredAccess, bool bInheritHandle, char* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateEventA(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpEventAttributes, bool bManualReset, bool bInitialState, [MarshalAs(UnmanagedType.LPStr)] string lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateEventA(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpEventAttributes, bool bManualReset, bool bInitialState, byte* lpName);
    [DllImport(lib, EntryPoint = "CreateEventW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateEvent(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpEventAttributes, bool bManualReset, bool bInitialState, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport(lib, EntryPoint = "CreateEventW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateEvent(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpEventAttributes, bool bManualReset, bool bInitialState, char* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateEventW(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpEventAttributes, bool bManualReset, bool bInitialState, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateEventW(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpEventAttributes, bool bManualReset, bool bInitialState, char* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenEventA(int dwDesiredAccess, bool bInheritHandle, [MarshalAs(UnmanagedType.LPStr)] string lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenEventA(int dwDesiredAccess, bool bInheritHandle, byte* lpName);
    [DllImport(lib, EntryPoint = "OpenEventW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenEvent(int dwDesiredAccess, bool bInheritHandle, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport(lib, EntryPoint = "OpenEventW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenEvent(int dwDesiredAccess, bool bInheritHandle, char* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenEventW(int dwDesiredAccess, bool bInheritHandle, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenEventW(int dwDesiredAccess, bool bInheritHandle, char* lpName);
    [DllImport(lib, EntryPoint = "OpenSemaphoreW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenSemaphore(int dwDesiredAccess, bool bInheritHandle, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport(lib, EntryPoint = "OpenSemaphoreW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenSemaphore(int dwDesiredAccess, bool bInheritHandle, char* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenSemaphoreW(int dwDesiredAccess, bool bInheritHandle, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenSemaphoreW(int dwDesiredAccess, bool bInheritHandle, char* lpName);
    [DllImport(lib, EntryPoint = "OpenWaitableTimerW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenWaitableTimer(int dwDesiredAccess, bool bInheritHandle, [MarshalAs(UnmanagedType.LPWStr)] string lpTimerName);
    [DllImport(lib, EntryPoint = "OpenWaitableTimerW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenWaitableTimer(int dwDesiredAccess, bool bInheritHandle, char* lpTimerName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenWaitableTimerW(int dwDesiredAccess, bool bInheritHandle, [MarshalAs(UnmanagedType.LPWStr)] string lpTimerName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenWaitableTimerW(int dwDesiredAccess, bool bInheritHandle, char* lpTimerName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetWaitableTimerEx(pointer hTimer, pointer unfoundType_LARGE_INTEGER_lpDueTime, int lPeriod, pointer unfoundType_PTIMERAPCROUTINE_pfnCompletionRoutine, pointer lpArgToCompletionRoutine, pointer unfoundType_PREASON_CONTEXT_WakeContext, uint TolerableDelay);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetWaitableTimer(pointer hTimer, pointer unfoundType_LARGE_INTEGER_lpDueTime, int lPeriod, pointer unfoundType_PTIMERAPCROUTINE_pfnCompletionRoutine, pointer lpArgToCompletionRoutine, bool fResume);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CancelWaitableTimer(pointer hTimer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateMutexExA(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpMutexAttributes, [MarshalAs(UnmanagedType.LPStr)] string lpName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateMutexExA(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpMutexAttributes, byte* lpName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, EntryPoint = "CreateMutexExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateMutexEx(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpMutexAttributes, [MarshalAs(UnmanagedType.LPWStr)] string lpName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, EntryPoint = "CreateMutexExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateMutexEx(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpMutexAttributes, char* lpName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateMutexExW(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpMutexAttributes, [MarshalAs(UnmanagedType.LPWStr)] string lpName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateMutexExW(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpMutexAttributes, char* lpName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateEventExA(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpEventAttributes, [MarshalAs(UnmanagedType.LPStr)] string lpName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateEventExA(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpEventAttributes, byte* lpName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, EntryPoint = "CreateEventExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateEventEx(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpEventAttributes, [MarshalAs(UnmanagedType.LPWStr)] string lpName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, EntryPoint = "CreateEventExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateEventEx(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpEventAttributes, char* lpName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateEventExW(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpEventAttributes, [MarshalAs(UnmanagedType.LPWStr)] string lpName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateEventExW(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpEventAttributes, char* lpName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, EntryPoint = "CreateSemaphoreExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateSemaphoreEx(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, [MarshalAs(UnmanagedType.LPWStr)] string lpName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, EntryPoint = "CreateSemaphoreExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateSemaphoreEx(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, char* lpName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateSemaphoreExW(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, [MarshalAs(UnmanagedType.LPWStr)] string lpName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateSemaphoreExW(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, char* lpName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, EntryPoint = "CreateWaitableTimerExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateWaitableTimerEx(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpTimerAttributes, [MarshalAs(UnmanagedType.LPWStr)] string lpTimerName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, EntryPoint = "CreateWaitableTimerExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateWaitableTimerEx(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpTimerAttributes, char* lpTimerName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateWaitableTimerExW(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpTimerAttributes, [MarshalAs(UnmanagedType.LPWStr)] string lpTimerName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateWaitableTimerExW(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpTimerAttributes, char* lpTimerName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnterSynchronizationBarrier(pointer unfoundType_LPSYNCHRONIZATION_BARRIER_lpBarrier, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool InitializeSynchronizationBarrier(pointer unfoundType_LPSYNCHRONIZATION_BARRIER_lpBarrier, int lTotalThreads, int lSpinCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DeleteSynchronizationBarrier(pointer unfoundType_LPSYNCHRONIZATION_BARRIER_lpBarrier);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void Sleep(int dwMilliseconds);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SignalObjectAndWait(pointer hObjectToSignal, pointer hObjectToWaitOn, int dwMilliseconds, bool bAlertable);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int WaitForMultipleObjects(int nCount, pointer lpHandles, bool bWaitAll, int dwMilliseconds);
    [DllImport(lib, EntryPoint = "CreateSemaphoreW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateSemaphore(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport(lib, EntryPoint = "CreateSemaphoreW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateSemaphore(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, char* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateSemaphoreW(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, [MarshalAs(UnmanagedType.LPWStr)] string lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateSemaphoreW(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, char* lpName);
    [DllImport(lib, EntryPoint = "CreateWaitableTimerW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateWaitableTimer(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpTimerAttributes, bool bManualReset, [MarshalAs(UnmanagedType.LPWStr)] string lpTimerName);
    [DllImport(lib, EntryPoint = "CreateWaitableTimerW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateWaitableTimer(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpTimerAttributes, bool bManualReset, char* lpTimerName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateWaitableTimerW(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpTimerAttributes, bool bManualReset, [MarshalAs(UnmanagedType.LPWStr)] string lpTimerName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateWaitableTimerW(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpTimerAttributes, bool bManualReset, char* lpTimerName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GlobalMemoryStatusEx(pointer unfoundType_LPMEMORYSTATUSEX_lpBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void GetSystemInfo(pointer unfoundType_LPSYSTEM_INFO_lpSystemInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void GetSystemTime(pointer unfoundType_LPSYSTEMTIME_lpSystemTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void GetSystemTimeAsFileTime(pointer unfoundType_LPFILETIME_lpSystemTimeAsFileTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void GetLocalTime(pointer unfoundType_LPSYSTEMTIME_lpSystemTime);
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
        bool SetLocalTime(pointer unfoundType_SYSTEMTIME_lpSystemTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTickCount();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetTickCount64();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetSystemTimeAdjustment(pointer unfoundType_PDWORD_lpTimeAdjustment, pointer unfoundType_PDWORD_lpTimeIncrement, pointer lpTimeAdjustmentDisabled);
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
        bool GetComputerNameExA(pointer unfoundType_COMPUTER_NAME_FORMAT_NameType, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, pointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetComputerNameExA(pointer unfoundType_COMPUTER_NAME_FORMAT_NameType, ReadOnlySpan<byte> lpBuffer, pointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetComputerNameExA(pointer unfoundType_COMPUTER_NAME_FORMAT_NameType, byte* lpBuffer, pointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, EntryPoint = "GetComputerNameExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetComputerNameEx(pointer unfoundType_COMPUTER_NAME_FORMAT_NameType, string lpBuffer, pointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, EntryPoint = "GetComputerNameExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetComputerNameEx(pointer unfoundType_COMPUTER_NAME_FORMAT_NameType, char* lpBuffer, pointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetComputerNameExW(pointer unfoundType_COMPUTER_NAME_FORMAT_NameType, string lpBuffer, pointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetComputerNameExW(pointer unfoundType_COMPUTER_NAME_FORMAT_NameType, char* lpBuffer, pointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, EntryPoint = "SetComputerNameExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetComputerNameEx(pointer unfoundType_COMPUTER_NAME_FORMAT_NameType, [MarshalAs(UnmanagedType.LPWStr)] string lpBuffer);
    [DllImport(lib, EntryPoint = "SetComputerNameExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetComputerNameEx(pointer unfoundType_COMPUTER_NAME_FORMAT_NameType, char* lpBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetComputerNameExW(pointer unfoundType_COMPUTER_NAME_FORMAT_NameType, [MarshalAs(UnmanagedType.LPWStr)] string lpBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetComputerNameExW(pointer unfoundType_COMPUTER_NAME_FORMAT_NameType, char* lpBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetSystemTime(pointer unfoundType_SYSTEMTIME_lpSystemTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVersionExA(pointer unfoundType_LPOSVERSIONINFOA_lpVersionInformation);
    [DllImport(lib, EntryPoint = "GetVersionExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVersionEx(pointer unfoundType_LPOSVERSIONINFOW_lpVersionInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVersionExW(pointer unfoundType_LPOSVERSIONINFOW_lpVersionInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetLogicalProcessorInformation(pointer unfoundType_PSYSTEM_LOGICAL_PROCESSOR_INFORMATION_Buffer, pointer unfoundType_PDWORD_ReturnedLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetLogicalProcessorInformationEx(pointer unfoundType_LOGICAL_PROCESSOR_RELATIONSHIP_RelationshipType, pointer unfoundType_PSYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX_Buffer, pointer unfoundType_PDWORD_ReturnedLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void GetNativeSystemInfo(pointer unfoundType_LPSYSTEM_INFO_lpSystemInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void GetSystemTimePreciseAsFileTime(pointer unfoundType_LPFILETIME_lpSystemTimeAsFileTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetProductInfo(int dwOSMajorVersion, int dwOSMinorVersion, int dwSpMajorVersion, int dwSpMinorVersion, pointer unfoundType_PDWORD_pdwReturnedProductType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer VerSetConditionMask(pointer unfoundType_ULONGLONG_ConditionMask, uint TypeMask, byte Condition);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint EnumSystemFirmwareTables(int FirmwareTableProviderSignature, pointer pFirmwareTableEnumBuffer, int BufferSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetSystemFirmwareTable(int FirmwareTableProviderSignature, int FirmwareTableID, pointer pFirmwareTableBuffer, int BufferSize);
    [DllImport(lib, EntryPoint = "DnsHostnameToComputerNameExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerNameEx([MarshalAs(UnmanagedType.LPWStr)] string Hostname, string ComputerName, pointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, EntryPoint = "DnsHostnameToComputerNameExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerNameEx([MarshalAs(UnmanagedType.LPWStr)] string Hostname, char* ComputerName, pointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, EntryPoint = "DnsHostnameToComputerNameExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerNameEx(char* Hostname, string ComputerName, pointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, EntryPoint = "DnsHostnameToComputerNameExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerNameEx(char* Hostname, char* ComputerName, pointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerNameExW([MarshalAs(UnmanagedType.LPWStr)] string Hostname, string ComputerName, pointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerNameExW([MarshalAs(UnmanagedType.LPWStr)] string Hostname, char* ComputerName, pointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerNameExW(char* Hostname, string ComputerName, pointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerNameExW(char* Hostname, char* ComputerName, pointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPhysicallyInstalledSystemMemory(pointer unfoundType_PULONGLONG_TotalMemoryInKilobytes);
    [DllImport(lib, EntryPoint = "SetComputerNameEx2W", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetComputerNameEx2(pointer unfoundType_COMPUTER_NAME_FORMAT_NameType, int Flags, [MarshalAs(UnmanagedType.LPWStr)] string lpBuffer);
    [DllImport(lib, EntryPoint = "SetComputerNameEx2W", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetComputerNameEx2(pointer unfoundType_COMPUTER_NAME_FORMAT_NameType, int Flags, char* lpBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetComputerNameEx2W(pointer unfoundType_COMPUTER_NAME_FORMAT_NameType, int Flags, [MarshalAs(UnmanagedType.LPWStr)] string lpBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetComputerNameEx2W(pointer unfoundType_COMPUTER_NAME_FORMAT_NameType, int Flags, char* lpBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetSystemTimeAdjustment(int dwTimeAdjustment, bool bTimeAdjustmentDisabled);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool InstallELAMCertificateInfo(pointer ELAMFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetProcessorSystemCycleTime(ushort Group, pointer unfoundType_PSYSTEM_PROCESSOR_CYCLE_TIME_INFORMATION_Buffer, pointer unfoundType_PDWORD_ReturnedLength);
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
        bool SetComputerNameExA(pointer unfoundType_COMPUTER_NAME_FORMAT_NameType, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetComputerNameExA(pointer unfoundType_COMPUTER_NAME_FORMAT_NameType, byte* lpBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer EncodePointer(pointer Ptr);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer DecodePointer(pointer Ptr);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer EncodeSystemPointer(pointer Ptr);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer DecodeSystemPointer(pointer Ptr);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool Beep(int dwFreq, int dwDuration);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer WerRegisterFile([MarshalAs(UnmanagedType.LPWStr)] string pwzFile, pointer unfoundType_WER_REGISTER_FILE_TYPE_regFileType, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer WerRegisterFile(char* pwzFile, pointer unfoundType_WER_REGISTER_FILE_TYPE_regFileType, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer WerUnregisterFile([MarshalAs(UnmanagedType.LPWStr)] string pwzFilePath);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer WerUnregisterFile(char* pwzFilePath);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer WerRegisterMemoryBlock(pointer pvAddress, int dwSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer WerUnregisterMemoryBlock(pointer pvAddress);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer WerRegisterExcludedMemoryBlock(pointer address, int size);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer WerUnregisterExcludedMemoryBlock(pointer address);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer WerRegisterCustomMetadata([MarshalAs(UnmanagedType.LPWStr)] string key, [MarshalAs(UnmanagedType.LPWStr)] string value);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer WerRegisterCustomMetadata([MarshalAs(UnmanagedType.LPWStr)] string key, char* value);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer WerRegisterCustomMetadata(char* key, [MarshalAs(UnmanagedType.LPWStr)] string value);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer WerRegisterCustomMetadata(char* key, char* value);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer WerUnregisterCustomMetadata([MarshalAs(UnmanagedType.LPWStr)] string key);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer WerUnregisterCustomMetadata(char* key);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer WerRegisterAdditionalProcess(int processId, int captureExtraInfoForThreadId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer WerUnregisterAdditionalProcess(int processId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer WerRegisterAppLocalDump([MarshalAs(UnmanagedType.LPWStr)] string localAppDataRelativePath);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer WerRegisterAppLocalDump(char* localAppDataRelativePath);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer WerUnregisterAppLocalDump();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer WerSetFlags(int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer WerGetFlags(pointer hProcess, pointer unfoundType_PDWORD_pdwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer WerRegisterRuntimeExceptionModule([MarshalAs(UnmanagedType.LPWStr)] string pwszOutOfProcessCallbackDll, pointer pContext);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer WerRegisterRuntimeExceptionModule(char* pwszOutOfProcessCallbackDll, pointer pContext);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer WerUnregisterRuntimeExceptionModule([MarshalAs(UnmanagedType.LPWStr)] string pwszOutOfProcessCallbackDll, pointer pContext);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer WerUnregisterRuntimeExceptionModule(char* pwszOutOfProcessCallbackDll, pointer pContext);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GlobalAlloc(uint uFlags, pointer dwBytes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GlobalReAlloc(pointer unfoundType_HGLOBAL_hMem, pointer dwBytes, uint uFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint* GlobalSize(pointer unfoundType_HGLOBAL_hMem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GlobalUnlock(pointer unfoundType_HGLOBAL_hMem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GlobalLock(pointer unfoundType_HGLOBAL_hMem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GlobalFlags(pointer unfoundType_HGLOBAL_hMem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GlobalHandle(pointer pMem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GlobalFree(pointer unfoundType_HGLOBAL_hMem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint* GlobalCompact(int dwMinFree);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void GlobalFix(pointer unfoundType_HGLOBAL_hMem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void GlobalUnfix(pointer unfoundType_HGLOBAL_hMem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GlobalWire(pointer unfoundType_HGLOBAL_hMem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GlobalUnWire(pointer unfoundType_HGLOBAL_hMem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void GlobalMemoryStatus(pointer unfoundType_LPMEMORYSTATUS_lpBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LocalAlloc(uint uFlags, pointer uBytes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LocalReAlloc(pointer unfoundType_HLOCAL_hMem, pointer uBytes, uint uFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LocalLock(pointer unfoundType_HLOCAL_hMem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LocalHandle(pointer pMem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool LocalUnlock(pointer unfoundType_HLOCAL_hMem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint* LocalSize(pointer unfoundType_HLOCAL_hMem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint LocalFlags(pointer unfoundType_HLOCAL_hMem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LocalFree(pointer unfoundType_HLOCAL_hMem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint* LocalShrink(pointer unfoundType_HLOCAL_hMem, uint cbNewSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint* LocalCompact(uint uMinFree);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetBinaryTypeA([MarshalAs(UnmanagedType.LPStr)] string lpApplicationName, pointer unfoundType_LPDWORD_lpBinaryType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetBinaryTypeA(byte* lpApplicationName, pointer unfoundType_LPDWORD_lpBinaryType);
    [DllImport(lib, EntryPoint = "GetBinaryTypeW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetBinaryType([MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, pointer unfoundType_LPDWORD_lpBinaryType);
    [DllImport(lib, EntryPoint = "GetBinaryTypeW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetBinaryType(char* lpApplicationName, pointer unfoundType_LPDWORD_lpBinaryType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetBinaryTypeW([MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, pointer unfoundType_LPDWORD_lpBinaryType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetBinaryTypeW(char* lpApplicationName, pointer unfoundType_LPDWORD_lpBinaryType);
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
        int GetLongPathNameTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpszShortPath, [MarshalAs(UnmanagedType.LPStr)] string lpszLongPath, int cchBuffer, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLongPathNameTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpszShortPath, ReadOnlySpan<byte> lpszLongPath, int cchBuffer, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLongPathNameTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpszShortPath, byte* lpszLongPath, int cchBuffer, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLongPathNameTransactedA(byte* lpszShortPath, [MarshalAs(UnmanagedType.LPStr)] string lpszLongPath, int cchBuffer, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLongPathNameTransactedA(byte* lpszShortPath, ReadOnlySpan<byte> lpszLongPath, int cchBuffer, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLongPathNameTransactedA(byte* lpszShortPath, byte* lpszLongPath, int cchBuffer, pointer hTransaction);
    [DllImport(lib, EntryPoint = "GetLongPathNameTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLongPathNameTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpszShortPath, string lpszLongPath, int cchBuffer, pointer hTransaction);
    [DllImport(lib, EntryPoint = "GetLongPathNameTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLongPathNameTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpszShortPath, char* lpszLongPath, int cchBuffer, pointer hTransaction);
    [DllImport(lib, EntryPoint = "GetLongPathNameTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLongPathNameTransacted(char* lpszShortPath, string lpszLongPath, int cchBuffer, pointer hTransaction);
    [DllImport(lib, EntryPoint = "GetLongPathNameTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLongPathNameTransacted(char* lpszShortPath, char* lpszLongPath, int cchBuffer, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLongPathNameTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpszShortPath, string lpszLongPath, int cchBuffer, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLongPathNameTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpszShortPath, char* lpszLongPath, int cchBuffer, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLongPathNameTransactedW(char* lpszShortPath, string lpszLongPath, int cchBuffer, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLongPathNameTransactedW(char* lpszShortPath, char* lpszLongPath, int cchBuffer, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetProcessAffinityMask(pointer hProcess, pointer unfoundType_PDWORD_PTR_lpProcessAffinityMask, pointer unfoundType_PDWORD_PTR_lpSystemAffinityMask);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetProcessAffinityMask(pointer hProcess, pointer unfoundType_DWORD_PTR_dwProcessAffinityMask);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetProcessIoCounters(pointer hProcess, pointer unfoundType_PIO_COUNTERS_lpIoCounters);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void FatalExit(int ExitCode);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetEnvironmentStringsA(pointer unfoundType_LPCH_NewEnvironment);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void SwitchToFiber(pointer lpFiber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void DeleteFiber(pointer lpFiber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ConvertFiberToThread();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateFiberEx(pointer dwStackCommitSize, pointer dwStackReserveSize, int dwFlags, pointer unfoundType_LPFIBER_START_ROUTINE_lpStartAddress, pointer lpParameter);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer ConvertThreadToFiberEx(pointer lpParameter, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateFiber(pointer dwStackSize, pointer unfoundType_LPFIBER_START_ROUTINE_lpStartAddress, pointer lpParameter);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer ConvertThreadToFiber(pointer lpParameter);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateUmsCompletionList(pointer unfoundType_PUMS_COMPLETION_LIST_UmsCompletionList);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DequeueUmsCompletionListItems(pointer unfoundType_PUMS_COMPLETION_LIST_UmsCompletionList, int WaitTimeOut, pointer unfoundType_PUMS_CONTEXT_UmsThreadList);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetUmsCompletionListEvent(pointer unfoundType_PUMS_COMPLETION_LIST_UmsCompletionList, pointer unfoundType_PHANDLE_UmsCompletionEvent);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ExecuteUmsThread(pointer unfoundType_PUMS_CONTEXT_UmsThread);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UmsThreadYield(pointer SchedulerParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DeleteUmsCompletionList(pointer unfoundType_PUMS_COMPLETION_LIST_UmsCompletionList);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetCurrentUmsThread();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetNextUmsListItem(pointer unfoundType_PUMS_CONTEXT_UmsContext);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryUmsThreadInformation(pointer unfoundType_PUMS_CONTEXT_UmsThread, pointer unfoundType_UMS_THREAD_INFO_CLASS_UmsThreadInfoClass, pointer UmsThreadInformation, uint UmsThreadInformationLength, pointer unfoundType_PULONG_ReturnLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetUmsThreadInformation(pointer unfoundType_PUMS_CONTEXT_UmsThread, pointer unfoundType_UMS_THREAD_INFO_CLASS_UmsThreadInfoClass, pointer UmsThreadInformation, uint UmsThreadInformationLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DeleteUmsThreadContext(pointer unfoundType_PUMS_CONTEXT_UmsThread);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateUmsThreadContext(pointer unfoundType_PUMS_CONTEXTlpUmsThreadlpUmsThread_unnamed_0);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnterUmsSchedulingMode(pointer unfoundType_PUMS_SCHEDULER_STARTUP_INFO_SchedulerStartupInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetUmsSystemThreadInformation(pointer ThreadHandle, pointer unfoundType_PUMS_SYSTEM_THREAD_INFORMATION_SystemThreadInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer SetThreadAffinityMask(pointer hThread, pointer unfoundType_DWORD_PTR_dwThreadAffinityMask);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetProcessDEPPolicy(int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetProcessDEPPolicy(pointer hProcess, pointer unfoundType_LPDWORD_lpFlags, pointer lpPermanent);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool RequestWakeupLatency(pointer unfoundType_LATENCY_TIME_latency);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsSystemResumeAutomatic();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetThreadSelectorEntry(pointer hThread, int dwSelector, pointer unfoundType_LPLDT_ENTRY_lpSelectorEntry);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer SetThreadExecutionState(pointer unfoundType_EXECUTION_STATE_esFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer PowerCreateRequest(pointer unfoundType_PREASON_CONTEXT_Context);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool PowerSetRequest(pointer PowerRequest, pointer unfoundType_POWER_REQUEST_TYPE_RequestType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool PowerClearRequest(pointer PowerRequest, pointer unfoundType_POWER_REQUEST_TYPE_RequestType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFileCompletionNotificationModes(pointer FileHandle, byte Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool Wow64GetThreadSelectorEntry(pointer hThread, int dwSelector, pointer unfoundType_PWOW64_LDT_ENTRY_lpSelectorEntry);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DebugSetProcessKillOnExit(bool KillOnExit);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DebugBreakProcess(pointer Process);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool PulseEvent(pointer hEvent);
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
        bool RequestDeviceWakeup(pointer hDevice);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CancelDeviceWakeupRequest(pointer hDevice);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetDevicePowerState(pointer hDevice, pointer unfoundType_BOOLpfOnpfOn_unnamed_1);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetMessageWaitingIndicator(pointer hMsgIndicator, uint ulMsgCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFileShortNameA(pointer hFile, [MarshalAs(UnmanagedType.LPStr)] string lpShortName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFileShortNameA(pointer hFile, byte* lpShortName);
    [DllImport(lib, EntryPoint = "SetFileShortNameW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFileShortName(pointer hFile, [MarshalAs(UnmanagedType.LPWStr)] string lpShortName);
    [DllImport(lib, EntryPoint = "SetFileShortNameW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFileShortName(pointer hFile, char* lpShortName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFileShortNameW(pointer hFile, [MarshalAs(UnmanagedType.LPWStr)] string lpShortName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFileShortNameW(pointer hFile, char* lpShortName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LoadModule([MarshalAs(UnmanagedType.LPStr)] string lpModuleName, pointer lpParameterBlock);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LoadModule(byte* lpModuleName, pointer lpParameterBlock);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint WinExec([MarshalAs(UnmanagedType.LPStr)] string lpCmdLine, uint uCmdShow);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint WinExec(byte* lpCmdLine, uint uCmdShow);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SetTapePosition(pointer hDevice, int dwPositionMethod, int dwPartition, int dwOffsetLow, int dwOffsetHigh, bool bImmediate);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTapePosition(pointer hDevice, int dwPositionType, pointer unfoundType_LPDWORD_lpdwPartition, pointer unfoundType_LPDWORD_lpdwOffsetLow, pointer unfoundType_LPDWORD_lpdwOffsetHigh);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int PrepareTape(pointer hDevice, int dwOperation, bool bImmediate);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int EraseTape(pointer hDevice, int dwEraseType, bool bImmediate);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CreateTapePartition(pointer hDevice, int dwPartitionMethod, int dwCount, int dwSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int WriteTapemark(pointer hDevice, int dwTapemarkType, int dwTapemarkCount, bool bImmediate);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTapeStatus(pointer hDevice);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTapeParameters(pointer hDevice, int dwOperation, pointer unfoundType_LPDWORD_lpdwSize, pointer lpTapeInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SetTapeParameters(pointer hDevice, int dwOperation, pointer lpTapeInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int MulDiv(int nNumber, int nNumerator, int nDenominator);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetSystemDEPPolicy();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetSystemRegistryQuota(pointer unfoundType_PDWORD_pdwQuotaAllowed, pointer unfoundType_PDWORD_pdwQuotaUsed);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FileTimeToDosDateTime(pointer unfoundType_FILETIMElpFileTimelpFileTime_unnamed_0, pointer unfoundType_LPWORD_lpFatDate, pointer unfoundType_LPWORD_lpFatTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DosDateTimeToFileTime(short wFatDate, short wFatTime, pointer unfoundType_LPFILETIME_lpFileTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FormatMessageA(int dwFlags, pointer lpSource, int dwMessageId, int dwLanguageId, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, int nSize, pointer unfoundType_va_listArgumentsArguments_unnamed_6);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FormatMessageA(int dwFlags, pointer lpSource, int dwMessageId, int dwLanguageId, ReadOnlySpan<byte> lpBuffer, int nSize, pointer unfoundType_va_listArgumentsArguments_unnamed_6);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FormatMessageA(int dwFlags, pointer lpSource, int dwMessageId, int dwLanguageId, byte* lpBuffer, int nSize, pointer unfoundType_va_listArgumentsArguments_unnamed_6);
    [DllImport(lib, EntryPoint = "FormatMessageW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int FormatMessage(int dwFlags, pointer lpSource, int dwMessageId, int dwLanguageId, string lpBuffer, int nSize, pointer unfoundType_va_listArgumentsArguments_unnamed_6);
    [DllImport(lib, EntryPoint = "FormatMessageW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int FormatMessage(int dwFlags, pointer lpSource, int dwMessageId, int dwLanguageId, char* lpBuffer, int nSize, pointer unfoundType_va_listArgumentsArguments_unnamed_6);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FormatMessageW(int dwFlags, pointer lpSource, int dwMessageId, int dwLanguageId, string lpBuffer, int nSize, pointer unfoundType_va_listArgumentsArguments_unnamed_6);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FormatMessageW(int dwFlags, pointer lpSource, int dwMessageId, int dwLanguageId, char* lpBuffer, int nSize, pointer unfoundType_va_listArgumentsArguments_unnamed_6);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateMailslotA([MarshalAs(UnmanagedType.LPStr)] string lpName, int nMaxMessageSize, int lReadTimeout, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateMailslotA(byte* lpName, int nMaxMessageSize, int lReadTimeout, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, EntryPoint = "CreateMailslotW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateMailslot([MarshalAs(UnmanagedType.LPWStr)] string lpName, int nMaxMessageSize, int lReadTimeout, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, EntryPoint = "CreateMailslotW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateMailslot(char* lpName, int nMaxMessageSize, int lReadTimeout, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateMailslotW([MarshalAs(UnmanagedType.LPWStr)] string lpName, int nMaxMessageSize, int lReadTimeout, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateMailslotW(char* lpName, int nMaxMessageSize, int lReadTimeout, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetMailslotInfo(pointer hMailslot, pointer unfoundType_LPDWORD_lpMaxMessageSize, pointer unfoundType_LPDWORD_lpNextSize, pointer unfoundType_LPDWORD_lpMessageCount, pointer unfoundType_LPDWORD_lpReadTimeout);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetMailslotInfo(pointer hMailslot, int lReadTimeout);
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
        int OpenFile([MarshalAs(UnmanagedType.LPStr)] string lpFileName, pointer unfoundType_LPOFSTRUCT_lpReOpenBuff, uint uStyle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int OpenFile(byte* lpFileName, pointer unfoundType_LPOFSTRUCT_lpReOpenBuff, uint uStyle);
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
        uint _lread(int hFile, pointer lpBuffer, uint uBytes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint _lwrite(int hFile, pointer unfoundType_LPCCH_lpBuffer, uint uBytes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int _hread(int hFile, pointer lpBuffer, int lBytes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int _hwrite(int hFile, pointer unfoundType_LPCCH_lpBuffer, int lBytes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int _lclose(int hFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int _llseek(int hFile, int lOffset, int iOrigin);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool BackupRead(pointer hFile, pointer unfoundType_LPBYTE_lpBuffer, int nNumberOfBytesToRead, pointer unfoundType_LPDWORD_lpNumberOfBytesRead, bool bAbort, bool bProcessSecurity, pointer unfoundType_LPVOIDlpContextlpContext_unnamed_6);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool BackupSeek(pointer hFile, int dwLowBytesToSeek, int dwHighBytesToSeek, pointer unfoundType_LPDWORD_lpdwLowByteSeeked, pointer unfoundType_LPDWORD_lpdwHighByteSeeked, pointer unfoundType_LPVOIDlpContextlpContext_unnamed_5);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool BackupWrite(pointer hFile, pointer unfoundType_LPBYTE_lpBuffer, int nNumberOfBytesToWrite, pointer unfoundType_LPDWORD_lpNumberOfBytesWritten, bool bAbort, bool bProcessSecurity, pointer unfoundType_LPVOIDlpContextlpContext_unnamed_6);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenMutexA(int dwDesiredAccess, bool bInheritHandle, [MarshalAs(UnmanagedType.LPStr)] string lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenMutexA(int dwDesiredAccess, bool bInheritHandle, byte* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateSemaphoreA(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, [MarshalAs(UnmanagedType.LPStr)] string lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateSemaphoreA(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, byte* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenSemaphoreA(int dwDesiredAccess, bool bInheritHandle, [MarshalAs(UnmanagedType.LPStr)] string lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenSemaphoreA(int dwDesiredAccess, bool bInheritHandle, byte* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateWaitableTimerA(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpTimerAttributes, bool bManualReset, [MarshalAs(UnmanagedType.LPStr)] string lpTimerName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateWaitableTimerA(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpTimerAttributes, bool bManualReset, byte* lpTimerName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenWaitableTimerA(int dwDesiredAccess, bool bInheritHandle, [MarshalAs(UnmanagedType.LPStr)] string lpTimerName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenWaitableTimerA(int dwDesiredAccess, bool bInheritHandle, byte* lpTimerName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateSemaphoreExA(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, [MarshalAs(UnmanagedType.LPStr)] string lpName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateSemaphoreExA(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, byte* lpName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateWaitableTimerExA(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpTimerAttributes, [MarshalAs(UnmanagedType.LPStr)] string lpTimerName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateWaitableTimerExA(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpTimerAttributes, byte* lpTimerName, int dwFlags, int dwDesiredAccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateFileMappingA(pointer hFile, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpFileMappingAttributes, int flProtect, int dwMaximumSizeHigh, int dwMaximumSizeLow, [MarshalAs(UnmanagedType.LPStr)] string lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateFileMappingA(pointer hFile, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpFileMappingAttributes, int flProtect, int dwMaximumSizeHigh, int dwMaximumSizeLow, byte* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateFileMappingNumaA(pointer hFile, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpFileMappingAttributes, int flProtect, int dwMaximumSizeHigh, int dwMaximumSizeLow, [MarshalAs(UnmanagedType.LPStr)] string lpName, int nndPreferred);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateFileMappingNumaA(pointer hFile, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpFileMappingAttributes, int flProtect, int dwMaximumSizeHigh, int dwMaximumSizeLow, byte* lpName, int nndPreferred);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenFileMappingA(int dwDesiredAccess, bool bInheritHandle, [MarshalAs(UnmanagedType.LPStr)] string lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenFileMappingA(int dwDesiredAccess, bool bInheritHandle, byte* lpName);
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
        bool QueryFullProcessImageNameA(pointer hProcess, int dwFlags, [MarshalAs(UnmanagedType.LPStr)] string lpExeName, pointer unfoundType_PDWORD_lpdwSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryFullProcessImageNameA(pointer hProcess, int dwFlags, ReadOnlySpan<byte> lpExeName, pointer unfoundType_PDWORD_lpdwSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryFullProcessImageNameA(pointer hProcess, int dwFlags, byte* lpExeName, pointer unfoundType_PDWORD_lpdwSize);
    [DllImport(lib, EntryPoint = "QueryFullProcessImageNameW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryFullProcessImageName(pointer hProcess, int dwFlags, string lpExeName, pointer unfoundType_PDWORD_lpdwSize);
    [DllImport(lib, EntryPoint = "QueryFullProcessImageNameW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryFullProcessImageName(pointer hProcess, int dwFlags, char* lpExeName, pointer unfoundType_PDWORD_lpdwSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryFullProcessImageNameW(pointer hProcess, int dwFlags, string lpExeName, pointer unfoundType_PDWORD_lpdwSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryFullProcessImageNameW(pointer hProcess, int dwFlags, char* lpExeName, pointer unfoundType_PDWORD_lpdwSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void GetStartupInfoA(pointer unfoundType_LPSTARTUPINFOA_lpStartupInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariableA([MarshalAs(UnmanagedType.LPStr)] string lpName, [MarshalAs(UnmanagedType.LPStr)] string lpGuid, pointer pBuffer, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariableA([MarshalAs(UnmanagedType.LPStr)] string lpName, byte* lpGuid, pointer pBuffer, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariableA(byte* lpName, [MarshalAs(UnmanagedType.LPStr)] string lpGuid, pointer pBuffer, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariableA(byte* lpName, byte* lpGuid, pointer pBuffer, int nSize);
    [DllImport(lib, EntryPoint = "GetFirmwareEnvironmentVariableW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariable([MarshalAs(UnmanagedType.LPWStr)] string lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, pointer pBuffer, int nSize);
    [DllImport(lib, EntryPoint = "GetFirmwareEnvironmentVariableW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariable([MarshalAs(UnmanagedType.LPWStr)] string lpName, char* lpGuid, pointer pBuffer, int nSize);
    [DllImport(lib, EntryPoint = "GetFirmwareEnvironmentVariableW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariable(char* lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, pointer pBuffer, int nSize);
    [DllImport(lib, EntryPoint = "GetFirmwareEnvironmentVariableW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariable(char* lpName, char* lpGuid, pointer pBuffer, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariableW([MarshalAs(UnmanagedType.LPWStr)] string lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, pointer pBuffer, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariableW([MarshalAs(UnmanagedType.LPWStr)] string lpName, char* lpGuid, pointer pBuffer, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariableW(char* lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, pointer pBuffer, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariableW(char* lpName, char* lpGuid, pointer pBuffer, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariableExA([MarshalAs(UnmanagedType.LPStr)] string lpName, [MarshalAs(UnmanagedType.LPStr)] string lpGuid, pointer pBuffer, int nSize, pointer unfoundType_PDWORD_pdwAttribubutes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariableExA([MarshalAs(UnmanagedType.LPStr)] string lpName, byte* lpGuid, pointer pBuffer, int nSize, pointer unfoundType_PDWORD_pdwAttribubutes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariableExA(byte* lpName, [MarshalAs(UnmanagedType.LPStr)] string lpGuid, pointer pBuffer, int nSize, pointer unfoundType_PDWORD_pdwAttribubutes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariableExA(byte* lpName, byte* lpGuid, pointer pBuffer, int nSize, pointer unfoundType_PDWORD_pdwAttribubutes);
    [DllImport(lib, EntryPoint = "GetFirmwareEnvironmentVariableExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariableEx([MarshalAs(UnmanagedType.LPWStr)] string lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, pointer pBuffer, int nSize, pointer unfoundType_PDWORD_pdwAttribubutes);
    [DllImport(lib, EntryPoint = "GetFirmwareEnvironmentVariableExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariableEx([MarshalAs(UnmanagedType.LPWStr)] string lpName, char* lpGuid, pointer pBuffer, int nSize, pointer unfoundType_PDWORD_pdwAttribubutes);
    [DllImport(lib, EntryPoint = "GetFirmwareEnvironmentVariableExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariableEx(char* lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, pointer pBuffer, int nSize, pointer unfoundType_PDWORD_pdwAttribubutes);
    [DllImport(lib, EntryPoint = "GetFirmwareEnvironmentVariableExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariableEx(char* lpName, char* lpGuid, pointer pBuffer, int nSize, pointer unfoundType_PDWORD_pdwAttribubutes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariableExW([MarshalAs(UnmanagedType.LPWStr)] string lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, pointer pBuffer, int nSize, pointer unfoundType_PDWORD_pdwAttribubutes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariableExW([MarshalAs(UnmanagedType.LPWStr)] string lpName, char* lpGuid, pointer pBuffer, int nSize, pointer unfoundType_PDWORD_pdwAttribubutes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariableExW(char* lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, pointer pBuffer, int nSize, pointer unfoundType_PDWORD_pdwAttribubutes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFirmwareEnvironmentVariableExW(char* lpName, char* lpGuid, pointer pBuffer, int nSize, pointer unfoundType_PDWORD_pdwAttribubutes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariableA([MarshalAs(UnmanagedType.LPStr)] string lpName, [MarshalAs(UnmanagedType.LPStr)] string lpGuid, pointer pValue, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariableA([MarshalAs(UnmanagedType.LPStr)] string lpName, byte* lpGuid, pointer pValue, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariableA(byte* lpName, [MarshalAs(UnmanagedType.LPStr)] string lpGuid, pointer pValue, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariableA(byte* lpName, byte* lpGuid, pointer pValue, int nSize);
    [DllImport(lib, EntryPoint = "SetFirmwareEnvironmentVariableW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariable([MarshalAs(UnmanagedType.LPWStr)] string lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, pointer pValue, int nSize);
    [DllImport(lib, EntryPoint = "SetFirmwareEnvironmentVariableW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariable([MarshalAs(UnmanagedType.LPWStr)] string lpName, char* lpGuid, pointer pValue, int nSize);
    [DllImport(lib, EntryPoint = "SetFirmwareEnvironmentVariableW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariable(char* lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, pointer pValue, int nSize);
    [DllImport(lib, EntryPoint = "SetFirmwareEnvironmentVariableW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariable(char* lpName, char* lpGuid, pointer pValue, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariableW([MarshalAs(UnmanagedType.LPWStr)] string lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, pointer pValue, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariableW([MarshalAs(UnmanagedType.LPWStr)] string lpName, char* lpGuid, pointer pValue, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariableW(char* lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, pointer pValue, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariableW(char* lpName, char* lpGuid, pointer pValue, int nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariableExA([MarshalAs(UnmanagedType.LPStr)] string lpName, [MarshalAs(UnmanagedType.LPStr)] string lpGuid, pointer pValue, int nSize, int dwAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariableExA([MarshalAs(UnmanagedType.LPStr)] string lpName, byte* lpGuid, pointer pValue, int nSize, int dwAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariableExA(byte* lpName, [MarshalAs(UnmanagedType.LPStr)] string lpGuid, pointer pValue, int nSize, int dwAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariableExA(byte* lpName, byte* lpGuid, pointer pValue, int nSize, int dwAttributes);
    [DllImport(lib, EntryPoint = "SetFirmwareEnvironmentVariableExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariableEx([MarshalAs(UnmanagedType.LPWStr)] string lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, pointer pValue, int nSize, int dwAttributes);
    [DllImport(lib, EntryPoint = "SetFirmwareEnvironmentVariableExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariableEx([MarshalAs(UnmanagedType.LPWStr)] string lpName, char* lpGuid, pointer pValue, int nSize, int dwAttributes);
    [DllImport(lib, EntryPoint = "SetFirmwareEnvironmentVariableExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariableEx(char* lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, pointer pValue, int nSize, int dwAttributes);
    [DllImport(lib, EntryPoint = "SetFirmwareEnvironmentVariableExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariableEx(char* lpName, char* lpGuid, pointer pValue, int nSize, int dwAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariableExW([MarshalAs(UnmanagedType.LPWStr)] string lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, pointer pValue, int nSize, int dwAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariableExW([MarshalAs(UnmanagedType.LPWStr)] string lpName, char* lpGuid, pointer pValue, int nSize, int dwAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariableExW(char* lpName, [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, pointer pValue, int nSize, int dwAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFirmwareEnvironmentVariableExW(char* lpName, char* lpGuid, pointer pValue, int nSize, int dwAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFirmwareType(pointer unfoundType_PFIRMWARE_TYPE_FirmwareType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsNativeVhdBoot(pointer NativeVhdBoot);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindResourceA(pointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPStr)] string lpName, [MarshalAs(UnmanagedType.LPStr)] string lpType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindResourceA(pointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPStr)] string lpName, byte* lpType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindResourceA(pointer unfoundType_HMODULE_hModule, byte* lpName, [MarshalAs(UnmanagedType.LPStr)] string lpType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindResourceA(pointer unfoundType_HMODULE_hModule, byte* lpName, byte* lpType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindResourceExA(pointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPStr)] string lpType, [MarshalAs(UnmanagedType.LPStr)] string lpName, short wLanguage);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindResourceExA(pointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPStr)] string lpType, byte* lpName, short wLanguage);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindResourceExA(pointer unfoundType_HMODULE_hModule, byte* lpType, [MarshalAs(UnmanagedType.LPStr)] string lpName, short wLanguage);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindResourceExA(pointer unfoundType_HMODULE_hModule, byte* lpType, byte* lpName, short wLanguage);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceTypesA(pointer unfoundType_HMODULE_hModule, pointer unfoundType_ENUMRESTYPEPROCA_lpEnumFunc, long lParam);
    [DllImport(lib, EntryPoint = "EnumResourceTypesW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceTypes(pointer unfoundType_HMODULE_hModule, pointer unfoundType_ENUMRESTYPEPROCW_lpEnumFunc, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceTypesW(pointer unfoundType_HMODULE_hModule, pointer unfoundType_ENUMRESTYPEPROCW_lpEnumFunc, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguagesA(pointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPStr)] string lpType, [MarshalAs(UnmanagedType.LPStr)] string lpName, pointer unfoundType_ENUMRESLANGPROCA_lpEnumFunc, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguagesA(pointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPStr)] string lpType, byte* lpName, pointer unfoundType_ENUMRESLANGPROCA_lpEnumFunc, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguagesA(pointer unfoundType_HMODULE_hModule, byte* lpType, [MarshalAs(UnmanagedType.LPStr)] string lpName, pointer unfoundType_ENUMRESLANGPROCA_lpEnumFunc, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguagesA(pointer unfoundType_HMODULE_hModule, byte* lpType, byte* lpName, pointer unfoundType_ENUMRESLANGPROCA_lpEnumFunc, long lParam);
    [DllImport(lib, EntryPoint = "EnumResourceLanguagesW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguages(pointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, pointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam);
    [DllImport(lib, EntryPoint = "EnumResourceLanguagesW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguages(pointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, char* lpName, pointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam);
    [DllImport(lib, EntryPoint = "EnumResourceLanguagesW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguages(pointer unfoundType_HMODULE_hModule, char* lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, pointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam);
    [DllImport(lib, EntryPoint = "EnumResourceLanguagesW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguages(pointer unfoundType_HMODULE_hModule, char* lpType, char* lpName, pointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguagesW(pointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, pointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguagesW(pointer unfoundType_HMODULE_hModule, [MarshalAs(UnmanagedType.LPWStr)] string lpType, char* lpName, pointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguagesW(pointer unfoundType_HMODULE_hModule, char* lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, pointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumResourceLanguagesW(pointer unfoundType_HMODULE_hModule, char* lpType, char* lpName, pointer unfoundType_ENUMRESLANGPROCW_lpEnumFunc, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer BeginUpdateResourceA([MarshalAs(UnmanagedType.LPStr)] string pFileName, bool bDeleteExistingResources);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer BeginUpdateResourceA(byte* pFileName, bool bDeleteExistingResources);
    [DllImport(lib, EntryPoint = "BeginUpdateResourceW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer BeginUpdateResource([MarshalAs(UnmanagedType.LPWStr)] string pFileName, bool bDeleteExistingResources);
    [DllImport(lib, EntryPoint = "BeginUpdateResourceW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer BeginUpdateResource(char* pFileName, bool bDeleteExistingResources);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer BeginUpdateResourceW([MarshalAs(UnmanagedType.LPWStr)] string pFileName, bool bDeleteExistingResources);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer BeginUpdateResourceW(char* pFileName, bool bDeleteExistingResources);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UpdateResourceA(pointer hUpdate, [MarshalAs(UnmanagedType.LPStr)] string lpType, [MarshalAs(UnmanagedType.LPStr)] string lpName, short wLanguage, pointer lpData, int cb);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UpdateResourceA(pointer hUpdate, [MarshalAs(UnmanagedType.LPStr)] string lpType, byte* lpName, short wLanguage, pointer lpData, int cb);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UpdateResourceA(pointer hUpdate, byte* lpType, [MarshalAs(UnmanagedType.LPStr)] string lpName, short wLanguage, pointer lpData, int cb);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UpdateResourceA(pointer hUpdate, byte* lpType, byte* lpName, short wLanguage, pointer lpData, int cb);
    [DllImport(lib, EntryPoint = "UpdateResourceW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UpdateResource(pointer hUpdate, [MarshalAs(UnmanagedType.LPWStr)] string lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, short wLanguage, pointer lpData, int cb);
    [DllImport(lib, EntryPoint = "UpdateResourceW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UpdateResource(pointer hUpdate, [MarshalAs(UnmanagedType.LPWStr)] string lpType, char* lpName, short wLanguage, pointer lpData, int cb);
    [DllImport(lib, EntryPoint = "UpdateResourceW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UpdateResource(pointer hUpdate, char* lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, short wLanguage, pointer lpData, int cb);
    [DllImport(lib, EntryPoint = "UpdateResourceW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UpdateResource(pointer hUpdate, char* lpType, char* lpName, short wLanguage, pointer lpData, int cb);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UpdateResourceW(pointer hUpdate, [MarshalAs(UnmanagedType.LPWStr)] string lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, short wLanguage, pointer lpData, int cb);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UpdateResourceW(pointer hUpdate, [MarshalAs(UnmanagedType.LPWStr)] string lpType, char* lpName, short wLanguage, pointer lpData, int cb);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UpdateResourceW(pointer hUpdate, char* lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpName, short wLanguage, pointer lpData, int cb);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UpdateResourceW(pointer hUpdate, char* lpType, char* lpName, short wLanguage, pointer lpData, int cb);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EndUpdateResourceA(pointer hUpdate, bool fDiscard);
    [DllImport(lib, EntryPoint = "EndUpdateResourceW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EndUpdateResource(pointer hUpdate, bool fDiscard);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EndUpdateResourceW(pointer hUpdate, bool fDiscard);
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
        bool GetPrivateProfileStructA([MarshalAs(UnmanagedType.LPStr)] string lpszSection, [MarshalAs(UnmanagedType.LPStr)] string lpszKey, pointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPStr)] string szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStructA([MarshalAs(UnmanagedType.LPStr)] string lpszSection, [MarshalAs(UnmanagedType.LPStr)] string lpszKey, pointer lpStruct, uint uSizeStruct, byte* szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStructA([MarshalAs(UnmanagedType.LPStr)] string lpszSection, byte* lpszKey, pointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPStr)] string szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStructA([MarshalAs(UnmanagedType.LPStr)] string lpszSection, byte* lpszKey, pointer lpStruct, uint uSizeStruct, byte* szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStructA(byte* lpszSection, [MarshalAs(UnmanagedType.LPStr)] string lpszKey, pointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPStr)] string szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStructA(byte* lpszSection, [MarshalAs(UnmanagedType.LPStr)] string lpszKey, pointer lpStruct, uint uSizeStruct, byte* szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStructA(byte* lpszSection, byte* lpszKey, pointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPStr)] string szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStructA(byte* lpszSection, byte* lpszKey, pointer lpStruct, uint uSizeStruct, byte* szFile);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStructW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStruct([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, pointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStructW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStruct([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, pointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStructW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStruct([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, char* lpszKey, pointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStructW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStruct([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, char* lpszKey, pointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStructW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStruct(char* lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, pointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStructW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStruct(char* lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, pointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStructW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStruct(char* lpszSection, char* lpszKey, pointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport(lib, EntryPoint = "GetPrivateProfileStructW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStruct(char* lpszSection, char* lpszKey, pointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStructW([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, pointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStructW([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, pointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStructW([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, char* lpszKey, pointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStructW([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, char* lpszKey, pointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStructW(char* lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, pointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStructW(char* lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, pointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStructW(char* lpszSection, char* lpszKey, pointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPrivateProfileStructW(char* lpszSection, char* lpszKey, pointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStructA([MarshalAs(UnmanagedType.LPStr)] string lpszSection, [MarshalAs(UnmanagedType.LPStr)] string lpszKey, pointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPStr)] string szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStructA([MarshalAs(UnmanagedType.LPStr)] string lpszSection, [MarshalAs(UnmanagedType.LPStr)] string lpszKey, pointer lpStruct, uint uSizeStruct, byte* szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStructA([MarshalAs(UnmanagedType.LPStr)] string lpszSection, byte* lpszKey, pointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPStr)] string szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStructA([MarshalAs(UnmanagedType.LPStr)] string lpszSection, byte* lpszKey, pointer lpStruct, uint uSizeStruct, byte* szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStructA(byte* lpszSection, [MarshalAs(UnmanagedType.LPStr)] string lpszKey, pointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPStr)] string szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStructA(byte* lpszSection, [MarshalAs(UnmanagedType.LPStr)] string lpszKey, pointer lpStruct, uint uSizeStruct, byte* szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStructA(byte* lpszSection, byte* lpszKey, pointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPStr)] string szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStructA(byte* lpszSection, byte* lpszKey, pointer lpStruct, uint uSizeStruct, byte* szFile);
    [DllImport(lib, EntryPoint = "WritePrivateProfileStructW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStruct([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, pointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport(lib, EntryPoint = "WritePrivateProfileStructW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStruct([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, pointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport(lib, EntryPoint = "WritePrivateProfileStructW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStruct([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, char* lpszKey, pointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport(lib, EntryPoint = "WritePrivateProfileStructW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStruct([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, char* lpszKey, pointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport(lib, EntryPoint = "WritePrivateProfileStructW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStruct(char* lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, pointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport(lib, EntryPoint = "WritePrivateProfileStructW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStruct(char* lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, pointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport(lib, EntryPoint = "WritePrivateProfileStructW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStruct(char* lpszSection, char* lpszKey, pointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport(lib, EntryPoint = "WritePrivateProfileStructW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStruct(char* lpszSection, char* lpszKey, pointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStructW([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, pointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStructW([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, pointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStructW([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, char* lpszKey, pointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStructW([MarshalAs(UnmanagedType.LPWStr)] string lpszSection, char* lpszKey, pointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStructW(char* lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, pointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStructW(char* lpszSection, [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, pointer lpStruct, uint uSizeStruct, char* szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStructW(char* lpszSection, char* lpszKey, pointer lpStruct, uint uSizeStruct, [MarshalAs(UnmanagedType.LPWStr)] string szFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WritePrivateProfileStructW(char* lpszSection, char* lpszKey, pointer lpStruct, uint uSizeStruct, char* szFile);
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
        bool CreateDirectoryExA([MarshalAs(UnmanagedType.LPStr)] string lpTemplateDirectory, [MarshalAs(UnmanagedType.LPStr)] string lpNewDirectory, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryExA([MarshalAs(UnmanagedType.LPStr)] string lpTemplateDirectory, byte* lpNewDirectory, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryExA(byte* lpTemplateDirectory, [MarshalAs(UnmanagedType.LPStr)] string lpNewDirectory, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryExA(byte* lpTemplateDirectory, byte* lpNewDirectory, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, EntryPoint = "CreateDirectoryExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryEx([MarshalAs(UnmanagedType.LPWStr)] string lpTemplateDirectory, [MarshalAs(UnmanagedType.LPWStr)] string lpNewDirectory, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, EntryPoint = "CreateDirectoryExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryEx([MarshalAs(UnmanagedType.LPWStr)] string lpTemplateDirectory, char* lpNewDirectory, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, EntryPoint = "CreateDirectoryExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryEx(char* lpTemplateDirectory, [MarshalAs(UnmanagedType.LPWStr)] string lpNewDirectory, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, EntryPoint = "CreateDirectoryExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryEx(char* lpTemplateDirectory, char* lpNewDirectory, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryExW([MarshalAs(UnmanagedType.LPWStr)] string lpTemplateDirectory, [MarshalAs(UnmanagedType.LPWStr)] string lpNewDirectory, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryExW([MarshalAs(UnmanagedType.LPWStr)] string lpTemplateDirectory, char* lpNewDirectory, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryExW(char* lpTemplateDirectory, [MarshalAs(UnmanagedType.LPWStr)] string lpNewDirectory, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryExW(char* lpTemplateDirectory, char* lpNewDirectory, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpTemplateDirectory, [MarshalAs(UnmanagedType.LPStr)] string lpNewDirectory, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpTemplateDirectory, byte* lpNewDirectory, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryTransactedA(byte* lpTemplateDirectory, [MarshalAs(UnmanagedType.LPStr)] string lpNewDirectory, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryTransactedA(byte* lpTemplateDirectory, byte* lpNewDirectory, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, pointer hTransaction);
    [DllImport(lib, EntryPoint = "CreateDirectoryTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpTemplateDirectory, [MarshalAs(UnmanagedType.LPWStr)] string lpNewDirectory, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, pointer hTransaction);
    [DllImport(lib, EntryPoint = "CreateDirectoryTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpTemplateDirectory, char* lpNewDirectory, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, pointer hTransaction);
    [DllImport(lib, EntryPoint = "CreateDirectoryTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryTransacted(char* lpTemplateDirectory, [MarshalAs(UnmanagedType.LPWStr)] string lpNewDirectory, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, pointer hTransaction);
    [DllImport(lib, EntryPoint = "CreateDirectoryTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryTransacted(char* lpTemplateDirectory, char* lpNewDirectory, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpTemplateDirectory, [MarshalAs(UnmanagedType.LPWStr)] string lpNewDirectory, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpTemplateDirectory, char* lpNewDirectory, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryTransactedW(char* lpTemplateDirectory, [MarshalAs(UnmanagedType.LPWStr)] string lpNewDirectory, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateDirectoryTransactedW(char* lpTemplateDirectory, char* lpNewDirectory, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool RemoveDirectoryTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpPathName, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool RemoveDirectoryTransactedA(byte* lpPathName, pointer hTransaction);
    [DllImport(lib, EntryPoint = "RemoveDirectoryTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool RemoveDirectoryTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpPathName, pointer hTransaction);
    [DllImport(lib, EntryPoint = "RemoveDirectoryTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool RemoveDirectoryTransacted(char* lpPathName, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool RemoveDirectoryTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpPathName, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool RemoveDirectoryTransactedW(char* lpPathName, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, pointer unfoundType_LPSTRlpFilePartlpFilePart_unnamed_3, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, int nBufferLength, ReadOnlySpan<byte> lpBuffer, pointer unfoundType_LPSTRlpFilePartlpFilePart_unnamed_3, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, int nBufferLength, byte* lpBuffer, pointer unfoundType_LPSTRlpFilePartlpFilePart_unnamed_3, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameTransactedA(byte* lpFileName, int nBufferLength, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, pointer unfoundType_LPSTRlpFilePartlpFilePart_unnamed_3, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameTransactedA(byte* lpFileName, int nBufferLength, ReadOnlySpan<byte> lpBuffer, pointer unfoundType_LPSTRlpFilePartlpFilePart_unnamed_3, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameTransactedA(byte* lpFileName, int nBufferLength, byte* lpBuffer, pointer unfoundType_LPSTRlpFilePartlpFilePart_unnamed_3, pointer hTransaction);
    [DllImport(lib, EntryPoint = "GetFullPathNameTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int nBufferLength, string lpBuffer, pointer unfoundType_LPWSTRlpFilePartlpFilePart_unnamed_3, pointer hTransaction);
    [DllImport(lib, EntryPoint = "GetFullPathNameTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int nBufferLength, char* lpBuffer, pointer unfoundType_LPWSTRlpFilePartlpFilePart_unnamed_3, pointer hTransaction);
    [DllImport(lib, EntryPoint = "GetFullPathNameTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameTransacted(char* lpFileName, int nBufferLength, string lpBuffer, pointer unfoundType_LPWSTRlpFilePartlpFilePart_unnamed_3, pointer hTransaction);
    [DllImport(lib, EntryPoint = "GetFullPathNameTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameTransacted(char* lpFileName, int nBufferLength, char* lpBuffer, pointer unfoundType_LPWSTRlpFilePartlpFilePart_unnamed_3, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int nBufferLength, string lpBuffer, pointer unfoundType_LPWSTRlpFilePartlpFilePart_unnamed_3, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int nBufferLength, char* lpBuffer, pointer unfoundType_LPWSTRlpFilePartlpFilePart_unnamed_3, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameTransactedW(char* lpFileName, int nBufferLength, string lpBuffer, pointer unfoundType_LPWSTRlpFilePartlpFilePart_unnamed_3, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetFullPathNameTransactedW(char* lpFileName, int nBufferLength, char* lpBuffer, pointer unfoundType_LPWSTRlpFilePartlpFilePart_unnamed_3, pointer hTransaction);
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
        pointer CreateFileTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, int dwDesiredAccess, int dwShareMode, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, pointer hTemplateFile, pointer hTransaction, pointer unfoundType_PUSHORT_pusMiniVersion, pointer lpExtendedParameter);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateFileTransactedA(byte* lpFileName, int dwDesiredAccess, int dwShareMode, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, pointer hTemplateFile, pointer hTransaction, pointer unfoundType_PUSHORT_pusMiniVersion, pointer lpExtendedParameter);
    [DllImport(lib, EntryPoint = "CreateFileTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateFileTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwDesiredAccess, int dwShareMode, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, pointer hTemplateFile, pointer hTransaction, pointer unfoundType_PUSHORT_pusMiniVersion, pointer lpExtendedParameter);
    [DllImport(lib, EntryPoint = "CreateFileTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateFileTransacted(char* lpFileName, int dwDesiredAccess, int dwShareMode, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, pointer hTemplateFile, pointer hTransaction, pointer unfoundType_PUSHORT_pusMiniVersion, pointer lpExtendedParameter);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateFileTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwDesiredAccess, int dwShareMode, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, pointer hTemplateFile, pointer hTransaction, pointer unfoundType_PUSHORT_pusMiniVersion, pointer lpExtendedParameter);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateFileTransactedW(char* lpFileName, int dwDesiredAccess, int dwShareMode, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, pointer hTemplateFile, pointer hTransaction, pointer unfoundType_PUSHORT_pusMiniVersion, pointer lpExtendedParameter);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer ReOpenFile(pointer hOriginalFile, int dwDesiredAccess, int dwShareMode, int dwFlagsAndAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFileAttributesTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, int dwFileAttributes, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFileAttributesTransactedA(byte* lpFileName, int dwFileAttributes, pointer hTransaction);
    [DllImport(lib, EntryPoint = "SetFileAttributesTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFileAttributesTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwFileAttributes, pointer hTransaction);
    [DllImport(lib, EntryPoint = "SetFileAttributesTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFileAttributesTransacted(char* lpFileName, int dwFileAttributes, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFileAttributesTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwFileAttributes, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetFileAttributesTransactedW(char* lpFileName, int dwFileAttributes, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileAttributesTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, pointer unfoundType_GET_FILEEX_INFO_LEVELS_fInfoLevelId, pointer lpFileInformation, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileAttributesTransactedA(byte* lpFileName, pointer unfoundType_GET_FILEEX_INFO_LEVELS_fInfoLevelId, pointer lpFileInformation, pointer hTransaction);
    [DllImport(lib, EntryPoint = "GetFileAttributesTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileAttributesTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, pointer unfoundType_GET_FILEEX_INFO_LEVELS_fInfoLevelId, pointer lpFileInformation, pointer hTransaction);
    [DllImport(lib, EntryPoint = "GetFileAttributesTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileAttributesTransacted(char* lpFileName, pointer unfoundType_GET_FILEEX_INFO_LEVELS_fInfoLevelId, pointer lpFileInformation, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileAttributesTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, pointer unfoundType_GET_FILEEX_INFO_LEVELS_fInfoLevelId, pointer lpFileInformation, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileAttributesTransactedW(char* lpFileName, pointer unfoundType_GET_FILEEX_INFO_LEVELS_fInfoLevelId, pointer lpFileInformation, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCompressedFileSizeTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, pointer unfoundType_LPDWORD_lpFileSizeHigh, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCompressedFileSizeTransactedA(byte* lpFileName, pointer unfoundType_LPDWORD_lpFileSizeHigh, pointer hTransaction);
    [DllImport(lib, EntryPoint = "GetCompressedFileSizeTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCompressedFileSizeTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, pointer unfoundType_LPDWORD_lpFileSizeHigh, pointer hTransaction);
    [DllImport(lib, EntryPoint = "GetCompressedFileSizeTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCompressedFileSizeTransacted(char* lpFileName, pointer unfoundType_LPDWORD_lpFileSizeHigh, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCompressedFileSizeTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, pointer unfoundType_LPDWORD_lpFileSizeHigh, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCompressedFileSizeTransactedW(char* lpFileName, pointer unfoundType_LPDWORD_lpFileSizeHigh, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DeleteFileTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DeleteFileTransactedA(byte* lpFileName, pointer hTransaction);
    [DllImport(lib, EntryPoint = "DeleteFileTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DeleteFileTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, pointer hTransaction);
    [DllImport(lib, EntryPoint = "DeleteFileTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DeleteFileTransacted(char* lpFileName, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DeleteFileTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DeleteFileTransactedW(char* lpFileName, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckNameLegalDOS8Dot3A([MarshalAs(UnmanagedType.LPStr)] string lpName, [MarshalAs(UnmanagedType.LPStr)] string lpOemName, int OemNameSize, pointer pbNameContainsSpaces, pointer pbNameLegal);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckNameLegalDOS8Dot3A([MarshalAs(UnmanagedType.LPStr)] string lpName, ReadOnlySpan<byte> lpOemName, int OemNameSize, pointer pbNameContainsSpaces, pointer pbNameLegal);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckNameLegalDOS8Dot3A([MarshalAs(UnmanagedType.LPStr)] string lpName, byte* lpOemName, int OemNameSize, pointer pbNameContainsSpaces, pointer pbNameLegal);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckNameLegalDOS8Dot3A(byte* lpName, [MarshalAs(UnmanagedType.LPStr)] string lpOemName, int OemNameSize, pointer pbNameContainsSpaces, pointer pbNameLegal);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckNameLegalDOS8Dot3A(byte* lpName, ReadOnlySpan<byte> lpOemName, int OemNameSize, pointer pbNameContainsSpaces, pointer pbNameLegal);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckNameLegalDOS8Dot3A(byte* lpName, byte* lpOemName, int OemNameSize, pointer pbNameContainsSpaces, pointer pbNameLegal);
    [DllImport(lib, EntryPoint = "CheckNameLegalDOS8Dot3W", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckNameLegalDOS8Dot3([MarshalAs(UnmanagedType.LPWStr)] string lpName, [MarshalAs(UnmanagedType.LPStr)] string lpOemName, int OemNameSize, pointer pbNameContainsSpaces, pointer pbNameLegal);
    [DllImport(lib, EntryPoint = "CheckNameLegalDOS8Dot3W", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckNameLegalDOS8Dot3([MarshalAs(UnmanagedType.LPWStr)] string lpName, ReadOnlySpan<byte> lpOemName, int OemNameSize, pointer pbNameContainsSpaces, pointer pbNameLegal);
    [DllImport(lib, EntryPoint = "CheckNameLegalDOS8Dot3W", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckNameLegalDOS8Dot3([MarshalAs(UnmanagedType.LPWStr)] string lpName, byte* lpOemName, int OemNameSize, pointer pbNameContainsSpaces, pointer pbNameLegal);
    [DllImport(lib, EntryPoint = "CheckNameLegalDOS8Dot3W", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckNameLegalDOS8Dot3(char* lpName, [MarshalAs(UnmanagedType.LPStr)] string lpOemName, int OemNameSize, pointer pbNameContainsSpaces, pointer pbNameLegal);
    [DllImport(lib, EntryPoint = "CheckNameLegalDOS8Dot3W", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckNameLegalDOS8Dot3(char* lpName, ReadOnlySpan<byte> lpOemName, int OemNameSize, pointer pbNameContainsSpaces, pointer pbNameLegal);
    [DllImport(lib, EntryPoint = "CheckNameLegalDOS8Dot3W", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckNameLegalDOS8Dot3(char* lpName, byte* lpOemName, int OemNameSize, pointer pbNameContainsSpaces, pointer pbNameLegal);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckNameLegalDOS8Dot3W([MarshalAs(UnmanagedType.LPWStr)] string lpName, [MarshalAs(UnmanagedType.LPStr)] string lpOemName, int OemNameSize, pointer pbNameContainsSpaces, pointer pbNameLegal);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckNameLegalDOS8Dot3W([MarshalAs(UnmanagedType.LPWStr)] string lpName, ReadOnlySpan<byte> lpOemName, int OemNameSize, pointer pbNameContainsSpaces, pointer pbNameLegal);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckNameLegalDOS8Dot3W([MarshalAs(UnmanagedType.LPWStr)] string lpName, byte* lpOemName, int OemNameSize, pointer pbNameContainsSpaces, pointer pbNameLegal);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckNameLegalDOS8Dot3W(char* lpName, [MarshalAs(UnmanagedType.LPStr)] string lpOemName, int OemNameSize, pointer pbNameContainsSpaces, pointer pbNameLegal);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckNameLegalDOS8Dot3W(char* lpName, ReadOnlySpan<byte> lpOemName, int OemNameSize, pointer pbNameContainsSpaces, pointer pbNameLegal);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckNameLegalDOS8Dot3W(char* lpName, byte* lpOemName, int OemNameSize, pointer pbNameContainsSpaces, pointer pbNameLegal);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstFileTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, pointer unfoundType_FINDEX_INFO_LEVELS_fInfoLevelId, pointer lpFindFileData, pointer unfoundType_FINDEX_SEARCH_OPS_fSearchOp, pointer lpSearchFilter, int dwAdditionalFlags, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstFileTransactedA(byte* lpFileName, pointer unfoundType_FINDEX_INFO_LEVELS_fInfoLevelId, pointer lpFindFileData, pointer unfoundType_FINDEX_SEARCH_OPS_fSearchOp, pointer lpSearchFilter, int dwAdditionalFlags, pointer hTransaction);
    [DllImport(lib, EntryPoint = "FindFirstFileTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstFileTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, pointer unfoundType_FINDEX_INFO_LEVELS_fInfoLevelId, pointer lpFindFileData, pointer unfoundType_FINDEX_SEARCH_OPS_fSearchOp, pointer lpSearchFilter, int dwAdditionalFlags, pointer hTransaction);
    [DllImport(lib, EntryPoint = "FindFirstFileTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstFileTransacted(char* lpFileName, pointer unfoundType_FINDEX_INFO_LEVELS_fInfoLevelId, pointer lpFindFileData, pointer unfoundType_FINDEX_SEARCH_OPS_fSearchOp, pointer lpSearchFilter, int dwAdditionalFlags, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstFileTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, pointer unfoundType_FINDEX_INFO_LEVELS_fInfoLevelId, pointer lpFindFileData, pointer unfoundType_FINDEX_SEARCH_OPS_fSearchOp, pointer lpSearchFilter, int dwAdditionalFlags, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstFileTransactedW(char* lpFileName, pointer unfoundType_FINDEX_INFO_LEVELS_fInfoLevelId, pointer lpFindFileData, pointer unfoundType_FINDEX_SEARCH_OPS_fSearchOp, pointer lpSearchFilter, int dwAdditionalFlags, pointer hTransaction);
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
        bool CopyFileExA([MarshalAs(UnmanagedType.LPStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPStr)] string lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, pointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileExA([MarshalAs(UnmanagedType.LPStr)] string lpExistingFileName, byte* lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, pointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileExA(byte* lpExistingFileName, [MarshalAs(UnmanagedType.LPStr)] string lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, pointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileExA(byte* lpExistingFileName, byte* lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, pointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags);
    [DllImport(lib, EntryPoint = "CopyFileExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileEx([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, pointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags);
    [DllImport(lib, EntryPoint = "CopyFileExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileEx([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, char* lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, pointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags);
    [DllImport(lib, EntryPoint = "CopyFileExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileEx(char* lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, pointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags);
    [DllImport(lib, EntryPoint = "CopyFileExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileEx(char* lpExistingFileName, char* lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, pointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileExW([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, pointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileExW([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, char* lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, pointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileExW(char* lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, pointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileExW(char* lpExistingFileName, char* lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, pointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPStr)] string lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, pointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpExistingFileName, byte* lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, pointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileTransactedA(byte* lpExistingFileName, [MarshalAs(UnmanagedType.LPStr)] string lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, pointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileTransactedA(byte* lpExistingFileName, byte* lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, pointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags, pointer hTransaction);
    [DllImport(lib, EntryPoint = "CopyFileTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, pointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags, pointer hTransaction);
    [DllImport(lib, EntryPoint = "CopyFileTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, char* lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, pointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags, pointer hTransaction);
    [DllImport(lib, EntryPoint = "CopyFileTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileTransacted(char* lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, pointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags, pointer hTransaction);
    [DllImport(lib, EntryPoint = "CopyFileTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileTransacted(char* lpExistingFileName, char* lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, pointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, pointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, char* lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, pointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileTransactedW(char* lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, pointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyFileTransactedW(char* lpExistingFileName, char* lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, pointer unfoundType_LPBOOL_pbCancel, int dwCopyFlags, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CopyFile2([MarshalAs(UnmanagedType.LPWStr)] string pwszExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string pwszNewFileName, pointer unfoundType_COPYFILE2_EXTENDED_PARAMETERSpExtendedParameterspExtendedParameters_unnamed_2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CopyFile2([MarshalAs(UnmanagedType.LPWStr)] string pwszExistingFileName, char* pwszNewFileName, pointer unfoundType_COPYFILE2_EXTENDED_PARAMETERSpExtendedParameterspExtendedParameters_unnamed_2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CopyFile2(char* pwszExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string pwszNewFileName, pointer unfoundType_COPYFILE2_EXTENDED_PARAMETERSpExtendedParameterspExtendedParameters_unnamed_2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CopyFile2(char* pwszExistingFileName, char* pwszNewFileName, pointer unfoundType_COPYFILE2_EXTENDED_PARAMETERSpExtendedParameterspExtendedParameters_unnamed_2);
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
        bool MoveFileWithProgressA([MarshalAs(UnmanagedType.LPStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPStr)] string lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileWithProgressA([MarshalAs(UnmanagedType.LPStr)] string lpExistingFileName, byte* lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileWithProgressA(byte* lpExistingFileName, [MarshalAs(UnmanagedType.LPStr)] string lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileWithProgressA(byte* lpExistingFileName, byte* lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, int dwFlags);
    [DllImport(lib, EntryPoint = "MoveFileWithProgressW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileWithProgress([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, int dwFlags);
    [DllImport(lib, EntryPoint = "MoveFileWithProgressW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileWithProgress([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, char* lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, int dwFlags);
    [DllImport(lib, EntryPoint = "MoveFileWithProgressW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileWithProgress(char* lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, int dwFlags);
    [DllImport(lib, EntryPoint = "MoveFileWithProgressW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileWithProgress(char* lpExistingFileName, char* lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileWithProgressW([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileWithProgressW([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, char* lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileWithProgressW(char* lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileWithProgressW(char* lpExistingFileName, char* lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPStr)] string lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, int dwFlags, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpExistingFileName, byte* lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, int dwFlags, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileTransactedA(byte* lpExistingFileName, [MarshalAs(UnmanagedType.LPStr)] string lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, int dwFlags, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileTransactedA(byte* lpExistingFileName, byte* lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, int dwFlags, pointer hTransaction);
    [DllImport(lib, EntryPoint = "MoveFileTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, int dwFlags, pointer hTransaction);
    [DllImport(lib, EntryPoint = "MoveFileTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, char* lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, int dwFlags, pointer hTransaction);
    [DllImport(lib, EntryPoint = "MoveFileTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileTransacted(char* lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, int dwFlags, pointer hTransaction);
    [DllImport(lib, EntryPoint = "MoveFileTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileTransacted(char* lpExistingFileName, char* lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, int dwFlags, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, int dwFlags, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, char* lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, int dwFlags, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileTransactedW(char* lpExistingFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, int dwFlags, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveFileTransactedW(char* lpExistingFileName, char* lpNewFileName, pointer unfoundType_LPPROGRESS_ROUTINE_lpProgressRoutine, pointer lpData, int dwFlags, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFileA([MarshalAs(UnmanagedType.LPStr)] string lpReplacedFileName, [MarshalAs(UnmanagedType.LPStr)] string lpReplacementFileName, [MarshalAs(UnmanagedType.LPStr)] string lpBackupFileName, int dwReplaceFlags, pointer lpExclude, pointer lpReserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFileA([MarshalAs(UnmanagedType.LPStr)] string lpReplacedFileName, [MarshalAs(UnmanagedType.LPStr)] string lpReplacementFileName, byte* lpBackupFileName, int dwReplaceFlags, pointer lpExclude, pointer lpReserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFileA([MarshalAs(UnmanagedType.LPStr)] string lpReplacedFileName, byte* lpReplacementFileName, [MarshalAs(UnmanagedType.LPStr)] string lpBackupFileName, int dwReplaceFlags, pointer lpExclude, pointer lpReserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFileA([MarshalAs(UnmanagedType.LPStr)] string lpReplacedFileName, byte* lpReplacementFileName, byte* lpBackupFileName, int dwReplaceFlags, pointer lpExclude, pointer lpReserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFileA(byte* lpReplacedFileName, [MarshalAs(UnmanagedType.LPStr)] string lpReplacementFileName, [MarshalAs(UnmanagedType.LPStr)] string lpBackupFileName, int dwReplaceFlags, pointer lpExclude, pointer lpReserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFileA(byte* lpReplacedFileName, [MarshalAs(UnmanagedType.LPStr)] string lpReplacementFileName, byte* lpBackupFileName, int dwReplaceFlags, pointer lpExclude, pointer lpReserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFileA(byte* lpReplacedFileName, byte* lpReplacementFileName, [MarshalAs(UnmanagedType.LPStr)] string lpBackupFileName, int dwReplaceFlags, pointer lpExclude, pointer lpReserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFileA(byte* lpReplacedFileName, byte* lpReplacementFileName, byte* lpBackupFileName, int dwReplaceFlags, pointer lpExclude, pointer lpReserved);
    [DllImport(lib, EntryPoint = "ReplaceFileW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFile([MarshalAs(UnmanagedType.LPWStr)] string lpReplacedFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpReplacementFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpBackupFileName, int dwReplaceFlags, pointer lpExclude, pointer lpReserved);
    [DllImport(lib, EntryPoint = "ReplaceFileW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFile([MarshalAs(UnmanagedType.LPWStr)] string lpReplacedFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpReplacementFileName, char* lpBackupFileName, int dwReplaceFlags, pointer lpExclude, pointer lpReserved);
    [DllImport(lib, EntryPoint = "ReplaceFileW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFile([MarshalAs(UnmanagedType.LPWStr)] string lpReplacedFileName, char* lpReplacementFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpBackupFileName, int dwReplaceFlags, pointer lpExclude, pointer lpReserved);
    [DllImport(lib, EntryPoint = "ReplaceFileW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFile([MarshalAs(UnmanagedType.LPWStr)] string lpReplacedFileName, char* lpReplacementFileName, char* lpBackupFileName, int dwReplaceFlags, pointer lpExclude, pointer lpReserved);
    [DllImport(lib, EntryPoint = "ReplaceFileW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFile(char* lpReplacedFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpReplacementFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpBackupFileName, int dwReplaceFlags, pointer lpExclude, pointer lpReserved);
    [DllImport(lib, EntryPoint = "ReplaceFileW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFile(char* lpReplacedFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpReplacementFileName, char* lpBackupFileName, int dwReplaceFlags, pointer lpExclude, pointer lpReserved);
    [DllImport(lib, EntryPoint = "ReplaceFileW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFile(char* lpReplacedFileName, char* lpReplacementFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpBackupFileName, int dwReplaceFlags, pointer lpExclude, pointer lpReserved);
    [DllImport(lib, EntryPoint = "ReplaceFileW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFile(char* lpReplacedFileName, char* lpReplacementFileName, char* lpBackupFileName, int dwReplaceFlags, pointer lpExclude, pointer lpReserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFileW([MarshalAs(UnmanagedType.LPWStr)] string lpReplacedFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpReplacementFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpBackupFileName, int dwReplaceFlags, pointer lpExclude, pointer lpReserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFileW([MarshalAs(UnmanagedType.LPWStr)] string lpReplacedFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpReplacementFileName, char* lpBackupFileName, int dwReplaceFlags, pointer lpExclude, pointer lpReserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFileW([MarshalAs(UnmanagedType.LPWStr)] string lpReplacedFileName, char* lpReplacementFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpBackupFileName, int dwReplaceFlags, pointer lpExclude, pointer lpReserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFileW([MarshalAs(UnmanagedType.LPWStr)] string lpReplacedFileName, char* lpReplacementFileName, char* lpBackupFileName, int dwReplaceFlags, pointer lpExclude, pointer lpReserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFileW(char* lpReplacedFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpReplacementFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpBackupFileName, int dwReplaceFlags, pointer lpExclude, pointer lpReserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFileW(char* lpReplacedFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpReplacementFileName, char* lpBackupFileName, int dwReplaceFlags, pointer lpExclude, pointer lpReserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFileW(char* lpReplacedFileName, char* lpReplacementFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpBackupFileName, int dwReplaceFlags, pointer lpExclude, pointer lpReserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplaceFileW(char* lpReplacedFileName, char* lpReplacementFileName, char* lpBackupFileName, int dwReplaceFlags, pointer lpExclude, pointer lpReserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLinkA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExistingFileName, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLinkA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, byte* lpExistingFileName, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLinkA(byte* lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExistingFileName, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLinkA(byte* lpFileName, byte* lpExistingFileName, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, EntryPoint = "CreateHardLinkW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLink([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, EntryPoint = "CreateHardLinkW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLink([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExistingFileName, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, EntryPoint = "CreateHardLinkW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLink(char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, EntryPoint = "CreateHardLinkW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLink(char* lpFileName, char* lpExistingFileName, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLinkW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLinkW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExistingFileName, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLinkW(char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLinkW(char* lpFileName, char* lpExistingFileName, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLinkTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExistingFileName, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLinkTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpFileName, byte* lpExistingFileName, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLinkTransactedA(byte* lpFileName, [MarshalAs(UnmanagedType.LPStr)] string lpExistingFileName, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLinkTransactedA(byte* lpFileName, byte* lpExistingFileName, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, pointer hTransaction);
    [DllImport(lib, EntryPoint = "CreateHardLinkTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLinkTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, pointer hTransaction);
    [DllImport(lib, EntryPoint = "CreateHardLinkTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLinkTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExistingFileName, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, pointer hTransaction);
    [DllImport(lib, EntryPoint = "CreateHardLinkTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLinkTransacted(char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, pointer hTransaction);
    [DllImport(lib, EntryPoint = "CreateHardLinkTransactedW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLinkTransacted(char* lpFileName, char* lpExistingFileName, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLinkTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLinkTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, char* lpExistingFileName, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLinkTransactedW(char* lpFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateHardLinkTransactedW(char* lpFileName, char* lpExistingFileName, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, pointer hTransaction);
    [DllImport(lib, EntryPoint = "FindFirstStreamTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstStreamTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, pointer unfoundType_STREAM_INFO_LEVELS_InfoLevel, pointer lpFindStreamData, int dwFlags, pointer hTransaction);
    [DllImport(lib, EntryPoint = "FindFirstStreamTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstStreamTransacted(char* lpFileName, pointer unfoundType_STREAM_INFO_LEVELS_InfoLevel, pointer lpFindStreamData, int dwFlags, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstStreamTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, pointer unfoundType_STREAM_INFO_LEVELS_InfoLevel, pointer lpFindStreamData, int dwFlags, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstStreamTransactedW(char* lpFileName, pointer unfoundType_STREAM_INFO_LEVELS_InfoLevel, pointer lpFindStreamData, int dwFlags, pointer hTransaction);
    [DllImport(lib, EntryPoint = "FindFirstFileNameTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstFileNameTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwFlags, pointer unfoundType_LPDWORD_StringLength, [MarshalAs(UnmanagedType.LPWStr)] string LinkName, pointer hTransaction);
    [DllImport(lib, EntryPoint = "FindFirstFileNameTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstFileNameTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwFlags, pointer unfoundType_LPDWORD_StringLength, char* LinkName, pointer hTransaction);
    [DllImport(lib, EntryPoint = "FindFirstFileNameTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstFileNameTransacted(char* lpFileName, int dwFlags, pointer unfoundType_LPDWORD_StringLength, [MarshalAs(UnmanagedType.LPWStr)] string LinkName, pointer hTransaction);
    [DllImport(lib, EntryPoint = "FindFirstFileNameTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstFileNameTransacted(char* lpFileName, int dwFlags, pointer unfoundType_LPDWORD_StringLength, char* LinkName, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstFileNameTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwFlags, pointer unfoundType_LPDWORD_StringLength, [MarshalAs(UnmanagedType.LPWStr)] string LinkName, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstFileNameTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, int dwFlags, pointer unfoundType_LPDWORD_StringLength, char* LinkName, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstFileNameTransactedW(char* lpFileName, int dwFlags, pointer unfoundType_LPDWORD_StringLength, [MarshalAs(UnmanagedType.LPWStr)] string LinkName, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstFileNameTransactedW(char* lpFileName, int dwFlags, pointer unfoundType_LPDWORD_StringLength, char* LinkName, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateNamedPipeA([MarshalAs(UnmanagedType.LPStr)] string lpName, int dwOpenMode, int dwPipeMode, int nMaxInstances, int nOutBufferSize, int nInBufferSize, int nDefaultTimeOut, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateNamedPipeA(byte* lpName, int dwOpenMode, int dwPipeMode, int nMaxInstances, int nOutBufferSize, int nInBufferSize, int nDefaultTimeOut, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNamedPipeHandleStateA(pointer hNamedPipe, pointer unfoundType_LPDWORD_lpState, pointer unfoundType_LPDWORD_lpCurInstances, pointer unfoundType_LPDWORD_lpMaxCollectionCount, pointer unfoundType_LPDWORD_lpCollectDataTimeout, [MarshalAs(UnmanagedType.LPStr)] string lpUserName, int nMaxUserNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNamedPipeHandleStateA(pointer hNamedPipe, pointer unfoundType_LPDWORD_lpState, pointer unfoundType_LPDWORD_lpCurInstances, pointer unfoundType_LPDWORD_lpMaxCollectionCount, pointer unfoundType_LPDWORD_lpCollectDataTimeout, ReadOnlySpan<byte> lpUserName, int nMaxUserNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNamedPipeHandleStateA(pointer hNamedPipe, pointer unfoundType_LPDWORD_lpState, pointer unfoundType_LPDWORD_lpCurInstances, pointer unfoundType_LPDWORD_lpMaxCollectionCount, pointer unfoundType_LPDWORD_lpCollectDataTimeout, byte* lpUserName, int nMaxUserNameSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CallNamedPipeA([MarshalAs(UnmanagedType.LPStr)] string lpNamedPipeName, pointer lpInBuffer, int nInBufferSize, pointer lpOutBuffer, int nOutBufferSize, pointer unfoundType_LPDWORD_lpBytesRead, int nTimeOut);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CallNamedPipeA(byte* lpNamedPipeName, pointer lpInBuffer, int nInBufferSize, pointer lpOutBuffer, int nOutBufferSize, pointer unfoundType_LPDWORD_lpBytesRead, int nTimeOut);
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
        bool GetNamedPipeClientComputerNameA(pointer Pipe, [MarshalAs(UnmanagedType.LPStr)] string ClientComputerName, uint ClientComputerNameLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNamedPipeClientComputerNameA(pointer Pipe, ReadOnlySpan<byte> ClientComputerName, uint ClientComputerNameLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNamedPipeClientComputerNameA(pointer Pipe, byte* ClientComputerName, uint ClientComputerNameLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNamedPipeClientProcessId(pointer Pipe, pointer unfoundType_PULONG_ClientProcessId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNamedPipeClientSessionId(pointer Pipe, pointer unfoundType_PULONG_ClientSessionId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNamedPipeServerProcessId(pointer Pipe, pointer unfoundType_PULONG_ServerProcessId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNamedPipeServerSessionId(pointer Pipe, pointer unfoundType_PULONG_ServerSessionId);
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
        bool SetFileBandwidthReservation(pointer hFile, int nPeriodMilliseconds, int nBytesPerPeriod, bool bDiscardable, pointer unfoundType_LPDWORD_lpTransferSize, pointer unfoundType_LPDWORD_lpNumOutstandingRequests);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileBandwidthReservation(pointer hFile, pointer unfoundType_LPDWORD_lpPeriodMilliseconds, pointer unfoundType_LPDWORD_lpBytesPerPeriod, pointer unfoundType_LPBOOL_pDiscardable, pointer unfoundType_LPDWORD_lpTransferSize, pointer unfoundType_LPDWORD_lpNumOutstandingRequests);
    [DllImport(lib, EntryPoint = "ReadDirectoryChangesW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadDirectoryChanges(pointer hDirectory, pointer lpBuffer, int nBufferLength, bool bWatchSubtree, int dwNotifyFilter, pointer unfoundType_LPDWORD_lpBytesReturned, pointer unfoundType_LPOVERLAPPED_lpOverlapped, pointer unfoundType_LPOVERLAPPED_COMPLETION_ROUTINE_lpCompletionRoutine);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadDirectoryChangesW(pointer hDirectory, pointer lpBuffer, int nBufferLength, bool bWatchSubtree, int dwNotifyFilter, pointer unfoundType_LPDWORD_lpBytesReturned, pointer unfoundType_LPOVERLAPPED_lpOverlapped, pointer unfoundType_LPOVERLAPPED_COMPLETION_ROUTINE_lpCompletionRoutine);
    [DllImport(lib, EntryPoint = "ReadDirectoryChangesExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadDirectoryChangesEx(pointer hDirectory, pointer lpBuffer, int nBufferLength, bool bWatchSubtree, int dwNotifyFilter, pointer unfoundType_LPDWORD_lpBytesReturned, pointer unfoundType_LPOVERLAPPED_lpOverlapped, pointer unfoundType_LPOVERLAPPED_COMPLETION_ROUTINE_lpCompletionRoutine, pointer unfoundType_READ_DIRECTORY_NOTIFY_INFORMATION_CLASS_ReadDirectoryNotifyInformationClass);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReadDirectoryChangesExW(pointer hDirectory, pointer lpBuffer, int nBufferLength, bool bWatchSubtree, int dwNotifyFilter, pointer unfoundType_LPDWORD_lpBytesReturned, pointer unfoundType_LPOVERLAPPED_lpOverlapped, pointer unfoundType_LPOVERLAPPED_COMPLETION_ROUTINE_lpCompletionRoutine, pointer unfoundType_READ_DIRECTORY_NOTIFY_INFORMATION_CLASS_ReadDirectoryNotifyInformationClass);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer MapViewOfFileExNuma(pointer hFileMappingObject, int dwDesiredAccess, int dwFileOffsetHigh, int dwFileOffsetLow, pointer dwNumberOfBytesToMap, pointer lpBaseAddress, int nndPreferred);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsBadReadPtr(pointer unfoundType_VOIDlplp_unnamed_0, ulong ucb);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsBadWritePtr(pointer lp, ulong ucb);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsBadHugeReadPtr(pointer unfoundType_VOIDlplp_unnamed_0, ulong ucb);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsBadHugeWritePtr(pointer lp, ulong ucb);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsBadCodePtr(pointer unfoundType__In_opt_PROC_lpfn);
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
        bool BuildCommDCBA([MarshalAs(UnmanagedType.LPStr)] string lpDef, pointer unfoundType_LPDCB_lpDCB);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool BuildCommDCBA(byte* lpDef, pointer unfoundType_LPDCB_lpDCB);
    [DllImport(lib, EntryPoint = "BuildCommDCBW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool BuildCommDCB([MarshalAs(UnmanagedType.LPWStr)] string lpDef, pointer unfoundType_LPDCB_lpDCB);
    [DllImport(lib, EntryPoint = "BuildCommDCBW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool BuildCommDCB(char* lpDef, pointer unfoundType_LPDCB_lpDCB);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool BuildCommDCBW([MarshalAs(UnmanagedType.LPWStr)] string lpDef, pointer unfoundType_LPDCB_lpDCB);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool BuildCommDCBW(char* lpDef, pointer unfoundType_LPDCB_lpDCB);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool BuildCommDCBAndTimeoutsA([MarshalAs(UnmanagedType.LPStr)] string lpDef, pointer unfoundType_LPDCB_lpDCB, pointer unfoundType_LPCOMMTIMEOUTS_lpCommTimeouts);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool BuildCommDCBAndTimeoutsA(byte* lpDef, pointer unfoundType_LPDCB_lpDCB, pointer unfoundType_LPCOMMTIMEOUTS_lpCommTimeouts);
    [DllImport(lib, EntryPoint = "BuildCommDCBAndTimeoutsW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool BuildCommDCBAndTimeouts([MarshalAs(UnmanagedType.LPWStr)] string lpDef, pointer unfoundType_LPDCB_lpDCB, pointer unfoundType_LPCOMMTIMEOUTS_lpCommTimeouts);
    [DllImport(lib, EntryPoint = "BuildCommDCBAndTimeoutsW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool BuildCommDCBAndTimeouts(char* lpDef, pointer unfoundType_LPDCB_lpDCB, pointer unfoundType_LPCOMMTIMEOUTS_lpCommTimeouts);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool BuildCommDCBAndTimeoutsW([MarshalAs(UnmanagedType.LPWStr)] string lpDef, pointer unfoundType_LPDCB_lpDCB, pointer unfoundType_LPCOMMTIMEOUTS_lpCommTimeouts);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool BuildCommDCBAndTimeoutsW(char* lpDef, pointer unfoundType_LPDCB_lpDCB, pointer unfoundType_LPCOMMTIMEOUTS_lpCommTimeouts);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CommConfigDialogA([MarshalAs(UnmanagedType.LPStr)] string lpszName, pointer hWnd, pointer unfoundType_LPCOMMCONFIG_lpCC);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CommConfigDialogA(byte* lpszName, pointer hWnd, pointer unfoundType_LPCOMMCONFIG_lpCC);
    [DllImport(lib, EntryPoint = "CommConfigDialogW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CommConfigDialog([MarshalAs(UnmanagedType.LPWStr)] string lpszName, pointer hWnd, pointer unfoundType_LPCOMMCONFIG_lpCC);
    [DllImport(lib, EntryPoint = "CommConfigDialogW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CommConfigDialog(char* lpszName, pointer hWnd, pointer unfoundType_LPCOMMCONFIG_lpCC);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CommConfigDialogW([MarshalAs(UnmanagedType.LPWStr)] string lpszName, pointer hWnd, pointer unfoundType_LPCOMMCONFIG_lpCC);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CommConfigDialogW(char* lpszName, pointer hWnd, pointer unfoundType_LPCOMMCONFIG_lpCC);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetDefaultCommConfigA([MarshalAs(UnmanagedType.LPStr)] string lpszName, pointer unfoundType_LPCOMMCONFIG_lpCC, pointer unfoundType_LPDWORD_lpdwSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetDefaultCommConfigA(byte* lpszName, pointer unfoundType_LPCOMMCONFIG_lpCC, pointer unfoundType_LPDWORD_lpdwSize);
    [DllImport(lib, EntryPoint = "GetDefaultCommConfigW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetDefaultCommConfig([MarshalAs(UnmanagedType.LPWStr)] string lpszName, pointer unfoundType_LPCOMMCONFIG_lpCC, pointer unfoundType_LPDWORD_lpdwSize);
    [DllImport(lib, EntryPoint = "GetDefaultCommConfigW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetDefaultCommConfig(char* lpszName, pointer unfoundType_LPCOMMCONFIG_lpCC, pointer unfoundType_LPDWORD_lpdwSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetDefaultCommConfigW([MarshalAs(UnmanagedType.LPWStr)] string lpszName, pointer unfoundType_LPCOMMCONFIG_lpCC, pointer unfoundType_LPDWORD_lpdwSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetDefaultCommConfigW(char* lpszName, pointer unfoundType_LPCOMMCONFIG_lpCC, pointer unfoundType_LPDWORD_lpdwSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetDefaultCommConfigA([MarshalAs(UnmanagedType.LPStr)] string lpszName, pointer unfoundType_LPCOMMCONFIG_lpCC, int dwSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetDefaultCommConfigA(byte* lpszName, pointer unfoundType_LPCOMMCONFIG_lpCC, int dwSize);
    [DllImport(lib, EntryPoint = "SetDefaultCommConfigW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetDefaultCommConfig([MarshalAs(UnmanagedType.LPWStr)] string lpszName, pointer unfoundType_LPCOMMCONFIG_lpCC, int dwSize);
    [DllImport(lib, EntryPoint = "SetDefaultCommConfigW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetDefaultCommConfig(char* lpszName, pointer unfoundType_LPCOMMCONFIG_lpCC, int dwSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetDefaultCommConfigW([MarshalAs(UnmanagedType.LPWStr)] string lpszName, pointer unfoundType_LPCOMMCONFIG_lpCC, int dwSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetDefaultCommConfigW(char* lpszName, pointer unfoundType_LPCOMMCONFIG_lpCC, int dwSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetComputerNameA([MarshalAs(UnmanagedType.LPStr)] string lpBuffer, pointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetComputerNameA(ReadOnlySpan<byte> lpBuffer, pointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetComputerNameA(byte* lpBuffer, pointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, EntryPoint = "GetComputerNameW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetComputerName(string lpBuffer, pointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, EntryPoint = "GetComputerNameW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetComputerName(char* lpBuffer, pointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetComputerNameW(string lpBuffer, pointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetComputerNameW(char* lpBuffer, pointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerNameA([MarshalAs(UnmanagedType.LPStr)] string Hostname, [MarshalAs(UnmanagedType.LPStr)] string ComputerName, pointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerNameA([MarshalAs(UnmanagedType.LPStr)] string Hostname, ReadOnlySpan<byte> ComputerName, pointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerNameA([MarshalAs(UnmanagedType.LPStr)] string Hostname, byte* ComputerName, pointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerNameA(byte* Hostname, [MarshalAs(UnmanagedType.LPStr)] string ComputerName, pointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerNameA(byte* Hostname, ReadOnlySpan<byte> ComputerName, pointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerNameA(byte* Hostname, byte* ComputerName, pointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, EntryPoint = "DnsHostnameToComputerNameW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerName([MarshalAs(UnmanagedType.LPWStr)] string Hostname, string ComputerName, pointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, EntryPoint = "DnsHostnameToComputerNameW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerName([MarshalAs(UnmanagedType.LPWStr)] string Hostname, char* ComputerName, pointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, EntryPoint = "DnsHostnameToComputerNameW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerName(char* Hostname, string ComputerName, pointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, EntryPoint = "DnsHostnameToComputerNameW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerName(char* Hostname, char* ComputerName, pointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerNameW([MarshalAs(UnmanagedType.LPWStr)] string Hostname, string ComputerName, pointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerNameW([MarshalAs(UnmanagedType.LPWStr)] string Hostname, char* ComputerName, pointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerNameW(char* Hostname, string ComputerName, pointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DnsHostnameToComputerNameW(char* Hostname, char* ComputerName, pointer unfoundType_LPDWORD_nSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool RegisterWaitForSingleObject(pointer unfoundType_PHANDLE_phNewWaitObject, pointer hObject, pointer unfoundType_WAITORTIMERCALLBACK_Callback, pointer Context, uint dwMilliseconds, uint dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UnregisterWait(pointer WaitHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool BindIoCompletionCallback(pointer FileHandle, pointer unfoundType_LPOVERLAPPED_COMPLETION_ROUTINE_Function, uint Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer SetTimerQueueTimer(pointer TimerQueue, pointer unfoundType_WAITORTIMERCALLBACK_Callback, pointer Parameter, int DueTime, int Period, bool PreferIo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CancelTimerQueueTimer(pointer TimerQueue, pointer Timer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreatePrivateNamespaceA(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpPrivateNamespaceAttributes, pointer lpBoundaryDescriptor, [MarshalAs(UnmanagedType.LPStr)] string lpAliasPrefix);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreatePrivateNamespaceA(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpPrivateNamespaceAttributes, pointer lpBoundaryDescriptor, byte* lpAliasPrefix);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenPrivateNamespaceA(pointer lpBoundaryDescriptor, [MarshalAs(UnmanagedType.LPStr)] string lpAliasPrefix);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenPrivateNamespaceA(pointer lpBoundaryDescriptor, byte* lpAliasPrefix);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateBoundaryDescriptorA([MarshalAs(UnmanagedType.LPStr)] string Name, uint Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateBoundaryDescriptorA(byte* Name, uint Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddIntegrityLabelToBoundaryDescriptor(pointer BoundaryDescriptor, pointer unfoundType_PSID_IntegrityLabel);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool VerifyVersionInfoA(pointer unfoundType_LPOSVERSIONINFOEXA_lpVersionInformation, int dwTypeMask, pointer unfoundType_DWORDLONG_dwlConditionMask);
    [DllImport(lib, EntryPoint = "VerifyVersionInfoW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool VerifyVersionInfo(pointer unfoundType_LPOSVERSIONINFOEXW_lpVersionInformation, int dwTypeMask, pointer unfoundType_DWORDLONG_dwlConditionMask);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool VerifyVersionInfoW(pointer unfoundType_LPOSVERSIONINFOEXW_lpVersionInformation, int dwTypeMask, pointer unfoundType_DWORDLONG_dwlConditionMask);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetSystemPowerState(bool fSuspend, bool fForce);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetSystemPowerStatus(pointer unfoundType_LPSYSTEM_POWER_STATUS_lpSystemPowerStatus);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MapUserPhysicalPagesScatter(pointer unfoundType_PVOIDVirtualAddressesVirtualAddresses_unnamed_0, pointer unfoundType_ULONG_PTR_NumberOfPages, pointer PageArray);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateJobObjectA(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpJobAttributes, [MarshalAs(UnmanagedType.LPStr)] string lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateJobObjectA(pointer unfoundType_LPSECURITY_ATTRIBUTES_lpJobAttributes, byte* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenJobObjectA(int dwDesiredAccess, bool bInheritHandle, [MarshalAs(UnmanagedType.LPStr)] string lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenJobObjectA(int dwDesiredAccess, bool bInheritHandle, byte* lpName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateJobSet(uint NumJob, pointer unfoundType_PJOB_SET_ARRAY_UserJobSet, uint Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstVolumeA([MarshalAs(UnmanagedType.LPStr)] string lpszVolumeName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstVolumeA(ReadOnlySpan<byte> lpszVolumeName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstVolumeA(byte* lpszVolumeName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextVolumeA(pointer hFindVolume, [MarshalAs(UnmanagedType.LPStr)] string lpszVolumeName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextVolumeA(pointer hFindVolume, ReadOnlySpan<byte> lpszVolumeName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextVolumeA(pointer hFindVolume, byte* lpszVolumeName, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstVolumeMountPointA([MarshalAs(UnmanagedType.LPStr)] string lpszRootPathName, [MarshalAs(UnmanagedType.LPStr)] string lpszVolumeMountPoint, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstVolumeMountPointA([MarshalAs(UnmanagedType.LPStr)] string lpszRootPathName, ReadOnlySpan<byte> lpszVolumeMountPoint, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstVolumeMountPointA([MarshalAs(UnmanagedType.LPStr)] string lpszRootPathName, byte* lpszVolumeMountPoint, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstVolumeMountPointA(byte* lpszRootPathName, [MarshalAs(UnmanagedType.LPStr)] string lpszVolumeMountPoint, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstVolumeMountPointA(byte* lpszRootPathName, ReadOnlySpan<byte> lpszVolumeMountPoint, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstVolumeMountPointA(byte* lpszRootPathName, byte* lpszVolumeMountPoint, int cchBufferLength);
    [DllImport(lib, EntryPoint = "FindFirstVolumeMountPointW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstVolumeMountPoint([MarshalAs(UnmanagedType.LPWStr)] string lpszRootPathName, string lpszVolumeMountPoint, int cchBufferLength);
    [DllImport(lib, EntryPoint = "FindFirstVolumeMountPointW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstVolumeMountPoint([MarshalAs(UnmanagedType.LPWStr)] string lpszRootPathName, char* lpszVolumeMountPoint, int cchBufferLength);
    [DllImport(lib, EntryPoint = "FindFirstVolumeMountPointW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstVolumeMountPoint(char* lpszRootPathName, string lpszVolumeMountPoint, int cchBufferLength);
    [DllImport(lib, EntryPoint = "FindFirstVolumeMountPointW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstVolumeMountPoint(char* lpszRootPathName, char* lpszVolumeMountPoint, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstVolumeMountPointW([MarshalAs(UnmanagedType.LPWStr)] string lpszRootPathName, string lpszVolumeMountPoint, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstVolumeMountPointW([MarshalAs(UnmanagedType.LPWStr)] string lpszRootPathName, char* lpszVolumeMountPoint, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstVolumeMountPointW(char* lpszRootPathName, string lpszVolumeMountPoint, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindFirstVolumeMountPointW(char* lpszRootPathName, char* lpszVolumeMountPoint, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextVolumeMountPointA(pointer hFindVolumeMountPoint, [MarshalAs(UnmanagedType.LPStr)] string lpszVolumeMountPoint, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextVolumeMountPointA(pointer hFindVolumeMountPoint, ReadOnlySpan<byte> lpszVolumeMountPoint, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextVolumeMountPointA(pointer hFindVolumeMountPoint, byte* lpszVolumeMountPoint, int cchBufferLength);
    [DllImport(lib, EntryPoint = "FindNextVolumeMountPointW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextVolumeMountPoint(pointer hFindVolumeMountPoint, string lpszVolumeMountPoint, int cchBufferLength);
    [DllImport(lib, EntryPoint = "FindNextVolumeMountPointW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextVolumeMountPoint(pointer hFindVolumeMountPoint, char* lpszVolumeMountPoint, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextVolumeMountPointW(pointer hFindVolumeMountPoint, string lpszVolumeMountPoint, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindNextVolumeMountPointW(pointer hFindVolumeMountPoint, char* lpszVolumeMountPoint, int cchBufferLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindVolumeMountPointClose(pointer hFindVolumeMountPoint);
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
        bool GetVolumePathNamesForVolumeNameA([MarshalAs(UnmanagedType.LPStr)] string lpszVolumeName, pointer unfoundType_LPCH_lpszVolumePathNames, int cchBufferLength, pointer unfoundType_PDWORD_lpcchReturnLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetVolumePathNamesForVolumeNameA(byte* lpszVolumeName, pointer unfoundType_LPCH_lpszVolumePathNames, int cchBufferLength, pointer unfoundType_PDWORD_lpcchReturnLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateActCtxA(pointer unfoundType_PCACTCTXA_pActCtx);
    [DllImport(lib, EntryPoint = "CreateActCtxW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateActCtx(pointer unfoundType_PCACTCTXW_pActCtx);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateActCtxW(pointer unfoundType_PCACTCTXW_pActCtx);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void AddRefActCtx(pointer hActCtx);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void ReleaseActCtx(pointer hActCtx);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ZombifyActCtx(pointer hActCtx);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ActivateActCtx(pointer hActCtx, pointer unfoundType_ULONG_PTRlpCookielpCookie_unnamed_1);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DeactivateActCtx(int dwFlags, pointer unfoundType_ULONG_PTR_ulCookie);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetCurrentActCtx(pointer unfoundType_HANDLElphActCtxlphActCtx_unnamed_0);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindActCtxSectionStringA(int dwFlags, pointer unfoundType_GUIDlpExtensionGuidlpExtensionGuid_unnamed_1, uint ulSectionId, [MarshalAs(UnmanagedType.LPStr)] string lpStringToFind, pointer unfoundType_PACTCTX_SECTION_KEYED_DATA_ReturnedData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindActCtxSectionStringA(int dwFlags, pointer unfoundType_GUIDlpExtensionGuidlpExtensionGuid_unnamed_1, uint ulSectionId, byte* lpStringToFind, pointer unfoundType_PACTCTX_SECTION_KEYED_DATA_ReturnedData);
    [DllImport(lib, EntryPoint = "FindActCtxSectionStringW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindActCtxSectionString(int dwFlags, pointer unfoundType_GUIDlpExtensionGuidlpExtensionGuid_unnamed_1, uint ulSectionId, [MarshalAs(UnmanagedType.LPWStr)] string lpStringToFind, pointer unfoundType_PACTCTX_SECTION_KEYED_DATA_ReturnedData);
    [DllImport(lib, EntryPoint = "FindActCtxSectionStringW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindActCtxSectionString(int dwFlags, pointer unfoundType_GUIDlpExtensionGuidlpExtensionGuid_unnamed_1, uint ulSectionId, char* lpStringToFind, pointer unfoundType_PACTCTX_SECTION_KEYED_DATA_ReturnedData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindActCtxSectionStringW(int dwFlags, pointer unfoundType_GUIDlpExtensionGuidlpExtensionGuid_unnamed_1, uint ulSectionId, [MarshalAs(UnmanagedType.LPWStr)] string lpStringToFind, pointer unfoundType_PACTCTX_SECTION_KEYED_DATA_ReturnedData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindActCtxSectionStringW(int dwFlags, pointer unfoundType_GUIDlpExtensionGuidlpExtensionGuid_unnamed_1, uint ulSectionId, char* lpStringToFind, pointer unfoundType_PACTCTX_SECTION_KEYED_DATA_ReturnedData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FindActCtxSectionGuid(int dwFlags, pointer unfoundType_GUIDlpExtensionGuidlpExtensionGuid_unnamed_1, uint ulSectionId, pointer unfoundType_GUIDlpGuidToFindlpGuidToFind_unnamed_3, pointer unfoundType_PACTCTX_SECTION_KEYED_DATA_ReturnedData);
    [DllImport(lib, EntryPoint = "QueryActCtxW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryActCtx(int dwFlags, pointer hActCtx, pointer pvSubInstance, uint ulInfoClass, pointer pvBuffer, pointer cbBuffer, pointer unfoundType_SIZE_TpcbWrittenOrRequiredpcbWrittenOrRequired_unnamed_6);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryActCtxW(int dwFlags, pointer hActCtx, pointer pvSubInstance, uint ulInfoClass, pointer pvBuffer, pointer cbBuffer, pointer unfoundType_SIZE_TpcbWrittenOrRequiredpcbWrittenOrRequired_unnamed_6);
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
        bool GetNumaProcessorNode(byte Processor, pointer unfoundType_PUCHAR_NodeNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNumaNodeNumberFromHandle(pointer hFile, pointer unfoundType_PUSHORT_NodeNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNumaProcessorNodeEx(pointer unfoundType_PPROCESSOR_NUMBER_Processor, pointer unfoundType_PUSHORT_NodeNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNumaNodeProcessorMask(byte Node, pointer unfoundType_PULONGLONG_ProcessorMask);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNumaAvailableMemoryNode(byte Node, pointer unfoundType_PULONGLONG_AvailableBytes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNumaAvailableMemoryNodeEx(ushort Node, pointer unfoundType_PULONGLONG_AvailableBytes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNumaProximityNode(uint ProximityId, pointer unfoundType_PUCHAR_NodeNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegisterApplicationRecoveryCallback(pointer unfoundType_APPLICATION_RECOVERY_CALLBACK_pRecoveyCallback, pointer pvParameter, int dwPingInterval, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer UnregisterApplicationRecoveryCallback();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegisterApplicationRestart([MarshalAs(UnmanagedType.LPWStr)] string pwzCommandline, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegisterApplicationRestart(char* pwzCommandline, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer UnregisterApplicationRestart();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetApplicationRecoveryCallback(pointer hProcess, pointer unfoundType_APPLICATION_RECOVERY_CALLBACK_pRecoveryCallback, pointer ppvParameter, pointer unfoundType_PDWORD_pdwPingInterval, pointer unfoundType_PDWORD_pdwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetApplicationRestartSettings(pointer hProcess, [MarshalAs(UnmanagedType.LPWStr)] string pwzCommandline, pointer unfoundType_PDWORD_pcchSize, pointer unfoundType_PDWORD_pdwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetApplicationRestartSettings(pointer hProcess, char* pwzCommandline, pointer unfoundType_PDWORD_pcchSize, pointer unfoundType_PDWORD_pdwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer ApplicationRecoveryInProgress(pointer pbCancelled);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void ApplicationRecoveryFinished(bool bSuccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileInformationByHandleEx(pointer hFile, pointer unfoundType_FILE_INFO_BY_HANDLE_CLASS_FileInformationClass, pointer lpFileInformation, int dwBufferSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenFileById(pointer hVolumeHint, pointer unfoundType_LPFILE_ID_DESCRIPTOR_lpFileId, int dwDesiredAccess, int dwShareMode, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int dwFlagsAndAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateSymbolicLinkA([MarshalAs(UnmanagedType.LPStr)] string lpSymlinkFileName, [MarshalAs(UnmanagedType.LPStr)] string lpTargetFileName, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateSymbolicLinkA([MarshalAs(UnmanagedType.LPStr)] string lpSymlinkFileName, byte* lpTargetFileName, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateSymbolicLinkA(byte* lpSymlinkFileName, [MarshalAs(UnmanagedType.LPStr)] string lpTargetFileName, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateSymbolicLinkA(byte* lpSymlinkFileName, byte* lpTargetFileName, int dwFlags);
    [DllImport(lib, EntryPoint = "CreateSymbolicLinkW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateSymbolicLink([MarshalAs(UnmanagedType.LPWStr)] string lpSymlinkFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpTargetFileName, int dwFlags);
    [DllImport(lib, EntryPoint = "CreateSymbolicLinkW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateSymbolicLink([MarshalAs(UnmanagedType.LPWStr)] string lpSymlinkFileName, char* lpTargetFileName, int dwFlags);
    [DllImport(lib, EntryPoint = "CreateSymbolicLinkW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateSymbolicLink(char* lpSymlinkFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpTargetFileName, int dwFlags);
    [DllImport(lib, EntryPoint = "CreateSymbolicLinkW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateSymbolicLink(char* lpSymlinkFileName, char* lpTargetFileName, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateSymbolicLinkW([MarshalAs(UnmanagedType.LPWStr)] string lpSymlinkFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpTargetFileName, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateSymbolicLinkW([MarshalAs(UnmanagedType.LPWStr)] string lpSymlinkFileName, char* lpTargetFileName, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateSymbolicLinkW(char* lpSymlinkFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpTargetFileName, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateSymbolicLinkW(char* lpSymlinkFileName, char* lpTargetFileName, int dwFlags);
    [DllImport(lib, EntryPoint = "QueryActCtxSettingsW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryActCtxSettings(int dwFlags, pointer hActCtx, [MarshalAs(UnmanagedType.LPWStr)] string settingsNameSpace, [MarshalAs(UnmanagedType.LPWStr)] string settingName, [MarshalAs(UnmanagedType.LPWStr)] string pvBuffer, pointer dwBuffer, pointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport(lib, EntryPoint = "QueryActCtxSettingsW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryActCtxSettings(int dwFlags, pointer hActCtx, [MarshalAs(UnmanagedType.LPWStr)] string settingsNameSpace, [MarshalAs(UnmanagedType.LPWStr)] string settingName, char* pvBuffer, pointer dwBuffer, pointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport(lib, EntryPoint = "QueryActCtxSettingsW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryActCtxSettings(int dwFlags, pointer hActCtx, [MarshalAs(UnmanagedType.LPWStr)] string settingsNameSpace, char* settingName, [MarshalAs(UnmanagedType.LPWStr)] string pvBuffer, pointer dwBuffer, pointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport(lib, EntryPoint = "QueryActCtxSettingsW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryActCtxSettings(int dwFlags, pointer hActCtx, [MarshalAs(UnmanagedType.LPWStr)] string settingsNameSpace, char* settingName, char* pvBuffer, pointer dwBuffer, pointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport(lib, EntryPoint = "QueryActCtxSettingsW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryActCtxSettings(int dwFlags, pointer hActCtx, char* settingsNameSpace, [MarshalAs(UnmanagedType.LPWStr)] string settingName, [MarshalAs(UnmanagedType.LPWStr)] string pvBuffer, pointer dwBuffer, pointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport(lib, EntryPoint = "QueryActCtxSettingsW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryActCtxSettings(int dwFlags, pointer hActCtx, char* settingsNameSpace, [MarshalAs(UnmanagedType.LPWStr)] string settingName, char* pvBuffer, pointer dwBuffer, pointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport(lib, EntryPoint = "QueryActCtxSettingsW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryActCtxSettings(int dwFlags, pointer hActCtx, char* settingsNameSpace, char* settingName, [MarshalAs(UnmanagedType.LPWStr)] string pvBuffer, pointer dwBuffer, pointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport(lib, EntryPoint = "QueryActCtxSettingsW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryActCtxSettings(int dwFlags, pointer hActCtx, char* settingsNameSpace, char* settingName, char* pvBuffer, pointer dwBuffer, pointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryActCtxSettingsW(int dwFlags, pointer hActCtx, [MarshalAs(UnmanagedType.LPWStr)] string settingsNameSpace, [MarshalAs(UnmanagedType.LPWStr)] string settingName, [MarshalAs(UnmanagedType.LPWStr)] string pvBuffer, pointer dwBuffer, pointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryActCtxSettingsW(int dwFlags, pointer hActCtx, [MarshalAs(UnmanagedType.LPWStr)] string settingsNameSpace, [MarshalAs(UnmanagedType.LPWStr)] string settingName, char* pvBuffer, pointer dwBuffer, pointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryActCtxSettingsW(int dwFlags, pointer hActCtx, [MarshalAs(UnmanagedType.LPWStr)] string settingsNameSpace, char* settingName, [MarshalAs(UnmanagedType.LPWStr)] string pvBuffer, pointer dwBuffer, pointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryActCtxSettingsW(int dwFlags, pointer hActCtx, [MarshalAs(UnmanagedType.LPWStr)] string settingsNameSpace, char* settingName, char* pvBuffer, pointer dwBuffer, pointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryActCtxSettingsW(int dwFlags, pointer hActCtx, char* settingsNameSpace, [MarshalAs(UnmanagedType.LPWStr)] string settingName, [MarshalAs(UnmanagedType.LPWStr)] string pvBuffer, pointer dwBuffer, pointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryActCtxSettingsW(int dwFlags, pointer hActCtx, char* settingsNameSpace, [MarshalAs(UnmanagedType.LPWStr)] string settingName, char* pvBuffer, pointer dwBuffer, pointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryActCtxSettingsW(int dwFlags, pointer hActCtx, char* settingsNameSpace, char* settingName, [MarshalAs(UnmanagedType.LPWStr)] string pvBuffer, pointer dwBuffer, pointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool QueryActCtxSettingsW(int dwFlags, pointer hActCtx, char* settingsNameSpace, char* settingName, char* pvBuffer, pointer dwBuffer, pointer unfoundType_SIZE_TpdwWrittenOrRequiredpdwWrittenOrRequired_unnamed_6);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateSymbolicLinkTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpSymlinkFileName, [MarshalAs(UnmanagedType.LPStr)] string lpTargetFileName, int dwFlags, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateSymbolicLinkTransactedA([MarshalAs(UnmanagedType.LPStr)] string lpSymlinkFileName, byte* lpTargetFileName, int dwFlags, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateSymbolicLinkTransactedA(byte* lpSymlinkFileName, [MarshalAs(UnmanagedType.LPStr)] string lpTargetFileName, int dwFlags, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateSymbolicLinkTransactedA(byte* lpSymlinkFileName, byte* lpTargetFileName, int dwFlags, pointer hTransaction);
    [DllImport(lib, EntryPoint = "CreateSymbolicLinkTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateSymbolicLinkTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpSymlinkFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpTargetFileName, int dwFlags, pointer hTransaction);
    [DllImport(lib, EntryPoint = "CreateSymbolicLinkTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateSymbolicLinkTransacted([MarshalAs(UnmanagedType.LPWStr)] string lpSymlinkFileName, char* lpTargetFileName, int dwFlags, pointer hTransaction);
    [DllImport(lib, EntryPoint = "CreateSymbolicLinkTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateSymbolicLinkTransacted(char* lpSymlinkFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpTargetFileName, int dwFlags, pointer hTransaction);
    [DllImport(lib, EntryPoint = "CreateSymbolicLinkTransactedW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateSymbolicLinkTransacted(char* lpSymlinkFileName, char* lpTargetFileName, int dwFlags, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateSymbolicLinkTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpSymlinkFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpTargetFileName, int dwFlags, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateSymbolicLinkTransactedW([MarshalAs(UnmanagedType.LPWStr)] string lpSymlinkFileName, char* lpTargetFileName, int dwFlags, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateSymbolicLinkTransactedW(char* lpSymlinkFileName, [MarshalAs(UnmanagedType.LPWStr)] string lpTargetFileName, int dwFlags, pointer hTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateSymbolicLinkTransactedW(char* lpSymlinkFileName, char* lpTargetFileName, int dwFlags, pointer hTransaction);
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
        bool AddSecureMemoryCacheCallback(pointer unfoundType_PSECURE_MEMORY_CACHE_CALLBACK_pfnCallBack);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool RemoveSecureMemoryCacheCallback(pointer unfoundType_PSECURE_MEMORY_CACHE_CALLBACK_pfnCallBack);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyContext(pointer unfoundType_PCONTEXT_Destination, int ContextFlags, pointer unfoundType_PCONTEXT_Source);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool InitializeContext(pointer Buffer, int ContextFlags, pointer unfoundType_PCONTEXT_Context, pointer unfoundType_PDWORD_ContextLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool InitializeContext2(pointer Buffer, int ContextFlags, pointer unfoundType_PCONTEXT_Context, pointer unfoundType_PDWORD_ContextLength, pointer unfoundType_ULONG64_XStateCompactionMask);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetEnabledXStateFeatures();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetXStateFeaturesMask(pointer unfoundType_PCONTEXT_Context, pointer unfoundType_PDWORD64_FeatureMask);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LocateXStateFeature(pointer unfoundType_PCONTEXT_Context, int FeatureId, pointer unfoundType_PDWORD_Length);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetXStateFeaturesMask(pointer unfoundType_PCONTEXT_Context, pointer unfoundType_DWORD64_FeatureMask);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetThreadEnabledXStateFeatures();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnableProcessOptionalXStateFeatures(pointer unfoundType_DWORD64_Features);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int EnableThreadProfiling(pointer ThreadHandle, int Flags, pointer unfoundType_DWORD64_HardwareCounters, pointer unfoundType_HANDLEPerformanceDataHandlePerformanceDataHandle_unnamed_3);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int DisableThreadProfiling(pointer PerformanceDataHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int QueryThreadProfiling(pointer ThreadHandle, pointer unfoundType_PBOOLEAN_Enabled);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ReadThreadProfilingData(pointer PerformanceDataHandle, int Flags, pointer unfoundType_PPERFORMANCE_DATA_PerformanceData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CeipIsOptedIn();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegCloseKey(nint hKey);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegOpenUserClassesRoot(pointer hToken, int dwOptions, pointer unfoundType_REGSAM_samDesired, pointer phkResult);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegOpenCurrentUser(pointer unfoundType_REGSAM_samDesired, pointer phkResult);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegDisablePredefinedCacheEx();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegCreateKeyExA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string lpSubKey, int Reserved, [MarshalAs(UnmanagedType.LPStr)] string lpClass, int dwOptions, pointer unfoundType_REGSAM_samDesired, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, pointer phkResult, pointer unfoundType_LPDWORD_lpdwDisposition);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegCreateKeyExA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string lpSubKey, int Reserved, ReadOnlySpan<byte> lpClass, int dwOptions, pointer unfoundType_REGSAM_samDesired, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, pointer phkResult, pointer unfoundType_LPDWORD_lpdwDisposition);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegCreateKeyExA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string lpSubKey, int Reserved, byte* lpClass, int dwOptions, pointer unfoundType_REGSAM_samDesired, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, pointer phkResult, pointer unfoundType_LPDWORD_lpdwDisposition);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegCreateKeyExA(nint hKey, byte* lpSubKey, int Reserved, [MarshalAs(UnmanagedType.LPStr)] string lpClass, int dwOptions, pointer unfoundType_REGSAM_samDesired, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, pointer phkResult, pointer unfoundType_LPDWORD_lpdwDisposition);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegCreateKeyExA(nint hKey, byte* lpSubKey, int Reserved, ReadOnlySpan<byte> lpClass, int dwOptions, pointer unfoundType_REGSAM_samDesired, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, pointer phkResult, pointer unfoundType_LPDWORD_lpdwDisposition);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegCreateKeyExA(nint hKey, byte* lpSubKey, int Reserved, byte* lpClass, int dwOptions, pointer unfoundType_REGSAM_samDesired, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, pointer phkResult, pointer unfoundType_LPDWORD_lpdwDisposition);
    [DllImport(lib, EntryPoint = "RegCreateKeyExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegCreateKeyEx(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, int Reserved, string lpClass, int dwOptions, pointer unfoundType_REGSAM_samDesired, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, pointer phkResult, pointer unfoundType_LPDWORD_lpdwDisposition);
    [DllImport(lib, EntryPoint = "RegCreateKeyExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegCreateKeyEx(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, int Reserved, char* lpClass, int dwOptions, pointer unfoundType_REGSAM_samDesired, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, pointer phkResult, pointer unfoundType_LPDWORD_lpdwDisposition);
    [DllImport(lib, EntryPoint = "RegCreateKeyExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegCreateKeyEx(nint hKey, char* lpSubKey, int Reserved, string lpClass, int dwOptions, pointer unfoundType_REGSAM_samDesired, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, pointer phkResult, pointer unfoundType_LPDWORD_lpdwDisposition);
    [DllImport(lib, EntryPoint = "RegCreateKeyExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegCreateKeyEx(nint hKey, char* lpSubKey, int Reserved, char* lpClass, int dwOptions, pointer unfoundType_REGSAM_samDesired, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, pointer phkResult, pointer unfoundType_LPDWORD_lpdwDisposition);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegCreateKeyExW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, int Reserved, string lpClass, int dwOptions, pointer unfoundType_REGSAM_samDesired, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, pointer phkResult, pointer unfoundType_LPDWORD_lpdwDisposition);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegCreateKeyExW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, int Reserved, char* lpClass, int dwOptions, pointer unfoundType_REGSAM_samDesired, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, pointer phkResult, pointer unfoundType_LPDWORD_lpdwDisposition);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegCreateKeyExW(nint hKey, char* lpSubKey, int Reserved, string lpClass, int dwOptions, pointer unfoundType_REGSAM_samDesired, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, pointer phkResult, pointer unfoundType_LPDWORD_lpdwDisposition);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegCreateKeyExW(nint hKey, char* lpSubKey, int Reserved, char* lpClass, int dwOptions, pointer unfoundType_REGSAM_samDesired, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, pointer phkResult, pointer unfoundType_LPDWORD_lpdwDisposition);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegDeleteKeyExA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string lpSubKey, pointer unfoundType_REGSAM_samDesired, int Reserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegDeleteKeyExA(nint hKey, byte* lpSubKey, pointer unfoundType_REGSAM_samDesired, int Reserved);
    [DllImport(lib, EntryPoint = "RegDeleteKeyExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegDeleteKeyEx(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, pointer unfoundType_REGSAM_samDesired, int Reserved);
    [DllImport(lib, EntryPoint = "RegDeleteKeyExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegDeleteKeyEx(nint hKey, char* lpSubKey, pointer unfoundType_REGSAM_samDesired, int Reserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegDeleteKeyExW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, pointer unfoundType_REGSAM_samDesired, int Reserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegDeleteKeyExW(nint hKey, char* lpSubKey, pointer unfoundType_REGSAM_samDesired, int Reserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegDeleteValueA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string lpValueName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegDeleteValueA(nint hKey, byte* lpValueName);
    [DllImport(lib, EntryPoint = "RegDeleteValueW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegDeleteValue(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpValueName);
    [DllImport(lib, EntryPoint = "RegDeleteValueW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegDeleteValue(nint hKey, char* lpValueName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegDeleteValueW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpValueName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegDeleteValueW(nint hKey, char* lpValueName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegEnumKeyExA(nint hKey, int dwIndex, [MarshalAs(UnmanagedType.LPStr)] string lpName, pointer unfoundType_LPDWORD_lpcchName, pointer unfoundType_LPDWORD_lpReserved, [MarshalAs(UnmanagedType.LPStr)] string lpClass, pointer unfoundType_LPDWORD_lpcchClass, pointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegEnumKeyExA(nint hKey, int dwIndex, [MarshalAs(UnmanagedType.LPStr)] string lpName, pointer unfoundType_LPDWORD_lpcchName, pointer unfoundType_LPDWORD_lpReserved, ReadOnlySpan<byte> lpClass, pointer unfoundType_LPDWORD_lpcchClass, pointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegEnumKeyExA(nint hKey, int dwIndex, [MarshalAs(UnmanagedType.LPStr)] string lpName, pointer unfoundType_LPDWORD_lpcchName, pointer unfoundType_LPDWORD_lpReserved, byte* lpClass, pointer unfoundType_LPDWORD_lpcchClass, pointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegEnumKeyExA(nint hKey, int dwIndex, ReadOnlySpan<byte> lpName, pointer unfoundType_LPDWORD_lpcchName, pointer unfoundType_LPDWORD_lpReserved, [MarshalAs(UnmanagedType.LPStr)] string lpClass, pointer unfoundType_LPDWORD_lpcchClass, pointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegEnumKeyExA(nint hKey, int dwIndex, ReadOnlySpan<byte> lpName, pointer unfoundType_LPDWORD_lpcchName, pointer unfoundType_LPDWORD_lpReserved, ReadOnlySpan<byte> lpClass, pointer unfoundType_LPDWORD_lpcchClass, pointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegEnumKeyExA(nint hKey, int dwIndex, ReadOnlySpan<byte> lpName, pointer unfoundType_LPDWORD_lpcchName, pointer unfoundType_LPDWORD_lpReserved, byte* lpClass, pointer unfoundType_LPDWORD_lpcchClass, pointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegEnumKeyExA(nint hKey, int dwIndex, byte* lpName, pointer unfoundType_LPDWORD_lpcchName, pointer unfoundType_LPDWORD_lpReserved, [MarshalAs(UnmanagedType.LPStr)] string lpClass, pointer unfoundType_LPDWORD_lpcchClass, pointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegEnumKeyExA(nint hKey, int dwIndex, byte* lpName, pointer unfoundType_LPDWORD_lpcchName, pointer unfoundType_LPDWORD_lpReserved, ReadOnlySpan<byte> lpClass, pointer unfoundType_LPDWORD_lpcchClass, pointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegEnumKeyExA(nint hKey, int dwIndex, byte* lpName, pointer unfoundType_LPDWORD_lpcchName, pointer unfoundType_LPDWORD_lpReserved, byte* lpClass, pointer unfoundType_LPDWORD_lpcchClass, pointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, EntryPoint = "RegEnumKeyExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegEnumKeyEx(nint hKey, int dwIndex, string lpName, pointer unfoundType_LPDWORD_lpcchName, pointer unfoundType_LPDWORD_lpReserved, string lpClass, pointer unfoundType_LPDWORD_lpcchClass, pointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, EntryPoint = "RegEnumKeyExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegEnumKeyEx(nint hKey, int dwIndex, string lpName, pointer unfoundType_LPDWORD_lpcchName, pointer unfoundType_LPDWORD_lpReserved, char* lpClass, pointer unfoundType_LPDWORD_lpcchClass, pointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, EntryPoint = "RegEnumKeyExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegEnumKeyEx(nint hKey, int dwIndex, char* lpName, pointer unfoundType_LPDWORD_lpcchName, pointer unfoundType_LPDWORD_lpReserved, string lpClass, pointer unfoundType_LPDWORD_lpcchClass, pointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, EntryPoint = "RegEnumKeyExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegEnumKeyEx(nint hKey, int dwIndex, char* lpName, pointer unfoundType_LPDWORD_lpcchName, pointer unfoundType_LPDWORD_lpReserved, char* lpClass, pointer unfoundType_LPDWORD_lpcchClass, pointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegEnumKeyExW(nint hKey, int dwIndex, string lpName, pointer unfoundType_LPDWORD_lpcchName, pointer unfoundType_LPDWORD_lpReserved, string lpClass, pointer unfoundType_LPDWORD_lpcchClass, pointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegEnumKeyExW(nint hKey, int dwIndex, string lpName, pointer unfoundType_LPDWORD_lpcchName, pointer unfoundType_LPDWORD_lpReserved, char* lpClass, pointer unfoundType_LPDWORD_lpcchClass, pointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegEnumKeyExW(nint hKey, int dwIndex, char* lpName, pointer unfoundType_LPDWORD_lpcchName, pointer unfoundType_LPDWORD_lpReserved, string lpClass, pointer unfoundType_LPDWORD_lpcchClass, pointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegEnumKeyExW(nint hKey, int dwIndex, char* lpName, pointer unfoundType_LPDWORD_lpcchName, pointer unfoundType_LPDWORD_lpReserved, char* lpClass, pointer unfoundType_LPDWORD_lpcchClass, pointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegEnumValueA(nint hKey, int dwIndex, [MarshalAs(UnmanagedType.LPStr)] string lpValueName, pointer unfoundType_LPDWORD_lpcchValueName, pointer unfoundType_LPDWORD_lpReserved, pointer unfoundType_LPDWORD_lpType, pointer unfoundType_LPBYTE_lpData, pointer unfoundType_LPDWORD_lpcbData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegEnumValueA(nint hKey, int dwIndex, ReadOnlySpan<byte> lpValueName, pointer unfoundType_LPDWORD_lpcchValueName, pointer unfoundType_LPDWORD_lpReserved, pointer unfoundType_LPDWORD_lpType, pointer unfoundType_LPBYTE_lpData, pointer unfoundType_LPDWORD_lpcbData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegEnumValueA(nint hKey, int dwIndex, byte* lpValueName, pointer unfoundType_LPDWORD_lpcchValueName, pointer unfoundType_LPDWORD_lpReserved, pointer unfoundType_LPDWORD_lpType, pointer unfoundType_LPBYTE_lpData, pointer unfoundType_LPDWORD_lpcbData);
    [DllImport(lib, EntryPoint = "RegEnumValueW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegEnumValue(nint hKey, int dwIndex, string lpValueName, pointer unfoundType_LPDWORD_lpcchValueName, pointer unfoundType_LPDWORD_lpReserved, pointer unfoundType_LPDWORD_lpType, pointer unfoundType_LPBYTE_lpData, pointer unfoundType_LPDWORD_lpcbData);
    [DllImport(lib, EntryPoint = "RegEnumValueW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegEnumValue(nint hKey, int dwIndex, char* lpValueName, pointer unfoundType_LPDWORD_lpcchValueName, pointer unfoundType_LPDWORD_lpReserved, pointer unfoundType_LPDWORD_lpType, pointer unfoundType_LPBYTE_lpData, pointer unfoundType_LPDWORD_lpcbData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegEnumValueW(nint hKey, int dwIndex, string lpValueName, pointer unfoundType_LPDWORD_lpcchValueName, pointer unfoundType_LPDWORD_lpReserved, pointer unfoundType_LPDWORD_lpType, pointer unfoundType_LPBYTE_lpData, pointer unfoundType_LPDWORD_lpcbData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegEnumValueW(nint hKey, int dwIndex, char* lpValueName, pointer unfoundType_LPDWORD_lpcchValueName, pointer unfoundType_LPDWORD_lpReserved, pointer unfoundType_LPDWORD_lpType, pointer unfoundType_LPBYTE_lpData, pointer unfoundType_LPDWORD_lpcbData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegFlushKey(nint hKey);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegGetKeySecurity(nint hKey, pointer unfoundType_SECURITY_INFORMATION_SecurityInformation, pointer unfoundType_PSECURITY_DESCRIPTOR_pSecurityDescriptor, pointer unfoundType_LPDWORD_lpcbSecurityDescriptor);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegLoadKeyA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string lpSubKey, [MarshalAs(UnmanagedType.LPStr)] string lpFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegLoadKeyA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string lpSubKey, byte* lpFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegLoadKeyA(nint hKey, byte* lpSubKey, [MarshalAs(UnmanagedType.LPStr)] string lpFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegLoadKeyA(nint hKey, byte* lpSubKey, byte* lpFile);
    [DllImport(lib, EntryPoint = "RegLoadKeyW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegLoadKey(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, [MarshalAs(UnmanagedType.LPWStr)] string lpFile);
    [DllImport(lib, EntryPoint = "RegLoadKeyW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegLoadKey(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, char* lpFile);
    [DllImport(lib, EntryPoint = "RegLoadKeyW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegLoadKey(nint hKey, char* lpSubKey, [MarshalAs(UnmanagedType.LPWStr)] string lpFile);
    [DllImport(lib, EntryPoint = "RegLoadKeyW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegLoadKey(nint hKey, char* lpSubKey, char* lpFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegLoadKeyW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, [MarshalAs(UnmanagedType.LPWStr)] string lpFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegLoadKeyW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, char* lpFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegLoadKeyW(nint hKey, char* lpSubKey, [MarshalAs(UnmanagedType.LPWStr)] string lpFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegLoadKeyW(nint hKey, char* lpSubKey, char* lpFile);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegNotifyChangeKeyValue(nint hKey, bool bWatchSubtree, int dwNotifyFilter, pointer hEvent, bool fAsynchronous);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegOpenKeyExA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string lpSubKey, int ulOptions, pointer unfoundType_REGSAM_samDesired, pointer phkResult);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegOpenKeyExA(nint hKey, byte* lpSubKey, int ulOptions, pointer unfoundType_REGSAM_samDesired, pointer phkResult);
    [DllImport(lib, EntryPoint = "RegOpenKeyExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegOpenKeyEx(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, int ulOptions, pointer unfoundType_REGSAM_samDesired, pointer phkResult);
    [DllImport(lib, EntryPoint = "RegOpenKeyExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegOpenKeyEx(nint hKey, char* lpSubKey, int ulOptions, pointer unfoundType_REGSAM_samDesired, pointer phkResult);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegOpenKeyExW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, int ulOptions, pointer unfoundType_REGSAM_samDesired, pointer phkResult);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegOpenKeyExW(nint hKey, char* lpSubKey, int ulOptions, pointer unfoundType_REGSAM_samDesired, pointer phkResult);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegQueryInfoKeyA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string lpClass, pointer unfoundType_LPDWORD_lpcchClass, pointer unfoundType_LPDWORD_lpReserved, pointer unfoundType_LPDWORD_lpcSubKeys, pointer unfoundType_LPDWORD_lpcbMaxSubKeyLen, pointer unfoundType_LPDWORD_lpcbMaxClassLen, pointer unfoundType_LPDWORD_lpcValues, pointer unfoundType_LPDWORD_lpcbMaxValueNameLen, pointer unfoundType_LPDWORD_lpcbMaxValueLen, pointer unfoundType_LPDWORD_lpcbSecurityDescriptor, pointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegQueryInfoKeyA(nint hKey, ReadOnlySpan<byte> lpClass, pointer unfoundType_LPDWORD_lpcchClass, pointer unfoundType_LPDWORD_lpReserved, pointer unfoundType_LPDWORD_lpcSubKeys, pointer unfoundType_LPDWORD_lpcbMaxSubKeyLen, pointer unfoundType_LPDWORD_lpcbMaxClassLen, pointer unfoundType_LPDWORD_lpcValues, pointer unfoundType_LPDWORD_lpcbMaxValueNameLen, pointer unfoundType_LPDWORD_lpcbMaxValueLen, pointer unfoundType_LPDWORD_lpcbSecurityDescriptor, pointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegQueryInfoKeyA(nint hKey, byte* lpClass, pointer unfoundType_LPDWORD_lpcchClass, pointer unfoundType_LPDWORD_lpReserved, pointer unfoundType_LPDWORD_lpcSubKeys, pointer unfoundType_LPDWORD_lpcbMaxSubKeyLen, pointer unfoundType_LPDWORD_lpcbMaxClassLen, pointer unfoundType_LPDWORD_lpcValues, pointer unfoundType_LPDWORD_lpcbMaxValueNameLen, pointer unfoundType_LPDWORD_lpcbMaxValueLen, pointer unfoundType_LPDWORD_lpcbSecurityDescriptor, pointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, EntryPoint = "RegQueryInfoKeyW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegQueryInfoKey(nint hKey, string lpClass, pointer unfoundType_LPDWORD_lpcchClass, pointer unfoundType_LPDWORD_lpReserved, pointer unfoundType_LPDWORD_lpcSubKeys, pointer unfoundType_LPDWORD_lpcbMaxSubKeyLen, pointer unfoundType_LPDWORD_lpcbMaxClassLen, pointer unfoundType_LPDWORD_lpcValues, pointer unfoundType_LPDWORD_lpcbMaxValueNameLen, pointer unfoundType_LPDWORD_lpcbMaxValueLen, pointer unfoundType_LPDWORD_lpcbSecurityDescriptor, pointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, EntryPoint = "RegQueryInfoKeyW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegQueryInfoKey(nint hKey, char* lpClass, pointer unfoundType_LPDWORD_lpcchClass, pointer unfoundType_LPDWORD_lpReserved, pointer unfoundType_LPDWORD_lpcSubKeys, pointer unfoundType_LPDWORD_lpcbMaxSubKeyLen, pointer unfoundType_LPDWORD_lpcbMaxClassLen, pointer unfoundType_LPDWORD_lpcValues, pointer unfoundType_LPDWORD_lpcbMaxValueNameLen, pointer unfoundType_LPDWORD_lpcbMaxValueLen, pointer unfoundType_LPDWORD_lpcbSecurityDescriptor, pointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegQueryInfoKeyW(nint hKey, string lpClass, pointer unfoundType_LPDWORD_lpcchClass, pointer unfoundType_LPDWORD_lpReserved, pointer unfoundType_LPDWORD_lpcSubKeys, pointer unfoundType_LPDWORD_lpcbMaxSubKeyLen, pointer unfoundType_LPDWORD_lpcbMaxClassLen, pointer unfoundType_LPDWORD_lpcValues, pointer unfoundType_LPDWORD_lpcbMaxValueNameLen, pointer unfoundType_LPDWORD_lpcbMaxValueLen, pointer unfoundType_LPDWORD_lpcbSecurityDescriptor, pointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegQueryInfoKeyW(nint hKey, char* lpClass, pointer unfoundType_LPDWORD_lpcchClass, pointer unfoundType_LPDWORD_lpReserved, pointer unfoundType_LPDWORD_lpcSubKeys, pointer unfoundType_LPDWORD_lpcbMaxSubKeyLen, pointer unfoundType_LPDWORD_lpcbMaxClassLen, pointer unfoundType_LPDWORD_lpcValues, pointer unfoundType_LPDWORD_lpcbMaxValueNameLen, pointer unfoundType_LPDWORD_lpcbMaxValueLen, pointer unfoundType_LPDWORD_lpcbSecurityDescriptor, pointer unfoundType_PFILETIME_lpftLastWriteTime);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegQueryValueExA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string lpValueName, pointer unfoundType_LPDWORD_lpReserved, pointer unfoundType_LPDWORD_lpType, pointer unfoundType_LPBYTE_lpData, pointer unfoundType_LPDWORD_lpcbData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegQueryValueExA(nint hKey, byte* lpValueName, pointer unfoundType_LPDWORD_lpReserved, pointer unfoundType_LPDWORD_lpType, pointer unfoundType_LPBYTE_lpData, pointer unfoundType_LPDWORD_lpcbData);
    [DllImport(lib, EntryPoint = "RegQueryValueExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegQueryValueEx(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpValueName, pointer unfoundType_LPDWORD_lpReserved, pointer unfoundType_LPDWORD_lpType, pointer unfoundType_LPBYTE_lpData, pointer unfoundType_LPDWORD_lpcbData);
    [DllImport(lib, EntryPoint = "RegQueryValueExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegQueryValueEx(nint hKey, char* lpValueName, pointer unfoundType_LPDWORD_lpReserved, pointer unfoundType_LPDWORD_lpType, pointer unfoundType_LPBYTE_lpData, pointer unfoundType_LPDWORD_lpcbData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegQueryValueExW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpValueName, pointer unfoundType_LPDWORD_lpReserved, pointer unfoundType_LPDWORD_lpType, pointer unfoundType_LPBYTE_lpData, pointer unfoundType_LPDWORD_lpcbData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegQueryValueExW(nint hKey, char* lpValueName, pointer unfoundType_LPDWORD_lpReserved, pointer unfoundType_LPDWORD_lpType, pointer unfoundType_LPBYTE_lpData, pointer unfoundType_LPDWORD_lpcbData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegRestoreKeyA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string lpFile, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegRestoreKeyA(nint hKey, byte* lpFile, int dwFlags);
    [DllImport(lib, EntryPoint = "RegRestoreKeyW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegRestoreKey(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpFile, int dwFlags);
    [DllImport(lib, EntryPoint = "RegRestoreKeyW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegRestoreKey(nint hKey, char* lpFile, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegRestoreKeyW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpFile, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegRestoreKeyW(nint hKey, char* lpFile, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegSetKeySecurity(nint hKey, pointer unfoundType_SECURITY_INFORMATION_SecurityInformation, pointer unfoundType_PSECURITY_DESCRIPTOR_pSecurityDescriptor);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegSetValueExA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string lpValueName, int Reserved, int dwType, pointer lpData, int cbData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegSetValueExA(nint hKey, byte* lpValueName, int Reserved, int dwType, pointer lpData, int cbData);
    [DllImport(lib, EntryPoint = "RegSetValueExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegSetValueEx(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpValueName, int Reserved, int dwType, pointer lpData, int cbData);
    [DllImport(lib, EntryPoint = "RegSetValueExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegSetValueEx(nint hKey, char* lpValueName, int Reserved, int dwType, pointer lpData, int cbData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegSetValueExW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpValueName, int Reserved, int dwType, pointer lpData, int cbData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegSetValueExW(nint hKey, char* lpValueName, int Reserved, int dwType, pointer lpData, int cbData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegUnLoadKeyA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string lpSubKey);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegUnLoadKeyA(nint hKey, byte* lpSubKey);
    [DllImport(lib, EntryPoint = "RegUnLoadKeyW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegUnLoadKey(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey);
    [DllImport(lib, EntryPoint = "RegUnLoadKeyW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegUnLoadKey(nint hKey, char* lpSubKey);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegUnLoadKeyW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegUnLoadKeyW(nint hKey, char* lpSubKey);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegDeleteTreeA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string lpSubKey);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegDeleteTreeA(nint hKey, byte* lpSubKey);
    [DllImport(lib, EntryPoint = "RegDeleteTreeW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegDeleteTree(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey);
    [DllImport(lib, EntryPoint = "RegDeleteTreeW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegDeleteTree(nint hKey, char* lpSubKey);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegDeleteTreeW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegDeleteTreeW(nint hKey, char* lpSubKey);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegGetValueA(nint hkey, [MarshalAs(UnmanagedType.LPStr)] string lpSubKey, [MarshalAs(UnmanagedType.LPStr)] string lpValue, int dwFlags, pointer unfoundType_LPDWORD_pdwType, pointer pvData, pointer unfoundType_LPDWORD_pcbData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegGetValueA(nint hkey, [MarshalAs(UnmanagedType.LPStr)] string lpSubKey, byte* lpValue, int dwFlags, pointer unfoundType_LPDWORD_pdwType, pointer pvData, pointer unfoundType_LPDWORD_pcbData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegGetValueA(nint hkey, byte* lpSubKey, [MarshalAs(UnmanagedType.LPStr)] string lpValue, int dwFlags, pointer unfoundType_LPDWORD_pdwType, pointer pvData, pointer unfoundType_LPDWORD_pcbData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegGetValueA(nint hkey, byte* lpSubKey, byte* lpValue, int dwFlags, pointer unfoundType_LPDWORD_pdwType, pointer pvData, pointer unfoundType_LPDWORD_pcbData);
    [DllImport(lib, EntryPoint = "RegGetValueW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegGetValue(nint hkey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, int dwFlags, pointer unfoundType_LPDWORD_pdwType, pointer pvData, pointer unfoundType_LPDWORD_pcbData);
    [DllImport(lib, EntryPoint = "RegGetValueW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegGetValue(nint hkey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, char* lpValue, int dwFlags, pointer unfoundType_LPDWORD_pdwType, pointer pvData, pointer unfoundType_LPDWORD_pcbData);
    [DllImport(lib, EntryPoint = "RegGetValueW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegGetValue(nint hkey, char* lpSubKey, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, int dwFlags, pointer unfoundType_LPDWORD_pdwType, pointer pvData, pointer unfoundType_LPDWORD_pcbData);
    [DllImport(lib, EntryPoint = "RegGetValueW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegGetValue(nint hkey, char* lpSubKey, char* lpValue, int dwFlags, pointer unfoundType_LPDWORD_pdwType, pointer pvData, pointer unfoundType_LPDWORD_pcbData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegGetValueW(nint hkey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, int dwFlags, pointer unfoundType_LPDWORD_pdwType, pointer pvData, pointer unfoundType_LPDWORD_pcbData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegGetValueW(nint hkey, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, char* lpValue, int dwFlags, pointer unfoundType_LPDWORD_pdwType, pointer pvData, pointer unfoundType_LPDWORD_pcbData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegGetValueW(nint hkey, char* lpSubKey, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, int dwFlags, pointer unfoundType_LPDWORD_pdwType, pointer pvData, pointer unfoundType_LPDWORD_pcbData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegGetValueW(nint hkey, char* lpSubKey, char* lpValue, int dwFlags, pointer unfoundType_LPDWORD_pdwType, pointer pvData, pointer unfoundType_LPDWORD_pcbData);
    [DllImport(lib, EntryPoint = "RegCopyTreeW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegCopyTree(nint hKeySrc, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, nint hKeyDest);
    [DllImport(lib, EntryPoint = "RegCopyTreeW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegCopyTree(nint hKeySrc, char* lpSubKey, nint hKeyDest);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegCopyTreeW(nint hKeySrc, [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, nint hKeyDest);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegCopyTreeW(nint hKeySrc, char* lpSubKey, nint hKeyDest);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegLoadMUIStringA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string pszValue, [MarshalAs(UnmanagedType.LPStr)] string pszOutBuf, int cbOutBuf, pointer unfoundType_LPDWORD_pcbData, int Flags, [MarshalAs(UnmanagedType.LPStr)] string pszDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegLoadMUIStringA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string pszValue, [MarshalAs(UnmanagedType.LPStr)] string pszOutBuf, int cbOutBuf, pointer unfoundType_LPDWORD_pcbData, int Flags, byte* pszDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegLoadMUIStringA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string pszValue, ReadOnlySpan<byte> pszOutBuf, int cbOutBuf, pointer unfoundType_LPDWORD_pcbData, int Flags, [MarshalAs(UnmanagedType.LPStr)] string pszDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegLoadMUIStringA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string pszValue, ReadOnlySpan<byte> pszOutBuf, int cbOutBuf, pointer unfoundType_LPDWORD_pcbData, int Flags, byte* pszDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegLoadMUIStringA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string pszValue, byte* pszOutBuf, int cbOutBuf, pointer unfoundType_LPDWORD_pcbData, int Flags, [MarshalAs(UnmanagedType.LPStr)] string pszDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegLoadMUIStringA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string pszValue, byte* pszOutBuf, int cbOutBuf, pointer unfoundType_LPDWORD_pcbData, int Flags, byte* pszDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegLoadMUIStringA(nint hKey, byte* pszValue, [MarshalAs(UnmanagedType.LPStr)] string pszOutBuf, int cbOutBuf, pointer unfoundType_LPDWORD_pcbData, int Flags, [MarshalAs(UnmanagedType.LPStr)] string pszDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegLoadMUIStringA(nint hKey, byte* pszValue, [MarshalAs(UnmanagedType.LPStr)] string pszOutBuf, int cbOutBuf, pointer unfoundType_LPDWORD_pcbData, int Flags, byte* pszDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegLoadMUIStringA(nint hKey, byte* pszValue, ReadOnlySpan<byte> pszOutBuf, int cbOutBuf, pointer unfoundType_LPDWORD_pcbData, int Flags, [MarshalAs(UnmanagedType.LPStr)] string pszDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegLoadMUIStringA(nint hKey, byte* pszValue, ReadOnlySpan<byte> pszOutBuf, int cbOutBuf, pointer unfoundType_LPDWORD_pcbData, int Flags, byte* pszDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegLoadMUIStringA(nint hKey, byte* pszValue, byte* pszOutBuf, int cbOutBuf, pointer unfoundType_LPDWORD_pcbData, int Flags, [MarshalAs(UnmanagedType.LPStr)] string pszDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegLoadMUIStringA(nint hKey, byte* pszValue, byte* pszOutBuf, int cbOutBuf, pointer unfoundType_LPDWORD_pcbData, int Flags, byte* pszDirectory);
    [DllImport(lib, EntryPoint = "RegLoadMUIStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegLoadMUIString(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string pszValue, string pszOutBuf, int cbOutBuf, pointer unfoundType_LPDWORD_pcbData, int Flags, [MarshalAs(UnmanagedType.LPWStr)] string pszDirectory);
    [DllImport(lib, EntryPoint = "RegLoadMUIStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegLoadMUIString(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string pszValue, string pszOutBuf, int cbOutBuf, pointer unfoundType_LPDWORD_pcbData, int Flags, char* pszDirectory);
    [DllImport(lib, EntryPoint = "RegLoadMUIStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegLoadMUIString(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string pszValue, char* pszOutBuf, int cbOutBuf, pointer unfoundType_LPDWORD_pcbData, int Flags, [MarshalAs(UnmanagedType.LPWStr)] string pszDirectory);
    [DllImport(lib, EntryPoint = "RegLoadMUIStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegLoadMUIString(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string pszValue, char* pszOutBuf, int cbOutBuf, pointer unfoundType_LPDWORD_pcbData, int Flags, char* pszDirectory);
    [DllImport(lib, EntryPoint = "RegLoadMUIStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegLoadMUIString(nint hKey, char* pszValue, string pszOutBuf, int cbOutBuf, pointer unfoundType_LPDWORD_pcbData, int Flags, [MarshalAs(UnmanagedType.LPWStr)] string pszDirectory);
    [DllImport(lib, EntryPoint = "RegLoadMUIStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegLoadMUIString(nint hKey, char* pszValue, string pszOutBuf, int cbOutBuf, pointer unfoundType_LPDWORD_pcbData, int Flags, char* pszDirectory);
    [DllImport(lib, EntryPoint = "RegLoadMUIStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegLoadMUIString(nint hKey, char* pszValue, char* pszOutBuf, int cbOutBuf, pointer unfoundType_LPDWORD_pcbData, int Flags, [MarshalAs(UnmanagedType.LPWStr)] string pszDirectory);
    [DllImport(lib, EntryPoint = "RegLoadMUIStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegLoadMUIString(nint hKey, char* pszValue, char* pszOutBuf, int cbOutBuf, pointer unfoundType_LPDWORD_pcbData, int Flags, char* pszDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegLoadMUIStringW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string pszValue, string pszOutBuf, int cbOutBuf, pointer unfoundType_LPDWORD_pcbData, int Flags, [MarshalAs(UnmanagedType.LPWStr)] string pszDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegLoadMUIStringW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string pszValue, string pszOutBuf, int cbOutBuf, pointer unfoundType_LPDWORD_pcbData, int Flags, char* pszDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegLoadMUIStringW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string pszValue, char* pszOutBuf, int cbOutBuf, pointer unfoundType_LPDWORD_pcbData, int Flags, [MarshalAs(UnmanagedType.LPWStr)] string pszDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegLoadMUIStringW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string pszValue, char* pszOutBuf, int cbOutBuf, pointer unfoundType_LPDWORD_pcbData, int Flags, char* pszDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegLoadMUIStringW(nint hKey, char* pszValue, string pszOutBuf, int cbOutBuf, pointer unfoundType_LPDWORD_pcbData, int Flags, [MarshalAs(UnmanagedType.LPWStr)] string pszDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegLoadMUIStringW(nint hKey, char* pszValue, string pszOutBuf, int cbOutBuf, pointer unfoundType_LPDWORD_pcbData, int Flags, char* pszDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegLoadMUIStringW(nint hKey, char* pszValue, char* pszOutBuf, int cbOutBuf, pointer unfoundType_LPDWORD_pcbData, int Flags, [MarshalAs(UnmanagedType.LPWStr)] string pszDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegLoadMUIStringW(nint hKey, char* pszValue, char* pszOutBuf, int cbOutBuf, pointer unfoundType_LPDWORD_pcbData, int Flags, char* pszDirectory);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegSaveKeyExA(nint hKey, [MarshalAs(UnmanagedType.LPStr)] string lpFile, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegSaveKeyExA(nint hKey, byte* lpFile, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int Flags);
    [DllImport(lib, EntryPoint = "RegSaveKeyExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegSaveKeyEx(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpFile, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int Flags);
    [DllImport(lib, EntryPoint = "RegSaveKeyExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegSaveKeyEx(nint hKey, char* lpFile, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegSaveKeyExW(nint hKey, [MarshalAs(UnmanagedType.LPWStr)] string lpFile, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegSaveKeyExW(nint hKey, char* lpFile, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpSecurityAttributes, int Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer Wow64EnableWow64FsRedirection(pointer unfoundType_BOOLEAN_Wow64FsEnableRedirection);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool Wow64DisableWow64FsRedirection(pointer OldValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool Wow64RevertWow64FsRedirection(pointer OlValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsWow64Process(pointer hProcess, pointer Wow64Process);
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
        bool IsWow64Process2(pointer hProcess, pointer pProcessMachine, pointer pNativeMachine);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer IsWow64GuestMachineSupported(ushort WowGuestMachine, pointer MachineIsSupported);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool Wow64GetThreadContext(pointer hThread, pointer unfoundType_PWOW64_CONTEXT_lpContext);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool Wow64SetThreadContext(pointer hThread, pointer unfoundType_WOW64_CONTEXT_lpContext);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int Wow64SuspendThread(pointer hThread);
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
        bool GetCPInfo(uint CodePage, pointer unfoundType_LPCPINFO_lpCPInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetCPInfoExA(uint CodePage, int dwFlags, pointer unfoundType_LPCPINFOEXA_lpCPInfoEx);
    [DllImport(lib, EntryPoint = "GetCPInfoExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetCPInfoEx(uint CodePage, int dwFlags, pointer unfoundType_LPCPINFOEXW_lpCPInfoEx);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetCPInfoExW(uint CodePage, int dwFlags, pointer unfoundType_LPCPINFOEXW_lpCPInfoEx);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CompareStringA(pointer unfoundType_LCID_Locale, int dwCmpFlags, pointer unfoundType_PCNZCH_lpString1, int cchCount1, pointer unfoundType_PCNZCH_lpString2, int cchCount2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FindNLSString(pointer unfoundType_LCID_Locale, int dwFindNLSStringFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpStringSource, int cchSource, [MarshalAs(UnmanagedType.LPWStr)] string lpStringValue, int cchValue, pointer unfoundType_LPINT_pcchFound);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FindNLSString(pointer unfoundType_LCID_Locale, int dwFindNLSStringFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpStringSource, int cchSource, char* lpStringValue, int cchValue, pointer unfoundType_LPINT_pcchFound);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FindNLSString(pointer unfoundType_LCID_Locale, int dwFindNLSStringFlags, char* lpStringSource, int cchSource, [MarshalAs(UnmanagedType.LPWStr)] string lpStringValue, int cchValue, pointer unfoundType_LPINT_pcchFound);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FindNLSString(pointer unfoundType_LCID_Locale, int dwFindNLSStringFlags, char* lpStringSource, int cchSource, char* lpStringValue, int cchValue, pointer unfoundType_LPINT_pcchFound);
    [DllImport(lib, EntryPoint = "LCMapStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapString(pointer unfoundType_LCID_Locale, int dwMapFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, string lpDestStr, int cchDest);
    [DllImport(lib, EntryPoint = "LCMapStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapString(pointer unfoundType_LCID_Locale, int dwMapFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, char* lpDestStr, int cchDest);
    [DllImport(lib, EntryPoint = "LCMapStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapString(pointer unfoundType_LCID_Locale, int dwMapFlags, char* lpSrcStr, int cchSrc, string lpDestStr, int cchDest);
    [DllImport(lib, EntryPoint = "LCMapStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapString(pointer unfoundType_LCID_Locale, int dwMapFlags, char* lpSrcStr, int cchSrc, char* lpDestStr, int cchDest);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapStringW(pointer unfoundType_LCID_Locale, int dwMapFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, string lpDestStr, int cchDest);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapStringW(pointer unfoundType_LCID_Locale, int dwMapFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, char* lpDestStr, int cchDest);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapStringW(pointer unfoundType_LCID_Locale, int dwMapFlags, char* lpSrcStr, int cchSrc, string lpDestStr, int cchDest);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapStringW(pointer unfoundType_LCID_Locale, int dwMapFlags, char* lpSrcStr, int cchSrc, char* lpDestStr, int cchDest);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapStringA(pointer unfoundType_LCID_Locale, int dwMapFlags, [MarshalAs(UnmanagedType.LPStr)] string lpSrcStr, int cchSrc, [MarshalAs(UnmanagedType.LPStr)] string lpDestStr, int cchDest);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapStringA(pointer unfoundType_LCID_Locale, int dwMapFlags, [MarshalAs(UnmanagedType.LPStr)] string lpSrcStr, int cchSrc, ReadOnlySpan<byte> lpDestStr, int cchDest);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapStringA(pointer unfoundType_LCID_Locale, int dwMapFlags, [MarshalAs(UnmanagedType.LPStr)] string lpSrcStr, int cchSrc, byte* lpDestStr, int cchDest);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapStringA(pointer unfoundType_LCID_Locale, int dwMapFlags, byte* lpSrcStr, int cchSrc, [MarshalAs(UnmanagedType.LPStr)] string lpDestStr, int cchDest);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapStringA(pointer unfoundType_LCID_Locale, int dwMapFlags, byte* lpSrcStr, int cchSrc, ReadOnlySpan<byte> lpDestStr, int cchDest);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapStringA(pointer unfoundType_LCID_Locale, int dwMapFlags, byte* lpSrcStr, int cchSrc, byte* lpDestStr, int cchDest);
    [DllImport(lib, EntryPoint = "GetLocaleInfoW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLocaleInfo(pointer unfoundType_LCID_Locale, pointer unfoundType_LCTYPE_LCType, string lpLCData, int cchData);
    [DllImport(lib, EntryPoint = "GetLocaleInfoW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLocaleInfo(pointer unfoundType_LCID_Locale, pointer unfoundType_LCTYPE_LCType, char* lpLCData, int cchData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLocaleInfoW(pointer unfoundType_LCID_Locale, pointer unfoundType_LCTYPE_LCType, string lpLCData, int cchData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLocaleInfoW(pointer unfoundType_LCID_Locale, pointer unfoundType_LCTYPE_LCType, char* lpLCData, int cchData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLocaleInfoA(pointer unfoundType_LCID_Locale, pointer unfoundType_LCTYPE_LCType, [MarshalAs(UnmanagedType.LPStr)] string lpLCData, int cchData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLocaleInfoA(pointer unfoundType_LCID_Locale, pointer unfoundType_LCTYPE_LCType, ReadOnlySpan<byte> lpLCData, int cchData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLocaleInfoA(pointer unfoundType_LCID_Locale, pointer unfoundType_LCTYPE_LCType, byte* lpLCData, int cchData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetLocaleInfoA(pointer unfoundType_LCID_Locale, pointer unfoundType_LCTYPE_LCType, [MarshalAs(UnmanagedType.LPStr)] string lpLCData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetLocaleInfoA(pointer unfoundType_LCID_Locale, pointer unfoundType_LCTYPE_LCType, byte* lpLCData);
    [DllImport(lib, EntryPoint = "SetLocaleInfoW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetLocaleInfo(pointer unfoundType_LCID_Locale, pointer unfoundType_LCTYPE_LCType, [MarshalAs(UnmanagedType.LPWStr)] string lpLCData);
    [DllImport(lib, EntryPoint = "SetLocaleInfoW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetLocaleInfo(pointer unfoundType_LCID_Locale, pointer unfoundType_LCTYPE_LCType, char* lpLCData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetLocaleInfoW(pointer unfoundType_LCID_Locale, pointer unfoundType_LCTYPE_LCType, [MarshalAs(UnmanagedType.LPWStr)] string lpLCData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetLocaleInfoW(pointer unfoundType_LCID_Locale, pointer unfoundType_LCTYPE_LCType, char* lpLCData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCalendarInfoA(pointer unfoundType_LCID_Locale, pointer unfoundType_CALID_Calendar, pointer unfoundType_CALTYPE_CalType, [MarshalAs(UnmanagedType.LPStr)] string lpCalData, int cchData, pointer unfoundType_LPDWORD_lpValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCalendarInfoA(pointer unfoundType_LCID_Locale, pointer unfoundType_CALID_Calendar, pointer unfoundType_CALTYPE_CalType, ReadOnlySpan<byte> lpCalData, int cchData, pointer unfoundType_LPDWORD_lpValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCalendarInfoA(pointer unfoundType_LCID_Locale, pointer unfoundType_CALID_Calendar, pointer unfoundType_CALTYPE_CalType, byte* lpCalData, int cchData, pointer unfoundType_LPDWORD_lpValue);
    [DllImport(lib, EntryPoint = "GetCalendarInfoW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCalendarInfo(pointer unfoundType_LCID_Locale, pointer unfoundType_CALID_Calendar, pointer unfoundType_CALTYPE_CalType, string lpCalData, int cchData, pointer unfoundType_LPDWORD_lpValue);
    [DllImport(lib, EntryPoint = "GetCalendarInfoW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCalendarInfo(pointer unfoundType_LCID_Locale, pointer unfoundType_CALID_Calendar, pointer unfoundType_CALTYPE_CalType, char* lpCalData, int cchData, pointer unfoundType_LPDWORD_lpValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCalendarInfoW(pointer unfoundType_LCID_Locale, pointer unfoundType_CALID_Calendar, pointer unfoundType_CALTYPE_CalType, string lpCalData, int cchData, pointer unfoundType_LPDWORD_lpValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCalendarInfoW(pointer unfoundType_LCID_Locale, pointer unfoundType_CALID_Calendar, pointer unfoundType_CALTYPE_CalType, char* lpCalData, int cchData, pointer unfoundType_LPDWORD_lpValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetCalendarInfoA(pointer unfoundType_LCID_Locale, pointer unfoundType_CALID_Calendar, pointer unfoundType_CALTYPE_CalType, [MarshalAs(UnmanagedType.LPStr)] string lpCalData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetCalendarInfoA(pointer unfoundType_LCID_Locale, pointer unfoundType_CALID_Calendar, pointer unfoundType_CALTYPE_CalType, byte* lpCalData);
    [DllImport(lib, EntryPoint = "SetCalendarInfoW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetCalendarInfo(pointer unfoundType_LCID_Locale, pointer unfoundType_CALID_Calendar, pointer unfoundType_CALTYPE_CalType, [MarshalAs(UnmanagedType.LPWStr)] string lpCalData);
    [DllImport(lib, EntryPoint = "SetCalendarInfoW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetCalendarInfo(pointer unfoundType_LCID_Locale, pointer unfoundType_CALID_Calendar, pointer unfoundType_CALTYPE_CalType, char* lpCalData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetCalendarInfoW(pointer unfoundType_LCID_Locale, pointer unfoundType_CALID_Calendar, pointer unfoundType_CALTYPE_CalType, [MarshalAs(UnmanagedType.LPWStr)] string lpCalData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetCalendarInfoW(pointer unfoundType_LCID_Locale, pointer unfoundType_CALID_Calendar, pointer unfoundType_CALTYPE_CalType, char* lpCalData);
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
        pointer LocaleNameToLCID([MarshalAs(UnmanagedType.LPWStr)] string lpName, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LocaleNameToLCID(char* lpName, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCIDToLocaleName(pointer unfoundType_LCID_Locale, string lpName, int cchName, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCIDToLocaleName(pointer unfoundType_LCID_Locale, char* lpName, int cchName, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDurationFormat(pointer unfoundType_LCID_Locale, int dwFlags, pointer unfoundType_SYSTEMTIMElpDurationlpDuration_unnamed_2, pointer unfoundType_ULONGLONG_ullDuration, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, string lpDurationStr, int cchDuration);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDurationFormat(pointer unfoundType_LCID_Locale, int dwFlags, pointer unfoundType_SYSTEMTIMElpDurationlpDuration_unnamed_2, pointer unfoundType_ULONGLONG_ullDuration, [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, char* lpDurationStr, int cchDuration);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDurationFormat(pointer unfoundType_LCID_Locale, int dwFlags, pointer unfoundType_SYSTEMTIMElpDurationlpDuration_unnamed_2, pointer unfoundType_ULONGLONG_ullDuration, char* lpFormat, string lpDurationStr, int cchDuration);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDurationFormat(pointer unfoundType_LCID_Locale, int dwFlags, pointer unfoundType_SYSTEMTIMElpDurationlpDuration_unnamed_2, pointer unfoundType_ULONGLONG_ullDuration, char* lpFormat, char* lpDurationStr, int cchDuration);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormatA(pointer unfoundType_LCID_Locale, int dwFlags, [MarshalAs(UnmanagedType.LPStr)] string lpValue, pointer unfoundType_NUMBERFMTAlpFormatlpFormat_unnamed_3, [MarshalAs(UnmanagedType.LPStr)] string lpNumberStr, int cchNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormatA(pointer unfoundType_LCID_Locale, int dwFlags, [MarshalAs(UnmanagedType.LPStr)] string lpValue, pointer unfoundType_NUMBERFMTAlpFormatlpFormat_unnamed_3, ReadOnlySpan<byte> lpNumberStr, int cchNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormatA(pointer unfoundType_LCID_Locale, int dwFlags, [MarshalAs(UnmanagedType.LPStr)] string lpValue, pointer unfoundType_NUMBERFMTAlpFormatlpFormat_unnamed_3, byte* lpNumberStr, int cchNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormatA(pointer unfoundType_LCID_Locale, int dwFlags, byte* lpValue, pointer unfoundType_NUMBERFMTAlpFormatlpFormat_unnamed_3, [MarshalAs(UnmanagedType.LPStr)] string lpNumberStr, int cchNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormatA(pointer unfoundType_LCID_Locale, int dwFlags, byte* lpValue, pointer unfoundType_NUMBERFMTAlpFormatlpFormat_unnamed_3, ReadOnlySpan<byte> lpNumberStr, int cchNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormatA(pointer unfoundType_LCID_Locale, int dwFlags, byte* lpValue, pointer unfoundType_NUMBERFMTAlpFormatlpFormat_unnamed_3, byte* lpNumberStr, int cchNumber);
    [DllImport(lib, EntryPoint = "GetNumberFormatW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormat(pointer unfoundType_LCID_Locale, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, pointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, string lpNumberStr, int cchNumber);
    [DllImport(lib, EntryPoint = "GetNumberFormatW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormat(pointer unfoundType_LCID_Locale, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, pointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, char* lpNumberStr, int cchNumber);
    [DllImport(lib, EntryPoint = "GetNumberFormatW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormat(pointer unfoundType_LCID_Locale, int dwFlags, char* lpValue, pointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, string lpNumberStr, int cchNumber);
    [DllImport(lib, EntryPoint = "GetNumberFormatW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormat(pointer unfoundType_LCID_Locale, int dwFlags, char* lpValue, pointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, char* lpNumberStr, int cchNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormatW(pointer unfoundType_LCID_Locale, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, pointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, string lpNumberStr, int cchNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormatW(pointer unfoundType_LCID_Locale, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, pointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, char* lpNumberStr, int cchNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormatW(pointer unfoundType_LCID_Locale, int dwFlags, char* lpValue, pointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, string lpNumberStr, int cchNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormatW(pointer unfoundType_LCID_Locale, int dwFlags, char* lpValue, pointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, char* lpNumberStr, int cchNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormatA(pointer unfoundType_LCID_Locale, int dwFlags, [MarshalAs(UnmanagedType.LPStr)] string lpValue, pointer unfoundType_CURRENCYFMTAlpFormatlpFormat_unnamed_3, [MarshalAs(UnmanagedType.LPStr)] string lpCurrencyStr, int cchCurrency);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormatA(pointer unfoundType_LCID_Locale, int dwFlags, [MarshalAs(UnmanagedType.LPStr)] string lpValue, pointer unfoundType_CURRENCYFMTAlpFormatlpFormat_unnamed_3, ReadOnlySpan<byte> lpCurrencyStr, int cchCurrency);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormatA(pointer unfoundType_LCID_Locale, int dwFlags, [MarshalAs(UnmanagedType.LPStr)] string lpValue, pointer unfoundType_CURRENCYFMTAlpFormatlpFormat_unnamed_3, byte* lpCurrencyStr, int cchCurrency);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormatA(pointer unfoundType_LCID_Locale, int dwFlags, byte* lpValue, pointer unfoundType_CURRENCYFMTAlpFormatlpFormat_unnamed_3, [MarshalAs(UnmanagedType.LPStr)] string lpCurrencyStr, int cchCurrency);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormatA(pointer unfoundType_LCID_Locale, int dwFlags, byte* lpValue, pointer unfoundType_CURRENCYFMTAlpFormatlpFormat_unnamed_3, ReadOnlySpan<byte> lpCurrencyStr, int cchCurrency);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormatA(pointer unfoundType_LCID_Locale, int dwFlags, byte* lpValue, pointer unfoundType_CURRENCYFMTAlpFormatlpFormat_unnamed_3, byte* lpCurrencyStr, int cchCurrency);
    [DllImport(lib, EntryPoint = "GetCurrencyFormatW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormat(pointer unfoundType_LCID_Locale, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, pointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, string lpCurrencyStr, int cchCurrency);
    [DllImport(lib, EntryPoint = "GetCurrencyFormatW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormat(pointer unfoundType_LCID_Locale, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, pointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, char* lpCurrencyStr, int cchCurrency);
    [DllImport(lib, EntryPoint = "GetCurrencyFormatW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormat(pointer unfoundType_LCID_Locale, int dwFlags, char* lpValue, pointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, string lpCurrencyStr, int cchCurrency);
    [DllImport(lib, EntryPoint = "GetCurrencyFormatW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormat(pointer unfoundType_LCID_Locale, int dwFlags, char* lpValue, pointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, char* lpCurrencyStr, int cchCurrency);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormatW(pointer unfoundType_LCID_Locale, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, pointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, string lpCurrencyStr, int cchCurrency);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormatW(pointer unfoundType_LCID_Locale, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, pointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, char* lpCurrencyStr, int cchCurrency);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormatW(pointer unfoundType_LCID_Locale, int dwFlags, char* lpValue, pointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, string lpCurrencyStr, int cchCurrency);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormatW(pointer unfoundType_LCID_Locale, int dwFlags, char* lpValue, pointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, char* lpCurrencyStr, int cchCurrency);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumCalendarInfoA(pointer unfoundType_CALINFO_ENUMPROCA_lpCalInfoEnumProc, pointer unfoundType_LCID_Locale, pointer unfoundType_CALID_Calendar, pointer unfoundType_CALTYPE_CalType);
    [DllImport(lib, EntryPoint = "EnumCalendarInfoW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumCalendarInfo(pointer unfoundType_CALINFO_ENUMPROCW_lpCalInfoEnumProc, pointer unfoundType_LCID_Locale, pointer unfoundType_CALID_Calendar, pointer unfoundType_CALTYPE_CalType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumCalendarInfoW(pointer unfoundType_CALINFO_ENUMPROCW_lpCalInfoEnumProc, pointer unfoundType_LCID_Locale, pointer unfoundType_CALID_Calendar, pointer unfoundType_CALTYPE_CalType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumCalendarInfoExA(pointer unfoundType_CALINFO_ENUMPROCEXA_lpCalInfoEnumProcEx, pointer unfoundType_LCID_Locale, pointer unfoundType_CALID_Calendar, pointer unfoundType_CALTYPE_CalType);
    [DllImport(lib, EntryPoint = "EnumCalendarInfoExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumCalendarInfoEx(pointer unfoundType_CALINFO_ENUMPROCEXW_lpCalInfoEnumProcEx, pointer unfoundType_LCID_Locale, pointer unfoundType_CALID_Calendar, pointer unfoundType_CALTYPE_CalType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumCalendarInfoExW(pointer unfoundType_CALINFO_ENUMPROCEXW_lpCalInfoEnumProcEx, pointer unfoundType_LCID_Locale, pointer unfoundType_CALID_Calendar, pointer unfoundType_CALTYPE_CalType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumTimeFormatsA(pointer unfoundType_TIMEFMT_ENUMPROCA_lpTimeFmtEnumProc, pointer unfoundType_LCID_Locale, int dwFlags);
    [DllImport(lib, EntryPoint = "EnumTimeFormatsW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumTimeFormats(pointer unfoundType_TIMEFMT_ENUMPROCW_lpTimeFmtEnumProc, pointer unfoundType_LCID_Locale, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumTimeFormatsW(pointer unfoundType_TIMEFMT_ENUMPROCW_lpTimeFmtEnumProc, pointer unfoundType_LCID_Locale, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumDateFormatsA(pointer unfoundType_DATEFMT_ENUMPROCA_lpDateFmtEnumProc, pointer unfoundType_LCID_Locale, int dwFlags);
    [DllImport(lib, EntryPoint = "EnumDateFormatsW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumDateFormats(pointer unfoundType_DATEFMT_ENUMPROCW_lpDateFmtEnumProc, pointer unfoundType_LCID_Locale, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumDateFormatsW(pointer unfoundType_DATEFMT_ENUMPROCW_lpDateFmtEnumProc, pointer unfoundType_LCID_Locale, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumDateFormatsExA(pointer unfoundType_DATEFMT_ENUMPROCEXA_lpDateFmtEnumProcEx, pointer unfoundType_LCID_Locale, int dwFlags);
    [DllImport(lib, EntryPoint = "EnumDateFormatsExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumDateFormatsEx(pointer unfoundType_DATEFMT_ENUMPROCEXW_lpDateFmtEnumProcEx, pointer unfoundType_LCID_Locale, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumDateFormatsExW(pointer unfoundType_DATEFMT_ENUMPROCEXW_lpDateFmtEnumProcEx, pointer unfoundType_LCID_Locale, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsValidLanguageGroup(pointer unfoundType_LGRPID_LanguageGroup, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNLSVersion(pointer unfoundType_NLS_FUNCTION_Function, pointer unfoundType_LCID_Locale, pointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsValidLocale(pointer unfoundType_LCID_Locale, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetGeoInfoA(pointer unfoundType_GEOID_Location, pointer unfoundType_GEOTYPE_GeoType, [MarshalAs(UnmanagedType.LPStr)] string lpGeoData, int cchData, pointer unfoundType_LANGID_LangId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetGeoInfoA(pointer unfoundType_GEOID_Location, pointer unfoundType_GEOTYPE_GeoType, ReadOnlySpan<byte> lpGeoData, int cchData, pointer unfoundType_LANGID_LangId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetGeoInfoA(pointer unfoundType_GEOID_Location, pointer unfoundType_GEOTYPE_GeoType, byte* lpGeoData, int cchData, pointer unfoundType_LANGID_LangId);
    [DllImport(lib, EntryPoint = "GetGeoInfoW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetGeoInfo(pointer unfoundType_GEOID_Location, pointer unfoundType_GEOTYPE_GeoType, string lpGeoData, int cchData, pointer unfoundType_LANGID_LangId);
    [DllImport(lib, EntryPoint = "GetGeoInfoW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetGeoInfo(pointer unfoundType_GEOID_Location, pointer unfoundType_GEOTYPE_GeoType, char* lpGeoData, int cchData, pointer unfoundType_LANGID_LangId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetGeoInfoW(pointer unfoundType_GEOID_Location, pointer unfoundType_GEOTYPE_GeoType, string lpGeoData, int cchData, pointer unfoundType_LANGID_LangId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetGeoInfoW(pointer unfoundType_GEOID_Location, pointer unfoundType_GEOTYPE_GeoType, char* lpGeoData, int cchData, pointer unfoundType_LANGID_LangId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetGeoInfoEx([MarshalAs(UnmanagedType.LPWStr)] string location, pointer unfoundType_GEOTYPE_geoType, [MarshalAs(UnmanagedType.LPWStr)] string geoData, int geoDataCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetGeoInfoEx([MarshalAs(UnmanagedType.LPWStr)] string location, pointer unfoundType_GEOTYPE_geoType, char* geoData, int geoDataCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetGeoInfoEx(char* location, pointer unfoundType_GEOTYPE_geoType, [MarshalAs(UnmanagedType.LPWStr)] string geoData, int geoDataCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetGeoInfoEx(char* location, pointer unfoundType_GEOTYPE_geoType, char* geoData, int geoDataCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumSystemGeoID(pointer unfoundType_GEOCLASS_GeoClass, pointer unfoundType_GEOID_ParentGeoId, pointer unfoundType_GEO_ENUMPROC_lpGeoEnumProc);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumSystemGeoNames(pointer unfoundType_GEOCLASS_geoClass, pointer unfoundType_GEO_ENUMNAMEPROC_geoEnumProc, long data);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetUserGeoID(pointer unfoundType_GEOCLASS_GeoClass);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetUserDefaultGeoName(string geoName, int geoNameCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetUserDefaultGeoName(char* geoName, int geoNameCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetUserGeoID(pointer unfoundType_GEOID_GeoId);
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
        pointer ConvertDefaultLocale(pointer unfoundType_LCID_Locale);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetSystemDefaultUILanguage();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetThreadLocale();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetThreadLocale(pointer unfoundType_LCID_Locale);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetUserDefaultUILanguage();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetUserDefaultLangID();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetSystemDefaultLangID();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetSystemDefaultLCID();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetUserDefaultLCID();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer SetThreadUILanguage(pointer unfoundType_LANGID_LangId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetThreadUILanguage();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetProcessPreferredUILanguages(int dwFlags, pointer unfoundType_PULONG_pulNumLanguages, pointer unfoundType_PZZWSTR_pwszLanguagesBuffer, pointer unfoundType_PULONG_pcchLanguagesBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetProcessPreferredUILanguages(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pwszLanguagesBuffer, pointer unfoundType_PULONG_pulNumLanguages);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetProcessPreferredUILanguages(int dwFlags, char* pwszLanguagesBuffer, pointer unfoundType_PULONG_pulNumLanguages);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetUserPreferredUILanguages(int dwFlags, pointer unfoundType_PULONG_pulNumLanguages, pointer unfoundType_PZZWSTR_pwszLanguagesBuffer, pointer unfoundType_PULONG_pcchLanguagesBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetSystemPreferredUILanguages(int dwFlags, pointer unfoundType_PULONG_pulNumLanguages, pointer unfoundType_PZZWSTR_pwszLanguagesBuffer, pointer unfoundType_PULONG_pcchLanguagesBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetThreadPreferredUILanguages(int dwFlags, pointer unfoundType_PULONG_pulNumLanguages, pointer unfoundType_PZZWSTR_pwszLanguagesBuffer, pointer unfoundType_PULONG_pcchLanguagesBuffer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetThreadPreferredUILanguages(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pwszLanguagesBuffer, pointer unfoundType_PULONG_pulNumLanguages);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetThreadPreferredUILanguages(int dwFlags, char* pwszLanguagesBuffer, pointer unfoundType_PULONG_pulNumLanguages);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileMUIInfo(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pcwszFilePath, pointer unfoundType_PFILEMUIINFO_pFileMUIInfo, pointer pcbFileMUIInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileMUIInfo(int dwFlags, char* pcwszFilePath, pointer unfoundType_PFILEMUIINFO_pFileMUIInfo, pointer pcbFileMUIInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileMUIPath(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pcwszFilePath, [MarshalAs(UnmanagedType.LPWStr)] string pwszLanguage, pointer unfoundType_PULONG_pcchLanguage, [MarshalAs(UnmanagedType.LPWStr)] string pwszFileMUIPath, pointer unfoundType_PULONG_pcchFileMUIPath, pointer unfoundType_PULONGLONG_pululEnumerator);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileMUIPath(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pcwszFilePath, [MarshalAs(UnmanagedType.LPWStr)] string pwszLanguage, pointer unfoundType_PULONG_pcchLanguage, char* pwszFileMUIPath, pointer unfoundType_PULONG_pcchFileMUIPath, pointer unfoundType_PULONGLONG_pululEnumerator);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileMUIPath(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pcwszFilePath, char* pwszLanguage, pointer unfoundType_PULONG_pcchLanguage, [MarshalAs(UnmanagedType.LPWStr)] string pwszFileMUIPath, pointer unfoundType_PULONG_pcchFileMUIPath, pointer unfoundType_PULONGLONG_pululEnumerator);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileMUIPath(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pcwszFilePath, char* pwszLanguage, pointer unfoundType_PULONG_pcchLanguage, char* pwszFileMUIPath, pointer unfoundType_PULONG_pcchFileMUIPath, pointer unfoundType_PULONGLONG_pululEnumerator);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileMUIPath(int dwFlags, char* pcwszFilePath, [MarshalAs(UnmanagedType.LPWStr)] string pwszLanguage, pointer unfoundType_PULONG_pcchLanguage, [MarshalAs(UnmanagedType.LPWStr)] string pwszFileMUIPath, pointer unfoundType_PULONG_pcchFileMUIPath, pointer unfoundType_PULONGLONG_pululEnumerator);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileMUIPath(int dwFlags, char* pcwszFilePath, [MarshalAs(UnmanagedType.LPWStr)] string pwszLanguage, pointer unfoundType_PULONG_pcchLanguage, char* pwszFileMUIPath, pointer unfoundType_PULONG_pcchFileMUIPath, pointer unfoundType_PULONGLONG_pululEnumerator);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileMUIPath(int dwFlags, char* pcwszFilePath, char* pwszLanguage, pointer unfoundType_PULONG_pcchLanguage, [MarshalAs(UnmanagedType.LPWStr)] string pwszFileMUIPath, pointer unfoundType_PULONG_pcchFileMUIPath, pointer unfoundType_PULONGLONG_pululEnumerator);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetFileMUIPath(int dwFlags, char* pcwszFilePath, char* pwszLanguage, pointer unfoundType_PULONG_pcchLanguage, char* pwszFileMUIPath, pointer unfoundType_PULONG_pcchFileMUIPath, pointer unfoundType_PULONGLONG_pululEnumerator);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetUILanguageInfo(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pwmszLanguage, pointer unfoundType_PZZWSTR_pwszFallbackLanguages, pointer unfoundType_PDWORD_pcchFallbackLanguages, pointer unfoundType_PDWORD_pAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetUILanguageInfo(int dwFlags, char* pwmszLanguage, pointer unfoundType_PZZWSTR_pwszFallbackLanguages, pointer unfoundType_PDWORD_pcchFallbackLanguages, pointer unfoundType_PDWORD_pAttributes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool NotifyUILanguageChange(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pcwstrNewLanguage, [MarshalAs(UnmanagedType.LPWStr)] string pcwstrPreviousLanguage, int dwReserved, pointer unfoundType_PDWORD_pdwStatusRtrn);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool NotifyUILanguageChange(int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pcwstrNewLanguage, char* pcwstrPreviousLanguage, int dwReserved, pointer unfoundType_PDWORD_pdwStatusRtrn);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool NotifyUILanguageChange(int dwFlags, char* pcwstrNewLanguage, [MarshalAs(UnmanagedType.LPWStr)] string pcwstrPreviousLanguage, int dwReserved, pointer unfoundType_PDWORD_pdwStatusRtrn);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool NotifyUILanguageChange(int dwFlags, char* pcwstrNewLanguage, char* pcwstrPreviousLanguage, int dwReserved, pointer unfoundType_PDWORD_pdwStatusRtrn);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetStringTypeExA(pointer unfoundType_LCID_Locale, int dwInfoType, [MarshalAs(UnmanagedType.LPStr)] string lpSrcStr, int cchSrc, pointer unfoundType_LPWORD_lpCharType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetStringTypeExA(pointer unfoundType_LCID_Locale, int dwInfoType, byte* lpSrcStr, int cchSrc, pointer unfoundType_LPWORD_lpCharType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetStringTypeA(pointer unfoundType_LCID_Locale, int dwInfoType, [MarshalAs(UnmanagedType.LPStr)] string lpSrcStr, int cchSrc, pointer unfoundType_LPWORD_lpCharType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetStringTypeA(pointer unfoundType_LCID_Locale, int dwInfoType, byte* lpSrcStr, int cchSrc, pointer unfoundType_LPWORD_lpCharType);
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
        bool EnumSystemLocalesA(pointer unfoundType_LOCALE_ENUMPROCA_lpLocaleEnumProc, int dwFlags);
    [DllImport(lib, EntryPoint = "EnumSystemLocalesW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumSystemLocales(pointer unfoundType_LOCALE_ENUMPROCW_lpLocaleEnumProc, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumSystemLocalesW(pointer unfoundType_LOCALE_ENUMPROCW_lpLocaleEnumProc, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumSystemLanguageGroupsA(pointer unfoundType_LANGUAGEGROUP_ENUMPROCA_lpLanguageGroupEnumProc, int dwFlags, long lParam);
    [DllImport(lib, EntryPoint = "EnumSystemLanguageGroupsW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumSystemLanguageGroups(pointer unfoundType_LANGUAGEGROUP_ENUMPROCW_lpLanguageGroupEnumProc, int dwFlags, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumSystemLanguageGroupsW(pointer unfoundType_LANGUAGEGROUP_ENUMPROCW_lpLanguageGroupEnumProc, int dwFlags, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumLanguageGroupLocalesA(pointer unfoundType_LANGGROUPLOCALE_ENUMPROCA_lpLangGroupLocaleEnumProc, pointer unfoundType_LGRPID_LanguageGroup, int dwFlags, long lParam);
    [DllImport(lib, EntryPoint = "EnumLanguageGroupLocalesW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumLanguageGroupLocales(pointer unfoundType_LANGGROUPLOCALE_ENUMPROCW_lpLangGroupLocaleEnumProc, pointer unfoundType_LGRPID_LanguageGroup, int dwFlags, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumLanguageGroupLocalesW(pointer unfoundType_LANGGROUPLOCALE_ENUMPROCW_lpLangGroupLocaleEnumProc, pointer unfoundType_LGRPID_LanguageGroup, int dwFlags, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumUILanguagesA(pointer unfoundType_UILANGUAGE_ENUMPROCA_lpUILanguageEnumProc, int dwFlags, long lParam);
    [DllImport(lib, EntryPoint = "EnumUILanguagesW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumUILanguages(pointer unfoundType_UILANGUAGE_ENUMPROCW_lpUILanguageEnumProc, int dwFlags, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumUILanguagesW(pointer unfoundType_UILANGUAGE_ENUMPROCW_lpUILanguageEnumProc, int dwFlags, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumSystemCodePagesA(pointer unfoundType_CODEPAGE_ENUMPROCA_lpCodePageEnumProc, int dwFlags);
    [DllImport(lib, EntryPoint = "EnumSystemCodePagesW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumSystemCodePages(pointer unfoundType_CODEPAGE_ENUMPROCW_lpCodePageEnumProc, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumSystemCodePagesW(pointer unfoundType_CODEPAGE_ENUMPROCW_lpCodePageEnumProc, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLocaleInfoEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, pointer unfoundType_LCTYPE_LCType, string lpLCData, int cchData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLocaleInfoEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, pointer unfoundType_LCTYPE_LCType, char* lpLCData, int cchData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLocaleInfoEx(char* lpLocaleName, pointer unfoundType_LCTYPE_LCType, string lpLCData, int cchData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetLocaleInfoEx(char* lpLocaleName, pointer unfoundType_LCTYPE_LCType, char* lpLCData, int cchData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCalendarInfoEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, pointer unfoundType_CALID_Calendar, [MarshalAs(UnmanagedType.LPWStr)] string lpReserved, pointer unfoundType_CALTYPE_CalType, string lpCalData, int cchData, pointer unfoundType_LPDWORD_lpValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCalendarInfoEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, pointer unfoundType_CALID_Calendar, [MarshalAs(UnmanagedType.LPWStr)] string lpReserved, pointer unfoundType_CALTYPE_CalType, char* lpCalData, int cchData, pointer unfoundType_LPDWORD_lpValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCalendarInfoEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, pointer unfoundType_CALID_Calendar, char* lpReserved, pointer unfoundType_CALTYPE_CalType, string lpCalData, int cchData, pointer unfoundType_LPDWORD_lpValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCalendarInfoEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, pointer unfoundType_CALID_Calendar, char* lpReserved, pointer unfoundType_CALTYPE_CalType, char* lpCalData, int cchData, pointer unfoundType_LPDWORD_lpValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCalendarInfoEx(char* lpLocaleName, pointer unfoundType_CALID_Calendar, [MarshalAs(UnmanagedType.LPWStr)] string lpReserved, pointer unfoundType_CALTYPE_CalType, string lpCalData, int cchData, pointer unfoundType_LPDWORD_lpValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCalendarInfoEx(char* lpLocaleName, pointer unfoundType_CALID_Calendar, [MarshalAs(UnmanagedType.LPWStr)] string lpReserved, pointer unfoundType_CALTYPE_CalType, char* lpCalData, int cchData, pointer unfoundType_LPDWORD_lpValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCalendarInfoEx(char* lpLocaleName, pointer unfoundType_CALID_Calendar, char* lpReserved, pointer unfoundType_CALTYPE_CalType, string lpCalData, int cchData, pointer unfoundType_LPDWORD_lpValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCalendarInfoEx(char* lpLocaleName, pointer unfoundType_CALID_Calendar, char* lpReserved, pointer unfoundType_CALTYPE_CalType, char* lpCalData, int cchData, pointer unfoundType_LPDWORD_lpValue);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, pointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, string lpNumberStr, int cchNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, pointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, char* lpNumberStr, int cchNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, char* lpValue, pointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, string lpNumberStr, int cchNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, char* lpValue, pointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, char* lpNumberStr, int cchNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormatEx(char* lpLocaleName, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, pointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, string lpNumberStr, int cchNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormatEx(char* lpLocaleName, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, pointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, char* lpNumberStr, int cchNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormatEx(char* lpLocaleName, int dwFlags, char* lpValue, pointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, string lpNumberStr, int cchNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetNumberFormatEx(char* lpLocaleName, int dwFlags, char* lpValue, pointer unfoundType_NUMBERFMTWlpFormatlpFormat_unnamed_3, char* lpNumberStr, int cchNumber);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, pointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, string lpCurrencyStr, int cchCurrency);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, pointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, char* lpCurrencyStr, int cchCurrency);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, char* lpValue, pointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, string lpCurrencyStr, int cchCurrency);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormatEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, char* lpValue, pointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, char* lpCurrencyStr, int cchCurrency);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormatEx(char* lpLocaleName, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, pointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, string lpCurrencyStr, int cchCurrency);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormatEx(char* lpLocaleName, int dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpValue, pointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, char* lpCurrencyStr, int cchCurrency);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormatEx(char* lpLocaleName, int dwFlags, char* lpValue, pointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, string lpCurrencyStr, int cchCurrency);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetCurrencyFormatEx(char* lpLocaleName, int dwFlags, char* lpValue, pointer unfoundType_CURRENCYFMTWlpFormatlpFormat_unnamed_3, char* lpCurrencyStr, int cchCurrency);
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
        bool IsNLSDefinedString(pointer unfoundType_NLS_FUNCTION_Function, int dwFlags, pointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, [MarshalAs(UnmanagedType.LPWStr)] string lpString, int cchStr);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsNLSDefinedString(pointer unfoundType_NLS_FUNCTION_Function, int dwFlags, pointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, char* lpString, int cchStr);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNLSVersionEx(pointer unfoundType_NLS_FUNCTION_function, [MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, pointer unfoundType_LPNLSVERSIONINFOEX_lpVersionInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetNLSVersionEx(pointer unfoundType_NLS_FUNCTION_function, char* lpLocaleName, pointer unfoundType_LPNLSVERSIONINFOEX_lpVersionInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int IsValidNLSVersion(pointer unfoundType_NLS_FUNCTION_function, [MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, pointer unfoundType_LPNLSVERSIONINFOEX_lpVersionInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int IsValidNLSVersion(pointer unfoundType_NLS_FUNCTION_function, char* lpLocaleName, pointer unfoundType_LPNLSVERSIONINFOEX_lpVersionInformation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FindNLSStringEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFindNLSStringFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpStringSource, int cchSource, [MarshalAs(UnmanagedType.LPWStr)] string lpStringValue, int cchValue, pointer unfoundType_LPINT_pcchFound, pointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, pointer lpReserved, long sortHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FindNLSStringEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFindNLSStringFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpStringSource, int cchSource, char* lpStringValue, int cchValue, pointer unfoundType_LPINT_pcchFound, pointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, pointer lpReserved, long sortHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FindNLSStringEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFindNLSStringFlags, char* lpStringSource, int cchSource, [MarshalAs(UnmanagedType.LPWStr)] string lpStringValue, int cchValue, pointer unfoundType_LPINT_pcchFound, pointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, pointer lpReserved, long sortHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FindNLSStringEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFindNLSStringFlags, char* lpStringSource, int cchSource, char* lpStringValue, int cchValue, pointer unfoundType_LPINT_pcchFound, pointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, pointer lpReserved, long sortHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FindNLSStringEx(char* lpLocaleName, int dwFindNLSStringFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpStringSource, int cchSource, [MarshalAs(UnmanagedType.LPWStr)] string lpStringValue, int cchValue, pointer unfoundType_LPINT_pcchFound, pointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, pointer lpReserved, long sortHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FindNLSStringEx(char* lpLocaleName, int dwFindNLSStringFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpStringSource, int cchSource, char* lpStringValue, int cchValue, pointer unfoundType_LPINT_pcchFound, pointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, pointer lpReserved, long sortHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FindNLSStringEx(char* lpLocaleName, int dwFindNLSStringFlags, char* lpStringSource, int cchSource, [MarshalAs(UnmanagedType.LPWStr)] string lpStringValue, int cchValue, pointer unfoundType_LPINT_pcchFound, pointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, pointer lpReserved, long sortHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FindNLSStringEx(char* lpLocaleName, int dwFindNLSStringFlags, char* lpStringSource, int cchSource, char* lpStringValue, int cchValue, pointer unfoundType_LPINT_pcchFound, pointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, pointer lpReserved, long sortHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapStringEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwMapFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, string lpDestStr, int cchDest, pointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, pointer lpReserved, long sortHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapStringEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwMapFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, char* lpDestStr, int cchDest, pointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, pointer lpReserved, long sortHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapStringEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwMapFlags, char* lpSrcStr, int cchSrc, string lpDestStr, int cchDest, pointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, pointer lpReserved, long sortHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapStringEx([MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwMapFlags, char* lpSrcStr, int cchSrc, char* lpDestStr, int cchDest, pointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, pointer lpReserved, long sortHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapStringEx(char* lpLocaleName, int dwMapFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, string lpDestStr, int cchDest, pointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, pointer lpReserved, long sortHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapStringEx(char* lpLocaleName, int dwMapFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, char* lpDestStr, int cchDest, pointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, pointer lpReserved, long sortHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapStringEx(char* lpLocaleName, int dwMapFlags, char* lpSrcStr, int cchSrc, string lpDestStr, int cchDest, pointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, pointer lpReserved, long sortHandle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LCMapStringEx(char* lpLocaleName, int dwMapFlags, char* lpSrcStr, int cchSrc, char* lpDestStr, int cchDest, pointer unfoundType_LPNLSVERSIONINFO_lpVersionInformation, pointer lpReserved, long sortHandle);
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
        bool EnumCalendarInfoExEx(pointer unfoundType_CALINFO_ENUMPROCEXEX_pCalInfoEnumProcExEx, [MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, pointer unfoundType_CALID_Calendar, [MarshalAs(UnmanagedType.LPWStr)] string lpReserved, pointer unfoundType_CALTYPE_CalType, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumCalendarInfoExEx(pointer unfoundType_CALINFO_ENUMPROCEXEX_pCalInfoEnumProcExEx, [MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, pointer unfoundType_CALID_Calendar, char* lpReserved, pointer unfoundType_CALTYPE_CalType, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumCalendarInfoExEx(pointer unfoundType_CALINFO_ENUMPROCEXEX_pCalInfoEnumProcExEx, char* lpLocaleName, pointer unfoundType_CALID_Calendar, [MarshalAs(UnmanagedType.LPWStr)] string lpReserved, pointer unfoundType_CALTYPE_CalType, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumCalendarInfoExEx(pointer unfoundType_CALINFO_ENUMPROCEXEX_pCalInfoEnumProcExEx, char* lpLocaleName, pointer unfoundType_CALID_Calendar, char* lpReserved, pointer unfoundType_CALTYPE_CalType, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumDateFormatsExEx(pointer unfoundType_DATEFMT_ENUMPROCEXEX_lpDateFmtEnumProcExEx, [MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumDateFormatsExEx(pointer unfoundType_DATEFMT_ENUMPROCEXEX_lpDateFmtEnumProcExEx, char* lpLocaleName, int dwFlags, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumTimeFormatsEx(pointer unfoundType_TIMEFMT_ENUMPROCEX_lpTimeFmtEnumProcEx, [MarshalAs(UnmanagedType.LPWStr)] string lpLocaleName, int dwFlags, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumTimeFormatsEx(pointer unfoundType_TIMEFMT_ENUMPROCEX_lpTimeFmtEnumProcEx, char* lpLocaleName, int dwFlags, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumSystemLocalesEx(pointer unfoundType_LOCALE_ENUMPROCEX_lpLocaleEnumProcEx, int dwFlags, long lParam, pointer lpReserved);
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