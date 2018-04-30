Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddRow(GRID1)
    End Sub
    Sub AddRow(GRID As DataGridView)
        Dim StringRow As String()

        StringRow = New String() {TextBox1.Text, TextBox2.Text}
        GRID.Rows.Add(StringRow)

        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
    Private Sub GRID1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GRID1.CellClick
        If e.RowIndex < 0 Then Exit Sub
        TextBox1.Text = GRID1.Rows(e.RowIndex).Cells("Column1").Value
        TextBox2.Text = GRID1.Rows(e.RowIndex).Cells("Column2").Value
    End Sub
End Class
