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
        Me.HexColorText = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BlueText = New System.Windows.Forms.TextBox()
        Me.GreenText = New System.Windows.Forms.TextBox()
        Me.RedText = New System.Windows.Forms.TextBox()
        Me.BrightnessText = New System.Windows.Forms.TextBox()
        Me.SaturationText = New System.Windows.Forms.TextBox()
        Me.HueText = New System.Windows.Forms.TextBox()
        Me.BlueRadio = New System.Windows.Forms.RadioButton()
        Me.GreenRadio = New System.Windows.Forms.RadioButton()
        Me.RedRadio = New System.Windows.Forms.RadioButton()
        Me.BrightnessRadio = New System.Windows.Forms.RadioButton()
        Me.SaturationRadio = New System.Windows.Forms.RadioButton()
        Me.HueRadio = New System.Windows.Forms.RadioButton()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Ok_Button = New System.Windows.Forms.Button()
        Me.OriginalColorLabel = New System.Windows.Forms.Label()
        Me.SelectedColorLabel = New System.Windows.Forms.Label()
        Me.clrDialog = New System.Windows.Forms.ColorDialog()
        Me.selectLabel = New System.Windows.Forms.Label()
        Me.CyanLabel = New System.Windows.Forms.TextBox()
        Me.MagentaLabel = New System.Windows.Forms.TextBox()
        Me.YellowLabel = New System.Windows.Forms.TextBox()
        Me.BlackLabel = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'HexColorText
        '
        Me.HexColorText.Location = New System.Drawing.Point(324, 239)
        Me.HexColorText.MaxLength = 6
        Me.HexColorText.Name = "HexColorText"
        Me.HexColorText.Size = New System.Drawing.Size(54, 20)
        Me.HexColorText.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(305, 238)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(16, 18)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "#"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(465, 218)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(20, 16)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "%"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(465, 195)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 16)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "%"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(465, 172)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(20, 16)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "%"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(401, 241)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 13)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "K:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(401, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 13)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Y:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(401, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 13)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "M:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(401, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 13)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "C:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(379, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 16)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "%"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(379, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 16)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "%"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(379, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 18)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "°"
        '
        'BlueText
        '
        Me.BlueText.Location = New System.Drawing.Point(338, 216)
        Me.BlueText.MaxLength = 3
        Me.BlueText.Name = "BlueText"
        Me.BlueText.Size = New System.Drawing.Size(40, 20)
        Me.BlueText.TabIndex = 2
        '
        'GreenText
        '
        Me.GreenText.Location = New System.Drawing.Point(338, 193)
        Me.GreenText.MaxLength = 3
        Me.GreenText.Name = "GreenText"
        Me.GreenText.Size = New System.Drawing.Size(40, 20)
        Me.GreenText.TabIndex = 1
        '
        'RedText
        '
        Me.RedText.Location = New System.Drawing.Point(338, 170)
        Me.RedText.MaxLength = 3
        Me.RedText.Name = "RedText"
        Me.RedText.Size = New System.Drawing.Size(40, 20)
        Me.RedText.TabIndex = 0
        '
        'BrightnessText
        '
        Me.BrightnessText.Location = New System.Drawing.Point(338, 130)
        Me.BrightnessText.MaxLength = 3
        Me.BrightnessText.Name = "BrightnessText"
        Me.BrightnessText.Size = New System.Drawing.Size(40, 20)
        Me.BrightnessText.TabIndex = 6
        '
        'SaturationText
        '
        Me.SaturationText.Location = New System.Drawing.Point(338, 107)
        Me.SaturationText.MaxLength = 3
        Me.SaturationText.Name = "SaturationText"
        Me.SaturationText.Size = New System.Drawing.Size(40, 20)
        Me.SaturationText.TabIndex = 5
        '
        'HueText
        '
        Me.HueText.Location = New System.Drawing.Point(338, 84)
        Me.HueText.MaxLength = 3
        Me.HueText.Name = "HueText"
        Me.HueText.Size = New System.Drawing.Size(40, 20)
        Me.HueText.TabIndex = 4
        '
        'BlueRadio
        '
        Me.BlueRadio.AutoSize = True
        Me.BlueRadio.Location = New System.Drawing.Point(304, 216)
        Me.BlueRadio.Name = "BlueRadio"
        Me.BlueRadio.Size = New System.Drawing.Size(35, 17)
        Me.BlueRadio.TabIndex = 51
        Me.BlueRadio.Text = "B:"
        Me.BlueRadio.UseVisualStyleBackColor = True
        '
        'GreenRadio
        '
        Me.GreenRadio.AutoSize = True
        Me.GreenRadio.Location = New System.Drawing.Point(304, 193)
        Me.GreenRadio.Name = "GreenRadio"
        Me.GreenRadio.Size = New System.Drawing.Size(36, 17)
        Me.GreenRadio.TabIndex = 50
        Me.GreenRadio.Text = "G:"
        Me.GreenRadio.UseVisualStyleBackColor = True
        '
        'RedRadio
        '
        Me.RedRadio.AutoSize = True
        Me.RedRadio.Location = New System.Drawing.Point(304, 170)
        Me.RedRadio.Name = "RedRadio"
        Me.RedRadio.Size = New System.Drawing.Size(36, 17)
        Me.RedRadio.TabIndex = 49
        Me.RedRadio.Text = "R:"
        Me.RedRadio.UseVisualStyleBackColor = True
        '
        'BrightnessRadio
        '
        Me.BrightnessRadio.AutoSize = True
        Me.BrightnessRadio.Location = New System.Drawing.Point(305, 130)
        Me.BrightnessRadio.Name = "BrightnessRadio"
        Me.BrightnessRadio.Size = New System.Drawing.Size(35, 17)
        Me.BrightnessRadio.TabIndex = 48
        Me.BrightnessRadio.Text = "B:"
        Me.BrightnessRadio.UseVisualStyleBackColor = True
        '
        'SaturationRadio
        '
        Me.SaturationRadio.AutoSize = True
        Me.SaturationRadio.Location = New System.Drawing.Point(305, 107)
        Me.SaturationRadio.Name = "SaturationRadio"
        Me.SaturationRadio.Size = New System.Drawing.Size(35, 17)
        Me.SaturationRadio.TabIndex = 47
        Me.SaturationRadio.Text = "S:"
        Me.SaturationRadio.UseVisualStyleBackColor = True
        '
        'HueRadio
        '
        Me.HueRadio.AutoSize = True
        Me.HueRadio.Location = New System.Drawing.Point(305, 84)
        Me.HueRadio.Name = "HueRadio"
        Me.HueRadio.Size = New System.Drawing.Size(36, 17)
        Me.HueRadio.TabIndex = 46
        Me.HueRadio.Text = "H:"
        Me.HueRadio.UseVisualStyleBackColor = True
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cancel_Button.Location = New System.Drawing.Point(394, 40)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(91, 24)
        Me.Cancel_Button.TabIndex = 45
        Me.Cancel_Button.TabStop = False
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = True
        '
        'Ok_Button
        '
        Me.Ok_Button.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Ok_Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Ok_Button.Location = New System.Drawing.Point(394, 12)
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
        Me.OriginalColorLabel.Location = New System.Drawing.Point(307, 40)
        Me.OriginalColorLabel.Name = "OriginalColorLabel"
        Me.OriginalColorLabel.Size = New System.Drawing.Size(76, 28)
        Me.OriginalColorLabel.TabIndex = 43
        Me.OriginalColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SelectedColorLabel
        '
        Me.SelectedColorLabel.BackColor = System.Drawing.Color.PowderBlue
        Me.SelectedColorLabel.Location = New System.Drawing.Point(307, 12)
        Me.SelectedColorLabel.Name = "SelectedColorLabel"
        Me.SelectedColorLabel.Size = New System.Drawing.Size(76, 28)
        Me.SelectedColorLabel.TabIndex = 42
        Me.SelectedColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'selectLabel
        '
        Me.selectLabel.AutoSize = True
        Me.selectLabel.Location = New System.Drawing.Point(8, 12)
        Me.selectLabel.Name = "selectLabel"
        Me.selectLabel.Size = New System.Drawing.Size(67, 13)
        Me.selectLabel.TabIndex = 84
        Me.selectLabel.Text = "Select Color:"
        '
        'CyanLabel
        '
        Me.CyanLabel.Enabled = False
        Me.CyanLabel.Location = New System.Drawing.Point(421, 169)
        Me.CyanLabel.MaxLength = 3
        Me.CyanLabel.Name = "CyanLabel"
        Me.CyanLabel.Size = New System.Drawing.Size(40, 20)
        Me.CyanLabel.TabIndex = 85
        '
        'MagentaLabel
        '
        Me.MagentaLabel.Enabled = False
        Me.MagentaLabel.Location = New System.Drawing.Point(421, 192)
        Me.MagentaLabel.MaxLength = 3
        Me.MagentaLabel.Name = "MagentaLabel"
        Me.MagentaLabel.Size = New System.Drawing.Size(40, 20)
        Me.MagentaLabel.TabIndex = 86
        '
        'YellowLabel
        '
        Me.YellowLabel.Enabled = False
        Me.YellowLabel.Location = New System.Drawing.Point(421, 216)
        Me.YellowLabel.MaxLength = 3
        Me.YellowLabel.Name = "YellowLabel"
        Me.YellowLabel.Size = New System.Drawing.Size(40, 20)
        Me.YellowLabel.TabIndex = 87
        '
        'BlackLabel
        '
        Me.BlackLabel.Enabled = False
        Me.BlackLabel.Location = New System.Drawing.Point(421, 239)
        Me.BlackLabel.MaxLength = 3
        Me.BlackLabel.Name = "BlackLabel"
        Me.BlackLabel.Size = New System.Drawing.Size(40, 20)
        Me.BlackLabel.TabIndex = 88
        '
        'cp
        '
        Me.AcceptButton = Me.Ok_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(497, 278)
        Me.ControlBox = False
        Me.Controls.Add(Me.BlackLabel)
        Me.Controls.Add(Me.YellowLabel)
        Me.Controls.Add(Me.MagentaLabel)
        Me.Controls.Add(Me.CyanLabel)
        Me.Controls.Add(Me.selectLabel)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "cp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " Color Box"
        Me.TopMost = True
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
    Friend WithEvents clrDialog As System.Windows.Forms.ColorDialog
    Friend WithEvents selectLabel As System.Windows.Forms.Label
    Friend WithEvents CyanLabel As System.Windows.Forms.TextBox
    Friend WithEvents MagentaLabel As System.Windows.Forms.TextBox
    Friend WithEvents YellowLabel As System.Windows.Forms.TextBox
    Friend WithEvents BlackLabel As System.Windows.Forms.TextBox
End Class
