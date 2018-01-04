Imports System.Management

''' <summary>
''' Represents the capabilities and management of cooling devices.
''' </summary>
''' <remarks>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa387232.aspx">MSDN</a>
''' </remarks>
Public MustInherit Class CIM_CoolingDevice
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
    ''' If TRUE, the cooling device provides active cooling—not passive cooling.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ActiveCooling() As Boolean
        Get
            Return GetBooleanProperty("ActiveCooling")
        End Get
    End Property

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.CIM_CoolingDevice"></see>.
''' </summary>
''' <remarks></remarks>
Public MustInherit Class CIM_CoolingDevices
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
