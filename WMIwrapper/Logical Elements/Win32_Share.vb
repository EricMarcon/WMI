Imports System.Management

''' <summary>
''' Represents a shared resource on a computer system running Windows.
''' </summary>
''' <remarks>
''' <para>
''' This may be a disk drive, printer, interprocess communication, or other shareable device.
''' </para>
''' <para>
''' Reference on <a href="http://msdn2.microsoft.com/EN-US/library/aa394435.aspx">MSDN</a>
''' </para> 
''' <para>
''' Inspired by <a href="http://www.mvps.org/emorcillo/en/code/grl/share.shtml">Eduardo Morcillo</a>
''' </para>
''' </remarks>
Public Class Win32_Share
    Inherits CIM_LogicalElement

#Region "Constructors"

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <remarks>
    ''' <para>This constructor prepares the creation of a new Management object on the specified computer.</para>
    ''' <para><see cref="M:WMIwrapper.Win32_Share.Create"></see> method will have to be called after setting properties.</para>
    ''' </remarks>
    Public Sub New(ByVal Computer As String)
        MyBase.New(Computer, "Win32_Share")
    End Sub

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <param name="ShareName">Name of the share on the host computer.</param>
    Public Sub New(ByVal Computer As String, ByVal ShareName As String)
        MyBase.New(New ManagementPath("\\" & Computer & "\root\cimv2:Win32_Share.Name=""" & ShareName & """"))
    End Sub

    ''' <summary>
    ''' Constructor. 
    ''' </summary>
    ''' <param name="ManagementObject">The underlying management object.</param>
    ''' <remarks>Use this constructor when the management object already exists (e.g. read from a collection).</remarks>
    Public Sub New(ByVal ManagementObject As System.Management.ManagementObject)
        MyBase.New(ManagementObject)
    End Sub

#End Region

#Region "Properties"

    ''' <summary>
    ''' Access rights to the share held by the user or group on whose behalf the instance is returned.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Calls GetAccessMask method.</remarks>
    Public ReadOnly Property AccessMask() As Enums.AccessMask
        Get
            Try
                Return CType(_ManagementObject.InvokeMethod("GetAccessMask", Nothing), Enums.AccessMask)
            Catch ex As Exception
                ' Fails if the share type does not support it
                Return Enums.AccessMask.None
            End Try
        End Get
    End Property

    ''' <summary>
    ''' Number of concurrent users for this resource has been limited.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>If <code>True</code>, the value in the <see cref="P:WMIwrapper.Win32_Share.MaximumAllowed"/> property is ignored.</remarks>
    Public ReadOnly Property AllowMaximum() As Boolean
        Get
            Return GetBooleanProperty("AllowMaximum")
        End Get
    End Property

    ''' <summary>
    ''' Limit on the maximum number of users allowed to use this resource concurrently.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>The value is only valid if the <see cref="P:WMIwrapper.Win32_Share.AllowMaximum"/> property is set to <c>False</c>.</remarks>
    Public Property MaximumAllowed() As UInt32
        Get
            Return GetUint32Property("MaximumAllowed")
        End Get
        Set(ByVal value As UInteger)
            Me.SetShareInfo(value, Me.Description, Nothing)
        End Set
    End Property

    ''' <summary>
    ''' Local path of the Windows share.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Path() As String
        Get
            Return GetStringProperty("Path")
        End Get
    End Property

    ''' <summary>
    ''' Type of resource being shared.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Types include: disk drives, print queues, interprocess communications (IPC), and general devices.</remarks>
    Public ReadOnly Property Type() As Enums.Type
        Get
            Dim obj As Object = GetPropertyObject("Type")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.Type)
            End If
        End Get
    End Property

#End Region

