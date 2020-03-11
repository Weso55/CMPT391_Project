Imports System.Data.SqlClient
Public Class Data_Generation
    Private con_string As String
    Public Sub startup(con_str As String)
        con_string = con_str
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Try
            con.ConnectionString = con_string
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Delete From Enrolled"
            'cmd.Parameters.Add(New SqlParameter("@DesignID", yourvaluehere))
            If MessageBox.Show("Do you really want to Delete this Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then

                MsgBox("Operation Cancelled")
                con.Close()
                Exit Sub
            Else
                MsgBox("Tables deleted")
                cmd.ExecuteNonQuery()

            End If
        Catch ex As Exception
            MessageBox.Show("Error while deleting record on table..." & ex.Message, "Delete Records")

        Finally
            con.Close()
        End Try
    End Sub

End Class