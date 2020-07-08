Public Class Form1
    Dim mov, movX, movY As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub panel4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles panel4.Paint

    End Sub

    Private Sub webBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs)

    End Sub

    Private Sub pictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictureBox2.Click
        bot_olustu_yada_davet_et.ShowDialog()
    End Sub

    Private Sub pictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictureBox3.Click
        MsgBox("Lütfen Alpha sürümü bekleyiniz. Sabrınız için teşekkür ederiz.", MsgBoxStyle.Information, Application.ProductName)
    End Sub

    Private Sub WebBrowser1_DocumentCompleted_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Dim bilgi As HtmlElementCollection = WebBrowser1.Document.All
        For Each element As HtmlElement In bilgi
            If element.GetAttribute("classname").Contains("upload-date-true") Then
                upload_date.ShowDialog()
            End If
        Next
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick


    End Sub

    Private Sub Label1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.TextChanged

    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        Application.Exit()
    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        
    End Sub

    Private Sub panel3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panel3.MouseDown
        mov = 1
        movX = e.X
        movY = e.Y
    End Sub

    Private Sub panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles panel3.Paint

    End Sub

    Private Sub Form1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
    
    End Sub

    Private Sub panel3_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panel3.MouseMove
        If mov = 1 Then
            Me.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY)
        End If
    End Sub

    Private Sub panel3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panel3.MouseUp
        mov = 0
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        hakkında.ShowDialog()
    End Sub
End Class
