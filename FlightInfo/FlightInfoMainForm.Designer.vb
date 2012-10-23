<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FlightInfoMainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FlightInfoMainForm))
        Me.DepartComboBox = New System.Windows.Forms.ComboBox()
        Me.DepartLabel = New System.Windows.Forms.Label()
        Me.ArriveComboBox = New System.Windows.Forms.ComboBox()
        Me.ArriveLabel = New System.Windows.Forms.Label()
        Me.DepartTimeLabel = New System.Windows.Forms.Label()
        Me.EarlyDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AndLabel = New System.Windows.Forms.Label()
        Me.LateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DepartComboBox
        '
        Me.DepartComboBox.FormattingEnabled = True
        Me.DepartComboBox.Location = New System.Drawing.Point(103, 86)
        Me.DepartComboBox.Name = "DepartComboBox"
        Me.DepartComboBox.Size = New System.Drawing.Size(144, 21)
        Me.DepartComboBox.TabIndex = 0
        '
        'DepartLabel
        '
        Me.DepartLabel.AutoSize = True
        Me.DepartLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepartLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.DepartLabel.Location = New System.Drawing.Point(103, 59)
        Me.DepartLabel.Name = "DepartLabel"
        Me.DepartLabel.Size = New System.Drawing.Size(120, 24)
        Me.DepartLabel.TabIndex = 1
        Me.DepartLabel.Text = "Depart From:"
        Me.DepartLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ArriveComboBox
        '
        Me.ArriveComboBox.FormattingEnabled = True
        Me.ArriveComboBox.Location = New System.Drawing.Point(529, 86)
        Me.ArriveComboBox.Name = "ArriveComboBox"
        Me.ArriveComboBox.Size = New System.Drawing.Size(147, 21)
        Me.ArriveComboBox.TabIndex = 2
        '
        'ArriveLabel
        '
        Me.ArriveLabel.AutoSize = True
        Me.ArriveLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArriveLabel.Location = New System.Drawing.Point(525, 59)
        Me.ArriveLabel.Name = "ArriveLabel"
        Me.ArriveLabel.Size = New System.Drawing.Size(86, 24)
        Me.ArriveLabel.TabIndex = 3
        Me.ArriveLabel.Text = "Arrive At:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'DepartTimeLabel
        '
        Me.DepartTimeLabel.AutoSize = True
        Me.DepartTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepartTimeLabel.Location = New System.Drawing.Point(302, 59)
        Me.DepartTimeLabel.Name = "DepartTimeLabel"
        Me.DepartTimeLabel.Size = New System.Drawing.Size(149, 24)
        Me.DepartTimeLabel.TabIndex = 4
        Me.DepartTimeLabel.Text = "Depart Between:"
        '
        'EarlyDateTimePicker
        '
        Me.EarlyDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EarlyDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.EarlyDateTimePicker.Location = New System.Drawing.Point(315, 85)
        Me.EarlyDateTimePicker.Name = "EarlyDateTimePicker"
        Me.EarlyDateTimePicker.ShowUpDown = True
        Me.EarlyDateTimePicker.Size = New System.Drawing.Size(108, 29)
        Me.EarlyDateTimePicker.TabIndex = 5
        Me.EarlyDateTimePicker.Value = New Date(2012, 10, 8, 12, 30, 0, 0)
        '
        'AndLabel
        '
        Me.AndLabel.AutoSize = True
        Me.AndLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AndLabel.Location = New System.Drawing.Point(366, 132)
        Me.AndLabel.Name = "AndLabel"
        Me.AndLabel.Size = New System.Drawing.Size(50, 24)
        Me.AndLabel.TabIndex = 6
        Me.AndLabel.Text = "And:"
        '
        'LateDateTimePicker
        '
        Me.LateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.LateDateTimePicker.Location = New System.Drawing.Point(315, 172)
        Me.LateDateTimePicker.Name = "LateDateTimePicker"
        Me.LateDateTimePicker.ShowUpDown = True
        Me.LateDateTimePicker.Size = New System.Drawing.Size(108, 29)
        Me.LateDateTimePicker.TabIndex = 7
        Me.LateDateTimePicker.Value = New Date(2012, 10, 8, 12, 30, 0, 0)
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.FlightInfo.My.Resources.Resources.clock1
        Me.PictureBox3.Location = New System.Drawing.Point(315, 120)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(45, 46)
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.FlightInfo.My.Resources.Resources.airplane_landing
        Me.PictureBox2.Location = New System.Drawing.Point(484, 72)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(62, 72)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(315, 257)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 36)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FlightInfoMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 363)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LateDateTimePicker)
        Me.Controls.Add(Me.AndLabel)
        Me.Controls.Add(Me.EarlyDateTimePicker)
        Me.Controls.Add(Me.DepartTimeLabel)
        Me.Controls.Add(Me.ArriveLabel)
        Me.Controls.Add(Me.ArriveComboBox)
        Me.Controls.Add(Me.DepartLabel)
        Me.Controls.Add(Me.DepartComboBox)
        Me.Name = "FlightInfoMainForm"
        Me.Text = "Flight Information"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DepartComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DepartLabel As System.Windows.Forms.Label
    Friend WithEvents ArriveComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ArriveLabel As System.Windows.Forms.Label
    Friend WithEvents DepartTimeLabel As System.Windows.Forms.Label
    Friend WithEvents EarlyDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents AndLabel As System.Windows.Forms.Label
    Friend WithEvents LateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
