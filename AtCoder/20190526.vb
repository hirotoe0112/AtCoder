Module _20190526

End Module

Module Past_20190526

    Sub Apple_Pie()
        'https://atcoder.jp/contests/abc128/tasks/abc128_a

        Dim sRead As String = Console.ReadLine()

        Dim iApple As Integer = sRead.Split(" ")(0)
        Dim iPart As Integer = sRead.Split(" ")(1)

        Dim iAll As Integer = iApple * 3 + iPart

        Console.WriteLine(iAll \ 2)

    End Sub

End Module
