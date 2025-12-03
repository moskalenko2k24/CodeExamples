#include <iostream>
#include <vector>
#include <algorithm>

int main() {
    std::vector <int> a = {1, 2, 3, 4, 5};
    std::vector <int> b(a.size());
    std::reverse_copy(a.begin(), a.end(), b.begin());
    for (size_t i = 0; i < b.size(); i++)
        std::cout << b[i] << " "; // 5 4 3 2 1
}
