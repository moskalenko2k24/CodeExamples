#include <iostream>

class friend_; //forward definition

class human {
	private:
		std::string secret;
	public:
		human() {
			secret = "password";
		}
	friend friend_;
};

class friend_{
	public:
		void getsecrets(human& obj) {
			std::cout << "secret: " << obj.secret << std::endl;
		}
};

int main() {
	human Andrew;
	friend_ bestf;
	bestf.getsecrets(Andrew); //secret: password
}