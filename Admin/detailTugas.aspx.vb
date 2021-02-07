Imports System.Data.SqlClient

Public Class detailTugas2
    Inherits System.Web.UI.Page
    Dim con As SqlConnection = New ConnectionDB().DbConnect
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        BindGrid(Request.QueryString("id_tugas"))
    End Sub
    Private Sub BindGrid(id_tugas As String)
        Using cmd As New SqlCommand()
            cmd.CommandText = "select td.id_tugas_detail as ID,a.nama as Mahasiswa,td.waktu_upload as Waktu,td.file_tugas from Akun a, TugasDetail td where a.id_akun=td.id_mhs and td.id_tugas=" + id_tugas
            cmd.Connection = con
            con.Open()
            GridView1.DataSource = cmd.ExecuteReader()
            GridView1.DataBind()
            con.Close()
        End Using
    End Sub

    Protected Sub lnkDownload_Click(sender As Object, e As EventArgs)
        Dim id As Integer = Integer.Parse(TryCast(sender, LinkButton).CommandArgument)
        Dim bytes As Byte()
        Dim fileName As String
        Using cmd As New SqlCommand()
            cmd.CommandText = "select a.nama as Mahasiswa,td.file_tugas from Akun a, TugasDetail td where a.id_akun=td.id_mhs and td.Id_tugas_detail=@Id"
            cmd.Parameters.AddWithValue("@Id", id)
                cmd.Connection = con
                con.Open()
                Using sdr As SqlDataReader = cmd.ExecuteReader()
                    sdr.Read()
                bytes = DirectCast(sdr(1), Byte())
                fileName = sdr(0).ToString()
            End Using
            con.Close()
        End Using
        Response.Clear()
        Response.Buffer = True
        Response.Charset = ""
        Response.Cache.SetCacheability(HttpCacheability.NoCache)
        Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName + ".pdf")
        Response.BinaryWrite(bytes)
        Response.Flush()
        Response.End()
    End Sub
End Class