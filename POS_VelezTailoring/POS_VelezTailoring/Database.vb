Imports System.Data.SQLite

Module Database

    Public sqlite_conn As New SQLiteConnection("Data Source = " & Application.StartupPath & "\user_tbl.db")
    Dim adapter As SQLiteDataAdapter

    Public Sub open_conn()
        Try
            If sqlite_conn.State = ConnectionState.Closed Then
                sqlite_conn.Open()

            End If
        Catch ex As SQLiteException
            MsgBox("Error: " & ex.Message, vbCritical)

        End Try
    End Sub
    Public Sub close_conn()
        Try
            If sqlite_conn.State = ConnectionState.Open Then
                sqlite_conn.Close()

            End If
        Catch ex As SQLiteException
            MsgBox("Error: " & ex.Message, vbCritical)

        End Try
    End Sub

    Public Sub user_login(ByVal username As String, ByVal password As String)
        Try
            open_conn()
            Dim sql_command As New SQLiteCommand($"SELECT * FROM user_tbl WHERE `user_name` = '{username}' And `user_password` = '{password}';", sqlite_conn)
            Dim reader As SQLiteDataReader = sql_command.ExecuteReader
            If reader.Read Then
                MsgBox("REGISTERED SUCCESSFULLY", vbInformation)
                MessageBox.Show("Welcome user: " & reader.GetString(1), "Velez Tailoring")
                Dashboard.Show()
                Form1.Close()
            Else
                MsgBox("YOUR CREDENTIALS DON'T MATCH AN" & vbCrLf & "ACCOUNT IN OUR SYSTEM.", vbCritical, "Velez Tailoring")

            End If
        Catch ex As SQLiteException
        Finally
            close_conn()
        End Try


    End Sub

    Public Sub user_register(ByVal username As String, ByVal password As String)
        Try
            open_conn()
            Dim sql_command As New SQLiteCommand($"INSERT INTO user_tbl (`user_name`,`user_password`) VALUES ('{username}', '{password}');", sqlite_conn)
            sql_command.ExecuteNonQuery()
            MsgBox("REGISTERED SUCCESSFULLY", vbInformation)

        Catch ex As SQLiteException
            MsgBox("Error: " & ex.Message, vbCritical)
        Finally
            close_conn()

        End Try
    End Sub

End Module
