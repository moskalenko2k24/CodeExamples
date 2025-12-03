#include <iostream>
using namespace std;
 
struct S {
    void f() const {
        const_cast <S*> (this) -> i = 42;
    }
    int i = 100500;
};
 
int main() {
    const S s;
    cout << s.i << endl;
 
    s.f();
    cout << s.i << endl;
}