Imports System.IO
Public Class Form1
    Dim noOfFields As Integer = 1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Disable it to avoid misbehaviour
        Button1.Enabled = False

        Dim filePath As String = TextBox1.Text()
        noOfFields = NumericUpDown1.Value

        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(filePath)
            MyReader.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited
            MyReader.Delimiters = New String() {","}

            'Handles the first line
            Dim fields = MyReader.ReadFields()
            For i = 0 To noOfFields - 1
                If True = CheckBox1.Checked Then
                    'Adds the header as the name of the column of the DataGridView
                    DataGridView1.Columns.Add(i, fields(i))
                Else
                    'Adds a numeric value as the name of the column of the DataGridView
                    DataGridView1.Columns.Add(i, i)
                End If
            Next
            'To add the first line if it has not headers
            If False = CheckBox1.Checked Then
                DataGridView1.Rows.Add(fields)
            End If

            'Add the lines of the file to the DataGridView
            While Not MyReader.EndOfData
                fields = MyReader.ReadFields()
                DataGridView1.Rows.Add(fields)
            End While
        End Using
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class
