<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Measurement
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMeasZ = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMeasY = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMeasX = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Notice1 = New System.Windows.Forms.Label()
        Me.PrismMeasurmentWorker = New System.ComponentModel.BackgroundWorker()
        Me.txtMeas2Z = New System.Windows.Forms.TextBox()
        Me.txtMeas2Y = New System.Windows.Forms.TextBox()
        Me.txtMeas2X = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtMeas3Z = New System.Windows.Forms.TextBox()
        Me.txtMeas3Y = New System.Windows.Forms.TextBox()
        Me.txtMeas3X = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtMeasNotice = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.txtErrZ = New System.Windows.Forms.TextBox()
        Me.txtErrY = New System.Windows.Forms.TextBox()
        Me.txtErrX = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMeasHz = New System.Windows.Forms.TextBox()
        Me.txtMeasVt = New System.Windows.Forms.TextBox()
        Me.txtMeas2Vt = New System.Windows.Forms.TextBox()
        Me.txtMeas2HZ = New System.Windows.Forms.TextBox()
        Me.txtMeas3Vt = New System.Windows.Forms.TextBox()
        Me.txtMeas3Hz = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(166, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 15)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "坐标[m]"
        '
        'txtMeasZ
        '
        Me.txtMeasZ.Location = New System.Drawing.Point(485, 142)
        Me.txtMeasZ.Name = "txtMeasZ"
        Me.txtMeasZ.Size = New System.Drawing.Size(100, 25)
        Me.txtMeasZ.TabIndex = 67
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(520, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 15)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "H"
        '
        'txtMeasY
        '
        Me.txtMeasY.Location = New System.Drawing.Point(325, 142)
        Me.txtMeasY.Name = "txtMeasY"
        Me.txtMeasY.Size = New System.Drawing.Size(100, 25)
        Me.txtMeasY.TabIndex = 65
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(362, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 15)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "E"
        '
        'txtMeasX
        '
        Me.txtMeasX.Location = New System.Drawing.Point(154, 142)
        Me.txtMeasX.Name = "txtMeasX"
        Me.txtMeasX.Size = New System.Drawing.Size(100, 25)
        Me.txtMeasX.TabIndex = 63
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(184, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 15)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "N"
        '
        'Notice1
        '
        Me.Notice1.AutoSize = True
        Me.Notice1.Location = New System.Drawing.Point(556, 129)
        Me.Notice1.Name = "Notice1"
        Me.Notice1.Size = New System.Drawing.Size(0, 15)
        Me.Notice1.TabIndex = 61
        '
        'txtMeas2Z
        '
        Me.txtMeas2Z.Location = New System.Drawing.Point(485, 208)
        Me.txtMeas2Z.Name = "txtMeas2Z"
        Me.txtMeas2Z.Size = New System.Drawing.Size(100, 25)
        Me.txtMeas2Z.TabIndex = 91
        '
        'txtMeas2Y
        '
        Me.txtMeas2Y.Location = New System.Drawing.Point(325, 208)
        Me.txtMeas2Y.Name = "txtMeas2Y"
        Me.txtMeas2Y.Size = New System.Drawing.Size(100, 25)
        Me.txtMeas2Y.TabIndex = 89
        '
        'txtMeas2X
        '
        Me.txtMeas2X.Location = New System.Drawing.Point(154, 208)
        Me.txtMeas2X.Name = "txtMeas2X"
        Me.txtMeas2X.Size = New System.Drawing.Size(100, 25)
        Me.txtMeas2X.TabIndex = 87
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(543, 337)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(0, 15)
        Me.Label21.TabIndex = 85
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(22, 145)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(45, 15)
        Me.Label34.TabIndex = 125
        Me.Label34.Text = "棱镜1"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(22, 218)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(45, 15)
        Me.Label35.TabIndex = 126
        Me.Label35.Text = "棱镜2"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(22, 286)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(45, 15)
        Me.Label36.TabIndex = 127
        Me.Label36.Text = "棱镜3"
        '
        'txtMeas3Z
        '
        Me.txtMeas3Z.Location = New System.Drawing.Point(485, 276)
        Me.txtMeas3Z.Name = "txtMeas3Z"
        Me.txtMeas3Z.Size = New System.Drawing.Size(100, 25)
        Me.txtMeas3Z.TabIndex = 134
        '
        'txtMeas3Y
        '
        Me.txtMeas3Y.Location = New System.Drawing.Point(326, 276)
        Me.txtMeas3Y.Name = "txtMeas3Y"
        Me.txtMeas3Y.Size = New System.Drawing.Size(100, 25)
        Me.txtMeas3Y.TabIndex = 132
        '
        'txtMeas3X
        '
        Me.txtMeas3X.Location = New System.Drawing.Point(154, 276)
        Me.txtMeas3X.Name = "txtMeas3X"
        Me.txtMeas3X.Size = New System.Drawing.Size(100, 25)
        Me.txtMeas3X.TabIndex = 130
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(763, 337)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(0, 15)
        Me.Label33.TabIndex = 128
        '
        'txtMeasNotice
        '
        Me.txtMeasNotice.AutoSize = True
        Me.txtMeasNotice.Location = New System.Drawing.Point(548, 367)
        Me.txtMeasNotice.Name = "txtMeasNotice"
        Me.txtMeasNotice.Size = New System.Drawing.Size(0, 15)
        Me.txtMeasNotice.TabIndex = 83
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(485, 462)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 25)
        Me.TextBox1.TabIndex = 168
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(325, 462)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 25)
        Me.TextBox2.TabIndex = 166
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(154, 462)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 25)
        Me.TextBox3.TabIndex = 164
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(543, 571)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 15)
        Me.Label9.TabIndex = 162
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 472)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 15)
        Me.Label10.TabIndex = 161
        Me.Label10.Text = "棱镜6"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 422)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 15)
        Me.Label11.TabIndex = 160
        Me.Label11.Text = "棱镜5"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 367)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 15)
        Me.Label12.TabIndex = 159
        Me.Label12.Text = "棱镜4"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(485, 395)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 25)
        Me.TextBox4.TabIndex = 157
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(326, 395)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 25)
        Me.TextBox5.TabIndex = 155
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(154, 395)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 25)
        Me.TextBox6.TabIndex = 153
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(323, 571)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(0, 15)
        Me.Label22.TabIndex = 151
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(548, 669)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(0, 15)
        Me.Label23.TabIndex = 150
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(485, 334)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 25)
        Me.TextBox7.TabIndex = 148
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(326, 337)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(100, 25)
        Me.TextBox8.TabIndex = 146
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(154, 337)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(100, 25)
        Me.TextBox9.TabIndex = 144
        '
        'txtErrZ
        '
        Me.txtErrZ.Location = New System.Drawing.Point(485, 561)
        Me.txtErrZ.Name = "txtErrZ"
        Me.txtErrZ.Size = New System.Drawing.Size(100, 25)
        Me.txtErrZ.TabIndex = 172
        '
        'txtErrY
        '
        Me.txtErrY.Location = New System.Drawing.Point(325, 561)
        Me.txtErrY.Name = "txtErrY"
        Me.txtErrY.Size = New System.Drawing.Size(100, 25)
        Me.txtErrY.TabIndex = 171
        '
        'txtErrX
        '
        Me.txtErrX.Location = New System.Drawing.Point(154, 561)
        Me.txtErrX.Name = "txtErrX"
        Me.txtErrX.Size = New System.Drawing.Size(100, 25)
        Me.txtErrX.TabIndex = 170
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 571)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 169
        Me.Label1.Text = "错台"
        '
        'txtMeasHz
        '
        Me.txtMeasHz.Location = New System.Drawing.Point(639, 135)
        Me.txtMeasHz.Name = "txtMeasHz"
        Me.txtMeasHz.Size = New System.Drawing.Size(100, 25)
        Me.txtMeasHz.TabIndex = 173
        '
        'txtMeasVt
        '
        Me.txtMeasVt.Location = New System.Drawing.Point(777, 135)
        Me.txtMeasVt.Name = "txtMeasVt"
        Me.txtMeasVt.Size = New System.Drawing.Size(100, 25)
        Me.txtMeasVt.TabIndex = 174
        '
        'txtMeas2Vt
        '
        Me.txtMeas2Vt.Location = New System.Drawing.Point(777, 208)
        Me.txtMeas2Vt.Name = "txtMeas2Vt"
        Me.txtMeas2Vt.Size = New System.Drawing.Size(100, 25)
        Me.txtMeas2Vt.TabIndex = 176
        '
        'txtMeas2HZ
        '
        Me.txtMeas2HZ.Location = New System.Drawing.Point(639, 208)
        Me.txtMeas2HZ.Name = "txtMeas2HZ"
        Me.txtMeas2HZ.Size = New System.Drawing.Size(100, 25)
        Me.txtMeas2HZ.TabIndex = 175
        '
        'txtMeas3Vt
        '
        Me.txtMeas3Vt.Location = New System.Drawing.Point(777, 276)
        Me.txtMeas3Vt.Name = "txtMeas3Vt"
        Me.txtMeas3Vt.Size = New System.Drawing.Size(100, 25)
        Me.txtMeas3Vt.TabIndex = 178
        '
        'txtMeas3Hz
        '
        Me.txtMeas3Hz.Location = New System.Drawing.Point(639, 276)
        Me.txtMeas3Hz.Name = "txtMeas3Hz"
        Me.txtMeas3Hz.Size = New System.Drawing.Size(100, 25)
        Me.txtMeas3Hz.TabIndex = 177
        '
        'TextBox16
        '
        Me.TextBox16.Location = New System.Drawing.Point(777, 468)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(100, 25)
        Me.TextBox16.TabIndex = 184
        '
        'TextBox17
        '
        Me.TextBox17.Location = New System.Drawing.Point(639, 468)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(100, 25)
        Me.TextBox17.TabIndex = 183
        '
        'TextBox18
        '
        Me.TextBox18.Location = New System.Drawing.Point(777, 400)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(100, 25)
        Me.TextBox18.TabIndex = 182
        '
        'TextBox19
        '
        Me.TextBox19.Location = New System.Drawing.Point(639, 400)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(100, 25)
        Me.TextBox19.TabIndex = 181
        '
        'TextBox20
        '
        Me.TextBox20.Location = New System.Drawing.Point(777, 327)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(100, 25)
        Me.TextBox20.TabIndex = 180
        '
        'TextBox21
        '
        Me.TextBox21.Location = New System.Drawing.Point(639, 327)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(100, 25)
        Me.TextBox21.TabIndex = 179
        '
        'Measurement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1101, 615)
        Me.Controls.Add(Me.TextBox16)
        Me.Controls.Add(Me.TextBox17)
        Me.Controls.Add(Me.TextBox18)
        Me.Controls.Add(Me.TextBox19)
        Me.Controls.Add(Me.TextBox20)
        Me.Controls.Add(Me.TextBox21)
        Me.Controls.Add(Me.txtMeas3Vt)
        Me.Controls.Add(Me.txtMeas3Hz)
        Me.Controls.Add(Me.txtMeas2Vt)
        Me.Controls.Add(Me.txtMeas2HZ)
        Me.Controls.Add(Me.txtMeasVt)
        Me.Controls.Add(Me.txtMeasHz)
        Me.Controls.Add(Me.txtErrZ)
        Me.Controls.Add(Me.txtErrY)
        Me.Controls.Add(Me.txtErrX)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.txtMeas3Z)
        Me.Controls.Add(Me.txtMeas3Y)
        Me.Controls.Add(Me.txtMeas3X)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.txtMeas2Z)
        Me.Controls.Add(Me.txtMeas2Y)
        Me.Controls.Add(Me.txtMeas2X)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtMeasNotice)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtMeasZ)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMeasY)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMeasX)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Notice1)
        Me.Name = "Measurement"
        Me.Text = "Measurement"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMeasZ As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMeasY As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMeasX As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Notice1 As System.Windows.Forms.Label
    Friend WithEvents PrismMeasurmentWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtMeas2Z As System.Windows.Forms.TextBox
    Friend WithEvents txtMeas2Y As System.Windows.Forms.TextBox
    Friend WithEvents txtMeas2X As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtMeas3Z As System.Windows.Forms.TextBox
    Friend WithEvents txtMeas3Y As System.Windows.Forms.TextBox
    Friend WithEvents txtMeas3X As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtMeasNotice As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents txtErrZ As System.Windows.Forms.TextBox
    Friend WithEvents txtErrY As System.Windows.Forms.TextBox
    Friend WithEvents txtErrX As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMeasHz As System.Windows.Forms.TextBox
    Friend WithEvents txtMeasVt As System.Windows.Forms.TextBox
    Friend WithEvents txtMeas2Vt As System.Windows.Forms.TextBox
    Friend WithEvents txtMeas2HZ As System.Windows.Forms.TextBox
    Friend WithEvents txtMeas3Vt As System.Windows.Forms.TextBox
    Friend WithEvents txtMeas3Hz As System.Windows.Forms.TextBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
End Class
