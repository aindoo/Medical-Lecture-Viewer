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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenVideoFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenTimetrackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecentFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HotkeysToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Skip3SecondsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditTimetrackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.AxWindowsMediaPlayer2 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.ShiftSkip10SecondsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SkipToPreviousnextSlideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeSpeedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpacebarPauseplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(11, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Resume Video"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Timer1
        '
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(11, 36)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Start from Beginning"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(636, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "             "
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(268, 95)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(145, 67)
        Me.Panel1.TabIndex = 13
        Me.Panel1.Visible = False
        '
        'Timer4
        '
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.TextBox3)
        Me.Panel2.Controls.Add(Me.TrackBar1)
        Me.Panel2.Location = New System.Drawing.Point(610, 336)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(279, 76)
        Me.Panel2.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(86, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "00:00:00 / 00:00:00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(145, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(12, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "/"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(116, 48)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(23, 20)
        Me.TextBox3.TabIndex = 0
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(2, 24)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(267, 45)
        Me.TrackBar1.TabIndex = 7
        Me.TrackBar1.TabStop = False
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(723, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 18)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "             "
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1013, 24)
        Me.MenuStrip1.TabIndex = 17
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenVideoFileToolStripMenuItem, Me.OpenTimetrackToolStripMenuItem, Me.RecentFilesToolStripMenuItem, Me.HotkeysToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenVideoFileToolStripMenuItem
        '
        Me.OpenVideoFileToolStripMenuItem.Name = "OpenVideoFileToolStripMenuItem"
        Me.OpenVideoFileToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.OpenVideoFileToolStripMenuItem.Text = "Open Video"
        '
        'OpenTimetrackToolStripMenuItem
        '
        Me.OpenTimetrackToolStripMenuItem.Name = "OpenTimetrackToolStripMenuItem"
        Me.OpenTimetrackToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.OpenTimetrackToolStripMenuItem.Text = "Open Timetrack"
        '
        'RecentFilesToolStripMenuItem
        '
        Me.RecentFilesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6, Me.ToolStripMenuItem7, Me.ToolStripMenuItem8, Me.ToolStripMenuItem9, Me.ToolStripMenuItem10, Me.ToolStripMenuItem11})
        Me.RecentFilesToolStripMenuItem.Name = "RecentFilesToolStripMenuItem"
        Me.RecentFilesToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.RecentFilesToolStripMenuItem.Text = "Recent Files"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripMenuItem2.Text = "1"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripMenuItem3.Text = "2"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripMenuItem4.Text = "3"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripMenuItem5.Text = "4"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripMenuItem6.Text = "5"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripMenuItem7.Text = "6"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripMenuItem8.Text = "7"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripMenuItem9.Text = "8"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripMenuItem10.Text = "9"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripMenuItem11.Text = "10"
        '
        'HotkeysToolStripMenuItem
        '
        Me.HotkeysToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Skip3SecondsToolStripMenuItem, Me.ShiftSkip10SecondsToolStripMenuItem, Me.SkipToPreviousnextSlideToolStripMenuItem, Me.ChangeSpeedToolStripMenuItem, Me.SpacebarPauseplayToolStripMenuItem})
        Me.HotkeysToolStripMenuItem.Name = "HotkeysToolStripMenuItem"
        Me.HotkeysToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.HotkeysToolStripMenuItem.Text = "Hotkeys"
        '
        'Skip3SecondsToolStripMenuItem
        '
        Me.Skip3SecondsToolStripMenuItem.Name = "Skip3SecondsToolStripMenuItem"
        Me.Skip3SecondsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Skip3SecondsToolStripMenuItem.Text = "<>  - skip 3 seconds"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.CloseToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditTimetrackToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'EditTimetrackToolStripMenuItem
        '
        Me.EditTimetrackToolStripMenuItem.Name = "EditTimetrackToolStripMenuItem"
        Me.EditTimetrackToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.EditTimetrackToolStripMenuItem.Text = "New Timetrack"
        '
        'Timer5
        '
        Me.Timer5.Interval = 2000
        '
        'AxWindowsMediaPlayer2
        '
        Me.AxWindowsMediaPlayer2.Enabled = True
        Me.AxWindowsMediaPlayer2.Location = New System.Drawing.Point(552, 183)
        Me.AxWindowsMediaPlayer2.Name = "AxWindowsMediaPlayer2"
        Me.AxWindowsMediaPlayer2.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer2.Size = New System.Drawing.Size(236, 147)
        Me.AxWindowsMediaPlayer2.TabIndex = 14
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.AllowDrop = True
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(-1, 63)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(588, 412)
        Me.AxWindowsMediaPlayer1.TabIndex = 0
        '
        'ShiftSkip10SecondsToolStripMenuItem
        '
        Me.ShiftSkip10SecondsToolStripMenuItem.Name = "ShiftSkip10SecondsToolStripMenuItem"
        Me.ShiftSkip10SecondsToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.ShiftSkip10SecondsToolStripMenuItem.Text = "Shift+ <> - skip 10 seconds"
        '
        'SkipToPreviousnextSlideToolStripMenuItem
        '
        Me.SkipToPreviousnextSlideToolStripMenuItem.Name = "SkipToPreviousnextSlideToolStripMenuItem"
        Me.SkipToPreviousnextSlideToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.SkipToPreviousnextSlideToolStripMenuItem.Text = "1,3 - skip to previous/next slide"
        '
        'ChangeSpeedToolStripMenuItem
        '
        Me.ChangeSpeedToolStripMenuItem.Name = "ChangeSpeedToolStripMenuItem"
        Me.ChangeSpeedToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.ChangeSpeedToolStripMenuItem.Text = "[,] - change speed"
        '
        'SpacebarPauseplayToolStripMenuItem
        '
        Me.SpacebarPauseplayToolStripMenuItem.Name = "SpacebarPauseplayToolStripMenuItem"
        Me.SpacebarPauseplayToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.SpacebarPauseplayToolStripMenuItem.Text = "spacebar - pause/play"
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 527)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.AxWindowsMediaPlayer2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "AMS EchoViewer v1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.AxWindowsMediaPlayer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents AxWindowsMediaPlayer2 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenVideoFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenTimetrackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditTimetrackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer5 As System.Windows.Forms.Timer
    Friend WithEvents RecentFilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HotkeysToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Skip3SecondsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShiftSkip10SecondsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SkipToPreviousnextSlideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeSpeedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpacebarPauseplayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
