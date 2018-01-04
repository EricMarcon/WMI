Imports System.Management

''' <summary>
''' Represents a Windows-based operating system installed on a computer.
''' </summary>
''' <remarks>
''' Any operating system that can be installed on a computer that can run a Windows-based operating system is a descendent or member of this class.
''' Win32_OperatingSystem is a singleton class.
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa394239.aspx">MSDN.</a>
''' Windows Server 2003, Windows XP, Windows 2000, and Windows NT 4.0:
''' If a computer has multiple operating systems installed, this class only returns an instance for the currently active operating system.
''' </remarks>
Public Class Win32_OperatingSystem
    Inherits CIM_OperatingSystem

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
    ''' Name of the disk drive from which the Windows operating system starts.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Example: "\\Device\Harddisk0"</remarks>
    Public ReadOnly Property BootDevice() As String
        Get
            Return GetStringProperty("BootDevice")
        End Get
    End Property

    ''' <summary>
    ''' Build number of an operating system.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>It can be used for more precise version information than product release version numbers.</remarks>
    Public ReadOnly Property BuildNumber() As String
        Get
            Return GetStringProperty("BuildNumber")
        End Get
    End Property

    ''' <summary>
    ''' Type of build used for an operating system.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Examples: "retail build", "checked build"</remarks>
    Public ReadOnly Property BuildType() As String
        Get
            Return GetStringProperty("BuildType")
        End Get
    End Property

    ''' <summary>
    ''' Code page value an operating system uses.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' A code page contains a character table that an operating system uses to translate strings for different languages.
    ''' The American National Standards Institute (ANSI) lists values that represent defined code pages.
    ''' If an operating system does not use an ANSI code page, this member is set to 0 (zero).
    ''' The CodeSet string can use a maximum of six characters to define the code page value.
    ''' </remarks>
    Public ReadOnly Property CodeSet() As String
        Get
            Return GetStringProperty("CodeSet")
        End Get
    End Property

    ''' <summary>
    ''' Code for the country/region that an operating system uses.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' Values are based on international phone dialing prefixes—also referred to as IBM country/region codes.
    ''' This property can use a maximum of six characters to define the country/region code value.
    ''' </remarks>
    Public ReadOnly Property CountryCode() As String
        Get
            Return GetStringProperty("CountryCode")
        End Get
    End Property

    ''' <summary>
    ''' Latest service pack installed on a computer.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' If no service pack is installed, the string is NULL.
    ''' For computers running on Windows 95, this property contains a null-terminated string that provides more information about the operating system.
    ''' </remarks>
    Public ReadOnly Property CSDVersion() As String
        Get
            Return GetStringProperty("CountryCode")
        End Get
    End Property

    ''' <summary>
    ''' When the data execution prevention hardware feature is available, this property indicates that the feature is set to work for 32-bit applications if True.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' <para>On 64-bit computers, the data execution prevention feature is configured in the Boot Configuration Data (BCD) store and the properties in Win32_OperatingSystem are set accordingly.</para>
    ''' <para>Windows Server 2003, Windows 2000, Windows NT 4.0, Windows XP, and Windows Me/98/95:  This property is not available.</para>
    ''' </remarks>
    Public ReadOnly Property DataExecutionPrevention_32BitApplications() As Boolean
        Get
            Return GetBooleanProperty("DataExecutionPrevention_32BitApplications")
        End Get
    End Property

    ''' <summary>
    ''' Data execution prevention is a hardware feature to prevent buffer overrun attacks by stopping the execution of code on data-type memory pages.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' <para>
    ''' If True, then this feature is available.
    ''' On 64-bit computers, the data execution prevention feature is configured in the BCD store and the properties in <see cref="T:WMIwrapper.Win32_OperatingSystem"></see> are set accordingly.
    ''' </para>
    ''' <para>Windows Server 2003, Windows 2000, Windows NT 4.0, Windows XP, and Windows Me/98/95:  This property is not available.</para>
    ''' </remarks>
    Public ReadOnly Property DataExecutionPrevention_Available() As Boolean
        Get
            Return GetBooleanProperty("DataExecutionPrevention_Available")
        End Get
    End Property

    ''' <summary>
    ''' When the data execution prevention hardware feature is available, this property indicates that the feature is set to work for drivers if True.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' <para>
    ''' If True, then this feature is available.
    ''' On 64-bit computers, the data execution prevention feature is configured in the BCD store and the properties in <see cref="T:WMIwrapper.Win32_OperatingSystem"></see> are set accordingly.
    ''' </para>
    ''' <para>Windows Server 2003, Windows 2000, Windows NT 4.0, Windows XP, and Windows Me/98/95:  This property is not available.</para>
    ''' </remarks>
    Public ReadOnly Property DataExecutionPrevention_Drivers() As Boolean
        Get
            Return GetBooleanProperty("DataExecutionPrevention_Drivers")
        End Get
    End Property

    ''' <summary>
    ''' Indicates which Data Execution Prevention (DEP) setting is applied.
    ''' The DEP setting specifies the extent to which DEP applies to 32-bit applications on the system.
    ''' DEP is always applied to the Windows kernel.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Windows Server 2003, Windows 2000, Windows NT 4.0, Windows XP, and Windows Me/98/95:  This property is not available.</remarks>
    Public ReadOnly Property DataExecutionPrevention_SupportPolicy() As Enums.DataExecutionPrevention_SupportPolicy
        Get
            Dim obj As Object = GetPropertyObject("DataExecutionPrevention_SupportPolicy")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.DataExecutionPrevention_SupportPolicy)
            End If
        End Get
    End Property

    ''' <summary>
    ''' Operating system is a checked (debug) build.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' If True, the debugging version of User.exe is installed.
    ''' Checked builds provide error checking, argument verification, and system debugging code.
    ''' Additional code in a checked binary generates a kernel debugger error message and breaks into the debugger.
    ''' This helps immediately determine the cause and location of the error.
    ''' Performance may be affected in a checked build due to the additional code that is executed.
    ''' </remarks>
    Public ReadOnly Property Debug() As Boolean
        Get
            Return GetBooleanProperty("Debug")
        End Get
    End Property

    ''' <summary>
    ''' Encryption level for secure transactions: 40-bit, 128-bit, or n-bit.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Windows Server 2003 and Windows XP only.</remarks>
    Public ReadOnly Property EncryptionLevel() As UInt32
        Get
            Return GetUint32Property("EncryptionLevel")
        End Get
    End Property

    ''' <summary>
    ''' Increase in priority is given to the foreground application. 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' <para>
    ''' Application boost is implemented by giving an application more execution time slices (quantum lengths).
    ''' </para>
    ''' <para>
    ''' Windows Me/98/95:  Application boost is not available.</para>
    ''' <para>
    ''' A ForegroundApplicationBoost value of 0 (zero) indicates the system boosts the quantum length by 6;
    ''' if 1, then 12; and if 2 then 18. The default value is 2.
    ''' </para>
    ''' </remarks>
    Public Property ForegroundApplicationBoost() As Byte
        Get
            Return GetByteProperty("ForegroundApplicationBoost")
        End Get
        Set(ByVal value As Byte)
            _ManagementObject.SetPropertyValue("ForegroundApplicationBoost", value)
        End Set
    End Property

    ''' <summary>
    ''' Indicates whether to optimize memory for applications or system performance.
    ''' </summary>
    ''' <value>0 : Optimize memory for applications, 1 : Optimize memory for system performance.</value>
    ''' <returns></returns>
    ''' <remarks>
    ''' <para>Beginning with Windows Vista, this property is obsolete and not supported.</para>
    ''' <para>Windows Server 2003 and Windows XP:  This property is supported.</para>
    ''' <para>Windows 2000 and Windows NT 4.0 SP4 and later:  This property is not available.</para>
    ''' </remarks>
    Public ReadOnly Property LargeSystemCache() As UInt32
        Get
            Return GetUint32Property("LargeSystemCache")
        End Get
    End Property

    ''' <summary>
    ''' Language identifier used by the operating system.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' A language identifier is a standard international numeric abbreviation for a country/region.
    ''' Each language has a unique language identifier (LANGID), a 16-bit value that consists of a primary language identifier and a secondary language identifier.
    ''' </remarks>
    Public ReadOnly Property Locale() As String
        Get
            Return GetStringProperty("Locale")
        End Get
    End Property

    ''' <summary>
    ''' Name of the operating system manufacturer.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>For Windows-based systems, this value is "Microsoft Corporation".</remarks>
    Public ReadOnly Property Manufacturer() As String
        Get
            Return GetStringProperty("Manufacturer")
        End Get
    End Property

    ''' <summary>
    ''' Multilingual User Interface Pack (MUI Pack ) languages installed on the computer.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' For example, "en-us".
    ''' MUI Pack languages are resource files that can be installed on the English version of the operating system.
    ''' When an MUI Pack is installed, you can can change the user interface language to one of 33 supported languages.
    ''' </remarks>
    Public ReadOnly Property MUILanguages() As String()
        Get
            Return GetStringArrayProperty("MUILanguages")
        End Get
    End Property

    ''' <summary>
    ''' Stock Keeping Unit (SKU) number for the operating system.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property OperatingSystemSKU() As String
        Get
            Dim _OperatingSystemSKU As UInt32 = GetUint32Property("OperatingSystemSKU")
            Select Case _OperatingSystemSKU
                Case 0
                    Return "Undefined"
                Case 1
                    Return "Ultimate Edition"
                Case 2
                    Return "Home Basic Edition"
                Case 3
                    Return "Home Basic Premium Edition"
                Case 4
                    Return "Enterprise Edition"
                Case 5
                    Return "Home Basic N Edition"
                Case 6
                    Return "Business Edition"
                Case 7
                    Return "Standard Server Edition"
                Case 8
                    Return "Datacenter Server Edition"
                Case 9
                    Return "Small Business Server Edition"
                Case 10
                    Return "Enterprise Server Edition"
                Case 11
                    Return "Starter Edition"
                Case 12
                    Return "Datacenter Server Core Edition"
                Case 13
                    Return "Standard Server Core Edition"
                Case 14
                    Return "Enterprise Server Core Edition"
                Case 15
                    Return "Enterprise Server Edition for Itanium-Based Systems"
                Case 16
                    Return "Business N Edition"
                Case 17
                    Return "Web Server Edition"
                Case 18
                    Return "Cluster Server Edition"
                Case 19
                    Return "Home Server Edition"
                Case 20
                    Return "Storage Express Server Edition"
                Case 21
                    Return "Storage Standard Server Edition"
                Case 22
                    Return "Storage Workgroup Server Edition"
                Case 23
                    Return "Storage Enterprise Server Edition"
                Case 24
                    Return "Server For Small Business Edition"
                Case 25
                    Return "Small Business Server Premium Edition"
                Case Else
                    Return "Other"
            End Select
        End Get
    End Property

    ''' <summary>
    ''' Company name for the registered user of the operating system.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Organization() As String
        Get
            Return GetStringProperty("Organization")
        End Get
    End Property

    ''' <summary>
    ''' Architecture of the operating system, as opposed to the processor.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Windows Server 2003, Windows 2000, Windows NT 4.0, Windows XP, and Windows Me/98/95:  This property is not available.</remarks>
    Public ReadOnly Property OSArchitecture() As String
        Get
            Return GetStringProperty("OSArchitecture")
        End Get
    End Property

    ''' <summary>
    ''' Language version of the operating system installed.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property OSLanguage() As String
        Get
            Dim _OSLanguage As UInt32 = GetUint32Property("OSLanguage")
            Select Case _OSLanguage
                Case 1
                    Return "Arabic"
                Case 4
                    Return "Simplified Chinese – China "
                Case 9
                    Return "English"
                Case 1025
                    Return "Arabic – Saudi Arabia"
                Case 1026
                    Return "Bulgarian"
                Case 1027
                    Return "Catalan"
                Case 1028
                    Return "Traditional Chinese – Taiwan"
                Case 1029
                    Return "Czech"
                Case 1030
                    Return "Danish"
                Case 1031
                    Return "German – Germany"
                Case 1032
                    Return "Greek"
                Case 1033
                    Return "English – United States"
                Case 1034
                    Return "Spanish – Traditional Sort"
                Case 1035
                    Return "Finnish"
                Case 1036
                    Return "French – France"
                Case 1037
                    Return "Hebrew"
                Case 1038
                    Return "Hungarian"
                Case 1039
                    Return "Icelandic"
                Case 1040
                    Return "Italian – Italy"
                Case 1041
                    Return "Japanese"
                Case 1042
                    Return "Korean"
                Case 1043
                    Return "Dutch – Netherlands"
                Case 1044
                    Return "Norwegian – Bokmal"
                Case 1045
                    Return "Polish"
                Case 1046
                    Return "Portuguese – Brazil"
                Case 1047
                    Return "Rhaeto-Romanic"
                Case 1048
                    Return "Romanian"
                Case 1049
                    Return "Russian"
                Case 1050
                    Return "Croatian"
                Case 1051
                    Return "Slovak"
                Case 1052
                    Return "Albanian"
                Case 1053
                    Return "Swedish"
                Case 1054
                    Return "Thai"
                Case 1055
                    Return "Turkish"
                Case 1056
                    Return "Urdu"
                Case 1057
                    Return "Indonesian"
                Case 1058
                    Return "Ukrainian"
                Case 1059
                    Return "Belarusian"
                Case 1060
                    Return "Slovenian"
                Case 1061
                    Return "Estonian"
                Case 1062
                    Return "Latvian"
                Case 1063
                    Return "Lithuanian"
                Case 1065
                    Return "Persian"
                Case 1066
                    Return "Vietnamese"
                Case 1069
                    Return "Basque"
                Case 1070
                    Return "Serbian"
                Case 1071
                    Return "Macedonian (FYROM)"
                Case 1072
                    Return "Sutu"
                Case 1073
                    Return "Tsonga"
                Case 1074
                    Return "Tswana"
                Case 1076
                    Return "Xhosa"
                Case 1077
                    Return "Zulu"
                Case 1078
                    Return "Afrikaans"
                Case 1080
                    Return "Faeroese"
                Case 1081
                    Return "Hindi"
                Case 1082
                    Return "Maltese"
                Case 1084
                    Return "Gaelic"
                Case 1085
                    Return "Yiddish"
                Case 1086
                    Return "Malay – Malaysia"
                Case 2049
                    Return "Arabic – Iraq"
                Case 2052
                    Return "Chinese – PRC"
                Case 2055
                    Return "German – Switzerland"
                Case 2057
                    Return "English – United Kingdom"
                Case 2058
                    Return "Spanish – Mexico"
                Case 2060
                    Return "French – Belgium"
                Case 2064
                    Return "Italian – Switzerland"
                Case 2067
                    Return "Dutch – Belgium"
                Case 2068
                    Return "Norwegian – Nynorsk"
                Case 2070
                    Return "Portuguese – Portugal"
                Case 2072
                    Return "Romanian – Moldova"
                Case 2073
                    Return "Russian – Moldova"
                Case 2074
                    Return "Serbian – Latin"
                Case 2077
                    Return "Swedish – Finland"
                Case 3073
                    Return "Arabic – Egypt"
                Case 3076
                    Return "Chinese – Hong Kong SAR"
                Case 3079
                    Return "German – Austria"
                Case 3081
                    Return "English – Australia"
                Case 3082
                    Return "Spanish – International Sort"
                Case 3084
                    Return "French – Canada"
                Case 3098
                    Return "Serbian – Cyrillic"
                Case 4097
                    Return "Arabic – Libya"
                Case 4100
                    Return "Chinese – Singapore"
                Case 4103
                    Return "German – Luxembourg"
                Case 4105
                    Return "English – Canada"
                Case 4106
                    Return "Spanish – Guatemala"
                Case 4108
                    Return "French – Switzerland"
                Case 5121
                    Return "Arabic – Algeria"
                Case 5127
                    Return "German – Liechtenstein"
                Case 5129
                    Return "English – New Zealand"
                Case 5130
                    Return "Spanish – Costa Rica"
                Case 5132
                    Return "French – Luxembourg"
                Case 6145
                    Return "Arabic – Morocco"
                Case 6153
                    Return "English – Ireland"
                Case 6154
                    Return "Spanish – Panama"
                Case 7169
                    Return "Arabic – Tunisia"
                Case 7177
                    Return "English – South Africa"
                Case 7178
                    Return "Spanish – Dominican Republic"
                Case 8193
                    Return "Arabic – Oman"
                Case 8201
                    Return "English – Jamaica"
                Case 8202
                    Return "Spanish – Venezuela"
                Case 9217
                    Return "Arabic – Yemen"
                Case 9226
                    Return "Spanish – Colombia"
                Case 10241
                    Return "Arabic – Syria"
                Case 10249
                    Return "English – Belize"
                Case 10250
                    Return "Spanish – Peru"
                Case 11265
                    Return "Arabic – Jordan"
                Case 11273
                    Return "English – Trinidad"
                Case 11274
                    Return "Spanish – Argentina"
                Case 12289
                    Return "Arabic – Lebanon"
                Case 12298
                    Return "Spanish – Ecuador"
                Case 13313
                    Return "Arabic – Kuwait"
                Case 13322
                    Return "Spanish – Chile"
                Case 14337
                    Return "Arabic – U.A.E."
                Case 14346
                    Return "Spanish – Uruguay"
                Case 15361
                    Return "Arabic – Bahrain"
                Case 15370
                    Return "Spanish – Paraguay"
                Case 16385
                    Return "Arabic – Qatar"
                Case 16394
                    Return "Spanish – Bolivia"
                Case 17418
                    Return "Spanish – El Salvador"
                Case 18442
                    Return "Spanish – Honduras"
                Case 19466
                    Return "Spanish – Nicaragua"
                Case 20490
                    Return "Spanish – Puerto Rico"
                Case Else
                    Return "Other"
            End Select
        End Get
    End Property

    ''' <summary>
    ''' Installed and licensed system product additions to the operating system.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property OSProductSuite() As Enums.OSProductSuite
        Get
            Dim obj As Object = GetPropertyObject("OSProductSuite")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.OSProductSuite)
            End If
        End Get
    End Property

    ''' <summary>
    ''' If True, the physical address extensions (PAE) are enabled by the operating system running on Intel processors.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' PAE allows applications to address more than 4 GB of physical memory.
    ''' When PAE is enabled, the operating system uses three-level linear address translation rather than two-level.
    ''' Providing more physical memory to an application reduces the need to swap memory to the page file and increases performance.
    ''' To enable, PAE, use the "/PAE" switch in the Boot.ini file.
    ''' For more information about the Physical Address Extension feature, see <a href="http://go.microsoft.com/fwlink?LinkID=45912">http://go.microsoft.com/fwlink?LinkID=45912</a>.
    ''' </remarks>
    Public ReadOnly Property PAEEnabled() As Boolean
        Get
            Return GetBooleanProperty("PAEEnabled")
        End Get
    End Property

    ''' <summary>
    ''' Identification number for the Windows Plus! operating system enhancement software—if installed.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property PlusProductID() As String
        Get
            Return GetStringProperty("PlusProductID")
        End Get
    End Property

    ''' <summary>
    ''' Version number of the Windows Plus! operating system enhancement software—if installed.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property PlusVersionNumber() As String
        Get
            Return GetStringProperty("PlusVersionNumber")
        End Get
    End Property

    ''' <summary>
    ''' Specifies whether this is the primary operating system.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Primary() As Boolean
        Get
            Return GetBooleanProperty("Primary")
        End Get
    End Property

    ''' <summary>
    ''' Additional system information.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Windows 2000 and Windows NT 4.0 SP4 and later: This property is not available.</remarks>
    Public ReadOnly Property ProductType() As Enums.ProductType
        Get
            Dim obj As Object = GetPropertyObject("ProductType")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.ProductType)
            End If
        End Get
    End Property

    ''' <summary>
    ''' Number of clock ticks per quantum.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' A quantum is a unit of execution time that the scheduler is allowed to give to an application before switching to other applications.
    ''' When a thread runs one quantum, the kernel preempts it and moves it to the end of a queue for applications with equal priorities. The actual length, of a thread quantum, varies across different Windows platforms—Windows NT and Windows 2000 only.
    ''' </remarks>
    Public Property QuantumLength() As Enums.QuantumLength
        Get
            Dim obj As Object = GetPropertyObject("QuantumLength")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.QuantumLength)
            End If
        End Get
        Set(ByVal value As Enums.QuantumLength)
            _ManagementObject.SetPropertyValue("QuantumLength", value)
        End Set
    End Property

    ''' <summary>
    ''' Length type of quantums.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' Windows NT Workstation and Windows 2000 defaults to variable-length quantums where the foreground application has a longer quantum than the background applications.
    ''' Windows NT Server defaults to fixed-length quantums.
    ''' A quantum is a unit of execution time that the scheduler is allowed to give to an application before switching to another application.
    ''' When a thread runs one quantum, the kernel preempts it and moves it to the end of a queue for applications with equal priorities.
    ''' The actual length of a thread quantum varies across different Windows platforms.
    ''' For Windows NT and Windows 2000 only.
    ''' </remarks>
    Public Property QuantumType() As Enums.QuantumType
        Get
            Dim obj As Object = GetPropertyObject("QuantumType")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.QuantumType)
            End If
        End Get
        Set(ByVal value As Enums.QuantumType)
            _ManagementObject.SetPropertyValue("QuantumType", value)
        End Set
    End Property

    ''' <summary>
    ''' Name of the registered user of the operating system.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property RegisteredUser() As String
        Get
            Return GetStringProperty("RegisteredUser")
        End Get
    End Property

    ''' <summary>
    ''' Operating system product serial identification number.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Example: "10497-OEM-0031416-71674"</remarks>
    Public ReadOnly Property SerialNumber() As String
        Get
            Return GetStringProperty("SerialNumber")
        End Get
    End Property

    ''' <summary>
    ''' Major version number of the service pack installed on the computer system.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' <para>If no service pack has been installed, the value is 0 (zero).</para>
    ''' <para>Windows NT 4.0 and Windows Me/98/95:  This property is present but the value is NULL.</para>
    ''' </remarks>
    Public ReadOnly Property ServicePackMajorVersion() As UInt16
        Get
            Return GetUint16Property("ServicePackMajorVersion")
        End Get
    End Property

    ''' <summary>
    ''' Minor version number of the service pack installed on the computer system.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' <para>If no service pack has been installed, the value is 0 (zero).</para>
    ''' <para>Windows NT 4.0 and Windows Me/98/95:  This property is present but the value is NULL.</para>
    ''' </remarks>
    Public ReadOnly Property ServicePackMinorVersion() As UInt16
        Get
            Return GetUint16Property("ServicePackMinorVersion")
        End Get
    End Property

    ''' <summary>
    ''' Bit flags that identify the product suites available on the system.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Windows 2000 and Windows NT 4.0 SP4 and later: This property is not available.</remarks>
    Public ReadOnly Property SuiteMask() As Enums.OSProductSuite
        Get
            Dim obj As Object = GetPropertyObject("SuiteMask")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.OSProductSuite)
            End If
        End Get
    End Property

    ''' <summary>
    ''' Physical disk partition on which the operating system is installed.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property SystemDevice() As String
        Get
            Return GetStringProperty("SystemDevice")
        End Get
    End Property

    ''' <summary>
    ''' System directory of the operating system.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Example: "C:\WINDOWS\SYSTEM32"</remarks>
    Public ReadOnly Property SystemDirectory() As String
        Get
            Return GetStringProperty("SystemDirectory")
        End Get
    End Property

    ''' <summary>
    ''' Letter of the disk drive on which the operating system resides.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Example: "C:"</remarks>
    Public ReadOnly Property SystemDrive() As String
        Get
            Return GetStringProperty("SystemDrive")
        End Get
    End Property

    ''' <summary>
    ''' Windows directory of the operating system.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Example: "C:\WINDOWS"</remarks>
    Public ReadOnly Property WindowsDirectory() As String
        Get
            Return GetStringProperty("WindowsDirectory")
        End Get
    End Property

