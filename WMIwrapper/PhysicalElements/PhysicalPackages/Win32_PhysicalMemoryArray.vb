Imports System.Management

''' <summary>
''' Represents details about the computer system physical memory.
''' </summary>
''' <remarks>
''' This includes the number of memory devices, memory capacity available, and memory type—for example, system or video memory.
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa394348.aspx">MSDN</a>
''' </remarks>
Public Class Win32_PhysicalMemoryArray
    Inherits CIM_PhysicalPackage

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
    ''' Physical location of the memory array.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    Public ReadOnly Property Location() As Enums.Location
        Get
            Return CType(GetUint16Property("Location"), Enums.Location)
        End Get
    End Property

    ''' <summary>
    ''' Maximum memory size (in bytes) installable for this particular memory array.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>If the size is unknown, the property is given a value of 0 (zero).</remarks>
    Public ReadOnly Property MaxCapacity() As UInt32
        Get
            Return GetUint32Property("MaxCapacity")
        End Get
    End Property

    ''' <summary>
    ''' Number of physical slots or sockets available in this memory array.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    Public ReadOnly Property MemoryDevices() As UInt16
        Get
            Return GetUint16Property("MemoryDevices")
        End Get
    End Property

    ''' <summary>
    ''' Type of error correction used by the memory array.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    Public ReadOnly Property MemoryErrorCorrection() As Enums.MemoryErrorCorrection
        Get
            Return CType(GetUint16Property("MemoryErrorCorrection"), Enums.MemoryErrorCorrection)
        End Get
    End Property

    ''' <summary>
    ''' How memory is used in the computer system.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    Public ReadOnly Property Use() As Enums.Use
        Get
            Return CType(GetUint16Property("Use"), Enums.Use)
        End Get
    End Property

#End Region

End Class

''' <summary>
''' Collection of <see cref="T:WMIwrapper.Win32_PhysicalMemoryArray"></see>.
''' </summary>
''' <remarks></remarks>
Public Class Win32_PhysicalMemoryArrays
    Inherits CIM_PhysicalPackages

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <param name="Tag">If specified, only the item corresponding to this key value is returned. Ignored if <code>Condition</code> is set.</param>
    ''' <param name="Condition">WQL condition can be specified. It is not checked and sent to WMI as is.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Computer As String, Optional ByVal Tag As String = Nothing, Optional ByVal Condition As String = Nothing)

        MyBase.New(Computer, "Win32_PhysicalMemoryArray")
        ' Prepare condition
        If Condition Is Nothing AndAlso Tag IsNot Nothing Then
            Condition = "Tag ='" & Tag & "'"
        End If
        ' Read the collection
        For Each ManagementObjectI As ManagementObject In Me.Read(Condition)
            Me.Add(New Win32_PhysicalMemoryArray(ManagementObjectI))
        Next

    End Sub

    ''' <summary>
    ''' Find an item in the collection.
    ''' </summary>
    ''' <param name="index">Index of the item.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal index As Integer) As Win32_PhysicalMemoryArray
        Return CType(List.Item(index), Win32_PhysicalMemoryArray)
    End Function

    ''' <summary>
    ''' Find an item by its tag.
    ''' </summary>
    ''' <param name="Tag">The item's tag.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal Tag As String) As Win32_PhysicalMemoryArray
        For intI As Integer = 0 To List.Count - 1
            If Me.Item(intI).Tag = Tag Then
                Return Me.Item(intI)
            End If
        Next
        Return Nothing
    End Function

End Class


Namespace Enums

    ''' <summary>
    ''' Physical location of the memory array.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum Location As UInt16

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
        ''' Unknown.
        ''' </summary>
        ''' <remarks></remarks>
        Unknown = 2

        ''' <summary>
        ''' System board or motherboard.
        ''' </summary>
        ''' <remarks></remarks>
        SystemBoardOrMotherboard = 3

        ''' <summary>
        ''' ISA add-on card.
        ''' </summary>
        ''' <remarks></remarks>
        ISAAddOn = 4

        ''' <summary>
        ''' EISA add-on card.
        ''' </summary>
        ''' <remarks></remarks>
        EISAAddOnCard = 5

        ''' <summary>
        ''' PCI add-on card.
        ''' </summary>
        ''' <remarks></remarks>
        PCIAddOnCard = 6

        ''' <summary>
        ''' MCA add-on card
        ''' </summary>
        ''' <remarks></remarks>
        MCAAddOnCard = 7

        ''' <summary>
        ''' PCMCIA add-on card.
        ''' </summary>
        ''' <remarks></remarks>
        PCMCIAAddOnCard = 8

        ''' <summary>
        ''' Proprietary add-on card.
        ''' </summary>
        ''' <remarks></remarks>
        ProprietaryAddOnCard = 9

        ''' <summary>
        ''' NuBus.
        ''' </summary>
        ''' <remarks></remarks>
        NuBus = 10

        ''' <summary>
        ''' PC-98/C20 add-on card.
        ''' </summary>
        ''' <remarks></remarks>
        PC98C20AddOnCard = 11

        ''' <summary>
        ''' PC-98/C24 add-on card.
        ''' </summary>
        ''' <remarks></remarks>
        PC98C24AddOnCard = 12

        ''' <summary>
        ''' PC-98/E add-on card.
        ''' </summary>
        ''' <remarks></remarks>
        PC98EAddOnCard = 13

        ''' <summary>
        ''' PC-98/Local bus add-on card.
        ''' </summary>
        ''' <remarks></remarks>
        PC98LocalBusAddOnCard = 14

    End Enum

    ''' <summary>
    ''' Type of error correction used by the memory array.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum MemoryErrorCorrection As UInt16

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
        ''' Unknown.
        ''' </summary>
        ''' <remarks></remarks>
        Unknown = 2

        ''' <summary>
        ''' None.
        ''' </summary>
        ''' <remarks></remarks>
        None = 3

        ''' <summary>
        ''' Parity.
        ''' </summary>
        ''' <remarks></remarks>
        Parity = 4

        ''' <summary>
        ''' Single-Bit ECC.
        ''' </summary>
        ''' <remarks></remarks>
        SingleBitECC = 5

        ''' <summary>
        ''' Multi-bit ECC.
        ''' </summary>
        ''' <remarks></remarks>
        MultiBitECC = 6

        ''' <summary>
        ''' CRC.
        ''' </summary>
        ''' <remarks></remarks>
        CRC = 7

    End Enum

    ''' <summary>
    ''' How memory is used in the computer system.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum Use As UInt16

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
        ''' Unknown.
        ''' </summary>
        ''' <remarks></remarks>
        Unknown = 2

        ''' <summary>
        ''' System memory.
        ''' </summary>
        ''' <remarks></remarks>
        SystemMemory = 3


        ''' <summary>
        ''' Video memory.
        ''' </summary>
        ''' <remarks></remarks>
        VideoMemory = 4

        ''' <summary>
        ''' Flash memory.
        ''' </summary>
        ''' <remarks></remarks>
        FlashMemory = 5

        ''' <summary>
        ''' Nonvolatile RAM.
        ''' </summary>
        ''' <remarks></remarks>
        NonvolatileRAM = 6

        ''' <summary>
        ''' Cache memory.
        ''' </summary>
        ''' <remarks></remarks>
        CacheMemory = 7

    End Enum

End Namespace
