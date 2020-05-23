Public Class acilis_ekrani

    Private Sub acilis_ekrani_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Computer.Network.IsAvailable Then
            Timer2.Enabled = True
        Else
            Label1.Visible = True
            Timer2.Enabled = False
            Timer1.Enabled = True
        End If

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        progDoldur.Increment(10)
        If progDoldur.Value = "100" Then
            Timer2.Stop()
            Me.Hide()
            Form1.Show()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        progDoldur.Increment(10)
        If progDoldur.Value = "25" Then
            Me.Hide()
            Label1.Text = "Bağlantı olmadığından çıkış yapılıyor.!"
            Application.Exit()
        End If
    End Sub
End Class