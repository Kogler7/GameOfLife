Public Class CellSandBox
    '——————————————————————
    '————————变量声明————————
    '——————————————————————
    '沙盘规格
    Protected sizSandSize As Size = New Size(32, 32)
    Protected intCellWidth As Integer = 12
    Protected Cell(sizSandSize.Height - 1, sizSandSize.Width - 1), newCell(sizSandSize.Height - 1, sizSandSize.Width - 1) As Boolean '（y,x）坐标系
    Protected recCell(sizSandSize.Width - 1, sizSandSize.Height - 1) As Rectangle
    '画板
    Protected bmpSand As Bitmap = New Bitmap(sizSandSize.Width * intCellWidth, sizSandSize.Height * intCellWidth) '内存细胞板
    Protected g_cellSand As Graphics = Graphics.FromImage(bmpSand)
    '画笔
    Protected Color_Living As Color = Color.White
    Protected Color_Dead As Color = Color.Black
    Protected Color_Focus As Color = Color.Wheat
    Protected LivingBrush As New SolidBrush(Color_Living)
    Protected DeadBrush As New SolidBrush(Color_Dead)
    Protected FocusBrush As New SolidBrush(Color_Focus)
    '——————————————————————
    '————————启动绘制————————
    '——————————————————————
    '内存绘制
    '初始化
    Public Overridable Sub InitializeSandImage()
        g_cellSand.Clear(DeadColor)
        For y As Integer = 0 To sizSandSize.Height - 1
            For x As Integer = 0 To sizSandSize.Width - 1
                ''细胞数据初始化
                Cell(y, x) = False
                ''细胞格初始化
                recCell(y, x) = Rectangle.FromLTRB(intCellWidth * x + 1, intCellWidth * y + 1, intCellWidth * (x + 1), intCellWidth * (y + 1))
                g_cellSand.FillRectangle(DeadBrush, recCell(y, x))
            Next
        Next
    End Sub
    '功能函数
    Public Sub ReSize(SandSize As Size, Optional CellWidth As Integer = 12)
        '规格数据更新
        sizSandSize = SandSize
        intCellWidth = CellWidth
        ReDim Cell(sizSandSize.Height - 1, sizSandSize.Width - 1), newCell(sizSandSize.Height - 1, sizSandSize.Width - 1)
        ReDim recCell(sizSandSize.Width - 1, sizSandSize.Height - 1)
        '重置内存画板
        bmpSand = New Bitmap(sizSandSize.Width * intCellWidth, sizSandSize.Height * intCellWidth)
        g_cellSand = Graphics.FromImage(bmpSand)
        g_cellSand.Clear(DeadColor)
        '修正细胞规格并重新绘制内存沙盘
        For j As Integer = 0 To sizSandSize.Height - 1
            For i As Integer = 0 To sizSandSize.Width - 1
                '修正细胞规格
                recCell(j, i) = Rectangle.FromLTRB(intCellWidth * i + 1, intCellWidth * j + 1, intCellWidth * (i + 1), intCellWidth * (j + 1))
                '重新绘制内存沙盘
                If Cell(j, i) Then
                    g_cellSand.FillRectangle(LivingBrush, recCell(j, i))
                Else
                    g_cellSand.FillRectangle(DeadBrush, recCell(j, i))
                End If
            Next
        Next
    End Sub




    '——————————————————————
    '————————属性更改————————
    '——————————————————————
    'New
    Public Sub New(sandsize As Size, Optional cellwidth As Integer = 12)
        ReSize(sandsize, cellwidth)
    End Sub
    '规格
    Public ReadOnly Property SandSize As Size
        Get
            Return sizSandSize
        End Get
    End Property
    '画笔颜色
    Public Property LivingColor As Color
        Set(value As Color)
            Color_Living = value
            LivingBrush.Color = value
        End Set
        Get
            Return Color_Living
        End Get
    End Property
    Public Property DeadColor As Color
        Set(value As Color)
            Color_Dead = value
            DeadBrush.Color = value
        End Set
        Get
            Return Color_Dead
        End Get
    End Property
    Public Property FocusColor As Color
        Set(value As Color)
            Color_Focus = value
            FocusBrush.Color = value
        End Set
        Get
            Return Color_Focus
        End Get
    End Property
    Public Property Name4 As Integer
        Set(value As Integer)

        End Set
        Get
            Return Nothing
        End Get
    End Property






End Class

Class MainSandCellsInfor
    Private _sandSize As Size
    Private Total As Integer = 100
    Public cellWidth = 12
    Public refreshCounts = 0
    Public livingNum = 0
    WriteOnly Property sandSize As Size
        Set(value As Size)
            _sandSize = value
            Total = value.Height * value.Width
        End Set
    End Property
    ReadOnly Property text_cellWidth As String
        Get
            Return "细胞大小：" & cellWidth.ToString & " X " & cellWidth.ToString & " 像素"
        End Get
    End Property
    ReadOnly Property text_sandSize As String
        Get
            Return "沙盘容纳量 ： " & _sandSize.Height.ToString & " X " & _sandSize.Width.ToString & " = " & Total.ToString & " 个"
        End Get
    End Property
    ReadOnly Property text_livingNum As String
        Get
            Return "存活细胞数量：" & livingNum.ToString & " 个"
        End Get
    End Property
    ReadOnly Property text_livingcellProportion As String
        Get
            Return "存活细胞占比：" & Int((livingNum / Total) * 100).ToString & " %"
        End Get
    End Property
