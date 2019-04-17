Public Class ClassEmunStructure1


#Region "棱镜"
    Public ReadOnly Property strPrismMeas() As String()
        Get
            Return [Enum].GetNames(GetType(PrismMeas))
        End Get
    End Property

    Enum PrismMeas
        MeasTime
        P1X
        P1Y
        P1Z
        P1Hz
        P1Vt
        P1SD
        P2X
        P2Y
        P2Z
        P2Hz
        P2Vt
        P2SD
        P3X
        P3Y
        P3Z
        P3Hz
        P3Vt
        P3SD
        P4X
        P4Y
        P4Z
        P4Hz
        P4Vt
        P4SD
        P5X
        P5Y
        P5Z
        P5Hz
        P5Vt
        P5SD
        P6X
        P6Y
        P6Z
        P6Hz
        P6Vt
        P6SD
    End Enum

    Public ReadOnly Property strPrismCal() As String()
        Get
            Return [Enum].GetNames(GetType(PrismCal))
        End Get
    End Property

    Enum PrismCal
        MeasTime
        P1X
        P1Y
        P1Z
        P2X
        P2Y
        P2Z
        P3X
        P3Y
        P3Z
        P4X
        P4Y
        P4Z
        P5X
        P5Y
        P5Z
        P6X
        P6Y
        P6Z
    End Enum

#End Region


#Region "梁端面错台"

    Public ReadOnly Property strSurfaceCal() As String()
        Get
            Return [Enum].GetNames(GetType(SurfaceCal))
        End Get
    End Property

    Enum SurfaceCal
        MeasTime
        FX
        FY
        FZ
        Angle1
        Angle2
        Angle3
    End Enum

#End Region


#Region "设站"

    Public ReadOnly Property strStation() As String()
        Get
            Return [Enum].GetNames(GetType(Station))
        End Get
    End Property
    Enum Station
        MeasTime
        Name
        X
        Y
        Z
        H
    End Enum




    'Public ReadOnly Property strStationChinese() As String()
    '    Get
    '        Dim Station(4) As String
    '        Station(0) = "时间TIME"
    '        Station(1) = "点号NAME"
    '        Station(2) = "X"
    '        Station(3) = "Y"
    '        Station(4) = "Z"
    '        Station(5) = "H"
    '        Return Station
    '    End Get
    'End Property
    Public ReadOnly Property strStationSet() As String()
        Get
            Return [Enum].GetNames(GetType(StationSet))
        End Get
    End Property
    Enum StationSet
        MeasTime
        Name
        X
        Y
        Z
        H
        SorB
        AngleName
        Az
        H0
    End Enum

#End Region


#Region "后视"

    Public ReadOnly Property strBackDirectional() As String()
        Get
            Return [Enum].GetNames(GetType(BackDirectional))
        End Get
    End Property
    Enum BackDirectional
        MeasTime
        X
        Y
        Z
        Hz
        Vt
        SlopeDistance
        DesignDistance
        SorB
    End Enum
#End Region



    'Public Event ReadSuccess(ByVal HeadX As Double, ByVal HeadY As Double, ByVal HeadZ As Double, ByVal TailX As Double, ByVal TailY As Double, ByVal TailZ As Double, _
    '                     ByVal outRoll As Double, ByVal outPitch As Double, ByVal outAzimuth As Double, ByVal spotX As Double, ByVal spotY As Double, _
    '                     ByVal inclRoll As Double, ByVal inclPitch As Double, ByVal temperature As Double, ByVal spotMax As Double, ByVal bz As Double, _
    '                     ByVal exptime As Double, ByVal ErrorBit As BitArray)
End Class
