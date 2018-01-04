Imports System.Management

''' <summary>
''' Represents a service on a computer system running Windows.
''' </summary>
''' <remarks>
''' A service application conforms to the interface rules of the Service Control Manager (SCM), 
''' and can be started by a user automatically at system start through the Services control panel utility,
''' or by an application that uses the service functions included in the Windows API. Services can start when there are no users logged on to the computer.
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa394418.aspx">MSDN</a>
''' </remarks>
Public Class Win32_Service
    Inherits Win32_BaseService

    ''' <summary>
    ''' Constructor. 
    ''' </summary>
    ''' <param name="ManagementObject">The underlying management object.</param>
    ''' <remarks>Use this constructor when the management object already exists (e.g. read from a collection).</remarks>
    Public Sub New(ByVal ManagementObject As ManagementObject)
        MyBase.New(ManagementObject)
    End Sub

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <param name="ClassPath">The class namespace.</param>
    ''' <param name="ClassName">The class name.</param>
    ''' <remarks>This constructor creates an unbound instance of the class.</remarks>
    Public Sub New(ByVal Computer As String, ByVal ClassName As String, Optional ByVal ClassPath As String = "root\cimv2")
        MyBase.New(Computer, ClassName, ClassPath)
    End Sub

    Private _SecurityDescriptor As Win32_SecurityDescriptor
    ''' <summary>
    ''' The security descriptor associated with the service.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Set this property before using <see cref="M:WMIwrapper.Win32_Service.SetSecurityDescriptor"></see> or to get the result of <see cref="M:WMIwrapper.Win32_Service.GetSecurityDescriptor"></see>.</remarks>
    Public Property SecurityDescriptor() As Win32_SecurityDescriptor
        Get
            Return _SecurityDescriptor
        End Get
        Set(ByVal value As Win32_SecurityDescriptor)
            _SecurityDescriptor = value
        End Set
    End Property

#Region "Properties"

    ''' <summary>
    ''' Value that the service increments periodically to report its progress during a long start, stop, pause, or continue operation.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' For example, the service increments this value as it completes each step of its initialization when it is starting up.
    ''' The user interface program that invokes the operation on the service uses this value to track the progress of the service during a lengthy operation.
    ''' </remarks> 
    Public ReadOnly Property CheckPoint() As UInt32
        Get
            Return GetUint32Property("CheckPoint")
        End Get
    End Property

    ''' <summary>
    ''' Process identifier of the service.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Example: 324</remarks>
    Public ReadOnly Property ProcessId() As UInt32
        Get
            Return GetUint32Property("ProcessId")
        End Get
    End Property

    ''' <summary>
    ''' Estimated time required, in milliseconds, for a pending start, stop, pause, or continue operation.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' After the specified time has elapsed, the service makes its next call to the <see cref="M:WMIwrapper.Win32_Service.SetServiceStatus"></see> method
    ''' with either an incremented <see cref="P:WMIwrapper.Win32_Service.CheckPoint"></see> value or a change in <see cref="P:WMIwrapper.Win32_Service.CurrentState"></see>.
    ''' If the amount of time specified by <see cref="P:WMIwrapper.Win32_Service.WaitHint"></see> passes, and <see cref="P:WMIwrapper.Win32_Service.CheckPoint"></see> has not been incremented, or <see cref="P:WMIwrapper.Win32_Service.CurrentState"></see> has not changed,
    ''' the service control manager or service control program assumes that an error has occurred.
    ''' </remarks>
    Public ReadOnly Property WaitHint() As UInt32
        Get
            Return GetUint32Property("WaitHint")
        End Get
    End Property

#End Region

#Region "Methods"

    ''' <summary>
    ''' Get the security descriptor that controls access to the service.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks>Requires Windows Vista or later.</remarks>
    Public Function GetSecurityDescriptor() As InvokeError

        ' Create the share. Can't use Me.InvokeMethod because the method is not applied to _ManagementObject
        Dim outParams As ManagementBaseObject = _ManagementObject.InvokeMethod("GetSecurityDescriptor", Nothing, Nothing)
        Dim uintReturnValue As UInteger = CType(outParams("ReturnValue"), UInteger)
        ' Return the result
        Return New InvokeError(uintReturnValue, Me.ErrorMessage(uintReturnValue))

    End Function

    ''' <summary>
    ''' Writes an updated version of the security descriptor that controls access to the service.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks>Requires Windows Vista or later.</remarks>
    Public Function SetSecurityDescriptor() As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_Service"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("SetSecurityDescriptor")
        inParams("Descriptor") = _SecurityDescriptor

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("SetSecurityDescriptor")
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
                Return "Successful completion."
            Case 2
                Return "The user does not have access to the requested information."
            Case 8
                Return "Unknown failure."
            Case 9
                Return "The user does not have adequate privileges to execute the method."
            Case 21
                Return "A parameter specified in the method call is invalid."
            Case Else
                Return "Unknown error"
        End Select
    End Function

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.Win32_Service"></see>.
''' </summary>
''' <remarks></remarks>
Public Class Win32_Services
    Inherits Win32_BaseServices

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <param name="Name">If specified, only the item corresponding to this key value is returned. Ignored if <code>Condition</code> is set.</param>
    ''' <param name="Condition">WQL condition can be specified. It is not checked and sent to WMI as is.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Computer As String, Optional ByVal Name As String = Nothing, Optional ByVal Condition As String = Nothing)

        MyBase.New(Computer, "Win32_Service")
        ' Prepare condition
        If Condition Is Nothing AndAlso Name IsNot Nothing Then
            Condition = "Name ='" & Name & "'"
        End If
        ' Read the collection
        For Each ManagementObjectI As ManagementObject In Me.Read(Condition)
            Me.Add(New Win32_Service(ManagementObjectI))
        Next

    End Sub

    ''' <summary>
    ''' Find an item in the collection.
    ''' </summary>
    ''' <param name="index">Index of the item.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal index As Integer) As Win32_Service
        Return CType(List.Item(index), Win32_Service)
    End Function

    ''' <summary>
    ''' Find an item by its name.
    ''' </summary>
    ''' <param name="Name">The service name.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal Name As String) As Win32_Service
        For intI As Integer = 0 To List.Count - 1
            If Me.Item(intI).Name = Name Then
                Return Me.Item(intI)
            End If
        Next
        Return Nothing
    End Function

End Class
