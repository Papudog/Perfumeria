Imports Perfumeria.Application

Public Class ViewClientes
    Inherits Form

    Private ReadOnly Property _clienteService As IClienteService

    Sub New(clienteService As IClienteService)
        InitializeComponent()
        _clienteService = clienteService

        AddHandler _clienteService.OnRepositoryChanged, AddressOf PopulateGrid
    End Sub

    Private Sub ViewClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateGrid()
    End Sub

    Private Sub PopulateGrid()
        DataGridClientes.DataSource = _clienteService.ObtenerClientes()
    End Sub
End Class