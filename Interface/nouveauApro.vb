Public Class nouveauApro
    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Me.Hide()
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.Hide()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Try
            Dim code = cd.Text
            Dim quantite = CType(qt.Text, Integer)
            Dim prix = CType(prx.Text, Double)

            GridProduit.Rows.Add(New String() {code, quantite, prix})
            cd.Text = " "
            qt.Text = " "
            prx.Text = " "
            ttl.Text.Equals(" ")
            If (ttl.Text.Equals(" ")) Then
                Dim total = prix * quantite
                ttl.Text = total + " "
            Else
                Dim ensTotal = CType(ttl.Text, Double)
                ensTotal = ensTotal + (prix * quantite)
                ttl.Text = ensTotal + " "
            End If

        Catch ex As Exception
            MessageBox.Show("Veullier entrer des valeurs valides SVP")
        End Try
    End Sub
End Class