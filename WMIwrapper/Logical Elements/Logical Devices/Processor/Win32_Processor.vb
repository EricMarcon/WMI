Imports System.Management

''' <summary>
''' Processor.
''' </summary>
''' <remarks>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa394373.aspx">MSDN.</a>
''' </remarks>
Public Class Win32_Processor
    Inherits CIM_Processor

    ''' <summary>
    ''' Constructor. 
    ''' </summary>
    ''' <param name="ManagementObject">The underlying management object.</param>
    ''' <remarks>Use this constructor when the management object already exists (e.g. read from a collection).</remarks>
    Public Sub New(ByVal ManagementObject As ManagementObject)
        MyBase.New(ManagementObject)
    End Sub

#Region "Properties"

    ''' <summary>
    ''' Processor architecture used by the platform.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Architecture() As Enums.Architecture
        Get
            Dim obj As Object = GetPropertyObject("Architecture")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.Architecture)
            End If
        End Get
    End Property

    ''' <summary>
    ''' Current status of the processor.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Status changes indicate processor usage, but not the physical condition of the processor.</remarks>
    Public ReadOnly Property CpuStatus() As Enums.CpuStatus
        Get
            Dim obj As Object = GetPropertyObject("CpuStatus")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.CpuStatus)
            End If
        End Get
    End Property

    ''' <summary>
    ''' Voltage of the processor. 
    ''' </summary>
    ''' <value></value>
    ''' <returns>The current processor voltage in Volts</returns>
    ''' <remarks>WMI property is Uint16.
    ''' If the eighth bit is set, bits 0-6 contain the voltage multiplied by 10.
    ''' If the eighth bit is not set, then the bit setting in VoltageCaps represents the voltage value.
    ''' CurrentVoltage is only set when SMBIOS designates a voltage value.
    ''' Note: It seems that MSDN documentation about 8th but is wrong. Divide by 10 when the bit is NOT set.
    ''' </remarks>
    Public ReadOnly Property CurrentVoltage() As Double
        Get
            Dim _CurrentVoltage As UInt16 = GetUint16Property("CurrentVoltage")
            If (_CurrentVoltage And 256) = 0 Then
                Return (_CurrentVoltage And Not 256) / 10
            Else
                Return _CurrentVoltage
            End If
        End Get
    End Property

    ''' <summary>
    ''' External clock frequency, in MHz.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ExtClock() As UInt32
        Get
            Return GetUint32Property("ExtClock")
        End Get
    End Property

    ''' <summary>
    ''' Size of the Level 2 processor cache. 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>A Level 2 cache is an external memory area that has a faster access time than the main RAM memory.</remarks>
    Public ReadOnly Property L2CacheSize() As UInt32
        Get
            Return GetUint32Property("L2CacheSize")
        End Get
    End Property

    ''' <summary>
    ''' Clock speed of the Level 2 processor cache.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>A Level 2 cache is an external memory area that has a faster access time than the main RAM memory.</remarks>
    Public ReadOnly Property L2CacheSpeed() As UInt32
        Get
            Return GetUint32Property("L2CacheSpeed")
        End Get
    End Property

    ''' <summary>
    ''' Size of the Level 3 property cache.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Windows Server 2003, Windows XP, and Windows 2000:  This property is not available.</remarks>
    Public ReadOnly Property L3CacheSize() As UInt32
        Get
            Return GetUint32Property("L3CacheSize")
        End Get
    End Property

    ''' <summary>
    ''' Clockspeed of the Level 3 property cache.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Windows Server 2003, Windows XP, and Windows 2000:  This property is not available.</remarks>
    Public ReadOnly Property L3CacheSpeed() As UInt32
        Get
            Return GetUint32Property("L3CacheSize")
        End Get
    End Property

    ''' <summary>
    ''' Definition of the processor type.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>The value depends on the architecture of the processor.</remarks>
    Public ReadOnly Property Level() As UInt16
        Get
            Return GetUint16Property("Level")
        End Get
    End Property

    ''' <summary>
    ''' Name of the processor manufacturer.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Manufacturer() As String
        Get
            Return GetStringProperty("Manufacturer")
        End Get
    End Property

    ''' <summary>
    ''' Number of cores for the current instance of the processor.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' <para>A core is a physical processor on the integrated circuit. For example, in a dual-core processor this property has a value of 2.
    ''' </para>
    ''' <para>Windows Server 2003, Windows XP, and Windows 2000:  This property is not available.</para>
    ''' </remarks>
    Public ReadOnly Property NumberOfCores() As UInt32
        Get
            Return GetUint32Property("NumberOfCores")
        End Get
    End Property

    ''' <summary>
    ''' Number of logical processors for the current instance of the processor.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' <para>For processors capable of hyperthreading, this value includes only the processors which have hyperthreading enabled.
    ''' </para>
    ''' <para>Windows Server 2003, Windows XP, and Windows 2000:  This property is not available.</para>
    ''' </remarks>
    Public ReadOnly Property NumberOfLogicalProcessors() As UInt32
        Get
            Return GetUint32Property("NumberOfLogicalProcessors")
        End Get
    End Property

    ''' <summary>
    ''' Processor information that describes the processor features.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' For an x86 class CPU, the field format depends on the processor support of the CPUID instruction.
    ''' If the instruction is supported, the property contains 2 (two) DWORD formatted values.
    ''' The first is an offset of 08h-0Bh, which is the EAX value that a CPUID instruction returns with input EAX set to 1.
    ''' The second is an offset of 0Ch-0Fh, which is the EDX value that the instruction returns.
    ''' Only the first two bytes of the property are significant and contain the contents of the DX register at CPU reset—all others are set to 0 (zero),
    ''' and the contents are in DWORD format.
    ''' </remarks>
    Public ReadOnly Property ProcessorId() As String
        Get
            Return GetStringProperty("ProcessorId")
        End Get
    End Property

    ''' <summary>
    ''' Primary function of the processor.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ProcessorType() As Enums.ProcessorType
        Get
            Dim obj As Object = GetPropertyObject("ProcessorType")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.ProcessorType)
            End If
        End Get
    End Property

    ''' <summary>
    ''' System revision level that depends on the architecture.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>The system revision level contains the same values as the Version property, but in a numerical format.</remarks>
    Public ReadOnly Property Revision() As UInt16
        Get
            Return GetUint16Property("Revision")
        End Get
    End Property

    ''' <summary>
    ''' Type of chip socket used on the circuit.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Example: J202.</remarks>
    Public ReadOnly Property SocketDesignation() As String
        Get
            Return GetStringProperty("SocketDesignation")
        End Get
    End Property

    ''' <summary>
    ''' Processor revision number that depends on the architecture.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Version() As String
        Get
            Return GetStringProperty("Version")
        End Get
    End Property

    ''' <summary>
    ''' Voltage capabilities of the processor.
    ''' </summary>
    ''' <remarks>
    ''' Bits 0-3 of the field represent specific voltages that the processor socket can accept.
    ''' All other bits should be set to 0 (zero). The socket is configurable if multiple bits are set.
    ''' For more information about the actual voltage at which the processor is running, see CurrentVoltage.
    ''' If the property is NULL, then the voltage capabilities are unknown.
    ''' </remarks>
    Public ReadOnly Property VoltageCaps() As Enums.VoltageCaps
        Get
            Dim obj As Object = GetPropertyObject("VoltageCaps")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.VoltageCaps)
            End If
        End Get
    End Property

