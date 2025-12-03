#include <iostream>
#include <vector>
#include <algorithm>
#include <functional> // std::greater<int>()

template <typename T>
void print(const std::vector<T>& arr) {
	for (auto& i: arr) std::cout << i << " ";
	std::cout << "\n";
}

int main() {
	std::vector <int> a = {4, 6, 1, 11, -1, 4, 13, 2};
	sort(a.begin(), a.end(), std::greater<int>()); // or std::less<int>()
	print(a); // 13 11 6 4 4 2 1 -1
}
