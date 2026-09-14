<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateStatus
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
        Me.MaterialCard1 = New ReaLTaiizor.Controls.MaterialCard()
        Me.updatebtn = New ReaLTaiizor.Controls.FoxButton()
        Me.cancelbtn = New ReaLTaiizor.Controls.FoxButton()
        Me.recordpreview = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.statuscombo = New ReaLTaiizor.Controls.DungeonComboBox()
        Me.MaterialCard1.SuspendLayout()
        CType(Me.recordpreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaterialCard1
        '
        Me.MaterialCard1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard1.Controls.Add(Me.recordpreview)
        Me.MaterialCard1.Depth = 0
        Me.MaterialCard1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard1.Location = New System.Drawing.Point(23, 110)
        Me.MaterialCard1.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.MaterialCard1.Name = "MaterialCard1"
        Me.MaterialCard1.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.Size = New System.Drawing.Size(465, 481)
        Me.MaterialCard1.TabIndex = 0
        '
        'updatebtn
        '
        Me.updatebtn.BackColor = System.Drawing.Color.Transparent
        Me.updatebtn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.updatebtn.BorderColor = System.Drawing.Color.Transparent
        Me.updatebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.updatebtn.DisabledBaseColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.updatebtn.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.updatebtn.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.updatebtn.DownColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.updatebtn.EnabledCalc = True
        Me.updatebtn.Font = New System.Drawing.Font("Nirmala UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatebtn.ForeColor = System.Drawing.Color.White
        Me.updatebtn.Location = New System.Drawing.Point(261, 608)
        Me.updatebtn.Name = "updatebtn"
        Me.updatebtn.OverColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.updatebtn.Size = New System.Drawing.Size(227, 40)
        Me.updatebtn.TabIndex = 9
        Me.updatebtn.Text = "Update"
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
        Me.cancelbtn.DownColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.cancelbtn.EnabledCalc = True
        Me.cancelbtn.Font = New System.Drawing.Font("Nirmala UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelbtn.ForeColor = System.Drawing.Color.Black
        Me.cancelbtn.Location = New System.Drawing.Point(23, 608)
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.OverColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.cancelbtn.Size = New System.Drawing.Size(227, 40)
        Me.cancelbtn.TabIndex = 10
        Me.cancelbtn.Text = "Cancel"
        '
        'recordpreview
        '
        Me.recordpreview.AllowExternalDrop = True
        Me.recordpreview.CreationProperties = Nothing
        Me.recordpreview.DefaultBackgroundColor = System.Drawing.Color.White
        Me.recordpreview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.recordpreview.Location = New System.Drawing.Point(14, 14)
        Me.recordpreview.Name = "recordpreview"
        Me.recordpreview.Size = New System.Drawing.Size(437, 453)
        Me.recordpreview.TabIndex = 0
        Me.recordpreview.ZoomFactor = 1.0R
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(17, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 32)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Update Status"
        '
        'statuscombo
        '
        Me.statuscombo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.statuscombo.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.statuscombo.ColorA = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.statuscombo.ColorB = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.statuscombo.ColorC = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.statuscombo.ColorD = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.statuscombo.ColorE = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.statuscombo.ColorF = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.statuscombo.ColorG = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.statuscombo.ColorH = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.statuscombo.ColorI = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.statuscombo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.statuscombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.statuscombo.DropDownHeight = 400
        Me.statuscombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.statuscombo.Font = New System.Drawing.Font("Nirmala UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.statuscombo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.statuscombo.FormattingEnabled = True
        Me.statuscombo.HoverSelectionColor = System.Drawing.Color.Empty
        Me.statuscombo.IntegralHeight = False
        Me.statuscombo.ItemHeight = 40
        Me.statuscombo.Items.AddRange(New Object() {"test", "test", "test", "test"})
        Me.statuscombo.Location = New System.Drawing.Point(23, 53)
        Me.statuscombo.Name = "statuscombo"
        Me.statuscombo.Size = New System.Drawing.Size(259, 46)
        Me.statuscombo.StartIndex = 0
        Me.statuscombo.TabIndex = 12
        '
        'UpdateStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(511, 677)
        Me.Controls.Add(Me.statuscombo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cancelbtn)
        Me.Controls.Add(Me.updatebtn)
        Me.Controls.Add(Me.MaterialCard1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UpdateStatus"
        Me.ShowIcon = False
        Me.MaterialCard1.ResumeLayout(False)
        CType(Me.recordpreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialCard1 As ReaLTaiizor.Controls.MaterialCard
    Friend WithEvents recordpreview As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents updatebtn As ReaLTaiizor.Controls.FoxButton
    Friend WithEvents cancelbtn As ReaLTaiizor.Controls.FoxButton
    Friend WithEvents Label1 As Label
    Friend WithEvents statuscombo As ReaLTaiizor.Controls.DungeonComboBox
End Class
