﻿Imports MySql.Data.MySqlClient
Imports System.IO

Public Class AjouterOptionRideau
    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        fermer()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        fermer()
    End Sub
    Private Sub fermer()
        Me.Hide()
    End Sub

    Private Sub selcImage_Click(sender As Object, e As EventArgs) Handles selcImage.Click
        Dim ofd As OpenFileDialog = New OpenFileDialog()
        With ofd

            .Filter = "JPEGs|*.jpg"
            .FilterIndex = 1
        End With
        If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            With imageModele

                .Image = Image.FromFile(ofd.FileName)
                .SizeMode = PictureBoxSizeMode.Zoom
                .BorderStyle = BorderStyle.Fixed3D
            End With
        End If
    End Sub

    Private Sub confirmeBTN_Click(sender As Object, e As EventArgs) Handles confirmeBTN.Click
        Dim prixMl As Double
        Dim nm As String
        Dim multi As Integer
        Dim dep As String

        Dim ms As New MemoryStream()
        Dim cnx As MySqlConnection = New MySqlConnection
        cnx.ConnectionString = "server=localhost;userid=root;password=admin;database=gestionets"


        If (Not prix.Text.Equals("")) Then

            Try
                prixMl = CDbl(prix.Text)
            Catch ex As Exception
                MessageBox.Show("Veullier entrer une valeur correct pour le prix")
                Return
            End Try

            If (Not multipliciter.Equals("")) Then

                Try
                    multi = CInt(multipliciter.Text)
                Catch ex As Exception
                    MessageBox.Show("Veullier entrer une valeur correct pour la multipliciter Ex : 1 , 2 ..")
                    Return
                End Try


                If (Not imageModele.Image Is Nothing) Then

                    nm = nom.Text
                    dep = dependence.Text

                    imageModele.Image.Save(ms, imageModele.Image.RawFormat)
                    Dim enregistrerModele As New MySqlCommand("insert into optionrideau (nom,prix,dependens,multiplicite,image) values(@n,@p,@dp,@ml,@im)", cnx)
                    enregistrerModele.Parameters.Add("@p", MySqlDbType.Double).Value = prixMl
                    enregistrerModele.Parameters.Add("@dp", MySqlDbType.VarChar).Value = dep
                    enregistrerModele.Parameters.Add("@ml", MySqlDbType.Int16).Value = multi
                    enregistrerModele.Parameters.Add("@n", MySqlDbType.VarChar).Value = nm
                    enregistrerModele.Parameters.Add("@im", MySqlDbType.LongBlob).Value = ms.ToArray()

                    Try
                        cnx.Open()
                        enregistrerModele.ExecuteNonQuery()
                        fermer()
                    Catch ex As Exception
                        MessageBox.Show("Error pendant l'enregistrement , veuillier reussier")
                        MessageBox.Show(ex.Message() + "--------------->" + ex.StackTrace)
                    Finally
                        cnx.Dispose()
                    End Try
                    fermer()
                Else
                    MessageBox.Show("Veullier selectionner une Image")
                    Return
                End If
            Else
                MessageBox.Show("Veullier entrer une description")
                Return
            End If

        Else
            MessageBox.Show("Veullier entrer un prix")
            Return
        End If
    End Sub


End Class