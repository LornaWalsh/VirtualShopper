Imports System.Net
Imports System.IO
Public Class ViewListCart
    Dim con As New OleDb.OleDbConnection    'Connection 
    Dim daList As OleDb.OleDbDataAdapter    'List Data adapter
    Dim dsList As New DataSet               'List Data set
    Dim sql As String                       'List sql string
    Dim dsTableName As String               'Table name string   
    Dim daDel As OleDb.OleDbDataAdapter     'Delete entries data adapter
    Dim dsDel As New DataSet                'Delete entries data set
    Dim daCopy As OleDb.OleDbDataAdapter    'Copy from List data adapter
    Dim dsCopy As New DataSet               'Copy from List data set
    Dim daFill As OleDb.OleDbDataAdapter    'Fill Cart data adapter
    Dim dsFill As New DataSet               'Fill Cart data set
    '------------------------------------------
    ' View shooping list or shopping cart
    '
    ' View items in list/cart, delete, add items to cart, and checkout.
    '------------------------------------------
    Private Sub ListCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '---------------------------------------------------
        'Load: Determine if List or Cart is to be displayed
        '---------------------------------------------------

        If G_Switch = True Then 'Boolean switch
            dsTableName = "List"
            btnAddOut.Text = "Add to cart"
        Else
            dsTableName = "Cart"
            btnAddOut.Text = "Checkout"
        End If
        lblListCart.Text = "Shopping " & dsTableName 'Display form name

        Call Load_In_Grid() 'Call sub
        Call Grid_SetUp() ' Call sub

    End Sub
    Public Sub Load_In_Grid()
        '-----------------------------------------------------
        '              Load Results In Grid
        '-----------------------------------------------------

        con = G_dbConnection    'Set connection to global connection string

        'Open Connection
        If con.State = ConnectionState.Closed Then con.Open() ' Open connection to the database if not already open.

        dsList.Clear()       ' Empty dataset.

        'SQL Query

        If G_Switch = True Then ' SQL for shopping list items
            sql = "SELECT List.ID, List.User_ID, List.Product_ID, Products_Main.Product, Products_Main.Price, List.Units
FROM Products_Main INNER Join List On Products_Main.Product_ID = List.Product_ID
WHERE List.User_ID = " & G_UserID
        Else ' SQL for shopping cart items
            sql = "SELECT Cart.ID, Cart.User_ID, Cart.Product_ID, Products_Main.Product, Products_Main.Price, Cart.Units
