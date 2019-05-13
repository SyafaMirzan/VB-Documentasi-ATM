<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrepare
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Refresh = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextQty = New System.Windows.Forms.TextBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.ComboDenom = New System.Windows.Forms.ComboBox()
        Me.ButtonBerangkat = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboWsid = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Refresh
        '
        Me.Refresh.Location = New System.Drawing.Point(105, 305)
        Me.Refresh.Name = "Refresh"
        Me.Refresh.Size = New System.Drawing.Size(75, 23)
        Me.Refresh.TabIndex = 29
        Me.Refresh.Text = "Refresh"
        Me.Refresh.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Qty"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "WSID"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(710, 187)
        Me.DataGridView1.TabIndex = 24
        '
        'TextQty
        '
        Me.TextQty.Location = New System.Drawing.Point(59, 228)
        Me.TextQty.Name = "TextQty"
        Me.TextQty.Size = New System.Drawing.Size(100, 20)
        Me.TextQty.TabIndex = 21
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(12, 305)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 18
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'ComboDenom
        '
        Me.ComboDenom.FormattingEnabled = True
        Me.ComboDenom.Location = New System.Drawing.Point(59, 254)
        Me.ComboDenom.Name = "ComboDenom"
        Me.ComboDenom.Size = New System.Drawing.Size(121, 21)
        Me.ComboDenom.TabIndex = 30
        '
        'ButtonBerangkat
        '
        Me.ButtonBerangkat.Location = New System.Drawing.Point(211, 205)
        Me.ButtonBerangkat.Name = "ButtonBerangkat"
        Me.ButtonBerangkat.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBerangkat.TabIndex = 31
        Me.ButtonBerangkat.Text = "Berangkat"
        Me.ButtonBerangkat.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 257)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Denom"
        '
        'ComboWsid
        '
        Me.ComboWsid.FormattingEnabled = True
        Me.ComboWsid.Location = New System.Drawing.Point(59, 202)
        Me.ComboWsid.Name = "ComboWsid"
        Me.ComboWsid.Size = New System.Drawing.Size(121, 21)
        Me.ComboWsid.TabIndex = 33
        '
        'frmPrepare
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 357)
        Me.Controls.Add(Me.ComboWsid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonBerangkat)
        Me.Controls.Add(Me.ComboDenom)
        Me.Controls.Add(Me.Refresh)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextQty)
        Me.Controls.Add(Me.BtnSave)
        Me.Name = "frmPrepare"
        Me.Text = "frmPrepare"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Refresh As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextQty As TextBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents ComboDenom As ComboBox
    Friend WithEvents ButtonBerangkat As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboWsid As ComboBox
End Class
