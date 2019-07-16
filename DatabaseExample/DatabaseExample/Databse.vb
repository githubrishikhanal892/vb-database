
Imports System.Data
Imports System.Data.OleDb
Public Class Databse
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Sub New()
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\database\College.accdb")
        cmd = New OleDbCommand
        cmd.Connection = con
    End Sub
    Public Sub Connect()

        If (con.State = ConnectionState.Closed) Then

            Try

                con.Open()
            Catch e As OleDbException

                MessageBox.Show(e.ToString)

            End Try
        End If
    End Sub
    Public Sub Disconnect()

        If (con.State = ConnectionState.Open) Then

            Try

                con.Close()

            Catch e As OleDbException

                MessageBox.Show(e.ToString)
            End Try
        End If
    End Sub


    Public Function Insert(ByVal name As String, ByVal address As String) As DataSet
        Dim i As Integer = -1
        Connect()
        cmd.CommandText = " insert into Student(Name,Address)Values(@name,@address)"
        cmd.Parameters.AddWithValue("@name", name)
        cmd.Parameters.AddWithValue("@address", address)
        cmd.ExecuteNonQuery()
        Dim retrievequery = "select *from Student"
        Dim adtp As OleDbDataAdapter = New OleDbDataAdapter(retrievequery, con)
        Dim ds As DataSet = New DataSet
        adtp.Fill(ds, "Student")
        '  DataGridView1.DataSource = ds.Tables(0)
        'Try
        '    i = cmd.ExecuteNonQuery
        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString)
        '    i = -1


        ' End Try

        ' Return i
        Return ds
    End Function

    Public Function FormData() As DataSet
        Connect()
        Dim retrievequery = "select *from Student"
        Dim adtp As OleDbDataAdapter = New OleDbDataAdapter(retrievequery, con)
        Dim ds As DataSet = New DataSet
        adtp.Fill(ds, "Student")
        Return ds
    End Function
End Class
