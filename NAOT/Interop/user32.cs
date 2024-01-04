using System.Runtime.InteropServices;

public unsafe class user32
{
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int LoadStringA(cpointer unfoundType_HINSTANCE_hInstance, uint uID, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, int cchBufferMax);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int LoadStringA(cpointer unfoundType_HINSTANCE_hInstance, uint uID, ReadOnlySpan<byte> lpBuffer, int cchBufferMax);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int LoadStringA(cpointer unfoundType_HINSTANCE_hInstance, uint uID, byte* lpBuffer, int cchBufferMax);
    [DllImport("user32", EntryPoint="LoadStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int LoadString(cpointer unfoundType_HINSTANCE_hInstance, uint uID, string lpBuffer, int cchBufferMax);
    [DllImport("user32", EntryPoint="LoadStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int LoadString(cpointer unfoundType_HINSTANCE_hInstance, uint uID, char* lpBuffer, int cchBufferMax);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int LoadStringW(cpointer unfoundType_HINSTANCE_hInstance, uint uID, string lpBuffer, int cchBufferMax);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int LoadStringW(cpointer unfoundType_HINSTANCE_hInstance, uint uID, char* lpBuffer, int cchBufferMax);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DdeSetQualityOfService(cpointer hwndClient, cpointer unfoundType_SECURITY_QUALITY_OF_SERVICEpqosNewpqosNew_unnamed_1, cpointer unfoundType_PSECURITY_QUALITY_OF_SERVICE_pqosPrev);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ImpersonateDdeClientWindow(cpointer hWndClient, cpointer hWndServer);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint DdeInitializeA(cpointer unfoundType_LPDWORD_pidInst, cpointer unfoundType_PFNCALLBACK_pfnCallback, int afCmd, int ulRes);
    [DllImport("user32", EntryPoint="DdeInitializeW", SetLastError=true, ExactSpelling=true)] public static extern
        uint DdeInitialize(cpointer unfoundType_LPDWORD_pidInst, cpointer unfoundType_PFNCALLBACK_pfnCallback, int afCmd, int ulRes);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint DdeInitializeW(cpointer unfoundType_LPDWORD_pidInst, cpointer unfoundType_PFNCALLBACK_pfnCallback, int afCmd, int ulRes);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DdeUninitialize(int idInst);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer DdeConnectList(int idInst, cpointer unfoundType_HSZ_hszService, cpointer unfoundType_HSZ_hszTopic, cpointer unfoundType_HCONVLIST_hConvList, cpointer unfoundType_PCONVCONTEXT_pCC);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer DdeQueryNextServer(cpointer unfoundType_HCONVLIST_hConvList, cpointer unfoundType_HCONV_hConvPrev);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DdeDisconnectList(cpointer unfoundType_HCONVLIST_hConvList);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer DdeConnect(int idInst, cpointer unfoundType_HSZ_hszService, cpointer unfoundType_HSZ_hszTopic, cpointer unfoundType_PCONVCONTEXT_pCC);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DdeDisconnect(cpointer unfoundType_HCONV_hConv);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer DdeReconnect(cpointer unfoundType_HCONV_hConv);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint DdeQueryConvInfo(cpointer unfoundType_HCONV_hConv, int idTransaction, cpointer unfoundType_PCONVINFO_pConvInfo);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DdeSetUserHandle(cpointer unfoundType_HCONV_hConv, int id, cpointer unfoundType_DWORD_PTR_hUser);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DdeAbandonTransaction(int idInst, cpointer unfoundType_HCONV_hConv, int idTransaction);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DdePostAdvise(int idInst, cpointer unfoundType_HSZ_hszTopic, cpointer unfoundType_HSZ_hszItem);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DdeEnableCallback(int idInst, cpointer unfoundType_HCONV_hConv, uint wCmd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DdeImpersonateClient(cpointer unfoundType_HCONV_hConv);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer DdeNameService(int idInst, cpointer unfoundType_HSZ_hsz1, cpointer unfoundType_HSZ_hsz2, uint afCmd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer DdeClientTransaction(cpointer unfoundType_LPBYTE_pData, int cbData, cpointer unfoundType_HCONV_hConv, cpointer unfoundType_HSZ_hszItem, uint wFmt, uint wType, int dwTimeout, cpointer unfoundType_LPDWORD_pdwResult);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer DdeCreateDataHandle(int idInst, cpointer unfoundType_LPBYTE_pSrc, int cb, int cbOff, cpointer unfoundType_HSZ_hszItem, uint wFmt, uint afCmd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer DdeAddData(cpointer unfoundType_HDDEDATA_hData, cpointer unfoundType_LPBYTE_pSrc, int cb, int cbOff);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DdeGetData(cpointer unfoundType_HDDEDATA_hData, cpointer unfoundType_LPBYTE_pDst, int cbMax, int cbOff);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer DdeAccessData(cpointer unfoundType_HDDEDATA_hData, cpointer unfoundType_LPDWORD_pcbDataSize);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DdeUnaccessData(cpointer unfoundType_HDDEDATA_hData);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DdeFreeDataHandle(cpointer unfoundType_HDDEDATA_hData);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint DdeGetLastError(int idInst);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer DdeCreateStringHandleA(int idInst, cpointer unfoundType_LPCSTR_psz, int iCodePage);
    [DllImport("user32", EntryPoint="DdeCreateStringHandleW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer DdeCreateStringHandle(int idInst, [MarshalAs(UnmanagedType.LPWStr)] string psz, int iCodePage);
    [DllImport("user32", EntryPoint="DdeCreateStringHandleW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer DdeCreateStringHandle(int idInst, char* psz, int iCodePage);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer DdeCreateStringHandleW(int idInst, [MarshalAs(UnmanagedType.LPWStr)] string psz, int iCodePage);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer DdeCreateStringHandleW(int idInst, char* psz, int iCodePage);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DdeQueryStringA(int idInst, cpointer unfoundType_HSZ_hsz, [MarshalAs(UnmanagedType.LPStr)] string psz, int cchMax, int iCodePage);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DdeQueryStringA(int idInst, cpointer unfoundType_HSZ_hsz, ReadOnlySpan<byte> psz, int cchMax, int iCodePage);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DdeQueryStringA(int idInst, cpointer unfoundType_HSZ_hsz, byte* psz, int cchMax, int iCodePage);
    [DllImport("user32", EntryPoint="DdeQueryStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int DdeQueryString(int idInst, cpointer unfoundType_HSZ_hsz, string psz, int cchMax, int iCodePage);
    [DllImport("user32", EntryPoint="DdeQueryStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int DdeQueryString(int idInst, cpointer unfoundType_HSZ_hsz, char* psz, int cchMax, int iCodePage);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DdeQueryStringW(int idInst, cpointer unfoundType_HSZ_hsz, string psz, int cchMax, int iCodePage);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DdeQueryStringW(int idInst, cpointer unfoundType_HSZ_hsz, char* psz, int cchMax, int iCodePage);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DdeFreeStringHandle(int idInst, cpointer unfoundType_HSZ_hsz);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DdeKeepStringHandle(int idInst, cpointer unfoundType_HSZ_hsz);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DdeCmpStringHandles(cpointer unfoundType_HSZ_hsz1, cpointer unfoundType_HSZ_hsz2);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int wvsprintfA([MarshalAs(UnmanagedType.LPStr)] string unnamed_0, cpointer unfoundType_LPCSTR_unnamed_1, cpointer arglist);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int wvsprintfA(ReadOnlySpan<byte> unnamed_0, cpointer unfoundType_LPCSTR_unnamed_1, cpointer arglist);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int wvsprintfA(byte* unnamed_0, cpointer unfoundType_LPCSTR_unnamed_1, cpointer arglist);
    [DllImport("user32", EntryPoint="wvsprintfW", SetLastError=true, ExactSpelling=true)] public static extern
        int wvsprintf(string unnamed_0, [MarshalAs(UnmanagedType.LPWStr)] string unnamed_1, cpointer arglist);
    [DllImport("user32", EntryPoint="wvsprintfW", SetLastError=true, ExactSpelling=true)] public static extern
        int wvsprintf(string unnamed_0, char* unnamed_1, cpointer arglist);
    [DllImport("user32", EntryPoint="wvsprintfW", SetLastError=true, ExactSpelling=true)] public static extern
        int wvsprintf(char* unnamed_0, [MarshalAs(UnmanagedType.LPWStr)] string unnamed_1, cpointer arglist);
    [DllImport("user32", EntryPoint="wvsprintfW", SetLastError=true, ExactSpelling=true)] public static extern
        int wvsprintf(char* unnamed_0, char* unnamed_1, cpointer arglist);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int wvsprintfW(string unnamed_0, [MarshalAs(UnmanagedType.LPWStr)] string unnamed_1, cpointer arglist);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int wvsprintfW(string unnamed_0, char* unnamed_1, cpointer arglist);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int wvsprintfW(char* unnamed_0, [MarshalAs(UnmanagedType.LPWStr)] string unnamed_1, cpointer arglist);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int wvsprintfW(char* unnamed_0, char* unnamed_1, cpointer arglist);
    [DllImport("user32", SetLastError=true, ExactSpelling=true, CallingConvention=CallingConvention.Cdecl)] public static extern
        int wsprintfA([MarshalAs(UnmanagedType.LPStr)] string unnamed_0, cpointer unfoundType_LPCSTR_unnamed_1, cpointer unnamed_2);
    [DllImport("user32", SetLastError=true, ExactSpelling=true, CallingConvention=CallingConvention.Cdecl)] public static extern
        int wsprintfA(ReadOnlySpan<byte> unnamed_0, cpointer unfoundType_LPCSTR_unnamed_1, cpointer unnamed_2);
    [DllImport("user32", SetLastError=true, ExactSpelling=true, CallingConvention=CallingConvention.Cdecl)] public static extern
        int wsprintfA(byte* unnamed_0, cpointer unfoundType_LPCSTR_unnamed_1, cpointer unnamed_2);
    [DllImport("user32", EntryPoint="wsprintfW", SetLastError=true, ExactSpelling=true, CallingConvention=CallingConvention.Cdecl)] public static extern
        int wsprintf(string unnamed_0, [MarshalAs(UnmanagedType.LPWStr)] string unnamed_1, cpointer unnamed_2);
    [DllImport("user32", EntryPoint="wsprintfW", SetLastError=true, ExactSpelling=true, CallingConvention=CallingConvention.Cdecl)] public static extern
        int wsprintf(string unnamed_0, char* unnamed_1, cpointer unnamed_2);
    [DllImport("user32", EntryPoint="wsprintfW", SetLastError=true, ExactSpelling=true, CallingConvention=CallingConvention.Cdecl)] public static extern
        int wsprintf(char* unnamed_0, [MarshalAs(UnmanagedType.LPWStr)] string unnamed_1, cpointer unnamed_2);
    [DllImport("user32", EntryPoint="wsprintfW", SetLastError=true, ExactSpelling=true, CallingConvention=CallingConvention.Cdecl)] public static extern
        int wsprintf(char* unnamed_0, char* unnamed_1, cpointer unnamed_2);
    [DllImport("user32", SetLastError=true, ExactSpelling=true, CallingConvention=CallingConvention.Cdecl)] public static extern
        int wsprintfW(string unnamed_0, [MarshalAs(UnmanagedType.LPWStr)] string unnamed_1, cpointer unnamed_2);
    [DllImport("user32", SetLastError=true, ExactSpelling=true, CallingConvention=CallingConvention.Cdecl)] public static extern
        int wsprintfW(string unnamed_0, char* unnamed_1, cpointer unnamed_2);
    [DllImport("user32", SetLastError=true, ExactSpelling=true, CallingConvention=CallingConvention.Cdecl)] public static extern
        int wsprintfW(char* unnamed_0, [MarshalAs(UnmanagedType.LPWStr)] string unnamed_1, cpointer unnamed_2);
    [DllImport("user32", SetLastError=true, ExactSpelling=true, CallingConvention=CallingConvention.Cdecl)] public static extern
        int wsprintfW(char* unnamed_0, char* unnamed_1, cpointer unnamed_2);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadKeyboardLayoutA(cpointer unfoundType_LPCSTR_pwszKLID, uint Flags);
    [DllImport("user32", EntryPoint="LoadKeyboardLayoutW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadKeyboardLayout([MarshalAs(UnmanagedType.LPWStr)] string pwszKLID, uint Flags);
    [DllImport("user32", EntryPoint="LoadKeyboardLayoutW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadKeyboardLayout(char* pwszKLID, uint Flags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadKeyboardLayoutW([MarshalAs(UnmanagedType.LPWStr)] string pwszKLID, uint Flags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadKeyboardLayoutW(char* pwszKLID, uint Flags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer ActivateKeyboardLayout(cpointer unfoundType_HKL_hkl, uint Flags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ToUnicodeEx(uint wVirtKey, uint wScanCode, cpointer unfoundType_BYTElpKeyStatelpKeyState_unnamed_2, string pwszBuff, int cchBuff, uint wFlags, cpointer unfoundType_HKL_dwhkl);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ToUnicodeEx(uint wVirtKey, uint wScanCode, cpointer unfoundType_BYTElpKeyStatelpKeyState_unnamed_2, char* pwszBuff, int cchBuff, uint wFlags, cpointer unfoundType_HKL_dwhkl);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int UnloadKeyboardLayout(cpointer unfoundType_HKL_hkl);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetKeyboardLayoutNameA([MarshalAs(UnmanagedType.LPStr)] string pwszKLID);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetKeyboardLayoutNameA(ReadOnlySpan<byte> pwszKLID);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetKeyboardLayoutNameA(byte* pwszKLID);
    [DllImport("user32", EntryPoint="GetKeyboardLayoutNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetKeyboardLayoutName(string pwszKLID);
    [DllImport("user32", EntryPoint="GetKeyboardLayoutNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetKeyboardLayoutName(char* pwszKLID);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetKeyboardLayoutNameW(string pwszKLID);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetKeyboardLayoutNameW(char* pwszKLID);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetKeyboardLayoutList(int nBuff, cpointer unfoundType_HKLlpListlpList_unnamed_1);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetKeyboardLayout(int idThread);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetMouseMovePointsEx(uint cbSize, cpointer unfoundType_LPMOUSEMOVEPOINT_lppt, cpointer unfoundType_LPMOUSEMOVEPOINT_lpptBuf, int nBufPoints, int resolution);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateDesktopA(cpointer unfoundType_LPCSTR_lpszDesktop, cpointer unfoundType_LPCSTR_lpszDevice, cpointer unfoundType_DEVMODEA_pDevmode, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport("user32", EntryPoint="CreateDesktopW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateDesktop([MarshalAs(UnmanagedType.LPWStr)] string lpszDesktop, [MarshalAs(UnmanagedType.LPWStr)] string lpszDevice, cpointer unfoundType_DEVMODEW_pDevmode, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport("user32", EntryPoint="CreateDesktopW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateDesktop([MarshalAs(UnmanagedType.LPWStr)] string lpszDesktop, char* lpszDevice, cpointer unfoundType_DEVMODEW_pDevmode, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport("user32", EntryPoint="CreateDesktopW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateDesktop(char* lpszDesktop, [MarshalAs(UnmanagedType.LPWStr)] string lpszDevice, cpointer unfoundType_DEVMODEW_pDevmode, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport("user32", EntryPoint="CreateDesktopW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateDesktop(char* lpszDesktop, char* lpszDevice, cpointer unfoundType_DEVMODEW_pDevmode, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateDesktopW([MarshalAs(UnmanagedType.LPWStr)] string lpszDesktop, [MarshalAs(UnmanagedType.LPWStr)] string lpszDevice, cpointer unfoundType_DEVMODEW_pDevmode, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateDesktopW([MarshalAs(UnmanagedType.LPWStr)] string lpszDesktop, char* lpszDevice, cpointer unfoundType_DEVMODEW_pDevmode, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateDesktopW(char* lpszDesktop, [MarshalAs(UnmanagedType.LPWStr)] string lpszDevice, cpointer unfoundType_DEVMODEW_pDevmode, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateDesktopW(char* lpszDesktop, char* lpszDevice, cpointer unfoundType_DEVMODEW_pDevmode, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateDesktopExA(cpointer unfoundType_LPCSTR_lpszDesktop, cpointer unfoundType_LPCSTR_lpszDevice, cpointer unfoundType_DEVMODEA_pDevmode, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa, uint ulHeapSize, cpointer pvoid);
    [DllImport("user32", EntryPoint="CreateDesktopExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateDesktopEx([MarshalAs(UnmanagedType.LPWStr)] string lpszDesktop, [MarshalAs(UnmanagedType.LPWStr)] string lpszDevice, cpointer unfoundType_DEVMODEW_pDevmode, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa, uint ulHeapSize, cpointer pvoid);
    [DllImport("user32", EntryPoint="CreateDesktopExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateDesktopEx([MarshalAs(UnmanagedType.LPWStr)] string lpszDesktop, char* lpszDevice, cpointer unfoundType_DEVMODEW_pDevmode, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa, uint ulHeapSize, cpointer pvoid);
    [DllImport("user32", EntryPoint="CreateDesktopExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateDesktopEx(char* lpszDesktop, [MarshalAs(UnmanagedType.LPWStr)] string lpszDevice, cpointer unfoundType_DEVMODEW_pDevmode, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa, uint ulHeapSize, cpointer pvoid);
    [DllImport("user32", EntryPoint="CreateDesktopExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateDesktopEx(char* lpszDesktop, char* lpszDevice, cpointer unfoundType_DEVMODEW_pDevmode, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa, uint ulHeapSize, cpointer pvoid);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateDesktopExW([MarshalAs(UnmanagedType.LPWStr)] string lpszDesktop, [MarshalAs(UnmanagedType.LPWStr)] string lpszDevice, cpointer unfoundType_DEVMODEW_pDevmode, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa, uint ulHeapSize, cpointer pvoid);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateDesktopExW([MarshalAs(UnmanagedType.LPWStr)] string lpszDesktop, char* lpszDevice, cpointer unfoundType_DEVMODEW_pDevmode, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa, uint ulHeapSize, cpointer pvoid);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateDesktopExW(char* lpszDesktop, [MarshalAs(UnmanagedType.LPWStr)] string lpszDevice, cpointer unfoundType_DEVMODEW_pDevmode, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa, uint ulHeapSize, cpointer pvoid);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateDesktopExW(char* lpszDesktop, char* lpszDevice, cpointer unfoundType_DEVMODEW_pDevmode, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa, uint ulHeapSize, cpointer pvoid);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenDesktopA(cpointer unfoundType_LPCSTR_lpszDesktop, int dwFlags, int fInherit, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess);
    [DllImport("user32", EntryPoint="OpenDesktopW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenDesktop([MarshalAs(UnmanagedType.LPWStr)] string lpszDesktop, int dwFlags, int fInherit, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess);
    [DllImport("user32", EntryPoint="OpenDesktopW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenDesktop(char* lpszDesktop, int dwFlags, int fInherit, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenDesktopW([MarshalAs(UnmanagedType.LPWStr)] string lpszDesktop, int dwFlags, int fInherit, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenDesktopW(char* lpszDesktop, int dwFlags, int fInherit, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenInputDesktop(int dwFlags, int fInherit, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumDesktopsA(cpointer unfoundType_HWINSTA_hwinsta, cpointer unfoundType_DESKTOPENUMPROCA_lpEnumFunc, long lParam);
    [DllImport("user32", EntryPoint="EnumDesktopsW", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumDesktops(cpointer unfoundType_HWINSTA_hwinsta, cpointer unfoundType_DESKTOPENUMPROCW_lpEnumFunc, long lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumDesktopsW(cpointer unfoundType_HWINSTA_hwinsta, cpointer unfoundType_DESKTOPENUMPROCW_lpEnumFunc, long lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumDesktopWindows(cpointer unfoundType_HDESK_hDesktop, cpointer unfoundType_WNDENUMPROC_lpfn, long lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SwitchDesktop(cpointer unfoundType_HDESK_hDesktop);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetThreadDesktop(cpointer unfoundType_HDESK_hDesktop);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CloseDesktop(cpointer unfoundType_HDESK_hDesktop);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetThreadDesktop(int dwThreadId);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateWindowStationA(cpointer unfoundType_LPCSTR_lpwinsta, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport("user32", EntryPoint="CreateWindowStationW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateWindowStation([MarshalAs(UnmanagedType.LPWStr)] string lpwinsta, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport("user32", EntryPoint="CreateWindowStationW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateWindowStation(char* lpwinsta, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateWindowStationW([MarshalAs(UnmanagedType.LPWStr)] string lpwinsta, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateWindowStationW(char* lpwinsta, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenWindowStationA(cpointer unfoundType_LPCSTR_lpszWinSta, int fInherit, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess);
    [DllImport("user32", EntryPoint="OpenWindowStationW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenWindowStation([MarshalAs(UnmanagedType.LPWStr)] string lpszWinSta, int fInherit, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess);
    [DllImport("user32", EntryPoint="OpenWindowStationW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenWindowStation(char* lpszWinSta, int fInherit, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenWindowStationW([MarshalAs(UnmanagedType.LPWStr)] string lpszWinSta, int fInherit, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer OpenWindowStationW(char* lpszWinSta, int fInherit, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumWindowStationsA(cpointer unfoundType_WINSTAENUMPROCA_lpEnumFunc, long lParam);
    [DllImport("user32", EntryPoint="EnumWindowStationsW", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumWindowStations(cpointer unfoundType_WINSTAENUMPROCW_lpEnumFunc, long lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumWindowStationsW(cpointer unfoundType_WINSTAENUMPROCW_lpEnumFunc, long lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CloseWindowStation(cpointer unfoundType_HWINSTA_hWinSta);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetProcessWindowStation(cpointer unfoundType_HWINSTA_hWinSta);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetProcessWindowStation();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetUserObjectSecurity(cpointer hObj, cpointer unfoundType_PSECURITY_INFORMATION_pSIRequested, cpointer unfoundType_PSECURITY_DESCRIPTOR_pSID);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetUserObjectSecurity(cpointer hObj, cpointer unfoundType_PSECURITY_INFORMATION_pSIRequested, cpointer unfoundType_PSECURITY_DESCRIPTOR_pSID, int nLength, cpointer unfoundType_LPDWORD_lpnLengthNeeded);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetUserObjectInformationA(cpointer hObj, int nIndex, cpointer pvInfo, int nLength, cpointer unfoundType_LPDWORD_lpnLengthNeeded);
    [DllImport("user32", EntryPoint="GetUserObjectInformationW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetUserObjectInformation(cpointer hObj, int nIndex, cpointer pvInfo, int nLength, cpointer unfoundType_LPDWORD_lpnLengthNeeded);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetUserObjectInformationW(cpointer hObj, int nIndex, cpointer pvInfo, int nLength, cpointer unfoundType_LPDWORD_lpnLengthNeeded);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetUserObjectInformationA(cpointer hObj, int nIndex, cpointer pvInfo, int nLength);
    [DllImport("user32", EntryPoint="SetUserObjectInformationW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetUserObjectInformation(cpointer hObj, int nIndex, cpointer pvInfo, int nLength);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetUserObjectInformationW(cpointer hObj, int nIndex, cpointer pvInfo, int nLength);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsHungAppWindow(cpointer hwnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        void DisableProcessWindowsGhosting();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint RegisterWindowMessageA(cpointer unfoundType_LPCSTR_lpString);
    [DllImport("user32", EntryPoint="RegisterWindowMessageW", SetLastError=true, ExactSpelling=true)] public static extern
        uint RegisterWindowMessage([MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport("user32", EntryPoint="RegisterWindowMessageW", SetLastError=true, ExactSpelling=true)] public static extern
        uint RegisterWindowMessage(char* lpString);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint RegisterWindowMessageW([MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint RegisterWindowMessageW(char* lpString);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int TrackMouseEvent(cpointer unfoundType_LPTRACKMOUSEEVENT_lpEventTrack);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DrawEdge(cpointer hdc, cpointer unfoundType_LPRECT_qrc, uint edge, uint grfFlags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DrawFrameControl(cpointer unnamed_0, cpointer unfoundType_LPRECT_unnamed_1, uint unnamed_2, uint unnamed_3);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DrawCaption(cpointer hwnd, cpointer hdc, cpointer unfoundType_RECT_lprect, uint flags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DrawAnimatedRects(cpointer hwnd, int idAni, cpointer unfoundType_RECTlprcFromlprcFrom_unnamed_2, cpointer unfoundType_RECTlprcTolprcTo_unnamed_3);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetMessageA(cpointer unfoundType_LPMSG_lpMsg, cpointer hWnd, uint wMsgFilterMin, uint wMsgFilterMax);
    [DllImport("user32", EntryPoint="GetMessageW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetMessage(cpointer unfoundType_LPMSG_lpMsg, cpointer hWnd, uint wMsgFilterMin, uint wMsgFilterMax);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetMessageW(cpointer unfoundType_LPMSG_lpMsg, cpointer hWnd, uint wMsgFilterMin, uint wMsgFilterMax);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int TranslateMessage(cpointer unfoundType_MSGlpMsglpMsg_unnamed_0);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        long DispatchMessageA(cpointer unfoundType_MSGlpMsglpMsg_unnamed_0);
    [DllImport("user32", EntryPoint="DispatchMessageW", SetLastError=true, ExactSpelling=true)] public static extern
        long DispatchMessage(cpointer unfoundType_MSGlpMsglpMsg_unnamed_0);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        long DispatchMessageW(cpointer unfoundType_MSGlpMsglpMsg_unnamed_0);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetMessageQueue(int cMessagesMax);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int PeekMessageA(cpointer unfoundType_LPMSG_lpMsg, cpointer hWnd, uint wMsgFilterMin, uint wMsgFilterMax, uint wRemoveMsg);
    [DllImport("user32", EntryPoint="PeekMessageW", SetLastError=true, ExactSpelling=true)] public static extern
        int PeekMessage(cpointer unfoundType_LPMSG_lpMsg, cpointer hWnd, uint wMsgFilterMin, uint wMsgFilterMax, uint wRemoveMsg);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int PeekMessageW(cpointer unfoundType_LPMSG_lpMsg, cpointer hWnd, uint wMsgFilterMin, uint wMsgFilterMax, uint wRemoveMsg);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int RegisterHotKey(cpointer hWnd, int id, uint fsModifiers, uint vk);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int UnregisterHotKey(cpointer hWnd, int id);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ExitWindowsEx(uint uFlags, int dwReason);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SwapMouseButton(int fSwap);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetMessagePos();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetMessageTime();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        long GetMessageExtraInfo();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetUnpredictedMessagePos();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsWow64Message();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        long SetMessageExtraInfo(long lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        long SendMessageA(cpointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport("user32", EntryPoint="SendMessageW", SetLastError=true, ExactSpelling=true)] public static extern
        long SendMessage(cpointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        long SendMessageW(cpointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        long SendMessageTimeoutA(cpointer hWnd, uint Msg, ulong wParam, long lParam, uint fuFlags, uint uTimeout, cpointer unfoundType_PDWORD_PTR_lpdwResult);
    [DllImport("user32", EntryPoint="SendMessageTimeoutW", SetLastError=true, ExactSpelling=true)] public static extern
        long SendMessageTimeout(cpointer hWnd, uint Msg, ulong wParam, long lParam, uint fuFlags, uint uTimeout, cpointer unfoundType_PDWORD_PTR_lpdwResult);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        long SendMessageTimeoutW(cpointer hWnd, uint Msg, ulong wParam, long lParam, uint fuFlags, uint uTimeout, cpointer unfoundType_PDWORD_PTR_lpdwResult);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SendNotifyMessageA(cpointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport("user32", EntryPoint="SendNotifyMessageW", SetLastError=true, ExactSpelling=true)] public static extern
        int SendNotifyMessage(cpointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SendNotifyMessageW(cpointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SendMessageCallbackA(cpointer hWnd, uint Msg, ulong wParam, long lParam, cpointer unfoundType_SENDASYNCPROC_lpResultCallBack, cpointer unfoundType_ULONG_PTR_dwData);
    [DllImport("user32", EntryPoint="SendMessageCallbackW", SetLastError=true, ExactSpelling=true)] public static extern
        int SendMessageCallback(cpointer hWnd, uint Msg, ulong wParam, long lParam, cpointer unfoundType_SENDASYNCPROC_lpResultCallBack, cpointer unfoundType_ULONG_PTR_dwData);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SendMessageCallbackW(cpointer hWnd, uint Msg, ulong wParam, long lParam, cpointer unfoundType_SENDASYNCPROC_lpResultCallBack, cpointer unfoundType_ULONG_PTR_dwData);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int BroadcastSystemMessageExA(int flags, cpointer unfoundType_LPDWORD_lpInfo, uint Msg, ulong wParam, long lParam, cpointer unfoundType_PBSMINFO_pbsmInfo);
    [DllImport("user32", EntryPoint="BroadcastSystemMessageExW", SetLastError=true, ExactSpelling=true)] public static extern
        int BroadcastSystemMessageEx(int flags, cpointer unfoundType_LPDWORD_lpInfo, uint Msg, ulong wParam, long lParam, cpointer unfoundType_PBSMINFO_pbsmInfo);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int BroadcastSystemMessageExW(int flags, cpointer unfoundType_LPDWORD_lpInfo, uint Msg, ulong wParam, long lParam, cpointer unfoundType_PBSMINFO_pbsmInfo);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int BroadcastSystemMessageA(int flags, cpointer unfoundType_LPDWORD_lpInfo, uint Msg, ulong wParam, long lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int BroadcastSystemMessageW(int flags, cpointer unfoundType_LPDWORD_lpInfo, uint Msg, ulong wParam, long lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int BroadcastSystemMessage(int flags, cpointer unfoundType_LPDWORD_lpInfo, uint Msg, ulong wParam, long lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegisterDeviceNotificationA(cpointer hRecipient, cpointer NotificationFilter, int Flags);
    [DllImport("user32", EntryPoint="RegisterDeviceNotificationW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegisterDeviceNotification(cpointer hRecipient, cpointer NotificationFilter, int Flags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegisterDeviceNotificationW(cpointer hRecipient, cpointer NotificationFilter, int Flags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int UnregisterDeviceNotification(cpointer unfoundType_HDEVNOTIFY_Handle);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegisterPowerSettingNotification(cpointer hRecipient, cpointer unfoundType_LPCGUID_PowerSettingGuid, int Flags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int UnregisterPowerSettingNotification(cpointer unfoundType_HPOWERNOTIFY_Handle);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RegisterSuspendResumeNotification(cpointer hRecipient, int Flags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int UnregisterSuspendResumeNotification(cpointer unfoundType_HPOWERNOTIFY_Handle);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int PostMessageA(cpointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport("user32", EntryPoint="PostMessageW", SetLastError=true, ExactSpelling=true)] public static extern
        int PostMessage(cpointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int PostMessageW(cpointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int PostThreadMessageA(int idThread, uint Msg, ulong wParam, long lParam);
    [DllImport("user32", EntryPoint="PostThreadMessageW", SetLastError=true, ExactSpelling=true)] public static extern
        int PostThreadMessage(int idThread, uint Msg, ulong wParam, long lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int PostThreadMessageW(int idThread, uint Msg, ulong wParam, long lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int AttachThreadInput(int idAttach, int idAttachTo, int fAttach);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ReplyMessage(long lResult);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int WaitMessage();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int WaitForInputIdle(cpointer hProcess, int dwMilliseconds);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer DefWindowProcA(cpointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport("user32", EntryPoint="DefWindowProcW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer DefWindowProc(cpointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer DefWindowProcW(cpointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        void PostQuitMessage(int nExitCode);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        long CallWindowProcA(cpointer unfoundType_WNDPROC_lpPrevWndFunc, cpointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport("user32", EntryPoint="CallWindowProcW", SetLastError=true, ExactSpelling=true)] public static extern
        long CallWindowProc(cpointer unfoundType_WNDPROC_lpPrevWndFunc, cpointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        long CallWindowProcW(cpointer unfoundType_WNDPROC_lpPrevWndFunc, cpointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int InSendMessage();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int InSendMessageEx(cpointer lpReserved);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetDoubleClickTime();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetDoubleClickTime(uint unnamed_0);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        short RegisterClassA(cpointer unfoundType_WNDCLASSAlpWndClasslpWndClass_unnamed_0);
    [DllImport("user32", EntryPoint="RegisterClassW", SetLastError=true, ExactSpelling=true)] public static extern
        short RegisterClass(cpointer unfoundType_WNDCLASSWlpWndClasslpWndClass_unnamed_0);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        short RegisterClassW(cpointer unfoundType_WNDCLASSWlpWndClasslpWndClass_unnamed_0);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int UnregisterClassA(cpointer unfoundType_LPCSTR_lpClassName, cpointer unfoundType_HINSTANCE_hInstance);
    [DllImport("user32", EntryPoint="UnregisterClassW", SetLastError=true, ExactSpelling=true)] public static extern
        int UnregisterClass([MarshalAs(UnmanagedType.LPWStr)] string lpClassName, cpointer unfoundType_HINSTANCE_hInstance);
    [DllImport("user32", EntryPoint="UnregisterClassW", SetLastError=true, ExactSpelling=true)] public static extern
        int UnregisterClass(char* lpClassName, cpointer unfoundType_HINSTANCE_hInstance);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int UnregisterClassW([MarshalAs(UnmanagedType.LPWStr)] string lpClassName, cpointer unfoundType_HINSTANCE_hInstance);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int UnregisterClassW(char* lpClassName, cpointer unfoundType_HINSTANCE_hInstance);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetClassInfoA(cpointer unfoundType_HINSTANCE_hInstance, cpointer unfoundType_LPCSTR_lpClassName, cpointer unfoundType_LPWNDCLASSA_lpWndClass);
    [DllImport("user32", EntryPoint="GetClassInfoW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetClassInfo(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpClassName, cpointer unfoundType_LPWNDCLASSW_lpWndClass);
    [DllImport("user32", EntryPoint="GetClassInfoW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetClassInfo(cpointer unfoundType_HINSTANCE_hInstance, char* lpClassName, cpointer unfoundType_LPWNDCLASSW_lpWndClass);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetClassInfoW(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpClassName, cpointer unfoundType_LPWNDCLASSW_lpWndClass);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetClassInfoW(cpointer unfoundType_HINSTANCE_hInstance, char* lpClassName, cpointer unfoundType_LPWNDCLASSW_lpWndClass);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        short RegisterClassExA(cpointer unfoundType_WNDCLASSEXA_unnamed_0);
    [DllImport("user32", EntryPoint="RegisterClassExW", SetLastError=true, ExactSpelling=true)] public static extern
        short RegisterClassEx(cpointer unfoundType_WNDCLASSEXW_unnamed_0);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        short RegisterClassExW(cpointer unfoundType_WNDCLASSEXW_unnamed_0);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetClassInfoExA(cpointer unfoundType_HINSTANCE_hInstance, cpointer unfoundType_LPCSTR_lpszClass, cpointer unfoundType_LPWNDCLASSEXA_lpwcx);
    [DllImport("user32", EntryPoint="GetClassInfoExW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetClassInfoEx(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpszClass, cpointer unfoundType_LPWNDCLASSEXW_lpwcx);
    [DllImport("user32", EntryPoint="GetClassInfoExW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetClassInfoEx(cpointer unfoundType_HINSTANCE_hInstance, char* lpszClass, cpointer unfoundType_LPWNDCLASSEXW_lpwcx);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetClassInfoExW(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpszClass, cpointer unfoundType_LPWNDCLASSEXW_lpwcx);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetClassInfoExW(cpointer unfoundType_HINSTANCE_hInstance, char* lpszClass, cpointer unfoundType_LPWNDCLASSEXW_lpwcx);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateWindowExA(int dwExStyle, cpointer unfoundType_LPCSTR_lpClassName, cpointer unfoundType_LPCSTR_lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, cpointer hWndParent, cpointer hMenu, cpointer unfoundType_HINSTANCE_hInstance, cpointer lpParam);
    [DllImport("user32", EntryPoint="CreateWindowExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateWindowEx(int dwExStyle, [MarshalAs(UnmanagedType.LPWStr)] string lpClassName, [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, cpointer hWndParent, cpointer hMenu, cpointer unfoundType_HINSTANCE_hInstance, cpointer lpParam);
    [DllImport("user32", EntryPoint="CreateWindowExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateWindowEx(int dwExStyle, [MarshalAs(UnmanagedType.LPWStr)] string lpClassName, char* lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, cpointer hWndParent, cpointer hMenu, cpointer unfoundType_HINSTANCE_hInstance, cpointer lpParam);
    [DllImport("user32", EntryPoint="CreateWindowExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateWindowEx(int dwExStyle, char* lpClassName, [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, cpointer hWndParent, cpointer hMenu, cpointer unfoundType_HINSTANCE_hInstance, cpointer lpParam);
    [DllImport("user32", EntryPoint="CreateWindowExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateWindowEx(int dwExStyle, char* lpClassName, char* lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, cpointer hWndParent, cpointer hMenu, cpointer unfoundType_HINSTANCE_hInstance, cpointer lpParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateWindowExW(int dwExStyle, [MarshalAs(UnmanagedType.LPWStr)] string lpClassName, [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, cpointer hWndParent, cpointer hMenu, cpointer unfoundType_HINSTANCE_hInstance, cpointer lpParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateWindowExW(int dwExStyle, [MarshalAs(UnmanagedType.LPWStr)] string lpClassName, char* lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, cpointer hWndParent, cpointer hMenu, cpointer unfoundType_HINSTANCE_hInstance, cpointer lpParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateWindowExW(int dwExStyle, char* lpClassName, [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, cpointer hWndParent, cpointer hMenu, cpointer unfoundType_HINSTANCE_hInstance, cpointer lpParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateWindowExW(int dwExStyle, char* lpClassName, char* lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, cpointer hWndParent, cpointer hMenu, cpointer unfoundType_HINSTANCE_hInstance, cpointer lpParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsWindow(cpointer hWnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsMenu(cpointer hMenu);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsChild(cpointer hWndParent, cpointer hWnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DestroyWindow(cpointer hWnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ShowWindow(cpointer hWnd, int nCmdShow);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int AnimateWindow(cpointer hWnd, int dwTime, int dwFlags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int UpdateLayeredWindow(cpointer hWnd, cpointer hdcDst, cpointer unfoundType_POINT_pptDst, cpointer unfoundType_SIZE_psize, cpointer hdcSrc, cpointer unfoundType_POINT_pptSrc, cpointer unfoundType_COLORREF_crKey, cpointer unfoundType_BLENDFUNCTION_pblend, int dwFlags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int UpdateLayeredWindowIndirect(cpointer hWnd, cpointer unfoundType_UPDATELAYEREDWINDOWINFO_pULWInfo);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLayeredWindowAttributes(cpointer hwnd, cpointer unfoundType_COLORREF_pcrKey, cpointer pbAlpha, cpointer pdwFlags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int PrintWindow(cpointer hwnd, cpointer hdcBlt, uint nFlags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetLayeredWindowAttributes(cpointer hwnd, cpointer unfoundType_COLORREF_crKey, byte bAlpha, int dwFlags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ShowWindowAsync(cpointer hWnd, int nCmdShow);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int FlashWindow(cpointer hWnd, int bInvert);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int FlashWindowEx(cpointer unfoundType_PFLASHWINFO_pfwi);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ShowOwnedPopups(cpointer hWnd, int fShow);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int OpenIcon(cpointer hWnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CloseWindow(cpointer hWnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int MoveWindow(cpointer hWnd, int X, int Y, int nWidth, int nHeight, int bRepaint);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetWindowPos(cpointer hWnd, cpointer hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetWindowPlacement(cpointer hWnd, cpointer unfoundType_WINDOWPLACEMENTlpwndpllpwndpl_unnamed_1);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetWindowPlacement(cpointer hWnd, cpointer unfoundType_WINDOWPLACEMENTlpwndpllpwndpl_unnamed_1);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetWindowDisplayAffinity(cpointer hWnd, cpointer pdwAffinity);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetWindowDisplayAffinity(cpointer hWnd, int dwAffinity);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer BeginDeferWindowPos(int nNumWindows);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer DeferWindowPos(cpointer unfoundType_HDWP_hWinPosInfo, cpointer hWnd, cpointer hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int EndDeferWindowPos(cpointer unfoundType_HDWP_hWinPosInfo);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsWindowVisible(cpointer hWnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsIconic(cpointer hWnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int AnyPopup();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int BringWindowToTop(cpointer hWnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsZoomed(cpointer hWnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateDialogParamA(cpointer unfoundType_HINSTANCE_hInstance, cpointer unfoundType_LPCSTR_lpTemplateName, cpointer hWndParent, cpointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport("user32", EntryPoint="CreateDialogParamW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateDialogParam(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpTemplateName, cpointer hWndParent, cpointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport("user32", EntryPoint="CreateDialogParamW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateDialogParam(cpointer unfoundType_HINSTANCE_hInstance, char* lpTemplateName, cpointer hWndParent, cpointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateDialogParamW(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpTemplateName, cpointer hWndParent, cpointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateDialogParamW(cpointer unfoundType_HINSTANCE_hInstance, char* lpTemplateName, cpointer hWndParent, cpointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateDialogIndirectParamA(cpointer unfoundType_HINSTANCE_hInstance, cpointer unfoundType_LPCDLGTEMPLATEA_lpTemplate, cpointer hWndParent, cpointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport("user32", EntryPoint="CreateDialogIndirectParamW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateDialogIndirectParam(cpointer unfoundType_HINSTANCE_hInstance, cpointer unfoundType_LPCDLGTEMPLATEW_lpTemplate, cpointer hWndParent, cpointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateDialogIndirectParamW(cpointer unfoundType_HINSTANCE_hInstance, cpointer unfoundType_LPCDLGTEMPLATEW_lpTemplate, cpointer hWndParent, cpointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer DialogBoxParamA(cpointer unfoundType_HINSTANCE_hInstance, cpointer unfoundType_LPCSTR_lpTemplateName, cpointer hWndParent, cpointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport("user32", EntryPoint="DialogBoxParamW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer DialogBoxParam(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpTemplateName, cpointer hWndParent, cpointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport("user32", EntryPoint="DialogBoxParamW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer DialogBoxParam(cpointer unfoundType_HINSTANCE_hInstance, char* lpTemplateName, cpointer hWndParent, cpointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer DialogBoxParamW(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpTemplateName, cpointer hWndParent, cpointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer DialogBoxParamW(cpointer unfoundType_HINSTANCE_hInstance, char* lpTemplateName, cpointer hWndParent, cpointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer DialogBoxIndirectParamA(cpointer unfoundType_HINSTANCE_hInstance, cpointer unfoundType_LPCDLGTEMPLATEA_hDialogTemplate, cpointer hWndParent, cpointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport("user32", EntryPoint="DialogBoxIndirectParamW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer DialogBoxIndirectParam(cpointer unfoundType_HINSTANCE_hInstance, cpointer unfoundType_LPCDLGTEMPLATEW_hDialogTemplate, cpointer hWndParent, cpointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer DialogBoxIndirectParamW(cpointer unfoundType_HINSTANCE_hInstance, cpointer unfoundType_LPCDLGTEMPLATEW_hDialogTemplate, cpointer hWndParent, cpointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int EndDialog(cpointer hDlg, cpointer unfoundType_INT_PTR_nResult);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetDlgItem(cpointer hDlg, int nIDDlgItem);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetDlgItemInt(cpointer hDlg, int nIDDlgItem, uint uValue, int bSigned);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetDlgItemInt(cpointer hDlg, int nIDDlgItem, cpointer unfoundType_BOOLlpTranslatedlpTranslated_unnamed_2, int bSigned);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetDlgItemTextA(cpointer hDlg, int nIDDlgItem, cpointer unfoundType_LPCSTR_lpString);
    [DllImport("user32", EntryPoint="SetDlgItemTextW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetDlgItemText(cpointer hDlg, int nIDDlgItem, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport("user32", EntryPoint="SetDlgItemTextW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetDlgItemText(cpointer hDlg, int nIDDlgItem, char* lpString);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetDlgItemTextW(cpointer hDlg, int nIDDlgItem, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetDlgItemTextW(cpointer hDlg, int nIDDlgItem, char* lpString);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetDlgItemTextA(cpointer hDlg, int nIDDlgItem, [MarshalAs(UnmanagedType.LPStr)] string lpString, int cchMax);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetDlgItemTextA(cpointer hDlg, int nIDDlgItem, ReadOnlySpan<byte> lpString, int cchMax);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetDlgItemTextA(cpointer hDlg, int nIDDlgItem, byte* lpString, int cchMax);
    [DllImport("user32", EntryPoint="GetDlgItemTextW", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetDlgItemText(cpointer hDlg, int nIDDlgItem, string lpString, int cchMax);
    [DllImport("user32", EntryPoint="GetDlgItemTextW", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetDlgItemText(cpointer hDlg, int nIDDlgItem, char* lpString, int cchMax);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetDlgItemTextW(cpointer hDlg, int nIDDlgItem, string lpString, int cchMax);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetDlgItemTextW(cpointer hDlg, int nIDDlgItem, char* lpString, int cchMax);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CheckDlgButton(cpointer hDlg, int nIDButton, uint uCheck);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CheckRadioButton(cpointer hDlg, int nIDFirstButton, int nIDLastButton, int nIDCheckButton);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint IsDlgButtonChecked(cpointer hDlg, int nIDButton);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        long SendDlgItemMessageA(cpointer hDlg, int nIDDlgItem, uint Msg, ulong wParam, long lParam);
    [DllImport("user32", EntryPoint="SendDlgItemMessageW", SetLastError=true, ExactSpelling=true)] public static extern
        long SendDlgItemMessage(cpointer hDlg, int nIDDlgItem, uint Msg, ulong wParam, long lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        long SendDlgItemMessageW(cpointer hDlg, int nIDDlgItem, uint Msg, ulong wParam, long lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetNextDlgGroupItem(cpointer hDlg, cpointer hCtl, int bPrevious);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetNextDlgTabItem(cpointer hDlg, cpointer hCtl, int bPrevious);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDlgCtrlID(cpointer hWnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDialogBaseUnits();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer DefDlgProcA(cpointer hDlg, uint Msg, ulong wParam, long lParam);
    [DllImport("user32", EntryPoint="DefDlgProcW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer DefDlgProc(cpointer hDlg, uint Msg, ulong wParam, long lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer DefDlgProcW(cpointer hDlg, uint Msg, ulong wParam, long lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetDialogControlDpiChangeBehavior(cpointer hWnd, cpointer unfoundType_DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS_mask, cpointer unfoundType_DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS_values);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetDialogControlDpiChangeBehavior(cpointer hWnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetDialogDpiChangeBehavior(cpointer hDlg, cpointer unfoundType_DIALOG_DPI_CHANGE_BEHAVIORS_mask, cpointer unfoundType_DIALOG_DPI_CHANGE_BEHAVIORS_values);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetDialogDpiChangeBehavior(cpointer hDlg);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CallMsgFilterA(cpointer unfoundType_LPMSG_lpMsg, int nCode);
    [DllImport("user32", EntryPoint="CallMsgFilterW", SetLastError=true, ExactSpelling=true)] public static extern
        int CallMsgFilter(cpointer unfoundType_LPMSG_lpMsg, int nCode);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CallMsgFilterW(cpointer unfoundType_LPMSG_lpMsg, int nCode);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int OpenClipboard(cpointer hWndNewOwner);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CloseClipboard();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetClipboardSequenceNumber();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetClipboardOwner();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer SetClipboardViewer(cpointer hWndNewViewer);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetClipboardViewer();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ChangeClipboardChain(cpointer hWndRemove, cpointer hWndNewNext);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer SetClipboardData(uint uFormat, cpointer hMem);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetClipboardData(uint uFormat);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetClipboardMetadata(uint format, cpointer unfoundType_PGETCLIPBMETADATA_metadata);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint RegisterClipboardFormatA(cpointer unfoundType_LPCSTR_lpszFormat);
    [DllImport("user32", EntryPoint="RegisterClipboardFormatW", SetLastError=true, ExactSpelling=true)] public static extern
        uint RegisterClipboardFormat([MarshalAs(UnmanagedType.LPWStr)] string lpszFormat);
    [DllImport("user32", EntryPoint="RegisterClipboardFormatW", SetLastError=true, ExactSpelling=true)] public static extern
        uint RegisterClipboardFormat(char* lpszFormat);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint RegisterClipboardFormatW([MarshalAs(UnmanagedType.LPWStr)] string lpszFormat);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint RegisterClipboardFormatW(char* lpszFormat);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CountClipboardFormats();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint EnumClipboardFormats(uint format);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetClipboardFormatNameA(uint format, [MarshalAs(UnmanagedType.LPStr)] string lpszFormatName, int cchMaxCount);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetClipboardFormatNameA(uint format, ReadOnlySpan<byte> lpszFormatName, int cchMaxCount);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetClipboardFormatNameA(uint format, byte* lpszFormatName, int cchMaxCount);
    [DllImport("user32", EntryPoint="GetClipboardFormatNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetClipboardFormatName(uint format, string lpszFormatName, int cchMaxCount);
    [DllImport("user32", EntryPoint="GetClipboardFormatNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetClipboardFormatName(uint format, char* lpszFormatName, int cchMaxCount);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetClipboardFormatNameW(uint format, string lpszFormatName, int cchMaxCount);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetClipboardFormatNameW(uint format, char* lpszFormatName, int cchMaxCount);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int EmptyClipboard();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsClipboardFormatAvailable(uint format);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPriorityClipboardFormat(cpointer unfoundType_UINTpaFormatPriorityListpaFormatPriorityList_unnamed_0, int cFormats);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetOpenClipboardWindow();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int AddClipboardFormatListener(cpointer hwnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int RemoveClipboardFormatListener(cpointer hwnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetUpdatedClipboardFormats(cpointer unfoundType_PUINT_lpuiFormats, uint cFormats, cpointer unfoundType_PUINT_pcFormatsOut);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CharToOemA(cpointer unfoundType_LPCSTR_pSrc, [MarshalAs(UnmanagedType.LPStr)] string pDst);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CharToOemA(cpointer unfoundType_LPCSTR_pSrc, ReadOnlySpan<byte> pDst);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CharToOemA(cpointer unfoundType_LPCSTR_pSrc, byte* pDst);
    [DllImport("user32", EntryPoint="CharToOemW", SetLastError=true, ExactSpelling=true)] public static extern
        int CharToOem([MarshalAs(UnmanagedType.LPWStr)] string pSrc, [MarshalAs(UnmanagedType.LPStr)] string pDst);
    [DllImport("user32", EntryPoint="CharToOemW", SetLastError=true, ExactSpelling=true)] public static extern
        int CharToOem([MarshalAs(UnmanagedType.LPWStr)] string pSrc, ReadOnlySpan<byte> pDst);
    [DllImport("user32", EntryPoint="CharToOemW", SetLastError=true, ExactSpelling=true)] public static extern
        int CharToOem([MarshalAs(UnmanagedType.LPWStr)] string pSrc, byte* pDst);
    [DllImport("user32", EntryPoint="CharToOemW", SetLastError=true, ExactSpelling=true)] public static extern
        int CharToOem(char* pSrc, [MarshalAs(UnmanagedType.LPStr)] string pDst);
    [DllImport("user32", EntryPoint="CharToOemW", SetLastError=true, ExactSpelling=true)] public static extern
        int CharToOem(char* pSrc, ReadOnlySpan<byte> pDst);
    [DllImport("user32", EntryPoint="CharToOemW", SetLastError=true, ExactSpelling=true)] public static extern
        int CharToOem(char* pSrc, byte* pDst);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CharToOemW([MarshalAs(UnmanagedType.LPWStr)] string pSrc, [MarshalAs(UnmanagedType.LPStr)] string pDst);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CharToOemW([MarshalAs(UnmanagedType.LPWStr)] string pSrc, ReadOnlySpan<byte> pDst);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CharToOemW([MarshalAs(UnmanagedType.LPWStr)] string pSrc, byte* pDst);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CharToOemW(char* pSrc, [MarshalAs(UnmanagedType.LPStr)] string pDst);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CharToOemW(char* pSrc, ReadOnlySpan<byte> pDst);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CharToOemW(char* pSrc, byte* pDst);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int OemToCharA(cpointer unfoundType_LPCSTR_pSrc, [MarshalAs(UnmanagedType.LPStr)] string pDst);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int OemToCharA(cpointer unfoundType_LPCSTR_pSrc, ReadOnlySpan<byte> pDst);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int OemToCharA(cpointer unfoundType_LPCSTR_pSrc, byte* pDst);
    [DllImport("user32", EntryPoint="OemToCharW", SetLastError=true, ExactSpelling=true)] public static extern
        int OemToChar(cpointer unfoundType_LPCSTR_pSrc, string pDst);
    [DllImport("user32", EntryPoint="OemToCharW", SetLastError=true, ExactSpelling=true)] public static extern
        int OemToChar(cpointer unfoundType_LPCSTR_pSrc, char* pDst);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int OemToCharW(cpointer unfoundType_LPCSTR_pSrc, string pDst);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int OemToCharW(cpointer unfoundType_LPCSTR_pSrc, char* pDst);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CharToOemBuffA(cpointer unfoundType_LPCSTR_lpszSrc, [MarshalAs(UnmanagedType.LPStr)] string lpszDst, int cchDstLength);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CharToOemBuffA(cpointer unfoundType_LPCSTR_lpszSrc, ReadOnlySpan<byte> lpszDst, int cchDstLength);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CharToOemBuffA(cpointer unfoundType_LPCSTR_lpszSrc, byte* lpszDst, int cchDstLength);
    [DllImport("user32", EntryPoint="CharToOemBuffW", SetLastError=true, ExactSpelling=true)] public static extern
        int CharToOemBuff([MarshalAs(UnmanagedType.LPWStr)] string lpszSrc, [MarshalAs(UnmanagedType.LPStr)] string lpszDst, int cchDstLength);
    [DllImport("user32", EntryPoint="CharToOemBuffW", SetLastError=true, ExactSpelling=true)] public static extern
        int CharToOemBuff([MarshalAs(UnmanagedType.LPWStr)] string lpszSrc, ReadOnlySpan<byte> lpszDst, int cchDstLength);
    [DllImport("user32", EntryPoint="CharToOemBuffW", SetLastError=true, ExactSpelling=true)] public static extern
        int CharToOemBuff([MarshalAs(UnmanagedType.LPWStr)] string lpszSrc, byte* lpszDst, int cchDstLength);
    [DllImport("user32", EntryPoint="CharToOemBuffW", SetLastError=true, ExactSpelling=true)] public static extern
        int CharToOemBuff(char* lpszSrc, [MarshalAs(UnmanagedType.LPStr)] string lpszDst, int cchDstLength);
    [DllImport("user32", EntryPoint="CharToOemBuffW", SetLastError=true, ExactSpelling=true)] public static extern
        int CharToOemBuff(char* lpszSrc, ReadOnlySpan<byte> lpszDst, int cchDstLength);
    [DllImport("user32", EntryPoint="CharToOemBuffW", SetLastError=true, ExactSpelling=true)] public static extern
        int CharToOemBuff(char* lpszSrc, byte* lpszDst, int cchDstLength);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CharToOemBuffW([MarshalAs(UnmanagedType.LPWStr)] string lpszSrc, [MarshalAs(UnmanagedType.LPStr)] string lpszDst, int cchDstLength);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CharToOemBuffW([MarshalAs(UnmanagedType.LPWStr)] string lpszSrc, ReadOnlySpan<byte> lpszDst, int cchDstLength);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CharToOemBuffW([MarshalAs(UnmanagedType.LPWStr)] string lpszSrc, byte* lpszDst, int cchDstLength);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CharToOemBuffW(char* lpszSrc, [MarshalAs(UnmanagedType.LPStr)] string lpszDst, int cchDstLength);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CharToOemBuffW(char* lpszSrc, ReadOnlySpan<byte> lpszDst, int cchDstLength);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CharToOemBuffW(char* lpszSrc, byte* lpszDst, int cchDstLength);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int OemToCharBuffA(cpointer unfoundType_LPCSTR_lpszSrc, [MarshalAs(UnmanagedType.LPStr)] string lpszDst, int cchDstLength);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int OemToCharBuffA(cpointer unfoundType_LPCSTR_lpszSrc, ReadOnlySpan<byte> lpszDst, int cchDstLength);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int OemToCharBuffA(cpointer unfoundType_LPCSTR_lpszSrc, byte* lpszDst, int cchDstLength);
    [DllImport("user32", EntryPoint="OemToCharBuffW", SetLastError=true, ExactSpelling=true)] public static extern
        int OemToCharBuff(cpointer unfoundType_LPCSTR_lpszSrc, string lpszDst, int cchDstLength);
    [DllImport("user32", EntryPoint="OemToCharBuffW", SetLastError=true, ExactSpelling=true)] public static extern
        int OemToCharBuff(cpointer unfoundType_LPCSTR_lpszSrc, char* lpszDst, int cchDstLength);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int OemToCharBuffW(cpointer unfoundType_LPCSTR_lpszSrc, string lpszDst, int cchDstLength);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int OemToCharBuffW(cpointer unfoundType_LPCSTR_lpszSrc, char* lpszDst, int cchDstLength);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        byte* CharUpperA_([MarshalAs(UnmanagedType.LPStr)] string lpsz);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        byte* CharUpperA_(ReadOnlySpan<byte> lpsz);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        byte* CharUpperA_(byte* lpsz);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        ReadOnlySpan<byte> CharUpperA([MarshalAs(UnmanagedType.LPStr)] string lpsz);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        ReadOnlySpan<byte> CharUpperA(ReadOnlySpan<byte> lpsz);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        ReadOnlySpan<byte> CharUpperA(byte* lpsz);
    [DllImport("user32", EntryPoint="CharUpperW", SetLastError=true, ExactSpelling=true)] public static extern
        char* CharUpper_(string lpsz);
    [DllImport("user32", EntryPoint="CharUpperW", SetLastError=true, ExactSpelling=true)] public static extern
        char* CharUpper_(char* lpsz);
    [DllImport("user32", EntryPoint="CharUpperW", SetLastError=true, ExactSpelling=true)] public static extern
        string CharUpper(string lpsz);
    [DllImport("user32", EntryPoint="CharUpperW", SetLastError=true, ExactSpelling=true)] public static extern
        string CharUpper(char* lpsz);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        char* CharUpperW_(string lpsz);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        char* CharUpperW_(char* lpsz);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        string CharUpperW(string lpsz);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        string CharUpperW(char* lpsz);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CharUpperBuffA([MarshalAs(UnmanagedType.LPStr)] string lpsz, int cchLength);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CharUpperBuffA(ReadOnlySpan<byte> lpsz, int cchLength);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CharUpperBuffA(byte* lpsz, int cchLength);
    [DllImport("user32", EntryPoint="CharUpperBuffW", SetLastError=true, ExactSpelling=true)] public static extern
        int CharUpperBuff(string lpsz, int cchLength);
    [DllImport("user32", EntryPoint="CharUpperBuffW", SetLastError=true, ExactSpelling=true)] public static extern
        int CharUpperBuff(char* lpsz, int cchLength);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CharUpperBuffW(string lpsz, int cchLength);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CharUpperBuffW(char* lpsz, int cchLength);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        byte* CharLowerA_([MarshalAs(UnmanagedType.LPStr)] string lpsz);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        byte* CharLowerA_(ReadOnlySpan<byte> lpsz);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        byte* CharLowerA_(byte* lpsz);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        ReadOnlySpan<byte> CharLowerA([MarshalAs(UnmanagedType.LPStr)] string lpsz);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        ReadOnlySpan<byte> CharLowerA(ReadOnlySpan<byte> lpsz);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        ReadOnlySpan<byte> CharLowerA(byte* lpsz);
    [DllImport("user32", EntryPoint="CharLowerW", SetLastError=true, ExactSpelling=true)] public static extern
        char* CharLower_(string lpsz);
    [DllImport("user32", EntryPoint="CharLowerW", SetLastError=true, ExactSpelling=true)] public static extern
        char* CharLower_(char* lpsz);
    [DllImport("user32", EntryPoint="CharLowerW", SetLastError=true, ExactSpelling=true)] public static extern
        string CharLower(string lpsz);
    [DllImport("user32", EntryPoint="CharLowerW", SetLastError=true, ExactSpelling=true)] public static extern
        string CharLower(char* lpsz);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        char* CharLowerW_(string lpsz);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        char* CharLowerW_(char* lpsz);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        string CharLowerW(string lpsz);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        string CharLowerW(char* lpsz);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CharLowerBuffA([MarshalAs(UnmanagedType.LPStr)] string lpsz, int cchLength);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CharLowerBuffA(ReadOnlySpan<byte> lpsz, int cchLength);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CharLowerBuffA(byte* lpsz, int cchLength);
    [DllImport("user32", EntryPoint="CharLowerBuffW", SetLastError=true, ExactSpelling=true)] public static extern
        int CharLowerBuff(string lpsz, int cchLength);
    [DllImport("user32", EntryPoint="CharLowerBuffW", SetLastError=true, ExactSpelling=true)] public static extern
        int CharLowerBuff(char* lpsz, int cchLength);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CharLowerBuffW(string lpsz, int cchLength);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CharLowerBuffW(char* lpsz, int cchLength);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        byte* CharNextA_(cpointer unfoundType_LPCSTR_lpsz);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        ReadOnlySpan<byte> CharNextA(cpointer unfoundType_LPCSTR_lpsz);
    [DllImport("user32", EntryPoint="CharNextW", SetLastError=true, ExactSpelling=true)] public static extern
        char* CharNext_([MarshalAs(UnmanagedType.LPWStr)] string lpsz);
    [DllImport("user32", EntryPoint="CharNextW", SetLastError=true, ExactSpelling=true)] public static extern
        char* CharNext_(char* lpsz);
    [DllImport("user32", EntryPoint="CharNextW", SetLastError=true, ExactSpelling=true)] public static extern
        string CharNext([MarshalAs(UnmanagedType.LPWStr)] string lpsz);
    [DllImport("user32", EntryPoint="CharNextW", SetLastError=true, ExactSpelling=true)] public static extern
        string CharNext(char* lpsz);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        char* CharNextW_([MarshalAs(UnmanagedType.LPWStr)] string lpsz);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        char* CharNextW_(char* lpsz);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        string CharNextW([MarshalAs(UnmanagedType.LPWStr)] string lpsz);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        string CharNextW(char* lpsz);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        byte* CharPrevA_(cpointer unfoundType_LPCSTR_lpszStart, cpointer unfoundType_LPCSTR_lpszCurrent);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        ReadOnlySpan<byte> CharPrevA(cpointer unfoundType_LPCSTR_lpszStart, cpointer unfoundType_LPCSTR_lpszCurrent);
    [DllImport("user32", EntryPoint="CharPrevW", SetLastError=true, ExactSpelling=true)] public static extern
        char* CharPrev_([MarshalAs(UnmanagedType.LPWStr)] string lpszStart, [MarshalAs(UnmanagedType.LPWStr)] string lpszCurrent);
    [DllImport("user32", EntryPoint="CharPrevW", SetLastError=true, ExactSpelling=true)] public static extern
        char* CharPrev_([MarshalAs(UnmanagedType.LPWStr)] string lpszStart, char* lpszCurrent);
    [DllImport("user32", EntryPoint="CharPrevW", SetLastError=true, ExactSpelling=true)] public static extern
        char* CharPrev_(char* lpszStart, [MarshalAs(UnmanagedType.LPWStr)] string lpszCurrent);
    [DllImport("user32", EntryPoint="CharPrevW", SetLastError=true, ExactSpelling=true)] public static extern
        char* CharPrev_(char* lpszStart, char* lpszCurrent);
    [DllImport("user32", EntryPoint="CharPrevW", SetLastError=true, ExactSpelling=true)] public static extern
        string CharPrev([MarshalAs(UnmanagedType.LPWStr)] string lpszStart, [MarshalAs(UnmanagedType.LPWStr)] string lpszCurrent);
    [DllImport("user32", EntryPoint="CharPrevW", SetLastError=true, ExactSpelling=true)] public static extern
        string CharPrev([MarshalAs(UnmanagedType.LPWStr)] string lpszStart, char* lpszCurrent);
    [DllImport("user32", EntryPoint="CharPrevW", SetLastError=true, ExactSpelling=true)] public static extern
        string CharPrev(char* lpszStart, [MarshalAs(UnmanagedType.LPWStr)] string lpszCurrent);
    [DllImport("user32", EntryPoint="CharPrevW", SetLastError=true, ExactSpelling=true)] public static extern
        string CharPrev(char* lpszStart, char* lpszCurrent);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        char* CharPrevW_([MarshalAs(UnmanagedType.LPWStr)] string lpszStart, [MarshalAs(UnmanagedType.LPWStr)] string lpszCurrent);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        char* CharPrevW_([MarshalAs(UnmanagedType.LPWStr)] string lpszStart, char* lpszCurrent);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        char* CharPrevW_(char* lpszStart, [MarshalAs(UnmanagedType.LPWStr)] string lpszCurrent);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        char* CharPrevW_(char* lpszStart, char* lpszCurrent);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        string CharPrevW([MarshalAs(UnmanagedType.LPWStr)] string lpszStart, [MarshalAs(UnmanagedType.LPWStr)] string lpszCurrent);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        string CharPrevW([MarshalAs(UnmanagedType.LPWStr)] string lpszStart, char* lpszCurrent);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        string CharPrevW(char* lpszStart, [MarshalAs(UnmanagedType.LPWStr)] string lpszCurrent);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        string CharPrevW(char* lpszStart, char* lpszCurrent);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        byte* CharNextExA_(short CodePage, cpointer unfoundType_LPCSTR_lpCurrentChar, int dwFlags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        ReadOnlySpan<byte> CharNextExA(short CodePage, cpointer unfoundType_LPCSTR_lpCurrentChar, int dwFlags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        byte* CharPrevExA_(short CodePage, cpointer unfoundType_LPCSTR_lpStart, cpointer unfoundType_LPCSTR_lpCurrentChar, int dwFlags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        ReadOnlySpan<byte> CharPrevExA(short CodePage, cpointer unfoundType_LPCSTR_lpStart, cpointer unfoundType_LPCSTR_lpCurrentChar, int dwFlags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsCharAlphaA(byte ch);
    [DllImport("user32", EntryPoint="IsCharAlphaW", SetLastError=true, ExactSpelling=true)] public static extern
        int IsCharAlpha(char ch);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsCharAlphaW(char ch);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsCharAlphaNumericA(byte ch);
    [DllImport("user32", EntryPoint="IsCharAlphaNumericW", SetLastError=true, ExactSpelling=true)] public static extern
        int IsCharAlphaNumeric(char ch);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsCharAlphaNumericW(char ch);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsCharUpperA(byte ch);
    [DllImport("user32", EntryPoint="IsCharUpperW", SetLastError=true, ExactSpelling=true)] public static extern
        int IsCharUpper(char ch);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsCharUpperW(char ch);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsCharLowerA(byte ch);
    [DllImport("user32", EntryPoint="IsCharLowerW", SetLastError=true, ExactSpelling=true)] public static extern
        int IsCharLower(char ch);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsCharLowerW(char ch);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer SetFocus(cpointer hWnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetActiveWindow();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetFocus();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetKBCodePage();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        short GetKeyState(int nVirtKey);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        short GetAsyncKeyState(int vKey);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetKeyboardState(cpointer unfoundType_PBYTE_lpKeyState);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetKeyboardState(cpointer unfoundType_LPBYTE_lpKeyState);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetKeyNameTextA(int lParam, [MarshalAs(UnmanagedType.LPStr)] string lpString, int cchSize);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetKeyNameTextA(int lParam, ReadOnlySpan<byte> lpString, int cchSize);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetKeyNameTextA(int lParam, byte* lpString, int cchSize);
    [DllImport("user32", EntryPoint="GetKeyNameTextW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetKeyNameText(int lParam, string lpString, int cchSize);
    [DllImport("user32", EntryPoint="GetKeyNameTextW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetKeyNameText(int lParam, char* lpString, int cchSize);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetKeyNameTextW(int lParam, string lpString, int cchSize);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetKeyNameTextW(int lParam, char* lpString, int cchSize);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetKeyboardType(int nTypeFlag);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ToAscii(uint uVirtKey, uint uScanCode, cpointer unfoundType_BYTElpKeyStatelpKeyState_unnamed_2, cpointer unfoundType_LPWORD_lpChar, uint uFlags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ToAsciiEx(uint uVirtKey, uint uScanCode, cpointer unfoundType_BYTElpKeyStatelpKeyState_unnamed_2, cpointer unfoundType_LPWORD_lpChar, uint uFlags, cpointer unfoundType_HKL_dwhkl);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ToUnicode(uint wVirtKey, uint wScanCode, cpointer unfoundType_BYTElpKeyStatelpKeyState_unnamed_2, string pwszBuff, int cchBuff, uint wFlags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ToUnicode(uint wVirtKey, uint wScanCode, cpointer unfoundType_BYTElpKeyStatelpKeyState_unnamed_2, char* pwszBuff, int cchBuff, uint wFlags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int OemKeyScan(short wOemChar);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        short VkKeyScanA(byte ch);
    [DllImport("user32", EntryPoint="VkKeyScanW", SetLastError=true, ExactSpelling=true)] public static extern
        short VkKeyScan(char ch);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        short VkKeyScanW(char ch);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        short VkKeyScanExA(byte ch, cpointer unfoundType_HKL_dwhkl);
    [DllImport("user32", EntryPoint="VkKeyScanExW", SetLastError=true, ExactSpelling=true)] public static extern
        short VkKeyScanEx(char ch, cpointer unfoundType_HKL_dwhkl);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        short VkKeyScanExW(char ch, cpointer unfoundType_HKL_dwhkl);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        void keybd_event(byte bVk, byte bScan, int dwFlags, cpointer unfoundType_ULONG_PTR_dwExtraInfo);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        void mouse_event(int dwFlags, int dx, int dy, int dwData, cpointer unfoundType_ULONG_PTR_dwExtraInfo);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint SendInput(uint cInputs, cpointer unfoundType_LPINPUT_pInputs, int cbSize);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTouchInputInfo(cpointer unfoundType_HTOUCHINPUT_hTouchInput);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CloseTouchInputHandle(cpointer unfoundType_HTOUCHINPUT_hTouchInput);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int RegisterTouchWindow(cpointer hwnd, uint ulFlags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int UnregisterTouchWindow(cpointer hwnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsTouchWindow(cpointer hwnd, cpointer unfoundType_PULONG_pulFlags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int InitializeTouchInjection(uint maxCount, int dwMode);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int InjectTouchInput(uint count, cpointer unfoundType_POINTER_TOUCH_INFOcontactscontacts_unnamed_1);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPointerType(uint pointerId, cpointer unfoundType_POINTER_INPUT_TYPEpointerTypepointerType_unnamed_1);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPointerCursorId(uint pointerId, cpointer unfoundType_UINT32cursorIdcursorId_unnamed_1);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPointerInfo(uint pointerId, cpointer unfoundType_POINTER_INFOpointerInfopointerInfo_unnamed_1);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPointerInfoHistory(uint pointerId, cpointer unfoundType_UINT32entriesCountentriesCount_unnamed_1, cpointer unfoundType_POINTER_INFOpointerInfopointerInfo_unnamed_2);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPointerFrameInfo(uint pointerId, cpointer unfoundType_UINT32pointerCountpointerCount_unnamed_1, cpointer unfoundType_POINTER_INFOpointerInfopointerInfo_unnamed_2);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPointerFrameInfoHistory(uint pointerId, cpointer unfoundType_UINT32entriesCountentriesCount_unnamed_1, cpointer unfoundType_UINT32pointerCountpointerCount_unnamed_2, cpointer unfoundType_POINTER_INFOpointerInfopointerInfo_unnamed_3);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPointerTouchInfo(uint pointerId, cpointer unfoundType_POINTER_TOUCH_INFOtouchInfotouchInfo_unnamed_1);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPointerTouchInfoHistory(uint pointerId, cpointer unfoundType_UINT32entriesCountentriesCount_unnamed_1, cpointer unfoundType_POINTER_TOUCH_INFOtouchInfotouchInfo_unnamed_2);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPointerFrameTouchInfo(uint pointerId, cpointer unfoundType_UINT32pointerCountpointerCount_unnamed_1, cpointer unfoundType_POINTER_TOUCH_INFOtouchInfotouchInfo_unnamed_2);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPointerFrameTouchInfoHistory(uint pointerId, cpointer unfoundType_UINT32entriesCountentriesCount_unnamed_1, cpointer unfoundType_UINT32pointerCountpointerCount_unnamed_2, cpointer unfoundType_POINTER_TOUCH_INFOtouchInfotouchInfo_unnamed_3);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPointerPenInfo(uint pointerId, cpointer unfoundType_POINTER_PEN_INFOpenInfopenInfo_unnamed_1);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPointerPenInfoHistory(uint pointerId, cpointer unfoundType_UINT32entriesCountentriesCount_unnamed_1, cpointer unfoundType_POINTER_PEN_INFOpenInfopenInfo_unnamed_2);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPointerFramePenInfo(uint pointerId, cpointer unfoundType_UINT32pointerCountpointerCount_unnamed_1, cpointer unfoundType_POINTER_PEN_INFOpenInfopenInfo_unnamed_2);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPointerFramePenInfoHistory(uint pointerId, cpointer unfoundType_UINT32entriesCountentriesCount_unnamed_1, cpointer unfoundType_UINT32pointerCountpointerCount_unnamed_2, cpointer unfoundType_POINTER_PEN_INFOpenInfopenInfo_unnamed_3);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SkipPointerFrameMessages(uint pointerId);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int RegisterPointerInputTarget(cpointer hwnd, cpointer unfoundType_POINTER_INPUT_TYPE_pointerType);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int UnregisterPointerInputTarget(cpointer hwnd, cpointer unfoundType_POINTER_INPUT_TYPE_pointerType);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int RegisterPointerInputTargetEx(cpointer hwnd, cpointer unfoundType_POINTER_INPUT_TYPE_pointerType, int fObserve);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int UnregisterPointerInputTargetEx(cpointer hwnd, cpointer unfoundType_POINTER_INPUT_TYPE_pointerType);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateSyntheticPointerDevice(cpointer unfoundType_POINTER_INPUT_TYPE_pointerType, uint maxCount, cpointer unfoundType_POINTER_FEEDBACK_MODE_mode);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int InjectSyntheticPointerInput(cpointer unfoundType_HSYNTHETICPOINTERDEVICE_device, cpointer unfoundType_POINTER_TYPE_INFO_pointerInfo, uint count);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        void DestroySyntheticPointerDevice(cpointer unfoundType_HSYNTHETICPOINTERDEVICE_device);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnableMouseInPointer(int fEnable);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsMouseInPointerEnabled();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int RegisterTouchHitTestingWindow(cpointer hwnd, uint value);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int EvaluateProximityToRect(cpointer unfoundType_RECTcontrolBoundingBoxcontrolBoundingBox_unnamed_0, cpointer unfoundType_TOUCH_HIT_TESTING_INPUTpHitTestingInputpHitTestingInput_unnamed_1, cpointer unfoundType_TOUCH_HIT_TESTING_PROXIMITY_EVALUATIONpProximityEvalpProximityEval_unnamed_2);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int EvaluateProximityToPolygon(uint numVertices, cpointer unfoundType_POINTcontrolPolygoncontrolPolygon_unnamed_1, cpointer unfoundType_TOUCH_HIT_TESTING_INPUTpHitTestingInputpHitTestingInput_unnamed_2, cpointer unfoundType_TOUCH_HIT_TESTING_PROXIMITY_EVALUATIONpProximityEvalpProximityEval_unnamed_3);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        long PackTouchHitTestingProximityEvaluation(cpointer unfoundType_TOUCH_HIT_TESTING_INPUTpHitTestingInputpHitTestingInput_unnamed_0, cpointer unfoundType_TOUCH_HIT_TESTING_PROXIMITY_EVALUATIONpProximityEvalpProximityEval_unnamed_1);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetWindowFeedbackSetting(cpointer hwnd, cpointer unfoundType_FEEDBACK_TYPE_feedback, int dwFlags, cpointer pSize, cpointer config);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetWindowFeedbackSetting(cpointer hwnd, cpointer unfoundType_FEEDBACK_TYPE_feedback, int dwFlags, uint size, cpointer configuration);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPointerInputTransform(uint pointerId, uint historyCount, cpointer unfoundType_INPUT_TRANSFORMinputTransforminputTransform_unnamed_2);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetLastInputInfo(cpointer unfoundType_PLASTINPUTINFO_plii);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint MapVirtualKeyA(uint uCode, uint uMapType);
    [DllImport("user32", EntryPoint="MapVirtualKeyW", SetLastError=true, ExactSpelling=true)] public static extern
        uint MapVirtualKey(uint uCode, uint uMapType);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint MapVirtualKeyW(uint uCode, uint uMapType);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint MapVirtualKeyExA(uint uCode, uint uMapType, cpointer unfoundType_HKL_dwhkl);
    [DllImport("user32", EntryPoint="MapVirtualKeyExW", SetLastError=true, ExactSpelling=true)] public static extern
        uint MapVirtualKeyEx(uint uCode, uint uMapType, cpointer unfoundType_HKL_dwhkl);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint MapVirtualKeyExW(uint uCode, uint uMapType, cpointer unfoundType_HKL_dwhkl);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetInputState();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetQueueStatus(uint flags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetCapture();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer SetCapture(cpointer hWnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ReleaseCapture();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int MsgWaitForMultipleObjects(int nCount, cpointer unfoundType_HANDLEpHandlespHandles_unnamed_1, int fWaitAll, int dwMilliseconds, int dwWakeMask);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int MsgWaitForMultipleObjectsEx(int nCount, cpointer unfoundType_HANDLEpHandlespHandles_unnamed_1, int dwMilliseconds, int dwWakeMask, int dwFlags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        ulong SetTimer(cpointer hWnd, ulong nIDEvent, uint uElapse, cpointer unfoundType_TIMERPROC_lpTimerFunc);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        ulong SetCoalescableTimer(cpointer hWnd, ulong nIDEvent, uint uElapse, cpointer unfoundType_TIMERPROC_lpTimerFunc, uint uToleranceDelay);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int KillTimer(cpointer hWnd, ulong uIDEvent);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsWindowUnicode(cpointer hWnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnableWindow(cpointer hWnd, int bEnable);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsWindowEnabled(cpointer hWnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadAcceleratorsA(cpointer unfoundType_HINSTANCE_hInstance, cpointer unfoundType_LPCSTR_lpTableName);
    [DllImport("user32", EntryPoint="LoadAcceleratorsW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadAccelerators(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpTableName);
    [DllImport("user32", EntryPoint="LoadAcceleratorsW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadAccelerators(cpointer unfoundType_HINSTANCE_hInstance, char* lpTableName);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadAcceleratorsW(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpTableName);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadAcceleratorsW(cpointer unfoundType_HINSTANCE_hInstance, char* lpTableName);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateAcceleratorTableA(cpointer unfoundType_LPACCEL_paccel, int cAccel);
    [DllImport("user32", EntryPoint="CreateAcceleratorTableW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateAcceleratorTable(cpointer unfoundType_LPACCEL_paccel, int cAccel);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateAcceleratorTableW(cpointer unfoundType_LPACCEL_paccel, int cAccel);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DestroyAcceleratorTable(cpointer hAccel);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CopyAcceleratorTableA(cpointer hAccelSrc, cpointer unfoundType_LPACCEL_lpAccelDst, int cAccelEntries);
    [DllImport("user32", EntryPoint="CopyAcceleratorTableW", SetLastError=true, ExactSpelling=true)] public static extern
        int CopyAcceleratorTable(cpointer hAccelSrc, cpointer unfoundType_LPACCEL_lpAccelDst, int cAccelEntries);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CopyAcceleratorTableW(cpointer hAccelSrc, cpointer unfoundType_LPACCEL_lpAccelDst, int cAccelEntries);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int TranslateAcceleratorA(cpointer hWnd, cpointer hAccTable, cpointer unfoundType_LPMSG_lpMsg);
    [DllImport("user32", EntryPoint="TranslateAcceleratorW", SetLastError=true, ExactSpelling=true)] public static extern
        int TranslateAccelerator(cpointer hWnd, cpointer hAccTable, cpointer unfoundType_LPMSG_lpMsg);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int TranslateAcceleratorW(cpointer hWnd, cpointer hAccTable, cpointer unfoundType_LPMSG_lpMsg);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetSystemMetrics(int nIndex);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetSystemMetricsForDpi(int nIndex, uint dpi);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadMenuA(cpointer unfoundType_HINSTANCE_hInstance, cpointer unfoundType_LPCSTR_lpMenuName);
    [DllImport("user32", EntryPoint="LoadMenuW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadMenu(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpMenuName);
    [DllImport("user32", EntryPoint="LoadMenuW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadMenu(cpointer unfoundType_HINSTANCE_hInstance, char* lpMenuName);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadMenuW(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpMenuName);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadMenuW(cpointer unfoundType_HINSTANCE_hInstance, char* lpMenuName);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadMenuIndirectA(cpointer unfoundType_MENUTEMPLATEAlpMenuTemplatelpMenuTemplate_unnamed_0);
    [DllImport("user32", EntryPoint="LoadMenuIndirectW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadMenuIndirect(cpointer unfoundType_MENUTEMPLATEWlpMenuTemplatelpMenuTemplate_unnamed_0);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadMenuIndirectW(cpointer unfoundType_MENUTEMPLATEWlpMenuTemplatelpMenuTemplate_unnamed_0);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetMenu(cpointer hWnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetMenu(cpointer hWnd, cpointer hMenu);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ChangeMenuA(cpointer hMenu, uint cmd, cpointer unfoundType_LPCSTR_lpszNewItem, uint cmdInsert, uint flags);
    [DllImport("user32", EntryPoint="ChangeMenuW", SetLastError=true, ExactSpelling=true)] public static extern
        int ChangeMenu(cpointer hMenu, uint cmd, [MarshalAs(UnmanagedType.LPWStr)] string lpszNewItem, uint cmdInsert, uint flags);
    [DllImport("user32", EntryPoint="ChangeMenuW", SetLastError=true, ExactSpelling=true)] public static extern
        int ChangeMenu(cpointer hMenu, uint cmd, char* lpszNewItem, uint cmdInsert, uint flags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ChangeMenuW(cpointer hMenu, uint cmd, [MarshalAs(UnmanagedType.LPWStr)] string lpszNewItem, uint cmdInsert, uint flags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ChangeMenuW(cpointer hMenu, uint cmd, char* lpszNewItem, uint cmdInsert, uint flags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int HiliteMenuItem(cpointer hWnd, cpointer hMenu, uint uIDHiliteItem, uint uHilite);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetMenuStringA(cpointer hMenu, uint uIDItem, [MarshalAs(UnmanagedType.LPStr)] string lpString, int cchMax, uint flags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetMenuStringA(cpointer hMenu, uint uIDItem, ReadOnlySpan<byte> lpString, int cchMax, uint flags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetMenuStringA(cpointer hMenu, uint uIDItem, byte* lpString, int cchMax, uint flags);
    [DllImport("user32", EntryPoint="GetMenuStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetMenuString(cpointer hMenu, uint uIDItem, string lpString, int cchMax, uint flags);
    [DllImport("user32", EntryPoint="GetMenuStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetMenuString(cpointer hMenu, uint uIDItem, char* lpString, int cchMax, uint flags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetMenuStringW(cpointer hMenu, uint uIDItem, string lpString, int cchMax, uint flags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetMenuStringW(cpointer hMenu, uint uIDItem, char* lpString, int cchMax, uint flags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetMenuState(cpointer hMenu, uint uId, uint uFlags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DrawMenuBar(cpointer hWnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetSystemMenu(cpointer hWnd, int bRevert);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateMenu();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreatePopupMenu();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DestroyMenu(cpointer hMenu);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CheckMenuItem(cpointer hMenu, uint uIDCheckItem, uint uCheck);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnableMenuItem(cpointer hMenu, uint uIDEnableItem, uint uEnable);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetSubMenu(cpointer hMenu, int nPos);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetMenuItemID(cpointer hMenu, int nPos);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetMenuItemCount(cpointer hMenu);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int InsertMenuA(cpointer hMenu, uint uPosition, uint uFlags, ulong uIDNewItem, cpointer unfoundType_LPCSTR_lpNewItem);
    [DllImport("user32", EntryPoint="InsertMenuW", SetLastError=true, ExactSpelling=true)] public static extern
        int InsertMenu(cpointer hMenu, uint uPosition, uint uFlags, ulong uIDNewItem, [MarshalAs(UnmanagedType.LPWStr)] string lpNewItem);
    [DllImport("user32", EntryPoint="InsertMenuW", SetLastError=true, ExactSpelling=true)] public static extern
        int InsertMenu(cpointer hMenu, uint uPosition, uint uFlags, ulong uIDNewItem, char* lpNewItem);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int InsertMenuW(cpointer hMenu, uint uPosition, uint uFlags, ulong uIDNewItem, [MarshalAs(UnmanagedType.LPWStr)] string lpNewItem);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int InsertMenuW(cpointer hMenu, uint uPosition, uint uFlags, ulong uIDNewItem, char* lpNewItem);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int AppendMenuA(cpointer hMenu, uint uFlags, ulong uIDNewItem, cpointer unfoundType_LPCSTR_lpNewItem);
    [DllImport("user32", EntryPoint="AppendMenuW", SetLastError=true, ExactSpelling=true)] public static extern
        int AppendMenu(cpointer hMenu, uint uFlags, ulong uIDNewItem, [MarshalAs(UnmanagedType.LPWStr)] string lpNewItem);
    [DllImport("user32", EntryPoint="AppendMenuW", SetLastError=true, ExactSpelling=true)] public static extern
        int AppendMenu(cpointer hMenu, uint uFlags, ulong uIDNewItem, char* lpNewItem);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int AppendMenuW(cpointer hMenu, uint uFlags, ulong uIDNewItem, [MarshalAs(UnmanagedType.LPWStr)] string lpNewItem);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int AppendMenuW(cpointer hMenu, uint uFlags, ulong uIDNewItem, char* lpNewItem);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ModifyMenuA(cpointer hMnu, uint uPosition, uint uFlags, ulong uIDNewItem, cpointer unfoundType_LPCSTR_lpNewItem);
    [DllImport("user32", EntryPoint="ModifyMenuW", SetLastError=true, ExactSpelling=true)] public static extern
        int ModifyMenu(cpointer hMnu, uint uPosition, uint uFlags, ulong uIDNewItem, [MarshalAs(UnmanagedType.LPWStr)] string lpNewItem);
    [DllImport("user32", EntryPoint="ModifyMenuW", SetLastError=true, ExactSpelling=true)] public static extern
        int ModifyMenu(cpointer hMnu, uint uPosition, uint uFlags, ulong uIDNewItem, char* lpNewItem);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ModifyMenuW(cpointer hMnu, uint uPosition, uint uFlags, ulong uIDNewItem, [MarshalAs(UnmanagedType.LPWStr)] string lpNewItem);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ModifyMenuW(cpointer hMnu, uint uPosition, uint uFlags, ulong uIDNewItem, char* lpNewItem);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DeleteMenu(cpointer hMenu, uint uPosition, uint uFlags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetMenuItemBitmaps(cpointer hMenu, uint uPosition, uint uFlags, cpointer unfoundType_HBITMAP_hBitmapUnchecked, cpointer unfoundType_HBITMAP_hBitmapChecked);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetMenuCheckMarkDimensions();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int TrackPopupMenu(cpointer hMenu, uint uFlags, int x, int y, int nReserved, cpointer hWnd, cpointer unfoundType_RECTprcRectprcRect_unnamed_6);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int TrackPopupMenuEx(cpointer hMenu, uint uFlags, int x, int y, cpointer hwnd, cpointer unfoundType_LPTPMPARAMS_lptpm);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CalculatePopupWindowPosition(cpointer unfoundType_POINTanchorPointanchorPoint_unnamed_0, cpointer unfoundType_SIZEwindowSizewindowSize_unnamed_1, uint flags, cpointer unfoundType_RECTexcludeRectexcludeRect_unnamed_3, cpointer unfoundType_RECTpopupWindowPositionpopupWindowPosition_unnamed_4);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetMenuInfo(cpointer unnamed_0, cpointer unfoundType_LPMENUINFO_unnamed_1);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetMenuInfo(cpointer unnamed_0, cpointer unfoundType_LPCMENUINFO_unnamed_1);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int EndMenu();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int InsertMenuItemA(cpointer hmenu, uint item, int fByPosition, cpointer unfoundType_LPCMENUITEMINFOA_lpmi);
    [DllImport("user32", EntryPoint="InsertMenuItemW", SetLastError=true, ExactSpelling=true)] public static extern
        int InsertMenuItem(cpointer hmenu, uint item, int fByPosition, cpointer unfoundType_LPCMENUITEMINFOW_lpmi);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int InsertMenuItemW(cpointer hmenu, uint item, int fByPosition, cpointer unfoundType_LPCMENUITEMINFOW_lpmi);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetMenuItemInfoA(cpointer hmenu, uint item, int fByPosition, cpointer unfoundType_LPMENUITEMINFOA_lpmii);
    [DllImport("user32", EntryPoint="GetMenuItemInfoW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetMenuItemInfo(cpointer hmenu, uint item, int fByPosition, cpointer unfoundType_LPMENUITEMINFOW_lpmii);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetMenuItemInfoW(cpointer hmenu, uint item, int fByPosition, cpointer unfoundType_LPMENUITEMINFOW_lpmii);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetMenuItemInfoA(cpointer hmenu, uint item, int fByPositon, cpointer unfoundType_LPCMENUITEMINFOA_lpmii);
    [DllImport("user32", EntryPoint="SetMenuItemInfoW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetMenuItemInfo(cpointer hmenu, uint item, int fByPositon, cpointer unfoundType_LPCMENUITEMINFOW_lpmii);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetMenuItemInfoW(cpointer hmenu, uint item, int fByPositon, cpointer unfoundType_LPCMENUITEMINFOW_lpmii);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetMenuDefaultItem(cpointer hMenu, uint fByPos, uint gmdiFlags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetMenuDefaultItem(cpointer hMenu, uint uItem, uint fByPos);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetMenuItemRect(cpointer hWnd, cpointer hMenu, uint uItem, cpointer unfoundType_LPRECT_lprcItem);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int MenuItemFromPoint(cpointer hWnd, cpointer hMenu, cpointer unfoundType_POINT_ptScreen);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DragObject(cpointer hwndParent, cpointer hwndFrom, uint fmt, cpointer unfoundType_ULONG_PTR_data, cpointer unfoundType_HCURSOR_hcur);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DragDetect(cpointer hwnd, cpointer unfoundType_POINT_pt);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DrawIcon(cpointer hDC, int X, int Y, cpointer hIcon);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DrawTextA(cpointer hdc, cpointer unfoundType_LPCSTR_lpchText, int cchText, cpointer unfoundType_LPRECT_lprc, uint format);
    [DllImport("user32", EntryPoint="DrawTextW", SetLastError=true, ExactSpelling=true)] public static extern
        int DrawText(cpointer hdc, [MarshalAs(UnmanagedType.LPWStr)] string lpchText, int cchText, cpointer unfoundType_LPRECT_lprc, uint format);
    [DllImport("user32", EntryPoint="DrawTextW", SetLastError=true, ExactSpelling=true)] public static extern
        int DrawText(cpointer hdc, char* lpchText, int cchText, cpointer unfoundType_LPRECT_lprc, uint format);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DrawTextW(cpointer hdc, [MarshalAs(UnmanagedType.LPWStr)] string lpchText, int cchText, cpointer unfoundType_LPRECT_lprc, uint format);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DrawTextW(cpointer hdc, char* lpchText, int cchText, cpointer unfoundType_LPRECT_lprc, uint format);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DrawTextExA(cpointer hdc, [MarshalAs(UnmanagedType.LPStr)] string lpchText, int cchText, cpointer unfoundType_LPRECT_lprc, uint format, cpointer unfoundType_LPDRAWTEXTPARAMS_lpdtp);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DrawTextExA(cpointer hdc, ReadOnlySpan<byte> lpchText, int cchText, cpointer unfoundType_LPRECT_lprc, uint format, cpointer unfoundType_LPDRAWTEXTPARAMS_lpdtp);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DrawTextExA(cpointer hdc, byte* lpchText, int cchText, cpointer unfoundType_LPRECT_lprc, uint format, cpointer unfoundType_LPDRAWTEXTPARAMS_lpdtp);
    [DllImport("user32", EntryPoint="DrawTextExW", SetLastError=true, ExactSpelling=true)] public static extern
        int DrawTextEx(cpointer hdc, string lpchText, int cchText, cpointer unfoundType_LPRECT_lprc, uint format, cpointer unfoundType_LPDRAWTEXTPARAMS_lpdtp);
    [DllImport("user32", EntryPoint="DrawTextExW", SetLastError=true, ExactSpelling=true)] public static extern
        int DrawTextEx(cpointer hdc, char* lpchText, int cchText, cpointer unfoundType_LPRECT_lprc, uint format, cpointer unfoundType_LPDRAWTEXTPARAMS_lpdtp);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DrawTextExW(cpointer hdc, string lpchText, int cchText, cpointer unfoundType_LPRECT_lprc, uint format, cpointer unfoundType_LPDRAWTEXTPARAMS_lpdtp);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DrawTextExW(cpointer hdc, char* lpchText, int cchText, cpointer unfoundType_LPRECT_lprc, uint format, cpointer unfoundType_LPDRAWTEXTPARAMS_lpdtp);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GrayStringA(cpointer hDC, cpointer hBrush, cpointer unfoundType_GRAYSTRINGPROC_lpOutputFunc, long lpData, int nCount, int X, int Y, int nWidth, int nHeight);
    [DllImport("user32", EntryPoint="GrayStringW", SetLastError=true, ExactSpelling=true)] public static extern
        int GrayString(cpointer hDC, cpointer hBrush, cpointer unfoundType_GRAYSTRINGPROC_lpOutputFunc, long lpData, int nCount, int X, int Y, int nWidth, int nHeight);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GrayStringW(cpointer hDC, cpointer hBrush, cpointer unfoundType_GRAYSTRINGPROC_lpOutputFunc, long lpData, int nCount, int X, int Y, int nWidth, int nHeight);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DrawStateA(cpointer hdc, cpointer hbrFore, cpointer unfoundType_DRAWSTATEPROC_qfnCallBack, long lData, ulong wData, int x, int y, int cx, int cy, uint uFlags);
    [DllImport("user32", EntryPoint="DrawStateW", SetLastError=true, ExactSpelling=true)] public static extern
        int DrawState(cpointer hdc, cpointer hbrFore, cpointer unfoundType_DRAWSTATEPROC_qfnCallBack, long lData, ulong wData, int x, int y, int cx, int cy, uint uFlags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DrawStateW(cpointer hdc, cpointer hbrFore, cpointer unfoundType_DRAWSTATEPROC_qfnCallBack, long lData, ulong wData, int x, int y, int cx, int cy, uint uFlags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int TabbedTextOutA(cpointer hdc, int x, int y, cpointer unfoundType_LPCSTR_lpString, int chCount, int nTabPositions, cpointer unfoundType_INTlpnTabStopPositionslpnTabStopPositions_unnamed_6, int nTabOrigin);
    [DllImport("user32", EntryPoint="TabbedTextOutW", SetLastError=true, ExactSpelling=true)] public static extern
        int TabbedTextOut(cpointer hdc, int x, int y, [MarshalAs(UnmanagedType.LPWStr)] string lpString, int chCount, int nTabPositions, cpointer unfoundType_INTlpnTabStopPositionslpnTabStopPositions_unnamed_6, int nTabOrigin);
    [DllImport("user32", EntryPoint="TabbedTextOutW", SetLastError=true, ExactSpelling=true)] public static extern
        int TabbedTextOut(cpointer hdc, int x, int y, char* lpString, int chCount, int nTabPositions, cpointer unfoundType_INTlpnTabStopPositionslpnTabStopPositions_unnamed_6, int nTabOrigin);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int TabbedTextOutW(cpointer hdc, int x, int y, [MarshalAs(UnmanagedType.LPWStr)] string lpString, int chCount, int nTabPositions, cpointer unfoundType_INTlpnTabStopPositionslpnTabStopPositions_unnamed_6, int nTabOrigin);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int TabbedTextOutW(cpointer hdc, int x, int y, char* lpString, int chCount, int nTabPositions, cpointer unfoundType_INTlpnTabStopPositionslpnTabStopPositions_unnamed_6, int nTabOrigin);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTabbedTextExtentA(cpointer hdc, cpointer unfoundType_LPCSTR_lpString, int chCount, int nTabPositions, cpointer unfoundType_INTlpnTabStopPositionslpnTabStopPositions_unnamed_4);
    [DllImport("user32", EntryPoint="GetTabbedTextExtentW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTabbedTextExtent(cpointer hdc, [MarshalAs(UnmanagedType.LPWStr)] string lpString, int chCount, int nTabPositions, cpointer unfoundType_INTlpnTabStopPositionslpnTabStopPositions_unnamed_4);
    [DllImport("user32", EntryPoint="GetTabbedTextExtentW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTabbedTextExtent(cpointer hdc, char* lpString, int chCount, int nTabPositions, cpointer unfoundType_INTlpnTabStopPositionslpnTabStopPositions_unnamed_4);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTabbedTextExtentW(cpointer hdc, [MarshalAs(UnmanagedType.LPWStr)] string lpString, int chCount, int nTabPositions, cpointer unfoundType_INTlpnTabStopPositionslpnTabStopPositions_unnamed_4);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTabbedTextExtentW(cpointer hdc, char* lpString, int chCount, int nTabPositions, cpointer unfoundType_INTlpnTabStopPositionslpnTabStopPositions_unnamed_4);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int UpdateWindow(cpointer hWnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer SetActiveWindow(cpointer hWnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetForegroundWindow();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int PaintDesktop(cpointer hdc);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        void SwitchToThisWindow(cpointer hwnd, int fUnknown);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetForegroundWindow(cpointer hWnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int AllowSetForegroundWindow(int dwProcessId);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int LockSetForegroundWindow(uint uLockCode);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer WindowFromDC(cpointer hDC);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetDC(cpointer hWnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetDCEx(cpointer hWnd, cpointer hrgnClip, int flags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetWindowDC(cpointer hWnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ReleaseDC(cpointer hWnd, cpointer hDC);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer BeginPaint(cpointer hWnd, cpointer unfoundType_LPPAINTSTRUCT_lpPaint);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int EndPaint(cpointer hWnd, cpointer unfoundType_PAINTSTRUCTlpPaintlpPaint_unnamed_1);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetUpdateRect(cpointer hWnd, cpointer unfoundType_LPRECT_lpRect, int bErase);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetUpdateRgn(cpointer hWnd, cpointer hRgn, int bErase);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetWindowRgn(cpointer hWnd, cpointer hRgn, int bRedraw);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetWindowRgn(cpointer hWnd, cpointer hRgn);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetWindowRgnBox(cpointer hWnd, cpointer unfoundType_LPRECT_lprc);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ExcludeUpdateRgn(cpointer hDC, cpointer hWnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int InvalidateRect(cpointer hWnd, cpointer unfoundType_RECTlpRectlpRect_unnamed_1, int bErase);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ValidateRect(cpointer hWnd, cpointer unfoundType_RECTlpRectlpRect_unnamed_1);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int InvalidateRgn(cpointer hWnd, cpointer hRgn, int bErase);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ValidateRgn(cpointer hWnd, cpointer hRgn);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int RedrawWindow(cpointer hWnd, cpointer unfoundType_RECTlprcUpdatelprcUpdate_unnamed_1, cpointer hrgnUpdate, uint flags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int LockWindowUpdate(cpointer hWndLock);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ScrollWindow(cpointer hWnd, int XAmount, int YAmount, cpointer unfoundType_RECTlpRectlpRect_unnamed_3, cpointer unfoundType_RECTlpClipRectlpClipRect_unnamed_4);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ScrollDC(cpointer hDC, int dx, int dy, cpointer unfoundType_RECTlprcScrolllprcScroll_unnamed_3, cpointer unfoundType_RECTlprcCliplprcClip_unnamed_4, cpointer hrgnUpdate, cpointer unfoundType_LPRECT_lprcUpdate);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ScrollWindowEx(cpointer hWnd, int dx, int dy, cpointer unfoundType_RECTprcScrollprcScroll_unnamed_3, cpointer unfoundType_RECTprcClipprcClip_unnamed_4, cpointer hrgnUpdate, cpointer unfoundType_LPRECT_prcUpdate, uint flags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetScrollPos(cpointer hWnd, int nBar, int nPos, int bRedraw);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetScrollPos(cpointer hWnd, int nBar);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetScrollRange(cpointer hWnd, int nBar, int nMinPos, int nMaxPos, int bRedraw);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetScrollRange(cpointer hWnd, int nBar, cpointer unfoundType_LPINT_lpMinPos, cpointer unfoundType_LPINT_lpMaxPos);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ShowScrollBar(cpointer hWnd, int wBar, int bShow);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnableScrollBar(cpointer hWnd, uint wSBflags, uint wArrows);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetPropA(cpointer hWnd, cpointer unfoundType_LPCSTR_lpString, cpointer hData);
    [DllImport("user32", EntryPoint="SetPropW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetProp(cpointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpString, cpointer hData);
    [DllImport("user32", EntryPoint="SetPropW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetProp(cpointer hWnd, char* lpString, cpointer hData);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetPropW(cpointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpString, cpointer hData);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetPropW(cpointer hWnd, char* lpString, cpointer hData);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetPropA(cpointer hWnd, cpointer unfoundType_LPCSTR_lpString);
    [DllImport("user32", EntryPoint="GetPropW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetProp(cpointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport("user32", EntryPoint="GetPropW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetProp(cpointer hWnd, char* lpString);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetPropW(cpointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetPropW(cpointer hWnd, char* lpString);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RemovePropA(cpointer hWnd, cpointer unfoundType_LPCSTR_lpString);
    [DllImport("user32", EntryPoint="RemovePropW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RemoveProp(cpointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport("user32", EntryPoint="RemovePropW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RemoveProp(cpointer hWnd, char* lpString);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RemovePropW(cpointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RemovePropW(cpointer hWnd, char* lpString);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumPropsExA(cpointer hWnd, cpointer unfoundType_PROPENUMPROCEXA_lpEnumFunc, long lParam);
    [DllImport("user32", EntryPoint="EnumPropsExW", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumPropsEx(cpointer hWnd, cpointer unfoundType_PROPENUMPROCEXW_lpEnumFunc, long lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumPropsExW(cpointer hWnd, cpointer unfoundType_PROPENUMPROCEXW_lpEnumFunc, long lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumPropsA(cpointer hWnd, cpointer unfoundType_PROPENUMPROCA_lpEnumFunc);
    [DllImport("user32", EntryPoint="EnumPropsW", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumProps(cpointer hWnd, cpointer unfoundType_PROPENUMPROCW_lpEnumFunc);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumPropsW(cpointer hWnd, cpointer unfoundType_PROPENUMPROCW_lpEnumFunc);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetWindowTextA(cpointer hWnd, cpointer unfoundType_LPCSTR_lpString);
    [DllImport("user32", EntryPoint="SetWindowTextW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetWindowText(cpointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport("user32", EntryPoint="SetWindowTextW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetWindowText(cpointer hWnd, char* lpString);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetWindowTextW(cpointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetWindowTextW(cpointer hWnd, char* lpString);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetWindowTextA(cpointer hWnd, [MarshalAs(UnmanagedType.LPStr)] string lpString, int nMaxCount);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetWindowTextA(cpointer hWnd, ReadOnlySpan<byte> lpString, int nMaxCount);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetWindowTextA(cpointer hWnd, byte* lpString, int nMaxCount);
    [DllImport("user32", EntryPoint="GetWindowTextW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetWindowText(cpointer hWnd, string lpString, int nMaxCount);
    [DllImport("user32", EntryPoint="GetWindowTextW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetWindowText(cpointer hWnd, char* lpString, int nMaxCount);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetWindowTextW(cpointer hWnd, string lpString, int nMaxCount);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetWindowTextW(cpointer hWnd, char* lpString, int nMaxCount);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetWindowTextLengthA(cpointer hWnd);
    [DllImport("user32", EntryPoint="GetWindowTextLengthW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetWindowTextLength(cpointer hWnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetWindowTextLengthW(cpointer hWnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetClientRect(cpointer hWnd, cpointer unfoundType_LPRECT_lpRect);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetWindowRect(cpointer hWnd, cpointer unfoundType_LPRECT_lpRect);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int AdjustWindowRect(cpointer unfoundType_LPRECT_lpRect, int dwStyle, int bMenu);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int AdjustWindowRectEx(cpointer unfoundType_LPRECT_lpRect, int dwStyle, int bMenu, int dwExStyle);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int AdjustWindowRectExForDpi(cpointer unfoundType_LPRECT_lpRect, int dwStyle, int bMenu, int dwExStyle, uint dpi);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetWindowContextHelpId(cpointer unnamed_0, int unnamed_1);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetWindowContextHelpId(cpointer unnamed_0);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetMenuContextHelpId(cpointer unnamed_0, int unnamed_1);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetMenuContextHelpId(cpointer unnamed_0);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int MessageBoxA(cpointer hWnd, cpointer unfoundType_LPCSTR_lpText, cpointer unfoundType_LPCSTR_lpCaption, uint uType);
    [DllImport("user32", EntryPoint="MessageBoxW", SetLastError=true, ExactSpelling=true)] public static extern
        int MessageBox(cpointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpText, [MarshalAs(UnmanagedType.LPWStr)] string lpCaption, uint uType);
    [DllImport("user32", EntryPoint="MessageBoxW", SetLastError=true, ExactSpelling=true)] public static extern
        int MessageBox(cpointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpText, char* lpCaption, uint uType);
    [DllImport("user32", EntryPoint="MessageBoxW", SetLastError=true, ExactSpelling=true)] public static extern
        int MessageBox(cpointer hWnd, char* lpText, [MarshalAs(UnmanagedType.LPWStr)] string lpCaption, uint uType);
    [DllImport("user32", EntryPoint="MessageBoxW", SetLastError=true, ExactSpelling=true)] public static extern
        int MessageBox(cpointer hWnd, char* lpText, char* lpCaption, uint uType);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int MessageBoxW(cpointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpText, [MarshalAs(UnmanagedType.LPWStr)] string lpCaption, uint uType);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int MessageBoxW(cpointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpText, char* lpCaption, uint uType);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int MessageBoxW(cpointer hWnd, char* lpText, [MarshalAs(UnmanagedType.LPWStr)] string lpCaption, uint uType);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int MessageBoxW(cpointer hWnd, char* lpText, char* lpCaption, uint uType);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int MessageBoxExA(cpointer hWnd, cpointer unfoundType_LPCSTR_lpText, cpointer unfoundType_LPCSTR_lpCaption, uint uType, short wLanguageId);
    [DllImport("user32", EntryPoint="MessageBoxExW", SetLastError=true, ExactSpelling=true)] public static extern
        int MessageBoxEx(cpointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpText, [MarshalAs(UnmanagedType.LPWStr)] string lpCaption, uint uType, short wLanguageId);
    [DllImport("user32", EntryPoint="MessageBoxExW", SetLastError=true, ExactSpelling=true)] public static extern
        int MessageBoxEx(cpointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpText, char* lpCaption, uint uType, short wLanguageId);
    [DllImport("user32", EntryPoint="MessageBoxExW", SetLastError=true, ExactSpelling=true)] public static extern
        int MessageBoxEx(cpointer hWnd, char* lpText, [MarshalAs(UnmanagedType.LPWStr)] string lpCaption, uint uType, short wLanguageId);
    [DllImport("user32", EntryPoint="MessageBoxExW", SetLastError=true, ExactSpelling=true)] public static extern
        int MessageBoxEx(cpointer hWnd, char* lpText, char* lpCaption, uint uType, short wLanguageId);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int MessageBoxExW(cpointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpText, [MarshalAs(UnmanagedType.LPWStr)] string lpCaption, uint uType, short wLanguageId);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int MessageBoxExW(cpointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpText, char* lpCaption, uint uType, short wLanguageId);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int MessageBoxExW(cpointer hWnd, char* lpText, [MarshalAs(UnmanagedType.LPWStr)] string lpCaption, uint uType, short wLanguageId);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int MessageBoxExW(cpointer hWnd, char* lpText, char* lpCaption, uint uType, short wLanguageId);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int MessageBoxIndirectA(cpointer unfoundType_MSGBOXPARAMSA_lpmbp);
    [DllImport("user32", EntryPoint="MessageBoxIndirectW", SetLastError=true, ExactSpelling=true)] public static extern
        int MessageBoxIndirect(cpointer unfoundType_MSGBOXPARAMSW_lpmbp);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int MessageBoxIndirectW(cpointer unfoundType_MSGBOXPARAMSW_lpmbp);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int MessageBeep(uint uType);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ShowCursor(int bShow);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetCursorPos(int X, int Y);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetPhysicalCursorPos(int X, int Y);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer SetCursor(cpointer unfoundType_HCURSOR_hCursor);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCursorPos(cpointer unfoundType_LPPOINT_lpPoint);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPhysicalCursorPos(cpointer unfoundType_LPPOINT_lpPoint);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetClipCursor(cpointer unfoundType_LPRECT_lpRect);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetCursor();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CreateCaret(cpointer hWnd, cpointer unfoundType_HBITMAP_hBitmap, int nWidth, int nHeight);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetCaretBlinkTime();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetCaretBlinkTime(uint uMSeconds);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DestroyCaret();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int HideCaret(cpointer hWnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ShowCaret(cpointer hWnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetCaretPos(int X, int Y);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCaretPos(cpointer unfoundType_LPPOINT_lpPoint);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ClientToScreen(cpointer hWnd, cpointer unfoundType_LPPOINT_lpPoint);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ScreenToClient(cpointer hWnd, cpointer unfoundType_LPPOINT_lpPoint);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int LogicalToPhysicalPoint(cpointer hWnd, cpointer unfoundType_LPPOINT_lpPoint);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int PhysicalToLogicalPoint(cpointer hWnd, cpointer unfoundType_LPPOINT_lpPoint);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int LogicalToPhysicalPointForPerMonitorDPI(cpointer hWnd, cpointer unfoundType_LPPOINT_lpPoint);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int PhysicalToLogicalPointForPerMonitorDPI(cpointer hWnd, cpointer unfoundType_LPPOINT_lpPoint);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int MapWindowPoints(cpointer hWndFrom, cpointer hWndTo, cpointer unfoundType_LPPOINT_lpPoints, uint cPoints);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer WindowFromPoint(cpointer unfoundType_POINT_Point);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer WindowFromPhysicalPoint(cpointer unfoundType_POINT_Point);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer ChildWindowFromPoint(cpointer hWndParent, cpointer unfoundType_POINT_Point);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ClipCursor(cpointer unfoundType_RECTlpRectlpRect_unnamed_0);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer ChildWindowFromPointEx(cpointer hwnd, cpointer unfoundType_POINT_pt, uint flags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetSysColor(int nIndex);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetSysColorBrush(int nIndex);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetSysColors(int cElements, cpointer lpaElements, cpointer unfoundType_COLORREF_lpaRgbValues);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DrawFocusRect(cpointer hDC, cpointer unfoundType_RECT_lprc);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int FillRect(cpointer hDC, cpointer unfoundType_RECTlprclprc_unnamed_1, cpointer hbr);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int FrameRect(cpointer hDC, cpointer unfoundType_RECTlprclprc_unnamed_1, cpointer hbr);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int InvertRect(cpointer hDC, cpointer unfoundType_RECTlprclprc_unnamed_1);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetRect(cpointer unfoundType_LPRECT_lprc, int xLeft, int yTop, int xRight, int yBottom);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetRectEmpty(cpointer unfoundType_LPRECT_lprc);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CopyRect(cpointer unfoundType_LPRECT_lprcDst, cpointer unfoundType_RECTlprcSrclprcSrc_unnamed_1);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int InflateRect(cpointer unfoundType_LPRECT_lprc, int dx, int dy);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int IntersectRect(cpointer unfoundType_LPRECT_lprcDst, cpointer unfoundType_RECTlprcSrc1lprcSrc1_unnamed_1, cpointer unfoundType_RECTlprcSrc2lprcSrc2_unnamed_2);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int UnionRect(cpointer unfoundType_LPRECT_lprcDst, cpointer unfoundType_RECTlprcSrc1lprcSrc1_unnamed_1, cpointer unfoundType_RECTlprcSrc2lprcSrc2_unnamed_2);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SubtractRect(cpointer unfoundType_LPRECT_lprcDst, cpointer unfoundType_RECTlprcSrc1lprcSrc1_unnamed_1, cpointer unfoundType_RECTlprcSrc2lprcSrc2_unnamed_2);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int OffsetRect(cpointer unfoundType_LPRECT_lprc, int dx, int dy);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsRectEmpty(cpointer unfoundType_RECTlprclprc_unnamed_0);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int EqualRect(cpointer unfoundType_RECTlprc1lprc1_unnamed_0, cpointer unfoundType_RECTlprc2lprc2_unnamed_1);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int PtInRect(cpointer unfoundType_RECTlprclprc_unnamed_0, cpointer unfoundType_POINT_pt);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        short GetWindowWord(cpointer hWnd, int nIndex);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        short SetWindowWord(cpointer hWnd, int nIndex, short wNewWord);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetWindowLongA(cpointer hWnd, int nIndex);
    [DllImport("user32", EntryPoint="GetWindowLongW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetWindowLong(cpointer hWnd, int nIndex);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetWindowLongW(cpointer hWnd, int nIndex);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetWindowLongA(cpointer hWnd, int nIndex, int dwNewLong);
    [DllImport("user32", EntryPoint="SetWindowLongW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetWindowLong(cpointer hWnd, int nIndex, int dwNewLong);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetWindowLongW(cpointer hWnd, int nIndex, int dwNewLong);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        long GetWindowLongPtrA(cpointer hWnd, int nIndex);
    [DllImport("user32", EntryPoint="GetWindowLongPtrW", SetLastError=true, ExactSpelling=true)] public static extern
        long GetWindowLongPtr(cpointer hWnd, int nIndex);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        long GetWindowLongPtrW(cpointer hWnd, int nIndex);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        long SetWindowLongPtrA(cpointer hWnd, int nIndex, long dwNewLong);
    [DllImport("user32", EntryPoint="SetWindowLongPtrW", SetLastError=true, ExactSpelling=true)] public static extern
        long SetWindowLongPtr(cpointer hWnd, int nIndex, long dwNewLong);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        long SetWindowLongPtrW(cpointer hWnd, int nIndex, long dwNewLong);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        short GetClassWord(cpointer hWnd, int nIndex);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        short SetClassWord(cpointer hWnd, int nIndex, short wNewWord);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetClassLongA(cpointer hWnd, int nIndex);
    [DllImport("user32", EntryPoint="GetClassLongW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetClassLong(cpointer hWnd, int nIndex);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetClassLongW(cpointer hWnd, int nIndex);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetClassLongA(cpointer hWnd, int nIndex, int dwNewLong);
    [DllImport("user32", EntryPoint="SetClassLongW", SetLastError=true, ExactSpelling=true)] public static extern
        int SetClassLong(cpointer hWnd, int nIndex, int dwNewLong);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetClassLongW(cpointer hWnd, int nIndex, int dwNewLong);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetClassLongPtrA(cpointer hWnd, int nIndex);
    [DllImport("user32", EntryPoint="GetClassLongPtrW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetClassLongPtr(cpointer hWnd, int nIndex);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetClassLongPtrW(cpointer hWnd, int nIndex);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer SetClassLongPtrA(cpointer hWnd, int nIndex, long dwNewLong);
    [DllImport("user32", EntryPoint="SetClassLongPtrW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer SetClassLongPtr(cpointer hWnd, int nIndex, long dwNewLong);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer SetClassLongPtrW(cpointer hWnd, int nIndex, long dwNewLong);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetProcessDefaultLayout(cpointer unfoundType_DWORDpdwDefaultLayoutpdwDefaultLayout_unnamed_0);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetProcessDefaultLayout(int dwDefaultLayout);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetDesktopWindow();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetParent(cpointer hWnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer SetParent(cpointer hWndChild, cpointer hWndNewParent);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumChildWindows(cpointer hWndParent, cpointer unfoundType_WNDENUMPROC_lpEnumFunc, long lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindWindowA(cpointer unfoundType_LPCSTR_lpClassName, cpointer unfoundType_LPCSTR_lpWindowName);
    [DllImport("user32", EntryPoint="FindWindowW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindWindow([MarshalAs(UnmanagedType.LPWStr)] string lpClassName, [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName);
    [DllImport("user32", EntryPoint="FindWindowW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindWindow([MarshalAs(UnmanagedType.LPWStr)] string lpClassName, char* lpWindowName);
    [DllImport("user32", EntryPoint="FindWindowW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindWindow(char* lpClassName, [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName);
    [DllImport("user32", EntryPoint="FindWindowW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindWindow(char* lpClassName, char* lpWindowName);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindWindowW([MarshalAs(UnmanagedType.LPWStr)] string lpClassName, [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindWindowW([MarshalAs(UnmanagedType.LPWStr)] string lpClassName, char* lpWindowName);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindWindowW(char* lpClassName, [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindWindowW(char* lpClassName, char* lpWindowName);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindWindowExA(cpointer hWndParent, cpointer hWndChildAfter, cpointer unfoundType_LPCSTR_lpszClass, cpointer unfoundType_LPCSTR_lpszWindow);
    [DllImport("user32", EntryPoint="FindWindowExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindWindowEx(cpointer hWndParent, cpointer hWndChildAfter, [MarshalAs(UnmanagedType.LPWStr)] string lpszClass, [MarshalAs(UnmanagedType.LPWStr)] string lpszWindow);
    [DllImport("user32", EntryPoint="FindWindowExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindWindowEx(cpointer hWndParent, cpointer hWndChildAfter, [MarshalAs(UnmanagedType.LPWStr)] string lpszClass, char* lpszWindow);
    [DllImport("user32", EntryPoint="FindWindowExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindWindowEx(cpointer hWndParent, cpointer hWndChildAfter, char* lpszClass, [MarshalAs(UnmanagedType.LPWStr)] string lpszWindow);
    [DllImport("user32", EntryPoint="FindWindowExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindWindowEx(cpointer hWndParent, cpointer hWndChildAfter, char* lpszClass, char* lpszWindow);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindWindowExW(cpointer hWndParent, cpointer hWndChildAfter, [MarshalAs(UnmanagedType.LPWStr)] string lpszClass, [MarshalAs(UnmanagedType.LPWStr)] string lpszWindow);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindWindowExW(cpointer hWndParent, cpointer hWndChildAfter, [MarshalAs(UnmanagedType.LPWStr)] string lpszClass, char* lpszWindow);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindWindowExW(cpointer hWndParent, cpointer hWndChildAfter, char* lpszClass, [MarshalAs(UnmanagedType.LPWStr)] string lpszWindow);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer FindWindowExW(cpointer hWndParent, cpointer hWndChildAfter, char* lpszClass, char* lpszWindow);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetShellWindow();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int RegisterShellHookWindow(cpointer hwnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DeregisterShellHookWindow(cpointer hwnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumWindows(cpointer unfoundType_WNDENUMPROC_lpEnumFunc, long lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumThreadWindows(int dwThreadId, cpointer unfoundType_WNDENUMPROC_lpfn, long lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetClassNameA(cpointer hWnd, [MarshalAs(UnmanagedType.LPStr)] string lpClassName, int nMaxCount);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetClassNameA(cpointer hWnd, ReadOnlySpan<byte> lpClassName, int nMaxCount);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetClassNameA(cpointer hWnd, byte* lpClassName, int nMaxCount);
    [DllImport("user32", EntryPoint="GetClassNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetClassName(cpointer hWnd, string lpClassName, int nMaxCount);
    [DllImport("user32", EntryPoint="GetClassNameW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetClassName(cpointer hWnd, char* lpClassName, int nMaxCount);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetClassNameW(cpointer hWnd, string lpClassName, int nMaxCount);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetClassNameW(cpointer hWnd, char* lpClassName, int nMaxCount);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetTopWindow(cpointer hWnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetWindowThreadProcessId(cpointer hWnd, cpointer unfoundType_LPDWORD_lpdwProcessId);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsGUIThread(int bConvert);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetLastActivePopup(cpointer hWnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetWindow(cpointer hWnd, uint uCmd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer SetWindowsHookA(int nFilterType, cpointer unfoundType_HOOKPROC_pfnFilterProc);
    [DllImport("user32", EntryPoint="SetWindowsHookW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer SetWindowsHook(int nFilterType, cpointer unfoundType_HOOKPROC_pfnFilterProc);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer SetWindowsHookW(int nFilterType, cpointer unfoundType_HOOKPROC_pfnFilterProc);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int UnhookWindowsHook(int nCode, cpointer unfoundType_HOOKPROC_pfnFilterProc);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer SetWindowsHookExA(int idHook, cpointer unfoundType_HOOKPROC_lpfn, cpointer unfoundType_HINSTANCE_hmod, int dwThreadId);
    [DllImport("user32", EntryPoint="SetWindowsHookExW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer SetWindowsHookEx(int idHook, cpointer unfoundType_HOOKPROC_lpfn, cpointer unfoundType_HINSTANCE_hmod, int dwThreadId);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer SetWindowsHookExW(int idHook, cpointer unfoundType_HOOKPROC_lpfn, cpointer unfoundType_HINSTANCE_hmod, int dwThreadId);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int UnhookWindowsHookEx(cpointer unfoundType_HHOOK_hhk);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        long CallNextHookEx(cpointer unfoundType_HHOOK_hhk, int nCode, ulong wParam, long lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CheckMenuRadioItem(cpointer hmenu, uint first, uint last, uint check, uint flags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadBitmapA(cpointer unfoundType_HINSTANCE_hInstance, cpointer unfoundType_LPCSTR_lpBitmapName);
    [DllImport("user32", EntryPoint="LoadBitmapW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadBitmap(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpBitmapName);
    [DllImport("user32", EntryPoint="LoadBitmapW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadBitmap(cpointer unfoundType_HINSTANCE_hInstance, char* lpBitmapName);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadBitmapW(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpBitmapName);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadBitmapW(cpointer unfoundType_HINSTANCE_hInstance, char* lpBitmapName);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadCursorA(cpointer unfoundType_HINSTANCE_hInstance, cpointer unfoundType_LPCSTR_lpCursorName);
    [DllImport("user32", EntryPoint="LoadCursorW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadCursor(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpCursorName);
    [DllImport("user32", EntryPoint="LoadCursorW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadCursor(cpointer unfoundType_HINSTANCE_hInstance, char* lpCursorName);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadCursorW(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpCursorName);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadCursorW(cpointer unfoundType_HINSTANCE_hInstance, char* lpCursorName);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadCursorFromFileA(cpointer unfoundType_LPCSTR_lpFileName);
    [DllImport("user32", EntryPoint="LoadCursorFromFileW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadCursorFromFile([MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("user32", EntryPoint="LoadCursorFromFileW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadCursorFromFile(char* lpFileName);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadCursorFromFileW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadCursorFromFileW(char* lpFileName);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateCursor(cpointer unfoundType_HINSTANCE_hInst, int xHotSpot, int yHotSpot, int nWidth, int nHeight, cpointer unfoundType_VOIDpvANDPlanepvANDPlane_unnamed_5, cpointer unfoundType_VOIDpvXORPlanepvXORPlane_unnamed_6);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DestroyCursor(cpointer unfoundType_HCURSOR_hCursor);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetSystemCursor(cpointer unfoundType_HCURSOR_hcur, int id);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadIconA(cpointer unfoundType_HINSTANCE_hInstance, cpointer unfoundType_LPCSTR_lpIconName);
    [DllImport("user32", EntryPoint="LoadIconW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadIcon(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpIconName);
    [DllImport("user32", EntryPoint="LoadIconW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadIcon(cpointer unfoundType_HINSTANCE_hInstance, char* lpIconName);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadIconW(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpIconName);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadIconW(cpointer unfoundType_HINSTANCE_hInstance, char* lpIconName);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint PrivateExtractIconsA(cpointer unfoundType_LPCSTR_szFileName, int nIconIndex, int cxIcon, int cyIcon, cpointer unfoundType_HICONphiconphicon_unnamed_4, cpointer unfoundType_UINTpiconidpiconid_unnamed_5, uint nIcons, uint flags);
    [DllImport("user32", EntryPoint="PrivateExtractIconsW", SetLastError=true, ExactSpelling=true)] public static extern
        uint PrivateExtractIcons([MarshalAs(UnmanagedType.LPWStr)] string szFileName, int nIconIndex, int cxIcon, int cyIcon, cpointer unfoundType_HICONphiconphicon_unnamed_4, cpointer unfoundType_UINTpiconidpiconid_unnamed_5, uint nIcons, uint flags);
    [DllImport("user32", EntryPoint="PrivateExtractIconsW", SetLastError=true, ExactSpelling=true)] public static extern
        uint PrivateExtractIcons(char* szFileName, int nIconIndex, int cxIcon, int cyIcon, cpointer unfoundType_HICONphiconphicon_unnamed_4, cpointer unfoundType_UINTpiconidpiconid_unnamed_5, uint nIcons, uint flags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint PrivateExtractIconsW([MarshalAs(UnmanagedType.LPWStr)] string szFileName, int nIconIndex, int cxIcon, int cyIcon, cpointer unfoundType_HICONphiconphicon_unnamed_4, cpointer unfoundType_UINTpiconidpiconid_unnamed_5, uint nIcons, uint flags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint PrivateExtractIconsW(char* szFileName, int nIconIndex, int cxIcon, int cyIcon, cpointer unfoundType_HICONphiconphicon_unnamed_4, cpointer unfoundType_UINTpiconidpiconid_unnamed_5, uint nIcons, uint flags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateIcon(cpointer unfoundType_HINSTANCE_hInstance, int nWidth, int nHeight, byte cPlanes, byte cBitsPixel, cpointer unfoundType_BYTElpbANDbitslpbANDbits_unnamed_5, cpointer unfoundType_BYTElpbXORbitslpbXORbits_unnamed_6);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DestroyIcon(cpointer hIcon);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int LookupIconIdFromDirectory(cpointer unfoundType_PBYTE_presbits, int fIcon);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int LookupIconIdFromDirectoryEx(cpointer unfoundType_PBYTE_presbits, int fIcon, int cxDesired, int cyDesired, uint Flags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateIconFromResource(cpointer unfoundType_PBYTE_presbits, int dwResSize, int fIcon, int dwVer);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateIconFromResourceEx(cpointer unfoundType_PBYTE_presbits, int dwResSize, int fIcon, int dwVer, int cxDesired, int cyDesired, uint Flags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint SetThreadCursorCreationScaling(uint cursorDpi);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadImageA(cpointer unfoundType_HINSTANCE_hInst, cpointer unfoundType_LPCSTR_name, uint type, int cx, int cy, uint fuLoad);
    [DllImport("user32", EntryPoint="LoadImageW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadImage(cpointer unfoundType_HINSTANCE_hInst, [MarshalAs(UnmanagedType.LPWStr)] string name, uint type, int cx, int cy, uint fuLoad);
    [DllImport("user32", EntryPoint="LoadImageW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadImage(cpointer unfoundType_HINSTANCE_hInst, char* name, uint type, int cx, int cy, uint fuLoad);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadImageW(cpointer unfoundType_HINSTANCE_hInst, [MarshalAs(UnmanagedType.LPWStr)] string name, uint type, int cx, int cy, uint fuLoad);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer LoadImageW(cpointer unfoundType_HINSTANCE_hInst, char* name, uint type, int cx, int cy, uint fuLoad);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CopyImage(cpointer h, uint type, int cx, int cy, uint flags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateIconIndirect(cpointer unfoundType_PICONINFO_piconinfo);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CopyIcon(cpointer hIcon);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetIconInfo(cpointer hIcon, cpointer unfoundType_PICONINFO_piconinfo);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetIconInfoExA(cpointer hicon, cpointer unfoundType_PICONINFOEXA_piconinfo);
    [DllImport("user32", EntryPoint="GetIconInfoExW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetIconInfoEx(cpointer hicon, cpointer unfoundType_PICONINFOEXW_piconinfo);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetIconInfoExW(cpointer hicon, cpointer unfoundType_PICONINFOEXW_piconinfo);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsDialogMessageA(cpointer hDlg, cpointer unfoundType_LPMSG_lpMsg);
    [DllImport("user32", EntryPoint="IsDialogMessageW", SetLastError=true, ExactSpelling=true)] public static extern
        int IsDialogMessage(cpointer hDlg, cpointer unfoundType_LPMSG_lpMsg);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsDialogMessageW(cpointer hDlg, cpointer unfoundType_LPMSG_lpMsg);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int MapDialogRect(cpointer hDlg, cpointer unfoundType_LPRECT_lpRect);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DlgDirListA(cpointer hDlg, [MarshalAs(UnmanagedType.LPStr)] string lpPathSpec, int nIDListBox, int nIDStaticPath, uint uFileType);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DlgDirListA(cpointer hDlg, ReadOnlySpan<byte> lpPathSpec, int nIDListBox, int nIDStaticPath, uint uFileType);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DlgDirListA(cpointer hDlg, byte* lpPathSpec, int nIDListBox, int nIDStaticPath, uint uFileType);
    [DllImport("user32", EntryPoint="DlgDirListW", SetLastError=true, ExactSpelling=true)] public static extern
        int DlgDirList(cpointer hDlg, string lpPathSpec, int nIDListBox, int nIDStaticPath, uint uFileType);
    [DllImport("user32", EntryPoint="DlgDirListW", SetLastError=true, ExactSpelling=true)] public static extern
        int DlgDirList(cpointer hDlg, char* lpPathSpec, int nIDListBox, int nIDStaticPath, uint uFileType);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DlgDirListW(cpointer hDlg, string lpPathSpec, int nIDListBox, int nIDStaticPath, uint uFileType);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DlgDirListW(cpointer hDlg, char* lpPathSpec, int nIDListBox, int nIDStaticPath, uint uFileType);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DlgDirSelectExA(cpointer hwndDlg, [MarshalAs(UnmanagedType.LPStr)] string lpString, int chCount, int idListBox);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DlgDirSelectExA(cpointer hwndDlg, ReadOnlySpan<byte> lpString, int chCount, int idListBox);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DlgDirSelectExA(cpointer hwndDlg, byte* lpString, int chCount, int idListBox);
    [DllImport("user32", EntryPoint="DlgDirSelectExW", SetLastError=true, ExactSpelling=true)] public static extern
        int DlgDirSelectEx(cpointer hwndDlg, string lpString, int chCount, int idListBox);
    [DllImport("user32", EntryPoint="DlgDirSelectExW", SetLastError=true, ExactSpelling=true)] public static extern
        int DlgDirSelectEx(cpointer hwndDlg, char* lpString, int chCount, int idListBox);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DlgDirSelectExW(cpointer hwndDlg, string lpString, int chCount, int idListBox);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DlgDirSelectExW(cpointer hwndDlg, char* lpString, int chCount, int idListBox);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DlgDirListComboBoxA(cpointer hDlg, [MarshalAs(UnmanagedType.LPStr)] string lpPathSpec, int nIDComboBox, int nIDStaticPath, uint uFiletype);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DlgDirListComboBoxA(cpointer hDlg, ReadOnlySpan<byte> lpPathSpec, int nIDComboBox, int nIDStaticPath, uint uFiletype);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DlgDirListComboBoxA(cpointer hDlg, byte* lpPathSpec, int nIDComboBox, int nIDStaticPath, uint uFiletype);
    [DllImport("user32", EntryPoint="DlgDirListComboBoxW", SetLastError=true, ExactSpelling=true)] public static extern
        int DlgDirListComboBox(cpointer hDlg, string lpPathSpec, int nIDComboBox, int nIDStaticPath, uint uFiletype);
    [DllImport("user32", EntryPoint="DlgDirListComboBoxW", SetLastError=true, ExactSpelling=true)] public static extern
        int DlgDirListComboBox(cpointer hDlg, char* lpPathSpec, int nIDComboBox, int nIDStaticPath, uint uFiletype);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DlgDirListComboBoxW(cpointer hDlg, string lpPathSpec, int nIDComboBox, int nIDStaticPath, uint uFiletype);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DlgDirListComboBoxW(cpointer hDlg, char* lpPathSpec, int nIDComboBox, int nIDStaticPath, uint uFiletype);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DlgDirSelectComboBoxExA(cpointer hwndDlg, [MarshalAs(UnmanagedType.LPStr)] string lpString, int cchOut, int idComboBox);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DlgDirSelectComboBoxExA(cpointer hwndDlg, ReadOnlySpan<byte> lpString, int cchOut, int idComboBox);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DlgDirSelectComboBoxExA(cpointer hwndDlg, byte* lpString, int cchOut, int idComboBox);
    [DllImport("user32", EntryPoint="DlgDirSelectComboBoxExW", SetLastError=true, ExactSpelling=true)] public static extern
        int DlgDirSelectComboBoxEx(cpointer hwndDlg, string lpString, int cchOut, int idComboBox);
    [DllImport("user32", EntryPoint="DlgDirSelectComboBoxExW", SetLastError=true, ExactSpelling=true)] public static extern
        int DlgDirSelectComboBoxEx(cpointer hwndDlg, char* lpString, int cchOut, int idComboBox);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DlgDirSelectComboBoxExW(cpointer hwndDlg, string lpString, int cchOut, int idComboBox);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DlgDirSelectComboBoxExW(cpointer hwndDlg, char* lpString, int cchOut, int idComboBox);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetScrollInfo(cpointer hwnd, int nBar, cpointer unfoundType_LPCSCROLLINFO_lpsi, int redraw);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetScrollInfo(cpointer hwnd, int nBar, cpointer unfoundType_LPSCROLLINFO_lpsi);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        long DefFrameProcA(cpointer hWnd, cpointer hWndMDIClient, uint uMsg, ulong wParam, long lParam);
    [DllImport("user32", EntryPoint="DefFrameProcW", SetLastError=true, ExactSpelling=true)] public static extern
        long DefFrameProc(cpointer hWnd, cpointer hWndMDIClient, uint uMsg, ulong wParam, long lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        long DefFrameProcW(cpointer hWnd, cpointer hWndMDIClient, uint uMsg, ulong wParam, long lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer DefMDIChildProcA(cpointer hWnd, uint uMsg, ulong wParam, long lParam);
    [DllImport("user32", EntryPoint="DefMDIChildProcW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer DefMDIChildProc(cpointer hWnd, uint uMsg, ulong wParam, long lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer DefMDIChildProcW(cpointer hWnd, uint uMsg, ulong wParam, long lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int TranslateMDISysAccel(cpointer hWndClient, cpointer unfoundType_LPMSG_lpMsg);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint ArrangeIconicWindows(cpointer hWnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateMDIWindowA(cpointer unfoundType_LPCSTR_lpClassName, cpointer unfoundType_LPCSTR_lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, cpointer hWndParent, cpointer unfoundType_HINSTANCE_hInstance, long lParam);
    [DllImport("user32", EntryPoint="CreateMDIWindowW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateMDIWindow([MarshalAs(UnmanagedType.LPWStr)] string lpClassName, [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, cpointer hWndParent, cpointer unfoundType_HINSTANCE_hInstance, long lParam);
    [DllImport("user32", EntryPoint="CreateMDIWindowW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateMDIWindow([MarshalAs(UnmanagedType.LPWStr)] string lpClassName, char* lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, cpointer hWndParent, cpointer unfoundType_HINSTANCE_hInstance, long lParam);
    [DllImport("user32", EntryPoint="CreateMDIWindowW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateMDIWindow(char* lpClassName, [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, cpointer hWndParent, cpointer unfoundType_HINSTANCE_hInstance, long lParam);
    [DllImport("user32", EntryPoint="CreateMDIWindowW", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateMDIWindow(char* lpClassName, char* lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, cpointer hWndParent, cpointer unfoundType_HINSTANCE_hInstance, long lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateMDIWindowW([MarshalAs(UnmanagedType.LPWStr)] string lpClassName, [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, cpointer hWndParent, cpointer unfoundType_HINSTANCE_hInstance, long lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateMDIWindowW([MarshalAs(UnmanagedType.LPWStr)] string lpClassName, char* lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, cpointer hWndParent, cpointer unfoundType_HINSTANCE_hInstance, long lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateMDIWindowW(char* lpClassName, [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, cpointer hWndParent, cpointer unfoundType_HINSTANCE_hInstance, long lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer CreateMDIWindowW(char* lpClassName, char* lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, cpointer hWndParent, cpointer unfoundType_HINSTANCE_hInstance, long lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        short TileWindows(cpointer hwndParent, uint wHow, cpointer unfoundType_RECT_lpRect, uint cKids, cpointer lpKids);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int WinHelpA(cpointer hWndMain, cpointer unfoundType_LPCSTR_lpszHelp, uint uCommand, cpointer unfoundType_ULONG_PTR_dwData);
    [DllImport("user32", EntryPoint="WinHelpW", SetLastError=true, ExactSpelling=true)] public static extern
        int WinHelp(cpointer hWndMain, [MarshalAs(UnmanagedType.LPWStr)] string lpszHelp, uint uCommand, cpointer unfoundType_ULONG_PTR_dwData);
    [DllImport("user32", EntryPoint="WinHelpW", SetLastError=true, ExactSpelling=true)] public static extern
        int WinHelp(cpointer hWndMain, char* lpszHelp, uint uCommand, cpointer unfoundType_ULONG_PTR_dwData);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int WinHelpW(cpointer hWndMain, [MarshalAs(UnmanagedType.LPWStr)] string lpszHelp, uint uCommand, cpointer unfoundType_ULONG_PTR_dwData);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int WinHelpW(cpointer hWndMain, char* lpszHelp, uint uCommand, cpointer unfoundType_ULONG_PTR_dwData);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetGuiResources(cpointer hProcess, int uiFlags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ChangeDisplaySettingsA(cpointer unfoundType_DEVMODEA_lpDevMode, int dwFlags);
    [DllImport("user32", EntryPoint="ChangeDisplaySettingsW", SetLastError=true, ExactSpelling=true)] public static extern
        int ChangeDisplaySettings(cpointer unfoundType_DEVMODEW_lpDevMode, int dwFlags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ChangeDisplaySettingsW(cpointer unfoundType_DEVMODEW_lpDevMode, int dwFlags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ChangeDisplaySettingsExA(cpointer unfoundType_LPCSTR_lpszDeviceName, cpointer unfoundType_DEVMODEA_lpDevMode, cpointer hwnd, int dwflags, cpointer lParam);
    [DllImport("user32", EntryPoint="ChangeDisplaySettingsExW", SetLastError=true, ExactSpelling=true)] public static extern
        int ChangeDisplaySettingsEx([MarshalAs(UnmanagedType.LPWStr)] string lpszDeviceName, cpointer unfoundType_DEVMODEW_lpDevMode, cpointer hwnd, int dwflags, cpointer lParam);
    [DllImport("user32", EntryPoint="ChangeDisplaySettingsExW", SetLastError=true, ExactSpelling=true)] public static extern
        int ChangeDisplaySettingsEx(char* lpszDeviceName, cpointer unfoundType_DEVMODEW_lpDevMode, cpointer hwnd, int dwflags, cpointer lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ChangeDisplaySettingsExW([MarshalAs(UnmanagedType.LPWStr)] string lpszDeviceName, cpointer unfoundType_DEVMODEW_lpDevMode, cpointer hwnd, int dwflags, cpointer lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ChangeDisplaySettingsExW(char* lpszDeviceName, cpointer unfoundType_DEVMODEW_lpDevMode, cpointer hwnd, int dwflags, cpointer lParam);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumDisplaySettingsA(cpointer unfoundType_LPCSTR_lpszDeviceName, int iModeNum, cpointer unfoundType_DEVMODEA_lpDevMode);
    [DllImport("user32", EntryPoint="EnumDisplaySettingsW", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumDisplaySettings([MarshalAs(UnmanagedType.LPWStr)] string lpszDeviceName, int iModeNum, cpointer unfoundType_DEVMODEW_lpDevMode);
    [DllImport("user32", EntryPoint="EnumDisplaySettingsW", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumDisplaySettings(char* lpszDeviceName, int iModeNum, cpointer unfoundType_DEVMODEW_lpDevMode);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumDisplaySettingsW([MarshalAs(UnmanagedType.LPWStr)] string lpszDeviceName, int iModeNum, cpointer unfoundType_DEVMODEW_lpDevMode);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumDisplaySettingsW(char* lpszDeviceName, int iModeNum, cpointer unfoundType_DEVMODEW_lpDevMode);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumDisplaySettingsExA(cpointer unfoundType_LPCSTR_lpszDeviceName, int iModeNum, cpointer unfoundType_DEVMODEA_lpDevMode, int dwFlags);
    [DllImport("user32", EntryPoint="EnumDisplaySettingsExW", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumDisplaySettingsEx([MarshalAs(UnmanagedType.LPWStr)] string lpszDeviceName, int iModeNum, cpointer unfoundType_DEVMODEW_lpDevMode, int dwFlags);
    [DllImport("user32", EntryPoint="EnumDisplaySettingsExW", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumDisplaySettingsEx(char* lpszDeviceName, int iModeNum, cpointer unfoundType_DEVMODEW_lpDevMode, int dwFlags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumDisplaySettingsExW([MarshalAs(UnmanagedType.LPWStr)] string lpszDeviceName, int iModeNum, cpointer unfoundType_DEVMODEW_lpDevMode, int dwFlags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumDisplaySettingsExW(char* lpszDeviceName, int iModeNum, cpointer unfoundType_DEVMODEW_lpDevMode, int dwFlags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumDisplayDevicesA(cpointer unfoundType_LPCSTR_lpDevice, int iDevNum, cpointer unfoundType_PDISPLAY_DEVICEA_lpDisplayDevice, int dwFlags);
    [DllImport("user32", EntryPoint="EnumDisplayDevicesW", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumDisplayDevices([MarshalAs(UnmanagedType.LPWStr)] string lpDevice, int iDevNum, cpointer unfoundType_PDISPLAY_DEVICEW_lpDisplayDevice, int dwFlags);
    [DllImport("user32", EntryPoint="EnumDisplayDevicesW", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumDisplayDevices(char* lpDevice, int iDevNum, cpointer unfoundType_PDISPLAY_DEVICEW_lpDisplayDevice, int dwFlags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumDisplayDevicesW([MarshalAs(UnmanagedType.LPWStr)] string lpDevice, int iDevNum, cpointer unfoundType_PDISPLAY_DEVICEW_lpDisplayDevice, int dwFlags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumDisplayDevicesW(char* lpDevice, int iDevNum, cpointer unfoundType_PDISPLAY_DEVICEW_lpDisplayDevice, int dwFlags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDisplayConfigBufferSizes(uint flags, cpointer numPathArrayElements, cpointer numModeInfoArrayElements);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetDisplayConfig(uint numPathArrayElements, cpointer unfoundType_DISPLAYCONFIG_PATH_INFO_pathArray, uint numModeInfoArrayElements, cpointer unfoundType_DISPLAYCONFIG_MODE_INFO_modeInfoArray, uint flags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int QueryDisplayConfig(uint flags, cpointer numPathArrayElements, cpointer unfoundType_DISPLAYCONFIG_PATH_INFO_pathArray, cpointer numModeInfoArrayElements, cpointer unfoundType_DISPLAYCONFIG_MODE_INFO_modeInfoArray, cpointer unfoundType_DISPLAYCONFIG_TOPOLOGY_ID_currentTopologyId);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DisplayConfigGetDeviceInfo(cpointer unfoundType_DISPLAYCONFIG_DEVICE_INFO_HEADER_requestPacket);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int DisplayConfigSetDeviceInfo(cpointer unfoundType_DISPLAYCONFIG_DEVICE_INFO_HEADER_setPacket);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SystemParametersInfoA(uint uiAction, uint uiParam, cpointer pvParam, uint fWinIni);
    [DllImport("user32", EntryPoint="SystemParametersInfoW", SetLastError=true, ExactSpelling=true)] public static extern
        int SystemParametersInfo(uint uiAction, uint uiParam, cpointer pvParam, uint fWinIni);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SystemParametersInfoW(uint uiAction, uint uiParam, cpointer pvParam, uint fWinIni);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SystemParametersInfoForDpi(uint uiAction, uint uiParam, cpointer pvParam, uint fWinIni, uint dpi);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SoundSentry();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        void SetDebugErrorLevel(int dwLevel);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        void SetLastErrorEx(int dwErrCode, int dwType);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int InternalGetWindowText(cpointer hWnd, string pString, int cchMaxCount);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int InternalGetWindowText(cpointer hWnd, char* pString, int cchMaxCount);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int EndTask(cpointer hWnd, int fShutDown, int fForce);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CancelShutdown();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer MonitorFromPoint(cpointer unfoundType_POINT_pt, int dwFlags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer MonitorFromRect(cpointer unfoundType_LPCRECT_lprc, int dwFlags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer MonitorFromWindow(cpointer hwnd, int dwFlags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetMonitorInfoA(cpointer hMonitor, cpointer unfoundType_LPMONITORINFO_lpmi);
    [DllImport("user32", EntryPoint="GetMonitorInfoW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetMonitorInfo(cpointer hMonitor, cpointer unfoundType_LPMONITORINFO_lpmi);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetMonitorInfoW(cpointer hMonitor, cpointer unfoundType_LPMONITORINFO_lpmi);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnumDisplayMonitors(cpointer hdc, cpointer unfoundType_LPCRECT_lprcClip, cpointer unfoundType_MONITORENUMPROC_lpfnEnum, long dwData);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        void NotifyWinEvent(int argEvent, cpointer hwnd, int idObject, int idChild);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer SetWinEventHook(int eventMin, int eventMax, cpointer unfoundType_HMODULE_hmodWinEventProc, cpointer unfoundType_WINEVENTPROC_pfnWinEventProc, int idProcess, int idThread, int dwFlags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsWinEventHookInstalled(int argEvent);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int UnhookWinEvent(cpointer unfoundType_HWINEVENTHOOK_hWinEventHook);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetGUIThreadInfo(int idThread, cpointer unfoundType_PGUITHREADINFO_pgui);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int BlockInput(int fBlockIt);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetProcessDPIAware();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsProcessDPIAware();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer SetThreadDpiAwarenessContext(cpointer unfoundType_DPI_AWARENESS_CONTEXT_dpiContext);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetThreadDpiAwarenessContext();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetWindowDpiAwarenessContext(cpointer hwnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetAwarenessFromDpiAwarenessContext(cpointer unfoundType_DPI_AWARENESS_CONTEXT_value);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetDpiFromDpiAwarenessContext(cpointer unfoundType_DPI_AWARENESS_CONTEXT_value);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int AreDpiAwarenessContextsEqual(cpointer unfoundType_DPI_AWARENESS_CONTEXT_dpiContextA, cpointer unfoundType_DPI_AWARENESS_CONTEXT_dpiContextB);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsValidDpiAwarenessContext(cpointer unfoundType_DPI_AWARENESS_CONTEXT_value);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetDpiForWindow(cpointer hwnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetDpiForSystem();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetSystemDpiForProcess(cpointer hProcess);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int EnableNonClientDpiScaling(cpointer hwnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int InheritWindowMonitor(cpointer hwnd, cpointer hwndInherit);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetProcessDpiAwarenessContext(cpointer unfoundType_DPI_AWARENESS_CONTEXT_value);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetDpiAwarenessContextForProcess(cpointer hProcess);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer SetThreadDpiHostingBehavior(cpointer unfoundType_DPI_HOSTING_BEHAVIOR_value);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetThreadDpiHostingBehavior();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetWindowDpiHostingBehavior(cpointer hwnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetWindowModuleFileNameA(cpointer hwnd, [MarshalAs(UnmanagedType.LPStr)] string pszFileName, uint cchFileNameMax);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetWindowModuleFileNameA(cpointer hwnd, ReadOnlySpan<byte> pszFileName, uint cchFileNameMax);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetWindowModuleFileNameA(cpointer hwnd, byte* pszFileName, uint cchFileNameMax);
    [DllImport("user32", EntryPoint="GetWindowModuleFileNameW", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetWindowModuleFileName(cpointer hwnd, string pszFileName, uint cchFileNameMax);
    [DllImport("user32", EntryPoint="GetWindowModuleFileNameW", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetWindowModuleFileName(cpointer hwnd, char* pszFileName, uint cchFileNameMax);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetWindowModuleFileNameW(cpointer hwnd, string pszFileName, uint cchFileNameMax);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetWindowModuleFileNameW(cpointer hwnd, char* pszFileName, uint cchFileNameMax);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCursorInfo(cpointer unfoundType_PCURSORINFO_pci);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetWindowInfo(cpointer hwnd, cpointer unfoundType_PWINDOWINFO_pwi);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetTitleBarInfo(cpointer hwnd, cpointer unfoundType_PTITLEBARINFO_pti);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetMenuBarInfo(cpointer hwnd, int idObject, int idItem, cpointer unfoundType_PMENUBARINFO_pmbi);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetScrollBarInfo(cpointer hwnd, int idObject, cpointer unfoundType_PSCROLLBARINFO_psbi);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetComboBoxInfo(cpointer hwndCombo, cpointer unfoundType_PCOMBOBOXINFO_pcbi);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer GetAncestor(cpointer hwnd, uint gaFlags);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        cpointer RealChildWindowFromPoint(cpointer hwndParent, cpointer unfoundType_POINT_ptParentClientCoords);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint RealGetWindowClassA(cpointer hwnd, [MarshalAs(UnmanagedType.LPStr)] string ptszClassName, uint cchClassNameMax);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint RealGetWindowClassA(cpointer hwnd, ReadOnlySpan<byte> ptszClassName, uint cchClassNameMax);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint RealGetWindowClassA(cpointer hwnd, byte* ptszClassName, uint cchClassNameMax);
    [DllImport("user32", EntryPoint="RealGetWindowClassW", SetLastError=true, ExactSpelling=true)] public static extern
        uint RealGetWindowClass(cpointer hwnd, string ptszClassName, uint cchClassNameMax);
    [DllImport("user32", EntryPoint="RealGetWindowClassW", SetLastError=true, ExactSpelling=true)] public static extern
        uint RealGetWindowClass(cpointer hwnd, char* ptszClassName, uint cchClassNameMax);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint RealGetWindowClassW(cpointer hwnd, string ptszClassName, uint cchClassNameMax);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint RealGetWindowClassW(cpointer hwnd, char* ptszClassName, uint cchClassNameMax);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetAltTabInfoA(cpointer hwnd, int iItem, cpointer unfoundType_PALTTABINFO_pati, [MarshalAs(UnmanagedType.LPStr)] string pszItemText, uint cchItemText);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetAltTabInfoA(cpointer hwnd, int iItem, cpointer unfoundType_PALTTABINFO_pati, ReadOnlySpan<byte> pszItemText, uint cchItemText);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetAltTabInfoA(cpointer hwnd, int iItem, cpointer unfoundType_PALTTABINFO_pati, byte* pszItemText, uint cchItemText);
    [DllImport("user32", EntryPoint="GetAltTabInfoW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetAltTabInfo(cpointer hwnd, int iItem, cpointer unfoundType_PALTTABINFO_pati, string pszItemText, uint cchItemText);
    [DllImport("user32", EntryPoint="GetAltTabInfoW", SetLastError=true, ExactSpelling=true)] public static extern
        int GetAltTabInfo(cpointer hwnd, int iItem, cpointer unfoundType_PALTTABINFO_pati, char* pszItemText, uint cchItemText);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetAltTabInfoW(cpointer hwnd, int iItem, cpointer unfoundType_PALTTABINFO_pati, string pszItemText, uint cchItemText);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetAltTabInfoW(cpointer hwnd, int iItem, cpointer unfoundType_PALTTABINFO_pati, char* pszItemText, uint cchItemText);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetListBoxInfo(cpointer hwnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int LockWorkStation();
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int UserHandleGrantAccess(cpointer hUserHandle, cpointer hJob, int bGrant);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetRawInputData(cpointer unfoundType_HRAWINPUT_hRawInput, uint uiCommand, cpointer pData, cpointer unfoundType_PUINT_pcbSize, uint cbSizeHeader);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetRawInputDeviceInfoA(cpointer hDevice, uint uiCommand, cpointer pData, cpointer unfoundType_PUINT_pcbSize);
    [DllImport("user32", EntryPoint="GetRawInputDeviceInfoW", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetRawInputDeviceInfo(cpointer hDevice, uint uiCommand, cpointer pData, cpointer unfoundType_PUINT_pcbSize);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetRawInputDeviceInfoW(cpointer hDevice, uint uiCommand, cpointer pData, cpointer unfoundType_PUINT_pcbSize);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetRawInputBuffer(cpointer unfoundType_PRAWINPUT_pData, cpointer unfoundType_PUINT_pcbSize, uint cbSizeHeader);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int RegisterRawInputDevices(cpointer unfoundType_PCRAWINPUTDEVICE_pRawInputDevices, uint uiNumDevices, uint cbSize);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetRegisteredRawInputDevices(cpointer unfoundType_PRAWINPUTDEVICE_pRawInputDevices, cpointer unfoundType_PUINT_puiNumDevices, uint cbSize);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        uint GetRawInputDeviceList(cpointer unfoundType_PRAWINPUTDEVICELIST_pRawInputDeviceList, cpointer unfoundType_PUINT_puiNumDevices, uint cbSize);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        long DefRawInputProc(cpointer unfoundType_PRAWINPUT_paRawInput, int nInput, uint cbSizeHeader);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPointerDevices(cpointer deviceCount, cpointer unfoundType_POINTER_DEVICE_INFOpointerDevicespointerDevices_unnamed_1);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPointerDevice(cpointer device, cpointer unfoundType_POINTER_DEVICE_INFOpointerDevicepointerDevice_unnamed_1);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPointerDeviceProperties(cpointer device, cpointer propertyCount, cpointer unfoundType_POINTER_DEVICE_PROPERTYpointerPropertiespointerProperties_unnamed_2);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int RegisterPointerDeviceNotifications(cpointer window, int notifyRange);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPointerDeviceRects(cpointer device, cpointer unfoundType_RECT_pointerDeviceRect, cpointer unfoundType_RECT_displayRect);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetPointerDeviceCursors(cpointer device, cpointer cursorCount, cpointer unfoundType_POINTER_DEVICE_CURSOR_INFOdeviceCursorsdeviceCursors_unnamed_2);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetRawPointerDeviceData(uint pointerId, uint historyCount, uint propertiesCount, cpointer unfoundType_POINTER_DEVICE_PROPERTY_pProperties, cpointer pValues);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ChangeWindowMessageFilter(uint message, int dwFlag);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ChangeWindowMessageFilterEx(cpointer hwnd, uint message, int action, cpointer unfoundType_PCHANGEFILTERSTRUCT_pChangeFilterStruct);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetGestureInfo(cpointer unfoundType_HGESTUREINFO_hGestureInfo, cpointer unfoundType_PGESTUREINFO_pGestureInfo);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetGestureExtraArgs(cpointer unfoundType_HGESTUREINFO_hGestureInfo, uint cbExtraArgs, cpointer unfoundType_PBYTE_pExtraArgs);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int CloseGestureInfoHandle(cpointer unfoundType_HGESTUREINFO_hGestureInfo);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetGestureConfig(cpointer hwnd, int dwReserved, uint cIDs, cpointer unfoundType_PGESTURECONFIG_pGestureConfig, uint cbSize);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetGestureConfig(cpointer hwnd, int dwReserved, int dwFlags, cpointer unfoundType_PUINT_pcIDs, cpointer unfoundType_PGESTURECONFIG_pGestureConfig, uint cbSize);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ShutdownBlockReasonCreate(cpointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string pwszReason);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ShutdownBlockReasonCreate(cpointer hWnd, char* pwszReason);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ShutdownBlockReasonQuery(cpointer hWnd, string pwszBuff, cpointer unfoundType_DWORDpcchBuffpcchBuff_unnamed_2);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ShutdownBlockReasonQuery(cpointer hWnd, char* pwszBuff, cpointer unfoundType_DWORDpcchBuffpcchBuff_unnamed_2);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int ShutdownBlockReasonDestroy(cpointer hWnd);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCurrentInputMessageSource(cpointer unfoundType_INPUT_MESSAGE_SOURCEinputMessageSourceinputMessageSource_unnamed_0);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetCIMSSM(cpointer unfoundType_INPUT_MESSAGE_SOURCEinputMessageSourceinputMessageSource_unnamed_0);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetAutoRotationState(cpointer unfoundType_PAR_STATE_pState);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int GetDisplayAutoRotationPreferences(cpointer unfoundType_ORIENTATION_PREFERENCEpOrientationpOrientation_unnamed_0);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetDisplayAutoRotationPreferences(cpointer unfoundType_ORIENTATION_PREFERENCE_orientation);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int IsImmersiveProcess(cpointer hProcess);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetProcessRestrictionExemption(int fEnableExemption);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int SetAdditionalForegroundBoostProcesses(cpointer topLevelWindow, int processHandleCount, cpointer unfoundType_HANDLEprocessHandleArrayprocessHandleArray_unnamed_2);
    [DllImport("user32", SetLastError=true, ExactSpelling=true)] public static extern
        int RegisterForTooltipDismissNotification(cpointer hWnd, cpointer unfoundType_TOOLTIP_DISMISS_FLAGS_tdFlags);
}