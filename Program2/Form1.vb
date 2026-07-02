Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim Students() As String
    Dim n As Integer
    Dim count As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If count < n Then
            If TextBox1.Text.Trim() <> "" Then
                Students(count) = TextBox1.Text.Trim()
                count += 1
                MessageBox.Show(count & ") " & TextBox1.Text.Trim & " added successfully!")
                TextBox1.Clear()
                TextBox1.Focus()
            Else
                MessageBox.Show("Please enter a name.")
            End If
        Else
            MessageBox.Show("You can only add " & n & " names.")
        End If
    End Sub
    Private Sub List_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListView1.Items.Clear()
        For i As Integer = 0 To count - 1
            ListView1.Items.Add(i + 1 & ") " & Students(i))
        Next
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        n = InputBox("Enter the number of names", "ARRAYS AND CONTROL STRUCTURES")
        ReDim Students(n)
    End Sub
End Class
