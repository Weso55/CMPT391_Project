Imports System.Data.SqlClient

Public Class enrolled

    'declaring variables used in'
    Private user_id As Integer
    Private con As SqlConnection
    Private cmd As SqlCommand
    Private adpt As SqlDataAdapter
    Private con_string As String
    Public PrevPage As Form

    'grid selection variables
    Private index As Integer = -1
    Private selectedrow As DataGridViewRow


    'code to run before switching to this form in the previous form (if that makes sense?)'
    Public Sub start_up(ID As Integer, con_s As String, prevp As Sign_in)
        user_id = ID
        con_string = con_s
        PrevPage = prevp
        If Not IsNumeric(user_id) Then
            Console.WriteLine("Invalid user id")
            Exit Sub
        End If
        Try
            'open new connection'
            con = New SqlConnection(con_string)
            cmd = New SqlCommand
            'assign parameters for stored procedure
            Dim params(0) As SqlParameter
            params(0) = New SqlParameter("@id", SqlDbType.Int)
            params(0).Value = user_id

            'Assign variables for connection
            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "Enrolled_Startup_Data"
            cmd.Parameters.AddRange(params)

            adpt = New SqlDataAdapter
            adpt.SelectCommand = cmd

            'fill table with enrolled details'
            Dim dt As DataTable = New DataTable
            adpt.Fill(dt)
            EnrollData.DataSource = dt

        Catch ex As Exception
            MsgBox("Error with Filling enrolled data table: " & ex.Message & " ")
        End Try
    End Sub

    Private Sub ViewCourses_Click(sender As Object, e As EventArgs) Handles ViewCourses.Click
        Dim formCourseList As New Course_List
        Me.Hide()
        formCourseList.startup(user_id, con_string, Me)
        formCourseList.ShowDialog()
        'Me.Close()'
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        Try
            'open new connection'
            con = New SqlConnection(con_string)
            cmd = New SqlCommand
            'assign parameters for stored procedure
            Dim params(2) As SqlParameter
            ' assign id
            params(0) = New SqlParameter("@id", SqlDbType.Int)
            params(0).Value = user_id
            ' assign sem
            params(1) = New SqlParameter("@sem", SqlDbType.VarChar)
            ' if combo box not empty then assign value else assign string null
            If Not SemComboBox.SelectedIndex = -1 Then
                params(1).Value = SemComboBox.Text
            Else
                params(1).Value = "null"
            End If
            ' assign year
            params(2) = New SqlParameter("@yr", SqlDbType.VarChar)
            If Not YearComboBox.SelectedIndex = -1 Then
                params(2).Value = YearComboBox.Text
            Else
                params(2).Value = "null"
            End If


            'Assign variables for connection
            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "Enrolled_Filter"
            cmd.Parameters.AddRange(params)

            adpt = New SqlDataAdapter
            adpt.SelectCommand = cmd


            'fill table with enrolled details'
            Dim dt As DataTable = New DataTable
            adpt.Fill(dt)
            EnrollData.DataSource = dt

        Catch ex As Exception
            MsgBox("Error with Filling enrolled data table: " & ex.Message & " ")
        End Try

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide() 'hides formEnrolled'
        PrevPage.Show()
    End Sub


    Private Sub EnrollData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EnrollData.CellContentClick
        'get rowindex of clicked cell
        index = e.RowIndex
        selectedrow = EnrollData.Rows(index)
    End Sub

    Private Sub DropButton_Click(sender As Object, e As EventArgs) Handles DropButton.Click
        If index = -1 Then
            MsgBox("select course to drop")
            Exit Sub
        End If
        Dim Student_id As Integer = selectedrow.Cells(0).Value
        Dim Course_ID As Integer = selectedrow.Cells(1).Value
        Dim Section_ID As String = selectedrow.Cells(2).Value
        Dim Semester As String = selectedrow.Cells(3).Value
        Dim Year As Integer = selectedrow.Cells(4).Value

        Try
            'open New connection'
            con = New SqlConnection(con_string)
            cmd = New SqlCommand
            'assign parameters for stored procedure

            Dim params(4) As SqlParameter

            params(0) = New SqlParameter("@user_id", SqlDbType.Int)
            params(0).Value = Student_id

            params(1) = New SqlParameter("@course_id", SqlDbType.Int)
            params(1).Value = Course_ID

            params(2) = New SqlParameter("@sect", SqlDbType.VarChar)
            params(2).Value = Section_ID

            params(3) = New SqlParameter("@sem", SqlDbType.VarChar)
            params(3).Value = Semester

            params(4) = New SqlParameter("@yr", SqlDbType.Int)
            params(4).Value = Year

            'Assign variables for connection
            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "Delete_Student"
            cmd.Parameters.AddRange(params)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Dropped Course: " & Course_ID & ", " & Section_ID & ", " & Semester & ", " & Year & " ")
        Catch ex As Exception
            MsgBox("Error with Deleting Course: " & ex.Message & " ")
        End Try


    End Sub



End Class