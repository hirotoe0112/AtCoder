Module _20190423

End Module

Module Past_20190423

    Sub B_Shiritori()
        'https://atcoder.jp/contests/abc109/tasks/abc109_b

        Dim iCount As Integer = Console.ReadLine()

        Dim sWord(iCount - 1) As String

        sWord(0) = Console.ReadLine()

        Dim sLastChar As String = sWord(0).ToCharArray(sWord(0).Length - 1, 1)

        Dim iNGFlg As Integer = 0
        For i As Integer = 1 To iCount - 1

            sWord(i) = Console.ReadLine()

            If sLastChar = sWord(i).ToCharArray(0, 1) Then

                For j As Integer = 0 To i - 1

                    If sWord(j) = sWord(i) Then

                        iNGFlg = 1

                        Exit For

                    End If

                Next

            Else

                iNGFlg = 1

            End If

            If iNGFlg = 1 Then

                Exit For

            Else

                sLastChar = sWord(i).ToCharArray(sWord(i).Length - 1, 1)

            End If

        Next

        If iNGFlg = 1 Then

            Console.WriteLine("No")

        Else

            Console.WriteLine("Yes")

        End If

    End Sub

    Sub B_Christmas_Eve_Eve()
        'https://atcoder.jp/contests/abc115/tasks/abc115_b

        Dim iCount As Integer = Console.ReadLine()

        Dim sValue() As Integer

        For i As Integer = 0 To iCount - 1

            ReDim Preserve sValue(i)

            sValue(i) = Console.ReadLine()

        Next

        '値段の降順に並び替えるバブルソート
        For j As Integer = 0 To iCount - 1

            For k As Integer = iCount - 1 To j + 1 Step -1

                If CInt(sValue(k)) > CInt(sValue(k - 1)) Then

                    Dim iTemp As Integer = sValue(k)
                    sValue(k) = sValue(k - 1)
                    sValue(k - 1) = iTemp

                End If

            Next

        Next

        Dim iOtherTotal As Integer
        For l As Integer = 1 To iCount - 1

            iOtherTotal = iOtherTotal + sValue(l)

        Next

        Console.WriteLine(CInt(sValue(0) / 2) + iOtherTotal)

    End Sub

End Module
