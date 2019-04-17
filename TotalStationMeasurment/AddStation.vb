Public Class AddStation

 
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Try
            If txtName.Text = "" Or txtX.Text = "" Or txtY.Text = "" Or txtZ.Text = "" Then
                MessageBox.Show(Notice.Text, "请输入全部数据 ")
            ElseIf IsNumeric(txtX.Text) = False Or IsNumeric(txtY.Text) = False Or IsNumeric(txtZ.Text) = False Then
                MessageBox.Show(Notice.Text, "输入数据格式错误")
            Else
                'Dim enumStructure As New ClassEmunStructure1
                'Dim AccessStation As New DataAccess1
                Dim RowValue(5) As String
                RowValue(0) = Now
                RowValue(1) = "'" & txtName.Text & "'"
                RowValue(2) = txtX.Text
                RowValue(3) = txtY.Text
                RowValue(4) = txtZ.Text
                RowValue(5) = txtH.Text

                'AccessStation.InitializeAccess(Project.StartPath)
                'AccessStation.Open()
                DataAccess.InsertAccess("Station", ClassEmunStructure.strStation, RowValue)


                Dim OleTable As New DataTable
                OleTable = DataAccess.FillTable("Station")
                SetStation.DataGridView.DataSource = OleTable
                'AccessStation.Close()
                MessageBox.Show(Notice.Text, "添加成功")
                Me.Close()
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
       
    End Sub

    

    Private Sub btnCancle_Click(sender As Object, e As EventArgs) Handles btnCancle.Click
        Me.Close()
    End Sub

    
End Class