Public Class Form1
    Public Sub New()
        InitializeComponent()

        GridControl1.RowCount = 10
        GridControl1.ColCount = 6
        GridControl1.ExcelLikeAlignment = True

        ' Fill first half of columns with numeric values
        For i As Integer = 1 To GridControl1.RowCount
            For j As Integer = 0 To GridControl1.ColCount \ 2
                GridControl1(i, j).CellValue = i + j
            Next
        Next

        ' Fill second half of columns with "Data"
        For i As Integer = 1 To GridControl1.RowCount
            For j As Integer = (GridControl1.ColCount \ 2) + 1 To GridControl1.ColCount
                GridControl1(i, j).CellValue = "Data"
            Next
        Next
    End Sub
End Class