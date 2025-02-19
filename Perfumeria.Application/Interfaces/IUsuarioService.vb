Imports Perfumeria.Domain

Public Interface IUsuarioService
    Sub AgregarUsuario(usuario As IUsuario)
    Function ObtenerUsuarios() As List(Of IUsuario)
    Function ValidarUsuario(inputNombre As String, inputContraseña As String) As Boolean
End Interface
