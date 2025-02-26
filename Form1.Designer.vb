<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DownloadButton = New System.Windows.Forms.Button()
        Me.urlTextBox = New System.Windows.Forms.TextBox()
        Me.localfolderTextBox = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.urlLabel = New System.Windows.Forms.Label()
        Me.FolderLabel = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.FolderBrowseButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DownloadButton
        '
        Me.DownloadButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DownloadButton.Location = New System.Drawing.Point(283, 125)
        Me.DownloadButton.Name = "DownloadButton"
        Me.DownloadButton.Size = New System.Drawing.Size(75, 36)
        Me.DownloadButton.TabIndex = 0
        Me.DownloadButton.Text = "Download"
        Me.DownloadButton.UseVisualStyleBackColor = True
        '
        'urlTextBox
        '
        Me.urlTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.urlTextBox.Location = New System.Drawing.Point(12, 62)
        Me.urlTextBox.Name = "urlTextBox"
        Me.urlTextBox.Size = New System.Drawing.Size(343, 20)
        Me.urlTextBox.TabIndex = 1
        Me.urlTextBox.Text = "https://oceancurrent.aodn.org.au/tides/Bass_spd"
        '
        'localfolderTextBox
        '
        Me.localfolderTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.localfolderTextBox.Location = New System.Drawing.Point(15, 188)
        Me.localfolderTextBox.Name = "localfolderTextBox"
        Me.localfolderTextBox.Size = New System.Drawing.Size(301, 20)
        Me.localfolderTextBox.TabIndex = 2
        Me.localfolderTextBox.Text = "C:\temp"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(12, 36)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'urlLabel
        '
        Me.urlLabel.AutoSize = True
        Me.urlLabel.Location = New System.Drawing.Point(12, 94)
        Me.urlLabel.Name = "urlLabel"
        Me.urlLabel.Size = New System.Drawing.Size(44, 13)
        Me.urlLabel.TabIndex = 4
        Me.urlLabel.Text = "urlLabel"
        '
        'FolderLabel
        '
        Me.FolderLabel.AutoSize = True
        Me.FolderLabel.Location = New System.Drawing.Point(12, 222)
        Me.FolderLabel.Name = "FolderLabel"
        Me.FolderLabel.Size = New System.Drawing.Size(62, 13)
        Me.FolderLabel.TabIndex = 5
        Me.FolderLabel.Text = "FolderLabel"
        '
        'FolderBrowseButton
        '
        Me.FolderBrowseButton.Location = New System.Drawing.Point(322, 188)
        Me.FolderBrowseButton.Name = "FolderBrowseButton"
        Me.FolderBrowseButton.Size = New System.Drawing.Size(33, 23)
        Me.FolderBrowseButton.TabIndex = 6
        Me.FolderBrowseButton.Text = "..."
        Me.FolderBrowseButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 261)
        Me.Controls.Add(Me.FolderBrowseButton)
        Me.Controls.Add(Me.FolderLabel)
        Me.Controls.Add(Me.urlLabel)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.localfolderTextBox)
        Me.Controls.Add(Me.urlTextBox)
        Me.Controls.Add(Me.DownloadButton)
        Me.MinimumSize = New System.Drawing.Size(410, 300)
        Me.Name = "Form1"
        Me.Text = "Download Bass Strait Tide Images"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DownloadButton As Button
    Friend WithEvents urlTextBox As TextBox
    Friend WithEvents localfolderTextBox As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents urlLabel As Label
    Friend WithEvents FolderLabel As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents FolderBrowseButton As Button
End Class
