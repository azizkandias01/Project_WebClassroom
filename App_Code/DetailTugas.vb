Public Class DetailTugas
    Public Sub New(id_tugasdetail As Integer, id_tugas As Integer, id_mhs As Integer, fileTugas() As Byte, upload As Date, nilai As Integer)
        Me.id_tugasdetail = id_tugasdetail
        Me.id_tugas = id_tugas
        Me.id_mhs = id_mhs
        Me.fileTugas = fileTugas
        Me.upload = upload
        Me.nilai = nilai
    End Sub

    Public Property id_tugasdetail As Integer
    Public Property id_tugas As Integer
    Public Property id_mhs As Integer
    Public Property fileTugas As Byte()
    Public Property upload As DateTime
    Public Property nilai As Integer



End Class
