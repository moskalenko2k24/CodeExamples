#include <bits/stdc++.h>

using namespace std;

template <typename T, typename cmp>
void print_set(const set<T, cmp>& s) {
    cout << "{";
    for (auto i: s) cout << i << " ";
    cout << "\b}\n";
}

struct cmp { // Comparator
   bool operator()(int a, int b) const {
       return a > b;
   }
};

int main() {
    set <int, cmp> st;
    for (int i = 1; i < 6; i++) st.insert(i * 10);
    print_set(st); // {50 40 30 20 10}
    st.erase(st.begin());
    print_set(st); // {40 30 20 10}
}
