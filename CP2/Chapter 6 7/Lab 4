// Ian Zimmerman
//Chapter 6/7 Lab 4: Constructors

#include "stdafx.h"//Microsoft wants this here, don't ask me.
#include <iostream>
using namespace std;

/* Create a class called book. It should contain private variables for the number
	of pages and the number of chapters. Write a member function that prints 
	out both items of information. Write 3 constructors, a default, a copy and a 
	parameter constructor. Create 3 books, using each of the three constructors,
	and use the print function to display the contents of the 3 books. Then recall
	the constructors explicitly to change the value of the three books.
  */

class book
{
	public:

		book()
		{
			pages = 0;
			chapters = 0;
		}

		book(int p, int c) : pages(p), chapters(c)
		{
			if (pages < 0)
			{
				cout << "Invalid number of pages" << endl;
				exit(1);
			}

			if (chapters < 0)
			{
				cout << "Invalid number of chapters" << endl;
				exit(1);
			}
		}

		book(const book & b)
		{
			pages = b.pages;
			chapters = b.chapters;
		}

		void printpages()
		{
			cout << "There are " << pages << " pages" << endl;
		}

		void printchapters()
		{
			cout << "There are " << chapters << " chapters" << endl;
		}

	private:
		int pages, chapters;
};

int main()
{
	book meinkampf;
	book manifesto(75, 10);
	book thebible2(manifesto);

	cout << "Mein Kampf" << endl;
	meinkampf.printpages();
	meinkampf.printchapters();
	cout << endl;

	cout << "Communist Manifesto" << endl;
	manifesto.printpages();
	manifesto.printchapters();
	cout << endl;

	cout << "The Bible 2: The Return of Marx" << endl;
	thebible2.printpages();
	thebible2.printchapters();
	cout << endl;
	
	manifesto = book();
	meinkampf = book(680, 86);
	thebible2 = book(meinkampf);

	cout << "Mein Kampf 2" << endl;
	meinkampf.printpages();
	meinkampf.printchapters();
	cout << endl;

	cout << "Communist Manifesto 2" << endl;
	manifesto.printpages();
	manifesto.printchapters();
	cout << endl;

	cout << "The Bible 3: The Return of Mein Fuhrer" << endl;
	thebible2.printpages();
	thebible2.printchapters();
	cout << endl;

	system ("pause"); //pauses program before termination so you can see final results 
	return 0;
}



