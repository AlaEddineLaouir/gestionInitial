Imports MySql.Data.MySqlClient
Public Class nouvelleVente
    ' Variable pour la validation '
    Private passe1 As Boolean = False
    Private passe2 As Boolean = False
    Private passe3 As Boolean = False

    'Variable des info sur la vente '
    Private totalRef As Double = 0
    Private idDeClient As Integer
    Private totalDeVente As Double
    Private tauxRemise As Double

    'Variable de Connexion a la base de donnée'
    Private cnx As MySqlConnection = New MySqlConnection


    Private Sub nouvelleVente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Show()
        cnx.ConnectionString = "server=localhost;userid=root;password=admin;database=gestionets"
        Try

            cnx.Open()
            Dim optionCode As MySqlCommand = cnx.CreateCommand()
            optionCode.CommandText = "select codeP from produit"
            Dim opRe As MySqlDataReader = optionCode.ExecuteReader()
            Dim listCode As New AutoCompleteStringCollection

            While (opRe.Read())
                listCode.Add(opRe.Item("codeP"))
            End While
            opRe.Close()

            cd.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            cd.AutoCompleteSource = AutoCompleteSource.CustomSource
            cd.AutoCompleteCustomSource = listCode
        Catch ex As Exception

        End Try
    End Sub


    Private Sub fermer()
        Me.Hide()
        GridProduit.Rows.Clear()
        ttl.Text = ""
        idClient.Text = ""
        idClient.ReadOnly = False
        totalRef = 0
        passe1 = passe2 = passe3 = False
        cnx.Dispose()
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
            Dim prixFixer As Double = CDbl(prx.Text)
            Dim prix As Double
            Dim produitsAcheter As New List(Of String)
            Dim valide As Boolean = True

            If (prixVente.Text.Equals("")) Then
                prix = prixFixer
            Else
                Try
                    prix = CDbl(prixVente.Text)
                Catch ex As Exception
                    MessageBox.Show("Entrer une valeur correct pour le prix vente")
                    Return
                End Try
            End If

            For i As Integer = 0 To GridProduit.Rows.Count - 1
                produitsAcheter.Add(GridProduit.Rows(i).Cells(0).Value)
            Next
            If (produitsAcheter.Contains(code)) Then
                MessageBox.Show("Produit déja ajouter")
            Else
                GridProduit.Rows.Add(New String() {code, quantite, prix, prixFixer})
                valide = True
            End If

            passe1 = False
            passe2 = False

            cd.Text = ""
            qt.Text = ""
            prx.Text = "0"
            prixVente.Text = ""


            If (valide) Then
                totalRef = totalRef + (prixFixer * quantite)
                totalDeVente = totalDeVente + (prix * quantite)
                ttl.Text = totalDeVente.ToString
                tauxRemise = Format((((totalRef - totalDeVente) * 100) / totalRef), "0.00")
                tauxRms.Text = tauxRemise.ToString + " %"
                passe3 = True
            End If
        End If
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        If (passe3) Then
            Dim cmdClient As MySqlCommand
            Try
                cnx.Open()
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try

            Dim dte As String
            Dim idCli As String = idClient.Text
            Dim infoClient As String()
            Try
                dte = CType(dateApro.Value.ToString("yyyy-MM-dd"), String)
                infoClient = Split(idCli, ", ")
                cmdClient = cnx.CreateCommand()
                MessageBox.Show("select id from client where nom like '" + infoClient(0) + "' and prenom like '" + infoClient(1) + "' and telephone like '" + infoClient(2) + "' and adress like '" + infoClient(3) + "'  ")
                cmdClient.CommandText = "select id from client where nom like '" + infoClient(0) + "' and prenom like '" + infoClient(1) + "' and telephone like '" + infoClient(2) + "' and adress like '" + infoClient(3) + "'  ;"
                idDeClient = CInt(cmdClient.ExecuteScalar())
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


            Dim sqlTran As MySqlTransaction = cnx.BeginTransaction()

            Try

                Dim insertVente As MySqlCommand = cnx.CreateCommand()

                insertVente.CommandText = "insert into vente (datevente,client,tauxremise) values ('" + dte + "'," + idDeClient.ToString + "," + tauxRemise.ToString + " ) ;
                                    SELECT LAST_INSERT_ID() ;"
                Console.Write(insertVente.CommandText)
                insertVente.Transaction = sqlTran

                Dim idVente As Integer = CInt(insertVente.ExecuteScalar())

                For i As Integer = 0 To produits.Count - 1

                    Dim ajout As MySqlCommand = cnx.CreateCommand()
                    ajout.CommandText = "insert into produitvente values('" + produits(i).code + "' ,
                                      " + idVente.ToString + "," + produits(i).quantite.ToString + "," + produits(i).prix.ToString + "  );"
                    ajout.Transaction = sqlTran
                    ajout.ExecuteNonQuery()

                    Dim check As MySqlCommand = cnx.CreateCommand()
                    check.CommandText = "select quantite from produit where codeP='" + produits(i).code + "' ;"
                    check.Transaction = sqlTran

                    Dim quantite As Integer

                    quantite = CInt(check.ExecuteScalar())


                    quantite = quantite - produits(i).quantite

                    Dim majStock As MySqlCommand = cnx.CreateCommand()
                    majStock.CommandText = "update produit set quantite = " + quantite.ToString + " where codeP='" + produits(i).code + "'  ;"
                    majStock.ExecuteNonQuery()


                Next
                Dim crediterCaisse As MySqlCommand = cnx.CreateCommand()
                crediterCaisse.CommandText = "insert into paiement (datePaiement,montant,vente) values ('" + dte + "'," + totalDeVente + "," + idVente + ")"




                sqlTran.Commit()
                fermer()
            Catch ex As Exception
                MessageBox.Show(ex.StackTrace)
                sqlTran.Rollback()
            Finally
                cnx.Dispose()
            End Try
        End If

    End Sub

    Private Sub cd_TextChanged(sender As Object, e As EventArgs) Handles cd.TextChanged
        If (cd.TextLength > 0) Then
            Dim code = cd.Text
            Dim valider As Boolean = False
            Dim produitsAcheter As New List(Of String)
            Dim prix As Double
            Try
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
                    MessageBox.Show(ex.ToString())
                    passe1 = False
                End Try

        End If

    End Sub

    Private Sub qt_TextChanged(sender As Object, e As EventArgs) Handles qt.TextChanged

        If (passe1 And qt.TextLength > 0) Then
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
        If (idClient.Text.Length > 0 And idClient.Text.Length < 10) Then
            Dim key As String = idClient.Text.ToString
            Try

                cnx.Open()
                Dim listClient As MySqlCommand = cnx.CreateCommand()
                Dim query As String = "select * from client where nom like '%" + key + "%'"

                listClient.CommandText = query
                Dim dataReader As MySqlDataReader = listClient.ExecuteReader()
                Dim list As New AutoCompleteStringCollection

                While dataReader.Read()
                    list.Add(dataReader.Item("nom") + ", " + dataReader.Item("prenom") + ", " + dataReader.Item("telephone") + ", " + dataReader.Item("adress"))
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
        ElseIf (idClient.Text.Length >= 10) Then
            idClient.ReadOnly = True
        End If
    End Sub

    Private Sub GridProduit_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridProduit.CellContentClick
        Dim result As Integer = MessageBox.Show("Voulez vous supprimer cette ligne ", "Validation", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Dim index As Integer = GridProduit.SelectedCells.Item(0).RowIndex
            Dim quantite As Integer = CInt(GridProduit.Rows(index).Cells(1).Value)
            Dim prixvente As Double = CDbl(GridProduit.Rows(index).Cells(2).Value)
            Dim prixFixer As Double = CDbl(GridProduit.Rows(index).Cells(3).Value)

            totalDeVente = totalDeVente - (quantite * prixvente)
            totalRef = totalRef - (quantite * prixFixer)
            tauxRemise = Format((((totalRef - totalDeVente) * 100) / totalRef), "0.00")

            ttl.Text = totalDeVente.ToString()
            tauxRms.Text = tauxRemise.ToString + " %"

            GridProduit.Rows.RemoveAt(index)
        End If
    End Sub
End Class