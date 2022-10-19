Imports Oracle.ManagedDataAccess.Client

Public Class frmLocations

    Dim userInterfaceUpdater As New UserInterfaceUpdater()
    Dim conection = New OracleConnection("Data Source = 127.0.0.1;User ID=hr;Password=hr;")
    Private Sub frmLocations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userInterfaceUpdater.defaultConfigFrmLocations()
    End Sub
    Private Sub btnBackMenu_Click(sender As Object, e As EventArgs) Handles btnBackMenu.Click
        Close()
        menuPrincipal.Visible = True
    End Sub

    Private Sub btnClean_Click(sender As Object, e As EventArgs) Handles btnClean.Click
        userInterfaceUpdater.defaultConfigFrmLocations()
        conection.Close
    End Sub

    Private Sub btnSeleccionarOpcion_Click(sender As Object, e As EventArgs) Handles btnSeleccionarOpcion.Click
        userInterfaceUpdater.defaultConfigFrmLocations()
        userInterfaceUpdater.selectionButtonConfigFrmLocations()
    End Sub

    Private Sub btnVerDatos_Click(sender As Object, e As EventArgs) Handles btnVerDatos.Click
        Dim command = New OracleCommand("SELECT * FROM locations WHERE location_id=" & txtLocationId.Text, conection)
        command.Parameters.Add("location_id", txtLocationId.Text)
        conection.Open
        Dim dataReader As OracleDataReader
        dataReader = command.ExecuteReader
        If dataReader.Read Then
            txtCity.Text = dataReader.GetValue("city").ToString
            txtCountryId.Text = dataReader.GetValue("country_id").ToString
            txtPostalCode.Text = dataReader.GetValue("postal_code").ToString
            txtStateProvince.Text = dataReader.GetValue("state_province").ToString
            txtStreetAddress.Text = dataReader.GetValue("street_address").ToString
        End If
        If txtCity.Text = "" And txtStateProvince.Text = "" Then
            MessageBox.Show("Datos no encontrados")
        Else
            If cbOpciones.SelectedItem.ToString.Equals("Modificar Registro") Then
                btnVerDatos.Visible = False
                btnModificar.Visible = True
                txtCity.Enabled = True
                txtCountryId.Enabled = True
                txtPostalCode.Enabled = True
                txtStateProvince.Enabled = True
                txtStreetAddress.Enabled = True
                MessageBox.Show("Datos encontrados", "Actualizar Registro")
            End If
        End If
        conection.Close
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        conection.Open
        Dim command = New OracleCommand("INSERT INTO locations(location_id,street_address,postal_code,city,state_province,country_id) VALUES(" & txtLocationId.Text & ",'" & txtStreetAddress.Text & "','" & txtPostalCode.Text & "','" & txtCity.Text & "','" & txtStateProvince.Text & "','" & txtCountryId.Text & "')", conection)
        command.ExecuteNonQuery()
        MessageBox.Show("Registro agregado correctamente")
        conection.Close
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim command As OracleCommand
        conection.Open
        Try
            command = New OracleCommand("UPDATE locations SET street_address='" & txtStreetAddress.Text & "',postal_code='" & txtPostalCode.Text & "',city='" & txtCity.Text & "',state_province='" & txtStateProvince.Text & "',country_id='" & txtCountryId.Text & "'" & " WHERE location_id=" & txtLocationId.Text, conection)
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
        Dim command = New OracleCommand("SELECT * FROM locations WHERE location_id=" & txtLocationId.Text, conection)
        command.Parameters.Add("location_id", txtLocationId.Text)
        conection.Open
        Dim dataReader As OracleDataReader
        dataReader = command.ExecuteReader
        If dataReader.Read Then
            txtCity.Text = dataReader.GetValue("city").ToString
            txtCountryId.Text = dataReader.GetValue("country_id").ToString
            txtPostalCode.Text = dataReader.GetValue("postal_code").ToString
            txtStateProvince.Text = dataReader.GetValue("state_province").ToString
            txtStreetAddress.Text = dataReader.GetValue("street_address").ToString
        End If
        If txtCity.Text = "" And txtStateProvince.Text = "" Then
            MessageBox.Show("Datos no encontrados")
        Else
            Dim selection = MessageBox.Show("Realmente desea eliminar a: " & txtLocationId.Text, "Eliminar", MessageBoxButtons.YesNoCancel)
            If selection.Cancel Or selection.No Then
                MessageBox.Show("Operacion cancelada")
            Else
                Try
                    command = New OracleCommand("DELETE FROM locations WHERE location_id=" & txtLocationId.Text, conection)
                    Dim dataAdapter = New OracleDataAdapter
                    dataAdapter.DeleteCommand = command
                    dataAdapter.DeleteCommand.ExecuteNonQuery()
                    MessageBox.Show("El registro ha sido eliminado correctamente")
                Catch ex As Exception
                    MessageBox.Show("ERROR: El registro no ha podido eliminar")
                End Try
            End If
        End If
        conection.Close
    End Sub

    Private Sub txtLocationId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLocationId.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Solo Puede digitar numeros en este campo", "Error de Tipo")
        End If
    End Sub
End Class