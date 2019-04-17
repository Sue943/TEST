Public Class DataXML
    Dim Path As String = Application.StartupPath
    Property StartupPath()
        Get
            Return Path
        End Get
        Set(ByVal value)
            Path = value
        End Set
    End Property

    Overridable Sub Load()

    End Sub

    Overridable Sub Save()

    End Sub
End Class

Public Class XMLParameter
    Inherits DataXML

    Dim Parameter As String = "Parameter"
    Dim SixPrism As String = "SixPrism"
    Dim theta As String = "theta"
    Dim DesignR As String = "DesignR"
    Dim FileName As String = "\Parameter.xml"

  

    Dim xdoc As XDocument = XDocument.Load(Me.StartupPath & FileName)
    Public Overrides Sub Load()

        xdoc = XDocument.Load(Me.StartupPath & FileName)

    End Sub

    Public Overrides Sub Save()
        xdoc.Save(Me.StartupPath & FileName)
    End Sub

   
#Region "棱镜"


    Property SixPrism1X()
        Get
            Return xdoc.Element(Parameter).Element(SixPrism).Element("Prism1X").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Parameter).Element(SixPrism).Element("Prism1X").SetValue(value)
            Save()
        End Set
    End Property


    Property SixPrism1Y()
        Get
            Return xdoc.Element(Parameter).Element(SixPrism).Element("Prism1Y").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Parameter).Element(SixPrism).Element("Prism1Y").SetValue(value)
            Save()
        End Set
    End Property


    Property SixPrism1Z()
        Get
            Return xdoc.Element(Parameter).Element(SixPrism).Element("Prism1Z").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Parameter).Element(SixPrism).Element("Prism1Z").SetValue(value)
            Save()
        End Set
    End Property


    Property SixPrism2X()
        Get
            Return xdoc.Element(Parameter).Element(SixPrism).Element("Prism2X").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Parameter).Element(SixPrism).Element("Prism2X").SetValue(value)
            Save()
        End Set
    End Property


    Property SixPrism2Y()
        Get
            Return xdoc.Element(Parameter).Element(SixPrism).Element("Prism2Y").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Parameter).Element(SixPrism).Element("Prism2Y").SetValue(value)
            Save()
        End Set
    End Property


    Property SixPrism2Z()
        Get
            Return xdoc.Element(Parameter).Element(SixPrism).Element("Prism2Z").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Parameter).Element(SixPrism).Element("Prism2Z").SetValue(value)
            Save()
        End Set
    End Property


    Property SixPrism3X()
        Get
            Return xdoc.Element(Parameter).Element(SixPrism).Element("Prism3X").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Parameter).Element(SixPrism).Element("Prism3X").SetValue(value)
            Save()
        End Set
    End Property


    Property SixPrism3Y()
        Get
            Return xdoc.Element(Parameter).Element(SixPrism).Element("Prism3Y").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Parameter).Element(SixPrism).Element("Prism3Y").SetValue(value)
            Save()
        End Set
    End Property


    Property SixPrism3Z()
        Get
            Return xdoc.Element(Parameter).Element(SixPrism).Element("Prism3Z").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Parameter).Element(SixPrism).Element("Prism3Z").SetValue(value)
            Save()
        End Set
    End Property


    Property SixPrism4X()
        Get
            Return xdoc.Element(Parameter).Element(SixPrism).Element("Prism4X").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Parameter).Element(SixPrism).Element("Prism4X").SetValue(value)
            Save()
        End Set
    End Property


    Property SixPrism4Y()
        Get
            Return xdoc.Element(Parameter).Element(SixPrism).Element("Prism4Y").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Parameter).Element(SixPrism).Element("Prism4Y").SetValue(value)
            Save()
        End Set
    End Property


    Property SixPrism4Z()
        Get
            Return xdoc.Element(Parameter).Element(SixPrism).Element("Prism4Z").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Parameter).Element(SixPrism).Element("Prism4Z").SetValue(value)
            Save()
        End Set
    End Property


    Property SixPrism5X()
        Get
            Return xdoc.Element(Parameter).Element(SixPrism).Element("Prism5X").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Parameter).Element(SixPrism).Element("Prism5X").SetValue(value)
            Save()
        End Set
    End Property


    Property SixPrism5Y()
        Get
            Return xdoc.Element(Parameter).Element(SixPrism).Element("Prism5Y").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Parameter).Element(SixPrism).Element("Prism5Y").SetValue(value)
            Save()
        End Set
    End Property


    Property SixPrism5Z()
        Get
            Return xdoc.Element(Parameter).Element(SixPrism).Element("Prism5Z").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Parameter).Element(SixPrism).Element("Prism5Z").SetValue(value)
            Save()
        End Set
    End Property

    Property SixPrism6X()
        Get
            Return xdoc.Element(Parameter).Element(SixPrism).Element("Prism6X").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Parameter).Element(SixPrism).Element("Prism6X").SetValue(value)
            Save()
        End Set
    End Property


    Property SixPrism6Y()
        Get
            Return xdoc.Element(Parameter).Element(SixPrism).Element("Prism6Y").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Parameter).Element(SixPrism).Element("Prism6Y").SetValue(value)
            Save()
        End Set
    End Property


    Property SixPrism6Z()
        Get
            Return xdoc.Element(Parameter).Element(SixPrism).Element("Prism6Z").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Parameter).Element(SixPrism).Element("Prism6Z").SetValue(value)
            Save()
        End Set
    End Property

