'Ian Zimmerman
'Computer Programming 1
'Chapter 6 lab 1: String Functions
Option Strict On
Option Explicit On
Module Module1

    'This program uses various string functions to accomplish a given task.

    Sub Main()
        Dim word1 As String = "abuzz"
        Dim word2 As String
        Dim word3 As String
        Dim location As Integer
        Dim size As Integer
        Dim counter As Integer

        'Use the Starts With string function to test if word1 starts with an a

        If word1.StartsWith("a") Then
            Console.WriteLine("word1 starts with a.")
        Else
            Console.WriteLine("word1 does not start with a.")
        End If

        'Use the Ends With string function to test if word1 starts with a z

        If word1.EndsWith("z") Then
            Console.WriteLine("word1 ends with z.")
        Else
            Console.WriteLine("word1 does not end with z.")
        End If

        'Use the Index Of string function to tell the user wether or not word1 has an e in it.

        location = word1.IndexOf("e")
        If location = -1 Then
            Console.WriteLine("word1 does not have an e in it.")
        Else
            Console.WriteLine("word1 has a e in it at index " & location)
        End If

        'Prompt the user to enter a word, and store it in word2.

        Console.Write("Please enter a word: ")
        word2 = Convert.ToString(Console.ReadLine())

        'Convert the value inputted for word2 into all capital letters, and store 
        '   the value in word3. Display word3.

        word3 = word2.ToUpper()
        Console.WriteLine(word3)


        'Prompt the user to enter a sentence, and store the value in word2

        Console.Write("Please enter a sentence: ")
        word2 = Convert.ToString(Console.ReadLine())

        'Use the Replace string function to change any instance of poop in 
        '   word2 to p***, and display the results.

        word3 = word2.Replace("poop", "p***")
        Console.WriteLine(word3)

        'Prompt the user to ener a word, and store it in word2.

        Console.Write("Please enter a Word: ")
        word2 = Convert.ToString(Console.ReadLine())

        'Use the substring and length string functions to remove the first and
        '   last letter from the word in word1, and store the value in word3. 
        '   Display word3.

        size = word1.Length
        word3 = word1.Substring(1, size - 2)
        Console.WriteLine(word3)

        'Prompt the user to enter a sentence, and store the value in word2

        Console.Write("Please enter a sentence: ")
        word2 = Convert.ToString(Console.ReadLine())

        'Use a for loop to check every element of the string to the element next to it.
        ' if they are the same, display the repeated letter.

        For counter = 0 To word2.Length Step 1
            If word2.Chars(counter) = word2.Chars(counter + 1) Then
                Console.WriteLine(word2.Chars(counter) & " apears in a series.")
            End If
        Next counter

        Console.ReadKey()
    End Sub

End Module
