
Imports System.Math
Public Class Matrix
    Private tMat(,) As Double = {{0}}
    'Private Array() As Double = {0}
    'Mat这一属性可以考虑直接删去；

    'Public Property Mat As Double(,)
    '    Get
    '        Return tMat
    '    End Get
    '    Set(value As Double(,))
    '        tMat = value
    '    End Set
    'End Property

    '@return：矩阵的行数
    Public ReadOnly Property RowSize As Integer
        Get
            Return UBound(tMat, 1) + 1
        End Get
    End Property
    ''@return：矩阵的列数
    Public ReadOnly Property ColumnSize As Integer
        Get
            Return UBound(tMat, 2) + 1
        End Get
    End Property
    '@abstract:用于设置或查询矩阵中的元素
    'parameter:rp和cp分别是元素所在的行号和列号
    '@return：返回矩阵中对应位置的数字，或设置矩阵中对应位置的数字
    Public Property Item(rp As Integer, cp As Integer) As Double
        Get
            Return tMat(rp - 1, cp - 1)
        End Get
        Set(value As Double)
            tMat(rp - 1, cp - 1) = value
        End Set
    End Property
    ''@abstract:空参构造方法
    Public Sub New()

    End Sub
    '@abstract:带参构造方法
    '@parameter:MatArr(,)为一二维数组
    Public Sub New(MatArr(,) As Double)
        tMat = MatArr
    End Sub
    ''@abstract:带参构造方法(产生具有固定大小的矩阵)
    ''@parameter:r表示矩阵的行数，c表示矩阵的列数；r，c都大于0.
    Public Sub New(r As Integer, c As Integer)
        ReDim tMat(r - 1, c - 1)
    End Sub

    'Public Sub New(Arr() As Double)
    '    Array = Arr
    'End Sub





    '@abstract:判断矩阵是否是行向量
    '@return：矩阵为行向量则返回True,否则返回False;
    Public Function IsRowVector() As Boolean
        If UBound(tMat, 1) = 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    '@abstract:判断矩阵是否为列向量
    '@return：矩阵为列向量则返回True,否则返回False;
    Public Function IsColumnVector() As Boolean
        If UBound(tMat, 2) = 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    '@abstract:判断一个矩阵是否为方阵
    Public Function IsSquareMatrix() As Boolean
        If UBound(tMat, 1) = UBound(tMat, 2) Then
            Return True
        Else
            Return False
        End If
    End Function
    '@abstract:判断两个矩阵是否为同类型
    '@parameter:anotherMat 需要与本Matrix实例进行对比的另一矩阵
    '@return：如果两矩阵行数都相等，返回True;否则返回Flase
    Public Function IsSimilarTo(ByVal anotherMat As Matrix) As Boolean
        If Me.RowSize = anotherMat.RowSize And Me.ColumnSize = anotherMat.ColumnSize Then
            Return True
        Else
            Return False
        End If
    End Function
    '@abstract:重写toString方法
    Public Overrides Function toString() As String
        Dim rowStr As String = ""
        Dim result As String = ""
        Dim r As Integer = UBound(tMat, 1)
        Dim c As Integer = UBound(tMat, 2)
        Dim ML As Integer = maxLen()
        For i = 0 To r
            If c > 0 Then
                For j = 0 To c - 1
                    rowStr += tMat(i, j) & "," & Space(ML - Len(tMat(i, j).ToString) + 2)

                Next
                rowStr += tMat(i, c) & ";"
            Else
                rowStr = tMat(i, 0)
            End If
            result += rowStr & vbCrLf
            rowStr = ""
        Next
        Return result
    End Function
    Private Function maxLen() As Integer
        Dim l As Integer = 0
        Dim max As Integer = 0
        For Each dbl As Double In tMat
            l = Len(dbl.ToString)
            If l > max Then
                max = l
            End If
        Next
        Return max
    End Function
    '@abstract:获取行向量
    '@parameter: rwoNum为原矩阵中某行的行号
    '@return:源矩阵中第rowNum行所有元素组成的行向量（矩阵）
    Public Function getRowVector(ByVal rowNum As Double) As Matrix
        If rowNum >= 1 And rowNum <= Me.RowSize Then
            Dim colN As Integer = Me.ColumnSize
            Dim vector As New Matrix(1, colN)
            For j = 1 To colN
                vector.Item(1, j) = Me.Item(rowNum, j)
            Next
            Return vector
        Else
            MsgBox("'rowNum' beyond the range of RowSize")
            Return Nothing
        End If
    End Function
    '@abstract:获取列向量
    '@parameter: colNum为原矩阵中某列的列号
    '@return:源矩阵中第colNum列所有元素组成的列向量（矩阵）
    Public Function getColVector(ByVal colNum As Double) As Matrix
        If colNum >= 1 And colNum <= Me.ColumnSize Then
            Dim rowN As Integer = Me.RowSize
            Dim vector As New Matrix(rowN, 1)
            For i = 1 To rowN
                vector.Item(i, 1) = Me.Item(i, colNum)
            Next
            Return vector
        Else
            MsgBox("'colNum' beyond the range of ColumnSize")
            Return Nothing
        End If
    End Function
    '@abstract:创建一个单位矩阵
    '@paramter:dimension 单位矩阵的维度
    '@return：一个维度为dimension的单位矩阵
    Public Shared Function E(ByVal dimension As Integer) As Matrix
        Dim identityMat As New Matrix(dimension, dimension)
        For i = 1 To dimension
            identityMat.Item(i, i) = 1
        Next
        Return identityMat
    End Function
    '@abstract:重载乘法运算符，做两个矩阵的乘法运算
    '@parameter:leftMat 乘号*左边的矩阵；rightMat 乘号*右边的矩阵
    '@return:两个矩阵相乘后得到的新矩阵
    Public Overloads Shared Operator *(ByVal leftMat As Matrix, ByVal rightMat As Matrix) As Matrix
        Dim rowleft, colleft, rowright, colright As Integer
        rowleft = leftMat.RowSize
        colleft = leftMat.ColumnSize

        rowright = rightMat.RowSize
        colright = rightMat.ColumnSize
        If colleft <> rowright Then
            MsgBox("矩阵相乘错误，原因：第一个矩阵与第二个矩阵的列行不等")
            Return Nothing
        End If
        Dim mulmat As New Matrix(rowleft, colright)
        Dim i, j, k As Integer
        Dim dblone As Double
        dblone = 0
        For i = 1 To rowleft
            For j = 1 To colright
                For k = 1 To colleft
                    dblone += leftMat.Item(i, k) * rightMat.Item(k, j)
                Next
                mulmat.Item(i, j) = dblone
                dblone = 0
            Next
        Next
        Return mulmat
    End Operator
    '@abstract:重载乘法运算符，做一个数字和一个矩阵的乘法运算
    '@parameter:leftNum 乘号*左边的数字；rightMat 乘号*右边的矩阵
    '@return:相乘后得到的新矩阵
    Public Overloads Shared Operator *(ByVal leftNum As Double, ByVal rightMat As Matrix) As Matrix
        Dim rowN As Integer = rightMat.RowSize
        Dim colN As Integer = rightMat.ColumnSize
        Dim resultMat As New Matrix(rowN, colN)
        For i = 1 To rowN
            For j = 1 To colN
                resultMat.Item(i, j) = rightMat.Item(i, j) * leftNum
            Next
        Next
        Return resultMat
    End Operator
    '@abstract:重载乘法运算符，做一个矩阵和一个数字的乘法运算
    '@parameter:leftMat 乘号*左边的矩阵；rightNum乘号*右边的数字
    '@return:相乘后得到的新矩阵
    Public Overloads Shared Operator *(ByVal leftMat As Matrix, ByVal rightNum As Double) As Matrix
        Dim rowN As Integer = leftMat.RowSize
        Dim colN As Integer = leftMat.ColumnSize
        Dim resultMat As New Matrix(rowN, colN)
        For i = 1 To rowN
            For j = 1 To colN
                resultMat.Item(i, j) = leftMat.Item(i, j) * rightNum
            Next
        Next
        Return resultMat
    End Operator
    '@abstract:重载加法运算符，做两个矩阵的加法运算。
    '@parameter:leftMat和rightMat分别是+号两边的矩阵
    '@return：两个矩阵相加后得到的新矩阵
    Public Overloads Shared Operator +(ByVal leftMat As Matrix, ByVal rightMat As Matrix) As Matrix
        If leftMat.IsSimilarTo(rightMat) Then
            Dim rowN As Integer = leftMat.RowSize
            Dim colN As Integer = leftMat.ColumnSize
            Dim resultMat As New Matrix(rowN, colN)
            For i = 1 To rowN
                For j = 1 To colN
                    resultMat.Item(i, j) = leftMat.Item(i, j) + rightMat.Item(i, j)
                Next
            Next
            Return resultMat
        Else
            MsgBox("'+'号两边矩阵不是同一类型！")
            Return Nothing
        End If
    End Operator
    '@abstract:重载负号运算
    '@parameter:theMat 要做符号运算的矩阵
    '@return:theMat中所有元素都去负后得到的新矩阵
    Public Overloads Shared Operator -(ByVal theMat As Matrix) As Matrix
        Dim rowN As Integer = theMat.RowSize
        Dim colN As Integer = theMat.ColumnSize
        Dim resultMat As New Matrix(rowN, colN)
        For i = 1 To rowN
            For j = 1 To colN
                resultMat.Item(i, j) = -theMat.Item(i, j)
            Next
        Next
        Return resultMat
    End Operator
    '@abstract:做增广矩阵
    '@parameter:leftMat,rightMat分别为要做合并的左右两个矩阵
    '@return：两个行数相同的矩阵合并为一个新矩阵
    Public Overloads Shared Operator &(ByVal leftMat As Matrix, ByVal rightMat As Matrix) As Matrix
        Dim leftRowN As Integer = leftMat.RowSize
        Dim leftColN As Integer = leftMat.ColumnSize
        Dim rightRowN As Integer = rightMat.RowSize
        Dim rightColN As Integer = rightMat.ColumnSize
        If leftRowN <> rightRowN Then
            MsgBox("两矩阵行数不同，不能够合并！")
            Return Nothing
        Else
            Dim resultMat As New Matrix(leftRowN, leftColN + rightColN)
            For i = 1 To leftRowN
                For j1 = 1 To leftColN
                    resultMat.Item(i, j1) = leftMat.Item(i, j1)
                Next
                For j2 = (leftColN + 1) To (leftColN + rightColN)
                    resultMat.Item(i, j2) = rightMat.Item(i, j2 - leftColN)
                Next
            Next
            Return resultMat
        End If
    End Operator
    '@abstract:转置矩阵
    '@return: 将一个矩阵转置后得到的新矩阵
    Public Function Transpose() As Matrix
        Dim rowN As Integer = Me.RowSize
        Dim colN As Integer = Me.ColumnSize
        Dim resultMat As New Matrix(colN, rowN)
        For i = 1 To colN
            For j = 1 To rowN
                resultMat.Item(i, j) = Me.Item(j, i)
            Next
        Next
        Return resultMat
    End Function
    '@abstract:求一个n阶方阵的行列式
    '@return：返回行列式对应的值
    Public Function Determ() As Double
        If Me.IsSquareMatrix Then
            If Me.RowSize >= 2 Then
                Dim result As Double = 0
                Dim n As Integer = Me.ColumnSize
                For i = 1 To n
                    result += (-1) ^ (1 + i) * Me.Item(1, i) * (Me.SubMatrix(1, i).Determ)
                Next
                Return result
            Else
                Return Me.Item(1, 1)
            End If
        Else
            MsgBox("矩阵不是方阵，不能求行列式值！")
            Return Nothing
        End If
    End Function
    '@abstract:求一个方阵对应位置元素的余子式对应的方阵
    '@parameter:rp和cp表时所要去掉的行和列编号
    '@return：去掉对应行和列的元素后产生的新矩阵,如果矩阵只有一个元素，返回自身；
    Public Function SubMatrix(ByVal rp As Integer, ByVal cp As Integer) As Matrix
        If Me.IsSquareMatrix Then
            If Me.RowSize < 2 Then
                MsgBox("矩阵只有一个元素，无法求子矩阵！")
                Return Me
            Else
                Dim rowN As Integer = Me.RowSize
                Dim colN As Integer = Me.ColumnSize
                Dim resultMat As New Matrix(rowN - 1, colN - 1)
                For i = 1 To rowN - 1
                    For j = 1 To colN - 1
                        If i >= rp Then
                            If j >= cp Then
                                resultMat.Item(i, j) = Me.Item(i + 1, j + 1)
                            Else
                                resultMat.Item(i, j) = Me.Item(i + 1, j)
                            End If
                        Else
                            If j >= cp Then
                                resultMat.Item(i, j) = Me.Item(i, j + 1)
                            Else
                                resultMat.Item(i, j) = Me.Item(i, j)
                            End If
                        End If
                    Next
                Next
                Return resultMat
            End If
        Else
            MsgBox("矩阵不是方阵，没有必要求子矩阵！")
            Return Nothing
        End If
    End Function
    '@abstract:求矩阵的逆矩阵
    '必须满足条件：矩阵为方阵；矩阵的行列式值不为0.
    '@return:返回本矩阵的逆矩阵
    Public Function InverseMatrix() As Matrix
        If Me.IsSquareMatrix Then
            Dim detMat As Double = Me.Determ
            If detMat = 0 Then
                MsgBox("矩阵的行列式值为0，不存在逆矩阵！")
                Return Nothing
            Else
                Dim D As Integer = Me.RowSize
                Dim resultMat As New Matrix(D, D)
                For i = 1 To D
                    For j = 1 To D
                        '对于做除法引起精度损失，保留8位小数
                        resultMat.Item(i, j) = (-1) ^ (i + j) * Me.SubMatrix(j, i).Determ * (1 / detMat)
                    Next
                Next
                Return resultMat
            End If
        Else
            MsgBox("矩阵不是方阵，不存在逆矩阵！")
            Return Nothing
        End If
    End Function

    ' 向量叉乘
    Public Sub Cross(ByVal A As Double(), ByVal B As Double(), ByVal C As Double(), ByRef Arr As Double(), ByRef M As Double())

        Try

            Dim BA(2) As Double     'BA向量
            Dim BC(2) As Double     'BC向量

            For i = 0 To A.Length() - 1
                BA(i) = A(i) - B(i)
                BC(i) = C(i) - B(i)
                M(i) = (A(i) + B(i) + C(i)) / 3
            Next
            Arr(0) = BA(1) * BC(2) - BC(1) * BA(2)
            Arr(1) = BC(0) * BA(2) - BA(0) * BC(2)
            Arr(2) = BA(0) * BC(1) - BC(0) * BA(1)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub


    Public Function Cross1(ByVal Arr1 As Double(), ByVal Arr2 As Double()) As Double()
        Dim arr3(2) As Double
        Try

       
        arr3(0) = Arr1(1) * Arr2(2) - Arr2(1) * Arr1(2)
        arr3(1) = Arr2(0) * Arr1(2) - Arr1(0) * Arr2(2)
        arr3(2) = Arr1(0) * Arr2(1) - Arr2(0) * Arr1(1)

        Catch ex As Exception
            Return Nothing
        End Try

        Return arr3

    End Function




End Class




