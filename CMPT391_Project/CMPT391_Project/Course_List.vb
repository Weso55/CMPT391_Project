Imports System.Data.SqlClient

Public Class Course_List

    Private user_id As Integer
    Private con As SqlConnection
    Private cmd As SqlCommand
    Private adpt As SqlDataAdapter
    Private con_string As String
    Public PrevPage As Form

    ' run startup in previous form before showing form to preload datagrid
    Public Sub startup(id As Integer, con_s As String, prevp As enrolled)
        user_id = id
        con_string = con_s
        PrevPage = prevp
        Try
            'open new connection'
            con = New SqlConnection(con_string)
            cmd = New SqlCommand
            'assign parameters for stored procedure
            Dim params(0) As SqlParameter
            params(0) = New SqlParameter("@yr", SqlDbType.Int)
            params(0).Value = 2020

            'Assign variables for connection
            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "Course_Startup_Data"
            cmd.Parameters.AddRange(params)

            adpt = New SqlDataAdapter
            adpt.SelectCommand = cmd


            'adpt = New SqlDataAdapter("Select * from Enrolled where Student_ID=" & user_id & " ", con)
            'fill table with enrolled details'
            Dim dt As DataTable = New DataTable
            adpt.Fill(dt)
            CourseDataGridView.DataSource = dt

        Catch ex As Exception
            MsgBox("Error with Filling enrolled data table: " & ex.Message & " ")
        End Try

    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click

        Try
            'open new connection'
            con = New SqlConnection(con_string)
            cmd = New SqlCommand
            'assign parameters for stored procedure
            Dim params(4) As SqlParameter

            params(0) = New SqlParameter("@name", SqlDbType.VarChar)
            If Not CourseTextBox.Text = "" Then
                'where_string = where_string & " Name=" & CourseTextBox.Text & " "
                params(0).Value = CourseTextBox.Text
            Else
                params(0).Value = "null"
            End If

            params(1) = New SqlParameter("@sect", SqlDbType.VarChar)
            If Not SectionTextBox.Text = "" Then
                params(1).Value = SectionTextBox.Text
            Else
                params(1).Value = "null"
            End If

            params(2) = New SqlParameter("@dept", SqlDbType.VarChar)
            If Not DepartmentComboBox.SelectedIndex = -1 Then
                params(2).Value = DepartmentComboBox.Text
            Else
                params(2).Value = "null"
            End If

            params(3) = New SqlParameter("@sem", SqlDbType.VarChar)
            If Not SemesterComboBox.SelectedIndex = -1 Then
                params(3).Value = SemesterComboBox.Text
            Else
                params(3).Value = "null"
            End If

            params(4) = New SqlParameter("@yr", SqlDbType.VarChar)
            If Not YearComboBox.SelectedIndex = -1 Then
                params(4).Value = YearComboBox.Text
            Else
                params(4).Value = "null"
            End If

            'Assign variables for connection
            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "Course_Filter"
            cmd.Parameters.AddRange(params)

            adpt = New SqlDataAdapter
            adpt.SelectCommand = cmd


            'fill table with enrolled details'
            Dim dt As DataTable = New DataTable
            adpt.Fill(dt)
            CourseDataGridView.DataSource = dt

        Catch ex As Exception
            MsgBox("Error with Filling Course data table: " & ex.Message & " ")
        End Try

    End Sub

    Private Sub CourseDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CourseDataGridView.CellContentClick
        'get rowindex of clicked cell'
        Dim index As Integer = e.RowIndex
        Dim selectedrow As DataGridViewRow
        selectedrow = CourseDataGridView.Rows(index)
        'pull value from row cell'
        Dim course_id As Integer = selectedrow.Cells(0).Value
        Dim semester As String = selectedrow.Cells(4).Value.ToString()
        Dim year As Integer = selectedrow.Cells(5).Value
        Dim section As String = selectedrow.Cells(3).Value.ToString()
        'create new detail form and hid current form'
        Dim formDetails As New Details
        Me.Hide()
        'pass user_id and course_id (selected course to next form)'
        formDetails.startup(user_id, course_id, semester, year, section, con_string, Me)
        formDetails.ShowDialog()
        'Me.Close()'
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide() 'hides formCourseList'
        PrevPage.Show()
    End Sub
End Class