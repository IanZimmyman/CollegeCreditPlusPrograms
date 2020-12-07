'Ian Zimmerman
'Computer Programming 1
'Chapter 4 lab 3: Logical Operators

Option Strict On
Option Explicit On

Module Module1
    Sub Main()

        Dim x, y As Integer

        Console.Write("Please input an integer value that is either equal to 0 or 1: ")
        x = Convert.ToInt32(Console.ReadLine())

        Console.Write("Please input another integer value that is either equal to 0 or 1: ")
        y = Convert.ToInt32(Console.ReadLine())

        If x = 1 Or x = 0 Then

            If x = 1 And y = 1 Then
                Console.WriteLine("1 + 1 = 10")
            End If

            If x = 1 Xor y = 1 Then
                Console.WriteLine(x & " + " & y & " = 1")
            End If

            If x = 0 And y = 0 Then
                Console.WriteLine("0 + 0 = 0")
            End If

            If (y < 0) Or (y > 1) Then
                Console.Write("The value entered is invalid")
                Console.ReadLine()
                End
            End If

        Else

            Console.Write("The value entered is invalid")
            Console.ReadLine()
            End

        End If

        Console.ReadLine()

    End Sub

End Module
