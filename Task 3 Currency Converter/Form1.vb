Public Class Form1
    Private Sub CurrenciesToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBox.SelectedIndexChanged

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cmbBox.SelectedIndex = 0 Then
            txtForeign.Text = txtAustralia.Text * 0.6524
        ElseIf cmbBox.SelectedIndex = 1 Then
            txtForeign.Text = txtAustralia.Text * 98.79
        ElseIf cmbBox.SelectedIndex = 2 Then
            txtForeign.Text = txtAustralia.Text * 0.5166
        End If


    End Sub
End Class
