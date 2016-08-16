Imports System.Text.RegularExpressions

Public Class config
    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave

        If Regex.IsMatch(TextBox1.Text, "\b[^0-9]*\b") Then
            MsgBox("Please enter a number between 100 and 360.", MsgBoxStyle.Critical, "Error")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        objForm1.Visible = True
        objConfig.Visible = False
    End Sub
End Class