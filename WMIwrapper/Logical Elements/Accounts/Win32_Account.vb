Imports System.Management

''' <summary>
''' Contains information about user accounts and group accounts known to the computer system running Windows.
''' </summary>
''' <remarks>
''' <para>User or group names recognized by a Windows NT domain are descendants (or members) of this class.</para>
''' <para>See <a href="http://msdn.microsoft.com/en-us/library/aa394061(VS.85).aspx">MSDN</a>.</para>
''' </remarks>
Public MustInherit Class Win32_Account
    Inherits CIM_LogicalElement

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
    ''' Name of the Windows domain to which a group or user belongs.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' </remarks>
    Public ReadOnly Property Domain() As String
        Get
            Return GetStringProperty("Domain")
        End Get
    End Property

    ''' <summary>
    ''' Indicates the account is defined on the local machine.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Windows 2000 and Windows NT 4.0 SP4 and later:  This property is not available.</remarks>
    Public ReadOnly Property LocalAccount() As Boolean
        Get
            Return GetBooleanProperty("LocalAccount")
        End Get
    End Property

    ''' <summary>
    ''' Security identifier (SID) for this account.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' A SID is a string value of variable length used to identify a trustee.
    ''' Each account has a unique SID issued by an authority (such as a Windows domain), stored in a security database.
    ''' When a user logs on, the system retrieves the user's SID from the database and places it in the user's access token.
    ''' The system uses the SID in the user's access token to identify the user in all subsequent interactions with Windows security.
    ''' When a SID has been used as the unique identifier for a user or group, it cannot be used again to identify another user or group.
    ''' </remarks>
    Public ReadOnly Property SID() As String
        Get
            Return GetStringProperty("SID")
        End Get
    End Property

    ''' <summary>
    ''' Name of the Windows domain to which a group or user belongs.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' </remarks>
    Public ReadOnly Property SIDType() As Enums.SIDType
        Get
            Dim obj As Object = GetPropertyObject("SIDType")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.SIDType)
            End If
        End Get

    End Property

#End Region

    ' No Methods

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.Win32_Account"></see>.
''' </summary>
''' <remarks></remarks>
Public MustInherit Class Win32_Accounts
    Inherits CIM_LogicalElements

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">Host Computer.</param>
    ''' <param name="ClassName">Class name.</param>
    ''' <remarks></remarks>
    Friend Sub New(ByVal Computer As String, ByVal ClassName As String)
        MyBase.New(Computer, ClassName)
    End Sub

End Class



Namespace Enums

    ''' <summary>
    ''' Type of security identifier (SID).
    ''' </summary>
    ''' <remarks>Original data type is UInt8, which is not supported in .NET.</remarks>
    Public Enum SIDType As Integer
        ''' <summary>
        ''' User.
        ''' </summary>
        ''' <remarks></remarks>
        SidTypeUser = 1
        ''' <summary>
        ''' Group.
        ''' </summary>
        ''' <remarks></remarks>
        SidTypeGroup
        ''' <summary>
        ''' Domain.
        ''' </summary>
        ''' <remarks></remarks>
        SidTypeDomain
        ''' <summary>
        ''' Alias.
        ''' </summary>
        ''' <remarks></remarks>
        SidTypeAlias
        ''' <summary>
        ''' Well-known group.
        ''' </summary>
        ''' <remarks></remarks>
        SidTypeWellKnownGroup
        ''' <summary>
        ''' Deleted account
        ''' </summary>
        ''' <remarks></remarks>
        SidTypeDeletedAccount
        ''' <summary>
        ''' Invalid.
        ''' </summary>
        ''' <remarks></remarks>
        SidTypeInvalid
        ''' <summary>
        ''' Unknown.
        ''' </summary>
        ''' <remarks></remarks>
        SidTypeUnknown
        ''' <summary>
        ''' Computer
        ''' </summary>
        ''' <remarks></remarks>
        SidTypeComputer
    End Enum

End Namespace
