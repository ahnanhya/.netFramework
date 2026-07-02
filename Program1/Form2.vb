Public Class CollegeApplicationForm
    Private num As String = ""
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear() ' Clears default items to prevent duplicates
        ComboBox1.Items.Add("UG")
        ComboBox1.Items.Add("PG")
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem Is Nothing Then Exit Sub

        Dim selectedDegree As String = ComboBox1.SelectedItem.ToString()

        If selectedDegree = "UG" Then
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("BCA")
            ComboBox2.Items.Add("BBA")
            ComboBox2.Items.Add("BSC")
        ElseIf selectedDegree = "PG" Then
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("MCA")
            ComboBox2.Items.Add("MBA")
            ComboBox2.Items.Add("MSC")
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        num = TextBox7.Text.Trim()

        ' Check if the length is exactly 10
        If num.Length = 10 Then
            MessageBox.Show("THANK YOU")
        Else
            MessageBox.Show("Invalid! The phone number must be exactly 10 digits long.",
                            "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox7.Focus()
        End If
        If Not TextBox8.Text.EndsWith("@gmail.com") Then
            MessageBox.Show("Invalid email! You must enter an email address ending with @gmail.com.",
                            "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox8.Focus()
            Exit Sub
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            CheckBox2.Checked = False
        End If
    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            CheckBox1.Checked = False
        End If
    End Sub
End Class
