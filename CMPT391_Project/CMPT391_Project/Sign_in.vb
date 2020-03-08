Imports System.Data.SqlClient

Public Class Sign_in
    Private Sub SignIn_Click(sender As Object, e As EventArgs) Handles SignIn.Click

        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader
            Dim user_text As String
            Dim form As New enrolled

            user_text = TextBox1.Text

            Dim myinteger As Integer
            Try
                myinteger = CInt(user_text)
            Catch
                Console.WriteLine("Error with the string")
            End Try
            Console.WriteLine(myinteger)

            con.ConnectionString = "Data Source=DESKTOP-IRRDDVT\SQLEXPRESS;Initial Catalog=CMPT391;Integrated Security=True"
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "select Name from Students where Student_ID =" & myinteger & " "
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                MsgBox("Signing you in")
                con.Close()
                form.Show()
            Else
                MsgBox("User does not Exist")
            End If

        Catch ex As Exception
            MsgBox("Error")
        End Try











    End Sub
End Class
