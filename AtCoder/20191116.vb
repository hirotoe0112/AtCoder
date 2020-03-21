Module _20191116

    Sub Main()
        'https://atcoder.jp/contests/abc108/tasks/arc102_a

        Dim sRead As String = Console.ReadLine()

        Dim iLimitNumber As Long = Split(sRead, (" "))(0)
        Dim iBaisuu As Long = Split(sRead, (" "))(1)

        Dim iCount As Long = 0

        For i As Integer = 1 To iLimitNumber

            Dim iJLimit As Integer = iBaisuu - i
            If iJLimit <= 0 Then
                iJLimit = 1
            End If
            For j As Integer = iJLimit To iLimitNumber

                If (i + j) Mod iBaisuu <> 0 Then
                    Continue For
                Else
                    Dim iKLimit1 As Integer = iBaisuu - i
                    Dim iKLimit2 As Integer = iBaisuu - j
                    Dim iKLimit As Integer
                    If iKLimit1 < iKLimit2 Then
                        iKLimit = iKLimit2
                    Else
                        iKLimit = iKLimit1
                    End If
                    If iKLimit <= 0 Then
                        iKLimit = 1
                    End If
                    Dim ikOKFlg As Integer = 0
                    For k As Integer = iKLimit To iLimitNumber

                        If (j + k) Mod iBaisuu <> 0 OrElse (i + k) Mod iBaisuu <> 0 Then
                            Continue For
                        Else
                            'Console.WriteLine(i & "," & j & "," & k)
                            ikOKFlg = 1
                            iCount += 1
                            k += iBaisuu - 1
                        End If

                    Next

                    If ikOKFlg = 1 Then
                        j += iBaisuu - 1
                    End If

                End If

            Next

        Next

        Console.WriteLine(iCount)

    End Sub

End Module

Module Past_20191116

    Sub Ruined_Square()
        'https://atcoder.jp/contests/abc108/tasks/abc108_b

        Dim sRead As String = Console.ReadLine()

        Dim iZahyou1 As Integer() = {Split(sRead, " ")(0), Split(sRead, " ")(1)}
        Dim iZahyou2 As Integer() = {Split(sRead, " ")(2), Split(sRead, " ")(3)}
        Dim iZahyou3 As Integer() = {0, 0}
        Dim iZahyou4 As Integer() = {0, 0}

        '移動距離
        Dim iNagasaX As Integer = iZahyou2(0) - iZahyou1(0)
        Dim iNagasaY As Integer = iZahyou2(1) - iZahyou1(1)

        If iNagasaX <= 0 AndAlso iNagasaY <= 0 Then
            'X方向マイナス、Y方向マイナスの場合はX方向にY移動距離をプラス、Y方向にX移動距離をマイナス
            iZahyou3(0) = iZahyou2(0) + Math.Abs(iNagasaY)
            iZahyou3(1) = iZahyou2(1) - Math.Abs(iNagasaX)
            iZahyou4(0) = iZahyou1(0) + Math.Abs(iNagasaY)
            iZahyou4(1) = iZahyou1(1) - Math.Abs(iNagasaX)
        ElseIf iNagasaX <= 0 AndAlso iNagasaY > 0 Then
            'X方向マイナス、Y方向プラスの場合はX方向にY移動距離をマイナス、Y方向にX移動距離をマイナス
            iZahyou3(0) = iZahyou2(0) - Math.Abs(iNagasaY)
            iZahyou3(1) = iZahyou2(1) - Math.Abs(iNagasaX)
            iZahyou4(0) = iZahyou1(0) - Math.Abs(iNagasaY)
            iZahyou4(1) = iZahyou1(1) - Math.Abs(iNagasaX)
        ElseIf iNagasaX > 0 And iNagasaY <= 0 Then
            'X方向プラス、Y方向マイナスの場合はX方向にY移動距離をプラス、Y方向にX移動距離をプラス
            iZahyou3(0) = iZahyou2(0) + Math.Abs(iNagasaY)
            iZahyou3(1) = iZahyou2(1) + Math.Abs(iNagasaX)
            iZahyou4(0) = iZahyou1(0) + Math.Abs(iNagasaY)
            iZahyou4(1) = iZahyou1(1) + Math.Abs(iNagasaX)
        ElseIf iNagasaX > 0 And iNagasaY > 0 Then
            'X方向プラス、Y方向プラスの場合はX方向にY移動距離をマイナス、Y方向にX移動距離をプラス
            iZahyou3(0) = iZahyou2(0) - Math.Abs(iNagasaY)
            iZahyou3(1) = iZahyou2(1) + Math.Abs(iNagasaX)
            iZahyou4(0) = iZahyou1(0) - Math.Abs(iNagasaY)
            iZahyou4(1) = iZahyou1(1) + Math.Abs(iNagasaX)
        End If

        Console.WriteLine(iZahyou3(0) & " " & iZahyou3(1) & " " & iZahyou4(0) & " " & iZahyou4(1))

    End Sub

    Sub Pair()
        'https://atcoder.jp/contests/abc108/tasks/abc108_a

        Dim iNumber As Integer = Console.ReadLine()

        Dim iKisuuCount As Integer = 0
        Dim iGusuuCount As Integer = 0

        For i As Integer = 1 To iNumber

            If i Mod 2 = 0 Then
                iGusuuCount += 1
            Else
                iKisuuCount += 1
            End If

        Next

        Console.WriteLine(iGusuuCount * iKisuuCount)

    End Sub

End Module
