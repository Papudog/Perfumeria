<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FacturaForm
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
        Label1 = New Label()
        TextCedula = New TextBox()
        ComboCliente = New ComboBox()
        GroupBox2 = New GroupBox()
        ListCanasta = New ListBox()
        ButtonQuitar = New Button()
        ButtonAgregar = New Button()
        ListDisponibles = New ListBox()
        Label2 = New Label()
        TextIVA = New TextBox()
        TextSub = New TextBox()
        Label3 = New Label()
        ButtonLimpiar = New Button()
        ButtonFacturar = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(TextCedula)
        GroupBox1.Controls.Add(ComboCliente)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(269, 151)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Cliente"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 20)
        Label1.TabIndex = 2
        Label1.Text = "Cédula"
        ' 
        ' TextCedula
        ' 
        TextCedula.Enabled = False
        TextCedula.Location = New Point(6, 100)
        TextCedula.Name = "TextCedula"
        TextCedula.Size = New Size(257, 27)
        TextCedula.TabIndex = 1
        ' 
        ' ComboCliente
        ' 
        ComboCliente.FormattingEnabled = True
        ComboCliente.Location = New Point(6, 35)
        ComboCliente.Name = "ComboCliente"
        ComboCliente.Size = New Size(257, 28)
        ComboCliente.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(ListCanasta)
        GroupBox2.Controls.Add(ButtonQuitar)
        GroupBox2.Controls.Add(ButtonAgregar)
        GroupBox2.Controls.Add(ListDisponibles)
        GroupBox2.Location = New Point(298, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(250, 370)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Productos"
        ' 
        ' ListCanasta
        ' 
        ListCanasta.FormattingEnabled = True
        ListCanasta.Location = New Point(6, 235)
        ListCanasta.Name = "ListCanasta"
        ListCanasta.Size = New Size(238, 124)
        ListCanasta.TabIndex = 3
        ' 
        ' ButtonQuitar
        ' 
        ButtonQuitar.Location = New Point(129, 182)
        ButtonQuitar.Name = "ButtonQuitar"
        ButtonQuitar.Size = New Size(94, 29)
        ButtonQuitar.TabIndex = 2
        ButtonQuitar.Text = "^"
        ButtonQuitar.UseVisualStyleBackColor = True
        ' 
        ' ButtonAgregar
        ' 
        ButtonAgregar.Location = New Point(29, 182)
        ButtonAgregar.Name = "ButtonAgregar"
        ButtonAgregar.Size = New Size(94, 29)
        ButtonAgregar.TabIndex = 1
        ButtonAgregar.Text = "v"
        ButtonAgregar.UseVisualStyleBackColor = True
        ' 
        ' ListDisponibles
        ' 
        ListDisponibles.FormattingEnabled = True
        ListDisponibles.Location = New Point(6, 35)
        ListDisponibles.Name = "ListDisponibles"
        ListDisponibles.Size = New Size(238, 124)
        ListDisponibles.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(18, 247)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 20)
        Label2.TabIndex = 2
        Label2.Text = "Total con IVA "
        ' 
        ' TextIVA
        ' 
        TextIVA.Enabled = False
        TextIVA.Location = New Point(18, 270)
        TextIVA.Name = "TextIVA"
        TextIVA.Size = New Size(257, 27)
        TextIVA.TabIndex = 3
        ' 
        ' TextSub
        ' 
        TextSub.Enabled = False
        TextSub.Location = New Point(18, 196)
        TextSub.Name = "TextSub"
        TextSub.Size = New Size(257, 27)
        TextSub.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(18, 173)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 20)
        Label3.TabIndex = 4
        Label3.Text = "Subtotal"
        ' 
        ' ButtonLimpiar
        ' 
        ButtonLimpiar.Location = New Point(87, 351)
        ButtonLimpiar.Name = "ButtonLimpiar"
        ButtonLimpiar.Size = New Size(94, 29)
        ButtonLimpiar.TabIndex = 6
        ButtonLimpiar.Text = "Limpiar"
        ButtonLimpiar.UseVisualStyleBackColor = True
        ' 
        ' ButtonFacturar
        ' 
        ButtonFacturar.Location = New Point(187, 351)
        ButtonFacturar.Name = "ButtonFacturar"
        ButtonFacturar.Size = New Size(94, 29)
        ButtonFacturar.TabIndex = 7
        ButtonFacturar.Text = "Facturar"
        ButtonFacturar.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' FacturaForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(560, 392)
        Controls.Add(ButtonFacturar)
        Controls.Add(ButtonLimpiar)
        Controls.Add(TextSub)
        Controls.Add(Label3)
        Controls.Add(TextIVA)
        Controls.Add(Label2)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "FacturaForm"
        Text = "Formulario de facturación"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboCliente As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextCedula As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ButtonAgregar As Button
    Friend WithEvents ListDisponibles As ListBox
    Friend WithEvents ListCanasta As ListBox
    Friend WithEvents ButtonQuitar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextIVA As TextBox
    Friend WithEvents TextSub As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonLimpiar As Button
    Friend WithEvents ButtonFacturar As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
