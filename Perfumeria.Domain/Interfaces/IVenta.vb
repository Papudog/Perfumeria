Public Interface IVenta
    Property Cliente As ICliente
    Property Productos As List(Of IProducto)
    Property Fecha As Date
    Property SubTotal As Decimal
    ReadOnly Property TotalConIva As Decimal
End Interface
