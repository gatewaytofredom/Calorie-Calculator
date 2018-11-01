<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalorieCounter
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCarbohydrateCalories = New System.Windows.Forms.Label()
        Me.lblFatCalories = New System.Windows.Forms.Label()
        Me.lblProteinCalories = New System.Windows.Forms.Label()
        Me.lblGramsCarbohydrates = New System.Windows.Forms.Label()
        Me.lblGramsFat = New System.Windows.Forms.Label()
        Me.lblGramsProtein = New System.Windows.Forms.Label()
        Me.txtCarbohydrates = New System.Windows.Forms.TextBox()
        Me.txtCalculationOutput = New System.Windows.Forms.TextBox()
        Me.txtProtein = New System.Windows.Forms.TextBox()
        Me.txtFat = New System.Windows.Forms.TextBox()
        Me.btnComputeCalories = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(240, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Calories/Gram"
        '
        'lblCarbohydrateCalories
        '
        Me.lblCarbohydrateCalories.AutoSize = True
        Me.lblCarbohydrateCalories.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblCarbohydrateCalories.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblCarbohydrateCalories.Location = New System.Drawing.Point(271, 72)
        Me.lblCarbohydrateCalories.Name = "lblCarbohydrateCalories"
        Me.lblCarbohydrateCalories.Size = New System.Drawing.Size(14, 15)
        Me.lblCarbohydrateCalories.TabIndex = 2
        Me.lblCarbohydrateCalories.Text = "4"
        '
        'lblFatCalories
        '
        Me.lblFatCalories.AutoSize = True
        Me.lblFatCalories.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblFatCalories.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblFatCalories.Location = New System.Drawing.Point(270, 98)
        Me.lblFatCalories.Name = "lblFatCalories"
        Me.lblFatCalories.Size = New System.Drawing.Size(14, 15)
        Me.lblFatCalories.TabIndex = 4
        Me.lblFatCalories.Text = "9"
        '
        'lblProteinCalories
        '
        Me.lblProteinCalories.AutoSize = True
        Me.lblProteinCalories.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblProteinCalories.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblProteinCalories.Location = New System.Drawing.Point(270, 124)
        Me.lblProteinCalories.Name = "lblProteinCalories"
        Me.lblProteinCalories.Size = New System.Drawing.Size(14, 15)
        Me.lblProteinCalories.TabIndex = 6
        Me.lblProteinCalories.Text = "4"
        '
        'lblGramsCarbohydrates
        '
        Me.lblGramsCarbohydrates.AutoSize = True
        Me.lblGramsCarbohydrates.Location = New System.Drawing.Point(9, 76)
        Me.lblGramsCarbohydrates.Name = "lblGramsCarbohydrates"
        Me.lblGramsCarbohydrates.Size = New System.Drawing.Size(120, 13)
        Me.lblGramsCarbohydrates.TabIndex = 8
        Me.lblGramsCarbohydrates.Text = "Grams of Carbohydrates"
        '
        'lblGramsFat
        '
        Me.lblGramsFat.AutoSize = True
        Me.lblGramsFat.Location = New System.Drawing.Point(62, 102)
        Me.lblGramsFat.Name = "lblGramsFat"
        Me.lblGramsFat.Size = New System.Drawing.Size(67, 13)
        Me.lblGramsFat.TabIndex = 10
        Me.lblGramsFat.Text = "Grams of Fat"
        '
        'lblGramsProtein
        '
        Me.lblGramsProtein.AutoSize = True
        Me.lblGramsProtein.Location = New System.Drawing.Point(44, 128)
        Me.lblGramsProtein.Name = "lblGramsProtein"
        Me.lblGramsProtein.Size = New System.Drawing.Size(85, 13)
        Me.lblGramsProtein.TabIndex = 12
        Me.lblGramsProtein.Text = "Grams of Protein"
        '
        'txtCarbohydrates
        '
        Me.txtCarbohydrates.Location = New System.Drawing.Point(135, 69)
        Me.txtCarbohydrates.MaxLength = 3
        Me.txtCarbohydrates.Name = "txtCarbohydrates"
        Me.txtCarbohydrates.Size = New System.Drawing.Size(100, 20)
        Me.txtCarbohydrates.TabIndex = 1
        Me.txtCarbohydrates.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCalculationOutput
        '
        Me.txtCalculationOutput.Location = New System.Drawing.Point(84, 192)
        Me.txtCalculationOutput.MaxLength = 40
        Me.txtCalculationOutput.Name = "txtCalculationOutput"
        Me.txtCalculationOutput.ReadOnly = True
        Me.txtCalculationOutput.Size = New System.Drawing.Size(174, 20)
        Me.txtCalculationOutput.TabIndex = 15
        Me.txtCalculationOutput.TabStop = False
        Me.txtCalculationOutput.Text = "0 calories per ounce serving."
        Me.txtCalculationOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtProtein
        '
        Me.txtProtein.Location = New System.Drawing.Point(135, 121)
        Me.txtProtein.MaxLength = 3
        Me.txtProtein.Name = "txtProtein"
        Me.txtProtein.Size = New System.Drawing.Size(100, 20)
        Me.txtProtein.TabIndex = 3
        Me.txtProtein.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFat
        '
        Me.txtFat.Location = New System.Drawing.Point(135, 95)
        Me.txtFat.MaxLength = 3
        Me.txtFat.Name = "txtFat"
        Me.txtFat.Size = New System.Drawing.Size(100, 20)
        Me.txtFat.TabIndex = 2
        Me.txtFat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnComputeCalories
        '
        Me.btnComputeCalories.Location = New System.Drawing.Point(100, 163)
        Me.btnComputeCalories.Name = "btnComputeCalories"
        Me.btnComputeCalories.Size = New System.Drawing.Size(135, 23)
        Me.btnComputeCalories.TabIndex = 4
        Me.btnComputeCalories.Text = "&Calculate"
        Me.btnComputeCalories.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(54, 218)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(223, 218)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmCalorieCounter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 262)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnComputeCalories)
        Me.Controls.Add(Me.txtFat)
        Me.Controls.Add(Me.txtProtein)
        Me.Controls.Add(Me.txtCalculationOutput)
        Me.Controls.Add(Me.txtCarbohydrates)
        Me.Controls.Add(Me.lblGramsProtein)
        Me.Controls.Add(Me.lblGramsFat)
        Me.Controls.Add(Me.lblGramsCarbohydrates)
        Me.Controls.Add(Me.lblProteinCalories)
        Me.Controls.Add(Me.lblFatCalories)
        Me.Controls.Add(Me.lblCarbohydrateCalories)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(360, 300)
        Me.MinimumSize = New System.Drawing.Size(360, 300)
        Me.Name = "frmCalorieCounter"
        Me.Text = "Calorie Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblCarbohydrateCalories As Label
    Friend WithEvents lblFatCalories As Label
    Friend WithEvents lblProteinCalories As Label
    Friend WithEvents lblGramsCarbohydrates As Label
    Friend WithEvents lblGramsFat As Label
    Friend WithEvents lblGramsProtein As Label
    Friend WithEvents txtCarbohydrates As TextBox
    Friend WithEvents txtCalculationOutput As TextBox
    Friend WithEvents txtProtein As TextBox
    Friend WithEvents txtFat As TextBox
    Friend WithEvents btnComputeCalories As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
End Class
