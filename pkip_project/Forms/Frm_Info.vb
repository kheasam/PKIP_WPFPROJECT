Public Class Frm_Info
    Private sql As New MySQLControls()

    Private Sub Btn_Brows_Click(sender As Object, e As EventArgs) Handles Btn_Brows.Click

        sql.browsImg(logo)

    End Sub

    Private Sub Frm_Info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql.SetCueText(txt_id, "បញ្ចូលលេខសម្គាល់")
        sql.SetCueText(txt_namkh, "បញ្ជូលឈ្មោះទីតាំង")
        sql.SetCueText(txt_nameen, "ជាឡាតាំង")
        sql.SetCueText(txt_address, "បញ្ចូលអាសយដ្ឋាន")

    End Sub

    Private Sub Btn_Remove_Click(sender As Object, e As EventArgs) Handles Btn_Remove.Click
        logo.Image = Nothing
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        sql.AddParam("@id", txt_id.Text)
        sql.AddParam("@namekh", txt_namkh.Text)
        sql.AddParam("@nameen", txt_nameen.Text)
        sql.AddParam("@address", txt_address.Text)

        Dim fname As String = txt_nameen.Text & ".jpg"
        Dim folder As String = "D:\pkip\files\logo"
        Dim pathstring As String = System.IO.Path.Combine(folder, fname)
        sql.AddParam("@img", pathstring)

        sql.ExecQuery("INSERT INTO infos(id,namekh,nameen,address,logo) " &
          "VALUES (@id,@namekh,@nameen,@address,@img);", True)

        Dim img As Image = logo.Image
        img.Save(pathstring)


        '' REPORT & ABORT ON ERRORS
        If sql.HasException(True) Then Exit Sub
        MessageBox.Show("Save Infos Successful")
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub
End Class