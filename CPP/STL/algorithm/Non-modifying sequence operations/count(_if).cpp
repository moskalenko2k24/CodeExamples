#include <iostream>
#include <algorithm>
#include <vector>

int main () {
    std::vector <int> a = {1, 1, 1, 6, 7, 8, 9};
    size_t one_count = std::count(a.begin(), a.end(), 1);
    size_t odd_count = std::count_if(a.begin(), a.end(), [](int x){return x % 2;});
    std::cout << "one_count: " << one_count << "\n"
              << "odd_count: " << odd_count;
}
