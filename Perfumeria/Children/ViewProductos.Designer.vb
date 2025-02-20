<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewProductos
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
        DataGridProductos = New DataGridView()
        Label1 = New Label()
        CType(DataGridProductos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridProductos
        ' 
        DataGridProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridProductos.Location = New Point(12, 12)
        DataGridProductos.Name = "DataGridProductos"
        DataGridProductos.RowHeadersWidth = 51
        DataGridProductos.Size = New Size(674, 393)
        DataGridProductos.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 421)
        Label1.Name = "Label1"
        Label1.Size = New Size(170, 20)
        Label1.TabIndex = 1
        Label1.Text = "Dé click sobre una celda"
        ' 
        ' ViewProductos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(698, 450)
        Controls.Add(Label1)
        Controls.Add(DataGridProductos)
        Name = "ViewProductos"
        Text = "Lista de productos"
        CType(DataGridProductos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridProductos As DataGridView
    Friend WithEvents Label1 As Label
End Class
