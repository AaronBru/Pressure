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
        Me.daqFindButton = New System.Windows.Forms.Button()
        Me.Sample = New System.Windows.Forms.Button()
        Me.analogTmr = New System.Windows.Forms.Timer(Me.components)
        Me.prev = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.config = New System.Windows.Forms.Button()
        CType(Me.prev, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'daqFindButton
        '
        Me.daqFindButton.Location = New System.Drawing.Point(37, 63)
        Me.daqFindButton.Name = "daqFindButton"
        Me.daqFindButton.Size = New System.Drawing.Size(75, 23)
        Me.daqFindButton.TabIndex = 0
        Me.daqFindButton.Text = "Find DAQ"
        Me.daqFindButton.UseVisualStyleBackColor = True
        '
        'Sample
        '
        Me.Sample.Location = New System.Drawing.Point(25, 23)
        Me.Sample.Name = "Sample"
        Me.Sample.Size = New System.Drawing.Size(96, 23)
        Me.Sample.TabIndex = 1
        Me.Sample.Text = "Start"
        Me.Sample.UseVisualStyleBackColor = True
        '
        'analogTmr
        '
        '
        'prev
        '
        ChartArea1.Name = "ChartArea1"
        Me.prev.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.prev.Legends.Add(Legend1)
        Me.prev.Location = New System.Drawing.Point(396, 23)
        Me.prev.Name = "prev"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.prev.Series.Add(Series1)
        Me.prev.Size = New System.Drawing.Size(327, 319)
        Me.prev.TabIndex = 3
        Me.prev.Text = "Chart1"
        '
        'config
        '
        Me.config.Location = New System.Drawing.Point(36, 108)
        Me.config.Name = "config"
        Me.config.Size = New System.Drawing.Size(75, 23)
        Me.config.TabIndex = 4
        Me.config.Text = "Configure Test"
        Me.config.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 451)
        Me.Controls.Add(Me.config)
        Me.Controls.Add(Me.prev)
        Me.Controls.Add(Me.Sample)
        Me.Controls.Add(Me.daqFindButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.prev, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents daqFindButton As Button
    Friend WithEvents Sample As Button
    Friend WithEvents analogTmr As Timer
    Friend WithEvents prev As DataVisualization.Charting.Chart
    Friend WithEvents config As Button
End Class
