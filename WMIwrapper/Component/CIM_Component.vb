Imports System.Management

''' <summary>
''' Represents the parts of a relationship between <see cref="T:WMIwrapper.CIM_ManagedSystemElement"></see>.
''' </summary>
''' <remarks>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa387218.aspx">MSDN</a>
''' </remarks>
Public Class CIM_Component
    Inherits WMIobject

    ''' <summary>
    ''' Constructor. 
    ''' </summary>
    ''' <param name="ManagementObject">The underlying management object.</param>
    ''' <remarks>Use this constructor when the management object already exists (e.g. read from a collection).</remarks>
    Public Sub New(ByVal ManagementObject As ManagementObject)
        MyBase.New(ManagementObject)
        ' Get the two managed system elements. Path strings are in the properties.
        _GroupComponent = New CIM_ManagedSystemElement(New ManagementPath(_ManagementObject.GetPropertyValue("GroupComponent").ToString))
        _PartComponent = New CIM_ManagedSystemElement(New ManagementPath(_ManagementObject.GetPropertyValue("PartComponent").ToString))
    End Sub

    Private _GroupComponent As CIM_ManagedSystemElement
    ''' <summary>
    ''' Physical component that implements the device.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property GroupComponent() As CIM_ManagedSystemElement
        Get
            Return _GroupComponent
        End Get
    End Property

    Private _PartComponent As CIM_ManagedSystemElement
    ''' <summary>
    ''' Logical device.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property PartComponent() As CIM_ManagedSystemElement
        Get
            Return _PartComponent
        End Get
    End Property

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.CIM_Component"></see>.
''' </summary>
''' <remarks></remarks>
Public MustInherit Class CIM_Components
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
