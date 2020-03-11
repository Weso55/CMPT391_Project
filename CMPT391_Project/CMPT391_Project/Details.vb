Imports System.Data
Imports System.Data.SqlClient


Public Class Details
    Private user_id As Integer
    Private course_id As Integer

    Public Sub startup(u_id As Integer, c_id As Integer)
        user_id = u_id
        course_id = c_id
        Dim cap As Integer
        Try
            Dim con As New SqlConnection
            con.ConnectionString = ("Data Source=DESKTOP-IRRDDVT\SQLEXPRESS;Initial Catalog=CMPT391;Integrated Security=True")
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
            MsgBox("Error")

        End Try

        Try
            Dim con2 As New SqlConnection
            con2.ConnectionString = ("Data Source=DESKTOP-IRRDDVT\SQLEXPRESS;Initial Catalog=CMPT391;Integrated Security=True")
            con2.Open()
            Dim strsql2 As String
            strsql2 = "SELECT COUNT(Couse_ID) AS num from Enrolled where Couse_ID = '" & course_id & "' "
            Dim cmd2 As New SqlCommand(strsql2, con2)
            Dim dr2 As SqlDataReader
            dr2 = cmd2.ExecuteReader
            dr2.Read()
            'add capacity to detail and fix naming
            StatusLabel.Text = dr2("num") & " /" & cap & " "
            con2.Close()
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub



End Class
