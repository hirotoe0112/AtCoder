Module _20190525

End Module

Module Past_20190525

    Sub Prison()
        'https://atcoder.jp/contests/abc127/tasks/abc127_c

        Dim sRead As String = Console.ReadLine()
        Dim N As Integer = sRead.Split(" ")(0)
        Dim M As Integer = sRead.Split(" ")(1)

        Dim sFirst As String = Console.ReadLine()

        Dim iMin As Integer = sFirst.Split(" ")(0)
        Dim iMax As Integer = sFirst.Split(" ")(1)

        For i As Integer = 2 To M

            Dim sTemp As String = Console.ReadLine()

            If CInt(sTemp.Split(" ")(0)) > iMin Then

                iMin = CInt(sTemp.Split(" ")(0))

            End If

            If CInt(sTemp.Split(" ")(1)) < iMax Then

                iMax = CInt(sTemp.Split(" ")(1))

            End If

        Next

        If iMax - iMin + 1 < 0 Then

            Console.WriteLine(0)

        Else

            Console.WriteLine(iMax - iMin + 1)

        End If

    End Sub

    Sub Algae()
        'https://atcoder.jp/contests/abc127/tasks/abc127_b

        Dim sRead As String = Console.ReadLine()

        Dim r As Integer = sRead.Split(" ")(0)
        Dim D As Integer = sRead.Split(" ")(1)
        Dim X2000 As Integer = sRead.Split(" ")(2)

        Dim XNext As Integer = r * X2000 - D

        Console.WriteLine(XNext)

        For i As Integer = 2 To 10

            XNext = r * XNext - D

            Console.WriteLine(XNext)

        Next

    End Sub

    Sub Ferris_Wheel()
        'https://atcoder.jp/contests/abc127/tasks/abc127_a

        Dim sRead As String = Console.ReadLine()

        Dim iAge As Integer = sRead.Split(" ")(0)
        Dim iFee As Integer = sRead.Split(" ")(1)

        If iAge >= 13 Then

            Console.WriteLine(iFee)

        ElseIf iAge >= 6 Then

            Console.WriteLine(iFee / 2)

        Else

            Console.WriteLine(0)

        End If

    End Sub

End Module
