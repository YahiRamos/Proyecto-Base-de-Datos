﻿Imports Oracle.ManagedDataAccess.Client
Imports System.Collections.ObjectModel

Public Class frmRegions

    Dim userInterfaceUpdater As New UserInterfaceUpdater()
    Dim conection = New OracleConnection("Data Source = 127.0.0.1;User ID=hr;Password=hr;")
    Private Sub frmRegions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userInterfaceUpdater.defaultConfigFrmRegions()
        conection.Open
        Dim command = New OracleCommand("SELECT * FROM regions", conection)
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

    Private Sub btnClean_Click(sender As Object, e As EventArgs) Handles btnClean.Click
        userInterfaceUpdater.defaultConfigFrmRegions()
        conection.Close
    End Sub

    Private Sub btnSeleccionarOpcion_Click(sender As Object, e As EventArgs) Handles btnSeleccionarOpcion.Click
        userInterfaceUpdater.selectionButtonConfigFrmRegions()
    End Sub

    Private Sub btnVerDatos_Click(sender As Object, e As EventArgs) Handles btnVerDatos.Click
        Dim command = New OracleCommand("SELECT * FROM regions WHERE region_id='" & txtRegionId.Text & "'", conection)
        command.Parameters.Add("region_id", txtRegionId.Text)
        conection.Open
        Dim dataReader As OracleDataReader
        dataReader = command.ExecuteReader
        If dataReader.Read Then
            txtRegionName.Text = dataReader.GetValue("region_name").ToString
        End If
        conection.Close
        If txtRegionName.Text = "" Then
            MessageBox.Show("Detos no encontrados")
        Else
            If cbOpciones.SelectedItem.ToString.Equals("Modificar Registro") Then
                btnVerDatos.Visible = False
                btnModificar.Visible = True
                txtRegionName.Enabled = True
                MessageBox.Show("Datos encontrados", "Actualizar Registro")
            End If
        End If
        conection.Close
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        conection.Open
        Dim command = New OracleCommand("INSERT INTO regions(region_id,region_name) VALUES(" & txtRegionId.Text & ",'" & txtRegionName.Text & "'" & ")", conection)
        command.ExecuteNonQuery()
        MessageBox.Show("Registro agregado correctamente")
        conection.Close
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim command = New OracleCommand("SELECT * FROM regions WHERE region_id=" & txtRegionId.Text, conection)
        command.Parameters.Add("region_id", txtRegionId.Text)
        conection.Open
        Dim dataReader As OracleDataReader
        dataReader = command.ExecuteReader
        If dataReader.Read Then
            txtRegionName.Text = dataReader.GetValue("region_name").ToString
        End If
        If txtRegionName.Text = "" Then
            MessageBox.Show("Detos no encontrados")
        Else
            Dim selection As DialogResult = MessageBox.Show("Realmente desea eliminar a: " & txtRegionName.Text, "Eliminar", MessageBoxButtons.YesNoCancel)
            If selection = DialogResult.Yes Then
                Try
                    command = New OracleCommand("DELETE FROM regions WHERE region_id=" & txtRegionId.Text, conection)
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

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim command As OracleCommand
        conection.Open
        Try
            command = New OracleCommand("UPDATE regions SET region_name='" & txtRegionName.Text & "' " & "WHERE region_id=" & txtRegionId.Text, conection)
            Dim dataAdapter = New OracleDataAdapter
            dataAdapter.UpdateCommand = command
            dataAdapter.UpdateCommand.ExecuteNonQuery()
            MessageBox.Show("Registro actualizado correctamente", "Actualizar Registro")
        Catch ex As Exception
            MessageBox.Show("Error al actualizar registro", "Actualizar Registro")
        End Try
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
        Dim command = New OracleCommand("SELECT * FROM regions", conection)
        Dim adapter = New OracleDataAdapter
        adapter.SelectCommand = command
        Dim dataTable = New DataTable
        adapter.Fill(dataTable)
        dataGridViewTable.DataSource = dataTable
        conection.Close
    End Sub
End Class