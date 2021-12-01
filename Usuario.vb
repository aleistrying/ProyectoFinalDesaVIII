
Public Class Usuario
    Private id As Integer
    Private sesionId As Integer
    Private nombre As String
    Private apellido As String
    Private email As String
    Private tipoUsuario As Integer
    Private foto As String
    Private sexo As Char

    Public Sub New(_id As Integer, _nombre As String, _apellido As String, _email As String, _tipoUsuario As Integer, _foto As String, _sexo As String)
        id = _id
        nombre = _nombre
        apellido = _apellido
        email = _email
        tipoUsuario = _tipoUsuario
        foto = _foto
        sexo = _sexo
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
    Public Function GetSesion()
        Return sesionId
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
    Public Sub SetSesionId(_sesionId As String)
        sesionId = _sesionId
    End Sub

End Class
