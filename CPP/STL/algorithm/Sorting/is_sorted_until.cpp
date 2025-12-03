#include <iostream>
#include <vector>
#include <algorithm>

int main() {
    std::vector <int> a = {1, 2, 4, 4, 1, 6, 7};
    std::cout << std::is_sorted_until(a.begin(), a.end()) - a.begin(); // 4
}
