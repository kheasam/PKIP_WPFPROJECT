Public Class Frm__Register
    Private sql As New MySQLControls()
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Me.Hide()
        Frm_Dashboard.Show()
    End Sub

    Private Sub Frm__Register_Load(sender As Object, e As EventArgs) Handles Me.Load

        sql.logos(logo, "select logo from infos")
    End Sub


    Private Sub IconButton1_Click_1(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Close()
    End Sub
End Class