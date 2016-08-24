<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.daqFindButton = New System.Windows.Forms.Button()
        Me.Sample = New System.Windows.Forms.Button()
        Me.analogTmr = New System.Windows.Forms.Timer(Me.components)
        Me.prev = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.config = New System.Windows.Forms.Button()
        Me.pressPrev = New System.Windows.Forms.CheckBox()
        Me.chamber = New System.Windows.Forms.CheckBox()
        Me.valve = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.setPSI = New System.Windows.Forms.Button()
        Me.upDownPSI = New System.Windows.Forms.NumericUpDown()
        Me.outputEnable = New System.Windows.Forms.CheckBox()
        Me.graphChange = New System.Windows.Forms.Button()
        Me.recordLED = New BERGtools.LED()
        Me.valveOpen = New System.Windows.Forms.Button()
        Me.valveLabel = New System.Windows.Forms.Label()
        CType(Me.prev, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.upDownPSI, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Sample
        '
        Me.Sample.Location = New System.Drawing.Point(47, 112)
        Me.Sample.Name = "Sample"
        Me.Sample.Size = New System.Drawing.Size(75, 23)
        Me.Sample.TabIndex = 1
        Me.Sample.Text = "Record"
        Me.Sample.UseVisualStyleBackColor = True
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
        ChartArea1.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        ChartArea1.CursorX.IsUserEnabled = True
        ChartArea1.CursorX.IsUserSelectionEnabled = True
        ChartArea1.Name = "ChartArea1"
        Me.prev.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.prev.Legends.Add(Legend1)
        Me.prev.Location = New System.Drawing.Point(190, 12)
        Me.prev.Name = "prev"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Enabled = False
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Enabled = False
        Series2.Legend = "Legend1"
        Series2.Name = "Series2"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series3.Enabled = False
        Series3.Legend = "Legend1"
        Series3.Name = "Series3"
        Me.prev.Series.Add(Series1)
        Me.prev.Series.Add(Series2)
        Me.prev.Series.Add(Series3)
        Me.prev.Size = New System.Drawing.Size(679, 485)
        Me.prev.TabIndex = 3
        Me.prev.Text = "Chart1"
        '
        'config
        '
        Me.config.Location = New System.Drawing.Point(47, 141)
        Me.config.Name = "config"
        Me.config.Size = New System.Drawing.Size(75, 23)
        Me.config.TabIndex = 4
        Me.config.Text = "Configure Test"
        Me.config.UseVisualStyleBackColor = True
        '
        'pressPrev
        '
        Me.pressPrev.AutoSize = True
        Me.pressPrev.Location = New System.Drawing.Point(25, 373)
        Me.pressPrev.Name = "pressPrev"
        Me.pressPrev.Size = New System.Drawing.Size(108, 17)
        Me.pressPrev.TabIndex = 5
        Me.pressPrev.Text = "Pressure Preview"
        Me.pressPrev.UseVisualStyleBackColor = True
        '
        'chamber
        '
        Me.chamber.AutoSize = True
        Me.chamber.Location = New System.Drawing.Point(25, 396)
        Me.chamber.Name = "chamber"
        Me.chamber.Size = New System.Drawing.Size(112, 17)
        Me.chamber.TabIndex = 6
        Me.chamber.Text = "Chamber Pressure"
        Me.chamber.UseVisualStyleBackColor = True
        '
        'valve
        '
        Me.valve.AutoSize = True
        Me.valve.Location = New System.Drawing.Point(25, 419)
        Me.valve.Name = "valve"
        Me.valve.Size = New System.Drawing.Size(97, 17)
        Me.valve.TabIndex = 7
        Me.valve.Text = "Valve Pressure"
        Me.valve.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(190, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(44, 20)
        Me.TextBox1.TabIndex = 8
        '
        'setPSI
        '
        Me.setPSI.Location = New System.Drawing.Point(47, 479)
        Me.setPSI.Name = "setPSI"
        Me.setPSI.Size = New System.Drawing.Size(75, 20)
        Me.setPSI.TabIndex = 9
        Me.setPSI.Text = "Set PSI"
        Me.setPSI.UseVisualStyleBackColor = True
        '
        'upDownPSI
        '
        Me.upDownPSI.Location = New System.Drawing.Point(25, 453)
        Me.upDownPSI.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        Me.upDownPSI.Name = "upDownPSI"
        Me.upDownPSI.Size = New System.Drawing.Size(120, 20)
        Me.upDownPSI.TabIndex = 11
        '
        'outputEnable
        '
        Me.outputEnable.AutoSize = True
        Me.outputEnable.Location = New System.Drawing.Point(25, 350)
        Me.outputEnable.Name = "outputEnable"
        Me.outputEnable.Size = New System.Drawing.Size(94, 17)
        Me.outputEnable.TabIndex = 12
        Me.outputEnable.Text = "Enable Output"
        Me.outputEnable.UseVisualStyleBackColor = True
        '
        'graphChange
        '
        Me.graphChange.Location = New System.Drawing.Point(43, 170)
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
        'valveOpen
        '
        Me.valveOpen.Location = New System.Drawing.Point(43, 258)
        Me.valveOpen.Name = "valveOpen"
        Me.valveOpen.Size = New System.Drawing.Size(79, 23)
        Me.valveOpen.TabIndex = 15
        Me.valveOpen.Text = "Open Valve"
        Me.valveOpen.UseVisualStyleBackColor = True
        '
        'valveLabel
        '
        Me.valveLabel.AutoSize = True
        Me.valveLabel.Location = New System.Drawing.Point(50, 284)
        Me.valveLabel.Name = "valveLabel"
        Me.valveLabel.Size = New System.Drawing.Size(69, 13)
        Me.valveLabel.TabIndex = 16
        Me.valveLabel.Text = "Valve Closed"
        Me.valveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 509)
        Me.Controls.Add(Me.valveLabel)
        Me.Controls.Add(Me.valveOpen)
        Me.Controls.Add(Me.recordLED)
        Me.Controls.Add(Me.graphChange)
        Me.Controls.Add(Me.outputEnable)
        Me.Controls.Add(Me.upDownPSI)
        Me.Controls.Add(Me.setPSI)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.valve)
        Me.Controls.Add(Me.chamber)
        Me.Controls.Add(Me.pressPrev)
        Me.Controls.Add(Me.config)
        Me.Controls.Add(Me.prev)
        Me.Controls.Add(Me.Sample)
        Me.Controls.Add(Me.daqFindButton)
        Me.Name = "Form1"
        Me.Text = "Disabled"
        CType(Me.prev, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.upDownPSI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents daqFindButton As Button
    Friend WithEvents Sample As Button
    Friend WithEvents analogTmr As Timer
    Friend WithEvents prev As DataVisualization.Charting.Chart
    Friend WithEvents config As Button
    Friend WithEvents pressPrev As CheckBox
    Friend WithEvents chamber As CheckBox
    Friend WithEvents valve As CheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents setPSI As Button
    Friend WithEvents upDownPSI As NumericUpDown
    Friend WithEvents outputEnable As CheckBox
    Friend WithEvents graphChange As Button
    Friend WithEvents recordLED As BERGtools.LED
    Friend WithEvents valveOpen As Button
    Friend WithEvents valveLabel As Label
End Class
