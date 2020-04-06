Imports System.Data.SqlClient
Public Class Form1
    Private user_id As Integer
    Private con As SqlConnection
    Private cmd As SqlCommand
    Private adpt As SqlDataAdapter
    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        Try
            'open new connection'
            Dim con_string = "Data Source=DESKTOP-IRRDDVT\SQLEXPRESS;Initial Catalog=CMPT391_Data_Warehouse;Integrated Security=True"
            con = New SqlConnection(con_string)
            cmd = New SqlCommand
            'assign parameters for stored procedure
            Dim params(4) As SqlParameter

            params(0) = New SqlParameter("@I_ID", SqlDbType.VarChar)
            If Not InstructorTextBox.Text = "" Then
                'where_string = where_string & " Name=" & CourseTextBox.Text & " "
                params(0).Value = InstructorTextBox.Text
            Else
                params(0).Value = "null"
            End If

            params(1) = New SqlParameter("@faculty", SqlDbType.VarChar)
            If Not FacultyComboBox.SelectedIndex = -1 Then
                params(1).Value = FacultyComboBox.Text
            Else
                params(1).Value = "null"
            End If

            params(2) = New SqlParameter("@department", SqlDbType.VarChar)
            If Not DepartmentComboBox.SelectedIndex = -1 Then
                params(2).Value = DepartmentComboBox.Text
            Else
                params(2).Value = "null"
            End If

            params(3) = New SqlParameter("@semester", SqlDbType.VarChar)
            If Not SemesterComboBox.SelectedIndex = -1 Then
                params(3).Value = SemesterComboBox.Text
            Else
                params(3).Value = "null"
            End If

            params(4) = New SqlParameter("@year", SqlDbType.VarChar)
            If Not YearComboBox.SelectedIndex = -1 Then
                params(4).Value = YearComboBox.Text
            Else
                params(4).Value = "null"
            End If

            MessageBox.Show("Values: " + params(0).Value.ToString() + ", " + params(1).Value.ToString() + ", " + params(2).Value.ToString() + ", " + params(3).Value.ToString() + ", " + params(4).Value.ToString() + ", ")
            'Assign variables for connection
            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "Course_Value"
            cmd.Parameters.AddRange(params)

            adpt = New SqlDataAdapter
            adpt.SelectCommand = cmd


            'fill table with enrolled details'
            Dim dt As DataTable = New DataTable
            adpt.Fill(dt)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox("Error with Filling Course_Total data table: " & ex.Message & " ")
        End Try
    End Sub
End Class
