Imports System.Data.OleDb
Imports System.Text

Public Class DataAccess1
    Dim OleConn As OleDbConnection
    Dim OleAdapter As OleDbDataAdapter
    Public AccessName As String = "TotalStationData.cdb"
    Dim OleCommd As OleDbCommandBuilder
    Dim OleCommand As New OleDbCommand
    Dim OleCommandBuilder As New OleDbCommandBuilder




    Public Property OleConnection() As OleDbConnection
        Get
            Return OleConn
        End Get
        Set(ByVal value As OleDbConnection)
            OleConn = value
        End Set
    End Property
    Sub InitializeAccess(ByVal StartPath As String)

        If StartPath = "" Then
            OleConn = New OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;data source=" & StartPath & "\" & AccessName & ";Jet OLEDB:Database Password=crcc")
        Else
            OleConn = New OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;data source=" & StartPath & "\" & AccessName & ";Jet OLEDB:Database Password=crcc")
        End If

    End Sub


    Function FillTable(ByVal TableName As String) As DataTable
        Dim OleTable As New DataTable
        OleAdapter = New OleDbDataAdapter("select * from " & TableName, OleConn)
        OleCommd = New OleDbCommandBuilder(OleAdapter)
        OleAdapter.Fill(OleTable)
        Return OleTable
    End Function

    Function FillOrderTable(ByVal TableName As String, ByVal ColumnName As String, ByVal UpDown As Integer) As DataTable
        Dim OleTable As New DataTable
        Dim strUpDown As String
        If UpDown = 0 Then
            strUpDown = "asc"
        Else
            strUpDown = "desc"
        End If
        OleAdapter = New OleDbDataAdapter("select * from " & TableName & " order by " & ColumnName & " " & strUpDown, OleConn)
        OleCommd = New OleDbCommandBuilder(OleAdapter)
        OleAdapter.Fill(OleTable)
        Return OleTable
    End Function

    Sub UpdataTable(ByVal OleTable As DataTable, ByVal TableName As String)
        OleAdapter = New OleDbDataAdapter("select * from " & TableName, OleConn)
        OleCommd = New OleDbCommandBuilder(OleAdapter)
        OleAdapter.Update(OleTable)
    End Sub
    Sub Open()
        OleConn.Open()
    End Sub
    Sub Close()
        OleConn.Close()
    End Sub





#Region "插入ACCESS"



    Private Sub InsertAccess(ByVal TableName As String, ByVal ColumnNames As String, ByVal RowValues As String)

        OleCommand.Connection = OleConn
        OleCommand.CommandText = "insert into " & TableName & "(" & ColumnNames & ")values(" & RowValues & ")"
        OleCommand.ExecuteNonQuery()

    End Sub

    Private Sub InsertAccess(ByVal TableName As String, ByVal MeasTimeName As String, ByVal MeasTimeValue As String, ByVal ColumnNames As String, ByVal RowValues As String)

        OleCommand.Connection = OleConn
        OleCommand.CommandText = "insert into " & TableName & "(" & MeasTimeName & "," & ColumnNames & ")values(#" & MeasTimeValue & "#," & RowValues & ")"
        OleCommand.ExecuteNonQuery()

    End Sub



    Public Sub InsertAccess(ByVal TableName As String, ByVal ColumnName() As String, ByVal RowValue() As String)
        Dim ColumnLength As Integer
        'Dim ValueLength As Int32

        ColumnLength = ColumnName.Length
        'ValueLength = RowValues.Length

        Dim ColumnNames As New StringBuilder
        Dim RowValues As New StringBuilder

        For i = 1 To ColumnLength - 1
            ColumnNames.Append(ColumnName(i) & ",")
            RowValues.Append(RowValue(i) & ",")
        Next
        ColumnNames.Remove(ColumnNames.Length - 1, 1)
        RowValues.Remove(RowValues.Length - 1, 1)
        InsertAccess(TableName, ColumnName(0), RowValue(0), ColumnNames.ToString, RowValues.ToString)
    End Sub

