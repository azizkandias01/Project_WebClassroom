Imports System.Data.SqlClient

Public Class tambahTugas
    Inherits System.Web.UI.Page

    Dim sqlConnection As SqlConnection = New ConnectionDB().DbConnect
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnAddTugas_Click(sender As Object, e As EventArgs)
        Dim id_dosen As String = Request.QueryString("id_dosen")
        Dim id_makul As String = Request.QueryString("id_makul")
        Dim judul As String = txtJudul.Text
        Dim deskripsi As String = txtDeskripsi.Text
        Dim tanggal As DateTime = Calendar1.SelectedDate.AddHours(23).AddMinutes(59).AddSeconds(59)

        Dim cmdText As String = "INSERT INTO Tugas Values(@id_dosen,@id_makul,@tengat,@detail,@judul)"

        Using cmd = New SqlCommand(cmdText, sqlConnection)
            sqlConnection.Open()
            cmd.Parameters.Add(New SqlParameter("@id_dosen", id_dosen))
            cmd.Parameters.Add(New SqlParameter("@id_makul", id_makul))
            cmd.Parameters.Add(New SqlParameter("@tengat", tanggal))
            cmd.Parameters.Add(New SqlParameter("@detail", deskripsi))
            cmd.Parameters.Add(New SqlParameter("@judul", judul))
            cmd.ExecuteNonQuery()
            sqlConnection.Close()
        End Using
        Response.Redirect("Index.aspx")
    End Sub
End Class