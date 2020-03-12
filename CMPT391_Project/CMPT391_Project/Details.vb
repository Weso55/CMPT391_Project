Imports System.Data
Imports System.Data.SqlClient


Public Class Details
    Private user_id As Integer
    Private course_id As Integer
    Private semester As String
    Private year As Integer
    Private con_string As String
    Public PrevPage As Form

    Public Sub startup(u_id As Integer, c_id As Integer, sem As String, yr As Integer, con_s As String, prevp As Course_List)
        user_id = u_id
        course_id = c_id
        semester = sem
        year = yr
        con_string = con_s
        PrevPage = prevp

        Dim cap As Integer
        Try
            Dim con As New SqlConnection
            con.ConnectionString = (con_string)
            con.Open()

            Dim strsql As String
            strsql = "select * from detail where Class_ID = '" & course_id & "' "

            Dim cmd As New SqlCommand(strsql, con)

            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            dr.Read()

            'Dim id As String = dr("C_Name")
            CourseNameLabel.Text = dr("C_Name")
            SectionLabel.Text = dr("S_ID")
            InstructorLabel.Text = dr("I_name")
            DepartmentLabel.Text = dr("D_name")
            cap = dr("cap")
            con.Close()
        Catch ex As Exception
            MsgBox("Error Detail select Failed: " & ex.Message & " ")

        End Try

        Try
            Dim con2 As New SqlConnection
            con2.ConnectionString = (con_string)
            con2.Open()
            Dim strsql2 As String
            strsql2 = "SELECT COUNT(Course_ID) AS num from Enrolled where Course_ID = '" & course_id & "' and Semester = '" & semester & "' and Year = " & year & "; "
            Dim cmd2 As New SqlCommand(strsql2, con2)
            Dim dr2 As SqlDataReader
            dr2 = cmd2.ExecuteReader
            dr2.Read()
            'add capacity to detail and fix naming
            StatusLabel.Text = dr2("num") & " /" & cap & " "
            con2.Close()
        Catch ex As Exception
            MsgBox("Error Count Failed: " & ex.Message & " ")
        End Try

        Try
            Dim con4 As New SqlConnection
            con4.ConnectionString = (con_string)
            con4.Open()
            Dim strsql4 As String
            strsql4 = "SELECT Prereq.prereq_id, isnull(Name, 'None') AS Name
                       FROM Prereq
                       LEFT JOIN (SELECT distinct Prereq.Course_id, Name FROM Courses,Prereq WHERE Courses.Course_ID = Prereq.Course_id) AS PR
                       ON Prereq.prereq_id = PR.Course_id
                       WHERE Prereq.Course_id = " & course_id & "; "
            Dim cmd4 As New SqlCommand(strsql4, con4)
            Dim dr4 As SqlDataReader
            dr4 = cmd4.ExecuteReader
            dr4.Read()
            PrereqLabel.Text = dr4("Name")
            con4.Close()
        Catch ex As Exception
            MsgBox("Error Prereq select Failed: " & ex.Message & " ")
        End Try

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide() 'hides formDetails'
        PrevPage.Show()
    End Sub

    Private Sub EnrollButton_Click(sender As Object, e As EventArgs) Handles EnrollButton.Click

        Dim con3 As New SqlConnection
        con3.ConnectionString = (con_string)
        con3.Open()
        Dim command As New SqlCommand
        command = con3.CreateCommand

        Dim transaction As SqlTransaction
        transaction = con3.BeginTransaction("EnrollTransaction")

        command.Connection = con3
        command.Transaction = transaction

        Try
            command.CommandText = "INSERT INTO Enrolled (Student_ID, Course_ID, Semester, Year) values (" & user_id & ", " & course_id & ", '" & semester & "', " & year & "); "
            command.ExecuteNonQuery()

            transaction.Commit()
            Debug.Write("Transaction committed" & Environment.NewLine)
            MsgBox("Enrolled!")

        Catch ex As Exception
            MsgBox("Error Enroll Failed: " & ex.Message & " ")

            Try
                transaction.Rollback()
            Catch ex2 As Exception
                MsgBox("Error Rollback Failed: " & ex.Message & " ")
            End Try

        End Try


    End Sub
End Class
