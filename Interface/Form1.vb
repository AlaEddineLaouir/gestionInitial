Public Class Form1


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
        Dim btn As Bunifu.Framework.UI.BunifuFlatButton = CType(sender, Bunifu.Framework.UI.BunifuFlatButton)
        btn.BackColor = Color.LightGray

    End Sub

    Private Sub BunifuFlatButton3_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Command1.BringtoFront()
        Dim btn As Bunifu.Framework.UI.BunifuFlatButton = CType(sender, Bunifu.Framework.UI.BunifuFlatButton)
        btn.BackColor = Color.LightGray
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        Stock1.BringtoFront()
        Dim btn As Bunifu.Framework.UI.BunifuFlatButton = CType(sender, Bunifu.Framework.UI.BunifuFlatButton)
        btn.BackColor = Color.LightGray
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs)
        WindowState = FormWindowState.Maximized
    End Sub
End Class
