#include <iostream>
#include <list>

using namespace std;

template <typename Type>
void print(const list<Type>& lst){
	for (auto i: lst) cout << i << " ";
	if (lst.empty()) cout << "List is empty";
	cout << endl;
}

int main(){
	list <int> a = {1, 4, 11, 6, 7};
	list <int> b = {6, 6, 17};
	cout << "Before:\n";
	print(a); print(b);
	a.splice(a.end(),b); // O(1)
	cout << "After:\n";
	print(a); print(b);
}
