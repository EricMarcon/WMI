Imports System.Management

''' <summary>
''' Represents an area of storage on a hard disk.
''' </summary>
''' <remarks>
''' The class returns local volumes that are formatted, unformatted, mounted, or offline.
''' A volume is formatted by using a file system, such as FAT or NTFS, and might have a drive letter assigned to it.
''' One hard disk can have multiple volumes, and volumes can span multiple physical disks.
''' The Win32_Volume class does not support disk drive management.
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa394515(VS.85).aspx">MSDN</a>
''' </remarks>
Public Class Win32_Volume
    Inherits CIM_StorageVolume

    ''' <summary>
    ''' Constructor. 
    ''' </summary>
    ''' <param name="ManagementObject">The underlying management object.</param>
    ''' <remarks>Use this constructor when the management object already exists (e.g. read from a collection).</remarks>
    Public Sub New(ByVal ManagementObject As ManagementObject)
        MyBase.New(ManagementObject)
    End Sub

    ''' <summary>
    ''' Constructor. 
    ''' </summary>
    ''' <param name="ManagementBaseObject">The underlying management base object.</param>
    ''' <remarks>
    ''' Alternate constructor, to use when a management base object is available instead of a management object.
    ''' Management base objects are returned as out parameters of methods.
    ''' </remarks>
    Public Sub New(ByVal ManagementBaseObject As ManagementBaseObject)
        MyBase.New(ManagementBaseObject)
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


#Region "Properties"

    ''' <summary>
    ''' If true, the volume is mounted to the file system automatically when the first I/O is issued.
    ''' If false, the volume is not mounted until explicitly mounted by using the <see cref="M:WMIwrapper.Win32_Volume.Mount"></see> method, or by adding a drive letter or mount point.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Automount() As Boolean
        Get
            Return GetBooleanProperty("Automount")
        End Get
    End Property

    ''' <summary>
    ''' If true, the volume contains the boot files for the current OS.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property BootVolume() As Boolean
        Get
            Return GetBooleanProperty("BootVolume")
        End Get
    End Property

    ''' <summary>
    ''' Size of the volume in bytes.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    Public ReadOnly Property Capacity() As UInt64
        Get
            Return GetUint64Property("Capacity")
        End Get
    End Property

    ''' <summary>
    ''' If true, the volume exists as one compressed entity, such as a DoubleSpace volume.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>If file-based compression is supported, such as the NTFS file system, this property is false.</remarks>
    Public ReadOnly Property Compressed() As Boolean
        Get
            Return GetBooleanProperty("Compressed")
        End Get
    End Property

    ''' <summary>
    ''' If true, the <see cref="M:WMIwrapper.Win32_Volume.Chkdsk"></see> method is automatically run by the system at the next restart.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    Public ReadOnly Property DirtyBitSet() As Boolean
        Get
            Return GetBooleanProperty("DirtyBitSet")
        End Get
    End Property

    ''' <summary>
    ''' Drive letter assigned to a volume.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>This property is NULL for volumes without drive letters.</remarks>
    Public ReadOnly Property DriveLetter() As String
        Get
            Return GetStringProperty("DriveLetter")
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
    ''' Space, in bytes, available on the volume.
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
    ''' If true, context indexing is enabled.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    Public ReadOnly Property IndexingEnabled() As Boolean
        Get
            Return GetBooleanProperty("IndexingEnabled")
        End Get
    End Property

    ''' <summary>
    ''' Volume name of the logical disk.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' This property is null for volumes without a label.
    ''' For FAT and FAT32 systems, the maximum length is 11 characters.
    ''' For NTFS file systems, the maximum length is 32 characters.
    ''' </remarks>
    Public ReadOnly Property Label() As String
        Get
            Return GetStringProperty("Label")
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
    Public ReadOnly Property MaximumFileNameLength() As UInt32
        Get
            Return GetUint32Property("MaximumFileNameLength")
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
    ''' If true, the volume contains a memory page file.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    Public ReadOnly Property PageFilePresent() As Boolean
        Get
            Return GetBooleanProperty("PageFilePresent")
        End Get
    End Property

    ''' <summary>
    ''' Indicates that quota management is enabled on this volume.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    Public ReadOnly Property QuotasEnabled() As Boolean
        Get
            Return GetBooleanProperty("QuotasEnabled")
        End Get
    End Property

    ''' <summary>
    ''' Indicates that the quota management was used but has been disabled (True).
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' Incomplete refers to the information left in the file system after quota management was disabled.
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
    Public ReadOnly Property QuotasRebuilding() As Boolean
        Get
            Return GetBooleanProperty("QuotasRebuilding")
        End Get
    End Property

    ''' <summary>
    ''' Serial number of the volume.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Example: A8C3D032.</remarks>
    Public ReadOnly Property SerialNumber() As String
        Get
            Return GetStringProperty("SerialNumber")
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
    ''' If true, the volume supports file-based compression—like the NTFS file system.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    Public ReadOnly Property SupportsFileBasedCompression() As Boolean
        Get
            Return GetBooleanProperty("SupportsFileBasedCompression")
        End Get
    End Property

    ''' <summary>
    ''' If True, the disk contains the system files.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    Public ReadOnly Property SystemVolume() As Boolean
        Get
            Return GetBooleanProperty("SystemVolume")
        End Get
    End Property

