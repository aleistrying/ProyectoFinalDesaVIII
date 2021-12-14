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
        Dim correctLogin As Integer = sqlDr.GetValue(0)

        sqlDr.Close()
        sqlConn.Close()
        Return correctLogin
    End Function
    Public Shared Function CrearSesion(email As String)
        Dim user As Usuario
        Dim currentDate As Date = Date.Now

        'no deberia fallar este query a menos que no haya limitaciones en nombre o apellido
        sqlCmd.CommandText = "SELECT id,nombre,apellido,tipoUsuario,COALESCE(foto,''),COALESCE(sexo,''), COALESCE(default_cafeteria_id,0), get_saldoById(id) saldo FROM user WHERE email='" + email + "' AND login_enable=true"
        sqlConn.Open()
        sqlDr = sqlCmd.ExecuteReader()
        sqlDr.Read()

        If Not sqlDr.HasRows Then
            MessageBox.Show("Error Base de Datos", "No tiene conexion a la base de datos, o el usuario fue incorrecto, reintente mas tarde.")
            Return vbNullString
        End If
        Try
            user = New Usuario(sqlDr.GetValue(0), sqlDr.GetString(1), sqlDr.GetString(2),
                            email, sqlDr.GetValue(3), sqlDr.GetString(4), sqlDr.GetChar(5), sqlDr.GetValue(6))
            'cafeteria seleccionada es la default.
            user.SetCafeteriaIdSeleccionada(sqlDr.GetValue(6))
            user.SetSaldo(sqlDr.GetValue(7))
        Catch ex As Exception
            Return vbNullString
        End Try
        sqlDr.Close()


        'Crear sesion en la base de datos
        Dim sesionToken As String = MD5HashText.HashFromText(user.ToString() + String.Format("{0:yyyy/MM/dd hh:mm:ss}", currentDate))
        user.SetSesionToken(sesionToken)
        'revisar si existe el registro
        sqlCmd.CommandText = $"SELECT COUNT(*) FROM sesiones_vb WHERE userId='{user.GetId()}'"
        sqlDr = sqlCmd.ExecuteReader()
        sqlDr.Read()
        Dim existe As Integer = sqlDr.GetValue(0)
        sqlDr.Close()
        'salvar la sesion en la base de datos
        If existe = 0 Then
            'si no existe crear el registro
            sqlCmd.CommandText = $"INSERT INTO sesiones_vb(userId,token,createDate,updateDate) VALUES ({user.GetId()},'{user.GetSesionToken()}','{currentDate:yyyy/MM/dd hh:mm:ss}','{currentDate:yyyy/MM/dd hh:mm:ss}')"
            Dim rows = sqlCmd.ExecuteNonQuery()
            If rows = 0 Then
                'eliminar la sesion del usuario
                MessageBox.Show("Error Insertando", "Error al intentar insertar el registro de usuario en la base de datos.")
                user.SetSesionToken("")
            End If
        Else
            'si existe, actualizar el registro.
            sqlCmd.CommandText = $"UPDATE sesiones_vb SET token = '{user.GetSesionToken()}', updateDate='{currentDate:yyyy/MM/dd hh:mm:ss}' WHERE userId={user.GetId()}"
            Dim rows = sqlCmd.ExecuteNonQuery()
            If rows = 0 Then
                'eliminar la sesion del usuario
                MessageBox.Show("Error Update", "Error al intentar actualizar el registro en la base de datos.")
                user.SetSesionToken("")
            End If
        End If
        sqlConn.Close()
        'si todo sale bien, deberia tener el SesionId funcional
        Return user
    End Function
    Public Shared Function RevisarToken(user As Usuario)
        sqlConn.Open()
        sqlCmd.CommandText = $"SELECT COUNT(*) FROM sesiones_vb WHERE token='{user.GetSesionToken()}' AND token IS NOT NULL AND token NOT LIKE ''"
        sqlDr = sqlCmd.ExecuteReader()
        sqlDr.Read()
        If Not sqlDr.HasRows Then
            MessageBox.Show("Error Base de Datos", "No tiene conexion a la base de datos, o el usuario fue incorrecto, reintente mas tarde.")
            Return vbNullString
        End If
        Dim tieneSesion As Integer = sqlDr.GetValue(0)
        sqlDr.Close()
        sqlConn.Close()
        Return tieneSesion
    End Function
    Public Shared Function UsuarioExiste(email As String)
        sqlCmd = sqlConn.CreateCommand()
        sqlCmd.CommandText = "SELECT COUNT(*) FROM user WHERE email='" + email + "'"
        sqlConn.Open()
        sqlDr = sqlCmd.ExecuteReader()
        sqlDr.Read()

        Dim exists As Integer = sqlDr.GetValue(0)

        sqlDr.Close()
        sqlConn.Close()
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
    Public Shared Function ActualizarUsuarioCafeteria(user As Usuario)
        sqlCmd.CommandText = $"UPDATE user SET default_cafeteria_id={user.GetCafeteriaIdSeleccionada()} WHERE id={user.GetId()}"
        sqlConn.Open()
        Dim updated As Integer = sqlCmd.ExecuteNonQuery()
        sqlConn.Close()
        Return updated
    End Function

    Public Shared Function ListaCafeterias()
        sqlCmd = sqlConn.CreateCommand()

        sqlConn.Open()
        'conseguimos la cantidad de registros
        sqlCmd.CommandText = "SELECT COUNT(*) FROM cafeteria WHERE enable = 1"
        sqlDr = sqlCmd.ExecuteReader()
        sqlDr.Read()

        'revisamos si tiene datos el query.
        If Not sqlDr.HasRows Then
            MessageBox.Show("Error Base de Datos", "No tiene conexion a la base de datos, reintente mas tarde.")
            Return vbNull
        End If

        'asignamos el valor de los rows al array multidimensional
        Dim rowCount As Integer = sqlDr.GetValue(0)
        Dim cafeterias(2, rowCount - 1) As String
        sqlDr.Close()

        'creamos un nuevo query, y conseguimos los registros
        sqlCmd.CommandText = "SELECT id,nombre_cafeteria,ubicacion FROM cafeteria WHERE enable = 1"
        sqlDr = sqlCmd.ExecuteReader()

        Dim i As Integer = 0

        While (sqlDr.Read() = True)
            cafeterias(0, i) = sqlDr.GetString(0)
            cafeterias(1, i) = sqlDr.GetString(1)
            cafeterias(2, i) = sqlDr.GetString(2)
            i += 1
        End While
        sqlDr.Close()
        sqlConn.Close()
        Return cafeterias
    End Function
    Public Shared Function CargarPlatos(user As Usuario)
        'Mi propia vista.

        sqlCmd.CommandText = $"
