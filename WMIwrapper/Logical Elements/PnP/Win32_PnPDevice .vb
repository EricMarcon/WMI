Imports System.Management

''' <summary>
''' Relates a device (known to Configuration Manager as a PNPEntity) and the function it performs.
''' </summary>
''' <remarks>
''' Its function is represented by a subclass of the logical device that describes its use.
''' For example, a <see cref="T:WMIwrapper.Win32_Keyboard"></see> or <see cref="T:WMIwrapper.Win32_DiskDrive"></see> instance.
''' Both referenced objects represent the same underlying system device;
''' changes to resource allocation on the PNPEntity side will effect the associated device.
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa394352.aspx">MSDN.</a>
''' </remarks>
Public Class Win32_PnPDevice
    Inherits WMIobject

    ''' <summary>
    ''' Constructor. 
    ''' </summary>
    ''' <param name="ManagementObject">The underlying management object.</param>
    ''' <remarks>Use this constructor when the management object already exists (e.g. read from a collection).</remarks>
    Public Sub New(ByVal ManagementObject As ManagementObject)
        MyBase.New(ManagementObject)
        ' Get the adapter and its configuration. Path strings are in the properties.
        _SameElement = New CIM_LogicalDevice(New ManagementPath(_ManagementObject.GetPropertyValue("SameElement").ToString))
        _SystemElement = New Win32_PnPEntity(New ManagementPath(_ManagementObject.GetPropertyValue("SystemElement").ToString))
    End Sub

    Private _SameElement As CIM_LogicalDevice
    ''' <summary>
    ''' Logical device.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property SameElement() As CIM_LogicalDevice
        Get
            Return _SameElement
        End Get
    End Property

    Private _SystemElement As Win32_PnPEntity
    ''' <summary>
    ''' PnP Entity.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property SystemElement() As Win32_PnPEntity
        Get
            Return _SystemElement
        End Get
    End Property

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.Win32_PnPDevice"></see>.
''' </summary>
''' <remarks></remarks>
Public Class Win32_PnPDevices
    Inherits WMIobjects

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Computer As String)

        MyBase.New(Computer, "Win32_PnPDevice")
        ' Read the collection
        For Each ManagementObjectI As ManagementObject In Me.Read()
            Me.Add(New Win32_PnPDevice(ManagementObjectI))
        Next

    End Sub

    ''' <summary>
    ''' Find an item by its index in the collection.
    ''' </summary>
    ''' <param name="index">0-based index of the item in the collection.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal index As Integer) As Win32_PnPDevice
        Return CType(List.Item(index), Win32_PnPDevice)
    End Function

End Class
