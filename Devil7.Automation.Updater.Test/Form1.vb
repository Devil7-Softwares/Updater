Imports Devil7.Automation.Updater
Public Class Form1

    Private Async Sub btn_GetAllReleases_Click(sender As Object, e As EventArgs) Handles btn_GetAllReleases.Click
        btn_GetAllReleases.Enabled = False
        gv_Releases.DataSource = Await UpdaterEx1.GetReleases
        btn_GetAllReleases.Enabled = True
        prog_Status.Value = 0
    End Sub

    Private Sub UpdaterEx1_StatusChanged(Sender As Object, StatusText As String, Progress As Integer, UpdateProgress As Boolean) Handles UpdaterEx1.StatusChanged
        lbl_Status.Text = StatusText
        If UpdateProgress Then
            prog_Status.Value = Progress
        End If
    End Sub

End Class
