Public Class Principale


    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        WindowState = FormWindowState.Minimized

    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Try
            Environment.Exit(0)
        Catch ex As Exception

        End Try
    End Sub



    Private Sub BunifuFlatButton2_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Vente1.BringToFront()

    End Sub

    Private Sub BunifuFlatButton3_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click

    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        Stock1.refresh()
        Stock1.BringtoFront()
        Dim btn As Bunifu.Framework.UI.BunifuFlatButton = CType(sender, Bunifu.Framework.UI.BunifuFlatButton)
        btn.BackColor = Color.LightGray
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs)
        WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click
        Apro1.refresh()
        Apro1.BringToFront()
    End Sub

    Private Sub BunifuFlatButton8_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton8.Click
        Fournisseur1.refresh()
        Fournisseur1.BringToFront()
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        Client1.refresh()
        Client1.BringToFront()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Caisse1.refresh()
        Caisse1.BringToFront()
    End Sub
End Class
