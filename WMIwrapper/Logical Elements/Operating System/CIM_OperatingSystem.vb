Imports System.Management

''' <summary>
''' Represents a computer operating system, which is comprised of software and firmware that make a computer system's hardware usable.
''' </summary>
''' <remarks>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa387937.aspx">MSDN.</a>
''' </remarks>
Public MustInherit Class CIM_OperatingSystem
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
    ''' Name of the class or subclass used in the creation of an instance.
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
    ''' Scoping computer system's creation class name.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property CSCreationClassName() As String
        Get
            Return GetStringProperty("CSCreationClassName")
        End Get
    End Property

    ''' <summary>
    ''' Scoping computer system's name.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property CSName() As String
        Get
            Return GetStringProperty("CSName")
        End Get
    End Property

    ''' <summary>
    ''' Number of minutes the operating system is offset from Greenwich Mean Time (GMT).
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>The number is positive, negative, or zero.</remarks>
    Public ReadOnly Property CurrentTimeZone() As Int16
        Get
            Return GetInt16Property("CurrentTimeZone")
        End Get
    End Property

    ''' <summary>
    ''' If True, the operating system is distributed across several computer system nodes, which should be grouped as a cluster.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Distributed() As Boolean
        Get
            Return GetBooleanProperty("Distributed")
        End Get
    End Property

    ''' <summary>
    ''' Number of kilobytes of physical memory currently unused and available.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property FreePhysicalMemory() As UInt64
        Get
            Return GetUint64Property("FreePhysicalMemory")
        End Get
    End Property

    ''' <summary>
    ''' Number of kilobytes that can be mapped into the operating system's paging files without causing other pages to be swapped out.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>A value of 0 indicates that there are no paging files.</remarks>
    Public ReadOnly Property FreeSpaceInPagingFiles() As UInt64
        Get
            Return GetUint64Property("FreeSpaceInPagingFiles")
        End Get
    End Property

    ''' <summary>
    ''' Number of kilobytes of virtual memory currently unused and available.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>For example, this can be calculated by adding the amount of free RAM to the amount of free paging space (that is, adding the <see cref="P:WMIwrapper.CIM_OperatingSystem.FreePhysicalMemory"></see> and <see cref="P:WMIwrapper.CIM_OperatingSystem.FreeSpaceInPagingFiles"></see> properties).</remarks>
    Public ReadOnly Property FreeVirtualMemory() As UInt64
        Get
            Return GetUint64Property("FreeVirtualMemory")
        End Get
    End Property

    ''' <summary>
    ''' Time when the operating system was last booted.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property LastBootUpTime() As DateTime
        Get
            Return GetDateTimeProperty("LastBootUpTime")
        End Get
    End Property

    ''' <summary>
    ''' Operating system's notion of the local date and time of day.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property LocalDateTime() As DateTime
        Get
            Return GetDateTimeProperty("LocalDateTime")
        End Get
    End Property

    ''' <summary>
    ''' Maximum number of process contexts the operating system can support.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' If there is no fixed maximum, the value should be 0 (zero).
    ''' On systems that have a fixed maximum, this object can help diagnose failures that occur when the maximum is reached.
    ''' If unknown, enter -1.
    ''' </remarks>
    Public ReadOnly Property MaxNumberOfProcesses() As UInt32
        Get
            Return GetUint32Property("MaxNumberOfProcesses")
        End Get
    End Property

    ''' <summary>
    ''' Maximum number of kilobytes of memory that can be allocated to a process.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' For operating systems with no virtual memory, this value is typically equal to the total amount of physical memory, minus memory used by the BIOS and OS.
    ''' For some operating systems, this value can be infinity, in which case 0 should be entered.
    ''' In other cases, this value can be a constant, for example, 2 GB or 4 GB.
    ''' </remarks>
    Public ReadOnly Property MaxProcessMemorySize() As UInt64
        Get
            Return GetUint64Property("MaxProcessMemorySize")
        End Get
    End Property

    ''' <summary>
    ''' Number of user licenses for the operating system.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>If unlimited, enter 0, if unknown, enter -1.</remarks>
    Public ReadOnly Property NumberOfLicensedUsers() As UInt32
        Get
            Return GetUint32Property("NumberOfLicensedUsers")
        End Get
    End Property

    ''' <summary>
    ''' Number of process contexts currently loaded or running on the operating system.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property NumberOfProcesses() As UInt32
        Get
            Return GetUint32Property("NumberOfProcesses")
        End Get
    End Property

    ''' <summary>
    ''' Number of user sessions for which the operating system is currently storing state information.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property NumberOfUsers() As UInt32
        Get
            Return GetUint32Property("NumberOfUsers")
        End Get
    End Property

    ''' <summary>
    ''' Type of operating system.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property OSType() As String
        Get
            Dim _OSType As UInt16 = GetUint16Property("NumberOfUsers")
            Select Case _OSType
                Case 0
                    Return "Unknown"
                Case 1
                    Return "Other"
                Case 2
                    Return "Mac OS"
                Case 3
                    Return "ATT UNIX"
                Case 4
                    Return "DGUX"
                Case 5
                    Return "DECNT"
                Case 6
                    Return "Digital UNIX"
                Case 7
                    Return "Open VMS"
                Case 8
                    Return "HP-UX"
                Case 9
                    Return "AIX"
                Case 10
                    Return "MVS"
                Case 11
                    Return "OS400"
                Case 12
                    Return "OS/2"
                Case 13
                    Return "Java VM"
                Case 14
                    Return "MSDOS"
                Case 15
                    Return "Windows 3.x"
                Case 16
                    Return "Windows 95"
                Case 17
                    Return "Windows 98"
                Case 18
                    Return "Windows NT"
                Case 19
                    Return "Windows CE"
                Case 20
                    Return "NCR 3000"
                Case 21
                    Return "NetWare"
                Case 22
                    Return "OSF"
                Case 23
                    Return "DC/OS"
                Case 24
                    Return "Reliant UNIX"
                Case 25
                    Return "SCO UnixWare"
                Case 26
                    Return "SCO OpenServer"
                Case 27
                    Return "Sequent"
                Case 28
                    Return "IRIX"
                Case 29
                    Return "Solaris"
                Case 30
                    Return "SunOS"
                Case 31
                    Return "U6000"
                Case 32
                    Return "A Series"
                Case 33
                    Return "Tandem NSK"
                Case 34
                    Return "Tandem NT"
                Case 35
                    Return "BS2000/OSD"
                Case 36
                    Return "Linux"
                Case 37
                    Return "Lynx"
                Case 38
                    Return "Xenix"
                Case 39
                    Return "VM/ESA"
                Case 40
                    Return "Interactive UNIX"
                Case 41
                    Return "BSD UNIX"
                Case 42
                    Return "FreeBSD"
                Case 43
                    Return "NetBSD"
                Case 44
                    Return "GNU Hurd"
                Case 45
                    Return "Mac OS 9"
                Case 46
                    Return "Mach Kernel"
                Case 47
                    Return "Inferno"
                Case 48
                    Return "QNX"
                Case 49
                    Return "EPOC"
                Case 50
                    Return "IxWorks"
                Case 51
                    Return "VxWorks"
                Case 52
                    Return "MiNT"
                Case 53
                    Return "BeOS"
                Case 54
                    Return "HP MPE"
                Case 55
                    Return "NEXTSTEP"
                Case 56
                    Return "Palm OS"
                Case 57
                    Return "Rhapsody"
                Case 58
                    Return "Windows 2000"
                Case 59
                    Return "Dedicated"
                Case 60
                    Return "OS/390"
                Case 61
                    Return "VSE"
                Case 62
                    Return "TPF"
                Case Else
                    Return "Other"
            End Select
        End Get
    End Property

    ''' <summary>
    ''' Describes the manufacturer and operating system type when the OSType property is set to 1 ("Other").
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' The format of the string inserted in OtherTypeDescription should be similar to the Values strings defined for <see cref="P:WMIwrapper.CIM_OperatingSystem.OSType"></see>.
    ''' This property should be set to null when <see cref="P:WMIwrapper.CIM_OperatingSystem.OSType"></see> is a value other than 1 (one).
    ''' </remarks>
    Public ReadOnly Property OtherTypeDescription() As String
        Get
            Return GetStringProperty("OtherTypeDescription")
        End Get
    End Property

    ''' <summary>
    ''' Number of kilobytes that can be stored in the operating system's paging files.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' This number does not represent the actual physical size of the paging file on disk.
    ''' A value of 0 (zero)indicates that there are no paging files.
    ''' </remarks>
    Public ReadOnly Property SizeStoredInPagingFiles() As UInt64
        Get
            Return GetUint64Property("SizeStoredInPagingFiles")
        End Get
    End Property

    ''' <summary>
    ''' Total swap space, in kilobytes.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' This value can be null (unspecified) if swap space is not distinguished from page files.
    ''' However, some operating systems distinguish these concepts. For example, entire processes can be "swapped out" in UNIX when the free page list falls and remains below a specified amount.
    ''' </remarks>
    Public ReadOnly Property TotalSwapSpaceSize() As UInt64
        Get
            Return GetUint64Property("TotalSwapSpaceSize")
        End Get
    End Property

    ''' <summary>
    ''' Number of kilobytes of virtual memory.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' For example, calculate this by adding the amount of total RAM to the amount of paging space (that is, add the amount of memory in or aggregated by the computer system to the <see cref="P:WMIwrapper.CIM_OperatingSystem.SizeStoredInPagingFiles"></see> property.
    ''' </remarks>
    Public ReadOnly Property TotalVirtualMemorySize() As UInt64
        Get
            Return GetUint64Property("TotalVirtualMemorySize")
        End Get
    End Property

    ''' <summary>
    ''' Total amount of physical memory, in kilobytes, available to the operating system.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' This value does not necessarily indicate the true amount of physical memory, but what is reported to the operating system as available to it.</remarks>
    Public ReadOnly Property TotalVisibleMemorySize() As UInt64
        Get
            Return GetUint64Property("TotalVisibleMemorySize")
        End Get
    End Property

    ''' <summary>
    ''' Version of the operation.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' The version of the operation should be in one of the following forms:
    ''' <list type="bullet">
    ''' <item><description>&lt;major&gt;.&lt;minor&gt;.&lt;revision&gt;</description></item>
    ''' <item><description>&lt;major&gt;.&lt;minor&gt;&lt;letter&gt;&lt;revision&gt;</description></item>
    ''' </list>
    ''' </remarks>
    Public ReadOnly Property Version() As String
        Get
            Return GetStringProperty("Version")
        End Get
    End Property

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.CIM_OperatingSystem"></see>.
''' </summary>
''' <remarks></remarks>
Public MustInherit Class CIM_OperatingSystems
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

End Class
