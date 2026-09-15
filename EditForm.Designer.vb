<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditForm
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
        Me.cancelbtn = New ReaLTaiizor.Controls.FoxButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.savebtn = New ReaLTaiizor.Controls.FoxButton()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.rolecomboedit = New ReaLTaiizor.Controls.DungeonComboBox()
        Me.confirmpassedit = New ReaLTaiizor.Controls.DungeonTextBox()
        Me.passwordedit = New ReaLTaiizor.Controls.DungeonTextBox()
        Me.usernameedit = New ReaLTaiizor.Controls.DungeonTextBox()
        Me.fullnamedit = New ReaLTaiizor.Controls.DungeonTextBox()
        Me.SuspendLayout()
        '
        'cancelbtn
        '
        Me.cancelbtn.BackColor = System.Drawing.Color.Transparent
        Me.cancelbtn.BaseColor = System.Drawing.Color.White
        Me.cancelbtn.BorderColor = System.Drawing.Color.Transparent
        Me.cancelbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelbtn.DisabledBaseColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.cancelbtn.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.cancelbtn.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.cancelbtn.DownColor = System.Drawing.Color.Gray
        Me.cancelbtn.EnabledCalc = True
        Me.cancelbtn.Font = New System.Drawing.Font("Nirmala UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelbtn.ForeColor = System.Drawing.Color.Black
        Me.cancelbtn.Location = New System.Drawing.Point(46, 494)
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.OverColor = System.Drawing.Color.Gray
        Me.cancelbtn.Size = New System.Drawing.Size(229, 51)
        Me.cancelbtn.TabIndex = 49
        Me.cancelbtn.Text = "Cancel"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(41, 388)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3, 0, 3, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 25)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Role"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(41, 307)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 0, 3, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 25)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Confirm Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(41, 226)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 0, 3, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 25)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(41, 145)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 0, 3, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 25)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(41, 64)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 25)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Full Name"
        '
        'savebtn
        '
        Me.savebtn.BackColor = System.Drawing.Color.Transparent
        Me.savebtn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.savebtn.BorderColor = System.Drawing.Color.Transparent
        Me.savebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.savebtn.DisabledBaseColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.savebtn.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.savebtn.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.savebtn.DownColor = System.Drawing.Color.Gray
        Me.savebtn.EnabledCalc = True
        Me.savebtn.Font = New System.Drawing.Font("Nirmala UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.savebtn.ForeColor = System.Drawing.Color.White
        Me.savebtn.Location = New System.Drawing.Point(299, 494)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.OverColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.savebtn.Size = New System.Drawing.Size(229, 51)
        Me.savebtn.TabIndex = 43
        Me.savebtn.Text = "Add Account"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.White
        Me.Label41.Location = New System.Drawing.Point(437, 12)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(128, 25)
        Me.Label41.TabIndex = 42
        Me.Label41.Text = "Add Account"
        '
        'rolecomboedit
        '
        Me.rolecomboedit.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.rolecomboedit.ColorA = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.rolecomboedit.ColorB = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.rolecomboedit.ColorC = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.rolecomboedit.ColorD = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.rolecomboedit.ColorE = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.rolecomboedit.ColorF = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rolecomboedit.ColorG = System.Drawing.Color.Black
        Me.rolecomboedit.ColorH = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.rolecomboedit.ColorI = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.rolecomboedit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rolecomboedit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.rolecomboedit.DropDownHeight = 400
        Me.rolecomboedit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.rolecomboedit.Font = New System.Drawing.Font("Nirmala UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.rolecomboedit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.rolecomboedit.FormattingEnabled = True
        Me.rolecomboedit.HoverSelectionColor = System.Drawing.Color.Empty
        Me.rolecomboedit.IntegralHeight = False
        Me.rolecomboedit.ItemHeight = 40
        Me.rolecomboedit.Items.AddRange(New Object() {"test", "test", "test", "test"})
        Me.rolecomboedit.Location = New System.Drawing.Point(46, 421)
        Me.rolecomboedit.Margin = New System.Windows.Forms.Padding(3, 3, 3, 40)
        Me.rolecomboedit.Name = "rolecomboedit"
        Me.rolecomboedit.Size = New System.Drawing.Size(482, 46)
        Me.rolecomboedit.StartIndex = 0
        Me.rolecomboedit.TabIndex = 41
        '
        'confirmpassedit
        '
        Me.confirmpassedit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.confirmpassedit.BackColor = System.Drawing.Color.Transparent
        Me.confirmpassedit.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.confirmpassedit.EdgeColor = System.Drawing.Color.White
        Me.confirmpassedit.Font = New System.Drawing.Font("Nirmala UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmpassedit.ForeColor = System.Drawing.Color.Black
        Me.confirmpassedit.Location = New System.Drawing.Point(46, 340)
        Me.confirmpassedit.Margin = New System.Windows.Forms.Padding(3, 3, 3, 40)
        Me.confirmpassedit.MaxLength = 32767
        Me.confirmpassedit.Multiline = False
        Me.confirmpassedit.Name = "confirmpassedit"
        Me.confirmpassedit.ReadOnly = False
        Me.confirmpassedit.Size = New System.Drawing.Size(482, 38)
        Me.confirmpassedit.TabIndex = 40
        Me.confirmpassedit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.confirmpassedit.UseSystemPasswordChar = True
        '
        'passwordedit
        '
        Me.passwordedit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.passwordedit.BackColor = System.Drawing.Color.Transparent
        Me.passwordedit.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.passwordedit.EdgeColor = System.Drawing.Color.White
        Me.passwordedit.Font = New System.Drawing.Font("Nirmala UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordedit.ForeColor = System.Drawing.Color.Black
        Me.passwordedit.Location = New System.Drawing.Point(46, 259)
        Me.passwordedit.Margin = New System.Windows.Forms.Padding(3, 3, 3, 40)
        Me.passwordedit.MaxLength = 32767
        Me.passwordedit.Multiline = False
        Me.passwordedit.Name = "passwordedit"
        Me.passwordedit.ReadOnly = False
        Me.passwordedit.Size = New System.Drawing.Size(482, 38)
        Me.passwordedit.TabIndex = 39
        Me.passwordedit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.passwordedit.UseSystemPasswordChar = True
        '
        'usernameedit
        '
        Me.usernameedit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.usernameedit.BackColor = System.Drawing.Color.Transparent
        Me.usernameedit.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.usernameedit.EdgeColor = System.Drawing.Color.White
        Me.usernameedit.Font = New System.Drawing.Font("Nirmala UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameedit.ForeColor = System.Drawing.Color.Black
        Me.usernameedit.Location = New System.Drawing.Point(46, 178)
        Me.usernameedit.Margin = New System.Windows.Forms.Padding(3, 3, 3, 40)
        Me.usernameedit.MaxLength = 32767
        Me.usernameedit.Multiline = False
        Me.usernameedit.Name = "usernameedit"
        Me.usernameedit.ReadOnly = False
        Me.usernameedit.Size = New System.Drawing.Size(482, 38)
        Me.usernameedit.TabIndex = 38
        Me.usernameedit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.usernameedit.UseSystemPasswordChar = False
        '
        'fullnamedit
        '
        Me.fullnamedit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fullnamedit.BackColor = System.Drawing.Color.Transparent
        Me.fullnamedit.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.fullnamedit.EdgeColor = System.Drawing.Color.White
        Me.fullnamedit.Font = New System.Drawing.Font("Nirmala UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullnamedit.ForeColor = System.Drawing.Color.Black
        Me.fullnamedit.Location = New System.Drawing.Point(46, 97)
        Me.fullnamedit.Margin = New System.Windows.Forms.Padding(3, 3, 3, 40)
        Me.fullnamedit.MaxLength = 32767
        Me.fullnamedit.Multiline = False
        Me.fullnamedit.Name = "fullnamedit"
        Me.fullnamedit.ReadOnly = False
        Me.fullnamedit.Size = New System.Drawing.Size(482, 38)
        Me.fullnamedit.TabIndex = 37
        Me.fullnamedit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.fullnamedit.UseSystemPasswordChar = False
        '
        'EditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(579, 570)
        Me.Controls.Add(Me.cancelbtn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.rolecomboedit)
        Me.Controls.Add(Me.confirmpassedit)
        Me.Controls.Add(Me.passwordedit)
        Me.Controls.Add(Me.usernameedit)
        Me.Controls.Add(Me.fullnamedit)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditForm"
        Me.ShowIcon = False
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cancelbtn As ReaLTaiizor.Controls.FoxButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents savebtn As ReaLTaiizor.Controls.FoxButton
    Friend WithEvents Label41 As Label
    Friend WithEvents rolecomboedit As ReaLTaiizor.Controls.DungeonComboBox
    Friend WithEvents confirmpassedit As ReaLTaiizor.Controls.DungeonTextBox
    Friend WithEvents passwordedit As ReaLTaiizor.Controls.DungeonTextBox
    Friend WithEvents usernameedit As ReaLTaiizor.Controls.DungeonTextBox
    Friend WithEvents fullnamedit As ReaLTaiizor.Controls.DungeonTextBox
End Class
