Imports System.Management

''' <summary>
''' Represents the capabilities and management capacity of the video controller on a computer system running Windows.
''' </summary>
''' <remarks>
''' <para>
''' Starting with Windows Vista, properties of this class replace Win32_DisplayConfiguration.
''' Starting with Windows Vista, hardware that is not compatible with Longhorn Display Driver Model (LDDM) returns inaccurate property values for instances of this class.
''' </para>
''' <para>See <a href="http://msdn2.microsoft.com/en-us/library/aa394512.aspx">MSDN</a>.</para>
''' </remarks>
Public Class Win32_VideoController
    Inherits CIM_PCVideoController

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
    ''' General chip set used for this controller to compare compatibilities with the system.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property AdapterCompatibility() As String
        Get
            Return GetStringProperty("AdapterCompatibility")
        End Get
    End Property

    ''' <summary>
    ''' Name or identifier of the digital-to-analog converter (DAC) chip.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>The character set of this property is alphanumeric.</remarks>
    ReadOnly Property AdapterDACType() As String
        Get
            Return GetStringProperty("AdapterDACType")
        End Get
    End Property

    ''' <summary>
    ''' Memory size of the video adapter, in Bytes.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property AdapterRAM() As UInt32
        Get
            Return GetUint32Property("AdapterRAM")
        End Get
    End Property

    ''' <summary>
    ''' Size of the system's color table.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>The device must have a color depth of no more than 8 bits per pixel; otherwise, this property is not set.</remarks>
    ReadOnly Property ColorTableEntries() As UInt32
        Get
            Return GetUint32Property("ColorTableEntries")
        End Get
    End Property

    ''' <summary>
    ''' Current number of device-specific pens.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>A value of 0xffff means that the device does not support pens.</remarks>
    ReadOnly Property DeviceSpecificPens() As UInt32
        Get
            Return GetUint32Property("DeviceSpecificPens")
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
    ''' Last modification date and time of the currently-installed video driver.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property DriverDate() As DateTime
        Get
            Return GetDateTimeProperty("DriverDate")
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
    ''' Name of the .inf file for the video adapter.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Example: "ab.inf"</remarks>
    Public ReadOnly Property InfFileName() As String
        Get
            Return GetStringProperty("InfFileName")
        End Get
    End Property

    ''' <summary>
    ''' Section of the .inf file that holds configuration information for the video adapter.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property InfSection() As String
        Get
            Return GetStringProperty("InfSection")
        End Get
    End Property

    ''' <summary>
    ''' Name of the installed display device driver.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property InstalledDisplayDrivers() As String
        Get
            Return GetStringProperty("InstalledDisplayDrivers")
        End Get
    End Property

    ''' <summary>
    ''' If TRUE, gray scale is used to display images.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Monochrome() As Boolean
        Get
            Return GetBooleanProperty("Monochrome")
        End Get
    End Property

    ''' <summary>
    ''' Number of reserved entries in the system palette.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' The operating system may reserve entries to support standard colors for task bars and other desktop display items.
    ''' This index is valid only if the device driver sets the RC_PALETTE bit in the RASTERCAPS index,
    ''' and is available only if the driver is compatible with 16-bit Windows.
    ''' If the system is not using a palette, ReservedSystemPaletteEntries is not set.
    ''' </remarks>
    ReadOnly Property ReservedSystemPaletteEntries() As UInt32
        Get
            Return GetUint32Property("ReservedSystemPaletteEntries")
        End Get
    End Property

    ''' <summary>
    ''' Version number of the initialization data specification (upon which the structure is based).
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property SpecificationVersion() As UInt32
        Get
            Return GetUint32Property("SpecificationVersion")
        End Get
    End Property

    ''' <summary>
    ''' Current number of color index entries in the system palette.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' The operating system may reserve entries to support standard colors for task bars and other desktop display items.
    ''' This index is valid only if the device driver sets the RC_PALETTE bit in the RASTERCAPS index,
    ''' and is available only if the driver is compatible with 16-bit Windows.
    ''' If the system is not using a palette, ReservedSystemPaletteEntries is not set.
    ''' </remarks>
    ReadOnly Property SystemPaletteEntries() As UInt32
        Get
            Return GetUint32Property("SystemPaletteEntries")
        End Get
    End Property

    ''' <summary>
    ''' Current resolution, color, and scan mode settings of the video controller.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Example: "1024 x 768 x 256 colors"</remarks>
    Public ReadOnly Property VideoModeDescription() As String
        Get
            Return GetStringProperty("VideoModeDescription")
        End Get
    End Property

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.Win32_VideoController"></see>.
''' </summary>
''' <remarks></remarks>
Public Class Win32_VideoControllers
    Inherits CIM_PCVideoControllers

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <param name="DeviceID">If specified, only the item corresponding to this key value is returned. Ignored if <code>Condition</code> is set.</param>
    ''' <param name="Condition">WQL condition can be specified. It is not checked and sent to WMI as is.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Computer As String, Optional ByVal DeviceID As String = Nothing, Optional ByVal Condition As String = Nothing)

        MyBase.New(Computer, "Win32_VideoController")
        ' Prepare condition
        If Condition Is Nothing AndAlso DeviceID IsNot Nothing Then
            Condition = "DeviceID ='" & DeviceID & "'"
        End If
        ' Read the collection
        For Each ManagementObjectI As ManagementObject In Me.Read(Condition)
            Me.Add(New Win32_VideoController(ManagementObjectI))
        Next

    End Sub

    ''' <summary>
    ''' Find an item in the collection.
    ''' </summary>
    ''' <param name="index">Index of the item.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal index As Integer) As Win32_VideoController
        Return CType(List.Item(index), Win32_VideoController)
    End Function

    ''' <summary>
    ''' Find an item by its ID.
    ''' </summary>
    ''' <param name="DeviceID">The device ID.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal DeviceID As String) As Win32_VideoController
        For intI As Integer = 0 To List.Count - 1
            If Me.Item(intI).DeviceID = DeviceID Then
                Return Me.Item(intI)
            End If
        Next
        Return Nothing
    End Function

