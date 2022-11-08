Imports Oracle.ManagedDataAccess.Client

Public Class frmEmployees
    Private Function department_id() As String
        Return "SELECT department_id FROM departments WHERE department_name='" & cbDepartmentId.Text & "'"
    End Function
    Private Function job_id() As String
        Return "SELECT job_id FROM jobs WHERE job_title='" & cbJobId.Text & "'"
    End Function
    Dim userInterfaceUpdater As New UserInterfaceUpdater()
    Dim conection = New OracleConnection("Data Source = 127.0.0.1;User ID=hr;Password=hr;")
    Private Sub frmEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userInterfaceUpdater.defaultConfigFrmEmployees()
        conection.Open
        Dim command = New OracleCommand("SELECT * FROM employees", conection)
        Dim adapter = New OracleDataAdapter
        adapter.SelectCommand = command
        Dim dataTable = New DataTable
        adapter.Fill(dataTable)
        dataGridViewTable.DataSource = dataTable


        command = New OracleCommand("SELECT * FROM jobs", conection)
        adapter = New OracleDataAdapter
        adapter.SelectCommand = command
        Dim data = New DataSet
        adapter.Fill(data)
        cbJobId.DataSource = data.Tables(0)
        cbJobId.DisplayMember = "job_title"
        cbJobId.ValueMember = "job_title"

        command = New OracleCommand("SELECT * FROM departments", conection)
        adapter = New OracleDataAdapter
        adapter.SelectCommand = command
        data = New DataSet
        adapter.Fill(data)
        cbDepartmentId.DataSource = data.Tables(0)
        cbDepartmentId.DisplayMember = "department_name"
        cbDepartmentId.ValueMember = "department_name"
        conection.Close
    End Sub

    Private Sub btnBackMenu_Click(sender As Object, e As EventArgs) Handles btnBackMenu.Click
        Close()
        menuPrincipal.Visible = True
    End Sub

    Private Sub btnClean_Click(sender As Object, e As EventArgs) Handles btnClean.Click
        userInterfaceUpdater.defaultConfigFrmEmployees()
        conection.Close
    End Sub

    Private Sub btnSeleccionarOpcion_Click(sender As Object, e As EventArgs) Handles btnSeleccionarOpcion.Click
        userInterfaceUpdater.defaultConfigFrmEmployees()
        userInterfaceUpdater.selectionButtonConfigFrmEmployees()
    End Sub

    Private Sub btnVerDatos_Click(sender As Object, e As EventArgs) Handles btnVerDatos.Click
        Dim command = New OracleCommand("SELECT  EMPLOYEE_ID, FIRST_NAME, LAST_NAME, EMAIL ,PHONE_NUMBER, HIRE_DATE, JOB_TITLE, SALARY, COMMISSION_PCT, e.MANAGER_ID, DEPARTMENT_NAME
                                        FROM employees e,jobs j,departments d
                                        WHERE employee_id=" & txtEmployeeId.Text & "
                                        AND e.job_id=j.job_id
                                        AND e.department_id=d.department_id", conection)
        command.Parameters.Add("employee_id ", txtEmployeeId.Text)
        conection.Open
        Dim dataReader As OracleDataReader
        dataReader = command.ExecuteReader
        If dataReader.Read Then
            txtCommissionPct.Text = dataReader.GetValue("COMMISSION_PCT").ToString
            txtDepartmentId.Text = dataReader.GetValue("DEPARTMENT_NAME").ToString
            txtEmail.Text = dataReader.GetValue("EMAIL").ToString
            txtFirstName.Text = dataReader.GetValue("FIRST_NAME").ToString
            txtHireDate.Text = dataReader.GetValue("HIRE_DATE").ToString
            txtJobId.Text = dataReader.GetValue("JOB_TITLE").ToString
            txtLastName.Text = dataReader.GetValue("LAST_NAME").ToString
            txtManagerId.Text = dataReader.GetValue("MANAGER_ID").ToString
            txtPhoneNumber.Text = dataReader.GetValue("PHONE_NUMBER").ToString
            txtSalary.Text = dataReader.GetValue("SALARY").ToString
        End If
        If txtFirstName.Text = "" And txtLastName.Text = "" Then
            MessageBox.Show("Datos no enconrados")
        Else
            If cbOpciones.SelectedItem.ToString.Equals("Modificar Registro") Then
                btnVerDatos.Visible = False
                btnModificar.Visible = True
                txtCommissionPct.Enabled = True
                cbDepartmentId.Visible = True
                txtEmail.Enabled = True
                txtFirstName.Enabled = True
                txtHireDate.Enabled = True
                cbJobId.Visible = True
                txtLastName.Enabled = True
                txtManagerId.Enabled = True
                txtPhoneNumber.Enabled = True
                txtSalary.Enabled = True
                MessageBox.Show("Datos encontrados", "Actualizar Registro")
            End If
        End If
        conection.Close
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        conection.Open
        If txtCommissionPct.Text = "" Then
            txtCommissionPct.Text = 0
        End If
        Dim command = New OracleCommand("INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,job_id,salary,commission_pct,manager_id,department_id) 
            VALUES(" & txtEmployeeId.Text & ",'" & txtFirstName.Text & "','" & txtLastName.Text & "','" & txtEmail.Text & "',
            '" & txtPhoneNumber.Text & "','" & txtHireDate.Text & "',(" & job_id() & ")," & txtSalary.Text & "," & txtCommissionPct.Text & "," & txtManagerId.Text & ",
            (" & department_id() & "))", conection)
        command.ExecuteNonQuery()
        MessageBox.Show("Registro agregado correctamente")
        conection.Close
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim command As OracleCommand
        conection.Open
        If txtCommissionPct.Text = "" Then
            txtCommissionPct.Text = 0
        End If
        Try
            command = New OracleCommand("UPDATE employees SET first_name='" & txtFirstName.Text & "',last_name='" & txtLastName.Text & "',
                email='" & txtEmail.Text & "',phone_number='" & txtPhoneNumber.Text & "',hire_date='" & txtHireDate.Text & "',job_id=(" & job_id() & "),
                salary=" & txtSalary.Text & ",commission_pct=" & txtCommissionPct.Text & ",manager_id=" & txtManagerId.Text & ",
                department_id=(" & department_id() & ") WHERE employee_id=" & txtEmployeeId.Text, conection)
            Dim dataAdapter = New OracleDataAdapter
            dataAdapter.UpdateCommand = command
            dataAdapter.UpdateCommand.ExecuteNonQuery()
            MessageBox.Show("Registro actualizado correctamente", "Actualizar Registro")
        Catch ex As Exception
            MessageBox.Show("Error al actualizar registro", "Actualizar Registro")
        End Try
        conection.Close
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim command = New OracleCommand("SELECT * FROM employees WHERE employee_id=" & txtEmployeeId.Text, conection)
        command.Parameters.Add("employee_id ", txtEmployeeId.Text)
        conection.Open
        Dim dataReader As OracleDataReader
        dataReader = command.ExecuteReader
        If dataReader.Read Then
            txtCommissionPct.Text = dataReader.GetValue("COMMISSION_PCT").ToString
            txtDepartmentId.Text = dataReader.GetValue("DEPARTMENT_ID").ToString
            txtEmail.Text = dataReader.GetValue("EMAIL").ToString
            txtFirstName.Text = dataReader.GetValue("FIRST_NAME").ToString
            txtHireDate.Text = dataReader.GetValue("HIRE_DATE").ToString
            txtJobId.Text = dataReader.GetValue("JOB_ID").ToString
            txtLastName.Text = dataReader.GetValue("LAST_NAME").ToString
            txtManagerId.Text = dataReader.GetValue("MANAGER_ID").ToString
            txtPhoneNumber.Text = dataReader.GetValue("PHONE_NUMBER").ToString
            txtSalary.Text = dataReader.GetValue("SALARY").ToString
        End If
        If txtFirstName.Text = "" And txtLastName.Text = "" Then
            MessageBox.Show("Datos no enconrados")
        Else
            Dim selection As DialogResult = MessageBox.Show("Realmente desea eliminar a: " & txtFirstName.Text &
                              " " & txtLastName.Text, "Eliminar", MessageBoxButtons.YesNoCancel)
            If selection = DialogResult.Yes Then
                Try
                    command = New OracleCommand("DELETE FROM employees WHERE employee_id=" & txtEmployeeId.Text, conection)
                    Dim dataAdapter = New OracleDataAdapter
                    dataAdapter.DeleteCommand = command
                    dataAdapter.DeleteCommand.ExecuteNonQuery()
                    MessageBox.Show("El registro ha sido eliminado correctamente")
                Catch ex As Exception
                    MessageBox.Show("ERROR: El registro no ha podido eliminar")
                End Try
            Else
                MessageBox.Show("Operación cancelada")
            End If
        End If
        conection.Close
    End Sub

    Private Sub txtEmployeeId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmployeeId.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Solo Puede digitar numeros en este campo", "Error de Tipo")
        End If
    End Sub

    Private Sub txtSalary_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSalary.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Solo Puede digitar numeros en este campo", "Error de Tipo")
        End If
    End Sub

    Private Sub txtCommissionPct_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCommissionPct.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Solo Puede digitar numeros en este campo", "Error de Tipo")
        End If
    End Sub

    Private Sub txtManagerId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtManagerId.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Solo Puede digitar numeros en este campo", "Error de Tipo")
        End If
    End Sub

    Private Sub txtDepartmentId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDepartmentId.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Solo Puede digitar numeros en este campo", "Error de Tipo")
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        conection.Open
        Dim command = New OracleCommand("SELECT * FROM employees", conection)
        Dim adapter = New OracleDataAdapter
        adapter.SelectCommand = command
        Dim dataTable = New DataTable
        adapter.Fill(dataTable)
        dataGridViewTable.DataSource = dataTable
        conection.Close
    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        frmReportes.Visible = True
        Hide()
    End Sub
End Class