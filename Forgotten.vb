Imports System.Net
Imports System.IO
'-----------------------------
' Forgotten Password

' Input email address and display stored password
'-----------------------------
Public Class Forgotten
    Dim con As New OleDb.OleDbConnection      'Connection 
    Dim daForgotten As OleDb.OleDbDataAdapter 'Data adapter
    Dim dsForgotten As New DataSet            'Data set
    Dim sql As String                         'sql string

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        '----------------
        'OK click event
        '----------------
        dsForgotten.Tables.Clear() 'Clear dataset

        con = G_dbConnection   ' Set con as connection

        If con.State = ConnectionState.Closed Then con.Open() 'Open con

        'Fill dataset using email address
        sql = "Select * FROM Users WHERE Email_Address='" & txtemail.Text & "'"    'Select user data using email address
        daForgotten = New OleDb.OleDbDataAdapter(sql, con)  'Create new DataAdaptor query and connection string 
        daForgotten.Fill(dsForgotten, "Users")          'Fill DataSet

        'Determin if email address matches a user account
        If dsForgotten.Tables(0).Rows.Count = 0 Then 'If not recognised 
            MsgBox("There is no account registered with this email") ' Then show error message
        Else
            MsgBox("Your password is: " & dsForgotten.Tables("Users").Rows(0).Item("User_Password")) 'Else show password
        End If

        'Dispose of resources
        dsForgotten.Clear()
        dsForgotten.Dispose()
        daForgotten.Dispose()

        'Close form
        Login.Show() 'Show Login form
        Me.Close() 'Close current form

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        '-------------------------
        'Cancel click event
        '--------------------------
        Login.Show() 'Show Login form
        Me.Close() 'Close current form

    End Sub

End Class
