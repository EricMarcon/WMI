Imports System.Management

''' <summary>
''' Represents a baseboard, which is also known as a motherboard or system board.
''' </summary>
''' <remarks>
''' See <a href="http://msdn.microsoft.com/en-us/library/aa394072(VS.85).aspx">MSDN</a>
''' </remarks>
Public Class Win32_BaseBoard
    Inherits CIM_Card

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

#Region "Properties"

    ''' <summary>
    ''' Array that represents the configuration of the jumpers and switches located on the baseboard.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' Example: "JP2: 1-2 Cache Size is 256K, 2-3 Cache Size is 512K, SW1-1: Close to Disable On Board Video"
    ''' </remarks>
    Public ReadOnly Property ConfigOptions() As String()
        Get
            Return GetStringArrayProperty("ConfigOptions")
        End Get
    End Property

    ''' <summary>
    ''' Baseboard part number defined by the manufacturer.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    Public ReadOnly Property Product() As String
        Get
            Return GetStringProperty("Product")
        End Get
    End Property

#End Region

End Class

''' <summary>
''' Collection of <see cref="T:WMIwrapper.Win32_BaseBoard"></see>.
''' </summary>
''' <remarks></remarks>
Public Class Win32_BaseBoards
    Inherits CIM_Cards

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <param name="Tag">If specified, only the item corresponding to this key value is returned. Ignored if <code>Condition</code> is set.</param>
    ''' <param name="Condition">WQL condition can be specified. It is not checked and sent to WMI as is.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Computer As String, Optional ByVal Tag As String = Nothing, Optional ByVal Condition As String = Nothing)

        MyBase.New(Computer, "Win32_BaseBoard")
        ' Prepare condition
        If Condition Is Nothing AndAlso Tag IsNot Nothing Then
            Condition = "Tag ='" & Tag & "'"
        End If
        ' Read the collection
        For Each ManagementObjectI As ManagementObject In Me.Read(Condition)
            Me.Add(New Win32_BaseBoard(ManagementObjectI))
        Next

    End Sub

    ''' <summary>
    ''' Find an item in the collection.
    ''' </summary>
    ''' <param name="index">Index of the item.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal index As Integer) As Win32_BaseBoard
        Return CType(List.Item(index), Win32_BaseBoard)
    End Function

    ''' <summary>
    ''' Find an item by its tag.
    ''' </summary>
    ''' <param name="Tag">The item's tag.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal Tag As String) As Win32_BaseBoard
        For intI As Integer = 0 To List.Count - 1
            If Me.Item(intI).Tag = Tag Then
                Return Me.Item(intI)
            End If
        Next
        Return Nothing
    End Function

End Class
