<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClienteChildForm
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
        TextNombre = New TextBox()
        Label1 = New Label()
        ButtonAgregar = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        GroupBox1.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextNombre)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(31, 21)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(302, 128)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Cliente"
        ' 
        ' TextNombre
        ' 
        TextNombre.Location = New Point(6, 61)
        TextNombre.Name = "TextNombre"
        TextNombre.Size = New Size(264, 27)
        TextNombre.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nombre"
        ' 
        ' ButtonAgregar
        ' 
        ButtonAgregar.Location = New Point(118, 193)
        ButtonAgregar.Name = "ButtonAgregar"
        ButtonAgregar.Size = New Size(128, 29)
        ButtonAgregar.TabIndex = 1
        ButtonAgregar.Text = "Agregar cliente"
        ButtonAgregar.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' ClienteChildForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(368, 277)
        Controls.Add(ButtonAgregar)
        Controls.Add(GroupBox1)
        Name = "ClienteChildForm"
        Text = "Formulario de cliente"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonAgregar As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
