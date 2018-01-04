Imports System.Management

''' <summary>
''' Represents the file used for handling virtual memory file swapping on a Win32 system.
''' </summary>
''' <remarks>
''' <para>
''' This class has been deprecated.
''' </para>
''' <para>See <a href="http://msdn2.microsoft.com/en-us/library/aa394243(VS.85).aspx">MSDN</a>.</para>
''' </remarks>
Public Class Win32_PageFile
    Inherits CIM_DataFile

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

#Region "Properties"

    ''' <summary>
    ''' Space available in the paging file, in megabytes. Deprecated.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' The operating system can enlarge the paging file as necessary, up to the limit imposed by the user.
    ''' This property shows the difference between the size of current committed memory and the current size of the paging file; it does not show the largest possible size of the paging file.
    ''' </remarks>
    Public ReadOnly Property FreeSpace() As UInt32
        Get
            Return GetUint32Property("FreeSpace")
        End Get
    End Property

    ''' <summary>
    ''' Initial size of the page file, in megabytes. Deprecated.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' </remarks>
    Public ReadOnly Property InitialSize() As UInt32
        Get
            Return GetUint32Property("InitialSize")
        End Get
    End Property

    ''' <summary>
    ''' Maximum size of the page file as set by the user, in megabytes. Deprecated.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' The operating system will not allow the page file to exceed this limit.
    ''' </remarks>
    Public ReadOnly Property MaximumSize() As UInt32
        Get
            Return GetUint32Property("MaximumSize")
        End Get
    End Property

#End Region

    ' TODO : methods

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.Win32_PageFile"></see>.
''' </summary>
''' <remarks></remarks>
Public MustInherit Class Win32_PageFiles
    Inherits CIM_DataFiles

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <param name="Name">If specified, only the item corresponding to this key value is returned. Ignored if <code>Condition</code> is set.</param>
    ''' <param name="Condition">WQL condition can be specified. It is not checked and sent to WMI as is.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Computer As String, Optional ByVal Name As String = Nothing, Optional ByVal Condition As String = Nothing)

        MyBase.New(Computer, "Win32_PageFile")
        ' Prepare condition
        If Condition Is Nothing AndAlso Name IsNot Nothing Then
            Condition = "Name ='" & Name & "'"
        End If
        ' Read the collection
        For Each ManagementObjectI As ManagementObject In Me.Read(Condition)
            Me.Add(New Win32_PageFile(ManagementObjectI))
        Next

    End Sub

    ''' <summary>
    ''' Find an item by its index in the collection.
    ''' </summary>
    ''' <param name="index">0-based index of the item in the collection.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal index As Integer) As Win32_PageFile
        Return CType(List.Item(index), Win32_PageFile)
    End Function

    ''' <summary>
    ''' Find an item by its name.
    ''' </summary>
    ''' <param name="Name">The file name.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal Name As String) As Win32_PageFile
        For intI As Integer = 0 To List.Count - 1
            If Me.Item(intI).Name = Name Then
                Return Me.Item(intI)
            End If
        Next
        Return Nothing
    End Function

End Class
