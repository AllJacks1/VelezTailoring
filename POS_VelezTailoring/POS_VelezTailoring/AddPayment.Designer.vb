<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddPayment))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_save = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_totalPayment = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_overallPayment = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_cancel = New Guna.UI2.WinForms.Guna2Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_addPayment = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pb_minimize = New System.Windows.Forms.PictureBox()
        Me.pb_exit = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_orderid = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_exit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(337, 507)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'btn_save
        '
        Me.btn_save.BorderRadius = 15
        Me.btn_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_save.FillColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(628, 402)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(207, 93)
        Me.btn_save.TabIndex = 64
        Me.btn_save.Text = "SAVE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(371, 303)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 29)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Overall Payment:"
        '
        'txt_totalPayment
        '
        Me.txt_totalPayment.Animated = True
        Me.txt_totalPayment.BorderRadius = 15
        Me.txt_totalPayment.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_totalPayment.DefaultText = ""
        Me.txt_totalPayment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_totalPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_totalPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_totalPayment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_totalPayment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_totalPayment.Font = New System.Drawing.Font("Segoe UI", 15.75!)
        Me.txt_totalPayment.ForeColor = System.Drawing.Color.Black
        Me.txt_totalPayment.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_totalPayment.Location = New System.Drawing.Point(376, 242)
        Me.txt_totalPayment.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txt_totalPayment.Name = "txt_totalPayment"
        Me.txt_totalPayment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_totalPayment.PlaceholderText = ""
        Me.txt_totalPayment.ReadOnly = True
        Me.txt_totalPayment.SelectedText = ""
        Me.txt_totalPayment.Size = New System.Drawing.Size(459, 55)
        Me.txt_totalPayment.TabIndex = 62
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(371, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 29)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Previous Total Payment:"
        '
        'txt_overallPayment
        '
        Me.txt_overallPayment.Animated = True
        Me.txt_overallPayment.BorderRadius = 15
        Me.txt_overallPayment.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_overallPayment.DefaultText = ""
        Me.txt_overallPayment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_overallPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_overallPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_overallPayment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_overallPayment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_overallPayment.Font = New System.Drawing.Font("Segoe UI", 15.75!)
        Me.txt_overallPayment.ForeColor = System.Drawing.Color.Black
        Me.txt_overallPayment.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_overallPayment.Location = New System.Drawing.Point(376, 338)
        Me.txt_overallPayment.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txt_overallPayment.Name = "txt_overallPayment"
        Me.txt_overallPayment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_overallPayment.PlaceholderText = ""
        Me.txt_overallPayment.ReadOnly = True
        Me.txt_overallPayment.SelectedText = ""
        Me.txt_overallPayment.Size = New System.Drawing.Size(459, 55)
        Me.txt_overallPayment.TabIndex = 60
        '
        'btn_cancel
        '
        Me.btn_cancel.BorderRadius = 15
        Me.btn_cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_cancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_cancel.Location = New System.Drawing.Point(376, 402)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(207, 93)
        Me.btn_cancel.TabIndex = 59
        Me.btn_cancel.Text = "CANCEL"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(371, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(173, 29)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Add Payment:"
        '
        'txt_addPayment
        '
        Me.txt_addPayment.Animated = True
        Me.txt_addPayment.BorderRadius = 15
        Me.txt_addPayment.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_addPayment.DefaultText = ""
        Me.txt_addPayment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_addPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_addPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_addPayment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_addPayment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_addPayment.Font = New System.Drawing.Font("Segoe UI", 15.75!)
        Me.txt_addPayment.ForeColor = System.Drawing.Color.Black
        Me.txt_addPayment.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_addPayment.Location = New System.Drawing.Point(376, 146)
        Me.txt_addPayment.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txt_addPayment.Name = "txt_addPayment"
        Me.txt_addPayment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_addPayment.PlaceholderText = ""
        Me.txt_addPayment.SelectedText = ""
        Me.txt_addPayment.Size = New System.Drawing.Size(459, 55)
        Me.txt_addPayment.TabIndex = 57
        '
        'pb_minimize
        '
        Me.pb_minimize.Image = CType(resources.GetObject("pb_minimize.Image"), System.Drawing.Image)
        Me.pb_minimize.Location = New System.Drawing.Point(821, 12)
        Me.pb_minimize.Name = "pb_minimize"
        Me.pb_minimize.Size = New System.Drawing.Size(34, 33)
        Me.pb_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_minimize.TabIndex = 66
        Me.pb_minimize.TabStop = False
        '
        'pb_exit
        '
        Me.pb_exit.Image = CType(resources.GetObject("pb_exit.Image"), System.Drawing.Image)
        Me.pb_exit.Location = New System.Drawing.Point(861, 12)
        Me.pb_exit.Name = "pb_exit"
        Me.pb_exit.Size = New System.Drawing.Size(34, 33)
        Me.pb_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_exit.TabIndex = 65
        Me.pb_exit.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(371, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 29)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Order ID:"
        '
        'txt_orderid
        '
        Me.txt_orderid.Animated = True
        Me.txt_orderid.BorderRadius = 15
        Me.txt_orderid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_orderid.DefaultText = ""
        Me.txt_orderid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_orderid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_orderid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_orderid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_orderid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_orderid.Font = New System.Drawing.Font("Segoe UI", 15.75!)
        Me.txt_orderid.ForeColor = System.Drawing.Color.Black
        Me.txt_orderid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_orderid.Location = New System.Drawing.Point(376, 47)
        Me.txt_orderid.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txt_orderid.Name = "txt_orderid"
        Me.txt_orderid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_orderid.PlaceholderText = ""
        Me.txt_orderid.SelectedText = ""
        Me.txt_orderid.Size = New System.Drawing.Size(196, 55)
        Me.txt_orderid.TabIndex = 68
        '
        'AddPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(918, 507)
        Me.Controls.Add(Me.txt_orderid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pb_minimize)
        Me.Controls.Add(Me.pb_exit)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_totalPayment)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_overallPayment)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_addPayment)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddPayment"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_exit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_save As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_totalPayment As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_overallPayment As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_cancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_addPayment As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents pb_minimize As PictureBox
    Friend WithEvents pb_exit As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_orderid As Guna.UI2.WinForms.Guna2TextBox
End Class
