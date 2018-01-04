Imports System.Management

''' <summary>
''' Represents common adapter devices built into the motherboard (system board).
''' </summary>
''' <remarks>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa394238.aspx">MSDN</a>
''' </remarks>
Public Class Win32_OnBoardDevice
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
    ''' Type of device being represented.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property DeviceType() As Enums.DeviceType
        Get
            Dim obj As Object = GetPropertyObject("DeviceType")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.DeviceType)
            End If
        End Get
    End Property

    ''' <summary>
    ''' If TRUE, the on-board device is available for use.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Enabled() As Boolean
        Get
            Return GetBooleanProperty("Enabled")
        End Get
    End Property

#End Region

End Class

''' <summary>
''' Collection of <see cref="T:WMIwrapper.Win32_OnBoardDevice"></see>.
''' </summary>
''' <remarks></remarks>
Public Class Win32_OnBoardDevices
    Inherits CIM_PhysicalComponents

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <param name="Tag">If specified, only the item corresponding to this key value is returned. Ignored if <code>Condition</code> is set.</param>
    ''' <param name="Condition">WQL condition can be specified. It is not checked and sent to WMI as is.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Computer As String, Optional ByVal Tag As String = Nothing, Optional ByVal Condition As String = Nothing)

        MyBase.New(Computer, "Win32_OnBoardDevice")
        ' Prepare condition
        If Condition Is Nothing AndAlso Tag IsNot Nothing Then
            Condition = "Tag ='" & Tag & "'"
        End If
        ' Read the collection
        For Each ManagementObjectI As ManagementObject In Me.Read(Condition)
            Me.Add(New Win32_OnBoardDevice(ManagementObjectI))
        Next

    End Sub

    ''' <summary>
    ''' Find an item in the collection.
    ''' </summary>
    ''' <param name="index">Index of the item.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal index As Integer) As Win32_OnBoardDevice
        Return CType(List.Item(index), Win32_OnBoardDevice)
    End Function

    ''' <summary>
    ''' Find an item by its tag.
    ''' </summary>
    ''' <param name="Tag">The item's tag.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal Tag As String) As Win32_OnBoardDevice
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
    ''' Type of device being represented.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum DeviceType As UInt16

        ''' <summary>
        ''' Other.
        ''' </summary>
        ''' <remarks></remarks>
        Other = 1

        ''' <summary>
        ''' Unknown.
        ''' </summary>
        ''' <remarks></remarks>
        Unknown

        ''' <summary>
        ''' Video.
        ''' </summary>
        ''' <remarks></remarks>
        Video

        ''' <summary>
        ''' SCSI Controller.
        ''' </summary>
        ''' <remarks></remarks>
        SCSIController

        ''' <summary>
        ''' Ethernet.
        ''' </summary>
        ''' <remarks></remarks>
        Ethernet

        ''' <summary>
        ''' Token Ring.
        ''' </summary>
        ''' <remarks></remarks>
        TokenRing

        ''' <summary>
        ''' Sound.
        ''' </summary>
        ''' <remarks></remarks>
        Sound

    End Enum

End Namespace
