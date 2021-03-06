﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.daqFindButton = New System.Windows.Forms.Button()
        Me.analogTmr = New System.Windows.Forms.Timer(Me.components)
        Me.prev = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pressPrev = New System.Windows.Forms.CheckBox()
        Me.chamber = New System.Windows.Forms.CheckBox()
        Me.valve = New System.Windows.Forms.CheckBox()
        Me.outputEnable = New System.Windows.Forms.CheckBox()
        Me.graphChange = New System.Windows.Forms.Button()
        Me.recordLED = New BERGtools.LED()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Sample = New System.Windows.Forms.Button()
        Me.config = New System.Windows.Forms.Button()
        Me.setPSI = New System.Windows.Forms.Button()
        Me.upDownPSI = New System.Windows.Forms.NumericUpDown()
        Me.valveOpen = New System.Windows.Forms.Button()
        Me.valveLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.instChamber = New System.Windows.Forms.Label()
        Me.instValve = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.instTimer = New System.Windows.Forms.Timer(Me.components)
        Me.timeLabel = New System.Windows.Forms.Label()
        CType(Me.prev, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.upDownPSI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'daqFindButton
        '
        Me.daqFindButton.Location = New System.Drawing.Point(47, 15)
        Me.daqFindButton.Name = "daqFindButton"
        Me.daqFindButton.Size = New System.Drawing.Size(75, 23)
        Me.daqFindButton.TabIndex = 0
        Me.daqFindButton.Text = "Find DAQ"
        Me.daqFindButton.UseVisualStyleBackColor = True
        '
        'analogTmr
        '
        Me.analogTmr.Interval = 125
        '
        'prev
        '
        Me.prev.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea2.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        ChartArea2.CursorX.IsUserEnabled = True
        ChartArea2.CursorX.IsUserSelectionEnabled = True
        ChartArea2.Name = "ChartArea1"
        Me.prev.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.prev.Legends.Add(Legend2)
        Me.prev.Location = New System.Drawing.Point(178, 12)
        Me.prev.Name = "prev"
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series4.Enabled = False
        Series4.Legend = "Legend1"
        Series4.Name = "Series1"
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series5.Enabled = False
        Series5.Legend = "Legend1"
        Series5.Name = "Series2"
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series6.Enabled = False
        Series6.Legend = "Legend1"
        Series6.Name = "Series3"
        Me.prev.Series.Add(Series4)
        Me.prev.Series.Add(Series5)
        Me.prev.Series.Add(Series6)
        Me.prev.Size = New System.Drawing.Size(691, 498)
        Me.prev.TabIndex = 3
        Me.prev.Text = "Chart1"
        '
        'pressPrev
        '
        Me.pressPrev.AutoSize = True
        Me.pressPrev.Location = New System.Drawing.Point(27, 48)
        Me.pressPrev.Name = "pressPrev"
        Me.pressPrev.Size = New System.Drawing.Size(108, 17)
        Me.pressPrev.TabIndex = 5
        Me.pressPrev.Text = "Pressure Preview"
        Me.pressPrev.UseVisualStyleBackColor = True
        '
        'chamber
        '
        Me.chamber.AutoSize = True
        Me.chamber.Location = New System.Drawing.Point(27, 71)
        Me.chamber.Name = "chamber"
        Me.chamber.Size = New System.Drawing.Size(112, 17)
        Me.chamber.TabIndex = 6
        Me.chamber.Text = "Chamber Pressure"
        Me.chamber.UseVisualStyleBackColor = True
        '
        'valve
        '
        Me.valve.AutoSize = True
        Me.valve.Location = New System.Drawing.Point(27, 94)
        Me.valve.Name = "valve"
        Me.valve.Size = New System.Drawing.Size(97, 17)
        Me.valve.TabIndex = 7
        Me.valve.Text = "Valve Pressure"
        Me.valve.UseVisualStyleBackColor = True
        '
        'outputEnable
        '
        Me.outputEnable.AutoSize = True
        Me.outputEnable.Location = New System.Drawing.Point(30, 77)
        Me.outputEnable.Name = "outputEnable"
        Me.outputEnable.Size = New System.Drawing.Size(94, 17)
        Me.outputEnable.TabIndex = 12
        Me.outputEnable.Text = "Enable Output"
        Me.outputEnable.UseVisualStyleBackColor = True
        '
        'graphChange
        '
        Me.graphChange.Location = New System.Drawing.Point(34, 19)
        Me.graphChange.Name = "graphChange"
        Me.graphChange.Size = New System.Drawing.Size(90, 23)
        Me.graphChange.TabIndex = 13
        Me.graphChange.Text = "View Full Graph"
        Me.graphChange.UseVisualStyleBackColor = True
        '
        'recordLED
        '
        Me.recordLED.FontColor = System.Drawing.Color.Black
        Me.recordLED.Location = New System.Drawing.Point(12, 12)
        Me.recordLED.Name = "recordLED"
        Me.recordLED.OffColor = System.Drawing.Color.Black
        Me.recordLED.OffText = ""
        Me.recordLED.OnColor = System.Drawing.Color.Red
        Me.recordLED.OnText = ""
        Me.recordLED.ShowText = True
        Me.recordLED.Size = New System.Drawing.Size(29, 26)
        Me.recordLED.TabIndex = 14
        Me.recordLED.Value = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.graphChange)
        Me.GroupBox2.Controls.Add(Me.valve)
        Me.GroupBox2.Controls.Add(Me.chamber)
        Me.GroupBox2.Controls.Add(Me.pressPrev)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 251)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(158, 125)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Graph Control"
        '
        'Sample
        '
        Me.Sample.Location = New System.Drawing.Point(38, 19)
        Me.Sample.Name = "Sample"
        Me.Sample.Size = New System.Drawing.Size(75, 23)
        Me.Sample.TabIndex = 1
        Me.Sample.Text = "Record"
        Me.Sample.UseVisualStyleBackColor = True
        '
        'config
        '
        Me.config.Location = New System.Drawing.Point(38, 48)
        Me.config.Name = "config"
        Me.config.Size = New System.Drawing.Size(75, 23)
        Me.config.TabIndex = 4
        Me.config.Text = "Configure Test"
        Me.config.UseVisualStyleBackColor = True
        '
        'setPSI
        '
        Me.setPSI.Location = New System.Drawing.Point(31, 45)
        Me.setPSI.Name = "setPSI"
        Me.setPSI.Size = New System.Drawing.Size(97, 20)
        Me.setPSI.TabIndex = 9
        Me.setPSI.Text = "Set Pressure (PSI)"
        Me.setPSI.UseVisualStyleBackColor = True
        '
        'upDownPSI
        '
        Me.upDownPSI.Location = New System.Drawing.Point(19, 19)
        Me.upDownPSI.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        Me.upDownPSI.Name = "upDownPSI"
        Me.upDownPSI.Size = New System.Drawing.Size(120, 20)
        Me.upDownPSI.TabIndex = 11
        '
        'valveOpen
        '
        Me.valveOpen.Location = New System.Drawing.Point(38, 19)
        Me.valveOpen.Name = "valveOpen"
        Me.valveOpen.Size = New System.Drawing.Size(79, 23)
        Me.valveOpen.TabIndex = 15
        Me.valveOpen.Text = "Open Valve"
        Me.valveOpen.UseVisualStyleBackColor = True
        '
        'valveLabel
        '
        Me.valveLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.valveLabel.AutoSize = True
        Me.valveLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valveLabel.Location = New System.Drawing.Point(683, 555)
        Me.valveLabel.Name = "valveLabel"
        Me.valveLabel.Size = New System.Drawing.Size(186, 31)
        Me.valveLabel.TabIndex = 16
        Me.valveLabel.Text = "Valve Closed"
        Me.valveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.upDownPSI)
        Me.GroupBox1.Controls.Add(Me.setPSI)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 172)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(158, 73)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Manual Control"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Sample)
        Me.GroupBox3.Controls.Add(Me.outputEnable)
        Me.GroupBox3.Controls.Add(Me.config)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 68)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(158, 98)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Test Control"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.valveOpen)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 382)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(158, 51)
        Me.GroupBox4.TabIndex = 21
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Valve Control"
        '
        'instChamber
        '
        Me.instChamber.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.instChamber.AutoSize = True
        Me.instChamber.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.instChamber.Location = New System.Drawing.Point(178, 527)
        Me.instChamber.Name = "instChamber"
        Me.instChamber.Size = New System.Drawing.Size(0, 31)
        Me.instChamber.TabIndex = 22
        '
        'instValve
        '
        Me.instValve.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.instValve.AutoSize = True
        Me.instValve.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.instValve.Location = New System.Drawing.Point(316, 527)
        Me.instValve.Name = "instValve"
        Me.instValve.Size = New System.Drawing.Size(0, 31)
        Me.instValve.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(181, 570)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Chamber Pressure"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(319, 570)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Valve Pressure"
        '
        'instTimer
        '
        Me.instTimer.Interval = 1000
        '
        'timeLabel
        '
        Me.timeLabel.AutoSize = True
        Me.timeLabel.Location = New System.Drawing.Point(178, 13)
        Me.timeLabel.Name = "timeLabel"
        Me.timeLabel.Size = New System.Drawing.Size(0, 13)
        Me.timeLabel.TabIndex = 26
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 597)
        Me.Controls.Add(Me.timeLabel)
        Me.Controls.Add(Me.valveLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.instValve)
        Me.Controls.Add(Me.instChamber)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.recordLED)
        Me.Controls.Add(Me.prev)
        Me.Controls.Add(Me.daqFindButton)
        Me.Name = "Form1"
        Me.Text = "Disabled"
        CType(Me.prev, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.upDownPSI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents daqFindButton As Button
    Friend WithEvents analogTmr As Timer
    Friend WithEvents prev As DataVisualization.Charting.Chart
    Friend WithEvents pressPrev As CheckBox
    Friend WithEvents chamber As CheckBox
    Friend WithEvents valve As CheckBox
    Friend WithEvents outputEnable As CheckBox
    Friend WithEvents graphChange As Button
    Friend WithEvents recordLED As BERGtools.LED
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Sample As Button
    Friend WithEvents config As Button
    Friend WithEvents setPSI As Button
    Friend WithEvents upDownPSI As NumericUpDown
    Friend WithEvents valveOpen As Button
    Friend WithEvents valveLabel As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents instChamber As Label
    Friend WithEvents instValve As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents instTimer As Timer
    Friend WithEvents timeLabel As Label
End Class
