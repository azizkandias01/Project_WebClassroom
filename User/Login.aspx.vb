Imports System.Data.SqlClient

Public Class Login
    Inherits System.Web.UI.Page
    Dim sqlConnection As SqlConnection = New ConnectionDB().DbConnect
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnLogin_Click(sender As Object, e As EventArgs)
        Dim email As String = txtEmail.Text
        Dim password As String = txtPassword.Text

        Dim auth As Boolean = False
        Dim isAdmin As Boolean = False
        sqlConnection.Open()
        Dim comm As New SqlCommand("select * from Akun where email='" + email + "' and password='" + password + "'", sqlConnection)
        Dim reader As SqlDataReader = comm.ExecuteReader
        If reader.HasRows Then
            auth = True
            While reader.Read
                Session("id") = reader.GetInt32(0)
                Session("nama") = reader.GetString(1)
                Session("email") = reader.GetString(2)
                Session("password") = reader.GetString(3)
                Session("level") = reader.GetInt32(4)
            End While
        End If
        reader.Close()
        sqlConnection.Close()

        If Session("nama") = "admin" Then
            isAdmin = True
            Session("namaAdmin") = Session("nama")
        End If

        If auth And isAdmin Then
            Response.Redirect("~/Admin/index.aspx")
        ElseIf auth And isAdmin = False Then
            Response.Redirect("index.aspx")
        Else
            Response.Redirect("Login.aspx")
        End If
    End Sub
End Class