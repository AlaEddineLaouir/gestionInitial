Imports MySql.Data.MySqlClient
Public Class nouvelleVente
    Private passe1 As Boolean = False
    Private passe2 As Boolean = False
    Private passe3 As Boolean = False
    Private Sub fermer()
        Me.Hide()
        GridProduit.Rows.Clear()
        ttl.Text = ""
        idClient.Text = ""
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        fermer()
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        fermer()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click



        If (passe2) Then
            Dim code = cd.Text
            Dim quantite = CType(qt.Text, Integer)
            Dim prix As Double
            If (prixVente.Text.Equals("")) Then
                prix = CDbl(prx.Text)
            Else
                Try
                    prix = CDbl(prixVente.Text)
                Catch ex As Exception
                    MessageBox.Show("Entrer une valeur correct pour le prix vente")
                    Return
                End Try
            End If

            GridProduit.Rows.Add(New String() {code, Quantite, prix})


            passe1 = False
            passe2 = False

            cd.Text = ""
            qt.Text = ""
            prx.Text = "0"
            prixVente.Text = ""



            If (ttl.Text.Equals("")) Then
                Dim total = prix * Quantite
                ttl.Text = total
            Else
                Dim ensTotal = CType(ttl.Text, Double)
                ensTotal = ensTotal + (prix * Quantite)
                ttl.Text = ensTotal
            End If
            passe3 = True
        End If


    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        If (passe3) Then
            Dim dte As String
            Dim idCli As Integer
            Try
                idCli = CType(idClient.Text, Integer)
                dte = CType(dateApro.Value.ToString("yyyy-MM-dd"), String)
                MessageBox.Show("la date est : " + dte)
            Catch ex As Exception
                MessageBox.Show("Verfie le id de Client SVP")
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

                Dim insertVente As MySqlCommand = cnx.CreateCommand()
                insertVente.CommandText = "insert into vente (dateArrivague,fournisseur) values ('" + dte + "'," + idClient.ToString + " ) ;
                                    SELECT LAST_INSERT_ID() ;"
                insertVente.Transaction = sqlTran

                Dim idApro As Integer = CInt(insertVente.ExecuteScalar())

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
        End If

    End Sub

    Private Sub cd_TextChanged(sender As Object, e As EventArgs) Handles cd.TextChanged

        Dim code = cd.Text
        Dim prix As Double

        Try
            Dim cnx As MySqlConnection = New MySqlConnection
            cnx.ConnectionString = "server=localhost;userid=root;password=admin;database=gestionets"
            cnx.Open()
            Dim getPrix As MySqlCommand = cnx.CreateCommand()
            getPrix.CommandText = "select prix from produit where codeP like '" + code + "'"
            prix = CDbl(getPrix.ExecuteScalar())
            prx.Text = prix.ToString()
            cnx.Close()
            If (prix > 0) Then
                passe1 = True
            End If

        Catch ex As Exception
            MessageBox.Show("Verifier le code de produit SVP")
            passe1 = False
        End Try
    End Sub

    Private Sub qt_TextChanged(sender As Object, e As EventArgs) Handles qt.TextChanged

        If (passe1) Then
            Dim Quantite As Integer
            Try
                Quantite = CInt(qt.Text)
            Catch ex As Exception
                MessageBox.Show("Entrer Une valeur Entier pour la quantite")
                passe2 = False
            End Try
            Try
                Dim cnx As MySqlConnection = New MySqlConnection
                cnx.ConnectionString = "server=localhost;userid=root;password=admin;database=gestionets"
                cnx.Open()
                Dim getQuantite As MySqlCommand = cnx.CreateCommand()
                getQuantite.CommandText = "select quantite from produit where codeP='" + cd.Text + "'"
                Dim qte As Integer = CInt(getQuantite.ExecuteScalar())
                If (qte < Quantite) Then
                    MessageBox.Show("Quantite Inssufisante")
                    passe2 = False
                    Return
                Else
                    passe2 = True
                End If


            Catch
            End Try
        End If
    End Sub




    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs) Handles BunifuImageButton4.Click
        profil.modifier.Visible = False
        profil.ajouter.Visible = True
        profil.Titre.Text = "Ajouter Client"
        profil.Show()
    End Sub

    Private Sub idClient_TextChanged(sender As Object, e As EventArgs) Handles idClient.TextChanged
        If (idClient.Text.Length > 0) Then
            Dim key As String = idClient.Text.ToString
            Dim cnx As MySqlConnection = New MySqlConnection
            cnx.ConnectionString = "server=localhost;userid=root;password=admin;database=gestionets"
            Try

                cnx.Open()
                Dim listClient As MySqlCommand = cnx.CreateCommand()
                Dim query As String = "select * from client where id like '%" + key + "%' or nom like '%" + key + "%' or prenom like '%" + key + "%' or telephone like '%" + key + "%' or adress like '%" + key + "%' "

                listClient.CommandText = query
                Dim dataReader As MySqlDataReader = listClient.ExecuteReader()
                Dim list As New AutoCompleteStringCollection

                While dataReader.Read()
                    list.Add(dataReader.Item("nom") + " " + dataReader.Item("prenom") + " " + dataReader.Item("telephone") + " " + " " + dataReader.Item("adress") + " ( " + dataReader.Item("id").ToString() + " )")
                End While

                dataReader.Close()

                idClient.AutoCompleteMode = AutoCompleteMode.Suggest
                idClient.AutoCompleteSource = AutoCompleteSource.CustomSource
                idClient.AutoCompleteCustomSource = list


                cnx.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)

            Finally

            End Try
        End If
    End Sub
End Class