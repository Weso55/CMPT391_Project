Imports System.Data.SqlClient
Public Class Data_Generation
    Private con_string As String

    'list of values to randomly choose
    Private Semesters As New List(Of String) From {"Summer", "Spring", "Winter", "Fall"}
    Private Instructors As New List(Of String) From {"john", "ryan", "candy", "bob"}
    Private Students As New List(Of String) From {"bob", "wes", "Collin", "Brett"}
    Private Department As New List(Of String) From {"Math", "Business", "Computer Science", "Arts", "Chemistry", "Biology"}
    Private Year As New List(Of Integer) From {2020, 2021, 2022, 2023}
    Private Courses As New List(Of String) From {"Math100", "Math200", "Math300", "CMPT100", "CMPT200", "CMPT300", "BIO100", "BIO200", "BIO300", "CHEM100", "CHEM200", "CHEM300"}
    Private Sect_ID As New List(Of String) From {"AS01", "AS02", "AS03", "AS04", "X01L", "AS05", "AS06", "AS07", "AS08", "X02L", "AS09", "AS10"}
    Private emails As New List(Of String) From {"john@god.com", "ryansucks@sucks.com", "candysgreat@great.com", "bob@bob.com"}
    ' connection
    Private con As New SqlConnection
    Private cmd As New SqlCommand
    ' default numbers
    Private student_count As Integer = 300
    Private instructor_count As Integer = 20
    Private dept_count As Integer = 10
    Private courses_count As Integer = 40
    Private enrolled_count As Integer = 100
    Private prereq_count As Integer = 10


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
                cmd.CommandText = "Delete From Enrolled"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "Delete From Students"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "Delete From Department"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "Delete From Instructors"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "Delete From Prereq"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "Delete From Courses"
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
        create_students(student_count)
        create_instructors(instructor_count)
        create_dept(dept_count)
        create_courses(courses_count)
        create_enrolled(enrolled_count)
        create_prereq(prereq_count)
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

    Private Sub create_instructors(count As Integer)
        Try
            con.ConnectionString = con_string
            con.Open()
            cmd.Connection = con
        Catch ex As Exception
            MessageBox.Show("Error while Connecting to Database: " & ex.Message)
        End Try

        'Example insert code. insert into Instructors values(1,1,'name','email')
        Try
            'inserting into Instructors
            For index As Integer = 0 To count - 1
                ' make sure that depts has head instructor that makes sense
                If index + 1 <= dept_count Then
                    cmd.CommandText = "Insert into Instructors values(" & index + 1 & ", " & index + 1 & ", '" & Instructors(Int((Instructors.Count) * Rnd())) & index & "','" & index & emails(Int((emails.Count) * Rnd())) & "')"
                    cmd.ExecuteNonQuery()
                Else
                    cmd.CommandText = "Insert into Instructors values(" & index + 1 & ", " & Int((dept_count) * Rnd()) & ", '" & Instructors(Int((Instructors.Count) * Rnd())) & index & "','" & index & emails(Int((emails.Count) * Rnd())) & "')"
                    cmd.ExecuteNonQuery()
                End If
                'Console.WriteLine("Insert into Students values(" & index & ", '" & Students(Int((Students.Count) * Rnd())) & index & "','" & index & emails(Int((emails.Count) * Rnd())) & "')")
            Next
            MsgBox("Insert into Instructors successful")
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on instructor table..." & ex.Message, "Delete Records")
        End Try
        con.Close()
    End Sub



    Private Sub create_dept(count As Integer)
        Try
            con.ConnectionString = con_string
            con.Open()
            cmd.Connection = con
        Catch ex As Exception
            MessageBox.Show("Error while Connecting to Database: " & ex.Message)
        End Try

        'Example insert code: insert into Department values(1,1,'name')
        Try
            'inserting into Department
            For index As Integer = 0 To count - 1
                Console.WriteLine(index)
                cmd.CommandText = "Insert into Department values(" & index + 1 & ", " & index + 1 & ", '" & Department(Int((Instructors.Count) * Rnd())) & index & "')"
                cmd.ExecuteNonQuery()
                'Console.WriteLine("Insert into Students values(" & index & ", '" & Students(Int((Students.Count) * Rnd())) & index & "','" & index & emails(Int((emails.Count) * Rnd())) & "')")
            Next
            MsgBox("Insert into Department successful")
        Catch ex As Exception
            MessageBox.Show("Error while inserting records Department table..." & ex.Message, "Delete Records")
        End Try
        con.Close()
    End Sub

    Private Sub create_courses(count As Integer)
        Try
            con.ConnectionString = con_string
            con.Open()
            cmd.Connection = con
        Catch ex As Exception
            MessageBox.Show("Error while Connecting to Database: " & ex.Message)
        End Try

        'Example insert code: insert into Courses values(1,1,1,section_id,semester,year,name,capacity)
        Try
            'inserting into Courses
            For index As Integer = 0 To count - 1
                cmd.CommandText = "Insert into Courses values(" & index + 1 & ", " & Int((dept_count) * Rnd()) & "," & Int((instructor_count) * Rnd()) & ", '" & Sect_ID(Int((Sect_ID.Count) * Rnd())) & "','" & Semesters(Int((Semesters.Count) * Rnd())) & "','" & Year(Int((Year.Count) * Rnd())) & "','" & Courses(Int((Courses.Count) * Rnd())) & "'," & 20 & ")"
                cmd.ExecuteNonQuery()
            Next
            MsgBox("Insert into Courses successful")
        Catch ex As Exception
            MessageBox.Show("Error while inserting records Courses table..." & ex.Message, "Delete Records")
        End Try
        con.Close()
    End Sub

    Private Sub create_enrolled(count As Integer)
        Try
            con.ConnectionString = con_string
            con.Open()
            cmd.Connection = con
        Catch ex As Exception
            MessageBox.Show("Error while Connecting to Database: " & ex.Message)
        End Try

        'Example insert code: insert into Enrolled values(student_id,Course_id,semester,year)
        Try
            'inserting into Enrolled
            For index As Integer = 0 To count - 1
                cmd.CommandText = "Insert into Enrolled values(" & Int((student_count) * Rnd()) & "," & Int((courses_count) * Rnd()) & ",'" & Semesters(Int((Semesters.Count) * Rnd())) & "'," & Year(Int((Year.Count) * Rnd())) & ")"
                cmd.ExecuteNonQuery()
            Next
            MsgBox("Insert into Enrolled successful")
        Catch ex As Exception
            MessageBox.Show("Error while inserting records enrolled table..." & ex.Message, "Delete Records")
        End Try
        con.Close()
    End Sub

    Private Sub create_prereq(count As Integer)
        Try
            con.ConnectionString = con_string
            con.Open()
            cmd.Connection = con
        Catch ex As Exception
            MessageBox.Show("Error while Connecting to Database: " & ex.Message)
        End Try

        'Example insert code: insert into Prereq values(Course_id,prereq_id)
        Try
            'inserting into Prereq
            For index As Integer = 0 To count - 1
                cmd.CommandText = "Insert into Prereq values(" & Int((courses_count) * Rnd()) & ", " & Int((prereq_count) * Rnd()) & ")"
                cmd.ExecuteNonQuery()
                'Console.WriteLine("Insert into Prereq values(" & Int((courses_count) * Rnd()) & ", " & Int((prereq_count) * Rnd()) & ")")
            Next
            MsgBox("Insert into prereq successful")
        Catch ex As Exception
            MessageBox.Show("Error while inserting records enrolled table..." & ex.Message, "Delete Records")
        End Try
        con.Close()
    End Sub


End Class