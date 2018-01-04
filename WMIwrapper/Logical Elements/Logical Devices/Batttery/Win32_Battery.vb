Imports System.Management

''' <summary>
''' Battery.
''' </summary>
''' <remarks>
''' Windows 2000 and Windows 98 do not report instances of Win32_Battery unless Advanced Power Management (APM) is enabled on the system and a battery is present.
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa394074.aspx">MSDN.</a>
''' </remarks>
Public Class Win32_Battery
    Inherits CIM_Battery

    ''' <summary>
    ''' Constructor. 
    ''' </summary>
    ''' <param name="ManagementObject">The underlying management object.</param>
    ''' <remarks>Use this constructor when the management object already exists (e.g. read from a collection).</remarks>
    Public Sub New(ByVal ManagementObject As ManagementObject)
        MyBase.New(ManagementObject)
    End Sub

    Public Sub New(ByVal Computer As String, ByVal DeviceID As String)
        MyBase.New(New ManagementPath("\\" & Computer & "\root\cimv2:Win32_Battery.DeviceID=""" & DeviceID & """"))
    End Sub


    ' All properties are inherited.

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.Win32_Battery"></see>.
''' </summary>
''' <remarks></remarks>
Public Class Win32_Batteries
    Inherits CIM_Batteries

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <param name="DeviceID">If specified, only the item corresponding to this key value is returned. Ignored if <code>Condition</code> is set.</param>
    ''' <param name="Condition">WQL condition can be specified. It is not checked and sent to WMI as is.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Computer As String, Optional ByVal DeviceID As String = Nothing, Optional ByVal Condition As String = Nothing)

        MyBase.New(Computer, "Win32_Battery")
        ' Prepare condition
        If Condition Is Nothing AndAlso DeviceID IsNot Nothing Then
            Condition = "DeviceID ='" & DeviceID & "'"
        End If
        ' Read the collection
        For Each ManagementObjectI As ManagementObject In Me.Read(Condition)
            Me.Add(New Win32_Battery(ManagementObjectI))
        Next

    End Sub

    ''' <summary>
    ''' Find an item in the collection.
    ''' </summary>
    ''' <param name="index">Index of the item.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal index As Integer) As Win32_Battery
        Return CType(List.Item(index), Win32_Battery)
    End Function

    ''' <summary>
    ''' Find an item by its ID.
    ''' </summary>
    ''' <param name="DeviceID">The device ID.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal DeviceID As String) As Win32_Battery
        For intI As Integer = 0 To List.Count - 1
            If Me.Item(intI).DeviceID = DeviceID Then
                Return Me.Item(intI)
            End If
        Next
        Return Nothing
    End Function

End Class
