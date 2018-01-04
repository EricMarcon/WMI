Imports System.Management

''' <summary>
''' Represents files that are shortcuts to other files, directories, and commands.
''' </summary>
''' <remarks>
''' <para>See <a href="http://msdn2.microsoft.com/en-us/library/aa394438(VS.85).aspx">MSDN</a>.</para>
''' </remarks>
Public Class Win32_ShortcutFile
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
    ''' Name of the object that this is a shortcut to.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' </remarks>
    Public ReadOnly Property Target() As String
        Get
            Return GetStringProperty("Target")
        End Get
    End Property

#End Region

    ' TODO : methods

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.Win32_ShortcutFile"></see>.
''' </summary>
''' <remarks></remarks>
Public Class Win32_ShortcutFiles
    Inherits CIM_DataFiles

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <param name="Name">If specified, only the item corresponding to this key value is returned. Ignored if <code>Condition</code> is set.</param>
    ''' <param name="Condition">WQL condition can be specified. It is not checked and sent to WMI as is.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Computer As String, Optional ByVal Name As String = Nothing, Optional ByVal Condition As String = Nothing)

        MyBase.New(Computer, "Win32_ShortcutFile")
        ' Prepare condition
        If Condition Is Nothing AndAlso Name IsNot Nothing Then
            Condition = "Name ='" & Name & "'"
        End If
        ' Read the collection
        For Each ManagementObjectI As ManagementObject In Me.Read(Condition)
            Me.Add(New Win32_ShortcutFile(ManagementObjectI))
        Next

    End Sub


    ''' <summary>
    ''' Find an item by its index in the collection.
    ''' </summary>
    ''' <param name="index">0-based index of the item in the collection.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal index As Integer) As Win32_ShortcutFile
        Return CType(List.Item(index), Win32_ShortcutFile)
    End Function

    ''' <summary>
    ''' Find an item by its name.
    ''' </summary>
    ''' <param name="Name">The file name.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal Name As String) As Win32_ShortcutFile
        For intI As Integer = 0 To List.Count - 1
            If Me.Item(intI).Name = Name Then
                Return Me.Item(intI)
            End If
        Next
        Return Nothing
    End Function

End Class
