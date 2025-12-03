#include <iostream>

int sum(int a, int b) {
	return a + b;
}

int mult(int a, int b) {
	return a * b;
} 

int calc(int a, int b, int(*func)(int, int)) {
	return func(a, b);
}

class monster {
	private:
		int ammo = 30, health = 100;
	public:
		int gethealth() { return health; }
		int getammo() { return ammo; }
};

void info(monster& obj, int(monster::*func)()) {
	std::cout << (obj.*func)() << std::endl;
}

void info_ptr(monster* obj, int(monster::*func)()) {
	std::cout << (obj->*func)() << std::endl;
}

int main() {
	std::cout << calc(3, 4, sum) << std::endl; // 7
	std::cout << calc(3, 4, mult) << std::endl; // 12
	monster player;
	std::cout << "ammo:";
	info(player, &monster::getammo); // 30
	std::cout << "health:";
	info_ptr(&player, &monster::gethealth); // 100
}