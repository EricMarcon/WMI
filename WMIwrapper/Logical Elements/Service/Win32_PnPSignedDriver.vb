Imports System.Management

''' <summary>
''' Provides digital signature information about drivers.
''' </summary>
''' <remarks>
''' See <a href="http://msdn2.microsoft.com/en-us/library/aa394354.aspx">MSDN</a>
''' </remarks>
Public Class Win32_PnPSignedDriver
    Inherits CIM_Service

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
    ''' GUID of the device class.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Example: "{71A27CDD-11D0-BEC7-08002BE2092F}"</remarks>
    Public ReadOnly Property ClassGuid() As String
        Get
            Return GetStringProperty("ClassGuid")
        End Get
    End Property

    ''' <summary>
    ''' Compatibility identifier for the driver. 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Example: "DETECTEDInternal\ftdisk"</remarks>
    Public ReadOnly Property CompatID() As String
        Get
            Return GetStringProperty("CompatID")
        End Get
    End Property

    ''' <summary>
    ''' Device class of the driver.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Example: "SYSTEM"</remarks>
    Public ReadOnly Property DeviceClass() As String
        Get
            Return GetStringProperty("DeviceClass")
        End Get
    End Property

    ''' <summary>
    ''' Device identifier of the device.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Example: "ROOT\FTDISK\0000"</remarks>
    Public ReadOnly Property DeviceID() As String
        Get
            Return GetStringProperty("DeviceID")
        End Get
    End Property

    ''' <summary>
    ''' Name of the device.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property DeviceName() As String
        Get
            Return GetStringProperty("DeviceName")
        End Get
    End Property

    ''' <summary>
    ''' Device loader for the device.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property DevLoader() As String
        Get
            Return GetStringProperty("DevLoader")
        End Get
    End Property

    ''' <summary>
    ''' Build date of the driver (from the manufacturer).
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Example: "1-25-2001"</remarks>
    Public ReadOnly Property DriverDate() As String
        Get
            Return GetStringProperty("DriverDate")
        End Get
    End Property

    ''' <summary>
    ''' Name of the driver.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property DriverName() As String
        Get
            Return GetStringProperty("DriverName")
        End Get
    End Property

    ''' <summary>
    ''' Version of the driver.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Example: "5.1.2427.1"</remarks>
    Public ReadOnly Property DriverVersion() As String
        Get
            Return GetStringProperty("DriverVersion")
        End Get
    End Property

    ''' <summary>
    ''' Friendly name of the driver.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Example: "Communications Port (COM2)"</remarks>
    Public ReadOnly Property FriendlyName() As String
        Get
            Return GetStringProperty("FriendlyName")
        End Get
    End Property

    ''' <summary>
    ''' Hardware identifier for the driver. 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Example: "ROOT\FTDISK"</remarks>
    Public ReadOnly Property HardWareID() As String
        Get
            Return GetStringProperty("HardWareID")
        End Get
    End Property

    ''' <summary>
    ''' Name of the .inf file that installed the device. 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Example: "machine.inf"</remarks>
    Public ReadOnly Property InfName() As String
        Get
            Return GetStringProperty("InfName")
        End Get
    End Property

    ''' <summary>
    ''' If TRUE, the driver is signed.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property IsSigned() As Boolean
        Get
            Return GetBooleanProperty("IsSigned")
        End Get
    End Property

    ''' <summary>
    ''' Location of the driver.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Location() As String
        Get
            Return GetStringProperty("Location")
        End Get
    End Property

    ''' <summary>
    ''' Name of the manufacturer of the Plug and Play device.
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
    ''' Physical device object (PDO).
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' PDOs represent individual devices on a bus.
    ''' Other drivers for the device attach on top of the PDO.
    ''' It is always at the bottom of the device stack.
    ''' Example: "\Device\00000002"
    ''' </remarks>
    Public ReadOnly Property PDO() As String
        Get
            Return GetStringProperty("PDO")
        End Get
    End Property

    ''' <summary>
    ''' Provider of the driver.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Example: "Microsoft"</remarks>
    Public ReadOnly Property DriverProviderName() As String
        Get
            Return GetStringProperty("DriverProviderName")
        End Get
    End Property

    ''' <summary>
    ''' Signer of driver, if it is signed.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Example: "ntbuild"</remarks>
    Public ReadOnly Property Signer() As String
        Get
            Return GetStringProperty("Signer")
        End Get
    End Property

#End Region

#Region "Methods"

    ''' <summary>
    ''' Starts the driver service.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function StartService() As InvokeError

        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("StartService")
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Stops the driver service.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function StopService(ByVal LogicalDisk As String()) As InvokeError

        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("StopService")
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.Win32_PnPSignedDriver"></see>.
''' </summary>
''' <remarks></remarks>
Public Class Win32_PnPSignedDrivers
    Inherits CIM_Services

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <param name="Name">If specified, only the item corresponding to this key value is returned. Ignored if <code>Condition</code> is set.</param>
    ''' <param name="Condition">WQL condition can be specified. It is not checked and sent to WMI as is.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Computer As String, Optional ByVal Name As String = Nothing, Optional ByVal Condition As String = Nothing)

        MyBase.New(Computer, "Win32_PnPSignedDriver")
        ' Prepare condition
        If Condition Is Nothing AndAlso Name IsNot Nothing Then
            Condition = "Name ='" & Name & "'"
        End If
        ' Read the collection
        For Each ManagementObjectI As ManagementObject In Me.Read(Condition)
            Me.Add(New Win32_PnPSignedDriver(ManagementObjectI))
        Next

    End Sub

    ''' <summary>
    ''' Find an item in the collection.
    ''' </summary>
    ''' <param name="index">Index of the item.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal index As Integer) As Win32_PnPSignedDriver
        Return CType(List.Item(index), Win32_PnPSignedDriver)
    End Function

    ''' <summary>
    ''' Find an item by its name.
    ''' </summary>
    ''' <param name="Name">The file name.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal Name As String) As Win32_PnPSignedDriver
        For intI As Integer = 0 To List.Count - 1
            If Me.Item(intI).Name = Name Then
                Return Me.Item(intI)
            End If
        Next
        Return Nothing
    End Function

End Class
