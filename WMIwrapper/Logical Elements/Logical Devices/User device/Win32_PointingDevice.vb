Imports System.Management

''' <summary>
''' Represents an input device used to point to and select regions on the display of a computer system running Windows.
''' </summary>
''' <remarks>
''' <para>
''' Any device used to manipulate a pointer, or point to the display on acomputer system running Windows is a member of this class.
''' </para>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa394356.aspx">MSDN.</a>
''' </remarks>
Public Class Win32_PointingDevice
    Inherits CIM_PointingDevice

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
    ''' Type of interface used for the pointing device.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property DeviceInterface() As Enums.DeviceInterface
        Get
            Dim obj As Object = GetPropertyObject("DeviceInterface")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.DeviceInterface)
            End If
        End Get
    End Property

    ''' <summary>
    ''' One of two acceleration values, in Mickeys.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' The sensitivity of the pointing device doubles (toggles from the first to the second value) when the pointing device moves a distance greater than this threshold value.
    ''' </remarks>
    Public ReadOnly Property DoubleSpeedThreshold() As UInt32
        Get
            Return GetUint32Property("DoubleSpeedThreshold")
        End Get
    End Property

    ''' <summary>
    ''' Type of hardware used for the Windows pointing device.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Example: "MICROSOFT PS2 MOUSE"</remarks>
    Public ReadOnly Property HardwareType() As String
        Get
            Return GetStringProperty("HardwareType")
        End Get
    End Property

    ''' <summary>
    ''' Name of the .inf file for the Windows pointing device.
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
    ''' Section of the .inf file that holds configuration information for the Windows pointing device.
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
    ''' Name of the device manufacturer.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Manufacturer() As String
        Get
            Return GetStringProperty("Manufacturer")
        End Get
    End Property

    ''' <summary>
    ''' One of two acceleration values, in Mickeys.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' The system doubles the speed of the pointer movement when the pointer device moves a distance greater than this value.
    ''' Because this speed increase occurs after the <see cref="P:WMIwrapper.Win32_PointingDevice.DoubleSpeedThreshold"></see> value has been met,
    ''' the pointer effectively moves at four times its original speed.
    ''' </remarks>
    Public ReadOnly Property QuadSpeedThreshold() As UInt32
        Get
            Return GetUint32Property("QuadSpeedThreshold")
        End Get
    End Property

    ''' <summary>
    ''' Rate at which the pointing device is polled for input information, in Hertz.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property SampleRate() As UInt32
        Get
            Return GetUint32Property("SampleRate")
        End Get
    End Property

    ''' <summary>
    ''' Length of time after which the next interrupt is assumed to indicate the start of a new device packet (partial packets are discarded), in 100 nanoseconds.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' In the event that an interrupt is lost, this allows the pointing device driver to synchronize its internal representation of the packet state with the hardware state.
    ''' </remarks>
    Public ReadOnly Property Synch() As UInt32
        Get
            Return GetUint32Property("Synch")
        End Get
    End Property

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.Win32_PointingDevice"></see>.
''' </summary>
''' <remarks></remarks>
Public Class Win32_PointingDevices
    Inherits CIM_PointingDevices

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <param name="DeviceID">If specified, only the item corresponding to this key value is returned. Ignored if <code>Condition</code> is set.</param>
    ''' <param name="Condition">WQL condition can be specified. It is not checked and sent to WMI as is.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Computer As String, Optional ByVal DeviceID As String = Nothing, Optional ByVal Condition As String = Nothing)

        MyBase.New(Computer, "Win32_PointingDevice")
        ' Prepare condition
        If Condition Is Nothing AndAlso DeviceID IsNot Nothing Then
            Condition = "DeviceID ='" & DeviceID & "'"
        End If
        ' Read the collection
        For Each ManagementObjectI As ManagementObject In Me.Read(Condition)
            Me.Add(New Win32_PointingDevice(ManagementObjectI))
        Next

    End Sub

    ''' <summary>
    ''' Find an item in the collection.
    ''' </summary>
    ''' <param name="index">Indes of the item.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal index As Integer) As Win32_PointingDevice
        Return CType(List.Item(index), Win32_PointingDevice)
    End Function

    ''' <summary>
    ''' Find an item by its ID.
    ''' </summary>
    ''' <param name="DeviceID">The device ID.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal DeviceID As String) As Win32_PointingDevice
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
    ''' Type of interface used for the pointing device.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum DeviceInterface As UInt16

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
        ''' Serial.
        ''' </summary>
        ''' <remarks></remarks>
        Serial

        ''' <summary>
        ''' PS/2.
        ''' </summary>
        ''' <remarks></remarks>
        PS2

        ''' <summary>
        ''' Infrared.
        ''' </summary>
        ''' <remarks></remarks>
        Infrared

        ''' <summary>
        ''' HP-HIL.
        ''' </summary>
        ''' <remarks></remarks>
        HPHIL

        ''' <summary>
        ''' Bus Mouse.
        ''' </summary>
        ''' <remarks></remarks>
        BusMouse

        ''' <summary>
        ''' Apple Desktop Bus.
        ''' </summary>
        ''' <remarks></remarks>
        ADB

        ''' <summary>
        ''' Bus Mouse DB-9.
        ''' </summary>
        ''' <remarks></remarks>
        BusMouseDB9 = 160

        ''' <summary>
        ''' Bus Mouse Micro-DIN.
        ''' </summary>
        ''' <remarks></remarks>
        BusMouseMicroDIN

        ''' <summary>
        ''' USB.
        ''' </summary>
        ''' <remarks></remarks>
        USB

    End Enum

End Namespace
