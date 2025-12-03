#include <iostream>     // std::cout
#include <algorithm>    // std::search_n
#include <vector>       // std::vector

int main () {
    std::vector<int> myvector = {10, 20, 30, 30, 20, 10, 10, 20};
    auto it = std::search_n (myvector.begin(), myvector.end(), 2, 30);
    if (it != myvector.end())
        std::cout << "two 30s found at position " << (it - myvector.begin());
    else
        std::cout << "match not found";
}
