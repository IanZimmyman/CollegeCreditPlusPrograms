'Ian Zimmerman
'Computer Programming 1
'Chapter 9 lab 1: basic sub methods
Option Strict On
Option Explicit On


Module Module1
    'This program should use a sub method to display 5 facts about yourself
    Sub Main()
        'Call the function that displays 5 facts about yourself to the screen

        Call facts()

    End Sub

    Sub facts()
        'Create a Sub that displays 5 facts about yourself to the screen

        Console.WriteLine("My favorite food is pizza")
        Console.WriteLine("I have a peanut allergy")
        Console.WriteLine("I am also allergic to apples")
        Console.WriteLine("I like pie more than cake")
        Console.WriteLine("I have a bullet-proof phone")
        Console.ReadLine()

    End Sub

End Module
