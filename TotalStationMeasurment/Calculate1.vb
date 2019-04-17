Imports System.Math
Imports System.Data.OleDb

'Imports TunnelGuide.ClassEmunStructure

Public Class Calculate1




    '计算从xyz1,到xyz2的方位角
    '输入：棱镜1，棱镜2
    '输出：方位角,弧度
    '计算成功返回true,失败返回false
    Function CalculateAzimuth12(ByVal XYZ1() As Double, ByVal XYZ2() As Double, ByRef Azimuth12 As Double) As Boolean

        Try



            Dim dX12 As Double
            Dim dY12 As Double
            Dim oAzimuth As Double

            dX12 = XYZ2(0) - XYZ1(0)
            dY12 = XYZ2(1) - XYZ1(1)
            If Abs(dX12) < 1.0E-300 Then
                dX12 = 1.0E-300
            End If
            oAzimuth = Atan(dY12 / dX12)
            If dX12 > 0 And dY12 > 0 Then
                Azimuth12 = oAzimuth
                CalculateAzimuth12 = True
            ElseIf dX12 < 0 And dY12 > 0 Then
                Azimuth12 = oAzimuth + Math.PI
                CalculateAzimuth12 = True
            ElseIf dX12 < 0 And dY12 <= 0 Then
                Azimuth12 = oAzimuth + Math.PI
                CalculateAzimuth12 = True
            ElseIf dX12 > 0 And dY12 <= 0 Then
                Azimuth12 = oAzimuth + Math.PI * 2
                CalculateAzimuth12 = True
            ElseIf dX12 = 0 Then
                CalculateAzimuth12 = False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function


    '棱镜坐标转换成线路中线坐标
    'alpha 是曲线线路弦切角的一半
    'theta 是梁的横滚角
    'return 线路中线坐标
    Public Function CenterPointCal(ByVal Arrb As Double(), ByVal Arrd As Double(), ByVal theta As Double, ByVal alpha As Double) As Double()

        Dim ArrCen(2) As Double
        Try

            Dim Xb, Yb, Zb As Double
            Dim Xd, Yd, Zd As Double
            Dim Xbd, Ybd, Zbd As Double
            Dim BDM As Double
            Dim Xf1, Yf1, Zf1 As Double
            Dim Xr, Yr, Zr As Double
            Dim Xf, Yf, Zf As Double
            Dim AA, BB, CC As Double
            Dim Xt1, Yt1, Zt1, Ztm, Xt, Yt, Zt As Double

            Xb = Arrb(0)      '棱镜b点坐标
            Yb = Arrb(1)
            Zb = Arrb(2)


            Xd = Arrd(0)    '棱镜d点坐标
            Yd = Arrd(1)
            Zd = Arrd(2)


            Xbd = Xd - Xb
            Ybd = Yd - Yb
            Zbd = Zd - Zb
            BDM = Math.Sqrt(Xbd * Xbd + Ybd * Ybd + Zbd * Zbd)

            Xf1 = Xbd / BDM
            Yf1 = Ybd / BDM
            Zf1 = Zbd / BDM

            Xr = ((Sin(alpha) + Sin(theta) * Zf1) * Xf1 + Sqrt((Sin(alpha) + Sin(theta) * Zf1) ^ 2 * Xf1 ^ 2 - (Xf1 ^ 2 + Yf1 ^ 2) * ((Sin(alpha) + Sin(theta) * Zf1) ^ 2 - Yf1 ^ 2 * Cos(theta) ^ 2))) / (Xf1 ^ 2 + Yf1 ^ 2)

            Yr = ((Sin(alpha) + Sin(theta) * Zf1) * Yf1 - Sqrt((Sin(alpha) + Sin(theta) * Zf1) ^ 2 * Yf1 ^ 2 - (Xf1 ^ 2 + Yf1 ^ 2) * ((Sin(alpha) + Sin(theta) * Zf1) ^ 2 - Xf1 ^ 2 * Cos(theta) ^ 2))) / (Xf1 ^ 2 + Yf1 ^ 2)

            Zr = -Sin(theta)


            AA = (Yf1 * Zr - Yr * Zf1) ^ 2 * (-Zr ^ 2 - Xr ^ 2) + (-Zr ^ 2 - Yr ^ 2) * (Xf1 * Zr - Xr * Zf1) ^ 2 + 2 * Xr * Yr * (Yf1 * Zr - Yr * Zf1) * (Xf1 * Zr - Xr * Zf1)


            BB = -2 * Zr * Cos(alpha) * (Yf1 * Zr - Yr * Zf1) * (-Zr ^ 2 - Xr ^ 2) - 2 * Xr * Yr * Zr * Cos(alpha) * (Xf1 * Zr - Xr * Zf1)
            CC = Zr ^ 2 * (Cos(alpha)) ^ 2 * (-Zr ^ 2 - Xr ^ 2) + Zr ^ 2 * (Xf1 * Zr - Xr * Zf1) ^ 2

            Yf = -BB / (2 * AA)

            Xf = (Zr * Cos(alpha) - Yf * (Yf1 * Zr - Yr * Zf1)) / (Xf1 * Zr - Xr * Zf1)

            Zf = -(Xf * Xr + Yf * Yr) / Zr

            Xt1 = Yr * Zf - Zr * Yf
            Yt1 = Zr * Xf - Xr * Zf
            Zt1 = Xr * Yf - Yr * Xf

            Ztm = Sqrt(Xt1 ^ 2 + Yt1 ^ 2 + Zt1 ^ 2)
            Xt = Xt1 / Ztm
            Yt = Yt1 / Ztm
            Zt = Zt1 / Ztm

            Dim TransMatSG As Matrix
            TransMatSG = New Matrix(4, 4)
            TransMatSG.Item(1, 1) = Xr
            TransMatSG.Item(1, 2) = Xf
            TransMatSG.Item(1, 3) = Xt
            TransMatSG.Item(1, 4) = Xb
            TransMatSG.Item(2, 1) = Yr
            TransMatSG.Item(2, 2) = Yf
            TransMatSG.Item(2, 3) = Yt
            TransMatSG.Item(2, 4) = Yb
            TransMatSG.Item(3, 1) = Zr
            TransMatSG.Item(3, 2) = Zf
            TransMatSG.Item(3, 3) = Zt
            TransMatSG.Item(3, 4) = Zb
            TransMatSG.Item(4, 1) = 0
            TransMatSG.Item(4, 2) = 0
            TransMatSG.Item(4, 3) = 0
            TransMatSG.Item(4, 4) = 1


            Dim xyzMat As Matrix
            xyzMat = New Matrix(4, 1)
            xyzMat.Item(1, 1) = 0
            xyzMat.Item(2, 1) = 0
            xyzMat.Item(3, 1) = -500
            xyzMat.Item(4, 1) = 1

            Dim AMat As Matrix
            AMat = New Matrix(4, 1)
            AMat = TransMatSG * xyzMat

            ArrCen(0) = AMat.Item(1, 1)               '棱镜b点下的线路中线坐标
            ArrCen(1) = AMat.Item(2, 1)
            ArrCen(2) = AMat.Item(3, 1)
        Catch ex As Exception
            Return Nothing
        End Try
        Return ArrCen
    End Function

  


End Class
