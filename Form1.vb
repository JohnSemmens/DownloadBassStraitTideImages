Imports System.IO
Imports System.Net
Imports System.Runtime.InteropServices
Imports System.Security.Policy
Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class Form1

    Dim BaseDate As Date
    Dim localFolder As String
    Dim url As String

    Dim YearString As String
    Dim DateString As String
    Dim DayString As String

    Dim urlBase As String
    Dim LocalPathBase As String

    Dim imageUrl As String
    Dim localFile As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdatePaths()
        UpdateFullPaths(0)
    End Sub

    Private Sub DownloadButton_Click(sender As Object, e As EventArgs) Handles DownloadButton.Click
        DownloadButton.Enabled = False
        Cursor = Cursors.WaitCursor

        Try

            ' Loop through the suffixes 00 to 23
            For hour As Integer = 0 To 23
                UpdateFullPaths(hour)

                ' make sure the folder exists
                ' Parse the file name to get the directory path
                Dim filePath As String = Path.GetDirectoryName(localFile)

                ' Check if the directory exists
                If Not Directory.Exists(filePath) Then
                    ' If the directory does not exist, create it
                    Directory.CreateDirectory(filePath)
                End If

                ' Create a new WebClient instance
                Dim client As WebClient = New WebClient()

                ' Download the image from the URL and save it to the local file

                client.DownloadFile(imageUrl, localFile)



                ' Dispose of the WebClient instance to free up resources
                client.Dispose()
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message + vbCrLf + vbCrLf + imageUrl)
        End Try

        Cursor = Cursors.Default
        DownloadButton.Enabled = True
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        UpdatePaths()
        UpdateFullPaths(0)
    End Sub


    Private Sub UpdatePaths()

        localFolder = localfolderTextBox.Text
        url = urlTextBox.Text

        BaseDate = DateTimePicker1.Value

        YearString = BaseDate.ToString("yyyy")
        DateString = BaseDate.ToString("yyyyMMdd")
        DayString = BaseDate.ToString("dd")

        urlBase = urlTextBox.Text + "/" + YearString + "/" + DateString
        LocalPathBase = localfolderTextBox.Text + "\" + DayString + "\" + DateString
    End Sub


    Private Sub UpdateFullPaths(hour As Integer)
        ' Construct the full image URL
        imageUrl = urlBase & hour.ToString("00") & ".gif"
        ' Construct the full local file path
        localFile = LocalPathBase & hour.ToString("00") & ".gif"

        FolderLabel.Text = localFile
        FolderLabel.Refresh()

        urlLabel.Text = imageUrl
        urlLabel.Refresh()
    End Sub

    Private Sub localfolderTextBox_TextChanged(sender As Object, e As EventArgs) Handles localfolderTextBox.TextChanged
        UpdatePaths()
        UpdateFullPaths(0)
    End Sub

    Private Sub urlTextBox_TextChanged(sender As Object, e As EventArgs) Handles urlTextBox.TextChanged
        UpdatePaths()
        UpdateFullPaths(0)
    End Sub

    Private Sub FolderBrowseButton_Click(sender As Object, e As EventArgs) Handles FolderBrowseButton.Click

        FolderBrowserDialog1.SelectedPath = localfolderTextBox.Text

        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            localfolderTextBox.Text = FolderBrowserDialog1.SelectedPath
        End If

    End Sub
End Class
