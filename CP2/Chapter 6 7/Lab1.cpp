// Ian Zimmerman
//Chapter 6/7 Lab 1: Classes

#include "stdafx.h"//Microsoft wants this here, don't ask me.
#include <iostream>
using namespace std;

/* Create a class car. Choose 5 properties of a car that should be represented 
	in your class. Then declare a car, fill it with user input, and display the 
	information about the car. 
  */


int main()
{
	class car
	{
		public:
				int wheels;
				int windows;
				int doors;
				int seats;
				int beds;
	};
	
	car camper;
		
	cout << "How many wheels does your camper have?" << endl;
		cin >> camper.wheels;
	cout << "How many windows does your camper have?" << endl;
		cin >> camper.windows;
	cout << "How many doors does your camper have?" << endl;
		cin >> camper.doors;
	cout << "How many seats does your camper have?" << endl;
		cin >> camper.seats;
	cout << "How many beds does your camper have?" << endl << endl;
		cin >> camper.beds;
	
	cout << "Your camper has:" << endl
		 << camper.wheels << " wheels" << endl
		 << camper.windows << " windows" << endl
		 << camper.doors << " doors" << endl
		 << camper.seats << " seats" << endl
		 << camper.beds << " beds" << endl;
	
	system ("pause"); //pauses program before termination so you can see final results 
	return 0;
}
