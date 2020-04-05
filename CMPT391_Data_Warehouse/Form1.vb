Imports System.Data.SqlClient
Public Class Form1
    Private con_string As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CreatDataButton.Click
        Dim d_form As New Data_Generation
        con_string = "Data Source=DESKTOP-IRRDDVT\SQLEXPRESS;Initial Catalog=CMPT391;Integrated Security=True"
        d_form.Startup(con_string)
        d_form.ShowDialog()
    End Sub



End Class
