#include <iostream>

template<class T>
struct C {
   void print() { std::cout << "I am generic\n"; }
   void writeln() {std::cout << "Generic\n";}
};
 
// Specialization for print, T = int
template<>
void C<int>::print()
{ std::cout << "I am specialized for int\n"; }

 
template<class T>
void func();
 
// Specialization for T = double
template <>
void func<double>() { std::cout << "I am func<double>\n"; }
 
int main() {
	C<double>  c1;
	C<int>     c2;
	c1.print(); // I am generic
	c2.print(); // I am specialized for int
	c1.writeln(); // Generic
	c2.writeln(); // Generic
	func<double>(); // I am func<double>
	// func<int>(); // Compile time error, no definition for T = int
}
