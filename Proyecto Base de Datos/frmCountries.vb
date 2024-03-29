﻿Imports Oracle.ManagedDataAccess.Client

Public Class frmCountries

    Dim userInterfaceUpdater As New UserInterfaceUpdater()
    Dim conection = New OracleConnection("Data Source = 127.0.0.1;User ID=hr;Password=hr;")
    Private Sub frmCountries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userInterfaceUpdater.defaultConfigFrmCountries()
        conection.Open
        Dim command = New OracleCommand("SELECT * FROM countries", conection)
        Dim adapter = New OracleDataAdapter
        adapter.SelectCommand = command
        Dim dataTable = New DataTable
        adapter.Fill(dataTable)
        dataGridViewTable.DataSource = dataTable
        conection.Close
    End Sub

    Private Sub btnBackMenu_Click(sender As Object, e As EventArgs) Handles btnBackMenu.Click
        Close()
        menuPrincipal.Visible = True
    End Sub

    Private Sub btnSeleccionarOpcion_Click(sender As Object, e As EventArgs) Handles btnSeleccionarOpcion.Click
        userInterfaceUpdater.defaultConfigFrmCountries()
        userInterfaceUpdater.selectionButtonConfigFrmCountries()
    End Sub

    Private Sub brnClean_Click(sender As Object, e As EventArgs) Handles brnClean.Click
        userInterfaceUpdater.defaultConfigFrmCountries()
        conection.Close
    End Sub

    Private Sub btnVerDatos_Click(sender As Object, e As EventArgs) Handles btnVerDatos.Click
        Dim command = New OracleCommand("SELECT * FROM countries WHERE country_id='" & txtCountryId.Text & "'", conection)
        command.Parameters.Add("country_id", txtCountryId.Text)
        conection.Open
        Dim dataReader As OracleDataReader
        dataReader = command.ExecuteReader
        If dataReader.Read Then
            txtCountryName.Text = dataReader.GetValue("country_name").ToString
            txtRegionId.Text = dataReader.GetValue("region_id").ToString

            If cbOpciones.SelectedItem.ToString.Equals("Modificar Registro") Then
                btnVerDatos.Visible = False
                btnModificar.Visible = True
                txtCountryName.Enabled = True
                txtRegionId.Enabled = True
                MessageBox.Show("Datos encontrados", "Actualizar Registro")
            End If
        End If
        If txtCountryName.Text = "" Then
            MessageBox.Show("Datos no encontrados")
        End If
        conection.Close

    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        conection.Open
        Dim command = New OracleCommand("INSERT INTO countries(country_id,country_name,region_id) VALUES(" & "'" & txtCountryId.Text & "'" & ",'" & txtCountryName.Text & "'," & txtRegionId.Text & ")", conection)
        command.ExecuteNonQuery()
        MessageBox.Show("Registro agregado correctamente")
        conection.Close
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim command As OracleCommand
        conection.Open
        Try
            command = New OracleCommand("UPDATE countries SET country_name='" & txtCountryName.Text & "', region_id= " & txtRegionId.Text & "WHERE country_id=" & "'" & txtCountryId.Text & "'", conection)
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
        Dim command = New OracleCommand("SELECT * FROM countries WHERE country_id='" & txtCountryId.Text & "'", conection)
        command.Parameters.Add("country_id", txtCountryId.Text)
        conection.Open
        Dim dataReader As OracleDataReader
        dataReader = command.ExecuteReader
        If dataReader.Read Then
            txtCountryName.Text = dataReader.GetValue("country_name").ToString
            txtRegionId.Text = dataReader.GetValue("region_id").ToString
        End If
        If txtCountryName.Text = "" Then
            MessageBox.Show("Datos no encontrados")
        Else
            Dim selection As DialogResult = MessageBox.Show("Realmente desea eliminar a: " & txtCountryName.Text, "Eliminar", MessageBoxButtons.YesNoCancel)
            If selection = DialogResult.Yes Then
                Try
                    command = New OracleCommand("DELETE FROM countries WHERE country_id=" & "'" & txtCountryId.Text & "'", conection)
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

    Private Sub txtRegionId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRegionId.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Solo Puede digitar numeros en este campo", "Error de Tipo")
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        conection.Open
        Dim command = New OracleCommand("SELECT * FROM countries", conection)
        Dim adapter = New OracleDataAdapter
        adapter.SelectCommand = command
        Dim dataTable = New DataTable
        adapter.Fill(dataTable)
        dataGridViewTable.DataSource = dataTable
        conection.Close
    End Sub
End Class