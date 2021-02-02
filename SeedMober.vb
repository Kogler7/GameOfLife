Module SeedMober

    '文件读取与写入
    Public SeedMob() As CellMobs
    Public Sub ParseSeedInput()
        Dim Mob_File As New IO.FileStream(Application.StartupPath & "\Mobs.seed", IO.FileMode.OpenOrCreate)
        Dim RI As New IO.StreamReader(Mob_File)
        Dim lines() As String = RI.ReadToEnd.Split(vbCrLf)

        If lines.Length > 0 Then
            ReDim SeedMob(lines.Length - 1)
            For i As Integer = 0 To lines.Length - 1
                If lines(i).Split(":").Length = 2 Then
                    Dim strs() As String = lines(i).Split(":")
                    SeedMob(i) = New CellMobs(strs(0), strs(1))
                End If
            Next
        End If
        RI.Close()
        'MsgBox("读取完毕！")
    End Sub






    '种子解析板块
    Public Function ToParseSeed(width As Integer, height As Integer, seed_A As String) As String
        Return Nothing
    End Function

    Public Function SeedParseToMob(name As String, seed_C As String, Optional Report As Boolean = False) As CellMobs
        '输入合法性检查
        If Len(seed_C) < 5 Then
            MsgBox("种子输入非法")
            Return Summon_Mob
        End If

        Dim seed_B As String = ""
        Dim seed_A As String = ""
        Dim Flag As Boolean = False '首码
        Dim A, B, C As String '报告记录
        '解析mob尺寸
        Dim width, height As Integer
        width = GetStrOrMergeNum(Left(seed_C, 1))
        height = GetStrOrMergeNum(Mid(seed_C, 2, 1))
        Dim mob As New CellMobs(name, width, height)
        '解析首码
        If Asc(Mid(seed_C, 4, 1)) = 49 Then Flag = True
        C = seed_C
        seed_C = Mid(seed_C, 5) '剪切（包含分隔符"."）XX.1/0XXXXX
        '三级解析
        Try
            Do While Len(seed_C) > 0
                Dim x As String = Left(seed_C, 1) '取一个归并码
                seed_C = Mid(seed_C, 2)
                If Asc(x) >= 65 And Asc(x) <= 90 Then '当x为大写字母时，再向下读取一位数字
                    For i As Integer = 1 To GetStrOrMergeNum(x) '以该数字为副本，粘贴x的归并次
                        seed_B = seed_B & Left(seed_C, 1)
                    Next
                    seed_C = Mid(seed_C, 2)
                Else '当x为计数码时，直接追加
                    seed_B = seed_B & x
                End If
            Loop
        Catch ex As Exception
            MsgBox("三级解析错误")
        End Try
        '二级解析
        B = seed_B
        Try
            Dim x As Integer
            Do While Len(seed_B) > 0
                x = GetStrOrCotNum(Left(seed_B, 1)) '取一个计数码，并得到其码值
                For i As Integer = 1 To x
                    seed_A = seed_A & GetBooStr(Flag)
                Next
                Flag = Not Flag
                seed_B = Mid(seed_B, 2)
            Loop
        Catch ex As Exception
            MsgBox("二级解析错误")
        End Try
        '一级解析
        A = seed_A
        Try
            Dim n As Integer = 1
            For y As Integer = 0 To height - 1
                For x As Integer = 0 To width - 1
                    If Mid(seed_A, n, 1) = "1" Then
                        mob.Cells(y, x) = True
                    Else
                        mob.Cells(y, x) = False
                    End If
                    n += 1
                Next
            Next
        Catch ex As Exception
            MsgBox("一级解析错误")
        End Try
        '汇报板块
        If Report Then

            seed_A = A '转储一级种子
            Dim Snap As String = "|     "
            Do
                Snap = Snap & Left(A, width) & "     |" & vbCrLf & "|     "
                A = Mid(A, width + 1)
            Loop Until Len(A) = 0
            MsgBox("种子解析成功：解析成果如下" & vbCrLf &
                   "Mob名称：" & name & vbCrLf &
                   "长度：" & width.ToString & vbCrLf &
                   "宽度：" & height.ToString & vbCrLf &
                   "三级种子：" & C & vbCrLf &
                   "二级种子：" & B & vbCrLf &
                   "一级种子：" & seed_A & vbCrLf &
                   "示意图：" & vbCrLf & Snap & "注：1 代表细胞为生，0 则为死。")

        End If

        Return mob
    End Function

    Private Function GetBooStr(Boo As Boolean) As String
        If Boo Then
            Return "1"
        Else
            Return "0"
        End If
    End Function

    Private Function GetStrOrCotNum(Optional str As String = "a", Optional CotNum As Integer = 100)
        If str = "" And CotNum <> 100 Then
            '当输入计数码码值时
            Select Case CotNum
                Case 0 To 9
                    Return Chr(CotNum + 48)
                Case 10 To 35
                    Return Chr(CotNum + 87)
                Case Else
                    MsgBox("计数码码值非法")
                    Return "X"
            End Select
        ElseIf str <> "" And CotNum = 100 Then
            '当输入计数码时
            Dim chr As Integer = Asc(str)
            Select Case chr
                Case 48 To 57
                    chr -= 48
                Case 97 To 122
                    chr -= 87
                Case Else
                    MsgBox("计数码非法")
            End Select
            Return chr
        Else
            MsgBox("AscOrCotNum输入非法")
            Return Nothing
        End If
    End Function

    Private Function GetStrOrMergeNum(Optional str As String = "", Optional MergeNum As Integer = 100)
        If str = "" And MergeNum <> 100 Then
            '当输入归并码码值时
            If MergeNum >= 1 And MergeNum <= 26 Then
                Return Chr(MergeNum + 64)
            Else
                MsgBox("归并码码值非法")
                Return "X"
            End If
        ElseIf str <> "" And MergeNum = 100 Then
            '当输入归并码时
            Dim chr As Integer = Asc(str)
            If chr >= 65 And chr <= 90 Then
                Return chr - 64
            Else
                MsgBox("归并码非法")
                Return 0
            End If
        Else
            MsgBox("AscOrMergeNum输入非法")
            Return Nothing
        End If
    End Function

End Module
