#include <iostream>

class Shape {
	public:
		virtual void draw() = 0 {
			std::cout << "Shape::draw()\n";	
		};
};

class Circle: public Shape {
	public:
		virtual void draw() {
			std::cout << "Circle::draw()\n";
		}
};

class Triangle: public Shape {
	public:
		virtual void draw() {
			std::cout << "Triangle::draw()\n";
		}
};

int main() {
	//Shape *shape = new Shape; // Compilation Error
	Shape *obj = new Circle;
	Shape *tr = new Triangle;
	obj->draw(); //Circle::draw() because of virtual
	tr->draw(); // Triangle::draw()
	delete obj; delete tr;
}