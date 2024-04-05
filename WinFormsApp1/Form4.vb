Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports MySql.Data.MySqlClient

Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ' Llama a la función del módulo con la consulta deseada
            Module1.GenerarPDFUsuarios("SELECT nombre, usuario, contraseña FROM usuarios;")
        Catch ex As Exception
            MessageBox.Show("Error al generar el PDF: " & ex.Message)
        End Try
    End Sub



End Class
