Public Class Frm_Info
    Private sql As New MySQLControls()

    Private Sub Btn_Brows_Click(sender As Object, e As EventArgs) Handles Btn_Brows.Click
        sql.browsImg(logo)

    End Sub

    Private Sub Frm_Info_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        logo.BackgroundImageLayout = ImageLayout.Stretch
    End Sub
End Class