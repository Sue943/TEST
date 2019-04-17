Public Class DesignR

    Dim R As Double


    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        If txtR.Text = "" Then
            MessageBox.Show("请输入梁设计曲线半径")
        Else
            R = txtR.Text
            Parameter.R = R
        End If
       
    End Sub
End Class