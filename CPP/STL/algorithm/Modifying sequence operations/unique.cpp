//unique
//Remove consecutive duplicates in range, O(N)
#include <iostream>
#include <algorithm>
#include <vector>

template <class T>
void print_vector(const std::vector<T>& a) {
    for (auto& i: a) std::cout << i << " ";
    std::cout << "\n";
}

int main () {
    std::vector <int> a = {1, 1, 3, 4, 5, 5, 4, 1, 3, 3};
    std::cout << "Before:\n";
    print_vector(a); // 1 1 3 4 5 5 4 1 3 3
    auto it = std::unique(a.begin(), a.end());
    a.resize(std::distance(a.begin(), it)); // !!!
    std::cout << "After:\n";
    print_vector(a); // 1 3 4 5 4 1 3
}
