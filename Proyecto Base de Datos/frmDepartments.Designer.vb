<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepartments
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
        Me.btnBackMenu = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtLocationId = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnVerDatos = New System.Windows.Forms.Button()
        Me.txtManagerId = New System.Windows.Forms.TextBox()
        Me.txtDepartmentName = New System.Windows.Forms.TextBox()
        Me.txtDepartmentId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSeleccionarOpcion = New System.Windows.Forms.Button()
        Me.cbOpciones = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBackMenu
        '
        Me.btnBackMenu.Location = New System.Drawing.Point(77, 445)
        Me.btnBackMenu.Name = "btnBackMenu"
        Me.btnBackMenu.Size = New System.Drawing.Size(160, 33)
        Me.btnBackMenu.TabIndex = 18
        Me.btnBackMenu.Text = "Regresar al Menu"
        Me.btnBackMenu.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtLocationId)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.btnModificar)
        Me.GroupBox2.Controls.Add(Me.btnRegistrar)
        Me.GroupBox2.Controls.Add(Me.btnVerDatos)
        Me.GroupBox2.Controls.Add(Me.txtManagerId)
        Me.GroupBox2.Controls.Add(Me.txtDepartmentName)
        Me.GroupBox2.Controls.Add(Me.txtDepartmentId)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 154)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(284, 273)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Campos de Datos"
        '
        'txtLocationId
        '
        Me.txtLocationId.Location = New System.Drawing.Point(115, 175)
        Me.txtLocationId.Name = "txtLocationId"
        Me.txtLocationId.Size = New System.Drawing.Size(157, 23)
        Me.txtLocationId.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Location ID"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(80, 224)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(128, 33)
        Me.btnEliminar.TabIndex = 9
        Me.btnEliminar.Text = "Eliminar Datos"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(80, 224)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(128, 33)
        Me.btnModificar.TabIndex = 8
        Me.btnModificar.Text = "Modificar Datos"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(80, 224)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(128, 33)
        Me.btnRegistrar.TabIndex = 7
        Me.btnRegistrar.Text = "Registrar Datos"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'btnVerDatos
        '
        Me.btnVerDatos.Location = New System.Drawing.Point(80, 224)
        Me.btnVerDatos.Name = "btnVerDatos"
        Me.btnVerDatos.Size = New System.Drawing.Size(128, 33)
        Me.btnVerDatos.TabIndex = 6
        Me.btnVerDatos.Text = "Ver Datos"
        Me.btnVerDatos.UseVisualStyleBackColor = True
        '
        'txtManagerId
        '
        Me.txtManagerId.Location = New System.Drawing.Point(115, 132)
        Me.txtManagerId.Name = "txtManagerId"
        Me.txtManagerId.Size = New System.Drawing.Size(157, 23)
        Me.txtManagerId.TabIndex = 5
        '
        'txtDepartmentName
        '
        Me.txtDepartmentName.Location = New System.Drawing.Point(115, 84)
        Me.txtDepartmentName.Name = "txtDepartmentName"
        Me.txtDepartmentName.Size = New System.Drawing.Size(157, 23)
        Me.txtDepartmentName.TabIndex = 4
        '
        'txtDepartmentId
        '
        Me.txtDepartmentId.Location = New System.Drawing.Point(115, 40)
        Me.txtDepartmentId.Name = "txtDepartmentId"
        Me.txtDepartmentId.Size = New System.Drawing.Size(157, 23)
        Me.txtDepartmentId.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Manager ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Department Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(84, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Department ID"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSeleccionarOpcion)
        Me.GroupBox1.Controls.Add(Me.cbOpciones)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(284, 135)
        Me.GroupBox1.TabIndex = 16
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione una opción"
        '
        'frmDepartments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 493)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnBackMenu)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmDepartments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Departments"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBackMenu As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtLocationId As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnVerDatos As Button
    Friend WithEvents txtManagerId As TextBox
    Friend WithEvents txtDepartmentName As TextBox
    Friend WithEvents txtDepartmentId As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSeleccionarOpcion As Button
    Friend WithEvents cbOpciones As ComboBox
    Friend WithEvents Label1 As Label
End Class
