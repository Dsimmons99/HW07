<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.FifthYearSalaryLBL = New System.Windows.Forms.Label()
        Me.FirstYearSalaryLBL = New System.Windows.Forms.Label()
        Me.FifthYearAmountLBL = New System.Windows.Forms.Label()
        Me.FirstYearAmountLBL = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.JobListLBL = New System.Windows.Forms.Label()
        Me.JobListBOX = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'FifthYearSalaryLBL
        '
        Me.FifthYearSalaryLBL.AutoSize = True
        Me.FifthYearSalaryLBL.Location = New System.Drawing.Point(492, 134)
        Me.FifthYearSalaryLBL.Name = "FifthYearSalaryLBL"
        Me.FifthYearSalaryLBL.Size = New System.Drawing.Size(136, 25)
        Me.FifthYearSalaryLBL.TabIndex = 13
        Me.FifthYearSalaryLBL.Text = "Fifth Year Salary"
        '
        'FirstYearSalaryLBL
        '
        Me.FirstYearSalaryLBL.AutoSize = True
        Me.FirstYearSalaryLBL.Location = New System.Drawing.Point(177, 134)
        Me.FirstYearSalaryLBL.Name = "FirstYearSalaryLBL"
        Me.FirstYearSalaryLBL.Size = New System.Drawing.Size(134, 25)
        Me.FirstYearSalaryLBL.TabIndex = 12
        Me.FirstYearSalaryLBL.Text = "First Year Salary"
        '
        'FifthYearAmountLBL
        '
        Me.FifthYearAmountLBL.AutoSize = True
        Me.FifthYearAmountLBL.Location = New System.Drawing.Point(492, 174)
        Me.FifthYearAmountLBL.Name = "FifthYearAmountLBL"
        Me.FifthYearAmountLBL.Size = New System.Drawing.Size(29, 25)
        Me.FifthYearAmountLBL.TabIndex = 11
        Me.FifthYearAmountLBL.Text = "$-"
        '
        'FirstYearAmountLBL
        '
        Me.FirstYearAmountLBL.AutoSize = True
        Me.FirstYearAmountLBL.Location = New System.Drawing.Point(176, 174)
        Me.FirstYearAmountLBL.Name = "FirstYearAmountLBL"
        Me.FirstYearAmountLBL.Size = New System.Drawing.Size(29, 25)
        Me.FirstYearAmountLBL.TabIndex = 10
        Me.FirstYearAmountLBL.Text = "$-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(90, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Salary:"
        '
        'JobListLBL
        '
        Me.JobListLBL.AutoSize = True
        Me.JobListLBL.Location = New System.Drawing.Point(90, 69)
        Me.JobListLBL.Name = "JobListLBL"
        Me.JobListLBL.Size = New System.Drawing.Size(75, 25)
        Me.JobListLBL.TabIndex = 8
        Me.JobListLBL.Text = "Job List:"
        '
        'JobListBOX
        '
        Me.JobListBOX.FormattingEnabled = True
        Me.JobListBOX.Items.AddRange(New Object() {"Computer Developers", "Computer System Analysts", "Computer and Information Systems Managers", "Computer Software Engineers, Applications"})
        Me.JobListBOX.Location = New System.Drawing.Point(176, 66)
        Me.JobListBOX.Name = "JobListBOX"
        Me.JobListBOX.Size = New System.Drawing.Size(391, 33)
        Me.JobListBOX.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 283)
        Me.Controls.Add(Me.FifthYearSalaryLBL)
        Me.Controls.Add(Me.FirstYearSalaryLBL)
        Me.Controls.Add(Me.FifthYearAmountLBL)
        Me.Controls.Add(Me.FirstYearAmountLBL)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.JobListLBL)
        Me.Controls.Add(Me.JobListBOX)
        Me.Name = "Form1"
        Me.Text = "Salaries For Computer Occupations"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FifthYearSalaryLBL As Label
    Friend WithEvents FirstYearSalaryLBL As Label
    Friend WithEvents FifthYearAmountLBL As Label
    Friend WithEvents FirstYearAmountLBL As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents JobListLBL As Label
    Friend WithEvents JobListBOX As ComboBox
End Class
