#include <iostream>
#include <vector>
#include <algorithm>

int main() {
    std::vector<int> a(8), b(8, 0);
    std::fill(a.begin(), a.begin() + 4, 1);
    std::fill(a.begin() + 4, a.end(), 0);
    for (size_t i = 0; i < a.size(); i++)
        std::cout << a[i] << " "; // 1 1 1 1 0 0 0 0
    std::fill_n(b.begin(), 3, 1); std::cout << "\n";
    for (size_t i = 0; i < b.size(); i++)
        std::cout << b[i] << " "; // 1 1 1 0 0 0 0 0
}
