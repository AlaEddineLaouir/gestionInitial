Imports MySql.Data.MySqlClient

Public Class Client

    Public Sub refresh()
        Dim cnx As MySqlConnection = New MySqlConnection
        cnx.ConnectionString = "server=localhost;userid=root;password=admin;database=gestionets"
        Dim sda As MySqlDataAdapter = New MySqlDataAdapter()
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource


        Try
            cnx.Open()
            Dim query As String = "select * from Client"
            Dim command As New MySqlCommand(query, cnx)
            sda.SelectCommand = command
            sda.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            GridClient.DataSource = bSource
            sda.Update(dbDataSet)
            cnx.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        profil.modifier.Visible = False
        profil.ajouter.Visible = True
        profil.Titre.Text = "Ajouter Client"
        profil.Show()
    End Sub

    Private Sub GridClient_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridClient.CellContentClick
        Dim indice = GridClient.SelectedCells.Item(0).RowIndex

        profil.nomPer = GridClient.Rows(indice).Cells(1).Value
        profil.prenomPer = GridClient.Rows(indice).Cells(2).Value
        profil.telephonePre = GridClient.Rows(indice).Cells(3).Value
        profil.adressePer = GridClient.Rows(indice).Cells(4).Value
        profil.idPersonne = CInt(GridClient.Rows(indice).Cells(0).Value)

        profil.ajouter.Visible = False
        profil.modifier.Visible = True
        profil.Titre.Text = "Modifier Client"
        profil.afficher()
        profil.Show()
    End Sub
End Class
