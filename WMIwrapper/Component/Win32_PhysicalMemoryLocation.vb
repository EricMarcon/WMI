Imports System.Management

''' <summary>
''' Relates an array of physical memory and its physical memory.
''' </summary>
''' <remarks>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa394349.aspx">MSDN</a>
''' </remarks>
Public Class Win32_PhysicalMemoryLocation
    Inherits CIM_PackagedComponent

    ''' <summary>
    ''' Constructor. 
    ''' </summary>
    ''' <param name="ManagementObject">The underlying management object.</param>
    ''' <remarks>Use this constructor when the management object already exists (e.g. read from a collection).</remarks>
    Public Sub New(ByVal ManagementObject As ManagementObject)
        MyBase.New(ManagementObject)
        ' Get the two managed system elements. Path strings are in the properties.
        _GroupComponent = New Win32_PhysicalMemoryArray(New ManagementPath(_ManagementObject.GetPropertyValue("GroupComponent").ToString))
        _PartComponent = New Win32_PhysicalMemory(New ManagementPath(_ManagementObject.GetPropertyValue("PartComponent").ToString))
    End Sub

    Private _GroupComponent As Win32_PhysicalMemoryArray
    ''' <summary>
    ''' Physical memory array that contains the physical memory.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads ReadOnly Property GroupComponent() As Win32_PhysicalMemoryArray
        Get
            Return _GroupComponent
        End Get
    End Property

    Private _PartComponent As Win32_PhysicalMemory
    ''' <summary>
    ''' Physical memory contained in the physical memory array.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads ReadOnly Property PartComponent() As Win32_PhysicalMemory
        Get
            Return _PartComponent
        End Get
    End Property

End Class


''' <summary>
''' Collection of <see cref="T:WMIwrapper.Win32_PhysicalMemoryLocation"></see>.
''' </summary>
''' <remarks></remarks>
Public Class Win32_PhysicalMemoryLocations
    Inherits CIM_PackagedComponents

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Computer As String)

        MyBase.New(Computer, "Win32_PhysicalMemoryLocation")
        ' Read the collection
        For Each ManagementObjectI As ManagementObject In Me.Read()
            Me.Add(New Win32_PhysicalMemoryLocation(ManagementObjectI))
        Next

    End Sub

    ''' <summary>
    ''' Find an item in the collection.
    ''' </summary>
    ''' <param name="index">Index of the item.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal index As Integer) As Win32_PhysicalMemoryLocation
        Return CType(List.Item(index), Win32_PhysicalMemoryLocation)
    End Function

End Class
