Imports MySql.Data.MySqlClient

Public Class automatisme
    Public Sub befresh()
        Dim row As DataGridViewRow = New DataGridViewRow()
        row.Height = 100
        GridAuto.RowTemplate = row
        'Objet de la base de donnée'


        Dim cnx As MySqlConnection = New MySqlConnection
        cnx.ConnectionString = "server=localhost;userid=root;password=admin;database=gestionets"
        Dim sda As MySqlDataAdapter = New MySqlDataAdapter()
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource


        Try
            cnx.Open()
            Dim query As String = "select * from automatismePorte  "
            Dim command As New MySqlCommand(query, cnx)
            sda.SelectCommand = command
            sda.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            GridAuto.DataSource = bSource
            sda.Update(dbDataSet)
            cnx.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        GC.Collect()
    End Sub

    Private Sub NvModeleBTN_Click(sender As Object, e As EventArgs) Handles NvModeleBTN.Click
        ajouterAutomatisme.Show()
    End Sub
End Class
