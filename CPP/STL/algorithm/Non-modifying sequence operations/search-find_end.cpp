#include <iostream>
#include <vector>
#include <algorithm>

/*
    std::search    Search first occurrence of subsequence
    std::find_end  Search last occurrence of subsequence
    BinaryPredicate can be used as last parameter (like overloaded ==)
*/

int main() {
    //                     0  1  2  3  4  *  6  7  8  9
    std::vector <int> a = {1, 2, 3, 4, 5, 1, 2, 3, 4, 5};
    std::vector <int> b = {3, 2};
    auto first_pos = std::search(a.begin(), a.end(), b.begin(), b.end()),
         last_pos = std::find_end(a.begin(), a.end(), b.begin(), b.end());

    if (first_pos != a.end())
        std::cout << "First pos: " << std::distance(a.begin(), first_pos); // 0
    else
        std::cout << "Subsequence not found";
    std::cout << "\n";
    if (last_pos != a.end())
        std::cout << "Last pos: " << std::distance(a.begin(), last_pos); // 5
    else
        std::cout << "Subsequence not found";
}

