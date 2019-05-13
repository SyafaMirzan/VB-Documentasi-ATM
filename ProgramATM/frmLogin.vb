Imports System.Data.SqlClient
Public Class frmLogin


    Private Sub Login_Click(sender As System.Object, e As System.EventArgs) Handles Login.Click
        Dim koneksi As New SqlConnection("Data Source=DESKTOP-CU318V1\SQLEXPRESS;Initial Catalog=DBATM;Integrated Security=True")

        Dim command As New SqlCommand("select * from Login where ID=@ID and Password=@Password", koneksi)

        command.Parameters.add("@ID", SqlDbType.VarChar).value = ID.Text

        command.Parameters.add("@Password", SqlDbType.VarChar).value = Password.Text

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count() <= 0 Then

            MessageBox.Show("Username Or Password Are Invalid")
        Else
            MessageBox.Show("Login Succesful")
            Dim frm As New frmMain()
            frm.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ID_TextChanged(sender As Object, e As EventArgs) Handles ID.TextChanged

    End Sub
End Class
