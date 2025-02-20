Imports Perfumeria.Domain
Imports Perfumeria.Infrastructure

Public Class ProductoService
    Implements IProductoService

    Private ReadOnly Property _productoRepository As IProductoRepository
    Public Event OnRepositoryChanged As Action Implements IProductoService.OnRepositoryChanged

    Sub New(productoRepository As IProductoRepository)
        _productoRepository = productoRepository
        AddHandler _productoRepository.OnProductosChanged, AddressOf OnRepositoryChangedHandler
    End Sub

    Private Sub OnRepositoryChangedHandler()
        RaiseEvent OnRepositoryChanged()
    End Sub

    Public Function AgregarProducto(producto As IProducto) As Boolean Implements IProductoService.AgregarProducto
        Return _productoRepository.AgregarProducto(producto)
    End Function

    Public Function ObtenerProductos() As List(Of IProducto) Implements IProductoService.ObtenerProductos
        Return _productoRepository.Productos.ToList()
    End Function
End Class