SELECT COUNT(*) 
FROM platos_en_cafeteria pc,plato p,
tipousuario tu LEFT JOIN  subsidio_tipo_usuario stu ON stu.tipo_usuario  = tu.id 
WHERE tu.id={user.GetTipoUsuario()} 
AND pc.idPlato = p.id 
AND pc.idCafeteria={user.GetCafeteriaIdSeleccionada()} 
AND pc.stock > 0 
AND pc.enable = 1"
        sqlConn.Open()
        sqlDr = sqlCmd.ExecuteReader()
        sqlDr.Read()
        Dim rows As Integer = sqlDr.GetValue(0)
        sqlDr.Close()

        Dim platos(5, rows - 1) As String
        sqlCmd.CommandText = $"
SELECT p.id,NVL(p.nombre,'') nombre,NVL(p.descripcion,'') descripcion,p.foto,ROUND((1-NVL(stu.porcentaje_subsidio,0)/100) * p.precio,2) precio, pc.stock
FROM platos_en_cafeteria pc,plato p,
tipousuario tu LEFT JOIN  subsidio_tipo_usuario stu ON stu.tipo_usuario  = tu.id 
WHERE tu.id={user.GetTipoUsuario()} 
AND pc.idPlato = p.id 
AND pc.idCafeteria={user.GetCafeteriaIdSeleccionada()} 
AND pc.stock > 0 
AND pc.enable = 1"
        sqlDr = sqlCmd.ExecuteReader()
        Dim i = 0
        While sqlDr.Read() = True
            platos(0, i) = sqlDr.GetValue(0) 'id
            platos(1, i) = sqlDr.GetString(1) 'nombre
            platos(2, i) = sqlDr.GetString(2) 'desc
            platos(3, i) = sqlDr.GetString(3) 'foto
            platos(4, i) = sqlDr.GetDouble(4) 'price
            platos(5, i) = sqlDr.GetValue(5) 'stock
            i += 1
        End While
        sqlDr.Close()
        sqlConn.Close()
        Return platos
    End Function
    Public Shared Function GetSaldo(user As Usuario)
        sqlConn.Open()
        sqlCmd.CommandText = $"SELECT get_saldoById({user.GetId()}) FROM sesiones_vb WHERE token='{user.GetSesionToken()}' AND token IS NOT NULL AND token NOT LIKE ''"
        sqlDr = sqlCmd.ExecuteReader()
        sqlDr.Read()

        If Not sqlDr.HasRows Then
            'MessageBox.Show("Error Base de Datos", "No tiene conexion a la base de datos, o el usuario fue incorrecto, reintente mas tarde.")
            Return vbNullString
        End If

        Dim saldo As Double = sqlDr.GetDouble(0)
        sqlDr.Close()
        sqlConn.Close()
        Return saldo

    End Function
    Public Shared Function CrearFactura(platoId As Integer, user As Usuario)
        sqlConn.Open()
        sqlCmd.CommandText = $"SELECT add_Factura2({platoId},{user.GetCafeteriaIdSeleccionada()},{user.GetId()}) FROM sesiones_vb WHERE token='{user.GetSesionToken()}' AND token IS NOT NULL AND token NOT LIKE ''"
        sqlDr = sqlCmd.ExecuteReader()
        sqlDr.Read()

        If Not sqlDr.HasRows Then
            'MessageBox.Show("Error Base de Datos", "No tiene conexion a la base de datos, o el usuario fue incorrecto, reintente mas tarde.")
            Return vbNullString
        End If

        Dim facturaId = sqlDr.GetValue(0)
        sqlDr.Close()
        sqlConn.Close()
        Return facturaId

    End Function
    Public Shared Function GetFactura(facturaId As String, user As Usuario)
        sqlConn.Open()
        sqlCmd.CommandText = $"SELECT client_name cliente, 
