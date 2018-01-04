Imports System.Management

''' <summary>
''' Storage extent WMI class.
''' </summary>
''' <remarks>
''' The CIM_StorageExtent class represents the capabilities and management of the various media that exist to store data and allow data retrieval. This parent class can represent the various components of RAID (hardware or software) or a raw logical extent on top of physical media.
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa388496.aspx">MSDN.</a>
''' </remarks>
Public MustInherit Class CIM_StorageExtent
    Inherits CIM_LogicalDevice

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

    ''' <summary>
    ''' Describes the read/write properties of the media.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Access() As CIM_StorageExtents.Access
        Get
            Dim obj As Object = GetPropertyObject("Access")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, CIM_StorageExtents.Access)
            End If
        End Get
    End Property

    ''' <summary>
    ''' Size, in bytes, of the blocks that form the storage extent.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' If variable block size, then the maximum block size, in bytes, should be specified.
    ''' If the block size is unknown, or if a block concept is not valid (for example, for aggregate extents, memory, or logical disks), enter a 1 (one).
    ''' </remarks>
    Public ReadOnly Property BlockSize() As UInt64
        Get
            Return GetUint64Property("BlockSize")
        End Get
    End Property

    ''' <summary>
    ''' Free-form string that describes the type of error detection and correction supported by the storage extent.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ErrorMethodology() As String
        Get
            Return GetStringProperty("ErrorMethodology")
        End Get
    End Property

    ''' <summary>
    ''' Number of consecutive blocks, each block the size of the value contained in the BlockSize property, that form the storage extent.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' Total size of the storage extent can be calculated by multiplying the value of the <see cref="P:WMIwrapper.CIM_StorageExtent.BlockSize"></see> property by the value of this property.
    ''' If the value of <see cref="P:WMIwrapper.CIM_StorageExtent.BlockSize"></see> is 1 (one), this property is the total size of the storage extent.
    ''' </remarks>
    Public ReadOnly Property NumberOfBlocks() As UInt64
        Get
            Return GetUint64Property("NumberOfBlocks")
        End Get
    End Property

    ''' <summary>
    ''' Free form string that describes the media and its use.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Purpose() As String
        Get
            Return GetStringProperty("Purpose")
        End Get
    End Property

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.CIM_StorageExtent"></see>.
''' </summary>
''' <remarks></remarks>
Public MustInherit Class CIM_StorageExtents
    Inherits CIM_LogicalDevices

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">Host Computer.</param>
    ''' <param name="ClassName">Class name.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Computer As String, ByVal ClassName As String)
        MyBase.New(Computer, ClassName)
    End Sub

    ''' <summary>
    ''' Describes the read/write properties of the media.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum Access As UInt16

        ''' <summary>
        ''' Unknown.
        ''' </summary>
        ''' <remarks></remarks>
        Unknown = 0

        ''' <summary>
        ''' Readable.
        ''' </summary>
        ''' <remarks></remarks>
        Readable

        ''' <summary>
        ''' Writeable.
        ''' </summary>
        ''' <remarks></remarks>
        Writeable

        ''' <summary>
        ''' Read/write supported.
        ''' </summary>
        ''' <remarks></remarks>
        ReadWrite

        ''' <summary>
        ''' Write once.
        ''' </summary>
        ''' <remarks></remarks>
        WriteOnce

    End Enum

End Class
