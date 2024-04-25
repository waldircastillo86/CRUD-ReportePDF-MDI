Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Conectarse con el servidor de xampp'
            conectarmysql = New MySqlConnection("server=localhost;" + "database=ejercicio1;user=root;password=;")
            conectarmysql.Open()
            conectarmysqlcomand = New MySqlCommand
            conectarmysqlcomand.CommandType = CommandType.Text
            conectarmysqlcomand.Connection = conectarmysql
        Catch ex As Exception
            MsgBox("Error nos falta ejecutar el SQL o el XAMPP " + ex.Message, MsgBoxStyle.Critical, "BD ERROR")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conectarmysqlcomand.CommandText = "select * from usuarios where usuario='" + TextBox1.Text + "'AND contraseña='" + TextBox2.Text + "'"
        Dim waldir As MySqlDataReader
        waldir = conectarmysqlcomand.ExecuteReader
        If waldir.HasRows <> False Then
            MsgBox("Acceso Correcto")
            Form5.Show()
        Else
            MsgBox("Acceso DENEGADO")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
    End Sub
End Class
