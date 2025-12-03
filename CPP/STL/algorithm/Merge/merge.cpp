// merge algorithm example
#include <iostream>     // std::cout
#include <algorithm>    // std::merge, std::sort
#include <vector>       // std::vector

int main () {
    int first[] = {5, 10, 15, 20, 25};
    int second[] = {50, 40, 30, 20, 10};
    std::vector<int> v(10);
    std::sort(first, first + 5);
    std::sort(second, second + 5);
    std::merge(first, first + 5, second, second + 5, v.begin());
    std::cout << "The resulting vector contains:";
    // 5 10 10 15 20 20 25 30 40 50
    for (auto it = v.begin(); it != v.end(); ++it)
        std::cout << ' ' << *it;;
}
