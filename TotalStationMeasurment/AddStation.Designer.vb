<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStation
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
        Me.btnCancle = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtZ = New System.Windows.Forms.TextBox()
        Me.txtY = New System.Windows.Forms.TextBox()
        Me.txtX = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Notice = New System.Windows.Forms.Label()
        Me.txtH = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCancle
        '
        Me.btnCancle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCancle.Location = New System.Drawing.Point(273, 328)
        Me.btnCancle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancle.Name = "btnCancle"
        Me.btnCancle.Size = New System.Drawing.Size(100, 29)
        Me.btnCancle.TabIndex = 29
        Me.btnCancle.Text = "CANCLE"
        Me.btnCancle.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnOK.Location = New System.Drawing.Point(134, 328)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(100, 29)
        Me.btnOK.TabIndex = 28
        Me.btnOK.Text = "SAVE"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'txtZ
        '
        Me.txtZ.Location = New System.Drawing.Point(214, 237)
        Me.txtZ.Margin = New System.Windows.Forms.Padding(4)
        Me.txtZ.Name = "txtZ"
        Me.txtZ.Size = New System.Drawing.Size(132, 25)
        Me.txtZ.TabIndex = 27
        '
        'txtY
        '
        Me.txtY.Location = New System.Drawing.Point(214, 198)
        Me.txtY.Margin = New System.Windows.Forms.Padding(4)
        Me.txtY.Name = "txtY"
        Me.txtY.Size = New System.Drawing.Size(132, 25)
        Me.txtY.TabIndex = 26
        '
        'txtX
        '
        Me.txtX.Location = New System.Drawing.Point(214, 154)
        Me.txtX.Margin = New System.Windows.Forms.Padding(4)
        Me.txtX.Name = "txtX"
        Me.txtX.Size = New System.Drawing.Size(132, 25)
        Me.txtX.TabIndex = 25
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(214, 107)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(132, 25)
        Me.txtName.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(136, 237)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 15)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Z"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(134, 198)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 15)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Y"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(134, 154)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 15)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(131, 111)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 15)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "ID"
        '
        'Notice
        '
        Me.Notice.AutoSize = True
        Me.Notice.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Notice.Location = New System.Drawing.Point(229, 378)
        Me.Notice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Notice.Name = "Notice"
        Me.Notice.Size = New System.Drawing.Size(0, 15)
        Me.Notice.TabIndex = 30
        '
        'txtH
        '
        Me.txtH.Location = New System.Drawing.Point(214, 283)
        Me.txtH.Margin = New System.Windows.Forms.Padding(4)
        Me.txtH.Name = "txtH"
        Me.txtH.Size = New System.Drawing.Size(132, 25)
        Me.txtH.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(136, 283)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 15)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "H"
        '
        'AddStation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 424)
        Me.Controls.Add(Me.txtH)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Notice)
        Me.Controls.Add(Me.btnCancle)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtZ)
        Me.Controls.Add(Me.txtY)
        Me.Controls.Add(Me.txtX)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddStation"
        Me.Text = "AddStation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancle As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents txtZ As System.Windows.Forms.TextBox
    Friend WithEvents txtY As System.Windows.Forms.TextBox
    Friend WithEvents txtX As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Notice As System.Windows.Forms.Label
    Friend WithEvents txtH As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
