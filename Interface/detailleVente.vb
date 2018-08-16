Imports MySql.Data.MySqlClient
Public Class detailleVente
    Public numVente As Integer

    Public Sub befresh()
        Try
            Dim cnx As MySqlConnection = New MySqlConnection
            cnx.ConnectionString = "server=localhost;userid=root;password=admin;database=gestionets"
            Dim sda As MySqlDataAdapter = New MySqlDataAdapter()
            Dim dbDataSet As New DataTable
            Dim bSource As New BindingSource

            cnx.Open()
            Dim query As String = "select produit , quantite , prix from produitvente pv where pv.vente=" + numVente.ToString + " "
            Dim command As New MySqlCommand(query, cnx)
            sda.SelectCommand = command
            sda.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            GridProduit.DataSource = bSource
            sda.Update(dbDataSet)
            cnx.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message + " ------------>  " + ex.StackTrace)
        End Try
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        fermer()
    End Sub

    Private Sub fermer()

        Try
            nomClient.Text = ""
            prenomClient.Text = ""
            telephoneClient.Text = ""
            adressClient.Text = ""
            TotalVente.Text = ""
            dateVente.Text = ""
            numVente = 0
            GridProduit.Rows.Clear()
            Me.Hide()
        Catch ex As Exception
            Me.Close()
        End Try

    End Sub
End Class