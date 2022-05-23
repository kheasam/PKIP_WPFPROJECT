Imports MySql.Data.MySqlClient
Public MustInherit Class MySQLConnects
    Public source As String = "localhost"
    Public database As String = "pkip"
    Public user As String = "root"
    Public password As String = ""
    Public cs As String

    'Declare All Variable
    Public da As New MySqlDataAdapter
    Public dr As MySqlDataReader
    Public cmd As New MySqlCommand
    Public cn As New MySqlConnection
    Public dt As DataTable
    Public ds As DataSet



    Protected Sub New()
        cs = "Server=" + source + ";Database=" + database + ";Uid=" + user + ";Pwd=" + password + ";"
    End Sub
    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(cs)
    End Function

End Class
