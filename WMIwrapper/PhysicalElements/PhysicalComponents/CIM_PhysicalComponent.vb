Imports System.Management

''' <summary>
''' Represents a low-level or basic component within a package.
''' </summary>
''' <remarks>
''' <para>
''' A physical element that is not a link, connector, or package is a descendent (or member) of this class.
''' For example, the UART chip set on an internal modem card would be a subclass (if additional properties or associations are defined) or an instance of CIM_PhysicalComponent.
''' </para>
''' <para>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa387960.aspx">MSDN</a>
''' </para>
''' </remarks>
Public Class CIM_PhysicalComponent
    Inherits CIM_PhysicalElement

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
    ''' If TRUE, this physical media component can be replaced with a physically different but equivalent one while the containing package has the power applied.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' For example, a fan component may be designed to be hot-swapped.
    ''' All components that can be hot-swapped are inherently removable and replaceable.
    ''' </remarks>
    Public ReadOnly Property HotSwappable() As Boolean
        Get
            Return GetBooleanProperty("HotSwappable")
        End Get
    End Property

    ''' <summary>
    ''' If TRUE, the physical component is designed to be taken in and out of the physical container in which it is normally found, without impairing the function of the overall packaging.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' A component can still be removable if the power must be "off" to perform the removal.
    ''' If power can be "on" and the component removed, the element is removable and can be hot-swapped.
    ''' </remarks>
    Public ReadOnly Property Removable() As Boolean
        Get
            Return GetBooleanProperty("Removable")
        End Get
    End Property

    ''' <summary>
    ''' If TRUE, this physical media component can be replaced with a physically different one.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' For example, some computer systems allow the main processor chip to be upgraded to one of a higher clock rating.
    ''' In this case, the processor is said to be replaceable. All removable components are inherently replaceable.
    ''' </remarks>
    Public ReadOnly Property Replaceable() As Boolean
        Get
            Return GetBooleanProperty("Replaceable")
        End Get
    End Property

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.CIM_PhysicalComponent"></see>.
''' </summary>
''' <remarks></remarks>
Public MustInherit Class CIM_PhysicalComponents
    Inherits CIM_PhysicalElements

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
