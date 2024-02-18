<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DailyTaskTracker
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
        Me.txtTask = New System.Windows.Forms.TextBox()
        Me.dateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.progressBar = New System.Windows.Forms.ProgressBar()
        Me.rdoPersonal = New System.Windows.Forms.RadioButton()
        Me.rdoSchool = New System.Windows.Forms.RadioButton()
        Me.rdoOther = New System.Windows.Forms.RadioButton()
        Me.btnAddTask = New System.Windows.Forms.Button()
        Me.btnCompleteTask = New System.Windows.Forms.Button()
        Me.lstTasks = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTask
        '
        Me.txtTask.Location = New System.Drawing.Point(12, 12)
        Me.txtTask.Name = "txtTask"
        Me.txtTask.Size = New System.Drawing.Size(260, 20)
        Me.txtTask.TabIndex = 0
        '
        'dateTimePicker
        '
        Me.dateTimePicker.Location = New System.Drawing.Point(12, 38)
        Me.dateTimePicker.Name = "dateTimePicker"
        Me.dateTimePicker.Size = New System.Drawing.Size(260, 20)
        Me.dateTimePicker.TabIndex = 1
        '
        'progressBar
        '
        Me.progressBar.Location = New System.Drawing.Point(12, 227)
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(260, 23)
        Me.progressBar.TabIndex = 2
        '
        'rdoPersonal
        '
        Me.rdoPersonal.AutoSize = True
        Me.rdoPersonal.Checked = True
        Me.rdoPersonal.Location = New System.Drawing.Point(12, 64)
        Me.rdoPersonal.Name = "rdoPersonal"
        Me.rdoPersonal.Size = New System.Drawing.Size(66, 17)
        Me.rdoPersonal.TabIndex = 3
        Me.rdoPersonal.TabStop = True
        Me.rdoPersonal.Text = "Personal"
        Me.rdoPersonal.UseVisualStyleBackColor = True
        '
        'rdoSchool
        '
        Me.rdoSchool.AutoSize = True
        Me.rdoSchool.Location = New System.Drawing.Point(84, 64)
        Me.rdoSchool.Name = "rdoSchool"
        Me.rdoSchool.Size = New System.Drawing.Size(58, 17)
        Me.rdoSchool.TabIndex = 4
        Me.rdoSchool.TabStop = True
        Me.rdoSchool.Text = "School"
        Me.rdoSchool.UseVisualStyleBackColor = True
        '
        'rdoOther
        '
        Me.rdoOther.AutoSize = True
        Me.rdoOther.Location = New System.Drawing.Point(148, 64)
        Me.rdoOther.Name = "rdoOther"
        Me.rdoOther.Size = New System.Drawing.Size(51, 17)
        Me.rdoOther.TabIndex = 5
        Me.rdoOther.TabStop = True
        Me.rdoOther.Text = "Other"
        Me.rdoOther.UseVisualStyleBackColor = True
        '
        'btnAddTask
        '
        Me.btnAddTask.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAddTask.FlatAppearance.BorderSize = 3
        Me.btnAddTask.Location = New System.Drawing.Point(12, 87)
        Me.btnAddTask.Name = "btnAddTask"
        Me.btnAddTask.Size = New System.Drawing.Size(75, 23)
        Me.btnAddTask.TabIndex = 6
        Me.btnAddTask.Text = "Add Task"
        Me.btnAddTask.UseVisualStyleBackColor = True
        '
        'btnCompleteTask
        '
        Me.btnCompleteTask.Location = New System.Drawing.Point(12, 198)
        Me.btnCompleteTask.Name = "btnCompleteTask"
        Me.btnCompleteTask.Size = New System.Drawing.Size(75, 23)
        Me.btnCompleteTask.TabIndex = 7
        Me.btnCompleteTask.Text = "Complete"
        Me.btnCompleteTask.UseVisualStyleBackColor = True
        '
        'lstTasks
        '
        Me.lstTasks.FormattingEnabled = True
        Me.lstTasks.Location = New System.Drawing.Point(12, 116)
        Me.lstTasks.Name = "lstTasks"
        Me.lstTasks.Size = New System.Drawing.Size(260, 69)
        Me.lstTasks.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(197, 198)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DailyTaskTracker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lstTasks)
        Me.Controls.Add(Me.btnCompleteTask)
        Me.Controls.Add(Me.btnAddTask)
        Me.Controls.Add(Me.rdoOther)
        Me.Controls.Add(Me.rdoSchool)
        Me.Controls.Add(Me.rdoPersonal)
        Me.Controls.Add(Me.progressBar)
        Me.Controls.Add(Me.dateTimePicker)
        Me.Controls.Add(Me.txtTask)
        Me.Name = "DailyTaskTracker"
        Me.Text = "Daily Task Tracker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTask As System.Windows.Forms.TextBox
    Friend WithEvents dateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents progressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents rdoPersonal As System.Windows.Forms.RadioButton
    Friend WithEvents rdoSchool As System.Windows.Forms.RadioButton
    Friend WithEvents rdoOther As System.Windows.Forms.RadioButton
    Friend WithEvents btnAddTask As System.Windows.Forms.Button
    Friend WithEvents btnCompleteTask As System.Windows.Forms.Button
    Friend WithEvents lstTasks As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class