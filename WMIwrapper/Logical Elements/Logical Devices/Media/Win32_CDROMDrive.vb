Imports System.Management

''' <summary>
''' CDROM Drive.
''' </summary>
''' <remarks>
''' <para>
''' Represents a CD-ROM drive on a computer system running Windows.
''' Be aware that the name of the drive does not correspond to the logical drive letter assigned to the device.
''' </para>
''' <para>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa394149.aspx">MSDN</a>
''' </para>
''' </remarks>
Public Class Win32_CDROMDrive
    Inherits CIM_MediaAccessDevice

    ''' <summary>
    ''' Constructor. 
    ''' </summary>
    ''' <param name="ManagementObject">The underlying management object.</param>
    ''' <remarks>Use this constructor when the management object already exists (e.g. read from a collection).</remarks>
    Public Sub New(ByVal ManagementObject As ManagementObject)
        MyBase.New(ManagementObject)
    End Sub

#Region "Properties"

    ''' <summary>
    ''' Drive letter of the CD-ROM drive.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>This is achieved by reading a block of data twice and comparing the data against itself.</remarks>
    Public ReadOnly Property Drive() As String
        Get
            Return GetStringProperty("Drive")
        End Get
    End Property

    ''' <summary>
    ''' If True, files can be accurately read from the CD device.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property DriveIntegrity() As Boolean
        Get
            Return GetBooleanProperty("DriveIntegrity")
        End Get
    End Property

    Public ReadOnly Property FileSystemFlagsEx() As Enums.FileSystemFlagsEx
        Get
            Dim obj As Object = GetPropertyObject("FileSystemFlagsEx")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.FileSystemFlagsEx)
            End If
        End Get
    End Property

    ''' <summary>
    ''' Drive letter that uniquely identifies this CD-ROM drive.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Id() As String
        Get
            Return GetStringProperty("Id")
        End Get
    End Property

    ''' <summary>
    ''' Maximum length of a filename component supported by the Windows CD-ROM drive.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' A file name component the portion of a file name between backslashes.
    ''' The value can be used to indicate that long names are supported by the specified file system.
    ''' For example, for a FAT file system supporting long names, the function stores the value 255, rather than the previous 8.3 indicator.
    ''' Long names can also be supported on systems that use the NTFS file system.
    ''' </remarks>
    Public ReadOnly Property MaximumComponentLength() As String
        Get
            Return GetStringProperty("MaximumComponentLength")
        End Get
    End Property

    ''' <summary>
    ''' If True, a CD-ROM is in the drive.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property MediaLoaded() As Boolean
        Get
            Return GetBooleanProperty("MediaLoaded")
        End Get
    End Property

    ''' <summary>
    ''' Type of media that can be used or accessed by this device.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' Possible values are:
    ''' <list type="bullet">
    ''' <item><description>CdRomOnly</description></item>
    ''' <item><description>CdRomWrite</description></item>
    ''' <item><description>DVDRomOnly</description></item>
    ''' <item><description>DVDRomWrite</description></item>
    ''' </list>
    ''' Windows Server 2003, Windows XP, Windows 2000, and Windows NT 4.0:  Possible values are:
    ''' <list type="bullet">
    ''' <item><description>Random Access</description></item>
    ''' <item><description>Supports Writing</description></item>
    ''' <item><description>Removable Media</description></item>
    ''' <item><description>CD-ROM</description></item>
    ''' </list>
    ''' </remarks>
    Public ReadOnly Property MediaType() As String
        Get
            Return GetStringProperty("MediaType")
        End Get
    End Property

    ''' <summary>
    ''' Firmware revision level that is assigned by the manufacturer.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Windows Server 2003, Windows XP, Windows 2000, Windows NT 4.0, and Windows Me/98/95:  This property is not available.</remarks>
    Public ReadOnly Property MfrAssignedRevisionLevel() As String
        Get
            Return GetStringProperty("MfrAssignedRevisionLevel")
        End Get
    End Property

    ''' <summary>
    ''' Firmware revision level of the Windows CD-ROM drive.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property RevisionLevel() As String
        Get
            Return GetStringProperty("RevisionLevel")
        End Get
    End Property

    ''' <summary>
    ''' SCSI bus number for the disk drive.
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
    ''' <remarks>
    ''' The LUN is used to designate which SCSI controller is being accessed in a system with more than one controller being used.
    ''' The SCSI device identifier is similar, but is the designation for multiple devices on one controller.
    ''' </remarks>
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
    ''' SCSI identifier number of the Windows CD-ROM drive.
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
    ''' Number supplied by the manufacturer that identifies the physical media.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Windows Server 2003, Windows XP, Windows 2000, Windows NT 4.0, and Windows Me/98/95:  This property is not available.</remarks>
    Public ReadOnly Property SerialNumber() As String
        Get
            Return GetStringProperty("SerialNumber")
        End Get
    End Property

    ''' <summary>
    ''' Size of the disk drive in Bytes.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Size() As UInt64
        Get
            Return GetUint64Property("Size")
        End Get
    End Property

    ''' <summary>
    ''' Transfer rate of the CD-ROM drive.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' A value of -1 indicates that the rate cannot be determined.
    ''' When this happens, the CD is not in the drive.
    ''' </remarks>
    Public ReadOnly Property TransferRate() As Double
        Get
            Return GetDoubleProperty("TransferRate")
        End Get
    End Property

    ''' <summary>
    ''' Volume name of the Windows CD-ROM drive.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property VolumeName() As String
        Get
            Return GetStringProperty("VolumeName")
        End Get
    End Property

    ''' <summary>
    ''' Volume serial number of the media in the CD-ROM drive.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property VolumeSerialNumber() As String
        Get
            Return GetStringProperty("VolumeSerialNumber")
        End Get
    End Property

