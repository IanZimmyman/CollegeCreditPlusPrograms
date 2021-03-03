// Ian Zimmerman
//Chapter 6/7 Lab 5: Class Arrays

#include "stdafx.h"//Microsoft wants this here, don't ask me.
#include <iostream>
using namespace std;

/* Use the following class to accomplish the following task: create an array of 
	5 students, fill each with user input, then sort them from least to greatest
	intelligence, using GPA. Display the age of the students in order of intelligence
	to determine if smarter is wiser! Although main will be useless in this task, it does
	deminstraite how to interact with the object.
  */
class student
{	public:
		student(): age(14),GPA(3.4)
		{}
		student (int a, double g)
		{	age = a;
			GPA = g;
		}
		student (const  student & bob)
		{	age=bob.age;
			GPA = bob.GPA;
		}
		void set_age(int a)
		{	age = a;
		}
		void set_GPA(double g)
		{	GPA = g;
		}
		double get_GPA ()
		{	return GPA;
		}
		int get_age()
		{	return age;
		}
		int smarter (const  student & bob);
		int older(const  student & bob);
		void swap (student &, student &);
	private:
		int age;
		double GPA;



};

int main()
{	
	/*student bob (17, 4.2);
	student phil (bob);
	phil.set_GPA(.75);
	if (bob.smarter(phil) == 1)
		cout<<"Bob is smarter\n";
	else
		cout<<"Phil is smarter";

	cout<<"Bob's GPA is: "<<bob.get_GPA()<<" Phil's GPA is: "<<phil.get_GPA()<<endl;
	cout<<"now lets swap!\n";
	swap (bob,phil);
	cout<<"Bob's GPA is: "<<bob.get_GPA()<<" Phil's GPA is: "<<phil.get_GPA()<<endl;*/

	student dummies[5];
	int c1 = 0, c2, c3, age;
	double smartest, gpa;

	const int size = 5;
	while (c1 < 5)
	{
		cout << "Please enter the age for student " << c1 << endl;
		cin >> age;
		cout << "Please enter the gpa for student " << c1 << endl;
		cin >> gpa;
		
		dummies[c1] = student(age, gpa);
		c1++;
	}

	for (c2 = 0; c2 < size; c2++)
		for (c3 = 0; c3 < size - 1; c3++)
			if (dummies[c3].smarter(dummies[c3 + 1]) == 1)
				swap(dummies[c3], dummies[c3 + 1]);

	smartest = dummies[4].get_GPA();

	c1 = size - 1;
	while (c1 >= 0)
	{
		cout << "Student " << c1 << "'s gpa: " << dummies[c1].get_GPA() << "\tage: " << dummies[c1].get_age() << endl;
		c1--;
	}
	
	system ("pause"); //pauses program before termination so you can see final results 
	return 0;
}

int student::smarter (const student & bob)
{	if (GPA > bob.GPA)
		return 1;
	else
		return 0;

}
int student::older(const  student & bob)
{	if (age > bob.age)
		return 1;
	else
		return 0;

}
void swap (student & a, student & b)
{	student temp;
	temp.set_age (a.get_age());
	temp.set_GPA (a.get_GPA());
	a.set_age (b.get_age());
	a.set_GPA (b.get_GPA());
	b.set_age (temp.get_age());
	b.set_GPA (temp.get_GPA());


}
