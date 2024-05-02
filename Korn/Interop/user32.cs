public unsafe class user32
{
    const string lib = "user32";
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LoadStringA(pointer unfoundType_HINSTANCE_hInstance, uint uID, [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, int cchBufferMax);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LoadStringA(pointer unfoundType_HINSTANCE_hInstance, uint uID, ReadOnlySpan<byte> lpBuffer, int cchBufferMax);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LoadStringA(pointer unfoundType_HINSTANCE_hInstance, uint uID, byte* lpBuffer, int cchBufferMax);
    [DllImport(lib, EntryPoint = "LoadStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int LoadString(pointer unfoundType_HINSTANCE_hInstance, uint uID, string lpBuffer, int cchBufferMax);
    [DllImport(lib, EntryPoint = "LoadStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int LoadString(pointer unfoundType_HINSTANCE_hInstance, uint uID, char* lpBuffer, int cchBufferMax);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LoadStringW(pointer unfoundType_HINSTANCE_hInstance, uint uID, string lpBuffer, int cchBufferMax);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LoadStringW(pointer unfoundType_HINSTANCE_hInstance, uint uID, char* lpBuffer, int cchBufferMax);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DdeSetQualityOfService(pointer hwndClient, pointer unfoundType_SECURITY_QUALITY_OF_SERVICEpqosNewpqosNew_unnamed_1, pointer unfoundType_PSECURITY_QUALITY_OF_SERVICE_pqosPrev);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ImpersonateDdeClientWindow(pointer hWndClient, pointer hWndServer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint DdeInitializeA(pointer unfoundType_LPDWORD_pidInst, pointer unfoundType_PFNCALLBACK_pfnCallback, int afCmd, int ulRes);
    [DllImport(lib, EntryPoint = "DdeInitializeW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint DdeInitialize(pointer unfoundType_LPDWORD_pidInst, pointer unfoundType_PFNCALLBACK_pfnCallback, int afCmd, int ulRes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint DdeInitializeW(pointer unfoundType_LPDWORD_pidInst, pointer unfoundType_PFNCALLBACK_pfnCallback, int afCmd, int ulRes);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DdeUninitialize(int idInst);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer DdeConnectList(int idInst, pointer unfoundType_HSZ_hszService, pointer unfoundType_HSZ_hszTopic, pointer unfoundType_HCONVLIST_hConvList, pointer unfoundType_PCONVCONTEXT_pCC);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer DdeQueryNextServer(pointer unfoundType_HCONVLIST_hConvList, pointer unfoundType_HCONV_hConvPrev);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DdeDisconnectList(pointer unfoundType_HCONVLIST_hConvList);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer DdeConnect(int idInst, pointer unfoundType_HSZ_hszService, pointer unfoundType_HSZ_hszTopic, pointer unfoundType_PCONVCONTEXT_pCC);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DdeDisconnect(pointer unfoundType_HCONV_hConv);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer DdeReconnect(pointer unfoundType_HCONV_hConv);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint DdeQueryConvInfo(pointer unfoundType_HCONV_hConv, int idTransaction, pointer unfoundType_PCONVINFO_pConvInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DdeSetUserHandle(pointer unfoundType_HCONV_hConv, int id, pointer unfoundType_DWORD_PTR_hUser);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DdeAbandonTransaction(int idInst, pointer unfoundType_HCONV_hConv, int idTransaction);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DdePostAdvise(int idInst, pointer unfoundType_HSZ_hszTopic, pointer unfoundType_HSZ_hszItem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DdeEnableCallback(int idInst, pointer unfoundType_HCONV_hConv, uint wCmd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DdeImpersonateClient(pointer unfoundType_HCONV_hConv);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer DdeNameService(int idInst, pointer unfoundType_HSZ_hsz1, pointer unfoundType_HSZ_hsz2, uint afCmd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer DdeClientTransaction(pointer unfoundType_LPBYTE_pData, int cbData, pointer unfoundType_HCONV_hConv, pointer unfoundType_HSZ_hszItem, uint wFmt, uint wType, int dwTimeout, pointer unfoundType_LPDWORD_pdwResult);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer DdeCreateDataHandle(int idInst, pointer unfoundType_LPBYTE_pSrc, int cb, int cbOff, pointer unfoundType_HSZ_hszItem, uint wFmt, uint afCmd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer DdeAddData(pointer unfoundType_HDDEDATA_hData, pointer unfoundType_LPBYTE_pSrc, int cb, int cbOff);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int DdeGetData(pointer unfoundType_HDDEDATA_hData, pointer unfoundType_LPBYTE_pDst, int cbMax, int cbOff);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer DdeAccessData(pointer unfoundType_HDDEDATA_hData, pointer unfoundType_LPDWORD_pcbDataSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DdeUnaccessData(pointer unfoundType_HDDEDATA_hData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DdeFreeDataHandle(pointer unfoundType_HDDEDATA_hData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint DdeGetLastError(int idInst);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer DdeCreateStringHandleA(int idInst, [MarshalAs(UnmanagedType.LPStr)] string psz, int iCodePage);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer DdeCreateStringHandleA(int idInst, byte* psz, int iCodePage);
    [DllImport(lib, EntryPoint = "DdeCreateStringHandleW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer DdeCreateStringHandle(int idInst, [MarshalAs(UnmanagedType.LPWStr)] string psz, int iCodePage);
    [DllImport(lib, EntryPoint = "DdeCreateStringHandleW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer DdeCreateStringHandle(int idInst, char* psz, int iCodePage);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer DdeCreateStringHandleW(int idInst, [MarshalAs(UnmanagedType.LPWStr)] string psz, int iCodePage);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer DdeCreateStringHandleW(int idInst, char* psz, int iCodePage);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int DdeQueryStringA(int idInst, pointer unfoundType_HSZ_hsz, [MarshalAs(UnmanagedType.LPStr)] string psz, int cchMax, int iCodePage);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int DdeQueryStringA(int idInst, pointer unfoundType_HSZ_hsz, ReadOnlySpan<byte> psz, int cchMax, int iCodePage);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int DdeQueryStringA(int idInst, pointer unfoundType_HSZ_hsz, byte* psz, int cchMax, int iCodePage);
    [DllImport(lib, EntryPoint = "DdeQueryStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int DdeQueryString(int idInst, pointer unfoundType_HSZ_hsz, string psz, int cchMax, int iCodePage);
    [DllImport(lib, EntryPoint = "DdeQueryStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int DdeQueryString(int idInst, pointer unfoundType_HSZ_hsz, char* psz, int cchMax, int iCodePage);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int DdeQueryStringW(int idInst, pointer unfoundType_HSZ_hsz, string psz, int cchMax, int iCodePage);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int DdeQueryStringW(int idInst, pointer unfoundType_HSZ_hsz, char* psz, int cchMax, int iCodePage);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DdeFreeStringHandle(int idInst, pointer unfoundType_HSZ_hsz);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DdeKeepStringHandle(int idInst, pointer unfoundType_HSZ_hsz);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int DdeCmpStringHandles(pointer unfoundType_HSZ_hsz1, pointer unfoundType_HSZ_hsz2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int wvsprintfA([MarshalAs(UnmanagedType.LPStr)] string unnamed_0, [MarshalAs(UnmanagedType.LPStr)] string unnamed_1, pointer arglist);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int wvsprintfA([MarshalAs(UnmanagedType.LPStr)] string unnamed_0, byte* unnamed_1, pointer arglist);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int wvsprintfA(ReadOnlySpan<byte> unnamed_0, [MarshalAs(UnmanagedType.LPStr)] string unnamed_1, pointer arglist);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int wvsprintfA(ReadOnlySpan<byte> unnamed_0, byte* unnamed_1, pointer arglist);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int wvsprintfA(byte* unnamed_0, [MarshalAs(UnmanagedType.LPStr)] string unnamed_1, pointer arglist);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int wvsprintfA(byte* unnamed_0, byte* unnamed_1, pointer arglist);
    [DllImport(lib, EntryPoint = "wvsprintfW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int wvsprintf(string unnamed_0, [MarshalAs(UnmanagedType.LPWStr)] string unnamed_1, pointer arglist);
    [DllImport(lib, EntryPoint = "wvsprintfW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int wvsprintf(string unnamed_0, char* unnamed_1, pointer arglist);
    [DllImport(lib, EntryPoint = "wvsprintfW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int wvsprintf(char* unnamed_0, [MarshalAs(UnmanagedType.LPWStr)] string unnamed_1, pointer arglist);
    [DllImport(lib, EntryPoint = "wvsprintfW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int wvsprintf(char* unnamed_0, char* unnamed_1, pointer arglist);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int wvsprintfW(string unnamed_0, [MarshalAs(UnmanagedType.LPWStr)] string unnamed_1, pointer arglist);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int wvsprintfW(string unnamed_0, char* unnamed_1, pointer arglist);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int wvsprintfW(char* unnamed_0, [MarshalAs(UnmanagedType.LPWStr)] string unnamed_1, pointer arglist);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int wvsprintfW(char* unnamed_0, char* unnamed_1, pointer arglist);
    [DllImport(lib, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
    public static extern
        int wsprintfA([MarshalAs(UnmanagedType.LPStr)] string unnamed_0, [MarshalAs(UnmanagedType.LPStr)] string unnamed_1, pointer unnamed_2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
    public static extern
        int wsprintfA([MarshalAs(UnmanagedType.LPStr)] string unnamed_0, byte* unnamed_1, pointer unnamed_2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
    public static extern
        int wsprintfA(ReadOnlySpan<byte> unnamed_0, [MarshalAs(UnmanagedType.LPStr)] string unnamed_1, pointer unnamed_2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
    public static extern
        int wsprintfA(ReadOnlySpan<byte> unnamed_0, byte* unnamed_1, pointer unnamed_2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
    public static extern
        int wsprintfA(byte* unnamed_0, [MarshalAs(UnmanagedType.LPStr)] string unnamed_1, pointer unnamed_2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
    public static extern
        int wsprintfA(byte* unnamed_0, byte* unnamed_1, pointer unnamed_2);
    [DllImport(lib, EntryPoint = "wsprintfW", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
    public static extern
        int wsprintf(string unnamed_0, [MarshalAs(UnmanagedType.LPWStr)] string unnamed_1, pointer unnamed_2);
    [DllImport(lib, EntryPoint = "wsprintfW", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
    public static extern
        int wsprintf(string unnamed_0, char* unnamed_1, pointer unnamed_2);
    [DllImport(lib, EntryPoint = "wsprintfW", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
    public static extern
        int wsprintf(char* unnamed_0, [MarshalAs(UnmanagedType.LPWStr)] string unnamed_1, pointer unnamed_2);
    [DllImport(lib, EntryPoint = "wsprintfW", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
    public static extern
        int wsprintf(char* unnamed_0, char* unnamed_1, pointer unnamed_2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
    public static extern
        int wsprintfW(string unnamed_0, [MarshalAs(UnmanagedType.LPWStr)] string unnamed_1, pointer unnamed_2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
    public static extern
        int wsprintfW(string unnamed_0, char* unnamed_1, pointer unnamed_2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
    public static extern
        int wsprintfW(char* unnamed_0, [MarshalAs(UnmanagedType.LPWStr)] string unnamed_1, pointer unnamed_2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
    public static extern
        int wsprintfW(char* unnamed_0, char* unnamed_1, pointer unnamed_2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadKeyboardLayoutA([MarshalAs(UnmanagedType.LPStr)] string pwszKLID, uint Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadKeyboardLayoutA(byte* pwszKLID, uint Flags);
    [DllImport(lib, EntryPoint = "LoadKeyboardLayoutW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadKeyboardLayout([MarshalAs(UnmanagedType.LPWStr)] string pwszKLID, uint Flags);
    [DllImport(lib, EntryPoint = "LoadKeyboardLayoutW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadKeyboardLayout(char* pwszKLID, uint Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadKeyboardLayoutW([MarshalAs(UnmanagedType.LPWStr)] string pwszKLID, uint Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadKeyboardLayoutW(char* pwszKLID, uint Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer ActivateKeyboardLayout(pointer unfoundType_HKL_hkl, uint Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ToUnicodeEx(uint wVirtKey, uint wScanCode, pointer unfoundType_BYTElpKeyStatelpKeyState_unnamed_2, string pwszBuff, int cchBuff, uint wFlags, pointer unfoundType_HKL_dwhkl);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ToUnicodeEx(uint wVirtKey, uint wScanCode, pointer unfoundType_BYTElpKeyStatelpKeyState_unnamed_2, char* pwszBuff, int cchBuff, uint wFlags, pointer unfoundType_HKL_dwhkl);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UnloadKeyboardLayout(pointer unfoundType_HKL_hkl);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetKeyboardLayoutNameA([MarshalAs(UnmanagedType.LPStr)] string pwszKLID);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetKeyboardLayoutNameA(ReadOnlySpan<byte> pwszKLID);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetKeyboardLayoutNameA(byte* pwszKLID);
    [DllImport(lib, EntryPoint = "GetKeyboardLayoutNameW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetKeyboardLayoutName(string pwszKLID);
    [DllImport(lib, EntryPoint = "GetKeyboardLayoutNameW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetKeyboardLayoutName(char* pwszKLID);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetKeyboardLayoutNameW(string pwszKLID);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetKeyboardLayoutNameW(char* pwszKLID);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetKeyboardLayoutList(int nBuff, pointer unfoundType_HKLlpListlpList_unnamed_1);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetKeyboardLayout(int idThread);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetMouseMovePointsEx(uint cbSize, pointer unfoundType_LPMOUSEMOVEPOINT_lppt, pointer unfoundType_LPMOUSEMOVEPOINT_lpptBuf, int nBufPoints, int resolution);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateDesktopA([MarshalAs(UnmanagedType.LPStr)] string lpszDesktop, [MarshalAs(UnmanagedType.LPStr)] string lpszDevice, pointer unfoundType_DEVMODEA_pDevmode, int dwFlags, pointer unfoundType_ACCESS_MASK_dwDesiredAccess, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateDesktopA([MarshalAs(UnmanagedType.LPStr)] string lpszDesktop, byte* lpszDevice, pointer unfoundType_DEVMODEA_pDevmode, int dwFlags, pointer unfoundType_ACCESS_MASK_dwDesiredAccess, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateDesktopA(byte* lpszDesktop, [MarshalAs(UnmanagedType.LPStr)] string lpszDevice, pointer unfoundType_DEVMODEA_pDevmode, int dwFlags, pointer unfoundType_ACCESS_MASK_dwDesiredAccess, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateDesktopA(byte* lpszDesktop, byte* lpszDevice, pointer unfoundType_DEVMODEA_pDevmode, int dwFlags, pointer unfoundType_ACCESS_MASK_dwDesiredAccess, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport(lib, EntryPoint = "CreateDesktopW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateDesktop([MarshalAs(UnmanagedType.LPWStr)] string lpszDesktop, [MarshalAs(UnmanagedType.LPWStr)] string lpszDevice, pointer unfoundType_DEVMODEW_pDevmode, int dwFlags, pointer unfoundType_ACCESS_MASK_dwDesiredAccess, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport(lib, EntryPoint = "CreateDesktopW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateDesktop([MarshalAs(UnmanagedType.LPWStr)] string lpszDesktop, char* lpszDevice, pointer unfoundType_DEVMODEW_pDevmode, int dwFlags, pointer unfoundType_ACCESS_MASK_dwDesiredAccess, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport(lib, EntryPoint = "CreateDesktopW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateDesktop(char* lpszDesktop, [MarshalAs(UnmanagedType.LPWStr)] string lpszDevice, pointer unfoundType_DEVMODEW_pDevmode, int dwFlags, pointer unfoundType_ACCESS_MASK_dwDesiredAccess, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport(lib, EntryPoint = "CreateDesktopW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateDesktop(char* lpszDesktop, char* lpszDevice, pointer unfoundType_DEVMODEW_pDevmode, int dwFlags, pointer unfoundType_ACCESS_MASK_dwDesiredAccess, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateDesktopW([MarshalAs(UnmanagedType.LPWStr)] string lpszDesktop, [MarshalAs(UnmanagedType.LPWStr)] string lpszDevice, pointer unfoundType_DEVMODEW_pDevmode, int dwFlags, pointer unfoundType_ACCESS_MASK_dwDesiredAccess, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateDesktopW([MarshalAs(UnmanagedType.LPWStr)] string lpszDesktop, char* lpszDevice, pointer unfoundType_DEVMODEW_pDevmode, int dwFlags, pointer unfoundType_ACCESS_MASK_dwDesiredAccess, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateDesktopW(char* lpszDesktop, [MarshalAs(UnmanagedType.LPWStr)] string lpszDevice, pointer unfoundType_DEVMODEW_pDevmode, int dwFlags, pointer unfoundType_ACCESS_MASK_dwDesiredAccess, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateDesktopW(char* lpszDesktop, char* lpszDevice, pointer unfoundType_DEVMODEW_pDevmode, int dwFlags, pointer unfoundType_ACCESS_MASK_dwDesiredAccess, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateDesktopExA([MarshalAs(UnmanagedType.LPStr)] string lpszDesktop, [MarshalAs(UnmanagedType.LPStr)] string lpszDevice, pointer unfoundType_DEVMODEA_pDevmode, int dwFlags, pointer unfoundType_ACCESS_MASK_dwDesiredAccess, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa, uint ulHeapSize, pointer pvoid);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateDesktopExA([MarshalAs(UnmanagedType.LPStr)] string lpszDesktop, byte* lpszDevice, pointer unfoundType_DEVMODEA_pDevmode, int dwFlags, pointer unfoundType_ACCESS_MASK_dwDesiredAccess, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa, uint ulHeapSize, pointer pvoid);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateDesktopExA(byte* lpszDesktop, [MarshalAs(UnmanagedType.LPStr)] string lpszDevice, pointer unfoundType_DEVMODEA_pDevmode, int dwFlags, pointer unfoundType_ACCESS_MASK_dwDesiredAccess, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa, uint ulHeapSize, pointer pvoid);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateDesktopExA(byte* lpszDesktop, byte* lpszDevice, pointer unfoundType_DEVMODEA_pDevmode, int dwFlags, pointer unfoundType_ACCESS_MASK_dwDesiredAccess, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa, uint ulHeapSize, pointer pvoid);
    [DllImport(lib, EntryPoint = "CreateDesktopExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateDesktopEx([MarshalAs(UnmanagedType.LPWStr)] string lpszDesktop, [MarshalAs(UnmanagedType.LPWStr)] string lpszDevice, pointer unfoundType_DEVMODEW_pDevmode, int dwFlags, pointer unfoundType_ACCESS_MASK_dwDesiredAccess, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa, uint ulHeapSize, pointer pvoid);
    [DllImport(lib, EntryPoint = "CreateDesktopExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateDesktopEx([MarshalAs(UnmanagedType.LPWStr)] string lpszDesktop, char* lpszDevice, pointer unfoundType_DEVMODEW_pDevmode, int dwFlags, pointer unfoundType_ACCESS_MASK_dwDesiredAccess, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa, uint ulHeapSize, pointer pvoid);
    [DllImport(lib, EntryPoint = "CreateDesktopExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateDesktopEx(char* lpszDesktop, [MarshalAs(UnmanagedType.LPWStr)] string lpszDevice, pointer unfoundType_DEVMODEW_pDevmode, int dwFlags, pointer unfoundType_ACCESS_MASK_dwDesiredAccess, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa, uint ulHeapSize, pointer pvoid);
    [DllImport(lib, EntryPoint = "CreateDesktopExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateDesktopEx(char* lpszDesktop, char* lpszDevice, pointer unfoundType_DEVMODEW_pDevmode, int dwFlags, pointer unfoundType_ACCESS_MASK_dwDesiredAccess, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa, uint ulHeapSize, pointer pvoid);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateDesktopExW([MarshalAs(UnmanagedType.LPWStr)] string lpszDesktop, [MarshalAs(UnmanagedType.LPWStr)] string lpszDevice, pointer unfoundType_DEVMODEW_pDevmode, int dwFlags, pointer unfoundType_ACCESS_MASK_dwDesiredAccess, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa, uint ulHeapSize, pointer pvoid);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateDesktopExW([MarshalAs(UnmanagedType.LPWStr)] string lpszDesktop, char* lpszDevice, pointer unfoundType_DEVMODEW_pDevmode, int dwFlags, pointer unfoundType_ACCESS_MASK_dwDesiredAccess, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa, uint ulHeapSize, pointer pvoid);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateDesktopExW(char* lpszDesktop, [MarshalAs(UnmanagedType.LPWStr)] string lpszDevice, pointer unfoundType_DEVMODEW_pDevmode, int dwFlags, pointer unfoundType_ACCESS_MASK_dwDesiredAccess, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa, uint ulHeapSize, pointer pvoid);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateDesktopExW(char* lpszDesktop, char* lpszDevice, pointer unfoundType_DEVMODEW_pDevmode, int dwFlags, pointer unfoundType_ACCESS_MASK_dwDesiredAccess, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa, uint ulHeapSize, pointer pvoid);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenDesktopA([MarshalAs(UnmanagedType.LPStr)] string lpszDesktop, int dwFlags, bool fInherit, pointer unfoundType_ACCESS_MASK_dwDesiredAccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenDesktopA(byte* lpszDesktop, int dwFlags, bool fInherit, pointer unfoundType_ACCESS_MASK_dwDesiredAccess);
    [DllImport(lib, EntryPoint = "OpenDesktopW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenDesktop([MarshalAs(UnmanagedType.LPWStr)] string lpszDesktop, int dwFlags, bool fInherit, pointer unfoundType_ACCESS_MASK_dwDesiredAccess);
    [DllImport(lib, EntryPoint = "OpenDesktopW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenDesktop(char* lpszDesktop, int dwFlags, bool fInherit, pointer unfoundType_ACCESS_MASK_dwDesiredAccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenDesktopW([MarshalAs(UnmanagedType.LPWStr)] string lpszDesktop, int dwFlags, bool fInherit, pointer unfoundType_ACCESS_MASK_dwDesiredAccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenDesktopW(char* lpszDesktop, int dwFlags, bool fInherit, pointer unfoundType_ACCESS_MASK_dwDesiredAccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenInputDesktop(int dwFlags, bool fInherit, pointer unfoundType_ACCESS_MASK_dwDesiredAccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumDesktopsA(pointer unfoundType_HWINSTA_hwinsta, pointer unfoundType_DESKTOPENUMPROCA_lpEnumFunc, long lParam);
    [DllImport(lib, EntryPoint = "EnumDesktopsW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumDesktops(pointer unfoundType_HWINSTA_hwinsta, pointer unfoundType_DESKTOPENUMPROCW_lpEnumFunc, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumDesktopsW(pointer unfoundType_HWINSTA_hwinsta, pointer unfoundType_DESKTOPENUMPROCW_lpEnumFunc, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumDesktopWindows(pointer unfoundType_HDESK_hDesktop, pointer unfoundType_WNDENUMPROC_lpfn, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SwitchDesktop(pointer unfoundType_HDESK_hDesktop);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetThreadDesktop(pointer unfoundType_HDESK_hDesktop);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CloseDesktop(pointer unfoundType_HDESK_hDesktop);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetThreadDesktop(int dwThreadId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateWindowStationA([MarshalAs(UnmanagedType.LPStr)] string lpwinsta, int dwFlags, pointer unfoundType_ACCESS_MASK_dwDesiredAccess, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateWindowStationA(byte* lpwinsta, int dwFlags, pointer unfoundType_ACCESS_MASK_dwDesiredAccess, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport(lib, EntryPoint = "CreateWindowStationW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateWindowStation([MarshalAs(UnmanagedType.LPWStr)] string lpwinsta, int dwFlags, pointer unfoundType_ACCESS_MASK_dwDesiredAccess, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport(lib, EntryPoint = "CreateWindowStationW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateWindowStation(char* lpwinsta, int dwFlags, pointer unfoundType_ACCESS_MASK_dwDesiredAccess, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateWindowStationW([MarshalAs(UnmanagedType.LPWStr)] string lpwinsta, int dwFlags, pointer unfoundType_ACCESS_MASK_dwDesiredAccess, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateWindowStationW(char* lpwinsta, int dwFlags, pointer unfoundType_ACCESS_MASK_dwDesiredAccess, pointer unfoundType_LPSECURITY_ATTRIBUTES_lpsa);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenWindowStationA([MarshalAs(UnmanagedType.LPStr)] string lpszWinSta, bool fInherit, pointer unfoundType_ACCESS_MASK_dwDesiredAccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenWindowStationA(byte* lpszWinSta, bool fInherit, pointer unfoundType_ACCESS_MASK_dwDesiredAccess);
    [DllImport(lib, EntryPoint = "OpenWindowStationW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenWindowStation([MarshalAs(UnmanagedType.LPWStr)] string lpszWinSta, bool fInherit, pointer unfoundType_ACCESS_MASK_dwDesiredAccess);
    [DllImport(lib, EntryPoint = "OpenWindowStationW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenWindowStation(char* lpszWinSta, bool fInherit, pointer unfoundType_ACCESS_MASK_dwDesiredAccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenWindowStationW([MarshalAs(UnmanagedType.LPWStr)] string lpszWinSta, bool fInherit, pointer unfoundType_ACCESS_MASK_dwDesiredAccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer OpenWindowStationW(char* lpszWinSta, bool fInherit, pointer unfoundType_ACCESS_MASK_dwDesiredAccess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumWindowStationsA(pointer unfoundType_WINSTAENUMPROCA_lpEnumFunc, long lParam);
    [DllImport(lib, EntryPoint = "EnumWindowStationsW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumWindowStations(pointer unfoundType_WINSTAENUMPROCW_lpEnumFunc, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumWindowStationsW(pointer unfoundType_WINSTAENUMPROCW_lpEnumFunc, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CloseWindowStation(pointer unfoundType_HWINSTA_hWinSta);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetProcessWindowStation(pointer unfoundType_HWINSTA_hWinSta);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetProcessWindowStation();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetUserObjectSecurity(pointer hObj, pointer unfoundType_PSECURITY_INFORMATION_pSIRequested, pointer unfoundType_PSECURITY_DESCRIPTOR_pSID);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetUserObjectSecurity(pointer hObj, pointer unfoundType_PSECURITY_INFORMATION_pSIRequested, pointer unfoundType_PSECURITY_DESCRIPTOR_pSID, int nLength, pointer unfoundType_LPDWORD_lpnLengthNeeded);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetUserObjectInformationA(pointer hObj, int nIndex, pointer pvInfo, int nLength, pointer unfoundType_LPDWORD_lpnLengthNeeded);
    [DllImport(lib, EntryPoint = "GetUserObjectInformationW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetUserObjectInformation(pointer hObj, int nIndex, pointer pvInfo, int nLength, pointer unfoundType_LPDWORD_lpnLengthNeeded);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetUserObjectInformationW(pointer hObj, int nIndex, pointer pvInfo, int nLength, pointer unfoundType_LPDWORD_lpnLengthNeeded);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetUserObjectInformationA(pointer hObj, int nIndex, pointer pvInfo, int nLength);
    [DllImport(lib, EntryPoint = "SetUserObjectInformationW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetUserObjectInformation(pointer hObj, int nIndex, pointer pvInfo, int nLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetUserObjectInformationW(pointer hObj, int nIndex, pointer pvInfo, int nLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsHungAppWindow(pointer hwnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void DisableProcessWindowsGhosting();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint RegisterWindowMessageA([MarshalAs(UnmanagedType.LPStr)] string lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint RegisterWindowMessageA(byte* lpString);
    [DllImport(lib, EntryPoint = "RegisterWindowMessageW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint RegisterWindowMessage([MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport(lib, EntryPoint = "RegisterWindowMessageW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint RegisterWindowMessage(char* lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint RegisterWindowMessageW([MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint RegisterWindowMessageW(char* lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool TrackMouseEvent(pointer unfoundType_LPTRACKMOUSEEVENT_lpEventTrack);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DrawEdge(pointer hdc, pointer unfoundType_LPRECT_qrc, uint edge, uint grfFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DrawFrameControl(pointer unnamed_0, pointer unfoundType_LPRECT_unnamed_1, uint unnamed_2, uint unnamed_3);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DrawCaption(pointer hwnd, pointer hdc, pointer unfoundType_RECT_lprect, uint flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DrawAnimatedRects(pointer hwnd, int idAni, pointer unfoundType_RECTlprcFromlprcFrom_unnamed_2, pointer unfoundType_RECTlprcTolprcTo_unnamed_3);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetMessageA(pointer unfoundType_LPMSG_lpMsg, pointer hWnd, uint wMsgFilterMin, uint wMsgFilterMax);
    [DllImport(lib, EntryPoint = "GetMessageW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetMessage(pointer unfoundType_LPMSG_lpMsg, pointer hWnd, uint wMsgFilterMin, uint wMsgFilterMax);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetMessageW(pointer unfoundType_LPMSG_lpMsg, pointer hWnd, uint wMsgFilterMin, uint wMsgFilterMax);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool TranslateMessage(pointer unfoundType_MSGlpMsglpMsg_unnamed_0);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        long DispatchMessageA(pointer unfoundType_MSGlpMsglpMsg_unnamed_0);
    [DllImport(lib, EntryPoint = "DispatchMessageW", SetLastError = true, ExactSpelling = true)]
    public static extern
        long DispatchMessage(pointer unfoundType_MSGlpMsglpMsg_unnamed_0);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        long DispatchMessageW(pointer unfoundType_MSGlpMsglpMsg_unnamed_0);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetMessageQueue(int cMessagesMax);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool PeekMessageA(pointer unfoundType_LPMSG_lpMsg, pointer hWnd, uint wMsgFilterMin, uint wMsgFilterMax, uint wRemoveMsg);
    [DllImport(lib, EntryPoint = "PeekMessageW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool PeekMessage(pointer unfoundType_LPMSG_lpMsg, pointer hWnd, uint wMsgFilterMin, uint wMsgFilterMax, uint wRemoveMsg);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool PeekMessageW(pointer unfoundType_LPMSG_lpMsg, pointer hWnd, uint wMsgFilterMin, uint wMsgFilterMax, uint wRemoveMsg);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool RegisterHotKey(pointer hWnd, int id, uint fsModifiers, uint vk);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UnregisterHotKey(pointer hWnd, int id);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ExitWindowsEx(uint uFlags, int dwReason);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SwapMouseButton(bool fSwap);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetMessagePos();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetMessageTime();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        long GetMessageExtraInfo();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetUnpredictedMessagePos();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsWow64Message();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        long SetMessageExtraInfo(long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        long SendMessageA(pointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport(lib, EntryPoint = "SendMessageW", SetLastError = true, ExactSpelling = true)]
    public static extern
        long SendMessage(pointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        long SendMessageW(pointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        long SendMessageTimeoutA(pointer hWnd, uint Msg, ulong wParam, long lParam, uint fuFlags, uint uTimeout, pointer unfoundType_PDWORD_PTR_lpdwResult);
    [DllImport(lib, EntryPoint = "SendMessageTimeoutW", SetLastError = true, ExactSpelling = true)]
    public static extern
        long SendMessageTimeout(pointer hWnd, uint Msg, ulong wParam, long lParam, uint fuFlags, uint uTimeout, pointer unfoundType_PDWORD_PTR_lpdwResult);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        long SendMessageTimeoutW(pointer hWnd, uint Msg, ulong wParam, long lParam, uint fuFlags, uint uTimeout, pointer unfoundType_PDWORD_PTR_lpdwResult);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SendNotifyMessageA(pointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport(lib, EntryPoint = "SendNotifyMessageW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SendNotifyMessage(pointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SendNotifyMessageW(pointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SendMessageCallbackA(pointer hWnd, uint Msg, ulong wParam, long lParam, pointer unfoundType_SENDASYNCPROC_lpResultCallBack, pointer unfoundType_ULONG_PTR_dwData);
    [DllImport(lib, EntryPoint = "SendMessageCallbackW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SendMessageCallback(pointer hWnd, uint Msg, ulong wParam, long lParam, pointer unfoundType_SENDASYNCPROC_lpResultCallBack, pointer unfoundType_ULONG_PTR_dwData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SendMessageCallbackW(pointer hWnd, uint Msg, ulong wParam, long lParam, pointer unfoundType_SENDASYNCPROC_lpResultCallBack, pointer unfoundType_ULONG_PTR_dwData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int BroadcastSystemMessageExA(int flags, pointer unfoundType_LPDWORD_lpInfo, uint Msg, ulong wParam, long lParam, pointer unfoundType_PBSMINFO_pbsmInfo);
    [DllImport(lib, EntryPoint = "BroadcastSystemMessageExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int BroadcastSystemMessageEx(int flags, pointer unfoundType_LPDWORD_lpInfo, uint Msg, ulong wParam, long lParam, pointer unfoundType_PBSMINFO_pbsmInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int BroadcastSystemMessageExW(int flags, pointer unfoundType_LPDWORD_lpInfo, uint Msg, ulong wParam, long lParam, pointer unfoundType_PBSMINFO_pbsmInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int BroadcastSystemMessageA(int flags, pointer unfoundType_LPDWORD_lpInfo, uint Msg, ulong wParam, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int BroadcastSystemMessageW(int flags, pointer unfoundType_LPDWORD_lpInfo, uint Msg, ulong wParam, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int BroadcastSystemMessage(int flags, pointer unfoundType_LPDWORD_lpInfo, uint Msg, ulong wParam, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegisterDeviceNotificationA(pointer hRecipient, pointer NotificationFilter, int Flags);
    [DllImport(lib, EntryPoint = "RegisterDeviceNotificationW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegisterDeviceNotification(pointer hRecipient, pointer NotificationFilter, int Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegisterDeviceNotificationW(pointer hRecipient, pointer NotificationFilter, int Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UnregisterDeviceNotification(pointer unfoundType_HDEVNOTIFY_Handle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegisterPowerSettingNotification(pointer hRecipient, pointer unfoundType_LPCGUID_PowerSettingGuid, int Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UnregisterPowerSettingNotification(pointer unfoundType_HPOWERNOTIFY_Handle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RegisterSuspendResumeNotification(pointer hRecipient, int Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UnregisterSuspendResumeNotification(pointer unfoundType_HPOWERNOTIFY_Handle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool PostMessageA(pointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport(lib, EntryPoint = "PostMessageW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool PostMessage(pointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool PostMessageW(pointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool PostThreadMessageA(int idThread, uint Msg, ulong wParam, long lParam);
    [DllImport(lib, EntryPoint = "PostThreadMessageW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool PostThreadMessage(int idThread, uint Msg, ulong wParam, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool PostThreadMessageW(int idThread, uint Msg, ulong wParam, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AttachThreadInput(int idAttach, int idAttachTo, bool fAttach);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReplyMessage(long lResult);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WaitMessage();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int WaitForInputIdle(pointer hProcess, int dwMilliseconds);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer DefWindowProcA(pointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport(lib, EntryPoint = "DefWindowProcW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer DefWindowProc(pointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer DefWindowProcW(pointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void PostQuitMessage(int nExitCode);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        long CallWindowProcA(pointer unfoundType_WNDPROC_lpPrevWndFunc, pointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport(lib, EntryPoint = "CallWindowProcW", SetLastError = true, ExactSpelling = true)]
    public static extern
        long CallWindowProc(pointer unfoundType_WNDPROC_lpPrevWndFunc, pointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        long CallWindowProcW(pointer unfoundType_WNDPROC_lpPrevWndFunc, pointer hWnd, uint Msg, ulong wParam, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool InSendMessage();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int InSendMessageEx(pointer lpReserved);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetDoubleClickTime();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetDoubleClickTime(uint unnamed_0);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        short RegisterClassA(pointer unfoundType_WNDCLASSAlpWndClasslpWndClass_unnamed_0);
    [DllImport(lib, EntryPoint = "RegisterClassW", SetLastError = true, ExactSpelling = true)]
    public static extern
        short RegisterClass(pointer unfoundType_WNDCLASSWlpWndClasslpWndClass_unnamed_0);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        short RegisterClassW(pointer unfoundType_WNDCLASSWlpWndClasslpWndClass_unnamed_0);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UnregisterClassA([MarshalAs(UnmanagedType.LPStr)] string lpClassName, pointer unfoundType_HINSTANCE_hInstance);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UnregisterClassA(byte* lpClassName, pointer unfoundType_HINSTANCE_hInstance);
    [DllImport(lib, EntryPoint = "UnregisterClassW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UnregisterClass([MarshalAs(UnmanagedType.LPWStr)] string lpClassName, pointer unfoundType_HINSTANCE_hInstance);
    [DllImport(lib, EntryPoint = "UnregisterClassW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UnregisterClass(char* lpClassName, pointer unfoundType_HINSTANCE_hInstance);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UnregisterClassW([MarshalAs(UnmanagedType.LPWStr)] string lpClassName, pointer unfoundType_HINSTANCE_hInstance);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UnregisterClassW(char* lpClassName, pointer unfoundType_HINSTANCE_hInstance);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetClassInfoA(pointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPStr)] string lpClassName, pointer unfoundType_LPWNDCLASSA_lpWndClass);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetClassInfoA(pointer unfoundType_HINSTANCE_hInstance, byte* lpClassName, pointer unfoundType_LPWNDCLASSA_lpWndClass);
    [DllImport(lib, EntryPoint = "GetClassInfoW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetClassInfo(pointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpClassName, pointer unfoundType_LPWNDCLASSW_lpWndClass);
    [DllImport(lib, EntryPoint = "GetClassInfoW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetClassInfo(pointer unfoundType_HINSTANCE_hInstance, char* lpClassName, pointer unfoundType_LPWNDCLASSW_lpWndClass);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetClassInfoW(pointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpClassName, pointer unfoundType_LPWNDCLASSW_lpWndClass);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetClassInfoW(pointer unfoundType_HINSTANCE_hInstance, char* lpClassName, pointer unfoundType_LPWNDCLASSW_lpWndClass);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        short RegisterClassExA(pointer unfoundType_WNDCLASSEXA_unnamed_0);
    [DllImport(lib, EntryPoint = "RegisterClassExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        short RegisterClassEx(pointer unfoundType_WNDCLASSEXW_unnamed_0);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        short RegisterClassExW(pointer unfoundType_WNDCLASSEXW_unnamed_0);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetClassInfoExA(pointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPStr)] string lpszClass, pointer unfoundType_LPWNDCLASSEXA_lpwcx);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetClassInfoExA(pointer unfoundType_HINSTANCE_hInstance, byte* lpszClass, pointer unfoundType_LPWNDCLASSEXA_lpwcx);
    [DllImport(lib, EntryPoint = "GetClassInfoExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetClassInfoEx(pointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpszClass, pointer unfoundType_LPWNDCLASSEXW_lpwcx);
    [DllImport(lib, EntryPoint = "GetClassInfoExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetClassInfoEx(pointer unfoundType_HINSTANCE_hInstance, char* lpszClass, pointer unfoundType_LPWNDCLASSEXW_lpwcx);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetClassInfoExW(pointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpszClass, pointer unfoundType_LPWNDCLASSEXW_lpwcx);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetClassInfoExW(pointer unfoundType_HINSTANCE_hInstance, char* lpszClass, pointer unfoundType_LPWNDCLASSEXW_lpwcx);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateWindowExA(int dwExStyle, [MarshalAs(UnmanagedType.LPStr)] string lpClassName, [MarshalAs(UnmanagedType.LPStr)] string lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, pointer hWndParent, pointer hMenu, pointer unfoundType_HINSTANCE_hInstance, pointer lpParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateWindowExA(int dwExStyle, [MarshalAs(UnmanagedType.LPStr)] string lpClassName, byte* lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, pointer hWndParent, pointer hMenu, pointer unfoundType_HINSTANCE_hInstance, pointer lpParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateWindowExA(int dwExStyle, byte* lpClassName, [MarshalAs(UnmanagedType.LPStr)] string lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, pointer hWndParent, pointer hMenu, pointer unfoundType_HINSTANCE_hInstance, pointer lpParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateWindowExA(int dwExStyle, byte* lpClassName, byte* lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, pointer hWndParent, pointer hMenu, pointer unfoundType_HINSTANCE_hInstance, pointer lpParam);
    [DllImport(lib, EntryPoint = "CreateWindowExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateWindowEx(int dwExStyle, [MarshalAs(UnmanagedType.LPWStr)] string lpClassName, [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, pointer hWndParent, pointer hMenu, pointer unfoundType_HINSTANCE_hInstance, pointer lpParam);
    [DllImport(lib, EntryPoint = "CreateWindowExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateWindowEx(int dwExStyle, [MarshalAs(UnmanagedType.LPWStr)] string lpClassName, char* lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, pointer hWndParent, pointer hMenu, pointer unfoundType_HINSTANCE_hInstance, pointer lpParam);
    [DllImport(lib, EntryPoint = "CreateWindowExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateWindowEx(int dwExStyle, char* lpClassName, [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, pointer hWndParent, pointer hMenu, pointer unfoundType_HINSTANCE_hInstance, pointer lpParam);
    [DllImport(lib, EntryPoint = "CreateWindowExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateWindowEx(int dwExStyle, char* lpClassName, char* lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, pointer hWndParent, pointer hMenu, pointer unfoundType_HINSTANCE_hInstance, pointer lpParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateWindowExW(int dwExStyle, [MarshalAs(UnmanagedType.LPWStr)] string lpClassName, [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, pointer hWndParent, pointer hMenu, pointer unfoundType_HINSTANCE_hInstance, pointer lpParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateWindowExW(int dwExStyle, [MarshalAs(UnmanagedType.LPWStr)] string lpClassName, char* lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, pointer hWndParent, pointer hMenu, pointer unfoundType_HINSTANCE_hInstance, pointer lpParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateWindowExW(int dwExStyle, char* lpClassName, [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, pointer hWndParent, pointer hMenu, pointer unfoundType_HINSTANCE_hInstance, pointer lpParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateWindowExW(int dwExStyle, char* lpClassName, char* lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, pointer hWndParent, pointer hMenu, pointer unfoundType_HINSTANCE_hInstance, pointer lpParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsWindow(pointer hWnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsMenu(pointer hMenu);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsChild(pointer hWndParent, pointer hWnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DestroyWindow(pointer hWnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ShowWindow(pointer hWnd, int nCmdShow);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AnimateWindow(pointer hWnd, int dwTime, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UpdateLayeredWindow(pointer hWnd, pointer hdcDst, pointer unfoundType_POINT_pptDst, pointer unfoundType_SIZE_psize, pointer hdcSrc, pointer unfoundType_POINT_pptSrc, pointer unfoundType_COLORREF_crKey, pointer unfoundType_BLENDFUNCTION_pblend, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UpdateLayeredWindowIndirect(pointer hWnd, pointer unfoundType_UPDATELAYEREDWINDOWINFO_pULWInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetLayeredWindowAttributes(pointer hwnd, pointer unfoundType_COLORREF_pcrKey, pointer pbAlpha, pointer pdwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool PrintWindow(pointer hwnd, pointer hdcBlt, uint nFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetLayeredWindowAttributes(pointer hwnd, pointer unfoundType_COLORREF_crKey, byte bAlpha, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ShowWindowAsync(pointer hWnd, int nCmdShow);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FlashWindow(pointer hWnd, bool bInvert);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool FlashWindowEx(pointer unfoundType_PFLASHWINFO_pfwi);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ShowOwnedPopups(pointer hWnd, bool fShow);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool OpenIcon(pointer hWnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CloseWindow(pointer hWnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MoveWindow(pointer hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetWindowPos(pointer hWnd, pointer hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetWindowPlacement(pointer hWnd, pointer unfoundType_WINDOWPLACEMENTlpwndpllpwndpl_unnamed_1);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetWindowPlacement(pointer hWnd, pointer unfoundType_WINDOWPLACEMENTlpwndpllpwndpl_unnamed_1);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetWindowDisplayAffinity(pointer hWnd, pointer pdwAffinity);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetWindowDisplayAffinity(pointer hWnd, int dwAffinity);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer BeginDeferWindowPos(int nNumWindows);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer DeferWindowPos(pointer unfoundType_HDWP_hWinPosInfo, pointer hWnd, pointer hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EndDeferWindowPos(pointer unfoundType_HDWP_hWinPosInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsWindowVisible(pointer hWnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsIconic(pointer hWnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AnyPopup();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool BringWindowToTop(pointer hWnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsZoomed(pointer hWnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateDialogParamA(pointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPStr)] string lpTemplateName, pointer hWndParent, pointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateDialogParamA(pointer unfoundType_HINSTANCE_hInstance, byte* lpTemplateName, pointer hWndParent, pointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport(lib, EntryPoint = "CreateDialogParamW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateDialogParam(pointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpTemplateName, pointer hWndParent, pointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport(lib, EntryPoint = "CreateDialogParamW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateDialogParam(pointer unfoundType_HINSTANCE_hInstance, char* lpTemplateName, pointer hWndParent, pointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateDialogParamW(pointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpTemplateName, pointer hWndParent, pointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateDialogParamW(pointer unfoundType_HINSTANCE_hInstance, char* lpTemplateName, pointer hWndParent, pointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateDialogIndirectParamA(pointer unfoundType_HINSTANCE_hInstance, pointer unfoundType_LPCDLGTEMPLATEA_lpTemplate, pointer hWndParent, pointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport(lib, EntryPoint = "CreateDialogIndirectParamW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateDialogIndirectParam(pointer unfoundType_HINSTANCE_hInstance, pointer unfoundType_LPCDLGTEMPLATEW_lpTemplate, pointer hWndParent, pointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateDialogIndirectParamW(pointer unfoundType_HINSTANCE_hInstance, pointer unfoundType_LPCDLGTEMPLATEW_lpTemplate, pointer hWndParent, pointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer DialogBoxParamA(pointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPStr)] string lpTemplateName, pointer hWndParent, pointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer DialogBoxParamA(pointer unfoundType_HINSTANCE_hInstance, byte* lpTemplateName, pointer hWndParent, pointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport(lib, EntryPoint = "DialogBoxParamW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer DialogBoxParam(pointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpTemplateName, pointer hWndParent, pointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport(lib, EntryPoint = "DialogBoxParamW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer DialogBoxParam(pointer unfoundType_HINSTANCE_hInstance, char* lpTemplateName, pointer hWndParent, pointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer DialogBoxParamW(pointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpTemplateName, pointer hWndParent, pointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer DialogBoxParamW(pointer unfoundType_HINSTANCE_hInstance, char* lpTemplateName, pointer hWndParent, pointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer DialogBoxIndirectParamA(pointer unfoundType_HINSTANCE_hInstance, pointer unfoundType_LPCDLGTEMPLATEA_hDialogTemplate, pointer hWndParent, pointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport(lib, EntryPoint = "DialogBoxIndirectParamW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer DialogBoxIndirectParam(pointer unfoundType_HINSTANCE_hInstance, pointer unfoundType_LPCDLGTEMPLATEW_hDialogTemplate, pointer hWndParent, pointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer DialogBoxIndirectParamW(pointer unfoundType_HINSTANCE_hInstance, pointer unfoundType_LPCDLGTEMPLATEW_hDialogTemplate, pointer hWndParent, pointer unfoundType_DLGPROC_lpDialogFunc, long dwInitParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EndDialog(pointer hDlg, pointer unfoundType_INT_PTR_nResult);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetDlgItem(pointer hDlg, int nIDDlgItem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetDlgItemInt(pointer hDlg, int nIDDlgItem, uint uValue, bool bSigned);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetDlgItemInt(pointer hDlg, int nIDDlgItem, pointer unfoundType_BOOLlpTranslatedlpTranslated_unnamed_2, bool bSigned);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetDlgItemTextA(pointer hDlg, int nIDDlgItem, [MarshalAs(UnmanagedType.LPStr)] string lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetDlgItemTextA(pointer hDlg, int nIDDlgItem, byte* lpString);
    [DllImport(lib, EntryPoint = "SetDlgItemTextW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetDlgItemText(pointer hDlg, int nIDDlgItem, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport(lib, EntryPoint = "SetDlgItemTextW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetDlgItemText(pointer hDlg, int nIDDlgItem, char* lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetDlgItemTextW(pointer hDlg, int nIDDlgItem, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetDlgItemTextW(pointer hDlg, int nIDDlgItem, char* lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetDlgItemTextA(pointer hDlg, int nIDDlgItem, [MarshalAs(UnmanagedType.LPStr)] string lpString, int cchMax);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetDlgItemTextA(pointer hDlg, int nIDDlgItem, ReadOnlySpan<byte> lpString, int cchMax);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetDlgItemTextA(pointer hDlg, int nIDDlgItem, byte* lpString, int cchMax);
    [DllImport(lib, EntryPoint = "GetDlgItemTextW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetDlgItemText(pointer hDlg, int nIDDlgItem, string lpString, int cchMax);
    [DllImport(lib, EntryPoint = "GetDlgItemTextW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetDlgItemText(pointer hDlg, int nIDDlgItem, char* lpString, int cchMax);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetDlgItemTextW(pointer hDlg, int nIDDlgItem, string lpString, int cchMax);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetDlgItemTextW(pointer hDlg, int nIDDlgItem, char* lpString, int cchMax);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckDlgButton(pointer hDlg, int nIDButton, uint uCheck);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckRadioButton(pointer hDlg, int nIDFirstButton, int nIDLastButton, int nIDCheckButton);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint IsDlgButtonChecked(pointer hDlg, int nIDButton);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        long SendDlgItemMessageA(pointer hDlg, int nIDDlgItem, uint Msg, ulong wParam, long lParam);
    [DllImport(lib, EntryPoint = "SendDlgItemMessageW", SetLastError = true, ExactSpelling = true)]
    public static extern
        long SendDlgItemMessage(pointer hDlg, int nIDDlgItem, uint Msg, ulong wParam, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        long SendDlgItemMessageW(pointer hDlg, int nIDDlgItem, uint Msg, ulong wParam, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetNextDlgGroupItem(pointer hDlg, pointer hCtl, bool bPrevious);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetNextDlgTabItem(pointer hDlg, pointer hCtl, bool bPrevious);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDlgCtrlID(pointer hWnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDialogBaseUnits();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer DefDlgProcA(pointer hDlg, uint Msg, ulong wParam, long lParam);
    [DllImport(lib, EntryPoint = "DefDlgProcW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer DefDlgProc(pointer hDlg, uint Msg, ulong wParam, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer DefDlgProcW(pointer hDlg, uint Msg, ulong wParam, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetDialogControlDpiChangeBehavior(pointer hWnd, pointer unfoundType_DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS_mask, pointer unfoundType_DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS_values);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetDialogControlDpiChangeBehavior(pointer hWnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetDialogDpiChangeBehavior(pointer hDlg, pointer unfoundType_DIALOG_DPI_CHANGE_BEHAVIORS_mask, pointer unfoundType_DIALOG_DPI_CHANGE_BEHAVIORS_values);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetDialogDpiChangeBehavior(pointer hDlg);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CallMsgFilterA(pointer unfoundType_LPMSG_lpMsg, int nCode);
    [DllImport(lib, EntryPoint = "CallMsgFilterW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CallMsgFilter(pointer unfoundType_LPMSG_lpMsg, int nCode);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CallMsgFilterW(pointer unfoundType_LPMSG_lpMsg, int nCode);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool OpenClipboard(pointer hWndNewOwner);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CloseClipboard();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetClipboardSequenceNumber();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetClipboardOwner();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer SetClipboardViewer(pointer hWndNewViewer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetClipboardViewer();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ChangeClipboardChain(pointer hWndRemove, pointer hWndNewNext);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer SetClipboardData(uint uFormat, pointer hMem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetClipboardData(uint uFormat);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetClipboardMetadata(uint format, pointer unfoundType_PGETCLIPBMETADATA_metadata);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint RegisterClipboardFormatA([MarshalAs(UnmanagedType.LPStr)] string lpszFormat);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint RegisterClipboardFormatA(byte* lpszFormat);
    [DllImport(lib, EntryPoint = "RegisterClipboardFormatW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint RegisterClipboardFormat([MarshalAs(UnmanagedType.LPWStr)] string lpszFormat);
    [DllImport(lib, EntryPoint = "RegisterClipboardFormatW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint RegisterClipboardFormat(char* lpszFormat);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint RegisterClipboardFormatW([MarshalAs(UnmanagedType.LPWStr)] string lpszFormat);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint RegisterClipboardFormatW(char* lpszFormat);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CountClipboardFormats();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint EnumClipboardFormats(uint format);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetClipboardFormatNameA(uint format, [MarshalAs(UnmanagedType.LPStr)] string lpszFormatName, int cchMaxCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetClipboardFormatNameA(uint format, ReadOnlySpan<byte> lpszFormatName, int cchMaxCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetClipboardFormatNameA(uint format, byte* lpszFormatName, int cchMaxCount);
    [DllImport(lib, EntryPoint = "GetClipboardFormatNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetClipboardFormatName(uint format, string lpszFormatName, int cchMaxCount);
    [DllImport(lib, EntryPoint = "GetClipboardFormatNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetClipboardFormatName(uint format, char* lpszFormatName, int cchMaxCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetClipboardFormatNameW(uint format, string lpszFormatName, int cchMaxCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetClipboardFormatNameW(uint format, char* lpszFormatName, int cchMaxCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EmptyClipboard();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsClipboardFormatAvailable(uint format);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetPriorityClipboardFormat(pointer unfoundType_UINTpaFormatPriorityListpaFormatPriorityList_unnamed_0, int cFormats);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetOpenClipboardWindow();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AddClipboardFormatListener(pointer hwnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool RemoveClipboardFormatListener(pointer hwnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetUpdatedClipboardFormats(pointer unfoundType_PUINT_lpuiFormats, uint cFormats, pointer unfoundType_PUINT_pcFormatsOut);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CharToOemA([MarshalAs(UnmanagedType.LPStr)] string pSrc, [MarshalAs(UnmanagedType.LPStr)] string pDst);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CharToOemA([MarshalAs(UnmanagedType.LPStr)] string pSrc, ReadOnlySpan<byte> pDst);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CharToOemA([MarshalAs(UnmanagedType.LPStr)] string pSrc, byte* pDst);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CharToOemA(byte* pSrc, [MarshalAs(UnmanagedType.LPStr)] string pDst);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CharToOemA(byte* pSrc, ReadOnlySpan<byte> pDst);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CharToOemA(byte* pSrc, byte* pDst);
    [DllImport(lib, EntryPoint = "CharToOemW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CharToOem([MarshalAs(UnmanagedType.LPWStr)] string pSrc, [MarshalAs(UnmanagedType.LPStr)] string pDst);
    [DllImport(lib, EntryPoint = "CharToOemW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CharToOem([MarshalAs(UnmanagedType.LPWStr)] string pSrc, ReadOnlySpan<byte> pDst);
    [DllImport(lib, EntryPoint = "CharToOemW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CharToOem([MarshalAs(UnmanagedType.LPWStr)] string pSrc, byte* pDst);
    [DllImport(lib, EntryPoint = "CharToOemW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CharToOem(char* pSrc, [MarshalAs(UnmanagedType.LPStr)] string pDst);
    [DllImport(lib, EntryPoint = "CharToOemW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CharToOem(char* pSrc, ReadOnlySpan<byte> pDst);
    [DllImport(lib, EntryPoint = "CharToOemW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CharToOem(char* pSrc, byte* pDst);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CharToOemW([MarshalAs(UnmanagedType.LPWStr)] string pSrc, [MarshalAs(UnmanagedType.LPStr)] string pDst);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CharToOemW([MarshalAs(UnmanagedType.LPWStr)] string pSrc, ReadOnlySpan<byte> pDst);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CharToOemW([MarshalAs(UnmanagedType.LPWStr)] string pSrc, byte* pDst);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CharToOemW(char* pSrc, [MarshalAs(UnmanagedType.LPStr)] string pDst);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CharToOemW(char* pSrc, ReadOnlySpan<byte> pDst);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CharToOemW(char* pSrc, byte* pDst);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool OemToCharA([MarshalAs(UnmanagedType.LPStr)] string pSrc, [MarshalAs(UnmanagedType.LPStr)] string pDst);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool OemToCharA([MarshalAs(UnmanagedType.LPStr)] string pSrc, ReadOnlySpan<byte> pDst);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool OemToCharA([MarshalAs(UnmanagedType.LPStr)] string pSrc, byte* pDst);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool OemToCharA(byte* pSrc, [MarshalAs(UnmanagedType.LPStr)] string pDst);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool OemToCharA(byte* pSrc, ReadOnlySpan<byte> pDst);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool OemToCharA(byte* pSrc, byte* pDst);
    [DllImport(lib, EntryPoint = "OemToCharW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool OemToChar([MarshalAs(UnmanagedType.LPStr)] string pSrc, string pDst);
    [DllImport(lib, EntryPoint = "OemToCharW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool OemToChar([MarshalAs(UnmanagedType.LPStr)] string pSrc, char* pDst);
    [DllImport(lib, EntryPoint = "OemToCharW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool OemToChar(byte* pSrc, string pDst);
    [DllImport(lib, EntryPoint = "OemToCharW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool OemToChar(byte* pSrc, char* pDst);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool OemToCharW([MarshalAs(UnmanagedType.LPStr)] string pSrc, string pDst);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool OemToCharW([MarshalAs(UnmanagedType.LPStr)] string pSrc, char* pDst);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool OemToCharW(byte* pSrc, string pDst);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool OemToCharW(byte* pSrc, char* pDst);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CharToOemBuffA([MarshalAs(UnmanagedType.LPStr)] string lpszSrc, [MarshalAs(UnmanagedType.LPStr)] string lpszDst, int cchDstLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CharToOemBuffA([MarshalAs(UnmanagedType.LPStr)] string lpszSrc, ReadOnlySpan<byte> lpszDst, int cchDstLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CharToOemBuffA([MarshalAs(UnmanagedType.LPStr)] string lpszSrc, byte* lpszDst, int cchDstLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CharToOemBuffA(byte* lpszSrc, [MarshalAs(UnmanagedType.LPStr)] string lpszDst, int cchDstLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CharToOemBuffA(byte* lpszSrc, ReadOnlySpan<byte> lpszDst, int cchDstLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CharToOemBuffA(byte* lpszSrc, byte* lpszDst, int cchDstLength);
    [DllImport(lib, EntryPoint = "CharToOemBuffW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CharToOemBuff([MarshalAs(UnmanagedType.LPWStr)] string lpszSrc, [MarshalAs(UnmanagedType.LPStr)] string lpszDst, int cchDstLength);
    [DllImport(lib, EntryPoint = "CharToOemBuffW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CharToOemBuff([MarshalAs(UnmanagedType.LPWStr)] string lpszSrc, ReadOnlySpan<byte> lpszDst, int cchDstLength);
    [DllImport(lib, EntryPoint = "CharToOemBuffW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CharToOemBuff([MarshalAs(UnmanagedType.LPWStr)] string lpszSrc, byte* lpszDst, int cchDstLength);
    [DllImport(lib, EntryPoint = "CharToOemBuffW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CharToOemBuff(char* lpszSrc, [MarshalAs(UnmanagedType.LPStr)] string lpszDst, int cchDstLength);
    [DllImport(lib, EntryPoint = "CharToOemBuffW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CharToOemBuff(char* lpszSrc, ReadOnlySpan<byte> lpszDst, int cchDstLength);
    [DllImport(lib, EntryPoint = "CharToOemBuffW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CharToOemBuff(char* lpszSrc, byte* lpszDst, int cchDstLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CharToOemBuffW([MarshalAs(UnmanagedType.LPWStr)] string lpszSrc, [MarshalAs(UnmanagedType.LPStr)] string lpszDst, int cchDstLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CharToOemBuffW([MarshalAs(UnmanagedType.LPWStr)] string lpszSrc, ReadOnlySpan<byte> lpszDst, int cchDstLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CharToOemBuffW([MarshalAs(UnmanagedType.LPWStr)] string lpszSrc, byte* lpszDst, int cchDstLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CharToOemBuffW(char* lpszSrc, [MarshalAs(UnmanagedType.LPStr)] string lpszDst, int cchDstLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CharToOemBuffW(char* lpszSrc, ReadOnlySpan<byte> lpszDst, int cchDstLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CharToOemBuffW(char* lpszSrc, byte* lpszDst, int cchDstLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool OemToCharBuffA([MarshalAs(UnmanagedType.LPStr)] string lpszSrc, [MarshalAs(UnmanagedType.LPStr)] string lpszDst, int cchDstLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool OemToCharBuffA([MarshalAs(UnmanagedType.LPStr)] string lpszSrc, ReadOnlySpan<byte> lpszDst, int cchDstLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool OemToCharBuffA([MarshalAs(UnmanagedType.LPStr)] string lpszSrc, byte* lpszDst, int cchDstLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool OemToCharBuffA(byte* lpszSrc, [MarshalAs(UnmanagedType.LPStr)] string lpszDst, int cchDstLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool OemToCharBuffA(byte* lpszSrc, ReadOnlySpan<byte> lpszDst, int cchDstLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool OemToCharBuffA(byte* lpszSrc, byte* lpszDst, int cchDstLength);
    [DllImport(lib, EntryPoint = "OemToCharBuffW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool OemToCharBuff([MarshalAs(UnmanagedType.LPStr)] string lpszSrc, string lpszDst, int cchDstLength);
    [DllImport(lib, EntryPoint = "OemToCharBuffW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool OemToCharBuff([MarshalAs(UnmanagedType.LPStr)] string lpszSrc, char* lpszDst, int cchDstLength);
    [DllImport(lib, EntryPoint = "OemToCharBuffW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool OemToCharBuff(byte* lpszSrc, string lpszDst, int cchDstLength);
    [DllImport(lib, EntryPoint = "OemToCharBuffW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool OemToCharBuff(byte* lpszSrc, char* lpszDst, int cchDstLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool OemToCharBuffW([MarshalAs(UnmanagedType.LPStr)] string lpszSrc, string lpszDst, int cchDstLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool OemToCharBuffW([MarshalAs(UnmanagedType.LPStr)] string lpszSrc, char* lpszDst, int cchDstLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool OemToCharBuffW(byte* lpszSrc, string lpszDst, int cchDstLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool OemToCharBuffW(byte* lpszSrc, char* lpszDst, int cchDstLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        byte* CharUpperA_([MarshalAs(UnmanagedType.LPStr)] string lpsz);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        byte* CharUpperA_(ReadOnlySpan<byte> lpsz);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        byte* CharUpperA_(byte* lpsz);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ReadOnlySpan<byte> CharUpperA([MarshalAs(UnmanagedType.LPStr)] string lpsz);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ReadOnlySpan<byte> CharUpperA(ReadOnlySpan<byte> lpsz);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ReadOnlySpan<byte> CharUpperA(byte* lpsz);
    [DllImport(lib, EntryPoint = "CharUpperW", SetLastError = true, ExactSpelling = true)]
    public static extern
        char* CharUpper_(string lpsz);
    [DllImport(lib, EntryPoint = "CharUpperW", SetLastError = true, ExactSpelling = true)]
    public static extern
        char* CharUpper_(char* lpsz);
    [DllImport(lib, EntryPoint = "CharUpperW", SetLastError = true, ExactSpelling = true)]
    public static extern
        string CharUpper(string lpsz);
    [DllImport(lib, EntryPoint = "CharUpperW", SetLastError = true, ExactSpelling = true)]
    public static extern
        string CharUpper(char* lpsz);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        char* CharUpperW_(string lpsz);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        char* CharUpperW_(char* lpsz);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        string CharUpperW(string lpsz);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        string CharUpperW(char* lpsz);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CharUpperBuffA([MarshalAs(UnmanagedType.LPStr)] string lpsz, int cchLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CharUpperBuffA(ReadOnlySpan<byte> lpsz, int cchLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CharUpperBuffA(byte* lpsz, int cchLength);
    [DllImport(lib, EntryPoint = "CharUpperBuffW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int CharUpperBuff(string lpsz, int cchLength);
    [DllImport(lib, EntryPoint = "CharUpperBuffW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int CharUpperBuff(char* lpsz, int cchLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CharUpperBuffW(string lpsz, int cchLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CharUpperBuffW(char* lpsz, int cchLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        byte* CharLowerA_([MarshalAs(UnmanagedType.LPStr)] string lpsz);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        byte* CharLowerA_(ReadOnlySpan<byte> lpsz);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        byte* CharLowerA_(byte* lpsz);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ReadOnlySpan<byte> CharLowerA([MarshalAs(UnmanagedType.LPStr)] string lpsz);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ReadOnlySpan<byte> CharLowerA(ReadOnlySpan<byte> lpsz);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ReadOnlySpan<byte> CharLowerA(byte* lpsz);
    [DllImport(lib, EntryPoint = "CharLowerW", SetLastError = true, ExactSpelling = true)]
    public static extern
        char* CharLower_(string lpsz);
    [DllImport(lib, EntryPoint = "CharLowerW", SetLastError = true, ExactSpelling = true)]
    public static extern
        char* CharLower_(char* lpsz);
    [DllImport(lib, EntryPoint = "CharLowerW", SetLastError = true, ExactSpelling = true)]
    public static extern
        string CharLower(string lpsz);
    [DllImport(lib, EntryPoint = "CharLowerW", SetLastError = true, ExactSpelling = true)]
    public static extern
        string CharLower(char* lpsz);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        char* CharLowerW_(string lpsz);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        char* CharLowerW_(char* lpsz);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        string CharLowerW(string lpsz);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        string CharLowerW(char* lpsz);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CharLowerBuffA([MarshalAs(UnmanagedType.LPStr)] string lpsz, int cchLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CharLowerBuffA(ReadOnlySpan<byte> lpsz, int cchLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CharLowerBuffA(byte* lpsz, int cchLength);
    [DllImport(lib, EntryPoint = "CharLowerBuffW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int CharLowerBuff(string lpsz, int cchLength);
    [DllImport(lib, EntryPoint = "CharLowerBuffW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int CharLowerBuff(char* lpsz, int cchLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CharLowerBuffW(string lpsz, int cchLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CharLowerBuffW(char* lpsz, int cchLength);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        byte* CharNextA_([MarshalAs(UnmanagedType.LPStr)] string lpsz);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        byte* CharNextA_(byte* lpsz);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ReadOnlySpan<byte> CharNextA([MarshalAs(UnmanagedType.LPStr)] string lpsz);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ReadOnlySpan<byte> CharNextA(byte* lpsz);
    [DllImport(lib, EntryPoint = "CharNextW", SetLastError = true, ExactSpelling = true)]
    public static extern
        char* CharNext_([MarshalAs(UnmanagedType.LPWStr)] string lpsz);
    [DllImport(lib, EntryPoint = "CharNextW", SetLastError = true, ExactSpelling = true)]
    public static extern
        char* CharNext_(char* lpsz);
    [DllImport(lib, EntryPoint = "CharNextW", SetLastError = true, ExactSpelling = true)]
    public static extern
        string CharNext([MarshalAs(UnmanagedType.LPWStr)] string lpsz);
    [DllImport(lib, EntryPoint = "CharNextW", SetLastError = true, ExactSpelling = true)]
    public static extern
        string CharNext(char* lpsz);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        char* CharNextW_([MarshalAs(UnmanagedType.LPWStr)] string lpsz);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        char* CharNextW_(char* lpsz);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        string CharNextW([MarshalAs(UnmanagedType.LPWStr)] string lpsz);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        string CharNextW(char* lpsz);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        byte* CharPrevA_([MarshalAs(UnmanagedType.LPStr)] string lpszStart, [MarshalAs(UnmanagedType.LPStr)] string lpszCurrent);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        byte* CharPrevA_([MarshalAs(UnmanagedType.LPStr)] string lpszStart, byte* lpszCurrent);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        byte* CharPrevA_(byte* lpszStart, [MarshalAs(UnmanagedType.LPStr)] string lpszCurrent);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        byte* CharPrevA_(byte* lpszStart, byte* lpszCurrent);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ReadOnlySpan<byte> CharPrevA([MarshalAs(UnmanagedType.LPStr)] string lpszStart, [MarshalAs(UnmanagedType.LPStr)] string lpszCurrent);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ReadOnlySpan<byte> CharPrevA([MarshalAs(UnmanagedType.LPStr)] string lpszStart, byte* lpszCurrent);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ReadOnlySpan<byte> CharPrevA(byte* lpszStart, [MarshalAs(UnmanagedType.LPStr)] string lpszCurrent);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ReadOnlySpan<byte> CharPrevA(byte* lpszStart, byte* lpszCurrent);
    [DllImport(lib, EntryPoint = "CharPrevW", SetLastError = true, ExactSpelling = true)]
    public static extern
        char* CharPrev_([MarshalAs(UnmanagedType.LPWStr)] string lpszStart, [MarshalAs(UnmanagedType.LPWStr)] string lpszCurrent);
    [DllImport(lib, EntryPoint = "CharPrevW", SetLastError = true, ExactSpelling = true)]
    public static extern
        char* CharPrev_([MarshalAs(UnmanagedType.LPWStr)] string lpszStart, char* lpszCurrent);
    [DllImport(lib, EntryPoint = "CharPrevW", SetLastError = true, ExactSpelling = true)]
    public static extern
        char* CharPrev_(char* lpszStart, [MarshalAs(UnmanagedType.LPWStr)] string lpszCurrent);
    [DllImport(lib, EntryPoint = "CharPrevW", SetLastError = true, ExactSpelling = true)]
    public static extern
        char* CharPrev_(char* lpszStart, char* lpszCurrent);
    [DllImport(lib, EntryPoint = "CharPrevW", SetLastError = true, ExactSpelling = true)]
    public static extern
        string CharPrev([MarshalAs(UnmanagedType.LPWStr)] string lpszStart, [MarshalAs(UnmanagedType.LPWStr)] string lpszCurrent);
    [DllImport(lib, EntryPoint = "CharPrevW", SetLastError = true, ExactSpelling = true)]
    public static extern
        string CharPrev([MarshalAs(UnmanagedType.LPWStr)] string lpszStart, char* lpszCurrent);
    [DllImport(lib, EntryPoint = "CharPrevW", SetLastError = true, ExactSpelling = true)]
    public static extern
        string CharPrev(char* lpszStart, [MarshalAs(UnmanagedType.LPWStr)] string lpszCurrent);
    [DllImport(lib, EntryPoint = "CharPrevW", SetLastError = true, ExactSpelling = true)]
    public static extern
        string CharPrev(char* lpszStart, char* lpszCurrent);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        char* CharPrevW_([MarshalAs(UnmanagedType.LPWStr)] string lpszStart, [MarshalAs(UnmanagedType.LPWStr)] string lpszCurrent);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        char* CharPrevW_([MarshalAs(UnmanagedType.LPWStr)] string lpszStart, char* lpszCurrent);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        char* CharPrevW_(char* lpszStart, [MarshalAs(UnmanagedType.LPWStr)] string lpszCurrent);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        char* CharPrevW_(char* lpszStart, char* lpszCurrent);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        string CharPrevW([MarshalAs(UnmanagedType.LPWStr)] string lpszStart, [MarshalAs(UnmanagedType.LPWStr)] string lpszCurrent);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        string CharPrevW([MarshalAs(UnmanagedType.LPWStr)] string lpszStart, char* lpszCurrent);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        string CharPrevW(char* lpszStart, [MarshalAs(UnmanagedType.LPWStr)] string lpszCurrent);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        string CharPrevW(char* lpszStart, char* lpszCurrent);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        byte* CharNextExA_(short CodePage, [MarshalAs(UnmanagedType.LPStr)] string lpCurrentChar, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        byte* CharNextExA_(short CodePage, byte* lpCurrentChar, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ReadOnlySpan<byte> CharNextExA(short CodePage, [MarshalAs(UnmanagedType.LPStr)] string lpCurrentChar, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ReadOnlySpan<byte> CharNextExA(short CodePage, byte* lpCurrentChar, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        byte* CharPrevExA_(short CodePage, [MarshalAs(UnmanagedType.LPStr)] string lpStart, [MarshalAs(UnmanagedType.LPStr)] string lpCurrentChar, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        byte* CharPrevExA_(short CodePage, [MarshalAs(UnmanagedType.LPStr)] string lpStart, byte* lpCurrentChar, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        byte* CharPrevExA_(short CodePage, byte* lpStart, [MarshalAs(UnmanagedType.LPStr)] string lpCurrentChar, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        byte* CharPrevExA_(short CodePage, byte* lpStart, byte* lpCurrentChar, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ReadOnlySpan<byte> CharPrevExA(short CodePage, [MarshalAs(UnmanagedType.LPStr)] string lpStart, [MarshalAs(UnmanagedType.LPStr)] string lpCurrentChar, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ReadOnlySpan<byte> CharPrevExA(short CodePage, [MarshalAs(UnmanagedType.LPStr)] string lpStart, byte* lpCurrentChar, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ReadOnlySpan<byte> CharPrevExA(short CodePage, byte* lpStart, [MarshalAs(UnmanagedType.LPStr)] string lpCurrentChar, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ReadOnlySpan<byte> CharPrevExA(short CodePage, byte* lpStart, byte* lpCurrentChar, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsCharAlphaA(byte ch);
    [DllImport(lib, EntryPoint = "IsCharAlphaW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsCharAlpha(char ch);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsCharAlphaW(char ch);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsCharAlphaNumericA(byte ch);
    [DllImport(lib, EntryPoint = "IsCharAlphaNumericW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsCharAlphaNumeric(char ch);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsCharAlphaNumericW(char ch);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsCharUpperA(byte ch);
    [DllImport(lib, EntryPoint = "IsCharUpperW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsCharUpper(char ch);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsCharUpperW(char ch);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsCharLowerA(byte ch);
    [DllImport(lib, EntryPoint = "IsCharLowerW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsCharLower(char ch);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsCharLowerW(char ch);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer SetFocus(pointer hWnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetActiveWindow();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetFocus();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetKBCodePage();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        short GetKeyState(int nVirtKey);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        short GetAsyncKeyState(int vKey);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetKeyboardState(pointer unfoundType_PBYTE_lpKeyState);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetKeyboardState(pointer unfoundType_LPBYTE_lpKeyState);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetKeyNameTextA(int lParam, [MarshalAs(UnmanagedType.LPStr)] string lpString, int cchSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetKeyNameTextA(int lParam, ReadOnlySpan<byte> lpString, int cchSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetKeyNameTextA(int lParam, byte* lpString, int cchSize);
    [DllImport(lib, EntryPoint = "GetKeyNameTextW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetKeyNameText(int lParam, string lpString, int cchSize);
    [DllImport(lib, EntryPoint = "GetKeyNameTextW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetKeyNameText(int lParam, char* lpString, int cchSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetKeyNameTextW(int lParam, string lpString, int cchSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetKeyNameTextW(int lParam, char* lpString, int cchSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetKeyboardType(int nTypeFlag);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ToAscii(uint uVirtKey, uint uScanCode, pointer unfoundType_BYTElpKeyStatelpKeyState_unnamed_2, pointer unfoundType_LPWORD_lpChar, uint uFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ToAsciiEx(uint uVirtKey, uint uScanCode, pointer unfoundType_BYTElpKeyStatelpKeyState_unnamed_2, pointer unfoundType_LPWORD_lpChar, uint uFlags, pointer unfoundType_HKL_dwhkl);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ToUnicode(uint wVirtKey, uint wScanCode, pointer unfoundType_BYTElpKeyStatelpKeyState_unnamed_2, string pwszBuff, int cchBuff, uint wFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ToUnicode(uint wVirtKey, uint wScanCode, pointer unfoundType_BYTElpKeyStatelpKeyState_unnamed_2, char* pwszBuff, int cchBuff, uint wFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int OemKeyScan(short wOemChar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        short VkKeyScanA(byte ch);
    [DllImport(lib, EntryPoint = "VkKeyScanW", SetLastError = true, ExactSpelling = true)]
    public static extern
        short VkKeyScan(char ch);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        short VkKeyScanW(char ch);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        short VkKeyScanExA(byte ch, pointer unfoundType_HKL_dwhkl);
    [DllImport(lib, EntryPoint = "VkKeyScanExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        short VkKeyScanEx(char ch, pointer unfoundType_HKL_dwhkl);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        short VkKeyScanExW(char ch, pointer unfoundType_HKL_dwhkl);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void keybd_event(byte bVk, byte bScan, int dwFlags, pointer unfoundType_ULONG_PTR_dwExtraInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void mouse_event(int dwFlags, int dx, int dy, int dwData, pointer unfoundType_ULONG_PTR_dwExtraInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint SendInput(uint cInputs, pointer unfoundType_LPINPUT_pInputs, int cbSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetTouchInputInfo(pointer unfoundType_HTOUCHINPUT_hTouchInput);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CloseTouchInputHandle(pointer unfoundType_HTOUCHINPUT_hTouchInput);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool RegisterTouchWindow(pointer hwnd, uint ulFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UnregisterTouchWindow(pointer hwnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsTouchWindow(pointer hwnd, pointer unfoundType_PULONG_pulFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool InitializeTouchInjection(uint maxCount, int dwMode);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool InjectTouchInput(uint count, pointer unfoundType_POINTER_TOUCH_INFOcontactscontacts_unnamed_1);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPointerType(uint pointerId, pointer unfoundType_POINTER_INPUT_TYPEpointerTypepointerType_unnamed_1);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPointerCursorId(uint pointerId, pointer unfoundType_UINT32cursorIdcursorId_unnamed_1);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPointerInfo(uint pointerId, pointer unfoundType_POINTER_INFOpointerInfopointerInfo_unnamed_1);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPointerInfoHistory(uint pointerId, pointer unfoundType_UINT32entriesCountentriesCount_unnamed_1, pointer unfoundType_POINTER_INFOpointerInfopointerInfo_unnamed_2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPointerFrameInfo(uint pointerId, pointer unfoundType_UINT32pointerCountpointerCount_unnamed_1, pointer unfoundType_POINTER_INFOpointerInfopointerInfo_unnamed_2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPointerFrameInfoHistory(uint pointerId, pointer unfoundType_UINT32entriesCountentriesCount_unnamed_1, pointer unfoundType_UINT32pointerCountpointerCount_unnamed_2, pointer unfoundType_POINTER_INFOpointerInfopointerInfo_unnamed_3);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPointerTouchInfo(uint pointerId, pointer unfoundType_POINTER_TOUCH_INFOtouchInfotouchInfo_unnamed_1);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPointerTouchInfoHistory(uint pointerId, pointer unfoundType_UINT32entriesCountentriesCount_unnamed_1, pointer unfoundType_POINTER_TOUCH_INFOtouchInfotouchInfo_unnamed_2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPointerFrameTouchInfo(uint pointerId, pointer unfoundType_UINT32pointerCountpointerCount_unnamed_1, pointer unfoundType_POINTER_TOUCH_INFOtouchInfotouchInfo_unnamed_2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPointerFrameTouchInfoHistory(uint pointerId, pointer unfoundType_UINT32entriesCountentriesCount_unnamed_1, pointer unfoundType_UINT32pointerCountpointerCount_unnamed_2, pointer unfoundType_POINTER_TOUCH_INFOtouchInfotouchInfo_unnamed_3);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPointerPenInfo(uint pointerId, pointer unfoundType_POINTER_PEN_INFOpenInfopenInfo_unnamed_1);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPointerPenInfoHistory(uint pointerId, pointer unfoundType_UINT32entriesCountentriesCount_unnamed_1, pointer unfoundType_POINTER_PEN_INFOpenInfopenInfo_unnamed_2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPointerFramePenInfo(uint pointerId, pointer unfoundType_UINT32pointerCountpointerCount_unnamed_1, pointer unfoundType_POINTER_PEN_INFOpenInfopenInfo_unnamed_2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPointerFramePenInfoHistory(uint pointerId, pointer unfoundType_UINT32entriesCountentriesCount_unnamed_1, pointer unfoundType_UINT32pointerCountpointerCount_unnamed_2, pointer unfoundType_POINTER_PEN_INFOpenInfopenInfo_unnamed_3);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SkipPointerFrameMessages(uint pointerId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool RegisterPointerInputTarget(pointer hwnd, pointer unfoundType_POINTER_INPUT_TYPE_pointerType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UnregisterPointerInputTarget(pointer hwnd, pointer unfoundType_POINTER_INPUT_TYPE_pointerType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool RegisterPointerInputTargetEx(pointer hwnd, pointer unfoundType_POINTER_INPUT_TYPE_pointerType, bool fObserve);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UnregisterPointerInputTargetEx(pointer hwnd, pointer unfoundType_POINTER_INPUT_TYPE_pointerType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateSyntheticPointerDevice(pointer unfoundType_POINTER_INPUT_TYPE_pointerType, uint maxCount, pointer unfoundType_POINTER_FEEDBACK_MODE_mode);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool InjectSyntheticPointerInput(pointer unfoundType_HSYNTHETICPOINTERDEVICE_device, pointer unfoundType_POINTER_TYPE_INFO_pointerInfo, uint count);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void DestroySyntheticPointerDevice(pointer unfoundType_HSYNTHETICPOINTERDEVICE_device);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnableMouseInPointer(bool fEnable);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsMouseInPointerEnabled();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool RegisterTouchHitTestingWindow(pointer hwnd, uint value);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EvaluateProximityToRect(pointer unfoundType_RECTcontrolBoundingBoxcontrolBoundingBox_unnamed_0, pointer unfoundType_TOUCH_HIT_TESTING_INPUTpHitTestingInputpHitTestingInput_unnamed_1, pointer unfoundType_TOUCH_HIT_TESTING_PROXIMITY_EVALUATIONpProximityEvalpProximityEval_unnamed_2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EvaluateProximityToPolygon(uint numVertices, pointer unfoundType_POINTcontrolPolygoncontrolPolygon_unnamed_1, pointer unfoundType_TOUCH_HIT_TESTING_INPUTpHitTestingInputpHitTestingInput_unnamed_2, pointer unfoundType_TOUCH_HIT_TESTING_PROXIMITY_EVALUATIONpProximityEvalpProximityEval_unnamed_3);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        long PackTouchHitTestingProximityEvaluation(pointer unfoundType_TOUCH_HIT_TESTING_INPUTpHitTestingInputpHitTestingInput_unnamed_0, pointer unfoundType_TOUCH_HIT_TESTING_PROXIMITY_EVALUATIONpProximityEvalpProximityEval_unnamed_1);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetWindowFeedbackSetting(pointer hwnd, pointer unfoundType_FEEDBACK_TYPE_feedback, int dwFlags, pointer pSize, pointer config);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetWindowFeedbackSetting(pointer hwnd, pointer unfoundType_FEEDBACK_TYPE_feedback, int dwFlags, uint size, pointer configuration);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPointerInputTransform(uint pointerId, uint historyCount, pointer unfoundType_INPUT_TRANSFORMinputTransforminputTransform_unnamed_2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetLastInputInfo(pointer unfoundType_PLASTINPUTINFO_plii);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint MapVirtualKeyA(uint uCode, uint uMapType);
    [DllImport(lib, EntryPoint = "MapVirtualKeyW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint MapVirtualKey(uint uCode, uint uMapType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint MapVirtualKeyW(uint uCode, uint uMapType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint MapVirtualKeyExA(uint uCode, uint uMapType, pointer unfoundType_HKL_dwhkl);
    [DllImport(lib, EntryPoint = "MapVirtualKeyExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint MapVirtualKeyEx(uint uCode, uint uMapType, pointer unfoundType_HKL_dwhkl);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint MapVirtualKeyExW(uint uCode, uint uMapType, pointer unfoundType_HKL_dwhkl);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetInputState();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetQueueStatus(uint flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetCapture();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer SetCapture(pointer hWnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ReleaseCapture();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int MsgWaitForMultipleObjects(int nCount, pointer unfoundType_HANDLEpHandlespHandles_unnamed_1, bool fWaitAll, int dwMilliseconds, int dwWakeMask);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int MsgWaitForMultipleObjectsEx(int nCount, pointer unfoundType_HANDLEpHandlespHandles_unnamed_1, int dwMilliseconds, int dwWakeMask, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ulong SetTimer(pointer hWnd, ulong nIDEvent, uint uElapse, pointer unfoundType_TIMERPROC_lpTimerFunc);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        ulong SetCoalescableTimer(pointer hWnd, ulong nIDEvent, uint uElapse, pointer unfoundType_TIMERPROC_lpTimerFunc, uint uToleranceDelay);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool KillTimer(pointer hWnd, ulong uIDEvent);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsWindowUnicode(pointer hWnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnableWindow(pointer hWnd, bool bEnable);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsWindowEnabled(pointer hWnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadAcceleratorsA(pointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPStr)] string lpTableName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadAcceleratorsA(pointer unfoundType_HINSTANCE_hInstance, byte* lpTableName);
    [DllImport(lib, EntryPoint = "LoadAcceleratorsW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadAccelerators(pointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpTableName);
    [DllImport(lib, EntryPoint = "LoadAcceleratorsW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadAccelerators(pointer unfoundType_HINSTANCE_hInstance, char* lpTableName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadAcceleratorsW(pointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpTableName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadAcceleratorsW(pointer unfoundType_HINSTANCE_hInstance, char* lpTableName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateAcceleratorTableA(pointer unfoundType_LPACCEL_paccel, int cAccel);
    [DllImport(lib, EntryPoint = "CreateAcceleratorTableW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateAcceleratorTable(pointer unfoundType_LPACCEL_paccel, int cAccel);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateAcceleratorTableW(pointer unfoundType_LPACCEL_paccel, int cAccel);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DestroyAcceleratorTable(pointer hAccel);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CopyAcceleratorTableA(pointer hAccelSrc, pointer unfoundType_LPACCEL_lpAccelDst, int cAccelEntries);
    [DllImport(lib, EntryPoint = "CopyAcceleratorTableW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int CopyAcceleratorTable(pointer hAccelSrc, pointer unfoundType_LPACCEL_lpAccelDst, int cAccelEntries);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CopyAcceleratorTableW(pointer hAccelSrc, pointer unfoundType_LPACCEL_lpAccelDst, int cAccelEntries);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int TranslateAcceleratorA(pointer hWnd, pointer hAccTable, pointer unfoundType_LPMSG_lpMsg);
    [DllImport(lib, EntryPoint = "TranslateAcceleratorW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int TranslateAccelerator(pointer hWnd, pointer hAccTable, pointer unfoundType_LPMSG_lpMsg);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int TranslateAcceleratorW(pointer hWnd, pointer hAccTable, pointer unfoundType_LPMSG_lpMsg);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetSystemMetrics(int nIndex);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetSystemMetricsForDpi(int nIndex, uint dpi);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadMenuA(pointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPStr)] string lpMenuName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadMenuA(pointer unfoundType_HINSTANCE_hInstance, byte* lpMenuName);
    [DllImport(lib, EntryPoint = "LoadMenuW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadMenu(pointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpMenuName);
    [DllImport(lib, EntryPoint = "LoadMenuW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadMenu(pointer unfoundType_HINSTANCE_hInstance, char* lpMenuName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadMenuW(pointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpMenuName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadMenuW(pointer unfoundType_HINSTANCE_hInstance, char* lpMenuName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadMenuIndirectA(pointer unfoundType_MENUTEMPLATEAlpMenuTemplatelpMenuTemplate_unnamed_0);
    [DllImport(lib, EntryPoint = "LoadMenuIndirectW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadMenuIndirect(pointer unfoundType_MENUTEMPLATEWlpMenuTemplatelpMenuTemplate_unnamed_0);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadMenuIndirectW(pointer unfoundType_MENUTEMPLATEWlpMenuTemplatelpMenuTemplate_unnamed_0);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetMenu(pointer hWnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetMenu(pointer hWnd, pointer hMenu);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ChangeMenuA(pointer hMenu, uint cmd, [MarshalAs(UnmanagedType.LPStr)] string lpszNewItem, uint cmdInsert, uint flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ChangeMenuA(pointer hMenu, uint cmd, byte* lpszNewItem, uint cmdInsert, uint flags);
    [DllImport(lib, EntryPoint = "ChangeMenuW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ChangeMenu(pointer hMenu, uint cmd, [MarshalAs(UnmanagedType.LPWStr)] string lpszNewItem, uint cmdInsert, uint flags);
    [DllImport(lib, EntryPoint = "ChangeMenuW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ChangeMenu(pointer hMenu, uint cmd, char* lpszNewItem, uint cmdInsert, uint flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ChangeMenuW(pointer hMenu, uint cmd, [MarshalAs(UnmanagedType.LPWStr)] string lpszNewItem, uint cmdInsert, uint flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ChangeMenuW(pointer hMenu, uint cmd, char* lpszNewItem, uint cmdInsert, uint flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool HiliteMenuItem(pointer hWnd, pointer hMenu, uint uIDHiliteItem, uint uHilite);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetMenuStringA(pointer hMenu, uint uIDItem, [MarshalAs(UnmanagedType.LPStr)] string lpString, int cchMax, uint flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetMenuStringA(pointer hMenu, uint uIDItem, ReadOnlySpan<byte> lpString, int cchMax, uint flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetMenuStringA(pointer hMenu, uint uIDItem, byte* lpString, int cchMax, uint flags);
    [DllImport(lib, EntryPoint = "GetMenuStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetMenuString(pointer hMenu, uint uIDItem, string lpString, int cchMax, uint flags);
    [DllImport(lib, EntryPoint = "GetMenuStringW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetMenuString(pointer hMenu, uint uIDItem, char* lpString, int cchMax, uint flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetMenuStringW(pointer hMenu, uint uIDItem, string lpString, int cchMax, uint flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetMenuStringW(pointer hMenu, uint uIDItem, char* lpString, int cchMax, uint flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetMenuState(pointer hMenu, uint uId, uint uFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DrawMenuBar(pointer hWnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetSystemMenu(pointer hWnd, bool bRevert);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateMenu();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreatePopupMenu();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DestroyMenu(pointer hMenu);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int CheckMenuItem(pointer hMenu, uint uIDCheckItem, uint uCheck);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnableMenuItem(pointer hMenu, uint uIDEnableItem, uint uEnable);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetSubMenu(pointer hMenu, int nPos);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetMenuItemID(pointer hMenu, int nPos);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetMenuItemCount(pointer hMenu);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool InsertMenuA(pointer hMenu, uint uPosition, uint uFlags, ulong uIDNewItem, [MarshalAs(UnmanagedType.LPStr)] string lpNewItem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool InsertMenuA(pointer hMenu, uint uPosition, uint uFlags, ulong uIDNewItem, byte* lpNewItem);
    [DllImport(lib, EntryPoint = "InsertMenuW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool InsertMenu(pointer hMenu, uint uPosition, uint uFlags, ulong uIDNewItem, [MarshalAs(UnmanagedType.LPWStr)] string lpNewItem);
    [DllImport(lib, EntryPoint = "InsertMenuW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool InsertMenu(pointer hMenu, uint uPosition, uint uFlags, ulong uIDNewItem, char* lpNewItem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool InsertMenuW(pointer hMenu, uint uPosition, uint uFlags, ulong uIDNewItem, [MarshalAs(UnmanagedType.LPWStr)] string lpNewItem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool InsertMenuW(pointer hMenu, uint uPosition, uint uFlags, ulong uIDNewItem, char* lpNewItem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AppendMenuA(pointer hMenu, uint uFlags, ulong uIDNewItem, [MarshalAs(UnmanagedType.LPStr)] string lpNewItem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AppendMenuA(pointer hMenu, uint uFlags, ulong uIDNewItem, byte* lpNewItem);
    [DllImport(lib, EntryPoint = "AppendMenuW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AppendMenu(pointer hMenu, uint uFlags, ulong uIDNewItem, [MarshalAs(UnmanagedType.LPWStr)] string lpNewItem);
    [DllImport(lib, EntryPoint = "AppendMenuW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AppendMenu(pointer hMenu, uint uFlags, ulong uIDNewItem, char* lpNewItem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AppendMenuW(pointer hMenu, uint uFlags, ulong uIDNewItem, [MarshalAs(UnmanagedType.LPWStr)] string lpNewItem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AppendMenuW(pointer hMenu, uint uFlags, ulong uIDNewItem, char* lpNewItem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ModifyMenuA(pointer hMnu, uint uPosition, uint uFlags, ulong uIDNewItem, [MarshalAs(UnmanagedType.LPStr)] string lpNewItem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ModifyMenuA(pointer hMnu, uint uPosition, uint uFlags, ulong uIDNewItem, byte* lpNewItem);
    [DllImport(lib, EntryPoint = "ModifyMenuW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ModifyMenu(pointer hMnu, uint uPosition, uint uFlags, ulong uIDNewItem, [MarshalAs(UnmanagedType.LPWStr)] string lpNewItem);
    [DllImport(lib, EntryPoint = "ModifyMenuW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ModifyMenu(pointer hMnu, uint uPosition, uint uFlags, ulong uIDNewItem, char* lpNewItem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ModifyMenuW(pointer hMnu, uint uPosition, uint uFlags, ulong uIDNewItem, [MarshalAs(UnmanagedType.LPWStr)] string lpNewItem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ModifyMenuW(pointer hMnu, uint uPosition, uint uFlags, ulong uIDNewItem, char* lpNewItem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DeleteMenu(pointer hMenu, uint uPosition, uint uFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetMenuItemBitmaps(pointer hMenu, uint uPosition, uint uFlags, pointer unfoundType_HBITMAP_hBitmapUnchecked, pointer unfoundType_HBITMAP_hBitmapChecked);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetMenuCheckMarkDimensions();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool TrackPopupMenu(pointer hMenu, uint uFlags, int x, int y, int nReserved, pointer hWnd, pointer unfoundType_RECTprcRectprcRect_unnamed_6);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool TrackPopupMenuEx(pointer hMenu, uint uFlags, int x, int y, pointer hwnd, pointer unfoundType_LPTPMPARAMS_lptpm);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CalculatePopupWindowPosition(pointer unfoundType_POINTanchorPointanchorPoint_unnamed_0, pointer unfoundType_SIZEwindowSizewindowSize_unnamed_1, uint flags, pointer unfoundType_RECTexcludeRectexcludeRect_unnamed_3, pointer unfoundType_RECTpopupWindowPositionpopupWindowPosition_unnamed_4);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetMenuInfo(pointer unnamed_0, pointer unfoundType_LPMENUINFO_unnamed_1);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetMenuInfo(pointer unnamed_0, pointer unfoundType_LPCMENUINFO_unnamed_1);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EndMenu();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool InsertMenuItemA(pointer hmenu, uint item, bool fByPosition, pointer unfoundType_LPCMENUITEMINFOA_lpmi);
    [DllImport(lib, EntryPoint = "InsertMenuItemW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool InsertMenuItem(pointer hmenu, uint item, bool fByPosition, pointer unfoundType_LPCMENUITEMINFOW_lpmi);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool InsertMenuItemW(pointer hmenu, uint item, bool fByPosition, pointer unfoundType_LPCMENUITEMINFOW_lpmi);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetMenuItemInfoA(pointer hmenu, uint item, bool fByPosition, pointer unfoundType_LPMENUITEMINFOA_lpmii);
    [DllImport(lib, EntryPoint = "GetMenuItemInfoW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetMenuItemInfo(pointer hmenu, uint item, bool fByPosition, pointer unfoundType_LPMENUITEMINFOW_lpmii);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetMenuItemInfoW(pointer hmenu, uint item, bool fByPosition, pointer unfoundType_LPMENUITEMINFOW_lpmii);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetMenuItemInfoA(pointer hmenu, uint item, bool fByPositon, pointer unfoundType_LPCMENUITEMINFOA_lpmii);
    [DllImport(lib, EntryPoint = "SetMenuItemInfoW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetMenuItemInfo(pointer hmenu, uint item, bool fByPositon, pointer unfoundType_LPCMENUITEMINFOW_lpmii);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetMenuItemInfoW(pointer hmenu, uint item, bool fByPositon, pointer unfoundType_LPCMENUITEMINFOW_lpmii);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetMenuDefaultItem(pointer hMenu, uint fByPos, uint gmdiFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetMenuDefaultItem(pointer hMenu, uint uItem, uint fByPos);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetMenuItemRect(pointer hWnd, pointer hMenu, uint uItem, pointer unfoundType_LPRECT_lprcItem);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int MenuItemFromPoint(pointer hWnd, pointer hMenu, pointer unfoundType_POINT_ptScreen);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int DragObject(pointer hwndParent, pointer hwndFrom, uint fmt, pointer unfoundType_ULONG_PTR_data, pointer unfoundType_HCURSOR_hcur);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DragDetect(pointer hwnd, pointer unfoundType_POINT_pt);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DrawIcon(pointer hDC, int X, int Y, pointer hIcon);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int DrawTextA(pointer hdc, [MarshalAs(UnmanagedType.LPStr)] string lpchText, int cchText, pointer unfoundType_LPRECT_lprc, uint format);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int DrawTextA(pointer hdc, byte* lpchText, int cchText, pointer unfoundType_LPRECT_lprc, uint format);
    [DllImport(lib, EntryPoint = "DrawTextW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int DrawText(pointer hdc, [MarshalAs(UnmanagedType.LPWStr)] string lpchText, int cchText, pointer unfoundType_LPRECT_lprc, uint format);
    [DllImport(lib, EntryPoint = "DrawTextW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int DrawText(pointer hdc, char* lpchText, int cchText, pointer unfoundType_LPRECT_lprc, uint format);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int DrawTextW(pointer hdc, [MarshalAs(UnmanagedType.LPWStr)] string lpchText, int cchText, pointer unfoundType_LPRECT_lprc, uint format);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int DrawTextW(pointer hdc, char* lpchText, int cchText, pointer unfoundType_LPRECT_lprc, uint format);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int DrawTextExA(pointer hdc, [MarshalAs(UnmanagedType.LPStr)] string lpchText, int cchText, pointer unfoundType_LPRECT_lprc, uint format, pointer unfoundType_LPDRAWTEXTPARAMS_lpdtp);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int DrawTextExA(pointer hdc, ReadOnlySpan<byte> lpchText, int cchText, pointer unfoundType_LPRECT_lprc, uint format, pointer unfoundType_LPDRAWTEXTPARAMS_lpdtp);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int DrawTextExA(pointer hdc, byte* lpchText, int cchText, pointer unfoundType_LPRECT_lprc, uint format, pointer unfoundType_LPDRAWTEXTPARAMS_lpdtp);
    [DllImport(lib, EntryPoint = "DrawTextExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int DrawTextEx(pointer hdc, string lpchText, int cchText, pointer unfoundType_LPRECT_lprc, uint format, pointer unfoundType_LPDRAWTEXTPARAMS_lpdtp);
    [DllImport(lib, EntryPoint = "DrawTextExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int DrawTextEx(pointer hdc, char* lpchText, int cchText, pointer unfoundType_LPRECT_lprc, uint format, pointer unfoundType_LPDRAWTEXTPARAMS_lpdtp);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int DrawTextExW(pointer hdc, string lpchText, int cchText, pointer unfoundType_LPRECT_lprc, uint format, pointer unfoundType_LPDRAWTEXTPARAMS_lpdtp);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int DrawTextExW(pointer hdc, char* lpchText, int cchText, pointer unfoundType_LPRECT_lprc, uint format, pointer unfoundType_LPDRAWTEXTPARAMS_lpdtp);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GrayStringA(pointer hDC, pointer hBrush, pointer unfoundType_GRAYSTRINGPROC_lpOutputFunc, long lpData, int nCount, int X, int Y, int nWidth, int nHeight);
    [DllImport(lib, EntryPoint = "GrayStringW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GrayString(pointer hDC, pointer hBrush, pointer unfoundType_GRAYSTRINGPROC_lpOutputFunc, long lpData, int nCount, int X, int Y, int nWidth, int nHeight);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GrayStringW(pointer hDC, pointer hBrush, pointer unfoundType_GRAYSTRINGPROC_lpOutputFunc, long lpData, int nCount, int X, int Y, int nWidth, int nHeight);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DrawStateA(pointer hdc, pointer hbrFore, pointer unfoundType_DRAWSTATEPROC_qfnCallBack, long lData, ulong wData, int x, int y, int cx, int cy, uint uFlags);
    [DllImport(lib, EntryPoint = "DrawStateW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DrawState(pointer hdc, pointer hbrFore, pointer unfoundType_DRAWSTATEPROC_qfnCallBack, long lData, ulong wData, int x, int y, int cx, int cy, uint uFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DrawStateW(pointer hdc, pointer hbrFore, pointer unfoundType_DRAWSTATEPROC_qfnCallBack, long lData, ulong wData, int x, int y, int cx, int cy, uint uFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int TabbedTextOutA(pointer hdc, int x, int y, [MarshalAs(UnmanagedType.LPStr)] string lpString, int chCount, int nTabPositions, pointer unfoundType_INTlpnTabStopPositionslpnTabStopPositions_unnamed_6, int nTabOrigin);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int TabbedTextOutA(pointer hdc, int x, int y, byte* lpString, int chCount, int nTabPositions, pointer unfoundType_INTlpnTabStopPositionslpnTabStopPositions_unnamed_6, int nTabOrigin);
    [DllImport(lib, EntryPoint = "TabbedTextOutW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int TabbedTextOut(pointer hdc, int x, int y, [MarshalAs(UnmanagedType.LPWStr)] string lpString, int chCount, int nTabPositions, pointer unfoundType_INTlpnTabStopPositionslpnTabStopPositions_unnamed_6, int nTabOrigin);
    [DllImport(lib, EntryPoint = "TabbedTextOutW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int TabbedTextOut(pointer hdc, int x, int y, char* lpString, int chCount, int nTabPositions, pointer unfoundType_INTlpnTabStopPositionslpnTabStopPositions_unnamed_6, int nTabOrigin);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int TabbedTextOutW(pointer hdc, int x, int y, [MarshalAs(UnmanagedType.LPWStr)] string lpString, int chCount, int nTabPositions, pointer unfoundType_INTlpnTabStopPositionslpnTabStopPositions_unnamed_6, int nTabOrigin);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int TabbedTextOutW(pointer hdc, int x, int y, char* lpString, int chCount, int nTabPositions, pointer unfoundType_INTlpnTabStopPositionslpnTabStopPositions_unnamed_6, int nTabOrigin);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTabbedTextExtentA(pointer hdc, [MarshalAs(UnmanagedType.LPStr)] string lpString, int chCount, int nTabPositions, pointer unfoundType_INTlpnTabStopPositionslpnTabStopPositions_unnamed_4);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTabbedTextExtentA(pointer hdc, byte* lpString, int chCount, int nTabPositions, pointer unfoundType_INTlpnTabStopPositionslpnTabStopPositions_unnamed_4);
    [DllImport(lib, EntryPoint = "GetTabbedTextExtentW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTabbedTextExtent(pointer hdc, [MarshalAs(UnmanagedType.LPWStr)] string lpString, int chCount, int nTabPositions, pointer unfoundType_INTlpnTabStopPositionslpnTabStopPositions_unnamed_4);
    [DllImport(lib, EntryPoint = "GetTabbedTextExtentW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTabbedTextExtent(pointer hdc, char* lpString, int chCount, int nTabPositions, pointer unfoundType_INTlpnTabStopPositionslpnTabStopPositions_unnamed_4);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTabbedTextExtentW(pointer hdc, [MarshalAs(UnmanagedType.LPWStr)] string lpString, int chCount, int nTabPositions, pointer unfoundType_INTlpnTabStopPositionslpnTabStopPositions_unnamed_4);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetTabbedTextExtentW(pointer hdc, char* lpString, int chCount, int nTabPositions, pointer unfoundType_INTlpnTabStopPositionslpnTabStopPositions_unnamed_4);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UpdateWindow(pointer hWnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer SetActiveWindow(pointer hWnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetForegroundWindow();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool PaintDesktop(pointer hdc);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void SwitchToThisWindow(pointer hwnd, bool fUnknown);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetForegroundWindow(pointer hWnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AllowSetForegroundWindow(int dwProcessId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool LockSetForegroundWindow(uint uLockCode);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer WindowFromDC(pointer hDC);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetDC(pointer hWnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetDCEx(pointer hWnd, pointer hrgnClip, int flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetWindowDC(pointer hWnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ReleaseDC(pointer hWnd, pointer hDC);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer BeginPaint(pointer hWnd, pointer unfoundType_LPPAINTSTRUCT_lpPaint);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EndPaint(pointer hWnd, pointer unfoundType_PAINTSTRUCTlpPaintlpPaint_unnamed_1);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetUpdateRect(pointer hWnd, pointer unfoundType_LPRECT_lpRect, bool bErase);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetUpdateRgn(pointer hWnd, pointer hRgn, bool bErase);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SetWindowRgn(pointer hWnd, pointer hRgn, bool bRedraw);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetWindowRgn(pointer hWnd, pointer hRgn);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetWindowRgnBox(pointer hWnd, pointer unfoundType_LPRECT_lprc);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ExcludeUpdateRgn(pointer hDC, pointer hWnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool InvalidateRect(pointer hWnd, pointer unfoundType_RECTlpRectlpRect_unnamed_1, bool bErase);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ValidateRect(pointer hWnd, pointer unfoundType_RECTlpRectlpRect_unnamed_1);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool InvalidateRgn(pointer hWnd, pointer hRgn, bool bErase);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ValidateRgn(pointer hWnd, pointer hRgn);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool RedrawWindow(pointer hWnd, pointer unfoundType_RECTlprcUpdatelprcUpdate_unnamed_1, pointer hrgnUpdate, uint flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool LockWindowUpdate(pointer hWndLock);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ScrollWindow(pointer hWnd, int XAmount, int YAmount, pointer unfoundType_RECTlpRectlpRect_unnamed_3, pointer unfoundType_RECTlpClipRectlpClipRect_unnamed_4);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ScrollDC(pointer hDC, int dx, int dy, pointer unfoundType_RECTlprcScrolllprcScroll_unnamed_3, pointer unfoundType_RECTlprcCliplprcClip_unnamed_4, pointer hrgnUpdate, pointer unfoundType_LPRECT_lprcUpdate);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ScrollWindowEx(pointer hWnd, int dx, int dy, pointer unfoundType_RECTprcScrollprcScroll_unnamed_3, pointer unfoundType_RECTprcClipprcClip_unnamed_4, pointer hrgnUpdate, pointer unfoundType_LPRECT_prcUpdate, uint flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SetScrollPos(pointer hWnd, int nBar, int nPos, bool bRedraw);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetScrollPos(pointer hWnd, int nBar);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetScrollRange(pointer hWnd, int nBar, int nMinPos, int nMaxPos, bool bRedraw);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetScrollRange(pointer hWnd, int nBar, pointer unfoundType_LPINT_lpMinPos, pointer unfoundType_LPINT_lpMaxPos);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ShowScrollBar(pointer hWnd, int wBar, bool bShow);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnableScrollBar(pointer hWnd, uint wSBflags, uint wArrows);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetPropA(pointer hWnd, [MarshalAs(UnmanagedType.LPStr)] string lpString, pointer hData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetPropA(pointer hWnd, byte* lpString, pointer hData);
    [DllImport(lib, EntryPoint = "SetPropW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetProp(pointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpString, pointer hData);
    [DllImport(lib, EntryPoint = "SetPropW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetProp(pointer hWnd, char* lpString, pointer hData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetPropW(pointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpString, pointer hData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetPropW(pointer hWnd, char* lpString, pointer hData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetPropA(pointer hWnd, [MarshalAs(UnmanagedType.LPStr)] string lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetPropA(pointer hWnd, byte* lpString);
    [DllImport(lib, EntryPoint = "GetPropW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetProp(pointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport(lib, EntryPoint = "GetPropW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetProp(pointer hWnd, char* lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetPropW(pointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetPropW(pointer hWnd, char* lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RemovePropA(pointer hWnd, [MarshalAs(UnmanagedType.LPStr)] string lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RemovePropA(pointer hWnd, byte* lpString);
    [DllImport(lib, EntryPoint = "RemovePropW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RemoveProp(pointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport(lib, EntryPoint = "RemovePropW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RemoveProp(pointer hWnd, char* lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RemovePropW(pointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RemovePropW(pointer hWnd, char* lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int EnumPropsExA(pointer hWnd, pointer unfoundType_PROPENUMPROCEXA_lpEnumFunc, long lParam);
    [DllImport(lib, EntryPoint = "EnumPropsExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int EnumPropsEx(pointer hWnd, pointer unfoundType_PROPENUMPROCEXW_lpEnumFunc, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int EnumPropsExW(pointer hWnd, pointer unfoundType_PROPENUMPROCEXW_lpEnumFunc, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int EnumPropsA(pointer hWnd, pointer unfoundType_PROPENUMPROCA_lpEnumFunc);
    [DllImport(lib, EntryPoint = "EnumPropsW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int EnumProps(pointer hWnd, pointer unfoundType_PROPENUMPROCW_lpEnumFunc);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int EnumPropsW(pointer hWnd, pointer unfoundType_PROPENUMPROCW_lpEnumFunc);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetWindowTextA(pointer hWnd, [MarshalAs(UnmanagedType.LPStr)] string lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetWindowTextA(pointer hWnd, byte* lpString);
    [DllImport(lib, EntryPoint = "SetWindowTextW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetWindowText(pointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport(lib, EntryPoint = "SetWindowTextW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetWindowText(pointer hWnd, char* lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetWindowTextW(pointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetWindowTextW(pointer hWnd, char* lpString);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetWindowTextA(pointer hWnd, [MarshalAs(UnmanagedType.LPStr)] string lpString, int nMaxCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetWindowTextA(pointer hWnd, ReadOnlySpan<byte> lpString, int nMaxCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetWindowTextA(pointer hWnd, byte* lpString, int nMaxCount);
    [DllImport(lib, EntryPoint = "GetWindowTextW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetWindowText(pointer hWnd, string lpString, int nMaxCount);
    [DllImport(lib, EntryPoint = "GetWindowTextW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetWindowText(pointer hWnd, char* lpString, int nMaxCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetWindowTextW(pointer hWnd, string lpString, int nMaxCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetWindowTextW(pointer hWnd, char* lpString, int nMaxCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetWindowTextLengthA(pointer hWnd);
    [DllImport(lib, EntryPoint = "GetWindowTextLengthW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetWindowTextLength(pointer hWnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetWindowTextLengthW(pointer hWnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetClientRect(pointer hWnd, pointer unfoundType_LPRECT_lpRect);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetWindowRect(pointer hWnd, pointer unfoundType_LPRECT_lpRect);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AdjustWindowRect(pointer unfoundType_LPRECT_lpRect, int dwStyle, bool bMenu);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AdjustWindowRectEx(pointer unfoundType_LPRECT_lpRect, int dwStyle, bool bMenu, int dwExStyle);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AdjustWindowRectExForDpi(pointer unfoundType_LPRECT_lpRect, int dwStyle, bool bMenu, int dwExStyle, uint dpi);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetWindowContextHelpId(pointer unnamed_0, int unnamed_1);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetWindowContextHelpId(pointer unnamed_0);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetMenuContextHelpId(pointer unnamed_0, int unnamed_1);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetMenuContextHelpId(pointer unnamed_0);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int MessageBoxA(pointer hWnd, [MarshalAs(UnmanagedType.LPStr)] string lpText, [MarshalAs(UnmanagedType.LPStr)] string lpCaption, uint uType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int MessageBoxA(pointer hWnd, [MarshalAs(UnmanagedType.LPStr)] string lpText, byte* lpCaption, uint uType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int MessageBoxA(pointer hWnd, byte* lpText, [MarshalAs(UnmanagedType.LPStr)] string lpCaption, uint uType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int MessageBoxA(pointer hWnd, byte* lpText, byte* lpCaption, uint uType);
    [DllImport(lib, EntryPoint = "MessageBoxW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int MessageBox(pointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpText, [MarshalAs(UnmanagedType.LPWStr)] string lpCaption, uint uType);
    [DllImport(lib, EntryPoint = "MessageBoxW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int MessageBox(pointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpText, char* lpCaption, uint uType);
    [DllImport(lib, EntryPoint = "MessageBoxW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int MessageBox(pointer hWnd, char* lpText, [MarshalAs(UnmanagedType.LPWStr)] string lpCaption, uint uType);
    [DllImport(lib, EntryPoint = "MessageBoxW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int MessageBox(pointer hWnd, char* lpText, char* lpCaption, uint uType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int MessageBoxW(pointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpText, [MarshalAs(UnmanagedType.LPWStr)] string lpCaption, uint uType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int MessageBoxW(pointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpText, char* lpCaption, uint uType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int MessageBoxW(pointer hWnd, char* lpText, [MarshalAs(UnmanagedType.LPWStr)] string lpCaption, uint uType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int MessageBoxW(pointer hWnd, char* lpText, char* lpCaption, uint uType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int MessageBoxExA(pointer hWnd, [MarshalAs(UnmanagedType.LPStr)] string lpText, [MarshalAs(UnmanagedType.LPStr)] string lpCaption, uint uType, short wLanguageId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int MessageBoxExA(pointer hWnd, [MarshalAs(UnmanagedType.LPStr)] string lpText, byte* lpCaption, uint uType, short wLanguageId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int MessageBoxExA(pointer hWnd, byte* lpText, [MarshalAs(UnmanagedType.LPStr)] string lpCaption, uint uType, short wLanguageId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int MessageBoxExA(pointer hWnd, byte* lpText, byte* lpCaption, uint uType, short wLanguageId);
    [DllImport(lib, EntryPoint = "MessageBoxExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int MessageBoxEx(pointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpText, [MarshalAs(UnmanagedType.LPWStr)] string lpCaption, uint uType, short wLanguageId);
    [DllImport(lib, EntryPoint = "MessageBoxExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int MessageBoxEx(pointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpText, char* lpCaption, uint uType, short wLanguageId);
    [DllImport(lib, EntryPoint = "MessageBoxExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int MessageBoxEx(pointer hWnd, char* lpText, [MarshalAs(UnmanagedType.LPWStr)] string lpCaption, uint uType, short wLanguageId);
    [DllImport(lib, EntryPoint = "MessageBoxExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int MessageBoxEx(pointer hWnd, char* lpText, char* lpCaption, uint uType, short wLanguageId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int MessageBoxExW(pointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpText, [MarshalAs(UnmanagedType.LPWStr)] string lpCaption, uint uType, short wLanguageId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int MessageBoxExW(pointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string lpText, char* lpCaption, uint uType, short wLanguageId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int MessageBoxExW(pointer hWnd, char* lpText, [MarshalAs(UnmanagedType.LPWStr)] string lpCaption, uint uType, short wLanguageId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int MessageBoxExW(pointer hWnd, char* lpText, char* lpCaption, uint uType, short wLanguageId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int MessageBoxIndirectA(pointer unfoundType_MSGBOXPARAMSA_lpmbp);
    [DllImport(lib, EntryPoint = "MessageBoxIndirectW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int MessageBoxIndirect(pointer unfoundType_MSGBOXPARAMSW_lpmbp);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int MessageBoxIndirectW(pointer unfoundType_MSGBOXPARAMSW_lpmbp);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MessageBeep(uint uType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ShowCursor(bool bShow);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetCursorPos(int X, int Y);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetPhysicalCursorPos(int X, int Y);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer SetCursor(pointer unfoundType_HCURSOR_hCursor);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetCursorPos(pointer unfoundType_LPPOINT_lpPoint);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPhysicalCursorPos(pointer unfoundType_LPPOINT_lpPoint);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetClipCursor(pointer unfoundType_LPRECT_lpRect);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetCursor();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CreateCaret(pointer hWnd, pointer unfoundType_HBITMAP_hBitmap, int nWidth, int nHeight);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetCaretBlinkTime();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetCaretBlinkTime(uint uMSeconds);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DestroyCaret();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool HideCaret(pointer hWnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ShowCaret(pointer hWnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetCaretPos(int X, int Y);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetCaretPos(pointer unfoundType_LPPOINT_lpPoint);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ClientToScreen(pointer hWnd, pointer unfoundType_LPPOINT_lpPoint);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ScreenToClient(pointer hWnd, pointer unfoundType_LPPOINT_lpPoint);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool LogicalToPhysicalPoint(pointer hWnd, pointer unfoundType_LPPOINT_lpPoint);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool PhysicalToLogicalPoint(pointer hWnd, pointer unfoundType_LPPOINT_lpPoint);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool LogicalToPhysicalPointForPerMonitorDPI(pointer hWnd, pointer unfoundType_LPPOINT_lpPoint);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool PhysicalToLogicalPointForPerMonitorDPI(pointer hWnd, pointer unfoundType_LPPOINT_lpPoint);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int MapWindowPoints(pointer hWndFrom, pointer hWndTo, pointer unfoundType_LPPOINT_lpPoints, uint cPoints);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer WindowFromPoint(pointer unfoundType_POINT_Point);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer WindowFromPhysicalPoint(pointer unfoundType_POINT_Point);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer ChildWindowFromPoint(pointer hWndParent, pointer unfoundType_POINT_Point);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ClipCursor(pointer unfoundType_RECTlpRectlpRect_unnamed_0);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer ChildWindowFromPointEx(pointer hwnd, pointer unfoundType_POINT_pt, uint flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetSysColor(int nIndex);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetSysColorBrush(int nIndex);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetSysColors(int cElements, pointer lpaElements, pointer unfoundType_COLORREF_lpaRgbValues);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DrawFocusRect(pointer hDC, pointer unfoundType_RECT_lprc);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FillRect(pointer hDC, pointer unfoundType_RECTlprclprc_unnamed_1, pointer hbr);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int FrameRect(pointer hDC, pointer unfoundType_RECTlprclprc_unnamed_1, pointer hbr);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool InvertRect(pointer hDC, pointer unfoundType_RECTlprclprc_unnamed_1);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetRect(pointer unfoundType_LPRECT_lprc, int xLeft, int yTop, int xRight, int yBottom);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetRectEmpty(pointer unfoundType_LPRECT_lprc);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CopyRect(pointer unfoundType_LPRECT_lprcDst, pointer unfoundType_RECTlprcSrclprcSrc_unnamed_1);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool InflateRect(pointer unfoundType_LPRECT_lprc, int dx, int dy);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IntersectRect(pointer unfoundType_LPRECT_lprcDst, pointer unfoundType_RECTlprcSrc1lprcSrc1_unnamed_1, pointer unfoundType_RECTlprcSrc2lprcSrc2_unnamed_2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UnionRect(pointer unfoundType_LPRECT_lprcDst, pointer unfoundType_RECTlprcSrc1lprcSrc1_unnamed_1, pointer unfoundType_RECTlprcSrc2lprcSrc2_unnamed_2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SubtractRect(pointer unfoundType_LPRECT_lprcDst, pointer unfoundType_RECTlprcSrc1lprcSrc1_unnamed_1, pointer unfoundType_RECTlprcSrc2lprcSrc2_unnamed_2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool OffsetRect(pointer unfoundType_LPRECT_lprc, int dx, int dy);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsRectEmpty(pointer unfoundType_RECTlprclprc_unnamed_0);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EqualRect(pointer unfoundType_RECTlprc1lprc1_unnamed_0, pointer unfoundType_RECTlprc2lprc2_unnamed_1);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool PtInRect(pointer unfoundType_RECTlprclprc_unnamed_0, pointer unfoundType_POINT_pt);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        short GetWindowWord(pointer hWnd, int nIndex);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        short SetWindowWord(pointer hWnd, int nIndex, short wNewWord);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetWindowLongA(pointer hWnd, int nIndex);
    [DllImport(lib, EntryPoint = "GetWindowLongW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetWindowLong(pointer hWnd, int nIndex);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetWindowLongW(pointer hWnd, int nIndex);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SetWindowLongA(pointer hWnd, int nIndex, int dwNewLong);
    [DllImport(lib, EntryPoint = "SetWindowLongW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int SetWindowLong(pointer hWnd, int nIndex, int dwNewLong);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SetWindowLongW(pointer hWnd, int nIndex, int dwNewLong);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        long GetWindowLongPtrA(pointer hWnd, int nIndex);
    [DllImport(lib, EntryPoint = "GetWindowLongPtrW", SetLastError = true, ExactSpelling = true)]
    public static extern
        long GetWindowLongPtr(pointer hWnd, int nIndex);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        long GetWindowLongPtrW(pointer hWnd, int nIndex);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        long SetWindowLongPtrA(pointer hWnd, int nIndex, long dwNewLong);
    [DllImport(lib, EntryPoint = "SetWindowLongPtrW", SetLastError = true, ExactSpelling = true)]
    public static extern
        long SetWindowLongPtr(pointer hWnd, int nIndex, long dwNewLong);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        long SetWindowLongPtrW(pointer hWnd, int nIndex, long dwNewLong);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        short GetClassWord(pointer hWnd, int nIndex);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        short SetClassWord(pointer hWnd, int nIndex, short wNewWord);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetClassLongA(pointer hWnd, int nIndex);
    [DllImport(lib, EntryPoint = "GetClassLongW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetClassLong(pointer hWnd, int nIndex);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetClassLongW(pointer hWnd, int nIndex);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SetClassLongA(pointer hWnd, int nIndex, int dwNewLong);
    [DllImport(lib, EntryPoint = "SetClassLongW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int SetClassLong(pointer hWnd, int nIndex, int dwNewLong);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SetClassLongW(pointer hWnd, int nIndex, int dwNewLong);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetClassLongPtrA(pointer hWnd, int nIndex);
    [DllImport(lib, EntryPoint = "GetClassLongPtrW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetClassLongPtr(pointer hWnd, int nIndex);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetClassLongPtrW(pointer hWnd, int nIndex);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer SetClassLongPtrA(pointer hWnd, int nIndex, long dwNewLong);
    [DllImport(lib, EntryPoint = "SetClassLongPtrW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer SetClassLongPtr(pointer hWnd, int nIndex, long dwNewLong);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer SetClassLongPtrW(pointer hWnd, int nIndex, long dwNewLong);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetProcessDefaultLayout(pointer unfoundType_DWORDpdwDefaultLayoutpdwDefaultLayout_unnamed_0);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetProcessDefaultLayout(int dwDefaultLayout);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetDesktopWindow();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetParent(pointer hWnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer SetParent(pointer hWndChild, pointer hWndNewParent);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumChildWindows(pointer hWndParent, pointer unfoundType_WNDENUMPROC_lpEnumFunc, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindWindowA([MarshalAs(UnmanagedType.LPStr)] string lpClassName, [MarshalAs(UnmanagedType.LPStr)] string lpWindowName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindWindowA([MarshalAs(UnmanagedType.LPStr)] string lpClassName, byte* lpWindowName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindWindowA(byte* lpClassName, [MarshalAs(UnmanagedType.LPStr)] string lpWindowName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindWindowA(byte* lpClassName, byte* lpWindowName);
    [DllImport(lib, EntryPoint = "FindWindowW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindWindow([MarshalAs(UnmanagedType.LPWStr)] string lpClassName, [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName);
    [DllImport(lib, EntryPoint = "FindWindowW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindWindow([MarshalAs(UnmanagedType.LPWStr)] string lpClassName, char* lpWindowName);
    [DllImport(lib, EntryPoint = "FindWindowW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindWindow(char* lpClassName, [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName);
    [DllImport(lib, EntryPoint = "FindWindowW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindWindow(char* lpClassName, char* lpWindowName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindWindowW([MarshalAs(UnmanagedType.LPWStr)] string lpClassName, [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindWindowW([MarshalAs(UnmanagedType.LPWStr)] string lpClassName, char* lpWindowName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindWindowW(char* lpClassName, [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindWindowW(char* lpClassName, char* lpWindowName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindWindowExA(pointer hWndParent, pointer hWndChildAfter, [MarshalAs(UnmanagedType.LPStr)] string lpszClass, [MarshalAs(UnmanagedType.LPStr)] string lpszWindow);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindWindowExA(pointer hWndParent, pointer hWndChildAfter, [MarshalAs(UnmanagedType.LPStr)] string lpszClass, byte* lpszWindow);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindWindowExA(pointer hWndParent, pointer hWndChildAfter, byte* lpszClass, [MarshalAs(UnmanagedType.LPStr)] string lpszWindow);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindWindowExA(pointer hWndParent, pointer hWndChildAfter, byte* lpszClass, byte* lpszWindow);
    [DllImport(lib, EntryPoint = "FindWindowExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindWindowEx(pointer hWndParent, pointer hWndChildAfter, [MarshalAs(UnmanagedType.LPWStr)] string lpszClass, [MarshalAs(UnmanagedType.LPWStr)] string lpszWindow);
    [DllImport(lib, EntryPoint = "FindWindowExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindWindowEx(pointer hWndParent, pointer hWndChildAfter, [MarshalAs(UnmanagedType.LPWStr)] string lpszClass, char* lpszWindow);
    [DllImport(lib, EntryPoint = "FindWindowExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindWindowEx(pointer hWndParent, pointer hWndChildAfter, char* lpszClass, [MarshalAs(UnmanagedType.LPWStr)] string lpszWindow);
    [DllImport(lib, EntryPoint = "FindWindowExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindWindowEx(pointer hWndParent, pointer hWndChildAfter, char* lpszClass, char* lpszWindow);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindWindowExW(pointer hWndParent, pointer hWndChildAfter, [MarshalAs(UnmanagedType.LPWStr)] string lpszClass, [MarshalAs(UnmanagedType.LPWStr)] string lpszWindow);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindWindowExW(pointer hWndParent, pointer hWndChildAfter, [MarshalAs(UnmanagedType.LPWStr)] string lpszClass, char* lpszWindow);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindWindowExW(pointer hWndParent, pointer hWndChildAfter, char* lpszClass, [MarshalAs(UnmanagedType.LPWStr)] string lpszWindow);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer FindWindowExW(pointer hWndParent, pointer hWndChildAfter, char* lpszClass, char* lpszWindow);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetShellWindow();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool RegisterShellHookWindow(pointer hwnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DeregisterShellHookWindow(pointer hwnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumWindows(pointer unfoundType_WNDENUMPROC_lpEnumFunc, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumThreadWindows(int dwThreadId, pointer unfoundType_WNDENUMPROC_lpfn, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetClassNameA(pointer hWnd, [MarshalAs(UnmanagedType.LPStr)] string lpClassName, int nMaxCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetClassNameA(pointer hWnd, ReadOnlySpan<byte> lpClassName, int nMaxCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetClassNameA(pointer hWnd, byte* lpClassName, int nMaxCount);
    [DllImport(lib, EntryPoint = "GetClassNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetClassName(pointer hWnd, string lpClassName, int nMaxCount);
    [DllImport(lib, EntryPoint = "GetClassNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetClassName(pointer hWnd, char* lpClassName, int nMaxCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetClassNameW(pointer hWnd, string lpClassName, int nMaxCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetClassNameW(pointer hWnd, char* lpClassName, int nMaxCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetTopWindow(pointer hWnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetWindowThreadProcessId(pointer hWnd, pointer unfoundType_LPDWORD_lpdwProcessId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsGUIThread(bool bConvert);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetLastActivePopup(pointer hWnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetWindow(pointer hWnd, uint uCmd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer SetWindowsHookA(int nFilterType, pointer unfoundType_HOOKPROC_pfnFilterProc);
    [DllImport(lib, EntryPoint = "SetWindowsHookW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer SetWindowsHook(int nFilterType, pointer unfoundType_HOOKPROC_pfnFilterProc);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer SetWindowsHookW(int nFilterType, pointer unfoundType_HOOKPROC_pfnFilterProc);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UnhookWindowsHook(int nCode, pointer unfoundType_HOOKPROC_pfnFilterProc);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer SetWindowsHookExA(int idHook, pointer unfoundType_HOOKPROC_lpfn, pointer unfoundType_HINSTANCE_hmod, int dwThreadId);
    [DllImport(lib, EntryPoint = "SetWindowsHookExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer SetWindowsHookEx(int idHook, pointer unfoundType_HOOKPROC_lpfn, pointer unfoundType_HINSTANCE_hmod, int dwThreadId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer SetWindowsHookExW(int idHook, pointer unfoundType_HOOKPROC_lpfn, pointer unfoundType_HINSTANCE_hmod, int dwThreadId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UnhookWindowsHookEx(pointer unfoundType_HHOOK_hhk);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        long CallNextHookEx(pointer unfoundType_HHOOK_hhk, int nCode, ulong wParam, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CheckMenuRadioItem(pointer hmenu, uint first, uint last, uint check, uint flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadBitmapA(pointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPStr)] string lpBitmapName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadBitmapA(pointer unfoundType_HINSTANCE_hInstance, byte* lpBitmapName);
    [DllImport(lib, EntryPoint = "LoadBitmapW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadBitmap(pointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpBitmapName);
    [DllImport(lib, EntryPoint = "LoadBitmapW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadBitmap(pointer unfoundType_HINSTANCE_hInstance, char* lpBitmapName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadBitmapW(pointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpBitmapName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadBitmapW(pointer unfoundType_HINSTANCE_hInstance, char* lpBitmapName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadCursorA(pointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPStr)] string lpCursorName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadCursorA(pointer unfoundType_HINSTANCE_hInstance, byte* lpCursorName);
    [DllImport(lib, EntryPoint = "LoadCursorW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadCursor(pointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpCursorName);
    [DllImport(lib, EntryPoint = "LoadCursorW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadCursor(pointer unfoundType_HINSTANCE_hInstance, char* lpCursorName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadCursorW(pointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpCursorName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadCursorW(pointer unfoundType_HINSTANCE_hInstance, char* lpCursorName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadCursorFromFileA([MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadCursorFromFileA(byte* lpFileName);
    [DllImport(lib, EntryPoint = "LoadCursorFromFileW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadCursorFromFile([MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, EntryPoint = "LoadCursorFromFileW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadCursorFromFile(char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadCursorFromFileW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadCursorFromFileW(char* lpFileName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateCursor(pointer unfoundType_HINSTANCE_hInst, int xHotSpot, int yHotSpot, int nWidth, int nHeight, pointer unfoundType_VOIDpvANDPlanepvANDPlane_unnamed_5, pointer unfoundType_VOIDpvXORPlanepvXORPlane_unnamed_6);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DestroyCursor(pointer unfoundType_HCURSOR_hCursor);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetSystemCursor(pointer unfoundType_HCURSOR_hcur, int id);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadIconA(pointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPStr)] string lpIconName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadIconA(pointer unfoundType_HINSTANCE_hInstance, byte* lpIconName);
    [DllImport(lib, EntryPoint = "LoadIconW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadIcon(pointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpIconName);
    [DllImport(lib, EntryPoint = "LoadIconW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadIcon(pointer unfoundType_HINSTANCE_hInstance, char* lpIconName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadIconW(pointer unfoundType_HINSTANCE_hInstance, [MarshalAs(UnmanagedType.LPWStr)] string lpIconName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadIconW(pointer unfoundType_HINSTANCE_hInstance, char* lpIconName);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint PrivateExtractIconsA([MarshalAs(UnmanagedType.LPStr)] string szFileName, int nIconIndex, int cxIcon, int cyIcon, pointer unfoundType_HICONphiconphicon_unnamed_4, pointer unfoundType_UINTpiconidpiconid_unnamed_5, uint nIcons, uint flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint PrivateExtractIconsA(byte* szFileName, int nIconIndex, int cxIcon, int cyIcon, pointer unfoundType_HICONphiconphicon_unnamed_4, pointer unfoundType_UINTpiconidpiconid_unnamed_5, uint nIcons, uint flags);
    [DllImport(lib, EntryPoint = "PrivateExtractIconsW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint PrivateExtractIcons([MarshalAs(UnmanagedType.LPWStr)] string szFileName, int nIconIndex, int cxIcon, int cyIcon, pointer unfoundType_HICONphiconphicon_unnamed_4, pointer unfoundType_UINTpiconidpiconid_unnamed_5, uint nIcons, uint flags);
    [DllImport(lib, EntryPoint = "PrivateExtractIconsW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint PrivateExtractIcons(char* szFileName, int nIconIndex, int cxIcon, int cyIcon, pointer unfoundType_HICONphiconphicon_unnamed_4, pointer unfoundType_UINTpiconidpiconid_unnamed_5, uint nIcons, uint flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint PrivateExtractIconsW([MarshalAs(UnmanagedType.LPWStr)] string szFileName, int nIconIndex, int cxIcon, int cyIcon, pointer unfoundType_HICONphiconphicon_unnamed_4, pointer unfoundType_UINTpiconidpiconid_unnamed_5, uint nIcons, uint flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint PrivateExtractIconsW(char* szFileName, int nIconIndex, int cxIcon, int cyIcon, pointer unfoundType_HICONphiconphicon_unnamed_4, pointer unfoundType_UINTpiconidpiconid_unnamed_5, uint nIcons, uint flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateIcon(pointer unfoundType_HINSTANCE_hInstance, int nWidth, int nHeight, byte cPlanes, byte cBitsPixel, pointer unfoundType_BYTElpbANDbitslpbANDbits_unnamed_5, pointer unfoundType_BYTElpbXORbitslpbXORbits_unnamed_6);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DestroyIcon(pointer hIcon);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LookupIconIdFromDirectory(pointer unfoundType_PBYTE_presbits, bool fIcon);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int LookupIconIdFromDirectoryEx(pointer unfoundType_PBYTE_presbits, bool fIcon, int cxDesired, int cyDesired, uint Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateIconFromResource(pointer unfoundType_PBYTE_presbits, int dwResSize, bool fIcon, int dwVer);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateIconFromResourceEx(pointer unfoundType_PBYTE_presbits, int dwResSize, bool fIcon, int dwVer, int cxDesired, int cyDesired, uint Flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint SetThreadCursorCreationScaling(uint cursorDpi);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadImageA(pointer unfoundType_HINSTANCE_hInst, [MarshalAs(UnmanagedType.LPStr)] string name, uint type, int cx, int cy, uint fuLoad);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadImageA(pointer unfoundType_HINSTANCE_hInst, byte* name, uint type, int cx, int cy, uint fuLoad);
    [DllImport(lib, EntryPoint = "LoadImageW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadImage(pointer unfoundType_HINSTANCE_hInst, [MarshalAs(UnmanagedType.LPWStr)] string name, uint type, int cx, int cy, uint fuLoad);
    [DllImport(lib, EntryPoint = "LoadImageW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadImage(pointer unfoundType_HINSTANCE_hInst, char* name, uint type, int cx, int cy, uint fuLoad);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadImageW(pointer unfoundType_HINSTANCE_hInst, [MarshalAs(UnmanagedType.LPWStr)] string name, uint type, int cx, int cy, uint fuLoad);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer LoadImageW(pointer unfoundType_HINSTANCE_hInst, char* name, uint type, int cx, int cy, uint fuLoad);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CopyImage(pointer h, uint type, int cx, int cy, uint flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateIconIndirect(pointer unfoundType_PICONINFO_piconinfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CopyIcon(pointer hIcon);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetIconInfo(pointer hIcon, pointer unfoundType_PICONINFO_piconinfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetIconInfoExA(pointer hicon, pointer unfoundType_PICONINFOEXA_piconinfo);
    [DllImport(lib, EntryPoint = "GetIconInfoExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetIconInfoEx(pointer hicon, pointer unfoundType_PICONINFOEXW_piconinfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetIconInfoExW(pointer hicon, pointer unfoundType_PICONINFOEXW_piconinfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsDialogMessageA(pointer hDlg, pointer unfoundType_LPMSG_lpMsg);
    [DllImport(lib, EntryPoint = "IsDialogMessageW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsDialogMessage(pointer hDlg, pointer unfoundType_LPMSG_lpMsg);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsDialogMessageW(pointer hDlg, pointer unfoundType_LPMSG_lpMsg);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool MapDialogRect(pointer hDlg, pointer unfoundType_LPRECT_lpRect);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int DlgDirListA(pointer hDlg, [MarshalAs(UnmanagedType.LPStr)] string lpPathSpec, int nIDListBox, int nIDStaticPath, uint uFileType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int DlgDirListA(pointer hDlg, ReadOnlySpan<byte> lpPathSpec, int nIDListBox, int nIDStaticPath, uint uFileType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int DlgDirListA(pointer hDlg, byte* lpPathSpec, int nIDListBox, int nIDStaticPath, uint uFileType);
    [DllImport(lib, EntryPoint = "DlgDirListW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int DlgDirList(pointer hDlg, string lpPathSpec, int nIDListBox, int nIDStaticPath, uint uFileType);
    [DllImport(lib, EntryPoint = "DlgDirListW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int DlgDirList(pointer hDlg, char* lpPathSpec, int nIDListBox, int nIDStaticPath, uint uFileType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int DlgDirListW(pointer hDlg, string lpPathSpec, int nIDListBox, int nIDStaticPath, uint uFileType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int DlgDirListW(pointer hDlg, char* lpPathSpec, int nIDListBox, int nIDStaticPath, uint uFileType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DlgDirSelectExA(pointer hwndDlg, [MarshalAs(UnmanagedType.LPStr)] string lpString, int chCount, int idListBox);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DlgDirSelectExA(pointer hwndDlg, ReadOnlySpan<byte> lpString, int chCount, int idListBox);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DlgDirSelectExA(pointer hwndDlg, byte* lpString, int chCount, int idListBox);
    [DllImport(lib, EntryPoint = "DlgDirSelectExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DlgDirSelectEx(pointer hwndDlg, string lpString, int chCount, int idListBox);
    [DllImport(lib, EntryPoint = "DlgDirSelectExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DlgDirSelectEx(pointer hwndDlg, char* lpString, int chCount, int idListBox);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DlgDirSelectExW(pointer hwndDlg, string lpString, int chCount, int idListBox);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DlgDirSelectExW(pointer hwndDlg, char* lpString, int chCount, int idListBox);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int DlgDirListComboBoxA(pointer hDlg, [MarshalAs(UnmanagedType.LPStr)] string lpPathSpec, int nIDComboBox, int nIDStaticPath, uint uFiletype);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int DlgDirListComboBoxA(pointer hDlg, ReadOnlySpan<byte> lpPathSpec, int nIDComboBox, int nIDStaticPath, uint uFiletype);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int DlgDirListComboBoxA(pointer hDlg, byte* lpPathSpec, int nIDComboBox, int nIDStaticPath, uint uFiletype);
    [DllImport(lib, EntryPoint = "DlgDirListComboBoxW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int DlgDirListComboBox(pointer hDlg, string lpPathSpec, int nIDComboBox, int nIDStaticPath, uint uFiletype);
    [DllImport(lib, EntryPoint = "DlgDirListComboBoxW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int DlgDirListComboBox(pointer hDlg, char* lpPathSpec, int nIDComboBox, int nIDStaticPath, uint uFiletype);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int DlgDirListComboBoxW(pointer hDlg, string lpPathSpec, int nIDComboBox, int nIDStaticPath, uint uFiletype);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int DlgDirListComboBoxW(pointer hDlg, char* lpPathSpec, int nIDComboBox, int nIDStaticPath, uint uFiletype);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DlgDirSelectComboBoxExA(pointer hwndDlg, [MarshalAs(UnmanagedType.LPStr)] string lpString, int cchOut, int idComboBox);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DlgDirSelectComboBoxExA(pointer hwndDlg, ReadOnlySpan<byte> lpString, int cchOut, int idComboBox);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DlgDirSelectComboBoxExA(pointer hwndDlg, byte* lpString, int cchOut, int idComboBox);
    [DllImport(lib, EntryPoint = "DlgDirSelectComboBoxExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DlgDirSelectComboBoxEx(pointer hwndDlg, string lpString, int cchOut, int idComboBox);
    [DllImport(lib, EntryPoint = "DlgDirSelectComboBoxExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DlgDirSelectComboBoxEx(pointer hwndDlg, char* lpString, int cchOut, int idComboBox);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DlgDirSelectComboBoxExW(pointer hwndDlg, string lpString, int cchOut, int idComboBox);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool DlgDirSelectComboBoxExW(pointer hwndDlg, char* lpString, int cchOut, int idComboBox);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SetScrollInfo(pointer hwnd, int nBar, pointer unfoundType_LPCSCROLLINFO_lpsi, bool redraw);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetScrollInfo(pointer hwnd, int nBar, pointer unfoundType_LPSCROLLINFO_lpsi);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        long DefFrameProcA(pointer hWnd, pointer hWndMDIClient, uint uMsg, ulong wParam, long lParam);
    [DllImport(lib, EntryPoint = "DefFrameProcW", SetLastError = true, ExactSpelling = true)]
    public static extern
        long DefFrameProc(pointer hWnd, pointer hWndMDIClient, uint uMsg, ulong wParam, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        long DefFrameProcW(pointer hWnd, pointer hWndMDIClient, uint uMsg, ulong wParam, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer DefMDIChildProcA(pointer hWnd, uint uMsg, ulong wParam, long lParam);
    [DllImport(lib, EntryPoint = "DefMDIChildProcW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer DefMDIChildProc(pointer hWnd, uint uMsg, ulong wParam, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer DefMDIChildProcW(pointer hWnd, uint uMsg, ulong wParam, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool TranslateMDISysAccel(pointer hWndClient, pointer unfoundType_LPMSG_lpMsg);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint ArrangeIconicWindows(pointer hWnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateMDIWindowA([MarshalAs(UnmanagedType.LPStr)] string lpClassName, [MarshalAs(UnmanagedType.LPStr)] string lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, pointer hWndParent, pointer unfoundType_HINSTANCE_hInstance, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateMDIWindowA([MarshalAs(UnmanagedType.LPStr)] string lpClassName, byte* lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, pointer hWndParent, pointer unfoundType_HINSTANCE_hInstance, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateMDIWindowA(byte* lpClassName, [MarshalAs(UnmanagedType.LPStr)] string lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, pointer hWndParent, pointer unfoundType_HINSTANCE_hInstance, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateMDIWindowA(byte* lpClassName, byte* lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, pointer hWndParent, pointer unfoundType_HINSTANCE_hInstance, long lParam);
    [DllImport(lib, EntryPoint = "CreateMDIWindowW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateMDIWindow([MarshalAs(UnmanagedType.LPWStr)] string lpClassName, [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, pointer hWndParent, pointer unfoundType_HINSTANCE_hInstance, long lParam);
    [DllImport(lib, EntryPoint = "CreateMDIWindowW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateMDIWindow([MarshalAs(UnmanagedType.LPWStr)] string lpClassName, char* lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, pointer hWndParent, pointer unfoundType_HINSTANCE_hInstance, long lParam);
    [DllImport(lib, EntryPoint = "CreateMDIWindowW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateMDIWindow(char* lpClassName, [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, pointer hWndParent, pointer unfoundType_HINSTANCE_hInstance, long lParam);
    [DllImport(lib, EntryPoint = "CreateMDIWindowW", SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateMDIWindow(char* lpClassName, char* lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, pointer hWndParent, pointer unfoundType_HINSTANCE_hInstance, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateMDIWindowW([MarshalAs(UnmanagedType.LPWStr)] string lpClassName, [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, pointer hWndParent, pointer unfoundType_HINSTANCE_hInstance, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateMDIWindowW([MarshalAs(UnmanagedType.LPWStr)] string lpClassName, char* lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, pointer hWndParent, pointer unfoundType_HINSTANCE_hInstance, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateMDIWindowW(char* lpClassName, [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, pointer hWndParent, pointer unfoundType_HINSTANCE_hInstance, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer CreateMDIWindowW(char* lpClassName, char* lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, pointer hWndParent, pointer unfoundType_HINSTANCE_hInstance, long lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        short TileWindows(pointer hwndParent, uint wHow, pointer unfoundType_RECT_lpRect, uint cKids, pointer lpKids);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WinHelpA(pointer hWndMain, [MarshalAs(UnmanagedType.LPStr)] string lpszHelp, uint uCommand, pointer unfoundType_ULONG_PTR_dwData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WinHelpA(pointer hWndMain, byte* lpszHelp, uint uCommand, pointer unfoundType_ULONG_PTR_dwData);
    [DllImport(lib, EntryPoint = "WinHelpW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WinHelp(pointer hWndMain, [MarshalAs(UnmanagedType.LPWStr)] string lpszHelp, uint uCommand, pointer unfoundType_ULONG_PTR_dwData);
    [DllImport(lib, EntryPoint = "WinHelpW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WinHelp(pointer hWndMain, char* lpszHelp, uint uCommand, pointer unfoundType_ULONG_PTR_dwData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WinHelpW(pointer hWndMain, [MarshalAs(UnmanagedType.LPWStr)] string lpszHelp, uint uCommand, pointer unfoundType_ULONG_PTR_dwData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool WinHelpW(pointer hWndMain, char* lpszHelp, uint uCommand, pointer unfoundType_ULONG_PTR_dwData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetGuiResources(pointer hProcess, int uiFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ChangeDisplaySettingsA(pointer unfoundType_DEVMODEA_lpDevMode, int dwFlags);
    [DllImport(lib, EntryPoint = "ChangeDisplaySettingsW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int ChangeDisplaySettings(pointer unfoundType_DEVMODEW_lpDevMode, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ChangeDisplaySettingsW(pointer unfoundType_DEVMODEW_lpDevMode, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ChangeDisplaySettingsExA([MarshalAs(UnmanagedType.LPStr)] string lpszDeviceName, pointer unfoundType_DEVMODEA_lpDevMode, pointer hwnd, int dwflags, pointer lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ChangeDisplaySettingsExA(byte* lpszDeviceName, pointer unfoundType_DEVMODEA_lpDevMode, pointer hwnd, int dwflags, pointer lParam);
    [DllImport(lib, EntryPoint = "ChangeDisplaySettingsExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int ChangeDisplaySettingsEx([MarshalAs(UnmanagedType.LPWStr)] string lpszDeviceName, pointer unfoundType_DEVMODEW_lpDevMode, pointer hwnd, int dwflags, pointer lParam);
    [DllImport(lib, EntryPoint = "ChangeDisplaySettingsExW", SetLastError = true, ExactSpelling = true)]
    public static extern
        int ChangeDisplaySettingsEx(char* lpszDeviceName, pointer unfoundType_DEVMODEW_lpDevMode, pointer hwnd, int dwflags, pointer lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ChangeDisplaySettingsExW([MarshalAs(UnmanagedType.LPWStr)] string lpszDeviceName, pointer unfoundType_DEVMODEW_lpDevMode, pointer hwnd, int dwflags, pointer lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int ChangeDisplaySettingsExW(char* lpszDeviceName, pointer unfoundType_DEVMODEW_lpDevMode, pointer hwnd, int dwflags, pointer lParam);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumDisplaySettingsA([MarshalAs(UnmanagedType.LPStr)] string lpszDeviceName, int iModeNum, pointer unfoundType_DEVMODEA_lpDevMode);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumDisplaySettingsA(byte* lpszDeviceName, int iModeNum, pointer unfoundType_DEVMODEA_lpDevMode);
    [DllImport(lib, EntryPoint = "EnumDisplaySettingsW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumDisplaySettings([MarshalAs(UnmanagedType.LPWStr)] string lpszDeviceName, int iModeNum, pointer unfoundType_DEVMODEW_lpDevMode);
    [DllImport(lib, EntryPoint = "EnumDisplaySettingsW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumDisplaySettings(char* lpszDeviceName, int iModeNum, pointer unfoundType_DEVMODEW_lpDevMode);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumDisplaySettingsW([MarshalAs(UnmanagedType.LPWStr)] string lpszDeviceName, int iModeNum, pointer unfoundType_DEVMODEW_lpDevMode);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumDisplaySettingsW(char* lpszDeviceName, int iModeNum, pointer unfoundType_DEVMODEW_lpDevMode);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumDisplaySettingsExA([MarshalAs(UnmanagedType.LPStr)] string lpszDeviceName, int iModeNum, pointer unfoundType_DEVMODEA_lpDevMode, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumDisplaySettingsExA(byte* lpszDeviceName, int iModeNum, pointer unfoundType_DEVMODEA_lpDevMode, int dwFlags);
    [DllImport(lib, EntryPoint = "EnumDisplaySettingsExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumDisplaySettingsEx([MarshalAs(UnmanagedType.LPWStr)] string lpszDeviceName, int iModeNum, pointer unfoundType_DEVMODEW_lpDevMode, int dwFlags);
    [DllImport(lib, EntryPoint = "EnumDisplaySettingsExW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumDisplaySettingsEx(char* lpszDeviceName, int iModeNum, pointer unfoundType_DEVMODEW_lpDevMode, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumDisplaySettingsExW([MarshalAs(UnmanagedType.LPWStr)] string lpszDeviceName, int iModeNum, pointer unfoundType_DEVMODEW_lpDevMode, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumDisplaySettingsExW(char* lpszDeviceName, int iModeNum, pointer unfoundType_DEVMODEW_lpDevMode, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumDisplayDevicesA([MarshalAs(UnmanagedType.LPStr)] string lpDevice, int iDevNum, pointer unfoundType_PDISPLAY_DEVICEA_lpDisplayDevice, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumDisplayDevicesA(byte* lpDevice, int iDevNum, pointer unfoundType_PDISPLAY_DEVICEA_lpDisplayDevice, int dwFlags);
    [DllImport(lib, EntryPoint = "EnumDisplayDevicesW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumDisplayDevices([MarshalAs(UnmanagedType.LPWStr)] string lpDevice, int iDevNum, pointer unfoundType_PDISPLAY_DEVICEW_lpDisplayDevice, int dwFlags);
    [DllImport(lib, EntryPoint = "EnumDisplayDevicesW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumDisplayDevices(char* lpDevice, int iDevNum, pointer unfoundType_PDISPLAY_DEVICEW_lpDisplayDevice, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumDisplayDevicesW([MarshalAs(UnmanagedType.LPWStr)] string lpDevice, int iDevNum, pointer unfoundType_PDISPLAY_DEVICEW_lpDisplayDevice, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumDisplayDevicesW(char* lpDevice, int iDevNum, pointer unfoundType_PDISPLAY_DEVICEW_lpDisplayDevice, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetDisplayConfigBufferSizes(uint flags, pointer numPathArrayElements, pointer numModeInfoArrayElements);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int SetDisplayConfig(uint numPathArrayElements, pointer unfoundType_DISPLAYCONFIG_PATH_INFO_pathArray, uint numModeInfoArrayElements, pointer unfoundType_DISPLAYCONFIG_MODE_INFO_modeInfoArray, uint flags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int QueryDisplayConfig(uint flags, pointer numPathArrayElements, pointer unfoundType_DISPLAYCONFIG_PATH_INFO_pathArray, pointer numModeInfoArrayElements, pointer unfoundType_DISPLAYCONFIG_MODE_INFO_modeInfoArray, pointer unfoundType_DISPLAYCONFIG_TOPOLOGY_ID_currentTopologyId);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int DisplayConfigGetDeviceInfo(pointer unfoundType_DISPLAYCONFIG_DEVICE_INFO_HEADER_requestPacket);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int DisplayConfigSetDeviceInfo(pointer unfoundType_DISPLAYCONFIG_DEVICE_INFO_HEADER_setPacket);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SystemParametersInfoA(uint uiAction, uint uiParam, pointer pvParam, uint fWinIni);
    [DllImport(lib, EntryPoint = "SystemParametersInfoW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SystemParametersInfo(uint uiAction, uint uiParam, pointer pvParam, uint fWinIni);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SystemParametersInfoW(uint uiAction, uint uiParam, pointer pvParam, uint fWinIni);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SystemParametersInfoForDpi(uint uiAction, uint uiParam, pointer pvParam, uint fWinIni, uint dpi);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SoundSentry();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void SetDebugErrorLevel(int dwLevel);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void SetLastErrorEx(int dwErrCode, int dwType);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int InternalGetWindowText(pointer hWnd, string pString, int cchMaxCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int InternalGetWindowText(pointer hWnd, char* pString, int cchMaxCount);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EndTask(pointer hWnd, bool fShutDown, bool fForce);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CancelShutdown();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer MonitorFromPoint(pointer unfoundType_POINT_pt, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer MonitorFromRect(pointer unfoundType_LPCRECT_lprc, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer MonitorFromWindow(pointer hwnd, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetMonitorInfoA(pointer hMonitor, pointer unfoundType_LPMONITORINFO_lpmi);
    [DllImport(lib, EntryPoint = "GetMonitorInfoW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetMonitorInfo(pointer hMonitor, pointer unfoundType_LPMONITORINFO_lpmi);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetMonitorInfoW(pointer hMonitor, pointer unfoundType_LPMONITORINFO_lpmi);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnumDisplayMonitors(pointer hdc, pointer unfoundType_LPCRECT_lprcClip, pointer unfoundType_MONITORENUMPROC_lpfnEnum, long dwData);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        void NotifyWinEvent(int argEvent, pointer hwnd, int idObject, int idChild);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer SetWinEventHook(int eventMin, int eventMax, pointer unfoundType_HMODULE_hmodWinEventProc, pointer unfoundType_WINEVENTPROC_pfnWinEventProc, int idProcess, int idThread, int dwFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsWinEventHookInstalled(int argEvent);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UnhookWinEvent(pointer unfoundType_HWINEVENTHOOK_hWinEventHook);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetGUIThreadInfo(int idThread, pointer unfoundType_PGUITHREADINFO_pgui);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool BlockInput(bool fBlockIt);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetProcessDPIAware();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsProcessDPIAware();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer SetThreadDpiAwarenessContext(pointer unfoundType_DPI_AWARENESS_CONTEXT_dpiContext);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetThreadDpiAwarenessContext();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetWindowDpiAwarenessContext(pointer hwnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetAwarenessFromDpiAwarenessContext(pointer unfoundType_DPI_AWARENESS_CONTEXT_value);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetDpiFromDpiAwarenessContext(pointer unfoundType_DPI_AWARENESS_CONTEXT_value);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool AreDpiAwarenessContextsEqual(pointer unfoundType_DPI_AWARENESS_CONTEXT_dpiContextA, pointer unfoundType_DPI_AWARENESS_CONTEXT_dpiContextB);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsValidDpiAwarenessContext(pointer unfoundType_DPI_AWARENESS_CONTEXT_value);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetDpiForWindow(pointer hwnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetDpiForSystem();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetSystemDpiForProcess(pointer hProcess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool EnableNonClientDpiScaling(pointer hwnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool InheritWindowMonitor(pointer hwnd, pointer hwndInherit);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetProcessDpiAwarenessContext(pointer unfoundType_DPI_AWARENESS_CONTEXT_value);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetDpiAwarenessContextForProcess(pointer hProcess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer SetThreadDpiHostingBehavior(pointer unfoundType_DPI_HOSTING_BEHAVIOR_value);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetThreadDpiHostingBehavior();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetWindowDpiHostingBehavior(pointer hwnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetWindowModuleFileNameA(pointer hwnd, [MarshalAs(UnmanagedType.LPStr)] string pszFileName, uint cchFileNameMax);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetWindowModuleFileNameA(pointer hwnd, ReadOnlySpan<byte> pszFileName, uint cchFileNameMax);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetWindowModuleFileNameA(pointer hwnd, byte* pszFileName, uint cchFileNameMax);
    [DllImport(lib, EntryPoint = "GetWindowModuleFileNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetWindowModuleFileName(pointer hwnd, string pszFileName, uint cchFileNameMax);
    [DllImport(lib, EntryPoint = "GetWindowModuleFileNameW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetWindowModuleFileName(pointer hwnd, char* pszFileName, uint cchFileNameMax);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetWindowModuleFileNameW(pointer hwnd, string pszFileName, uint cchFileNameMax);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetWindowModuleFileNameW(pointer hwnd, char* pszFileName, uint cchFileNameMax);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetCursorInfo(pointer unfoundType_PCURSORINFO_pci);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetWindowInfo(pointer hwnd, pointer unfoundType_PWINDOWINFO_pwi);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetTitleBarInfo(pointer hwnd, pointer unfoundType_PTITLEBARINFO_pti);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetMenuBarInfo(pointer hwnd, int idObject, int idItem, pointer unfoundType_PMENUBARINFO_pmbi);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetScrollBarInfo(pointer hwnd, int idObject, pointer unfoundType_PSCROLLBARINFO_psbi);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetComboBoxInfo(pointer hwndCombo, pointer unfoundType_PCOMBOBOXINFO_pcbi);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer GetAncestor(pointer hwnd, uint gaFlags);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        pointer RealChildWindowFromPoint(pointer hwndParent, pointer unfoundType_POINT_ptParentClientCoords);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint RealGetWindowClassA(pointer hwnd, [MarshalAs(UnmanagedType.LPStr)] string ptszClassName, uint cchClassNameMax);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint RealGetWindowClassA(pointer hwnd, ReadOnlySpan<byte> ptszClassName, uint cchClassNameMax);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint RealGetWindowClassA(pointer hwnd, byte* ptszClassName, uint cchClassNameMax);
    [DllImport(lib, EntryPoint = "RealGetWindowClassW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint RealGetWindowClass(pointer hwnd, string ptszClassName, uint cchClassNameMax);
    [DllImport(lib, EntryPoint = "RealGetWindowClassW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint RealGetWindowClass(pointer hwnd, char* ptszClassName, uint cchClassNameMax);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint RealGetWindowClassW(pointer hwnd, string ptszClassName, uint cchClassNameMax);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint RealGetWindowClassW(pointer hwnd, char* ptszClassName, uint cchClassNameMax);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetAltTabInfoA(pointer hwnd, int iItem, pointer unfoundType_PALTTABINFO_pati, [MarshalAs(UnmanagedType.LPStr)] string pszItemText, uint cchItemText);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetAltTabInfoA(pointer hwnd, int iItem, pointer unfoundType_PALTTABINFO_pati, ReadOnlySpan<byte> pszItemText, uint cchItemText);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetAltTabInfoA(pointer hwnd, int iItem, pointer unfoundType_PALTTABINFO_pati, byte* pszItemText, uint cchItemText);
    [DllImport(lib, EntryPoint = "GetAltTabInfoW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetAltTabInfo(pointer hwnd, int iItem, pointer unfoundType_PALTTABINFO_pati, string pszItemText, uint cchItemText);
    [DllImport(lib, EntryPoint = "GetAltTabInfoW", SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetAltTabInfo(pointer hwnd, int iItem, pointer unfoundType_PALTTABINFO_pati, char* pszItemText, uint cchItemText);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetAltTabInfoW(pointer hwnd, int iItem, pointer unfoundType_PALTTABINFO_pati, string pszItemText, uint cchItemText);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetAltTabInfoW(pointer hwnd, int iItem, pointer unfoundType_PALTTABINFO_pati, char* pszItemText, uint cchItemText);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        int GetListBoxInfo(pointer hwnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool LockWorkStation();
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool UserHandleGrantAccess(pointer hUserHandle, pointer hJob, bool bGrant);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetRawInputData(pointer unfoundType_HRAWINPUT_hRawInput, uint uiCommand, pointer pData, pointer unfoundType_PUINT_pcbSize, uint cbSizeHeader);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetRawInputDeviceInfoA(pointer hDevice, uint uiCommand, pointer pData, pointer unfoundType_PUINT_pcbSize);
    [DllImport(lib, EntryPoint = "GetRawInputDeviceInfoW", SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetRawInputDeviceInfo(pointer hDevice, uint uiCommand, pointer pData, pointer unfoundType_PUINT_pcbSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetRawInputDeviceInfoW(pointer hDevice, uint uiCommand, pointer pData, pointer unfoundType_PUINT_pcbSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetRawInputBuffer(pointer unfoundType_PRAWINPUT_pData, pointer unfoundType_PUINT_pcbSize, uint cbSizeHeader);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool RegisterRawInputDevices(pointer unfoundType_PCRAWINPUTDEVICE_pRawInputDevices, uint uiNumDevices, uint cbSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetRegisteredRawInputDevices(pointer unfoundType_PRAWINPUTDEVICE_pRawInputDevices, pointer unfoundType_PUINT_puiNumDevices, uint cbSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        uint GetRawInputDeviceList(pointer unfoundType_PRAWINPUTDEVICELIST_pRawInputDeviceList, pointer unfoundType_PUINT_puiNumDevices, uint cbSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    public static extern
        long DefRawInputProc(pointer unfoundType_PRAWINPUT_paRawInput, int nInput, uint cbSizeHeader);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPointerDevices(pointer deviceCount, pointer unfoundType_POINTER_DEVICE_INFOpointerDevicespointerDevices_unnamed_1);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPointerDevice(pointer device, pointer unfoundType_POINTER_DEVICE_INFOpointerDevicepointerDevice_unnamed_1);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPointerDeviceProperties(pointer device, pointer propertyCount, pointer unfoundType_POINTER_DEVICE_PROPERTYpointerPropertiespointerProperties_unnamed_2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool RegisterPointerDeviceNotifications(pointer window, bool notifyRange);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPointerDeviceRects(pointer device, pointer unfoundType_RECT_pointerDeviceRect, pointer unfoundType_RECT_displayRect);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetPointerDeviceCursors(pointer device, pointer cursorCount, pointer unfoundType_POINTER_DEVICE_CURSOR_INFOdeviceCursorsdeviceCursors_unnamed_2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetRawPointerDeviceData(uint pointerId, uint historyCount, uint propertiesCount, pointer unfoundType_POINTER_DEVICE_PROPERTY_pProperties, pointer pValues);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ChangeWindowMessageFilter(uint message, int dwFlag);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ChangeWindowMessageFilterEx(pointer hwnd, uint message, int action, pointer unfoundType_PCHANGEFILTERSTRUCT_pChangeFilterStruct);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetGestureInfo(pointer unfoundType_HGESTUREINFO_hGestureInfo, pointer unfoundType_PGESTUREINFO_pGestureInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetGestureExtraArgs(pointer unfoundType_HGESTUREINFO_hGestureInfo, uint cbExtraArgs, pointer unfoundType_PBYTE_pExtraArgs);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool CloseGestureInfoHandle(pointer unfoundType_HGESTUREINFO_hGestureInfo);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetGestureConfig(pointer hwnd, int dwReserved, uint cIDs, pointer unfoundType_PGESTURECONFIG_pGestureConfig, uint cbSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetGestureConfig(pointer hwnd, int dwReserved, int dwFlags, pointer unfoundType_PUINT_pcIDs, pointer unfoundType_PGESTURECONFIG_pGestureConfig, uint cbSize);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ShutdownBlockReasonCreate(pointer hWnd, [MarshalAs(UnmanagedType.LPWStr)] string pwszReason);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ShutdownBlockReasonCreate(pointer hWnd, char* pwszReason);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ShutdownBlockReasonQuery(pointer hWnd, string pwszBuff, pointer unfoundType_DWORDpcchBuffpcchBuff_unnamed_2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ShutdownBlockReasonQuery(pointer hWnd, char* pwszBuff, pointer unfoundType_DWORDpcchBuffpcchBuff_unnamed_2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool ShutdownBlockReasonDestroy(pointer hWnd);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetCurrentInputMessageSource(pointer unfoundType_INPUT_MESSAGE_SOURCEinputMessageSourceinputMessageSource_unnamed_0);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetCIMSSM(pointer unfoundType_INPUT_MESSAGE_SOURCEinputMessageSourceinputMessageSource_unnamed_0);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetAutoRotationState(pointer unfoundType_PAR_STATE_pState);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool GetDisplayAutoRotationPreferences(pointer unfoundType_ORIENTATION_PREFERENCEpOrientationpOrientation_unnamed_0);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetDisplayAutoRotationPreferences(pointer unfoundType_ORIENTATION_PREFERENCE_orientation);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool IsImmersiveProcess(pointer hProcess);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetProcessRestrictionExemption(bool fEnableExemption);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool SetAdditionalForegroundBoostProcesses(pointer topLevelWindow, int processHandleCount, pointer unfoundType_HANDLEprocessHandleArrayprocessHandleArray_unnamed_2);
    [DllImport(lib, SetLastError = true, ExactSpelling = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern
        bool RegisterForTooltipDismissNotification(pointer hWnd, pointer unfoundType_TOOLTIP_DISMISS_FLAGS_tdFlags);

}