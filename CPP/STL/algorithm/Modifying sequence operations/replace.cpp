#include <iostream>
#include <vector>
#include <algorithm>

int main() {
    std::vector <int> a = {2, 1, 3, 4, 1, 2, 1};
    std::replace(a.begin(), a.end(), 1, 0);
    for (size_t i = 0; i < a.size(); i++)
        std::cout << a[i] << " "; // 2 0 3 4 0 2 0
}
