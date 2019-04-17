
Imports System.IO
Imports Microsoft.VisualBasic.FileIO

Public Class ProjectInfo

    Private Sub btnCreatItem_Click(sender As Object, e As EventArgs) Handles btnCreatItem.Click
        Try

            Dim sfd As New SaveFileDialog

            sfd.Filter = "crcc files (*.crcc)|*.crcc|All files (*.*)|*.*"
            sfd.FilterIndex = 1
            sfd.ShowDialog()

            Dim FileName As String
            FileName = sfd.FileName

            If FileName = "" Or FileName Is Nothing Then
                Exit Sub
            End If

            Dim path As String()
            Dim SafeFileName As String
            Dim l1 As Integer
            Dim SaveFileName As String

            path = FileName.Split("\"c)
            l1 = path.Length
            Dim spath(l1 - 1) As String
            SafeFileName = path(l1 - 1)

            For i = 0 To l1 - 2
                spath(i) = path(i)
            Next
            spath(l1 - 1) = SafeFileName.Remove(SafeFileName.Length - 5)
            SaveFileName = [String].Join("\", spath)

            Project.StartPath = SaveFileName
            Project.Name = SafeFileName
            txtItemName.Text = SafeFileName
          

            My.Computer.FileSystem.CopyFile(Application.StartupPath & "\TotalStationData.mdb", SaveFileName & "\TotalStationData.cdb", FileIO.UIOption.AllDialogs, FileIO.UICancelOption.DoNothing)
            My.Computer.FileSystem.CopyFile(Application.StartupPath & "\Parameter.xml", SaveFileName & "\Parameter.xml", FileIO.UIOption.AllDialogs, FileIO.UICancelOption.DoNothing)
            My.Computer.FileSystem.CopyFile(Application.StartupPath & "\Station.xml", SaveFileName & "\Station.xml", FileIO.UIOption.AllDialogs, FileIO.UICancelOption.DoNothing)
            My.Computer.FileSystem.CopyFile(Application.StartupPath & "\Project.xml", FileName, FileIO.UIOption.AllDialogs, FileIO.UICancelOption.DoNothing)

            InitializeSystem()

            '   My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\CRCC\ProjectInfo", "ProjectPath", Project.StartPath)
            Service.SetStartPath(SaveFileName)

            DesignR.Show()
           
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub btnSelectItem_Click(sender As Object, e As EventArgs) Handles btnSelectItem.Click

        Try

            Dim ofd As New OpenFileDialog

            ofd.Filter = "crcc files (*.crcc)|*.crcc|All files (*.*)|*.*"
            ofd.FilterIndex = 1
            ofd.ShowDialog()

            Dim FileName As String
            FileName = ofd.FileName

            If FileName = "" Or FileName Is Nothing Then
                'MessageBox.Show("没有选择文件")
                Exit Sub
            End If

            Dim path As String()
            Dim SafeFileName As String
            Dim l1 As Integer
            Dim SaveFileName As String


            path = FileName.Split("\"c)
            l1 = path.Length
            Dim spath(l1 - 1) As String
            SafeFileName = path(l1 - 1)


            For i = 0 To l1 - 2
                spath(i) = path(i)
            Next
            spath(l1 - 1) = SafeFileName.Remove(SafeFileName.Length - 5)
            SaveFileName = [String].Join("\", spath)


            Project.StartPath = SaveFileName
            Project.Name = ofd.SafeFileName
            txtItemName.Text = ofd.SafeFileName

            InitializeSystem()
            '   My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\CRCC\ProjectInfo", "ProjectPath", Project.StartPath)
            Service.SetStartPath(SaveFileName)
            Me.Hide()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub
End Class