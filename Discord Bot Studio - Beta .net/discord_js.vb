Imports System.Text.RegularExpressions
Imports Setting.IniFile
Public Class discord_js
    Dim komutnamefunction As String = InputBox("Komut adını giriniz [Türkçe karakter serbest] : ", Title:="Komut adı gir")
    Dim inifile As New Setting.IniFile(Application.StartupPath & "\kaynak\setting.ini")
    Private Sub GeriAlToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeriAlToolStripMenuItem.Click
        FastColoredTextBox1.Undo()
    End Sub

    Private Sub YenileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YenileToolStripMenuItem.Click
        FastColoredTextBox1.Redo()
    End Sub

    Private Sub KesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KesToolStripMenuItem.Click
        FastColoredTextBox1.Cut()
    End Sub

    Private Sub KopyalaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KopyalaToolStripMenuItem.Click
        FastColoredTextBox1.Copy()
    End Sub

    Private Sub YapıştırToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YapıştırToolStripMenuItem.Click
        FastColoredTextBox1.Paste()
    End Sub

    Private Sub SilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SilToolStripMenuItem.Click
        FastColoredTextBox1.ClearSelected()
    End Sub

    Private Sub TümünüSeçToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TümünüSeçToolStripMenuItem.Click
        FastColoredTextBox1.SelectAll()
    End Sub

    Private Sub BulToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BulToolStripMenuItem.Click
        FastColoredTextBox1.ShowFindDialog()
    End Sub

    Private Sub YerleştirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YerleştirToolStripMenuItem.Click
        FastColoredTextBox1.ShowReplaceDialog()
    End Sub

    Private Sub GitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GitToolStripMenuItem.Click
        FastColoredTextBox1.ShowGoToDialog()
    End Sub

    Private Sub ÇıkışToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÇıkışToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub YeniKomutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YeniKomutToolStripMenuItem.Click
        Dim newcommand As String = MsgBox("Yeni komut oluşturmak istediğinizden emin misiniz?", MsgBoxStyle.YesNoCancel, Application.ProductName)
        If newcommand = MsgBoxResult.Yes Then
            Dim komutname As String = InputBox("Komut adını giriniz [Türkçe karakter serbest] : ", Title:="Komut adı gir")
            Dim komutKonum As System.IO.StreamWriter = System.IO.File.CreateText("C:\Users\" & Environment.UserName & "\Documents\" & My.Settings.bot_adi & "\komutlar\" & komutname + ".js")
            komutKonum.WriteLine(FastColoredTextBox1.Text)
            komutKonum.Close()
        ElseIf newcommand = MsgBoxResult.No Then
            FastColoredTextBox1.SelectAll()
            FastColoredTextBox1.Clear()
        End If
    End Sub

    Private Sub KomutAçToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KomutAçToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim text As String = System.IO.File.ReadAllText(OpenFileDialog1.FileName, System.Text.Encoding.GetEncoding("utf-8"))
            FastColoredTextBox1.Text = text
            Me.Text = "Apple editor - discord_js " + System.IO.Path.GetFileName(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        FastColoredTextBox1.LineNumberColor = Color.Orange
        Timer2.Start()
        Timer1.Stop()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        FastColoredTextBox1.LineNumberColor = Color.Red
        Timer3.Start()
        Timer2.Stop()
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        FastColoredTextBox1.LineNumberColor = Color.MediumSlateBlue
        Timer1.Start()
        Timer3.Stop()
    End Sub

    Private Sub RenkModuToolStripMenuItem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RenkModuToolStripMenuItem.CheckedChanged
        If RenkModuToolStripMenuItem.Checked = True Then
            Timer1.Start()
        ElseIf RenkModuToolStripMenuItem.Checked = False Then
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
        End If
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        If OtomatikKaydetToolStripMenuItem.Checked = True Then
            Try
                Dim komutKonum As System.IO.StreamWriter = System.IO.File.CreateText("C:\Users\" & Environment.UserName & "\Documents\" & "Furkans" & "\komutlar\" & komutnamefunction + ".js")
                komutKonum.Write(FastColoredTextBox1.Text)
                komutKonum.Close()
            Catch ex As Exception
                MsgBox("Otomatik kaydet ayarları yapılmamış olabilir.!", MsgBoxStyle.Exclamation, Application.ProductName)
            End Try
        End If
    End Sub

    Private Sub FastColoredTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As FastColoredTextBoxNS.TextChangedEventArgs) Handles FastColoredTextBox1.TextChanged
        e.ChangedRange.ClearFoldingMarkers()
        e.ChangedRange.SetFoldingMarkers("{", "}")
        FastColoredTextBox1.CollapseBlock(FastColoredTextBox1.Selection.Start.iLine,
               FastColoredTextBox1.Selection.End.iLine)

    End Sub

    Private Sub FastColoredTextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles FastColoredTextBox1.KeyDown

        Dim selectionLenght As Integer = FastColoredTextBox1.SelectionLength
        Dim selectionart As Integer = FastColoredTextBox1.SelectionStart
        Dim letter As String = String.Empty
        Do Until letter = " " Or FastColoredTextBox1.SelectionStart = 0
            FastColoredTextBox1.SelectionStart -= 1
            FastColoredTextBox1.SelectionLength += 1
            letter = FastColoredTextBox1.Text.Substring(FastColoredTextBox1.SelectionStart, 1)
        Loop
        If FastColoredTextBox1.SelectedText = "If" Or FastColoredTextBox1.SelectedText = "If" Then
            FastColoredTextBox1.SelectionColor = Color.Blue
        Else
            'hiç bir şey yapma
        End If
        FastColoredTextBox1.SelectionStart = selectionart
        FastColoredTextBox1.SelectionLength = 0
        FastColoredTextBox1.SelectionColor = Color.Black

    End Sub

    Private Sub FastColoredTextBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FastColoredTextBox1.Load

    End Sub

    Private Sub KomutKaydetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KomutKaydetToolStripMenuItem.Click
        Try

            Dim komutKonum As System.IO.StreamWriter = System.IO.File.CreateText("C:\Users\" & Environment.UserName & "\Documents\" & "Furkans" & "\komutlar\" & komutnamefunction + ".js")
            komutKonum.WriteLine(FastColoredTextBox1.Text)
            komutKonum.Close()
        Catch ex As Exception
            MsgBox("Otomatik kaydet ayarları yapılmamış olabilir.!", MsgBoxStyle.Exclamation, Application.ProductName)
        End Try
    End Sub

    Private Sub DosyaAdıAyarlaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DosyaAdıAyarlaToolStripMenuItem.Click
        Dim adayarı As String = InputBox("Otomatik kayıt için dosya adını giriniz [Türkçe larakter serbest] : ", Title:=
                                         "Otomatik kayıt dosya adı")
        komutnamefunction = adayarı
    End Sub

    Private Sub discord_js_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Settings.Reload()
        My.Settings.Reload()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class