Imports Perfumeria.Domain
Imports Perfumeria.Infrastructure

Public Class ClienteService
    Implements IClienteService

    Private ReadOnly Property _clienteRepository As IClienteRepository
    Public Event OnRepositoryChanged As Action Implements IClienteService.OnRepositoryChanged

    Sub New(clienteRepository As IClienteRepository)
        _clienteRepository = clienteRepository
        AddHandler _clienteRepository.OnClientesChanged, AddressOf OnRepositoryChangedHandler
    End Sub

    Private Sub OnRepositoryChangedHandler()
        RaiseEvent OnRepositoryChanged()
    End Sub

    Public Function AgregarCliente(cliente As ICliente) As Boolean Implements IClienteService.AgregarCliente
        Try
            If _clienteRepository.Clientes.Any(Function(c) c.Cedula = cliente.Cedula) Then
                Throw New Exception("Ya existe un cliente con esa cédula")
            End If

            Return _clienteRepository.AgregarCliente(cliente)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ObtenerClientes() As List(Of ICliente) Implements IClienteService.ObtenerClientes
        Return _clienteRepository.Clientes.ToList()
    End Function

    Public Function ValidarCedula(cedula As String) As Boolean Implements IClienteService.ValidarCedula
        Return REGEX_CEDULA.IsMatch(cedula)
    End Function
End Class
