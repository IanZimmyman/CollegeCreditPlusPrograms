'Ian Zimmerman
'Computer Programming 1
'Chapter 4 lab 2: Nested if statements

Option Strict On
Option Explicit On

Module Module1

    '                                                   Yes - square
    '                                                  /
    '                      Yes-- are the angles equal < 
    '                     /                            \
    '                    /                              No - Rhombus
    'are the sides equal<
    '                    \                             Yes - Rectangle
    '                     \                          /   
    '                      No--are the angles equal <
    '                                                \
    '                                                  No - Parallelogram

    Sub Main()

        Dim sides, angles As Boolean

        Console.Write("True or False: The sides of the parallelogram equal. ")
        sides = Convert.ToBoolean(Console.ReadLine())

        If sides Then

            Console.Write("True or False: The angles of the parallelogram equal. ")
            angles = Convert.ToBoolean(Console.ReadLine())

            If angles Then
                Console.WriteLine("The parallelogram is a square.")
            Else

                Console.WriteLine("The parallelogram is a rhombus.")

            End If

        Else

            Console.Write("True or False: The angles of the parallelogram equal. ")
            angles = Convert.ToBoolean(Console.ReadLine())

            If angles Then
                Console.WriteLine("The parallelogram is a rectangle.")
            Else
                Console.WriteLine("The parallelogram is a special parallelogram.")
            End If

        End If

        Console.ReadKey()

    End Sub

End Module
