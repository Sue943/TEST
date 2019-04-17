

Imports System.Net.Sockets
Imports System.Net
Imports System.Text
Imports System.Threading
Imports System.Data.OleDb
Imports System.Math








Module Module1
    'Public enumStructure As New ClassEmunStructure1
    'Public AccessStation As New DataAccess1
    Public Service As New DataWebReference.MeasWebService
    Public DataAccess As New DataAccess1
    Public Project As New XMLProject
    Public ClassEmunStructure As New ClassEmunStructure1
    Public Calculate As New Calculate1
    Public Station As New XMLStation
    Public Parameter As New XMLParameter
    Public isbusy As Boolean = False
    '全站仪工作状态
    Public bgwIsBusy As Boolean = False
    '后台运行状态
    ' Public testbusy As Integer = 0  '全站仪连接成功标志，1成功，0失败

    ' Public s As Socket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
    Public s As New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)

    Public localEndPoint As New IPEndPoint(IPAddress.Parse("172.20.10.8"), 1212)   '设置IP和端口

    'Public t As Thread
    ' Public rc As Integer

    ' Public RC As Integer = 0

    Public SX As Double
    Public SY As Double
    Public SZ As Double
    Public SH As Double
    Public BX As Double
    Public BY As Double
    Public BZ As Double
    Public BH As Double


    Public Sub InitializeSystem()
        '初始化系统数据


        DataAccess.InitializeAccess(Project.StartPath)
        DataAccess.Open()

        Station.StartupPath = Project.StartPath
        Parameter.StartupPath = Project.StartPath


        Station.Load()
        Parameter.Load()
    End Sub

    'Public Sub InitDataCollect()
    '    Dim myDevice As New DeviceInformation
    '    Dim instantAiCtrl1 As New InstantAiCtrl
    '    If Not instantAiCtrl1.Initialized Then
    '        MessageBox.Show("Please select a device in control property!")
    '    End If


    '    myDevice.Description = "USB-4716,BID#0"        '板卡名称
    '    myDevice.DeviceMode = AccessMode.ModeWrite      '板卡模式
    '    myDevice.DeviceNumber = 1                       '板卡编号
    '    myDevice.ModuleIndex = 0

    '    instantAiCtrl1.SelectedDevice = myDevice




    '    instantAiCtrl1.Channels





    'End Sub



    'Public Sub WaitData()
    '    s = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp) '使用TCP协议
    '    Dim localEndPoint As New IPEndPoint(IPAddress.Parse("127.0.0.1"), 1024)  '指定IP和Port
    '    s.Bind(localEndPoint)        '绑定到该Socket
    '    s.Listen(100)     '侦听，最多接受100个连接
    '    While (True)
    '        Dim bytes(1024) As Byte   '用来存储接收到的字节
    '        Dim ss As Socket = s.Accept()  '若接收到,则创建一个新的Socket与之连接
    '        ss.Receive(bytes)    '接收数据，若用ss.send(Byte()),则发送数据
    '        'ListBox1.Items.Insert(0, Encoding.Unicode.GetString(bytes)) '将其插入到列表框的第一项之前
    '        '若使用Encoding.ASCII.GetString(bytes),则接收到的中文字符不能正常显示
    '    End While
    'End Sub

    Public Function TMC_ComTest(ByRef Name As String, ByRef rc As Integer) As Boolean   '测试连接
        Try
            If isbusy = True Then
                Return True
            End If

            Dim a As String
            Dim returnvalue As String()
            Dim bytes(1024) As Byte
            'Static s = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)   '构建socket对象
            s.ReceiveTimeout = 5000
            'Dim localEndPoint As New IPEndPoint(IPAddress.Parse("172.20.10.8"), 1212)   '设置IP和端口
            s.Connect(localEndPoint)   '建立连接
            s.Send(Encoding.ASCII.GetBytes("%R1Q,5004:" & vbCrLf))    '连接
            s.Receive(bytes)    '接收数据
            a = Encoding.ASCII.GetString(bytes)
            returnvalue = a.Split(":"c, ","c)
            rc = returnvalue(3)
            If rc = 0 Then
                Name = returnvalue(4)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False

    End Function


    Public Function TMC_InstrumentName(ByRef SerialNo As String, ByRef rc As Integer) As Boolean      '获取仪器名

        Try
            If isbusy = True Then
                Return True
            End If

            Dim a As String
            Dim returnvalue As String()
            Dim bytes(1024) As Byte

            s.Send(Encoding.ASCII.GetBytes("%R1Q,5003:" & vbCrLf))    '仪器名字
            s.Receive(bytes)    '接收数据
            a = Encoding.ASCII.GetString(bytes)
            returnvalue = a.Split(":"c, ","c)
            rc = returnvalue(3)
            If rc = 0 Then
                SerialNo = returnvalue(4)
            End If
        Catch ex As Exception
        End Try
        Return False
    End Function


    Public Function AUT_ChangeFace(ByRef rc As Integer) As Boolean          '全站仪换面测量

        Try
            If isbusy = True Then
                Return True
            End If

            Dim a As String
            Dim returnvalue As String()
            Dim bytes(1024) As Byte

            s.Send(Encoding.ASCII.GetBytes("%R1Q,9028:" & vbCrLf))    '换面
            s.Receive(bytes)    '接收数据
            a = Encoding.ASCII.GetString(bytes)
            returnvalue = a.Split(":"c, ","c)
            rc = returnvalue(3)
        Catch ex As Exception
        End Try
        Return False


    End Function







    Public Function TMC_SetStation(ByVal e As Double, ByVal n As Double, ByVal h As Double, ByVal h0 As Double, ByRef rc As Integer) As Boolean      '设站
        Try
            If isbusy = True Then
                Return True
            End If

            Dim a As String
            Dim returnvalue As String()
            Dim bytes(1024) As Byte
            s.Send(Encoding.ASCII.GetBytes("%R1Q,2010:" & e & "," & n & "," & h & "," & h0 & vbCrLf))    '设站
            s.Receive(bytes)    '接收数据
            a = Encoding.ASCII.GetString(bytes)
            returnvalue = a.Split(":"c, ","c)
            rc = returnvalue(3)
        Catch ex As Exception
        End Try
        Return False
    End Function

    Public Function TMC_GetCoordinate(ByRef E As Double, ByRef N As Double, ByRef H As Double, ByRef rc As Integer) As Boolean     '获取坐标
        Try
            If isbusy = True Then
                Return True
            End If

            Dim a As String
            Dim returnvalue As String()
            Dim bytes(1024) As Byte

            s.Send(Encoding.ASCII.GetBytes("%R1Q,2082:2000" & vbCrLf))    '获得坐标
            '  System.Threading.Thread.Sleep(1000)
            s.Receive(bytes)    '接收数据
            a = Encoding.ASCII.GetString(bytes)
            returnvalue = a.Split(":"c, ","c)
            rc = returnvalue(3)

            If rc = 0 Then
                E = returnvalue(4)
                N = returnvalue(5)
                H = returnvalue(6)
            End If
        Catch ex As Exception
        End Try
        Return False

    End Function

    Public Function TMC_GetSimpleMeas(ByRef Hz As Double, ByRef Vt As Double, ByRef SlopeDistance As Double, ByRef rc As Integer) As Boolean      '简单测量

        Try
            If isbusy = True Then
                Return True
            End If

            Dim a As String
            Dim returnvalue As String()
            Dim bytes(1024) As Byte

            s.Send(Encoding.ASCII.GetBytes("%R1Q,2108:2000" & vbCrLf))   '简单测量
            s.Receive(bytes)    '接收数据
            a = Encoding.ASCII.GetString(bytes)
            returnvalue = a.Split(":"c, ","c)
            rc = returnvalue(3)
            If rc = 0 Then
                Hz = returnvalue(4)
                Vt = returnvalue(5)
                SlopeDistance = returnvalue(6)
            End If
        Catch ex As Exception
        End Try
        Return False
    End Function

    Public Function AUT_SetFineAdjustMode(ByRef rc As Integer) As Boolean       '设置精确定位模式

        Try
            If isbusy = True Then
                Return True
            End If

            Dim a As String
            Dim returnvalue As String()
            Dim bytes(1024) As Byte
            s.Send(Encoding.ASCII.GetBytes("%R1Q,9037:1" & vbCrLf))    '精确定位

            s.Receive(bytes)    '接收数据
            a = Encoding.ASCII.GetString(bytes)
            returnvalue = a.Split(":"c, ","c)
            rc = returnvalue(3)

        Catch ex As Exception
        End Try
        Return False

    End Function

    Public Function AUT_GetFineAdjustMode(ByRef AdjMode As Integer, ByRef rc As Integer) As Boolean      '获取精确定位模式

        Try
            If isbusy = True Then
                Return True
            End If

            Dim a As String
            Dim returnvalue As String()
            Dim bytes(1024) As Byte
            s.Send(Encoding.ASCII.GetBytes("%R1Q,9030:" & vbCrLf))    '精确定位

            s.Receive(bytes)    '接收数据
            a = Encoding.ASCII.GetString(bytes)

            returnvalue = a.Split(":"c, ","c)
            rc = returnvalue(3)
            If rc = 0 Then
                AdjMode = returnvalue(4)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False

    End Function

    Public Function AUT_FineAdjust(ByVal Hz As Double, ByVal V As Double, ByRef rc As Integer) As Boolean        '精确定位

        Try
            If isbusy = True Then
                Return True
            End If

            Dim a As String
            Dim returnvalue As String()
            Dim bytes(1024) As Byte
            s.Send(Encoding.ASCII.GetBytes("%R1Q,9037:" & Hz & "," & V & vbCrLf))    '精确定位
            '  System.Threading.Thread.Sleep(1000)
            s.Receive(bytes)    '接收数据
            a = Encoding.ASCII.GetString(bytes)
            returnvalue = a.Split(":"c, ","c)
            rc = returnvalue(3)

        Catch ex As Exception
        End Try
        Return False

    End Function

    Public Function AUT_FineAdjust1(ByVal Hz As Double, ByVal V As Double, ByRef rc As Integer) As Boolean


        If isbusy = True Then
            Return True
        End If

        Dim a As String
        Dim returnvalue As String()
        Dim bytes(1024) As Byte
        s.Send(Encoding.ASCII.GetBytes("%R1Q,9037:" & Hz & "," & V & vbCrLf))    '精确定位
        System.Threading.Thread.Sleep(5000)
        s.Receive(bytes)    '接收数据
        a = Encoding.ASCII.GetString(bytes)
        returnvalue = a.Split(":"c, ","c)
        rc = returnvalue(3)

        Return False

    End Function

    Public Function AUT_FineAdjust2(ByVal Hz As Double, ByVal V As Double, ByRef rc As Integer) As Boolean


        If isbusy = True Then
            Return True
        End If

        Dim a As String
        Dim returnvalue As String()
        Dim bytes(1024) As Byte
        s.Send(Encoding.ASCII.GetBytes("%R1Q,9037:" & Hz & "," & V & vbCrLf))    '精确定位
        System.Threading.Thread.Sleep(20000)
        s.Receive(bytes)    '接收数据
        a = Encoding.ASCII.GetString(bytes)
        returnvalue = a.Split(":"c, ","c)
        rc = returnvalue(3)

        Return False

    End Function





    Public Function AUT_Search1(ByVal HzArea As Double, ByVal VArea As Double, ByRef rc As Integer) As Boolean     '自动寻找目标


        If isbusy = True Then
            Return True
        End If

        Dim a As String
        Dim Timeout As Integer = 0
        Dim returnvalue As String()
        Dim bytes(1024) As Byte

        Try
            s.Send(Encoding.ASCII.GetBytes("%R1Q,9029:" & HzArea & "," & VArea & "," & vbCrLf))   '自动寻找目标

            For I As Integer = 1 To 10

                System.Threading.Thread.Sleep(5000)

                If s.Poll(100, SelectMode.SelectRead) Then
                    s.Receive(bytes)    '接收数据
                    a = Encoding.ASCII.GetString(bytes)
                    returnvalue = a.Split(":"c, ","c)
                    rc = returnvalue(3)

                    Exit For

                End If
            Next

        Catch ex As SocketException
            MessageBox.Show(ex.Message)
        End Try
        Return False

    End Function


    'Public Function AUT_Search1(ByVal HzArea As Double, ByVal VArea As Double, ByRef rc As Integer) As Boolean



    '    If isbusy = True Then
    '        Return True
    '    End If

    '    Dim a As String
    '    Dim Timeout As Integer = 0
    '    Dim returnvalue As String()
    '    Dim bytes(1024) As Byte
    '    Dim returncode As Integer = 1
    '    Try
    '        For t = 1 To 5

    '            s.Send(Encoding.ASCII.GetBytes("%R1Q,9029:" & HzArea & "," & VArea & "," & vbCrLf))   '自动寻找目标

    '            For i = 1 To 10

    '                System.Threading.Thread.Sleep(5000)

    '                If s.Poll(100, SelectMode.SelectRead) Then
    '                    s.Receive(bytes)    '接收数据
    '                    a = Encoding.ASCII.GetString(bytes)
    '                    returnvalue = a.Split(":"c, ","c)
    '                    MessageBox.Show(a)
    '                    rc = returnvalue(3)
    '                    Exit For
    '                End If
    '            Next

    '            If rc = 8710 Then
    '                HzArea += 0.1
    '                VArea += 0.1
    '            Else
    '                Exit For
    '            End If
    '        Next
    '    Catch ex As SocketException
    '        MessageBox.Show(ex.Message)
    '    End Try
    '    Return False

    'End Function


    Public Function TMC_DoMeas(ByRef rc As Integer) As Boolean       '执行测量


        Try
            If isbusy = True Then
                Return True
            End If

            Dim a As String
            Dim returnvalue As String()
            Dim bytes(1024) As Byte

            s.Send(Encoding.ASCII.GetBytes("%R1Q,2008:1" & vbCrLf))    '执行测量
            s.Receive(bytes)    '接收数据
            a = Encoding.ASCII.GetString(bytes)
            returnvalue = a.Split(":"c, ","c)
            rc = returnvalue(3)

        Catch ex As Exception
        End Try
        Return False

    End Function


    Public Function MOT_StopControler(ByRef rc As Integer) As Boolean


        Try

            Dim a As String
            Dim returnvalue As String()
            Dim bytes(1024) As Byte

            s.Send(Encoding.ASCII.GetBytes("%R1Q,6002:1" & vbCrLf))    '停止控制电机
            s.Receive(bytes)    '接收数据
            a = Encoding.ASCII.GetString(bytes)
            returnvalue = a.Split(":"c, ","c)
            rc = returnvalue(3)

        Catch ex As Exception
        End Try
        Return False

    End Function




    Public Function TMC_DoMeasstop(ByRef rc As Integer) As Boolean


        Try

            Dim a As String
            Dim returnvalue As String()
            Dim bytes(1024) As Byte

            s.Send(Encoding.ASCII.GetBytes("%R1Q,2008:0" & vbCrLf))    '停止测量
            s.Receive(bytes)    '接收数据
            a = Encoding.ASCII.GetString(bytes)
            returnvalue = a.Split(":"c, ","c)
            rc = returnvalue(3)

        Catch ex As Exception
        End Try
        Return False

    End Function

    Public Function TMC_DoMeasClear(ByRef rc As Integer) As Boolean

        If isbusy = True Then
            Return True
        End If
        Dim a As String
        Dim returnvalue As String()
        Dim bytes(1024) As Byte

        s.Send(Encoding.ASCII.GetBytes("%R1Q,2008:3" & vbCrLf))    '定向前清除数据
        s.Receive(bytes)    '接收数据
        a = Encoding.ASCII.GetString(bytes)
        returnvalue = a.Split(":"c, ","c)
        rc = returnvalue(3)


        Return False

    End Function


    Public Function TMC_SetHeight(ByVal h0 As Double, ByRef rc As Integer) As Boolean

        Try
            If isbusy = True Then
                Return True
            End If

            Dim a As String
            Dim returnvalue As String()
            Dim bytes(1024) As Byte

            s.Send(Encoding.ASCII.GetBytes("%R1Q,2012:" & vbCrLf))    '设置棱镜高度
            s.Receive(bytes)    '接收数据
            a = Encoding.ASCII.GetString(bytes)
            returnvalue = a.Split(":"c, ","c)
            rc = returnvalue(3)
        Catch ex As Exception
        End Try
        Return False

    End Function

    Public Function TMC_SetOrientation(ByVal HzOrientation As Double, ByRef rc As Integer) As Boolean
        Try
            If isbusy = True Then
                Return True
            End If

            Dim a As String
            Dim returnvalue As String()
            Dim bytes(1024) As Byte

            s.Send(Encoding.ASCII.GetBytes("%R1Q,2113:" & HzOrientation & vbCrLf))    '设置后视定向
            s.Receive(bytes)    '接收数据
            a = Encoding.ASCII.GetString(bytes)
            returnvalue = a.Split(":"c, ","c)
            rc = returnvalue(3)
        Catch ex As Exception
        End Try

        Return False

    End Function


    Public Function BAP_SearchTarget(ByRef rc As Integer) As Boolean
        Try
            If isbusy = True Then
                Return True
            End If

            Dim a As String
            Dim returnvalue As String()
            Dim bytes(1024) As Byte

            s.Send(Encoding.ASCII.GetBytes("%R1Q,17020:" & vbCrLf))
            s.Receive(bytes)    '接收数据
            a = Encoding.ASCII.GetString(bytes)
            returnvalue = a.Split(":"c, ","c)
            rc = returnvalue(3)
        Catch ex As Exception
        End Try

        Return False

    End Function



    Public Function AUT_MakePositioning(ByVal Hz As Double, ByVal V As Double, ByRef rc As Integer) As Boolean     '定位目标
        Try
            If isbusy = True Then
                Return True
            End If

            Dim a As String
            Dim returnvalue As String()
            Dim bytes(1024) As Byte
            s.Send(Encoding.ASCII.GetBytes("%R1Q,9027:" & Hz & "," & V & vbCrLf))
            '  System.Threading.Thread.Sleep(1000)
            s.Receive(bytes)    '接收数据
            a = Encoding.ASCII.GetString(bytes)
            returnvalue = a.Split(":"c, ","c)
            rc = returnvalue(3)
        Catch ex As Exception
        End Try

        Return False

    End Function




    'Public Function ChoosePrism(ByVal Hz As Double, ByVal V As Double, ByVal HzArea As Double, ByVal VArea As Double, ByRef rc1 As Integer, ByRef rc2 As Integer) As Boolean
    '    Try
    '        For i As Integer = 1 To 10
    '            Hz += 0.005
    '            isbusy = AUT_MakePositioning1(Hz, V, rc1)
    '            If rc1 = 0 Then
    '                isbusy = AUT_FineAdjust1(HzArea, VArea, rc2)
    '                If rc2 = 0 Then
    '                    Exit For
    '                End If
    '            Else
    '                Exit For

    '            End If
    '        Next
    '    Catch ex As Exception
    '    End Try
    '    Return False
    'End Function







    Public Function CSV_CheckPower(ByRef Power As String, ByRef rc As Integer) As Boolean       '检查电量
        Try
            If isbusy = True Then
                Return True
            End If

            Dim a As String
            Dim returnvalue As String()
            Dim bytes(1024) As Byte

            s.Send(Encoding.ASCII.GetBytes("%R1Q,5039:" & vbCrLf))
            s.Receive(bytes)    '接收数据
            a = Encoding.ASCII.GetString(bytes)
            returnvalue = a.Split(":"c, ","c)
            rc = returnvalue(3)
            If rc = 0 Then
                Power = returnvalue(4)
            End If
        Catch ex As Exception
        End Try

        Return False

    End Function

    Public Function TMC_GetFullMeas(ByRef Hz As Double, ByRef Vt As Double, ByRef C As Double, ByRef L As Double, ByRef SlopeDistance As Double, ByRef rc As Integer) As Boolean
        Try

            If isbusy = True Then
                Return True
            End If
            Dim a As String
            Dim returnvalue As String()
            Dim bytes(1024) As Byte

            s.Send(Encoding.ASCII.GetBytes("%R1Q,2167:1500" & vbCrLf))
            s.Receive(bytes)    '接收数据
            a = Encoding.ASCII.GetString(bytes)
            returnvalue = a.Split(":"c, ","c)
            rc = returnvalue(3)
            If rc = 0 Then

                Hz = returnvalue(4)
                Vt = returnvalue(5)
                C = returnvalue(7)
                L = returnvalue(8)
                SlopeDistance = returnvalue(10)
            End If
        Catch ex As Exception
        End Try

        Return False
    End Function

    Public Function TMC_GetAngle(ByRef C As Double, ByRef L As Double, ByRef rc As Integer) As Boolean
        Try

            If isbusy = True Then
                Return True
            End If
            Dim a As String
            Dim returnvalue As String()
            Dim bytes(1024) As Byte

            s.Send(Encoding.ASCII.GetBytes("%R1Q,2003:1" & vbCrLf))
            s.Receive(bytes)    '接收数据
            a = Encoding.ASCII.GetString(bytes)
            returnvalue = a.Split(":"c, ","c)
            rc = returnvalue(3)
            If rc = 0 Then
                C = returnvalue(8)
                L = returnvalue(9)
            End If
        Catch ex As Exception
        End Try

        Return False
    End Function









    Public Function AUS_SetUserAtrState(ByVal OnOff As Long, ByRef rc As Integer) As Boolean         '设置ATR状态
        Try

            If isbusy = True Then
                Return True
            End If
            Dim a As String
            Dim returnvalue As String()
            Dim bytes(1024) As Byte

            s.Send(Encoding.ASCII.GetBytes("%R1Q,18005:" & OnOff & vbCrLf))
            s.Receive(bytes)    '接收数据
            a = Encoding.ASCII.GetString(bytes)
            returnvalue = a.Split(":"c, ","c)
            rc = returnvalue(3)
        Catch ex As Exception
        End Try

        Return False
    End Function




    'Public Function CenterPointCal(ByVal Arrb As Double(), ByVal Arrd As Double(), ByVal theta As Double, ByVal alpha As Double) As Double()    '棱镜坐标转换成线路中线坐标

    '    Dim ArrCen(2) As Double
    '    Try

    '        Dim Xb, Yb, Zb As Double
    '        Dim Xd, Yd, Zd As Double
    '        Dim Xbd, Ybd, Zbd As Double
    '        Dim BDM As Double
    '        Dim Xf1, Yf1, Zf1 As Double
    '        Dim Xr, Yr, Zr As Double
    '        Dim Xf, Yf, Zf As Double
    '        Dim AA, BB, CC As Double
    '        Dim Xt1, Yt1, Zt1, Ztm, Xt, Yt, Zt As Double

    '        Xb = Arrb(0)
    '        Yb = Arrb(1)
    '        Zb = Arrb(2)


    '        Xd = Arrd(0)
    '        Yd = Arrd(1)
    '        Zd = Arrd(2)


    '        Xbd = Xd - Xb
    '        Ybd = Yd - Yb
    '        Zbd = Zd - Zb
    '        BDM = Math.Sqrt(Xbd * Xbd + Ybd * Ybd + Zbd * Zbd)

    '        Xf1 = Xbd / BDM
    '        Yf1 = Ybd / BDM
    '        Zf1 = Zbd / BDM

    '        Xr = ((Sin(alpha) + Sin(theta) * Zf1) * Xf1 + Sqrt((Sin(alpha) + Sin(theta) * Zf1) ^ 2 * Xf1 ^ 2 - (Xf1 ^ 2 + Yf1 ^ 2) * ((Sin(alpha) + Sin(theta) * Zf1) ^ 2 - Yf1 ^ 2 * Cos(theta) ^ 2))) / (Xf1 ^ 2 + Yf1 ^ 2)

    '        Yr = ((Sin(alpha) + Sin(theta) * Zf1) * Yf1 - Sqrt((Sin(alpha) + Sin(theta) * Zf1) ^ 2 * Yf1 ^ 2 - (Xf1 ^ 2 + Yf1 ^ 2) * ((Sin(alpha) + Sin(theta) * Zf1) ^ 2 - Xf1 ^ 2 * Cos(theta) ^ 2))) / (Xf1 ^ 2 + Yf1 ^ 2)

    '        Zr = -Sin(theta)


    '        AA = (Yf1 * Zr - Yr * Zf1) ^ 2 * (-Zr ^ 2 - Xr ^ 2) + (-Zr ^ 2 - Yr ^ 2) * (Xf1 * Zr - Xr * Zf1) ^ 2 + 2 * Xr * Yr * (Yf1 * Zr - Yr * Zf1) * (Xf1 * Zr - Xr * Zf1)


    '        BB = -2 * Zr * Cos(alpha) * (Yf1 * Zr - Yr * Zf1) * (-Zr ^ 2 - Xr ^ 2) - 2 * Xr * Yr * Zr * Cos(alpha) * (Xf1 * Zr - Xr * Zf1)
    '        CC = Zr ^ 2 * (Cos(alpha)) ^ 2 * (-Zr ^ 2 - Xr ^ 2) + Zr ^ 2 * (Xf1 * Zr - Xr * Zf1) ^ 2

    '        Yf = -BB / (2 * AA)

    '        Xf = (Zr * Cos(alpha) - Yf * (Yf1 * Zr - Yr * Zf1)) / (Xf1 * Zr - Xr * Zf1)

    '        Zf = -(Xf * Xr + Yf * Yr) / Zr

    '        Xt1 = Yr * Zf - Zr * Yf
    '        Yt1 = Zr * Xf - Xr * Zf
    '        Zt1 = Xr * Yf - Yr * Xf

    '        Ztm = Sqrt(Xt1 ^ 2 + Yt1 ^ 2 + Zt1 ^ 2)
    '        Xt = Xt1 / Ztm
    '        Yt = Yt1 / Ztm
    '        Zt = Zt1 / Ztm

    '        Dim TransMatSG As Matrix
    '        TransMatSG = New Matrix(4, 4)
    '        TransMatSG.Item(1, 1) = Xr
    '        TransMatSG.Item(1, 2) = Xf
    '        TransMatSG.Item(1, 3) = Xt
    '        TransMatSG.Item(1, 4) = Xb
    '        TransMatSG.Item(2, 1) = Yr
    '        TransMatSG.Item(2, 2) = Yf
    '        TransMatSG.Item(2, 3) = Yt
    '        TransMatSG.Item(2, 4) = Yb
    '        TransMatSG.Item(3, 1) = Zr
    '        TransMatSG.Item(3, 2) = Zf
    '        TransMatSG.Item(3, 3) = Zt
    '        TransMatSG.Item(3, 4) = Zb
    '        TransMatSG.Item(4, 1) = 0
    '        TransMatSG.Item(4, 2) = 0
    '        TransMatSG.Item(4, 3) = 0
    '        TransMatSG.Item(4, 4) = 1


    '        Dim xyzMat As Matrix
    '        xyzMat = New Matrix(4, 1)
    '        xyzMat.Item(1, 1) = 0
    '        xyzMat.Item(2, 1) = 0
    '        xyzMat.Item(3, 1) = -500
    '        xyzMat.Item(4, 1) = 1

    '        Dim AMat As Matrix
    '        AMat = New Matrix(4, 1)
    '        AMat = TransMatSG * xyzMat

    '        ArrCen(0) = AMat.Item(1, 1)
    '        ArrCen(1) = AMat.Item(2, 1)
    '        ArrCen(2) = AMat.Item(3, 1)
    '    Catch ex As Exception
    '        Return Nothing
    '    End Try
    '    Return ArrCen
    'End Function








End Module
