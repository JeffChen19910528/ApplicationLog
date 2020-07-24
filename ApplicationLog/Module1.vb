Module Module1

    Sub Main()
        TracingTest("LogFile.txt")
        Console.ReadLine()
    End Sub

    Public Sub TracingTest(ByVal fileName As String)
        My.Application.Log.WriteEntry($"Entering TracingTest with argument '{fileName}'.")

        ' Code to trace goes here.

        My.Application.Log.WriteEntry($"Exiting TracingTest with argument '{fileName}'.")
    End Sub

End Module
