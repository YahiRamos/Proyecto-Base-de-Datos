<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLocations
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnBackMenu = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCountryId = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtStateProvince = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnVerDatos = New System.Windows.Forms.Button()
        Me.txtPostalCode = New System.Windows.Forms.TextBox()
        Me.txtStreetAddress = New System.Windows.Forms.TextBox()
        Me.txtLocationId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnClean = New System.Windows.Forms.Button()
        Me.btnSeleccionarOpcion = New System.Windows.Forms.Button()
        Me.cbOpciones = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.dataGridViewTable = New System.Windows.Forms.DataGridView()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dataGridViewTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBackMenu
        '
        Me.btnBackMenu.Location = New System.Drawing.Point(76, 539)
        Me.btnBackMenu.Name = "btnBackMenu"
        Me.btnBackMenu.Size = New System.Drawing.Size(160, 33)
        Me.btnBackMenu.TabIndex = 12
        Me.btnBackMenu.Text = "Regresar al Menu"
        Me.btnBackMenu.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCountryId)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtStateProvince)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtCity)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.btnModificar)
        Me.GroupBox2.Controls.Add(Me.btnRegistrar)
        Me.GroupBox2.Controls.Add(Me.btnVerDatos)
        Me.GroupBox2.Controls.Add(Me.txtPostalCode)
        Me.GroupBox2.Controls.Add(Me.txtStreetAddress)
        Me.GroupBox2.Controls.Add(Me.txtLocationId)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 153)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(284, 372)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Campos de Datos"
        '
        'txtCountryId
        '
        Me.txtCountryId.Location = New System.Drawing.Point(108, 272)
        Me.txtCountryId.Name = "txtCountryId"
        Me.txtCountryId.Size = New System.Drawing.Size(164, 23)
        Me.txtCountryId.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 280)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Country ID"
        '
        'txtStateProvince
        '
        Me.txtStateProvince.Location = New System.Drawing.Point(108, 220)
        Me.txtStateProvince.Name = "txtStateProvince"
        Me.txtStateProvince.Size = New System.Drawing.Size(164, 23)
        Me.txtStateProvince.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "State Province"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(108, 175)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(164, 23)
        Me.txtCity.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "City"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(80, 331)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(128, 33)
        Me.btnEliminar.TabIndex = 9
        Me.btnEliminar.Text = "Eliminar Datos"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(80, 331)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(128, 33)
        Me.btnModificar.TabIndex = 8
        Me.btnModificar.Text = "Modificar Datos"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(80, 331)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(128, 33)
        Me.btnRegistrar.TabIndex = 7
        Me.btnRegistrar.Text = "Registrar Datos"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'btnVerDatos
        '
        Me.btnVerDatos.Location = New System.Drawing.Point(80, 331)
        Me.btnVerDatos.Name = "btnVerDatos"
        Me.btnVerDatos.Size = New System.Drawing.Size(128, 33)
        Me.btnVerDatos.TabIndex = 6
        Me.btnVerDatos.Text = "Ver Datos"
        Me.btnVerDatos.UseVisualStyleBackColor = True
        '
        'txtPostalCode
        '
        Me.txtPostalCode.Location = New System.Drawing.Point(108, 132)
        Me.txtPostalCode.Name = "txtPostalCode"
        Me.txtPostalCode.Size = New System.Drawing.Size(164, 23)
        Me.txtPostalCode.TabIndex = 5
        '
        'txtStreetAddress
        '
        Me.txtStreetAddress.Location = New System.Drawing.Point(108, 84)
        Me.txtStreetAddress.Name = "txtStreetAddress"
        Me.txtStreetAddress.Size = New System.Drawing.Size(164, 23)
        Me.txtStreetAddress.TabIndex = 4
        '
        'txtLocationId
        '
        Me.txtLocationId.Location = New System.Drawing.Point(108, 40)
        Me.txtLocationId.Name = "txtLocationId"
        Me.txtLocationId.Size = New System.Drawing.Size(164, 23)
        Me.txtLocationId.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Postal Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Street Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Location ID"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnClean)
        Me.GroupBox1.Controls.Add(Me.btnSeleccionarOpcion)
        Me.GroupBox1.Controls.Add(Me.cbOpciones)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(284, 135)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Accion a Realizar"
        '
        'btnClean
        '
        Me.btnClean.Location = New System.Drawing.Point(6, 92)
        Me.btnClean.Name = "btnClean"
        Me.btnClean.Size = New System.Drawing.Size(128, 37)
        Me.btnClean.TabIndex = 3
        Me.btnClean.Text = "Limpiar Campos"
        Me.btnClean.UseVisualStyleBackColor = True
        '
        'btnSeleccionarOpcion
        '
        Me.btnSeleccionarOpcion.Location = New System.Drawing.Point(144, 92)
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnRefresh)
        Me.GroupBox3.Controls.Add(Me.dataGridViewTable)
        Me.GroupBox3.Location = New System.Drawing.Point(302, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(333, 567)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de tabla"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(85, 522)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(171, 38)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "Refrescar"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'dataGridViewTable
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent
        Me.dataGridViewTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dataGridViewTable.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridViewTable.Location = New System.Drawing.Point(6, 22)
        Me.dataGridViewTable.Name = "dataGridViewTable"
        Me.dataGridViewTable.RowTemplate.Height = 25
        Me.dataGridViewTable.Size = New System.Drawing.Size(321, 483)
        Me.dataGridViewTable.TabIndex = 0
        '
        'frmLocations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 584)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnBackMenu)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmLocations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Locations"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dataGridViewTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBackMenu As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtCountryId As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtStateProvince As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnVerDatos As Button
    Friend WithEvents txtPostalCode As TextBox
    Friend WithEvents txtStreetAddress As TextBox
    Friend WithEvents txtLocationId As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSeleccionarOpcion As Button
    Friend WithEvents cbOpciones As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClean As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents dataGridViewTable As DataGridView
End Class
