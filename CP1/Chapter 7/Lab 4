'Ian Zimmerman
'Computer Programming 1
'Chapter 7 lab 4: Multi-Dimensional Arrays
Option Strict On
Option Explicit On

Module Module1
    'Main should declare, fill and display a 2-D array
    Sub Main()
        'Declare a 2-D array with 3 rows and 2 columns
        'Fill the 2-D array with user input. include the row
        '   and column in the user prompt
        'Display the 2-D array as rows and columns over multiple lines.

        Dim row, column As Integer
        Dim jeff(2, 1) As Integer

        For row = 0 To 2 Step 1
            For column = 0 To 1 Step 1
                Console.Write("Please enter a value into the array for element (" & row & "," & column & "): ")
                jeff(row, column) = Convert.ToInt32(Console.ReadLine())
            Next column
        Next row

        Console.WriteLine(" ")

        For row = 0 To 2 Step 1
            For column = 0 To 1 Step 1
                Console.Write(" " & jeff(row, column))
            Next
            Console.WriteLine(" ")
        Next
        Console.ReadLine()

    End Sub

End Module
