Public Class frmComputer

    Private _Computer As WMIwrapper.Computer
    Friend ReadOnly Property Computer() As WMIwrapper.Computer
        Get
            Return _Computer
        End Get
    End Property

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <remarks>Applies to local computer.</remarks>
    Public Sub New()
        Me.New(My.Computer.Name)

        ' Call designer method to initialize components.
        Me.InitializeComponent()

    End Sub

    ''' <summary>
    ''' Computer.
    ''' </summary>
    ''' <param name="ComputerName">The host computer to connect to.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal ComputerName As String)

        _Computer = New WMIwrapper.Computer(ComputerName)

        ' Call designer method to initialize components.
        Me.InitializeComponent()

        ' Show the computer's name.
        Me.TreeView1.Nodes(0).Text = ComputerName
        Me.Text = ComputerName

    End Sub

    ''' <summary>
    ''' Run when the form is loaded.
    ''' </summary>
    ''' <param name="sender">Sender object.</param>
    ''' <param name="e">Arguments.</param>
    ''' <remarks></remarks>
    Private Sub frmComputer_Load(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles Me.Load

        Me.PanelEmpty.Visible = True

    End Sub

    ''' <summary>
    ''' Run when a tree node is selected.
    ''' </summary>
    ''' <param name="sender">Sender object.</param>
    ''' <param name="e">Arguments.</param>
    ''' <remarks>Shows the appropriate panel.</remarks>
    Private Sub TreeView1_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) _
          Handles TreeView1.AfterSelect

        Me.Cursor = Cursors.WaitCursor
        Try

            Dim WMIobject As WMIwrapper.WMIobject = Nothing

            Select Case e.Node.Name
                Case "Accounts", "Computer", "Disks", "Hardware", "Memory", "Network", "PnP", "System", "Video"
                    Me.PanelEmpty.BringToFront()
                    Me.dgvProperties.DataSource = Nothing
                Case "Batteries"
                    If _Computer.Batteries Is Nothing Then
                        _Computer.GetLogicalElements(WMIwrapper.Computer.LogicalElements.Batteries)
                    End If
                    If _Computer.Batteries IsNot Nothing Then
                        Me.Win32BatteryBindingSource.Clear()
                        For Each Win32_Battery As WMIwrapper.Win32_Battery In _Computer.Batteries
                            Me.Win32BatteryBindingSource.Add(Win32_Battery)
                            WMIobject = Win32_Battery
                        Next
                    End If
                    Me.PanelBatteries.BringToFront()
                Case "CDROMdrives"
                    If _Computer.CDROMDrives Is Nothing Then
                        _Computer.GetLogicalElements(WMIwrapper.Computer.LogicalElements.CDROMDrives)
                    End If
                    If _Computer.CDROMDrives IsNot Nothing Then
                        Me.Win32CDROMDriveBindingSource.Clear()
                        For Each Win32_CDROMdrive As WMIwrapper.Win32_CDROMDrive In _Computer.CDROMDrives
                            Me.Win32CDROMDriveBindingSource.Add(Win32_CDROMdrive)
                            WMIobject = Win32_CDROMdrive
                        Next
                    End If
                    Me.PanelCDROMdrives.BringToFront()
                Case "ComputerSystem"
                    If _Computer.ComputerSystem Is Nothing Then
                        _Computer.GetComputerSystem()
                    End If
                    If _Computer.ComputerSystem IsNot Nothing Then
                        Me.Win32ComputerSystemBindingSource.Clear()
                        Me.Win32ComputerSystemBindingSource.Add(_Computer.ComputerSystem)
                        WMIobject = _Computer.ComputerSystem
                    End If
                    Me.PanelComputerSystem.BringToFront()
                Case "DesktopMonitors"
                    If _Computer.DesktopMonitors Is Nothing Then
                        _Computer.GetLogicalElements(WMIwrapper.Computer.LogicalElements.DesktopMonitors)
                    End If
                    If _Computer.DesktopMonitors IsNot Nothing Then
                        Me.Win32DesktopMonitorBindingSource.Clear()
                        For Each Win32_DesktopMonitor As WMIwrapper.Win32_DesktopMonitor In _Computer.DesktopMonitors
                            Me.Win32DesktopMonitorBindingSource.Add(Win32_DesktopMonitor)
                            WMIobject = Win32_DesktopMonitor
                        Next
                    End If
                    Me.PanelDesktopMonitors.BringToFront()
                Case "DiskDrives"
                    If _Computer.DiskDrivePhysicalMedias Is Nothing Then
                        _Computer.GetLogicalElements(WMIwrapper.Computer.LogicalElements.DiskDrivePhysicalMedias)
                    End If
                    If _Computer.DiskDrivePhysicalMedias IsNot Nothing Then
                        Me.Win32DiskDriveBindingSource.Clear()
                        For Each Win32_DiskDrivePhysicalMedia As WMIwrapper.Win32_DiskDrivePhysicalMedia In _Computer.DiskDrivePhysicalMedias
                            Me.Win32DiskDriveBindingSource.Add(Win32_DiskDrivePhysicalMedia.Setting)
                            WMIobject = Win32_DiskDrivePhysicalMedia.Setting
                        Next
                    End If
                    Me.PanelDiskDrives.BringToFront()
                Case "FloppyDrives"
                    If _Computer.FloppyDrives Is Nothing Then
                        _Computer.GetLogicalElements(WMIwrapper.Computer.LogicalElements.FloppyDrives)
                    End If
                    If _Computer.FloppyDrives IsNot Nothing Then
                        Me.Win32ProcessorBindingSource.Clear()
                        For Each Win32_FloppyDrive As WMIwrapper.Win32_FloppyDrive In _Computer.FloppyDrives
                            Me.Win32ProcessorBindingSource.Add(Win32_FloppyDrive)
                            WMIobject = Win32_FloppyDrive
                        Next
                    End If
                    Me.PanelFloppyDrives.BringToFront()
                Case "Groups"
                    If _Computer.Groups Is Nothing Then
                        _Computer.GetLogicalElements(WMIwrapper.Computer.LogicalElements.Groups)
                    End If
                    If _Computer.Groups IsNot Nothing Then
                        Me.Win32GroupBindingSource.Clear()
                        For Each Win32_Group As WMIwrapper.Win32_Group In _Computer.Groups
                            Me.Win32GroupBindingSource.Add(Win32_Group)
                            WMIobject = Win32_Group
                        Next
                    End If
                    Me.PanelGroups.BringToFront()
                Case "Keyboard"
                    If _Computer.Keyboard Is Nothing Then
                        _Computer.GetLogicalElements(WMIwrapper.Computer.LogicalElements.Keyboard)
                    End If
                    If _Computer.Keyboard IsNot Nothing Then
                        Me.Win32KeyboardBindingSource.Clear()
                        Me.Win32KeyboardBindingSource.Add(_Computer.Keyboard)
                        WMIobject = _Computer.Keyboard
                    End If
                    Me.PanelKeyboard.BringToFront()
                Case "LogicalDisks"
                    If _Computer.LogicalDisks Is Nothing Then
                        _Computer.GetLogicalElements(WMIwrapper.Computer.LogicalElements.LogicalDisks)
                    End If
                    If _Computer.LogicalDisks IsNot Nothing Then
                        Me.Win32LogicalDiskBindingSource.Clear()
                        For Each Win32_LogicalDisk As WMIwrapper.Win32_LogicalDisk In _Computer.LogicalDisks
                            Me.Win32LogicalDiskBindingSource.Add(Win32_LogicalDisk)
                            WMIobject = Win32_LogicalDisk
                        Next
                    End If
                    Me.PanelLogicalDisks.BringToFront()
                Case "NetworkAdapters"
                    If _Computer.NetworkAdapterSettings Is Nothing Then
                        _Computer.GetLogicalElements(WMIwrapper.Computer.LogicalElements.NetworkAdapterSettings)
                    End If
                    If _Computer.NetworkAdapterSettings IsNot Nothing Then
                        Me.Win32NetworkAdapterBindingSource.Clear()
                        For Each Win32_NetworkAdapterSetting As WMIwrapper.Win32_NetworkAdapterSetting In _Computer.NetworkAdapterSettings
                            Me.Win32NetworkAdapterBindingSource.Add(Win32_NetworkAdapterSetting.Element)
                            WMIobject = Win32_NetworkAdapterSetting.Element
                        Next
                    End If
                    Me.PanelNetworkAdapter.BringToFront()
                Case "NetworkAdaptersConfiguration"
                    If _Computer.NetworkAdapterSettings Is Nothing Then
                        _Computer.GetLogicalElements(WMIwrapper.Computer.LogicalElements.NetworkAdapterSettings)
                    End If
                    If _Computer.NetworkAdapterSettings IsNot Nothing Then
                        Me.Win32NetworkAdapterConfigurationBindingSource.Clear()
                        For Each Win32_NetworkAdapterSetting As WMIwrapper.Win32_NetworkAdapterSetting In _Computer.NetworkAdapterSettings
                            Me.Win32NetworkAdapterConfigurationBindingSource.Add(Win32_NetworkAdapterSetting.Setting)
                            WMIobject = Win32_NetworkAdapterSetting.Setting
                        Next
                    End If
                    Me.PanelNetworkAdapterConfiguration.BringToFront()
                Case "OnBoardDevices"
                    If _Computer.OnBoardDevices Is Nothing Then
                        _Computer.GetLogicalElements(WMIwrapper.Computer.LogicalElements.OnBoardDevices)
                    End If
                    If _Computer.OnBoardDevices IsNot Nothing Then
                        Me.Win32OnBoardDeviceBindingSource.Clear()
                        For Each Win32_OnBoardDevice As WMIwrapper.Win32_OnBoardDevice In _Computer.OnBoardDevices
                            Me.Win32OnBoardDeviceBindingSource.Add(Win32_OnBoardDevice)
                            WMIobject = Win32_OnBoardDevice
                        Next
                    End If
                    Me.PanelOnBoardDevices.BringToFront()
                Case "OperatingSystem"
                    If _Computer.OperatingSystem Is Nothing Then
                        _Computer.GetOperatingSystem()
                    End If
                    If _Computer.OperatingSystem IsNot Nothing Then
                        Me.Win32OperatingSystemBindingSource.Clear()
                        Me.Win32OperatingSystemBindingSource.Add(_Computer.OperatingSystem)
                        WMIobject = _Computer.OperatingSystem
                    End If
                    Me.PanelOS.BringToFront()
                Case "PhysicalMedia"
                    If _Computer.DiskDrivePhysicalMedias Is Nothing Then
                        _Computer.GetLogicalElements(WMIwrapper.Computer.LogicalElements.DiskDrivePhysicalMedias)
                    End If
                    If _Computer.DiskDrivePhysicalMedias IsNot Nothing Then
                        Me.Win32PhysicalMediaBindingSource.Clear()
                        For Each Win32_DiskDrivePhysicalMedia As WMIwrapper.Win32_DiskDrivePhysicalMedia In _Computer.DiskDrivePhysicalMedias
                            Me.Win32PhysicalMediaBindingSource.Add(Win32_DiskDrivePhysicalMedia.Element)
                            WMIobject = Win32_DiskDrivePhysicalMedia.Element
                        Next
                    End If
                    Me.PanelPhysicalMedia.BringToFront()
                Case "PhysicalMemory"
                    If _Computer.PhysicalMemories Is Nothing Then
                        _Computer.GetLogicalElements(WMIwrapper.Computer.LogicalElements.PhysicalMemories)
                    End If
                    If _Computer.PhysicalMemories IsNot Nothing Then
                        Me.Win32PhysicalMemoryBindingSource.Clear()
                        For Each Win32_PhysicalMemory As WMIwrapper.Win32_PhysicalMemory In _Computer.PhysicalMemories
                            Me.Win32PhysicalMemoryBindingSource.Add(Win32_PhysicalMemory)
                            WMIobject = Win32_PhysicalMemory
                        Next
                    End If
                    Me.PanelPhysicalMemory.BringToFront()
                Case "PhysicalMemoryArray"
                    If _Computer.PhysicalMemoryArrays Is Nothing Then
                        _Computer.GetLogicalElements(WMIwrapper.Computer.LogicalElements.PhysicalMemoryArrays)
                    End If
                    If _Computer.PhysicalMemoryArrays IsNot Nothing Then
                        Me.Win32PhysicalMemoryArrayBindingSource.Clear()
                        For Each Win32_PhysicalMemoryArray As WMIwrapper.Win32_PhysicalMemoryArray In _Computer.PhysicalMemoryArrays
                            Me.Win32PhysicalMemoryArrayBindingSource.Add(Win32_PhysicalMemoryArray)
                            WMIobject = Win32_PhysicalMemoryArray
                        Next
                    End If
                    Me.PanelPhysicalMemoryArray.BringToFront()
                Case "PnPEntities"
                    If _Computer.PnPDevices Is Nothing Then
                        _Computer.GetLogicalElements(WMIwrapper.Computer.LogicalElements.PnPDevices)
                    End If
                    If _Computer.PnPDevices IsNot Nothing Then
                        Me.Win32PnPEntityBindingSource.Clear()
                        For Each Win32_PnPDevice As WMIwrapper.Win32_PnPDevice In _Computer.PnPDevices
                            Me.Win32PnPEntityBindingSource.Add(Win32_PnPDevice.SystemElement)
                            WMIobject = Win32_PnPDevice.SystemElement
                        Next
                    End If
                    Me.PanelPnPEntities.BringToFront()
                Case "PnPSignedDrivers"
                    If _Computer.PnPSignedDrivers Is Nothing Then
                        _Computer.GetLogicalElements(WMIwrapper.Computer.LogicalElements.PnPSignedDrivers)
                    End If
                    If _Computer.PnPSignedDrivers IsNot Nothing Then
                        Me.Win32PnPSignedDriverBindingSource.Clear()
                        For Each Win32_PnPSignedDriver As WMIwrapper.Win32_PnPSignedDriver In _Computer.PnPSignedDrivers
                            Me.Win32PnPSignedDriverBindingSource.Add(Win32_PnPSignedDriver)
                            WMIobject = Win32_PnPSignedDriver
                        Next
                    End If
                    Me.PanelPnPSignedDrivers.BringToFront()
                Case "PointingDevices"
                    If _Computer.PointingDevices Is Nothing Then
                        _Computer.GetLogicalElements(WMIwrapper.Computer.LogicalElements.PointingDevices)
                    End If
                    If _Computer.PointingDevices IsNot Nothing Then
                        Me.Win32PointingDeviceBindingSource.Clear()
                        For Each Win32_PointingDevice As WMIwrapper.Win32_PointingDevice In _Computer.PointingDevices
                            Me.Win32PointingDeviceBindingSource.Add(Win32_PointingDevice)
                            WMIobject = Win32_PointingDevice
                        Next
                    End If
                    Me.PanelPointingDevices.BringToFront()
                Case "Processors"
                    If _Computer.Processors Is Nothing Then
                        _Computer.GetLogicalElements(WMIwrapper.Computer.LogicalElements.Processors)
                    End If
                    If _Computer.Processors IsNot Nothing Then
                        Me.Win32ProcessorBindingSource.Clear()
                        For Each Win32_Processor As WMIwrapper.Win32_Processor In _Computer.Processors
                            Me.Win32ProcessorBindingSource.Add(Win32_Processor)
                            WMIobject = Win32_Processor
                        Next
                    End If
                    Me.PanelProcessors.BringToFront()
                Case "Refrigeration"
                    If _Computer.Refrigerations Is Nothing Then
                        _Computer.GetLogicalElements(WMIwrapper.Computer.LogicalElements.Refrigerations)
                    End If
                    If _Computer.Refrigerations IsNot Nothing Then
                        Me.Win32RefrigerationBindingSource.Clear()
                        For Each Win32_Refrigeration As WMIwrapper.Win32_Refrigeration In _Computer.Refrigerations
                            Me.Win32RefrigerationBindingSource.Add(Win32_Refrigeration)
                            WMIobject = Win32_Refrigeration
                        Next
                    End If
                    Me.PanelRefrigeration.BringToFront()
                Case "Services"
                    If _Computer.Services Is Nothing Then
                        _Computer.GetLogicalElements(WMIwrapper.Computer.LogicalElements.Services)
                    End If
                    If _Computer.Services IsNot Nothing Then
                        Me.Win32ServiceBindingSource.Clear()
                        For Each Win32_Service As WMIwrapper.Win32_Service In _Computer.Services
                            Me.Win32ServiceBindingSource.Add(Win32_Service)
                            WMIobject = Win32_Service
                        Next
                    End If
                    Me.PanelServices.BringToFront()
                Case "Shares"
                    If _Computer.Shares Is Nothing Then
                        _Computer.GetShares()
                    End If
                    If _Computer.Shares IsNot Nothing Then
                        Me.Win32ShareBindingSource.Clear()
                        For Each Win32_Share As WMIwrapper.Win32_Share In _Computer.Shares
                            Me.Win32ShareBindingSource.Add(Win32_Share)
                            WMIobject = Win32_Share
                        Next
                    End If
                    Me.PanelShares.BringToFront()
                Case "SystemAccounts"
                    If _Computer.SystemAccounts Is Nothing Then
                        _Computer.GetLogicalElements(WMIwrapper.Computer.LogicalElements.SystemAccounts)
                    End If
                    If _Computer.SystemAccounts IsNot Nothing Then
                        Me.Win32SystemAccountBindingSource.Clear()
                        For Each Win32_systemAccount As WMIwrapper.Win32_SystemAccount In _Computer.SystemAccounts
                            Me.Win32SystemAccountBindingSource.Add(Win32_systemAccount)
                            WMIobject = Win32_systemAccount
                        Next
                    End If
                    Me.PanelSystemAccounts.BringToFront()
                Case "SystemDrivers"
                    If _Computer.SystemDrivers Is Nothing Then
                        _Computer.GetLogicalElements(WMIwrapper.Computer.LogicalElements.SystemDrivers)
                    End If
                    If _Computer.SystemDrivers IsNot Nothing Then
                        Me.Win32SystemDriverBindingSource.Clear()
                        For Each Win32_SystemDriver As WMIwrapper.Win32_SystemDriver In _Computer.SystemDrivers
                            Me.Win32SystemDriverBindingSource.Add(Win32_SystemDriver)
                            WMIobject = Win32_SystemDriver
                        Next
                    End If
                    Me.PanelSystemDrivers.BringToFront()
                Case "VideoControllers"
                    If _Computer.VideoControllers Is Nothing Then
                        _Computer.GetLogicalElements(WMIwrapper.Computer.LogicalElements.VideoControllers)
                    End If
                    If _Computer.VideoControllers IsNot Nothing Then
                        Me.Win32VideoControllerBindingSource.Clear()
                        For Each Win32_VideoController As WMIwrapper.Win32_VideoController In _Computer.VideoControllers
                            Me.Win32VideoControllerBindingSource.Add(Win32_VideoController)
                            WMIobject = Win32_VideoController
                        Next
                    End If
                    Me.PanelVideoControllers.BringToFront()
                Case "UserAccounts"
                    If _Computer.UserAccounts Is Nothing Then
                        _Computer.GetLogicalElements(WMIwrapper.Computer.LogicalElements.UserAccounts)
                    End If
                    If _Computer.UserAccounts IsNot Nothing Then
                        Me.Win32UserAccountBindingSource.Clear()
                        For Each Win32_UserAccount As WMIwrapper.Win32_UserAccount In _Computer.UserAccounts
                            Me.Win32UserAccountBindingSource.Add(Win32_UserAccount)
                            WMIobject = Win32_UserAccount
                        Next
                    End If
                    Me.PanelUserAccounts.BringToFront()
                Case "Volumes"
                    If _Computer.Volumes Is Nothing Then
                        _Computer.GetLogicalElements(WMIwrapper.Computer.LogicalElements.Volumes)
                    End If
                    If _Computer.Volumes IsNot Nothing Then
                        Me.Win32VolumeBindingSource.Clear()
                        For Each Win32_Volume As WMIwrapper.Win32_Volume In _Computer.Volumes
                            Me.Win32VolumeBindingSource.Add(Win32_Volume)
                            WMIobject = Win32_Volume
                        Next
                    End If
                    Me.PanelVolumes.BringToFront()
            End Select

            ' Right panel: show all properties of the directory entries.
            Dim sdProperties As New SortedDictionary(Of String, String)
            ' Add each property to the sorted dictionary
            If WMIobject IsNot Nothing AndAlso WMIobject.ManagementObject IsNot Nothing Then
                For Each PropertyI As System.Management.PropertyData In WMIobject.ManagementObject.Properties
                    Dim strValue As String
                    If PropertyI.Value Is Nothing Then
                        strValue = ""
                    Else
                        strValue = PropertyI.Value.ToString
                    End If
                    sdProperties.Add(PropertyI.Name, strValue)
                Next
                ' Create a binding source to bind the DataGridView to the SortedDictionary
                Dim BindingSource As New BindingSource()
                BindingSource.DataSource = sdProperties
                Me.dgvProperties.DataSource = BindingSource
            End If

        Catch ex As Exception
            MsgBox("WMI returned an error: " & ex.Message, MsgBoxStyle.Exclamation)
            Me.PanelEmpty.BringToFront()
        End Try
        Me.Cursor = Cursors.Default

    End Sub

