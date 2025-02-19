Imports Perfumeria.Application
Imports Perfumeria.Infrastructure

Public Class Dashboard
    Inherits Form

    Private ReadOnly Property _clienteRepository As New ClienteRepository
    Private ReadOnly Property _clienteService As IClienteService

    Sub New()
        InitializeComponent()

        _clienteService = New ClienteService(_clienteRepository)
    End Sub

    Private Sub AgregarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarClienteToolStripMenuItem.Click
        Dim clienteChildForm As New ClienteChildForm(_clienteService) With {
            .MdiParent = Me
        }
        clienteChildForm.Show()
    End Sub
End Class