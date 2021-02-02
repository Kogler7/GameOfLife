Public Class frmControl
    Private Sub frmControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''调整位置
        GroupBox2.Left = GroupBox1.Left
        GroupBox3.Left = GroupBox1.Left
        GroupBox4.Left = GroupBox1.Left
        Me.Width = GroupBox1.Right + 25
        ''Groupbox1
        For i As Integer = 1 To 6
            GroupBox1.Controls.Item(i).Top = GroupBox1.Controls.Item(i - 1).Bottom + 12
        Next

        'Call ShowingRefresh()
    End Sub

    ''模块选择
    Private Sub OptionsChanged(sender As Object, e As EventArgs) Handles btnOption1.Click, btnOption2.Click, btnOption3.Click, btnOption4.Click
        For Each grpb As GroupBox In Me.Controls
            If grpb.TabIndex = sender.tabindex Then
                grpb.Visible = True
            ElseIf grpb.TabIndex <> 0 Then
                grpb.Visible = False
            End If
        Next
    End Sub

    ''沙盘信息更新显示
    'Public Sub InforUpdate()
    '    Dim n As Integer = intCellAmounts
    '    Dim n2 As Integer = n ^ 2
    '    lblCellSize.Text = "细胞大小：" & intCellWidth.ToString & " X " & intCellWidth.ToString & " 像素"
    '    lblSandContain.Text = "沙盘容纳量 ： " & n.ToString & " X " & n.ToString & " = " & n2.ToString & " 个"
    '    lblFmax.Text = "最高帧率：" & intFmax.ToString & " 帧/秒"
    '    lblFreal.Text = "实际帧率：" & intFreal.ToString & " 帧/秒"
    '    lblLivingNum.Text = "存活细胞数量：" & intLivingNum.ToString & " 个"
    '    lblLivingPercentage.Text = "存活占比：" & Int((intLivingNum / n2) * 100).ToString & " %"
    '    lblRefreshCounts.Text = "累积刷新次数：" & intRefreshCounts.ToString
    'End Sub

    ''随机生成启动器
    'Private Sub btnRdmSettle_Click(sender As Object, e As EventArgs) Handles btnRdmSettle.Click
    '    If CMBchecker(cmbRdmGroups, 1, 6) And CMBchecker(cmbRdmCells, 1, 10) AndAlso CMBchecker(cmbRdmGrpSize, 4, Math.Min(15, intCellAmounts / 2)) Then
    '        For Each i As PictureBox In palRdm.Controls
    '            If isRdmChoosed(i.Tag - 1) = True Then Call frmSand.RdmSummon(i.Tag, Val(cmbRdmGroups.Text), Val(cmbRdmGrpSize.Text), Val(cmbRdmCells.Text))
    '        Next
    '    End If
    'End Sub


    ''控制中心显示刷新
    'Private Sub ShowingRefresh()
    '    ''RdmColor
    '    For Each i As PictureBox In palRdm.Controls
    '        If isRdmChoosed(i.Tag - 1) = False Then
    '            i.BackColor = DeadColor
    '        Else
    '            i.BackColor = LivingColor
    '        End If
    '    Next
    '    ''Texts
    '    cmbCellAmounts.Text = intCellAmounts.ToString
    '    cmbCellWidth.Text = intCellWidth.ToString
    '    cmbFmax.Text = intFmax.ToString
    'End Sub

    ''随机生成位置选择器
    Dim isRdmChoosed(8) As Boolean
    Private Sub picRdm_Click(sender As Object, e As EventArgs) Handles picRdm1.Click, picRdm2.Click, picRdm3.Click, picRdm4.Click, picRdm5.Click, picRdm6.Click, picRdm7.Click, picRdm8.Click, picRdm9.Click
        isRdmChoosed(sender.tag - 1) = Not isRdmChoosed(sender.tag - 1)
        'Call ShowingRefresh()
    End Sub

    ''相关信息
    Private Sub btnOption5_Click(sender As Object, e As EventArgs) Handles btnOption5.Click
        MsgBox(“基本操作：” _
               & vbCrLf & "     1.单击鼠标可以在鼠标停留位置生成一个细胞；" _
               & vbCrLf & "     2.双击鼠标可以杀死鼠标停留位置的细胞；" _
               & vbCrLf & "" _
               & vbCrLf & "基本设置：" _
               & vbCrLf & "     1.游戏默认的帧率为3，您也可以在（设置）中自行改变帧率限制，实际运行情况由电脑硬件决定；" _
               & vbCrLf & "     2.本游戏可以任意调节细胞容纳量和细胞大小，详情请移步（设置）；" _
               & vbCrLf & "     注：随着细胞容纳量和细胞大小的增大，本游戏对电脑硬件的要求将会增大，同时游戏的实际帧率也将不可避免地降低；" _
               & vbCrLf & "" _
               & vbCrLf & "本游戏提供细胞随机生成器，具体用法如下：" _
               & vbCrLf & "     1.在菜单栏中选定想要生成细胞群落的位置并输入相关参数；" _
               & vbCrLf & "     2.系统将会在你选定的位置附近随机选取一定数量的点作为细胞群落的中心；" _
               & vbCrLf & "     3.而后系统将会对每一个选定的细胞群落中心随机生成一个细胞群落；" _
               & vbCrLf & "     4.您可以限定该区域内细胞群落的数目以及每个细胞群落中所包含细胞的最大数目；" _
               & vbCrLf & "     5.您也可以限定每一个群落的大小；" _
               & vbCrLf & "" _
               & vbCrLf & "《生命的游戏》的规则如下：" _
               & vbCrLf & "     1． 如果一个细胞周围有3个细胞为生（一个细胞周围共有8个细胞），则该细胞为生；" _
               & vbCrLf & "     2． 如果一个细胞周围有2个细胞为生，则该细胞的生死状态保持不变；" _
               & vbCrLf & "     3． 在其它情况下，该细胞为死；" _
               & vbCrLf & "" _
               & vbCrLf & "其他：" _
               & vbCrLf & "                                       使用Visual Basic 2015 (VB.net) 编写；" _
               & vbCrLf & "" _
               & vbCrLf & "                                                版权所有，侵权必究。（笑" _
               , Title:="GameOfLife使用说明")
    End Sub

    ''设置应用
    Private Sub btnSetSettle_Click(sender As Object, e As EventArgs) Handles btnSetSettle.Click
        If CMBchecker(cmbCellAmounts, 1, 200) And CMBchecker(cmbCellWidth, 1, 25) Then
            MainSand.ReSize(New Size(Val(cmbCellAmounts.Text), Val(cmbCellAmounts.Text)), Val(cmbCellWidth.Text))
            'Call frmSand.Initialize()
        End If
    End Sub

    ''帧率设置
    Private Sub btnFset_Click(sender As Object, e As EventArgs) Handles btnFset.Click
        'intFmax = Val(cmbFmax.Text)
        'frmSand.TimerRefresh.Interval = 1000 / intFmax
        'Call InforUpdate()
    End Sub

    ''combobox输入合法性检查
    Private Function CMBchecker(e As ComboBox, a As Integer, b As Integer) As Boolean
        If Val(e.Text) >= a And Val(e.Text) <= b Then
            Return True
        Else
            MsgBox("Error,您输入的数值超出了预定界限，请输入合适的数值", Title:="非法数值！")
            Return False
        End If
    End Function

    '——————————————————————————————————————
    '———————————————— 召唤组 ——————————————————
    '——————————————————————————————————————
    Private Sub btnReadIn_Click(sender As Object, e As EventArgs) Handles btnReadIn.Click
        Call ParseSeedInput()
        cmbSeedDisplay.Items.Clear()
        If SeedMob.Length > 0 Then
            Try
                For i As Integer = 0 To SeedMob.Length - 1
                    cmbSeedDisplay.Items.Add(i.ToString & ")" & SeedMob(i).Infor)
                Next
            Catch ex As Exception
                MsgBox("展示栏更新失败: " & ex.Message)
            End Try
        End If
        MsgBox("种子载入成功！")
        cmbSeedDisplay.Text = cmbSeedDisplay.Items(0)
    End Sub

    Private Sub cmbSeedDisplay_TextChanged(sender As Object, e As EventArgs) Handles cmbSeedDisplay.TextChanged
        Try
            If Mid(cmbSeedDisplay.Text, 2, 1) = ")" Then
                Dim i As Integer = Asc(Mid(cmbSeedDisplay.Text, 1, 1)) - 48
                Summon_Mob = SeedMob(i)
            End If
        Catch ex As Exception
            MsgBox("信息格式非法" & ex.Message)
        End Try

        Try
            Dim g As Graphics = picMobDisplay.CreateGraphics
            g.Clear(picMobDisplay.BackColor)
            Dim recs(Summon_Mob.Height - 1, Summon_Mob.Width - 1) As Rectangle
            Dim intRecWidth As Integer = 20
            intRecWidth = Math.Min(picMobDisplay.Width / (Summon_Mob.Width * 1.3), picMobDisplay.Height / (Summon_Mob.Height * 1.3))
            Dim Px, Py As Integer
            Px = (picMobDisplay.Width - intRecWidth * Summon_Mob.Width) / 2 - 5
            Py = (picMobDisplay.Width - intRecWidth * Summon_Mob.Height) / 2 - 5

            For y As Integer = 0 To Summon_Mob.Height - 1
                For x As Integer = 0 To Summon_Mob.Width - 1
                    recs(y, x) = Rectangle.FromLTRB(intRecWidth * x + Px + 1, intRecWidth * y + Py + 1, intRecWidth * (x + 1) + Px, intRecWidth * (y + 1) + Py)
                    If Summon_Mob.Cells(y, x) Then
                        g.FillRectangle(New SolidBrush(Present_Theme.Cell_Color), recs(y, x))
                    Else
                        g.FillRectangle(New SolidBrush(Present_Theme.Sand_Color), recs(y, x))
                    End If
                Next
            Next
            g.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub btnSeedParser_Click(sender As Object, e As EventArgs) Handles btnSeedParser.Click
        Summon_Mob = New CellMobs("Slipper", InputBox("Seed:"), report:=True)
        'Call SummonStart()
    End Sub

    Private Sub btnGetSeed_Click(sender As Object, e As EventArgs) Handles btnGetSeed.Click

    End Sub

    Private Sub btnSummon_Click(sender As Object, e As EventArgs) Handles btnSummon.Click
        'Call SummonStart()
    End Sub

    '启动召唤
    'Private Sub SummonStart()
    '    '还原整个沙盘
    '    Call frmSand.CellDraw(intCellAmounts, intCellAmounts)
    '    ''开始运行
    '    '全局暂停
    '    If frmSand.TimerRefresh.Enabled Then
    '        Call frmSand.transState()
    '    End If
    '    frmSand.btnStart.Enabled = False
    '    '进入召唤模式
    '    OnSummon = True
    '    '启动
    '    frmSand.TimerSummon.Start()
    'End Sub

End Class