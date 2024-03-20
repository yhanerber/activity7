Public Class Form1
    Private Sub txtbox1_TextChanged(sender As Object, e As EventArgs) Handles txtbox1.TextChanged
        Form2.Show()
        Me.Hide()

    End Sub
End Class
