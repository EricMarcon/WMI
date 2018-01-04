Imports System.Management

''' <summary>
''' Represents an association that establishes dependency relationships between objects.
''' </summary>
''' <remarks>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa387238.aspx">MSDN</a>
''' </remarks>
Public MustInherit Class CIM_Dependency
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

    Protected _Antecedent As CIM_ManagedSystemElement
    ''' <summary>
    ''' Reference to the independent object in this association.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Antecedent() As CIM_ManagedSystemElement
        Get
            Return _Antecedent
        End Get
    End Property

    Protected _Dependent As CIM_ManagedSystemElement
    ''' <summary>
    ''' Reference to the object that is dependent on the <see cref="P:WMIwrapper.CIM_Dependency.Antecedent"></see> property.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Dependent() As CIM_ManagedSystemElement
        Get
            Return _Dependent
        End Get
    End Property

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.CIM_Dependency"></see>.
''' </summary>
''' <remarks></remarks>
Public MustInherit Class CIM_Dependencies
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
