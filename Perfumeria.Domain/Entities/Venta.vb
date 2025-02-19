Public Class Venta
    Implements IVenta

    Private Property _cliente As ICliente
    Private Property _productos As List(Of IProducto)
    Private Property _fecha As Date
    Private Property _subTotal As Decimal

    Public Property Cliente As ICliente Implements IVenta.Cliente
        Get
            Return _cliente
        End Get
        Set(value As ICliente)
            _cliente = value
        End Set
    End Property

    Public Property Productos As List(Of IProducto) Implements IVenta.Productos
        Get
            Return _productos
        End Get
        Set(value As List(Of IProducto))
            _productos = value
        End Set
    End Property

    Public Property Fecha As Date Implements IVenta.Fecha
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property

    Public Property SubTotal As Decimal Implements IVenta.SubTotal
        Get
            Return _subTotal
        End Get
        Set(value As Decimal)
            _subTotal = value
        End Set
    End Property

    Public ReadOnly Property TotalConIva As Decimal Implements IVenta.TotalConIva
        Get
            Return SubTotal * 0.15
        End Get
    End Property
End Class
