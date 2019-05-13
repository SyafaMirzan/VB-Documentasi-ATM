Imports System.Data.SqlClient

Public Class frmATM

    Dim koneksi As New SqlConnection("Data Source=DESKTOP-CU318V1\SQLEXPRESS;Initial Catalog=DBATM;Integrated Security=True")



    Private Sub BtnSave_Click(sender As System.Object, e As EventArgs) Handles BtnSave.Click
        If TextWSID.Text = "" Then
            MsgBox("Semua data harus ada", vbCritical, "Peringatan")
        ElseIf TextLokasi.Text = "" Then
            MsgBox("Semua data harus ada", vbCritical, "Peringatan")
        ElseIf TextBank.Text = "" Then
            MsgBox("Semua data harus ada", vbCritical, "Peringatan")
        Else

            Dim insertQuery As String = "INSERT INTO ATM (WSID,Lokasi,Bank) VALUES('" & TextWSID.Text & "','" & TextLokasi.Text & "','" & TextBank.Text & "')"

            ExecuteQuery(insertQuery)
            MessageBox.Show("Data Tersimpan")
        End If


    End Sub

    Public Sub ExecuteQuery(query As String)

        Dim command As New SqlCommand(query, koneksi)

        koneksi.Open()

        command.ExecuteNonQuery()

        koneksi.Close()

    End Sub


    Private Sub BtnDelete_Click(sender As System.Object, e As System.EventArgs) Handles BtnDelete.Click
        Dim deleteQuery As String = "delete from ATM Where WSID in ( '" & TextWSID.Text & "' )"

        ExecuteQuery(deleteQuery)
        MessageBox.Show("WSID Deleted")
    End Sub

    Private Sub BtnLogout_Click(sender As System.Object, e As System.EventArgs) Handles BtnLogout.Click
        Dim frm As New frmLogin()
        frm.Show()
        Me.Hide()
    End Sub


    Private Sub frmATM_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim adapter As New SqlDataAdapter("SELECT wsid,lokasi,bank FROM ATM", koneksi)

        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table



    End Sub

    Private Sub Refresh_Click(sender As System.Object, e As System.EventArgs) Handles Refresh.Click
        Dim adapter As New SqlDataAdapter("SELECT * FROM ATM", koneksi)

        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table

    End Sub



    Private Sub BtnAccount_Click(sender As System.Object, e As System.EventArgs) Handles BtnAccount.Click
        Dim frm As New frmAccount()
        frm.Show()
        Me.Hide()
    End Sub


End Class