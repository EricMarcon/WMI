''' <summary>
''' A computer.
''' </summary>
''' <remarks>This class is designed to allow easy access to hardware, shares, etc.</remarks>
Public Class Computer
    Implements IDisposable

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="ComputerName">The computer's name.</param>
    ''' <remarks></remarks>
    Sub New(ByVal ComputerName As String)
        _ComputerName = ComputerName
    End Sub

#Region "Logical elements Properties"

    Private _ComputerName As String
    ''' <summary>
    ''' The computer's name.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ComputerName() As String
        Get
            Return _ComputerName
        End Get
    End Property

    Private _Batteries As Win32_Batteries
    ''' <summary>
    ''' Batteries.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Batteries() As Win32_Batteries
        Get
            Return _Batteries
        End Get
    End Property

    Private _CDROMDrives As Win32_CDROMDrives
    ''' <summary>
    ''' CDROM drives.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property CDROMDrives() As Win32_CDROMDrives
        Get
            Return _CDROMDrives
        End Get
    End Property

    Private _DesktopMonitors As Win32_DesktopMonitors
    ''' <summary>
    ''' Desktop Monitors.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property DesktopMonitors() As Win32_DesktopMonitors
        Get
            Return _DesktopMonitors
        End Get
    End Property

    Private _DiskDrivePhysicalMedias As Win32_DiskDrivePhysicalMedias
    ''' <summary>
    ''' Disk drives and physical media.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property DiskDrivePhysicalMedias() As Win32_DiskDrivePhysicalMedias
        Get
            Return _DiskDrivePhysicalMedias
        End Get
    End Property

    Private _FloppyDrives As Win32_FloppyDrives
    ''' <summary>
    ''' Floppy drives.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property FloppyDrives() As Win32_FloppyDrives
        Get
            Return _FloppyDrives
        End Get
    End Property

    Private _Groups As Win32_Groups
    ''' <summary>
    ''' Group Accounts.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Groups() As Win32_Groups
        Get
            Return _Groups
        End Get
    End Property

    Private _Keyboard As Win32_Keyboard
    ''' <summary>
    ''' Keyboard.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>A single computer is assumed.</remarks>
    Public ReadOnly Property Keyboard() As Win32_Keyboard
        Get
            Return _Keyboard
        End Get
    End Property

    Private _LogicalDisks As Win32_LogicalDisks
    ''' <summary>
    ''' Logical Disks.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property LogicalDisks() As Win32_LogicalDisks
        Get
            Return _LogicalDisks
        End Get
    End Property

    Private _NetworkAdapterSettings As Win32_NetworkAdapterSettings
    ''' <summary>
    ''' Network adapters and their configurations.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property NetworkAdapterSettings() As Win32_NetworkAdapterSettings
        Get
            Return _NetworkAdapterSettings
        End Get
    End Property

    Private _OnBoardDevices As Win32_OnBoardDevices
    ''' <summary>
    ''' On-Board Devices.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property OnBoardDevices() As Win32_OnBoardDevices
        Get
            Return _OnBoardDevices
        End Get
    End Property

    Private _PhysicalMemories As Win32_PhysicalMemories
    ''' <summary>
    ''' Physical Memory.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property PhysicalMemories() As Win32_PhysicalMemories
        Get
            Return _PhysicalMemories
        End Get
    End Property

    Private _PhysicalMemoryArrays As Win32_PhysicalMemoryArrays
    ''' <summary>
    ''' Physical Memory Arrays.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property PhysicalMemoryArrays() As Win32_PhysicalMemoryArrays
        Get
            Return _PhysicalMemoryArrays
        End Get
    End Property

    Private _PnPDevices As Win32_PnPDevices
    ''' <summary>
    ''' Plug and Play devices.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property PnPDevices() As Win32_PnPDevices
        Get
            Return _PnPDevices
        End Get
    End Property

    Private _PnPSignedDrivers As Win32_PnPSignedDrivers
    ''' <summary>
    ''' Plug and Play signed drivers.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property PnPSignedDrivers() As Win32_PnPSignedDrivers
        Get
            Return _PnPSignedDrivers
        End Get
    End Property

    Private _PointingDevices As Win32_PointingDevices
    ''' <summary>
    ''' Pointing Devices.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property PointingDevices() As Win32_PointingDevices
        Get
            Return _PointingDevices
        End Get
    End Property

    Private _Processors As Win32_Processors
    ''' <summary>
    ''' Computer Processors.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Processors() As Win32_Processors
        Get
            Return _Processors
        End Get
    End Property

    Private _Refrigerations As Win32_Refrigerations
    ''' <summary>
    ''' Cooling Devices.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Refrigerations() As Win32_Refrigerations
        Get
            Return _Refrigerations
        End Get
    End Property

    Private _Services As Win32_Services
    ''' <summary>
    ''' Services.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Services() As Win32_Services
        Get
            Return _Services
        End Get
    End Property

    Private _SystemAccounts As Win32_SystemAccounts
    ''' <summary>
    ''' System Accounts.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property SystemAccounts() As Win32_SystemAccounts
        Get
            Return _SystemAccounts
        End Get
    End Property

    Private _SystemDrivers As Win32_SystemDrivers
    ''' <summary>
    ''' System drivers.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property SystemDrivers() As Win32_SystemDrivers
        Get
            Return _SystemDrivers
        End Get
    End Property

    Private _UserAccounts As Win32_UserAccounts
    ''' <summary>
    ''' User Accounts.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property UserAccounts() As Win32_UserAccounts
        Get
            Return _UserAccounts
        End Get
    End Property

    Private _VideoControllers As Win32_VideoControllers
    ''' <summary>
    ''' Video Controller.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property VideoControllers() As Win32_VideoControllers
        Get
            Return _VideoControllers
        End Get
    End Property

    Private _Volumes As Win32_Volumes
    ''' <summary>
    ''' Volumes (storage areas).
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Volumes() As Win32_Volumes
        Get
            Return _Volumes
        End Get
    End Property

#End Region

#Region "Logical elements Methods"

    ''' <summary>
    '''  Read selected logical elements (hardware and software) in WMI classes.
    ''' </summary>
    ''' <param name="LogicalElements">Selection of elements as flags. Use <c>OR</c> to combine them or <c>All</c> value.</param>
    ''' <remarks></remarks>
    Public Sub GetLogicalElements(Optional ByVal LogicalElements As LogicalElements = Computer.LogicalElements.All)

        ' Batteries
        If (LogicalElements And Computer.LogicalElements.Batteries) = Computer.LogicalElements.Batteries Then
            _Batteries = New Win32_Batteries(_ComputerName)
        End If
        ' CDROM Drives
        If (LogicalElements And Computer.LogicalElements.CDROMDrives) = Computer.LogicalElements.CDROMDrives Then
            _CDROMDrives = New Win32_CDROMDrives(_ComputerName)
        End If
        ' Desktop Monitors
        If (LogicalElements And Computer.LogicalElements.DesktopMonitors) = Computer.LogicalElements.DesktopMonitors Then
            _DesktopMonitors = New Win32_DesktopMonitors(_ComputerName)
        End If
        ' Disk drives and physical media
        If (LogicalElements And Computer.LogicalElements.DiskDrivePhysicalMedias) = Computer.LogicalElements.DiskDrivePhysicalMedias Then
            _DiskDrivePhysicalMedias = New Win32_DiskDrivePhysicalMedias(_ComputerName)
        End If
        ' Floppy Drives
        If (LogicalElements And Computer.LogicalElements.FloppyDrives) = Computer.LogicalElements.FloppyDrives Then
            _FloppyDrives = New Win32_FloppyDrives(_ComputerName)
        End If
        ' Groups
        If (LogicalElements And Computer.LogicalElements.Groups) = Computer.LogicalElements.Groups Then
            _Groups = New Win32_Groups(_ComputerName)
        End If
        ' Keyboard
        If (LogicalElements And Computer.LogicalElements.Keyboard) = Computer.LogicalElements.Keyboard Then
            Using Win32_Keyboards As New Win32_Keyboards(_ComputerName)
                _Keyboard = Win32_Keyboards.Item(0)
            End Using
        End If
        ' Logical Disks
        If (LogicalElements And Computer.LogicalElements.LogicalDisks) = Computer.LogicalElements.LogicalDisks Then
            _LogicalDisks = New Win32_LogicalDisks(_ComputerName)
        End If
        ' Network Adapters
        If (LogicalElements And Computer.LogicalElements.NetworkAdapterSettings) = Computer.LogicalElements.NetworkAdapterSettings Then
            _NetworkAdapterSettings = New Win32_NetworkAdapterSettings(_ComputerName)
        End If
        ' On-Board Devices
        If (LogicalElements And Computer.LogicalElements.OnBoardDevices) = Computer.LogicalElements.OnBoardDevices Then
            _OnBoardDevices = New Win32_OnBoardDevices(_ComputerName)
        End If
        ' Physical Memory
        If (LogicalElements And Computer.LogicalElements.PhysicalMemories) = Computer.LogicalElements.PhysicalMemories Then
            _PhysicalMemories = New Win32_PhysicalMemories(_ComputerName)
        End If
        ' Physical Memory Arrays
        If (LogicalElements And Computer.LogicalElements.PhysicalMemoryArrays) = Computer.LogicalElements.PhysicalMemoryArrays Then
            _PhysicalMemoryArrays = New Win32_PhysicalMemoryArrays(_ComputerName)
        End If
        ' PnP Devices
        If (LogicalElements And Computer.LogicalElements.PnPDevices) = Computer.LogicalElements.PnPDevices Then
            _PnPDevices = New Win32_PnPDevices(_ComputerName)
        End If
        ' PnP Signed drivers
        If (LogicalElements And Computer.LogicalElements.PnPSignedDrivers) = Computer.LogicalElements.PnPSignedDrivers Then
            _PnPSignedDrivers = New Win32_PnPSignedDrivers(_ComputerName)
        End If
        ' Pointing Devices
        If (LogicalElements And Computer.LogicalElements.PointingDevices) = Computer.LogicalElements.PointingDevices Then
            _PointingDevices = New Win32_PointingDevices(_ComputerName)
        End If
        ' Processors
        If (LogicalElements And Computer.LogicalElements.Processors) = Computer.LogicalElements.Processors Then
            _Processors = New Win32_Processors(_ComputerName)
        End If
        ' Refrigeration Devices
        If (LogicalElements And Computer.LogicalElements.Refrigerations) = Computer.LogicalElements.Refrigerations Then
            _Refrigerations = New Win32_Refrigerations(_ComputerName)
        End If
        ' Services
        If (LogicalElements And Computer.LogicalElements.Services) = Computer.LogicalElements.Services Then
            _Services = New Win32_Services(_ComputerName)
        End If
        ' System Accouts
        If (LogicalElements And Computer.LogicalElements.SystemAccounts) = Computer.LogicalElements.SystemAccounts Then
            _SystemAccounts = New Win32_SystemAccounts(_ComputerName)
        End If
        ' System Drivers
        If (LogicalElements And Computer.LogicalElements.SystemDrivers) = Computer.LogicalElements.SystemDrivers Then
            _SystemDrivers = New Win32_SystemDrivers(_ComputerName)
        End If
        ' User Accouts
        If (LogicalElements And Computer.LogicalElements.UserAccounts) = Computer.LogicalElements.UserAccounts Then
            _UserAccounts = New Win32_UserAccounts(_ComputerName)
        End If
        ' Video Controllers
        If (LogicalElements And Computer.LogicalElements.VideoControllers) = Computer.LogicalElements.VideoControllers Then
            _VideoControllers = New Win32_VideoControllers(_ComputerName)
        End If
        ' Volumes
        If (LogicalElements And Computer.LogicalElements.Volumes) = Computer.LogicalElements.Volumes Then
            _Volumes = New Win32_Volumes(_ComputerName)
        End If

    End Sub

