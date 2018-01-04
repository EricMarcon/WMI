Imports System.Management

''' <summary>
''' Represents the capabilities and management of the battery logical device.
''' </summary>
''' <remarks>
''' This class applies to batteries in laptop systems and other internal and external batteries. 
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa387189.aspx">MSDN</a>
''' </remarks>
Public MustInherit Class CIM_Battery
    Inherits CIM_LogicalDevice

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
    ''' Status of the battery.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property BatteryStatus() As Enums.BatteryStatus
        Get
            Dim obj As Object = GetPropertyObject("BatteryStatus")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.BatteryStatus)
            End If
        End Get
    End Property

    ''' <summary>
    ''' Enumeration that describes the battery's chemistry.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Chemistry() As Enums.Chemistry
        Get
            Dim obj As Object = GetPropertyObject("Chemistry")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.Chemistry)
            End If
        End Get
    End Property

    ''' <summary>
    ''' Design capacity of the battery in milliwatt-hours.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>If the property is not supported, enter 0 (zero).</remarks>
    Public ReadOnly Property DesignCapacity() As UInt32
        Get
            Return GetUint32Property("DesignCapacity")
        End Get
    End Property

    ''' <summary>
    ''' Design voltage of the battery in millivolts.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>If the attribute is not supported, enter 0 (zero).</remarks>
    Public ReadOnly Property DesignVoltage() As UInt64
        Get
            Return GetUint32Property("DesignVoltage")
        End Get
    End Property

    ''' <summary>
    ''' Estimate of the percentage of full charge remaining.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property EstimatedChargeRemaining() As UInt16
        Get
            Return GetUint16Property("EstimatedChargeRemaining")
        End Get
    End Property

    ''' <summary>
    ''' Estimate in minutes of the time to battery charge depletion under the present load conditions if the utility power is off, or lost and remains off, or a laptop is disconnected from a power source.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property EstimatedRunTime() As UInt32
        Get
            Return GetUint32Property("EstimatedRunTime")
        End Get
    End Property

    ''' <summary>
    ''' Battery's expected lifetime in minutes, assuming that the battery is fully charged.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' The property represents the total expected life of the battery, not its current remaining life, which is indicated by the <see cref="P:WMIwrapper.CIM_Battery.EstimatedRunTime"></see> property.
    ''' </remarks>
    Public ReadOnly Property ExpectedLife() As UInt32
        Get
            Return GetUint32Property("ExpectedLife")
        End Get
    End Property

    ''' <summary>
    ''' Full charge capacity of the battery in milliwatt-hours.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' Comparison of the value to the <see cref="P:WMIwrapper.CIM_Battery.DesignCapacity"></see> property determines when the battery requires replacement.
    ''' A battery's end of life is typically when the <see cref="P:WMIwrapper.CIM_Battery.FullChargeCapacity"></see> property falls below 80% of the <see cref="P:WMIwrapper.CIM_Battery.DesignCapacity"></see> property.
    ''' If the property is not supported, enter 0 (zero).
    ''' </remarks>
    Public ReadOnly Property FullChargeCapacity() As UInt32
        Get
            Return GetUint32Property("FullChargeCapacity")
        End Get
    End Property

    ''' <summary>
    ''' Maximum time, in minutes, to fully charge the battery.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' The property represents the time to recharge a fully depleted battery, not the current remaining charge time, which is indicated in the <see cref="P:WMIwrapper.CIM_Battery.TimeToFullCharge"></see> property.
    ''' </remarks>
    Public ReadOnly Property MaxRechargeTime() As UInt32
        Get
            Return GetUint32Property("MaxRechargeTime")
        End Get
    End Property

    ''' <summary>
    ''' Data Specification version number supported by the battery.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>If the battery does not support this function, the value should be left blank.</remarks>
    Public ReadOnly Property SmartBatteryVersion() As String
        Get
            Return GetStringProperty("SmartBatteryVersion")
        End Get
    End Property

    ''' <summary>
    ''' Elapsed time in seconds since the computer system's UPS last switched to battery power, or the time since the system or UPS was last restarted, whichever is less.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>If the battery is "on line", 0 (zero) is returned.</remarks>
    Public ReadOnly Property TimeOnBattery() As UInt32
        Get
            Return GetUint32Property("TimeOnBattery")
        End Get
    End Property

    ''' <summary>
    ''' Remaining time to charge the battery fully in minutes at the current charging rate and usage.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property TimeToFullCharge() As UInt32
        Get
            Return GetUint32Property("TimeToFullCharge")
        End Get
    End Property

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.CIM_Battery"></see>.
''' </summary>
''' <remarks></remarks>
Public MustInherit Class CIM_Batteries
    Inherits CIM_LogicalDevices

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
    ''' Status of the battery.
    ''' </summary>
    ''' <remarks>The value 10 (Undefined) is not valid in the CIM schema because in DMI it represents that no battery is installed.
    ''' In this case, the object should not be instantiated.
    ''' </remarks>
    Public Enum BatteryStatus As UInt16

        ''' <summary>
        ''' No data: method returned 0.
        ''' </summary>
        ''' <remarks></remarks>
        NoData = 0

        ''' <summary>
        ''' The battery is discharging.
        ''' </summary>
        ''' <remarks></remarks>
        Discharging

        ''' <summary>
        ''' The system has access to AC so no battery is being discharged.
        ''' However, the battery is not necessarily charging.
        ''' </summary>
        ''' <remarks></remarks>
        AC

        ''' <summary>
        ''' Fully Charged.
        ''' </summary>
        ''' <remarks></remarks>
        FullyCharged

        ''' <summary>
        ''' Low.
        ''' </summary>
        ''' <remarks></remarks>
        Low

        ''' <summary>
        ''' Critical.
        ''' </summary>
        ''' <remarks></remarks>
        Critical

        ''' <summary>
        ''' Charging.
        ''' </summary>
        ''' <remarks></remarks>
        Charging

        ''' <summary>
        ''' Charging and High.
        ''' </summary>
        ''' <remarks></remarks>
        ChargingHigh

        ''' <summary>
        ''' Charging and Low.
        ''' </summary>
        ''' <remarks></remarks>
        ChargingLow

        ''' <summary>
        ''' Charging and Critical.
        ''' </summary>
        ''' <remarks></remarks>
        ChargingCritical

        ''' <summary>
        ''' Undefined.
        ''' </summary>
        ''' <remarks></remarks>
        Undefined

        ''' <summary>
        ''' Partially Charged.
        ''' </summary>
        ''' <remarks></remarks>
        PartiallyCharged

    End Enum

    ''' <summary>
    ''' Battery's chemistry.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum Chemistry As UInt16

        ''' <summary>
        ''' Other
        ''' </summary>
        ''' <remarks></remarks>
        Other = 0

        ''' <summary>
        ''' Unknown.
        ''' </summary>
        ''' <remarks></remarks>
        Unknown

        ''' <summary>
        ''' Lead Acid.
        ''' </summary>
        ''' <remarks></remarks>
        LeadAcid

        ''' <summary>
        ''' Nickel Cadmium.
        ''' </summary>
        ''' <remarks></remarks>
        NickelCadmium

        ''' <summary>
        ''' Nickel Metal Hydride.
        ''' </summary>
        ''' <remarks></remarks>
        NickelMetalHydride

        ''' <summary>
        ''' Lithium-ion.
        ''' </summary>
        ''' <remarks></remarks>
        LithiumIon

        ''' <summary>
        ''' Zinc air.
        ''' </summary>
        ''' <remarks></remarks>
        ZincAir

        ''' <summary>
        ''' Lithium Polymer.
        ''' </summary>
        ''' <remarks></remarks>
        LithiumPolymer

    End Enum

End Namespace
