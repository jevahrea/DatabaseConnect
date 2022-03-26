Imports MySql.Data.MySqlClient
Public Class LoginForm1
    Public DBConnection As New MySqlConnection 'NEED TO ADD "MYSQL.DATA.DLL" AS PROJECT REFERENCE

    Public Sub Connect_to_DB()
        Dim DBConnectionstring As String = "Server=localhost;Uid=mike;Pwd='mike';Database=sampledb;"
        With DBConnection
            Try
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = DBConnectionstring
                .Open()
            Catch ex As MySqlException
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Error")
                Call Disconnect_to_DB()
            End Try
        End With
    End Sub
    Public Sub Disconnect_to_DB()
        With DBConnection
            .Close()
            .Dispose()

        End With
    End Sub
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim strsql As String
        Dim mycommand As New MySqlCommand
        strsql = "Select * from users where username = '" & Me.UsernameTextBox.Text _
            & "' and pass = '" & Me.PasswordTextBox.Text & "'"

        Connect_to_DB()
        With mycommand
            .Connection = DBConnection
            .CommandType = CommandType.Text
            .CommandText = strsql
        End With
        Dim myreader As MySqlDataReader
        myreader = mycommand.ExecuteReader
        If myreader.HasRows Then
            Me.Hide()
            Form1.Show()
        Else
            MessageBox.Show("Invalid Username or Password")
        End If
        Disconnect_to_DB()

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
