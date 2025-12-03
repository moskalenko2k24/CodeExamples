#include <iostream>
#include <vector>
#include <algorithm> // std::copy_n, only since C++11!

int main() {
    std::vector <int> a = {1, 2, 3, 4, 5}, b(a.size(), 0);
    auto it = std::copy_n(a.begin() + 2, std::distance(a.begin() + 2, a.end()), b.begin());
    for (size_t i = 0; i < b.size(); i++)
        std::cout << b[i] << " "; // 3 4 5 0 0
    b.resize(std::distance(b.begin(), it));
    std::cout << "\n";
    for (size_t i = 0; i < b.size(); i++)
        std::cout << b[i] << " "; // 3 4 5
}