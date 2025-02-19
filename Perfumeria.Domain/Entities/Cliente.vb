Public Class Cliente
    Implements ICliente
    Private Property _nombre As String
    Public Property Nombre As String Implements ICliente.Nombre
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
End Class
