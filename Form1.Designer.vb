<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtYears = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.lblNametot = New System.Windows.Forms.Label()
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.rad1 = New System.Windows.Forms.RadioButton()
        Me.rad2 = New System.Windows.Forms.RadioButton()
        Me.rad3 = New System.Windows.Forms.RadioButton()
        Me.rad4 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(98, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Years Employed:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Amount of Sales:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(157, 12)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 0
        '
        'txtYears
        '
        Me.txtYears.Location = New System.Drawing.Point(157, 70)
        Me.txtYears.Name = "txtYears"
        Me.txtYears.Size = New System.Drawing.Size(100, 20)
        Me.txtYears.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Brown
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExit.Location = New System.Drawing.Point(592, 349)
        Me.btnExit.MinimumSize = New System.Drawing.Size(80, 30)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(81, 30)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(403, 349)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(81, 30)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clea&r"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(157, 349)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(81, 30)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'lblNametot
        '
        Me.lblNametot.AutoSize = True
        Me.lblNametot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNametot.Location = New System.Drawing.Point(527, 92)
        Me.lblNametot.Name = "lblNametot"
        Me.lblNametot.Size = New System.Drawing.Size(0, 16)
        Me.lblNametot.TabIndex = 10
        Me.lblNametot.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSalary
        '
        Me.lblSalary.AutoSize = True
        Me.lblSalary.BackColor = System.Drawing.SystemColors.Info
        Me.lblSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalary.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblSalary.Location = New System.Drawing.Point(524, 121)
        Me.lblSalary.MaximumSize = New System.Drawing.Size(200, 100)
        Me.lblSalary.MinimumSize = New System.Drawing.Size(200, 100)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(200, 100)
        Me.lblSalary.TabIndex = 9
        Me.lblSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rad1
        '
        Me.rad1.AutoSize = True
        Me.rad1.Checked = True
        Me.rad1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad1.Location = New System.Drawing.Point(158, 132)
        Me.rad1.Name = "rad1"
        Me.rad1.Size = New System.Drawing.Size(57, 19)
        Me.rad1.TabIndex = 2
        Me.rad1.TabStop = True
        Me.rad1.Text = "0-999"
        Me.rad1.UseVisualStyleBackColor = True
        '
        'rad2
        '
        Me.rad2.AutoSize = True
        Me.rad2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad2.Location = New System.Drawing.Point(158, 156)
        Me.rad2.Name = "rad2"
        Me.rad2.Size = New System.Drawing.Size(85, 19)
        Me.rad2.TabIndex = 3
        Me.rad2.Text = "1000-5000"
        Me.rad2.UseVisualStyleBackColor = True
        '
        'rad3
        '
        Me.rad3.AutoSize = True
        Me.rad3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad3.Location = New System.Drawing.Point(158, 180)
        Me.rad3.Name = "rad3"
        Me.rad3.Size = New System.Drawing.Size(92, 19)
        Me.rad3.TabIndex = 4
        Me.rad3.Text = "5001-10000"
        Me.rad3.UseVisualStyleBackColor = True
        '
        'rad4
        '
        Me.rad4.AutoSize = True
        Me.rad4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad4.Location = New System.Drawing.Point(157, 204)
        Me.rad4.Name = "rad4"
        Me.rad4.Size = New System.Drawing.Size(99, 19)
        Me.rad4.TabIndex = 5
        Me.rad4.Text = "10001-15000"
        Me.rad4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.rad4)
        Me.Controls.Add(Me.rad3)
        Me.Controls.Add(Me.rad2)
        Me.Controls.Add(Me.rad1)
        Me.Controls.Add(Me.lblSalary)
        Me.Controls.Add(Me.lblNametot)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtYears)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Salary Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtYears As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalc As Button
    Friend WithEvents lblNametot As Label
    Friend WithEvents lblSalary As Label
    Friend WithEvents rad1 As RadioButton
    Friend WithEvents rad2 As RadioButton
    Friend WithEvents rad3 As RadioButton
    Friend WithEvents rad4 As RadioButton
End Class
