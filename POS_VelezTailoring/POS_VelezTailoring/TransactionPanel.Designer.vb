<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TransactionPanel
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.customer_nametxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.customer_numtxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.prod_typetxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.etc_dtp = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.save_ordertxt = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.overall_pricetxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.down_paymenttxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SuspendLayout()
        '
        'customer_nametxt
        '
        Me.customer_nametxt.Animated = True
        Me.customer_nametxt.BorderRadius = 15
        Me.customer_nametxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.customer_nametxt.DefaultText = ""
        Me.customer_nametxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.customer_nametxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.customer_nametxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.customer_nametxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.customer_nametxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.customer_nametxt.Font = New System.Drawing.Font("Segoe UI", 15.75!)
        Me.customer_nametxt.ForeColor = System.Drawing.Color.Black
        Me.customer_nametxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.customer_nametxt.Location = New System.Drawing.Point(42, 101)
        Me.customer_nametxt.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.customer_nametxt.Name = "customer_nametxt"
        Me.customer_nametxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.customer_nametxt.PlaceholderText = "Please enter customer name here..."
        Me.customer_nametxt.SelectedText = ""
        Me.customer_nametxt.Size = New System.Drawing.Size(904, 72)
        Me.customer_nametxt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(37, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Customer Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(34, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 29)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Contact Number:"
        '
        'customer_numtxt
        '
        Me.customer_numtxt.Animated = True
        Me.customer_numtxt.BorderRadius = 15
        Me.customer_numtxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.customer_numtxt.DefaultText = ""
        Me.customer_numtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.customer_numtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.customer_numtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.customer_numtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.customer_numtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.customer_numtxt.Font = New System.Drawing.Font("Segoe UI", 15.75!)
        Me.customer_numtxt.ForeColor = System.Drawing.Color.Black
        Me.customer_numtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.customer_numtxt.Location = New System.Drawing.Point(39, 221)
        Me.customer_numtxt.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.customer_numtxt.Name = "customer_numtxt"
        Me.customer_numtxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.customer_numtxt.PlaceholderText = "Please enter contact number here..."
        Me.customer_numtxt.SelectedText = ""
        Me.customer_numtxt.Size = New System.Drawing.Size(907, 72)
        Me.customer_numtxt.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(996, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 29)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Product type:"
        '
        'prod_typetxt
        '
        Me.prod_typetxt.BorderRadius = 15
        Me.prod_typetxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.prod_typetxt.DefaultText = ""
        Me.prod_typetxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.prod_typetxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.prod_typetxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.prod_typetxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.prod_typetxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.prod_typetxt.Font = New System.Drawing.Font("Segoe UI", 15.75!)
        Me.prod_typetxt.ForeColor = System.Drawing.Color.Black
        Me.prod_typetxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.prod_typetxt.Location = New System.Drawing.Point(998, 101)
        Me.prod_typetxt.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.prod_typetxt.Multiline = True
        Me.prod_typetxt.Name = "prod_typetxt"
        Me.prod_typetxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.prod_typetxt.PlaceholderText = "Please enter description here..."
        Me.prod_typetxt.SelectedText = ""
        Me.prod_typetxt.Size = New System.Drawing.Size(613, 450)
        Me.prod_typetxt.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(142, 522)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 29)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Overall Price:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(621, 522)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(278, 29)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Downpayment Amount:"
        '
        'etc_dtp
        '
        Me.etc_dtp.BorderRadius = 15
        Me.etc_dtp.Checked = True
        Me.etc_dtp.CustomFormat = ""
        Me.etc_dtp.FillColor = System.Drawing.Color.White
        Me.etc_dtp.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etc_dtp.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.etc_dtp.Location = New System.Drawing.Point(249, 376)
        Me.etc_dtp.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.etc_dtp.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.etc_dtp.Name = "etc_dtp"
        Me.etc_dtp.Size = New System.Drawing.Size(486, 72)
        Me.etc_dtp.TabIndex = 14
        Me.etc_dtp.Value = New Date(2023, 9, 18, 21, 9, 38, 473)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(316, 344)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(352, 29)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Estimated Time to Complete:"
        '
        'save_ordertxt
        '
        Me.save_ordertxt.BorderRadius = 15
        Me.save_ordertxt.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.save_ordertxt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.save_ordertxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.save_ordertxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.save_ordertxt.FillColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.save_ordertxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.save_ordertxt.ForeColor = System.Drawing.Color.White
        Me.save_ordertxt.Location = New System.Drawing.Point(1001, 605)
        Me.save_ordertxt.Name = "save_ordertxt"
        Me.save_ordertxt.Size = New System.Drawing.Size(610, 103)
        Me.save_ordertxt.TabIndex = 16
        Me.save_ordertxt.Text = "SAVE ORDER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(996, 557)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 24)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Text: 250/250"
        '
        'overall_pricetxt
        '
        Me.overall_pricetxt.Animated = True
        Me.overall_pricetxt.BorderRadius = 15
        Me.overall_pricetxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.overall_pricetxt.DefaultText = ""
        Me.overall_pricetxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.overall_pricetxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.overall_pricetxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.overall_pricetxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.overall_pricetxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.overall_pricetxt.Font = New System.Drawing.Font("Segoe UI", 15.75!)
        Me.overall_pricetxt.ForeColor = System.Drawing.Color.Black
        Me.overall_pricetxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.overall_pricetxt.Location = New System.Drawing.Point(42, 557)
        Me.overall_pricetxt.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.overall_pricetxt.Name = "overall_pricetxt"
        Me.overall_pricetxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.overall_pricetxt.PlaceholderText = "Enter amount here..."
        Me.overall_pricetxt.SelectedText = ""
        Me.overall_pricetxt.Size = New System.Drawing.Size(372, 72)
        Me.overall_pricetxt.TabIndex = 18
        '
        'down_paymenttxt
        '
        Me.down_paymenttxt.Animated = True
        Me.down_paymenttxt.BorderRadius = 15
        Me.down_paymenttxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.down_paymenttxt.DefaultText = ""
        Me.down_paymenttxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.down_paymenttxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.down_paymenttxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.down_paymenttxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.down_paymenttxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.down_paymenttxt.Font = New System.Drawing.Font("Segoe UI", 15.75!)
        Me.down_paymenttxt.ForeColor = System.Drawing.Color.Black
        Me.down_paymenttxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.down_paymenttxt.Location = New System.Drawing.Point(574, 557)
        Me.down_paymenttxt.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.down_paymenttxt.Name = "down_paymenttxt"
        Me.down_paymenttxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.down_paymenttxt.PlaceholderText = "Enter amount here..."
        Me.down_paymenttxt.SelectedText = ""
        Me.down_paymenttxt.Size = New System.Drawing.Size(372, 72)
        Me.down_paymenttxt.TabIndex = 19
        '
        'transaction_panel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Controls.Add(Me.down_paymenttxt)
        Me.Controls.Add(Me.overall_pricetxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.save_ordertxt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.etc_dtp)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.prod_typetxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.customer_numtxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.customer_nametxt)
        Me.Name = "transaction_panel"
        Me.Size = New System.Drawing.Size(1657, 757)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents customer_nametxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents customer_numtxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents prod_typetxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents etc_dtp As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents save_ordertxt As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents overall_pricetxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents down_paymenttxt As Guna.UI2.WinForms.Guna2TextBox
End Class
