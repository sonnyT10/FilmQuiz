﻿Public Class frmQuestion1
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        tmrQuestion1.Enabled = False
        If btnAnswer1.Checked Then
            playerScore = playerScore + 1
        End If
        frmQuestion2.Show()
        frmQuestion2.init()
        Me.Hide()

    End Sub

    Public Sub init()

        progressCount = 0
        tmrQuestion1.Enabled = True
        ProgressBarQ1.Value = 0
        btnAnswer1.Checked = False
        btnAnswer2.Checked = False
        btnAnswer3.Checked = False
        btnAnswer4.Checked = False
    End Sub

    Private Sub tmrQuestion1_Tick(sender As Object, e As EventArgs) Handles tmrQuestion1.Tick
        progressCount = progressCount + 1

        ProgressBarQ1.PerformStep()
        If progressCount = 10 Then
            tmrQuestion1.Enabled = False
            MsgBox("Too Slow Try Again")
            frmQuestion2.Show()
            frmQuestion2.init()
            Me.Hide()
        End If
    End Sub
End Class