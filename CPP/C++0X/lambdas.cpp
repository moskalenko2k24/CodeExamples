#include <iostream>
#include <vector>
#include <algorithm>

int main() {
	std::vector<int> arr(10, 1);
	int k = 1, count = 0;
	for_each(arr.begin(), arr.end(), [&k, &count](int& value) { // [&](int& value)
          value *= k;
          k *= 2;
          count++;
    });
	for (auto& i : arr) std::cout << i << " "; // 1 2 4 8 16 32 64 128 256 512
	std::cout << "\nCount of iterations: " << count << std::endl;
}