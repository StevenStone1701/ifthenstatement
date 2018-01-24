Module Module1

    Sub Main()
        Dim Alice As String = "allice"
        Dim Steven As String = "steven"
        Console.Write("what's your name?: ")
        Dim userValue As String = Console.ReadLine()
        If LCase(userValue) = Alice Then
            Console.WriteLine("Hi Allice.")
        ElseIf LCase(userValue) = Steven Then
            Console.WriteLine("Hi Steven.")
        Else
            Console.WriteLine("Sorry, I don't know you.")
        End If
        Console.ReadKey()


    End Sub

End Module
