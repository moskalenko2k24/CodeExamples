#include <iostream>
#include <vector>
#include <algorithm>
#include <functional> // std::plus<int>(), std::negate<int>()

int main() {
    std::vector <int> a = {1, 2 ,3}, b{4, 5, 6},
                      c(a.size());
    std::transform(a.begin(), a.end(), b.begin(), c.begin(), std::plus<int>());
    for (size_t i = 0; i < c.size(); i++)
        std::cout << c[i] << " "; // 5 7 9
    std::cout << std::endl;
    std::transform(a.begin(), a.end(), a.begin(), std::negate<int>());
    for (size_t i = 0; i < a.size(); i++)
        std::cout << a[i] << " "; // -1 -2 -3
    
}