Imports MySql.Data.MySqlClient
Public Class detailleApro
    Public idApro As Integer
    Public idFour As Integer
    Public dateAproo As String

    Public Sub afficher()
        Dim cnx As MySqlConnection = New MySqlConnection
        cnx.ConnectionString = "server=localhost;userid=root;password=admin;database=gestionets"
        Dim sda As MySqlDataAdapter = New MySqlDataAdapter()
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource


        Try
            cnx.Open()
            Dim query1 As String = "select produit , quantite , prix from aproproduit ap where ap.apro=" + idApro.ToString + " "
            Dim command As New MySqlCommand(query1, cnx)
            sda.SelectCommand = command
            sda.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            GridProduit.DataSource = bSource
            sda.Update(dbDataSet)

            Dim query2 As String = "select nom,prenom,telephone,adress from fournisseur where id= " + idFour.ToString + ""
            Dim command2 As New MySqlCommand(query2, cnx)
            Dim reader As MySqlDataReader = command2.ExecuteReader()
            reader.Read()
            nomFour.Text = reader(0).ToString
            prenomFour.Text = reader(1).ToString
            telephoneFour.Text = reader(2).ToString
            adressFour.Text = reader(3).ToString
            cnx.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

        dateApro.Text = dateAproo

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Hide()
        nomFour.Text = ""
        prenomFour.Text = ""
        telephoneFour.Text = ""
        adressFour.Text = ""
        dateApro.Text = ""


    End Sub
End Class