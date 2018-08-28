Imports MySql.Data.MySqlClient

Public Class Prestation

    Public Sub befresh()
        Dim cnx As MySqlConnection = New MySqlConnection
        cnx.ConnectionString = "server=localhost;userid=root;password=admin;database=gestionets"
        Dim sda As MySqlDataAdapter = New MySqlDataAdapter()
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Dim dateFiltre As String = CStr(dateSelec.Value.ToString("yyyy-MM-dd"))

        Try
            cnx.Open()
            Dim query As String = "select datecommande  , totalpayer,datePrestation ,concat(nom,' ',prenom,' ',telephone,' ',adress) as info, p.id as num  from prestation p ,client c  where  p.client=c.id and datevente >= '" + dateFiltre + "'"
            Dim command As New MySqlCommand(query, cnx)
            sda.SelectCommand = command
            sda.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            GridPrestation.DataSource = bSource
            sda.Update(dbDataSet)
            cnx.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        nouvellePrestation.Show()
    End Sub
End Class