End Class

Class MainCellSandBox
    Inherits CellSandBox
    '主沙盘信息
    Public Infor As MainSandCellsInfor
    Private OnSummon As Boolean = False
    Public Sub New(sandsize As Size, Optional cellwidth As Integer = 12)
        MyBase.New(sandsize, cellwidth)
    End Sub
    '初始化
    Public Overrides Sub InitializeSandImage()
        MyBase.InitializeSandImage()
        Infor.livingNum = 0
        Infor.refreshCounts = 0
        Infor.cellWidth = intCellWidth
        Infor.sandSize = sizSandSize
    End Sub

    '按照一定规则刷新沙盘上的细胞状态并绘制到内存细胞板中
    Public Sub UpdateFresh()
        Infor.livingNum = 0
        For j As Integer = 1 To sizSandSize.Height - 2
            For i As Integer = 1 To sizSandSize.Width - 2
                Dim Num As Integer = 0

                For y As Integer = j - 1 To j + 1
                    For x As Integer = i - 1 To i + 1
                        If Not (y = j And x = i) Then
                            If Cell(y, x) Then Num += 1
                        End If
                    Next
                Next

                If Num = 3 Then
                    newCell(j, i) = True
                ElseIf Num = 2 Then
                    newCell(j, i) = Cell(j, i)
                Else
                    newCell(j, i) = False
                End If

            Next
        Next

        '细胞数据更新
        For j As Integer = 0 To sizSandSize.Height - 1
            For i As Integer = 0 To sizSandSize.Width - 1
                Cell(j, i) = newCell(j, i)
            Next
        Next

        Call CellsDraw(sizSandSize.Width, sizSandSize.Height)

        Infor.refreshCounts += 1
    End Sub
    '在内存细胞沙盘上，以(px,py)为起点，绘制长为a，宽(高)为b的细胞群,可选择是否将绘制计入存活细胞总数
    Public Sub CellsDraw(a As Integer, b As Integer, Optional px As Integer = 0, Optional py As Integer = 0, Optional counting As Boolean = True) ''绘制并更新当前细胞沙盘
        Dim ry, rx As Integer
        '输入合法性检查
        RangeCheck(a, 1, sizSandSize.Width, "细胞群绘制")
        RangeCheck(b, 1, sizSandSize.Height, "细胞群绘制")
        ry = RangeCheck(py + b, py, sizSandSize.Height, "细胞群绘制")
        rx = RangeCheck(px + a, px, sizSandSize.Width, "细胞群绘制")
        For j As Integer = py To ry - 1
            For i As Integer = px To rx - 1
                If Cell(j, i) Then
                    g_cellSand.FillRectangle(LivingBrush, recCell(j, i))
                    If counting Then Infor.livingNum += 1
                Else
                    g_cellSand.FillRectangle(DeadBrush, recCell(j, i))
                End If
            Next
        Next
    End Sub

    '沙盘数据更新


End Class



Public Class CellMobs
    Private Mob_Name As String = ""
    Private Mob_W As Integer = 5
    Private Mob_H As Integer = 5
    Private Infortext As String = Nothing
    Public Cells(Mob_W - 1, Mob_H - 1) As Boolean
    Private PosNum() As Integer

    '只读属性
    Public ReadOnly Property Name As Integer
        Get
            Name = Mob_Name
        End Get
    End Property
    Public ReadOnly Property Width As Integer
        Get
            Width = Mob_W
        End Get
    End Property
    Public ReadOnly Property Height As Integer
        Get
            Height = Mob_H
        End Get
    End Property
    Public ReadOnly Property Infor As String
        Get
            Infor = Infortext
        End Get
    End Property


    '功能性构造函数
    Public Sub New(name As String, w As Integer, h As Integer, ParamArray poses As Integer())
        Mob_Name = name
        Mob_W = w
        Mob_H = h
        ReDim Cells(h - 1, w - 1)
        Infortext = name & ": (Pos) (" & w.ToString & "X" & h.ToString & ")"

        For Each n In poses
            Dim y As Integer = Math.Ceiling(n / Mob_W) - 1
            Dim x As Integer = n Mod Mob_W
            If x = 0 Then
                x = Mob_W - 1
            Else
                x -= 1
            End If

            Try
                Cells(y, x) = True
            Catch ex As Exception
                MsgBox("Mis")
            End Try
        Next
    End Sub
    Public Sub New(name As String, ParseSeed As String, Optional report As Boolean = False)
        Dim mob As CellMobs = SeedParseToMob(name, ParseSeed, report)
        Mob_Name = name
        Mob_W = mob.Width
        Mob_H = mob.Height
        ReDim Cells(Mob_H - 1, Mob_W - 1)
        Cells = mob.Cells
        Infortext = name & ": (" & Mob_W.ToString & "X" & Mob_H.ToString & ")" & ParseSeed
    End Sub

    '标准构造函数
    Public Sub New(name As String, w As Integer, h As Integer)
        Mob_Name = name
        Mob_W = w
        Mob_H = h
        ReDim Cells(h - 1, w - 1)
        Infortext = name & ": (" & w.ToString & "X" & h.ToString & ")"
    End Sub
End Class

