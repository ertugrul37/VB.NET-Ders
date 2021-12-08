Public Class Form7
    Dim a, b, h As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        CVP.Text = (a * b / 2).ToString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        a = Val(TextBox1.Text)
        CVP.Text = (a * 3).ToString
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        a = Val(TextBox1.Text)
        h = Val(TextBox3.Text)
        CVP.Text = (a * h / 2).ToString
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        CVP.Text = (a * b).ToString
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        a = Val(TextBox1.Text)
        CVP.Text = (a * 4).ToString
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        a = Val(TextBox1.Text)
        CVP.Text = ((a + b) * 2).ToString
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        CVP.Text = ((a + b) * h / 2).ToString
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        a = Val(TextBox1.Text)
        CVP.Text = (a * a).ToString
    End Sub
End Class