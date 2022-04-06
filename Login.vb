Imports System.Net
Imports System.IO
'----------------------------------------
' Login
' Login or register for a user account
'----------------------------------------
Public Class Login
    Dim con As New OleDb.OleDbConnection     'Connection 
    Dim daLogin As OleDb.OleDbDataAdapter    'Data adapter
    Dim dsLogin As New DataSet               'Data set
    Dim sql As String                        'sql string
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '------------------------
        'Load: Login or Register
        '------------------------
        ' Hide controls
        txtuser.Visible = False
        txtpassword.Visible = False

        lbluser.Visible = False
        lblpassword.Visible = False

        btnok.Visible = False
        btncancel.Visible = False

        lblfogotten.Visible = False

        'Ensure global user ID variable is blank
        G_UserID = 0
    End Sub
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        '----------------
        ' Login Selected
        '----------------
        'Show controls
        txtuser.Visible = True
        txtpassword.Visible = True

        lbluser.Visible = True
        lblpassword.Visible = True

        btnok.Visible = True
        btncancel.Visible = True

        lblfogotten.Visible = True

        btnlogin.Visible = False
        btnreg.Visible = False

        'Set control focus
        txtuser.Focus()

    End Sub

    Private Sub btnreg_Click(sender As Object, e As EventArgs) Handles btnreg.Click
        '---------------------
        ' Register Selected
        '---------------------
        Register.Show() 'Open Register form
        Me.Close()      'Close current form
    End Sub
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        '------------------------------
        ' Login: OK click event
        '------------------------------
        dsLogin.Tables.Clear() 'Clear dataset

        con = G_dbConnection   'Set con as connection

        If con.State = ConnectionState.Closed Then con.Open() 'Open con

        'Fill dataset using username and password
        sql = "SELECT * FROM Users WHERE Username= '" & txtuser.Text & "' And User_Password ='" & txtpassword.Text & "'" 'Select all user data based on username password
        daLogin = New OleDb.OleDbDataAdapter(sql, con)  'Create new DataAdaptor query and connection string 
        daLogin.Fill(dsLogin, "Users")                  'Fill DataSet

        'Determin if password and username match entry in Db
        If dsLogin.Tables(0).Rows.Count = 0 Then                          'If the user details do not exsist
            MessageBox.Show("There is an error with username or password") 'Show error message
        Else 'If user exists
            G_UserID = dsLogin.Tables(0).Rows(0).Item("ID") ' Set gloabl var
            Main.Show() 'Show form
            Me.Close() 'Close current form
        End If
        'Dispose of resources
        dsLogin.Clear()
        dsLogin.Dispose()
        daLogin.Dispose()

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        '--------------------------
        'Login: Cancel click event
        '--------------------------
        Me.Close() 'Close current form
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblfogotten.LinkClicked
        '------------------------------------
        'Forgotten password link click event
        '------------------------------------
        Forgotten.Show() 'Show Forgotten form
        Me.Close() 'Close current form

    End Sub

End Class
