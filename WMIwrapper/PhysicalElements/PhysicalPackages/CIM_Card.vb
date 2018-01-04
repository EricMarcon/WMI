Imports System.Management

''' <summary>
''' Represents  a type of physical container that can be plugged into another card or hosting board, or is itself a hosting board/motherboard in a chassis.
''' </summary>
''' <remarks>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa387200.aspx">MSDN</a>
''' </remarks>
Public MustInherit Class CIM_Card
    Inherits CIM_PhysicalPackage

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
    ''' If TRUE, this card is a motherboard or, more generically, a baseboard in a chassis.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' </remarks>
    Public ReadOnly Property HostingBoard() As Boolean
        Get
            Return GetBooleanProperty("HostingBoard")
        End Get
    End Property

    ''' <summary>
    ''' Free-form string that describes the ways in which the card is physically unique from other cards.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' This property only has meaning when the corresponding Boolean property, <see cref="P:WMIwrapper.CIM_Card.SpecialRequirements"></see>, is set to <c>TRUE</c>.
    ''' </remarks>
    Public ReadOnly Property RequirementsDescription() As String
        Get
            Return GetStringProperty("RequirementsDescription")
        End Get
    End Property

    ''' <summary>
    ''' If TRUE, to function properly, at least one daughterboard or auxiliary card is required.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' </remarks>
    Public ReadOnly Property RequiresDaughterBoard() As Boolean
        Get
            Return GetBooleanProperty("RequiresDaughterBoard")
        End Get
    End Property

    ''' <summary>
    ''' Free-form string that describes the slot positioning, typical usage, restrictions, individual slot spacings, or other pertinent information for the slots on a card.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' </remarks>
    Public ReadOnly Property SlotLayout() As String
        Get
            Return GetStringProperty("SlotLayout")
        End Get
    End Property

    ''' <summary>
    ''' If TRUE, the card is physically unique from other cards of the same type and, therefore, requires a special slot.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' For example, a double-wide card requires two slots.
    ''' Another example is when a certain card can be used for the same general function as other cards, but requires a special slot (extra long, for example);
    ''' whereas, other cards can be placed in any available slot.
    ''' If TRUE, the corresponding <see cref="P:WMIwrapper.CIM_Card.RequirementsDescription"></see> property should specify the nature of the uniqueness or purpose of the card.
    ''' </remarks>
    Public ReadOnly Property SpecialRequirements() As Boolean
        Get
            Return GetBooleanProperty("SpecialRequirements")
        End Get
    End Property

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.CIM_Card"></see>.
''' </summary>
''' <remarks></remarks>
Public MustInherit Class CIM_Cards
    Inherits CIM_PhysicalPackages

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
