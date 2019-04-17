Imports System.Threading
Imports System.Net.Sockets
Imports System.Net
Imports System.Text
Imports System.Math



Public Class Orientation

  

    ' Dim RC As Integer
    Dim sPrismBackZ As Double
    Dim sPrismBackY As Double
    Dim sPrismBackX As Double

    Dim sentid As Integer
    Dim sPrismBackHz As Double
    Dim sPrismBackVt As Double
    Dim sPrismBackSlopeDistance As Double
    Dim DesignDistance As Double


  

    Dim Az As Double
    Dim H0 As Double

    Dim SBackDeltaX As Double
    Dim SBackDeltaY As Double
    Dim SBackDeltaZ As Double


    Dim Orientation As Double
    Dim SXY(1) As Double
    Dim BXY(1) As Double

    Dim BackMeasX As Double
    Dim BackMeasY As Double
    Dim BackMeasZ As Double
    Dim BackMeasHz As Double
    Dim BackMeasVt As Double
    Dim BackMeasDistance As Double
    Dim BackdeltaX As Double
    Dim BackdeltaY As Double
    Dim BackdeltaZ As Double
    Dim BackDesignDistance As Double
    Dim BackGapDistance As Double

    Dim RC As Integer = 1
    Dim RC1 As Integer = 1
    Dim RC2 As Integer = 1
    Dim RC3 As Integer = 1
    Dim RC4 As Integer = 1
    Dim RC5 As Integer = 1
    Dim RC6 As Integer = 1
    Dim RC7 As Integer = 1
    Dim RC8 As Integer = 1
    Dim RC9 As Integer = 1
    Dim HzArea As Double
    Dim VtArea As Double
    Dim SearchAreaHz As Double
    Dim SearchAreaVt As Double

    Enum sent As Integer
        SetStation
        SearchTarget
        FineAdjust
        DoMeas
        GetCoordinate
        GetSimpleMeas
        SetHeight
        SetOrientation
        MakePositioning
        DoMeasClear
    End Enum



    Private Sub btnSMeasBack_Click(sender As Object, e As EventArgs) Handles btnSMeasBack.Click
        Try
          
            If btnSMeasBack.Enabled = False Then
                MessageBox.Show(BackNotice.Text, "请先停止测量,再进行后视定向操作")
            ElseIf bgwIsBusy = True Or isbusy = True Then

                MessageBox.Show(BackNotice.Text, "正在执行测量，请等待测量完成再执行其他操作")
            Else
                bgwIsBusy = True
                '   MessageBox.Show(BackNotice.Text, "开始测量后视棱镜")

                sentid = sent.SetStation
                BackgroundWorker.RunWorkerAsync()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

   

    Private Sub BackgroundWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker.DoWork
        Try
            SearchAreaHz = 0.5
            SearchAreaVt = 0.5
            HzArea = 0.07
            VtArea = 0.07

            SX = Station.XYZX
            SY = Station.XYZY
            SZ = Station.XYZZ
            SH = Station.XYZH

            SXY(0) = SX
            SXY(1) = SY

            If SetStation.btnSStationBack.Enabled = True Then
                BX = Station.BackX
                BY = Station.BackY
                BZ = Station.BackZ
                BH = Station.BackH
                BXY(0) = BX
                BXY(1) = BY
            ElseIf SetStation.btnAz.Enabled = True Then
                Az = Station.AzAz
                H0 = Station.AzH0
            End If

            Calculate.CalculateAzimuth12(SXY, BXY, Orientation)

            Select Case sentid
                Case sent.FineAdjust
                    isbusy = AUT_FineAdjust2(HzArea, VtArea, RC)
                Case sent.DoMeas
                    isbusy = TMC_DoMeas(RC1)
                Case sent.GetCoordinate
                    isbusy = TMC_GetCoordinate(sPrismBackY, sPrismBackX, sPrismBackZ, RC2)
                Case sent.GetSimpleMeas
                    isbusy = TMC_GetSimpleMeas(sPrismBackHz, sPrismBackVt, sPrismBackSlopeDistance, RC3)
                Case sent.SetStation
                    isbusy = TMC_SetStation(SY, SX, SZ, SH, RC4)
                Case sent.SetHeight
                    If SetStation.btnSStationBack.Enabled = True Then
                        isbusy = TMC_SetHeight(BH, RC5)
                    ElseIf SetStation.btnAz.Enabled = True Then
                        isbusy = TMC_SetHeight(H0, RC5)
                    End If
                Case sent.SetOrientation
                    If SetStation.btnSStationBack.Enabled = True Then
                        isbusy = TMC_SetOrientation(Orientation, RC6)
                    ElseIf SetStation.btnAz.Enabled = True Then
                        isbusy = TMC_SetOrientation(Az, RC6)
                    End If
                Case sent.SearchTarget
                    isbusy = AUT_Search1(SearchAreaHz, SearchAreaVt, RC7)
                Case sent.DoMeasClear
                    isbusy = TMC_DoMeasClear(RC9)
            End Select


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub BackgroundWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker.RunWorkerCompleted
        Try


            Select Case sentid

                Case sent.SetStation
                    If RC4 = 0 Then
                        '   MessageBox.Show(BackNotice.Text, "设置全站仪坐标")
                        sentid = sent.SetHeight
                        BackgroundWorker.RunWorkerAsync()
                    Else
                        bgwIsBusy = False
                        MessageBox.Show(BackNotice.Text, "设置全站仪坐标错误 " & ":" & RC4)
                        'If RC4 = 1 Then
                        '    testbusy = 0
                        'End If
                    End If

                Case sent.SetHeight
                    If RC5 = 0 Then
                        '    MessageBox.Show(BackNotice.Text, "设置棱镜高 ")
                        sentid = sent.DoMeasClear
                        ' sentid = sent.SearchTarget
                        ' sentid = sent.FineAdjust
                        BackgroundWorker.RunWorkerAsync()
                    Else
                        bgwIsBusy = False
                        MessageBox.Show(BackNotice.Text, "设置棱镜高错误 " & ":" & RC5)
                        'If RC5 = 1 Then
                        '    testbusy = 0
                        'End If
                    End If


                Case sent.DoMeasClear
                    If RC9 = 0 Then
                        '    MessageBox.Show(BackNotice.Text, "设置棱镜高 ")
                        sentid = sent.SetOrientation
                        'sentid = sent.SearchTarget
                        ' sentid = sent.FineAdjust
                        BackgroundWorker.RunWorkerAsync()
                    Else
                        bgwIsBusy = False
                        MessageBox.Show(BackNotice.Text, "清楚数据错误 " & ":" & RC9)
                        'If RC5 = 1 Then
                        '    testbusy = 0
                        'End If
                    End If


                    'Case sent.SearchTarget
                    '    If RC7 = 0 Then
                    '        '   MessageBox.Show(BackNotice.Text, "寻找目标成功 ")
                    '        sentid = sent.FineAdjust
                    '        BackgroundWorker.RunWorkerAsync()
                    '    Else
                    '        bgwIsBusy = False
                    '        MessageBox.Show(BackNotice.Text, "寻找目标失败" & ":" & RC7)
                    '        'If RC7 = 1 Then
                    '        '    testbusy = 0
                    '        'End If
                    '    End If



                    'Case sent.FineAdjust
                    '    If RC = 0 Then
                    '        '     MessageBox.Show(BackNotice.Text, "照准后视棱镜")
                    '        sentid = sent.SetOrientation
                    '        BackgroundWorker.RunWorkerAsync()

                    '    Else
                    '        bgwIsBusy = False
                    '        MessageBox.Show(BackNotice.Text, "后视棱镜照准错误" & ":" & RC)
                    '        'If RC = 1 Then
                    '        '    testbusy = 0
                    '        'End If
                    '    End If


                    'Case sent.SetOrientation
                    '    If RC6 = 0 Then
                    '        '  MessageBox.Show(BackNotice.Text, "设置全站仪方位角")
                    '        sentid = sent.DoMeas
                    '        BackgroundWorker.RunWorkerAsync()
                    '    Else
                    '        bgwIsBusy = False
                    '        MessageBox.Show(BackNotice.Text, "设置全站仪方位角错误 " & ":" & RC6)
                    '        'If RC6 = 1 Then
                    '        '    testbusy = 0
                    '        'End If
                    '    End If

                Case sent.SetOrientation
                    If RC6 = 0 Then
                        '  MessageBox.Show(BackNotice.Text, "设置全站仪方位角")
                        sentid = sent.FineAdjust
                        BackgroundWorker.RunWorkerAsync()
                    Else
                        bgwIsBusy = False
                        MessageBox.Show(BackNotice.Text, "设置全站仪方位角错误 " & ":" & RC6)
                        'If RC6 = 1 Then
                        '    testbusy = 0
                        'End If
                    End If

                Case sent.FineAdjust
                    If RC = 0 Then
                        '     MessageBox.Show(BackNotice.Text, "照准后视棱镜")
                        ' sentid = sent.SetOrientation
                        sentid = sent.DoMeas
                        BackgroundWorker.RunWorkerAsync()

                    Else
                        bgwIsBusy = False
                        MessageBox.Show(BackNotice.Text, "后视棱镜照准错误" & ":" & RC)
                        'If RC = 1 Then
                        '    testbusy = 0
                        'End If
                    End If

                Case sent.DoMeas
                    If RC1 = 0 Then
                        '   MessageBox.Show(BackNotice.Text, "执行测量")
                        sentid = sent.GetCoordinate
                        BackgroundWorker.RunWorkerAsync()
                    Else
                        bgwIsBusy = False
                        MessageBox.Show(BackNotice.Text, "后视棱镜执行测量错误" & ":" & RC1)
                        'If RC1 = 1 Then
                        '    testbusy = 0
                        'End If
                    End If
                Case sent.GetCoordinate
                    If RC2 = 0 Then
                        '   MessageBox.Show(BackNotice.Text, "获取后视坐标")
                        sentid = sent.GetSimpleMeas
                        BackgroundWorker.RunWorkerAsync()
                    Else
                        bgwIsBusy = False
                        MessageBox.Show(BackNotice.Text, "后视棱镜获取坐标错误" & ":" & RC2)
                        'If RC2 = 1 Then
                        '    testbusy = 0
                        'End If
                    End If

                Case sent.GetSimpleMeas
                    If RC3 = 0 Then
                        '  MessageBox.Show(BackNotice.Text, "完成测量")
                        bgwIsBusy = False


                        BackMeasX = Math.Round(sPrismBackX, 3)
                        BackMeasY = Math.Round(sPrismBackY, 3)
                        BackMeasZ = Math.Round(sPrismBackZ, 3)
                        BackMeasHz = Math.Round(sPrismBackHz * 180 / Math.PI, 3)
                        BackMeasVt = Math.Round(sPrismBackVt * 180 / Math.PI, 3)
                        BackMeasDistance = Math.Round(sPrismBackSlopeDistance, 3)


                        txtSBackMeasX.Text = BackMeasX
                        txtSBackMeasY.Text = BackMeasY
                        txtSBackMeasZ.Text = BackMeasZ
                        txtSMeasHz.Text = BackMeasHz
                        txtSMeasVt.Text = BackMeasVt
                        txtSMeasDistance.Text = BackMeasDistance

                       
                        If SetStation.btnSStationBack.Enabled = True Then

                            BackdeltaX = Math.Round((BX - sPrismBackX) * 1000, 0)
                            BackdeltaY = Math.Round((BY - sPrismBackY) * 1000, 0)
                            BackdeltaZ = Math.Round((BZ - sPrismBackZ) * 1000, 0)

                            If Math.Abs(BackdeltaX) > 10 Or Math.Abs(BackdeltaY) > 10 Or Math.Abs(BackdeltaZ) > 10 Then
                                MessageBox.Show(BackNotice.Text, "后视超限,请检查后重新设置")
                            End If

                            If BackGapDistance > 0.025 Then
                                MessageBox.Show(BackNotice.Text, "平距差超出了限差0.025m，请重新设置")
                            End If
                            DesignDistance = Math.Sqrt((SX - BX) ^ 2 + (SY - BY) ^ 2 + (SZ + SH - BZ - BH) ^ 2)
                            BackDesignDistance = Math.Round(DesignDistance, 3)
                            BackGapDistance = Math.Round(DesignDistance - sPrismBackSlopeDistance, 3)

                        ElseIf SetStation.btnAz.Enabled = True Then
                            BackDesignDistance = "null"
                            BackGapDistance = "null"
                            If Math.Abs(sPrismBackHz - Az) > 0.05 Then
                                MessageBox.Show(BackNotice.Text, "方位角与测量值差值太大，请重新设置")
                            End If
                        End If

                        txtSBackdeltaX.Text = BackdeltaX
                        txtSBackdeltaY.Text = BackdeltaY
                        txtSBackdeltaZ.Text = BackdeltaZ
                        txtSDesignDistance.Text = BackDesignDistance
                        txtSGapDistance.Text = BackGapDistance
                    Else
                        bgwIsBusy = False
                        MessageBox.Show(BackNotice.Text, "后视棱镜获取角度距离错误" & ":" & RC3)
                        'If RC3 = 1 Then
                        '    testbusy = 0
                        'End If
                    End If

            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSSaveBack_Click(sender As Object, e As EventArgs) Handles btnSSaveBack.Click
        Try
            'If Math.Abs(CInt(SBackDeltaX)) > Parameter.BackCheckOffset Or Math.Abs(CInt(SBackDeltaY)) > Parameter.BackCheckOffset Or Math.Abs(CInt(SBackDeltaZ)) > Parameter.BackCheckOffset Then
            'MessageBox.Show(BackNotice.Text, "后视超限,请检查后重新设置")

            'Else

            Station.BackMeasX = BackMeasX
            Station.BackMeasY = BackMeasY
            Station.BackMeasZ = BackMeasZ

            Station.BackDeltaX = BackdeltaX
            Station.BackDeltaY = BackdeltaY
            Station.BackDeltaZ = BackdeltaZ

            Station.BackMeasHz = BackMeasHz
            Station.BackMeasVt = BackMeasVt
            Station.BackSlopeDistance = BackMeasDistance

            Station.BackDesignedDistance = BackDesignDistance
            Station.BackDistanceOffset = backGapDistance
            
         
            Dim BackDirectional(8) As String
            BackDirectional(0) = Now
            BackDirectional(1) = BackMeasX
            BackDirectional(2) = BackMeasY
            BackDirectional(3) = BackMeasZ
            BackDirectional(4) = BackMeasHz
            BackDirectional(5) = BackMeasVt
            BackDirectional(6) = BackMeasDistance
            BackDirectional(7) = BackDesignDistance
            BackDirectional(8) = 0

            Dim BackDirectionalDelta(8) As String
            BackDirectionalDelta(0) = Now
            BackDirectionalDelta(1) = BackdeltaX
            BackDirectionalDelta(2) = BackdeltaY
            BackDirectionalDelta(3) = BackdeltaZ
            BackDirectionalDelta(4) = "null"
            BackDirectionalDelta(5) = "null"
            BackDirectionalDelta(6) = BackGapDistance
            BackDirectionalDelta(7) = "null"
            BackDirectionalDelta(8) = 1

            'DataAccess.InitializeAccess(Project.StartPath)
            'DataAccess.Open()
            DataAccess.InsertAccess("BackDirectional", ClassEmunStructure.strBackDirectional, BackDirectional)
            DataAccess.InsertAccess("BackDirectional", ClassEmunStructure.strBackDirectional, BackDirectionalDelta)
            'DataAccess.Close()

            MessageBox.Show(BackNotice.Text, "后视数据保存成功")
            Me.Hide()
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            isbusy = TMC_DoMeasstop(RC8)
            If RC8 = 0 Then
                btnSMeasBack.Enabled = True
                'isbusy = False
                bgwIsBusy = False

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Orientation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Left = 300 '左
        Me.Top = 200 '上
        Me.Width = 700 '宽
        Me.Height = 500 '高
    End Sub

   
End Class