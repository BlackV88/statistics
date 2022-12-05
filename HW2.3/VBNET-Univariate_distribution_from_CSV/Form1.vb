Imports System.IO
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim filePath As String = TextBox1.Text()
        Dim columnToParse = NumericUpDown1.Value - 1


        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(filePath)
            MyReader.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited
            MyReader.Delimiters = New String() {","}
            Dim values As ArrayList = New ArrayList()

            'Handles the first line
            Dim fields = MyReader.ReadFields()
            If 0 <= columnToParse And columnToParse < fields.Length Then 'If has been choosen a valid number for the column
                ListBox1.Items.Add(fields(columnToParse))
                If True = CheckBox1.Checked Then
                    'Adds a string to indicate that above there is an header ListBox
                    ListBox1.Items.Add("----------------")
                End If

                'Add the lines of the file to the ListBox
                While Not MyReader.EndOfData
                    fields = MyReader.ReadFields()
                    values.Add(fields(columnToParse))
                End While

                values.Sort()
                Dim counter As Long = 0
                Dim inspected As Integer = values.Item(0)
                For Each value In values
                    'A new value of the variable has been found
                    If inspected <> value Then
                        ListBox1.Items.Add(inspected & " has been counted " & counter & " times")
                        inspected = value
                        counter = 1
                    Else
                        counter += 1
                    End If
                Next
                'Print the last value inspected
                ListBox1.Items.Add(inspected & " has been counted " & counter & " times")
            End If
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
    End Sub
End Class
