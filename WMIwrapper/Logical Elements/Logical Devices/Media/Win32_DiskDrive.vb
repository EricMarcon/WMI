Imports System.Management

''' <summary>
''' Disk Drive.
''' </summary>
''' <remarks>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa394132.aspx">MSDN</a>
''' </remarks>
Public Class Win32_DiskDrive
    Inherits CIM_MediaAccessDevice

    ''' <summary>
    ''' Constructor. 
    ''' </summary>
    ''' <param name="ManagementObject">The underlying management object.</param>
    ''' <remarks>Use this constructor when the management object already exists (e.g. read from a collection).</remarks>
    Public Sub New(ByVal ManagementObject As ManagementObject)
        MyBase.New(ManagementObject)
    End Sub

    ''' <summary>
    ''' Constructor
    ''' </summary>
    ''' <param name="ManagementPath">The path to the object, as \\Computer\ClassPath:ClassName.Condition.</param>
    ''' <remarks>
    ''' <para>Creates a new Management Object bound to an existing WMI instance found by its scope, class and key.</para>
    ''' </remarks>
    Public Sub New(ByVal ManagementPath As ManagementPath)
        MyBase.New(ManagementPath)
    End Sub

    ''' <summary>
    ''' Number of bytes in each sector for the physical disk drive.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property BytesPerSector() As UInt32
        Get
            Return GetUint32Property("BytesPerSector")
        End Get
    End Property

    ''' <summary>
    ''' Revision for the disk drive firmware that is assigned by the manufacturer.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Windows Server 2003, Windows XP, Windows 2000, and Windows NT 4.0:  This property is not available.</remarks>
    Public ReadOnly Property FirmwareRevision() As String
        Get
            Return GetStringProperty("FirmwareRevision")
        End Get
    End Property

    ''' <summary>
    ''' Physical drive number of the given drive.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>This property is filled by the GetDriveMapInfo method. A value of 0xFF indicates that the given drive does not map to a physical drive.</remarks>
    Public ReadOnly Property Index() As UInt32
        Get
            Return GetUint32Property("Index")
        End Get
    End Property

    ''' <summary>
    ''' Interface type of physical disk drive.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>The values are: SCSI, HDC,IDE, USB, 1394</remarks>
    Public ReadOnly Property InterfaceType() As String
        Get
            Return GetStringProperty("InterfaceType")
        End Get
    End Property

    ''' <summary>
    ''' Name of the manufacturer of the disk drive.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Manufacturer() As String
        Get
            Return GetStringProperty("Manufacturer")
        End Get
    End Property

    ''' <summary>
    ''' Indicates the media for a disk drive is loaded.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>For fixed disk drives, this property will always be <c>True</c>.</remarks>
    Public ReadOnly Property MediaLoaded() As Boolean
        Get
            Return GetBooleanProperty("MediaLoaded")
        End Get
    End Property

    ''' <summary>
    ''' Type of media used or accessed by this device.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property MediaType() As String
        Get
            Return GetStringProperty("MediaType")
        End Get
    End Property

    ''' <summary>
    ''' Manufacturer's model number of the disk drive.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Model() As String
        Get
            Return GetStringProperty("Model")
        End Get
    End Property

    ''' <summary>
    ''' Number of partitions on this physical disk drive that are recognized by the operating system.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Partitions() As UInt32
        Get
            Return GetUint32Property("Partitions")
        End Get
    End Property

    ''' <summary>
    ''' SCSI bus number of the disk drive.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property SCSIBus() As UInt32
        Get
            Return GetUint32Property("SCSIBus")
        End Get
    End Property

    ''' <summary>
    ''' SCSI logical unit number (LUN) of the disk drive.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property SCSILogicalUnit() As UInt16
        Get
            Return GetUint16Property("SCSILogicalUnit")
        End Get
    End Property

    ''' <summary>
    ''' SCSI port number of the disk drive.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property SCSIPort() As UInt16
        Get
            Return GetUint16Property("SCSIPort")
        End Get
    End Property

    ''' <summary>
    ''' SCSI identifier number of the disk drive.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property SCSITargetId() As UInt16
        Get
            Return GetUint16Property("SCSITargetId")
        End Get
    End Property

    ''' <summary>
    ''' Number of sectors in each track for this physical disk drive.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property SectorsPerTrack() As UInt32
        Get
            Return GetUint32Property("SectorsPerTrack")
        End Get
    End Property

    ''' <summary>
    ''' Number allocated by the manufacturer to identify the physical media.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Windows Server 2003, Windows XP, Windows 2000, and Windows NT 4.0:  This property is not available.</remarks>
    Public ReadOnly Property SerialNumber() As String
        Get
            Return GetStringProperty("SerialNumber")
        End Get
    End Property

    ''' <summary>
    ''' Disk identification. This property can be used to identify a shared resource.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>This property has been added for Windows XP.</remarks>
    Public ReadOnly Property Signature() As UInt32
        Get
            Return GetUint32Property("Signature")
        End Get
    End Property

    ''' <summary>
    ''' Size of the disk drive.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>It is calculated by multiplying the total number of cylinders, tracks in each cylinder, sectors in each track, and bytes in each sector.</remarks>
    Public ReadOnly Property Size() As UInt64
        Get
            Return GetUint64Property("Size")
        End Get
    End Property

    ''' <summary>
    ''' Total number of cylinders on the physical disk drive.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Note: the value for this property is obtained through extended functions of BIOS interrupt 13h. The value may be inaccurate if the drive uses a translation scheme to support high-capacity disk sizes. Consult the manufacturer for accurate drive specifications.</remarks>
    Public ReadOnly Property TotalCylinders() As UInt64
        Get
            Return GetUint64Property("TotalCylinders")
        End Get
    End Property

    ''' <summary>
    ''' Total number of heads on the disk drive.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Note: the value for this property is obtained through extended functions of BIOS interrupt 13h. The value may be inaccurate if the drive uses a translation scheme to support high-capacity disk sizes. Consult the manufacturer for accurate drive specifications.</remarks>
    Public ReadOnly Property TotalHeads() As UInt32
        Get
            Return GetUint32Property("TotalHeads")
        End Get
    End Property

    ''' <summary>
    ''' Total number of sectors on the physical disk drive.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Note: the value for this property is obtained through extended functions of BIOS interrupt 13h. The value may be inaccurate if the drive uses a translation scheme to support high-capacity disk sizes. Consult the manufacturer for accurate drive specifications.</remarks>
    Public ReadOnly Property TotalSectors() As UInt64
        Get
            Return GetUint64Property("TotalSectors")
        End Get
    End Property

    ''' <summary>
    ''' Total number of tracks on the physical disk drive.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Note: the value for this property is obtained through extended functions of BIOS interrupt 13h. The value may be inaccurate if the drive uses a translation scheme to support high-capacity disk sizes. Consult the manufacturer for accurate drive specifications.</remarks>
    Public ReadOnly Property TotalTracks() As UInt64
        Get
            Return GetUint64Property("TotalTracks")
        End Get
    End Property

    ''' <summary>
    ''' Number of tracks in each cylinder on the physical disk drive. 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Note: the value for this property is obtained through extended functions of BIOS interrupt 13h. The value may be inaccurate if the drive uses a translation scheme to support high-capacity disk sizes. Consult the manufacturer for accurate drive specifications.</remarks>
    Public ReadOnly Property TracksPerCylinder() As UInt32
        Get
            Return GetUint32Property("TracksPerCylinder")
        End Get
    End Property

End Class

''' <summary>
''' Collection of <see cref="T:WMIwrapper.Win32_DiskDrive"></see>.
''' </summary>
''' <remarks></remarks>
Public Class Win32_DiskDrives
    Inherits CIM_MediaAccessDevices

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <param name="DeviceID">If specified, only the item corresponding to this key value is returned. Ignored if <code>Condition</code> is set.</param>
    ''' <param name="Condition">WQL condition can be specified. It is not checked and sent to WMI as is.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Computer As String, Optional ByVal DeviceID As String = Nothing, Optional ByVal Condition As String = Nothing)

        MyBase.New(Computer, "Win32_DiskDrive")
        ' Prepare condition
        If Condition Is Nothing AndAlso DeviceID IsNot Nothing Then
            Condition = "DeviceID ='" & DeviceID & "'"
        End If
        ' Read the collection
        For Each ManagementObjectI As ManagementObject In Me.Read(Condition)
            Me.Add(New Win32_DiskDrive(ManagementObjectI))
        Next

    End Sub

    ''' <summary>
    ''' Find an item in the collection.
    ''' </summary>
    ''' <param name="index">Index of the item.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal index As Integer) As Win32_DiskDrive
        Return CType(List.Item(index), Win32_DiskDrive)
    End Function

    ''' <summary>
    ''' Find an item by its ID.
    ''' </summary>
    ''' <param name="DeviceID">The device ID.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal DeviceID As String) As Win32_DiskDrive
        For intI As Integer = 0 To List.Count - 1
            If Me.Item(intI).DeviceID = DeviceID Then
                Return Me.Item(intI)
            End If
        Next
        Return Nothing
    End Function

End Class
