<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        TextBox1 = New TextBox()
        ListView1 = New ListView()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(35, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(143, 20)
        Label1.TabIndex = 0
        Label1.Text = "Enter students name"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(199, 31)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(282, 27)
        TextBox1.TabIndex = 1
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(199, 82)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(282, 122)
        ListView1.TabIndex = 3
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.List
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(35, 82)
        Button1.Name = "Button1"
        Button1.Size = New Size(143, 52)
        Button1.TabIndex = 4
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(35, 153)
        Button2.Name = "Button2"
        Button2.Size = New Size(143, 51)
        Button2.TabIndex = 5
        Button2.Text = "Display"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(502, 232)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ListView1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Arrays and Control Structures"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

End Class
