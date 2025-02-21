Imports Perfumeria.Domain
Imports Perfumeria.Infrastructure

Public Class VentaService
    Implements IVentaService

    Private ReadOnly Property _ventaRepository As IVentaRepository
    Public Event OnRepositoryChanged As Action Implements IVentaService.OnRepositoryChanged

    Sub New(ventaRepository As IVentaRepository)
        _ventaRepository = ventaRepository
        AddHandler _ventaRepository.OnVentasChanged, AddressOf OnRepositoryChangedHandler
    End Sub

    Private Sub OnRepositoryChangedHandler()
        RaiseEvent OnRepositoryChanged()
    End Sub

    Public Function AgregarVenta(venta As IVenta) As Boolean Implements IVentaService.AgregarVenta
        Return _ventaRepository.AgregarVenta(venta)
    End Function

    Public Function ObtenerVentas() As List(Of IVenta) Implements IVentaService.ObtenerVentas
        Return _ventaRepository.Ventas.ToList()
    End Function
End Class
