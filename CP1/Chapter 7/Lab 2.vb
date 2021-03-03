'Ian Zimmerman
'Computer Programming 1
'Chapter 7 lab 2: Array Methods
Option Strict On
Option Explicit On

Module Module1
    'This lab uses array methods to put elements in an array into assending
    '   (smallest to largest) or desending (largest to smallest) order and
    '   determine the nmber of elements in the array.
    Sub Main()
        ''Declare an integer array of size 9.
        ''Use a loop to fill the array with user input.
        'Use the sort method to put the array in assending order.
        'Display the array in assending order.
        'Use the reverse method to put the array in desending order.
        'Display the array in desending order.

        Dim gerry(8) As Integer
        Dim counter As Integer = 0

        For counter = 0 To 8 Step 1
            Console.Write("Please input an integer value into the array 'gerry' ")
            gerry(counter) = Convert.ToInt32(Console.ReadLine())
        Next

        Array.Sort(gerry)

        Console.Clear()

        Console.Write("The integers put in order are: ")
        For counter = 0 To 8 Step 1
            Console.Write(gerry(counter) & " ")
        Next

        Console.ReadKey()

        Array.Reverse(gerry)

        Console.Write("The integers reversed are: ")
        For counter = 0 To 8 Step 1
            Console.Write(gerry(counter) & " ")
        Next

        Console.ReadKey()

    End Sub

End Module
