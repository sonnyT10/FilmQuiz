﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHighScore
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
        Me.lstHighScore = New System.Windows.Forms.ListBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnAgain = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstHighScore
        '
        Me.lstHighScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstHighScore.FormattingEnabled = True
        Me.lstHighScore.ItemHeight = 20
        Me.lstHighScore.Location = New System.Drawing.Point(214, 92)
        Me.lstHighScore.Name = "lstHighScore"
        Me.lstHighScore.Size = New System.Drawing.Size(422, 364)
        Me.lstHighScore.TabIndex = 0
        '
        'lblMessage
        '
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(167, 5)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(611, 84)
        Me.lblMessage.TabIndex = 1
        Me.lblMessage.Text = "Label1"
        '
        'btnAgain
        '
        Me.btnAgain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgain.Location = New System.Drawing.Point(749, 517)
        Me.btnAgain.Name = "btnAgain"
        Me.btnAgain.Size = New System.Drawing.Size(198, 54)
        Me.btnAgain.TabIndex = 2
        Me.btnAgain.Text = "Again"
        Me.btnAgain.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(749, 593)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(198, 54)
        Me.btnQuit.TabIndex = 3
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'frmHighScore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 718)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnAgain)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lstHighScore)
        Me.Name = "frmHighScore"
        Me.Text = "frmHighScore"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstHighScore As ListBox
    Friend WithEvents lblMessage As Label
    Friend WithEvents btnAgain As Button
    Friend WithEvents btnQuit As Button
End Class
