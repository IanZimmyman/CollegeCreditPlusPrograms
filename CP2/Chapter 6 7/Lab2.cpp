// Ian Zimmerman
//Chapter 6/7 Lab 2: Accessors and Mutators/Modifiers

#include "stdafx.h"//Microsoft wants this here, don't ask me.
#include <iostream>
using namespace std;

/*		Create a class called disk, with private variables for size in Megs and 
	number of files. Write an assessor and mutator/modifier function for each variable. 
	All functions should be inline.
		In main, declare two disks, input information for 
	the properties of the disks, and set those properties using the mutator/modifier 
	functions. Then use the assessor to determine which disk is larger, and display the 
	information about the larger disk.  

  */
	class disk
	{
	public:
		void setsize(int s)
		{
			if (s > 0)
				size = s;
			else
				cout << "Enter a valid size moron" << endl;
		}
		
		int getsize()
		{
			return size;
		}
		
		void setfiles(int s)
		{
			if (s >= 0)
				files = s;
			else
				cout << "Enter a valid amount moron" << endl;
		}
		
		int getfiles()
		{
			return files;
		}

	private:
		int size, files;
	};


int main()
{
	disk mine, yours;
	mine.setsize(3000);
	mine.setfiles(15);
	yours.setsize(2999);
	yours.setfiles(18);

	if (mine.getsize() > yours.getsize())
	{
		cout << "Mine is bigger than yours" << endl
			<< "My disk size is " << mine.getsize() << endl
			<< "My disk has " << mine.getfiles() << " files" << endl;
	}
	else
	{
		cout << "I guess we can't all be born lucky" << endl
			<< "Your disk size is " << yours.getsize() << endl
			<< "Your disk has " << yours.getfiles() << " files" << endl;
	}
	
	system ("pause"); //pauses program before termination so you can see final results 
	return 0;
}