#End Region

#Region "Methods"

    ''' <summary>
    ''' Adds a mount point directory for the volume.
    ''' </summary>
    ''' <param name="Directory">
    ''' Directory where the volume is to be mounted.
    ''' </param>
    ''' <remarks>
    ''' The result of this method is the creation of a <see cref="T:WMIwrapper.Win32_MountPoint"></see> class associating this volume with the <see cref="T:WMIwrapper.Win32_Directory"></see> instance representing the directory specified in the parameter list.
    ''' </remarks>
    Public Function AddMountPoint(ByVal Directory As String) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_Volume"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("AddMountPoint")
        inParams("Directory") = Directory

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("AddMountPoint", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.AddMountPointErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Error messages for the <see cref="M:WMIwrapper.Win32_Volume.AddMountPoint"></see> method of this class.
    ''' </summary>
    ''' <param name="Number">Error number.</param>
    ''' <returns>A string containing the error message.</returns>
    ''' <remarks></remarks>
    Protected Function AddMountPointErrorMessage(ByVal Number As UInteger) As String
        Select Case Number
            Case 0
                Return "Success"
            Case 1
                Return "Access Denied"
            Case 2
                Return "Invalid Argument"
            Case 3
                Return "Specified Directory Not Empty"
            Case 4
                Return "Specified Directory Not Found"
            Case 5
                Return "Volume Mount Points Not Supported"
            Case 6
                Return "Unknown Error"
            Case Else
                Return "Unreferenced Error"
        End Select
    End Function

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
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_Volume"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("Chkdsk")
        inParams("FixErrors") = FixErrors
        inParams("VigorousIndexCheck") = VigorousIndexCheck
        inParams("SkipFolderCycle") = SkipFolderCycle
        inParams("ForceDismount") = ForceDismount
        inParams("RecoverBadSectors") = RecoverBadSectors
        inParams("OKToRunAtBootUp") = OKToRunAtBootUp

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("ExcludeFromAutochk", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ChkdskErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Error messages for the <see cref="M:WMIwrapper.Win32_Volume.Chkdsk"></see> method of this class.
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

    Protected _DefragResult As Win32_DefragAnalysis
    ''' <summary>
    ''' Contains the properties that describe the extent to which the volume is fragmented.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Set by <see cref="M:WMIwrapper.Win32_Volume.Defrag"></see>.</remarks>
    Public ReadOnly Property DefragResult() As Win32_DefragAnalysis
        Get
            Return _DefragResult
        End Get
    End Property
    Public Function Defrag(ByVal Force As Boolean) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_Volume"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("Defrag")
        inParams("Force") = Force

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("Defrag", inParams)

        ' Treat the result if OK. 
        If InvokeReturn.ReturnValue = 0 Then
            ' The base management object containing the Win32_DefragAnalysis is in DefragAnalysis property of OutParams
            _DefragResult = New Win32_DefragAnalysis(CType(InvokeReturn.outParams.Properties.Item("DefragAnalysis").Value, ManagementBaseObject))
        End If

        Return New InvokeError(InvokeReturn.ReturnValue, Me.DefragErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Error messages for the <see cref="M:WMIwrapper.Win32_Volume.Defrag"></see> method of this class.
    ''' </summary>
    ''' <param name="Number">Error number.</param>
    ''' <returns>A string containing the error message.</returns>
    ''' <remarks></remarks>
    Protected Function DefragErrorMessage(ByVal Number As UInteger) As String
        Select Case Number
            Case 0
                Return "Success"
            Case 1
                Return "Access Denied"
            Case 2
                Return "Not Supported"
            Case 3
                Return "Volume Dirty Bit Is Set"
            Case 4
                Return "Not Enough Free Space"
            Case 5
                Return "Corrupt Master File Table Detected"
            Case 6
                Return "Call Canceled"
            Case 7
                Return "Call Cancellation Request Too Late"
            Case 8
                Return "Defrag Engine Is Already Running"
            Case 9
                Return "Unable To Connect To Defrag Engine"
            Case 10
                Return "Defrag Engine Error"
            Case 11
                Return "Unknown Error"
            Case Else
                Return "Unreferenced Error"
        End Select
    End Function

    Protected _DefragRecommended As Boolean
    ''' <summary>
    ''' Indicates defragmentation is recommended.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' Set by <see cref="M:WMIwrapper.Win32_Volume.DefragAnalysis"></see>.
    ''' On Windows Vista, this value will be true if the file fragmentation on the volume exceeds 10%.
    ''' On earlier versions of Windows, this value will be true if the average of the percent file fragmentation and percent free space fragmentation of the volume exceeds 10%.
    ''' </remarks>
    Public ReadOnly Property DefragRecommended() As Boolean
        Get
            Return _DefragRecommended
        End Get
    End Property

    Protected _DefragAnalysisResult As Win32_DefragAnalysis
    ''' <summary>
    ''' Contains the properties that describe the extent to which the volume is fragmented.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Set by <see cref="M:WMIwrapper.Win32_Volume.DefragAnalysis"></see>.</remarks>
    Public ReadOnly Property DefragAnalysisResult() As Win32_DefragAnalysis
        Get
            Return _DefragAnalysisResult
        End Get
    End Property

    ''' <summary>
    ''' Generates a fragmentation analysis for a volume.
    ''' </summary>
    Public Function DefragAnalysis() As InvokeError

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("DefragAnalysis")

        ' Treat the result if OK. 
        If InvokeReturn.ReturnValue = 0 Then
            _DefragRecommended = CType(InvokeReturn.outParams.Properties.Item("DefragRecommended").Value, Boolean)
            ' The base management object containing the Win32_DefragAnalysis is in DefragAnalysis property of OutParams
            _DefragAnalysisResult = New Win32_DefragAnalysis(CType(InvokeReturn.outParams.Properties.Item("DefragAnalysis").Value, ManagementBaseObject))
        End If

        Return New InvokeError(InvokeReturn.ReturnValue, Me.DefragAnalysisErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Error messages for the <see cref="M:WMIwrapper.Win32_Volume.DefragAnalysis"></see> method of this class.
    ''' </summary>
    ''' <param name="Number">Error number.</param>
    ''' <returns>A string containing the error message.</returns>
    ''' <remarks></remarks>
    Protected Function DefragAnalysisErrorMessage(ByVal Number As UInteger) As String
        Select Case Number
            Case 0
                Return "Success"
            Case 1
                Return "Access Denied"
            Case 2
                Return "Not Supported"
            Case 3
                Return "Volume Dirty Bit Is Set"
            Case 4
                Return "Not Enough Free Space"
            Case 5
                Return "Corrupt Master File Table Detected"
            Case 6
                Return "Call Canceled"
            Case 7
                Return "Call Cancellation Request Too Late"
            Case 8
                Return "Defrag Engine Is Already Running"
            Case 9
                Return "Unable To Connect To Defrag Engine"
            Case 11
                Return "Unknown Error"
            Case Else
                Return "Unreferenced Error"
        End Select
    End Function

    ''' <summary>
    ''' Dismounts a volume from the file system.
    ''' </summary>
    ''' <param name="Force">
    ''' If true, the volume is dismounted even if there are open handles. The default is false.
    ''' </param>
    ''' <param name="Permanent">
    ''' If true, the volume is dismounted to a no-automount, offline state.
    ''' The volume may be returned to the automount state by explicitly calling the <see cref="M:WMIwrapper.Win32_Volume.Mount"></see> method, or by creating a mount point for the volume.
    ''' The default is false.
    ''' </param>
    ''' <remarks>
    ''' </remarks>
    Public Function Dismount(Optional ByVal Force As Boolean = False, Optional ByVal Permanent As Boolean = False) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_Volume"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("Dismount")
        inParams("Force") = Force
        inParams("Permanent") = Permanent

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("Dismount", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.DismountErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Error messages for the <see cref="M:WMIwrapper.Win32_Volume.Dismount"></see> method of this class.
    ''' </summary>
    ''' <param name="Number">Error number.</param>
    ''' <returns>A string containing the error message.</returns>
    ''' <remarks></remarks>
    Protected Function DismountErrorMessage(ByVal Number As UInteger) As String
        Select Case Number
            Case 0
                Return "Success"
            Case 1
                Return "Access Denied"
            Case 2
                Return "Volume Has Mount Points"
            Case 3
                Return "Volume Does Not Support The No-Autoremount State"
            Case 4
                Return "Force Option Required"
            Case Else
                Return "Unreferenced Error"
        End Select
    End Function

    ''' <summary>
    ''' Excludes disks from the autochk operation to be run at the next reboot.
    ''' </summary>
    ''' <param name="Volume">
    ''' List of volumes that should be excluded from autochk at the next reboot.
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
    Public Function ExcludeFromAutochk(ByVal Volume As String()) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_Volume"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("ExcludeFromAutochk")
        inParams("Volume") = Volume

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("ExcludeFromAutochk", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ExcludeFromAutochkErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Error messages for the <see cref="M:WMIwrapper.Win32_Volume.ExcludeFromAutochk"></see> method of this class.
    ''' </summary>
    ''' <param name="Number">Error number.</param>
    ''' <returns>A string containing the error message.</returns>
    ''' <remarks></remarks>
    Protected Function ExcludeFromAutochkErrorMessage(ByVal Number As UInteger) As String
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

    ''' <summary>
    ''' Formats the volume.
    ''' </summary>
    ''' <param name="QuickFormat">
    ''' If true, formats the volume with a quick format by removing files from the disk without scanning the disk for bad sectors.
    ''' Use this option only if the disk has been previously formatted, and you know that the disk is not damaged.
    ''' The default is false.
    ''' </param>
    ''' <param name="FileSystem">
    ''' File system format to use for this volume.
    ''' Possible values are "NTFS", "FAT32", "FAT".
    ''' </param>
    ''' <param name="ClusterSize">
    ''' Disk allocation unit size—cluster size.
    ''' All of the file systems used by this version of Windows organize the hard disk based on cluster size, which represents the smallest amount of disk space that can be allocated to hold a file.
    ''' The smaller the cluster size you use, the more efficiently your disk stores information.
    ''' If no cluster size is specified during format, Windows picks defaults based on the size of the volume.
    ''' These defaults have been selected to reduce the amount of space lost and to reduce fragmentation.
    ''' For general use, the default settings are strongly recommended.
    ''' </param>
    ''' <param name="Label">
    ''' Label to use for the new volume.
    ''' The volume label can contain up to 11 characters for FAT and FAT32 volumes, and up to 32 characters for NTFS file system volumes.
    ''' </param>
    ''' <param name="EnableCompression ">
    ''' Not implemented.
    ''' </param>
    Public Function Format(ByVal QuickFormat As Boolean, Optional ByVal FileSystem As String = "NTFS", Optional ByVal ClusterSize As UInt32 = 4096, Optional ByVal Label As String = "", Optional ByVal EnableCompression As Boolean = False) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_Volume"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("Format")
        inParams("QuickFormat") = QuickFormat
        inParams("FileSystem") = FileSystem
        inParams("ClusterSize") = ClusterSize
        inParams("Label") = Label
        inParams("EnableCompression") = EnableCompression

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("Format", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.FormatErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Error messages for the <see cref="M:WMIwrapper.Win32_Volume.Format"></see> method of this class.
    ''' </summary>
    ''' <param name="Number">Error number.</param>
    ''' <returns>A string containing the error message.</returns>
    ''' <remarks></remarks>
    Protected Function FormatErrorMessage(ByVal Number As UInteger) As String
        Select Case Number
            Case 0
                Return "Success"
            Case 1
                Return "Unsupported file system"
            Case 2
                Return "Incompatible media in drive"
            Case 3
                Return "Access denied"
            Case 4
                Return "Call canceled"
            Case 5
                Return "Call cancellation request too late"
            Case 6
                Return "Volume write protected"
            Case 7
                Return "Volume lock failed"
            Case 8
                Return "Unable to quick format"
            Case 9
                Return "Input/Output (I/O) error"
            Case 10
                Return "Invalid volume label"
            Case 11
                Return "No media in drive"
            Case 12
                Return "Volume is too small"
            Case 13
                Return "Volume is too large"
            Case 14
                Return "Volume is not mounted"
            Case 15
                Return "Cluster size is too small"
            Case 16
                Return "Cluster size is too large"
            Case 17
                Return "Cluster size is beyond 32 bits"
            Case 18
                Return "Unknown error"
            Case Else
                Return "Unreferenced Error"
        End Select
    End Function

    ''' <summary>
    ''' Mounts a volume to the file system.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    Public Function Mount() As InvokeError

        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("Delete")
        Return New InvokeError(InvokeReturn.ReturnValue, Me.MountErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Error messages for the <see cref="M:WMIwrapper.Win32_Volume.Mount"></see> method of this class.
    ''' </summary>
    ''' <param name="Number">Error number.</param>
    ''' <returns>A string containing the error message.</returns>
    ''' <remarks></remarks>
    Protected Function MountErrorMessage(ByVal Number As UInteger) As String
        Select Case Number
            Case 0
                Return "Success"
            Case 1
                Return "Access Denied"
            Case 2
                Return "Unknown Error"
            Case Else
                Return "Unreferenced Error"
        End Select
    End Function

    ''' <summary>
    ''' Schedules AutoChk to be run at the next reboot if the volume's dirty bit has been set.
    ''' </summary>
    ''' <param name="Volume">
    ''' List of volumes scheduled for AutoChk at the next reboot.
    ''' The string consists of the drive letter, mount point name, or volume globally unique identifier (GUID) name.
    ''' </param>
    ''' <remarks>
    ''' The method is only applicableto those volume instances that represent a physical disk.
    ''' It is not applicable to mapped logical drives.
    ''' </remarks>
    Public Function ScheduleAutoChk(ByVal Volume As String()) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_Volume"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("ScheduleAutoChk")
        inParams("Volume") = Volume

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("ScheduleAutoChk", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ScheduleAutoChkErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Error messages for the <see cref="M:WMIwrapper.Win32_Volume.ScheduleAutoChk"></see> method of this class.
    ''' </summary>
    ''' <param name="Number">Error number.</param>
    ''' <returns>A string containing the error message.</returns>
    ''' <remarks></remarks>
    Protected Function ScheduleAutoChkErrorMessage(ByVal Number As UInteger) As String
        Select Case Number
            Case 0
                Return "Success"
            Case 1
                Return "Remote Drive"
            Case 2
                Return "Removable Drive"
            Case 3
                Return "Drive Not Root Directory"
            Case 4
                Return "Unknown Drive"
            Case Else
                Return "Unreferenced Error"
        End Select
    End Function

#End Region

End Class

''' <summary>
''' Collection of <see cref="T:WMIwrapper.Win32_Volume"></see>.
''' </summary>
''' <remarks></remarks>
Public Class Win32_Volumes
    Inherits CIM_StorageVolumes

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <param name="DeviceID">If specified, only the item corresponding to this key value is returned. Ignored if <code>Condition</code> is set.</param>
    ''' <param name="Condition">WQL condition can be specified. It is not checked and sent to WMI as is.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Computer As String, Optional ByVal DeviceID As String = Nothing, Optional ByVal Condition As String = Nothing)

        MyBase.New(Computer, "Win32_Volume")
        ' Prepare condition
        If Condition Is Nothing AndAlso DeviceID IsNot Nothing Then
            Condition = "DeviceID ='" & DeviceID & "'"
        End If
        ' Read the collection
        For Each ManagementObjectI As ManagementObject In Me.Read(Condition)
            Me.Add(New Win32_Volume(ManagementObjectI))
        Next

    End Sub

    ''' <summary>
    ''' Find an item by its index.
    ''' </summary>
    ''' <param name="Index">The index of the item in the collection.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal Index As Integer) As Win32_Volume
        Return CType(List.Item(Index), Win32_Volume)
    End Function

    ''' <summary>
    ''' Find an item by its ID.
    ''' </summary>
    ''' <param name="DeviceID">The device ID.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal DeviceID As String) As Win32_Volume
        For intI As Integer = 0 To List.Count - 1
            If Me.Item(intI).DeviceID = DeviceID Then
                Return Me.Item(intI)
            End If
        Next
        Return Nothing
    End Function

 
End Class