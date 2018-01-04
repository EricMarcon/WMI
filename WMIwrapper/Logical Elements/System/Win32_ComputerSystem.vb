Imports System.Management

''' <summary>
''' Represents a computer system running Windows.
''' </summary>
''' <remarks>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa394102.aspx">MSDN</a>
''' </remarks>
Public Class Win32_ComputerSystem
    Inherits CIM_UnitaryComputerSystem

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
    ''' System hardware security settings for administrator password status.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private ReadOnly Property AdminPasswordStatus() As Enums.AdminPasswordStatus
        Get
            Dim obj As Object = GetPropertyObject("AdminPasswordStatus")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.AdminPasswordStatus)
            End If
        End Get
    End Property

    ''' <summary>
    ''' If True, the system manages the page file. 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Windows Server 2003, Windows XP, and Windows 2000:  This property is not available.</remarks>
    Public Property AutomaticManagedPagefile() As Boolean
        Get
            Return GetBooleanProperty("AutomaticManagedPagefile")
        End Get
        Set(ByVal value As Boolean)
            _ManagementObject.SetPropertyValue("AutomaticManagedPagefile", value)
        End Set
    End Property

    ''' <summary>
    ''' If True, the automatic reset boot option is enabled.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property AutomaticResetBootOption() As Boolean
        Get
            Return GetBooleanProperty("AutomaticResetBootOption")
        End Get
        Set(ByVal value As Boolean)
            _ManagementObject.SetPropertyValue("AutomaticResetBootOption", value)
        End Set
    End Property

    ''' <summary>
    ''' If True, the automatic reset is enabled.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property AutomaticResetCapability() As Boolean
        Get
            Return GetBooleanProperty("AutomaticResetCapability")
        End Get
    End Property

    ''' <summary>
    ''' Boot option limit is ON. Identifies the system action when the ResetLimit value is reached.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private ReadOnly Property BootOptionOnLimit() As Enums.BootOptions
        Get
            Dim obj As Object = GetPropertyObject("BootOptionOnLimit")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.BootOptions)
            End If
        End Get
    End Property

    ''' <summary>
    ''' Type of reboot action after the time on the watchdog timer is elapsed.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private ReadOnly Property BootOptionOnWatchDog() As Enums.BootOptions
        Get
            Dim obj As Object = GetPropertyObject("BootOptionOnWatchDog")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.BootOptions)
            End If
        End Get
    End Property

    ''' <summary>
    ''' If True, indicates a boot ROM is supported.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property BootROMSupported() As Boolean
        Get
            Return GetBooleanProperty("BootROMSupported")
        End Get
    End Property

    ''' <summary>
    ''' System is started. Fail-safe boot bypasses the user startup files—also called SafeBoot. 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' The following list contains the required values:
    ''' <list type="bullet">
    ''' <item><description>Normal boot.</description></item>
    ''' <item><description>Fail-safe boot.</description></item>
    ''' <item><description>Fail-safe with network boot.</description></item>
    ''' </list>
    ''' </remarks>
    Public ReadOnly Property BootupState() As String
        Get
            Return GetStringProperty("BootupState")
        End Get
    End Property

    ''' <summary>
    ''' Boot up state of the chassis.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ChassisBootupState() As Enums.ChassisBootupState
        Get
            Dim obj As Object = GetPropertyObject("ChassisBootupState")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.ChassisBootupState)
            End If
        End Get
    End Property

    ''' <summary>
    ''' Number of minutes the operating system is offset from Greenwich Mean Time (GMT).
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>The number is positive, negative, or zero.</remarks>
    Public Property CurrentTimeZone() As Int16
        Get
            Return GetInt16Property("CurrentTimeZone")
        End Get
        Set(ByVal value As Int16)
            _ManagementObject.SetPropertyValue("CurrentTimeZone", value)
        End Set
    End Property

    ''' <summary>
    ''' If True, the daylight savings mode is ON.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property DaylightInEffect() As Boolean
        Get
            Return GetBooleanProperty("DaylightInEffect")
        End Get
    End Property

    ''' <summary>
    ''' Name of local computer according to the domain name server (DNS).
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Windows XP and Windows 2000:  This property is not available.</remarks>
    Public ReadOnly Property DNSHostName() As String
        Get
            Return GetStringProperty("DNSHostName")
        End Get
    End Property

    ''' <summary>
    ''' Name of the domain to which a computer belongs.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>If the computer is not part of a domain, then the name of the workgroup is returned.</remarks>
    Public ReadOnly Property Domain() As String
        Get
            Return GetStringProperty("Domain")
        End Get
    End Property

    ''' <summary>
    ''' Role of a computer in an assigned domain workgroup.
    ''' A domain workgroup is a collection of computers on the same network.
    ''' For example, a DomainRole property may show that a computer is a member workstation.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property DomainRole() As Enums.DomainRole
        Get
            Dim obj As Object = GetPropertyObject("DomainRole")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.DomainRole)
            End If
        End Get
    End Property

    ''' <summary>
    ''' Enables daylight savings time (DST) on a computer.
    ''' </summary>
    ''' <value>
    ''' A value of True indicates that the system time changes to an hour ahead or behind when DST starts or ends.
    ''' A value of False indicates that the system time does not change to an hour ahead or behind when DST starts or ends.
    ''' A value of NULL indicates that the DST status is unknown on a system.
    ''' </value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property EnableDaylightSavingsTime() As Boolean
        Get
            Return GetBooleanProperty("EnableDaylightSavingsTime")
        End Get
    End Property

    ''' <summary>
    ''' The following table lists the hardware security settings for the reset button on a computer.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property FrontPanelResetStatus() As Enums.Status
        Get
            Dim obj As Object = GetPropertyObject("FrontPanelResetStatus")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.Status)
            End If
        End Get
    End Property

    ''' <summary>
    ''' If True, an infrared (IR) port exists on a computer system.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property InfraredSupported() As Boolean
        Get
            Return GetBooleanProperty("InfraredSupported")
        End Get
    End Property

    ''' <summary>
    ''' System hardware security settings for Keyboard Password Status.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property KeyboardPasswordStatus() As Enums.Status
        Get
            Dim obj As Object = GetPropertyObject("KeyboardPasswordStatus")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.Status)
            End If
        End Get
    End Property

    ''' <summary>
    ''' Name of the organization responsible for producing the physical element.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected ReadOnly Property Manufacturer() As String
        Get
            Return GetStringProperty("Manufacturer")
        End Get
    End Property

    ''' <summary>
    ''' Name by which the physical element is generally known.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected ReadOnly Property Model() As String
        Get
            Return GetStringProperty("Model")
        End Get
    End Property

    ''' <summary>
    ''' If True, the network Server Mode is enabled.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property NetworkServerModeEnabled() As Boolean
        Get
            Return GetBooleanProperty("NetworkServerModeEnabled")
        End Get
    End Property

    ''' <summary>
    ''' Number of logical processors available on the computer.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' <para>For processors capable of hyperthreading, this value includes only the processors which have hyperthreading enabled.
    ''' </para>
    ''' <para>Windows Server 2003, Windows XP, and Windows 2000:  This property is not available.</para>
    ''' </remarks>
    Public ReadOnly Property NumberOfLogicalProcessors() As UInt32
        Get
            Return GetUint32Property("NumberOfLogicalProcessors")
        End Get
    End Property

    ''' <summary>
    ''' Number of physical processors currently available on a system.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' This is the number of enabled processors for a system, which does not include the disabled processors.
    ''' If a computer system has two physical processors each containing two logical processors, then the value of <see cref="P:WMIwrapper.Win32_ComputerSystem.NumberOfProcessors"></see> is 2 and <see cref="P:WMIwrapper.Win32_ComputerSystem.NumberOfLogicalProcessors"></see> is 4.
    ''' The processors may be multicore or they may be hyperthreading processors.
    ''' Windows Server 2003, Windows XP, and Windows 2000:  Because the <see cref="P:WMIwrapper.Win32_ComputerSystem.NumberOfLogicalProcessors"></see> property is not available, <see cref="P:WMIwrapper.Win32_ComputerSystem.NumberOfProcessors"></see> indicates the number of logical processors available in the system.
    ''' In the case of a computer system that has two physical processors each containing two logical processors, the value of <see cref="P:WMIwrapper.Win32_ComputerSystem.NumberOfProcessors"></see> is 4.</remarks>
    Public ReadOnly Property NumberOfProcessors() As UInt32
        Get
            Return GetUint32Property("NumberOfProcessors")
        End Get
    End Property

    ''' <summary>
    ''' List of data for a bitmap that the original equipment manufacturer (OEM) creates.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property OEMLogoBitmap() As Byte()
        Get
            Return GetByteArrayProperty("OEMLogoBitmap")
        End Get
    End Property

    ''' <summary>
    ''' List of free-form strings that an OEM defines.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>For example, an OEM defines the part numbers for system reference documents, manufacturer contact information, and so on.</remarks>
    Public ReadOnly Property OEMStringArray() As String()
        Get
            Return GetStringArrayProperty("OEMStringArray")
        End Get
    End Property

    ''' <summary>
    ''' If True, the computer is part of a domain.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' If the value is NULL, the computer is not in a domain or the status is unknown.
    ''' If you unjoin the computer from a domain, the value becomes false.
    ''' </remarks>
    Public ReadOnly Property PartOfDomain() As Boolean
        Get
            Return GetBooleanProperty("PartOfDomain")
        End Get
    End Property

    ''' <summary>
    ''' Time delay before a reboot is initiated—in milliseconds.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' It is used after a system power cycle, local or remote system reset, and automatic system reset.
    ''' A value of –1 (minus one) indicates that the pause value is unknown.
    ''' </remarks>
    Public ReadOnly Property PauseAfterReset() As Int64
        Get
            Return GetInt64Property("PauseAfterReset")
        End Get
    End Property

    ''' <summary>
    ''' Type of the computer in use, such as laptop, desktop, or Tablet.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Windows Server 2003, Windows XP, Windows 2000, Windows NT 4.0, and Windows Me/98/95:  This property is not available.</remarks>
    Public ReadOnly Property PCSystemType() As Enums.PCSystemType
        Get
            Dim obj As Object = GetPropertyObject("PCSystemType")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.PCSystemType)
            End If
        End Get
    End Property

    ''' <summary>
    ''' System hardware security settings for Power-On Password Status.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property PowerOnPasswordStatus() As Enums.Status
        Get
            Dim obj As Object = GetPropertyObject("PowerOnPasswordStatus")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.Status)
            End If
        End Get
    End Property

    ''' <summary>
    ''' State of the power supply or supplies when last booted. The following list identifies the values for this property.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property PowerSupplyState() As Enums.State
        Get
            Dim obj As Object = GetPropertyObject("PowerSupplyState")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.State)
            End If
        End Get
    End Property

    ''' <summary>
    ''' Number of automatic resets since the last reset. A value of –1 (minus one) indicates that the count is unknown.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ResetCount() As Int16
        Get
            Return GetInt16Property("ResetCount")
        End Get
    End Property

    ''' <summary>
    ''' Number of consecutive times a system reset is attempted. A value of –1 (minus one) indicates that the limit is unknown.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ResetLimit() As Int16
        Get
            Return GetInt16Property("ResetLimit")
        End Get
    End Property

    ''' <summary>
    ''' List of the support contact information for the Windows operating system.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property SupportContactDescription() As String()
        Get
            Return GetStringArrayProperty("SupportContactDescription")
        End Get
    End Property

    ''' <summary>
    ''' Time to delay before starting the Windows operating system—in seconds.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' Beginning with Windows Vista, SystemStartupDelay is obsolete because Boot.ini is not used to configure system startup.
    ''' Instead, use the BCD classes supplied by the Boot Configuration Data (BCD) WMI provider or the Bcdedit command.
    ''' </remarks>
    Public Property SystemStartupDelay() As UInt16
        Get
            Return GetUint16Property("SystemStartupDelay")
        End Get
        Set(ByVal value As UInt16)
            _ManagementObject.SetPropertyValue("SystemStartupDelay", value)
        End Set
    End Property

    ''' <summary>
    ''' List of the options for starting up the coumputer system running Windows.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' This property must have a value.
    ''' Beginning with Windows Vista, SystemStartupOptions is obsolete because Boot.ini is not used to configure system startup.
    ''' Instead, use the BCD classes supplied by the Boot Configuration Data (BCD) WMI provider or the Bcdedit command.
    ''' </remarks>
    Public ReadOnly Property SystemStartupOptions() As String()
        Get
            Return GetStringArrayProperty("SystemStartupOptions")
        End Get
    End Property

    ''' <summary>
    ''' Index of the default startup profile.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' This value is calculated so that it usually returns 0 (zero), because at write-time the profile string is physically moved to the top of the list, which is how Windows NT determines the default value.
    ''' Beginning with Windows Vista, SystemStartupSetting is obsolete because Boot.ini is not used to configure system startup.
    ''' Instead, use the BCD classes supplied by the Boot Configuration Data (BCD) WMI provider or the Bcdedit command.
    ''' </remarks>
    Public Property SystemStartupSetting() As Byte
        Get
            Return GetByteProperty("SystemStartupSetting")
        End Get
        Set(ByVal value As Byte)
            _ManagementObject.SetPropertyValue("SystemStartupSetting", value)
        End Set
    End Property

    ''' <summary>
    ''' System running on the Windows-based computer.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property SystemType() As String
        Get
            Return GetStringProperty("SystemType")
        End Get
    End Property

    ''' <summary>
    ''' Thermal state of the system when last booted.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ThermalState() As Enums.State
        Get
            Dim obj As Object = GetPropertyObject("ThermalState")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.State)
            End If
        End Get
    End Property

    ''' <summary>
    ''' Total size of physical memory.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' Be aware that, under some circumstances, this property may not return an accurate value for the physical memory.
    ''' For example, it is not accurate if the BIOS is using some of the physical memory.
    ''' For an accurate value, use the <see cref="P:WMIwrapper.Win32_PhysicalMemory.Capacity"></see> property in <see cref="T:WMIwrapper.Win32_PhysicalMemory"></see> instead.
    ''' </remarks>
    Public ReadOnly Property TotalPhysicalMemory() As UInt64
        Get
            Return GetUint64Property("TotalPhysicalMemory")
        End Get
    End Property

    ''' <summary>
    ''' Name of a user that is logged on currently.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' This property must have a value.
    ''' In a terminal services session, UserName returns the name of the user that is logged on to the console—not the user logged on during the terminal service session.
    ''' </remarks>
    Public ReadOnly Property UserName() As String
        Get
            Return GetStringProperty("UserName")
        End Get
    End Property

    ''' <summary>
    ''' Event that causes the system to power up.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property WakeUpType() As Enums.WakeUpType
        Get
            Dim obj As Object = GetPropertyObject("WakeUpType")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.WakeUpType)
            End If
        End Get
    End Property

    ''' <summary>
    ''' Name of the workgroup for this computer.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' If the value of the <see cref="P:WMIwrapper.Win32_ComputerSystem.PartOfDomain"></see> property is False, then the name of the workgroup is returned.
    ''' Windows 2000 and Windows NT:  This property is not available.
    ''' </remarks>
    Public ReadOnly Property Workgroup() As String
        Get
            Return GetStringProperty("Workgroup")
        End Get
    End Property

