<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainSand
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
        Me.components = New System.ComponentModel.Container()
        Me.pctMainSand = New System.Windows.Forms.PictureBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblMainSandTitle = New System.Windows.Forms.Label()
        Me.pctClose = New System.Windows.Forms.PictureBox()
        Me.pctMini = New System.Windows.Forms.PictureBox()
        Me.lblSandReset = New System.Windows.Forms.Label()
        Me.lblControlCenter = New System.Windows.Forms.Label()
        Me.lblThemeCenter = New System.Windows.Forms.Label()
        Me.TimerGrpKeeper = New System.Windows.Forms.Timer(Me.components)
        Me.TimerOpacityController = New System.Windows.Forms.Timer(Me.components)
        Me.TimerRefresh = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pctMainSand, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctMini, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctMainSand
        '
        Me.pctMainSand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pctMainSand.Location = New System.Drawing.Point(20, 60)
        Me.pctMainSand.Name = "pctMainSand"
        Me.pctMainSand.Size = New System.Drawing.Size(560, 420)
        Me.pctMainSand.TabIndex = 1
        Me.pctMainSand.TabStop = False
        '
        'btnStart
        '
        Me.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnStart.Font = New System.Drawing.Font("微软雅黑 Light", 18.0!)
        Me.btnStart.Location = New System.Drawing.Point(67, 490)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(459, 48)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lblMainSandTitle
        '
        Me.lblMainSandTitle.AutoSize = True
        Me.lblMainSandTitle.Font = New System.Drawing.Font("微软雅黑 Light", 23.0!)
        Me.lblMainSandTitle.Location = New System.Drawing.Point(7, 12)
        Me.lblMainSandTitle.Name = "lblMainSandTitle"
        Me.lblMainSandTitle.Size = New System.Drawing.Size(245, 40)
        Me.lblMainSandTitle.TabIndex = 3
        Me.lblMainSandTitle.Text = "Game of Life 5.0"
        '
        'pctClose
        '
        Me.pctClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pctClose.Location = New System.Drawing.Point(552, 12)
        Me.pctClose.Name = "pctClose"
        Me.pctClose.Size = New System.Drawing.Size(36, 36)
        Me.pctClose.TabIndex = 4
        Me.pctClose.TabStop = False
        '
        'pctMini
        '
        Me.pctMini.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pctMini.Location = New System.Drawing.Point(510, 12)
        Me.pctMini.Name = "pctMini"
        Me.pctMini.Size = New System.Drawing.Size(36, 36)
        Me.pctMini.TabIndex = 5
        Me.pctMini.TabStop = False
        '
        'lblSandReset
        '
        Me.lblSandReset.AutoSize = True
        Me.lblSandReset.Location = New System.Drawing.Point(258, 27)
        Me.lblSandReset.Name = "lblSandReset"
        Me.lblSandReset.Size = New System.Drawing.Size(74, 21)
        Me.lblSandReset.TabIndex = 6
        Me.lblSandReset.Text = "重置沙盘"
        '
        'lblControlCenter
        '
        Me.lblControlCenter.AutoSize = True
        Me.lblControlCenter.Location = New System.Drawing.Point(338, 27)
        Me.lblControlCenter.Name = "lblControlCenter"
        Me.lblControlCenter.Size = New System.Drawing.Size(74, 21)
        Me.lblControlCenter.TabIndex = 7
        Me.lblControlCenter.Text = "控制中心"
        '
        'lblThemeCenter
        '
        Me.lblThemeCenter.AutoSize = True
        Me.lblThemeCenter.Location = New System.Drawing.Point(418, 27)
        Me.lblThemeCenter.Name = "lblThemeCenter"
        Me.lblThemeCenter.Size = New System.Drawing.Size(74, 21)
        Me.lblThemeCenter.TabIndex = 8
        Me.lblThemeCenter.Text = "更改主题"
        '
        'TimerGrpKeeper
        '
        Me.TimerGrpKeeper.Interval = 20
        '
        'TimerOpacityController
        '
        Me.TimerOpacityController.Interval = 20
        '
        'frmMainSand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 550)
        Me.Controls.Add(Me.lblThemeCenter)
        Me.Controls.Add(Me.lblControlCenter)
        Me.Controls.Add(Me.lblSandReset)
        Me.Controls.Add(Me.pctMini)
        Me.Controls.Add(Me.pctClose)
        Me.Controls.Add(Me.lblMainSandTitle)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.pctMainSand)
        Me.Font = New System.Drawing.Font("微软雅黑 Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMainSand"
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMainSand"
        CType(Me.pctMainSand, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctMini, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pctMainSand As PictureBox
    Friend WithEvents btnStart As Button
    Friend WithEvents lblMainSandTitle As Label
    Friend WithEvents pctClose As PictureBox
    Friend WithEvents pctMini As PictureBox
    Friend WithEvents lblSandReset As Label
    Friend WithEvents lblControlCenter As Label
    Friend WithEvents lblThemeCenter As Label
    Friend WithEvents TimerGrpKeeper As Timer
    Friend WithEvents TimerOpacityController As Timer
    Friend WithEvents TimerRefresh As Timer
End Class
