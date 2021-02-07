Imports System.Data.SqlClient
Imports System.IO

Public Class detailTugas1
    Inherits System.Web.UI.Page

    Public detailTugasNew As DetailTugas
    Public tugas As Tugas
    Dim sqlConnection As SqlConnection = New ConnectionDB().DbConnect

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim id_dosen As String = Request.QueryString("id_dosen")
        Dim id_tugas As String = Request.QueryString("id_tugas")
        Dim id_mhs As String = Request.QueryString("id_mhs")
        Dim id_makul As String = Request.QueryString("id_makul")
        getTugas(id_dosen, id_makul, id_tugas)
        getTugas1(id_dosen, id_tugas, id_mhs)
    End Sub

    Sub getTugas1(id_dosen As String, id_tugas As String, id_mhs As String)
        sqlConnection.Open()
        Dim comm As New SqlCommand("select id_tugas_detail,id_tugas,id_mhs,file_tugas,waktu_upload,nilai From TugasDetail where id_tugas=" + id_tugas + " and id_mhs=" + id_mhs, sqlConnection)
        Dim reader As SqlDataReader = comm.ExecuteReader
        'writing data that has been read from db

        If reader.HasRows Then
            While reader.Read
                detailTugasNew = New DetailTugas(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader(3), reader.GetDateTime(4), reader.GetInt32(5))
            End While
        End If
        reader.Close()
        sqlConnection.Close()
    End Sub

    Sub getTugas(id_dosen As String, id_makul As String, id_tugas As String)
        sqlConnection.Open()
        Dim comm As New SqlCommand("select * from Tugas where id_dosen=" + id_dosen + " and id_makul=" + id_makul + " and id_tugas=" + id_tugas, sqlConnection)
        Dim reader As SqlDataReader = comm.ExecuteReader
        'writing data that has been read from db
        While reader.Read
            'special case for data with varbinary type, we need to convert it to Byte() remember that Byte!=Byte() in vb so we cannot use getByte to get this kind of data from database directly
            tugas = New Tugas(
                    reader.GetInt32(0),
                    reader.GetInt32(1),
                    reader.GetInt32(2),
                    reader.GetDateTime(3),
                    reader.GetString(4),
                    reader.GetString(5)
            )
        End While
        reader.Close()
        sqlConnection.Close()
    End Sub

    Sub upload()
        Dim fileStreamBuku As Stream = FileUpload1.PostedFile.InputStream

        Dim binaryReaderBuku As New BinaryReader(fileStreamBuku)

        Dim bytesBuku As Byte() = binaryReaderBuku.ReadBytes(fileStreamBuku.Length)

        Dim constString As String = "Data Source=ZEEKANDS\SQLEXPRESS;Initial Catalog=DB_Classroom;Integrated Security=True"
        Using con As New SqlConnection(constString)
            Dim query As String = "insert into TugasDetail values (@id_tugas,@id_mhs,@file_tugas,@waktu_upload,@nilai)"
            Using cmd As New SqlCommand(query)
                cmd.Connection = con
                cmd.Parameters.Add("@id_tugas", SqlDbType.Int).Value = Integer.Parse(Request.QueryString("id_tugas"))
                cmd.Parameters.Add("@id_mhs", SqlDbType.Int).Value = Integer.Parse(Request.QueryString("id_mhs"))
                cmd.Parameters.Add("@file_tugas", SqlDbType.Binary).Value = bytesBuku
                cmd.Parameters.Add("@waktu_upload", SqlDbType.Date).Value = DateAndTime.Now
                cmd.Parameters.Add("@nilai", SqlDbType.Int).Value = 0
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
    End Sub

    Protected Sub btnUpload_Click(sender As Object, e As EventArgs)
        upload()
        Response.Redirect("class.aspx")
    End Sub
End Class