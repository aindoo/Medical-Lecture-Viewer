Imports System.IO

Public Class Form1
    Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Int32) As Int16
    Dim strm As System.IO.Stream
    Dim timestamps() As Integer
    Dim timestampsi As Integer
    Dim timestampsi2 As Integer
    Dim t As Integer
    Dim myData As String = "1"
    Dim totaldur As Integer
    Dim historyfile As String
    Dim newarray(500) As Decimal
    Dim editingtimes As Integer
    Dim counter As Integer
    Dim confirmadd As Integer
    Dim currplace As Integer
    Dim recentvidstxtfile As String = "C:\EchoViewer\StreamHistory\recentlist.txt"


    ' GUI ELEMENTS
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer5.Enabled = False
        TrackBar1.Enabled = False

        'setting up element positions

        AxWindowsMediaPlayer1.Top = 0
        AxWindowsMediaPlayer1.Left = 0
        AxWindowsMediaPlayer1.Width = Me.Width
        AxWindowsMediaPlayer1.Height = Me.Height
        AxWindowsMediaPlayer2.Top = AxWindowsMediaPlayer1.Height - AxWindowsMediaPlayer2.Height - Panel2.Height * 2
        AxWindowsMediaPlayer2.Left = Me.Width / 2 - AxWindowsMediaPlayer2.Width / 2
        AxWindowsMediaPlayer2.Visible = False
        AxWindowsMediaPlayer2.settings.mute = True
        Panel1.Top = Me.Height / 2 - Panel2.Height / 2
        Panel2.Left = Me.Width / 2 - Panel2.Width / 2
        Panel2.Top = AxWindowsMediaPlayer1.Height - Panel2.Height * 2
        Panel2.Left = Me.Width / 2 - Panel2.Width / 2

        Label1.Top = 0
        Label2.Top = 0
        Label1.Left = 0
        Label2.Left = Me.Width - 50


        If System.IO.File.Exists(recentvidstxtfile) = True Then
            Dim recentvidstxt As String = System.IO.File.ReadAllText(recentvidstxtfile) 'get your data
            Dim recentvidslist As String() = recentvidstxt.Split(New String() {Environment.NewLine},
                                       StringSplitOptions.None)
            ToolStripMenuItem2.Text = recentvidslist(0)
            ToolStripMenuItem3.Text = recentvidslist(1)
            ToolStripMenuItem4.Text = recentvidslist(2)
            ToolStripMenuItem5.Text = recentvidslist(3)
            ToolStripMenuItem6.Text = recentvidslist(4)
            ToolStripMenuItem7.Text = recentvidslist(5)
            ToolStripMenuItem8.Text = recentvidslist(6)
            ToolStripMenuItem9.Text = recentvidslist(7)
            ToolStripMenuItem10.Text = recentvidslist(8)
            ToolStripMenuItem11.Text = recentvidslist(9)

        Else
            If (Not System.IO.Directory.Exists("C:\EchoViewer\StreamHistory\")) Then
                System.IO.Directory.CreateDirectory("C:\EchoViewer\StreamHistory\")
            End If
            Dim objWriter As New System.IO.StreamWriter(recentvidstxtfile)
            objWriter.WriteLine("")
            objWriter.WriteLine("")
            objWriter.WriteLine("")
            objWriter.WriteLine("")
            objWriter.WriteLine("")
            objWriter.WriteLine("")
            objWriter.WriteLine("")
            objWriter.WriteLine("")
            objWriter.WriteLine("")
            objWriter.WriteLine("")
            objWriter.Close()
        End If

    End Sub
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        AxWindowsMediaPlayer1.Top = 0
        AxWindowsMediaPlayer1.Left = 0
        AxWindowsMediaPlayer1.Width = Me.Width
        AxWindowsMediaPlayer1.Height = Me.Height
        AxWindowsMediaPlayer2.Top = AxWindowsMediaPlayer1.Height - AxWindowsMediaPlayer2.Height - Panel2.Height * 2
        AxWindowsMediaPlayer2.Left = Me.Width / 2 - AxWindowsMediaPlayer2.Width / 2


        Panel2.Top = AxWindowsMediaPlayer1.Height - Panel2.Height * 2
        Panel2.Left = Me.Width / 2 - Panel2.Width / 2
        Label1.Top = 0
        Label2.Top = 0
        Label1.Left = 0
        Label2.Left = Me.Width - 50

    End Sub
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub AxWindowsMediaPlayer1_MouseMoveEvent(sender As Object, e As AxWMPLib._WMPOCXEvents_MouseMoveEvent) Handles AxWindowsMediaPlayer1.MouseMoveEvent
        If (e.fY > AxWindowsMediaPlayer1.Height - Panel2.Height * 2) Then
            Panel2.Visible = True
        Else
            Panel2.Visible = False
        End If
        If (e.fY < MenuStrip1.Height * 2) Then
            MenuStrip1.Visible = True
        Else
            MenuStrip1.Visible = False
        End If

    End Sub
    Private Sub EditTimetrackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditTimetrackToolStripMenuItem.Click
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
        MessageBox.Show("Down Button = bookmark framechange positions" & vbNewLine & "Up Button = finish adding")
        editingtimes = 1
    End Sub

    ' BACK-END VIDEO LOADING TIMESTAMPS
    Private Sub OpenVideoFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenVideoFileToolStripMenuItem.Click
        OpenFileDialog1.Title = "Please Select a Lecture Video"
        OpenFileDialog1.Filter = "M4V files (*.m4v)|*.m4v|AVI files (*.avi)|*.avi|MP4 files (*.mp4)|*.mp4|MPEG files (*.mpeg)|*.mpeg|All files (*.*)|*.*"
        OpenFileDialog1.InitialDirectory = OpenFileDialog1.RestoreDirectory
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.ShowDialog()
        Timer5.Enabled = False
    End Sub
    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        strm = OpenFileDialog1.OpenFile()
        Dim fi As New FileInfo(OpenFileDialog1.FileName.ToString())
        AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName.ToString()
        AxWindowsMediaPlayer2.URL = OpenFileDialog1.FileName.ToString()
        AxWindowsMediaPlayer2.settings.mute = True
        Timer4.Enabled = True
        Me.Text = "AMS EchoViewer v1 - " & fi.Name.ToString
        editingtimes = 0
        counter = 0

        '  RECALL LAST PLAYBACK POSITION FOR CURRENT VIDEO FILE
        historyfile = "C:\EchoViewer\StreamHistory\" & fi.Name.ToString & "-history.txt"
        If System.IO.File.Exists(historyfile) = True Then
            AxWindowsMediaPlayer1.Ctlcontrols.pause()
            Panel1.Visible = True
        Else
            If (Not System.IO.Directory.Exists("C:\EchoViewer\StreamHistory\")) Then
                System.IO.Directory.CreateDirectory("C:\EchoViewer\StreamHistory\")
            End If
            Dim objWriter As New System.IO.StreamWriter(historyfile)
            objWriter.Write("1")
            objWriter.Close()
            Timer5.Enabled = True
        End If

        '  ADD NEW ITEM TO RECENTLY OPENED FILE LIST
        Dim recentvidstxt As String = System.IO.File.ReadAllText(recentvidstxtfile) 'get your data
        Dim recentvidslist As String() = recentvidstxt.Split(New String() {Environment.NewLine},
                                   StringSplitOptions.None)

        Dim text As New System.IO.StreamWriter(recentvidstxtfile)
        text.WriteLine(OpenFileDialog1.FileName.ToString())
        text.WriteLine(recentvidslist(0))
        text.WriteLine(recentvidslist(1))
        text.WriteLine(recentvidslist(2))
        text.WriteLine(recentvidslist(3))
        text.WriteLine(recentvidslist(4))
        text.WriteLine(recentvidslist(5))
        text.WriteLine(recentvidslist(6))
        text.WriteLine(recentvidslist(7))
        text.WriteLine(recentvidslist(8))
        text.Close()


    End Sub
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick

        If (AxWindowsMediaPlayer1.currentMedia.duration <> 0 And myData = "1") Then

            totaldur = AxWindowsMediaPlayer1.currentMedia.duration * 10

            For i As Integer = 0 To 99
                myData = String.Join(",", myData, Math.Round((totaldur / 100)) * (i + 1))
            Next

            timestamps = (From s As Integer In myData.Split(","c)).ToArray

            Timer1.Enabled = True
            TrackBar1.Minimum = 0
            TrackBar1.Maximum = timestamps.Length - 1
            TrackBar1.Enabled = True
            Label5.Text = "/" & timestamps.Length
            AxWindowsMediaPlayer1.Ctlcontrols.pause()
            Timer4.Enabled = False
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim prevposition As Integer = System.IO.File.ReadAllText(historyfile)
        AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = prevposition
        AxWindowsMediaPlayer1.Ctlcontrols.play()
        Timer5.Enabled = True
        Panel1.Visible = False
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = 1
        AxWindowsMediaPlayer1.Ctlcontrols.play()
        Timer5.Enabled = True
        Panel1.Visible = False

    End Sub
    Private Sub OpenTimetrackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenTimetrackToolStripMenuItem.Click
        OpenFileDialog2.Title = "Please Select a Timestamp File"
        OpenFileDialog2.Filter = "TXT files (*.txt)|*.txt|All files (*.*)|*.*"
        OpenFileDialog2.FileName = ""
        OpenFileDialog2.InitialDirectory = OpenFileDialog1.RestoreDirectory
        OpenFileDialog2.ShowDialog()
    End Sub
    Private Sub OpenFileDialog2_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog2.FileOk
        strm = OpenFileDialog2.OpenFile()
        Dim myData As String = System.IO.File.ReadAllText(OpenFileDialog2.FileName.ToString()) 'get your data
        timestamps = (From s As Integer In myData.Split(","c)).ToArray
        Timer1.Enabled = True
        TrackBar1.Minimum = 0
        TrackBar1.Maximum = timestamps.Length - 1
        TrackBar1.Enabled = True
        Label5.Text = "/" & timestamps.Length

    End Sub

    ' VIDEO TRACKING
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        Dim currenttime As Integer = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition
        Dim currentframe As Integer = currenttime * 10

        For i = 0 To timestamps.Length - 2
            If (currentframe >= timestamps(i) + 10 And currentframe < timestamps(i + 1)) Then
                timestampsi = i
                timestampsi2 = i

            ElseIf (currentframe >= timestamps(i) And currentframe < timestamps(i) + 10) Then
                timestampsi = i
                timestampsi2 = i - 1
            End If
        Next
        If (Label1.Text = "    ") Then
            TrackBar1.Value = timestampsi
        End If
        TextBox3.Text = timestampsi
        Label6.Text = AxWindowsMediaPlayer1.Ctlcontrols.currentPositionString & " / " & AxWindowsMediaPlayer1.currentMedia.durationString

    End Sub
    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Dim objWriter As New System.IO.StreamWriter(historyfile)
        objWriter.Write(AxWindowsMediaPlayer1.Ctlcontrols.currentPosition)
        objWriter.Close()
    End Sub
    'by keyboard
    Public Sub Form1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        If (e.Alt And e.KeyCode = 13) Then   'Toggle fullscreen by pressing Alt+Enter
            If Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable Then
                Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Else
                Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            End If
        End If

        If (e.KeyCode = 37 And AxWindowsMediaPlayer1.URL <> "") Then  'REWIND 3s BY PRESSING left
            AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition - 3
        End If
        If (e.KeyCode = 39 And AxWindowsMediaPlayer1.URL <> "") Then  'FASTFORWARD 3S BY PRESSING RIGHT
            AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition + 3
        End If
        If (e.Shift And e.KeyCode = 37 And AxWindowsMediaPlayer1.URL <> "") Then  'REWIND 10s BY PRESSING shift left
            AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition - 10
        End If
        If (e.Shift And e.KeyCode = 39 And AxWindowsMediaPlayer1.URL <> "") Then  'FASTFORWARD 10S BY PRESSING shift RIGHT
            AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition + 10
        End If

        If (e.KeyCode = 49 And AxWindowsMediaPlayer1.URL <> "") Then  'REWIND TO PREVIOUS RELEVANT SLIDE BY PRESSING 1
            AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = timestamps(timestampsi2) / 10
        End If

        If (e.KeyCode = 51 And AxWindowsMediaPlayer1.URL <> "") Then 'FASTFORWARD TO NEXT RELEVANT SLIDE BY PRESSING 3
            AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = timestamps(timestampsi + 1) / 10
        End If
        If (e.KeyCode = 32 And AxWindowsMediaPlayer1.URL <> "") Then 'PAUSE PLAY WITH SPACEBAR
            If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPaused Then
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            ElseIf AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying Then
                AxWindowsMediaPlayer1.Ctlcontrols.pause()
            End If
        End If
        If (e.KeyCode = 221 And AxWindowsMediaPlayer1.URL <> "") Then  'SPEED UP BY INCREMENT 0.1 WITH PRESSING ]'
            AxWindowsMediaPlayer1.settings.rate = AxWindowsMediaPlayer1.settings.rate + 0.1
            t = 0
            Timer2.Enabled = True
            Dim rate As Decimal = Math.Round(AxWindowsMediaPlayer1.settings.rate, 2)
            Label2.Text = rate
        End If
        If (e.KeyCode = 219 And AxWindowsMediaPlayer1.URL <> "") Then 'SLOWDOWN BY INCREMENT 0.1 WITH PRESSING ['
            AxWindowsMediaPlayer1.settings.rate = AxWindowsMediaPlayer1.settings.rate - 0.1
            t = 0
            Timer2.Enabled = True
            Dim rate As Decimal = Math.Round(AxWindowsMediaPlayer1.settings.rate, 2)
            Label2.Text = rate
        End If

        If (e.KeyCode = 40 And AxWindowsMediaPlayer1.URL <> "" And editingtimes = 1) Then   'TRIGGER BOOKMARK BY PRESSING DOWN BTN
            Timer2.Enabled = True
            confirmadd = confirmadd + 1
            If confirmadd = 1 Then
                currplace = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition * 10
                Label1.Text = "Confirm bookmark?"
            ElseIf confirmadd = 2 Then
                newarray(counter) = currplace
                counter = counter + 1
                Label1.Text = "Bookmark Added!"
            End If
        End If
        If (e.KeyCode = 38 And AxWindowsMediaPlayer1.URL <> "" And editingtimes = 1) Then   'EXPORT BOOKMARKS BY PRESSING UP BTN
            Timer2.Enabled = True
            Dim sdasad As String = OpenFileDialog1.FileName.ToString() & "-timestamps.txt"
            Dim objWriter As New System.IO.StreamWriter(sdasad, True)
            For z As Integer = 0 To counter
                objWriter.WriteLine(newarray(z))
            Next
            objWriter.Close()
            Label1.Text = "Bookmark Added!"
        End If
    End Sub
    'by scrollbar
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll

        Label1.Text = timestamps(TrackBar1.Value)
        Timer2.Enabled = True
        t = 0

        AxWindowsMediaPlayer2.Ctlcontrols.currentPosition = timestamps(TrackBar1.Value) / 10
        AxWindowsMediaPlayer2.Ctlcontrols.play()
        AxWindowsMediaPlayer2.Visible = True
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        t = t + 1

        If t = 3 Then
            confirmadd = 0

            If Label1.Text <> "" Then
                Label1.Text = "    "
            End If
            t = 0
            Timer2.Enabled = False
        End If
    End Sub
    Private Sub TrackBar1_MouseUp(sender As Object, e As MouseEventArgs) Handles TrackBar1.MouseUp
        '    AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = timestamps(TrackBar1.Value) / 10
        If Label1.Text <> "    " Then
            AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = Label1.Text / 10
        End If
    End Sub
    Private Sub Trackbar1_MouseLeave(sender As Object, e As EventArgs) Handles TrackBar1.MouseLeave
        AxWindowsMediaPlayer2.Visible = False
        AxWindowsMediaPlayer2.Ctlcontrols.pause()
    End Sub


End Class

