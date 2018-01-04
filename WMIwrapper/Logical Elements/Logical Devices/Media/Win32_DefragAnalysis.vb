Imports System.Management

''' <summary>
''' Represents fragmentation values on a volume.
''' </summary>
''' <remarks>
''' <para>
''' An instance of the Win32_DefragAnalysis class is passed as an out parameter from the <see cref="P:WMIwrapper.Win32_Volume.DefragAnalysis"></see> and <see cref="M:WMIwrapper.Win32_Volume.Defrag"></see> methods.</para>
''' <para>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa394119.aspx">MSDN</a>.
''' </para>
''' </remarks>
Public Class Win32_DefragAnalysis
    Inherits WMIobject

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

#Region "Properties"

    ''' <summary>
    ''' Average size of the files on a volume, in bytes.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property AverageFileSize() As UInt64
        Get
            Return GetUint64Property("AverageFileSize")
        End Get
    End Property

    ''' <summary>
    ''' Average number of fragments per file on a volume.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property AverageFragmentsPerFile() As Double
        Get
            Return GetDoubleProperty("AverageFragmentsPerFile")
        End Get
    End Property

    ''' <summary>
    ''' Average size of free space extents on the volume.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property AverageFreeSpacePerExtent() As Double
        Get
            Return GetDoubleProperty("AverageFreeSpacePerExtent")
        End Get
    End Property

    ''' <summary>
    ''' Size, in bytes, of the file system allocation unit.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ClusterSize() As UInt64
        Get
            Return GetUint64Property("ClusterSize")
        End Get
    End Property

    ''' <summary>
    ''' Number of excess folder fragments on a volume.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ExcessFolderFragments() As UInt64
        Get
            Return GetUint64Property("ExcessFolderFragments")
        End Get
    End Property

    ''' <summary>
    ''' Percentage of files on a volume that are fragmented.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property FilePercentFragmentation() As UInt32
        Get
            Return GetUint32Property("FilePercentFragmentation")
        End Get
    End Property

    ''' <summary>
    ''' Number of fragmented folders (subdirectories) on a volume.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property FragmentedFolders() As UInt64
        Get
            Return GetUint64Property("FragmentedFolders")
        End Get
    End Property

    ''' <summary>
    ''' Number of bytes currently available for use on a volume.
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
    ''' Percent of volume that is free space.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property FreeSpacePercent() As UInt32
        Get
            Return GetUint32Property("FreeSpacePercent")
        End Get
    End Property

    ''' <summary>
    ''' Percentage of free space on a volume that is fragmented.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' Starting with Windows Vista, this property is obsolete. Instead, use <see cref="P:WMIwrapper.Win32_DefragAnalysis.AverageFreeSpacePerExtent"></see>, <see cref="P:WMIwrapper.Win32_DefragAnalysis.LargestFreeSpaceExtent"></see>,
    ''' and <see cref="P:WMIwrapper.Win32_DefragAnalysis.TotalFreeSpaceExtents"></see> to determine the free space fragmentation state of a volume.
    ''' </remarks>
    Public ReadOnly Property FreeSpacePercentFragmentation() As UInt32
        Get
            Return GetUint32Property("FreeSpacePercentFragmentation")
        End Get
    End Property

    ''' <summary>
    ''' Size of the largest free space extent on the volume.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Windows Server 2003:  This property is not available.</remarks>
    Public ReadOnly Property LargestFreeSpaceExtent() As UInt64
        Get
            Return GetUint64Property("LargestFreeSpaceExtent")
        End Get
    End Property

    ''' <summary>
    ''' Percentage of the Master File Table that is in use.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property MFTPercentInUse() As UInt32
        Get
            Return GetUint32Property("MFTPercentInUse")
        End Get
    End Property

    ''' <summary>
    ''' Number of records in the Master File Table on a volume.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property MFTRecordCount() As UInt64
        Get
            Return GetUint64Property("MFTRecordCount")
        End Get
    End Property

    ''' <summary>
    ''' Size of a page file on a volume, in bytes.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' If there is no page file on a volume, this property is NULL.
    ''' Starting with Windows Vista, this property is obsolete.
    ''' The value is always zero and there is no substitute property to use in this class.
    ''' </remarks>
    Public ReadOnly Property PageFileSize() As UInt64
        Get
            Return GetUint64Property("PageFileSize")
        End Get
    End Property

    ''' <summary>
    ''' Number of excess file fragments on a volume.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property TotalExcessFragments() As UInt64
        Get
            Return GetUint64Property("TotalExcessFragments")
        End Get
    End Property

    ''' <summary>
    ''' Number of files on a volume.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property TotalFiles() As UInt64
        Get
            Return GetUint64Property("TotalFiles")
        End Get
    End Property

    ''' <summary>
    ''' Number of folders (subdirectories) on a volume.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property TotalFolders() As UInt64
        Get
            Return GetUint64Property("TotalFolders")
        End Get
    End Property

    ''' <summary>
    ''' Number of fragmented files on a volume.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property TotalFragmentedFiles() As UInt64
        Get
            Return GetUint64Property("TotalFragmentedFiles")
        End Get
    End Property

    ''' <summary>
    ''' Total number of free space extents on the volume.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Windows Server 2003:  This property is not available.</remarks>
    Public ReadOnly Property TotalFreeSpaceExtents() As UInt64
        Get
            Return GetUint64Property("TotalFreeSpaceExtents")
        End Get
    End Property

    ''' <summary>
    ''' Number of Master File Table fragments on a volume.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property TotalMFTFragments() As UInt64
        Get
            Return GetUint64Property("TotalMFTFragments")
        End Get
    End Property

    ''' <summary>
    ''' Number of fragments for a page file.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' If there is no page file on a volume, this property is NULL.
    ''' Starting with Windows Vista, this property is obsolete.
    ''' The value is always zero and there is no substitute property to use in this class.
    ''' </remarks>
    Public ReadOnly Property TotalPageFileFragments() As UInt64
        Get
            Return GetUint64Property("TotalPageFileFragments")
        End Get
    End Property

    ''' <summary>
    ''' Percent of the volume that is fragmented.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' Starting with Windows Vista, this property is obsolete.
    ''' Instead, use <see cref="P:WMIwrapper.Win32_DefragAnalysis.FilePercentFragmentation"></see> to determine whether the volume should be defragmented.
    ''' The <see cref="P:WMIwrapper.Win32_DefragAnalysis.AverageFreeSpacePerExtent"></see>, <see cref="P:WMIwrapper.Win32_DefragAnalysis.LargestFreeSpaceExtent"></see>, and <see cref="P:WMIwrapper.Win32_DefragAnalysis.TotalFreeSpaceExtents"></see> properties report the free space fragmentation state of the volume.
    ''' </remarks>
    Public ReadOnly Property TotalPercentFragmentation() As UInt32
        Get
            Return GetUint32Property("TotalPercentFragmentation")
        End Get
    End Property

    ''' <summary>
    ''' Total number of immovable files on the volume.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Windows Server 2003:  This property is not available.</remarks>
    Public ReadOnly Property TotalUnmoveableFiles() As UInt64
        Get
            Return GetUint64Property("TotalUnmoveableFiles")
        End Get
    End Property

    ''' <summary>
    ''' Number of bytes currently used on a volume.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property UsedSpace() As UInt64
        Get
            Return GetUint64Property("UsedSpace")
        End Get
    End Property

    ''' <summary>
    ''' Name of the volume for which this report is generated.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>This property can be the drive letter, mount point, or the volume GUID name.</remarks>
    Public ReadOnly Property VolumeName() As String
        Get
            Return GetStringProperty("VolumeName")
        End Get
    End Property

    ''' <summary>
    ''' Total size of a volume—in bytes.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property VolumeSize() As UInt64
        Get
            Return GetUint64Property("VolumeSize")
        End Get
    End Property

#End Region

End Class

' This class cannot be enumerated.