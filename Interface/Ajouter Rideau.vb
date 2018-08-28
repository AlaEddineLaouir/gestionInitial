Imports MySql.Data.MySqlClient

Public Class Ajouter_Rideau
    Private hauteur As Double = 0
    Private largeur As Double = 0

    Private totalFixer As Double = 0
    Private tauxRemise As Double = 0
    Private totalArranger As Double = 0
    Private qtt As Integer = 1

    Private passe1 As Boolean = False
    Private passe2 As Boolean = False
    Private passe3 As Boolean = False

    Private cnx As MySqlConnection = New MySqlConnection()

    Private Sub nomC_TextChanged(sender As Object, e As EventArgs) Handles nomC.TextChanged
        If (nomC.TextLength > 0) Then
            Dim nom = nomC.Text
            Dim prix As Double
            Try
                cnx.Open()
                Dim getdetaille As MySqlCommand = cnx.CreateCommand()
                getdetaille.CommandText = "select prix,dependens,multiplicite,id from optionRideau where nom like '" + nom + "'"
                Dim dataRD As MySqlDataReader = getdetaille.ExecuteReader()
                If (dataRD.Read()) Then
                    prix = CDbl(dataRD.Item("Prix"))
                    prx.Text = prix.ToString()
                    multi.Text = dataRD.Item("multiplicite")
                    dep.Text = dataRD.Item("dependens")
                    numCompo.Text = CInt(dataRD.Item("id"))

                    passe1 = True

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message + "---->" + ex.StackTrace)
                passe1 = False
            Finally
                cnx.Close()

            End Try

        End If

    End Sub


    Private Sub ajouterRideau_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Show()
        cnx.ConnectionString = "server=localhost;userid=root;password=admin;database=gestionets"
        Try

            cnx.Open()
            Dim optionCode As MySqlCommand = cnx.CreateCommand()
            optionCode.CommandText = "select nom from optionrideau"
            Dim opRe As MySqlDataReader = optionCode.ExecuteReader()
            Dim listCode As New AutoCompleteStringCollection

            While (opRe.Read())
                listCode.Add(opRe.Item("nom"))
            End While
            opRe.Close()

            nomC.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            nomC.AutoCompleteSource = AutoCompleteSource.CustomSource
            nomC.AutoCompleteCustomSource = listCode
            cnx.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ajouterComposant_Click(sender As Object, e As EventArgs) Handles ajouterComposant.Click
        If (passe1) Then

            'Recupirer les valeurs de la hauteur et lalargeur'

            If (hauteur = 0 And largeur = 0) Then
                Try
                    hauteur = CDbl(ht.Text)
                    largeur = CDbl(lg.Text)
                    If (hauteur > 0 And largeur > 0) Then
                        ht.ReadOnly = True
                        lg.ReadOnly = True
                    Else
                        MessageBox.Show("Veuillier Entrer des valeus correctes pour la hauteur et la largeur")
                        Return
                    End If
                Catch ex As Exception
                    MessageBox.Show("Veuillier Entrer des valeus correctes pour la hauteur et la largeur")
                    Return
                End Try
            End If

            'Recupirer les valeur de composant'
            Dim nom As String = nomC.Text
            Dim multip As Integer = CInt(multi.Text)
            Dim depe As String = dep.Text
            Dim prix As Double = CDbl(prx.Text)
            Dim cout As Double = 0
            Dim num As Integer = CInt(numCompo.Text)



            'Recupirer les composants ajouter '
            Dim composantAjouter As New List(Of String)

            For i As Integer = 0 To GridComposant.Rows.Count - 1
                composantAjouter.Add(GridComposant.Rows(i).Cells(0).Value)
            Next

            'Verifier Si le composant a été déja ajouter '
            If (composantAjouter.Contains(nom)) Then
                MessageBox.Show("Composant déja ajouter ")
                Return
            End If

            'Calculer le cout selon la dependece '
            cout = prix * multip
            If (depe.Equals("largeur")) Then
                cout = cout * largeur
            ElseIf (depe.Equals("hauteur")) Then
                cout = cout * hauteur
            ElseIf (depe.Equals("surface")) Then
                cout = cout * hauteur * largeur
            End If



            'Calcule de nouveau total'

            totalFixer = totalFixer + cout * qtt

            GridComposant.Rows.Add(New String() {num, nom, multip, depe, prix, cout})
            ttl.Text = totalFixer.ToString()


            passe2 = True
        End If
    End Sub

    Private Sub totalArr_TextChanged(sender As Object, e As EventArgs) Handles totalArr.TextChanged
        If (Not totalArr.Text.Equals("") And totalArr.Text.Length > 3) Then
            Try
                totalArranger = CDbl(totalArr.Text)
                tauxRemise = Format((((totalFixer - totalArranger) * 100) / totalFixer), "0.00")
                tauxRms.Text = tauxRemise.ToString + " %"
            Catch ex As Exception
                MessageBox.Show("entrer une valeur valide SVP")
                totalArr.Text = totalFixer.ToString
            End Try
        End If
    End Sub

    Private Sub QtRideau_TextChanged(sender As Object, e As EventArgs) Handles QtRideau.TextChanged
        If (Not QtRideau.Text.Equals("")) Then

            Try
                Dim qutt As Integer = CInt(QtRideau.Text)
                totalFixer = totalFixer / qtt
                totalFixer = totalFixer * qutt
                ttl.Text = totalFixer.ToString
                totalArranger = totalArranger / qtt
                totalArranger = totalArranger * qutt
                totalArr.Text = totalArranger.ToString
                qtt = qutt
            Catch ex As Exception
                MessageBox.Show("Entrer une valeur correct pour la quantite ")
                QtRideau.Text = "1"
                totalFixer = totalFixer / qtt
                ttl.Text = totalFixer.ToString
                totalArr.Text = totalFixer.ToString
                qtt = 1
            End Try

        End If
    End Sub

    Private Sub ttl_TextChanged(sender As Object, e As EventArgs) Handles ttl.TextChanged
        If (Not totalArranger = 0) Then
            tauxRemise = Format((((totalFixer - totalArranger) * 100) / totalFixer), "0.00")
            tauxRms.Text = tauxRemise.ToString + " %"
        End If
    End Sub

    Private Sub GridComposant_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridComposant.CellContentClick
        Dim result As Integer = MessageBox.Show("Voulez vous supprimer cette ligne ", "Validation", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Dim index As Integer = GridComposant.SelectedCells.Item(0).RowIndex

            Dim coutComp As Double = CDbl(GridComposant.Rows(index).Cells(5).Value)

            coutComp = coutComp * qtt
            totalFixer = totalFixer - coutComp
            totalArranger = totalArranger - (coutComp * tauxRemise) / 100

            ttl.Text = totalFixer.ToString
            totalArr.Text = totalArranger.ToString

            tauxRemise = Format((((totalFixer - totalArranger) * 100) / totalFixer), "0.00")
            tauxRms.Text = tauxRemise.ToString + " %"

            GridComposant.Rows.RemoveAt(index)
            If (GridComposant.Rows.Count = 0) Then
                passe2 = False
            End If
        End If
    End Sub

    Private Sub valider_Click(sender As Object, e As EventArgs) Handles valider.Click

        If (passe2) Then
            Dim rideau As RideauBean = New RideauBean()
            rideau.description = "rideau de " + hauteur.ToString + " hauteur et de " + largeur.ToString + " larguer, constituer de : "
            rideau.hautre = hauteur
            rideau.largre = largeur
            rideau.quantite = qtt
            rideau.prixFixer = totalFixer
            If (Not totalArranger = 0) Then
                rideau.prixArrang = totalArranger
            Else
                rideau.prixArrang = totalFixer
            End If

            For i As Integer = 0 To GridComposant.Rows.Count - 1
                rideau.idsComposant.Add(CInt(GridComposant.Rows(i).Cells(0).Value))
                rideau.coutComposant.Add(CDbl(GridComposant.Rows(i).Cells(5).Value))
                rideau.description += GridComposant.Rows(i).Cells(1).Value + " ,"
            Next

            rideau.num = nouvellePrestation.prestationRideau.Count
            nouvellePrestation.prestationRideau.Add(rideau)
            nouvellePrestation.befresh()
            fermer()
        Else
                MessageBox.Show("Un Rideau doit au moin avoir un composant ")
        End If



    End Sub

    Private Sub annuler_Click(sender As Object, e As EventArgs) Handles annuler.Click
        fermer()
    End Sub
    Private Sub fermer()
        ht.Text = ""
        ht.ReadOnly = False
        lg.Text = ""
        lg.ReadOnly = False
        GridComposant.Rows.Clear()

        passe1 = False
        passe2 = False
        passe3 = False
        Me.Hide()
    End Sub

End Class