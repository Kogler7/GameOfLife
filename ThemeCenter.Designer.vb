<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ThemeCenter
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.grpDIY = New System.Windows.Forms.GroupBox()
        Me.CheckDIY = New System.Windows.Forms.CheckBox()
        Me.lblBlue = New System.Windows.Forms.Label()
        Me.lblGreen = New System.Windows.Forms.Label()
        Me.lblRed = New System.Windows.Forms.Label()
        Me.grpPreview = New System.Windows.Forms.GroupBox()
        Me.palPreview = New System.Windows.Forms.Panel()
        Me.numBlue = New System.Windows.Forms.NumericUpDown()
        Me.numGreen = New System.Windows.Forms.NumericUpDown()
        Me.numRed = New System.Windows.Forms.NumericUpDown()
        Me.ListBoxChoice = New System.Windows.Forms.ListBox()
        Me.grpTheme = New System.Windows.Forms.GroupBox()
        Me.palTheme6 = New System.Windows.Forms.Panel()
        Me.lblA6 = New System.Windows.Forms.Label()
        Me.palTheme5 = New System.Windows.Forms.Panel()
        Me.lblA5 = New System.Windows.Forms.Label()
        Me.palTheme4 = New System.Windows.Forms.Panel()
        Me.lblA4 = New System.Windows.Forms.Label()
        Me.palTheme2 = New System.Windows.Forms.Panel()
        Me.lblA2 = New System.Windows.Forms.Label()
        Me.palTheme3 = New System.Windows.Forms.Panel()
        Me.lblA3 = New System.Windows.Forms.Label()
        Me.palTheme1 = New System.Windows.Forms.Panel()
        Me.lblA1 = New System.Windows.Forms.Label()
        Me.lbl0 = New System.Windows.Forms.Label()
        Me.lblTheme6 = New System.Windows.Forms.Label()
        Me.lblTheme5 = New System.Windows.Forms.Label()
        Me.lblTheme4 = New System.Windows.Forms.Label()
        Me.lblTheme3 = New System.Windows.Forms.Label()
        Me.lblTheme2 = New System.Windows.Forms.Label()
        Me.lblTheme1 = New System.Windows.Forms.Label()
        Me.lblInfor1 = New System.Windows.Forms.Label()
        Me.grpDIY.SuspendLayout()
        Me.grpPreview.SuspendLayout()
        CType(Me.numBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numRed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTheme.SuspendLayout()
        Me.palTheme6.SuspendLayout()
        Me.palTheme5.SuspendLayout()
        Me.palTheme4.SuspendLayout()
        Me.palTheme2.SuspendLayout()
        Me.palTheme3.SuspendLayout()
        Me.palTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(205, 453)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(169, 42)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "取消"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnYes
        '
        Me.btnYes.Location = New System.Drawing.Point(205, 399)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(169, 42)
        Me.btnYes.TabIndex = 9
        Me.btnYes.Text = "完成"
        Me.btnYes.UseVisualStyleBackColor = True
        '
        'grpDIY
        '
        Me.grpDIY.Controls.Add(Me.CheckDIY)
        Me.grpDIY.Controls.Add(Me.lblBlue)
        Me.grpDIY.Controls.Add(Me.lblGreen)
        Me.grpDIY.Controls.Add(Me.lblRed)
        Me.grpDIY.Controls.Add(Me.numBlue)
        Me.grpDIY.Controls.Add(Me.numGreen)
        Me.grpDIY.Controls.Add(Me.numRed)
        Me.grpDIY.Controls.Add(Me.ListBoxChoice)
        Me.grpDIY.Location = New System.Drawing.Point(420, 80)
        Me.grpDIY.Name = "grpDIY"
        Me.grpDIY.Size = New System.Drawing.Size(328, 464)
        Me.grpDIY.TabIndex = 8
        Me.grpDIY.TabStop = False
        Me.grpDIY.Text = "主题设计器"
        '
        'CheckDIY
        '
        Me.CheckDIY.AutoSize = True
        Me.CheckDIY.Location = New System.Drawing.Point(70, 389)
        Me.CheckDIY.Name = "CheckDIY"
        Me.CheckDIY.Size = New System.Drawing.Size(175, 29)
        Me.CheckDIY.TabIndex = 10
        Me.CheckDIY.Text = "使用我的DIY主题"
        Me.CheckDIY.UseVisualStyleBackColor = True
        '
        'lblBlue
        '
        Me.lblBlue.AutoSize = True
        Me.lblBlue.ForeColor = System.Drawing.Color.Teal
        Me.lblBlue.Location = New System.Drawing.Point(229, 139)
        Me.lblBlue.Name = "lblBlue"
        Me.lblBlue.Size = New System.Drawing.Size(48, 25)
        Me.lblBlue.TabIndex = 9
        Me.lblBlue.Text = "Blue"
        '
        'lblGreen
        '
        Me.lblGreen.AutoSize = True
        Me.lblGreen.ForeColor = System.Drawing.Color.Green
        Me.lblGreen.Location = New System.Drawing.Point(120, 139)
        Me.lblGreen.Name = "lblGreen"
        Me.lblGreen.Size = New System.Drawing.Size(64, 25)
        Me.lblGreen.TabIndex = 8
        Me.lblGreen.Text = "Green"
        '
        'lblRed
        '
        Me.lblRed.AutoSize = True
        Me.lblRed.ForeColor = System.Drawing.Color.Red
        Me.lblRed.Location = New System.Drawing.Point(26, 139)
        Me.lblRed.Name = "lblRed"
        Me.lblRed.Size = New System.Drawing.Size(45, 25)
        Me.lblRed.TabIndex = 7
        Me.lblRed.Text = "Red"
        '
        'grpPreview
        '
        Me.grpPreview.Controls.Add(Me.palPreview)
        Me.grpPreview.Location = New System.Drawing.Point(30, 367)
        Me.grpPreview.Name = "grpPreview"
        Me.grpPreview.Size = New System.Drawing.Size(147, 141)
        Me.grpPreview.TabIndex = 6
        Me.grpPreview.TabStop = False
        Me.grpPreview.Text = "效果预览"
        '
        'palPreview
        '
        Me.palPreview.Location = New System.Drawing.Point(6, 32)
        Me.palPreview.Name = "palPreview"
        Me.palPreview.Size = New System.Drawing.Size(131, 96)
        Me.palPreview.TabIndex = 2
        '
        'numBlue
        '
        Me.numBlue.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numBlue.Location = New System.Drawing.Point(205, 103)
        Me.numBlue.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.numBlue.Name = "numBlue"
        Me.numBlue.Size = New System.Drawing.Size(90, 33)
        Me.numBlue.TabIndex = 5
        '
        'numGreen
        '
        Me.numGreen.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numGreen.Location = New System.Drawing.Point(106, 103)
        Me.numGreen.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.numGreen.Name = "numGreen"
        Me.numGreen.Size = New System.Drawing.Size(90, 33)
        Me.numGreen.TabIndex = 4
        '
        'numRed
        '
        Me.numRed.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numRed.Location = New System.Drawing.Point(6, 103)
        Me.numRed.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.numRed.Name = "numRed"
        Me.numRed.Size = New System.Drawing.Size(90, 33)
        Me.numRed.TabIndex = 3
        '
        'ListBoxChoice
        '
        Me.ListBoxChoice.FormattingEnabled = True
        Me.ListBoxChoice.ItemHeight = 25
        Me.ListBoxChoice.Items.AddRange(New Object() {"前景色(ForeColor)", "背景色(BackColor)", "高亮显示色(HighLightColor)"})
        Me.ListBoxChoice.Location = New System.Drawing.Point(6, 45)
        Me.ListBoxChoice.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListBoxChoice.Name = "ListBoxChoice"
        Me.ListBoxChoice.Size = New System.Drawing.Size(286, 29)
        Me.ListBoxChoice.TabIndex = 1
        '
        'grpTheme
        '
        Me.grpTheme.Controls.Add(Me.palTheme6)
        Me.grpTheme.Controls.Add(Me.palTheme5)
        Me.grpTheme.Controls.Add(Me.palTheme4)
        Me.grpTheme.Controls.Add(Me.palTheme2)
        Me.grpTheme.Controls.Add(Me.palTheme3)
        Me.grpTheme.Controls.Add(Me.palTheme1)
        Me.grpTheme.Controls.Add(Me.lbl0)
        Me.grpTheme.Controls.Add(Me.lblTheme6)
        Me.grpTheme.Controls.Add(Me.lblTheme5)
        Me.grpTheme.Controls.Add(Me.lblTheme4)
        Me.grpTheme.Controls.Add(Me.lblTheme3)
        Me.grpTheme.Controls.Add(Me.lblTheme2)
        Me.grpTheme.Controls.Add(Me.lblTheme1)
        Me.grpTheme.Location = New System.Drawing.Point(29, 80)
        Me.grpTheme.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpTheme.Name = "grpTheme"
        Me.grpTheme.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpTheme.Size = New System.Drawing.Size(350, 280)
        Me.grpTheme.TabIndex = 7
        Me.grpTheme.TabStop = False
        Me.grpTheme.Text = "所有主题"
        '
        'palTheme6
        '
        Me.palTheme6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.palTheme6.Controls.Add(Me.lblA6)
        Me.palTheme6.Location = New System.Drawing.Point(250, 160)
        Me.palTheme6.Name = "palTheme6"
        Me.palTheme6.Size = New System.Drawing.Size(65, 55)
        Me.palTheme6.TabIndex = 23
        '
        'lblA6
        '
        Me.lblA6.AutoSize = True
        Me.lblA6.Font = New System.Drawing.Font("微软雅黑 Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblA6.Location = New System.Drawing.Point(10, 4)
        Me.lblA6.Name = "lblA6"
        Me.lblA6.Size = New System.Drawing.Size(44, 46)
        Me.lblA6.TabIndex = 6
        Me.lblA6.Text = "A"
        '
        'palTheme5
        '
        Me.palTheme5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.palTheme5.Controls.Add(Me.lblA5)
        Me.palTheme5.Location = New System.Drawing.Point(140, 160)
        Me.palTheme5.Name = "palTheme5"
        Me.palTheme5.Size = New System.Drawing.Size(65, 55)
        Me.palTheme5.TabIndex = 22
        '
        'lblA5
        '
        Me.lblA5.AutoSize = True
        Me.lblA5.Font = New System.Drawing.Font("微软雅黑 Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblA5.Location = New System.Drawing.Point(10, 4)
        Me.lblA5.Name = "lblA5"
        Me.lblA5.Size = New System.Drawing.Size(44, 46)
        Me.lblA5.TabIndex = 5
        Me.lblA5.Text = "A"
        '
        'palTheme4
        '
        Me.palTheme4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.palTheme4.Controls.Add(Me.lblA4)
        Me.palTheme4.Location = New System.Drawing.Point(30, 160)
        Me.palTheme4.Name = "palTheme4"
        Me.palTheme4.Size = New System.Drawing.Size(65, 55)
        Me.palTheme4.TabIndex = 21
        '
        'lblA4
        '
        Me.lblA4.AutoSize = True
        Me.lblA4.Font = New System.Drawing.Font("微软雅黑 Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblA4.Location = New System.Drawing.Point(10, 4)
        Me.lblA4.Name = "lblA4"
        Me.lblA4.Size = New System.Drawing.Size(44, 46)
        Me.lblA4.TabIndex = 4
        Me.lblA4.Text = "A"
        '
        'palTheme2
        '
        Me.palTheme2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.palTheme2.Controls.Add(Me.lblA2)
        Me.palTheme2.Location = New System.Drawing.Point(140, 45)
        Me.palTheme2.Name = "palTheme2"
        Me.palTheme2.Size = New System.Drawing.Size(65, 55)
        Me.palTheme2.TabIndex = 20
        '
        'lblA2
        '
        Me.lblA2.AutoSize = True
        Me.lblA2.Font = New System.Drawing.Font("微软雅黑 Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblA2.Location = New System.Drawing.Point(10, 4)
        Me.lblA2.Name = "lblA2"
        Me.lblA2.Size = New System.Drawing.Size(44, 46)
        Me.lblA2.TabIndex = 2
        Me.lblA2.Text = "A"
        '
        'palTheme3
        '
        Me.palTheme3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.palTheme3.Controls.Add(Me.lblA3)
        Me.palTheme3.Location = New System.Drawing.Point(250, 45)
        Me.palTheme3.Name = "palTheme3"
        Me.palTheme3.Size = New System.Drawing.Size(65, 55)
        Me.palTheme3.TabIndex = 19
        '
        'lblA3
        '
        Me.lblA3.AutoSize = True
        Me.lblA3.Font = New System.Drawing.Font("微软雅黑 Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblA3.Location = New System.Drawing.Point(10, 4)
        Me.lblA3.Name = "lblA3"
        Me.lblA3.Size = New System.Drawing.Size(44, 46)
        Me.lblA3.TabIndex = 3
        Me.lblA3.Text = "A"
        '
        'palTheme1
        '
        Me.palTheme1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.palTheme1.Controls.Add(Me.lblA1)
        Me.palTheme1.Location = New System.Drawing.Point(30, 45)
        Me.palTheme1.Name = "palTheme1"
        Me.palTheme1.Size = New System.Drawing.Size(65, 55)
        Me.palTheme1.TabIndex = 6
        '
        'lblA1
        '
        Me.lblA1.AutoSize = True
        Me.lblA1.Font = New System.Drawing.Font("微软雅黑 Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblA1.Location = New System.Drawing.Point(10, 4)
        Me.lblA1.Name = "lblA1"
        Me.lblA1.Size = New System.Drawing.Size(44, 46)
        Me.lblA1.TabIndex = 1
        Me.lblA1.Text = "A"
        '
        'lbl0
        '
        Me.lbl0.AutoSize = True
        Me.lbl0.Location = New System.Drawing.Point(544, 30)
        Me.lbl0.Name = "lbl0"
        Me.lbl0.Size = New System.Drawing.Size(0, 25)
        Me.lbl0.TabIndex = 18
        '
        'lblTheme6
        '
        Me.lblTheme6.AutoSize = True
        Me.lblTheme6.Location = New System.Drawing.Point(240, 225)
        Me.lblTheme6.Name = "lblTheme6"
        Me.lblTheme6.Size = New System.Drawing.Size(89, 25)
        Me.lblTheme6.TabIndex = 11
        Me.lblTheme6.Text = "Eggplant"
        '
        'lblTheme5
        '
        Me.lblTheme5.AutoSize = True
        Me.lblTheme5.Location = New System.Drawing.Point(135, 225)
        Me.lblTheme5.Name = "lblTheme5"
        Me.lblTheme5.Size = New System.Drawing.Size(75, 25)
        Me.lblTheme5.TabIndex = 10
        Me.lblTheme5.Text = "Banana"
        '
        'lblTheme4
        '
        Me.lblTheme4.AutoSize = True
        Me.lblTheme4.Location = New System.Drawing.Point(32, 225)
        Me.lblTheme4.Name = "lblTheme4"
        Me.lblTheme4.Size = New System.Drawing.Size(63, 25)
        Me.lblTheme4.TabIndex = 9
        Me.lblTheme4.Text = "Peach"
        '
        'lblTheme3
        '
        Me.lblTheme3.AutoSize = True
        Me.lblTheme3.Location = New System.Drawing.Point(252, 110)
        Me.lblTheme3.Name = "lblTheme3"
        Me.lblTheme3.Size = New System.Drawing.Size(63, 25)
        Me.lblTheme3.TabIndex = 8
        Me.lblTheme3.Text = "Apple"
        '
        'lblTheme2
        '
        Me.lblTheme2.AutoSize = True
        Me.lblTheme2.Location = New System.Drawing.Point(145, 110)
        Me.lblTheme2.Name = "lblTheme2"
        Me.lblTheme2.Size = New System.Drawing.Size(55, 25)
        Me.lblTheme2.TabIndex = 7
        Me.lblTheme2.Text = "Black"
        '
        'lblTheme1
        '
        Me.lblTheme1.AutoSize = True
        Me.lblTheme1.Location = New System.Drawing.Point(32, 110)
        Me.lblTheme1.Name = "lblTheme1"
        Me.lblTheme1.Size = New System.Drawing.Size(61, 25)
        Me.lblTheme1.TabIndex = 6
        Me.lblTheme1.Text = "White"
        '
        'lblInfor1
        '
        Me.lblInfor1.AutoSize = True
        Me.lblInfor1.Font = New System.Drawing.Font("微软雅黑 Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblInfor1.Location = New System.Drawing.Point(23, 22)
        Me.lblInfor1.Name = "lblInfor1"
        Me.lblInfor1.Size = New System.Drawing.Size(274, 41)
        Me.lblInfor1.TabIndex = 6
        Me.lblInfor1.Text = "更改你的颜色设置"
        '
        'ThemeCenter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 530)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.grpDIY)
        Me.Controls.Add(Me.grpTheme)
        Me.Controls.Add(Me.grpPreview)
        Me.Controls.Add(Me.lblInfor1)
        Me.Font = New System.Drawing.Font("微软雅黑 Light", 14.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "ThemeCenter"
        Me.Text = "ThemeCenter"
        Me.grpDIY.ResumeLayout(False)
        Me.grpDIY.PerformLayout()
        Me.grpPreview.ResumeLayout(False)
        CType(Me.numBlue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numRed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTheme.ResumeLayout(False)
        Me.grpTheme.PerformLayout()
        Me.palTheme6.ResumeLayout(False)
        Me.palTheme6.PerformLayout()
        Me.palTheme5.ResumeLayout(False)
        Me.palTheme5.PerformLayout()
        Me.palTheme4.ResumeLayout(False)
        Me.palTheme4.PerformLayout()
        Me.palTheme2.ResumeLayout(False)
        Me.palTheme2.PerformLayout()
        Me.palTheme3.ResumeLayout(False)
        Me.palTheme3.PerformLayout()
        Me.palTheme1.ResumeLayout(False)
        Me.palTheme1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnYes As Button
    Friend WithEvents grpDIY As GroupBox
    Friend WithEvents CheckDIY As CheckBox
    Friend WithEvents lblBlue As Label
    Friend WithEvents lblGreen As Label
    Friend WithEvents lblRed As Label
    Friend WithEvents grpPreview As GroupBox
    Friend WithEvents palPreview As Panel
    Friend WithEvents numBlue As NumericUpDown
    Friend WithEvents numGreen As NumericUpDown
    Friend WithEvents numRed As NumericUpDown
    Friend WithEvents ListBoxChoice As ListBox
    Friend WithEvents grpTheme As GroupBox
    Friend WithEvents palTheme6 As Panel
    Friend WithEvents lblA6 As Label
    Friend WithEvents palTheme5 As Panel
    Friend WithEvents lblA5 As Label
    Friend WithEvents palTheme4 As Panel
    Friend WithEvents lblA4 As Label
    Friend WithEvents palTheme2 As Panel
    Friend WithEvents lblA2 As Label
    Friend WithEvents palTheme3 As Panel
    Friend WithEvents lblA3 As Label
    Friend WithEvents palTheme1 As Panel
    Friend WithEvents lblA1 As Label
    Friend WithEvents lbl0 As Label
    Friend WithEvents lblTheme6 As Label
    Friend WithEvents lblTheme5 As Label
    Friend WithEvents lblTheme4 As Label
    Friend WithEvents lblTheme3 As Label
    Friend WithEvents lblTheme2 As Label
    Friend WithEvents lblTheme1 As Label
    Friend WithEvents lblInfor1 As Label
End Class
