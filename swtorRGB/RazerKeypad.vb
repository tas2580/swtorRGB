Public Class RazerKeypad
    Private Sub Key1_Click(sender As Object, e As EventArgs) Handles Key1.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Key1.BackColor = ColorDialog1.Color
        End If
    End Sub
    Private Sub Key2_Click(sender As Object, e As EventArgs) Handles Key2.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Key2.BackColor = ColorDialog1.Color
        End If
    End Sub
    Private Sub Key3_Click(sender As Object, e As EventArgs) Handles Key3.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Key3.BackColor = ColorDialog1.Color
        End If
    End Sub
    Private Sub Key4_Click(sender As Object, e As EventArgs) Handles Key4.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Key4.BackColor = ColorDialog1.Color
        End If
    End Sub
    Private Sub Key5_Click(sender As Object, e As EventArgs) Handles Key5.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Key5.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub Key6_Click(sender As Object, e As EventArgs) Handles Key6.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Key6.BackColor = ColorDialog1.Color
        End If
    End Sub
    Private Sub Key7_Click(sender As Object, e As EventArgs) Handles Key7.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Key7.BackColor = ColorDialog1.Color
        End If
    End Sub
    Private Sub Key8_Click(sender As Object, e As EventArgs) Handles Key8.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Key8.BackColor = ColorDialog1.Color
        End If
    End Sub
    Private Sub Key9_Click(sender As Object, e As EventArgs) Handles Key9.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Key9.BackColor = ColorDialog1.Color
        End If
    End Sub
    Private Sub Key10_Click(sender As Object, e As EventArgs) Handles Key10.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Key10.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub Key11_Click(sender As Object, e As EventArgs) Handles Key11.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Key11.BackColor = ColorDialog1.Color
        End If
    End Sub
    Private Sub Key12_Click(sender As Object, e As EventArgs) Handles Key12.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Key12.BackColor = ColorDialog1.Color
        End If
    End Sub
    Private Sub Key13_Click(sender As Object, e As EventArgs) Handles Key13.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Key13.BackColor = ColorDialog1.Color
        End If
    End Sub
    Private Sub Key14_Click(sender As Object, e As EventArgs) Handles Key14.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Key14.BackColor = ColorDialog1.Color
        End If
    End Sub
    Private Sub Key15_Click(sender As Object, e As EventArgs) Handles Key15.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Key15.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub Key16_Click(sender As Object, e As EventArgs) Handles Key16.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Key16.BackColor = ColorDialog1.Color
        End If
    End Sub
    Private Sub Key17_Click(sender As Object, e As EventArgs) Handles Key17.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Key17.BackColor = ColorDialog1.Color
        End If
    End Sub
    Private Sub Key18_Click(sender As Object, e As EventArgs) Handles Key18.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Key18.BackColor = ColorDialog1.Color
        End If
    End Sub
    Private Sub Key19_Click(sender As Object, e As EventArgs) Handles Key19.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Key19.BackColor = ColorDialog1.Color
        End If
    End Sub
    Private Sub Key20_Click(sender As Object, e As EventArgs) Handles Key20.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Key20.BackColor = ColorDialog1.Color
        End If
    End Sub



    Private Sub RazerKeypad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Key1.BackColor = My.Settings.RazerKeypadColor1
        Key2.BackColor = My.Settings.RazerKeypadColor2
        Key3.BackColor = My.Settings.RazerKeypadColor3
        Key4.BackColor = My.Settings.RazerKeypadColor4
        Key5.BackColor = My.Settings.RazerKeypadColor5
        Key6.BackColor = My.Settings.RazerKeypadColor6
        Key7.BackColor = My.Settings.RazerKeypadColor7
        Key8.BackColor = My.Settings.RazerKeypadColor8
        Key9.BackColor = My.Settings.RazerKeypadColor9
        Key10.BackColor = My.Settings.RazerKeypadColor10
        Key11.BackColor = My.Settings.RazerKeypadColor11
        Key12.BackColor = My.Settings.RazerKeypadColor12
        Key13.BackColor = My.Settings.RazerKeypadColor13
        Key14.BackColor = My.Settings.RazerKeypadColor14
        Key15.BackColor = My.Settings.RazerKeypadColor15
        Key16.BackColor = My.Settings.RazerKeypadColor16
        Key17.BackColor = My.Settings.RazerKeypadColor17
        Key18.BackColor = My.Settings.RazerKeypadColor18
        Key19.BackColor = My.Settings.RazerKeypadColor19
        Key20.BackColor = My.Settings.RazerKeypadColor20

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.RazerKeypadColor1 = Key1.BackColor
        My.Settings.RazerKeypadColor2 = Key2.BackColor
        My.Settings.RazerKeypadColor3 = Key3.BackColor
        My.Settings.RazerKeypadColor4 = Key4.BackColor
        My.Settings.RazerKeypadColor5 = Key5.BackColor
        My.Settings.RazerKeypadColor6 = Key6.BackColor
        My.Settings.RazerKeypadColor7 = Key7.BackColor
        My.Settings.RazerKeypadColor8 = Key8.BackColor
        My.Settings.RazerKeypadColor9 = Key9.BackColor
        My.Settings.RazerKeypadColor10 = Key10.BackColor
        My.Settings.RazerKeypadColor11 = Key11.BackColor
        My.Settings.RazerKeypadColor12 = Key12.BackColor
        My.Settings.RazerKeypadColor13 = Key13.BackColor
        My.Settings.RazerKeypadColor14 = Key14.BackColor
        My.Settings.RazerKeypadColor15 = Key15.BackColor
        My.Settings.RazerKeypadColor16 = Key16.BackColor
        My.Settings.RazerKeypadColor17 = Key17.BackColor
        My.Settings.RazerKeypadColor18 = Key18.BackColor
        My.Settings.RazerKeypadColor19 = Key19.BackColor
        My.Settings.RazerKeypadColor20 = Key20.BackColor

        RazerChroma.SetKeypad()
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class