order_code facturaId, NVL(description_order,'') descripcion, order_status status, 
responsible_cafe cafeteria, NVL(order_amount,0) monto, order_date fecha
FROM pedidos_realizados
WHERE order_code = '{facturaId}'"
        sqlDr = sqlCmd.ExecuteReader()

        If Not sqlDr.HasRows Then
            'MessageBox.Show("Error Base de Datos", "No tiene conexion a la base de datos, o el usuario fue incorrecto, reintente mas tarde.")
            Return vbNullString
        End If
        Dim factura As New Dictionary(Of String, String)
        'Dim i = 0
        While sqlDr.Read() = True
            factura.Add("cliente", sqlDr.GetValue(0)) 'cliente
            factura.Add("facturaId", sqlDr.GetValue(1)) 'facturaId
            factura.Add("descripcion", sqlDr.GetValue(2)) 'descripcion
            factura.Add("status", sqlDr.GetValue(3)) 'status
            factura.Add("cafeteria", sqlDr.GetValue(4)) 'cafeteria
            factura.Add("monto", sqlDr.GetValue(5)) 'monto
            factura.Add("fecha", sqlDr.GetValue(6)) 'fecha
            'i += 1
        End While

        sqlDr.Close()
        sqlConn.Close()

        Return factura
    End Function
    Public Shared Function GetFacturas(user As Usuario)
        sqlConn.Open()
        sqlCmd.CommandText = $"SELECT COUNT(*)
FROM pedidos_realizados
WHERE client_id={user.GetId()}"
        sqlDr = sqlCmd.ExecuteReader()
        sqlDr.Read()

        Dim length As Integer = sqlDr.GetValue(0)
        sqlDr.Close()

        sqlCmd.CommandText = $"SELECT client_name cliente, 
