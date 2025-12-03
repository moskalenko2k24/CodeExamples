#include <iostream>
#include <functional>

int sum(int a, int b) {
	return a + b;
}

int mult(int a, int b) {
	return a * b;
}

int calc(int a, int b, std::function<int(int, int)> func) {
	return func(a, b);
}

class monster {
	private:
		int ammo = 30, health = 100;
	public:
		int gethealth() {
			return health;
		}
		int getammo() {
			return ammo;
		}
};

void info(monster& obj, std::function<int(monster& obj)> func) {
	std::cout << func(obj) << std::endl;
}

int main() {
	std::cout << calc(3, 4, sum) << std::endl;//7
	std::cout << calc(3, 4, mult) << std::endl;//12
	monster player;
	std::cout << "ammo:";
	info(player, &monster::getammo);//30
	std::cout << "health:";
	info(player, &monster::gethealth);//100
}