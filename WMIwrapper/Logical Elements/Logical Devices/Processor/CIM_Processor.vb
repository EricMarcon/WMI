Imports System.Management

''' <summary>
''' Represents the capabilities and management of the battery logical device.
''' </summary>
''' <remarks>
''' This class applies to batteries in laptop systems and other internal and external batteries. 
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa387189.aspx">MSDN</a>
''' </remarks>
Public MustInherit Class CIM_Processor
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
    ''' Processor address width, in bits. This represents the size of a pointer type on the processor.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>On a 32-bit processor, the value is 32 and on a 64-bit processor it is 64.</remarks>
    Public ReadOnly Property AddressWidth() As UInt16
        Get
            Return GetUint16Property("AddressWidth")
        End Get
    End Property

    ''' <summary>
    ''' Current speed of the processor, in MHz.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property CurrentClockSpeed() As UInt32
        Get
            Return GetUint32Property("CurrentClockSpeed")
        End Get
    End Property

    ''' <summary>
    ''' Processor data width, in bits. 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property DataWidth() As UInt16
        Get
            Return GetUint16Property("DataWidth")
        End Get
    End Property

    ''' <summary>
    ''' Processor family type.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Family() As Enums.Family
        Get
            Dim obj As Object = GetPropertyObject("Family")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.Family)
            End If
        End Get
    End Property

    ''' <summary>
    ''' Load capacity of each processor, averaged to the last second.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Processor loading refers to the total computing burden for each processor at one time.</remarks>
    Public ReadOnly Property LoadPercentage() As UInt16
        Get
            Return GetUint16Property("LoadPercentage")
        End Get
    End Property

    ''' <summary>
    ''' Maximum speed of the processor, in MHz.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property MaxClockSpeed() As UInt32
        Get
            Return GetUint32Property("MaxClockSpeed")
        End Get
    End Property

    ''' <summary>
    ''' Processor family type.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Used when the Family property is set to 1, which means Other. This string should be set to NULL when the Family property is a value that is not 1.</remarks>
    Public ReadOnly Property OtherFamilyDescription() As String
        Get
            Return GetStringProperty("OtherFamilyDescription")
        End Get
    End Property

    ''' <summary>
    ''' Role of the processor.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Examples: Central Processor or Math Processor</remarks>
    Public ReadOnly Property Role() As String
        Get
            Return GetStringProperty("Role")
        End Get
    End Property

    ''' <summary>
    ''' Revision level of the processor in the processor family.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Stepping() As String
        Get
            Return GetStringProperty("Stepping")
        End Get
    End Property

    ''' <summary>
    ''' Globally unique identifier for the processor.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>This identifier may only be unique within a processor family.</remarks>
    Public ReadOnly Property UniqueId() As String
        Get
            Return GetStringProperty("UniqueId")
        End Get
    End Property

    ''' <summary>
    ''' CPU socket information, including the method by which this processor can be upgraded, if upgrades are supported.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property UpgradeMethod() As Enums.UpgradeMethod
        Get
            Dim obj As Object = GetPropertyObject("UpgradeMethod")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.UpgradeMethod)
            End If
        End Get
    End Property

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.CIM_Processor"></see>.
''' </summary>
''' <remarks></remarks>
Public MustInherit Class CIM_Processors
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
