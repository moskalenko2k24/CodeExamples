#include <iostream>
#include <iomanip>
#include <vector>
#include <algorithm>
#include <functional>
#include <string>

struct player {
	std::string fname,sname;
	size_t age;
};

std::istream& operator >>(std::istream& in, player& obj) {
	return in >> obj.fname >> obj.sname >> obj.age;
}

class CompareStr {
	private:
	  std::string player::*ptr;
	public:
	  CompareStr(std::string player::*ptr): ptr(ptr) {}
      bool operator () (player a, player b) { return a.*ptr < b.*ptr;}
};

std::ostream& operator <<(std::ostream& out, const std::vector<player>& arr) {
	using std::setw;
	for (auto& i: arr)
		out << setw(17) << i.fname << " " << setw(15) 
			<< i.sname << "  " << i.age << "\n";
	return out << "--------------------------------------\n";
}

int main() {
	std::cout << "Count of players: ";
	size_t p_count;
	std::cin >> p_count;
	std::vector<player> players(p_count);
	std::cout << "Write information about players: name, surname and age\n"
			  << "(for example \"Magnus Carlsen 24\")\n";
	for (auto& i: players) std::cin >> i;
	std::cout << "Before sort:\n";
	std::cout << players;
	//Sorting by firstname
	std::sort(players.begin(), players.end(), CompareStr(&player::fname));
	std::cout << "Sorting by fname:\n";
	std::cout << players;
	//Sorting by secondname
	std::sort(players.begin(), players.end(), CompareStr(&player::sname));
	std::cout << "Sorting by sname:\n";
	std::cout << players;
}

/* Test for program
Count of players:5
Magnus Carlsen 24
Viswanathan Anand 45
Fabiano Caruana 23
Vladimir Kramnik 40
Levon Aronian 32
*/
