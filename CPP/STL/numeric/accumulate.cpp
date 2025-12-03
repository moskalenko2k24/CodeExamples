#include <iostream>
#include <vector>
#include <algorithm>


int main() {
    std::vector <int> a = {1, 3, 5, 2, 8};
    std::cout << accumulate(a.begin(), a.end(), 0); // 19
}
