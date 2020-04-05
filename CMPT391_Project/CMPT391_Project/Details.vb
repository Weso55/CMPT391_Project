Imports System.Data
Imports System.Data.SqlClient


Public Class Details
    Private user_id As Integer
    Private course_id As Integer
    Private semester As String
    Private year As Integer
    Private section As String
    Private con_string As String
    Public PrevPage As Form
    Private cap As Integer

    Private cmd As SqlCommand
     Private con As SqlConnection

    Public Sub startup(u_id As Integer, c_id As Integer, sem As String, yr As Integer, sec As String, con_s As String, prevp As Course_List)
        user_id = u_id
        course_id = c_id
        semester = sem
        year = yr
        section = sec
        con_string = con_s
        PrevPage = prevp

        'Dim cap As Integer
        Try
            'open new connection'
            con = New SqlConnection(con_string)
            cmd = New SqlCommand
            'assign parameters for stored procedure

            Dim params(3) As SqlParameter
            params(0) = New SqlParameter("@course_id", SqlDbType.Int)
            params(0).Value = course_id

            params(1) = New SqlParameter("@sem", SqlDbType.VarChar)
            params(1).Value = semester

            params(2) = New SqlParameter("@yr", SqlDbType.VarChar)
            params(2).Value = year

            params(3) = New SqlParameter("@sect", SqlDbType.VarChar)
            params(3).Value = section

            'Assign variables for connection
            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "Detail_Startup_Data"
            cmd.Parameters.AddRange(params)
            con.Open()

            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            dr.Read()

            CourseNameLabel.Text = dr("C_Name")
            SectionLabel.Text = dr("S_ID")
            InstructorLabel.Text = dr("I_name")
            DepartmentLabel.Text = dr("D_name")
            cap = dr("cap")
            con.Close()
        Catch ex As Exception
            MsgBox("Error filling detail info: " & ex.Message & " ")

        End Try

        'Count number of enrolled student in the class using the enrolled table

        Try

            'open new connection'
            con = New SqlConnection(con_string)
            cmd = New SqlCommand
            'assign parameters for stored procedure

            Dim params(3) As SqlParameter
            params(0) = New SqlParameter("@course_id", SqlDbType.Int)
            params(0).Value = course_id

            params(1) = New SqlParameter("@sem", SqlDbType.VarChar)
            params(1).Value = semester

            params(2) = New SqlParameter("@yr", SqlDbType.VarChar)
            params(2).Value = year

            params(3) = New SqlParameter("@sect", SqlDbType.VarChar)
            params(3).Value = section

            'Assign variables for connection
            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "Enrolled_Course_Count"
            cmd.Parameters.AddRange(params)
            con.Open()

            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            dr.Read()

            'add capacity to detail and fix naming
            StatusLabel.Text = dr("num") & " /" & cap & " "
            con.Close()

        Catch ex As Exception
            MsgBox("Error Count Failed: " & ex.Message & " ")
        End Try
        ' 
        Try
            con = New SqlConnection(con_string)
            cmd = New SqlCommand
            'assign parameters for stored procedure

            Dim params(0) As SqlParameter
            params(0) = New SqlParameter("@course_id", SqlDbType.Int)
            params(0).Value = course_id

            'Assign variables for connection
            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "Detail_Prereq"
            cmd.Parameters.AddRange(params)
            con.Open()

            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            dr.Read()
            PrereqLabel.Text = dr("Name")
            con.Close()

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

            Dim params(4) As SqlParameter

            params(0) = New SqlParameter("@user_id", SqlDbType.Int)
            params(0).Value = user_id

            params(1) = New SqlParameter("@course_id", SqlDbType.Int)
            params(1).Value = course_id

            params(2) = New SqlParameter("@sect", SqlDbType.VarChar)
            params(2).Value = section

            params(3) = New SqlParameter("@sem", SqlDbType.VarChar)
            params(3).Value = semester

            params(4) = New SqlParameter("@yr", SqlDbType.Int)
            params(4).Value = year

            'checking if already enrolled
            Dim command2 As New SqlCommand
            command2 = con3.CreateCommand
            command2.Connection = con3
            command2.Transaction = transaction
            Try
                command2.CommandType = CommandType.StoredProcedure
                Dim dr As SqlDataReader

                command2.CommandText = "Check_Enrolled"
                command2.Parameters.AddRange(params)

                dr = command2.ExecuteReader
                dr.Read()
                If (dr.HasRows) Then 'already enrolled
                    'Debug.WriteLine("has rows")
                    Try
                        dr.Close()
                        command2.Parameters.Clear()
                        transaction.Rollback()
                        MsgBox("You are already enrolled in this course!")
                        Exit Sub
                    Catch ex2 As Exception
                        MsgBox("Error Rollback Failed: " & ex2.Message & " ")
                    End Try
                Else
                    'Debug.WriteLine("has no rows")
                    dr.Close()
                    command2.Parameters.Clear()
                    'Debug.WriteLine("end check_enrolled")
                End If
            Catch ex As Exception
                MsgBox("Error Enroll Check Failed: " & ex.Message & " ")
                Try
                    transaction.Rollback()
                Catch ex2 As Exception
                    MsgBox("Error Rollback Failed: " & ex2.Message & " ")
                End Try
            End Try

            'checking if course is full
            Dim command3 As New SqlCommand
            command3 = con3.CreateCommand
            command3.Connection = con3
            command3.Transaction = transaction
            Try
                command3.CommandType = CommandType.StoredProcedure
                Dim dr2 As SqlDataReader

                Dim params2(3) As SqlParameter
                params2(0) = New SqlParameter("@course_id", SqlDbType.Int)
                params2(0).Value = course_id
                params2(1) = New SqlParameter("@sem", SqlDbType.VarChar)
                params2(1).Value = semester
                params2(2) = New SqlParameter("@yr", SqlDbType.VarChar)
                params2(2).Value = year
                params2(3) = New SqlParameter("@sect", SqlDbType.VarChar)
                params2(3).Value = section

                command3.CommandText = "Enrolled_Course_Count"
                'Debug.WriteLine("before add params to enrolled course count")
                command3.Parameters.AddRange(params2)

                dr2 = command3.ExecuteReader
                dr2.Read()
                'Debug.WriteLine("cap = " & cap)
                If (dr2("num") = cap) Then 'course is full
                    'Debug.WriteLine("is full")
                    Try
                        dr2.Close()
                        command3.Parameters.Clear()
                        transaction.Rollback()
                        MsgBox("Course is full!")
                        Exit Sub
                    Catch ex2 As Exception
                        MsgBox("Error Rollback Failed: " & ex2.Message & " ")
                    End Try
                Else
                    'Debug.WriteLine("is not full")
                    dr2.Close()
                    command3.Parameters.Clear()
                End If
            Catch ex As Exception
                MsgBox("Error Capacity Check Failed: " & ex.Message & " ")
                Try
                    transaction.Rollback()
                Catch ex2 As Exception
                    MsgBox("Error Rollback Failed: " & ex2.Message & " ")
                End Try
            End Try

            'Debug.WriteLine("end error checking")

            'Assign variables for connection
            'Debug.WriteLine("before command type")
            command.CommandType = CommandType.StoredProcedure
            'Debug.WriteLine("before enroll_student")
            command.CommandText = "Enroll_Student"
            'Debug.WriteLine("before add params")
            command.Parameters.AddRange(params)
            'Debug.WriteLine("about to enroll")
            command.ExecuteNonQuery()
            'Debug.WriteLine("after enroll")


            transaction.Commit()
            Debug.WriteLine("Transaction committed")
            MsgBox("Successfully enrolled!")

        Catch ex As Exception
            'Debug.WriteLine("ex 1")
            MsgBox("Error Enroll Failed: " & ex.Message & " ")

            Try
                transaction.Rollback()
            Catch ex2 As Exception
                'Debug.WriteLine("ex2")
                MsgBox("Error Rollback Failed: " & ex2.Message & " ")
            End Try

        End Try


    End Sub
End Class
