
Public Class Frm_Users

    Private sql As New MySQLControls

    Sub headerdgv()
        dgv_data.Columns(0).HeaderText = "លេខសម្គាល់"
        dgv_data.Columns(1).HeaderText = "គណនីប្រើប្រាស់"
        dgv_data.Columns(2).HeaderText = "លេខសម្ងាត់"
        dgv_data.Columns(3).HeaderText = "មុខងារ"
    End Sub
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        sql.AddParam("@id", txt_id.Text)
        sql.AddParam("@user", txt_username.Text)
        sql.AddParam("@pass", txt_password.Text)
        sql.AddParam("@role", cmb_role.SelectedValue)

        sql.ExecQuery("INSERT INTO users " &
          "VALUES (@id,@user,@pass,@role);", True)

        '' REPORT & ABORT ON ERRORS
        If sql.HasException(True) Then Exit Sub
        sql.Gridview(dgv_data, "SELECT * FROM v_users")
    End Sub

    Private Sub Frm_Users_Load(sender As Object, e As EventArgs) Handles Me.Load
        sql.SetCueText(txt_id, "សូមបញ្ចូលលេខសម្គាល់")
        sql.SetCueText(txt_username, "សូមបញ្ចូលគណនីប្រើប្រាស់")
        sql.SetCueText(txt_password, "សូមបញ្ចូលលេខសម្ងាត់")
        sql.SetCueText(cmb_role, "សូមជ្រើសរើសមុខងារ")



        sql.Gridview(dgv_data, "SELECT * FROM v_users")
        headerdgv()
        sql.cbmx(cmb_role, "SELECT * FROM roles", "id", "role")

    End Sub


    Private Sub dgv_data_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_data.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow

            row = dgv_data.Rows(e.RowIndex)
            txt_id.Text = row.Cells(0).Value.ToString
            txt_username.Text = row.Cells(1).Value.ToString
            txt_password.Text = row.Cells(2).Value.ToString
            cmb_role.Text = row.Cells(3).Value.ToString

        End If
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        sql.AddParam("@id", txt_id.Text)
        sql.AddParam("@user", txt_username.Text)
        sql.AddParam("@pass", txt_password.Text)
        sql.AddParam("@role", cmb_role.SelectedValue)

        sql.ExecQuery("UPDATE users SET username=@user,password=@pass,role=@role WHERE id = @id", True)

        '' REPORT & ABORT ON ERRORS
        If sql.HasException(True) Then Exit Sub
        sql.Gridview(dgv_data, "SELECT * FROM v_users")
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        sql.AddParam("@id", txt_id.Text)

        sql.ExecQuery("DELETE FROM users WHERE id = @id", True)

        '' REPORT & ABORT ON ERRORS
        If sql.HasException(True) Then Exit Sub
        sql.Gridview(dgv_data, "SELECT * FROM v_users")
    End Sub

    Private Sub Panel_content_Paint(sender As Object, e As PaintEventArgs) Handles Panel_content.Paint

    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()

    End Sub
End Class