Imports System.Management

''' <summary>
''' Represents the type of integrated circuit hardware, including ASICs, processors, memory chips, and so on.
''' </summary>
''' <remarks>
''' <para>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa387207.aspx">MSDN</a>
''' </para>
''' </remarks>
Public MustInherit Class CIM_Chip
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
    ''' Implementation form factor for the chip.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property FormFactor() As Enums.FormFactor
        Get
            Dim obj As Object = GetPropertyObject("FormFactor")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.FormFactor)
            End If
        End Get
    End Property

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.CIM_Chip"></see>.
''' </summary>
''' <remarks></remarks>
Public MustInherit Class CIM_Chips
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



Namespace Enums

    ''' <summary>
    ''' Implementation form factor for the chip.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum FormFactor As UInt16


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
        ''' SIP.
        ''' </summary>
        ''' <remarks></remarks>
        SIP

        ''' <summary>
        ''' DIP.
        ''' </summary>
        ''' <remarks></remarks>
        DIP

        ''' <summary>
        ''' ZIP.
        ''' </summary>
        ''' <remarks></remarks>
        ZIP

        ''' <summary>
        ''' SOJ.
        ''' </summary>
        ''' <remarks></remarks>
        SOJ

        ''' <summary>
        ''' Proprietary.
        ''' </summary>
        ''' <remarks></remarks>
        Proprietary

        ''' <summary>
        ''' SIMM.
        ''' </summary>
        ''' <remarks></remarks>
        SIMM

        ''' <summary>
        ''' DIMM.
        ''' </summary>
        ''' <remarks></remarks>
        DIMM

        ''' <summary>
        ''' TSOP.
        ''' </summary>
        ''' <remarks></remarks>
        TSOP

        ''' <summary>
        ''' PGA.
        ''' </summary>
        ''' <remarks></remarks>
        PGA

        ''' <summary>
        ''' RIMM.
        ''' </summary>
        ''' <remarks></remarks>
        RIMM

        ''' <summary>
        ''' SODIMM.
        ''' </summary>
        ''' <remarks></remarks>
        SODIMM

        ''' <summary>
        ''' SRIMM.
        ''' </summary>
        ''' <remarks></remarks>
        SRIMM

        ''' <summary>
        ''' SMD.
        ''' </summary>
        ''' <remarks></remarks>
        SMD

        ''' <summary>
        ''' SSMP.
        ''' </summary>
        ''' <remarks></remarks>
        SSMP

        ''' <summary>
        ''' QFP.
        ''' </summary>
        ''' <remarks></remarks>
        QFP

        ''' <summary>
        ''' TQFP.
        ''' </summary>
        ''' <remarks></remarks>
        TQFP

        ''' <summary>
        ''' SOIC.
        ''' </summary>
        ''' <remarks></remarks>
        SOIC

        ''' <summary>
        ''' LCC.
        ''' </summary>
        ''' <remarks></remarks>
        LCC

        ''' <summary>
        ''' PLCC.
        ''' </summary>
        ''' <remarks></remarks>
        PLCC

        ''' <summary>
        ''' BGA.
        ''' </summary>
        ''' <remarks></remarks>
        BGA

        ''' <summary>
        ''' FPBGA.
        ''' </summary>
        ''' <remarks></remarks>
        FPBGA

        ''' <summary>
        ''' LGA.
        ''' </summary>
        ''' <remarks></remarks>
        LGA

    End Enum

End Namespace
