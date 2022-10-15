﻿Imports Oracle.ManagedDataAccess.Client


Public Class frmJobs

    Dim userInterfaceUpdater As New UserInterfaceUpdater()
    Dim conection = New OracleConnection("Data Source = 127.0.0.1;User ID=hr;Password=hr;")

    Private Sub frmJobs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userInterfaceUpdater.defaultConfigFrmJobs()
    End Sub

    Private Sub btnBackMenu_Click(sender As Object, e As EventArgs) Handles btnBackMenu.Click
        Close()
        menuPrincipal.Visible = True
    End Sub

    Private Sub btnVerDatos_Click(sender As Object, e As EventArgs) Handles btnVerDatos.Click
        Dim command = New OracleCommand("SELECT * FROM jobs WHERE job_id='" & txtJobId.Text & "'", conection)
        command.Parameters.Add("job_id", txtJobId.Text)
        conection.Open
        Dim dataReader As OracleDataReader
        dataReader = command.ExecuteReader
        If dataReader.Read Then
            txtJobTitle.Text = dataReader.GetValue("job_title").ToString
            txtMinSalary.Text = dataReader.GetValue("min_salary").ToString
            txtMaxSalary.Text = dataReader.GetValue("max_salary").ToString
        End If
        conection.Close
        If cbOpciones.SelectedItem.ToString.Equals("Modificar Registro") Then
            btnVerDatos.Visible = False
            btnModificar.Visible = True
            txtJobTitle.Enabled = True
            txtMaxSalary.Enabled = True
            txtMinSalary.Enabled = True
            MessageBox.Show("Datos encontrados", "Actualizar Registro")
        End If
    End Sub

    Private Sub btnSeleccionarOpcion_Click(sender As Object, e As EventArgs) Handles btnSeleccionarOpcion.Click
        userInterfaceUpdater.defaultConfigFrmJobs()
        userInterfaceUpdater.selectionButtonConfigFrmJobs()
    End Sub

    Private Sub btnClean_Click(sender As Object, e As EventArgs) Handles btnClean.Click
        userInterfaceUpdater.defaultConfigFrmJobs()
        conection.Close
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim command = New OracleCommand("SELECT * FROM jobs WHERE job_id='" & txtJobId.Text & "'", conection)
        command.Parameters.Add("job_id", txtJobId.Text)
        conection.Open
        Dim dataReader As OracleDataReader
        dataReader = command.ExecuteReader
        If dataReader.Read Then
            txtJobTitle.Text = dataReader.GetValue("job_title").ToString
            txtMinSalary.Text = dataReader.GetValue("min_salary").ToString
            txtMaxSalary.Text = dataReader.GetValue("max_salary").ToString
        End If
        Dim selection = MessageBox.Show("Realmente desea eliminar a: " & txtJobId.Text, "Eliminar", MessageBoxButtons.YesNoCancel)
        If selection.Yes Then
            Try
                command = New OracleCommand("DELETE FROM jobs WHERE job_id='" & txtJobId.Text & "'", conection)
                Dim dataAdapter = New OracleDataAdapter
                dataAdapter.DeleteCommand = command
                dataAdapter.DeleteCommand.ExecuteNonQuery()
                MessageBox.Show("El registro ha sido eliminado correctamente")
            Catch ex As Exception
                MessageBox.Show("ERROR: El registro no ha podido eliminar")
            End Try
        End If
        conection.Close
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        conection.Open
        Dim command = New OracleCommand("INSERT INTO jobs(job_id,job_title,min_salary,max_salary) VALUES('" & txtJobId.Text & "','" & txtJobTitle.Text & "'," & txtMinSalary.Text & "," & txtMaxSalary.Text & ")", conection)
        command.ExecuteNonQuery()
        MessageBox.Show("Registro agregado correctamente")
        conection.Close
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim command As OracleCommand
        conection.Open
        Try
            command = New OracleCommand("UPDATE jobs SET job_title='" & txtJobTitle.Text & "',min_salary=" & txtMinSalary.Text & ",max_salary=" & txtMaxSalary.Text & "WHERE job_id='" & txtJobId.Text & "'", conection)
            Dim dataAdapter = New OracleDataAdapter
            dataAdapter.UpdateCommand = command
            dataAdapter.UpdateCommand.ExecuteNonQuery()
            MessageBox.Show("Registro actualizado correctamente", "Actualizar Registro")
        Catch ex As Exception
            MessageBox.Show("Error al actualizar registro", "Actualizar Registro")
        End Try
    End Sub
End Class