Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Ajouter_Inox_Prestation
    'Variable de connxion BD'
    Private cnx As MySqlConnection = New MySqlConnection("server=localhost;userid=root;password=admin;database=gestionets")

    'variable de control'
    Private passe1 As Boolean = False
    Private passe2 As Boolean = False

    'Variable de donnée'
    Private qtt As Integer = 0
    Private prixArng As Double = 0
    Private prixF As Double = 0
    Private numModele As Integer = 0
    Private total As Double = 0
    Private totalArranger As Double = 0


    Private Sub num_TextChanged(sender As Object, e As EventArgs) Handles num.TextChanged
        If (Not num.Text.Equals("")) Then
            Try
                cnx.Open()

                Dim getPrix As MySqlCommand = cnx.CreateCommand()
                getPrix.CommandText = "select prix from modeleInox where id=" + num.Text
                prixF = getPrix.ExecuteScalar()
                Dim getDesc As MySqlCommand = cnx.CreateCommand()
                getDesc.CommandText = "select description from modeleinox where id=" + num.Text
                spec.Text = CStr(getDesc.ExecuteScalar())
                If (prixF > 0) Then
                    prix.Text = prixF.ToString()
                    numModele = CInt(num.Text)
                    passe1 = True
                Else
                    passe1 = False
                End If
                cnx.Close()
            Catch ex As Exception
                passe1 = False
            Finally
                cnx.Close()
            End Try
        End If
    End Sub

    Private Sub Qt_TextChanged(sender As Object, e As EventArgs) Handles Qt.TextChanged
        If (passe1) Then
            Try
                qtt = CInt(Qt.Text)
                total = prixF * qtt
                passe2 = True
                If (Not prixArng = 0) Then
                    totalArranger = prixArng * qtt
                    ttl.Text = totalArranger.ToString
                    tauxRms.Text = Format((((total - totalArranger) * 100) / total), "0.00") + " %"
                Else
                    ttl.Text = total.ToString
                End If
            Catch ex As Exception
                MessageBox.Show("Entrer une valeur correct comme quantite SVP")
                passe2 = False
            End Try
        End If
    End Sub

    Private Sub selcImage_Click(sender As Object, e As EventArgs) Handles selcImage.Click
        If (passe1) Then
            Try
                cnx.Open()
                Dim getImage As MySqlCommand = cnx.CreateCommand()
                getImage.CommandText = "select  image from modeleInox where id=" + numModele.ToString
            Catch ex As Exception

        End Try
        End If
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        fermer()
    End Sub
    Private Sub fermer()
        num.Text = ""
        prix.Text = "0"
        prixArr.Text = "0"
        Qt.Text = "0"
        spec.Text = ""

        numModele = 0
        prixArng = 0
        prixF = 0
        qtt = 0

        passe1 = False
        passe2 = False

        Me.Hide()
    End Sub

    Private Sub valider_Click(sender As Object, e As EventArgs) Handles valider.Click
        If (passe2) Then
            Dim pi As PresInox = New PresInox()
            pi.numModele = numModele
            If (Not prixArng = 0) Then
                pi.prixArr = prixArng
            Else
                pi.prixArr = prixF
            End If
            pi.quantite = qtt
            pi.prixFixer = prixF
            pi.description = spec.Text
            pi.num = nouvellePrestation.prestationInox.Count

            nouvellePrestation.prestationInox.Add(pi)

            nouvellePrestation.befresh()
            fermer()
        End If
    End Sub

    Private Sub prixArr_TextChanged(sender As Object, e As EventArgs) Handles prixArr.TextChanged

        If (Not prixArr.Text.Equals("")) Then

            Try
                prixArng = CDbl(prixArr.Text)
                totalArranger = prixArng * qtt
                ttl.Text = totalArranger.ToString
            Catch ex As Exception
                prixArng = 0
                MessageBox.Show("entrer une valeur correcte pour le prix")
            End Try

        End If

    End Sub
End Class