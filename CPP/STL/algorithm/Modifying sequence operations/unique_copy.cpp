#include <iostream>
#include <vector>
#include <algorithm>

int main() {
    std::vector <int> a = {1, 3, 3, 2, 4, 1, 1}, b(a.size());
    auto it = std::unique_copy(a.begin(), a.end(), b.begin());
    b.resize(it - b.begin());
    for (auto i = b.begin(); i != b.end(); ++i)
        std::cout << *i << " "; // 1 3 2 4 1
}
