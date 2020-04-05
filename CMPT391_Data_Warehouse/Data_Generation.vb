Imports System.Data.SqlClient

Public Class Data_Generation
    Private con_string As String

    'list of values to randomly choose
    Private Semesters As New List(Of String) From {"Summer", "Spring", "Winter", "Fall"}
    Private Instructors As New List(Of String) From {"john", "ryan", "candy", "bob"}

    Private Department As New List(Of String) From {"Math", "Business", "Computer Science", "Arts", "Chemistry", "Biology"}

    Private Year As New List(Of Integer) From {2020, 2021, 2022, 2023}

    Private Courses As New List(Of String) From {"Math100", "Math200", "Math300", "CMPT100", "CMPT200", "CMPT300", "BIO100", "BIO200", "BIO300", "CHEM100", "CHEM200", "CHEM300"}

    ' connection
    Private con As New SqlConnection
    Private cmd As New SqlCommand
    ' default numbers
    Private instructor_count As Integer = 20
    Private courses_count As Integer = 40


    Public Sub startup(con_str As String)
        con_string = con_str
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Me.clear()
    End Sub

    Private Sub clear()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Try
            con.ConnectionString = con_string
            con.Open()
            cmd.Connection = con
            'cmd.Parameters.Add(New SqlParameter("@DesignID", yourvaluehere))
            If MessageBox.Show("Do you really want to Delete these Records?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then

                MsgBox("Operation Cancelled")
                con.Close()
                Exit Sub
            Else
                cmd.CommandText = "Delete From History"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "Delete From Courses"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "Delete From Date"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "Delete From Instructors"
                cmd.ExecuteNonQuery()


                MsgBox("Tables deleted:  Enrolled,Students,Department,Instructors,Prereq,Courses")
            End If
        Catch ex As Exception
            MessageBox.Show("Error while deleting record on table..." & ex.Message, "Delete Records")
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub GenerateButton_Click(sender As Object, e As EventArgs) Handles GenerateButton.Click
        Me.clear()
        'Generate the data
        'create_students(student_count)
        'create_instructors(instructor_count)
        'create_dept(dept_count)
        'create_courses(courses_count)
        'create_enrolled(enrolled_count)
        'create_prereq(prereq_count)
    End Sub





    Private Sub create_students(count As Integer)
        Try
            con.ConnectionString = con_string
            con.Open()
            cmd.Connection = con
        Catch ex As Exception
            MessageBox.Show("Error while Connecting to Database: " & ex.Message)
        End Try

        'Example insert code. Insert into Students values(2,'bob','bob@bob.com')
        Try
            'inserting into students
            For index As Integer = 0 To count - 1

                cmd.CommandText = "Insert into Students values(" & index + 1 & ", '" & Students(Int((Students.Count) * Rnd())) & index & "','" & index & emails(Int((emails.Count) * Rnd())) & "')"
                cmd.ExecuteNonQuery()
            Next
            MsgBox("Insert into students successful")
        Catch ex As Exception
            MessageBox.Show("Error while inserting records on student table..." & ex.Message, "Delete Records")
        End Try
        con.Close()
    End Sub

    Private Sub Create_instructors(count As Integer)
        Try
            con.ConnectionString = con_string
            con.Open()
            cmd.Connection = con
        Catch ex As Exception
            MessageBox.Show("Error while Connecting to Database: " & ex.Message)
        End Try



    End Sub

End Class