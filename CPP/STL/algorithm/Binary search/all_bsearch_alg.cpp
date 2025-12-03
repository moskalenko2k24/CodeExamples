#include <iostream>
#include <vector>
#include <algorithm>

int main() {
    //                     0  *  2  3  *  5  6
    std::vector <int> a = {1, 2, 2, 2, 3, 5, 6};
    auto low = std::lower_bound(a.begin(), a.end(), 2), // First number x >= 2
         high = std::upper_bound(a.begin(), a.end(), 2); // First number x > 2
    std::cout << low - a.begin() << "\n" // 1
              << high - a.begin() << "\n"; // 4
    std::cout << std::boolalpha
              << std::binary_search(a.begin(), a.end(), 4); // false
    auto e = std::equal_range(a.begin(), a.end(), 2);
    std::cout << "\n"
              << std::distance(a.begin(), e.first) << "\n" // 1
              << std::distance(a.begin(), e.second) << "\n"; // 4
}