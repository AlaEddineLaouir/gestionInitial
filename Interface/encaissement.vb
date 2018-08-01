Imports MySql.Data.MySqlClient

Public Class encaissement
    Private Sub fermer()
        InputMontant.Text = ""
        inputNature.Text = ""
        InputObs.Text = ""
        Me.Hide()
    End Sub
    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        fermer()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        fermer()
    End Sub

    Private Sub ok_Click(sender As Object, e As EventArgs) Handles ok.Click
        Dim dateE As String = DateTime.Today.ToString("yyyy-MM-dd")
        Dim heure As String = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString()
        Dim nature As String = inputNature.Text
        Dim obser As String = InputObs.Text
        Dim montant As Double
        Dim aller As Boolean = True

        Try
            montant = CDbl(InputMontant.Text)
            If (nature.Equals("") Or InputMontant.Text.Equals("")) Then
                Throw New Exception()
            End If
        Catch ex As Exception
            MessageBox.Show("Verfie les valeur que vous avez entrées")
            aller = False
        End Try

        If (aller) Then
            Dim type = action.Text
            Dim cnx As MySqlConnection = New MySqlConnection
            cnx.ConnectionString = "server=localhost;userid=root;password=admin;database=gestionets"
            Try
                cnx.Open()
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
            Dim Trans As MySqlTransaction = cnx.BeginTransaction()
            Try


                Dim getEtat As MySqlCommand = cnx.CreateCommand()
                getEtat.Transaction = Trans
                getEtat.CommandText = "select etatCaisse from caisse where id >= All (select id from caisse) "
                Dim etat As Double = CDbl(getEtat.ExecuteScalar())

                If (type.Equals("Debiter")) Then
                    etat = etat - montant
                Else
                    etat = etat + montant
                End If

                Dim command As MySqlCommand = cnx.CreateCommand()
                Dim query As String =
                "insert into caisse (ladate,heure,montant,type,obs,nature,etatCaisse) values 
                ('" + dateE + "','" + heure + "'," + montant.ToString() + ",'" + type + "','" + obser + "',
                    '" + nature + "','" + etat.ToString() + "')"
                command.CommandText = query


                command.ExecuteNonQuery()
                Trans.Commit()
                cnx.Close()
                Principale.Caisse1.refresh()
            Catch ex As Exception
                Trans.Rollback()
            Finally
                cnx.Dispose()
                fermer()
            End Try


        End If

    End Sub
End Class