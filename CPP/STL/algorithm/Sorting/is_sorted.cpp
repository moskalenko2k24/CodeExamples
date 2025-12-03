#include <iostream>
#include <vector>
#include <algorithm>

int main() {
    std::vector <int> a = {1, 2, 3, 4, 5, 6, 7};
    std::cout << std::is_sorted(a.begin(), a.end()); // 1
}
