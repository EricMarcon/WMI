Imports System.Management

''' <summary>
''' A trustee that can be a name or a security identifier (SID) byte array.
''' </summary>
''' <remarks>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa394501.aspx">MSDN</a>
''' </remarks>
Public Class Win32_Trustee
    Inherits WMIobject

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        MyBase.New("Win32_Trustee")
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
    ''' Domain to which a trustee belongs.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Domain() As String
        Get
            Return TryCast(GetPropertyObject("Domain"), String)
        End Get
        Set(ByVal value As String)
            _ManagementObject.SetPropertyValue("Domain", value)
        End Set
    End Property

    ''' <summary> 
    ''' A trustee can be a user account, group account, or logon session.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shadows Property Name() As String
        Get
            Return GetStringProperty("Name")
        End Get
        Set(ByVal value As String)
            _ManagementObject.SetPropertyValue("Name", value)
        End Set
    End Property

    ''' <summary>
    ''' SID that uniquely identifies a user or group.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property SID() As Byte()
        Get
            Return GetByteArrayProperty("SID")
        End Get
        Set(ByVal value As Byte())
            _ManagementObject.SetPropertyValue("SID", value)
        End Set
    End Property

    ''' <summary>
    ''' Length of a SID.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>In bytes</remarks>
    Public Property SidLength() As UInt32
        Get
            Return GetUint32Property("SidLength")
        End Get
        Set(ByVal value As UInteger)
            _ManagementObject.SetPropertyValue("SidLength", value)
        End Set
    End Property

    ''' <summary>
    ''' SID of a trustee in string format. 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks><para>The format for a string value is the following:
    ''' <list type="number">
    ''' <item>The "S" character identifies the series of digits as a SID.</item>
    ''' <item>The revision level.</item>
    ''' <item>Identifier authority value.</item>
    ''' <item>One or more subauthority values.</item>
    ''' </list>
    ''' Example: "S-1-1-0"</para></remarks>
    Public Property SIDString() As String
        Get
            Return GetStringProperty("SIDString")
        End Get
        Set(ByVal value As String)
            _ManagementObject.SetPropertyValue("SIDString", value)
        End Set
    End Property

#End Region

    ''' <summary>
    ''' Read the object of interest inside the <see cref="T:System.Management.ManagementBaseObject"></see> returned by <see cref="M:WMIwrapper.Win32_Trustee.InvokeMethod"></see>
    ''' </summary>
    ''' <param name="mbo">The <see cref="T:System.Management.ManagementBaseObject"></see> to unwrap.</param>
    ''' <remarks></remarks>
    Friend Sub ReadFromManagementBaseObject(ByVal mbo As ManagementBaseObject)
        With Me
            .Domain = TryCast(mbo.Item("Domain"), String)
            .Name = TryCast(mbo.Item("Name"), String)
            .SID = TryCast(mbo.Item("SID"), Byte())
            .SidLength = CType(mbo.Item("SidLength"), UInteger)
            .SIDString = TryCast(mbo.Item("SIDString"), String)
        End With
    End Sub

End Class
