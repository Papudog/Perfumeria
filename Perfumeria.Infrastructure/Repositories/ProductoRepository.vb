Imports Perfumeria.Domain

Public Class ProductoRepository
    Implements IProductoRepository

    Private ReadOnly _productos As ICollection(Of IProducto)
    Public Event OnProductosChanged As Action(Of IProducto) Implements IProductoRepository.OnProductosChanged

    Sub New()
        _productos = New List(Of IProducto) From {
            New Producto With {
                .Nombre = "Colonia",
                .Precio = 100
            },
            New Producto With {
                .Nombre = "Perfume",
                .Precio = 200
            }
        }
    End Sub

    Public ReadOnly Property Productos As ICollection(Of IProducto) Implements IProductoRepository.Productos
        Get
            Return _productos
        End Get
    End Property


    Public Function AgregarProducto(producto As IProducto) As Boolean Implements IProductoRepository.AgregarProducto
        If producto Is Nothing Then Return False

        _productos.Add(producto)
        RaiseEvent OnProductosChanged(producto)
        Return True
    End Function
End Class
