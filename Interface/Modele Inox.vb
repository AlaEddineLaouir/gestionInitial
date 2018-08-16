Imports MySql.Data.MySqlClient
Imports Bunifu.Framework.UI
Imports System.IO

Public Class Modele_Inox
    Private Sub NvModeleBTN_Click(sender As Object, e As EventArgs) Handles NvModeleBTN.Click
        ajouterModele.Show()
    End Sub

    Public Sub befresh()

        Dim row As DataGridViewRow = New DataGridViewRow()
        row.Height = 230
        GridModele.RowTemplate = row
        'Objet de la base de donnée'


        Dim cnx As MySqlConnection = New MySqlConnection
        cnx.ConnectionString = "server=localhost;userid=root;password=admin;database=gestionets"
        Dim sda As MySqlDataAdapter = New MySqlDataAdapter()
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource


        Try
            cnx.Open()
            Dim query As String = "select * from modeleinox "
            Dim command As New MySqlCommand(query, cnx)
            sda.SelectCommand = command
            sda.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            GridModele.DataSource = bSource
            sda.Update(dbDataSet)
            cnx.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Public Shared Function Byte2Image(ByVal byteArr() As Byte) As Drawing.Image

        Using ImageStream As New MemoryStream(byteArr)
            Dim newImage As Drawing.Image
            Try
                If byteArr.GetUpperBound(0) > 0 Then
                    newImage = System.Drawing.Image.FromStream(ImageStream)
                Else
                    newImage = Nothing
                End If
            Catch ex As Exception
                newImage = Nothing
            End Try
            Return newImage
        End Using

    End Function


End Class
