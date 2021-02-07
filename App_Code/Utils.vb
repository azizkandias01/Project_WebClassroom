Imports System.Data.SqlClient

Public Class Utils

    Dim sqlConnection As SqlConnection = New ConnectionDB().DbConnect
    Public akun As Akun


    Function login(email As String, password As String) As Integer
        Try
            Dim auth As Boolean = False
            Dim isAdmin As Boolean = False
            sqlConnection.Open()
            Dim comm As New SqlCommand("select * from Akun where email='" + email + "' and password='" + password + "'", sqlConnection)
            Dim reader As SqlDataReader = comm.ExecuteReader
            If reader.HasRows Then
                auth = True
                While reader.Read
                    akun = New Akun(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4))
                End While
            End If
            reader.Close()
            sqlConnection.Close()

            If akun Is Nothing Then
                isAdmin = False
            Else
                If akun.level = 2 Then
                    isAdmin = True
                Else
                    isAdmin = False
                End If
            End If

            If auth And isAdmin Then
                Return 2
            ElseIf auth And isAdmin = False Then
                Return 1
            Else
                Return 0
            End If
        Catch
            Return 0
        End Try
    End Function

End Class
