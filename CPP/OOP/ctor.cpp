#include <iostream>

class basepoint {
	protected:
		int x, y;
	public:
		basepoint(int a = 0, int b = 0): x(a), y(b) {}
		virtual void print(){
		std::cout << "(" << x << " ; " << y << ")\n";
		}
};

class point: public basepoint {
	protected:
		int z;
	public:
		point(int a = 0, int b = 0, int c = 0): basepoint(a, b), z(c) {}
		void print() override{
			std::cout << "(" << x << " ; " << y << " ; " << z << ")\n";
		}
};

int main() {
	basepoint* Point = new point(1, 2, 3);
	Point -> print();
	delete Point;
}