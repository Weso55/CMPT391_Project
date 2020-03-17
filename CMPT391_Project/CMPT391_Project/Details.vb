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

        Dim cap As Integer
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

            params(4) = New SqlParameter("@yr", SqlDbType.VarChar)
            params(4).Value = year

            'Assign variables for connection
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "Enroll_Student"
            command.Parameters.AddRange(params)
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
