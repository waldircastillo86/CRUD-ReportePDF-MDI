Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud

Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Tabla As New DataTable
        Dim Conexion As MySqlConnection
        Dim Ds As New DataSet
        Conexion = New MySql.Data.MySqlClient.MySqlConnection
        Conexion.ConnectionString = "server=localhost; user = root; database = ejercicio1;"
        Dim insertar As New MySqlDataAdapter("insert into usuarios(nombre, usuario, contraseña) values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')", conectarmysql)
        Try
            insertar.Fill(Tabla)
            MessageBox.Show("Su registro ha sido exitoso")
        Catch Mierror As MySqlException
            MessageBox.Show("Error, Su registro no se completo")
        Finally
        End Try
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            create("insert into usuarios(nombre, usuario, contraseña, tipo_usuario, nombre_usuario) values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "')")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            updatew("UPDATE usuarios SET nombre='" & TextBox1.Text & "', usuario='" & TextBox2.Text & "', contraseña='" & TextBox3.Text & "', tipo_usuario='" & TextBox4.Text & "', nombre_usuario='" & TextBox5.Text & "' WHERE idusuario='" & TextBox6.Text & "'")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            read("SELECT * FROM usuarios", DataGridView1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub








    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            GenerarPDFUsuarios("SELECT nombre, usuario, nombre_usuario FROM `usuarios` WHERE idusuario=6;")
        Catch ex As Exception
            MessageBox.Show("Error al generar el PDF: " & ex.Message)
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Try
            ' Llama a la función del módulo con la consulta deseada
            GenerarPDFUsuarios("SELECT * FROM usuarios;")
        Catch ex As Exception
            MessageBox.Show("Error al generar el PDF: " & ex.Message)
        End Try
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            deletew("delete from usuarios WHERE idusuario='" & TextBox6.Text & "'")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class