'Ian Zimmerman
'Computer Programming 1
'Chapter 7 lab 5: Searching Arrays
Option Strict On
Option Explicit On

Module Module1
    'While playing bingo, you need to use the bathroom and you miss 10 numbers.
    '   You had asked your friend to keep track of your card, but instead he put 
    '   them into an array. This program will search the list for the numbers on 
    '   your card to see if you won.
    Sub Main()
        'You need letter O62 to win! write a search that displays Bingo!
        '   if that string is in the array board.
        'Whenever the caller yells out B4, you yell BEFORE WHAT? search the array 
        '   and display if you have missed your chance for the joke this game, 
        '   or if B4 has not been called yet and you can still make your joke.

        Dim found As Boolean = False
        Dim counter As Integer = 0
        Dim value As String = "O62"
        Dim board(9) As String
        Dim called As String = "B4 B10 I23 I29 N35 N41 G50 G60 O70 O71"

        board = called.Split(" "c)

        For counter = 0 To board.Length - 1 Step 1
            If board(counter) = value Then
                found = True
            End If
        Next

        If found = True Then
            Console.WriteLine("You have a bingo.")
        ElseIf found = False Then
            Console.WriteLine("You don't have a bingo.")
        End If

        value = "B4"
        found = False

        For counter = 0 To board.Length - 1 Step 1
            If board(counter) = value Then
                found = True
            End If
        Next

        If found = True Then
            Console.WriteLine("You missed your chance to use your joke.")
        ElseIf found = False Then
            Console.WriteLine("You haven't missed your chance yet.")
        End If

        Console.ReadKey()

    End Sub

End Module
