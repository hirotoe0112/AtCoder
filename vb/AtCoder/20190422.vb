Module _20190422


End Module

Module Past_20190422

    Sub B_K_th_Common_Divisor()
        'https://atcoder.jp/contests/abc120/tasks/abc120_b

        Dim sRead As String = Console.ReadLine

        Dim iNum1 As Integer = sRead.Split(" ")(0)
        Dim iNum2 As Integer = sRead.Split(" ")(1)
        Dim iOrder As Integer = sRead.Split(" ")(2)

        Dim iMaxNum As Integer
        If iNum1 > iNum2 Then

            iMaxNum = iNum1

        Else

            iMaxNum = iNum2

        End If

        Dim iTempOrder As Integer = 0
        Dim iKotae As Integer

        For i As Integer = iMaxNum To 1 Step -1

            If iNum1 Mod i = 0 AndAlso iNum2 Mod i = 0 Then

                iTempOrder = iTempOrder + 1

            End If

            If iOrder = iTempOrder Then

                iKotae = i

                Exit For

            End If

        Next

        Console.WriteLine(iKotae)

    End Sub

    Sub B_754()
        'https://atcoder.jp/contests/abc114/tasks/abc114_b

        Dim sNumber() As Char = Console.ReadLine().ToCharArray

        Dim iMin As Integer = 9999999
        Dim iCalc As Integer

        For i As Integer = 0 To sNumber.Length - 3

            iCalc = 753 - CInt(sNumber(i).ToString & sNumber(i + 1).ToString & sNumber(i + 2).ToString)

            If iCalc < 0 Then

                iCalc = iCalc * -1

            End If

            If iMin > iCalc Then

                iMin = iCalc

            End If

        Next

        Console.WriteLine(iMin)

    End Sub

    Sub B_AtCoder_Beginner_Contest_111()
        'https://atcoder.jp/contests/abc111/tasks/abc111_b

        Dim sNextContest() As Char = Console.ReadLine().ToCharArray

        Dim iKuriagariFlg As Integer = 0

        For i As Integer = 1 To sNextContest.Length - 1

            If sNextContest(0) < sNextContest(i) Then

                iKuriagariFlg = 1

                Exit For

            End If

        Next

        If iKuriagariFlg = 0 Then

            Console.WriteLine(sNextContest(0) & sNextContest(0) & sNextContest(0))

        Else

            Dim A As String = (CInt(sNextContest(0).ToString) + 1).ToString

            Console.WriteLine(A & A & A)

        End If

    End Sub

    Sub B_ATCoder()
        'https://atcoder.jp/contests/abc122/tasks/abc122_b

        Dim sStr() As Char = Console.ReadLine().ToCharArray

        Dim iMaxLength As Integer = 0
        Dim iCurrentLength As Integer = 0

        For i As Integer = 0 To sStr.Length - 1

            iCurrentLength = 0

            For j As Integer = i To sStr.Length - 1

                If sStr(j) = "A" OrElse sStr(j) = "C" OrElse sStr(j) = "G" OrElse sStr(j) = "T" Then

                    iCurrentLength = iCurrentLength + 1

                Else

                    Exit For

                End If

            Next

            If iMaxLength < iCurrentLength Then

                iMaxLength = iCurrentLength

            End If

        Next

        Console.WriteLine(iMaxLength)

    End Sub

    Sub B_Polygon()
        'https://atcoder.jp/contests/abc117/tasks/abc117_b

        Dim iLineCount As Integer = Console.ReadLine()

        Dim iLength() As String = Console.ReadLine().Split(" ")

        '大きい順に並べるバブルソート
        For i As Integer = 0 To iLineCount - 1

            For j As Integer = iLineCount - 1 To i + 1 Step -1

                'Stringのままだと比較が正常にできないので注意
                If CInt(iLength(j)) > CInt(iLength(j - 1)) Then

                    Dim iTemp As String = iLength(j)
                    iLength(j) = iLength(j - 1)
                    iLength(j - 1) = iTemp

                End If

            Next

        Next

        Dim iLongest As Integer = iLength(0)

        Dim iTotal As Integer = 0

        For k As Integer = 1 To iLineCount - 1

            iTotal = iTotal + CInt(iLength(k))

        Next

        If iLongest < iTotal Then

            Console.WriteLine("Yes")

        Else

            Console.WriteLine("No")

        End If

    End Sub

    Sub A_Maximize_the_Formula()
        'https://atcoder.jp/contests/abc110/tasks/abc110_a

        Dim sRead As String = Console.ReadLine()

        Dim iNum() As String = sRead.Split(" ")

        '降順に並べるバブルソート
        For i As Integer = 0 To iNum.Length - 1

            For j As Integer = iNum.Length - 1 To i + 1 Step -1

                If iNum(j) > iNum(j - 1) Then

                    Dim iTemp As String = iNum(j)
                    iNum(j) = iNum(j - 1)
                    iNum(j - 1) = iTemp

                End If

            Next

        Next

        Console.WriteLine(CInt(iNum(0).ToString & iNum(1).ToString) + iNum(2))

    End Sub

    Sub A_AtCoder_Beginner_Contest_999()
        'https://atcoder.jp/contests/abc111/tasks/abc111_a

        Dim sStr() As Char = Console.ReadLine().ToCharArray

        Dim sCorrect As String = ""

        For i As Integer = 0 To sStr.Length - 1

            If sStr(i) = "1" Then

                sCorrect = sCorrect + "9"

            Else

                sCorrect = sCorrect + "1"

            End If

        Next

        Console.WriteLine(sCorrect)

    End Sub

    Sub A_Programming_Education()
        'https://atcoder.jp/contests/abc112/tasks/abc112_a

        Dim iAge As Integer = Console.ReadLine()

        If iAge = 1 Then

            Console.WriteLine("Hello World")

        Else


            Console.WriteLine(CInt(Console.ReadLine()) + CInt(Console.ReadLine()))

        End If

    End Sub

    Sub A_Discount_Fare()
        'https://atcoder.jp/contests/abc113/tasks/abc113_a

        Dim sRead As String = Console.ReadLine()

        Console.WriteLine(sRead.Split(" ")(0) + sRead.Split(" ")(1) / 2)

    End Sub

    Sub A_753()
        'https://atcoder.jp/contests/abc114/tasks/abc114_a

        Select Case Console.ReadLine()
            Case 7, 5, 3
                Console.WriteLine("YES")
            Case Else
                Console.WriteLine("NO")
        End Select

    End Sub

    Sub Christmas_Eve_Eve_Eve()
        'https://atcoder.jp/contests/abc115/tasks/abc115_a

        Select Case Console.ReadLine()
            Case 25
                Console.WriteLine("Christmas")
            Case 24
                Console.WriteLine("Christmas Eve")
            Case 23
                Console.WriteLine("Christmas Eve Eve")
            Case 22
                Console.WriteLine("Christmas Eve Eve Eve")
        End Select

    End Sub

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
