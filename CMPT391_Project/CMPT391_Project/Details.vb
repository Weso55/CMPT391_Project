Imports System.Data.SqlClient


Public Class Details
    Private user_id As Integer
    Private course_id As Integer
    Private con As SqlConnection
    Private cmd As SqlCommand
    Private adpt As SqlDataAdapter
    Public Sub startup(u_id As Integer, c_id As Integer)
        user_id = u_id
        course_id = c_id
    End Sub



End Class