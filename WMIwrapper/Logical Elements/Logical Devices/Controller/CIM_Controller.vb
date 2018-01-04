Imports System.Management

''' <summary>
''' Parent class for grouping miscellaneous control-related devices.
''' </summary>
''' <remarks>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa387231.aspx">MSDN</a>
''' </remarks>
Public MustInherit Class CIM_Controller
    Inherits CIM_LogicalDevice

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
    ''' Maximum number of directly addressable entities supported by this controller.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>A value of 0 should be used if the number is unknown or unlimited.</remarks>
    Public ReadOnly Property MaxNumberControlled() As UInt32
        Get
            Return GetUint32Property("MaxNumberControlled")
        End Get
    End Property

    ''' <summary>
    ''' Protocol used by the controller to access 'controlled' devices.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ProtocolSupported() As Enums.ProtocolSupported
        Get
            Dim obj As Object = GetPropertyObject("ProtocolSupported")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.ProtocolSupported)
            End If
        End Get
    End Property

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.CIM_Controller"></see>.
''' </summary>
''' <remarks></remarks>
Public MustInherit Class CIM_Controllers
    Inherits CIM_LogicalDevices

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
    ''' Protocol used by the controller to access 'controlled' devices.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum ProtocolSupported As UInt16

        ''' <summary>
        ''' None.
        ''' </summary>
        ''' <remarks>Not in MSDN documentation but added after tests.</remarks>
        None

        ''' <summary>
        ''' Other.
        ''' </summary>
        ''' <remarks></remarks>
        Other

        ''' <summary>
        ''' Unknown.
        ''' </summary>
        ''' <remarks></remarks>
        Unknown

        ''' <summary>
        ''' EISA.
        ''' </summary>
        ''' <remarks></remarks>
        EISA

        ''' <summary>
        ''' ISA.
        ''' </summary>
        ''' <remarks></remarks>
        ISA

        ''' <summary>
        ''' PCI.
        ''' </summary>
        ''' <remarks></remarks>
        PCI

        ''' <summary>
        ''' ATA/ATAPI.
        ''' </summary>
        ''' <remarks></remarks>
        ATA_ATAPI

        ''' <summary>
        ''' Flexible Diskette.
        ''' </summary>
        ''' <remarks></remarks>
        FlexibleDiskette

        ''' <summary>
        ''' 1496.
        ''' </summary>
        ''' <remarks></remarks>
        _1496

        ''' <summary>
        ''' SCSI Parallel Interface.
        ''' </summary>
        ''' <remarks></remarks>
        SCSIParallelInterface

        ''' <summary>
        ''' SCSI Fibre Channel Protocol.
        ''' </summary>
        ''' <remarks></remarks>
        SCSIFibreChannelProtocol

        ''' <summary>
        ''' SCSI Serial Bus Protocol.
        ''' </summary>
        ''' <remarks></remarks>
        SCSISerialBusProtocol

        ''' <summary>
        ''' SCSI Serial Bus Protocol-2 (1394).
        ''' </summary>
        ''' <remarks></remarks>
        SCSISerialBusProtocol2

        ''' <summary>
        ''' SCSI Serial Storage Architecture.
        ''' </summary>
        ''' <remarks></remarks>
        SCSISerialStorageArchitecture

        ''' <summary>
        ''' VESA.
        ''' </summary>
        ''' <remarks></remarks>
        VESA

        ''' <summary>
        ''' PCMCIA.
        ''' </summary>
        ''' <remarks></remarks>
        PCMCIA

        ''' <summary>
        ''' Universal Serial Bus.
        ''' </summary>
        ''' <remarks></remarks>
        USB

        ''' <summary>
        ''' Parallel Protocol.
        ''' </summary>
        ''' <remarks></remarks>
        ParallelProtocol

        ''' <summary>
        ''' ESCON.
        ''' </summary>
        ''' <remarks></remarks>
        ESCON

        ''' <summary>
        ''' Diagnostic.
        ''' </summary>
        ''' <remarks></remarks>
        Diagnostic

        ''' <summary>
        ''' I2C.
        ''' </summary>
        ''' <remarks></remarks>
        I2C

        ''' <summary>
        ''' Power.
        ''' </summary>
        ''' <remarks></remarks>
        Power

        ''' <summary>
        ''' HIPPI.
        ''' </summary>
        ''' <remarks></remarks>
        HIPPI

        ''' <summary>
        ''' MultiBus.
        ''' </summary>
        ''' <remarks></remarks>
        MultiBus

        ''' <summary>
        ''' VME.
        ''' </summary>
        ''' <remarks></remarks>
        VME

        ''' <summary>
        ''' IPI.
        ''' </summary>
        ''' <remarks></remarks>
        IPI

        ''' <summary>
        ''' IEEE-488.
        ''' </summary>
        ''' <remarks></remarks>
        IEEE488

        ''' <summary>
        ''' RS232.
        ''' </summary>
        ''' <remarks></remarks>
        RS232

        ''' <summary>
        ''' IEEE 802.3 10BASE5.
        ''' </summary>
        ''' <remarks></remarks>
        IEEE802_3_10BASE5

        ''' <summary>
        ''' IEEE 802.3 10BASE2.
        ''' </summary>
        ''' <remarks></remarks>
        IEEE802_3_10BASE2

        ''' <summary>
        ''' IEEE 802.3 1BASE5.
        ''' </summary>
        ''' <remarks></remarks>
        IEEE802_3_1BASE5

        ''' <summary>
        ''' IEEE 802.3 10BROAD36.
        ''' </summary>
        ''' <remarks></remarks>
        IEEE_802_3_10BROAD36

        ''' <summary>
        ''' IEEE 802.3 100BASEVG.
        ''' </summary>
        ''' <remarks></remarks>
        IEEE_802_3_100BASEVG

        ''' <summary>
        ''' IEEE 802.5 Token-Ring.
        ''' </summary>
        ''' <remarks></remarks>
        IEEE802_5_TokenRing

        ''' <summary>
        ''' ANSI X3T9.5 FDDI.
        ''' </summary>
        ''' <remarks></remarks>
        ANSIX3T9_5FDDI

        ''' <summary>
        ''' MCA.
        ''' </summary>
        ''' <remarks></remarks>
        MCA

        ''' <summary>
        ''' ESDI.
        ''' </summary>
        ''' <remarks></remarks>
        ESDI

        ''' <summary>
        ''' IDE.
        ''' </summary>
        ''' <remarks></remarks>
        IDE

        ''' <summary>
        ''' CMD.
        ''' </summary>
        ''' <remarks></remarks>
        CMD

        ''' <summary>
        ''' ST506.
        ''' </summary>
        ''' <remarks></remarks>
        ST506

        ''' <summary>
        ''' DSSI.
        ''' </summary>
        ''' <remarks></remarks>
        DSSI

        ''' <summary>
        ''' QIC2.
        ''' </summary>
        ''' <remarks></remarks>
        QIC2

        ''' <summary>
        ''' Enhanced ATA/IDE.
        ''' </summary>
        ''' <remarks></remarks>
        EnhancedATAIDE

        ''' <summary>
        ''' AGP.
        ''' </summary>
        ''' <remarks></remarks>
        AGP

        ''' <summary>
        ''' TWIRP (two-way infrared).
        ''' </summary>
        ''' <remarks></remarks>
        TWIRP

        ''' <summary>
        ''' FIR (fast infrared).
        ''' </summary>
        ''' <remarks></remarks>
        FIR

        ''' <summary>
        ''' SIR (serial infrared)
        ''' </summary>
        ''' <remarks></remarks>
        SIR

        ''' <summary>
        ''' IrBus.
        ''' </summary>
        ''' <remarks></remarks>
        IrBus

    End Enum

End Namespace
