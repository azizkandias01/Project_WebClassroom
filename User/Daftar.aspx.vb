Imports System.Data.SqlClient

Public Class Daftar
    Inherits System.Web.UI.Page

    Dim conn As SqlConnection = New ConnectionDB().DbConnect

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnDaftar_Click(sender As Object, e As EventArgs)
        Dim nama As String = txtNama.Text
        Dim email As String = txtEmail.Text
        Dim password As String = txtPassword.Text

        Dim query As String = "Insert Into Akun Values(@nama,@email,@password,@level)"

        Using cmd = New SqlCommand(query, conn)
            conn.Open()
            cmd.Parameters.Add(New SqlParameter("@nama", nama))
            cmd.Parameters.Add(New SqlParameter("@email", email))
            cmd.Parameters.Add(New SqlParameter("@password", password))
            cmd.Parameters.Add(New SqlParameter("@level", 1))
            cmd.ExecuteNonQuery()
            conn.Close()
        End Using
        Response.Redirect("Login.aspx")

    End Sub
End Class