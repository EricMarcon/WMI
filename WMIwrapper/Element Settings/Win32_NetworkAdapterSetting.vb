Imports System.Management

''' <summary>
''' Relates a network adapter and its configuration settings.
''' </summary>
''' <remarks>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa394218.aspx">MSDN</a>
''' </remarks>
Public Class Win32_NetworkAdapterSetting
    Inherits Win32_DeviceSetting

    ''' <summary>
    ''' Constructor. 
    ''' </summary>
    ''' <param name="ManagementObject">The underlying management object.</param>
    ''' <remarks>Use this constructor when the management object already exists (e.g. read from a collection).</remarks>
    Public Sub New(ByVal ManagementObject As ManagementObject)
        MyBase.New(ManagementObject)
        ' Get the adapter and its configuration. Path strings are in the properties.
        _Element = New Win32_NetworkAdapter(New ManagementPath(_ManagementObject.GetPropertyValue("Element").ToString))
        _Setting = New Win32_NetworkAdapterConfiguration(New ManagementPath(_ManagementObject.GetPropertyValue("Setting").ToString))
    End Sub

    ''' <summary>
    ''' Reference to the <see cref="T:WMIwrapper.Win32_NetworkAdapter"></see> instance representing the properties of a network adapter using a particular network adapter setting.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads ReadOnly Property Element() As Win32_NetworkAdapter
        Get
            Return CType(_Element, Win32_NetworkAdapter)
        End Get
    End Property

    ''' <summary>
    ''' Reference to the <see cref="T:WMIwrapper.Win32_NetworkAdapterConfiguration"></see> instance representing the configuration settings used on the network adapter.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads ReadOnly Property Setting() As Win32_NetworkAdapterConfiguration
        Get
            Return CType(_Setting, Win32_NetworkAdapterConfiguration)
        End Get
    End Property

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.Win32_NetworkAdapterSetting"></see>.
''' </summary>
''' <remarks></remarks>
Public Class Win32_NetworkAdapterSettings
    Inherits Win32_DeviceSettings

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Computer As String)

        MyBase.New(Computer, "Win32_NetworkAdapterSetting")
        ' Read the collection
        For Each ManagementObjectI As ManagementObject In Me.Read()
            Me.Add(New Win32_NetworkAdapterSetting(ManagementObjectI))
        Next

    End Sub

    ''' <summary>
    ''' Find an item by its index in the collection.
    ''' </summary>
    ''' <param name="index">0-based index of the item in the collection.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal index As Integer) As Win32_NetworkAdapterSetting
        Return CType(List.Item(index), Win32_NetworkAdapterSetting)
    End Function

End Class
