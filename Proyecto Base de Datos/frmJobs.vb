Imports Oracle.ManagedDataAccess.Client
Imports System.Data.OracleClient
Imports System.Diagnostics.Eventing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

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
    End Sub

    Private Sub btnSeleccionarOpcion_Click(sender As Object, e As EventArgs) Handles btnSeleccionarOpcion.Click
        userInterfaceUpdater.defaultConfigFrmJobs()
        userInterfaceUpdater.selectionButtonConfigFrmJobs()
    End Sub

    Private Sub btnClean_Click(sender As Object, e As EventArgs) Handles btnClean.Click
        userInterfaceUpdater.defaultConfigFrmJobs()
    End Sub
End Class