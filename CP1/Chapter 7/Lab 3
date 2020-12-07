'Ian Zimmerman
'Computer Programming 1
'Chapter 7 lab 3: Arrays of strings
Option Strict On
Option Explicit On
Module Module1
    'Main should input a sentence and display the first word alphabetically
    Sub Main()
        'Declare a string array and a string variable
        'Enter a sentence into the string variable. Be sure to include a 
        '   user prompt.
        'Use Split to seperate each word of the sentence into an element of the
        '    string array
        'Use sort to alplhabatize the words in the string array.
        'Display the word that is first alphabetically in the sentence 
        '   (hint its the first element in the string array).

        Dim jim() As String
        Dim stringy As String = "jim is an array"

        Console.Write("Please enter a setence to input into the array 'jim' ")
        stringy = Convert.ToString(Console.ReadLine)

        jim = stringy.Split(" "c)

        Array.Sort(jim)

        Console.WriteLine("The first word of the string alphabetically is " & jim(0))

        Console.ReadKey()
    End Sub

End Module
