Imports System.Management

''' <summary>
''' Represents physical elements that contain or host other components.
''' </summary>
''' <remarks>
''' <para>
''' Examples are a rack enclosure or an adapter card.
''' </para>
''' <para>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa387969.aspx">MSDN</a>
''' </para>
''' </remarks>
Public Class CIM_PhysicalPackage
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
    ''' Depth of the physical package, in inches.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' </remarks>
    Public ReadOnly Property Depth() As Double
        Get
            Return GetDoubleProperty("Depth")
        End Get
    End Property

    ''' <summary>
    ''' Height  of the physical package, in inches.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' </remarks>
    Public ReadOnly Property Height() As Double
        Get
            Return GetDoubleProperty("Height")
        End Get
    End Property

    ''' <summary>
    ''' If TRUE, the package can be hot-swapped.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' A physical package can be hot-swapped if the element can be replaced by a physically different (but equivalent) one while the containing package is turned on.
    ''' For example, a fan component may be designed to be hot-swapped.
    ''' All components that can be hot-swapped are inherently removable and replaceable. 
    ''' </remarks>
    Public ReadOnly Property HotSwappable() As Boolean
        Get
            Return GetBooleanProperty("HotSwappable")
        End Get
    End Property

    ''' <summary>
    ''' If TRUE, the package is designed to be taken in and out of the physical container in which it is normally found, without impairing the function of the overall packaging.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' A package is considered removable even if the power must be off to perform the removal.
    ''' If the power can be on and the package removed, then the element is removable and can be hot-swapped.
    ''' For example, an upgradeable processor chip is removable. 
    ''' </remarks>
    Public ReadOnly Property Removable() As Boolean
        Get
            Return GetBooleanProperty("Removable")
        End Get
    End Property

    ''' <summary>
    ''' If TRUE, it is possible to replace the element with a physically different one.
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

    ''' <summary>
    ''' Weight of the physical package, in pounds.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' </remarks>
    Public ReadOnly Property Weight() As Double
        Get
            Return GetDoubleProperty("Weight")
        End Get
    End Property

    ''' <summary>
    ''' Width of the physical package, in inches.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' </remarks>
    Public ReadOnly Property Width() As Double
        Get
            Return GetDoubleProperty("Width")
        End Get
    End Property

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.CIM_PhysicalPackage"></see>.
''' </summary>
''' <remarks></remarks>
Public MustInherit Class CIM_PhysicalPackages
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
