Imports System.Management

''' <summary>
''' Represents executable objects that are installed in a registry database maintained by the Service Control Manager.
''' </summary>
''' <remarks>
''' The executable file associated with a service can be started at boot time by a boot program or by the system.
''' It can also be started on-demand by the Service Control Manager.
''' Any service or process that is not owned by a specific user, and that provides an interface to some functionality supported by the computer system, is a descendent (or member) of this class.
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa394073.aspx">MSDN</a>
''' </remarks>
Public MustInherit Class Win32_BaseService
    Inherits CIM_Service

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

#Region "Properties"

    ''' <summary>
    ''' Indicates that the service can be paused.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property AcceptPause() As Boolean
        Get
            Return GetBooleanProperty("AcceptPause")
        End Get
    End Property

    ''' <summary>
    ''' Indicates that the service can be stopped.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property AcceptStop() As Boolean
        Get
            Return GetBooleanProperty("AcceptStop")
        End Get
    End Property

    ''' <summary>
    ''' Indicates that the service can create or communicate with windows on the desktop.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property DesktopInteract() As Boolean
        Get
            Return GetBooleanProperty("DesktopInteract")
        End Get
    End Property

    ''' <summary>
    ''' Display name of the service.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' This string has a maximum length of 256 characters.
    ''' The name is case-preserved in the Service Control Manager.
    ''' DisplayName comparisons are always case-insensitive.
    ''' </remarks>
    Public ReadOnly Property DisplayName() As String
        Get
            Return GetStringProperty("DisplayName")
        End Get
    End Property

    ''' <summary>
    ''' Severity of the error if this service fails to start during startup.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' This value indicates the action taken by the startup program if failure occurs.
    ''' All errors are logged by the computer system. 
    ''' Values are:
    ''' <list type="table">
    ''' <item><term>Ignore</term><description>User is not notified.</description></item>
    ''' <item><term>Normal</term><description>User is notified.</description></item>
    ''' <item><term>Severe</term><description>System is restarted with the last-known-good configuration.</description></item>
    ''' <item><term>Critical</term><description>System attempts to restart with a good configuration.</description></item>
    ''' <item><term>Unknown</term><description>Cause of the failure is unknown.</description></item>
    ''' </list>
    ''' </remarks>
    Public ReadOnly Property ErrorControl() As String
        Get
            Return GetStringProperty("ErrorControl")
        End Get
    End Property

    ''' <summary>
    ''' Windows error code defining any problems encountered in starting or stopping the service.
    ''' </summary>
    ''' <value></value>
    ''' <returns>
    ''' This property is set to ERROR_SERVICE_SPECIFIC_ERROR (1066) when the error is unique to the service represented by this class, 
    ''' and information about the error is available in the ServiceSpecificExitCode property.
    ''' The service sets this value to NO_ERROR when running, and again upon normal termination.
    ''' </returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ExitCode() As UInt32
        Get
            Return GetUint32Property("ExitCode")
        End Get
    End Property

    ''' <summary>
    ''' Fully-qualified path to the service binary file that implements the service.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Example: "\SystemRoot\System32\drivers\afd.sys"</remarks>
    Public ReadOnly Property PathName() As String
        Get
            Return GetStringProperty("PathName")
        End Get
    End Property

    ''' <summary>
    ''' Service-specific error code for errors that occur while the service is either starting or stopping.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>The exit codes are defined by the service represented by this class.
    ''' This value is only set when the ExitCode property value is ERROR_SERVICE_SPECIFIC_ERROR (1066).
    ''' </remarks>
    Public ReadOnly Property ServiceSpecificExitCode() As UInt32
        Get
            Return GetUint32Property("ServiceSpecificExitCode")
        End Get
    End Property

    ''' <summary>
    ''' Type of service provided to calling processes. 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' The values are:
    ''' <item><description>Kernel Driver.</description></item>
    ''' <item><description>File System Driver.</description></item>
    ''' <item><description>Adapter.</description></item>
    ''' <item><description>Recognizer Driver.</description></item>
    ''' <item><description>Own Process.</description></item>
    ''' <item><description>Share Process.</description></item>
    ''' <item><description>Interactive Process.</description></item>
    ''' </remarks>
    Public ReadOnly Property ServiceType() As String
        Get
            Return GetStringProperty("ServiceType")
        End Get
    End Property

    ''' <summary>
    ''' Account name under which the service runs.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Depending on the service type, the account name may be in the form of DomainName\Username.
    ''' The service process will be logged using one of these two forms when it runs.
    ''' If the account belongs to the built-in domain, .\Username can be specified.
    ''' If NULL is specified, the service will be logged on as the LocalSystem account.
    ''' For kernel or system-level drivers, StartName contains the driver object name 
    ''' (that is, \FileSystem\Rdr or \Driver\Xns) which the input and output (I/O) system uses to load the device driver.
    ''' Additionally, if NULL is specified, the driver runs with a default object name created by the I/O system based on the service name. 
    ''' Windows XP:  You can use User Principal Name (UPN) format (Username@DomainName) to specify the StartName.
    ''' </remarks>
    Public ReadOnly Property StartName() As String
        Get
            Return GetStringProperty("StartName")
        End Get
    End Property

    ''' <summary>
    ''' Current state of the base service.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' Values are:
    ''' <list type="bullet">
    ''' <item><description>Stopped.</description></item>
    ''' <item><description>Start Pending.</description></item>
    ''' <item><description>Stop Pending.</description></item>
    ''' <item><description>Running.</description></item>
    ''' <item><description>Continue Pending.</description></item>
    ''' <item><description>Continue Pending.</description></item>
    ''' <item><description>Pause Pending.</description></item>
    ''' <item><description>Paused.</description></item>
    ''' <item><description>Unknown.</description></item>
    ''' </list>
    ''' </remarks>
    Public ReadOnly Property State() As String
        Get
            Return GetStringProperty("State")
        End Get
    End Property

    ''' <summary>
    ''' Unique tag value for this service in the group. 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' A value of 0 (zero) indicates that the service has not been assigned a tag.
    ''' A tag can be used for ordering service startup within a load order group by specifying a tag order vector in the registry located at: 
    ''' HKEY_LOCAL_MACHINE\System\CurrentControlSet\Control\GroupOrderList. 
    ''' Tags are only evaluated for Kernel Driver and File System Driver start-type services that have Boot or System start modes.
    ''' </remarks>
    Public ReadOnly Property TagId() As UInt32
        Get
            Return GetUint32Property("TagId")
        End Get
    End Property

