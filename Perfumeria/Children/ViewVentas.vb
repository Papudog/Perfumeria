Imports Perfumeria.Application

Public Class ViewVentas
    Inherits Form

    Private ReadOnly Property _ventaService As IVentaService

    Sub New(ventaService As IVentaService)
        InitializeComponent()
        _ventaService = ventaService
        AddHandler _ventaService.OnRepositoryChanged, AddressOf PopulateGrid
    End Sub

    Private Sub PopulateGrid()
        DataGridVentas.DataSource = _ventaService.ObtenerVentas().Select(Function(v) New With {
            v.Cliente.Nombre,
            v.Cliente.Cedula,
            v.Fecha,
            v.SubTotal,
            v.TotalConIva
        }).ToList()
    End Sub

    Private Sub ViewVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateGrid()
        DataGridVentas.Columns("Nombre").HeaderText = "Nombre del cliente"
        DataGridVentas.Columns("Cedula").HeaderText = "Cédula"
        DataGridVentas.Columns("Fecha").HeaderText = "Fecha de la venta"
        DataGridVentas.Columns("SubTotal").HeaderText = "Subtotal (C$)"
        DataGridVentas.Columns("TotalConIVA").HeaderText = "Total con IVA (C$)"
    End Sub
End Class