#End Region

    ''' <summary>
    ''' Logical elements selection.
    ''' </summary>
    ''' <remarks></remarks>
    <Flags()> _
       Public Enum LogicalElements As Integer

        ''' <summary>
        ''' No element.
        ''' </summary>
        ''' <remarks></remarks>
        None = 0
        ''' <summary>
        ''' Keyboard.
        ''' </summary>
        ''' <remarks></remarks>
        Keyboard = 1
        ''' <summary>
        ''' Processors.
        ''' </summary>
        ''' <remarks></remarks>
        Processors = 2
        ''' <summary>
        ''' Disk Drives and Physical Medias.
        ''' </summary>
        ''' <remarks></remarks>
        DiskDrivePhysicalMedias = 4
        ''' <summary>
        ''' Network Adapter Settings.
        ''' </summary>
        ''' <remarks></remarks>
        NetworkAdapterSettings = 8
        ''' <summary>
        ''' Batteries.
        ''' </summary>
        ''' <remarks></remarks>
        Batteries = &H10
        ''' <summary>
        ''' CDROM Drives
        ''' </summary>
        ''' <remarks></remarks>
        CDROMDrives = &H20
        ''' <summary>
        ''' PnP Devices.
        ''' </summary>
        ''' <remarks></remarks>
        PnPDevices = &H40
        ''' <summary>
        ''' Refrigeration Devices.
        ''' </summary>
        ''' <remarks></remarks>
        Refrigerations = &H80
        ''' <summary>
        ''' Floppy Drives.
        ''' </summary>
        ''' <remarks></remarks>
        FloppyDrives = &H100
        ''' <summary>
        ''' Logical Disks.
        ''' </summary>
        ''' <remarks></remarks>
        LogicalDisks = &H200
        ''' <summary>
        ''' System drivers.
        ''' </summary>
        ''' <remarks></remarks>
        SystemDrivers = &H400
        ''' <summary>
        ''' PnP Signed Drivers.
        ''' </summary>
        ''' <remarks></remarks>
        PnPSignedDrivers = &H800
        ''' <summary>
        ''' Video Controllers.
        ''' </summary>
        ''' <remarks></remarks>
        VideoControllers = &H1000
        ''' <summary>
        ''' DesktopMonitors.
        ''' </summary>
        ''' <remarks></remarks>
        DesktopMonitors = &H2000
        ''' <summary>
        ''' Pointing Devices.
        ''' </summary>
        ''' <remarks></remarks>
        PointingDevices = &H4000
        ''' <summary>
        ''' Services.
        ''' </summary>
        ''' <remarks></remarks>
        Services = &H8000
        ''' <summary>
        ''' Physical Memory.
        ''' </summary>
        ''' <remarks></remarks>
        PhysicalMemories = &H10000
        ''' <summary>
        ''' OnBoard Devices.
        ''' </summary>
        ''' <remarks></remarks>
        OnBoardDevices = &H20000
        ''' <summary>
        ''' Physical Memory Arrays.
        ''' </summary>
        ''' <remarks></remarks>
        PhysicalMemoryArrays = &H40000
        ''' <summary>
        ''' Area of storage on a hard disk.
        ''' </summary>
        ''' <remarks></remarks>
        Volumes = &H80000
        ''' <summary>
        ''' User Accounts.
        ''' </summary>
        ''' <remarks></remarks>
        UserAccounts = &H100000
        ''' <summary>
        ''' Groups.
        ''' </summary>
        ''' <remarks></remarks>
        Groups = &H200000
        ''' <summary>
        ''' System Accounts.
        ''' </summary>
        ''' <remarks></remarks>
        SystemAccounts = &H400000
        ''' <summary>
        ''' All elements.
        ''' </summary>
        ''' <remarks></remarks>
        All = -1

    End Enum



