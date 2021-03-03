
'Ian Zimmerman
'Computer Programming 1
'Chapter 9 lab 3: Retrun values
Option Strict On
Option Explicit On
Module Module1
    'This program calculates the amount of gas needed to 
    '   travel a given number of miles on the highway or
    '   in the city.
    Sub Main()
        Dim miles As Double
        Dim city As Double
        Dim high As Double

        ' input the number of miles traveled from the user
        '   and store it in the variable miles.

        Console.Write("How many miles were traveled?: ")
        miles = Convert.ToDouble(Console.ReadLine())

        'Call your function with miles as the first parameter
        '   and 24 as your second parameter (MPG in the city).

        city = mileage(miles, 24)

        'Display the number of gallons of gas needed to complete
        '   the trip in the city.

        Console.WriteLine(city & " gallons used in the city")

        'Call your function with miles as the first parameter
        '   and 32 as your second parameter (MPG on the highway).

        high = mileage(miles, 32)

        'Display the number of gallons of gas needed to complete
        '   the trip on the highway.

        Console.WriteLine(high & " gallons used on the highway")
        Console.ReadLine()
    End Sub

    'Write a function that takes 2 numbers as parameters,
    '   one is the distance a person has traveled, and the
    '   other is the miles per gallon the person's car gets.
    '   Calculate the amount of gas used, and return it.

    Function mileage(ByVal dist As Double, ByVal mpg As Double) As Double

        'The formula for calculating the amount of gas used is:
        '   miles diriven / miles per gallon

        dist = dist / mpg

        Return dist
    End Function

End Module
