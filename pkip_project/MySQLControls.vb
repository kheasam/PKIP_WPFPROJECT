Imports System.IO
Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class MySQLControls
    Inherits MySQLConnects

#Region "Placehoder"
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Private Declare Function FindWindowEx Lib "user32" Alias "FindWindowExA" (ByVal hWnd1 As IntPtr, ByVal hWnd2 As IntPtr, ByVal lpsz1 As String, ByVal lpsz2 As String) As IntPtr
    Private Const EM_SETCUEBANNER As Integer = &H1501

    Public Sub SetCueText(ByVal control As Control, ByVal text As String)
        If TypeOf control Is ComboBox Then
            Dim Edit_hWnd As IntPtr = FindWindowEx(control.Handle, IntPtr.Zero, "Edit", Nothing)
            If Not Edit_hWnd = IntPtr.Zero Then
                SendMessage(Edit_hWnd, EM_SETCUEBANNER, 0, text)
            End If
        ElseIf TypeOf control Is TextBox Then
            SendMessage(control.Handle, EM_SETCUEBANNER, 0, text)
        ElseIf TypeOf control Is RichTextBox Then
            SendMessage(control.Handle, EM_SETCUEBANNER, 0, text)
        End If
    End Sub
#End Region
    Public Sub New()
        cn = GetConnection()
    End Sub
    Public Sub Gridview(dgv As DataGridView, query As String)
        Using cn = GetConnection()
            cn.Open()

            da = New MySqlDataAdapter(query, cn)
            dt = New DataTable
            da.Fill(dt)
            dgv.DataSource = dt
        End Using
    End Sub
    Public Sub cbmx(cmb As ComboBox, query As String, id As String, value As String)
        Using cn = GetConnection()
            cn.Open()
            da = New MySqlDataAdapter(query, cn)
            dt = New DataTable
            da.Fill(dt)

            cmb.DataSource = dt
            cmb.DisplayMember = value
            cmb.ValueMember = id
        End Using
    End Sub
#Region "SQL Command Function"
    ' QUERY PARAMETERS
    Public Params As New List(Of MySqlParameter)
    ' QUERY STATISTICS
    Public RecordCount As Integer
    Public Exception As String

    ' ALLOW CONNECTION STRING OVERRIDE
    'Public Sub New(ConnectionString As String)
    '    cn = New SqlConnection(ConnectionString)
    'End Sub

    ' EXECUTE QUERY SUB
    Public Sub ExecQuery(Query As String, Optional ReturnIdentity As Boolean = False)
        ' RESET QUERY STATS
        RecordCount = 0
        Exception = ""
        Try
            cn.Open()
            ' CREATE DB COMMAND
            cmd = New MySqlCommand(Query, cn)
            ' LOAD PARAMS INTO DB COMMAND
            Params.ForEach(Sub(p) cmd.Parameters.Add(p))
            ' CLEAR PARAM LIST
            Params.Clear()
            ' EXECUTE COMMAND & FILL DATASET
            dt = New DataTable
            da = New MySqlDataAdapter(cmd)
            RecordCount = da.Fill(dt)

            If ReturnIdentity = True Then
                Dim ReturnQuery As String = "SELECT @@IDENTITY As LastID;"
                ' @@IDENTITY - SESSION
                ' SCOPE_IDENTITY() - SESSION & SCOPE
                ' IDENT_CURRENT(tablename) - LAST IDENT IN TABLE, ANY SCOPE, ANY SESSION
                cmd = New MySqlCommand(ReturnQuery, cn)
                dt = New DataTable
                da = New MySqlDataAdapter(cmd)
                RecordCount = da.Fill(dt)
            End If
        Catch ex As Exception
            ' CAPTURE ERROR
            Exception = "ExecQuery Error: " & vbNewLine & ex.Message
        Finally
            ' CLOSE CONNECTION
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    ' ADD PARAMS
    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New MySqlParameter(Name, Value)
        Params.Add(NewParam)
    End Sub

    ' ERROR CHECKING
    Public Function HasException(Optional Report As Boolean = False) As Boolean
        If String.IsNullOrEmpty(Exception) Then Return False
        If Report = True Then MsgBox(Exception, MsgBoxStyle.Critical, "Exception:")
        Return True
    End Function
#End Region

    Sub browsImg(pic As Object)
        Dim op As OpenFileDialog = New OpenFileDialog
        If op.ShowDialog = DialogResult.OK Then
            pic.image = System.Drawing.Image.FromFile(op.FileName)
        End If

    End Sub

    Sub logos(pic As Object, qty As String)
        Dim folder As String = "D:\pkip\files\logo"
        Using cn = GetConnection()
            cn.Open()
            Using cmd As MySqlCommand = New MySqlCommand(qty, cn)
                dr = cmd.ExecuteReader()
                While dr.Read()
                    Dim fname As String = dr(0)
                    Dim pathstring As String = System.IO.Path.Combine(folder, fname)
                    pic.image = System.Drawing.Image.FromStream(New System.IO.MemoryStream(File.ReadAllBytes(pathstring)))
                End While
                dr.Close()
                cn.Close()
            End Using
        End Using
    End Sub
End Class
