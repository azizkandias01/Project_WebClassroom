Imports System.Data.SqlClient

Public Class hapusKelas
    Inherits System.Web.UI.Page
    Dim sqlConnection As SqlConnection = New ConnectionDB().DbConnect
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim id_dosen As String = Request.QueryString("id_dosen")
        Dim id_makul As String = Request.QueryString("id_makul")

        Dim cmdText As String = "Update Dosen Set id_makul = null where id_dosen=@id_dosen"

        Using cmd = New SqlCommand(cmdText, sqlConnection)
            sqlConnection.Open()
            cmd.Parameters.Add(New SqlParameter("@id_dosen", id_dosen))
            cmd.ExecuteNonQuery()
            sqlConnection.Close()
        End Using
        Response.Redirect("Index.aspx")
    End Sub

End Class