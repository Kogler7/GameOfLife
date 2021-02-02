Public Class frmMainSand
    Dim posX, posY As Integer
    Dim DefaultSandSize As Size = New Size(750, 750)
    Dim MinSandSize As Size = New Size(550, 350)
    Private Sub frmMainSand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '主题设置读取
        Present_Theme.Back_Color = My.Settings.Back_Color
        Present_Theme.Sand_Color = My.Settings.Sand_Color
        Present_Theme.Cell_Color = My.Settings.Cell_Color
        Call MainFormReset(DefaultSandSize)
        '重新定位
        Me.Left = Screen.PrimaryScreen.Bounds.Width / 2 - Me.Width / 2
        Me.Top = Screen.PrimaryScreen.Bounds.Height / 2 - Me.Height / 2
        Call MyOpacity()
    End Sub

    Public Sub MainFormReset(SandSize As Size)

        '窗口调整
        Me.BackColor = Present_Theme.Back_Color
        Me.ForeColor = Present_Theme.Cell_Color
        pctMainSand.BackColor = Present_Theme.Sand_Color

        'LayOut
        pctMainSand.Size = SandSize
        Me.Size = New Size(SandSize.Width + 40, SandSize.Height + 130)
        TimerGrpKeeper.Start()
    End Sub













    ''以下是控制区
    Dim OpacityShowards As Boolean = True
    Private Sub MyOpacity(Optional Closewards As Boolean = False)
        OpacityShowards = Not Closewards
        TimerOpacityController.Start()
    End Sub

    Private Sub TimerOpacityController_Tick(sender As Object, e As EventArgs) Handles TimerOpacityController.Tick
        Static opa As Single = 0
        If OpacityShowards Then
            If Me.Opacity <= 0.99 Then
                Me.Opacity += 0.07
            Else
                Me.Opacity = 1
                TimerOpacityController.Stop()
            End If
        Else
            If Me.Opacity >= 0.02 Then
                Me.Opacity -= 0.07
            Else
                Me.Opacity = 0.01
                TimerOpacityController.Stop()
                Me.Close()
            End If
        End If
    End Sub
    Dim Moveable As Boolean = False
    Private Sub MEMouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        posX = e.X
        posY = e.Y
        Moveable = True
    End Sub

    Private Sub MEMouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If Moveable = True Then
            Me.Left = Me.Left + e.X - posX
            Me.Top = Me.Top + e.Y - posY
        End If
    End Sub

    Private Sub MEMouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        Moveable = False
    End Sub
    Private Sub pctClose_Click(sender As Object, e As EventArgs) Handles pctClose.Click
        Call MyOpacity(Closewards:=True)
    End Sub

    Private Sub pctMini_Click(sender As Object, e As EventArgs) Handles pctMini.Click
        Me.WindowState = 1
    End Sub
    Public Sub FormPainter()
        Dim g As Graphics = Me.CreateGraphics
        Dim c As Graphics = pctClose.CreateGraphics
        Dim n As Graphics = pctMini.CreateGraphics
        Dim rec As New Rectangle
        Dim p As New Pen(Present_Theme.Cell_Color, 2)

        ''Form边框
        rec = Rectangle.FromLTRB(0, 0, Me.Width, Me.Height)
        g.DrawRectangle(p, rec)
        g.Dispose()
        ''CloseBox
        c.DrawLine(p, New Point(10, 10), New Point(26, 26))
        c.DrawLine(p, New Point(26, 10), New Point(10, 26))
        c.Dispose()
        ''MiniBox
        n.DrawLine(p, New Point(10, 18), New Point(26, 18))
        n.Dispose()
    End Sub
    Private Sub TimerGrpKeeper_Tick(sender As Object, e As EventArgs) Handles TimerGrpKeeper.Tick
        Call FormPainter()
        TimerGrpKeeper.Stop()
    End Sub

    Private Sub pct_MouseEnter(sender As Object, e As EventArgs) Handles pctClose.MouseEnter, pctMini.MouseEnter
        sender.BackColor = ColorShadow(sender.BackColor)
        TimerGrpKeeper.Start()
    End Sub

    Private Sub pct_MouseLeave(sender As Object, e As EventArgs) Handles pctClose.MouseLeave, pctMini.MouseLeave
        sender.BackColor = ColorShadow(sender.BackColor, backwards:=True)
        TimerGrpKeeper.Start()
    End Sub

    Private Sub lblSandReset_Click(sender As Object, e As EventArgs) Handles lblSandReset.Click

    End Sub

    Private Sub lblControlCenter_Click(sender As Object, e As EventArgs) Handles lblControlCenter.Click
        frmControl.Show()
    End Sub

    Private Sub lblThemeCenter_Click(sender As Object, e As EventArgs) Handles lblThemeCenter.Click
        ThemeCenter.Show()
    End Sub

    Private Sub lbl_MouseEnter(sender As Object, e As EventArgs) Handles lblSandReset.MouseEnter, lblControlCenter.MouseEnter, lblThemeCenter.MouseEnter
        sender.forecolor = Present_Theme.Sand_Color
    End Sub

    Private Sub lbl_MouseLeave(sender As Object, e As EventArgs) Handles lblSandReset.MouseLeave, lblControlCenter.MouseLeave, lblThemeCenter.MouseLeave
        sender.forecolor = Present_Theme.Cell_Color
    End Sub

    Private Sub frmMainSand_Move(sender As Object, e As EventArgs) Handles Me.Move
        TimerGrpKeeper.Start()
    End Sub
End Class