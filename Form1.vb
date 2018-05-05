Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b, i, c, n, hasil As Single

        a = TextBox1.Text
        a = 1
        For i = 1 To TextBox1.Text
            a = a * i
        Next i
        TextBox2.Text = a

        a = 0
        b = 1
        n = TextBox1.Text
        ListBox1.Items.Add(a)
        ListBox1.Items.Add(b)
        For i = 3 To n
            c = Val(a) + Val(b)
            ListBox1.Items.Add(c)
            a = b
            b = c
        Next i
        hasil = n * n
        TextBox3.Text = hasil


    End Sub
End Class
