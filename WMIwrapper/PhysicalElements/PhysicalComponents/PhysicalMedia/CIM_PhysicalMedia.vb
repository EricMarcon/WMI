Imports System.Management

''' <summary>
''' Represents types of documentation and storage medium, such as tapes, CD ROMs, and so on.
''' </summary>
''' <remarks>
''' <para>
''' This class is typically used to locate and manage removable media (versus media sealed with the media access device as a single package, such as hard disks).
''' Sealed media, however, can also be modeled using this class when the media is associated with the physical package using the <see cref="T:WMIwrapper.CIM_PackagedComponent"></see> relationship.
''' </para>
''' <para>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa387967.aspx">MSDN</a>
''' </para>
''' </remarks>
Public MustInherit Class CIM_PhysicalMedia
    Inherits CIM_PhysicalComponent

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
    ''' Number of bytes that can be read from or written to this physical media component.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' This property does not apply to "Hard Copy" or cleaner media.
    ''' Data compression should not be assumed as it would increase the value of this property.
    ''' For tapes, it should be assumed that no filemarks or blank space areas are recorded on the media.
    ''' </remarks>
    Public ReadOnly Property Capacity() As UInt64
        Get
            Return GetUint64Property("Capacity")
        End Get
    End Property

    ''' <summary>
    ''' If TRUE, the physical media is used for cleaning purposes and not data storage.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property CleanerMedia() As Boolean
        Get
            Return GetBooleanProperty("CleanerMedia")
        End Get
    End Property

    ''' <summary>
    ''' Additional detail related to the MediaType property.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' For example, if MediaType has the value 3 (QIC Cartridge) the MediaDescription property can indicate whether the tape is wide or quarter inch.
    ''' </remarks>
    Public ReadOnly Property MediaDescription() As String
        Get
            Return GetStringProperty("MediaDescription")
        End Get
    End Property

    ''' <summary>
    ''' The type of the media, as an enumerated integer.
    ''' </summary>
    ''' <remarks>The MediaDescription property provides a more explicit definition of the media type.</remarks>
    Public ReadOnly Property MediaType() As Structures.MediaType
        Get
            Dim _MediaType As Structures.MediaType
            _MediaType.Number = GetUint16Property("MediaType")
            Select Case _MediaType.Number
                Case 0
                    _MediaType.Name = "Unknown"
                Case 1
                    _MediaType.Name = "Other"
                Case 2
                    _MediaType.Name = "Tape Cartridge"
                Case 3
                    _MediaType.Name = "QIC Cartridge"
                Case 4
                    _MediaType.Name = "AIT Cartridge"
                Case 5
                    _MediaType.Name = "DTF Cartridge"
                Case 6
                    _MediaType.Name = "DAT Cartridge"
                Case 7
                    _MediaType.Name = "8mm Tape Cartridge"
                Case 8
                    _MediaType.Name = "19mm Tape Cartridge"
                Case 9
                    _MediaType.Name = "DLT Cartridge"
                Case 10
                    _MediaType.Name = "Half-Inch Magnetic Tape Cartridge"
                Case 11
                    _MediaType.Name = "Cartridge Disk"
                Case 12
                    _MediaType.Name = "JAZ Disk"
                Case 13
                    _MediaType.Name = "ZIP Disk"
                Case 14
                    _MediaType.Name = "SyQuest Disk"
                Case 15
                    _MediaType.Name = "Winchester Removable Disk"
                Case 16
                    _MediaType.Name = "CDROM"
                Case 17
                    _MediaType.Name = "CD ROM/XA"
                Case 18
                    _MediaType.Name = "CD-I"
                Case 19
                    _MediaType.Name = "CD Recordable"
                Case 20
                    _MediaType.Name = "WORM"
                Case 21
                    _MediaType.Name = "Magneto-Optical"
                Case 22
                    _MediaType.Name = "DVD"
                Case 23
                    _MediaType.Name = "DVD+RW"
                Case 24
                    _MediaType.Name = "DVD-RAM"
                Case 25
                    _MediaType.Name = "DVD-ROM"
                Case 26
                    _MediaType.Name = "DVD-Video"
                Case 27
                    _MediaType.Name = "Divx"
                Case 28
                    _MediaType.Name = "Floppy/Diskette"
                Case 29
                    _MediaType.Name = "Hard Disk"
                Case 30
                    _MediaType.Name = "Memory Card"
                Case 31
                    _MediaType.Name = "Hard Copy"
                Case 32
                    _MediaType.Name = "Clik Disk"
                Case 33
                    _MediaType.Name = "CD-RW"
                Case 34
                    _MediaType.Name = "CD-DA"
                Case 35
                    _MediaType.Name = "CD+"
                Case 36
                    _MediaType.Name = "DVD Recordable"
                Case 37
                    _MediaType.Name = "DVD-RW"
                Case 38
                    _MediaType.Name = "DVD-Audio"
                Case 39
                    _MediaType.Name = "DVD-5"
                Case 40
                    _MediaType.Name = "DVD-9"
                Case 41
                    _MediaType.Name = "DVD-10"
                Case 42
                    _MediaType.Name = "DVD-18"
                Case 43
                    _MediaType.Name = "Magneto-Optical Rewriteable"
                Case 44
                    _MediaType.Name = "Magneto-Optical Write Once"
                Case 45
                    _MediaType.Name = "Magneto-Optical Rewriteable (LIMDOW)"
                Case 46
                    _MediaType.Name = "Phase Change Write Once"
                Case 47
                    _MediaType.Name = "Phase Change Rewriteable"
                Case 48
                    _MediaType.Name = "Phase Change Dual Rewriteable"
                Case 49
                    _MediaType.Name = "Ablative Write Once"
                Case 50
                    _MediaType.Name = "Near Field Recording"
                Case 51
                    _MediaType.Name = "MiniQic"
                Case 52
                    _MediaType.Name = "Travan"
                Case 53
                    _MediaType.Name = "8mm Metal Particle"
                Case 54
                    _MediaType.Name = "8mm Advanced Metal Evaporate"
                Case 55
                    _MediaType.Name = "NCTP"
                Case 56
                    _MediaType.Name = "LTO Ultrium"
                Case 57
                    _MediaType.Name = "LTO Accelis"
                Case 58
                    _MediaType.Name = "9 Track Tape"
                Case 59
                    _MediaType.Name = "18 Track Tape"
                Case 60
                    _MediaType.Name = "36 Track Tape "
                Case 61
                    _MediaType.Name = "Magstar 3590"
                Case 62
                    _MediaType.Name = "Magstar MP"
                Case 63
                    _MediaType.Name = "D2 Tape"
                Case 64
                    _MediaType.Name = "Tape - DST Small"
                Case 65
                    _MediaType.Name = "Tape - DST Medium"
                Case 66
                    _MediaType.Name = "Tape - DST Large"
                Case Else
                    _MediaType.Name = "Unknown media"
            End Select
            Return _MediaType
        End Get
    End Property

    ''' <summary>
    ''' If TRUE, the media is currently write protected by some kind of physical mechanism, such as a protect tab on a floppy disk.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property WriteProtectOn() As Boolean
        Get
            Return GetBooleanProperty("WriteProtectOn")
        End Get
    End Property

#End Region

    ''' <summary>
    ''' Structures used by the class.
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Structures

        ''' <summary>
        ''' The type of the media.
        ''' </summary>
        ''' <remarks></remarks>
        Public Structure MediaType
            Public Number As UInt16
            Public Name As String
        End Structure

    End Class

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.CIM_PhysicalMedia"></see>.
''' </summary>
''' <remarks></remarks>
Public MustInherit Class CIM_PhysicalMedias
    Inherits CIM_PhysicalComponents

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
