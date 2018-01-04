Imports System.Management

''' <summary>
''' Represents a device that points to regions on the display.
''' </summary>
''' <remarks>
''' <para>
''' Any device that manipulates a pointer, or points to regions on a visual display, is a member of this class.
''' For example, a mouse, stylus, touch pad, or tablet.
''' </para>
''' <para>See <a href="http://msdn2.microsoft.com/en-us/library/aa387970.aspx">MSDN</a></para>
''' </remarks>
Public MustInherit Class CIM_PointingDevice
    Inherits CIM_UserDevice

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
    ''' Configuration of the pointing device for right-hand or left-hand operation. 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Handedness() As CIM_PointingDevices.Handedness
        Get
            Dim obj As Object = GetPropertyObject("Handedness")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, CIM_PointingDevices.Handedness)
            End If
        End Get
    End Property

    ''' <summary>
    ''' Number of buttons on the pointing device.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property NumberOfButtons() As Byte
        Get
            Return GetByteProperty("NumberOfButtons")
        End Get
    End Property

    ''' <summary>
    ''' Type of the pointing device.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property PointingType() As CIM_PointingDevices.PointingType
        Get
            Dim obj As Object = GetPropertyObject("PointingType")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, CIM_PointingDevices.PointingType)
            End If
        End Get
    End Property

    ''' <summary>
    ''' Tracking resolution.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Resolution() As UInt32
        Get
            Return GetUint32Property("Resolution")
        End Get
    End Property

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.CIM_PointingDevice"></see>.
''' </summary>
''' <remarks></remarks>
Public MustInherit Class CIM_PointingDevices
    Inherits CIM_UserDevices

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
    ''' Configuration of the pointing device for right-hand or left-hand operation. 
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum Handedness As UInt16

        ''' <summary>
        ''' Unknown.
        ''' </summary>
        ''' <remarks></remarks>
        Unknown

        ''' <summary>
        ''' Not Applicable.
        ''' </summary>
        ''' <remarks></remarks>
        NotApplicable

        ''' <summary>
        ''' Right-Hand Operation.
        ''' </summary>
        ''' <remarks></remarks>
        RightHandOperation

        ''' <summary>
        ''' Left-Hand Operation.
        ''' </summary>
        ''' <remarks></remarks>
        LeftHandOperation

    End Enum

    ''' <summary>
    ''' Type of the pointing device.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum PointingType As UInt16

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
        ''' Mouse.
        ''' </summary>
        ''' <remarks></remarks>
        Mouse

        ''' <summary>
        ''' Track ball.
        ''' </summary>
        ''' <remarks></remarks>
        TrackBall

        ''' <summary>
        ''' Track point.
        ''' </summary>
        ''' <remarks></remarks>
        TrackPoint

        ''' <summary>
        ''' Glide point.
        ''' </summary>
        ''' <remarks></remarks>
        GlidePoint

        ''' <summary>
        ''' Touch pad.
        ''' </summary>
        ''' <remarks></remarks>
        TouchPad

        ''' <summary>
        ''' Touch screen.
        ''' </summary>
        ''' <remarks></remarks>
        TouchScreen

        ''' <summary>
        ''' Mouse — optical sensor.
        ''' </summary>
        ''' <remarks></remarks>
        MouseOpticalSensor

    End Enum

End Class
