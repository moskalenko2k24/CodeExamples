#include <iostream>

int main() {
	int a = 6, b = 8;
	std::cout << " a = " << a << " ; b = " << b << std::endl;
	a^=b^=a^=b; // Undefined behaviour!!!
	std::cout << "a = " << a << " ; b = " << b << std::endl;
}
