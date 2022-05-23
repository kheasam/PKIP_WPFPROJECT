Public Class Frm__Register
    Private sql As New MySQLControls()
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Me.Hide()
        sql.login(txt_username, txt_password, cmb_role)

    End Sub

    Private Sub Frm__Register_Load(sender As Object, e As EventArgs) Handles Me.Load
        sql.SetCueText(txt_username, "សូមបញ្ចូលគណនីប្រើប្រាស់")
        sql.SetCueText(txt_password, "សូមបញ្ចូលលេខសម្ងាត់")
        sql.SetCueText(cmb_role, "ជ្រើសរើសមុខងារ")
        sql.cbmx(cmb_role, "select * from roles", "id", "role")

        sql.logos(logo, "select logo from infos")
    End Sub

    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        Me.Close()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click

    End Sub

    Private Sub Btn_Setting_Click(sender As Object, e As EventArgs) Handles Btn_Setting.Click
        Me.Hide()
        Frm_Info.Show()
    End Sub
End Class