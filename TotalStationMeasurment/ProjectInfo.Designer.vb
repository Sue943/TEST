<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProjectInfo
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
        Me.btnCreatItem = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.btnSelectItem = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCreatItem
        '
        Me.btnCreatItem.Location = New System.Drawing.Point(126, 220)
        Me.btnCreatItem.Name = "btnCreatItem"
        Me.btnCreatItem.Size = New System.Drawing.Size(109, 26)
        Me.btnCreatItem.TabIndex = 2
        Me.btnCreatItem.Text = "创建项目"
        Me.btnCreatItem.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(133, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "项目信息"
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(203, 115)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(152, 25)
        Me.txtItemName.TabIndex = 4
        '
        'btnSelectItem
        '
        Me.btnSelectItem.Location = New System.Drawing.Point(286, 220)
        Me.btnSelectItem.Name = "btnSelectItem"
        Me.btnSelectItem.Size = New System.Drawing.Size(109, 26)
        Me.btnSelectItem.TabIndex = 5
        Me.btnSelectItem.Text = "选择项目"
        Me.btnSelectItem.UseVisualStyleBackColor = True
        '
        'ProjectInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 431)
        Me.Controls.Add(Me.btnSelectItem)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCreatItem)
        Me.Name = "ProjectInfo"
        Me.Text = "ProjectInfo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCreatItem As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtItemName As System.Windows.Forms.TextBox
    Friend WithEvents btnSelectItem As System.Windows.Forms.Button
End Class
