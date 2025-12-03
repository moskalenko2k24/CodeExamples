#include <iostream>
#include <vector>
#include <numeric>

int main() {
    std::vector <int> a(10);
    std::iota(a.begin(), a.end(), 3); // C++11
    for (size_t i = 0; i < a.size(); i++)
        std::cout << a[i] << " "; // 3 4 5 6 7 8 9 10 11 12
}
