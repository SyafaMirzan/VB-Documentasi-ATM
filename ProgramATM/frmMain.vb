Public Class frmMain

    Private Sub LogoutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim frm As New frmLogin()
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ATMToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ATMToolStripMenuItem.Click
        Dim frm As New frmATM()
        frm.Show()
    End Sub

    Private Sub AccountSaldoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AccountSaldoToolStripMenuItem.Click
        Dim frm As New frmAccount()
        frm.Show()
    End Sub


    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel1.Text = TimeOfDay
    End Sub

    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub AccountATMToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AccountATMToolStripMenuItem.Click
        Dim frm As New Laporan()
        frm.Show()
    End Sub

    Private Sub PrepareDanBerangkatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrepareDanBerangkatToolStripMenuItem.Click
        Dim frm As New frmPrepare()
        frm.Show()
    End Sub

    Private Sub MonitoringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonitoringToolStripMenuItem.Click
        Dim frm As New frmMonitoring()
        frm.Show()
    End Sub

    Private Sub MasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterToolStripMenuItem.Click

    End Sub
End Class