Imports System.Runtime.InteropServices

Public Class Frm_Dashboard
    'make form header moving 
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Public Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Public Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Sub abri_Form(ByVal FormAbri As Object)
        If Panel_Content.Controls.Count > 0 Then
            Me.Panel_Content.Controls.RemoveAt(0)
        End If
        Dim fa As Form = TryCast(FormAbri, Form)
        fa.TopLevel = False
        fa.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        fa.Dock = DockStyle.Fill
        Me.Panel_Content.Controls.Add(fa)
        Me.Panel_Content.Tag = fa
        fa.Show()

    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub bnt_minimize_Click(sender As Object, e As EventArgs) Handles bnt_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_maximize_Click(sender As Object, e As EventArgs) Handles btn_maximize.Click
        btn_restore.Visible = True
        btn_maximize.Visible = False
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btn_restore_Click(sender As Object, e As EventArgs) Handles btn_restore.Click
        btn_restore.Visible = False
        btn_maximize.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Timer_Hide_Tick(sender As Object, e As EventArgs) Handles Timer_Hide.Tick
        If Panel_Menu.Width <= 40 Then
            Me.Timer_Hide.Enabled = False
        Else
            Me.Panel_Menu.Width = Panel_Menu.Width - 20

        End If

    End Sub

    Private Sub Timer_Show_Tick(sender As Object, e As EventArgs) Handles Timer_Show.Tick
        If Panel_Menu.Width >= 300 Then
            Me.Timer_Show.Enabled = False
        Else
            Me.Panel_Menu.Width = Panel_Menu.Width + 20
        End If
    End Sub

    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        If Panel_Menu.Width = 300 Then
            Timer_Hide.Enabled = True
        ElseIf Panel_Menu.Width = 40 Then
            Timer_Show.Enabled = True
        End If

    End Sub

    Private Sub btn_User_Click(sender As Object, e As EventArgs) Handles btn_User.Click
        Call abri_Form(New Frm_Users)
    End Sub



    Private Sub Panel_Title_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel_Title.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
        btn_maximize.Visible = True
        btn_restore.Visible = False
    End Sub

    Private Sub youtube_Click(sender As Object, e As EventArgs) Handles youtube.Click
        Dim url As New ProcessStartInfo("https://www.youtube.com/channel/UCm4NthZlVLidSFt1ramRiWg")
        Try
            Process.Start(url)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub telegrame_Click(sender As Object, e As EventArgs) Handles telegrame.Click
        Dim url As New ProcessStartInfo("https://t.me/gurutechi")
        Try
            Process.Start(url)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


End Class