﻿Public Class bot_olustu_yada_davet_et

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        newbotfunction()
    End Sub
    Public Sub newbotfunction()
        Dim newbotmesaj As String = MsgBox("Yeni bir bot oluşturmak istiyor musun? Discord Bot Studio programı hala test ve beta aşamasında olduğundan eski çalışmanı yükleme şansın olmayabilir. Bu problem Alpha sürümde düzeltilmesi beklenen bir özellik.", MsgBoxStyle.YesNoCancel, Application.ProductName)
        If newbotmesaj = MsgBoxResult.Yes Then
            yeni_bot.ShowDialog()
        ElseIf newbotmesaj = MsgBoxResult.No Then

        End If
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        bot_davet_et.ShowDialog()
    End Sub
End Class