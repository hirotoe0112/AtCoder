Module _20190421


End Module

Module Past_20190421

    Sub A_Favorite_Sound()
        'https://atcoder.jp/contests/abc120/tasks/abc120_a

        Dim sRead As String = Console.ReadLine()

        Dim iOnceMoney As Integer = sRead.Split(" ")(0)
        Dim iHaveMoney As Integer = sRead.Split(" ")(1)
        Dim iMaxCount As Integer = sRead.Split(" ")(2)

        If iOnceMoney * iMaxCount > iHaveMoney Then

            Console.WriteLine(iHaveMoney \ iOnceMoney)

        Else

            Console.WriteLine(iMaxCount)

        End If

    End Sub

    Sub A_White_Cells()
        'https://atcoder.jp/contests/abc121/tasks/abc121_a

        Dim sRead1 As String = Console.ReadLine()
        Dim sRead2 As String = Console.ReadLine()

        Dim iColumn As Integer = sRead1.Split(" ")(0)
        Dim iRow As Integer = sRead1.Split(" ")(1)

        Dim iBlackColumn As Integer = sRead2.Split(" ")(0)
        Dim iBlackRow As Integer = sRead2.Split(" ")(1)

        Console.WriteLine(iColumn * iRow - iBlackColumn * iRow - iBlackRow * iColumn + iBlackColumn * iBlackRow)

    End Sub

    Sub A_Double_Helix()
        'https://atcoder.jp/contests/abc122/tasks/abc122_a

        Dim sRead As String = Console.ReadLine()

        Select Case sRead
            Case "A"
                Console.WriteLine("T")
            Case "T"
                Console.WriteLine("A")
            Case "C"
                Console.WriteLine("G")
            Case "G"
                Console.WriteLine("C")
        End Select

    End Sub

    Sub A_Five_Antennas()
        'https://atcoder.jp/contests/abc123/tasks/abc123_a

        Dim iAntena(5) As Integer
        iAntena(0) = Console.ReadLine()
        Dim iMax As Integer = iAntena(0)
        Dim iMin As Integer = iAntena(0)

        For i As Integer = 1 To 4

            iAntena(i) = Console.ReadLine()

            If iAntena(i) > iMax Then

                iMax = iAntena(i)

            ElseIf iAntena(i) < iMin Then

                iMin = iAntena(i)

            End If

        Next

        Dim iDistance As Integer = Console.ReadLine()

        If iMax - iMin > iDistance Then

            Console.WriteLine(":(")

        Else

            Console.WriteLine("Yay!")

        End If

    End Sub

    Sub abc016_1()
        'https://atcoder.jp/contests/abc016/tasks/abc016_1

        Dim sRead As String = Console.ReadLine()

        Dim iMonth As Integer = sRead.Split(" ")(0)
        Dim iDay As Integer = sRead.Split(" ")(1)

        If iMonth Mod iDay = 0 Then

            Console.WriteLine("YES")

        Else

            Console.WriteLine("NO")

        End If

    End Sub

    Sub tenka1_2019_b()
        'https://atcoder.jp/contests/tenka1-2019-beginner/tasks/tenka1_2019_b

        '文字列の長さ
        Dim iStrLength As Integer = CInt(Console.ReadLine())

        '文字列
        Dim sStr As String = Console.ReadLine()

        '整数
        Dim iNumber As Integer = CInt(Console.ReadLine())

        '文字列を分解
        Dim arrStr() As Char = sStr.ToCharArray

        '比較する文字を取得
        Dim sCompareStr As String = arrStr(iNumber - 1)

        '出力文字列
        Dim sOutput As String = ""

        For i As Integer = 0 To iStrLength - 1

            If arrStr(i) = sCompareStr Then

                sOutput = sOutput & arrStr(i)

            Else

                sOutput = sOutput & "*"

            End If

        Next

        Console.WriteLine(sOutput)

    End Sub

    Sub A_On_the_Way()
        'https://atcoder.jp/contests/tenka1-2019-beginner/tasks/tenka1_2019_a

        Dim sRead As String = Console.ReadLine()

        Dim iHouse1 As Integer = sRead.Split(" ")(0)
        Dim iHouse2 As Integer = sRead.Split(" ")(1)
        Dim iHouse3 As Integer = sRead.Split(" ")(2)

        If iHouse1 < iHouse3 AndAlso iHouse3 < iHouse2 Then

            Console.WriteLine("Yes")

        ElseIf iHouse1 > iHouse3 AndAlso iHouse3 > iHouse2 Then

            Console.WriteLine("Yes")

        Else

            Console.WriteLine("No")

        End If

    End Sub

End Module
