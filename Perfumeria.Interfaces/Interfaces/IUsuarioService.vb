Public Interface IUsuarioService
    Property Usuarios As List(Of IUsuario)
    Function ValidarUsuario(inputNombre As String, inputContraseña As String) As Boolean
End Interface
