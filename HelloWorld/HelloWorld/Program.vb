Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("What is your name?")
        Dim name = Console.ReadLine()
        Console.WriteLine("Hello " + name)
        Dim dayofyear = Date.Now.DayOfYear
        Console.Write("Day of year: ")
        Console.WriteLine(dayofyear)

    End Sub
End Module
