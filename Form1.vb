Imports MySql.Data.MySqlClient 'NEED TO ADD "MYSQL.DATA.DLL" AS PROJECT REFERENCE
Public Class Form1
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

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim strsql As String = "insert into users values('" & Me.txtuserid.Text & "','" & Me.txtname.Text & "')"
        Connect_to_DB()
        Dim mycommand As New MySqlCommand
        Try
            mycommand.Connection = DBConnection
            mycommand.CommandText = strsql
            mycommand.ExecuteNonQuery()
            MsgBox("Successfully added.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Disconnect_to_DB()
    End Sub

    Private Sub btnloadusers_Click(sender As Object, e As EventArgs) Handles btnloadusers.Click
        Me.dgusers.Rows.Clear()
        Dim strsql As String
        Dim mycommand As New MySqlCommand
        strsql = "Select * from users"
        Connect_to_DB()
        With mycommand
            .Connection = DBConnection
            .CommandType = CommandType.Text
            .CommandText = strsql
        End With
        Dim myreader As MySqlDataReader
        myreader = mycommand.ExecuteReader
        While myreader.Read()
            Me.dgusers.Rows.Add(New Object() {myreader.Item("user_id"), myreader.Item("username")})
        End While
        Disconnect_to_DB()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim strsql As String
        strsql = "Update users set username = '" _
        & Me.txtname.Text & "' where user_id = '" & Me.txtuserid.Text & "'"
        MsgBox(strsql)
        Connect_to_DB()
        Dim mycommand As New MySqlCommand
        Try
            mycommand.Connection = DBConnection
            mycommand.CommandText = strsql
            mycommand.ExecuteNonQuery()
            MsgBox("Record Updated.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Disconnect_to_DB()
        Call btnloadusers_Click(sender, e)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim strsql As String
        strsql = "Delete from users " _
        & " where user_id = '" & Me.txtuserid.Text & "'"
        MsgBox(strsql)
        Connect_to_DB()
        Dim mycommand As New MySqlCommand
        Try
            mycommand.Connection = DBConnection
            mycommand.CommandText = strsql
            mycommand.ExecuteNonQuery()
            MsgBox("Record Deleted.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Disconnect_to_DB()
        Call btnloadusers_Click(sender, e)
    End Sub
End Class
