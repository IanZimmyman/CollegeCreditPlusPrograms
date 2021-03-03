'Ian Zimmerman
'Computer Programming 1
'Chapter 5 lab 2: sum of numbers

Option Strict Off
Option Explicit On

Module Module1
    ' Legend has it when the famous mathematician Johann Carl Friedrich Gauss was in grade school,
    '   his teacher gave him a busy work assignmnet of finding the sum of the numbers from 1-100.
    '   he immediatly gave the answer 5050, because the sum of the numbers from 1-n is n*(n+1)/2.
    '   This lab is going to verify his discovery by using a for loop and the formula.
    Sub Main()
        'declare an integer variable that will be used as a counter variable.
        Dim counter As Integer
        'declare n as a constant integer with value 100
        Dim n As Integer = 100
        'declare two more integer variables, sum1 and sum2 and set both to 0
        Dim sum1 As Integer = 0
        Dim sum2 As Integer = 0
        'create a for loop that goes from 1-n, and adds the counter variable to sum1 each time
        '   through the loop
        For counter = 1 To n Step 1
            sum1 = sum1 + counter
        Next counter
        'calculate sum2 using the formula n*(n+1)/2
        sum2 = n * (n + 1) / 2
        'display sum1 and sum2
        Console.WriteLine("sum1 = " & sum1)
        Console.WriteLine("sum2 = " & sum2)
        Console.ReadLine()
    End Sub
End Module
