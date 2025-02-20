Imports Perfumeria.Application
Imports Perfumeria.Domain

Public Class ProductoForm
    Inherits Form
    Implements IForm

    Private ReadOnly Property _productoService As IProductoService

    Sub New(productoService As IProductoService)
        InitializeComponent()
        _productoService = productoService
    End Sub

    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        If Not ValidarCampos() Then Return

        Dim productoAgregado As Boolean = _productoService.AgregarProducto(New Producto With {
            .Nombre = TextNombre.Text,
            .Precio = NumericPrecio.Value
        })

        If Not productoAgregado Then
            MessageBox.Show("Error al agregar producto")
            Return
        End If
        MessageBox.Show("Producto agregado")
    End Sub

    Private Sub ProductoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Function ValidarCampos() As Boolean Implements IForm.ValidarCampos
        ErrorProvider1.Clear()

        If String.IsNullOrWhiteSpace(TextNombre.Text) Then
            ErrorProvider1.SetError(TextNombre, ErrorDictionary(ErrorConstants.IS_EMPTY))
            Return False
        End If

        If NumericPrecio.Value = 0 Then
            ErrorProvider1.SetError(NumericPrecio, ErrorDictionary(ErrorConstants.MIN_PRICE))
            Return False
        End If

        Return True
    End Function

    Public Sub LimpiarCampos() Implements IForm.LimpiarCampos
        TextNombre.Clear()
        NumericPrecio.Value = 0
    End Sub
End Class