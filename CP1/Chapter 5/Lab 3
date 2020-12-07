'Ian Zimmerman
'Computer Programming 1
'Chapter 5 lab 3: looping menu
Option Strict On
Option Explicit On


Module Module1
    'This lab uses a switch statement nested inside of a loop to implement a menu that 
    '   allows the user to keep selecting items until they choose to quit.
    Sub Main()
        'declare a choice variable as integer
        Dim choice As Integer
        'begin a loop that keeps running until the choice variable is 5 (quit)
        choice = 0
        Do
            '   display a menu of 4 items and a fifth quit choice
            Console.WriteLine("Please choose an item")
            Console.WriteLine("1.) Pizza")
            Console.WriteLine("2.) Waffle")
            Console.WriteLine("3.) Potato")
            Console.WriteLine("4.) Coffee")
            Console.WriteLine("5.) Quit")
            choice = Convert.ToInt32(Console.ReadLine())
            '   use a select case to list the price of the item selected, or goodbye if
            '       quit is chosen. case else should state invalid entry
            Select Case choice
                Case Is = 1
                    Console.Write("$1.75 per slice")
                Case Is = 2
                    Console.Write("$0.50 per waffle")
                Case Is = 3
                    Console.Write("$0.50 per potato")
                Case Is = 4
                    Console.Write("$1.00 per cup")
                Case Is = 5
                    Console.Write("Goodbye")
                    End
                Case Else
                    Console.Write("That entry is invalid")
            End Select
            Console.ReadLine()
            Console.Clear()
            'close your loop structure
        Loop Until choice = 5
    End Sub

End Module