#End Region
#Region "theta"
    Property thetaX()
        Get
            Return xdoc.Element(Parameter).Element(theta).Element("thetaX").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Parameter).Element(theta).Element("thetaX").SetValue(value)
            Save()
        End Set
    End Property

    Property thetaY()
        Get
            Return xdoc.Element(Parameter).Element(theta).Element("thetaY").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Parameter).Element(theta).Element("thetaY").SetValue(value)
            Save()
        End Set
    End Property

#End Region

#Region "DesignR"
    Property R()
        Get
            Return xdoc.Element(Parameter).Element(DesignR).Element("R").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Parameter).Element(DesignR).Element("R").SetValue(value)
            Save()
        End Set
    End Property
#End Region

End Class

Public Class XMLStation
    Inherits DataXML
    Dim Station As String = "Station"
    Dim FileName As String = "\Station.xml"
    Dim XYZ As String = "XYZ"
    Dim Back As String = "Back"
    Dim Az As String = "Az"
    Dim BackMeas As String = "BackMeas"
    Dim Test As String = "Test"


    Dim xdoc As XDocument = XDocument.Load(Me.StartupPath & FileName)
    Public Overrides Sub Load()

        xdoc = XDocument.Load(Me.StartupPath & FileName)
    End Sub

    Public Overrides Sub Save()
        xdoc.Save(Me.StartupPath & FileName)
    End Sub



#Region "后视"

    Property BackName()
        Get
            Return xdoc.Element(Station).Element(Back).Element("Name").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Station).Element(Back).Element("Name").SetValue(value)
            Save()
        End Set
    End Property

    Property BackX()
        Get
            Return xdoc.Element(Station).Element(Back).Element("X").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Station).Element(Back).Element("X").SetValue(value)
            Save()
        End Set
    End Property

    Property BackY()
        Get
            Return xdoc.Element(Station).Element(Back).Element("Y").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Station).Element(Back).Element("Y").SetValue(value)
            Save()
        End Set
    End Property

    Property BackZ()
        Get
            Return xdoc.Element(Station).Element(Back).Element("Z").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Station).Element(Back).Element("Z").SetValue(value)
            Save()
        End Set
    End Property

    Property BackH()
        Get
            Return xdoc.Element(Station).Element(Back).Element("H").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Station).Element(Back).Element("H").SetValue(value)
            Save()
        End Set
    End Property
#End Region


