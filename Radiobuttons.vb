Public Class Radiobuttons
    Private Sub operación_Click(sender As Object, e As EventArgs) Handles operación.Click
        Dim n1, n2 As Integer
        Dim resultado As Double

        n1 = Num1.Text
        n2 = Num2.Text

        If (Suma.Checked = True) Then
            resultado = n1 + n2
        ElseIf (Resta.Checked = True) Then
            resultado = n1 - n2
        ElseIf (Multiplicación.Checked = True) Then
            resultado = n1 * n2
        ElseIf (División.Checked) Then
            resultado = n1 / n2
        End If
        MsgBox("El resultado de la operación es" + resultado.ToString)
    End Sub

    Private Sub Resta_CheckedChanged(sender As Object, e As EventArgs) Handles Resta.CheckedChanged

    End Sub
End Class