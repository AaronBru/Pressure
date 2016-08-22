Imports System.Runtime.InteropServices

Public Class Form1

    Private daqDevice As MccDaq.DaqDeviceDescriptor()
    Private boardExists As Boolean
    Private AInRange As MccDaq.Range = MccDaq.Range.Bip10Volts
    Private AInMode As MccDaq.AInputMode = MccDaq.AInputMode.SingleEnded
    Private count As Integer = 0
    Private DaqBoard As New MccDaq.MccBoard()

    Private rateTau As Integer
    Private timeFull As Integer
    Private finalPSI As Integer
    Private pressurePlot As Integer

    Private timer As System.Timers.Timer()
    Private secCount As Integer

    Public Sub New()

        InitializeComponent()
        rateTau = 50
        timeFull = 1800
        finalPSI = 600
        boardExists = False
        pressurePlot = 0

        prev.Series.Item(0).LegendText = "PSI"
        prev.Series.Item(1).LegendText = "Chamber Pressure"
        prev.Series.Item(2).LegendText = "Valve Pressure"

    End Sub

    Sub setRate(ByVal rate As Integer)
        rateTau = rate
    End Sub

    Sub setTime(ByVal time As Integer)
        timeFull = time
    End Sub

    Sub setFinal(ByVal final As Integer)
        finalPSI = final
    End Sub

    Sub setpressurePlot(ByVal type As Integer)
        pressurePlot = type
    End Sub

    Function getRate() As Integer
        Return rateTau
    End Function

    Function getTime() As Integer
        Return timeFull
    End Function

    Function getFinal() As Integer
        Return finalPSI
    End Function

    Private Sub daqFindButton_Click(sender As Object, e As EventArgs) Handles daqFindButton.Click
        MccDaq.DaqDeviceManager.IgnoreInstaCal()
        boardExists = False

        daqDevice = MccDaq.DaqDeviceManager.GetDaqDeviceInventory(MccDaq.DaqDeviceInterface.Usb)
        If daqDevice.Length > 0 Then

            DaqBoard = MccDaq.DaqDeviceManager.CreateDaqDevice(0, daqDevice(0))

            If DaqBoard.BoardName.Contains("1208FS") Then
                DaqBoard.FlashLED()
                DaqBoard.AInputMode(AInRange)
                MsgBox("USB 1208FS Plus Initialized")
                MyBase.Text = "USB 1208FS Plus"
                boardExists = True
            End If
        Else
            MsgBox("Please connect 1208FS Plus.", MsgBoxStyle.Critical, "Error")
        End If

    End Sub

    Private Sub Sample_Click(sender As Object, e As EventArgs) Handles Sample.Click
        If Not boardExists Then
            MsgBox("Please connect 1208FS Plus.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If sender.Text = "Start" Then

            sender.Text = "Stop"
            analogTmr.Enabled = True

        Else
            sender.Text = "Start"
            analogTmr.Enabled = False
        End If

    End Sub

    Private Sub analogTmr_Tick(sender As Object, e As EventArgs) Handles analogTmr.Tick
        Dim vInChamber, vInValve As Double
        Dim timeDisplay As String = secCount \ 480 & secCount \ 8

        DaqBoard.VIn32(0, AInRange, vInChamber, MccDaq.VInOptions.Default)
        DaqBoard.VIn32(1, AInRange, vInValve, MccDaq.VInOptions.Default)
        prev.Series.Item(1).Points.AddXY(secCount / 8.0, vInChamber * 300)
        prev.Series.Item(2).Points.AddXY(secCount / 8.0, vInValve * 300)

        If pressurePlot = 0 Then
            DaqBoard.VOut(0, MccDaq.Range.Uni5Volts, analogOutRate(), MccDaq.VOutOptions.Default)
        ElseIf pressurePlot = 1 Then
            DaqBoard.VOut(0, MccDaq.Range.Uni5Volts, analogOutExp(), MccDaq.VOutOptions.Default)
        End If

        If secCount Mod 480 = 0 Then
            updateAxis(secCount \ 8)
        End If

        secCount += 1

    End Sub

    Private Function analogOutRate() As Double
        Dim aOut As Double

        aOut = (rateTau / 60.0) * (secCount / 8.0)

        If aOut > finalPSI Then

            aOut = finalPSI

        End If

        Return aOut / 600.0
    End Function

    Private Function analogOutExp() As Double
        Dim aOut As Double
        aOut = finalPSI - finalPSI * System.Math.Exp(secCount / (8.0 * CDbl(rateTau)))

        Return aOut / 600.0
    End Function

    Private Sub updateAxis(ByVal maxInt As Integer)
        prev.ChartAreas.Item(0).AxisX.Minimum = maxInt
        prev.ChartAreas.Item(0).AxisX.Maximum = maxInt + 60
    End Sub

    Private Sub config_Click(sender As Object, e As EventArgs) Handles config.Click
        configure.Show()
        configure.BringToFront()
    End Sub

    Private Sub pressPrev_CheckedChanged(sender As Object, e As EventArgs) Handles pressPrev.CheckedChanged
        If pressPrev.Checked = True Then
            prev.Series.Item(0).Points.Clear()

            If pressurePlot = 0 Then
                constRate(rateTau, timeFull, finalPSI, prev.Series.Item(0))
            Else
                exp(rateTau, timeFull, finalPSI, prev.Series.Item(0))
            End If

            changeAxis(timeFull, prev.ChartAreas.Item(0))

            prev.Series.Item(0).Enabled = True
        Else
            prev.Series.Item(0).Enabled = False
        End If
    End Sub

    Private Sub chamber_CheckedChanged(sender As Object, e As EventArgs) Handles chamber.CheckedChanged
        If chamber.Checked = True Then
            prev.Series.Item(1).Enabled = True
        Else
            prev.Series.Item(1).Enabled = False
        End If
    End Sub

    Private Sub valve_CheckedChanged(sender As Object, e As EventArgs) Handles valve.CheckedChanged
        If valve.Checked = True Then
            prev.Series.Item(2).Enabled = True
        Else
            prev.Series.Item(2).Enabled = False
        End If
    End Sub

End Class
