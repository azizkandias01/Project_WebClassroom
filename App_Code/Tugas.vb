Public Class Tugas


    Public Property id_tugas As Integer
    Public Property id_dosen As Integer
    Public Property id_makul As Integer
    Public Property tengat As DateTime
    Public Property detail As String
    Public Property judul As String

    Public Sub New(id_tugas As Integer, id_dosen As Integer, id_makul As Integer, tengat As Date, detail As String, judul As String)
        Me.id_tugas = id_tugas
        Me.id_dosen = id_dosen
        Me.id_makul = id_makul
        Me.tengat = tengat
        Me.detail = detail
        Me.judul = judul
    End Sub

End Class
