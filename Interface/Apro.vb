﻿Imports MySql.Data.MySqlClient
Public Class Apro


    Public Sub refresh()
        Dim cnx As MySqlConnection = New MySqlConnection
        cnx.ConnectionString = "server=localhost;userid=root;password=admin;database=gestionets"
        Dim sda As MySqlDataAdapter = New MySqlDataAdapter()
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource


        Try
            cnx.Open()
            Dim query As String = "select dateArrivague As date ,concat(nom,' ',prenom,' ',telephone) as four , sum(prix * quantite) As total , count(produit) As nombre , a.id from apro a , aproproduit ap, fournisseur f where f.id=a.fournisseur and  a.id=ap.apro group by a.id"
            Dim command As New MySqlCommand(query, cnx)
            sda.SelectCommand = command
            sda.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            GridProduit.DataSource = bSource
            sda.Update(dbDataSet)
            cnx.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        nouveauApro.Show()
    End Sub

    Private Sub GridProduit_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridProduit.CellContentClick

        Dim indiceApro As Integer = GridProduit.SelectedCells.Item(0).RowIndex
        Dim idFour As Integer = CInt(GridProduit.Rows(indiceApro).Cells(1).Value)
        Dim dateApro As String = GridProduit.Rows(indiceApro).Cells(0).Value
        indiceApro = CInt(GridProduit.Rows(indiceApro).Cells(4).Value)

        detailleApro.idApro = indiceApro
        detailleApro.idFour = idFour
        detailleApro.dateAproo = dateApro
        detailleApro.afficher()
        detailleApro.Show()





    End Sub
End Class
