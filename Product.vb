Imports System.Net
Imports System.IO
Imports Microsoft.Office.Interop.Access.Dao
'-------------------------
' View selected product 
' Select from different images, choose quantity, add to cart, and add to shopping list.
Public Class Product
    Dim con As New OleDb.OleDbConnection    'Connection 
    Dim daList As OleDb.OleDbDataAdapter    'Data adapter
    Dim dsList As New DataSet               'Data set
    Dim sql As String                       'sql string
    Dim daProduct As OleDb.OleDbDataAdapter 'Data adapter
    Dim dsProduct As New DataSet            'Data set
    Dim sqlProduct As String                'sql string

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '-------------
        'Load Form
        '-------------
        Call Fill_PictureBoxes() 'Retrieve product images from database
    End Sub

    Private Sub Fill_PictureBoxes()
        '--------------------------------
        'Get attachments from Database
        '--------------------------------
        'OleDb Jet Engin doesn't support attachements in Access
        'Dao DBEngine required 
        '
        'Code snipit taken from Paul Clemet  https://social.msdn.microsoft.com/Forums/en-US/eb0a287f-e98e-4e90-86d7-f959615b8fa4/how-to-download-my-pdf-attachment-on-access-by-using-vb-net?forum=vbgeneral
        'Full reference in report
        '----------------------------------
        Dim dbEngine As DBEngine 'Dao engin
        dbEngine = New DBEngine() 'Initalise
        Dim SQLMain As String 'sql
        Dim AccessEngine As New Microsoft.Office.Interop.Access.Dao.DBEngine 'Dao Access engin
        Dim SourceRecordset As Microsoft.Office.Interop.Access.Dao.Recordset 'Record set
        Dim AttachmentRecordset As Microsoft.Office.Interop.Access.Dao.Recordset 'Recod set of attachements
        Dim SQLDetails As String 'sql
        Dim db As Microsoft.Office.Interop.Access.Dao.Database = AccessEngine.OpenDatabase(G_MyData) 'Dao db connection

        'Get attachments from Products_Main table
        SQLMain = "SELECT * FROM Products_Main WHERE Product_ID =" & G_ID
        SourceRecordset = db.OpenRecordset(SQLMain) 'Get full dataset
        AttachmentRecordset = SourceRecordset.Fields("Front").Value 'Get attachement records 
        Dim AttachmentFileName As String = AttachmentRecordset.Fields("FileName").Value.ToString 'Filename
        Dim AttachmentPath As String = (System.AppDomain.CurrentDomain.BaseDirectory()) & "\" & AttachmentFileName 'Filepath
        While Not AttachmentRecordset.EOF 'While not the end of recordset
            If Dir(AttachmentPath) = "" Then 'If the file doesn't exsist
                AttachmentRecordset.Fields("FileData").SaveToFile(AttachmentPath) 'Save
            End If
            AttachmentRecordset.MoveNext()
        End While

        'Clear recordset
        AttachmentRecordset = Nothing

        'Create image from file
        Dim picture As Image 'create image object 
        picture = Image.FromFile(AttachmentPath) 'Build the image
        pbxMain.SizeMode = PictureBoxSizeMode.StretchImage 'Set background style
        pbxMain.BackgroundImage = picture 'Set picture as background image
        G_picFront = AttachmentPath 'Save filepath

        'pbxFront
        pbxFront.SizeMode = PictureBoxSizeMode.StretchImage 'Set background style
        pbxFront.BackgroundImage = picture 'Set picture as background image

        'pbxBack
        AttachmentRecordset = SourceRecordset.Fields("Back").Value 'Get record of attachements
        AttachmentFileName = AttachmentRecordset.Fields("FileName").Value.ToString 'Filename
        AttachmentPath = (System.AppDomain.CurrentDomain.BaseDirectory()) & "\" & AttachmentFileName 'Filepath
        While Not AttachmentRecordset.EOF 'While not the end of recordset
            If Dir(AttachmentPath) = "" Then 'If file doesn't exsist 
                AttachmentRecordset.Fields("FileData").SaveToFile(AttachmentPath) 'Save file
            End If
            AttachmentRecordset.MoveNext()
        End While

        'Dispose of resources
        SourceRecordset.Close()
        SourceRecordset = Nothing
        AttachmentRecordset = Nothing

        Dim pictureBack As Image 'create image object 
        pictureBack = Image.FromFile(AttachmentPath) 'Build the image
        pbxBack.SizeMode = PictureBoxSizeMode.StretchImage
        pbxBack.BackgroundImage = pictureBack
        G_picBack = AttachmentPath

        'Get attachement from Product_Details table
        SQLDetails = "SELECT * FROM Product_Details WHERE Product_ID =" & G_ID
        SourceRecordset = db.OpenRecordset(SQLDetails) 'Get full dataset
        AttachmentRecordset = SourceRecordset.Fields("Product_Info").Value 'Get attachments
        If AttachmentRecordset.RecordCount > 0 Then
            Dim AttachmentFileName1 As String = AttachmentRecordset.Fields("FileName").Value.ToString 'Filename 
            Dim AttachmentPath1 As String = (System.AppDomain.CurrentDomain.BaseDirectory()) & "\" & AttachmentFileName1 'Filepath
            While Not AttachmentRecordset.EOF 'While not the end of the recordset
                If Dir(AttachmentPath1) = "" Then 'If file doesn't exsis
                    AttachmentRecordset.Fields("FileData").SaveToFile(AttachmentPath1) 'Save file
                End If
                AttachmentRecordset.MoveNext()
            End While
            Dim pictureDetails As Image 'create image object 
            pictureDetails = Image.FromFile(AttachmentPath1) 'Build the image
            pbxDetails.SizeMode = PictureBoxSizeMode.StretchImage 'Set size mode
            pbxDetails.BackgroundImage = pictureDetails 'Set picture as background image
            G_picDetails = AttachmentPath1 'Save filepath
        Else
            pbxDetails.BackgroundImage = Image.FromFile((System.AppDomain.CurrentDomain.BaseDirectory()) & "VSFullLogo.png") 'Set imaage from file
            pbxDetails.Enabled = False 'if no picture to display then hide control
        End If


        'Dispose of resources
        SourceRecordset.Close()
        SourceRecordset = Nothing
        AttachmentRecordset = Nothing
        db.Close()
        db = Nothing



    End Sub

    Private Sub pbxFront_Click(sender As Object, e As EventArgs) Handles pbxFront.Click
        '----------------------------------------------------------------
        ' When clicked fill the main picture box with the FRONT image
        '----------------------------------------------------------------
        pbxMain.BackgroundImage = Image.FromFile(G_picFront)

    End Sub
    Private Sub pbxBack_Click_1(sender As Object, e As EventArgs) Handles pbxBack.Click
        '---------------------------------------------------------------
        ' When clicked fill the main picture box with the BACK image
        '--------------------------------------------------------------
        pbxMain.BackgroundImage = Image.FromFile(G_picBack)
    End Sub
    Private Sub pbxDetails_Click(sender As Object, e As EventArgs) Handles pbxDetails.Click
        '-----------------------------------------------
        'Load the details picture into main picturebox
        '-----------------------------------------------
        pbxMain.BackgroundImage = Image.FromFile(G_picDetails)
    End Sub

    Private Sub btnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        '--------------------------
        ' Add to Cart click event
        '--------------------------
        AddTo(False) 'Set switch to False
    End Sub

    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
        '-------------------------
        'Add to List click event
        '-------------------------
        AddTo(True) 'Set switch to True
    End Sub

    Private Sub AddTo(ByVal Switch As Boolean)
        '---------------------
        ' Add to List/Cart
        '---------------------
        Dim dsTableName As String

        If Switch = True Then 'Determin if adding to List or Cart
            dsTableName = "List"
        Else
            dsTableName = "Cart"
        End If

        con = G_dbConnection   ' Set con as connection

        If con.State = ConnectionState.Closed Then con.Open() 'Open con

        dsList.Clear()

        sql = "SELECT * FROM [" & dsTableName & "]"           ' Select All
        daList = New OleDb.OleDbDataAdapter(sql, con)         'data adaptor using sql & con
        daList.Fill(dsList, dsTableName)                      ' fill dataset

        Dim dsNewRow As DataRow                               'New data row
        Dim cb As New OleDb.OleDbCommandBuilder(daList)       'Create new command builder

        dsNewRow = dsList.Tables(dsTableName).NewRow()        'Create new row

        dsNewRow.Item(1) = G_UserID             'Add User_ID
        dsNewRow.Item(2) = G_ID                 'Add Product_ID
        dsNewRow.Item(3) = numUnits.Value       'Add Qantity

        dsList.Tables(dsTableName).Rows.Add(dsNewRow)           ' Add the new row
        daList.UpdateCommand = cb.GetUpdateCommand()            ' Build command

        Try 'Catch errors
            daList.Update(dsList, dsTableName)                  ' Update Datatable 
        Catch ex As Exception
            MessageBox.Show("Error")
        End Try

        'Dispose of resources
        dsList.Clear()
        dsList.Dispose()        ' Dispose of the dataset
        daList.Dispose()        ' Dispose of data adaptor  

        MsgBox("Added To Shopping " & dsTableName)
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        '-----------------
        'Close Form
        '-----------------
        '_______TDD - trying to kill the process accessing the saved images so they can be deleted.... not successful
        pbxBack.BackgroundImage.Dispose()
        pbxFront.BackgroundImage.Dispose()
        pbxDetails.BackgroundImage.Dispose()
        pbxMain.BackgroundImage.Dispose()

        pbxBack.BackgroundImage = Nothing
        pbxFront.BackgroundImage = Nothing
        pbxDetails.BackgroundImage = Nothing
        pbxMain.BackgroundImage = Nothing


        Me.Close() 'Close form

    End Sub
End Class