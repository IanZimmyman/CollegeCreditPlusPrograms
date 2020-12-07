Module Module1
    'Ian Zimmerman
    'Mr. Johnson
    'CP1
    '15 April 2016
    Sub Main()

        'variables
        Dim field(5, 5) As String
        Dim row, column, grow, gcolumn As Integer
        Dim guesses As String
        Dim guess(1) As String
        Dim ships(5, 5) As String
        Dim shots As Integer = 0
        Dim hits As Integer = 0
        Dim valid As Boolean = True

        'everything in the main array is set to "O"
        For row = 0 To 5 Step 1
            For column = 0 To 5 Step 1
                field(row, column) = "O"
            Next column
        Next row

        Do Until hits = 3

            'displaying the grid
            For row = 0 To 5 Step 1
                For column = 0 To 5 Step 1
                    Console.Write(" " & field(row, column))
                Next column
                Console.WriteLine(" ")
            Next row

            'user guess
            Console.Write("Please input the coordinates of where you would like to guess in the format 'row column': ")
            guesses = Convert.ToString(Console.ReadLine())

            guess = guesses.Split(" "c)

            'error testing
            valid = True
            grow = Convert.ToInt32(guess(0))
            gcolumn = Convert.ToInt32(guess(1))
            If (grow > 5) Or (grow < 0) Then
                Console.WriteLine("Please enter a valid row.")
                valid = False
            ElseIf (gcolumn > 5) Or (gcolumn < 0) Then
                Console.WriteLine("Please enter a valid column.")
                valid = False
            End If

            'shooting
            If valid = True Then
                shots = shots + 1
                'ships are at (1, 4), (2, 1), and (4, 3)
                If (grow = 1 And gcolumn = 4) Or (grow = 2 And gcolumn = 1) Or (grow = 4 And gcolumn = 3) Then
                    'it hit
                    hits = hits + 1
                    field(grow, gcolumn) = "H"
                    Console.WriteLine("You hit a ship.")
                Else
                    'it missed
                    field(grow, gcolumn) = "M"
                    Console.WriteLine("You missed.")
                End If
            End If
            Console.ReadKey()
            Console.Clear()
        Loop

        'number of shots
        Console.Clear()
        Console.WriteLine("You destroyed all of the battleships in " & shots & " shots")

        Console.ReadKey()

    End Sub

End Module
