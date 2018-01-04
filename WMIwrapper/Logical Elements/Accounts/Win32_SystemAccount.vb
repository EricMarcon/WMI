Imports System.Management

''' <summary>
''' Represents a system account.
''' </summary>
''' <remarks>
''' <para>
''' The system account is used by the operating system and services that run under Windows NT.
''' There are many services and processes within Windows NT that need the capability to logon internally, for example, during a Windows NT installation.
''' The system account was designed for that purpose.
''' </para>
''' <para>
''' The system account is an internal account that does not show up in User Manager, cannot be added to any groups, and cannot have user rights assigned to it.
''' However, the system account does show up on an NTFS file system volume in file manager, which is located in the Permissions section of the Security menu.
''' By default, the system account is granted full control to all files on an NTFS file system volume, which means that the system account has the same functional privileges as the administrator account.
''' </para>
''' <para>See <a href="http://msdn.microsoft.com/en-us/library/aa394466(VS.85).aspx">MSDN</a>.</para>
''' </remarks>
Public Class Win32_SystemAccount
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

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.Win32_SystemAccount"></see>.
''' </summary>.
''' <remarks>This collection contains all builtin accounts, such as "Everyone".</remarks>
Public Class Win32_SystemAccounts
    Inherits Win32_Accounts

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <param name="Domain">The domain to restrict the selection to. Ignored if <code>Condition</code> is set=.</param>
    ''' <param name="Name">The account name to restrict the selection to. Ignored if <code>Condition</code> is set.</param>
    ''' <param name="Condition">WQL condition can be specified. It is not checked and sent to WMI as is.</param>
    ''' <remarks>
    ''' Names are localized. You may prefer to use SID's (see <a href="http://support.microsoft.com/kb/243330">well known SIDs</a>):
    ''' set <code>Condition</code> to <code>SID = 'S-1-1-0'</code> for Everyone or <code>SID LIKE S-1-5-%-512</code> for domain admins.
    ''' </remarks>
    Public Sub New(ByVal Computer As String, Optional ByVal Domain As String = Nothing, Optional ByVal Name As String = Nothing, Optional ByVal Condition As String = Nothing)

        MyBase.New(Computer, "Win32_SystemAccount")
        ' Prepare condition
        If Condition Is Nothing Then
            If Domain IsNot Nothing Then
                Condition = "Domain ='" & Domain & "'"
                If Name IsNot Nothing Then
                    Condition &= " AND "
                End If
            End If
            If Name IsNot Nothing Then
                Condition = "Name ='" & Name & "'"
            End If
        End If
        ' Read the collection
        For Each ManagementObjectI As ManagementObject In Me.Read(Condition)
            Me.Add(New Win32_SystemAccount(ManagementObjectI))
        Next

    End Sub

    ''' <summary>
    ''' Find an item in the collection.
    ''' </summary>
    ''' <param name="index">Index of the item.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal index As Integer) As Win32_SystemAccount
        Return CType(List.Item(index), Win32_SystemAccount)
    End Function

    ''' <summary>
    ''' Find an item by its domain and name.
    ''' </summary>
    ''' <param name="Domain">The account domain.</param>
    ''' <param name="Name">The account name.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal Domain As String, ByVal Name As String) As Win32_SystemAccount
        For intI As Integer = 0 To List.Count - 1
            Using Win32_SystemAccount As Win32_SystemAccount = Me.Item(intI)
                With Win32_SystemAccount
                    If .Name = Name And .Domain = Domain Then
                        Return Me.Item(intI)
                    End If
                End With
            End Using
        Next
        Return Nothing
    End Function

End Class
