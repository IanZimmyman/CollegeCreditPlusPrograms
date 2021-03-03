'Ian Zimmerman
'Mr. Johnson
'CP1
'18 February 2016
Option Strict Off
Option Explicit On
Module Module1

    Sub Main()
        'Integers
        Dim choice As Integer = 0
        Dim counter As Integer = 0
        'Double
        Dim ans As Double = 0
        Dim x As Double = 0
        Dim facx As Double = 0
        Dim avg As Double = 0
        Dim n As Double = 0
        Dim facn As Double = 0
        Dim r As Double = 0
        Dim facr As Double = 0

        Do
            'menu
            Console.WriteLine("Please choose a function")
            Console.WriteLine("1.) Counting Backwards")
            Console.WriteLine("2.) Average of Ten Numbers")
            Console.WriteLine("3.) Factorial")
            Console.WriteLine("4.) Permutation")
            Console.WriteLine("5.) Combination")
            Console.WriteLine("6.) Quit")
            choice = Convert.ToDouble(Console.ReadLine())
            Console.Clear()

            Select Case choice


                    'Counting Backwards
                Case Is = 1
                    Console.Write("Please enter an integer value to count down by from 100: ")
                    x = Convert.ToDouble(Console.ReadLine())
                    For ans = 100 To 0 Step -x
                        If ans > 0 Then
                            Console.WriteLine(ans)
                        End If
                    Next ans


                    'Average of Ten Numbers
                Case Is = 2
                    For counter = 1 To 11 Step 1
                        'The 11th number is to complete the statement successfully and will not affect the result
                        ans = ans + x
                        Console.WriteLine("Please enter a number: ")
                        avg = ans / (counter - 1)
                        Console.WriteLine("Your current average is " & avg)
                        x = Convert.ToDouble(Console.ReadLine())
                    Next counter


                    'Factorial
                Case Is = 3
                    Console.Write("Enter a positive number to find its factorial: ")
                    x = Convert.ToDouble(Console.ReadLine())
                    For counter = x To 1 Step -1
                        If counter = x Then
                            ans = counter
                        Else
                            ans = ans * counter
                        End If
                        Console.WriteLine(ans)
                    Next counter
                    Console.WriteLine("The factorial of " & x & " is " & ans)


                    'Permutation
                Case Is = 4
                    Console.Write("Please input the number of items: ")
                    n = Convert.ToDouble(Console.ReadLine())
                    Console.Write("Please input the number of items per permutation: ")
                    r = Convert.ToDouble(Console.ReadLine())
                    For counter = n To 1 Step -1
                        If counter = n Then
                            facn = counter
                        Else
                            facn = facn * counter
                        End If
                    Next counter
                    x = n - r
                    For counter = x To 1 Step -1
                        If counter = x Then
                            facx = counter
                        Else
                            facx = facx * counter
                        End If
                    Next counter
                    ans = facn / facx
                    Console.WriteLine("There are " & ans & " permutations for P(" & n & "," & r & ")")


                    'Combination
                Case Is = 5
                    Console.Write("Please input the number of items: ")
                    n = Convert.ToDouble(Console.ReadLine())
                    Console.Write("Please input the number of items per combination: ")
                    r = Convert.ToDouble(Console.ReadLine())
                    For counter = n To 1 Step -1
                        If counter = n Then
                            facn = counter
                        Else
                            facn = facn * counter
                        End If
                    Next counter
                    For counter = r To 1 Step -1
                        If counter = r Then
                            facr = counter
                        Else
                            facr = facr * counter
                        End If
                    Next counter
                    x = n - r
                    For counter = x To 1 Step -1
                        If counter = x Then
                            facx = counter
                        Else
                            facx = facx * counter
                        End If
                    Next counter
                    ans = facn / (facr * facx)
                    Console.WriteLine("There are " & ans & " combinations for C(" & n & "," & r & ")")


                    'Quit
                Case Is = 6
                    Console.WriteLine("Goodbye!")
                    Console.ReadLine()
                    End

                    'Wrong Number
                Case Else
                    Console.Write("Please enter a valid input")
            End Select
            Console.ReadLine()
            Console.Clear()
        Loop Until choice = 6
    End Sub

End Module
