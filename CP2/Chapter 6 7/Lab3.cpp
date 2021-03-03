// Ian Zimmerman
//Chapter 6/7 Lab 3: Member Functions

#include "stdafx.h"//Microsoft wants this here, don't ask me.
#include <iostream>
using namespace std;

/* Create a class called rectangle. It should have private variables for length, 
	width, perimeter and area. It should have an input function that inputs 
	length and width, a calculate function that calculates perimeter and area, 
	and a print function that displays all 4 values. In main, declare two rectangles,
	then call the input calculate and print function for each of the rectangles.



  */

class rectangle
{
	public:
		void length();
		void width();
		void calculate();
		void print();
	private:
		int len, wid, area, perim;
};

int main()
{
	rectangle a, b;

	a.length();
	a.width();
	b.length();
	b.width();
	a.calculate();
	b.calculate();
	a.print();
	b.print();
		
	system ("pause"); //pauses program before termination so you can see final results 
	return 0;
}

void rectangle::length()
{
	cout << "How long is your rectangle?" << endl;
	cin >> len;
}

void rectangle::width()
{
	cout << "How wide is your rectangle?" << endl;
	cin >> wid;
}

void rectangle::calculate()
{
	area = len * wid;
	perim = (2 * len) + (2 * wid);
}

void rectangle::print()
{
	cout << "Length is " << len << " and width is " << wid << endl;
	cout << "Area is " << area << " and the perimeter is " << perim << endl;
	system("pause");
}