#Region "Methods"

    ''' <summary>
    ''' Set the share info.
    ''' </summary>
    ''' <param name="MaximumAllowed">Maximum number of users.</param>
    ''' <param name="Description">Description.</param>
    ''' <param name="Access">Security Descriptor.</param>
    Public Function SetShareInfo(ByVal MaximumAllowed As UInteger, ByVal Description As String, ByVal Access As Win32_SecurityDescriptor) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_Share"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("SetShareInfo")
        If MaximumAllowed > 0 Then
            inParams("MaximumAllowed") = MaximumAllowed
        End If
        inParams("Description") = Description
        inParams("Access") = Access.ManagementObject

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("SetShareInfo", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Create a shared resource in the specified computer.
    ''' </summary>
    ''' <param name="Path">Local path on the computer.</param>
    ''' <param name="Type">Share type.</param>
    ''' <param name="Name">Share name.</param>
    ''' <param name="MaximumAllowed">Maximum number of clients allowed.</param>
    ''' <param name="Description">Share description.</param>
    ''' <remarks>Invoke Create method.</remarks>
    Public Shadows Function Create( _
        ByVal Path As String, _
        ByVal Type As Enums.Type, _
        ByVal Name As String, _
        ByVal MaximumAllowed As Integer, _
        ByVal Access As Win32_SecurityDescriptor, _
        ByVal Description As String) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_Share"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("Create")
        inParams("Access") = Access.ManagementObject
        inParams("Path") = Path
        inParams("Name") = Name
        inParams("Type") = Type
        If MaximumAllowed > 0 Then
            inParams("MaximumAllowed") = MaximumAllowed
        End If
        inParams("Description") = Description

        ' Create the share. Can't use Me.InvokeMethod because the method is not applied to _ManagementObject
        Dim outParams As ManagementBaseObject = mc.InvokeMethod("Create", inParams, Nothing)
        Dim uintReturnValue As UInteger = CType(outParams("ReturnValue"), UInteger)
        ' If OK
        If uintReturnValue = 0 Then
            ' Query WMI to get the created share back.
            _ManagementPath.Path &= ".Name=""" & Name & """"
            _ManagementObject.Path = _ManagementPath
            _ManagementObject.Get()
        End If
        ' Return the result
        Return New InvokeError(uintReturnValue, Me.ErrorMessage(uintReturnValue))

    End Function

    ''' <summary>
    ''' Invoke Delete method.
    ''' </summary>
    ''' <remarks>Not supported by all objects.</remarks>
    Public Function Delete() As InvokeError
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("Delete")
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))
    End Function

    ''' <summary>
    ''' Error messages for the methods of this class.
    ''' </summary>
    ''' <param name="Number">Error number.</param>
    ''' <returns>A string containing the error message.</returns>
    ''' <remarks></remarks>
    Protected Overrides Function ErrorMessage(ByVal Number As UInteger) As String
        Select Case Number
            Case 0
                Return "Success"
            Case 2
                Return "Access Denied"
            Case 8
                Return "Unknown Failure"
            Case 9
                Return "Invalid Name"
            Case 10
                Return "Invalid Level"
            Case 21
                Return "Invalid Parameter"
            Case 22
                Return "Duplicate Share"
            Case 23
                Return "Redirected Path"
            Case 24
                Return "Unknown Device or Directory"
            Case 25
                Return "Net Name Not Found"
            Case Else
                Return "Unknown error"
        End Select
    End Function

#End Region

End Class



''' <summary>
''' The collection of shares on a computer.
''' </summary>
''' <remarks>Types include: disk drives, print queues, interprocess communications (IPC), and general devices.</remarks>
Public Class Win32_Shares
    Inherits CIM_LogicalElements

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <param name="Name">If specified, only the item corresponding to this key value is returned. Ignored if <code>Condition</code> is set.</param>
    ''' <param name="Condition">WQL condition can be specified. It is not checked and sent to WMI as is.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Computer As String, Optional ByVal Name As String = Nothing, Optional ByVal Condition As String = Nothing)

        MyBase.New(Computer, "Win32_Share")
        ' Prepare condition
        If Condition Is Nothing AndAlso Name IsNot Nothing Then
            Condition = "Name ='" & Name & "'"
        End If
        ' Read the collection
        For Each ManagementObjectI As ManagementObject In Me.Read(Condition)
            Me.Add(New Win32_Share(ManagementObjectI))
        Next

    End Sub

    ''' <summary>
    ''' Find an item by its index.
    ''' </summary>
    ''' <param name="Index">The index of the item in the collection.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal Index As Integer) As Win32_Share
        Return CType(List.Item(Index), Win32_Share)
    End Function

    ''' <summary>
    ''' Find an item by its name.
    ''' </summary>
    ''' <param name="Name">The share name.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal Name As String) As Win32_Share
        For intI As Integer = 0 To List.Count - 1
            If Me.Item(intI).Name = Name Then
                Return Me.Item(intI)
            End If
        Next
        Return Nothing
    End Function

    ''' <summary>
    ''' Remove a  share by its name.
    ''' </summary>
    ''' <param name="Name">Name of the share to remove.</param>
    ''' <remarks></remarks>
    Public Overloads Sub Remove(ByVal Name As String)
        Me.Remove(Me.Item(Name))
    End Sub

End Class


Namespace Enums

    ''' <summary>
    ''' Type of resource being shared. Types include: disk drives, print queues, interprocess communications (IPC), and general devices.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum Type As UInteger
        ''' <summary>
        ''' Disk Drive.
        ''' </summary>
        ''' <remarks></remarks>
        DiskDrive = 0
        ''' <summary>
        ''' Print Queue.
        ''' </summary>
        ''' <remarks></remarks>
        PrintQueue = 1
        ''' <summary>
        ''' Device.
        ''' </summary>
        ''' <remarks></remarks>
        Device = 2
        ''' <summary>
        ''' IPC.
        ''' </summary>
        ''' <remarks></remarks>
        IPC = 3
        ''' <summary>
        ''' Disk Drive Admin.
        ''' </summary>
        ''' <remarks></remarks>
        DiskDriveAdmin = &H80000000UI
        ''' <summary>
        ''' Print Queue Admin.
        ''' </summary>
        ''' <remarks></remarks>
        PrintQueueAdmin = &H80000001UI
        ''' <summary>
        ''' Device Admin.
        ''' </summary>
        ''' <remarks></remarks>
        DeviceAdmin = &H80000002UI
        ''' <summary>
        ''' IPC Admin.
        ''' </summary>
        ''' <remarks></remarks>
        IPCAdmin = &H80000003UI

    End Enum

End Namespace
