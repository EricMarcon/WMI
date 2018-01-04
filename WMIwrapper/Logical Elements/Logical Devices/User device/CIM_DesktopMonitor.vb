Imports System.Management

''' <summary>
''' Represents the capabilities and management of the desktop monitor (CRT) logical device.
''' </summary>
''' <remarks>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa387240.aspx">MSDN</a>
''' </remarks>
Public MustInherit Class CIM_DesktopMonitor
    Inherits CIM_Display

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
    ''' Monitor's bandwidth in MHz.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>If unknown, use 0 (zero).</remarks>
    Public ReadOnly Property Bandwidth() As UInt32
        Get
            Return GetUint32Property("Bandwidth")
        End Get
    End Property

    ''' <summary>
    ''' Type of desktop monitor or CRT.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property DisplayType() As CIM_DesktopMonitors.DisplayType
        Get
            Dim obj As Object = GetPropertyObject("DisplayType")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, CIM_DesktopMonitors.DisplayType)
            End If
        End Get
    End Property

    ''' <summary>
    ''' Logical height of the display, in screen coordinates.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ScreenHeight() As UInt32
        Get
            Return GetUint32Property("ScreenHeight")
        End Get
    End Property

    ''' <summary>
    ''' Logical width of the display, in screen coordinates.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ScreenWidth() As UInt32
        Get
            Return GetUint32Property("ScreenWidth")
        End Get
    End Property

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.CIM_DesktopMonitor"></see>.
''' </summary>
''' <remarks></remarks>
Public MustInherit Class CIM_DesktopMonitors
    Inherits CIM_Displays

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">Host Computer.</param>
    ''' <param name="ClassName">Class name.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Computer As String, ByVal ClassName As String)
        MyBase.New(Computer, ClassName)
    End Sub

    ''' <summary>
    ''' Type of desktop monitor or CRT.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum DisplayType As UInt16

        ''' <summary>
        ''' Unknown.
        ''' </summary>
        ''' <remarks></remarks>
        Unknown

        ''' <summary>
        ''' Other.
        ''' </summary>
        ''' <remarks></remarks>
        Other

        ''' <summary>
        ''' Multiscan color.
        ''' </summary>
        ''' <remarks></remarks>
        MultiscanColor

        ''' <summary>
        ''' Multiscan monochrome.
        ''' </summary>
        ''' <remarks></remarks>
        MultiscanMonochrome

        ''' <summary>
        ''' Fixed frequency color.
        ''' </summary>
        ''' <remarks></remarks>
        FixedFrequencyColor

        ''' <summary>
        ''' Fixed frequency monochrome.
        ''' </summary>
        ''' <remarks></remarks>
        FixedFrequencyMonochrome

    End Enum

End Class
