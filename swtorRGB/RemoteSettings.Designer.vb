<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RemoteSettings
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tabHyperion = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HyperionEnabled = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.HyperionPriority = New System.Windows.Forms.TextBox()
        Me.HyperionPort = New System.Windows.Forms.TextBox()
        Me.HyperionIP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.tabSWTOR = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FilePath = New System.Windows.Forms.TextBox()
        Me.tabChroma = New System.Windows.Forms.GroupBox()
        Me.RazerChromaHeadset = New System.Windows.Forms.CheckBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.RazerChromaMouse = New System.Windows.Forms.CheckBox()
        Me.RazerChromaLink = New System.Windows.Forms.CheckBox()
        Me.RazerChromaMousepad = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RazerChromaEnabled = New System.Windows.Forms.CheckBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.tabHyperion.SuspendLayout()
        Me.tabSWTOR.SuspendLayout()
        Me.tabChroma.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabHyperion
        '
        Me.tabHyperion.Controls.Add(Me.Label1)
        Me.tabHyperion.Controls.Add(Me.HyperionEnabled)
        Me.tabHyperion.Controls.Add(Me.Label5)
        Me.tabHyperion.Controls.Add(Me.HyperionPriority)
        Me.tabHyperion.Controls.Add(Me.HyperionPort)
        Me.tabHyperion.Controls.Add(Me.HyperionIP)
        Me.tabHyperion.Controls.Add(Me.Label4)
        Me.tabHyperion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabHyperion.Location = New System.Drawing.Point(138, 12)
        Me.tabHyperion.Name = "tabHyperion"
        Me.tabHyperion.Size = New System.Drawing.Size(376, 173)
        Me.tabHyperion.TabIndex = 7
        Me.tabHyperion.TabStop = False
        Me.tabHyperion.Text = "Hyperion"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(7, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(370, 47)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Hyperion is an ambilight System, see https://hyperion-project.org/ for more info." &
    ""
        '
        'HyperionEnabled
        '
        Me.HyperionEnabled.AutoSize = True
        Me.HyperionEnabled.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HyperionEnabled.Location = New System.Drawing.Point(9, 27)
        Me.HyperionEnabled.Name = "HyperionEnabled"
        Me.HyperionEnabled.Size = New System.Drawing.Size(102, 17)
        Me.HyperionEnabled.TabIndex = 5
        Me.HyperionEnabled.Text = "Use Hyperion"
        Me.HyperionEnabled.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Priority"
        '
        'HyperionPriority
        '
        Me.HyperionPriority.Location = New System.Drawing.Point(51, 80)
        Me.HyperionPriority.Name = "HyperionPriority"
        Me.HyperionPriority.Size = New System.Drawing.Size(94, 20)
        Me.HyperionPriority.TabIndex = 3
        '
        'HyperionPort
        '
        Me.HyperionPort.Location = New System.Drawing.Point(151, 50)
        Me.HyperionPort.Name = "HyperionPort"
        Me.HyperionPort.Size = New System.Drawing.Size(45, 20)
        Me.HyperionPort.TabIndex = 2
        Me.HyperionPort.Text = "19444"
        '
        'HyperionIP
        '
        Me.HyperionIP.Location = New System.Drawing.Point(51, 50)
        Me.HyperionIP.Name = "HyperionIP"
        Me.HyperionIP.Size = New System.Drawing.Size(94, 20)
        Me.HyperionIP.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "IP:Port"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(316, 191)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 24)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(418, 191)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 24)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Abbrechen"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"SWTOR", "Hyperion", "Razer Chroma"})
        Me.ListBox1.Location = New System.Drawing.Point(12, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 147)
        Me.ListBox1.TabIndex = 10
        '
        'tabSWTOR
        '
        Me.tabSWTOR.Controls.Add(Me.Button4)
        Me.tabSWTOR.Controls.Add(Me.Label6)
        Me.tabSWTOR.Controls.Add(Me.Label3)
        Me.tabSWTOR.Controls.Add(Me.FilePath)
        Me.tabSWTOR.Location = New System.Drawing.Point(138, 12)
        Me.tabSWTOR.Name = "tabSWTOR"
        Me.tabSWTOR.Size = New System.Drawing.Size(376, 173)
        Me.tabSWTOR.TabIndex = 12
        Me.tabSWTOR.TabStop = False
        Me.tabSWTOR.Text = "SWTOR"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(288, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Path to combat Log. You must enable Combat Log in game."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Log Path"
        '
        'FilePath
        '
        Me.FilePath.Location = New System.Drawing.Point(10, 39)
        Me.FilePath.Name = "FilePath"
        Me.FilePath.Size = New System.Drawing.Size(304, 20)
        Me.FilePath.TabIndex = 6
        '
        'tabChroma
        '
        Me.tabChroma.Controls.Add(Me.RazerChromaHeadset)
        Me.tabChroma.Controls.Add(Me.Button3)
        Me.tabChroma.Controls.Add(Me.RazerChromaMouse)
        Me.tabChroma.Controls.Add(Me.RazerChromaLink)
        Me.tabChroma.Controls.Add(Me.RazerChromaMousepad)
        Me.tabChroma.Controls.Add(Me.Label7)
        Me.tabChroma.Controls.Add(Me.RazerChromaEnabled)
        Me.tabChroma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabChroma.Location = New System.Drawing.Point(135, 12)
        Me.tabChroma.Name = "tabChroma"
        Me.tabChroma.Size = New System.Drawing.Size(376, 173)
        Me.tabChroma.TabIndex = 14
        Me.tabChroma.TabStop = False
        Me.tabChroma.Text = "Razer Chroma"
        '
        'RazerChromaHeadset
        '
        Me.RazerChromaHeadset.AutoSize = True
        Me.RazerChromaHeadset.Location = New System.Drawing.Point(23, 108)
        Me.RazerChromaHeadset.Name = "RazerChromaHeadset"
        Me.RazerChromaHeadset.Size = New System.Drawing.Size(66, 17)
        Me.RazerChromaHeadset.TabIndex = 11
        Me.RazerChromaHeadset.Text = "Headset"
        Me.RazerChromaHeadset.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(188, 46)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Configure Keypad"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'RazerChromaMouse
        '
        Me.RazerChromaMouse.AutoSize = True
        Me.RazerChromaMouse.Location = New System.Drawing.Point(23, 50)
        Me.RazerChromaMouse.Name = "RazerChromaMouse"
        Me.RazerChromaMouse.Size = New System.Drawing.Size(58, 17)
        Me.RazerChromaMouse.TabIndex = 9
        Me.RazerChromaMouse.Text = "Mouse"
        Me.RazerChromaMouse.UseVisualStyleBackColor = True
        '
        'RazerChromaLink
        '
        Me.RazerChromaLink.AutoSize = True
        Me.RazerChromaLink.Location = New System.Drawing.Point(23, 89)
        Me.RazerChromaLink.Name = "RazerChromaLink"
        Me.RazerChromaLink.Size = New System.Drawing.Size(93, 17)
        Me.RazerChromaLink.TabIndex = 8
        Me.RazerChromaLink.Text = "Linked device"
        Me.RazerChromaLink.UseVisualStyleBackColor = True
        '
        'RazerChromaMousepad
        '
        Me.RazerChromaMousepad.AutoSize = True
        Me.RazerChromaMousepad.Location = New System.Drawing.Point(23, 69)
        Me.RazerChromaMousepad.Name = "RazerChromaMousepad"
        Me.RazerChromaMousepad.Size = New System.Drawing.Size(76, 17)
        Me.RazerChromaMousepad.TabIndex = 7
        Me.RazerChromaMousepad.Text = "Mousepad"
        Me.RazerChromaMousepad.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(6, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(370, 33)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Hyperion is an ambilight System, see https://hyperion-project.org/ for more info." &
    ""
        '
        'RazerChromaEnabled
        '
        Me.RazerChromaEnabled.AutoSize = True
        Me.RazerChromaEnabled.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RazerChromaEnabled.Location = New System.Drawing.Point(9, 27)
        Me.RazerChromaEnabled.Name = "RazerChromaEnabled"
        Me.RazerChromaEnabled.Size = New System.Drawing.Size(131, 17)
        Me.RazerChromaEnabled.TabIndex = 5
        Me.RazerChromaEnabled.Text = "Use Razer Chroma"
        Me.RazerChromaEnabled.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(314, 38)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(36, 22)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "..."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'RemoteSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 221)
        Me.ControlBox = False
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tabSWTOR)
        Me.Controls.Add(Me.tabChroma)
        Me.Controls.Add(Me.tabHyperion)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RemoteSettings"
        Me.Text = "Settings"
        Me.tabHyperion.ResumeLayout(False)
        Me.tabHyperion.PerformLayout()
        Me.tabSWTOR.ResumeLayout(False)
        Me.tabSWTOR.PerformLayout()
        Me.tabChroma.ResumeLayout(False)
        Me.tabChroma.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabHyperion As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents HyperionPriority As TextBox
    Friend WithEvents HyperionPort As TextBox
    Friend WithEvents HyperionIP As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents HyperionEnabled As CheckBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tabSWTOR As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents FilePath As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tabChroma As GroupBox
    Friend WithEvents RazerChromaLink As CheckBox
    Friend WithEvents RazerChromaMousepad As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents RazerChromaEnabled As CheckBox
    Friend WithEvents RazerChromaMouse As CheckBox
    Friend WithEvents Button3 As Button
    Friend WithEvents RazerChromaHeadset As CheckBox
    Friend WithEvents Button4 As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
