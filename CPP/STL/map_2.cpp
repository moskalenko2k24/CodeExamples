#include <string>
#include <iostream>
#include <vector>
#include <map>
 
int main(){
    std::vector<std::string> words = { 
        "this", "sentence", "is", "not", "a", "sentence",
	"this", "sentence", "is", "a", "hoax" 
    };
 
    std::map<std::string, size_t>  word_map;
    for (const auto &w : words) {
        ++word_map[w];
    }
	//Finding count of each word
    for (const auto &pair : word_map) {
        std::cout << pair.second
	          << " occurrences of word '"
	          << pair.first << "'\n";
    }
    /*Output:
      2 occurrences of word 'a'
      1 occurrences of word 'hoax'
	  2 occurrences of word 'is'
      1 occurrences of word 'not'
	  3 occurrences of word 'sentence'
      2 occurrences of word 'this' */
}