#Region "Operating System"

    Private _OperatingSystem As Win32_OperatingSystem
    ''' <summary>
    ''' The computer's Operating System.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property OperatingSystem() As Win32_OperatingSystem
        Get
            Return _OperatingSystem
        End Get
    End Property

    ''' <summary>
    ''' Read operating system properties.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub GetOperatingSystem()
        Using Win32_OperatingSystems As New Win32_OperatingSystems(_ComputerName)
            _OperatingSystem = Win32_OperatingSystems.Item(0)
        End Using
    End Sub

    ''' <summary>
    ''' Shut down the computer.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Shutdown()

        ' Verify the OS has been read
        If _OperatingSystem Is Nothing Then Me.GetOperatingSystem()

        ' Reboot
        Dim ieShutdown As WMIwrapper.InvokeError = _OperatingSystem.Shutdown
        If ieShutdown.Number > 0 Then
            Throw New Exception(ieShutdown.Message)
        End If

    End Sub

    ''' <summary>
    ''' Reboot the computer.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Reboot()

        ' Verify the OS has been read
        If _OperatingSystem Is Nothing Then Me.GetOperatingSystem()

        ' Reboot
        Dim ieReboot As WMIwrapper.InvokeError = _OperatingSystem.Reboot
        If ieReboot.Number > 0 Then
            Throw New Exception(ieReboot.Message)
        End If

    End Sub

    Private _ComputerSystem As Win32_ComputerSystem
    ''' <summary>
    ''' Computer System.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ComputerSystem() As Win32_ComputerSystem
        Get
            Return _ComputerSystem
        End Get
    End Property

    ''' <summary>
    ''' Get a computer system.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub GetComputerSystem()
        ' Computer System
        Using Win32_ComputerSystems As New Win32_ComputerSystems(_ComputerName)
            _ComputerSystem = Win32_ComputerSystems.Item(0)
        End Using
    End Sub

