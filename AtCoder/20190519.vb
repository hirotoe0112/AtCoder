Module _20190519

    Sub Main()



    End Sub

End Module

Module Past_20190519

    Sub YYYY_or_MMYY()
        'https://atcoder.jp/contests/abc126/tasks/abc126_b

        Dim sRead As String = Console.ReadLine()

        Dim arrChar() As Char = sRead.ToCharArray()

        Dim sUe As Integer = CInt(arrChar(0) & arrChar(1))
        Dim sSita As Integer = CInt(arrChar(2) & arrChar(3))

        '1=年のみ 2=両方OK
        Dim iUeFlg As Integer = 0
        Dim iSitaFlg As Integer = 0

        If sUe > 12 OrElse sUe = 0 Then

            iUeFlg = 1

        Else

            iUeFlg = 2

        End If

        If sSita > 12 OrElse sSita = 0 Then

            iSitaFlg = 1

        Else

            iSitaFlg = 2

        End If

        If iUeFlg = 2 AndAlso iSitaFlg = 2 Then

            Console.WriteLine("AMBIGUOUS")

        ElseIf iUeFlg = 1 AndAlso iSitaFlg = 2 Then

            Console.WriteLine("YYMM")

        ElseIf iUeFlg = 2 AndAlso iSitaFlg = 1 Then

            Console.WriteLine("MMYY")

        Else

            Console.WriteLine("NA")

        End If

    End Sub

    Sub Changing_a_Character()
        'https://atcoder.jp/contests/abc126/tasks/abc126_a

        Dim sRead As String = Console.ReadLine()
        Dim iLong As Integer = sRead.Split(" ")(0)
        Dim iOrder As Integer = sRead.Split(" ")(1)
        Dim sStr As String = Console.ReadLine()

        Dim arrChar() As Char = sStr.ToCharArray()

        Dim sNewStr As String = ""

        For i As Integer = 0 To iLong - 1

            If i + 1 = iOrder Then

                Select Case arrChar(i)
                    Case "A"

                        sNewStr = sNewStr & "a"

                    Case "B"

                        sNewStr = sNewStr & "b"

                    Case "C"

                        sNewStr = sNewStr & "c"
                End Select

            Else

                sNewStr = sNewStr & arrChar(i)

            End If

        Next

        Console.WriteLine(sNewStr)

    End Sub


End Module