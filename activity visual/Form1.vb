Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strNamaHari(6) As String
        Dim strOutput As String

        strNamaHari(0) = "Isnin"
        strNamaHari(1) = "Selasa"
        strNamaHari(2) = "Rabu"
        strNamaHari(3) = "Khamis"
        strNamaHari(4) = "Jumaat"
        strNamaHari(5) = "Sabtu"
        strNamaHari(6) = "Ahad"

        For count = 0 To 6
            strOutput = strNamaHari(count)
            ListBox1.Items.Add(strOutput)
        Next

    End Sub
End Class
