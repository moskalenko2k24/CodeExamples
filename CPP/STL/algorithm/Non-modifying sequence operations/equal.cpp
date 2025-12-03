#include <iostream>
#include <iomanip>
#include <algorithm>
#include <vector>

int main () {
    std::vector <int> a = {1, 2, 3, 4, 5};
    std::vector <int> b = {1, 2, 3, 4, 5};
    std::cout << std::boolalpha
              << std::equal(a.begin(), a.end(), b.begin()) << "\n";
    if (a == b) std::cout << "a == b\n";
    b[3] = 2;
    std::cout << std::boolalpha << std::equal(a.begin(), a.end(), b.begin());
}
