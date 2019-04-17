Imports System.Net.Sockets
Imports System.Net
Imports System.Text
Imports System.Threading
Public Class SetStation

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            AddStation.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    



    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If (MessageBox.Show("确定删除该行 DELETE？", "提示 INFORMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then

                Dim OleTable As New DataTable


                Try
                    'DataAccess.InitializeAccess(Project.StartPath)
                    'DataAccess.Open()
                    DataAccess.DeleteAccess("Station", "MeasTime", "#" & DataGridView.CurrentRow.Cells(0).Value & "#")
                    OleTable = DataAccess.FillTable("Station")
                    DataGridView.DataSource = OleTable
                    'DataAccess.Close()

                    MessageBox.Show(txtNotice.Text, "测站坐标删除成功")

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub



    Private Sub btnSStation_Click(sender As Object, e As EventArgs) Handles btnSStation.Click
        Try
            Dim i As Integer
            i = DataGridView.CurrentCell.RowIndex

            txtSStationName.Text = DataGridView.Item("Name", i).Value
            txtSStationX.Text = DataGridView.Item("X", i).Value
            txtSStationY.Text = DataGridView.Item("Y", i).Value
            txtSStationZ.Text = DataGridView.Item("Z", i).Value
            txtSStationH.Text = DataGridView.Item("H", i).Value


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSStationBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSStationBack.Click
        Try
            Dim i As Integer

            i = DataGridView.CurrentCell.RowIndex

            txtSStationBackName.Text = DataGridView.Item("Name", i).Value
            txtSStationBackX.Text = DataGridView.Item("X", i).Value
            txtSStationBackY.Text = DataGridView.Item("Y", i).Value
            txtSStationBackZ.Text = DataGridView.Item("Z", i).Value
            txtSStationBackH.Text = DataGridView.Item("H", i).Value

            btnAz.Enabled = False
            txtAzName.Enabled = False
            txtAz.Enabled = False
            txtH0.Enabled = False

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    
    Private Sub btnSStationSave_Click(sender As Object, e As EventArgs) Handles btnSStationSave.Click

        Try
            If txtSStationX.Text = "" Or txtSStationY.Text = "" Or txtSStationZ.Text = "" Then
                MessageBox.Show(txtNotice.Text, "请添加测站")

            ElseIf btnSStationBack.Enabled = True And (txtSStationBackX.Text = "" Or txtSStationBackY.Text = "" Or txtSStationBackZ.Text = "") Then
                MessageBox.Show(txtNotice.Text, "请添加后视")
            ElseIf btnAz.Enabled = True And (txtAzName.Text = "" Or txtAz.Text = "" Or txtH0.Text = "") Then
                MessageBox.Show(txtNotice.Text, "请添加方位角")

            Else
                Station.XYZName = txtSStationName.Text
                Station.XYZX = txtSStationX.Text
                Station.XYZY = txtSStationY.Text
                Station.XYZZ = txtSStationZ.Text
                Station.XYZH = txtSStationH.Text


                If btnSStationBack.Enabled = True Then
                    Station.BackName = txtSStationBackName.Text
                    Station.BackX = txtSStationBackX.Text
                    Station.BackY = txtSStationBackY.Text
                    Station.BackZ = txtSStationBackZ.Text
                    Station.BackH = txtSStationBackH.Text


                ElseIf btnAz.Enabled = True Then
                    Station.AzName = txtAzName.Text
                    Station.AzAz = txtAz.Text
                    Station.AzH0 = txtH0.Text
                End If

                'station为0, back为1
                Dim StationSet(9) As String
                StationSet(0) = Now
                StationSet(1) = "'" & txtSStationName.Text & "'"
                StationSet(2) = txtSStationX.Text
                StationSet(3) = txtSStationY.Text
                StationSet(4) = txtSStationZ.Text
                StationSet(5) = txtSStationH.Text
                StationSet(6) = 0
                StationSet(7) = 0
                StationSet(8) = 0
                StationSet(9) = 0

                Dim StationBackSet(9) As String
                If btnSStationBack.Enabled = True Then
                    StationBackSet(0) = Now
                    StationBackSet(1) = "'" & txtSStationBackName.Text & "'"
                    StationBackSet(2) = txtSStationBackX.Text
                    StationBackSet(3) = txtSStationBackY.Text
                    StationBackSet(4) = txtSStationBackZ.Text
                    StationBackSet(5) = txtSStationBackH.Text
                    StationBackSet(6) = 1
                    StationBackSet(7) = "null"
                    StationBackSet(8) = "null"
                    StationBackSet(9) = "null"

                ElseIf btnAz.Enabled = True Then
                    StationBackSet(0) = Now
                    StationBackSet(1) = "null"
                    StationBackSet(2) = "null"
                    StationBackSet(3) = "null"
                    StationBackSet(4) = "null"
                    StationBackSet(5) = "null"
                    StationBackSet(6) = 1
                    StationBackSet(7) = "'" & txtAzName.Text & "'"
                    StationBackSet(8) = txtAz.Text
                    StationBackSet(9) = txtH0.Text

                End If



                'DataAccess.InitializeAccess(Project.StartPath)
                'DataAccess.Open()
                DataAccess.InsertAccess("StationSet", ClassEmunStructure.strStationSet, StationSet)
                DataAccess.InsertAccess("StationSet", ClassEmunStructure.strStationSet, StationBackSet)
                'DataAccess.Close()


                MessageBox.Show(txtNotice.Text, "测站坐标保存成功")
                Me.Hide()
                Orientation.Show()
                End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAz_Click(sender As Object, e As EventArgs) Handles btnAz.Click
        txtAzName.Enabled = True
        txtAz.Enabled = True
        txtH0.Enabled = True
        btnSStationBack.Enabled = False
        txtSStationBackName.Enabled = False
        txtSStationBackX.Enabled = False
        txtSStationBackY.Enabled = False
        txtSStationBackZ.Enabled = False
        txtSStationBackH.Enabled = False
    End Sub

    

    Private Sub DataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellEndEdit
        Try
            If (MessageBox.Show("确定更改数据 CHANGE？", "提示 INMORMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then

                Dim OleTable As New DataTable
                OleTable = DataAccess.FillTable("Station")
                Try
                    Dim i As Integer
                    Dim j As Integer
                    i = DataGridView.CurrentCell.RowIndex
                    j = DataGridView.CurrentCell.ColumnIndex
                    OleTable.Rows(i).Item(j) = DataGridView.CurrentCell.Value
                    DataAccess.UpdataTable(OleTable, "Station")
                    '  OleTable.AcceptChanges()
                    DataGridView.DataSource = OleTable
                    ' DataAccess.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SetStation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Left = 300 '左
        Me.Top = 200 '上
        Me.Width = 750 '宽
        Me.Height = 500 '高

    End Sub
End Class