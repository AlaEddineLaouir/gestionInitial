Imports MySql.Data.MySqlClient

Public Class Caisse



    Public Sub refreshcaisse()

        Dim cnx As MySqlConnection = New MySqlConnection
        cnx.ConnectionString = "server=localhost;userid=root;password=admin;database=gestionets"
        Dim sda As MySqlDataAdapter = New MySqlDataAdapter()
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Dim dateSelection As String = CStr(dateDeSelection.Value.ToString("yyyy-MM-dd"))

        Try
            cnx.Open()
            Dim query As String = "select montant,nature,ladate,heure, obs ,etatCaisse,type from Caisse where ladate >='" + dateSelection + "'"
            Dim command As New MySqlCommand(query, cnx)
            sda.SelectCommand = command
            sda.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            GridCaisse.DataSource = bSource
            sda.Update(dbDataSet)
            cnx.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

        Try
            Initial.Text = GridCaisse.Rows(0).Cells(5).Value
        Catch ex As Exception
            Initial.Text = "0,0"
        End Try

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        encaissement.action.Text = ("Debiter")
        encaissement.Show()
    End Sub

    Private Sub dateDeSelection_onValueChanged(sender As Object, e As EventArgs) Handles dateDeSelection.onValueChanged
        refresh()
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        encaissement.action.Text = ("Crediter")
        encaissement.Show()
    End Sub

    Private Sub Caisse_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub GridCaisse_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub GridProduit_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class
