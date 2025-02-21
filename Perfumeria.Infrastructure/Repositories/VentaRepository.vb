Imports Perfumeria.Domain

Public Class VentaRepository
    Implements IVentaRepository

    Private ReadOnly Property _ventas As ICollection(Of IVenta)

    Sub New()
        _ventas = New List(Of IVenta)
    End Sub

    Public ReadOnly Property Ventas As ICollection(Of IVenta) Implements IVentaRepository.Ventas
        Get
            Return _ventas
        End Get
    End Property

    Public Event OnVentasChanged As Action(Of IVenta) Implements IVentaRepository.OnVentasChanged

    Public Function AgregarVenta(venta As IVenta) As Boolean Implements IVentaRepository.AgregarVenta
        If venta Is Nothing Then Return False

        _ventas.Add(venta)
        RaiseEvent OnVentasChanged(venta)
        Return True
    End Function
End Class
