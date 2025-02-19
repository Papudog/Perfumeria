Imports Perfumeria.Domain

Public Interface IUsuarioRepository
    ReadOnly Property Usuarios As ICollection(Of IUsuario)
    Sub AgregarUsuario(usuario As IUsuario)
    Function ObtenerUsuario(nombre As String, contraseña As String) As IUsuario
End Interface
