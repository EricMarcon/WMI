Imports System.Management

''' <summary>
''' Represents a hardware entity that may or may not be realized in physical hardware. 
''' </summary>
''' <remarks>
''' <para>
''' Logical device characteristics that manage operation or configuration are contained in, or associated with, the CIM_LogicalDevice object.
''' Printer operational properties, for example, are supported paper sizes or detected errors.
''' Sensor device configuration properties, for example, are threshold settings.
''' Various configurations can exist for a logical device and are contained in the <see cref="T:WMIwrapper.CIM_Setting"></see> objects, which are associated with the logical device.
''' </para>
''' <para>See <a href="http://msdn2.microsoft.com/en-us/library/aa387884.aspx">MSDN</a>.</para>
''' <para>This class is not abstract because it belongs to at least an association.</para>
''' </remarks>
Public Class CIM_LogicalDevice
    Inherits CIM_LogicalElement

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
    ''' <param name="ManagementBaseObject">The underlying management base object.</param>
    ''' <remarks>
    ''' Alternate constructor, to use when a management base object is available instead of a management object.
    ''' Management base objects are returned as out parameters of methods.
    ''' </remarks>
    Public Sub New(ByVal ManagementBaseObject As ManagementBaseObject)
        MyBase.New(ManagementBaseObject)
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
    ''' Availability and status of the device.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Availability() As CIM_LogicalDevices.Availability
        Get
            Dim obj As Object = GetPropertyObject("Availability")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, CIM_LogicalDevices.Availability)
            End If
        End Get
    End Property

    ''' <summary>
    ''' Win32 Configuration Manager error code.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ConfigManagerErrorCode() As UInt32
        Get
            Return GetUint32Property("ConfigManagerErrorCode")
        End Get
    End Property

    ''' <summary>
    ''' Win32 Configuration Manager error message.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ConfigManagerError() As String
        Get
            Select Case ConfigManagerErrorCode
                Case 0
                    Return "Device is working properly."
                Case 1
                    Return "Device is not configured correctly."
                Case 2
                    Return "Windows cannot load the driver for this device."
                Case 3
                    Return "Driver for this device might be corrupted, or the system may be low on memory or other resources."
                Case 4
                    Return "Device is not working properly. One of its drivers or the registry might be corrupted."
                Case 5
                    Return "Driver for the device requires a resource that Windows cannot manage."
                Case 6
                    Return "Boot configuration for the device conflicts with other devices."
                Case 7
                    Return "Cannot filter."
                Case 8
                    Return "Driver loader for the device is missing."
                Case 9
                    Return "Device is not working properly. The controlling firmware is incorrectly reporting the resources for the device."
                Case 10
                    Return "Device cannot start."
                Case 11
                    Return "Device failed."
                Case 12
                    Return "Device cannot find enough free resources to use."
                Case 13
                    Return "Windows cannot verify the device's resources."
                Case 14
                    Return "Device cannot work properly until the computer is restarted."
                Case 15
                    Return "Device is not working properly due to a possible re-enumeration problem."
                Case 16
                    Return "Windows cannot identify all of the resources that the device uses."
                Case 17
                    Return "Device is requesting an unknown resource type."
                Case 18
                    Return "Device drivers must be reinstalled."
                Case 19
                    Return "Failure using the VxD loader."
                Case 20
                    Return "Registry might be corrupted."
                Case 21
                    Return "System failure. If changing the device driver is ineffective, see the hardware documentation. Windows is removing the device."
                Case 22
                    Return "Device is disabled."
                Case 23
                    Return "System failure. If changing the device driver is ineffective, see the hardware documentation."
                Case 24
                    Return "Device is not present, not working properly, or does not have all of its drivers installed."
                Case 25
                    Return "Windows is still setting up the device."
                Case 26
                    Return "Windows is still setting up the device."
                Case 27
                    Return "Device does not have valid log configuration."
                Case 28
                    Return "Device drivers are not installed."
                Case 29
                    Return "Device is disabled. The device firmware did not provide the required resources."
                Case 30
                    Return "Device is using an IRQ resource that another device is using."
                Case 31
                    Return "Device is not working properly. Windows cannot load the required device drivers"
                Case Else
                    Return ""
            End Select
        End Get
    End Property

    ''' <summary>
    ''' Indicates the device is using a configuration that the user defines.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ConfigManagerUserConfig() As Boolean
        Get
            Return GetBooleanProperty("ConfigManagerUserConfig")
        End Get
    End Property

    ''' <summary>
    ''' Name of the first concrete class that appears in the inheritance chain used to create an instance. 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>When used with the other key properties of the class, the property allows all instances of this class and its subclasses to be identified uniquely.</remarks>
    Public ReadOnly Property CreationClassName() As String
        Get
            Return GetStringProperty("CreationClassName")
        End Get
    End Property

    ''' <summary>
    ''' Unique identifier of a device on the system.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property DeviceID() As String
        Get
            Return GetStringProperty("DeviceID")
        End Get
    End Property

    ''' <summary>
    ''' Indicates that the error reported in LastErrorCode is clear.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ErrorCleared() As Boolean
        Get
            Return GetBooleanProperty("ErrorCleared")
        End Get
    End Property

    ''' <summary>
    ''' More information about the error recorded in LastErrorCode, and information about corrective actions that can be taken.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ErrorDescription() As String
        Get
            Return GetStringProperty("ErrorDescription")
        End Get
    End Property

    ''' <summary>
    ''' Last error code reported by the logical device.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property LastErrorCode() As UInt32
        Get
            Return GetUint32Property("LastErrorCode")
        End Get
    End Property

    ''' <summary>
    ''' Windows Plug and Play device identifier of the logical device.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property PNPDeviceID() As String
        Get
            Return GetStringProperty("PNPDeviceID")
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
    ''' Indicates that the power of the device can be managed, which means that it can be put into suspend mode, and so on.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>The property does not indicate that power management features are enabled, but it does indicate that the logical device power can be managed.</remarks>
    Public ReadOnly Property PowerManagementSupported() As Boolean
        Get
            Return GetBooleanProperty("PowerManagementSupported")
        End Get
    End Property

    ''' <summary>
    ''' State of the logical device.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>If this property does not apply to the logical device, use the value 5, which means Not Applicable.</remarks>
    Public ReadOnly Property StatusInfo() As CIM_LogicalDevices.StatusInfo
        Get
            Dim obj As Object = GetPropertyObject("StatusInfo")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, CIM_LogicalDevices.StatusInfo)
            End If
        End Get
    End Property

    ''' <summary>
    ''' Value of the CreationClassName property for the scoping computer.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property SystemCreationClassName() As String
        Get
            Return GetStringProperty("SystemCreationClassName")
        End Get
    End Property

    ''' <summary>
    ''' Name of the scoping system.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property SystemName() As String
        Get
            Return GetStringProperty("SystemName")
        End Get
    End Property

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.CIM_LogicalDevice"></see>.
''' </summary>
''' <remarks></remarks>
Public MustInherit Class CIM_LogicalDevices
    Inherits CIM_LogicalElements

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
    ''' Availability and status of the device.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum Availability As UInt16

        ''' <summary>
        ''' No data: method returned 0.
        ''' </summary>
        ''' <remarks></remarks>
        NoData = 0

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
        ''' Running.
        ''' </summary>
        ''' <remarks></remarks>
        Running = 3

        ''' <summary>
        ''' Full Power.
        ''' </summary>
        ''' <remarks></remarks>
        FullPower = 3

        ''' <summary>
        ''' Warning.
        ''' </summary>
        ''' <remarks></remarks>
        Warning = 4

        ''' <summary>
        ''' In Test.
        ''' </summary>
        ''' <remarks></remarks>
        InTest = 5

        ''' <summary>
        ''' Not Applicable.
        ''' </summary>
        ''' <remarks></remarks>
        NotApplicable = 6

        ''' <summary>
        ''' Power Off.
        ''' </summary>
        ''' <remarks></remarks>
        PowerOff = 7

        ''' <summary>
        ''' Off Line.
        ''' </summary>
        ''' <remarks></remarks>
        OffLine = 8

        ''' <summary>
        ''' Off Duty.
        ''' </summary>
        ''' <remarks></remarks>
        OffDuty = 9

        ''' <summary>
        ''' Degraded.
        ''' </summary>
        ''' <remarks></remarks>
        Degraded = 10

        ''' <summary>
        ''' Not Installed.
        ''' </summary>
        ''' <remarks></remarks>
        NotInstalled = 11

        ''' <summary>
        ''' Install Error.
        ''' </summary>
        ''' <remarks></remarks>
        InstallError = 12

        ''' <summary>
        ''' The device is known to be in a power save state, but its exact status is unknown.
        ''' </summary>
        ''' <remarks></remarks>
        PowerSaveUnknown = 13

        ''' <summary>
        ''' The device is in a power save state, but is still functioning, and may exhibit decreased performance.
        ''' </summary>
        ''' <remarks></remarks>
        PowerSaveLowPowerMode = 14

        ''' <summary>
        ''' The device is not functioning, but can be brought to full power quickly.
        ''' </summary>
        ''' <remarks></remarks>
        PowerSaveStandby = 15

        ''' <summary>
        ''' Power Cycle.
        ''' </summary>
        ''' <remarks></remarks>
        PowerCycle = 16

        ''' <summary>
        ''' The device is in a warning state, though also in a power save state.
        ''' </summary>
        ''' <remarks></remarks>
        PowerSaveWarning = 17

    End Enum

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
    ''' State of the logical device.
    ''' </summary>
    ''' <remarks>
    ''' If this property does not apply to the logical device, use the value 5, which means Not Applicable.
    ''' </remarks>
    Public Enum StatusInfo As UInt16

        ''' <summary>
        ''' No data: method returned 0.
        ''' </summary>
        ''' <remarks></remarks>
        NoData = 0

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
        ''' Enabled.
        ''' </summary>
        ''' <remarks></remarks>
        Enabled = 3

        ''' <summary>
        ''' Disabled.
        ''' </summary>
        ''' <remarks></remarks>
        Disabled = 4

        ''' <summary>
        ''' Not Applicable.
        ''' </summary>
        ''' <remarks></remarks>
        NotApplicable = 5

    End Enum

End Class
