Imports Oracle.ManagedDataAccess.Client

Public Class frmReportes

    Dim userInterfaceUpdater As New UserInterfaceUpdater()
    Dim conection = New OracleConnection("Data Source = 127.0.0.1;User ID=hr;Password=hr;")
    Private Sub frmReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conection.Open
        Dim command = New OracleCommand("SELECT * FROM jobs", conection)
        Dim adapter = New OracleDataAdapter
        adapter.SelectCommand = command
        Dim data = New DataSet
        adapter.Fill(data)
        cbJob.DataSource = data.Tables(0)
        cbJob.DisplayMember = "job_title"
        cbJob.ValueMember = "job_title"

        command = New OracleCommand("SELECT * FROM departments", conection)
        adapter = New OracleDataAdapter
        adapter.SelectCommand = command
        data = New DataSet
        adapter.Fill(data)
        cbDepartment.DataSource = data.Tables(0)
        cbDepartment.DisplayMember = "department_name"
        cbDepartment.ValueMember = "department_name"
        conection.Close

    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Close()
        frmEmployees.Visible = True
    End Sub

    Private Sub btnSearchJobs_Click(sender As Object, e As EventArgs) Handles btnSearchJobs.Click
        conection.Open
        Dim command = New OracleCommand("SELECT first_name as nombre, last_name as apellido, salary as salario, department_name as departamento
                                        FROM employees e, departments d
                                        WHERE job_id = (SELECT job_id from jobs
                                                        WHERE job_title='" & cbJob.Text & "')
                                       AND e.department_id=d.department_id", conection)
        Dim adapter = New OracleDataAdapter
        adapter.SelectCommand = command
        Dim dataTable = New DataTable
        adapter.Fill(dataTable)
        dataGridViewReportes.DataSource = dataTable
        conection.Close
    End Sub

    Private Sub btnSearchDepartments_Click(sender As Object, e As EventArgs) Handles btnSearchDepartments.Click
        conection.Open
        Dim command = New OracleCommand("SELECT first_name as nombre,last_name as apellido,job_title as empleo,city as ciudad
                                         FROM employees e, jobs j,locations l
                                         WHERE e.department_id=(SELECT department_id 
                                                				FROM departments 
                                                				WHERE department_name='" & cbDepartment.Text & "')
                                         AND e.job_id = j.job_id
                                         AND l.location_id=(SELECT location_id
                                                			FROM departments 	
                                                			WHERE department_name='" & cbDepartment.Text & "')", conection)
        Dim adapter = New OracleDataAdapter
        adapter.SelectCommand = command
        Dim dataTable = New DataTable
        adapter.Fill(dataTable)
        dataGridViewReportes.DataSource = dataTable
        conection.Close
    End Sub

    Private Sub btnSearchEndDate_Click(sender As Object, e As EventArgs) Handles btnSearchEndDate.Click
        conection.Open
        Dim command = New OracleCommand("SELECT first_name as nombre, last_name as apellido,job_title as empleo,department_name as departamento
                                        FROM employees e,departments d,jobs j,job_history jh
                                        WHERE e.employee_id = jh.employee_id
                                        AND d.department_id = jh.department_id
                                        AND j.job_id = jh.job_id", conection)
        Dim adapter = New OracleDataAdapter
        adapter.SelectCommand = command
        Dim dataTable = New DataTable
        adapter.Fill(dataTable)
        dataGridViewReportes.DataSource = dataTable
        conection.Close
    End Sub

    Private Sub btnClean_Click(sender As Object, e As EventArgs) Handles btnClean.Click
        dataGridViewReportes.Columns.Clear()
    End Sub
End Class