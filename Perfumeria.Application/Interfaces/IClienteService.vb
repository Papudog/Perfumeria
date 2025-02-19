Imports Perfumeria.Domain

Public Interface IClienteService
    Function ObtenerClientes() As List(Of ICliente)
    Sub AgregarCliente(cliente As ICliente)

End Interface
