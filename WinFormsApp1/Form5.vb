Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form5
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            updatew("UPDATE usuarios set contraseña=contraseña +1 where idusuario = idusuario and contraseña <1")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class