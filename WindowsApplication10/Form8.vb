Public Class Form8
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a = (TextBox3.Text).ToString
        Dim s = Double.Parse(TextBox1.Text) * Double.Parse(TextBox2.Text)
        If CheckBox1.Checked = True Then
            s = s * (100 / 18)
        End If
        Label5.Text = a
        Label1.Text = s

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class