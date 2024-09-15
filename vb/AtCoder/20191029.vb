Module _20191029

End Module

Module Past_20191029

    Sub Slimes()
        'https://atcoder.jp/contests/abc143/tasks/abc143_c

        Dim iCount As Integer = CLng(Console.ReadLine())
        Dim sString As String = Console.ReadLine()

        Dim arrChar As Char() = sString

        Dim sBeforeColor As String = arrChar(0)
        Dim iTotalCount As Integer = 1

        For i As Integer = 1 To iCount - 1

            If arrChar(i) <> sBeforeColor Then

                iTotalCount += 1
                sBeforeColor = arrChar(i)

            End If

        Next

        Console.WriteLine(iTotalCount)

    End Sub

    Sub Walk_on_multiplication()
        'https://atcoder.jp/contests/abc144/tasks/abc144_c

        Dim iRead As Long = CLng(Console.ReadLine())

        '平方根
        Dim iKijun As Long = Math.Sqrt(iRead)

        Dim x As Long
        Dim y As Long

        For i As Long = iKijun To 1 Step -1

            If iRead Mod i = 0 Then

                x = i

                y = iRead \ i

                Exit For

            End If

        Next

        Console.WriteLine(x + y - 2)


    End Sub

    Sub _81()
        'https://atcoder.jp/contests/abc144/tasks/abc144_b

        Dim sRead As Integer = CInt(Console.ReadLine())

        Dim isYes As Boolean = False

        For i As Integer = 1 To 9

            If sRead Mod i = 0 AndAlso sRead \ i > 0 AndAlso sRead \ i < 10 Then

                isYes = True

            End If

        Next

        If isYes = True Then

            Console.WriteLine("Yes")

        Else

            Console.WriteLine("No")

        End If

    End Sub

    Sub _99()
        'https://atcoder.jp/contests/abc144/tasks/abc144_a

        Dim sRead As String = Console.ReadLine()

        Dim iNumber1 As Integer = sRead.Split(" ")(0)
        Dim iNumber2 As Integer = sRead.Split(" ")(1)

        If iNumber1 > 0 AndAlso iNumber1 < 10 AndAlso iNumber2 > 0 AndAlso iNumber2 < 10 Then

            Console.WriteLine(iNumber1 * iNumber2)

        Else

            Console.WriteLine(-1)

        End If

    End Sub

End Module