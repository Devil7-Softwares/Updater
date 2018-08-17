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
        Me.btn_GetAllReleases = New System.Windows.Forms.Button()
        Me.gv_Releases = New System.Windows.Forms.DataGridView()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.lbl_Status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.prog_Status = New System.Windows.Forms.ToolStripProgressBar()
        Me.PropertyGrid1 = New System.Windows.Forms.PropertyGrid()
        Me.btn_GetLatestRelease = New System.Windows.Forms.Button()
        Me.UpdaterEx1 = New Devil7.Automation.Updater.UpdaterEx()
        Me.btn_CheckForUpdates = New System.Windows.Forms.Button()
        CType(Me.gv_Releases, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_GetAllReleases
        '
        Me.btn_GetAllReleases.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_GetAllReleases.Location = New System.Drawing.Point(12, 342)
        Me.btn_GetAllReleases.Name = "btn_GetAllReleases"
        Me.btn_GetAllReleases.Size = New System.Drawing.Size(99, 23)
        Me.btn_GetAllReleases.TabIndex = 0
        Me.btn_GetAllReleases.Text = "Get All Releases"
        Me.btn_GetAllReleases.UseVisualStyleBackColor = True
        '
        'gv_Releases
        '
        Me.gv_Releases.AllowUserToAddRows = False
        Me.gv_Releases.AllowUserToDeleteRows = False
        Me.gv_Releases.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gv_Releases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gv_Releases.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.gv_Releases.Location = New System.Drawing.Point(12, 9)
        Me.gv_Releases.MultiSelect = False
        Me.gv_Releases.Name = "gv_Releases"
        Me.gv_Releases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gv_Releases.Size = New System.Drawing.Size(109, 327)
        Me.gv_Releases.TabIndex = 3
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_Status, Me.prog_Status})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 371)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(431, 22)
        Me.StatusStrip.TabIndex = 4
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'lbl_Status
        '
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(314, 17)
        Me.lbl_Status.Spring = True
        Me.lbl_Status.Text = "-"
        Me.lbl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'prog_Status
        '
        Me.prog_Status.Name = "prog_Status"
        Me.prog_Status.Size = New System.Drawing.Size(100, 16)
        '
        'PropertyGrid1
        '
        Me.PropertyGrid1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PropertyGrid1.Location = New System.Drawing.Point(127, 9)
        Me.PropertyGrid1.Name = "PropertyGrid1"
        Me.PropertyGrid1.Size = New System.Drawing.Size(292, 327)
        Me.PropertyGrid1.TabIndex = 5
        '
        'btn_GetLatestRelease
        '
        Me.btn_GetLatestRelease.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_GetLatestRelease.Location = New System.Drawing.Point(117, 342)
        Me.btn_GetLatestRelease.Name = "btn_GetLatestRelease"
        Me.btn_GetLatestRelease.Size = New System.Drawing.Size(113, 23)
        Me.btn_GetLatestRelease.TabIndex = 6
        Me.btn_GetLatestRelease.Text = "Get Latest Release"
        Me.btn_GetLatestRelease.UseVisualStyleBackColor = True
        '
        'UpdaterEx1
        '
        Me.UpdaterEx1.AssociatedAssembly = Nothing
        Me.UpdaterEx1.Icon = Nothing
        Me.UpdaterEx1.RepoName = "GSTR_2A-JSON_to_Excel_Converter"
        Me.UpdaterEx1.Status = Nothing
        Me.UpdaterEx1.UserName = "Devil7-Softwares"
        '
        'btn_CheckForUpdates
        '
        Me.btn_CheckForUpdates.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_CheckForUpdates.Location = New System.Drawing.Point(236, 342)
        Me.btn_CheckForUpdates.Name = "btn_CheckForUpdates"
        Me.btn_CheckForUpdates.Size = New System.Drawing.Size(115, 23)
        Me.btn_CheckForUpdates.TabIndex = 7
        Me.btn_CheckForUpdates.Text = "Check for Updates"
        Me.btn_CheckForUpdates.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 393)
        Me.Controls.Add(Me.btn_CheckForUpdates)
        Me.Controls.Add(Me.btn_GetLatestRelease)
        Me.Controls.Add(Me.PropertyGrid1)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.gv_Releases)
        Me.Controls.Add(Me.btn_GetAllReleases)
        Me.Name = "Form1"
        Me.Text = "Devil7 Updater Library Test"
        CType(Me.gv_Releases, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_GetAllReleases As Button
    Friend WithEvents gv_Releases As DataGridView
    Friend WithEvents UpdaterEx1 As UpdaterEx
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents lbl_Status As ToolStripStatusLabel
    Friend WithEvents prog_Status As ToolStripProgressBar
    Friend WithEvents PropertyGrid1 As PropertyGrid
    Friend WithEvents btn_GetLatestRelease As Button
    Friend WithEvents btn_CheckForUpdates As Button
End Class
