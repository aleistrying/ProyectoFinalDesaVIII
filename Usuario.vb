
Public Class Usuario
    Private id As Integer
    Private sesionToken As String
    Private nombre As String
    Private apellido As String
    Private email As String
    Private tipoUsuario As Integer
    Private foto As String
    Private sexo As Char
    Private default_cafeteria_id As Integer
    Private cafeteria_id_seleccionada As Integer
    Private saldo As Double = 0.0D
    Private enabled As Boolean
    Public Sub New(_id As Integer, _nombre As String,
                   _apellido As String, _email As String,
                   _tipoUsuario As Integer, _foto As String,
                   _sexo As Char, _default_cafeteria_id As Integer)
        id = _id
        nombre = _nombre
        apellido = _apellido
        email = _email
        tipoUsuario = _tipoUsuario
        foto = _foto
        sexo = _sexo
        default_cafeteria_id = _default_cafeteria_id
    End Sub
    Public Function GetId()
        Return id
    End Function
    Public Function GetNombre()
        Return nombre
    End Function
    Public Function GetApellido()
        Return apellido
    End Function
    Public Function GetEmail()
        Return email
    End Function
    Public Function GetTipoUsuario()
        Return tipoUsuario
    End Function
    Public Function GetSexo()
        Return sexo
    End Function
    Public Function GetFoto()
        Return foto
    End Function
    Public Function GetSesionToken()
        Return sesionToken
    End Function
    Public Function GetDefaultCafeteriaId()
        Return default_cafeteria_id
    End Function
    Public Function GetCafeteriaIdSeleccionada()
        Return cafeteria_id_seleccionada
    End Function
    Public Function GetSaldo()
        Return saldo
    End Function
    Public Function GetEnabled()
        Return enabled
    End Function


    Public Sub SetId(_id As Integer)
        id = _id
    End Sub
    Public Sub SetNombre(_nombre As String)
        nombre = _nombre
    End Sub
    Public Sub SetApellido(_apellido As String)
        apellido = _apellido
    End Sub
    Public Sub SetEmail(_email As String)
        email = _email
    End Sub
    Public Sub SetTipoUsuario(_tipoUsuario As String)
        tipoUsuario = _tipoUsuario
    End Sub
    Public Sub SetFoto(_foto As String)
        foto = _foto
    End Sub
    Public Sub SetSexo(_sexo As Char)
        sexo = _sexo
    End Sub
    Public Sub SetSesionToken(_sesionToken As String)
        sesionToken = _sesionToken
    End Sub
    Public Sub SetDefaultCafeteriaId(_default_cafeteria_id As Integer)
        default_cafeteria_id = _default_cafeteria_id
    End Sub
    Public Sub SetCafeteriaIdSeleccionada(_cafeteria_id_seleccionada As Integer)
        cafeteria_id_seleccionada = _cafeteria_id_seleccionada
    End Sub
    Public Sub SetSaldo(_saldo As Double)
        saldo = _saldo
    End Sub
    Public Sub SetEnabled(_enabled As Boolean)
        enabled = _enabled
    End Sub

End Class
