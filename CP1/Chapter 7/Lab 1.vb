'Ian Zimmerman
'Computer Programming 1
'Chapter 7 lab 1: Arrays
Option Strict Off
Option Explicit On


Module Module1

    'This program will declare, fill, change, and display 
    '   the elements of an array.

    Sub Main()

        'Declare an integer array of size 6
        'fill the array with user input
        'Use a loop to add 3 to each element of the array
        'Use a second loop to double the value of every element in the array
        'Display the new values of the array.

        Dim array1(5) As Integer
        Dim counter As Integer = 0

        For counter = 0 To 5 Step 1
            array1(counter) = Console.ReadLine()
        Next

        Console.Clear()

        For counter = 0 To 5 Step 1
            array1(counter) += 3
        Next

        For counter = 0 To 5 Step 1
            array1(counter) *= 2
        Next

        For counter = 0 To 5 Step 1
            Console.WriteLine(array1(counter))
        Next

        Console.ReadKey()

    End Sub

End Module
