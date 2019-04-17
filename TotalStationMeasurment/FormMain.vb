
Imports System.Net.Sockets
Imports System.Net
Imports System.Text
Imports System.Threading
Imports System.Math
Imports System.IO


Public Class FormMain




    Dim InstrumentName As String
    Dim InstruNo As String

    Dim cRC As Integer = 1
    Dim cRC1 As Integer = 1
    Dim cRC2 As Integer = 1
    Dim cRC3 As Integer = 1




    Dim C As Double
    Dim L As Double
    Dim Power As String
    Dim ATRon As Long = 1


    Dim testid As Integer
    Enum Test As Integer
        Communication
        CheckPower
        BubbleLevel
        SetUserAtrState
    End Enum
 

    Dim sentid As Integer
    Dim meastid As Integer


    Dim Prism1DoMeasX As Double
    Dim Prism1DoMeasY As Double
    Dim Prism1DoMeasZ As Double
    Dim Prism1DoMeasHz As Double
    Dim Prism1DoMeasVt As Double
    Dim Prism1DoMeasSlopeDistance As Double
    Dim Prism1DoMeasC As Double
    Dim Prism1DoMeasL As Double

  

    Public dataSaveX(5) As Double
    Public dataSaveY(5) As Double
    Public dataSaveZ(5) As Double
    Public dataSaveHz(5) As Double
    Public dataSaveVt(5) As Double
    Public dataSaveSD(5) As Double
   
    Public dataCenX(5) As Double
    Public dataCenY(5) As Double
    Public dataCenZ(5) As Double

    Dim rc As Integer = 1
    Dim rc1 As Integer = 1
    Dim rc2 As Integer = 1
    Dim rc3 As Integer = 1
    Dim rc4 As Integer = 1
    Dim rc5 As Integer = 1
    Dim rc6 As Integer = 1
    Dim rc7 As Integer = 1
    Dim rc8 As Integer = 1

  

    Dim SearchAreaHz As Double = 0.5     '自动寻找第一个棱镜组的寻找范围
    Dim SearchAreaVt As Double = 0.5
    'Dim SearchAreaSetHz() As Double = {0.4, 0.2, 0.2, 0, 0, 0}
    'Dim SearchAreaSetVt() As Double = {0.4, 0.2, 0.2, 0, 0, 0}

    Dim HzArea1 As Double = 0.07    '自动寻找第一个棱镜组后精确定位到其中一个棱镜
    Dim VArea1 As Double = 0.07
    Dim HzArea As Double = 0.07  '棱镜组第二个第三个棱镜寻找范围（因为距离太近，直接精确定位范围）
    Dim VArea As Double = 0.07
   

    Dim Prism1Hz As Double
    Dim Prism1Vt As Double
  

    Dim deltaHz() As Double = {0.09, 1.15, 0.23, 0.23, 1.15}

   
    Dim PrismNum As Integer = 1
    Dim CircleNum As Integer = 1

    Enum sent As Integer
        CheckPower
        FineAdjust1
        DoMeas1
        GetCoordinate1
        GetFullMeas1
        MakePositioning1
        SetUserAtrState
        SearchTarget1
      
    End Enum


    Private Sub Connection_Click(sender As Object, e As EventArgs) Handles Connection.Click

        Try
            If s.Connected Then
                MessageBox.Show(MainNotice.Text, "已连接")
            Else
                testid = Test.Communication
                TestWorker.RunWorkerAsync()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub TestWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles TestWorker.DoWork
        Try
            Select Case testid
                Case Test.Communication
                    TMC_ComTest(InstrumentName, cRC)
                Case Test.BubbleLevel
                    TMC_GetAngle(C, L, cRC1)
                Case Test.CheckPower
                    CSV_CheckPower(Power, cRC2)
                Case Test.SetUserAtrState
                    AUS_SetUserAtrState(ATRon, cRC3)
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TestWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles TestWorker.RunWorkerCompleted
        Try

            Select Case testid

                Case Test.Communication
                    If cRC = 0 Then
                        TestNotice.Text = InstrumentName
                        InitializeSystem()
                        testid = Test.BubbleLevel
                        TestWorker.RunWorkerAsync()
                    Else
                        MessageBox.Show(MainNotice.Text, "连接失败" & ":" & cRC)

                    End If
                Case Test.BubbleLevel
                    If cRC1 = 0 Then

                        If C * 180 / Math.PI * C * 180 / Math.PI + L * 180 / Math.PI * L * 180 / Math.PI < 0.07 Then

                            TestNotice1.Text = "T:" & Math.Round(C * 180 / Math.PI, 4) & "°" + vbLf + "L:" & Math.Round(L * 180 / Math.PI, 4) & "°"

                        Else
                            TestNotice1.Text = "T:XXXX°" + vbLf + "L:XXXX°"

                        End If
                        testid = Test.CheckPower
                        TestWorker.RunWorkerAsync()
                    Else
                        MessageBox.Show(MainNotice.Text, " 全站仪水平测试失败" & ":" & cRC1)

                    End If
                Case Test.CheckPower
                    If cRC2 = 0 Then
                        TestNotice2.Text = CDbl(Power)
                        testid = Test.SetUserAtrState
                        TestWorker.RunWorkerAsync()
                    Else
                        MessageBox.Show(MainNotice.Text, " 全站仪水平测试失败" & ":" & cRC2)

                    End If
                Case Test.SetUserAtrState
                    If cRC3 = 0 Then
                        MessageBox.Show(MainNotice.Text, "全站仪连接成功，ATR打开成功")
                     
                    Else
                        bgwIsBusy = False
                        MessageBox.Show(MainNotice.Text, "ATR打开失败" & ":" & cRC3)

                    End If

            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub btnProject_Click(sender As Object, e As EventArgs) Handles btnProject.Click
        Try
            ProjectInfo.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSStation_Click(sender As Object, e As EventArgs) Handles btnSStation.Click
        Try


            If s.Connected = False Then
                MessageBox.Show(MainNotice.Text, "请先连接全站仪，再进行设站")
            ElseIf btnMeas.Enabled = False Then
                MessageBox.Show(MainNotice.Text, "请先停止测量,再进行设站")
            ElseIf bgwIsBusy = True Or isbusy = True Then
                MessageBox.Show(MainNotice.Text, "正在执行测量，请等待测量完成再执行其他操作")
            Else
                SetStation.Show()

                Dim OleTable As New DataTable
                OleTable = DataAccess.FillTable("Station")
                SetStation.DataGridView.DataSource = OleTable

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Dim count = 0
    Private Sub btnMeas_Click(sender As Object, e As EventArgs) Handles btnMeas.Click

        Try

            If s.Connected = False Then
                MessageBox.Show(MainNotice.Text, "请先连接全站仪再进行测量")
            ElseIf bgwIsBusy = True Or isbusy = True Then

                MessageBox.Show(MainNotice.Text, "正在执行测量,请等待测量完成再执行其他操作")
            Else
                Dim adjmode As Integer
                Dim mm As Integer = 1
                Dim nn As Integer = 1

                isbusy = AUT_GetFineAdjustMode(adjmode, mm)
                If adjmode = 0 Then
                    isbusy = AUT_SetFineAdjustMode(nn)
                    If nn <> 0 Then
                        MessageBox.Show("设置失败" & "," & nn)
                    End If
                End If


                Timer3.Interval = 1000
                Timer3.Enabled = True

                btnMeas.Enabled = False
                bgwIsBusy = True
                PrismNum = 1
                CircleNum = 1
                Prism1Hz = 190 * PI / 180 '210 * PI / 180
                Prism1Vt = 80 * PI / 180

                sentid = sent.MakePositioning1
                PrismMeasurmentWorker.RunWorkerAsync()
                Timer2.Interval = 30000
                Timer2.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        count += 1
        Label1.Text = count
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        Try
            If CircleNum = 1 Then
                Timer1.Interval = 80000
            End If

            Label2.Text = CircleNum
            CircleNum += 1
            PrismNum = 1
            
            sentid = sent.MakePositioning1
            PrismMeasurmentWorker.RunWorkerAsync()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PrismMeasurmentWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles PrismMeasurmentWorker.DoWork
        Try


            Select Case sentid
                Case sent.CheckPower
                    isbusy = CSV_CheckPower(Power, rc)
                Case sent.FineAdjust1
                    isbusy = AUT_FineAdjust(HzArea1, VArea1, rc1)
                Case sent.DoMeas1
                    isbusy = TMC_DoMeas(rc2)
                Case sent.GetCoordinate1
                    isbusy = TMC_GetCoordinate(Prism1DoMeasY, Prism1DoMeasX, Prism1DoMeasZ, rc3)
                Case sent.GetFullMeas1
                    isbusy = TMC_GetFullMeas(Prism1DoMeasHz, Prism1DoMeasVt, Prism1DoMeasC, Prism1DoMeasL, Prism1DoMeasSlopeDistance, rc4)
                Case sent.MakePositioning1
                    isbusy = AUT_MakePositioning(Prism1Hz, Prism1Vt, rc5)
                Case sent.SearchTarget1
                    ' isbusy = BAP_SearchTarget(rc7)
                    isbusy = AUT_Search1(SearchAreaHz, SearchAreaVt, rc7)

            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PrismMeasurmentWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles PrismMeasurmentWorker.RunWorkerCompleted
        Try
            Select Case sentid

                Case sent.MakePositioning1
                    If rc5 = 0 Then
                        '  MessageBox.Show(Prism1Hz * 180 / PI, Prism1Vt * 180 / PI)
                            sentid = sent.SearchTarget1
                        PrismMeasurmentWorker.RunWorkerAsync()
                    Else
                        bgwIsBusy = False
                        Timer1.Enabled = False
                        MessageBox.Show(Notice1.Text, "定位失败" & ":" & PrismNum & "," & rc5)    '显示第几组棱镜的返回码，共六组棱镜
                    End If

                Case sent.SearchTarget1
                    If rc7 = 0 Then
                        sentid = sent.FineAdjust1
                        PrismMeasurmentWorker.RunWorkerAsync()
                    Else
                        bgwIsBusy = False
                        Timer1.Enabled = False
                        MessageBox.Show(Notice1.Text, "目标搜索失败" & ":" & PrismNum & "," & rc7)
                    End If

                Case sent.FineAdjust1
                    If rc1 = 0 Then
                        sentid = sent.DoMeas1
                        PrismMeasurmentWorker.RunWorkerAsync()
                    Else
                        bgwIsBusy = False
                        Timer1.Enabled = False
                        MessageBox.Show(Notice1.Text, "棱镜照准失败" & ":" & PrismNum & "," & rc1)

                    End If

                Case sent.DoMeas1
                    If rc2 = 0 Then
                        sentid = sent.GetCoordinate1
                        PrismMeasurmentWorker.RunWorkerAsync()
                    Else
                        bgwIsBusy = False
                        Timer1.Enabled = False
                        MessageBox.Show(Notice1.Text, "执行测量错误" & ":" & PrismNum & "," & rc2)

                    End If

                Case sent.GetCoordinate1
                    If rc3 = 0 Then
                        sentid = sent.GetFullMeas1
                        PrismMeasurmentWorker.RunWorkerAsync()
                    Else
                        bgwIsBusy = False
                        Timer1.Enabled = False
                        MessageBox.Show(Notice1.Text, "获取坐标错误" & ":" & PrismNum & "," & rc3)
                    End If

                Case sent.GetFullMeas1
                    If rc4 = 0 Then
                        MessageBox.Show(Prism1DoMeasHz * 180 / PI & "," & Prism1DoMeasVt * 180 / PI)

                        dataSaveX(PrismNum - 1) = Math.Round(Prism1DoMeasX, 3)
                        dataSaveY(PrismNum - 1) = Math.Round(Prism1DoMeasY, 3)
                        dataSaveZ(PrismNum - 1) = Math.Round(Prism1DoMeasZ, 3)
                        dataSaveHz(PrismNum - 1) = Math.Round(Prism1DoMeasHz * 180 / PI, 3)
                        dataSaveVt(PrismNum - 1) = Math.Round(Prism1DoMeasVt * 180 / PI, 3)
                        dataSaveSD(PrismNum - 1) = Math.Round(Prism1DoMeasSlopeDistance, 3)

                       
                        If CircleNum = 1 Then
                            If PrismNum < 6 Then
                                Prism1Hz = Prism1DoMeasHz + deltaHz(PrismNum - 1)           '第一个棱镜测量完成，向右定位下一个棱镜
                                Prism1Vt = Prism1DoMeasVt
                            ElseIf PrismNum = 6 Then
                                Prism1Hz = dataSaveHz(0)          '第一轮棱镜测量完毕，定位下一轮棱镜测量，每轮都从最左边开始
                                Prism1Vt = dataSaveVt(0)
                            End If
                        Else
                            If PrismNum < 6 Then
                                Prism1Hz = dataSaveHz(PrismNum)          '第一个棱镜测量完成，向右定位下一个棱镜
                                Prism1Vt = dataSaveVt(PrismNum)
                            ElseIf PrismNum = 6 Then
                                Prism1Hz = dataSaveHz(0)          '第一轮棱镜测量完毕，定位下一轮棱镜测量，每轮都从最左边开始
                                Prism1Vt = dataSaveVt(0)
                            End If
                            
                        End If
                        PrismNum += 1
                        If PrismNum <= 6 Then
                            sentid = sent.MakePositioning1
                            PrismMeasurmentWorker.RunWorkerAsync()
                        Else
                            Dim PrismMeas(36) As String
                            PrismMeas(0) = Now
                            PrismMeas(1) = dataSaveX(0)
                            PrismMeas(2) = dataSaveY(0)
                            PrismMeas(3) = dataSaveZ(0)
                            PrismMeas(4) = dataSaveHz(0)
                            PrismMeas(5) = dataSaveVt(0)
                            PrismMeas(6) = dataSaveSD(0)
                            PrismMeas(7) = dataSaveX(1)
                            PrismMeas(8) = dataSaveY(1)
                            PrismMeas(9) = dataSaveZ(1)
                            PrismMeas(10) = dataSaveHz(1)
                            PrismMeas(11) = dataSaveVt(1)
                            PrismMeas(12) = dataSaveSD(1)
                            PrismMeas(13) = dataSaveX(2)
                            PrismMeas(14) = dataSaveY(2)
                            PrismMeas(15) = dataSaveZ(2)
                            PrismMeas(16) = dataSaveHz(2)
                            PrismMeas(17) = dataSaveVt(2)
                            PrismMeas(18) = dataSaveSD(2)
                            PrismMeas(19) = dataSaveX(3)
                            PrismMeas(20) = dataSaveY(3)
                            PrismMeas(21) = dataSaveZ(3)
                            PrismMeas(22) = dataSaveHz(3)
                            PrismMeas(23) = dataSaveVt(3)
                            PrismMeas(24) = dataSaveSD(3)
                            PrismMeas(25) = dataSaveX(4)
                            PrismMeas(26) = dataSaveY(4)
                            PrismMeas(27) = dataSaveZ(4)
                            PrismMeas(28) = dataSaveHz(4)
                            PrismMeas(29) = dataSaveVt(4)
                            PrismMeas(30) = dataSaveSD(4)
                            PrismMeas(31) = dataSaveX(5)
                            PrismMeas(32) = dataSaveY(5)
                            PrismMeas(33) = dataSaveZ(5)
                            PrismMeas(34) = dataSaveHz(5)
                            PrismMeas(35) = dataSaveVt(5)
                            PrismMeas(36) = dataSaveSD(5)

                            DataAccess.InsertAccess("PrismMeas", ClassEmunStructure.strPrismMeas, PrismMeas)
                            Dim Arrb(2) As Double
                            Dim Arrd(2) As Double
                            Dim theta As Double
                            Dim alpha As Double
                            Dim ArrCen(2) As Double

                            alpha = 15 / (2 * Parameter.R)
                            theta = Parameter.thetaX

                            For I = 0 To dataSaveX.Length - 1
                                Arrb = {dataSaveX(I), dataSaveY(I), dataSaveZ(I)}
                                arrd = {dataSaveX(I + 1), dataSaveY(I + 1), dataSaveZ(I + 1)}

                                ArrCen = Calculate.CenterPointCal(Arrb, Arrd, theta, alpha)

                                dataCenX(I) = ArrCen(0)
                                dataCenY(I) = ArrCen(1)
                                dataCenZ(I) = ArrCen(2)
                                I += 1
                            Next

                            Parameter.SixPrism1X = dataCenX(0)
                            Parameter.SixPrism1Y = dataCenY(0)
                            Parameter.SixPrism1Z = dataCenZ(0)
                            Parameter.SixPrism2X = dataCenX(1)
                            Parameter.SixPrism2Y = dataCenY(1)
                            Parameter.SixPrism2Z = dataCenZ(1)
                            Parameter.SixPrism3X = dataCenX(2)
                            Parameter.SixPrism3Y = dataCenY(2)
                            Parameter.SixPrism3Z = dataCenZ(2)
                            Parameter.SixPrism4X = dataCenX(3)
                            Parameter.SixPrism4Y = dataCenY(3)
                            Parameter.SixPrism4Z = dataCenZ(3)
                            Parameter.SixPrism5X = dataCenX(4)
                            Parameter.SixPrism5Y = dataCenY(4)
                            Parameter.SixPrism5Z = dataCenZ(4)
                            Parameter.SixPrism6X = dataCenX(5)
                            Parameter.SixPrism6Y = dataCenY(5)
                            Parameter.SixPrism6Z = dataCenZ(5)

                            Dim PrismCal(18) As String
                            PrismCal(0) = Now
                            PrismCal(1) = dataCenX(0)
                            PrismCal(2) = dataCenY(0)
                            PrismCal(3) = dataCenZ(0)
                            PrismCal(4) = dataCenX(1)
                            PrismCal(5) = dataCenY(1)
                            PrismCal(6) = dataCenZ(1)
                            PrismCal(7) = dataCenX(2)
                            PrismCal(8) = dataCenY(2)
                            PrismCal(9) = dataCenZ(2)
                            PrismCal(10) = dataCenX(3)
                            PrismCal(11) = dataCenY(3)
                            PrismCal(12) = dataCenZ(3)
                            PrismCal(13) = dataCenX(4)
                            PrismCal(14) = dataCenY(4)
                            PrismCal(15) = dataCenZ(4)
                            PrismCal(16) = dataCenX(5)
                            PrismCal(17) = dataCenY(5)
                            PrismCal(18) = dataCenZ(5)

                            DataAccess.InsertAccess("SixPrismCal", ClassEmunStructure.strPrismCal, PrismCal)      '保存到数据库


                            Timer1.Enabled = True


                        End If

                    Else
                        bgwIsBusy = False
                        Timer1.Enabled = False
                        MessageBox.Show(Notice1.Text, "获取角度距离1错误" & ":" & PrismNum & "," & rc4)
                    End If

            End Select



        Catch ex As Exception
            bgwIsBusy = False
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick     '采集卡采集数据

        Dim data(8) As Double
        Dim delta(8) As Double

        Dim CrossMat As New Matrix
        Dim A(2) As Double    'A点坐标
        Dim B(2) As Double    'B点坐标
        Dim C(2) As Double    'C点坐标
        Dim Arr1(2) As Double     'BA,BC的叉乘 第一个面的法向量
        Dim M1(2) As Double     '三角形ABC的质心点

        Dim U(2) As Double    'A点坐标
        Dim V(2) As Double    'B点坐标
        Dim W(2) As Double    'C点坐标
        Dim Arr2(2) As Double     'VW,VU的叉乘  第二个面的法向量
        Dim M2(2) As Double     '三角形UVW的质心点
        Dim Arr3(2) As Double   '第三个面的法向量

        Dim Q(2) As Double    '激光线与被测杆的端面交点







        '获得采集卡测量的六组数据

        InstantAiCtrl1.Read(0, 9, data)
        'Dim bb, aa, aaa As Double
        'InstantAiCtrl1.Read(9, 3, data)
        'bb = data(0) * 40 / 10 - 20
        'aa = data(1) * 40 / 10 - 20
        'aaa = data(2) * 40 / 10 - 20
        'MessageBox.Show(bb & "," & aa & "," & aaa)
        'For i = 0 To 6 'data.Length() - 1
        '    delta(i) = data(i) * 40 / 10 - 20 + 85
        'Next
        'If (delta(0) < 65 Or delta(0) > 105) Or (delta(1) < 65 Or delta(1) > 105) Or (delta(2) < 65 Or delta(2) > 105) Then
        '    MessageBox.Show("顶面位移传感器测量超限")
        'End If
        'If (delta(3) < 65 Or delta(3) > 105) Or (delta(4) < 65 Or delta(4) > 105) Or (delta(5) < 65 Or delta(5) > 105) Then
        '    MessageBox.Show("测面位移传感器测量超限")
        'End If
        'If (delta(6) < 65 Or delta(6) > 105) Then
        '    MessageBox.Show("端面位移传感器测量超限")
        'End If


        '  MessageBox.Show(delta(0) & "," & delta(1) & "," & delta(2) & "," & delta(3) & "," & delta(4) & "," & delta(5) & "," & delta(6))

        delta(7) = data(7) * 30 / 10 - 15
        delta(8) = data(8) * 30 / 10 - 15
        'If (delta(7) < -15 Or delta(7) > 15) Then
        '    MessageBox.Show("梁横面角度测量超限")
        'End If
        'If (delta(8) < -15 Or delta(8) > 15) Then
        '    MessageBox.Show("梁纵面角度测量超限")
        'End If
        TextBox1.Text = delta(7)
        TextBox2.Text = delta(8)
        ' MessageBox.Show(delta(7) & "," & delta(8))

    End Sub



    Private Sub btnStopConn_Click(sender As Object, e As EventArgs) Handles btnStopConn.Click

        Try

            If s.Connected Then
                s.Shutdown(SocketShutdown.Both)
                System.Threading.Thread.Sleep(10)
                s.Close()
                DataAccess.Close()

                cRC = 1
                cRC1 = 1
                cRC2 = 1
                cRC3 = 1
                MessageBox.Show(MainNotice.Text, "断开连接")
            Else
                MessageBox.Show(MainNotice.Text, "已断开")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnStopMeas_Click(sender As Object, e As EventArgs) Handles btnStopMeas.Click
        Try

            btnMeas.Enabled = True
            isbusy = False
            bgwIsBusy = False
            Timer1.Enabled = False
            Timer2.Enabled = False
            Timer3.Enabled = False
            count = 0
            Label2.Text = 0
            rc = 1
            rc1 = 1
            rc2 = 1
            rc3 = 1
            rc4 = 1
            rc5 = 1
            rc6 = 1
            rc7 = 1
            rc8 = 1
           
            Dim scrc As Integer = 1
            Dim sdrc As Integer = 1
            'isbusy = MOT_StopControler(scrc)
            'MessageBox.Show(MainNotice.Text, ":" & scrc)



            isbusy = TMC_DoMeasstop(sdrc)
            If sdrc = 0 Then
                MessageBox.Show(MainNotice.Text, "已停止测量" & ":" & sdrc)
            Else
                MessageBox.Show(MainNotice.Text, "停止测量失败" & ":" & sdrc)
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FormMain_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        s.Close()
    End Sub

   
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Left = 300 '左
        Me.Top = 200 '上
        Me.Width = 500 '宽
        Me.Height = 450 '高
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Prism1Hz = 190 * PI / 180 '210 * PI / 180
        Prism1Vt = 80 * PI / 180
        isbusy = AUT_MakePositioning(Prism1Hz, Prism1Vt, rc5)
        If rc5 = 0 Then
            isbusy = AUT_FineAdjust2(0.5, 0.5, rc1)
            If rc1 = 0 Then
                sentid = sent.DoMeas1
                PrismMeasurmentWorker.RunWorkerAsync()
            End If
        End If

        Select sentid
            Case sent.DoMeas1
                If rc2 = 0 Then
                    sentid = sent.GetCoordinate1
                    PrismMeasurmentWorker.RunWorkerAsync()
                Else
                    bgwIsBusy = False
                    Timer1.Enabled = False
                    MessageBox.Show(Notice1.Text, "执行测量错误" & ":" & PrismNum & "," & rc2)

                End If

            Case sent.GetCoordinate1
                If rc3 = 0 Then
                    sentid = sent.GetFullMeas1
                    PrismMeasurmentWorker.RunWorkerAsync()
                Else
                    bgwIsBusy = False
                    Timer1.Enabled = False
                    MessageBox.Show(Notice1.Text, "获取坐标错误" & ":" & PrismNum & "," & rc3)
                End If

            Case sent.GetFullMeas1
                If rc4 = 0 Then
                    MessageBox.Show(Prism1DoMeasHz * 180 / PI & "," & Prism1DoMeasVt * 180 / PI)
                End If

        End Select

    End Sub





    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Timer2.Interval = 100
        Timer2.Enabled = True



        Dim data(8) As Double
        Dim delta(8) As Double

        Dim CrossMat As New Matrix
        Dim A(2) As Double    'A点坐标
        Dim B(2) As Double    'B点坐标
        Dim C(2) As Double    'C点坐标
        Dim Arr1(2) As Double     'BA,BC的叉乘 第一个面的法向量
        Dim M1(2) As Double     '三角形ABC的质心点

        Dim U(2) As Double    'A点坐标
        Dim V(2) As Double    'B点坐标
        Dim W(2) As Double    'C点坐标
        Dim Arr2(2) As Double     'VW,VU的叉乘  第二个面的法向量
        Dim M2(2) As Double     '三角形UVW的质心点
        Dim Arr3(2) As Double   '第三个面的法向量

        Dim Q(2) As Double    '激光线与被测杆的端面交点







        '获得采集卡测量的六组数据

        InstantAiCtrl1.Read(0, 9, data)
        'Dim bb, aa, aaa As Double
        'InstantAiCtrl1.Read(9, 3, data)
        'bb = data(0) * 40 / 10 - 20
        'aa = data(1) * 40 / 10 - 20
        'aaa = data(2) * 40 / 10 - 20
        'MessageBox.Show(bb & "," & aa & "," & aaa)
        For i = 0 To 6 'data.Length() - 1
            delta(i) = data(i) * 40 / 10 - 20 + 85
        Next
        If (delta(0) < 65 Or delta(0) > 105) Or (delta(1) < 65 Or delta(1) > 105) Or (delta(2) < 65 Or delta(2) > 105) Then
            MessageBox.Show("顶面位移传感器测量超限")
        End If
        If (delta(3) < 65 Or delta(3) > 105) Or (delta(4) < 65 Or delta(4) > 105) Or (delta(5) < 65 Or delta(5) > 105) Then
            MessageBox.Show("测面位移传感器测量超限")
        End If
        If (delta(6) < 65 Or delta(6) > 105) Then
            MessageBox.Show("端面位移传感器测量超限")
        End If


        MessageBox.Show(delta(0) & "," & delta(1) & "," & delta(2) & "," & delta(3) & "," & delta(4) & "," & delta(5) & "," & delta(6))

        delta(7) = data(7) * 30 / 10 - 15
        delta(8) = data(8) * 30 / 10 - 15
        If (delta(7) < -15 Or delta(7) > 15) Then
            MessageBox.Show("梁横面角度测量超限")
        End If
        If (delta(8) < -15 Or delta(8) > 15) Then
            MessageBox.Show("梁纵面角度测量超限")
        End If

        MessageBox.Show(delta(7) & "," & delta(8))

        Parameter.thetaX = delta(7)
        Parameter.thetaY = delta(8)

        '位移传感器的激光线与被测杆的侧面交点
        A = {171.8, 9.5 - delta(3), 22}
        B = {141.8, 9.5 - delta(4), 42}
        C = {111.8, 9.5 - delta(5), 22}
        '位移传感器的激光线与被测杆的顶面交点
        U = {166.8, -58.7, 89.5 - delta(0)}
        V = {136.806, -38.7, 89.5 - delta(1)}
        W = {106.8, -58.7, 89.5 - delta(2)}


        '通过BA，BC向量叉乘获得侧面法向量Arr1，通过A,B,C三点求得质心点坐标M1

        CrossMat.Cross(A, B, C, Arr1, M1)
        MessageBox.Show(Arr1(0) & "," & Arr1(1) & "," & Arr1(2))

        '通过VW，VU向量叉乘获得顶面法向量Arr2，通过U,V,W三点求得质心点坐标M2
        CrossMat.Cross(W, V, U, Arr2, M2)
        MessageBox.Show(Arr2(0) & "," & Arr2(1) & "," & Arr2(2))

        '通过法向量叉乘求得第三个面端面的法向量Arr3
        Arr3 = CrossMat.Cross1(Arr1, Arr2)
        MessageBox.Show(Arr3(0) & "," & Arr3(1) & "," & Arr3(2))
        Q = {-5.2 + delta(6), -44.2, 23.5}   '激光线与被测杆的端面交点

        Dim tMat As Matrix
        tMat = New Matrix(3, 3)
        Dim D As Integer = tMat.RowSize
        Dim resultMat As New Matrix(D, D)

        '求逆矩阵
        tMat.Item(1, 1) = Arr1(0)
        tMat.Item(1, 2) = Arr1(1)
        tMat.Item(1, 3) = Arr1(2)
        tMat.Item(2, 1) = Arr2(0)
        tMat.Item(2, 2) = Arr2(1)
        tMat.Item(2, 3) = Arr2(2)
        tMat.Item(3, 1) = Arr3(0)
        tMat.Item(3, 2) = Arr3(1)
        tMat.Item(3, 3) = Arr3(2)


        '  tMat.InverseMatrix()

        Dim VecMat As Matrix
        VecMat = New Matrix(3, 1)
        VecMat.Item(1, 1) = Arr1(0) * M1(0) + Arr1(1) * M1(1) + Arr1(2) * M1(2)
        VecMat.Item(2, 1) = Arr2(0) * M2(0) + Arr2(1) * M2(1) + Arr2(2) * M2(2)
        VecMat.Item(3, 1) = Arr3(0) * Q(0) + Arr3(1) * Q(1) + Arr3(2) * Q(2)

        Dim OriginMat As Matrix     '被测杆坐标系坐标原点，三个被测平面的交点
        OriginMat = New Matrix(3, 1)
        OriginMat = tMat.InverseMatrix * VecMat

        MessageBox.Show(OriginMat.toString)

        Dim Arr4(2) As Double   '归一化
        Dim Arr5(2) As Double
        Dim Arr6(2) As Double
        For i = 0 To Arr1.Length() - 1
            Arr4(i) = Arr1(i) / Math.Sqrt(Arr1(0) ^ 2 + Arr1(1) ^ 2 + Arr1(2) ^ 2)    '侧面单位法向量
            Arr5(i) = Arr2(i) / Math.Sqrt(Arr2(0) ^ 2 + Arr2(1) ^ 2 + Arr2(2) ^ 2)    '顶面单位法向量
            Arr6(i) = Arr3(i) / Math.Sqrt(Arr3(0) ^ 2 + Arr3(1) ^ 2 + Arr3(2) ^ 2)    '端面单位法向量
        Next

        Dim TransMat As Matrix     'T P-S   中间变换矩阵
        TransMat = New Matrix(4, 4)
        TransMat.Item(1, 1) = Arr6(0)
        TransMat.Item(2, 1) = Arr6(1)
        TransMat.Item(3, 1) = Arr6(2)
        TransMat.Item(1, 4) = OriginMat.Item(1, 1)
        TransMat.Item(1, 2) = Arr4(0)
        TransMat.Item(2, 2) = Arr4(1)
        TransMat.Item(3, 2) = Arr4(2)
        TransMat.Item(2, 4) = OriginMat.Item(2, 1)
        TransMat.Item(1, 3) = Arr5(0)
        TransMat.Item(2, 3) = Arr5(1)
        TransMat.Item(3, 3) = Arr5(2)
        TransMat.Item(3, 4) = OriginMat.Item(3, 1)
        TransMat.Item(4, 1) = 0
        TransMat.Item(4, 2) = 0
        TransMat.Item(4, 3) = 0
        TransMat.Item(4, 4) = 1

        MessageBox.Show(TransMat.toString)

        Dim ConstMat As New Matrix(4, 1)      'T坐标系下的原点坐标OT
        ConstMat.Item(1, 1) = 0
        ConstMat.Item(2, 1) = 0
        ConstMat.Item(3, 1) = 0
        ConstMat.Item(4, 1) = 1
        Dim TpMat As New Matrix(4, 4)    'T-P
        TpMat.Item(1, 1) = 1
        TpMat.Item(1, 2) = 0
        TpMat.Item(1, 3) = 0
        TpMat.Item(1, 4) = 299
        TpMat.Item(2, 1) = 0
        TpMat.Item(2, 2) = 1
        TpMat.Item(2, 3) = 0
        TpMat.Item(2, 4) = 50.5
        TpMat.Item(3, 1) = 0
        TpMat.Item(3, 2) = 0
        TpMat.Item(3, 3) = 1
        TpMat.Item(3, 4) = -60.5
        TpMat.Item(4, 1) = 0
        TpMat.Item(4, 2) = 0
        TpMat.Item(4, 3) = 0
        TpMat.Item(4, 4) = 1



        Dim TbMat As New Matrix(4, 4)   'T S-B
        TbMat.Item(1, 1) = 1
        TbMat.Item(1, 2) = 0
        TbMat.Item(1, 3) = 0
        TbMat.Item(1, 4) = 94.1
        TbMat.Item(2, 1) = 0
        TbMat.Item(2, 2) = 1
        TbMat.Item(2, 3) = 0
        TbMat.Item(2, 4) = 40
        TbMat.Item(3, 1) = 0
        TbMat.Item(3, 2) = 0
        TbMat.Item(3, 3) = 1
        TbMat.Item(3, 4) = 62
        TbMat.Item(4, 1) = 0
        TbMat.Item(4, 2) = 0
        TbMat.Item(4, 3) = 0
        TbMat.Item(4, 4) = 1

        Dim Inter1Mat As New Matrix(4, 1)
        Dim Inter2Mat As New Matrix(4, 1)    '姿态矩阵T  T-B
        Dim LastMat As New Matrix(4, 1)       'OT在B中的坐标

        Inter1Mat = TbMat * TransMat
        Inter2Mat = Inter1Mat * TpMat
        LastMat = Inter2Mat * ConstMat

        MessageBox.Show(LastMat.toString)


        Dim Angle(2) As Double

        Angle(0) = Acos(Arr4(1)) * 180 / PI   '侧面夹角   弧度
        Angle(1) = Acos(Arr5(2)) * 180 / PI   '顶面夹角
        Angle(2) = Acos(Arr6(0)) * 180 / PI   '端面夹角
        MessageBox.Show(Angle(0) & "," & Angle(1) & "," & Angle(2))

        '旋转角
        'Angle(0) = Math.Atan2(Inter2Mat.Item(3, 2), Inter2Mat.Item(3, 3))
        'Angle(1) = Math.Atan2(-1 * Inter2Mat.Item(3, 1), Math.Sqrt(Inter2Mat.Item(3, 2) ^ 2 + Inter2Mat.Item(3, 3) ^ 2))
        'Angle(2) = Math.Atan2(Inter2Mat.Item(2, 1), Inter2Mat.Item(1, 1))

        Dim SurfaceCal(6) As String
        SurfaceCal(0) = Now
        SurfaceCal(1) = LastMat.Item(1, 1)
        SurfaceCal(2) = LastMat.Item(2, 1)
        SurfaceCal(3) = LastMat.Item(3, 1)
        SurfaceCal(4) = Angle(0)
        SurfaceCal(5) = Angle(1)
        SurfaceCal(6) = Angle(2)

        InitializeSystem()
        DataAccess.InsertAccess("ThreeSurfaceCal", ClassEmunStructure.strSurfaceCal, SurfaceCal)


    End Sub

   
End Class
