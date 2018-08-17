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

    Private Sub gv_Releases_SelectionChanged(sender As Object, e As EventArgs) Handles gv_Releases.SelectionChanged
        If gv_Releases.SelectedRows.Count > 0 Then
            Dim I As Objects.Release = gv_Releases.SelectedRows(0).DataBoundItem
            If I IsNot Nothing Then
                PropertyGrid1.SelectedObject = I
            End If
        End If
    End Sub

    Private Async Sub btn_GetLatestRelease_Click(sender As Object, e As EventArgs) Handles btn_GetLatestRelease.Click
        btn_GetLatestRelease.Enabled = False
        Dim Release As Objects.Release = Await UpdaterEx1.GetLatestRelease
        PropertyGrid1.SelectedObject = Release
        gv_Releases.DataSource = New List(Of Objects.Release)({Release})
        btn_GetLatestRelease.Enabled = True
        prog_Status.Value = 0
    End Sub
End Class
