#include <iostream>
#include <vector>
#include <algorithm>
#include <iterator>
#include <cstdlib>
#include <ctime>

int rand_num() { return std::rand()%20; }

int main() {
    std::srand(std::time(nullptr));
    std::vector <int> a(8);
    std::generate(a.begin(), a.end(), rand_num);
    std::copy(a.begin(), a.end(), std::ostream_iterator<int>(std::cout, " "));
    std::generate_n(a.begin(), 4, rand_num); std::cout << "\n";
    std::copy(a.begin(), a.end(), std::ostream_iterator<int>(std::cout, " "));
}
