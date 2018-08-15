Imports MySql.Data.MySqlClient
Public Class Vente

    Public Sub refresh()
        Dim cnx As MySqlConnection = New MySqlConnection
        cnx.ConnectionString = "server=localhost;userid=root;password=admin;database=gestionets"
        Dim sda As MySqlDataAdapter = New MySqlDataAdapter()
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Dim dateFiltre As String = CStr(dateSelec.Value.ToString("yyyy-MM-dd"))

        Try
            cnx.Open()
            Dim query As String = "select datevente As date  , sum(prix * quantite) As total , concat(nom,' ',prenom,' ',telephone) as info  from vente v , produitvente pv ,client c  where v.id=pv.vente and v.client=c.id and datevente >= '" + dateFiltre + "' group by v.id"
            Dim command As New MySqlCommand(query, cnx)
            sda.SelectCommand = command
            sda.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            GridVente.DataSource = bSource
            sda.Update(dbDataSet)
            cnx.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub BunifuThinButton21_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        nouvelleVente.Show()
    End Sub

    Private Sub Vente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dateSelec.Value = DateTime.Now
    End Sub

    Private Sub dateSelec_onValueChanged(sender As Object, e As EventArgs) Handles dateSelec.onValueChanged
        refresh()
    End Sub
End Class
