<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Info
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
        Me.Panel_title = New System.Windows.Forms.Panel()
        Me.title = New FontAwesome.Sharp.IconButton()
        Me.btn_Close = New FontAwesome.Sharp.IconButton()
        Me.Icon_password = New FontAwesome.Sharp.IconButton()
        Me.Panel_password = New System.Windows.Forms.Panel()
        Me.txt_nameen = New System.Windows.Forms.TextBox()
        Me.Icon_user = New FontAwesome.Sharp.IconButton()
        Me.Panel_user = New System.Windows.Forms.Panel()
        Me.txt_namkh = New System.Windows.Forms.TextBox()
        Me.Icon_id = New FontAwesome.Sharp.IconButton()
        Me.Panel_id = New System.Windows.Forms.Panel()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.btn_save = New FontAwesome.Sharp.IconButton()
        Me.Btn_Brows = New FontAwesome.Sharp.IconButton()
        Me.Btn_Remove = New FontAwesome.Sharp.IconButton()
        Me.Panel_title.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel_title.Size = New System.Drawing.Size(900, 35)
        Me.Panel_title.TabIndex = 3
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
        Me.title.Text = "ពត៌មានអំពីកម្មវិធី"
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
        Me.btn_Close.Location = New System.Drawing.Point(862, 0)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(35, 35)
        Me.btn_Close.TabIndex = 15
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'Icon_password
        '
        Me.Icon_password.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Icon_password.FlatAppearance.BorderSize = 0
        Me.Icon_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Icon_password.IconChar = FontAwesome.Sharp.IconChar.Building
        Me.Icon_password.IconColor = System.Drawing.Color.Brown
        Me.Icon_password.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Icon_password.IconSize = 40
        Me.Icon_password.Location = New System.Drawing.Point(388, 250)
        Me.Icon_password.Name = "Icon_password"
        Me.Icon_password.Size = New System.Drawing.Size(40, 40)
        Me.Icon_password.TabIndex = 24
        Me.Icon_password.UseVisualStyleBackColor = True
        '
        'Panel_password
        '
        Me.Panel_password.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_password.BackColor = System.Drawing.Color.Brown
        Me.Panel_password.Location = New System.Drawing.Point(392, 291)
        Me.Panel_password.Name = "Panel_password"
        Me.Panel_password.Size = New System.Drawing.Size(470, 3)
        Me.Panel_password.TabIndex = 23
        '
        'txt_nameen
        '
        Me.txt_nameen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_nameen.BackColor = System.Drawing.Color.MistyRose
        Me.txt_nameen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nameen.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.8!)
        Me.txt_nameen.ForeColor = System.Drawing.Color.Brown
        Me.txt_nameen.Location = New System.Drawing.Point(438, 247)
        Me.txt_nameen.Name = "txt_nameen"
        Me.txt_nameen.Size = New System.Drawing.Size(425, 39)
        Me.txt_nameen.TabIndex = 22
        '
        'Icon_user
        '
        Me.Icon_user.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Icon_user.FlatAppearance.BorderSize = 0
        Me.Icon_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Icon_user.IconChar = FontAwesome.Sharp.IconChar.Building
        Me.Icon_user.IconColor = System.Drawing.Color.Brown
        Me.Icon_user.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Icon_user.IconSize = 40
        Me.Icon_user.Location = New System.Drawing.Point(387, 165)
        Me.Icon_user.Name = "Icon_user"
        Me.Icon_user.Size = New System.Drawing.Size(40, 40)
        Me.Icon_user.TabIndex = 21
        Me.Icon_user.UseVisualStyleBackColor = True
        '
        'Panel_user
        '
        Me.Panel_user.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_user.BackColor = System.Drawing.Color.Brown
        Me.Panel_user.Location = New System.Drawing.Point(392, 206)
        Me.Panel_user.Name = "Panel_user"
        Me.Panel_user.Size = New System.Drawing.Size(470, 3)
        Me.Panel_user.TabIndex = 20
        '
        'txt_namkh
        '
        Me.txt_namkh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_namkh.BackColor = System.Drawing.Color.MistyRose
        Me.txt_namkh.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_namkh.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.8!)
        Me.txt_namkh.ForeColor = System.Drawing.Color.Brown
        Me.txt_namkh.Location = New System.Drawing.Point(438, 162)
        Me.txt_namkh.Name = "txt_namkh"
        Me.txt_namkh.Size = New System.Drawing.Size(425, 39)
        Me.txt_namkh.TabIndex = 19
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
        Me.Icon_id.Location = New System.Drawing.Point(386, 80)
        Me.Icon_id.Name = "Icon_id"
        Me.Icon_id.Size = New System.Drawing.Size(40, 40)
        Me.Icon_id.TabIndex = 18
        Me.Icon_id.UseVisualStyleBackColor = True
        '
        'Panel_id
        '
        Me.Panel_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_id.BackColor = System.Drawing.Color.Brown
        Me.Panel_id.Location = New System.Drawing.Point(392, 121)
        Me.Panel_id.Name = "Panel_id"
        Me.Panel_id.Size = New System.Drawing.Size(470, 3)
        Me.Panel_id.TabIndex = 17
        '
        'txt_id
        '
        Me.txt_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_id.BackColor = System.Drawing.Color.MistyRose
        Me.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_id.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.8!)
        Me.txt_id.ForeColor = System.Drawing.Color.Brown
        Me.txt_id.Location = New System.Drawing.Point(438, 77)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(425, 39)
        Me.txt_id.TabIndex = 16
        '
        'IconButton1
        '
        Me.IconButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.ListUl
        Me.IconButton1.IconColor = System.Drawing.Color.Brown
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 40
        Me.IconButton1.Location = New System.Drawing.Point(388, 347)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(40, 40)
        Me.IconButton1.TabIndex = 27
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Brown
        Me.Panel1.Location = New System.Drawing.Point(392, 388)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(470, 3)
        Me.Panel1.TabIndex = 26
        '
        'txt_address
        '
        Me.txt_address.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_address.BackColor = System.Drawing.Color.MistyRose
        Me.txt_address.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_address.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.8!)
        Me.txt_address.ForeColor = System.Drawing.Color.Brown
        Me.txt_address.Location = New System.Drawing.Point(438, 344)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(425, 39)
        Me.txt_address.TabIndex = 25
        '
        'logo
        '
        Me.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.logo.Location = New System.Drawing.Point(29, 66)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(300, 300)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logo.TabIndex = 28
        Me.logo.TabStop = False
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
        Me.btn_save.Location = New System.Drawing.Point(436, 425)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(130, 40)
        Me.btn_save.TabIndex = 29
        Me.btn_save.Text = "រក្សាទុក"
        Me.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'Btn_Brows
        '
        Me.Btn_Brows.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Brows.FlatAppearance.BorderSize = 0
        Me.Btn_Brows.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Brows.ForeColor = System.Drawing.Color.Brown
        Me.Btn_Brows.IconChar = FontAwesome.Sharp.IconChar.Upload
        Me.Btn_Brows.IconColor = System.Drawing.Color.Brown
        Me.Btn_Brows.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Brows.IconSize = 40
        Me.Btn_Brows.Location = New System.Drawing.Point(29, 372)
        Me.Btn_Brows.Name = "Btn_Brows"
        Me.Btn_Brows.Size = New System.Drawing.Size(163, 40)
        Me.Btn_Brows.TabIndex = 30
        Me.Btn_Brows.Text = "ទាញរូបភាព"
        Me.Btn_Brows.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Brows.UseVisualStyleBackColor = True
        '
        'Btn_Remove
        '
        Me.Btn_Remove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Remove.FlatAppearance.BorderSize = 0
        Me.Btn_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Remove.ForeColor = System.Drawing.Color.Brown
        Me.Btn_Remove.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.Btn_Remove.IconColor = System.Drawing.Color.Brown
        Me.Btn_Remove.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Remove.IconSize = 40
        Me.Btn_Remove.Location = New System.Drawing.Point(183, 372)
        Me.Btn_Remove.Name = "Btn_Remove"
        Me.Btn_Remove.Size = New System.Drawing.Size(170, 40)
        Me.Btn_Remove.TabIndex = 31
        Me.Btn_Remove.Text = "សំអាតរូបភាព"
        Me.Btn_Remove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Remove.UseVisualStyleBackColor = True
        '
        'Frm_Info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 33.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(900, 500)
        Me.Controls.Add(Me.Btn_Remove)
        Me.Controls.Add(Me.Btn_Brows)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_address)
        Me.Controls.Add(Me.Icon_password)
        Me.Controls.Add(Me.Panel_title)
        Me.Controls.Add(Me.Panel_password)
        Me.Controls.Add(Me.txt_nameen)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Icon_user)
        Me.Controls.Add(Me.Panel_id)
        Me.Controls.Add(Me.Panel_user)
        Me.Controls.Add(Me.Icon_id)
        Me.Controls.Add(Me.txt_namkh)
        Me.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "Frm_Info"
        Me.Text = "Frm_Info"
        Me.Panel_title.ResumeLayout(False)
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel_title As Panel
    Friend WithEvents title As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_Close As FontAwesome.Sharp.IconButton
    Friend WithEvents Icon_password As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel_password As Panel
    Friend WithEvents txt_nameen As TextBox
    Friend WithEvents Icon_user As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel_user As Panel
    Friend WithEvents txt_namkh As TextBox
    Friend WithEvents Icon_id As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel_id As Panel
    Friend WithEvents txt_id As TextBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_address As TextBox
    Friend WithEvents logo As PictureBox
    Friend WithEvents btn_save As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Brows As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Remove As FontAwesome.Sharp.IconButton
End Class
