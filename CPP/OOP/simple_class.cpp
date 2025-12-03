#include <iostream>

class counter {
	private:
		int count;
	public:
		counter();
		counter(const int& n);
		counter&& operator++();
		counter operator++(int); // Postfix 
		counter&& operator--();
		counter operator--(int); // Postfix 
		operator int(); // Cast operator int()
		friend std::istream& operator>>(std::istream&, counter&);
		friend std::ostream& operator<<(std::ostream&, counter&);
};

counter::counter() { count = 0; }

counter::counter(const int& n) { count = n; }

counter&& counter::operator++() {
	count++;
	return *this;
}

counter counter::operator++(int) {
	counter temp = *this;
	++*this;
	return temp;
}

counter&& counter::operator--() {
	count--;
	return *this;
}

counter counter::operator--(int) {
	counter temp = *this;
	--*this;
	return temp;
}

counter::operator int() {
	return count;
}


std::istream& operator>>(std::istream& in, counter& obj) {
	in >> obj.count;
	return in;
}

std::ostream& operator<<(std::ostream& out, counter& obj) {
	out << obj.count;
	return out;
}

int main() {
	counter a(10), b(4);
	std::cout << "a = " << int(a) << " ; b = " << int(b) << std::endl;
	a++; b++;
	std::cout << "a = " << int(a) << " ; b = " << int(b) << std::endl;
	//std::cin.get();
}

