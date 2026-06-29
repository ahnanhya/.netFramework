Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub RedToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RedToolStripMenuItem.Click
        TextBox1.ForeColor = Color.Red
    End Sub
    Private Sub GreenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GreenToolStripMenuItem.Click
        TextBox1.ForeColor = Color.Green
    End Sub
    Private Sub YellowToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles YellowToolStripMenuItem.Click
        TextBox1.ForeColor = Color.Yellow
    End Sub
    Private Sub CutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CutToolStripMenuItem.Click
        Clipboard.SetText(TextBox1.SelectedText)
        TextBox1.Text = ""
    End Sub
    Private Sub CopyToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        Clipboard.SetText(TextBox1.SelectedText)
    End Sub
    Private Sub PasteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        TextBox1.SelectedText = Clipboard.GetText
    End Sub
End Class