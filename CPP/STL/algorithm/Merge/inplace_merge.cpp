#include <iostream>     // std::cout
#include <algorithm>    // std::merge, std::sort
#include <vector>       // std::vector
#include <iterator>

template <class iter>
void my_sort(iter begin, iter end) { // Merge sort =)
    if (std::distance(begin, end) < 2) return;
    iter mid = begin + std::distance(begin, end) / 2;
    my_sort(begin, mid);
    my_sort(mid, end);
    std::inplace_merge(begin, mid, end);
}

int main () {
    std::vector <int> a = {3, 1, 4, -9, 10, 2, -1, 4, 3, 15, 1};
    my_sort(a.begin(), a.end()); // -9 -1 1 1 2 3 3 4 4 10 15
    for (auto& i: a)
        std::cout << i << " ";
}
