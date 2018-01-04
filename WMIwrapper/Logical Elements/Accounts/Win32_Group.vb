Imports System.Management

''' <summary>
''' Contains data about a group account.
''' </summary>
''' <remarks>
''' <para>See <a href="http://msdn.microsoft.com/en-us/library/aa394151(VS.85).aspx">MSDN</a>.</para>
''' </remarks>
Public Class Win32_Group
    Inherits Win32_Account

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

    ' All properties are inherited.

#Region "Methods"

    ''' <summary>
    ''' Allows the group name to be changed.
    ''' </summary>
    ''' <param name="Name">The new group name.</param>
    ''' <returns></returns>
    ''' <remarks>
    ''' </remarks>
    Public Function Rename(ByVal Name As String) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_Group"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("Rename")
        inParams("Name") = Name

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("Rename", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Error messages for the methods of this class.
    ''' </summary>
    ''' <param name="Number">Error number.</param>
    ''' <returns>A string containing the error message.</returns>
    ''' <remarks></remarks>
    Protected Overrides Function ErrorMessage(ByVal Number As UInteger) As String
        Select Case Number
            Case 0
                Return "Success"
            Case 1
                Return "Error - Instance not found"
            Case 2
                Return "Error - Instance required"
            Case 3
                Return "Error - Invalid parameter"
            Case 4
                Return "Error - Group not found"
            Case 5
                Return "Error - Domain not found"
            Case 6
                Return "Error - Operation is allowed only on the primary domain controller of the domain"
            Case 7
                Return "Error - Operation is not allowed on the last administrative account"
            Case 8
                Return "Error - Operation is not allowed on specified special groups: user, admin, local, or guest"
            Case 9
                Return "Error - Other API error"
            Case 10
                Return "Error - Internal error"
            Case Else
                Return "Unknown Error"
        End Select
    End Function

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.Win32_Group"></see>.
''' </summary>
''' <remarks></remarks>
Public Class Win32_Groups
    Inherits Win32_Accounts

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Computer As String)

        MyBase.New(Computer, "Win32_Group")
        ' Read the collection
        For Each ManagementObjectI As ManagementObject In Me.Read()
            Me.Add(New Win32_Group(ManagementObjectI))
        Next

    End Sub

    ''' <summary>
    ''' Find an item in the collection.
    ''' </summary>
    ''' <param name="index">Index of the item.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal index As Integer) As Win32_Group
        Return CType(List.Item(index), Win32_Group)
    End Function

    ''' <summary>
    ''' Find an item by its domain and name.
    ''' </summary>
    ''' <param name="Domain">The account domain.</param>
    ''' <param name="Name">The account name.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal Domain As String, ByVal Name As String) As Win32_Group
        For intI As Integer = 0 To List.Count - 1
            Using Win32_Group As Win32_Group = Me.Item(intI)
                With Win32_Group
                    If .Name = Name And .Domain = Domain Then
                        Return Me.Item(intI)
                    End If
                End With
            End Using
        Next
        Return Nothing
    End Function

End Class
