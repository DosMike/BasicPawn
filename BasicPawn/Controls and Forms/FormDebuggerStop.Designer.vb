﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDebuggerStop
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDebuggerStop))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button_OK = New System.Windows.Forms.Button()
        Me.Button_Cancel = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip_ResultOptions = New System.Windows.Forms.ToolTip(Me.components)
        Me.Class_PictureBoxQuality1 = New BasicPawn.ClassPictureBoxQuality()
        Me.Panel1.SuspendLayout()
        CType(Me.Class_PictureBoxQuality1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Button_OK)
        Me.Panel1.Controls.Add(Me.Button_Cancel)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 213)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(334, 48)
        Me.Panel1.TabIndex = 0
        '
        'Button_OK
        '
        Me.Button_OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_OK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button_OK.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_OK.Location = New System.Drawing.Point(144, 13)
        Me.Button_OK.Name = "Button_OK"
        Me.Button_OK.Size = New System.Drawing.Size(86, 23)
        Me.Button_OK.TabIndex = 2
        Me.Button_OK.Text = "OK"
        Me.Button_OK.UseVisualStyleBackColor = True
        '
        'Button_Cancel
        '
        Me.Button_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_Cancel.Location = New System.Drawing.Point(236, 13)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(86, 23)
        Me.Button_Cancel.TabIndex = 1
        Me.Button_Cancel.Text = "Cancel"
        Me.Button_Cancel.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(334, 1)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(66, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 48)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "You are about to stop the debugger!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "What do you want to do?"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RadioButton1.Location = New System.Drawing.Point(73, 76)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(64, 16, 3, 3)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(91, 18)
        Me.RadioButton1.TabIndex = 3
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Do nothing"
        Me.ToolTip_ResultOptions.SetToolTip(Me.RadioButton1, "Just ends the debugger.")
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RadioButton2.Location = New System.Drawing.Point(73, 99)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(64, 3, 3, 3)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(111, 18)
        Me.RadioButton2.TabIndex = 4
        Me.RadioButton2.Text = "Terminate game"
        Me.ToolTip_ResultOptions.SetToolTip(Me.RadioButton2, "Ends the debugger and terminates the game." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You need to re-open the game on next " &
        "debugging.")
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RadioButton3.Location = New System.Drawing.Point(73, 151)
        Me.RadioButton3.Margin = New System.Windows.Forms.Padding(64, 3, 3, 3)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(98, 18)
        Me.RadioButton3.TabIndex = 5
        Me.RadioButton3.Text = "Restart game"
        Me.ToolTip_ResultOptions.SetToolTip(Me.RadioButton3, "Ends the debugging and restarts the game using the '_restart' command." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Usefull w" &
        "hen cleaning up maps or memory." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(BasicPawn debugger runner is required for this" &
        " to work)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RadioButton4.Location = New System.Drawing.Point(73, 174)
        Me.RadioButton4.Margin = New System.Windows.Forms.Padding(64, 3, 3, 3)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(106, 18)
        Me.RadioButton4.TabIndex = 6
        Me.RadioButton4.Text = "Unload plugin"
        Me.ToolTip_ResultOptions.SetToolTip(Me.RadioButton4, "Ends the debugger and unloads the plugin you're currently debugging." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Usefull for" &
        " quick debugging." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(BasicPawn debugger runner is required for this to work)")
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(70, 135)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 16, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "BasicPawn debugger runner required:"
        '
        'Class_PictureBoxQuality1
        '
        Me.Class_PictureBoxQuality1.HighQuality = True
        Me.Class_PictureBoxQuality1.Image = Global.BasicPawn.My.Resources.Resources.Bmp_Stop
        Me.Class_PictureBoxQuality1.Location = New System.Drawing.Point(12, 12)
        Me.Class_PictureBoxQuality1.Name = "Class_PictureBoxQuality1"
        Me.Class_PictureBoxQuality1.Size = New System.Drawing.Size(48, 48)
        Me.Class_PictureBoxQuality1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Class_PictureBoxQuality1.TabIndex = 2
        Me.Class_PictureBoxQuality1.TabStop = False
        '
        'FormDebuggerStop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Button_Cancel
        Me.ClientSize = New System.Drawing.Size(334, 261)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Class_PictureBoxQuality1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormDebuggerStop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stopping Debugger"
        Me.Panel1.ResumeLayout(False)
        CType(Me.Class_PictureBoxQuality1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button_OK As Button
    Friend WithEvents Button_Cancel As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Class_PictureBoxQuality1 As ClassPictureBoxQuality
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolTip_ResultOptions As ToolTip
End Class
