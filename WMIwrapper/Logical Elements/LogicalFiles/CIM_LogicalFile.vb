Imports System.Management

''' <summary>
''' Represents a named collection of data, which can be executable code, that is located in a file system on a storage extent.
''' </summary>
''' <remarks>
''' <para>See <a href="http://msdn2.microsoft.com/en-us/library/aa387893(VS.85).aspx">MSDN</a>.</para>
''' </remarks>
Public MustInherit Class CIM_LogicalFile
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
    ''' Bitmask that represents the access rights required to access or perform specific operations on the file.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' Windows 2000 and Windows NT 4.0:  On FAT volumes, the FULL_ACCESS value is returned instead, which indicates no security has been set on the object.
    ''' </remarks>
    Public ReadOnly Property AccessMask() As Enums.AccessMask
        Get
            Dim obj As Object = GetPropertyObject("AccessMask")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.AccessMask)
            End If
        End Get
    End Property

    ''' <summary>
    ''' If True, the file should be archived.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    Public ReadOnly Property Archive() As Boolean
        Get
            Return GetBooleanProperty("Archive")
        End Get
    End Property

    ''' <summary>
    ''' If True, the file is compressed.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    Public ReadOnly Property Compressed() As Boolean
        Get
            Return GetBooleanProperty("Compressed")
        End Get
    End Property

    ''' <summary>
    ''' Free-form string that indicates the algorithm or tool used to compress the logical file.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' If the compression scheme is unknown or not described, use "Unknown".
    ''' If the logical file is compressed, but the compression scheme is unknown or not described, use "Compressed".
    ''' If the logical file is not compressed, use "Not Compressed".
    ''' </remarks>
    Public ReadOnly Property CompressionMethod() As String
        Get
            Return GetStringProperty("CompressionMethod")
        End Get
    End Property

    ''' <summary>
    ''' Name of the class.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' </remarks>
    Public ReadOnly Property CreationClassName() As String
        Get
            Return GetStringProperty("CreationClassName")
        End Get
    End Property

    ''' <summary>
    ''' Date and time of the file's creation.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' </remarks>
    Public ReadOnly Property CreationDate() As DateTime
        Get
            Return GetDateTimeProperty("CreationDate")
        End Get
    End Property

    ''' <summary>
    ''' Class of the computer system.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' </remarks>
    Public ReadOnly Property CSCreationClassName() As String
        Get
            Return GetStringProperty("CSCreationClassName")
        End Get
    End Property

    ''' <summary>
    ''' Name of the computer system.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' </remarks>
    Public ReadOnly Property CSName() As String
        Get
            Return GetStringProperty("CSName")
        End Get
    End Property

    ''' <summary>
    ''' Drive letter (including the colon that follows the drive letter) of the file.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Example: "c:"</remarks>
    Public ReadOnly Property Drive() As String
        Get
            Return GetStringProperty("Drive")
        End Get
    End Property

    ''' <summary>
    ''' DOS-compatible file name.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Example: "c:\progra~1"</remarks>
    Public ReadOnly Property EightDotThreeFileName() As String
        Get
            Return GetStringProperty("EightDotThreeFileName")
        End Get
    End Property

    ''' <summary>
    ''' If True, the file is encrypted.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    Public ReadOnly Property Encrypted() As Boolean
        Get
            Return GetBooleanProperty("Encrypted")
        End Get
    End Property

    ''' <summary>
    ''' Free-form string that identifies the algorithm or tool used to encrypt a logical file.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' If the encryption scheme is not indulged (for security reasons, for example), use "Unknown".
    ''' If the file is encrypted, but either its encryption scheme is unknown or not disclosed, use "Encrypted".
    ''' If the logical file is not encrypted, use "Not Encrypted".
    ''' </remarks>
    Public ReadOnly Property EncryptionMethod() As String
        Get
            Return GetStringProperty("EncryptionMethod")
        End Get
    End Property

    ''' <summary>
    ''' File extension without the preceding period (dot).
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' Example: "txt", "mof", "mdb"
    ''' </remarks>
    Public ReadOnly Property Extension() As String
        Get
            Return GetStringProperty("Extension")
        End Get
    End Property

    ''' <summary>
    ''' Size of the file, in bytes.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' </remarks>
    Public ReadOnly Property FileSize() As UInt64
        Get
            Return GetUint64Property("FileSize")
        End Get
    End Property

    ''' <summary>
    ''' Descriptor that represents the file type indicated by the Extension property.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' </remarks>
    Public ReadOnly Property FileType() As String
        Get
            Return GetStringProperty("FileType")
        End Get
    End Property

    ''' <summary>
    ''' Class of the file system.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' </remarks>
    Public ReadOnly Property FSCreationClassName() As String
        Get
            Return GetStringProperty("FSCreationClassName")
        End Get
    End Property

    ''' <summary>
    ''' Name of the file system.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' </remarks>
    Public ReadOnly Property FSName() As String
        Get
            Return GetStringProperty("FSName")
        End Get
    End Property

    ''' <summary>
    ''' If True, the file is hidden.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    Public ReadOnly Property Hidden() As Boolean
        Get
            Return GetBooleanProperty("Hidden")
        End Get
    End Property

    ''' <summary>
    ''' Number of "file opens" that are currently active against the file.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' </remarks>
    Public ReadOnly Property InUseCount() As UInt64
        Get
            Return GetUint64Property("InUseCount")
        End Get
    End Property

    ''' <summary>
    ''' Date and time the file was last accessed.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' </remarks>
    Public ReadOnly Property LastAccessed() As DateTime
        Get
            Return GetDateTimeProperty("LastAccessed")
        End Get
    End Property

    ''' <summary>
    ''' Date and time the file was last modified.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' </remarks>
    Public ReadOnly Property LastModified() As DateTime
        Get
            Return GetDateTimeProperty("LastModified")
        End Get
    End Property

    ''' <summary>
    ''' Path of the file including the leading and trailing backslashes.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' Example: "\windows\system\"
    ''' </remarks>
    Public ReadOnly Property Path() As String
        Get
            Return GetStringProperty("Path")
        End Get
    End Property

    ''' <summary>
    ''' If True, the file can be read.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    Public ReadOnly Property Readable() As Boolean
        Get
            Return GetBooleanProperty("Readable")
        End Get
    End Property

    ''' <summary>
    ''' If True, the file a system file.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    Public ReadOnly Property System() As Boolean
        Get
            Return GetBooleanProperty("System")
        End Get
    End Property

    ''' <summary>
    ''' If True, the file can be written.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    Public ReadOnly Property Writeable() As Boolean
        Get
            Return GetBooleanProperty("Writeable")
        End Get
    End Property

