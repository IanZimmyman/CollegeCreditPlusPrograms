'Ian Zimmerman
'Computer Programming 1
'Chapter 5 lab 1: Laberenth

Option Strict On
Option Explicit On

Module Module1
    'Sphinx wants to take a break from  guarding the entrance to the Greek city of Thebes.
    '   Since everyone knows the answer to the Sphinx's riddle is (spoiler alert) man, you 
    '   must write a program that forces the user to answer 4 questions, or be trapped forever!
    '   The four questions are the year day and month you were born in, and how many licks does 
    '   it take to get to the Toosie roll center of a toosie pop (three).

    Sub Main()
        'Declare an integer value that will store the answer to the questions, and be used in the 
        '   loop conditions
        Dim ans As Integer
        'Write a do while that asks the user the month you were born until their answer is correct.
        ans = 0
        Do While ans <> 11
            Console.Write("What month was I born in? ")
            ans = Convert.ToInt32(Console.ReadLine())
        Loop
        'Write a do until that asks the user the day you were born until their answer is correct.
        ans = 0
        Do Until ans = 9
            Console.Write("What day was I born on? ")
            ans = Convert.ToInt32(Console.ReadLine())
        Loop
        'Write a loop while that asks the user the year you were born until their answer is correct.
        Do
            Console.Write("What year was I born in? ")
            ans = Convert.ToInt32(Console.ReadLine())
        Loop While ans <> 2000
        'Write a loop until that asks the user how many licks does it take to get to the tootsie
        '  roll center of a tootsie pop, until they answer 3
        Do
            Console.Write("How many licks does it take to get to the tootsie roll center of a tootsie pop? ")
            ans = Convert.ToInt32(Console.ReadLine())
        Loop Until ans = 3
        Console.ReadLine()
    End Sub

End Module
