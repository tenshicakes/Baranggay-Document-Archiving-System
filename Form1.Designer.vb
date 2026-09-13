<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.MaterialCard1 = New ReaLTaiizor.Controls.MaterialCard()
        Me.loginbtn = New ReaLTaiizor.Controls.FoxButton()
        Me.passtxtbox = New ReaLTaiizor.Controls.DungeonTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.usertxtbox = New ReaLTaiizor.Controls.DungeonTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MaterialCard1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaterialCard1
        '
        Me.MaterialCard1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard1.Controls.Add(Me.loginbtn)
        Me.MaterialCard1.Controls.Add(Me.passtxtbox)
        Me.MaterialCard1.Controls.Add(Me.Label3)
        Me.MaterialCard1.Controls.Add(Me.usertxtbox)
        Me.MaterialCard1.Controls.Add(Me.Label2)
        Me.MaterialCard1.Controls.Add(Me.Panel1)
        Me.MaterialCard1.Depth = 0
        Me.MaterialCard1.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaterialCard1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard1.Location = New System.Drawing.Point(458, 23)
        Me.MaterialCard1.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.MaterialCard1.Name = "MaterialCard1"
        Me.MaterialCard1.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.Size = New System.Drawing.Size(361, 417)
        Me.MaterialCard1.TabIndex = 0
        '
        'loginbtn
        '
        Me.loginbtn.BackColor = System.Drawing.Color.Transparent
        Me.loginbtn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.loginbtn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.loginbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loginbtn.DisabledBaseColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.loginbtn.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.loginbtn.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.loginbtn.DownColor = System.Drawing.Color.Silver
        Me.loginbtn.EnabledCalc = True
        Me.loginbtn.Font = New System.Drawing.Font("Nirmala UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginbtn.ForeColor = System.Drawing.Color.White
        Me.loginbtn.Location = New System.Drawing.Point(23, 327)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.OverColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.loginbtn.Size = New System.Drawing.Size(310, 63)
        Me.loginbtn.TabIndex = 5
        Me.loginbtn.Text = "Login"
        '
        'passtxtbox
        '
        Me.passtxtbox.BackColor = System.Drawing.Color.Transparent
        Me.passtxtbox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.passtxtbox.EdgeColor = System.Drawing.Color.White
        Me.passtxtbox.Font = New System.Drawing.Font("Nirmala UI", 18.0!)
        Me.passtxtbox.ForeColor = System.Drawing.Color.Black
        Me.passtxtbox.Location = New System.Drawing.Point(23, 226)
        Me.passtxtbox.MaxLength = 32767
        Me.passtxtbox.Multiline = False
        Me.passtxtbox.Name = "passtxtbox"
        Me.passtxtbox.ReadOnly = False
        Me.passtxtbox.Size = New System.Drawing.Size(310, 42)
        Me.passtxtbox.TabIndex = 4
        Me.passtxtbox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.passtxtbox.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(17, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 32)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Password"
        '
        'usertxtbox
        '
        Me.usertxtbox.BackColor = System.Drawing.Color.Transparent
        Me.usertxtbox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.usertxtbox.EdgeColor = System.Drawing.Color.White
        Me.usertxtbox.Font = New System.Drawing.Font("Nirmala UI", 18.0!)
        Me.usertxtbox.ForeColor = System.Drawing.Color.Black
        Me.usertxtbox.Location = New System.Drawing.Point(23, 127)
        Me.usertxtbox.MaxLength = 32767
        Me.usertxtbox.Multiline = False
        Me.usertxtbox.Name = "usertxtbox"
        Me.usertxtbox.ReadOnly = False
        Me.usertxtbox.Size = New System.Drawing.Size(310, 42)
        Me.usertxtbox.TabIndex = 2
        Me.usertxtbox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.usertxtbox.UseSystemPasswordChar = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(17, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(361, 55)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(109, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(42, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(366, 365)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Myanmar Text", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(11, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(441, 48)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "DOCUMENT ARCHIVING SYSTEM"
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(842, 463)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MaterialCard1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(858, 502)
        Me.MinimumSize = New System.Drawing.Size(858, 502)
        Me.Name = "login"
        Me.ShowIcon = False
        Me.Text = "   "
        Me.MaterialCard1.ResumeLayout(False)
        Me.MaterialCard1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialCard1 As ReaLTaiizor.Controls.MaterialCard
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents passtxtbox As ReaLTaiizor.Controls.DungeonTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents usertxtbox As ReaLTaiizor.Controls.DungeonTextBox
    Friend WithEvents loginbtn As ReaLTaiizor.Controls.FoxButton
    Friend WithEvents Label4 As Label
End Class
