Imports Perfumeria.Application

Public Class ViewProductos
    Inherits Form

    Private ReadOnly Property _productoService As IProductoService

    Sub New(productoService As IProductoService)
        InitializeComponent()
        _productoService = productoService
        AddHandler _productoService.OnRepositoryChanged, AddressOf PopulateGrid
    End Sub

    Private Sub ViewProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateGrid()
    End Sub

    Sub PopulateGrid()
        DataGridProductos.DataSource = _productoService.ObtenerProductos()
    End Sub

    Private Sub ViewProductos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class