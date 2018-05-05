Public Class Form2
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton2.Checked = True Then
            Dim A, B, C As Integer
            ListBox1.Items.Clear()
            For A = TextBox1.Text To TextBox2.Text Step 1
                For B = 1 To TextBox3.Text Step 1
                    C = A * B
                    If A = 1 Then
                        ListBox1.Items.Add(A & "x" & B & "=" & C)
                    ElseIf A = 2 Then
                        ListBox1.Items.Add(A & "x" & B & "=" & C)
                    Else
                        ListBox1.Items.Add(A & "x" & B & "=" & C)
                    End If
                Next
                ListBox1.Items.Add("--------------")
            Next
        ElseIf RadioButton1.Checked = True Then
            Dim A, B, C As Integer
            ListBox1.Items.Clear()
            For A = 1 To TextBox3.Text Step 1
                For B = 1 To TextBox3.Text Step 1
                    C = A * B
                    If A = 1 Then
                        ListBox1.Items.Add(A & "x" & B & "=" & C)
                    ElseIf A = 2 Then
                        ListBox1.Items.Add(A & "x" & B & "=" & C)
                    Else
                        ListBox1.Items.Add(A & "x" & B & "=" & C)
                    End If
                Next
                ListBox1.Items.Add("--------------")
            Next
        End If
    End Sub
End Class