Imports MySql.Data.MySqlClient

Public Class Fournisseur
    Public Sub refresh()
        Dim cnx As MySqlConnection = New MySqlConnection
        cnx.ConnectionString = "server=localhost;userid=root;password=admin;database=gestionets"
        Dim sda As MySqlDataAdapter = New MySqlDataAdapter()
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource


        Try
            cnx.Open()
            Dim query As String = "select * from fournisseur"
            Dim command As New MySqlCommand(query, cnx)
            sda.SelectCommand = command
            sda.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            GridFour.DataSource = bSource
            sda.Update(dbDataSet)
            cnx.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        profil.modifier.Visible = False
        profil.ajouter.Visible = True
        profil.Titre.Text = "Ajouter Fournisseur"
        profil.Show()
    End Sub

    Private Sub GridFour_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridFour.CellContentClick
        Dim indice = GridFour.SelectedCells.Item(0).RowIndex

        profil.nomPer = GridFour.Rows(indice).Cells(1).Value
        profil.prenomPer = GridFour.Rows(indice).Cells(2).Value
        profil.telephonePre = GridFour.Rows(indice).Cells(3).Value
        profil.adressePer = GridFour.Rows(indice).Cells(4).Value
        profil.idPersonne = CInt(GridFour.Rows(indice).Cells(0).Value)

        profil.ajouter.Visible = False
        profil.modifier.Visible = True
        profil.Titre.Text = "Modifier Fournisseur"
        profil.afficher()
        profil.Show()
    End Sub
End Class
