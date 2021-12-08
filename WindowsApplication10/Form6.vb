Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lst As New List(Of String) From {"Pazartesi", "salı", "çarşamba", "perşembe", "cuma", "cumartesi", "pazar"}

        For Each item As String In lst
            ListBox1.Items.Add(item)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim gunler(6) As String
        Dim i As Integer
        gunler(0) = "Pazartesi"
        gunler(1) = "Salı"
        gunler(2) = "Çarşamba"
        gunler(3) = "Perşembe"
        gunler(4) = "Cuma"
        gunler(5) = "Cumartesi"
        gunler(6) = "Pazar"
        For i = 0 To 6
            ListBox2.Items.Add(gunler(i))
        Next i
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()

    End Sub
End Class