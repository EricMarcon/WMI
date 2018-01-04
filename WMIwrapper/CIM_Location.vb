Imports System.Management

''' <summary>
''' Represents the position and address of a physical element.
''' </summary>
''' <remarks>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa387882.aspx">MSDN</a>.
''' </remarks>
Public MustInherit Class CIM_Location
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
    ''' Free-form string that indicates a street or other type of address for the physical element's location.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Address() As String
        Get
            Return GetStringProperty("Address")
        End Get
    End Property

    ''' <summary>
    ''' Free-form string that defines a label for the location and is part of the key for the object.
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
    ''' Free-form string that indicates the placement of a physical element.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' It can specify slot information on a hosting board, mounting site in a cabinet, or latitude and longitude information. 
    ''' </remarks>
    Public ReadOnly Property PhysicalPosition() As String
        Get
            Return GetStringProperty("PhysicalPosition")
        End Get
    End Property

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.CIM_Location"></see>.
''' </summary>
''' <remarks></remarks>
Public MustInherit Class CIM_Locations
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
