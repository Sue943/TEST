﻿'------------------------------------------------------------------------------
' <auto-generated>
'     此代码由工具生成。
'     运行时版本:4.0.30319.42000
'
'     对此文件的更改可能会导致不正确的行为，并且如果
'     重新生成代码，这些更改将会丢失。
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'此源代码是由 Microsoft.VSDesigner 4.0.30319.42000 版自动生成。
'
Namespace DataWebReference
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="MeasWebServiceSoap", [Namespace]:="http://tempuri.org/")>  _
    Partial Public Class MeasWebService
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private SetStartPathOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetStartPathOperationCompleted As System.Threading.SendOrPostCallback
        
        Private testOperationCompleted As System.Threading.SendOrPostCallback
        
        Private DataSourceOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.TotalStationMeasurment.My.MySettings.Default.TotalStationMeasurment_DataWebReference_MeasWebService
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = true
                Me.useDefaultCredentialsSetExplicitly = false
            Else
                Me.useDefaultCredentialsSetExplicitly = true
            End If
        End Sub
        
        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = true)  _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = false))  _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = false)) Then
                    MyBase.UseDefaultCredentials = false
                End If
                MyBase.Url = value
            End Set
        End Property
        
        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property
        
        '''<remarks/>
        Public Event SetStartPathCompleted As SetStartPathCompletedEventHandler
        
        '''<remarks/>
        Public Event GetStartPathCompleted As GetStartPathCompletedEventHandler
        
        '''<remarks/>
        Public Event testCompleted As testCompletedEventHandler
        
        '''<remarks/>
        Public Event DataSourceCompleted As DataSourceCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SetStartPath", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function SetStartPath(ByVal StartPath As String) As String
            Dim results() As Object = Me.Invoke("SetStartPath", New Object() {StartPath})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub SetStartPathAsync(ByVal StartPath As String)
            Me.SetStartPathAsync(StartPath, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SetStartPathAsync(ByVal StartPath As String, ByVal userState As Object)
            If (Me.SetStartPathOperationCompleted Is Nothing) Then
                Me.SetStartPathOperationCompleted = AddressOf Me.OnSetStartPathOperationCompleted
            End If
            Me.InvokeAsync("SetStartPath", New Object() {StartPath}, Me.SetStartPathOperationCompleted, userState)
        End Sub
        
        Private Sub OnSetStartPathOperationCompleted(ByVal arg As Object)
            If (Not (Me.SetStartPathCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SetStartPathCompleted(Me, New SetStartPathCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetStartPath", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetStartPath() As String
            Dim results() As Object = Me.Invoke("GetStartPath", New Object(-1) {})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetStartPathAsync()
            Me.GetStartPathAsync(Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetStartPathAsync(ByVal userState As Object)
            If (Me.GetStartPathOperationCompleted Is Nothing) Then
                Me.GetStartPathOperationCompleted = AddressOf Me.OnGetStartPathOperationCompleted
            End If
            Me.InvokeAsync("GetStartPath", New Object(-1) {}, Me.GetStartPathOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetStartPathOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetStartPathCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetStartPathCompleted(Me, New GetStartPathCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/test", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function test() As String
            Dim results() As Object = Me.Invoke("test", New Object(-1) {})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub testAsync()
            Me.testAsync(Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub testAsync(ByVal userState As Object)
            If (Me.testOperationCompleted Is Nothing) Then
                Me.testOperationCompleted = AddressOf Me.OntestOperationCompleted
            End If
            Me.InvokeAsync("test", New Object(-1) {}, Me.testOperationCompleted, userState)
        End Sub
        
        Private Sub OntestOperationCompleted(ByVal arg As Object)
            If (Not (Me.testCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent testCompleted(Me, New testCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DataSource", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function DataSource() As System.Data.DataTable
            Dim results() As Object = Me.Invoke("DataSource", New Object(-1) {})
            Return CType(results(0),System.Data.DataTable)
        End Function
        
        '''<remarks/>
        Public Overloads Sub DataSourceAsync()
            Me.DataSourceAsync(Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub DataSourceAsync(ByVal userState As Object)
            If (Me.DataSourceOperationCompleted Is Nothing) Then
                Me.DataSourceOperationCompleted = AddressOf Me.OnDataSourceOperationCompleted
            End If
            Me.InvokeAsync("DataSource", New Object(-1) {}, Me.DataSourceOperationCompleted, userState)
        End Sub
        
        Private Sub OnDataSourceOperationCompleted(ByVal arg As Object)
            If (Not (Me.DataSourceCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent DataSourceCompleted(Me, New DataSourceCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
        
        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing)  _
                        OrElse (url Is String.Empty)) Then
                Return false
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024)  _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return true
            End If
            Return false
        End Function
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")>  _
    Public Delegate Sub SetStartPathCompletedEventHandler(ByVal sender As Object, ByVal e As SetStartPathCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class SetStartPathCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")>  _
    Public Delegate Sub GetStartPathCompletedEventHandler(ByVal sender As Object, ByVal e As GetStartPathCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class GetStartPathCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")>  _
    Public Delegate Sub testCompletedEventHandler(ByVal sender As Object, ByVal e As testCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class testCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")>  _
    Public Delegate Sub DataSourceCompletedEventHandler(ByVal sender As Object, ByVal e As DataSourceCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class DataSourceCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As System.Data.DataTable
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),System.Data.DataTable)
            End Get
        End Property
    End Class
End Namespace
