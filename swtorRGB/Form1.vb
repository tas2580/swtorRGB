Imports System.IO
Imports System.Net.Sockets


Public Class Form1
    Dim serverStream As NetworkStream
    Dim LogFile
    Dim OldStatus = 0



    ' load form
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RazerChroma.init()

        If My.Settings.LogFilePath = "" Then
            My.Settings.LogFilePath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\Star Wars - The Old Republic\CombatLogs\"
        End If

        ' Set colors to buttons
        Dim ColorFightArray() As String = Split(My.Settings.ColorFight, ",")
        Dim ColorNoFightArray() As String = Split(My.Settings.ColorNoFight, ",")
        btnColorFight.BackColor = ColorTranslator.FromOle(RGB(ColorFightArray(0), ColorFightArray(1), ColorFightArray(2)))
        btnColorNoFight.BackColor = ColorTranslator.FromOle(RGB(ColorNoFightArray(0), ColorNoFightArray(1), ColorNoFightArray(2)))

        SetColor(My.Settings.ColorNoFight)
        Timer1.Enabled = True
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        EndAll()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim lastLine As String = ""
        Dim status = 0
        Dim fs As FileStream
        Dim sr As StreamReader

        LogFile = Directory.GetFiles(My.Settings.LogFilePath).OrderByDescending(Function(f) New FileInfo(f).LastWriteTime).First()
        fs = New FileStream(LogFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
        sr = New IO.StreamReader(fs)
        Do Until sr.EndOfStream
            lastLine = sr.ReadLine()
            If lastLine.Contains("KampfVerlassen") Or lastLine.Contains("ExitCombat") Then
                out.Text = lastLine
                status = 0
            ElseIf lastLine.Contains("KampfBeginnen") Or lastLine.Contains("EnterCombat") Then
                out.Text = lastLine
                status = 1

            End If
        Loop

        If status <> OldStatus Then
            OldStatus = status
            If status = 0 Then
                SetColor(My.Settings.ColorNoFight)
            ElseIf status = 1 Then
                SetColor(My.Settings.ColorFight)
            End If
        End If
        fs.Close()
        sr.Close()
    End Sub


    Private Sub SetColor(color)

        If My.Settings.HyperionEnabled = True Then
            Hyperion.SetColor(color)
        End If

        If My.Settings.RazerChromaEnabled = True Then
            RazerChroma.SetColor(color)
        End If

        Dim ColorArray() As String = Split(color, ",")
        ScreenColor.BackColor = ColorTranslator.FromOle(RGB(ColorArray(0), ColorArray(1), ColorArray(2)))
    End Sub






    Private Sub RemoteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoteToolStripMenuItem.Click
        RemoteSettings.Show()
    End Sub

    Private Sub btnColorNoFight_Click(sender As Object, e As EventArgs) Handles btnColorNoFight.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            My.Settings.ColorNoFight = CStr(ColorDialog1.Color.R) + "," + CStr(ColorDialog1.Color.G) + "," + CStr(ColorDialog1.Color.B)
            btnColorNoFight.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub btnColorFight_Click_1(sender As Object, e As EventArgs) Handles btnColorFight.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            My.Settings.ColorFight = CStr(ColorDialog1.Color.R) + "," + CStr(ColorDialog1.Color.G) + "," + CStr(ColorDialog1.Color.B)
            btnColorFight.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub btnSetNoFight_Click(sender As Object, e As EventArgs) Handles btnSetNoFight.Click
        SetColor(My.Settings.ColorNoFight)
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        SetColor(My.Settings.ColorFight)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ScreenColor.Show()

    End Sub

    Private Sub TimerRazor_Tick(sender As Object, e As EventArgs) Handles TimerRazor.Tick
        RazerChroma.HeartBeat()
    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        EndAll()
    End Sub


    Private Function EndAll()
        If My.Settings.HyperionEnabled = True Then
            Hyperion.TurnOff()
        End If

        If My.Settings.RazerChromaEnabled = True Then
            RazerChroma.TurnOff()
        End If
        End
    End Function
End Class
