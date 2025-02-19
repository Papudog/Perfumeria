<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        Panel1 = New Panel()
        Label4 = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        ButtonIniciar = New Button()
        GroupBox1 = New GroupBox()
        TextContra = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        TextNombre = New TextBox()
        ErrorProvider1 = New ErrorProvider(components)
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.HotPink
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(392, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(410, 506)
        Panel1.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 20F)
        Label4.ForeColor = Color.AliceBlue
        Label4.Location = New Point(43, 66)
        Label4.Name = "Label4"
        Label4.Size = New Size(328, 46)
        Label4.TabIndex = 7
        Label4.Text = "Perfumeria Los Dogs"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.login_logo
        PictureBox1.Location = New Point(23, 180)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(369, 291)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F)
        Label1.Location = New Point(77, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(228, 32)
        Label1.TabIndex = 2
        Label1.Text = "Bienvenid@ usuario"
        ' 
        ' ButtonIniciar
        ' 
        ButtonIniciar.Location = New Point(121, 375)
        ButtonIniciar.Name = "ButtonIniciar"
        ButtonIniciar.Size = New Size(140, 29)
        ButtonIniciar.TabIndex = 3
        ButtonIniciar.Text = "Iniciar sesión"
        ButtonIniciar.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextContra)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(TextNombre)
        GroupBox1.Location = New Point(15, 163)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(363, 160)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        GroupBox1.Text = "Datos de usuario"
        ' 
        ' TextContra
        ' 
        TextContra.Location = New Point(182, 100)
        TextContra.Name = "TextContra"
        TextContra.Size = New Size(159, 27)
        TextContra.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(29, 103)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 20)
        Label3.TabIndex = 2
        Label3.Text = "Contraseña"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(29, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 20)
        Label2.TabIndex = 1
        Label2.Text = "Nombre"
        ' 
        ' TextNombre
        ' 
        TextNombre.Location = New Point(182, 50)
        TextNombre.Name = "TextNombre"
        TextNombre.Size = New Size(159, 27)
        TextNombre.TabIndex = 0
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' LoginView
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 504)
        Controls.Add(GroupBox1)
        Controls.Add(ButtonIniciar)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Name = "LoginView"
        Text = "Inicio de sesión"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonIniciar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextNombre As TextBox
    Friend WithEvents TextContra As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider

End Class
