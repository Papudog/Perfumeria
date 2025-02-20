Imports Perfumeria.Domain

Public Interface IClienteRepository
    ReadOnly Property Clientes As ICollection(Of ICliente)
    Function AgregarCliente(cliente As ICliente) As Boolean
    Event OnClientesChanged As Action(Of ICliente)
End Interface
