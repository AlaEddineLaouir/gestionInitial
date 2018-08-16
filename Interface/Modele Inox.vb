Imports MySql.Data.MySqlClient
Imports Bunifu.Framework.UI
Imports System.IO

Public Class Modele_Inox
    Private Sub NvModeleBTN_Click(sender As Object, e As EventArgs) Handles NvModeleBTN.Click
        ajouterModele.Show()
    End Sub

    Public Sub befresh()
        'Vider le milieu'
        Me.Milieu.Controls.Clear()
        GC.Collect()


        'compossant de de la carte '
        Dim backPanel As Panel
        Dim imageModele As PictureBox
        Dim bottomPanel As Panel
        Dim numModele As BunifuCustomLabel
        Dim prixModele As BunifuCustomLabel
        Dim unitePrix As BunifuCustomLabel
        Dim description As TextBox



        'Objet de la base de donnée'

        Dim cnx As MySqlConnection = New MySqlConnection
        cnx.ConnectionString = "server=localhost;userid=root;password=admin;database=gestionets"
        cnx.Open()

        Dim listModele As MySqlCommand = cnx.CreateCommand()
        listModele.CommandText = "select * from modeleinox"
        Dim dataReader As MySqlDataReader
        Try
            dataReader = listModele.ExecuteReader()

            Dim position As Integer = 0
            Dim location As Point = New Point(15, 15)
            While dataReader.Read()

                backPanel = New Panel()
                imageModele = New PictureBox()
                bottomPanel = New Panel()
                prixModele = New BunifuCustomLabel()
                numModele = New BunifuCustomLabel()
                unitePrix = New BunifuCustomLabel()
                description = New TextBox()

                With backPanel
                    .Location = location
                    .Width = 245
                    .Height = 325
                    .BackColor = Color.LightGray
                    .Padding = New Padding(1, 1, 2, 2)
                End With

                With imageModele
                    .Dock = DockStyle.Top
                    .SizeMode = PictureBoxSizeMode.StretchImage
                    .Width = 242
                    .Height = 195
                    .Image = Byte2Image(dataReader.Item("image"))
                End With

                With bottomPanel
                    .BackColor = Color.White
                    .Dock = DockStyle.Bottom
                    .Width = 247
                    .Height = 127
                End With

                With numModele
                    .Location = New Point(3, 5)
                    .ForeColor = Color.ForestGreen
                    .Font = New Font("Segeo UI", 12, FontStyle.Regular, GraphicsUnit.Point, 0, False)
                    .Text = dataReader.Item("id")
                    .Width = 52
                    .Height = 21
                End With

                With prixModele
                    .Location = New Point(120, 5)
                    .ForeColor = Color.Maroon
                    .Font = New Font("Segeo UI", 14.25, FontStyle.Regular, GraphicsUnit.Point, 0, False)
                    .Text = dataReader.Item("prix")
                    .Width = 86
                    .Height = 25
                End With

                With unitePrix
                    .Location = New Point(200, 5)
                    .Text = "DA/ML"
                    .Font = New Font("Segeo UI", 8, FontStyle.Regular, GraphicsUnit.Point, 0, False)
                    .ForeColor = Color.Maroon
                    .Width = 41
                    .Height = 13
                End With

                With description
                    .Dock = DockStyle.Bottom
                    .Height = 82
                    .Width = 242
                    .Multiline = True
                    .ReadOnly = True
                    .BackColor = Color.White
                    .ForeColor = Color.LightBlue
                    .Font = New Font("Segoe UI", 14.25, FontStyle.Regular, GraphicsUnit.Point, 0, False)
                    .Text = dataReader.Item("description")
                    .BorderStyle = BorderStyle.None
                End With

                bottomPanel.Controls.AddRange(New Control() {description, prixModele, unitePrix, numModele})
                backPanel.Controls.AddRange(New Control() {imageModele, bottomPanel})
                Me.Milieu.Controls.Add(backPanel)

                position = position + 1
                If (position Mod 4 = 0) Then
                    location = New Point(15, location.Y + 350)
                Else
                    location = New Point(location.X + 280, location.Y)
                End If

            End While
        Catch ex As Exception
        Finally
            dataReader.Dispose()
 
            cnx.Dispose()

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
