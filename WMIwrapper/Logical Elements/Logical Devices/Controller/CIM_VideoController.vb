Imports System.Management

''' <summary>
''' Represents the capabilities and management of the video controller.
''' </summary>
''' <remarks>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa388668.aspx">MSDN</a>
''' </remarks>
Public MustInherit Class CIM_VideoController
    Inherits CIM_Controller

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
    ''' Graphics and 3-D capabilities of the video controller.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    Public ReadOnly Property AcceleratorCapabilities() As Enums.AcceleratorCapabilities()
        Get
            Dim obj As Object = GetPropertyObject("AcceleratorCapabilities")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.AcceleratorCapabilities())
            End If
        End Get
    End Property

    ''' <summary>
    ''' Free-form strings that provide detailed descriptions for the video accelerator features indicated in the <see cref="P:WMIwrapper.CIM_VideoController.AcceleratorCapabilities"></see> array.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' Each entry of this array is related to the entry in the <see cref="P:WMIwrapper.CIM_VideoController.AcceleratorCapabilities"></see> array that is located at the same index.
    ''' </remarks>
    Public ReadOnly Property CapabilityDescriptions() As String()
        Get
            Return GetStringArrayProperty("CapabilityDescriptions")
        End Get
    End Property

    ''' <summary>
    ''' Number of bits used to display each pixel.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property CurrentBitsPerPixel() As UInt32
        Get
            Return GetUint32Property("CurrentBitsPerPixel")
        End Get
    End Property

    ''' <summary>
    ''' Current number of horizontal pixels.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property CurrentHorizontalResolution() As UInt32
        Get
            Return GetUint32Property("CurrentHorizontalResolution")
        End Get
    End Property

    ''' <summary>
    ''' Number of colors supported at the current resolution.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property CurrentNumberOfColors() As UInt64
        Get
            Return GetUint64Property("CurrentNumberOfColors")
        End Get
    End Property

    ''' <summary>
    ''' If in character mode, number of columns for the video controller; otherwise, enter 0.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property CurrentNumberOfColumns() As UInt32
        Get
            Return GetUint32Property("CurrentNumberOfColumns")
        End Get
    End Property

    ''' <summary>
    ''' If in character mode, number of rows for the video controller; otherwise, enter 0.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property CurrentNumberOfRows() As UInt32
        Get
            Return GetUint32Property("CurrentNumberOfRows")
        End Get
    End Property

    ''' <summary>
    ''' Current refresh rate, in hertz.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property CurrentRefreshRate() As UInt32
        Get
            Return GetUint32Property("CurrentRefreshRate")
        End Get
    End Property

    ''' <summary>
    ''' Current scan mode.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property CurrentScanMode() As Enums.CurrentScanMode
        Get
            Dim obj As Object = GetPropertyObject("CurrentScanMode")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.CurrentScanMode)
            End If
        End Get
    End Property

    ''' <summary>
    ''' Current number of vertical pixels.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property CurrentVerticalResolution() As UInt32
        Get
            Return GetUint32Property("CurrentVerticalResolution")
        End Get
    End Property

    ''' <summary>
    ''' Maximum amount of memory supported, in bytes.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property MaxMemorySupported() As UInt32
        Get
            Return GetUint32Property("MaxMemorySupported")
        End Get
    End Property

    ''' <summary>
    ''' Maximum refresh rate of the video controller, in hertz.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property MaxRefreshRate() As UInt32
        Get
            Return GetUint32Property("MaxRefreshRate")
        End Get
    End Property

    ''' <summary>
    ''' Minimum refresh rate of the video controller, in hertz.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property MinRefreshRate() As UInt32
        Get
            Return GetUint32Property("MinRefreshRate")
        End Get
    End Property

    ''' <summary>
    ''' Number of video pages supported given the current resolutions and available memory.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property NumberOfVideoPages() As UInt32
        Get
            Return GetUint32Property("NumberOfVideoPages")
        End Get
    End Property

    ''' <summary>
    ''' Type of video memory.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property VideoMemoryType() As Enums.VideoMemoryType
        Get
            Dim obj As Object = GetPropertyObject("VideoMemoryType")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.VideoMemoryType)
            End If
        End Get
    End Property

    ''' <summary>
    ''' Free-form string that describes the video processor or controller.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property VideoProcessor() As String
        Get
            Return GetStringProperty("VideoProcessor")
        End Get
    End Property

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.CIM_VideoController"></see>.
''' </summary>
''' <remarks></remarks>
Public MustInherit Class CIM_VideoControllers
    Inherits CIM_Controllers

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
    ''' Graphics and 3-D capabilities of the video controller.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum AcceleratorCapabilities As UInt16

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
        ''' Graphics accelerator.
        ''' </summary>
        ''' <remarks></remarks>
        GraphicsAccelerator

        ''' <summary>
        ''' 3-D accelerator.
        ''' </summary>
        ''' <remarks></remarks>
        _3Daccelerator

    End Enum

    ''' <summary>
    ''' Current scan mode.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum CurrentScanMode As UInt16

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
        ''' Interlaced.
        ''' </summary>
        ''' <remarks></remarks>
        Interlaced

        ''' <summary>
        ''' Noninterlaced.
        ''' </summary>
        ''' <remarks></remarks>
        Noninterlaced

    End Enum

    ''' <summary>
    ''' Type of video memory.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum VideoMemoryType As UInt16

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
        ''' VRAM.
        ''' </summary>
        ''' <remarks></remarks>
        VRAM

        ''' <summary>
        ''' DRAM.
        ''' </summary>
        ''' <remarks></remarks>
        DRAM

        ''' <summary>
        ''' SRAM.
        ''' </summary>
        ''' <remarks></remarks>
        SRAM

        ''' <summary>
        ''' WRAM.
        ''' </summary>
        ''' <remarks></remarks>
        WRAM

        ''' <summary>
        ''' EDO RAM.
        ''' </summary>
        ''' <remarks></remarks>
        EDORAM

        ''' <summary>
        ''' Burst Synchronous DRAM.
        ''' </summary>
        ''' <remarks></remarks>
        BurstSynchronousDRAM

        ''' <summary>
        ''' Pipelined Burst SRAM.
        ''' </summary>
        ''' <remarks></remarks>
        PipelinedBurstSRAM

        ''' <summary>
        ''' CDRAM.
        ''' </summary>
        ''' <remarks></remarks>
        CDRAM

        ''' <summary>
        ''' 3DRAM.
        ''' </summary>
        ''' <remarks></remarks>
        _3DRAM

        ''' <summary>
        ''' SDRAM.
        ''' </summary>
        ''' <remarks></remarks>
        SDRAM

        ''' <summary>
        ''' SGRAM.
        ''' </summary>
        ''' <remarks></remarks>
        SGRAM

    End Enum

End Namespace
