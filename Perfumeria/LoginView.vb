Imports Perfumeria.Application
Imports Perfumeria.Infrastructure

Public Class LoginView
    Implements IForm

    Private ReadOnly Property _usuarioService As New UsuarioService(New UsuarioRepository())

    Private ReadOnly Property _errorDictionary As New Dictionary(Of String, String) From {
        {"isEmpty", "El nombre de usuario no puede estar vacío"}
    }

    Sub New()
        InitializeComponent()
    End Sub

    Private Sub ButtonIniciar_Click(sender As Object, e As EventArgs) Handles ButtonIniciar.Click
        If Not ValidarCampos() Then Return

        Dim nombre As String = TextNombre.Text
        Dim contraseña As String = TextContra.Text

        If _usuarioService.ValidarUsuario(nombre, contraseña) Then
            MessageBox.Show("Usuario válido")
        Else
            MessageBox.Show("Usuario inválido")
        End If
    End Sub

    Public Function ValidarCampos() As Boolean Implements IForm.ValidarCampos
        ErrorProvider1.Clear()

        If (String.IsNullOrWhiteSpace(TextNombre.Text)) Then
            ErrorProvider1.SetError(TextNombre, _errorDictionary("isEmpty"))
            Return False
        End If

        If (String.IsNullOrWhiteSpace(TextContra.Text)) Then
            ErrorProvider1.SetError(TextContra, _errorDictionary("isEmpty"))
            Return False
        End If

        Return True
    End Function
End Class
