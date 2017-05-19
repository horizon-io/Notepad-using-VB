Imports System.Text.RegularExpressions
Public Class MainForm

    Sub CopyToClipBoard(ByVal input As String)
        Clipboard.SetText(input)
    End Sub

    Function PasteFromClipBoard()
        Return Clipboard.GetText()
    End Function

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        InputTextBox.Clear()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        InputTextBox.Undo()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        Dim index = InputTextBox.SelectionStart
        Dim length = InputTextBox.SelectionLength

        CopyToClipBoard(InputTextBox.SelectedText)

        InputTextBox.Text = InputTextBox.Text.Remove(index, length)

        InputTextBox.SelectionStart = index
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        CopyToClipBoard(InputTextBox.SelectedText)
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        Dim text As String = PasteFromClipBoard()

        Dim index = InputTextBox.SelectionStart

        InputTextBox.Text = InputTextBox.Text.Insert(index, text)

        InputTextBox.SelectionStart = index
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim index = InputTextBox.SelectionStart
        Dim length = InputTextBox.SelectionLength

        InputTextBox.Text = InputTextBox.Text.Remove(index, length)

        InputTextBox.SelectionStart = index
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        InputTextBox.SelectionStart = 0
        InputTextBox.SelectionLength = InputTextBox.Text.Length
    End Sub

    Private Sub DateTimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DateTimeToolStripMenuItem.Click

        Dim index = InputTextBox.SelectionStart

        Dim time = DateTime.Now.ToString()

        InputTextBox.Text = InputTextBox.Text.Insert(index, time)

        InputTextBox.SelectionStart = index + time.Length
    End Sub

    Private Sub WordWrapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WordWrapToolStripMenuItem.Click
        WordWrapToolStripMenuItem.Checked = Not WordWrapToolStripMenuItem.Checked

        InputTextBox.WordWrap = WordWrapToolStripMenuItem.Checked
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click

        Dim f As New FontsForm(InputTextBox.Font)

        If f.ShowDialog() = DialogResult.OK Then
            InputTextBox.Font = f.ResultFont
        End If

    End Sub

    Dim WithEvents find As New FindForm

    Dim searchResults As MatchCollection

    Dim searchIndex As Integer

    Private Sub GoToNextResult()

        Dim result = searchResults(searchIndex)

        InputTextBox.SelectionStart = result.Index
        InputTextBox.SelectionLength = result.Length
        InputTextBox.HideSelection = False
        InputTextBox.ScrollToCaret()

        searchIndex += 1

        If searchIndex = searchResults.Count Then
            MessageBox.Show("No other matches")
            searchResults = Nothing
            searchIndex = 0
        End If
    End Sub

    Public Sub FindNext(sender As Object, e As String) Handles find.FindNext

        If searchResults Is Nothing Then
            searchResults = Regex.Matches(InputTextBox.Text, e)

            GoToNextResult()
        Else
            GoToNextResult()
        End If

    End Sub

    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click
        find.Show()
    End Sub

    Private Sub FindNextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindNextToolStripMenuItem.Click
        GoToNextResult()
    End Sub

    Private Sub ReplaceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReplaceToolStripMenuItem.Click

    End Sub
End Class
