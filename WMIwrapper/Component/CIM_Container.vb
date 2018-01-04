Imports System.Management

''' <summary>
''' Represents an association between a contained and a containing physical element.
''' </summary>
''' <remarks>
''' A containing object must be a physical package.
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa387229.aspx">MSDN</a>
''' </remarks>
Public MustInherit Class CIM_Container
    Inherits CIM_Component

    ''' <summary>
    ''' Constructor. 
    ''' </summary>
    ''' <param name="ManagementObject">The underlying management object.</param>
    ''' <remarks>Use this constructor when the management object already exists (e.g. read from a collection).</remarks>
    Public Sub New(ByVal ManagementObject As ManagementObject)
        MyBase.New(ManagementObject)
        ' Get the two managed system elements. Path strings are in the properties.
        _GroupComponent = New CIM_PhysicalPackage(New ManagementPath(_ManagementObject.GetPropertyValue("GroupComponent").ToString))
        _PartComponent = New CIM_PhysicalElement(New ManagementPath(_ManagementObject.GetPropertyValue("PartComponent").ToString))
    End Sub

    Private _GroupComponent As CIM_PhysicalPackage
    ''' <summary>
    ''' Physical component that implements the device.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads ReadOnly Property GroupComponent() As CIM_PhysicalPackage
        Get
            Return _GroupComponent
        End Get
    End Property

    ''' <summary>
    ''' Free-form string that represents the positioning of the physical element within the physical package.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' Information relative to stationary elements in the container (for example, "second drive bay from the top"), angles, altitudes, and other data can be recorded in this property.
    ''' This string could supplement or be used in place of instantiating the <see cref="T:WMIwrapper.CIM_Location"></see> object.
    ''' </remarks>
    Public ReadOnly Property LocationWithinContainer() As String
        Get
            Return GetStringProperty("LocationWithinContainer")
        End Get
    End Property

    Private _PartComponent As CIM_PhysicalElement
    ''' <summary>
    ''' Logical device.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads ReadOnly Property PartComponent() As CIM_PhysicalElement
        Get
            Return _PartComponent
        End Get
    End Property

End Class


''' <summary>
''' Collection of <see cref="T:WMIwrapper.CIM_Container"></see>.
''' </summary>
''' <remarks></remarks>
Public MustInherit Class CIM_Containers
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