#End Region

#Region "Methods"

    ''' <summary>
    ''' Start the service.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function StartService() As InvokeError

        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("StartService")
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Stop the service.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function StopService() As InvokeError

        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("StopService")
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Pause the service.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function PauseService() As InvokeError

        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("PauseService")
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Resume the service.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ResumeService() As InvokeError

        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("ResumeService")
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Request that the system driver service update its state to the service manager.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function InterrogateService() As InvokeError

        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("InterrogateService")
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Attempts to send a user-defined control code to a service managed by a system driver.
    ''' </summary>
    ''' <param name="ControlCode">Specifies defined values (from 128 to 255) that provide control commands specific to a user.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function UserControlService(ByVal ControlCode As Byte) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_SystemDriver"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("UserControlService")
        inParams("ControlCode") = ControlCode

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("UserControlService", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Create a new service managed by the system driver.
    ''' </summary>
    ''' <param name="Name">
    ''' Name of the service to install.
    ''' The maximum string length is 256 characters.
    ''' The Service Control Manager database preserves the case of the characters, but service name comparisons are always case-insensitive.
    ''' Forward-slashes (/) and double back-slashes (\) are invalid service name characters.
    ''' </param>
    ''' <param name="DisplayName">
    ''' Display name of the service.
    ''' This string has a maximum length of 256 characters.
    ''' The name is case-preserved in the Service Control Manager.
    ''' DisplayName comparisons are always case-insensitive. 
    ''' Constraints: Accepts the same value as the Name parameter.
    ''' Example: "Atdisk".
    ''' </param>
    ''' <param name="PathName">
    ''' Fully qualified path to the executable file that implements the service.
    ''' Example: "\SystemRoot\System32\drivers\afd.sys".
    ''' </param>
    ''' <param name="ServiceType">Type of services provided to the processes that call them.</param>
    ''' <param name="ErrorControl">
    ''' Severity of the error if the Create method fails to start.
    ''' This value indicates the action taken by the startup program if failure occurs.
    ''' All errors are logged by the system.
    ''' </param>
    ''' <param name="StartMode">Start mode of the Windows base service.</param>
    ''' <param name="DesktopInteract">If true, the service can create or communicate with the windows on the desktop. </param>
    ''' <param name="StartName">
    ''' Account name under which the service runs.
    ''' Depending on the service type, the account name may be in the form of DomainName\Username.
    ''' The service process is logged using one of these two forms when it runs.
    ''' If the account belongs to the built-in domain, .\Username can be specified.
    ''' If NULL is specified, the service is logged on as the LocalSystem account.
    ''' For a kernel or system-level drivers, StartName contains the driver object name (that is, \FileSystem\Rdr or \Driver\Xns) that the input and output (I/O) system uses to load the device driver.
    ''' If NULL is specified, the driver runs with a default object name created by the I/O system based on the service name.
    ''' Example: DWDOM\Admin</param>
    ''' Windows XP:  You can use User Principal Name (UPN) format (Username@DomainName) to specify the StartName.
    ''' <param name="StartPassword">
    ''' Password to the account name specified by the StartName parameter.
    ''' Specify NULL if you are not changing the password.
    ''' Specify an empty string if the service has no password.
    ''' </param>
    ''' <param name="LoadOrderGroup">
    ''' Group name associated with the new service.
    ''' Load order groups are contained in the registry and determine the sequence in which services are loaded into the operating system.
    ''' If the pointer is NULL or if it points to an empty string, the service does not belong to a group.
    ''' Dependencies between groups should be listed in the LoadOrderGroupDependencies parameter.
    ''' Services in the load-ordering group list are started first, followed by services in groups not in the load-ordering group list, followed by services that do not belong to a group.
    ''' The registry has a list of load ordering groups located at: 
    ''' HKEY_LOCAL_MACHINE\System\CurrentControlSet\Control\ServiceGroupOrder
    ''' </param>
    ''' <param name="LoadOrderGroupDependencies">
    ''' Array of load-ordering groups that must start before this service.
    ''' Each item in the array is delimited by NULL and the list is terminated by two NULL values.
    ''' In Visual Basic or script you can pass a vbArray.
    ''' If the pointer is NULL or if it points to an empty string, the service has no dependencies.
    ''' Group names must be prefixed by the SC_GROUP_IDENTIFIER (defined in the Winsvc.h file) character to differentiate it from a service name, because services and service groups share the same namespace.
    ''' Dependency on a group means that this service can run if at least one member of the group is running after an attempt to start all of the members of the group.
    ''' </param>
    ''' <param name="ServiceDependencies">
    ''' An array that contains the names of services that must start before this service starts.
    ''' Each item in the array is delimited by NULL and the list is terminated by two NULL values.
    ''' In Visual Basic or script you can pass a vbArray.
    ''' If the pointer is NULL, or if it points to an empty string, the service has no dependencies.
    ''' Dependency on a service means that this service can only run if the service it depends on is running.
    ''' </param>
    ''' <returns></returns>
    ''' <remarks>
    ''' The Win32_LoadOrderGroup parameter represents a grouping of system services defining execution dependencies.
    ''' The services must be initiated in the order specified by the Load Order Group, as the services are dependent on each other.
    ''' These dependent services require the presence of the antecedent services to function correctly. 
    ''' </remarks>
    Public Function Create( _
          ByVal Name As String, _
          ByVal DisplayName As String, _
          ByVal PathName As String, _
          ByVal ServiceType As Enums.ServiceType, _
          ByVal ErrorControl As Enums.ErrorControl, _
          ByVal StartMode As Enums.StartMode, _
          ByVal DesktopInteract As String, _
          ByVal StartName As String, _
          ByVal StartPassword As String, _
          ByVal LoadOrderGroup As String, _
          ByVal LoadOrderGroupDependencies As String(), _
          ByVal ServiceDependencies As String() _
          ) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_SystemDriver"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("Create")
        inParams("Name") = Name
        inParams("DisplayName") = DisplayName
        inParams("PathName") = PathName
        inParams("ServiceType") = ServiceType
        inParams("ErrorControl") = ErrorControl
        inParams("StartMode") = StartModeString(StartMode)
        inParams("DesktopInteract") = DesktopInteract
        inParams("StartName") = StartName
        inParams("StartPassword") = StartPassword
        inParams("LoadOrderGroup") = LoadOrderGroup
        inParams("LoadOrderGroupDependencies") = LoadOrderGroupDependencies
        inParams("ServiceDependencies") = ServiceDependencies

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("Create", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Modify the service.
    ''' </summary>
    ''' <param name="DisplayName">
    ''' Display name of the service.
    ''' This string has a maximum length of 256 characters.
    ''' The name is case-preserved in the Service Control Manager.
    ''' DisplayName comparisons are always case-insensitive. 
    ''' Constraints: Accepts the same value as the Name parameter.
    ''' Example: "Atdisk".
    ''' </param>
    ''' <param name="PathName">
    ''' Fully qualified path to the executable file that implements the service.
    ''' Example: "\SystemRoot\System32\drivers\afd.sys".
    ''' </param>
    ''' <param name="ServiceType">Type of services provided to the processes that call them.</param>
    ''' <param name="ErrorControl">
    ''' Severity of the error if the Create method fails to start.
    ''' This value indicates the action taken by the startup program if failure occurs.
    ''' All errors are logged by the system.
    ''' </param>
    ''' <param name="StartMode">Start mode of the Windows base service.</param>
    ''' <param name="DesktopInteract">If true, the service can create or communicate with the windows on the desktop. </param>
    ''' <param name="StartName">
    ''' Account name under which the service runs.
    ''' Depending on the service type, the account name may be in the form of DomainName\Username.
    ''' The service process is logged using one of these two forms when it runs.
    ''' If the account belongs to the built-in domain, .\Username can be specified.
    ''' If NULL is specified, the service is logged on as the LocalSystem account.
    ''' For a kernel or system-level drivers, StartName contains the driver object name (that is, \FileSystem\Rdr or \Driver\Xns) that the input and output (I/O) system uses to load the device driver.
    ''' If NULL is specified, the driver runs with a default object name created by the I/O system based on the service name.
    ''' Example: DWDOM\Admin</param>
    ''' Windows XP:  You can use User Principal Name (UPN) format (Username@DomainName) to specify the StartName.
    ''' <param name="StartPassword">
    ''' Password to the account name specified by the StartName parameter.
    ''' Specify NULL if you are not changing the password.
    ''' Specify an empty string if the service has no password.
    ''' </param>
    ''' <param name="LoadOrderGroup">
    ''' Group name associated with the new service.
    ''' Load order groups are contained in the registry and determine the sequence in which services are loaded into the operating system.
    ''' If the pointer is NULL or if it points to an empty string, the service does not belong to a group.
    ''' Dependencies between groups should be listed in the LoadOrderGroupDependencies parameter.
    ''' Services in the load-ordering group list are started first, followed by services in groups not in the load-ordering group list, followed by services that do not belong to a group.
    ''' The registry has a list of load ordering groups located at: 
    ''' HKEY_LOCAL_MACHINE\System\CurrentControlSet\Control\ServiceGroupOrder
    ''' </param>
    ''' <param name="LoadOrderGroupDependencies">
    ''' Array of load-ordering groups that must start before this service.
    ''' Each item in the array is delimited by NULL and the list is terminated by two NULL values.
    ''' In Visual Basic or script you can pass a vbArray.
    ''' If the pointer is NULL or if it points to an empty string, the service has no dependencies.
    ''' Group names must be prefixed by the SC_GROUP_IDENTIFIER (defined in the Winsvc.h file) character to differentiate it from a service name, because services and service groups share the same namespace.
    ''' Dependency on a group means that this service can run if at least one member of the group is running after an attempt to start all of the members of the group.
    ''' </param>
    ''' <param name="ServiceDependencies">
    ''' An array that contains the names of services that must start before this service starts.
    ''' Each item in the array is delimited by NULL and the list is terminated by two NULL values.
    ''' In Visual Basic or script you can pass a vbArray.
    ''' If the pointer is NULL, or if it points to an empty string, the service has no dependencies.
    ''' Dependency on a service means that this service can only run if the service it depends on is running.
    ''' </param>
    ''' <returns></returns>
    ''' <remarks>
    ''' The Win32_LoadOrderGroup parameter represents a grouping of system services defining execution dependencies.
    ''' The services must be initiated in the order specified by the Load Order Group, as the services are dependent on each other.
    ''' These dependent services require the presence of the antecedent services to function correctly. 
    ''' </remarks>
    Public Function Change( _
          ByVal DisplayName As String, _
          ByVal PathName As String, _
          ByVal ServiceType As Enums.ServiceType, _
          ByVal ErrorControl As Enums.ErrorControl, _
          ByVal StartMode As Enums.StartMode, _
          ByVal DesktopInteract As String, _
          ByVal StartName As String, _
          ByVal StartPassword As String, _
          ByVal LoadOrderGroup As String, _
          ByVal LoadOrderGroupDependencies As String(), _
          ByVal ServiceDependencies As String() _
          ) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_SystemDriver"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("Change")
        inParams("DisplayName") = DisplayName
        inParams("PathName") = PathName
        inParams("ServiceType") = ServiceType
        inParams("ErrorControl") = ErrorControl
        inParams("StartMode") = StartModeString(StartMode)
        inParams("DesktopInteract") = DesktopInteract
        inParams("StartName") = StartName
        inParams("StartPassword") = StartPassword
        inParams("LoadOrderGroup") = LoadOrderGroup
        inParams("LoadOrderGroupDependencies") = LoadOrderGroupDependencies
        inParams("ServiceDependencies") = ServiceDependencies

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("Change", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Modify the start mode of the service.
    ''' </summary>
    ''' <param name="StartMode">Start mode of the Windows base service.</param>
    ''' <returns></returns>
    ''' <remarks>
    ''' The Win32_LoadOrderGroup parameter represents a grouping of system services defining execution dependencies.
    ''' The services must be initiated in the order specified by the Load Order Group, as the services are dependent on each other.
    ''' These dependent services require the presence of the antecedent services to function correctly. 
    ''' </remarks>
    Public Function ChangeStartMode(ByVal StartMode As Enums.StartMode) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_SystemDriver"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("ChangeStartMode")
        inParams("StartMode") = StartModeString(StartMode)

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("ChangeStartMode", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Delete the service.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Delete() As InvokeError

        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("Delete")
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Convert Start Mode enum to string
    ''' </summary>
    ''' <param name="StartMode">Start mode.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function StartModeString(ByVal StartMode As Enums.StartMode) As String

        Select Case StartMode
            Case Enums.StartMode.Automatic
                Return "Automatic"
            Case Enums.StartMode.Boot
                Return "Boot"
            Case Enums.StartMode.Disabled
                Return "Disabled"
            Case Enums.StartMode.Manual
                Return "Manual"
            Case Enums.StartMode.System
                Return "System"
            Case Else
                Return ""
        End Select

    End Function

    ''' <summary>
    ''' Error messages for the methods of this class.
    ''' </summary>
    ''' <param name="Number">Error number.</param>
    ''' <returns>A string containing the error message.</returns>
    ''' <remarks></remarks>
    Protected Overrides Function ErrorMessage(ByVal Number As UInteger) As String
        Select Case Number
            Case 0
                Return "The request was accepted."
            Case 1
                Return "The request is not supported."
            Case 2
                Return "The user did not have the necessary access."
            Case 3
                Return "The service cannot be stopped because other services that are running are dependent on it."
            Case 4
                Return "The requested control code is not valid, or it is unacceptable to the service."
            Case 5
                Return "The requested control code cannot be sent to the service because the state of the service (Win32_BaseService State property) is equal to 0, 1, or 2."
            Case 6
                Return "The service has not been started."
            Case 7
                Return "The service did not respond to the start request in a timely fashion."
            Case 8
                Return "An unknown failure occurred when starting the service."
            Case 9
                Return "The directory path to the service executable file was not found."
            Case 10
                Return "The service is already running."
            Case 11
                Return "The database to add a new service is locked."
            Case 12
                Return "A dependency for which this service relies on has been removed from the system."
            Case 13
                Return "The service failed to find the service needed from a dependent service."
            Case 14
                Return "The service has been disabled from the system."
            Case 15
                Return "The service does not have the correct authentication to run on the system."
            Case 16
                Return "This service is being removed from the system."
            Case 17
                Return "There is no execution thread for the service."
            Case 18
                Return "There are circular dependencies when starting the service."
            Case 19
                Return "There is a service running under the same name."
            Case 20
                Return "There are invalid characters in the name of the service."
            Case 21
                Return "Invalid parameters have been passed to the service."
            Case 22
                Return "The account which this service is to run under is either invalid or lacks the permissions to run the service."
            Case 23
                Return "The service exists in the database of services available from the system."
            Case 24
                Return "The service is currently paused in the system."
            Case Else
                Return "Unknown error"
        End Select
    End Function

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.Win32_BaseService"></see>.
''' </summary>
''' <remarks></remarks> 
Public MustInherit Class Win32_BaseServices
    Inherits CIM_Services

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
    ''' Type of services provided to the processes that call them.
    ''' </summary>
    ''' <remarks></remarks>
    <Flags()> _
    Public Enum ServiceType As Byte

        ''' <summary>
        ''' Kernel Driver.
        ''' </summary>
        ''' <remarks></remarks>
        KernelDriver = 1

        ''' <summary>
        ''' File System Driver.
        ''' </summary>
        ''' <remarks></remarks>
        FileSystemDriver = 2

        ''' <summary>
        ''' Adapter.
        ''' </summary>
        ''' <remarks></remarks>
        Adapter = 4

        ''' <summary>
        ''' Recognizer Driver.
        ''' </summary>
        ''' <remarks></remarks>
        RecognizerDriver = 8

        ''' <summary>
        ''' Own Process.
        ''' </summary>
        ''' <remarks></remarks>
        OwnProcess = 16

        ''' <summary>
        ''' Share Process.
        ''' </summary>
        ''' <remarks></remarks>
        ShareProcess = 32

        ''' <summary>
        ''' Interactive Process.
        ''' </summary>
        ''' <remarks></remarks>
        InteractiveProcess = 255

    End Enum

    ''' <summary>
    ''' Severity of the error if the Create method fails to start.
    ''' </summary>
    ''' <remarks>
    ''' This value indicates the action taken by the startup program if failure occurs.
    ''' All errors are logged by the system.
    ''' </remarks>
    Public Enum ErrorControl As Byte

        ''' <summary>
        ''' Ignore.
        ''' </summary>
        ''' <remarks>User is not notified.</remarks>
        Ignore = 0

        ''' <summary>
        ''' Normal.
        ''' </summary>
        ''' <remarks>User is notified.</remarks>
        Normal = 1

        ''' <summary>
        ''' Severe.
        ''' </summary>
        ''' <remarks>System is restarted with the last-known-good configuration.</remarks>
        Severe = 2

        ''' <summary>
        ''' Critical.
        ''' </summary>
        ''' <remarks>System attempts to start with a good configuration.</remarks>
        Critical = 3

    End Enum

    ''' <summary>
    ''' Start mode of the Windows base service.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum StartMode

        ''' <summary>
        ''' Device driver started by the operating system loader. This value is valid only for driver services.
        ''' </summary>
        ''' <remarks></remarks>
        Boot

        ''' <summary>
        ''' Device driver started by the operating system initialization process. This value is valid only for driver services.
        ''' </summary>
        ''' <remarks></remarks>
        System

        ''' <summary>
        ''' Service to be started automatically by the Service Control Manager during system startup.
        ''' </summary>
        ''' <remarks></remarks>
        Automatic

        ''' <summary>
        ''' Service to be started by the Service Control Manager when a process calls the StartService method.
        ''' </summary>
        ''' <remarks></remarks>
        Manual

        ''' <summary>
        ''' Service that can no longer be started.
        ''' </summary>
        ''' <remarks></remarks>
        Disabled

    End Enum

End Namespace
