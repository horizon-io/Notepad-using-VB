<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FontsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FontListBox = New System.Windows.Forms.ListBox()
        Me.FontStyleListBox = New System.Windows.Forms.ListBox()
        Me.SizeListBox = New System.Windows.Forms.ListBox()
        Me.SizeTextBox = New System.Windows.Forms.TextBox()
        Me.FontStyleTextBox = New System.Windows.Forms.TextBox()
        Me.FontTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OkButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SampleLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FontListBox
        '
        Me.FontListBox.FormattingEnabled = True
        Me.FontListBox.Items.AddRange(New Object() {"Consolas", "Constantina", "Copperplate Gothic", "Tahoma", "Vladimir Script"})
        Me.FontListBox.Location = New System.Drawing.Point(12, 54)
        Me.FontListBox.Name = "FontListBox"
        Me.FontListBox.Size = New System.Drawing.Size(110, 134)
        Me.FontListBox.TabIndex = 0
        '
        'FontStyleListBox
        '
        Me.FontStyleListBox.FormattingEnabled = True
        Me.FontStyleListBox.Items.AddRange(New Object() {"Regular", "Italic", "Bold", "Bold Italic"})
        Me.FontStyleListBox.Location = New System.Drawing.Point(142, 54)
        Me.FontStyleListBox.Name = "FontStyleListBox"
        Me.FontStyleListBox.Size = New System.Drawing.Size(104, 134)
        Me.FontStyleListBox.TabIndex = 1
        '
        'SizeListBox
        '
        Me.SizeListBox.FormattingEnabled = True
        Me.SizeListBox.Items.AddRange(New Object() {"8", "10", "12", "14", "16", "20", "24"})
        Me.SizeListBox.Location = New System.Drawing.Point(264, 54)
        Me.SizeListBox.Name = "SizeListBox"
        Me.SizeListBox.Size = New System.Drawing.Size(71, 134)
        Me.SizeListBox.TabIndex = 2
        '
        'SizeTextBox
        '
        Me.SizeTextBox.Location = New System.Drawing.Point(264, 32)
        Me.SizeTextBox.Name = "SizeTextBox"
        Me.SizeTextBox.Size = New System.Drawing.Size(71, 20)
        Me.SizeTextBox.TabIndex = 3
        '
        'FontStyleTextBox
        '
        Me.FontStyleTextBox.Location = New System.Drawing.Point(142, 32)
        Me.FontStyleTextBox.Name = "FontStyleTextBox"
        Me.FontStyleTextBox.Size = New System.Drawing.Size(104, 20)
        Me.FontStyleTextBox.TabIndex = 4
        '
        'FontTextBox
        '
        Me.FontTextBox.Location = New System.Drawing.Point(12, 32)
        Me.FontTextBox.Name = "FontTextBox"
        Me.FontTextBox.Size = New System.Drawing.Size(110, 20)
        Me.FontTextBox.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(261, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Size:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Font:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(139, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Font Style:"
        '
        'OkButton
        '
        Me.OkButton.Location = New System.Drawing.Point(179, 318)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(75, 23)
        Me.OkButton.TabIndex = 9
        Me.OkButton.Text = "OK"
        Me.OkButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(260, 318)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 10
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SampleLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(142, 203)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(193, 100)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sample"
        '
        'SampleLabel
        '
        Me.SampleLabel.AutoSize = True
        Me.SampleLabel.Location = New System.Drawing.Point(69, 46)
        Me.SampleLabel.Name = "SampleLabel"
        Me.SampleLabel.Size = New System.Drawing.Size(55, 13)
        Me.SampleLabel.TabIndex = 0
        Me.SampleLabel.Text = "AaBbYyZz"
        Me.SampleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FontsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 353)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.OkButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FontTextBox)
        Me.Controls.Add(Me.FontStyleTextBox)
        Me.Controls.Add(Me.SizeTextBox)
        Me.Controls.Add(Me.SizeListBox)
        Me.Controls.Add(Me.FontStyleListBox)
        Me.Controls.Add(Me.FontListBox)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FontsForm"
        Me.ShowIcon = False
        Me.Text = "Fonts"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FontListBox As ListBox
    Friend WithEvents FontStyleListBox As ListBox
    Friend WithEvents SizeListBox As ListBox
    Friend WithEvents SizeTextBox As TextBox
    Friend WithEvents FontStyleTextBox As TextBox
    Friend WithEvents FontTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents OkButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SampleLabel As Label
End Class
