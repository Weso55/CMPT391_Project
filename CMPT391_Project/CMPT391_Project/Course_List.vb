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
        Dim where_string As String = ""
        Dim flag As Integer = 0

        'find out how many options in search have been selected
        If Not DepartmentComboBox.SelectedIndex = -1 Then
            flag += 1
        End If
        If Not SemesterComboBox.SelectedIndex = -1 Then
            flag += 1
        End If
        If Not SectionTextBox.Text = "" Then
            flag += 1
        End If
        If Not CourseTextBox.Text = "" Then
            flag += 1
        End If

        'build where string based on selected options
        If Not DepartmentComboBox.SelectedIndex = -1 Then
            Dim deptname As String = DepartmentComboBox.Text
            where_string = where_string & " Department_ID=" & deptname & " "
            If flag > 1 Then
                where_string = where_string & "and " & " "
                flag -= 1
            End If
        End If

        If Not SemesterComboBox.SelectedIndex = -1 Then
            Dim sem As String = SemesterComboBox.Text
            where_string = where_string & " Semester='" & sem & "' "
            If flag > 1 Then
                where_string = where_string & "and" & " "
                flag -= 1
            End If
        End If

        If Not SectionTextBox.Text = "" Then
            where_string = where_string & " Section_ID=" & SectionTextBox.Text & " "
            If flag > 1 Then
                where_string = where_string & "and" & " "
                flag -= 1
            End If
        End If

        If Not CourseTextBox.Text = "" Then
            where_string = where_string & " Name=" & CourseTextBox.Text & " "
            If flag > 1 Then
                where_string = where_string & "and" & " "
                flag -= 1
            End If
        End If

        con = New SqlConnection(con_string)
        If flag = 0 Then
            adpt = New SqlDataAdapter("Select * from Courses", con)
        Else
            Try
                adpt = New SqlDataAdapter("Select * from Courses where " + where_string, con)
            Catch ex As Exception
                MsgBox("invalid selection: " + ex.Message)
            End Try
        End If
        Dim dt As DataTable = New DataTable

        'fill table with enrolled details'
        adpt.Fill(dt)
        CourseDataGridView.DataSource = dt
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