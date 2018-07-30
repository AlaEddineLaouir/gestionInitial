Imports MySql.Data.MySqlClient
Public Class Stock
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click, BunifuFlatButton2.Click
        slider.Left = CType(sender, Bunifu.Framework.UI.BunifuFlatButton).Left
        slider.Width = CType(sender, Bunifu.Framework.UI.BunifuFlatButton).Width

    End Sub

    Public Sub refresh()
        Dim cnx As MySqlConnection = New MySqlConnection
        cnx.ConnectionString = "server=localhost;userid=root;password=admin;database=gestionets"
        Dim sda As MySqlDataAdapter = New MySqlDataAdapter()
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource


        Try
            cnx.Open()
            Dim query As String = "select p.codeP ,p.nom , p.description ,p.prix , p.quantite from produit p "
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
        ajouterProduit.Titre.Text = "Ajouter Produit"
        ajouterProduit.Show()

    End Sub



    Private Sub GridProduit_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridProduit.CellContentClick
        Dim indice As Integer = GridProduit.SelectedCells.Item(0).RowIndex
        Dim code As String = GridProduit.Rows(indice).Cells(0).Value
        Dim nomProduit As String = GridProduit.Rows(indice).Cells(1).Value
        Dim descProduit As String = GridProduit.Rows(indice).Cells(2).Value
        Dim prixVente As Double = CDbl(GridProduit.Rows(indice).Cells(3).Value)

        ajouterProduit.code.Text = code
        ajouterProduit.nom.Text = nomProduit
        ajouterProduit.desc.Text = descProduit
        ajouterProduit.prix.Text = prixVente

        ajouterProduit.Titre.Text = "Modifie Produit"
        ajouterProduit.confirmeBTN.Visible = False
        ajouterProduit.modifieBTN.Visible = True

        ajouterProduit.codeProduit = code

        ajouterProduit.Show()
    End Sub
End Class