#End Region

#Region "Methods"

    ''' <summary>
    ''' Invoke Reboot method.
    ''' </summary>
    ''' <returns>Returns 0 (zero) to indicate success. Any other number indicates an error.</returns>
    ''' <remarks>The calling process must have the SE_SHUTDOWN_NAME privilege.</remarks>
    Public Function Reboot() As InvokeError
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("Reboot")
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))
    End Function

    ''' <summary>
    ''' Sets the current system time on the computer.
    ''' </summary>
    ''' <param name="LocalDatetime"></param>
    ''' <returns>Returns 0 (zero) to indicate success, and any other number to indicate an error.</returns>
    ''' <remarks>The calling process must have the SE_SYSTEMTIME_NAME privilege.</remarks>
    Public Function SetDateTime(ByVal LocalDatetime As DateTime) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_OperatingSystem"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("SetDateTime")
        inParams("LocalDatetime") = LocalDatetime

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("SetDateTime", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Unloads programs and DLLs until it is safe to turn off the computer.
    ''' </summary>
    ''' <returns>Returns zero (0) to indicate success. Any other number indicates an error.</returns>
    ''' <remarks>
    ''' All file buffers are flushed to the disk, and all of the running processes are stopped.
    ''' </remarks>
    Public Function Shutdown() As InvokeError

        ' On computer systems running Windows 2000 or Windows NT, the calling process must have the SE_SHUTDOWN_NAME privilege.
        _ManagementObject.Scope.Options.EnablePrivileges = True

        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("Shutdown")
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Provides the full set of shutdown options supported by Win32 operating systems.
    ''' </summary>
    ''' <param name="Flags">
    ''' Bitmapped set of flags to shut the computer down.
    ''' To force a command, add the Force flag (4) to the command value.
    ''' Using Force in conjunction with Shutdown or Reboot on a remote computer immediately shuts down everything
    ''' (including WMI, COM, and so on), or reboots the remote computer.
    ''' This results in an indeterminate return value.
    ''' </param>
    ''' <param name="Reserved">A means to extend Win32Shutdown. Currently, the Reserved parameter is ignored.</param>
    ''' <returns></returns>
    ''' <remarks>The calling process must have the SE_SHUTDOWN_NAME privilege.</remarks>
    Public Function Win32Shutdown(ByVal Flags As Enums.Flags, Optional ByVal Reserved As Int32 = 0) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_OperatingSystem"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("Win32Shutdown")
        inParams("Flags") = Flags
        inParams("Reserved") = Reserved

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("Win32Shutdown")
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Provides the same set of shutdown options supported by the <see cref="M:WMIwrapper.Win32_OperatingSystem.Win32Shutdown"></see> method, but it also allows you to specify comments, a reason for shutdown, or a timeout.
    ''' </summary>
    ''' <param name="Timeout">Time, in seconds, before shutdown takes place. The default value is 0 (zero).</param>
    ''' <param name="Comment">Message to display in the shutdown dialog box that is also stored as a comment in the event log entry.</param>
    ''' <param name="ReasonCode">Reason for initiating the shutdown.</param>
    ''' <param name="Flags">
    ''' Bitmapped set of flags to shut the computer down.
    ''' To force a command, add the Force flag (4) to the command value.
    ''' Using Force in conjunction with Shutdown or Reboot on a remote computer immediately shuts down everything
    ''' (including WMI, COM, and so on), or reboots the remote computer.
    ''' This results in an indeterminate return value.
    ''' </param>
    ''' <returns>Returns zero (0) to indicate success. Any other number indicates an error.</returns>
    ''' <remarks></remarks>
    Public Function Win32ShutdownTracker(ByVal Flags As Enums.Flags, Optional ByVal Timeout As UInt32 = 0, Optional ByVal Comment As String = "", Optional ByVal ReasonCode As UInt32 = 0) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_OperatingSystem"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("Win32ShutdownTracker")
        inParams("Timeout") = Timeout
        inParams("Comment") = Comment
        inParams("ReasonCode") = ReasonCode
        inParams("Flags") = Flags

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("Win32ShutdownTracker")
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.Win32_OperatingSystem"></see>.
''' </summary>
''' <remarks></remarks>
Public Class Win32_OperatingSystems
    Inherits CIM_OperatingSystems

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Computer As String)

        MyBase.New(Computer, "Win32_OperatingSystem")
        ' Read the collection
        For Each ManagementObjectI As ManagementObject In Me.Read()
            Me.Add(New Win32_OperatingSystem(ManagementObjectI))
        Next

    End Sub

    ''' <summary>
    ''' Find an item in the collection.
    ''' </summary>
    ''' <param name="index">Index of the item.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal index As Integer) As Win32_OperatingSystem
        Return CType(List.Item(index), Win32_OperatingSystem)
    End Function

    ' Singleton class: use item(0).
