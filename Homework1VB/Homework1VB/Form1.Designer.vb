<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.displaylabel = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.RichTextBox()
        Me.txt_from = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(63, 194)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 29)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Display"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(63, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(63, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "From"
        '
        'displaylabel
        '
        Me.displaylabel.AutoSize = True
        Me.displaylabel.Location = New System.Drawing.Point(63, 244)
        Me.displaylabel.Name = "displaylabel"
        Me.displaylabel.Size = New System.Drawing.Size(0, 20)
        Me.displaylabel.TabIndex = 3
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(63, 60)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(183, 34)
        Me.txt_name.TabIndex = 4
        Me.txt_name.Text = ""
        '
        'txt_from
        '
        Me.txt_from.Location = New System.Drawing.Point(63, 135)
        Me.txt_from.Name = "txt_from"
        Me.txt_from.Size = New System.Drawing.Size(183, 34)
        Me.txt_from.TabIndex = 5
        Me.txt_from.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_from)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.displaylabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents displaylabel As Label
    Friend WithEvents txt_name As RichTextBox
    Friend WithEvents txt_from As RichTextBox
End Class
