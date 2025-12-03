//find_first_of
//Find element from set in range
#include <iostream>
#include <vector>
#include <algorithm>
#include <cctype>

bool letter_equal(char c1, char c2) {
    return std::tolower(c1) == std::tolower(c2);
}

int main() {
    std::vector <char> letters = {'a', 'b', 'c', 'd', 'e', 'f'};
    std::vector <char> vec_cmp = {'A', 'B', 'C'};

    auto i = find_first_of(letters.begin(), letters.end(), vec_cmp.begin(), vec_cmp.end());
    std::cout << "Position of first match: " << i - letters.begin() << "\n";
    if (i != letters.end())
        std::cout << "First match: " << *i;
    else
        std::cout << "No matches found!";

    std::cout << "\n";

    i = find_first_of(letters.begin(), letters.end(), vec_cmp.begin(), vec_cmp.end(), letter_equal);
    std::cout << "Position of first match: " << i - letters.begin() << "\n";
    if (i != letters.end())
        std::cout << "First match: " << *i;
    else
        std::cout << "No matches found!";
}