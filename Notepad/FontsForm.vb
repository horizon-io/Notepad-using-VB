Public Class FontsForm

    Private oldFont As Font

    Public Property ResultFont As Font

    Public Sub New(font As Font)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        oldFont = font
    End Sub

    Private Sub UpdateSampleFont()

        Try
            ResultFont = New Font(FontTextBox.Text,
                                    Convert.ToSingle(SizeTextBox.Text),
                                    StringToFontStyle(FontStyleTextBox.Text))

            SampleLabel.Font = ResultFont
            FontStyleListBox.Font = New Font(ResultFont.FontFamily, 8, ResultFont.Style)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub FontListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FontListBox.SelectedIndexChanged
        FontTextBox.Text = FontListBox.SelectedItem.ToString()

        UpdateSampleFont()
    End Sub

    Private Sub FontStyleListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FontStyleListBox.SelectedIndexChanged
        FontStyleTextBox.Text = FontStyleListBox.SelectedItem.ToString()

        UpdateSampleFont()
    End Sub

    Private Sub SizeListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SizeListBox.SelectedIndexChanged
        SizeTextBox.Text = SizeListBox.SelectedItem.ToString()

        UpdateSampleFont()
    End Sub

    Private Sub FontsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FontListBox.SelectedIndex = FontListBox.Items.IndexOf(oldFont.Name)

        SizeListBox.SelectedIndex = SizeListBox.Items.IndexOf(oldFont.Size.ToString())

        FontStyleListBox.SelectedIndex = FontStyleToIndex(oldFont.Style)

    End Sub

    Function FontStyleToIndex(s As FontStyle) As Integer

        Select Case s
            Case FontStyle.Regular
                Return 0
            Case FontStyle.Italic
                Return 1
            Case FontStyle.Bold
                Return 2
            Case Else
                Return 3
        End Select

    End Function

    Function StringToFontStyle(s As String) As FontStyle
        Dim style = FontStyle.Regular

        If s.Contains("Bold") Then
            style = style Or FontStyle.Bold ' 0000 OR 0001 = 0001
        End If
        If s.Contains("Italic") Then
            style = style Or FontStyle.Italic ' 0000 OR 0010 = 0010, 0001 OR 0010 = 0011
        End If

        Return style
    End Function

    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        DialogResult = DialogResult.OK

        Close()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        DialogResult = DialogResult.Cancel

        Close()
    End Sub
End Class