#Region "Services"

    ''' <summary>
    ''' Run when Services datagridview is clicked.
    ''' </summary>
    ''' <param name="sender">Sender object.</param>
    ''' <param name="e">Arguments.</param>
    ''' <remarks>Filters clicks to retain button clicks only.</remarks>
    Private Sub dgvServices_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) _
           Handles dgvServices.CellClick

        ' Ignore if the clicked item is not a button
        If dgvServices.CurrentCell.GetType Is GetType(DataGridViewButtonCell) Then
            ' Get the service name
            Dim strServiceName As String = dgvServices.CurrentRow.Cells.Item("ServiceName").Value.ToString
            ' Find the service
            Dim Service As WMIwrapper.Win32_Service = _Computer.Services.Item(strServiceName)
            ' Refresh it to have recent information
            Service.Refresh()
            ' Start or stop?
            Dim strAction As String
            If Service.Started Then
                strAction = "stop"
            Else
                strAction = "start"
            End If
            If MsgBox("Are you sure you want to " & strAction & " the service " & strServiceName & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                ' Start or stop
                Try
                    Dim InvokeError As WMIwrapper.InvokeError
                    If Service.Started Then
                        InvokeError = Service.StopService()
                    Else
                        InvokeError = Service.StartService()
                    End If
                    ' Result
                    If InvokeError.Number = 0 Then
                        MsgBox("Success", MsgBoxStyle.Exclamation)
                    Else
                        MsgBox("Failure: " & InvokeError.Message, MsgBoxStyle.Critical)
                    End If
                    Service.Refresh()
                    ' Refresh the grid view
                    dgvServices.Refresh()
                Catch ex As Exception
                    MsgBox("The service could not be " & strAction & "ed : " & ex.Message, MsgBoxStyle.Exclamation)
                End Try
            End If
        End If

    End Sub

#End Region

#Region "Shares"

    ''' <summary>
    ''' Run when Shares datagridview is clicked.
    ''' </summary>
    ''' <param name="sender">Sender object.</param>
    ''' <param name="e">Arguments.</param>
    ''' <remarks>Filters clicks to retain button clicks only.</remarks>
    Private Sub dgvShares_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) _
           Handles dgvShares.CellClick

        ' Ignore if the clicked item is not a button
        If dgvShares.CurrentCell.GetType Is GetType(DataGridViewButtonCell) Then
            ' Get the share name
            Dim strShareName As String = dgvShares.CurrentRow.Cells.Item("ShareName").Value.ToString
            If MsgBox("Are you sure you want to remove the share named " & strShareName & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                ' Find the share
                Dim ShareToDelete As WMIwrapper.Win32_Share = _Computer.Shares.Item(strShareName)
                ' Delete the share
                Try
                    Dim InvokeError As WMIwrapper.InvokeError = ShareToDelete.Delete()
                    ' Result
                    If InvokeError.Number = 0 Then
                        MsgBox("Success", MsgBoxStyle.Exclamation)
                        ' Delete the Win32_Share from the collection
                        _Computer.Shares.Remove(ShareToDelete)
                        ' Delete the row
                        dgvShares.Rows.Remove(dgvShares.CurrentRow)
                    Else
                        MsgBox("Failure: " & InvokeError.Message, MsgBoxStyle.Critical)
                    End If
                Catch ex As Exception
                    MsgBox("The share could not be removed: " & ex.Message, MsgBoxStyle.Exclamation)
                End Try
            End If
        End If

    End Sub

    ''' <summary>
    ''' Run when Shares / Create new file share menu is clicked.
    ''' </summary>
    ''' <param name="sender">Sender object.</param>
    ''' <param name="e">Arguments.</param>
    ''' <remarks>Shows the appropriate panel.</remarks>
    Private Sub NewFileShareToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles NewFileShareToolStripMenuItem.Click

        Dim frmCreateFileShare As New frmCreateFileShare
        With frmCreateFileShare
            ' Prepare values
            .txtDescription.Text = My.Settings.FileShareDescription
            .txtName.Text = My.Settings.FileShareName
            .txtPath.Text = My.Settings.FileSharePath

            If .ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                ' If OK chosen
                My.Settings.FileShareDescription = .txtDescription.Text
                My.Settings.FileShareName = .txtName.Text
                My.Settings.FileSharePath = .txtPath.Text
                Try
                    ' Create the file share
                    Dim NewShare As WMIwrapper.Win32_Share = _Computer.CreateFileShare(.txtPath.Text, .txtName.Text, .txtDescription.Text)
                    ' Refresh the datagridview
                    Me.Win32ShareBindingSource.Add(NewShare)
                Catch ex As Exception
                    MsgBox("The file share could not be created: " & ex.Message, MsgBoxStyle.Exclamation)
                End Try
            End If
        End With

    End Sub

#End Region

#Region "Volumes"

    ''' <summary>
    ''' Run when Volumes datagridview is clicked.
    ''' </summary>
    ''' <param name="sender">Sender object.</param>
    ''' <param name="e">Arguments.</param>
    ''' <remarks>Filters clicks to retain button clicks only.</remarks>
    Private Sub dgvVolumes_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) _
           Handles dgvVolumes.CellClick

        ' Ignore if the clicked item is not a button
        If dgvVolumes.CurrentCell.GetType Is GetType(DataGridViewButtonCell) Then
            ' Get the drive name
            Dim strDeviceID As String = dgvVolumes.CurrentRow.Cells.Item("DeviceID").Value.ToString
            If strDeviceID.Length = 0 Then
                MsgBox("This operation cannot be applied to this volume", MsgBoxStyle.Exclamation)
            Else
                If MsgBox("Are you sure you want to analyse the drive " & strDeviceID & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    With bwDefragAnalysis
                        If .IsBusy Then
                            MsgBox("Another analysis is in progress. Please wait until it is finished.", MsgBoxStyle.Information)
                        Else
                            .WorkerReportsProgress = False
                            .WorkerSupportsCancellation = False
                            .RunWorkerAsync(_Computer.Volumes.Item(strDeviceID))
                        End If
                    End With
                End If
            End If
        End If

    End Sub

    ''' <summary>
    ''' A background worker to analyse volume fragmentation
    ''' </summary>
    ''' <remarks></remarks>
    Private WithEvents bwDefragAnalysis As New System.ComponentModel.BackgroundWorker

    Private Sub bwDefragAnalysis_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) _
        Handles bwDefragAnalysis.DoWork

        Dim VolumeToAnalyze As WMIwrapper.Win32_Volume = TryCast(e.Argument, WMIwrapper.Win32_Volume)

        Try
            VolumeToAnalyze.DefragAnalysis()
            e.Result = VolumeToAnalyze
        Catch ex As Exception
            MsgBox("The volume could not be analyzed: " & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub bwDefragAnalysis_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) _
        Handles bwDefragAnalysis.RunWorkerCompleted

        Dim VolumeToAnalyze As WMIwrapper.Win32_Volume = TryCast(e.Result, WMIwrapper.Win32_Volume)
        Dim frmDefragAnalysis As New frmDefragAnalysis
        With frmDefragAnalysis
            .Text = VolumeToAnalyze.Caption
            .Win32DefragAnalysisBindingSource.Add(VolumeToAnalyze.DefragAnalysisResult)
            .Show()
        End With
        Me.Win32VolumesBindingSource.ResetBindings(False)

    End Sub

#End Region

#Region "Computer OS"

    Private Sub ShutDownToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles ShutDownToolStripMenuItem.Click

        If MsgBox("Are you sure you want to shut down the computer?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                _Computer.Shutdown()
            Catch ex As Exception
                MsgBox("The computer could not be shut down: " & ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If

    End Sub

    Private Sub RebootToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles RebootToolStripMenuItem.Click

        If MsgBox("Are you sure you want to reboot the computer?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                _Computer.Reboot()
            Catch ex As Exception
                MsgBox("The computer could not be rebooted: " & ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If

    End Sub

#End Region

End Class