'Ian Zimmerman
'Computer Programming 1
'Chapter 4 lab 1: Guess a Number

Option Strict On
Option Explicit On

Module Module1
    Sub Main()
        Dim x As Integer
        Console.Write("Please input a guess as an integer value: ")
        x = Convert.ToInt32(Console.ReadLine())

        If x = 42 Then
            Console.Write("Congratgulations! The value was " & x & "!")
        End If

        If x < 42 Then
            Console.Write("I'm sorry, but " & x & " is too small.")
        End If

        If x > 42 Then
            Console.Write("I'm sorry, but " & x & " is too large.")
        End If
        Console.ReadLine()

        Console.Write("Please enter another integer value to guess again: ")
        x = Convert.ToInt32(Console.ReadLine())
        If x = 42 Then
            Console.Write("Congratgulations! The value was " & x & "!")
        Else
            Console.Write("I'm sorry, " & x & " is not the correct value. The correct value was 42.")
        End If
        Console.ReadLine()

    End Sub

End Module
