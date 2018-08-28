Imports MySql.Data.MySqlClient

Public Class nouvellePrestation
    'Variable de Prestation'
    Private total As Double = 0
    Private totalArranger As Double = 0
    Private tauxRemise As Double = 0


    'Variable de Connexion a la base de donnée'
    Private cnx As MySqlConnection = New MySqlConnection

    'Variable pour les donnée'

    Public prestationRideau As New List(Of RideauBean)
    Public prestationInox As New List(Of PresInox)



    Public Sub befresh()
        Try
            GridPrestation.Rows.Clear()
            totalArranger = 0
            tauxRemise = 0
            total = 0
        Catch ex As Exception

        End Try
        For i As Integer = 0 To prestationRideau.Count - 1
            Dim r As RideauBean = prestationRideau.Item(i)
            total += r.prixFixer
            totalArranger += r.prixArrang
            GridPrestation.Rows.Add(New String() {r.num.ToString, r.description, r.quantite, r.prixFixer, r.prixArrang})
        Next

        For i As Integer = 0 To prestationInox.Count - 1
            Dim pi As PresInox = prestationInox.Item(i)
            total = total + pi.prixFixer * pi.quantite
            totalArranger = totalArranger + pi.quantite * pi.prixArr
            GridPrestation.Rows.Add(New String() {pi.num.ToString, pi.description, pi.quantite, pi.prixFixer, pi.prixArr})
        Next

        tauxRemise = Format((((total - totalArranger) * 100) / total), "0.00")
        tauxRms.Text = tauxRemise.ToString
        ttl.Text = totalArranger.ToString
    End Sub

    Private Sub nouvellePrestation_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Show()

        cnx.ConnectionString = "server=localhost;userid=root;password=admin;database=gestionets"
    End Sub

    Private Sub fermer()
        idClient.Text = ""
        idClient.ReadOnly = False
        dateApro.Value = DateTime.Now()
        GridPrestation.Rows.Clear()
        totalArranger = 0
        total = 0
        tauxRemise = 0
        tauxRms.Text = "%"
        ttl.Text = "0"

        prestationRideau.Clear()
        Me.Hide()
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

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            Finally
                cnx.Close()
            End Try
        ElseIf (idClient.Text.Length >= 10) Then
            idClient.ReadOnly = True
        End If
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        fermer()
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        fermer()
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        Ajouter_Rideau.Show()
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Ajouter_Inox_Prestation.Show()
    End Sub
End Class