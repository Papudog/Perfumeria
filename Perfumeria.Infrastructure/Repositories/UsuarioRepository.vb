Imports Perfumeria.Domain

Public Class UsuarioRepository
    Implements IUsuarioRepository

    Private ReadOnly Property _usuarios As ICollection(Of IUsuario)
    Public ReadOnly Property Usuarios As ICollection(Of IUsuario) Implements IUsuarioRepository.Usuarios
        Get
            Return _usuarios
        End Get
    End Property

    Sub New()
        _usuarios = New List(Of IUsuario) From {
            New Usuario With {.Nombre = "admin", .Contraseña = "1234"}
        }
    End Sub

    Public Sub AgregarUsuario(usuario As IUsuario) Implements IUsuarioRepository.AgregarUsuario
        _usuarios.Add(usuario)
    End Sub

    Public Function ObtenerUsuario(nombre As String, contraseña As String) As IUsuario Implements IUsuarioRepository.ObtenerUsuario
        Return _usuarios.Where(Function(u) (u.Nombre = nombre) And (u.Contraseña = contraseña)).FirstOrDefault()
    End Function
End Class
