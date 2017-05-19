<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaveForm
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
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.DontSaveButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(105, 58)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 0
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'DontSaveButton
        '
        Me.DontSaveButton.Location = New System.Drawing.Point(186, 58)
        Me.DontSaveButton.Name = "DontSaveButton"
        Me.DontSaveButton.Size = New System.Drawing.Size(75, 23)
        Me.DontSaveButton.TabIndex = 1
        Me.DontSaveButton.Text = "Don't save"
        Me.DontSaveButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButton.Location = New System.Drawing.Point(267, 58)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 2
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Do you want to save changes to Untitled?"
        '
        'SaveForm
        '
        Me.AcceptButton = Me.SaveButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CancelButton
        Me.ClientSize = New System.Drawing.Size(354, 93)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.DontSaveButton)
        Me.Controls.Add(Me.SaveButton)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SaveForm"
        Me.ShowIcon = False
        Me.Text = "Save"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SaveButton As Button
    Friend WithEvents DontSaveButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents Label1 As Label
End Class
