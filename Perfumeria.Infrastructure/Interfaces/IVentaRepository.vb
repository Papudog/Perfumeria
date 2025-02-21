Imports Perfumeria.Domain

Public Interface IVentaRepository
    ReadOnly Property Ventas As ICollection(Of IVenta)
    Function AgregarVenta(venta As IVenta) As Boolean
    Event OnVentasChanged As Action(Of IVenta)
End Interface
