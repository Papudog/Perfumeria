Public Class Producto
    Implements IProducto

    Private Property _nombre As String
    Private Property _precio As Decimal

    Public Property Nombre As String Implements IProducto.Nombre
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Precio As Decimal Implements IProducto.Precio
        Get
            Return _precio
        End Get
        Set(value As Decimal)
            _precio = value
        End Set
    End Property

    Public ReadOnly Property NombreYPrecio As String Implements IProducto.NombreYPrecio
        Get
            Return $"{Nombre} - C${Precio}"
        End Get
    End Property
End Class
