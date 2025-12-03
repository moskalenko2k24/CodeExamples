#include <iostream>

struct kek {
     void operator()() {
        std::cout << "kek\n";
    }
};

class SumClass {
    public:
        int operator()(int a, int b) {
            return a + b;
        }

};

int sum(int a, int b) { return a + b; }

int f(int a, int b, int (*func)(int x, int y)) {
    return func(a, b);
}

int main() {
    kek lol;
    lol();
    int s1 = sum(3, 4),
        s2 = SumClass()(3, 4);
    std::cout << s1 << " " << s2;
}
