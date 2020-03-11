Imports System.Data.SqlClient

Public Class enrolled

    'declaring variables used in'
    Private user_id As Integer
    Private con As SqlConnection
    Private cmd As SqlCommand
    Private adpt As SqlDataAdapter
    Private con_string As String

    'code to run before switching to this form in the previous form (if that makes sense?)'
    Public Sub start_up(ID As Integer, con_s As String)
        user_id = ID
        con_string = con_s
        If Not IsNumeric(user_id) Then
            Console.WriteLine("Invalid user id")
        Exit Sub
        End If

        'open new connection'
        con = New SqlConnection(con_string)
        adpt = New SqlDataAdapter("Select * from Enrolled where Student_ID=" & user_id & " ", con)
        'fill table with enrolled details'
        Dim dt As DataTable = New DataTable
        adpt.Fill(dt)
        EnrollData.DataSource = dt
    End Sub

    Private Sub ViewCourses_Click(sender As Object, e As EventArgs) Handles ViewCourses.Click
        Dim form As New Course_List
        Me.Hide()
        form.startup(user_id, con_string)
        form.ShowDialog()
        Me.Close()
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        Dim sem As String
        Dim year As Integer

        'Check if combo boxes are selected'
        If SemComboBox.SelectedIndex = -1 Then
            MsgBox("select semester")
            Exit Sub
        End If

        If YearComboBox.SelectedIndex = -1 Then
            MsgBox("select Year")
            Exit Sub
        End If

        sem = SemComboBox.Text
        year = CInt(YearComboBox.Text)

        con = New SqlConnection(con_string)
        adpt = New SqlDataAdapter("Select * from Enrolled where Student_ID=" & user_id & " and Year=" & year & " and Semester='" & sem & "' ", con)
        Dim dt As DataTable = New DataTable

        'fill table with enrolled details'
        adpt.Fill(dt)
        EnrollData.DataSource = dt
    End Sub

End Class