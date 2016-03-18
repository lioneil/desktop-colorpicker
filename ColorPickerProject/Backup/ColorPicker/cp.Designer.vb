<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cp
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
        Me.HexColorText = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BlueText = New System.Windows.Forms.TextBox
        Me.GreenText = New System.Windows.Forms.TextBox
        Me.RedText = New System.Windows.Forms.TextBox
        Me.BrightnessText = New System.Windows.Forms.TextBox
        Me.SaturationText = New System.Windows.Forms.TextBox
        Me.HueText = New System.Windows.Forms.TextBox
        Me.BlueRadio = New System.Windows.Forms.RadioButton
        Me.GreenRadio = New System.Windows.Forms.RadioButton
        Me.RedRadio = New System.Windows.Forms.RadioButton
        Me.BrightnessRadio = New System.Windows.Forms.RadioButton
        Me.SaturationRadio = New System.Windows.Forms.RadioButton
        Me.HueRadio = New System.Windows.Forms.RadioButton
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.Ok_Button = New System.Windows.Forms.Button
        Me.OriginalColorLabel = New System.Windows.Forms.Label
        Me.SelectedColorLabel = New System.Windows.Forms.Label
        Me.SelectLabel = New System.Windows.Forms.Label
        Me.clrDialog = New System.Windows.Forms.ColorDialog
        Me.CyanLabel = New System.Windows.Forms.Label
        Me.MagentaLabel = New System.Windows.Forms.Label
        Me.YellowLabel = New System.Windows.Forms.Label
        Me.BlackLabel = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'HexColorText
        '
        Me.HexColorText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HexColorText.Location = New System.Drawing.Point(324, 263)
        Me.HexColorText.MaxLength = 6
        Me.HexColorText.Name = "HexColorText"
        Me.HexColorText.Size = New System.Drawing.Size(54, 20)
        Me.HexColorText.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(302, 261)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(16, 18)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "#"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(490, 242)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(20, 16)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "%"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(490, 219)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 16)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "%"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(490, 196)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(20, 16)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "%"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(426, 265)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 13)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "K:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(426, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 13)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Y:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(426, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 13)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "M:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(426, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 13)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "C:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(379, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 16)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "%"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(379, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 16)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "%"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(379, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 18)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "°"
        '
        'BlueText
        '
        Me.BlueText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BlueText.Location = New System.Drawing.Point(338, 240)
        Me.BlueText.MaxLength = 3
        Me.BlueText.Name = "BlueText"
        Me.BlueText.Size = New System.Drawing.Size(40, 20)
        Me.BlueText.TabIndex = 2
        '
        'GreenText
        '
        Me.GreenText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GreenText.Location = New System.Drawing.Point(338, 217)
        Me.GreenText.MaxLength = 3
        Me.GreenText.Name = "GreenText"
        Me.GreenText.Size = New System.Drawing.Size(40, 20)
        Me.GreenText.TabIndex = 1
        '
        'RedText
        '
        Me.RedText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RedText.Location = New System.Drawing.Point(338, 194)
        Me.RedText.MaxLength = 3
        Me.RedText.Name = "RedText"
        Me.RedText.Size = New System.Drawing.Size(40, 20)
        Me.RedText.TabIndex = 0
        '
        'BrightnessText
        '
        Me.BrightnessText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BrightnessText.Location = New System.Drawing.Point(338, 154)
        Me.BrightnessText.MaxLength = 3
        Me.BrightnessText.Name = "BrightnessText"
        Me.BrightnessText.Size = New System.Drawing.Size(40, 20)
        Me.BrightnessText.TabIndex = 6
        '
        'SaturationText
        '
        Me.SaturationText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SaturationText.Location = New System.Drawing.Point(338, 131)
        Me.SaturationText.MaxLength = 3
        Me.SaturationText.Name = "SaturationText"
        Me.SaturationText.Size = New System.Drawing.Size(40, 20)
        Me.SaturationText.TabIndex = 5
        '
        'HueText
        '
        Me.HueText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HueText.Location = New System.Drawing.Point(338, 108)
        Me.HueText.MaxLength = 3
        Me.HueText.Name = "HueText"
        Me.HueText.Size = New System.Drawing.Size(40, 20)
        Me.HueText.TabIndex = 4
        '
        'BlueRadio
        '
        Me.BlueRadio.AutoSize = True
        Me.BlueRadio.Location = New System.Drawing.Point(304, 240)
        Me.BlueRadio.Name = "BlueRadio"
        Me.BlueRadio.Size = New System.Drawing.Size(35, 17)
        Me.BlueRadio.TabIndex = 51
        Me.BlueRadio.Text = "B:"
        Me.BlueRadio.UseVisualStyleBackColor = True
        '
        'GreenRadio
        '
        Me.GreenRadio.AutoSize = True
        Me.GreenRadio.Location = New System.Drawing.Point(304, 217)
        Me.GreenRadio.Name = "GreenRadio"
        Me.GreenRadio.Size = New System.Drawing.Size(36, 17)
        Me.GreenRadio.TabIndex = 50
        Me.GreenRadio.Text = "G:"
        Me.GreenRadio.UseVisualStyleBackColor = True
        '
        'RedRadio
        '
        Me.RedRadio.AutoSize = True
        Me.RedRadio.Location = New System.Drawing.Point(304, 194)
        Me.RedRadio.Name = "RedRadio"
        Me.RedRadio.Size = New System.Drawing.Size(36, 17)
        Me.RedRadio.TabIndex = 49
        Me.RedRadio.Text = "R:"
        Me.RedRadio.UseVisualStyleBackColor = True
        '
        'BrightnessRadio
        '
        Me.BrightnessRadio.AutoSize = True
        Me.BrightnessRadio.Location = New System.Drawing.Point(305, 154)
        Me.BrightnessRadio.Name = "BrightnessRadio"
        Me.BrightnessRadio.Size = New System.Drawing.Size(35, 17)
        Me.BrightnessRadio.TabIndex = 48
        Me.BrightnessRadio.Text = "B:"
        Me.BrightnessRadio.UseVisualStyleBackColor = True
        '
        'SaturationRadio
        '
        Me.SaturationRadio.AutoSize = True
        Me.SaturationRadio.Location = New System.Drawing.Point(305, 131)
        Me.SaturationRadio.Name = "SaturationRadio"
        Me.SaturationRadio.Size = New System.Drawing.Size(35, 17)
        Me.SaturationRadio.TabIndex = 47
        Me.SaturationRadio.Text = "S:"
        Me.SaturationRadio.UseVisualStyleBackColor = True
        '
        'HueRadio
        '
        Me.HueRadio.AutoSize = True
        Me.HueRadio.Location = New System.Drawing.Point(305, 108)
        Me.HueRadio.Name = "HueRadio"
        Me.HueRadio.Size = New System.Drawing.Size(36, 17)
        Me.HueRadio.TabIndex = 46
        Me.HueRadio.Text = "H:"
        Me.HueRadio.UseVisualStyleBackColor = True
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel_Button.Location = New System.Drawing.Point(407, 35)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(91, 24)
        Me.Cancel_Button.TabIndex = 45
        Me.Cancel_Button.TabStop = False
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = True
        '
        'Ok_Button
        '
        Me.Ok_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ok_Button.Location = New System.Drawing.Point(407, 5)
        Me.Ok_Button.Name = "Ok_Button"
        Me.Ok_Button.Size = New System.Drawing.Size(91, 24)
        Me.Ok_Button.TabIndex = 44
        Me.Ok_Button.TabStop = False
        Me.Ok_Button.Text = "Ok"
        Me.Ok_Button.UseVisualStyleBackColor = True
        '
        'OriginalColorLabel
        '
        Me.OriginalColorLabel.BackColor = System.Drawing.Color.SkyBlue
        Me.OriginalColorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OriginalColorLabel.Location = New System.Drawing.Point(307, 54)
        Me.OriginalColorLabel.Name = "OriginalColorLabel"
        Me.OriginalColorLabel.Size = New System.Drawing.Size(76, 28)
        Me.OriginalColorLabel.TabIndex = 43
        Me.OriginalColorLabel.Text = "Original"
        Me.OriginalColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SelectedColorLabel
        '
        Me.SelectedColorLabel.BackColor = System.Drawing.Color.PowderBlue
        Me.SelectedColorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SelectedColorLabel.Location = New System.Drawing.Point(307, 27)
        Me.SelectedColorLabel.Name = "SelectedColorLabel"
        Me.SelectedColorLabel.Size = New System.Drawing.Size(76, 28)
        Me.SelectedColorLabel.TabIndex = 42
        Me.SelectedColorLabel.Text = "Selected"
        Me.SelectedColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SelectLabel
        '
        Me.SelectLabel.AutoSize = True
        Me.SelectLabel.Location = New System.Drawing.Point(8, 5)
        Me.SelectLabel.Name = "SelectLabel"
        Me.SelectLabel.Size = New System.Drawing.Size(64, 13)
        Me.SelectLabel.TabIndex = 41
        Me.SelectLabel.Text = "Select Color"
        '
        'CyanLabel
        '
        Me.CyanLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CyanLabel.Location = New System.Drawing.Point(446, 195)
        Me.CyanLabel.Name = "CyanLabel"
        Me.CyanLabel.Size = New System.Drawing.Size(40, 19)
        Me.CyanLabel.TabIndex = 80
        Me.CyanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MagentaLabel
        '
        Me.MagentaLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MagentaLabel.Location = New System.Drawing.Point(446, 218)
        Me.MagentaLabel.Name = "MagentaLabel"
        Me.MagentaLabel.Size = New System.Drawing.Size(40, 19)
        Me.MagentaLabel.TabIndex = 81
        Me.MagentaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'YellowLabel
        '
        Me.YellowLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.YellowLabel.Location = New System.Drawing.Point(446, 241)
        Me.YellowLabel.Name = "YellowLabel"
        Me.YellowLabel.Size = New System.Drawing.Size(40, 19)
        Me.YellowLabel.TabIndex = 82
        Me.YellowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BlackLabel
        '
        Me.BlackLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BlackLabel.Location = New System.Drawing.Point(446, 264)
        Me.BlackLabel.Name = "BlackLabel"
        Me.BlackLabel.Size = New System.Drawing.Size(40, 19)
        Me.BlackLabel.TabIndex = 83
        Me.BlackLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cp
        '
        Me.AcceptButton = Me.Ok_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 295)
        Me.ControlBox = False
        Me.Controls.Add(Me.BlackLabel)
        Me.Controls.Add(Me.YellowLabel)
        Me.Controls.Add(Me.MagentaLabel)
        Me.Controls.Add(Me.CyanLabel)
        Me.Controls.Add(Me.HexColorText)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BlueText)
        Me.Controls.Add(Me.GreenText)
        Me.Controls.Add(Me.RedText)
        Me.Controls.Add(Me.BrightnessText)
        Me.Controls.Add(Me.SaturationText)
        Me.Controls.Add(Me.HueText)
        Me.Controls.Add(Me.BlueRadio)
        Me.Controls.Add(Me.GreenRadio)
        Me.Controls.Add(Me.RedRadio)
        Me.Controls.Add(Me.BrightnessRadio)
        Me.Controls.Add(Me.SaturationRadio)
        Me.Controls.Add(Me.HueRadio)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.Ok_Button)
        Me.Controls.Add(Me.OriginalColorLabel)
        Me.Controls.Add(Me.SelectedColorLabel)
        Me.Controls.Add(Me.SelectLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "cp"
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HexColorText As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BlueText As System.Windows.Forms.TextBox
    Friend WithEvents GreenText As System.Windows.Forms.TextBox
    Friend WithEvents RedText As System.Windows.Forms.TextBox
    Friend WithEvents BrightnessText As System.Windows.Forms.TextBox
    Friend WithEvents SaturationText As System.Windows.Forms.TextBox
    Friend WithEvents HueText As System.Windows.Forms.TextBox
    Friend WithEvents BlueRadio As System.Windows.Forms.RadioButton
    Friend WithEvents GreenRadio As System.Windows.Forms.RadioButton
    Friend WithEvents RedRadio As System.Windows.Forms.RadioButton
    Friend WithEvents BrightnessRadio As System.Windows.Forms.RadioButton
    Friend WithEvents SaturationRadio As System.Windows.Forms.RadioButton
    Friend WithEvents HueRadio As System.Windows.Forms.RadioButton
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Ok_Button As System.Windows.Forms.Button
    Friend WithEvents OriginalColorLabel As System.Windows.Forms.Label
    Friend WithEvents SelectedColorLabel As System.Windows.Forms.Label
    Friend WithEvents SelectLabel As System.Windows.Forms.Label
    Friend WithEvents clrDialog As System.Windows.Forms.ColorDialog
	Friend WithEvents CyanLabel As System.Windows.Forms.Label
	Friend WithEvents MagentaLabel As System.Windows.Forms.Label
	Friend WithEvents YellowLabel As System.Windows.Forms.Label
    Friend WithEvents BlackLabel As System.Windows.Forms.Label
End Class
