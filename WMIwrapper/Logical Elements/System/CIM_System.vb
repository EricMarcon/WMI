Imports System.Management

''' <summary>
''' Aggregates an enumerable set of managed system elements.
''' </summary>
''' <remarks>
''' The aggregation operates as a functional whole.
''' Within any particular subclass of the system, there is a well-defined list of managed system element classes whose instances must be aggregated.
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa388503.aspx">MSDN.</a>
''' </remarks>
Public MustInherit Class CIM_System
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
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <param name="ClassPath">The class namespace.</param>
    ''' <param name="ClassName">The class name.</param>
    ''' <remarks>This constructor creates an unbound instance of the class.</remarks>
    Public Sub New(ByVal Computer As String, ByVal ClassName As String, Optional ByVal ClassPath As String = "root\cimv2")
        MyBase.New(Computer, ClassName, ClassPath)
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
    ''' Identifies how the system name was generated, using the subclass heuristic.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property NameFormat() As String
        Get
            Return GetStringProperty("NameFormat")
        End Get
    End Property

    ''' <summary>
    ''' How the primary system owner can be reached (for example, phone number or e-mail address).
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property PrimaryOwnerContact() As String
        Get
            Return GetStringProperty("PrimaryOwnerContact")
        End Get
    End Property

    ''' <summary>
    ''' Name of the primary system owner.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property PrimaryOwnerName() As String
        Get
            Return GetStringProperty("PrimaryOwnerName")
        End Get
    End Property

    ''' <summary>
    ''' Roles the system plays in the information technology environment.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' Subclasses of the system can override this property to define explicit role values.
    ''' Alternately, a working group can describe the heuristics, conventions, and guidelines for specifying roles.
    ''' For example, for an instance of a networking system, this property might contain the string "Switch" or "Bridge".
    ''' </remarks>
    Public Property Roles() As String()
        Get
            Return GetStringArrayProperty("Roles")
        End Get
        Set(ByVal value As String())
            _ManagementObject.SetPropertyValue("Roles", value)
        End Set
    End Property

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.CIM_System"></see>.
''' </summary>
''' <remarks></remarks>
Public MustInherit Class CIM_Systems
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
