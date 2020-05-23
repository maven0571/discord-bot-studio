<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bunifuFormFadeTransition1 = New Bunifu.Framework.UI.BunifuFormFadeTransition(Me.components)
        Me.pictureBox4 = New System.Windows.Forms.PictureBox()
        Me.panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.button2 = New System.Windows.Forms.Button()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.button1 = New System.Windows.Forms.Button()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel4.SuspendLayout()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel3.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'bunifuFormFadeTransition1
        '
        Me.bunifuFormFadeTransition1.Delay = 1
        '
        'pictureBox4
        '
        Me.pictureBox4.Image = CType(resources.GetObject("pictureBox4.Image"), System.Drawing.Image)
        Me.pictureBox4.Location = New System.Drawing.Point(11, 101)
        Me.pictureBox4.Name = "pictureBox4"
        Me.pictureBox4.Size = New System.Drawing.Size(49, 19)
        Me.pictureBox4.TabIndex = 0
        Me.pictureBox4.TabStop = False
        '
        'panel4
        '
        Me.panel4.Controls.Add(Me.Label1)
        Me.panel4.Controls.Add(Me.WebBrowser1)
        Me.panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel4.Location = New System.Drawing.Point(0, 0)
        Me.panel4.Name = "panel4"
        Me.panel4.Size = New System.Drawing.Size(602, 416)
        Me.panel4.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(384, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 1
        '
        'WebBrowser1
        '
        Me.WebBrowser1.IsWebBrowserContextMenuEnabled = False
        Me.WebBrowser1.Location = New System.Drawing.Point(579, 418)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScrollBarsEnabled = False
        Me.WebBrowser1.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.Url = New System.Uri("https://discord-bot-studio.glitch.me/", System.UriKind.Absolute)
        Me.WebBrowser1.Visible = False
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button2.ForeColor = System.Drawing.Color.White
        Me.button2.Location = New System.Drawing.Point(556, 4)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(46, 23)
        Me.button2.TabIndex = 1
        Me.button2.Text = "-"
        Me.button2.UseVisualStyleBackColor = False
        '
        'pictureBox3
        '
        Me.pictureBox3.Image = CType(resources.GetObject("pictureBox3.Image"), System.Drawing.Image)
        Me.pictureBox3.Location = New System.Drawing.Point(11, 120)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(49, 48)
        Me.pictureBox3.TabIndex = 5
        Me.pictureBox3.TabStop = False
        '
        'pictureBox2
        '
        Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image)
        Me.pictureBox2.Location = New System.Drawing.Point(11, 52)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(49, 48)
        Me.pictureBox2.TabIndex = 0
        Me.pictureBox2.TabStop = False
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(8, 8)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(151, 30)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 4
        Me.pictureBox1.TabStop = False
        '
        'panel3
        '
        Me.panel3.Controls.Add(Me.Button3)
        Me.panel3.Controls.Add(Me.button2)
        Me.panel3.Controls.Add(Me.button1)
        Me.panel3.Location = New System.Drawing.Point(3, 3)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(657, 35)
        Me.panel3.TabIndex = 0
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.ForeColor = System.Drawing.Color.White
        Me.button1.Location = New System.Drawing.Point(608, 4)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(46, 23)
        Me.button1.TabIndex = 0
        Me.button1.Text = "X"
        Me.button1.UseVisualStyleBackColor = False
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.panel1.Controls.Add(Me.pictureBox4)
        Me.panel1.Controls.Add(Me.pictureBox3)
        Me.panel1.Controls.Add(Me.pictureBox2)
        Me.panel1.Controls.Add(Me.pictureBox1)
        Me.panel1.Controls.Add(Me.panel2)
        Me.panel1.Controls.Add(Me.panel3)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(671, 461)
        Me.panel1.TabIndex = 1
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.panel2.Controls.Add(Me.panel4)
        Me.panel2.Location = New System.Drawing.Point(69, 45)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(602, 416)
        Me.panel2.TabIndex = 3
        '
        'Timer1
        '
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(504, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(46, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "?"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 461)
        Me.Controls.Add(Me.panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Discord Bot Studio"
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel4.ResumeLayout(False)
        Me.panel4.PerformLayout()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel3.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents pictureBox4 As System.Windows.Forms.PictureBox
    Private WithEvents pictureBox3 As System.Windows.Forms.PictureBox
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents panel4 As System.Windows.Forms.Panel
    Private WithEvents panel3 As System.Windows.Forms.Panel
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents bunifuFormFadeTransition1 As Bunifu.Framework.UI.BunifuFormFadeTransition
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Private WithEvents Button3 As System.Windows.Forms.Button

End Class
