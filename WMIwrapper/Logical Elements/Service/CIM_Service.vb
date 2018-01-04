Imports System.Management

''' <summary>
''' Represents a logical element that contains information to represent and manage the functionality provided by a device or software feature.
''' </summary>
''' <remarks>
''' A service is a general-purpose object to configure and manage the implementation of functionality; it is not the functionality itself.
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa388442.aspx">MSDN</a>
''' </remarks>
Public MustInherit Class CIM_Service
    Inherits CIM_LogicalElement

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

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <param name="ClassPath">The class namespace.</param>
    ''' <param name="ClassName">The class name.</param>
    ''' <remarks>This constructor creates an unbound instance of the class.</remarks>
    Public Sub New(ByVal Computer As String, ByVal ClassName As String, Optional ByVal ClassPath As String = "root\cimv2")
        MyBase.New(Computer, ClassName, ClassPath)
    End Sub

#Region "Properties"

    ''' <summary>
    ''' Name of the first concrete class that appears in the inheritance chain used to create an instance. 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>When used with the other key properties of the class, the property allows all instances of this class and its subclasses to be identified uniquely.</remarks>
    Public ReadOnly Property CreationClassName() As String
        Get
            Return GetStringProperty("CreationClassName")
        End Get
    End Property

    ''' <summary>
    ''' Indicates that the service has been started.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Started() As Boolean
        Get
            Return GetBooleanProperty("Started")
        End Get
    End Property

    ''' <summary>
    ''' Severity of the error if this service fails to start during startup.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' This value indicates the action taken by the startup program if failure occurs.
    ''' All errors are logged by the computer system. 
    ''' Values are:
    ''' <list type="table">
    ''' <item><term>Ignore</term><description>User is not notified.</description></item>
    ''' <item><term>Normal</term><description>User is notified.</description></item>
    ''' <item><term>Severe</term><description>System is restarted with the last-known-good configuration.</description></item>
    ''' <item><term>Critical</term><description>System attempts to restart with a good configuration.</description></item>
    ''' <item><term>Unknown</term><description>Cause of the failure is unknown.</description></item>
    ''' </list>
    ''' </remarks>
    Public ReadOnly Property StartMode() As String
        Get
            Return GetStringProperty("StartMode")
        End Get
    End Property

    ''' <summary>
    ''' Value of the CreationClassName property for the scoping computer.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property SystemCreationClassName() As String
        Get
            Return GetStringProperty("SystemCreationClassName")
        End Get
    End Property

    ''' <summary>
    ''' Name of the scoping system.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property SystemName() As String
        Get
            Return GetStringProperty("SystemName")
        End Get
    End Property

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.CIM_Service"></see>.
''' </summary>
''' <remarks></remarks>
Public MustInherit Class CIM_Services
    Inherits CIM_LogicalElements

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
