Public Class Form1
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        WindowState = FormWindowState.Minimized

    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Environment.Exit(0)

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        If (SidePanel.Width >= 232) Then
            logo.Location = New Point(1, 18)
            logo.Width = 46
            logo.Height = 48
            brandMax.Visible = False
            brandMin.Visible = True
            SidePanel.Width = 48
        Else
            logo.Location = New Point(55, 28)
            logo.Width = 123
            logo.Height = 72
            brandMax.Visible = True
            brandMin.Visible = False
            SidePanel.Width = 232

        End If
    End Sub

    Private Sub BunifuFlatButton2_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Vente1.BringToFront()

    End Sub

    Private Sub BunifuFlatButton3_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Command1.BringtoFront()
    End Sub
End Class
