#include <iostream>
#include <vector>
#include <algorithm>

int main() {
    int a, b;
    a = 3; b = 7;
    std::vector <int> arr;
    for (int i = a; i <= b; i++)
            arr.push_back(i);
    std::random_shuffle(arr.begin(), arr.end());
    for (size_t i = 0; i < arr.size(); i++)
        std::cout << arr[i] << " ";
    // Possible output: 7 4 6 5 3
}