#End Region

#Region "Methods"

    ''' <summary>
    ''' Changes the security permissions for the logical data file specified in the object path.
    ''' </summary>
    ''' <param name="SecurityDescriptor">
    ''' Specifies the security information.
    ''' A NULL ACL in the SECURITY_DESCRIPTOR structure grants unlimited access.
    ''' </param>
    ''' <param name="Option_">Security privilege to modify.</param>
    ''' <remarks>
    ''' If the logical file is a directory, then this method will act recursively,
    ''' changing the security permissions for all of the files and sub-directories that the directory contains.
    ''' </remarks>
    Public Function ChangeSecurityPermissions(ByVal SecurityDescriptor As Win32_SecurityDescriptor, ByVal Option_ As Enums.Option_) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("CIM_LogicalFile"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("ChangeSecurityPermissions")
        inParams("SecurityDescriptor") = SecurityDescriptor
        inParams("Option") = Option_

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("ChangeSecurityPermissions", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ChangeSecurityPermissionsErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Error messages for the <see cref="M:WMIwrapper.CIM_LogicalFile.ChangeSecurityPermissions"></see> method of this class.
    ''' </summary>
    ''' <param name="Number">Error number.</param>
    ''' <returns>A string containing the error message.</returns>
    ''' <remarks></remarks>
    Protected Function ChangeSecurityPermissionsErrorMessage(ByVal Number As UInteger) As String
        Select Case Number
            Case 0
                Return "Success"
            Case 2
                Return "Access Denied"
            Case 8
                Return "Unspecified failure."
            Case 9
                Return "Invalid object."
            Case 10
                Return "Object already exists."
            Case 11
                Return "File system not NTFS."
            Case 12
                Return "Platform not Windows NT or Windows 2000."
            Case 13
                Return "Drive not the same."
            Case 14
                Return "Directory not empty."
            Case 15
                Return "Sharing violation."
            Case 16
                Return "Invalid start file."
            Case 17
                Return "Privilege not held."
            Case 21
                Return "Invalid parameter."
            Case Else
                Return "Unreferenced Error"
        End Select
    End Function

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.CIM_LogicalFile"></see>.
''' </summary>
''' <remarks></remarks>
Public MustInherit Class CIM_LogicalFiles
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



Namespace Enums

    ''' <summary>
    ''' Security privilege to modify.
    ''' </summary>
    ''' <remarks></remarks>
    <Flags()> _
      Public Enum Option_ As UInt32

        ''' <summary>
        ''' Change the owner of the logical file.
        ''' </summary>
        ''' <remarks></remarks>
        CHANGE_OWNER_SECURITY_INFORMATION = 1

        ''' <summary>
        ''' Change the group of the logical file. 
        ''' </summary>
        ''' <remarks></remarks>
        CHANGE_GROUP_SECURITY_INFORMATION = 2

        ''' <summary>
        ''' Change the ACL of the logical file.
        ''' </summary>
        ''' <remarks></remarks>
        CHANGE_DACL_SECURITY_INFORMATION = 4

        ''' <summary>
        ''' Change the system ACL of the logical file.
        ''' </summary>
        ''' <remarks></remarks>
        CHANGE_SACL_SECURITY_INFORMATION = 8

    End Enum

End Namespace
