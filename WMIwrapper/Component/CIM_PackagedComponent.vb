Imports System.Management

''' <summary>
''' Represents an explicit relationship in which a component is typically contained by a physical package, such as a chassis or card.
''' </summary>
''' <remarks>
''' A component may be removed from, or not yet inserted into, its containing package (that is, the Removable Boolean property is TRUE).
''' Therefore, a component may not always be associated with a container.
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa387948.aspx">MSDN</a>
''' </remarks>
Public MustInherit Class CIM_PackagedComponent
    Inherits CIM_Container

    ''' <summary>
    ''' Constructor. 
    ''' </summary>
    ''' <param name="ManagementObject">The underlying management object.</param>
    ''' <remarks>Use this constructor when the management object already exists (e.g. read from a collection).</remarks>
    Public Sub New(ByVal ManagementObject As ManagementObject)
        MyBase.New(ManagementObject)
        ' Get the two managed system elements. Path strings are in the properties.
        _GroupComponent = New CIM_PhysicalPackage(New ManagementPath(_ManagementObject.GetPropertyValue("GroupComponent").ToString))
        _PartComponent = New CIM_PhysicalComponent(New ManagementPath(_ManagementObject.GetPropertyValue("PartComponent").ToString))
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

    Private _PartComponent As CIM_PhysicalComponent
    ''' <summary>
    ''' Logical device.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads ReadOnly Property PartComponent() As CIM_PhysicalComponent
        Get
            Return _PartComponent
        End Get
    End Property

End Class


''' <summary>
''' Collection of <see cref="T:WMIwrapper.CIM_PackagedComponent"></see>.
''' </summary>
''' <remarks></remarks>
Public MustInherit Class CIM_PackagedComponents
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
