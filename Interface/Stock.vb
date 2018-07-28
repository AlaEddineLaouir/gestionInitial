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
            Dim query As String = "select p.nomoCloture ,p.nom , p.description ,p.prix , p.quantite from produit p "
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

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BunifuMetroTextbox1_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox1.OnValueChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub slider_Click(sender As Object, e As EventArgs) Handles slider.Click

    End Sub

    Private Sub GridProduit_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridProduit.CellContentClick
        ajouterProduit.Titre.Text = "Modifie Produit"
        ajouterProduit.Show()
    End Sub
End Class
