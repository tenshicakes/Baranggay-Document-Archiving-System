<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddForm
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
        Me.fullnametxt = New ReaLTaiizor.Controls.DungeonTextBox()
        Me.usernametxt = New ReaLTaiizor.Controls.DungeonTextBox()
        Me.passwordtxt = New ReaLTaiizor.Controls.DungeonTextBox()
        Me.confirmpasstxt = New ReaLTaiizor.Controls.DungeonTextBox()
        Me.rolecombo = New ReaLTaiizor.Controls.DungeonComboBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.addbtn = New ReaLTaiizor.Controls.FoxButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cancelbtn = New ReaLTaiizor.Controls.FoxButton()
        Me.SuspendLayout()
        '
        'fullnametxt
        '
        Me.fullnametxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fullnametxt.BackColor = System.Drawing.Color.Transparent
        Me.fullnametxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.fullnametxt.EdgeColor = System.Drawing.Color.White
        Me.fullnametxt.Font = New System.Drawing.Font("Nirmala UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullnametxt.ForeColor = System.Drawing.Color.Black
        Me.fullnametxt.Location = New System.Drawing.Point(48, 94)
        Me.fullnametxt.Margin = New System.Windows.Forms.Padding(3, 3, 3, 40)
        Me.fullnametxt.MaxLength = 32767
        Me.fullnametxt.Multiline = False
        Me.fullnametxt.Name = "fullnametxt"
        Me.fullnametxt.ReadOnly = False
        Me.fullnametxt.Size = New System.Drawing.Size(482, 38)
        Me.fullnametxt.TabIndex = 5
        Me.fullnametxt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.fullnametxt.UseSystemPasswordChar = False
        '
        'usernametxt
        '
        Me.usernametxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.usernametxt.BackColor = System.Drawing.Color.Transparent
        Me.usernametxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.usernametxt.EdgeColor = System.Drawing.Color.White
        Me.usernametxt.Font = New System.Drawing.Font("Nirmala UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernametxt.ForeColor = System.Drawing.Color.Black
        Me.usernametxt.Location = New System.Drawing.Point(48, 175)
        Me.usernametxt.Margin = New System.Windows.Forms.Padding(3, 3, 3, 40)
        Me.usernametxt.MaxLength = 32767
        Me.usernametxt.Multiline = False
        Me.usernametxt.Name = "usernametxt"
        Me.usernametxt.ReadOnly = False
        Me.usernametxt.Size = New System.Drawing.Size(482, 38)
        Me.usernametxt.TabIndex = 6
        Me.usernametxt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.usernametxt.UseSystemPasswordChar = False
        '
        'passwordtxt
        '
        Me.passwordtxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.passwordtxt.BackColor = System.Drawing.Color.Transparent
        Me.passwordtxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.passwordtxt.EdgeColor = System.Drawing.Color.White
        Me.passwordtxt.Font = New System.Drawing.Font("Nirmala UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordtxt.ForeColor = System.Drawing.Color.Black
        Me.passwordtxt.Location = New System.Drawing.Point(48, 256)
        Me.passwordtxt.Margin = New System.Windows.Forms.Padding(3, 3, 3, 40)
        Me.passwordtxt.MaxLength = 32767
        Me.passwordtxt.Multiline = False
        Me.passwordtxt.Name = "passwordtxt"
        Me.passwordtxt.ReadOnly = False
        Me.passwordtxt.Size = New System.Drawing.Size(482, 38)
        Me.passwordtxt.TabIndex = 7
        Me.passwordtxt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.passwordtxt.UseSystemPasswordChar = False
        '
        'confirmpasstxt
        '
        Me.confirmpasstxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.confirmpasstxt.BackColor = System.Drawing.Color.Transparent
        Me.confirmpasstxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.confirmpasstxt.EdgeColor = System.Drawing.Color.White
        Me.confirmpasstxt.Font = New System.Drawing.Font("Nirmala UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmpasstxt.ForeColor = System.Drawing.Color.Black
        Me.confirmpasstxt.Location = New System.Drawing.Point(48, 337)
        Me.confirmpasstxt.Margin = New System.Windows.Forms.Padding(3, 3, 3, 40)
        Me.confirmpasstxt.MaxLength = 32767
        Me.confirmpasstxt.Multiline = False
        Me.confirmpasstxt.Name = "confirmpasstxt"
        Me.confirmpasstxt.ReadOnly = False
        Me.confirmpasstxt.Size = New System.Drawing.Size(482, 38)
        Me.confirmpasstxt.TabIndex = 8
        Me.confirmpasstxt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.confirmpasstxt.UseSystemPasswordChar = False
        '
        'rolecombo
        '
        Me.rolecombo.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.rolecombo.ColorA = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.rolecombo.ColorB = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.rolecombo.ColorC = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.rolecombo.ColorD = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.rolecombo.ColorE = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.rolecombo.ColorF = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rolecombo.ColorG = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.rolecombo.ColorH = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.rolecombo.ColorI = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.rolecombo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rolecombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.rolecombo.DropDownHeight = 400
        Me.rolecombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.rolecombo.Font = New System.Drawing.Font("Nirmala UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.rolecombo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.rolecombo.FormattingEnabled = True
        Me.rolecombo.HoverSelectionColor = System.Drawing.Color.Empty
        Me.rolecombo.IntegralHeight = False
        Me.rolecombo.ItemHeight = 40
        Me.rolecombo.Items.AddRange(New Object() {"test", "test", "test", "test"})
        Me.rolecombo.Location = New System.Drawing.Point(48, 418)
        Me.rolecombo.Margin = New System.Windows.Forms.Padding(3, 3, 3, 40)
        Me.rolecombo.Name = "rolecombo"
        Me.rolecombo.Size = New System.Drawing.Size(482, 46)
        Me.rolecombo.StartIndex = 0
        Me.rolecombo.TabIndex = 11
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.White
        Me.Label41.Location = New System.Drawing.Point(439, 9)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(128, 25)
        Me.Label41.TabIndex = 29
        Me.Label41.Text = "Add Account"
        '
        'addbtn
        '
        Me.addbtn.BackColor = System.Drawing.Color.Transparent
        Me.addbtn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.addbtn.BorderColor = System.Drawing.Color.Transparent
        Me.addbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addbtn.DisabledBaseColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.addbtn.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.addbtn.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.addbtn.DownColor = System.Drawing.Color.Gray
        Me.addbtn.EnabledCalc = True
        Me.addbtn.Font = New System.Drawing.Font("Nirmala UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addbtn.ForeColor = System.Drawing.Color.White
        Me.addbtn.Location = New System.Drawing.Point(301, 491)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.OverColor = System.Drawing.Color.Gray
        Me.addbtn.Size = New System.Drawing.Size(229, 51)
        Me.addbtn.TabIndex = 30
        Me.addbtn.Text = "Add Account"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(43, 61)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 25)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Full Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(43, 142)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 0, 3, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 25)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(43, 223)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 0, 3, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 25)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(43, 304)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 0, 3, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 25)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Confirm Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(43, 385)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3, 0, 3, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 25)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Role"
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
        Me.cancelbtn.Location = New System.Drawing.Point(48, 491)
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.OverColor = System.Drawing.Color.Gray
        Me.cancelbtn.Size = New System.Drawing.Size(229, 51)
        Me.cancelbtn.TabIndex = 36
        Me.cancelbtn.Text = "Cancel"
        '
        'AddForm
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
        Me.Controls.Add(Me.addbtn)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.rolecombo)
        Me.Controls.Add(Me.confirmpasstxt)
        Me.Controls.Add(Me.passwordtxt)
        Me.Controls.Add(Me.usernametxt)
        Me.Controls.Add(Me.fullnametxt)
        Me.MaximumSize = New System.Drawing.Size(595, 609)
        Me.MinimumSize = New System.Drawing.Size(595, 609)
        Me.Name = "AddForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fullnametxt As ReaLTaiizor.Controls.DungeonTextBox
    Friend WithEvents usernametxt As ReaLTaiizor.Controls.DungeonTextBox
    Friend WithEvents passwordtxt As ReaLTaiizor.Controls.DungeonTextBox
    Friend WithEvents confirmpasstxt As ReaLTaiizor.Controls.DungeonTextBox
    Friend WithEvents rolecombo As ReaLTaiizor.Controls.DungeonComboBox
    Friend WithEvents Label41 As Label
    Friend WithEvents addbtn As ReaLTaiizor.Controls.FoxButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cancelbtn As ReaLTaiizor.Controls.FoxButton
End Class
