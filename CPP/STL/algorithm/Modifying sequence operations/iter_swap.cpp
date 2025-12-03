#include <iostream>
#include <vector>
#include <algorithm>

int main() {
    std::vector <int> a = {1, 2, 3, 4};
    std::iter_swap(a.begin(), a.end() - 1);
    for (size_t i = 0; i < a.size(); i++)
            std::cout << a[i] << " "; // 4 2 3 1
}
