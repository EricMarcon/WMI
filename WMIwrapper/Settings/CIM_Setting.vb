Imports System.Management

''' <summary>
''' Represents configuration-related and operational parameters for one or more managed system elements.
''' </summary>
''' <remarks>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa388461.aspx">MSDN</a>
''' </remarks>
Public MustInherit Class CIM_Setting
    Inherits WMIobject

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="ClassName">The class name.</param>
    ''' <remarks>This constructor creates an unbound instance of the class.</remarks>
    Public Sub New(ByVal ClassName As String)
        MyBase.New(ClassName)
    End Sub

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
    ''' Short description of the object.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Caption() As String
        Get
            Return GetStringProperty("Caption")
        End Get
    End Property

    ''' <summary>
    ''' Description of the object.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Description() As String
        Get
            Return GetStringProperty("Description")
        End Get
    End Property

    ''' <summary>
    ''' Identifier by which the CIM_Setting object is known.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property SettingID() As String
        Get
            Return GetStringProperty("SettingID")
        End Get
    End Property

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.CIM_Setting"></see>.
''' </summary>
''' <remarks></remarks>
Public MustInherit Class CIM_Settings
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
