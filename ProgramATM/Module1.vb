Imports System.Data.SqlClient
Module Module1

    Public con As SqlConnection
    Public da As SqlDataAdapter
    Public ds As DataSet
    Public cmd As SqlCommand
    Public dr As SqlDataReader
    Public query As String

    Public Sub koneksi()
        con = New SqlConnection
        con.ConnectionString = ("Data Source=DESKTOP-CU318V1\SQLEXPRESS;Initial Catalog=DBATM;Integrated Security=True")
        'Try
        If con.State = ConnectionState.Closed Then
            con.Open()
            'MsgBox("Koneksi Tersambung")

        End If
        'Catch ex As Exception
        'MsgBox("Koneksi Tidak Terhubung")
        'End Try

    End Sub

End Module