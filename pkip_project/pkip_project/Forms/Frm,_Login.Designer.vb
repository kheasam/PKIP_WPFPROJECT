<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm__Register
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
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Icon_user = New FontAwesome.Sharp.IconButton()
        Me.Panel_user = New System.Windows.Forms.Panel()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.logo = New FontAwesome.Sharp.IconPictureBox()
        Me.btn_cancel = New FontAwesome.Sharp.IconButton()
        Me.btn_login = New FontAwesome.Sharp.IconButton()
        Me.Icon_password = New FontAwesome.Sharp.IconButton()
        Me.Panel_password = New System.Windows.Forms.Panel()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IconButton1
        '
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.IconButton1.IconColor = System.Drawing.Color.Brown
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 35
        Me.IconButton1.Location = New System.Drawing.Point(658, 4)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(35, 35)
        Me.IconButton1.TabIndex = 16
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'Icon_user
        '
        Me.Icon_user.FlatAppearance.BorderSize = 0
        Me.Icon_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Icon_user.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        Me.Icon_user.IconColor = System.Drawing.Color.Brown
        Me.Icon_user.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Icon_user.IconSize = 40
        Me.Icon_user.Location = New System.Drawing.Point(315, 82)
        Me.Icon_user.Name = "Icon_user"
        Me.Icon_user.Size = New System.Drawing.Size(40, 40)
        Me.Icon_user.TabIndex = 22
        Me.Icon_user.UseVisualStyleBackColor = True
        '
        'Panel_user
        '
        Me.Panel_user.BackColor = System.Drawing.Color.Brown
        Me.Panel_user.Location = New System.Drawing.Point(315, 123)
        Me.Panel_user.Name = "Panel_user"
        Me.Panel_user.Size = New System.Drawing.Size(329, 3)
        Me.Panel_user.TabIndex = 21
        '
        'txt_username
        '
        Me.txt_username.BackColor = System.Drawing.Color.MistyRose
        Me.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_username.ForeColor = System.Drawing.Color.Brown
        Me.txt_username.Location = New System.Drawing.Point(356, 84)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(289, 37)
        Me.txt_username.TabIndex = 20
        '
        'logo
        '
        Me.logo.BackColor = System.Drawing.Color.MistyRose
        Me.logo.ForeColor = System.Drawing.Color.Brown
        Me.logo.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.logo.IconColor = System.Drawing.Color.Brown
        Me.logo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.logo.IconSize = 200
        Me.logo.Location = New System.Drawing.Point(25, 68)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(200, 200)
        Me.logo.TabIndex = 23
        Me.logo.TabStop = False
        '
        'btn_cancel
        '
        Me.btn_cancel.FlatAppearance.BorderSize = 0
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.ForeColor = System.Drawing.Color.Brown
        Me.btn_cancel.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.btn_cancel.IconColor = System.Drawing.Color.Brown
        Me.btn_cancel.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_cancel.IconSize = 40
        Me.btn_cancel.Location = New System.Drawing.Point(458, 280)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(151, 40)
        Me.btn_cancel.TabIndex = 25
        Me.btn_cancel.Text = "ចាកចេញ"
        Me.btn_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_login
        '
        Me.btn_login.FlatAppearance.BorderSize = 0
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.ForeColor = System.Drawing.Color.Brown
        Me.btn_login.IconChar = FontAwesome.Sharp.IconChar.SignInAlt
        Me.btn_login.IconColor = System.Drawing.Color.Brown
        Me.btn_login.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_login.IconSize = 40
        Me.btn_login.Location = New System.Drawing.Point(322, 280)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(151, 40)
        Me.btn_login.TabIndex = 24
        Me.btn_login.Text = "ចូលប្រើ"
        Me.btn_login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'Icon_password
        '
        Me.Icon_password.FlatAppearance.BorderSize = 0
        Me.Icon_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Icon_password.IconChar = FontAwesome.Sharp.IconChar.Lock
        Me.Icon_password.IconColor = System.Drawing.Color.Brown
        Me.Icon_password.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Icon_password.IconSize = 40
        Me.Icon_password.Location = New System.Drawing.Point(315, 170)
        Me.Icon_password.Name = "Icon_password"
        Me.Icon_password.Size = New System.Drawing.Size(40, 40)
        Me.Icon_password.TabIndex = 28
        Me.Icon_password.UseVisualStyleBackColor = True
        '
        'Panel_password
        '
        Me.Panel_password.BackColor = System.Drawing.Color.Brown
        Me.Panel_password.Location = New System.Drawing.Point(315, 211)
        Me.Panel_password.Name = "Panel_password"
        Me.Panel_password.Size = New System.Drawing.Size(328, 3)
        Me.Panel_password.TabIndex = 27
        '
        'txt_password
        '
        Me.txt_password.BackColor = System.Drawing.Color.MistyRose
        Me.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_password.ForeColor = System.Drawing.Color.Brown
        Me.txt_password.Location = New System.Drawing.Point(356, 172)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(288, 37)
        Me.txt_password.TabIndex = 26
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(280, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(3, 383)
        Me.Panel1.TabIndex = 29
        '
        'Frm__Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 36.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(700, 400)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Icon_password)
        Me.Controls.Add(Me.Panel_password)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.Icon_user)
        Me.Controls.Add(Me.Panel_user)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.IconButton1)
        Me.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.8!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "Frm__Register"
        Me.Text = "Frm__Register"
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Icon_user As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel_user As Panel
    Friend WithEvents txt_username As TextBox
    Friend WithEvents logo As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btn_cancel As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_login As FontAwesome.Sharp.IconButton
    Friend WithEvents Icon_password As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel_password As Panel
    Friend WithEvents txt_password As TextBox
    Friend WithEvents Panel1 As Panel
End Class
