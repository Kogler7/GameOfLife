<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControl
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCellSize = New System.Windows.Forms.Label()
        Me.lblSandContain = New System.Windows.Forms.Label()
        Me.lblFreal = New System.Windows.Forms.Label()
        Me.lblFmax = New System.Windows.Forms.Label()
        Me.lblLivingNum = New System.Windows.Forms.Label()
        Me.lblLivingPercentage = New System.Windows.Forms.Label()
        Me.lblRefreshCounts = New System.Windows.Forms.Label()
        Me.gpbOptions = New System.Windows.Forms.GroupBox()
        Me.btnOption4 = New System.Windows.Forms.Button()
        Me.btnOption5 = New System.Windows.Forms.Button()
        Me.btnOption3 = New System.Windows.Forms.Button()
        Me.btnOption2 = New System.Windows.Forms.Button()
        Me.btnOption1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnFset = New System.Windows.Forms.Button()
        Me.btnSetSettle = New System.Windows.Forms.Button()
        Me.cmbFmax = New System.Windows.Forms.ComboBox()
        Me.cmbCellWidth = New System.Windows.Forms.ComboBox()
        Me.cmbCellAmounts = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbRdmGrpSize = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRdmSettle = New System.Windows.Forms.Button()
        Me.cmbRdmCells = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmbRdmGroups = New System.Windows.Forms.ComboBox()
        Me.palRdm = New System.Windows.Forms.Panel()
        Me.picRdm1 = New System.Windows.Forms.PictureBox()
        Me.picRdm2 = New System.Windows.Forms.PictureBox()
        Me.picRdm3 = New System.Windows.Forms.PictureBox()
        Me.picRdm4 = New System.Windows.Forms.PictureBox()
        Me.picRdm5 = New System.Windows.Forms.PictureBox()
        Me.picRdm6 = New System.Windows.Forms.PictureBox()
        Me.picRdm7 = New System.Windows.Forms.PictureBox()
        Me.picRdm8 = New System.Windows.Forms.PictureBox()
        Me.picRdm9 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnGetSeed = New System.Windows.Forms.Button()
        Me.btnSeedParser = New System.Windows.Forms.Button()
        Me.cmbSeedDisplay = New System.Windows.Forms.ComboBox()
        Me.picMobDisplay = New System.Windows.Forms.PictureBox()
        Me.btnReadIn = New System.Windows.Forms.Button()
        Me.btnSummon = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.gpbOptions.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.palRdm.SuspendLayout()
        CType(Me.picRdm1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRdm2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRdm3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRdm4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRdm5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRdm6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRdm7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRdm8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRdm9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.picMobDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCellSize)
        Me.GroupBox1.Controls.Add(Me.lblSandContain)
        Me.GroupBox1.Controls.Add(Me.lblFreal)
        Me.GroupBox1.Controls.Add(Me.lblFmax)
        Me.GroupBox1.Controls.Add(Me.lblLivingNum)
        Me.GroupBox1.Controls.Add(Me.lblLivingPercentage)
        Me.GroupBox1.Controls.Add(Me.lblRefreshCounts)
        Me.GroupBox1.Location = New System.Drawing.Point(170, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(385, 373)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "沙盘信息"
        '
        'lblCellSize
        '
        Me.lblCellSize.AutoSize = True
        Me.lblCellSize.Location = New System.Drawing.Point(47, 44)
        Me.lblCellSize.Name = "lblCellSize"
        Me.lblCellSize.Size = New System.Drawing.Size(219, 25)
        Me.lblCellSize.TabIndex = 1
        Me.lblCellSize.Tag = "1"
        Me.lblCellSize.Text = "细胞大小：10 X 10 像素"
        '
        'lblSandContain
        '
        Me.lblSandContain.AutoSize = True
        Me.lblSandContain.Location = New System.Drawing.Point(47, 75)
        Me.lblSandContain.Name = "lblSandContain"
        Me.lblSandContain.Size = New System.Drawing.Size(289, 25)
        Me.lblSandContain.TabIndex = 2
        Me.lblSandContain.Tag = "2"
        Me.lblSandContain.Text = "沙盘容纳量：64 X 64 = 4096 个"
        '
        'lblFreal
        '
        Me.lblFreal.AutoSize = True
        Me.lblFreal.Location = New System.Drawing.Point(47, 153)
        Me.lblFreal.Name = "lblFreal"
        Me.lblFreal.Size = New System.Drawing.Size(170, 25)
        Me.lblFreal.TabIndex = 4
        Me.lblFreal.Tag = "4"
        Me.lblFreal.Text = "实际帧率：3 帧/秒"
        '
        'lblFmax
        '
        Me.lblFmax.AutoSize = True
        Me.lblFmax.Location = New System.Drawing.Point(47, 110)
        Me.lblFmax.Name = "lblFmax"
        Me.lblFmax.Size = New System.Drawing.Size(181, 25)
        Me.lblFmax.TabIndex = 3
        Me.lblFmax.Tag = "3"
        Me.lblFmax.Text = "最高帧率：20 帧/秒"
        '
        'lblLivingNum
        '
        Me.lblLivingNum.AutoSize = True
        Me.lblLivingNum.Location = New System.Drawing.Point(47, 194)
        Me.lblLivingNum.Name = "lblLivingNum"
        Me.lblLivingNum.Size = New System.Drawing.Size(181, 25)
        Me.lblLivingNum.TabIndex = 5
        Me.lblLivingNum.Tag = "5"
        Me.lblLivingNum.Text = "存活细胞数量：0 个"
        '
        'lblLivingPercentage
        '
        Me.lblLivingPercentage.AutoSize = True
        Me.lblLivingPercentage.Location = New System.Drawing.Point(47, 223)
        Me.lblLivingPercentage.Name = "lblLivingPercentage"
        Me.lblLivingPercentage.Size = New System.Drawing.Size(135, 25)
        Me.lblLivingPercentage.TabIndex = 6
        Me.lblLivingPercentage.Tag = "6"
        Me.lblLivingPercentage.Text = "存活占比：0%"
        '
        'lblRefreshCounts
        '
        Me.lblRefreshCounts.AutoSize = True
        Me.lblRefreshCounts.Location = New System.Drawing.Point(47, 259)
        Me.lblRefreshCounts.Name = "lblRefreshCounts"
        Me.lblRefreshCounts.Size = New System.Drawing.Size(156, 25)
        Me.lblRefreshCounts.TabIndex = 7
        Me.lblRefreshCounts.Tag = "7"
        Me.lblRefreshCounts.Text = "累积刷新次数：0"
        '
        'gpbOptions
        '
        Me.gpbOptions.Controls.Add(Me.btnOption4)
        Me.gpbOptions.Controls.Add(Me.btnOption5)
        Me.gpbOptions.Controls.Add(Me.btnOption3)
        Me.gpbOptions.Controls.Add(Me.btnOption2)
        Me.gpbOptions.Controls.Add(Me.btnOption1)
        Me.gpbOptions.Location = New System.Drawing.Point(8, 20)
        Me.gpbOptions.Name = "gpbOptions"
        Me.gpbOptions.Size = New System.Drawing.Size(155, 372)
        Me.gpbOptions.TabIndex = 0
        Me.gpbOptions.TabStop = False
        Me.gpbOptions.Text = "Options"
        '
        'btnOption4
        '
        Me.btnOption4.Location = New System.Drawing.Point(24, 223)
        Me.btnOption4.Name = "btnOption4"
        Me.btnOption4.Size = New System.Drawing.Size(106, 48)
        Me.btnOption4.TabIndex = 4
        Me.btnOption4.Text = "召唤模式"
        Me.btnOption4.UseVisualStyleBackColor = True
        '
        'btnOption5
        '
        Me.btnOption5.Location = New System.Drawing.Point(24, 283)
        Me.btnOption5.Name = "btnOption5"
        Me.btnOption5.Size = New System.Drawing.Size(106, 48)
        Me.btnOption5.TabIndex = 5
        Me.btnOption5.Text = "相关信息"
        Me.btnOption5.UseVisualStyleBackColor = True
        '
        'btnOption3
        '
        Me.btnOption3.Location = New System.Drawing.Point(24, 164)
        Me.btnOption3.Name = "btnOption3"
        Me.btnOption3.Size = New System.Drawing.Size(106, 48)
        Me.btnOption3.TabIndex = 3
        Me.btnOption3.Text = "随机生成"
        Me.btnOption3.UseVisualStyleBackColor = True
        '
        'btnOption2
        '
        Me.btnOption2.Location = New System.Drawing.Point(24, 102)
        Me.btnOption2.Name = "btnOption2"
        Me.btnOption2.Size = New System.Drawing.Size(106, 48)
        Me.btnOption2.TabIndex = 2
        Me.btnOption2.Text = "沙盘设置"
        Me.btnOption2.UseVisualStyleBackColor = True
        '
        'btnOption1
        '
        Me.btnOption1.Location = New System.Drawing.Point(24, 40)
        Me.btnOption1.Name = "btnOption1"
        Me.btnOption1.Size = New System.Drawing.Size(106, 48)
        Me.btnOption1.TabIndex = 1
        Me.btnOption1.Text = "沙盘信息"
        Me.btnOption1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnFset)
        Me.GroupBox2.Controls.Add(Me.btnSetSettle)
        Me.GroupBox2.Controls.Add(Me.cmbFmax)
        Me.GroupBox2.Controls.Add(Me.cmbCellWidth)
        Me.GroupBox2.Controls.Add(Me.cmbCellAmounts)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(561, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(385, 373)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "沙盘设置"
        Me.GroupBox2.Visible = False
        '
        'btnFset
        '
        Me.btnFset.Location = New System.Drawing.Point(63, 259)
        Me.btnFset.Name = "btnFset"
        Me.btnFset.Size = New System.Drawing.Size(271, 40)
        Me.btnFset.TabIndex = 10
        Me.btnFset.Text = "更改帧率限制"
        Me.btnFset.UseVisualStyleBackColor = True
        '
        'btnSetSettle
        '
        Me.btnSetSettle.Location = New System.Drawing.Point(63, 152)
        Me.btnSetSettle.Name = "btnSetSettle"
        Me.btnSetSettle.Size = New System.Drawing.Size(271, 40)
        Me.btnSetSettle.TabIndex = 5
        Me.btnSetSettle.Text = "应用设置并重置"
        Me.btnSetSettle.UseVisualStyleBackColor = True
        '
        'cmbFmax
        '
        Me.cmbFmax.FormattingEnabled = True
        Me.cmbFmax.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "10", "15", "20", "25", "30", "35", "40", "45", "50"})
        Me.cmbFmax.Location = New System.Drawing.Point(132, 206)
        Me.cmbFmax.Name = "cmbFmax"
        Me.cmbFmax.Size = New System.Drawing.Size(102, 33)
        Me.cmbFmax.TabIndex = 9
        Me.cmbFmax.Text = "3"
        '
        'cmbCellWidth
        '
        Me.cmbCellWidth.FormattingEnabled = True
        Me.cmbCellWidth.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "20", "25"})
        Me.cmbCellWidth.Location = New System.Drawing.Point(132, 102)
        Me.cmbCellWidth.Name = "cmbCellWidth"
        Me.cmbCellWidth.Size = New System.Drawing.Size(102, 33)
        Me.cmbCellWidth.TabIndex = 8
        Me.cmbCellWidth.Text = "12"
        '
        'cmbCellAmounts
        '
        Me.cmbCellAmounts.FormattingEnabled = True
        Me.cmbCellAmounts.Items.AddRange(New Object() {"10", "20", "50", "64", "75", "100", "125", "150", "200"})
        Me.cmbCellAmounts.Location = New System.Drawing.Point(132, 44)
        Me.cmbCellAmounts.Name = "cmbCellAmounts"
        Me.cmbCellAmounts.Size = New System.Drawing.Size(102, 33)
        Me.cmbCellAmounts.TabIndex = 7
        Me.cmbCellAmounts.Text = "64"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(240, 212)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(114, 25)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "帧/秒 [1,50]"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(240, 109)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 25)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "像素 [1,25]"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(240, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(136, 25)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "个/行 [10,200]"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(38, 209)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 25)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "最大帧率"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(38, 105)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 25)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "细胞宽度"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "细胞数量"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbRdmGrpSize)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.btnRdmSettle)
        Me.GroupBox3.Controls.Add(Me.cmbRdmCells)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.cmbRdmGroups)
        Me.GroupBox3.Controls.Add(Me.palRdm)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(952, 20)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(385, 373)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "随机生成"
        Me.GroupBox3.Visible = False
        '
        'cmbRdmGrpSize
        '
        Me.cmbRdmGrpSize.FormattingEnabled = True
        Me.cmbRdmGrpSize.Items.AddRange(New Object() {"4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        Me.cmbRdmGrpSize.Location = New System.Drawing.Point(248, 215)
        Me.cmbRdmGrpSize.Name = "cmbRdmGrpSize"
        Me.cmbRdmGrpSize.Size = New System.Drawing.Size(121, 33)
        Me.cmbRdmGrpSize.TabIndex = 8
        Me.cmbRdmGrpSize.Text = "6"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(261, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "群落大小"
        '
        'btnRdmSettle
        '
        Me.btnRdmSettle.Location = New System.Drawing.Point(20, 279)
        Me.btnRdmSettle.Name = "btnRdmSettle"
        Me.btnRdmSettle.Size = New System.Drawing.Size(340, 52)
        Me.btnRdmSettle.TabIndex = 6
        Me.btnRdmSettle.Text = "确认生成"
        Me.btnRdmSettle.UseVisualStyleBackColor = True
        '
        'cmbRdmCells
        '
        Me.cmbRdmCells.FormattingEnabled = True
        Me.cmbRdmCells.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbRdmCells.Location = New System.Drawing.Point(248, 142)
        Me.cmbRdmCells.Name = "cmbRdmCells"
        Me.cmbRdmCells.Size = New System.Drawing.Size(121, 33)
        Me.cmbRdmCells.TabIndex = 6
        Me.cmbRdmCells.Text = "5"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(261, 114)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 25)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "细胞密度"
        '
        'cmbRdmGroups
        '
        Me.cmbRdmGroups.FormattingEnabled = True
        Me.cmbRdmGroups.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cmbRdmGroups.Location = New System.Drawing.Point(248, 68)
        Me.cmbRdmGroups.Name = "cmbRdmGroups"
        Me.cmbRdmGroups.Size = New System.Drawing.Size(121, 33)
        Me.cmbRdmGroups.TabIndex = 4
        Me.cmbRdmGroups.Text = "3"
        '
        'palRdm
        '
        Me.palRdm.Controls.Add(Me.picRdm1)
        Me.palRdm.Controls.Add(Me.picRdm2)
        Me.palRdm.Controls.Add(Me.picRdm3)
        Me.palRdm.Controls.Add(Me.picRdm4)
        Me.palRdm.Controls.Add(Me.picRdm5)
        Me.palRdm.Controls.Add(Me.picRdm6)
        Me.palRdm.Controls.Add(Me.picRdm7)
        Me.palRdm.Controls.Add(Me.picRdm8)
        Me.palRdm.Controls.Add(Me.picRdm9)
        Me.palRdm.Location = New System.Drawing.Point(17, 35)
        Me.palRdm.Name = "palRdm"
        Me.palRdm.Size = New System.Drawing.Size(215, 214)
        Me.palRdm.TabIndex = 3
        '
        'picRdm1
        '
        Me.picRdm1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picRdm1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picRdm1.Location = New System.Drawing.Point(3, 3)
        Me.picRdm1.Name = "picRdm1"
        Me.picRdm1.Size = New System.Drawing.Size(65, 65)
        Me.picRdm1.TabIndex = 1
        Me.picRdm1.TabStop = False
        Me.picRdm1.Tag = "1"
        '
        'picRdm2
        '
        Me.picRdm2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picRdm2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picRdm2.Location = New System.Drawing.Point(74, 3)
        Me.picRdm2.Name = "picRdm2"
        Me.picRdm2.Size = New System.Drawing.Size(65, 65)
        Me.picRdm2.TabIndex = 2
        Me.picRdm2.TabStop = False
        Me.picRdm2.Tag = "2"
        '
        'picRdm3
        '
        Me.picRdm3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picRdm3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picRdm3.Location = New System.Drawing.Point(145, 3)
        Me.picRdm3.Name = "picRdm3"
        Me.picRdm3.Size = New System.Drawing.Size(65, 65)
        Me.picRdm3.TabIndex = 3
        Me.picRdm3.TabStop = False
        Me.picRdm3.Tag = "3"
        '
        'picRdm4
        '
        Me.picRdm4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picRdm4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picRdm4.Location = New System.Drawing.Point(3, 74)
        Me.picRdm4.Name = "picRdm4"
        Me.picRdm4.Size = New System.Drawing.Size(65, 65)
        Me.picRdm4.TabIndex = 4
        Me.picRdm4.TabStop = False
        Me.picRdm4.Tag = "4"
        '
        'picRdm5
        '
        Me.picRdm5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picRdm5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picRdm5.Location = New System.Drawing.Point(74, 74)
        Me.picRdm5.Name = "picRdm5"
        Me.picRdm5.Size = New System.Drawing.Size(65, 65)
        Me.picRdm5.TabIndex = 5
        Me.picRdm5.TabStop = False
        Me.picRdm5.Tag = "5"
        '
        'picRdm6
        '
        Me.picRdm6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picRdm6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picRdm6.Location = New System.Drawing.Point(145, 74)
        Me.picRdm6.Name = "picRdm6"
        Me.picRdm6.Size = New System.Drawing.Size(65, 65)
        Me.picRdm6.TabIndex = 6
        Me.picRdm6.TabStop = False
        Me.picRdm6.Tag = "6"
        '
        'picRdm7
        '
        Me.picRdm7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picRdm7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picRdm7.Location = New System.Drawing.Point(3, 145)
        Me.picRdm7.Name = "picRdm7"
        Me.picRdm7.Size = New System.Drawing.Size(65, 65)
        Me.picRdm7.TabIndex = 7
        Me.picRdm7.TabStop = False
        Me.picRdm7.Tag = "7"
        '
        'picRdm8
        '
        Me.picRdm8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picRdm8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picRdm8.Location = New System.Drawing.Point(74, 145)
        Me.picRdm8.Name = "picRdm8"
        Me.picRdm8.Size = New System.Drawing.Size(65, 65)
        Me.picRdm8.TabIndex = 8
        Me.picRdm8.TabStop = False
        Me.picRdm8.Tag = "8"
        '
        'picRdm9
        '
        Me.picRdm9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picRdm9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picRdm9.Location = New System.Drawing.Point(145, 145)
        Me.picRdm9.Name = "picRdm9"
        Me.picRdm9.Size = New System.Drawing.Size(65, 65)
        Me.picRdm9.TabIndex = 9
        Me.picRdm9.TabStop = False
        Me.picRdm9.Tag = "9"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(261, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "群落密度"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnGetSeed)
        Me.GroupBox4.Controls.Add(Me.btnSeedParser)
        Me.GroupBox4.Controls.Add(Me.cmbSeedDisplay)
        Me.GroupBox4.Controls.Add(Me.picMobDisplay)
        Me.GroupBox4.Controls.Add(Me.btnReadIn)
        Me.GroupBox4.Controls.Add(Me.btnSummon)
        Me.GroupBox4.Location = New System.Drawing.Point(1343, 20)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(385, 373)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "召唤模式"
        '
        'btnGetSeed
        '
        Me.btnGetSeed.Location = New System.Drawing.Point(251, 187)
        Me.btnGetSeed.Name = "btnGetSeed"
        Me.btnGetSeed.Size = New System.Drawing.Size(115, 45)
        Me.btnGetSeed.TabIndex = 6
        Me.btnGetSeed.Text = "获取种子"
        Me.btnGetSeed.UseVisualStyleBackColor = True
        '
        'btnSeedParser
        '
        Me.btnSeedParser.Location = New System.Drawing.Point(251, 114)
        Me.btnSeedParser.Name = "btnSeedParser"
        Me.btnSeedParser.Size = New System.Drawing.Size(115, 45)
        Me.btnSeedParser.TabIndex = 5
        Me.btnSeedParser.Text = "种子解析"
        Me.btnSeedParser.UseVisualStyleBackColor = True
        '
        'cmbSeedDisplay
        '
        Me.cmbSeedDisplay.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.cmbSeedDisplay.FormattingEnabled = True
        Me.cmbSeedDisplay.Location = New System.Drawing.Point(24, 259)
        Me.cmbSeedDisplay.Name = "cmbSeedDisplay"
        Me.cmbSeedDisplay.Size = New System.Drawing.Size(342, 25)
        Me.cmbSeedDisplay.TabIndex = 4
        Me.cmbSeedDisplay.Text = "（请不要手动输入内容）"
        '
        'picMobDisplay
        '
        Me.picMobDisplay.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.picMobDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picMobDisplay.Location = New System.Drawing.Point(8, 35)
        Me.picMobDisplay.Name = "picMobDisplay"
        Me.picMobDisplay.Size = New System.Drawing.Size(223, 210)
        Me.picMobDisplay.TabIndex = 3
        Me.picMobDisplay.TabStop = False
        '
        'btnReadIn
        '
        Me.btnReadIn.Location = New System.Drawing.Point(251, 42)
        Me.btnReadIn.Name = "btnReadIn"
        Me.btnReadIn.Size = New System.Drawing.Size(115, 45)
        Me.btnReadIn.TabIndex = 1
        Me.btnReadIn.Text = "载入文件"
        Me.btnReadIn.UseVisualStyleBackColor = True
        '
        'btnSummon
        '
        Me.btnSummon.Location = New System.Drawing.Point(63, 303)
        Me.btnSummon.Name = "btnSummon"
        Me.btnSummon.Size = New System.Drawing.Size(259, 47)
        Me.btnSummon.TabIndex = 0
        Me.btnSummon.Text = "召唤"
        Me.btnSummon.UseVisualStyleBackColor = True
        '
        'frmControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1752, 399)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gpbOptions)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "frmControl"
        Me.Text = "控制中心"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gpbOptions.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.palRdm.ResumeLayout(False)
        CType(Me.picRdm1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRdm2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRdm3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRdm4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRdm5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRdm6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRdm7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRdm8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRdm9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.picMobDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblLivingPercentage As Label
    Friend WithEvents lblRefreshCounts As Label
    Friend WithEvents lblLivingNum As Label
    Friend WithEvents lblFreal As Label
    Friend WithEvents lblCellSize As Label
    Friend WithEvents lblSandContain As Label
    Friend WithEvents gpbOptions As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblFmax As Label
    Friend WithEvents cmbFmax As ComboBox
    Friend WithEvents cmbCellWidth As ComboBox
    Friend WithEvents cmbCellAmounts As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnSetSettle As Button
    Friend WithEvents btnRdmSettle As Button
    Friend WithEvents cmbRdmCells As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents cmbRdmGroups As ComboBox
    Friend WithEvents palRdm As Panel
    Friend WithEvents picRdm9 As PictureBox
    Friend WithEvents picRdm8 As PictureBox
    Friend WithEvents picRdm7 As PictureBox
    Friend WithEvents picRdm6 As PictureBox
    Friend WithEvents picRdm5 As PictureBox
    Friend WithEvents picRdm4 As PictureBox
    Friend WithEvents picRdm3 As PictureBox
    Friend WithEvents picRdm2 As PictureBox
    Friend WithEvents picRdm1 As PictureBox
    Friend WithEvents btnOption5 As Button
    Friend WithEvents btnOption3 As Button
    Friend WithEvents btnOption2 As Button
    Friend WithEvents btnOption1 As Button
    Friend WithEvents btnFset As Button
    Friend WithEvents cmbRdmGrpSize As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnOption4 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnSummon As Button
    Friend WithEvents picMobDisplay As PictureBox
    Friend WithEvents btnReadIn As Button
    Friend WithEvents btnGetSeed As Button
    Friend WithEvents btnSeedParser As Button
    Friend WithEvents cmbSeedDisplay As ComboBox
End Class
