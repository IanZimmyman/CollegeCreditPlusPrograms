// Ian Zimmerman
#include "stdafx.h"//Microsoft wants this here, don't ask me.
#include <iostream>
using namespace std;

void opt1(int [], int size);
void opt2(int [][3], int row, int col);
void opt3(int [], int size);
void opt4(int [][3], int row, int col);
void opt5(int [], int size);
void opt6(int [][3], int row, int col);
void opt7(int [], int size);
	void swap1d(int & a, int & b);
void opt8(int [][3], int row, int col);
void opt9(int [], int size);
void opt10();

int main()
{
	int menu;
	const int size = 9;
	const int rsize = 3;
	const int csize = 3;
	int array1 [size], array2 [rsize][csize];
	do
	{
	system("CLS");
	cout << "Please enter the number of the option you want to perform\n"
		<< "1. Fill 1-D array with numbers\n"
		<< "2. Fill 2 - D array with numbers\n"
		<< "3. Print the numbers in the 1 - D array\n"
		<< "4. Print the numbers in the 2 - D array\n"
		<< "5. Find the average of the numbers in the 1 - D array\n"
		<< "6. Find the average of the numbers in the 2 - D array\n"
		<< "7. Find the median of the numbers in the 1 - D array\n"
		<< "8. Find the median of the numbers in the 2 - D array\n"
		<< "9. Find the mode of the numbers in the 1 - D array\n"
		<< "10. Quit\n";
	cin >> menu;

	switch (menu)
	{
	case 1: // calls the function that populates the 1d array
		opt1(array1, size);
		break;
	case 2: // calls the function that populates the 2d array
		opt2(array2, rsize, csize);
		break;
	case 3: // calls the function that prints the 1d array
		opt3(array1, size);
		break;
	case 4: // calls the function that prints the 2d array
		opt4(array2, rsize, csize);
		break;
	case 5: // calls the function that finds/displays the average of the numbers in the 1d array
		opt5(array1, size);
		break;
	case 6: // calls the function that finds/displays the average of the numbers in the 2d array
		opt6(array2, rsize, csize);
		break;
	case 7: // calls the function that finds/displays the median of the numbers in the 1d array
		opt7(array1, size);
		break;
	case 8: // calls the function that finds/displays the median of the numbers in the 2d array
		opt8(array2, rsize, csize);
		break;
	case 9: // calls the function that finds/displays the mode of the numbers in the 1d array
		opt9(array1, size);
		break;
	case 10: // calls the funtion that exits the program
		opt10();
		break;
	default: // tells the user that they're mentally challanged
		cout << "Enter something that is on the list!\n";
		break;
	}
	} while (menu != 10);
	system ("pause"); //pauses program before termination so you can see final results 
	return 0;
}

void opt1(int ar1 [], int s) // this function populates the 1d array
{
	int counter = 0;
	while (counter < s)
	{
		cout << "Please enter the value for spot " << counter << endl;
			cin >> ar1 [counter];
		counter++;
	}
}

void opt2(int ar2 [][3], int rs, int cs) // this function populates the 2d array
{
	int r = 0, c = 0;
	for (r = 0; r < rs; r++)
		for (c = 0; c < cs; c++)
		{
			cout << "Please enter the value for index " << r << ", " << c << endl;
				cin >> ar2 [r][c];
		}
}

void opt3(int ar1 [], int s) // this function prints the 1d array
{
	int counter = 0;
	for (counter = 0; counter < s; counter++)
		cout << ar1 [counter] << " ";
	cout << endl;
	system("pause");
}

void opt4(int ar2 [][3], int rs, int cs) // this function prints the 2d array
{
	int r = 0, c = 0;
	for (r = 0; r < rs; r++)
	{
		for (c = 0; c < cs; c++)
		{
			cout << ar2[r][c] << " ";
		}
		cout << endl;
	}
	system("pause");
}

void opt5(int ar1 [], int s) // this function finds/ displays the average of the 1d array
{
	int counter = 0, sum = 0;
	double avg;
	while (counter < s)
	{
		sum = sum + ar1[counter];
		counter++;
	}
	avg = sum / s;
	cout << "The average of the numbers in the 1D array is " << avg << endl;
	system("pause");
}

void opt6(int ar2 [][3], int rs, int cs) // this function finds/ displays the average of the 2d array
{
	int r = 0, c = 0, sum;
	double avg;
	for (r = 0; r < rs; r++)
	{
		for (c = 0; c < cs; c++)
		{
			sum = sum + ar2[r][c];
		}
	}
	avg = sum / (rs * cs);
	cout << "The average of the numbers in the 2D array is " << avg << endl;
	system("pause");
}

void opt7(int ar1 [], int s) // this function finds/displays the median of the 1d array
{
	int m, n;
	for (m = 0; m < s; m++)
	{
		for (n = 0; n < s - 1; n++)
		{
			if (ar1 [n] > ar1 [n + 1])
				swap1d(ar1 [n], ar1 [n + 1]);
		}
	}
	cout << "The median of the 1D array is " << ar1 [5] << endl; // hardcoding because size is a constant at 9
	system("pause");
}

	void swap1d(int & a, int & b) // this function swaps the numbers in the 1d array
	{
		int temp = a;
		a = b;
		b = temp;
	}

void opt8(int ar2 [][3], int rs, int cs) // this function finds/displays the median of the 2d array
{
	int r1, r2, c1, c2, temp;
	for (int r1 = 0; r1 < rs; r1++)
		for (int c1 = 0; c1 < cs; c1++)
			for (int r2 = 0; r2 < rs; r2++)
				for (int c2 = 0; c2 < cs; c2++)
					if (ar2 [r1][c1] < ar2[r2][c2])
					{
						temp = ar2[r1][c1];
						ar2[r1][c1] = ar2[r2][c2];
						ar2[r2][c2] = temp;
					}
	cout << "The median of the 2D array is " << ar2 [1][1] << endl; // hardcoding because rsize and csize are both constant at 3
	system("pause");
}

void opt9(int ar1[], int s) // this function finds/displays the mode of the 1d array
{
	int c1, c2, count, m, n, highcount = 0, highvalue;
	for (m = 0; m < s; m++)
	{
		for (n = 0; n < s - 1; n++)
		{
			if (ar1[n] > ar1[n + 1])
				swap1d(ar1[n], ar1[n + 1]);
		}
	}

	for (c1 = 0; c1 < s; c1++)
	{
		count = 0;
		for (c2 = 0; c2 < s; c2++)
			if (ar1 [c1] == ar1 [c2])
				count++;
		cout << ar1 [c1] << " occurs " << count << " times" << endl << endl;
		if (count > highcount)
		{
			highcount = count;
			highvalue = ar1 [c1];
		}
	}
	cout << "The mode of the 1D array is " << highvalue << ", which occurs " << highcount << " time(s)" << endl;
	system("pause");
}

void opt10() // this function closes the program
{
	exit(0);
}
