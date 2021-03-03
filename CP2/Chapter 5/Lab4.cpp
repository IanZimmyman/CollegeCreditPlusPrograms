// Ian Zimmerman
//Chapter 5 Lab 4: Sorting Arrays

#include "stdafx.h" //Microsoft wants this here, don't ask me.
#include <iostream>
using namespace std;

/* Write a program that fills an char array of size 10 with user input, 
	alphabetizes the letters and prints out every element in alphabetical order. 
*/

void swap (char & a, char & b);

int main()
{
	const int size = 10;
	char crab[size];
	int counter = 0, m, n;
	char input;

	while (counter < size)
	{
		cout << "Please input a char to slot " << counter << endl;
		cin >> input;
		crab[counter] = input;
		counter++;
	};

	for (m = 0; m < size; m++)
	{
		for (n = 0; n < size - 1; n++)
		{
			if (crab[n] > crab[n + 1])
				swap(crab[n], crab[n + 1]);
		}
	}

	counter = 0;
	while (counter < size)
	{
		cout << crab[counter] << " ";
		counter++;
	}
	cout << endl;
	
	system ("pause"); //pauses program before termination so you can see final results 
	return 0;
}

void swap(char & a, char & b)
{
	char lobster = a;
	a = b;
	b = lobster;
}
