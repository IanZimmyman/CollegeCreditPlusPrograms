'Ian Zimmerman
'Computer Programming 1
'Chapter 4 lab 4: Elseifs

Option Strict Off
Option Explicit On

Module Module1

    Sub Main()
        Dim x As Integer
        Console.Write("Please enter a value between 0 and 9999: ")
        x = Convert.ToInt32(Console.ReadLine())
        If x < 0 Then
            Console.WriteLine("That number is less than 0.")
            Console.ReadLine()
        ElseIf x >= 0 And x <= 9 Then
            Console.WriteLine("That number has one digit.")
            Console.ReadLine()
        ElseIf x >= 10 And x <= 99 Then
            Console.WriteLine("That number has two digits.")
            Console.ReadLine()
        ElseIf x >= 100 And x <= 999 Then
            Console.WriteLine("That number has three digits.")
            Console.ReadLine()
        ElseIf x >= 1000 And x <= 9999 Then
            Console.WriteLine("That number has four digits.")
            Console.ReadLine()
        Else
            If x > 9999 Then
                Console.WriteLine("That number is more than 9999.")
                Console.ReadLine()
            End If
        End If
    End Sub

End Module
