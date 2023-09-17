<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dashCanvas = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_minimize = New System.Windows.Forms.PictureBox()
        Me.btn_exit = New System.Windows.Forms.PictureBox()
        Me.btn_transaction = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_orders = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_sales = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.btn_minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_exit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Panel1.Controls.Add(Me.dashCanvas)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btn_transaction)
        Me.Panel1.Controls.Add(Me.btn_orders)
        Me.Panel1.Controls.Add(Me.btn_sales)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1712, 900)
        Me.Panel1.TabIndex = 0
        '
        'dashCanvas
        '
        Me.dashCanvas.Location = New System.Drawing.Point(3, 140)
        Me.dashCanvas.Name = "dashCanvas"
        Me.dashCanvas.Size = New System.Drawing.Size(1657, 757)
        Me.dashCanvas.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btn_minimize)
        Me.Panel2.Controls.Add(Me.btn_exit)
        Me.Panel2.Location = New System.Drawing.Point(1495, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(215, 134)
        Me.Panel2.TabIndex = 10
        '
        'btn_minimize
        '
        Me.btn_minimize.Image = CType(resources.GetObject("btn_minimize.Image"), System.Drawing.Image)
        Me.btn_minimize.Location = New System.Drawing.Point(82, 12)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.Size = New System.Drawing.Size(34, 33)
        Me.btn_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_minimize.TabIndex = 12
        Me.btn_minimize.TabStop = False
        '
        'btn_exit
        '
        Me.btn_exit.Image = CType(resources.GetObject("btn_exit.Image"), System.Drawing.Image)
        Me.btn_exit.Location = New System.Drawing.Point(122, 12)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(34, 33)
        Me.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_exit.TabIndex = 11
        Me.btn_exit.TabStop = False
        '
        'btn_transaction
        '
        Me.btn_transaction.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btn_transaction.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btn_transaction.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_transaction.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_transaction.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_transaction.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_transaction.FillColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btn_transaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btn_transaction.ForeColor = System.Drawing.Color.White
        Me.btn_transaction.Location = New System.Drawing.Point(1122, 0)
        Me.btn_transaction.Name = "btn_transaction"
        Me.btn_transaction.Size = New System.Drawing.Size(373, 134)
        Me.btn_transaction.TabIndex = 9
        Me.btn_transaction.Text = "TRANSACTION"
        '
        'btn_orders
        '
        Me.btn_orders.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btn_orders.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btn_orders.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_orders.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_orders.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_orders.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_orders.FillColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btn_orders.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btn_orders.ForeColor = System.Drawing.Color.White
        Me.btn_orders.Location = New System.Drawing.Point(754, 0)
        Me.btn_orders.Name = "btn_orders"
        Me.btn_orders.Size = New System.Drawing.Size(373, 134)
        Me.btn_orders.TabIndex = 8
        Me.btn_orders.Text = "ORDERS"
        '
        'btn_sales
        '
        Me.btn_sales.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btn_sales.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btn_sales.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btn_sales.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_sales.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_sales.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_sales.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_sales.FillColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btn_sales.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btn_sales.ForeColor = System.Drawing.Color.White
        Me.btn_sales.Location = New System.Drawing.Point(384, 0)
        Me.btn_sales.Name = "btn_sales"
        Me.btn_sales.Size = New System.Drawing.Size(385, 134)
        Me.btn_sales.TabIndex = 7
        Me.btn_sales.Text = "SALES"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(385, 134)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1663, 900)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.btn_minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_exit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_sales As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_transaction As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_orders As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_minimize As PictureBox
    Friend WithEvents btn_exit As PictureBox
    Friend WithEvents dashCanvas As Panel
End Class
