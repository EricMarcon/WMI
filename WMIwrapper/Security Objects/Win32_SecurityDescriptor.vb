Imports System.Management

''' <summary>
''' A security descriptor contains the security information for a securable object.
''' </summary>
''' <remarks>
''' The Owner and Group properties identify the owner and primary group for the object.
''' It can also contain a discretionary access control list (DACL) that controls access to the object and a system access control list (SACL) that controls the logging of attempts to access the object.
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa394402.aspx">MSDN</a>
''' </remarks>
Public Class Win32_SecurityDescriptor
    Inherits WMIobject

    ''' <summary>
    ''' Constructor
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        MyBase.New("Win32_SecurityDescriptor")
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

    ''' <summary>
    ''' Each array entry defines the type of object access that the system grants to a specific user or group.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property DACL() As Win32_ACE()
        Get
            Return GetACEs("DACL")
        End Get
        Set(ByVal value As Win32_ACE())
            If value IsNot Nothing Then
                Dim ManagementObjects(value.Length - 1) As Management.ManagementObject
                For intI As Integer = 0 To value.Length - 1
                    ManagementObjects(intI) = value(intI).ManagementObject
                Next
                _ManagementObject.SetPropertyValue("DACL", ManagementObjects)
            End If
        End Set
    End Property

    ''' <summary>
    ''' Group that owns this object.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Group() As Win32_Trustee
        Get
            Return GetTrustee("Group")
        End Get
        Set(ByVal value As Win32_Trustee)
            _ManagementObject.SetPropertyValue("Group", value.ManagementObject)
        End Set
    End Property

    ''' <summary>
    ''' Owner of an object.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Owner() As Win32_Trustee
        Get
            Return GetTrustee("Owner")
        End Get
        Set(ByVal value As Win32_Trustee)
            _ManagementObject.SetPropertyValue("Owner", value.ManagementObject)
        End Set
    End Property

    ''' <summary>
    ''' Each array entry defines the type of access attempts that generate audit records for a specific user or group.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property SACL() As Win32_ACE()
        Get
            Return GetACEs("SACL")
        End Get
        Set(ByVal value As Win32_ACE())
            If value IsNot Nothing Then
                Dim ManagementObjects(value.Length - 1) As Management.ManagementObject
                For intI As Integer = 0 To value.Length - 1
                    ManagementObjects(intI) = value(intI).ManagementObject
                Next
                _ManagementObject.SetPropertyValue("SACL", ManagementObjects)
            End If
        End Set
    End Property

#End Region

End Class