order_code facturaId, NVL(description_order,'')  descripcion, order_status status, 
responsible_cafe cafeteria, NVL(order_amount,0) monto, order_date fecha
FROM pedidos_realizados
WHERE client_id={user.GetId()}"
        sqlDr = sqlCmd.ExecuteReader()

        If Not sqlDr.HasRows Then
            'MessageBox.Show("Error Base de Datos", "No tiene conexion a la base de datos, o el usuario fue incorrecto, reintente mas tarde.")
            Return vbNullString
        End If
        Dim facturas(length - 1) As Dictionary(Of String, String)
        Dim factura As Dictionary(Of String, String)
        Dim i = 0
        While sqlDr.Read() = True
            facturas(i) = New Dictionary(Of String, String) From {
                {"cliente", sqlDr.GetValue(0)}, 'cliente
                {"facturaId", sqlDr.GetValue(1)}, 'facturaId
                {"descripcion", sqlDr.GetValue(2)}, 'descripcion
                {"status", sqlDr.GetValue(3)}, 'status
                {"cafeteria", sqlDr.GetValue(4)}, 'cafeteria
                {"monto", sqlDr.GetValue(5)}, 'monto
                {"fecha", sqlDr.GetValue(6)} 'fecha
                }

            i += 1
        End While

        sqlDr.Close()
        sqlConn.Close()

        Return facturas
    End Function

    Public Shared Function AgregarFondos(user As Usuario, monto As Double)
        sqlCmd.CommandText = $"INSERT INTO recarga(idUser,montoRecargado) 
VALUES({user.GetId()},{Math.Round(monto, 2)})"
        sqlConn.Open()
        Dim inserted As Integer = sqlCmd.ExecuteNonQuery()
        sqlConn.Close()
        Return inserted
    End Function
    Public Shared Function ActualizarUsuario(user As Usuario)
        sqlCmd.CommandText = $"UPDATE user
SET nombre='{user.GetNombre()}',
apellido='{user.GetApellido()}',
foto='{user.GetFoto()}'
WHERE id = {user.GetId()}"
        sqlConn.Open()
        Dim inserted As Integer = sqlCmd.ExecuteNonQuery()
        sqlConn.Close()
        Return inserted
    End Function
    Public Shared Function GetUsuarios()
        sqlConn.Open()
        sqlCmd.CommandText = $"SELECT COUNT(*)
FROM user"
        sqlDr = sqlCmd.ExecuteReader()
        sqlDr.Read()

        Dim length As Integer = sqlDr.GetValue(0)
        sqlDr.Close()

        sqlCmd.CommandText = $"SELECT 
        id,nombre,apellido,email,tipoUsuario,
COALESCE(foto,'') foto,COALESCE(sexo,'') sexo,
COALESCE(default_cafeteria_id,0) default_cafeteria_id, 
get_saldoById(id) saldo, login_enable
FROM user "
        sqlDr = sqlCmd.ExecuteReader()

        If Not sqlDr.HasRows Then
            'MessageBox.Show("Error Base de Datos", "No tiene conexion a la base de datos, o el usuario fue incorrecto, reintente mas tarde.")
            Return vbNullString
        End If
        Dim usuarios(length - 1) As Usuario
        Dim user As Usuario
        Dim i = 0
        While sqlDr.Read() = True
            user = New Usuario(sqlDr.GetValue(0),
sqlDr.GetString(1),
sqlDr.GetString(2),
sqlDr.GetString(3),
sqlDr.GetValue(4),
sqlDr.GetString(5),
sqlDr.GetString(6),
sqlDr.GetValue(7))
            user.SetCafeteriaIdSeleccionada(sqlDr.GetValue(7))
            user.SetSaldo(sqlDr.GetValue(8))
            user.SetEnabled(sqlDr.GetBoolean(9))
            usuarios(i) = user
            i += 1
        End While

        sqlDr.Close()
        sqlConn.Close()

        Return usuarios
    End Function

    Public Shared Function GetTipoUsuarios()
        sqlConn.Open()
        sqlCmd.CommandText = $"SELECT COUNT(*) FROM tipousuario"
        sqlDr = sqlCmd.ExecuteReader()
        sqlDr.Read()

        Dim len As Integer = sqlDr.GetValue(0)
        sqlDr.Close()

        sqlCmd.CommandText = $"SELECT id, tipo FROM tipousuario"
        sqlDr = sqlCmd.ExecuteReader()
        Dim tipoUsuarios(len - 1) As Dictionary(Of String, String)
        Dim i = 0
        While sqlDr.Read() = True

            tipoUsuarios(i) = New Dictionary(Of String, String) From {
                {"id", sqlDr.GetValue(0)},
                {"descripcion", sqlDr.GetString(1)}}

            i += 1
        End While
        sqlDr.Close()
        sqlConn.Close()
        Return tipoUsuarios
    End Function

End Class
