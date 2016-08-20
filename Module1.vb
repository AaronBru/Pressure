Module Module1

    Sub exp(ByVal tau As Integer, ByVal time As Integer, ByVal final As Integer, ByRef curve As DataVisualization.Charting.Series)

        Dim timeInt As Double
        Dim yCoord As Double

        curve.ChartType = DataVisualization.Charting.SeriesChartType.Line

        For i As Integer = 0 To 10 * time
            timeInt = CDbl(i / 10.0)
            yCoord = timeInt / CDbl(tau)
            curve.Points.AddXY(timeInt, final - final * System.Math.Exp(-yCoord))
        Next

    End Sub

    Sub constRate(ByVal rate As Integer, ByVal time As Integer, ByVal final As Integer, ByRef curve As DataVisualization.Charting.Series)

        Dim timeInt As Double
        Dim yCoord As Double = 0
        Dim rateSec As Double = rate / 60

        curve.ChartType = DataVisualization.Charting.SeriesChartType.Line

        For i As Integer = 0 To 10 * time
            timeInt = CDbl(i / 10.0)
            If yCoord >= final Then
                yCoord = final
                curve.Points.AddXY(timeInt, yCoord)
            Else
                yCoord = rateSec * timeInt
                curve.Points.AddXY(timeInt, yCoord)
            End If
        Next

    End Sub

    Sub changeAxis(ByVal finalTime As Integer, ByRef area As DataVisualization.Charting.ChartArea)
        area.AxisX.Maximum = finalTime
        area.AxisX.LabelStyle.Format = "#####"
        area.AxisX.Title = "Time (sec)"
        area.AxisY.Title = "PSI"
    End Sub

End Module
