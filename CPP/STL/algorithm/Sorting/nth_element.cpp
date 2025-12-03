#include <iostream>
#include <algorithm>
#include <functional>

int main() {
	std::vector <int> a = {4, 5, 10, 11, -1, 6, 7, 7}; // -1, 4, 5, 6, 7, 7, 10, 11
	auto pos = a.begin() + 3;
	std::nth_element(a.begin(), pos, a.end(), std::greater<int>()); // fourth max element
	std::cout << *pos << std::endl;// 7
	pos = a.begin() + 1;
	std::nth_element(a.begin(), pos, a.end(), std::less<int>()); // second min element
	std::cout << *pos << std::endl;// 4
}
