// Ian Zimmerman
//Chapter 5 Lab 5: Searching Arrays

#include "stdafx.h"//Microsoft wants this here, don't ask me.
#include <iostream>
using namespace std;

/*  Write a program that inputs 10 numbers from the user into an integer array. 
		Then input a number from the user. If that number is in the array, tell the 
		user the index number. If not, tell the user the element is not found.    
*/



int main()
{
	const int size = 10;
	int orphans [size];
	int counter = 0;
	int search, location = size + 1;
	int flag = 0;

	while (counter < size)
	{
		cout << "Please input a number to slot " << counter << endl;
		cin >> orphans [counter];
			counter++;
	}

	cout << "Please input a number to find its spot in the array" << endl;
	cin >> search;
	

	counter = 0;

	for (counter = 0; counter < size; counter++)
		if (orphans[counter] == search)
		{
			flag = 1;
			cout << search << " was found at index " << counter << endl;
		}

	if (flag == 0)
		cout << "That number is not in the array" << endl;
	
	system ("pause"); //pauses program before termination so you can see final results 
	return 0;
}
