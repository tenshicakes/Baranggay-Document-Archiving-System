<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RequestForm
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
        Me.fullnamelbl = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.addresslbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.birthdatelbl = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.numberlbl = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.documentcat_combo = New ReaLTaiizor.Controls.DungeonComboBox()
        Me.submitreqbtn = New ReaLTaiizor.Controls.FoxButton()
        Me.cancelbtn = New ReaLTaiizor.Controls.FoxButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.documenttype_combo = New ReaLTaiizor.Controls.DungeonComboBox()
        Me.SuspendLayout()
        '
        'fullnamelbl
        '
        Me.fullnamelbl.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.fullnamelbl.AutoSize = True
        Me.fullnamelbl.Font = New System.Drawing.Font("Nirmala UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullnamelbl.ForeColor = System.Drawing.Color.Black
        Me.fullnamelbl.Location = New System.Drawing.Point(11, 98)
        Me.fullnamelbl.Margin = New System.Windows.Forms.Padding(3, 0, 3, 10)
        Me.fullnamelbl.Name = "fullnamelbl"
        Me.fullnamelbl.Size = New System.Drawing.Size(201, 30)
        Me.fullnamelbl.TabIndex = 7
        Me.fullnamelbl.Text = "Louie Jelaine Recto"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(12, 77)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 21)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "Full Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 21)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Adress"
        '
        'addresslbl
        '
        Me.addresslbl.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.addresslbl.AutoSize = True
        Me.addresslbl.Font = New System.Drawing.Font("Nirmala UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addresslbl.ForeColor = System.Drawing.Color.Black
        Me.addresslbl.Location = New System.Drawing.Point(11, 159)
        Me.addresslbl.Margin = New System.Windows.Forms.Padding(3, 0, 3, 10)
        Me.addresslbl.Name = "addresslbl"
        Me.addresslbl.Size = New System.Drawing.Size(514, 30)
        Me.addresslbl.TabIndex = 11
        Me.addresslbl.Text = "123 Biringat City, Baranggay Sak Dudol Philippines"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(181, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(305, 30)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Resident Information Preview"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(12, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 21)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Birth Date"
        '
        'birthdatelbl
        '
        Me.birthdatelbl.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.birthdatelbl.AutoSize = True
        Me.birthdatelbl.Font = New System.Drawing.Font("Nirmala UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.birthdatelbl.ForeColor = System.Drawing.Color.Black
        Me.birthdatelbl.Location = New System.Drawing.Point(11, 220)
        Me.birthdatelbl.Margin = New System.Windows.Forms.Padding(3, 0, 3, 10)
        Me.birthdatelbl.Name = "birthdatelbl"
        Me.birthdatelbl.Size = New System.Drawing.Size(125, 30)
        Me.birthdatelbl.TabIndex = 14
        Me.birthdatelbl.Text = "04-12-2004"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(14, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 21)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Phone Number"
        '
        'numberlbl
        '
        Me.numberlbl.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.numberlbl.AutoSize = True
        Me.numberlbl.Font = New System.Drawing.Font("Nirmala UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numberlbl.ForeColor = System.Drawing.Color.Black
        Me.numberlbl.Location = New System.Drawing.Point(13, 281)
        Me.numberlbl.Margin = New System.Windows.Forms.Padding(3, 0, 3, 10)
        Me.numberlbl.Name = "numberlbl"
        Me.numberlbl.Size = New System.Drawing.Size(157, 30)
        Me.numberlbl.TabIndex = 16
        Me.numberlbl.Text = "096767676767"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(12, 333)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 21)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Document Category"
        '
        'documentcat_combo
        '
        Me.documentcat_combo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.documentcat_combo.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.documentcat_combo.ColorA = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.documentcat_combo.ColorB = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.documentcat_combo.ColorC = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.documentcat_combo.ColorD = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.documentcat_combo.ColorE = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.documentcat_combo.ColorF = System.Drawing.Color.Black
        Me.documentcat_combo.ColorG = System.Drawing.Color.Black
        Me.documentcat_combo.ColorH = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.documentcat_combo.ColorI = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.documentcat_combo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.documentcat_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.documentcat_combo.DropDownHeight = 400
        Me.documentcat_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.documentcat_combo.Font = New System.Drawing.Font("Nirmala UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.documentcat_combo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.documentcat_combo.FormattingEnabled = True
        Me.documentcat_combo.HoverSelectionColor = System.Drawing.Color.Empty
        Me.documentcat_combo.IntegralHeight = False
        Me.documentcat_combo.ItemHeight = 40
        Me.documentcat_combo.Items.AddRange(New Object() {"test", "test", "test", "test"})
        Me.documentcat_combo.Location = New System.Drawing.Point(16, 357)
        Me.documentcat_combo.Name = "documentcat_combo"
        Me.documentcat_combo.Size = New System.Drawing.Size(315, 46)
        Me.documentcat_combo.StartIndex = 0
        Me.documentcat_combo.TabIndex = 18
        '
        'submitreqbtn
        '
        Me.submitreqbtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.submitreqbtn.BackColor = System.Drawing.Color.Transparent
        Me.submitreqbtn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.submitreqbtn.BorderColor = System.Drawing.Color.Transparent
        Me.submitreqbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.submitreqbtn.DisabledBaseColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.submitreqbtn.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.submitreqbtn.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.submitreqbtn.DownColor = System.Drawing.Color.Gray
        Me.submitreqbtn.EnabledCalc = True
        Me.submitreqbtn.Font = New System.Drawing.Font("Nirmala UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitreqbtn.ForeColor = System.Drawing.Color.White
        Me.submitreqbtn.Location = New System.Drawing.Point(354, 529)
        Me.submitreqbtn.Name = "submitreqbtn"
        Me.submitreqbtn.OverColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.submitreqbtn.Size = New System.Drawing.Size(318, 65)
        Me.submitreqbtn.TabIndex = 19
        Me.submitreqbtn.Text = "Submit Request"
        '
        'cancelbtn
        '
        Me.cancelbtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cancelbtn.BackColor = System.Drawing.Color.Transparent
        Me.cancelbtn.BaseColor = System.Drawing.Color.DimGray
        Me.cancelbtn.BorderColor = System.Drawing.Color.Transparent
        Me.cancelbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelbtn.DisabledBaseColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.cancelbtn.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.cancelbtn.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.cancelbtn.DownColor = System.Drawing.Color.Silver
        Me.cancelbtn.EnabledCalc = True
        Me.cancelbtn.Font = New System.Drawing.Font("Nirmala UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelbtn.ForeColor = System.Drawing.Color.White
        Me.cancelbtn.Location = New System.Drawing.Point(16, 529)
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.OverColor = System.Drawing.Color.DimGray
        Me.cancelbtn.Size = New System.Drawing.Size(318, 65)
        Me.cancelbtn.TabIndex = 20
        Me.cancelbtn.Text = "Cancel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 421)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 21)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Requested Document"
        '
        'documenttype_combo
        '
        Me.documenttype_combo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.documenttype_combo.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.documenttype_combo.ColorA = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.documenttype_combo.ColorB = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.documenttype_combo.ColorC = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.documenttype_combo.ColorD = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.documenttype_combo.ColorE = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.documenttype_combo.ColorF = System.Drawing.Color.Black
        Me.documenttype_combo.ColorG = System.Drawing.Color.Black
        Me.documenttype_combo.ColorH = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.documenttype_combo.ColorI = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.documenttype_combo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.documenttype_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.documenttype_combo.DropDownHeight = 400
        Me.documenttype_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.documenttype_combo.Font = New System.Drawing.Font("Nirmala UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.documenttype_combo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.documenttype_combo.FormattingEnabled = True
        Me.documenttype_combo.HoverSelectionColor = System.Drawing.Color.Empty
        Me.documenttype_combo.IntegralHeight = False
        Me.documenttype_combo.ItemHeight = 40
        Me.documenttype_combo.Items.AddRange(New Object() {"test", "test", "test", "test"})
        Me.documenttype_combo.Location = New System.Drawing.Point(18, 445)
        Me.documenttype_combo.Name = "documenttype_combo"
        Me.documenttype_combo.Size = New System.Drawing.Size(315, 46)
        Me.documenttype_combo.StartIndex = 0
        Me.documenttype_combo.TabIndex = 22
        '
        'RequestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 606)
        Me.Controls.Add(Me.documenttype_combo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cancelbtn)
        Me.Controls.Add(Me.submitreqbtn)
        Me.Controls.Add(Me.documentcat_combo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.numberlbl)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.birthdatelbl)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.addresslbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.fullnamelbl)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(700, 645)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(700, 645)
        Me.Name = "RequestForm"
        Me.ShowIcon = False
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fullnamelbl As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents addresslbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents birthdatelbl As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents numberlbl As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents documentcat_combo As ReaLTaiizor.Controls.DungeonComboBox
    Friend WithEvents submitreqbtn As ReaLTaiizor.Controls.FoxButton
    Friend WithEvents cancelbtn As ReaLTaiizor.Controls.FoxButton
    Friend WithEvents Label2 As Label
    Friend WithEvents documenttype_combo As ReaLTaiizor.Controls.DungeonComboBox
End Class