#End Region

#Region "Methods"

    ''' <summary>
    ''' Join a computer system to a domain or workgroup.
    ''' </summary>
    ''' <param name="Name">
    ''' Specifies the domain or workgroup to join.
    ''' Cannot be NULL.
    ''' </param>
    ''' <param name="Password">
    ''' If the UserName parameter specifies an account name, the Password parameter must point to the password to use when connecting to the domain controller.
    ''' Otherwise, this parameter must be NULL.
    ''' </param>
    ''' <param name="UserName">
    ''' Pointer to a constant null-terminated character string that specifies the account name to use when connecting to the domain controller.
    ''' Must specify a domain NetBIOS name and user account, for example, Domain\user.
    ''' If this parameter is NULL, the caller information is used.
    ''' You can also use the user principal name (UPPED) in the form user@domain.
    ''' Windows 2000, Windows NT 4.0, and Windows Me/98/95:  You cannot specify UserName in UPPED format.
    ''' </param>
    ''' <param name="AccountOU">
    ''' Specifies the pointer to a constant null-terminated character string that contains the RFC 1779 format name of the organizational unit (OU) for the computer account.
    ''' If you specify this parameter, the string must contain a full path, otherwise Accent must be NULL. 
    ''' Example: "OU=testOU, DC=domain, DC=Domain, DC=com"
    ''' </param>
    ''' <param name="FJoinOptions">Join Options.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function JoinDomainOrWorkgroup( _
           ByVal Name As String, _
           ByVal Password As String, _
           ByVal UserName As String, _
           ByVal AccountOU As String, _
           ByVal FJoinOptions As Enums.FJoinOptions _
           ) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_ComputerSystem"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("JoinDomainOrWorkgroup")
        inParams("Name") = Name
        inParams("Password") = Password
        inParams("UserName") = UserName
        inParams("AccountOU") = AccountOU
        inParams("FJoinOptions") = FJoinOptions

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("JoinDomainOrWorkgroup", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Rename a computer.
    ''' </summary>
    ''' <param name="Name">
    ''' Specifies the domain or workgroup to join.
    ''' Cannot be NULL.
    ''' </param>
    ''' <param name="Password">
    ''' If the UserName parameter specifies an account name, the Password parameter must point to the password to use when connecting to the domain controller.
    ''' Otherwise, this parameter must be NULL.
    ''' </param>
    ''' <param name="UserName">
    ''' Pointer to a constant null-terminated character string that specifies the account name to use when connecting to the domain controller.
    ''' Must specify a domain NetBIOS name and user account, for example, Domain\user.
    ''' If this parameter is NULL, the caller information is used.
    ''' You can also use the user principal name (UPPED) in the form user@domain.
    ''' Windows 2000, Windows NT 4.0, and Windows Me/98/95:  You cannot specify UserName in UPPED format.
    ''' </param>
    ''' <returns></returns>
    ''' <remarks>Cannot be used to rename remote computers.</remarks>
    Public Function Rename( _
           ByVal Name As String, _
           ByVal Password As String, _
           ByVal UserName As String, _
           ByVal AccountOU As String, _
           ByVal FJoinOptions As Enums.FJoinOptions _
           ) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_ComputerSystem"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("Rename")
        inParams("Name") = Name
        inParams("Password") = Password
        inParams("UserName") = UserName

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("Rename", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Join a computer system to a domain or workgroup.
    ''' </summary>
    ''' <param name="Password">
    ''' If the UserName parameter specifies an account name, the Password parameter must point to the password to use when connecting to the domain controller.
    ''' Otherwise, this parameter must be NULL.
    ''' </param>
    ''' <param name="UserName">
    ''' Pointer to a constant null-terminated character string that specifies the account name to use when connecting to the domain controller.
    ''' Must specify a domain NetBIOS name and user account, for example, Domain\user.
    ''' If this parameter is NULL, the caller information is used.
    ''' You can also use the user principal name (UPPED) in the form user@domain.
    ''' Windows 2000, Windows NT 4.0, and Windows Me/98/95:  You cannot specify UserName in UPPED format.
    ''' </param>
    ''' <param name="FUnJoinOptions">Join Options.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function UnjoinDomainOrWorkgroup( _
           ByVal Password As String, _
           ByVal UserName As String, _
           ByVal FUnJoinOptions As Enums.FUnjoinOptions _
           ) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_ComputerSystem"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("UnjoinDomainOrWorkgroup")
        inParams("Password") = Password
        inParams("UserName") = UserName
        inParams("FUnJoinOptions") = FUnJoinOptions

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("UnjoinDomainOrWorkgroup", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.Win32_ComputerSystem"></see>.
''' </summary>
''' <remarks></remarks>
Public Class Win32_ComputerSystems
    Inherits CIM_UnitaryComputerSystems

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <param name="Name">If specified, only the item corresponding to this key value is returned. Ignored if <code>Condition</code> is set.</param>
    ''' <param name="Condition">WQL condition can be specified. It is not checked and sent to WMI as is.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Computer As String, Optional ByVal Name As String = Nothing, Optional ByVal Condition As String = Nothing)

        MyBase.New(Computer, "Win32_ComputerSystem")
        ' Prepare condition
        If Condition Is Nothing AndAlso Name IsNot Nothing Then
            Condition = "Name ='" & Name & "'"
        End If
        ' Read the collection
        For Each ManagementObjectI As ManagementObject In Me.Read(Condition)
            Me.Add(New Win32_ComputerSystem(ManagementObjectI))
        Next

    End Sub

    ''' <summary>
    ''' Find an item in the collection.
    ''' </summary>
    ''' <param name="index">Index of the item.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal index As Integer) As Win32_ComputerSystem
        Return CType(List.Item(index), Win32_ComputerSystem)
    End Function

    ''' <summary>
    ''' Find an item by its name.
    ''' </summary>
    ''' <param name="Name">The system's name.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal Name As String) As Win32_ComputerSystem
        For intI As Integer = 0 To List.Count - 1
            If Me.Item(intI).Name = Name Then
                Return Me.Item(intI)
            End If
        Next
        Return Nothing
    End Function

