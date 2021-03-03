'Ian Zimmerman
'Computer Programming 1
'Chapter 6 lab 2: Message Boxes
Option Strict On
Option Explicit On

Imports System.Windows.Forms

Module Module1
    'Main should use message boxes to determine if the user and the writer of
    '   the program have the same first name.
    Sub Main()
        Dim result As DialogResult


        'Use a basic message box to tell the user your first name

        MessageBox.Show("My first name is Ian.")

        'Use a yes/no message box to ask if the user's first name is the same as yours.
        '   store the response in result.

        result = MessageBox.Show("Is that your first name too?", "???", MessageBoxButtons.YesNo)

        'Use result in an if then statement to tell the user that you do or dont have the 
        '   same first name.

        If result = DialogResult.No Then
            Console.WriteLine("We do not share a first name.")
        ElseIf result = DialogResult.Yes Then
            Console.WriteLine("We have the same first name.")
        End If

        Console.ReadKey()
    End Sub

End Module
