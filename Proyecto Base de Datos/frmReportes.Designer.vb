<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportes
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSearchJobs = New System.Windows.Forms.Button()
        Me.cbJob = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSearchDepartments = New System.Windows.Forms.Button()
        Me.cbDepartment = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnSearchEndDate = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnClean = New System.Windows.Forms.Button()
        Me.dataGridViewReportes = New System.Windows.Forms.DataGridView()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dataGridViewReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearchJobs)
        Me.GroupBox1.Controls.Add(Me.cbJob)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(273, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda de Empleados por Empleo"
        '
        'btnSearchJobs
        '
        Me.btnSearchJobs.Location = New System.Drawing.Point(155, 36)
        Me.btnSearchJobs.Name = "btnSearchJobs"
        Me.btnSearchJobs.Size = New System.Drawing.Size(112, 23)
        Me.btnSearchJobs.TabIndex = 1
        Me.btnSearchJobs.Text = "Buscar"
        Me.btnSearchJobs.UseVisualStyleBackColor = True
        '
        'cbJob
        '
        Me.cbJob.FormattingEnabled = True
        Me.cbJob.Location = New System.Drawing.Point(6, 36)
        Me.cbJob.Name = "cbJob"
        Me.cbJob.Size = New System.Drawing.Size(143, 23)
        Me.cbJob.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSearchDepartments)
        Me.GroupBox2.Controls.Add(Me.cbDepartment)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(273, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Busqueda de Empleados por Departamento"
        '
        'btnSearchDepartments
        '
        Me.btnSearchDepartments.Location = New System.Drawing.Point(155, 45)
        Me.btnSearchDepartments.Name = "btnSearchDepartments"
        Me.btnSearchDepartments.Size = New System.Drawing.Size(112, 23)
        Me.btnSearchDepartments.TabIndex = 2
        Me.btnSearchDepartments.Text = "Buscar"
        Me.btnSearchDepartments.UseVisualStyleBackColor = True
        '
        'cbDepartment
        '
        Me.cbDepartment.FormattingEnabled = True
        Me.cbDepartment.Location = New System.Drawing.Point(6, 46)
        Me.cbDepartment.Name = "cbDepartment"
        Me.cbDepartment.Size = New System.Drawing.Size(143, 23)
        Me.cbDepartment.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnSearchEndDate)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 224)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(273, 100)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Busqueda de empleados dados de baja"
        '
        'btnSearchEndDate
        '
        Me.btnSearchEndDate.Location = New System.Drawing.Point(6, 34)
        Me.btnSearchEndDate.Name = "btnSearchEndDate"
        Me.btnSearchEndDate.Size = New System.Drawing.Size(261, 47)
        Me.btnSearchEndDate.TabIndex = 2
        Me.btnSearchEndDate.Text = "Buscar"
        Me.btnSearchEndDate.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnClean)
        Me.GroupBox4.Controls.Add(Me.dataGridViewReportes)
        Me.GroupBox4.Location = New System.Drawing.Point(291, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(494, 373)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Reporte"
        '
        'btnClean
        '
        Me.btnClean.Location = New System.Drawing.Point(6, 318)
        Me.btnClean.Name = "btnClean"
        Me.btnClean.Size = New System.Drawing.Size(482, 55)
        Me.btnClean.TabIndex = 5
        Me.btnClean.Text = "Limpiar Reporte"
        Me.btnClean.UseVisualStyleBackColor = True
        '
        'dataGridViewReportes
        '
        Me.dataGridViewReportes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dataGridViewReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridViewReportes.Location = New System.Drawing.Point(6, 22)
        Me.dataGridViewReportes.Name = "dataGridViewReportes"
        Me.dataGridViewReportes.RowTemplate.Height = 25
        Me.dataGridViewReportes.Size = New System.Drawing.Size(482, 290)
        Me.dataGridViewReportes.TabIndex = 0
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(12, 330)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(273, 55)
        Me.btnRegresar.TabIndex = 4
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'frmReportes
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(797, 397)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MdiChildrenMinimizedAnchorBottom = False
        Me.MinimizeBox = False
        Me.Name = "frmReportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dataGridViewReportes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnSearchJobs As Button
    Friend WithEvents cbJob As ComboBox
    Friend WithEvents btnSearchDepartments As Button
    Friend WithEvents cbDepartment As ComboBox
    Friend WithEvents btnSearchEndDate As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnClean As Button
    Friend WithEvents dataGridViewReportes As DataGridView
    Friend WithEvents btnRegresar As Button
End Class
