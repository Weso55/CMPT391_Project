Imports System.Data.SqlClient

Public Class Sign_in
    Private con_string As String
    Private Sub SignIn_Click(sender As Object, e As EventArgs) Handles SignIn.Click
        'wes laptop
        'con_string = "Data Source=LAPTOP-I5S445IL\SQLEXPRESS;Initial Catalog=CMPT391;Integrated Security=True"'

        'wes desktop
        con_string = "Data Source=DESKTOP-IRRDDVT\SQLEXPRESS;Initial Catalog=CMPT391;Integrated Security=True"

        ' nathan desktop
        'con_string = "Data Source=DESKTOP-DBHGK71\SQL2017;Initial Catalog=cmpt391;Integrated Security=True"
        Try
            'declare all the connection variables'
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader
            Dim user_text As String
            'new form'
            Dim formEnrolled As New enrolled

            user_text = TextBox1.Text

            'convert text from textbox to integer for sign in'
            Dim myinteger As Integer
            Try
                myinteger = CInt(user_text)
            Catch ex As Exception
                MsgBox("Error: " & ex.Message & " ")
            End Try
            Console.WriteLine(myinteger)
            'replace with your own connection string'
            con.ConnectionString = con_string
            'open connection and query to see if user exists'


            'assign parameters for stored procedure
            Dim params(0) As SqlParameter
            params(0) = New SqlParameter("@username", SqlDbType.VarChar)
            params(0).Value = myinteger

            'Assign variables for connection
            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "Sign_in"
            cmd.Parameters.AddRange(params)
            con.Open()
            dr = cmd.ExecuteReader
            'check if query returned a row -> means the user exists'
            If dr.HasRows Then
                dr.Read()
                MsgBox("Signing in: " + dr("Name"))
                con.Close()
                Me.Hide()
                formEnrolled.start_up(myinteger, con_string, Me)
                formEnrolled.ShowDialog()
            Else
                MsgBox("User does not Exist")
            End If

        Catch ex As Exception
            MsgBox("Error Sign in Failed: " & ex.Message & " ")
            Me.Close()
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'wes laptop
        'con_string = "Data Source=LAPTOP-I5S445IL\SQLEXPRESS;Initial Catalog=CMPT391;Integrated Security=True"'
        'wes desktop
        con_string = "Data Source=DESKTOP-IRRDDVT\SQLEXPRESS;Initial Catalog=CMPT391;Integrated Security=True"
        'nathan desktop
        'con_string = "Data Source=DESKTOP-DBHGK71\SQL2017;Initial Catalog=cmpt391;Integrated Security=True"
        Dim d_form As New Data_Generation
        d_form.startup(con_string)
        d_form.ShowDialog()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub
End Class
