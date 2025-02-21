Imports Perfumeria.Domain

Public Interface IVentaService
    Function AgregarVenta(venta As IVenta) As Boolean
    Function ObtenerVentas() As List(Of IVenta)
    Event OnRepositoryChanged As Action
End Interface
