Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        TextBox1.BackColor = Color.Aqua
        TextBox1.ForeColor = Color.Chocolate
        TextBox4.Text = "mouse entered"
    End Sub
    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged
        TextBox2.BackColor = Color.AliceBlue
        TextBox2.ForeColor = Color.Black
        TextBox4.Text = "mouse leave"
    End Sub
    Private Sub TextBox3_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox3.TextChanged
        TextBox3.BackColor = Color.Bisque
        TextBox3.ForeColor = Color.CadetBlue
        TextBox4.Text = "mouse up"
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        MsgBox("THANK YOU""" + TextBox2.Text + """FOR YOUR KIND CO_OPERATION")
    End Sub
End Class