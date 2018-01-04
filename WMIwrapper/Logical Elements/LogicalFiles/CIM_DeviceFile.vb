Imports System.Management

''' <summary>
''' Represents a type of logical file, which represents a device.
''' </summary>
''' <remarks>
''' <para>
''' This convention is useful for operating systems that manage devices using a byte stream I/O model.
''' The logical device that is associated with this file is specified using the <see cref="T:WMIwrapper.CIM_DeviceAccessedByFile"></see> relationship.
''' </para>
''' <para>See <a href="http://msdn2.microsoft.com/en-us/library/aa387244(VS.85).aspx">MSDN</a>.</para>
''' </remarks>
Public Class CIM_DeviceFile
    Inherits CIM_LogicalFile

    ''' <summary>
    ''' Constructor. 
    ''' </summary>
    ''' <param name="ManagementObject">The underlying management object.</param>
    ''' <remarks>Use this constructor when the management object already exists (e.g. read from a collection).</remarks>
    Public Sub New(ByVal ManagementObject As ManagementObject)
        MyBase.New(ManagementObject)
    End Sub

    ''' <summary>
    ''' Constructor. 
    ''' </summary>
    ''' <param name="ManagementBaseObject">The underlying management base object.</param>
    ''' <remarks>
    ''' Alternate constructor, to use when a management base object is available instead of a management object.
    ''' Management base objects are returned as out parameters of methods.
    ''' </remarks>
    Public Sub New(ByVal ManagementBaseObject As ManagementBaseObject)
        MyBase.New(ManagementBaseObject)
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

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.CIM_DeviceFile"></see>.
''' </summary>
''' <remarks></remarks>
Public MustInherit Class CIM_DeviceFiles
    Inherits CIM_LogicalFiles

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
