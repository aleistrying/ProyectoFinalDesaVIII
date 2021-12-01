Imports MySql.Data.MySqlClient
Imports System.Text
Public Class MySql
    Private Shared connectionString As String = "server=cafeteria.eastus2.cloudapp.azure.com;user id=proyectophp;password=123456;persistsecurityinfo=True;database=p_cafeteria"
    Private Shared sqlConn As New MySqlConnection(connectionString)
    Private Shared sqlCmd As New MySqlCommand
    Private Shared sqlDr As MySqlDataReader
    Private Shared sqlDt As New DataTable
    Private Shared DtA As New MySqlDataAdapter
    Public Sub New()
    End Sub
    Public Shared Function Connection()
        Return sqlConn
    End Function
    Public Shared Function UsuarioLogin(email As String, password As String)
        sqlCmd = sqlConn.CreateCommand()
        sqlCmd.CommandText = "SELECT COUNT(*) FROM user WHERE email='" + email + "' AND pass='" + password + "' AND login_enable=true"
        sqlConn.Open()
        sqlDr = sqlCmd.ExecuteReader()
        sqlDr.Read()
        Dim exists As Integer = sqlDr.GetValue(0)

        sqlDr.Close()
        sqlConn.Close()
        Return exists
    End Function
    Public Shared Function UsuarioExiste(email As String)
        sqlCmd = sqlConn.CreateCommand()
        sqlCmd.CommandText = "SELECT COUNT(*) FROM user WHERE email='" + email + "'"
        sqlConn.Open()
        sqlDr = sqlCmd.ExecuteReader()
        sqlDr.Read()

        Dim exists As Integer = sqlDr.GetValue(0)

        sqlDr.Close()
        Return exists
    End Function
    Public Shared Function CrearUsuario(email As String, nombre As String, apellido As String, pass As String)
        sqlCmd = sqlConn.CreateCommand()

        Dim cmd = New StringBuilder()
        cmd.Append("INSERT INTO user(email,nombre,apellido,pass,tipoUsuario,foto,login_enable) ")
        cmd.Append("VALUES(")
        cmd.Append("'" & email & "',")
        cmd.Append("'" & nombre & "',")
        cmd.Append("'" & apellido & "',")
        cmd.Append("'" & pass & "',")
        cmd.Append("1,null,1)")

        sqlCmd.CommandText = cmd.ToString()
        Dim rowsAffected As Integer = sqlCmd.ExecuteNonQuery()
        sqlConn.Close()
        Return rowsAffected
    End Function

End Class
