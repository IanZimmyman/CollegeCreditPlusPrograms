'Ian Zimmerman
'Computer Programming 1
'Chapter 6 lab 4: Output files
Option Strict On
Option Explicit On
Imports System.IO

Module Module1

    'This program will write adress labels to a sequential file

    Sub Main()

        Dim file1 As StreamWriter

        'dim a variable called output as a StreamWriter and open the file h:\stuff.txt

        Dim output1 As StreamWriter
        output1 = New StreamWriter("h:\stuff.txt")

        'write an adress label for yourself to the file stuff.txt

        output1.WriteLine("Ian Zimmerman")
        output1.WriteLine("3000 Archwood Pl")
        output1.WriteLine("Cuyahoga Falls, OH 44221")
        output1.WriteLine("")

        'Close the file.

        output1.Close()

        'reopen stuff.txt for append. reuse the variable file1
        
        file1 = output1
        file1 = New StreamWriter("h:\stuff.txt", True)

        'Write an adress label for CFHS to the file. the adress is: 
        '   Cuyahoga Falls High School 2300 4th Street Cuyahoga Falls, OH 44221 

        file1.WriteLine("Cuyahoga Falls High School", True)
        file1.WriteLine("2300 4th Street", True)
        file1.WriteLine("Cuyahoga Falls, OH 44221", True)

        'close the file again

        file1.Close()

        Console.ReadKey()
    End Sub

End Module
