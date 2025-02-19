
Imports Perfumeria.Domain
Imports Perfumeria.Infrastructure

Public Class UsuarioService
    Implements IUsuarioService

    Private ReadOnly Property _usuarioRepository As IUsuarioRepository

    Sub New(usuarioRepository As IUsuarioRepository)
        _usuarioRepository = usuarioRepository
    End Sub
    Public Function ValidarUsuario(inputNombre As String, inputContraseña As String) As Boolean Implements IUsuarioService.ValidarUsuario
        Dim usuario As IUsuario = _usuarioRepository.ObtenerUsuario(inputNombre, inputContraseña)

        If usuario IsNot Nothing Then Return True
        Return False
    End Function

    Public Function ObtenerUsuarios() As List(Of IUsuario) Implements IUsuarioService.ObtenerUsuarios
        Return _usuarioRepository.Usuarios.ToList()
    End Function

    Public Sub AgregarUsuario(usuario As IUsuario) Implements IUsuarioService.AgregarUsuario
        _usuarioRepository.AgregarUsuario(usuario)
    End Sub
End Class
