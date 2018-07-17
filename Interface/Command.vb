Imports MySql
Imports MySql.Data.MySqlClient

Public Class Command
    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Dim cnx As MySqlConnection = New MySqlConnection
        cnx.ConnectionString = "server=localhost;userid=root;password=admin;database=vb_test"
        Dim sda As MySqlDataAdapter = New MySqlDataAdapter()
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource


        Try
            cnx.Open()
            Dim query As String = "select * from produit"
            Dim command As New MySqlCommand(query, cnx)
            sda.SelectCommand = command
            sda.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            GridCommand.DataSource = bSource
            sda.Update(dbDataSet)
            cnx.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click

        Dim id As String = idProduit.Text
        Dim nom As String = nomProduit.Text

        Dim cnx As MySqlConnection = New MySqlConnection
                cnx.ConnectionString = "server=localhost;userid=root;password=admin;database=vb_test"
                Dim reader As MySqlDataReader

                Try
                    cnx.Open()
            Dim query As String = "insert into produit values (" + id + ",'" + nom + "')"
            Dim command As New MySqlCommand(query, cnx)
                    reader = command.ExecuteReader
                    cnx.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    cnx.Dispose()
                End Try






    End Sub
End Class
