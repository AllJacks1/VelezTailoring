<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateRecord
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateRecord))
        Me.txt_description = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_balance = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_save = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_price = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_pay = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_date = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_name = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_dead = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_status = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_orderid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pb_minimize = New System.Windows.Forms.PictureBox()
        Me.pb_exit = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_cancel = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.pb_minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_exit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_description
        '
        Me.txt_description.Animated = True
        Me.txt_description.AutoScroll = True
        Me.txt_description.BorderRadius = 15
        Me.txt_description.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_description.DefaultText = ""
        Me.txt_description.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_description.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_description.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_description.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_description.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_description.Font = New System.Drawing.Font("Segoe UI", 15.75!)
        Me.txt_description.ForeColor = System.Drawing.Color.Black
        Me.txt_description.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_description.Location = New System.Drawing.Point(419, 403)
        Me.txt_description.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txt_description.Multiline = True
        Me.txt_description.Name = "txt_description"
        Me.txt_description.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_description.PlaceholderText = ""
        Me.txt_description.ReadOnly = True
        Me.txt_description.SelectedText = ""
        Me.txt_description.Size = New System.Drawing.Size(696, 444)
        Me.txt_description.TabIndex = 93
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(414, 368)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(228, 29)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "Order Description:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(1156, 490)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(189, 29)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "Order Balance:"
        '
        'txt_balance
        '
        Me.txt_balance.Animated = True
        Me.txt_balance.BorderRadius = 15
        Me.txt_balance.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_balance.DefaultText = ""
        Me.txt_balance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_balance.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_balance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_balance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_balance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_balance.Font = New System.Drawing.Font("Segoe UI", 15.75!)
        Me.txt_balance.ForeColor = System.Drawing.Color.Black
        Me.txt_balance.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_balance.Location = New System.Drawing.Point(1155, 525)
        Me.txt_balance.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txt_balance.Name = "txt_balance"
        Me.txt_balance.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_balance.PlaceholderText = ""
        Me.txt_balance.ReadOnly = True
        Me.txt_balance.SelectedText = ""
        Me.txt_balance.Size = New System.Drawing.Size(314, 55)
        Me.txt_balance.TabIndex = 90
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
        Me.btn_save.Location = New System.Drawing.Point(1155, 617)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(314, 112)
        Me.btn_save.TabIndex = 89
        Me.btn_save.Text = "SAVE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(414, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 29)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Order Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(414, 262)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(200, 29)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = "Order Deadline:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(1150, 376)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(195, 29)
        Me.Label7.TabIndex = 86
        Me.Label7.Text = "Order Payment:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(1145, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 29)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "Overall Price:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(649, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(208, 29)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "Customer Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1145, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 29)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Order Status:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(414, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 29)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Order ID:"
        '
        'txt_price
        '
        Me.txt_price.Animated = True
        Me.txt_price.BorderRadius = 15
        Me.txt_price.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_price.DefaultText = ""
        Me.txt_price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_price.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_price.Font = New System.Drawing.Font("Segoe UI", 15.75!)
        Me.txt_price.ForeColor = System.Drawing.Color.Black
        Me.txt_price.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_price.Location = New System.Drawing.Point(1150, 297)
        Me.txt_price.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_price.PlaceholderText = ""
        Me.txt_price.ReadOnly = True
        Me.txt_price.SelectedText = ""
        Me.txt_price.Size = New System.Drawing.Size(319, 55)
        Me.txt_price.TabIndex = 81
        '
        'txt_pay
        '
        Me.txt_pay.Animated = True
        Me.txt_pay.BorderRadius = 15
        Me.txt_pay.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_pay.DefaultText = ""
        Me.txt_pay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_pay.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_pay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_pay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_pay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_pay.Font = New System.Drawing.Font("Segoe UI", 15.75!)
        Me.txt_pay.ForeColor = System.Drawing.Color.Black
        Me.txt_pay.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_pay.Location = New System.Drawing.Point(1155, 411)
        Me.txt_pay.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txt_pay.Name = "txt_pay"
        Me.txt_pay.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_pay.PlaceholderText = ""
        Me.txt_pay.ReadOnly = True
        Me.txt_pay.SelectedText = ""
        Me.txt_pay.Size = New System.Drawing.Size(314, 55)
        Me.txt_pay.TabIndex = 80
        '
        'txt_date
        '
        Me.txt_date.Animated = True
        Me.txt_date.BorderRadius = 15
        Me.txt_date.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_date.DefaultText = ""
        Me.txt_date.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_date.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_date.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_date.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_date.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_date.Font = New System.Drawing.Font("Segoe UI", 15.75!)
        Me.txt_date.ForeColor = System.Drawing.Color.Black
        Me.txt_date.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_date.Location = New System.Drawing.Point(419, 191)
        Me.txt_date.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_date.PlaceholderText = ""
        Me.txt_date.ReadOnly = True
        Me.txt_date.SelectedText = ""
        Me.txt_date.Size = New System.Drawing.Size(696, 55)
        Me.txt_date.TabIndex = 79
        '
        'txt_name
        '
        Me.txt_name.Animated = True
        Me.txt_name.BorderRadius = 15
        Me.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_name.DefaultText = ""
        Me.txt_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_name.Font = New System.Drawing.Font("Segoe UI", 15.75!)
        Me.txt_name.ForeColor = System.Drawing.Color.Black
        Me.txt_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_name.Location = New System.Drawing.Point(654, 85)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_name.PlaceholderText = ""
        Me.txt_name.ReadOnly = True
        Me.txt_name.SelectedText = ""
        Me.txt_name.Size = New System.Drawing.Size(815, 55)
        Me.txt_name.TabIndex = 78
        '
        'txt_dead
        '
        Me.txt_dead.Animated = True
        Me.txt_dead.BorderRadius = 15
        Me.txt_dead.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_dead.DefaultText = ""
        Me.txt_dead.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_dead.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_dead.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_dead.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_dead.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_dead.Font = New System.Drawing.Font("Segoe UI", 15.75!)
        Me.txt_dead.ForeColor = System.Drawing.Color.Black
        Me.txt_dead.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_dead.Location = New System.Drawing.Point(419, 297)
        Me.txt_dead.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txt_dead.Name = "txt_dead"
        Me.txt_dead.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_dead.PlaceholderText = ""
        Me.txt_dead.ReadOnly = True
        Me.txt_dead.SelectedText = ""
        Me.txt_dead.Size = New System.Drawing.Size(696, 55)
        Me.txt_dead.TabIndex = 77
        '
        'txt_status
        '
        Me.txt_status.Animated = True
        Me.txt_status.BorderRadius = 15
        Me.txt_status.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_status.DefaultText = ""
        Me.txt_status.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_status.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_status.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_status.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_status.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_status.Font = New System.Drawing.Font("Segoe UI", 15.75!)
        Me.txt_status.ForeColor = System.Drawing.Color.Black
        Me.txt_status.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_status.Location = New System.Drawing.Point(1150, 191)
        Me.txt_status.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txt_status.Name = "txt_status"
        Me.txt_status.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_status.PlaceholderText = ""
        Me.txt_status.ReadOnly = True
        Me.txt_status.SelectedText = ""
        Me.txt_status.Size = New System.Drawing.Size(319, 55)
        Me.txt_status.TabIndex = 76
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
        Me.txt_orderid.Location = New System.Drawing.Point(419, 85)
        Me.txt_orderid.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txt_orderid.Name = "txt_orderid"
        Me.txt_orderid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_orderid.PlaceholderText = ""
        Me.txt_orderid.ReadOnly = True
        Me.txt_orderid.SelectedText = ""
        Me.txt_orderid.Size = New System.Drawing.Size(207, 55)
        Me.txt_orderid.TabIndex = 75
        '
        'pb_minimize
        '
        Me.pb_minimize.Image = CType(resources.GetObject("pb_minimize.Image"), System.Drawing.Image)
        Me.pb_minimize.Location = New System.Drawing.Point(1480, 12)
        Me.pb_minimize.Name = "pb_minimize"
        Me.pb_minimize.Size = New System.Drawing.Size(34, 33)
        Me.pb_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_minimize.TabIndex = 74
        Me.pb_minimize.TabStop = False
        '
        'pb_exit
        '
        Me.pb_exit.Image = CType(resources.GetObject("pb_exit.Image"), System.Drawing.Image)
        Me.pb_exit.Location = New System.Drawing.Point(1520, 12)
        Me.pb_exit.Name = "pb_exit"
        Me.pb_exit.Size = New System.Drawing.Size(34, 33)
        Me.pb_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_exit.TabIndex = 73
        Me.pb_exit.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(377, 859)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 72
        Me.PictureBox1.TabStop = False
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
        Me.btn_cancel.Location = New System.Drawing.Point(1155, 735)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(314, 112)
        Me.btn_cancel.TabIndex = 94
        Me.btn_cancel.Text = "CANCEL"
        '
        'UpdateRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1560, 859)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.txt_description)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_balance)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_pay)
        Me.Controls.Add(Me.txt_date)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_dead)
        Me.Controls.Add(Me.txt_status)
        Me.Controls.Add(Me.txt_orderid)
        Me.Controls.Add(Me.pb_minimize)
        Me.Controls.Add(Me.pb_exit)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UpdateRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UpdateRecord"
        CType(Me.pb_minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_exit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_description As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_balance As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_save As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_price As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_pay As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_date As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_name As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_dead As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_status As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_orderid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents pb_minimize As PictureBox
    Friend WithEvents pb_exit As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_cancel As Guna.UI2.WinForms.Guna2Button
End Class