#Region "后视测量"

    Property BackMeasX()
        Get
            Return xdoc.Element(Station).Element(BackMeas).Element("X").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Station).Element(BackMeas).Element("X").SetValue(value)
            Save()
        End Set
    End Property

    Property BackMeasY()
        Get
            Return xdoc.Element(Station).Element(BackMeas).Element("Y").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Station).Element(BackMeas).Element("Y").SetValue(value)
            Save()
        End Set
    End Property

    Property BackMeasZ()
        Get
            Return xdoc.Element(Station).Element(BackMeas).Element("Z").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Station).Element(BackMeas).Element("Z").SetValue(value)
            Save()
        End Set
    End Property

    Property BackMeasHz()
        Get
            Return xdoc.Element(Station).Element(BackMeas).Element("Hz").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Station).Element(BackMeas).Element("Hz").SetValue(value)
            Save()
        End Set
    End Property

    Property BackMeasVt()
        Get
            Return xdoc.Element(Station).Element(BackMeas).Element("Vt").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Station).Element(BackMeas).Element("Vt").SetValue(value)
            Save()
        End Set
    End Property

    Property BackSlopeDistance()
        Get
            Return xdoc.Element(Station).Element(BackMeas).Element("SlopeDistance").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Station).Element(BackMeas).Element("SlopeDistance").SetValue(value)
            Save()
        End Set
    End Property


    Property BackDesignedDistance()
        Get
            Return xdoc.Element(Station).Element(BackMeas).Element("DesignedDistance").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Station).Element(BackMeas).Element("DesignedDistance").SetValue(value)
            Save()
        End Set
    End Property


    Property BackDistanceOffset()
        Get
            Return xdoc.Element(Station).Element(BackMeas).Element("DistanceOffset").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Station).Element(BackMeas).Element("DistanceOffset").SetValue(value)
            Save()
        End Set
    End Property

    Property BackAngleOffset()
        Get
            Return xdoc.Element(Station).Element(BackMeas).Element("AngleOffset").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Station).Element(BackMeas).Element("AngleOffset").SetValue(value)
            Save()
        End Set
    End Property

    Property BackDeltaX()
        Get
            Return xdoc.Element(Station).Element(BackMeas).Element("DeltaX").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Station).Element(BackMeas).Element("DeltaX").SetValue(value)
            Save()
        End Set
    End Property

    Property BackDeltaY()
        Get
            Return xdoc.Element(Station).Element(BackMeas).Element("DeltaY").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Station).Element(BackMeas).Element("DeltaY").SetValue(value)
            Save()
        End Set
    End Property

    Property BackDeltaZ()
        Get
            Return xdoc.Element(Station).Element(BackMeas).Element("DeltaZ").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Station).Element(BackMeas).Element("DeltaZ").SetValue(value)
            Save()
        End Set
    End Property


#End Region


#Region "测站"


    Property XYZName()
        Get
            Return xdoc.Element(Station).Element(XYZ).Element("Name").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Station).Element(XYZ).Element("Name").SetValue(value)
            Save()
        End Set
    End Property

    Property XYZX()
        Get
            Return xdoc.Element(Station).Element(XYZ).Element("X").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Station).Element(XYZ).Element("X").SetValue(value)
            Save()
        End Set
    End Property

    Property XYZY()
        Get
            Return xdoc.Element(Station).Element(XYZ).Element("Y").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Station).Element(XYZ).Element("Y").SetValue(value)
            Save()
        End Set
    End Property

    Property XYZZ()
        Get
            Return xdoc.Element(Station).Element(XYZ).Element("Z").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Station).Element(XYZ).Element("Z").SetValue(value)
            Save()
        End Set
    End Property

    Property XYZH()
        Get
            Return xdoc.Element(Station).Element(XYZ).Element("H").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Station).Element(XYZ).Element("H").SetValue(value)
            Save()
        End Set
    End Property
#End Region

#Region "方向角"
    Property AzName()
        Get
            Return xdoc.Element(Station).Element(Az).Element("Name").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Station).Element(Az).Element("Name").SetValue(value)
            Save()
        End Set
    End Property

    Property AzAz()
        Get
            Return xdoc.Element(Station).Element(Az).Element("Az").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Station).Element(Az).Element("Az").SetValue(value)
            Save()
        End Set
    End Property

    Property AzH0()
        Get
            Return xdoc.Element(Station).Element(Az).Element("H0").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Station).Element(Az).Element("H0").SetValue(value)
            Save()
        End Set
    End Property
#End Region

#Region "测试连接"

    Property TestC()
        Get
            Return xdoc.Element(Station).Element(Test).Element("C").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Station).Element(Test).Element("C").SetValue(value)
            Save()
        End Set
    End Property


    Property TestL()
        Get
            Return xdoc.Element(Station).Element(Test).Element("L").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Station).Element(Test).Element("L").SetValue(value)
            Save()
        End Set
    End Property


    Property TestPower()
        Get
            Return xdoc.Element(Station).Element(Test).Element("Power").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Station).Element(Test).Element("Power").SetValue(value)
            Save()
        End Set
    End Property

#End Region

End Class

Public Class XMLProject
    Inherits DataXML

    Dim Project As String = "Project"
    Dim FileName As String = "\Project.xml"

    Dim xdoc As XDocument = XDocument.Load(Me.StartupPath & FileName)

    Public Overrides Sub Load()

        xdoc = XDocument.Load(Me.StartupPath & FileName)
    End Sub

    Public Overrides Sub Save()
        xdoc.Save(Me.StartupPath & FileName)
    End Sub

    Property StartPath()
        Get
            Return xdoc.Element(Project).Element("StartPath").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Project).Element("StartPath").SetValue(value)
            Save()
        End Set
    End Property


    Property Name()
        Get
            Return xdoc.Element(Project).Element("Name").Value
        End Get
        Set(ByVal value)
            xdoc.Element(Project).Element("Name").SetValue(value)
            Save()
        End Set
    End Property

End Class


