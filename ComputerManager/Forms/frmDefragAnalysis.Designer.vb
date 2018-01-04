<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDefragAnalysis
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
        Me.components = New System.ComponentModel.Container
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Win32DefragAnalysisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AverageFileSizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AverageFragmentsPerFileDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AverageFreeSpacePerExtentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClusterSizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ExcessFolderFragmentsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FilePercentFragmentationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FragmentedFoldersDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FreeSpaceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FreeSpacePercentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FreeSpacePercentFragmentationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LargestFreeSpaceExtentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MFTPercentInUseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MFTRecordCountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PageFileSizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalExcessFragmentsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalFilesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalFoldersDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalFragmentedFilesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalFreeSpaceExtentsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalMFTFragmentsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalPageFileFragmentsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalPercentFragmentationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalUnmoveableFilesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UsedSpaceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VolumeNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VolumeSizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Win32DefragAnalysisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AverageFileSizeDataGridViewTextBoxColumn, Me.AverageFragmentsPerFileDataGridViewTextBoxColumn, Me.AverageFreeSpacePerExtentDataGridViewTextBoxColumn, Me.ClusterSizeDataGridViewTextBoxColumn, Me.ExcessFolderFragmentsDataGridViewTextBoxColumn, Me.FilePercentFragmentationDataGridViewTextBoxColumn, Me.FragmentedFoldersDataGridViewTextBoxColumn, Me.FreeSpaceDataGridViewTextBoxColumn, Me.FreeSpacePercentDataGridViewTextBoxColumn, Me.FreeSpacePercentFragmentationDataGridViewTextBoxColumn, Me.LargestFreeSpaceExtentDataGridViewTextBoxColumn, Me.MFTPercentInUseDataGridViewTextBoxColumn, Me.MFTRecordCountDataGridViewTextBoxColumn, Me.PageFileSizeDataGridViewTextBoxColumn, Me.TotalExcessFragmentsDataGridViewTextBoxColumn, Me.TotalFilesDataGridViewTextBoxColumn, Me.TotalFoldersDataGridViewTextBoxColumn, Me.TotalFragmentedFilesDataGridViewTextBoxColumn, Me.TotalFreeSpaceExtentsDataGridViewTextBoxColumn, Me.TotalMFTFragmentsDataGridViewTextBoxColumn, Me.TotalPageFileFragmentsDataGridViewTextBoxColumn, Me.TotalPercentFragmentationDataGridViewTextBoxColumn, Me.TotalUnmoveableFilesDataGridViewTextBoxColumn, Me.UsedSpaceDataGridViewTextBoxColumn, Me.VolumeNameDataGridViewTextBoxColumn, Me.VolumeSizeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Win32DefragAnalysisBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(284, 264)
        Me.DataGridView1.TabIndex = 0
        '
        'Win32DefragAnalysisBindingSource
        '
        Me.Win32DefragAnalysisBindingSource.DataSource = GetType(WMIwrapper.Win32_DefragAnalysis)
        '
        'AverageFileSizeDataGridViewTextBoxColumn
        '
        Me.AverageFileSizeDataGridViewTextBoxColumn.DataPropertyName = "AverageFileSize"
        Me.AverageFileSizeDataGridViewTextBoxColumn.HeaderText = "AverageFileSize"
        Me.AverageFileSizeDataGridViewTextBoxColumn.Name = "AverageFileSizeDataGridViewTextBoxColumn"
        Me.AverageFileSizeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AverageFragmentsPerFileDataGridViewTextBoxColumn
        '
        Me.AverageFragmentsPerFileDataGridViewTextBoxColumn.DataPropertyName = "AverageFragmentsPerFile"
        Me.AverageFragmentsPerFileDataGridViewTextBoxColumn.HeaderText = "AverageFragmentsPerFile"
        Me.AverageFragmentsPerFileDataGridViewTextBoxColumn.Name = "AverageFragmentsPerFileDataGridViewTextBoxColumn"
        Me.AverageFragmentsPerFileDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AverageFreeSpacePerExtentDataGridViewTextBoxColumn
        '
        Me.AverageFreeSpacePerExtentDataGridViewTextBoxColumn.DataPropertyName = "AverageFreeSpacePerExtent"
        Me.AverageFreeSpacePerExtentDataGridViewTextBoxColumn.HeaderText = "AverageFreeSpacePerExtent"
        Me.AverageFreeSpacePerExtentDataGridViewTextBoxColumn.Name = "AverageFreeSpacePerExtentDataGridViewTextBoxColumn"
        Me.AverageFreeSpacePerExtentDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClusterSizeDataGridViewTextBoxColumn
        '
        Me.ClusterSizeDataGridViewTextBoxColumn.DataPropertyName = "ClusterSize"
        Me.ClusterSizeDataGridViewTextBoxColumn.HeaderText = "ClusterSize"
        Me.ClusterSizeDataGridViewTextBoxColumn.Name = "ClusterSizeDataGridViewTextBoxColumn"
        Me.ClusterSizeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ExcessFolderFragmentsDataGridViewTextBoxColumn
        '
        Me.ExcessFolderFragmentsDataGridViewTextBoxColumn.DataPropertyName = "ExcessFolderFragments"
        Me.ExcessFolderFragmentsDataGridViewTextBoxColumn.HeaderText = "ExcessFolderFragments"
        Me.ExcessFolderFragmentsDataGridViewTextBoxColumn.Name = "ExcessFolderFragmentsDataGridViewTextBoxColumn"
        Me.ExcessFolderFragmentsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FilePercentFragmentationDataGridViewTextBoxColumn
        '
        Me.FilePercentFragmentationDataGridViewTextBoxColumn.DataPropertyName = "FilePercentFragmentation"
        Me.FilePercentFragmentationDataGridViewTextBoxColumn.HeaderText = "FilePercentFragmentation"
        Me.FilePercentFragmentationDataGridViewTextBoxColumn.Name = "FilePercentFragmentationDataGridViewTextBoxColumn"
        Me.FilePercentFragmentationDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FragmentedFoldersDataGridViewTextBoxColumn
        '
        Me.FragmentedFoldersDataGridViewTextBoxColumn.DataPropertyName = "FragmentedFolders"
        Me.FragmentedFoldersDataGridViewTextBoxColumn.HeaderText = "FragmentedFolders"
        Me.FragmentedFoldersDataGridViewTextBoxColumn.Name = "FragmentedFoldersDataGridViewTextBoxColumn"
        Me.FragmentedFoldersDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FreeSpaceDataGridViewTextBoxColumn
        '
        Me.FreeSpaceDataGridViewTextBoxColumn.DataPropertyName = "FreeSpace"
        Me.FreeSpaceDataGridViewTextBoxColumn.HeaderText = "FreeSpace"
        Me.FreeSpaceDataGridViewTextBoxColumn.Name = "FreeSpaceDataGridViewTextBoxColumn"
        Me.FreeSpaceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FreeSpacePercentDataGridViewTextBoxColumn
        '
        Me.FreeSpacePercentDataGridViewTextBoxColumn.DataPropertyName = "FreeSpacePercent"
        Me.FreeSpacePercentDataGridViewTextBoxColumn.HeaderText = "FreeSpacePercent"
        Me.FreeSpacePercentDataGridViewTextBoxColumn.Name = "FreeSpacePercentDataGridViewTextBoxColumn"
        Me.FreeSpacePercentDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FreeSpacePercentFragmentationDataGridViewTextBoxColumn
        '
        Me.FreeSpacePercentFragmentationDataGridViewTextBoxColumn.DataPropertyName = "FreeSpacePercentFragmentation"
        Me.FreeSpacePercentFragmentationDataGridViewTextBoxColumn.HeaderText = "FreeSpacePercentFragmentation"
        Me.FreeSpacePercentFragmentationDataGridViewTextBoxColumn.Name = "FreeSpacePercentFragmentationDataGridViewTextBoxColumn"
        Me.FreeSpacePercentFragmentationDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LargestFreeSpaceExtentDataGridViewTextBoxColumn
        '
        Me.LargestFreeSpaceExtentDataGridViewTextBoxColumn.DataPropertyName = "LargestFreeSpaceExtent"
        Me.LargestFreeSpaceExtentDataGridViewTextBoxColumn.HeaderText = "LargestFreeSpaceExtent"
        Me.LargestFreeSpaceExtentDataGridViewTextBoxColumn.Name = "LargestFreeSpaceExtentDataGridViewTextBoxColumn"
        Me.LargestFreeSpaceExtentDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MFTPercentInUseDataGridViewTextBoxColumn
        '
        Me.MFTPercentInUseDataGridViewTextBoxColumn.DataPropertyName = "MFTPercentInUse"
        Me.MFTPercentInUseDataGridViewTextBoxColumn.HeaderText = "MFTPercentInUse"
        Me.MFTPercentInUseDataGridViewTextBoxColumn.Name = "MFTPercentInUseDataGridViewTextBoxColumn"
        Me.MFTPercentInUseDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MFTRecordCountDataGridViewTextBoxColumn
        '
        Me.MFTRecordCountDataGridViewTextBoxColumn.DataPropertyName = "MFTRecordCount"
        Me.MFTRecordCountDataGridViewTextBoxColumn.HeaderText = "MFTRecordCount"
        Me.MFTRecordCountDataGridViewTextBoxColumn.Name = "MFTRecordCountDataGridViewTextBoxColumn"
        Me.MFTRecordCountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PageFileSizeDataGridViewTextBoxColumn
        '
        Me.PageFileSizeDataGridViewTextBoxColumn.DataPropertyName = "PageFileSize"
        Me.PageFileSizeDataGridViewTextBoxColumn.HeaderText = "PageFileSize"
        Me.PageFileSizeDataGridViewTextBoxColumn.Name = "PageFileSizeDataGridViewTextBoxColumn"
        Me.PageFileSizeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalExcessFragmentsDataGridViewTextBoxColumn
        '
        Me.TotalExcessFragmentsDataGridViewTextBoxColumn.DataPropertyName = "TotalExcessFragments"
        Me.TotalExcessFragmentsDataGridViewTextBoxColumn.HeaderText = "TotalExcessFragments"
        Me.TotalExcessFragmentsDataGridViewTextBoxColumn.Name = "TotalExcessFragmentsDataGridViewTextBoxColumn"
        Me.TotalExcessFragmentsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalFilesDataGridViewTextBoxColumn
        '
        Me.TotalFilesDataGridViewTextBoxColumn.DataPropertyName = "TotalFiles"
        Me.TotalFilesDataGridViewTextBoxColumn.HeaderText = "TotalFiles"
        Me.TotalFilesDataGridViewTextBoxColumn.Name = "TotalFilesDataGridViewTextBoxColumn"
        Me.TotalFilesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalFoldersDataGridViewTextBoxColumn
        '
        Me.TotalFoldersDataGridViewTextBoxColumn.DataPropertyName = "TotalFolders"
        Me.TotalFoldersDataGridViewTextBoxColumn.HeaderText = "TotalFolders"
        Me.TotalFoldersDataGridViewTextBoxColumn.Name = "TotalFoldersDataGridViewTextBoxColumn"
        Me.TotalFoldersDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalFragmentedFilesDataGridViewTextBoxColumn
        '
        Me.TotalFragmentedFilesDataGridViewTextBoxColumn.DataPropertyName = "TotalFragmentedFiles"
        Me.TotalFragmentedFilesDataGridViewTextBoxColumn.HeaderText = "TotalFragmentedFiles"
        Me.TotalFragmentedFilesDataGridViewTextBoxColumn.Name = "TotalFragmentedFilesDataGridViewTextBoxColumn"
        Me.TotalFragmentedFilesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalFreeSpaceExtentsDataGridViewTextBoxColumn
        '
        Me.TotalFreeSpaceExtentsDataGridViewTextBoxColumn.DataPropertyName = "TotalFreeSpaceExtents"
        Me.TotalFreeSpaceExtentsDataGridViewTextBoxColumn.HeaderText = "TotalFreeSpaceExtents"
        Me.TotalFreeSpaceExtentsDataGridViewTextBoxColumn.Name = "TotalFreeSpaceExtentsDataGridViewTextBoxColumn"
        Me.TotalFreeSpaceExtentsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalMFTFragmentsDataGridViewTextBoxColumn
        '
        Me.TotalMFTFragmentsDataGridViewTextBoxColumn.DataPropertyName = "TotalMFTFragments"
        Me.TotalMFTFragmentsDataGridViewTextBoxColumn.HeaderText = "TotalMFTFragments"
        Me.TotalMFTFragmentsDataGridViewTextBoxColumn.Name = "TotalMFTFragmentsDataGridViewTextBoxColumn"
        Me.TotalMFTFragmentsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalPageFileFragmentsDataGridViewTextBoxColumn
        '
        Me.TotalPageFileFragmentsDataGridViewTextBoxColumn.DataPropertyName = "TotalPageFileFragments"
        Me.TotalPageFileFragmentsDataGridViewTextBoxColumn.HeaderText = "TotalPageFileFragments"
        Me.TotalPageFileFragmentsDataGridViewTextBoxColumn.Name = "TotalPageFileFragmentsDataGridViewTextBoxColumn"
        Me.TotalPageFileFragmentsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalPercentFragmentationDataGridViewTextBoxColumn
        '
        Me.TotalPercentFragmentationDataGridViewTextBoxColumn.DataPropertyName = "TotalPercentFragmentation"
        Me.TotalPercentFragmentationDataGridViewTextBoxColumn.HeaderText = "TotalPercentFragmentation"
        Me.TotalPercentFragmentationDataGridViewTextBoxColumn.Name = "TotalPercentFragmentationDataGridViewTextBoxColumn"
        Me.TotalPercentFragmentationDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalUnmoveableFilesDataGridViewTextBoxColumn
        '
        Me.TotalUnmoveableFilesDataGridViewTextBoxColumn.DataPropertyName = "TotalUnmoveableFiles"
        Me.TotalUnmoveableFilesDataGridViewTextBoxColumn.HeaderText = "TotalUnmoveableFiles"
        Me.TotalUnmoveableFilesDataGridViewTextBoxColumn.Name = "TotalUnmoveableFilesDataGridViewTextBoxColumn"
        Me.TotalUnmoveableFilesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsedSpaceDataGridViewTextBoxColumn
        '
        Me.UsedSpaceDataGridViewTextBoxColumn.DataPropertyName = "UsedSpace"
        Me.UsedSpaceDataGridViewTextBoxColumn.HeaderText = "UsedSpace"
        Me.UsedSpaceDataGridViewTextBoxColumn.Name = "UsedSpaceDataGridViewTextBoxColumn"
        Me.UsedSpaceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VolumeNameDataGridViewTextBoxColumn
        '
        Me.VolumeNameDataGridViewTextBoxColumn.DataPropertyName = "VolumeName"
        Me.VolumeNameDataGridViewTextBoxColumn.HeaderText = "VolumeName"
        Me.VolumeNameDataGridViewTextBoxColumn.Name = "VolumeNameDataGridViewTextBoxColumn"
        Me.VolumeNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VolumeSizeDataGridViewTextBoxColumn
        '
        Me.VolumeSizeDataGridViewTextBoxColumn.DataPropertyName = "VolumeSize"
        Me.VolumeSizeDataGridViewTextBoxColumn.HeaderText = "VolumeSize"
        Me.VolumeSizeDataGridViewTextBoxColumn.Name = "VolumeSizeDataGridViewTextBoxColumn"
        Me.VolumeSizeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmDefragAnalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 264)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmDefragAnalysis"
        Me.Text = "frmDefragAnalysis"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Win32DefragAnalysisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Win32DefragAnalysisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AverageFileSizeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AverageFragmentsPerFileDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AverageFreeSpacePerExtentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClusterSizeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExcessFolderFragmentsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FilePercentFragmentationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FragmentedFoldersDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FreeSpaceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FreeSpacePercentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FreeSpacePercentFragmentationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LargestFreeSpaceExtentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MFTPercentInUseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MFTRecordCountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PageFileSizeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalExcessFragmentsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalFilesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalFoldersDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalFragmentedFilesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalFreeSpaceExtentsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalMFTFragmentsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalPageFileFragmentsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalPercentFragmentationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalUnmoveableFilesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsedSpaceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VolumeNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VolumeSizeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
