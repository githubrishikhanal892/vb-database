Imports System.Data.OleDb
Public Class Form1

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        Dim name, address As String
        name = Txtname.Text
        address = TxtAddress.Text
        ' Dim constring As OleDbConnection
        'Dim query As OleDbCommand = New OleDbCommand
        'constring = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\database\College.accdb")
        ' Try
        '   query.Connection = constring
        '  constring.Open()

        'query.CommandText = "insert into Student(Name,Address)Values(@name,@address)"
        'query.Parameters.AddWithValue("@name", name)
        'query.Parameters.AddWithValue("@address", address)
        'query.ExecuteNonQuery()
        'Dim retrievequery = "select *from Student"
        'Dim adtp As OleDbDataAdapter = New OleDbDataAdapter(retrievequery, constring)
        'Dim ds As DataSet = New DataSet
        'adtp.Fill(ds, "Student")
        'DataGridView1.DataSource = ds.Tables(0)
        ''   MessageBox.Show("data added")
        'constring.Close()
        'Catch ex As Exception
        '    MsgBox("Can not open connection ! ")
        'End Try
        Dim data As DataSet
        Dim database As Databse = New Databse
        data = database.Insert(name, address)
        DataGridView1.DataSource = data.Tables(0)
        ''   If (res = -1) Then
        'MessageBox.Show("Data can not be inserted")
        'Else
        'MessageBox.Show("Data inserted")
        'End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Dim constring As OleDbConnection
        'Dim query As OleDbCommand = New OleDbCommand
        'constring = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\database\College.accdb")
        'Try
        'query.Connection = constring
        'constring.Open()
        'Dim retrievequery = "select *from Student"
        'Dim adtp As OleDbDataAdapter = New OleDbDataAdapter(retrievequery, constring)
        'Dim ds As DataSet = New DataSet
        'adtp.Fill(ds, "Student")
        'DataGridView1.DataSource = ds.Tables(0)
        '   MessageBox.Show("data added")
        'constring.Close()
        'Catch ex As Exception
        'MsgBox("Can not open connection ! ")
        'End Try
        Dim alldata As Databse = New Databse
        Dim retrieveddata As DataSet
        retrieveddata = alldata.FormData()
        DataGridView1.DataSource = retrieveddata.Tables(0)

    End Sub
End Class
