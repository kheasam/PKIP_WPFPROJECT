<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_RPTRegister
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
        Me.CR_Report = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CR_Report
        '
        Me.CR_Report.ActiveViewIndex = -1
        Me.CR_Report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CR_Report.Cursor = System.Windows.Forms.Cursors.Default
        Me.CR_Report.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CR_Report.Location = New System.Drawing.Point(0, 0)
        Me.CR_Report.Name = "CR_Report"
        Me.CR_Report.Size = New System.Drawing.Size(1028, 633)
        Me.CR_Report.TabIndex = 0
        '
        'Frm_RPTRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 633)
        Me.Controls.Add(Me.CR_Report)
        Me.Name = "Frm_RPTRegister"
        Me.Text = "Frm_RPTRegister"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CR_Report As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
