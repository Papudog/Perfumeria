Imports Perfumeria.Application
Imports Perfumeria.Domain

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
        DataGridProductos.DataSource = _productoService.ObtenerProductos().Select(Function(p) New With {p.Nombre, p.Precio}).ToList()
    End Sub
End Class