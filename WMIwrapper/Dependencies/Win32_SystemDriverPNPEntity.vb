Imports System.Management

''' <summary>
''' Relates a Plug and Play device on the computer system running Windows and the driver that supports the Plug and Play device.
''' </summary>
''' <remarks>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa394473.aspx">MSDN.</a>
''' </remarks>
Public Class Win32_SystemDriverPNPEntity
    Inherits CIM_Dependency

    ''' <summary>
    ''' Constructor. 
    ''' </summary>
    ''' <param name="ManagementObject">The underlying management object.</param>
    ''' <remarks>Use this constructor when the management object already exists (e.g. read from a collection).</remarks>
    Public Sub New(ByVal ManagementObject As ManagementObject)
        MyBase.New(ManagementObject)
        ' Get the adapter and its configuration. Path strings are in the properties.
        _Antecedent = New Win32_PnPEntity(New ManagementPath(_ManagementObject.GetPropertyValue("Antecedent").ToString))
        _Dependent = New Win32_SystemDriver(New ManagementPath(_ManagementObject.GetPropertyValue("Dependent").ToString))
    End Sub

#Region "Properties"

    ''' <summary>
    ''' The Plug and Play device controlled by the driver.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads ReadOnly Property Antecedent() As Win32_PnPEntity
        Get
            Return CType(_Antecedent, Win32_PnPEntity)
        End Get
    End Property

    ''' <summary>
    ''' PnP Entity.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads ReadOnly Property Dependent() As Win32_SystemDriver
        Get
            Return CType(_Dependent, Win32_SystemDriver)
        End Get
    End Property

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.Win32_SystemDriverPNPEntity"></see>.
''' </summary>
''' <remarks></remarks>
Public Class Win32_SystemDriverPNPEntities
    Inherits CIM_Dependencies

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Computer As String)

        MyBase.New(Computer, "Win32_SystemDriverPNPEntity")
        ' Read the collection
        For Each ManagementObjectI As ManagementObject In Me.Read()
            Me.Add(New Win32_SystemDriverPNPEntity(ManagementObjectI))
        Next

    End Sub

    ''' <summary>
    ''' Find an item by its index in the collection.
    ''' </summary>
    ''' <param name="index">0-based index of the item in the collection.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal index As Integer) As Win32_SystemDriverPNPEntity
        Return CType(List.Item(index), Win32_SystemDriverPNPEntity)
    End Function

End Class
