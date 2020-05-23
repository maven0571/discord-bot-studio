<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class discord_js
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(discord_js))
        Me.FastColoredTextBox1 = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DosyaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YeniKomutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.KomutAçToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KomutKaydetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ÇıkışToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DüzenleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeriAlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YenileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.KesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KopyalaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YapıştırToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TümünüSeçToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BulToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.YerleştirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyarlarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenkModuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.OtomatikKaydetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.DosyaAdıAyarlaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DocumentMap1 = New FastColoredTextBoxNS.DocumentMap()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.AutocompleteMenu1 = New AutocompleteMenuNS.AutocompleteMenu()
        CType(Me.FastColoredTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FastColoredTextBox1
        '
        Me.FastColoredTextBox1.AllowSeveralTextStyleDrawing = True
        Me.FastColoredTextBox1.AutoCompleteBrackets = True
        Me.FastColoredTextBox1.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.AutocompleteMenu1.SetAutocompleteMenu(Me.FastColoredTextBox1, Me.AutocompleteMenu1)
        Me.FastColoredTextBox1.AutoIndentCharsPatterns = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "^\s*[\w\.]+(\s\w+)?\s*(?<range>=)\s*(?<range>[^;]+);" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.FastColoredTextBox1.AutoScrollMinSize = New System.Drawing.Size(723, 266)
        Me.FastColoredTextBox1.BackBrush = Nothing
        Me.FastColoredTextBox1.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2
        Me.FastColoredTextBox1.CharHeight = 14
        Me.FastColoredTextBox1.CharWidth = 8
        Me.FastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.FastColoredTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FastColoredTextBox1.IndentBackColor = System.Drawing.Color.White
        Me.FastColoredTextBox1.IsReplaceMode = False
        Me.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.JS
        Me.FastColoredTextBox1.LeftBracket = Global.Microsoft.VisualBasic.ChrW(40)
        Me.FastColoredTextBox1.LeftBracket2 = Global.Microsoft.VisualBasic.ChrW(123)
        Me.FastColoredTextBox1.LineNumberColor = System.Drawing.Color.MediumSlateBlue
        Me.FastColoredTextBox1.Location = New System.Drawing.Point(0, 24)
        Me.FastColoredTextBox1.Name = "FastColoredTextBox1"
        Me.FastColoredTextBox1.Paddings = New System.Windows.Forms.Padding(0)
        Me.FastColoredTextBox1.RightBracket = Global.Microsoft.VisualBasic.ChrW(41)
        Me.FastColoredTextBox1.RightBracket2 = Global.Microsoft.VisualBasic.ChrW(125)
        Me.FastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.FastColoredTextBox1.ServiceColors = CType(resources.GetObject("FastColoredTextBox1.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        Me.FastColoredTextBox1.Size = New System.Drawing.Size(617, 424)
        Me.FastColoredTextBox1.SourceTextBox = Me.FastColoredTextBox1
        Me.FastColoredTextBox1.TabIndex = 0
        Me.FastColoredTextBox1.Text = resources.GetString("FastColoredTextBox1.Text")
        Me.FastColoredTextBox1.Zoom = 100
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DosyaToolStripMenuItem, Me.DüzenleToolStripMenuItem, Me.AraToolStripMenuItem, Me.AyarlarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(617, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DosyaToolStripMenuItem
        '
        Me.DosyaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YeniKomutToolStripMenuItem, Me.ToolStripSeparator1, Me.KomutAçToolStripMenuItem, Me.KomutKaydetToolStripMenuItem, Me.ToolStripSeparator2, Me.ÇıkışToolStripMenuItem})
        Me.DosyaToolStripMenuItem.Name = "DosyaToolStripMenuItem"
        Me.DosyaToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.DosyaToolStripMenuItem.Text = "Dosya"
        '
        'YeniKomutToolStripMenuItem
        '
        Me.YeniKomutToolStripMenuItem.Name = "YeniKomutToolStripMenuItem"
        Me.YeniKomutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.YeniKomutToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.YeniKomutToolStripMenuItem.Text = "Yeni komut"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(175, 6)
        '
        'KomutAçToolStripMenuItem
        '
        Me.KomutAçToolStripMenuItem.Name = "KomutAçToolStripMenuItem"
        Me.KomutAçToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.KomutAçToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.KomutAçToolStripMenuItem.Text = "Komut aç"
        '
        'KomutKaydetToolStripMenuItem
        '
        Me.KomutKaydetToolStripMenuItem.Name = "KomutKaydetToolStripMenuItem"
        Me.KomutKaydetToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.KomutKaydetToolStripMenuItem.Text = "Komut kaydet"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(175, 6)
        '
        'ÇıkışToolStripMenuItem
        '
        Me.ÇıkışToolStripMenuItem.Name = "ÇıkışToolStripMenuItem"
        Me.ÇıkışToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.ÇıkışToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ÇıkışToolStripMenuItem.Text = "Çıkış"
        '
        'DüzenleToolStripMenuItem
        '
        Me.DüzenleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeriAlToolStripMenuItem, Me.YenileToolStripMenuItem, Me.ToolStripSeparator3, Me.KesToolStripMenuItem, Me.KopyalaToolStripMenuItem, Me.YapıştırToolStripMenuItem, Me.SilToolStripMenuItem, Me.TümünüSeçToolStripMenuItem})
        Me.DüzenleToolStripMenuItem.Name = "DüzenleToolStripMenuItem"
        Me.DüzenleToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.DüzenleToolStripMenuItem.Text = "Düzenle"
        '
        'GeriAlToolStripMenuItem
        '
        Me.GeriAlToolStripMenuItem.Name = "GeriAlToolStripMenuItem"
        Me.GeriAlToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.GeriAlToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.GeriAlToolStripMenuItem.Text = "Geri al"
        '
        'YenileToolStripMenuItem
        '
        Me.YenileToolStripMenuItem.Name = "YenileToolStripMenuItem"
        Me.YenileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.YenileToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.YenileToolStripMenuItem.Text = "Yenile"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(179, 6)
        '
        'KesToolStripMenuItem
        '
        Me.KesToolStripMenuItem.Name = "KesToolStripMenuItem"
        Me.KesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.KesToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.KesToolStripMenuItem.Text = "Kes"
        '
        'KopyalaToolStripMenuItem
        '
        Me.KopyalaToolStripMenuItem.Name = "KopyalaToolStripMenuItem"
        Me.KopyalaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.KopyalaToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.KopyalaToolStripMenuItem.Text = "Kopyala"
        '
        'YapıştırToolStripMenuItem
        '
        Me.YapıştırToolStripMenuItem.Name = "YapıştırToolStripMenuItem"
        Me.YapıştırToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.YapıştırToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.YapıştırToolStripMenuItem.Text = "Yapıştır"
        '
        'SilToolStripMenuItem
        '
        Me.SilToolStripMenuItem.Name = "SilToolStripMenuItem"
        Me.SilToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.SilToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.SilToolStripMenuItem.Text = "Sil"
        '
        'TümünüSeçToolStripMenuItem
        '
        Me.TümünüSeçToolStripMenuItem.Name = "TümünüSeçToolStripMenuItem"
        Me.TümünüSeçToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.TümünüSeçToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.TümünüSeçToolStripMenuItem.Text = "Tümünü seç"
        '
        'AraToolStripMenuItem
        '
        Me.AraToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BulToolStripMenuItem, Me.ToolStripSeparator4, Me.YerleştirToolStripMenuItem, Me.GitToolStripMenuItem})
        Me.AraToolStripMenuItem.Name = "AraToolStripMenuItem"
        Me.AraToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.AraToolStripMenuItem.Text = "Ara"
        '
        'BulToolStripMenuItem
        '
        Me.BulToolStripMenuItem.Name = "BulToolStripMenuItem"
        Me.BulToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.BulToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.BulToolStripMenuItem.Text = "Bul"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(156, 6)
        '
        'YerleştirToolStripMenuItem
        '
        Me.YerleştirToolStripMenuItem.Name = "YerleştirToolStripMenuItem"
        Me.YerleştirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.YerleştirToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.YerleştirToolStripMenuItem.Text = "Yerleştir"
        '
        'GitToolStripMenuItem
        '
        Me.GitToolStripMenuItem.Name = "GitToolStripMenuItem"
        Me.GitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.GitToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.GitToolStripMenuItem.Text = "Git"
        '
        'AyarlarToolStripMenuItem
        '
        Me.AyarlarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RenkModuToolStripMenuItem, Me.ToolStripSeparator5, Me.OtomatikKaydetToolStripMenuItem, Me.ToolStripSeparator6, Me.DosyaAdıAyarlaToolStripMenuItem})
        Me.AyarlarToolStripMenuItem.Name = "AyarlarToolStripMenuItem"
        Me.AyarlarToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.AyarlarToolStripMenuItem.Text = "Ayarlar"
        '
        'RenkModuToolStripMenuItem
        '
        Me.RenkModuToolStripMenuItem.CheckOnClick = True
        Me.RenkModuToolStripMenuItem.Name = "RenkModuToolStripMenuItem"
        Me.RenkModuToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.RenkModuToolStripMenuItem.Text = "Renk modu"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(159, 6)
        '
        'OtomatikKaydetToolStripMenuItem
        '
        Me.OtomatikKaydetToolStripMenuItem.CheckOnClick = True
        Me.OtomatikKaydetToolStripMenuItem.Name = "OtomatikKaydetToolStripMenuItem"
        Me.OtomatikKaydetToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.OtomatikKaydetToolStripMenuItem.Text = "Otomatik kaydet"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(159, 6)
        '
        'DosyaAdıAyarlaToolStripMenuItem
        '
        Me.DosyaAdıAyarlaToolStripMenuItem.Name = "DosyaAdıAyarlaToolStripMenuItem"
        Me.DosyaAdıAyarlaToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.DosyaAdıAyarlaToolStripMenuItem.Text = "Dosya adı ayarla"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Javascript dosyası|*.js*"
        Me.OpenFileDialog1.Title = "Apple editor - discord.js | Dosya aç"
        '
        'DocumentMap1
        '
        Me.DocumentMap1.BackColor = System.Drawing.Color.White
        Me.DocumentMap1.Dock = System.Windows.Forms.DockStyle.Right
        Me.DocumentMap1.ForeColor = System.Drawing.Color.Gainsboro
        Me.DocumentMap1.Location = New System.Drawing.Point(516, 24)
        Me.DocumentMap1.Name = "DocumentMap1"
        Me.DocumentMap1.Size = New System.Drawing.Size(101, 424)
        Me.DocumentMap1.TabIndex = 2
        Me.DocumentMap1.Target = Me.FastColoredTextBox1
        Me.DocumentMap1.Text = "DocumentMap1"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'Timer4
        '
        Me.Timer4.Enabled = True
        '
        'AutocompleteMenu1
        '
        Me.AutocompleteMenu1.AppearInterval = 50
        Me.AutocompleteMenu1.Colors = CType(resources.GetObject("AutocompleteMenu1.Colors"), AutocompleteMenuNS.Colors)
        Me.AutocompleteMenu1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.AutocompleteMenu1.ImageList = Nothing
        Me.AutocompleteMenu1.Items = New String() {"ACCEPTED", "api", "attachment", "ANIMATED_ICON", "ALL_MEMBERS", "all", "AQUA", "ALL", "ALL: null", "ALLS", "allowDMs", "attachments", "awaitMessages", "args", "aliases:", "avatar", "avatarURL", "acceptInvite", "array", "afkChannel", "afkChannelID", "afkTimeout", "applicationID", "available", "Actions", "author", "add", "addBlankField", "addField", "attachFile", "action", "actionType", "addMember", "addFriend", "awaitReactions", "author", "acknowledge", "addUser", "addRestrictedGuild", "addRole", "addRoles", "BANNER", "binary", "BLUE", "BOT_ADD: 28", "BOT_ONLY_ENDPOINT", "BOT_PROHIBITED_ENDPOINT", "BULK_DELETE_MESSAGE_TOO_OLD", "bitfield", "blocked", "broadcastEval", "bulkDelete", "broadcasts", "browser", "block", "ban", "build", "bannable", "bot", "botPublic", "botRequireCodeGrant", "broadcast", "broadcastEval", "block", "cdn", "COMMERCE", "ClientPresence", "Guild", "GuildMember", "CategoryChannel", "collection", "CHANNEL", "CREATE", "CHANNEL_CREATE: 10", "CHANNEL_DELETE: 12", "CHANNEL_OVERWRITE_CREATE: 13", "CHANNEL_OVERWRITE_DELETE: 15", "CHANNEL_OVERWRITE_UPDATE: 14", "CHANNEL_UPDATE: 11", "CANNOT_EDIT_MESSAGE_BY_OTHER", "CANNOT_EXECUTE_ON_DM", "CANNOT_EXECUTE_ON_SYSTEM_MESSAGE", "CANNOT_MESSAGE_USER", "CANNOT_PIN_MESSAGE_IN_OTHER_CHANNEL", "CANNOT_SEND_EMPTY_MESSAGE", "CANNOT_SEND_MESSAGES_IN_VOICE_CHANNEL", "CHANNEL_VERIFICATION_LEVEL_TOO_HIGH", "CUSTOM_STATUS", "changes", "channel", "clearInterval", "clearTimeout", "code", "collected", "comparePositionTo", "comparePositions", "createShard", "createVoiceBroadcast", "createdAt", "createGroupDM", "createGuild", "channelOverrides", "channelCreate", "channelDelete", "channelPinsUpdate", "channelUpdate", "clientUserGuildSettingsUpdate", "clientUserSettingsUpdate", "conf", "connections", "clone", "createCollectorD", "createInvite", "createMessageCollector", "createWebhook", "color", "reaction", "calculatedPosition", "count", "CHANNELS_PATTERNS", "createdTimestamp", "collect", "clearReactions", "createReactionCollector", "content", "cleanContent", "createDM", "colorRole", "createInvite", "createChannel", "createEmoji", "createRole", "createCollectorD", "createMessageCollector", "awaitMessages", "concat", "convertEmoticons", "client.login("""");", "client.login(token);", "channels", "console.log("""")", "console", "client()", "Discord.Client();", "const client = new Discord.Client();", "const Discord = require('discord.js');", "client.on", "const", "dynamic", "DISCOVERABLE", "DMChannel", "DISABLED", "date", "DARKER_GREY", "DARK_AQUA", "DARK_BLUE", "DARK_GOLD", "DARK_GREEN", "DARK_GREY", "DARK_NAVY", "DARK_ORANGE", "DARK_PURPLE", "DARK_RED", "DARK_VIVID_PINK", "DEFAULT", "dispose", "dnd", "DELETE", "DEFAULTS", "defaultChannelD", "defaultRole", "deletable", "deleteEmoji", "debug", "description", "destroy", "destroyed", "description:", "disconnect", "discriminator", "displayAvatarURL", "dmChannel", "defaultGuildsRestricted", "detectPlatformAccounts", "developerMode", "deleteAll", "deaf", "displayColor", "displayHexColor", "displayName", "delete", "deleteDM", "defaultAvatarURL", "discriminator", "displayAvatarURL", "dmChannel", "expireGracePeriod", "expireBehavior", "EMOJI", "EMOJI_CREATE: 60", "EMOJI_DELETE: 62", "EMOJI_UPDATE: 61", "EMBED_DISABLED", "edit", "editable", "email", "embedEnabled", "emojis", "enableTTSCommand", "end", "ended", "env", "equals", "every", "exists", "explicitContentFilter", "enabled:", "emojiCreate", "emojiDelete", "emojiUpdate", "eval", "end", "equals", "emoji", "EVERYONE_PATTERNS", "everyone", "embed", "editCode", "editedAt", "editedTimestamp", "edits", "embeds", "explicitContentFilter", "error", "exports", "executor", "extra", "escapeMarkdown", "expiresAt", "expiresTimestamp", "format", "FEATURABLE", "FLAGSS", "features", "filename", "filesize", "flags", "footer", "function", "fetchApplication", "fetchInvite", "fetchUser", "fetchVoiceRegions", "fetchWebhook", "fetchMentions", "fetchProfile", "filter", "filterArray", "find", "findAll", "first", "firstKey", "fetchAuditLogs", "fetchBans", "fetchInvites", "fetchMember", "fetchMembers", "fetchVoiceRegions", "fetchWebhooks", "fetchMessage", "fetchPinnedMessages", "entries", "fields", "file", "fetchProfile", "fetchClientValue", "fetchClientValues", "fetchRecommendedShards", "friends", "fetchUsers", "fetchMessage", "fetchMessages", "fetchPinnedMessages", "friendSources", "GuildEmoji", "GOLD", "GREEN", "GREY", "GUILD", "GUILD_UPDATE: 1", "game", "generateInvite", "guild", "guildOnly:", "guilds", "guildBanAdd", "guildBanRemove", "guildCreate", "guildDelete", "guildMemberAdd", "guildMemberAvailable", "guildMemberRemove", "guildMembersChunk", "guildMemberSpeaking", "guildMemberUpdate", "guildUnavailable", "guildUpdate", "guildSettings", "guildID", "guildPositions", "help", "has", "hasPermission", "hasPermissions", "hexColor", "hoist", "hasPermission", "hasPermissions", "height", "hexColor", "highestRole", "hit", "hoistRole", "size", "systemChannelFlags", "StoreChannel", "STREAMING", "secret", "setGuildPosition", "settings", "showCurrentGame", "singleton", "speaking", "splash", "start", "startTyping", "status", "stopTyping", "stream", "suppressEveryone", "system", "setInterval", "setTimeout", "sweepMessages", "syncGuilds", "send", "sendEmbed", "sendFile", "sendMessage", "setActivity", "setAFK", "setAvatar", "setEmail", "setGame", "setNote", "setPassword", "setPresence", "setStatus", "setUsername", "some", "sort", "streaming", "search", "sendFiles", "sendMessage", "setIcon", "splashURL", "suppressEveryone", "systemChannel", "systemChannelID", "search", "setAFKChannel", "setAFKTimeout", "setChannelPosition", "setChannelPositions", "setExplicitContentFilter", "setOwner", "setPosition", "setRegion", "setRolePosition", "setSplash", "setSystemChannel", "setVerificationLevel", "sync", "setName", "setParent", "setPosition", "setTopic", "selfDeaf", "selfMute", "serverDeaf", "serverMute", "speaking", "sendCodeD", "sendEmbedD", "sendFileD", "sendMessage", "setDeaf", "setMute", "setNickname", "setRoles", "setVoiceChannel", "stop", "reset", "serialize", "setAuthor", "setColor", "setDescription", "setFooter", "setImage", "setThumbnail", "setTimestamp", "setTitle", "setURL", "serialize", "setColor", "setHoist", "setMentionable", "setPermissions", "shardArgs", "shards", "spawn", "setBitrate", "search", "sendMessage", "setParent", "setPosition", "setTopic", "startTyping", "stopTyping", "sendCode", "sendMessage", "setNote", "splitMessage", "shard", "Role", "RANDOM", "RED", "ROLE", "ROLE_CREATE: 30", "ROLE_DELETE: 32", "ROLE_UPDATE: 31", "REACTION_BLOCKED", "RESOURCE_OVERLOADED", "random", "randomKey", "react", "reactions", "redirectURIs", "reduce", "region", "removeFriend", "renderReactions", "restrictedGuilds", "resume", "roles", "rpcApplicationState", "rpcOrigins", "require", "reply", "run", "readyAt", "readyTimestamp", "ready", "reconnecting", "resume", "roleCreate", "roleDelete", "roleUpdate", "recipients", "reason", "roles", "removeRole", "removeRoles", "removeFriend", "raw", "respawn", "revoked", "remove", "resolve", "roles", "ROLES_PATTERNS", "received", "removeUser", "removeRestrictedGuild", "partyID", "PARTNERED", "PUBLIC", "PUBLIC_DISABLED", "Presence", "processID", "PURPLE", "PLAYING", "parent", "parentID", "permissions", "pruneMembers", "pin", "pinnable", "pinned", "position", "premium", "premiumSince", "presenceCount", "presences", "process", "provider", "proxyIconUrl", "permLevel:", "ping", "pings", "presences", "premium", "presence", "presenceUpdate", "presence", "permissionsIn", "presence", "permissionsFor", "passes", "paused", "player", "pause", "members", "messageNotifications", "muted", "permissionOverwrites", "message", "managed", "members", "mentionable", "members", "message", "maxProcessed", "max", "Message", "MessageReaction", "MEMBERS_WITHOUT_ROLES", "MENTIONS", "MEMBER_BAN_ADD: 22", "MEMBER_BAN_REMOVE: 23", "MEMBER_DISCONNECT: 27", "MEMBER_KICK: 20", "MEMBER_MOVE: 26", "MEMBER_PRUNE: 21", "MEMBER_ROLE_UPDATE: 25", "MEMBER_UPDATE: 24", "MESSAGE_BULK_DELETE: 73", "MESSAGE_DELETE: 72", "MESSAGE_PIN: 74", "MESSAGE_UNPIN: 75", "MAXIMUM_CHANNELS", "MAXIMUM_FRIENDS", "MAXIMUM_GUILDS", "MAXIMUM_INVITES", "MAXIMUM_OAUTH2_APPLICATIONS", "MAXIMUM_PINS", "MAXIMUM_REACTIONS", "MAXIMUM_ROLES", "MISSING_ACCESS", "MISSING_PERMISSIONS", "missingPermissions", "maxAge", "maxUses", "memberCount", "messageNotifications", "mobilePush", "mfaEnabled", "mobile", "me", "memberCount", "members", "messageNotifications", "mobilePush", "messageNotifications", "message", "mutualGuilds", "messageDelete", "messageDeleteBulk", "messageReactionAdd", "messageReactionRemove", "messageReactionRemoveAll", "messageUpdate", "message", "message.reply("""");", "managed", "manager", "map", "me", "messageDisplayCompact", "missing", "missingPermissions", "msg", "mute", "version", "VANITY_URL", "VERIFIED", "VIP_REGIONS", "VoiceState", "voiceChannel", "voiceChannelCount", "voiceChannelID", "voiceConnection", "voiceConnections", "voiceSessionID", "voiceStateUpdate", "value", "verificationLevel", "verified", "video", "WELCOME_SCREEN_ENABLED", "workerID", "WHITE", "WEBHOOK", "WEBHOOK_CREATE: 50", "WEBHOOK_DELETE: 52", "WEBHOOK_UPDATE: 51", "WATCHING", "warn", "webhookID", "width", "User", "USER", "UPDATE", "UNAUTHORIZED", "UNKNOWN_ACCOUNT", "UNKNOWN_APPLICATION", "UNKNOWN_CHANNEL", "UNKNOWN_EMOJI", "UNKNOWN_GUILD", "UNKNOWN_INTEGRATION", "UNKNOWN_INVITE", "UNKNOWN_MEMBER", "UNKNOWN_MESSAGE", "UNKNOWN_OVERWRITE", "UNKNOWN_PROVIDER", "UNKNOWN_ROLE", "UNKNOWN_TOKEN", "UNKNOWN_USER", "UNKNOWN_WEBHOOK", "USER_BANNED", "USERS_PATTERN", "unban", "unblock", "unblock", "unpin", "update", "update", "uptime", "url", "usage:", "user", "userNoteUpdate", "userUpdate", "username", "users", "uses", "TextChannel", "tag", "target", "targetType", "temporary", "text", "textChannelCount", "theme", "thumbnail", "time", "timestamp", "title", "toString", "token", "topic", "total", "totalShards", "totalStreamTime", "tts", "type", "typing", "typingCount", "typingDurationIn", "typingIn", "typingSinceIn", "typingStart", "typingStop", "ORANGE", "online", "old", "OAUTH2_APPLICATION_BOT_ABSENT", "on", "options", "overwritePermissions", "owner", "ownerID", "NEWS", "NewsChannel", "none", "NAVY", "NOTE_TOO_LONG", "name", "name:", "nameAcronym", "new", "next", "nickname", "nicks", "nonce", "note", "notes", "nsfw", "LIGHT_GREY", "LUMINOUS_VIVID_PINK", "LISTENING", "large", "last", "lastKey", "lastMessage", "lastMessageID", "launch", "leave", "locale", "log", "login", "key", "keyArray", "kick", "kickable", "isMemberMentioned", "isMentioned", "joinedAt", "joinedAt", "joinedTimestamp", "joinedTimestamp", "increment", "idle", "id", "identifier", "image", "inline", "inlineAttachmentMedia", "inlineEmbedMedia", "integrations", "inviter", "icon", "iconURL", "INVITED", "INVITE_SPLASH", "INTEGRATION", "INVITE", "MESSAGE", "INTEGRATION_CREATE: 80", "INTEGRATION_DELETE: 82", "INTEGRATION_UPDATE: 81", "INVITE_CREATE: 40", "INVITE_DELETE: 42", "INVITE_UPDATE: 41", "INVALID_ACCOUNT_TYPE", "INVALID_API_VERSION", "INVALID_AUTHENTICATION_TOKEN", "INVALID_BULK_DELETE_QUANTITY", "INVALID_FORM_BODY", "INVALID_OAUTH_STATE", "INVALID_OAUTH_TOKEN", "INVALID_OR_TAKEN_INVITE_CODE", "INVITE_ACCEPTED_TO_GUILD_NOT_CONTAINING_BOT", "If", "_member", "YELLOW", "query"}
        Me.AutocompleteMenu1.TargetControlWrapper = Nothing
        Me.AutocompleteMenu1.ToolTipDuration = 30
        '
        'discord_js
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 448)
        Me.Controls.Add(Me.DocumentMap1)
        Me.Controls.Add(Me.FastColoredTextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "discord_js"
        Me.Text = "Apple editor - discord_js"
        CType(Me.FastColoredTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FastColoredTextBox1 As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DosyaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DüzenleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyarlarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YeniKomutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KomutAçToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ÇıkışToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GeriAlToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YenileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KopyalaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YapıştırToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TümünüSeçToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BulToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents YerleştirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents DocumentMap1 As FastColoredTextBoxNS.DocumentMap
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents RenkModuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents KomutKaydetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OtomatikKaydetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DosyaAdıAyarlaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AutocompleteMenu1 As AutocompleteMenuNS.AutocompleteMenu
End Class
