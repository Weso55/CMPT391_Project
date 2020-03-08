Imports System.Data.SqlClient

Public Class Sign_in

    Private Sub SignIn_Click(sender As Object, e As EventArgs) Handles SignIn.Click

        Try
            'declare all the connection variables'
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader
            Dim user_text As String
            'new form'
            Dim form As New enrolled

            user_text = TextBox1.Text

            'convert text from textbox to integer for sign in'
            Dim myinteger As Integer
            Try
                myinteger = CInt(user_text)
            Catch
                Console.WriteLine("Error with the string")
            End Try
            Console.WriteLine(myinteger)
            'replace with your own connection string'
            con.ConnectionString = "Data Source=DESKTOP-IRRDDVT\SQLEXPRESS;Initial Catalog=CMPT391;Integrated Security=True"
            'open connection and query to see if user exists'
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select Name from Students where Student_ID =" & myinteger & " "
            dr = cmd.ExecuteReader
            'check if query returned a row -> means the user exists'
            If dr.HasRows Then
                MsgBox("Signing you in")
                con.Close()
                Me.Hide()
                form.start_up(myinteger)
                form.ShowDialog()
                Me.Close()
            Else
                MsgBox("User does not Exist")
            End If

        Catch ex As Exception
            MsgBox("Error")
            Me.Close()
        End Try











    End Sub
End Class
