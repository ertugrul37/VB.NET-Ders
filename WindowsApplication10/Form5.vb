Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim durum As Boolean
        Dim ortalama As Integer
        durum = InputBox("Not Ortalaması ")
        durum = ortalama >= 50
        If durum = True Then
            MsgBox("GEÇTİ")
        Else
            MsgBox("KALDI")
        End If

    End Sub
End Class