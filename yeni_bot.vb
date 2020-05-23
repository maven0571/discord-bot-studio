Imports System.IO
Imports System
Imports System.IO.Compression
Imports System.Environment
Public Class yeni_bot
    Dim template_bot As String = Application.StartupPath & "\kaynak\"
    Dim library_error As String
    Dim bot_konumu As String
    Dim inifile As New Setting.IniFile(Application.StartupPath & "\kaynak\setting.ini")
    Dim images(10) As Bitmap
    Dim pos As Integer = 0
    Private Declare Function SHEmptyRecycleBin Lib "shell32.dll" Alias "SHEmptyRecycleBinA" (ByVal hWnd As Int32, ByVal pszRootPath As String, ByVal dwFlags As Int32) As Int32
    Private Declare Function SHUpdateRecycleBinIcon Lib "shell32.dll" () As Int32

    Private Const SHERB_NOCONFIRMATION = &H1

    Private Const SHERB_NOPROGRESSUI = &H2

    Private Const SHERB_NOSOUND = &H4

    Private Sub EmptyRecycleBin()

        SHEmptyRecycleBin(Me.Handle.ToInt32, vbNullString, SHERB_NOCONFIRMATION)

        SHUpdateRecycleBinIcon()
    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub yeni_bot_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Settings.Reload()
        My.Settings.Reload()
        My.Settings.bot_adi = inifile.ReadValue("Yeni BOT", "Bot Adı")
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

        If TextBox1.Text = Nothing Then
            Label2.Text = "Hey sen : Bot'un adını girmedin.!"
            Timer1.Start()
        ElseIf TextBox2.Text = Nothing Then
            Label2.Text = "Hey sen : Bot'un Tokenini girmedin.!"
            Timer1.Start()
        Else
            kaydet() '1.function
            template_olustur() '2.funciton
            eventyükleyici() '3.function
            modulindir() '4.function
            eventindir() '5.function
            ayarlar() '6.function
            baslat() '7.function
            komutdownload() '8.function
            zipçıkartma() '11.function
            packsett() '9.function
            package_json() '10.function

        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label2.Visible = True
        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Label2.Visible = False
        Timer1.Stop()
        Timer2.Stop()
    End Sub
    Private Sub kapaninca() Handles MyBase.FormClosing
        My.Settings.Save()
    End Sub
    Private Sub acilinca() Handles MyBase.Load
        My.Settings.Reload()
    End Sub
    Public Sub kaydet()
        My.Settings.Save()
        My.Settings.Save()
        inifile.WriteValue("Yeni BOT", "Bot Adı", TextBox1.Text)
        My.Settings.Save()
        My.Settings.Save()
    End Sub

    Public Sub template_olustur()
        Try
            My.Computer.FileSystem.CreateDirectory("C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text)
            My.Computer.FileSystem.CreateDirectory("C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\events")
            My.Computer.FileSystem.CreateDirectory("C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\img")
            My.Computer.FileSystem.CreateDirectory("C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\img\wasted")
            My.Computer.FileSystem.CreateDirectory("C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\jsonlar")
            My.Computer.FileSystem.CreateDirectory("C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar")
            My.Computer.FileSystem.CreateDirectory("C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\node_modules")
            My.Computer.FileSystem.CreateDirectory("C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\util")
        Catch ex As Exception
            MsgBox("Bot dosyaları oluşturulurken bir problem çıktı.!", MsgBoxStyle.Exclamation, Application.ProductName)
            Dim denemeonayı As String = MsgBox("Tekrardan denemek ister misiniz?", MsgBoxStyle.YesNo, Application.ProductName)
            If denemeonayı = MsgBoxResult.Yes Then
                My.Computer.FileSystem.CreateDirectory("C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text)
                My.Computer.FileSystem.CreateDirectory("C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\events")
                My.Computer.FileSystem.CreateDirectory("C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\img")
                My.Computer.FileSystem.CreateDirectory("C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\img\wasted")
                My.Computer.FileSystem.CreateDirectory("C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\jsonlar")
                My.Computer.FileSystem.CreateDirectory("C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar")
                My.Computer.FileSystem.CreateDirectory("C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\node_modules")
                My.Computer.FileSystem.CreateDirectory("C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\util")
            ElseIf denemeonayı = MsgBoxResult.No Then
                MsgBox("Bot oluşturma işlemi iptal edildi.!", MsgBoxStyle.Exclamation, Application.ProductName)
                Me.Close()
            End If
        End Try
    End Sub

    Public Sub eventyükleyici()
        Try
            Dim eventsyükle As StreamWriter = File.CreateText("C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\util\eventLoader.js")
            eventsyükle.Write("const reqEvent = (event) => require(`../events/${event}`);")
            eventsyükle.WriteLine("module.exports = client => {")
            eventsyükle.WriteLine("  client.on('ready', () => reqEvent('ready')(client));")
            eventsyükle.WriteLine("  client.on('message', reqEvent('message'));")
            eventsyükle.WriteLine("  client.on('guildMemberAdd', reqEvent('guildMemberAdd'));")
            eventsyükle.WriteLine("  client.on('guildMemberRemove', reqEvent('guildMemberRemove'));")
            eventsyükle.WriteLine("};")
            eventsyükle.Close()
        Catch ex As Exception
            MsgBox("'eventLoader.js' adlı dosya oluşturulurken problem çıktı.", MsgBoxStyle.Exclamation, Application.ProductName)
            Dim denemeonayı As String = MsgBox("Tekrardan denemek ister misiniz?", MsgBoxStyle.YesNo, Application.ProductName)
            If denemeonayı = MsgBoxResult.Yes Then
                Dim eventsyükle As StreamWriter = File.CreateText("C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\util\eventLoader.js")
                eventsyükle.Write("const reqEvent = (event) => require(`../events/${event}`);")
                eventsyükle.WriteLine("module.exports = client => {")
                eventsyükle.WriteLine("  client.on('ready', () => reqEvent('ready')(client));")
                eventsyükle.WriteLine("  client.on('message', reqEvent('message'));")
                eventsyükle.WriteLine("  client.on('guildMemberAdd', reqEvent('guildMemberAdd'));")
                eventsyükle.WriteLine("  client.on('guildMemberRemove', reqEvent('guildMemberRemove'));")
                eventsyükle.WriteLine("};")
                eventsyükle.Close()
            ElseIf denemeonayı = MsgBoxResult.No Then
                MsgBox("Bot oluşturma işlemi iptal edildi.!", MsgBoxStyle.Exclamation, Application.ProductName)
                Me.Close()
            End If
        End Try
    End Sub
    Public Sub modulindir()
        Try
            My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/package-lock.json", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\package-lock.json")
            My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/bot.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\bot.js")
            My.Computer.Network.DownloadFile("https://cdn.glitch.com/401fa44c-5e16-4d34-b31d-e6b2c092e147%2Fnpm%20dbs%20--save.zip?v=1589552587120", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\node_modules\node_modules.zip", "", "", True, "20", False)
        Catch ex As Exception
            MsgBox("'modüller' indirilirken problem çıktı", MsgBoxStyle.Exclamation, Application.ProductName)
            Dim denemeonayı As String = MsgBox("Tekrardan denemek ister misiniz?", MsgBoxStyle.YesNo, Application.ProductName)
            If denemeonayı = MsgBoxResult.Yes Then
                My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/package-lock.json", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\package-lock.json")
                My.Computer.Network.DownloadFile("https://cdn.glitch.com/34c8bc1a-7582-445c-a9c6-12608ba4280f%2Fnode_modules.zip?v=1590138081964", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\node_modules\node_modules.zip", "", "", True, "20", False)
            ElseIf denemeonayı = MsgBoxResult.No Then
                MsgBox("Bot oluşturma işlemi iptal edildi.!", MsgBoxStyle.Exclamation, Application.ProductName)
                Me.Close()
            End If
        End Try
    End Sub
    Public Sub eventindir()
        Try
            My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/disconnect.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\events\disconnect.js")
            My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/guildCreate.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\events\guildCreate.js")
            My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/guildMemberAdd.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\events\guildMemberAdd.js")
            My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/guildMemberRemove.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\events\guildMemberRemove.js")
            My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/guildMemberUpdate.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\events\guildMemberUpdate.js")
            My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/message.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\events\message.js")
            My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/reconnecting.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\events\reconnecting.js")
        Catch ex As Exception
            MsgBox("'events' indirilirken problem çıktı", MsgBoxStyle.Exclamation, Application.ProductName)
            Dim denemeonayı As String = MsgBox("Tekrardan denemek ister misiniz?", MsgBoxStyle.YesNo, Application.ProductName)
            If denemeonayı = MsgBoxResult.Yes Then
                My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/disconnect.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\events\disconnect.js")
                My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/guildCreate.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\events\guildCreate.js")
                My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/guildMemberAdd.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\events\guildMemberAdd.js")
                My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/guildMemberRemove.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\events\guildMemberRemove.js")
                My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/guildMemberUpdate.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\events\guildMemberUpdate.js")
                My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/message.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\events\message.js")
                My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/reconnecting.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\events\reconnecting.js")
            ElseIf denemeonayı = MsgBoxResult.No Then
                MsgBox("Bot oluşturma işlemi iptal edildi.!", MsgBoxStyle.Exclamation, Application.ProductName)
                Me.Close()
            End If
        End Try
    End Sub
    Public Sub zipçıkartma()
        Try
            MsgBox("3 - 5 Dakikalık çıkartma işlemi başlıyor...", MsgBoxStyle.Information, Application.ProductName)
            Dim anaKonum, zipKonum As String
            anaKonum = "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\node_modules"
            zipKonum = "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\node_modules\node_modules.zip"
            ZipFile.ExtractToDirectory(zipKonum, anaKonum)
        Catch ex As Exception
            MsgBox("'zip' çıkartılırken problem çıktı", MsgBoxStyle.Exclamation, Application.ProductName)
            Dim denemeonayı As String = MsgBox("Tekrardan denemek ister misiniz?", MsgBoxStyle.YesNo, Application.ProductName)
            If denemeonayı = MsgBoxResult.Yes Then
                Dim anaKonum, zipKonum As String
                anaKonum = "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\node_modules"
                zipKonum = "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\node_modules\node_modules.zip"
            ElseIf denemeonayı = MsgBoxResult.No Then
                MsgBox("Bot oluşturma işlemi iptal edildi.!", MsgBoxStyle.Exclamation, Application.ProductName)
                Me.Close()
            End If
        End Try
    End Sub

    Public Sub ayarlar()
        Try
            Dim ayarlardosyası As StreamWriter = File.CreateText("C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\ayarlar.json")
            Dim sahipid As String
            Dim api As String = "AIzaSyDbewrEEQW5tHmQzuBvVpM00C4dg6uc92Q"
            Dim prefix As String
            Dim passes As String = "1"
            Dim token As String = TextBox2.Text
            sahipid = InputBox("BOT Sahibinin Discord Kullanıcı ID : ", Title:="Sahip ID")
            prefix = InputBox("BOT Prefix : ", Title:="Prefix")
            ayarlardosyası.Write("{")
            ayarlardosyası.WriteLine()
            ayarlardosyası.WriteLine("    ""prefix""" & ":" & " " & tirnak.Text & prefix & tirnak.Text & ",")
            ayarlardosyası.WriteLine("    ""api""" & ":" & " " & tirnak.Text & api & tirnak.Text & ",")
            ayarlardosyası.WriteLine("    ""sahip""" & ":" & " " & tirnak.Text & sahipid & tirnak.Text & ",")
            ayarlardosyası.WriteLine("    ""token""" & ":" & " " & tirnak.Text & token & tirnak.Text & ",")
            ayarlardosyası.WriteLine("    ""passes""" & ":" & " " & tirnak.Text & passes & tirnak.Text)
            ayarlardosyası.WriteLine("}")
            ayarlardosyası.Close()
        Catch ex As Exception
            MsgBox("'ayarlar.json' oluşturulurken problem çıktı", MsgBoxStyle.Exclamation, Application.ProductName)
            Dim denemeonayı As String = MsgBox("Tekrardan denemek ister misiniz?", MsgBoxStyle.YesNo, Application.ProductName)
            If denemeonayı = MsgBoxResult.Yes Then
                Dim ayarlardosyası As StreamWriter = File.CreateText("C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\ayarlar.json")
                Dim sahipid As String
                Dim api As String = "AIzaSyDbewrEEQW5tHmQzuBvVpM00C4dg6uc92Q"
                Dim prefix As String
                Dim passes As String = "1"
                Dim token As String = TextBox2.Text
                sahipid = InputBox("BOT Sahibinin Discord Kullanıcı ID : ", Title:="Sahip ID")
                prefix = InputBox("BOT Prefix : ", Title:="Prefix")
                ayarlardosyası.Write("{")
                ayarlardosyası.WriteLine()
                ayarlardosyası.WriteLine("    ""prefix""" & ":" & " " & tirnak.Text & prefix & tirnak.Text & ",")
                ayarlardosyası.WriteLine("    ""api""" & ":" & " " & tirnak.Text & api & tirnak.Text & ",")
                ayarlardosyası.WriteLine("    ""sahip""" & ":" & " " & tirnak.Text & sahipid & tirnak.Text & ",")
                ayarlardosyası.WriteLine("    ""token""" & ":" & " " & tirnak.Text & token & tirnak.Text & ",")
                ayarlardosyası.WriteLine("    ""passes""" & ":" & " " & tirnak.Text & passes & tirnak.Text)
                ayarlardosyası.WriteLine("}")
                ayarlardosyası.Close()
            ElseIf denemeonayı = MsgBoxResult.No Then
                MsgBox("Bot oluşturma işlemi iptal edildi.!", MsgBoxStyle.Exclamation, Application.ProductName)
                Me.Close()
            End If
        End Try
    End Sub
    Public Sub baslat()
        Try
            Dim baslat_bat As System.IO.StreamWriter = System.IO.File.CreateText("C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\baslat.bat")
            baslat_bat.Write("echo off")
            baslat_bat.WriteLine()
            baslat_bat.WriteLine("title " & TextBox1.Text & " BOT Ana Paneli")
            baslat_bat.WriteLine("color 0f")
            baslat_bat.WriteLine("cls")
            baslat_bat.WriteLine(":a")
            baslat_bat.WriteLine("node bot.js")
            baslat_bat.WriteLine("goto a")
            baslat_bat.Close()
        Catch ex As Exception
            MsgBox("'baslat.bat' oluşturulurken problem çıktı", MsgBoxStyle.Exclamation, Application.ProductName)
            Dim denemeonayı As String = MsgBox("Tekrardan denemek ister misiniz?", MsgBoxStyle.YesNo, Application.ProductName)
            If denemeonayı = MsgBoxResult.Yes Then
                Dim baslat_bat As System.IO.StreamWriter = System.IO.File.CreateText("C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\baslat.bat")
                baslat_bat.WriteLine("echo off")
                baslat_bat.WriteLine()
                baslat_bat.WriteLine("title " & TextBox1.Text & " BOT Ana Paneli")
                baslat_bat.WriteLine("color 0f")
                baslat_bat.WriteLine("cls")
                baslat_bat.WriteLine(":a")
                baslat_bat.WriteLine("node bot.js")
                baslat_bat.WriteLine("goto a")
                baslat_bat.Close()
            ElseIf denemeonayı = MsgBoxResult.No Then
                MsgBox("Bot oluşturma işlemi iptal edildi.!", MsgBoxStyle.Exclamation, Application.ProductName)
                Me.Close()
            End If
        End Try
    End Sub
    Public Sub komutdownload()
        Try
            My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/%C3%A7ekili%C5%9F.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\çekiliş.js")
            My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/emojiyaz%C4%B1.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\emojiyazı.js")
            My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/kick.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\kick.js")
            My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/mute.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\mute.js")
            My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/reboot.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\reboot.js")
            My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/rolver.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\rolver.js")
            My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/sunucukur.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\sunucukur.js")
            My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/unmute.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\unmute.js")
            My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/yaz.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\yaz.js")
            My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/ban.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\ban.js")
            My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/duyuru.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\duyuru.js")
            My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/istatistik.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\istatistik.js")
            My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/kullan%C4%B1c%C4%B1bilgim.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\kullanııcbilgim.js")
            My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/oylama.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\oylama.js")
            My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/reklamengelle.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\reklamengelle.js")
            My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/sahip.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\sahip.js")
            My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/tekmeat.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\tekmeat.js")
            My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/uyar.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\uyar.js")
            My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/bayrak.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\bayrak.js")
            My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/emojikur.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\emojikur.js")
            My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/%C4%B1smarla.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\ısmarla.js")
            My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/mesajd%C3%B6nd%C3%BCr.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\mesajdöndür.js")
            My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/ping.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\ping.js")
            My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/rol_al.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\rol_al.js")
            My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/sunucubilgi.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\sunucubilgi.js")
            My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/temizle.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\temzile.js")
            My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/wasted.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\wasted.js")
            My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/reklamengelle.json", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\jsonlar\reklamengelle.json")
        Catch ex As Exception
            MsgBox("'komutlar' indirilerken problem çıktı.", MsgBoxStyle.Exclamation, Application.ProductName)
            Dim denemeonayı As String = MsgBox("Tekrardan denemek ister misiniz?", MsgBoxStyle.YesNo, Application.ProductName)
            If denemeonayı = MsgBoxResult.Yes Then
                My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/%C3%A7ekili%C5%9F.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\çekiliş.js")
                My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/emojiyaz%C4%B1.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\emojiyazı.js")
                My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/kick.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\kick.js")
                My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/mute.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\mute.js")
                My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/reboot.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\reboot.js")
                My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/rolver.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\rolver.js")
                My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/sunucukur.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\sunucukur.js")
                My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/unmute.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\unmute.js")
                My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/yaz.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\yaz.js")
                My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/ban.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\ban.js")
                My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/duyuru.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\duyuru.js")
                My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/istatistik.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\istatistik.js")
                My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/kullan%C4%B1c%C4%B1bilgim.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\kullanııcbilgim.js")
                My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/oylama.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\oylama.js")
                My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/reklamengelle.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\reklamengelle.js")
                My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/sahip.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\sahip.js")
                My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/tekmeat.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\tekmeat.js")
                My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/uyar.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\uyar.js")
                My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/bayrak.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\bayrak.js")
                My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/emojikur.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\emojikur.js")
                My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/%C4%B1smarla.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\ısmarla.js")
                My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/mesajd%C3%B6nd%C3%BCr.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\mesajdöndür.js")
                My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/ping.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\ping.js")
                My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/rol_al.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\rol_al.js")
                My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/sunucubilgi.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\sunucubilgi.js")
                My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/temizle.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\temzile.js")
                My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/wasted.js", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\komutlar\wasted.js")
                My.Computer.Network.DownloadFile("https://furkan-database.glitch.me/discord-bot-studio/komutlar/reklamengelle.json", "C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\jsonlar\reklamengelle.json")
            ElseIf denemeonayı = MsgBoxResult.No Then
                MsgBox("Bot oluşturma işlemi iptal edildi.!", MsgBoxStyle.Exclamation, Application.ProductName)
                Me.Close()
            End If
        End Try
    End Sub
    Private Sub packsett()
        Try
            Dim neyazsin As String = InputBox("Botunuzun durumunda ne yazmasını istersiniz?", Title:=
                                           "Botun durumunda ne yazsın?")
            Dim hazir_js As System.IO.StreamWriter = System.IO.File.CreateText("C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\events\ready.js")
            hazir_js.Write("const chalk = require('chalk');")
            hazir_js.WriteLine("const moment = require('moment');")
            hazir_js.WriteLine("const Discord = require('discord.js');")
            hazir_js.WriteLine("const ayarlar = require('../ayarlar.json');")
            hazir_js.WriteLine()
            hazir_js.WriteLine("var prefix = ayarlar.prefix;")
            hazir_js.WriteLine()
            hazir_js.WriteLine("module.exports = client => {")
            hazir_js.WriteLine("  console.log(`[${moment().format('YYYY-MM-DD HH:mm:ss')}] BOT: Aktif, Komutlar yüklendi!`);")
            hazir_js.WriteLine("  console.log(`[${moment().format('YYYY-MM-DD HH:mm:ss')}] BOT: ${client.user.username} ismi ile giriş yapıldı!`);")
            hazir_js.WriteLine("  client.user.setStatus(" & tirnak.Text & "online" & tirnak.Text & ");")
            hazir_js.WriteLine("client.user.setGame(" & tirnak.Text & neyazsin & " | " & tirnak.Text & "+ client.guilds.size + " & tirnak.Text & "Sunucu " & tirnak.Text & "+ client.users.size + " & tirnak.Text & " Kullanıcı " & tirnak.Text & ");")
            hazir_js.WriteLine("}")
            hazir_js.Close()
        Catch ex As Exception
            MsgBox("'ready.js' oluşturulurken problem çıktı", MsgBoxStyle.Exclamation, Application.ProductName)
            Dim denemeonayı As String = MsgBox("Tekrardan denemek ister misiniz?", MsgBoxStyle.YesNo, Application.ProductName)
            If denemeonayı = MsgBoxResult.Yes Then
                Dim neyazsin As String = InputBox("Botunuzun durumunda ne yazmasını istersiniz?", Title:=
                                           "Botun durumunda ne yazsın?")
                Dim hazir_js As System.IO.StreamWriter = System.IO.File.CreateText("C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\events\ready.js")
                hazir_js.Write("const chalk = require('chalk');")
                hazir_js.WriteLine("const moment = require('moment');")
                hazir_js.WriteLine("const Discord = require('discord.js');")
                hazir_js.WriteLine("const ayarlar = require('../ayarlar.json');")
                hazir_js.WriteLine()
                hazir_js.WriteLine("var prefix = ayarlar.prefix;")
                hazir_js.WriteLine()
                hazir_js.WriteLine("module.exports = client => {")
                hazir_js.WriteLine("  console.log(`[${moment().format('YYYY-MM-DD HH:mm:ss')}] BOT: Aktif, Komutlar yüklendi!`);")
                hazir_js.WriteLine("  console.log(`[${moment().format('YYYY-MM-DD HH:mm:ss')}] BOT: ${client.user.username} ismi ile giriş yapıldı!`);")
                hazir_js.WriteLine("  client.user.setStatus(" & tirnak.Text & "online" & tirnak.Text & ");")
                hazir_js.WriteLine("client.user.setGame(" & tirnak.Text & neyazsin & " | " & "+ client.guilds.size + " & tirnak.Text & "Sunucu " & tirnak.Text & "+ client.users.size + " & tirnak.Text & " Kullanıcı " & tirnak.Text & ");")
                hazir_js.WriteLine("}")
                hazir_js.Close()
            ElseIf denemeonayı = MsgBoxResult.No Then
                MsgBox("Bot oluşturma işlemi iptal edildi.!", MsgBoxStyle.Exclamation, Application.ProductName)
                Me.Close()
            End If
        End Try
    End Sub
    Private Sub package_json()
        Try
            MsgBox(TextBox1.Text & " | Botunuzun bilgilerini eksiksiz giriniz.! sizden belirli bilgiler istenicektir.", MsgBoxStyle.Information, Application.ProductName)
            Dim aciklama As String = InputBox("Botunuzun açıklamasını yazınız", Title:=
                                              "Açıklama yazınız")
            Dim yapimci As String = InputBox("Botunuzun yapımcısını yazınız", Title:=
                                             "Yapımcı adı yazınız")
            Dim package_json_file As StreamWriter = File.CreateText("C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\package.json")
            package_json_file.Write("{")
            package_json_file.WriteLine()
            package_json_file.WriteLine("  " & tirnak.Text & "name" & tirnak.Text & ": " & tirnak.Text & TextBox1.Text & tirnak.Text & ",")
            package_json_file.WriteLine("  " & tirnak.Text & "version" & tirnak.Text & ": " & tirnak.Text & "0.0.1" & tirnak.Text & ",")
            package_json_file.WriteLine("  " & tirnak.Text & "description" & tirnak.Text & ": " & tirnak.Text & aciklama & tirnak.Text & ",")
            package_json_file.WriteLine("  " & tirnak.Text & "main" & tirnak.Text & ": " & tirnak.Text & "bot.js" & tirnak.Text & ",")
            package_json_file.WriteLine("  " & tirnak.Text & "scripts" & tirnak.Text & ": " & "{")
            package_json_file.WriteLine("  " & tirnak.Text & "test" & tirnak.Text & ": " & tirnak.Text & "node bot.js" & tirnak.Text)
            package_json_file.WriteLine("  },")
            package_json_file.WriteLine("  " & tirnak.Text & "author" & tirnak.Text & ": " & tirnak.Text & yapimci & tirnak.Text & ",")
            package_json_file.WriteLine("  " & tirnak.Text & "license" & tirnak.Text & ": " & tirnak.Text & "ISC" & tirnak.Text & ",")
            package_json_file.WriteLine("  " & tirnak.Text & "dependencies" & tirnak.Text & ": " & "{")
            package_json_file.WriteLine("  " & tirnak.Text & "cat-names" & tirnak.Text & ": " & tirnak.Text & "^3.0.0" & tirnak.Text & ",")
            package_json_file.WriteLine("  " & tirnak.Text & "chalk" & tirnak.Text & ": " & tirnak.Text & "^2.3.0" & tirnak.Text & ",")
            package_json_file.WriteLine("  " & tirnak.Text & "cleverbot-node" & tirnak.Text & ": " & tirnak.Text & "^0.3.11" & tirnak.Text & ",")
            package_json_file.WriteLine("  " & tirnak.Text & "discord.js" & tirnak.Text & ": " & tirnak.Text & "^11.3.2" & tirnak.Text & ",")
            package_json_file.WriteLine("  " & tirnak.Text & "discord.js-commando" & tirnak.Text & ": " & tirnak.Text & "^0.10.0" & tirnak.Text & ",")
            package_json_file.WriteLine("  " & tirnak.Text & "jimp" & tirnak.Text & ": " & tirnak.Text & "^0.6.0" & tirnak.Text & ",")
            package_json_file.WriteLine("  " & tirnak.Text & "moment" & tirnak.Text & ": " & tirnak.Text & "^2.24.0" & tirnak.Text & ",")
            package_json_file.WriteLine("  " & tirnak.Text & "moment-duration-format" & tirnak.Text & ": " & tirnak.Text & "^1.3.0" & tirnak.Text & ",")
            package_json_file.WriteLine("  " & tirnak.Text & "ms" & tirnak.Text & ": " & tirnak.Text & "^2.0.0" & tirnak.Text)
            package_json_file.WriteLine("  }")
            package_json_file.WriteLine("}")
            package_json_file.Close()
            MsgBox("Botunuz başarılı bir şekilde oluşturuldu.! Discord Bot Studio şimdilik bu kadar özelliğe sahip https://discord.gg/Cjc99Js adresinden bize fikirlerinizi belirte bilirsiniz.", MsgBoxStyle.Information, Application.ProductName)
            MsgBox("Botunuza Belgeler\" & TextBox1.Text & " Klasöründen ulaşabilirsiniz.", MsgBoxStyle.Information, Application.ProductName)
            Me.Close()
        Catch ex As Exception

            MsgBox("'package.json' oluşturulurken problem çıktı", MsgBoxStyle.Exclamation, Application.ProductName)
            Dim denemeonayı As String = MsgBox("Tekrardan denemek ister misiniz?", MsgBoxStyle.YesNo, Application.ProductName)
            If denemeonayı = MsgBoxResult.Yes Then
                MsgBox(TextBox1.Text & " | Botunuzun bilgilerini eksiksiz giriniz.! sizden belirli bilgiler istenecektir.", MsgBoxStyle.Information, Application.ProductName)
                Dim aciklama As String = InputBox("Botunuzun açıklamasını yazınız", Title:=
                                                  "Açıklama yazınız")
                Dim yapimci As String = InputBox("Botunuzun yapımcısını yazınız", Title:=
                                                 "Yapımcı adı yazınız")
                Dim package_json_file As StreamWriter = File.CreateText("C:\Users\" & Environment.UserName & "\Documents\" & TextBox1.Text & "\package.json")
                package_json_file.Write("{")
                package_json_file.WriteLine()
                package_json_file.WriteLine("  " & tirnak.Text & "name" & tirnak.Text & ": " & tirnak.Text & TextBox1.Text & tirnak.Text & ",")
                package_json_file.WriteLine("  " & tirnak.Text & "version" & tirnak.Text & ": " & tirnak.Text & "0.0.1" & tirnak.Text & ",")
                package_json_file.WriteLine("  " & tirnak.Text & "description" & tirnak.Text & ": " & tirnak.Text & aciklama & tirnak.Text & ",")
                package_json_file.WriteLine("  " & tirnak.Text & "main" & tirnak.Text & ": " & tirnak.Text & "bot.js" & tirnak.Text & ",")
                package_json_file.WriteLine("  " & tirnak.Text & "scripts" & tirnak.Text & ": " & "{")
                package_json_file.WriteLine("  " & tirnak.Text & "test" & tirnak.Text & ": " & tirnak.Text & "node bot.js" & tirnak.Text)
                package_json_file.WriteLine("  },")
                package_json_file.WriteLine("  " & tirnak.Text & "author" & tirnak.Text & ": " & tirnak.Text & yapimci & tirnak.Text & ",")
                package_json_file.WriteLine("  " & tirnak.Text & "license" & tirnak.Text & ": " & tirnak.Text & "ISC" & tirnak.Text & ",")
                package_json_file.WriteLine("  " & tirnak.Text & "dependencies" & tirnak.Text & ": " & "{")
                package_json_file.WriteLine("  " & tirnak.Text & "cat-names" & tirnak.Text & ": " & tirnak.Text & "^3.0.0" & tirnak.Text & ",")
                package_json_file.WriteLine("  " & tirnak.Text & "chalk" & tirnak.Text & ": " & tirnak.Text & "^2.3.0" & tirnak.Text & ",")
                package_json_file.WriteLine("  " & tirnak.Text & "cleverbot-node" & tirnak.Text & ": " & tirnak.Text & "^0.3.11" & tirnak.Text & ",")
                package_json_file.WriteLine("  " & tirnak.Text & "discord.js" & tirnak.Text & ": " & tirnak.Text & "^11.3.2" & tirnak.Text & ",")
                package_json_file.WriteLine("  " & tirnak.Text & "discord.js-commando" & tirnak.Text & ": " & tirnak.Text & "^0.10.0" & tirnak.Text & ",")
                package_json_file.WriteLine("  " & tirnak.Text & "jimp" & tirnak.Text & ": " & tirnak.Text & "^0.6.0" & tirnak.Text & ",")
                package_json_file.WriteLine("  " & tirnak.Text & "moment" & tirnak.Text & ": " & tirnak.Text & "^2.24.0" & tirnak.Text & ",")
                package_json_file.WriteLine("  " & tirnak.Text & "moment-duration-format" & tirnak.Text & ": " & tirnak.Text & "^1.3.0" & tirnak.Text & ",")
                package_json_file.WriteLine("  " & tirnak.Text & "ms" & tirnak.Text & ": " & tirnak.Text & "^2.0.0" & tirnak.Text)
                package_json_file.WriteLine("  }")
                package_json_file.WriteLine("}")
                package_json_file.Close()
                MsgBox("Botunuz başarılı bir şekilde oluşturuldu.! Discord Bot Studio şimdilik bu kadar özelliğe sahip https://discord.gg/Cjc99Js adresinden bize fikirlerinizi belirte bilirsiniz.", MsgBoxStyle.Information, Application.ProductName)
                MsgBox("Botunuza Belgeler\" & TextBox1.Text & " Klasöründen ulaşabilirsiniz.", MsgBoxStyle.Information, Application.ProductName)
            ElseIf denemeonayı = MsgBoxResult.No Then
                MsgBox("Bot oluşturma işlemi iptal edildi.!", MsgBoxStyle.Exclamation, Application.ProductName)
                Me.Close()
            End If
        End Try
    End Sub
End Class
