'Ian Zimmerman
'Mr. Johnson
'CP1
'13 May 2016
Option Strict On
Option Explicit On
Module Module1

    Sub Main()
        Dim inches, feet, lengths, miles, hands, furlongs, distance As Double
        Dim n1 As Double = 0
        Dim n2 As Double = 0
        Dim n3 As Double = 0
        Dim n4 As Double = 0
        Dim n5 As Double = 0
        Dim n6 As Double = 0
        Dim type As String = ""
        miles = 1
        furlongs = 8
        lengths = 660
        feet = 5280
        hands = 15840
        inches = 63360
        distance = 0

        n1 = miles
        n2 = furlongs
        n3 = lengths
        n4 = feet
        n5 = hands
        n6 = inches
        Dim choice As String = "k"

        Console.WriteLine("Hello and welcome to Mr. J's Conversion Emporium!")
        Console.WriteLine()

        Do While choice <> "7"

            Console.WriteLine("Please select from the following choices of conversions.")
            Console.WriteLine("1. Miles")
            Console.WriteLine("2. Furlongs")
            Console.WriteLine("3. Lengths")
            Console.WriteLine("4. Feet")
            Console.WriteLine("5. Hands")
            Console.WriteLine("6. Inches")
            Console.WriteLine("7. Quit")

            Console.Write("Enter the number coresponding to your choice: ")
            choice = Console.ReadLine()
            Select Case choice

                Case Is = "1"

                    Console.Clear()
                    type = "miles"
                    distance = getval(type)

                    Call conversion(n1, n2, n3, n4, n5, n6, miles, miles, furlongs, lengths, feet, hands, inches, distance)

                    Call display(type, distance, n1, n2, n3, n4, n5, n6)

                    Console.Clear()

                Case Is = "2"

                    Console.Clear()
                    type = "furlongs"
                    distance = getval(type)

                    Call conversion(n1, n2, n3, n4, n5, n6, furlongs, miles, furlongs, lengths, feet, hands, inches, distance)

                    Call display(type, distance, n1, n2, n3, n4, n5, n6)

                    Console.Clear()

                Case Is = "3"

                    Console.Clear()
                    type = "lengths"
                    distance = getval(type)

                    Call conversion(n1, n2, n3, n4, n5, n6, lengths, miles, furlongs, lengths, feet, hands, inches, distance)

                    Call display(type, distance, n1, n2, n3, n4, n5, n6)

                    Console.Clear()

                Case Is = "4"

                    Console.Clear()
                    type = "feet"
                    distance = getval(type)

                    Call conversion(n1, n2, n3, n4, n5, n6, feet, miles, furlongs, lengths, feet, hands, inches, distance)

                    Call display(type, distance, n1, n2, n3, n4, n5, n6)

                    Console.Clear()

                Case Is = "5"

                    Console.Clear()
                    type = "hands"
                    distance = getval(type)

                    Call conversion(n1, n2, n3, n4, n5, n6, hands, miles, furlongs, lengths, feet, hands, inches, distance)

                    Call display(type, distance, n1, n2, n3, n4, n5, n6)

                    Console.Clear()

                Case Is = "6"

                    Console.Clear()
                    type = "inches"
                    distance = getval(type)

                    Call conversion(n1, n2, n3, n4, n5, n6, inches, miles, furlongs, lengths, feet, hands, inches, distance)

                    Call display(type, distance, n1, n2, n3, n4, n5, n6)

                    Console.Clear()

                Case Is = "7"

                    Console.Clear()
                    Console.Write("Are you sure you want to quit (Y or N)? ")
                    choice = Console.ReadLine()
                    If choice = "Y" Or choice = "y" Then
                        Console.Write("Are you REALLY sure you want to quit (Y or N)? ")
                        choice = Console.ReadLine()
                        If choice = "Y" Or choice = "y" Then
                            Console.WriteLine("Goodbye!")
                            Console.Write("Please press the any key to complete the program. ")
                            Console.ReadKey()
                            choice = "7"
                        End If
                    End If
                    Console.Clear()

                Case Else

                    Console.Clear()
                    Console.WriteLine("Im sorry, we don't have that conversion in stock. Try back again later.")
                    Console.Write("Please press the any key to continue.")
                    Console.ReadKey()
                    Console.Clear()

            End Select

        Loop





    End Sub

    Function getval(ByVal desc As String) As Double
        Dim dist As Double

        Console.Write("How many " & desc & " do you want to convert? ")
        dist = Convert.ToDouble(Console.ReadLine())

        Return dist
    End Function

    Sub conversion(ByRef x1 As Double, ByRef x2 As Double, ByRef x3 As Double, ByRef x4 As Double, ByRef x5 As Double, ByRef x6 As Double,
                   ByVal con As Double, ByVal y1 As Double, ByVal y2 As Double, ByVal y3 As Double, ByVal y4 As Double, ByVal y5 As Double,
                   ByVal y6 As Double, ByVal d As Double)

        x1 = d * y1 / con
        x2 = d * y2 / con
        x3 = d * y3 / con
        x4 = d * y4 / con
        x5 = d * y5 / con
        x6 = d * y6 / con

    End Sub

    Sub display(ByVal desc As String, ByVal dist As Double, ByVal x1 As Double, ByVal x2 As Double, ByVal x3 As Double, ByVal x4 As Double,
                ByVal x5 As Double, ByVal x6 As Double)

        Console.WriteLine("You wanted to convert " & dist & " " & desc & ":")
        Console.WriteLine("Miles = " & x1)
        Console.WriteLine("Furlongs = " & x2)
        Console.WriteLine("Lengths = " & x3)
        Console.WriteLine("Feet = " & x4)
        Console.WriteLine("Hands = " & x5)
        Console.WriteLine("Inches = " & x6)
        Console.Write("Press any key to continue.")
        Console.ReadKey()

    End Sub
End Module
