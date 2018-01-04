Imports System.Management

''' <summary>
''' Represents a network adapter of a computer running a Windows operating system.
''' </summary>
''' <remarks>
''' Only supplies IPv4 data.
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa394216.aspx">MSDN</a>
''' </remarks>
Public Class Win32_NetworkAdapter
    Inherits CIM_Battery

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
    ''' Network medium in use.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property AdapterType() As String
        Get
            Return GetStringProperty("AdapterType")
        End Get
    End Property

    ''' <summary>
    ''' Network medium in use.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' <para>Returns the same information as the AdapterType property, except that the information is in the form of an integer.</para>
    ''' <para>Windows 2000 and Windows NT 4.0:  This property is not applicable.</para>
    ''' </remarks>
    Public ReadOnly Property AdapterTypeID() As Enums.AdapterTypeID
        Get
            Dim obj As Object = GetPropertyObject("AdapterTypeID")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.AdapterTypeID)
            End If
        End Get
    End Property

    ''' <summary>
    ''' Indicates the network adapter can automatically determine the speed of the attached or network media.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property AutoSense() As Boolean
        Get
            Return GetBooleanProperty("AutoSense")
        End Get
    End Property

    ''' <summary>
    ''' Globally unique identifier for the connection.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Windows Server 2003, Windows XP, Windows 2000, and Windows NT 4.0:  This property is not available.</remarks>
    Public ReadOnly Property GUID() As String
        Get
            Return GetStringProperty("GUID")
        End Get
    End Property

    ''' <summary>
    ''' Index number of the network adapter, stored in the system registry.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Index() As UInt32
        Get
            Return GetUint32Property("Index")
        End Get
    End Property

    ''' <summary>
    ''' Indicates the network adapter is installed in the system.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Deprecated.</remarks>
    Public ReadOnly Property Installed() As Boolean
        Get
            Return GetBooleanProperty("Installed")
        End Get
    End Property

    ''' <summary>
    ''' Index value that uniquely identifies the local network interface.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Windows XP, Windows 2000, and Windows NT 4.0:  This property is not available.</remarks>
    Public ReadOnly Property InterfaceIndex() As UInt32
        Get
            Return GetUint32Property("InterfaceIndex")
        End Get
    End Property

    ''' <summary>
    ''' Media access control address for this network adapter.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property MACAddress() As String
        Get
            Return GetStringProperty("MACAddress")
        End Get
    End Property

    ''' <summary>
    ''' Name of the network adapter's manufacturer.
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
    ''' Maximum number of directly addressable ports supported by this network adapter.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>A value of 0 (zero) should be used if the number is unknown.</remarks>
    Public ReadOnly Property MaxNumberControlled() As UInt32
        Get
            Return GetUint32Property("MaxNumberControlled")
        End Get
    End Property

    ''' <summary>
    ''' Name of the network connection as it appears in the Network Connections Control Panel program. 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' <para>Windows Server 2003 and Windows XP:  This property is read-only.</para>
    ''' <para>Windows 2000 and Windows NT 4.0:  This property is not available.</para>
    ''' </remarks>
    Public Property NetConnectionID() As String
        Get
            Return GetStringProperty("NetConnectionID")
        End Get
        Set(ByVal value As String)
            _ManagementObject.SetPropertyValue("NetConnectionID", value)
        End Set
    End Property

    ''' <summary>
    ''' State of the network adapter connection to the network.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Windows 2000 and Windows NT 4.0:  This property is not available. </remarks>
    Public ReadOnly Property NetConnectionStatus() As Enums.NetConnectionStatus
        Get
            Dim obj As Object = GetPropertyObject("NetConnectionStatus")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.NetConnectionStatus)
            End If
        End Get
    End Property

    ''' <summary>
    ''' Indicates whether the adapter is enabled or not.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' <para>You can enable or disable the NIC by using the <see cref="M:WMIwrapper.Win32_NetworkAdapter.Enable"/> and <see cref="M:WMIwrapper.Win32_NetworkAdapter.Disable"/> methods.</para>
    ''' <para>Windows Server 2003, Windows XP, Windows 2000, and Windows NT 4.0:  This property is not available.</para>
    ''' </remarks>
    Public ReadOnly Property NetEnabled() As Boolean
        Get
            Return GetBooleanProperty("NetEnabled")
        End Get
    End Property

    ''' <summary>
    ''' Indicates whether the adapter is a physical or a logical adapter.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property PhysicalAdapter() As Boolean
        Get
            Return GetBooleanProperty("PhysicalAdapter")
        End Get
    End Property

    ''' <summary>
    ''' Product name of the network adapter.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ProductName() As String
        Get
            Return GetStringProperty("ProductName")
        End Get
    End Property

    ''' <summary>
    ''' Service name of the network adapter.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>This name is usually shorter than the full product name.</remarks>
    Public ReadOnly Property ServiceName() As String
        Get
            Return GetStringProperty("ProductName")
        End Get
    End Property

    ''' <summary>
    ''' Date and time the network adapter was last reset.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property TimeOfLastReset() As DateTime
        Get
            Return GetDateTimeProperty("TimeOfLastReset")
        End Get
    End Property

#End Region

