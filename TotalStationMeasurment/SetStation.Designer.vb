<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetStation
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
        Me.txtSStationBackName = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSStationName = New System.Windows.Forms.TextBox()
        Me.点号 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSStationBackZ = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSStationBackY = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSStationBackX = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSStationSave = New System.Windows.Forms.Button()
        Me.txtSStationZ = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSStationY = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSStationX = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSStation = New System.Windows.Forms.Button()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.TotalStationDataDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TotalStationDataDataSet = New TotalStationMeasurment.TotalStationDataDataSet()
        Me.btnSStationBack = New System.Windows.Forms.Button()
        Me.txtNotice = New System.Windows.Forms.Label()
        Me.txtSStationH = New System.Windows.Forms.TextBox()
        Me.lable = New System.Windows.Forms.Label()
        Me.txtSStationBackH = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnAz = New System.Windows.Forms.Button()
        Me.txtAzName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAz = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtH0 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TotalStationDataDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TotalStationDataDataSet1 = New TotalStationMeasurment.TotalStationDataDataSet1()
        Me.StationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StationTableAdapter = New TotalStationMeasurment.TotalStationDataDataSet1TableAdapters.StationTableAdapter()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalStationDataDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalStationDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalStationDataDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalStationDataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSStationBackName
        '
        Me.txtSStationBackName.Location = New System.Drawing.Point(506, 221)
        Me.txtSStationBackName.Name = "txtSStationBackName"
        Me.txtSStationBackName.Size = New System.Drawing.Size(100, 25)
        Me.txtSStationBackName.TabIndex = 65
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(461, 224)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 15)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = "点号"
        '
        'txtSStationName
        '
        Me.txtSStationName.Location = New System.Drawing.Point(224, 221)
        Me.txtSStationName.Name = "txtSStationName"
        Me.txtSStationName.Size = New System.Drawing.Size(100, 25)
        Me.txtSStationName.TabIndex = 63
        '
        '点号
        '
        Me.点号.AutoSize = True
        Me.点号.Location = New System.Drawing.Point(180, 224)
        Me.点号.Name = "点号"
        Me.点号.Size = New System.Drawing.Size(37, 15)
        Me.点号.TabIndex = 62
        Me.点号.Text = "点号"
        '
        'btnDelete
        '
        Me.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDelete.Location = New System.Drawing.Point(54, 109)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 29)
        Me.btnDelete.TabIndex = 61
        Me.btnDelete.Text = "删除"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(398, 479)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 15)
        Me.Label9.TabIndex = 60
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(388, 224)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 15)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "后视[m]"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(102, 221)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 15)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "测站[m]"
        '
        'txtSStationBackZ
        '
        Me.txtSStationBackZ.Location = New System.Drawing.Point(506, 353)
        Me.txtSStationBackZ.Name = "txtSStationBackZ"
        Me.txtSStationBackZ.Size = New System.Drawing.Size(100, 25)
        Me.txtSStationBackZ.TabIndex = 52
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(472, 356)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 15)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "H"
        '
        'txtSStationBackY
        '
        Me.txtSStationBackY.Location = New System.Drawing.Point(506, 311)
        Me.txtSStationBackY.Name = "txtSStationBackY"
        Me.txtSStationBackY.Size = New System.Drawing.Size(100, 25)
        Me.txtSStationBackY.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(472, 314)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 15)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "E"
        '
        'txtSStationBackX
        '
        Me.txtSStationBackX.Location = New System.Drawing.Point(506, 267)
        Me.txtSStationBackX.Name = "txtSStationBackX"
        Me.txtSStationBackX.Size = New System.Drawing.Size(100, 25)
        Me.txtSStationBackX.TabIndex = 48
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(472, 270)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 15)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "N"
        '
        'btnSStationSave
        '
        Me.btnSStationSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSStationSave.Location = New System.Drawing.Point(359, 465)
        Me.btnSStationSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSStationSave.Name = "btnSStationSave"
        Me.btnSStationSave.Size = New System.Drawing.Size(157, 50)
        Me.btnSStationSave.TabIndex = 46
        Me.btnSStationSave.Text = "保存"
        Me.btnSStationSave.UseVisualStyleBackColor = True
        '
        'txtSStationZ
        '
        Me.txtSStationZ.Location = New System.Drawing.Point(224, 353)
        Me.txtSStationZ.Name = "txtSStationZ"
        Me.txtSStationZ.Size = New System.Drawing.Size(100, 25)
        Me.txtSStationZ.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(190, 356)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 15)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "H"
        '
        'txtSStationY
        '
        Me.txtSStationY.Location = New System.Drawing.Point(224, 311)
        Me.txtSStationY.Name = "txtSStationY"
        Me.txtSStationY.Size = New System.Drawing.Size(100, 25)
        Me.txtSStationY.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(190, 314)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 15)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "E"
        '
        'txtSStationX
        '
        Me.txtSStationX.Location = New System.Drawing.Point(224, 267)
        Me.txtSStationX.Name = "txtSStationX"
        Me.txtSStationX.Size = New System.Drawing.Size(100, 25)
        Me.txtSStationX.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(190, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 15)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "N"
        '
        'btnAdd
        '
        Me.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAdd.Location = New System.Drawing.Point(54, 54)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 29)
        Me.btnAdd.TabIndex = 67
        Me.btnAdd.Text = "添加"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSStation
        '
        Me.btnSStation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSStation.Location = New System.Drawing.Point(54, 300)
        Me.btnSStation.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSStation.Name = "btnSStation"
        Me.btnSStation.Size = New System.Drawing.Size(100, 29)
        Me.btnSStation.TabIndex = 68
        Me.btnSStation.Text = "测站点"
        Me.btnSStation.UseVisualStyleBackColor = True
        '
        'DataGridView
        '
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Location = New System.Drawing.Point(224, 36)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.RowTemplate.Height = 27
        Me.DataGridView.Size = New System.Drawing.Size(399, 119)
        Me.DataGridView.TabIndex = 66
        '
        'TotalStationDataDataSetBindingSource
        '
        Me.TotalStationDataDataSetBindingSource.DataSource = Me.TotalStationDataDataSet
        Me.TotalStationDataDataSetBindingSource.Position = 0
        '
        'TotalStationDataDataSet
        '
        Me.TotalStationDataDataSet.DataSetName = "TotalStationDataDataSet"
        Me.TotalStationDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnSStationBack
        '
        Me.btnSStationBack.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSStationBack.Location = New System.Drawing.Point(349, 300)
        Me.btnSStationBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSStationBack.Name = "btnSStationBack"
        Me.btnSStationBack.Size = New System.Drawing.Size(100, 29)
        Me.btnSStationBack.TabIndex = 69
        Me.btnSStationBack.Text = "后视点"
        Me.btnSStationBack.UseVisualStyleBackColor = True
        '
        'txtNotice
        '
        Me.txtNotice.AutoSize = True
        Me.txtNotice.Location = New System.Drawing.Point(163, 465)
        Me.txtNotice.Name = "txtNotice"
        Me.txtNotice.Size = New System.Drawing.Size(0, 15)
        Me.txtNotice.TabIndex = 70
        '
        'txtSStationH
        '
        Me.txtSStationH.Location = New System.Drawing.Point(224, 390)
        Me.txtSStationH.Name = "txtSStationH"
        Me.txtSStationH.Size = New System.Drawing.Size(100, 25)
        Me.txtSStationH.TabIndex = 72
        '
        'lable
        '
        Me.lable.AutoSize = True
        Me.lable.Location = New System.Drawing.Point(190, 393)
        Me.lable.Name = "lable"
        Me.lable.Size = New System.Drawing.Size(23, 15)
        Me.lable.TabIndex = 71
        Me.lable.Text = "H0"
        '
        'txtSStationBackH
        '
        Me.txtSStationBackH.Location = New System.Drawing.Point(506, 393)
        Me.txtSStationBackH.Name = "txtSStationBackH"
        Me.txtSStationBackH.Size = New System.Drawing.Size(100, 25)
        Me.txtSStationBackH.TabIndex = 74
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(472, 396)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(23, 15)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "H0"
        '
        'btnAz
        '
        Me.btnAz.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAz.Location = New System.Drawing.Point(638, 297)
        Me.btnAz.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAz.Name = "btnAz"
        Me.btnAz.Size = New System.Drawing.Size(100, 29)
        Me.btnAz.TabIndex = 75
        Me.btnAz.Text = "方位角"
        Me.btnAz.UseVisualStyleBackColor = True
        '
        'txtAzName
        '
        Me.txtAzName.Enabled = False
        Me.txtAzName.Location = New System.Drawing.Point(798, 214)
        Me.txtAzName.Name = "txtAzName"
        Me.txtAzName.Size = New System.Drawing.Size(100, 25)
        Me.txtAzName.TabIndex = 77
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(753, 217)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 15)
        Me.Label11.TabIndex = 76
        Me.Label11.Text = "点号"
        '
        'txtAz
        '
        Me.txtAz.Enabled = False
        Me.txtAz.Location = New System.Drawing.Point(798, 250)
        Me.txtAz.Name = "txtAz"
        Me.txtAz.Size = New System.Drawing.Size(100, 25)
        Me.txtAz.TabIndex = 79
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(737, 253)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 15)
        Me.Label14.TabIndex = 78
        Me.Label14.Text = "Az(rad)"
        '
        'txtH0
        '
        Me.txtH0.Enabled = False
        Me.txtH0.Location = New System.Drawing.Point(798, 297)
        Me.txtH0.Name = "txtH0"
        Me.txtH0.Size = New System.Drawing.Size(100, 25)
        Me.txtH0.TabIndex = 83
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(764, 300)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(23, 15)
        Me.Label15.TabIndex = 82
        Me.Label15.Text = "H0"
        '
        'TotalStationDataDataSetBindingSource1
        '
        Me.TotalStationDataDataSetBindingSource1.DataSource = Me.TotalStationDataDataSet
        Me.TotalStationDataDataSetBindingSource1.Position = 0
        '
        'TotalStationDataDataSet1
        '
        Me.TotalStationDataDataSet1.DataSetName = "TotalStationDataDataSet1"
        Me.TotalStationDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StationBindingSource
        '
        Me.StationBindingSource.DataMember = "Station"
        Me.StationBindingSource.DataSource = Me.TotalStationDataDataSet1
        '
        'StationTableAdapter
        '
        Me.StationTableAdapter.ClearBeforeFill = True
        '
        'SetStation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 550)
        Me.Controls.Add(Me.txtH0)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtAz)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtAzName)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnAz)
        Me.Controls.Add(Me.txtSStationBackH)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtSStationH)
        Me.Controls.Add(Me.lable)
        Me.Controls.Add(Me.txtNotice)
        Me.Controls.Add(Me.btnSStationBack)
        Me.Controls.Add(Me.btnSStation)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.txtSStationBackName)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtSStationName)
        Me.Controls.Add(Me.点号)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtSStationBackZ)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSStationBackY)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSStationBackX)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnSStationSave)
        Me.Controls.Add(Me.txtSStationZ)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSStationY)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSStationX)
        Me.Controls.Add(Me.Label2)
        Me.Name = "SetStation"
        Me.Text = "设站"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalStationDataDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalStationDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalStationDataDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalStationDataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSStationBackName As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtSStationName As System.Windows.Forms.TextBox
    Friend WithEvents 点号 As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSStationBackZ As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSStationBackY As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSStationBackX As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnSStationSave As System.Windows.Forms.Button
    Friend WithEvents txtSStationZ As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSStationY As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSStationX As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnSStation As System.Windows.Forms.Button
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents btnSStationBack As System.Windows.Forms.Button
    Friend WithEvents txtNotice As System.Windows.Forms.Label
    Friend WithEvents txtSStationH As System.Windows.Forms.TextBox
    Friend WithEvents lable As System.Windows.Forms.Label
    Friend WithEvents txtSStationBackH As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnAz As System.Windows.Forms.Button
    Friend WithEvents txtAzName As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtAz As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtH0 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TotalStationDataDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TotalStationDataDataSet As TotalStationMeasurment.TotalStationDataDataSet
    Friend WithEvents TotalStationDataDataSetBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TotalStationDataDataSet1 As TotalStationMeasurment.TotalStationDataDataSet1
    Friend WithEvents StationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StationTableAdapter As TotalStationMeasurment.TotalStationDataDataSet1TableAdapters.StationTableAdapter
End Class
