<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.out = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EinstellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnSetNoFight = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnColorFight = New System.Windows.Forms.Button()
        Me.btnColorNoFight = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TimerRazor = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'out
        '
        Me.out.Location = New System.Drawing.Point(15, 145)
        Me.out.Name = "out"
        Me.out.Size = New System.Drawing.Size(269, 127)
        Me.out.TabIndex = 1
        Me.out.Text = "Label1"
        '
        'Timer1
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EinstellungenToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(292, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EinstellungenToolStripMenuItem
        '
        Me.EinstellungenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoteToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.EinstellungenToolStripMenuItem.Name = "EinstellungenToolStripMenuItem"
        Me.EinstellungenToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.EinstellungenToolStripMenuItem.Text = "Window"
        '
        'RemoteToolStripMenuItem
        '
        Me.RemoteToolStripMenuItem.Name = "RemoteToolStripMenuItem"
        Me.RemoteToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.RemoteToolStripMenuItem.Text = "Settings"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(191, 63)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(66, 27)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "anwenden"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnSetNoFight
        '
        Me.btnSetNoFight.Location = New System.Drawing.Point(191, 31)
        Me.btnSetNoFight.Name = "btnSetNoFight"
        Me.btnSetNoFight.Size = New System.Drawing.Size(66, 26)
        Me.btnSetNoFight.TabIndex = 18
        Me.btnSetNoFight.Text = "anwenden"
        Me.btnSetNoFight.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "In fight"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Not in fight"
        '
        'btnColorFight
        '
        Me.btnColorFight.BackColor = System.Drawing.Color.Red
        Me.btnColorFight.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnColorFight.Location = New System.Drawing.Point(91, 64)
        Me.btnColorFight.Name = "btnColorFight"
        Me.btnColorFight.Size = New System.Drawing.Size(94, 27)
        Me.btnColorFight.TabIndex = 15
        Me.btnColorFight.UseVisualStyleBackColor = False
        '
        'btnColorNoFight
        '
        Me.btnColorNoFight.BackColor = System.Drawing.Color.Lime
        Me.btnColorNoFight.Location = New System.Drawing.Point(91, 31)
        Me.btnColorNoFight.Name = "btnColorNoFight"
        Me.btnColorNoFight.Size = New System.Drawing.Size(94, 27)
        Me.btnColorNoFight.TabIndex = 14
        Me.btnColorNoFight.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(18, 97)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(266, 33)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Display color window"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TimerRazor
        '
        Me.TimerRazor.Enabled = True
        Me.TimerRazor.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(292, 134)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnSetNoFight)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnColorFight)
        Me.Controls.Add(Me.btnColorNoFight)
        Me.Controls.Add(Me.out)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "SWTOR fight status to RGB"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents out As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EinstellungenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button3 As Button
    Friend WithEvents btnSetNoFight As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnColorFight As Button
    Friend WithEvents btnColorNoFight As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TimerRazor As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
