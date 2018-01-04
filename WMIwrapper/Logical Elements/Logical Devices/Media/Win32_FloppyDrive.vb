Imports System.Management

''' <summary>
''' Floppy drive.
''' </summary>
''' <remarks>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa394149.aspx">MSDN</a>
''' </remarks>
Public Class Win32_FloppyDrive
    Inherits CIM_MediaAccessDevice

    ''' <summary>
    ''' Constructor. 
    ''' </summary>
    ''' <param name="ManagementObject">The underlying management object.</param>
    ''' <remarks>Use this constructor when the management object already exists (e.g. read from a collection).</remarks>
    Public Sub New(ByVal ManagementObject As ManagementObject)
        MyBase.New(ManagementObject)
    End Sub

    ''' <summary>
    ''' Name of the manufacturer of the floppy disk drive.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Manufacturer() As String
        Get
            Return GetStringProperty("Manufacturer")
        End Get
    End Property

 End Class

''' <summary>
''' Collection of <see cref="T:WMIwrapper.Win32_FloppyDrive"></see>.
''' </summary>
''' <remarks></remarks>
Public Class Win32_FloppyDrives
    Inherits CIM_MediaAccessDevices

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <param name="DeviceID">If specified, only the item corresponding to this key value is returned. Ignored if <code>Condition</code> is set.</param>
    ''' <param name="Condition">WQL condition can be specified. It is not checked and sent to WMI as is.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Computer As String, Optional ByVal DeviceID As String = Nothing, Optional ByVal Condition As String = Nothing)

        MyBase.New(Computer, "Win32_FloppyDrive")
        ' Prepare condition
        If Condition Is Nothing AndAlso DeviceID IsNot Nothing Then
            Condition = "DeviceID ='" & DeviceID & "'"
        End If
        ' Read the collection
        For Each ManagementObjectI As ManagementObject In Me.Read(Condition)
            Me.Add(New Win32_FloppyDrive(ManagementObjectI))
        Next

    End Sub

    ''' <summary>
    ''' Find an item in the collection.
    ''' </summary>
    ''' <param name="index">Index of the item.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal index As Integer) As Win32_FloppyDrive
        Return CType(List.Item(index), Win32_FloppyDrive)
    End Function

    ''' <summary>
    ''' Find an item by its ID.
    ''' </summary>
    ''' <param name="DeviceID">The device ID.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal DeviceID As String) As Win32_FloppyDrive
        For intI As Integer = 0 To List.Count - 1
            If Me.Item(intI).DeviceID = DeviceID Then
                Return Me.Item(intI)
            End If
        Next
        Return Nothing
    End Function

End Class