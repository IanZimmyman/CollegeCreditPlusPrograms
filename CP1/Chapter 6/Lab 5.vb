'Ian Zimmerman
'Computer Programming 1
'Chapter 6 lab 5: input files
Option Strict On
Option Explicit On
Imports System.IO


Module Module1

    'This program reads the Gettysburg Address from an input sequential file, and 
    '   displays the text on to the screen.

    Sub Main()

        'Before writing the code for the lab, create a text file called speech.txt on the default 
        '   directory of your H drive. Then find a copy of the Gettysburg Address online and 
        '   copy paste the text of the speech into the text file.

        'dim file1 as a StreamReader, and open h:\speech.txt

        Dim file1 As StreamReader
        file1 = New StreamReader("h:\speech.txt")

        'dim a string variable for use in inputting the text of the speech

        Dim temp As String

        'use a loop and inputfile.peak to read each line of the file into the string variable,
        '   then display the line to the screen.

        Do Until file1.Peek <> -1
            temp = file1.ReadLine()
            Console.WriteLine(temp)
        Loop

        Console.ReadKey()

    End Sub

End Module
