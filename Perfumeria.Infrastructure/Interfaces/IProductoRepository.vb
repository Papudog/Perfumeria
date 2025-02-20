Imports Perfumeria.Domain

Public Interface IProductoRepository
    ReadOnly Property Productos As ICollection(Of IProducto)
    Function AgregarProducto(producto As IProducto) As Boolean
    Event OnProductosChanged As Action(Of IProducto)
End Interface
