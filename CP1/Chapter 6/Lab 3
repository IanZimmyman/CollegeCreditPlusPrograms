'Ian Zimmerman
'Computer Programming 1
'Chapter 6 lab 3: Formatting output.
Option Strict On
Option Explicit On


Module Module1
    'Main should display formatted variables.
    Sub Main()
        Dim GPA As Double = 3.4
        Dim Fees As Double = 123.4547
        Dim Grade As Double = 0.92
        Dim Phone As Double = 3305551234
        Dim SSI As Double = 987654321
        Dim Date1 As DateTime
        Dim temp As String

        'Format GPA as a fixed point number. Use temp to store and display the value.

        Console.WriteLine("GPA = " & GPA)
        temp = GPA.ToString("F")
        Console.WriteLine("GPA formatted as a fixed point number is " & temp)

        'Format Fees as currency. Use temp to store and display the value.

        Console.WriteLine("Fees = " & Fees)
        temp = Fees.ToString("C")
        Console.WriteLine("Fees formatted as currency is " & temp)

        'Format Grade as a percentage. Use temp to store and display the value.

        Console.WriteLine("Grade = " & Grade)
        temp = Grade.ToString("P")
        Console.WriteLine("Grade formatted as a percentage is " & temp)

        'Format phone as a phone number with area code in parenthesis and apropriate 
        '   hyphens. Use temp to store and display the value.

        Console.WriteLine("Phone = " & Phone)
        temp = Phone.ToString("(###) ###-####")
        Console.WriteLine("Phone formatted as a phone number is " & temp)

        'Format SSI as a Social Security Number with apropriate hyphens. Use temp 
        '   to store and display the value.

        Console.WriteLine("SSI = " & SSI)
        temp = SSI.ToString("###-##-####")
        Console.WriteLine("SSI formatted as a Social Security Number is " & temp)

        'Set date to the current date using DateTime.Today. Format the date in the eropean 
        '   style of day month year.Use temp to store and display the value.

        Date1 = DateTime.Today
        Console.WriteLine("Date1 = " & Date1)
        temp = Date1.ToString("dd/MM/yy")
        Console.WriteLine("In the European style, the date is " & temp)
        temp = Date1.ToString("dddd MMMM d, yyyy")
        Console.WriteLine("In other words, the date is " & temp)

        Console.ReadKey()
    End Sub

End Module
