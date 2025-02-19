Imports Perfumeria.Domain

Public Class ClienteRepository
    Implements IClienteRepository

    Private ReadOnly _clientes As ICollection(Of ICliente)

    Public ReadOnly Property Clientes As ICollection(Of ICliente) Implements IClienteRepository.Clientes
        Get
            Return _clientes
        End Get
    End Property

    Sub New()
        _clientes = New List(Of ICliente) From {
            New Cliente With {
                .Nombre = "María"
            },
            New Cliente With {
                .Nombre = "Camelia"
            }
        }
    End Sub

    Public Sub AgregarCliente(cliente As ICliente) Implements IClienteRepository.AgregarCliente
        _clientes.Add(cliente)
    End Sub
End Class
