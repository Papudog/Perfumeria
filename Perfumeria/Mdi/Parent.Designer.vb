<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Parent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        ArchivoToolStripMenuItem = New ToolStripMenuItem()
        CerrarSesiónToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        OpcionesToolStripMenuItem = New ToolStripMenuItem()
        AgregarClienteToolStripMenuItem = New ToolStripMenuItem()
        ListaDeClientesToolStripMenuItem = New ToolStripMenuItem()
        ProductosToolStripMenuItem = New ToolStripMenuItem()
        AgregarProductosToolStripMenuItem = New ToolStripMenuItem()
        ListaDeProductosToolStripMenuItem = New ToolStripMenuItem()
        VentaToolStripMenuItem = New ToolStripMenuItem()
        FacturarToolStripMenuItem = New ToolStripMenuItem()
        RegistroToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ArchivoToolStripMenuItem, OpcionesToolStripMenuItem, ProductosToolStripMenuItem, VentaToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ArchivoToolStripMenuItem
        ' 
        ArchivoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CerrarSesiónToolStripMenuItem, SalirToolStripMenuItem})
        ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        ArchivoToolStripMenuItem.Size = New Size(73, 24)
        ArchivoToolStripMenuItem.Text = "Archivo"
        ' 
        ' CerrarSesiónToolStripMenuItem
        ' 
        CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        CerrarSesiónToolStripMenuItem.Size = New Size(177, 26)
        CerrarSesiónToolStripMenuItem.Text = "Cerrar sesión"
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(177, 26)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' OpcionesToolStripMenuItem
        ' 
        OpcionesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AgregarClienteToolStripMenuItem, ListaDeClientesToolStripMenuItem})
        OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        OpcionesToolStripMenuItem.Size = New Size(75, 24)
        OpcionesToolStripMenuItem.Text = "Clientes"
        ' 
        ' AgregarClienteToolStripMenuItem
        ' 
        AgregarClienteToolStripMenuItem.Name = "AgregarClienteToolStripMenuItem"
        AgregarClienteToolStripMenuItem.Size = New Size(197, 26)
        AgregarClienteToolStripMenuItem.Text = "Agregar cliente"
        ' 
        ' ListaDeClientesToolStripMenuItem
        ' 
        ListaDeClientesToolStripMenuItem.Name = "ListaDeClientesToolStripMenuItem"
        ListaDeClientesToolStripMenuItem.Size = New Size(197, 26)
        ListaDeClientesToolStripMenuItem.Text = "Lista de clientes"
        ' 
        ' ProductosToolStripMenuItem
        ' 
        ProductosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AgregarProductosToolStripMenuItem, ListaDeProductosToolStripMenuItem})
        ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        ProductosToolStripMenuItem.Size = New Size(89, 24)
        ProductosToolStripMenuItem.Text = "Productos"
        ' 
        ' AgregarProductosToolStripMenuItem
        ' 
        AgregarProductosToolStripMenuItem.Name = "AgregarProductosToolStripMenuItem"
        AgregarProductosToolStripMenuItem.Size = New Size(217, 26)
        AgregarProductosToolStripMenuItem.Text = "Agregar productos"
        ' 
        ' ListaDeProductosToolStripMenuItem
        ' 
        ListaDeProductosToolStripMenuItem.Name = "ListaDeProductosToolStripMenuItem"
        ListaDeProductosToolStripMenuItem.Size = New Size(217, 26)
        ListaDeProductosToolStripMenuItem.Text = "Lista de productos"
        ' 
        ' VentaToolStripMenuItem
        ' 
        VentaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {FacturarToolStripMenuItem, RegistroToolStripMenuItem})
        VentaToolStripMenuItem.Name = "VentaToolStripMenuItem"
        VentaToolStripMenuItem.Size = New Size(60, 24)
        VentaToolStripMenuItem.Text = "Venta"
        ' 
        ' FacturarToolStripMenuItem
        ' 
        FacturarToolStripMenuItem.Name = "FacturarToolStripMenuItem"
        FacturarToolStripMenuItem.Size = New Size(224, 26)
        FacturarToolStripMenuItem.Text = "Facturar"
        ' 
        ' RegistroToolStripMenuItem
        ' 
        RegistroToolStripMenuItem.Name = "RegistroToolStripMenuItem"
        RegistroToolStripMenuItem.Size = New Size(224, 26)
        RegistroToolStripMenuItem.Text = "Registro de ventas"
        ' 
        ' Parent
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 565)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "Parent"
        Text = "Dashboard"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaDeClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaDeProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroToolStripMenuItem As ToolStripMenuItem
End Class
