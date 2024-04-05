Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports MySql.Data.MySqlClient

Module Module1
    Public conectarmysql As MySqlConnection
    Public conectarmysqlcomand As MySqlCommand

    Public Function strconnection() As MySqlConnection
        Return New MySqlConnection("server=localhost;user id=root;password=;database=ejercicio1")
    End Function

    Public strcon As MySqlConnection = strconnection()
    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable

    Public Sub create(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Error en los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Se Guardaron los datos", "COMPLETO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub

    Public Sub updatew(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Error en los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Se ACTUALIZARON los datos", "COMPLETO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub

    Public Sub deletew(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Error en eliminar los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Se elimino el registro ", "Exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub
    Public Sub read(ByVal sql As String, ByVal DTG As Object)
        Try
            dt = New DataTable
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            DTG.datasource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
            da.Dispose()
        End Try
    End Sub



    Public Sub GenerarPDFUsuarios(ByVal consulta As String)
        Try
            ' Mostrar un cuadro de diálogo para seleccionar la ubicación del PDF
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Archivo PDF (*.pdf)|*.pdf"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Dim rutaPDF As String = saveFileDialog.FileName

                ' Realizar la consulta a la base de datos
                Dim dataTable As New DataTable()

                Using connection As MySqlConnection = strconnection()
                    Using command As New MySqlCommand(consulta, connection)
                        connection.Open()
                        Using adapter As New MySqlDataAdapter(command)
                            adapter.Fill(dataTable)
                        End Using
                    End Using
                End Using

                ' Crear el documento PDF
                Using fs As New FileStream(rutaPDF, FileMode.Create)
                    Dim document As New Document()
                    PdfWriter.GetInstance(document, fs)
                    document.Open()

                    ' Agregar título centrado al PDF
                    Dim titulo As New Paragraph()
                    titulo.Alignment = Element.ALIGN_CENTER
                    titulo.Add(New Phrase("Reporte de Usuarios"))
                    document.Add(titulo)

                    ' Agregar los datos de la consulta al PDF en forma de tabla
                    Dim tabla As New PdfPTable(dataTable.Columns.Count)
                    tabla.WidthPercentage = 100

                    ' Agregar encabezados de columnas
                    For Each col As DataColumn In dataTable.Columns
                        Dim celda As New PdfPCell(New Phrase(col.ColumnName))
                        celda.HorizontalAlignment = Element.ALIGN_CENTER
                        celda.VerticalAlignment = Element.ALIGN_MIDDLE
                        tabla.AddCell(celda)
                    Next

                    ' Agregar datos de las filas
                    For Each row As DataRow In dataTable.Rows
                        For Each col As DataColumn In dataTable.Columns
                            Dim celda As New PdfPCell(New Phrase(row(col).ToString()))
                            celda.HorizontalAlignment = Element.ALIGN_CENTER
                            celda.VerticalAlignment = Element.ALIGN_MIDDLE
                            tabla.AddCell(celda)
                        Next
                    Next

                    ' Agregar la tabla al documento
                    document.Add(tabla)

                    ' Cerrar el documento
                    document.Close()

                    ' Mostrar un mensaje de éxito
                    MessageBox.Show("PDF creado correctamente en " & rutaPDF)
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Error al crear el PDF: " & ex.Message)
        End Try
    End Sub


End Module
