<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Radiobuttons
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.División = New System.Windows.Forms.RadioButton()
        Me.Multiplicación = New System.Windows.Forms.RadioButton()
        Me.Resta = New System.Windows.Forms.RadioButton()
        Me.Suma = New System.Windows.Forms.RadioButton()
        Me.Num1 = New System.Windows.Forms.TextBox()
        Me.Num2 = New System.Windows.Forms.TextBox()
        Me.operación = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.División)
        Me.GroupBox1.Controls.Add(Me.Multiplicación)
        Me.GroupBox1.Controls.Add(Me.Resta)
        Me.GroupBox1.Controls.Add(Me.Suma)
        Me.GroupBox1.Location = New System.Drawing.Point(47, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(177, 163)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'División
        '
        Me.División.AutoSize = True
        Me.División.Location = New System.Drawing.Point(16, 125)
        Me.División.Name = "División"
        Me.División.Size = New System.Drawing.Size(83, 24)
        Me.División.TabIndex = 3
        Me.División.TabStop = True
        Me.División.Text = "División"
        Me.División.UseVisualStyleBackColor = True
        '
        'Multiplicación
        '
        Me.Multiplicación.AutoSize = True
        Me.Multiplicación.Location = New System.Drawing.Point(16, 95)
        Me.Multiplicación.Name = "Multiplicación"
        Me.Multiplicación.Size = New System.Drawing.Size(124, 24)
        Me.Multiplicación.TabIndex = 2
        Me.Multiplicación.TabStop = True
        Me.Multiplicación.Text = "Multiplicación"
        Me.Multiplicación.UseVisualStyleBackColor = True
        '
        'Resta
        '
        Me.Resta.AutoSize = True
        Me.Resta.Location = New System.Drawing.Point(16, 65)
        Me.Resta.Name = "Resta"
        Me.Resta.Size = New System.Drawing.Size(66, 24)
        Me.Resta.TabIndex = 1
        Me.Resta.TabStop = True
        Me.Resta.Text = "Resta"
        Me.Resta.UseVisualStyleBackColor = True
        '
        'Suma
        '
        Me.Suma.AutoSize = True
        Me.Suma.Location = New System.Drawing.Point(16, 35)
        Me.Suma.Name = "Suma"
        Me.Suma.Size = New System.Drawing.Size(67, 24)
        Me.Suma.TabIndex = 0
        Me.Suma.TabStop = True
        Me.Suma.Text = "Suma"
        Me.Suma.UseVisualStyleBackColor = True
        '
        'Num1
        '
        Me.Num1.Location = New System.Drawing.Point(243, 122)
        Me.Num1.Name = "Num1"
        Me.Num1.Size = New System.Drawing.Size(74, 27)
        Me.Num1.TabIndex = 4
        '
        'Num2
        '
        Me.Num2.Location = New System.Drawing.Point(243, 74)
        Me.Num2.Name = "Num2"
        Me.Num2.Size = New System.Drawing.Size(74, 27)
        Me.Num2.TabIndex = 5
        '
        'operación
        '
        Me.operación.Location = New System.Drawing.Point(243, 164)
        Me.operación.Name = "operación"
        Me.operación.Size = New System.Drawing.Size(74, 38)
        Me.operación.TabIndex = 6
        Me.operación.Text = "ejecutar"
        Me.operación.UseVisualStyleBackColor = True
        '
        'Radiobuttons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 220)
        Me.Controls.Add(Me.operación)
        Me.Controls.Add(Me.Num1)
        Me.Controls.Add(Me.Num2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Radiobuttons"
        Me.Text = "Radiobuttons"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents División As RadioButton
    Friend WithEvents Multiplicación As RadioButton
    Friend WithEvents Resta As RadioButton
    Friend WithEvents Suma As RadioButton
    Friend WithEvents Num1 As TextBox
    Friend WithEvents Num2 As TextBox
    Friend WithEvents operación As Button
End Class
