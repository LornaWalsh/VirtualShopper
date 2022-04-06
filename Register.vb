Imports System.Net
Imports System.IO
Public Class Register
    Dim con As New OleDb.OleDbConnection   'Connection 
    Dim daReg As OleDb.OleDbDataAdapter    'Data adapter
    Dim dsReg As New DataSet               'Data set
    Dim sql As String                      'sql string
    '-----------------------------
    ' Register for user account
    '-----------------------------
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '---------
        'Form load
        '----------
        'Set control focus
        txtuser.Focus()
    End Sub
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        '--------------------
        'Cancel click event
        '--------------------
        Me.Close() 'Close current form
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        '--------------------
        'OK click event
        '--------------------

        con = G_dbConnection   ' Set con as connection

        If con.State = ConnectionState.Closed Then con.Open() 'Open con

        dsReg.Clear()
        sql = "SELECT * FROM Users"                  ' Select all from Users
        daReg = New OleDb.OleDbDataAdapter(sql, con) ' data adaptor using sql & con
        daReg.Fill(dsReg, "Users")                   ' fill dataset

        Dim dsNewRow As DataRow                             ' New data row
        Dim cb As New OleDb.OleDbCommandBuilder(daReg)      ' Create new command builder using the daReg DataAdaptor


        dsNewRow = dsReg.Tables("Users").NewRow()         'Create new row

        'Fill New Row from textboxes 
        dsNewRow.Item(1) = txtuser.Text     'Add username
        dsNewRow.Item(2) = txtpassword.Text 'Add password
        dsNewRow.Item(3) = txtemail.Text    'Add email address

        dsReg.Tables("Users").Rows.Add(dsNewRow)      'Add the new row
        daReg.UpdateCommand = cb.GetUpdateCommand()   'Get update command

        'Catch errors
        Try
            daReg.Update(dsReg, "Users")  'Update Datatable 
        Catch ex As Exception
            MessageBox.Show("Error")      'Display message if error is caught
        End Try

        'Dispose of resources
        dsReg.Clear()          ' Clear dataset
        dsReg.Dispose()        ' Dispose of the dataset
        daReg.Dispose()        ' Dispose of data adaptor  

        MsgBox("Registration Successful. Please login")  'Display message

        Login.Show() 'Show Login form
        Me.Close()   'Close current form
    End Sub

End Class
