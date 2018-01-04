Imports System.Management

''' <summary>
''' Represents configuration information for the display device on a computer running on a Windows operating system.
''' </summary>
''' <remarks>
''' <para>
''' Starting with Windows Vista, this class is obsolete.
''' In place of this class,use the properties in the <see cref="T:WMIwrapper.Win32_VideoController"></see>, <see cref="T:WMIwrapper.Win32_DesktopMonitor"></see>,
''' and <see cref="T:WMIwrapper.CIM_VideoControllerResolution"></see>.
''' Hardware that is not compatible with Longhorn Display Driver Model (LDDM) returns inaccurate property values for instances of this class.
''' </para>
''' <para>See <a href="http://msdn2.microsoft.com/en-us/library/aa394137.aspx">MSDN</a>.</para>
''' </remarks>
Public Class Win32_DisplayConfiguration
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
    ''' Number of bits used to represent the color in this configuration (bits per pixel).
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property BitsPerPel() As UInt32
        Get
            Return GetUint32Property("BitsPerPel")
        End Get
    End Property

    ''' <summary>
    ''' Name of the display device.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property DeviceName() As String
        Get
            Return GetStringProperty("DeviceName")
        End Get
    End Property

    ''' <summary>
    ''' Indicates whether the display device is color (versus monochrome), and noninterlaced (versus interlaced).
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Improved from WMI by creating the enumeration.</remarks>
    ReadOnly Property DisplayFlags() As Enums.DisplayFlags
        Get
            Dim obj As Object = GetPropertyObject("DisplayFlags")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.DisplayFlags)
            End If
        End Get
    End Property

    ''' <summary>
    ''' The vertical refresh rate for the display, in Hertz.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ReadOnly Property DisplayFrequency() As UInt32
        Get
            Return GetUint32Property("DisplayFrequency")
        End Get
    End Property

    ''' <summary>
    ''' Dither type of the display.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' This property can assume predefined values of 1 to 5, or driver-defined values from 6 to 256.
    ''' Line art dithering is a special dithering method that produces well-defined borders between black, white, and gray scalings.
    ''' It is not suitable for images that include continuous graduations in intensity and hue (such as scanned photographs).
    ''' </remarks>
    ReadOnly Property DitherType() As Enums.DitherType
        Get
            Dim obj As Object = GetPropertyObject("DitherType")
            If obj Is Nothing Then
                Return Nothing
            Else
                Dim u32DitherType As UInt32 = CType(obj, UInt32)
                If u32DitherType > 5 Then
                    Return Enums.DitherType.DriverDefined
                Else
                    Return CType(u32DitherType, Enums.DitherType)
                End If
            End If
        End Get
    End Property

    ''' <summary>
    ''' Release version of the display driver.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property DriverVersion() As String
        Get
            Return GetStringProperty("DriverVersion")
        End Get
    End Property

    ''' <summary>
    ''' Value of one of the three possible color matching methods (intents) that should be used by default.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' This property is used primarily for non-ICM applications.
    ''' ICM applications establish intents by using the ICM functions.
    ''' This property can assume predefined values of 1 to 3, or driver-defined values from 4 to 256.
    ''' </remarks>
    ReadOnly Property ICMIntent() As Enums.ICMIntent
        Get
            Dim obj As Object = GetPropertyObject("ICMIntent")
            If obj Is Nothing Then
                Return Nothing
            Else
                Dim u32ICMIntent As UInt32 = CType(obj, UInt32)
                If u32ICMIntent > 3 Then
                    Return Enums.ICMIntent.DriverDefined
                Else
                    Return CType(u32ICMIntent, Enums.ICMIntent)
                End If
            End If
        End Get
    End Property

    ''' <summary>
    ''' How ICM is handled.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' For a non-ICM application, this property indicates if ICM is enabled or disabled.
    ''' For ICM applications, the system examines this property to determine which part of the computer system handles ICM support.
    ''' </remarks>
    ReadOnly Property ICMMethod() As Enums.ICMMethod
        Get
            Dim obj As Object = GetPropertyObject("ICMMethod")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.ICMMethod)
            End If
        End Get
    End Property

    ''' <summary>
    ''' Number of pixels per logical inch.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>This property is valid only with devices that work with pixels (this excludes devices such as printers).</remarks>
    ReadOnly Property LogPixels() As UInt32
        Get
            Return GetUint32Property("LogPixels")
        End Get
    End Property

    ''' <summary>
    ''' Height of the displayable surface.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property PelsHeight() As UInt32
        Get
            Return GetUint32Property("PelsHeight")
        End Get
    End Property

    ''' <summary>
    ''' Width of the displayable surface.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property PelsWidth() As UInt32
        Get
            Return GetUint32Property("PelsWidth")
        End Get
    End Property

    ''' <summary>
    ''' Version number of the initialization data for the Windows display device.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property SpecificationVersion() As UInt32
        Get
            Return GetUint32Property("SpecificationVersion")
        End Get
    End Property

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.Win32_DisplayConfiguration"></see>.
''' </summary>
''' <remarks></remarks>
Public Class Win32_DisplayConfigurations
    Inherits CIM_Settings

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <param name="DeviceName">If specified, only the item corresponding to this key value is returned. Ignored if <code>Condition</code> is set.</param>
    ''' <param name="Condition">WQL condition can be specified. It is not checked and sent to WMI as is.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Computer As String, Optional ByVal DeviceName As String = Nothing, Optional ByVal Condition As String = Nothing)

        MyBase.New(Computer, "Win32_DisplayConfiguration")
        ' Prepare condition
        If Condition Is Nothing AndAlso DeviceName IsNot Nothing Then
            Condition = "DeviceName ='" & DeviceName & "'"
        End If
        ' Read the collection
        For Each ManagementObjectI As ManagementObject In Me.Read(Condition)
            Me.Add(New Win32_DisplayConfiguration(ManagementObjectI))
        Next

    End Sub

    ''' <summary>
    ''' Find an item in the collection.
    ''' </summary>
    ''' <param name="index">Index of the item.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal index As Integer) As Win32_DisplayConfiguration
        Return CType(List.Item(index), Win32_DisplayConfiguration)
    End Function

    ''' <summary>
    ''' Find an item by its device name.
    ''' </summary>
    ''' <param name="DeviceName">The device name.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal DeviceName As String) As Win32_DisplayConfiguration
        For intI As Integer = 0 To List.Count - 1
            If Me.Item(intI).DeviceName = DeviceName Then
                Return Me.Item(intI)
            End If
        Next
        Return Nothing
    End Function

End Class



Namespace Enums

    ''' <summary>
    ''' Display flags.
    ''' </summary>
    ''' <remarks></remarks>
    <Flags()> _
    Public Enum DisplayFlags As UInt32

        ''' <summary>
        ''' Gray scale.
        ''' </summary>
        ''' <remarks></remarks>
        DM_GRAYSCALE = 1

        ''' <summary>
        ''' Interlaced.
        ''' </summary>
        ''' <remarks></remarks>
        DM_INTERLACED = 2

    End Enum

End Namespace
