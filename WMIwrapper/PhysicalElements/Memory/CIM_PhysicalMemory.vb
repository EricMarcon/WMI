Imports System.Management

''' <summary>
''' Represents low-level memory devices, such as SIMMS, DIMMs, raw memory chips, and so on.
''' </summary>
''' <remarks>
''' <para>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa387968.aspx">MSDN</a>
''' </para>
''' </remarks>
Public MustInherit Class CIM_PhysicalMemory
    Inherits CIM_Chip

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
    ''' Labeled bank in which the memory is located.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>For example, "Bank 0" or "Bank A".</remarks>
    Public ReadOnly Property BankLabel() As String
        Get
            Return GetStringProperty("BankLabel")
        End Get
    End Property

    ''' <summary>
    ''' Total capacity of the physical memory, in bytes.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    Public ReadOnly Property Capacity() As UInt64
        Get
            Return GetUint64Property("Capacity")
        End Get
    End Property

    ''' <summary>
    ''' Data width of the physical memory, in bits.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>A data width of 0 (zero) , and a total width of 8, indicates that the memory is solely used to provide error correction bits.</remarks>
    Public ReadOnly Property DataWidth() As UInt16
        Get
            Return GetUint16Property("DataWidth")
        End Get
    End Property

    ''' <summary>
    ''' Position of the physical memory in an interleave.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' A value of 0 indicates non-interleaved, 1 indicates the first position, 2 indicates the second position, and so on.
    ''' For example, in a 2:1 interleave, a value of 1 indicates that the memory is in the even position.
    ''' </remarks>
    Public ReadOnly Property InterleavePosition() As UInt32
        Get
            Return GetUint32Property("InterleavePosition")
        End Get
    End Property

    ''' <summary>
    ''' Type of physical memory.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property MemoryType() As Enums.MemoryType
        Get
            Dim obj As Object = GetPropertyObject("MemoryType")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.MemoryType)
            End If
        End Get
    End Property

    ''' <summary>
    ''' Position of the physical memory in a row.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' For example, if it takes two 8-bit memory devices to form a 16-bit row, then a value of 2 indicates that the memory is the second device.
    ''' A value of 0 is an invalid value for this property.
    ''' </remarks>
    Public ReadOnly Property PositionInRow() As UInt32
        Get
            Return GetUint32Property("PositionInRow")
        End Get
    End Property

    ''' <summary>
    ''' Speed of the physical memory, in nanoseconds.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Speed() As UInt32
        Get
            Return GetUint32Property("Speed")
        End Get
    End Property

    ''' <summary>
    ''' Total width, in bits, of the physical memory, including check or error correction bits.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' If there are no error correction bits, the value in this property should match that specified for the <see cref="P:WMIwrapper.CIM_PhysicalMemory.DataWidth"></see> property.
    ''' </remarks>
    Public ReadOnly Property TotalWidth() As UInt16
        Get
            Return GetUint16Property("TotalWidth")
        End Get
    End Property

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.CIM_PhysicalMemory"></see>.
''' </summary>
''' <remarks></remarks>
Public MustInherit Class CIM_PhysicalMemories
    Inherits CIM_Chips

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
    ''' Type of physical memory.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum MemoryType As UInt16

        ''' <summary>
        ''' Unknown.
        ''' </summary>
        ''' <remarks></remarks>
        Unknown

        ''' <summary>
        ''' Other.
        ''' </summary>
        ''' <remarks></remarks>
        Other

        ''' <summary>
        ''' DRAM.
        ''' </summary>
        ''' <remarks></remarks>
        DRAM

        ''' <summary>
        ''' Synchronous DRAM.
        ''' </summary>
        ''' <remarks></remarks>
        SynchronousDRAM

        ''' <summary>
        ''' Cache DRAM.
        ''' </summary>
        ''' <remarks></remarks>
        CacheDRAM

        ''' <summary>
        ''' EDO.
        ''' </summary>
        ''' <remarks></remarks>
        EDO

        ''' <summary>
        ''' EDRAM.
        ''' </summary>
        ''' <remarks></remarks>
        EDRAM

        ''' <summary>
        ''' VRAM.
        ''' </summary>
        ''' <remarks></remarks>
        VRAM

        ''' <summary>
        ''' SRAM.
        ''' </summary>
        ''' <remarks></remarks>
        SRAM

        ''' <summary>
        ''' RAM.
        ''' </summary>
        ''' <remarks></remarks>
        RAM

        ''' <summary>
        ''' ROM.
        ''' </summary>
        ''' <remarks></remarks>
        ROM

        ''' <summary>
        ''' Flash.
        ''' </summary>
        ''' <remarks></remarks>
        Flash

        ''' <summary>
        ''' EEPROM.
        ''' </summary>
        ''' <remarks></remarks>
        EEPROM

        ''' <summary>
        ''' FEPROM.
        ''' </summary>
        ''' <remarks></remarks>
        FEPROM

        ''' <summary>
        ''' EPROM.
        ''' </summary>
        ''' <remarks></remarks>
        EPROM

        ''' <summary>
        ''' CDRAM.
        ''' </summary>
        ''' <remarks></remarks>
        CDRAM

        ''' <summary>
        ''' 3DRAM.
        ''' </summary>
        ''' <remarks></remarks>
        _3DRAM

        ''' <summary>
        ''' SDRAM.
        ''' </summary>
        ''' <remarks></remarks>
        SDRAM

        ''' <summary>
        ''' SGRAM.
        ''' </summary>
        ''' <remarks></remarks>
        SGRAM

        ''' <summary>
        ''' RDRAM.
        ''' </summary>
        ''' <remarks></remarks>
        RDRAM

        ''' <summary>
        ''' DDR.
        ''' </summary>
        ''' <remarks></remarks>
        DDR

        ''' <summary>
        ''' DDR 2.
        ''' </summary>
        ''' <remarks></remarks>
        DDR_2

        ''' <summary>
        ''' DDR2 FB-DIM
        ''' </summary>
        ''' <remarks></remarks>
        DDR2_FB_DIMM

    End Enum

End Namespace