#End Region

End Class


''' <summary>
''' Collection of <see cref="T:WMIwrapper.Win32_Processor"></see>.
''' </summary>
''' <remarks></remarks>
Public Class Win32_Processors
    Inherits CIM_Processors

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <param name="DeviceID">If specified, only the item corresponding to this key value is returned. Ignored if <code>Condition</code> is set.</param>
    ''' <param name="Condition">WQL condition can be specified. It is not checked and sent to WMI as is.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Computer As String, Optional ByVal DeviceID As String = Nothing, Optional ByVal Condition As String = Nothing)

        MyBase.New(Computer, "Win32_processor")
        ' Prepare condition
        If Condition Is Nothing AndAlso DeviceID IsNot Nothing Then
            Condition = "DeviceID ='" & DeviceID & "'"
        End If
        ' Read the collection
        For Each ManagementObjectI As ManagementObject In Me.Read(Condition)
            Me.Add(New Win32_Processor(ManagementObjectI))
        Next

    End Sub

    ''' <summary>
    ''' Find an item in the collection.
    ''' </summary>
    ''' <param name="index">Index of the item.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal index As Integer) As Win32_Processor
        Return CType(List.Item(index), Win32_Processor)
    End Function

    ''' <summary>
    ''' Find an item by its ID.
    ''' </summary>
    ''' <param name="DeviceID">The device ID.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal DeviceID As String) As Win32_Processor
        For intI As Integer = 0 To List.Count - 1
            If Me.Item(intI).DeviceID = DeviceID Then
                Return Me.Item(intI)
            End If
        Next
        Return Nothing
    End Function

  End Class



Namespace Enums

    ''' <summary>
    ''' Processor architecture used by the platform.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum Architecture As UInt16

        ''' <summary>
        ''' x86
        ''' </summary>
        ''' <remarks></remarks>
        x86 = 0

        ''' <summary>
        ''' MIPS
        ''' </summary>
        ''' <remarks></remarks>
        MIPS = 1

        ''' <summary>
        ''' Alpha
        ''' </summary>
        ''' <remarks></remarks>
        Alpha = 2

        ''' <summary>
        ''' PowerPC 
        ''' </summary>
        ''' <remarks></remarks>
        PowerPC = 3

        ''' <summary>
        ''' Intel Itanium Processor Family
        ''' </summary>
        ''' <remarks></remarks>
        IPF = 6

        ''' <summary>
        ''' x64
        ''' </summary>
        ''' <remarks></remarks>
        x64 = 9

    End Enum

    ''' <summary>
    ''' Current status of the processor. Status changes indicate processor usage, but not the physical condition of the processor.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum CpuStatus As UInt16

        ''' <summary>
        ''' Unknown
        ''' </summary>
        ''' <remarks></remarks>
        Unknown = 0

        ''' <summary>
        ''' CPU Enabled.
        ''' </summary>
        ''' <remarks></remarks>
        Enabled = 1

        ''' <summary>
        '''  CPU Disabled by User via BIOS Setup.
        ''' </summary>
        ''' <remarks></remarks>
        DisabledByUser = 2

        ''' <summary>
        ''' CPU Disabled by BIOS (POST Error).
        ''' </summary>
        ''' <remarks></remarks>
        DisabledByBIOS = 4

        ''' <summary>
        ''' CPU Is Idle.
        ''' </summary>
        ''' <remarks></remarks>
        Idle = 4

        ''' <summary>
        ''' Reserved.
        ''' </summary>
        ''' <remarks></remarks>
        Reserved5 = 5

        ''' <summary>
        ''' Reserved.
        ''' </summary>
        ''' <remarks></remarks>
        Reserved6 = 6

        ''' <summary>
        ''' Other.
        ''' </summary>
        ''' <remarks></remarks>
        Other = 7

    End Enum

    ''' <summary>
    ''' Processor family type.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum Family As UInt16

        ''' <summary>
        ''' No data: method returned 0.
        ''' </summary>
        ''' <remarks></remarks>
        NoData = 0

        ''' <summary>
        ''' Other
        ''' </summary>
        ''' <remarks></remarks>
        Other = 1

        ''' <summary>
        ''' Unknown
        ''' </summary>
        ''' <remarks></remarks>
        Unknown = 2

        ''' <summary>
        ''' 8086.
        ''' </summary>
        ''' <remarks></remarks>
        _8086 = 3

        ''' <summary>
        ''' 80286.
        ''' </summary>
        ''' <remarks></remarks>
        _80286 = 4

        ''' <summary>
        ''' Intel386™ Processor.
        ''' </summary>
        ''' <remarks></remarks>
        i386 = 5

        ''' <summary>
        ''' Intel486™ Processor.
        ''' </summary>
        ''' <remarks></remarks>
        i486 = 6

        ''' <summary>
        ''' 8087.
        ''' </summary>
        ''' <remarks></remarks>
        _8087 = 7

        ''' <summary>
        ''' 80287.
        ''' </summary>
        ''' <remarks></remarks>
        _80287 = 8

        ''' <summary>
        ''' 80387.
        ''' </summary>
        ''' <remarks></remarks>
        _80387 = 9

        ''' <summary>
        ''' 80487.
        ''' </summary>
        ''' <remarks></remarks>
        _80487 = 10

        ''' <summary>
        '''  Pentium Brand.
        ''' </summary>
        ''' <remarks></remarks>
        Pentium = 11

        ''' <summary>
        ''' Pentium Pro.
        ''' </summary>
        ''' <remarks></remarks>
        PentiumPro = 12

        ''' <summary>
        ''' Pentium II.
        ''' </summary>
        ''' <remarks></remarks>
        PentiumII = 13

        ''' <summary>
        ''' Pentium Processor with MMX™ Technology.
        ''' </summary>
        ''' <remarks></remarks>
        PentiumMMX = 14

        ''' <summary>
        ''' Celeron™.
        ''' </summary>
        ''' <remarks></remarks>
        Celeron = 15

        ''' <summary>
        ''' Pentium II Xeon™.
        ''' </summary>
        ''' <remarks></remarks>
        PIIXeon = 16

        ''' <summary>
        ''' Pentium III.
        ''' </summary>
        ''' <remarks></remarks>
        PIII = 17

        ''' <summary>
        ''' M1 Family.
        ''' </summary>
        ''' <remarks></remarks>
        M1 = 18

        ''' <summary>
        '''  M2 Family.
        ''' </summary>
        ''' <remarks></remarks>
        M2 = 19

        ''' <summary>
        '''  AMD Duron™ Processor Family.
        ''' </summary>
        ''' <remarks></remarks>
        Duron = 24

        ''' <summary>
        '''  K5 Family.
        ''' </summary>
        ''' <remarks></remarks>
        K5 = 25

        ''' <summary>
        ''' K6 Family.
        ''' </summary>
        ''' <remarks></remarks>
        K6 = 26

        ''' <summary>
        '''  K6-2.
        ''' </summary>
        ''' <remarks></remarks>
        K6_2 = 27


        ''' <summary>
        '''  K6-3.
        ''' </summary>
        ''' <remarks></remarks>
        K6_3 = 28

        ''' <summary>
        ''' AMD Athlon™ Processor Family.
        ''' </summary>
        ''' <remarks></remarks>
        Athlon = 29

        ''' <summary>
        ''' AMD2900 Family.
        ''' </summary>
        ''' <remarks></remarks>
        AMD2900 = 30

        ''' <summary>
        '''  K6-2+.
        ''' </summary>
        ''' <remarks></remarks>
        K6_2Plus = 31


        ''' <summary>
        ''' Power PC Family.
        ''' </summary>
        ''' <remarks></remarks>
        PowerPC = 32

        ''' <summary>
        '''  Power PC 603.
        ''' </summary>
        ''' <remarks></remarks>
        PowerPC603 = 34

        ''' <summary>
        ''' Power PC 603+.
        ''' </summary>
        ''' <remarks></remarks>
        PowerPC603Plus = 35

        ''' <summary>
        '''  Power PC 604.
        ''' </summary>
        ''' <remarks></remarks>
        PowerPC604 = 36

        ''' <summary>
        '''  Power PC 620.
        ''' </summary>
        ''' <remarks></remarks>
        PowerPC620 = 37

        ''' <summary>
        '''  Power PC X704.
        ''' </summary>
        ''' <remarks></remarks>
        PowerPCX704 = 38

        ''' <summary>
        '''  Power PC 750.
        ''' </summary>
        ''' <remarks></remarks>
        PowerPCX750 = 39

        ''' <summary>
        ''' Alpha Family.
        ''' </summary>
        ''' <remarks></remarks>
        Alpha = 48

        ''' <summary>
        ''' Alpha 21064.
        ''' </summary>
        ''' <remarks></remarks>
        Alpha21064 = 49

        ''' <summary>
        ''' Alpha 21066.
        ''' </summary>
        ''' <remarks></remarks>
        Alpha21066 = 50

        ''' <summary>
        ''' Alpha 21164.
        ''' </summary>
        ''' <remarks></remarks>
        Alpha21164 = 51

        ''' <summary>
        ''' Alpha 21164PC.
        ''' </summary>
        ''' <remarks></remarks>
        Alpha21164PC = 52

        ''' <summary>
        ''' Alpha 21164a .
        ''' </summary>
        ''' <remarks></remarks>
        Alpha21164a = 53

        ''' <summary>
        ''' Alpha 21264.
        ''' </summary>
        ''' <remarks></remarks>
        Alpha21264 = 54

        ''' <summary>
        ''' Alpha 21364.
        ''' </summary>
        ''' <remarks></remarks>
        Alpha21364 = 55

        ''' <summary>
        ''' MIPS Family.
        ''' </summary>
        ''' <remarks></remarks>
        MIPS = 64

        ''' <summary>
        ''' MIPS Family R4000.
        ''' </summary>
        ''' <remarks></remarks>
        MIPSR4000 = 65

        ''' <summary>
        ''' MIPS R4200.
        ''' </summary>
        ''' <remarks></remarks>
        MIPSR4200 = 66

        ''' <summary>
        ''' MIPS R4400.
        ''' </summary>
        ''' <remarks></remarks>
        MIPSR4400 = 67

        ''' <summary>
        ''' MIPS Family R4600.
        ''' </summary>
        ''' <remarks></remarks>
        MIPSR4600 = 68

        ''' <summary>
        ''' MIPS Family R10000.
        ''' </summary>
        ''' <remarks></remarks>
        MIPSR10000 = 69

        ''' <summary>
        ''' SPARC Family.
        ''' </summary>
        ''' <remarks></remarks>
        SPARC = 80

        ''' <summary>
        ''' SuperSPARC.
        ''' </summary>
        ''' <remarks></remarks>
        SuperSPARC = 81

        ''' <summary>
        ''' microSPARC II.
        ''' </summary>
        ''' <remarks></remarks>
        microSPARCII = 82

        ''' <summary>
        ''' microSPARC IIep.
        ''' </summary>
        ''' <remarks></remarks>
        microSPARCIIep = 83

        ''' <summary>
        ''' UltraSPARC.
        ''' </summary>
        ''' <remarks></remarks>
        UltraSPARC = 84

        ''' <summary>
        ''' UltraSPARC II.
        ''' </summary>
        ''' <remarks></remarks>
        UltraSPARCII = 85

        ''' <summary>
        ''' UltraSPARC IIi.
        ''' </summary>
        ''' <remarks></remarks>
        UltraSPARCII_i = 86

        ''' <summary>
        ''' UltraSPARC III.
        ''' </summary>
        ''' <remarks></remarks>
        UltraSPARCIII = 87

        ''' <summary>
        ''' UltraSPARC IIIi.
        ''' </summary>
        ''' <remarks></remarks>
        UltraSPARCIII_i = 88

        ''' <summary>
        ''' 68040.
        ''' </summary>
        ''' <remarks></remarks>
        _68040 = 96

        ''' <summary>
        ''' 68xxx Family.
        ''' </summary>
        ''' <remarks></remarks>
        _68xxx = 97

        ''' <summary>
        ''' 68000.
        ''' </summary>
        ''' <remarks></remarks>
        _68000 = 98

        ''' <summary>
        ''' 68010.
        ''' </summary>
        ''' <remarks></remarks>
        _68010 = 99

        ''' <summary>
        ''' 68020.
        ''' </summary>
        ''' <remarks></remarks>
        _68020 = 100

        ''' <summary>
        ''' 68030.
        ''' </summary>
        ''' <remarks></remarks>
        _68030 = 101

        ''' <summary>
        ''' Hobbit Family.
        ''' </summary>
        ''' <remarks></remarks>
        Hobbit = 112

        ''' <summary>
        ''' Crusoe™ TM5000 Family.
        ''' </summary>
        ''' <remarks></remarks>
        CrusoeTM5000 = 120

        ''' <summary>
        ''' Crusoe™ TM3000 Family.
        ''' </summary>
        ''' <remarks></remarks>
        CrusoeTM3000 = 121

        ''' <summary>
        ''' Efficeon™ TM8000.
        ''' </summary>
        ''' <remarks></remarks>
        EfficeonTM8000 = 122

        ''' <summary>
        ''' Weitek.
        ''' </summary>
        ''' <remarks></remarks>
        Weitek = 128

        ''' <summary>
        ''' Itanium™ Processor.
        ''' </summary>
        ''' <remarks></remarks>
        Itanium = 130

        ''' <summary>
        ''' AMD Athlon™ 64 Processor Family.
        ''' </summary>
        ''' <remarks></remarks>
        Athlon64 = 131

        ''' <summary>
        ''' AMD Opteron™ Processor Family.
        ''' </summary>
        ''' <remarks></remarks>
        Opteron = 132

        ''' <summary>
        ''' PA-RISC Family.
        ''' </summary>
        ''' <remarks></remarks>
        PA_RISC = 144

        ''' <summary>
        ''' PA-RISC 8500.
        ''' </summary>
        ''' <remarks></remarks>
        PA_RISC8500 = 145

        ''' <summary>
        ''' PA-RISC 8000.
        ''' </summary>
        ''' <remarks></remarks>
        PA_RISC8000 = 146

        ''' <summary>
        ''' PA-RISC 7300LC.
        ''' </summary>
        ''' <remarks></remarks>
        PA_RISC7300LC = 147

        ''' <summary>
        ''' PA-RISC 7200.
        ''' </summary>
        ''' <remarks></remarks>
        PA_RISC7200 = 148

        ''' <summary>
        ''' PA-RISC 7100LC.
        ''' </summary>
        ''' <remarks></remarks>
        PA_RISC7100LC = 149

        ''' <summary>
        ''' PA-RISC 7100.
        ''' </summary>
        ''' <remarks></remarks>
        PA_RISC7100 = 150

        ''' <summary>
        ''' V30 Family.
        ''' </summary>
        ''' <remarks></remarks>
        V30 = 160

        ''' <summary>
        ''' Pentium III Xeon™ Processor.
        ''' </summary>
        ''' <remarks></remarks>
        PIIIXeon = 176

        ''' <summary>
        ''' Pentium III Processor with Intel SpeedStep™ Technology.
        ''' </summary>
        ''' <remarks></remarks>
        PIIIXeonSpeedStep = 177

        ''' <summary>
        ''' Pentium 4.
        ''' </summary>
        ''' <remarks></remarks>
        P4 = 178

        ''' <summary>
        ''' Intel Xeon™.
        ''' </summary>
        ''' <remarks></remarks>
        Xeon = 179

        ''' <summary>
        ''' AS400 Family.
        ''' </summary>
        ''' <remarks></remarks>
        AS400 = 180

        ''' <summary>
        ''' Intel Xeon™ Processor MP.
        ''' </summary>
        ''' <remarks></remarks>
        XeonMP = 181

        ''' <summary>
        ''' AMD Athlon™ XP Family.
        ''' </summary>
        ''' <remarks></remarks>
        AthlonXP = 182

        ''' <summary>
        ''' AMD Athlon™ MP Family.
        ''' </summary>
        ''' <remarks></remarks>
        AthlonMP = 183

        ''' <summary>
        ''' Intel Itanium 2.
        ''' </summary>
        ''' <remarks></remarks>
        Itanum2 = 184

        ''' <summary>
        ''' Intel Pentium M Processor.
        ''' </summary>
        ''' <remarks></remarks>
        PentiumM = 185

        ''' <summary>
        ''' K7.
        ''' </summary>
        ''' <remarks></remarks>
        K7 = 190

        ''' <summary>
        ''' IBM390 Family.
        ''' </summary>
        ''' <remarks></remarks>
        IBM390 = 200

        ''' <summary>
        ''' G4.
        ''' </summary>
        ''' <remarks></remarks>
        G4 = 201

        ''' <summary>
        ''' G5.
        ''' </summary>
        ''' <remarks></remarks>
        G5 = 202

        ''' <summary>
        ''' G6.
        ''' </summary>
        ''' <remarks></remarks>
        G6 = 203

        ''' <summary>
        ''' z/Architecture Base.
        ''' </summary>
        ''' <remarks></remarks>
        z = 204

        ''' <summary>
        ''' i860.
        ''' </summary>
        ''' <remarks></remarks>
        i860 = 250

        ''' <summary>
        ''' i960.
        ''' </summary>
        ''' <remarks></remarks>
        i960 = 251

        ''' <summary>
        ''' SH-3.
        ''' </summary>
        ''' <remarks></remarks>
        SH3 = 260

        ''' <summary>
        ''' SH-4.
        ''' </summary>
        ''' <remarks></remarks>
        SH4 = 261

        ''' <summary>
        ''' ARM.
        ''' </summary>
        ''' <remarks></remarks>
        ARM = 280

        ''' <summary>
        ''' StrongARM.
        ''' </summary>
        ''' <remarks></remarks>
        StrongARM = 281

        ''' <summary>
        ''' 6x86.
        ''' </summary>
        ''' <remarks></remarks>
        _6x86 = 300

        ''' <summary>
        ''' MediaGX.
        ''' </summary>
        ''' <remarks></remarks>
        MediaGX = 301

        ''' <summary>
        ''' MII.
        ''' </summary>
        ''' <remarks></remarks>
        MII = 301

        ''' <summary>
        ''' WinChip.
        ''' </summary>
        ''' <remarks></remarks>
        WinChip = 320

        ''' <summary>
        ''' DSP.
        ''' </summary>
        ''' <remarks></remarks>
        DSP = 350

        ''' <summary>
        ''' Video Processor.
        ''' </summary>
        ''' <remarks></remarks>
        Video = 500

    End Enum

    ''' <summary>
    ''' Primary function of the processor.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum ProcessorType As UInt16

        ''' <summary>
        ''' No data: method returned 0.
        ''' </summary>
        ''' <remarks></remarks>
        NoData = 0

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
        ''' Central Processor.
        ''' </summary>
        ''' <remarks></remarks>
        CentralProcessor = 3

        ''' <summary>
        ''' Math Processor.
        ''' </summary>
        ''' <remarks></remarks>
        MathProcessor = 4

        ''' <summary>
        ''' DSP Processor.
        ''' </summary>
        ''' <remarks></remarks>
        DSPProcessor = 5

        ''' <summary>
        ''' Video Processor.
        ''' </summary>
        ''' <remarks></remarks>
        VideoProcessor = 6

    End Enum

    ''' <summary>
    ''' CPU socket information, including the method by which this processor can be upgraded, if upgrades are supported.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum UpgradeMethod As UInt16

        ''' <summary>
        ''' No data: method returned 0.
        ''' </summary>
        ''' <remarks></remarks>
        NoData = 0

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
        ''' Daughter Board.
        ''' </summary>
        ''' <remarks></remarks>
        DaughterBoard = 3

        ''' <summary>
        ''' ZIF Socket.
        ''' </summary>
        ''' <remarks></remarks>
        ZIFSocket = 4

        ''' <summary>
        ''' Replacement.
        ''' </summary>
        ''' <remarks></remarks>
        Replacement = 5

        ''' <summary>
        ''' Piggy Back.
        ''' </summary>
        ''' <remarks></remarks>
        PiggyBack = 5

        ''' <summary>
        ''' None.
        ''' </summary>
        ''' <remarks></remarks>
        None = 6

        ''' <summary>
        ''' LIF Socket.
        ''' </summary>
        ''' <remarks></remarks>
        LIFSocket = 7

        ''' <summary>
        ''' Slot 1.
        ''' </summary>
        ''' <remarks></remarks>
        Slot1 = 8

        ''' <summary>
        ''' Slot 2.
        ''' </summary>
        ''' <remarks></remarks>
        Slot2 = 9

        ''' <summary>
        ''' 370 Pin Socket.
        ''' </summary>
        ''' <remarks></remarks>
        _370PinSocket = 10

        ''' <summary>
        ''' Slot A.
        ''' </summary>
        ''' <remarks></remarks>
        SlotA = 11

        ''' <summary>
        ''' Slot M.
        ''' </summary>
        ''' <remarks></remarks>
        SlotM = 12

        ''' <summary>
        ''' Socket 423.
        ''' </summary>
        ''' <remarks></remarks>
        Socket423 = 13

        ''' <summary>
        ''' Socket A (Socket 462).
        ''' </summary>
        ''' <remarks></remarks>
        SocketA = 14

        ''' <summary>
        ''' Socket 478.
        ''' </summary>
        ''' <remarks></remarks>
        Socket478 = 15

        ''' <summary>
        ''' Socket 754.
        ''' </summary>
        ''' <remarks></remarks>
        Socket754 = 16

        ''' <summary>
        ''' Socket 940.
        ''' </summary>
        ''' <remarks></remarks>
        Socket940 = 17

        ''' <summary>
        ''' Socket 939.
        ''' </summary>
        ''' <remarks></remarks>
        Socket939 = 18

    End Enum

    ''' <summary>
    ''' Voltage capabilities of the processor.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum VoltageCaps As UInt32

        ''' <summary>
        ''' No data: method returned 0.
        ''' </summary>
        ''' <remarks></remarks>
        NoData = 0

        ''' <summary>
        ''' 5 volts.
        ''' </summary>
        ''' <remarks></remarks>
        _5V = 1

        ''' <summary>
        ''' 3.3 volts.
        ''' </summary>
        ''' <remarks></remarks>
        _3_3V = 2

        ''' <summary>
        ''' 2.9 volts 
        ''' </summary>
        ''' <remarks></remarks>
        _2_9V = 4

    End Enum

End Namespace
