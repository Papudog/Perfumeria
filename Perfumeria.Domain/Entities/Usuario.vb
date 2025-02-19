Imports Perfumeria.Application

Public Class Usuario
    Implements IUsuario

    Private Property _nombre As String
    Private Property _contraseña As String

    Public Property Nombre As String Implements IUsuario.Nombre
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Contraseña As String Implements IUsuario.Contraseña
        Get
            Return _contraseña
        End Get
        Set(value As String)
            _contraseña = value
        End Set
    End Property
End Class
