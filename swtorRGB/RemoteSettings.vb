Public Class RemoteSettings
    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.HyperionEnabled = True Then
            HyperionEnabled.Checked = True
        End If
        HyperionPort.Text = My.Settings.HyperionPort
        HyperionIP.Text = My.Settings.HyperionIP
        HyperionPriority.Text = My.Settings.HyperionPriority

        RazerChromaEnabled.Checked = My.Settings.RazerChromaEnabled
        RazerChromaLink.Checked = My.Settings.RazerChromaLink
        RazerChromaMouse.Checked = My.Settings.RazerChromaMouse
        RazerChromaMousepad.Checked = My.Settings.RazerChromaMousepad
        RazerChromaHeadset.Checked = My.Settings.RazerChromaHeadset

        FilePath.Text = My.Settings.LogFilePath

        FolderBrowserDialog1.SelectedPath = My.Settings.LogFilePath
        ListBox1.SelectedIndex = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.HyperionPort = HyperionPort.Text
        My.Settings.HyperionIP = HyperionIP.Text
        My.Settings.HyperionPriority = HyperionPriority.Text
        My.Settings.LogFilePath = FilePath.Text

        My.Settings.HyperionEnabled = HyperionEnabled.Checked

        My.Settings.RazerChromaEnabled = RazerChromaEnabled.Checked
        My.Settings.RazerChromaLink = RazerChromaLink.Checked
        My.Settings.RazerChromaMouse = RazerChromaMouse.Checked
        My.Settings.RazerChromaMousepad = RazerChromaMousepad.Checked
        My.Settings.RazerChromaHeadset = RazerChromaHeadset.Checked

        Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        tabChroma.Visible = False
        tabHyperion.Visible = False
        tabSWTOR.Visible = False

        If ListBox1.SelectedIndex = 0 Then
            tabSWTOR.Visible = True
        End If

        If ListBox1.SelectedIndex = 1 Then
            tabHyperion.Visible = True
        End If
        If ListBox1.SelectedIndex = 2 Then
            tabChroma.Visible = True
        End If
    End Sub

    Private Sub RazerChromaEnabled_CheckedChanged(sender As Object, e As EventArgs) Handles RazerChromaEnabled.CheckedChanged
        RazerChromaLink.Enabled = RazerChromaEnabled.Checked
        RazerChromaMouse.Enabled = RazerChromaEnabled.Checked
        RazerChromaMousepad.Enabled = RazerChromaEnabled.Checked
        RazerChromaHeadset.Enabled = RazerChromaEnabled.Checked
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RazerKeypad.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            FilePath.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub
End Class