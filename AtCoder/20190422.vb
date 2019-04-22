Module _20190422

    Sub Main()



    End Sub

End Module

Module Past_20190422

    Sub A_Right_Triangle()
        'https://atcoder.jp/contests/abc116/tasks/abc116_a

        Dim sRead As String = Console.ReadLine()

        Dim iAB As Integer = sRead.Split(" ")(0)
        Dim iBC As Integer = sRead.Split(" ")(1)
        Dim iCA As Integer = sRead.Split(" ")(2)

        Console.WriteLine((iAB * iBC) / 2)

    End Sub

    Sub A_Entrance_Examination()
        'https://atcoder.jp/contests/abc117/tasks/abc117_a

        Dim sRead As String = Console.ReadLine()

        Dim iBWorld As Integer = sRead.Split(" ")(0)
        Dim iSpeed As Integer = sRead.Split(" ")(1)

        Dim iResult As Decimal = Math.Round(iBWorld / iSpeed, 10, MidpointRounding.AwayFromZero)

        Console.WriteLine(iResult)

    End Sub

    Sub _118_a()
        'https://atcoder.jp/contests/abc118/tasks/abc118_a

        Dim sRead As String = Console.ReadLine()

        Dim iInt1 As Integer = sRead.Split(" ")(0)
        Dim iInt2 As Integer = sRead.Split(" ")(1)

        If iInt2 Mod iInt1 = 0 Then

            Console.WriteLine(iInt1 + iInt2)

        Else

            Console.WriteLine(iInt2 - iInt1)

        End If

    End Sub

    Sub A_Still_TBD()
        'https://atcoder.jp/contests/abc119/tasks/abc119_a

        Dim sRead As String = Console.ReadLine()

        Dim iDay As Integer = sRead.Replace("/", "")

        If iDay <= 20190430 Then

            Console.WriteLine("Heisei")

        Else

            Console.WriteLine("TBD")

        End If

    End Sub

End Module