End Class



Namespace Enums

    ''' <summary>
    ''' Dither type of the display.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum DitherType As UInt32

        ''' <summary>
        ''' Driver defined value (actually 6 to 255).
        ''' </summary>
        ''' <remarks></remarks>
        DriverDefined = 0

        ''' <summary>
        ''' No Dithering.
        ''' </summary>
        ''' <remarks></remarks>
        NoDithering = 1

        ''' <summary>
        ''' Coarse Brush.
        ''' </summary>
        ''' <remarks></remarks>
        CoarseBrush

        ''' <summary>
        ''' Fine Brush.
        ''' </summary>
        ''' <remarks></remarks>
        FineBrush

        ''' <summary>
        ''' Line Art.
        ''' </summary>
        ''' <remarks></remarks>
        LineArt

        ''' <summary>
        ''' Grayscale.
        ''' </summary>
        ''' <remarks></remarks>
        Grayscale

    End Enum

    ''' <summary>
    ''' Value of one of the three possible color matching methods (intents) that should be used by default.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum ICMIntent As UInt32

        ''' <summary>
        ''' Driver defined value (actually 4 to 255).
        ''' </summary>
        ''' <remarks></remarks>
        DriverDefined = 0

        ''' <summary>
        ''' Saturation.
        ''' </summary>
        ''' <remarks></remarks>
        Saturation = 1

        ''' <summary>
        ''' Contrast.
        ''' </summary>
        ''' <remarks></remarks>
        Contrast

        ''' <summary>
        ''' Exact Color.
        ''' </summary>
        ''' <remarks></remarks>
        ExactColor

    End Enum

    ''' <summary>
    ''' How ICM is handled.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum ICMMethod As UInt32

        ''' <summary>
        ''' No data returned.
        ''' </summary>
        ''' <remarks>Not in MSDN documentation but added after tests.</remarks>
        None = 0

        ''' <summary>
        ''' Disabled.
        ''' </summary>
        ''' <remarks></remarks>
        Disabled = 1

        ''' <summary>
        ''' Windows.
        ''' </summary>
        ''' <remarks></remarks>
        Windows

        ''' <summary>
        ''' Device Driver.
        ''' </summary>
        ''' <remarks></remarks>
        DeviceDriver

        ''' <summary>
        ''' Device.
        ''' </summary>
        ''' <remarks></remarks>
        Device

    End Enum

End Namespace
