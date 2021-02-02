Module mdlFuncs
    '输入合法性检查
    Public Function RangeCheck(value As Integer, n As Integer, m As Integer, Optional sender As String = "")
        If value >= n And value <= m Then
            Return value
        Else
            MsgBox("输入的值 " & value.ToString & " 不在范围 [" & n.ToString & " , " & m.ToString & "] 内", "输入合法性检查：" & sender)
            Return RangeCut(value, n, m)
        End If
    End Function
    '输入合法性裁切
    Public Function RangeCut(x As Integer, n As Integer, m As Integer)
        If x < n Then
            Return n
        ElseIf x > m Then
            Return m
        Else
            Return x
        End If
    End Function
    '颜色转变（加阴影）
    Public Function ColorShadow(target As Color, Optional val As Integer = 20, Optional backwards As Boolean = False) As Color
        Dim r, g, b, rr, gg, bb As Integer
        r = target.R
        g = target.G
        b = target.B

        If backwards Then
            If r >= 125 Then
                rr = r + val
            Else
                rr = r - val
            End If
            If g >= 125 Then
                gg = g + val
            Else
                gg = g - val
            End If
            If b >= 125 Then
                bb = b + val
            Else
                bb = b - val
            End If
            Return Color.FromArgb(rr, gg, bb)
        Else
            If r >= 125 Then
                rr = r - val
            Else
                rr = r + val
            End If
            If g >= 125 Then
                gg = g - val
            Else
                gg = g + val
            End If
            If b >= 125 Then
                bb = b - val
            Else
                bb = b + val
            End If
            Return Color.FromArgb(rr, gg, bb)
        End If

    End Function
End Module
