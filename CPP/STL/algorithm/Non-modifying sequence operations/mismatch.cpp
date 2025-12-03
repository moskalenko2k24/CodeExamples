//mismatch
//Return first position where two ranges differ, returns pair of 2 iterators
#include <iostream>
#include <algorithm>
#include <vector>

int main () {
    //                     0  1  2  *  4
    std::vector <int> a = {1, 2, 3, 4, 5};
    std::vector <int> b = {1, 2, 3, 9, 5};
    auto pos = std::mismatch(a.begin(), a.end(), b.begin());
    std::cout << pos.first - a.begin(); // 3
    std::cout << "\n" << *pos.first << " " << *pos.second; // 4 9
}
