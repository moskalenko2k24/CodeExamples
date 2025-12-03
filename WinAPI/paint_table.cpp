#ifndef UNICODE
#define UNICODE
#endif 

#include <windows.h>

LRESULT CALLBACK WindowProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam) {
	PAINTSTRUCT ps;
	HDC hdc;
	int x, y;
	static int sx, sy;
	static HPEN pen;
    switch (uMsg) {
		case WM_CREATE:
			// create pen
			pen = CreatePen(PS_SOLID, 1, RGB(0, 0, 255));
			break;
		case WM_SIZE:
			sx = LOWORD(lParam);
			sy = HIWORD(lParam);
			InvalidateRect(hwnd, NULL, TRUE); // WM_PAINT
			break;
		case WM_PAINT:
			hdc = BeginPaint(hwnd, &ps);
			SelectObject(hdc, pen); // select pen
			for (x = 0; x < sx && sx >= 10; x += sx / 10) {
				MoveToEx(hdc, x, 0, NULL);
				LineTo(hdc, x, sy);
			}
			
			for (y = 0; y < sy && sy >= 10; y += sy / 10) {
				MoveToEx(hdc, 0, y, NULL);
				LineTo(hdc, sx, y);
			}
			
			EndPaint(hwnd, &ps);
			break;
        case WM_DESTROY:
			DeleteObject(pen); // free pen
            PostQuitMessage(0);
            return 0;
    }
    
    return DefWindowProc(hwnd, uMsg, wParam, lParam);
}

// int WINAPI  WinMain(HINSTANCE hInstance, HINSTANCE, LPSTR pCmdLine, int nCmdShow)
// int WINAPI wWinMain(HINSTANCE hInstance, HINSTANCE, PWSTR pCmdLine, int nCmdShow)
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
