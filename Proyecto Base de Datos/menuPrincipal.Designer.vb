<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menuPrincipal))
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnModificarDatos = New System.Windows.Forms.Button()
        Me.btnEliminarDatos = New System.Windows.Forms.Button()
        Me.btnVisualizarDatos = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(12, 12)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(195, 57)
        Me.btnRegistrar.TabIndex = 0
        Me.btnRegistrar.Text = "Registro de datos"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'btnModificarDatos
        '
        Me.btnModificarDatos.Location = New System.Drawing.Point(12, 75)
        Me.btnModificarDatos.Name = "btnModificarDatos"
        Me.btnModificarDatos.Size = New System.Drawing.Size(195, 57)
        Me.btnModificarDatos.TabIndex = 1
        Me.btnModificarDatos.Text = "Modificar Datos"
        Me.btnModificarDatos.UseVisualStyleBackColor = True
        '
        'btnEliminarDatos
        '
        Me.btnEliminarDatos.Location = New System.Drawing.Point(12, 138)
        Me.btnEliminarDatos.Name = "btnEliminarDatos"
        Me.btnEliminarDatos.Size = New System.Drawing.Size(195, 57)
        Me.btnEliminarDatos.TabIndex = 2
        Me.btnEliminarDatos.Text = "Eliminar Datos"
        Me.btnEliminarDatos.UseVisualStyleBackColor = True
        '
        'btnVisualizarDatos
        '
        Me.btnVisualizarDatos.Location = New System.Drawing.Point(12, 201)
        Me.btnVisualizarDatos.Name = "btnVisualizarDatos"
        Me.btnVisualizarDatos.Size = New System.Drawing.Size(195, 57)
        Me.btnVisualizarDatos.TabIndex = 3
        Me.btnVisualizarDatos.Text = "Visualizar Datos"
        Me.btnVisualizarDatos.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(12, 264)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(195, 57)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'menuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(218, 336)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnVisualizarDatos)
        Me.Controls.Add(Me.btnEliminarDatos)
        Me.Controls.Add(Me.btnModificarDatos)
        Me.Controls.Add(Me.btnRegistrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "menuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnModificarDatos As Button
    Friend WithEvents btnEliminarDatos As Button
    Friend WithEvents btnVisualizarDatos As Button
    Friend WithEvents btnSalir As Button
End Class
