#include <iostream>
#include <vector>
#include <numeric>

int main() {
    std::vector <int> a, b;
    for (int i = 1; i <= 10; i++)
        a.push_back(i);
    b.resize(a.size());
    std::partial_sum(a.begin(), a.end(), b.begin());
    for (size_t i = 0; i < b.size(); i++)
        std::cout << a[i] << " - " << b[i] << "\n";
}
