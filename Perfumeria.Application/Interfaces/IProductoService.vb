Imports Perfumeria.Domain

Public Interface IProductoService
    Function AgregarProducto(producto As IProducto) As Boolean
    Function ObtenerProductos() As List(Of IProducto)
    Event OnRepositoryChanged As Action
End Interface
