Public Class Form1
    Dim rd As Random = New Random()
    Dim mid As Double = 0
    Dim rand_num As Integer = 0
    Dim counter As Long = 0
    Dim sum As Long = 0
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RichTextBox1.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        counter += 1
        rand_num = rd.Next(0, 100)
        sum += rand_num
        mid = sum / counter
        RichTextBox1.AppendText(
                "Generation no. " & CStr(counter) &
                ", Number: " & CStr(rand_num) &
                ", Mean: " & CStr(mid) & vbLf
                )
    End Sub
End Class
