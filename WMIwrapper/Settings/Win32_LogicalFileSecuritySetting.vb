Imports System.Management

''' <summary>
''' Represents security settings for a logical file.
''' </summary>
''' <remarks>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa394180.aspx">MSDN</a>
''' </remarks>
Public Class Win32_LogicalFileSecuritySetting
    Inherits Win32_SecuritySetting

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        MyBase.New("Win32_LogicalFileSecuritySetting")
    End Sub

    ''' <summary>
    ''' Constructor. 
    ''' </summary>
    ''' <param name="ManagementObject">The underlying management object.</param>
    ''' <remarks>Use this constructor when the management object already exists (e.g. read from a collection).</remarks>
    Public Sub New(ByVal ManagementObject As System.Management.ManagementObject)
        MyBase.New(ManagementObject)
    End Sub

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <param name="Path">Path of the file on the host computer.</param>
    Public Sub New(ByVal Computer As String, ByVal Path As String)
        MyBase.New(New System.Management.ManagementPath("\\" & Computer & "\root\cimv2:Win32_LogicalFileSecuritySetting.Path=""" & Path & """"))
    End Sub

#Region "Properties"

    ''' <summary>
    ''' Indicates whether the caller has owner permissions to the file.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property OwnerPermissions() As Boolean
        Get
            Return GetBooleanProperty("OwnerPermissions")
        End Get
    End Property

    ''' <summary>
    ''' Full path of the file or directory.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Path() As String
        Get
            Return GetStringProperty("Path")
        End Get
    End Property

#End Region

End Class

' This class cannot be enumerated.