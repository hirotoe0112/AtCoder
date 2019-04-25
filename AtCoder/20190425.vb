Module _20190425

    Sub Main()



    End Sub

End Module

Module Past_20190425

    Sub B_Dimensional_Worlds_Tale()
        'https://atcoder.jp/contests/abc110/tasks/abc110_b

        Dim sRead As String = Console.ReadLine()
        Dim iACityCount As Integer = sRead.Split(" ")(0)
        Dim iBCityCount As Integer = sRead.Split(" ")(1)
        Dim iX As Integer = sRead.Split(" ")(2)
        Dim iY As Integer = sRead.Split(" ")(3)

        Dim iAMax As Integer = -100
        Dim sAList() As String = Console.ReadLine().Split

        For i As Integer = 0 To iACityCount - 1

            If sAList(i) > iAMax Then

                iAMax = sAList(i)

            End If

        Next

        If iX > iAMax Then

            iAMax = iX

        End If

        Dim iBMin As Integer = 100
        Dim sBList() As String = Console.ReadLine().Split

        For j As Integer = 0 To iBCityCount - 1

            If sBList(j) < iBMin Then

                iBMin = sBList(j)

            End If

        Next

        If iY < iBMin Then

            iBMin = iY

        End If

        If iBMin > iAMax Then

            Console.WriteLine("No War")

        Else

            Console.WriteLine("War")

        End If

    End Sub

    Sub A_ABC333()
        'https://atcoder.jp/contests/abc109/tasks/abc109_a

        Dim sRead As String = Console.ReadLine()

        If sRead.Split(" ")(0) * sRead.Split(" ")(1) Mod 2 = 0 Then

            Console.WriteLine("No")

        Else

            Console.WriteLine("Yes")

        End If

    End Sub

End Module