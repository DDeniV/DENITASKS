Public Class DailyTaskTracker

    Private Sub DailyTaskTracker_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        progressBar.Maximum = 100 ' Adjust based on your scale
    End Sub

    Private Sub btnAddTask_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddTask.Click
        Dim taskCategory As String = If(rdoPersonal.Checked, "Personal", If(rdoSchool.Checked, "School", "Other"))
        Dim taskDescription As String = txtTask.Text & " - Due: " & dateTimePicker.Value.ToString("yyyy-MM-d") & " [" & taskCategory & "]"

        If txtTask.Text <> "" Then
            lstTasks.Items.Add(taskDescription)
            txtTask.Clear()
        Else
            MessageBox.Show("Please enter a task description.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnCompleteTask_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompleteTask.Click
        If lstTasks.SelectedIndex <> -1 Then
            lstTasks.Items.RemoveAt(lstTasks.SelectedIndex)
            Dim taskNumber As Integer = lstTasks.Items.Count
            progressBar.Increment(100 / taskNumber) ' Adjust the increment value based on your scale
        Else
            MessageBox.Show("Please select a task to mark as completed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
