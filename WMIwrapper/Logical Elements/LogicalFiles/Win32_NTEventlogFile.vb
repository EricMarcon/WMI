Imports System.Management

''' <summary>
''' Represents  a logical file or directory of operating system events. The file is also known as the event log.
''' </summary>
''' <remarks>
''' <para>See <a href="http://msdn2.microsoft.com/en-us/library/aa394225(VS.85).aspx">MSDN</a>.</para>
''' </remarks>
Public Class Win32_NTEventlogFile
    Inherits CIM_DataFile

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
    ''' Name of the file that contains Windows NT events.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' Standard log file names include: Application, System, and Security.
    ''' </remarks>
    Public ReadOnly Property LogfileName() As String
        Get
            Return GetStringProperty("LogfileName")
        End Get
    End Property

    ''' <summary>
    ''' Maximum size (in bytes) permitted for the file that contains Windows NT events.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' If the file exceeds its maximum size, its contents are moved to another file and the primary file is emptied.
    ''' A value of zero indicates no size limit.
    ''' WMI retrieves the Maxsize value from the Event Log Service registry values.
    ''' </remarks>
    Public ReadOnly Property MaxFileSize() As UInt32
        Get
            Return GetUint32Property("MaxFileSize")
        End Get
    End Property

    ''' <summary>
    ''' Number of records in the file that contains Windows NT events.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' This value is determined by calling the Windows function GetNumberOfEventLogRecords.
    ''' </remarks>
    Public ReadOnly Property NumberOfRecords() As UInt32
        Get
            Return GetUint32Property("NumberOfRecords")
        End Get
    End Property

    ''' <summary>
    ''' Number of days after which an event can be overwritten.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' Special values are:
    ''' <list type="bullet">
    ''' <item><description>0: Always Overwrite</description></item>
    ''' <item><description>4294967295 (0xFFFFFFFF): Never Overwrite.</description></item>
    ''' </list>
    ''' Windows Server 2003, Windows XP, Windows 2000, and Windows NT 4.0 special values:
    ''' <list type="bullet">
    ''' <item><description>0: Any entry can be overwritten when necessary.</description></item>
    ''' <item><description>1...365: Events that have been in the log file for one year (365 days) or less can be overwritten.</description></item>
    ''' <item><description>4294967295 (0xFFFFFFFF): Nothing can be ever be overwritten.</description></item>
    ''' </list>
    ''' </remarks>
    Public ReadOnly Property OverwriteOutDated() As UInt32
        Get
            Return GetUint32Property("OverwriteOutDated")
        End Get
    End Property

    ''' <summary>
    ''' Current overwrite policy the Event Log service employs for this log file.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' Data can be never overwritten, or can be overwritten when necessary or when outdated.
    ''' When data is outdated depends on the OverwriteOutDated value.
    ''' Possible values are:
    ''' <list type="bullet">
    ''' <item><description>WhenNeeded: The value of OverwriteOutDated equals 0 (zero).</description></item>
    ''' <item><description>OutDated: The value of OverwriteOutDated ranges from 1 to 365.</description></item>
    ''' <item><description>Never: The value of OverwriteOutDated equals 4294967295.</description></item>
    ''' </list>
    ''' </remarks>
    Public ReadOnly Property OverWritePolicy() As String
        Get
            Return GetStringProperty("OverWritePolicy")
        End Get
    End Property

    ''' <summary>
    ''' List of applications that are registered to log into this log file. 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' </remarks>
    Public ReadOnly Property Sources() As String()
        Get
            Return GetStringArrayProperty("Sources")
        End Get
    End Property

#End Region

    ' TODO : methods

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.Win32_NTEventlogFile"></see>.
''' </summary>
''' <remarks></remarks>
Public Class Win32_NTEventlogFiles
    Inherits CIM_DataFiles

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <param name="Name">If specified, only the item corresponding to this key value is returned. Ignored if <code>Condition</code> is set.</param>
    ''' <param name="Condition">WQL condition can be specified. It is not checked and sent to WMI as is.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Computer As String, Optional ByVal Name As String = Nothing, Optional ByVal Condition As String = Nothing)

        MyBase.New(Computer, "Win32_NTEventlogFile")
        ' Prepare condition
        If Condition Is Nothing AndAlso Name IsNot Nothing Then
            Condition = "Name ='" & Name & "'"
        End If
        ' Read the collection
        For Each ManagementObjectI As ManagementObject In Me.Read(Condition)
            Me.Add(New Win32_NTEventlogFile(ManagementObjectI))
        Next

    End Sub

    ''' <summary>
    ''' Find an item by its index in the collection.
    ''' </summary>
    ''' <param name="index">0-based index of the item in the collection.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal index As Integer) As Win32_NTEventlogFile
        Return CType(List.Item(index), Win32_NTEventlogFile)
    End Function

    ''' <summary>
    ''' Find an item by its name.
    ''' </summary>
    ''' <param name="Name">The file name.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal Name As String) As Win32_NTEventlogFile
        For intI As Integer = 0 To List.Count - 1
            If Me.Item(intI).Name = Name Then
                Return Me.Item(intI)
            End If
        Next
        Return Nothing
    End Function

End Class
