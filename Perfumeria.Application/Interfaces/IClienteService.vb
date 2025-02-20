Imports Perfumeria.Domain

Public Interface IClienteService
    Function ObtenerClientes() As List(Of ICliente)
    Function AgregarCliente(cliente As ICliente) As Boolean
    Function ValidarCedula(cedula As String) As Boolean
    Event OnRepositoryChanged As Action
End Interface