End Class


Namespace Enums

    ''' <summary>
    ''' Indicates which Data Execution Prevention (DEP) setting is applied.
    ''' The DEP setting specifies the extent to which DEP applies to 32-bit applications on the system.
    ''' DEP is always applied to the Windows kernel.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum DataExecutionPrevention_SupportPolicy As Byte
        ''' <summary>
        ''' DEP is turned off for all 32-bit applications on the computer with no exceptions.
        ''' This setting is not available for the user interface.
        ''' </summary>
        ''' <remarks></remarks>
        AlwaysOff = 0
        ''' <summary>
        ''' DEP is enabled for all 32-bit applications on the computer.
        ''' This setting is not available for the user interface.
        ''' </summary>
        ''' <remarks></remarks>
        AlwaysOn = 1
        ''' <summary>
        ''' DEP is enabled for a limited number of binaries, the kernel, and all Windows-based services.
        ''' However, it is off by default for all 32-bit applications.
        ''' A user or administrator must explicitly choose either the AlwaysOn or the OptOut setting before DEP can be applied to 32-bit applications.
        ''' </summary>
        ''' <remarks></remarks>
        OptIn = 2
        ''' <summary>
        ''' DEP is enabled by default for all 32-bit applications.
        ''' A user or administrator can explicitly remove support for a 32-bit application by adding the application to an exceptions list.
        ''' </summary>
        ''' <remarks></remarks>
        OptOut = 3
    End Enum

    ''' <summary>
    ''' Installed and licensed system product additions to the operating system.
    ''' </summary>
    ''' <remarks></remarks>
    <Flags()> _
        Public Enum OSProductSuite As UInt32
        ''' <summary>
        ''' Microsoft Small Business Server was once installed, but may have been upgraded to another version of Windows.
        ''' </summary>
        ''' <remarks>Windows Server 2003, Windows XP, and Windows 2000: Small Business.</remarks>
        SmallBusiness = 1
        ''' <summary>
        ''' Windows Server 2008 Enterprise, Windows Server 2003, Enterprise Edition, Windows 2000 Advanced Server, or Windows NT Server 4.0 Enterprise Edition is installed.
        ''' </summary>
        ''' <remarks>Windows Server 2003, Windows XP, and Windows 2000: Enterprise</remarks>
        Enterprise = 2
        ''' <summary>
        ''' Windows BackOffice components are installed.
        ''' </summary>
        ''' <remarks>Windows Server 2003, Windows XP, and Windows 2000: BackOffice</remarks>
        BackOffice = 4
        ''' <summary>
        ''' Communication Server is installed.
        ''' </summary>
        ''' <remarks>Windows Server 2003, Windows XP, and Windows 2000: Communication Server</remarks>
        CommunicationServer = 8
        ''' <summary>
        ''' Terminal Services is installed.
        ''' </summary>
        ''' <remarks>Windows Server 2003, Windows XP, and Windows 2000: Terminal Server</remarks>
        TerminalServer = 16
        ''' <summary>
        ''' Microsoft Small Business Server is installed with the restrictive client license.
        ''' </summary>
        ''' <remarks>Windows Server 2003, Windows XP, and Windows 2000: Small Business (Restricted)</remarks>
        SmallBusinessRestricted = 32
        ''' <summary>
        ''' Windows XP Embedded is installed.
        ''' </summary>
        ''' <remarks>Windows Server 2003 and Windows XP: Embedded NT</remarks>
        EmbeddedNT = 64
        ''' <summary>
        ''' Windows Server 2008 Datacenter, Windows Server 2003, Datacenter Edition, or Windows 2000 Datacenter Server is installed.
        ''' </summary>
        ''' <remarks>Windows Server 2003, Windows XP, and Windows 2000: Data Center</remarks>
        DataCenter = 128
        ''' <summary>
        ''' Terminal Services is installed, but only one interactive session is supported.
        ''' </summary>
        ''' <remarks>Windows Server 2003, Windows XP, and Windows 2000: This value is not available.</remarks>
        TerminalServicesSingleUser = 256
        ''' <summary>
        ''' Windows XP Home Edition is installed.
        ''' </summary>
        ''' <remarks>Windows Server 2003, Windows XP, and Windows 2000: This value is not available.</remarks>
        XPHome = 512
        ''' <summary>
        ''' Windows Server 2003, Web Edition is installed.
        ''' </summary>
        ''' <remarks>Windows Server 2003, Windows XP, and Windows 2000: This value is not available.</remarks>
        WebEdition2003 = 1024
        ''' <summary>
        ''' Windows Storage Server 2003 R2 is installed.
        ''' </summary>
        ''' <remarks>Windows Server 2003, Windows XP, and Windows 2000:  This value is not available.</remarks>
        StorageServer2003R2 = 8192
        ''' <summary>
        ''' Windows Server 2003, Compute Cluster Edition is installed.
        ''' </summary>
        ''' <remarks>Windows Server 2003, Windows XP, and Windows 2000: This value is not available.</remarks>
        ClusterEdition2003 = 16384
    End Enum

    ''' <summary>
    ''' Additional system information.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum ProductType As UInt32
        ''' <summary>
        ''' Work Station.
        ''' </summary>
        ''' <remarks></remarks>
        WorkStation = 1
        ''' <summary>
        ''' Domain Controller.
        ''' </summary>
        ''' <remarks></remarks>
        DomainController = 2
        ''' <summary>
        ''' Server.
        ''' </summary>
        ''' <remarks></remarks>
        Server = 3
    End Enum

    ''' <summary>
    ''' Number of clock ticks per quantum.
    ''' </summary>
    ''' <remarks>
    ''' A quantum is a unit of execution time that the scheduler is allowed to give to an application before switching to other applications.
    ''' When a thread runs one quantum, the kernel preempts it and moves it to the end of a queue for applications with equal priorities. The actual length, of a thread quantum, varies across different Windows platforms—Windows NT and Windows 2000 only.
    ''' </remarks>
    Public Enum QuantumLength As Byte
        ''' <summary>
        ''' Unknown.
        ''' </summary>
        ''' <remarks></remarks>
        Unknown = 1
        ''' <summary>
        ''' One Tick.
        ''' </summary>
        ''' <remarks></remarks>
        OneTick = 2
        ''' <summary>
        ''' Two Ticks.
        ''' </summary>
        ''' <remarks></remarks>
        TwoTicks = 3
    End Enum

    ''' <summary>
    ''' Length type of quantums.
    ''' </summary>
    ''' <remarks>
    ''' Windows NT Workstation and Windows 2000 defaults to variable-length quantums where the foreground application has a longer quantum than the background applications.
    ''' Windows NT Server defaults to fixed-length quantums.
    ''' A quantum is a unit of execution time that the scheduler is allowed to give to an application before switching to another application.
    ''' When a thread runs one quantum, the kernel preempts it and moves it to the end of a queue for applications with equal priorities.
    ''' The actual length of a thread quantum varies across different Windows platforms.
    ''' For Windows NT and Windows 2000 only.
    ''' </remarks>
    Public Enum QuantumType As Byte
        ''' <summary>
        ''' Unknown.
        ''' </summary>
        ''' <remarks></remarks>
        Unknown = 1
        ''' <summary>
        ''' Fixed.
        ''' </summary>
        ''' <remarks></remarks>
        Fixed = 2
        ''' <summary>
        ''' Variable.
        ''' </summary>
        ''' <remarks></remarks>
        Variable = 3
    End Enum

    ''' <summary>
    ''' Bitmapped set of flags to shut the computer down.
    ''' </summary>
    ''' <remarks>
    ''' To force a command, add the Force flag (4) to the command value.
    ''' Using Force in conjunction with Shutdown or Reboot on a remote computer immediately shuts down everything (including WMI, COM, and so on), or reboots the remote computer.
    ''' This results in an indeterminate return value.
    ''' </remarks>
    <Flags()> _
    Public Enum Flags As Int32
        ''' <summary>
        ''' Log Off.
        ''' </summary>
        ''' <remarks></remarks>
        LogOff = 0
        ''' <summary>
        ''' Shutdown.
        ''' </summary>
        ''' <remarks></remarks>
        Shutdown = 1
        ''' <summary>
        ''' Reboot.
        ''' </summary>
        ''' <remarks></remarks>
        Reboot = 2
        ''' <summary>
        ''' Forced Log Off.
        ''' </summary>
        ''' <remarks></remarks>
        ForcedLogOff = 4
        ''' <summary>
        ''' Power Off.
        ''' </summary>
        ''' <remarks></remarks>
        PowerOff = 8
        ''' <summary>
        ''' Forced Shutdown.
        ''' </summary>
        ''' <remarks></remarks>
        ForcedShutdown = 5
        ''' <summary>
        ''' Forced Reboot.
        ''' </summary>
        ''' <remarks></remarks>
        ForcedReboot = 6
        ''' <summary>
        ''' Forced Power Off.
        ''' </summary>
        ''' <remarks></remarks>
        ForcedPowerOff = 12
    End Enum

End Namespace
