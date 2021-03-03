// Ian Zimmerman
//Chapter 6/7 Lab 6: Vectors

#include "stdafx.h"//Microsoft wants this here, don't ask me.
#include <iostream>
#include <vector>
using namespace std;

/* Declare a vector of chars. Display the size  (should be 0) and capacity of the vector. 
	Double the current capacity of the vector.	Then prompt the user to enter values 
	until q is entered. Display the size, capacity and contents of the vector. 
  */


int main()
{
	vector <char> letters;
	cout << letters.size() << " " << letters.capacity() << endl;
	cout << "Enter letters into the array. Type q to quit." << endl;
	char temp = 'a';

	while (temp != 'q')
	{
		cout << "Enter a letter" << endl;
		cin >> temp;
		if (temp != 'q')
			letters.push_back(temp);
	}
	letters.reserve(letters.size() * 2);

	int counter;
	for (counter = 0; counter < letters.size(); counter++)
		cout << letters[counter] << " ";
	cout << endl;
	cout << letters.size() << " " << letters.capacity() << endl;
	
	system ("pause"); //pauses program before termination so you can see final results 
	return 0;
}




