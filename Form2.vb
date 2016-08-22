Imports System.Text.RegularExpressions

Public Class configure

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave

        If Regex.IsMatch(TextBox1.Text, "[^0-9]") Then
            MsgBox("Please enter a number.", MsgBoxStyle.Critical, "Error")
        End If

    End Sub

    Private Sub time_Leave(sender As Object, e As EventArgs) Handles time.Leave

        If Regex.IsMatch(time.Text, "[^0-9]") Then
            MsgBox("Please enter a number.", MsgBoxStyle.Critical, "Error")
        End If

    End Sub

    Private Sub final_Leave(sender As Object, e As EventArgs) Handles final.Leave

        If Regex.IsMatch(final.Text, "[^0-9]") Then
            MsgBox("Please enter a number.", MsgBoxStyle.Critical, "Error")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form1.setRate(Integer.Parse(TextBox1.Text))
        Form1.setTime(Integer.Parse(time.Text))
        Form1.setFinal(Integer.Parse(final.Text))

        If CheckBox1.Checked Then
            Form1.setpressurePlot(0)
        Else
            Form1.setpressurePlot(1)
        End If

        Form1.Show()
        Me.Close()

    End Sub

    Private Sub Preview_Click(sender As Object, e As EventArgs) Handles Preview.Click
        Dim rateTau As Integer = Integer.Parse(TextBox1.Text)
        Dim timeFull As Integer = Integer.Parse(time.Text)
        Dim finalPSI As Integer = Integer.Parse(final.Text)
        Dim plotEqn As New DataVisualization.Charting.Series
        Dim plotAxis As New DataVisualization.Charting.ChartArea

        If CheckBox1.Checked Then
            Chart1.Series.Clear()
            Chart1.ChartAreas.Clear()
            Chart1.Series.Add("")
            Chart1.ChartAreas.Add("")

            constRate(rateTau, timeFull, finalPSI, Chart1.Series.Item(0))
            changeAxis(timeFull, Chart1.ChartAreas.Item(0))

            Chart1.ChartAreas.Item(0).AxisX.IsMarginVisible = False
            Chart1.Series.Item(0).BorderWidth = 3
            Chart1.Series.Item(0).LegendText = "PSI"
            Chart1.Legends.Item(0).Enabled = True
            Chart1.Titles.Item(0).Text = "PSI vs. Time"


        ElseIf CheckBox2.Checked Then
            Chart1.Series.Clear()
            Chart1.ChartAreas.Clear()
            Chart1.Series.Add("")
            Chart1.ChartAreas.Add("")

            exp(rateTau, timeFull, finalPSI, Chart1.Series.Item(0))
            changeAxis(timeFull, Chart1.ChartAreas.Item(0))

            Chart1.ChartAreas.Item(0).AxisX.IsMarginVisible = False
            Chart1.Series.Item(0).BorderWidth = 3
            Chart1.Series.Item(0).LegendText = "PSI"
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

    Private Sub configure_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox1.Text = Form1.getRate()
        time.Text = Form1.getTime()
        final.Text = Form1.getFinal()

    End Sub
End Class