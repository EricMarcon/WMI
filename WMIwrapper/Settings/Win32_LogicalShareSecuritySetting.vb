Imports System.Management

''' <summary>
''' Represents security settings for a logical file.
''' </summary>
''' <remarks>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa394188.aspx">MSDN</a>
''' </remarks>
Public Class Win32_LogicalShareSecuritySetting
    Inherits Win32_SecuritySetting

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        MyBase.New("Win32_LogicalShareSecuritySetting")
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
    ''' <param name="ShareName">Name of the share on the host computer.</param>
    Public Sub New(ByVal Computer As String, ByVal ShareName As String)
        MyBase.New(New System.Management.ManagementPath("\\" & Computer & "\root\cimv2:Win32_LogicalShareSecuritySetting.Name=""" & ShareName & """"))
    End Sub

#Region "Properties"

    ''' <summary>
    ''' Name of the share.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Name() As String
        Get
            Return GetStringProperty("Name")
        End Get
    End Property

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.Win32_LogicalShareSecuritySetting"></see>.
''' </summary>
''' <remarks></remarks>
Public Class Win32_LogicalShareSecuritySettings
    Inherits Win32_SecuritySettings

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <param name="Name">If specified, only the item corresponding to this key value is returned. Ignored if <code>Condition</code> is set.</param>
    ''' <param name="Condition">WQL condition can be specified. It is not checked and sent to WMI as is.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Computer As String, Optional ByVal Name As String = Nothing, Optional ByVal Condition As String = Nothing)

        MyBase.New(Computer, "Win32_LogicalShareSecuritySetting")
        ' Prepare condition
        If Condition Is Nothing AndAlso Name IsNot Nothing Then
            Condition = "Name ='" & Name & "'"
        End If
        ' Read the collection
        For Each ManagementObjectI As ManagementObject In Me.Read(Condition)
            Me.Add(New Win32_LogicalShareSecuritySetting(ManagementObjectI))
        Next

    End Sub

    ''' <summary>
    ''' Find an item in the collection.
    ''' </summary>
    ''' <param name="index">Index of the item.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal index As Integer) As Win32_LogicalShareSecuritySetting
        Return CType(List.Item(index), Win32_LogicalShareSecuritySetting)
    End Function

    ''' <summary>
    ''' Find an item by its name.
    ''' </summary>
    ''' <param name="Name">The file name.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal Name As String) As Win32_LogicalShareSecuritySetting
        For intI As Integer = 0 To List.Count - 1
            If Me.Item(intI).Name = Name Then
                Return Me.Item(intI)
            End If
        Next
        Return Nothing
    End Function

End Class
