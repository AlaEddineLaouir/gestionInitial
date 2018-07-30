Imports MySql.Data.MySqlClient

Public Class ajouterProduit

    Public codeProduit As String

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs)
        Try
            fermer()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs)
        Try
            fermer()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs)
        Try
            Dim produit As ProduitBean = New ProduitBean()
            produit.code = code.Text
            produit.nom = nom.Text
            produit.description = desc.Text
            produit.prix = CDbl(prix.Text)

            If (produit.nom.Equals(" ") Or produit.code.Equals("") Or produit.description.Equals(" ") Or
                produit.prix.Equals(" ")) Then
                MessageBox.Show("Alert", "Veuiller Bien remplit les Champs SVP")
            Else
                Dim cnx As MySqlConnection = New MySqlConnection
                cnx.ConnectionString = "server=localhost;userid=root;password=admin;database=gestionets"
                Dim reader As MySqlDataReader

                Try
                    cnx.Open()
                    Dim query As String = "insert into produit (nom,codeP,description,prix) values ('" + produit.nom +
                        "','" + produit.code + "','" + produit.description + "' ,'" + produit.prix.ToString() + "' );"
                    Dim command As New MySqlCommand(query, cnx)
                    reader = command.ExecuteReader
                    cnx.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    cnx.Dispose()
                    fermer()
                End Try

            End If
        Catch ex As Exception

        End Try

    End Sub



    Private Sub BunifuImageButton1_Click_1(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        fermer()
    End Sub

    Private Sub BunifuThinButton21_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        fermer()
    End Sub

    Private Sub modifieBTN_Click_1(sender As Object, e As EventArgs) Handles modifieBTN.Click
        Dim cnx As MySqlConnection = New MySqlConnection
        cnx.ConnectionString = "server=localhost;userid=root;password=admin;database=gestionets"
        If (nom.Equals(" ") Or code.Equals("") Or desc.Equals(" ") Or
                prix.Equals(" ")) Then
            MessageBox.Show("Alert", "Veuiller Bien remplit les Champs SVP")
        Else
            Try
                cnx.Open()
                Dim nouveaPrix As Double = CDbl(prix.Text)
                Dim nouveauCode As String = code.Text
                Dim mmCode As Boolean = codeProduit.Equals(nouveauCode)

                If (Not mmCode) Then

                    Dim verfierCommand As MySqlCommand = cnx.CreateCommand()
                    verfierCommand.CommandText = "select count(codeP) from Produit where  codeP ='" + nouveauCode + "' "
                    Dim countCode As Integer = CInt(verfierCommand.ExecuteScalar())
                    If (countCode > 0) Then
                        MessageBox.Show("Code de Produit Déja utiliser")
                        fermer()
                    End If

                End If

                Dim modifierCommand As MySqlCommand = cnx.CreateCommand()
                modifierCommand.CommandText = "update produit set nom='" + nom.Text + "' , prix='" + nouveaPrix.ToString + "' 
                                            , description='" + desc.Text + "' where codeP='" + codeProduit + "'"
                modifierCommand.ExecuteNonQuery()

                cnx.Close()

            Catch ex As Exception
                MessageBox.Show("Verifie les valeurs entrers ")
            Finally
                cnx.Dispose()
                fermer()
            End Try
        End If



    End Sub

    Private Sub fermer()
        code.Text = ""
        desc.Text = ""
        prix.Text = ""
        nom.Text = ""
        Me.Hide()
    End Sub
End Class