End Class


Namespace Enums

    ''' <summary>
    ''' System hardware security settings for administrator password status.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum AdminPasswordStatus As UInt16

        ''' <summary>
        ''' Disabled.
        ''' </summary>
        ''' <remarks></remarks>
        Disabled = 1

        ''' <summary>
        ''' Enabled.
        ''' </summary>
        ''' <remarks></remarks>
        Enabled = 2

        ''' <summary>
        ''' Not Implemented.
        ''' </summary>
        ''' <remarks></remarks>
        NotImplemented = 3

        ''' <summary>
        ''' Unknown.
        ''' </summary>
        ''' <remarks></remarks>
        Unknown = 4

    End Enum

    ''' <summary>
    ''' Types of reboot action .
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum BootOptions As UInt16

        ''' <summary>
        ''' Reserved.
        ''' </summary>
        ''' <remarks></remarks>
        Reserved = 1

        ''' <summary>
        ''' Operating System.
        ''' </summary>
        ''' <remarks></remarks>
        OperatingSystem = 2

        ''' <summary>
        ''' System Utilities.
        ''' </summary>
        ''' <remarks></remarks>
        SystemUtilities = 3

        ''' <summary>
        ''' Do Not Reboot.
        ''' </summary>
        ''' <remarks></remarks>
        DoNotReboot = 4

    End Enum

    ''' <summary>
    ''' Boot up state of the chassis.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum ChassisBootupState As UInt16

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
        ''' Safes.
        ''' </summary>
        ''' <remarks></remarks>
        Safes = 3

        ''' <summary>
        ''' Warning.
        ''' </summary>
        ''' <remarks></remarks>
        Warning = 4

        ''' <summary>
        ''' Critical.
        ''' </summary>
        ''' <remarks></remarks>
        Critical = 5

        ''' <summary>
        ''' Nonrecoverable.
        ''' </summary>
        ''' <remarks></remarks>
        Nonrecoverable = 6

    End Enum

    ''' <summary>
    ''' Role of a computer in an assigned domain workgroup.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum DomainRole As UInt16

        ''' <summary>
        '''  Standalone Workstation.
        ''' </summary>
        ''' <remarks></remarks>
        StandaloneWorkstation = 0

        ''' <summary>
        ''' Member Workstation.
        ''' </summary>
        ''' <remarks></remarks>
        MemberWorkstation = 1

        ''' <summary>
        ''' Standalone Server.
        ''' </summary>
        ''' <remarks></remarks>
        StandaloneServer = 2

        ''' <summary>
        ''' Member Server.
        ''' </summary>
        ''' <remarks></remarks>
        MemberServer = 3

        ''' <summary>
        ''' Backup Domain Controller.
        ''' </summary>
        ''' <remarks></remarks>
        BackupDomainController = 4

        ''' <summary>
        ''' Primary Domain Controller.
        ''' </summary>
        ''' <remarks></remarks>
        PrimaryDomainController = 5

    End Enum

    ''' <summary>
    ''' Status.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum Status As UInt16

        ''' <summary>
        ''' Disabled.
        ''' </summary>
        ''' <remarks></remarks>
        Disabled = 0

        ''' <summary>
        ''' Enabled.
        ''' </summary>
        ''' <remarks></remarks>
        Enabled = 1

        ''' <summary>
        ''' Not Implemented.
        ''' </summary>
        ''' <remarks></remarks>
        NotImplemented = 2

        ''' <summary>
        ''' Unknown.
        ''' </summary>
        ''' <remarks></remarks>
        Unknown = 3

    End Enum

    ''' <summary>
    ''' Type of the computer in use, such as laptop, desktop, or Tablet.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum PCSystemType As UInt16

        ''' <summary>
        ''' Unspecified.
        ''' </summary>
        ''' <remarks></remarks>
        Unspecified = 0

        ''' <summary>
        ''' Desktop.
        ''' </summary>
        ''' <remarks></remarks>
        Desktop = 1

        ''' <summary>
        ''' Mobile.
        ''' </summary>
        ''' <remarks></remarks>
        Mobile = 2

        ''' <summary>
        ''' Workstation.
        ''' </summary>
        ''' <remarks></remarks>
        Workstation = 3

        ''' <summary>
        ''' Enterprise Server.
        ''' </summary>
        ''' <remarks></remarks>
        EnterpriseServer = 4

        ''' <summary>
        ''' Small Office and Home Office (SOHO) Server.
        ''' </summary>
        ''' <remarks></remarks>
        SOHO = 5

        ''' <summary>
        ''' Appliance PC.
        ''' </summary>
        ''' <remarks></remarks>
        AppliancePC = 6

        ''' <summary>
        ''' Performance Server.
        ''' </summary>
        ''' <remarks></remarks>
        PerformanceServer = 7

        ''' <summary>
        ''' Maximum.
        ''' </summary>
        ''' <remarks></remarks>
        Maximum = 8

    End Enum

    ''' <summary>
    ''' State.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum State As UInt16

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
        ''' Safe.
        ''' </summary>
        ''' <remarks></remarks>
        Safe = 3

        ''' <summary>
        ''' Warning.
        ''' </summary>
        ''' <remarks></remarks>
        Warning = 4

        ''' <summary>
        ''' Critical.
        ''' </summary>
        ''' <remarks></remarks>
        Critical = 5

        ''' <summary>
        ''' Nonrecoverable.
        ''' </summary>
        ''' <remarks></remarks>
        Nonrecoverable = 6

    End Enum

    ''' <summary>
    ''' Event that causes the system to power up.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum WakeUpType As UInt16

        ''' <summary>
        ''' Reserved.
        ''' </summary>
        ''' <remarks></remarks>
        Reserved = 0

        ''' <summary>
        ''' Other.
        ''' </summary>
        ''' <remarks></remarks>
        Other = 1

        ''' <summary>
        ''' Unknown=2.
        ''' </summary>
        ''' <remarks></remarks>
        Unknown = 2

        ''' <summary>
        ''' APM Timer.
        ''' </summary>
        ''' <remarks></remarks>
        APMTimer = 3

        ''' <summary>
        ''' Modem Ring.
        ''' </summary>
        ''' <remarks></remarks>
        ModemRing = 4

        ''' <summary>
        ''' LAN Remote.
        ''' </summary>
        ''' <remarks></remarks>
        LANRemote = 5

        ''' <summary>
        ''' Power Switch.
        ''' </summary>
        ''' <remarks></remarks>
        PowerSwitch = 6

        ''' <summary>
        ''' PCI PME#
        ''' </summary>
        ''' <remarks></remarks>
        PCIPME = 7

        ''' <summary>
        ''' AC Power Restored.
        ''' </summary>
        ''' <remarks></remarks>
        ACPowerRestored

    End Enum

    ''' <summary>
    ''' Set of bit flags that define the join options.
    ''' </summary>
    ''' <remarks></remarks>
    <Flags()> _
    Public Enum FJoinOptions As UInt32

        ''' <summary>
        ''' Default. Joins a computer to a domain. If this value is not specified, the join is a computer to a workgroup.
        ''' </summary>
        ''' <remarks></remarks>
        DefaultJoin = 1

        ''' <summary>
        ''' Creates an account on a domain.
        ''' </summary>
        ''' <remarks></remarks>
        Create = 2

        ''' <summary>
        ''' Deletes an account when a domain exists.
        ''' </summary>
        ''' <remarks></remarks>
        Delete = 4

        ''' <summary>
        ''' The join operation is part of an upgrade from Windows 98 or Windows 95 to Windows 2000 or Windows NT.
        ''' </summary>
        ''' <remarks></remarks>
        Upgrade = 16

        ''' <summary>
        ''' Allows a join to a new domain, even if the computer is already joined to a domain.
        ''' </summary>
        ''' <remarks></remarks>
        Allow = 32

        ''' <summary>
        ''' Performs an unsecured join.
        ''' </summary>
        ''' <remarks></remarks>
        Unsecure = 64

        ''' <summary>
        ''' The machine, not the user, password passed. This option is only valid for unsecure joins.
        ''' </summary>
        ''' <remarks></remarks>
        MachinePassword = 128

        ''' <summary>
        ''' Writing SPN and DnsHostName attributes on the computer object should be deferred until the rename that follows the join.
        ''' </summary>
        ''' <remarks></remarks>
        Deferred = 256

        ''' <summary>
        ''' The APIs were invoked during install.
        ''' </summary>
        ''' <remarks></remarks>
        API = 262144

    End Enum

    ''' <summary>
    ''' Set of bit flags defining the unjoin options.
    ''' </summary>
    ''' <remarks></remarks>
    <Flags()> _
    Public Enum FUnjoinOptions As UInt32

        ''' <summary>
        ''' No options.
        ''' </summary>
        ''' <remarks></remarks>
        DefaultUnjoin = 0

        ''' <summary>
        '''  Disable the Active Directory account after the unjoin operation, but do not delete the account.
        ''' </summary>
        ''' <remarks></remarks>
        NETSETUP_ACCT_DELETE = 2

    End Enum

End Namespace
