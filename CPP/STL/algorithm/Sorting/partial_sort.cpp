#include <iostream>
#include <vector>
#include <algorithm>
#include <functional> // std::greater<int>

int main() {
    std::vector <int> a = {1, 2, 3, 4, 5, 6, 7};
    std::partial_sort(a.begin(), a.begin() + 3, a.end(), std::greater<int>());
    for (auto& i: a)
        std::cout << i << " "; // 7 6 5 1 2 3 4
}
