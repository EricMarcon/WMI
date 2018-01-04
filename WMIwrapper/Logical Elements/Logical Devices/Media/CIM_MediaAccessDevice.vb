Imports System.Management

''' <summary>
''' Represents the ability to access one or more media, and then use the media to store and retrieve data.
''' </summary>
''' <remarks>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa387901.aspx">MSDN</a>
''' </remarks>
Public MustInherit Class CIM_MediaAccessDevice
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
    ''' Array of capabilities of the media access device. 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Array used instead of flags to allow <see cref="P:WMIwrapper.CIM_MediaAccessDevice.CapabilityDescriptions"/></remarks>
    Public ReadOnly Property Capabilities() As CIM_MediaAccessDevices.Capabilities()
        Get
            Dim obj As Object = GetPropertyObject("Capabilities")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, CIM_MediaAccessDevices.Capabilities())
            End If
        End Get
    End Property

    ''' <summary>
    ''' Array of free-form strings providing more detailed explanations for any of the serial controller features indicated in the <see cref="P:WMIwrapper.CIM_MediaAccessDevice.Capabilities"/> array.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Note, each entry of this array is related to the entry in the Capabilities array that is located at the same index.</remarks>
    Public ReadOnly Property CapabilityDescriptions() As String()
        Get
            Return GetStringArrayProperty("CapabilityDescriptions")
        End Get
    End Property

    ''' <summary>
    ''' Free form string indicating the algorithm or tool used by the device to support compression.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property CompressionMethod() As String
        Get
            Return GetStringProperty("CompressionMethod")
        End Get
    End Property

    ''' <summary>
    ''' Default block size, in bytes, for this device.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property DefaultBlockSize() As UInt64
        Get
            Return GetUint64Property("DefaultBlockSize")
        End Get
    End Property

    ''' <summary>
    ''' Free-form string describing the type of error detection and correction supported by this device. 
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
    ''' Maximum block size, in bytes, for media accessed by this device.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property MaxBlockSize() As UInt64
        Get
            Return GetUint64Property("MaxBlockSize")
        End Get
    End Property

    ''' <summary>
    ''' Maximum size, in kilobytes, of media supported by this device.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property MaxMediaSize() As UInt64
        Get
            Return GetUint64Property("MaxMediaSize")
        End Get
    End Property

    ''' <summary>
    ''' Minimum block size, in bytes, for media accessed by this device.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property MinBlockSize() As UInt64
        Get
            Return GetUint64Property("MinBlockSize")
        End Get
    End Property

    ''' <summary>
    ''' Indicates the media access device needs cleaning.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Whether manual or automatic cleaning is possible is indicated in the Capabilities property.</remarks>
    Public ReadOnly Property NeedsCleaning() As Boolean
        Get
            Return GetBooleanProperty("NeedsCleaning")
        End Get
    End Property

    ''' <summary>
    ''' Maximum number of individual media which can be supported or inserted in the media access device (when supported).
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property NumberOfMediaSupported() As UInt32
        Get
            Return GetUint32Property("NumberOfMediaSupported")
        End Get
    End Property

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.CIM_MediaAccessDevice"></see>.
''' </summary>
''' <remarks></remarks>
Public MustInherit Class CIM_MediaAccessDevices
    Inherits WMIobjects

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
    ''' Array of capabilities of the media access device. 
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum Capabilities As UInt16

        ''' <summary>
        ''' Unknown.
        ''' </summary>
        ''' <remarks></remarks>
        Unknown = 0

        ''' <summary>
        ''' Other.
        ''' </summary>
        ''' <remarks></remarks>
        Other

        ''' <summary>
        ''' Sequential Access.
        ''' </summary>
        ''' <remarks></remarks>
        SequentialAccess

        ''' <summary>
        ''' Random Access.
        ''' </summary>
        ''' <remarks></remarks>
        RandomAccess

        ''' <summary>
        '''  Supports Writing.
        ''' </summary>
        ''' <remarks></remarks>
        SupportsWriting

        ''' <summary>
        ''' Encryption.
        ''' </summary>
        ''' <remarks></remarks>
        Encryption

        ''' <summary>
        ''' Compression.
        ''' </summary>
        ''' <remarks></remarks>
        Compression

        ''' <summary>
        ''' Supports Removable Media
        ''' </summary>
        ''' <remarks></remarks>
        SupportsRemovableMedia

        ''' <summary>
        ''' Manual Cleaning.
        ''' </summary>
        ''' <remarks></remarks>
        ManualCleaning

        ''' <summary>
        ''' Automatic Cleaning.
        ''' </summary>
        ''' <remarks></remarks>
        AutomaticCleaning

        ''' <summary>
        ''' SMART Notification.
        ''' </summary>
        ''' <remarks></remarks>
        SMARTNotification

        ''' <summary>
        ''' Supports Dual-Sided Media.
        ''' </summary>
        ''' <remarks></remarks>
        SupportsDualSidedMedia

        ''' <summary>
        ''' Predismount Eject Not Required.
        ''' </summary>
        ''' <remarks></remarks>
        PredismountEjectNotRequired

    End Enum

End Class