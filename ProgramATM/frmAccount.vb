Imports System.Data.SqlClient
Public Class frmAccount
    Dim koneksi As New SqlConnection("Data Source=DESKTOP-CU318V1\SQLEXPRESS;Initial Catalog=DBATM;Integrated Security=True")



    Private Sub frmAccount_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter("SELECT ATM.WSID, ATM.Lokasi, ATM.Bank, AccountSaldo1.Denom, AccountSaldo1.Qty FROM AccountSaldo1 inner join ATM on ATM.WSID=AccountSaldo1.WSID", koneksi)

        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table


    End Sub

    Private Sub BtnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles BtnUpdate.Click
        If TxtWSID.Text = "" Then
            MsgBox("WSID harus ada", vbCritical, "Peringatan")
        ElseIf TxtQty.Text = "" Then
            MsgBox("Qty harus ada", vbCritical, "Peringatan")
        Else
            Dim updateQuery As String = "Update AccountSaldo1 Set Qty = '" & TxtQty.Text & "' WHERE WSID ='" & TxtWSID.Text & "'"
            ExecuteQuery(updateQuery)
            MessageBox.Show("Data Terupdate")
        End If

    End Sub
    Public Sub ExecuteQuery(query As String)

        Dim command As New SqlCommand(query, koneksi)

        koneksi.Open()

        command.ExecuteNonQuery()

        koneksi.Close()

    End Sub

    Private Sub BtnLogout_Click(sender As System.Object, e As System.EventArgs) Handles BtnLogout.Click
        Dim frm As New frmLogin()
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub BtnAccount_Click(sender As System.Object, e As System.EventArgs) Handles BtnAccount.Click
        Dim frm As New frmATM()
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub BtnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles BtnRefresh.Click
        Dim adapter As New SqlDataAdapter("SELECT ATM.WSID, ATM.Lokasi, ATM.Bank, AccountSaldo1.Denom, AccountSaldo1.Qty FROM AccountSaldo1 inner join ATM on ATM.WSID=AccountSaldo1.WSID", koneksi)

        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class