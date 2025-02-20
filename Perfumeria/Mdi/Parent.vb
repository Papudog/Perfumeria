Imports Perfumeria.Application
Imports Perfumeria.Infrastructure

Public Class Parent
    Inherits Form

    Private ReadOnly Property _clienteRepository As New ClienteRepository
    Private ReadOnly Property _productoRepository As New ProductoRepository
    Private ReadOnly Property _clienteService As IClienteService
    Private ReadOnly Property _productoService As IProductoService
    Private Property _viewProductos As ViewProductos

    Sub New()
        InitializeComponent()
        _clienteService = New ClienteService(_clienteRepository)
        _productoService = New ProductoService(_productoRepository)
    End Sub

    Private Sub Parent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ViewProductosLoad()
    End Sub

    Private Sub ViewProductosLoad()
        If _viewProductos Is Nothing Then
            _viewProductos = New ViewProductos(_productoService) With {
                .MdiParent = Me
            }
            _viewProductos.Show()
        End If

    End Sub

    Private Sub AgregarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarClienteToolStripMenuItem.Click
        Dim clienteForm As New ClienteForm(_clienteService) With {
            .MdiParent = Me
        }
        clienteForm.Show()
    End Sub

    Private Sub ListaDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeClientesToolStripMenuItem.Click
        Dim viewClientes As New ViewClientes(_clienteService) With {
            .MdiParent = Me
        }
        viewClientes.Show()
    End Sub

    Private Sub AgregarProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarProductosToolStripMenuItem.Click
        Dim productoForm As New ProductoForm(_productoService) With {
            .MdiParent = Me
        }
        productoForm.Show()
    End Sub

    Private Sub ListaDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeProductosToolStripMenuItem.Click
        ViewProductosLoad()
    End Sub
End Class