#End Region



#Region "Shares"

    Private _Shares As Win32_Shares
    ''' <summary>
    ''' Collection of computer's share.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Shares() As Win32_Shares
        Get
            Return _Shares
        End Get
    End Property

    ''' <summary>
    ''' Read shares.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub GetShares()
        _Shares = New Win32_Shares(_ComputerName)
    End Sub

    ''' <summary>
    ''' Create a file share on the computer.
    ''' </summary>
    ''' <param name="Path">Path on the computer file system to the shared folder.</param>
    ''' <param name="Name">Share name.</param>
    ''' <param name="Description">Share description.</param>
    ''' <returns>The created share.</returns>
    ''' <remarks>
    ''' Creates a file share with Read and Write access to Everyone and unlimited number of users.
    ''' Security should be set by the file system.
    ''' For more sophisticated shares, use <see cref="M:WMIwrapper.Win32_Share.Create"></see>
    ''' Check whether the share already exists. If so, just return it.
    ''' May throw an exception containing the <see cref="P:WMIwrapper.InvokeError.Message"></see> as Message.
    ''' </remarks>
    Public Function CreateFileShare(ByVal Path As String, ByVal Name As String, Optional ByVal Description As String = Nothing) As Win32_Share

        ' Read file shares collection if necessary
        If _Shares Is Nothing Then Me.GetShares()

        ' Search for the share
        Dim Share As Win32_Share = _Shares.Item(Name)

        If Share Is Nothing Then
            ' If the share does not exist, create it
            Share = New Win32_Share(_ComputerName)

            ' Create a trustee for Everyone
            Using Everyone As New Win32_Trustee
                Everyone.SID = New Byte() {1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0}

                ' Create an ACE for Everyone
                Using aceEveryone As New Win32_ACE
                    With aceEveryone
                        .Trustee = Everyone
                        ' Allow modify 
                        .AccessMask = Enums.AccessMask.Modify
                        ' No flag for a share
                        .AceFlags = Enums.AceFlags.None
                        ' Positive ACE
                        .AceType = Enums.AceType.Access_Allowed
                    End With

                    ' Create the share's security descriptor
                    Using secDesc As New Win32_SecurityDescriptor
                        ' Declare DACLs exist
                        secDesc.ControlFlags = Enums.ControlFlags.SE_DACL_PRESENT
                        ' DACLs are just Everyone's ACE
                        secDesc.DACL = New Win32_ACE() {aceEveryone}

                        ' Finally create the share. Get the return error.
                        Dim ieCreateShare As WMIwrapper.InvokeError = Share.Create(Path, Enums.Type.DiskDrive, Name, -1, secDesc, Description)
                        If ieCreateShare.Number = 0 Then
                            ' Add it to the collection
                            _Shares.Add(Share)
                        Else
                            Throw New Exception(ieCreateShare.Message)
                        End If
                    End Using
                End Using
            End Using
        End If

        Return Share

    End Function

    ''' <summary>
    ''' Delete a file share.
    ''' </summary>
    ''' <param name="Name">Share name.</param>
    ''' <remarks>
    ''' Actually deletes any type of share, not only file shares.
    ''' May throw an exception containing the <see cref="P:WMIwrapper.InvokeError.Message"></see> as Message.
    ''' </remarks>
    Public Sub DeleteFileShare(ByVal Name As String)

        Using Share As New Win32_Share(_ComputerName, Name)
            Dim ieDeleteShare As WMIwrapper.InvokeError = Share.Delete()
            If ieDeleteShare.Number > 0 Then
                Throw New Exception(ieDeleteShare.Message)
            End If
        End Using

    End Sub

