Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As Integer
        a = Val(TextBox1.Text)
        b = 1
        For c = 1 To a
            b = b * c
        Next
        ListBox1.Items.Add(b)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
