// С-string example
#include <iostream>
#include <cstring>

using namespace std;

int main() {
    const int max_size = 1000;
    char s[max_size] = "Hello",
         delim[] = "-------------------------------\n";
    cout << "s = \"Hello\"\n";
    // strlen
    cout << "strlen(s) == " << strlen(s) << endl; // 5
    cout << delim;
    // strcpy
    strcpy(s, "123"); // s == "123"
    cout << "After strcpy(s, \"123\"): s == " << "\"" << s << "\"\n";
    cout << delim;
    // strncpy
    strncpy(s, "12345" + 1, 3); // s == "234"
    cout << "After strncpy(s, \"12345\" + 1, 3): s == \"" << s << "\"\n";
    cout << delim;
    // strcat
    strcat(s, "+10"); // s == "234+10"
    cout << "After strcat(s, \"+10\"): s == \"" << s << "\"\n";
    cout << delim;
    // strcmp
    cout << "strcmp(\"abc\", \"abc\") == " << strcmp("abc", "abc") << endl; // 0
    cout << "strcmp(\"abc\", \"bbc\") == " << strcmp("abc", "bbc") << endl; // -1
    cout << "strcmp(\"bbc\", \"abc\") == " << strcmp("bbc", "abc") << endl; // 1
    cout << delim;
    // strncmp
    cout << "strncmp(\"123456\", \"123568\", 2) == " << strncmp("123456", "123568", 2) << endl; // 0
    cout << "strncmp(\"12\", \"68\", 1) == " << strncmp("12", "68", 1) << endl; // -1
    //cin.get();
}
/*
s = "Hello"
strlen(s) == 5
-------------------------------
After strcpy(s, "123"): s == "123"
-------------------------------
After strncpy(s, "12345" + 1, 3): s == "234"
-------------------------------
After strcat(s, "+10"): s == "234+10"
-------------------------------
strcmp("abc", "abc") == 0
strcmp("abc", "bbc") == -1
strcmp("bbc", "abc") == 1
-------------------------------
strncmp("123456", "123568", 2) == 0
strncmp("12", "68", 1) == -1
*/