#End Region



    ''' <summary>
    ''' Dispose.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Dispose() Implements System.IDisposable.Dispose
        ' Dispose the WMI objects
        If _Batteries IsNot Nothing Then _Batteries.Dispose()
        If _CDROMDrives IsNot Nothing Then _CDROMDrives.Dispose()
        If _ComputerSystem IsNot Nothing Then _ComputerSystem.Dispose()
        If _DesktopMonitors IsNot Nothing Then _DesktopMonitors.Dispose()
        If _DiskDrivePhysicalMedias IsNot Nothing Then _DiskDrivePhysicalMedias.Dispose()
        If _FloppyDrives IsNot Nothing Then _FloppyDrives.Dispose()
        If _Groups IsNot Nothing Then _Groups.Dispose()
        If _Keyboard IsNot Nothing Then _Keyboard.Dispose()
        If _LogicalDisks IsNot Nothing Then _LogicalDisks.Dispose()
        If _NetworkAdapterSettings IsNot Nothing Then _NetworkAdapterSettings.Dispose()
        If _OnBoardDevices IsNot Nothing Then _OnBoardDevices.Dispose()
        If _PhysicalMemories IsNot Nothing Then _PhysicalMemories.Dispose()
        If _PhysicalMemoryArrays IsNot Nothing Then _PhysicalMemoryArrays.Dispose()
        If _PnPDevices IsNot Nothing Then _PnPDevices.Dispose()
        If _PnPSignedDrivers IsNot Nothing Then _PnPSignedDrivers.Dispose()
        If _PointingDevices IsNot Nothing Then _PointingDevices.Dispose()
        If _Processors IsNot Nothing Then _Processors.Dispose()
        If _Refrigerations IsNot Nothing Then _Refrigerations.Dispose()
        If _Services IsNot Nothing Then _Services.Dispose()
        If _Shares IsNot Nothing Then _Shares.Dispose()
        If _SystemAccounts IsNot Nothing Then _SystemAccounts.Dispose()
        If _SystemDrivers IsNot Nothing Then _SystemDrivers.Dispose()
        If _UserAccounts IsNot Nothing Then _UserAccounts.Dispose()
        If _VideoControllers IsNot Nothing Then _VideoControllers.Dispose()
        If _Volumes IsNot Nothing Then _Volumes.Dispose()
        ' Call the garbage collector
        GC.SuppressFinalize(Me)
    End Sub

End Class
