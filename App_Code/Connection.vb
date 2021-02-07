Imports System.Data.SqlClient
Imports System.Data.DataSet
Imports System.Data

Public Class ConnectionDB
    Function DbConnect() As SqlConnection
        Dim connectionString As String = "Data Source=ZEEKANDS\SQLEXPRESS;Initial Catalog=DB_Classroom;Integrated Security=True"
        Dim conn As New SqlConnection(connectionString)

        Return conn
    End Function
End Class
