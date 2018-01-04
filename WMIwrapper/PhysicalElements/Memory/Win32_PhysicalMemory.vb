Imports System.Management

''' <summary>
''' Represents a physical memory device located on a computer system and available to the operating system.
''' </summary>
''' <remarks>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa394347.aspx">MSDN</a>
''' </remarks>
Public Class Win32_PhysicalMemory
    Inherits CIM_PhysicalMemory

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
    ''' Label of the socket or circuit board that holds the memory.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Example: "SIMM 3"</remarks>
    Public ReadOnly Property DeviceLocator() As String
        Get
            Return GetStringProperty("DeviceLocator")
        End Get
    End Property

    ''' <summary>
    ''' Maximum number of consecutive rows of data that are accessed in a single interleaved transfer from the memory device.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>If the value is 0 (zero), the memory is not interleaved.</remarks>
    Public ReadOnly Property InterleaveDataDepth() As UInt16
        Get
            Return GetUint16Property("InterleaveDataDepth")
        End Get
    End Property

    ''' <summary>
    ''' Type of physical memory represented.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property TypeDetail() As Enums.TypeDetail
        Get
            Dim obj As Object = GetPropertyObject("TypeDetail")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.TypeDetail)
            End If
        End Get
    End Property

#End Region

End Class

''' <summary>
''' Collection of <see cref="T:WMIwrapper.Win32_PhysicalMemory"></see>.
''' </summary>
''' <remarks></remarks>
Public Class Win32_PhysicalMemories
    Inherits CIM_PhysicalMemories

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <param name="Tag">If specified, only the item corresponding to this key value is returned. Ignored if <code>Condition</code> is set.</param>
    ''' <param name="Condition">WQL condition can be specified. It is not checked and sent to WMI as is.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Computer As String, Optional ByVal Tag As String = Nothing, Optional ByVal Condition As String = Nothing)

        MyBase.New(Computer, "Win32_PhysicalMemory")
        ' Prepare condition
        If Condition Is Nothing AndAlso Tag IsNot Nothing Then
            Condition = "Tag ='" & Tag & "'"
        End If
        ' Read the collection
        For Each ManagementObjectI As ManagementObject In Me.Read(Condition)
            Me.Add(New Win32_PhysicalMemory(ManagementObjectI))
        Next

    End Sub

    ''' <summary>
    ''' Find an item in the collection.
    ''' </summary>
    ''' <param name="index">Index of the item.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal index As Integer) As Win32_PhysicalMemory
        Return CType(List.Item(index), Win32_PhysicalMemory)
    End Function

    ''' <summary>
    ''' Find an item by its tag.
    ''' </summary>
    ''' <param name="Tag">The item's tag.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal Tag As String) As Win32_PhysicalMemory
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
    ''' Type of physical memory represented.
    ''' </summary>
    ''' <remarks></remarks>
    <Flags()> _
    Public Enum TypeDetail As UInt16

        ''' <summary>
        ''' None.
        ''' </summary>
        ''' <remarks></remarks>
        None = 0

        ''' <summary>
        ''' Reserved.
        ''' </summary>
        ''' <remarks></remarks>
        Reserved = 1

        ''' <summary>
        ''' Other.
        ''' </summary>
        ''' <remarks></remarks>
        Other = 2

        ''' <summary>
        ''' Unknown.
        ''' </summary>
        ''' <remarks></remarks>
        Unknown = 4

        ''' <summary>
        ''' Fast-paged.
        ''' </summary>
        ''' <remarks></remarks>
        FastPaged = 8

        ''' <summary>
        '''  Static column.
        ''' </summary>
        ''' <remarks></remarks>
        StaticColumn = 16

        ''' <summary>
        ''' Pseudo-static.
        ''' </summary>
        ''' <remarks></remarks>
        PseudoStatic = 32

        ''' <summary>
        ''' RAMBUS.
        ''' </summary>
        ''' <remarks></remarks>
        RAMBUS = 64

        ''' <summary>
        ''' Synchronous.
        ''' </summary>
        ''' <remarks></remarks>
        Synchronous = 128

        ''' <summary>
        ''' CMOS.
        ''' </summary>
        ''' <remarks></remarks>
        CMOS = 256

        ''' <summary>
        ''' EDO.
        ''' </summary>
        ''' <remarks></remarks>
        EDO = 5122

        ''' <summary>
        ''' Window DRAM.
        ''' </summary>
        ''' <remarks></remarks>
        WindowDRAM = 24

        ''' <summary>
        ''' Cache DRAM.
        ''' </summary>
        ''' <remarks></remarks>
        CacheDRAM = 2048

        ''' <summary>
        ''' Nonvolatile.
        ''' </summary>
        ''' <remarks></remarks>
        Nonvolatile = 8192

    End Enum

End Namespace
