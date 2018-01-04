Imports System.Management

''' <summary>
''' Specifies an access control entry (ACE).
''' </summary>
''' <remarks>
''' <para>
''' An ACE grants permission to execute a restricted operation, such as writing to a file or formatting a disk.
''' An ACE that is specific to WMI allows logon, remote access, method execution, and writing to the WMI repository.
''' </para>
''' <para>See <a href="http://msdn2.microsoft.com/en-us/library/aa394063.aspx">MSDN</a>.</para>
''' </remarks>
Public Class Win32_ACE
    Inherits WMIobject

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        MyBase.New("Win32_ACE")
    End Sub

    ''' <summary>
    ''' Constructor. 
    ''' </summary>
    ''' <param name="ManagementObject">The underlying management object.</param>
    ''' <remarks>Use this constructor when the management object already exists (e.g. read from a collection).</remarks>
    Public Sub New(ByVal ManagementObject As ManagementObject)
        MyBase.New(ManagementObject)
    End Sub

#Region "Properties"

    ''' <summary> 
    ''' Bit flags that indicate rights granted or denied to the trustee.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property AccessMask() As Enums.AccessMask
        Get
            Dim obj As Object = GetPropertyObject("AccessMask")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.AccessMask)
            End If
        End Get
        Set(ByVal value As Enums.AccessMask)
            _ManagementObject.SetPropertyValue("AccessMask", value)
        End Set
    End Property

    ''' <summary>
    ''' Bit flags that specify inheritance of the ACE.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property AceFlags() As Enums.AceFlags
        Get
            Dim obj As Object = GetPropertyObject("AceFlags")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.AceFlags)
            End If
        End Get
        Set(ByVal value As Enums.AceFlags)
            _ManagementObject.SetPropertyValue("AceFlags", value)
        End Set
    End Property

    ''' <summary>
    ''' Type of ACE.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property AceType() As Enums.AceType
        Get
            Dim obj As Object = GetPropertyObject("AceType")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.AceType)
            End If
        End Get
        Set(ByVal value As Enums.AceType)
            _ManagementObject.SetPropertyValue("AceType", value)
        End Set
    End Property

    ''' <summary>
    ''' Globally unique identifier (GUID) associated with the parent of the object to which these rights apply.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property GuidInheritedObjectType() As String
        Get
            Return GetStringProperty("GuidInheritedObjectType")
        End Get
        Set(ByVal value As String)
            _ManagementObject.SetPropertyValue("GuidInheritedObjectType", value)
        End Set
    End Property

    ''' <summary>
    ''' GUID associated with the type of object to which these rights apply.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property GuidObjectType() As String
        Get
            Return GetStringProperty("GuidObjectType")
        End Get
        Set(ByVal value As String)
            _ManagementObject.SetPropertyValue("GuidObjectType", value)
        End Set
    End Property

    ''' <summary>
    ''' Object representing the user account, group account, or logon session to which an ACE applies.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Trustee() As Win32_Trustee
        Get
            Return GetTrustee()
        End Get
        Set(ByVal value As Win32_Trustee)
            _ManagementObject.SetPropertyValue("Trustee", value.ManagementObject)
        End Set
    End Property

#End Region

    ''' <summary>
    ''' Read the object of interest inside the ManagementBaseObject return by <see cref="M:WMIwrapper.Win32_ACE.InvokeMethod"></see>
    ''' </summary>
    ''' <param name="mbo">The ManagementBaseObject to unwrap.</param>
    ''' <remarks></remarks>
    Friend Sub ReadFromManagementBaseObject(ByVal mbo As ManagementBaseObject)
        With Me
            .AccessMask = CType(mbo.Item("AccessMask"), Enums.AccessMask)
            .AceFlags = CType(mbo.Item("AceFlags"), Enums.AceFlags)
            .AceType = CType(mbo.Item("AceFlags"), Enums.AceType)
            .GuidInheritedObjectType = TryCast(mbo.Item("AceFlags"), String)
            .GuidObjectType = TryCast(mbo.Item("GuidObjectType"), String)
            ' Read Trustee
            Dim mboTrustee As Management.ManagementBaseObject = CType(mbo.Properties.Item("Trustee").Value, Management.ManagementBaseObject)
            If mboTrustee IsNot Nothing Then
                Dim Trustee As New Win32_Trustee
                Trustee.ReadFromManagementBaseObject(mboTrustee)
                .Trustee = Trustee
            End If
        End With
    End Sub

