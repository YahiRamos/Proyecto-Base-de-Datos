<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployees
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnBackMenu = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtHireDate = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDepartmentId = New System.Windows.Forms.TextBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtManagerId = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCommissionPct = New System.Windows.Forms.TextBox()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.txtJobId = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnVerDatos = New System.Windows.Forms.Button()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtEmployeeId = New System.Windows.Forms.TextBox()
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
        Me.btnBackMenu.Location = New System.Drawing.Point(251, 448)
        Me.btnBackMenu.Name = "btnBackMenu"
        Me.btnBackMenu.Size = New System.Drawing.Size(160, 33)
        Me.btnBackMenu.TabIndex = 21
        Me.btnBackMenu.Text = "Regresar al Menu"
        Me.btnBackMenu.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtHireDate)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtDepartmentId)
        Me.GroupBox2.Controls.Add(Me.btnModificar)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtManagerId)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtCommissionPct)
        Me.GroupBox2.Controls.Add(Me.txtSalary)
        Me.GroupBox2.Controls.Add(Me.txtJobId)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtPhoneNumber)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtEmail)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.btnRegistrar)
        Me.GroupBox2.Controls.Add(Me.btnVerDatos)
        Me.GroupBox2.Controls.Add(Me.txtLastName)
        Me.GroupBox2.Controls.Add(Me.txtFirstName)
        Me.GroupBox2.Controls.Add(Me.txtEmployeeId)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 98)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(610, 330)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Campos de Datos"
        '
        'txtHireDate
        '
        Me.txtHireDate.Location = New System.Drawing.Point(115, 272)
        Me.txtHireDate.Name = "txtHireDate"
        Me.txtHireDate.Size = New System.Drawing.Size(157, 23)
        Me.txtHireDate.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 280)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 15)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Hire Date"
        '
        'txtDepartmentId
        '
        Me.txtDepartmentId.Location = New System.Drawing.Point(447, 223)
        Me.txtDepartmentId.Name = "txtDepartmentId"
        Me.txtDepartmentId.Size = New System.Drawing.Size(157, 23)
        Me.txtDepartmentId.TabIndex = 23
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(447, 272)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(157, 52)
        Me.btnModificar.TabIndex = 8
        Me.btnModificar.Text = "Modificar Datos"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(338, 231)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 15)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Department ID"
        '
        'txtManagerId
        '
        Me.txtManagerId.Location = New System.Drawing.Point(447, 175)
        Me.txtManagerId.Name = "txtManagerId"
        Me.txtManagerId.Size = New System.Drawing.Size(157, 23)
        Me.txtManagerId.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(338, 183)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 15)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Manager ID"
        '
        'txtCommissionPct
        '
        Me.txtCommissionPct.Location = New System.Drawing.Point(447, 132)
        Me.txtCommissionPct.Name = "txtCommissionPct"
        Me.txtCommissionPct.Size = New System.Drawing.Size(157, 23)
        Me.txtCommissionPct.TabIndex = 19
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(447, 84)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(157, 23)
        Me.txtSalary.TabIndex = 18
        '
        'txtJobId
        '
        Me.txtJobId.Location = New System.Drawing.Point(447, 40)
        Me.txtJobId.Name = "txtJobId"
        Me.txtJobId.Size = New System.Drawing.Size(157, 23)
        Me.txtJobId.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(338, 140)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 15)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Commission Pct"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(338, 92)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 15)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Salary"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(338, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label11.Size = New System.Drawing.Size(39, 15)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Job ID"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(115, 223)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(157, 23)
        Me.txtPhoneNumber.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Phone Number"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(115, 175)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(157, 23)
        Me.txtEmail.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "E-mail"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(447, 272)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(157, 52)
        Me.btnEliminar.TabIndex = 9
        Me.btnEliminar.Text = "Eliminar Datos"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(447, 272)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(157, 52)
        Me.btnRegistrar.TabIndex = 7
        Me.btnRegistrar.Text = "Registrar Datos"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'btnVerDatos
        '
        Me.btnVerDatos.Location = New System.Drawing.Point(447, 272)
        Me.btnVerDatos.Name = "btnVerDatos"
        Me.btnVerDatos.Size = New System.Drawing.Size(157, 52)
        Me.btnVerDatos.TabIndex = 6
        Me.btnVerDatos.Text = "Ver Datos"
        Me.btnVerDatos.UseVisualStyleBackColor = True
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(115, 132)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(157, 23)
        Me.txtLastName.TabIndex = 5
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(115, 84)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(157, 23)
        Me.txtFirstName.TabIndex = 4
        '
        'txtEmployeeId
        '
        Me.txtEmployeeId.Location = New System.Drawing.Point(115, 40)
        Me.txtEmployeeId.Name = "txtEmployeeId"
        Me.txtEmployeeId.Size = New System.Drawing.Size(157, 23)
        Me.txtEmployeeId.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(73, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Employee ID"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnClean)
        Me.GroupBox1.Controls.Add(Me.btnSeleccionarOpcion)
        Me.GroupBox1.Controls.Add(Me.cbOpciones)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(610, 78)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Accion a Realizar"
        '
        'btnClean
        '
        Me.btnClean.Location = New System.Drawing.Point(284, 23)
        Me.btnClean.Name = "btnClean"
        Me.btnClean.Size = New System.Drawing.Size(157, 37)
        Me.btnClean.TabIndex = 3
        Me.btnClean.Text = "Limpiar Campos"
        Me.btnClean.UseVisualStyleBackColor = True
        '
        'btnSeleccionarOpcion
        '
        Me.btnSeleccionarOpcion.Location = New System.Drawing.Point(447, 23)
        Me.btnSeleccionarOpcion.Name = "btnSeleccionarOpcion"
        Me.btnSeleccionarOpcion.Size = New System.Drawing.Size(157, 37)
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
        Me.GroupBox3.Location = New System.Drawing.Point(628, 14)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(462, 468)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de tabla"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(156, 424)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(171, 38)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "Refrescar"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'dataGridViewTable
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent
        Me.dataGridViewTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dataGridViewTable.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridViewTable.Location = New System.Drawing.Point(6, 22)
        Me.dataGridViewTable.Name = "dataGridViewTable"
        Me.dataGridViewTable.RowTemplate.Height = 25
        Me.dataGridViewTable.Size = New System.Drawing.Size(450, 392)
        Me.dataGridViewTable.TabIndex = 0
        '
        'frmEmployees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1102, 493)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnBackMenu)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmEmployees"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employees"
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
    Friend WithEvents txtHireDate As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtDepartmentId As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtManagerId As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCommissionPct As TextBox
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents txtJobId As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnVerDatos As Button
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtEmployeeId As TextBox
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
