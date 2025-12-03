#include <stdio.h>

int main(void) {
    int x;
    if (scanf("%d", &x) != 1) {
        printf("Error! Incorrect input");
        return -1;
    }
    printf("%d * 2 = %d\n", x, x * 2);
}
