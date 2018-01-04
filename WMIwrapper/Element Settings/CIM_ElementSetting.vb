Imports System.Management

''' <summary>
''' Represents the association between managed system elements and the setting class defined for them.
''' </summary>
''' <remarks>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa387263.aspx">MSDN</a>
''' </remarks>
Public MustInherit Class CIM_ElementSetting
    Inherits WMIobject

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

    Protected _Element As CIM_ManagedSystemElement
    ''' <summary>
    ''' The associated managed system element provides the element that implements the element setting.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Element() As CIM_ManagedSystemElement
        Get
            Return _Element
        End Get
    End Property

    Protected _Setting As CIM_Setting
    ''' <summary>
    ''' The associated setting provides the setting that implements the element setting.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Setting() As CIM_Setting
        Get
            Return _Setting
        End Get
    End Property

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.CIM_ElementSetting"></see>.
''' </summary>
''' <remarks></remarks>
Public MustInherit Class CIM_ElementSettings
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

End Class
