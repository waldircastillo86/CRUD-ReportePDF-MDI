<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TextBox6 = New TextBox()
        Button5 = New Button()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Button6 = New Button()
        Button7 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(134, 36)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(187, 23)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(134, 77)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(187, 23)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(134, 117)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(187, 23)
        TextBox3.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(31, 274)
        Button1.Name = "Button1"
        Button1.Size = New Size(162, 80)
        Button1.TabIndex = 3
        Button1.Text = "Registrar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(58, 85)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 15)
        Label1.TabIndex = 4
        Label1.Text = "usuario"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(55, 39)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 15)
        Label2.TabIndex = 5
        Label2.Text = "nombre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(58, 125)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 15)
        Label3.TabIndex = 6
        Label3.Text = "contraseña"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(117, 399)
        Button2.Name = "Button2"
        Button2.Size = New Size(146, 69)
        Button2.TabIndex = 7
        Button2.Text = "Limpiar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(361, 187)
        Button3.Name = "Button3"
        Button3.Size = New Size(201, 68)
        Button3.TabIndex = 8
        Button3.Text = "Registrar solo que mas imple"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(349, 36)
        Button4.Name = "Button4"
        Button4.Size = New Size(213, 101)
        Button4.TabIndex = 9
        Button4.Text = "Actualizar datos"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(134, 160)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(59, 23)
        TextBox4.TabIndex = 10
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(134, 196)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(187, 23)
        TextBox5.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(31, 163)
        Label4.Name = "Label4"
        Label4.Size = New Size(88, 15)
        Label4.TabIndex = 12
        Label4.Text = "Tipo de usuario"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(14, 196)
        Label5.Name = "Label5"
        Label5.Size = New Size(109, 15)
        Label5.TabIndex = 13
        Label5.Text = "Nombre de usuario"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(14, 235)
        Label6.Name = "Label6"
        Label6.Size = New Size(115, 15)
        Label6.TabIndex = 14
        Label6.Text = "ID USUARIO UPDATE"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(140, 232)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(100, 23)
        TextBox6.TabIndex = 15
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(601, 250)
        Button5.Name = "Button5"
        Button5.Size = New Size(151, 62)
        Button5.TabIndex = 17
        Button5.Text = "Read"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6})
        DataGridView1.Location = New Point(320, 318)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(655, 150)
        DataGridView1.TabIndex = 18
        ' 
        ' Column1
        ' 
        Column1.DataPropertyName = "idusuario"
        Column1.HeaderText = "idusuario"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.DataPropertyName = "nombre"
        Column2.HeaderText = "nombre"
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.DataPropertyName = "usuario"
        Column3.HeaderText = "usuario"
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.DataPropertyName = "contraseña"
        Column4.HeaderText = "contraseña"
        Column4.Name = "Column4"
        ' 
        ' Column5
        ' 
        Column5.DataPropertyName = "tipo_usuario"
        Column5.HeaderText = "tipo_usuario"
        Column5.Name = "Column5"
        ' 
        ' Column6
        ' 
        Column6.DataPropertyName = "nombre_usuario"
        Column6.HeaderText = "nombre_usuario"
        Column6.Name = "Column6"
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(635, 12)
        Button6.Name = "Button6"
        Button6.Size = New Size(137, 72)
        Button6.TabIndex = 19
        Button6.Text = "Generar Reporte PDF"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(635, 112)
        Button7.Name = "Button7"
        Button7.Size = New Size(117, 49)
        Button7.TabIndex = 20
        Button7.Text = "DELETE"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1036, 480)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(DataGridView1)
        Controls.Add(Button5)
        Controls.Add(TextBox6)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "Form3"
        Text = "Form3"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
End Class
