Imports System.Globalization
Imports System.Reflection.PortableExecutable
Imports Perfumeria.Application
Imports Perfumeria.Domain

Public Class FacturaForm
    Inherits Form
    Implements IForm

    Private ReadOnly Property _clienteService As IClienteService
    Private ReadOnly Property _productoService As IProductoService
    Private ReadOnly Property _ventaService As IVentaService
    Private ReadOnly Property _cordoba As New CultureInfo("es-NI")

    Sub New(clienteService As IClienteService, productoService As IProductoService, ventaService As IVentaService)
        InitializeComponent()

        _clienteService = clienteService
        _productoService = productoService
        _ventaService = ventaService
    End Sub

    Public Sub LimpiarCampos() Implements IForm.LimpiarCampos
        ComboCliente.SelectedIndex = -1
        TextCedula.Clear()
        ListCanasta.Items.Clear()
        TextSub.Clear()
        TextIVA.Clear()
    End Sub

    Public Function ValidarCampos() As Boolean Implements IForm.ValidarCampos
        ErrorProvider1.Clear()

        If ListCanasta.Items.Count <= 0 Then
            ErrorProvider1.SetError(TextIVA, ErrorDictionary(MIN_PRODUCTOS))
            ErrorProvider1.SetError(TextSub, ErrorDictionary(MIN_PRODUCTOS))
            Return False
        End If

        If ComboCliente.SelectedIndex = -1 Then
            ErrorProvider1.SetError(ComboCliente, ErrorDictionary(IS_EMPTY))
            Return False
        End If

        Return True
    End Function

    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        Dim productoSeleccionado As IProducto = ListDisponibles.SelectedItem
        ListCanasta.Items.Add(productoSeleccionado)
        CalcularMontos()
    End Sub

    Private Sub ButtonQuitar_Click(sender As Object, e As EventArgs) Handles ButtonQuitar.Click
        If ListCanasta.SelectedIndex = -1 Then Return

        Dim indiceProducto As Integer = ListCanasta.SelectedIndex
        ListCanasta.Items.RemoveAt(indiceProducto)
        CalcularMontos()
    End Sub

    Private Sub CalcularMontos()
        Dim subtotal As Decimal = ListCanasta.Items.Cast(Of IProducto).Sum(Function(p) p.Precio)
        Dim iva As Decimal = subtotal * 0.15
        Dim total As Decimal = subtotal + iva

        TextSub.Text = subtotal.ToString("C", _cordoba)
        TextIVA.Text = total.ToString("C", _cordoba)
    End Sub

    Private Sub FacturaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboCliente.DataSource = _clienteService.ObtenerClientes()
        ComboCliente.DisplayMember = "Nombre"
        TextCedula.Text = CType(ComboCliente.SelectedItem, ICliente).Cedula

        ListDisponibles.DataSource = _productoService.ObtenerProductos
        ListDisponibles.DisplayMember = "NombreYPrecio"

        ListCanasta.DisplayMember = "NombreYPrecio"

        CalcularMontos()
    End Sub

    Private Sub ComboCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboCliente.SelectedIndexChanged
        If ComboCliente.SelectedIndex = -1 Then Return

        Dim clienteSeleccionado As ICliente = ComboCliente.SelectedItem
        TextCedula.Text = clienteSeleccionado.Cedula
    End Sub

    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
        LimpiarCampos()
    End Sub

    Private Sub ButtonFacturar_Click(sender As Object, e As EventArgs) Handles ButtonFacturar.Click
        If Not ValidarCampos() Then Return

        Dim subtotal As Decimal = Decimal.Parse(TextSub.Text, NumberStyles.Currency, _cordoba)


        Dim ventaCreada As Boolean = _ventaService.AgregarVenta(New Venta With {
           .Cliente = ComboCliente.SelectedItem,
           .Productos = ListCanasta.Items.Cast(Of IProducto).ToList(),
           .Fecha = Date.Now,
           .SubTotal = subtotal
       })

        If Not ventaCreada Then
            MessageBox.Show("No fue posible facturar estos productos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        MessageBox.Show("Venta realizada con éxito", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LimpiarCampos()
    End Sub
End Class