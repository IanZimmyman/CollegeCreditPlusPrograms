Option Strict On
Option Explicit On
Imports System.Windows.Forms
Imports System.IO
Module Module1

    Sub Main()
        'variables
        Dim input1 As String = "waffle"
        Dim output1 As String = "pie"
        Dim length As Integer
        Dim output2 As DialogResult
        Dim today As DateTime
        Dim input3 As StreamReader
        Dim output3 As StreamWriter

        Do
            'when program is launched
            Console.Write("Please enter a sentence: ")
            input1 = Convert.ToString(Console.ReadLine())
            length = input1.Length
            input1 = input1.ToLower

            'when simon says date
            If input1.Equals("simon says date") Then
                today = DateTime.Today
                input1 = today.ToString("dddd MMMM d, yyyy")
                output2 = MessageBox.Show("Today is " & input1, "Simon", MessageBoxButtons.OK)
                Console.WriteLine("Press enter to continue")
                Console.ReadLine()

                'when simon says joke
            ElseIf input1.Equals("simon says joke") Then
                input3 = New StreamReader("H:\inputfile.txt")
                Do While input3.Peek <> -1
                    input1 = input3.ReadLine()
                    output2 = MessageBox.Show(input1, "Simon", MessageBoxButtons.OK)
                Loop
                Console.WriteLine("Press enter to continue")
                Console.ReadLine()

                'when simon says write
            ElseIf input1.Equals("simon says write") Then
                Console.Write("Please enter a sentence: ")
                input1 = Convert.ToString(Console.ReadLine)
                output3 = New StreamWriter("e:\outputfile.txt")
                output3.WriteLine(input1)
                output2 = MessageBox.Show("'" & input1 & "' has been writen to h:\outputfile.txt", "Simon", MessageBoxButtons.OK)
                Console.WriteLine("Press enter to continue")
                Console.ReadLine()

                'when simon says quit
            ElseIf input1.Equals("simon says quit") Then
                Console.WriteLine("Press enter to continue")
                Console.ReadLine()
                End

                'other simon says statement
            ElseIf input1.StartsWith("simon says") Then
                output1 = input1.Substring(11, (length - 11))
                output2 = MessageBox.Show(output1, "Simon", MessageBoxButtons.OK)
                Console.WriteLine("Press enter to continue")
                Console.ReadLine()

                'no simon says given
            Else
                output2 = MessageBox.Show("you didn't say simon says", "Simon", MessageBoxButtons.OK)
                Console.WriteLine("Press enter to continue")
                Console.ReadLine()
            End If
            Console.Clear()
        Loop
    End Sub

End Module
