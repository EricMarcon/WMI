Imports System.Management

''' <summary>
''' Represents the properties of a Plug and Play device. Plug and Play entities are shown as entries in the Device Manager located in Control Panel.
''' </summary>
''' <remarks>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa394353.aspx">MSDN</a>
''' </remarks>
Public Class Win32_PnPEntity
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
    ''' Globally unique identifier (GUID) of this Plug and Play device.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ClassGuid() As String
        Get
            Return GetStringProperty("ClassGuid")
        End Get
    End Property

    ''' <summary>
    ''' A vendor-defined identification string that Setup uses to match a device to an INF file.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' <para>
    ''' A device can have a list of compatible IDs associated with it.
    ''' The compatible IDs should be listed in order of decreasing suitability.
    ''' If Setup cannot locate an INF file that matches one of a device's hardware IDs, it uses compatible IDs to locate an INF file.
    ''' A compatible ID has the same format as a HardwareID.
    ''' </para>
    ''' <para>Windows Server 2003, Windows XP, Windows 2000, Windows XP, and Windows NT 4.0:  This property is not available.</para>
    ''' </remarks>
    Public ReadOnly Property CompatibleID() As String()
        Get
            Return GetStringArrayProperty("CompatibleID")
        End Get
    End Property

    ''' <summary>
    ''' A vendor-defined identification string that Setup uses to match a device to an INF file.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' <para>
    ''' Normally, a device has an associated list of hardware IDs.
    ''' An exception is the 1394 bus driver, which does not use hardware IDs.
    ''' The first hardware ID in the list should be the device ID.
    ''' The remaining IDs should be listed in order of decreasing suitability.
    ''' </para>
    ''' <para>
    ''' Hardware IDs appear in one the following formats:
    ''' <list type="bullet">
    ''' <item><description>enumerator\enumerator-specific-device-ID: This is the most common format for individual PnP devices. An example of an enumerator is the BIOS or ISAPNP.</description></item>
    ''' <item><description>enumerat*enumerator-specific ID: An asterisk (*) indicates use by more than one enumerator.</description></item>
    ''' <item><description>device-class-specific ID: a custom format.</description></item>
    ''' </list>
    ''' </para>
    ''' <para>Windows Server 2003, Windows XP, Windows 2000, Windows XP, and Windows NT 4.0: This property is not available.</para>
    ''' </remarks>
    Public ReadOnly Property HardwareID() As String()
        Get
            Return GetStringArrayProperty("HardwareID")
        End Get
    End Property

    ''' <summary>
    ''' Name of the manufacturer of the Plug and Play device.
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
    ''' Name of the service that supports this Plug and Play device.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>For more information, see <see cref="T:WMIwrapper.Win32_SystemDriverPnPEntity"></see>.</remarks>
    Public ReadOnly Property Service() As String
        Get
            Return GetStringProperty("Service")
        End Get
    End Property

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.Win32_PnPEntity"></see>.
''' </summary>
''' <remarks></remarks>
Public Class Win32_PnPEntities
    Inherits CIM_LogicalDevices

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <param name="DeviceID">If specified, only the item corresponding to this key value is returned. Ignored if <code>Condition</code> is set.</param>
    ''' <param name="Condition">WQL condition can be specified. It is not checked and sent to WMI as is.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Computer As String, Optional ByVal DeviceID As String = Nothing, Optional ByVal Condition As String = Nothing)

        MyBase.New(Computer, "Win32_PnPEntity")
        ' Prepare condition
        If Condition Is Nothing AndAlso DeviceID IsNot Nothing Then
            Condition = "DeviceID ='" & DeviceID & "'"
        End If
        ' Read the collection
        For Each ManagementObjectI As ManagementObject In Me.Read(Condition)
            Me.Add(New Win32_PnPEntity(ManagementObjectI))
        Next

    End Sub

    ''' <summary>
    ''' Find an item in the collection.
    ''' </summary>
    ''' <param name="index">Index of the item.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal index As Integer) As Win32_PnPEntity
        Return CType(List.Item(index), Win32_PnPEntity)
    End Function

    ''' <summary>
    ''' Find an item by its ID.
    ''' </summary>
    ''' <param name="DeviceID">The device ID.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal DeviceID As String) As Win32_PnPEntity
        For intI As Integer = 0 To List.Count - 1
            If Me.Item(intI).DeviceID = DeviceID Then
                Return Me.Item(intI)
            End If
        Next
        Return Nothing
    End Function

End Class
