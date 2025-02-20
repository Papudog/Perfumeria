Imports Perfumeria.Application
Imports Perfumeria.Domain

Public Class ClienteForm
    Inherits Form
    Implements IForm

    Private ReadOnly Property _clienteService As IClienteService

    Sub New(clienteService As IClienteService)
        InitializeComponent()
        _clienteService = clienteService
    End Sub

    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        If Not ValidarCampos() Then Return
        Try
            Dim clienteAgregado As Boolean = _clienteService.AgregarCliente(New Cliente With {
                .Nombre = TextNombre.Text,
                .Cedula = TextCedula.Text
            })

            If Not clienteAgregado Then
                MessageBox.Show("Error al agregar cliente")
                Return
            End If
            MessageBox.Show("Cliente agregado")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function ValidarCampos() As Boolean Implements IForm.ValidarCampos
        ErrorProvider1.Clear()

        If String.IsNullOrWhiteSpace(TextNombre.Text) Then
            ErrorProvider1.SetError(TextNombre, ErrorDictionary(ErrorConstants.IS_EMPTY))
            Return False
        End If

        If Not _clienteService.ValidarCedula(TextCedula.Text) Then
            ErrorProvider1.SetError(TextCedula, ErrorDictionary(ErrorConstants.INVALID_CEDULA))
            Return False
        End If

        Return True
    End Function

    Public Sub LimpiarCampos() Implements IForm.LimpiarCampos
        TextNombre.Clear()
        TextCedula.Clear()
    End Sub
End Class