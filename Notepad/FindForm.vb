Imports System.ComponentModel

Public Class FindForm

    Public Event FindNext As EventHandler(Of String)

    Private Sub FindNextButton_Click(sender As Object, e As EventArgs) Handles FindNextButton.Click
        RaiseEvent FindNext(Me, SearchTextBox.Text)
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Close()
    End Sub

    Private Sub FindForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = True

        Hide()
    End Sub
End Class