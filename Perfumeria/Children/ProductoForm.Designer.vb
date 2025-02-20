<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductoForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        GroupBox1 = New GroupBox()
        NumericPrecio = New NumericUpDown()
        Label2 = New Label()
        Label1 = New Label()
        TextNombre = New TextBox()
        ButtonAgregar = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        GroupBox1.SuspendLayout()
        CType(NumericPrecio, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(NumericPrecio)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(TextNombre)
        GroupBox1.Location = New Point(31, 21)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(302, 194)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Producto"
        ' 
        ' NumericPrecio
        ' 
        NumericPrecio.Location = New Point(6, 127)
        NumericPrecio.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        NumericPrecio.Name = "NumericPrecio"
        NumericPrecio.Size = New Size(272, 27)
        NumericPrecio.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 104)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 20)
        Label2.TabIndex = 3
        Label2.Text = "Precio"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 20)
        Label1.TabIndex = 1
        Label1.Text = "Nombre"
        ' 
        ' TextNombre
        ' 
        TextNombre.Location = New Point(6, 58)
        TextNombre.Name = "TextNombre"
        TextNombre.Size = New Size(272, 27)
        TextNombre.TabIndex = 0
        ' 
        ' ButtonAgregar
        ' 
        ButtonAgregar.Location = New Point(108, 221)
        ButtonAgregar.Name = "ButtonAgregar"
        ButtonAgregar.Size = New Size(148, 29)
        ButtonAgregar.TabIndex = 3
        ButtonAgregar.Text = "Agregar producto"
        ButtonAgregar.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' ProductoForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(368, 277)
        Controls.Add(ButtonAgregar)
        Controls.Add(GroupBox1)
        Name = "ProductoForm"
        Text = "Formulario de producto"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(NumericPrecio, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonAgregar As Button
    Friend WithEvents NumericPrecio As NumericUpDown
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
