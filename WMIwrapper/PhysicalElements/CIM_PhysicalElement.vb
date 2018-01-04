Imports System.Management

''' <summary>
''' Physical Element.
''' </summary>
''' <remarks>
''' <para>
''' The CIM_PhysicalElement subclasses define any component of a system that has a distinct physical identity.
''' Instances of this class can be defined in terms of labels that can be physically attached to the object.
''' All processes, files, and logical devices are not considered to be physical elements.
''' For example, it is not possible to attach a label to a modem; it is only possible to attach a label to the card that implements the modem.
''' The same card could also implement a LAN adapter.
''' </para>
''' <para>
''' Tangible managed system elements (usually hardware items) have a physical manifestation.
''' A managed system element is not necessarily a discrete component.
''' For example, it is possible for a single card (a type of physical element) to host more than one logical device.
''' The card would be represented by a single physical element associated with multiple logical devices.
''' </para>
''' <para>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa387962.aspx">MSDN</a>
''' </para>
''' </remarks>
Public Class CIM_PhysicalElement
    Inherits CIM_ManagedSystemElement

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
    ''' Name of the organization responsible for producing the physical element.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected ReadOnly Property Manufacturer() As String
        Get
            Return GetStringProperty("Manufacturer")
        End Get
    End Property

    ''' <summary>
    ''' Name by which the physical element is generally known.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected ReadOnly Property Model() As String
        Get
            Return GetStringProperty("Model")
        End Get
    End Property

    ''' <summary>
    ''' Additional data, beyond asset tag information, that can be used to identify a physical element.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' One example is bar-code data that is associated with an element, which also has an asset tag.
    ''' Note that if only bar-code data is available, and is unique and able to be used as an element key, this property would be null and the bar-code data would be used as the class key in the Tag property.
    ''' </remarks>
    Protected ReadOnly Property OtherIdentifyingInfo() As String
        Get
            Return GetStringProperty("OtherIdentifyingInfo")
        End Get
    End Property

    ''' <summary>
    ''' Part number assigned by the organization responsible for producing or manufacturing the physical element.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected ReadOnly Property PartNumber() As String
        Get
            Return GetStringProperty("PartNumber")
        End Get
    End Property

    ''' <summary>
    ''' If TRUE, the physical element is powered on. Otherwise, it is currently off.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected ReadOnly Property PoweredOn() As Boolean
        Get
            Return GetBooleanProperty("PoweredOn")
        End Get
    End Property

    ''' <summary>
    ''' Manufacturer-allocated number used to identify the physical element.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected ReadOnly Property SerialNumber() As String
        Get
            Return GetStringProperty("SerialNumber")
        End Get
    End Property

    ''' <summary>
    ''' Stock-keeping unit number for this physical element.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected ReadOnly Property SKU() As String
        Get
            Return GetStringProperty("SKU")
        End Get
    End Property

    ''' <summary>
    ''' Arbitrary string that uniquely identifies the physical element and serves as the element's key.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' <para>
    ''' This property can contain information, such as asset tag or serial number data.
    ''' The key for CIM_PhysicalElement is placed very high in the object hierarchy to independently identify the hardware or entity, regardless of physical placement in (or on) cabinets, adapters, and so on.
    ''' For example, a removable component that can be hot-swapped can be taken from its containing (scoping) package and be temporarily unused.
    ''' The object still continues to exist and can even be inserted into a different scoping container.
    ''' The key for a physical element is an arbitrary string that is defined independently of placement or location-oriented hierarchy.
    ''' </para>
    ''' <para>
    ''' This property is <code>Friend</code> because it is used by collection classes to find derived objects.
    ''' </para>
    ''' </remarks>
    Friend ReadOnly Property Tag() As String
        Get
            Return GetStringProperty("Tag")
        End Get
    End Property

    ''' <summary>
    ''' String that indicates the version of the physical element.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected ReadOnly Property Version() As String
        Get
            Return GetStringProperty("Version")
        End Get
    End Property

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.CIM_PhysicalElement"></see>.
''' </summary>
''' <remarks></remarks>
Public MustInherit Class CIM_PhysicalElements
    Inherits CIM_ManagedSystemElements

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
