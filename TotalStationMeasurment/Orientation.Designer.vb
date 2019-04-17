<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Orientation
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BackNotice = New System.Windows.Forms.Label()
        Me.btnSSaveBack = New System.Windows.Forms.Button()
        Me.btnSMeasBack = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSMeasDistance = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSMeasVt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSMeasHz = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSBackMeasZ = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSBackMeasY = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSBackMeasX = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSBackdeltaZ = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSBackdeltaY = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSBackdeltaX = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtSDesignDistance = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtSGapDistance = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BackNotice
        '
        Me.BackNotice.AutoSize = True
        Me.BackNotice.Location = New System.Drawing.Point(274, 261)
        Me.BackNotice.Name = "BackNotice"
        Me.BackNotice.Size = New System.Drawing.Size(0, 15)
        Me.BackNotice.TabIndex = 76
        '
        'btnSSaveBack
        '
        Me.btnSSaveBack.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSSaveBack.Location = New System.Drawing.Point(310, 398)
        Me.btnSSaveBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSSaveBack.Name = "btnSSaveBack"
        Me.btnSSaveBack.Size = New System.Drawing.Size(115, 48)
        Me.btnSSaveBack.TabIndex = 75
        Me.btnSSaveBack.Text = "保存"
        Me.btnSSaveBack.UseVisualStyleBackColor = True
        '
        'btnSMeasBack
        '
        Me.btnSMeasBack.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSMeasBack.Location = New System.Drawing.Point(144, 398)
        Me.btnSMeasBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSMeasBack.Name = "btnSMeasBack"
        Me.btnSMeasBack.Size = New System.Drawing.Size(121, 48)
        Me.btnSMeasBack.TabIndex = 74
        Me.btnSMeasBack.Text = "测量"
        Me.btnSMeasBack.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(634, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 15)
        Me.Label9.TabIndex = 73
        Me.Label9.Text = "斜距[m]"
        '
        'txtSMeasDistance
        '
        Me.txtSMeasDistance.Location = New System.Drawing.Point(657, 129)
        Me.txtSMeasDistance.Name = "txtSMeasDistance"
        Me.txtSMeasDistance.Size = New System.Drawing.Size(100, 25)
        Me.txtSMeasDistance.TabIndex = 70
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(619, 132)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 15)
        Me.Label11.TabIndex = 69
        Me.Label11.Text = "测量"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(432, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 15)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "角度[°]"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(87, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 15)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "坐标[m]"
        '
        'txtSMeasVt
        '
        Me.txtSMeasVt.Location = New System.Drawing.Point(462, 191)
        Me.txtSMeasVt.Name = "txtSMeasVt"
        Me.txtSMeasVt.Size = New System.Drawing.Size(100, 25)
        Me.txtSMeasVt.TabIndex = 64
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(428, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 15)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Vt"
        '
        'txtSMeasHz
        '
        Me.txtSMeasHz.Location = New System.Drawing.Point(462, 126)
        Me.txtSMeasHz.Name = "txtSMeasHz"
        Me.txtSMeasHz.Size = New System.Drawing.Size(100, 25)
        Me.txtSMeasHz.TabIndex = 62
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(428, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 15)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Hz"
        '
        'txtSBackMeasZ
        '
        Me.txtSBackMeasZ.Location = New System.Drawing.Point(109, 258)
        Me.txtSBackMeasZ.Name = "txtSBackMeasZ"
        Me.txtSBackMeasZ.Size = New System.Drawing.Size(100, 25)
        Me.txtSBackMeasZ.TabIndex = 60
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(75, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 15)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "H"
        '
        'txtSBackMeasY
        '
        Me.txtSBackMeasY.Location = New System.Drawing.Point(109, 191)
        Me.txtSBackMeasY.Name = "txtSBackMeasY"
        Me.txtSBackMeasY.Size = New System.Drawing.Size(100, 25)
        Me.txtSBackMeasY.TabIndex = 58
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 15)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "E"
        '
        'txtSBackMeasX
        '
        Me.txtSBackMeasX.Location = New System.Drawing.Point(109, 126)
        Me.txtSBackMeasX.Name = "txtSBackMeasX"
        Me.txtSBackMeasX.Size = New System.Drawing.Size(100, 25)
        Me.txtSBackMeasX.TabIndex = 56
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 15)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "N"
        '
        'BackgroundWorker
        '
        '
        'Button1
        '
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(477, 398)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 48)
        Me.Button1.TabIndex = 77
        Me.Button1.Text = "停止测量"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(442, 261)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 15)
        Me.Label1.TabIndex = 85
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(255, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 15)
        Me.Label10.TabIndex = 84
        Me.Label10.Text = "坐标差[mm]"
        '
        'txtSBackdeltaZ
        '
        Me.txtSBackdeltaZ.Location = New System.Drawing.Point(277, 258)
        Me.txtSBackdeltaZ.Name = "txtSBackdeltaZ"
        Me.txtSBackdeltaZ.Size = New System.Drawing.Size(100, 25)
        Me.txtSBackdeltaZ.TabIndex = 83
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(243, 261)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 15)
        Me.Label12.TabIndex = 82
        Me.Label12.Text = "ΔH"
        '
        'txtSBackdeltaY
        '
        Me.txtSBackdeltaY.Location = New System.Drawing.Point(277, 191)
        Me.txtSBackdeltaY.Name = "txtSBackdeltaY"
        Me.txtSBackdeltaY.Size = New System.Drawing.Size(100, 25)
        Me.txtSBackdeltaY.TabIndex = 81
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(243, 194)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 15)
        Me.Label13.TabIndex = 80
        Me.Label13.Text = "ΔE"
        '
        'txtSBackdeltaX
        '
        Me.txtSBackdeltaX.Location = New System.Drawing.Point(277, 126)
        Me.txtSBackdeltaX.Name = "txtSBackdeltaX"
        Me.txtSBackdeltaX.Size = New System.Drawing.Size(100, 25)
        Me.txtSBackdeltaX.TabIndex = 79
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(243, 129)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 15)
        Me.Label14.TabIndex = 78
        Me.Label14.Text = "ΔN"
        '
        'txtSDesignDistance
        '
        Me.txtSDesignDistance.Location = New System.Drawing.Point(657, 191)
        Me.txtSDesignDistance.Name = "txtSDesignDistance"
        Me.txtSDesignDistance.Size = New System.Drawing.Size(100, 25)
        Me.txtSDesignDistance.TabIndex = 87
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(619, 194)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 15)
        Me.Label15.TabIndex = 86
        Me.Label15.Text = "理论"
        '
        'txtSGapDistance
        '
        Me.txtSGapDistance.Location = New System.Drawing.Point(657, 258)
        Me.txtSGapDistance.Name = "txtSGapDistance"
        Me.txtSGapDistance.Size = New System.Drawing.Size(100, 25)
        Me.txtSGapDistance.TabIndex = 89
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(619, 261)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(37, 15)
        Me.Label16.TabIndex = 88
        Me.Label16.Text = "差值"
        '
        'Orientation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 498)
        Me.Controls.Add(Me.txtSGapDistance)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtSDesignDistance)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtSBackdeltaZ)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtSBackdeltaY)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtSBackdeltaX)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BackNotice)
        Me.Controls.Add(Me.btnSSaveBack)
        Me.Controls.Add(Me.btnSMeasBack)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtSMeasDistance)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtSMeasVt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSMeasHz)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSBackMeasZ)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSBackMeasY)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSBackMeasX)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Orientation"
        Me.Text = "Orientation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackNotice As System.Windows.Forms.Label
    Friend WithEvents btnSSaveBack As System.Windows.Forms.Button
    Friend WithEvents btnSMeasBack As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtSMeasDistance As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSMeasVt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSMeasHz As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSBackMeasZ As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSBackMeasY As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSBackMeasX As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtSBackdeltaZ As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtSBackdeltaY As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtSBackdeltaX As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtSDesignDistance As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtSGapDistance As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
