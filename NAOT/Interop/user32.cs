using System.Runtime.InteropServices;

public unsafe class user32
{
    const string lib = "user32";
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int LoadStringA(cpointer unfoundType_HINSTANCE_hInstance, uint uID, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, int cchBufferMax);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int LoadStringA(cpointer unfoundType_HINSTANCE_hInstance, uint uID, ReadOnlySpan<byte> lpBuffer, int cchBufferMax);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int LoadStringA(cpointer unfoundType_HINSTANCE_hInstance, uint uID, byte* lpBuffer, int cchBufferMax);
    [DllImport(lib,EntryPoint="LoadStringW",SetLastError=true,ExactSpelling=true)]public static extern
        int LoadString(cpointer unfoundType_HINSTANCE_hInstance, uint uID, string lpBuffer, int cchBufferMax);
    [DllImport(lib,EntryPoint="LoadStringW",SetLastError=true,ExactSpelling=true)]public static extern
        int LoadString(cpointer unfoundType_HINSTANCE_hInstance, uint uID, char* lpBuffer, int cchBufferMax);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int LoadStringW(cpointer unfoundType_HINSTANCE_hInstance, uint uID, string lpBuffer, int cchBufferMax);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int LoadStringW(cpointer unfoundType_HINSTANCE_hInstance, uint uID, char* lpBuffer, int cchBufferMax);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DdeSetQualityOfService(cpointer hwndClient, cpointer unfoundType_SECURITY_QUALITY_OF_SERVICEpqosNewpqosNew_unnamed_1, cpointer unfoundType_PSECURITY_QUALITY_OF_SERVICE_pqosPrev);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool ImpersonateDdeClientWindow(cpointer hWndClient, cpointer hWndServer);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint DdeInitializeA(cpointer unfoundType_LPDWORD_pidInst, cpointer unfoundType_PFNCALLBACK_pfnCallback, int afCmd, int ulRes);
    [DllImport(lib,EntryPoint="DdeInitializeW",SetLastError=true,ExactSpelling=true)]public static extern
        uint DdeInitialize(cpointer unfoundType_LPDWORD_pidInst, cpointer unfoundType_PFNCALLBACK_pfnCallback, int afCmd, int ulRes);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint DdeInitializeW(cpointer unfoundType_LPDWORD_pidInst, cpointer unfoundType_PFNCALLBACK_pfnCallback, int afCmd, int ulRes);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DdeUninitialize(int idInst);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer DdeConnectList(int idInst, cpointer unfoundType_HSZ_hszService, cpointer unfoundType_HSZ_hszTopic, cpointer unfoundType_HCONVLIST_hConvList, cpointer unfoundType_PCONVCONTEXT_pCC);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer DdeQueryNextServer(cpointer unfoundType_HCONVLIST_hConvList, cpointer unfoundType_HCONV_hConvPrev);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DdeDisconnectList(cpointer unfoundType_HCONVLIST_hConvList);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer DdeConnect(int idInst, cpointer unfoundType_HSZ_hszService, cpointer unfoundType_HSZ_hszTopic, cpointer unfoundType_PCONVCONTEXT_pCC);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DdeDisconnect(cpointer unfoundType_HCONV_hConv);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer DdeReconnect(cpointer unfoundType_HCONV_hConv);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint DdeQueryConvInfo(cpointer unfoundType_HCONV_hConv, int idTransaction, cpointer unfoundType_PCONVINFO_pConvInfo);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DdeSetUserHandle(cpointer unfoundType_HCONV_hConv, int id, cpointer unfoundType_DWORD_PTR_hUser);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DdeAbandonTransaction(int idInst, cpointer unfoundType_HCONV_hConv, int idTransaction);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DdePostAdvise(int idInst, cpointer unfoundType_HSZ_hszTopic, cpointer unfoundType_HSZ_hszItem);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DdeEnableCallback(int idInst, cpointer unfoundType_HCONV_hConv, uint wCmd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DdeImpersonateClient(cpointer unfoundType_HCONV_hConv);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer DdeNameService(int idInst, cpointer unfoundType_HSZ_hsz1, cpointer unfoundType_HSZ_hsz2, uint afCmd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer DdeClientTransaction(cpointer unfoundType_LPBYTE_pData, int cbData, cpointer unfoundType_HCONV_hConv, cpointer unfoundType_HSZ_hszItem, uint wFmt, uint wType, int dwTimeout, cpointer unfoundType_LPDWORD_pdwResult);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer DdeCreateDataHandle(int idInst, cpointer unfoundType_LPBYTE_pSrc, int cb, int cbOff, cpointer unfoundType_HSZ_hszItem, uint wFmt, uint afCmd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer DdeAddData(cpointer unfoundType_HDDEDATA_hData, cpointer unfoundType_LPBYTE_pSrc, int cb, int cbOff);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int DdeGetData(cpointer unfoundType_HDDEDATA_hData, cpointer unfoundType_LPBYTE_pDst, int cbMax, int cbOff);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer DdeAccessData(cpointer unfoundType_HDDEDATA_hData, cpointer unfoundType_LPDWORD_pcbDataSize);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DdeUnaccessData(cpointer unfoundType_HDDEDATA_hData);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DdeFreeDataHandle(cpointer unfoundType_HDDEDATA_hData);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint DdeGetLastError(int idInst);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer DdeCreateStringHandleA(int idInst, [MarshalAs(UnmanagedType.LPStr)] string psz, int iCodePage);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer DdeCreateStringHandleA(int idInst, byte* psz, int iCodePage);
    [DllImport(lib,EntryPoint="DdeCreateStringHandleW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer DdeCreateStringHandle(int idInst, [MarshalAs(UnmanagedType.LPWStr)] string psz, int iCodePage);
    [DllImport(lib,EntryPoint="DdeCreateStringHandleW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer DdeCreateStringHandle(int idInst, char* psz, int iCodePage);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer DdeCreateStringHandleW(int idInst, [MarshalAs(UnmanagedType.LPWStr)] string psz, int iCodePage);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer DdeCreateStringHandleW(int idInst, char* psz, int iCodePage);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int DdeQueryStringA(int idInst, cpointer unfoundType_HSZ_hsz, [MarshalAs(UnmanagedType.LPStr)] string psz, int cchMax, int iCodePage);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int DdeQueryStringA(int idInst, cpointer unfoundType_HSZ_hsz, ReadOnlySpan<byte> psz, int cchMax, int iCodePage);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int DdeQueryStringA(int idInst, cpointer unfoundType_HSZ_hsz, byte* psz, int cchMax, int iCodePage);
    [DllImport(lib,EntryPoint="DdeQueryStringW",SetLastError=true,ExactSpelling=true)]public static extern
        int DdeQueryString(int idInst, cpointer unfoundType_HSZ_hsz, string psz, int cchMax, int iCodePage);
    [DllImport(lib,EntryPoint="DdeQueryStringW",SetLastError=true,ExactSpelling=true)]public static extern
        int DdeQueryString(int idInst, cpointer unfoundType_HSZ_hsz, char* psz, int cchMax, int iCodePage);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int DdeQueryStringW(int idInst, cpointer unfoundType_HSZ_hsz, string psz, int cchMax, int iCodePage);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int DdeQueryStringW(int idInst, cpointer unfoundType_HSZ_hsz, char* psz, int cchMax, int iCodePage);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DdeFreeStringHandle(int idInst, cpointer unfoundType_HSZ_hsz);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DdeKeepStringHandle(int idInst, cpointer unfoundType_HSZ_hsz);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int DdeCmpStringHandles(cpointer unfoundType_HSZ_hsz1, cpointer unfoundType_HSZ_hsz2);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int wvsprintfA([MarshalAs(UnmanagedType.LPStr)] string unnamed_0, [MarshalAs(UnmanagedType.LPStr)] string unnamed_1, cpointer arglist);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int wvsprintfA([MarshalAs(UnmanagedType.LPStr)] string unnamed_0, byte* unnamed_1, cpointer arglist);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int wvsprintfA(ReadOnlySpan<byte> unnamed_0, [MarshalAs(UnmanagedType.LPStr)] string unnamed_1, cpointer arglist);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int wvsprintfA(ReadOnlySpan<byte> unnamed_0, byte* unnamed_1, cpointer arglist);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int wvsprintfA(byte* unnamed_0, [MarshalAs(UnmanagedType.LPStr)] string unnamed_1, cpointer arglist);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int wvsprintfA(byte* unnamed_0, byte* unnamed_1, cpointer arglist);
    [DllImport(lib,EntryPoint="wvsprintfW",SetLastError=true,ExactSpelling=true)]public static extern
        int wvsprintf(string unnamed_0, [MarshalAs(UnmanagedType.LPWStr)] string unnamed_1, cpointer arglist);
    [DllImport(lib,EntryPoint="wvsprintfW",SetLastError=true,ExactSpelling=true)]public static extern
        int wvsprintf(string unnamed_0, char* unnamed_1, cpointer arglist);
    [DllImport(lib,EntryPoint="wvsprintfW",SetLastError=true,ExactSpelling=true)]public static extern
        int wvsprintf(char* unnamed_0, [MarshalAs(UnmanagedType.LPWStr)] string unnamed_1, cpointer arglist);
    [DllImport(lib,EntryPoint="wvsprintfW",SetLastError=true,ExactSpelling=true)]public static extern
        int wvsprintf(char* unnamed_0, char* unnamed_1, cpointer arglist);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int wvsprintfW(string unnamed_0, [MarshalAs(UnmanagedType.LPWStr)] string unnamed_1, cpointer arglist);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int wvsprintfW(string unnamed_0, char* unnamed_1, cpointer arglist);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int wvsprintfW(char* unnamed_0, [MarshalAs(UnmanagedType.LPWStr)] string unnamed_1, cpointer arglist);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int wvsprintfW(char* unnamed_0, char* unnamed_1, cpointer arglist);
    [DllImport(lib,SetLastError=true,ExactSpelling=true,CallingConvention=CallingConvention.Cdecl)]public static extern
        int wsprintfA([MarshalAs(UnmanagedType.LPStr)] string unnamed_0, [MarshalAs(UnmanagedType.LPStr)] string unnamed_1, cpointer unnamed_2);
    [DllImport(lib,SetLastError=true,ExactSpelling=true,CallingConvention=CallingConvention.Cdecl)]public static extern
        int wsprintfA([MarshalAs(UnmanagedType.LPStr)] string unnamed_0, byte* unnamed_1, cpointer unnamed_2);
    [DllImport(lib,SetLastError=true,ExactSpelling=true,CallingConvention=CallingConvention.Cdecl)]public static extern
        int wsprintfA(ReadOnlySpan<byte> unnamed_0, [MarshalAs(UnmanagedType.LPStr)] string unnamed_1, cpointer unnamed_2);
    [DllImport(lib,SetLastError=true,ExactSpelling=true,CallingConvention=CallingConvention.Cdecl)]public static extern
        int wsprintfA(ReadOnlySpan<byte> unnamed_0, byte* unnamed_1, cpointer unnamed_2);
    [DllImport(lib,SetLastError=true,ExactSpelling=true,CallingConvention=CallingConvention.Cdecl)]public static extern
        int wsprintfA(byte* unnamed_0, [MarshalAs(UnmanagedType.LPStr)] string unnamed_1, cpointer unnamed_2);
    [DllImport(lib,SetLastError=true,ExactSpelling=true,CallingConvention=CallingConvention.Cdecl)]public static extern
        int wsprintfA(byte* unnamed_0, byte* unnamed_1, cpointer unnamed_2);
    [DllImport(lib,EntryPoint="wsprintfW",SetLastError=true,ExactSpelling=true,CallingConvention=CallingConvention.Cdecl)]public static extern
        int wsprintf(string unnamed_0, [MarshalAs(UnmanagedType.LPWStr)] string unnamed_1, cpointer unnamed_2);
    [DllImport(lib,EntryPoint="wsprintfW",SetLastError=true,ExactSpelling=true,CallingConvention=CallingConvention.Cdecl)]public static extern
        int wsprintf(string unnamed_0, char* unnamed_1, cpointer unnamed_2);
    [DllImport(lib,EntryPoint="wsprintfW",SetLastError=true,ExactSpelling=true,CallingConvention=CallingConvention.Cdecl)]public static extern
        int wsprintf(char* unnamed_0, [MarshalAs(UnmanagedType.LPWStr)] string unnamed_1, cpointer unnamed_2);
    [DllImport(lib,EntryPoint="wsprintfW",SetLastError=true,ExactSpelling=true,CallingConvention=CallingConvention.Cdecl)]public static extern
        int wsprintf(char* unnamed_0, char* unnamed_1, cpointer unnamed_2);
    [DllImport(lib,SetLastError=true,ExactSpelling=true,CallingConvention=CallingConvention.Cdecl)]public static extern
        int wsprintfW(string unnamed_0, [MarshalAs(UnmanagedType.LPWStr)] string unnamed_1, cpointer unnamed_2);
    [DllImport(lib,SetLastError=true,ExactSpelling=true,CallingConvention=CallingConvention.Cdecl)]public static extern
        int wsprintfW(string unnamed_0, char* unnamed_1, cpointer unnamed_2);
    [DllImport(lib,SetLastError=true,ExactSpelling=true,CallingConvention=CallingConvention.Cdecl)]public static extern
        int wsprintfW(char* unnamed_0, [MarshalAs(UnmanagedType.LPWStr)] string unnamed_1, cpointer unnamed_2);
    [DllImport(lib,SetLastError=true,ExactSpelling=true,CallingConvention=CallingConvention.Cdecl)]public static extern
        int wsprintfW(char* unnamed_0, char* unnamed_1, cpointer unnamed_2);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadKeyboardLayoutA([MarshalAs(UnmanagedType.LPStr)] string pwszKLID, uint Flags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadKeyboardLayoutA(byte* pwszKLID, uint Flags);
    [DllImport(lib,EntryPoint="LoadKeyboardLayoutW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadKeyboardLayout([MarshalAs(UnmanagedType.LPWStr)] string pwszKLID, uint Flags);
    [DllImport(lib,EntryPoint="LoadKeyboardLayoutW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadKeyboardLayout(char* pwszKLID, uint Flags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadKeyboardLayoutW([MarshalAs(UnmanagedType.LPWStr)] string pwszKLID, uint Flags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadKeyboardLayoutW(char* pwszKLID, uint Flags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer ActivateKeyboardLayout(cpointer unfoundType_HKL_hkl, uint Flags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int ToUnicodeEx(uint wVirtKey, uint wScanCode, cpointer unfoundType_BYTElpKeyStatelpKeyState_unnamed_2, string pwszBuff, int cchBuff, uint wFlags, cpointer unfoundType_HKL_dwhkl);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int ToUnicodeEx(uint wVirtKey, uint wScanCode, cpointer unfoundType_BYTElpKeyStatelpKeyState_unnamed_2, char* pwszBuff, int cchBuff, uint wFlags, cpointer unfoundType_HKL_dwhkl);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool UnloadKeyboardLayout(cpointer unfoundType_HKL_hkl);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetKeyboardLayoutNameA([MarshalAs(UnmanagedType.LPStr)] string pwszKLID);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetKeyboardLayoutNameA(ReadOnlySpan<byte> pwszKLID);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetKeyboardLayoutNameA(byte* pwszKLID);
    [DllImport(lib,EntryPoint="GetKeyboardLayoutNameW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetKeyboardLayoutName(string pwszKLID);
    [DllImport(lib,EntryPoint="GetKeyboardLayoutNameW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetKeyboardLayoutName(char* pwszKLID);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetKeyboardLayoutNameW(string pwszKLID);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetKeyboardLayoutNameW(char* pwszKLID);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetKeyboardLayoutList(int nBuff, cpointer unfoundType_HKLlpListlpList_unnamed_1);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetKeyboardLayout(int idThread);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetMouseMovePointsEx(uint cbSize, cpointer unfoundType_LPMOUSEMOVEPOINT_lppt, cpointer unfoundType_LPMOUSEMOVEPOINT_lpptBuf, int nBufPoints, int resolution);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateDesktopA([MarshalAs(UnmanagedType.LPStr)] string lpszDesktop, [MarshalAs(UnmanagedType.LPStr)] string lpszDevice, cpointer unfoundType_DEVMODEA_pDevmode, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateDesktopA([MarshalAs(UnmanagedType.LPStr)] string lpszDesktop, byte* lpszDevice, cpointer unfoundType_DEVMODEA_pDevmode, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateDesktopA(byte* lpszDesktop, [MarshalAs(UnmanagedType.LPStr)] string lpszDevice, cpointer unfoundType_DEVMODEA_pDevmode, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateDesktopA(byte* lpszDesktop, byte* lpszDevice, cpointer unfoundType_DEVMODEA_pDevmode, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport(lib,EntryPoint="CreateDesktopW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateDesktop([MarshalAs(UnmanagedType.LPWStr)] string lpszDesktop, [MarshalAs(UnmanagedType.LPWStr)] string lpszDevice, cpointer unfoundType_DEVMODEW_pDevmode, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport(lib,EntryPoint="CreateDesktopW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateDesktop([MarshalAs(UnmanagedType.LPWStr)] string lpszDesktop, char* lpszDevice, cpointer unfoundType_DEVMODEW_pDevmode, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport(lib,EntryPoint="CreateDesktopW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateDesktop(char* lpszDesktop, [MarshalAs(UnmanagedType.LPWStr)] string lpszDevice, cpointer unfoundType_DEVMODEW_pDevmode, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport(lib,EntryPoint="CreateDesktopW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateDesktop(char* lpszDesktop, char* lpszDevice, cpointer unfoundType_DEVMODEW_pDevmode, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateDesktopW([MarshalAs(UnmanagedType.LPWStr)] string lpszDesktop, [MarshalAs(UnmanagedType.LPWStr)] string lpszDevice, cpointer unfoundType_DEVMODEW_pDevmode, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateDesktopW([MarshalAs(UnmanagedType.LPWStr)] string lpszDesktop, char* lpszDevice, cpointer unfoundType_DEVMODEW_pDevmode, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateDesktopW(char* lpszDesktop, [MarshalAs(UnmanagedType.LPWStr)] string lpszDevice, cpointer unfoundType_DEVMODEW_pDevmode, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateDesktopW(char* lpszDesktop, char* lpszDevice, cpointer unfoundType_DEVMODEW_pDevmode, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateDesktopExA([MarshalAs(UnmanagedType.LPStr)] string lpszDesktop, [MarshalAs(UnmanagedType.LPStr)] string lpszDevice, cpointer unfoundType_DEVMODEA_pDevmode, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa, uint ulHeapSize, cpointer pvoid);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateDesktopExA([MarshalAs(UnmanagedType.LPStr)] string lpszDesktop, byte* lpszDevice, cpointer unfoundType_DEVMODEA_pDevmode, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa, uint ulHeapSize, cpointer pvoid);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateDesktopExA(byte* lpszDesktop, [MarshalAs(UnmanagedType.LPStr)] string lpszDevice, cpointer unfoundType_DEVMODEA_pDevmode, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa, uint ulHeapSize, cpointer pvoid);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateDesktopExA(byte* lpszDesktop, byte* lpszDevice, cpointer unfoundType_DEVMODEA_pDevmode, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa, uint ulHeapSize, cpointer pvoid);
    [DllImport(lib,EntryPoint="CreateDesktopExW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateDesktopEx([MarshalAs(UnmanagedType.LPWStr)] string lpszDesktop, [MarshalAs(UnmanagedType.LPWStr)] string lpszDevice, cpointer unfoundType_DEVMODEW_pDevmode, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa, uint ulHeapSize, cpointer pvoid);
    [DllImport(lib,EntryPoint="CreateDesktopExW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateDesktopEx([MarshalAs(UnmanagedType.LPWStr)] string lpszDesktop, char* lpszDevice, cpointer unfoundType_DEVMODEW_pDevmode, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa, uint ulHeapSize, cpointer pvoid);
    [DllImport(lib,EntryPoint="CreateDesktopExW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateDesktopEx(char* lpszDesktop, [MarshalAs(UnmanagedType.LPWStr)] string lpszDevice, cpointer unfoundType_DEVMODEW_pDevmode, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa, uint ulHeapSize, cpointer pvoid);
    [DllImport(lib,EntryPoint="CreateDesktopExW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateDesktopEx(char* lpszDesktop, char* lpszDevice, cpointer unfoundType_DEVMODEW_pDevmode, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa, uint ulHeapSize, cpointer pvoid);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateDesktopExW([MarshalAs(UnmanagedType.LPWStr)] string lpszDesktop, [MarshalAs(UnmanagedType.LPWStr)] string lpszDevice, cpointer unfoundType_DEVMODEW_pDevmode, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa, uint ulHeapSize, cpointer pvoid);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateDesktopExW([MarshalAs(UnmanagedType.LPWStr)] string lpszDesktop, char* lpszDevice, cpointer unfoundType_DEVMODEW_pDevmode, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa, uint ulHeapSize, cpointer pvoid);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateDesktopExW(char* lpszDesktop, [MarshalAs(UnmanagedType.LPWStr)] string lpszDevice, cpointer unfoundType_DEVMODEW_pDevmode, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa, uint ulHeapSize, cpointer pvoid);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateDesktopExW(char* lpszDesktop, char* lpszDevice, cpointer unfoundType_DEVMODEW_pDevmode, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa, uint ulHeapSize, cpointer pvoid);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer OpenDesktopA([MarshalAs(UnmanagedType.LPStr)] string lpszDesktop, int dwFlags, bool fInherit, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer OpenDesktopA(byte* lpszDesktop, int dwFlags, bool fInherit, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess);
    [DllImport(lib,EntryPoint="OpenDesktopW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer OpenDesktop([MarshalAs(UnmanagedType.LPWStr)] string lpszDesktop, int dwFlags, bool fInherit, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess);
    [DllImport(lib,EntryPoint="OpenDesktopW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer OpenDesktop(char* lpszDesktop, int dwFlags, bool fInherit, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer OpenDesktopW([MarshalAs(UnmanagedType.LPWStr)] string lpszDesktop, int dwFlags, bool fInherit, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer OpenDesktopW(char* lpszDesktop, int dwFlags, bool fInherit, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer OpenInputDesktop(int dwFlags, bool fInherit, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EnumDesktopsA(cpointer unfoundType_HWINSTA_hwinsta, cpointer unfoundType_DESKTOPENUMPROCA_lpEnumFunc, long lParam);
    [DllImport(lib,EntryPoint="EnumDesktopsW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EnumDesktops(cpointer unfoundType_HWINSTA_hwinsta, cpointer unfoundType_DESKTOPENUMPROCW_lpEnumFunc, long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EnumDesktopsW(cpointer unfoundType_HWINSTA_hwinsta, cpointer unfoundType_DESKTOPENUMPROCW_lpEnumFunc, long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EnumDesktopWindows(cpointer unfoundType_HDESK_hDesktop, cpointer unfoundType_WNDENUMPROC_lpfn, long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SwitchDesktop(cpointer unfoundType_HDESK_hDesktop);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetThreadDesktop(cpointer unfoundType_HDESK_hDesktop);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CloseDesktop(cpointer unfoundType_HDESK_hDesktop);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetThreadDesktop(int dwThreadId);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateWindowStationA([MarshalAs(UnmanagedType.LPStr)] string lpwinsta, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateWindowStationA(byte* lpwinsta, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport(lib,EntryPoint="CreateWindowStationW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateWindowStation([MarshalAs(UnmanagedType.LPWStr)] string lpwinsta, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport(lib,EntryPoint="CreateWindowStationW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateWindowStation(char* lpwinsta, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateWindowStationW([MarshalAs(UnmanagedType.LPWStr)] string lpwinsta, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateWindowStationW(char* lpwinsta, int dwFlags, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess, cpointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer OpenWindowStationA([MarshalAs(UnmanagedType.LPStr)] string lpszWinSta, bool fInherit, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer OpenWindowStationA(byte* lpszWinSta, bool fInherit, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess);
    [DllImport(lib,EntryPoint="OpenWindowStationW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer OpenWindowStation([MarshalAs(UnmanagedType.LPWStr)] string lpszWinSta, bool fInherit, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess);
    [DllImport(lib,EntryPoint="OpenWindowStationW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer OpenWindowStation(char* lpszWinSta, bool fInherit, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer OpenWindowStationW([MarshalAs(UnmanagedType.LPWStr)] string lpszWinSta, bool fInherit, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer OpenWindowStationW(char* lpszWinSta, bool fInherit, cpointer unfoundType_ACCESS_MASK_dwDesiredAccess);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EnumWindowStationsA(cpointer unfoundType_WINSTAENUMPROCA_lpEnumFunc, long lParam);
    [DllImport(lib,EntryPoint="EnumWindowStationsW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EnumWindowStations(cpointer unfoundType_WINSTAENUMPROCW_lpEnumFunc, long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EnumWindowStationsW(cpointer unfoundType_WINSTAENUMPROCW_lpEnumFunc, long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CloseWindowStation(cpointer unfoundType_HWINSTA_hWinSta);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetProcessWindowStation(cpointer unfoundType_HWINSTA_hWinSta);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetProcessWindowStation();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetUserObjectSecurity(cpointer hObj, cpointer unfoundType_PSECURITY_INFORMATION_pSIRequested, cpointer unfoundType_PSECURITY_DESCRIPTOR_pSID);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetUserObjectSecurity(cpointer hObj, cpointer unfoundType_PSECURITY_INFORMATION_pSIRequested, cpointer unfoundType_PSECURITY_DESCRIPTOR_pSID, int nLength, cpointer unfoundType_LPDWORD_lpnLengthNeeded);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetUserObjectInformationA(cpointer hObj, int nIndex, cpointer pvInfo, int nLength, cpointer unfoundType_LPDWORD_lpnLengthNeeded);
    [DllImport(lib,EntryPoint="GetUserObjectInformationW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetUserObjectInformation(cpointer hObj, int nIndex, cpointer pvInfo, int nLength, cpointer unfoundType_LPDWORD_lpnLengthNeeded);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetUserObjectInformationW(cpointer hObj, int nIndex, cpointer pvInfo, int nLength, cpointer unfoundType_LPDWORD_lpnLengthNeeded);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetUserObjectInformationA(cpointer hObj, int nIndex, cpointer pvInfo, int nLength);
    [DllImport(lib,EntryPoint="SetUserObjectInformationW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetUserObjectInformation(cpointer hObj, int nIndex, cpointer pvInfo, int nLength);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetUserObjectInformationW(cpointer hObj, int nIndex, cpointer pvInfo, int nLength);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool IsHungAppWindow(cpointer hwnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        void DisableProcessWindowsGhosting();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint RegisterWindowMessageA([MarshalAs(UnmanagedType.LPStr)] string lpString);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint RegisterWindowMessageA(byte* lpString);
    [DllImport(lib,EntryPoint="RegisterWindowMessageW",SetLastError=true,ExactSpelling=true)]public static extern
        uint RegisterWindowMessage([MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport(lib,EntryPoint="RegisterWindowMessageW",SetLastError=true,ExactSpelling=true)]public static extern
        uint RegisterWindowMessage(char* lpString);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint RegisterWindowMessageW([MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint RegisterWindowMessageW(char* lpString);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool TrackMouseEvent(cpointer unfoundType_LPTRACKMOUSEEVENT_lpEventTrack);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DrawEdge(cpointer hdc, cpointer unfoundType_LPRECT_qrc, uint edge, uint grfFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DrawFrameControl(cpointer unnamed_0, cpointer unfoundType_LPRECT_unnamed_1, uint unnamed_2, uint unnamed_3);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DrawCaption(cpointer hwnd, cpointer hdc, cpointer unfoundType_RECT_lprect, uint flags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DrawAnimatedRects(cpointer hwnd, int idAni, cpointer unfoundType_RECTlprcFromlprcFrom_unnamed_2, cpointer unfoundType_RECTlprcTolprcTo_unnamed_3);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetMessageA(cpointer unfoundType_LPMSG_lpMsg, cpointer hWnd, uint wMsgFilterMin, uint wMsgFilterMax);
    [DllImport(lib,EntryPoint="GetMessageW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetMessage(cpointer unfoundType_LPMSG_lpMsg, cpointer hWnd, uint wMsgFilterMin, uint wMsgFilterMax);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetMessageW(cpointer unfoundType_LPMSG_lpMsg, cpointer hWnd, uint wMsgFilterMin, uint wMsgFilterMax);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool TranslateMessage(cpointer unfoundType_MSGlpMsglpMsg_unnamed_0);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        long DispatchMessageA(cpointer unfoundType_MSGlpMsglpMsg_unnamed_0);
    [DllImport(lib,EntryPoint="DispatchMessageW",SetLastError=true,ExactSpelling=true)]public static extern
        long DispatchMessage(cpointer unfoundType_MSGlpMsglpMsg_unnamed_0);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        long DispatchMessageW(cpointer unfoundType_MSGlpMsglpMsg_unnamed_0);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetMessageQueue(int cMessagesMax);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool PeekMessageA(cpointer unfoundType_LPMSG_lpMsg, cpointer hWnd, uint wMsgFilterMin, uint wMsgFilterMax, uint wRemoveMsg);
    [DllImport(lib,EntryPoint="PeekMessageW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool PeekMessage(cpointer unfoundType_LPMSG_lpMsg, cpointer hWnd, uint wMsgFilterMin, uint wMsgFilterMax, uint wRemoveMsg);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool PeekMessageW(cpointer unfoundType_LPMSG_lpMsg, cpointer hWnd, uint wMsgFilterMin, uint wMsgFilterMax, uint wRemoveMsg);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool RegisterHotKey(cpointer hWnd, int id, uint fsModifiers, uint vk);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool UnregisterHotKey(cpointer hWnd, int id);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool ExitWindowsEx(uint uFlags, int dwReason);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SwapMouseButton(bool fSwap);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetMessagePos();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetMessageTime();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        long GetMessageExtraInfo();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetUnpredictedMessagePos();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool IsWow64Message();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        long SetMessageExtraInfo(long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        long SendMessageA(cpointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport(lib,EntryPoint="SendMessageW",SetLastError=true,ExactSpelling=true)]public static extern
        long SendMessage(cpointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        long SendMessageW(cpointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        long SendMessageTimeoutA(cpointer hWnd, uint Msg, ulong wParam, long lParam, uint fuFlags, uint uTimeout, cpointer unfoundType_PDWORD_PTR_lpdwResult);
    [DllImport(lib,EntryPoint="SendMessageTimeoutW",SetLastError=true,ExactSpelling=true)]public static extern
        long SendMessageTimeout(cpointer hWnd, uint Msg, ulong wParam, long lParam, uint fuFlags, uint uTimeout, cpointer unfoundType_PDWORD_PTR_lpdwResult);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        long SendMessageTimeoutW(cpointer hWnd, uint Msg, ulong wParam, long lParam, uint fuFlags, uint uTimeout, cpointer unfoundType_PDWORD_PTR_lpdwResult);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SendNotifyMessageA(cpointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport(lib,EntryPoint="SendNotifyMessageW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SendNotifyMessage(cpointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SendNotifyMessageW(cpointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SendMessageCallbackA(cpointer hWnd, uint Msg, ulong wParam, long lParam, cpointer unfoundType_SENDASYNCPROC_lpResultCallBack, cpointer unfoundType_ULONG_PTR_dwData);
    [DllImport(lib,EntryPoint="SendMessageCallbackW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SendMessageCallback(cpointer hWnd, uint Msg, ulong wParam, long lParam, cpointer unfoundType_SENDASYNCPROC_lpResultCallBack, cpointer unfoundType_ULONG_PTR_dwData);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SendMessageCallbackW(cpointer hWnd, uint Msg, ulong wParam, long lParam, cpointer unfoundType_SENDASYNCPROC_lpResultCallBack, cpointer unfoundType_ULONG_PTR_dwData);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int BroadcastSystemMessageExA(int flags, cpointer unfoundType_LPDWORD_lpInfo, uint Msg, ulong wParam, long lParam, cpointer unfoundType_PBSMINFO_pbsmInfo);
    [DllImport(lib,EntryPoint="BroadcastSystemMessageExW",SetLastError=true,ExactSpelling=true)]public static extern
        int BroadcastSystemMessageEx(int flags, cpointer unfoundType_LPDWORD_lpInfo, uint Msg, ulong wParam, long lParam, cpointer unfoundType_PBSMINFO_pbsmInfo);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int BroadcastSystemMessageExW(int flags, cpointer unfoundType_LPDWORD_lpInfo, uint Msg, ulong wParam, long lParam, cpointer unfoundType_PBSMINFO_pbsmInfo);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int BroadcastSystemMessageA(int flags, cpointer unfoundType_LPDWORD_lpInfo, uint Msg, ulong wParam, long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int BroadcastSystemMessageW(int flags, cpointer unfoundType_LPDWORD_lpInfo, uint Msg, ulong wParam, long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int BroadcastSystemMessage(int flags, cpointer unfoundType_LPDWORD_lpInfo, uint Msg, ulong wParam, long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer RegisterDeviceNotificationA(cpointer hRecipient, cpointer NotificationFilter, int Flags);
    [DllImport(lib,EntryPoint="RegisterDeviceNotificationW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer RegisterDeviceNotification(cpointer hRecipient, cpointer NotificationFilter, int Flags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer RegisterDeviceNotificationW(cpointer hRecipient, cpointer NotificationFilter, int Flags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool UnregisterDeviceNotification(cpointer unfoundType_HDEVNOTIFY_Handle);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer RegisterPowerSettingNotification(cpointer hRecipient, cpointer unfoundType_LPCGUID_PowerSettingGuid, int Flags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool UnregisterPowerSettingNotification(cpointer unfoundType_HPOWERNOTIFY_Handle);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer RegisterSuspendResumeNotification(cpointer hRecipient, int Flags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool UnregisterSuspendResumeNotification(cpointer unfoundType_HPOWERNOTIFY_Handle);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool PostMessageA(cpointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport(lib,EntryPoint="PostMessageW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool PostMessage(cpointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool PostMessageW(cpointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool PostThreadMessageA(int idThread, uint Msg, ulong wParam, long lParam);
    [DllImport(lib,EntryPoint="PostThreadMessageW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool PostThreadMessage(int idThread, uint Msg, ulong wParam, long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool PostThreadMessageW(int idThread, uint Msg, ulong wParam, long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool AttachThreadInput(int idAttach, int idAttachTo, bool fAttach);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool ReplyMessage(long lResult);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool WaitMessage();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int WaitForInputIdle(cpointer hProcess, int dwMilliseconds);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer DefWindowProcA(cpointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport(lib,EntryPoint="DefWindowProcW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer DefWindowProc(cpointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer DefWindowProcW(cpointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        void PostQuitMessage(int nExitCode);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        long CallWindowProcA(cpointer unfoundType_WNDPROC_lpPrevWndFunc, cpointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport(lib,EntryPoint="CallWindowProcW",SetLastError=true,ExactSpelling=true)]public static extern
        long CallWindowProc(cpointer unfoundType_WNDPROC_lpPrevWndFunc, cpointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        long CallWindowProcW(cpointer unfoundType_WNDPROC_lpPrevWndFunc, cpointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool InSendMessage();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int InSendMessageEx(cpointer lpReserved);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint GetDoubleClickTime();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetDoubleClickTime(uint unnamed_0);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        short RegisterClassA(cpointer unfoundType_WNDCLASSAlpWndClasslpWndClass_unnamed_0);
    [DllImport(lib,EntryPoint="RegisterClassW",SetLastError=true,ExactSpelling=true)]public static extern
        short RegisterClass(cpointer unfoundType_WNDCLASSWlpWndClasslpWndClass_unnamed_0);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        short RegisterClassW(cpointer unfoundType_WNDCLASSWlpWndClasslpWndClass_unnamed_0);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool UnregisterClassA([MarshalAs(UnmanagedType.LPStr)] string lpClassName, cpointer unfoundType_HINSTANCE_hInstance);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool UnregisterClassA(byte* lpClassName, cpointer unfoundType_HINSTANCE_hInstance);
    [DllImport(lib,EntryPoint="UnregisterClassW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool UnregisterClass([MarshalAs(UnmanagedType.LPWStr)] string lpClassName, cpointer unfoundType_HINSTANCE_hInstance);
    [DllImport(lib,EntryPoint="UnregisterClassW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool UnregisterClass(char* lpClassName, cpointer unfoundType_HINSTANCE_hInstance);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool UnregisterClassW([MarshalAs(UnmanagedType.LPWStr)] string lpClassName, cpointer unfoundType_HINSTANCE_hInstance);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool UnregisterClassW(char* lpClassName, cpointer unfoundType_HINSTANCE_hInstance);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetClassInfoA(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPStr)] string lpClassName, cpointer unfoundType_LPWNDCLASSA_lpWndClass);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetClassInfoA(cpointer unfoundType_HINSTANCE_hInstance, byte* lpClassName, cpointer unfoundType_LPWNDCLASSA_lpWndClass);
    [DllImport(lib,EntryPoint="GetClassInfoW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetClassInfo(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpClassName, cpointer unfoundType_LPWNDCLASSW_lpWndClass);
    [DllImport(lib,EntryPoint="GetClassInfoW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetClassInfo(cpointer unfoundType_HINSTANCE_hInstance, char* lpClassName, cpointer unfoundType_LPWNDCLASSW_lpWndClass);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetClassInfoW(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpClassName, cpointer unfoundType_LPWNDCLASSW_lpWndClass);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetClassInfoW(cpointer unfoundType_HINSTANCE_hInstance, char* lpClassName, cpointer unfoundType_LPWNDCLASSW_lpWndClass);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        short RegisterClassExA(cpointer unfoundType_WNDCLASSEXA_unnamed_0);
    [DllImport(lib,EntryPoint="RegisterClassExW",SetLastError=true,ExactSpelling=true)]public static extern
        short RegisterClassEx(cpointer unfoundType_WNDCLASSEXW_unnamed_0);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        short RegisterClassExW(cpointer unfoundType_WNDCLASSEXW_unnamed_0);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetClassInfoExA(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPStr)] string lpszClass, cpointer unfoundType_LPWNDCLASSEXA_lpwcx);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetClassInfoExA(cpointer unfoundType_HINSTANCE_hInstance, byte* lpszClass, cpointer unfoundType_LPWNDCLASSEXA_lpwcx);
    [DllImport(lib,EntryPoint="GetClassInfoExW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetClassInfoEx(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpszClass, cpointer unfoundType_LPWNDCLASSEXW_lpwcx);
    [DllImport(lib,EntryPoint="GetClassInfoExW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetClassInfoEx(cpointer unfoundType_HINSTANCE_hInstance, char* lpszClass, cpointer unfoundType_LPWNDCLASSEXW_lpwcx);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetClassInfoExW(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpszClass, cpointer unfoundType_LPWNDCLASSEXW_lpwcx);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetClassInfoExW(cpointer unfoundType_HINSTANCE_hInstance, char* lpszClass, cpointer unfoundType_LPWNDCLASSEXW_lpwcx);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateWindowExA(int dwExStyle, [MarshalAs(UnmanagedType.LPStr)] string lpClassName, [MarshalAs(UnmanagedType.LPStr)] string lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, cpointer hWndParent, cpointer hMenu, cpointer unfoundType_HINSTANCE_hInstance, cpointer lpParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateWindowExA(int dwExStyle, [MarshalAs(UnmanagedType.LPStr)] string lpClassName, byte* lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, cpointer hWndParent, cpointer hMenu, cpointer unfoundType_HINSTANCE_hInstance, cpointer lpParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateWindowExA(int dwExStyle, byte* lpClassName, [MarshalAs(UnmanagedType.LPStr)] string lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, cpointer hWndParent, cpointer hMenu, cpointer unfoundType_HINSTANCE_hInstance, cpointer lpParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateWindowExA(int dwExStyle, byte* lpClassName, byte* lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, cpointer hWndParent, cpointer hMenu, cpointer unfoundType_HINSTANCE_hInstance, cpointer lpParam);
    [DllImport(lib,EntryPoint="CreateWindowExW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateWindowEx(int dwExStyle, [MarshalAs(UnmanagedType.LPWStr)] string lpClassName, [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, cpointer hWndParent, cpointer hMenu, cpointer unfoundType_HINSTANCE_hInstance, cpointer lpParam);
    [DllImport(lib,EntryPoint="CreateWindowExW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateWindowEx(int dwExStyle, [MarshalAs(UnmanagedType.LPWStr)] string lpClassName, char* lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, cpointer hWndParent, cpointer hMenu, cpointer unfoundType_HINSTANCE_hInstance, cpointer lpParam);
    [DllImport(lib,EntryPoint="CreateWindowExW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateWindowEx(int dwExStyle, char* lpClassName, [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, cpointer hWndParent, cpointer hMenu, cpointer unfoundType_HINSTANCE_hInstance, cpointer lpParam);
    [DllImport(lib,EntryPoint="CreateWindowExW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateWindowEx(int dwExStyle, char* lpClassName, char* lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, cpointer hWndParent, cpointer hMenu, cpointer unfoundType_HINSTANCE_hInstance, cpointer lpParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateWindowExW(int dwExStyle, [MarshalAs(UnmanagedType.LPWStr)] string lpClassName, [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, cpointer hWndParent, cpointer hMenu, cpointer unfoundType_HINSTANCE_hInstance, cpointer lpParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateWindowExW(int dwExStyle, [MarshalAs(UnmanagedType.LPWStr)] string lpClassName, char* lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, cpointer hWndParent, cpointer hMenu, cpointer unfoundType_HINSTANCE_hInstance, cpointer lpParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateWindowExW(int dwExStyle, char* lpClassName, [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, cpointer hWndParent, cpointer hMenu, cpointer unfoundType_HINSTANCE_hInstance, cpointer lpParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateWindowExW(int dwExStyle, char* lpClassName, char* lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, cpointer hWndParent, cpointer hMenu, cpointer unfoundType_HINSTANCE_hInstance, cpointer lpParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool IsWindow(cpointer hWnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool IsMenu(cpointer hMenu);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool IsChild(cpointer hWndParent, cpointer hWnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DestroyWindow(cpointer hWnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool ShowWindow(cpointer hWnd, int nCmdShow);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool AnimateWindow(cpointer hWnd, int dwTime, int dwFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool UpdateLayeredWindow(cpointer hWnd, cpointer hdcDst, cpointer unfoundType_POINT_pptDst, cpointer unfoundType_SIZE_psize, cpointer hdcSrc, cpointer unfoundType_POINT_pptSrc, cpointer unfoundType_COLORREF_crKey, cpointer unfoundType_BLENDFUNCTION_pblend, int dwFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool UpdateLayeredWindowIndirect(cpointer hWnd, cpointer unfoundType_UPDATELAYEREDWINDOWINFO_pULWInfo);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetLayeredWindowAttributes(cpointer hwnd, cpointer unfoundType_COLORREF_pcrKey, cpointer pbAlpha, cpointer pdwFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool PrintWindow(cpointer hwnd, cpointer hdcBlt, uint nFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetLayeredWindowAttributes(cpointer hwnd, cpointer unfoundType_COLORREF_crKey, byte bAlpha, int dwFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool ShowWindowAsync(cpointer hWnd, int nCmdShow);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool FlashWindow(cpointer hWnd, bool bInvert);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool FlashWindowEx(cpointer unfoundType_PFLASHWINFO_pfwi);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool ShowOwnedPopups(cpointer hWnd, bool fShow);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool OpenIcon(cpointer hWnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CloseWindow(cpointer hWnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool MoveWindow(cpointer hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetWindowPos(cpointer hWnd, cpointer hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetWindowPlacement(cpointer hWnd, cpointer unfoundType_WINDOWPLACEMENTlpwndpllpwndpl_unnamed_1);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetWindowPlacement(cpointer hWnd, cpointer unfoundType_WINDOWPLACEMENTlpwndpllpwndpl_unnamed_1);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetWindowDisplayAffinity(cpointer hWnd, cpointer pdwAffinity);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetWindowDisplayAffinity(cpointer hWnd, int dwAffinity);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer BeginDeferWindowPos(int nNumWindows);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer DeferWindowPos(cpointer unfoundType_HDWP_hWinPosInfo, cpointer hWnd, cpointer hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EndDeferWindowPos(cpointer unfoundType_HDWP_hWinPosInfo);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool IsWindowVisible(cpointer hWnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool IsIconic(cpointer hWnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool AnyPopup();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool BringWindowToTop(cpointer hWnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool IsZoomed(cpointer hWnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateDialogParamA(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPStr)] string lpTemplateName, cpointer hWndParent, cpointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateDialogParamA(cpointer unfoundType_HINSTANCE_hInstance, byte* lpTemplateName, cpointer hWndParent, cpointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport(lib,EntryPoint="CreateDialogParamW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateDialogParam(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpTemplateName, cpointer hWndParent, cpointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport(lib,EntryPoint="CreateDialogParamW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateDialogParam(cpointer unfoundType_HINSTANCE_hInstance, char* lpTemplateName, cpointer hWndParent, cpointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateDialogParamW(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpTemplateName, cpointer hWndParent, cpointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateDialogParamW(cpointer unfoundType_HINSTANCE_hInstance, char* lpTemplateName, cpointer hWndParent, cpointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateDialogIndirectParamA(cpointer unfoundType_HINSTANCE_hInstance, cpointer unfoundType_LPCDLGTEMPLATEA_lpTemplate, cpointer hWndParent, cpointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport(lib,EntryPoint="CreateDialogIndirectParamW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateDialogIndirectParam(cpointer unfoundType_HINSTANCE_hInstance, cpointer unfoundType_LPCDLGTEMPLATEW_lpTemplate, cpointer hWndParent, cpointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateDialogIndirectParamW(cpointer unfoundType_HINSTANCE_hInstance, cpointer unfoundType_LPCDLGTEMPLATEW_lpTemplate, cpointer hWndParent, cpointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer DialogBoxParamA(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPStr)] string lpTemplateName, cpointer hWndParent, cpointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer DialogBoxParamA(cpointer unfoundType_HINSTANCE_hInstance, byte* lpTemplateName, cpointer hWndParent, cpointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport(lib,EntryPoint="DialogBoxParamW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer DialogBoxParam(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpTemplateName, cpointer hWndParent, cpointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport(lib,EntryPoint="DialogBoxParamW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer DialogBoxParam(cpointer unfoundType_HINSTANCE_hInstance, char* lpTemplateName, cpointer hWndParent, cpointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer DialogBoxParamW(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpTemplateName, cpointer hWndParent, cpointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer DialogBoxParamW(cpointer unfoundType_HINSTANCE_hInstance, char* lpTemplateName, cpointer hWndParent, cpointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer DialogBoxIndirectParamA(cpointer unfoundType_HINSTANCE_hInstance, cpointer unfoundType_LPCDLGTEMPLATEA_hDialogTemplate, cpointer hWndParent, cpointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport(lib,EntryPoint="DialogBoxIndirectParamW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer DialogBoxIndirectParam(cpointer unfoundType_HINSTANCE_hInstance, cpointer unfoundType_LPCDLGTEMPLATEW_hDialogTemplate, cpointer hWndParent, cpointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer DialogBoxIndirectParamW(cpointer unfoundType_HINSTANCE_hInstance, cpointer unfoundType_LPCDLGTEMPLATEW_hDialogTemplate, cpointer hWndParent, cpointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EndDialog(cpointer hDlg, cpointer unfoundType_INT_PTR_nResult);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetDlgItem(cpointer hDlg, int nIDDlgItem);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetDlgItemInt(cpointer hDlg, int nIDDlgItem, uint uValue, bool bSigned);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint GetDlgItemInt(cpointer hDlg, int nIDDlgItem, cpointer unfoundType_BOOLlpTranslatedlpTranslated_unnamed_2, bool bSigned);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetDlgItemTextA(cpointer hDlg, int nIDDlgItem, [MarshalAs(UnmanagedType.LPStr)] string lpString);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetDlgItemTextA(cpointer hDlg, int nIDDlgItem, byte* lpString);
    [DllImport(lib,EntryPoint="SetDlgItemTextW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetDlgItemText(cpointer hDlg, int nIDDlgItem, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport(lib,EntryPoint="SetDlgItemTextW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetDlgItemText(cpointer hDlg, int nIDDlgItem, char* lpString);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetDlgItemTextW(cpointer hDlg, int nIDDlgItem, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetDlgItemTextW(cpointer hDlg, int nIDDlgItem, char* lpString);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint GetDlgItemTextA(cpointer hDlg, int nIDDlgItem, [MarshalAs(UnmanagedType.LPStr)] string lpString, int cchMax);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint GetDlgItemTextA(cpointer hDlg, int nIDDlgItem, ReadOnlySpan<byte> lpString, int cchMax);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint GetDlgItemTextA(cpointer hDlg, int nIDDlgItem, byte* lpString, int cchMax);
    [DllImport(lib,EntryPoint="GetDlgItemTextW",SetLastError=true,ExactSpelling=true)]public static extern
        uint GetDlgItemText(cpointer hDlg, int nIDDlgItem, string lpString, int cchMax);
    [DllImport(lib,EntryPoint="GetDlgItemTextW",SetLastError=true,ExactSpelling=true)]public static extern
        uint GetDlgItemText(cpointer hDlg, int nIDDlgItem, char* lpString, int cchMax);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint GetDlgItemTextW(cpointer hDlg, int nIDDlgItem, string lpString, int cchMax);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint GetDlgItemTextW(cpointer hDlg, int nIDDlgItem, char* lpString, int cchMax);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CheckDlgButton(cpointer hDlg, int nIDButton, uint uCheck);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CheckRadioButton(cpointer hDlg, int nIDFirstButton, int nIDLastButton, int nIDCheckButton);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint IsDlgButtonChecked(cpointer hDlg, int nIDButton);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        long SendDlgItemMessageA(cpointer hDlg, int nIDDlgItem, uint Msg, ulong wParam, long lParam);
    [DllImport(lib,EntryPoint="SendDlgItemMessageW",SetLastError=true,ExactSpelling=true)]public static extern
        long SendDlgItemMessage(cpointer hDlg, int nIDDlgItem, uint Msg, ulong wParam, long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        long SendDlgItemMessageW(cpointer hDlg, int nIDDlgItem, uint Msg, ulong wParam, long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetNextDlgGroupItem(cpointer hDlg, cpointer hCtl, bool bPrevious);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetNextDlgTabItem(cpointer hDlg, cpointer hCtl, bool bPrevious);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetDlgCtrlID(cpointer hWnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetDialogBaseUnits();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer DefDlgProcA(cpointer hDlg, uint Msg, ulong wParam, long lParam);
    [DllImport(lib,EntryPoint="DefDlgProcW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer DefDlgProc(cpointer hDlg, uint Msg, ulong wParam, long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer DefDlgProcW(cpointer hDlg, uint Msg, ulong wParam, long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetDialogControlDpiChangeBehavior(cpointer hWnd, cpointer unfoundType_DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS_mask, cpointer unfoundType_DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS_values);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetDialogControlDpiChangeBehavior(cpointer hWnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetDialogDpiChangeBehavior(cpointer hDlg, cpointer unfoundType_DIALOG_DPI_CHANGE_BEHAVIORS_mask, cpointer unfoundType_DIALOG_DPI_CHANGE_BEHAVIORS_values);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetDialogDpiChangeBehavior(cpointer hDlg);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CallMsgFilterA(cpointer unfoundType_LPMSG_lpMsg, int nCode);
    [DllImport(lib,EntryPoint="CallMsgFilterW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CallMsgFilter(cpointer unfoundType_LPMSG_lpMsg, int nCode);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CallMsgFilterW(cpointer unfoundType_LPMSG_lpMsg, int nCode);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool OpenClipboard(cpointer hWndNewOwner);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CloseClipboard();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetClipboardSequenceNumber();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetClipboardOwner();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer SetClipboardViewer(cpointer hWndNewViewer);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetClipboardViewer();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool ChangeClipboardChain(cpointer hWndRemove, cpointer hWndNewNext);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer SetClipboardData(uint uFormat, cpointer hMem);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetClipboardData(uint uFormat);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetClipboardMetadata(uint format, cpointer unfoundType_PGETCLIPBMETADATA_metadata);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint RegisterClipboardFormatA([MarshalAs(UnmanagedType.LPStr)] string lpszFormat);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint RegisterClipboardFormatA(byte* lpszFormat);
    [DllImport(lib,EntryPoint="RegisterClipboardFormatW",SetLastError=true,ExactSpelling=true)]public static extern
        uint RegisterClipboardFormat([MarshalAs(UnmanagedType.LPWStr)] string lpszFormat);
    [DllImport(lib,EntryPoint="RegisterClipboardFormatW",SetLastError=true,ExactSpelling=true)]public static extern
        uint RegisterClipboardFormat(char* lpszFormat);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint RegisterClipboardFormatW([MarshalAs(UnmanagedType.LPWStr)] string lpszFormat);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint RegisterClipboardFormatW(char* lpszFormat);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int CountClipboardFormats();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint EnumClipboardFormats(uint format);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetClipboardFormatNameA(uint format, [MarshalAs(UnmanagedType.LPStr)] string lpszFormatName, int cchMaxCount);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetClipboardFormatNameA(uint format, ReadOnlySpan<byte> lpszFormatName, int cchMaxCount);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetClipboardFormatNameA(uint format, byte* lpszFormatName, int cchMaxCount);
    [DllImport(lib,EntryPoint="GetClipboardFormatNameW",SetLastError=true,ExactSpelling=true)]public static extern
        int GetClipboardFormatName(uint format, string lpszFormatName, int cchMaxCount);
    [DllImport(lib,EntryPoint="GetClipboardFormatNameW",SetLastError=true,ExactSpelling=true)]public static extern
        int GetClipboardFormatName(uint format, char* lpszFormatName, int cchMaxCount);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetClipboardFormatNameW(uint format, string lpszFormatName, int cchMaxCount);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetClipboardFormatNameW(uint format, char* lpszFormatName, int cchMaxCount);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EmptyClipboard();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool IsClipboardFormatAvailable(uint format);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetPriorityClipboardFormat(cpointer unfoundType_UINTpaFormatPriorityListpaFormatPriorityList_unnamed_0, int cFormats);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetOpenClipboardWindow();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool AddClipboardFormatListener(cpointer hwnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool RemoveClipboardFormatListener(cpointer hwnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetUpdatedClipboardFormats(cpointer unfoundType_PUINT_lpuiFormats, uint cFormats, cpointer unfoundType_PUINT_pcFormatsOut);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CharToOemA([MarshalAs(UnmanagedType.LPStr)] string pSrc, [MarshalAs(UnmanagedType.LPStr)] string pDst);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CharToOemA([MarshalAs(UnmanagedType.LPStr)] string pSrc, ReadOnlySpan<byte> pDst);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CharToOemA([MarshalAs(UnmanagedType.LPStr)] string pSrc, byte* pDst);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CharToOemA(byte* pSrc, [MarshalAs(UnmanagedType.LPStr)] string pDst);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CharToOemA(byte* pSrc, ReadOnlySpan<byte> pDst);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CharToOemA(byte* pSrc, byte* pDst);
    [DllImport(lib,EntryPoint="CharToOemW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CharToOem([MarshalAs(UnmanagedType.LPWStr)] string pSrc, [MarshalAs(UnmanagedType.LPStr)] string pDst);
    [DllImport(lib,EntryPoint="CharToOemW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CharToOem([MarshalAs(UnmanagedType.LPWStr)] string pSrc, ReadOnlySpan<byte> pDst);
    [DllImport(lib,EntryPoint="CharToOemW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CharToOem([MarshalAs(UnmanagedType.LPWStr)] string pSrc, byte* pDst);
    [DllImport(lib,EntryPoint="CharToOemW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CharToOem(char* pSrc, [MarshalAs(UnmanagedType.LPStr)] string pDst);
    [DllImport(lib,EntryPoint="CharToOemW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CharToOem(char* pSrc, ReadOnlySpan<byte> pDst);
    [DllImport(lib,EntryPoint="CharToOemW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CharToOem(char* pSrc, byte* pDst);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CharToOemW([MarshalAs(UnmanagedType.LPWStr)] string pSrc, [MarshalAs(UnmanagedType.LPStr)] string pDst);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CharToOemW([MarshalAs(UnmanagedType.LPWStr)] string pSrc, ReadOnlySpan<byte> pDst);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CharToOemW([MarshalAs(UnmanagedType.LPWStr)] string pSrc, byte* pDst);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CharToOemW(char* pSrc, [MarshalAs(UnmanagedType.LPStr)] string pDst);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CharToOemW(char* pSrc, ReadOnlySpan<byte> pDst);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CharToOemW(char* pSrc, byte* pDst);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool OemToCharA([MarshalAs(UnmanagedType.LPStr)] string pSrc, [MarshalAs(UnmanagedType.LPStr)] string pDst);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool OemToCharA([MarshalAs(UnmanagedType.LPStr)] string pSrc, ReadOnlySpan<byte> pDst);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool OemToCharA([MarshalAs(UnmanagedType.LPStr)] string pSrc, byte* pDst);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool OemToCharA(byte* pSrc, [MarshalAs(UnmanagedType.LPStr)] string pDst);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool OemToCharA(byte* pSrc, ReadOnlySpan<byte> pDst);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool OemToCharA(byte* pSrc, byte* pDst);
    [DllImport(lib,EntryPoint="OemToCharW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool OemToChar([MarshalAs(UnmanagedType.LPStr)] string pSrc, string pDst);
    [DllImport(lib,EntryPoint="OemToCharW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool OemToChar([MarshalAs(UnmanagedType.LPStr)] string pSrc, char* pDst);
    [DllImport(lib,EntryPoint="OemToCharW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool OemToChar(byte* pSrc, string pDst);
    [DllImport(lib,EntryPoint="OemToCharW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool OemToChar(byte* pSrc, char* pDst);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool OemToCharW([MarshalAs(UnmanagedType.LPStr)] string pSrc, string pDst);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool OemToCharW([MarshalAs(UnmanagedType.LPStr)] string pSrc, char* pDst);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool OemToCharW(byte* pSrc, string pDst);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool OemToCharW(byte* pSrc, char* pDst);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CharToOemBuffA([MarshalAs(UnmanagedType.LPStr)] string lpszSrc, [MarshalAs(UnmanagedType.LPStr)] string lpszDst, int cchDstLength);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CharToOemBuffA([MarshalAs(UnmanagedType.LPStr)] string lpszSrc, ReadOnlySpan<byte> lpszDst, int cchDstLength);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CharToOemBuffA([MarshalAs(UnmanagedType.LPStr)] string lpszSrc, byte* lpszDst, int cchDstLength);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CharToOemBuffA(byte* lpszSrc, [MarshalAs(UnmanagedType.LPStr)] string lpszDst, int cchDstLength);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CharToOemBuffA(byte* lpszSrc, ReadOnlySpan<byte> lpszDst, int cchDstLength);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CharToOemBuffA(byte* lpszSrc, byte* lpszDst, int cchDstLength);
    [DllImport(lib,EntryPoint="CharToOemBuffW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CharToOemBuff([MarshalAs(UnmanagedType.LPWStr)] string lpszSrc, [MarshalAs(UnmanagedType.LPStr)] string lpszDst, int cchDstLength);
    [DllImport(lib,EntryPoint="CharToOemBuffW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CharToOemBuff([MarshalAs(UnmanagedType.LPWStr)] string lpszSrc, ReadOnlySpan<byte> lpszDst, int cchDstLength);
    [DllImport(lib,EntryPoint="CharToOemBuffW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CharToOemBuff([MarshalAs(UnmanagedType.LPWStr)] string lpszSrc, byte* lpszDst, int cchDstLength);
    [DllImport(lib,EntryPoint="CharToOemBuffW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CharToOemBuff(char* lpszSrc, [MarshalAs(UnmanagedType.LPStr)] string lpszDst, int cchDstLength);
    [DllImport(lib,EntryPoint="CharToOemBuffW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CharToOemBuff(char* lpszSrc, ReadOnlySpan<byte> lpszDst, int cchDstLength);
    [DllImport(lib,EntryPoint="CharToOemBuffW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CharToOemBuff(char* lpszSrc, byte* lpszDst, int cchDstLength);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CharToOemBuffW([MarshalAs(UnmanagedType.LPWStr)] string lpszSrc, [MarshalAs(UnmanagedType.LPStr)] string lpszDst, int cchDstLength);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CharToOemBuffW([MarshalAs(UnmanagedType.LPWStr)] string lpszSrc, ReadOnlySpan<byte> lpszDst, int cchDstLength);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CharToOemBuffW([MarshalAs(UnmanagedType.LPWStr)] string lpszSrc, byte* lpszDst, int cchDstLength);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CharToOemBuffW(char* lpszSrc, [MarshalAs(UnmanagedType.LPStr)] string lpszDst, int cchDstLength);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CharToOemBuffW(char* lpszSrc, ReadOnlySpan<byte> lpszDst, int cchDstLength);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CharToOemBuffW(char* lpszSrc, byte* lpszDst, int cchDstLength);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool OemToCharBuffA([MarshalAs(UnmanagedType.LPStr)] string lpszSrc, [MarshalAs(UnmanagedType.LPStr)] string lpszDst, int cchDstLength);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool OemToCharBuffA([MarshalAs(UnmanagedType.LPStr)] string lpszSrc, ReadOnlySpan<byte> lpszDst, int cchDstLength);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool OemToCharBuffA([MarshalAs(UnmanagedType.LPStr)] string lpszSrc, byte* lpszDst, int cchDstLength);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool OemToCharBuffA(byte* lpszSrc, [MarshalAs(UnmanagedType.LPStr)] string lpszDst, int cchDstLength);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool OemToCharBuffA(byte* lpszSrc, ReadOnlySpan<byte> lpszDst, int cchDstLength);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool OemToCharBuffA(byte* lpszSrc, byte* lpszDst, int cchDstLength);
    [DllImport(lib,EntryPoint="OemToCharBuffW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool OemToCharBuff([MarshalAs(UnmanagedType.LPStr)] string lpszSrc, string lpszDst, int cchDstLength);
    [DllImport(lib,EntryPoint="OemToCharBuffW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool OemToCharBuff([MarshalAs(UnmanagedType.LPStr)] string lpszSrc, char* lpszDst, int cchDstLength);
    [DllImport(lib,EntryPoint="OemToCharBuffW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool OemToCharBuff(byte* lpszSrc, string lpszDst, int cchDstLength);
    [DllImport(lib,EntryPoint="OemToCharBuffW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool OemToCharBuff(byte* lpszSrc, char* lpszDst, int cchDstLength);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool OemToCharBuffW([MarshalAs(UnmanagedType.LPStr)] string lpszSrc, string lpszDst, int cchDstLength);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool OemToCharBuffW([MarshalAs(UnmanagedType.LPStr)] string lpszSrc, char* lpszDst, int cchDstLength);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool OemToCharBuffW(byte* lpszSrc, string lpszDst, int cchDstLength);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool OemToCharBuffW(byte* lpszSrc, char* lpszDst, int cchDstLength);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        byte* CharUpperA_([MarshalAs(UnmanagedType.LPStr)] string lpsz);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        byte* CharUpperA_(ReadOnlySpan<byte> lpsz);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        byte* CharUpperA_(byte* lpsz);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        ReadOnlySpan<byte> CharUpperA([MarshalAs(UnmanagedType.LPStr)] string lpsz);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        ReadOnlySpan<byte> CharUpperA(ReadOnlySpan<byte> lpsz);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        ReadOnlySpan<byte> CharUpperA(byte* lpsz);
    [DllImport(lib,EntryPoint="CharUpperW",SetLastError=true,ExactSpelling=true)]public static extern
        char* CharUpper_(string lpsz);
    [DllImport(lib,EntryPoint="CharUpperW",SetLastError=true,ExactSpelling=true)]public static extern
        char* CharUpper_(char* lpsz);
    [DllImport(lib,EntryPoint="CharUpperW",SetLastError=true,ExactSpelling=true)]public static extern
        string CharUpper(string lpsz);
    [DllImport(lib,EntryPoint="CharUpperW",SetLastError=true,ExactSpelling=true)]public static extern
        string CharUpper(char* lpsz);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        char* CharUpperW_(string lpsz);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        char* CharUpperW_(char* lpsz);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        string CharUpperW(string lpsz);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        string CharUpperW(char* lpsz);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int CharUpperBuffA([MarshalAs(UnmanagedType.LPStr)] string lpsz, int cchLength);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int CharUpperBuffA(ReadOnlySpan<byte> lpsz, int cchLength);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int CharUpperBuffA(byte* lpsz, int cchLength);
    [DllImport(lib,EntryPoint="CharUpperBuffW",SetLastError=true,ExactSpelling=true)]public static extern
        int CharUpperBuff(string lpsz, int cchLength);
    [DllImport(lib,EntryPoint="CharUpperBuffW",SetLastError=true,ExactSpelling=true)]public static extern
        int CharUpperBuff(char* lpsz, int cchLength);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int CharUpperBuffW(string lpsz, int cchLength);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int CharUpperBuffW(char* lpsz, int cchLength);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        byte* CharLowerA_([MarshalAs(UnmanagedType.LPStr)] string lpsz);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        byte* CharLowerA_(ReadOnlySpan<byte> lpsz);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        byte* CharLowerA_(byte* lpsz);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        ReadOnlySpan<byte> CharLowerA([MarshalAs(UnmanagedType.LPStr)] string lpsz);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        ReadOnlySpan<byte> CharLowerA(ReadOnlySpan<byte> lpsz);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        ReadOnlySpan<byte> CharLowerA(byte* lpsz);
    [DllImport(lib,EntryPoint="CharLowerW",SetLastError=true,ExactSpelling=true)]public static extern
        char* CharLower_(string lpsz);
    [DllImport(lib,EntryPoint="CharLowerW",SetLastError=true,ExactSpelling=true)]public static extern
        char* CharLower_(char* lpsz);
    [DllImport(lib,EntryPoint="CharLowerW",SetLastError=true,ExactSpelling=true)]public static extern
        string CharLower(string lpsz);
    [DllImport(lib,EntryPoint="CharLowerW",SetLastError=true,ExactSpelling=true)]public static extern
        string CharLower(char* lpsz);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        char* CharLowerW_(string lpsz);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        char* CharLowerW_(char* lpsz);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        string CharLowerW(string lpsz);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        string CharLowerW(char* lpsz);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int CharLowerBuffA([MarshalAs(UnmanagedType.LPStr)] string lpsz, int cchLength);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int CharLowerBuffA(ReadOnlySpan<byte> lpsz, int cchLength);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int CharLowerBuffA(byte* lpsz, int cchLength);
    [DllImport(lib,EntryPoint="CharLowerBuffW",SetLastError=true,ExactSpelling=true)]public static extern
        int CharLowerBuff(string lpsz, int cchLength);
    [DllImport(lib,EntryPoint="CharLowerBuffW",SetLastError=true,ExactSpelling=true)]public static extern
        int CharLowerBuff(char* lpsz, int cchLength);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int CharLowerBuffW(string lpsz, int cchLength);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int CharLowerBuffW(char* lpsz, int cchLength);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        byte* CharNextA_([MarshalAs(UnmanagedType.LPStr)] string lpsz);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        byte* CharNextA_(byte* lpsz);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        ReadOnlySpan<byte> CharNextA([MarshalAs(UnmanagedType.LPStr)] string lpsz);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        ReadOnlySpan<byte> CharNextA(byte* lpsz);
    [DllImport(lib,EntryPoint="CharNextW",SetLastError=true,ExactSpelling=true)]public static extern
        char* CharNext_([MarshalAs(UnmanagedType.LPWStr)] string lpsz);
    [DllImport(lib,EntryPoint="CharNextW",SetLastError=true,ExactSpelling=true)]public static extern
        char* CharNext_(char* lpsz);
    [DllImport(lib,EntryPoint="CharNextW",SetLastError=true,ExactSpelling=true)]public static extern
        string CharNext([MarshalAs(UnmanagedType.LPWStr)] string lpsz);
    [DllImport(lib,EntryPoint="CharNextW",SetLastError=true,ExactSpelling=true)]public static extern
        string CharNext(char* lpsz);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        char* CharNextW_([MarshalAs(UnmanagedType.LPWStr)] string lpsz);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        char* CharNextW_(char* lpsz);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        string CharNextW([MarshalAs(UnmanagedType.LPWStr)] string lpsz);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        string CharNextW(char* lpsz);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        byte* CharPrevA_([MarshalAs(UnmanagedType.LPStr)] string lpszStart, [MarshalAs(UnmanagedType.LPStr)] string lpszCurrent);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        byte* CharPrevA_([MarshalAs(UnmanagedType.LPStr)] string lpszStart, byte* lpszCurrent);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        byte* CharPrevA_(byte* lpszStart, [MarshalAs(UnmanagedType.LPStr)] string lpszCurrent);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        byte* CharPrevA_(byte* lpszStart, byte* lpszCurrent);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        ReadOnlySpan<byte> CharPrevA([MarshalAs(UnmanagedType.LPStr)] string lpszStart, [MarshalAs(UnmanagedType.LPStr)] string lpszCurrent);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        ReadOnlySpan<byte> CharPrevA([MarshalAs(UnmanagedType.LPStr)] string lpszStart, byte* lpszCurrent);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        ReadOnlySpan<byte> CharPrevA(byte* lpszStart, [MarshalAs(UnmanagedType.LPStr)] string lpszCurrent);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        ReadOnlySpan<byte> CharPrevA(byte* lpszStart, byte* lpszCurrent);
    [DllImport(lib,EntryPoint="CharPrevW",SetLastError=true,ExactSpelling=true)]public static extern
        char* CharPrev_([MarshalAs(UnmanagedType.LPWStr)] string lpszStart, [MarshalAs(UnmanagedType.LPWStr)] string lpszCurrent);
    [DllImport(lib,EntryPoint="CharPrevW",SetLastError=true,ExactSpelling=true)]public static extern
        char* CharPrev_([MarshalAs(UnmanagedType.LPWStr)] string lpszStart, char* lpszCurrent);
    [DllImport(lib,EntryPoint="CharPrevW",SetLastError=true,ExactSpelling=true)]public static extern
        char* CharPrev_(char* lpszStart, [MarshalAs(UnmanagedType.LPWStr)] string lpszCurrent);
    [DllImport(lib,EntryPoint="CharPrevW",SetLastError=true,ExactSpelling=true)]public static extern
        char* CharPrev_(char* lpszStart, char* lpszCurrent);
    [DllImport(lib,EntryPoint="CharPrevW",SetLastError=true,ExactSpelling=true)]public static extern
        string CharPrev([MarshalAs(UnmanagedType.LPWStr)] string lpszStart, [MarshalAs(UnmanagedType.LPWStr)] string lpszCurrent);
    [DllImport(lib,EntryPoint="CharPrevW",SetLastError=true,ExactSpelling=true)]public static extern
        string CharPrev([MarshalAs(UnmanagedType.LPWStr)] string lpszStart, char* lpszCurrent);
    [DllImport(lib,EntryPoint="CharPrevW",SetLastError=true,ExactSpelling=true)]public static extern
        string CharPrev(char* lpszStart, [MarshalAs(UnmanagedType.LPWStr)] string lpszCurrent);
    [DllImport(lib,EntryPoint="CharPrevW",SetLastError=true,ExactSpelling=true)]public static extern
        string CharPrev(char* lpszStart, char* lpszCurrent);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        char* CharPrevW_([MarshalAs(UnmanagedType.LPWStr)] string lpszStart, [MarshalAs(UnmanagedType.LPWStr)] string lpszCurrent);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        char* CharPrevW_([MarshalAs(UnmanagedType.LPWStr)] string lpszStart, char* lpszCurrent);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        char* CharPrevW_(char* lpszStart, [MarshalAs(UnmanagedType.LPWStr)] string lpszCurrent);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        char* CharPrevW_(char* lpszStart, char* lpszCurrent);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        string CharPrevW([MarshalAs(UnmanagedType.LPWStr)] string lpszStart, [MarshalAs(UnmanagedType.LPWStr)] string lpszCurrent);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        string CharPrevW([MarshalAs(UnmanagedType.LPWStr)] string lpszStart, char* lpszCurrent);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        string CharPrevW(char* lpszStart, [MarshalAs(UnmanagedType.LPWStr)] string lpszCurrent);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        string CharPrevW(char* lpszStart, char* lpszCurrent);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        byte* CharNextExA_(short CodePage, [MarshalAs(UnmanagedType.LPStr)] string lpCurrentChar, int dwFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        byte* CharNextExA_(short CodePage, byte* lpCurrentChar, int dwFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        ReadOnlySpan<byte> CharNextExA(short CodePage, [MarshalAs(UnmanagedType.LPStr)] string lpCurrentChar, int dwFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        ReadOnlySpan<byte> CharNextExA(short CodePage, byte* lpCurrentChar, int dwFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        byte* CharPrevExA_(short CodePage, [MarshalAs(UnmanagedType.LPStr)] string lpStart, [MarshalAs(UnmanagedType.LPStr)] string lpCurrentChar, int dwFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        byte* CharPrevExA_(short CodePage, [MarshalAs(UnmanagedType.LPStr)] string lpStart, byte* lpCurrentChar, int dwFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        byte* CharPrevExA_(short CodePage, byte* lpStart, [MarshalAs(UnmanagedType.LPStr)] string lpCurrentChar, int dwFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        byte* CharPrevExA_(short CodePage, byte* lpStart, byte* lpCurrentChar, int dwFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        ReadOnlySpan<byte> CharPrevExA(short CodePage, [MarshalAs(UnmanagedType.LPStr)] string lpStart, [MarshalAs(UnmanagedType.LPStr)] string lpCurrentChar, int dwFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        ReadOnlySpan<byte> CharPrevExA(short CodePage, [MarshalAs(UnmanagedType.LPStr)] string lpStart, byte* lpCurrentChar, int dwFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        ReadOnlySpan<byte> CharPrevExA(short CodePage, byte* lpStart, [MarshalAs(UnmanagedType.LPStr)] string lpCurrentChar, int dwFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        ReadOnlySpan<byte> CharPrevExA(short CodePage, byte* lpStart, byte* lpCurrentChar, int dwFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool IsCharAlphaA(byte ch);
    [DllImport(lib,EntryPoint="IsCharAlphaW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool IsCharAlpha(char ch);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool IsCharAlphaW(char ch);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool IsCharAlphaNumericA(byte ch);
    [DllImport(lib,EntryPoint="IsCharAlphaNumericW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool IsCharAlphaNumeric(char ch);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool IsCharAlphaNumericW(char ch);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool IsCharUpperA(byte ch);
    [DllImport(lib,EntryPoint="IsCharUpperW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool IsCharUpper(char ch);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool IsCharUpperW(char ch);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool IsCharLowerA(byte ch);
    [DllImport(lib,EntryPoint="IsCharLowerW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool IsCharLower(char ch);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool IsCharLowerW(char ch);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer SetFocus(cpointer hWnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetActiveWindow();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetFocus();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint GetKBCodePage();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        short GetKeyState(int nVirtKey);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        short GetAsyncKeyState(int vKey);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetKeyboardState(cpointer unfoundType_PBYTE_lpKeyState);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetKeyboardState(cpointer unfoundType_LPBYTE_lpKeyState);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetKeyNameTextA(int lParam, [MarshalAs(UnmanagedType.LPStr)] string lpString, int cchSize);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetKeyNameTextA(int lParam, ReadOnlySpan<byte> lpString, int cchSize);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetKeyNameTextA(int lParam, byte* lpString, int cchSize);
    [DllImport(lib,EntryPoint="GetKeyNameTextW",SetLastError=true,ExactSpelling=true)]public static extern
        int GetKeyNameText(int lParam, string lpString, int cchSize);
    [DllImport(lib,EntryPoint="GetKeyNameTextW",SetLastError=true,ExactSpelling=true)]public static extern
        int GetKeyNameText(int lParam, char* lpString, int cchSize);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetKeyNameTextW(int lParam, string lpString, int cchSize);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetKeyNameTextW(int lParam, char* lpString, int cchSize);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetKeyboardType(int nTypeFlag);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int ToAscii(uint uVirtKey, uint uScanCode, cpointer unfoundType_BYTElpKeyStatelpKeyState_unnamed_2, cpointer unfoundType_LPWORD_lpChar, uint uFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int ToAsciiEx(uint uVirtKey, uint uScanCode, cpointer unfoundType_BYTElpKeyStatelpKeyState_unnamed_2, cpointer unfoundType_LPWORD_lpChar, uint uFlags, cpointer unfoundType_HKL_dwhkl);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int ToUnicode(uint wVirtKey, uint wScanCode, cpointer unfoundType_BYTElpKeyStatelpKeyState_unnamed_2, string pwszBuff, int cchBuff, uint wFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int ToUnicode(uint wVirtKey, uint wScanCode, cpointer unfoundType_BYTElpKeyStatelpKeyState_unnamed_2, char* pwszBuff, int cchBuff, uint wFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int OemKeyScan(short wOemChar);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        short VkKeyScanA(byte ch);
    [DllImport(lib,EntryPoint="VkKeyScanW",SetLastError=true,ExactSpelling=true)]public static extern
        short VkKeyScan(char ch);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        short VkKeyScanW(char ch);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        short VkKeyScanExA(byte ch, cpointer unfoundType_HKL_dwhkl);
    [DllImport(lib,EntryPoint="VkKeyScanExW",SetLastError=true,ExactSpelling=true)]public static extern
        short VkKeyScanEx(char ch, cpointer unfoundType_HKL_dwhkl);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        short VkKeyScanExW(char ch, cpointer unfoundType_HKL_dwhkl);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        void keybd_event(byte bVk, byte bScan, int dwFlags, cpointer unfoundType_ULONG_PTR_dwExtraInfo);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        void mouse_event(int dwFlags, int dx, int dy, int dwData, cpointer unfoundType_ULONG_PTR_dwExtraInfo);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint SendInput(uint cInputs, cpointer unfoundType_LPINPUT_pInputs, int cbSize);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetTouchInputInfo(cpointer unfoundType_HTOUCHINPUT_hTouchInput);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CloseTouchInputHandle(cpointer unfoundType_HTOUCHINPUT_hTouchInput);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool RegisterTouchWindow(cpointer hwnd, uint ulFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool UnregisterTouchWindow(cpointer hwnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool IsTouchWindow(cpointer hwnd, cpointer unfoundType_PULONG_pulFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool InitializeTouchInjection(uint maxCount, int dwMode);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool InjectTouchInput(uint count, cpointer unfoundType_POINTER_TOUCH_INFOcontactscontacts_unnamed_1);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetPointerType(uint pointerId, cpointer unfoundType_POINTER_INPUT_TYPEpointerTypepointerType_unnamed_1);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetPointerCursorId(uint pointerId, cpointer unfoundType_UINT32cursorIdcursorId_unnamed_1);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetPointerInfo(uint pointerId, cpointer unfoundType_POINTER_INFOpointerInfopointerInfo_unnamed_1);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetPointerInfoHistory(uint pointerId, cpointer unfoundType_UINT32entriesCountentriesCount_unnamed_1, cpointer unfoundType_POINTER_INFOpointerInfopointerInfo_unnamed_2);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetPointerFrameInfo(uint pointerId, cpointer unfoundType_UINT32pointerCountpointerCount_unnamed_1, cpointer unfoundType_POINTER_INFOpointerInfopointerInfo_unnamed_2);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetPointerFrameInfoHistory(uint pointerId, cpointer unfoundType_UINT32entriesCountentriesCount_unnamed_1, cpointer unfoundType_UINT32pointerCountpointerCount_unnamed_2, cpointer unfoundType_POINTER_INFOpointerInfopointerInfo_unnamed_3);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetPointerTouchInfo(uint pointerId, cpointer unfoundType_POINTER_TOUCH_INFOtouchInfotouchInfo_unnamed_1);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetPointerTouchInfoHistory(uint pointerId, cpointer unfoundType_UINT32entriesCountentriesCount_unnamed_1, cpointer unfoundType_POINTER_TOUCH_INFOtouchInfotouchInfo_unnamed_2);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetPointerFrameTouchInfo(uint pointerId, cpointer unfoundType_UINT32pointerCountpointerCount_unnamed_1, cpointer unfoundType_POINTER_TOUCH_INFOtouchInfotouchInfo_unnamed_2);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetPointerFrameTouchInfoHistory(uint pointerId, cpointer unfoundType_UINT32entriesCountentriesCount_unnamed_1, cpointer unfoundType_UINT32pointerCountpointerCount_unnamed_2, cpointer unfoundType_POINTER_TOUCH_INFOtouchInfotouchInfo_unnamed_3);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetPointerPenInfo(uint pointerId, cpointer unfoundType_POINTER_PEN_INFOpenInfopenInfo_unnamed_1);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetPointerPenInfoHistory(uint pointerId, cpointer unfoundType_UINT32entriesCountentriesCount_unnamed_1, cpointer unfoundType_POINTER_PEN_INFOpenInfopenInfo_unnamed_2);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetPointerFramePenInfo(uint pointerId, cpointer unfoundType_UINT32pointerCountpointerCount_unnamed_1, cpointer unfoundType_POINTER_PEN_INFOpenInfopenInfo_unnamed_2);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetPointerFramePenInfoHistory(uint pointerId, cpointer unfoundType_UINT32entriesCountentriesCount_unnamed_1, cpointer unfoundType_UINT32pointerCountpointerCount_unnamed_2, cpointer unfoundType_POINTER_PEN_INFOpenInfopenInfo_unnamed_3);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SkipPointerFrameMessages(uint pointerId);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool RegisterPointerInputTarget(cpointer hwnd, cpointer unfoundType_POINTER_INPUT_TYPE_pointerType);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool UnregisterPointerInputTarget(cpointer hwnd, cpointer unfoundType_POINTER_INPUT_TYPE_pointerType);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool RegisterPointerInputTargetEx(cpointer hwnd, cpointer unfoundType_POINTER_INPUT_TYPE_pointerType, bool fObserve);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool UnregisterPointerInputTargetEx(cpointer hwnd, cpointer unfoundType_POINTER_INPUT_TYPE_pointerType);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateSyntheticPointerDevice(cpointer unfoundType_POINTER_INPUT_TYPE_pointerType, uint maxCount, cpointer unfoundType_POINTER_FEEDBACK_MODE_mode);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool InjectSyntheticPointerInput(cpointer unfoundType_HSYNTHETICPOINTERDEVICE_device, cpointer unfoundType_POINTER_TYPE_INFO_pointerInfo, uint count);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        void DestroySyntheticPointerDevice(cpointer unfoundType_HSYNTHETICPOINTERDEVICE_device);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EnableMouseInPointer(bool fEnable);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool IsMouseInPointerEnabled();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool RegisterTouchHitTestingWindow(cpointer hwnd, uint value);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EvaluateProximityToRect(cpointer unfoundType_RECTcontrolBoundingBoxcontrolBoundingBox_unnamed_0, cpointer unfoundType_TOUCH_HIT_TESTING_INPUTpHitTestingInputpHitTestingInput_unnamed_1, cpointer unfoundType_TOUCH_HIT_TESTING_PROXIMITY_EVALUATIONpProximityEvalpProximityEval_unnamed_2);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EvaluateProximityToPolygon(uint numVertices, cpointer unfoundType_POINTcontrolPolygoncontrolPolygon_unnamed_1, cpointer unfoundType_TOUCH_HIT_TESTING_INPUTpHitTestingInputpHitTestingInput_unnamed_2, cpointer unfoundType_TOUCH_HIT_TESTING_PROXIMITY_EVALUATIONpProximityEvalpProximityEval_unnamed_3);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        long PackTouchHitTestingProximityEvaluation(cpointer unfoundType_TOUCH_HIT_TESTING_INPUTpHitTestingInputpHitTestingInput_unnamed_0, cpointer unfoundType_TOUCH_HIT_TESTING_PROXIMITY_EVALUATIONpProximityEvalpProximityEval_unnamed_1);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetWindowFeedbackSetting(cpointer hwnd, cpointer unfoundType_FEEDBACK_TYPE_feedback, int dwFlags, cpointer pSize, cpointer config);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetWindowFeedbackSetting(cpointer hwnd, cpointer unfoundType_FEEDBACK_TYPE_feedback, int dwFlags, uint size, cpointer configuration);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetPointerInputTransform(uint pointerId, uint historyCount, cpointer unfoundType_INPUT_TRANSFORMinputTransforminputTransform_unnamed_2);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetLastInputInfo(cpointer unfoundType_PLASTINPUTINFO_plii);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint MapVirtualKeyA(uint uCode, uint uMapType);
    [DllImport(lib,EntryPoint="MapVirtualKeyW",SetLastError=true,ExactSpelling=true)]public static extern
        uint MapVirtualKey(uint uCode, uint uMapType);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint MapVirtualKeyW(uint uCode, uint uMapType);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint MapVirtualKeyExA(uint uCode, uint uMapType, cpointer unfoundType_HKL_dwhkl);
    [DllImport(lib,EntryPoint="MapVirtualKeyExW",SetLastError=true,ExactSpelling=true)]public static extern
        uint MapVirtualKeyEx(uint uCode, uint uMapType, cpointer unfoundType_HKL_dwhkl);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint MapVirtualKeyExW(uint uCode, uint uMapType, cpointer unfoundType_HKL_dwhkl);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetInputState();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetQueueStatus(uint flags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetCapture();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer SetCapture(cpointer hWnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool ReleaseCapture();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int MsgWaitForMultipleObjects(int nCount, cpointer unfoundType_HANDLEpHandlespHandles_unnamed_1, bool fWaitAll, int dwMilliseconds, int dwWakeMask);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int MsgWaitForMultipleObjectsEx(int nCount, cpointer unfoundType_HANDLEpHandlespHandles_unnamed_1, int dwMilliseconds, int dwWakeMask, int dwFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        ulong SetTimer(cpointer hWnd, ulong nIDEvent, uint uElapse, cpointer unfoundType_TIMERPROC_lpTimerFunc);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        ulong SetCoalescableTimer(cpointer hWnd, ulong nIDEvent, uint uElapse, cpointer unfoundType_TIMERPROC_lpTimerFunc, uint uToleranceDelay);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool KillTimer(cpointer hWnd, ulong uIDEvent);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool IsWindowUnicode(cpointer hWnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EnableWindow(cpointer hWnd, bool bEnable);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool IsWindowEnabled(cpointer hWnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadAcceleratorsA(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPStr)] string lpTableName);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadAcceleratorsA(cpointer unfoundType_HINSTANCE_hInstance, byte* lpTableName);
    [DllImport(lib,EntryPoint="LoadAcceleratorsW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadAccelerators(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpTableName);
    [DllImport(lib,EntryPoint="LoadAcceleratorsW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadAccelerators(cpointer unfoundType_HINSTANCE_hInstance, char* lpTableName);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadAcceleratorsW(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpTableName);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadAcceleratorsW(cpointer unfoundType_HINSTANCE_hInstance, char* lpTableName);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateAcceleratorTableA(cpointer unfoundType_LPACCEL_paccel, int cAccel);
    [DllImport(lib,EntryPoint="CreateAcceleratorTableW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateAcceleratorTable(cpointer unfoundType_LPACCEL_paccel, int cAccel);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateAcceleratorTableW(cpointer unfoundType_LPACCEL_paccel, int cAccel);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DestroyAcceleratorTable(cpointer hAccel);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int CopyAcceleratorTableA(cpointer hAccelSrc, cpointer unfoundType_LPACCEL_lpAccelDst, int cAccelEntries);
    [DllImport(lib,EntryPoint="CopyAcceleratorTableW",SetLastError=true,ExactSpelling=true)]public static extern
        int CopyAcceleratorTable(cpointer hAccelSrc, cpointer unfoundType_LPACCEL_lpAccelDst, int cAccelEntries);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int CopyAcceleratorTableW(cpointer hAccelSrc, cpointer unfoundType_LPACCEL_lpAccelDst, int cAccelEntries);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int TranslateAcceleratorA(cpointer hWnd, cpointer hAccTable, cpointer unfoundType_LPMSG_lpMsg);
    [DllImport(lib,EntryPoint="TranslateAcceleratorW",SetLastError=true,ExactSpelling=true)]public static extern
        int TranslateAccelerator(cpointer hWnd, cpointer hAccTable, cpointer unfoundType_LPMSG_lpMsg);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int TranslateAcceleratorW(cpointer hWnd, cpointer hAccTable, cpointer unfoundType_LPMSG_lpMsg);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetSystemMetrics(int nIndex);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetSystemMetricsForDpi(int nIndex, uint dpi);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadMenuA(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPStr)] string lpMenuName);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadMenuA(cpointer unfoundType_HINSTANCE_hInstance, byte* lpMenuName);
    [DllImport(lib,EntryPoint="LoadMenuW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadMenu(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpMenuName);
    [DllImport(lib,EntryPoint="LoadMenuW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadMenu(cpointer unfoundType_HINSTANCE_hInstance, char* lpMenuName);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadMenuW(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpMenuName);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadMenuW(cpointer unfoundType_HINSTANCE_hInstance, char* lpMenuName);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadMenuIndirectA(cpointer unfoundType_MENUTEMPLATEAlpMenuTemplatelpMenuTemplate_unnamed_0);
    [DllImport(lib,EntryPoint="LoadMenuIndirectW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadMenuIndirect(cpointer unfoundType_MENUTEMPLATEWlpMenuTemplatelpMenuTemplate_unnamed_0);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadMenuIndirectW(cpointer unfoundType_MENUTEMPLATEWlpMenuTemplatelpMenuTemplate_unnamed_0);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetMenu(cpointer hWnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetMenu(cpointer hWnd, cpointer hMenu);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool ChangeMenuA(cpointer hMenu, uint cmd, [MarshalAs(UnmanagedType.LPStr)] string lpszNewItem, uint cmdInsert, uint flags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool ChangeMenuA(cpointer hMenu, uint cmd, byte* lpszNewItem, uint cmdInsert, uint flags);
    [DllImport(lib,EntryPoint="ChangeMenuW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool ChangeMenu(cpointer hMenu, uint cmd, [MarshalAs(UnmanagedType.LPWStr)] string lpszNewItem, uint cmdInsert, uint flags);
    [DllImport(lib,EntryPoint="ChangeMenuW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool ChangeMenu(cpointer hMenu, uint cmd, char* lpszNewItem, uint cmdInsert, uint flags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool ChangeMenuW(cpointer hMenu, uint cmd, [MarshalAs(UnmanagedType.LPWStr)] string lpszNewItem, uint cmdInsert, uint flags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool ChangeMenuW(cpointer hMenu, uint cmd, char* lpszNewItem, uint cmdInsert, uint flags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool HiliteMenuItem(cpointer hWnd, cpointer hMenu, uint uIDHiliteItem, uint uHilite);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetMenuStringA(cpointer hMenu, uint uIDItem, [MarshalAs(UnmanagedType.LPStr)] string lpString, int cchMax, uint flags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetMenuStringA(cpointer hMenu, uint uIDItem, ReadOnlySpan<byte> lpString, int cchMax, uint flags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetMenuStringA(cpointer hMenu, uint uIDItem, byte* lpString, int cchMax, uint flags);
    [DllImport(lib,EntryPoint="GetMenuStringW",SetLastError=true,ExactSpelling=true)]public static extern
        int GetMenuString(cpointer hMenu, uint uIDItem, string lpString, int cchMax, uint flags);
    [DllImport(lib,EntryPoint="GetMenuStringW",SetLastError=true,ExactSpelling=true)]public static extern
        int GetMenuString(cpointer hMenu, uint uIDItem, char* lpString, int cchMax, uint flags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetMenuStringW(cpointer hMenu, uint uIDItem, string lpString, int cchMax, uint flags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetMenuStringW(cpointer hMenu, uint uIDItem, char* lpString, int cchMax, uint flags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint GetMenuState(cpointer hMenu, uint uId, uint uFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DrawMenuBar(cpointer hWnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetSystemMenu(cpointer hWnd, bool bRevert);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateMenu();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreatePopupMenu();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DestroyMenu(cpointer hMenu);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int CheckMenuItem(cpointer hMenu, uint uIDCheckItem, uint uCheck);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EnableMenuItem(cpointer hMenu, uint uIDEnableItem, uint uEnable);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetSubMenu(cpointer hMenu, int nPos);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint GetMenuItemID(cpointer hMenu, int nPos);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetMenuItemCount(cpointer hMenu);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool InsertMenuA(cpointer hMenu, uint uPosition, uint uFlags, ulong uIDNewItem, [MarshalAs(UnmanagedType.LPStr)] string lpNewItem);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool InsertMenuA(cpointer hMenu, uint uPosition, uint uFlags, ulong uIDNewItem, byte* lpNewItem);
    [DllImport(lib,EntryPoint="InsertMenuW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool InsertMenu(cpointer hMenu, uint uPosition, uint uFlags, ulong uIDNewItem, [MarshalAs(UnmanagedType.LPWStr)] string lpNewItem);
    [DllImport(lib,EntryPoint="InsertMenuW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool InsertMenu(cpointer hMenu, uint uPosition, uint uFlags, ulong uIDNewItem, char* lpNewItem);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool InsertMenuW(cpointer hMenu, uint uPosition, uint uFlags, ulong uIDNewItem, [MarshalAs(UnmanagedType.LPWStr)] string lpNewItem);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool InsertMenuW(cpointer hMenu, uint uPosition, uint uFlags, ulong uIDNewItem, char* lpNewItem);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool AppendMenuA(cpointer hMenu, uint uFlags, ulong uIDNewItem, [MarshalAs(UnmanagedType.LPStr)] string lpNewItem);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool AppendMenuA(cpointer hMenu, uint uFlags, ulong uIDNewItem, byte* lpNewItem);
    [DllImport(lib,EntryPoint="AppendMenuW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool AppendMenu(cpointer hMenu, uint uFlags, ulong uIDNewItem, [MarshalAs(UnmanagedType.LPWStr)] string lpNewItem);
    [DllImport(lib,EntryPoint="AppendMenuW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool AppendMenu(cpointer hMenu, uint uFlags, ulong uIDNewItem, char* lpNewItem);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool AppendMenuW(cpointer hMenu, uint uFlags, ulong uIDNewItem, [MarshalAs(UnmanagedType.LPWStr)] string lpNewItem);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool AppendMenuW(cpointer hMenu, uint uFlags, ulong uIDNewItem, char* lpNewItem);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool ModifyMenuA(cpointer hMnu, uint uPosition, uint uFlags, ulong uIDNewItem, [MarshalAs(UnmanagedType.LPStr)] string lpNewItem);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool ModifyMenuA(cpointer hMnu, uint uPosition, uint uFlags, ulong uIDNewItem, byte* lpNewItem);
    [DllImport(lib,EntryPoint="ModifyMenuW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool ModifyMenu(cpointer hMnu, uint uPosition, uint uFlags, ulong uIDNewItem, [MarshalAs(UnmanagedType.LPWStr)] string lpNewItem);
    [DllImport(lib,EntryPoint="ModifyMenuW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool ModifyMenu(cpointer hMnu, uint uPosition, uint uFlags, ulong uIDNewItem, char* lpNewItem);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool ModifyMenuW(cpointer hMnu, uint uPosition, uint uFlags, ulong uIDNewItem, [MarshalAs(UnmanagedType.LPWStr)] string lpNewItem);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool ModifyMenuW(cpointer hMnu, uint uPosition, uint uFlags, ulong uIDNewItem, char* lpNewItem);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DeleteMenu(cpointer hMenu, uint uPosition, uint uFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetMenuItemBitmaps(cpointer hMenu, uint uPosition, uint uFlags, cpointer unfoundType_HBITMAP_hBitmapUnchecked, cpointer unfoundType_HBITMAP_hBitmapChecked);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetMenuCheckMarkDimensions();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool TrackPopupMenu(cpointer hMenu, uint uFlags, int x, int y, int nReserved, cpointer hWnd, cpointer unfoundType_RECTprcRectprcRect_unnamed_6);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool TrackPopupMenuEx(cpointer hMenu, uint uFlags, int x, int y, cpointer hwnd, cpointer unfoundType_LPTPMPARAMS_lptpm);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CalculatePopupWindowPosition(cpointer unfoundType_POINTanchorPointanchorPoint_unnamed_0, cpointer unfoundType_SIZEwindowSizewindowSize_unnamed_1, uint flags, cpointer unfoundType_RECTexcludeRectexcludeRect_unnamed_3, cpointer unfoundType_RECTpopupWindowPositionpopupWindowPosition_unnamed_4);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetMenuInfo(cpointer unnamed_0, cpointer unfoundType_LPMENUINFO_unnamed_1);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetMenuInfo(cpointer unnamed_0, cpointer unfoundType_LPCMENUINFO_unnamed_1);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EndMenu();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool InsertMenuItemA(cpointer hmenu, uint item, bool fByPosition, cpointer unfoundType_LPCMENUITEMINFOA_lpmi);
    [DllImport(lib,EntryPoint="InsertMenuItemW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool InsertMenuItem(cpointer hmenu, uint item, bool fByPosition, cpointer unfoundType_LPCMENUITEMINFOW_lpmi);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool InsertMenuItemW(cpointer hmenu, uint item, bool fByPosition, cpointer unfoundType_LPCMENUITEMINFOW_lpmi);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetMenuItemInfoA(cpointer hmenu, uint item, bool fByPosition, cpointer unfoundType_LPMENUITEMINFOA_lpmii);
    [DllImport(lib,EntryPoint="GetMenuItemInfoW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetMenuItemInfo(cpointer hmenu, uint item, bool fByPosition, cpointer unfoundType_LPMENUITEMINFOW_lpmii);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetMenuItemInfoW(cpointer hmenu, uint item, bool fByPosition, cpointer unfoundType_LPMENUITEMINFOW_lpmii);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetMenuItemInfoA(cpointer hmenu, uint item, bool fByPositon, cpointer unfoundType_LPCMENUITEMINFOA_lpmii);
    [DllImport(lib,EntryPoint="SetMenuItemInfoW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetMenuItemInfo(cpointer hmenu, uint item, bool fByPositon, cpointer unfoundType_LPCMENUITEMINFOW_lpmii);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetMenuItemInfoW(cpointer hmenu, uint item, bool fByPositon, cpointer unfoundType_LPCMENUITEMINFOW_lpmii);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint GetMenuDefaultItem(cpointer hMenu, uint fByPos, uint gmdiFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetMenuDefaultItem(cpointer hMenu, uint uItem, uint fByPos);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetMenuItemRect(cpointer hWnd, cpointer hMenu, uint uItem, cpointer unfoundType_LPRECT_lprcItem);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int MenuItemFromPoint(cpointer hWnd, cpointer hMenu, cpointer unfoundType_POINT_ptScreen);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int DragObject(cpointer hwndParent, cpointer hwndFrom, uint fmt, cpointer unfoundType_ULONG_PTR_data, cpointer unfoundType_HCURSOR_hcur);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DragDetect(cpointer hwnd, cpointer unfoundType_POINT_pt);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DrawIcon(cpointer hDC, int X, int Y, cpointer hIcon);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int DrawTextA(cpointer hdc, [MarshalAs(UnmanagedType.LPStr)] string lpchText, int cchText, cpointer unfoundType_LPRECT_lprc, uint format);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int DrawTextA(cpointer hdc, byte* lpchText, int cchText, cpointer unfoundType_LPRECT_lprc, uint format);
    [DllImport(lib,EntryPoint="DrawTextW",SetLastError=true,ExactSpelling=true)]public static extern
        int DrawText(cpointer hdc, [MarshalAs(UnmanagedType.LPWStr)] string lpchText, int cchText, cpointer unfoundType_LPRECT_lprc, uint format);
    [DllImport(lib,EntryPoint="DrawTextW",SetLastError=true,ExactSpelling=true)]public static extern
        int DrawText(cpointer hdc, char* lpchText, int cchText, cpointer unfoundType_LPRECT_lprc, uint format);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int DrawTextW(cpointer hdc, [MarshalAs(UnmanagedType.LPWStr)] string lpchText, int cchText, cpointer unfoundType_LPRECT_lprc, uint format);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int DrawTextW(cpointer hdc, char* lpchText, int cchText, cpointer unfoundType_LPRECT_lprc, uint format);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int DrawTextExA(cpointer hdc, [MarshalAs(UnmanagedType.LPStr)] string lpchText, int cchText, cpointer unfoundType_LPRECT_lprc, uint format, cpointer unfoundType_LPDRAWTEXTPARAMS_lpdtp);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int DrawTextExA(cpointer hdc, ReadOnlySpan<byte> lpchText, int cchText, cpointer unfoundType_LPRECT_lprc, uint format, cpointer unfoundType_LPDRAWTEXTPARAMS_lpdtp);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int DrawTextExA(cpointer hdc, byte* lpchText, int cchText, cpointer unfoundType_LPRECT_lprc, uint format, cpointer unfoundType_LPDRAWTEXTPARAMS_lpdtp);
    [DllImport(lib,EntryPoint="DrawTextExW",SetLastError=true,ExactSpelling=true)]public static extern
        int DrawTextEx(cpointer hdc, string lpchText, int cchText, cpointer unfoundType_LPRECT_lprc, uint format, cpointer unfoundType_LPDRAWTEXTPARAMS_lpdtp);
    [DllImport(lib,EntryPoint="DrawTextExW",SetLastError=true,ExactSpelling=true)]public static extern
        int DrawTextEx(cpointer hdc, char* lpchText, int cchText, cpointer unfoundType_LPRECT_lprc, uint format, cpointer unfoundType_LPDRAWTEXTPARAMS_lpdtp);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int DrawTextExW(cpointer hdc, string lpchText, int cchText, cpointer unfoundType_LPRECT_lprc, uint format, cpointer unfoundType_LPDRAWTEXTPARAMS_lpdtp);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int DrawTextExW(cpointer hdc, char* lpchText, int cchText, cpointer unfoundType_LPRECT_lprc, uint format, cpointer unfoundType_LPDRAWTEXTPARAMS_lpdtp);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GrayStringA(cpointer hDC, cpointer hBrush, cpointer unfoundType_GRAYSTRINGPROC_lpOutputFunc, long lpData, int nCount, int X, int Y, int nWidth, int nHeight);
    [DllImport(lib,EntryPoint="GrayStringW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GrayString(cpointer hDC, cpointer hBrush, cpointer unfoundType_GRAYSTRINGPROC_lpOutputFunc, long lpData, int nCount, int X, int Y, int nWidth, int nHeight);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GrayStringW(cpointer hDC, cpointer hBrush, cpointer unfoundType_GRAYSTRINGPROC_lpOutputFunc, long lpData, int nCount, int X, int Y, int nWidth, int nHeight);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DrawStateA(cpointer hdc, cpointer hbrFore, cpointer unfoundType_DRAWSTATEPROC_qfnCallBack, long lData, ulong wData, int x, int y, int cx, int cy, uint uFlags);
    [DllImport(lib,EntryPoint="DrawStateW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DrawState(cpointer hdc, cpointer hbrFore, cpointer unfoundType_DRAWSTATEPROC_qfnCallBack, long lData, ulong wData, int x, int y, int cx, int cy, uint uFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DrawStateW(cpointer hdc, cpointer hbrFore, cpointer unfoundType_DRAWSTATEPROC_qfnCallBack, long lData, ulong wData, int x, int y, int cx, int cy, uint uFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int TabbedTextOutA(cpointer hdc, int x, int y, [MarshalAs(UnmanagedType.LPStr)] string lpString, int chCount, int nTabPositions, cpointer unfoundType_INTlpnTabStopPositionslpnTabStopPositions_unnamed_6, int nTabOrigin);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int TabbedTextOutA(cpointer hdc, int x, int y, byte* lpString, int chCount, int nTabPositions, cpointer unfoundType_INTlpnTabStopPositionslpnTabStopPositions_unnamed_6, int nTabOrigin);
    [DllImport(lib,EntryPoint="TabbedTextOutW",SetLastError=true,ExactSpelling=true)]public static extern
        int TabbedTextOut(cpointer hdc, int x, int y, [MarshalAs(UnmanagedType.LPWStr)] string lpString, int chCount, int nTabPositions, cpointer unfoundType_INTlpnTabStopPositionslpnTabStopPositions_unnamed_6, int nTabOrigin);
    [DllImport(lib,EntryPoint="TabbedTextOutW",SetLastError=true,ExactSpelling=true)]public static extern
        int TabbedTextOut(cpointer hdc, int x, int y, char* lpString, int chCount, int nTabPositions, cpointer unfoundType_INTlpnTabStopPositionslpnTabStopPositions_unnamed_6, int nTabOrigin);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int TabbedTextOutW(cpointer hdc, int x, int y, [MarshalAs(UnmanagedType.LPWStr)] string lpString, int chCount, int nTabPositions, cpointer unfoundType_INTlpnTabStopPositionslpnTabStopPositions_unnamed_6, int nTabOrigin);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int TabbedTextOutW(cpointer hdc, int x, int y, char* lpString, int chCount, int nTabPositions, cpointer unfoundType_INTlpnTabStopPositionslpnTabStopPositions_unnamed_6, int nTabOrigin);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetTabbedTextExtentA(cpointer hdc, [MarshalAs(UnmanagedType.LPStr)] string lpString, int chCount, int nTabPositions, cpointer unfoundType_INTlpnTabStopPositionslpnTabStopPositions_unnamed_4);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetTabbedTextExtentA(cpointer hdc, byte* lpString, int chCount, int nTabPositions, cpointer unfoundType_INTlpnTabStopPositionslpnTabStopPositions_unnamed_4);
    [DllImport(lib,EntryPoint="GetTabbedTextExtentW",SetLastError=true,ExactSpelling=true)]public static extern
        int GetTabbedTextExtent(cpointer hdc, [MarshalAs(UnmanagedType.LPWStr)] string lpString, int chCount, int nTabPositions, cpointer unfoundType_INTlpnTabStopPositionslpnTabStopPositions_unnamed_4);
    [DllImport(lib,EntryPoint="GetTabbedTextExtentW",SetLastError=true,ExactSpelling=true)]public static extern
        int GetTabbedTextExtent(cpointer hdc, char* lpString, int chCount, int nTabPositions, cpointer unfoundType_INTlpnTabStopPositionslpnTabStopPositions_unnamed_4);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetTabbedTextExtentW(cpointer hdc, [MarshalAs(UnmanagedType.LPWStr)] string lpString, int chCount, int nTabPositions, cpointer unfoundType_INTlpnTabStopPositionslpnTabStopPositions_unnamed_4);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetTabbedTextExtentW(cpointer hdc, char* lpString, int chCount, int nTabPositions, cpointer unfoundType_INTlpnTabStopPositionslpnTabStopPositions_unnamed_4);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool UpdateWindow(cpointer hWnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer SetActiveWindow(cpointer hWnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetForegroundWindow();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool PaintDesktop(cpointer hdc);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        void SwitchToThisWindow(cpointer hwnd, bool fUnknown);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetForegroundWindow(cpointer hWnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool AllowSetForegroundWindow(int dwProcessId);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool LockSetForegroundWindow(uint uLockCode);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer WindowFromDC(cpointer hDC);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetDC(cpointer hWnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetDCEx(cpointer hWnd, cpointer hrgnClip, int flags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetWindowDC(cpointer hWnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int ReleaseDC(cpointer hWnd, cpointer hDC);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer BeginPaint(cpointer hWnd, cpointer unfoundType_LPPAINTSTRUCT_lpPaint);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EndPaint(cpointer hWnd, cpointer unfoundType_PAINTSTRUCTlpPaintlpPaint_unnamed_1);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetUpdateRect(cpointer hWnd, cpointer unfoundType_LPRECT_lpRect, bool bErase);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetUpdateRgn(cpointer hWnd, cpointer hRgn, bool bErase);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int SetWindowRgn(cpointer hWnd, cpointer hRgn, bool bRedraw);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetWindowRgn(cpointer hWnd, cpointer hRgn);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetWindowRgnBox(cpointer hWnd, cpointer unfoundType_LPRECT_lprc);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int ExcludeUpdateRgn(cpointer hDC, cpointer hWnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool InvalidateRect(cpointer hWnd, cpointer unfoundType_RECTlpRectlpRect_unnamed_1, bool bErase);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool ValidateRect(cpointer hWnd, cpointer unfoundType_RECTlpRectlpRect_unnamed_1);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool InvalidateRgn(cpointer hWnd, cpointer hRgn, bool bErase);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool ValidateRgn(cpointer hWnd, cpointer hRgn);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool RedrawWindow(cpointer hWnd, cpointer unfoundType_RECTlprcUpdatelprcUpdate_unnamed_1, cpointer hrgnUpdate, uint flags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool LockWindowUpdate(cpointer hWndLock);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool ScrollWindow(cpointer hWnd, int XAmount, int YAmount, cpointer unfoundType_RECTlpRectlpRect_unnamed_3, cpointer unfoundType_RECTlpClipRectlpClipRect_unnamed_4);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool ScrollDC(cpointer hDC, int dx, int dy, cpointer unfoundType_RECTlprcScrolllprcScroll_unnamed_3, cpointer unfoundType_RECTlprcCliplprcClip_unnamed_4, cpointer hrgnUpdate, cpointer unfoundType_LPRECT_lprcUpdate);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int ScrollWindowEx(cpointer hWnd, int dx, int dy, cpointer unfoundType_RECTprcScrollprcScroll_unnamed_3, cpointer unfoundType_RECTprcClipprcClip_unnamed_4, cpointer hrgnUpdate, cpointer unfoundType_LPRECT_prcUpdate, uint flags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int SetScrollPos(cpointer hWnd, int nBar, int nPos, bool bRedraw);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetScrollPos(cpointer hWnd, int nBar);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetScrollRange(cpointer hWnd, int nBar, int nMinPos, int nMaxPos, bool bRedraw);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetScrollRange(cpointer hWnd, int nBar, cpointer unfoundType_LPINT_lpMinPos, cpointer unfoundType_LPINT_lpMaxPos);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool ShowScrollBar(cpointer hWnd, int wBar, bool bShow);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EnableScrollBar(cpointer hWnd, uint wSBflags, uint wArrows);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetPropA(cpointer hWnd, [MarshalAs(UnmanagedType.LPStr)] string lpString, cpointer hData);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetPropA(cpointer hWnd, byte* lpString, cpointer hData);
    [DllImport(lib,EntryPoint="SetPropW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetProp(cpointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpString, cpointer hData);
    [DllImport(lib,EntryPoint="SetPropW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetProp(cpointer hWnd, char* lpString, cpointer hData);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetPropW(cpointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpString, cpointer hData);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetPropW(cpointer hWnd, char* lpString, cpointer hData);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetPropA(cpointer hWnd, [MarshalAs(UnmanagedType.LPStr)] string lpString);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetPropA(cpointer hWnd, byte* lpString);
    [DllImport(lib,EntryPoint="GetPropW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetProp(cpointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport(lib,EntryPoint="GetPropW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetProp(cpointer hWnd, char* lpString);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetPropW(cpointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetPropW(cpointer hWnd, char* lpString);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer RemovePropA(cpointer hWnd, [MarshalAs(UnmanagedType.LPStr)] string lpString);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer RemovePropA(cpointer hWnd, byte* lpString);
    [DllImport(lib,EntryPoint="RemovePropW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer RemoveProp(cpointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport(lib,EntryPoint="RemovePropW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer RemoveProp(cpointer hWnd, char* lpString);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer RemovePropW(cpointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer RemovePropW(cpointer hWnd, char* lpString);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int EnumPropsExA(cpointer hWnd, cpointer unfoundType_PROPENUMPROCEXA_lpEnumFunc, long lParam);
    [DllImport(lib,EntryPoint="EnumPropsExW",SetLastError=true,ExactSpelling=true)]public static extern
        int EnumPropsEx(cpointer hWnd, cpointer unfoundType_PROPENUMPROCEXW_lpEnumFunc, long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int EnumPropsExW(cpointer hWnd, cpointer unfoundType_PROPENUMPROCEXW_lpEnumFunc, long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int EnumPropsA(cpointer hWnd, cpointer unfoundType_PROPENUMPROCA_lpEnumFunc);
    [DllImport(lib,EntryPoint="EnumPropsW",SetLastError=true,ExactSpelling=true)]public static extern
        int EnumProps(cpointer hWnd, cpointer unfoundType_PROPENUMPROCW_lpEnumFunc);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int EnumPropsW(cpointer hWnd, cpointer unfoundType_PROPENUMPROCW_lpEnumFunc);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetWindowTextA(cpointer hWnd, [MarshalAs(UnmanagedType.LPStr)] string lpString);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetWindowTextA(cpointer hWnd, byte* lpString);
    [DllImport(lib,EntryPoint="SetWindowTextW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetWindowText(cpointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport(lib,EntryPoint="SetWindowTextW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetWindowText(cpointer hWnd, char* lpString);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetWindowTextW(cpointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetWindowTextW(cpointer hWnd, char* lpString);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetWindowTextA(cpointer hWnd, [MarshalAs(UnmanagedType.LPStr)] string lpString, int nMaxCount);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetWindowTextA(cpointer hWnd, ReadOnlySpan<byte> lpString, int nMaxCount);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetWindowTextA(cpointer hWnd, byte* lpString, int nMaxCount);
    [DllImport(lib,EntryPoint="GetWindowTextW",SetLastError=true,ExactSpelling=true)]public static extern
        int GetWindowText(cpointer hWnd, string lpString, int nMaxCount);
    [DllImport(lib,EntryPoint="GetWindowTextW",SetLastError=true,ExactSpelling=true)]public static extern
        int GetWindowText(cpointer hWnd, char* lpString, int nMaxCount);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetWindowTextW(cpointer hWnd, string lpString, int nMaxCount);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetWindowTextW(cpointer hWnd, char* lpString, int nMaxCount);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetWindowTextLengthA(cpointer hWnd);
    [DllImport(lib,EntryPoint="GetWindowTextLengthW",SetLastError=true,ExactSpelling=true)]public static extern
        int GetWindowTextLength(cpointer hWnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetWindowTextLengthW(cpointer hWnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetClientRect(cpointer hWnd, cpointer unfoundType_LPRECT_lpRect);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetWindowRect(cpointer hWnd, cpointer unfoundType_LPRECT_lpRect);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool AdjustWindowRect(cpointer unfoundType_LPRECT_lpRect, int dwStyle, bool bMenu);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool AdjustWindowRectEx(cpointer unfoundType_LPRECT_lpRect, int dwStyle, bool bMenu, int dwExStyle);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool AdjustWindowRectExForDpi(cpointer unfoundType_LPRECT_lpRect, int dwStyle, bool bMenu, int dwExStyle, uint dpi);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetWindowContextHelpId(cpointer unnamed_0, int unnamed_1);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetWindowContextHelpId(cpointer unnamed_0);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetMenuContextHelpId(cpointer unnamed_0, int unnamed_1);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetMenuContextHelpId(cpointer unnamed_0);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int MessageBoxA(cpointer hWnd, [MarshalAs(UnmanagedType.LPStr)] string lpText, [MarshalAs(UnmanagedType.LPStr)] string lpCaption, uint uType);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int MessageBoxA(cpointer hWnd, [MarshalAs(UnmanagedType.LPStr)] string lpText, byte* lpCaption, uint uType);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int MessageBoxA(cpointer hWnd, byte* lpText, [MarshalAs(UnmanagedType.LPStr)] string lpCaption, uint uType);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int MessageBoxA(cpointer hWnd, byte* lpText, byte* lpCaption, uint uType);
    [DllImport(lib,EntryPoint="MessageBoxW",SetLastError=true,ExactSpelling=true)]public static extern
        int MessageBox(cpointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpText, [MarshalAs(UnmanagedType.LPWStr)] string lpCaption, uint uType);
    [DllImport(lib,EntryPoint="MessageBoxW",SetLastError=true,ExactSpelling=true)]public static extern
        int MessageBox(cpointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpText, char* lpCaption, uint uType);
    [DllImport(lib,EntryPoint="MessageBoxW",SetLastError=true,ExactSpelling=true)]public static extern
        int MessageBox(cpointer hWnd, char* lpText, [MarshalAs(UnmanagedType.LPWStr)] string lpCaption, uint uType);
    [DllImport(lib,EntryPoint="MessageBoxW",SetLastError=true,ExactSpelling=true)]public static extern
        int MessageBox(cpointer hWnd, char* lpText, char* lpCaption, uint uType);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int MessageBoxW(cpointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpText, [MarshalAs(UnmanagedType.LPWStr)] string lpCaption, uint uType);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int MessageBoxW(cpointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpText, char* lpCaption, uint uType);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int MessageBoxW(cpointer hWnd, char* lpText, [MarshalAs(UnmanagedType.LPWStr)] string lpCaption, uint uType);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int MessageBoxW(cpointer hWnd, char* lpText, char* lpCaption, uint uType);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int MessageBoxExA(cpointer hWnd, [MarshalAs(UnmanagedType.LPStr)] string lpText, [MarshalAs(UnmanagedType.LPStr)] string lpCaption, uint uType, short wLanguageId);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int MessageBoxExA(cpointer hWnd, [MarshalAs(UnmanagedType.LPStr)] string lpText, byte* lpCaption, uint uType, short wLanguageId);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int MessageBoxExA(cpointer hWnd, byte* lpText, [MarshalAs(UnmanagedType.LPStr)] string lpCaption, uint uType, short wLanguageId);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int MessageBoxExA(cpointer hWnd, byte* lpText, byte* lpCaption, uint uType, short wLanguageId);
    [DllImport(lib,EntryPoint="MessageBoxExW",SetLastError=true,ExactSpelling=true)]public static extern
        int MessageBoxEx(cpointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpText, [MarshalAs(UnmanagedType.LPWStr)] string lpCaption, uint uType, short wLanguageId);
    [DllImport(lib,EntryPoint="MessageBoxExW",SetLastError=true,ExactSpelling=true)]public static extern
        int MessageBoxEx(cpointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpText, char* lpCaption, uint uType, short wLanguageId);
    [DllImport(lib,EntryPoint="MessageBoxExW",SetLastError=true,ExactSpelling=true)]public static extern
        int MessageBoxEx(cpointer hWnd, char* lpText, [MarshalAs(UnmanagedType.LPWStr)] string lpCaption, uint uType, short wLanguageId);
    [DllImport(lib,EntryPoint="MessageBoxExW",SetLastError=true,ExactSpelling=true)]public static extern
        int MessageBoxEx(cpointer hWnd, char* lpText, char* lpCaption, uint uType, short wLanguageId);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int MessageBoxExW(cpointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpText, [MarshalAs(UnmanagedType.LPWStr)] string lpCaption, uint uType, short wLanguageId);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int MessageBoxExW(cpointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpText, char* lpCaption, uint uType, short wLanguageId);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int MessageBoxExW(cpointer hWnd, char* lpText, [MarshalAs(UnmanagedType.LPWStr)] string lpCaption, uint uType, short wLanguageId);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int MessageBoxExW(cpointer hWnd, char* lpText, char* lpCaption, uint uType, short wLanguageId);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int MessageBoxIndirectA(cpointer unfoundType_MSGBOXPARAMSA_lpmbp);
    [DllImport(lib,EntryPoint="MessageBoxIndirectW",SetLastError=true,ExactSpelling=true)]public static extern
        int MessageBoxIndirect(cpointer unfoundType_MSGBOXPARAMSW_lpmbp);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int MessageBoxIndirectW(cpointer unfoundType_MSGBOXPARAMSW_lpmbp);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool MessageBeep(uint uType);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int ShowCursor(bool bShow);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetCursorPos(int X, int Y);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetPhysicalCursorPos(int X, int Y);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer SetCursor(cpointer unfoundType_HCURSOR_hCursor);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetCursorPos(cpointer unfoundType_LPPOINT_lpPoint);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetPhysicalCursorPos(cpointer unfoundType_LPPOINT_lpPoint);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetClipCursor(cpointer unfoundType_LPRECT_lpRect);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetCursor();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CreateCaret(cpointer hWnd, cpointer unfoundType_HBITMAP_hBitmap, int nWidth, int nHeight);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint GetCaretBlinkTime();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetCaretBlinkTime(uint uMSeconds);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DestroyCaret();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool HideCaret(cpointer hWnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool ShowCaret(cpointer hWnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetCaretPos(int X, int Y);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetCaretPos(cpointer unfoundType_LPPOINT_lpPoint);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool ClientToScreen(cpointer hWnd, cpointer unfoundType_LPPOINT_lpPoint);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool ScreenToClient(cpointer hWnd, cpointer unfoundType_LPPOINT_lpPoint);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool LogicalToPhysicalPoint(cpointer hWnd, cpointer unfoundType_LPPOINT_lpPoint);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool PhysicalToLogicalPoint(cpointer hWnd, cpointer unfoundType_LPPOINT_lpPoint);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool LogicalToPhysicalPointForPerMonitorDPI(cpointer hWnd, cpointer unfoundType_LPPOINT_lpPoint);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool PhysicalToLogicalPointForPerMonitorDPI(cpointer hWnd, cpointer unfoundType_LPPOINT_lpPoint);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int MapWindowPoints(cpointer hWndFrom, cpointer hWndTo, cpointer unfoundType_LPPOINT_lpPoints, uint cPoints);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer WindowFromPoint(cpointer unfoundType_POINT_Point);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer WindowFromPhysicalPoint(cpointer unfoundType_POINT_Point);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer ChildWindowFromPoint(cpointer hWndParent, cpointer unfoundType_POINT_Point);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool ClipCursor(cpointer unfoundType_RECTlpRectlpRect_unnamed_0);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer ChildWindowFromPointEx(cpointer hwnd, cpointer unfoundType_POINT_pt, uint flags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetSysColor(int nIndex);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetSysColorBrush(int nIndex);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetSysColors(int cElements, cpointer lpaElements, cpointer unfoundType_COLORREF_lpaRgbValues);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DrawFocusRect(cpointer hDC, cpointer unfoundType_RECT_lprc);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int FillRect(cpointer hDC, cpointer unfoundType_RECTlprclprc_unnamed_1, cpointer hbr);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int FrameRect(cpointer hDC, cpointer unfoundType_RECTlprclprc_unnamed_1, cpointer hbr);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool InvertRect(cpointer hDC, cpointer unfoundType_RECTlprclprc_unnamed_1);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetRect(cpointer unfoundType_LPRECT_lprc, int xLeft, int yTop, int xRight, int yBottom);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetRectEmpty(cpointer unfoundType_LPRECT_lprc);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CopyRect(cpointer unfoundType_LPRECT_lprcDst, cpointer unfoundType_RECTlprcSrclprcSrc_unnamed_1);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool InflateRect(cpointer unfoundType_LPRECT_lprc, int dx, int dy);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool IntersectRect(cpointer unfoundType_LPRECT_lprcDst, cpointer unfoundType_RECTlprcSrc1lprcSrc1_unnamed_1, cpointer unfoundType_RECTlprcSrc2lprcSrc2_unnamed_2);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool UnionRect(cpointer unfoundType_LPRECT_lprcDst, cpointer unfoundType_RECTlprcSrc1lprcSrc1_unnamed_1, cpointer unfoundType_RECTlprcSrc2lprcSrc2_unnamed_2);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SubtractRect(cpointer unfoundType_LPRECT_lprcDst, cpointer unfoundType_RECTlprcSrc1lprcSrc1_unnamed_1, cpointer unfoundType_RECTlprcSrc2lprcSrc2_unnamed_2);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool OffsetRect(cpointer unfoundType_LPRECT_lprc, int dx, int dy);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool IsRectEmpty(cpointer unfoundType_RECTlprclprc_unnamed_0);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EqualRect(cpointer unfoundType_RECTlprc1lprc1_unnamed_0, cpointer unfoundType_RECTlprc2lprc2_unnamed_1);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool PtInRect(cpointer unfoundType_RECTlprclprc_unnamed_0, cpointer unfoundType_POINT_pt);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        short GetWindowWord(cpointer hWnd, int nIndex);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        short SetWindowWord(cpointer hWnd, int nIndex, short wNewWord);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetWindowLongA(cpointer hWnd, int nIndex);
    [DllImport(lib,EntryPoint="GetWindowLongW",SetLastError=true,ExactSpelling=true)]public static extern
        int GetWindowLong(cpointer hWnd, int nIndex);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetWindowLongW(cpointer hWnd, int nIndex);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int SetWindowLongA(cpointer hWnd, int nIndex, int dwNewLong);
    [DllImport(lib,EntryPoint="SetWindowLongW",SetLastError=true,ExactSpelling=true)]public static extern
        int SetWindowLong(cpointer hWnd, int nIndex, int dwNewLong);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int SetWindowLongW(cpointer hWnd, int nIndex, int dwNewLong);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        long GetWindowLongPtrA(cpointer hWnd, int nIndex);
    [DllImport(lib,EntryPoint="GetWindowLongPtrW",SetLastError=true,ExactSpelling=true)]public static extern
        long GetWindowLongPtr(cpointer hWnd, int nIndex);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        long GetWindowLongPtrW(cpointer hWnd, int nIndex);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        long SetWindowLongPtrA(cpointer hWnd, int nIndex, long dwNewLong);
    [DllImport(lib,EntryPoint="SetWindowLongPtrW",SetLastError=true,ExactSpelling=true)]public static extern
        long SetWindowLongPtr(cpointer hWnd, int nIndex, long dwNewLong);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        long SetWindowLongPtrW(cpointer hWnd, int nIndex, long dwNewLong);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        short GetClassWord(cpointer hWnd, int nIndex);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        short SetClassWord(cpointer hWnd, int nIndex, short wNewWord);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetClassLongA(cpointer hWnd, int nIndex);
    [DllImport(lib,EntryPoint="GetClassLongW",SetLastError=true,ExactSpelling=true)]public static extern
        int GetClassLong(cpointer hWnd, int nIndex);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetClassLongW(cpointer hWnd, int nIndex);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int SetClassLongA(cpointer hWnd, int nIndex, int dwNewLong);
    [DllImport(lib,EntryPoint="SetClassLongW",SetLastError=true,ExactSpelling=true)]public static extern
        int SetClassLong(cpointer hWnd, int nIndex, int dwNewLong);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int SetClassLongW(cpointer hWnd, int nIndex, int dwNewLong);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetClassLongPtrA(cpointer hWnd, int nIndex);
    [DllImport(lib,EntryPoint="GetClassLongPtrW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetClassLongPtr(cpointer hWnd, int nIndex);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetClassLongPtrW(cpointer hWnd, int nIndex);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer SetClassLongPtrA(cpointer hWnd, int nIndex, long dwNewLong);
    [DllImport(lib,EntryPoint="SetClassLongPtrW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer SetClassLongPtr(cpointer hWnd, int nIndex, long dwNewLong);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer SetClassLongPtrW(cpointer hWnd, int nIndex, long dwNewLong);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetProcessDefaultLayout(cpointer unfoundType_DWORDpdwDefaultLayoutpdwDefaultLayout_unnamed_0);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetProcessDefaultLayout(int dwDefaultLayout);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetDesktopWindow();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetParent(cpointer hWnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer SetParent(cpointer hWndChild, cpointer hWndNewParent);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EnumChildWindows(cpointer hWndParent, cpointer unfoundType_WNDENUMPROC_lpEnumFunc, long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer FindWindowA([MarshalAs(UnmanagedType.LPStr)] string lpClassName, [MarshalAs(UnmanagedType.LPStr)] string lpWindowName);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer FindWindowA([MarshalAs(UnmanagedType.LPStr)] string lpClassName, byte* lpWindowName);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer FindWindowA(byte* lpClassName, [MarshalAs(UnmanagedType.LPStr)] string lpWindowName);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer FindWindowA(byte* lpClassName, byte* lpWindowName);
    [DllImport(lib,EntryPoint="FindWindowW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer FindWindow([MarshalAs(UnmanagedType.LPWStr)] string lpClassName, [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName);
    [DllImport(lib,EntryPoint="FindWindowW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer FindWindow([MarshalAs(UnmanagedType.LPWStr)] string lpClassName, char* lpWindowName);
    [DllImport(lib,EntryPoint="FindWindowW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer FindWindow(char* lpClassName, [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName);
    [DllImport(lib,EntryPoint="FindWindowW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer FindWindow(char* lpClassName, char* lpWindowName);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer FindWindowW([MarshalAs(UnmanagedType.LPWStr)] string lpClassName, [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer FindWindowW([MarshalAs(UnmanagedType.LPWStr)] string lpClassName, char* lpWindowName);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer FindWindowW(char* lpClassName, [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer FindWindowW(char* lpClassName, char* lpWindowName);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer FindWindowExA(cpointer hWndParent, cpointer hWndChildAfter, [MarshalAs(UnmanagedType.LPStr)] string lpszClass, [MarshalAs(UnmanagedType.LPStr)] string lpszWindow);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer FindWindowExA(cpointer hWndParent, cpointer hWndChildAfter, [MarshalAs(UnmanagedType.LPStr)] string lpszClass, byte* lpszWindow);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer FindWindowExA(cpointer hWndParent, cpointer hWndChildAfter, byte* lpszClass, [MarshalAs(UnmanagedType.LPStr)] string lpszWindow);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer FindWindowExA(cpointer hWndParent, cpointer hWndChildAfter, byte* lpszClass, byte* lpszWindow);
    [DllImport(lib,EntryPoint="FindWindowExW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer FindWindowEx(cpointer hWndParent, cpointer hWndChildAfter, [MarshalAs(UnmanagedType.LPWStr)] string lpszClass, [MarshalAs(UnmanagedType.LPWStr)] string lpszWindow);
    [DllImport(lib,EntryPoint="FindWindowExW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer FindWindowEx(cpointer hWndParent, cpointer hWndChildAfter, [MarshalAs(UnmanagedType.LPWStr)] string lpszClass, char* lpszWindow);
    [DllImport(lib,EntryPoint="FindWindowExW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer FindWindowEx(cpointer hWndParent, cpointer hWndChildAfter, char* lpszClass, [MarshalAs(UnmanagedType.LPWStr)] string lpszWindow);
    [DllImport(lib,EntryPoint="FindWindowExW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer FindWindowEx(cpointer hWndParent, cpointer hWndChildAfter, char* lpszClass, char* lpszWindow);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer FindWindowExW(cpointer hWndParent, cpointer hWndChildAfter, [MarshalAs(UnmanagedType.LPWStr)] string lpszClass, [MarshalAs(UnmanagedType.LPWStr)] string lpszWindow);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer FindWindowExW(cpointer hWndParent, cpointer hWndChildAfter, [MarshalAs(UnmanagedType.LPWStr)] string lpszClass, char* lpszWindow);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer FindWindowExW(cpointer hWndParent, cpointer hWndChildAfter, char* lpszClass, [MarshalAs(UnmanagedType.LPWStr)] string lpszWindow);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer FindWindowExW(cpointer hWndParent, cpointer hWndChildAfter, char* lpszClass, char* lpszWindow);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetShellWindow();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool RegisterShellHookWindow(cpointer hwnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DeregisterShellHookWindow(cpointer hwnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EnumWindows(cpointer unfoundType_WNDENUMPROC_lpEnumFunc, long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EnumThreadWindows(int dwThreadId, cpointer unfoundType_WNDENUMPROC_lpfn, long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetClassNameA(cpointer hWnd, [MarshalAs(UnmanagedType.LPStr)] string lpClassName, int nMaxCount);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetClassNameA(cpointer hWnd, ReadOnlySpan<byte> lpClassName, int nMaxCount);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetClassNameA(cpointer hWnd, byte* lpClassName, int nMaxCount);
    [DllImport(lib,EntryPoint="GetClassNameW",SetLastError=true,ExactSpelling=true)]public static extern
        int GetClassName(cpointer hWnd, string lpClassName, int nMaxCount);
    [DllImport(lib,EntryPoint="GetClassNameW",SetLastError=true,ExactSpelling=true)]public static extern
        int GetClassName(cpointer hWnd, char* lpClassName, int nMaxCount);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetClassNameW(cpointer hWnd, string lpClassName, int nMaxCount);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetClassNameW(cpointer hWnd, char* lpClassName, int nMaxCount);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetTopWindow(cpointer hWnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetWindowThreadProcessId(cpointer hWnd, cpointer unfoundType_LPDWORD_lpdwProcessId);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool IsGUIThread(bool bConvert);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetLastActivePopup(cpointer hWnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetWindow(cpointer hWnd, uint uCmd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer SetWindowsHookA(int nFilterType, cpointer unfoundType_HOOKPROC_pfnFilterProc);
    [DllImport(lib,EntryPoint="SetWindowsHookW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer SetWindowsHook(int nFilterType, cpointer unfoundType_HOOKPROC_pfnFilterProc);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer SetWindowsHookW(int nFilterType, cpointer unfoundType_HOOKPROC_pfnFilterProc);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool UnhookWindowsHook(int nCode, cpointer unfoundType_HOOKPROC_pfnFilterProc);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer SetWindowsHookExA(int idHook, cpointer unfoundType_HOOKPROC_lpfn, cpointer unfoundType_HINSTANCE_hmod, int dwThreadId);
    [DllImport(lib,EntryPoint="SetWindowsHookExW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer SetWindowsHookEx(int idHook, cpointer unfoundType_HOOKPROC_lpfn, cpointer unfoundType_HINSTANCE_hmod, int dwThreadId);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer SetWindowsHookExW(int idHook, cpointer unfoundType_HOOKPROC_lpfn, cpointer unfoundType_HINSTANCE_hmod, int dwThreadId);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool UnhookWindowsHookEx(cpointer unfoundType_HHOOK_hhk);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        long CallNextHookEx(cpointer unfoundType_HHOOK_hhk, int nCode, ulong wParam, long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CheckMenuRadioItem(cpointer hmenu, uint first, uint last, uint check, uint flags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadBitmapA(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPStr)] string lpBitmapName);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadBitmapA(cpointer unfoundType_HINSTANCE_hInstance, byte* lpBitmapName);
    [DllImport(lib,EntryPoint="LoadBitmapW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadBitmap(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpBitmapName);
    [DllImport(lib,EntryPoint="LoadBitmapW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadBitmap(cpointer unfoundType_HINSTANCE_hInstance, char* lpBitmapName);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadBitmapW(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpBitmapName);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadBitmapW(cpointer unfoundType_HINSTANCE_hInstance, char* lpBitmapName);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadCursorA(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPStr)] string lpCursorName);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadCursorA(cpointer unfoundType_HINSTANCE_hInstance, byte* lpCursorName);
    [DllImport(lib,EntryPoint="LoadCursorW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadCursor(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpCursorName);
    [DllImport(lib,EntryPoint="LoadCursorW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadCursor(cpointer unfoundType_HINSTANCE_hInstance, char* lpCursorName);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadCursorW(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpCursorName);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadCursorW(cpointer unfoundType_HINSTANCE_hInstance, char* lpCursorName);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadCursorFromFileA([MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadCursorFromFileA(byte* lpFileName);
    [DllImport(lib,EntryPoint="LoadCursorFromFileW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadCursorFromFile([MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib,EntryPoint="LoadCursorFromFileW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadCursorFromFile(char* lpFileName);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadCursorFromFileW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadCursorFromFileW(char* lpFileName);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateCursor(cpointer unfoundType_HINSTANCE_hInst, int xHotSpot, int yHotSpot, int nWidth, int nHeight, cpointer unfoundType_VOIDpvANDPlanepvANDPlane_unnamed_5, cpointer unfoundType_VOIDpvXORPlanepvXORPlane_unnamed_6);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DestroyCursor(cpointer unfoundType_HCURSOR_hCursor);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetSystemCursor(cpointer unfoundType_HCURSOR_hcur, int id);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadIconA(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPStr)] string lpIconName);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadIconA(cpointer unfoundType_HINSTANCE_hInstance, byte* lpIconName);
    [DllImport(lib,EntryPoint="LoadIconW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadIcon(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpIconName);
    [DllImport(lib,EntryPoint="LoadIconW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadIcon(cpointer unfoundType_HINSTANCE_hInstance, char* lpIconName);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadIconW(cpointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpIconName);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadIconW(cpointer unfoundType_HINSTANCE_hInstance, char* lpIconName);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint PrivateExtractIconsA([MarshalAs(UnmanagedType.LPStr)] string szFileName, int nIconIndex, int cxIcon, int cyIcon, cpointer unfoundType_HICONphiconphicon_unnamed_4, cpointer unfoundType_UINTpiconidpiconid_unnamed_5, uint nIcons, uint flags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint PrivateExtractIconsA(byte* szFileName, int nIconIndex, int cxIcon, int cyIcon, cpointer unfoundType_HICONphiconphicon_unnamed_4, cpointer unfoundType_UINTpiconidpiconid_unnamed_5, uint nIcons, uint flags);
    [DllImport(lib,EntryPoint="PrivateExtractIconsW",SetLastError=true,ExactSpelling=true)]public static extern
        uint PrivateExtractIcons([MarshalAs(UnmanagedType.LPWStr)] string szFileName, int nIconIndex, int cxIcon, int cyIcon, cpointer unfoundType_HICONphiconphicon_unnamed_4, cpointer unfoundType_UINTpiconidpiconid_unnamed_5, uint nIcons, uint flags);
    [DllImport(lib,EntryPoint="PrivateExtractIconsW",SetLastError=true,ExactSpelling=true)]public static extern
        uint PrivateExtractIcons(char* szFileName, int nIconIndex, int cxIcon, int cyIcon, cpointer unfoundType_HICONphiconphicon_unnamed_4, cpointer unfoundType_UINTpiconidpiconid_unnamed_5, uint nIcons, uint flags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint PrivateExtractIconsW([MarshalAs(UnmanagedType.LPWStr)] string szFileName, int nIconIndex, int cxIcon, int cyIcon, cpointer unfoundType_HICONphiconphicon_unnamed_4, cpointer unfoundType_UINTpiconidpiconid_unnamed_5, uint nIcons, uint flags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint PrivateExtractIconsW(char* szFileName, int nIconIndex, int cxIcon, int cyIcon, cpointer unfoundType_HICONphiconphicon_unnamed_4, cpointer unfoundType_UINTpiconidpiconid_unnamed_5, uint nIcons, uint flags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateIcon(cpointer unfoundType_HINSTANCE_hInstance, int nWidth, int nHeight, byte cPlanes, byte cBitsPixel, cpointer unfoundType_BYTElpbANDbitslpbANDbits_unnamed_5, cpointer unfoundType_BYTElpbXORbitslpbXORbits_unnamed_6);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DestroyIcon(cpointer hIcon);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int LookupIconIdFromDirectory(cpointer unfoundType_PBYTE_presbits, bool fIcon);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int LookupIconIdFromDirectoryEx(cpointer unfoundType_PBYTE_presbits, bool fIcon, int cxDesired, int cyDesired, uint Flags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateIconFromResource(cpointer unfoundType_PBYTE_presbits, int dwResSize, bool fIcon, int dwVer);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateIconFromResourceEx(cpointer unfoundType_PBYTE_presbits, int dwResSize, bool fIcon, int dwVer, int cxDesired, int cyDesired, uint Flags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint SetThreadCursorCreationScaling(uint cursorDpi);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadImageA(cpointer unfoundType_HINSTANCE_hInst, [MarshalAs(UnmanagedType.LPStr)] string name, uint type, int cx, int cy, uint fuLoad);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadImageA(cpointer unfoundType_HINSTANCE_hInst, byte* name, uint type, int cx, int cy, uint fuLoad);
    [DllImport(lib,EntryPoint="LoadImageW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadImage(cpointer unfoundType_HINSTANCE_hInst, [MarshalAs(UnmanagedType.LPWStr)] string name, uint type, int cx, int cy, uint fuLoad);
    [DllImport(lib,EntryPoint="LoadImageW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadImage(cpointer unfoundType_HINSTANCE_hInst, char* name, uint type, int cx, int cy, uint fuLoad);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadImageW(cpointer unfoundType_HINSTANCE_hInst, [MarshalAs(UnmanagedType.LPWStr)] string name, uint type, int cx, int cy, uint fuLoad);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer LoadImageW(cpointer unfoundType_HINSTANCE_hInst, char* name, uint type, int cx, int cy, uint fuLoad);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CopyImage(cpointer h, uint type, int cx, int cy, uint flags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateIconIndirect(cpointer unfoundType_PICONINFO_piconinfo);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CopyIcon(cpointer hIcon);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetIconInfo(cpointer hIcon, cpointer unfoundType_PICONINFO_piconinfo);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetIconInfoExA(cpointer hicon, cpointer unfoundType_PICONINFOEXA_piconinfo);
    [DllImport(lib,EntryPoint="GetIconInfoExW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetIconInfoEx(cpointer hicon, cpointer unfoundType_PICONINFOEXW_piconinfo);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetIconInfoExW(cpointer hicon, cpointer unfoundType_PICONINFOEXW_piconinfo);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool IsDialogMessageA(cpointer hDlg, cpointer unfoundType_LPMSG_lpMsg);
    [DllImport(lib,EntryPoint="IsDialogMessageW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool IsDialogMessage(cpointer hDlg, cpointer unfoundType_LPMSG_lpMsg);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool IsDialogMessageW(cpointer hDlg, cpointer unfoundType_LPMSG_lpMsg);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool MapDialogRect(cpointer hDlg, cpointer unfoundType_LPRECT_lpRect);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int DlgDirListA(cpointer hDlg, [MarshalAs(UnmanagedType.LPStr)] string lpPathSpec, int nIDListBox, int nIDStaticPath, uint uFileType);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int DlgDirListA(cpointer hDlg, ReadOnlySpan<byte> lpPathSpec, int nIDListBox, int nIDStaticPath, uint uFileType);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int DlgDirListA(cpointer hDlg, byte* lpPathSpec, int nIDListBox, int nIDStaticPath, uint uFileType);
    [DllImport(lib,EntryPoint="DlgDirListW",SetLastError=true,ExactSpelling=true)]public static extern
        int DlgDirList(cpointer hDlg, string lpPathSpec, int nIDListBox, int nIDStaticPath, uint uFileType);
    [DllImport(lib,EntryPoint="DlgDirListW",SetLastError=true,ExactSpelling=true)]public static extern
        int DlgDirList(cpointer hDlg, char* lpPathSpec, int nIDListBox, int nIDStaticPath, uint uFileType);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int DlgDirListW(cpointer hDlg, string lpPathSpec, int nIDListBox, int nIDStaticPath, uint uFileType);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int DlgDirListW(cpointer hDlg, char* lpPathSpec, int nIDListBox, int nIDStaticPath, uint uFileType);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DlgDirSelectExA(cpointer hwndDlg, [MarshalAs(UnmanagedType.LPStr)] string lpString, int chCount, int idListBox);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DlgDirSelectExA(cpointer hwndDlg, ReadOnlySpan<byte> lpString, int chCount, int idListBox);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DlgDirSelectExA(cpointer hwndDlg, byte* lpString, int chCount, int idListBox);
    [DllImport(lib,EntryPoint="DlgDirSelectExW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DlgDirSelectEx(cpointer hwndDlg, string lpString, int chCount, int idListBox);
    [DllImport(lib,EntryPoint="DlgDirSelectExW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DlgDirSelectEx(cpointer hwndDlg, char* lpString, int chCount, int idListBox);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DlgDirSelectExW(cpointer hwndDlg, string lpString, int chCount, int idListBox);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DlgDirSelectExW(cpointer hwndDlg, char* lpString, int chCount, int idListBox);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int DlgDirListComboBoxA(cpointer hDlg, [MarshalAs(UnmanagedType.LPStr)] string lpPathSpec, int nIDComboBox, int nIDStaticPath, uint uFiletype);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int DlgDirListComboBoxA(cpointer hDlg, ReadOnlySpan<byte> lpPathSpec, int nIDComboBox, int nIDStaticPath, uint uFiletype);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int DlgDirListComboBoxA(cpointer hDlg, byte* lpPathSpec, int nIDComboBox, int nIDStaticPath, uint uFiletype);
    [DllImport(lib,EntryPoint="DlgDirListComboBoxW",SetLastError=true,ExactSpelling=true)]public static extern
        int DlgDirListComboBox(cpointer hDlg, string lpPathSpec, int nIDComboBox, int nIDStaticPath, uint uFiletype);
    [DllImport(lib,EntryPoint="DlgDirListComboBoxW",SetLastError=true,ExactSpelling=true)]public static extern
        int DlgDirListComboBox(cpointer hDlg, char* lpPathSpec, int nIDComboBox, int nIDStaticPath, uint uFiletype);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int DlgDirListComboBoxW(cpointer hDlg, string lpPathSpec, int nIDComboBox, int nIDStaticPath, uint uFiletype);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int DlgDirListComboBoxW(cpointer hDlg, char* lpPathSpec, int nIDComboBox, int nIDStaticPath, uint uFiletype);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DlgDirSelectComboBoxExA(cpointer hwndDlg, [MarshalAs(UnmanagedType.LPStr)] string lpString, int cchOut, int idComboBox);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DlgDirSelectComboBoxExA(cpointer hwndDlg, ReadOnlySpan<byte> lpString, int cchOut, int idComboBox);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DlgDirSelectComboBoxExA(cpointer hwndDlg, byte* lpString, int cchOut, int idComboBox);
    [DllImport(lib,EntryPoint="DlgDirSelectComboBoxExW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DlgDirSelectComboBoxEx(cpointer hwndDlg, string lpString, int cchOut, int idComboBox);
    [DllImport(lib,EntryPoint="DlgDirSelectComboBoxExW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DlgDirSelectComboBoxEx(cpointer hwndDlg, char* lpString, int cchOut, int idComboBox);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DlgDirSelectComboBoxExW(cpointer hwndDlg, string lpString, int cchOut, int idComboBox);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool DlgDirSelectComboBoxExW(cpointer hwndDlg, char* lpString, int cchOut, int idComboBox);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int SetScrollInfo(cpointer hwnd, int nBar, cpointer unfoundType_LPCSCROLLINFO_lpsi, bool redraw);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetScrollInfo(cpointer hwnd, int nBar, cpointer unfoundType_LPSCROLLINFO_lpsi);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        long DefFrameProcA(cpointer hWnd, cpointer hWndMDIClient, uint uMsg, ulong wParam, long lParam);
    [DllImport(lib,EntryPoint="DefFrameProcW",SetLastError=true,ExactSpelling=true)]public static extern
        long DefFrameProc(cpointer hWnd, cpointer hWndMDIClient, uint uMsg, ulong wParam, long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        long DefFrameProcW(cpointer hWnd, cpointer hWndMDIClient, uint uMsg, ulong wParam, long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer DefMDIChildProcA(cpointer hWnd, uint uMsg, ulong wParam, long lParam);
    [DllImport(lib,EntryPoint="DefMDIChildProcW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer DefMDIChildProc(cpointer hWnd, uint uMsg, ulong wParam, long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer DefMDIChildProcW(cpointer hWnd, uint uMsg, ulong wParam, long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool TranslateMDISysAccel(cpointer hWndClient, cpointer unfoundType_LPMSG_lpMsg);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint ArrangeIconicWindows(cpointer hWnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateMDIWindowA([MarshalAs(UnmanagedType.LPStr)] string lpClassName, [MarshalAs(UnmanagedType.LPStr)] string lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, cpointer hWndParent, cpointer unfoundType_HINSTANCE_hInstance, long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateMDIWindowA([MarshalAs(UnmanagedType.LPStr)] string lpClassName, byte* lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, cpointer hWndParent, cpointer unfoundType_HINSTANCE_hInstance, long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateMDIWindowA(byte* lpClassName, [MarshalAs(UnmanagedType.LPStr)] string lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, cpointer hWndParent, cpointer unfoundType_HINSTANCE_hInstance, long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateMDIWindowA(byte* lpClassName, byte* lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, cpointer hWndParent, cpointer unfoundType_HINSTANCE_hInstance, long lParam);
    [DllImport(lib,EntryPoint="CreateMDIWindowW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateMDIWindow([MarshalAs(UnmanagedType.LPWStr)] string lpClassName, [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, cpointer hWndParent, cpointer unfoundType_HINSTANCE_hInstance, long lParam);
    [DllImport(lib,EntryPoint="CreateMDIWindowW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateMDIWindow([MarshalAs(UnmanagedType.LPWStr)] string lpClassName, char* lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, cpointer hWndParent, cpointer unfoundType_HINSTANCE_hInstance, long lParam);
    [DllImport(lib,EntryPoint="CreateMDIWindowW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateMDIWindow(char* lpClassName, [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, cpointer hWndParent, cpointer unfoundType_HINSTANCE_hInstance, long lParam);
    [DllImport(lib,EntryPoint="CreateMDIWindowW",SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateMDIWindow(char* lpClassName, char* lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, cpointer hWndParent, cpointer unfoundType_HINSTANCE_hInstance, long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateMDIWindowW([MarshalAs(UnmanagedType.LPWStr)] string lpClassName, [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, cpointer hWndParent, cpointer unfoundType_HINSTANCE_hInstance, long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateMDIWindowW([MarshalAs(UnmanagedType.LPWStr)] string lpClassName, char* lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, cpointer hWndParent, cpointer unfoundType_HINSTANCE_hInstance, long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateMDIWindowW(char* lpClassName, [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, cpointer hWndParent, cpointer unfoundType_HINSTANCE_hInstance, long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer CreateMDIWindowW(char* lpClassName, char* lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, cpointer hWndParent, cpointer unfoundType_HINSTANCE_hInstance, long lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        short TileWindows(cpointer hwndParent, uint wHow, cpointer unfoundType_RECT_lpRect, uint cKids, cpointer lpKids);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool WinHelpA(cpointer hWndMain, [MarshalAs(UnmanagedType.LPStr)] string lpszHelp, uint uCommand, cpointer unfoundType_ULONG_PTR_dwData);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool WinHelpA(cpointer hWndMain, byte* lpszHelp, uint uCommand, cpointer unfoundType_ULONG_PTR_dwData);
    [DllImport(lib,EntryPoint="WinHelpW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool WinHelp(cpointer hWndMain, [MarshalAs(UnmanagedType.LPWStr)] string lpszHelp, uint uCommand, cpointer unfoundType_ULONG_PTR_dwData);
    [DllImport(lib,EntryPoint="WinHelpW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool WinHelp(cpointer hWndMain, char* lpszHelp, uint uCommand, cpointer unfoundType_ULONG_PTR_dwData);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool WinHelpW(cpointer hWndMain, [MarshalAs(UnmanagedType.LPWStr)] string lpszHelp, uint uCommand, cpointer unfoundType_ULONG_PTR_dwData);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool WinHelpW(cpointer hWndMain, char* lpszHelp, uint uCommand, cpointer unfoundType_ULONG_PTR_dwData);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetGuiResources(cpointer hProcess, int uiFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int ChangeDisplaySettingsA(cpointer unfoundType_DEVMODEA_lpDevMode, int dwFlags);
    [DllImport(lib,EntryPoint="ChangeDisplaySettingsW",SetLastError=true,ExactSpelling=true)]public static extern
        int ChangeDisplaySettings(cpointer unfoundType_DEVMODEW_lpDevMode, int dwFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int ChangeDisplaySettingsW(cpointer unfoundType_DEVMODEW_lpDevMode, int dwFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int ChangeDisplaySettingsExA([MarshalAs(UnmanagedType.LPStr)] string lpszDeviceName, cpointer unfoundType_DEVMODEA_lpDevMode, cpointer hwnd, int dwflags, cpointer lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int ChangeDisplaySettingsExA(byte* lpszDeviceName, cpointer unfoundType_DEVMODEA_lpDevMode, cpointer hwnd, int dwflags, cpointer lParam);
    [DllImport(lib,EntryPoint="ChangeDisplaySettingsExW",SetLastError=true,ExactSpelling=true)]public static extern
        int ChangeDisplaySettingsEx([MarshalAs(UnmanagedType.LPWStr)] string lpszDeviceName, cpointer unfoundType_DEVMODEW_lpDevMode, cpointer hwnd, int dwflags, cpointer lParam);
    [DllImport(lib,EntryPoint="ChangeDisplaySettingsExW",SetLastError=true,ExactSpelling=true)]public static extern
        int ChangeDisplaySettingsEx(char* lpszDeviceName, cpointer unfoundType_DEVMODEW_lpDevMode, cpointer hwnd, int dwflags, cpointer lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int ChangeDisplaySettingsExW([MarshalAs(UnmanagedType.LPWStr)] string lpszDeviceName, cpointer unfoundType_DEVMODEW_lpDevMode, cpointer hwnd, int dwflags, cpointer lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int ChangeDisplaySettingsExW(char* lpszDeviceName, cpointer unfoundType_DEVMODEW_lpDevMode, cpointer hwnd, int dwflags, cpointer lParam);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EnumDisplaySettingsA([MarshalAs(UnmanagedType.LPStr)] string lpszDeviceName, int iModeNum, cpointer unfoundType_DEVMODEA_lpDevMode);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EnumDisplaySettingsA(byte* lpszDeviceName, int iModeNum, cpointer unfoundType_DEVMODEA_lpDevMode);
    [DllImport(lib,EntryPoint="EnumDisplaySettingsW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EnumDisplaySettings([MarshalAs(UnmanagedType.LPWStr)] string lpszDeviceName, int iModeNum, cpointer unfoundType_DEVMODEW_lpDevMode);
    [DllImport(lib,EntryPoint="EnumDisplaySettingsW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EnumDisplaySettings(char* lpszDeviceName, int iModeNum, cpointer unfoundType_DEVMODEW_lpDevMode);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EnumDisplaySettingsW([MarshalAs(UnmanagedType.LPWStr)] string lpszDeviceName, int iModeNum, cpointer unfoundType_DEVMODEW_lpDevMode);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EnumDisplaySettingsW(char* lpszDeviceName, int iModeNum, cpointer unfoundType_DEVMODEW_lpDevMode);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EnumDisplaySettingsExA([MarshalAs(UnmanagedType.LPStr)] string lpszDeviceName, int iModeNum, cpointer unfoundType_DEVMODEA_lpDevMode, int dwFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EnumDisplaySettingsExA(byte* lpszDeviceName, int iModeNum, cpointer unfoundType_DEVMODEA_lpDevMode, int dwFlags);
    [DllImport(lib,EntryPoint="EnumDisplaySettingsExW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EnumDisplaySettingsEx([MarshalAs(UnmanagedType.LPWStr)] string lpszDeviceName, int iModeNum, cpointer unfoundType_DEVMODEW_lpDevMode, int dwFlags);
    [DllImport(lib,EntryPoint="EnumDisplaySettingsExW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EnumDisplaySettingsEx(char* lpszDeviceName, int iModeNum, cpointer unfoundType_DEVMODEW_lpDevMode, int dwFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EnumDisplaySettingsExW([MarshalAs(UnmanagedType.LPWStr)] string lpszDeviceName, int iModeNum, cpointer unfoundType_DEVMODEW_lpDevMode, int dwFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EnumDisplaySettingsExW(char* lpszDeviceName, int iModeNum, cpointer unfoundType_DEVMODEW_lpDevMode, int dwFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EnumDisplayDevicesA([MarshalAs(UnmanagedType.LPStr)] string lpDevice, int iDevNum, cpointer unfoundType_PDISPLAY_DEVICEA_lpDisplayDevice, int dwFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EnumDisplayDevicesA(byte* lpDevice, int iDevNum, cpointer unfoundType_PDISPLAY_DEVICEA_lpDisplayDevice, int dwFlags);
    [DllImport(lib,EntryPoint="EnumDisplayDevicesW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EnumDisplayDevices([MarshalAs(UnmanagedType.LPWStr)] string lpDevice, int iDevNum, cpointer unfoundType_PDISPLAY_DEVICEW_lpDisplayDevice, int dwFlags);
    [DllImport(lib,EntryPoint="EnumDisplayDevicesW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EnumDisplayDevices(char* lpDevice, int iDevNum, cpointer unfoundType_PDISPLAY_DEVICEW_lpDisplayDevice, int dwFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EnumDisplayDevicesW([MarshalAs(UnmanagedType.LPWStr)] string lpDevice, int iDevNum, cpointer unfoundType_PDISPLAY_DEVICEW_lpDisplayDevice, int dwFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EnumDisplayDevicesW(char* lpDevice, int iDevNum, cpointer unfoundType_PDISPLAY_DEVICEW_lpDisplayDevice, int dwFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetDisplayConfigBufferSizes(uint flags, cpointer numPathArrayElements, cpointer numModeInfoArrayElements);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int SetDisplayConfig(uint numPathArrayElements, cpointer unfoundType_DISPLAYCONFIG_PATH_INFO_pathArray, uint numModeInfoArrayElements, cpointer unfoundType_DISPLAYCONFIG_MODE_INFO_modeInfoArray, uint flags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int QueryDisplayConfig(uint flags, cpointer numPathArrayElements, cpointer unfoundType_DISPLAYCONFIG_PATH_INFO_pathArray, cpointer numModeInfoArrayElements, cpointer unfoundType_DISPLAYCONFIG_MODE_INFO_modeInfoArray, cpointer unfoundType_DISPLAYCONFIG_TOPOLOGY_ID_currentTopologyId);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int DisplayConfigGetDeviceInfo(cpointer unfoundType_DISPLAYCONFIG_DEVICE_INFO_HEADER_requestPacket);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int DisplayConfigSetDeviceInfo(cpointer unfoundType_DISPLAYCONFIG_DEVICE_INFO_HEADER_setPacket);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SystemParametersInfoA(uint uiAction, uint uiParam, cpointer pvParam, uint fWinIni);
    [DllImport(lib,EntryPoint="SystemParametersInfoW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SystemParametersInfo(uint uiAction, uint uiParam, cpointer pvParam, uint fWinIni);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SystemParametersInfoW(uint uiAction, uint uiParam, cpointer pvParam, uint fWinIni);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SystemParametersInfoForDpi(uint uiAction, uint uiParam, cpointer pvParam, uint fWinIni, uint dpi);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SoundSentry();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        void SetDebugErrorLevel(int dwLevel);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        void SetLastErrorEx(int dwErrCode, int dwType);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int InternalGetWindowText(cpointer hWnd, string pString, int cchMaxCount);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int InternalGetWindowText(cpointer hWnd, char* pString, int cchMaxCount);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EndTask(cpointer hWnd, bool fShutDown, bool fForce);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CancelShutdown();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer MonitorFromPoint(cpointer unfoundType_POINT_pt, int dwFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer MonitorFromRect(cpointer unfoundType_LPCRECT_lprc, int dwFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer MonitorFromWindow(cpointer hwnd, int dwFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetMonitorInfoA(cpointer hMonitor, cpointer unfoundType_LPMONITORINFO_lpmi);
    [DllImport(lib,EntryPoint="GetMonitorInfoW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetMonitorInfo(cpointer hMonitor, cpointer unfoundType_LPMONITORINFO_lpmi);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetMonitorInfoW(cpointer hMonitor, cpointer unfoundType_LPMONITORINFO_lpmi);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EnumDisplayMonitors(cpointer hdc, cpointer unfoundType_LPCRECT_lprcClip, cpointer unfoundType_MONITORENUMPROC_lpfnEnum, long dwData);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        void NotifyWinEvent(int argEvent, cpointer hwnd, int idObject, int idChild);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer SetWinEventHook(int eventMin, int eventMax, cpointer unfoundType_HMODULE_hmodWinEventProc, cpointer unfoundType_WINEVENTPROC_pfnWinEventProc, int idProcess, int idThread, int dwFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool IsWinEventHookInstalled(int argEvent);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool UnhookWinEvent(cpointer unfoundType_HWINEVENTHOOK_hWinEventHook);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetGUIThreadInfo(int idThread, cpointer unfoundType_PGUITHREADINFO_pgui);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool BlockInput(bool fBlockIt);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetProcessDPIAware();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool IsProcessDPIAware();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer SetThreadDpiAwarenessContext(cpointer unfoundType_DPI_AWARENESS_CONTEXT_dpiContext);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetThreadDpiAwarenessContext();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetWindowDpiAwarenessContext(cpointer hwnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetAwarenessFromDpiAwarenessContext(cpointer unfoundType_DPI_AWARENESS_CONTEXT_value);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint GetDpiFromDpiAwarenessContext(cpointer unfoundType_DPI_AWARENESS_CONTEXT_value);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool AreDpiAwarenessContextsEqual(cpointer unfoundType_DPI_AWARENESS_CONTEXT_dpiContextA, cpointer unfoundType_DPI_AWARENESS_CONTEXT_dpiContextB);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool IsValidDpiAwarenessContext(cpointer unfoundType_DPI_AWARENESS_CONTEXT_value);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint GetDpiForWindow(cpointer hwnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint GetDpiForSystem();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint GetSystemDpiForProcess(cpointer hProcess);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool EnableNonClientDpiScaling(cpointer hwnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool InheritWindowMonitor(cpointer hwnd, cpointer hwndInherit);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetProcessDpiAwarenessContext(cpointer unfoundType_DPI_AWARENESS_CONTEXT_value);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetDpiAwarenessContextForProcess(cpointer hProcess);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer SetThreadDpiHostingBehavior(cpointer unfoundType_DPI_HOSTING_BEHAVIOR_value);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetThreadDpiHostingBehavior();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetWindowDpiHostingBehavior(cpointer hwnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint GetWindowModuleFileNameA(cpointer hwnd, [MarshalAs(UnmanagedType.LPStr)] string pszFileName, uint cchFileNameMax);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint GetWindowModuleFileNameA(cpointer hwnd, ReadOnlySpan<byte> pszFileName, uint cchFileNameMax);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint GetWindowModuleFileNameA(cpointer hwnd, byte* pszFileName, uint cchFileNameMax);
    [DllImport(lib,EntryPoint="GetWindowModuleFileNameW",SetLastError=true,ExactSpelling=true)]public static extern
        uint GetWindowModuleFileName(cpointer hwnd, string pszFileName, uint cchFileNameMax);
    [DllImport(lib,EntryPoint="GetWindowModuleFileNameW",SetLastError=true,ExactSpelling=true)]public static extern
        uint GetWindowModuleFileName(cpointer hwnd, char* pszFileName, uint cchFileNameMax);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint GetWindowModuleFileNameW(cpointer hwnd, string pszFileName, uint cchFileNameMax);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint GetWindowModuleFileNameW(cpointer hwnd, char* pszFileName, uint cchFileNameMax);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetCursorInfo(cpointer unfoundType_PCURSORINFO_pci);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetWindowInfo(cpointer hwnd, cpointer unfoundType_PWINDOWINFO_pwi);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetTitleBarInfo(cpointer hwnd, cpointer unfoundType_PTITLEBARINFO_pti);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetMenuBarInfo(cpointer hwnd, int idObject, int idItem, cpointer unfoundType_PMENUBARINFO_pmbi);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetScrollBarInfo(cpointer hwnd, int idObject, cpointer unfoundType_PSCROLLBARINFO_psbi);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetComboBoxInfo(cpointer hwndCombo, cpointer unfoundType_PCOMBOBOXINFO_pcbi);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer GetAncestor(cpointer hwnd, uint gaFlags);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        cpointer RealChildWindowFromPoint(cpointer hwndParent, cpointer unfoundType_POINT_ptParentClientCoords);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint RealGetWindowClassA(cpointer hwnd, [MarshalAs(UnmanagedType.LPStr)] string ptszClassName, uint cchClassNameMax);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint RealGetWindowClassA(cpointer hwnd, ReadOnlySpan<byte> ptszClassName, uint cchClassNameMax);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint RealGetWindowClassA(cpointer hwnd, byte* ptszClassName, uint cchClassNameMax);
    [DllImport(lib,EntryPoint="RealGetWindowClassW",SetLastError=true,ExactSpelling=true)]public static extern
        uint RealGetWindowClass(cpointer hwnd, string ptszClassName, uint cchClassNameMax);
    [DllImport(lib,EntryPoint="RealGetWindowClassW",SetLastError=true,ExactSpelling=true)]public static extern
        uint RealGetWindowClass(cpointer hwnd, char* ptszClassName, uint cchClassNameMax);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint RealGetWindowClassW(cpointer hwnd, string ptszClassName, uint cchClassNameMax);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint RealGetWindowClassW(cpointer hwnd, char* ptszClassName, uint cchClassNameMax);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetAltTabInfoA(cpointer hwnd, int iItem, cpointer unfoundType_PALTTABINFO_pati, [MarshalAs(UnmanagedType.LPStr)] string pszItemText, uint cchItemText);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetAltTabInfoA(cpointer hwnd, int iItem, cpointer unfoundType_PALTTABINFO_pati, ReadOnlySpan<byte> pszItemText, uint cchItemText);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetAltTabInfoA(cpointer hwnd, int iItem, cpointer unfoundType_PALTTABINFO_pati, byte* pszItemText, uint cchItemText);
    [DllImport(lib,EntryPoint="GetAltTabInfoW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetAltTabInfo(cpointer hwnd, int iItem, cpointer unfoundType_PALTTABINFO_pati, string pszItemText, uint cchItemText);
    [DllImport(lib,EntryPoint="GetAltTabInfoW",SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetAltTabInfo(cpointer hwnd, int iItem, cpointer unfoundType_PALTTABINFO_pati, char* pszItemText, uint cchItemText);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetAltTabInfoW(cpointer hwnd, int iItem, cpointer unfoundType_PALTTABINFO_pati, string pszItemText, uint cchItemText);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetAltTabInfoW(cpointer hwnd, int iItem, cpointer unfoundType_PALTTABINFO_pati, char* pszItemText, uint cchItemText);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        int GetListBoxInfo(cpointer hwnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool LockWorkStation();
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool UserHandleGrantAccess(cpointer hUserHandle, cpointer hJob, bool bGrant);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint GetRawInputData(cpointer unfoundType_HRAWINPUT_hRawInput, uint uiCommand, cpointer pData, cpointer unfoundType_PUINT_pcbSize, uint cbSizeHeader);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint GetRawInputDeviceInfoA(cpointer hDevice, uint uiCommand, cpointer pData, cpointer unfoundType_PUINT_pcbSize);
    [DllImport(lib,EntryPoint="GetRawInputDeviceInfoW",SetLastError=true,ExactSpelling=true)]public static extern
        uint GetRawInputDeviceInfo(cpointer hDevice, uint uiCommand, cpointer pData, cpointer unfoundType_PUINT_pcbSize);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint GetRawInputDeviceInfoW(cpointer hDevice, uint uiCommand, cpointer pData, cpointer unfoundType_PUINT_pcbSize);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint GetRawInputBuffer(cpointer unfoundType_PRAWINPUT_pData, cpointer unfoundType_PUINT_pcbSize, uint cbSizeHeader);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool RegisterRawInputDevices(cpointer unfoundType_PCRAWINPUTDEVICE_pRawInputDevices, uint uiNumDevices, uint cbSize);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint GetRegisteredRawInputDevices(cpointer unfoundType_PRAWINPUTDEVICE_pRawInputDevices, cpointer unfoundType_PUINT_puiNumDevices, uint cbSize);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        uint GetRawInputDeviceList(cpointer unfoundType_PRAWINPUTDEVICELIST_pRawInputDeviceList, cpointer unfoundType_PUINT_puiNumDevices, uint cbSize);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)]public static extern
        long DefRawInputProc(cpointer unfoundType_PRAWINPUT_paRawInput, int nInput, uint cbSizeHeader);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetPointerDevices(cpointer deviceCount, cpointer unfoundType_POINTER_DEVICE_INFOpointerDevicespointerDevices_unnamed_1);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetPointerDevice(cpointer device, cpointer unfoundType_POINTER_DEVICE_INFOpointerDevicepointerDevice_unnamed_1);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetPointerDeviceProperties(cpointer device, cpointer propertyCount, cpointer unfoundType_POINTER_DEVICE_PROPERTYpointerPropertiespointerProperties_unnamed_2);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool RegisterPointerDeviceNotifications(cpointer window, bool notifyRange);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetPointerDeviceRects(cpointer device, cpointer unfoundType_RECT_pointerDeviceRect, cpointer unfoundType_RECT_displayRect);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetPointerDeviceCursors(cpointer device, cpointer cursorCount, cpointer unfoundType_POINTER_DEVICE_CURSOR_INFOdeviceCursorsdeviceCursors_unnamed_2);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetRawPointerDeviceData(uint pointerId, uint historyCount, uint propertiesCount, cpointer unfoundType_POINTER_DEVICE_PROPERTY_pProperties, cpointer pValues);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool ChangeWindowMessageFilter(uint message, int dwFlag);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool ChangeWindowMessageFilterEx(cpointer hwnd, uint message, int action, cpointer unfoundType_PCHANGEFILTERSTRUCT_pChangeFilterStruct);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetGestureInfo(cpointer unfoundType_HGESTUREINFO_hGestureInfo, cpointer unfoundType_PGESTUREINFO_pGestureInfo);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetGestureExtraArgs(cpointer unfoundType_HGESTUREINFO_hGestureInfo, uint cbExtraArgs, cpointer unfoundType_PBYTE_pExtraArgs);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool CloseGestureInfoHandle(cpointer unfoundType_HGESTUREINFO_hGestureInfo);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetGestureConfig(cpointer hwnd, int dwReserved, uint cIDs, cpointer unfoundType_PGESTURECONFIG_pGestureConfig, uint cbSize);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetGestureConfig(cpointer hwnd, int dwReserved, int dwFlags, cpointer unfoundType_PUINT_pcIDs, cpointer unfoundType_PGESTURECONFIG_pGestureConfig, uint cbSize);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool ShutdownBlockReasonCreate(cpointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string pwszReason);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool ShutdownBlockReasonCreate(cpointer hWnd, char* pwszReason);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool ShutdownBlockReasonQuery(cpointer hWnd, string pwszBuff, cpointer unfoundType_DWORDpcchBuffpcchBuff_unnamed_2);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool ShutdownBlockReasonQuery(cpointer hWnd, char* pwszBuff, cpointer unfoundType_DWORDpcchBuffpcchBuff_unnamed_2);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool ShutdownBlockReasonDestroy(cpointer hWnd);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetCurrentInputMessageSource(cpointer unfoundType_INPUT_MESSAGE_SOURCEinputMessageSourceinputMessageSource_unnamed_0);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetCIMSSM(cpointer unfoundType_INPUT_MESSAGE_SOURCEinputMessageSourceinputMessageSource_unnamed_0);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetAutoRotationState(cpointer unfoundType_PAR_STATE_pState);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool GetDisplayAutoRotationPreferences(cpointer unfoundType_ORIENTATION_PREFERENCEpOrientationpOrientation_unnamed_0);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetDisplayAutoRotationPreferences(cpointer unfoundType_ORIENTATION_PREFERENCE_orientation);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool IsImmersiveProcess(cpointer hProcess);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetProcessRestrictionExemption(bool fEnableExemption);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool SetAdditionalForegroundBoostProcesses(cpointer topLevelWindow, int processHandleCount, cpointer unfoundType_HANDLEprocessHandleArrayprocessHandleArray_unnamed_2);
    [DllImport(lib,SetLastError=true,ExactSpelling=true)][return:MarshalAs(UnmanagedType.Bool)]public static extern
        bool RegisterForTooltipDismissNotification(cpointer hWnd, cpointer unfoundType_TOOLTIP_DISMISS_FLAGS_tdFlags);

}