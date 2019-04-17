<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.btnSStation = New System.Windows.Forms.Button()
        Me.btnMeas = New System.Windows.Forms.Button()
        Me.MainNotice = New System.Windows.Forms.Label()
        Me.btnProject = New System.Windows.Forms.Button()
        Me.Connection = New System.Windows.Forms.Button()
        Me.btnStopConn = New System.Windows.Forms.Button()
        Me.btnStopMeas = New System.Windows.Forms.Button()
        Me.TestWorker = New System.ComponentModel.BackgroundWorker()
        Me.TestNotice = New System.Windows.Forms.Label()
        Me.TestNotice1 = New System.Windows.Forms.Label()
        Me.TestNotice2 = New System.Windows.Forms.Label()
        Me.PrismMeasurmentWorker = New System.ComponentModel.BackgroundWorker()
        Me.Notice1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.InstantAiCtrl1 = New Automation.BDaq.InstantAiCtrl(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnSStation
        '
        Me.btnSStation.Location = New System.Drawing.Point(139, 185)
        Me.btnSStation.Name = "btnSStation"
        Me.btnSStation.Size = New System.Drawing.Size(129, 52)
        Me.btnSStation.TabIndex = 1
        Me.btnSStation.Text = "设站"
        Me.btnSStation.UseVisualStyleBackColor = True
        '
        'btnMeas
        '
        Me.btnMeas.Location = New System.Drawing.Point(139, 297)
        Me.btnMeas.Name = "btnMeas"
        Me.btnMeas.Size = New System.Drawing.Size(129, 52)
        Me.btnMeas.TabIndex = 3
        Me.btnMeas.Text = "测量"
        Me.btnMeas.UseVisualStyleBackColor = True
        '
        'MainNotice
        '
        Me.MainNotice.AutoSize = True
        Me.MainNotice.Location = New System.Drawing.Point(171, 393)
        Me.MainNotice.Name = "MainNotice"
        Me.MainNotice.Size = New System.Drawing.Size(0, 15)
        Me.MainNotice.TabIndex = 5
        '
        'btnProject
        '
        Me.btnProject.Location = New System.Drawing.Point(139, 87)
        Me.btnProject.Name = "btnProject"
        Me.btnProject.Size = New System.Drawing.Size(129, 49)
        Me.btnProject.TabIndex = 6
        Me.btnProject.Text = "项目"
        Me.btnProject.UseVisualStyleBackColor = True
        '
        'Connection
        '
        Me.Connection.Location = New System.Drawing.Point(318, 87)
        Me.Connection.Name = "Connection"
        Me.Connection.Size = New System.Drawing.Size(129, 52)
        Me.Connection.TabIndex = 7
        Me.Connection.Text = "建立连接"
        Me.Connection.UseVisualStyleBackColor = True
        '
        'btnStopConn
        '
        Me.btnStopConn.Location = New System.Drawing.Point(316, 185)
        Me.btnStopConn.Name = "btnStopConn"
        Me.btnStopConn.Size = New System.Drawing.Size(129, 52)
        Me.btnStopConn.TabIndex = 8
        Me.btnStopConn.Text = "断开连接"
        Me.btnStopConn.UseVisualStyleBackColor = True
        '
        'btnStopMeas
        '
        Me.btnStopMeas.Location = New System.Drawing.Point(318, 297)
        Me.btnStopMeas.Name = "btnStopMeas"
        Me.btnStopMeas.Size = New System.Drawing.Size(129, 52)
        Me.btnStopMeas.TabIndex = 9
        Me.btnStopMeas.Text = "停止测量"
        Me.btnStopMeas.UseVisualStyleBackColor = True
        '
        'TestWorker
        '
        '
        'TestNotice
        '
        Me.TestNotice.AutoSize = True
        Me.TestNotice.Location = New System.Drawing.Point(500, 247)
        Me.TestNotice.Name = "TestNotice"
        Me.TestNotice.Size = New System.Drawing.Size(0, 15)
        Me.TestNotice.TabIndex = 10
        '
        'TestNotice1
        '
        Me.TestNotice1.AutoSize = True
        Me.TestNotice1.Location = New System.Drawing.Point(500, 316)
        Me.TestNotice1.Name = "TestNotice1"
        Me.TestNotice1.Size = New System.Drawing.Size(0, 15)
        Me.TestNotice1.TabIndex = 11
        '
        'TestNotice2
        '
        Me.TestNotice2.AutoSize = True
        Me.TestNotice2.Location = New System.Drawing.Point(500, 380)
        Me.TestNotice2.Name = "TestNotice2"
        Me.TestNotice2.Size = New System.Drawing.Size(0, 15)
        Me.TestNotice2.TabIndex = 12
        '
        'PrismMeasurmentWorker
        '
        '
        'Notice1
        '
        Me.Notice1.AutoSize = True
        Me.Notice1.Location = New System.Drawing.Point(84, 393)
        Me.Notice1.Name = "Notice1"
        Me.Notice1.Size = New System.Drawing.Size(0, 15)
        Me.Notice1.TabIndex = 13
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'InstantAiCtrl1
        '
        Me.InstantAiCtrl1._StateStream = CType(resources.GetObject("InstantAiCtrl1._StateStream"), Automation.BDaq.DeviceStateStreamer)
        '
        'Timer3
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 359)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 15)
        Me.Label1.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 236)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 15)
        Me.Label2.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(59, 374)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 52)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "测量"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(288, 374)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(129, 52)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "设站"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(27, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(201, 25)
        Me.TextBox1.TabIndex = 18
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(288, 40)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(201, 25)
        Me.TextBox2.TabIndex = 19
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 465)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Notice1)
        Me.Controls.Add(Me.TestNotice2)
        Me.Controls.Add(Me.TestNotice1)
        Me.Controls.Add(Me.TestNotice)
        Me.Controls.Add(Me.btnStopMeas)
        Me.Controls.Add(Me.btnStopConn)
        Me.Controls.Add(Me.Connection)
        Me.Controls.Add(Me.btnProject)
        Me.Controls.Add(Me.MainNotice)
        Me.Controls.Add(Me.btnMeas)
        Me.Controls.Add(Me.btnSStation)
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMain"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSStation As System.Windows.Forms.Button
    Friend WithEvents btnMeas As System.Windows.Forms.Button
    Friend WithEvents MainNotice As System.Windows.Forms.Label
    Friend WithEvents btnProject As System.Windows.Forms.Button
    Friend WithEvents Connection As System.Windows.Forms.Button
    Friend WithEvents btnStopConn As System.Windows.Forms.Button
    Friend WithEvents btnStopMeas As System.Windows.Forms.Button
    Friend WithEvents TestWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents TestNotice As System.Windows.Forms.Label
    Friend WithEvents TestNotice1 As System.Windows.Forms.Label
    Friend WithEvents TestNotice2 As System.Windows.Forms.Label
    Friend WithEvents PrismMeasurmentWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents Notice1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents InstantAiCtrl1 As Automation.BDaq.InstantAiCtrl
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox

End Class
