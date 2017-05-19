<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReplaceForm
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FindNextButton = New System.Windows.Forms.Button()
        Me.ReplaceButton = New System.Windows.Forms.Button()
        Me.ReplaceAllButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.MatchCaseCheckBox = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(104, 17)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(224, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(104, 50)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(224, 20)
        Me.TextBox2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Find what:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Replace with:"
        '
        'FindNextButton
        '
        Me.FindNextButton.Location = New System.Drawing.Point(338, 15)
        Me.FindNextButton.Name = "FindNextButton"
        Me.FindNextButton.Size = New System.Drawing.Size(83, 23)
        Me.FindNextButton.TabIndex = 4
        Me.FindNextButton.Text = "Find Next"
        Me.FindNextButton.UseVisualStyleBackColor = True
        '
        'ReplaceButton
        '
        Me.ReplaceButton.Location = New System.Drawing.Point(338, 48)
        Me.ReplaceButton.Name = "ReplaceButton"
        Me.ReplaceButton.Size = New System.Drawing.Size(83, 23)
        Me.ReplaceButton.TabIndex = 5
        Me.ReplaceButton.Text = "Replace"
        Me.ReplaceButton.UseVisualStyleBackColor = True
        '
        'ReplaceAllButton
        '
        Me.ReplaceAllButton.Location = New System.Drawing.Point(338, 88)
        Me.ReplaceAllButton.Name = "ReplaceAllButton"
        Me.ReplaceAllButton.Size = New System.Drawing.Size(83, 23)
        Me.ReplaceAllButton.TabIndex = 6
        Me.ReplaceAllButton.Text = "Replace All"
        Me.ReplaceAllButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(338, 117)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(83, 23)
        Me.CancelButton.TabIndex = 7
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'MatchCaseCheckBox
        '
        Me.MatchCaseCheckBox.AutoSize = True
        Me.MatchCaseCheckBox.Location = New System.Drawing.Point(12, 117)
        Me.MatchCaseCheckBox.Name = "MatchCaseCheckBox"
        Me.MatchCaseCheckBox.Size = New System.Drawing.Size(80, 17)
        Me.MatchCaseCheckBox.TabIndex = 8
        Me.MatchCaseCheckBox.Text = "Match case"
        Me.MatchCaseCheckBox.UseVisualStyleBackColor = True
        '
        'ReplaceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 149)
        Me.Controls.Add(Me.MatchCaseCheckBox)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.ReplaceAllButton)
        Me.Controls.Add(Me.ReplaceButton)
        Me.Controls.Add(Me.FindNextButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "ReplaceForm"
        Me.Text = "Replace"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FindNextButton As Button
    Friend WithEvents ReplaceButton As Button
    Friend WithEvents ReplaceAllButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents MatchCaseCheckBox As CheckBox
End Class
