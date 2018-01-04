Imports System.Management

''' <summary>
''' Represents any type of documentation or storage medium, such as tapes, CD ROMs, and so on.
''' </summary>
''' <remarks>
''' <para>
''' To obtain the characteristics of the media in a CD drive, such as whether it is writeable,
''' use <see cref="T:WMIwrapper.Win32_CDROMDrive"></see> and the Capabilities property.
''' </para>
''' <para>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa394346.aspx">MSDN</a>
''' </para>
''' </remarks>
Public Class Win32_PhysicalMedia
    Inherits CIM_PhysicalMedia
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

    ' All properties are inherited.

    ' All methods are inherited.

End Class

''' <summary>
''' Collection of <see cref="T:WMIwrapper.Win32_PhysicalMedia"></see>.
''' </summary>
''' <remarks></remarks>
Public Class Win32_PhysicalMedias
    Inherits CIM_PhysicalMedias

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <param name="Tag">If specified, only the item corresponding to this key value is returned. Ignored if <code>Condition</code> is set.</param>
    ''' <param name="Condition">WQL condition can be specified. It is not checked and sent to WMI as is.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Computer As String, Optional ByVal Tag As String = Nothing, Optional ByVal Condition As String = Nothing)

        MyBase.New(Computer, "Win32_PhysicalMedia")
        ' Prepare condition
        If Condition Is Nothing AndAlso Tag IsNot Nothing Then
            Condition = "Tag ='" & Tag & "'"
        End If
        ' Read the collection
        For Each ManagementObjectI As ManagementObject In Me.Read(Condition)
            Me.Add(New Win32_PhysicalMedia(ManagementObjectI))
        Next

    End Sub

    ''' <summary>
    ''' Find an item in the collection.
    ''' </summary>
    ''' <param name="index">Index of the item.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal index As Integer) As Win32_PhysicalMedia
        Return CType(List.Item(index), Win32_PhysicalMedia)
    End Function

    ''' <summary>
    ''' Find an item by its tag.
    ''' </summary>
    ''' <param name="Tag">The item's tag.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal Tag As String) As Win32_PhysicalMedia
        For intI As Integer = 0 To List.Count - 1
            If Me.Item(intI).Tag = Tag Then
                Return Me.Item(intI)
            End If
        Next
        Return Nothing
    End Function

End Class