//adjacent_find
//Find equal adjacent elements in range
#include <iostream>
#include <algorithm>
#include <vector>

int main () {
    std::vector <int> a = {4, 2, 1, 5, 30, 30, 1};
    std::vector <int> b = {10, 14, 2, 3, 1};
    auto a_pair = adjacent_find(a.begin(), a.end()),
         b_pair = adjacent_find(b.begin(), b.end());

    if (a_pair != a.end())
        std::cout << *a_pair; // 30
    else std::cout << "Not found";
    std::cout << "\n";
    if (b_pair != b.end())
        std::cout << *a_pair; // Not found
    else std::cout << "Not found";
}
