#include <iostream>
#include <vector>
#include <algorithm>

int main() {
    std::vector<int> a = {1, 2, 3, 4, 5},
                     b = {6, 7, 8, 9, 0};
    std::swap_ranges(a.begin(), a.begin() + 3, b.begin() + 2);
    std::cout << "a:\n";
    for (auto i = a.begin(); i != a.end(); i++)
        std::cout << *i << " "; // 8 9 0 4 5
    std::cout << "\nb:\n";
    for (auto i = b.begin(); i != b.end(); i++)
        std::cout << *i << " "; // 6 7 1 2 3
}
