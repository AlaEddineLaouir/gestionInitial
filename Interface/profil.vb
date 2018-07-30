Imports MySql.Data.MySqlClient
Public Class profil
    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs)
        Dim four As FournisseurBean = New FournisseurBean
        four.nom = nom.Text
        four.prenom = prenom.Text
        four.telephone = telephone.Text
        four.adresse = adresse.Text

        If (four.nom.Equals(" ") Or four.prenom.Equals("") Or four.adresse.Equals(" ") Or
                four.telephone.Equals(" ")) Then
            MessageBox.Show("Alert", "Veuiller Bien remplit les Champs SVP")
        Else
            Dim cnx As MySqlConnection = New MySqlConnection
            cnx.ConnectionString = "server=localhost;userid=root;password=admin;database=gestionets"
            Dim reader As MySqlDataReader

            Try
                cnx.Open()
                Dim query As String = "insert into fournisseur (nom,prenom,adress,telephone) values ('" + four.nom +
                    "','" + four.prenom + "','" + four.adresse + "' ,'" + four.telephone.ToString() + "' );"
                Dim command As New MySqlCommand(query, cnx)
                reader = command.ExecuteReader
                cnx.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnx.Dispose()
            End Try
            Form1.Fournisseur1.refresh()
            Me.Hide()
        End If


    End Sub

    Private Sub BunifuImageButton1_Click_1(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        nom.Text = ""
        prenom.Text = ""
        telephone.Text = ""
        adresse.Text = ""
        Me.Hide()
    End Sub

    Private Sub BunifuThinButton21_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        nom.Text = ""
        prenom.Text = ""
        telephone.Text = ""
        adresse.Text = ""
        Me.Hide()
    End Sub
End Class