Imports System.Management

''' <summary>
''' Keyboard.
''' </summary>
''' <remarks>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa394166.aspx">MSDN.</a>
''' </remarks>
Public Class Win32_Keyboard
    Inherits CIM_Keyboard

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
    ''' Free-form string indicating the layout of the keyboard.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Layout() As String
        Get
            Return GetStringProperty("Layout")
        End Get
    End Property

    ''' <summary>
    ''' Number of function keys on the keyboard.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property NumberOfFunctionKeys() As UInt16
        Get
            Return GetUint16Property("NumberOfFunctionKeys")
        End Get
    End Property

    ''' <summary>
    ''' Status of hardware-level password enabled at the keyboard, preventing local input.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Password() As Enums.Password
        Get
            Dim obj As Object = GetPropertyObject("Password")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.Password)
            End If
        End Get
    End Property

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.Win32_Keyboard"></see>.
''' </summary>
''' <remarks></remarks>
Public Class Win32_Keyboards
    Inherits CIM_Keyboards

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <param name="DeviceID">If specified, only the item corresponding to this key value is returned. Ignored if <code>Condition</code> is set.</param>
    ''' <param name="Condition">WQL condition can be specified. It is not checked and sent to WMI as is.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Computer As String, Optional ByVal DeviceID As String = Nothing, Optional ByVal Condition As String = Nothing)

        MyBase.New(Computer, "Win32_Keyboard")
        ' Prepare condition
        If Condition Is Nothing AndAlso DeviceID IsNot Nothing Then
            Condition = "DeviceID ='" & DeviceID & "'"
        End If
        ' Read the collection
        For Each ManagementObjectI As ManagementObject In Me.Read(Condition)
            Me.Add(New Win32_Keyboard(ManagementObjectI))
        Next

    End Sub

    ''' <summary>
    ''' Find an item in the collection.
    ''' </summary>
    ''' <param name="index">Indes of the item.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal index As Integer) As Win32_Keyboard
        Return CType(List.Item(index), Win32_Keyboard)
    End Function

    ''' <summary>
    ''' Find an item by its ID.
    ''' </summary>
    ''' <param name="DeviceID">The device ID.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal DeviceID As String) As Win32_Keyboard
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
    ''' Status of hardware-level password enabled at the keyboard, preventing local input.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum Password As UInt16

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
        ''' Disabled.
        ''' </summary>
        ''' <remarks></remarks>
        Disabled = 3

        ''' <summary>
        ''' Enabled.
        ''' </summary>
        ''' <remarks></remarks>
        Enabled = 4

        ''' <summary>
        '''  Not Implemented.
        ''' </summary>
        ''' <remarks></remarks>
        NotImplemented = 5

    End Enum

End Namespace