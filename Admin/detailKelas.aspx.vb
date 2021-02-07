Imports System.Data.SqlClient

Public Class detailKelas
    Inherits System.Web.UI.Page

    Dim sqlConnection As SqlConnection = New ConnectionDB().DbConnect
    Public detailKelas As Dosen
    Public ListTugas As List(Of Tugas) = New List(Of Tugas)
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim id_dosen As String = Request.QueryString("id_dosen")
        Dim id_makul As String = Request.QueryString("id_makul")
        getDetailClassData(id_dosen, id_makul)
        getTugas(id_dosen, id_makul)
    End Sub
    Sub getDetailClassData(id_dosen As String, id_makul As String)
        sqlConnection.Open()
        Dim comm As New SqlCommand("select d.id_dosen,d.nama,d.hp,d.email,d.foto,m.id_makul,m.nama,m.sks,m.jam from Dosen d,Makul m where d.id_makul=m.id_makul and d.id_dosen=" + id_dosen + " and m.id_makul=" + id_makul, sqlConnection)
        Dim reader As SqlDataReader = comm.ExecuteReader
        'writing data that has been read from db
        While reader.Read
            'special case for data with varbinary type, we need to convert it to Byte() remember that Byte!=Byte() in vb so we cannot use getByte to get this kind of data from database directly
            detailKelas = New Dosen(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    reader.GetInt32(5),
                    reader.GetString(6),
                    reader.GetInt32(7),
                    reader.GetInt32(8)
            )
        End While
        reader.Close()
        sqlConnection.Close()
    End Sub
    Sub getTugas(id_dosen As String, id_makul As String)
        sqlConnection.Open()
        Dim comm As New SqlCommand("select * from Tugas where id_dosen=" + id_dosen + " and id_makul=" + id_makul, sqlConnection)
        Dim reader As SqlDataReader = comm.ExecuteReader
        'writing data that has been read from db
        While reader.Read
            'special case for data with varbinary type, we need to convert it to Byte() remember that Byte!=Byte() in vb so we cannot use getByte to get this kind of data from database directly
            ListTugas.Add(New Tugas(
                    reader.GetInt32(0),
                    reader.GetInt32(1),
                    reader.GetInt32(2),
                    reader.GetDateTime(3),
                    reader.GetString(4),
                    reader.GetString(5)
            ))
        End While
        reader.Close()
        sqlConnection.Close()
    End Sub

End Class