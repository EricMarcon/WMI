<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComputer
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
Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Operating System")
Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Computer System")
Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("User Accounts")
Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Groups")
Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("System Accounts")
Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Accounts", New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode4, TreeNode5})
Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("System", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode6})
Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Services")
Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Batteries")
Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Desktop Monitors")
Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("CD ROM Drives")
Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Physical Media")
Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Disk Drives")
Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Logical Disks")
Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Volumes")
Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Disks", New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode12, TreeNode13, TreeNode14, TreeNode15})
Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Floppy Drives")
Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Keyboard")
Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Physical Memory")
Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Physical Memory Array")
Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Memory", New System.Windows.Forms.TreeNode() {TreeNode19, TreeNode20})
Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Network Adapters")
Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Network Adapters Configuration")
Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Network", New System.Windows.Forms.TreeNode() {TreeNode22, TreeNode23})
Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("On-Board Devices")
Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pointing Devices")
Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Processors")
Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Refrigeration")
Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Video Controllers")
Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Video", New System.Windows.Forms.TreeNode() {TreeNode29})
Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hardware", New System.Windows.Forms.TreeNode() {TreeNode9, TreeNode10, TreeNode16, TreeNode17, TreeNode18, TreeNode21, TreeNode24, TreeNode25, TreeNode26, TreeNode27, TreeNode28, TreeNode30})
Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PnP Entities")
Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("System Drivers")
Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PnP Signed Drivers")
Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Plug and Play", New System.Windows.Forms.TreeNode() {TreeNode32, TreeNode33, TreeNode34})
Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Shares")
Dim TreeNode37 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Computer", New System.Windows.Forms.TreeNode() {TreeNode7, TreeNode8, TreeNode31, TreeNode35, TreeNode36})
Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComputer))
Me.cmsComputer = New System.Windows.Forms.ContextMenuStrip(Me.components)
Me.ShutDownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
Me.RebootToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
Me.CustomShutDownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
Me.cmsShares = New System.Windows.Forms.ContextMenuStrip(Me.components)
Me.NewFileShareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
Me.TreeView1 = New System.Windows.Forms.TreeView
Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
Me.PanelSystemAccounts = New System.Windows.Forms.Panel
Me.dgvSystemAccounts = New System.Windows.Forms.DataGridView
Me.Win32SystemAccountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
Me.PanelBatteries = New System.Windows.Forms.Panel
Me.dgvBatteries = New System.Windows.Forms.DataGridView
Me.AvailabilityDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CaptionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ConfigManagerErrorDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.CreationClassNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DescriptionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DeviceIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ErrorClearedDataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.ErrorDescriptionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn58 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn59 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn60 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.InstallDateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.LastErrorCodeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn62 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.NameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PNPDeviceIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PowerManagementSupportedDataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.DataGridViewTextBoxColumn68 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.StatusDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.StatusInfoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SystemCreationClassNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SystemNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn69 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn70 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CLASSDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DYNASTYDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.GENUSDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.NAMESPACEDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PATHDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PROPERTYCOUNTDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.RELPATHDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SERVERDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SUPERCLASSDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.Win32BatteryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
Me.PanelShares = New System.Windows.Forms.Panel
Me.dgvShares = New System.Windows.Forms.DataGridView
Me.btnShareDelete = New System.Windows.Forms.DataGridViewButtonColumn
Me.AccessMaskDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.AllowMaximumDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.Caption = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DescriptionDataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.MaximumAllowedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ShareName = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PathDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.Win32ShareBindingSource = New System.Windows.Forms.BindingSource(Me.components)
Me.PanelServices = New System.Windows.Forms.Panel
Me.dgvServices = New System.Windows.Forms.DataGridView
Me.btnStartStop = New System.Windows.Forms.DataGridViewButtonColumn
Me.AcceptPauseDataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.AcceptStopDataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.CaptionDataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CheckPointDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CreationClassNameDataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DesktopInteractDataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.DescriptionDataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DisplayNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ErrorControlDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ExitCodeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.InstallDateDataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ServiceName = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PathNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ProcessIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SecurityDescriptorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ServiceSpecificExitCodeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ServiceTypeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.StateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.StartedDataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.StartModeDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.StartNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.StatusDataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SystemCreationClassNameDataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SystemNameDataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.TagIdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.WaitHintDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.Win32ServiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
Me.PanelGroups = New System.Windows.Forms.Panel
Me.dgvGroups = New System.Windows.Forms.DataGridView
Me.CaptionDataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DescriptionDataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DomainDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.InstallDateDataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.LocalAccountDataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.NameDataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SIDTypeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.StatusDataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CLASSDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DYNASTYDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.GENUSDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.NAMESPACEDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PATHDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PROPERTYCOUNTDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.RELPATHDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SERVERDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SUPERCLASSDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.Win32GroupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
Me.PanelUserAccounts = New System.Windows.Forms.Panel
Me.dgvUserAccounts = New System.Windows.Forms.DataGridView
Me.AccountTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CaptionDataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DescriptionDataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DisabledDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.DomainDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.FullNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.InstallDateDataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.LocalAccountDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.LockoutDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.NameDataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PasswordChangeableDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.PasswordExpiresDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.PasswordRequiredDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.SIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SIDTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.StatusDataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CLASSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DYNASTYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.GENUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.NAMESPACEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PATHDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PROPERTYCOUNTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.RELPATHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SERVERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SUPERCLASSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.Win32UserAccountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
Me.PanelVolumes = New System.Windows.Forms.Panel
Me.dgvVolumes = New System.Windows.Forms.DataGridView
Me.DefragAnalysis = New System.Windows.Forms.DataGridViewButtonColumn
Me.AccessDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.AutomountDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.AvailabilityDataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.BlockSizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.BootVolumeDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.CapacityDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CaptionDataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CompressedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.ConfigManagerErrorDataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn10 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.CreationClassNameDataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DefragAnalysisResultDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DefragRecommendedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.DefragResultDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DescriptionDataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DeviceID = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DirtyBitSetDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.DriveLetterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DriveTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ErrorClearedDataGridViewCheckBoxColumn10 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.ErrorDescriptionDataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ErrorMethodologyDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.FileSystemDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.FreeSpaceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.IndexingEnabledDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.InstallDateDataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.LabelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.LastErrorCodeDataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.MaximumFileNameLengthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.MediaTypeDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.NameDataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.NumberOfBlocksDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PageFilePresentDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.PNPDeviceIDDataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PowerManagementSupportedDataGridViewCheckBoxColumn11 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.PurposeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.QuotasEnabledDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.QuotasIncompleteDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.QuotasRebuildingDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.SerialNumberDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.StatusDataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.StatusInfoDataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SupportsDiskQuotasDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.SupportsFileBasedCompressionDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.SystemCreationClassNameDataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SystemVolumeDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.SystemNameDataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.Win32VolumeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
Me.PanelPhysicalMemoryArray = New System.Windows.Forms.Panel
Me.dgvPhysicalMemoryArray = New System.Windows.Forms.DataGridView
Me.CaptionDataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CreationClassNameDataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DepthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DescriptionDataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.HeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.HotSwappableDataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.InstallDateDataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.LocationDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.MaxCapacityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.MemoryDevicesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.MemoryErrorCorrectionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.NameDataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.UseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.RemovableDataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.ReplaceableDataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.StatusDataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.WeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.WidthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.Win32PhysicalMemoryArrayBindingSource = New System.Windows.Forms.BindingSource(Me.components)
Me.PanelOnBoardDevices = New System.Windows.Forms.Panel
Me.dgvOnBoardDevices = New System.Windows.Forms.DataGridView
Me.CaptionDataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CreationClassNameDataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DescriptionDataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DeviceTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.EnabledDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.HotSwappableDataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.InstallDateDataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.NameDataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.RemovableDataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.ReplaceableDataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.StatusDataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.Win32OnBoardDeviceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
Me.PanelPhysicalMemory = New System.Windows.Forms.Panel
Me.dgvPhysicalMemory = New System.Windows.Forms.DataGridView
Me.BankLabelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CapacityDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CaptionDataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CreationClassNameDataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataWidthDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DescriptionDataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DeviceLocatorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.FormFactorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.HotSwappableDataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.InstallDateDataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.InterleaveDataDepthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.InterleavePositionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.MemoryTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.NameDataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PositionInRowDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.RemovableDataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.ReplaceableDataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.StatusDataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.TotalWidthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.TypeDetailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.Win32PhysicalMemoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
Me.PanelPointingDevices = New System.Windows.Forms.Panel
Me.dgvPointingDevices = New System.Windows.Forms.DataGridView
Me.LastErrorCodeDataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.HardwareTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SystemCreationClassNameDataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DeviceInterfaceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.QuadSpeedThresholdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ErrorDescriptionDataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.InstallDateDataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ResolutionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DoubleSpeedThresholdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ManufacturerDataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.StatusDataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.NumberOfButtonsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.HandednessDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PointingTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.StatusInfoDataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SystemNameDataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PowerManagementSupportedDataGridViewCheckBoxColumn10 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.CreationClassNameDataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.IsLockedDataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn9 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.DeviceIDDataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PNPDeviceIDDataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CaptionDataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.InfSectionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SynchDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.InfFileNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ErrorClearedDataGridViewCheckBoxColumn9 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.ConfigManagerErrorDataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ManagementObjectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DescriptionDataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.NameDataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.AvailabilityDataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SampleRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.Win32PointingDeviceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
Me.PanelDesktopMonitors = New System.Windows.Forms.Panel
Me.dgvDesktopMonitors = New System.Windows.Forms.DataGridView
Me.AvailabilityDataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.BandwidthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CaptionDataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ConfigManagerErrorDataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn8 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.CreationClassNameDataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DescriptionDataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DeviceIDDataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DisplayTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ErrorClearedDataGridViewCheckBoxColumn8 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.ErrorDescriptionDataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.InstallDateDataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.IsLockedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.LastErrorCodeDataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.MonitorManufacturerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.MonitorTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.NameDataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PixelsPerXLogicalInchDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PixelsPerYLogicalInchDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PNPDeviceIDDataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PowerManagementSupportedDataGridViewCheckBoxColumn9 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.ScreenHeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ScreenWidthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.StatusDataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.StatusInfoDataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SystemCreationClassNameDataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SystemNameDataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.Win32DesktopMonitorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
Me.PanelVideoControllers = New System.Windows.Forms.Panel
Me.dgvVideoControllers = New System.Windows.Forms.DataGridView
Me.AdapterCompatibilityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.AdapterDACTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.AdapterRAMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.AvailabilityDataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CaptionDataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn7 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.ColorTableEntriesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ConfigManagerErrorDataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CreationClassNameDataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CurrentBitsPerPixelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CurrentHorizontalResolutionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CurrentNumberOfColorsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CurrentVerticalResolutionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CurrentNumberOfColumnsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CurrentNumberOfRowsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CurrentRefreshRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CurrentScanModeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DescriptionDataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DeviceIDDataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DeviceSpecificPensDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DitherTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DriverDateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DriverVersionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ErrorClearedDataGridViewCheckBoxColumn7 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.ErrorDescriptionDataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ICMIntentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ICMMethodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.InfFileNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.InfSectionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.InstallDateDataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.InstalledDisplayDriversDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.LastErrorCodeDataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.MaxMemorySupportedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.MaxNumberControlledDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.MaxRefreshRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.MinRefreshRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.MonochromeDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.NameDataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.NumberOfColorPlanesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.NumberOfVideoPagesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PNPDeviceIDDataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PowerManagementSupportedDataGridViewCheckBoxColumn8 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.ProtocolSupportedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ReservedSystemPaletteEntriesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SpecificationVersionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.StatusDataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.StatusInfoDataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SystemCreationClassNameDataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SystemNameDataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SystemPaletteEntriesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.VideoModeDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.VideoProcessorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.VideoMemoryTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.Win32VideoControllerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
Me.PanelComputerSystem = New System.Windows.Forms.Panel
Me.dgvComputerSystem = New System.Windows.Forms.DataGridView
Me.AutomaticManagedPagefileDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.AutomaticResetCapabilityDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.AutomaticResetBootOptionDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.BootROMSupportedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.BootupStateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CaptionDataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ChassisBootupStateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CreationClassNameDataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DescriptionDataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CurrentTimeZoneDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DNSHostNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DomainRoleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DaylightInEffectDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.DomainDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.EnableDaylightSavingsTimeDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.FrontPanelResetStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.InfraredSupportedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.InitialLoadInfoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.InstallDateDataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.KeyboardPasswordStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.LastLoadInfoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.NameDataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.NameFormatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.NetworkServerModeEnabledDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.NumberOfLogicalProcessorsDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.NumberOfProcessorsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.OEMLogoBitmapDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn
Me.PartOfDomainDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.PauseAfterResetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PCSystemTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PowerManagementSupportedDataGridViewCheckBoxColumn7 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.PowerOnPasswordStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PowerStateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PowerSupplyStateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PrimaryOwnerContactDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PrimaryOwnerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ResetCapabilityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ResetCountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ResetLimitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.StatusDataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SystemStartupDelayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SystemStartupSettingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SystemTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ThermalStateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.TotalPhysicalMemoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.UserNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.WakeUpTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.WorkgroupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.Win32ComputerSystemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
Me.PanelKeyboard = New System.Windows.Forms.Panel
Me.dgvKeyboard = New System.Windows.Forms.DataGridView
Me.Password = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.Win32KeyboardBindingSource = New System.Windows.Forms.BindingSource(Me.components)
Me.PanelPnPSignedDrivers = New System.Windows.Forms.Panel
Me.dgvPnPSignedDrivers = New System.Windows.Forms.DataGridView
Me.DriverProviderName = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CaptionDataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ClassGuidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CompatIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CreationClassNameDataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DescriptionDataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DeviceIDDataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DevLoaderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DeviceNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DeviceClassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DriverDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DriverNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DriverVersionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.FriendlyNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.HardWareIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.InfNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.InstallDateDataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.IsSignedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.LocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ManufacturerDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.NameDataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PDODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SignerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.StatusDataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.StartedDataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.StartModeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SystemCreationClassNameDataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SystemNameDataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.Win32PnPSignedDriverBindingSource = New System.Windows.Forms.BindingSource(Me.components)
Me.PanelSystemDrivers = New System.Windows.Forms.Panel
Me.dgvSystemDrivers = New System.Windows.Forms.DataGridView
Me.AcceptPauseDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.AcceptStopDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.CaptionDataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CreationClassNameDataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DescriptionDataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DesktopInteractDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.DisplayNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ErrorControlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ExitCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.InstallDateDataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PathNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ServiceSpecificExitCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ServiceTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.StartedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.NameDataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.StartModeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.StartNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.StateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.StatusDataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SystemCreationClassNameDataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SystemNameDataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.TagIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.Win32SystemDriverBindingSource = New System.Windows.Forms.BindingSource(Me.components)
Me.PanelRefrigeration = New System.Windows.Forms.Panel
Me.dgvRefrigeration = New System.Windows.Forms.DataGridView
Me.ActiveCoolingDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.AvailabilityDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CaptionDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ConfigManagerErrorDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.CreationClassNameDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DescriptionDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DeviceIDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ErrorDescriptionDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.InstallDateDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.LastErrorCodeDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ErrorClearedDataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.NameDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PNPDeviceIDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PowerManagementSupportedDataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.StatusDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.StatusInfoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SystemCreationClassNameDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SystemNameDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.Win32RefrigerationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
Me.PanelPnPEntities = New System.Windows.Forms.Panel
Me.dgvPnPEntities = New System.Windows.Forms.DataGridView
Me.AvailabilityDataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CaptionDataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ClassGuidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ConfigManagerErrorDataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn6 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.CreationClassNameDataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DescriptionDataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DeviceIDDataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ErrorClearedDataGridViewCheckBoxColumn6 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.ErrorDescriptionDataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.InstallDateDataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.LastErrorCodeDataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ManufacturerDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.NameDataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PNPDeviceIDDataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PowerManagementSupportedDataGridViewCheckBoxColumn6 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.ServiceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.StatusDataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.StatusInfoDataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SystemNameDataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SystemCreationClassNameDataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.Win32PnPEntityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
Me.PanelOS = New System.Windows.Forms.Panel
Me.dgvOS = New System.Windows.Forms.DataGridView
Me.BootDeviceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.BuildNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.BuildTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CaptionDataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CodeSetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CountryCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CreationClassNameDataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CSCreationClassNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CSDVersionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CSNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CurrentTimeZoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataExecutionPrevention32BitApplicationsDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.DataExecutionPreventionAvailableDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.DataExecutionPreventionDriversDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.DataExecutionPreventionSupportPolicyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DebugDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.DescriptionDataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DistributedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.EncryptionLevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ForegroundApplicationBoostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.FreePhysicalMemoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.FreeSpaceInPagingFilesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.FreeVirtualMemoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.InstallDateDataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.LargeSystemCacheDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.LastBootUpTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.LocalDateTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.LocaleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ManufacturerDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.MaxNumberOfProcessesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.MaxProcessMemorySizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.NameDataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.NumberOfLicensedUsersDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.NumberOfProcessesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.NumberOfUsersDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.OperatingSystemSKUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.OrganizationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.OSLanguageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.OSArchitectureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.OSProductSuiteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.OSTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.OtherTypeDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PAEEnabledDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.PlusProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PlusVersionNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ProductTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PrimaryDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.QuantumLengthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.QuantumTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.RegisteredUserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SerialNumberDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ServicePackMajorVersionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ServicePackMinorVersionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SizeStoredInPagingFilesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.StatusDataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SuiteMaskDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SystemDeviceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SystemDirectoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SystemDriveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.TotalSwapSpaceSizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.TotalVirtualMemorySizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.TotalVisibleMemorySizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.VersionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.WindowsDirectoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.Win32OperatingSystemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
Me.PanelEmpty = New System.Windows.Forms.Panel
Me.PanelNetworkAdapterConfiguration = New System.Windows.Forms.Panel
Me.dgvNetworkAdapterConfiguration = New System.Windows.Forms.DataGridView
Me.ArpAlwaysSourceRouteDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.ArpUseEtherSNAPDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.CaptionDataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DatabasePathDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DeadGWDetectEnabledDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.DefaultTOSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DefaultTTLDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DescriptionDataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DHCPEnabledDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.DHCPLeaseExpiresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DHCPLeaseObtainedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DHCPServerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DNSDomainDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DNSEnabledForWINSResolutionDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.DNSHostNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DomainDNSRegistrationEnabledDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.ForwardBufferMemoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.FullDNSRegistrationEnabledDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.IGMPLevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.IndexDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.InterfaceIndexDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.IPConnectionMetricDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.IPEnabledDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.IPFilterSecurityEnabledDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.IPUseZeroBroadcastDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.KeepAliveIntervalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.KeepAliveTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.MACAddressDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.MTUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.NumForwardPacketsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PMTUBHDetectEnabledDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.PMTUDiscoveryEnabledDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.ServiceNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SettingIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.TcpMaxConnectRetransmissionsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.TcpMaxDataRetransmissionsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.TcpipNetbiosOptionsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.TcpNumConnectionsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.TcpUseRFC1122UrgentPointerDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.TcpWindowSizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.WINSScopeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.WINSHostLookupFileDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.WINSEnableLMHostsLookupDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.WINSPrimaryServerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.WINSSecondaryServerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.Win32NetworkAdapterConfigurationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
Me.PanelNetworkAdapter = New System.Windows.Forms.Panel
Me.dgvNetworkAdapter = New System.Windows.Forms.DataGridView
Me.AdapterTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.AdapterTypeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.AutoSenseDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.AvailabilityDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CaptionDataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ConfigManagerErrorDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CreationClassNameDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn5 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.DescriptionDataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DeviceIDDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ErrorClearedDataGridViewCheckBoxColumn5 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.ErrorDescriptionDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.GUIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.IndexDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.InstallDateDataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.InstalledDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.InterfaceIndexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.LastErrorCodeDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.MACAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ManufacturerDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.MaxNumberControlledDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.NameDataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.NetConnectionIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.NetConnectionStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.NetEnabledDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.PhysicalAdapterDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.PNPDeviceIDDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PowerManagementSupportedDataGridViewCheckBoxColumn5 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ServiceNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.StatusDataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.StatusInfoDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SystemCreationClassNameDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SystemNameDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.TimeOfLastResetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.Win32NetworkAdapterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
Me.PanelPhysicalMedia = New System.Windows.Forms.Panel
Me.dgvPhysicalMedia = New System.Windows.Forms.DataGridView
Me.CapacityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CaptionDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CleanerMediaDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.DescriptionDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.HotSwappableDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.InstallDateDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.MediaDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.MediaTypeDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.NameDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.RemovableDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.ReplaceableDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.StatusDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.WriteProtectOnDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.Win32PhysicalMediaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
Me.PanelLogicalDisks = New System.Windows.Forms.Panel
Me.dgvLogicalDisks = New System.Windows.Forms.DataGridView
Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewCheckBoxColumn6 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewCheckBoxColumn9 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn61 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn63 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewCheckBoxColumn11 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.DataGridViewTextBoxColumn64 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn65 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn66 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn67 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.Win32LogicalDiskBindingSource = New System.Windows.Forms.BindingSource(Me.components)
Me.PanelFloppyDrives = New System.Windows.Forms.Panel
Me.dgvFloppyDrives = New System.Windows.Forms.DataGridView
Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewCheckBoxColumn5 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewCheckBoxColumn7 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewCheckBoxColumn8 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn56 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataGridViewTextBoxColumn57 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.Win32FloppyDriveBindingSource = New System.Windows.Forms.BindingSource(Me.components)
Me.PanelDiskDrives = New System.Windows.Forms.Panel
Me.dgvDiskDrives = New System.Windows.Forms.DataGridView
Me.AvailabilityDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.BytesPerSectorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CaptionDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CompressionMethodDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ConfigManagerErrorDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.CreationClassNameDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DefaultBlockSizeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DescriptionDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DeviceIDDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ErrorClearedDataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.ErrorDescriptionDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ErrorMethodologyDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.FirmwareRevisionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.IndexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.InterfaceTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.InstallDateDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.LastErrorCodeDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ManufacturerDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.MaxBlockSizeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.MaxMediaSizeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.MediaLoadedDataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.ModelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.MediaTypeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.MinBlockSizeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.NameDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.NeedsCleaningDataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.NumberOfMediaSupportedDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PartitionsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PNPDeviceIDDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PowerManagementSupportedDataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.SCSIBusDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SCSILogicalUnitDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SCSIPortDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SCSITargetIdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SectorsPerTrackDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SerialNumberDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SizeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.StatusInfoDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SystemCreationClassNameDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SignatureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.StatusDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SystemNameDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.TotalHeadsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.TotalCylindersDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.TotalSectorsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.TotalTracksDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.TracksPerCylinderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.Win32DiskDriveBindingSource = New System.Windows.Forms.BindingSource(Me.components)
Me.PanelCDROMdrives = New System.Windows.Forms.Panel
Me.dgvCDROMdrives = New System.Windows.Forms.DataGridView
Me.AvailabilityDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CaptionDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CompressionMethodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ConfigManagerErrorDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.CreationClassNameDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DefaultBlockSizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DescriptionDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DeviceIDDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DriveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DriveIntegrityDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.ErrorClearedDataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.ErrorDescriptionDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ErrorMethodologyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.FileSystemFlagsExDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.InstallDateDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.LastErrorCodeDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.MaxBlockSizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.MaximumComponentLengthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.MaxMediaSizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.MediaLoadedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.MediaTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.MfrAssignedRevisionLevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.MinBlockSizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.NameDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.NeedsCleaningDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.NumberOfMediaSupportedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PNPDeviceIDDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PowerManagementSupportedDataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.RevisionLevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SCSIBusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SCSILogicalUnitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SCSIPortDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SCSITargetIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SerialNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.StatusDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.StatusInfoDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SystemCreationClassNameDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SystemNameDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.TransferRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.VolumeNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.VolumeSerialNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.Win32CDROMDriveBindingSource = New System.Windows.Forms.BindingSource(Me.components)
Me.PanelProcessors = New System.Windows.Forms.Panel
Me.dgvProcessors = New System.Windows.Forms.DataGridView
Me.AddressWidthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ArchitectureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.AvailabilityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CaptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ConfigManagerErrorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.CpuStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CreationClassNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CurrentClockSpeedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CurrentVoltageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DataWidthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DeviceIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ErrorClearedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.ErrorDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ExtClockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.FamilyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.InstallDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.L2CacheSizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.L2CacheSpeedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.L3CacheSizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.L3CacheSpeedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.LastErrorCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.LevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.LoadPercentageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ManufacturerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.MaxClockSpeedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.NumberOfCoresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.NumberOfLogicalProcessorsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.OtherFamilyDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PNPDeviceIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PowerManagementSupportedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.ProcessorIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.ProcessorTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.RevisionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.RoleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.StatusInfoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SocketDesignationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SteppingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SystemCreationClassNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SystemNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.UniqueIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.UpgradeMethodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.VersionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.VoltageCapsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.Win32ProcessorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
Me.dgvProperties = New System.Windows.Forms.DataGridView
Me.Win32PhysicalMemoryLocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
Me.Win32VolumesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
Me.CaptionDataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DescriptionDataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DomainDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.InstallDateDataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.LocalAccountDataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
Me.NameDataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SIDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SIDTypeDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.StatusDataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.CLASSDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.DYNASTYDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.GENUSDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.NAMESPACEDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PATHDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PROPERTYCOUNTDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.RELPATHDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SERVERDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.SUPERCLASSDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.cmsComputer.SuspendLayout
Me.cmsShares.SuspendLayout
Me.SplitContainer1.Panel1.SuspendLayout
Me.SplitContainer1.Panel2.SuspendLayout
Me.SplitContainer1.SuspendLayout
Me.PanelSystemAccounts.SuspendLayout
CType(Me.dgvSystemAccounts,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Win32SystemAccountBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
Me.PanelBatteries.SuspendLayout
CType(Me.dgvBatteries,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Win32BatteryBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
Me.PanelShares.SuspendLayout
CType(Me.dgvShares,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Win32ShareBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
Me.PanelServices.SuspendLayout
CType(Me.dgvServices,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Win32ServiceBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
Me.PanelGroups.SuspendLayout
CType(Me.dgvGroups,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Win32GroupBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
Me.PanelUserAccounts.SuspendLayout
CType(Me.dgvUserAccounts,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Win32UserAccountBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
Me.PanelVolumes.SuspendLayout
CType(Me.dgvVolumes,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Win32VolumeBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
Me.PanelPhysicalMemoryArray.SuspendLayout
CType(Me.dgvPhysicalMemoryArray,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Win32PhysicalMemoryArrayBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
Me.PanelOnBoardDevices.SuspendLayout
CType(Me.dgvOnBoardDevices,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Win32OnBoardDeviceBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
Me.PanelPhysicalMemory.SuspendLayout
CType(Me.dgvPhysicalMemory,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Win32PhysicalMemoryBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
Me.PanelPointingDevices.SuspendLayout
CType(Me.dgvPointingDevices,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Win32PointingDeviceBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
Me.PanelDesktopMonitors.SuspendLayout
CType(Me.dgvDesktopMonitors,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Win32DesktopMonitorBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
Me.PanelVideoControllers.SuspendLayout
CType(Me.dgvVideoControllers,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Win32VideoControllerBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
Me.PanelComputerSystem.SuspendLayout
CType(Me.dgvComputerSystem,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Win32ComputerSystemBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
Me.PanelKeyboard.SuspendLayout
CType(Me.dgvKeyboard,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Win32KeyboardBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
Me.PanelPnPSignedDrivers.SuspendLayout
CType(Me.dgvPnPSignedDrivers,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Win32PnPSignedDriverBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
Me.PanelSystemDrivers.SuspendLayout
CType(Me.dgvSystemDrivers,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Win32SystemDriverBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
Me.PanelRefrigeration.SuspendLayout
CType(Me.dgvRefrigeration,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Win32RefrigerationBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
Me.PanelPnPEntities.SuspendLayout
CType(Me.dgvPnPEntities,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Win32PnPEntityBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
Me.PanelOS.SuspendLayout
CType(Me.dgvOS,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Win32OperatingSystemBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
Me.PanelNetworkAdapterConfiguration.SuspendLayout
CType(Me.dgvNetworkAdapterConfiguration,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Win32NetworkAdapterConfigurationBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
Me.PanelNetworkAdapter.SuspendLayout
CType(Me.dgvNetworkAdapter,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Win32NetworkAdapterBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
Me.PanelPhysicalMedia.SuspendLayout
CType(Me.dgvPhysicalMedia,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Win32PhysicalMediaBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
Me.PanelLogicalDisks.SuspendLayout
CType(Me.dgvLogicalDisks,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Win32LogicalDiskBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
Me.PanelFloppyDrives.SuspendLayout
CType(Me.dgvFloppyDrives,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Win32FloppyDriveBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
Me.PanelDiskDrives.SuspendLayout
CType(Me.dgvDiskDrives,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Win32DiskDriveBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
Me.PanelCDROMdrives.SuspendLayout
CType(Me.dgvCDROMdrives,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Win32CDROMDriveBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
Me.PanelProcessors.SuspendLayout
CType(Me.dgvProcessors,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Win32ProcessorBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
Me.SplitContainer2.Panel1.SuspendLayout
Me.SplitContainer2.Panel2.SuspendLayout
Me.SplitContainer2.SuspendLayout
CType(Me.dgvProperties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Win32PhysicalMemoryLocationBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Win32VolumesBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
Me.SuspendLayout
'
'cmsComputer
'
Me.cmsComputer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShutDownToolStripMenuItem, Me.RebootToolStripMenuItem, Me.CustomShutDownToolStripMenuItem})
Me.cmsComputer.Name = "cmsComputer"
Me.cmsComputer.Size = New System.Drawing.Size(178, 70)
'
'ShutDownToolStripMenuItem
'
Me.ShutDownToolStripMenuItem.Name = "ShutDownToolStripMenuItem"
Me.ShutDownToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
Me.ShutDownToolStripMenuItem.Text = "&Shut Down"
'
'RebootToolStripMenuItem
'
Me.RebootToolStripMenuItem.Name = "RebootToolStripMenuItem"
Me.RebootToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
Me.RebootToolStripMenuItem.Text = "&Reboot"
'
'CustomShutDownToolStripMenuItem
'
Me.CustomShutDownToolStripMenuItem.Name = "CustomShutDownToolStripMenuItem"
Me.CustomShutDownToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
Me.CustomShutDownToolStripMenuItem.Text = "&Custom Shut Down"
'
'cmsShares
'
Me.cmsShares.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewFileShareToolStripMenuItem})
Me.cmsShares.Name = "cmsShares"
Me.cmsShares.Size = New System.Drawing.Size(196, 26)
'
'NewFileShareToolStripMenuItem
'
Me.NewFileShareToolStripMenuItem.Name = "NewFileShareToolStripMenuItem"
Me.NewFileShareToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
Me.NewFileShareToolStripMenuItem.Text = "&Create a new File Share"
'
'SplitContainer1
'
Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
Me.SplitContainer1.Name = "SplitContainer1"
Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
'
'SplitContainer1.Panel1
'
Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
'
'SplitContainer1.Panel2
'
Me.SplitContainer1.Panel2.Controls.Add(Me.PanelSystemAccounts)
Me.SplitContainer1.Panel2.Controls.Add(Me.PanelBatteries)
Me.SplitContainer1.Panel2.Controls.Add(Me.PanelShares)
Me.SplitContainer1.Panel2.Controls.Add(Me.PanelServices)
Me.SplitContainer1.Panel2.Controls.Add(Me.PanelGroups)
Me.SplitContainer1.Panel2.Controls.Add(Me.PanelUserAccounts)
Me.SplitContainer1.Panel2.Controls.Add(Me.PanelVolumes)
Me.SplitContainer1.Panel2.Controls.Add(Me.PanelPhysicalMemoryArray)
Me.SplitContainer1.Panel2.Controls.Add(Me.PanelOnBoardDevices)
Me.SplitContainer1.Panel2.Controls.Add(Me.PanelPhysicalMemory)
Me.SplitContainer1.Panel2.Controls.Add(Me.PanelPointingDevices)
Me.SplitContainer1.Panel2.Controls.Add(Me.PanelDesktopMonitors)
Me.SplitContainer1.Panel2.Controls.Add(Me.PanelVideoControllers)
Me.SplitContainer1.Panel2.Controls.Add(Me.PanelComputerSystem)
Me.SplitContainer1.Panel2.Controls.Add(Me.PanelKeyboard)
Me.SplitContainer1.Panel2.Controls.Add(Me.PanelPnPSignedDrivers)
Me.SplitContainer1.Panel2.Controls.Add(Me.PanelSystemDrivers)
Me.SplitContainer1.Panel2.Controls.Add(Me.PanelRefrigeration)
Me.SplitContainer1.Panel2.Controls.Add(Me.PanelPnPEntities)
Me.SplitContainer1.Panel2.Controls.Add(Me.PanelOS)
Me.SplitContainer1.Panel2.Controls.Add(Me.PanelEmpty)
Me.SplitContainer1.Panel2.Controls.Add(Me.PanelNetworkAdapterConfiguration)
Me.SplitContainer1.Panel2.Controls.Add(Me.PanelNetworkAdapter)
Me.SplitContainer1.Panel2.Controls.Add(Me.PanelPhysicalMedia)
Me.SplitContainer1.Panel2.Controls.Add(Me.PanelLogicalDisks)
Me.SplitContainer1.Panel2.Controls.Add(Me.PanelFloppyDrives)
Me.SplitContainer1.Panel2.Controls.Add(Me.PanelDiskDrives)
Me.SplitContainer1.Panel2.Controls.Add(Me.PanelCDROMdrives)
Me.SplitContainer1.Panel2.Controls.Add(Me.PanelProcessors)
Me.SplitContainer1.Size = New System.Drawing.Size(468, 361)
Me.SplitContainer1.SplitterDistance = 174
Me.SplitContainer1.TabIndex = 0
'
'TreeView1
'
Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
Me.TreeView1.ImageIndex = 0
Me.TreeView1.ImageList = Me.ImageList1
Me.TreeView1.Location = New System.Drawing.Point(0, 0)
Me.TreeView1.Name = "TreeView1"
TreeNode1.ContextMenuStrip = Me.cmsComputer
TreeNode1.Name = "OperatingSystem"
TreeNode1.Text = "Operating System"
TreeNode2.Name = "ComputerSystem"
TreeNode2.Text = "Computer System"
TreeNode3.ImageKey = "User"
TreeNode3.Name = "UserAccounts"
TreeNode3.SelectedImageKey = "User"
TreeNode3.Text = "User Accounts"
TreeNode4.ImageKey = "Users"
TreeNode4.Name = "Groups"
TreeNode4.SelectedImageKey = "Users"
TreeNode4.Text = "Groups"
TreeNode5.ImageKey = "Computer"
TreeNode5.Name = "SystemAccounts"
TreeNode5.SelectedImageKey = "Computer"
TreeNode5.Text = "System Accounts"
TreeNode6.ImageKey = "Users"
TreeNode6.Name = "Accounts"
TreeNode6.SelectedImageKey = "Users"
TreeNode6.Text = "Accounts"
TreeNode7.Name = "System"
TreeNode7.Text = "System"
TreeNode8.ImageKey = "Software"
TreeNode8.Name = "Services"
TreeNode8.SelectedImageKey = "Software"
TreeNode8.Text = "Services"
TreeNode9.Name = "Batteries"
TreeNode9.Text = "Batteries"
TreeNode10.ImageKey = "Computer"
TreeNode10.Name = "DesktopMonitors"
TreeNode10.SelectedImageKey = "Computer"
TreeNode10.Text = "Desktop Monitors"
TreeNode11.Name = "CDROMdrives"
TreeNode11.Text = "CD ROM Drives"
TreeNode12.Name = "PhysicalMedia"
TreeNode12.Text = "Physical Media"
TreeNode13.Name = "DiskDrives"
TreeNode13.Text = "Disk Drives"
TreeNode14.Name = "LogicalDisks"
TreeNode14.Text = "Logical Disks"
TreeNode15.Name = "Volumes"
TreeNode15.Text = "Volumes"
TreeNode16.Name = "Disks"
TreeNode16.Text = "Disks"
TreeNode17.Name = "FloppyDrives"
TreeNode17.Text = "Floppy Drives"
TreeNode18.Name = "Keyboard"
TreeNode18.Text = "Keyboard"
TreeNode19.Name = "PhysicalMemory"
TreeNode19.Text = "Physical Memory"
TreeNode20.Name = "PhysicalMemoryArray"
TreeNode20.Text = "Physical Memory Array"
TreeNode21.ImageKey = "Chip"
TreeNode21.Name = "Memory"
TreeNode21.SelectedImageKey = "Chip"
TreeNode21.Text = "Memory"
TreeNode22.Name = "NetworkAdapters"
TreeNode22.Text = "Network Adapters"
TreeNode23.Name = "NetworkAdaptersConfiguration"
TreeNode23.Text = "Network Adapters Configuration"
TreeNode24.ImageKey = "ComputerNetwork"
TreeNode24.Name = "Network"
TreeNode24.SelectedImageKey = "ComputerNetwork"
TreeNode24.Text = "Network"
TreeNode25.ImageKey = "Chip"
TreeNode25.Name = "OnBoardDevices"
TreeNode25.SelectedImageKey = "Chip"
TreeNode25.Text = "On-Board Devices"
TreeNode26.Name = "PointingDevices"
TreeNode26.Text = "Pointing Devices"
TreeNode27.ImageKey = "Chip"
TreeNode27.Name = "Processors"
TreeNode27.SelectedImageKey = "Chip"
TreeNode27.Text = "Processors"
TreeNode28.Name = "Refrigeration"
TreeNode28.Text = "Refrigeration"
TreeNode29.Name = "VideoControllers"
TreeNode29.Text = "Video Controllers"
TreeNode30.Name = "Video"
TreeNode30.Text = "Video"
TreeNode31.ImageKey = "Card"
TreeNode31.Name = "Hardware"
TreeNode31.SelectedImageKey = "Card"
TreeNode31.Text = "Hardware"
TreeNode32.Name = "PnPEntities"
TreeNode32.Text = "PnP Entities"
TreeNode33.Name = "SystemDrivers"
TreeNode33.Text = "System Drivers"
TreeNode34.Name = "PnPSignedDrivers"
TreeNode34.Text = "PnP Signed Drivers"
TreeNode35.Name = "Pnp"
TreeNode35.Text = "Plug and Play"
TreeNode36.ContextMenuStrip = Me.cmsShares
TreeNode36.Name = "Shares"
TreeNode36.Text = "Shares"
TreeNode37.ContextMenuStrip = Me.cmsComputer
TreeNode37.ImageKey = "Computer"
TreeNode37.Name = "Computer"
TreeNode37.SelectedImageKey = "Computer"
TreeNode37.Text = "Computer"
Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode37})
Me.TreeView1.SelectedImageIndex = 0
Me.TreeView1.Size = New System.Drawing.Size(468, 174)
Me.TreeView1.TabIndex = 0
'
'ImageList1
'
Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"),System.Windows.Forms.ImageListStreamer)
Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
Me.ImageList1.Images.SetKeyName(0, "Tree")
Me.ImageList1.Images.SetKeyName(1, "Globe")
Me.ImageList1.Images.SetKeyName(2, "ComputerNetwork")
Me.ImageList1.Images.SetKeyName(3, "Home")
Me.ImageList1.Images.SetKeyName(4, "Network")
Me.ImageList1.Images.SetKeyName(5, "Computer")
Me.ImageList1.Images.SetKeyName(6, "Users")
Me.ImageList1.Images.SetKeyName(7, "User")
Me.ImageList1.Images.SetKeyName(8, "Computers")
Me.ImageList1.Images.SetKeyName(9, "Card")
Me.ImageList1.Images.SetKeyName(10, "Chip")
Me.ImageList1.Images.SetKeyName(11, "Software")
Me.ImageList1.Images.SetKeyName(12, "SoftwareType")
Me.ImageList1.Images.SetKeyName(13, "Printer")
'
'PanelSystemAccounts
'
Me.PanelSystemAccounts.Controls.Add(Me.dgvSystemAccounts)
Me.PanelSystemAccounts.Dock = System.Windows.Forms.DockStyle.Fill
Me.PanelSystemAccounts.Location = New System.Drawing.Point(0, 0)
Me.PanelSystemAccounts.Name = "PanelSystemAccounts"
Me.PanelSystemAccounts.Size = New System.Drawing.Size(468, 183)
Me.PanelSystemAccounts.TabIndex = 28
'
'dgvSystemAccounts
'
Me.dgvSystemAccounts.AllowUserToAddRows = false
Me.dgvSystemAccounts.AllowUserToDeleteRows = false
Me.dgvSystemAccounts.AutoGenerateColumns = false
Me.dgvSystemAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
Me.dgvSystemAccounts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CaptionDataGridViewTextBoxColumn23, Me.DescriptionDataGridViewTextBoxColumn24, Me.DomainDataGridViewTextBoxColumn3, Me.InstallDateDataGridViewTextBoxColumn22, Me.LocalAccountDataGridViewCheckBoxColumn2, Me.NameDataGridViewTextBoxColumn15, Me.SIDDataGridViewTextBoxColumn2, Me.SIDTypeDataGridViewTextBoxColumn2, Me.StatusDataGridViewTextBoxColumn22, Me.CLASSDataGridViewTextBoxColumn3, Me.DYNASTYDataGridViewTextBoxColumn3, Me.GENUSDataGridViewTextBoxColumn3, Me.NAMESPACEDataGridViewTextBoxColumn3, Me.PATHDataGridViewTextBoxColumn4, Me.PROPERTYCOUNTDataGridViewTextBoxColumn3, Me.RELPATHDataGridViewTextBoxColumn3, Me.SERVERDataGridViewTextBoxColumn3, Me.SUPERCLASSDataGridViewTextBoxColumn3})
Me.dgvSystemAccounts.DataSource = Me.Win32SystemAccountBindingSource
Me.dgvSystemAccounts.Dock = System.Windows.Forms.DockStyle.Fill
Me.dgvSystemAccounts.Location = New System.Drawing.Point(0, 0)
Me.dgvSystemAccounts.Name = "dgvSystemAccounts"
Me.dgvSystemAccounts.ReadOnly = true
Me.dgvSystemAccounts.Size = New System.Drawing.Size(468, 183)
Me.dgvSystemAccounts.TabIndex = 22
'
'Win32SystemAccountBindingSource
'
Me.Win32SystemAccountBindingSource.DataSource = GetType(WMIwrapper.Win32_SystemAccount)
'
'PanelBatteries
'
Me.PanelBatteries.Controls.Add(Me.dgvBatteries)
Me.PanelBatteries.Dock = System.Windows.Forms.DockStyle.Fill
Me.PanelBatteries.Location = New System.Drawing.Point(0, 0)
Me.PanelBatteries.Name = "PanelBatteries"
Me.PanelBatteries.Size = New System.Drawing.Size(468, 183)
Me.PanelBatteries.TabIndex = 3
'
'dgvBatteries
'
Me.dgvBatteries.AllowUserToAddRows = false
Me.dgvBatteries.AllowUserToDeleteRows = false
Me.dgvBatteries.AutoGenerateColumns = false
Me.dgvBatteries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
Me.dgvBatteries.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AvailabilityDataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn29, Me.CaptionDataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn34, Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn1, Me.ConfigManagerErrorDataGridViewTextBoxColumn1, Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn1, Me.CreationClassNameDataGridViewTextBoxColumn1, Me.DescriptionDataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn44, Me.DataGridViewTextBoxColumn52, Me.DeviceIDDataGridViewTextBoxColumn1, Me.ErrorClearedDataGridViewCheckBoxColumn1, Me.ErrorDescriptionDataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn58, Me.DataGridViewTextBoxColumn55, Me.DataGridViewTextBoxColumn59, Me.DataGridViewTextBoxColumn60, Me.InstallDateDataGridViewTextBoxColumn1, Me.LastErrorCodeDataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn62, Me.NameDataGridViewTextBoxColumn1, Me.PNPDeviceIDDataGridViewTextBoxColumn1, Me.PowerManagementSupportedDataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn68, Me.StatusDataGridViewTextBoxColumn1, Me.StatusInfoDataGridViewTextBoxColumn1, Me.SystemCreationClassNameDataGridViewTextBoxColumn1, Me.SystemNameDataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn69, Me.DataGridViewTextBoxColumn70, Me.CLASSDataGridViewTextBoxColumn2, Me.DYNASTYDataGridViewTextBoxColumn2, Me.GENUSDataGridViewTextBoxColumn2, Me.NAMESPACEDataGridViewTextBoxColumn2, Me.PATHDataGridViewTextBoxColumn3, Me.PROPERTYCOUNTDataGridViewTextBoxColumn2, Me.RELPATHDataGridViewTextBoxColumn2, Me.SERVERDataGridViewTextBoxColumn2, Me.SUPERCLASSDataGridViewTextBoxColumn2})
Me.dgvBatteries.DataSource = Me.Win32BatteryBindingSource
Me.dgvBatteries.Dock = System.Windows.Forms.DockStyle.Fill
Me.dgvBatteries.Location = New System.Drawing.Point(0, 0)
Me.dgvBatteries.Name = "dgvBatteries"
Me.dgvBatteries.ReadOnly = true
Me.dgvBatteries.Size = New System.Drawing.Size(468, 183)
Me.dgvBatteries.TabIndex = 22
'
'AvailabilityDataGridViewTextBoxColumn1
'
Me.AvailabilityDataGridViewTextBoxColumn1.DataPropertyName = "Availability"
Me.AvailabilityDataGridViewTextBoxColumn1.HeaderText = "Availability"
Me.AvailabilityDataGridViewTextBoxColumn1.Name = "AvailabilityDataGridViewTextBoxColumn1"
Me.AvailabilityDataGridViewTextBoxColumn1.ReadOnly = true
'
'DataGridViewTextBoxColumn29
'
Me.DataGridViewTextBoxColumn29.DataPropertyName = "BatteryStatus"
Me.DataGridViewTextBoxColumn29.HeaderText = "BatteryStatus"
Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
Me.DataGridViewTextBoxColumn29.ReadOnly = true
'
'CaptionDataGridViewTextBoxColumn1
'
Me.CaptionDataGridViewTextBoxColumn1.DataPropertyName = "Caption"
Me.CaptionDataGridViewTextBoxColumn1.HeaderText = "Caption"
Me.CaptionDataGridViewTextBoxColumn1.Name = "CaptionDataGridViewTextBoxColumn1"
Me.CaptionDataGridViewTextBoxColumn1.ReadOnly = true
'
'DataGridViewTextBoxColumn34
'
Me.DataGridViewTextBoxColumn34.DataPropertyName = "Chemistry"
Me.DataGridViewTextBoxColumn34.HeaderText = "Chemistry"
Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
Me.DataGridViewTextBoxColumn34.ReadOnly = true
'
'ConfigManagerErrorCodeDataGridViewTextBoxColumn1
'
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn1.DataPropertyName = "ConfigManagerErrorCode"
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn1.HeaderText = "ConfigManagerErrorCode"
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn1.Name = "ConfigManagerErrorCodeDataGridViewTextBoxColumn1"
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn1.ReadOnly = true
'
'ConfigManagerErrorDataGridViewTextBoxColumn1
'
Me.ConfigManagerErrorDataGridViewTextBoxColumn1.DataPropertyName = "ConfigManagerError"
Me.ConfigManagerErrorDataGridViewTextBoxColumn1.HeaderText = "ConfigManagerError"
Me.ConfigManagerErrorDataGridViewTextBoxColumn1.Name = "ConfigManagerErrorDataGridViewTextBoxColumn1"
Me.ConfigManagerErrorDataGridViewTextBoxColumn1.ReadOnly = true
'
'ConfigManagerUserConfigDataGridViewCheckBoxColumn1
'
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn1.DataPropertyName = "ConfigManagerUserConfig"
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn1.HeaderText = "ConfigManagerUserConfig"
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn1.Name = "ConfigManagerUserConfigDataGridViewCheckBoxColumn1"
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn1.ReadOnly = true
'
'CreationClassNameDataGridViewTextBoxColumn1
'
Me.CreationClassNameDataGridViewTextBoxColumn1.DataPropertyName = "CreationClassName"
Me.CreationClassNameDataGridViewTextBoxColumn1.HeaderText = "CreationClassName"
Me.CreationClassNameDataGridViewTextBoxColumn1.Name = "CreationClassNameDataGridViewTextBoxColumn1"
Me.CreationClassNameDataGridViewTextBoxColumn1.ReadOnly = true
'
'DescriptionDataGridViewTextBoxColumn1
'
Me.DescriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description"
Me.DescriptionDataGridViewTextBoxColumn1.HeaderText = "Description"
Me.DescriptionDataGridViewTextBoxColumn1.Name = "DescriptionDataGridViewTextBoxColumn1"
Me.DescriptionDataGridViewTextBoxColumn1.ReadOnly = true
'
'DataGridViewTextBoxColumn44
'
Me.DataGridViewTextBoxColumn44.DataPropertyName = "DesignCapacity"
Me.DataGridViewTextBoxColumn44.HeaderText = "DesignCapacity"
Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
Me.DataGridViewTextBoxColumn44.ReadOnly = true
'
'DataGridViewTextBoxColumn52
'
Me.DataGridViewTextBoxColumn52.DataPropertyName = "DesignVoltage"
Me.DataGridViewTextBoxColumn52.HeaderText = "DesignVoltage"
Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
Me.DataGridViewTextBoxColumn52.ReadOnly = true
'
'DeviceIDDataGridViewTextBoxColumn1
'
Me.DeviceIDDataGridViewTextBoxColumn1.DataPropertyName = "DeviceID"
Me.DeviceIDDataGridViewTextBoxColumn1.HeaderText = "DeviceID"
Me.DeviceIDDataGridViewTextBoxColumn1.Name = "DeviceIDDataGridViewTextBoxColumn1"
Me.DeviceIDDataGridViewTextBoxColumn1.ReadOnly = true
'
'ErrorClearedDataGridViewCheckBoxColumn1
'
Me.ErrorClearedDataGridViewCheckBoxColumn1.DataPropertyName = "ErrorCleared"
Me.ErrorClearedDataGridViewCheckBoxColumn1.HeaderText = "ErrorCleared"
Me.ErrorClearedDataGridViewCheckBoxColumn1.Name = "ErrorClearedDataGridViewCheckBoxColumn1"
Me.ErrorClearedDataGridViewCheckBoxColumn1.ReadOnly = true
'
'ErrorDescriptionDataGridViewTextBoxColumn1
'
Me.ErrorDescriptionDataGridViewTextBoxColumn1.DataPropertyName = "ErrorDescription"
Me.ErrorDescriptionDataGridViewTextBoxColumn1.HeaderText = "ErrorDescription"
Me.ErrorDescriptionDataGridViewTextBoxColumn1.Name = "ErrorDescriptionDataGridViewTextBoxColumn1"
Me.ErrorDescriptionDataGridViewTextBoxColumn1.ReadOnly = true
'
'DataGridViewTextBoxColumn58
'
Me.DataGridViewTextBoxColumn58.DataPropertyName = "EstimatedRunTime"
Me.DataGridViewTextBoxColumn58.HeaderText = "EstimatedRunTime"
Me.DataGridViewTextBoxColumn58.Name = "DataGridViewTextBoxColumn58"
Me.DataGridViewTextBoxColumn58.ReadOnly = true
'
'DataGridViewTextBoxColumn55
'
Me.DataGridViewTextBoxColumn55.DataPropertyName = "EstimatedChargeRemaining"
Me.DataGridViewTextBoxColumn55.HeaderText = "EstimatedChargeRemaining"
Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
Me.DataGridViewTextBoxColumn55.ReadOnly = true
'
'DataGridViewTextBoxColumn59
'
Me.DataGridViewTextBoxColumn59.DataPropertyName = "ExpectedLife"
Me.DataGridViewTextBoxColumn59.HeaderText = "ExpectedLife"
Me.DataGridViewTextBoxColumn59.Name = "DataGridViewTextBoxColumn59"
Me.DataGridViewTextBoxColumn59.ReadOnly = true
'
'DataGridViewTextBoxColumn60
'
Me.DataGridViewTextBoxColumn60.DataPropertyName = "FullChargeCapacity"
Me.DataGridViewTextBoxColumn60.HeaderText = "FullChargeCapacity"
Me.DataGridViewTextBoxColumn60.Name = "DataGridViewTextBoxColumn60"
Me.DataGridViewTextBoxColumn60.ReadOnly = true
'
'InstallDateDataGridViewTextBoxColumn1
'
Me.InstallDateDataGridViewTextBoxColumn1.DataPropertyName = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn1.HeaderText = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn1.Name = "InstallDateDataGridViewTextBoxColumn1"
Me.InstallDateDataGridViewTextBoxColumn1.ReadOnly = true
'
'LastErrorCodeDataGridViewTextBoxColumn1
'
Me.LastErrorCodeDataGridViewTextBoxColumn1.DataPropertyName = "LastErrorCode"
Me.LastErrorCodeDataGridViewTextBoxColumn1.HeaderText = "LastErrorCode"
Me.LastErrorCodeDataGridViewTextBoxColumn1.Name = "LastErrorCodeDataGridViewTextBoxColumn1"
Me.LastErrorCodeDataGridViewTextBoxColumn1.ReadOnly = true
'
'DataGridViewTextBoxColumn62
'
Me.DataGridViewTextBoxColumn62.DataPropertyName = "MaxRechargeTime"
Me.DataGridViewTextBoxColumn62.HeaderText = "MaxRechargeTime"
Me.DataGridViewTextBoxColumn62.Name = "DataGridViewTextBoxColumn62"
Me.DataGridViewTextBoxColumn62.ReadOnly = true
'
'NameDataGridViewTextBoxColumn1
'
Me.NameDataGridViewTextBoxColumn1.DataPropertyName = "Name"
Me.NameDataGridViewTextBoxColumn1.HeaderText = "Name"
Me.NameDataGridViewTextBoxColumn1.Name = "NameDataGridViewTextBoxColumn1"
Me.NameDataGridViewTextBoxColumn1.ReadOnly = true
'
'PNPDeviceIDDataGridViewTextBoxColumn1
'
Me.PNPDeviceIDDataGridViewTextBoxColumn1.DataPropertyName = "PNPDeviceID"
Me.PNPDeviceIDDataGridViewTextBoxColumn1.HeaderText = "PNPDeviceID"
Me.PNPDeviceIDDataGridViewTextBoxColumn1.Name = "PNPDeviceIDDataGridViewTextBoxColumn1"
Me.PNPDeviceIDDataGridViewTextBoxColumn1.ReadOnly = true
'
'PowerManagementSupportedDataGridViewCheckBoxColumn1
'
Me.PowerManagementSupportedDataGridViewCheckBoxColumn1.DataPropertyName = "PowerManagementSupported"
Me.PowerManagementSupportedDataGridViewCheckBoxColumn1.HeaderText = "PowerManagementSupported"
Me.PowerManagementSupportedDataGridViewCheckBoxColumn1.Name = "PowerManagementSupportedDataGridViewCheckBoxColumn1"
Me.PowerManagementSupportedDataGridViewCheckBoxColumn1.ReadOnly = true
'
'DataGridViewTextBoxColumn68
'
Me.DataGridViewTextBoxColumn68.DataPropertyName = "SmartBatteryVersion"
Me.DataGridViewTextBoxColumn68.HeaderText = "SmartBatteryVersion"
Me.DataGridViewTextBoxColumn68.Name = "DataGridViewTextBoxColumn68"
Me.DataGridViewTextBoxColumn68.ReadOnly = true
'
'StatusDataGridViewTextBoxColumn1
'
Me.StatusDataGridViewTextBoxColumn1.DataPropertyName = "Status"
Me.StatusDataGridViewTextBoxColumn1.HeaderText = "Status"
Me.StatusDataGridViewTextBoxColumn1.Name = "StatusDataGridViewTextBoxColumn1"
Me.StatusDataGridViewTextBoxColumn1.ReadOnly = true
'
'StatusInfoDataGridViewTextBoxColumn1
'
Me.StatusInfoDataGridViewTextBoxColumn1.DataPropertyName = "StatusInfo"
Me.StatusInfoDataGridViewTextBoxColumn1.HeaderText = "StatusInfo"
Me.StatusInfoDataGridViewTextBoxColumn1.Name = "StatusInfoDataGridViewTextBoxColumn1"
Me.StatusInfoDataGridViewTextBoxColumn1.ReadOnly = true
'
'SystemCreationClassNameDataGridViewTextBoxColumn1
'
Me.SystemCreationClassNameDataGridViewTextBoxColumn1.DataPropertyName = "SystemCreationClassName"
Me.SystemCreationClassNameDataGridViewTextBoxColumn1.HeaderText = "SystemCreationClassName"
Me.SystemCreationClassNameDataGridViewTextBoxColumn1.Name = "SystemCreationClassNameDataGridViewTextBoxColumn1"
Me.SystemCreationClassNameDataGridViewTextBoxColumn1.ReadOnly = true
'
'SystemNameDataGridViewTextBoxColumn1
'
Me.SystemNameDataGridViewTextBoxColumn1.DataPropertyName = "SystemName"
Me.SystemNameDataGridViewTextBoxColumn1.HeaderText = "SystemName"
Me.SystemNameDataGridViewTextBoxColumn1.Name = "SystemNameDataGridViewTextBoxColumn1"
Me.SystemNameDataGridViewTextBoxColumn1.ReadOnly = true
'
'DataGridViewTextBoxColumn69
'
Me.DataGridViewTextBoxColumn69.DataPropertyName = "TimeOnBattery"
Me.DataGridViewTextBoxColumn69.HeaderText = "TimeOnBattery"
Me.DataGridViewTextBoxColumn69.Name = "DataGridViewTextBoxColumn69"
Me.DataGridViewTextBoxColumn69.ReadOnly = true
'
'DataGridViewTextBoxColumn70
'
Me.DataGridViewTextBoxColumn70.DataPropertyName = "TimeToFullCharge"
Me.DataGridViewTextBoxColumn70.HeaderText = "TimeToFullCharge"
Me.DataGridViewTextBoxColumn70.Name = "DataGridViewTextBoxColumn70"
Me.DataGridViewTextBoxColumn70.ReadOnly = true
'
'CLASSDataGridViewTextBoxColumn2
'
Me.CLASSDataGridViewTextBoxColumn2.DataPropertyName = "__CLASS"
Me.CLASSDataGridViewTextBoxColumn2.HeaderText = "__CLASS"
Me.CLASSDataGridViewTextBoxColumn2.Name = "CLASSDataGridViewTextBoxColumn2"
Me.CLASSDataGridViewTextBoxColumn2.ReadOnly = true
'
'DYNASTYDataGridViewTextBoxColumn2
'
Me.DYNASTYDataGridViewTextBoxColumn2.DataPropertyName = "__DYNASTY"
Me.DYNASTYDataGridViewTextBoxColumn2.HeaderText = "__DYNASTY"
Me.DYNASTYDataGridViewTextBoxColumn2.Name = "DYNASTYDataGridViewTextBoxColumn2"
Me.DYNASTYDataGridViewTextBoxColumn2.ReadOnly = true
'
'GENUSDataGridViewTextBoxColumn2
'
Me.GENUSDataGridViewTextBoxColumn2.DataPropertyName = "__GENUS"
Me.GENUSDataGridViewTextBoxColumn2.HeaderText = "__GENUS"
Me.GENUSDataGridViewTextBoxColumn2.Name = "GENUSDataGridViewTextBoxColumn2"
Me.GENUSDataGridViewTextBoxColumn2.ReadOnly = true
'
'NAMESPACEDataGridViewTextBoxColumn2
'
Me.NAMESPACEDataGridViewTextBoxColumn2.DataPropertyName = "__NAMESPACE"
Me.NAMESPACEDataGridViewTextBoxColumn2.HeaderText = "__NAMESPACE"
Me.NAMESPACEDataGridViewTextBoxColumn2.Name = "NAMESPACEDataGridViewTextBoxColumn2"
Me.NAMESPACEDataGridViewTextBoxColumn2.ReadOnly = true
'
'PATHDataGridViewTextBoxColumn3
'
Me.PATHDataGridViewTextBoxColumn3.DataPropertyName = "__PATH"
Me.PATHDataGridViewTextBoxColumn3.HeaderText = "__PATH"
Me.PATHDataGridViewTextBoxColumn3.Name = "PATHDataGridViewTextBoxColumn3"
Me.PATHDataGridViewTextBoxColumn3.ReadOnly = true
'
'PROPERTYCOUNTDataGridViewTextBoxColumn2
'
Me.PROPERTYCOUNTDataGridViewTextBoxColumn2.DataPropertyName = "__PROPERTY_COUNT"
Me.PROPERTYCOUNTDataGridViewTextBoxColumn2.HeaderText = "__PROPERTY_COUNT"
Me.PROPERTYCOUNTDataGridViewTextBoxColumn2.Name = "PROPERTYCOUNTDataGridViewTextBoxColumn2"
Me.PROPERTYCOUNTDataGridViewTextBoxColumn2.ReadOnly = true
'
'RELPATHDataGridViewTextBoxColumn2
'
Me.RELPATHDataGridViewTextBoxColumn2.DataPropertyName = "__RELPATH"
Me.RELPATHDataGridViewTextBoxColumn2.HeaderText = "__RELPATH"
Me.RELPATHDataGridViewTextBoxColumn2.Name = "RELPATHDataGridViewTextBoxColumn2"
Me.RELPATHDataGridViewTextBoxColumn2.ReadOnly = true
'
'SERVERDataGridViewTextBoxColumn2
'
Me.SERVERDataGridViewTextBoxColumn2.DataPropertyName = "__SERVER"
Me.SERVERDataGridViewTextBoxColumn2.HeaderText = "__SERVER"
Me.SERVERDataGridViewTextBoxColumn2.Name = "SERVERDataGridViewTextBoxColumn2"
Me.SERVERDataGridViewTextBoxColumn2.ReadOnly = true
'
'SUPERCLASSDataGridViewTextBoxColumn2
'
Me.SUPERCLASSDataGridViewTextBoxColumn2.DataPropertyName = "__SUPERCLASS"
Me.SUPERCLASSDataGridViewTextBoxColumn2.HeaderText = "__SUPERCLASS"
Me.SUPERCLASSDataGridViewTextBoxColumn2.Name = "SUPERCLASSDataGridViewTextBoxColumn2"
Me.SUPERCLASSDataGridViewTextBoxColumn2.ReadOnly = true
'
'Win32BatteryBindingSource
'
Me.Win32BatteryBindingSource.DataSource = GetType(WMIwrapper.Win32_Battery)
'
'PanelShares
'
Me.PanelShares.Controls.Add(Me.dgvShares)
Me.PanelShares.Dock = System.Windows.Forms.DockStyle.Fill
Me.PanelShares.Location = New System.Drawing.Point(0, 0)
Me.PanelShares.Name = "PanelShares"
Me.PanelShares.Size = New System.Drawing.Size(468, 183)
Me.PanelShares.TabIndex = 13
'
'dgvShares
'
Me.dgvShares.AllowUserToAddRows = false
Me.dgvShares.AllowUserToDeleteRows = false
Me.dgvShares.AutoGenerateColumns = false
Me.dgvShares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
Me.dgvShares.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.btnShareDelete, Me.AccessMaskDataGridViewTextBoxColumn, Me.AllowMaximumDataGridViewCheckBoxColumn, Me.Caption, Me.DescriptionDataGridViewTextBoxColumn9, Me.MaximumAllowedDataGridViewTextBoxColumn, Me.ShareName, Me.PathDataGridViewTextBoxColumn, Me.Status, Me.TypeDataGridViewTextBoxColumn})
Me.dgvShares.DataSource = Me.Win32ShareBindingSource
Me.dgvShares.Dock = System.Windows.Forms.DockStyle.Fill
Me.dgvShares.Location = New System.Drawing.Point(0, 0)
Me.dgvShares.Name = "dgvShares"
Me.dgvShares.ReadOnly = true
Me.dgvShares.Size = New System.Drawing.Size(468, 183)
Me.dgvShares.TabIndex = 22
'
'btnShareDelete
'
Me.btnShareDelete.HeaderText = ""
Me.btnShareDelete.Name = "btnShareDelete"
Me.btnShareDelete.ReadOnly = true
Me.btnShareDelete.Text = "Delete"
Me.btnShareDelete.UseColumnTextForButtonValue = true
'
'AccessMaskDataGridViewTextBoxColumn
'
Me.AccessMaskDataGridViewTextBoxColumn.DataPropertyName = "AccessMask"
Me.AccessMaskDataGridViewTextBoxColumn.HeaderText = "AccessMask"
Me.AccessMaskDataGridViewTextBoxColumn.Name = "AccessMaskDataGridViewTextBoxColumn"
Me.AccessMaskDataGridViewTextBoxColumn.ReadOnly = true
'
'AllowMaximumDataGridViewCheckBoxColumn
'
Me.AllowMaximumDataGridViewCheckBoxColumn.DataPropertyName = "AllowMaximum"
Me.AllowMaximumDataGridViewCheckBoxColumn.HeaderText = "AllowMaximum"
Me.AllowMaximumDataGridViewCheckBoxColumn.Name = "AllowMaximumDataGridViewCheckBoxColumn"
Me.AllowMaximumDataGridViewCheckBoxColumn.ReadOnly = true
'
'Caption
'
Me.Caption.DataPropertyName = "Caption"
Me.Caption.HeaderText = "Caption"
Me.Caption.Name = "Caption"
Me.Caption.ReadOnly = true
'
'DescriptionDataGridViewTextBoxColumn9
'
Me.DescriptionDataGridViewTextBoxColumn9.DataPropertyName = "Description"
Me.DescriptionDataGridViewTextBoxColumn9.HeaderText = "Description"
Me.DescriptionDataGridViewTextBoxColumn9.Name = "DescriptionDataGridViewTextBoxColumn9"
Me.DescriptionDataGridViewTextBoxColumn9.ReadOnly = true
'
'MaximumAllowedDataGridViewTextBoxColumn
'
Me.MaximumAllowedDataGridViewTextBoxColumn.DataPropertyName = "MaximumAllowed"
Me.MaximumAllowedDataGridViewTextBoxColumn.HeaderText = "MaximumAllowed"
Me.MaximumAllowedDataGridViewTextBoxColumn.Name = "MaximumAllowedDataGridViewTextBoxColumn"
Me.MaximumAllowedDataGridViewTextBoxColumn.ReadOnly = true
'
'ShareName
'
Me.ShareName.DataPropertyName = "Name"
Me.ShareName.HeaderText = "Name"
Me.ShareName.Name = "ShareName"
Me.ShareName.ReadOnly = true
'
'PathDataGridViewTextBoxColumn
'
Me.PathDataGridViewTextBoxColumn.DataPropertyName = "Path"
Me.PathDataGridViewTextBoxColumn.HeaderText = "Path"
Me.PathDataGridViewTextBoxColumn.Name = "PathDataGridViewTextBoxColumn"
Me.PathDataGridViewTextBoxColumn.ReadOnly = true
'
'Status
'
Me.Status.DataPropertyName = "Status"
Me.Status.HeaderText = "Status"
Me.Status.Name = "Status"
Me.Status.ReadOnly = true
'
'TypeDataGridViewTextBoxColumn
'
Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "Type"
Me.TypeDataGridViewTextBoxColumn.HeaderText = "Type"
Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
Me.TypeDataGridViewTextBoxColumn.ReadOnly = true
'
'Win32ShareBindingSource
'
Me.Win32ShareBindingSource.DataSource = GetType(WMIwrapper.Win32_Share)
'
'PanelServices
'
Me.PanelServices.Controls.Add(Me.dgvServices)
Me.PanelServices.Dock = System.Windows.Forms.DockStyle.Fill
Me.PanelServices.Location = New System.Drawing.Point(0, 0)
Me.PanelServices.Name = "PanelServices"
Me.PanelServices.Size = New System.Drawing.Size(468, 183)
Me.PanelServices.TabIndex = 21
'
'dgvServices
'
Me.dgvServices.AllowUserToAddRows = false
Me.dgvServices.AllowUserToDeleteRows = false
Me.dgvServices.AutoGenerateColumns = false
Me.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
Me.dgvServices.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.btnStartStop, Me.AcceptPauseDataGridViewCheckBoxColumn1, Me.AcceptStopDataGridViewCheckBoxColumn1, Me.CaptionDataGridViewTextBoxColumn16, Me.CheckPointDataGridViewTextBoxColumn, Me.CreationClassNameDataGridViewTextBoxColumn14, Me.DesktopInteractDataGridViewCheckBoxColumn1, Me.DescriptionDataGridViewTextBoxColumn17, Me.DisplayNameDataGridViewTextBoxColumn1, Me.ErrorControlDataGridViewTextBoxColumn1, Me.ExitCodeDataGridViewTextBoxColumn1, Me.InstallDateDataGridViewTextBoxColumn15, Me.ServiceName, Me.PathNameDataGridViewTextBoxColumn1, Me.ProcessIdDataGridViewTextBoxColumn, Me.SecurityDescriptorDataGridViewTextBoxColumn, Me.ServiceSpecificExitCodeDataGridViewTextBoxColumn1, Me.ServiceTypeDataGridViewTextBoxColumn1, Me.StateDataGridViewTextBoxColumn1, Me.StartedDataGridViewCheckBoxColumn2, Me.StartModeDataGridViewTextBoxColumn2, Me.StartNameDataGridViewTextBoxColumn1, Me.StatusDataGridViewTextBoxColumn15, Me.SystemCreationClassNameDataGridViewTextBoxColumn12, Me.SystemNameDataGridViewTextBoxColumn12, Me.TagIdDataGridViewTextBoxColumn1, Me.WaitHintDataGridViewTextBoxColumn})
Me.dgvServices.DataSource = Me.Win32ServiceBindingSource
Me.dgvServices.Dock = System.Windows.Forms.DockStyle.Fill
Me.dgvServices.Location = New System.Drawing.Point(0, 0)
Me.dgvServices.Name = "dgvServices"
Me.dgvServices.ReadOnly = true
Me.dgvServices.Size = New System.Drawing.Size(468, 183)
Me.dgvServices.TabIndex = 22
'
'btnStartStop
'
Me.btnStartStop.HeaderText = ""
Me.btnStartStop.Name = "btnStartStop"
Me.btnStartStop.ReadOnly = true
Me.btnStartStop.Text = "Start/Stop"
Me.btnStartStop.UseColumnTextForButtonValue = true
'
'AcceptPauseDataGridViewCheckBoxColumn1
'
Me.AcceptPauseDataGridViewCheckBoxColumn1.DataPropertyName = "AcceptPause"
Me.AcceptPauseDataGridViewCheckBoxColumn1.HeaderText = "AcceptPause"
Me.AcceptPauseDataGridViewCheckBoxColumn1.Name = "AcceptPauseDataGridViewCheckBoxColumn1"
Me.AcceptPauseDataGridViewCheckBoxColumn1.ReadOnly = true
'
'AcceptStopDataGridViewCheckBoxColumn1
'
Me.AcceptStopDataGridViewCheckBoxColumn1.DataPropertyName = "AcceptStop"
Me.AcceptStopDataGridViewCheckBoxColumn1.HeaderText = "AcceptStop"
Me.AcceptStopDataGridViewCheckBoxColumn1.Name = "AcceptStopDataGridViewCheckBoxColumn1"
Me.AcceptStopDataGridViewCheckBoxColumn1.ReadOnly = true
'
'CaptionDataGridViewTextBoxColumn16
'
Me.CaptionDataGridViewTextBoxColumn16.DataPropertyName = "Caption"
Me.CaptionDataGridViewTextBoxColumn16.HeaderText = "Caption"
Me.CaptionDataGridViewTextBoxColumn16.Name = "CaptionDataGridViewTextBoxColumn16"
Me.CaptionDataGridViewTextBoxColumn16.ReadOnly = true
'
'CheckPointDataGridViewTextBoxColumn
'
Me.CheckPointDataGridViewTextBoxColumn.DataPropertyName = "CheckPoint"
Me.CheckPointDataGridViewTextBoxColumn.HeaderText = "CheckPoint"
Me.CheckPointDataGridViewTextBoxColumn.Name = "CheckPointDataGridViewTextBoxColumn"
Me.CheckPointDataGridViewTextBoxColumn.ReadOnly = true
'
'CreationClassNameDataGridViewTextBoxColumn14
'
Me.CreationClassNameDataGridViewTextBoxColumn14.DataPropertyName = "CreationClassName"
Me.CreationClassNameDataGridViewTextBoxColumn14.HeaderText = "CreationClassName"
Me.CreationClassNameDataGridViewTextBoxColumn14.Name = "CreationClassNameDataGridViewTextBoxColumn14"
Me.CreationClassNameDataGridViewTextBoxColumn14.ReadOnly = true
'
'DesktopInteractDataGridViewCheckBoxColumn1
'
Me.DesktopInteractDataGridViewCheckBoxColumn1.DataPropertyName = "DesktopInteract"
Me.DesktopInteractDataGridViewCheckBoxColumn1.HeaderText = "DesktopInteract"
Me.DesktopInteractDataGridViewCheckBoxColumn1.Name = "DesktopInteractDataGridViewCheckBoxColumn1"
Me.DesktopInteractDataGridViewCheckBoxColumn1.ReadOnly = true
'
'DescriptionDataGridViewTextBoxColumn17
'
Me.DescriptionDataGridViewTextBoxColumn17.DataPropertyName = "Description"
Me.DescriptionDataGridViewTextBoxColumn17.HeaderText = "Description"
Me.DescriptionDataGridViewTextBoxColumn17.Name = "DescriptionDataGridViewTextBoxColumn17"
Me.DescriptionDataGridViewTextBoxColumn17.ReadOnly = true
'
'DisplayNameDataGridViewTextBoxColumn1
'
Me.DisplayNameDataGridViewTextBoxColumn1.DataPropertyName = "DisplayName"
Me.DisplayNameDataGridViewTextBoxColumn1.HeaderText = "DisplayName"
Me.DisplayNameDataGridViewTextBoxColumn1.Name = "DisplayNameDataGridViewTextBoxColumn1"
Me.DisplayNameDataGridViewTextBoxColumn1.ReadOnly = true
'
'ErrorControlDataGridViewTextBoxColumn1
'
Me.ErrorControlDataGridViewTextBoxColumn1.DataPropertyName = "ErrorControl"
Me.ErrorControlDataGridViewTextBoxColumn1.HeaderText = "ErrorControl"
Me.ErrorControlDataGridViewTextBoxColumn1.Name = "ErrorControlDataGridViewTextBoxColumn1"
Me.ErrorControlDataGridViewTextBoxColumn1.ReadOnly = true
'
'ExitCodeDataGridViewTextBoxColumn1
'
Me.ExitCodeDataGridViewTextBoxColumn1.DataPropertyName = "ExitCode"
Me.ExitCodeDataGridViewTextBoxColumn1.HeaderText = "ExitCode"
Me.ExitCodeDataGridViewTextBoxColumn1.Name = "ExitCodeDataGridViewTextBoxColumn1"
Me.ExitCodeDataGridViewTextBoxColumn1.ReadOnly = true
'
'InstallDateDataGridViewTextBoxColumn15
'
Me.InstallDateDataGridViewTextBoxColumn15.DataPropertyName = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn15.HeaderText = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn15.Name = "InstallDateDataGridViewTextBoxColumn15"
Me.InstallDateDataGridViewTextBoxColumn15.ReadOnly = true
'
'ServiceName
'
Me.ServiceName.DataPropertyName = "Name"
Me.ServiceName.HeaderText = "Name"
Me.ServiceName.Name = "ServiceName"
Me.ServiceName.ReadOnly = true
'
'PathNameDataGridViewTextBoxColumn1
'
Me.PathNameDataGridViewTextBoxColumn1.DataPropertyName = "PathName"
Me.PathNameDataGridViewTextBoxColumn1.HeaderText = "PathName"
Me.PathNameDataGridViewTextBoxColumn1.Name = "PathNameDataGridViewTextBoxColumn1"
Me.PathNameDataGridViewTextBoxColumn1.ReadOnly = true
'
'ProcessIdDataGridViewTextBoxColumn
'
Me.ProcessIdDataGridViewTextBoxColumn.DataPropertyName = "ProcessId"
Me.ProcessIdDataGridViewTextBoxColumn.HeaderText = "ProcessId"
Me.ProcessIdDataGridViewTextBoxColumn.Name = "ProcessIdDataGridViewTextBoxColumn"
Me.ProcessIdDataGridViewTextBoxColumn.ReadOnly = true
'
'SecurityDescriptorDataGridViewTextBoxColumn
'
Me.SecurityDescriptorDataGridViewTextBoxColumn.DataPropertyName = "SecurityDescriptor"
Me.SecurityDescriptorDataGridViewTextBoxColumn.HeaderText = "SecurityDescriptor"
Me.SecurityDescriptorDataGridViewTextBoxColumn.Name = "SecurityDescriptorDataGridViewTextBoxColumn"
Me.SecurityDescriptorDataGridViewTextBoxColumn.ReadOnly = true
'
'ServiceSpecificExitCodeDataGridViewTextBoxColumn1
'
Me.ServiceSpecificExitCodeDataGridViewTextBoxColumn1.DataPropertyName = "ServiceSpecificExitCode"
Me.ServiceSpecificExitCodeDataGridViewTextBoxColumn1.HeaderText = "ServiceSpecificExitCode"
Me.ServiceSpecificExitCodeDataGridViewTextBoxColumn1.Name = "ServiceSpecificExitCodeDataGridViewTextBoxColumn1"
Me.ServiceSpecificExitCodeDataGridViewTextBoxColumn1.ReadOnly = true
'
'ServiceTypeDataGridViewTextBoxColumn1
'
Me.ServiceTypeDataGridViewTextBoxColumn1.DataPropertyName = "ServiceType"
Me.ServiceTypeDataGridViewTextBoxColumn1.HeaderText = "ServiceType"
Me.ServiceTypeDataGridViewTextBoxColumn1.Name = "ServiceTypeDataGridViewTextBoxColumn1"
Me.ServiceTypeDataGridViewTextBoxColumn1.ReadOnly = true
'
'StateDataGridViewTextBoxColumn1
'
Me.StateDataGridViewTextBoxColumn1.DataPropertyName = "State"
Me.StateDataGridViewTextBoxColumn1.HeaderText = "State"
Me.StateDataGridViewTextBoxColumn1.Name = "StateDataGridViewTextBoxColumn1"
Me.StateDataGridViewTextBoxColumn1.ReadOnly = true
'
'StartedDataGridViewCheckBoxColumn2
'
Me.StartedDataGridViewCheckBoxColumn2.DataPropertyName = "Started"
Me.StartedDataGridViewCheckBoxColumn2.HeaderText = "Started"
Me.StartedDataGridViewCheckBoxColumn2.Name = "StartedDataGridViewCheckBoxColumn2"
Me.StartedDataGridViewCheckBoxColumn2.ReadOnly = true
'
'StartModeDataGridViewTextBoxColumn2
'
Me.StartModeDataGridViewTextBoxColumn2.DataPropertyName = "StartMode"
Me.StartModeDataGridViewTextBoxColumn2.HeaderText = "StartMode"
Me.StartModeDataGridViewTextBoxColumn2.Name = "StartModeDataGridViewTextBoxColumn2"
Me.StartModeDataGridViewTextBoxColumn2.ReadOnly = true
'
'StartNameDataGridViewTextBoxColumn1
'
Me.StartNameDataGridViewTextBoxColumn1.DataPropertyName = "StartName"
Me.StartNameDataGridViewTextBoxColumn1.HeaderText = "StartName"
Me.StartNameDataGridViewTextBoxColumn1.Name = "StartNameDataGridViewTextBoxColumn1"
Me.StartNameDataGridViewTextBoxColumn1.ReadOnly = true
'
'StatusDataGridViewTextBoxColumn15
'
Me.StatusDataGridViewTextBoxColumn15.DataPropertyName = "Status"
Me.StatusDataGridViewTextBoxColumn15.HeaderText = "Status"
Me.StatusDataGridViewTextBoxColumn15.Name = "StatusDataGridViewTextBoxColumn15"
Me.StatusDataGridViewTextBoxColumn15.ReadOnly = true
'
'SystemCreationClassNameDataGridViewTextBoxColumn12
'
Me.SystemCreationClassNameDataGridViewTextBoxColumn12.DataPropertyName = "SystemCreationClassName"
Me.SystemCreationClassNameDataGridViewTextBoxColumn12.HeaderText = "SystemCreationClassName"
Me.SystemCreationClassNameDataGridViewTextBoxColumn12.Name = "SystemCreationClassNameDataGridViewTextBoxColumn12"
Me.SystemCreationClassNameDataGridViewTextBoxColumn12.ReadOnly = true
'
'SystemNameDataGridViewTextBoxColumn12
'
Me.SystemNameDataGridViewTextBoxColumn12.DataPropertyName = "SystemName"
Me.SystemNameDataGridViewTextBoxColumn12.HeaderText = "SystemName"
Me.SystemNameDataGridViewTextBoxColumn12.Name = "SystemNameDataGridViewTextBoxColumn12"
Me.SystemNameDataGridViewTextBoxColumn12.ReadOnly = true
'
'TagIdDataGridViewTextBoxColumn1
'
Me.TagIdDataGridViewTextBoxColumn1.DataPropertyName = "TagId"
Me.TagIdDataGridViewTextBoxColumn1.HeaderText = "TagId"
Me.TagIdDataGridViewTextBoxColumn1.Name = "TagIdDataGridViewTextBoxColumn1"
Me.TagIdDataGridViewTextBoxColumn1.ReadOnly = true
'
'WaitHintDataGridViewTextBoxColumn
'
Me.WaitHintDataGridViewTextBoxColumn.DataPropertyName = "WaitHint"
Me.WaitHintDataGridViewTextBoxColumn.HeaderText = "WaitHint"
Me.WaitHintDataGridViewTextBoxColumn.Name = "WaitHintDataGridViewTextBoxColumn"
Me.WaitHintDataGridViewTextBoxColumn.ReadOnly = true
'
'Win32ServiceBindingSource
'
Me.Win32ServiceBindingSource.DataSource = GetType(WMIwrapper.Win32_Service)
'
'PanelGroups
'
Me.PanelGroups.Controls.Add(Me.dgvGroups)
Me.PanelGroups.Dock = System.Windows.Forms.DockStyle.Fill
Me.PanelGroups.Location = New System.Drawing.Point(0, 0)
Me.PanelGroups.Name = "PanelGroups"
Me.PanelGroups.Size = New System.Drawing.Size(468, 183)
Me.PanelGroups.TabIndex = 27
'
'dgvGroups
'
Me.dgvGroups.AllowUserToAddRows = false
Me.dgvGroups.AllowUserToDeleteRows = false
Me.dgvGroups.AutoGenerateColumns = false
Me.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
Me.dgvGroups.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CaptionDataGridViewTextBoxColumn22, Me.DescriptionDataGridViewTextBoxColumn23, Me.DomainDataGridViewTextBoxColumn2, Me.InstallDateDataGridViewTextBoxColumn21, Me.LocalAccountDataGridViewCheckBoxColumn1, Me.NameDataGridViewTextBoxColumn21, Me.SIDDataGridViewTextBoxColumn1, Me.SIDTypeDataGridViewTextBoxColumn1, Me.StatusDataGridViewTextBoxColumn21, Me.CLASSDataGridViewTextBoxColumn1, Me.DYNASTYDataGridViewTextBoxColumn1, Me.GENUSDataGridViewTextBoxColumn1, Me.NAMESPACEDataGridViewTextBoxColumn1, Me.PATHDataGridViewTextBoxColumn2, Me.PROPERTYCOUNTDataGridViewTextBoxColumn1, Me.RELPATHDataGridViewTextBoxColumn1, Me.SERVERDataGridViewTextBoxColumn1, Me.SUPERCLASSDataGridViewTextBoxColumn1})
Me.dgvGroups.DataSource = Me.Win32GroupBindingSource
Me.dgvGroups.Dock = System.Windows.Forms.DockStyle.Fill
Me.dgvGroups.Location = New System.Drawing.Point(0, 0)
Me.dgvGroups.Name = "dgvGroups"
Me.dgvGroups.ReadOnly = true
Me.dgvGroups.Size = New System.Drawing.Size(468, 183)
Me.dgvGroups.TabIndex = 22
'
'CaptionDataGridViewTextBoxColumn22
'
Me.CaptionDataGridViewTextBoxColumn22.DataPropertyName = "Caption"
Me.CaptionDataGridViewTextBoxColumn22.HeaderText = "Caption"
Me.CaptionDataGridViewTextBoxColumn22.Name = "CaptionDataGridViewTextBoxColumn22"
Me.CaptionDataGridViewTextBoxColumn22.ReadOnly = true
'
'DescriptionDataGridViewTextBoxColumn23
'
Me.DescriptionDataGridViewTextBoxColumn23.DataPropertyName = "Description"
Me.DescriptionDataGridViewTextBoxColumn23.HeaderText = "Description"
Me.DescriptionDataGridViewTextBoxColumn23.Name = "DescriptionDataGridViewTextBoxColumn23"
Me.DescriptionDataGridViewTextBoxColumn23.ReadOnly = true
'
'DomainDataGridViewTextBoxColumn2
'
Me.DomainDataGridViewTextBoxColumn2.DataPropertyName = "Domain"
Me.DomainDataGridViewTextBoxColumn2.HeaderText = "Domain"
Me.DomainDataGridViewTextBoxColumn2.Name = "DomainDataGridViewTextBoxColumn2"
Me.DomainDataGridViewTextBoxColumn2.ReadOnly = true
'
'InstallDateDataGridViewTextBoxColumn21
'
Me.InstallDateDataGridViewTextBoxColumn21.DataPropertyName = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn21.HeaderText = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn21.Name = "InstallDateDataGridViewTextBoxColumn21"
Me.InstallDateDataGridViewTextBoxColumn21.ReadOnly = true
'
'LocalAccountDataGridViewCheckBoxColumn1
'
Me.LocalAccountDataGridViewCheckBoxColumn1.DataPropertyName = "LocalAccount"
Me.LocalAccountDataGridViewCheckBoxColumn1.HeaderText = "LocalAccount"
Me.LocalAccountDataGridViewCheckBoxColumn1.Name = "LocalAccountDataGridViewCheckBoxColumn1"
Me.LocalAccountDataGridViewCheckBoxColumn1.ReadOnly = true
'
'NameDataGridViewTextBoxColumn21
'
Me.NameDataGridViewTextBoxColumn21.DataPropertyName = "Name"
Me.NameDataGridViewTextBoxColumn21.HeaderText = "Name"
Me.NameDataGridViewTextBoxColumn21.Name = "NameDataGridViewTextBoxColumn21"
Me.NameDataGridViewTextBoxColumn21.ReadOnly = true
'
'SIDDataGridViewTextBoxColumn1
'
Me.SIDDataGridViewTextBoxColumn1.DataPropertyName = "SID"
Me.SIDDataGridViewTextBoxColumn1.HeaderText = "SID"
Me.SIDDataGridViewTextBoxColumn1.Name = "SIDDataGridViewTextBoxColumn1"
Me.SIDDataGridViewTextBoxColumn1.ReadOnly = true
'
'SIDTypeDataGridViewTextBoxColumn1
'
Me.SIDTypeDataGridViewTextBoxColumn1.DataPropertyName = "SIDType"
Me.SIDTypeDataGridViewTextBoxColumn1.HeaderText = "SIDType"
Me.SIDTypeDataGridViewTextBoxColumn1.Name = "SIDTypeDataGridViewTextBoxColumn1"
Me.SIDTypeDataGridViewTextBoxColumn1.ReadOnly = true
'
'StatusDataGridViewTextBoxColumn21
'
Me.StatusDataGridViewTextBoxColumn21.DataPropertyName = "Status"
Me.StatusDataGridViewTextBoxColumn21.HeaderText = "Status"
Me.StatusDataGridViewTextBoxColumn21.Name = "StatusDataGridViewTextBoxColumn21"
Me.StatusDataGridViewTextBoxColumn21.ReadOnly = true
'
'CLASSDataGridViewTextBoxColumn1
'
Me.CLASSDataGridViewTextBoxColumn1.DataPropertyName = "__CLASS"
Me.CLASSDataGridViewTextBoxColumn1.HeaderText = "__CLASS"
Me.CLASSDataGridViewTextBoxColumn1.Name = "CLASSDataGridViewTextBoxColumn1"
Me.CLASSDataGridViewTextBoxColumn1.ReadOnly = true
'
'DYNASTYDataGridViewTextBoxColumn1
'
Me.DYNASTYDataGridViewTextBoxColumn1.DataPropertyName = "__DYNASTY"
Me.DYNASTYDataGridViewTextBoxColumn1.HeaderText = "__DYNASTY"
Me.DYNASTYDataGridViewTextBoxColumn1.Name = "DYNASTYDataGridViewTextBoxColumn1"
Me.DYNASTYDataGridViewTextBoxColumn1.ReadOnly = true
'
'GENUSDataGridViewTextBoxColumn1
'
Me.GENUSDataGridViewTextBoxColumn1.DataPropertyName = "__GENUS"
Me.GENUSDataGridViewTextBoxColumn1.HeaderText = "__GENUS"
Me.GENUSDataGridViewTextBoxColumn1.Name = "GENUSDataGridViewTextBoxColumn1"
Me.GENUSDataGridViewTextBoxColumn1.ReadOnly = true
'
'NAMESPACEDataGridViewTextBoxColumn1
'
Me.NAMESPACEDataGridViewTextBoxColumn1.DataPropertyName = "__NAMESPACE"
Me.NAMESPACEDataGridViewTextBoxColumn1.HeaderText = "__NAMESPACE"
Me.NAMESPACEDataGridViewTextBoxColumn1.Name = "NAMESPACEDataGridViewTextBoxColumn1"
Me.NAMESPACEDataGridViewTextBoxColumn1.ReadOnly = true
'
'PATHDataGridViewTextBoxColumn2
'
Me.PATHDataGridViewTextBoxColumn2.DataPropertyName = "__PATH"
Me.PATHDataGridViewTextBoxColumn2.HeaderText = "__PATH"
Me.PATHDataGridViewTextBoxColumn2.Name = "PATHDataGridViewTextBoxColumn2"
Me.PATHDataGridViewTextBoxColumn2.ReadOnly = true
'
'PROPERTYCOUNTDataGridViewTextBoxColumn1
'
Me.PROPERTYCOUNTDataGridViewTextBoxColumn1.DataPropertyName = "__PROPERTY_COUNT"
Me.PROPERTYCOUNTDataGridViewTextBoxColumn1.HeaderText = "__PROPERTY_COUNT"
Me.PROPERTYCOUNTDataGridViewTextBoxColumn1.Name = "PROPERTYCOUNTDataGridViewTextBoxColumn1"
Me.PROPERTYCOUNTDataGridViewTextBoxColumn1.ReadOnly = true
'
'RELPATHDataGridViewTextBoxColumn1
'
Me.RELPATHDataGridViewTextBoxColumn1.DataPropertyName = "__RELPATH"
Me.RELPATHDataGridViewTextBoxColumn1.HeaderText = "__RELPATH"
Me.RELPATHDataGridViewTextBoxColumn1.Name = "RELPATHDataGridViewTextBoxColumn1"
Me.RELPATHDataGridViewTextBoxColumn1.ReadOnly = true
'
'SERVERDataGridViewTextBoxColumn1
'
Me.SERVERDataGridViewTextBoxColumn1.DataPropertyName = "__SERVER"
Me.SERVERDataGridViewTextBoxColumn1.HeaderText = "__SERVER"
Me.SERVERDataGridViewTextBoxColumn1.Name = "SERVERDataGridViewTextBoxColumn1"
Me.SERVERDataGridViewTextBoxColumn1.ReadOnly = true
'
'SUPERCLASSDataGridViewTextBoxColumn1
'
Me.SUPERCLASSDataGridViewTextBoxColumn1.DataPropertyName = "__SUPERCLASS"
Me.SUPERCLASSDataGridViewTextBoxColumn1.HeaderText = "__SUPERCLASS"
Me.SUPERCLASSDataGridViewTextBoxColumn1.Name = "SUPERCLASSDataGridViewTextBoxColumn1"
Me.SUPERCLASSDataGridViewTextBoxColumn1.ReadOnly = true
'
'Win32GroupBindingSource
'
Me.Win32GroupBindingSource.DataSource = GetType(WMIwrapper.Win32_Group)
'
'PanelUserAccounts
'
Me.PanelUserAccounts.Controls.Add(Me.dgvUserAccounts)
Me.PanelUserAccounts.Dock = System.Windows.Forms.DockStyle.Fill
Me.PanelUserAccounts.Location = New System.Drawing.Point(0, 0)
Me.PanelUserAccounts.Name = "PanelUserAccounts"
Me.PanelUserAccounts.Size = New System.Drawing.Size(468, 183)
Me.PanelUserAccounts.TabIndex = 26
'
'dgvUserAccounts
'
Me.dgvUserAccounts.AllowUserToAddRows = false
Me.dgvUserAccounts.AllowUserToDeleteRows = false
Me.dgvUserAccounts.AutoGenerateColumns = false
Me.dgvUserAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
Me.dgvUserAccounts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AccountTypeDataGridViewTextBoxColumn, Me.CaptionDataGridViewTextBoxColumn21, Me.DescriptionDataGridViewTextBoxColumn22, Me.DisabledDataGridViewCheckBoxColumn, Me.DomainDataGridViewTextBoxColumn1, Me.FullNameDataGridViewTextBoxColumn, Me.InstallDateDataGridViewTextBoxColumn20, Me.LocalAccountDataGridViewCheckBoxColumn, Me.LockoutDataGridViewCheckBoxColumn, Me.NameDataGridViewTextBoxColumn20, Me.PasswordChangeableDataGridViewCheckBoxColumn, Me.PasswordExpiresDataGridViewCheckBoxColumn, Me.PasswordRequiredDataGridViewCheckBoxColumn, Me.SIDDataGridViewTextBoxColumn, Me.SIDTypeDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn20, Me.CLASSDataGridViewTextBoxColumn, Me.DYNASTYDataGridViewTextBoxColumn, Me.GENUSDataGridViewTextBoxColumn, Me.NAMESPACEDataGridViewTextBoxColumn, Me.PATHDataGridViewTextBoxColumn1, Me.PROPERTYCOUNTDataGridViewTextBoxColumn, Me.RELPATHDataGridViewTextBoxColumn, Me.SERVERDataGridViewTextBoxColumn, Me.SUPERCLASSDataGridViewTextBoxColumn})
Me.dgvUserAccounts.DataSource = Me.Win32UserAccountBindingSource
Me.dgvUserAccounts.Dock = System.Windows.Forms.DockStyle.Fill
Me.dgvUserAccounts.Location = New System.Drawing.Point(0, 0)
Me.dgvUserAccounts.Name = "dgvUserAccounts"
Me.dgvUserAccounts.ReadOnly = true
Me.dgvUserAccounts.Size = New System.Drawing.Size(468, 183)
Me.dgvUserAccounts.TabIndex = 22
'
'AccountTypeDataGridViewTextBoxColumn
'
Me.AccountTypeDataGridViewTextBoxColumn.DataPropertyName = "AccountType"
Me.AccountTypeDataGridViewTextBoxColumn.HeaderText = "AccountType"
Me.AccountTypeDataGridViewTextBoxColumn.Name = "AccountTypeDataGridViewTextBoxColumn"
Me.AccountTypeDataGridViewTextBoxColumn.ReadOnly = true
'
'CaptionDataGridViewTextBoxColumn21
'
Me.CaptionDataGridViewTextBoxColumn21.DataPropertyName = "Caption"
Me.CaptionDataGridViewTextBoxColumn21.HeaderText = "Caption"
Me.CaptionDataGridViewTextBoxColumn21.Name = "CaptionDataGridViewTextBoxColumn21"
Me.CaptionDataGridViewTextBoxColumn21.ReadOnly = true
'
'DescriptionDataGridViewTextBoxColumn22
'
Me.DescriptionDataGridViewTextBoxColumn22.DataPropertyName = "Description"
Me.DescriptionDataGridViewTextBoxColumn22.HeaderText = "Description"
Me.DescriptionDataGridViewTextBoxColumn22.Name = "DescriptionDataGridViewTextBoxColumn22"
Me.DescriptionDataGridViewTextBoxColumn22.ReadOnly = true
'
'DisabledDataGridViewCheckBoxColumn
'
Me.DisabledDataGridViewCheckBoxColumn.DataPropertyName = "Disabled"
Me.DisabledDataGridViewCheckBoxColumn.HeaderText = "Disabled"
Me.DisabledDataGridViewCheckBoxColumn.Name = "DisabledDataGridViewCheckBoxColumn"
Me.DisabledDataGridViewCheckBoxColumn.ReadOnly = true
'
'DomainDataGridViewTextBoxColumn1
'
Me.DomainDataGridViewTextBoxColumn1.DataPropertyName = "Domain"
Me.DomainDataGridViewTextBoxColumn1.HeaderText = "Domain"
Me.DomainDataGridViewTextBoxColumn1.Name = "DomainDataGridViewTextBoxColumn1"
Me.DomainDataGridViewTextBoxColumn1.ReadOnly = true
'
'FullNameDataGridViewTextBoxColumn
'
Me.FullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName"
Me.FullNameDataGridViewTextBoxColumn.HeaderText = "FullName"
Me.FullNameDataGridViewTextBoxColumn.Name = "FullNameDataGridViewTextBoxColumn"
Me.FullNameDataGridViewTextBoxColumn.ReadOnly = true
'
'InstallDateDataGridViewTextBoxColumn20
'
Me.InstallDateDataGridViewTextBoxColumn20.DataPropertyName = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn20.HeaderText = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn20.Name = "InstallDateDataGridViewTextBoxColumn20"
Me.InstallDateDataGridViewTextBoxColumn20.ReadOnly = true
'
'LocalAccountDataGridViewCheckBoxColumn
'
Me.LocalAccountDataGridViewCheckBoxColumn.DataPropertyName = "LocalAccount"
Me.LocalAccountDataGridViewCheckBoxColumn.HeaderText = "LocalAccount"
Me.LocalAccountDataGridViewCheckBoxColumn.Name = "LocalAccountDataGridViewCheckBoxColumn"
Me.LocalAccountDataGridViewCheckBoxColumn.ReadOnly = true
'
'LockoutDataGridViewCheckBoxColumn
'
Me.LockoutDataGridViewCheckBoxColumn.DataPropertyName = "Lockout"
Me.LockoutDataGridViewCheckBoxColumn.HeaderText = "Lockout"
Me.LockoutDataGridViewCheckBoxColumn.Name = "LockoutDataGridViewCheckBoxColumn"
Me.LockoutDataGridViewCheckBoxColumn.ReadOnly = true
'
'NameDataGridViewTextBoxColumn20
'
Me.NameDataGridViewTextBoxColumn20.DataPropertyName = "Name"
Me.NameDataGridViewTextBoxColumn20.HeaderText = "Name"
Me.NameDataGridViewTextBoxColumn20.Name = "NameDataGridViewTextBoxColumn20"
Me.NameDataGridViewTextBoxColumn20.ReadOnly = true
'
'PasswordChangeableDataGridViewCheckBoxColumn
'
Me.PasswordChangeableDataGridViewCheckBoxColumn.DataPropertyName = "PasswordChangeable"
Me.PasswordChangeableDataGridViewCheckBoxColumn.HeaderText = "PasswordChangeable"
Me.PasswordChangeableDataGridViewCheckBoxColumn.Name = "PasswordChangeableDataGridViewCheckBoxColumn"
Me.PasswordChangeableDataGridViewCheckBoxColumn.ReadOnly = true
'
'PasswordExpiresDataGridViewCheckBoxColumn
'
Me.PasswordExpiresDataGridViewCheckBoxColumn.DataPropertyName = "PasswordExpires"
Me.PasswordExpiresDataGridViewCheckBoxColumn.HeaderText = "PasswordExpires"
Me.PasswordExpiresDataGridViewCheckBoxColumn.Name = "PasswordExpiresDataGridViewCheckBoxColumn"
Me.PasswordExpiresDataGridViewCheckBoxColumn.ReadOnly = true
'
'PasswordRequiredDataGridViewCheckBoxColumn
'
Me.PasswordRequiredDataGridViewCheckBoxColumn.DataPropertyName = "PasswordRequired"
Me.PasswordRequiredDataGridViewCheckBoxColumn.HeaderText = "PasswordRequired"
Me.PasswordRequiredDataGridViewCheckBoxColumn.Name = "PasswordRequiredDataGridViewCheckBoxColumn"
Me.PasswordRequiredDataGridViewCheckBoxColumn.ReadOnly = true
'
'SIDDataGridViewTextBoxColumn
'
Me.SIDDataGridViewTextBoxColumn.DataPropertyName = "SID"
Me.SIDDataGridViewTextBoxColumn.HeaderText = "SID"
Me.SIDDataGridViewTextBoxColumn.Name = "SIDDataGridViewTextBoxColumn"
Me.SIDDataGridViewTextBoxColumn.ReadOnly = true
'
'SIDTypeDataGridViewTextBoxColumn
'
Me.SIDTypeDataGridViewTextBoxColumn.DataPropertyName = "SIDType"
Me.SIDTypeDataGridViewTextBoxColumn.HeaderText = "SIDType"
Me.SIDTypeDataGridViewTextBoxColumn.Name = "SIDTypeDataGridViewTextBoxColumn"
Me.SIDTypeDataGridViewTextBoxColumn.ReadOnly = true
'
'StatusDataGridViewTextBoxColumn20
'
Me.StatusDataGridViewTextBoxColumn20.DataPropertyName = "Status"
Me.StatusDataGridViewTextBoxColumn20.HeaderText = "Status"
Me.StatusDataGridViewTextBoxColumn20.Name = "StatusDataGridViewTextBoxColumn20"
Me.StatusDataGridViewTextBoxColumn20.ReadOnly = true
'
'CLASSDataGridViewTextBoxColumn
'
Me.CLASSDataGridViewTextBoxColumn.DataPropertyName = "__CLASS"
Me.CLASSDataGridViewTextBoxColumn.HeaderText = "__CLASS"
Me.CLASSDataGridViewTextBoxColumn.Name = "CLASSDataGridViewTextBoxColumn"
Me.CLASSDataGridViewTextBoxColumn.ReadOnly = true
'
'DYNASTYDataGridViewTextBoxColumn
'
Me.DYNASTYDataGridViewTextBoxColumn.DataPropertyName = "__DYNASTY"
Me.DYNASTYDataGridViewTextBoxColumn.HeaderText = "__DYNASTY"
Me.DYNASTYDataGridViewTextBoxColumn.Name = "DYNASTYDataGridViewTextBoxColumn"
Me.DYNASTYDataGridViewTextBoxColumn.ReadOnly = true
'
'GENUSDataGridViewTextBoxColumn
'
Me.GENUSDataGridViewTextBoxColumn.DataPropertyName = "__GENUS"
Me.GENUSDataGridViewTextBoxColumn.HeaderText = "__GENUS"
Me.GENUSDataGridViewTextBoxColumn.Name = "GENUSDataGridViewTextBoxColumn"
Me.GENUSDataGridViewTextBoxColumn.ReadOnly = true
'
'NAMESPACEDataGridViewTextBoxColumn
'
Me.NAMESPACEDataGridViewTextBoxColumn.DataPropertyName = "__NAMESPACE"
Me.NAMESPACEDataGridViewTextBoxColumn.HeaderText = "__NAMESPACE"
Me.NAMESPACEDataGridViewTextBoxColumn.Name = "NAMESPACEDataGridViewTextBoxColumn"
Me.NAMESPACEDataGridViewTextBoxColumn.ReadOnly = true
'
'PATHDataGridViewTextBoxColumn1
'
Me.PATHDataGridViewTextBoxColumn1.DataPropertyName = "__PATH"
Me.PATHDataGridViewTextBoxColumn1.HeaderText = "__PATH"
Me.PATHDataGridViewTextBoxColumn1.Name = "PATHDataGridViewTextBoxColumn1"
Me.PATHDataGridViewTextBoxColumn1.ReadOnly = true
'
'PROPERTYCOUNTDataGridViewTextBoxColumn
'
Me.PROPERTYCOUNTDataGridViewTextBoxColumn.DataPropertyName = "__PROPERTY_COUNT"
Me.PROPERTYCOUNTDataGridViewTextBoxColumn.HeaderText = "__PROPERTY_COUNT"
Me.PROPERTYCOUNTDataGridViewTextBoxColumn.Name = "PROPERTYCOUNTDataGridViewTextBoxColumn"
Me.PROPERTYCOUNTDataGridViewTextBoxColumn.ReadOnly = true
'
'RELPATHDataGridViewTextBoxColumn
'
Me.RELPATHDataGridViewTextBoxColumn.DataPropertyName = "__RELPATH"
Me.RELPATHDataGridViewTextBoxColumn.HeaderText = "__RELPATH"
Me.RELPATHDataGridViewTextBoxColumn.Name = "RELPATHDataGridViewTextBoxColumn"
Me.RELPATHDataGridViewTextBoxColumn.ReadOnly = true
'
'SERVERDataGridViewTextBoxColumn
'
Me.SERVERDataGridViewTextBoxColumn.DataPropertyName = "__SERVER"
Me.SERVERDataGridViewTextBoxColumn.HeaderText = "__SERVER"
Me.SERVERDataGridViewTextBoxColumn.Name = "SERVERDataGridViewTextBoxColumn"
Me.SERVERDataGridViewTextBoxColumn.ReadOnly = true
'
'SUPERCLASSDataGridViewTextBoxColumn
'
Me.SUPERCLASSDataGridViewTextBoxColumn.DataPropertyName = "__SUPERCLASS"
Me.SUPERCLASSDataGridViewTextBoxColumn.HeaderText = "__SUPERCLASS"
Me.SUPERCLASSDataGridViewTextBoxColumn.Name = "SUPERCLASSDataGridViewTextBoxColumn"
Me.SUPERCLASSDataGridViewTextBoxColumn.ReadOnly = true
'
'Win32UserAccountBindingSource
'
Me.Win32UserAccountBindingSource.DataSource = GetType(WMIwrapper.Win32_UserAccount)
'
'PanelVolumes
'
Me.PanelVolumes.Controls.Add(Me.dgvVolumes)
Me.PanelVolumes.Dock = System.Windows.Forms.DockStyle.Fill
Me.PanelVolumes.Location = New System.Drawing.Point(0, 0)
Me.PanelVolumes.Name = "PanelVolumes"
Me.PanelVolumes.Size = New System.Drawing.Size(468, 183)
Me.PanelVolumes.TabIndex = 25
'
'dgvVolumes
'
Me.dgvVolumes.AllowUserToAddRows = false
Me.dgvVolumes.AllowUserToDeleteRows = false
Me.dgvVolumes.AutoGenerateColumns = false
Me.dgvVolumes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
Me.dgvVolumes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DefragAnalysis, Me.AccessDataGridViewTextBoxColumn, Me.AutomountDataGridViewCheckBoxColumn, Me.AvailabilityDataGridViewTextBoxColumn10, Me.BlockSizeDataGridViewTextBoxColumn, Me.BootVolumeDataGridViewCheckBoxColumn, Me.CapacityDataGridViewTextBoxColumn2, Me.CaptionDataGridViewTextBoxColumn20, Me.CompressedDataGridViewCheckBoxColumn, Me.ConfigManagerErrorDataGridViewTextBoxColumn10, Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn10, Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn10, Me.CreationClassNameDataGridViewTextBoxColumn18, Me.DefragAnalysisResultDataGridViewTextBoxColumn, Me.DefragRecommendedDataGridViewCheckBoxColumn, Me.DefragResultDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn21, Me.DeviceID, Me.DirtyBitSetDataGridViewCheckBoxColumn, Me.DriveLetterDataGridViewTextBoxColumn, Me.DriveTypeDataGridViewTextBoxColumn, Me.ErrorClearedDataGridViewCheckBoxColumn10, Me.ErrorDescriptionDataGridViewTextBoxColumn10, Me.ErrorMethodologyDataGridViewTextBoxColumn2, Me.FileSystemDataGridViewTextBoxColumn, Me.FreeSpaceDataGridViewTextBoxColumn, Me.IndexingEnabledDataGridViewCheckBoxColumn, Me.InstallDateDataGridViewTextBoxColumn19, Me.LabelDataGridViewTextBoxColumn, Me.LastErrorCodeDataGridViewTextBoxColumn10, Me.MaximumFileNameLengthDataGridViewTextBoxColumn, Me.MediaTypeDataGridViewTextBoxColumn3, Me.NameDataGridViewTextBoxColumn19, Me.NumberOfBlocksDataGridViewTextBoxColumn, Me.PageFilePresentDataGridViewCheckBoxColumn, Me.PNPDeviceIDDataGridViewTextBoxColumn10, Me.PowerManagementSupportedDataGridViewCheckBoxColumn11, Me.PurposeDataGridViewTextBoxColumn, Me.QuotasEnabledDataGridViewCheckBoxColumn, Me.QuotasIncompleteDataGridViewCheckBoxColumn, Me.QuotasRebuildingDataGridViewCheckBoxColumn, Me.SerialNumberDataGridViewTextBoxColumn3, Me.StatusDataGridViewTextBoxColumn19, Me.StatusInfoDataGridViewTextBoxColumn10, Me.SupportsDiskQuotasDataGridViewCheckBoxColumn, Me.SupportsFileBasedCompressionDataGridViewCheckBoxColumn, Me.SystemCreationClassNameDataGridViewTextBoxColumn13, Me.SystemVolumeDataGridViewCheckBoxColumn, Me.SystemNameDataGridViewTextBoxColumn13})
Me.dgvVolumes.DataSource = Me.Win32VolumeBindingSource
Me.dgvVolumes.Dock = System.Windows.Forms.DockStyle.Fill
Me.dgvVolumes.Location = New System.Drawing.Point(0, 0)
Me.dgvVolumes.Name = "dgvVolumes"
Me.dgvVolumes.ReadOnly = true
Me.dgvVolumes.Size = New System.Drawing.Size(468, 183)
Me.dgvVolumes.TabIndex = 22
'
'DefragAnalysis
'
Me.DefragAnalysis.HeaderText = "Defrag Analysis"
Me.DefragAnalysis.Name = "DefragAnalysis"
Me.DefragAnalysis.ReadOnly = true
Me.DefragAnalysis.Text = "Defrag Analysis"
Me.DefragAnalysis.UseColumnTextForButtonValue = true
'
'AccessDataGridViewTextBoxColumn
'
Me.AccessDataGridViewTextBoxColumn.DataPropertyName = "Access"
Me.AccessDataGridViewTextBoxColumn.HeaderText = "Access"
Me.AccessDataGridViewTextBoxColumn.Name = "AccessDataGridViewTextBoxColumn"
Me.AccessDataGridViewTextBoxColumn.ReadOnly = true
'
'AutomountDataGridViewCheckBoxColumn
'
Me.AutomountDataGridViewCheckBoxColumn.DataPropertyName = "Automount"
Me.AutomountDataGridViewCheckBoxColumn.HeaderText = "Automount"
Me.AutomountDataGridViewCheckBoxColumn.Name = "AutomountDataGridViewCheckBoxColumn"
Me.AutomountDataGridViewCheckBoxColumn.ReadOnly = true
'
'AvailabilityDataGridViewTextBoxColumn10
'
Me.AvailabilityDataGridViewTextBoxColumn10.DataPropertyName = "Availability"
Me.AvailabilityDataGridViewTextBoxColumn10.HeaderText = "Availability"
Me.AvailabilityDataGridViewTextBoxColumn10.Name = "AvailabilityDataGridViewTextBoxColumn10"
Me.AvailabilityDataGridViewTextBoxColumn10.ReadOnly = true
'
'BlockSizeDataGridViewTextBoxColumn
'
Me.BlockSizeDataGridViewTextBoxColumn.DataPropertyName = "BlockSize"
Me.BlockSizeDataGridViewTextBoxColumn.HeaderText = "BlockSize"
Me.BlockSizeDataGridViewTextBoxColumn.Name = "BlockSizeDataGridViewTextBoxColumn"
Me.BlockSizeDataGridViewTextBoxColumn.ReadOnly = true
'
'BootVolumeDataGridViewCheckBoxColumn
'
Me.BootVolumeDataGridViewCheckBoxColumn.DataPropertyName = "BootVolume"
Me.BootVolumeDataGridViewCheckBoxColumn.HeaderText = "BootVolume"
Me.BootVolumeDataGridViewCheckBoxColumn.Name = "BootVolumeDataGridViewCheckBoxColumn"
Me.BootVolumeDataGridViewCheckBoxColumn.ReadOnly = true
'
'CapacityDataGridViewTextBoxColumn2
'
Me.CapacityDataGridViewTextBoxColumn2.DataPropertyName = "Capacity"
Me.CapacityDataGridViewTextBoxColumn2.HeaderText = "Capacity"
Me.CapacityDataGridViewTextBoxColumn2.Name = "CapacityDataGridViewTextBoxColumn2"
Me.CapacityDataGridViewTextBoxColumn2.ReadOnly = true
'
'CaptionDataGridViewTextBoxColumn20
'
Me.CaptionDataGridViewTextBoxColumn20.DataPropertyName = "Caption"
Me.CaptionDataGridViewTextBoxColumn20.HeaderText = "Caption"
Me.CaptionDataGridViewTextBoxColumn20.Name = "CaptionDataGridViewTextBoxColumn20"
Me.CaptionDataGridViewTextBoxColumn20.ReadOnly = true
'
'CompressedDataGridViewCheckBoxColumn
'
Me.CompressedDataGridViewCheckBoxColumn.DataPropertyName = "Compressed"
Me.CompressedDataGridViewCheckBoxColumn.HeaderText = "Compressed"
Me.CompressedDataGridViewCheckBoxColumn.Name = "CompressedDataGridViewCheckBoxColumn"
Me.CompressedDataGridViewCheckBoxColumn.ReadOnly = true
'
'ConfigManagerErrorDataGridViewTextBoxColumn10
'
Me.ConfigManagerErrorDataGridViewTextBoxColumn10.DataPropertyName = "ConfigManagerError"
Me.ConfigManagerErrorDataGridViewTextBoxColumn10.HeaderText = "ConfigManagerError"
Me.ConfigManagerErrorDataGridViewTextBoxColumn10.Name = "ConfigManagerErrorDataGridViewTextBoxColumn10"
Me.ConfigManagerErrorDataGridViewTextBoxColumn10.ReadOnly = true
'
'ConfigManagerErrorCodeDataGridViewTextBoxColumn10
'
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn10.DataPropertyName = "ConfigManagerErrorCode"
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn10.HeaderText = "ConfigManagerErrorCode"
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn10.Name = "ConfigManagerErrorCodeDataGridViewTextBoxColumn10"
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn10.ReadOnly = true
'
'ConfigManagerUserConfigDataGridViewCheckBoxColumn10
'
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn10.DataPropertyName = "ConfigManagerUserConfig"
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn10.HeaderText = "ConfigManagerUserConfig"
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn10.Name = "ConfigManagerUserConfigDataGridViewCheckBoxColumn10"
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn10.ReadOnly = true
'
'CreationClassNameDataGridViewTextBoxColumn18
'
Me.CreationClassNameDataGridViewTextBoxColumn18.DataPropertyName = "CreationClassName"
Me.CreationClassNameDataGridViewTextBoxColumn18.HeaderText = "CreationClassName"
Me.CreationClassNameDataGridViewTextBoxColumn18.Name = "CreationClassNameDataGridViewTextBoxColumn18"
Me.CreationClassNameDataGridViewTextBoxColumn18.ReadOnly = true
'
'DefragAnalysisResultDataGridViewTextBoxColumn
'
Me.DefragAnalysisResultDataGridViewTextBoxColumn.DataPropertyName = "DefragAnalysisResult"
Me.DefragAnalysisResultDataGridViewTextBoxColumn.HeaderText = "DefragAnalysisResult"
Me.DefragAnalysisResultDataGridViewTextBoxColumn.Name = "DefragAnalysisResultDataGridViewTextBoxColumn"
Me.DefragAnalysisResultDataGridViewTextBoxColumn.ReadOnly = true
'
'DefragRecommendedDataGridViewCheckBoxColumn
'
Me.DefragRecommendedDataGridViewCheckBoxColumn.DataPropertyName = "DefragRecommended"
Me.DefragRecommendedDataGridViewCheckBoxColumn.HeaderText = "DefragRecommended"
Me.DefragRecommendedDataGridViewCheckBoxColumn.Name = "DefragRecommendedDataGridViewCheckBoxColumn"
Me.DefragRecommendedDataGridViewCheckBoxColumn.ReadOnly = true
'
'DefragResultDataGridViewTextBoxColumn
'
Me.DefragResultDataGridViewTextBoxColumn.DataPropertyName = "DefragResult"
Me.DefragResultDataGridViewTextBoxColumn.HeaderText = "DefragResult"
Me.DefragResultDataGridViewTextBoxColumn.Name = "DefragResultDataGridViewTextBoxColumn"
Me.DefragResultDataGridViewTextBoxColumn.ReadOnly = true
'
'DescriptionDataGridViewTextBoxColumn21
'
Me.DescriptionDataGridViewTextBoxColumn21.DataPropertyName = "Description"
Me.DescriptionDataGridViewTextBoxColumn21.HeaderText = "Description"
Me.DescriptionDataGridViewTextBoxColumn21.Name = "DescriptionDataGridViewTextBoxColumn21"
Me.DescriptionDataGridViewTextBoxColumn21.ReadOnly = true
'
'DeviceID
'
Me.DeviceID.DataPropertyName = "DeviceID"
Me.DeviceID.HeaderText = "DeviceID"
Me.DeviceID.Name = "DeviceID"
Me.DeviceID.ReadOnly = true
'
'DirtyBitSetDataGridViewCheckBoxColumn
'
Me.DirtyBitSetDataGridViewCheckBoxColumn.DataPropertyName = "DirtyBitSet"
Me.DirtyBitSetDataGridViewCheckBoxColumn.HeaderText = "DirtyBitSet"
Me.DirtyBitSetDataGridViewCheckBoxColumn.Name = "DirtyBitSetDataGridViewCheckBoxColumn"
Me.DirtyBitSetDataGridViewCheckBoxColumn.ReadOnly = true
'
'DriveLetterDataGridViewTextBoxColumn
'
Me.DriveLetterDataGridViewTextBoxColumn.DataPropertyName = "DriveLetter"
Me.DriveLetterDataGridViewTextBoxColumn.HeaderText = "DriveLetter"
Me.DriveLetterDataGridViewTextBoxColumn.Name = "DriveLetterDataGridViewTextBoxColumn"
Me.DriveLetterDataGridViewTextBoxColumn.ReadOnly = true
'
'DriveTypeDataGridViewTextBoxColumn
'
Me.DriveTypeDataGridViewTextBoxColumn.DataPropertyName = "DriveType"
Me.DriveTypeDataGridViewTextBoxColumn.HeaderText = "DriveType"
Me.DriveTypeDataGridViewTextBoxColumn.Name = "DriveTypeDataGridViewTextBoxColumn"
Me.DriveTypeDataGridViewTextBoxColumn.ReadOnly = true
'
'ErrorClearedDataGridViewCheckBoxColumn10
'
Me.ErrorClearedDataGridViewCheckBoxColumn10.DataPropertyName = "ErrorCleared"
Me.ErrorClearedDataGridViewCheckBoxColumn10.HeaderText = "ErrorCleared"
Me.ErrorClearedDataGridViewCheckBoxColumn10.Name = "ErrorClearedDataGridViewCheckBoxColumn10"
Me.ErrorClearedDataGridViewCheckBoxColumn10.ReadOnly = true
'
'ErrorDescriptionDataGridViewTextBoxColumn10
'
Me.ErrorDescriptionDataGridViewTextBoxColumn10.DataPropertyName = "ErrorDescription"
Me.ErrorDescriptionDataGridViewTextBoxColumn10.HeaderText = "ErrorDescription"
Me.ErrorDescriptionDataGridViewTextBoxColumn10.Name = "ErrorDescriptionDataGridViewTextBoxColumn10"
Me.ErrorDescriptionDataGridViewTextBoxColumn10.ReadOnly = true
'
'ErrorMethodologyDataGridViewTextBoxColumn2
'
Me.ErrorMethodologyDataGridViewTextBoxColumn2.DataPropertyName = "ErrorMethodology"
Me.ErrorMethodologyDataGridViewTextBoxColumn2.HeaderText = "ErrorMethodology"
Me.ErrorMethodologyDataGridViewTextBoxColumn2.Name = "ErrorMethodologyDataGridViewTextBoxColumn2"
Me.ErrorMethodologyDataGridViewTextBoxColumn2.ReadOnly = true
'
'FileSystemDataGridViewTextBoxColumn
'
Me.FileSystemDataGridViewTextBoxColumn.DataPropertyName = "FileSystem"
Me.FileSystemDataGridViewTextBoxColumn.HeaderText = "FileSystem"
Me.FileSystemDataGridViewTextBoxColumn.Name = "FileSystemDataGridViewTextBoxColumn"
Me.FileSystemDataGridViewTextBoxColumn.ReadOnly = true
'
'FreeSpaceDataGridViewTextBoxColumn
'
Me.FreeSpaceDataGridViewTextBoxColumn.DataPropertyName = "FreeSpace"
Me.FreeSpaceDataGridViewTextBoxColumn.HeaderText = "FreeSpace"
Me.FreeSpaceDataGridViewTextBoxColumn.Name = "FreeSpaceDataGridViewTextBoxColumn"
Me.FreeSpaceDataGridViewTextBoxColumn.ReadOnly = true
'
'IndexingEnabledDataGridViewCheckBoxColumn
'
Me.IndexingEnabledDataGridViewCheckBoxColumn.DataPropertyName = "IndexingEnabled"
Me.IndexingEnabledDataGridViewCheckBoxColumn.HeaderText = "IndexingEnabled"
Me.IndexingEnabledDataGridViewCheckBoxColumn.Name = "IndexingEnabledDataGridViewCheckBoxColumn"
Me.IndexingEnabledDataGridViewCheckBoxColumn.ReadOnly = true
'
'InstallDateDataGridViewTextBoxColumn19
'
Me.InstallDateDataGridViewTextBoxColumn19.DataPropertyName = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn19.HeaderText = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn19.Name = "InstallDateDataGridViewTextBoxColumn19"
Me.InstallDateDataGridViewTextBoxColumn19.ReadOnly = true
'
'LabelDataGridViewTextBoxColumn
'
Me.LabelDataGridViewTextBoxColumn.DataPropertyName = "Label"
Me.LabelDataGridViewTextBoxColumn.HeaderText = "Label"
Me.LabelDataGridViewTextBoxColumn.Name = "LabelDataGridViewTextBoxColumn"
Me.LabelDataGridViewTextBoxColumn.ReadOnly = true
'
'LastErrorCodeDataGridViewTextBoxColumn10
'
Me.LastErrorCodeDataGridViewTextBoxColumn10.DataPropertyName = "LastErrorCode"
Me.LastErrorCodeDataGridViewTextBoxColumn10.HeaderText = "LastErrorCode"
Me.LastErrorCodeDataGridViewTextBoxColumn10.Name = "LastErrorCodeDataGridViewTextBoxColumn10"
Me.LastErrorCodeDataGridViewTextBoxColumn10.ReadOnly = true
'
'MaximumFileNameLengthDataGridViewTextBoxColumn
'
Me.MaximumFileNameLengthDataGridViewTextBoxColumn.DataPropertyName = "MaximumFileNameLength"
Me.MaximumFileNameLengthDataGridViewTextBoxColumn.HeaderText = "MaximumFileNameLength"
Me.MaximumFileNameLengthDataGridViewTextBoxColumn.Name = "MaximumFileNameLengthDataGridViewTextBoxColumn"
Me.MaximumFileNameLengthDataGridViewTextBoxColumn.ReadOnly = true
'
'MediaTypeDataGridViewTextBoxColumn3
'
Me.MediaTypeDataGridViewTextBoxColumn3.DataPropertyName = "MediaType"
Me.MediaTypeDataGridViewTextBoxColumn3.HeaderText = "MediaType"
Me.MediaTypeDataGridViewTextBoxColumn3.Name = "MediaTypeDataGridViewTextBoxColumn3"
Me.MediaTypeDataGridViewTextBoxColumn3.ReadOnly = true
'
'NameDataGridViewTextBoxColumn19
'
Me.NameDataGridViewTextBoxColumn19.DataPropertyName = "Name"
Me.NameDataGridViewTextBoxColumn19.HeaderText = "Name"
Me.NameDataGridViewTextBoxColumn19.Name = "NameDataGridViewTextBoxColumn19"
Me.NameDataGridViewTextBoxColumn19.ReadOnly = true
'
'NumberOfBlocksDataGridViewTextBoxColumn
'
Me.NumberOfBlocksDataGridViewTextBoxColumn.DataPropertyName = "NumberOfBlocks"
Me.NumberOfBlocksDataGridViewTextBoxColumn.HeaderText = "NumberOfBlocks"
Me.NumberOfBlocksDataGridViewTextBoxColumn.Name = "NumberOfBlocksDataGridViewTextBoxColumn"
Me.NumberOfBlocksDataGridViewTextBoxColumn.ReadOnly = true
'
'PageFilePresentDataGridViewCheckBoxColumn
'
Me.PageFilePresentDataGridViewCheckBoxColumn.DataPropertyName = "PageFilePresent"
Me.PageFilePresentDataGridViewCheckBoxColumn.HeaderText = "PageFilePresent"
Me.PageFilePresentDataGridViewCheckBoxColumn.Name = "PageFilePresentDataGridViewCheckBoxColumn"
Me.PageFilePresentDataGridViewCheckBoxColumn.ReadOnly = true
'
'PNPDeviceIDDataGridViewTextBoxColumn10
'
Me.PNPDeviceIDDataGridViewTextBoxColumn10.DataPropertyName = "PNPDeviceID"
Me.PNPDeviceIDDataGridViewTextBoxColumn10.HeaderText = "PNPDeviceID"
Me.PNPDeviceIDDataGridViewTextBoxColumn10.Name = "PNPDeviceIDDataGridViewTextBoxColumn10"
Me.PNPDeviceIDDataGridViewTextBoxColumn10.ReadOnly = true
'
'PowerManagementSupportedDataGridViewCheckBoxColumn11
'
Me.PowerManagementSupportedDataGridViewCheckBoxColumn11.DataPropertyName = "PowerManagementSupported"
Me.PowerManagementSupportedDataGridViewCheckBoxColumn11.HeaderText = "PowerManagementSupported"
Me.PowerManagementSupportedDataGridViewCheckBoxColumn11.Name = "PowerManagementSupportedDataGridViewCheckBoxColumn11"
Me.PowerManagementSupportedDataGridViewCheckBoxColumn11.ReadOnly = true
'
'PurposeDataGridViewTextBoxColumn
'
Me.PurposeDataGridViewTextBoxColumn.DataPropertyName = "Purpose"
Me.PurposeDataGridViewTextBoxColumn.HeaderText = "Purpose"
Me.PurposeDataGridViewTextBoxColumn.Name = "PurposeDataGridViewTextBoxColumn"
Me.PurposeDataGridViewTextBoxColumn.ReadOnly = true
'
'QuotasEnabledDataGridViewCheckBoxColumn
'
Me.QuotasEnabledDataGridViewCheckBoxColumn.DataPropertyName = "QuotasEnabled"
Me.QuotasEnabledDataGridViewCheckBoxColumn.HeaderText = "QuotasEnabled"
Me.QuotasEnabledDataGridViewCheckBoxColumn.Name = "QuotasEnabledDataGridViewCheckBoxColumn"
Me.QuotasEnabledDataGridViewCheckBoxColumn.ReadOnly = true
'
'QuotasIncompleteDataGridViewCheckBoxColumn
'
Me.QuotasIncompleteDataGridViewCheckBoxColumn.DataPropertyName = "QuotasIncomplete"
Me.QuotasIncompleteDataGridViewCheckBoxColumn.HeaderText = "QuotasIncomplete"
Me.QuotasIncompleteDataGridViewCheckBoxColumn.Name = "QuotasIncompleteDataGridViewCheckBoxColumn"
Me.QuotasIncompleteDataGridViewCheckBoxColumn.ReadOnly = true
'
'QuotasRebuildingDataGridViewCheckBoxColumn
'
Me.QuotasRebuildingDataGridViewCheckBoxColumn.DataPropertyName = "QuotasRebuilding"
Me.QuotasRebuildingDataGridViewCheckBoxColumn.HeaderText = "QuotasRebuilding"
Me.QuotasRebuildingDataGridViewCheckBoxColumn.Name = "QuotasRebuildingDataGridViewCheckBoxColumn"
Me.QuotasRebuildingDataGridViewCheckBoxColumn.ReadOnly = true
'
'SerialNumberDataGridViewTextBoxColumn3
'
Me.SerialNumberDataGridViewTextBoxColumn3.DataPropertyName = "SerialNumber"
Me.SerialNumberDataGridViewTextBoxColumn3.HeaderText = "SerialNumber"
Me.SerialNumberDataGridViewTextBoxColumn3.Name = "SerialNumberDataGridViewTextBoxColumn3"
Me.SerialNumberDataGridViewTextBoxColumn3.ReadOnly = true
'
'StatusDataGridViewTextBoxColumn19
'
Me.StatusDataGridViewTextBoxColumn19.DataPropertyName = "Status"
Me.StatusDataGridViewTextBoxColumn19.HeaderText = "Status"
Me.StatusDataGridViewTextBoxColumn19.Name = "StatusDataGridViewTextBoxColumn19"
Me.StatusDataGridViewTextBoxColumn19.ReadOnly = true
'
'StatusInfoDataGridViewTextBoxColumn10
'
Me.StatusInfoDataGridViewTextBoxColumn10.DataPropertyName = "StatusInfo"
Me.StatusInfoDataGridViewTextBoxColumn10.HeaderText = "StatusInfo"
Me.StatusInfoDataGridViewTextBoxColumn10.Name = "StatusInfoDataGridViewTextBoxColumn10"
Me.StatusInfoDataGridViewTextBoxColumn10.ReadOnly = true
'
'SupportsDiskQuotasDataGridViewCheckBoxColumn
'
Me.SupportsDiskQuotasDataGridViewCheckBoxColumn.DataPropertyName = "SupportsDiskQuotas"
Me.SupportsDiskQuotasDataGridViewCheckBoxColumn.HeaderText = "SupportsDiskQuotas"
Me.SupportsDiskQuotasDataGridViewCheckBoxColumn.Name = "SupportsDiskQuotasDataGridViewCheckBoxColumn"
Me.SupportsDiskQuotasDataGridViewCheckBoxColumn.ReadOnly = true
'
'SupportsFileBasedCompressionDataGridViewCheckBoxColumn
'
Me.SupportsFileBasedCompressionDataGridViewCheckBoxColumn.DataPropertyName = "SupportsFileBasedCompression"
Me.SupportsFileBasedCompressionDataGridViewCheckBoxColumn.HeaderText = "SupportsFileBasedCompression"
Me.SupportsFileBasedCompressionDataGridViewCheckBoxColumn.Name = "SupportsFileBasedCompressionDataGridViewCheckBoxColumn"
Me.SupportsFileBasedCompressionDataGridViewCheckBoxColumn.ReadOnly = true
'
'SystemCreationClassNameDataGridViewTextBoxColumn13
'
Me.SystemCreationClassNameDataGridViewTextBoxColumn13.DataPropertyName = "SystemCreationClassName"
Me.SystemCreationClassNameDataGridViewTextBoxColumn13.HeaderText = "SystemCreationClassName"
Me.SystemCreationClassNameDataGridViewTextBoxColumn13.Name = "SystemCreationClassNameDataGridViewTextBoxColumn13"
Me.SystemCreationClassNameDataGridViewTextBoxColumn13.ReadOnly = true
'
'SystemVolumeDataGridViewCheckBoxColumn
'
Me.SystemVolumeDataGridViewCheckBoxColumn.DataPropertyName = "SystemVolume"
Me.SystemVolumeDataGridViewCheckBoxColumn.HeaderText = "SystemVolume"
Me.SystemVolumeDataGridViewCheckBoxColumn.Name = "SystemVolumeDataGridViewCheckBoxColumn"
Me.SystemVolumeDataGridViewCheckBoxColumn.ReadOnly = true
'
'SystemNameDataGridViewTextBoxColumn13
'
Me.SystemNameDataGridViewTextBoxColumn13.DataPropertyName = "SystemName"
Me.SystemNameDataGridViewTextBoxColumn13.HeaderText = "SystemName"
Me.SystemNameDataGridViewTextBoxColumn13.Name = "SystemNameDataGridViewTextBoxColumn13"
Me.SystemNameDataGridViewTextBoxColumn13.ReadOnly = true
'
'Win32VolumeBindingSource
'
Me.Win32VolumeBindingSource.DataSource = GetType(WMIwrapper.Win32_Volume)
'
'PanelPhysicalMemoryArray
'
Me.PanelPhysicalMemoryArray.Controls.Add(Me.dgvPhysicalMemoryArray)
Me.PanelPhysicalMemoryArray.Dock = System.Windows.Forms.DockStyle.Fill
Me.PanelPhysicalMemoryArray.Location = New System.Drawing.Point(0, 0)
Me.PanelPhysicalMemoryArray.Name = "PanelPhysicalMemoryArray"
Me.PanelPhysicalMemoryArray.Size = New System.Drawing.Size(468, 183)
Me.PanelPhysicalMemoryArray.TabIndex = 24
'
'dgvPhysicalMemoryArray
'
Me.dgvPhysicalMemoryArray.AllowUserToAddRows = false
Me.dgvPhysicalMemoryArray.AllowUserToDeleteRows = false
Me.dgvPhysicalMemoryArray.AutoGenerateColumns = false
Me.dgvPhysicalMemoryArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
Me.dgvPhysicalMemoryArray.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CaptionDataGridViewTextBoxColumn19, Me.CreationClassNameDataGridViewTextBoxColumn17, Me.DepthDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn20, Me.HeightDataGridViewTextBoxColumn, Me.HotSwappableDataGridViewCheckBoxColumn3, Me.InstallDateDataGridViewTextBoxColumn18, Me.LocationDataGridViewTextBoxColumn1, Me.MaxCapacityDataGridViewTextBoxColumn, Me.MemoryDevicesDataGridViewTextBoxColumn, Me.MemoryErrorCorrectionDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn18, Me.UseDataGridViewTextBoxColumn, Me.RemovableDataGridViewCheckBoxColumn3, Me.ReplaceableDataGridViewCheckBoxColumn3, Me.StatusDataGridViewTextBoxColumn18, Me.WeightDataGridViewTextBoxColumn, Me.WidthDataGridViewTextBoxColumn})
Me.dgvPhysicalMemoryArray.DataSource = Me.Win32PhysicalMemoryArrayBindingSource
Me.dgvPhysicalMemoryArray.Dock = System.Windows.Forms.DockStyle.Fill
Me.dgvPhysicalMemoryArray.Location = New System.Drawing.Point(0, 0)
Me.dgvPhysicalMemoryArray.Name = "dgvPhysicalMemoryArray"
Me.dgvPhysicalMemoryArray.ReadOnly = true
Me.dgvPhysicalMemoryArray.Size = New System.Drawing.Size(468, 183)
Me.dgvPhysicalMemoryArray.TabIndex = 22
'
'CaptionDataGridViewTextBoxColumn19
'
Me.CaptionDataGridViewTextBoxColumn19.DataPropertyName = "Caption"
Me.CaptionDataGridViewTextBoxColumn19.HeaderText = "Caption"
Me.CaptionDataGridViewTextBoxColumn19.Name = "CaptionDataGridViewTextBoxColumn19"
Me.CaptionDataGridViewTextBoxColumn19.ReadOnly = true
'
'CreationClassNameDataGridViewTextBoxColumn17
'
Me.CreationClassNameDataGridViewTextBoxColumn17.DataPropertyName = "CreationClassName"
Me.CreationClassNameDataGridViewTextBoxColumn17.HeaderText = "CreationClassName"
Me.CreationClassNameDataGridViewTextBoxColumn17.Name = "CreationClassNameDataGridViewTextBoxColumn17"
Me.CreationClassNameDataGridViewTextBoxColumn17.ReadOnly = true
'
'DepthDataGridViewTextBoxColumn
'
Me.DepthDataGridViewTextBoxColumn.DataPropertyName = "Depth"
Me.DepthDataGridViewTextBoxColumn.HeaderText = "Depth"
Me.DepthDataGridViewTextBoxColumn.Name = "DepthDataGridViewTextBoxColumn"
Me.DepthDataGridViewTextBoxColumn.ReadOnly = true
'
'DescriptionDataGridViewTextBoxColumn20
'
Me.DescriptionDataGridViewTextBoxColumn20.DataPropertyName = "Description"
Me.DescriptionDataGridViewTextBoxColumn20.HeaderText = "Description"
Me.DescriptionDataGridViewTextBoxColumn20.Name = "DescriptionDataGridViewTextBoxColumn20"
Me.DescriptionDataGridViewTextBoxColumn20.ReadOnly = true
'
'HeightDataGridViewTextBoxColumn
'
Me.HeightDataGridViewTextBoxColumn.DataPropertyName = "Height"
Me.HeightDataGridViewTextBoxColumn.HeaderText = "Height"
Me.HeightDataGridViewTextBoxColumn.Name = "HeightDataGridViewTextBoxColumn"
Me.HeightDataGridViewTextBoxColumn.ReadOnly = true
'
'HotSwappableDataGridViewCheckBoxColumn3
'
Me.HotSwappableDataGridViewCheckBoxColumn3.DataPropertyName = "HotSwappable"
Me.HotSwappableDataGridViewCheckBoxColumn3.HeaderText = "HotSwappable"
Me.HotSwappableDataGridViewCheckBoxColumn3.Name = "HotSwappableDataGridViewCheckBoxColumn3"
Me.HotSwappableDataGridViewCheckBoxColumn3.ReadOnly = true
'
'InstallDateDataGridViewTextBoxColumn18
'
Me.InstallDateDataGridViewTextBoxColumn18.DataPropertyName = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn18.HeaderText = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn18.Name = "InstallDateDataGridViewTextBoxColumn18"
Me.InstallDateDataGridViewTextBoxColumn18.ReadOnly = true
'
'LocationDataGridViewTextBoxColumn1
'
Me.LocationDataGridViewTextBoxColumn1.DataPropertyName = "Location"
Me.LocationDataGridViewTextBoxColumn1.HeaderText = "Location"
Me.LocationDataGridViewTextBoxColumn1.Name = "LocationDataGridViewTextBoxColumn1"
Me.LocationDataGridViewTextBoxColumn1.ReadOnly = true
'
'MaxCapacityDataGridViewTextBoxColumn
'
Me.MaxCapacityDataGridViewTextBoxColumn.DataPropertyName = "MaxCapacity"
Me.MaxCapacityDataGridViewTextBoxColumn.HeaderText = "MaxCapacity"
Me.MaxCapacityDataGridViewTextBoxColumn.Name = "MaxCapacityDataGridViewTextBoxColumn"
Me.MaxCapacityDataGridViewTextBoxColumn.ReadOnly = true
'
'MemoryDevicesDataGridViewTextBoxColumn
'
Me.MemoryDevicesDataGridViewTextBoxColumn.DataPropertyName = "MemoryDevices"
Me.MemoryDevicesDataGridViewTextBoxColumn.HeaderText = "MemoryDevices"
Me.MemoryDevicesDataGridViewTextBoxColumn.Name = "MemoryDevicesDataGridViewTextBoxColumn"
Me.MemoryDevicesDataGridViewTextBoxColumn.ReadOnly = true
'
'MemoryErrorCorrectionDataGridViewTextBoxColumn
'
Me.MemoryErrorCorrectionDataGridViewTextBoxColumn.DataPropertyName = "MemoryErrorCorrection"
Me.MemoryErrorCorrectionDataGridViewTextBoxColumn.HeaderText = "MemoryErrorCorrection"
Me.MemoryErrorCorrectionDataGridViewTextBoxColumn.Name = "MemoryErrorCorrectionDataGridViewTextBoxColumn"
Me.MemoryErrorCorrectionDataGridViewTextBoxColumn.ReadOnly = true
'
'NameDataGridViewTextBoxColumn18
'
Me.NameDataGridViewTextBoxColumn18.DataPropertyName = "Name"
Me.NameDataGridViewTextBoxColumn18.HeaderText = "Name"
Me.NameDataGridViewTextBoxColumn18.Name = "NameDataGridViewTextBoxColumn18"
Me.NameDataGridViewTextBoxColumn18.ReadOnly = true
'
'UseDataGridViewTextBoxColumn
'
Me.UseDataGridViewTextBoxColumn.DataPropertyName = "Use"
Me.UseDataGridViewTextBoxColumn.HeaderText = "Use"
Me.UseDataGridViewTextBoxColumn.Name = "UseDataGridViewTextBoxColumn"
Me.UseDataGridViewTextBoxColumn.ReadOnly = true
'
'RemovableDataGridViewCheckBoxColumn3
'
Me.RemovableDataGridViewCheckBoxColumn3.DataPropertyName = "Removable"
Me.RemovableDataGridViewCheckBoxColumn3.HeaderText = "Removable"
Me.RemovableDataGridViewCheckBoxColumn3.Name = "RemovableDataGridViewCheckBoxColumn3"
Me.RemovableDataGridViewCheckBoxColumn3.ReadOnly = true
'
'ReplaceableDataGridViewCheckBoxColumn3
'
Me.ReplaceableDataGridViewCheckBoxColumn3.DataPropertyName = "Replaceable"
Me.ReplaceableDataGridViewCheckBoxColumn3.HeaderText = "Replaceable"
Me.ReplaceableDataGridViewCheckBoxColumn3.Name = "ReplaceableDataGridViewCheckBoxColumn3"
Me.ReplaceableDataGridViewCheckBoxColumn3.ReadOnly = true
'
'StatusDataGridViewTextBoxColumn18
'
Me.StatusDataGridViewTextBoxColumn18.DataPropertyName = "Status"
Me.StatusDataGridViewTextBoxColumn18.HeaderText = "Status"
Me.StatusDataGridViewTextBoxColumn18.Name = "StatusDataGridViewTextBoxColumn18"
Me.StatusDataGridViewTextBoxColumn18.ReadOnly = true
'
'WeightDataGridViewTextBoxColumn
'
Me.WeightDataGridViewTextBoxColumn.DataPropertyName = "Weight"
Me.WeightDataGridViewTextBoxColumn.HeaderText = "Weight"
Me.WeightDataGridViewTextBoxColumn.Name = "WeightDataGridViewTextBoxColumn"
Me.WeightDataGridViewTextBoxColumn.ReadOnly = true
'
'WidthDataGridViewTextBoxColumn
'
Me.WidthDataGridViewTextBoxColumn.DataPropertyName = "Width"
Me.WidthDataGridViewTextBoxColumn.HeaderText = "Width"
Me.WidthDataGridViewTextBoxColumn.Name = "WidthDataGridViewTextBoxColumn"
Me.WidthDataGridViewTextBoxColumn.ReadOnly = true
'
'Win32PhysicalMemoryArrayBindingSource
'
Me.Win32PhysicalMemoryArrayBindingSource.DataSource = GetType(WMIwrapper.Win32_PhysicalMemoryArray)
'
'PanelOnBoardDevices
'
Me.PanelOnBoardDevices.Controls.Add(Me.dgvOnBoardDevices)
Me.PanelOnBoardDevices.Dock = System.Windows.Forms.DockStyle.Fill
Me.PanelOnBoardDevices.Location = New System.Drawing.Point(0, 0)
Me.PanelOnBoardDevices.Name = "PanelOnBoardDevices"
Me.PanelOnBoardDevices.Size = New System.Drawing.Size(468, 183)
Me.PanelOnBoardDevices.TabIndex = 23
'
'dgvOnBoardDevices
'
Me.dgvOnBoardDevices.AllowUserToAddRows = false
Me.dgvOnBoardDevices.AllowUserToDeleteRows = false
Me.dgvOnBoardDevices.AutoGenerateColumns = false
Me.dgvOnBoardDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
Me.dgvOnBoardDevices.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CaptionDataGridViewTextBoxColumn18, Me.CreationClassNameDataGridViewTextBoxColumn16, Me.DescriptionDataGridViewTextBoxColumn19, Me.DeviceTypeDataGridViewTextBoxColumn, Me.EnabledDataGridViewCheckBoxColumn, Me.HotSwappableDataGridViewCheckBoxColumn2, Me.InstallDateDataGridViewTextBoxColumn17, Me.NameDataGridViewTextBoxColumn17, Me.RemovableDataGridViewCheckBoxColumn2, Me.ReplaceableDataGridViewCheckBoxColumn2, Me.StatusDataGridViewTextBoxColumn17})
Me.dgvOnBoardDevices.DataSource = Me.Win32OnBoardDeviceBindingSource
Me.dgvOnBoardDevices.Dock = System.Windows.Forms.DockStyle.Fill
Me.dgvOnBoardDevices.Location = New System.Drawing.Point(0, 0)
Me.dgvOnBoardDevices.Name = "dgvOnBoardDevices"
Me.dgvOnBoardDevices.ReadOnly = true
Me.dgvOnBoardDevices.Size = New System.Drawing.Size(468, 183)
Me.dgvOnBoardDevices.TabIndex = 22
'
'CaptionDataGridViewTextBoxColumn18
'
Me.CaptionDataGridViewTextBoxColumn18.DataPropertyName = "Caption"
Me.CaptionDataGridViewTextBoxColumn18.HeaderText = "Caption"
Me.CaptionDataGridViewTextBoxColumn18.Name = "CaptionDataGridViewTextBoxColumn18"
Me.CaptionDataGridViewTextBoxColumn18.ReadOnly = true
'
'CreationClassNameDataGridViewTextBoxColumn16
'
Me.CreationClassNameDataGridViewTextBoxColumn16.DataPropertyName = "CreationClassName"
Me.CreationClassNameDataGridViewTextBoxColumn16.HeaderText = "CreationClassName"
Me.CreationClassNameDataGridViewTextBoxColumn16.Name = "CreationClassNameDataGridViewTextBoxColumn16"
Me.CreationClassNameDataGridViewTextBoxColumn16.ReadOnly = true
'
'DescriptionDataGridViewTextBoxColumn19
'
Me.DescriptionDataGridViewTextBoxColumn19.DataPropertyName = "Description"
Me.DescriptionDataGridViewTextBoxColumn19.HeaderText = "Description"
Me.DescriptionDataGridViewTextBoxColumn19.Name = "DescriptionDataGridViewTextBoxColumn19"
Me.DescriptionDataGridViewTextBoxColumn19.ReadOnly = true
'
'DeviceTypeDataGridViewTextBoxColumn
'
Me.DeviceTypeDataGridViewTextBoxColumn.DataPropertyName = "DeviceType"
Me.DeviceTypeDataGridViewTextBoxColumn.HeaderText = "DeviceType"
Me.DeviceTypeDataGridViewTextBoxColumn.Name = "DeviceTypeDataGridViewTextBoxColumn"
Me.DeviceTypeDataGridViewTextBoxColumn.ReadOnly = true
'
'EnabledDataGridViewCheckBoxColumn
'
Me.EnabledDataGridViewCheckBoxColumn.DataPropertyName = "Enabled"
Me.EnabledDataGridViewCheckBoxColumn.HeaderText = "Enabled"
Me.EnabledDataGridViewCheckBoxColumn.Name = "EnabledDataGridViewCheckBoxColumn"
Me.EnabledDataGridViewCheckBoxColumn.ReadOnly = true
'
'HotSwappableDataGridViewCheckBoxColumn2
'
Me.HotSwappableDataGridViewCheckBoxColumn2.DataPropertyName = "HotSwappable"
Me.HotSwappableDataGridViewCheckBoxColumn2.HeaderText = "HotSwappable"
Me.HotSwappableDataGridViewCheckBoxColumn2.Name = "HotSwappableDataGridViewCheckBoxColumn2"
Me.HotSwappableDataGridViewCheckBoxColumn2.ReadOnly = true
'
'InstallDateDataGridViewTextBoxColumn17
'
Me.InstallDateDataGridViewTextBoxColumn17.DataPropertyName = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn17.HeaderText = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn17.Name = "InstallDateDataGridViewTextBoxColumn17"
Me.InstallDateDataGridViewTextBoxColumn17.ReadOnly = true
'
'NameDataGridViewTextBoxColumn17
'
Me.NameDataGridViewTextBoxColumn17.DataPropertyName = "Name"
Me.NameDataGridViewTextBoxColumn17.HeaderText = "Name"
Me.NameDataGridViewTextBoxColumn17.Name = "NameDataGridViewTextBoxColumn17"
Me.NameDataGridViewTextBoxColumn17.ReadOnly = true
'
'RemovableDataGridViewCheckBoxColumn2
'
Me.RemovableDataGridViewCheckBoxColumn2.DataPropertyName = "Removable"
Me.RemovableDataGridViewCheckBoxColumn2.HeaderText = "Removable"
Me.RemovableDataGridViewCheckBoxColumn2.Name = "RemovableDataGridViewCheckBoxColumn2"
Me.RemovableDataGridViewCheckBoxColumn2.ReadOnly = true
'
'ReplaceableDataGridViewCheckBoxColumn2
'
Me.ReplaceableDataGridViewCheckBoxColumn2.DataPropertyName = "Replaceable"
Me.ReplaceableDataGridViewCheckBoxColumn2.HeaderText = "Replaceable"
Me.ReplaceableDataGridViewCheckBoxColumn2.Name = "ReplaceableDataGridViewCheckBoxColumn2"
Me.ReplaceableDataGridViewCheckBoxColumn2.ReadOnly = true
'
'StatusDataGridViewTextBoxColumn17
'
Me.StatusDataGridViewTextBoxColumn17.DataPropertyName = "Status"
Me.StatusDataGridViewTextBoxColumn17.HeaderText = "Status"
Me.StatusDataGridViewTextBoxColumn17.Name = "StatusDataGridViewTextBoxColumn17"
Me.StatusDataGridViewTextBoxColumn17.ReadOnly = true
'
'Win32OnBoardDeviceBindingSource
'
Me.Win32OnBoardDeviceBindingSource.DataSource = GetType(WMIwrapper.Win32_OnBoardDevice)
'
'PanelPhysicalMemory
'
Me.PanelPhysicalMemory.Controls.Add(Me.dgvPhysicalMemory)
Me.PanelPhysicalMemory.Dock = System.Windows.Forms.DockStyle.Fill
Me.PanelPhysicalMemory.Location = New System.Drawing.Point(0, 0)
Me.PanelPhysicalMemory.Name = "PanelPhysicalMemory"
Me.PanelPhysicalMemory.Size = New System.Drawing.Size(468, 183)
Me.PanelPhysicalMemory.TabIndex = 22
'
'dgvPhysicalMemory
'
Me.dgvPhysicalMemory.AllowUserToAddRows = false
Me.dgvPhysicalMemory.AllowUserToDeleteRows = false
Me.dgvPhysicalMemory.AutoGenerateColumns = false
Me.dgvPhysicalMemory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
Me.dgvPhysicalMemory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BankLabelDataGridViewTextBoxColumn, Me.CapacityDataGridViewTextBoxColumn1, Me.CaptionDataGridViewTextBoxColumn17, Me.CreationClassNameDataGridViewTextBoxColumn15, Me.DataWidthDataGridViewTextBoxColumn1, Me.DescriptionDataGridViewTextBoxColumn18, Me.DeviceLocatorDataGridViewTextBoxColumn, Me.FormFactorDataGridViewTextBoxColumn, Me.HotSwappableDataGridViewCheckBoxColumn1, Me.InstallDateDataGridViewTextBoxColumn16, Me.InterleaveDataDepthDataGridViewTextBoxColumn, Me.InterleavePositionDataGridViewTextBoxColumn, Me.MemoryTypeDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn16, Me.PositionInRowDataGridViewTextBoxColumn, Me.RemovableDataGridViewCheckBoxColumn1, Me.ReplaceableDataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn22, Me.StatusDataGridViewTextBoxColumn16, Me.TotalWidthDataGridViewTextBoxColumn, Me.TypeDetailDataGridViewTextBoxColumn})
Me.dgvPhysicalMemory.DataSource = Me.Win32PhysicalMemoryBindingSource
Me.dgvPhysicalMemory.Dock = System.Windows.Forms.DockStyle.Fill
Me.dgvPhysicalMemory.Location = New System.Drawing.Point(0, 0)
Me.dgvPhysicalMemory.Name = "dgvPhysicalMemory"
Me.dgvPhysicalMemory.ReadOnly = true
Me.dgvPhysicalMemory.Size = New System.Drawing.Size(468, 183)
Me.dgvPhysicalMemory.TabIndex = 22
'
'BankLabelDataGridViewTextBoxColumn
'
Me.BankLabelDataGridViewTextBoxColumn.DataPropertyName = "BankLabel"
Me.BankLabelDataGridViewTextBoxColumn.HeaderText = "BankLabel"
Me.BankLabelDataGridViewTextBoxColumn.Name = "BankLabelDataGridViewTextBoxColumn"
Me.BankLabelDataGridViewTextBoxColumn.ReadOnly = true
'
'CapacityDataGridViewTextBoxColumn1
'
Me.CapacityDataGridViewTextBoxColumn1.DataPropertyName = "Capacity"
Me.CapacityDataGridViewTextBoxColumn1.HeaderText = "Capacity"
Me.CapacityDataGridViewTextBoxColumn1.Name = "CapacityDataGridViewTextBoxColumn1"
Me.CapacityDataGridViewTextBoxColumn1.ReadOnly = true
'
'CaptionDataGridViewTextBoxColumn17
'
Me.CaptionDataGridViewTextBoxColumn17.DataPropertyName = "Caption"
Me.CaptionDataGridViewTextBoxColumn17.HeaderText = "Caption"
Me.CaptionDataGridViewTextBoxColumn17.Name = "CaptionDataGridViewTextBoxColumn17"
Me.CaptionDataGridViewTextBoxColumn17.ReadOnly = true
'
'CreationClassNameDataGridViewTextBoxColumn15
'
Me.CreationClassNameDataGridViewTextBoxColumn15.DataPropertyName = "CreationClassName"
Me.CreationClassNameDataGridViewTextBoxColumn15.HeaderText = "CreationClassName"
Me.CreationClassNameDataGridViewTextBoxColumn15.Name = "CreationClassNameDataGridViewTextBoxColumn15"
Me.CreationClassNameDataGridViewTextBoxColumn15.ReadOnly = true
'
'DataWidthDataGridViewTextBoxColumn1
'
Me.DataWidthDataGridViewTextBoxColumn1.DataPropertyName = "DataWidth"
Me.DataWidthDataGridViewTextBoxColumn1.HeaderText = "DataWidth"
Me.DataWidthDataGridViewTextBoxColumn1.Name = "DataWidthDataGridViewTextBoxColumn1"
Me.DataWidthDataGridViewTextBoxColumn1.ReadOnly = true
'
'DescriptionDataGridViewTextBoxColumn18
'
Me.DescriptionDataGridViewTextBoxColumn18.DataPropertyName = "Description"
Me.DescriptionDataGridViewTextBoxColumn18.HeaderText = "Description"
Me.DescriptionDataGridViewTextBoxColumn18.Name = "DescriptionDataGridViewTextBoxColumn18"
Me.DescriptionDataGridViewTextBoxColumn18.ReadOnly = true
'
'DeviceLocatorDataGridViewTextBoxColumn
'
Me.DeviceLocatorDataGridViewTextBoxColumn.DataPropertyName = "DeviceLocator"
Me.DeviceLocatorDataGridViewTextBoxColumn.HeaderText = "DeviceLocator"
Me.DeviceLocatorDataGridViewTextBoxColumn.Name = "DeviceLocatorDataGridViewTextBoxColumn"
Me.DeviceLocatorDataGridViewTextBoxColumn.ReadOnly = true
'
'FormFactorDataGridViewTextBoxColumn
'
Me.FormFactorDataGridViewTextBoxColumn.DataPropertyName = "FormFactor"
Me.FormFactorDataGridViewTextBoxColumn.HeaderText = "FormFactor"
Me.FormFactorDataGridViewTextBoxColumn.Name = "FormFactorDataGridViewTextBoxColumn"
Me.FormFactorDataGridViewTextBoxColumn.ReadOnly = true
'
'HotSwappableDataGridViewCheckBoxColumn1
'
Me.HotSwappableDataGridViewCheckBoxColumn1.DataPropertyName = "HotSwappable"
Me.HotSwappableDataGridViewCheckBoxColumn1.HeaderText = "HotSwappable"
Me.HotSwappableDataGridViewCheckBoxColumn1.Name = "HotSwappableDataGridViewCheckBoxColumn1"
Me.HotSwappableDataGridViewCheckBoxColumn1.ReadOnly = true
'
'InstallDateDataGridViewTextBoxColumn16
'
Me.InstallDateDataGridViewTextBoxColumn16.DataPropertyName = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn16.HeaderText = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn16.Name = "InstallDateDataGridViewTextBoxColumn16"
Me.InstallDateDataGridViewTextBoxColumn16.ReadOnly = true
'
'InterleaveDataDepthDataGridViewTextBoxColumn
'
Me.InterleaveDataDepthDataGridViewTextBoxColumn.DataPropertyName = "InterleaveDataDepth"
Me.InterleaveDataDepthDataGridViewTextBoxColumn.HeaderText = "InterleaveDataDepth"
Me.InterleaveDataDepthDataGridViewTextBoxColumn.Name = "InterleaveDataDepthDataGridViewTextBoxColumn"
Me.InterleaveDataDepthDataGridViewTextBoxColumn.ReadOnly = true
'
'InterleavePositionDataGridViewTextBoxColumn
'
Me.InterleavePositionDataGridViewTextBoxColumn.DataPropertyName = "InterleavePosition"
Me.InterleavePositionDataGridViewTextBoxColumn.HeaderText = "InterleavePosition"
Me.InterleavePositionDataGridViewTextBoxColumn.Name = "InterleavePositionDataGridViewTextBoxColumn"
Me.InterleavePositionDataGridViewTextBoxColumn.ReadOnly = true
'
'MemoryTypeDataGridViewTextBoxColumn
'
Me.MemoryTypeDataGridViewTextBoxColumn.DataPropertyName = "MemoryType"
Me.MemoryTypeDataGridViewTextBoxColumn.HeaderText = "MemoryType"
Me.MemoryTypeDataGridViewTextBoxColumn.Name = "MemoryTypeDataGridViewTextBoxColumn"
Me.MemoryTypeDataGridViewTextBoxColumn.ReadOnly = true
'
'NameDataGridViewTextBoxColumn16
'
Me.NameDataGridViewTextBoxColumn16.DataPropertyName = "Name"
Me.NameDataGridViewTextBoxColumn16.HeaderText = "Name"
Me.NameDataGridViewTextBoxColumn16.Name = "NameDataGridViewTextBoxColumn16"
Me.NameDataGridViewTextBoxColumn16.ReadOnly = true
'
'PositionInRowDataGridViewTextBoxColumn
'
Me.PositionInRowDataGridViewTextBoxColumn.DataPropertyName = "PositionInRow"
Me.PositionInRowDataGridViewTextBoxColumn.HeaderText = "PositionInRow"
Me.PositionInRowDataGridViewTextBoxColumn.Name = "PositionInRowDataGridViewTextBoxColumn"
Me.PositionInRowDataGridViewTextBoxColumn.ReadOnly = true
'
'RemovableDataGridViewCheckBoxColumn1
'
Me.RemovableDataGridViewCheckBoxColumn1.DataPropertyName = "Removable"
Me.RemovableDataGridViewCheckBoxColumn1.HeaderText = "Removable"
Me.RemovableDataGridViewCheckBoxColumn1.Name = "RemovableDataGridViewCheckBoxColumn1"
Me.RemovableDataGridViewCheckBoxColumn1.ReadOnly = true
'
'ReplaceableDataGridViewCheckBoxColumn1
'
Me.ReplaceableDataGridViewCheckBoxColumn1.DataPropertyName = "Replaceable"
Me.ReplaceableDataGridViewCheckBoxColumn1.HeaderText = "Replaceable"
Me.ReplaceableDataGridViewCheckBoxColumn1.Name = "ReplaceableDataGridViewCheckBoxColumn1"
Me.ReplaceableDataGridViewCheckBoxColumn1.ReadOnly = true
'
'DataGridViewTextBoxColumn22
'
Me.DataGridViewTextBoxColumn22.DataPropertyName = "Speed"
Me.DataGridViewTextBoxColumn22.HeaderText = "Speed"
Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
Me.DataGridViewTextBoxColumn22.ReadOnly = true
'
'StatusDataGridViewTextBoxColumn16
'
Me.StatusDataGridViewTextBoxColumn16.DataPropertyName = "Status"
Me.StatusDataGridViewTextBoxColumn16.HeaderText = "Status"
Me.StatusDataGridViewTextBoxColumn16.Name = "StatusDataGridViewTextBoxColumn16"
Me.StatusDataGridViewTextBoxColumn16.ReadOnly = true
'
'TotalWidthDataGridViewTextBoxColumn
'
Me.TotalWidthDataGridViewTextBoxColumn.DataPropertyName = "TotalWidth"
Me.TotalWidthDataGridViewTextBoxColumn.HeaderText = "TotalWidth"
Me.TotalWidthDataGridViewTextBoxColumn.Name = "TotalWidthDataGridViewTextBoxColumn"
Me.TotalWidthDataGridViewTextBoxColumn.ReadOnly = true
'
'TypeDetailDataGridViewTextBoxColumn
'
Me.TypeDetailDataGridViewTextBoxColumn.DataPropertyName = "TypeDetail"
Me.TypeDetailDataGridViewTextBoxColumn.HeaderText = "TypeDetail"
Me.TypeDetailDataGridViewTextBoxColumn.Name = "TypeDetailDataGridViewTextBoxColumn"
Me.TypeDetailDataGridViewTextBoxColumn.ReadOnly = true
'
'Win32PhysicalMemoryBindingSource
'
Me.Win32PhysicalMemoryBindingSource.DataSource = GetType(WMIwrapper.Win32_PhysicalMemory)
'
'PanelPointingDevices
'
Me.PanelPointingDevices.Controls.Add(Me.dgvPointingDevices)
Me.PanelPointingDevices.Dock = System.Windows.Forms.DockStyle.Fill
Me.PanelPointingDevices.Location = New System.Drawing.Point(0, 0)
Me.PanelPointingDevices.Name = "PanelPointingDevices"
Me.PanelPointingDevices.Size = New System.Drawing.Size(468, 183)
Me.PanelPointingDevices.TabIndex = 20
'
'dgvPointingDevices
'
Me.dgvPointingDevices.AllowUserToAddRows = false
Me.dgvPointingDevices.AllowUserToDeleteRows = false
Me.dgvPointingDevices.AutoGenerateColumns = false
Me.dgvPointingDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
Me.dgvPointingDevices.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LastErrorCodeDataGridViewTextBoxColumn9, Me.HardwareTypeDataGridViewTextBoxColumn, Me.SystemCreationClassNameDataGridViewTextBoxColumn11, Me.DeviceInterfaceDataGridViewTextBoxColumn, Me.QuadSpeedThresholdDataGridViewTextBoxColumn, Me.ErrorDescriptionDataGridViewTextBoxColumn9, Me.InstallDateDataGridViewTextBoxColumn14, Me.ResolutionDataGridViewTextBoxColumn, Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn9, Me.DoubleSpeedThresholdDataGridViewTextBoxColumn, Me.ManufacturerDataGridViewTextBoxColumn6, Me.StatusDataGridViewTextBoxColumn14, Me.NumberOfButtonsDataGridViewTextBoxColumn, Me.HandednessDataGridViewTextBoxColumn, Me.PointingTypeDataGridViewTextBoxColumn, Me.StatusInfoDataGridViewTextBoxColumn9, Me.SystemNameDataGridViewTextBoxColumn11, Me.PowerManagementSupportedDataGridViewCheckBoxColumn10, Me.CreationClassNameDataGridViewTextBoxColumn13, Me.IsLockedDataGridViewCheckBoxColumn1, Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn9, Me.DeviceIDDataGridViewTextBoxColumn10, Me.PNPDeviceIDDataGridViewTextBoxColumn9, Me.CaptionDataGridViewTextBoxColumn15, Me.InfSectionDataGridViewTextBoxColumn1, Me.SynchDataGridViewTextBoxColumn, Me.InfFileNameDataGridViewTextBoxColumn1, Me.ErrorClearedDataGridViewCheckBoxColumn9, Me.ConfigManagerErrorDataGridViewTextBoxColumn9, Me.ManagementObjectDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn16, Me.NameDataGridViewTextBoxColumn14, Me.AvailabilityDataGridViewTextBoxColumn9, Me.SampleRateDataGridViewTextBoxColumn})
Me.dgvPointingDevices.DataSource = Me.Win32PointingDeviceBindingSource
Me.dgvPointingDevices.Dock = System.Windows.Forms.DockStyle.Fill
Me.dgvPointingDevices.Location = New System.Drawing.Point(0, 0)
Me.dgvPointingDevices.Name = "dgvPointingDevices"
Me.dgvPointingDevices.ReadOnly = true
Me.dgvPointingDevices.Size = New System.Drawing.Size(468, 183)
Me.dgvPointingDevices.TabIndex = 22
'
'LastErrorCodeDataGridViewTextBoxColumn9
'
Me.LastErrorCodeDataGridViewTextBoxColumn9.DataPropertyName = "LastErrorCode"
Me.LastErrorCodeDataGridViewTextBoxColumn9.HeaderText = "LastErrorCode"
Me.LastErrorCodeDataGridViewTextBoxColumn9.Name = "LastErrorCodeDataGridViewTextBoxColumn9"
Me.LastErrorCodeDataGridViewTextBoxColumn9.ReadOnly = true
'
'HardwareTypeDataGridViewTextBoxColumn
'
Me.HardwareTypeDataGridViewTextBoxColumn.DataPropertyName = "HardwareType"
Me.HardwareTypeDataGridViewTextBoxColumn.HeaderText = "HardwareType"
Me.HardwareTypeDataGridViewTextBoxColumn.Name = "HardwareTypeDataGridViewTextBoxColumn"
Me.HardwareTypeDataGridViewTextBoxColumn.ReadOnly = true
'
'SystemCreationClassNameDataGridViewTextBoxColumn11
'
Me.SystemCreationClassNameDataGridViewTextBoxColumn11.DataPropertyName = "SystemCreationClassName"
Me.SystemCreationClassNameDataGridViewTextBoxColumn11.HeaderText = "SystemCreationClassName"
Me.SystemCreationClassNameDataGridViewTextBoxColumn11.Name = "SystemCreationClassNameDataGridViewTextBoxColumn11"
Me.SystemCreationClassNameDataGridViewTextBoxColumn11.ReadOnly = true
'
'DeviceInterfaceDataGridViewTextBoxColumn
'
Me.DeviceInterfaceDataGridViewTextBoxColumn.DataPropertyName = "DeviceInterface"
Me.DeviceInterfaceDataGridViewTextBoxColumn.HeaderText = "DeviceInterface"
Me.DeviceInterfaceDataGridViewTextBoxColumn.Name = "DeviceInterfaceDataGridViewTextBoxColumn"
Me.DeviceInterfaceDataGridViewTextBoxColumn.ReadOnly = true
'
'QuadSpeedThresholdDataGridViewTextBoxColumn
'
Me.QuadSpeedThresholdDataGridViewTextBoxColumn.DataPropertyName = "QuadSpeedThreshold"
Me.QuadSpeedThresholdDataGridViewTextBoxColumn.HeaderText = "QuadSpeedThreshold"
Me.QuadSpeedThresholdDataGridViewTextBoxColumn.Name = "QuadSpeedThresholdDataGridViewTextBoxColumn"
Me.QuadSpeedThresholdDataGridViewTextBoxColumn.ReadOnly = true
'
'ErrorDescriptionDataGridViewTextBoxColumn9
'
Me.ErrorDescriptionDataGridViewTextBoxColumn9.DataPropertyName = "ErrorDescription"
Me.ErrorDescriptionDataGridViewTextBoxColumn9.HeaderText = "ErrorDescription"
Me.ErrorDescriptionDataGridViewTextBoxColumn9.Name = "ErrorDescriptionDataGridViewTextBoxColumn9"
Me.ErrorDescriptionDataGridViewTextBoxColumn9.ReadOnly = true
'
'InstallDateDataGridViewTextBoxColumn14
'
Me.InstallDateDataGridViewTextBoxColumn14.DataPropertyName = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn14.HeaderText = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn14.Name = "InstallDateDataGridViewTextBoxColumn14"
Me.InstallDateDataGridViewTextBoxColumn14.ReadOnly = true
'
'ResolutionDataGridViewTextBoxColumn
'
Me.ResolutionDataGridViewTextBoxColumn.DataPropertyName = "Resolution"
Me.ResolutionDataGridViewTextBoxColumn.HeaderText = "Resolution"
Me.ResolutionDataGridViewTextBoxColumn.Name = "ResolutionDataGridViewTextBoxColumn"
Me.ResolutionDataGridViewTextBoxColumn.ReadOnly = true
'
'ConfigManagerErrorCodeDataGridViewTextBoxColumn9
'
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn9.DataPropertyName = "ConfigManagerErrorCode"
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn9.HeaderText = "ConfigManagerErrorCode"
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn9.Name = "ConfigManagerErrorCodeDataGridViewTextBoxColumn9"
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn9.ReadOnly = true
'
'DoubleSpeedThresholdDataGridViewTextBoxColumn
'
Me.DoubleSpeedThresholdDataGridViewTextBoxColumn.DataPropertyName = "DoubleSpeedThreshold"
Me.DoubleSpeedThresholdDataGridViewTextBoxColumn.HeaderText = "DoubleSpeedThreshold"
Me.DoubleSpeedThresholdDataGridViewTextBoxColumn.Name = "DoubleSpeedThresholdDataGridViewTextBoxColumn"
Me.DoubleSpeedThresholdDataGridViewTextBoxColumn.ReadOnly = true
'
'ManufacturerDataGridViewTextBoxColumn6
'
Me.ManufacturerDataGridViewTextBoxColumn6.DataPropertyName = "Manufacturer"
Me.ManufacturerDataGridViewTextBoxColumn6.HeaderText = "Manufacturer"
Me.ManufacturerDataGridViewTextBoxColumn6.Name = "ManufacturerDataGridViewTextBoxColumn6"
Me.ManufacturerDataGridViewTextBoxColumn6.ReadOnly = true
'
'StatusDataGridViewTextBoxColumn14
'
Me.StatusDataGridViewTextBoxColumn14.DataPropertyName = "Status"
Me.StatusDataGridViewTextBoxColumn14.HeaderText = "Status"
Me.StatusDataGridViewTextBoxColumn14.Name = "StatusDataGridViewTextBoxColumn14"
Me.StatusDataGridViewTextBoxColumn14.ReadOnly = true
'
'NumberOfButtonsDataGridViewTextBoxColumn
'
Me.NumberOfButtonsDataGridViewTextBoxColumn.DataPropertyName = "NumberOfButtons"
Me.NumberOfButtonsDataGridViewTextBoxColumn.HeaderText = "NumberOfButtons"
Me.NumberOfButtonsDataGridViewTextBoxColumn.Name = "NumberOfButtonsDataGridViewTextBoxColumn"
Me.NumberOfButtonsDataGridViewTextBoxColumn.ReadOnly = true
'
'HandednessDataGridViewTextBoxColumn
'
Me.HandednessDataGridViewTextBoxColumn.DataPropertyName = "Handedness"
Me.HandednessDataGridViewTextBoxColumn.HeaderText = "Handedness"
Me.HandednessDataGridViewTextBoxColumn.Name = "HandednessDataGridViewTextBoxColumn"
Me.HandednessDataGridViewTextBoxColumn.ReadOnly = true
'
'PointingTypeDataGridViewTextBoxColumn
'
Me.PointingTypeDataGridViewTextBoxColumn.DataPropertyName = "PointingType"
Me.PointingTypeDataGridViewTextBoxColumn.HeaderText = "PointingType"
Me.PointingTypeDataGridViewTextBoxColumn.Name = "PointingTypeDataGridViewTextBoxColumn"
Me.PointingTypeDataGridViewTextBoxColumn.ReadOnly = true
'
'StatusInfoDataGridViewTextBoxColumn9
'
Me.StatusInfoDataGridViewTextBoxColumn9.DataPropertyName = "StatusInfo"
Me.StatusInfoDataGridViewTextBoxColumn9.HeaderText = "StatusInfo"
Me.StatusInfoDataGridViewTextBoxColumn9.Name = "StatusInfoDataGridViewTextBoxColumn9"
Me.StatusInfoDataGridViewTextBoxColumn9.ReadOnly = true
'
'SystemNameDataGridViewTextBoxColumn11
'
Me.SystemNameDataGridViewTextBoxColumn11.DataPropertyName = "SystemName"
Me.SystemNameDataGridViewTextBoxColumn11.HeaderText = "SystemName"
Me.SystemNameDataGridViewTextBoxColumn11.Name = "SystemNameDataGridViewTextBoxColumn11"
Me.SystemNameDataGridViewTextBoxColumn11.ReadOnly = true
'
'PowerManagementSupportedDataGridViewCheckBoxColumn10
'
Me.PowerManagementSupportedDataGridViewCheckBoxColumn10.DataPropertyName = "PowerManagementSupported"
Me.PowerManagementSupportedDataGridViewCheckBoxColumn10.HeaderText = "PowerManagementSupported"
Me.PowerManagementSupportedDataGridViewCheckBoxColumn10.Name = "PowerManagementSupportedDataGridViewCheckBoxColumn10"
Me.PowerManagementSupportedDataGridViewCheckBoxColumn10.ReadOnly = true
'
'CreationClassNameDataGridViewTextBoxColumn13
'
Me.CreationClassNameDataGridViewTextBoxColumn13.DataPropertyName = "CreationClassName"
Me.CreationClassNameDataGridViewTextBoxColumn13.HeaderText = "CreationClassName"
Me.CreationClassNameDataGridViewTextBoxColumn13.Name = "CreationClassNameDataGridViewTextBoxColumn13"
Me.CreationClassNameDataGridViewTextBoxColumn13.ReadOnly = true
'
'IsLockedDataGridViewCheckBoxColumn1
'
Me.IsLockedDataGridViewCheckBoxColumn1.DataPropertyName = "IsLocked"
Me.IsLockedDataGridViewCheckBoxColumn1.HeaderText = "IsLocked"
Me.IsLockedDataGridViewCheckBoxColumn1.Name = "IsLockedDataGridViewCheckBoxColumn1"
Me.IsLockedDataGridViewCheckBoxColumn1.ReadOnly = true
'
'ConfigManagerUserConfigDataGridViewCheckBoxColumn9
'
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn9.DataPropertyName = "ConfigManagerUserConfig"
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn9.HeaderText = "ConfigManagerUserConfig"
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn9.Name = "ConfigManagerUserConfigDataGridViewCheckBoxColumn9"
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn9.ReadOnly = true
'
'DeviceIDDataGridViewTextBoxColumn10
'
Me.DeviceIDDataGridViewTextBoxColumn10.DataPropertyName = "DeviceID"
Me.DeviceIDDataGridViewTextBoxColumn10.HeaderText = "DeviceID"
Me.DeviceIDDataGridViewTextBoxColumn10.Name = "DeviceIDDataGridViewTextBoxColumn10"
Me.DeviceIDDataGridViewTextBoxColumn10.ReadOnly = true
'
'PNPDeviceIDDataGridViewTextBoxColumn9
'
Me.PNPDeviceIDDataGridViewTextBoxColumn9.DataPropertyName = "PNPDeviceID"
Me.PNPDeviceIDDataGridViewTextBoxColumn9.HeaderText = "PNPDeviceID"
Me.PNPDeviceIDDataGridViewTextBoxColumn9.Name = "PNPDeviceIDDataGridViewTextBoxColumn9"
Me.PNPDeviceIDDataGridViewTextBoxColumn9.ReadOnly = true
'
'CaptionDataGridViewTextBoxColumn15
'
Me.CaptionDataGridViewTextBoxColumn15.DataPropertyName = "Caption"
Me.CaptionDataGridViewTextBoxColumn15.HeaderText = "Caption"
Me.CaptionDataGridViewTextBoxColumn15.Name = "CaptionDataGridViewTextBoxColumn15"
Me.CaptionDataGridViewTextBoxColumn15.ReadOnly = true
'
'InfSectionDataGridViewTextBoxColumn1
'
Me.InfSectionDataGridViewTextBoxColumn1.DataPropertyName = "InfSection"
Me.InfSectionDataGridViewTextBoxColumn1.HeaderText = "InfSection"
Me.InfSectionDataGridViewTextBoxColumn1.Name = "InfSectionDataGridViewTextBoxColumn1"
Me.InfSectionDataGridViewTextBoxColumn1.ReadOnly = true
'
'SynchDataGridViewTextBoxColumn
'
Me.SynchDataGridViewTextBoxColumn.DataPropertyName = "Synch"
Me.SynchDataGridViewTextBoxColumn.HeaderText = "Synch"
Me.SynchDataGridViewTextBoxColumn.Name = "SynchDataGridViewTextBoxColumn"
Me.SynchDataGridViewTextBoxColumn.ReadOnly = true
'
'InfFileNameDataGridViewTextBoxColumn1
'
Me.InfFileNameDataGridViewTextBoxColumn1.DataPropertyName = "InfFileName"
Me.InfFileNameDataGridViewTextBoxColumn1.HeaderText = "InfFileName"
Me.InfFileNameDataGridViewTextBoxColumn1.Name = "InfFileNameDataGridViewTextBoxColumn1"
Me.InfFileNameDataGridViewTextBoxColumn1.ReadOnly = true
'
'ErrorClearedDataGridViewCheckBoxColumn9
'
Me.ErrorClearedDataGridViewCheckBoxColumn9.DataPropertyName = "ErrorCleared"
Me.ErrorClearedDataGridViewCheckBoxColumn9.HeaderText = "ErrorCleared"
Me.ErrorClearedDataGridViewCheckBoxColumn9.Name = "ErrorClearedDataGridViewCheckBoxColumn9"
Me.ErrorClearedDataGridViewCheckBoxColumn9.ReadOnly = true
'
'ConfigManagerErrorDataGridViewTextBoxColumn9
'
Me.ConfigManagerErrorDataGridViewTextBoxColumn9.DataPropertyName = "ConfigManagerError"
Me.ConfigManagerErrorDataGridViewTextBoxColumn9.HeaderText = "ConfigManagerError"
Me.ConfigManagerErrorDataGridViewTextBoxColumn9.Name = "ConfigManagerErrorDataGridViewTextBoxColumn9"
Me.ConfigManagerErrorDataGridViewTextBoxColumn9.ReadOnly = true
'
'ManagementObjectDataGridViewTextBoxColumn
'
Me.ManagementObjectDataGridViewTextBoxColumn.DataPropertyName = "ManagementObject"
Me.ManagementObjectDataGridViewTextBoxColumn.HeaderText = "ManagementObject"
Me.ManagementObjectDataGridViewTextBoxColumn.Name = "ManagementObjectDataGridViewTextBoxColumn"
Me.ManagementObjectDataGridViewTextBoxColumn.ReadOnly = true
'
'DescriptionDataGridViewTextBoxColumn16
'
Me.DescriptionDataGridViewTextBoxColumn16.DataPropertyName = "Description"
Me.DescriptionDataGridViewTextBoxColumn16.HeaderText = "Description"
Me.DescriptionDataGridViewTextBoxColumn16.Name = "DescriptionDataGridViewTextBoxColumn16"
Me.DescriptionDataGridViewTextBoxColumn16.ReadOnly = true
'
'NameDataGridViewTextBoxColumn14
'
Me.NameDataGridViewTextBoxColumn14.DataPropertyName = "Name"
Me.NameDataGridViewTextBoxColumn14.HeaderText = "Name"
Me.NameDataGridViewTextBoxColumn14.Name = "NameDataGridViewTextBoxColumn14"
Me.NameDataGridViewTextBoxColumn14.ReadOnly = true
'
'AvailabilityDataGridViewTextBoxColumn9
'
Me.AvailabilityDataGridViewTextBoxColumn9.DataPropertyName = "Availability"
Me.AvailabilityDataGridViewTextBoxColumn9.HeaderText = "Availability"
Me.AvailabilityDataGridViewTextBoxColumn9.Name = "AvailabilityDataGridViewTextBoxColumn9"
Me.AvailabilityDataGridViewTextBoxColumn9.ReadOnly = true
'
'SampleRateDataGridViewTextBoxColumn
'
Me.SampleRateDataGridViewTextBoxColumn.DataPropertyName = "SampleRate"
Me.SampleRateDataGridViewTextBoxColumn.HeaderText = "SampleRate"
Me.SampleRateDataGridViewTextBoxColumn.Name = "SampleRateDataGridViewTextBoxColumn"
Me.SampleRateDataGridViewTextBoxColumn.ReadOnly = true
'
'Win32PointingDeviceBindingSource
'
Me.Win32PointingDeviceBindingSource.DataSource = GetType(WMIwrapper.Win32_PointingDevice)
'
'PanelDesktopMonitors
'
Me.PanelDesktopMonitors.Controls.Add(Me.dgvDesktopMonitors)
Me.PanelDesktopMonitors.Dock = System.Windows.Forms.DockStyle.Fill
Me.PanelDesktopMonitors.Location = New System.Drawing.Point(0, 0)
Me.PanelDesktopMonitors.Name = "PanelDesktopMonitors"
Me.PanelDesktopMonitors.Size = New System.Drawing.Size(468, 183)
Me.PanelDesktopMonitors.TabIndex = 19
'
'dgvDesktopMonitors
'
Me.dgvDesktopMonitors.AllowUserToAddRows = false
Me.dgvDesktopMonitors.AllowUserToDeleteRows = false
Me.dgvDesktopMonitors.AutoGenerateColumns = false
Me.dgvDesktopMonitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
Me.dgvDesktopMonitors.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AvailabilityDataGridViewTextBoxColumn8, Me.BandwidthDataGridViewTextBoxColumn, Me.CaptionDataGridViewTextBoxColumn14, Me.ConfigManagerErrorDataGridViewTextBoxColumn8, Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn8, Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn8, Me.CreationClassNameDataGridViewTextBoxColumn12, Me.DescriptionDataGridViewTextBoxColumn15, Me.DeviceIDDataGridViewTextBoxColumn9, Me.DisplayTypeDataGridViewTextBoxColumn, Me.ErrorClearedDataGridViewCheckBoxColumn8, Me.ErrorDescriptionDataGridViewTextBoxColumn8, Me.InstallDateDataGridViewTextBoxColumn13, Me.IsLockedDataGridViewCheckBoxColumn, Me.LastErrorCodeDataGridViewTextBoxColumn8, Me.MonitorManufacturerDataGridViewTextBoxColumn, Me.MonitorTypeDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn13, Me.PixelsPerXLogicalInchDataGridViewTextBoxColumn, Me.PixelsPerYLogicalInchDataGridViewTextBoxColumn, Me.PNPDeviceIDDataGridViewTextBoxColumn8, Me.PowerManagementSupportedDataGridViewCheckBoxColumn9, Me.ScreenHeightDataGridViewTextBoxColumn, Me.ScreenWidthDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn13, Me.StatusInfoDataGridViewTextBoxColumn8, Me.SystemCreationClassNameDataGridViewTextBoxColumn10, Me.SystemNameDataGridViewTextBoxColumn10})
Me.dgvDesktopMonitors.DataSource = Me.Win32DesktopMonitorBindingSource
Me.dgvDesktopMonitors.Dock = System.Windows.Forms.DockStyle.Fill
Me.dgvDesktopMonitors.Location = New System.Drawing.Point(0, 0)
Me.dgvDesktopMonitors.Name = "dgvDesktopMonitors"
Me.dgvDesktopMonitors.ReadOnly = true
Me.dgvDesktopMonitors.Size = New System.Drawing.Size(468, 183)
Me.dgvDesktopMonitors.TabIndex = 22
'
'AvailabilityDataGridViewTextBoxColumn8
'
Me.AvailabilityDataGridViewTextBoxColumn8.DataPropertyName = "Availability"
Me.AvailabilityDataGridViewTextBoxColumn8.HeaderText = "Availability"
Me.AvailabilityDataGridViewTextBoxColumn8.Name = "AvailabilityDataGridViewTextBoxColumn8"
Me.AvailabilityDataGridViewTextBoxColumn8.ReadOnly = true
'
'BandwidthDataGridViewTextBoxColumn
'
Me.BandwidthDataGridViewTextBoxColumn.DataPropertyName = "Bandwidth"
Me.BandwidthDataGridViewTextBoxColumn.HeaderText = "Bandwidth"
Me.BandwidthDataGridViewTextBoxColumn.Name = "BandwidthDataGridViewTextBoxColumn"
Me.BandwidthDataGridViewTextBoxColumn.ReadOnly = true
'
'CaptionDataGridViewTextBoxColumn14
'
Me.CaptionDataGridViewTextBoxColumn14.DataPropertyName = "Caption"
Me.CaptionDataGridViewTextBoxColumn14.HeaderText = "Caption"
Me.CaptionDataGridViewTextBoxColumn14.Name = "CaptionDataGridViewTextBoxColumn14"
Me.CaptionDataGridViewTextBoxColumn14.ReadOnly = true
'
'ConfigManagerErrorDataGridViewTextBoxColumn8
'
Me.ConfigManagerErrorDataGridViewTextBoxColumn8.DataPropertyName = "ConfigManagerError"
Me.ConfigManagerErrorDataGridViewTextBoxColumn8.HeaderText = "ConfigManagerError"
Me.ConfigManagerErrorDataGridViewTextBoxColumn8.Name = "ConfigManagerErrorDataGridViewTextBoxColumn8"
Me.ConfigManagerErrorDataGridViewTextBoxColumn8.ReadOnly = true
'
'ConfigManagerErrorCodeDataGridViewTextBoxColumn8
'
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn8.DataPropertyName = "ConfigManagerErrorCode"
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn8.HeaderText = "ConfigManagerErrorCode"
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn8.Name = "ConfigManagerErrorCodeDataGridViewTextBoxColumn8"
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn8.ReadOnly = true
'
'ConfigManagerUserConfigDataGridViewCheckBoxColumn8
'
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn8.DataPropertyName = "ConfigManagerUserConfig"
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn8.HeaderText = "ConfigManagerUserConfig"
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn8.Name = "ConfigManagerUserConfigDataGridViewCheckBoxColumn8"
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn8.ReadOnly = true
'
'CreationClassNameDataGridViewTextBoxColumn12
'
Me.CreationClassNameDataGridViewTextBoxColumn12.DataPropertyName = "CreationClassName"
Me.CreationClassNameDataGridViewTextBoxColumn12.HeaderText = "CreationClassName"
Me.CreationClassNameDataGridViewTextBoxColumn12.Name = "CreationClassNameDataGridViewTextBoxColumn12"
Me.CreationClassNameDataGridViewTextBoxColumn12.ReadOnly = true
'
'DescriptionDataGridViewTextBoxColumn15
'
Me.DescriptionDataGridViewTextBoxColumn15.DataPropertyName = "Description"
Me.DescriptionDataGridViewTextBoxColumn15.HeaderText = "Description"
Me.DescriptionDataGridViewTextBoxColumn15.Name = "DescriptionDataGridViewTextBoxColumn15"
Me.DescriptionDataGridViewTextBoxColumn15.ReadOnly = true
'
'DeviceIDDataGridViewTextBoxColumn9
'
Me.DeviceIDDataGridViewTextBoxColumn9.DataPropertyName = "DeviceID"
Me.DeviceIDDataGridViewTextBoxColumn9.HeaderText = "DeviceID"
Me.DeviceIDDataGridViewTextBoxColumn9.Name = "DeviceIDDataGridViewTextBoxColumn9"
Me.DeviceIDDataGridViewTextBoxColumn9.ReadOnly = true
'
'DisplayTypeDataGridViewTextBoxColumn
'
Me.DisplayTypeDataGridViewTextBoxColumn.DataPropertyName = "DisplayType"
Me.DisplayTypeDataGridViewTextBoxColumn.HeaderText = "DisplayType"
Me.DisplayTypeDataGridViewTextBoxColumn.Name = "DisplayTypeDataGridViewTextBoxColumn"
Me.DisplayTypeDataGridViewTextBoxColumn.ReadOnly = true
'
'ErrorClearedDataGridViewCheckBoxColumn8
'
Me.ErrorClearedDataGridViewCheckBoxColumn8.DataPropertyName = "ErrorCleared"
Me.ErrorClearedDataGridViewCheckBoxColumn8.HeaderText = "ErrorCleared"
Me.ErrorClearedDataGridViewCheckBoxColumn8.Name = "ErrorClearedDataGridViewCheckBoxColumn8"
Me.ErrorClearedDataGridViewCheckBoxColumn8.ReadOnly = true
'
'ErrorDescriptionDataGridViewTextBoxColumn8
'
Me.ErrorDescriptionDataGridViewTextBoxColumn8.DataPropertyName = "ErrorDescription"
Me.ErrorDescriptionDataGridViewTextBoxColumn8.HeaderText = "ErrorDescription"
Me.ErrorDescriptionDataGridViewTextBoxColumn8.Name = "ErrorDescriptionDataGridViewTextBoxColumn8"
Me.ErrorDescriptionDataGridViewTextBoxColumn8.ReadOnly = true
'
'InstallDateDataGridViewTextBoxColumn13
'
Me.InstallDateDataGridViewTextBoxColumn13.DataPropertyName = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn13.HeaderText = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn13.Name = "InstallDateDataGridViewTextBoxColumn13"
Me.InstallDateDataGridViewTextBoxColumn13.ReadOnly = true
'
'IsLockedDataGridViewCheckBoxColumn
'
Me.IsLockedDataGridViewCheckBoxColumn.DataPropertyName = "IsLocked"
Me.IsLockedDataGridViewCheckBoxColumn.HeaderText = "IsLocked"
Me.IsLockedDataGridViewCheckBoxColumn.Name = "IsLockedDataGridViewCheckBoxColumn"
Me.IsLockedDataGridViewCheckBoxColumn.ReadOnly = true
'
'LastErrorCodeDataGridViewTextBoxColumn8
'
Me.LastErrorCodeDataGridViewTextBoxColumn8.DataPropertyName = "LastErrorCode"
Me.LastErrorCodeDataGridViewTextBoxColumn8.HeaderText = "LastErrorCode"
Me.LastErrorCodeDataGridViewTextBoxColumn8.Name = "LastErrorCodeDataGridViewTextBoxColumn8"
Me.LastErrorCodeDataGridViewTextBoxColumn8.ReadOnly = true
'
'MonitorManufacturerDataGridViewTextBoxColumn
'
Me.MonitorManufacturerDataGridViewTextBoxColumn.DataPropertyName = "MonitorManufacturer"
Me.MonitorManufacturerDataGridViewTextBoxColumn.HeaderText = "MonitorManufacturer"
Me.MonitorManufacturerDataGridViewTextBoxColumn.Name = "MonitorManufacturerDataGridViewTextBoxColumn"
Me.MonitorManufacturerDataGridViewTextBoxColumn.ReadOnly = true
'
'MonitorTypeDataGridViewTextBoxColumn
'
Me.MonitorTypeDataGridViewTextBoxColumn.DataPropertyName = "MonitorType"
Me.MonitorTypeDataGridViewTextBoxColumn.HeaderText = "MonitorType"
Me.MonitorTypeDataGridViewTextBoxColumn.Name = "MonitorTypeDataGridViewTextBoxColumn"
Me.MonitorTypeDataGridViewTextBoxColumn.ReadOnly = true
'
'NameDataGridViewTextBoxColumn13
'
Me.NameDataGridViewTextBoxColumn13.DataPropertyName = "Name"
Me.NameDataGridViewTextBoxColumn13.HeaderText = "Name"
Me.NameDataGridViewTextBoxColumn13.Name = "NameDataGridViewTextBoxColumn13"
Me.NameDataGridViewTextBoxColumn13.ReadOnly = true
'
'PixelsPerXLogicalInchDataGridViewTextBoxColumn
'
Me.PixelsPerXLogicalInchDataGridViewTextBoxColumn.DataPropertyName = "PixelsPerXLogicalInch"
Me.PixelsPerXLogicalInchDataGridViewTextBoxColumn.HeaderText = "PixelsPerXLogicalInch"
Me.PixelsPerXLogicalInchDataGridViewTextBoxColumn.Name = "PixelsPerXLogicalInchDataGridViewTextBoxColumn"
Me.PixelsPerXLogicalInchDataGridViewTextBoxColumn.ReadOnly = true
'
'PixelsPerYLogicalInchDataGridViewTextBoxColumn
'
Me.PixelsPerYLogicalInchDataGridViewTextBoxColumn.DataPropertyName = "PixelsPerYLogicalInch"
Me.PixelsPerYLogicalInchDataGridViewTextBoxColumn.HeaderText = "PixelsPerYLogicalInch"
Me.PixelsPerYLogicalInchDataGridViewTextBoxColumn.Name = "PixelsPerYLogicalInchDataGridViewTextBoxColumn"
Me.PixelsPerYLogicalInchDataGridViewTextBoxColumn.ReadOnly = true
'
'PNPDeviceIDDataGridViewTextBoxColumn8
'
Me.PNPDeviceIDDataGridViewTextBoxColumn8.DataPropertyName = "PNPDeviceID"
Me.PNPDeviceIDDataGridViewTextBoxColumn8.HeaderText = "PNPDeviceID"
Me.PNPDeviceIDDataGridViewTextBoxColumn8.Name = "PNPDeviceIDDataGridViewTextBoxColumn8"
Me.PNPDeviceIDDataGridViewTextBoxColumn8.ReadOnly = true
'
'PowerManagementSupportedDataGridViewCheckBoxColumn9
'
Me.PowerManagementSupportedDataGridViewCheckBoxColumn9.DataPropertyName = "PowerManagementSupported"
Me.PowerManagementSupportedDataGridViewCheckBoxColumn9.HeaderText = "PowerManagementSupported"
Me.PowerManagementSupportedDataGridViewCheckBoxColumn9.Name = "PowerManagementSupportedDataGridViewCheckBoxColumn9"
Me.PowerManagementSupportedDataGridViewCheckBoxColumn9.ReadOnly = true
'
'ScreenHeightDataGridViewTextBoxColumn
'
Me.ScreenHeightDataGridViewTextBoxColumn.DataPropertyName = "ScreenHeight"
Me.ScreenHeightDataGridViewTextBoxColumn.HeaderText = "ScreenHeight"
Me.ScreenHeightDataGridViewTextBoxColumn.Name = "ScreenHeightDataGridViewTextBoxColumn"
Me.ScreenHeightDataGridViewTextBoxColumn.ReadOnly = true
'
'ScreenWidthDataGridViewTextBoxColumn
'
Me.ScreenWidthDataGridViewTextBoxColumn.DataPropertyName = "ScreenWidth"
Me.ScreenWidthDataGridViewTextBoxColumn.HeaderText = "ScreenWidth"
Me.ScreenWidthDataGridViewTextBoxColumn.Name = "ScreenWidthDataGridViewTextBoxColumn"
Me.ScreenWidthDataGridViewTextBoxColumn.ReadOnly = true
'
'StatusDataGridViewTextBoxColumn13
'
Me.StatusDataGridViewTextBoxColumn13.DataPropertyName = "Status"
Me.StatusDataGridViewTextBoxColumn13.HeaderText = "Status"
Me.StatusDataGridViewTextBoxColumn13.Name = "StatusDataGridViewTextBoxColumn13"
Me.StatusDataGridViewTextBoxColumn13.ReadOnly = true
'
'StatusInfoDataGridViewTextBoxColumn8
'
Me.StatusInfoDataGridViewTextBoxColumn8.DataPropertyName = "StatusInfo"
Me.StatusInfoDataGridViewTextBoxColumn8.HeaderText = "StatusInfo"
Me.StatusInfoDataGridViewTextBoxColumn8.Name = "StatusInfoDataGridViewTextBoxColumn8"
Me.StatusInfoDataGridViewTextBoxColumn8.ReadOnly = true
'
'SystemCreationClassNameDataGridViewTextBoxColumn10
'
Me.SystemCreationClassNameDataGridViewTextBoxColumn10.DataPropertyName = "SystemCreationClassName"
Me.SystemCreationClassNameDataGridViewTextBoxColumn10.HeaderText = "SystemCreationClassName"
Me.SystemCreationClassNameDataGridViewTextBoxColumn10.Name = "SystemCreationClassNameDataGridViewTextBoxColumn10"
Me.SystemCreationClassNameDataGridViewTextBoxColumn10.ReadOnly = true
'
'SystemNameDataGridViewTextBoxColumn10
'
Me.SystemNameDataGridViewTextBoxColumn10.DataPropertyName = "SystemName"
Me.SystemNameDataGridViewTextBoxColumn10.HeaderText = "SystemName"
Me.SystemNameDataGridViewTextBoxColumn10.Name = "SystemNameDataGridViewTextBoxColumn10"
Me.SystemNameDataGridViewTextBoxColumn10.ReadOnly = true
'
'Win32DesktopMonitorBindingSource
'
Me.Win32DesktopMonitorBindingSource.DataSource = GetType(WMIwrapper.Win32_DesktopMonitor)
'
'PanelVideoControllers
'
Me.PanelVideoControllers.Controls.Add(Me.dgvVideoControllers)
Me.PanelVideoControllers.Dock = System.Windows.Forms.DockStyle.Fill
Me.PanelVideoControllers.Location = New System.Drawing.Point(0, 0)
Me.PanelVideoControllers.Name = "PanelVideoControllers"
Me.PanelVideoControllers.Size = New System.Drawing.Size(468, 183)
Me.PanelVideoControllers.TabIndex = 18
'
'dgvVideoControllers
'
Me.dgvVideoControllers.AllowUserToAddRows = false
Me.dgvVideoControllers.AllowUserToDeleteRows = false
Me.dgvVideoControllers.AutoGenerateColumns = false
Me.dgvVideoControllers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
Me.dgvVideoControllers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AdapterCompatibilityDataGridViewTextBoxColumn, Me.AdapterDACTypeDataGridViewTextBoxColumn, Me.AdapterRAMDataGridViewTextBoxColumn, Me.AvailabilityDataGridViewTextBoxColumn7, Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn7, Me.CaptionDataGridViewTextBoxColumn13, Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn7, Me.ColorTableEntriesDataGridViewTextBoxColumn, Me.ConfigManagerErrorDataGridViewTextBoxColumn7, Me.CreationClassNameDataGridViewTextBoxColumn11, Me.CurrentBitsPerPixelDataGridViewTextBoxColumn, Me.CurrentHorizontalResolutionDataGridViewTextBoxColumn, Me.CurrentNumberOfColorsDataGridViewTextBoxColumn, Me.CurrentVerticalResolutionDataGridViewTextBoxColumn, Me.CurrentNumberOfColumnsDataGridViewTextBoxColumn, Me.CurrentNumberOfRowsDataGridViewTextBoxColumn, Me.CurrentRefreshRateDataGridViewTextBoxColumn, Me.CurrentScanModeDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn14, Me.DeviceIDDataGridViewTextBoxColumn8, Me.DeviceSpecificPensDataGridViewTextBoxColumn, Me.DitherTypeDataGridViewTextBoxColumn, Me.DriverDateDataGridViewTextBoxColumn1, Me.DriverVersionDataGridViewTextBoxColumn1, Me.ErrorClearedDataGridViewCheckBoxColumn7, Me.ErrorDescriptionDataGridViewTextBoxColumn7, Me.ICMIntentDataGridViewTextBoxColumn, Me.ICMMethodDataGridViewTextBoxColumn, Me.InfFileNameDataGridViewTextBoxColumn, Me.InfSectionDataGridViewTextBoxColumn, Me.InstallDateDataGridViewTextBoxColumn12, Me.InstalledDisplayDriversDataGridViewTextBoxColumn, Me.LastErrorCodeDataGridViewTextBoxColumn7, Me.MaxMemorySupportedDataGridViewTextBoxColumn, Me.MaxNumberControlledDataGridViewTextBoxColumn1, Me.MaxRefreshRateDataGridViewTextBoxColumn, Me.MinRefreshRateDataGridViewTextBoxColumn, Me.MonochromeDataGridViewCheckBoxColumn, Me.NameDataGridViewTextBoxColumn12, Me.NumberOfColorPlanesDataGridViewTextBoxColumn, Me.NumberOfVideoPagesDataGridViewTextBoxColumn, Me.PNPDeviceIDDataGridViewTextBoxColumn7, Me.PowerManagementSupportedDataGridViewCheckBoxColumn8, Me.ProtocolSupportedDataGridViewTextBoxColumn, Me.ReservedSystemPaletteEntriesDataGridViewTextBoxColumn, Me.SpecificationVersionDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn12, Me.StatusInfoDataGridViewTextBoxColumn7, Me.SystemCreationClassNameDataGridViewTextBoxColumn9, Me.SystemNameDataGridViewTextBoxColumn9, Me.SystemPaletteEntriesDataGridViewTextBoxColumn, Me.VideoModeDescriptionDataGridViewTextBoxColumn, Me.VideoProcessorDataGridViewTextBoxColumn, Me.VideoMemoryTypeDataGridViewTextBoxColumn})
Me.dgvVideoControllers.DataSource = Me.Win32VideoControllerBindingSource
Me.dgvVideoControllers.Dock = System.Windows.Forms.DockStyle.Fill
Me.dgvVideoControllers.Location = New System.Drawing.Point(0, 0)
Me.dgvVideoControllers.Name = "dgvVideoControllers"
Me.dgvVideoControllers.ReadOnly = true
Me.dgvVideoControllers.Size = New System.Drawing.Size(468, 183)
Me.dgvVideoControllers.TabIndex = 22
'
'AdapterCompatibilityDataGridViewTextBoxColumn
'
Me.AdapterCompatibilityDataGridViewTextBoxColumn.DataPropertyName = "AdapterCompatibility"
Me.AdapterCompatibilityDataGridViewTextBoxColumn.HeaderText = "AdapterCompatibility"
Me.AdapterCompatibilityDataGridViewTextBoxColumn.Name = "AdapterCompatibilityDataGridViewTextBoxColumn"
Me.AdapterCompatibilityDataGridViewTextBoxColumn.ReadOnly = true
'
'AdapterDACTypeDataGridViewTextBoxColumn
'
Me.AdapterDACTypeDataGridViewTextBoxColumn.DataPropertyName = "AdapterDACType"
Me.AdapterDACTypeDataGridViewTextBoxColumn.HeaderText = "AdapterDACType"
Me.AdapterDACTypeDataGridViewTextBoxColumn.Name = "AdapterDACTypeDataGridViewTextBoxColumn"
Me.AdapterDACTypeDataGridViewTextBoxColumn.ReadOnly = true
'
'AdapterRAMDataGridViewTextBoxColumn
'
Me.AdapterRAMDataGridViewTextBoxColumn.DataPropertyName = "AdapterRAM"
Me.AdapterRAMDataGridViewTextBoxColumn.HeaderText = "AdapterRAM"
Me.AdapterRAMDataGridViewTextBoxColumn.Name = "AdapterRAMDataGridViewTextBoxColumn"
Me.AdapterRAMDataGridViewTextBoxColumn.ReadOnly = true
'
'AvailabilityDataGridViewTextBoxColumn7
'
Me.AvailabilityDataGridViewTextBoxColumn7.DataPropertyName = "Availability"
Me.AvailabilityDataGridViewTextBoxColumn7.HeaderText = "Availability"
Me.AvailabilityDataGridViewTextBoxColumn7.Name = "AvailabilityDataGridViewTextBoxColumn7"
Me.AvailabilityDataGridViewTextBoxColumn7.ReadOnly = true
'
'ConfigManagerErrorCodeDataGridViewTextBoxColumn7
'
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn7.DataPropertyName = "ConfigManagerErrorCode"
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn7.HeaderText = "ConfigManagerErrorCode"
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn7.Name = "ConfigManagerErrorCodeDataGridViewTextBoxColumn7"
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn7.ReadOnly = true
'
'CaptionDataGridViewTextBoxColumn13
'
Me.CaptionDataGridViewTextBoxColumn13.DataPropertyName = "Caption"
Me.CaptionDataGridViewTextBoxColumn13.HeaderText = "Caption"
Me.CaptionDataGridViewTextBoxColumn13.Name = "CaptionDataGridViewTextBoxColumn13"
Me.CaptionDataGridViewTextBoxColumn13.ReadOnly = true
'
'ConfigManagerUserConfigDataGridViewCheckBoxColumn7
'
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn7.DataPropertyName = "ConfigManagerUserConfig"
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn7.HeaderText = "ConfigManagerUserConfig"
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn7.Name = "ConfigManagerUserConfigDataGridViewCheckBoxColumn7"
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn7.ReadOnly = true
'
'ColorTableEntriesDataGridViewTextBoxColumn
'
Me.ColorTableEntriesDataGridViewTextBoxColumn.DataPropertyName = "ColorTableEntries"
Me.ColorTableEntriesDataGridViewTextBoxColumn.HeaderText = "ColorTableEntries"
Me.ColorTableEntriesDataGridViewTextBoxColumn.Name = "ColorTableEntriesDataGridViewTextBoxColumn"
Me.ColorTableEntriesDataGridViewTextBoxColumn.ReadOnly = true
'
'ConfigManagerErrorDataGridViewTextBoxColumn7
'
Me.ConfigManagerErrorDataGridViewTextBoxColumn7.DataPropertyName = "ConfigManagerError"
Me.ConfigManagerErrorDataGridViewTextBoxColumn7.HeaderText = "ConfigManagerError"
Me.ConfigManagerErrorDataGridViewTextBoxColumn7.Name = "ConfigManagerErrorDataGridViewTextBoxColumn7"
Me.ConfigManagerErrorDataGridViewTextBoxColumn7.ReadOnly = true
'
'CreationClassNameDataGridViewTextBoxColumn11
'
Me.CreationClassNameDataGridViewTextBoxColumn11.DataPropertyName = "CreationClassName"
Me.CreationClassNameDataGridViewTextBoxColumn11.HeaderText = "CreationClassName"
Me.CreationClassNameDataGridViewTextBoxColumn11.Name = "CreationClassNameDataGridViewTextBoxColumn11"
Me.CreationClassNameDataGridViewTextBoxColumn11.ReadOnly = true
'
'CurrentBitsPerPixelDataGridViewTextBoxColumn
'
Me.CurrentBitsPerPixelDataGridViewTextBoxColumn.DataPropertyName = "CurrentBitsPerPixel"
Me.CurrentBitsPerPixelDataGridViewTextBoxColumn.HeaderText = "CurrentBitsPerPixel"
Me.CurrentBitsPerPixelDataGridViewTextBoxColumn.Name = "CurrentBitsPerPixelDataGridViewTextBoxColumn"
Me.CurrentBitsPerPixelDataGridViewTextBoxColumn.ReadOnly = true
'
'CurrentHorizontalResolutionDataGridViewTextBoxColumn
'
Me.CurrentHorizontalResolutionDataGridViewTextBoxColumn.DataPropertyName = "CurrentHorizontalResolution"
Me.CurrentHorizontalResolutionDataGridViewTextBoxColumn.HeaderText = "CurrentHorizontalResolution"
Me.CurrentHorizontalResolutionDataGridViewTextBoxColumn.Name = "CurrentHorizontalResolutionDataGridViewTextBoxColumn"
Me.CurrentHorizontalResolutionDataGridViewTextBoxColumn.ReadOnly = true
'
'CurrentNumberOfColorsDataGridViewTextBoxColumn
'
Me.CurrentNumberOfColorsDataGridViewTextBoxColumn.DataPropertyName = "CurrentNumberOfColors"
Me.CurrentNumberOfColorsDataGridViewTextBoxColumn.HeaderText = "CurrentNumberOfColors"
Me.CurrentNumberOfColorsDataGridViewTextBoxColumn.Name = "CurrentNumberOfColorsDataGridViewTextBoxColumn"
Me.CurrentNumberOfColorsDataGridViewTextBoxColumn.ReadOnly = true
'
'CurrentVerticalResolutionDataGridViewTextBoxColumn
'
Me.CurrentVerticalResolutionDataGridViewTextBoxColumn.DataPropertyName = "CurrentVerticalResolution"
Me.CurrentVerticalResolutionDataGridViewTextBoxColumn.HeaderText = "CurrentVerticalResolution"
Me.CurrentVerticalResolutionDataGridViewTextBoxColumn.Name = "CurrentVerticalResolutionDataGridViewTextBoxColumn"
Me.CurrentVerticalResolutionDataGridViewTextBoxColumn.ReadOnly = true
'
'CurrentNumberOfColumnsDataGridViewTextBoxColumn
'
Me.CurrentNumberOfColumnsDataGridViewTextBoxColumn.DataPropertyName = "CurrentNumberOfColumns"
Me.CurrentNumberOfColumnsDataGridViewTextBoxColumn.HeaderText = "CurrentNumberOfColumns"
Me.CurrentNumberOfColumnsDataGridViewTextBoxColumn.Name = "CurrentNumberOfColumnsDataGridViewTextBoxColumn"
Me.CurrentNumberOfColumnsDataGridViewTextBoxColumn.ReadOnly = true
'
'CurrentNumberOfRowsDataGridViewTextBoxColumn
'
Me.CurrentNumberOfRowsDataGridViewTextBoxColumn.DataPropertyName = "CurrentNumberOfRows"
Me.CurrentNumberOfRowsDataGridViewTextBoxColumn.HeaderText = "CurrentNumberOfRows"
Me.CurrentNumberOfRowsDataGridViewTextBoxColumn.Name = "CurrentNumberOfRowsDataGridViewTextBoxColumn"
Me.CurrentNumberOfRowsDataGridViewTextBoxColumn.ReadOnly = true
'
'CurrentRefreshRateDataGridViewTextBoxColumn
'
Me.CurrentRefreshRateDataGridViewTextBoxColumn.DataPropertyName = "CurrentRefreshRate"
Me.CurrentRefreshRateDataGridViewTextBoxColumn.HeaderText = "CurrentRefreshRate"
Me.CurrentRefreshRateDataGridViewTextBoxColumn.Name = "CurrentRefreshRateDataGridViewTextBoxColumn"
Me.CurrentRefreshRateDataGridViewTextBoxColumn.ReadOnly = true
'
'CurrentScanModeDataGridViewTextBoxColumn
'
Me.CurrentScanModeDataGridViewTextBoxColumn.DataPropertyName = "CurrentScanMode"
Me.CurrentScanModeDataGridViewTextBoxColumn.HeaderText = "CurrentScanMode"
Me.CurrentScanModeDataGridViewTextBoxColumn.Name = "CurrentScanModeDataGridViewTextBoxColumn"
Me.CurrentScanModeDataGridViewTextBoxColumn.ReadOnly = true
'
'DescriptionDataGridViewTextBoxColumn14
'
Me.DescriptionDataGridViewTextBoxColumn14.DataPropertyName = "Description"
Me.DescriptionDataGridViewTextBoxColumn14.HeaderText = "Description"
Me.DescriptionDataGridViewTextBoxColumn14.Name = "DescriptionDataGridViewTextBoxColumn14"
Me.DescriptionDataGridViewTextBoxColumn14.ReadOnly = true
'
'DeviceIDDataGridViewTextBoxColumn8
'
Me.DeviceIDDataGridViewTextBoxColumn8.DataPropertyName = "DeviceID"
Me.DeviceIDDataGridViewTextBoxColumn8.HeaderText = "DeviceID"
Me.DeviceIDDataGridViewTextBoxColumn8.Name = "DeviceIDDataGridViewTextBoxColumn8"
Me.DeviceIDDataGridViewTextBoxColumn8.ReadOnly = true
'
'DeviceSpecificPensDataGridViewTextBoxColumn
'
Me.DeviceSpecificPensDataGridViewTextBoxColumn.DataPropertyName = "DeviceSpecificPens"
Me.DeviceSpecificPensDataGridViewTextBoxColumn.HeaderText = "DeviceSpecificPens"
Me.DeviceSpecificPensDataGridViewTextBoxColumn.Name = "DeviceSpecificPensDataGridViewTextBoxColumn"
Me.DeviceSpecificPensDataGridViewTextBoxColumn.ReadOnly = true
'
'DitherTypeDataGridViewTextBoxColumn
'
Me.DitherTypeDataGridViewTextBoxColumn.DataPropertyName = "DitherType"
Me.DitherTypeDataGridViewTextBoxColumn.HeaderText = "DitherType"
Me.DitherTypeDataGridViewTextBoxColumn.Name = "DitherTypeDataGridViewTextBoxColumn"
Me.DitherTypeDataGridViewTextBoxColumn.ReadOnly = true
'
'DriverDateDataGridViewTextBoxColumn1
'
Me.DriverDateDataGridViewTextBoxColumn1.DataPropertyName = "DriverDate"
Me.DriverDateDataGridViewTextBoxColumn1.HeaderText = "DriverDate"
Me.DriverDateDataGridViewTextBoxColumn1.Name = "DriverDateDataGridViewTextBoxColumn1"
Me.DriverDateDataGridViewTextBoxColumn1.ReadOnly = true
'
'DriverVersionDataGridViewTextBoxColumn1
'
Me.DriverVersionDataGridViewTextBoxColumn1.DataPropertyName = "DriverVersion"
Me.DriverVersionDataGridViewTextBoxColumn1.HeaderText = "DriverVersion"
Me.DriverVersionDataGridViewTextBoxColumn1.Name = "DriverVersionDataGridViewTextBoxColumn1"
Me.DriverVersionDataGridViewTextBoxColumn1.ReadOnly = true
'
'ErrorClearedDataGridViewCheckBoxColumn7
'
Me.ErrorClearedDataGridViewCheckBoxColumn7.DataPropertyName = "ErrorCleared"
Me.ErrorClearedDataGridViewCheckBoxColumn7.HeaderText = "ErrorCleared"
Me.ErrorClearedDataGridViewCheckBoxColumn7.Name = "ErrorClearedDataGridViewCheckBoxColumn7"
Me.ErrorClearedDataGridViewCheckBoxColumn7.ReadOnly = true
'
'ErrorDescriptionDataGridViewTextBoxColumn7
'
Me.ErrorDescriptionDataGridViewTextBoxColumn7.DataPropertyName = "ErrorDescription"
Me.ErrorDescriptionDataGridViewTextBoxColumn7.HeaderText = "ErrorDescription"
Me.ErrorDescriptionDataGridViewTextBoxColumn7.Name = "ErrorDescriptionDataGridViewTextBoxColumn7"
Me.ErrorDescriptionDataGridViewTextBoxColumn7.ReadOnly = true
'
'ICMIntentDataGridViewTextBoxColumn
'
Me.ICMIntentDataGridViewTextBoxColumn.DataPropertyName = "ICMIntent"
Me.ICMIntentDataGridViewTextBoxColumn.HeaderText = "ICMIntent"
Me.ICMIntentDataGridViewTextBoxColumn.Name = "ICMIntentDataGridViewTextBoxColumn"
Me.ICMIntentDataGridViewTextBoxColumn.ReadOnly = true
'
'ICMMethodDataGridViewTextBoxColumn
'
Me.ICMMethodDataGridViewTextBoxColumn.DataPropertyName = "ICMMethod"
Me.ICMMethodDataGridViewTextBoxColumn.HeaderText = "ICMMethod"
Me.ICMMethodDataGridViewTextBoxColumn.Name = "ICMMethodDataGridViewTextBoxColumn"
Me.ICMMethodDataGridViewTextBoxColumn.ReadOnly = true
'
'InfFileNameDataGridViewTextBoxColumn
'
Me.InfFileNameDataGridViewTextBoxColumn.DataPropertyName = "InfFileName"
Me.InfFileNameDataGridViewTextBoxColumn.HeaderText = "InfFileName"
Me.InfFileNameDataGridViewTextBoxColumn.Name = "InfFileNameDataGridViewTextBoxColumn"
Me.InfFileNameDataGridViewTextBoxColumn.ReadOnly = true
'
'InfSectionDataGridViewTextBoxColumn
'
Me.InfSectionDataGridViewTextBoxColumn.DataPropertyName = "InfSection"
Me.InfSectionDataGridViewTextBoxColumn.HeaderText = "InfSection"
Me.InfSectionDataGridViewTextBoxColumn.Name = "InfSectionDataGridViewTextBoxColumn"
Me.InfSectionDataGridViewTextBoxColumn.ReadOnly = true
'
'InstallDateDataGridViewTextBoxColumn12
'
Me.InstallDateDataGridViewTextBoxColumn12.DataPropertyName = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn12.HeaderText = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn12.Name = "InstallDateDataGridViewTextBoxColumn12"
Me.InstallDateDataGridViewTextBoxColumn12.ReadOnly = true
'
'InstalledDisplayDriversDataGridViewTextBoxColumn
'
Me.InstalledDisplayDriversDataGridViewTextBoxColumn.DataPropertyName = "InstalledDisplayDrivers"
Me.InstalledDisplayDriversDataGridViewTextBoxColumn.HeaderText = "InstalledDisplayDrivers"
Me.InstalledDisplayDriversDataGridViewTextBoxColumn.Name = "InstalledDisplayDriversDataGridViewTextBoxColumn"
Me.InstalledDisplayDriversDataGridViewTextBoxColumn.ReadOnly = true
'
'LastErrorCodeDataGridViewTextBoxColumn7
'
Me.LastErrorCodeDataGridViewTextBoxColumn7.DataPropertyName = "LastErrorCode"
Me.LastErrorCodeDataGridViewTextBoxColumn7.HeaderText = "LastErrorCode"
Me.LastErrorCodeDataGridViewTextBoxColumn7.Name = "LastErrorCodeDataGridViewTextBoxColumn7"
Me.LastErrorCodeDataGridViewTextBoxColumn7.ReadOnly = true
'
'MaxMemorySupportedDataGridViewTextBoxColumn
'
Me.MaxMemorySupportedDataGridViewTextBoxColumn.DataPropertyName = "MaxMemorySupported"
Me.MaxMemorySupportedDataGridViewTextBoxColumn.HeaderText = "MaxMemorySupported"
Me.MaxMemorySupportedDataGridViewTextBoxColumn.Name = "MaxMemorySupportedDataGridViewTextBoxColumn"
Me.MaxMemorySupportedDataGridViewTextBoxColumn.ReadOnly = true
'
'MaxNumberControlledDataGridViewTextBoxColumn1
'
Me.MaxNumberControlledDataGridViewTextBoxColumn1.DataPropertyName = "MaxNumberControlled"
Me.MaxNumberControlledDataGridViewTextBoxColumn1.HeaderText = "MaxNumberControlled"
Me.MaxNumberControlledDataGridViewTextBoxColumn1.Name = "MaxNumberControlledDataGridViewTextBoxColumn1"
Me.MaxNumberControlledDataGridViewTextBoxColumn1.ReadOnly = true
'
'MaxRefreshRateDataGridViewTextBoxColumn
'
Me.MaxRefreshRateDataGridViewTextBoxColumn.DataPropertyName = "MaxRefreshRate"
Me.MaxRefreshRateDataGridViewTextBoxColumn.HeaderText = "MaxRefreshRate"
Me.MaxRefreshRateDataGridViewTextBoxColumn.Name = "MaxRefreshRateDataGridViewTextBoxColumn"
Me.MaxRefreshRateDataGridViewTextBoxColumn.ReadOnly = true
'
'MinRefreshRateDataGridViewTextBoxColumn
'
Me.MinRefreshRateDataGridViewTextBoxColumn.DataPropertyName = "MinRefreshRate"
Me.MinRefreshRateDataGridViewTextBoxColumn.HeaderText = "MinRefreshRate"
Me.MinRefreshRateDataGridViewTextBoxColumn.Name = "MinRefreshRateDataGridViewTextBoxColumn"
Me.MinRefreshRateDataGridViewTextBoxColumn.ReadOnly = true
'
'MonochromeDataGridViewCheckBoxColumn
'
Me.MonochromeDataGridViewCheckBoxColumn.DataPropertyName = "Monochrome"
Me.MonochromeDataGridViewCheckBoxColumn.HeaderText = "Monochrome"
Me.MonochromeDataGridViewCheckBoxColumn.Name = "MonochromeDataGridViewCheckBoxColumn"
Me.MonochromeDataGridViewCheckBoxColumn.ReadOnly = true
'
'NameDataGridViewTextBoxColumn12
'
Me.NameDataGridViewTextBoxColumn12.DataPropertyName = "Name"
Me.NameDataGridViewTextBoxColumn12.HeaderText = "Name"
Me.NameDataGridViewTextBoxColumn12.Name = "NameDataGridViewTextBoxColumn12"
Me.NameDataGridViewTextBoxColumn12.ReadOnly = true
'
'NumberOfColorPlanesDataGridViewTextBoxColumn
'
Me.NumberOfColorPlanesDataGridViewTextBoxColumn.DataPropertyName = "NumberOfColorPlanes"
Me.NumberOfColorPlanesDataGridViewTextBoxColumn.HeaderText = "NumberOfColorPlanes"
Me.NumberOfColorPlanesDataGridViewTextBoxColumn.Name = "NumberOfColorPlanesDataGridViewTextBoxColumn"
Me.NumberOfColorPlanesDataGridViewTextBoxColumn.ReadOnly = true
'
'NumberOfVideoPagesDataGridViewTextBoxColumn
'
Me.NumberOfVideoPagesDataGridViewTextBoxColumn.DataPropertyName = "NumberOfVideoPages"
Me.NumberOfVideoPagesDataGridViewTextBoxColumn.HeaderText = "NumberOfVideoPages"
Me.NumberOfVideoPagesDataGridViewTextBoxColumn.Name = "NumberOfVideoPagesDataGridViewTextBoxColumn"
Me.NumberOfVideoPagesDataGridViewTextBoxColumn.ReadOnly = true
'
'PNPDeviceIDDataGridViewTextBoxColumn7
'
Me.PNPDeviceIDDataGridViewTextBoxColumn7.DataPropertyName = "PNPDeviceID"
Me.PNPDeviceIDDataGridViewTextBoxColumn7.HeaderText = "PNPDeviceID"
Me.PNPDeviceIDDataGridViewTextBoxColumn7.Name = "PNPDeviceIDDataGridViewTextBoxColumn7"
Me.PNPDeviceIDDataGridViewTextBoxColumn7.ReadOnly = true
'
'PowerManagementSupportedDataGridViewCheckBoxColumn8
'
Me.PowerManagementSupportedDataGridViewCheckBoxColumn8.DataPropertyName = "PowerManagementSupported"
Me.PowerManagementSupportedDataGridViewCheckBoxColumn8.HeaderText = "PowerManagementSupported"
Me.PowerManagementSupportedDataGridViewCheckBoxColumn8.Name = "PowerManagementSupportedDataGridViewCheckBoxColumn8"
Me.PowerManagementSupportedDataGridViewCheckBoxColumn8.ReadOnly = true
'
'ProtocolSupportedDataGridViewTextBoxColumn
'
Me.ProtocolSupportedDataGridViewTextBoxColumn.DataPropertyName = "ProtocolSupported"
Me.ProtocolSupportedDataGridViewTextBoxColumn.HeaderText = "ProtocolSupported"
Me.ProtocolSupportedDataGridViewTextBoxColumn.Name = "ProtocolSupportedDataGridViewTextBoxColumn"
Me.ProtocolSupportedDataGridViewTextBoxColumn.ReadOnly = true
'
'ReservedSystemPaletteEntriesDataGridViewTextBoxColumn
'
Me.ReservedSystemPaletteEntriesDataGridViewTextBoxColumn.DataPropertyName = "ReservedSystemPaletteEntries"
Me.ReservedSystemPaletteEntriesDataGridViewTextBoxColumn.HeaderText = "ReservedSystemPaletteEntries"
Me.ReservedSystemPaletteEntriesDataGridViewTextBoxColumn.Name = "ReservedSystemPaletteEntriesDataGridViewTextBoxColumn"
Me.ReservedSystemPaletteEntriesDataGridViewTextBoxColumn.ReadOnly = true
'
'SpecificationVersionDataGridViewTextBoxColumn
'
Me.SpecificationVersionDataGridViewTextBoxColumn.DataPropertyName = "SpecificationVersion"
Me.SpecificationVersionDataGridViewTextBoxColumn.HeaderText = "SpecificationVersion"
Me.SpecificationVersionDataGridViewTextBoxColumn.Name = "SpecificationVersionDataGridViewTextBoxColumn"
Me.SpecificationVersionDataGridViewTextBoxColumn.ReadOnly = true
'
'StatusDataGridViewTextBoxColumn12
'
Me.StatusDataGridViewTextBoxColumn12.DataPropertyName = "Status"
Me.StatusDataGridViewTextBoxColumn12.HeaderText = "Status"
Me.StatusDataGridViewTextBoxColumn12.Name = "StatusDataGridViewTextBoxColumn12"
Me.StatusDataGridViewTextBoxColumn12.ReadOnly = true
'
'StatusInfoDataGridViewTextBoxColumn7
'
Me.StatusInfoDataGridViewTextBoxColumn7.DataPropertyName = "StatusInfo"
Me.StatusInfoDataGridViewTextBoxColumn7.HeaderText = "StatusInfo"
Me.StatusInfoDataGridViewTextBoxColumn7.Name = "StatusInfoDataGridViewTextBoxColumn7"
Me.StatusInfoDataGridViewTextBoxColumn7.ReadOnly = true
'
'SystemCreationClassNameDataGridViewTextBoxColumn9
'
Me.SystemCreationClassNameDataGridViewTextBoxColumn9.DataPropertyName = "SystemCreationClassName"
Me.SystemCreationClassNameDataGridViewTextBoxColumn9.HeaderText = "SystemCreationClassName"
Me.SystemCreationClassNameDataGridViewTextBoxColumn9.Name = "SystemCreationClassNameDataGridViewTextBoxColumn9"
Me.SystemCreationClassNameDataGridViewTextBoxColumn9.ReadOnly = true
'
'SystemNameDataGridViewTextBoxColumn9
'
Me.SystemNameDataGridViewTextBoxColumn9.DataPropertyName = "SystemName"
Me.SystemNameDataGridViewTextBoxColumn9.HeaderText = "SystemName"
Me.SystemNameDataGridViewTextBoxColumn9.Name = "SystemNameDataGridViewTextBoxColumn9"
Me.SystemNameDataGridViewTextBoxColumn9.ReadOnly = true
'
'SystemPaletteEntriesDataGridViewTextBoxColumn
'
Me.SystemPaletteEntriesDataGridViewTextBoxColumn.DataPropertyName = "SystemPaletteEntries"
Me.SystemPaletteEntriesDataGridViewTextBoxColumn.HeaderText = "SystemPaletteEntries"
Me.SystemPaletteEntriesDataGridViewTextBoxColumn.Name = "SystemPaletteEntriesDataGridViewTextBoxColumn"
Me.SystemPaletteEntriesDataGridViewTextBoxColumn.ReadOnly = true
'
'VideoModeDescriptionDataGridViewTextBoxColumn
'
Me.VideoModeDescriptionDataGridViewTextBoxColumn.DataPropertyName = "VideoModeDescription"
Me.VideoModeDescriptionDataGridViewTextBoxColumn.HeaderText = "VideoModeDescription"
Me.VideoModeDescriptionDataGridViewTextBoxColumn.Name = "VideoModeDescriptionDataGridViewTextBoxColumn"
Me.VideoModeDescriptionDataGridViewTextBoxColumn.ReadOnly = true
'
'VideoProcessorDataGridViewTextBoxColumn
'
Me.VideoProcessorDataGridViewTextBoxColumn.DataPropertyName = "VideoProcessor"
Me.VideoProcessorDataGridViewTextBoxColumn.HeaderText = "VideoProcessor"
Me.VideoProcessorDataGridViewTextBoxColumn.Name = "VideoProcessorDataGridViewTextBoxColumn"
Me.VideoProcessorDataGridViewTextBoxColumn.ReadOnly = true
'
'VideoMemoryTypeDataGridViewTextBoxColumn
'
Me.VideoMemoryTypeDataGridViewTextBoxColumn.DataPropertyName = "VideoMemoryType"
Me.VideoMemoryTypeDataGridViewTextBoxColumn.HeaderText = "VideoMemoryType"
Me.VideoMemoryTypeDataGridViewTextBoxColumn.Name = "VideoMemoryTypeDataGridViewTextBoxColumn"
Me.VideoMemoryTypeDataGridViewTextBoxColumn.ReadOnly = true
'
'Win32VideoControllerBindingSource
'
Me.Win32VideoControllerBindingSource.DataSource = GetType(WMIwrapper.Win32_VideoController)
'
'PanelComputerSystem
'
Me.PanelComputerSystem.Controls.Add(Me.dgvComputerSystem)
Me.PanelComputerSystem.Dock = System.Windows.Forms.DockStyle.Fill
Me.PanelComputerSystem.Location = New System.Drawing.Point(0, 0)
Me.PanelComputerSystem.Name = "PanelComputerSystem"
Me.PanelComputerSystem.Size = New System.Drawing.Size(468, 183)
Me.PanelComputerSystem.TabIndex = 17
'
'dgvComputerSystem
'
Me.dgvComputerSystem.AllowUserToAddRows = false
Me.dgvComputerSystem.AllowUserToDeleteRows = false
Me.dgvComputerSystem.AutoGenerateColumns = false
Me.dgvComputerSystem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
Me.dgvComputerSystem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AutomaticManagedPagefileDataGridViewCheckBoxColumn, Me.AutomaticResetCapabilityDataGridViewCheckBoxColumn, Me.AutomaticResetBootOptionDataGridViewCheckBoxColumn, Me.BootROMSupportedDataGridViewCheckBoxColumn, Me.BootupStateDataGridViewTextBoxColumn, Me.CaptionDataGridViewTextBoxColumn12, Me.ChassisBootupStateDataGridViewTextBoxColumn, Me.CreationClassNameDataGridViewTextBoxColumn10, Me.DescriptionDataGridViewTextBoxColumn13, Me.CurrentTimeZoneDataGridViewTextBoxColumn1, Me.DNSHostNameDataGridViewTextBoxColumn1, Me.DomainRoleDataGridViewTextBoxColumn, Me.DaylightInEffectDataGridViewCheckBoxColumn, Me.DomainDataGridViewTextBoxColumn, Me.EnableDaylightSavingsTimeDataGridViewCheckBoxColumn, Me.FrontPanelResetStatusDataGridViewTextBoxColumn, Me.InfraredSupportedDataGridViewCheckBoxColumn, Me.InitialLoadInfoDataGridViewTextBoxColumn, Me.InstallDateDataGridViewTextBoxColumn11, Me.KeyboardPasswordStatusDataGridViewTextBoxColumn, Me.LastLoadInfoDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn11, Me.NameFormatDataGridViewTextBoxColumn, Me.NetworkServerModeEnabledDataGridViewCheckBoxColumn, Me.NumberOfLogicalProcessorsDataGridViewTextBoxColumn1, Me.NumberOfProcessorsDataGridViewTextBoxColumn, Me.OEMLogoBitmapDataGridViewImageColumn, Me.PartOfDomainDataGridViewCheckBoxColumn, Me.PauseAfterResetDataGridViewTextBoxColumn, Me.PCSystemTypeDataGridViewTextBoxColumn, Me.PowerManagementSupportedDataGridViewCheckBoxColumn7, Me.PowerOnPasswordStatusDataGridViewTextBoxColumn, Me.PowerStateDataGridViewTextBoxColumn, Me.PowerSupplyStateDataGridViewTextBoxColumn, Me.PrimaryOwnerContactDataGridViewTextBoxColumn, Me.PrimaryOwnerNameDataGridViewTextBoxColumn, Me.ResetCapabilityDataGridViewTextBoxColumn, Me.ResetCountDataGridViewTextBoxColumn, Me.ResetLimitDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn11, Me.SystemStartupDelayDataGridViewTextBoxColumn, Me.SystemStartupSettingDataGridViewTextBoxColumn, Me.SystemTypeDataGridViewTextBoxColumn, Me.ThermalStateDataGridViewTextBoxColumn, Me.TotalPhysicalMemoryDataGridViewTextBoxColumn, Me.UserNameDataGridViewTextBoxColumn, Me.WakeUpTypeDataGridViewTextBoxColumn, Me.WorkgroupDataGridViewTextBoxColumn})
Me.dgvComputerSystem.DataSource = Me.Win32ComputerSystemBindingSource
Me.dgvComputerSystem.Dock = System.Windows.Forms.DockStyle.Fill
Me.dgvComputerSystem.Location = New System.Drawing.Point(0, 0)
Me.dgvComputerSystem.Name = "dgvComputerSystem"
Me.dgvComputerSystem.ReadOnly = true
Me.dgvComputerSystem.Size = New System.Drawing.Size(468, 183)
Me.dgvComputerSystem.TabIndex = 22
'
'AutomaticManagedPagefileDataGridViewCheckBoxColumn
'
Me.AutomaticManagedPagefileDataGridViewCheckBoxColumn.DataPropertyName = "AutomaticManagedPagefile"
Me.AutomaticManagedPagefileDataGridViewCheckBoxColumn.HeaderText = "AutomaticManagedPagefile"
Me.AutomaticManagedPagefileDataGridViewCheckBoxColumn.Name = "AutomaticManagedPagefileDataGridViewCheckBoxColumn"
Me.AutomaticManagedPagefileDataGridViewCheckBoxColumn.ReadOnly = true
'
'AutomaticResetCapabilityDataGridViewCheckBoxColumn
'
Me.AutomaticResetCapabilityDataGridViewCheckBoxColumn.DataPropertyName = "AutomaticResetCapability"
Me.AutomaticResetCapabilityDataGridViewCheckBoxColumn.HeaderText = "AutomaticResetCapability"
Me.AutomaticResetCapabilityDataGridViewCheckBoxColumn.Name = "AutomaticResetCapabilityDataGridViewCheckBoxColumn"
Me.AutomaticResetCapabilityDataGridViewCheckBoxColumn.ReadOnly = true
'
'AutomaticResetBootOptionDataGridViewCheckBoxColumn
'
Me.AutomaticResetBootOptionDataGridViewCheckBoxColumn.DataPropertyName = "AutomaticResetBootOption"
Me.AutomaticResetBootOptionDataGridViewCheckBoxColumn.HeaderText = "AutomaticResetBootOption"
Me.AutomaticResetBootOptionDataGridViewCheckBoxColumn.Name = "AutomaticResetBootOptionDataGridViewCheckBoxColumn"
Me.AutomaticResetBootOptionDataGridViewCheckBoxColumn.ReadOnly = true
'
'BootROMSupportedDataGridViewCheckBoxColumn
'
Me.BootROMSupportedDataGridViewCheckBoxColumn.DataPropertyName = "BootROMSupported"
Me.BootROMSupportedDataGridViewCheckBoxColumn.HeaderText = "BootROMSupported"
Me.BootROMSupportedDataGridViewCheckBoxColumn.Name = "BootROMSupportedDataGridViewCheckBoxColumn"
Me.BootROMSupportedDataGridViewCheckBoxColumn.ReadOnly = true
'
'BootupStateDataGridViewTextBoxColumn
'
Me.BootupStateDataGridViewTextBoxColumn.DataPropertyName = "BootupState"
Me.BootupStateDataGridViewTextBoxColumn.HeaderText = "BootupState"
Me.BootupStateDataGridViewTextBoxColumn.Name = "BootupStateDataGridViewTextBoxColumn"
Me.BootupStateDataGridViewTextBoxColumn.ReadOnly = true
'
'CaptionDataGridViewTextBoxColumn12
'
Me.CaptionDataGridViewTextBoxColumn12.DataPropertyName = "Caption"
Me.CaptionDataGridViewTextBoxColumn12.HeaderText = "Caption"
Me.CaptionDataGridViewTextBoxColumn12.Name = "CaptionDataGridViewTextBoxColumn12"
Me.CaptionDataGridViewTextBoxColumn12.ReadOnly = true
'
'ChassisBootupStateDataGridViewTextBoxColumn
'
Me.ChassisBootupStateDataGridViewTextBoxColumn.DataPropertyName = "ChassisBootupState"
Me.ChassisBootupStateDataGridViewTextBoxColumn.HeaderText = "ChassisBootupState"
Me.ChassisBootupStateDataGridViewTextBoxColumn.Name = "ChassisBootupStateDataGridViewTextBoxColumn"
Me.ChassisBootupStateDataGridViewTextBoxColumn.ReadOnly = true
'
'CreationClassNameDataGridViewTextBoxColumn10
'
Me.CreationClassNameDataGridViewTextBoxColumn10.DataPropertyName = "CreationClassName"
Me.CreationClassNameDataGridViewTextBoxColumn10.HeaderText = "CreationClassName"
Me.CreationClassNameDataGridViewTextBoxColumn10.Name = "CreationClassNameDataGridViewTextBoxColumn10"
Me.CreationClassNameDataGridViewTextBoxColumn10.ReadOnly = true
'
'DescriptionDataGridViewTextBoxColumn13
'
Me.DescriptionDataGridViewTextBoxColumn13.DataPropertyName = "Description"
Me.DescriptionDataGridViewTextBoxColumn13.HeaderText = "Description"
Me.DescriptionDataGridViewTextBoxColumn13.Name = "DescriptionDataGridViewTextBoxColumn13"
Me.DescriptionDataGridViewTextBoxColumn13.ReadOnly = true
'
'CurrentTimeZoneDataGridViewTextBoxColumn1
'
Me.CurrentTimeZoneDataGridViewTextBoxColumn1.DataPropertyName = "CurrentTimeZone"
Me.CurrentTimeZoneDataGridViewTextBoxColumn1.HeaderText = "CurrentTimeZone"
Me.CurrentTimeZoneDataGridViewTextBoxColumn1.Name = "CurrentTimeZoneDataGridViewTextBoxColumn1"
Me.CurrentTimeZoneDataGridViewTextBoxColumn1.ReadOnly = true
'
'DNSHostNameDataGridViewTextBoxColumn1
'
Me.DNSHostNameDataGridViewTextBoxColumn1.DataPropertyName = "DNSHostName"
Me.DNSHostNameDataGridViewTextBoxColumn1.HeaderText = "DNSHostName"
Me.DNSHostNameDataGridViewTextBoxColumn1.Name = "DNSHostNameDataGridViewTextBoxColumn1"
Me.DNSHostNameDataGridViewTextBoxColumn1.ReadOnly = true
'
'DomainRoleDataGridViewTextBoxColumn
'
Me.DomainRoleDataGridViewTextBoxColumn.DataPropertyName = "DomainRole"
Me.DomainRoleDataGridViewTextBoxColumn.HeaderText = "DomainRole"
Me.DomainRoleDataGridViewTextBoxColumn.Name = "DomainRoleDataGridViewTextBoxColumn"
Me.DomainRoleDataGridViewTextBoxColumn.ReadOnly = true
'
'DaylightInEffectDataGridViewCheckBoxColumn
'
Me.DaylightInEffectDataGridViewCheckBoxColumn.DataPropertyName = "DaylightInEffect"
Me.DaylightInEffectDataGridViewCheckBoxColumn.HeaderText = "DaylightInEffect"
Me.DaylightInEffectDataGridViewCheckBoxColumn.Name = "DaylightInEffectDataGridViewCheckBoxColumn"
Me.DaylightInEffectDataGridViewCheckBoxColumn.ReadOnly = true
'
'DomainDataGridViewTextBoxColumn
'
Me.DomainDataGridViewTextBoxColumn.DataPropertyName = "Domain"
Me.DomainDataGridViewTextBoxColumn.HeaderText = "Domain"
Me.DomainDataGridViewTextBoxColumn.Name = "DomainDataGridViewTextBoxColumn"
Me.DomainDataGridViewTextBoxColumn.ReadOnly = true
'
'EnableDaylightSavingsTimeDataGridViewCheckBoxColumn
'
Me.EnableDaylightSavingsTimeDataGridViewCheckBoxColumn.DataPropertyName = "EnableDaylightSavingsTime"
Me.EnableDaylightSavingsTimeDataGridViewCheckBoxColumn.HeaderText = "EnableDaylightSavingsTime"
Me.EnableDaylightSavingsTimeDataGridViewCheckBoxColumn.Name = "EnableDaylightSavingsTimeDataGridViewCheckBoxColumn"
Me.EnableDaylightSavingsTimeDataGridViewCheckBoxColumn.ReadOnly = true
'
'FrontPanelResetStatusDataGridViewTextBoxColumn
'
Me.FrontPanelResetStatusDataGridViewTextBoxColumn.DataPropertyName = "FrontPanelResetStatus"
Me.FrontPanelResetStatusDataGridViewTextBoxColumn.HeaderText = "FrontPanelResetStatus"
Me.FrontPanelResetStatusDataGridViewTextBoxColumn.Name = "FrontPanelResetStatusDataGridViewTextBoxColumn"
Me.FrontPanelResetStatusDataGridViewTextBoxColumn.ReadOnly = true
'
'InfraredSupportedDataGridViewCheckBoxColumn
'
Me.InfraredSupportedDataGridViewCheckBoxColumn.DataPropertyName = "InfraredSupported"
Me.InfraredSupportedDataGridViewCheckBoxColumn.HeaderText = "InfraredSupported"
Me.InfraredSupportedDataGridViewCheckBoxColumn.Name = "InfraredSupportedDataGridViewCheckBoxColumn"
Me.InfraredSupportedDataGridViewCheckBoxColumn.ReadOnly = true
'
'InitialLoadInfoDataGridViewTextBoxColumn
'
Me.InitialLoadInfoDataGridViewTextBoxColumn.DataPropertyName = "InitialLoadInfo"
Me.InitialLoadInfoDataGridViewTextBoxColumn.HeaderText = "InitialLoadInfo"
Me.InitialLoadInfoDataGridViewTextBoxColumn.Name = "InitialLoadInfoDataGridViewTextBoxColumn"
Me.InitialLoadInfoDataGridViewTextBoxColumn.ReadOnly = true
'
'InstallDateDataGridViewTextBoxColumn11
'
Me.InstallDateDataGridViewTextBoxColumn11.DataPropertyName = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn11.HeaderText = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn11.Name = "InstallDateDataGridViewTextBoxColumn11"
Me.InstallDateDataGridViewTextBoxColumn11.ReadOnly = true
'
'KeyboardPasswordStatusDataGridViewTextBoxColumn
'
Me.KeyboardPasswordStatusDataGridViewTextBoxColumn.DataPropertyName = "KeyboardPasswordStatus"
Me.KeyboardPasswordStatusDataGridViewTextBoxColumn.HeaderText = "KeyboardPasswordStatus"
Me.KeyboardPasswordStatusDataGridViewTextBoxColumn.Name = "KeyboardPasswordStatusDataGridViewTextBoxColumn"
Me.KeyboardPasswordStatusDataGridViewTextBoxColumn.ReadOnly = true
'
'LastLoadInfoDataGridViewTextBoxColumn
'
Me.LastLoadInfoDataGridViewTextBoxColumn.DataPropertyName = "LastLoadInfo"
Me.LastLoadInfoDataGridViewTextBoxColumn.HeaderText = "LastLoadInfo"
Me.LastLoadInfoDataGridViewTextBoxColumn.Name = "LastLoadInfoDataGridViewTextBoxColumn"
Me.LastLoadInfoDataGridViewTextBoxColumn.ReadOnly = true
'
'NameDataGridViewTextBoxColumn11
'
Me.NameDataGridViewTextBoxColumn11.DataPropertyName = "Name"
Me.NameDataGridViewTextBoxColumn11.HeaderText = "Name"
Me.NameDataGridViewTextBoxColumn11.Name = "NameDataGridViewTextBoxColumn11"
Me.NameDataGridViewTextBoxColumn11.ReadOnly = true
'
'NameFormatDataGridViewTextBoxColumn
'
Me.NameFormatDataGridViewTextBoxColumn.DataPropertyName = "NameFormat"
Me.NameFormatDataGridViewTextBoxColumn.HeaderText = "NameFormat"
Me.NameFormatDataGridViewTextBoxColumn.Name = "NameFormatDataGridViewTextBoxColumn"
Me.NameFormatDataGridViewTextBoxColumn.ReadOnly = true
'
'NetworkServerModeEnabledDataGridViewCheckBoxColumn
'
Me.NetworkServerModeEnabledDataGridViewCheckBoxColumn.DataPropertyName = "NetworkServerModeEnabled"
Me.NetworkServerModeEnabledDataGridViewCheckBoxColumn.HeaderText = "NetworkServerModeEnabled"
Me.NetworkServerModeEnabledDataGridViewCheckBoxColumn.Name = "NetworkServerModeEnabledDataGridViewCheckBoxColumn"
Me.NetworkServerModeEnabledDataGridViewCheckBoxColumn.ReadOnly = true
'
'NumberOfLogicalProcessorsDataGridViewTextBoxColumn1
'
Me.NumberOfLogicalProcessorsDataGridViewTextBoxColumn1.DataPropertyName = "NumberOfLogicalProcessors"
Me.NumberOfLogicalProcessorsDataGridViewTextBoxColumn1.HeaderText = "NumberOfLogicalProcessors"
Me.NumberOfLogicalProcessorsDataGridViewTextBoxColumn1.Name = "NumberOfLogicalProcessorsDataGridViewTextBoxColumn1"
Me.NumberOfLogicalProcessorsDataGridViewTextBoxColumn1.ReadOnly = true
'
'NumberOfProcessorsDataGridViewTextBoxColumn
'
Me.NumberOfProcessorsDataGridViewTextBoxColumn.DataPropertyName = "NumberOfProcessors"
Me.NumberOfProcessorsDataGridViewTextBoxColumn.HeaderText = "NumberOfProcessors"
Me.NumberOfProcessorsDataGridViewTextBoxColumn.Name = "NumberOfProcessorsDataGridViewTextBoxColumn"
Me.NumberOfProcessorsDataGridViewTextBoxColumn.ReadOnly = true
'
'OEMLogoBitmapDataGridViewImageColumn
'
Me.OEMLogoBitmapDataGridViewImageColumn.DataPropertyName = "OEMLogoBitmap"
Me.OEMLogoBitmapDataGridViewImageColumn.HeaderText = "OEMLogoBitmap"
Me.OEMLogoBitmapDataGridViewImageColumn.Name = "OEMLogoBitmapDataGridViewImageColumn"
Me.OEMLogoBitmapDataGridViewImageColumn.ReadOnly = true
'
'PartOfDomainDataGridViewCheckBoxColumn
'
Me.PartOfDomainDataGridViewCheckBoxColumn.DataPropertyName = "PartOfDomain"
Me.PartOfDomainDataGridViewCheckBoxColumn.HeaderText = "PartOfDomain"
Me.PartOfDomainDataGridViewCheckBoxColumn.Name = "PartOfDomainDataGridViewCheckBoxColumn"
Me.PartOfDomainDataGridViewCheckBoxColumn.ReadOnly = true
'
'PauseAfterResetDataGridViewTextBoxColumn
'
Me.PauseAfterResetDataGridViewTextBoxColumn.DataPropertyName = "PauseAfterReset"
Me.PauseAfterResetDataGridViewTextBoxColumn.HeaderText = "PauseAfterReset"
Me.PauseAfterResetDataGridViewTextBoxColumn.Name = "PauseAfterResetDataGridViewTextBoxColumn"
Me.PauseAfterResetDataGridViewTextBoxColumn.ReadOnly = true
'
'PCSystemTypeDataGridViewTextBoxColumn
'
Me.PCSystemTypeDataGridViewTextBoxColumn.DataPropertyName = "PCSystemType"
Me.PCSystemTypeDataGridViewTextBoxColumn.HeaderText = "PCSystemType"
Me.PCSystemTypeDataGridViewTextBoxColumn.Name = "PCSystemTypeDataGridViewTextBoxColumn"
Me.PCSystemTypeDataGridViewTextBoxColumn.ReadOnly = true
'
'PowerManagementSupportedDataGridViewCheckBoxColumn7
'
Me.PowerManagementSupportedDataGridViewCheckBoxColumn7.DataPropertyName = "PowerManagementSupported"
Me.PowerManagementSupportedDataGridViewCheckBoxColumn7.HeaderText = "PowerManagementSupported"
Me.PowerManagementSupportedDataGridViewCheckBoxColumn7.Name = "PowerManagementSupportedDataGridViewCheckBoxColumn7"
Me.PowerManagementSupportedDataGridViewCheckBoxColumn7.ReadOnly = true
'
'PowerOnPasswordStatusDataGridViewTextBoxColumn
'
Me.PowerOnPasswordStatusDataGridViewTextBoxColumn.DataPropertyName = "PowerOnPasswordStatus"
Me.PowerOnPasswordStatusDataGridViewTextBoxColumn.HeaderText = "PowerOnPasswordStatus"
Me.PowerOnPasswordStatusDataGridViewTextBoxColumn.Name = "PowerOnPasswordStatusDataGridViewTextBoxColumn"
Me.PowerOnPasswordStatusDataGridViewTextBoxColumn.ReadOnly = true
'
'PowerStateDataGridViewTextBoxColumn
'
Me.PowerStateDataGridViewTextBoxColumn.DataPropertyName = "PowerState"
Me.PowerStateDataGridViewTextBoxColumn.HeaderText = "PowerState"
Me.PowerStateDataGridViewTextBoxColumn.Name = "PowerStateDataGridViewTextBoxColumn"
Me.PowerStateDataGridViewTextBoxColumn.ReadOnly = true
'
'PowerSupplyStateDataGridViewTextBoxColumn
'
Me.PowerSupplyStateDataGridViewTextBoxColumn.DataPropertyName = "PowerSupplyState"
Me.PowerSupplyStateDataGridViewTextBoxColumn.HeaderText = "PowerSupplyState"
Me.PowerSupplyStateDataGridViewTextBoxColumn.Name = "PowerSupplyStateDataGridViewTextBoxColumn"
Me.PowerSupplyStateDataGridViewTextBoxColumn.ReadOnly = true
'
'PrimaryOwnerContactDataGridViewTextBoxColumn
'
Me.PrimaryOwnerContactDataGridViewTextBoxColumn.DataPropertyName = "PrimaryOwnerContact"
Me.PrimaryOwnerContactDataGridViewTextBoxColumn.HeaderText = "PrimaryOwnerContact"
Me.PrimaryOwnerContactDataGridViewTextBoxColumn.Name = "PrimaryOwnerContactDataGridViewTextBoxColumn"
Me.PrimaryOwnerContactDataGridViewTextBoxColumn.ReadOnly = true
'
'PrimaryOwnerNameDataGridViewTextBoxColumn
'
Me.PrimaryOwnerNameDataGridViewTextBoxColumn.DataPropertyName = "PrimaryOwnerName"
Me.PrimaryOwnerNameDataGridViewTextBoxColumn.HeaderText = "PrimaryOwnerName"
Me.PrimaryOwnerNameDataGridViewTextBoxColumn.Name = "PrimaryOwnerNameDataGridViewTextBoxColumn"
Me.PrimaryOwnerNameDataGridViewTextBoxColumn.ReadOnly = true
'
'ResetCapabilityDataGridViewTextBoxColumn
'
Me.ResetCapabilityDataGridViewTextBoxColumn.DataPropertyName = "ResetCapability"
Me.ResetCapabilityDataGridViewTextBoxColumn.HeaderText = "ResetCapability"
Me.ResetCapabilityDataGridViewTextBoxColumn.Name = "ResetCapabilityDataGridViewTextBoxColumn"
Me.ResetCapabilityDataGridViewTextBoxColumn.ReadOnly = true
'
'ResetCountDataGridViewTextBoxColumn
'
Me.ResetCountDataGridViewTextBoxColumn.DataPropertyName = "ResetCount"
Me.ResetCountDataGridViewTextBoxColumn.HeaderText = "ResetCount"
Me.ResetCountDataGridViewTextBoxColumn.Name = "ResetCountDataGridViewTextBoxColumn"
Me.ResetCountDataGridViewTextBoxColumn.ReadOnly = true
'
'ResetLimitDataGridViewTextBoxColumn
'
Me.ResetLimitDataGridViewTextBoxColumn.DataPropertyName = "ResetLimit"
Me.ResetLimitDataGridViewTextBoxColumn.HeaderText = "ResetLimit"
Me.ResetLimitDataGridViewTextBoxColumn.Name = "ResetLimitDataGridViewTextBoxColumn"
Me.ResetLimitDataGridViewTextBoxColumn.ReadOnly = true
'
'StatusDataGridViewTextBoxColumn11
'
Me.StatusDataGridViewTextBoxColumn11.DataPropertyName = "Status"
Me.StatusDataGridViewTextBoxColumn11.HeaderText = "Status"
Me.StatusDataGridViewTextBoxColumn11.Name = "StatusDataGridViewTextBoxColumn11"
Me.StatusDataGridViewTextBoxColumn11.ReadOnly = true
'
'SystemStartupDelayDataGridViewTextBoxColumn
'
Me.SystemStartupDelayDataGridViewTextBoxColumn.DataPropertyName = "SystemStartupDelay"
Me.SystemStartupDelayDataGridViewTextBoxColumn.HeaderText = "SystemStartupDelay"
Me.SystemStartupDelayDataGridViewTextBoxColumn.Name = "SystemStartupDelayDataGridViewTextBoxColumn"
Me.SystemStartupDelayDataGridViewTextBoxColumn.ReadOnly = true
'
'SystemStartupSettingDataGridViewTextBoxColumn
'
Me.SystemStartupSettingDataGridViewTextBoxColumn.DataPropertyName = "SystemStartupSetting"
Me.SystemStartupSettingDataGridViewTextBoxColumn.HeaderText = "SystemStartupSetting"
Me.SystemStartupSettingDataGridViewTextBoxColumn.Name = "SystemStartupSettingDataGridViewTextBoxColumn"
Me.SystemStartupSettingDataGridViewTextBoxColumn.ReadOnly = true
'
'SystemTypeDataGridViewTextBoxColumn
'
Me.SystemTypeDataGridViewTextBoxColumn.DataPropertyName = "SystemType"
Me.SystemTypeDataGridViewTextBoxColumn.HeaderText = "SystemType"
Me.SystemTypeDataGridViewTextBoxColumn.Name = "SystemTypeDataGridViewTextBoxColumn"
Me.SystemTypeDataGridViewTextBoxColumn.ReadOnly = true
'
'ThermalStateDataGridViewTextBoxColumn
'
Me.ThermalStateDataGridViewTextBoxColumn.DataPropertyName = "ThermalState"
Me.ThermalStateDataGridViewTextBoxColumn.HeaderText = "ThermalState"
Me.ThermalStateDataGridViewTextBoxColumn.Name = "ThermalStateDataGridViewTextBoxColumn"
Me.ThermalStateDataGridViewTextBoxColumn.ReadOnly = true
'
'TotalPhysicalMemoryDataGridViewTextBoxColumn
'
Me.TotalPhysicalMemoryDataGridViewTextBoxColumn.DataPropertyName = "TotalPhysicalMemory"
Me.TotalPhysicalMemoryDataGridViewTextBoxColumn.HeaderText = "TotalPhysicalMemory"
Me.TotalPhysicalMemoryDataGridViewTextBoxColumn.Name = "TotalPhysicalMemoryDataGridViewTextBoxColumn"
Me.TotalPhysicalMemoryDataGridViewTextBoxColumn.ReadOnly = true
'
'UserNameDataGridViewTextBoxColumn
'
Me.UserNameDataGridViewTextBoxColumn.DataPropertyName = "UserName"
Me.UserNameDataGridViewTextBoxColumn.HeaderText = "UserName"
Me.UserNameDataGridViewTextBoxColumn.Name = "UserNameDataGridViewTextBoxColumn"
Me.UserNameDataGridViewTextBoxColumn.ReadOnly = true
'
'WakeUpTypeDataGridViewTextBoxColumn
'
Me.WakeUpTypeDataGridViewTextBoxColumn.DataPropertyName = "WakeUpType"
Me.WakeUpTypeDataGridViewTextBoxColumn.HeaderText = "WakeUpType"
Me.WakeUpTypeDataGridViewTextBoxColumn.Name = "WakeUpTypeDataGridViewTextBoxColumn"
Me.WakeUpTypeDataGridViewTextBoxColumn.ReadOnly = true
'
'WorkgroupDataGridViewTextBoxColumn
'
Me.WorkgroupDataGridViewTextBoxColumn.DataPropertyName = "Workgroup"
Me.WorkgroupDataGridViewTextBoxColumn.HeaderText = "Workgroup"
Me.WorkgroupDataGridViewTextBoxColumn.Name = "WorkgroupDataGridViewTextBoxColumn"
Me.WorkgroupDataGridViewTextBoxColumn.ReadOnly = true
'
'Win32ComputerSystemBindingSource
'
Me.Win32ComputerSystemBindingSource.DataSource = GetType(WMIwrapper.Win32_ComputerSystem)
'
'PanelKeyboard
'
Me.PanelKeyboard.Controls.Add(Me.dgvKeyboard)
Me.PanelKeyboard.Dock = System.Windows.Forms.DockStyle.Fill
Me.PanelKeyboard.Location = New System.Drawing.Point(0, 0)
Me.PanelKeyboard.Name = "PanelKeyboard"
Me.PanelKeyboard.Size = New System.Drawing.Size(468, 183)
Me.PanelKeyboard.TabIndex = 1
'
'dgvKeyboard
'
Me.dgvKeyboard.AllowUserToAddRows = false
Me.dgvKeyboard.AllowUserToDeleteRows = false
Me.dgvKeyboard.AutoGenerateColumns = false
Me.dgvKeyboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
Me.dgvKeyboard.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Password, Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn9, Me.DataGridViewCheckBoxColumn3, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn10, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn30, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn25})
Me.dgvKeyboard.DataSource = Me.Win32KeyboardBindingSource
Me.dgvKeyboard.Dock = System.Windows.Forms.DockStyle.Fill
Me.dgvKeyboard.Location = New System.Drawing.Point(0, 0)
Me.dgvKeyboard.Name = "dgvKeyboard"
Me.dgvKeyboard.ReadOnly = true
Me.dgvKeyboard.Size = New System.Drawing.Size(468, 183)
Me.dgvKeyboard.TabIndex = 22
'
'Password
'
Me.Password.DataPropertyName = "Password"
Me.Password.HeaderText = "Password"
Me.Password.Name = "Password"
Me.Password.ReadOnly = true
'
'DataGridViewTextBoxColumn43
'
Me.DataGridViewTextBoxColumn43.DataPropertyName = "Availability"
Me.DataGridViewTextBoxColumn43.HeaderText = "Availability"
Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
Me.DataGridViewTextBoxColumn43.ReadOnly = true
'
'DataGridViewTextBoxColumn32
'
Me.DataGridViewTextBoxColumn32.DataPropertyName = "Caption"
Me.DataGridViewTextBoxColumn32.HeaderText = "Caption"
Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
Me.DataGridViewTextBoxColumn32.ReadOnly = true
'
'DataGridViewTextBoxColumn36
'
Me.DataGridViewTextBoxColumn36.DataPropertyName = "ConfigManagerError"
Me.DataGridViewTextBoxColumn36.HeaderText = "ConfigManagerError"
Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
Me.DataGridViewTextBoxColumn36.ReadOnly = true
'
'DataGridViewTextBoxColumn9
'
Me.DataGridViewTextBoxColumn9.DataPropertyName = "ConfigManagerErrorCode"
Me.DataGridViewTextBoxColumn9.HeaderText = "ConfigManagerErrorCode"
Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
Me.DataGridViewTextBoxColumn9.ReadOnly = true
'
'DataGridViewCheckBoxColumn3
'
Me.DataGridViewCheckBoxColumn3.DataPropertyName = "ConfigManagerUserConfig"
Me.DataGridViewCheckBoxColumn3.HeaderText = "ConfigManagerUserConfig"
Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
Me.DataGridViewCheckBoxColumn3.ReadOnly = true
'
'DataGridViewTextBoxColumn27
'
Me.DataGridViewTextBoxColumn27.DataPropertyName = "CreationClassName"
Me.DataGridViewTextBoxColumn27.HeaderText = "CreationClassName"
Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
Me.DataGridViewTextBoxColumn27.ReadOnly = true
'
'DataGridViewTextBoxColumn38
'
Me.DataGridViewTextBoxColumn38.DataPropertyName = "Description"
Me.DataGridViewTextBoxColumn38.HeaderText = "Description"
Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
Me.DataGridViewTextBoxColumn38.ReadOnly = true
'
'DataGridViewTextBoxColumn10
'
Me.DataGridViewTextBoxColumn10.DataPropertyName = "DeviceID"
Me.DataGridViewTextBoxColumn10.HeaderText = "DeviceID"
Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
Me.DataGridViewTextBoxColumn10.ReadOnly = true
'
'DataGridViewCheckBoxColumn2
'
Me.DataGridViewCheckBoxColumn2.DataPropertyName = "ErrorCleared"
Me.DataGridViewCheckBoxColumn2.HeaderText = "ErrorCleared"
Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
Me.DataGridViewCheckBoxColumn2.ReadOnly = true
'
'DataGridViewTextBoxColumn8
'
Me.DataGridViewTextBoxColumn8.DataPropertyName = "ErrorDescription"
Me.DataGridViewTextBoxColumn8.HeaderText = "ErrorDescription"
Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
Me.DataGridViewTextBoxColumn8.ReadOnly = true
'
'DataGridViewTextBoxColumn12
'
Me.DataGridViewTextBoxColumn12.DataPropertyName = "InstallDate"
Me.DataGridViewTextBoxColumn12.HeaderText = "InstallDate"
Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
Me.DataGridViewTextBoxColumn12.ReadOnly = true
'
'DataGridViewTextBoxColumn1
'
Me.DataGridViewTextBoxColumn1.DataPropertyName = "LastErrorCode"
Me.DataGridViewTextBoxColumn1.HeaderText = "LastErrorCode"
Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
Me.DataGridViewTextBoxColumn1.ReadOnly = true
'
'DataGridViewTextBoxColumn15
'
Me.DataGridViewTextBoxColumn15.DataPropertyName = "Name"
Me.DataGridViewTextBoxColumn15.HeaderText = "Name"
Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
Me.DataGridViewTextBoxColumn15.ReadOnly = true
'
'DataGridViewTextBoxColumn30
'
Me.DataGridViewTextBoxColumn30.DataPropertyName = "PNPDeviceID"
Me.DataGridViewTextBoxColumn30.HeaderText = "PNPDeviceID"
Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
Me.DataGridViewTextBoxColumn30.ReadOnly = true
'
'DataGridViewCheckBoxColumn1
'
Me.DataGridViewCheckBoxColumn1.DataPropertyName = "PowerManagementSupported"
Me.DataGridViewCheckBoxColumn1.HeaderText = "PowerManagementSupported"
Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
Me.DataGridViewCheckBoxColumn1.ReadOnly = true
'
'DataGridViewTextBoxColumn21
'
Me.DataGridViewTextBoxColumn21.DataPropertyName = "Status"
Me.DataGridViewTextBoxColumn21.HeaderText = "Status"
Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
Me.DataGridViewTextBoxColumn21.ReadOnly = true
'
'DataGridViewTextBoxColumn24
'
Me.DataGridViewTextBoxColumn24.DataPropertyName = "StatusInfo"
Me.DataGridViewTextBoxColumn24.HeaderText = "StatusInfo"
Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
Me.DataGridViewTextBoxColumn24.ReadOnly = true
'
'DataGridViewTextBoxColumn5
'
Me.DataGridViewTextBoxColumn5.DataPropertyName = "SystemCreationClassName"
Me.DataGridViewTextBoxColumn5.HeaderText = "SystemCreationClassName"
Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
Me.DataGridViewTextBoxColumn5.ReadOnly = true
'
'DataGridViewTextBoxColumn25
'
Me.DataGridViewTextBoxColumn25.DataPropertyName = "SystemName"
Me.DataGridViewTextBoxColumn25.HeaderText = "SystemName"
Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
Me.DataGridViewTextBoxColumn25.ReadOnly = true
'
'Win32KeyboardBindingSource
'
Me.Win32KeyboardBindingSource.DataSource = GetType(WMIwrapper.Win32_Keyboard)
'
'PanelPnPSignedDrivers
'
Me.PanelPnPSignedDrivers.Controls.Add(Me.dgvPnPSignedDrivers)
Me.PanelPnPSignedDrivers.Dock = System.Windows.Forms.DockStyle.Fill
Me.PanelPnPSignedDrivers.Location = New System.Drawing.Point(0, 0)
Me.PanelPnPSignedDrivers.Name = "PanelPnPSignedDrivers"
Me.PanelPnPSignedDrivers.Size = New System.Drawing.Size(468, 183)
Me.PanelPnPSignedDrivers.TabIndex = 16
'
'dgvPnPSignedDrivers
'
Me.dgvPnPSignedDrivers.AllowUserToAddRows = false
Me.dgvPnPSignedDrivers.AllowUserToDeleteRows = false
Me.dgvPnPSignedDrivers.AutoGenerateColumns = false
Me.dgvPnPSignedDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
Me.dgvPnPSignedDrivers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DriverProviderName, Me.CaptionDataGridViewTextBoxColumn11, Me.ClassGuidDataGridViewTextBoxColumn1, Me.CompatIDDataGridViewTextBoxColumn, Me.CreationClassNameDataGridViewTextBoxColumn9, Me.DescriptionDataGridViewTextBoxColumn12, Me.DeviceIDDataGridViewTextBoxColumn7, Me.DevLoaderDataGridViewTextBoxColumn, Me.DeviceNameDataGridViewTextBoxColumn, Me.DeviceClassDataGridViewTextBoxColumn, Me.DriverDateDataGridViewTextBoxColumn, Me.DriverNameDataGridViewTextBoxColumn, Me.DriverVersionDataGridViewTextBoxColumn, Me.FriendlyNameDataGridViewTextBoxColumn, Me.HardWareIDDataGridViewTextBoxColumn, Me.InfNameDataGridViewTextBoxColumn, Me.InstallDateDataGridViewTextBoxColumn10, Me.IsSignedDataGridViewCheckBoxColumn, Me.LocationDataGridViewTextBoxColumn, Me.ManufacturerDataGridViewTextBoxColumn5, Me.NameDataGridViewTextBoxColumn10, Me.PDODataGridViewTextBoxColumn, Me.SignerDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn10, Me.StartedDataGridViewCheckBoxColumn1, Me.StartModeDataGridViewTextBoxColumn1, Me.SystemCreationClassNameDataGridViewTextBoxColumn8, Me.SystemNameDataGridViewTextBoxColumn8})
Me.dgvPnPSignedDrivers.DataSource = Me.Win32PnPSignedDriverBindingSource
Me.dgvPnPSignedDrivers.Dock = System.Windows.Forms.DockStyle.Fill
Me.dgvPnPSignedDrivers.Location = New System.Drawing.Point(0, 0)
Me.dgvPnPSignedDrivers.Name = "dgvPnPSignedDrivers"
Me.dgvPnPSignedDrivers.ReadOnly = true
Me.dgvPnPSignedDrivers.Size = New System.Drawing.Size(468, 183)
Me.dgvPnPSignedDrivers.TabIndex = 22
'
'DriverProviderName
'
Me.DriverProviderName.DataPropertyName = "DriverProviderName"
Me.DriverProviderName.HeaderText = "DriverProviderName"
Me.DriverProviderName.Name = "DriverProviderName"
Me.DriverProviderName.ReadOnly = true
'
'CaptionDataGridViewTextBoxColumn11
'
Me.CaptionDataGridViewTextBoxColumn11.DataPropertyName = "Caption"
Me.CaptionDataGridViewTextBoxColumn11.HeaderText = "Caption"
Me.CaptionDataGridViewTextBoxColumn11.Name = "CaptionDataGridViewTextBoxColumn11"
Me.CaptionDataGridViewTextBoxColumn11.ReadOnly = true
'
'ClassGuidDataGridViewTextBoxColumn1
'
Me.ClassGuidDataGridViewTextBoxColumn1.DataPropertyName = "ClassGuid"
Me.ClassGuidDataGridViewTextBoxColumn1.HeaderText = "ClassGuid"
Me.ClassGuidDataGridViewTextBoxColumn1.Name = "ClassGuidDataGridViewTextBoxColumn1"
Me.ClassGuidDataGridViewTextBoxColumn1.ReadOnly = true
'
'CompatIDDataGridViewTextBoxColumn
'
Me.CompatIDDataGridViewTextBoxColumn.DataPropertyName = "CompatID"
Me.CompatIDDataGridViewTextBoxColumn.HeaderText = "CompatID"
Me.CompatIDDataGridViewTextBoxColumn.Name = "CompatIDDataGridViewTextBoxColumn"
Me.CompatIDDataGridViewTextBoxColumn.ReadOnly = true
'
'CreationClassNameDataGridViewTextBoxColumn9
'
Me.CreationClassNameDataGridViewTextBoxColumn9.DataPropertyName = "CreationClassName"
Me.CreationClassNameDataGridViewTextBoxColumn9.HeaderText = "CreationClassName"
Me.CreationClassNameDataGridViewTextBoxColumn9.Name = "CreationClassNameDataGridViewTextBoxColumn9"
Me.CreationClassNameDataGridViewTextBoxColumn9.ReadOnly = true
'
'DescriptionDataGridViewTextBoxColumn12
'
Me.DescriptionDataGridViewTextBoxColumn12.DataPropertyName = "Description"
Me.DescriptionDataGridViewTextBoxColumn12.HeaderText = "Description"
Me.DescriptionDataGridViewTextBoxColumn12.Name = "DescriptionDataGridViewTextBoxColumn12"
Me.DescriptionDataGridViewTextBoxColumn12.ReadOnly = true
'
'DeviceIDDataGridViewTextBoxColumn7
'
Me.DeviceIDDataGridViewTextBoxColumn7.DataPropertyName = "DeviceID"
Me.DeviceIDDataGridViewTextBoxColumn7.HeaderText = "DeviceID"
Me.DeviceIDDataGridViewTextBoxColumn7.Name = "DeviceIDDataGridViewTextBoxColumn7"
Me.DeviceIDDataGridViewTextBoxColumn7.ReadOnly = true
'
'DevLoaderDataGridViewTextBoxColumn
'
Me.DevLoaderDataGridViewTextBoxColumn.DataPropertyName = "DevLoader"
Me.DevLoaderDataGridViewTextBoxColumn.HeaderText = "DevLoader"
Me.DevLoaderDataGridViewTextBoxColumn.Name = "DevLoaderDataGridViewTextBoxColumn"
Me.DevLoaderDataGridViewTextBoxColumn.ReadOnly = true
'
'DeviceNameDataGridViewTextBoxColumn
'
Me.DeviceNameDataGridViewTextBoxColumn.DataPropertyName = "DeviceName"
Me.DeviceNameDataGridViewTextBoxColumn.HeaderText = "DeviceName"
Me.DeviceNameDataGridViewTextBoxColumn.Name = "DeviceNameDataGridViewTextBoxColumn"
Me.DeviceNameDataGridViewTextBoxColumn.ReadOnly = true
'
'DeviceClassDataGridViewTextBoxColumn
'
Me.DeviceClassDataGridViewTextBoxColumn.DataPropertyName = "DeviceClass"
Me.DeviceClassDataGridViewTextBoxColumn.HeaderText = "DeviceClass"
Me.DeviceClassDataGridViewTextBoxColumn.Name = "DeviceClassDataGridViewTextBoxColumn"
Me.DeviceClassDataGridViewTextBoxColumn.ReadOnly = true
'
'DriverDateDataGridViewTextBoxColumn
'
Me.DriverDateDataGridViewTextBoxColumn.DataPropertyName = "DriverDate"
Me.DriverDateDataGridViewTextBoxColumn.HeaderText = "DriverDate"
Me.DriverDateDataGridViewTextBoxColumn.Name = "DriverDateDataGridViewTextBoxColumn"
Me.DriverDateDataGridViewTextBoxColumn.ReadOnly = true
'
'DriverNameDataGridViewTextBoxColumn
'
Me.DriverNameDataGridViewTextBoxColumn.DataPropertyName = "DriverName"
Me.DriverNameDataGridViewTextBoxColumn.HeaderText = "DriverName"
Me.DriverNameDataGridViewTextBoxColumn.Name = "DriverNameDataGridViewTextBoxColumn"
Me.DriverNameDataGridViewTextBoxColumn.ReadOnly = true
'
'DriverVersionDataGridViewTextBoxColumn
'
Me.DriverVersionDataGridViewTextBoxColumn.DataPropertyName = "DriverVersion"
Me.DriverVersionDataGridViewTextBoxColumn.HeaderText = "DriverVersion"
Me.DriverVersionDataGridViewTextBoxColumn.Name = "DriverVersionDataGridViewTextBoxColumn"
Me.DriverVersionDataGridViewTextBoxColumn.ReadOnly = true
'
'FriendlyNameDataGridViewTextBoxColumn
'
Me.FriendlyNameDataGridViewTextBoxColumn.DataPropertyName = "FriendlyName"
Me.FriendlyNameDataGridViewTextBoxColumn.HeaderText = "FriendlyName"
Me.FriendlyNameDataGridViewTextBoxColumn.Name = "FriendlyNameDataGridViewTextBoxColumn"
Me.FriendlyNameDataGridViewTextBoxColumn.ReadOnly = true
'
'HardWareIDDataGridViewTextBoxColumn
'
Me.HardWareIDDataGridViewTextBoxColumn.DataPropertyName = "HardWareID"
Me.HardWareIDDataGridViewTextBoxColumn.HeaderText = "HardWareID"
Me.HardWareIDDataGridViewTextBoxColumn.Name = "HardWareIDDataGridViewTextBoxColumn"
Me.HardWareIDDataGridViewTextBoxColumn.ReadOnly = true
'
'InfNameDataGridViewTextBoxColumn
'
Me.InfNameDataGridViewTextBoxColumn.DataPropertyName = "InfName"
Me.InfNameDataGridViewTextBoxColumn.HeaderText = "InfName"
Me.InfNameDataGridViewTextBoxColumn.Name = "InfNameDataGridViewTextBoxColumn"
Me.InfNameDataGridViewTextBoxColumn.ReadOnly = true
'
'InstallDateDataGridViewTextBoxColumn10
'
Me.InstallDateDataGridViewTextBoxColumn10.DataPropertyName = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn10.HeaderText = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn10.Name = "InstallDateDataGridViewTextBoxColumn10"
Me.InstallDateDataGridViewTextBoxColumn10.ReadOnly = true
'
'IsSignedDataGridViewCheckBoxColumn
'
Me.IsSignedDataGridViewCheckBoxColumn.DataPropertyName = "IsSigned"
Me.IsSignedDataGridViewCheckBoxColumn.HeaderText = "IsSigned"
Me.IsSignedDataGridViewCheckBoxColumn.Name = "IsSignedDataGridViewCheckBoxColumn"
Me.IsSignedDataGridViewCheckBoxColumn.ReadOnly = true
'
'LocationDataGridViewTextBoxColumn
'
Me.LocationDataGridViewTextBoxColumn.DataPropertyName = "Location"
Me.LocationDataGridViewTextBoxColumn.HeaderText = "Location"
Me.LocationDataGridViewTextBoxColumn.Name = "LocationDataGridViewTextBoxColumn"
Me.LocationDataGridViewTextBoxColumn.ReadOnly = true
'
'ManufacturerDataGridViewTextBoxColumn5
'
Me.ManufacturerDataGridViewTextBoxColumn5.DataPropertyName = "Manufacturer"
Me.ManufacturerDataGridViewTextBoxColumn5.HeaderText = "Manufacturer"
Me.ManufacturerDataGridViewTextBoxColumn5.Name = "ManufacturerDataGridViewTextBoxColumn5"
Me.ManufacturerDataGridViewTextBoxColumn5.ReadOnly = true
'
'NameDataGridViewTextBoxColumn10
'
Me.NameDataGridViewTextBoxColumn10.DataPropertyName = "Name"
Me.NameDataGridViewTextBoxColumn10.HeaderText = "Name"
Me.NameDataGridViewTextBoxColumn10.Name = "NameDataGridViewTextBoxColumn10"
Me.NameDataGridViewTextBoxColumn10.ReadOnly = true
'
'PDODataGridViewTextBoxColumn
'
Me.PDODataGridViewTextBoxColumn.DataPropertyName = "PDO"
Me.PDODataGridViewTextBoxColumn.HeaderText = "PDO"
Me.PDODataGridViewTextBoxColumn.Name = "PDODataGridViewTextBoxColumn"
Me.PDODataGridViewTextBoxColumn.ReadOnly = true
'
'SignerDataGridViewTextBoxColumn
'
Me.SignerDataGridViewTextBoxColumn.DataPropertyName = "Signer"
Me.SignerDataGridViewTextBoxColumn.HeaderText = "Signer"
Me.SignerDataGridViewTextBoxColumn.Name = "SignerDataGridViewTextBoxColumn"
Me.SignerDataGridViewTextBoxColumn.ReadOnly = true
'
'StatusDataGridViewTextBoxColumn10
'
Me.StatusDataGridViewTextBoxColumn10.DataPropertyName = "Status"
Me.StatusDataGridViewTextBoxColumn10.HeaderText = "Status"
Me.StatusDataGridViewTextBoxColumn10.Name = "StatusDataGridViewTextBoxColumn10"
Me.StatusDataGridViewTextBoxColumn10.ReadOnly = true
'
'StartedDataGridViewCheckBoxColumn1
'
Me.StartedDataGridViewCheckBoxColumn1.DataPropertyName = "Started"
Me.StartedDataGridViewCheckBoxColumn1.HeaderText = "Started"
Me.StartedDataGridViewCheckBoxColumn1.Name = "StartedDataGridViewCheckBoxColumn1"
Me.StartedDataGridViewCheckBoxColumn1.ReadOnly = true
'
'StartModeDataGridViewTextBoxColumn1
'
Me.StartModeDataGridViewTextBoxColumn1.DataPropertyName = "StartMode"
Me.StartModeDataGridViewTextBoxColumn1.HeaderText = "StartMode"
Me.StartModeDataGridViewTextBoxColumn1.Name = "StartModeDataGridViewTextBoxColumn1"
Me.StartModeDataGridViewTextBoxColumn1.ReadOnly = true
'
'SystemCreationClassNameDataGridViewTextBoxColumn8
'
Me.SystemCreationClassNameDataGridViewTextBoxColumn8.DataPropertyName = "SystemCreationClassName"
Me.SystemCreationClassNameDataGridViewTextBoxColumn8.HeaderText = "SystemCreationClassName"
Me.SystemCreationClassNameDataGridViewTextBoxColumn8.Name = "SystemCreationClassNameDataGridViewTextBoxColumn8"
Me.SystemCreationClassNameDataGridViewTextBoxColumn8.ReadOnly = true
'
'SystemNameDataGridViewTextBoxColumn8
'
Me.SystemNameDataGridViewTextBoxColumn8.DataPropertyName = "SystemName"
Me.SystemNameDataGridViewTextBoxColumn8.HeaderText = "SystemName"
Me.SystemNameDataGridViewTextBoxColumn8.Name = "SystemNameDataGridViewTextBoxColumn8"
Me.SystemNameDataGridViewTextBoxColumn8.ReadOnly = true
'
'Win32PnPSignedDriverBindingSource
'
Me.Win32PnPSignedDriverBindingSource.DataSource = GetType(WMIwrapper.Win32_PnPSignedDriver)
'
'PanelSystemDrivers
'
Me.PanelSystemDrivers.Controls.Add(Me.dgvSystemDrivers)
Me.PanelSystemDrivers.Dock = System.Windows.Forms.DockStyle.Fill
Me.PanelSystemDrivers.Location = New System.Drawing.Point(0, 0)
Me.PanelSystemDrivers.Name = "PanelSystemDrivers"
Me.PanelSystemDrivers.Size = New System.Drawing.Size(468, 183)
Me.PanelSystemDrivers.TabIndex = 15
'
'dgvSystemDrivers
'
Me.dgvSystemDrivers.AllowUserToAddRows = false
Me.dgvSystemDrivers.AllowUserToDeleteRows = false
Me.dgvSystemDrivers.AutoGenerateColumns = false
Me.dgvSystemDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
Me.dgvSystemDrivers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AcceptPauseDataGridViewCheckBoxColumn, Me.AcceptStopDataGridViewCheckBoxColumn, Me.CaptionDataGridViewTextBoxColumn10, Me.CreationClassNameDataGridViewTextBoxColumn8, Me.DescriptionDataGridViewTextBoxColumn11, Me.DesktopInteractDataGridViewCheckBoxColumn, Me.DisplayNameDataGridViewTextBoxColumn, Me.ErrorControlDataGridViewTextBoxColumn, Me.ExitCodeDataGridViewTextBoxColumn, Me.InstallDateDataGridViewTextBoxColumn9, Me.PathNameDataGridViewTextBoxColumn, Me.ServiceSpecificExitCodeDataGridViewTextBoxColumn, Me.ServiceTypeDataGridViewTextBoxColumn, Me.StartedDataGridViewCheckBoxColumn, Me.NameDataGridViewTextBoxColumn9, Me.StartModeDataGridViewTextBoxColumn, Me.StartNameDataGridViewTextBoxColumn, Me.StateDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn9, Me.SystemCreationClassNameDataGridViewTextBoxColumn7, Me.SystemNameDataGridViewTextBoxColumn7, Me.TagIdDataGridViewTextBoxColumn})
Me.dgvSystemDrivers.DataSource = Me.Win32SystemDriverBindingSource
Me.dgvSystemDrivers.Dock = System.Windows.Forms.DockStyle.Fill
Me.dgvSystemDrivers.Location = New System.Drawing.Point(0, 0)
Me.dgvSystemDrivers.Name = "dgvSystemDrivers"
Me.dgvSystemDrivers.ReadOnly = true
Me.dgvSystemDrivers.Size = New System.Drawing.Size(468, 183)
Me.dgvSystemDrivers.TabIndex = 22
'
'AcceptPauseDataGridViewCheckBoxColumn
'
Me.AcceptPauseDataGridViewCheckBoxColumn.DataPropertyName = "AcceptPause"
Me.AcceptPauseDataGridViewCheckBoxColumn.HeaderText = "AcceptPause"
Me.AcceptPauseDataGridViewCheckBoxColumn.Name = "AcceptPauseDataGridViewCheckBoxColumn"
Me.AcceptPauseDataGridViewCheckBoxColumn.ReadOnly = true
'
'AcceptStopDataGridViewCheckBoxColumn
'
Me.AcceptStopDataGridViewCheckBoxColumn.DataPropertyName = "AcceptStop"
Me.AcceptStopDataGridViewCheckBoxColumn.HeaderText = "AcceptStop"
Me.AcceptStopDataGridViewCheckBoxColumn.Name = "AcceptStopDataGridViewCheckBoxColumn"
Me.AcceptStopDataGridViewCheckBoxColumn.ReadOnly = true
'
'CaptionDataGridViewTextBoxColumn10
'
Me.CaptionDataGridViewTextBoxColumn10.DataPropertyName = "Caption"
Me.CaptionDataGridViewTextBoxColumn10.HeaderText = "Caption"
Me.CaptionDataGridViewTextBoxColumn10.Name = "CaptionDataGridViewTextBoxColumn10"
Me.CaptionDataGridViewTextBoxColumn10.ReadOnly = true
'
'CreationClassNameDataGridViewTextBoxColumn8
'
Me.CreationClassNameDataGridViewTextBoxColumn8.DataPropertyName = "CreationClassName"
Me.CreationClassNameDataGridViewTextBoxColumn8.HeaderText = "CreationClassName"
Me.CreationClassNameDataGridViewTextBoxColumn8.Name = "CreationClassNameDataGridViewTextBoxColumn8"
Me.CreationClassNameDataGridViewTextBoxColumn8.ReadOnly = true
'
'DescriptionDataGridViewTextBoxColumn11
'
Me.DescriptionDataGridViewTextBoxColumn11.DataPropertyName = "Description"
Me.DescriptionDataGridViewTextBoxColumn11.HeaderText = "Description"
Me.DescriptionDataGridViewTextBoxColumn11.Name = "DescriptionDataGridViewTextBoxColumn11"
Me.DescriptionDataGridViewTextBoxColumn11.ReadOnly = true
'
'DesktopInteractDataGridViewCheckBoxColumn
'
Me.DesktopInteractDataGridViewCheckBoxColumn.DataPropertyName = "DesktopInteract"
Me.DesktopInteractDataGridViewCheckBoxColumn.HeaderText = "DesktopInteract"
Me.DesktopInteractDataGridViewCheckBoxColumn.Name = "DesktopInteractDataGridViewCheckBoxColumn"
Me.DesktopInteractDataGridViewCheckBoxColumn.ReadOnly = true
'
'DisplayNameDataGridViewTextBoxColumn
'
Me.DisplayNameDataGridViewTextBoxColumn.DataPropertyName = "DisplayName"
Me.DisplayNameDataGridViewTextBoxColumn.HeaderText = "DisplayName"
Me.DisplayNameDataGridViewTextBoxColumn.Name = "DisplayNameDataGridViewTextBoxColumn"
Me.DisplayNameDataGridViewTextBoxColumn.ReadOnly = true
'
'ErrorControlDataGridViewTextBoxColumn
'
Me.ErrorControlDataGridViewTextBoxColumn.DataPropertyName = "ErrorControl"
Me.ErrorControlDataGridViewTextBoxColumn.HeaderText = "ErrorControl"
Me.ErrorControlDataGridViewTextBoxColumn.Name = "ErrorControlDataGridViewTextBoxColumn"
Me.ErrorControlDataGridViewTextBoxColumn.ReadOnly = true
'
'ExitCodeDataGridViewTextBoxColumn
'
Me.ExitCodeDataGridViewTextBoxColumn.DataPropertyName = "ExitCode"
Me.ExitCodeDataGridViewTextBoxColumn.HeaderText = "ExitCode"
Me.ExitCodeDataGridViewTextBoxColumn.Name = "ExitCodeDataGridViewTextBoxColumn"
Me.ExitCodeDataGridViewTextBoxColumn.ReadOnly = true
'
'InstallDateDataGridViewTextBoxColumn9
'
Me.InstallDateDataGridViewTextBoxColumn9.DataPropertyName = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn9.HeaderText = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn9.Name = "InstallDateDataGridViewTextBoxColumn9"
Me.InstallDateDataGridViewTextBoxColumn9.ReadOnly = true
'
'PathNameDataGridViewTextBoxColumn
'
Me.PathNameDataGridViewTextBoxColumn.DataPropertyName = "PathName"
Me.PathNameDataGridViewTextBoxColumn.HeaderText = "PathName"
Me.PathNameDataGridViewTextBoxColumn.Name = "PathNameDataGridViewTextBoxColumn"
Me.PathNameDataGridViewTextBoxColumn.ReadOnly = true
'
'ServiceSpecificExitCodeDataGridViewTextBoxColumn
'
Me.ServiceSpecificExitCodeDataGridViewTextBoxColumn.DataPropertyName = "ServiceSpecificExitCode"
Me.ServiceSpecificExitCodeDataGridViewTextBoxColumn.HeaderText = "ServiceSpecificExitCode"
Me.ServiceSpecificExitCodeDataGridViewTextBoxColumn.Name = "ServiceSpecificExitCodeDataGridViewTextBoxColumn"
Me.ServiceSpecificExitCodeDataGridViewTextBoxColumn.ReadOnly = true
'
'ServiceTypeDataGridViewTextBoxColumn
'
Me.ServiceTypeDataGridViewTextBoxColumn.DataPropertyName = "ServiceType"
Me.ServiceTypeDataGridViewTextBoxColumn.HeaderText = "ServiceType"
Me.ServiceTypeDataGridViewTextBoxColumn.Name = "ServiceTypeDataGridViewTextBoxColumn"
Me.ServiceTypeDataGridViewTextBoxColumn.ReadOnly = true
'
'StartedDataGridViewCheckBoxColumn
'
Me.StartedDataGridViewCheckBoxColumn.DataPropertyName = "Started"
Me.StartedDataGridViewCheckBoxColumn.HeaderText = "Started"
Me.StartedDataGridViewCheckBoxColumn.Name = "StartedDataGridViewCheckBoxColumn"
Me.StartedDataGridViewCheckBoxColumn.ReadOnly = true
'
'NameDataGridViewTextBoxColumn9
'
Me.NameDataGridViewTextBoxColumn9.DataPropertyName = "Name"
Me.NameDataGridViewTextBoxColumn9.HeaderText = "Name"
Me.NameDataGridViewTextBoxColumn9.Name = "NameDataGridViewTextBoxColumn9"
Me.NameDataGridViewTextBoxColumn9.ReadOnly = true
'
'StartModeDataGridViewTextBoxColumn
'
Me.StartModeDataGridViewTextBoxColumn.DataPropertyName = "StartMode"
Me.StartModeDataGridViewTextBoxColumn.HeaderText = "StartMode"
Me.StartModeDataGridViewTextBoxColumn.Name = "StartModeDataGridViewTextBoxColumn"
Me.StartModeDataGridViewTextBoxColumn.ReadOnly = true
'
'StartNameDataGridViewTextBoxColumn
'
Me.StartNameDataGridViewTextBoxColumn.DataPropertyName = "StartName"
Me.StartNameDataGridViewTextBoxColumn.HeaderText = "StartName"
Me.StartNameDataGridViewTextBoxColumn.Name = "StartNameDataGridViewTextBoxColumn"
Me.StartNameDataGridViewTextBoxColumn.ReadOnly = true
'
'StateDataGridViewTextBoxColumn
'
Me.StateDataGridViewTextBoxColumn.DataPropertyName = "State"
Me.StateDataGridViewTextBoxColumn.HeaderText = "State"
Me.StateDataGridViewTextBoxColumn.Name = "StateDataGridViewTextBoxColumn"
Me.StateDataGridViewTextBoxColumn.ReadOnly = true
'
'StatusDataGridViewTextBoxColumn9
'
Me.StatusDataGridViewTextBoxColumn9.DataPropertyName = "Status"
Me.StatusDataGridViewTextBoxColumn9.HeaderText = "Status"
Me.StatusDataGridViewTextBoxColumn9.Name = "StatusDataGridViewTextBoxColumn9"
Me.StatusDataGridViewTextBoxColumn9.ReadOnly = true
'
'SystemCreationClassNameDataGridViewTextBoxColumn7
'
Me.SystemCreationClassNameDataGridViewTextBoxColumn7.DataPropertyName = "SystemCreationClassName"
Me.SystemCreationClassNameDataGridViewTextBoxColumn7.HeaderText = "SystemCreationClassName"
Me.SystemCreationClassNameDataGridViewTextBoxColumn7.Name = "SystemCreationClassNameDataGridViewTextBoxColumn7"
Me.SystemCreationClassNameDataGridViewTextBoxColumn7.ReadOnly = true
'
'SystemNameDataGridViewTextBoxColumn7
'
Me.SystemNameDataGridViewTextBoxColumn7.DataPropertyName = "SystemName"
Me.SystemNameDataGridViewTextBoxColumn7.HeaderText = "SystemName"
Me.SystemNameDataGridViewTextBoxColumn7.Name = "SystemNameDataGridViewTextBoxColumn7"
Me.SystemNameDataGridViewTextBoxColumn7.ReadOnly = true
'
'TagIdDataGridViewTextBoxColumn
'
Me.TagIdDataGridViewTextBoxColumn.DataPropertyName = "TagId"
Me.TagIdDataGridViewTextBoxColumn.HeaderText = "TagId"
Me.TagIdDataGridViewTextBoxColumn.Name = "TagIdDataGridViewTextBoxColumn"
Me.TagIdDataGridViewTextBoxColumn.ReadOnly = true
'
'Win32SystemDriverBindingSource
'
Me.Win32SystemDriverBindingSource.DataSource = GetType(WMIwrapper.Win32_SystemDriver)
'
'PanelRefrigeration
'
Me.PanelRefrigeration.Controls.Add(Me.dgvRefrigeration)
Me.PanelRefrigeration.Dock = System.Windows.Forms.DockStyle.Fill
Me.PanelRefrigeration.Location = New System.Drawing.Point(0, 0)
Me.PanelRefrigeration.Name = "PanelRefrigeration"
Me.PanelRefrigeration.Size = New System.Drawing.Size(468, 183)
Me.PanelRefrigeration.TabIndex = 4
'
'dgvRefrigeration
'
Me.dgvRefrigeration.AllowUserToAddRows = false
Me.dgvRefrigeration.AllowUserToDeleteRows = false
Me.dgvRefrigeration.AutoGenerateColumns = false
Me.dgvRefrigeration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
Me.dgvRefrigeration.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ActiveCoolingDataGridViewCheckBoxColumn, Me.AvailabilityDataGridViewTextBoxColumn2, Me.CaptionDataGridViewTextBoxColumn2, Me.ConfigManagerErrorDataGridViewTextBoxColumn2, Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn2, Me.CreationClassNameDataGridViewTextBoxColumn2, Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn2, Me.DescriptionDataGridViewTextBoxColumn2, Me.DeviceIDDataGridViewTextBoxColumn2, Me.ErrorDescriptionDataGridViewTextBoxColumn2, Me.InstallDateDataGridViewTextBoxColumn2, Me.LastErrorCodeDataGridViewTextBoxColumn2, Me.ErrorClearedDataGridViewCheckBoxColumn2, Me.NameDataGridViewTextBoxColumn2, Me.PNPDeviceIDDataGridViewTextBoxColumn2, Me.PowerManagementSupportedDataGridViewCheckBoxColumn2, Me.StatusDataGridViewTextBoxColumn2, Me.StatusInfoDataGridViewTextBoxColumn2, Me.SystemCreationClassNameDataGridViewTextBoxColumn2, Me.SystemNameDataGridViewTextBoxColumn2})
Me.dgvRefrigeration.DataSource = Me.Win32RefrigerationBindingSource
Me.dgvRefrigeration.Dock = System.Windows.Forms.DockStyle.Fill
Me.dgvRefrigeration.Location = New System.Drawing.Point(0, 0)
Me.dgvRefrigeration.Name = "dgvRefrigeration"
Me.dgvRefrigeration.ReadOnly = true
Me.dgvRefrigeration.Size = New System.Drawing.Size(468, 183)
Me.dgvRefrigeration.TabIndex = 22
'
'ActiveCoolingDataGridViewCheckBoxColumn
'
Me.ActiveCoolingDataGridViewCheckBoxColumn.DataPropertyName = "ActiveCooling"
Me.ActiveCoolingDataGridViewCheckBoxColumn.HeaderText = "ActiveCooling"
Me.ActiveCoolingDataGridViewCheckBoxColumn.Name = "ActiveCoolingDataGridViewCheckBoxColumn"
Me.ActiveCoolingDataGridViewCheckBoxColumn.ReadOnly = true
'
'AvailabilityDataGridViewTextBoxColumn2
'
Me.AvailabilityDataGridViewTextBoxColumn2.DataPropertyName = "Availability"
Me.AvailabilityDataGridViewTextBoxColumn2.HeaderText = "Availability"
Me.AvailabilityDataGridViewTextBoxColumn2.Name = "AvailabilityDataGridViewTextBoxColumn2"
Me.AvailabilityDataGridViewTextBoxColumn2.ReadOnly = true
'
'CaptionDataGridViewTextBoxColumn2
'
Me.CaptionDataGridViewTextBoxColumn2.DataPropertyName = "Caption"
Me.CaptionDataGridViewTextBoxColumn2.HeaderText = "Caption"
Me.CaptionDataGridViewTextBoxColumn2.Name = "CaptionDataGridViewTextBoxColumn2"
Me.CaptionDataGridViewTextBoxColumn2.ReadOnly = true
'
'ConfigManagerErrorDataGridViewTextBoxColumn2
'
Me.ConfigManagerErrorDataGridViewTextBoxColumn2.DataPropertyName = "ConfigManagerError"
Me.ConfigManagerErrorDataGridViewTextBoxColumn2.HeaderText = "ConfigManagerError"
Me.ConfigManagerErrorDataGridViewTextBoxColumn2.Name = "ConfigManagerErrorDataGridViewTextBoxColumn2"
Me.ConfigManagerErrorDataGridViewTextBoxColumn2.ReadOnly = true
'
'ConfigManagerUserConfigDataGridViewCheckBoxColumn2
'
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn2.DataPropertyName = "ConfigManagerUserConfig"
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn2.HeaderText = "ConfigManagerUserConfig"
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn2.Name = "ConfigManagerUserConfigDataGridViewCheckBoxColumn2"
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn2.ReadOnly = true
'
'CreationClassNameDataGridViewTextBoxColumn2
'
Me.CreationClassNameDataGridViewTextBoxColumn2.DataPropertyName = "CreationClassName"
Me.CreationClassNameDataGridViewTextBoxColumn2.HeaderText = "CreationClassName"
Me.CreationClassNameDataGridViewTextBoxColumn2.Name = "CreationClassNameDataGridViewTextBoxColumn2"
Me.CreationClassNameDataGridViewTextBoxColumn2.ReadOnly = true
'
'ConfigManagerErrorCodeDataGridViewTextBoxColumn2
'
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn2.DataPropertyName = "ConfigManagerErrorCode"
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn2.HeaderText = "ConfigManagerErrorCode"
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn2.Name = "ConfigManagerErrorCodeDataGridViewTextBoxColumn2"
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn2.ReadOnly = true
'
'DescriptionDataGridViewTextBoxColumn2
'
Me.DescriptionDataGridViewTextBoxColumn2.DataPropertyName = "Description"
Me.DescriptionDataGridViewTextBoxColumn2.HeaderText = "Description"
Me.DescriptionDataGridViewTextBoxColumn2.Name = "DescriptionDataGridViewTextBoxColumn2"
Me.DescriptionDataGridViewTextBoxColumn2.ReadOnly = true
'
'DeviceIDDataGridViewTextBoxColumn2
'
Me.DeviceIDDataGridViewTextBoxColumn2.DataPropertyName = "DeviceID"
Me.DeviceIDDataGridViewTextBoxColumn2.HeaderText = "DeviceID"
Me.DeviceIDDataGridViewTextBoxColumn2.Name = "DeviceIDDataGridViewTextBoxColumn2"
Me.DeviceIDDataGridViewTextBoxColumn2.ReadOnly = true
'
'ErrorDescriptionDataGridViewTextBoxColumn2
'
Me.ErrorDescriptionDataGridViewTextBoxColumn2.DataPropertyName = "ErrorDescription"
Me.ErrorDescriptionDataGridViewTextBoxColumn2.HeaderText = "ErrorDescription"
Me.ErrorDescriptionDataGridViewTextBoxColumn2.Name = "ErrorDescriptionDataGridViewTextBoxColumn2"
Me.ErrorDescriptionDataGridViewTextBoxColumn2.ReadOnly = true
'
'InstallDateDataGridViewTextBoxColumn2
'
Me.InstallDateDataGridViewTextBoxColumn2.DataPropertyName = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn2.HeaderText = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn2.Name = "InstallDateDataGridViewTextBoxColumn2"
Me.InstallDateDataGridViewTextBoxColumn2.ReadOnly = true
'
'LastErrorCodeDataGridViewTextBoxColumn2
'
Me.LastErrorCodeDataGridViewTextBoxColumn2.DataPropertyName = "LastErrorCode"
Me.LastErrorCodeDataGridViewTextBoxColumn2.HeaderText = "LastErrorCode"
Me.LastErrorCodeDataGridViewTextBoxColumn2.Name = "LastErrorCodeDataGridViewTextBoxColumn2"
Me.LastErrorCodeDataGridViewTextBoxColumn2.ReadOnly = true
'
'ErrorClearedDataGridViewCheckBoxColumn2
'
Me.ErrorClearedDataGridViewCheckBoxColumn2.DataPropertyName = "ErrorCleared"
Me.ErrorClearedDataGridViewCheckBoxColumn2.HeaderText = "ErrorCleared"
Me.ErrorClearedDataGridViewCheckBoxColumn2.Name = "ErrorClearedDataGridViewCheckBoxColumn2"
Me.ErrorClearedDataGridViewCheckBoxColumn2.ReadOnly = true
'
'NameDataGridViewTextBoxColumn2
'
Me.NameDataGridViewTextBoxColumn2.DataPropertyName = "Name"
Me.NameDataGridViewTextBoxColumn2.HeaderText = "Name"
Me.NameDataGridViewTextBoxColumn2.Name = "NameDataGridViewTextBoxColumn2"
Me.NameDataGridViewTextBoxColumn2.ReadOnly = true
'
'PNPDeviceIDDataGridViewTextBoxColumn2
'
Me.PNPDeviceIDDataGridViewTextBoxColumn2.DataPropertyName = "PNPDeviceID"
Me.PNPDeviceIDDataGridViewTextBoxColumn2.HeaderText = "PNPDeviceID"
Me.PNPDeviceIDDataGridViewTextBoxColumn2.Name = "PNPDeviceIDDataGridViewTextBoxColumn2"
Me.PNPDeviceIDDataGridViewTextBoxColumn2.ReadOnly = true
'
'PowerManagementSupportedDataGridViewCheckBoxColumn2
'
Me.PowerManagementSupportedDataGridViewCheckBoxColumn2.DataPropertyName = "PowerManagementSupported"
Me.PowerManagementSupportedDataGridViewCheckBoxColumn2.HeaderText = "PowerManagementSupported"
Me.PowerManagementSupportedDataGridViewCheckBoxColumn2.Name = "PowerManagementSupportedDataGridViewCheckBoxColumn2"
Me.PowerManagementSupportedDataGridViewCheckBoxColumn2.ReadOnly = true
'
'StatusDataGridViewTextBoxColumn2
'
Me.StatusDataGridViewTextBoxColumn2.DataPropertyName = "Status"
Me.StatusDataGridViewTextBoxColumn2.HeaderText = "Status"
Me.StatusDataGridViewTextBoxColumn2.Name = "StatusDataGridViewTextBoxColumn2"
Me.StatusDataGridViewTextBoxColumn2.ReadOnly = true
'
'StatusInfoDataGridViewTextBoxColumn2
'
Me.StatusInfoDataGridViewTextBoxColumn2.DataPropertyName = "StatusInfo"
Me.StatusInfoDataGridViewTextBoxColumn2.HeaderText = "StatusInfo"
Me.StatusInfoDataGridViewTextBoxColumn2.Name = "StatusInfoDataGridViewTextBoxColumn2"
Me.StatusInfoDataGridViewTextBoxColumn2.ReadOnly = true
'
'SystemCreationClassNameDataGridViewTextBoxColumn2
'
Me.SystemCreationClassNameDataGridViewTextBoxColumn2.DataPropertyName = "SystemCreationClassName"
Me.SystemCreationClassNameDataGridViewTextBoxColumn2.HeaderText = "SystemCreationClassName"
Me.SystemCreationClassNameDataGridViewTextBoxColumn2.Name = "SystemCreationClassNameDataGridViewTextBoxColumn2"
Me.SystemCreationClassNameDataGridViewTextBoxColumn2.ReadOnly = true
'
'SystemNameDataGridViewTextBoxColumn2
'
Me.SystemNameDataGridViewTextBoxColumn2.DataPropertyName = "SystemName"
Me.SystemNameDataGridViewTextBoxColumn2.HeaderText = "SystemName"
Me.SystemNameDataGridViewTextBoxColumn2.Name = "SystemNameDataGridViewTextBoxColumn2"
Me.SystemNameDataGridViewTextBoxColumn2.ReadOnly = true
'
'Win32RefrigerationBindingSource
'
Me.Win32RefrigerationBindingSource.DataSource = GetType(WMIwrapper.Win32_Refrigeration)
'
'PanelPnPEntities
'
Me.PanelPnPEntities.Controls.Add(Me.dgvPnPEntities)
Me.PanelPnPEntities.Dock = System.Windows.Forms.DockStyle.Fill
Me.PanelPnPEntities.Location = New System.Drawing.Point(0, 0)
Me.PanelPnPEntities.Name = "PanelPnPEntities"
Me.PanelPnPEntities.Size = New System.Drawing.Size(468, 183)
Me.PanelPnPEntities.TabIndex = 14
'
'dgvPnPEntities
'
Me.dgvPnPEntities.AllowUserToAddRows = false
Me.dgvPnPEntities.AllowUserToDeleteRows = false
Me.dgvPnPEntities.AutoGenerateColumns = false
Me.dgvPnPEntities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
Me.dgvPnPEntities.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AvailabilityDataGridViewTextBoxColumn6, Me.CaptionDataGridViewTextBoxColumn9, Me.ClassGuidDataGridViewTextBoxColumn, Me.ConfigManagerErrorDataGridViewTextBoxColumn6, Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn6, Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn6, Me.CreationClassNameDataGridViewTextBoxColumn7, Me.DescriptionDataGridViewTextBoxColumn10, Me.DeviceIDDataGridViewTextBoxColumn6, Me.ErrorClearedDataGridViewCheckBoxColumn6, Me.ErrorDescriptionDataGridViewTextBoxColumn6, Me.InstallDateDataGridViewTextBoxColumn8, Me.LastErrorCodeDataGridViewTextBoxColumn6, Me.ManufacturerDataGridViewTextBoxColumn4, Me.NameDataGridViewTextBoxColumn8, Me.PNPDeviceIDDataGridViewTextBoxColumn6, Me.PowerManagementSupportedDataGridViewCheckBoxColumn6, Me.ServiceDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn8, Me.StatusInfoDataGridViewTextBoxColumn6, Me.SystemNameDataGridViewTextBoxColumn6, Me.SystemCreationClassNameDataGridViewTextBoxColumn6})
Me.dgvPnPEntities.DataSource = Me.Win32PnPEntityBindingSource
Me.dgvPnPEntities.Dock = System.Windows.Forms.DockStyle.Fill
Me.dgvPnPEntities.Location = New System.Drawing.Point(0, 0)
Me.dgvPnPEntities.Name = "dgvPnPEntities"
Me.dgvPnPEntities.ReadOnly = true
Me.dgvPnPEntities.Size = New System.Drawing.Size(468, 183)
Me.dgvPnPEntities.TabIndex = 22
'
'AvailabilityDataGridViewTextBoxColumn6
'
Me.AvailabilityDataGridViewTextBoxColumn6.DataPropertyName = "Availability"
Me.AvailabilityDataGridViewTextBoxColumn6.HeaderText = "Availability"
Me.AvailabilityDataGridViewTextBoxColumn6.Name = "AvailabilityDataGridViewTextBoxColumn6"
Me.AvailabilityDataGridViewTextBoxColumn6.ReadOnly = true
'
'CaptionDataGridViewTextBoxColumn9
'
Me.CaptionDataGridViewTextBoxColumn9.DataPropertyName = "Caption"
Me.CaptionDataGridViewTextBoxColumn9.HeaderText = "Caption"
Me.CaptionDataGridViewTextBoxColumn9.Name = "CaptionDataGridViewTextBoxColumn9"
Me.CaptionDataGridViewTextBoxColumn9.ReadOnly = true
'
'ClassGuidDataGridViewTextBoxColumn
'
Me.ClassGuidDataGridViewTextBoxColumn.DataPropertyName = "ClassGuid"
Me.ClassGuidDataGridViewTextBoxColumn.HeaderText = "ClassGuid"
Me.ClassGuidDataGridViewTextBoxColumn.Name = "ClassGuidDataGridViewTextBoxColumn"
Me.ClassGuidDataGridViewTextBoxColumn.ReadOnly = true
'
'ConfigManagerErrorDataGridViewTextBoxColumn6
'
Me.ConfigManagerErrorDataGridViewTextBoxColumn6.DataPropertyName = "ConfigManagerError"
Me.ConfigManagerErrorDataGridViewTextBoxColumn6.HeaderText = "ConfigManagerError"
Me.ConfigManagerErrorDataGridViewTextBoxColumn6.Name = "ConfigManagerErrorDataGridViewTextBoxColumn6"
Me.ConfigManagerErrorDataGridViewTextBoxColumn6.ReadOnly = true
'
'ConfigManagerErrorCodeDataGridViewTextBoxColumn6
'
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn6.DataPropertyName = "ConfigManagerErrorCode"
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn6.HeaderText = "ConfigManagerErrorCode"
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn6.Name = "ConfigManagerErrorCodeDataGridViewTextBoxColumn6"
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn6.ReadOnly = true
'
'ConfigManagerUserConfigDataGridViewCheckBoxColumn6
'
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn6.DataPropertyName = "ConfigManagerUserConfig"
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn6.HeaderText = "ConfigManagerUserConfig"
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn6.Name = "ConfigManagerUserConfigDataGridViewCheckBoxColumn6"
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn6.ReadOnly = true
'
'CreationClassNameDataGridViewTextBoxColumn7
'
Me.CreationClassNameDataGridViewTextBoxColumn7.DataPropertyName = "CreationClassName"
Me.CreationClassNameDataGridViewTextBoxColumn7.HeaderText = "CreationClassName"
Me.CreationClassNameDataGridViewTextBoxColumn7.Name = "CreationClassNameDataGridViewTextBoxColumn7"
Me.CreationClassNameDataGridViewTextBoxColumn7.ReadOnly = true
'
'DescriptionDataGridViewTextBoxColumn10
'
Me.DescriptionDataGridViewTextBoxColumn10.DataPropertyName = "Description"
Me.DescriptionDataGridViewTextBoxColumn10.HeaderText = "Description"
Me.DescriptionDataGridViewTextBoxColumn10.Name = "DescriptionDataGridViewTextBoxColumn10"
Me.DescriptionDataGridViewTextBoxColumn10.ReadOnly = true
'
'DeviceIDDataGridViewTextBoxColumn6
'
Me.DeviceIDDataGridViewTextBoxColumn6.DataPropertyName = "DeviceID"
Me.DeviceIDDataGridViewTextBoxColumn6.HeaderText = "DeviceID"
Me.DeviceIDDataGridViewTextBoxColumn6.Name = "DeviceIDDataGridViewTextBoxColumn6"
Me.DeviceIDDataGridViewTextBoxColumn6.ReadOnly = true
'
'ErrorClearedDataGridViewCheckBoxColumn6
'
Me.ErrorClearedDataGridViewCheckBoxColumn6.DataPropertyName = "ErrorCleared"
Me.ErrorClearedDataGridViewCheckBoxColumn6.HeaderText = "ErrorCleared"
Me.ErrorClearedDataGridViewCheckBoxColumn6.Name = "ErrorClearedDataGridViewCheckBoxColumn6"
Me.ErrorClearedDataGridViewCheckBoxColumn6.ReadOnly = true
'
'ErrorDescriptionDataGridViewTextBoxColumn6
'
Me.ErrorDescriptionDataGridViewTextBoxColumn6.DataPropertyName = "ErrorDescription"
Me.ErrorDescriptionDataGridViewTextBoxColumn6.HeaderText = "ErrorDescription"
Me.ErrorDescriptionDataGridViewTextBoxColumn6.Name = "ErrorDescriptionDataGridViewTextBoxColumn6"
Me.ErrorDescriptionDataGridViewTextBoxColumn6.ReadOnly = true
'
'InstallDateDataGridViewTextBoxColumn8
'
Me.InstallDateDataGridViewTextBoxColumn8.DataPropertyName = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn8.HeaderText = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn8.Name = "InstallDateDataGridViewTextBoxColumn8"
Me.InstallDateDataGridViewTextBoxColumn8.ReadOnly = true
'
'LastErrorCodeDataGridViewTextBoxColumn6
'
Me.LastErrorCodeDataGridViewTextBoxColumn6.DataPropertyName = "LastErrorCode"
Me.LastErrorCodeDataGridViewTextBoxColumn6.HeaderText = "LastErrorCode"
Me.LastErrorCodeDataGridViewTextBoxColumn6.Name = "LastErrorCodeDataGridViewTextBoxColumn6"
Me.LastErrorCodeDataGridViewTextBoxColumn6.ReadOnly = true
'
'ManufacturerDataGridViewTextBoxColumn4
'
Me.ManufacturerDataGridViewTextBoxColumn4.DataPropertyName = "Manufacturer"
Me.ManufacturerDataGridViewTextBoxColumn4.HeaderText = "Manufacturer"
Me.ManufacturerDataGridViewTextBoxColumn4.Name = "ManufacturerDataGridViewTextBoxColumn4"
Me.ManufacturerDataGridViewTextBoxColumn4.ReadOnly = true
'
'NameDataGridViewTextBoxColumn8
'
Me.NameDataGridViewTextBoxColumn8.DataPropertyName = "Name"
Me.NameDataGridViewTextBoxColumn8.HeaderText = "Name"
Me.NameDataGridViewTextBoxColumn8.Name = "NameDataGridViewTextBoxColumn8"
Me.NameDataGridViewTextBoxColumn8.ReadOnly = true
'
'PNPDeviceIDDataGridViewTextBoxColumn6
'
Me.PNPDeviceIDDataGridViewTextBoxColumn6.DataPropertyName = "PNPDeviceID"
Me.PNPDeviceIDDataGridViewTextBoxColumn6.HeaderText = "PNPDeviceID"
Me.PNPDeviceIDDataGridViewTextBoxColumn6.Name = "PNPDeviceIDDataGridViewTextBoxColumn6"
Me.PNPDeviceIDDataGridViewTextBoxColumn6.ReadOnly = true
'
'PowerManagementSupportedDataGridViewCheckBoxColumn6
'
Me.PowerManagementSupportedDataGridViewCheckBoxColumn6.DataPropertyName = "PowerManagementSupported"
Me.PowerManagementSupportedDataGridViewCheckBoxColumn6.HeaderText = "PowerManagementSupported"
Me.PowerManagementSupportedDataGridViewCheckBoxColumn6.Name = "PowerManagementSupportedDataGridViewCheckBoxColumn6"
Me.PowerManagementSupportedDataGridViewCheckBoxColumn6.ReadOnly = true
'
'ServiceDataGridViewTextBoxColumn
'
Me.ServiceDataGridViewTextBoxColumn.DataPropertyName = "Service"
Me.ServiceDataGridViewTextBoxColumn.HeaderText = "Service"
Me.ServiceDataGridViewTextBoxColumn.Name = "ServiceDataGridViewTextBoxColumn"
Me.ServiceDataGridViewTextBoxColumn.ReadOnly = true
'
'StatusDataGridViewTextBoxColumn8
'
Me.StatusDataGridViewTextBoxColumn8.DataPropertyName = "Status"
Me.StatusDataGridViewTextBoxColumn8.HeaderText = "Status"
Me.StatusDataGridViewTextBoxColumn8.Name = "StatusDataGridViewTextBoxColumn8"
Me.StatusDataGridViewTextBoxColumn8.ReadOnly = true
'
'StatusInfoDataGridViewTextBoxColumn6
'
Me.StatusInfoDataGridViewTextBoxColumn6.DataPropertyName = "StatusInfo"
Me.StatusInfoDataGridViewTextBoxColumn6.HeaderText = "StatusInfo"
Me.StatusInfoDataGridViewTextBoxColumn6.Name = "StatusInfoDataGridViewTextBoxColumn6"
Me.StatusInfoDataGridViewTextBoxColumn6.ReadOnly = true
'
'SystemNameDataGridViewTextBoxColumn6
'
Me.SystemNameDataGridViewTextBoxColumn6.DataPropertyName = "SystemName"
Me.SystemNameDataGridViewTextBoxColumn6.HeaderText = "SystemName"
Me.SystemNameDataGridViewTextBoxColumn6.Name = "SystemNameDataGridViewTextBoxColumn6"
Me.SystemNameDataGridViewTextBoxColumn6.ReadOnly = true
'
'SystemCreationClassNameDataGridViewTextBoxColumn6
'
Me.SystemCreationClassNameDataGridViewTextBoxColumn6.DataPropertyName = "SystemCreationClassName"
Me.SystemCreationClassNameDataGridViewTextBoxColumn6.HeaderText = "SystemCreationClassName"
Me.SystemCreationClassNameDataGridViewTextBoxColumn6.Name = "SystemCreationClassNameDataGridViewTextBoxColumn6"
Me.SystemCreationClassNameDataGridViewTextBoxColumn6.ReadOnly = true
'
'Win32PnPEntityBindingSource
'
Me.Win32PnPEntityBindingSource.DataSource = GetType(WMIwrapper.Win32_PnPEntity)
'
'PanelOS
'
Me.PanelOS.Controls.Add(Me.dgvOS)
Me.PanelOS.Dock = System.Windows.Forms.DockStyle.Fill
Me.PanelOS.Location = New System.Drawing.Point(0, 0)
Me.PanelOS.Name = "PanelOS"
Me.PanelOS.Size = New System.Drawing.Size(468, 183)
Me.PanelOS.TabIndex = 12
'
'dgvOS
'
Me.dgvOS.AllowUserToAddRows = false
Me.dgvOS.AllowUserToDeleteRows = false
Me.dgvOS.AutoGenerateColumns = false
Me.dgvOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
Me.dgvOS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BootDeviceDataGridViewTextBoxColumn, Me.BuildNumberDataGridViewTextBoxColumn, Me.BuildTypeDataGridViewTextBoxColumn, Me.CaptionDataGridViewTextBoxColumn8, Me.CodeSetDataGridViewTextBoxColumn, Me.CountryCodeDataGridViewTextBoxColumn, Me.CreationClassNameDataGridViewTextBoxColumn6, Me.CSCreationClassNameDataGridViewTextBoxColumn, Me.CSDVersionDataGridViewTextBoxColumn, Me.CSNameDataGridViewTextBoxColumn, Me.CurrentTimeZoneDataGridViewTextBoxColumn, Me.DataExecutionPrevention32BitApplicationsDataGridViewCheckBoxColumn, Me.DataExecutionPreventionAvailableDataGridViewCheckBoxColumn, Me.DataExecutionPreventionDriversDataGridViewCheckBoxColumn, Me.DataExecutionPreventionSupportPolicyDataGridViewTextBoxColumn, Me.DebugDataGridViewCheckBoxColumn, Me.DescriptionDataGridViewTextBoxColumn8, Me.DistributedDataGridViewCheckBoxColumn, Me.EncryptionLevelDataGridViewTextBoxColumn, Me.ForegroundApplicationBoostDataGridViewTextBoxColumn, Me.FreePhysicalMemoryDataGridViewTextBoxColumn, Me.FreeSpaceInPagingFilesDataGridViewTextBoxColumn, Me.FreeVirtualMemoryDataGridViewTextBoxColumn, Me.InstallDateDataGridViewTextBoxColumn7, Me.LargeSystemCacheDataGridViewTextBoxColumn, Me.LastBootUpTimeDataGridViewTextBoxColumn, Me.LocalDateTimeDataGridViewTextBoxColumn, Me.LocaleDataGridViewTextBoxColumn, Me.ManufacturerDataGridViewTextBoxColumn3, Me.MaxNumberOfProcessesDataGridViewTextBoxColumn, Me.MaxProcessMemorySizeDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn7, Me.NumberOfLicensedUsersDataGridViewTextBoxColumn, Me.NumberOfProcessesDataGridViewTextBoxColumn, Me.NumberOfUsersDataGridViewTextBoxColumn, Me.OperatingSystemSKUDataGridViewTextBoxColumn, Me.OrganizationDataGridViewTextBoxColumn, Me.OSLanguageDataGridViewTextBoxColumn, Me.OSArchitectureDataGridViewTextBoxColumn, Me.OSProductSuiteDataGridViewTextBoxColumn, Me.OSTypeDataGridViewTextBoxColumn, Me.OtherTypeDescriptionDataGridViewTextBoxColumn, Me.PAEEnabledDataGridViewCheckBoxColumn, Me.PlusProductIDDataGridViewTextBoxColumn, Me.PlusVersionNumberDataGridViewTextBoxColumn, Me.ProductTypeDataGridViewTextBoxColumn, Me.PrimaryDataGridViewCheckBoxColumn, Me.QuantumLengthDataGridViewTextBoxColumn, Me.QuantumTypeDataGridViewTextBoxColumn, Me.RegisteredUserDataGridViewTextBoxColumn, Me.SerialNumberDataGridViewTextBoxColumn2, Me.ServicePackMajorVersionDataGridViewTextBoxColumn, Me.ServicePackMinorVersionDataGridViewTextBoxColumn, Me.SizeStoredInPagingFilesDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn7, Me.SuiteMaskDataGridViewTextBoxColumn, Me.SystemDeviceDataGridViewTextBoxColumn, Me.SystemDirectoryDataGridViewTextBoxColumn, Me.SystemDriveDataGridViewTextBoxColumn, Me.TotalSwapSpaceSizeDataGridViewTextBoxColumn, Me.TotalVirtualMemorySizeDataGridViewTextBoxColumn, Me.TotalVisibleMemorySizeDataGridViewTextBoxColumn, Me.VersionDataGridViewTextBoxColumn1, Me.WindowsDirectoryDataGridViewTextBoxColumn})
Me.dgvOS.DataSource = Me.Win32OperatingSystemBindingSource
Me.dgvOS.Dock = System.Windows.Forms.DockStyle.Fill
Me.dgvOS.Location = New System.Drawing.Point(0, 0)
Me.dgvOS.Name = "dgvOS"
Me.dgvOS.ReadOnly = true
Me.dgvOS.Size = New System.Drawing.Size(468, 183)
Me.dgvOS.TabIndex = 22
'
'BootDeviceDataGridViewTextBoxColumn
'
Me.BootDeviceDataGridViewTextBoxColumn.DataPropertyName = "BootDevice"
Me.BootDeviceDataGridViewTextBoxColumn.HeaderText = "BootDevice"
Me.BootDeviceDataGridViewTextBoxColumn.Name = "BootDeviceDataGridViewTextBoxColumn"
Me.BootDeviceDataGridViewTextBoxColumn.ReadOnly = true
'
'BuildNumberDataGridViewTextBoxColumn
'
Me.BuildNumberDataGridViewTextBoxColumn.DataPropertyName = "BuildNumber"
Me.BuildNumberDataGridViewTextBoxColumn.HeaderText = "BuildNumber"
Me.BuildNumberDataGridViewTextBoxColumn.Name = "BuildNumberDataGridViewTextBoxColumn"
Me.BuildNumberDataGridViewTextBoxColumn.ReadOnly = true
'
'BuildTypeDataGridViewTextBoxColumn
'
Me.BuildTypeDataGridViewTextBoxColumn.DataPropertyName = "BuildType"
Me.BuildTypeDataGridViewTextBoxColumn.HeaderText = "BuildType"
Me.BuildTypeDataGridViewTextBoxColumn.Name = "BuildTypeDataGridViewTextBoxColumn"
Me.BuildTypeDataGridViewTextBoxColumn.ReadOnly = true
'
'CaptionDataGridViewTextBoxColumn8
'
Me.CaptionDataGridViewTextBoxColumn8.DataPropertyName = "Caption"
Me.CaptionDataGridViewTextBoxColumn8.HeaderText = "Caption"
Me.CaptionDataGridViewTextBoxColumn8.Name = "CaptionDataGridViewTextBoxColumn8"
Me.CaptionDataGridViewTextBoxColumn8.ReadOnly = true
'
'CodeSetDataGridViewTextBoxColumn
'
Me.CodeSetDataGridViewTextBoxColumn.DataPropertyName = "CodeSet"
Me.CodeSetDataGridViewTextBoxColumn.HeaderText = "CodeSet"
Me.CodeSetDataGridViewTextBoxColumn.Name = "CodeSetDataGridViewTextBoxColumn"
Me.CodeSetDataGridViewTextBoxColumn.ReadOnly = true
'
'CountryCodeDataGridViewTextBoxColumn
'
Me.CountryCodeDataGridViewTextBoxColumn.DataPropertyName = "CountryCode"
Me.CountryCodeDataGridViewTextBoxColumn.HeaderText = "CountryCode"
Me.CountryCodeDataGridViewTextBoxColumn.Name = "CountryCodeDataGridViewTextBoxColumn"
Me.CountryCodeDataGridViewTextBoxColumn.ReadOnly = true
'
'CreationClassNameDataGridViewTextBoxColumn6
'
Me.CreationClassNameDataGridViewTextBoxColumn6.DataPropertyName = "CreationClassName"
Me.CreationClassNameDataGridViewTextBoxColumn6.HeaderText = "CreationClassName"
Me.CreationClassNameDataGridViewTextBoxColumn6.Name = "CreationClassNameDataGridViewTextBoxColumn6"
Me.CreationClassNameDataGridViewTextBoxColumn6.ReadOnly = true
'
'CSCreationClassNameDataGridViewTextBoxColumn
'
Me.CSCreationClassNameDataGridViewTextBoxColumn.DataPropertyName = "CSCreationClassName"
Me.CSCreationClassNameDataGridViewTextBoxColumn.HeaderText = "CSCreationClassName"
Me.CSCreationClassNameDataGridViewTextBoxColumn.Name = "CSCreationClassNameDataGridViewTextBoxColumn"
Me.CSCreationClassNameDataGridViewTextBoxColumn.ReadOnly = true
'
'CSDVersionDataGridViewTextBoxColumn
'
Me.CSDVersionDataGridViewTextBoxColumn.DataPropertyName = "CSDVersion"
Me.CSDVersionDataGridViewTextBoxColumn.HeaderText = "CSDVersion"
Me.CSDVersionDataGridViewTextBoxColumn.Name = "CSDVersionDataGridViewTextBoxColumn"
Me.CSDVersionDataGridViewTextBoxColumn.ReadOnly = true
'
'CSNameDataGridViewTextBoxColumn
'
Me.CSNameDataGridViewTextBoxColumn.DataPropertyName = "CSName"
Me.CSNameDataGridViewTextBoxColumn.HeaderText = "CSName"
Me.CSNameDataGridViewTextBoxColumn.Name = "CSNameDataGridViewTextBoxColumn"
Me.CSNameDataGridViewTextBoxColumn.ReadOnly = true
'
'CurrentTimeZoneDataGridViewTextBoxColumn
'
Me.CurrentTimeZoneDataGridViewTextBoxColumn.DataPropertyName = "CurrentTimeZone"
Me.CurrentTimeZoneDataGridViewTextBoxColumn.HeaderText = "CurrentTimeZone"
Me.CurrentTimeZoneDataGridViewTextBoxColumn.Name = "CurrentTimeZoneDataGridViewTextBoxColumn"
Me.CurrentTimeZoneDataGridViewTextBoxColumn.ReadOnly = true
'
'DataExecutionPrevention32BitApplicationsDataGridViewCheckBoxColumn
'
Me.DataExecutionPrevention32BitApplicationsDataGridViewCheckBoxColumn.DataPropertyName = "DataExecutionPrevention_32BitApplications"
Me.DataExecutionPrevention32BitApplicationsDataGridViewCheckBoxColumn.HeaderText = "DataExecutionPrevention_32BitApplications"
Me.DataExecutionPrevention32BitApplicationsDataGridViewCheckBoxColumn.Name = "DataExecutionPrevention32BitApplicationsDataGridViewCheckBoxColumn"
Me.DataExecutionPrevention32BitApplicationsDataGridViewCheckBoxColumn.ReadOnly = true
'
'DataExecutionPreventionAvailableDataGridViewCheckBoxColumn
'
Me.DataExecutionPreventionAvailableDataGridViewCheckBoxColumn.DataPropertyName = "DataExecutionPrevention_Available"
Me.DataExecutionPreventionAvailableDataGridViewCheckBoxColumn.HeaderText = "DataExecutionPrevention_Available"
Me.DataExecutionPreventionAvailableDataGridViewCheckBoxColumn.Name = "DataExecutionPreventionAvailableDataGridViewCheckBoxColumn"
Me.DataExecutionPreventionAvailableDataGridViewCheckBoxColumn.ReadOnly = true
'
'DataExecutionPreventionDriversDataGridViewCheckBoxColumn
'
Me.DataExecutionPreventionDriversDataGridViewCheckBoxColumn.DataPropertyName = "DataExecutionPrevention_Drivers"
Me.DataExecutionPreventionDriversDataGridViewCheckBoxColumn.HeaderText = "DataExecutionPrevention_Drivers"
Me.DataExecutionPreventionDriversDataGridViewCheckBoxColumn.Name = "DataExecutionPreventionDriversDataGridViewCheckBoxColumn"
Me.DataExecutionPreventionDriversDataGridViewCheckBoxColumn.ReadOnly = true
'
'DataExecutionPreventionSupportPolicyDataGridViewTextBoxColumn
'
Me.DataExecutionPreventionSupportPolicyDataGridViewTextBoxColumn.DataPropertyName = "DataExecutionPrevention_SupportPolicy"
Me.DataExecutionPreventionSupportPolicyDataGridViewTextBoxColumn.HeaderText = "DataExecutionPrevention_SupportPolicy"
Me.DataExecutionPreventionSupportPolicyDataGridViewTextBoxColumn.Name = "DataExecutionPreventionSupportPolicyDataGridViewTextBoxColumn"
Me.DataExecutionPreventionSupportPolicyDataGridViewTextBoxColumn.ReadOnly = true
'
'DebugDataGridViewCheckBoxColumn
'
Me.DebugDataGridViewCheckBoxColumn.DataPropertyName = "Debug"
Me.DebugDataGridViewCheckBoxColumn.HeaderText = "Debug"
Me.DebugDataGridViewCheckBoxColumn.Name = "DebugDataGridViewCheckBoxColumn"
Me.DebugDataGridViewCheckBoxColumn.ReadOnly = true
'
'DescriptionDataGridViewTextBoxColumn8
'
Me.DescriptionDataGridViewTextBoxColumn8.DataPropertyName = "Description"
Me.DescriptionDataGridViewTextBoxColumn8.HeaderText = "Description"
Me.DescriptionDataGridViewTextBoxColumn8.Name = "DescriptionDataGridViewTextBoxColumn8"
Me.DescriptionDataGridViewTextBoxColumn8.ReadOnly = true
'
'DistributedDataGridViewCheckBoxColumn
'
Me.DistributedDataGridViewCheckBoxColumn.DataPropertyName = "Distributed"
Me.DistributedDataGridViewCheckBoxColumn.HeaderText = "Distributed"
Me.DistributedDataGridViewCheckBoxColumn.Name = "DistributedDataGridViewCheckBoxColumn"
Me.DistributedDataGridViewCheckBoxColumn.ReadOnly = true
'
'EncryptionLevelDataGridViewTextBoxColumn
'
Me.EncryptionLevelDataGridViewTextBoxColumn.DataPropertyName = "EncryptionLevel"
Me.EncryptionLevelDataGridViewTextBoxColumn.HeaderText = "EncryptionLevel"
Me.EncryptionLevelDataGridViewTextBoxColumn.Name = "EncryptionLevelDataGridViewTextBoxColumn"
Me.EncryptionLevelDataGridViewTextBoxColumn.ReadOnly = true
'
'ForegroundApplicationBoostDataGridViewTextBoxColumn
'
Me.ForegroundApplicationBoostDataGridViewTextBoxColumn.DataPropertyName = "ForegroundApplicationBoost"
Me.ForegroundApplicationBoostDataGridViewTextBoxColumn.HeaderText = "ForegroundApplicationBoost"
Me.ForegroundApplicationBoostDataGridViewTextBoxColumn.Name = "ForegroundApplicationBoostDataGridViewTextBoxColumn"
Me.ForegroundApplicationBoostDataGridViewTextBoxColumn.ReadOnly = true
'
'FreePhysicalMemoryDataGridViewTextBoxColumn
'
Me.FreePhysicalMemoryDataGridViewTextBoxColumn.DataPropertyName = "FreePhysicalMemory"
Me.FreePhysicalMemoryDataGridViewTextBoxColumn.HeaderText = "FreePhysicalMemory"
Me.FreePhysicalMemoryDataGridViewTextBoxColumn.Name = "FreePhysicalMemoryDataGridViewTextBoxColumn"
Me.FreePhysicalMemoryDataGridViewTextBoxColumn.ReadOnly = true
'
'FreeSpaceInPagingFilesDataGridViewTextBoxColumn
'
Me.FreeSpaceInPagingFilesDataGridViewTextBoxColumn.DataPropertyName = "FreeSpaceInPagingFiles"
Me.FreeSpaceInPagingFilesDataGridViewTextBoxColumn.HeaderText = "FreeSpaceInPagingFiles"
Me.FreeSpaceInPagingFilesDataGridViewTextBoxColumn.Name = "FreeSpaceInPagingFilesDataGridViewTextBoxColumn"
Me.FreeSpaceInPagingFilesDataGridViewTextBoxColumn.ReadOnly = true
'
'FreeVirtualMemoryDataGridViewTextBoxColumn
'
Me.FreeVirtualMemoryDataGridViewTextBoxColumn.DataPropertyName = "FreeVirtualMemory"
Me.FreeVirtualMemoryDataGridViewTextBoxColumn.HeaderText = "FreeVirtualMemory"
Me.FreeVirtualMemoryDataGridViewTextBoxColumn.Name = "FreeVirtualMemoryDataGridViewTextBoxColumn"
Me.FreeVirtualMemoryDataGridViewTextBoxColumn.ReadOnly = true
'
'InstallDateDataGridViewTextBoxColumn7
'
Me.InstallDateDataGridViewTextBoxColumn7.DataPropertyName = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn7.HeaderText = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn7.Name = "InstallDateDataGridViewTextBoxColumn7"
Me.InstallDateDataGridViewTextBoxColumn7.ReadOnly = true
'
'LargeSystemCacheDataGridViewTextBoxColumn
'
Me.LargeSystemCacheDataGridViewTextBoxColumn.DataPropertyName = "LargeSystemCache"
Me.LargeSystemCacheDataGridViewTextBoxColumn.HeaderText = "LargeSystemCache"
Me.LargeSystemCacheDataGridViewTextBoxColumn.Name = "LargeSystemCacheDataGridViewTextBoxColumn"
Me.LargeSystemCacheDataGridViewTextBoxColumn.ReadOnly = true
'
'LastBootUpTimeDataGridViewTextBoxColumn
'
Me.LastBootUpTimeDataGridViewTextBoxColumn.DataPropertyName = "LastBootUpTime"
Me.LastBootUpTimeDataGridViewTextBoxColumn.HeaderText = "LastBootUpTime"
Me.LastBootUpTimeDataGridViewTextBoxColumn.Name = "LastBootUpTimeDataGridViewTextBoxColumn"
Me.LastBootUpTimeDataGridViewTextBoxColumn.ReadOnly = true
'
'LocalDateTimeDataGridViewTextBoxColumn
'
Me.LocalDateTimeDataGridViewTextBoxColumn.DataPropertyName = "LocalDateTime"
Me.LocalDateTimeDataGridViewTextBoxColumn.HeaderText = "LocalDateTime"
Me.LocalDateTimeDataGridViewTextBoxColumn.Name = "LocalDateTimeDataGridViewTextBoxColumn"
Me.LocalDateTimeDataGridViewTextBoxColumn.ReadOnly = true
'
'LocaleDataGridViewTextBoxColumn
'
Me.LocaleDataGridViewTextBoxColumn.DataPropertyName = "Locale"
Me.LocaleDataGridViewTextBoxColumn.HeaderText = "Locale"
Me.LocaleDataGridViewTextBoxColumn.Name = "LocaleDataGridViewTextBoxColumn"
Me.LocaleDataGridViewTextBoxColumn.ReadOnly = true
'
'ManufacturerDataGridViewTextBoxColumn3
'
Me.ManufacturerDataGridViewTextBoxColumn3.DataPropertyName = "Manufacturer"
Me.ManufacturerDataGridViewTextBoxColumn3.HeaderText = "Manufacturer"
Me.ManufacturerDataGridViewTextBoxColumn3.Name = "ManufacturerDataGridViewTextBoxColumn3"
Me.ManufacturerDataGridViewTextBoxColumn3.ReadOnly = true
'
'MaxNumberOfProcessesDataGridViewTextBoxColumn
'
Me.MaxNumberOfProcessesDataGridViewTextBoxColumn.DataPropertyName = "MaxNumberOfProcesses"
Me.MaxNumberOfProcessesDataGridViewTextBoxColumn.HeaderText = "MaxNumberOfProcesses"
Me.MaxNumberOfProcessesDataGridViewTextBoxColumn.Name = "MaxNumberOfProcessesDataGridViewTextBoxColumn"
Me.MaxNumberOfProcessesDataGridViewTextBoxColumn.ReadOnly = true
'
'MaxProcessMemorySizeDataGridViewTextBoxColumn
'
Me.MaxProcessMemorySizeDataGridViewTextBoxColumn.DataPropertyName = "MaxProcessMemorySize"
Me.MaxProcessMemorySizeDataGridViewTextBoxColumn.HeaderText = "MaxProcessMemorySize"
Me.MaxProcessMemorySizeDataGridViewTextBoxColumn.Name = "MaxProcessMemorySizeDataGridViewTextBoxColumn"
Me.MaxProcessMemorySizeDataGridViewTextBoxColumn.ReadOnly = true
'
'NameDataGridViewTextBoxColumn7
'
Me.NameDataGridViewTextBoxColumn7.DataPropertyName = "Name"
Me.NameDataGridViewTextBoxColumn7.HeaderText = "Name"
Me.NameDataGridViewTextBoxColumn7.Name = "NameDataGridViewTextBoxColumn7"
Me.NameDataGridViewTextBoxColumn7.ReadOnly = true
'
'NumberOfLicensedUsersDataGridViewTextBoxColumn
'
Me.NumberOfLicensedUsersDataGridViewTextBoxColumn.DataPropertyName = "NumberOfLicensedUsers"
Me.NumberOfLicensedUsersDataGridViewTextBoxColumn.HeaderText = "NumberOfLicensedUsers"
Me.NumberOfLicensedUsersDataGridViewTextBoxColumn.Name = "NumberOfLicensedUsersDataGridViewTextBoxColumn"
Me.NumberOfLicensedUsersDataGridViewTextBoxColumn.ReadOnly = true
'
'NumberOfProcessesDataGridViewTextBoxColumn
'
Me.NumberOfProcessesDataGridViewTextBoxColumn.DataPropertyName = "NumberOfProcesses"
Me.NumberOfProcessesDataGridViewTextBoxColumn.HeaderText = "NumberOfProcesses"
Me.NumberOfProcessesDataGridViewTextBoxColumn.Name = "NumberOfProcessesDataGridViewTextBoxColumn"
Me.NumberOfProcessesDataGridViewTextBoxColumn.ReadOnly = true
'
'NumberOfUsersDataGridViewTextBoxColumn
'
Me.NumberOfUsersDataGridViewTextBoxColumn.DataPropertyName = "NumberOfUsers"
Me.NumberOfUsersDataGridViewTextBoxColumn.HeaderText = "NumberOfUsers"
Me.NumberOfUsersDataGridViewTextBoxColumn.Name = "NumberOfUsersDataGridViewTextBoxColumn"
Me.NumberOfUsersDataGridViewTextBoxColumn.ReadOnly = true
'
'OperatingSystemSKUDataGridViewTextBoxColumn
'
Me.OperatingSystemSKUDataGridViewTextBoxColumn.DataPropertyName = "OperatingSystemSKU"
Me.OperatingSystemSKUDataGridViewTextBoxColumn.HeaderText = "OperatingSystemSKU"
Me.OperatingSystemSKUDataGridViewTextBoxColumn.Name = "OperatingSystemSKUDataGridViewTextBoxColumn"
Me.OperatingSystemSKUDataGridViewTextBoxColumn.ReadOnly = true
'
'OrganizationDataGridViewTextBoxColumn
'
Me.OrganizationDataGridViewTextBoxColumn.DataPropertyName = "Organization"
Me.OrganizationDataGridViewTextBoxColumn.HeaderText = "Organization"
Me.OrganizationDataGridViewTextBoxColumn.Name = "OrganizationDataGridViewTextBoxColumn"
Me.OrganizationDataGridViewTextBoxColumn.ReadOnly = true
'
'OSLanguageDataGridViewTextBoxColumn
'
Me.OSLanguageDataGridViewTextBoxColumn.DataPropertyName = "OSLanguage"
Me.OSLanguageDataGridViewTextBoxColumn.HeaderText = "OSLanguage"
Me.OSLanguageDataGridViewTextBoxColumn.Name = "OSLanguageDataGridViewTextBoxColumn"
Me.OSLanguageDataGridViewTextBoxColumn.ReadOnly = true
'
'OSArchitectureDataGridViewTextBoxColumn
'
Me.OSArchitectureDataGridViewTextBoxColumn.DataPropertyName = "OSArchitecture"
Me.OSArchitectureDataGridViewTextBoxColumn.HeaderText = "OSArchitecture"
Me.OSArchitectureDataGridViewTextBoxColumn.Name = "OSArchitectureDataGridViewTextBoxColumn"
Me.OSArchitectureDataGridViewTextBoxColumn.ReadOnly = true
'
'OSProductSuiteDataGridViewTextBoxColumn
'
Me.OSProductSuiteDataGridViewTextBoxColumn.DataPropertyName = "OSProductSuite"
Me.OSProductSuiteDataGridViewTextBoxColumn.HeaderText = "OSProductSuite"
Me.OSProductSuiteDataGridViewTextBoxColumn.Name = "OSProductSuiteDataGridViewTextBoxColumn"
Me.OSProductSuiteDataGridViewTextBoxColumn.ReadOnly = true
'
'OSTypeDataGridViewTextBoxColumn
'
Me.OSTypeDataGridViewTextBoxColumn.DataPropertyName = "OSType"
Me.OSTypeDataGridViewTextBoxColumn.HeaderText = "OSType"
Me.OSTypeDataGridViewTextBoxColumn.Name = "OSTypeDataGridViewTextBoxColumn"
Me.OSTypeDataGridViewTextBoxColumn.ReadOnly = true
'
'OtherTypeDescriptionDataGridViewTextBoxColumn
'
Me.OtherTypeDescriptionDataGridViewTextBoxColumn.DataPropertyName = "OtherTypeDescription"
Me.OtherTypeDescriptionDataGridViewTextBoxColumn.HeaderText = "OtherTypeDescription"
Me.OtherTypeDescriptionDataGridViewTextBoxColumn.Name = "OtherTypeDescriptionDataGridViewTextBoxColumn"
Me.OtherTypeDescriptionDataGridViewTextBoxColumn.ReadOnly = true
'
'PAEEnabledDataGridViewCheckBoxColumn
'
Me.PAEEnabledDataGridViewCheckBoxColumn.DataPropertyName = "PAEEnabled"
Me.PAEEnabledDataGridViewCheckBoxColumn.HeaderText = "PAEEnabled"
Me.PAEEnabledDataGridViewCheckBoxColumn.Name = "PAEEnabledDataGridViewCheckBoxColumn"
Me.PAEEnabledDataGridViewCheckBoxColumn.ReadOnly = true
'
'PlusProductIDDataGridViewTextBoxColumn
'
Me.PlusProductIDDataGridViewTextBoxColumn.DataPropertyName = "PlusProductID"
Me.PlusProductIDDataGridViewTextBoxColumn.HeaderText = "PlusProductID"
Me.PlusProductIDDataGridViewTextBoxColumn.Name = "PlusProductIDDataGridViewTextBoxColumn"
Me.PlusProductIDDataGridViewTextBoxColumn.ReadOnly = true
'
'PlusVersionNumberDataGridViewTextBoxColumn
'
Me.PlusVersionNumberDataGridViewTextBoxColumn.DataPropertyName = "PlusVersionNumber"
Me.PlusVersionNumberDataGridViewTextBoxColumn.HeaderText = "PlusVersionNumber"
Me.PlusVersionNumberDataGridViewTextBoxColumn.Name = "PlusVersionNumberDataGridViewTextBoxColumn"
Me.PlusVersionNumberDataGridViewTextBoxColumn.ReadOnly = true
'
'ProductTypeDataGridViewTextBoxColumn
'
Me.ProductTypeDataGridViewTextBoxColumn.DataPropertyName = "ProductType"
Me.ProductTypeDataGridViewTextBoxColumn.HeaderText = "ProductType"
Me.ProductTypeDataGridViewTextBoxColumn.Name = "ProductTypeDataGridViewTextBoxColumn"
Me.ProductTypeDataGridViewTextBoxColumn.ReadOnly = true
'
'PrimaryDataGridViewCheckBoxColumn
'
Me.PrimaryDataGridViewCheckBoxColumn.DataPropertyName = "Primary"
Me.PrimaryDataGridViewCheckBoxColumn.HeaderText = "Primary"
Me.PrimaryDataGridViewCheckBoxColumn.Name = "PrimaryDataGridViewCheckBoxColumn"
Me.PrimaryDataGridViewCheckBoxColumn.ReadOnly = true
'
'QuantumLengthDataGridViewTextBoxColumn
'
Me.QuantumLengthDataGridViewTextBoxColumn.DataPropertyName = "QuantumLength"
Me.QuantumLengthDataGridViewTextBoxColumn.HeaderText = "QuantumLength"
Me.QuantumLengthDataGridViewTextBoxColumn.Name = "QuantumLengthDataGridViewTextBoxColumn"
Me.QuantumLengthDataGridViewTextBoxColumn.ReadOnly = true
'
'QuantumTypeDataGridViewTextBoxColumn
'
Me.QuantumTypeDataGridViewTextBoxColumn.DataPropertyName = "QuantumType"
Me.QuantumTypeDataGridViewTextBoxColumn.HeaderText = "QuantumType"
Me.QuantumTypeDataGridViewTextBoxColumn.Name = "QuantumTypeDataGridViewTextBoxColumn"
Me.QuantumTypeDataGridViewTextBoxColumn.ReadOnly = true
'
'RegisteredUserDataGridViewTextBoxColumn
'
Me.RegisteredUserDataGridViewTextBoxColumn.DataPropertyName = "RegisteredUser"
Me.RegisteredUserDataGridViewTextBoxColumn.HeaderText = "RegisteredUser"
Me.RegisteredUserDataGridViewTextBoxColumn.Name = "RegisteredUserDataGridViewTextBoxColumn"
Me.RegisteredUserDataGridViewTextBoxColumn.ReadOnly = true
'
'SerialNumberDataGridViewTextBoxColumn2
'
Me.SerialNumberDataGridViewTextBoxColumn2.DataPropertyName = "SerialNumber"
Me.SerialNumberDataGridViewTextBoxColumn2.HeaderText = "SerialNumber"
Me.SerialNumberDataGridViewTextBoxColumn2.Name = "SerialNumberDataGridViewTextBoxColumn2"
Me.SerialNumberDataGridViewTextBoxColumn2.ReadOnly = true
'
'ServicePackMajorVersionDataGridViewTextBoxColumn
'
Me.ServicePackMajorVersionDataGridViewTextBoxColumn.DataPropertyName = "ServicePackMajorVersion"
Me.ServicePackMajorVersionDataGridViewTextBoxColumn.HeaderText = "ServicePackMajorVersion"
Me.ServicePackMajorVersionDataGridViewTextBoxColumn.Name = "ServicePackMajorVersionDataGridViewTextBoxColumn"
Me.ServicePackMajorVersionDataGridViewTextBoxColumn.ReadOnly = true
'
'ServicePackMinorVersionDataGridViewTextBoxColumn
'
Me.ServicePackMinorVersionDataGridViewTextBoxColumn.DataPropertyName = "ServicePackMinorVersion"
Me.ServicePackMinorVersionDataGridViewTextBoxColumn.HeaderText = "ServicePackMinorVersion"
Me.ServicePackMinorVersionDataGridViewTextBoxColumn.Name = "ServicePackMinorVersionDataGridViewTextBoxColumn"
Me.ServicePackMinorVersionDataGridViewTextBoxColumn.ReadOnly = true
'
'SizeStoredInPagingFilesDataGridViewTextBoxColumn
'
Me.SizeStoredInPagingFilesDataGridViewTextBoxColumn.DataPropertyName = "SizeStoredInPagingFiles"
Me.SizeStoredInPagingFilesDataGridViewTextBoxColumn.HeaderText = "SizeStoredInPagingFiles"
Me.SizeStoredInPagingFilesDataGridViewTextBoxColumn.Name = "SizeStoredInPagingFilesDataGridViewTextBoxColumn"
Me.SizeStoredInPagingFilesDataGridViewTextBoxColumn.ReadOnly = true
'
'StatusDataGridViewTextBoxColumn7
'
Me.StatusDataGridViewTextBoxColumn7.DataPropertyName = "Status"
Me.StatusDataGridViewTextBoxColumn7.HeaderText = "Status"
Me.StatusDataGridViewTextBoxColumn7.Name = "StatusDataGridViewTextBoxColumn7"
Me.StatusDataGridViewTextBoxColumn7.ReadOnly = true
'
'SuiteMaskDataGridViewTextBoxColumn
'
Me.SuiteMaskDataGridViewTextBoxColumn.DataPropertyName = "SuiteMask"
Me.SuiteMaskDataGridViewTextBoxColumn.HeaderText = "SuiteMask"
Me.SuiteMaskDataGridViewTextBoxColumn.Name = "SuiteMaskDataGridViewTextBoxColumn"
Me.SuiteMaskDataGridViewTextBoxColumn.ReadOnly = true
'
'SystemDeviceDataGridViewTextBoxColumn
'
Me.SystemDeviceDataGridViewTextBoxColumn.DataPropertyName = "SystemDevice"
Me.SystemDeviceDataGridViewTextBoxColumn.HeaderText = "SystemDevice"
Me.SystemDeviceDataGridViewTextBoxColumn.Name = "SystemDeviceDataGridViewTextBoxColumn"
Me.SystemDeviceDataGridViewTextBoxColumn.ReadOnly = true
'
'SystemDirectoryDataGridViewTextBoxColumn
'
Me.SystemDirectoryDataGridViewTextBoxColumn.DataPropertyName = "SystemDirectory"
Me.SystemDirectoryDataGridViewTextBoxColumn.HeaderText = "SystemDirectory"
Me.SystemDirectoryDataGridViewTextBoxColumn.Name = "SystemDirectoryDataGridViewTextBoxColumn"
Me.SystemDirectoryDataGridViewTextBoxColumn.ReadOnly = true
'
'SystemDriveDataGridViewTextBoxColumn
'
Me.SystemDriveDataGridViewTextBoxColumn.DataPropertyName = "SystemDrive"
Me.SystemDriveDataGridViewTextBoxColumn.HeaderText = "SystemDrive"
Me.SystemDriveDataGridViewTextBoxColumn.Name = "SystemDriveDataGridViewTextBoxColumn"
Me.SystemDriveDataGridViewTextBoxColumn.ReadOnly = true
'
'TotalSwapSpaceSizeDataGridViewTextBoxColumn
'
Me.TotalSwapSpaceSizeDataGridViewTextBoxColumn.DataPropertyName = "TotalSwapSpaceSize"
Me.TotalSwapSpaceSizeDataGridViewTextBoxColumn.HeaderText = "TotalSwapSpaceSize"
Me.TotalSwapSpaceSizeDataGridViewTextBoxColumn.Name = "TotalSwapSpaceSizeDataGridViewTextBoxColumn"
Me.TotalSwapSpaceSizeDataGridViewTextBoxColumn.ReadOnly = true
'
'TotalVirtualMemorySizeDataGridViewTextBoxColumn
'
Me.TotalVirtualMemorySizeDataGridViewTextBoxColumn.DataPropertyName = "TotalVirtualMemorySize"
Me.TotalVirtualMemorySizeDataGridViewTextBoxColumn.HeaderText = "TotalVirtualMemorySize"
Me.TotalVirtualMemorySizeDataGridViewTextBoxColumn.Name = "TotalVirtualMemorySizeDataGridViewTextBoxColumn"
Me.TotalVirtualMemorySizeDataGridViewTextBoxColumn.ReadOnly = true
'
'TotalVisibleMemorySizeDataGridViewTextBoxColumn
'
Me.TotalVisibleMemorySizeDataGridViewTextBoxColumn.DataPropertyName = "TotalVisibleMemorySize"
Me.TotalVisibleMemorySizeDataGridViewTextBoxColumn.HeaderText = "TotalVisibleMemorySize"
Me.TotalVisibleMemorySizeDataGridViewTextBoxColumn.Name = "TotalVisibleMemorySizeDataGridViewTextBoxColumn"
Me.TotalVisibleMemorySizeDataGridViewTextBoxColumn.ReadOnly = true
'
'VersionDataGridViewTextBoxColumn1
'
Me.VersionDataGridViewTextBoxColumn1.DataPropertyName = "Version"
Me.VersionDataGridViewTextBoxColumn1.HeaderText = "Version"
Me.VersionDataGridViewTextBoxColumn1.Name = "VersionDataGridViewTextBoxColumn1"
Me.VersionDataGridViewTextBoxColumn1.ReadOnly = true
'
'WindowsDirectoryDataGridViewTextBoxColumn
'
Me.WindowsDirectoryDataGridViewTextBoxColumn.DataPropertyName = "WindowsDirectory"
Me.WindowsDirectoryDataGridViewTextBoxColumn.HeaderText = "WindowsDirectory"
Me.WindowsDirectoryDataGridViewTextBoxColumn.Name = "WindowsDirectoryDataGridViewTextBoxColumn"
Me.WindowsDirectoryDataGridViewTextBoxColumn.ReadOnly = true
'
'Win32OperatingSystemBindingSource
'
Me.Win32OperatingSystemBindingSource.DataSource = GetType(WMIwrapper.Win32_OperatingSystem)
'
'PanelEmpty
'
Me.PanelEmpty.Dock = System.Windows.Forms.DockStyle.Fill
Me.PanelEmpty.Location = New System.Drawing.Point(0, 0)
Me.PanelEmpty.Name = "PanelEmpty"
Me.PanelEmpty.Size = New System.Drawing.Size(468, 183)
Me.PanelEmpty.TabIndex = 0
'
'PanelNetworkAdapterConfiguration
'
Me.PanelNetworkAdapterConfiguration.Controls.Add(Me.dgvNetworkAdapterConfiguration)
Me.PanelNetworkAdapterConfiguration.Dock = System.Windows.Forms.DockStyle.Fill
Me.PanelNetworkAdapterConfiguration.Location = New System.Drawing.Point(0, 0)
Me.PanelNetworkAdapterConfiguration.Name = "PanelNetworkAdapterConfiguration"
Me.PanelNetworkAdapterConfiguration.Size = New System.Drawing.Size(468, 183)
Me.PanelNetworkAdapterConfiguration.TabIndex = 11
'
'dgvNetworkAdapterConfiguration
'
Me.dgvNetworkAdapterConfiguration.AllowUserToAddRows = false
Me.dgvNetworkAdapterConfiguration.AllowUserToDeleteRows = false
Me.dgvNetworkAdapterConfiguration.AutoGenerateColumns = false
Me.dgvNetworkAdapterConfiguration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
Me.dgvNetworkAdapterConfiguration.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ArpAlwaysSourceRouteDataGridViewCheckBoxColumn, Me.ArpUseEtherSNAPDataGridViewCheckBoxColumn, Me.CaptionDataGridViewTextBoxColumn7, Me.DatabasePathDataGridViewTextBoxColumn, Me.DeadGWDetectEnabledDataGridViewCheckBoxColumn, Me.DefaultTOSDataGridViewTextBoxColumn, Me.DefaultTTLDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn7, Me.DHCPEnabledDataGridViewCheckBoxColumn, Me.DHCPLeaseExpiresDataGridViewTextBoxColumn, Me.DHCPLeaseObtainedDataGridViewTextBoxColumn, Me.DHCPServerDataGridViewTextBoxColumn, Me.DNSDomainDataGridViewTextBoxColumn, Me.DNSEnabledForWINSResolutionDataGridViewCheckBoxColumn, Me.DNSHostNameDataGridViewTextBoxColumn, Me.DomainDNSRegistrationEnabledDataGridViewCheckBoxColumn, Me.ForwardBufferMemoryDataGridViewTextBoxColumn, Me.FullDNSRegistrationEnabledDataGridViewCheckBoxColumn, Me.IGMPLevelDataGridViewTextBoxColumn, Me.IndexDataGridViewTextBoxColumn2, Me.InterfaceIndexDataGridViewTextBoxColumn1, Me.IPConnectionMetricDataGridViewTextBoxColumn, Me.IPEnabledDataGridViewCheckBoxColumn, Me.IPFilterSecurityEnabledDataGridViewCheckBoxColumn, Me.IPUseZeroBroadcastDataGridViewCheckBoxColumn, Me.KeepAliveIntervalDataGridViewTextBoxColumn, Me.KeepAliveTimeDataGridViewTextBoxColumn, Me.MACAddressDataGridViewTextBoxColumn1, Me.MTUDataGridViewTextBoxColumn, Me.NumForwardPacketsDataGridViewTextBoxColumn, Me.PMTUBHDetectEnabledDataGridViewCheckBoxColumn, Me.PMTUDiscoveryEnabledDataGridViewCheckBoxColumn, Me.ServiceNameDataGridViewTextBoxColumn1, Me.SettingIDDataGridViewTextBoxColumn, Me.TcpMaxConnectRetransmissionsDataGridViewTextBoxColumn, Me.TcpMaxDataRetransmissionsDataGridViewTextBoxColumn, Me.TcpipNetbiosOptionsDataGridViewTextBoxColumn, Me.TcpNumConnectionsDataGridViewTextBoxColumn, Me.TcpUseRFC1122UrgentPointerDataGridViewCheckBoxColumn, Me.TcpWindowSizeDataGridViewTextBoxColumn, Me.WINSScopeIDDataGridViewTextBoxColumn, Me.WINSHostLookupFileDataGridViewTextBoxColumn, Me.WINSEnableLMHostsLookupDataGridViewCheckBoxColumn, Me.WINSPrimaryServerDataGridViewTextBoxColumn, Me.WINSSecondaryServerDataGridViewTextBoxColumn})
Me.dgvNetworkAdapterConfiguration.DataSource = Me.Win32NetworkAdapterConfigurationBindingSource
Me.dgvNetworkAdapterConfiguration.Dock = System.Windows.Forms.DockStyle.Fill
Me.dgvNetworkAdapterConfiguration.Location = New System.Drawing.Point(0, 0)
Me.dgvNetworkAdapterConfiguration.Name = "dgvNetworkAdapterConfiguration"
Me.dgvNetworkAdapterConfiguration.ReadOnly = true
Me.dgvNetworkAdapterConfiguration.Size = New System.Drawing.Size(468, 183)
Me.dgvNetworkAdapterConfiguration.TabIndex = 22
'
'ArpAlwaysSourceRouteDataGridViewCheckBoxColumn
'
Me.ArpAlwaysSourceRouteDataGridViewCheckBoxColumn.DataPropertyName = "ArpAlwaysSourceRoute"
Me.ArpAlwaysSourceRouteDataGridViewCheckBoxColumn.HeaderText = "ArpAlwaysSourceRoute"
Me.ArpAlwaysSourceRouteDataGridViewCheckBoxColumn.Name = "ArpAlwaysSourceRouteDataGridViewCheckBoxColumn"
Me.ArpAlwaysSourceRouteDataGridViewCheckBoxColumn.ReadOnly = true
'
'ArpUseEtherSNAPDataGridViewCheckBoxColumn
'
Me.ArpUseEtherSNAPDataGridViewCheckBoxColumn.DataPropertyName = "ArpUseEtherSNAP"
Me.ArpUseEtherSNAPDataGridViewCheckBoxColumn.HeaderText = "ArpUseEtherSNAP"
Me.ArpUseEtherSNAPDataGridViewCheckBoxColumn.Name = "ArpUseEtherSNAPDataGridViewCheckBoxColumn"
Me.ArpUseEtherSNAPDataGridViewCheckBoxColumn.ReadOnly = true
'
'CaptionDataGridViewTextBoxColumn7
'
Me.CaptionDataGridViewTextBoxColumn7.DataPropertyName = "Caption"
Me.CaptionDataGridViewTextBoxColumn7.HeaderText = "Caption"
Me.CaptionDataGridViewTextBoxColumn7.Name = "CaptionDataGridViewTextBoxColumn7"
Me.CaptionDataGridViewTextBoxColumn7.ReadOnly = true
'
'DatabasePathDataGridViewTextBoxColumn
'
Me.DatabasePathDataGridViewTextBoxColumn.DataPropertyName = "DatabasePath"
Me.DatabasePathDataGridViewTextBoxColumn.HeaderText = "DatabasePath"
Me.DatabasePathDataGridViewTextBoxColumn.Name = "DatabasePathDataGridViewTextBoxColumn"
Me.DatabasePathDataGridViewTextBoxColumn.ReadOnly = true
'
'DeadGWDetectEnabledDataGridViewCheckBoxColumn
'
Me.DeadGWDetectEnabledDataGridViewCheckBoxColumn.DataPropertyName = "DeadGWDetectEnabled"
Me.DeadGWDetectEnabledDataGridViewCheckBoxColumn.HeaderText = "DeadGWDetectEnabled"
Me.DeadGWDetectEnabledDataGridViewCheckBoxColumn.Name = "DeadGWDetectEnabledDataGridViewCheckBoxColumn"
Me.DeadGWDetectEnabledDataGridViewCheckBoxColumn.ReadOnly = true
'
'DefaultTOSDataGridViewTextBoxColumn
'
Me.DefaultTOSDataGridViewTextBoxColumn.DataPropertyName = "DefaultTOS"
Me.DefaultTOSDataGridViewTextBoxColumn.HeaderText = "DefaultTOS"
Me.DefaultTOSDataGridViewTextBoxColumn.Name = "DefaultTOSDataGridViewTextBoxColumn"
Me.DefaultTOSDataGridViewTextBoxColumn.ReadOnly = true
'
'DefaultTTLDataGridViewTextBoxColumn
'
Me.DefaultTTLDataGridViewTextBoxColumn.DataPropertyName = "DefaultTTL"
Me.DefaultTTLDataGridViewTextBoxColumn.HeaderText = "DefaultTTL"
Me.DefaultTTLDataGridViewTextBoxColumn.Name = "DefaultTTLDataGridViewTextBoxColumn"
Me.DefaultTTLDataGridViewTextBoxColumn.ReadOnly = true
'
'DescriptionDataGridViewTextBoxColumn7
'
Me.DescriptionDataGridViewTextBoxColumn7.DataPropertyName = "Description"
Me.DescriptionDataGridViewTextBoxColumn7.HeaderText = "Description"
Me.DescriptionDataGridViewTextBoxColumn7.Name = "DescriptionDataGridViewTextBoxColumn7"
Me.DescriptionDataGridViewTextBoxColumn7.ReadOnly = true
'
'DHCPEnabledDataGridViewCheckBoxColumn
'
Me.DHCPEnabledDataGridViewCheckBoxColumn.DataPropertyName = "DHCPEnabled"
Me.DHCPEnabledDataGridViewCheckBoxColumn.HeaderText = "DHCPEnabled"
Me.DHCPEnabledDataGridViewCheckBoxColumn.Name = "DHCPEnabledDataGridViewCheckBoxColumn"
Me.DHCPEnabledDataGridViewCheckBoxColumn.ReadOnly = true
'
'DHCPLeaseExpiresDataGridViewTextBoxColumn
'
Me.DHCPLeaseExpiresDataGridViewTextBoxColumn.DataPropertyName = "DHCPLeaseExpires"
Me.DHCPLeaseExpiresDataGridViewTextBoxColumn.HeaderText = "DHCPLeaseExpires"
Me.DHCPLeaseExpiresDataGridViewTextBoxColumn.Name = "DHCPLeaseExpiresDataGridViewTextBoxColumn"
Me.DHCPLeaseExpiresDataGridViewTextBoxColumn.ReadOnly = true
'
'DHCPLeaseObtainedDataGridViewTextBoxColumn
'
Me.DHCPLeaseObtainedDataGridViewTextBoxColumn.DataPropertyName = "DHCPLeaseObtained"
Me.DHCPLeaseObtainedDataGridViewTextBoxColumn.HeaderText = "DHCPLeaseObtained"
Me.DHCPLeaseObtainedDataGridViewTextBoxColumn.Name = "DHCPLeaseObtainedDataGridViewTextBoxColumn"
Me.DHCPLeaseObtainedDataGridViewTextBoxColumn.ReadOnly = true
'
'DHCPServerDataGridViewTextBoxColumn
'
Me.DHCPServerDataGridViewTextBoxColumn.DataPropertyName = "DHCPServer"
Me.DHCPServerDataGridViewTextBoxColumn.HeaderText = "DHCPServer"
Me.DHCPServerDataGridViewTextBoxColumn.Name = "DHCPServerDataGridViewTextBoxColumn"
Me.DHCPServerDataGridViewTextBoxColumn.ReadOnly = true
'
'DNSDomainDataGridViewTextBoxColumn
'
Me.DNSDomainDataGridViewTextBoxColumn.DataPropertyName = "DNSDomain"
Me.DNSDomainDataGridViewTextBoxColumn.HeaderText = "DNSDomain"
Me.DNSDomainDataGridViewTextBoxColumn.Name = "DNSDomainDataGridViewTextBoxColumn"
Me.DNSDomainDataGridViewTextBoxColumn.ReadOnly = true
'
'DNSEnabledForWINSResolutionDataGridViewCheckBoxColumn
'
Me.DNSEnabledForWINSResolutionDataGridViewCheckBoxColumn.DataPropertyName = "DNSEnabledForWINSResolution"
Me.DNSEnabledForWINSResolutionDataGridViewCheckBoxColumn.HeaderText = "DNSEnabledForWINSResolution"
Me.DNSEnabledForWINSResolutionDataGridViewCheckBoxColumn.Name = "DNSEnabledForWINSResolutionDataGridViewCheckBoxColumn"
Me.DNSEnabledForWINSResolutionDataGridViewCheckBoxColumn.ReadOnly = true
'
'DNSHostNameDataGridViewTextBoxColumn
'
Me.DNSHostNameDataGridViewTextBoxColumn.DataPropertyName = "DNSHostName"
Me.DNSHostNameDataGridViewTextBoxColumn.HeaderText = "DNSHostName"
Me.DNSHostNameDataGridViewTextBoxColumn.Name = "DNSHostNameDataGridViewTextBoxColumn"
Me.DNSHostNameDataGridViewTextBoxColumn.ReadOnly = true
'
'DomainDNSRegistrationEnabledDataGridViewCheckBoxColumn
'
Me.DomainDNSRegistrationEnabledDataGridViewCheckBoxColumn.DataPropertyName = "DomainDNSRegistrationEnabled"
Me.DomainDNSRegistrationEnabledDataGridViewCheckBoxColumn.HeaderText = "DomainDNSRegistrationEnabled"
Me.DomainDNSRegistrationEnabledDataGridViewCheckBoxColumn.Name = "DomainDNSRegistrationEnabledDataGridViewCheckBoxColumn"
Me.DomainDNSRegistrationEnabledDataGridViewCheckBoxColumn.ReadOnly = true
'
'ForwardBufferMemoryDataGridViewTextBoxColumn
'
Me.ForwardBufferMemoryDataGridViewTextBoxColumn.DataPropertyName = "ForwardBufferMemory"
Me.ForwardBufferMemoryDataGridViewTextBoxColumn.HeaderText = "ForwardBufferMemory"
Me.ForwardBufferMemoryDataGridViewTextBoxColumn.Name = "ForwardBufferMemoryDataGridViewTextBoxColumn"
Me.ForwardBufferMemoryDataGridViewTextBoxColumn.ReadOnly = true
'
'FullDNSRegistrationEnabledDataGridViewCheckBoxColumn
'
Me.FullDNSRegistrationEnabledDataGridViewCheckBoxColumn.DataPropertyName = "FullDNSRegistrationEnabled"
Me.FullDNSRegistrationEnabledDataGridViewCheckBoxColumn.HeaderText = "FullDNSRegistrationEnabled"
Me.FullDNSRegistrationEnabledDataGridViewCheckBoxColumn.Name = "FullDNSRegistrationEnabledDataGridViewCheckBoxColumn"
Me.FullDNSRegistrationEnabledDataGridViewCheckBoxColumn.ReadOnly = true
'
'IGMPLevelDataGridViewTextBoxColumn
'
Me.IGMPLevelDataGridViewTextBoxColumn.DataPropertyName = "IGMPLevel"
Me.IGMPLevelDataGridViewTextBoxColumn.HeaderText = "IGMPLevel"
Me.IGMPLevelDataGridViewTextBoxColumn.Name = "IGMPLevelDataGridViewTextBoxColumn"
Me.IGMPLevelDataGridViewTextBoxColumn.ReadOnly = true
'
'IndexDataGridViewTextBoxColumn2
'
Me.IndexDataGridViewTextBoxColumn2.DataPropertyName = "Index"
Me.IndexDataGridViewTextBoxColumn2.HeaderText = "Index"
Me.IndexDataGridViewTextBoxColumn2.Name = "IndexDataGridViewTextBoxColumn2"
Me.IndexDataGridViewTextBoxColumn2.ReadOnly = true
'
'InterfaceIndexDataGridViewTextBoxColumn1
'
Me.InterfaceIndexDataGridViewTextBoxColumn1.DataPropertyName = "InterfaceIndex"
Me.InterfaceIndexDataGridViewTextBoxColumn1.HeaderText = "InterfaceIndex"
Me.InterfaceIndexDataGridViewTextBoxColumn1.Name = "InterfaceIndexDataGridViewTextBoxColumn1"
Me.InterfaceIndexDataGridViewTextBoxColumn1.ReadOnly = true
'
'IPConnectionMetricDataGridViewTextBoxColumn
'
Me.IPConnectionMetricDataGridViewTextBoxColumn.DataPropertyName = "IPConnectionMetric"
Me.IPConnectionMetricDataGridViewTextBoxColumn.HeaderText = "IPConnectionMetric"
Me.IPConnectionMetricDataGridViewTextBoxColumn.Name = "IPConnectionMetricDataGridViewTextBoxColumn"
Me.IPConnectionMetricDataGridViewTextBoxColumn.ReadOnly = true
'
'IPEnabledDataGridViewCheckBoxColumn
'
Me.IPEnabledDataGridViewCheckBoxColumn.DataPropertyName = "IPEnabled"
Me.IPEnabledDataGridViewCheckBoxColumn.HeaderText = "IPEnabled"
Me.IPEnabledDataGridViewCheckBoxColumn.Name = "IPEnabledDataGridViewCheckBoxColumn"
Me.IPEnabledDataGridViewCheckBoxColumn.ReadOnly = true
'
'IPFilterSecurityEnabledDataGridViewCheckBoxColumn
'
Me.IPFilterSecurityEnabledDataGridViewCheckBoxColumn.DataPropertyName = "IPFilterSecurityEnabled"
Me.IPFilterSecurityEnabledDataGridViewCheckBoxColumn.HeaderText = "IPFilterSecurityEnabled"
Me.IPFilterSecurityEnabledDataGridViewCheckBoxColumn.Name = "IPFilterSecurityEnabledDataGridViewCheckBoxColumn"
Me.IPFilterSecurityEnabledDataGridViewCheckBoxColumn.ReadOnly = true
'
'IPUseZeroBroadcastDataGridViewCheckBoxColumn
'
Me.IPUseZeroBroadcastDataGridViewCheckBoxColumn.DataPropertyName = "IPUseZeroBroadcast"
Me.IPUseZeroBroadcastDataGridViewCheckBoxColumn.HeaderText = "IPUseZeroBroadcast"
Me.IPUseZeroBroadcastDataGridViewCheckBoxColumn.Name = "IPUseZeroBroadcastDataGridViewCheckBoxColumn"
Me.IPUseZeroBroadcastDataGridViewCheckBoxColumn.ReadOnly = true
'
'KeepAliveIntervalDataGridViewTextBoxColumn
'
Me.KeepAliveIntervalDataGridViewTextBoxColumn.DataPropertyName = "KeepAliveInterval"
Me.KeepAliveIntervalDataGridViewTextBoxColumn.HeaderText = "KeepAliveInterval"
Me.KeepAliveIntervalDataGridViewTextBoxColumn.Name = "KeepAliveIntervalDataGridViewTextBoxColumn"
Me.KeepAliveIntervalDataGridViewTextBoxColumn.ReadOnly = true
'
'KeepAliveTimeDataGridViewTextBoxColumn
'
Me.KeepAliveTimeDataGridViewTextBoxColumn.DataPropertyName = "KeepAliveTime"
Me.KeepAliveTimeDataGridViewTextBoxColumn.HeaderText = "KeepAliveTime"
Me.KeepAliveTimeDataGridViewTextBoxColumn.Name = "KeepAliveTimeDataGridViewTextBoxColumn"
Me.KeepAliveTimeDataGridViewTextBoxColumn.ReadOnly = true
'
'MACAddressDataGridViewTextBoxColumn1
'
Me.MACAddressDataGridViewTextBoxColumn1.DataPropertyName = "MACAddress"
Me.MACAddressDataGridViewTextBoxColumn1.HeaderText = "MACAddress"
Me.MACAddressDataGridViewTextBoxColumn1.Name = "MACAddressDataGridViewTextBoxColumn1"
Me.MACAddressDataGridViewTextBoxColumn1.ReadOnly = true
'
'MTUDataGridViewTextBoxColumn
'
Me.MTUDataGridViewTextBoxColumn.DataPropertyName = "MTU"
Me.MTUDataGridViewTextBoxColumn.HeaderText = "MTU"
Me.MTUDataGridViewTextBoxColumn.Name = "MTUDataGridViewTextBoxColumn"
Me.MTUDataGridViewTextBoxColumn.ReadOnly = true
'
'NumForwardPacketsDataGridViewTextBoxColumn
'
Me.NumForwardPacketsDataGridViewTextBoxColumn.DataPropertyName = "NumForwardPackets"
Me.NumForwardPacketsDataGridViewTextBoxColumn.HeaderText = "NumForwardPackets"
Me.NumForwardPacketsDataGridViewTextBoxColumn.Name = "NumForwardPacketsDataGridViewTextBoxColumn"
Me.NumForwardPacketsDataGridViewTextBoxColumn.ReadOnly = true
'
'PMTUBHDetectEnabledDataGridViewCheckBoxColumn
'
Me.PMTUBHDetectEnabledDataGridViewCheckBoxColumn.DataPropertyName = "PMTUBHDetectEnabled"
Me.PMTUBHDetectEnabledDataGridViewCheckBoxColumn.HeaderText = "PMTUBHDetectEnabled"
Me.PMTUBHDetectEnabledDataGridViewCheckBoxColumn.Name = "PMTUBHDetectEnabledDataGridViewCheckBoxColumn"
Me.PMTUBHDetectEnabledDataGridViewCheckBoxColumn.ReadOnly = true
'
'PMTUDiscoveryEnabledDataGridViewCheckBoxColumn
'
Me.PMTUDiscoveryEnabledDataGridViewCheckBoxColumn.DataPropertyName = "PMTUDiscoveryEnabled"
Me.PMTUDiscoveryEnabledDataGridViewCheckBoxColumn.HeaderText = "PMTUDiscoveryEnabled"
Me.PMTUDiscoveryEnabledDataGridViewCheckBoxColumn.Name = "PMTUDiscoveryEnabledDataGridViewCheckBoxColumn"
Me.PMTUDiscoveryEnabledDataGridViewCheckBoxColumn.ReadOnly = true
'
'ServiceNameDataGridViewTextBoxColumn1
'
Me.ServiceNameDataGridViewTextBoxColumn1.DataPropertyName = "ServiceName"
Me.ServiceNameDataGridViewTextBoxColumn1.HeaderText = "ServiceName"
Me.ServiceNameDataGridViewTextBoxColumn1.Name = "ServiceNameDataGridViewTextBoxColumn1"
Me.ServiceNameDataGridViewTextBoxColumn1.ReadOnly = true
'
'SettingIDDataGridViewTextBoxColumn
'
Me.SettingIDDataGridViewTextBoxColumn.DataPropertyName = "SettingID"
Me.SettingIDDataGridViewTextBoxColumn.HeaderText = "SettingID"
Me.SettingIDDataGridViewTextBoxColumn.Name = "SettingIDDataGridViewTextBoxColumn"
Me.SettingIDDataGridViewTextBoxColumn.ReadOnly = true
'
'TcpMaxConnectRetransmissionsDataGridViewTextBoxColumn
'
Me.TcpMaxConnectRetransmissionsDataGridViewTextBoxColumn.DataPropertyName = "TcpMaxConnectRetransmissions"
Me.TcpMaxConnectRetransmissionsDataGridViewTextBoxColumn.HeaderText = "TcpMaxConnectRetransmissions"
Me.TcpMaxConnectRetransmissionsDataGridViewTextBoxColumn.Name = "TcpMaxConnectRetransmissionsDataGridViewTextBoxColumn"
Me.TcpMaxConnectRetransmissionsDataGridViewTextBoxColumn.ReadOnly = true
'
'TcpMaxDataRetransmissionsDataGridViewTextBoxColumn
'
Me.TcpMaxDataRetransmissionsDataGridViewTextBoxColumn.DataPropertyName = "TcpMaxDataRetransmissions"
Me.TcpMaxDataRetransmissionsDataGridViewTextBoxColumn.HeaderText = "TcpMaxDataRetransmissions"
Me.TcpMaxDataRetransmissionsDataGridViewTextBoxColumn.Name = "TcpMaxDataRetransmissionsDataGridViewTextBoxColumn"
Me.TcpMaxDataRetransmissionsDataGridViewTextBoxColumn.ReadOnly = true
'
'TcpipNetbiosOptionsDataGridViewTextBoxColumn
'
Me.TcpipNetbiosOptionsDataGridViewTextBoxColumn.DataPropertyName = "TcpipNetbiosOptions"
Me.TcpipNetbiosOptionsDataGridViewTextBoxColumn.HeaderText = "TcpipNetbiosOptions"
Me.TcpipNetbiosOptionsDataGridViewTextBoxColumn.Name = "TcpipNetbiosOptionsDataGridViewTextBoxColumn"
Me.TcpipNetbiosOptionsDataGridViewTextBoxColumn.ReadOnly = true
'
'TcpNumConnectionsDataGridViewTextBoxColumn
'
Me.TcpNumConnectionsDataGridViewTextBoxColumn.DataPropertyName = "TcpNumConnections"
Me.TcpNumConnectionsDataGridViewTextBoxColumn.HeaderText = "TcpNumConnections"
Me.TcpNumConnectionsDataGridViewTextBoxColumn.Name = "TcpNumConnectionsDataGridViewTextBoxColumn"
Me.TcpNumConnectionsDataGridViewTextBoxColumn.ReadOnly = true
'
'TcpUseRFC1122UrgentPointerDataGridViewCheckBoxColumn
'
Me.TcpUseRFC1122UrgentPointerDataGridViewCheckBoxColumn.DataPropertyName = "TcpUseRFC1122UrgentPointer"
Me.TcpUseRFC1122UrgentPointerDataGridViewCheckBoxColumn.HeaderText = "TcpUseRFC1122UrgentPointer"
Me.TcpUseRFC1122UrgentPointerDataGridViewCheckBoxColumn.Name = "TcpUseRFC1122UrgentPointerDataGridViewCheckBoxColumn"
Me.TcpUseRFC1122UrgentPointerDataGridViewCheckBoxColumn.ReadOnly = true
'
'TcpWindowSizeDataGridViewTextBoxColumn
'
Me.TcpWindowSizeDataGridViewTextBoxColumn.DataPropertyName = "TcpWindowSize"
Me.TcpWindowSizeDataGridViewTextBoxColumn.HeaderText = "TcpWindowSize"
Me.TcpWindowSizeDataGridViewTextBoxColumn.Name = "TcpWindowSizeDataGridViewTextBoxColumn"
Me.TcpWindowSizeDataGridViewTextBoxColumn.ReadOnly = true
'
'WINSScopeIDDataGridViewTextBoxColumn
'
Me.WINSScopeIDDataGridViewTextBoxColumn.DataPropertyName = "WINSScopeID"
Me.WINSScopeIDDataGridViewTextBoxColumn.HeaderText = "WINSScopeID"
Me.WINSScopeIDDataGridViewTextBoxColumn.Name = "WINSScopeIDDataGridViewTextBoxColumn"
Me.WINSScopeIDDataGridViewTextBoxColumn.ReadOnly = true
'
'WINSHostLookupFileDataGridViewTextBoxColumn
'
Me.WINSHostLookupFileDataGridViewTextBoxColumn.DataPropertyName = "WINSHostLookupFile"
Me.WINSHostLookupFileDataGridViewTextBoxColumn.HeaderText = "WINSHostLookupFile"
Me.WINSHostLookupFileDataGridViewTextBoxColumn.Name = "WINSHostLookupFileDataGridViewTextBoxColumn"
Me.WINSHostLookupFileDataGridViewTextBoxColumn.ReadOnly = true
'
'WINSEnableLMHostsLookupDataGridViewCheckBoxColumn
'
Me.WINSEnableLMHostsLookupDataGridViewCheckBoxColumn.DataPropertyName = "WINSEnableLMHostsLookup"
Me.WINSEnableLMHostsLookupDataGridViewCheckBoxColumn.HeaderText = "WINSEnableLMHostsLookup"
Me.WINSEnableLMHostsLookupDataGridViewCheckBoxColumn.Name = "WINSEnableLMHostsLookupDataGridViewCheckBoxColumn"
Me.WINSEnableLMHostsLookupDataGridViewCheckBoxColumn.ReadOnly = true
'
'WINSPrimaryServerDataGridViewTextBoxColumn
'
Me.WINSPrimaryServerDataGridViewTextBoxColumn.DataPropertyName = "WINSPrimaryServer"
Me.WINSPrimaryServerDataGridViewTextBoxColumn.HeaderText = "WINSPrimaryServer"
Me.WINSPrimaryServerDataGridViewTextBoxColumn.Name = "WINSPrimaryServerDataGridViewTextBoxColumn"
Me.WINSPrimaryServerDataGridViewTextBoxColumn.ReadOnly = true
'
'WINSSecondaryServerDataGridViewTextBoxColumn
'
Me.WINSSecondaryServerDataGridViewTextBoxColumn.DataPropertyName = "WINSSecondaryServer"
Me.WINSSecondaryServerDataGridViewTextBoxColumn.HeaderText = "WINSSecondaryServer"
Me.WINSSecondaryServerDataGridViewTextBoxColumn.Name = "WINSSecondaryServerDataGridViewTextBoxColumn"
Me.WINSSecondaryServerDataGridViewTextBoxColumn.ReadOnly = true
'
'Win32NetworkAdapterConfigurationBindingSource
'
Me.Win32NetworkAdapterConfigurationBindingSource.DataSource = GetType(WMIwrapper.Win32_NetworkAdapterConfiguration)
'
'PanelNetworkAdapter
'
Me.PanelNetworkAdapter.Controls.Add(Me.dgvNetworkAdapter)
Me.PanelNetworkAdapter.Dock = System.Windows.Forms.DockStyle.Fill
Me.PanelNetworkAdapter.Location = New System.Drawing.Point(0, 0)
Me.PanelNetworkAdapter.Name = "PanelNetworkAdapter"
Me.PanelNetworkAdapter.Size = New System.Drawing.Size(468, 183)
Me.PanelNetworkAdapter.TabIndex = 10
'
'dgvNetworkAdapter
'
Me.dgvNetworkAdapter.AllowUserToAddRows = false
Me.dgvNetworkAdapter.AllowUserToDeleteRows = false
Me.dgvNetworkAdapter.AutoGenerateColumns = false
Me.dgvNetworkAdapter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
Me.dgvNetworkAdapter.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AdapterTypeDataGridViewTextBoxColumn, Me.AdapterTypeIDDataGridViewTextBoxColumn, Me.AutoSenseDataGridViewCheckBoxColumn, Me.AvailabilityDataGridViewTextBoxColumn5, Me.CaptionDataGridViewTextBoxColumn6, Me.ConfigManagerErrorDataGridViewTextBoxColumn5, Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn5, Me.CreationClassNameDataGridViewTextBoxColumn5, Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn5, Me.DescriptionDataGridViewTextBoxColumn6, Me.DeviceIDDataGridViewTextBoxColumn5, Me.ErrorClearedDataGridViewCheckBoxColumn5, Me.ErrorDescriptionDataGridViewTextBoxColumn5, Me.GUIDDataGridViewTextBoxColumn, Me.IndexDataGridViewTextBoxColumn1, Me.InstallDateDataGridViewTextBoxColumn6, Me.InstalledDataGridViewCheckBoxColumn, Me.InterfaceIndexDataGridViewTextBoxColumn, Me.LastErrorCodeDataGridViewTextBoxColumn5, Me.MACAddressDataGridViewTextBoxColumn, Me.ManufacturerDataGridViewTextBoxColumn2, Me.MaxNumberControlledDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn6, Me.NetConnectionIDDataGridViewTextBoxColumn, Me.NetConnectionStatusDataGridViewTextBoxColumn, Me.NetEnabledDataGridViewCheckBoxColumn, Me.PhysicalAdapterDataGridViewCheckBoxColumn, Me.PNPDeviceIDDataGridViewTextBoxColumn5, Me.PowerManagementSupportedDataGridViewCheckBoxColumn5, Me.ProductNameDataGridViewTextBoxColumn, Me.ServiceNameDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn6, Me.StatusInfoDataGridViewTextBoxColumn5, Me.SystemCreationClassNameDataGridViewTextBoxColumn5, Me.SystemNameDataGridViewTextBoxColumn5, Me.TimeOfLastResetDataGridViewTextBoxColumn})
Me.dgvNetworkAdapter.DataSource = Me.Win32NetworkAdapterBindingSource
Me.dgvNetworkAdapter.Dock = System.Windows.Forms.DockStyle.Fill
Me.dgvNetworkAdapter.Location = New System.Drawing.Point(0, 0)
Me.dgvNetworkAdapter.Name = "dgvNetworkAdapter"
Me.dgvNetworkAdapter.ReadOnly = true
Me.dgvNetworkAdapter.Size = New System.Drawing.Size(468, 183)
Me.dgvNetworkAdapter.TabIndex = 22
'
'AdapterTypeDataGridViewTextBoxColumn
'
Me.AdapterTypeDataGridViewTextBoxColumn.DataPropertyName = "AdapterType"
Me.AdapterTypeDataGridViewTextBoxColumn.HeaderText = "AdapterType"
Me.AdapterTypeDataGridViewTextBoxColumn.Name = "AdapterTypeDataGridViewTextBoxColumn"
Me.AdapterTypeDataGridViewTextBoxColumn.ReadOnly = true
'
'AdapterTypeIDDataGridViewTextBoxColumn
'
Me.AdapterTypeIDDataGridViewTextBoxColumn.DataPropertyName = "AdapterTypeID"
Me.AdapterTypeIDDataGridViewTextBoxColumn.HeaderText = "AdapterTypeID"
Me.AdapterTypeIDDataGridViewTextBoxColumn.Name = "AdapterTypeIDDataGridViewTextBoxColumn"
Me.AdapterTypeIDDataGridViewTextBoxColumn.ReadOnly = true
'
'AutoSenseDataGridViewCheckBoxColumn
'
Me.AutoSenseDataGridViewCheckBoxColumn.DataPropertyName = "AutoSense"
Me.AutoSenseDataGridViewCheckBoxColumn.HeaderText = "AutoSense"
Me.AutoSenseDataGridViewCheckBoxColumn.Name = "AutoSenseDataGridViewCheckBoxColumn"
Me.AutoSenseDataGridViewCheckBoxColumn.ReadOnly = true
'
'AvailabilityDataGridViewTextBoxColumn5
'
Me.AvailabilityDataGridViewTextBoxColumn5.DataPropertyName = "Availability"
Me.AvailabilityDataGridViewTextBoxColumn5.HeaderText = "Availability"
Me.AvailabilityDataGridViewTextBoxColumn5.Name = "AvailabilityDataGridViewTextBoxColumn5"
Me.AvailabilityDataGridViewTextBoxColumn5.ReadOnly = true
'
'CaptionDataGridViewTextBoxColumn6
'
Me.CaptionDataGridViewTextBoxColumn6.DataPropertyName = "Caption"
Me.CaptionDataGridViewTextBoxColumn6.HeaderText = "Caption"
Me.CaptionDataGridViewTextBoxColumn6.Name = "CaptionDataGridViewTextBoxColumn6"
Me.CaptionDataGridViewTextBoxColumn6.ReadOnly = true
'
'ConfigManagerErrorDataGridViewTextBoxColumn5
'
Me.ConfigManagerErrorDataGridViewTextBoxColumn5.DataPropertyName = "ConfigManagerError"
Me.ConfigManagerErrorDataGridViewTextBoxColumn5.HeaderText = "ConfigManagerError"
Me.ConfigManagerErrorDataGridViewTextBoxColumn5.Name = "ConfigManagerErrorDataGridViewTextBoxColumn5"
Me.ConfigManagerErrorDataGridViewTextBoxColumn5.ReadOnly = true
'
'ConfigManagerErrorCodeDataGridViewTextBoxColumn5
'
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn5.DataPropertyName = "ConfigManagerErrorCode"
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn5.HeaderText = "ConfigManagerErrorCode"
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn5.Name = "ConfigManagerErrorCodeDataGridViewTextBoxColumn5"
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn5.ReadOnly = true
'
'CreationClassNameDataGridViewTextBoxColumn5
'
Me.CreationClassNameDataGridViewTextBoxColumn5.DataPropertyName = "CreationClassName"
Me.CreationClassNameDataGridViewTextBoxColumn5.HeaderText = "CreationClassName"
Me.CreationClassNameDataGridViewTextBoxColumn5.Name = "CreationClassNameDataGridViewTextBoxColumn5"
Me.CreationClassNameDataGridViewTextBoxColumn5.ReadOnly = true
'
'ConfigManagerUserConfigDataGridViewCheckBoxColumn5
'
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn5.DataPropertyName = "ConfigManagerUserConfig"
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn5.HeaderText = "ConfigManagerUserConfig"
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn5.Name = "ConfigManagerUserConfigDataGridViewCheckBoxColumn5"
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn5.ReadOnly = true
'
'DescriptionDataGridViewTextBoxColumn6
'
Me.DescriptionDataGridViewTextBoxColumn6.DataPropertyName = "Description"
Me.DescriptionDataGridViewTextBoxColumn6.HeaderText = "Description"
Me.DescriptionDataGridViewTextBoxColumn6.Name = "DescriptionDataGridViewTextBoxColumn6"
Me.DescriptionDataGridViewTextBoxColumn6.ReadOnly = true
'
'DeviceIDDataGridViewTextBoxColumn5
'
Me.DeviceIDDataGridViewTextBoxColumn5.DataPropertyName = "DeviceID"
Me.DeviceIDDataGridViewTextBoxColumn5.HeaderText = "DeviceID"
Me.DeviceIDDataGridViewTextBoxColumn5.Name = "DeviceIDDataGridViewTextBoxColumn5"
Me.DeviceIDDataGridViewTextBoxColumn5.ReadOnly = true
'
'ErrorClearedDataGridViewCheckBoxColumn5
'
Me.ErrorClearedDataGridViewCheckBoxColumn5.DataPropertyName = "ErrorCleared"
Me.ErrorClearedDataGridViewCheckBoxColumn5.HeaderText = "ErrorCleared"
Me.ErrorClearedDataGridViewCheckBoxColumn5.Name = "ErrorClearedDataGridViewCheckBoxColumn5"
Me.ErrorClearedDataGridViewCheckBoxColumn5.ReadOnly = true
'
'ErrorDescriptionDataGridViewTextBoxColumn5
'
Me.ErrorDescriptionDataGridViewTextBoxColumn5.DataPropertyName = "ErrorDescription"
Me.ErrorDescriptionDataGridViewTextBoxColumn5.HeaderText = "ErrorDescription"
Me.ErrorDescriptionDataGridViewTextBoxColumn5.Name = "ErrorDescriptionDataGridViewTextBoxColumn5"
Me.ErrorDescriptionDataGridViewTextBoxColumn5.ReadOnly = true
'
'GUIDDataGridViewTextBoxColumn
'
Me.GUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID"
Me.GUIDDataGridViewTextBoxColumn.HeaderText = "GUID"
Me.GUIDDataGridViewTextBoxColumn.Name = "GUIDDataGridViewTextBoxColumn"
Me.GUIDDataGridViewTextBoxColumn.ReadOnly = true
'
'IndexDataGridViewTextBoxColumn1
'
Me.IndexDataGridViewTextBoxColumn1.DataPropertyName = "Index"
Me.IndexDataGridViewTextBoxColumn1.HeaderText = "Index"
Me.IndexDataGridViewTextBoxColumn1.Name = "IndexDataGridViewTextBoxColumn1"
Me.IndexDataGridViewTextBoxColumn1.ReadOnly = true
'
'InstallDateDataGridViewTextBoxColumn6
'
Me.InstallDateDataGridViewTextBoxColumn6.DataPropertyName = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn6.HeaderText = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn6.Name = "InstallDateDataGridViewTextBoxColumn6"
Me.InstallDateDataGridViewTextBoxColumn6.ReadOnly = true
'
'InstalledDataGridViewCheckBoxColumn
'
Me.InstalledDataGridViewCheckBoxColumn.DataPropertyName = "Installed"
Me.InstalledDataGridViewCheckBoxColumn.HeaderText = "Installed"
Me.InstalledDataGridViewCheckBoxColumn.Name = "InstalledDataGridViewCheckBoxColumn"
Me.InstalledDataGridViewCheckBoxColumn.ReadOnly = true
'
'InterfaceIndexDataGridViewTextBoxColumn
'
Me.InterfaceIndexDataGridViewTextBoxColumn.DataPropertyName = "InterfaceIndex"
Me.InterfaceIndexDataGridViewTextBoxColumn.HeaderText = "InterfaceIndex"
Me.InterfaceIndexDataGridViewTextBoxColumn.Name = "InterfaceIndexDataGridViewTextBoxColumn"
Me.InterfaceIndexDataGridViewTextBoxColumn.ReadOnly = true
'
'LastErrorCodeDataGridViewTextBoxColumn5
'
Me.LastErrorCodeDataGridViewTextBoxColumn5.DataPropertyName = "LastErrorCode"
Me.LastErrorCodeDataGridViewTextBoxColumn5.HeaderText = "LastErrorCode"
Me.LastErrorCodeDataGridViewTextBoxColumn5.Name = "LastErrorCodeDataGridViewTextBoxColumn5"
Me.LastErrorCodeDataGridViewTextBoxColumn5.ReadOnly = true
'
'MACAddressDataGridViewTextBoxColumn
'
Me.MACAddressDataGridViewTextBoxColumn.DataPropertyName = "MACAddress"
Me.MACAddressDataGridViewTextBoxColumn.HeaderText = "MACAddress"
Me.MACAddressDataGridViewTextBoxColumn.Name = "MACAddressDataGridViewTextBoxColumn"
Me.MACAddressDataGridViewTextBoxColumn.ReadOnly = true
'
'ManufacturerDataGridViewTextBoxColumn2
'
Me.ManufacturerDataGridViewTextBoxColumn2.DataPropertyName = "Manufacturer"
Me.ManufacturerDataGridViewTextBoxColumn2.HeaderText = "Manufacturer"
Me.ManufacturerDataGridViewTextBoxColumn2.Name = "ManufacturerDataGridViewTextBoxColumn2"
Me.ManufacturerDataGridViewTextBoxColumn2.ReadOnly = true
'
'MaxNumberControlledDataGridViewTextBoxColumn
'
Me.MaxNumberControlledDataGridViewTextBoxColumn.DataPropertyName = "MaxNumberControlled"
Me.MaxNumberControlledDataGridViewTextBoxColumn.HeaderText = "MaxNumberControlled"
Me.MaxNumberControlledDataGridViewTextBoxColumn.Name = "MaxNumberControlledDataGridViewTextBoxColumn"
Me.MaxNumberControlledDataGridViewTextBoxColumn.ReadOnly = true
'
'NameDataGridViewTextBoxColumn6
'
Me.NameDataGridViewTextBoxColumn6.DataPropertyName = "Name"
Me.NameDataGridViewTextBoxColumn6.HeaderText = "Name"
Me.NameDataGridViewTextBoxColumn6.Name = "NameDataGridViewTextBoxColumn6"
Me.NameDataGridViewTextBoxColumn6.ReadOnly = true
'
'NetConnectionIDDataGridViewTextBoxColumn
'
Me.NetConnectionIDDataGridViewTextBoxColumn.DataPropertyName = "NetConnectionID"
Me.NetConnectionIDDataGridViewTextBoxColumn.HeaderText = "NetConnectionID"
Me.NetConnectionIDDataGridViewTextBoxColumn.Name = "NetConnectionIDDataGridViewTextBoxColumn"
Me.NetConnectionIDDataGridViewTextBoxColumn.ReadOnly = true
'
'NetConnectionStatusDataGridViewTextBoxColumn
'
Me.NetConnectionStatusDataGridViewTextBoxColumn.DataPropertyName = "NetConnectionStatus"
Me.NetConnectionStatusDataGridViewTextBoxColumn.HeaderText = "NetConnectionStatus"
Me.NetConnectionStatusDataGridViewTextBoxColumn.Name = "NetConnectionStatusDataGridViewTextBoxColumn"
Me.NetConnectionStatusDataGridViewTextBoxColumn.ReadOnly = true
'
'NetEnabledDataGridViewCheckBoxColumn
'
Me.NetEnabledDataGridViewCheckBoxColumn.DataPropertyName = "NetEnabled"
Me.NetEnabledDataGridViewCheckBoxColumn.HeaderText = "NetEnabled"
Me.NetEnabledDataGridViewCheckBoxColumn.Name = "NetEnabledDataGridViewCheckBoxColumn"
Me.NetEnabledDataGridViewCheckBoxColumn.ReadOnly = true
'
'PhysicalAdapterDataGridViewCheckBoxColumn
'
Me.PhysicalAdapterDataGridViewCheckBoxColumn.DataPropertyName = "PhysicalAdapter"
Me.PhysicalAdapterDataGridViewCheckBoxColumn.HeaderText = "PhysicalAdapter"
Me.PhysicalAdapterDataGridViewCheckBoxColumn.Name = "PhysicalAdapterDataGridViewCheckBoxColumn"
Me.PhysicalAdapterDataGridViewCheckBoxColumn.ReadOnly = true
'
'PNPDeviceIDDataGridViewTextBoxColumn5
'
Me.PNPDeviceIDDataGridViewTextBoxColumn5.DataPropertyName = "PNPDeviceID"
Me.PNPDeviceIDDataGridViewTextBoxColumn5.HeaderText = "PNPDeviceID"
Me.PNPDeviceIDDataGridViewTextBoxColumn5.Name = "PNPDeviceIDDataGridViewTextBoxColumn5"
Me.PNPDeviceIDDataGridViewTextBoxColumn5.ReadOnly = true
'
'PowerManagementSupportedDataGridViewCheckBoxColumn5
'
Me.PowerManagementSupportedDataGridViewCheckBoxColumn5.DataPropertyName = "PowerManagementSupported"
Me.PowerManagementSupportedDataGridViewCheckBoxColumn5.HeaderText = "PowerManagementSupported"
Me.PowerManagementSupportedDataGridViewCheckBoxColumn5.Name = "PowerManagementSupportedDataGridViewCheckBoxColumn5"
Me.PowerManagementSupportedDataGridViewCheckBoxColumn5.ReadOnly = true
'
'ProductNameDataGridViewTextBoxColumn
'
Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName"
Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "ProductName"
Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
Me.ProductNameDataGridViewTextBoxColumn.ReadOnly = true
'
'ServiceNameDataGridViewTextBoxColumn
'
Me.ServiceNameDataGridViewTextBoxColumn.DataPropertyName = "ServiceName"
Me.ServiceNameDataGridViewTextBoxColumn.HeaderText = "ServiceName"
Me.ServiceNameDataGridViewTextBoxColumn.Name = "ServiceNameDataGridViewTextBoxColumn"
Me.ServiceNameDataGridViewTextBoxColumn.ReadOnly = true
'
'StatusDataGridViewTextBoxColumn6
'
Me.StatusDataGridViewTextBoxColumn6.DataPropertyName = "Status"
Me.StatusDataGridViewTextBoxColumn6.HeaderText = "Status"
Me.StatusDataGridViewTextBoxColumn6.Name = "StatusDataGridViewTextBoxColumn6"
Me.StatusDataGridViewTextBoxColumn6.ReadOnly = true
'
'StatusInfoDataGridViewTextBoxColumn5
'
Me.StatusInfoDataGridViewTextBoxColumn5.DataPropertyName = "StatusInfo"
Me.StatusInfoDataGridViewTextBoxColumn5.HeaderText = "StatusInfo"
Me.StatusInfoDataGridViewTextBoxColumn5.Name = "StatusInfoDataGridViewTextBoxColumn5"
Me.StatusInfoDataGridViewTextBoxColumn5.ReadOnly = true
'
'SystemCreationClassNameDataGridViewTextBoxColumn5
'
Me.SystemCreationClassNameDataGridViewTextBoxColumn5.DataPropertyName = "SystemCreationClassName"
Me.SystemCreationClassNameDataGridViewTextBoxColumn5.HeaderText = "SystemCreationClassName"
Me.SystemCreationClassNameDataGridViewTextBoxColumn5.Name = "SystemCreationClassNameDataGridViewTextBoxColumn5"
Me.SystemCreationClassNameDataGridViewTextBoxColumn5.ReadOnly = true
'
'SystemNameDataGridViewTextBoxColumn5
'
Me.SystemNameDataGridViewTextBoxColumn5.DataPropertyName = "SystemName"
Me.SystemNameDataGridViewTextBoxColumn5.HeaderText = "SystemName"
Me.SystemNameDataGridViewTextBoxColumn5.Name = "SystemNameDataGridViewTextBoxColumn5"
Me.SystemNameDataGridViewTextBoxColumn5.ReadOnly = true
'
'TimeOfLastResetDataGridViewTextBoxColumn
'
Me.TimeOfLastResetDataGridViewTextBoxColumn.DataPropertyName = "TimeOfLastReset"
Me.TimeOfLastResetDataGridViewTextBoxColumn.HeaderText = "TimeOfLastReset"
Me.TimeOfLastResetDataGridViewTextBoxColumn.Name = "TimeOfLastResetDataGridViewTextBoxColumn"
Me.TimeOfLastResetDataGridViewTextBoxColumn.ReadOnly = true
'
'Win32NetworkAdapterBindingSource
'
Me.Win32NetworkAdapterBindingSource.DataSource = GetType(WMIwrapper.Win32_NetworkAdapter)
'
'PanelPhysicalMedia
'
Me.PanelPhysicalMedia.Controls.Add(Me.dgvPhysicalMedia)
Me.PanelPhysicalMedia.Dock = System.Windows.Forms.DockStyle.Fill
Me.PanelPhysicalMedia.Location = New System.Drawing.Point(0, 0)
Me.PanelPhysicalMedia.Name = "PanelPhysicalMedia"
Me.PanelPhysicalMedia.Size = New System.Drawing.Size(468, 183)
Me.PanelPhysicalMedia.TabIndex = 9
'
'dgvPhysicalMedia
'
Me.dgvPhysicalMedia.AllowUserToAddRows = false
Me.dgvPhysicalMedia.AllowUserToDeleteRows = false
Me.dgvPhysicalMedia.AutoGenerateColumns = false
Me.dgvPhysicalMedia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
Me.dgvPhysicalMedia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CapacityDataGridViewTextBoxColumn, Me.CaptionDataGridViewTextBoxColumn5, Me.CleanerMediaDataGridViewCheckBoxColumn, Me.DescriptionDataGridViewTextBoxColumn5, Me.HotSwappableDataGridViewCheckBoxColumn, Me.InstallDateDataGridViewTextBoxColumn5, Me.MediaDescriptionDataGridViewTextBoxColumn, Me.MediaTypeDataGridViewTextBoxColumn2, Me.NameDataGridViewTextBoxColumn5, Me.RemovableDataGridViewCheckBoxColumn, Me.ReplaceableDataGridViewCheckBoxColumn, Me.StatusDataGridViewTextBoxColumn5, Me.WriteProtectOnDataGridViewCheckBoxColumn})
Me.dgvPhysicalMedia.DataSource = Me.Win32PhysicalMediaBindingSource
Me.dgvPhysicalMedia.Dock = System.Windows.Forms.DockStyle.Fill
Me.dgvPhysicalMedia.Location = New System.Drawing.Point(0, 0)
Me.dgvPhysicalMedia.Name = "dgvPhysicalMedia"
Me.dgvPhysicalMedia.ReadOnly = true
Me.dgvPhysicalMedia.Size = New System.Drawing.Size(468, 183)
Me.dgvPhysicalMedia.TabIndex = 22
'
'CapacityDataGridViewTextBoxColumn
'
Me.CapacityDataGridViewTextBoxColumn.DataPropertyName = "Capacity"
Me.CapacityDataGridViewTextBoxColumn.HeaderText = "Capacity"
Me.CapacityDataGridViewTextBoxColumn.Name = "CapacityDataGridViewTextBoxColumn"
Me.CapacityDataGridViewTextBoxColumn.ReadOnly = true
'
'CaptionDataGridViewTextBoxColumn5
'
Me.CaptionDataGridViewTextBoxColumn5.DataPropertyName = "Caption"
Me.CaptionDataGridViewTextBoxColumn5.HeaderText = "Caption"
Me.CaptionDataGridViewTextBoxColumn5.Name = "CaptionDataGridViewTextBoxColumn5"
Me.CaptionDataGridViewTextBoxColumn5.ReadOnly = true
'
'CleanerMediaDataGridViewCheckBoxColumn
'
Me.CleanerMediaDataGridViewCheckBoxColumn.DataPropertyName = "CleanerMedia"
Me.CleanerMediaDataGridViewCheckBoxColumn.HeaderText = "CleanerMedia"
Me.CleanerMediaDataGridViewCheckBoxColumn.Name = "CleanerMediaDataGridViewCheckBoxColumn"
Me.CleanerMediaDataGridViewCheckBoxColumn.ReadOnly = true
'
'DescriptionDataGridViewTextBoxColumn5
'
Me.DescriptionDataGridViewTextBoxColumn5.DataPropertyName = "Description"
Me.DescriptionDataGridViewTextBoxColumn5.HeaderText = "Description"
Me.DescriptionDataGridViewTextBoxColumn5.Name = "DescriptionDataGridViewTextBoxColumn5"
Me.DescriptionDataGridViewTextBoxColumn5.ReadOnly = true
'
'HotSwappableDataGridViewCheckBoxColumn
'
Me.HotSwappableDataGridViewCheckBoxColumn.DataPropertyName = "HotSwappable"
Me.HotSwappableDataGridViewCheckBoxColumn.HeaderText = "HotSwappable"
Me.HotSwappableDataGridViewCheckBoxColumn.Name = "HotSwappableDataGridViewCheckBoxColumn"
Me.HotSwappableDataGridViewCheckBoxColumn.ReadOnly = true
'
'InstallDateDataGridViewTextBoxColumn5
'
Me.InstallDateDataGridViewTextBoxColumn5.DataPropertyName = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn5.HeaderText = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn5.Name = "InstallDateDataGridViewTextBoxColumn5"
Me.InstallDateDataGridViewTextBoxColumn5.ReadOnly = true
'
'MediaDescriptionDataGridViewTextBoxColumn
'
Me.MediaDescriptionDataGridViewTextBoxColumn.DataPropertyName = "MediaDescription"
Me.MediaDescriptionDataGridViewTextBoxColumn.HeaderText = "MediaDescription"
Me.MediaDescriptionDataGridViewTextBoxColumn.Name = "MediaDescriptionDataGridViewTextBoxColumn"
Me.MediaDescriptionDataGridViewTextBoxColumn.ReadOnly = true
'
'MediaTypeDataGridViewTextBoxColumn2
'
Me.MediaTypeDataGridViewTextBoxColumn2.DataPropertyName = "MediaType"
Me.MediaTypeDataGridViewTextBoxColumn2.HeaderText = "MediaType"
Me.MediaTypeDataGridViewTextBoxColumn2.Name = "MediaTypeDataGridViewTextBoxColumn2"
Me.MediaTypeDataGridViewTextBoxColumn2.ReadOnly = true
'
'NameDataGridViewTextBoxColumn5
'
Me.NameDataGridViewTextBoxColumn5.DataPropertyName = "Name"
Me.NameDataGridViewTextBoxColumn5.HeaderText = "Name"
Me.NameDataGridViewTextBoxColumn5.Name = "NameDataGridViewTextBoxColumn5"
Me.NameDataGridViewTextBoxColumn5.ReadOnly = true
'
'RemovableDataGridViewCheckBoxColumn
'
Me.RemovableDataGridViewCheckBoxColumn.DataPropertyName = "Removable"
Me.RemovableDataGridViewCheckBoxColumn.HeaderText = "Removable"
Me.RemovableDataGridViewCheckBoxColumn.Name = "RemovableDataGridViewCheckBoxColumn"
Me.RemovableDataGridViewCheckBoxColumn.ReadOnly = true
'
'ReplaceableDataGridViewCheckBoxColumn
'
Me.ReplaceableDataGridViewCheckBoxColumn.DataPropertyName = "Replaceable"
Me.ReplaceableDataGridViewCheckBoxColumn.HeaderText = "Replaceable"
Me.ReplaceableDataGridViewCheckBoxColumn.Name = "ReplaceableDataGridViewCheckBoxColumn"
Me.ReplaceableDataGridViewCheckBoxColumn.ReadOnly = true
'
'StatusDataGridViewTextBoxColumn5
'
Me.StatusDataGridViewTextBoxColumn5.DataPropertyName = "Status"
Me.StatusDataGridViewTextBoxColumn5.HeaderText = "Status"
Me.StatusDataGridViewTextBoxColumn5.Name = "StatusDataGridViewTextBoxColumn5"
Me.StatusDataGridViewTextBoxColumn5.ReadOnly = true
'
'WriteProtectOnDataGridViewCheckBoxColumn
'
Me.WriteProtectOnDataGridViewCheckBoxColumn.DataPropertyName = "WriteProtectOn"
Me.WriteProtectOnDataGridViewCheckBoxColumn.HeaderText = "WriteProtectOn"
Me.WriteProtectOnDataGridViewCheckBoxColumn.Name = "WriteProtectOnDataGridViewCheckBoxColumn"
Me.WriteProtectOnDataGridViewCheckBoxColumn.ReadOnly = true
'
'Win32PhysicalMediaBindingSource
'
Me.Win32PhysicalMediaBindingSource.DataSource = GetType(WMIwrapper.Win32_PhysicalMedia)
'
'PanelLogicalDisks
'
Me.PanelLogicalDisks.Controls.Add(Me.dgvLogicalDisks)
Me.PanelLogicalDisks.Dock = System.Windows.Forms.DockStyle.Fill
Me.PanelLogicalDisks.Location = New System.Drawing.Point(0, 0)
Me.PanelLogicalDisks.Name = "PanelLogicalDisks"
Me.PanelLogicalDisks.Size = New System.Drawing.Size(468, 183)
Me.PanelLogicalDisks.TabIndex = 8
'
'dgvLogicalDisks
'
Me.dgvLogicalDisks.AllowUserToAddRows = false
Me.dgvLogicalDisks.AllowUserToDeleteRows = false
Me.dgvLogicalDisks.AutoGenerateColumns = false
Me.dgvLogicalDisks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
Me.dgvLogicalDisks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn37, Me.DataGridViewCheckBoxColumn6, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn46, Me.DataGridViewTextBoxColumn47, Me.DataGridViewCheckBoxColumn9, Me.DataGridViewTextBoxColumn48, Me.DataGridViewTextBoxColumn49, Me.DataGridViewTextBoxColumn50, Me.DataGridViewTextBoxColumn51, Me.DataGridViewTextBoxColumn61, Me.DataGridViewTextBoxColumn63, Me.DataGridViewCheckBoxColumn11, Me.DataGridViewTextBoxColumn64, Me.DataGridViewTextBoxColumn65, Me.DataGridViewTextBoxColumn66, Me.DataGridViewTextBoxColumn67})
Me.dgvLogicalDisks.DataSource = Me.Win32LogicalDiskBindingSource
Me.dgvLogicalDisks.Dock = System.Windows.Forms.DockStyle.Fill
Me.dgvLogicalDisks.Location = New System.Drawing.Point(0, 0)
Me.dgvLogicalDisks.Name = "dgvLogicalDisks"
Me.dgvLogicalDisks.ReadOnly = true
Me.dgvLogicalDisks.Size = New System.Drawing.Size(468, 183)
Me.dgvLogicalDisks.TabIndex = 22
'
'DataGridViewTextBoxColumn3
'
Me.DataGridViewTextBoxColumn3.DataPropertyName = "Availability"
Me.DataGridViewTextBoxColumn3.HeaderText = "Availability"
Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
Me.DataGridViewTextBoxColumn3.ReadOnly = true
'
'DataGridViewTextBoxColumn20
'
Me.DataGridViewTextBoxColumn20.DataPropertyName = "Caption"
Me.DataGridViewTextBoxColumn20.HeaderText = "Caption"
Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
Me.DataGridViewTextBoxColumn20.ReadOnly = true
'
'DataGridViewTextBoxColumn23
'
Me.DataGridViewTextBoxColumn23.DataPropertyName = "ConfigManagerError"
Me.DataGridViewTextBoxColumn23.HeaderText = "ConfigManagerError"
Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
Me.DataGridViewTextBoxColumn23.ReadOnly = true
'
'DataGridViewTextBoxColumn37
'
Me.DataGridViewTextBoxColumn37.DataPropertyName = "ConfigManagerErrorCode"
Me.DataGridViewTextBoxColumn37.HeaderText = "ConfigManagerErrorCode"
Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
Me.DataGridViewTextBoxColumn37.ReadOnly = true
'
'DataGridViewCheckBoxColumn6
'
Me.DataGridViewCheckBoxColumn6.DataPropertyName = "ConfigManagerUserConfig"
Me.DataGridViewCheckBoxColumn6.HeaderText = "ConfigManagerUserConfig"
Me.DataGridViewCheckBoxColumn6.Name = "DataGridViewCheckBoxColumn6"
Me.DataGridViewCheckBoxColumn6.ReadOnly = true
'
'DataGridViewTextBoxColumn39
'
Me.DataGridViewTextBoxColumn39.DataPropertyName = "CreationClassName"
Me.DataGridViewTextBoxColumn39.HeaderText = "CreationClassName"
Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
Me.DataGridViewTextBoxColumn39.ReadOnly = true
'
'DataGridViewTextBoxColumn46
'
Me.DataGridViewTextBoxColumn46.DataPropertyName = "Description"
Me.DataGridViewTextBoxColumn46.HeaderText = "Description"
Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
Me.DataGridViewTextBoxColumn46.ReadOnly = true
'
'DataGridViewTextBoxColumn47
'
Me.DataGridViewTextBoxColumn47.DataPropertyName = "DeviceID"
Me.DataGridViewTextBoxColumn47.HeaderText = "DeviceID"
Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
Me.DataGridViewTextBoxColumn47.ReadOnly = true
'
'DataGridViewCheckBoxColumn9
'
Me.DataGridViewCheckBoxColumn9.DataPropertyName = "ErrorCleared"
Me.DataGridViewCheckBoxColumn9.HeaderText = "ErrorCleared"
Me.DataGridViewCheckBoxColumn9.Name = "DataGridViewCheckBoxColumn9"
Me.DataGridViewCheckBoxColumn9.ReadOnly = true
'
'DataGridViewTextBoxColumn48
'
Me.DataGridViewTextBoxColumn48.DataPropertyName = "ErrorDescription"
Me.DataGridViewTextBoxColumn48.HeaderText = "ErrorDescription"
Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
Me.DataGridViewTextBoxColumn48.ReadOnly = true
'
'DataGridViewTextBoxColumn49
'
Me.DataGridViewTextBoxColumn49.DataPropertyName = "ErrorMethodology"
Me.DataGridViewTextBoxColumn49.HeaderText = "ErrorMethodology"
Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
Me.DataGridViewTextBoxColumn49.ReadOnly = true
'
'DataGridViewTextBoxColumn50
'
Me.DataGridViewTextBoxColumn50.DataPropertyName = "InstallDate"
Me.DataGridViewTextBoxColumn50.HeaderText = "InstallDate"
Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
Me.DataGridViewTextBoxColumn50.ReadOnly = true
'
'DataGridViewTextBoxColumn51
'
Me.DataGridViewTextBoxColumn51.DataPropertyName = "LastErrorCode"
Me.DataGridViewTextBoxColumn51.HeaderText = "LastErrorCode"
Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
Me.DataGridViewTextBoxColumn51.ReadOnly = true
'
'DataGridViewTextBoxColumn61
'
Me.DataGridViewTextBoxColumn61.DataPropertyName = "Name"
Me.DataGridViewTextBoxColumn61.HeaderText = "Name"
Me.DataGridViewTextBoxColumn61.Name = "DataGridViewTextBoxColumn61"
Me.DataGridViewTextBoxColumn61.ReadOnly = true
'
'DataGridViewTextBoxColumn63
'
Me.DataGridViewTextBoxColumn63.DataPropertyName = "PNPDeviceID"
Me.DataGridViewTextBoxColumn63.HeaderText = "PNPDeviceID"
Me.DataGridViewTextBoxColumn63.Name = "DataGridViewTextBoxColumn63"
Me.DataGridViewTextBoxColumn63.ReadOnly = true
'
'DataGridViewCheckBoxColumn11
'
Me.DataGridViewCheckBoxColumn11.DataPropertyName = "PowerManagementSupported"
Me.DataGridViewCheckBoxColumn11.HeaderText = "PowerManagementSupported"
Me.DataGridViewCheckBoxColumn11.Name = "DataGridViewCheckBoxColumn11"
Me.DataGridViewCheckBoxColumn11.ReadOnly = true
'
'DataGridViewTextBoxColumn64
'
Me.DataGridViewTextBoxColumn64.DataPropertyName = "StatusInfo"
Me.DataGridViewTextBoxColumn64.HeaderText = "StatusInfo"
Me.DataGridViewTextBoxColumn64.Name = "DataGridViewTextBoxColumn64"
Me.DataGridViewTextBoxColumn64.ReadOnly = true
'
'DataGridViewTextBoxColumn65
'
Me.DataGridViewTextBoxColumn65.DataPropertyName = "SystemCreationClassName"
Me.DataGridViewTextBoxColumn65.HeaderText = "SystemCreationClassName"
Me.DataGridViewTextBoxColumn65.Name = "DataGridViewTextBoxColumn65"
Me.DataGridViewTextBoxColumn65.ReadOnly = true
'
'DataGridViewTextBoxColumn66
'
Me.DataGridViewTextBoxColumn66.DataPropertyName = "Status"
Me.DataGridViewTextBoxColumn66.HeaderText = "Status"
Me.DataGridViewTextBoxColumn66.Name = "DataGridViewTextBoxColumn66"
Me.DataGridViewTextBoxColumn66.ReadOnly = true
'
'DataGridViewTextBoxColumn67
'
Me.DataGridViewTextBoxColumn67.DataPropertyName = "SystemName"
Me.DataGridViewTextBoxColumn67.HeaderText = "SystemName"
Me.DataGridViewTextBoxColumn67.Name = "DataGridViewTextBoxColumn67"
Me.DataGridViewTextBoxColumn67.ReadOnly = true
'
'Win32LogicalDiskBindingSource
'
Me.Win32LogicalDiskBindingSource.DataSource = GetType(WMIwrapper.Win32_LogicalDisk)
'
'PanelFloppyDrives
'
Me.PanelFloppyDrives.Controls.Add(Me.dgvFloppyDrives)
Me.PanelFloppyDrives.Dock = System.Windows.Forms.DockStyle.Fill
Me.PanelFloppyDrives.Location = New System.Drawing.Point(0, 0)
Me.PanelFloppyDrives.Name = "PanelFloppyDrives"
Me.PanelFloppyDrives.Size = New System.Drawing.Size(468, 183)
Me.PanelFloppyDrives.TabIndex = 7
'
'dgvFloppyDrives
'
Me.dgvFloppyDrives.AllowUserToAddRows = false
Me.dgvFloppyDrives.AllowUserToDeleteRows = false
Me.dgvFloppyDrives.AutoGenerateColumns = false
Me.dgvFloppyDrives.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
Me.dgvFloppyDrives.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn11, Me.DataGridViewCheckBoxColumn4, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewCheckBoxColumn5, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn41, Me.DataGridViewCheckBoxColumn7, Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn45, Me.DataGridViewCheckBoxColumn8, Me.DataGridViewTextBoxColumn53, Me.DataGridViewTextBoxColumn54, Me.DataGridViewTextBoxColumn56, Me.DataGridViewTextBoxColumn57})
Me.dgvFloppyDrives.DataSource = Me.Win32FloppyDriveBindingSource
Me.dgvFloppyDrives.Dock = System.Windows.Forms.DockStyle.Fill
Me.dgvFloppyDrives.Location = New System.Drawing.Point(0, 0)
Me.dgvFloppyDrives.Name = "dgvFloppyDrives"
Me.dgvFloppyDrives.ReadOnly = true
Me.dgvFloppyDrives.Size = New System.Drawing.Size(468, 183)
Me.dgvFloppyDrives.TabIndex = 22
'
'DataGridViewTextBoxColumn2
'
Me.DataGridViewTextBoxColumn2.DataPropertyName = "Availability"
Me.DataGridViewTextBoxColumn2.HeaderText = "Availability"
Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
Me.DataGridViewTextBoxColumn2.ReadOnly = true
'
'DataGridViewTextBoxColumn4
'
Me.DataGridViewTextBoxColumn4.DataPropertyName = "Caption"
Me.DataGridViewTextBoxColumn4.HeaderText = "Caption"
Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
Me.DataGridViewTextBoxColumn4.ReadOnly = true
'
'DataGridViewTextBoxColumn6
'
Me.DataGridViewTextBoxColumn6.DataPropertyName = "CompressionMethod"
Me.DataGridViewTextBoxColumn6.HeaderText = "CompressionMethod"
Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
Me.DataGridViewTextBoxColumn6.ReadOnly = true
'
'DataGridViewTextBoxColumn7
'
Me.DataGridViewTextBoxColumn7.DataPropertyName = "ConfigManagerError"
Me.DataGridViewTextBoxColumn7.HeaderText = "ConfigManagerError"
Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
Me.DataGridViewTextBoxColumn7.ReadOnly = true
'
'DataGridViewTextBoxColumn11
'
Me.DataGridViewTextBoxColumn11.DataPropertyName = "ConfigManagerErrorCode"
Me.DataGridViewTextBoxColumn11.HeaderText = "ConfigManagerErrorCode"
Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
Me.DataGridViewTextBoxColumn11.ReadOnly = true
'
'DataGridViewCheckBoxColumn4
'
Me.DataGridViewCheckBoxColumn4.DataPropertyName = "ConfigManagerUserConfig"
Me.DataGridViewCheckBoxColumn4.HeaderText = "ConfigManagerUserConfig"
Me.DataGridViewCheckBoxColumn4.Name = "DataGridViewCheckBoxColumn4"
Me.DataGridViewCheckBoxColumn4.ReadOnly = true
'
'DataGridViewTextBoxColumn13
'
Me.DataGridViewTextBoxColumn13.DataPropertyName = "CreationClassName"
Me.DataGridViewTextBoxColumn13.HeaderText = "CreationClassName"
Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
Me.DataGridViewTextBoxColumn13.ReadOnly = true
'
'DataGridViewTextBoxColumn14
'
Me.DataGridViewTextBoxColumn14.DataPropertyName = "DefaultBlockSize"
Me.DataGridViewTextBoxColumn14.HeaderText = "DefaultBlockSize"
Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
Me.DataGridViewTextBoxColumn14.ReadOnly = true
'
'DataGridViewTextBoxColumn16
'
Me.DataGridViewTextBoxColumn16.DataPropertyName = "Description"
Me.DataGridViewTextBoxColumn16.HeaderText = "Description"
Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
Me.DataGridViewTextBoxColumn16.ReadOnly = true
'
'DataGridViewTextBoxColumn17
'
Me.DataGridViewTextBoxColumn17.DataPropertyName = "DeviceID"
Me.DataGridViewTextBoxColumn17.HeaderText = "DeviceID"
Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
Me.DataGridViewTextBoxColumn17.ReadOnly = true
'
'DataGridViewCheckBoxColumn5
'
Me.DataGridViewCheckBoxColumn5.DataPropertyName = "ErrorCleared"
Me.DataGridViewCheckBoxColumn5.HeaderText = "ErrorCleared"
Me.DataGridViewCheckBoxColumn5.Name = "DataGridViewCheckBoxColumn5"
Me.DataGridViewCheckBoxColumn5.ReadOnly = true
'
'DataGridViewTextBoxColumn18
'
Me.DataGridViewTextBoxColumn18.DataPropertyName = "ErrorDescription"
Me.DataGridViewTextBoxColumn18.HeaderText = "ErrorDescription"
Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
Me.DataGridViewTextBoxColumn18.ReadOnly = true
'
'DataGridViewTextBoxColumn19
'
Me.DataGridViewTextBoxColumn19.DataPropertyName = "ErrorMethodology"
Me.DataGridViewTextBoxColumn19.HeaderText = "ErrorMethodology"
Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
Me.DataGridViewTextBoxColumn19.ReadOnly = true
'
'DataGridViewTextBoxColumn26
'
Me.DataGridViewTextBoxColumn26.DataPropertyName = "InstallDate"
Me.DataGridViewTextBoxColumn26.HeaderText = "InstallDate"
Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
Me.DataGridViewTextBoxColumn26.ReadOnly = true
'
'DataGridViewTextBoxColumn28
'
Me.DataGridViewTextBoxColumn28.DataPropertyName = "LastErrorCode"
Me.DataGridViewTextBoxColumn28.HeaderText = "LastErrorCode"
Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
Me.DataGridViewTextBoxColumn28.ReadOnly = true
'
'DataGridViewTextBoxColumn31
'
Me.DataGridViewTextBoxColumn31.DataPropertyName = "Manufacturer"
Me.DataGridViewTextBoxColumn31.HeaderText = "Manufacturer"
Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
Me.DataGridViewTextBoxColumn31.ReadOnly = true
'
'DataGridViewTextBoxColumn33
'
Me.DataGridViewTextBoxColumn33.DataPropertyName = "MaxBlockSize"
Me.DataGridViewTextBoxColumn33.HeaderText = "MaxBlockSize"
Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
Me.DataGridViewTextBoxColumn33.ReadOnly = true
'
'DataGridViewTextBoxColumn35
'
Me.DataGridViewTextBoxColumn35.DataPropertyName = "MaxMediaSize"
Me.DataGridViewTextBoxColumn35.HeaderText = "MaxMediaSize"
Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
Me.DataGridViewTextBoxColumn35.ReadOnly = true
'
'DataGridViewTextBoxColumn40
'
Me.DataGridViewTextBoxColumn40.DataPropertyName = "MinBlockSize"
Me.DataGridViewTextBoxColumn40.HeaderText = "MinBlockSize"
Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
Me.DataGridViewTextBoxColumn40.ReadOnly = true
'
'DataGridViewTextBoxColumn41
'
Me.DataGridViewTextBoxColumn41.DataPropertyName = "Name"
Me.DataGridViewTextBoxColumn41.HeaderText = "Name"
Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
Me.DataGridViewTextBoxColumn41.ReadOnly = true
'
'DataGridViewCheckBoxColumn7
'
Me.DataGridViewCheckBoxColumn7.DataPropertyName = "NeedsCleaning"
Me.DataGridViewCheckBoxColumn7.HeaderText = "NeedsCleaning"
Me.DataGridViewCheckBoxColumn7.Name = "DataGridViewCheckBoxColumn7"
Me.DataGridViewCheckBoxColumn7.ReadOnly = true
'
'DataGridViewTextBoxColumn42
'
Me.DataGridViewTextBoxColumn42.DataPropertyName = "NumberOfMediaSupported"
Me.DataGridViewTextBoxColumn42.HeaderText = "NumberOfMediaSupported"
Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
Me.DataGridViewTextBoxColumn42.ReadOnly = true
'
'DataGridViewTextBoxColumn45
'
Me.DataGridViewTextBoxColumn45.DataPropertyName = "PNPDeviceID"
Me.DataGridViewTextBoxColumn45.HeaderText = "PNPDeviceID"
Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
Me.DataGridViewTextBoxColumn45.ReadOnly = true
'
'DataGridViewCheckBoxColumn8
'
Me.DataGridViewCheckBoxColumn8.DataPropertyName = "PowerManagementSupported"
Me.DataGridViewCheckBoxColumn8.HeaderText = "PowerManagementSupported"
Me.DataGridViewCheckBoxColumn8.Name = "DataGridViewCheckBoxColumn8"
Me.DataGridViewCheckBoxColumn8.ReadOnly = true
'
'DataGridViewTextBoxColumn53
'
Me.DataGridViewTextBoxColumn53.DataPropertyName = "StatusInfo"
Me.DataGridViewTextBoxColumn53.HeaderText = "StatusInfo"
Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
Me.DataGridViewTextBoxColumn53.ReadOnly = true
'
'DataGridViewTextBoxColumn54
'
Me.DataGridViewTextBoxColumn54.DataPropertyName = "SystemCreationClassName"
Me.DataGridViewTextBoxColumn54.HeaderText = "SystemCreationClassName"
Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
Me.DataGridViewTextBoxColumn54.ReadOnly = true
'
'DataGridViewTextBoxColumn56
'
Me.DataGridViewTextBoxColumn56.DataPropertyName = "Status"
Me.DataGridViewTextBoxColumn56.HeaderText = "Status"
Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
Me.DataGridViewTextBoxColumn56.ReadOnly = true
'
'DataGridViewTextBoxColumn57
'
Me.DataGridViewTextBoxColumn57.DataPropertyName = "SystemName"
Me.DataGridViewTextBoxColumn57.HeaderText = "SystemName"
Me.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
Me.DataGridViewTextBoxColumn57.ReadOnly = true
'
'Win32FloppyDriveBindingSource
'
Me.Win32FloppyDriveBindingSource.DataSource = GetType(WMIwrapper.Win32_FloppyDrive)
'
'PanelDiskDrives
'
Me.PanelDiskDrives.Controls.Add(Me.dgvDiskDrives)
Me.PanelDiskDrives.Dock = System.Windows.Forms.DockStyle.Fill
Me.PanelDiskDrives.Location = New System.Drawing.Point(0, 0)
Me.PanelDiskDrives.Name = "PanelDiskDrives"
Me.PanelDiskDrives.Size = New System.Drawing.Size(468, 183)
Me.PanelDiskDrives.TabIndex = 6
'
'dgvDiskDrives
'
Me.dgvDiskDrives.AllowUserToAddRows = false
Me.dgvDiskDrives.AllowUserToDeleteRows = false
Me.dgvDiskDrives.AutoGenerateColumns = false
Me.dgvDiskDrives.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
Me.dgvDiskDrives.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AvailabilityDataGridViewTextBoxColumn4, Me.BytesPerSectorDataGridViewTextBoxColumn, Me.CaptionDataGridViewTextBoxColumn4, Me.CompressionMethodDataGridViewTextBoxColumn1, Me.ConfigManagerErrorDataGridViewTextBoxColumn4, Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn4, Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn4, Me.CreationClassNameDataGridViewTextBoxColumn4, Me.DefaultBlockSizeDataGridViewTextBoxColumn1, Me.DescriptionDataGridViewTextBoxColumn4, Me.DeviceIDDataGridViewTextBoxColumn4, Me.ErrorClearedDataGridViewCheckBoxColumn4, Me.ErrorDescriptionDataGridViewTextBoxColumn4, Me.ErrorMethodologyDataGridViewTextBoxColumn1, Me.FirmwareRevisionDataGridViewTextBoxColumn, Me.IndexDataGridViewTextBoxColumn, Me.InterfaceTypeDataGridViewTextBoxColumn, Me.InstallDateDataGridViewTextBoxColumn4, Me.LastErrorCodeDataGridViewTextBoxColumn4, Me.ManufacturerDataGridViewTextBoxColumn1, Me.MaxBlockSizeDataGridViewTextBoxColumn1, Me.MaxMediaSizeDataGridViewTextBoxColumn1, Me.MediaLoadedDataGridViewCheckBoxColumn1, Me.ModelDataGridViewTextBoxColumn, Me.MediaTypeDataGridViewTextBoxColumn1, Me.MinBlockSizeDataGridViewTextBoxColumn1, Me.NameDataGridViewTextBoxColumn4, Me.NeedsCleaningDataGridViewCheckBoxColumn1, Me.NumberOfMediaSupportedDataGridViewTextBoxColumn1, Me.PartitionsDataGridViewTextBoxColumn, Me.PNPDeviceIDDataGridViewTextBoxColumn4, Me.PowerManagementSupportedDataGridViewCheckBoxColumn4, Me.SCSIBusDataGridViewTextBoxColumn1, Me.SCSILogicalUnitDataGridViewTextBoxColumn1, Me.SCSIPortDataGridViewTextBoxColumn1, Me.SCSITargetIdDataGridViewTextBoxColumn1, Me.SectorsPerTrackDataGridViewTextBoxColumn, Me.SerialNumberDataGridViewTextBoxColumn1, Me.SizeDataGridViewTextBoxColumn1, Me.StatusInfoDataGridViewTextBoxColumn4, Me.SystemCreationClassNameDataGridViewTextBoxColumn4, Me.SignatureDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn4, Me.SystemNameDataGridViewTextBoxColumn4, Me.TotalHeadsDataGridViewTextBoxColumn, Me.TotalCylindersDataGridViewTextBoxColumn, Me.TotalSectorsDataGridViewTextBoxColumn, Me.TotalTracksDataGridViewTextBoxColumn, Me.TracksPerCylinderDataGridViewTextBoxColumn})
Me.dgvDiskDrives.DataSource = Me.Win32DiskDriveBindingSource
Me.dgvDiskDrives.Dock = System.Windows.Forms.DockStyle.Fill
Me.dgvDiskDrives.Location = New System.Drawing.Point(0, 0)
Me.dgvDiskDrives.Name = "dgvDiskDrives"
Me.dgvDiskDrives.ReadOnly = true
Me.dgvDiskDrives.Size = New System.Drawing.Size(468, 183)
Me.dgvDiskDrives.TabIndex = 22
'
'AvailabilityDataGridViewTextBoxColumn4
'
Me.AvailabilityDataGridViewTextBoxColumn4.DataPropertyName = "Availability"
Me.AvailabilityDataGridViewTextBoxColumn4.HeaderText = "Availability"
Me.AvailabilityDataGridViewTextBoxColumn4.Name = "AvailabilityDataGridViewTextBoxColumn4"
Me.AvailabilityDataGridViewTextBoxColumn4.ReadOnly = true
'
'BytesPerSectorDataGridViewTextBoxColumn
'
Me.BytesPerSectorDataGridViewTextBoxColumn.DataPropertyName = "BytesPerSector"
Me.BytesPerSectorDataGridViewTextBoxColumn.HeaderText = "BytesPerSector"
Me.BytesPerSectorDataGridViewTextBoxColumn.Name = "BytesPerSectorDataGridViewTextBoxColumn"
Me.BytesPerSectorDataGridViewTextBoxColumn.ReadOnly = true
'
'CaptionDataGridViewTextBoxColumn4
'
Me.CaptionDataGridViewTextBoxColumn4.DataPropertyName = "Caption"
Me.CaptionDataGridViewTextBoxColumn4.HeaderText = "Caption"
Me.CaptionDataGridViewTextBoxColumn4.Name = "CaptionDataGridViewTextBoxColumn4"
Me.CaptionDataGridViewTextBoxColumn4.ReadOnly = true
'
'CompressionMethodDataGridViewTextBoxColumn1
'
Me.CompressionMethodDataGridViewTextBoxColumn1.DataPropertyName = "CompressionMethod"
Me.CompressionMethodDataGridViewTextBoxColumn1.HeaderText = "CompressionMethod"
Me.CompressionMethodDataGridViewTextBoxColumn1.Name = "CompressionMethodDataGridViewTextBoxColumn1"
Me.CompressionMethodDataGridViewTextBoxColumn1.ReadOnly = true
'
'ConfigManagerErrorDataGridViewTextBoxColumn4
'
Me.ConfigManagerErrorDataGridViewTextBoxColumn4.DataPropertyName = "ConfigManagerError"
Me.ConfigManagerErrorDataGridViewTextBoxColumn4.HeaderText = "ConfigManagerError"
Me.ConfigManagerErrorDataGridViewTextBoxColumn4.Name = "ConfigManagerErrorDataGridViewTextBoxColumn4"
Me.ConfigManagerErrorDataGridViewTextBoxColumn4.ReadOnly = true
'
'ConfigManagerErrorCodeDataGridViewTextBoxColumn4
'
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn4.DataPropertyName = "ConfigManagerErrorCode"
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn4.HeaderText = "ConfigManagerErrorCode"
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn4.Name = "ConfigManagerErrorCodeDataGridViewTextBoxColumn4"
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn4.ReadOnly = true
'
'ConfigManagerUserConfigDataGridViewCheckBoxColumn4
'
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn4.DataPropertyName = "ConfigManagerUserConfig"
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn4.HeaderText = "ConfigManagerUserConfig"
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn4.Name = "ConfigManagerUserConfigDataGridViewCheckBoxColumn4"
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn4.ReadOnly = true
'
'CreationClassNameDataGridViewTextBoxColumn4
'
Me.CreationClassNameDataGridViewTextBoxColumn4.DataPropertyName = "CreationClassName"
Me.CreationClassNameDataGridViewTextBoxColumn4.HeaderText = "CreationClassName"
Me.CreationClassNameDataGridViewTextBoxColumn4.Name = "CreationClassNameDataGridViewTextBoxColumn4"
Me.CreationClassNameDataGridViewTextBoxColumn4.ReadOnly = true
'
'DefaultBlockSizeDataGridViewTextBoxColumn1
'
Me.DefaultBlockSizeDataGridViewTextBoxColumn1.DataPropertyName = "DefaultBlockSize"
Me.DefaultBlockSizeDataGridViewTextBoxColumn1.HeaderText = "DefaultBlockSize"
Me.DefaultBlockSizeDataGridViewTextBoxColumn1.Name = "DefaultBlockSizeDataGridViewTextBoxColumn1"
Me.DefaultBlockSizeDataGridViewTextBoxColumn1.ReadOnly = true
'
'DescriptionDataGridViewTextBoxColumn4
'
Me.DescriptionDataGridViewTextBoxColumn4.DataPropertyName = "Description"
Me.DescriptionDataGridViewTextBoxColumn4.HeaderText = "Description"
Me.DescriptionDataGridViewTextBoxColumn4.Name = "DescriptionDataGridViewTextBoxColumn4"
Me.DescriptionDataGridViewTextBoxColumn4.ReadOnly = true
'
'DeviceIDDataGridViewTextBoxColumn4
'
Me.DeviceIDDataGridViewTextBoxColumn4.DataPropertyName = "DeviceID"
Me.DeviceIDDataGridViewTextBoxColumn4.HeaderText = "DeviceID"
Me.DeviceIDDataGridViewTextBoxColumn4.Name = "DeviceIDDataGridViewTextBoxColumn4"
Me.DeviceIDDataGridViewTextBoxColumn4.ReadOnly = true
'
'ErrorClearedDataGridViewCheckBoxColumn4
'
Me.ErrorClearedDataGridViewCheckBoxColumn4.DataPropertyName = "ErrorCleared"
Me.ErrorClearedDataGridViewCheckBoxColumn4.HeaderText = "ErrorCleared"
Me.ErrorClearedDataGridViewCheckBoxColumn4.Name = "ErrorClearedDataGridViewCheckBoxColumn4"
Me.ErrorClearedDataGridViewCheckBoxColumn4.ReadOnly = true
'
'ErrorDescriptionDataGridViewTextBoxColumn4
'
Me.ErrorDescriptionDataGridViewTextBoxColumn4.DataPropertyName = "ErrorDescription"
Me.ErrorDescriptionDataGridViewTextBoxColumn4.HeaderText = "ErrorDescription"
Me.ErrorDescriptionDataGridViewTextBoxColumn4.Name = "ErrorDescriptionDataGridViewTextBoxColumn4"
Me.ErrorDescriptionDataGridViewTextBoxColumn4.ReadOnly = true
'
'ErrorMethodologyDataGridViewTextBoxColumn1
'
Me.ErrorMethodologyDataGridViewTextBoxColumn1.DataPropertyName = "ErrorMethodology"
Me.ErrorMethodologyDataGridViewTextBoxColumn1.HeaderText = "ErrorMethodology"
Me.ErrorMethodologyDataGridViewTextBoxColumn1.Name = "ErrorMethodologyDataGridViewTextBoxColumn1"
Me.ErrorMethodologyDataGridViewTextBoxColumn1.ReadOnly = true
'
'FirmwareRevisionDataGridViewTextBoxColumn
'
Me.FirmwareRevisionDataGridViewTextBoxColumn.DataPropertyName = "FirmwareRevision"
Me.FirmwareRevisionDataGridViewTextBoxColumn.HeaderText = "FirmwareRevision"
Me.FirmwareRevisionDataGridViewTextBoxColumn.Name = "FirmwareRevisionDataGridViewTextBoxColumn"
Me.FirmwareRevisionDataGridViewTextBoxColumn.ReadOnly = true
'
'IndexDataGridViewTextBoxColumn
'
Me.IndexDataGridViewTextBoxColumn.DataPropertyName = "Index"
Me.IndexDataGridViewTextBoxColumn.HeaderText = "Index"
Me.IndexDataGridViewTextBoxColumn.Name = "IndexDataGridViewTextBoxColumn"
Me.IndexDataGridViewTextBoxColumn.ReadOnly = true
'
'InterfaceTypeDataGridViewTextBoxColumn
'
Me.InterfaceTypeDataGridViewTextBoxColumn.DataPropertyName = "InterfaceType"
Me.InterfaceTypeDataGridViewTextBoxColumn.HeaderText = "InterfaceType"
Me.InterfaceTypeDataGridViewTextBoxColumn.Name = "InterfaceTypeDataGridViewTextBoxColumn"
Me.InterfaceTypeDataGridViewTextBoxColumn.ReadOnly = true
'
'InstallDateDataGridViewTextBoxColumn4
'
Me.InstallDateDataGridViewTextBoxColumn4.DataPropertyName = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn4.HeaderText = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn4.Name = "InstallDateDataGridViewTextBoxColumn4"
Me.InstallDateDataGridViewTextBoxColumn4.ReadOnly = true
'
'LastErrorCodeDataGridViewTextBoxColumn4
'
Me.LastErrorCodeDataGridViewTextBoxColumn4.DataPropertyName = "LastErrorCode"
Me.LastErrorCodeDataGridViewTextBoxColumn4.HeaderText = "LastErrorCode"
Me.LastErrorCodeDataGridViewTextBoxColumn4.Name = "LastErrorCodeDataGridViewTextBoxColumn4"
Me.LastErrorCodeDataGridViewTextBoxColumn4.ReadOnly = true
'
'ManufacturerDataGridViewTextBoxColumn1
'
Me.ManufacturerDataGridViewTextBoxColumn1.DataPropertyName = "Manufacturer"
Me.ManufacturerDataGridViewTextBoxColumn1.HeaderText = "Manufacturer"
Me.ManufacturerDataGridViewTextBoxColumn1.Name = "ManufacturerDataGridViewTextBoxColumn1"
Me.ManufacturerDataGridViewTextBoxColumn1.ReadOnly = true
'
'MaxBlockSizeDataGridViewTextBoxColumn1
'
Me.MaxBlockSizeDataGridViewTextBoxColumn1.DataPropertyName = "MaxBlockSize"
Me.MaxBlockSizeDataGridViewTextBoxColumn1.HeaderText = "MaxBlockSize"
Me.MaxBlockSizeDataGridViewTextBoxColumn1.Name = "MaxBlockSizeDataGridViewTextBoxColumn1"
Me.MaxBlockSizeDataGridViewTextBoxColumn1.ReadOnly = true
'
'MaxMediaSizeDataGridViewTextBoxColumn1
'
Me.MaxMediaSizeDataGridViewTextBoxColumn1.DataPropertyName = "MaxMediaSize"
Me.MaxMediaSizeDataGridViewTextBoxColumn1.HeaderText = "MaxMediaSize"
Me.MaxMediaSizeDataGridViewTextBoxColumn1.Name = "MaxMediaSizeDataGridViewTextBoxColumn1"
Me.MaxMediaSizeDataGridViewTextBoxColumn1.ReadOnly = true
'
'MediaLoadedDataGridViewCheckBoxColumn1
'
Me.MediaLoadedDataGridViewCheckBoxColumn1.DataPropertyName = "MediaLoaded"
Me.MediaLoadedDataGridViewCheckBoxColumn1.HeaderText = "MediaLoaded"
Me.MediaLoadedDataGridViewCheckBoxColumn1.Name = "MediaLoadedDataGridViewCheckBoxColumn1"
Me.MediaLoadedDataGridViewCheckBoxColumn1.ReadOnly = true
'
'ModelDataGridViewTextBoxColumn
'
Me.ModelDataGridViewTextBoxColumn.DataPropertyName = "Model"
Me.ModelDataGridViewTextBoxColumn.HeaderText = "Model"
Me.ModelDataGridViewTextBoxColumn.Name = "ModelDataGridViewTextBoxColumn"
Me.ModelDataGridViewTextBoxColumn.ReadOnly = true
'
'MediaTypeDataGridViewTextBoxColumn1
'
Me.MediaTypeDataGridViewTextBoxColumn1.DataPropertyName = "MediaType"
Me.MediaTypeDataGridViewTextBoxColumn1.HeaderText = "MediaType"
Me.MediaTypeDataGridViewTextBoxColumn1.Name = "MediaTypeDataGridViewTextBoxColumn1"
Me.MediaTypeDataGridViewTextBoxColumn1.ReadOnly = true
'
'MinBlockSizeDataGridViewTextBoxColumn1
'
Me.MinBlockSizeDataGridViewTextBoxColumn1.DataPropertyName = "MinBlockSize"
Me.MinBlockSizeDataGridViewTextBoxColumn1.HeaderText = "MinBlockSize"
Me.MinBlockSizeDataGridViewTextBoxColumn1.Name = "MinBlockSizeDataGridViewTextBoxColumn1"
Me.MinBlockSizeDataGridViewTextBoxColumn1.ReadOnly = true
'
'NameDataGridViewTextBoxColumn4
'
Me.NameDataGridViewTextBoxColumn4.DataPropertyName = "Name"
Me.NameDataGridViewTextBoxColumn4.HeaderText = "Name"
Me.NameDataGridViewTextBoxColumn4.Name = "NameDataGridViewTextBoxColumn4"
Me.NameDataGridViewTextBoxColumn4.ReadOnly = true
'
'NeedsCleaningDataGridViewCheckBoxColumn1
'
Me.NeedsCleaningDataGridViewCheckBoxColumn1.DataPropertyName = "NeedsCleaning"
Me.NeedsCleaningDataGridViewCheckBoxColumn1.HeaderText = "NeedsCleaning"
Me.NeedsCleaningDataGridViewCheckBoxColumn1.Name = "NeedsCleaningDataGridViewCheckBoxColumn1"
Me.NeedsCleaningDataGridViewCheckBoxColumn1.ReadOnly = true
'
'NumberOfMediaSupportedDataGridViewTextBoxColumn1
'
Me.NumberOfMediaSupportedDataGridViewTextBoxColumn1.DataPropertyName = "NumberOfMediaSupported"
Me.NumberOfMediaSupportedDataGridViewTextBoxColumn1.HeaderText = "NumberOfMediaSupported"
Me.NumberOfMediaSupportedDataGridViewTextBoxColumn1.Name = "NumberOfMediaSupportedDataGridViewTextBoxColumn1"
Me.NumberOfMediaSupportedDataGridViewTextBoxColumn1.ReadOnly = true
'
'PartitionsDataGridViewTextBoxColumn
'
Me.PartitionsDataGridViewTextBoxColumn.DataPropertyName = "Partitions"
Me.PartitionsDataGridViewTextBoxColumn.HeaderText = "Partitions"
Me.PartitionsDataGridViewTextBoxColumn.Name = "PartitionsDataGridViewTextBoxColumn"
Me.PartitionsDataGridViewTextBoxColumn.ReadOnly = true
'
'PNPDeviceIDDataGridViewTextBoxColumn4
'
Me.PNPDeviceIDDataGridViewTextBoxColumn4.DataPropertyName = "PNPDeviceID"
Me.PNPDeviceIDDataGridViewTextBoxColumn4.HeaderText = "PNPDeviceID"
Me.PNPDeviceIDDataGridViewTextBoxColumn4.Name = "PNPDeviceIDDataGridViewTextBoxColumn4"
Me.PNPDeviceIDDataGridViewTextBoxColumn4.ReadOnly = true
'
'PowerManagementSupportedDataGridViewCheckBoxColumn4
'
Me.PowerManagementSupportedDataGridViewCheckBoxColumn4.DataPropertyName = "PowerManagementSupported"
Me.PowerManagementSupportedDataGridViewCheckBoxColumn4.HeaderText = "PowerManagementSupported"
Me.PowerManagementSupportedDataGridViewCheckBoxColumn4.Name = "PowerManagementSupportedDataGridViewCheckBoxColumn4"
Me.PowerManagementSupportedDataGridViewCheckBoxColumn4.ReadOnly = true
'
'SCSIBusDataGridViewTextBoxColumn1
'
Me.SCSIBusDataGridViewTextBoxColumn1.DataPropertyName = "SCSIBus"
Me.SCSIBusDataGridViewTextBoxColumn1.HeaderText = "SCSIBus"
Me.SCSIBusDataGridViewTextBoxColumn1.Name = "SCSIBusDataGridViewTextBoxColumn1"
Me.SCSIBusDataGridViewTextBoxColumn1.ReadOnly = true
'
'SCSILogicalUnitDataGridViewTextBoxColumn1
'
Me.SCSILogicalUnitDataGridViewTextBoxColumn1.DataPropertyName = "SCSILogicalUnit"
Me.SCSILogicalUnitDataGridViewTextBoxColumn1.HeaderText = "SCSILogicalUnit"
Me.SCSILogicalUnitDataGridViewTextBoxColumn1.Name = "SCSILogicalUnitDataGridViewTextBoxColumn1"
Me.SCSILogicalUnitDataGridViewTextBoxColumn1.ReadOnly = true
'
'SCSIPortDataGridViewTextBoxColumn1
'
Me.SCSIPortDataGridViewTextBoxColumn1.DataPropertyName = "SCSIPort"
Me.SCSIPortDataGridViewTextBoxColumn1.HeaderText = "SCSIPort"
Me.SCSIPortDataGridViewTextBoxColumn1.Name = "SCSIPortDataGridViewTextBoxColumn1"
Me.SCSIPortDataGridViewTextBoxColumn1.ReadOnly = true
'
'SCSITargetIdDataGridViewTextBoxColumn1
'
Me.SCSITargetIdDataGridViewTextBoxColumn1.DataPropertyName = "SCSITargetId"
Me.SCSITargetIdDataGridViewTextBoxColumn1.HeaderText = "SCSITargetId"
Me.SCSITargetIdDataGridViewTextBoxColumn1.Name = "SCSITargetIdDataGridViewTextBoxColumn1"
Me.SCSITargetIdDataGridViewTextBoxColumn1.ReadOnly = true
'
'SectorsPerTrackDataGridViewTextBoxColumn
'
Me.SectorsPerTrackDataGridViewTextBoxColumn.DataPropertyName = "SectorsPerTrack"
Me.SectorsPerTrackDataGridViewTextBoxColumn.HeaderText = "SectorsPerTrack"
Me.SectorsPerTrackDataGridViewTextBoxColumn.Name = "SectorsPerTrackDataGridViewTextBoxColumn"
Me.SectorsPerTrackDataGridViewTextBoxColumn.ReadOnly = true
'
'SerialNumberDataGridViewTextBoxColumn1
'
Me.SerialNumberDataGridViewTextBoxColumn1.DataPropertyName = "SerialNumber"
Me.SerialNumberDataGridViewTextBoxColumn1.HeaderText = "SerialNumber"
Me.SerialNumberDataGridViewTextBoxColumn1.Name = "SerialNumberDataGridViewTextBoxColumn1"
Me.SerialNumberDataGridViewTextBoxColumn1.ReadOnly = true
'
'SizeDataGridViewTextBoxColumn1
'
Me.SizeDataGridViewTextBoxColumn1.DataPropertyName = "Size"
Me.SizeDataGridViewTextBoxColumn1.HeaderText = "Size"
Me.SizeDataGridViewTextBoxColumn1.Name = "SizeDataGridViewTextBoxColumn1"
Me.SizeDataGridViewTextBoxColumn1.ReadOnly = true
'
'StatusInfoDataGridViewTextBoxColumn4
'
Me.StatusInfoDataGridViewTextBoxColumn4.DataPropertyName = "StatusInfo"
Me.StatusInfoDataGridViewTextBoxColumn4.HeaderText = "StatusInfo"
Me.StatusInfoDataGridViewTextBoxColumn4.Name = "StatusInfoDataGridViewTextBoxColumn4"
Me.StatusInfoDataGridViewTextBoxColumn4.ReadOnly = true
'
'SystemCreationClassNameDataGridViewTextBoxColumn4
'
Me.SystemCreationClassNameDataGridViewTextBoxColumn4.DataPropertyName = "SystemCreationClassName"
Me.SystemCreationClassNameDataGridViewTextBoxColumn4.HeaderText = "SystemCreationClassName"
Me.SystemCreationClassNameDataGridViewTextBoxColumn4.Name = "SystemCreationClassNameDataGridViewTextBoxColumn4"
Me.SystemCreationClassNameDataGridViewTextBoxColumn4.ReadOnly = true
'
'SignatureDataGridViewTextBoxColumn
'
Me.SignatureDataGridViewTextBoxColumn.DataPropertyName = "Signature"
Me.SignatureDataGridViewTextBoxColumn.HeaderText = "Signature"
Me.SignatureDataGridViewTextBoxColumn.Name = "SignatureDataGridViewTextBoxColumn"
Me.SignatureDataGridViewTextBoxColumn.ReadOnly = true
'
'StatusDataGridViewTextBoxColumn4
'
Me.StatusDataGridViewTextBoxColumn4.DataPropertyName = "Status"
Me.StatusDataGridViewTextBoxColumn4.HeaderText = "Status"
Me.StatusDataGridViewTextBoxColumn4.Name = "StatusDataGridViewTextBoxColumn4"
Me.StatusDataGridViewTextBoxColumn4.ReadOnly = true
'
'SystemNameDataGridViewTextBoxColumn4
'
Me.SystemNameDataGridViewTextBoxColumn4.DataPropertyName = "SystemName"
Me.SystemNameDataGridViewTextBoxColumn4.HeaderText = "SystemName"
Me.SystemNameDataGridViewTextBoxColumn4.Name = "SystemNameDataGridViewTextBoxColumn4"
Me.SystemNameDataGridViewTextBoxColumn4.ReadOnly = true
'
'TotalHeadsDataGridViewTextBoxColumn
'
Me.TotalHeadsDataGridViewTextBoxColumn.DataPropertyName = "TotalHeads"
Me.TotalHeadsDataGridViewTextBoxColumn.HeaderText = "TotalHeads"
Me.TotalHeadsDataGridViewTextBoxColumn.Name = "TotalHeadsDataGridViewTextBoxColumn"
Me.TotalHeadsDataGridViewTextBoxColumn.ReadOnly = true
'
'TotalCylindersDataGridViewTextBoxColumn
'
Me.TotalCylindersDataGridViewTextBoxColumn.DataPropertyName = "TotalCylinders"
Me.TotalCylindersDataGridViewTextBoxColumn.HeaderText = "TotalCylinders"
Me.TotalCylindersDataGridViewTextBoxColumn.Name = "TotalCylindersDataGridViewTextBoxColumn"
Me.TotalCylindersDataGridViewTextBoxColumn.ReadOnly = true
'
'TotalSectorsDataGridViewTextBoxColumn
'
Me.TotalSectorsDataGridViewTextBoxColumn.DataPropertyName = "TotalSectors"
Me.TotalSectorsDataGridViewTextBoxColumn.HeaderText = "TotalSectors"
Me.TotalSectorsDataGridViewTextBoxColumn.Name = "TotalSectorsDataGridViewTextBoxColumn"
Me.TotalSectorsDataGridViewTextBoxColumn.ReadOnly = true
'
'TotalTracksDataGridViewTextBoxColumn
'
Me.TotalTracksDataGridViewTextBoxColumn.DataPropertyName = "TotalTracks"
Me.TotalTracksDataGridViewTextBoxColumn.HeaderText = "TotalTracks"
Me.TotalTracksDataGridViewTextBoxColumn.Name = "TotalTracksDataGridViewTextBoxColumn"
Me.TotalTracksDataGridViewTextBoxColumn.ReadOnly = true
'
'TracksPerCylinderDataGridViewTextBoxColumn
'
Me.TracksPerCylinderDataGridViewTextBoxColumn.DataPropertyName = "TracksPerCylinder"
Me.TracksPerCylinderDataGridViewTextBoxColumn.HeaderText = "TracksPerCylinder"
Me.TracksPerCylinderDataGridViewTextBoxColumn.Name = "TracksPerCylinderDataGridViewTextBoxColumn"
Me.TracksPerCylinderDataGridViewTextBoxColumn.ReadOnly = true
'
'Win32DiskDriveBindingSource
'
Me.Win32DiskDriveBindingSource.DataSource = GetType(WMIwrapper.Win32_DiskDrive)
'
'PanelCDROMdrives
'
Me.PanelCDROMdrives.Controls.Add(Me.dgvCDROMdrives)
Me.PanelCDROMdrives.Dock = System.Windows.Forms.DockStyle.Fill
Me.PanelCDROMdrives.Location = New System.Drawing.Point(0, 0)
Me.PanelCDROMdrives.Name = "PanelCDROMdrives"
Me.PanelCDROMdrives.Size = New System.Drawing.Size(468, 183)
Me.PanelCDROMdrives.TabIndex = 5
'
'dgvCDROMdrives
'
Me.dgvCDROMdrives.AllowUserToAddRows = false
Me.dgvCDROMdrives.AllowUserToDeleteRows = false
Me.dgvCDROMdrives.AutoGenerateColumns = false
Me.dgvCDROMdrives.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
Me.dgvCDROMdrives.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AvailabilityDataGridViewTextBoxColumn3, Me.CaptionDataGridViewTextBoxColumn3, Me.CompressionMethodDataGridViewTextBoxColumn, Me.ConfigManagerErrorDataGridViewTextBoxColumn3, Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn3, Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn3, Me.CreationClassNameDataGridViewTextBoxColumn3, Me.DefaultBlockSizeDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn3, Me.DeviceIDDataGridViewTextBoxColumn3, Me.DriveDataGridViewTextBoxColumn, Me.DriveIntegrityDataGridViewCheckBoxColumn, Me.ErrorClearedDataGridViewCheckBoxColumn3, Me.ErrorDescriptionDataGridViewTextBoxColumn3, Me.ErrorMethodologyDataGridViewTextBoxColumn, Me.FileSystemFlagsExDataGridViewTextBoxColumn, Me.IdDataGridViewTextBoxColumn, Me.InstallDateDataGridViewTextBoxColumn3, Me.LastErrorCodeDataGridViewTextBoxColumn3, Me.MaxBlockSizeDataGridViewTextBoxColumn, Me.MaximumComponentLengthDataGridViewTextBoxColumn, Me.MaxMediaSizeDataGridViewTextBoxColumn, Me.MediaLoadedDataGridViewCheckBoxColumn, Me.MediaTypeDataGridViewTextBoxColumn, Me.MfrAssignedRevisionLevelDataGridViewTextBoxColumn, Me.MinBlockSizeDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn3, Me.NeedsCleaningDataGridViewCheckBoxColumn, Me.NumberOfMediaSupportedDataGridViewTextBoxColumn, Me.PNPDeviceIDDataGridViewTextBoxColumn3, Me.PowerManagementSupportedDataGridViewCheckBoxColumn3, Me.RevisionLevelDataGridViewTextBoxColumn, Me.SCSIBusDataGridViewTextBoxColumn, Me.SCSILogicalUnitDataGridViewTextBoxColumn, Me.SCSIPortDataGridViewTextBoxColumn, Me.SCSITargetIdDataGridViewTextBoxColumn, Me.SerialNumberDataGridViewTextBoxColumn, Me.SizeDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn3, Me.StatusInfoDataGridViewTextBoxColumn3, Me.SystemCreationClassNameDataGridViewTextBoxColumn3, Me.SystemNameDataGridViewTextBoxColumn3, Me.TransferRateDataGridViewTextBoxColumn, Me.VolumeNameDataGridViewTextBoxColumn, Me.VolumeSerialNumberDataGridViewTextBoxColumn})
Me.dgvCDROMdrives.DataSource = Me.Win32CDROMDriveBindingSource
Me.dgvCDROMdrives.Dock = System.Windows.Forms.DockStyle.Fill
Me.dgvCDROMdrives.Location = New System.Drawing.Point(0, 0)
Me.dgvCDROMdrives.Name = "dgvCDROMdrives"
Me.dgvCDROMdrives.ReadOnly = true
Me.dgvCDROMdrives.Size = New System.Drawing.Size(468, 183)
Me.dgvCDROMdrives.TabIndex = 22
'
'AvailabilityDataGridViewTextBoxColumn3
'
Me.AvailabilityDataGridViewTextBoxColumn3.DataPropertyName = "Availability"
Me.AvailabilityDataGridViewTextBoxColumn3.HeaderText = "Availability"
Me.AvailabilityDataGridViewTextBoxColumn3.Name = "AvailabilityDataGridViewTextBoxColumn3"
Me.AvailabilityDataGridViewTextBoxColumn3.ReadOnly = true
'
'CaptionDataGridViewTextBoxColumn3
'
Me.CaptionDataGridViewTextBoxColumn3.DataPropertyName = "Caption"
Me.CaptionDataGridViewTextBoxColumn3.HeaderText = "Caption"
Me.CaptionDataGridViewTextBoxColumn3.Name = "CaptionDataGridViewTextBoxColumn3"
Me.CaptionDataGridViewTextBoxColumn3.ReadOnly = true
'
'CompressionMethodDataGridViewTextBoxColumn
'
Me.CompressionMethodDataGridViewTextBoxColumn.DataPropertyName = "CompressionMethod"
Me.CompressionMethodDataGridViewTextBoxColumn.HeaderText = "CompressionMethod"
Me.CompressionMethodDataGridViewTextBoxColumn.Name = "CompressionMethodDataGridViewTextBoxColumn"
Me.CompressionMethodDataGridViewTextBoxColumn.ReadOnly = true
'
'ConfigManagerErrorDataGridViewTextBoxColumn3
'
Me.ConfigManagerErrorDataGridViewTextBoxColumn3.DataPropertyName = "ConfigManagerError"
Me.ConfigManagerErrorDataGridViewTextBoxColumn3.HeaderText = "ConfigManagerError"
Me.ConfigManagerErrorDataGridViewTextBoxColumn3.Name = "ConfigManagerErrorDataGridViewTextBoxColumn3"
Me.ConfigManagerErrorDataGridViewTextBoxColumn3.ReadOnly = true
'
'ConfigManagerErrorCodeDataGridViewTextBoxColumn3
'
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn3.DataPropertyName = "ConfigManagerErrorCode"
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn3.HeaderText = "ConfigManagerErrorCode"
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn3.Name = "ConfigManagerErrorCodeDataGridViewTextBoxColumn3"
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn3.ReadOnly = true
'
'ConfigManagerUserConfigDataGridViewCheckBoxColumn3
'
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn3.DataPropertyName = "ConfigManagerUserConfig"
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn3.HeaderText = "ConfigManagerUserConfig"
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn3.Name = "ConfigManagerUserConfigDataGridViewCheckBoxColumn3"
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn3.ReadOnly = true
'
'CreationClassNameDataGridViewTextBoxColumn3
'
Me.CreationClassNameDataGridViewTextBoxColumn3.DataPropertyName = "CreationClassName"
Me.CreationClassNameDataGridViewTextBoxColumn3.HeaderText = "CreationClassName"
Me.CreationClassNameDataGridViewTextBoxColumn3.Name = "CreationClassNameDataGridViewTextBoxColumn3"
Me.CreationClassNameDataGridViewTextBoxColumn3.ReadOnly = true
'
'DefaultBlockSizeDataGridViewTextBoxColumn
'
Me.DefaultBlockSizeDataGridViewTextBoxColumn.DataPropertyName = "DefaultBlockSize"
Me.DefaultBlockSizeDataGridViewTextBoxColumn.HeaderText = "DefaultBlockSize"
Me.DefaultBlockSizeDataGridViewTextBoxColumn.Name = "DefaultBlockSizeDataGridViewTextBoxColumn"
Me.DefaultBlockSizeDataGridViewTextBoxColumn.ReadOnly = true
'
'DescriptionDataGridViewTextBoxColumn3
'
Me.DescriptionDataGridViewTextBoxColumn3.DataPropertyName = "Description"
Me.DescriptionDataGridViewTextBoxColumn3.HeaderText = "Description"
Me.DescriptionDataGridViewTextBoxColumn3.Name = "DescriptionDataGridViewTextBoxColumn3"
Me.DescriptionDataGridViewTextBoxColumn3.ReadOnly = true
'
'DeviceIDDataGridViewTextBoxColumn3
'
Me.DeviceIDDataGridViewTextBoxColumn3.DataPropertyName = "DeviceID"
Me.DeviceIDDataGridViewTextBoxColumn3.HeaderText = "DeviceID"
Me.DeviceIDDataGridViewTextBoxColumn3.Name = "DeviceIDDataGridViewTextBoxColumn3"
Me.DeviceIDDataGridViewTextBoxColumn3.ReadOnly = true
'
'DriveDataGridViewTextBoxColumn
'
Me.DriveDataGridViewTextBoxColumn.DataPropertyName = "Drive"
Me.DriveDataGridViewTextBoxColumn.HeaderText = "Drive"
Me.DriveDataGridViewTextBoxColumn.Name = "DriveDataGridViewTextBoxColumn"
Me.DriveDataGridViewTextBoxColumn.ReadOnly = true
'
'DriveIntegrityDataGridViewCheckBoxColumn
'
Me.DriveIntegrityDataGridViewCheckBoxColumn.DataPropertyName = "DriveIntegrity"
Me.DriveIntegrityDataGridViewCheckBoxColumn.HeaderText = "DriveIntegrity"
Me.DriveIntegrityDataGridViewCheckBoxColumn.Name = "DriveIntegrityDataGridViewCheckBoxColumn"
Me.DriveIntegrityDataGridViewCheckBoxColumn.ReadOnly = true
'
'ErrorClearedDataGridViewCheckBoxColumn3
'
Me.ErrorClearedDataGridViewCheckBoxColumn3.DataPropertyName = "ErrorCleared"
Me.ErrorClearedDataGridViewCheckBoxColumn3.HeaderText = "ErrorCleared"
Me.ErrorClearedDataGridViewCheckBoxColumn3.Name = "ErrorClearedDataGridViewCheckBoxColumn3"
Me.ErrorClearedDataGridViewCheckBoxColumn3.ReadOnly = true
'
'ErrorDescriptionDataGridViewTextBoxColumn3
'
Me.ErrorDescriptionDataGridViewTextBoxColumn3.DataPropertyName = "ErrorDescription"
Me.ErrorDescriptionDataGridViewTextBoxColumn3.HeaderText = "ErrorDescription"
Me.ErrorDescriptionDataGridViewTextBoxColumn3.Name = "ErrorDescriptionDataGridViewTextBoxColumn3"
Me.ErrorDescriptionDataGridViewTextBoxColumn3.ReadOnly = true
'
'ErrorMethodologyDataGridViewTextBoxColumn
'
Me.ErrorMethodologyDataGridViewTextBoxColumn.DataPropertyName = "ErrorMethodology"
Me.ErrorMethodologyDataGridViewTextBoxColumn.HeaderText = "ErrorMethodology"
Me.ErrorMethodologyDataGridViewTextBoxColumn.Name = "ErrorMethodologyDataGridViewTextBoxColumn"
Me.ErrorMethodologyDataGridViewTextBoxColumn.ReadOnly = true
'
'FileSystemFlagsExDataGridViewTextBoxColumn
'
Me.FileSystemFlagsExDataGridViewTextBoxColumn.DataPropertyName = "FileSystemFlagsEx"
Me.FileSystemFlagsExDataGridViewTextBoxColumn.HeaderText = "FileSystemFlagsEx"
Me.FileSystemFlagsExDataGridViewTextBoxColumn.Name = "FileSystemFlagsExDataGridViewTextBoxColumn"
Me.FileSystemFlagsExDataGridViewTextBoxColumn.ReadOnly = true
'
'IdDataGridViewTextBoxColumn
'
Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
Me.IdDataGridViewTextBoxColumn.ReadOnly = true
'
'InstallDateDataGridViewTextBoxColumn3
'
Me.InstallDateDataGridViewTextBoxColumn3.DataPropertyName = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn3.HeaderText = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn3.Name = "InstallDateDataGridViewTextBoxColumn3"
Me.InstallDateDataGridViewTextBoxColumn3.ReadOnly = true
'
'LastErrorCodeDataGridViewTextBoxColumn3
'
Me.LastErrorCodeDataGridViewTextBoxColumn3.DataPropertyName = "LastErrorCode"
Me.LastErrorCodeDataGridViewTextBoxColumn3.HeaderText = "LastErrorCode"
Me.LastErrorCodeDataGridViewTextBoxColumn3.Name = "LastErrorCodeDataGridViewTextBoxColumn3"
Me.LastErrorCodeDataGridViewTextBoxColumn3.ReadOnly = true
'
'MaxBlockSizeDataGridViewTextBoxColumn
'
Me.MaxBlockSizeDataGridViewTextBoxColumn.DataPropertyName = "MaxBlockSize"
Me.MaxBlockSizeDataGridViewTextBoxColumn.HeaderText = "MaxBlockSize"
Me.MaxBlockSizeDataGridViewTextBoxColumn.Name = "MaxBlockSizeDataGridViewTextBoxColumn"
Me.MaxBlockSizeDataGridViewTextBoxColumn.ReadOnly = true
'
'MaximumComponentLengthDataGridViewTextBoxColumn
'
Me.MaximumComponentLengthDataGridViewTextBoxColumn.DataPropertyName = "MaximumComponentLength"
Me.MaximumComponentLengthDataGridViewTextBoxColumn.HeaderText = "MaximumComponentLength"
Me.MaximumComponentLengthDataGridViewTextBoxColumn.Name = "MaximumComponentLengthDataGridViewTextBoxColumn"
Me.MaximumComponentLengthDataGridViewTextBoxColumn.ReadOnly = true
'
'MaxMediaSizeDataGridViewTextBoxColumn
'
Me.MaxMediaSizeDataGridViewTextBoxColumn.DataPropertyName = "MaxMediaSize"
Me.MaxMediaSizeDataGridViewTextBoxColumn.HeaderText = "MaxMediaSize"
Me.MaxMediaSizeDataGridViewTextBoxColumn.Name = "MaxMediaSizeDataGridViewTextBoxColumn"
Me.MaxMediaSizeDataGridViewTextBoxColumn.ReadOnly = true
'
'MediaLoadedDataGridViewCheckBoxColumn
'
Me.MediaLoadedDataGridViewCheckBoxColumn.DataPropertyName = "MediaLoaded"
Me.MediaLoadedDataGridViewCheckBoxColumn.HeaderText = "MediaLoaded"
Me.MediaLoadedDataGridViewCheckBoxColumn.Name = "MediaLoadedDataGridViewCheckBoxColumn"
Me.MediaLoadedDataGridViewCheckBoxColumn.ReadOnly = true
'
'MediaTypeDataGridViewTextBoxColumn
'
Me.MediaTypeDataGridViewTextBoxColumn.DataPropertyName = "MediaType"
Me.MediaTypeDataGridViewTextBoxColumn.HeaderText = "MediaType"
Me.MediaTypeDataGridViewTextBoxColumn.Name = "MediaTypeDataGridViewTextBoxColumn"
Me.MediaTypeDataGridViewTextBoxColumn.ReadOnly = true
'
'MfrAssignedRevisionLevelDataGridViewTextBoxColumn
'
Me.MfrAssignedRevisionLevelDataGridViewTextBoxColumn.DataPropertyName = "MfrAssignedRevisionLevel"
Me.MfrAssignedRevisionLevelDataGridViewTextBoxColumn.HeaderText = "MfrAssignedRevisionLevel"
Me.MfrAssignedRevisionLevelDataGridViewTextBoxColumn.Name = "MfrAssignedRevisionLevelDataGridViewTextBoxColumn"
Me.MfrAssignedRevisionLevelDataGridViewTextBoxColumn.ReadOnly = true
'
'MinBlockSizeDataGridViewTextBoxColumn
'
Me.MinBlockSizeDataGridViewTextBoxColumn.DataPropertyName = "MinBlockSize"
Me.MinBlockSizeDataGridViewTextBoxColumn.HeaderText = "MinBlockSize"
Me.MinBlockSizeDataGridViewTextBoxColumn.Name = "MinBlockSizeDataGridViewTextBoxColumn"
Me.MinBlockSizeDataGridViewTextBoxColumn.ReadOnly = true
'
'NameDataGridViewTextBoxColumn3
'
Me.NameDataGridViewTextBoxColumn3.DataPropertyName = "Name"
Me.NameDataGridViewTextBoxColumn3.HeaderText = "Name"
Me.NameDataGridViewTextBoxColumn3.Name = "NameDataGridViewTextBoxColumn3"
Me.NameDataGridViewTextBoxColumn3.ReadOnly = true
'
'NeedsCleaningDataGridViewCheckBoxColumn
'
Me.NeedsCleaningDataGridViewCheckBoxColumn.DataPropertyName = "NeedsCleaning"
Me.NeedsCleaningDataGridViewCheckBoxColumn.HeaderText = "NeedsCleaning"
Me.NeedsCleaningDataGridViewCheckBoxColumn.Name = "NeedsCleaningDataGridViewCheckBoxColumn"
Me.NeedsCleaningDataGridViewCheckBoxColumn.ReadOnly = true
'
'NumberOfMediaSupportedDataGridViewTextBoxColumn
'
Me.NumberOfMediaSupportedDataGridViewTextBoxColumn.DataPropertyName = "NumberOfMediaSupported"
Me.NumberOfMediaSupportedDataGridViewTextBoxColumn.HeaderText = "NumberOfMediaSupported"
Me.NumberOfMediaSupportedDataGridViewTextBoxColumn.Name = "NumberOfMediaSupportedDataGridViewTextBoxColumn"
Me.NumberOfMediaSupportedDataGridViewTextBoxColumn.ReadOnly = true
'
'PNPDeviceIDDataGridViewTextBoxColumn3
'
Me.PNPDeviceIDDataGridViewTextBoxColumn3.DataPropertyName = "PNPDeviceID"
Me.PNPDeviceIDDataGridViewTextBoxColumn3.HeaderText = "PNPDeviceID"
Me.PNPDeviceIDDataGridViewTextBoxColumn3.Name = "PNPDeviceIDDataGridViewTextBoxColumn3"
Me.PNPDeviceIDDataGridViewTextBoxColumn3.ReadOnly = true
'
'PowerManagementSupportedDataGridViewCheckBoxColumn3
'
Me.PowerManagementSupportedDataGridViewCheckBoxColumn3.DataPropertyName = "PowerManagementSupported"
Me.PowerManagementSupportedDataGridViewCheckBoxColumn3.HeaderText = "PowerManagementSupported"
Me.PowerManagementSupportedDataGridViewCheckBoxColumn3.Name = "PowerManagementSupportedDataGridViewCheckBoxColumn3"
Me.PowerManagementSupportedDataGridViewCheckBoxColumn3.ReadOnly = true
'
'RevisionLevelDataGridViewTextBoxColumn
'
Me.RevisionLevelDataGridViewTextBoxColumn.DataPropertyName = "RevisionLevel"
Me.RevisionLevelDataGridViewTextBoxColumn.HeaderText = "RevisionLevel"
Me.RevisionLevelDataGridViewTextBoxColumn.Name = "RevisionLevelDataGridViewTextBoxColumn"
Me.RevisionLevelDataGridViewTextBoxColumn.ReadOnly = true
'
'SCSIBusDataGridViewTextBoxColumn
'
Me.SCSIBusDataGridViewTextBoxColumn.DataPropertyName = "SCSIBus"
Me.SCSIBusDataGridViewTextBoxColumn.HeaderText = "SCSIBus"
Me.SCSIBusDataGridViewTextBoxColumn.Name = "SCSIBusDataGridViewTextBoxColumn"
Me.SCSIBusDataGridViewTextBoxColumn.ReadOnly = true
'
'SCSILogicalUnitDataGridViewTextBoxColumn
'
Me.SCSILogicalUnitDataGridViewTextBoxColumn.DataPropertyName = "SCSILogicalUnit"
Me.SCSILogicalUnitDataGridViewTextBoxColumn.HeaderText = "SCSILogicalUnit"
Me.SCSILogicalUnitDataGridViewTextBoxColumn.Name = "SCSILogicalUnitDataGridViewTextBoxColumn"
Me.SCSILogicalUnitDataGridViewTextBoxColumn.ReadOnly = true
'
'SCSIPortDataGridViewTextBoxColumn
'
Me.SCSIPortDataGridViewTextBoxColumn.DataPropertyName = "SCSIPort"
Me.SCSIPortDataGridViewTextBoxColumn.HeaderText = "SCSIPort"
Me.SCSIPortDataGridViewTextBoxColumn.Name = "SCSIPortDataGridViewTextBoxColumn"
Me.SCSIPortDataGridViewTextBoxColumn.ReadOnly = true
'
'SCSITargetIdDataGridViewTextBoxColumn
'
Me.SCSITargetIdDataGridViewTextBoxColumn.DataPropertyName = "SCSITargetId"
Me.SCSITargetIdDataGridViewTextBoxColumn.HeaderText = "SCSITargetId"
Me.SCSITargetIdDataGridViewTextBoxColumn.Name = "SCSITargetIdDataGridViewTextBoxColumn"
Me.SCSITargetIdDataGridViewTextBoxColumn.ReadOnly = true
'
'SerialNumberDataGridViewTextBoxColumn
'
Me.SerialNumberDataGridViewTextBoxColumn.DataPropertyName = "SerialNumber"
Me.SerialNumberDataGridViewTextBoxColumn.HeaderText = "SerialNumber"
Me.SerialNumberDataGridViewTextBoxColumn.Name = "SerialNumberDataGridViewTextBoxColumn"
Me.SerialNumberDataGridViewTextBoxColumn.ReadOnly = true
'
'SizeDataGridViewTextBoxColumn
'
Me.SizeDataGridViewTextBoxColumn.DataPropertyName = "Size"
Me.SizeDataGridViewTextBoxColumn.HeaderText = "Size"
Me.SizeDataGridViewTextBoxColumn.Name = "SizeDataGridViewTextBoxColumn"
Me.SizeDataGridViewTextBoxColumn.ReadOnly = true
'
'StatusDataGridViewTextBoxColumn3
'
Me.StatusDataGridViewTextBoxColumn3.DataPropertyName = "Status"
Me.StatusDataGridViewTextBoxColumn3.HeaderText = "Status"
Me.StatusDataGridViewTextBoxColumn3.Name = "StatusDataGridViewTextBoxColumn3"
Me.StatusDataGridViewTextBoxColumn3.ReadOnly = true
'
'StatusInfoDataGridViewTextBoxColumn3
'
Me.StatusInfoDataGridViewTextBoxColumn3.DataPropertyName = "StatusInfo"
Me.StatusInfoDataGridViewTextBoxColumn3.HeaderText = "StatusInfo"
Me.StatusInfoDataGridViewTextBoxColumn3.Name = "StatusInfoDataGridViewTextBoxColumn3"
Me.StatusInfoDataGridViewTextBoxColumn3.ReadOnly = true
'
'SystemCreationClassNameDataGridViewTextBoxColumn3
'
Me.SystemCreationClassNameDataGridViewTextBoxColumn3.DataPropertyName = "SystemCreationClassName"
Me.SystemCreationClassNameDataGridViewTextBoxColumn3.HeaderText = "SystemCreationClassName"
Me.SystemCreationClassNameDataGridViewTextBoxColumn3.Name = "SystemCreationClassNameDataGridViewTextBoxColumn3"
Me.SystemCreationClassNameDataGridViewTextBoxColumn3.ReadOnly = true
'
'SystemNameDataGridViewTextBoxColumn3
'
Me.SystemNameDataGridViewTextBoxColumn3.DataPropertyName = "SystemName"
Me.SystemNameDataGridViewTextBoxColumn3.HeaderText = "SystemName"
Me.SystemNameDataGridViewTextBoxColumn3.Name = "SystemNameDataGridViewTextBoxColumn3"
Me.SystemNameDataGridViewTextBoxColumn3.ReadOnly = true
'
'TransferRateDataGridViewTextBoxColumn
'
Me.TransferRateDataGridViewTextBoxColumn.DataPropertyName = "TransferRate"
Me.TransferRateDataGridViewTextBoxColumn.HeaderText = "TransferRate"
Me.TransferRateDataGridViewTextBoxColumn.Name = "TransferRateDataGridViewTextBoxColumn"
Me.TransferRateDataGridViewTextBoxColumn.ReadOnly = true
'
'VolumeNameDataGridViewTextBoxColumn
'
Me.VolumeNameDataGridViewTextBoxColumn.DataPropertyName = "VolumeName"
Me.VolumeNameDataGridViewTextBoxColumn.HeaderText = "VolumeName"
Me.VolumeNameDataGridViewTextBoxColumn.Name = "VolumeNameDataGridViewTextBoxColumn"
Me.VolumeNameDataGridViewTextBoxColumn.ReadOnly = true
'
'VolumeSerialNumberDataGridViewTextBoxColumn
'
Me.VolumeSerialNumberDataGridViewTextBoxColumn.DataPropertyName = "VolumeSerialNumber"
Me.VolumeSerialNumberDataGridViewTextBoxColumn.HeaderText = "VolumeSerialNumber"
Me.VolumeSerialNumberDataGridViewTextBoxColumn.Name = "VolumeSerialNumberDataGridViewTextBoxColumn"
Me.VolumeSerialNumberDataGridViewTextBoxColumn.ReadOnly = true
'
'Win32CDROMDriveBindingSource
'
Me.Win32CDROMDriveBindingSource.DataSource = GetType(WMIwrapper.Win32_CDROMDrive)
'
'PanelProcessors
'
Me.PanelProcessors.AutoScroll = true
Me.PanelProcessors.Controls.Add(Me.dgvProcessors)
Me.PanelProcessors.Dock = System.Windows.Forms.DockStyle.Fill
Me.PanelProcessors.Location = New System.Drawing.Point(0, 0)
Me.PanelProcessors.Name = "PanelProcessors"
Me.PanelProcessors.Size = New System.Drawing.Size(468, 183)
Me.PanelProcessors.TabIndex = 2
'
'dgvProcessors
'
Me.dgvProcessors.AllowUserToAddRows = false
Me.dgvProcessors.AllowUserToDeleteRows = false
Me.dgvProcessors.AutoGenerateColumns = false
Me.dgvProcessors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
Me.dgvProcessors.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AddressWidthDataGridViewTextBoxColumn, Me.ArchitectureDataGridViewTextBoxColumn, Me.AvailabilityDataGridViewTextBoxColumn, Me.CaptionDataGridViewTextBoxColumn, Me.ConfigManagerErrorDataGridViewTextBoxColumn, Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn, Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn, Me.CpuStatusDataGridViewTextBoxColumn, Me.CreationClassNameDataGridViewTextBoxColumn, Me.CurrentClockSpeedDataGridViewTextBoxColumn, Me.CurrentVoltageDataGridViewTextBoxColumn, Me.DataWidthDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.DeviceIDDataGridViewTextBoxColumn, Me.ErrorClearedDataGridViewCheckBoxColumn, Me.ErrorDescriptionDataGridViewTextBoxColumn, Me.ExtClockDataGridViewTextBoxColumn, Me.FamilyDataGridViewTextBoxColumn, Me.InstallDateDataGridViewTextBoxColumn, Me.L2CacheSizeDataGridViewTextBoxColumn, Me.L2CacheSpeedDataGridViewTextBoxColumn, Me.L3CacheSizeDataGridViewTextBoxColumn, Me.L3CacheSpeedDataGridViewTextBoxColumn, Me.LastErrorCodeDataGridViewTextBoxColumn, Me.LevelDataGridViewTextBoxColumn, Me.LoadPercentageDataGridViewTextBoxColumn, Me.ManufacturerDataGridViewTextBoxColumn, Me.MaxClockSpeedDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.NumberOfCoresDataGridViewTextBoxColumn, Me.NumberOfLogicalProcessorsDataGridViewTextBoxColumn, Me.OtherFamilyDescriptionDataGridViewTextBoxColumn, Me.PNPDeviceIDDataGridViewTextBoxColumn, Me.PowerManagementSupportedDataGridViewCheckBoxColumn, Me.ProcessorIdDataGridViewTextBoxColumn, Me.ProcessorTypeDataGridViewTextBoxColumn, Me.RevisionDataGridViewTextBoxColumn, Me.RoleDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.StatusInfoDataGridViewTextBoxColumn, Me.SocketDesignationDataGridViewTextBoxColumn, Me.SteppingDataGridViewTextBoxColumn, Me.SystemCreationClassNameDataGridViewTextBoxColumn, Me.SystemNameDataGridViewTextBoxColumn, Me.UniqueIdDataGridViewTextBoxColumn, Me.UpgradeMethodDataGridViewTextBoxColumn, Me.VersionDataGridViewTextBoxColumn, Me.VoltageCapsDataGridViewTextBoxColumn})
Me.dgvProcessors.DataSource = Me.Win32ProcessorBindingSource
Me.dgvProcessors.Dock = System.Windows.Forms.DockStyle.Fill
Me.dgvProcessors.Location = New System.Drawing.Point(0, 0)
Me.dgvProcessors.Name = "dgvProcessors"
Me.dgvProcessors.ReadOnly = true
Me.dgvProcessors.Size = New System.Drawing.Size(468, 183)
Me.dgvProcessors.TabIndex = 22
'
'AddressWidthDataGridViewTextBoxColumn
'
Me.AddressWidthDataGridViewTextBoxColumn.DataPropertyName = "AddressWidth"
Me.AddressWidthDataGridViewTextBoxColumn.HeaderText = "AddressWidth"
Me.AddressWidthDataGridViewTextBoxColumn.Name = "AddressWidthDataGridViewTextBoxColumn"
Me.AddressWidthDataGridViewTextBoxColumn.ReadOnly = true
'
'ArchitectureDataGridViewTextBoxColumn
'
Me.ArchitectureDataGridViewTextBoxColumn.DataPropertyName = "Architecture"
Me.ArchitectureDataGridViewTextBoxColumn.HeaderText = "Architecture"
Me.ArchitectureDataGridViewTextBoxColumn.Name = "ArchitectureDataGridViewTextBoxColumn"
Me.ArchitectureDataGridViewTextBoxColumn.ReadOnly = true
'
'AvailabilityDataGridViewTextBoxColumn
'
Me.AvailabilityDataGridViewTextBoxColumn.DataPropertyName = "Availability"
Me.AvailabilityDataGridViewTextBoxColumn.HeaderText = "Availability"
Me.AvailabilityDataGridViewTextBoxColumn.Name = "AvailabilityDataGridViewTextBoxColumn"
Me.AvailabilityDataGridViewTextBoxColumn.ReadOnly = true
'
'CaptionDataGridViewTextBoxColumn
'
Me.CaptionDataGridViewTextBoxColumn.DataPropertyName = "Caption"
Me.CaptionDataGridViewTextBoxColumn.HeaderText = "Caption"
Me.CaptionDataGridViewTextBoxColumn.Name = "CaptionDataGridViewTextBoxColumn"
Me.CaptionDataGridViewTextBoxColumn.ReadOnly = true
'
'ConfigManagerErrorDataGridViewTextBoxColumn
'
Me.ConfigManagerErrorDataGridViewTextBoxColumn.DataPropertyName = "ConfigManagerError"
Me.ConfigManagerErrorDataGridViewTextBoxColumn.HeaderText = "ConfigManagerError"
Me.ConfigManagerErrorDataGridViewTextBoxColumn.Name = "ConfigManagerErrorDataGridViewTextBoxColumn"
Me.ConfigManagerErrorDataGridViewTextBoxColumn.ReadOnly = true
'
'ConfigManagerErrorCodeDataGridViewTextBoxColumn
'
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn.DataPropertyName = "ConfigManagerErrorCode"
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn.HeaderText = "ConfigManagerErrorCode"
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn.Name = "ConfigManagerErrorCodeDataGridViewTextBoxColumn"
Me.ConfigManagerErrorCodeDataGridViewTextBoxColumn.ReadOnly = true
'
'ConfigManagerUserConfigDataGridViewCheckBoxColumn
'
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn.DataPropertyName = "ConfigManagerUserConfig"
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn.HeaderText = "ConfigManagerUserConfig"
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn.Name = "ConfigManagerUserConfigDataGridViewCheckBoxColumn"
Me.ConfigManagerUserConfigDataGridViewCheckBoxColumn.ReadOnly = true
'
'CpuStatusDataGridViewTextBoxColumn
'
Me.CpuStatusDataGridViewTextBoxColumn.DataPropertyName = "CpuStatus"
Me.CpuStatusDataGridViewTextBoxColumn.HeaderText = "CpuStatus"
Me.CpuStatusDataGridViewTextBoxColumn.Name = "CpuStatusDataGridViewTextBoxColumn"
Me.CpuStatusDataGridViewTextBoxColumn.ReadOnly = true
'
'CreationClassNameDataGridViewTextBoxColumn
'
Me.CreationClassNameDataGridViewTextBoxColumn.DataPropertyName = "CreationClassName"
Me.CreationClassNameDataGridViewTextBoxColumn.HeaderText = "CreationClassName"
Me.CreationClassNameDataGridViewTextBoxColumn.Name = "CreationClassNameDataGridViewTextBoxColumn"
Me.CreationClassNameDataGridViewTextBoxColumn.ReadOnly = true
'
'CurrentClockSpeedDataGridViewTextBoxColumn
'
Me.CurrentClockSpeedDataGridViewTextBoxColumn.DataPropertyName = "CurrentClockSpeed"
Me.CurrentClockSpeedDataGridViewTextBoxColumn.HeaderText = "CurrentClockSpeed"
Me.CurrentClockSpeedDataGridViewTextBoxColumn.Name = "CurrentClockSpeedDataGridViewTextBoxColumn"
Me.CurrentClockSpeedDataGridViewTextBoxColumn.ReadOnly = true
'
'CurrentVoltageDataGridViewTextBoxColumn
'
Me.CurrentVoltageDataGridViewTextBoxColumn.DataPropertyName = "CurrentVoltage"
Me.CurrentVoltageDataGridViewTextBoxColumn.HeaderText = "CurrentVoltage"
Me.CurrentVoltageDataGridViewTextBoxColumn.Name = "CurrentVoltageDataGridViewTextBoxColumn"
Me.CurrentVoltageDataGridViewTextBoxColumn.ReadOnly = true
'
'DataWidthDataGridViewTextBoxColumn
'
Me.DataWidthDataGridViewTextBoxColumn.DataPropertyName = "DataWidth"
Me.DataWidthDataGridViewTextBoxColumn.HeaderText = "DataWidth"
Me.DataWidthDataGridViewTextBoxColumn.Name = "DataWidthDataGridViewTextBoxColumn"
Me.DataWidthDataGridViewTextBoxColumn.ReadOnly = true
'
'DescriptionDataGridViewTextBoxColumn
'
Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = true
'
'DeviceIDDataGridViewTextBoxColumn
'
Me.DeviceIDDataGridViewTextBoxColumn.DataPropertyName = "DeviceID"
Me.DeviceIDDataGridViewTextBoxColumn.HeaderText = "DeviceID"
Me.DeviceIDDataGridViewTextBoxColumn.Name = "DeviceIDDataGridViewTextBoxColumn"
Me.DeviceIDDataGridViewTextBoxColumn.ReadOnly = true
'
'ErrorClearedDataGridViewCheckBoxColumn
'
Me.ErrorClearedDataGridViewCheckBoxColumn.DataPropertyName = "ErrorCleared"
Me.ErrorClearedDataGridViewCheckBoxColumn.HeaderText = "ErrorCleared"
Me.ErrorClearedDataGridViewCheckBoxColumn.Name = "ErrorClearedDataGridViewCheckBoxColumn"
Me.ErrorClearedDataGridViewCheckBoxColumn.ReadOnly = true
'
'ErrorDescriptionDataGridViewTextBoxColumn
'
Me.ErrorDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ErrorDescription"
Me.ErrorDescriptionDataGridViewTextBoxColumn.HeaderText = "ErrorDescription"
Me.ErrorDescriptionDataGridViewTextBoxColumn.Name = "ErrorDescriptionDataGridViewTextBoxColumn"
Me.ErrorDescriptionDataGridViewTextBoxColumn.ReadOnly = true
'
'ExtClockDataGridViewTextBoxColumn
'
Me.ExtClockDataGridViewTextBoxColumn.DataPropertyName = "ExtClock"
Me.ExtClockDataGridViewTextBoxColumn.HeaderText = "ExtClock"
Me.ExtClockDataGridViewTextBoxColumn.Name = "ExtClockDataGridViewTextBoxColumn"
Me.ExtClockDataGridViewTextBoxColumn.ReadOnly = true
'
'FamilyDataGridViewTextBoxColumn
'
Me.FamilyDataGridViewTextBoxColumn.DataPropertyName = "Family"
Me.FamilyDataGridViewTextBoxColumn.HeaderText = "Family"
Me.FamilyDataGridViewTextBoxColumn.Name = "FamilyDataGridViewTextBoxColumn"
Me.FamilyDataGridViewTextBoxColumn.ReadOnly = true
'
'InstallDateDataGridViewTextBoxColumn
'
Me.InstallDateDataGridViewTextBoxColumn.DataPropertyName = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn.HeaderText = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn.Name = "InstallDateDataGridViewTextBoxColumn"
Me.InstallDateDataGridViewTextBoxColumn.ReadOnly = true
'
'L2CacheSizeDataGridViewTextBoxColumn
'
Me.L2CacheSizeDataGridViewTextBoxColumn.DataPropertyName = "L2CacheSize"
Me.L2CacheSizeDataGridViewTextBoxColumn.HeaderText = "L2CacheSize"
Me.L2CacheSizeDataGridViewTextBoxColumn.Name = "L2CacheSizeDataGridViewTextBoxColumn"
Me.L2CacheSizeDataGridViewTextBoxColumn.ReadOnly = true
'
'L2CacheSpeedDataGridViewTextBoxColumn
'
Me.L2CacheSpeedDataGridViewTextBoxColumn.DataPropertyName = "L2CacheSpeed"
Me.L2CacheSpeedDataGridViewTextBoxColumn.HeaderText = "L2CacheSpeed"
Me.L2CacheSpeedDataGridViewTextBoxColumn.Name = "L2CacheSpeedDataGridViewTextBoxColumn"
Me.L2CacheSpeedDataGridViewTextBoxColumn.ReadOnly = true
'
'L3CacheSizeDataGridViewTextBoxColumn
'
Me.L3CacheSizeDataGridViewTextBoxColumn.DataPropertyName = "L3CacheSize"
Me.L3CacheSizeDataGridViewTextBoxColumn.HeaderText = "L3CacheSize"
Me.L3CacheSizeDataGridViewTextBoxColumn.Name = "L3CacheSizeDataGridViewTextBoxColumn"
Me.L3CacheSizeDataGridViewTextBoxColumn.ReadOnly = true
'
'L3CacheSpeedDataGridViewTextBoxColumn
'
Me.L3CacheSpeedDataGridViewTextBoxColumn.DataPropertyName = "L3CacheSpeed"
Me.L3CacheSpeedDataGridViewTextBoxColumn.HeaderText = "L3CacheSpeed"
Me.L3CacheSpeedDataGridViewTextBoxColumn.Name = "L3CacheSpeedDataGridViewTextBoxColumn"
Me.L3CacheSpeedDataGridViewTextBoxColumn.ReadOnly = true
'
'LastErrorCodeDataGridViewTextBoxColumn
'
Me.LastErrorCodeDataGridViewTextBoxColumn.DataPropertyName = "LastErrorCode"
Me.LastErrorCodeDataGridViewTextBoxColumn.HeaderText = "LastErrorCode"
Me.LastErrorCodeDataGridViewTextBoxColumn.Name = "LastErrorCodeDataGridViewTextBoxColumn"
Me.LastErrorCodeDataGridViewTextBoxColumn.ReadOnly = true
'
'LevelDataGridViewTextBoxColumn
'
Me.LevelDataGridViewTextBoxColumn.DataPropertyName = "Level"
Me.LevelDataGridViewTextBoxColumn.HeaderText = "Level"
Me.LevelDataGridViewTextBoxColumn.Name = "LevelDataGridViewTextBoxColumn"
Me.LevelDataGridViewTextBoxColumn.ReadOnly = true
'
'LoadPercentageDataGridViewTextBoxColumn
'
Me.LoadPercentageDataGridViewTextBoxColumn.DataPropertyName = "LoadPercentage"
Me.LoadPercentageDataGridViewTextBoxColumn.HeaderText = "LoadPercentage"
Me.LoadPercentageDataGridViewTextBoxColumn.Name = "LoadPercentageDataGridViewTextBoxColumn"
Me.LoadPercentageDataGridViewTextBoxColumn.ReadOnly = true
'
'ManufacturerDataGridViewTextBoxColumn
'
Me.ManufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer"
Me.ManufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer"
Me.ManufacturerDataGridViewTextBoxColumn.Name = "ManufacturerDataGridViewTextBoxColumn"
Me.ManufacturerDataGridViewTextBoxColumn.ReadOnly = true
'
'MaxClockSpeedDataGridViewTextBoxColumn
'
Me.MaxClockSpeedDataGridViewTextBoxColumn.DataPropertyName = "MaxClockSpeed"
Me.MaxClockSpeedDataGridViewTextBoxColumn.HeaderText = "MaxClockSpeed"
Me.MaxClockSpeedDataGridViewTextBoxColumn.Name = "MaxClockSpeedDataGridViewTextBoxColumn"
Me.MaxClockSpeedDataGridViewTextBoxColumn.ReadOnly = true
'
'NameDataGridViewTextBoxColumn
'
Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
Me.NameDataGridViewTextBoxColumn.ReadOnly = true
'
'NumberOfCoresDataGridViewTextBoxColumn
'
Me.NumberOfCoresDataGridViewTextBoxColumn.DataPropertyName = "NumberOfCores"
Me.NumberOfCoresDataGridViewTextBoxColumn.HeaderText = "NumberOfCores"
Me.NumberOfCoresDataGridViewTextBoxColumn.Name = "NumberOfCoresDataGridViewTextBoxColumn"
Me.NumberOfCoresDataGridViewTextBoxColumn.ReadOnly = true
'
'NumberOfLogicalProcessorsDataGridViewTextBoxColumn
'
Me.NumberOfLogicalProcessorsDataGridViewTextBoxColumn.DataPropertyName = "NumberOfLogicalProcessors"
Me.NumberOfLogicalProcessorsDataGridViewTextBoxColumn.HeaderText = "NumberOfLogicalProcessors"
Me.NumberOfLogicalProcessorsDataGridViewTextBoxColumn.Name = "NumberOfLogicalProcessorsDataGridViewTextBoxColumn"
Me.NumberOfLogicalProcessorsDataGridViewTextBoxColumn.ReadOnly = true
'
'OtherFamilyDescriptionDataGridViewTextBoxColumn
'
Me.OtherFamilyDescriptionDataGridViewTextBoxColumn.DataPropertyName = "OtherFamilyDescription"
Me.OtherFamilyDescriptionDataGridViewTextBoxColumn.HeaderText = "OtherFamilyDescription"
Me.OtherFamilyDescriptionDataGridViewTextBoxColumn.Name = "OtherFamilyDescriptionDataGridViewTextBoxColumn"
Me.OtherFamilyDescriptionDataGridViewTextBoxColumn.ReadOnly = true
'
'PNPDeviceIDDataGridViewTextBoxColumn
'
Me.PNPDeviceIDDataGridViewTextBoxColumn.DataPropertyName = "PNPDeviceID"
Me.PNPDeviceIDDataGridViewTextBoxColumn.HeaderText = "PNPDeviceID"
Me.PNPDeviceIDDataGridViewTextBoxColumn.Name = "PNPDeviceIDDataGridViewTextBoxColumn"
Me.PNPDeviceIDDataGridViewTextBoxColumn.ReadOnly = true
'
'PowerManagementSupportedDataGridViewCheckBoxColumn
'
Me.PowerManagementSupportedDataGridViewCheckBoxColumn.DataPropertyName = "PowerManagementSupported"
Me.PowerManagementSupportedDataGridViewCheckBoxColumn.HeaderText = "PowerManagementSupported"
Me.PowerManagementSupportedDataGridViewCheckBoxColumn.Name = "PowerManagementSupportedDataGridViewCheckBoxColumn"
Me.PowerManagementSupportedDataGridViewCheckBoxColumn.ReadOnly = true
'
'ProcessorIdDataGridViewTextBoxColumn
'
Me.ProcessorIdDataGridViewTextBoxColumn.DataPropertyName = "ProcessorId"
Me.ProcessorIdDataGridViewTextBoxColumn.HeaderText = "ProcessorId"
Me.ProcessorIdDataGridViewTextBoxColumn.Name = "ProcessorIdDataGridViewTextBoxColumn"
Me.ProcessorIdDataGridViewTextBoxColumn.ReadOnly = true
'
'ProcessorTypeDataGridViewTextBoxColumn
'
Me.ProcessorTypeDataGridViewTextBoxColumn.DataPropertyName = "ProcessorType"
Me.ProcessorTypeDataGridViewTextBoxColumn.HeaderText = "ProcessorType"
Me.ProcessorTypeDataGridViewTextBoxColumn.Name = "ProcessorTypeDataGridViewTextBoxColumn"
Me.ProcessorTypeDataGridViewTextBoxColumn.ReadOnly = true
'
'RevisionDataGridViewTextBoxColumn
'
Me.RevisionDataGridViewTextBoxColumn.DataPropertyName = "Revision"
Me.RevisionDataGridViewTextBoxColumn.HeaderText = "Revision"
Me.RevisionDataGridViewTextBoxColumn.Name = "RevisionDataGridViewTextBoxColumn"
Me.RevisionDataGridViewTextBoxColumn.ReadOnly = true
'
'RoleDataGridViewTextBoxColumn
'
Me.RoleDataGridViewTextBoxColumn.DataPropertyName = "Role"
Me.RoleDataGridViewTextBoxColumn.HeaderText = "Role"
Me.RoleDataGridViewTextBoxColumn.Name = "RoleDataGridViewTextBoxColumn"
Me.RoleDataGridViewTextBoxColumn.ReadOnly = true
'
'StatusDataGridViewTextBoxColumn
'
Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
Me.StatusDataGridViewTextBoxColumn.ReadOnly = true
'
'StatusInfoDataGridViewTextBoxColumn
'
Me.StatusInfoDataGridViewTextBoxColumn.DataPropertyName = "StatusInfo"
Me.StatusInfoDataGridViewTextBoxColumn.HeaderText = "StatusInfo"
Me.StatusInfoDataGridViewTextBoxColumn.Name = "StatusInfoDataGridViewTextBoxColumn"
Me.StatusInfoDataGridViewTextBoxColumn.ReadOnly = true
'
'SocketDesignationDataGridViewTextBoxColumn
'
Me.SocketDesignationDataGridViewTextBoxColumn.DataPropertyName = "SocketDesignation"
Me.SocketDesignationDataGridViewTextBoxColumn.HeaderText = "SocketDesignation"
Me.SocketDesignationDataGridViewTextBoxColumn.Name = "SocketDesignationDataGridViewTextBoxColumn"
Me.SocketDesignationDataGridViewTextBoxColumn.ReadOnly = true
'
'SteppingDataGridViewTextBoxColumn
'
Me.SteppingDataGridViewTextBoxColumn.DataPropertyName = "Stepping"
Me.SteppingDataGridViewTextBoxColumn.HeaderText = "Stepping"
Me.SteppingDataGridViewTextBoxColumn.Name = "SteppingDataGridViewTextBoxColumn"
Me.SteppingDataGridViewTextBoxColumn.ReadOnly = true
'
'SystemCreationClassNameDataGridViewTextBoxColumn
'
Me.SystemCreationClassNameDataGridViewTextBoxColumn.DataPropertyName = "SystemCreationClassName"
Me.SystemCreationClassNameDataGridViewTextBoxColumn.HeaderText = "SystemCreationClassName"
Me.SystemCreationClassNameDataGridViewTextBoxColumn.Name = "SystemCreationClassNameDataGridViewTextBoxColumn"
Me.SystemCreationClassNameDataGridViewTextBoxColumn.ReadOnly = true
'
'SystemNameDataGridViewTextBoxColumn
'
Me.SystemNameDataGridViewTextBoxColumn.DataPropertyName = "SystemName"
Me.SystemNameDataGridViewTextBoxColumn.HeaderText = "SystemName"
Me.SystemNameDataGridViewTextBoxColumn.Name = "SystemNameDataGridViewTextBoxColumn"
Me.SystemNameDataGridViewTextBoxColumn.ReadOnly = true
'
'UniqueIdDataGridViewTextBoxColumn
'
Me.UniqueIdDataGridViewTextBoxColumn.DataPropertyName = "UniqueId"
Me.UniqueIdDataGridViewTextBoxColumn.HeaderText = "UniqueId"
Me.UniqueIdDataGridViewTextBoxColumn.Name = "UniqueIdDataGridViewTextBoxColumn"
Me.UniqueIdDataGridViewTextBoxColumn.ReadOnly = true
'
'UpgradeMethodDataGridViewTextBoxColumn
'
Me.UpgradeMethodDataGridViewTextBoxColumn.DataPropertyName = "UpgradeMethod"
Me.UpgradeMethodDataGridViewTextBoxColumn.HeaderText = "UpgradeMethod"
Me.UpgradeMethodDataGridViewTextBoxColumn.Name = "UpgradeMethodDataGridViewTextBoxColumn"
Me.UpgradeMethodDataGridViewTextBoxColumn.ReadOnly = true
'
'VersionDataGridViewTextBoxColumn
'
Me.VersionDataGridViewTextBoxColumn.DataPropertyName = "Version"
Me.VersionDataGridViewTextBoxColumn.HeaderText = "Version"
Me.VersionDataGridViewTextBoxColumn.Name = "VersionDataGridViewTextBoxColumn"
Me.VersionDataGridViewTextBoxColumn.ReadOnly = true
'
'VoltageCapsDataGridViewTextBoxColumn
'
Me.VoltageCapsDataGridViewTextBoxColumn.DataPropertyName = "VoltageCaps"
Me.VoltageCapsDataGridViewTextBoxColumn.HeaderText = "VoltageCaps"
Me.VoltageCapsDataGridViewTextBoxColumn.Name = "VoltageCapsDataGridViewTextBoxColumn"
Me.VoltageCapsDataGridViewTextBoxColumn.ReadOnly = true
'
'Win32ProcessorBindingSource
'
Me.Win32ProcessorBindingSource.DataSource = GetType(WMIwrapper.Win32_Processor)
'
'SplitContainer2
'
Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
Me.SplitContainer2.Name = "SplitContainer2"
'
'SplitContainer2.Panel1
'
Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer1)
'
'SplitContainer2.Panel2
'
Me.SplitContainer2.Panel2.Controls.Add(Me.dgvProperties)
Me.SplitContainer2.Size = New System.Drawing.Size(625, 361)
Me.SplitContainer2.SplitterDistance = 468
Me.SplitContainer2.TabIndex = 1
'
'dgvProperties
'
Me.dgvProperties.AllowUserToAddRows = false
Me.dgvProperties.AllowUserToDeleteRows = false
Me.dgvProperties.AllowUserToOrderColumns = true
Me.dgvProperties.BackgroundColor = System.Drawing.Color.Maroon
Me.dgvProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
Me.dgvProperties.Dock = System.Windows.Forms.DockStyle.Fill
Me.dgvProperties.Location = New System.Drawing.Point(0, 0)
Me.dgvProperties.Name = "dgvProperties"
Me.dgvProperties.ReadOnly = true
Me.dgvProperties.Size = New System.Drawing.Size(153, 361)
Me.dgvProperties.TabIndex = 1
'
'Win32PhysicalMemoryLocationBindingSource
'
Me.Win32PhysicalMemoryLocationBindingSource.DataSource = GetType(WMIwrapper.Win32_PhysicalMemoryLocation)
'
'Win32VolumesBindingSource
'
Me.Win32VolumesBindingSource.DataSource = GetType(WMIwrapper.Win32_Volumes)
'
'CaptionDataGridViewTextBoxColumn23
'
Me.CaptionDataGridViewTextBoxColumn23.DataPropertyName = "Caption"
Me.CaptionDataGridViewTextBoxColumn23.HeaderText = "Caption"
Me.CaptionDataGridViewTextBoxColumn23.Name = "CaptionDataGridViewTextBoxColumn23"
Me.CaptionDataGridViewTextBoxColumn23.ReadOnly = true
'
'DescriptionDataGridViewTextBoxColumn24
'
Me.DescriptionDataGridViewTextBoxColumn24.DataPropertyName = "Description"
Me.DescriptionDataGridViewTextBoxColumn24.HeaderText = "Description"
Me.DescriptionDataGridViewTextBoxColumn24.Name = "DescriptionDataGridViewTextBoxColumn24"
Me.DescriptionDataGridViewTextBoxColumn24.ReadOnly = true
'
'DomainDataGridViewTextBoxColumn3
'
Me.DomainDataGridViewTextBoxColumn3.DataPropertyName = "Domain"
Me.DomainDataGridViewTextBoxColumn3.HeaderText = "Domain"
Me.DomainDataGridViewTextBoxColumn3.Name = "DomainDataGridViewTextBoxColumn3"
Me.DomainDataGridViewTextBoxColumn3.ReadOnly = true
'
'InstallDateDataGridViewTextBoxColumn22
'
Me.InstallDateDataGridViewTextBoxColumn22.DataPropertyName = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn22.HeaderText = "InstallDate"
Me.InstallDateDataGridViewTextBoxColumn22.Name = "InstallDateDataGridViewTextBoxColumn22"
Me.InstallDateDataGridViewTextBoxColumn22.ReadOnly = true
'
'LocalAccountDataGridViewCheckBoxColumn2
'
Me.LocalAccountDataGridViewCheckBoxColumn2.DataPropertyName = "LocalAccount"
Me.LocalAccountDataGridViewCheckBoxColumn2.HeaderText = "LocalAccount"
Me.LocalAccountDataGridViewCheckBoxColumn2.Name = "LocalAccountDataGridViewCheckBoxColumn2"
Me.LocalAccountDataGridViewCheckBoxColumn2.ReadOnly = true
'
'NameDataGridViewTextBoxColumn15
'
Me.NameDataGridViewTextBoxColumn15.DataPropertyName = "Name"
Me.NameDataGridViewTextBoxColumn15.HeaderText = "Name"
Me.NameDataGridViewTextBoxColumn15.Name = "NameDataGridViewTextBoxColumn15"
Me.NameDataGridViewTextBoxColumn15.ReadOnly = true
'
'SIDDataGridViewTextBoxColumn2
'
Me.SIDDataGridViewTextBoxColumn2.DataPropertyName = "SID"
Me.SIDDataGridViewTextBoxColumn2.HeaderText = "SID"
Me.SIDDataGridViewTextBoxColumn2.Name = "SIDDataGridViewTextBoxColumn2"
Me.SIDDataGridViewTextBoxColumn2.ReadOnly = true
'
'SIDTypeDataGridViewTextBoxColumn2
'
Me.SIDTypeDataGridViewTextBoxColumn2.DataPropertyName = "SIDType"
Me.SIDTypeDataGridViewTextBoxColumn2.HeaderText = "SIDType"
Me.SIDTypeDataGridViewTextBoxColumn2.Name = "SIDTypeDataGridViewTextBoxColumn2"
Me.SIDTypeDataGridViewTextBoxColumn2.ReadOnly = true
'
'StatusDataGridViewTextBoxColumn22
'
Me.StatusDataGridViewTextBoxColumn22.DataPropertyName = "Status"
Me.StatusDataGridViewTextBoxColumn22.HeaderText = "Status"
Me.StatusDataGridViewTextBoxColumn22.Name = "StatusDataGridViewTextBoxColumn22"
Me.StatusDataGridViewTextBoxColumn22.ReadOnly = true
'
'CLASSDataGridViewTextBoxColumn3
'
Me.CLASSDataGridViewTextBoxColumn3.DataPropertyName = "__CLASS"
Me.CLASSDataGridViewTextBoxColumn3.HeaderText = "__CLASS"
Me.CLASSDataGridViewTextBoxColumn3.Name = "CLASSDataGridViewTextBoxColumn3"
Me.CLASSDataGridViewTextBoxColumn3.ReadOnly = true
'
'DYNASTYDataGridViewTextBoxColumn3
'
Me.DYNASTYDataGridViewTextBoxColumn3.DataPropertyName = "__DYNASTY"
Me.DYNASTYDataGridViewTextBoxColumn3.HeaderText = "__DYNASTY"
Me.DYNASTYDataGridViewTextBoxColumn3.Name = "DYNASTYDataGridViewTextBoxColumn3"
Me.DYNASTYDataGridViewTextBoxColumn3.ReadOnly = true
'
'GENUSDataGridViewTextBoxColumn3
'
Me.GENUSDataGridViewTextBoxColumn3.DataPropertyName = "__GENUS"
Me.GENUSDataGridViewTextBoxColumn3.HeaderText = "__GENUS"
Me.GENUSDataGridViewTextBoxColumn3.Name = "GENUSDataGridViewTextBoxColumn3"
Me.GENUSDataGridViewTextBoxColumn3.ReadOnly = true
'
'NAMESPACEDataGridViewTextBoxColumn3
'
Me.NAMESPACEDataGridViewTextBoxColumn3.DataPropertyName = "__NAMESPACE"
Me.NAMESPACEDataGridViewTextBoxColumn3.HeaderText = "__NAMESPACE"
Me.NAMESPACEDataGridViewTextBoxColumn3.Name = "NAMESPACEDataGridViewTextBoxColumn3"
Me.NAMESPACEDataGridViewTextBoxColumn3.ReadOnly = true
'
'PATHDataGridViewTextBoxColumn4
'
Me.PATHDataGridViewTextBoxColumn4.DataPropertyName = "__PATH"
Me.PATHDataGridViewTextBoxColumn4.HeaderText = "__PATH"
Me.PATHDataGridViewTextBoxColumn4.Name = "PATHDataGridViewTextBoxColumn4"
Me.PATHDataGridViewTextBoxColumn4.ReadOnly = true
'
'PROPERTYCOUNTDataGridViewTextBoxColumn3
'
Me.PROPERTYCOUNTDataGridViewTextBoxColumn3.DataPropertyName = "__PROPERTY_COUNT"
Me.PROPERTYCOUNTDataGridViewTextBoxColumn3.HeaderText = "__PROPERTY_COUNT"
Me.PROPERTYCOUNTDataGridViewTextBoxColumn3.Name = "PROPERTYCOUNTDataGridViewTextBoxColumn3"
Me.PROPERTYCOUNTDataGridViewTextBoxColumn3.ReadOnly = true
'
'RELPATHDataGridViewTextBoxColumn3
'
Me.RELPATHDataGridViewTextBoxColumn3.DataPropertyName = "__RELPATH"
Me.RELPATHDataGridViewTextBoxColumn3.HeaderText = "__RELPATH"
Me.RELPATHDataGridViewTextBoxColumn3.Name = "RELPATHDataGridViewTextBoxColumn3"
Me.RELPATHDataGridViewTextBoxColumn3.ReadOnly = true
'
'SERVERDataGridViewTextBoxColumn3
'
Me.SERVERDataGridViewTextBoxColumn3.DataPropertyName = "__SERVER"
Me.SERVERDataGridViewTextBoxColumn3.HeaderText = "__SERVER"
Me.SERVERDataGridViewTextBoxColumn3.Name = "SERVERDataGridViewTextBoxColumn3"
Me.SERVERDataGridViewTextBoxColumn3.ReadOnly = true
'
'SUPERCLASSDataGridViewTextBoxColumn3
'
Me.SUPERCLASSDataGridViewTextBoxColumn3.DataPropertyName = "__SUPERCLASS"
Me.SUPERCLASSDataGridViewTextBoxColumn3.HeaderText = "__SUPERCLASS"
Me.SUPERCLASSDataGridViewTextBoxColumn3.Name = "SUPERCLASSDataGridViewTextBoxColumn3"
Me.SUPERCLASSDataGridViewTextBoxColumn3.ReadOnly = true
'
'frmComputer
'
Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.ClientSize = New System.Drawing.Size(625, 361)
Me.Controls.Add(Me.SplitContainer2)
Me.Name = "frmComputer"
Me.Text = "frmComputer"
Me.cmsComputer.ResumeLayout(false)
Me.cmsShares.ResumeLayout(false)
Me.SplitContainer1.Panel1.ResumeLayout(false)
Me.SplitContainer1.Panel2.ResumeLayout(false)
Me.SplitContainer1.ResumeLayout(false)
Me.PanelSystemAccounts.ResumeLayout(false)
CType(Me.dgvSystemAccounts,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Win32SystemAccountBindingSource,System.ComponentModel.ISupportInitialize).EndInit
Me.PanelBatteries.ResumeLayout(false)
CType(Me.dgvBatteries,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Win32BatteryBindingSource,System.ComponentModel.ISupportInitialize).EndInit
Me.PanelShares.ResumeLayout(false)
CType(Me.dgvShares,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Win32ShareBindingSource,System.ComponentModel.ISupportInitialize).EndInit
Me.PanelServices.ResumeLayout(false)
CType(Me.dgvServices,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Win32ServiceBindingSource,System.ComponentModel.ISupportInitialize).EndInit
Me.PanelGroups.ResumeLayout(false)
CType(Me.dgvGroups,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Win32GroupBindingSource,System.ComponentModel.ISupportInitialize).EndInit
Me.PanelUserAccounts.ResumeLayout(false)
CType(Me.dgvUserAccounts,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Win32UserAccountBindingSource,System.ComponentModel.ISupportInitialize).EndInit
Me.PanelVolumes.ResumeLayout(false)
CType(Me.dgvVolumes,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Win32VolumeBindingSource,System.ComponentModel.ISupportInitialize).EndInit
Me.PanelPhysicalMemoryArray.ResumeLayout(false)
CType(Me.dgvPhysicalMemoryArray,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Win32PhysicalMemoryArrayBindingSource,System.ComponentModel.ISupportInitialize).EndInit
Me.PanelOnBoardDevices.ResumeLayout(false)
CType(Me.dgvOnBoardDevices,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Win32OnBoardDeviceBindingSource,System.ComponentModel.ISupportInitialize).EndInit
Me.PanelPhysicalMemory.ResumeLayout(false)
CType(Me.dgvPhysicalMemory,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Win32PhysicalMemoryBindingSource,System.ComponentModel.ISupportInitialize).EndInit
Me.PanelPointingDevices.ResumeLayout(false)
CType(Me.dgvPointingDevices,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Win32PointingDeviceBindingSource,System.ComponentModel.ISupportInitialize).EndInit
Me.PanelDesktopMonitors.ResumeLayout(false)
CType(Me.dgvDesktopMonitors,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Win32DesktopMonitorBindingSource,System.ComponentModel.ISupportInitialize).EndInit
Me.PanelVideoControllers.ResumeLayout(false)
CType(Me.dgvVideoControllers,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Win32VideoControllerBindingSource,System.ComponentModel.ISupportInitialize).EndInit
Me.PanelComputerSystem.ResumeLayout(false)
CType(Me.dgvComputerSystem,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Win32ComputerSystemBindingSource,System.ComponentModel.ISupportInitialize).EndInit
Me.PanelKeyboard.ResumeLayout(false)
CType(Me.dgvKeyboard,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Win32KeyboardBindingSource,System.ComponentModel.ISupportInitialize).EndInit
Me.PanelPnPSignedDrivers.ResumeLayout(false)
CType(Me.dgvPnPSignedDrivers,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Win32PnPSignedDriverBindingSource,System.ComponentModel.ISupportInitialize).EndInit
Me.PanelSystemDrivers.ResumeLayout(false)
CType(Me.dgvSystemDrivers,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Win32SystemDriverBindingSource,System.ComponentModel.ISupportInitialize).EndInit
Me.PanelRefrigeration.ResumeLayout(false)
CType(Me.dgvRefrigeration,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Win32RefrigerationBindingSource,System.ComponentModel.ISupportInitialize).EndInit
Me.PanelPnPEntities.ResumeLayout(false)
CType(Me.dgvPnPEntities,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Win32PnPEntityBindingSource,System.ComponentModel.ISupportInitialize).EndInit
Me.PanelOS.ResumeLayout(false)
CType(Me.dgvOS,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Win32OperatingSystemBindingSource,System.ComponentModel.ISupportInitialize).EndInit
Me.PanelNetworkAdapterConfiguration.ResumeLayout(false)
CType(Me.dgvNetworkAdapterConfiguration,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Win32NetworkAdapterConfigurationBindingSource,System.ComponentModel.ISupportInitialize).EndInit
Me.PanelNetworkAdapter.ResumeLayout(false)
CType(Me.dgvNetworkAdapter,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Win32NetworkAdapterBindingSource,System.ComponentModel.ISupportInitialize).EndInit
Me.PanelPhysicalMedia.ResumeLayout(false)
CType(Me.dgvPhysicalMedia,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Win32PhysicalMediaBindingSource,System.ComponentModel.ISupportInitialize).EndInit
Me.PanelLogicalDisks.ResumeLayout(false)
CType(Me.dgvLogicalDisks,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Win32LogicalDiskBindingSource,System.ComponentModel.ISupportInitialize).EndInit
Me.PanelFloppyDrives.ResumeLayout(false)
CType(Me.dgvFloppyDrives,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Win32FloppyDriveBindingSource,System.ComponentModel.ISupportInitialize).EndInit
Me.PanelDiskDrives.ResumeLayout(false)
CType(Me.dgvDiskDrives,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Win32DiskDriveBindingSource,System.ComponentModel.ISupportInitialize).EndInit
Me.PanelCDROMdrives.ResumeLayout(false)
CType(Me.dgvCDROMdrives,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Win32CDROMDriveBindingSource,System.ComponentModel.ISupportInitialize).EndInit
Me.PanelProcessors.ResumeLayout(false)
CType(Me.dgvProcessors,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Win32ProcessorBindingSource,System.ComponentModel.ISupportInitialize).EndInit
Me.SplitContainer2.Panel1.ResumeLayout(false)
Me.SplitContainer2.Panel2.ResumeLayout(false)
Me.SplitContainer2.ResumeLayout(false)
CType(Me.dgvProperties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Win32PhysicalMemoryLocationBindingSource,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Win32VolumesBindingSource,System.ComponentModel.ISupportInitialize).EndInit
Me.ResumeLayout(false)

End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents PanelEmpty As System.Windows.Forms.Panel
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents PanelKeyboard As System.Windows.Forms.Panel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PanelProcessors As System.Windows.Forms.Panel
    Friend WithEvents dgvProcessors As System.Windows.Forms.DataGridView
    Friend WithEvents Win32ProcessorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Win32KeyboardBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dgvKeyboard As System.Windows.Forms.DataGridView
    Friend WithEvents PanelBatteries As System.Windows.Forms.Panel
    Friend WithEvents dgvBatteries As System.Windows.Forms.DataGridView
    Friend WithEvents Win32BatteryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PanelRefrigeration As System.Windows.Forms.Panel
    Friend WithEvents dgvRefrigeration As System.Windows.Forms.DataGridView
    Friend WithEvents Win32RefrigerationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PanelCDROMdrives As System.Windows.Forms.Panel
    Friend WithEvents dgvCDROMdrives As System.Windows.Forms.DataGridView
    Friend WithEvents Win32CDROMDriveBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PanelDiskDrives As System.Windows.Forms.Panel
    Friend WithEvents dgvDiskDrives As System.Windows.Forms.DataGridView
    Friend WithEvents Win32DiskDriveBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PanelFloppyDrives As System.Windows.Forms.Panel
    Friend WithEvents dgvFloppyDrives As System.Windows.Forms.DataGridView
    Friend WithEvents Win32FloppyDriveBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PanelLogicalDisks As System.Windows.Forms.Panel
    Friend WithEvents dgvLogicalDisks As System.Windows.Forms.DataGridView
    Friend WithEvents Win32LogicalDiskBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PanelPhysicalMedia As System.Windows.Forms.Panel
    Friend WithEvents dgvPhysicalMedia As System.Windows.Forms.DataGridView
    Friend WithEvents Win32PhysicalMediaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PanelNetworkAdapter As System.Windows.Forms.Panel
    Friend WithEvents dgvNetworkAdapter As System.Windows.Forms.DataGridView
    Friend WithEvents Win32NetworkAdapterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PanelNetworkAdapterConfiguration As System.Windows.Forms.Panel
    Friend WithEvents dgvNetworkAdapterConfiguration As System.Windows.Forms.DataGridView
    Friend WithEvents Win32NetworkAdapterConfigurationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PanelOS As System.Windows.Forms.Panel
    Friend WithEvents dgvOS As System.Windows.Forms.DataGridView
    Friend WithEvents Win32OperatingSystemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PanelShares As System.Windows.Forms.Panel
    Friend WithEvents dgvShares As System.Windows.Forms.DataGridView
    Friend WithEvents PanelPnPEntities As System.Windows.Forms.Panel
    Friend WithEvents dgvPnPEntities As System.Windows.Forms.DataGridView
    Friend WithEvents Win32PnPEntityBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Win32ShareBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AvailabilityDataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CaptionDataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClassGuidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConfigManagerErrorDataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConfigManagerErrorCodeDataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConfigManagerUserConfigDataGridViewCheckBoxColumn6 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CreationClassNameDataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeviceIDDataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErrorClearedDataGridViewCheckBoxColumn6 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ErrorDescriptionDataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InstallDateDataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastErrorCodeDataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ManufacturerDataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNPDeviceIDDataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PowerManagementSupportedDataGridViewCheckBoxColumn6 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ServiceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusInfoDataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SystemNameDataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SystemCreationClassNameDataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BootDeviceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BuildNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BuildTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CaptionDataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodeSetDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CountryCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreationClassNameDataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CSCreationClassNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CSDVersionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CSNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrentTimeZoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataExecutionPrevention32BitApplicationsDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataExecutionPreventionAvailableDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataExecutionPreventionDriversDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataExecutionPreventionSupportPolicyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DebugDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DistributedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents EncryptionLevelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ForegroundApplicationBoostDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FreePhysicalMemoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FreeSpaceInPagingFilesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FreeVirtualMemoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InstallDateDataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LargeSystemCacheDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastBootUpTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LocalDateTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LocaleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ManufacturerDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaxNumberOfProcessesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaxProcessMemorySizeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumberOfLicensedUsersDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumberOfProcessesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumberOfUsersDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OperatingSystemSKUDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrganizationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OSLanguageDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OSArchitectureDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OSProductSuiteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OSTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OtherTypeDescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PAEEnabledDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PlusProductIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlusVersionNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrimaryDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents QuantumLengthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantumTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegisteredUserDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SerialNumberDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicePackMajorVersionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicePackMinorVersionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SizeStoredInPagingFilesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SuiteMaskDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SystemDeviceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SystemDirectoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SystemDriveDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalSwapSpaceSizeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalVirtualMemorySizeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalVisibleMemorySizeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VersionDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WindowsDirectoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArpAlwaysSourceRouteDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ArpUseEtherSNAPDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CaptionDataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatabasePathDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeadGWDetectEnabledDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DefaultTOSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DefaultTTLDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DHCPEnabledDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DHCPLeaseExpiresDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DHCPLeaseObtainedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DHCPServerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DNSDomainDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DNSEnabledForWINSResolutionDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DNSHostNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DomainDNSRegistrationEnabledDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ForwardBufferMemoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FullDNSRegistrationEnabledDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IGMPLevelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IndexDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InterfaceIndexDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IPConnectionMetricDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IPEnabledDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IPFilterSecurityEnabledDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IPUseZeroBroadcastDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents KeepAliveIntervalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KeepAliveTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MACAddressDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MTUDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumForwardPacketsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PMTUBHDetectEnabledDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PMTUDiscoveryEnabledDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ServiceNameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SettingIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TcpMaxConnectRetransmissionsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TcpMaxDataRetransmissionsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TcpipNetbiosOptionsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TcpNumConnectionsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TcpUseRFC1122UrgentPointerDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents TcpWindowSizeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WINSScopeIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WINSHostLookupFileDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WINSEnableLMHostsLookupDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents WINSPrimaryServerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WINSSecondaryServerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdapterTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdapterTypeIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AutoSenseDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents AvailabilityDataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CaptionDataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConfigManagerErrorDataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConfigManagerErrorCodeDataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreationClassNameDataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConfigManagerUserConfigDataGridViewCheckBoxColumn5 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeviceIDDataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErrorClearedDataGridViewCheckBoxColumn5 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ErrorDescriptionDataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GUIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IndexDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InstallDateDataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InstalledDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents InterfaceIndexDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastErrorCodeDataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MACAddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ManufacturerDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaxNumberControlledDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaxSpeedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NetConnectionIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NetConnectionStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NetEnabledDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PhysicalAdapterDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PNPDeviceIDDataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PowerManagementSupportedDataGridViewCheckBoxColumn5 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PermanentAddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiceNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SpeedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusInfoDataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SystemCreationClassNameDataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SystemNameDataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeOfLastResetDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CapacityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CaptionDataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CleanerMediaDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HotSwappableDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents InstallDateDataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MediaDescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MediaTypeDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RemovableDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ReplaceableDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WriteProtectOnDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn6 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn9 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn51 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn61 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn63 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn11 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn64 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn65 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn66 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn67 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn4 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn5 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn7 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn8 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn53 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn54 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn56 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn57 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AvailabilityDataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BytesPerSectorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CaptionDataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompressionMethodDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConfigManagerErrorDataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConfigManagerErrorCodeDataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConfigManagerUserConfigDataGridViewCheckBoxColumn4 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CreationClassNameDataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DefaultBlockSizeDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeviceIDDataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErrorClearedDataGridViewCheckBoxColumn4 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ErrorDescriptionDataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErrorMethodologyDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirmwareRevisionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IndexDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InterfaceTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InstallDateDataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastErrorCodeDataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ManufacturerDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaxBlockSizeDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaxMediaSizeDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MediaLoadedDataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ModelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MediaTypeDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MinBlockSizeDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NeedsCleaningDataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents NumberOfMediaSupportedDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PartitionsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNPDeviceIDDataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PowerManagementSupportedDataGridViewCheckBoxColumn4 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SCSIBusDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SCSILogicalUnitDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SCSIPortDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SCSITargetIdDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SectorsPerTrackDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SerialNumberDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SizeDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusInfoDataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SystemCreationClassNameDataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SignatureDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SystemNameDataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalHeadsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalCylindersDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalSectorsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalTracksDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TracksPerCylinderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AvailabilityDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CaptionDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompressionMethodDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConfigManagerErrorDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConfigManagerErrorCodeDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConfigManagerUserConfigDataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CreationClassNameDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DefaultBlockSizeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeviceIDDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DriveDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DriveIntegrityDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ErrorClearedDataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ErrorDescriptionDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErrorMethodologyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FileSystemFlagsExDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InstallDateDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastErrorCodeDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaxBlockSizeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaximumComponentLengthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaxMediaSizeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MediaLoadedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MediaTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MfrAssignedRevisionLevelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MinBlockSizeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NeedsCleaningDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents NumberOfMediaSupportedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNPDeviceIDDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PowerManagementSupportedDataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RevisionLevelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SCSIBusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SCSILogicalUnitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SCSIPortDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SCSITargetIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SerialNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SizeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusInfoDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SystemCreationClassNameDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SystemNameDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransferRateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VolumeNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VolumeSerialNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActiveCoolingDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents AvailabilityDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CaptionDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConfigManagerErrorDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConfigManagerUserConfigDataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CreationClassNameDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConfigManagerErrorCodeDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeviceIDDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErrorDescriptionDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InstallDateDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastErrorCodeDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErrorClearedDataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNPDeviceIDDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PowerManagementSupportedDataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusInfoDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SystemCreationClassNameDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SystemNameDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BatteryStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChemistryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DesignCapacityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DesignVoltageDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstimatedChargeRemainingDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstimatedRunTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExpectedLifeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FullChargeCapacityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaxRechargeTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SmartBatteryVersionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeOnBatteryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeToFullChargeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressWidthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArchitectureDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AvailabilityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CaptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConfigManagerErrorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConfigManagerErrorCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConfigManagerUserConfigDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CpuStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreationClassNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrentClockSpeedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrentVoltageDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataWidthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeviceIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErrorClearedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ErrorDescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExtClockDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FamilyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InstallDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents L2CacheSizeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents L2CacheSpeedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents L3CacheSizeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents L3CacheSpeedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastErrorCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LevelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoadPercentageDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ManufacturerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaxClockSpeedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumberOfCoresDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumberOfLogicalProcessorsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OtherFamilyDescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNPDeviceIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PowerManagementSupportedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ProcessorIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProcessorTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RevisionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusInfoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SocketDesignationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SteppingDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SystemCreationClassNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SystemNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UniqueIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UpgradeMethodDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VersionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VoltageCapsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmsShares As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewFileShareToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsComputer As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ShutDownToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RebootToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomShutDownToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PanelSystemDrivers As System.Windows.Forms.Panel
    Friend WithEvents dgvSystemDrivers As System.Windows.Forms.DataGridView
    Friend WithEvents Win32SystemDriverBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AcceptPauseDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents AcceptStopDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CaptionDataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreationClassNameDataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DesktopInteractDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DisplayNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErrorControlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExitCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InstallDateDataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PathNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiceSpecificExitCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiceTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StartedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StartModeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StartNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SystemCreationClassNameDataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SystemNameDataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TagIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PanelPnPSignedDrivers As System.Windows.Forms.Panel
    Friend WithEvents dgvPnPSignedDrivers As System.Windows.Forms.DataGridView
    Friend WithEvents ProviderNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Win32PnPSignedDriverBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CaptionDataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClassGuidDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompatIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreationClassNameDataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeviceIDDataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DevLoaderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeviceNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeviceClassDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DriverDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DriverNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DriverProviderName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DriverVersionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FriendlyNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HardWareIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InfNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InstallDateDataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsSignedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents LocationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ManufacturerDataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PDODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SignerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StartedDataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents StartModeDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SystemCreationClassNameDataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SystemNameDataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Password As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PanelComputerSystem As System.Windows.Forms.Panel
    Friend WithEvents dgvComputerSystem As System.Windows.Forms.DataGridView
    Friend WithEvents Win32ComputerSystemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PanelVideoControllers As System.Windows.Forms.Panel
    Friend WithEvents dgvVideoControllers As System.Windows.Forms.DataGridView
    Friend WithEvents Win32VideoControllerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AdapterCompatibilityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdapterDACTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdapterRAMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AvailabilityDataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConfigManagerErrorCodeDataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CaptionDataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConfigManagerUserConfigDataGridViewCheckBoxColumn7 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ColorTableEntriesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConfigManagerErrorDataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreationClassNameDataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrentBitsPerPixelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrentHorizontalResolutionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrentNumberOfColorsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrentVerticalResolutionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrentNumberOfColumnsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrentNumberOfRowsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrentRefreshRateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrentScanModeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeviceIDDataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeviceSpecificPensDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DitherTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DriverDateDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DriverVersionDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErrorClearedDataGridViewCheckBoxColumn7 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ErrorDescriptionDataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ICMIntentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ICMMethodDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InfFileNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InfSectionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InstallDateDataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InstalledDisplayDriversDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastErrorCodeDataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaxMemorySupportedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaxNumberControlledDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaxRefreshRateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MinRefreshRateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonochromeDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumberOfColorPlanesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumberOfVideoPagesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNPDeviceIDDataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PowerManagementSupportedDataGridViewCheckBoxColumn8 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ProtocolSupportedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReservedSystemPaletteEntriesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SpecificationVersionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusInfoDataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SystemCreationClassNameDataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SystemNameDataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SystemPaletteEntriesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VideoModeDescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VideoProcessorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VideoMemoryTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AutomaticManagedPagefileDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents AutomaticResetCapabilityDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents AutomaticResetBootOptionDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents BootROMSupportedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents BootupStateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CaptionDataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChassisBootupStateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreationClassNameDataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrentTimeZoneDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DNSHostNameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DomainRoleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DaylightInEffectDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DomainDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EnableDaylightSavingsTimeDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents FrontPanelResetStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InfraredSupportedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents InitialLoadInfoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InstallDateDataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KeyboardPasswordStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastLoadInfoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameFormatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NetworkServerModeEnabledDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents NumberOfLogicalProcessorsDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumberOfProcessorsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OEMLogoBitmapDataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents PartOfDomainDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PauseAfterResetDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PCSystemTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PowerManagementSupportedDataGridViewCheckBoxColumn7 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PowerOnPasswordStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PowerStateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PowerSupplyStateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrimaryOwnerContactDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrimaryOwnerNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResetCapabilityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResetCountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResetLimitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SystemStartupDelayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SystemStartupSettingDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SystemTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ThermalStateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalPhysicalMemoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WakeUpTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WorkgroupDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PanelDesktopMonitors As System.Windows.Forms.Panel
    Friend WithEvents dgvDesktopMonitors As System.Windows.Forms.DataGridView
    Friend WithEvents Win32DesktopMonitorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AvailabilityDataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BandwidthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CaptionDataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConfigManagerErrorDataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConfigManagerErrorCodeDataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConfigManagerUserConfigDataGridViewCheckBoxColumn8 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CreationClassNameDataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeviceIDDataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DisplayTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErrorClearedDataGridViewCheckBoxColumn8 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ErrorDescriptionDataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InstallDateDataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsLockedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents LastErrorCodeDataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonitorManufacturerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonitorTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PixelsPerXLogicalInchDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PixelsPerYLogicalInchDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNPDeviceIDDataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PowerManagementSupportedDataGridViewCheckBoxColumn9 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ScreenHeightDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ScreenWidthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusInfoDataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SystemCreationClassNameDataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SystemNameDataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PanelPointingDevices As System.Windows.Forms.Panel
    Friend WithEvents dgvPointingDevices As System.Windows.Forms.DataGridView
    Friend WithEvents LastErrorCodeDataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HardwareTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SystemCreationClassNameDataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeviceInterfaceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuadSpeedThresholdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErrorDescriptionDataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InstallDateDataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResolutionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConfigManagerErrorCodeDataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DoubleSpeedThresholdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ManufacturerDataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumberOfButtonsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HandednessDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PointingTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusInfoDataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SystemNameDataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PowerManagementSupportedDataGridViewCheckBoxColumn10 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CreationClassNameDataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsLockedDataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ConfigManagerUserConfigDataGridViewCheckBoxColumn9 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DeviceIDDataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNPDeviceIDDataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CaptionDataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InfSectionDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SynchDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InfFileNameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErrorClearedDataGridViewCheckBoxColumn9 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ConfigManagerErrorDataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ManagementObjectDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AvailabilityDataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SampleRateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Win32PointingDeviceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PanelServices As System.Windows.Forms.Panel
    Friend WithEvents dgvServices As System.Windows.Forms.DataGridView
    Friend WithEvents Win32ServiceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PanelPhysicalMemory As System.Windows.Forms.Panel
    Friend WithEvents dgvPhysicalMemory As System.Windows.Forms.DataGridView
    Friend WithEvents BankLabelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CapacityDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CaptionDataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreationClassNameDataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataWidthDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeviceLocatorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FormFactorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HotSwappableDataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents InstallDateDataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InterleaveDataDepthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InterleavePositionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemoryTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PositionInRowDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RemovableDataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ReplaceableDataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalWidthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeDetailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Win32PhysicalMemoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PanelOnBoardDevices As System.Windows.Forms.Panel
    Friend WithEvents dgvOnBoardDevices As System.Windows.Forms.DataGridView
    Friend WithEvents CaptionDataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreationClassNameDataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeviceTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EnabledDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents HotSwappableDataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents InstallDateDataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RemovableDataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ReplaceableDataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Win32OnBoardDeviceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgvProperties As System.Windows.Forms.DataGridView
    Friend WithEvents PanelPhysicalMemoryArray As System.Windows.Forms.Panel
    Friend WithEvents dgvPhysicalMemoryArray As System.Windows.Forms.DataGridView
    Friend WithEvents CaptionDataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreationClassNameDataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HeightDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HotSwappableDataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents InstallDateDataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LocationDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaxCapacityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemoryDevicesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemoryErrorCorrectionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RemovableDataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ReplaceableDataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WeightDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WidthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Win32PhysicalMemoryArrayBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Win32PhysicalMemoryLocationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PanelVolumes As System.Windows.Forms.Panel
    Friend WithEvents dgvVolumes As System.Windows.Forms.DataGridView
    Friend WithEvents Win32VolumesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Win32VolumeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnShareDelete As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents AccessMaskDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AllowMaximumDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Caption As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaximumAllowedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShareName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PathDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DefragAnalysis As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents AccessDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AutomountDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents AvailabilityDataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BlockSizeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BootVolumeDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CapacityDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CaptionDataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompressedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ConfigManagerErrorDataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConfigManagerErrorCodeDataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConfigManagerUserConfigDataGridViewCheckBoxColumn10 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CreationClassNameDataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DefragAnalysisResultDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DefragRecommendedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DefragResultDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeviceID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DirtyBitSetDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DriveLetterDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DriveTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErrorClearedDataGridViewCheckBoxColumn10 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ErrorDescriptionDataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErrorMethodologyDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FileSystemDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FreeSpaceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IndexingEnabledDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents InstallDateDataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LabelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastErrorCodeDataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaximumFileNameLengthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MediaTypeDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumberOfBlocksDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PageFilePresentDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PNPDeviceIDDataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PowerManagementSupportedDataGridViewCheckBoxColumn11 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PurposeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuotasEnabledDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents QuotasIncompleteDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents QuotasRebuildingDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SerialNumberDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusInfoDataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SupportsDiskQuotasDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SupportsFileBasedCompressionDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SystemCreationClassNameDataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SystemVolumeDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SystemNameDataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PanelUserAccounts As System.Windows.Forms.Panel
    Friend WithEvents dgvUserAccounts As System.Windows.Forms.DataGridView
    Friend WithEvents AccountTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CaptionDataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DisabledDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DomainDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FullNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InstallDateDataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LocalAccountDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents LockoutDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PasswordChangeableDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PasswordExpiresDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PasswordRequiredDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SIDTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLASSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DYNASTYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GENUSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NAMESPACEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PATHDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROPERTYCOUNTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RELPATHDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SERVERDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SUPERCLASSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Win32UserAccountBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PanelGroups As System.Windows.Forms.Panel
    Friend WithEvents dgvGroups As System.Windows.Forms.DataGridView
    Friend WithEvents CaptionDataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DomainDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InstallDateDataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LocalAccountDataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SIDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SIDTypeDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLASSDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DYNASTYDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GENUSDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NAMESPACEDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PATHDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROPERTYCOUNTDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RELPATHDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SERVERDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SUPERCLASSDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Win32GroupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnStartStop As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents AcceptPauseDataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents AcceptStopDataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CaptionDataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckPointDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreationClassNameDataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DesktopInteractDataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DisplayNameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErrorControlDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExitCodeDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InstallDateDataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiceName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PathNameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProcessIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SecurityDescriptorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiceSpecificExitCodeDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiceTypeDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StartedDataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents StartModeDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StartNameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SystemCreationClassNameDataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SystemNameDataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TagIdDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WaitHintDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AvailabilityDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CaptionDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConfigManagerErrorCodeDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConfigManagerErrorDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConfigManagerUserConfigDataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CreationClassNameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn52 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeviceIDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErrorClearedDataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ErrorDescriptionDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn58 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn55 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn59 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn60 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InstallDateDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastErrorCodeDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn62 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNPDeviceIDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PowerManagementSupportedDataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn68 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusInfoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SystemCreationClassNameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SystemNameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn69 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn70 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLASSDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DYNASTYDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GENUSDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NAMESPACEDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PATHDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROPERTYCOUNTDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RELPATHDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SERVERDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SUPERCLASSDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PanelSystemAccounts As System.Windows.Forms.Panel
    Friend WithEvents dgvSystemAccounts As System.Windows.Forms.DataGridView
    Friend WithEvents Win32SystemAccountBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CaptionDataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DomainDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InstallDateDataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LocalAccountDataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SIDDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SIDTypeDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLASSDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DYNASTYDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GENUSDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NAMESPACEDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PATHDataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROPERTYCOUNTDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RELPATHDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SERVERDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SUPERCLASSDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
