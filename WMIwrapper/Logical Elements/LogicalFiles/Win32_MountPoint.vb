Imports System.Management

''' <summary>
''' Associates a volume to the directory where it is mounted.
''' </summary>
''' <remarks>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa394205(VS.85).aspx">MSDN</a>
''' </remarks>
Public Class Win32_MountPoint
    Inherits WMIobject

    ''' <summary>
    ''' Constructor. 
    ''' </summary>
    ''' <param name="ManagementObject">The underlying management object.</param>
    ''' <remarks>Use this constructor when the management object already exists (e.g. read from a collection).</remarks>
    Public Sub New(ByVal ManagementObject As ManagementObject)
        MyBase.New(ManagementObject)
        ' Get the two managed system elements. Path strings are in the properties.
        _Directory = New Win32_Directory(New ManagementPath(_ManagementObject.GetPropertyValue("Directory").ToString))
        _Volume = New Win32_Volume(New ManagementPath(_ManagementObject.GetPropertyValue("Volume").ToString))
    End Sub

    Private _Directory As Win32_Directory
    ''' <summary>
    ''' Reference to the directory where the volume is mounted.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads ReadOnly Property Directory() As Win32_Directory
        Get
            Return _Directory
        End Get
    End Property

    Private _Volume As Win32_Volume
    ''' <summary>
    ''' Reference to the mounted volume.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads ReadOnly Property Volume() As Win32_Volume
        Get
            Return _Volume
        End Get
    End Property

End Class


''' <summary>
''' Collection of <see cref="Win32_MountPoint"></see>.
''' </summary>
''' <remarks></remarks>
Public Class Win32_MountPoints
    Inherits WMIobjects

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Computer As String)

        MyBase.New(Computer, "Win32_MountPoint")
        ' Read the collection
        For Each ManagementObjectI As ManagementObject In Me.Read()
            Me.Add(New Win32_MountPoint(ManagementObjectI))
        Next

    End Sub

    ''' <summary>
    ''' Find an item in the collection.
    ''' </summary>
    ''' <param name="index">Index of the item.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal index As Integer) As Win32_MountPoint
        Return CType(List.Item(index), Win32_MountPoint)
    End Function

End Class
