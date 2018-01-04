Imports System.Management

''' <summary>
''' Represents the various video modes that a video controller can support.
''' </summary>
''' <remarks>
''' <para>
''' Video modes are defined by the possible horizontal and vertical resolutions, refresh rate, scan mode, and number of color settings supported by a controller.
''' The actual resolutions in use are the values specified in the <see cref="T:WMIwrapper.CIM_VideoController"></see> object.
''' Starting with Windows Vista, properties of this class replace the data in <see cref="T:WMIwrapper.Win32_DisplayConfiguration"></see>.
''' </para>
''' <para>See <a href="http://msdn2.microsoft.com/en-us/library/aa388669.aspx">MSDN</a>.</para>
''' </remarks>
Public Class CIM_VideoControllerResolution
    Inherits CIM_Setting

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
    ''' Horizontal resolution, in pixels.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property HorizontalResolution() As UInt32
        Get
            Return GetUint32Property("BitsPerPel")
        End Get
    End Property

    ''' <summary>
    ''' Maximum refresh rate when a range of rates is supported at the specified resolutions, in hertz.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property MaxRefreshRate() As UInt32
        Get
            Return GetUint32Property("MaxRefreshRate")
        End Get
    End Property

    ''' <summary>
    ''' Minimum refresh rate when a range of rates is supported at the specified resolutions, in hertz.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property MinRefreshRate() As UInt32
        Get
            Return GetUint32Property("MinRefreshRate")
        End Get
    End Property

    ''' <summary>
    ''' Number of colors supported at the current resolution.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property NumberOfColors() As UInt64
        Get
            Return GetUint64Property("NumberOfColors")
        End Get
    End Property

    ''' <summary>
    ''' Refresh rate in hertz.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>If a range of rates is supported, use the MinRefreshRate and MaxRefreshRate properties, and set this property to 0.</remarks>
    ReadOnly Property RefreshRate() As UInt32
        Get
            Return GetUint32Property("RefreshRate")
        End Get
    End Property

    ''' <summary>
    ''' Scan mode at which the controller operates.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property ScanMode() As Enums.ScanMode
        Get
            Dim obj As Object = GetPropertyObject("ScanMode")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.ScanMode)
            End If
        End Get
    End Property

    ''' <summary>
    ''' Vertical resolution, in pixels.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property VerticalResolution() As UInt32
        Get
            Return GetUint32Property("VerticalResolution")
        End Get
    End Property

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.CIM_VideoControllerResolution"></see>.
''' </summary>
''' <remarks></remarks>
Public Class CIM_VideoControllerResolutions
    Inherits CIM_Settings

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Computer As String)

        MyBase.New(Computer, "CIM_VideoControllerResolution")
        ' Read the collection
        For Each ManagementObjectI As ManagementObject In Me.Read()
            Me.Add(New Win32_DisplayConfiguration(ManagementObjectI))
        Next

    End Sub

    ''' <summary>
    ''' Find an item in the collection.
    ''' </summary>
    ''' <param name="index">Index of the item.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal index As Integer) As CIM_VideoControllerResolution
        Return CType(List.Item(index), CIM_VideoControllerResolution)
    End Function

End Class



Namespace Enums

    ''' <summary>
    ''' Scan mode at which the controller operates.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum ScanMode As UInt16

        ''' <summary>
        ''' Other.
        ''' </summary>
        ''' <remarks></remarks>
        Other = 1

        ''' <summary>
        ''' Unknown.
        ''' </summary>
        ''' <remarks></remarks>
        Unknown

        ''' <summary>
        ''' Not supported.
        ''' </summary>
        ''' <remarks></remarks>
        NotSupported

        ''' <summary>
        ''' Noninterlaced operation.
        ''' </summary>
        ''' <remarks></remarks>
        Noninterlaced

        ''' <summary>
        ''' Interlaced operation.
        ''' </summary>
        ''' <remarks></remarks>
        Interlaced

    End Enum

End Namespace
