Imports MySql.Data.MySqlClient
Public Class nouveauApro

    Private Sub fermer()
        Me.Hide()
        GridProduit.Rows.Clear()
        ttl.Text = ""
        idFournisseur.Text = ""
    End Sub
    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        fermer()
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        fermer()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Try
            Dim code = cd.Text
            Dim quantite = CType(qt.Text, Integer)
            Dim prix = CType(prx.Text, Double)

            GridProduit.Rows.Add(New String() {code, quantite, prix})
            cd.Text = ""
            qt.Text = ""
            prx.Text = ""


            If (ttl.Text.Equals("")) Then
                Dim total = prix * quantite
                ttl.Text = total
            Else
                Dim ensTotal = CType(ttl.Text, Double)
                ensTotal = ensTotal + (prix * quantite)
                ttl.Text = ensTotal
            End If

        Catch ex As Exception
            MessageBox.Show("Veullier entrer des valeurs valides SVP")
        End Try
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Dim dte As String
        Dim idFour As Integer
        Try
            idFour = CType(idFournisseur.Text, Integer)
            dte = CType(dateApro.Value.ToString("yyyy-MM-dd"), String)
            MessageBox.Show("la date est : " + dte)
        Catch ex As Exception
            MessageBox.Show("Verfie le id de fournisseur SVP")
            Return
        End Try

        Dim rowCount = GridProduit.Rows.Count
        Dim produits As List(Of ProduitBean) = New List(Of ProduitBean)

        For i As Integer = 0 To rowCount - 1
            Dim produit As ProduitBean = New ProduitBean()
            produit.code = GridProduit.Rows(i).Cells(0).Value
            produit.quantite = CType(GridProduit.Rows(i).Cells(1).Value, Integer)
            produit.prix = CType(GridProduit.Rows(i).Cells(2).Value, Double)

            produits.Add(produit)
        Next

        Dim cnx As MySqlConnection = New MySqlConnection
        cnx.ConnectionString = "server=localhost;userid=root;password=admin;database=gestionets"
        Try
            cnx.Open()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
        Dim sqlTran As MySqlTransaction = cnx.BeginTransaction()

        Try

            Dim insertApro As MySqlCommand = cnx.CreateCommand()
            insertApro.CommandText = "insert into apro (dateArrivague,fournisseur) values ('" + dte + "'," + idFour.ToString + " ) ;
                                    SELECT LAST_INSERT_ID() ;"
            insertApro.Transaction = sqlTran

            Dim idApro As Integer = CInt(insertApro.ExecuteScalar())

            For i As Integer = 0 To produits.Count - 1

                Dim ajout As MySqlCommand = cnx.CreateCommand()
                ajout.CommandText = "insert into aproProduit values('" + produits(i).code + "' ,
                                      " + idApro.ToString + "," + produits(i).quantite.ToString + "," + produits(i).prix.ToString + "  );"
                ajout.Transaction = sqlTran
                ajout.ExecuteNonQuery()

                Dim check As MySqlCommand = cnx.CreateCommand()
                check.CommandText = "select quantite from produit where codeP='" + produits(i).code + "' ;"
                check.Transaction = sqlTran

                Dim quantite As Integer
                Try
                    quantite = CInt(check.ExecuteScalar())
                Catch ex As Exception
                    quantite = 0
                End Try

                quantite = quantite + produits(i).quantite

                Dim majStock As MySqlCommand = cnx.CreateCommand()
                majStock.CommandText = "update produit set quantite = " + quantite.ToString + " where codeP='" + produits(i).code + "'  ;"
                majStock.ExecuteNonQuery()


            Next


            sqlTran.Commit()
            fermer()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            sqlTran.Rollback()
        Finally
            cnx.Dispose()
        End Try








    End Sub
End Class