#ifndef UNICODE
#define UNICODE
#endif

#include <windows.h>
#include <cwchar>
#include <string>

LRESULT CALLBACK WindowProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam) {
    PAINTSTRUCT ps;
    HDC hdc;
    static int t = 0;
    wchar_t str[20] = L"Таймер: ";
    switch (uMsg) {
        case WM_CREATE:
            SetTimer(hwnd, 1, 1000, NULL);
            break;
        case WM_TIMER:
            ++t;
            InvalidateRect(hwnd, NULL, TRUE);
            break;
        case WM_PAINT:
            hdc = BeginPaint(hwnd, &ps);
            wcscat(str, std::to_wstring(t).c_str());
            TextOut(hdc, 0, 0, str, wcslen(str));
            EndPaint(hwnd, &ps);
            break;
        case WM_DESTROY:
            KillTimer(hwnd, 1);
            PostQuitMessage(0);
            return 0;
    }
    
    return DefWindowProc(hwnd, uMsg, wParam, lParam);
}

int main() {
    auto hInstance = GetModuleHandle(nullptr);
    auto nCmdShow = SW_SHOW;
    // Register the window class.
    const wchar_t CLASS_NAME[] = L"Sample Window Class";
    
    WNDCLASS wc = {};

    wc.lpfnWndProc   = WindowProc;
    wc.hInstance     = hInstance;
    wc.lpszClassName = CLASS_NAME;
    wc.hbrBackground = (HBRUSH)(COLOR_WINDOW + 1);
    wc.hCursor = LoadCursor(NULL, IDC_ARROW);

    RegisterClass(&wc);

    // Create the window.

    HWND hwnd = CreateWindowEx(
        0,                              // Optional window styles
        CLASS_NAME,                     // Window class
        L"Win32-приложение",            // Window text
        WS_OVERLAPPEDWINDOW,            // Window style

        // Size and position
        CW_USEDEFAULT, CW_USEDEFAULT, CW_USEDEFAULT, CW_USEDEFAULT,

        NULL,       // Parent window
        NULL,       // Menu
        hInstance,  // Instance handle
        NULL        // Additional application data
    );

    if (hwnd == NULL) {
        return 0;
    }

    ShowWindow(hwnd, nCmdShow);
    UpdateWindow(hwnd);
    
    // Run the message loop.
    MSG msg = {};
    while (GetMessage(&msg, NULL, 0, 0)) {
        TranslateMessage(&msg);
        DispatchMessage(&msg);
    }

    return 0;
}
