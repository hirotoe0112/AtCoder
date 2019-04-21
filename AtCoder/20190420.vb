Module _20190420


End Module

Module Past_20190420

    Sub B_未提出者は誰だ()
        'https://atcoder.jp/contests/joi2007yo/tasks/joi2007yo_b

        Dim arrStudentCount(28) As Integer

        For i As Integer = 0 To 27

            arrStudentCount(i) = CInt(Console.ReadLine())

        Next

        Dim arrNotSubmit(2) As Integer
        Dim iDiscover As Integer = 0
        For j As Integer = 1 To 30

            If Array.IndexOf(arrStudentCount.ToArray, j) < 0 Then

                arrNotSubmit(iDiscover) = j
                iDiscover = iDiscover + 1

            End If

        Next

        If arrNotSubmit(0) > arrNotSubmit(1) Then

            Console.WriteLine(arrNotSubmit(1))
            Console.WriteLine(arrNotSubmit(0))

        Else

            Console.WriteLine(arrNotSubmit(0))
            Console.WriteLine(arrNotSubmit(1))

        End If

    End Sub

    Sub B_Great_Ocean_View()
        'https://atcoder.jp/contests/abc124/tasks/abc124_b

        '山の数
        Dim intMountainCount As Integer = Console.ReadLine()

        '高さ
        Dim sHeight As String() = Console.ReadLine().Split(" ")

        Dim iMaxHeight As Integer = CInt(sHeight(0))
        Dim iWatchCount As Integer = 0
        'For文でAs Integerをつけないとコンパイルエラーになる！！
        For i As Integer = 0 To intMountainCount - 1

            If CInt(sHeight(i)) >= iMaxHeight Then

                iWatchCount = iWatchCount + 1

                iMaxHeight = CInt(sHeight(i))

            End If

        Next

        Console.WriteLine(iWatchCount)

    End Sub

    Sub A_Buttons()
        'https://atcoder.jp/contests/abc124/tasks/abc124_a

        '入力を受け取る
        Dim a As String = Console.ReadLine()

        '数値に分解
        Dim Int1 As Integer = CInt(a.Split(" ")(0))
        Dim Int2 As Integer = CInt(a.Split(" ")(1))

        If Int1 = Int2 Then

            '出力
            Console.WriteLine(Int1 + Int2)

        End If

        If Int1 > Int2 Then

            '出力
            Console.WriteLine(Int1 + Int1 - 1)

        End If

        If Int2 > Int1 Then

            '出力
            Console.WriteLine(Int2 + Int2 - 1)

        End If

    End Sub

    Sub ABC081A_Product()
        'https://atcoder.jp/contests/abs/tasks/abc086_a

        '入力を受け取る
        Dim a As String = Console.ReadLine()

        '数値に分解
        Dim Int1 As Integer = CInt(a.Split(" ")(0))
        Dim Int2 As Integer = CInt(a.Split(" ")(1))

        'どちらかが偶数なら偶数
        If Int1 Mod 2 = 0 Then

            '出力
            Console.WriteLine("Even")

        ElseIf Int2 Mod 2 = 0 Then

            '出力
            Console.WriteLine("Even")

        Else

            '出力
            Console.WriteLine("Odd")

        End If

    End Sub

    Sub practice_contest_A()
        'https://atcoder.jp/contests/practice/tasks/practice_1

        '1行目
        Dim a As Integer = Console.ReadLine()

        '2行目
        Dim b As String() = Console.ReadLine().Split(" ")

        '3行目
        Dim c As String = Console.ReadLine()

        '出力
        Console.WriteLine(CInt(a) + CInt(b(0)) + CInt(b(1)) & " " + c)

    End Sub

End Module
