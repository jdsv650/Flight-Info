<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FlightInfoResultsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.FlightChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.AmericanCheckBox = New System.Windows.Forms.CheckBox()
        Me.DeltaCheckBox = New System.Windows.Forms.CheckBox()
        Me.UnitedCheckBox = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MaxLabel = New System.Windows.Forms.Label()
        Me.MinLabel = New System.Windows.Forms.Label()
        Me.TicketPriceLabel = New System.Windows.Forms.Label()
        Me.TickMarkLabel = New System.Windows.Forms.Label()
        Me.MaxTrackBar = New System.Windows.Forms.TrackBar()
        Me.MinTrackBar = New System.Windows.Forms.TrackBar()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.FlightChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.MaxTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlightChart
        '
        ChartArea4.AxisY.Title = "Flight Info"
        ChartArea4.Name = "ChartArea1"
        Me.FlightChart.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.FlightChart.Legends.Add(Legend4)
        Me.FlightChart.Location = New System.Drawing.Point(12, 12)
        Me.FlightChart.Name = "FlightChart"
        Me.FlightChart.Size = New System.Drawing.Size(869, 406)
        Me.FlightChart.TabIndex = 0
        Me.FlightChart.Text = "Chart1"
        '
        'AmericanCheckBox
        '
        Me.AmericanCheckBox.AutoSize = True
        Me.AmericanCheckBox.Checked = True
        Me.AmericanCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AmericanCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmericanCheckBox.Location = New System.Drawing.Point(72, 451)
        Me.AmericanCheckBox.Name = "AmericanCheckBox"
        Me.AmericanCheckBox.Size = New System.Drawing.Size(95, 24)
        Me.AmericanCheckBox.TabIndex = 1
        Me.AmericanCheckBox.Text = "American"
        Me.AmericanCheckBox.UseVisualStyleBackColor = True
        '
        'DeltaCheckBox
        '
        Me.DeltaCheckBox.AutoSize = True
        Me.DeltaCheckBox.Checked = True
        Me.DeltaCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.DeltaCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeltaCheckBox.Location = New System.Drawing.Point(72, 481)
        Me.DeltaCheckBox.Name = "DeltaCheckBox"
        Me.DeltaCheckBox.Size = New System.Drawing.Size(66, 24)
        Me.DeltaCheckBox.TabIndex = 2
        Me.DeltaCheckBox.Text = "Delta"
        Me.DeltaCheckBox.UseVisualStyleBackColor = True
        '
        'UnitedCheckBox
        '
        Me.UnitedCheckBox.AutoSize = True
        Me.UnitedCheckBox.Checked = True
        Me.UnitedCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.UnitedCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnitedCheckBox.Location = New System.Drawing.Point(72, 511)
        Me.UnitedCheckBox.Name = "UnitedCheckBox"
        Me.UnitedCheckBox.Size = New System.Drawing.Size(75, 24)
        Me.UnitedCheckBox.TabIndex = 3
        Me.UnitedCheckBox.Text = "United"
        Me.UnitedCheckBox.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.MaxLabel)
        Me.Panel1.Controls.Add(Me.MinLabel)
        Me.Panel1.Controls.Add(Me.TicketPriceLabel)
        Me.Panel1.Controls.Add(Me.TickMarkLabel)
        Me.Panel1.Controls.Add(Me.MaxTrackBar)
        Me.Panel1.Controls.Add(Me.MinTrackBar)
        Me.Panel1.Location = New System.Drawing.Point(216, 442)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(483, 111)
        Me.Panel1.TabIndex = 28
        '
        'MaxLabel
        '
        Me.MaxLabel.AutoSize = True
        Me.MaxLabel.Location = New System.Drawing.Point(4, 34)
        Me.MaxLabel.Name = "MaxLabel"
        Me.MaxLabel.Size = New System.Drawing.Size(51, 13)
        Me.MaxLabel.TabIndex = 54
        Me.MaxLabel.Text = "Maximum"
        '
        'MinLabel
        '
        Me.MinLabel.AutoSize = True
        Me.MinLabel.Location = New System.Drawing.Point(4, 4)
        Me.MinLabel.Name = "MinLabel"
        Me.MinLabel.Size = New System.Drawing.Size(48, 13)
        Me.MinLabel.TabIndex = 53
        Me.MinLabel.Text = "Minimum"
        '
        'TicketPriceLabel
        '
        Me.TicketPriceLabel.AutoSize = True
        Me.TicketPriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TicketPriceLabel.Location = New System.Drawing.Point(178, 77)
        Me.TicketPriceLabel.Name = "TicketPriceLabel"
        Me.TicketPriceLabel.Size = New System.Drawing.Size(119, 20)
        Me.TicketPriceLabel.TabIndex = 52
        Me.TicketPriceLabel.Text = "Ticket Price in $"
        '
        'TickMarkLabel
        '
        Me.TickMarkLabel.AutoSize = True
        Me.TickMarkLabel.Location = New System.Drawing.Point(52, 61)
        Me.TickMarkLabel.Name = "TickMarkLabel"
        Me.TickMarkLabel.Size = New System.Drawing.Size(412, 13)
        Me.TickMarkLabel.TabIndex = 51
        Me.TickMarkLabel.Text = "0         100       200       300       400       500       600       700       8" & _
    "00       900      1000"
        '
        'MaxTrackBar
        '
        Me.MaxTrackBar.LargeChange = 50
        Me.MaxTrackBar.Location = New System.Drawing.Point(45, 29)
        Me.MaxTrackBar.Maximum = 1000
        Me.MaxTrackBar.Name = "MaxTrackBar"
        Me.MaxTrackBar.Size = New System.Drawing.Size(416, 45)
        Me.MaxTrackBar.SmallChange = 50
        Me.MaxTrackBar.TabIndex = 50
        Me.MaxTrackBar.TickFrequency = 50
        Me.MaxTrackBar.Value = 1000
        '
        'MinTrackBar
        '
        Me.MinTrackBar.LargeChange = 50
        Me.MinTrackBar.Location = New System.Drawing.Point(45, 3)
        Me.MinTrackBar.Maximum = 1000
        Me.MinTrackBar.Name = "MinTrackBar"
        Me.MinTrackBar.Size = New System.Drawing.Size(416, 45)
        Me.MinTrackBar.SmallChange = 50
        Me.MinTrackBar.TabIndex = 50
        Me.MinTrackBar.TickFrequency = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(768, 520)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 33)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FlightInfoResultsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 588)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UnitedCheckBox)
        Me.Controls.Add(Me.DeltaCheckBox)
        Me.Controls.Add(Me.AmericanCheckBox)
        Me.Controls.Add(Me.FlightChart)
        Me.Name = "FlightInfoResultsForm"
        Me.Text = "Flight Information Results"
        CType(Me.FlightChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.MaxTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlightChart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents AmericanCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DeltaCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents UnitedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MaxLabel As System.Windows.Forms.Label
    Friend WithEvents MinLabel As System.Windows.Forms.Label
    Friend WithEvents TicketPriceLabel As System.Windows.Forms.Label
    Friend WithEvents TickMarkLabel As System.Windows.Forms.Label
    Friend WithEvents MaxTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents MinTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
