Imports System.Management

''' <summary>
''' Disk Drive Physical Media.
''' </summary>
''' <remarks>
''' <para>
''' Mapping between a disk drive and the physical components that implement it.
''' </para>
''' <para>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa394133.aspx">MSDN</a>
''' </para>
''' </remarks>
Public Class Win32_DiskDrivePhysicalMedia
    Inherits WMIobject

    ''' <summary>
    ''' Constructor. 
    ''' </summary>
    ''' <param name="ManagementObject">The underlying management object.</param>
    ''' <remarks>Use this constructor when the management object already exists (e.g. read from a collection).</remarks>
    Public Sub New(ByVal ManagementObject As ManagementObject)
        MyBase.New(ManagementObject)
        ' Get the adapter and its configuration. Path strings are in the properties.
        _Antecedent = New Win32_PhysicalMedia(New ManagementPath(_ManagementObject.GetPropertyValue("Antecedent").ToString))
        _Dependent = New Win32_DiskDrive(New ManagementPath(_ManagementObject.GetPropertyValue("Dependent").ToString))
    End Sub

    Private _Antecedent As Win32_PhysicalMedia
    ''' <summary>
    ''' Physical component that implements the device.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Element() As Win32_PhysicalMedia
        Get
            Return _Antecedent
        End Get
    End Property

    Private _Dependent As Win32_DiskDrive
    ''' <summary>
    ''' Logical device.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Setting() As Win32_DiskDrive
        Get
            Return _Dependent
        End Get
    End Property

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.Win32_DiskDrivePhysicalMedia"></see>.
''' </summary>
''' <remarks></remarks>
Public Class Win32_DiskDrivePhysicalMedias
    Inherits WMIobjects

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Computer As String)

        MyBase.New(Computer, "Win32_DiskDrivePhysicalMedia")
        ' Read the collection
        For Each ManagementObjectI As ManagementObject In Me.Read()
            Me.Add(New Win32_DiskDrivePhysicalMedia(ManagementObjectI))
        Next

    End Sub

    ''' <summary>
    ''' Find an item in the collection.
    ''' </summary>
    ''' <param name="index">Index of the item.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal index As Integer) As Win32_DiskDrivePhysicalMedia
        Return CType(List.Item(index), Win32_DiskDrivePhysicalMedia)
    End Function

End Class
