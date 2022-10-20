Imports Oracle.ManagedDataAccess.Client

Public Class frmDepartments

    Dim userInterfaceUpdater As New UserInterfaceUpdater()
    Dim conection = New OracleConnection("Data Source = 127.0.0.1;User ID=hr;Password=hr;")
    Private Sub frmDepartments_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        userInterfaceUpdater.defaultConfigFrmDepartments()
    End Sub

    Private Sub btnBackMenu_Click(sender As Object, e As EventArgs) Handles btnBackMenu.Click
        Close()
        menuPrincipal.Visible = True
    End Sub

    Private Sub btnClean_Click(sender As Object, e As EventArgs) Handles btnClean.Click
        userInterfaceUpdater.defaultConfigFrmDepartments()
        conection.Close
    End Sub

    Private Sub btnSeleccionarOpcion_Click(sender As Object, e As EventArgs) Handles btnSeleccionarOpcion.Click
        userInterfaceUpdater.defaultConfigFrmDepartments()
        userInterfaceUpdater.selectionButtonConfigFrmDepartments()
    End Sub

    Private Sub btnVerDatos_Click(sender As Object, e As EventArgs) Handles btnVerDatos.Click
        Dim command = New OracleCommand("SELECT * FROM departments WHERE department_id=" & txtDepartmentId.Text, conection)
        command.Parameters.Add("department_id", txtDepartmentId.Text)
        conection.Open
        Dim dataReader As OracleDataReader
        dataReader = command.ExecuteReader
        If dataReader.Read Then
            txtDepartmentName.Text = dataReader.GetValue("department_name").ToString
            txtManagerId.Text = dataReader.GetValue("manager_id").ToString
            txtLocationId.Text = dataReader.GetValue("location_id").ToString
        End If
        If txtDepartmentName.Text = "" Then
            MessageBox.Show("Datos no encontrados")
        Else
            If cbOpciones.SelectedItem.ToString.Equals("Modificar Registro") Then
                btnVerDatos.Visible = False
                btnModificar.Visible = True
                txtDepartmentName.Enabled = True
                txtLocationId.Enabled = True
                txtManagerId.Enabled = True
                MessageBox.Show("Datos encontrados", "Actualizar Registro")
            End If
        End If
        conection.Close

    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        conection.Open
        Dim command = New OracleCommand("INSERT INTO departments(department_id,department_name,manager_id,location_id) VALUES(" & txtDepartmentId.Text & ",'" & txtDepartmentName.Text & "'," & txtManagerId.Text & "," & txtLocationId.Text & ")", conection)
        command.ExecuteNonQuery()
        MessageBox.Show("Registro agregado correctamente")
        conection.Close
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim command As OracleCommand
        conection.Open
        Try
            command = New OracleCommand("UPDATE departments SET department_name='" & txtDepartmentName.Text & "',manager_id=" & txtManagerId.Text & ",location_id=" & txtLocationId.Text & "WHERE department_id=" & txtDepartmentId.Text, conection)
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
        Dim command = New OracleCommand("SELECT * FROM departments WHERE department_id=" & txtDepartmentId.Text, conection)
        command.Parameters.Add("department_id", txtDepartmentId.Text)
        conection.Open
        Dim dataReader As OracleDataReader
        dataReader = command.ExecuteReader
        If dataReader.Read Then
            txtDepartmentName.Text = dataReader.GetValue("department_name").ToString
            txtManagerId.Text = dataReader.GetValue("manager_id").ToString
            txtLocationId.Text = dataReader.GetValue("location_id").ToString
        End If
        If txtDepartmentName.Text = "" Then
            MessageBox.Show("Datos no encontrados")
        Else
            Dim selection As DialogResult = MessageBox.Show("Realmente desea eliminar a: " & txtDepartmentName.Text, "Eliminar", MessageBoxButtons.YesNoCancel)
            If selection = DialogResult.Yes Then
                Try
                    command = New OracleCommand("DELETE FROM departments WHERE department_id=" & txtDepartmentId.Text, conection)
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

    Private Sub txtDepartmentId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDepartmentId.KeyPress
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

    Private Sub txtLocationId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLocationId.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Solo Puede digitar numeros en este campo", "Error de Tipo")
        End If
    End Sub
End Class