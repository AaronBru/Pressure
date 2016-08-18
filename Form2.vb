Imports System.Text.RegularExpressions

Public Class config
    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave

        If Regex.IsMatch(TextBox1.Text, "[^0-9]") Then
            MsgBox("Please enter a number.", MsgBoxStyle.Critical, "Error")
        End If

    End Sub

    Private Sub time_Leave(sender As Object, e As EventArgs) Handles time.Leave

        If Regex.IsMatch(TextBox1.Text, "[^0-9]") Then
            MsgBox("Please enter a number.", MsgBoxStyle.Critical, "Error")
        End If

    End Sub

    Private Sub final_Leave(sender As Object, e As EventArgs) Handles final.Leave

        If Regex.IsMatch(TextBox1.Text, "[^0-9]") Then
            MsgBox("Please enter a number.", MsgBoxStyle.Critical, "Error")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        objForm1.Visible = True
        objConfig.Visible = False

    End Sub

    Private Sub Preview_Click(sender As Object, e As EventArgs) Handles Preview.Click
        Dim rateTau As Integer = Integer.Parse(TextBox1.Text)
        Dim timeFull As Integer = Integer.Parse(time.Text)
        Dim finalPSI As Integer = Integer.Parse(final.Text)
        Dim plotEqn As New DataVisualization.Charting.Series
        Dim plotAxis As New DataVisualization.Charting.ChartArea

        If CheckBox1.Checked Then
            constRate(rateTau, timeFull, finalPSI, plotEqn)
            Chart1.Series.Clear()
            Chart1.Series.Add(plotEqn)
            Chart1.ChartAreas.Clear()
            changeAxis(timeFull, plotAxis)
            Chart1.ChartAreas.Add(plotAxis)
            Chart1.Series.Item(0).BorderWidth = 3
            Chart1.Series.Item(0).LegendText = "PSI"
            Chart1.Legends.Item(0).Enabled = True
            Chart1.Titles.Item(0).Text = "PSI vs. Time"


        ElseIf CheckBox2.Checked Then
            exp(rateTau, timeFull, finalPSI, plotEqn)
            Chart1.Series.Clear()
            Chart1.Series.Add(plotEqn)
            changeAxis(timeFull, plotAxis)
            Chart1.ChartAreas.Clear()
            Chart1.ChartAreas.Add(plotAxis)
            Chart1.Series.Item(0).LegendText = "PSI"
            Chart1.Series.Item(0).BorderWidth = 3
            Chart1.Legends.Item(0).Enabled = True
            Chart1.Titles.Item(0).Text = "PSI vs. Time"
        End If

    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            CheckBox2.Checked = False
            Label3.Text = "Rate (PSI/min)"
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            CheckBox1.Checked = False
            Label3.Text = "Time Constant"
        End If
    End Sub

End Class