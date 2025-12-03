#include <iostream>
#include <vector>
#include <algorithm>

bool pred(int x) {return x < 3;}

int main() {
    std::vector <int> a = {2, 1, 3, 4, 1, 2, 1};
    std::replace_if(a.begin(), a.end(), pred, 0);
    for (size_t i = 0; i < a.size(); i++)
        std::cout << a[i] << " "; // 0 0 3 4 0 0 0
}
