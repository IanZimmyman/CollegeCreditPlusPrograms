// Ian Zimmerman
// Take Home Exam 2

#include "stdafx.h"//Microsoft wants this here, don't ask me.
#include <iostream>
#include <ctime>
#include <cstdlib>
using namespace std;

void print_array(char[][20], int row, int col);
void fill_array(char[][20], int row, int col);
void flip_array(char[][20], int row, int col);

int main()
{
	const int size = 20; // sets a constant for the size of the array in both dimensional directions
	char board[size][size]; // defines the array

	srand(time(NULL)); // randomizes the rand seed

	// calls the function that fills the original array
	fill_array(board, size, size);

	// anounces and calls the function that prints the original array
	cout << "Initial Array" << endl;
	print_array(board, size, size);


	// calls the function that flips the original array
	flip_array(board, size, size);

	// anounces and calls the function that prints the flipped array
	cout << endl << "Flipped Array" << endl;
	print_array(board, size, size);

	system("pause");
	return 0;
}

void print_array(char arr[][20], int row, int col) //prints the arrays
{
	int r, c;

	for (r = 0; r < row; r++)
	{
		for (c = 0; c < col; c++)
			cout << arr[r][c];
		cout << endl;
	}
}

void fill_array(char arr[][20], int row, int col) // fills the arrays
{
	int r, c, temp;

	for (r = 0; r < row; r++)
		for (c = 0; c < col; c++)
		{
			temp = rand() % (1 - 0 + 1) + 0; // only possibilities are 0 and 1, making it 50% either way
			if (temp == 0)
				arr[r][c] = 'O';
			else
				arr[r][c] = 'X';
		}
}

void flip_array(char arr[][20], int row, int col) //flips the array
{
	int r, c;
	char ctemp;

	for (r = 0; r < row; r++)
		for (c = 0; c < col / 2; c++) // dividing by 2 to split the array columns in half
		{
			ctemp = arr[r][c];
			arr[r][c] = arr[r][col - c - 1]; // pairs 0,19; 1,18; etc...
			arr[r][col - c - 1] = ctemp;
		}
}
