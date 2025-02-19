Imports Perfumeria.Application
Imports Perfumeria.Domain

Public Class ClienteChildForm
    Inherits Form
    Implements IForm
    Private ReadOnly Property _clienteService As IClienteService

    Sub New(clienteService As IClienteService)
        InitializeComponent()

        _clienteService = clienteService
    End Sub

    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        If Not ValidarCampos() Then Return

        Dim nombre As String = TextNombre.Text
        _clienteService.AgregarCliente(New Cliente With {
            .Nombre = nombre
        })
        MessageBox.Show("Cliente agregado")
    End Sub

    Public Function ValidarCampos() As Boolean Implements IForm.ValidarCampos
        ErrorProvider1.Clear()

        If String.IsNullOrWhiteSpace(TextNombre.Text) Then
            ErrorProvider1.SetError(TextNombre, ErrorMessages.ErrorDictionary(ErrorConstants.IS_EMPTY))
            Return False
        End If

        Return True
    End Function
End Class