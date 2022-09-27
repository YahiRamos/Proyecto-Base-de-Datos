<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCountries
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSeleccionarOpcion = New System.Windows.Forms.Button()
        Me.cbOpciones = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnVerDatos = New System.Windows.Forms.Button()
        Me.txtRegionId = New System.Windows.Forms.TextBox()
        Me.txtCountryName = New System.Windows.Forms.TextBox()
        Me.txtCountryId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBackMenu = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione una opción"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSeleccionarOpcion)
        Me.GroupBox1.Controls.Add(Me.cbOpciones)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(284, 135)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Accion a Realizar"
        '
        'btnSeleccionarOpcion
        '
        Me.btnSeleccionarOpcion.Location = New System.Drawing.Point(80, 92)
        Me.btnSeleccionarOpcion.Name = "btnSeleccionarOpcion"
        Me.btnSeleccionarOpcion.Size = New System.Drawing.Size(128, 37)
        Me.btnSeleccionarOpcion.TabIndex = 2
        Me.btnSeleccionarOpcion.Text = "Seleccionar"
        Me.btnSeleccionarOpcion.UseVisualStyleBackColor = True
        '
        'cbOpciones
        '
        Me.cbOpciones.FormattingEnabled = True
        Me.cbOpciones.Items.AddRange(New Object() {"Agregar Registro", "Modificar Registro", "Ver Registro", "Eliminar Registro"})
        Me.cbOpciones.Location = New System.Drawing.Point(151, 31)
        Me.cbOpciones.Name = "cbOpciones"
        Me.cbOpciones.Size = New System.Drawing.Size(121, 23)
        Me.cbOpciones.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.btnModificar)
        Me.GroupBox2.Controls.Add(Me.btnRegistrar)
        Me.GroupBox2.Controls.Add(Me.btnVerDatos)
        Me.GroupBox2.Controls.Add(Me.txtRegionId)
        Me.GroupBox2.Controls.Add(Me.txtCountryName)
        Me.GroupBox2.Controls.Add(Me.txtCountryId)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 153)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(284, 242)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Campos de Datos"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(80, 203)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(128, 33)
        Me.btnEliminar.TabIndex = 9
        Me.btnEliminar.Text = "Eliminar Datos"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(80, 203)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(128, 33)
        Me.btnModificar.TabIndex = 8
        Me.btnModificar.Text = "Modificar Datos"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(80, 203)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(128, 33)
        Me.btnRegistrar.TabIndex = 7
        Me.btnRegistrar.Text = "Registrar Datos"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'btnVerDatos
        '
        Me.btnVerDatos.Location = New System.Drawing.Point(80, 203)
        Me.btnVerDatos.Name = "btnVerDatos"
        Me.btnVerDatos.Size = New System.Drawing.Size(128, 33)
        Me.btnVerDatos.TabIndex = 6
        Me.btnVerDatos.Text = "Ver Datos"
        Me.btnVerDatos.UseVisualStyleBackColor = True
        '
        'txtRegionId
        '
        Me.txtRegionId.Location = New System.Drawing.Point(108, 132)
        Me.txtRegionId.Name = "txtRegionId"
        Me.txtRegionId.Size = New System.Drawing.Size(164, 23)
        Me.txtRegionId.TabIndex = 5
        '
        'txtCountryName
        '
        Me.txtCountryName.Location = New System.Drawing.Point(108, 84)
        Me.txtCountryName.Name = "txtCountryName"
        Me.txtCountryName.Size = New System.Drawing.Size(164, 23)
        Me.txtCountryName.TabIndex = 4
        '
        'txtCountryId
        '
        Me.txtCountryId.Location = New System.Drawing.Point(108, 40)
        Me.txtCountryId.Name = "txtCountryId"
        Me.txtCountryId.Size = New System.Drawing.Size(164, 23)
        Me.txtCountryId.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Region ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Country Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Country ID"
        '
        'btnBackMenu
        '
        Me.btnBackMenu.Location = New System.Drawing.Point(75, 416)
        Me.btnBackMenu.Name = "btnBackMenu"
        Me.btnBackMenu.Size = New System.Drawing.Size(160, 33)
        Me.btnBackMenu.TabIndex = 6
        Me.btnBackMenu.Text = "Regresar al Menu"
        Me.btnBackMenu.UseVisualStyleBackColor = True
        '
        'frmCountries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 461)
        Me.Controls.Add(Me.btnBackMenu)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmCountries"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Countries"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSeleccionarOpcion As Button
    Friend WithEvents cbOpciones As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtRegionId As TextBox
    Friend WithEvents txtCountryName As TextBox
    Friend WithEvents txtCountryId As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnVerDatos As Button
    Friend WithEvents btnBackMenu As Button
    Friend WithEvents btnEliminar As Button
End Class
