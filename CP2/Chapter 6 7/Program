// Ian Zimmerman
// Chapter 6/7 Program

#include "stdafx.h"//Microsoft wants this here, don't ask me.
#include <iostream>
#include <string>
#include <cmath>
using namespace std;

class vectors
{
public:
	vectors() //default constructor
	{
		x = 0;
		y = 0;
		magnitude = 0.0;
		direction = "";
		angle = 0.0;
	}

	vectors(int x1, int y1) :x(x1), y(y1) //Constructor
	{
		magnitude = 0.0;
		direction = "";
		angle = 0.0;
	}

	void translate_vector(int, int);
	void set_direction();

	void calculate_magnitude()
	{
		magnitude = sqrt(pow(x,2) + pow(y,2));
		cout << "The magnitude of vector <" << x << "," << y << "> is " << magnitude << endl;
	}

	void set_x()
	{
		cout << "Enter the X component of the vector" << endl;
		cin >> x;
	}
	int get_x()
	{
		return x;
	}
	void set_y()
	{
		cout << "Enter the Y component of the vector" << endl;
		cin >> y;
	}
	int get_y()
	{
		return y;
	}
	void display_vector()
	{
		cout << "<" << x << "," << y << ">\tMagnitude: " << magnitude << "\tDirection: " << angle << direction << endl;
	}

private:
	int x;
	int y;
	double magnitude;
	double angle;
	string direction;

};

void add_vectors(vectors v1, vectors v2); //prototype for non-member function
void enter_points(int & x1, int & y1);

int main()
{
	vectors victor(3, 4);
	vectors victoria(5, 12);
	int point_x, point_y;
	int response = 0;

	while (response != 7)
	{
		cout << "1. Fill vectors\n"
			<< "2. Display vectors\n"
			<< "3. Add vectors\n"
			<< "4. Perform a translation using the vectors\n"
			<< "5. Find magnitude of vectors\n"
			<< "6. Find the directon of the vectors\n"
			<< "7. Quit" << endl;

		cout << endl << "Please choose an option:" << endl;
		cin >> response;

		switch (response)
		{
		case 1:
			cout << "Resetting Victor" << endl;
			victor = vectors(0, 0);
			victor.set_x();
			victor.set_y();
			cout << "Resetting Victoria" << endl;
			victoria = vectors(0, 0);
			victoria.set_x();
			victoria.set_y();
			break;

		case 2:
			cout << "Victor's Details" << endl;
			victor.calculate_magnitude();
			victor.set_direction();
			victor.display_vector();
			cout << "Victoria's Details" << endl;
			victoria.calculate_magnitude();
			victoria.set_direction();
			victoria.display_vector();
			system("pause");
			break;

		case 3:
			add_vectors(victor, victoria);
			break;

		case 4:
			enter_points(point_x, point_y);
			victor.translate_vector(point_x, point_y);
			victoria.translate_vector(point_x, point_y);
			system("pause");
			break;

		case 5:
			victor.calculate_magnitude();
			victoria.calculate_magnitude();
			system("pause");
			break;

		case 6:
			victor.set_direction();
			victoria.set_direction();
			system("pause");
			break;

		case 7:
			cout << "Thanks for visiting" << endl;
			system("pause");
			exit(0);
			break;

		default:
			cout << "Maybe next time you can enter a valid option!" << endl;
			system("pause");
			break;
		}

		system("CLS");
	};

	system("pause"); //pauses program before termination so you can see final results 
	return 0;
}

void add_vectors(vectors v1, vectors v2)
{
	int a, b;
	a = v1.get_x() + v2.get_x();
	b = v1.get_y() + v2.get_y();
	cout << "Adding the vectors produces the following:" << endl;
	cout << "<" << v1.get_x() << "+" << v2.get_x() << " , "
		<< v1.get_y() << "+" << v2.get_y() << ">" << " = <"
		<< a << "," << b << ">" << endl;
	system("pause");
}

void vectors::translate_vector(int x1, int y1)
{
	int a, b;
	a = x + x1;
	b = y + y1;
	cout << "(" << x1 << "+" << x << " , " << y1 << "+" << y << ") -> (" << a << "," << b << ")" << endl;
}

void vectors::set_direction()
{
	double ang = 0.0, temp = 0.0;
	string dir = "";

	// static_cast the x/y as doubles so that decimals can be calculated
	ang = abs(static_cast <double> (y) / static_cast <double> (x));

	// take the ArcTangent and convert from rads to degrees
	angle = atan(ang) * 180 / 3.14;

	if (x == 0 && y > 0)
		dir = " deg north";
	else if (x == 0 && y < 0)
		dir = " deg south";
	else if (x > 0 && y == 0)
		dir = " deg east";
	else if (x < 0 && y == 0)
		dir = " deg west";
	else if (x > 0 && y > 0)
		dir = " deg north of east";
	else if (x > 0 && y < 0)
		dir = " deg south of east";
	else if (x < 0 && y < 0)
		dir = " deg south of west";
	else
		dir = " deg north of west";

	direction = dir;

	cout << "Direction for vector <" << x << "," << y << "> is " << angle << direction << endl;
}


void enter_points(int & x1, int & y1)
{
	cout << "Enter the X value" << endl;
	cin >> x1;
	cout << "Enter the Y value" << endl;
	cin >> y1;
}
