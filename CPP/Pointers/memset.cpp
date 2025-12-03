/* memset example */
#include <cstdio>
#include <cstring>

int main() {
    char str[] = "almost every programmer should know memset!";
    memset(str, '-', 6);
    puts(str); // ------ every programmer should know memset!
}
