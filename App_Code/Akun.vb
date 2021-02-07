Public Class Akun
	Public Property id_akun As Integer
	Public Property nama As String
	Public Property email As String
	Public Property password As String
	Public Property level As Integer

	Sub New(ByVal id_akun_ As Integer, ByVal nama_ As String, ByVal email_ As String, ByVal password_ As String, ByVal level_ As Integer)
		Me.id_akun = id_akun_
		Me.nama = nama_
		Me.email = email_
		Me.password = password_
		Me.level = level_
	End Sub
End Class
