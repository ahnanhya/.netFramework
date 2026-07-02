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
        MenuStrip1 = New MenuStrip()
        ColorToolStripMenuItem = New ToolStripMenuItem()
        RedToolStripMenuItem = New ToolStripMenuItem()
        GreenToolStripMenuItem = New ToolStripMenuItem()
        YellowToolStripMenuItem = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        CutToolStripMenuItem = New ToolStripMenuItem()
        CopyToolStripMenuItem = New ToolStripMenuItem()
        PasteToolStripMenuItem = New ToolStripMenuItem()
        TextBox1 = New TextBox()
        Label1 = New Label()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ColorToolStripMenuItem, EditToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(440, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "color"
        ' 
        ' ColorToolStripMenuItem
        ' 
        ColorToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {RedToolStripMenuItem, GreenToolStripMenuItem, YellowToolStripMenuItem})
        ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        ColorToolStripMenuItem.Size = New Size(57, 24)
        ColorToolStripMenuItem.Text = "color"
        ' 
        ' RedToolStripMenuItem
        ' 
        RedToolStripMenuItem.Name = "RedToolStripMenuItem"
        RedToolStripMenuItem.Size = New Size(135, 26)
        RedToolStripMenuItem.Text = "red"
        ' 
        ' GreenToolStripMenuItem
        ' 
        GreenToolStripMenuItem.Name = "GreenToolStripMenuItem"
        GreenToolStripMenuItem.Size = New Size(135, 26)
        GreenToolStripMenuItem.Text = "green"
        ' 
        ' YellowToolStripMenuItem
        ' 
        YellowToolStripMenuItem.Name = "YellowToolStripMenuItem"
        YellowToolStripMenuItem.Size = New Size(135, 26)
        YellowToolStripMenuItem.Text = "yellow"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CutToolStripMenuItem, CopyToolStripMenuItem, PasteToolStripMenuItem})
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(49, 24)
        EditToolStripMenuItem.Text = "edit"
        ' 
        ' CutToolStripMenuItem
        ' 
        CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        CutToolStripMenuItem.Size = New Size(128, 26)
        CutToolStripMenuItem.Text = "cut"
        ' 
        ' CopyToolStripMenuItem
        ' 
        CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        CopyToolStripMenuItem.Size = New Size(128, 26)
        CopyToolStripMenuItem.Text = "copy"
        ' 
        ' PasteToolStripMenuItem
        ' 
        PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        PasteToolStripMenuItem.Size = New Size(128, 26)
        PasteToolStripMenuItem.Text = "paste"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.WindowFrame
        TextBox1.ForeColor = SystemColors.WindowFrame
        TextBox1.Location = New Point(123, 182)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(145, 76)
        TextBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(123, 159)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 20)
        Label1.TabIndex = 2
        Label1.Text = "OUTPUT"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(440, 450)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YellowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label

End Class
