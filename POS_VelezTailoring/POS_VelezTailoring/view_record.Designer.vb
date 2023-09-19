<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class view_record
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(view_record))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pb_minimize = New System.Windows.Forms.PictureBox()
        Me.pb_exit = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.order_viewPanel = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.pb_minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_exit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Panel1.Controls.Add(Me.order_viewPanel)
        Me.Panel1.Controls.Add(Me.pb_minimize)
        Me.Panel1.Controls.Add(Me.pb_exit)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1406, 533)
        Me.Panel1.TabIndex = 0
        '
        'pb_minimize
        '
        Me.pb_minimize.Image = CType(resources.GetObject("pb_minimize.Image"), System.Drawing.Image)
        Me.pb_minimize.Location = New System.Drawing.Point(1320, 12)
        Me.pb_minimize.Name = "pb_minimize"
        Me.pb_minimize.Size = New System.Drawing.Size(34, 33)
        Me.pb_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_minimize.TabIndex = 21
        Me.pb_minimize.TabStop = False
        '
        'pb_exit
        '
        Me.pb_exit.Image = CType(resources.GetObject("pb_exit.Image"), System.Drawing.Image)
        Me.pb_exit.Location = New System.Drawing.Point(1360, 12)
        Me.pb_exit.Name = "pb_exit"
        Me.pb_exit.Size = New System.Drawing.Size(34, 33)
        Me.pb_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_exit.TabIndex = 20
        Me.pb_exit.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(377, 529)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'order_viewPanel
        '
        Me.order_viewPanel.Location = New System.Drawing.Point(383, 35)
        Me.order_viewPanel.Name = "order_viewPanel"
        Me.order_viewPanel.Size = New System.Drawing.Size(928, 473)
        Me.order_viewPanel.TabIndex = 22
        '
        'view_record
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1406, 530)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "view_record"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "view_record"
        Me.Panel1.ResumeLayout(False)
        CType(Me.pb_minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_exit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pb_minimize As PictureBox
    Friend WithEvents pb_exit As PictureBox
    Friend WithEvents order_viewPanel As Panel
End Class
