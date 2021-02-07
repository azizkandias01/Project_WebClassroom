Public Class Dosen

    Public Property idDosen As Integer
    Public Property nama As String
    Public Property hp As String
    Public Property email As String
    Public Property foto As String
    Public Property id_makul As Integer
    Public Property namaMakul As String
    Public Property sks As Integer
    Public Property jam As Integer

    Public Sub New(idDosen As Integer, nama As String, hp As String, email As String, foto As String, id_makul As Integer, namaMakul As String, sks As Integer, jam As Integer)
        Me.idDosen = idDosen
        Me.nama = nama
        Me.hp = hp
        Me.email = email
        Me.foto = foto
        Me.id_makul = id_makul
        Me.namaMakul = namaMakul
        Me.sks = sks
        Me.jam = jam
    End Sub
End Class
