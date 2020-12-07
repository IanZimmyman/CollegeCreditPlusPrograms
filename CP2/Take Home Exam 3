// Ian Zimmerman
//Take Home Exam 3

#include "stdafx.h"//Microsoft wants this here, don't ask me.
#include <iostream>
#include <string>
using namespace std;

class human
{
	public:

		human() : name("JohnDoe"), age(0), height(6), weight(160)
		{}

		void eat();
		void sleep();
		void poop();
		void walk();
		void outputdescription();

		void setname(string n)
		{
			name = n;
		}

		string getname()
		{
			return name;
		}

		void setage(int a)
		{
			age = a;
		}

		int getage()
		{
			return age;
		}

		void setheight(double h)
		{
			height = h;
		}

		double getheight()
		{
			return height;
		}

		void setweight(double w)
		{
			weight = w;
		}

		double getweight()
		{
			return weight;
		}

	private:
		string name;
		int age;
		double height, weight;
};


int main()
{
	human Ian;
	Ian.setname("Ian");
	Ian.setage(16);
	Ian.setheight(5.5);
	Ian.setweight(145);
	
	cout << Ian.getname() << " is " << Ian.getage() << ", is " << Ian.getheight() << " feet tall, and is " << Ian.getweight() << " pounds.\n";
	Ian.eat();
	Ian.poop();
	Ian.walk();
	Ian.sleep();
	Ian.outputdescription();
    return 0;
}

void human::eat()
{
	double food;
	cout << "How much food did " << name << " eat?" << endl;
	cin >> food;
	weight = weight + food;
	cout << name << " now weighs " << weight << "." << endl;
	system("pause");
}

void human::sleep()
{
	cout << name << " went to sleep." << endl;
	system("pause");
}

void human::poop()
{
	double crap;
	cout << "How much did " << name << " crap?" << endl;
	cin >> crap;
	weight = weight - crap;
	cout << name << " now weighs " << weight << "." << endl;
	system("pause");
}

void human::walk()
{
	cout << name << " went for a walk." << endl;
	system("pause");
}

void human::outputdescription()
{
	cout << "The human named " << name << " is " << age << ", weighs " << weight << " pounds, and is " << height << " feet tall.\n"
		<< "The human can eat, sleep, poop, and walk. How exciting." << endl;
	system("pause");
}
