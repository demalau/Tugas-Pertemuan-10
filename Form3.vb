Public Class Form3
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        For i As Integer = 0 To 10 
            ListBox1.Items.Add(i)
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        For i As Integer = 10 To 0 Step -1
            ListBox2.Items.Add(i)
        Next
    End Sub
End Class