#End Region

End Class

''' <summary>
''' Collection of <see cref="T:WMIwrapper.Win32_CDROMDrive"></see>.
''' </summary>
''' <remarks></remarks>
Public Class Win32_CDROMDrives
    Inherits CIM_MediaAccessDevices

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <param name="DeviceID">If specified, only the item corresponding to this key value is returned. Ignored if <code>Condition</code> is set.</param>
    ''' <param name="Condition">WQL condition can be specified. It is not checked and sent to WMI as is.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Computer As String, Optional ByVal DeviceID As String = Nothing, Optional ByVal Condition As String = Nothing)

        MyBase.New(Computer, "Win32_CDROMDrive")
        ' Prepare condition
        If Condition Is Nothing AndAlso DeviceID IsNot Nothing Then
            Condition = "DeviceID ='" & DeviceID & "'"
        End If
        ' Read the collection
        For Each ManagementObjectI As ManagementObject In Me.Read(Condition)
            Me.Add(New Win32_CDROMDrive(ManagementObjectI))
        Next

    End Sub

    ''' <summary>
    ''' Find an item in the collection.
    ''' </summary>
    ''' <param name="index">Index of the item.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal index As Integer) As Win32_CDROMDrive
        Return CType(List.Item(index), Win32_CDROMDrive)
    End Function

    ''' <summary>
    ''' Find an item by its ID.
    ''' </summary>
    ''' <param name="DeviceID">The device ID.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal DeviceID As String) As Win32_CDROMDrive
        For intI As Integer = 0 To List.Count - 1
            If Me.Item(intI).DeviceID = DeviceID Then
                Return Me.Item(intI)
            End If
        Next
        Return Nothing
    End Function

End Class


Namespace Enums

    ''' <summary>
    ''' File system flags associated with the Windows CD-ROM drive.
    ''' </summary>
    ''' <remarks></remarks>
    <Flags()> _
    Public Enum FileSystemFlagsEx As UInt32

        ''' <summary>
        ''' None.
        ''' </summary>
        ''' <remarks></remarks>
        None = 0

        ''' <summary>
        ''' The file system supports case-sensitive file names.
        ''' </summary>
        ''' <remarks></remarks>
        CASE_SENSITIVE_SEARCH = 1

        ''' <summary>
        ''' The file system preserves the case of file names when it places a name on a disk.
        ''' </summary>
        ''' <remarks></remarks>
        CASE_PRESERVED_NAMES = 2

        ''' <summary>
        ''' The file system supports Unicode in file names as they appear on the disk.
        ''' </summary>
        ''' <remarks></remarks>
        UNICODE_ON_DISK = 4

        ''' <summary>
        ''' The file system preserves and enforces access control lists (ACLs).
        ''' </summary>
        ''' <remarks>For example, the NTFS file system preserves and enforces ACLs and the FAT file system does not.</remarks>
        PERSISTENT_ACLS = 8

        ''' <summary>
        ''' The file system supports file-based compression.
        ''' </summary>
        ''' <remarks></remarks>
        FILE_COMPRESSION = 16

        ''' <summary>
        ''' The file system supports disk quotas.
        ''' </summary>
        ''' <remarks></remarks>
        VOLUME_QUOTAS = 32

        ''' <summary>
        ''' The file system supports spare files.
        ''' </summary>
        ''' <remarks></remarks>
        SUPPORTS_SPARSE_FILES = 64

        ''' <summary>
        ''' The file system supports reparse points.
        ''' </summary>
        ''' <remarks></remarks>
        SUPPORTS_REPARSE_POINTS = 128

        ''' <summary>
        ''' The file system supports the remote storage of files.
        ''' </summary>
        ''' <remarks></remarks>
        SUPPORTS_REMOTE_STORAGE = 256

        ''' <summary>
        ''' The file system supports file names that are longer than eight characters.
        ''' </summary>
        ''' <remarks></remarks>
        SUPPORTS_LONG_NAMES = 16384

        ''' <summary>
        ''' The specified disk volume is a compressed volume, for example, a DougbleSpace volume. 
        ''' </summary>
        ''' <remarks></remarks>
        VOLUME_IS_COMPRESSED = 32768

        ''' <summary>
        ''' The specified volume is read-only.
        ''' </summary>
        ''' <remarks>Windows 2000, Windows NT 4.0, and Windows Me/98/95:  This value is not supported.</remarks>
        READ_ONLY_VOLUME = 524289

        ''' <summary>
        ''' The file system supports object identifiers.
        ''' </summary>
        ''' <remarks></remarks>
        SUPPORTS_OBJECT_IDS = 65536

        ''' <summary>
        ''' The file system supports the Encrypted File System (EFS).
        ''' </summary>
        ''' <remarks></remarks>
        SUPPORTS_ENCRYPTION = 131072

        ''' <summary>
        ''' The file system supports named streams.
        ''' </summary>
        ''' <remarks></remarks>
        SUPPORTS_NAMED_STREAMS = 262144

    End Enum

End Namespace