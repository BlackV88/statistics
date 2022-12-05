Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        displaylabel.Text = "Hello, I am '" + txt_name.Text + "', I am from '" + txt_from.Text + "'"
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_name.TextChanged
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles displaylabel.Click

    End Sub
End Class
