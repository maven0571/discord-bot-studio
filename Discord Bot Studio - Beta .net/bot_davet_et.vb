Public Class bot_davet_et

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        If TextBox1.Text = Nothing Then
            Label2.Text = "Hey sen : Bot'un ID yada Davet linkini girmedin.!"
            Timer1.Start()
        Else
            If CheckBox1.Checked = True Then
                Process.Start("https://discordapp.com/oauth2/authorize?client_id=" & TextBox1.Text & "&scope=bot&permissions=2146958847")
                My.Computer.Clipboard.SetText("https://discordapp.com/oauth2/authorize?client_id=" & TextBox1.Text & "scope=bot&permissions=2146958847")
            ElseIf CheckBox1.Checked = False Then
                Process.Start(TextBox1.Text)
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Label2.Visible = False
        Timer1.Stop()
        Timer2.Stop()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label2.Visible = True
        Timer2.Start()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        TextBox1.Text = "698777677644955730"
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        TextBox1.Text = "https://discord.com/oauth2/authorize?client_id=698777677644955730&scope=bot&permissions=805829694"
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        TextBox1.Text = "https://discord.com/oauth2/authorize?response_type=code&client_id=159985415099514880&redirect_uri=https%3A%2F%2Fmee6.xyz%2Fapi%2Fdiscord-callback&scope=identify+guilds+email&state=hse9y3mFN1p335oqzZxG9vakrnp3Fv"
    End Sub
End Class