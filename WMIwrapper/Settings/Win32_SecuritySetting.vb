Imports System.Management

''' <summary>
''' Represents security settings for a managed element.
''' </summary>
''' <remarks>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa394404.aspx">MSDN</a>
''' </remarks>
Public MustInherit Class Win32_SecuritySetting
    Inherits CIM_Setting

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="ClassName">The class name.</param>
    ''' <remarks>This constructor creates an unbound instance of the class.</remarks>
    Public Sub New(ByVal ClassName As String)
        MyBase.New(ClassName)
    End Sub

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
    ''' Control bits that qualify the meaning of a security descriptor (SD) or its individual members.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ControlFlags() As Enums.ControlFlags
        Get
            Dim obj As Object = GetPropertyObject("ControlFlags")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.ControlFlags)
            End If
        End Get
        Set(ByVal value As Enums.ControlFlags)
            _ManagementObject.SetPropertyValue("ControlFlags", value)
        End Set
    End Property

#End Region

#Region "Methods"

    Protected _Win32_SecurityDescriptor As New Win32_SecurityDescriptor
    ''' <summary>
    ''' Security descriptor.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' Set the property before using <see cref="M:WMIwrapper.Win32_SecuritySetting.SetSecurityDescriptor"></see>
    ''' or Get the property after using <see cref="M:WMIwrapper.Win32_SecuritySetting.GetSecurityDescriptor"></see>.
    ''' </remarks>
    Public Property Win32_SecurityDescriptor() As Win32_SecurityDescriptor
        Get
            Return _Win32_SecurityDescriptor
        End Get
        Set(ByVal value As Win32_SecurityDescriptor)
            _Win32_SecurityDescriptor = value
        End Set
    End Property

    ''' <summary>
    ''' Retrieve <see cref="T:WMIwrapper.Win32_SecurityDescriptor"></see> value.
    ''' </summary>
    ''' <remarks></remarks>
    Public Function GetSecurityDescriptor() As InvokeError

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("GetSecurityDescriptor", Nothing, Nothing)
        ' Treat the result if OK. 
        If InvokeReturn.ReturnValue = 0 Then
            ' The base management object containing the Win32_SecurityDescriptor is in Descriptor property of OutParams
            Dim mbo As Management.ManagementBaseObject = CType(InvokeReturn.outParams.Properties.Item("Descriptor").Value, Management.ManagementBaseObject)
            ' Create a new security descriptor
            _Win32_SecurityDescriptor = New Win32_SecurityDescriptor()
            ' Set its properties: read them in mbo properties
            With _Win32_SecurityDescriptor
                .ControlFlags = CType(mbo("ControlFlags"), Enums.ControlFlags)
                ' DACLs are in an array of ManagementBaseObjects
                Dim mboDACL() As Management.ManagementBaseObject = CType(mbo.Properties.Item("DACL").Value, Management.ManagementBaseObject())
                If mboDACL IsNot Nothing Then
                    ' Create a DACL array
                    Dim DACL(mboDACL.Length - 1) As Win32_ACE
                    For intI As Integer = 0 To mboDACL.Length - 1
                        DACL(intI) = New Win32_ACE
                        DACL(intI).ReadFromManagementBaseObject(mboDACL(intI))
                    Next
                    .DACL = DACL
                End If
                ' Group
                Dim mboGroup As Management.ManagementBaseObject = CType(mbo.Properties.Item("Group").Value, Management.ManagementBaseObject)
                If mboGroup IsNot Nothing Then
                    Dim Group As New Win32_Trustee
                    Group.ReadFromManagementBaseObject(mboGroup)
                    .Group = Group
                End If
                ' Owner
                Dim mboOwner As Management.ManagementBaseObject = CType(mbo.Properties.Item("Owner").Value, Management.ManagementBaseObject)
                If mboOwner IsNot Nothing Then
                    Dim Owner As New Win32_Trustee
                    Owner.ReadFromManagementBaseObject(mboOwner)
                    .Owner = Owner
                End If
                ' SACLs are in an array of ManagementBaseObjects
                Dim mboSACL() As Management.ManagementBaseObject = CType(mbo.Properties.Item("SACL").Value, Management.ManagementBaseObject())
                If mboSACL IsNot Nothing Then
                    ' Create a SACL array
                    Dim SACL(mboSACL.Length - 1) As Win32_ACE
                    For intI As Integer = 0 To mboSACL.Length - 1
                        SACL(intI) = New Win32_ACE
                        SACL(intI).ReadFromManagementBaseObject(mboSACL(intI))
                    Next
                    .SACL = SACL
                End If
            End With
        End If

        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Set the <see cref="T:WMIwrapper.Win32_SecurityDescriptor"></see> property value.
    ''' </summary>
    ''' <remarks></remarks>
    Public Function SetSecurityDescriptor() As InvokeError

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("SetSecurityDescriptor", _Win32_SecurityDescriptor.ManagementObject, Nothing)
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
                Return "The request was accepted."
            Case 1
                Return "The request is not supported."
            Case 2
                Return "The user did not have the necessary access."
            Case 8
                Return "Interactive process."
            Case 9
                Return "The name specified was invalid."
            Case 21
                Return "Invalid parameters have been passed to the service."
            Case Else
                Return "Error - Unknown Drive"
        End Select
    End Function

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.Win32_SecuritySetting"></see>.
''' </summary>
''' <remarks></remarks>
Public MustInherit Class Win32_SecuritySettings
    Inherits CIM_Settings

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



Namespace Enums

    ''' <summary>
    ''' Control bits that qualify the meaning of a security descriptor (SD) or its individual members.
    ''' </summary>
    ''' <remarks></remarks>
    <Flags()> _
   Public Enum ControlFlags As UInteger

        ''' <summary>
        ''' Indicates an SD with a default owner security identifier (SID).
        ''' Use this bit to find all of the objects that have default owner permissions set.
        ''' </summary>
        ''' <remarks></remarks>
        SE_OWNER_DEFAULTED = 1

        ''' <summary>
        ''' Indicates an SD with a default group SID.
        ''' Use this bit to find all of the objects that have default group permissions set.
        ''' </summary>
        ''' <remarks></remarks>
        SE_GROUP_DEFAULTED = 2

        ''' <summary>
        ''' Indicates an SD that has a DACL.
        ''' If this flag is not set, or if this flag is set and the DACL is NULL, the SD allows full access to everyone.
        ''' </summary>
        ''' <remarks></remarks>
        SE_DACL_PRESENT = 4

        ''' <summary>
        ''' Indicates an SD with a default DACL.
        ''' For example, if an object creator does not specify a DACL, the object receives the default DACL from the access token of the creator.
        ''' This flag can affect how the system treats the DACL, with respect to access control entry (ACE) inheritance.
        ''' The system ignores this flag if the SE_DACL_PRESENT flag is not set.
        ''' </summary>
        ''' <remarks></remarks>
        SE_DACL_DEFAULTED = 8

        ''' <summary>
        ''' Indicates an SD that has a system access control list (SACL).
        ''' </summary>
        ''' <remarks></remarks>
        SE_SACL_PRESENT = 16

        ''' <summary>
        ''' Indicates an SD with a default SACL.
        ''' For example, if an object creator does not specify an SACL, the object receives the default SACL from the access token of the creator.
        ''' This flag can affect how the system treats the SACL, with respect to ACE inheritance.
        ''' The system ignores this flag if the SE_SACL_PRESENT flag is not set.
        ''' </summary>
        ''' <remarks></remarks>
        SE_SACL_DEFAULTED = 32

        ''' <summary>
        ''' Requests that the provider for the object protected by the SD automatically propagate the DACL to existing child objects.
        ''' If the provider supports automatic inheritance, the DACL is propagated to any existing child objects, and the SE_DACL_AUTO_INHERITED bit in the SD of the parent and child objects is set.
        ''' </summary>
        ''' <remarks></remarks>
        SE_DACL_AUTO_INHERIT_REQ = 256

        ''' <summary>
        ''' Requests that the provider for the object protected by the SD automatically propagate the SACL to existing child objects.
        ''' If the provider supports automatic inheritance, the SACL is propagated to any existing child objects, and the SE_SACL_AUTO_INHERITED bit in the SDs of the parent object and child objects is set.
        ''' </summary>
        ''' <remarks></remarks>
        SE_SACL_AUTO_INHERIT_REQ = 512

        ''' <summary>
        ''' Indicates an SD in which the DACL is set up to support automatic propagation of inheritable ACEs to existing child objects.
        ''' The system sets this bit when it performs the automatic inheritance algorithm for the object and its existing child objects.
        ''' This bit is not set in SDs for Windows NT versions 4.0 and earlier, which do not support automatic propagation of inheritable ACEs.
        ''' </summary>
        ''' <remarks>Windows NT 4.0:  This value is not available. </remarks>
        SE_DACL_AUTO_INHERITED = 1024

        ''' <summary>
        ''' Indicates an SD in which the SACL is set up to support automatic propagation of inheritable ACEs to existing child objects.
        ''' The system sets this bit when it performs the automatic inheritance algorithm for the object and its existing child objects.
        ''' This bit is not set in SDs for Windows NT versions 4.0 and earlier, which do not support automatic propagation of inheritable ACEs.
        ''' </summary>
        ''' <remarks> Windows NT 4.0:  This value is not available. </remarks>
        SE_SACL_AUTO_INHERITED = 2048

        ''' <summary>
        ''' Prevents the DACL of an SD from being modified by inheritable ACEs.
        ''' </summary>
        ''' <remarks>Windows NT 4.0:  This value is not available. </remarks>
        SE_DACL_PROTECTED = 4096

        ''' <summary>
        ''' Prevents the SACL of an SD from being modified by inheritable ACEs.
        ''' </summary>
        ''' <remarks> Windows NT 4.0:  This value is not available. </remarks>
        SE_SACL_PROTECTED = 8192

        ''' <summary>
        ''' Indicates an SD in self-relative format with all the security information in a contiguous block of memory.
        ''' If this flag is not set, the SD is in absolute format.
        ''' </summary>
        ''' <remarks>See http://msdn2.microsoft.com/en-us/library/aa374807.aspx</remarks>
        SE_SELF_RELATIVE = 32768

    End Enum

End Namespace
