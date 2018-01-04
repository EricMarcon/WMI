Imports System.Management

''' <summary>
''' Abstract class that defines general networking hardware concepts (for example, permanent address or speed of operation).
''' </summary>
''' <remarks>
''' Network adapters and related endpoints represent the potential for connectivity among peers.
''' The potential for connectivity is significantly different from the master or subordinate and controller or controlled-by relationships of CIM_Controller.
''' Occasionally, however, a single device acts as both a network adapter and a controller, for example, when a fiber channel adapter operates as a computer system's SCSI controller.
''' In which case, aspects of the device are network oriented and others are controller oriented.
''' The controller and adapter classes should be instantiated and a device identity relationship should also be created to link the different aspects of the device.
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa387931.aspx">MSDN</a>
''' </remarks>
Public MustInherit Class CIM_NetworkAdapter
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

#Region "Properties"

    ''' <summary>
    ''' Maximum speed, in bits per second, for the network adapter.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>This property has not been implemented yet. It returns a NULL value by default.</remarks>
    Public ReadOnly Property MaxSpeed() As UInt64
        Get
            Return GetUint64Property("MaxSpeed")
        End Get
    End Property

    ''' <summary>
    ''' Array of network addresses for an adapter.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>This property has not been implemented yet. It returns a NULL value by default.</remarks>
    Public ReadOnly Property NetworkAddresses() As String()
        Get
            Return GetStringArrayProperty("NetworkAddresses")
        End Get
    End Property

    ''' <summary>
    ''' Network address hard-coded into an adapter.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' This hard-coded address may be changed by firmware upgrade or software configuration.
    ''' If so, this field should be updated when the change is made.
    ''' The property should be left blank if no hard-coded address exists for the network adapter.</remarks>
    Public ReadOnly Property PermanentAddress() As String
        Get
            Return GetStringProperty("PermanentAddress")
        End Get
    End Property

    ''' <summary>
    ''' Estimate of the current bandwidth in bits per second.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' <para>For endpoints which vary in bandwidth or for those where no accurate estimation can be made, this property should contain the nominal bandwidth.</para>
    ''' <para>Windows Server 2003, Windows XP, Windows 2000, and Windows NT 4.0:  This property has not been implemented yet. It returns a NULL value by default.</para>
    ''' </remarks>
    Public ReadOnly Property Speed() As UInt64
        Get
            Return GetUint64Property("Speed")
        End Get
    End Property

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.CIM_NetworkAdapter"></see>.
''' </summary>
''' <remarks></remarks>
Public MustInherit Class CIM_NetworkAdapters
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


End Class
