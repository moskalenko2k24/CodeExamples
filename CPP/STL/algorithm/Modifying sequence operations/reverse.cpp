#include <iostream>
#include <vector>
#include <algorithm>

int main() {
    std::vector <int> a = {1, 2, 3, 4};
    std::reverse(a.begin(), a.end());
    for (size_t i = 0; i < a.size(); i++)
            std::cout << a[i] << " "; // 4 3 2 1
}
