'Ian Zimmerman
'Computer Programming 1
'Chapter 9 lab 4: pass by reference parameters
Option Strict On
Option Explicit On
Module Module1
    'This program uses pass by refeerence paramerters in
    '   a sub to input 2 numbers and a second sub to square
    '   the two numbers. A third sub should use pass by value 
    '   paramarers to display 2 numbers

    Sub Main()
        Dim num1, num2 As Double


        'call your input sub (see below) with num1 and num2 as paramaters

        Call input(num1, num2)

        'call your square sub (see below) with num1 and num2 as paramaters

        Call square(num1, num2)

        'call your display sub (see below) with num1 and num2 as paramaters

        Call Display(num1, num2)

    End Sub

    'Write a sub that takes two numbers as pass by reference paramaters, 
    '   and fills them with user input.

    Sub input(ByRef n1 As Double, ByRef n2 As Double)

        Console.Write("Please input a value into num1: ")
        n1 = Convert.ToDouble(Console.ReadLine())

        Console.Write("Please input a value into num2: ")
        n2 = Convert.ToDouble(Console.ReadLine())

    End Sub

    'Write a sub that takes two numbers as pass by reference paramaters, 
    '   and squares their value.

    Sub square(ByRef n1 As Double, ByRef n2 As Double)

        n1 = n1 ^ 2

        n2 = n2 ^ 2

    End Sub

    'Write a sub that takes two numbers as pass by value paramaters, 
    '   and displays their values to the user.

    Sub display(ByVal n1 As Double, ByVal n2 As Double)

        Console.WriteLine("The new value of num1 is " & n1)

        Console.WriteLine("The new value of num2 is " & n2)

        Console.ReadLine()

    End Sub

End Module
