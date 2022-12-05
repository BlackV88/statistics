Public Class Form1
    Dim accumulator As Integer = 0
    Dim user As String = "guest"

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If accumulator <= Integer.MaxValue Then
            accumulator = accumulator + 1
            Label1.Text = accumulator
        Else
            MsgBox("Max number reached")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If accumulator >= Integer.MinValue Then
            accumulator = accumulator - 1
            Label1.Text = accumulator
        Else
            MsgBox("Minumum number reached")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("See you " + user)
        End
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MsgBox("Thank you!")
        user = TextBox1.Text
        TextBox1.Enabled = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
