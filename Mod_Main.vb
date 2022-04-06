Imports System
Imports System.Management
Imports System.Data.OleDb
Module Mod_Main
    Public Class GVar ' Coordinate string variables
        Public Shared txtValueX As String 'Shared string
        Public Shared txtValueY As String ' Shared string
    End Class
    Public G_MyData As String = (System.AppDomain.CurrentDomain.BaseDirectory()) & "Groceries.accdb" 'Database location
    'Public G_MyData As String = "C:\Users\Lorna Walsh\Documents\11 COLLEGE\DMU\Project\VirtualShopper\Groceries.accdb"
    Public G_connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=" & G_MyData  'Connection String
    Public G_dbConnection As IDbConnection = New OleDb.OleDbConnection(G_connectionString)  'Golbal Connection
    Public G_dataset As New DataSet 'Global dataset
    Public G_ID As Int16  'Global ID variable
    Public G_Switch As Boolean 'Gloabl Boolean
    Public G_UserID As Int16 'Global User ID variable
    Public G_picFront As String 'Filepath string
    Public G_picDetails As String 'Filepath string
    Public G_picBack As String 'Filepath string
    Public G_Camera As String 'Filepath string

End Module
