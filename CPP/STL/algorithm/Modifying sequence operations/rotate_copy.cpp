#include <iostream>
#include <vector>
#include <algorithm>

int main() {
    std::vector <int> a = {1, 2, 3, 4, 5},
                      b(a.size());
    std::rotate_copy(a.begin(), a.begin() + 2, a.end(), b.begin()); // 3 4 5 1 2
    for (auto& i: b)
        std::cout << i << " ";
}