End Class



Namespace Enums

    ''' <summary>
    ''' Access rights to the share held by the user or group.
    ''' </summary>
    ''' <remarks></remarks>
    <Flags()> _
    Public Enum AccessMask As UInteger

        ''' <summary>
        ''' Grants the right to list the contents of the directory.
        ''' </summary>
        ''' <remarks></remarks>
        FILE_LIST_DIRECTORY = 1

        ''' <summary>
        ''' Grants the right to read data from the file.
        ''' </summary>
        ''' <remarks></remarks>
        FILE_READ_DATA = 1

        ''' <summary>
        ''' Grants the right to create a file in the directory.
        ''' </summary>
        ''' <remarks></remarks>
        FILE_ADD_FILE = 2

        ''' <summary>
        ''' Grants the right to write data to the file. 
        ''' </summary>
        ''' <remarks></remarks>
        FILE_WRITE_DATA = 2

        ''' <summary>
        ''' Grants the right to create a subdirectory.
        ''' </summary>
        ''' <remarks></remarks>
        FILE_ADD_SUBDIRECTORY = 4

        ''' <summary>
        ''' Grants the right to append data to the file. 
        ''' </summary>
        ''' <remarks></remarks>
        FILE_APPEND_DATA = 4

        ''' <summary>
        ''' Grants the right to read extended attributes.
        ''' </summary>
        ''' <remarks></remarks>
        FILE_READ_EA = 8

        ''' <summary>
        ''' Grants the right to write extended attributes.
        ''' </summary>
        ''' <remarks></remarks>
        FILE_WRITE_EA = 16

        ''' <summary>
        ''' Allows the directory to be traversed.
        ''' </summary>
        ''' <remarks></remarks>
        FILE_TRAVERSE = 32

        ''' <summary>
        ''' Grants the right to execute a file.
        ''' </summary>
        ''' <remarks></remarks>
        FILE_EXECUTE = 32

        ''' <summary>
        ''' Grants the right to delete a directory and all of the files it contains (its children), even if the files are read-only.
        ''' </summary>
        ''' <remarks></remarks>
        FILE_DELETE_CHILD = 64

        ''' <summary>
        ''' Grants the right to read file attributes.
        ''' </summary>
        ''' <remarks></remarks>
        FILE_READ_ATTRIBUTES = 128

        ''' <summary>
        ''' Grants the right to change file attributes.
        ''' </summary>
        ''' <remarks></remarks>
        FILE_WRITE_ATTRIBUTES = 256

        ''' <summary>
        ''' Grants delete access.
        ''' </summary>
        ''' <remarks></remarks>
        DELETE = 65536

        ''' <summary>
        ''' Grants read access to the security descriptor and owner.
        ''' </summary>
        ''' <remarks></remarks>
        READ_CONTROL = 131072

        ''' <summary>
        ''' Grants write access to the discretionary access control list (DACL).
        ''' </summary>
        ''' <remarks></remarks>
        WRITE_DAC = 262144

        ''' <summary>
        ''' Assigns the write owner.
        ''' </summary>
        ''' <remarks></remarks>
        WRITE_OWNER = 524288

        ''' <summary>
        ''' Synchronizes access and allows a process to wait for an object to enter the signaled state.
        ''' </summary>
        ''' <remarks></remarks>
        SYNCHRONIZE = 1048576

        ''' <summary>
        ''' Read.
        ''' </summary>
        ''' <remarks>Composite flag.</remarks>
        Read = FILE_LIST_DIRECTORY Or FILE_READ_EA Or FILE_READ_ATTRIBUTES Or READ_CONTROL Or SYNCHRONIZE

        ''' <summary>
        ''' Read and Execute.
        ''' </summary>
        ''' <remarks>Composite flag.</remarks>
        ReadAndExecute = Read Or FILE_EXECUTE

        ''' <summary>
        ''' Write.
        ''' </summary>
        ''' <remarks>Composite flag.</remarks>
        Write = FILE_ADD_FILE Or FILE_ADD_SUBDIRECTORY Or FILE_WRITE_ATTRIBUTES Or FILE_WRITE_EA Or SYNCHRONIZE

        ''' <summary>
        ''' Modify.
        ''' </summary>
        ''' <remarks>Composite flag.</remarks>
        Modify = Read Or Write Or DELETE Or FILE_EXECUTE

        ''' <summary>
        ''' Full control.
        ''' </summary>
        ''' <remarks>Composite flag.</remarks>
        FullControl = FILE_DELETE_CHILD Or WRITE_DAC Or WRITE_OWNER Or Modify

        ''' <summary>
        ''' Nothing.
        ''' </summary>
        ''' <remarks>Added to the enumeration.</remarks>
        None = 0

    End Enum

    ''' <summary>
    ''' Bit flags that specify inheritance of the ACE.
    ''' </summary>
    ''' <remarks></remarks>
    <Flags()> _
    Public Enum AceFlags As UInteger

        ''' <summary>
        ''' Nothing.
        ''' </summary>
        ''' <remarks></remarks>
        None = 0

        ''' <summary>
        ''' Noncontainer child objects inherit the ACE as an effective ACE. For child objects that are containers, the ACE is inherited as an inherit-only ACE unless the NO_PROPAGATE_INHERIT_ACE bit flag is also set.
        ''' </summary>
        ''' <remarks></remarks>
        OBJECT_INHERIT_ACE = 1

        ''' <summary>
        ''' Child objects that are containers, such as directories, inherit the ACE as an effective ACE. The inherited ACE is inheritable unless the NO_PROPAGATE_INHERIT_ACE bit flag is also set.
        ''' </summary>
        ''' <remarks></remarks>
        CONTAINER_INHERIT_ACE = 2

        ''' <summary>
        ''' If the ACE is inherited by a child object, the system clears the OBJECT_INHERIT_ACE and CONTAINER_INHERIT_ACE flags in the inherited ACE. This prevents the ACE from being inherited by subsequent generations of objects.
        ''' </summary>
        ''' <remarks></remarks>
        NO_PROPAGATE_INHERIT_ACE = 4

        ''' <summary>
        ''' Indicates an inherit-only ACE which does not control access to the object to which it is attached. If this flag is not set, the ACE is an effective ACE which controls access to the object to which it is attached. Both effective and inherit-only ACEs can be inherited depending on the state of the other inheritance flags.
        ''' </summary>
        ''' <remarks></remarks>
        INHERIT_ONLY_ACE = 8

        ''' <summary>
        ''' The system sets this bit when it propagates an inherited ACE to a child object.
        ''' </summary>
        ''' <remarks></remarks>
        INHERITED_ACE = 16

        ''' <summary>
        ''' Used with system-audit ACEs in an SACL to generate audit messages for successful access attempts.
        ''' </summary>
        ''' <remarks>Pertains only to an ACE contained within a system access control list (SACL).</remarks>
        SUCCESSFUL_ACCESS_ACE_FLAG = 64

        ''' <summary>
        ''' Used with system-audit ACEs in an SACL to generate audit messages for failed access attempts.
        ''' </summary>
        ''' <remarks>Pertains only to an ACE contained within a system access control list (SACL).</remarks>
        FAILED_ACCESS_ACE_FLAG = 128

    End Enum

    ''' <summary>
    ''' ACE Type.
    ''' </summary>
    ''' <remarks></remarks>
    <Flags()> _
    Public Enum AceType As UInteger
        ''' <summary>
        ''' Access Denied.
        ''' </summary>
        ''' <remarks></remarks>
        Access_Denied = 1
        ''' <summary>
        ''' Access Allowed.
        ''' </summary>
        ''' <remarks></remarks>
        Access_Allowed = 0
        ''' <summary>
        ''' Audit.
        ''' </summary>
        ''' <remarks></remarks>
        Audit = 2
    End Enum

End Namespace
