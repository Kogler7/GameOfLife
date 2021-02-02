Module mdlMain
    'Public LivingColor As Color = Color.White
    'Public DeadColor As Color = Color.Black

    'Public intCellAmounts As Integer = 64
    'Public intCellWidth As Integer = 12
    'Public Cell(intCellAmounts - 1, intCellAmounts - 1), newCell(intCellAmounts - 1, intCellAmounts - 1) As Boolean
    Public MainSand As MainCellSandBox = New MainCellSandBox(New Size(64, 64), 12)
    Public Structure Theme
        Public Theme_name As String
        Public Back_Color, Sand_Color, Cell_Color As Color
    End Structure
    Public Present_Theme, BuiltIn_Theme(5) As Theme
    'Public intRefreshCounts As Integer
    'Public intLivingNum As Integer
    'Public intFreal, Refresh_Counts As Integer
    'Public intFmax As Integer = 3

    'Public OnSummon As Boolean = False

    '标准mob
    Public Summon_Mob As New CellMobs("Slipper", 3, 3, {1, 5, 6, 7, 8})


End Module
