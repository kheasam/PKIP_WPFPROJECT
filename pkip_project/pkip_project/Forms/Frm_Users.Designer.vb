<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Users
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel_title = New System.Windows.Forms.Panel()
        Me.title = New FontAwesome.Sharp.IconButton()
        Me.btn_Close = New FontAwesome.Sharp.IconButton()
        Me.Panel_left = New System.Windows.Forms.Panel()
        Me.dgv_data = New System.Windows.Forms.DataGridView()
        Me.Panel_content = New System.Windows.Forms.Panel()
        Me.btn_delete = New FontAwesome.Sharp.IconButton()
        Me.btn_edit = New FontAwesome.Sharp.IconButton()
        Me.btn_save = New FontAwesome.Sharp.IconButton()
        Me.Icon_role = New FontAwesome.Sharp.IconButton()
        Me.Panel_role = New System.Windows.Forms.Panel()
        Me.Icon_password = New FontAwesome.Sharp.IconButton()
        Me.Panel_password = New System.Windows.Forms.Panel()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.Icon_user = New FontAwesome.Sharp.IconButton()
        Me.Panel_user = New System.Windows.Forms.Panel()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.Icon_id = New FontAwesome.Sharp.IconButton()
        Me.Panel_id = New System.Windows.Forms.Panel()
        Me.cmb_role = New System.Windows.Forms.ComboBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Panel_title.SuspendLayout()
        Me.Panel_left.SuspendLayout()
        CType(Me.dgv_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_content.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_title
        '
        Me.Panel_title.BackColor = System.Drawing.Color.LightGray
        Me.Panel_title.Controls.Add(Me.title)
        Me.Panel_title.Controls.Add(Me.btn_Close)
        Me.Panel_title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_title.Location = New System.Drawing.Point(0, 0)
        Me.Panel_title.Name = "Panel_title"
        Me.Panel_title.Size = New System.Drawing.Size(1100, 35)
        Me.Panel_title.TabIndex = 2
        '
        'title
        '
        Me.title.FlatAppearance.BorderSize = 0
        Me.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.title.Font = New System.Drawing.Font("Khmer OS Siemreap", 9.8!)
        Me.title.ForeColor = System.Drawing.Color.Brown
        Me.title.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.title.IconColor = System.Drawing.Color.Brown
        Me.title.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.title.IconSize = 35
        Me.title.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.title.Location = New System.Drawing.Point(0, 0)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(311, 40)
        Me.title.TabIndex = 15
        Me.title.Text = "បង្កើតគណនីថ្មី"
        Me.title.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.title.UseVisualStyleBackColor = True
        '
        'btn_Close
        '
        Me.btn_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Close.FlatAppearance.BorderSize = 0
        Me.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Close.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.btn_Close.IconColor = System.Drawing.Color.Brown
        Me.btn_Close.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_Close.IconSize = 35
        Me.btn_Close.Location = New System.Drawing.Point(1062, 0)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(35, 35)
        Me.btn_Close.TabIndex = 15
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'Panel_left
        '
        Me.Panel_left.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_left.Controls.Add(Me.dgv_data)
        Me.Panel_left.Location = New System.Drawing.Point(0, 35)
        Me.Panel_left.Name = "Panel_left"
        Me.Panel_left.Size = New System.Drawing.Size(550, 630)
        Me.Panel_left.TabIndex = 2
        '
        'dgv_data
        '
        Me.dgv_data.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_data.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Khmer OS Siemreap", 10.8!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Brown
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_data.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_data.Location = New System.Drawing.Point(3, 3)
        Me.dgv_data.MultiSelect = False
        Me.dgv_data.Name = "dgv_data"
        Me.dgv_data.ReadOnly = True
        Me.dgv_data.RowHeadersVisible = False
        Me.dgv_data.RowHeadersWidth = 51
        Me.dgv_data.RowTemplate.Height = 24
        Me.dgv_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_data.Size = New System.Drawing.Size(544, 624)
        Me.dgv_data.TabIndex = 0
        '
        'Panel_content
        '
        Me.Panel_content.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_content.Controls.Add(Me.btn_delete)
        Me.Panel_content.Controls.Add(Me.btn_edit)
        Me.Panel_content.Controls.Add(Me.btn_save)
        Me.Panel_content.Controls.Add(Me.Icon_role)
        Me.Panel_content.Controls.Add(Me.Panel_role)
        Me.Panel_content.Controls.Add(Me.Icon_password)
        Me.Panel_content.Controls.Add(Me.Panel_password)
        Me.Panel_content.Controls.Add(Me.txt_password)
        Me.Panel_content.Controls.Add(Me.Icon_user)
        Me.Panel_content.Controls.Add(Me.Panel_user)
        Me.Panel_content.Controls.Add(Me.txt_username)
        Me.Panel_content.Controls.Add(Me.Icon_id)
        Me.Panel_content.Controls.Add(Me.Panel_id)
        Me.Panel_content.Controls.Add(Me.cmb_role)
        Me.Panel_content.Controls.Add(Me.txt_id)
        Me.Panel_content.Location = New System.Drawing.Point(556, 35)
        Me.Panel_content.Name = "Panel_content"
        Me.Panel_content.Size = New System.Drawing.Size(544, 630)
        Me.Panel_content.TabIndex = 3
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_delete.FlatAppearance.BorderSize = 0
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.ForeColor = System.Drawing.Color.Brown
        Me.btn_delete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.btn_delete.IconColor = System.Drawing.Color.Brown
        Me.btn_delete.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_delete.IconSize = 40
        Me.btn_delete.Location = New System.Drawing.Point(362, 509)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(151, 40)
        Me.btn_delete.TabIndex = 14
        Me.btn_delete.Text = "លុប"
        Me.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_edit.FlatAppearance.BorderSize = 0
        Me.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit.ForeColor = System.Drawing.Color.Brown
        Me.btn_edit.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.btn_edit.IconColor = System.Drawing.Color.Brown
        Me.btn_edit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_edit.IconSize = 40
        Me.btn_edit.Location = New System.Drawing.Point(205, 509)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(151, 40)
        Me.btn_edit.TabIndex = 13
        Me.btn_edit.Text = "កែប្រែ"
        Me.btn_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save.FlatAppearance.BorderSize = 0
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.ForeColor = System.Drawing.Color.Brown
        Me.btn_save.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.btn_save.IconColor = System.Drawing.Color.Brown
        Me.btn_save.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_save.IconSize = 40
        Me.btn_save.Location = New System.Drawing.Point(69, 509)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(130, 40)
        Me.btn_save.TabIndex = 12
        Me.btn_save.Text = "រក្សាទុក"
        Me.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'Icon_role
        '
        Me.Icon_role.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Icon_role.FlatAppearance.BorderSize = 0
        Me.Icon_role.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Icon_role.IconChar = FontAwesome.Sharp.IconChar.UserShield
        Me.Icon_role.IconColor = System.Drawing.Color.Brown
        Me.Icon_role.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Icon_role.Location = New System.Drawing.Point(53, 381)
        Me.Icon_role.Name = "Icon_role"
        Me.Icon_role.Size = New System.Drawing.Size(40, 40)
        Me.Icon_role.TabIndex = 11
        Me.Icon_role.UseVisualStyleBackColor = True
        '
        'Panel_role
        '
        Me.Panel_role.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_role.BackColor = System.Drawing.Color.Brown
        Me.Panel_role.Location = New System.Drawing.Point(53, 422)
        Me.Panel_role.Name = "Panel_role"
        Me.Panel_role.Size = New System.Drawing.Size(470, 3)
        Me.Panel_role.TabIndex = 10
        '
        'Icon_password
        '
        Me.Icon_password.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Icon_password.FlatAppearance.BorderSize = 0
        Me.Icon_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Icon_password.IconChar = FontAwesome.Sharp.IconChar.Lock
        Me.Icon_password.IconColor = System.Drawing.Color.Brown
        Me.Icon_password.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Icon_password.IconSize = 40
        Me.Icon_password.Location = New System.Drawing.Point(49, 260)
        Me.Icon_password.Name = "Icon_password"
        Me.Icon_password.Size = New System.Drawing.Size(40, 40)
        Me.Icon_password.TabIndex = 9
        Me.Icon_password.UseVisualStyleBackColor = True
        '
        'Panel_password
        '
        Me.Panel_password.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_password.BackColor = System.Drawing.Color.Brown
        Me.Panel_password.Location = New System.Drawing.Point(53, 301)
        Me.Panel_password.Name = "Panel_password"
        Me.Panel_password.Size = New System.Drawing.Size(470, 3)
        Me.Panel_password.TabIndex = 8
        '
        'txt_password
        '
        Me.txt_password.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_password.BackColor = System.Drawing.Color.MistyRose
        Me.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_password.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.8!)
        Me.txt_password.ForeColor = System.Drawing.Color.Brown
        Me.txt_password.Location = New System.Drawing.Point(99, 257)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(425, 39)
        Me.txt_password.TabIndex = 7
        '
        'Icon_user
        '
        Me.Icon_user.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Icon_user.FlatAppearance.BorderSize = 0
        Me.Icon_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Icon_user.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        Me.Icon_user.IconColor = System.Drawing.Color.Brown
        Me.Icon_user.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Icon_user.IconSize = 40
        Me.Icon_user.Location = New System.Drawing.Point(48, 152)
        Me.Icon_user.Name = "Icon_user"
        Me.Icon_user.Size = New System.Drawing.Size(40, 40)
        Me.Icon_user.TabIndex = 6
        Me.Icon_user.UseVisualStyleBackColor = True
        '
        'Panel_user
        '
        Me.Panel_user.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_user.BackColor = System.Drawing.Color.Brown
        Me.Panel_user.Location = New System.Drawing.Point(53, 193)
        Me.Panel_user.Name = "Panel_user"
        Me.Panel_user.Size = New System.Drawing.Size(470, 3)
        Me.Panel_user.TabIndex = 5
        '
        'txt_username
        '
        Me.txt_username.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_username.BackColor = System.Drawing.Color.MistyRose
        Me.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_username.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.8!)
        Me.txt_username.ForeColor = System.Drawing.Color.Brown
        Me.txt_username.Location = New System.Drawing.Point(99, 149)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(425, 39)
        Me.txt_username.TabIndex = 4
        '
        'Icon_id
        '
        Me.Icon_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Icon_id.FlatAppearance.BorderSize = 0
        Me.Icon_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Icon_id.IconChar = FontAwesome.Sharp.IconChar.AddressCard
        Me.Icon_id.IconColor = System.Drawing.Color.Brown
        Me.Icon_id.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Icon_id.IconSize = 40
        Me.Icon_id.Location = New System.Drawing.Point(47, 40)
        Me.Icon_id.Name = "Icon_id"
        Me.Icon_id.Size = New System.Drawing.Size(40, 40)
        Me.Icon_id.TabIndex = 3
        Me.Icon_id.UseVisualStyleBackColor = True
        '
        'Panel_id
        '
        Me.Panel_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_id.BackColor = System.Drawing.Color.Brown
        Me.Panel_id.Location = New System.Drawing.Point(53, 81)
        Me.Panel_id.Name = "Panel_id"
        Me.Panel_id.Size = New System.Drawing.Size(470, 3)
        Me.Panel_id.TabIndex = 2
        '
        'cmb_role
        '
        Me.cmb_role.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_role.BackColor = System.Drawing.Color.MistyRose
        Me.cmb_role.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_role.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.8!)
        Me.cmb_role.FormattingEnabled = True
        Me.cmb_role.Location = New System.Drawing.Point(99, 375)
        Me.cmb_role.Name = "cmb_role"
        Me.cmb_role.Size = New System.Drawing.Size(424, 46)
        Me.cmb_role.TabIndex = 1
        '
        'txt_id
        '
        Me.txt_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_id.BackColor = System.Drawing.Color.MistyRose
        Me.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_id.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.8!)
        Me.txt_id.ForeColor = System.Drawing.Color.Brown
        Me.txt_id.Location = New System.Drawing.Point(99, 37)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(425, 39)
        Me.txt_id.TabIndex = 0
        '
        'Frm_Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 33.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(1100, 665)
        Me.Controls.Add(Me.Panel_content)
        Me.Controls.Add(Me.Panel_left)
        Me.Controls.Add(Me.Panel_title)
        Me.Font = New System.Drawing.Font("Khmer OS Siemreap", 10.8!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "Frm_Users"
        Me.Text = "Frm_Users"
        Me.Panel_title.ResumeLayout(False)
        Me.Panel_left.ResumeLayout(False)
        CType(Me.dgv_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_content.ResumeLayout(False)
        Me.Panel_content.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_title As Panel
    Friend WithEvents title As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_Close As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel_left As Panel
    Friend WithEvents dgv_data As DataGridView
    Friend WithEvents Panel_content As Panel
    Friend WithEvents btn_delete As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_edit As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_save As FontAwesome.Sharp.IconButton
    Friend WithEvents Icon_role As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel_role As Panel
    Friend WithEvents Icon_password As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel_password As Panel
    Friend WithEvents txt_password As TextBox
    Friend WithEvents Icon_user As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel_user As Panel
    Friend WithEvents txt_username As TextBox
    Friend WithEvents Icon_id As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel_id As Panel
    Friend WithEvents cmb_role As ComboBox
    Friend WithEvents txt_id As TextBox
End Class
