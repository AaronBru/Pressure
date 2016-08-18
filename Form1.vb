Public Class Form1

    Dim daqDevice As MccDaq.DaqDeviceDescriptor()
    Dim boardExists As Boolean
    Dim AInRange As MccDaq.Range = MccDaq.Range.Bip10Volts
    Dim AInMode As MccDaq.AInputMode = MccDaq.AInputMode.SingleEnded
    Dim preview As New DataVisualization.Charting.Series
    Dim count As Integer = 0

    Public DaqBoard As New MccDaq.MccBoard()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        preview.ChartType = DataVisualization.Charting.SeriesChartType.Line

    End Sub

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
        Dim voltsIn As Double

        DaqBoard.VIn32(0, AInRange, voltsIn, MccDaq.VInOptions.Default)
        preview.Points.AddXY(count, count)
        prev.Series.Clear()
        prev.Series.Add(preview)
        count += 1

    End Sub

    Private Sub config_Click(sender As Object, e As EventArgs) Handles config.Click
        objConfig.Visible = True
        objForm1.Visible = False
    End Sub
End Class
