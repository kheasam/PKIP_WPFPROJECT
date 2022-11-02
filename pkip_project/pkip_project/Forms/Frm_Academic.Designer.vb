<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Academic
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
        Me.Panel_Title = New System.Windows.Forms.Panel()
        Me.Panel_content = New System.Windows.Forms.Panel()
        Me.DGV_DATA = New System.Windows.Forms.DataGridView()
        Me.Txt_ID = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Txt_NameKH = New System.Windows.Forms.TextBox()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Txt_NameEN = New System.Windows.Forms.TextBox()
        Me.IconButton4 = New FontAwesome.Sharp.IconButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Txt_Department = New System.Windows.Forms.TextBox()
        Me.Btn_Save = New FontAwesome.Sharp.IconButton()
        Me.Btn_Edit = New FontAwesome.Sharp.IconButton()
        Me.Btn_Delete = New FontAwesome.Sharp.IconButton()
        Me.Btn_Close = New FontAwesome.Sharp.IconButton()
        Me.Panel_Title.SuspendLayout()
        Me.Panel_content.SuspendLayout()
        CType(Me.DGV_DATA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Title
        '
        Me.Panel_Title.BackColor = System.Drawing.Color.DimGray
        Me.Panel_Title.Controls.Add(Me.Btn_Close)
        Me.Panel_Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Title.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Title.Name = "Panel_Title"
        Me.Panel_Title.Size = New System.Drawing.Size(1100, 35)
        Me.Panel_Title.TabIndex = 0
        '
        'Panel_content
        '
        Me.Panel_content.Controls.Add(Me.Btn_Delete)
        Me.Panel_content.Controls.Add(Me.Btn_Edit)
        Me.Panel_content.Controls.Add(Me.Btn_Save)
        Me.Panel_content.Controls.Add(Me.IconButton4)
        Me.Panel_content.Controls.Add(Me.Panel4)
        Me.Panel_content.Controls.Add(Me.Txt_Department)
        Me.Panel_content.Controls.Add(Me.IconButton3)
        Me.Panel_content.Controls.Add(Me.Panel3)
        Me.Panel_content.Controls.Add(Me.Txt_NameEN)
        Me.Panel_content.Controls.Add(Me.IconButton2)
        Me.Panel_content.Controls.Add(Me.Panel2)
        Me.Panel_content.Controls.Add(Me.Txt_NameKH)
        Me.Panel_content.Controls.Add(Me.IconButton1)
        Me.Panel_content.Controls.Add(Me.Panel1)
        Me.Panel_content.Controls.Add(Me.Txt_ID)
        Me.Panel_content.Controls.Add(Me.DGV_DATA)
        Me.Panel_content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_content.Location = New System.Drawing.Point(0, 35)
        Me.Panel_content.Name = "Panel_content"
        Me.Panel_content.Size = New System.Drawing.Size(1100, 630)
        Me.Panel_content.TabIndex = 1
        '
        'DGV_DATA
        '
        Me.DGV_DATA.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_DATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_DATA.GridColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_DATA.Location = New System.Drawing.Point(3, 3)
        Me.DGV_DATA.Name = "DGV_DATA"
        Me.DGV_DATA.RowHeadersWidth = 51
        Me.DGV_DATA.RowTemplate.Height = 24
        Me.DGV_DATA.Size = New System.Drawing.Size(591, 624)
        Me.DGV_DATA.TabIndex = 0
        '
        'Txt_ID
        '
        Me.Txt_ID.BackColor = System.Drawing.Color.LightCoral
        Me.Txt_ID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_ID.ForeColor = System.Drawing.Color.DimGray
        Me.Txt_ID.Location = New System.Drawing.Point(688, 120)
        Me.Txt_ID.Name = "Txt_ID"
        Me.Txt_ID.Size = New System.Drawing.Size(400, 35)
        Me.Txt_ID.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Location = New System.Drawing.Point(651, 159)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(440, 3)
        Me.Panel1.TabIndex = 2
        '
        'IconButton1
        '
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.ListUl
        Me.IconButton1.IconColor = System.Drawing.Color.DimGray
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 35
        Me.IconButton1.Location = New System.Drawing.Point(647, 124)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(35, 35)
        Me.IconButton1.TabIndex = 3
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'IconButton2
        '
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        Me.IconButton2.IconColor = System.Drawing.Color.DimGray
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 35
        Me.IconButton2.Location = New System.Drawing.Point(644, 211)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(35, 35)
        Me.IconButton2.TabIndex = 6
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Location = New System.Drawing.Point(648, 246)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(440, 3)
        Me.Panel2.TabIndex = 5
        '
        'Txt_NameKH
        '
        Me.Txt_NameKH.BackColor = System.Drawing.Color.LightCoral
        Me.Txt_NameKH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_NameKH.ForeColor = System.Drawing.Color.DimGray
        Me.Txt_NameKH.Location = New System.Drawing.Point(685, 207)
        Me.Txt_NameKH.Name = "Txt_NameKH"
        Me.Txt_NameKH.Size = New System.Drawing.Size(400, 35)
        Me.Txt_NameKH.TabIndex = 4
        '
        'IconButton3
        '
        Me.IconButton3.FlatAppearance.BorderSize = 0
        Me.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.UserCog
        Me.IconButton3.IconColor = System.Drawing.Color.DimGray
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.IconSize = 35
        Me.IconButton3.Location = New System.Drawing.Point(647, 301)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Size = New System.Drawing.Size(35, 35)
        Me.IconButton3.TabIndex = 9
        Me.IconButton3.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DimGray
        Me.Panel3.Location = New System.Drawing.Point(651, 336)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(440, 3)
        Me.Panel3.TabIndex = 8
        '
        'Txt_NameEN
        '
        Me.Txt_NameEN.BackColor = System.Drawing.Color.LightCoral
        Me.Txt_NameEN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_NameEN.ForeColor = System.Drawing.Color.DimGray
        Me.Txt_NameEN.Location = New System.Drawing.Point(688, 297)
        Me.Txt_NameEN.Name = "Txt_NameEN"
        Me.Txt_NameEN.Size = New System.Drawing.Size(400, 35)
        Me.Txt_NameEN.TabIndex = 7
        '
        'IconButton4
        '
        Me.IconButton4.FlatAppearance.BorderSize = 0
        Me.IconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton4.IconChar = FontAwesome.Sharp.IconChar.Building
        Me.IconButton4.IconColor = System.Drawing.Color.DimGray
        Me.IconButton4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton4.IconSize = 35
        Me.IconButton4.Location = New System.Drawing.Point(647, 391)
        Me.IconButton4.Name = "IconButton4"
        Me.IconButton4.Size = New System.Drawing.Size(35, 35)
        Me.IconButton4.TabIndex = 12
        Me.IconButton4.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DimGray
        Me.Panel4.Location = New System.Drawing.Point(651, 426)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(440, 3)
        Me.Panel4.TabIndex = 11
        '
        'Txt_Department
        '
        Me.Txt_Department.BackColor = System.Drawing.Color.LightCoral
        Me.Txt_Department.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_Department.ForeColor = System.Drawing.Color.DimGray
        Me.Txt_Department.Location = New System.Drawing.Point(688, 387)
        Me.Txt_Department.Name = "Txt_Department"
        Me.Txt_Department.Size = New System.Drawing.Size(400, 35)
        Me.Txt_Department.TabIndex = 10
        '
        'Btn_Save
        '
        Me.Btn_Save.FlatAppearance.BorderSize = 0
        Me.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Save.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_Save.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.Btn_Save.IconColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_Save.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Save.IconSize = 35
        Me.Btn_Save.Location = New System.Drawing.Point(670, 537)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(135, 44)
        Me.Btn_Save.TabIndex = 13
        Me.Btn_Save.Text = "រក្សាទុក"
        Me.Btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Save.UseVisualStyleBackColor = True
        '
        'Btn_Edit
        '
        Me.Btn_Edit.BackColor = System.Drawing.Color.LightCoral
        Me.Btn_Edit.FlatAppearance.BorderSize = 0
        Me.Btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Edit.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_Edit.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.Btn_Edit.IconColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_Edit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Edit.IconSize = 35
        Me.Btn_Edit.Location = New System.Drawing.Point(811, 537)
        Me.Btn_Edit.Name = "Btn_Edit"
        Me.Btn_Edit.Size = New System.Drawing.Size(132, 44)
        Me.Btn_Edit.TabIndex = 14
        Me.Btn_Edit.Text = "កែប្រែ"
        Me.Btn_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Edit.UseVisualStyleBackColor = False
        '
        'Btn_Delete
        '
        Me.Btn_Delete.BackColor = System.Drawing.Color.LightCoral
        Me.Btn_Delete.FlatAppearance.BorderSize = 0
        Me.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Delete.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_Delete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.Btn_Delete.IconColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_Delete.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Delete.IconSize = 35
        Me.Btn_Delete.Location = New System.Drawing.Point(949, 537)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Size = New System.Drawing.Size(93, 44)
        Me.Btn_Delete.TabIndex = 15
        Me.Btn_Delete.Text = "លុប"
        Me.Btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Delete.UseVisualStyleBackColor = False
        '
        'Btn_Close
        '
        Me.Btn_Close.FlatAppearance.BorderSize = 0
        Me.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Close.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.Btn_Close.IconColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_Close.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Close.IconSize = 35
        Me.Btn_Close.Location = New System.Drawing.Point(1062, 0)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(35, 35)
        Me.Btn_Close.TabIndex = 16
        Me.Btn_Close.UseVisualStyleBackColor = True
        '
        'Frm_Academic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 34.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(1100, 665)
        Me.Controls.Add(Me.Panel_content)
        Me.Controls.Add(Me.Panel_Title)
        Me.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Frm_Academic"
        Me.Text = "Frm_Academic"
        Me.Panel_Title.ResumeLayout(False)
        Me.Panel_content.ResumeLayout(False)
        Me.Panel_content.PerformLayout()
        CType(Me.DGV_DATA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Title As Panel
    Friend WithEvents Btn_Close As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel_content As Panel
    Friend WithEvents Btn_Delete As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Edit As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Save As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Txt_Department As TextBox
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Txt_NameEN As TextBox
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Txt_NameKH As TextBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Txt_ID As TextBox
    Friend WithEvents DGV_DATA As DataGridView
End Class
