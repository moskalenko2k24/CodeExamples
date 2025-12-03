#include <iostream>

template<typename T, size_t N>
void foo(T (&arr)[N]) {
    for(auto &x: arr)
		std::cout << x << "; ";
    std::cout << std::endl;
}

int main() {
    int arr[5] = {5, 7, 8, 9, 0};
    int (*p)[5] = &arr; // Pointer to array
    int (&r)[5] = arr; // Reference to array
    foo(arr);
    foo(*p);
    foo(r);
}