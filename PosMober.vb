Module PosMober


    Public Sub PosMobOutput()
        Dim Mob_File As New IO.FileStream(Application.StartupPath & "\Mobs.txt", IO.FileMode.OpenOrCreate)
        Dim WT As New IO.StreamWriter(Mob_File)
        WT.WriteLine("233")
        WT.Close()
    End Sub
    Public Function PosMobInput()
        Dim Mob_File As New IO.FileStream(Application.StartupPath & "\Mobs.txt", IO.FileMode.OpenOrCreate)
        Dim RI As New IO.StreamReader(Mob_File)
        Dim m(10) As CellMobs
        Do While RI.Peek() > 0
            Static n As Integer = 0
            Dim name As String
            Dim strArray1() As Integer
            'Dim strArray2() As Integer
            'Try
            name = RI.ReadLine
            strArray1 = getNum(RI.ReadLine.Split(","))
            'strArray2 = getNum(RI.ReadLine.Split(","))
            'Dim a(getNum(RI.ReadLine.Split(",")).Length + 1) As Integer
            'a = getNum(RI.ReadLine.Split(","))
            'For Each s In a
            '    MsgBox(s.ToString)
            'Next
            m(n) = New CellMobs(name, strArray1(0), strArray1(1), {1, 2, 3})
            MsgBox(m(n).Width.ToString & m(n).Height.ToString & m(n).Cells(0, 2).ToString)
            'Catch ex As Exception
            '    MsgBox("Error")
            'End Try
            n += 1
        Loop
        RI.Close()
        Return m
    End Function

    '坐标种子解析
    Public Function PosSeedToMob(name As String, w As Integer, h As Integer, ParamArray poses As Integer()) As CellMobs
        Dim mob As New CellMobs(name, w, h)
        For Each n In poses
            Dim y As Integer = Math.Ceiling(n / w) - 1
            Dim x As Integer = n Mod w
            If x = 0 Then
                x = w - 1
            Else
                x -= 1
            End If

            Try
                mob.Cells(y, x) = True
            Catch ex As Exception
                MsgBox("Mis")
            End Try
        Next
        Return mob
    End Function

    Private Function getNum(str() As String) As Integer()
        Dim x(str.Length - 1) As Integer
        Dim n As Integer = 0
        For Each a In str
            For i As Integer = 0 To 999
                Try
                    If i.ToString = a Then
                        x(n) = i
                        MsgBox("匹配" & a & "为" & x(n).ToString)
                        n += 1
                    End If
                Catch ex As Exception
                    MsgBox("数字强制转换出错")
                End Try
            Next
        Next
        For j As Integer = 0 To n - 1
            MsgBox(x(j).ToString)
        Next
        Return x
    End Function

End Module
