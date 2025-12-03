#include <iostream>
#include <vector>
#include <algorithm>

int main() {
    std::vector <int> a = {1, 2, 3, 4, 5};
    auto it = std::remove_if(a.begin(), a.end(), [](int x){return x%2;});
    a.resize(it - a.begin());
    for (auto& i: a)
        std::cout << i << " "; // 2 4
}
