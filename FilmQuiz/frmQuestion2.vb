﻿Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmQuestion2
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        tmrQuestion2.Enabled = False
        If btnAnswer1.Checked Then
            playerScore = playerScore + 1
        End If
        frmQuestion3.Show()
        frmQuestion3.init()
        Me.Hide()
    End Sub

    Public Sub init()
        progressCount = 0
        tmrQuestion2.Enabled = True
        ProgressBarQ2.Value = 0
        btnAnswer1.Checked = False
        btnAnswer2.Checked = False
        btnAnswer3.Checked = False
        btnAnswer4.Checked = False
    End Sub

    Private Sub tmrQuestion2_Tick(sender As Object, e As EventArgs) Handles tmrQuestion2.Tick

        progressCount = progressCount + 1

        ProgressBarQ2.PerformStep()
        If progressCount = 10 Then
            tmrQuestion2.Enabled = False
            MsgBox("Too Slow Try Again")
            frmQuestion3.Show()
            frmQuestion3.init()
            Me.Hide()
        End If
    End Sub

End Class