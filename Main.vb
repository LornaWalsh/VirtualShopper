Imports System.Net
Imports System.IO
'--------------------------------
' Visual Shopper main form
' View image of shelves, select items from image, view item details, view shopping list, and view shopping cart.
'--------------------------------
Public Class Main
    Dim con As New OleDb.OleDbConnection     'Connection 
    Dim daItems As OleDb.OleDbDataAdapter    'Data adapter 
    Dim dsItems As New DataSet               'Data set
    Dim sql As String                        'sql string
    Dim CameraNum As Integer

    Private Sub Input_Image_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '------------
        'Form load
        '------------
        pbxIn.BackgroundImage = Image.FromFile((System.AppDomain.CurrentDomain.BaseDirectory()) & "VSFullLogo.png") 'Set default image of the logo
    End Sub

    Private Sub pbxIn_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbxIn.MouseDown
        '------------------
        'Mouse Down Event 
        '-------------------
        'Will log the coordinates where the user has clicked
        GVar.txtValueX = e.X.ToString 'Store the x coordinate in a global vairiable
        GVar.txtValueY = e.Y.ToString 'Store the y coordinate in a global vairiable
        txtX.Text = GVar.txtValueX  'Display the x coordinate
        txtY.Text = GVar.txtValueY  'Display the y coordinate

        dsItems.Tables.Clear() 'Clear dataset

        con = G_dbConnection   ' Set con as connection

        If con.State = ConnectionState.Closed Then con.Open() 'Open con

        'Determin which item has the coordinate range that includes the mouse pointer coordinates and the selected camera
        sql = "SELECT * FROM Products_Main WHERE x1 <= " & GVar.txtValueX & " AND x2 >= " & GVar.txtValueX & " AND y1 <= " & GVar.txtValueY & " AND y2 >= " & GVar.txtValueY & " AND Camera = " & CameraNum  'Select the item based on coordinates and selected camera
        daItems = New OleDb.OleDbDataAdapter(sql, con)  'Create new DataAdaptor query and connection string 
        daItems.Fill(dsItems, "Products_Main")          'Fill DataSet

        'Display item brand and name or show error message
        If dsItems.Tables(0).Rows.Count = 0 Then 'If dataset is empty
            MsgBox("No items have been selected") 'show error
        Else
            G_ID = dsItems.Tables("Products_Main").Rows(0).Item("Product_ID") ' Set global ID based on selected product ID
            'For testing
            lblItem.Text = "Chosen Item - " & dsItems.Tables("Products_Main").Rows(0).Item("Brand") & " " & dsItems.Tables("Products_Main").Rows(0).Item("Product") ' Display product name
        End If


        If con.State = ConnectionState.Open Then con.Close() 'Close con
    End Sub

    Private Sub btnCam1_Click(sender As Object, e As EventArgs) Handles btnCam1.Click
        '----------------
        ' Camera 1
        '---------------
        Call Display_Cam1() 'Display the feed from camera 1

    End Sub

    Private Sub btnCam2_Click(sender As Object, e As EventArgs) Handles btnCam2.Click
        '------------
        ' Camera 2
        '------------
        Call Display_Cam2() 'Display the feed from camera 2

    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        '-----------------------------------
        'View details of selected product
        '-----------------------------------
        If txtX.Text = "" Or txtY.Text = "" Then 'If no full set of coordinates retrieved then exit 
            Exit Sub
        End If
        If con.State = ConnectionState.Open Then con.Close() 'Close con
        Product.Show() 'Show Product form
    End Sub

    Private Sub ShoppingListToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ShoppingListToolStripMenuItem1.Click
        '--------------------
        'View shopping list
        '--------------------
        G_Switch = True 'Set Boolean switch to true for Shopping List
        ViewListCart.Show() 'Open Shopping List form
    End Sub

    Private Sub CartToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CartToolStripMenuItem1.Click
        '--------------------
        'View shopping cart
        '--------------------
        G_Switch = False 'Set Boolean switch to false for Shopping Cart
        ViewListCart.Show() 'Open Shopping Cart form
    End Sub
    Private Sub Display_Cam1()
        '--------------------------------
        ' Display feed from camera 1
        '--------------------------------

        'Release current image from picturebox
        pbxIn.BackgroundImage.Dispose()
        pbxIn.BackgroundImage = Nothing

        Dim myCamUrl As String = "http://116.118.0.254:333/image/jpeg.cgi" 'Camera1 url
        Dim client As New WebClient 'Set webclient

        CameraNum = 1 'Camera 1 is in use
        Try
            client.Credentials = New NetworkCredential("admin", "YnSmRiUQ") 'Save username and password
            client.DownloadFile(myCamUrl, (System.AppDomain.CurrentDomain.BaseDirectory()) & "Camera.jpg") 'Take image and save
            G_Camera = System.AppDomain.CurrentDomain.BaseDirectory() & "Camera.jpg" ' store image file path
            pbxIn.BackgroundImage = Image.FromFile((System.AppDomain.CurrentDomain.BaseDirectory()) & "Camera.jpg") 'Display saved image
        Catch ex As Exception
            MsgBox("Connection error") 'Catch connection error
            pbxIn.BackgroundImage = Image.FromFile((System.AppDomain.CurrentDomain.BaseDirectory()) & "VsFullLogo.png") 'Display logo
        End Try
    End Sub

    Private Sub Display_Cam2()
        '------------------------------
        ' Display feed from camera 2
        '------------------------------
        'Release current image from picturebox
        pbxIn.BackgroundImage.Dispose()
        pbxIn.BackgroundImage = Nothing

        Dim myCamUrl As String = "http://116.118.0.254:334/image/jpeg.cgi" 'Camera2 url
        Dim client As New WebClient 'Set webclient

        CameraNum = 2 'Camera 2 is in use

        Try
            client.Credentials = New NetworkCredential("admin", "cmAAvRDi") 'Save username and password
            client.DownloadFile(myCamUrl, (System.AppDomain.CurrentDomain.BaseDirectory()) & "Camera.jpg") 'Take image and save
            pbxIn.BackgroundImage = Image.FromFile((System.AppDomain.CurrentDomain.BaseDirectory()) & "Camera.jpg") 'Display saved image
            MsgBox("file downloaded")

        Catch ex As Exception
            MsgBox("Connection error") 'Catch connection error
            pbxIn.BackgroundImage = Image.FromFile((System.AppDomain.CurrentDomain.BaseDirectory()) & "VSFullLogo.png") 'Display logo
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        '---------------------
        ' Exit application
        '--------------------

        'Clean up any downloaded images - product images from Product Form are downloaded and not deleted


        '_______TDD - Can't delete the files as still being used by another process. I have set the Dispose() property on the picture boxes on the close event of the Products screen but it has not solved this issue. 



        'If My.Computer.FileSystem.FileExists(G_picBack) Then
        '    My.Computer.FileSystem.DeleteFile(G_picBack)
        'End If
        'If My.Computer.FileSystem.FileExists(G_picDetails) Then
        '    My.Computer.FileSystem.DeleteFile(G_picDetails)
        'End If
        'If My.Computer.FileSystem.FileExists(G_picFront) Then
        '    My.Computer.FileSystem.DeleteFile(G_picFront)
        'End If
        '--------------------
        'Exit application
        '--------------------
        Application.Exit()
        End
    End Sub

    Private Sub btnCam1Image_Click(sender As Object, e As EventArgs) Handles btnCam1Image.Click
        '----------------------------------
        'Show backup image for Camera 1
        '----------------------------------
        '_______TDD - capturing a live image from the camera is difficult due to unreliable connection and a difficulty in providing a uniform simulation enviroment
        CameraNum = 1 'Camera 1 is in use
        pbxIn.BackgroundImage = Image.FromFile((System.AppDomain.CurrentDomain.BaseDirectory()) & "Camera1Backup.jpg")
    End Sub

    Private Sub btnCam2Image_Click(sender As Object, e As EventArgs) Handles btnCam2Image.Click
        '----------------------------------
        'Show backup image for Camera 2
        '----------------------------------
        '_______TDD - capturing a live image from the camera is difficult due to unreliable connection and a difficulty in providing a uniform simulation enviroment
        CameraNum = 2 'Camera 2 is in use
        pbxIn.BackgroundImage = Image.FromFile((System.AppDomain.CurrentDomain.BaseDirectory()) & "Camera2Backup.jpg")
    End Sub

End Class
