﻿Imports MySql.Data.MySqlClient
Public Class ajouterProduit
    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Try
            Me.Hide()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Try
            Me.Hide()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
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
                    Dim query As String = "insert into produit (nom,nomoCloture,description,prix) values ('" + produit.nom +
                        "','" + produit.code + "','" + produit.description + "' ,'" + produit.prix.ToString() + "' );"
                    Dim command As New MySqlCommand(query, cnx)
                    reader = command.ExecuteReader
                    cnx.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    cnx.Dispose()
                End Try

            End If
        Catch ex As Exception

        End Try

    End Sub
End Class
