﻿Imports System.Security.Cryptography
Imports System.Text
Public Class MD5HashText
    Public Shared Function HashFromText(text As String)
        'Crear Hash del password.
        Using hasher As MD5 = MD5.Create()
            ' Convert to byte array and get hash
            Dim dbytes As Byte() =
                 hasher.ComputeHash(Encoding.UTF8.GetBytes(text))

            ' sb to create string from bytes
            Dim sBuilder As New StringBuilder()

            ' convert byte data to hex string
            For n As Integer = 0 To dbytes.Length - 1
                sBuilder.Append(dbytes(n).ToString("X2"))
            Next n

            Return sBuilder.ToString()
        End Using
    End Function
End Class
