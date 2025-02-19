Imports Perfumeria.Domain
Imports Perfumeria.Infrastructure

Public Class ClienteService
    Implements IClienteService
    Private ReadOnly Property _clienteRepository As IClienteRepository

    Sub New(clienteRepository As IClienteRepository)
        _clienteRepository = clienteRepository
    End Sub
    Public Sub AgregarCliente(cliente As ICliente) Implements IClienteService.AgregarCliente
        _clienteRepository.AgregarCliente(cliente)
    End Sub

    Public Function ObtenerClientes() As List(Of ICliente) Implements IClienteService.ObtenerClientes
        Return _clienteRepository.Clientes.ToList()
    End Function
End Class
