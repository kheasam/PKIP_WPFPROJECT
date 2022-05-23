Public Class Frm_Academic
    Private sql As New MySQLControls
    Sub heading()
        DGV_Data.Columns(0).HeaderText = "លេខសម្គាល់"
        DGV_Data.Columns(1).HeaderText = "ឆ្នាំសិក្សា"
        DGV_Data.Columns(2).HeaderText = "ជាឡាតាំង"

    End Sub
    Sub clear()
        Txt_ID.Text = ""
        Txt_NameEN.Text = ""
        Txt_NameKH.Text = ""
        Txt_ID.Focus()


    End Sub
    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        sql.AddParam("@id", Txt_ID.Text)
        sql.AddParam("@namekh", Txt_NameKH.Text)
        sql.AddParam("@nameen", Txt_NameEN.Text)

        sql.ExecQuery("INSERT INTO academics VALUES(@id,@namekh,@nameen)", True)

        If sql.HasException(True) Then Exit Sub
        MsgBox("Save Successfull", MessageBoxIcon.Information, "Save")
        sql.Gridview(DGV_Data, "SELECT * FROM Academics")
        clear()
    End Sub

    Private Sub Frm_Academic_Load(sender As Object, e As EventArgs) Handles Me.Load
        sql.SetCueText(Txt_ID, "លេខសម្គាល់")
        sql.SetCueText(Txt_NameKH, "ឆ្នាំសិក្សា")
        sql.SetCueText(Txt_NameEN, "ឡាតាំង")

        sql.Gridview(DGV_Data, "SELECT * FROM Academics")
        heading()

    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub

    Private Sub DGV_Data_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Data.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow

            row = DGV_Data.Rows(e.RowIndex)
            Txt_ID.Text = row.Cells(0).Value.ToString
            Txt_NameKH.Text = row.Cells(1).Value.ToString
            Txt_NameEN.Text = row.Cells(2).Value.ToString
        End If
    End Sub

    Private Sub Btn_Update_Click(sender As Object, e As EventArgs) Handles Btn_Update.Click
        sql.AddParam("@id", Txt_ID.Text)
        sql.AddParam("@namekh", Txt_NameKH.Text)
        sql.AddParam("@nameen", Txt_NameEN.Text)

        sql.ExecQuery("UPDATE academics SET namekh = @namekh, nameen = @nameen WHERE id = @id", True)

        If sql.HasException(True) Then Exit Sub
        MsgBox("Update Successfull", MessageBoxIcon.Information, "Update")
        sql.Gridview(DGV_Data, "SELECT * FROM Academics")
        clear()
    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        sql.AddParam("@id", Txt_ID.Text)


        sql.ExecQuery("DELETE FROM academics WHERE id = @id", True)

        If sql.HasException(True) Then Exit Sub
        MsgBox("Delete Successfull", MessageBoxIcon.Information, "Delete")
        sql.Gridview(DGV_Data, "SELECT * FROM Academics")
        clear()
    End Sub
End Class