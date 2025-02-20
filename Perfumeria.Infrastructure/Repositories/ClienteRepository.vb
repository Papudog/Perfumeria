Imports Perfumeria.Domain

Public Class ClienteRepository
    Implements IClienteRepository

    Private ReadOnly _clientes As ICollection(Of ICliente)
    Public Event OnClientesChanged As Action(Of ICliente) Implements IClienteRepository.OnClientesChanged

    Public ReadOnly Property Clientes As ICollection(Of ICliente) Implements IClienteRepository.Clientes
        Get
            Return _clientes
        End Get
    End Property

    Sub New()
        _clientes = New List(Of ICliente) From {
            New Cliente With {
                .Nombre = "María",
                .Cedula = "001-150304-2003L"
            },
            New Cliente With {
                .Nombre = "Camelia",
                .Cedula = "001-070895-4051M"
            }
        }
    End Sub

    Public Function AgregarCliente(cliente As ICliente) As Boolean Implements IClienteRepository.AgregarCliente
        If cliente Is Nothing Then Return False

        _clientes.Add(cliente)
        RaiseEvent OnClientesChanged(cliente)
        Return True
    End Function
End Class
