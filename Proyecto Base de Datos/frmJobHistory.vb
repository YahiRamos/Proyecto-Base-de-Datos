Imports Oracle.ManagedDataAccess.Client

Public Class frmJobHistory

    Dim userInterfaceUpdater As New UserInterfaceUpdater()
    Dim conection = New OracleConnection("Data Source = 127.0.0.1;User ID=hr;Password=hr;")
    Private Sub frmJobHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userInterfaceUpdater.defaultConfigFrmJobHistory()
        conection.Open
        Dim command = New OracleCommand("SELECT * FROM job_history", conection)
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
        cbJobId.DisplayMember = "job_id"
        cbJobId.ValueMember = "job_id"

        command = New OracleCommand("SELECT * FROM departments", conection)
        adapter = New OracleDataAdapter
        adapter.SelectCommand = command
        data = New DataSet
        adapter.Fill(data)
        cbDepartmentId.DataSource = data.Tables(0)
        cbDepartmentId.DisplayMember = "department_id"
        cbDepartmentId.ValueMember = "department_id"

        conection.Close
    End Sub
    Private Sub btnBackMenu_Click(sender As Object, e As EventArgs) Handles btnBackMenu.Click
        Close()
        menuPrincipal.Visible = True
    End Sub

    Private Sub btnClean_Click(sender As Object, e As EventArgs) Handles btnClean.Click
        userInterfaceUpdater.defaultConfigFrmJobHistory()
        conection.Close
    End Sub

    Private Sub btnSeleccionarOpcion_Click(sender As Object, e As EventArgs) Handles btnSeleccionarOpcion.Click
        userInterfaceUpdater.defaultConfigFrmJobHistory()
        userInterfaceUpdater.selectionButtonConfigFrmJobHistory()
    End Sub

    Private Sub btnVerDatos_Click(sender As Object, e As EventArgs) Handles btnVerDatos.Click
        Dim command = New OracleCommand("SELECT * FROM job_history WHERE employee_id=" & txtEmployeeId.Text & "AND start_date='" & txtStartDate.Text & "'", conection)
        command.Parameters.Add("employee_id ", txtEmployeeId.Text)
        conection.Open
        Dim dataReader As OracleDataReader
        dataReader = command.ExecuteReader
        If dataReader.Read Then
            txtDepartmentId.Text = dataReader.GetValue("department_id").ToString
            txtEndDate.Text = dataReader.GetValue("end_date").ToString
            txtJobId.Text = dataReader.GetValue("job_id").ToString
        End If
        If txtDepartmentId.Text = "" And txtEndDate.Text = "" And txtJobId.Text = "" Then
            MessageBox.Show("Datos no encontrados")
        Else
            If cbOpciones.SelectedItem.ToString.Equals("Modificar Registro") Then
                btnVerDatos.Visible = False
                btnModificar.Visible = True
                cbDepartmentId.Visible = True
                txtEndDate.Enabled = True
                cbJobId.Visible = True
                MessageBox.Show("Datos encontrados", "Actualizar Registro")
            End If
        End If
        conection.Close
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        conection.Open
        Dim command = New OracleCommand("INSERT INTO job_history(employee_id,start_date,end_date,job_id,department_id) 
            VALUES(" & txtEmployeeId.Text & ",'" & txtStartDate.Text & "','" & txtEndDate.Text & "','" & cbJobId.Text & "'," & cbDepartmentId.Text & ")", conection)
        command.ExecuteNonQuery()
        MessageBox.Show("Registro agregado correctamente")
        conection.Close
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim command As OracleCommand
        conection.Open
        Try
            command = New OracleCommand("UPDATE job_history SET end_date='" & txtEndDate.Text & "',job_id='" & cbJobId.Text & "'
            ,department_id=" & cbDepartmentId.Text & " WHERE employee_id=" & txtEmployeeId.Text & " AND start_date='" & txtStartDate.Text & "'", conection)
            Dim dataAdapter = New OracleDataAdapter
            dataAdapter.UpdateCommand = command
            dataAdapter.UpdateCommand.ExecuteNonQuery()
            MessageBox.Show("Registro actualizado correctamente", "Actualizar Registro")
        Catch ex As Exception
            MessageBox.Show("Error al actualizar registro", "Actualizar Registro")
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim command = New OracleCommand("SELECT * FROM job_history WHERE employee_id=" & txtEmployeeId.Text & "AND start_date='" & txtStartDate.Text & "'", conection)
        command.Parameters.Add("employee_id ", txtEmployeeId.Text)
        conection.Open
        Dim dataReader As OracleDataReader
        dataReader = command.ExecuteReader
        If dataReader.Read Then
            txtDepartmentId.Text = dataReader.GetValue("department_id").ToString
            txtEndDate.Text = dataReader.GetValue("end_date").ToString
            txtJobId.Text = dataReader.GetValue("job_id").ToString
        End If
        If txtDepartmentId.Text = "" And txtEndDate.Text = "" And txtJobId.Text = "" Then
            MessageBox.Show("Datos no encontrados")
        Else
            Dim selection As DialogResult = MessageBox.Show("Realmente desea eliminar a: " & txtEmployeeId.Text, "Eliminar", MessageBoxButtons.YesNoCancel)
            If selection = DialogResult.Yes Then
                Try
                    command = New OracleCommand("DELETE FROM job_history WHERE employee_id=" & txtEmployeeId.Text & " AND start_date='" & txtStartDate.Text & "'", conection)
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

    Private Sub txtDepartmentId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDepartmentId.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Solo Puede digitar numeros en este campo", "Error de Tipo")
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        conection.Open
        Dim command = New OracleCommand("SELECT * FROM job_history", conection)
        Dim adapter = New OracleDataAdapter
        adapter.SelectCommand = command
        Dim dataTable = New DataTable
        adapter.Fill(dataTable)
        dataGridViewTable.DataSource = dataTable
        conection.Close
    End Sub
End Class