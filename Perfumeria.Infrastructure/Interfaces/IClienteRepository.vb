Imports Perfumeria.Domain

Public Interface IClienteRepository
    ReadOnly Property Clientes As ICollection(Of ICliente)
    Sub AgregarCliente(cliente As ICliente)
End Interface
