Public Class ThemeCenter
    Private Sub ThemeCenter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '内置主题
        ''White
        BuiltIn_Theme(0).Back_Color = Color.FromArgb(240, 240, 240)
        BuiltIn_Theme(0).Sand_Color = Color.FromArgb(0, 0, 0)
        BuiltIn_Theme(0).Cell_Color = Color.FromArgb(0, 0, 0)
        ''Black
        BuiltIn_Theme(1).Back_Color = Color.FromArgb(45, 45, 48)
        BuiltIn_Theme(1).Sand_Color = Color.FromArgb(255, 192, 192)
        BuiltIn_Theme(1).Cell_Color = Color.FromArgb(192, 192, 0)
        ''Apple
        BuiltIn_Theme(2).Back_Color = Color.FromArgb(242, 249, 237)
        BuiltIn_Theme(2).Sand_Color = Color.FromArgb(192, 64, 0)
        BuiltIn_Theme(2).Cell_Color = Color.FromArgb(0, 64, 0)
        ''Peach
        BuiltIn_Theme(3).Back_Color = Color.FromArgb(252, 238, 238)
        BuiltIn_Theme(3).Sand_Color = Color.FromArgb(255, 128, 128)
        BuiltIn_Theme(3).Cell_Color = Color.FromArgb(64, 0, 0)
        ''Banana
        BuiltIn_Theme(4).Back_Color = Color.FromArgb(254, 248, 230)
        BuiltIn_Theme(4).Sand_Color = Color.FromArgb(192, 192, 0)
        BuiltIn_Theme(4).Cell_Color = Color.FromArgb(64, 64, 0)
        ''Eggplant
        BuiltIn_Theme(5).Back_Color = Color.FromArgb(249, 241, 235)
        BuiltIn_Theme(5).Sand_Color = Color.FromArgb(128, 128, 255)
        BuiltIn_Theme(5).Cell_Color = Color.FromArgb(64, 0, 64)
    End Sub
End Class