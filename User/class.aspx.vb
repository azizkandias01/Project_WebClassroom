Imports System.Data.SqlClient

Public Class _class
    Inherits System.Web.UI.Page

    Dim sqlConnection As SqlConnection = New ConnectionDB().DbConnect
    Public Listkelas As List(Of Dosen) = New List(Of Dosen)
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        getClassData()
    End Sub

    Sub getClassData()
        sqlConnection.Open()
        Dim comm As New SqlCommand("select d.id_dosen,d.nama,d.hp,d.email,d.foto,m.id_makul,m.nama,m.sks,m.jam from Dosen d,Makul m where d.id_makul=m.id_makul", sqlConnection)
        Dim reader As SqlDataReader = comm.ExecuteReader
        'writing data that has been read from db
        While reader.Read
            Listkelas.Add(New Dosen(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    reader.GetInt32(5),
                    reader.GetString(6),
                    reader.GetInt32(7),
                    reader.GetInt32(8)
            ))
        End While
        reader.Close()
        sqlConnection.Close()
    End Sub

End Class