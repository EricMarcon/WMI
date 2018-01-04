Imports System.Management

''' <summary>
''' Represents a desktop, mobile, network computer, server, or other type of single-node computer system.
''' </summary>
''' <remarks>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa388626.aspx">MSDN.</a>
''' </remarks>
Public MustInherit Class CIM_UnitaryComputerSystem
    Inherits CIM_ComputerSystem

    ''' <summary>
    ''' Constructor. 
    ''' </summary>
    ''' <param name="ManagementObject">The underlying management object.</param>
    ''' <remarks>Use this constructor when the management object already exists (e.g. read from a collection).</remarks>
    Public Sub New(ByVal ManagementObject As ManagementObject)
        MyBase.New(ManagementObject)
    End Sub

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <param name="ClassPath">The class namespace.</param>
    ''' <param name="ClassName">The class name.</param>
    ''' <remarks>This constructor creates an unbound instance of the class.</remarks>
    Public Sub New(ByVal Computer As String, ByVal ClassName As String, Optional ByVal ClassPath As String = "root\cimv2")
        MyBase.New(Computer, ClassName, ClassPath)
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
    ''' Data needed to find either the initial load device (its key) or the boot service to request the operating system to start.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>In addition, the load parameters (that is, a path name and parameters) can also be specified.</remarks>
    Public ReadOnly Property InitialLoadInfo() As String
        Get
            Return GetStringProperty("InitialLoadInfo")
        End Get
    End Property

    ''' <summary>
    ''' Data that identifies either the initial load device (its key) or the boot service that requested the last operating system load.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>In addition, the load parameters (that is, a path name and parameters) can also be specified.</remarks>
    Public ReadOnly Property LastLoadInfo() As String
        Get
            Return GetStringProperty("LastLoadInfo")
        End Get
    End Property

    ''' <summary>
    ''' Array of the specific power-related capabilities of a logical device.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property PowerManagementCapabilities() As CIM_LogicalDevices.PowerManagementCapabilities()
        Get
            Dim obj As Object = GetPropertyObject("PowerManagementCapabilities")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, CIM_LogicalDevices.PowerManagementCapabilities())
            End If
        End Get
    End Property

    ''' <summary>
    ''' If TRUE, the device can be power managed, that is, put into a power-save state.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' If FALSE, the integer value 1 ("Not Supported") should be the only entry in the <see cref="P:WMIwrapper.CIM_UnitaryComputerSystem.PowerManagementCapabilities"></see> array.
    ''' This property does not indicate whether power management features are currently enabled, or if enabled, which features are supported.
    ''' For more information, see the <see cref="P:WMIwrapper.CIM_UnitaryComputerSystem.PowerManagementCapabilities"></see> array.
    ''' </remarks>
    Public ReadOnly Property PowerManagementSupported() As Boolean
        Get
            Return GetBooleanProperty("PowerManagementSupported")
        End Get
    End Property

    ''' <summary>
    ''' Current power state of a computer and its associated operating system.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' The power saving states have the following values:
    ''' Value 4 (Unknown) indicates that the system is known to be in a power save mode, but its exact status in this mode is unknown;
    ''' 2 (Low Power Mode) indicates that the system is in a power save state, but still functioning and may exhibit degraded performance;
    ''' 3 (Standby) indicates that the system is not functioning, but could be brought to full power quickly;
    ''' and 7 (Warning) indicates that the computer system is in a warning state and a power save mode.
    ''' </remarks>
    Public ReadOnly Property PowerState() As CIM_UnitaryComputerSystems.PowerState
        Get
            Dim obj As Object = GetPropertyObject("PowerState")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, CIM_UnitaryComputerSystems.PowerState)
            End If
        End Get
    End Property

    ''' <summary>
    ''' If enabled, the unitary computer system can be reset with hardware (for example, with the power and reset buttons). If disabled, hardware reset is not allowed.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ResetCapability() As CIM_UnitaryComputerSystems.ResetCapability
        Get
            Dim obj As Object = GetPropertyObject("ResetCapability")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, CIM_UnitaryComputerSystems.ResetCapability)
            End If
        End Get
    End Property

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.CIM_UnitaryComputerSystem"></see>.
''' </summary>
''' <remarks></remarks>
Public MustInherit Class CIM_UnitaryComputerSystems
    Inherits CIM_ComputerSystems

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
    ''' Power-related capabilities of a logical device.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum PowerManagementCapabilities As UInt16

        ''' <summary>
        ''' Unknown.
        ''' </summary>
        ''' <remarks></remarks>
        Unknown = 0

        ''' <summary>
        ''' Not Supported.
        ''' </summary>
        ''' <remarks></remarks>
        NotSupported = 1

        ''' <summary>
        ''' Disabled
        ''' </summary>
        ''' <remarks></remarks>
        Disabled = 2

        ''' <summary>
        ''' The power management features are currently enabled but the exact feature set is unknown or the information is unavailable.
        ''' </summary>
        ''' <remarks></remarks>
        Enabled = 3

        ''' <summary>
        ''' The device can change its power state based on usage or other criteria.
        ''' </summary>
        ''' <remarks></remarks>
        PowerSavingModesEnteredAutomatically = 4


        ''' <summary>
        ''' The SetPowerState method is supported. This method is found on the parent LogicalDevices class and can be implemented.
        ''' </summary>
        ''' <remarks>For more information, see Designing Managed Object Format (MOF) Classes.</remarks>
        PowerStateSettable = 5

        ''' <summary>
        ''' The SetPowerState method can be invoked with the PowerState parameter set to 5 (Power Cycle).
        ''' </summary>
        ''' <remarks></remarks>
        PowerCyclingSupported = 6

        ''' <summary>
        ''' The SetPowerState method can be invoked with the PowerState parameter set to 5 (Power Cycle) and Time set to a specific date and time, or interval, for power-on.
        ''' </summary>
        ''' <remarks></remarks>
        TimedPowerOnSupported = 7

    End Enum

    ''' <summary>
    ''' Current power state of a computer and its associated operating system.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum PowerState As UInt16

        ''' <summary>
        ''' Unknown.
        ''' </summary>
        ''' <remarks></remarks>
        Unknown = 0

        ''' <summary>
        ''' Full Power.
        ''' </summary>
        ''' <remarks></remarks>
        FullPower = 1

        ''' <summary>
        ''' System is in a power-save state and still functioning, but may exhibit degraded performance.
        ''' </summary>
        ''' <remarks></remarks>
        PowerSaveLowPowerMode = 2

        ''' <summary>
        ''' Power Save - Standby.
        ''' </summary>
        ''' <remarks></remarks>
        PowerSaveStandby = 3

        ''' <summary>
        ''' System is not functioning, but could be brought to full power quickly.
        ''' </summary>
        ''' <remarks></remarks>
        PowerSaveUnknown = 4

        ''' <summary>
        ''' Power Cycle.
        ''' </summary>
        ''' <remarks></remarks>
        PowerCycle = 5

        ''' <summary>
        ''' Power Off.
        ''' </summary>
        ''' <remarks></remarks>
        PowerOff = 6

        ''' <summary>
        ''' System is in a warning state and also in a power-save mode.
        ''' </summary>
        ''' <remarks></remarks>
        PowerSaveWarning = 7

        ''' <summary>
        ''' Power save — hibernate.
        ''' </summary>
        ''' <remarks></remarks>
        PowerSaveHibernate = 8

        ''' <summary>
        ''' Power save — soft off.
        ''' </summary>
        ''' <remarks></remarks>
        PowerSaveSoftOff = 9

    End Enum

    ''' <summary>
    ''' Reset capability of the sytem.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum ResetCapability As UInt16

        ''' <summary>
        ''' Other.
        ''' </summary>
        ''' <remarks></remarks>
        Other = 1

        ''' <summary>
        ''' Unknown.
        ''' </summary>
        ''' <remarks></remarks>
        Unknown = 2

        ''' <summary>
        ''' Disabled.
        ''' </summary>
        ''' <remarks></remarks>
        Disabled = 3

        ''' <summary>
        ''' Enabled.
        ''' </summary>
        ''' <remarks></remarks>
        Enabled = 4

        ''' <summary>
        ''' Not implemented.
        ''' </summary>
        ''' <remarks></remarks>
        NotImplemented = 5

    End Enum

End Class
