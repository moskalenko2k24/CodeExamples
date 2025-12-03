#include <iostream>

template <class T>
void print(const T& obj) {
	std::cout << obj << "\nvoid print(const T& obj)\n";
}

void print(int n) {
	std::cout << n << "\nvoid print(int n)\n";
}


int main() {
	int a = 4;
	print(a); //void print(int n)
	print("Hello"); //void print(const T& obj)
	print<>(a); //void print(const T& obj) !
}