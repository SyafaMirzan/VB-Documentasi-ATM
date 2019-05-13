Imports System.Data.SqlClient
Public Class frmMonitoring



    Dim koneksi As New SqlConnection("Data Source=DESKTOP-CU318V1\SQLEXPRESS;Initial Catalog=DBATM;Integrated Security=True")



    Private Sub BtnSave_Click(sender As System.Object, e As EventArgs) Handles BtnSave.Click
        If ComboWsid.Text = "" Then
            MsgBox("Semua data harus ada", vbCritical, "Peringatan")
        ElseIf TextQty.Text = "" Then
            MsgBox("Semua data harus ada", vbCritical, "Peringatan")
        Else

            Dim insertQuery As String = "update accountsaldo1 set qty ='" & TextQty.Text & "' where wsid ='" & ComboWsid.Text & "' and denom='" & ComboDenom.Text & "'"

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


    Private Sub BtnDelete_Click(sender As System.Object, e As System.EventArgs)
        Dim deleteQuery As String = "delete from ATM Where WSID in ( '" & ComboWsid.Text & "' )"

        ExecuteQuery(deleteQuery)
        MessageBox.Show("WSID Deleted")
    End Sub

    Private Sub BtnLogout_Click(sender As System.Object, e As System.EventArgs)
        Dim frm As New frmLogin()
        frm.Show()
        Me.Hide()
    End Sub


    Private Sub frmATM_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        DateTimePicker1.Format = DateTimePickerFormat.Time
        DateTimePicker1.ShowUpDown = True
        DateTimePicker2.Format = DateTimePickerFormat.Time
        DateTimePicker2.ShowUpDown = True

        ''batas waktu

        Dim koneksi As New SqlConnection("Data Source=DESKTOP-CU318V1\SQLEXPRESS;Initial Catalog=DBATM;Integrated Security=True")

        Dim commando As New SqlCommand("select distinct ATM.WSID, accountsaldo1.wsid, accountsaldo1.denom from ATM inner join accountsaldo1 on ATM.WSID=accountsaldo1.WSID where ATM.status ='R'", koneksi)

        Dim adapterse As New SqlDataAdapter(commando)

        Dim tables As New DataTable()

        adapterse.Fill(tables)

        ComboWsid.DataSource = tables

        ComboWsid.DisplayMember = "WSID"
        ComboWsid.ValueMember = "WSID"

        '''batas combo WSID

        Dim command As New SqlCommand("select distinct Denom from AccountSaldo1", koneksi)

        Dim adapters As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapters.Fill(table)

        ComboDenom.DataSource = table

        ComboDenom.DisplayMember = "Denom"
        ComboDenom.ValueMember = "Denom"

        '''batas combo account saldo
        Dim adapter As New SqlDataAdapter("SELECT ATM.WSID, ATM.Lokasi, ATM.Bank FROM AccountSaldo1 inner join ATM on ATM.WSID=AccountSaldo1.WSID where ATM.status='R'", koneksi)

        Dim tablee As New DataTable()

        adapter.Fill(tablee)

        DataGridView1.DataSource = tablee

        '''batas muncul di grid ATM

        Dim adapt As New SqlDataAdapter("SELECT  AccountSaldo1.Denom, AccountSaldo1.Qty, Accountsaldo1.WSID FROM AccountSaldo1 inner join ATM on ATM.WSID=AccountSaldo1.WSID where ATM.status='R'", koneksi)

        Dim tabl As New DataTable()

        adapt.Fill(tabl)

        DataGridView2.DataSource = tabl

        '''batas muncul di grid Account

    End Sub

    Private Sub Refresh_Click(sender As System.Object, e As System.EventArgs) Handles Refresh.Click
        Dim adapter As New SqlDataAdapter("SELECT ATM.WSID, ATM.Lokasi, ATM.Bank FROM AccountSaldo1 inner join ATM on ATM.WSID=AccountSaldo1.WSID where ATM.status='R'", koneksi)

        Dim table As New DataTable()

        Dim adapt As New SqlDataAdapter("SELECT  AccountSaldo1.Denom, AccountSaldo1.Qty, Accountsaldo1.WSID FROM AccountSaldo1 inner join ATM on ATM.WSID=AccountSaldo1.WSID where ATM.status='R'", koneksi)

        Dim tabl As New DataTable()

        adapt.Fill(tabl)

        adapter.Fill(table)

        DataGridView1.DataSource = table
        DataGridView2.DataSource = tabl

    End Sub

    Private Sub ButtonBerangkat_Click(sender As Object, e As EventArgs) Handles ButtonBerangkat.Click
        If ComboWsid.Text = "" Then
            MsgBox("Semua data harus ada", vbCritical, "Peringatan")
        Else


            Dim insertQuery As String = "update ATM set status ='L',IsLaporan='Y',TimeInputMonitor=GETDATE(), Waktutiba='" & DateTimePicker1.Text & "' , waktuselesai='" & DateTimePicker2.Text & "'  where wsid ='" & ComboWsid.Text & "'"

            ExecuteQuery(insertQuery)
            MessageBox.Show("Data Tersimpan")
        End If
    End Sub



End Class