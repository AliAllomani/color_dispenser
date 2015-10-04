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
        Me.grid3 = New System.Windows.Forms.DataGridView()
        Me.grid4 = New System.Windows.Forms.DataGridView()
        Me.colorn_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.color_name_id = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.base_name = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.search_btn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.search_txt = New System.Windows.Forms.TextBox()
        Me.quant = New System.Windows.Forms.ComboBox()
        Me.list2 = New System.Windows.Forms.ComboBox()
        Me.list1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.color_type_id = New System.Windows.Forms.Label()
        Me.company_id = New System.Windows.Forms.Label()
        Me.gtclrsbtn = New System.Windows.Forms.Button()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdoText = New System.Windows.Forms.RadioButton()
        Me.rdoHex = New System.Windows.Forms.RadioButton()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmdOpen = New System.Windows.Forms.Button()
        Me.cboPort = New System.Windows.Forms.ComboBox()
        Me.rtbDisplay = New System.Windows.Forms.RichTextBox()
        Me.cmdSend = New System.Windows.Forms.Button()
        Me.txtSend = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.quant_txt = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.color_type_txt = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.grid3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid3
        '
        Me.grid3.AllowUserToAddRows = False
        Me.grid3.AllowUserToDeleteRows = False
        Me.grid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid3.Location = New System.Drawing.Point(12, 144)
        Me.grid3.MultiSelect = False
        Me.grid3.Name = "grid3"
        Me.grid3.ReadOnly = True
        Me.grid3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid3.Size = New System.Drawing.Size(248, 288)
        Me.grid3.TabIndex = 5
        '
        'grid4
        '
        Me.grid4.AllowUserToAddRows = False
        Me.grid4.AllowUserToDeleteRows = False
        Me.grid4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colorn_id, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.grid4.Location = New System.Drawing.Point(266, 61)
        Me.grid4.Name = "grid4"
        Me.grid4.ReadOnly = True
        Me.grid4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid4.Size = New System.Drawing.Size(356, 148)
        Me.grid4.TabIndex = 9
        '
        'colorn_id
        '
        Me.colorn_id.HeaderText = "ID"
        Me.colorn_id.Name = "colorn_id"
        Me.colorn_id.ReadOnly = True
        Me.colorn_id.Width = 43
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Color"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 57
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Value"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 58
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(263, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Color ID :"
        '
        'color_name_id
        '
        Me.color_name_id.AutoSize = True
        Me.color_name_id.Location = New System.Drawing.Point(327, 30)
        Me.color_name_id.Name = "color_name_id"
        Me.color_name_id.Size = New System.Drawing.Size(35, 13)
        Me.color_name_id.TabIndex = 13
        Me.color_name_id.Text = "......."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(518, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Base :"
        '
        'base_name
        '
        Me.base_name.AutoSize = True
        Me.base_name.Location = New System.Drawing.Point(581, 30)
        Me.base_name.Name = "base_name"
        Me.base_name.Size = New System.Drawing.Size(31, 13)
        Me.base_name.TabIndex = 15
        Me.base_name.Text = "......"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.search_btn)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.search_txt)
        Me.GroupBox1.Controls.Add(Me.quant)
        Me.GroupBox1.Controls.Add(Me.list2)
        Me.GroupBox1.Controls.Add(Me.list1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.color_type_id)
        Me.GroupBox1.Controls.Add(Me.company_id)
        Me.GroupBox1.Controls.Add(Me.gtclrsbtn)
        Me.GroupBox1.Location = New System.Drawing.Point(12, -2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 140)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'search_btn
        '
        Me.search_btn.Location = New System.Drawing.Point(112, 112)
        Me.search_btn.Name = "search_btn"
        Me.search_btn.Size = New System.Drawing.Size(51, 23)
        Me.search_btn.TabIndex = 28
        Me.search_btn.Text = "Search"
        Me.search_btn.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Color Code :"
        '
        'search_txt
        '
        Me.search_txt.Location = New System.Drawing.Point(6, 114)
        Me.search_txt.Name = "search_txt"
        Me.search_txt.Size = New System.Drawing.Size(100, 20)
        Me.search_txt.TabIndex = 28
        '
        'quant
        '
        Me.quant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.quant.FormattingEnabled = True
        Me.quant.Items.AddRange(New Object() {"0.9", "3.6", "18.8"})
        Me.quant.Location = New System.Drawing.Point(193, 114)
        Me.quant.Name = "quant"
        Me.quant.Size = New System.Drawing.Size(49, 21)
        Me.quant.TabIndex = 26
        '
        'list2
        '
        Me.list2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.list2.FormattingEnabled = True
        Me.list2.Location = New System.Drawing.Point(6, 74)
        Me.list2.Name = "list2"
        Me.list2.Size = New System.Drawing.Size(141, 21)
        Me.list2.TabIndex = 25
        '
        'list1
        '
        Me.list1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.list1.FormattingEnabled = True
        Me.list1.Location = New System.Drawing.Point(6, 32)
        Me.list1.Name = "list1"
        Me.list1.Size = New System.Drawing.Size(141, 21)
        Me.list1.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Company :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Color Type :"
        '
        'color_type_id
        '
        Me.color_type_id.AutoSize = True
        Me.color_type_id.Location = New System.Drawing.Point(117, 16)
        Me.color_type_id.Name = "color_type_id"
        Me.color_type_id.Size = New System.Drawing.Size(13, 13)
        Me.color_type_id.TabIndex = 21
        Me.color_type_id.Text = "1"
        Me.color_type_id.Visible = False
        '
        'company_id
        '
        Me.company_id.AutoSize = True
        Me.company_id.Location = New System.Drawing.Point(117, 58)
        Me.company_id.Name = "company_id"
        Me.company_id.Size = New System.Drawing.Size(13, 13)
        Me.company_id.TabIndex = 20
        Me.company_id.Text = "5"
        Me.company_id.Visible = False
        '
        'gtclrsbtn
        '
        Me.gtclrsbtn.Location = New System.Drawing.Point(167, 23)
        Me.gtclrsbtn.Name = "gtclrsbtn"
        Me.gtclrsbtn.Size = New System.Drawing.Size(75, 71)
        Me.gtclrsbtn.TabIndex = 19
        Me.gtclrsbtn.Text = "Get Colors"
        Me.gtclrsbtn.UseVisualStyleBackColor = True
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.rdoText)
        Me.groupBox2.Controls.Add(Me.rdoHex)
        Me.groupBox2.Controls.Add(Me.cmdClose)
        Me.groupBox2.Controls.Add(Me.Label9)
        Me.groupBox2.Controls.Add(Me.cmdOpen)
        Me.groupBox2.Controls.Add(Me.cboPort)
        Me.groupBox2.Location = New System.Drawing.Point(266, 215)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(96, 203)
        Me.groupBox2.TabIndex = 17
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Options"
        '
        'rdoText
        '
        Me.rdoText.AutoSize = True
        Me.rdoText.Location = New System.Drawing.Point(6, 147)
        Me.rdoText.Name = "rdoText"
        Me.rdoText.Size = New System.Drawing.Size(47, 17)
        Me.rdoText.TabIndex = 22
        Me.rdoText.TabStop = True
        Me.rdoText.Text = "Text"
        Me.rdoText.UseVisualStyleBackColor = True
        '
        'rdoHex
        '
        Me.rdoHex.AutoSize = True
        Me.rdoHex.Location = New System.Drawing.Point(6, 170)
        Me.rdoHex.Name = "rdoHex"
        Me.rdoHex.Size = New System.Drawing.Size(44, 17)
        Me.rdoHex.TabIndex = 21
        Me.rdoHex.TabStop = True
        Me.rdoHex.Text = "Hex"
        Me.rdoHex.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Enabled = False
        Me.cmdClose.Location = New System.Drawing.Point(6, 104)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(85, 23)
        Me.cmdClose.TabIndex = 23
        Me.cmdClose.Text = "Close Port"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Port"
        '
        'cmdOpen
        '
        Me.cmdOpen.Location = New System.Drawing.Point(6, 75)
        Me.cmdOpen.Name = "cmdOpen"
        Me.cmdOpen.Size = New System.Drawing.Size(85, 23)
        Me.cmdOpen.TabIndex = 24
        Me.cmdOpen.Text = "Open Port"
        Me.cmdOpen.UseVisualStyleBackColor = True
        '
        'cboPort
        '
        Me.cboPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPort.FormattingEnabled = True
        Me.cboPort.Location = New System.Drawing.Point(9, 34)
        Me.cboPort.Name = "cboPort"
        Me.cboPort.Size = New System.Drawing.Size(76, 21)
        Me.cboPort.TabIndex = 10
        '
        'rtbDisplay
        '
        Me.rtbDisplay.Location = New System.Drawing.Point(368, 242)
        Me.rtbDisplay.Name = "rtbDisplay"
        Me.rtbDisplay.Size = New System.Drawing.Size(254, 176)
        Me.rtbDisplay.TabIndex = 18
        Me.rtbDisplay.Text = ""
        '
        'cmdSend
        '
        Me.cmdSend.Enabled = False
        Me.cmdSend.Location = New System.Drawing.Point(545, 213)
        Me.cmdSend.Name = "cmdSend"
        Me.cmdSend.Size = New System.Drawing.Size(75, 23)
        Me.cmdSend.TabIndex = 20
        Me.cmdSend.Text = "Send"
        Me.cmdSend.UseVisualStyleBackColor = True
        '
        'txtSend
        '
        Me.txtSend.Location = New System.Drawing.Point(368, 215)
        Me.txtSend.Name = "txtSend"
        Me.txtSend.Size = New System.Drawing.Size(174, 20)
        Me.txtSend.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(537, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Q :"
        '
        'quant_txt
        '
        Me.quant_txt.AutoSize = True
        Me.quant_txt.Location = New System.Drawing.Point(577, 9)
        Me.quant_txt.Name = "quant_txt"
        Me.quant_txt.Size = New System.Drawing.Size(35, 13)
        Me.quant_txt.TabIndex = 22
        Me.quant_txt.Text = "......."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(263, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Color Type :"
        '
        'color_type_txt
        '
        Me.color_type_txt.AutoSize = True
        Me.color_type_txt.Location = New System.Drawing.Point(342, 9)
        Me.color_type_txt.Name = "color_type_txt"
        Me.color_type_txt.Size = New System.Drawing.Size(35, 13)
        Me.color_type_txt.TabIndex = 24
        Me.color_type_txt.Text = "......."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.despenser.My.Resources.Resources.Untitled
        Me.PictureBox1.Location = New System.Drawing.Point(636, 242)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 430)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.color_type_txt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.quant_txt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmdSend)
        Me.Controls.Add(Me.txtSend)
        Me.Controls.Add(Me.rtbDisplay)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.base_name)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.color_name_id)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.grid4)
        Me.Controls.Add(Me.grid3)
        Me.Name = "Form1"
        Me.Text = "Colorate Despenser"
        CType(Me.grid3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid3 As System.Windows.Forms.DataGridView
    Friend WithEvents grid4 As System.Windows.Forms.DataGridView
    Friend WithEvents colorn_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents color_name_id As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents base_name As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents list2 As System.Windows.Forms.ComboBox
    Friend WithEvents list1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents color_type_id As System.Windows.Forms.Label
    Friend WithEvents company_id As System.Windows.Forms.Label
    Friend WithEvents gtclrsbtn As System.Windows.Forms.Button
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents Label9 As System.Windows.Forms.Label
    Private WithEvents cboPort As System.Windows.Forms.ComboBox
    Private WithEvents rtbDisplay As System.Windows.Forms.RichTextBox
    Private WithEvents cmdSend As System.Windows.Forms.Button
    Private WithEvents txtSend As System.Windows.Forms.TextBox
    Private WithEvents rdoText As System.Windows.Forms.RadioButton
    Private WithEvents rdoHex As System.Windows.Forms.RadioButton
    Private WithEvents cmdClose As System.Windows.Forms.Button
    Private WithEvents cmdOpen As System.Windows.Forms.Button
    Friend WithEvents quant As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents quant_txt As System.Windows.Forms.Label
    Friend WithEvents search_btn As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents search_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents color_type_txt As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
