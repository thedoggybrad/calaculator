<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CmdOff = New System.Windows.Forms.Button()
        Me.CmdClearAll = New System.Windows.Forms.Button()
        Me.cmd7 = New System.Windows.Forms.Button()
        Me.cmd8 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdDecimal = New System.Windows.Forms.Button()
        Me.cmdSign = New System.Windows.Forms.Button()
        Me.cmd0 = New System.Windows.Forms.Button()
        Me.CmdInverse = New System.Windows.Forms.Button()
        Me.Cmdsubstraction = New System.Windows.Forms.Button()
        Me.cmdSqrtRoot = New System.Windows.Forms.Button()
        Me.cmd2 = New System.Windows.Forms.Button()
        Me.cmd3 = New System.Windows.Forms.Button()
        Me.cmd1 = New System.Windows.Forms.Button()
        Me.cmdMultiply = New System.Windows.Forms.Button()
        Me.cmd6 = New System.Windows.Forms.Button()
        Me.cmd5 = New System.Windows.Forms.Button()
        Me.CmdPowerOF = New System.Windows.Forms.Button()
        Me.cmd4 = New System.Windows.Forms.Button()
        Me.cmdDivide = New System.Windows.Forms.Button()
        Me.cmd9 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtInput.Location = New System.Drawing.Point(6, 23)
        Me.txtInput.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.ReadOnly = True
        Me.txtInput.Size = New System.Drawing.Size(310, 31)
        Me.txtInput.TabIndex = 0
        Me.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtInput)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 14)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(322, 70)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(22, 19)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(54, 44)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "←"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CmdOff
        '
        Me.CmdOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdOff.Location = New System.Drawing.Point(138, 19)
        Me.CmdOff.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmdOff.Name = "CmdOff"
        Me.CmdOff.Size = New System.Drawing.Size(52, 44)
        Me.CmdOff.TabIndex = 3
        Me.CmdOff.Text = "CE"
        Me.CmdOff.UseVisualStyleBackColor = True
        '
        'CmdClearAll
        '
        Me.CmdClearAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClearAll.Location = New System.Drawing.Point(82, 19)
        Me.CmdClearAll.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmdClearAll.Name = "CmdClearAll"
        Me.CmdClearAll.Size = New System.Drawing.Size(49, 44)
        Me.CmdClearAll.TabIndex = 4
        Me.CmdClearAll.Text = "C"
        Me.CmdClearAll.UseVisualStyleBackColor = True
        '
        'cmd7
        '
        Me.cmd7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd7.Location = New System.Drawing.Point(22, 73)
        Me.cmd7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmd7.Name = "cmd7"
        Me.cmd7.Size = New System.Drawing.Size(51, 35)
        Me.cmd7.TabIndex = 5
        Me.cmd7.Text = "7"
        Me.cmd7.UseVisualStyleBackColor = True
        '
        'cmd8
        '
        Me.cmd8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd8.Location = New System.Drawing.Point(78, 73)
        Me.cmd8.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmd8.Name = "cmd8"
        Me.cmd8.Size = New System.Drawing.Size(51, 35)
        Me.cmd8.TabIndex = 6
        Me.cmd8.Text = "8"
        Me.cmd8.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button23)
        Me.GroupBox2.Controls.Add(Me.cmdAdd)
        Me.GroupBox2.Controls.Add(Me.cmd7)
        Me.GroupBox2.Controls.Add(Me.cmdDecimal)
        Me.GroupBox2.Controls.Add(Me.cmdSign)
        Me.GroupBox2.Controls.Add(Me.cmd0)
        Me.GroupBox2.Controls.Add(Me.CmdInverse)
        Me.GroupBox2.Controls.Add(Me.Cmdsubstraction)
        Me.GroupBox2.Controls.Add(Me.cmdSqrtRoot)
        Me.GroupBox2.Controls.Add(Me.cmd2)
        Me.GroupBox2.Controls.Add(Me.cmd3)
        Me.GroupBox2.Controls.Add(Me.cmd1)
        Me.GroupBox2.Controls.Add(Me.cmdMultiply)
        Me.GroupBox2.Controls.Add(Me.cmd6)
        Me.GroupBox2.Controls.Add(Me.cmd5)
        Me.GroupBox2.Controls.Add(Me.CmdPowerOF)
        Me.GroupBox2.Controls.Add(Me.cmd4)
        Me.GroupBox2.Controls.Add(Me.cmdDivide)
        Me.GroupBox2.Controls.Add(Me.cmd9)
        Me.GroupBox2.Controls.Add(Me.cmd8)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.CmdOff)
        Me.GroupBox2.Controls.Add(Me.CmdClearAll)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 93)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(321, 262)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'Button23
        '
        Me.Button23.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button23.Location = New System.Drawing.Point(259, 207)
        Me.Button23.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(52, 35)
        Me.Button23.TabIndex = 24
        Me.Button23.Text = "="
        Me.Button23.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Location = New System.Drawing.Point(199, 207)
        Me.cmdAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(51, 35)
        Me.cmdAdd.TabIndex = 23
        Me.cmdAdd.Text = "+"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdDecimal
        '
        Me.cmdDecimal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDecimal.Location = New System.Drawing.Point(138, 207)
        Me.cmdDecimal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdDecimal.Name = "cmdDecimal"
        Me.cmdDecimal.Size = New System.Drawing.Size(52, 35)
        Me.cmdDecimal.TabIndex = 22
        Me.cmdDecimal.Text = "."
        Me.cmdDecimal.UseVisualStyleBackColor = True
        '
        'cmdSign
        '
        Me.cmdSign.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSign.Location = New System.Drawing.Point(78, 207)
        Me.cmdSign.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdSign.Name = "cmdSign"
        Me.cmdSign.Size = New System.Drawing.Size(51, 35)
        Me.cmdSign.TabIndex = 21
        Me.cmdSign.Text = "+/-"
        Me.cmdSign.UseVisualStyleBackColor = True
        '
        'cmd0
        '
        Me.cmd0.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd0.Location = New System.Drawing.Point(24, 207)
        Me.cmd0.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmd0.Name = "cmd0"
        Me.cmd0.Size = New System.Drawing.Size(45, 35)
        Me.cmd0.TabIndex = 20
        Me.cmd0.Text = "0"
        Me.cmd0.UseVisualStyleBackColor = True
        '
        'CmdInverse
        '
        Me.CmdInverse.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdInverse.Location = New System.Drawing.Point(259, 162)
        Me.CmdInverse.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmdInverse.Name = "CmdInverse"
        Me.CmdInverse.Size = New System.Drawing.Size(52, 35)
        Me.CmdInverse.TabIndex = 19
        Me.CmdInverse.Text = "1/x"
        Me.CmdInverse.UseVisualStyleBackColor = True
        '
        'Cmdsubstraction
        '
        Me.Cmdsubstraction.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmdsubstraction.Location = New System.Drawing.Point(199, 162)
        Me.Cmdsubstraction.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Cmdsubstraction.Name = "Cmdsubstraction"
        Me.Cmdsubstraction.Size = New System.Drawing.Size(51, 35)
        Me.Cmdsubstraction.TabIndex = 18
        Me.Cmdsubstraction.Text = "-"
        Me.Cmdsubstraction.UseVisualStyleBackColor = True
        '
        'cmdSqrtRoot
        '
        Me.cmdSqrtRoot.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSqrtRoot.Location = New System.Drawing.Point(259, 118)
        Me.cmdSqrtRoot.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdSqrtRoot.Name = "cmdSqrtRoot"
        Me.cmdSqrtRoot.Size = New System.Drawing.Size(52, 35)
        Me.cmdSqrtRoot.TabIndex = 17
        Me.cmdSqrtRoot.Text = "Sqrt"
        Me.cmdSqrtRoot.UseVisualStyleBackColor = True
        '
        'cmd2
        '
        Me.cmd2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd2.Location = New System.Drawing.Point(78, 162)
        Me.cmd2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmd2.Name = "cmd2"
        Me.cmd2.Size = New System.Drawing.Size(51, 35)
        Me.cmd2.TabIndex = 16
        Me.cmd2.Text = "2"
        Me.cmd2.UseVisualStyleBackColor = True
        '
        'cmd3
        '
        Me.cmd3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd3.Location = New System.Drawing.Point(138, 162)
        Me.cmd3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmd3.Name = "cmd3"
        Me.cmd3.Size = New System.Drawing.Size(52, 35)
        Me.cmd3.TabIndex = 15
        Me.cmd3.Text = "3"
        Me.cmd3.UseVisualStyleBackColor = True
        '
        'cmd1
        '
        Me.cmd1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd1.Location = New System.Drawing.Point(24, 162)
        Me.cmd1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmd1.Name = "cmd1"
        Me.cmd1.Size = New System.Drawing.Size(45, 35)
        Me.cmd1.TabIndex = 14
        Me.cmd1.Text = "1"
        Me.cmd1.UseVisualStyleBackColor = True
        '
        'cmdMultiply
        '
        Me.cmdMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMultiply.Location = New System.Drawing.Point(199, 118)
        Me.cmdMultiply.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdMultiply.Name = "cmdMultiply"
        Me.cmdMultiply.Size = New System.Drawing.Size(51, 35)
        Me.cmdMultiply.TabIndex = 13
        Me.cmdMultiply.Text = "*"
        Me.cmdMultiply.UseVisualStyleBackColor = True
        '
        'cmd6
        '
        Me.cmd6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd6.Location = New System.Drawing.Point(138, 118)
        Me.cmd6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmd6.Name = "cmd6"
        Me.cmd6.Size = New System.Drawing.Size(52, 35)
        Me.cmd6.TabIndex = 12
        Me.cmd6.Text = "6"
        Me.cmd6.UseVisualStyleBackColor = True
        '
        'cmd5
        '
        Me.cmd5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd5.Location = New System.Drawing.Point(78, 118)
        Me.cmd5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmd5.Name = "cmd5"
        Me.cmd5.Size = New System.Drawing.Size(51, 35)
        Me.cmd5.TabIndex = 11
        Me.cmd5.Text = "5"
        Me.cmd5.UseVisualStyleBackColor = True
        '
        'CmdPowerOF
        '
        Me.CmdPowerOF.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPowerOF.Location = New System.Drawing.Point(259, 73)
        Me.CmdPowerOF.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmdPowerOF.Name = "CmdPowerOF"
        Me.CmdPowerOF.Size = New System.Drawing.Size(52, 35)
        Me.CmdPowerOF.TabIndex = 9
        Me.CmdPowerOF.Text = "x^"
        Me.CmdPowerOF.UseVisualStyleBackColor = True
        '
        'cmd4
        '
        Me.cmd4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd4.Location = New System.Drawing.Point(24, 118)
        Me.cmd4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmd4.Name = "cmd4"
        Me.cmd4.Size = New System.Drawing.Size(45, 35)
        Me.cmd4.TabIndex = 10
        Me.cmd4.Text = "4"
        Me.cmd4.UseVisualStyleBackColor = True
        '
        'cmdDivide
        '
        Me.cmdDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDivide.Location = New System.Drawing.Point(199, 73)
        Me.cmdDivide.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdDivide.Name = "cmdDivide"
        Me.cmdDivide.Size = New System.Drawing.Size(51, 35)
        Me.cmdDivide.TabIndex = 8
        Me.cmdDivide.Text = "/"
        Me.cmdDivide.UseVisualStyleBackColor = True
        '
        'cmd9
        '
        Me.cmd9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd9.Location = New System.Drawing.Point(138, 73)
        Me.cmd9.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmd9.Name = "cmd9"
        Me.cmd9.Size = New System.Drawing.Size(52, 35)
        Me.cmd9.TabIndex = 7
        Me.cmd9.Text = "9"
        Me.cmd9.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 365)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CmdOff As System.Windows.Forms.Button
    Friend WithEvents CmdClearAll As System.Windows.Forms.Button
    Friend WithEvents cmd7 As System.Windows.Forms.Button
    Friend WithEvents cmd8 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd0 As System.Windows.Forms.Button
    Friend WithEvents CmdInverse As System.Windows.Forms.Button
    Friend WithEvents Cmdsubstraction As System.Windows.Forms.Button
    Friend WithEvents cmd2 As System.Windows.Forms.Button
    Friend WithEvents cmd3 As System.Windows.Forms.Button
    Friend WithEvents cmd1 As System.Windows.Forms.Button
    Friend WithEvents cmdMultiply As System.Windows.Forms.Button
    Friend WithEvents cmd6 As System.Windows.Forms.Button
    Friend WithEvents cmd5 As System.Windows.Forms.Button
    Friend WithEvents cmd4 As System.Windows.Forms.Button
    Friend WithEvents cmdDivide As System.Windows.Forms.Button
    Friend WithEvents cmd9 As System.Windows.Forms.Button
    Friend WithEvents Button23 As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdDecimal As System.Windows.Forms.Button
    Friend WithEvents cmdSign As System.Windows.Forms.Button
    Friend WithEvents cmdSqrtRoot As System.Windows.Forms.Button
    Friend WithEvents CmdPowerOF As System.Windows.Forms.Button
End Class
