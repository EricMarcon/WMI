Imports System.Management

''' <summary>
''' Sspecifies the logical device accessed by using the referenced <see cref="T:WMIwrapper.CIM_DeviceFile"></see> class.
''' </summary>
''' <remarks>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa387241(VS.85).aspx">MSDN.</a>
''' </remarks>
Public Class CIM_DeviceAccessedByFile
    Inherits CIM_Dependency

    ''' <summary>
    ''' Constructor. 
    ''' </summary>
    ''' <param name="ManagementObject">The underlying management object.</param>
    ''' <remarks>Use this constructor when the management object already exists (e.g. read from a collection).</remarks>
    Public Sub New(ByVal ManagementObject As ManagementObject)
        MyBase.New(ManagementObject)
        ' Get the adapter and its configuration. Path strings are in the properties.
        _Antecedent = New CIM_DeviceFile(New ManagementPath(_ManagementObject.GetPropertyValue("Antecedent").ToString))
        _Dependent = New CIM_LogicalDevice(New ManagementPath(_ManagementObject.GetPropertyValue("Dependent").ToString))
    End Sub

#Region "Properties"

    ''' <summary>
    ''' Reference to the device file.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads ReadOnly Property Antecedent() As CIM_DeviceFile
        Get
            Return CType(_Antecedent, CIM_DeviceFile)
        End Get
    End Property

    ''' <summary>
    ''' Reference to the device that is accessed by using the device file.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads ReadOnly Property Dependent() As CIM_LogicalDevice
        Get
            Return CType(_Dependent, CIM_LogicalDevice)
        End Get
    End Property

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.CIM_DeviceAccessedByFile"></see>.
''' </summary>
''' <remarks></remarks>
Public MustInherit Class CIM_DeviceAccessedByFiles
    Inherits CIM_Dependencies

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
