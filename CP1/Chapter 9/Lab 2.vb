'Ian Zimmerman
'Computer Programming 1
'Chapter 9 lab 2: Parameters
Option Strict On
Option Explicit On

Module Module1
    'This program gets 2 numbers from the user. 
    '   then it then calls a sub that displays the sum
    '   product, difference and quotient of the two numbers.

    Sub Main()
        Dim num1 As Double
        Dim num2 As Double

        'fill num1 and num2 with user input

        Console.Write("Please enter a value for num1: ")
        num1 = Convert.ToDouble(Console.ReadLine())

        Console.Write("Please enter a value for num2: ")
        num2 = Convert.ToDouble(Console.ReadLine())

        'call your sub with num1 and num2 as parameters

        Call waffles(num1, num2)


    End Sub

    Sub waffles(ByVal num1 As Double, ByVal num2 As Double)
        'Write your sub here. It should take 2 doubles as parameters,
        '   and display the sum, product, difference and quotent.

        Dim sum, pro, dif, quo As Double

        sum = num1 + num2
        pro = num1 * num2
        dif = num1 - num2
        quo = num1 / num2

        Console.WriteLine("The sum of " & num1 & " and " & num2 & " is " & sum)
        Console.WriteLine("The product of " & num1 & " and " & num2 & " is " & pro)
        Console.WriteLine("The difference of " & num1 & " and " & num2 & " is " & dif)
        Console.WriteLine("The quotient of " & num1 & " and " & num2 & " is " & quo)
        Console.ReadLine()

    End Sub

End Module
