Imports System.Management

''' <summary>
''' Represents the type of monitor or display device attached to the computer system.
''' </summary>
''' <remarks>
''' <para>
''' Starting with Windows Vista, properties of this class replace <see cref="T:WMIwrapper.Win32_DisplayConfiguration"></see>.
''' Starting with Windows Vista, hardware that is not compatible with Longhorn Display Driver Model (LDDM) returns inaccurate property values for instances of this class.
''' </para>
''' <para>See <a href="http://msdn2.microsoft.com/en-us/library/aa394122.aspx">MSDN.</a></para>
''' </remarks>
Public Class Win32_DesktopMonitor
    Inherits CIM_DesktopMonitor

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
    ''' Name of the monitor manufacturer.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Example: "NEC"</remarks>
    Public ReadOnly Property MonitorManufacturer() As String
        Get
            Return GetStringProperty("MonitorManufacturer")
        End Get
    End Property

    ''' <summary>
    ''' Type of monitor.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Example: "NEC 5FGp"</remarks>
    Public ReadOnly Property MonitorType() As String
        Get
            Return GetStringProperty("MonitorType")
        End Get
    End Property

    ''' <summary>
    ''' Resolution along the X axis (horizontal direction) of the monitor.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property PixelsPerXLogicalInch() As UInt32
        Get
            Return GetUint32Property("PixelsPerXLogicalInch")
        End Get
    End Property

    ''' <summary>
    ''' Resolution along the Y axis (vertical direction) of the monitor.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property PixelsPerYLogicalInch() As UInt32
        Get
            Return GetUint32Property("PixelsPerYLogicalInch")
        End Get
    End Property

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.Win32_DesktopMonitor"></see>.
''' </summary>
''' <remarks></remarks>
Public Class Win32_DesktopMonitors
    Inherits CIM_DesktopMonitors

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <param name="DeviceID">If specified, only the item corresponding to this key value is returned. Ignored if <code>Condition</code> is set.</param>
    ''' <param name="Condition">WQL condition can be specified. It is not checked and sent to WMI as is.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Computer As String, Optional ByVal DeviceID As String = Nothing, Optional ByVal Condition As String = Nothing)

        MyBase.New(Computer, "Win32_DesktopMonitor")
        ' Prepare condition
        If Condition Is Nothing AndAlso DeviceID IsNot Nothing Then
            Condition = "DeviceID ='" & DeviceID & "'"
        End If
        ' Read the collection
        For Each ManagementObjectI As ManagementObject In Me.Read(Condition)
            Me.Add(New Win32_DesktopMonitor(ManagementObjectI))
        Next

    End Sub

    ''' <summary>
    ''' Find an item in the collection.
    ''' </summary>
    ''' <param name="index">Indes of the item.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal index As Integer) As Win32_DesktopMonitor
        Return CType(List.Item(index), Win32_DesktopMonitor)
    End Function

    ''' <summary>
    ''' Find an item by its ID.
    ''' </summary>
    ''' <param name="DeviceID">The device ID.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal DeviceID As String) As Win32_DesktopMonitor
        For intI As Integer = 0 To List.Count - 1
            If Me.Item(intI).DeviceID = DeviceID Then
                Return Me.Item(intI)
            End If
        Next
        Return Nothing
    End Function

End Class
