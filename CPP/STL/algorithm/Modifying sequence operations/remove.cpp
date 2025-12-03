#include <iostream>
#include <vector>
#include <algorithm>
/*
remove / remove_if
Remove value from range
Return value: an iterator to the element that follows the last element not removed
*/
bool isodd(int x) {return x%2;}

int main() {
    std::vector<int> a = {10, 10, 20, 3, 6, 5, 7, 4, 10};
    a.resize(std::remove(a.begin(), a.end(), 10) - a.begin()); // 20 3 6 5 7 4
    a.resize(std::remove_if(a.begin(), a.end(), isodd) - a.begin()); // 20 6 4
    for (auto& i: a) std::cout << i << " ";
}
