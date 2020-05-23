<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class acilis_ekrani
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(acilis_ekrani))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.progDoldur = New System.Windows.Forms.ProgressBar()
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'progDoldur
        '
        Me.progDoldur.Location = New System.Drawing.Point(27, 299)
        Me.progDoldur.Name = "progDoldur"
        Me.progDoldur.Size = New System.Drawing.Size(231, 23)
        Me.progDoldur.TabIndex = 5
        Me.progDoldur.Visible = False
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 5
        Me.BunifuElipse2.TargetControl = Me
        '
        'pictureBox2
        '
        Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image)
        Me.pictureBox2.Location = New System.Drawing.Point(58, 241)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(168, 43)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureBox2.TabIndex = 4
        Me.pictureBox2.TabStop = False
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(27, 37)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(231, 198)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 3
        Me.pictureBox1.TabStop = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(67, 305)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Bağlantınız ile ilgi problem var.!"
        Me.Label1.Visible = False
        '
        'Timer1
        '
        '
        'acilis_ekrani
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(284, 358)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.progDoldur)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.pictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(284, 358)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(284, 358)
        Me.Name = "acilis_ekrani"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Private WithEvents progDoldur As System.Windows.Forms.ProgressBar
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
