#include <iostream>
#include <algorithm>
#include <vector>
// void rotate (ForwardIterator first, ForwardIterator middle, ForwardIterator last);
int main () {
    std::vector<int> a = {1, 2, 3, 4, 5, 6, 7, 8, 9};
    // std::rotate(a.begin(), a.begin() + 3, a.end()); // 4 5 6 7 8 9 1 2 3
    std::rotate(a.rbegin(), a.rbegin() + 3, a.rend()); // 7 8 9 1 2 3 4 5 6
    for (auto& i: a) std::cout << i << " ";
}
