Imports MySql.Data.MySqlClient



Public Class profil

    Public idPersonne As Integer
    Public nomPer As String
    Public prenomPer As String
    Public adressePer As String
    Public telephonePre As String

    Public Sub afficher()
        nom.Text = nomPer
        prenom.Text = prenomPer
        telephone.Text = telephonePre
        adresse.Text = adressePer
    End Sub



    Private Sub BunifuImageButton1_Click_1(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        fermer()
    End Sub

    Private Sub BunifuThinButton21_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        fermer()
    End Sub
    Private Sub fermer()
        nom.Text = ""
        prenom.Text = ""
        telephone.Text = ""
        adresse.Text = ""
        Me.Hide()
    End Sub

    Private Sub modifier_Click(sender As Object, e As EventArgs) Handles modifier.Click
        If (nom.Equals(" ") Or prenom.Equals("") Or adresse.Equals(" ") Or
               telephone.Equals(" ")) Then
            MessageBox.Show("Alert", "Veuiller Bien remplit les Champs SVP")
        Else
            Dim cnx As MySqlConnection = New MySqlConnection
            cnx.ConnectionString = "server=localhost;userid=root;password=admin;database=gestionets"
            Dim query As String
            If (Titre.Text.Equals("Modifier Fournisseur")) Then
                query = "update fournisseur set nom='" + nom.Text + "' , prenom='" + prenom.Text + "' , telephone='" + telephone.Text + "' ,
                            adress= '" + adresse.Text + "' where id=" + idPersonne.ToString() + ""
            Else
                query = "update client set nom='" + nom.Text + "',prenom='" + prenom.Text + "',telephone='" + telephone.Text + "',
                            adress='" + adresse.Text + "' where id=" + idPersonne + ""
            End If
            Try
                cnx.Open()
                Dim command As New MySqlCommand(query, cnx)
                command.ExecuteNonQuery()
                cnx.Close()
            Catch ex As Exception
            Finally
                cnx.Dispose()
                fermer()
            End Try


        End If


    End Sub

    Private Sub ajouter_Click(sender As Object, e As EventArgs) Handles ajouter.Click
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
                Dim query As String
                If (Titre.Text.Equals("Ajouter Fournisseur")) Then
                    query = "insert into fournisseur (nom,prenom,adress,telephone) values ('" + four.nom +
                    "','" + four.prenom + "','" + four.adresse + "' ,'" + four.telephone.ToString() + "' );"
                Else
                    query = "insert into client (nom,prenom,adress,telephone) values ('" + four.nom +
                    "','" + four.prenom + "','" + four.adresse + "' ,'" + four.telephone.ToString() + "' );"
                End If
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
End Class