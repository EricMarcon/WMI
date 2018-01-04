Imports System.Management

''' <summary>
''' Base class for the system element hierarchy.
''' </summary>
''' <remarks>
''' Any distinguishable system component is a candidate for inclusion in this class.
''' Examples include software components, such as files; devices, such as disk drives and controllers; and physical components, such as chips and cards.
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa387898.aspx">MSDN</a>.
''' </remarks>
Public Class CIM_ManagedSystemElement
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
    ''' Constructor. 
    ''' </summary>
    ''' <param name="ManagementBaseObject">The underlying management base object.</param>
    ''' <remarks>
    ''' Alternate constructor, to use when a management base object is available instead of a management object.
    ''' Management base objects are returned as out parameters of methods.
    ''' </remarks>
    Public Sub New(ByVal ManagementBaseObject As ManagementBaseObject)
        MyBase.New(ManagementBaseObject)
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
    ''' Date and time the object is installed.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>This property does not require a value to indicate that the object is installed.</remarks>
    Public ReadOnly Property InstallDate() As DateTime
        Get
            Return GetDateTimeProperty("InstallDate")
        End Get
    End Property

    ''' <summary>
    ''' Label by which the object is known.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Name() As String
        Get
            Return GetStringProperty("Name")
        End Get
    End Property

    ''' <summary>
    ''' Current status of an object.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>The values are:
    ''' <list type="bullet">
    ''' <item><description>"OK"</description></item> 
    ''' <item><description>"Error"</description></item> 
    ''' <item><description>"Degraded"</description></item> 
    ''' <item><description>"Unknown"</description></item> 
    ''' <item><description>"Pred Fail"</description></item> 
    ''' <item><description>"Starting"</description></item> 
    ''' <item><description>"Stopping"</description></item> 
    ''' <item><description>"Service"</description></item> 
    ''' <item><description>"Stressed"</description></item> 
    ''' <item><description>"NonRecover"</description></item> 
    ''' <item><description>"NoContact"</description></item> 
    ''' <item><description>"LostComm"</description></item> 
    ''' </list>
    ''' </remarks>
    Public ReadOnly Property Status() As String
        Get
            Return GetStringProperty("Status")
        End Get
    End Property

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.CIM_ManagedSystemElement"></see>.
''' </summary>
''' <remarks></remarks>
Public MustInherit Class CIM_ManagedSystemElements
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
