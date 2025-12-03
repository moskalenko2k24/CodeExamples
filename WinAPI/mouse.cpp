#ifndef UNICODE
#define UNICODE
#endif 

#include <windows.h>
#include <cwchar>
#include <string>

const wchar_t *l_str = L"Левая кнопка";
const wchar_t *r_str = L"Правая кнопка";

LRESULT CALLBACK WindowProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam) {    
    HDC hdc;
    int x, y;
    switch (uMsg) {
        case WM_LBUTTONDOWN:
            x = LOWORD(lParam);
            y = HIWORD(lParam);
            hdc = GetDC(hwnd);
            TextOutW(hdc, x, y, l_str, wcslen(l_str));
            ReleaseDC(hwnd, hdc);
            break;
        case WM_RBUTTONDOWN:
            x = LOWORD(lParam);
            y = HIWORD(lParam);
            hdc = GetDC(hwnd);
            TextOutW(hdc, x, y, r_str, wcslen(r_str));
            ReleaseDC(hwnd, hdc);
            break;
        case WM_LBUTTONUP:
        case WM_RBUTTONUP:
            InvalidateRect(hwnd, NULL, TRUE);
            break;
        case WM_DESTROY:
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
