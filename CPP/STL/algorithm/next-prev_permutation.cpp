#include <iostream>
#include <algorithm>
#include <vector>

int main() {
    int n;
    std::cin >> n;
    std::vector<int> a;
    for (int i = 0; i < n; i++) a.push_back(i + 1);
    do {
		for (auto i&: a) std::cout << i << " ";
        std::cout << "\n";
	}
    while (next_permutation(a.begin(), a.end())); // There is also prev_permutation
}
