﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Specialty
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
        Me.Panel_DEP = New System.Windows.Forms.Panel()
        Me.Cmb_Department = New System.Windows.Forms.ComboBox()
        Me.Panel_NAMEEN = New System.Windows.Forms.Panel()
        Me.Txt_NameEN = New System.Windows.Forms.TextBox()
        Me.Panel_NAMEKH = New System.Windows.Forms.Panel()
        Me.Txt_NameKH = New System.Windows.Forms.TextBox()
        Me.Txt_ID = New System.Windows.Forms.TextBox()
        Me.DGV_Data = New System.Windows.Forms.DataGridView()
        Me.Panel_Title = New System.Windows.Forms.Panel()
        Me.Panel_ID = New System.Windows.Forms.Panel()
        Me.Panel_Content = New System.Windows.Forms.Panel()
        Me.Btn_Close = New FontAwesome.Sharp.IconButton()
        Me.Btn_Delete = New FontAwesome.Sharp.IconButton()
        Me.Btn_Update = New FontAwesome.Sharp.IconButton()
        Me.Btn_Save = New FontAwesome.Sharp.IconButton()
        Me.BTN_DEP = New FontAwesome.Sharp.IconButton()
        Me.BTN_NAMEEN = New FontAwesome.Sharp.IconButton()
        Me.BTN_NAMEKH = New FontAwesome.Sharp.IconButton()
        Me.BTN_ID = New FontAwesome.Sharp.IconButton()
        CType(Me.DGV_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Title.SuspendLayout()
        Me.Panel_Content.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_DEP
        '
        Me.Panel_DEP.BackColor = System.Drawing.Color.Maroon
        Me.Panel_DEP.Location = New System.Drawing.Point(605, 428)
        Me.Panel_DEP.Name = "Panel_DEP"
        Me.Panel_DEP.Size = New System.Drawing.Size(490, 3)
        Me.Panel_DEP.TabIndex = 12
        '
        'Cmb_Department
        '
        Me.Cmb_Department.BackColor = System.Drawing.Color.SeaShell
        Me.Cmb_Department.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmb_Department.FormattingEnabled = True
        Me.Cmb_Department.Location = New System.Drawing.Point(644, 378)
        Me.Cmb_Department.Name = "Cmb_Department"
        Me.Cmb_Department.Size = New System.Drawing.Size(450, 44)
        Me.Cmb_Department.TabIndex = 10
        '
        'Panel_NAMEEN
        '
        Me.Panel_NAMEEN.BackColor = System.Drawing.Color.Maroon
        Me.Panel_NAMEEN.Location = New System.Drawing.Point(606, 324)
        Me.Panel_NAMEEN.Name = "Panel_NAMEEN"
        Me.Panel_NAMEEN.Size = New System.Drawing.Size(490, 3)
        Me.Panel_NAMEEN.TabIndex = 9
        '
        'Txt_NameEN
        '
        Me.Txt_NameEN.BackColor = System.Drawing.Color.SeaShell
        Me.Txt_NameEN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_NameEN.ForeColor = System.Drawing.Color.Maroon
        Me.Txt_NameEN.Location = New System.Drawing.Point(644, 281)
        Me.Txt_NameEN.Name = "Txt_NameEN"
        Me.Txt_NameEN.Size = New System.Drawing.Size(450, 36)
        Me.Txt_NameEN.TabIndex = 7
        '
        'Panel_NAMEKH
        '
        Me.Panel_NAMEKH.BackColor = System.Drawing.Color.Maroon
        Me.Panel_NAMEKH.Location = New System.Drawing.Point(606, 229)
        Me.Panel_NAMEKH.Name = "Panel_NAMEKH"
        Me.Panel_NAMEKH.Size = New System.Drawing.Size(490, 3)
        Me.Panel_NAMEKH.TabIndex = 6
        '
        'Txt_NameKH
        '
        Me.Txt_NameKH.BackColor = System.Drawing.Color.SeaShell
        Me.Txt_NameKH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_NameKH.ForeColor = System.Drawing.Color.Maroon
        Me.Txt_NameKH.Location = New System.Drawing.Point(644, 186)
        Me.Txt_NameKH.Name = "Txt_NameKH"
        Me.Txt_NameKH.Size = New System.Drawing.Size(450, 36)
        Me.Txt_NameKH.TabIndex = 4
        '
        'Txt_ID
        '
        Me.Txt_ID.BackColor = System.Drawing.Color.SeaShell
        Me.Txt_ID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_ID.ForeColor = System.Drawing.Color.Maroon
        Me.Txt_ID.Location = New System.Drawing.Point(644, 101)
        Me.Txt_ID.Name = "Txt_ID"
        Me.Txt_ID.Size = New System.Drawing.Size(450, 36)
        Me.Txt_ID.TabIndex = 1
        '
        'DGV_Data
        '
        Me.DGV_Data.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Data.Location = New System.Drawing.Point(4, 38)
        Me.DGV_Data.Name = "DGV_Data"
        Me.DGV_Data.RowHeadersWidth = 51
        Me.DGV_Data.RowTemplate.Height = 24
        Me.DGV_Data.Size = New System.Drawing.Size(586, 624)
        Me.DGV_Data.TabIndex = 0
        '
        'Panel_Title
        '
        Me.Panel_Title.BackColor = System.Drawing.Color.DimGray
        Me.Panel_Title.Controls.Add(Me.Btn_Close)
        Me.Panel_Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Title.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Title.Name = "Panel_Title"
        Me.Panel_Title.Size = New System.Drawing.Size(1100, 35)
        Me.Panel_Title.TabIndex = 2
        '
        'Panel_ID
        '
        Me.Panel_ID.BackColor = System.Drawing.Color.Maroon
        Me.Panel_ID.Location = New System.Drawing.Point(606, 144)
        Me.Panel_ID.Name = "Panel_ID"
        Me.Panel_ID.Size = New System.Drawing.Size(490, 3)
        Me.Panel_ID.TabIndex = 3
        '
        'Panel_Content
        '
        Me.Panel_Content.Controls.Add(Me.Btn_Delete)
        Me.Panel_Content.Controls.Add(Me.Btn_Update)
        Me.Panel_Content.Controls.Add(Me.Btn_Save)
        Me.Panel_Content.Controls.Add(Me.Panel_DEP)
        Me.Panel_Content.Controls.Add(Me.BTN_DEP)
        Me.Panel_Content.Controls.Add(Me.Cmb_Department)
        Me.Panel_Content.Controls.Add(Me.Panel_NAMEEN)
        Me.Panel_Content.Controls.Add(Me.BTN_NAMEEN)
        Me.Panel_Content.Controls.Add(Me.Txt_NameEN)
        Me.Panel_Content.Controls.Add(Me.Panel_NAMEKH)
        Me.Panel_Content.Controls.Add(Me.BTN_NAMEKH)
        Me.Panel_Content.Controls.Add(Me.Txt_NameKH)
        Me.Panel_Content.Controls.Add(Me.Panel_ID)
        Me.Panel_Content.Controls.Add(Me.BTN_ID)
        Me.Panel_Content.Controls.Add(Me.Txt_ID)
        Me.Panel_Content.Controls.Add(Me.DGV_Data)
        Me.Panel_Content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Content.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Content.Name = "Panel_Content"
        Me.Panel_Content.Size = New System.Drawing.Size(1100, 665)
        Me.Panel_Content.TabIndex = 3
        '
        'Btn_Close
        '
        Me.Btn_Close.FlatAppearance.BorderSize = 0
        Me.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Close.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.Btn_Close.IconColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_Close.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Close.IconSize = 35
        Me.Btn_Close.Location = New System.Drawing.Point(1065, 0)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(35, 35)
        Me.Btn_Close.TabIndex = 1
        Me.Btn_Close.UseVisualStyleBackColor = True
        '
        'Btn_Delete
        '
        Me.Btn_Delete.FlatAppearance.BorderSize = 0
        Me.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Delete.ForeColor = System.Drawing.Color.Maroon
        Me.Btn_Delete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.Btn_Delete.IconColor = System.Drawing.Color.Maroon
        Me.Btn_Delete.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Delete.IconSize = 40
        Me.Btn_Delete.Location = New System.Drawing.Point(912, 509)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Size = New System.Drawing.Size(131, 54)
        Me.Btn_Delete.TabIndex = 15
        Me.Btn_Delete.Text = "លុប"
        Me.Btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Delete.UseVisualStyleBackColor = True
        '
        'Btn_Update
        '
        Me.Btn_Update.FlatAppearance.BorderSize = 0
        Me.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Update.ForeColor = System.Drawing.Color.Maroon
        Me.Btn_Update.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.Btn_Update.IconColor = System.Drawing.Color.Maroon
        Me.Btn_Update.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Update.IconSize = 40
        Me.Btn_Update.Location = New System.Drawing.Point(761, 509)
        Me.Btn_Update.Name = "Btn_Update"
        Me.Btn_Update.Size = New System.Drawing.Size(131, 54)
        Me.Btn_Update.TabIndex = 14
        Me.Btn_Update.Text = "កែប្រែ"
        Me.Btn_Update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Update.UseVisualStyleBackColor = True
        '
        'Btn_Save
        '
        Me.Btn_Save.FlatAppearance.BorderSize = 0
        Me.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Save.ForeColor = System.Drawing.Color.Maroon
        Me.Btn_Save.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.Btn_Save.IconColor = System.Drawing.Color.Maroon
        Me.Btn_Save.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Save.IconSize = 40
        Me.Btn_Save.Location = New System.Drawing.Point(606, 509)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(125, 54)
        Me.Btn_Save.TabIndex = 13
        Me.Btn_Save.Text = "រក្សាទុក"
        Me.Btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Save.UseVisualStyleBackColor = True
        '
        'BTN_DEP
        '
        Me.BTN_DEP.FlatAppearance.BorderSize = 0
        Me.BTN_DEP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_DEP.IconChar = FontAwesome.Sharp.IconChar.Building
        Me.BTN_DEP.IconColor = System.Drawing.Color.Maroon
        Me.BTN_DEP.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BTN_DEP.IconSize = 35
        Me.BTN_DEP.Location = New System.Drawing.Point(605, 386)
        Me.BTN_DEP.Name = "BTN_DEP"
        Me.BTN_DEP.Size = New System.Drawing.Size(35, 35)
        Me.BTN_DEP.TabIndex = 11
        Me.BTN_DEP.UseVisualStyleBackColor = True
        '
        'BTN_NAMEEN
        '
        Me.BTN_NAMEEN.FlatAppearance.BorderSize = 0
        Me.BTN_NAMEEN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_NAMEEN.IconChar = FontAwesome.Sharp.IconChar.UserTag
        Me.BTN_NAMEEN.IconColor = System.Drawing.Color.Maroon
        Me.BTN_NAMEEN.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BTN_NAMEEN.IconSize = 40
        Me.BTN_NAMEEN.Location = New System.Drawing.Point(606, 282)
        Me.BTN_NAMEEN.Name = "BTN_NAMEEN"
        Me.BTN_NAMEEN.Size = New System.Drawing.Size(35, 35)
        Me.BTN_NAMEEN.TabIndex = 8
        Me.BTN_NAMEEN.UseVisualStyleBackColor = True
        '
        'BTN_NAMEKH
        '
        Me.BTN_NAMEKH.FlatAppearance.BorderSize = 0
        Me.BTN_NAMEKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_NAMEKH.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        Me.BTN_NAMEKH.IconColor = System.Drawing.Color.Maroon
        Me.BTN_NAMEKH.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BTN_NAMEKH.IconSize = 40
        Me.BTN_NAMEKH.Location = New System.Drawing.Point(606, 187)
        Me.BTN_NAMEKH.Name = "BTN_NAMEKH"
        Me.BTN_NAMEKH.Size = New System.Drawing.Size(35, 35)
        Me.BTN_NAMEKH.TabIndex = 5
        Me.BTN_NAMEKH.UseVisualStyleBackColor = True
        '
        'BTN_ID
        '
        Me.BTN_ID.FlatAppearance.BorderSize = 0
        Me.BTN_ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ID.IconChar = FontAwesome.Sharp.IconChar.ListUl
        Me.BTN_ID.IconColor = System.Drawing.Color.Maroon
        Me.BTN_ID.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BTN_ID.IconSize = 40
        Me.BTN_ID.Location = New System.Drawing.Point(606, 102)
        Me.BTN_ID.Name = "BTN_ID"
        Me.BTN_ID.Size = New System.Drawing.Size(35, 35)
        Me.BTN_ID.TabIndex = 2
        Me.BTN_ID.UseVisualStyleBackColor = True
        '
        'Frm_Specialty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 36.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(1100, 665)
        Me.Controls.Add(Me.Panel_Title)
        Me.Controls.Add(Me.Panel_Content)
        Me.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.8!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "Frm_Specialty"
        Me.Text = "Frm_Specialty"
        CType(Me.DGV_Data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Title.ResumeLayout(False)
        Me.Panel_Content.ResumeLayout(False)
        Me.Panel_Content.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_Delete As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Update As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Save As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel_DEP As Panel
    Friend WithEvents BTN_DEP As FontAwesome.Sharp.IconButton
    Friend WithEvents Cmb_Department As ComboBox
    Friend WithEvents Panel_NAMEEN As Panel
    Friend WithEvents BTN_NAMEEN As FontAwesome.Sharp.IconButton
    Friend WithEvents Txt_NameEN As TextBox
    Friend WithEvents Panel_NAMEKH As Panel
    Friend WithEvents BTN_NAMEKH As FontAwesome.Sharp.IconButton
    Friend WithEvents Txt_NameKH As TextBox
    Friend WithEvents BTN_ID As FontAwesome.Sharp.IconButton
    Friend WithEvents Txt_ID As TextBox
    Friend WithEvents DGV_Data As DataGridView
    Friend WithEvents Btn_Close As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel_Title As Panel
    Friend WithEvents Panel_ID As Panel
    Friend WithEvents Panel_Content As Panel
End Class
