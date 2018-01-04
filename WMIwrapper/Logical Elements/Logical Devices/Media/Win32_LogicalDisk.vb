Imports System.Management

''' <summary>
''' Represents a data source that resolves to an actual local storage device on a computer system running Windows.
''' </summary>
''' <remarks>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa394173.aspx">MSDN</a>
''' </remarks>
Public Class Win32_LogicalDisk
    Inherits CIM_StorageExtent

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
    ''' Indicates whether the logical volume exists as a single compressed entity, such as a DoubleSpace volume.
    ''' If file based compression is supported, such as on NTFS, this property is False.
    ''' </summary>
    ''' <value></value>
    Public ReadOnly Property Compressed() As Boolean
        Get
            Return GetBooleanProperty("Compressed")
        End Get
    End Property

    ''' <summary>
    ''' Type of disk drive this logical disk represents.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property DriveType() As Enums.DriveType
        Get
            Dim obj As Object = GetPropertyObject("DriveType")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.DriveType)
            End If
        End Get
    End Property

    ''' <summary>
    ''' File system on the logical disk.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property FileSystem() As String
        Get
            Return GetStringProperty("FileSystem")
        End Get
    End Property

    ''' <summary>
    ''' Space, in bytes, available on the logical disk.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property FreeSpace() As UInt64
        Get
            Return GetUint64Property("FreeSpace")
        End Get
    End Property

    ''' <summary>
    ''' Maximum length of a filename component supported by the Windows drive.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' A filename component is that portion of a filename between backslashes.
    ''' The value can be used to indicate that long names are supported by the specified file system.
    ''' For example, for a FAT file system supporting long names, the function stores the value 255, rather than the previous 8.3 indicator.
    ''' Long names can also be supported on systems that use the NTFS file system.
    ''' </remarks>
    Public ReadOnly Property MaximumComponentLength() As UInt32
        Get
            Return GetUint32Property("MaximumComponentLength")
        End Get
    End Property

    ''' <summary>
    ''' Type of media currently present in the logical drive.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>The value may not be exact for removable drives if currently there is no media in the drive.</remarks>
    Public ReadOnly Property MediaType() As UInt32
        Get
            Return GetUint32Property("MediaType")
        End Get
    End Property

    ''' <summary>
    ''' Network path to the logical device.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ProviderName() As String
        Get
            Return GetStringProperty("ProviderName")
        End Get
    End Property

    ''' <summary>
    ''' Indicates that quota management is not enabled (TRUE) on this system.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Windows 2000, Windows NT 4.0, and Windows Me/98/95:  This property is not available.</remarks>
    Public ReadOnly Property QuotasDisabled() As Boolean
        Get
            Return GetBooleanProperty("QuotasDisabled")
        End Get
    End Property

    ''' <summary>
    ''' Indicates that the quota management was used but has been disabled (True).
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' <para>Incomplete refers to the information left in the file system after quota management was disabled.</para>
    ''' <para>Windows 2000, Windows NT 4.0, and Windows Me/98/95:  This property is not available.</para>
    ''' </remarks>
    Public ReadOnly Property QuotasIncomplete() As Boolean
        Get
            Return GetBooleanProperty("QuotasIncomplete")
        End Get
    End Property

    ''' <summary>
    ''' Indicates that the file system is in the active process of compiling information and setting the disk up for quota management.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Windows 2000, Windows NT 4.0, and Windows Me/98/95:  This property is not available.</remarks>
    Public ReadOnly Property QuotasRebuilding() As Boolean
        Get
            Return GetBooleanProperty("QuotasRebuilding")
        End Get
    End Property

    ''' <summary>
    ''' Indicates that  this volume supports disk quotas.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Windows 2000, Windows NT 4.0, and Windows Me/98/95:  This property is not available.</remarks>
    Public ReadOnly Property SupportsDiskQuotas() As Boolean
        Get
            Return GetBooleanProperty("SupportsDiskQuotas")
        End Get
    End Property

    ''' <summary>
    ''' Size of the disk drive.
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
    ''' If True, the logical disk partition supports file-based compression, such as is the case with the NTFS file system.
    ''' This property is False when the <see cref="P:WMIwrapper.Win32_LogicalDisk.Compressed"></see> property is True.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property SupportsFileBasedCompression() As Boolean
        Get
            Return GetBooleanProperty("SupportsFileBasedCompression")
        End Get
    End Property

    ''' <summary>
    ''' If True, the disk requires ChkDsk to be run at the next restart.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' <para>
    ''' This property is only applicable to those instances of logical disk that represent a physical disk in the machine.
    ''' It is not applicable to mapped logical drives.
    ''' </para>
    ''' <para>Windows 2000, Windows NT 4.0, and Windows Me/98/95:  This property is not available.</para>
    ''' </remarks>
    Public ReadOnly Property VolumeDirty() As Boolean
        Get
            Return GetBooleanProperty("VolumeDirty")
        End Get
    End Property

    ''' <summary>
    ''' Volume name of the logical disk.
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
    ''' Volume serial number of the logical disk.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Maximum 11 characters.</remarks>
    Public ReadOnly Property VolumeSerialNumber() As String
        Get
            Return GetStringProperty("VolumeSerialNumber")
        End Get
    End Property

#End Region

#Region "Methods"

    ''' <summary>
    ''' Invokes the chkdsk operation on the disk.
    ''' </summary>
    ''' <param name="FixErrors">
    ''' Indicates what should be done to errors found on the disk.
    ''' If true, then errors are fixed. The default is false.
    ''' </param>
    ''' <param name="VigorousIndexCheck">
    ''' If true, a vigorous check of index entries should be performed.
    ''' The default is true.
    ''' </param>
    ''' <param name="SkipFolderCycle">
    ''' If true, the folder cycle checking should be skipped.
    ''' The default is true.
    ''' </param>
    ''' <param name="ForceDismount">
    ''' If true, the drive should be forced to dismount before checking.
    ''' The default is false.
    ''' </param>
    ''' <param name="RecoverBadSectors">
    ''' If true, the bad sectors should be located and the readable information should be recovered from these sectors.
    ''' The default is false.
    ''' </param>
    ''' <param name="OKToRunAtBootUp">
    ''' If true, the ChkDsk operation should be performed at next boot up time, in case the operation could not be performed because the disk is locked at time this method is called.
    ''' The default is false.
    ''' </param>
    ''' <remarks>
    ''' <para>
    ''' This method is only applicable to those instances of logical disk that represent a physical disk in the machine.
    ''' It is not applicable to mapped logical drives.
    ''' </para>
    ''' <para>
    ''' Windows 2000, Windows NT 4.0, and Windows Me/98/95:  This method is not available.
    ''' </para>
    ''' </remarks>
    Public Function Chkdsk(ByVal FixErrors As Boolean, ByVal VigorousIndexCheck As Boolean, ByVal SkipFolderCycle As Boolean, ByVal ForceDismount As Boolean, ByVal RecoverBadSectors As Boolean, ByVal OKToRunAtBootUp As Boolean) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_LogicalDisk"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("Chkdsk")
        inParams("FixErrors") = FixErrors
        inParams("VigorousIndexCheck") = VigorousIndexCheck
        inParams("SkipFolderCycle") = SkipFolderCycle
        inParams("ForceDismount") = ForceDismount
        inParams("RecoverBadSectors") = RecoverBadSectors
        inParams("OKToRunAtBootUp") = OKToRunAtBootUp

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("Chkdsk", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ChkdskErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Error messages for the <see cref="M:WMIwrapper.Win32_LogicalDisk.Chkdsk"></see> method of this class.
    ''' </summary>
    ''' <param name="Number">Error number.</param>
    ''' <returns>A string containing the error message.</returns>
    ''' <remarks></remarks>
    Protected Function ChkdskErrorMessage(ByVal Number As UInteger) As String
        Select Case Number
            Case 0
                Return "Success - Chkdsk Completed"
            Case 1
                Return "Success - Locked and Chkdsk Scheduled on Reboot"
            Case 2
                Return "Failure - Unknown File System"
            Case 3
                Return "Failure - Unknown Error"
            Case Else
                Return "Unknown error"
        End Select
    End Function

    ''' <summary>
    ''' Excludes disks from the autochk operation to be run at the next reboot.
    ''' </summary>
    ''' <param name="LogicalDisk">
    ''' List of drives that should be excluded from autochk at the next reboot.
    ''' The string syntax consists of the drive letter followed by a colon for the logical disk.
    ''' </param>
    ''' <returns></returns>
    ''' <remarks>
    ''' <para>
    ''' If not excluded, autochk is performed on the disk when the dirty bit is set for the disk.
    ''' Note that the calls to exclude disks are not cumulative.
    ''' If a call is made to exclude some disks, then the new list is not added to the list of disks that are already marked for exclusion.
    ''' The new list of disks overwrites the previous list.
    ''' This method is only applicable to those instances of logical disk that represent a physical disk in the machine.
    ''' It is not applicable to mapped logical drives.
    ''' </para>
    ''' <para>
    ''' Windows 2000, Windows NT 4.0, and Windows Me/98/95:  This method is not available.
    ''' </para>
    ''' </remarks>
    Public Function ExcludeFromAutochk(ByVal LogicalDisk As String()) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_LogicalDisk"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("ExcludeFromAutochk")
        inParams("LogicalDisk") = LogicalDisk

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("ExcludeFromAutochk", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Schedules Autochk to be run on the disk drive represented by the <see cref="T:WMIwrapper.Win32_LogicalDisk"></see> at the next reboot if the dirty bit is set.
    ''' </summary>
    ''' <param name="LogicalDisk">
    ''' Specifies the list of drives to schedule for Autochk at the next reboot.
    ''' The string syntax consists of the drive letter followed by a colon for the logical disk, for example: "C:"
    ''' </param>
    ''' <returns></returns>
    ''' <remarks>
    ''' <para>
    ''' This method is only applicable to those instances of logical disk that represent a physical disk in the machine.
    ''' This method is not applicable to mapped logical drives.
    ''' </para>
    ''' <para>
    ''' Windows 2000, Windows NT 4.0, and Windows Me/98/95:  This method is not available.
    ''' </para>
    ''' </remarks>
    Public Function ScheduleAutoChk(ByVal LogicalDisk As String()) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_LogicalDisk"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("ScheduleAutoChk")
        inParams("LogicalDisk") = LogicalDisk

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("ScheduleAutoChk", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Error messages for the methods of this class.
    ''' </summary>
    ''' <param name="Number">Error number.</param>
    ''' <returns>A string containing the error message.</returns>
    ''' <remarks></remarks>
    Protected Overrides Function ErrorMessage(ByVal Number As UInteger) As String
        Select Case Number
            Case 0
                Return "Success"
            Case 1
                Return "Error - Remote Drive"
            Case 2
                Return "Error - Removable Drive"
            Case 3
                Return "Error - Drive Not Root Directory"
            Case Else
                Return "Error - Unknown Drive"
        End Select
    End Function

#End Region

End Class

''' <summary>
''' Collection of <see cref="T:WMIwrapper.Win32_LogicalDisk"></see>.
''' </summary>
''' <remarks></remarks>
Public Class Win32_LogicalDisks
    Inherits CIM_StorageExtents

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <param name="DeviceID">If specified, only the item corresponding to this key value is returned. Ignored if <code>Condition</code> is set.</param>
    ''' <param name="Condition">WQL condition can be specified. It is not checked and sent to WMI as is.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Computer As String, Optional ByVal DeviceID As String = Nothing, Optional ByVal Condition As String = Nothing)

        MyBase.New(Computer, "Win32_LogicalDisk")
        ' Prepare condition
        If Condition Is Nothing AndAlso DeviceID IsNot Nothing Then
            Condition = "DeviceID ='" & DeviceID & "'"
        End If
        ' Read the collection
        For Each ManagementObjectI As ManagementObject In Me.Read(Condition)
            Me.Add(New Win32_LogicalDisk(ManagementObjectI))
        Next

    End Sub

    ''' <summary>
    ''' Find an item in the collection.
    ''' </summary>
    ''' <param name="index">Index of the item.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal index As Integer) As Win32_LogicalDisk
        Return CType(List.Item(index), Win32_LogicalDisk)
    End Function

    ''' <summary>
    ''' Find an item by its ID.
    ''' </summary>
    ''' <param name="DeviceID">The device ID.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal DeviceID As String) As Win32_LogicalDisk
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
    ''' Numeric value that corresponds to the type of disk drive this logical disk represents.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum DriveType As UInt32

        ''' <summary>
        ''' Unknown.
        ''' </summary>
        ''' <remarks></remarks>
        Unknown

        ''' <summary>
        ''' No Root Directory.
        ''' </summary>
        ''' <remarks></remarks>
        NoRootDirectory

        ''' <summary>
        ''' Removable Disk.
        ''' </summary>
        ''' <remarks></remarks>
        RemovableDisk

        ''' <summary>
        ''' Local Disk.
        ''' </summary>
        ''' <remarks></remarks>
        LocalDisk

        ''' <summary>
        ''' Network Drive.
        ''' </summary>
        ''' <remarks></remarks>
        NetworkDrive

        ''' <summary>
        ''' Compact Disc.
        ''' </summary>
        ''' <remarks></remarks>
        CompactDisc

        ''' <summary>
        ''' RAM Disk.
        ''' </summary>
        ''' <remarks></remarks>
        RAMDisk

    End Enum

    ''' <summary>
    ''' Type of media currently present in the logical drive.
    ''' The value may not be exact for removable drives if currently there is no media in the drive.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum MediaType As UInt32

        ''' <summary>
        ''' Unknown.
        ''' </summary>
        ''' <remarks></remarks>
        Unknown = 0

        ''' <summary>
        ''' 5 1/4-Inch Floppy Disk - 1.2 MB - 512 bytes/sector.
        ''' </summary>
        ''' <remarks></remarks>
        F5_1Pt2_512

        ''' <summary>
        ''' 3 1/2-Inch Floppy Disk - 1.44 MB -512 bytes/sector.
        ''' </summary>
        ''' <remarks></remarks>
        F3_1Pt44_512

        ''' <summary>
        ''' 3 1/2-Inch Floppy Disk - 2.88 MB - 512 bytes/sector.
        ''' </summary>
        ''' <remarks></remarks>
        F3_2Pt88_512

        ''' <summary>
        ''' 3 1/2-Inch Floppy Disk - 20.8 MB - 512 bytes/sector.
        ''' </summary>
        ''' <remarks></remarks>
        F3_20Pt8_512

        ''' <summary>
        ''' 3 1/2-Inch Floppy Disk - 720 KB - 512 bytes/sector.
        ''' </summary>
        ''' <remarks></remarks>
        F3_720_512

        ''' <summary>
        ''' 5 1/4-Inch Floppy Disk - 360 KB - 512 bytes/sector.
        ''' </summary>
        ''' <remarks></remarks>
        F5_360_512

        ''' <summary>
        ''' 5 1/4-Inch Floppy Disk - 320 KB - 512 bytes/sector.
        ''' </summary>
        ''' <remarks></remarks>
        F5_320_512

        ''' <summary>
        ''' 5 1/4-Inch Floppy Disk - 320 KB - 1024 bytes/sector.
        ''' </summary>
        ''' <remarks></remarks>
        F5_320_1024

        ''' <summary>
        ''' 5 1/4-Inch Floppy Disk - 180 KB - 512 bytes/sector.
        ''' </summary>
        ''' <remarks></remarks>
        F5_180_512

        ''' <summary>
        ''' 5 1/4-Inch Floppy Disk - 160 KB - 512 bytes/sector.
        ''' </summary>
        ''' <remarks></remarks>
        F5_160_512

        ''' <summary>
        '''  Removable media other than floppy.
        ''' </summary>
        ''' <remarks></remarks>
        RemovableMediaOtherThanFloppy

        ''' <summary>
        ''' Fixed hard disk media.
        ''' </summary>
        ''' <remarks></remarks>
        FixedHardDiskMedia

        ''' <summary>
        ''' 3 1/2-Inch Floppy Disk - 120 MB - 512 bytes/sector.
        ''' </summary>
        ''' <remarks></remarks>
        F3_120M_512

        ''' <summary>
        ''' 3 1/2-Inch Floppy Disk - 640 KB - 512 bytes/sector.
        ''' </summary>
        ''' <remarks></remarks>
        F3_640_512

        ''' <summary>
        ''' 5 1/4-Inch Floppy Disk - 640 KB - 512 bytes/sector.
        ''' </summary>
        ''' <remarks></remarks>
        F5_640_512

        ''' <summary>
        ''' 5 1/4-Inch Floppy Disk - 720 KB - 512 bytes/sector.
        ''' </summary>
        ''' <remarks></remarks>
        F5_720_512

        ''' <summary>
        ''' 3 1/2-Inch Floppy Disk - 1.2 MB - 512 bytes/sector.
        ''' </summary>
        ''' <remarks></remarks>
        F3_1Pt2_512

        ''' <summary>
        ''' 3 1/2-Inch Floppy Disk - 1.23 MB - 1024 bytes/sector.
        ''' </summary>
        ''' <remarks></remarks>
        F3_1Pt23_1024

        ''' <summary>
        ''' 5 1/4-Inch Floppy Disk - 1.23 MB - 1024 bytes/sector.
        ''' </summary>
        ''' <remarks></remarks>
        F5_1Pt23_1024

        ''' <summary>
        ''' 3 1/2-Inch Floppy Disk - 128 MB - 512 bytes/sector.
        ''' </summary>
        ''' <remarks></remarks>
        F3_128Mb_512

        ''' <summary>
        ''' 3 1/2-Inch Floppy Disk - 230 MB - 512 bytes/sector.
        ''' </summary>
        ''' <remarks></remarks>
        F3_230Mb_512

        ''' <summary>
        ''' 8-Inch Floppy Disk - 256 KB - 128 bytes/sector .
        ''' </summary>
        ''' <remarks></remarks>
        F8_256_128

    End Enum

End Namespace
