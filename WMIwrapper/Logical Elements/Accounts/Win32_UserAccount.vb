Imports System.Management

''' <summary>
''' Contains information about a user account on a computer system running Windows.
''' </summary>
''' <remarks>
''' <para>Enumerating Win32_UserAccount on a large network can negatively affect performance.</para>
''' <para>See <a href="http://msdn.microsoft.com/en-us/library/aa394507(VS.85).aspx">MSDN</a>.</para>
''' </remarks>
Public Class Win32_UserAccount
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

#Region "Properties"

    ''' <summary>
    ''' Flags that describe the characteristics of a Windows user account.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' </remarks>
    Public ReadOnly Property AccountType() As Enums.AccountType
        Get
            Dim obj As Object = GetPropertyObject("AccountType")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.AccountType)
            End If
        End Get

    End Property

    ''' <summary>
    ''' Indicates the account is disabled.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    Public ReadOnly Property Disabled() As Boolean
        Get
            Return GetBooleanProperty("Disabled")
        End Get
    End Property

    ''' <summary>
    ''' Full name of a local user.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    Public ReadOnly Property FullName() As String
        Get
            Return GetStringProperty("FullName")
        End Get
    End Property

    ''' <summary>
    ''' Indicates the user account is locked out of the Windows operating system.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    Public ReadOnly Property Lockout() As Boolean
        Get
            Return GetBooleanProperty("Lockout")
        End Get
    End Property

    ''' <summary>
    ''' Indicates the password on this user account can be changed.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    Public ReadOnly Property PasswordChangeable() As Boolean
        Get
            Return GetBooleanProperty("PasswordChangeable")
        End Get
    End Property

    ''' <summary>
    ''' Indicates the password on this user account expires.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    Public ReadOnly Property PasswordExpires() As Boolean
        Get
            Return GetBooleanProperty("PasswordExpires")
        End Get
    End Property

    ''' <summary>
    ''' Indicates whether a password is required on a Windows user account.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    Public ReadOnly Property PasswordRequired() As Boolean
        Get
            Return GetBooleanProperty("PasswordRequired")
        End Get
    End Property

#End Region

#Region "Methods"

    ''' <summary>
    ''' Renames a user account name.
    ''' </summary>
    ''' <param name="Name">The new account name.</param>
    ''' <returns></returns>
    ''' <remarks>
    ''' This functionality is implemented as a method to provide a separate context for the new name that is distinguishable from the key property value for Name that is associated with the instance to be modified.
    ''' </remarks>
    Public Function Rename(ByVal Name As String) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_UserAccount"), Nothing)
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
                Return "Error - User not found"
            Case 5
                Return "Error - Domain not found"
            Case 6
                Return "Error - Operation is allowed only on the primary domain controller of the domain"
            Case 7
                Return "Error - Operation is not allowed on the last administrative account"
            Case 8
                Return "Error - Operation is not allowed on specified special accounts: user, admin, local, or guest"
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
''' Collection of <see cref="T:WMIwrapper.Win32_UserAccount"></see>.
''' </summary>
''' <remarks></remarks>
Public Class Win32_UserAccounts
    Inherits Win32_Accounts

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <param name="Domain">The domain to restrict the selection to. Ignored if <code>Condition</code> is set=.</param>
    ''' <param name="Name">The account name to restrict the selection to. Ignored if <code>Condition</code> is set.</param>
    ''' <param name="Condition">WQL condition can be specified. It is not checked and sent to WMI as is.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Computer As String, Optional ByVal Domain As String = Nothing, Optional ByVal Name As String = Nothing, Optional ByVal Condition As String = Nothing)

        MyBase.New(Computer, "Win32_UserAccount")
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
            Me.Add(New Win32_UserAccount(ManagementObjectI))
        Next

    End Sub

    ''' <summary>
    ''' Find an item in the collection.
    ''' </summary>
    ''' <param name="index">Index of the item.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal index As Integer) As Win32_UserAccount
        Return CType(List.Item(index), Win32_UserAccount)
    End Function

    ''' <summary>
    ''' Find an item by its domain and name.
    ''' </summary>
    ''' <param name="Domain">The account domain.</param>
    ''' <param name="Name">The account name.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal Domain As String, ByVal Name As String) As Win32_UserAccount
        For intI As Integer = 0 To List.Count - 1
            Using Win32_UserAccount As Win32_UserAccount = Me.Item(intI)
                With Win32_UserAccount
                    If .Name = Name And .Domain = Domain Then
                        Return Me.Item(intI)
                    End If
                End With
            End Using
        Next
        Return Nothing
    End Function

End Class



Namespace Enums

    ''' <summary>
    ''' Flags that describe the characteristics of a Windows user account.
    ''' </summary>
    ''' <remarks></remarks>
    <Flags()> _
    Public Enum AccountType As UInt32

        ''' <summary>
        ''' Local user account for users who have a primary account in another domain.
        ''' </summary>
        ''' <remarks>
        ''' This account provides user access to this domain only—not to any domain that trusts this domain.
        ''' </remarks>
        UF_TEMP_DUPLICATE_ACCOUNT = &H100

        ''' <summary>
        ''' Default account type that represents a typical user.
        ''' </summary>
        ''' <remarks></remarks>
        UF_NORMAL_ACCOUNT = &H200

        ''' <summary>
        ''' Account for a system domain that trusts other domains.
        ''' </summary>
        ''' <remarks></remarks>
        UF_INTERDOMAIN_TRUST_ACCOUNT = &H800

        ''' <summary>
        ''' Computer account for a computer system running Windows 2000 or Windows NT that is a member of this domain.
        ''' </summary>
        ''' <remarks></remarks>
        UF_WORKSTATION_TRUST_ACCOUNT = &H1000

        ''' <summary>
        ''' Account for a system backup domain controller that is a member of this domain.
        ''' </summary>
        ''' <remarks></remarks>
        UF_SERVER_TRUST_ACCOUNT = &H8192

    End Enum

End Namespace