#End Region


#Region "查询Access"
    Private Function SelectAccess(ByVal TableName As String, ByVal QueryString As String, ByVal ColumnName As String, ByVal StartItem As String, ByVal EndItem As String, Optional ByVal DateItem As Boolean = False) As DataTable
        Dim QueryTable As New DataTable
        Dim DateString As String = ""
        If DateItem = False Then
            DateString = ""
        ElseIf DateItem = True Then
            DateString = "#"
        End If


        OleAdapter = New OleDbDataAdapter("select " & QueryString & " from " & TableName & " where " & ColumnName & " between " & DateString & StartItem & DateString & " and " & DateString & EndItem & DateString & " order by " & ColumnName & " asc ", OleConn)
        OleCommandBuilder = New OleDbCommandBuilder(OleAdapter)
        OleAdapter.Fill(QueryTable)

        Return QueryTable

    End Function

    Public Function SelectAccess(ByVal TableName As String, ByVal QueryString As String, ByVal ColumnName As String, ByVal Value As String) As DataTable
        Dim QueryTable As New DataTable

        OleAdapter = New OleDbDataAdapter("select " & QueryString & " from " & TableName & " where " & ColumnName & " in('" & Value & "')", OleConn)
        'OleAdapter = New OleDbDataAdapter("select * from CrccUser where CrccName in('" & txtName.Text & "')", OleConn)
        OleCommandBuilder = New OleDbCommandBuilder(OleAdapter)
        OleAdapter.Fill(QueryTable)

        Return QueryTable

    End Function
    'yxl于2015年10月26日添加
    Public Function QueryDTA(ByVal RingCounter As Integer) As DataTable
        Dim QueryTable As New DataTable

        OleAdapter = New OleDbDataAdapter("Select * from DTA where RingCounter = " & RingCounter, OleConn)
        OleCommandBuilder = New OleDbCommandBuilder(OleAdapter)
        OleAdapter.Fill(QueryTable)
        Return QueryTable

        OleConn.Close()

    End Function

    Public Function SelectAccess(ByVal TableName As String, ByVal QueryString() As String, ByVal ColumnName As String, ByVal StartItem As String, ByVal EndItem As String, Optional ByVal DateItem As Boolean = False) As DataTable
        Dim QueryStringLength As Integer
        QueryStringLength = QueryString.Length
        Dim QueryStrings As New StringBuilder


        For i = 0 To QueryStringLength - 1
            QueryStrings.Append(QueryString(i) & ",")
        Next

        QueryStrings.Remove(QueryStrings.Length - 1, 1)

        Return SelectAccess(TableName, QueryStrings.ToString, ColumnName, StartItem, EndItem, DateItem)

    End Function
#End Region

#Region "删除Access"
    Sub DeleteAccess(ByVal TableName As String, ByVal ColumnName As String, ByVal RowValue As String, Optional ByVal txtItem As Boolean = False)
        Dim txtString As String = ""
        If txtItem = False Then
            txtString = ""
        ElseIf txtItem = True Then
            txtString = "'"
        End If
        OleCommand.Connection = OleConn

        OleCommand.CommandText = "delete from " & TableName & " where " & ColumnName & "=" & txtString & RowValue & txtString
        OleCommand.ExecuteNonQuery()

    End Sub


#End Region


#Region "更新Access"
    Sub UpdateAccess(ByVal TableName As String, ByVal UpdateColumnName As String, ByVal UpdateValue As String, ByVal ColumnName As String, ByVal RowValue As String, Optional ByVal txtItem As Boolean = False)
        Dim txtString As String = ""
        If txtItem = False Then
            txtString = ""
        ElseIf txtItem = True Then
            txtString = "'"
        End If
        OleCommand.Connection = OleConn
        OleCommand.CommandText = "update " & TableName & " set " & UpdateColumnName & "=" & txtString & UpdateValue & txtString & " where " & ColumnName & "=" & txtString & RowValue & txtString
        OleCommand.ExecuteNonQuery()

    End Sub
#End Region


End Class