#Region "Methods"

    ''' <summary>
    ''' Enables the network adapter.
    ''' </summary>
    ''' <remarks></remarks>
    Public Function Enable() As InvokeError
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("Enable")
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))
    End Function

    ''' <summary>
    ''' Disables the network adapter.
    ''' </summary>
    ''' <remarks></remarks>
    Public Function Disable() As InvokeError
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("Disable")
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))
    End Function

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.Win32_NetworkAdapter"></see>.
''' </summary>
''' <remarks></remarks>
Public Class Win32_NetworkAdapters
    Inherits CIM_NetworkAdapters

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <param name="DeviceID">If specified, only the item corresponding to this key value is returned. Ignored if <code>Condition</code> is set.</param>
    ''' <param name="Condition">WQL condition can be specified. It is not checked and sent to WMI as is.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Computer As String, Optional ByVal DeviceID As String = Nothing, Optional ByVal Condition As String = Nothing)

        MyBase.New(Computer, "Win32_NetworkAdapter")
        ' Prepare condition
        If Condition Is Nothing AndAlso DeviceID IsNot Nothing Then
            Condition = "DeviceID ='" & DeviceID & "'"
        End If
        ' Read the collection
        For Each ManagementObjectI As ManagementObject In Me.Read(Condition)
            Me.Add(New Win32_NetworkAdapter(ManagementObjectI))
        Next

    End Sub

    ''' <summary>
    ''' Find an item in the collection.
    ''' </summary>
    ''' <param name="index">Index of the item.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal index As Integer) As Win32_NetworkAdapter
        Return CType(List.Item(index), Win32_NetworkAdapter)
    End Function

    ''' <summary>
    ''' Find an item by its ID.
    ''' </summary>
    ''' <param name="DeviceID">The device ID.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal DeviceID As String) As Win32_NetworkAdapter
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
    ''' Network medium in use.
    ''' </summary>
    ''' <remarks>Returns the same information as the AdapterType property, except that the information is in the form of an integer.</remarks>
    Public Enum AdapterTypeID As UInt16

        ''' <summary>
        ''' Ethernet 802.3.
        ''' </summary>
        ''' <remarks></remarks>
        Ethernet

        ''' <summary>
        '''  Token Ring 802.5.
        ''' </summary>
        ''' <remarks></remarks>
        TokenRing

        ''' <summary>
        ''' Fiber Distributed Data Interface (FDDI) 
        ''' </summary>
        ''' <remarks></remarks>
        FDDI

        ''' <summary>
        ''' Wide Area Network (WAN).
        ''' </summary>
        ''' <remarks></remarks>
        WAN

        ''' <summary>
        ''' LocalTalk.
        ''' </summary>
        ''' <remarks></remarks>
        LocalTalk

        ''' <summary>
        ''' Ethernet using DIX header format.
        ''' </summary>
        ''' <remarks></remarks>
        EthernetDIX

        ''' <summary>
        '''  ARCNET.
        ''' </summary>
        ''' <remarks></remarks>
        ARCNET

        ''' <summary>
        '''  ARCNET (878.2).
        ''' </summary>
        ''' <remarks></remarks>
        ARCNET878_2

        ''' <summary>
        ''' ATM.
        ''' </summary>
        ''' <remarks></remarks>
        ATM

        ''' <summary>
        ''' Wireless.
        ''' </summary>
        ''' <remarks></remarks>
        Wireless

        ''' <summary>
        ''' Infrared Wireless.
        ''' </summary>
        ''' <remarks></remarks>
        InfraredWireless

        ''' <summary>
        ''' Bpc.
        ''' </summary>
        ''' <remarks></remarks>
        Bpc

        ''' <summary>
        ''' CoWan
        ''' </summary>
        ''' <remarks></remarks>
        CoWan

        ''' <summary>
        ''' 1394.
        ''' </summary>
        ''' <remarks></remarks>
        _1394

        ''' <summary>
        ''' Not documented in MSDN.
        ''' </summary>
        ''' <remarks></remarks>
        _14

        ''' <summary>
        ''' Tunnel.
        ''' </summary>
        ''' <remarks>Not documented in MSDN.</remarks>
        Tunnel
    End Enum

    ''' <summary>
    ''' State of the network adapter connection to the network. 
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum NetConnectionStatus As UInt16

        ''' <summary>
        ''' Disconnected.
        ''' </summary>
        ''' <remarks></remarks>
        Disconnected = 0

        ''' <summary>
        ''' Connecting.
        ''' </summary>
        ''' <remarks></remarks>
        Connecting

        ''' <summary>
        ''' Connected.
        ''' </summary>
        ''' <remarks></remarks>
        Connected

        ''' <summary>
        ''' Disconnecting.
        ''' </summary>
        ''' <remarks></remarks>
        Disconnecting

        ''' <summary>
        ''' Hardware not present.
        ''' </summary>
        ''' <remarks></remarks>
        HardwareNotPresent

        ''' <summary>
        '''  Hardware disabled. 
        ''' </summary>
        ''' <remarks></remarks>
        Hardwaredisabled

        ''' <summary>
        ''' Hardware malfunction.
        ''' </summary>
        ''' <remarks></remarks>
        HardwareMalfunction

        ''' <summary>
        ''' Media disconnected.
        ''' </summary>
        ''' <remarks></remarks>
        MediaDisconnected

        ''' <summary>
        ''' Authenticating.
        ''' </summary>
        ''' <remarks></remarks>
        Authenticating

        ''' <summary>
        ''' Authentication succeeded.
        ''' </summary>
        ''' <remarks></remarks>
        AuthenticationSucceeded

        ''' <summary>
        ''' Authentication failed.
        ''' </summary>
        ''' <remarks></remarks>
        AuthenticationFailed

        ''' <summary>
        ''' Invalid address.
        ''' </summary>
        ''' <remarks></remarks>
        InvalidAddress

        ''' <summary>
        ''' Credentials required.
        ''' </summary>
        ''' <remarks></remarks>
        CredentialsRequired

    End Enum

End Namespace
