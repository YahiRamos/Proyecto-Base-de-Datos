Imports System.Runtime.CompilerServices
Imports System.Security.Principal

Public Class menuPrincipal

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        pantallaLogin.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmEmployees.Visible = True
        Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        frmRegions.Visible = True
        Hide()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        frmCountries.Visible = True
        Hide()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        frmLocations.Visible = True
        Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        frmDepartments.Visible = True
        Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        frmJobHistory.Visible = True
        Hide()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        frmJobs.Visible = True
        Hide()
    End Sub
End Class