Imports Perfumeria.Application
Imports Perfumeria.Infrastructure

Public Class LoginView
    Inherits Form
    Implements IForm

    Private ReadOnly Property _usuarioService As New UsuarioService(New UsuarioRepository())

    Sub New()
        InitializeComponent()
    End Sub

    Private Sub ButtonIniciar_Click(sender As Object, e As EventArgs) Handles ButtonIniciar.Click
        If Not ValidarCampos() Then Return

        Dim nombre As String = TextNombre.Text
        Dim contraseña As String = TextContra.Text

        If _usuarioService.ValidarUsuario(nombre, contraseña) Then
            Dim dashboard As New Dashboard()
            AddHandler dashboard.Shown, AddressOf DashboardShown
            dashboard.Show()
        Else
            MessageBox.Show("Usuario inválido")
        End If
    End Sub

    Sub DashboardShown()
        Me.Hide()
    End Sub

    Public Function ValidarCampos() As Boolean Implements IForm.ValidarCampos
        ErrorProvider1.Clear()

        If (String.IsNullOrWhiteSpace(TextNombre.Text)) Then
            ErrorProvider1.SetError(TextNombre, ErrorMessages.ErrorDictionary(ErrorConstants.IS_EMPTY))
            Return False
        End If

        If (String.IsNullOrWhiteSpace(TextContra.Text)) Then
            ErrorProvider1.SetError(TextContra, ErrorMessages.ErrorDictionary(ErrorConstants.IS_EMPTY))
            Return False
        End If

        Return True
    End Function
End Class