FROM Products_Main INNER Join Cart On Products_Main.Product_ID = Cart.Product_ID
WHERE Cart.User_ID = " & G_UserID
        End If

        daList = New OleDb.OleDbDataAdapter(sql, con) ' DataAdapter- Associate it with SQL query and connection   
        daList.Fill(dsList, dsTableName)              ' The fill method. This stores data from the DB into the dataset   


        If con.State = ConnectionState.Open Then con.Close() ' Close the connection after data access is done   

    End Sub
    Private Sub Grid_SetUp()
        '-----------------------------------------------------
        '              Set Up Grid
        '-----------------------------------------------------

        Me.DataGridView1.ReadOnly = False                   ' Make whole grid read only = false
        Me.DataGridView1.DataSource = dsList                ' The source of data for the grid view control is the dataset   
        Me.DataGridView1.DataMember = dsTableName           ' Specify data from which table is needed   
        Me.DataGridView1.Columns(3).HeaderText = "Product"  ' Set Header Text 
        Me.DataGridView1.Columns(3).ReadOnly = True         ' Make column read only
        Me.DataGridView1.Columns(4).HeaderText = "Price"    ' Set Header Text 
        Me.DataGridView1.Columns(4).ReadOnly = True         ' Make column read only
        Me.DataGridView1.Columns(5).HeaderText = "Quantity" ' Set Header Text 
        Me.DataGridView1.Columns(5).ReadOnly = True         ' Make column read only
        Me.DataGridView1.Columns(0).Visible = False         ' Hide first column of data - Key ID
        Me.DataGridView1.Columns(1).Visible = False         ' Hide the column with User ID
        Me.DataGridView1.Columns(2).Visible = False         ' Hide the column with Product ID
        Me.DataGridView1.RowHeadersVisible = False          ' Hide row headers
        Me.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect ' Select the full row when one cell within that row is selected 
        Me.DataGridView1.AllowUserToAddRows = False         ' Removes the blank row at the bottom of the datagrid
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill ' Fill the widths of the columns to width of the grid

        Me.DataGridView1.AllowUserToResizeRows = False      ' Stop user from resizing rows
        Call ADD_Column() 'Call sub to add checkbox column
    End Sub
    Private Sub ADD_Column()
        '-----------------------------------------------------
        '              Add a column
        '-----------------------------------------------------
        Dim AddColumn As New DataGridViewCheckBoxColumn 'Set new column as a checkbox control

        With AddColumn 'loop
            .HeaderText = "Highlight" 'Set header text
            .Name = "Highlight"       'Column Name
            .Width = 80               'Width
        End With

        DataGridView1.Columns.Insert(6, AddColumn) 'Insert new column
    End Sub

    Private Sub btnAddOut_Click(sender As Object, e As EventArgs) Handles btnAddOut.Click
        '----------------------------------------
        'Add to Cart/Checkout Button Click Event
        '----------------------------------------
        Dim addto As Boolean = False 'Boolean to control messagebox
        If G_Switch = True Then 'Boolean switch
            For i As Integer = Me.DataGridView1.RowCount - 1 To 0 Step -1 'Decending loop
                If Me.DataGridView1.Rows(i).Cells("Highlight").Value = True Then 'If checkbox selected then:
                    Call AddToCart(Me.DataGridView1.Rows(i).Cells(0).Value) 'Add to Cart and remove from List
                    addto = True
                End If
            Next
            If addto = True Then
                'Force data grid to refresh on click event
                If MessageBox.Show("Selected items have been added to your Shopping Cart ",
               "Add to Cart", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                    Load_In_Grid()
                End If
            Else
                MsgBox("No items selected")
            End If
        End If
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        '-----------------------------------------------------
        '              Delete: Remove item from list/cart
        '-----------------------------------------------------
        Dim delSelcted As Boolean = False 'Boolean to control messagebox
        'Warning if no items are available to delete
        If DataGridView1.Rows.Count = 0 Then
            MessageBox.Show("You have no items to delete",
            "Delete Items", MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        'Message box with option to delete selected items or cancel
        If MessageBox.Show("This will delete the selected items. Do you want to continue?",
       "Delete Items", MessageBoxButtons.YesNo,
       MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If


        'Loop through to find all selected rows. Delete them from grid and from the database table
        For i As Integer = Me.DataGridView1.RowCount - 1 To 0 Step -1 'Decending loop
            If Me.DataGridView1.Rows(i).Cells("Highlight").Value = True Then 'If checkbox selected then:
                delSelcted = True
                'Fill dataset with List/Cart entry to be deleted using the Key ID
                con = G_dbConnection                                  'Set connection to global connection string
                If con.State = ConnectionState.Closed Then con.Open() ' Open connection to the database if not already open.
                dsDel.Clear()                                         ' Empty dataset.
                'SQL Query
                If G_Switch = True Then ' SQL for shopping list items
                    sql = "SELECT * FROM List WHERE ID =" & Me.DataGridView1.Rows(i).Cells(0).Value 'Will return single entry with correct ID
                Else ' SQL for shopping cart items
                    sql = "SELECT * FROM Cart WHERE ID =" & Me.DataGridView1.Rows(i).Cells(0).Value 'Will return single entry with correct ID
                End If

                daDel = New OleDb.OleDbDataAdapter(sql, con) ' DataAdapter- Associate it with SQL query and connection   
                daDel.Fill(dsDel, dsTableName)               ' The fill method. This stores data from the DB into the dataset   

                Dim cb As New OleDb.OleDbCommandBuilder(daDel)  'New command
                dsDel.Tables(dsTableName).Rows(0).Delete()      'Delete the single row in the dataset
                daDel.Update(dsDel, dsTableName)                'Update data adapter and delete from Databse
                Me.DataGridView1.Rows.RemoveAt(i)               'Remove row from grid

            End If
        Next

        If delSelcted = True Then
            'Dispose of resources
            dsDel.Clear()
            dsDel.Dispose()        ' Dispose of the dataset
            daDel.Dispose()        ' Dispose of data adaptor
        Else
            MsgBox("No items selected")
        End If

    End Sub
    Private Sub AddToCart(List_ID As Integer)
        '---------------------------------------------------
        'Add selected items to Cart and remove from List
        '---------------------------------------------------
        con = G_dbConnection   ' Set con as connection

        If con.State = ConnectionState.Closed Then con.Open() 'Open con

        dsCopy.Clear()
        dsFill.Clear()

        'Fill data sets
        sql = "SELECT * FROM List WHERE ID =" & List_ID  ' Select All From NewResuls Table
        daCopy = New OleDb.OleDbDataAdapter(sql, con)    ' data adaptor using sql & con
        daCopy.Fill(dsCopy, "List")                      ' fill dataset

        sql = "SELECT * FROM Cart"                       ' Select All From NewResuls Table
        daFill = New OleDb.OleDbDataAdapter(sql, con)    ' data adaptor using sql & con
        daFill.Fill(dsFill, "Cart")                      ' fill dataset

        'Create new row in Cart table
        Dim dsNewRow As DataRow                              ' New data row
        Dim cb As New OleDb.OleDbCommandBuilder(daFill)      ' Create new command builder

        dsNewRow = dsFill.Tables("Cart").NewRow()            'Create new row

        dsNewRow.Item(1) = dsCopy.Tables("List").Rows(0).Item(1) 'Add User_ID
        dsNewRow.Item(2) = dsCopy.Tables("List").Rows(0).Item(2) 'Add Product_ID
        dsNewRow.Item(3) = dsCopy.Tables("List").Rows(0).Item(3) 'Add Quantity

        dsFill.Tables("Cart").Rows.Add(dsNewRow)           ' Add the new row


        daFill.UpdateCommand = cb.GetUpdateCommand() 'Get update command

        Try 'Catch errors
            daFill.Update(dsFill, "Cart")                  ' Update with new row
        Catch ex As Exception
            MessageBox.Show("Error")
        End Try
        'Dispose of resources
        dsFill.Clear()
        dsFill.Dispose()        ' Dispose of the dataset
        daFill.Dispose()        ' Dispose of data adaptor  

        'Delete selected items from shopping list
        Dim cb1 As New OleDb.OleDbCommandBuilder(daCopy)  'New command
        dsCopy.Tables("List").Rows(0).Delete()            'Delete the single row in the dataset
        daCopy.Update(dsCopy, "List")                     'Update data adapter and delete from Database
        'Dispose of resources
        dsCopy.Clear()
        dsCopy.Dispose()        ' Dispose of the dataset
        daCopy.Dispose()        ' Dispose of data adaptor

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        '-------------------------------------------------------------------
        'Cell selction event - display total price of selcted items
        '-------------------------------------------------------------------

        '_______TDD - Cannot get this to work.....
        '
        If Me.DataGridView1.Rows.Count = 0 Then
            Exit Sub
        Else
            Dim Total As Integer = 0 'Total var
            For i As Integer = Me.DataGridView1.RowCount - 1 To 0 Step -1 'Decending loop
                If Me.DataGridView1.Rows(i).Cells("Highlight").Value = True Then 'If checkbox selected then:
                    Total += (Me.DataGridView1.Rows(i).Cells(4).Value * Me.DataGridView1.Rows(i).Cells(5).Value) 'Add total price
                End If
            Next
            lblTotal.Text = Total 'Display total price
        End If
    End Sub
End Class