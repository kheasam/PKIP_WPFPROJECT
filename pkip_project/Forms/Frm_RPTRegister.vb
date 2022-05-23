Public Class Frm_RPTRegister
    Private sql As New MySQLControls
    Private Sub Frm_RPTRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql.crReport(CR_Report)
    End Sub
End Class