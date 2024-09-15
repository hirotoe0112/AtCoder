Module _20190427


End Module

Module Past_20190427

    Sub B_Resale()
        'https://atcoder.jp/contests/abc125/tasks/abc125_b

        Dim iCount As Integer = Console.ReadLine()

        Dim sValue() As String = Console.ReadLine().Split(" ")
        Dim sCost() As String = Console.ReadLine().Split(" ")

        Dim iMax As Integer = 0

        For i As Integer = 0 To iCount - 1

            If CInt(sValue(i)) - CInt(sCost(i)) > 0 Then

                iMax = iMax + CInt(sValue(i)) - CInt(sCost(i))

            End If

        Next

        Console.WriteLine(iMax)

    End Sub

    Sub A_Biscuit_Generator()
        'https://atcoder.jp/contests/abc125/tasks/abc125_a

        Dim sRead As String = Console.ReadLine()

        Dim iMinutes As Decimal = CDec(sRead.Split(" ")(2)) + 0.5

        Dim iEndFlg As Integer = 0
        Dim iTotalCount As Integer = 0
        Dim iLoopCount As Integer = 1

        Do While iEndFlg = 0

            If iLoopCount * sRead.Split(" ")(0) > iMinutes Then

                iEndFlg = 1

            Else

                iTotalCount = iTotalCount + CInt(sRead.Split(" ")(1))

            End If

            iLoopCount = iLoopCount + 1

        Loop

        Console.WriteLine(iTotalCount)

    End Sub

End Module