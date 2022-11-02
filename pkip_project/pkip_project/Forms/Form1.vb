Imports System.Data.SqlClient

Public Class Form1



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim data As New Database
        With data
            'Assing the object property values
            .ServerName = TextBox1.Text
            .DatabaseName = TextBox2.Text
            '.UserID = txt_uid.Text
            '.Password = txt_pwd.Text

            'Connection testing
            If .Connection Then
                MessageBox.Show("Database Conneted.")
            Else
                MessageBox.Show(.ErrorMessage)
            End If
        End With
    End Sub
End Class

Public Class Database
    Private _connection As New SqlConnection
    Private _errormessge As String
    Private _servername As String
    Private _databasename As String
    Private _userid As String
    Private _password As String

    Public WriteOnly Property ServerName() As String
        Set(ByVal value As String)
            _servername = value
        End Set
    End Property

    Public WriteOnly Property DatabaseName() As String
        Set(ByVal value As String)
            _databasename = value
        End Set
    End Property

    Public WriteOnly Property UserID() As String
        Set(ByVal value As String)
            _userid = value
        End Set
    End Property

    Public WriteOnly Property Password() As String
        Set(ByVal value As String)
            _password = value
        End Set
    End Property

    Public ReadOnly Property ErrorMessage() As String
        Get
            Return _errormessge
        End Get
    End Property

    Public Function Connection() As Boolean
        Try
            _connection.ConnectionString = "Server=" & _servername & ";Database=" & _databasename & ";Integrated Security=True"
            _connection.Open()
            If _connection.State = ConnectionState.Open Then
                _connection.Close()
                Return True
            End If
        Catch ex As Exception
            _errormessge = ex.Message
            Return False
        End Try
    End Function
End Class
