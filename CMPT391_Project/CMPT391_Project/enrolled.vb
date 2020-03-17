Imports System.Data.SqlClient

Public Class enrolled

    'declaring variables used in'
    Private user_id As Integer
    Private con As SqlConnection
    Private cmd As SqlCommand
    Private adpt As SqlDataAdapter
    Private con_string As String
    Public PrevPage As Form

    'code to run before switching to this form in the previous form (if that makes sense?)'
    Public Sub start_up(ID As Integer, con_s As String, prevp As Sign_in)
        user_id = ID
        con_string = con_s
        PrevPage = prevp
        If Not IsNumeric(user_id) Then
            Console.WriteLine("Invalid user id")
            Exit Sub
        End If

        'open new connection'
        con = New SqlConnection(con_string)
        'assign parameters for stored procedure
        Dim params(0) As SqlParameter
        params(0) = New SqlParameter("@id", SqlDbType.Int)
        params(0).Value = user_id

        'Assign variables for connection
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Enrolled_Startup_Data"
        cmd.Parameters.AddRange(params)

        adpt = New SqlDataAdapter()
        adpt.SelectCommand = cmd

        'adpt = New SqlDataAdapter("Select * from Enrolled where Student_ID=" & user_id & " ", con)
        'fill table with enrolled details'
        Dim dt As DataTable = New DataTable
        adpt.Fill(dt)
        EnrollData.DataSource = dt
    End Sub

    Private Sub ViewCourses_Click(sender As Object, e As EventArgs) Handles ViewCourses.Click
        Dim formCourseList As New Course_List
        Me.Hide()
        formCourseList.startup(user_id, con_string, Me)
        formCourseList.ShowDialog()
        'Me.Close()'
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        Dim where_string As String = ""
        Dim flag As Integer = 0

        'find out how many options in search have been selected
        If Not SemComboBox.SelectedIndex = -1 Then
            flag += 1
        End If
        If Not YearComboBox.SelectedIndex = -1 Then
            flag += 1
        End If

        'build where string based on selected options
        If Not SemComboBox.SelectedIndex = -1 Then
            Dim sem As String = SemComboBox.Text
            where_string = where_string & " Semester='" & sem & "' "
            If flag > 1 Then
                where_string = where_string & "and " & " "
                flag -= 1
            End If
        End If

        If Not YearComboBox.SelectedIndex = -1 Then
            Dim year As String = YearComboBox.Text
            where_string = where_string & " Year='" & year & "' "
            If flag > 1 Then
                where_string = where_string & "and" & " "
                flag -= 1
            End If
        End If

        con = New SqlConnection(con_string)
        If flag = 0 Then
            adpt = New SqlDataAdapter("Select * from Enrolled where Student_ID=" & user_id & " ", con)

        Else
            adpt = New SqlDataAdapter("Select * from Enrolled where Student_ID=" & user_id & "and" & where_string, con)
        End If

        Dim dt As DataTable = New DataTable

        'fill table with enrolled details'
        adpt.Fill(dt)
        EnrollData.DataSource = dt

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide() 'hides formEnrolled'
        PrevPage.Show()
    End Sub
End Class