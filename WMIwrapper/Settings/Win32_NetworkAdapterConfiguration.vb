Imports System.Management

''' <summary>
''' Represents the attributes and behaviors of a network adapter.
''' </summary>
''' <remarks>
''' <para>
''' This class includes extra properties and methods that support the management of the TCP/IP and Internetwork Packet Exchange (IPX) protocols that are independent from the network adapter.
''' </para>
''' <para>See <a href="http://msdn2.microsoft.com/en-us/library/aa394217.aspx">MSDN</a>.</para>
''' </remarks>
Public Class Win32_NetworkAdapterConfiguration
    Inherits CIM_Setting

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
    ''' If TRUE, TCP/IP transmits Address Resolution Protocol (ARP) queries with source routing enabled on Token Ring networks.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' By default (FALSE), ARP first queries without source routing, and then retries with source routing enabled if no reply is received.
    ''' Source routing allows the routing of network packets across different types of networks.
    ''' </remarks>
    Public ReadOnly Property ArpAlwaysSourceRoute() As Boolean
        Get
            Return GetBooleanProperty("ArpAlwaysSourceRoute")
        End Get
    End Property

    ''' <summary>
    ''' If TRUE, Ethernet packets follow the IEEE 802.3 Sub-Network Access Protocol (SNAP) encoding.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' Setting this parameter to 1 forces TCP/IP to transmit Ethernet packets by using 802.3 SNAP encoding.
    ''' By default (FALSE), the stack transmits packets in DIX Ethernet format.
    ''' Windows 2000 and Windows NT systems can receive both formats.
    ''' </remarks>
    Public ReadOnly Property ArpUseEtherSNAP() As Boolean
        Get
            Return GetBooleanProperty("ArpUseEtherSNAP")
        End Get
    End Property

    ''' <summary>
    ''' Valid Windows file path to standard Internet database files (HOSTS, LMHOSTS, NETWORKS, and PROTOCOLS).
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' The file path is used by the Windows Sockets interface.
    ''' This property is only available on computer systems running Windows 2000 and Windows NT.
    ''' </remarks>
    Public ReadOnly Property DatabasePath() As String
        Get
            Return GetStringProperty("DatabasePath")
        End Get
    End Property

    ''' <summary>
    ''' Indicates whether dead gateway detection occurs.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>With this feature enabled, Transmission Control Protocol (TCP) asks Internet Protocol (IP) to change to a backup gateway if it retransmits a segment several times without receiving a response.</remarks>
    Public ReadOnly Property DeadGWDetectEnabled() As Boolean
        Get
            Return GetBooleanProperty("DeadGWDetectEnabled")
        End Get
    End Property

    ''' <summary>
    ''' Array of IP addresses of default gateways that the computer system uses.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property DefaultIPGateway() As String()
        Get
            Return GetStringArrayProperty("DefaultIPGateway")
        End Get
    End Property

    ''' <summary>
    ''' Default Type Of Service (TOS) value set in the header of outgoing IP packets.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Request for Comments (RFC) 791 defines the values. Default: 0 (zero), Valid Range: 0 - 255.</remarks>
    Public ReadOnly Property DefaultTOS() As Byte
        Get
            Return GetByteProperty("DefaultTOS")
        End Get
    End Property

    ''' <summary>
    ''' Default Time To Live (TTL) value set in the header of outgoing IP packets.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' The TTL specifies the number of routers an IP packet can pass through to reach its destination before being discarded.
    ''' Each router decrements by one the TTL count of a packet as it passes through and discards the packets—if the TTL is 0 (zero).
    ''' Default: 32, Valid Range: 1 - 255.
    ''' </remarks>
    Public ReadOnly Property DefaultTTL() As Byte
        Get
            Return GetByteProperty("DefaultTTL")
        End Get
    End Property

    ''' <summary>
    ''' If whether the dynamic host configuration protocol (DHCP) server automatically assigns an IP address to the computer system when establishing a network connection.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property DHCPEnabled() As Boolean
        Get
            Return GetBooleanProperty("DHCPEnabled")
        End Get
    End Property

    ''' <summary>
    ''' Expiration date and time for a leased IP address that was assigned to the computer by the dynamic host configuration protocol (DHCP) server.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property DHCPLeaseExpires() As DateTime
        Get
            Return GetDateTimeProperty("DHCPLeaseExpires")
        End Get
    End Property

    ''' <summary>
    ''' Date and time the lease was obtained for the IP address assigned to the computer by the dynamic host configuration protocol (DHCP) server.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property DHCPLeaseObtained() As DateTime
        Get
            Return GetDateTimeProperty("DHCPLeaseObtained")
        End Get
    End Property

    ''' <summary>
    ''' IP address of the dynamic host configuration protocol (DHCP) server.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property DHCPServer() As String
        Get
            Return GetStringProperty("DHCPServer")
        End Get
    End Property

    ''' <summary>
    ''' Organization name followed by a period and an extension that indicates the type of organization.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>The name can be any combination of the letters A through Z, the numerals 0 through 9, and the hyphen (-), plus the period (.) character used as a separator.</remarks>
    Public ReadOnly Property DNSDomain() As String
        Get
            Return GetStringProperty("DNSDomain")
        End Get
    End Property

    ''' <summary>
    ''' Array of DNS domain suffixes to be appended to the end of host names during name resolution.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' When attempting to resolve a fully-qualified domain name (FQDN) from a host-only name, the system will first append the local domain name.
    ''' If this is not successful, the system will use the domain suffix list to create additional FQDNs in the order listed and query DNS servers for each.
    ''' </remarks>
    Public ReadOnly Property DNSDomainSuffixSearchOrder() As String()
        Get
            Return GetStringArrayProperty("DNSDomainSuffixSearchOrder")
        End Get
    End Property

    ''' <summary>
    ''' Indicates whether the Domain Name System (DNS) is enabled for name resolution over Windows Internet Naming Service (WINS) resolution.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>If the name cannot be resolved using DNS, the name request is forwarded to WINS for resolution.</remarks>
    Public ReadOnly Property DNSEnabledForWINSResolution() As Boolean
        Get
            Return GetBooleanProperty("DNSEnabledForWINSResolution")
        End Get
    End Property

    ''' <summary>
    ''' Host name used to identify the local computer for authentication by some utilities.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' Other TCP/IP-based utilities can use this value to acquire the name of the local computer.
    ''' Host names are stored on DNS servers in a table that maps names to IP addresses for use by DNS.
    ''' The name can be any combination of the letters A through Z, the numerals 0 through 9, and the hyphen (-), plus the period (.) character used as a separator.
    ''' By default, this value is the Microsoft networking computer name, but the network administrator can assign another host name without affecting the computer name.
    ''' </remarks>
    Public ReadOnly Property DNSHostName() As String
        Get
            Return GetStringProperty("DNSHostName")
        End Get
    End Property

    ''' <summary>
    ''' Array of server IP addresses to be used in querying for DNS servers.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property DNSServerSearchOrder() As String()
        Get
            Return GetStringArrayProperty("DNSServerSearchOrder")
        End Get
    End Property

    ''' <summary>
    ''' Indicates whether the IP addresses for this connection are registered in DNS under the domain name of this connection in addition to being registered under the computer's full DNS name.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' <para>The domain name of this connection is either set using the <see cref="M:WMIwrapper.Win32_NetworkAdapterConfiguration.SetDNSDomain"/> method or assigned by DSCP.
    ''' The registered name is the host name of the computer with the domain name appended.</para>
    ''' <para>Windows 2000 and Windows NT 4.0:  This property is not available.</para>
    ''' </remarks>
    Public ReadOnly Property DomainDNSRegistrationEnabled() As Boolean
        Get
            Return GetBooleanProperty("DomainDNSRegistrationEnabled")
        End Get
    End Property

    ''' <summary>
    ''' Memory allocated by IP to store packet data in the router packet queue.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' When this buffer space is filled, the router begins discarding packets at random from its queue.
    ''' Packet queue data buffers are 256 bytes in length, so the value of this parameter should be a multiple of 256.
    ''' Multiple buffers are chained together for larger packets.
    ''' The IP header for a packet is stored separately.
    ''' This parameter is ignored and no buffers are allocated if the IP router is not enabled.
    ''' The buffer size can range from the network MTU to a value smaller than 0xFFFFFFFF.
    ''' Default: 74240 (fifty 1480-byte packets, rounded to a multiple of 256).
    ''' </remarks>
    Public ReadOnly Property ForwardBufferMemory() As UInt32
        Get
            Return GetUint32Property("ForwardBufferMemory")
        End Get
    End Property

    ''' <summary>
    ''' Indicates whether the IP addresses for this connection are registered in DNS under the computer's full DNS name.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' <para>The full DNS name of the computer is displayed on the Network Identification tab in the System application in Control Panel.</para>
    ''' <para>Windows 2000 and Windows NT 4.0:  This property is not available.</para>
    ''' </remarks>
    Public ReadOnly Property FullDNSRegistrationEnabled() As Boolean
        Get
            Return GetBooleanProperty("FullDNSRegistrationEnabled")
        End Get
    End Property

    ''' <summary>
    ''' Array of integer cost metric values (ranging from 1 to 9999) to be used in calculating the fastest, most reliable, or least expensive routes.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>This argument has a one-to-one correspondence with the DefaultIPGateway property.</remarks>
    Public ReadOnly Property GatewayCostMetric() As UInt16()
        Get
            Return GetUint16ArrayProperty("GatewayCostMetric")
        End Get
    End Property

    ''' <summary>
    ''' Extent to which the system supports IP multicast and participates in the Internet Group Management Protocol (IGMP).
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks> At level 0 (zero), the system provides no multicast support. At level 1, the system may only send IP multicast packets. At level 2, the system may send IP multicast packets and fully participate in IGMP to receive multicast packets.</remarks>
    Public ReadOnly Property IGMPLevel() As Enums.IGMPLevel
        Get
            Dim obj As Object = GetPropertyObject("IGMPLevel")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.IGMPLevel)
            End If
        End Get
    End Property

    ''' <summary>
    ''' Index number of the Windows network adapter configuration.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>The index number is used when there is more than one configuration available.</remarks>
    Public ReadOnly Property Index() As UInt32
        Get
            Return GetUint32Property("Index")
        End Get
    End Property

    ''' <summary>
    ''' Index value that uniquely identifies a local network interface.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' The value in this property is the same as the value in the InterfaceIndex property in the instance of Win32_IP4RouteTable that represents the network interface in the route table.
    ''' </remarks>
    Public ReadOnly Property InterfaceIndex() As UInt32
        Get
            Return GetUint32Property("InterfaceIndex")
        End Get
    End Property

    ''' <summary>
    ''' Array of all of the IP addresses associated with the current network adapter.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Starting with Windows Vista, this property can contain either IPv6 addresses or IPv4 addresses.</remarks>
    Public ReadOnly Property IPAddress() As String()
        Get
            Return GetStringArrayProperty("IPAddress")
        End Get
    End Property

    ''' <summary>
    ''' Cost of using the configured routes for the IP bound adapter and is the weighted value for those routes in the IP routing table.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' If there are multiple routes to a destination in the IP routing table, the route with the lowest metric is used.
    ''' The default value is 1.
    ''' </remarks>
    Public ReadOnly Property IPConnectionMetric() As UInt32
        Get
            Return GetUint32Property("IPConnectionMetric")
        End Get
    End Property

    ''' <summary>
    ''' Indicates whether TCP/IP is bound and enabled on this network adapter.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property IPEnabled() As Boolean
        Get
            Return GetBooleanProperty("IPEnabled")
        End Get
    End Property

    ''' <summary>
    ''' Indicates whether IP port security is enabled globally across all IP-bound network adapters and the security values associated with individual network adapters are in effect.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' This property is used in conjunction with <see cref="P:WMIwrapper.Win32_NetworkAdapterConfiguration.IPSecPermitTCPPorts"/>, <see cref="P:WMIwrapper.Win32_NetworkAdapterConfiguration.IPSecPermitUDPPorts"/>, and <see cref="P:WMIwrapper.Win32_NetworkAdapterConfiguration.IPSecPermitIPProtocols"/>.
    ''' If <c>FALSE</c>, IP filter security is disabled across all network adapters and allows all port and protocol traffic to flow unfiltered.
    ''' </remarks>
    Public ReadOnly Property IPFilterSecurityEnabled() As Boolean
        Get
            Return GetBooleanProperty("IPFilterSecurityEnabled")
        End Get
    End Property

    ''' <summary>
    ''' Array of the protocols permitted to run over the IP.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' The list of protocols is defined using the <see cref="M:WMIwrapper.Win32_NetworkAdapterConfiguration.EnableIPSec"/> method.
    ''' The list will either be empty or contain numeric values.
    ''' A numeric value of 0 (zero) indicates access permission is granted for all protocols.
    ''' An empty string indicates that no protocols are permitted to run when <see cref="P:WMIwrapper.Win32_NetworkAdapterConfiguration.IPFilterSecurityEnabled"/> is <c>TRUE</c>.
    ''' </remarks>
    Public ReadOnly Property IPSecPermitIPProtocols() As String()
        Get
            Return GetStringArrayProperty("IPSecPermitIPProtocols")
        End Get
    End Property

    ''' <summary>
    ''' Array of the ports that will be granted access permission for TCP.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' The list of protocols is defined using the <see cref="M:WMIwrapper.Win32_NetworkAdapterConfiguration.EnableIPSec"/> method.
    ''' The list will either be empty or contain numeric values.
    ''' A numeric value of 0 (zero) indicates access permission is granted for all ports.
    ''' An empty string indicates that no ports are permitted to run when <see cref="P:WMIwrapper.Win32_NetworkAdapterConfiguration.IPFilterSecurityEnabled"/> is <c>TRUE</c>.
    ''' </remarks>
    Public ReadOnly Property IPSecPermitTCPPorts() As String()
        Get
            Return GetStringArrayProperty("IPSecPermitTCPPorts")
        End Get
    End Property

    ''' <summary>
    ''' Array of the ports that will be granted User Datagram Protocol (UDP) access permission.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' The list of protocols is defined using the <see cref="M:WMIwrapper.Win32_NetworkAdapterConfiguration.EnableIPSec"/> method.
    ''' The list will either be empty or contain numeric values.
    ''' A numeric value of 0 (zero) indicates access permission is granted for all ports.
    ''' An empty string indicates that no ports are permitted to run when <see cref="P:WMIwrapper.Win32_NetworkAdapterConfiguration.IPFilterSecurityEnabled"/> is <c>TRUE</c>.
    ''' </remarks>
    Public ReadOnly Property IPSecPermitUDPPorts() As String()
        Get
            Return GetStringArrayProperty("IPSecPermitUDPPorts")
        End Get
    End Property

    ''' <summary>
    ''' Array of all of the subnet masks associated with the current network adapter.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property IPSubnet() As String()
        Get
            Return GetStringArrayProperty("IPSubnet")
        End Get
    End Property

    ''' <summary>
    ''' Indicates whether IP zeros-broadcasts are used (0.0.0.0), and the system uses ones-broadcasts (255.255.255.255).
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Computer systems generally use ones-broadcasts, but those derived from BSD implementations use zeros-broadcasts.
    ''' Systems that do not use that same broadcasts will not interoperate on the same network.
    ''' The default is FALSE.
    ''' </remarks>
    Public ReadOnly Property IPUseZeroBroadcast() As Boolean
        Get
            Return GetBooleanProperty("IPUseZeroBroadcast")
        End Get
    End Property

    ' TODO: IPX properties are not implemented yet

    ''' <summary>
    ''' Interval separating Keep Alive Retransmissions until a response is received.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' After a response is received, the delay until the next Keep Alive Transmission is again controlled by the value of <see cref="P:WMIwrapper.Win32_NetworkAdapterConfiguration.KeepAliveTime"/>.
    ''' The connection will be aborted after the number of retransmissions specified by <see cref="P:WMIwrapper.Win32_NetworkAdapterConfiguration.TcpMaxDataRetransmissions"/> have gone unanswered.
    ''' Default: 1000, Valid Range: 1 - 0xFFFFFFFF.
    ''' </remarks>
    Public ReadOnly Property KeepAliveInterval() As UInt32
        Get
            Return GetUint32Property("KeepAliveInterval")
        End Get
    End Property

    ''' <summary>
    ''' The KeepAliveTime property indicates how often the TCP attempts to verify that an idle connection is still intact by sending a Keep Alive Packet.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' A remote system that is reachable will acknowledge the keep alive transmission.
    ''' Keep Alive packets are not sent by default.
    ''' This feature may be enabled in a connection by an application.
    ''' Default: 7,200,000 (two hours).
    ''' </remarks>
    Public ReadOnly Property KeepAliveTime() As UInt32
        Get
            Return GetUint32Property("KeepAliveTime")
        End Get
    End Property

    ''' <summary>
    ''' Media Access Control (MAC) address of the network adapter.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>A MAC address is assigned by the manufacturer to uniquely identify the network adapter.</remarks>
    Public ReadOnly Property MACAddress() As String
        Get
            Return GetStringProperty("MACAddress")
        End Get
    End Property

    ''' <summary>
    ''' Overrides the default Maximum Transmission Unit (MTU) for a network interface.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' The MTU is the maximum packet size (including the transport header) that the transport will transmit over the underlying network.
    ''' The IP datagram can span multiple packets.
    ''' The range of this value spans the minimum packet size (68) to the MTU supported by the underlying network.
    ''' </remarks>
    Public ReadOnly Property MTU() As UInt32
        Get
            Return GetUint32Property("MTU")
        End Get
    End Property

    ''' <summary>
    ''' Number of IP packet headers allocated for the router packet queue.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' When all headers are in use, the router will begin to discard packets from the queue at random.
    ''' This value should be at least as large as the <see cref="P:WMIwrapper.Win32_NetworkAdapterConfiguration.ForwardBufferMemory"/> value divided by the maximum IP data size of the networks connected to the router.
    ''' It should be no larger than the <see cref="P:WMIwrapper.Win32_NetworkAdapterConfiguration.ForwardBufferMemory"/> value divided by 256, since at least 256 bytes of forward buffer memory are used for each packet.
    ''' The optimal number of forward packets for a given <see cref="P:WMIwrapper.Win32_NetworkAdapterConfiguration.ForwardBufferMemory"/> size depends on the type of traffic on the network.
    ''' It will be somewhere between these two values.
    ''' If the router is not enabled, this parameter is ignored and no headers are allocated.
    ''' Default: 50, Valid Range: 1 - 0xFFFFFFFE.
    ''' </remarks>
    Public ReadOnly Property NumForwardPackets() As UInt32
        Get
            Return GetUint32Property("NumForwardPackets")
        End Get
    End Property

    ''' <summary>
    ''' Indicates whether detection of black hole routers occurs while TCP discovers the path of the Maximum Transmission Unit.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' A black hole router does not return ICMP Destination Unreachable messages when it needs to fragment an IP datagram with the Don't Fragment bit set.
    ''' TCP depends on receiving these messages to perform Path MTU Discovery.
    ''' With this feature enabled, TCP will try to send segments without the Don't Fragment bit set if several retransmissions of a segment go unacknowledged.
    ''' If the segment is acknowledged as a result, the MSS will be decreased and the Don't Fragment bit will be set in future packets on the connection.
    ''' Enabling black hole detection increases the maximum number of retransmissions performed for a given segment.
    ''' The default value of this property is FALSE.
    ''' </remarks>
    Public ReadOnly Property PMTUBHDetectEnabled() As Boolean
        Get
            Return GetBooleanProperty("PMTUBHDetectEnabled")
        End Get
    End Property

    ''' <summary>
    ''' Indicates whether the Maximum Transmission Unit (MTU) path is discovered over the path to a remote host.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' By discovering the MTU path and limiting TCP segments to this size, TCP can eliminate fragmentation at routers along the path that connect networks with different MTUs.
    ''' Fragmentation adversely affects TCP throughput and network congestion.
    ''' Setting this parameter to FALSE causes an MTU of 576 bytes to be used for all connections that are not to machines on the local subnet.
    ''' The default is TRUE.</remarks>
    Public ReadOnly Property PMTUDiscoveryEnabled() As Boolean
        Get
            Return GetBooleanProperty("PMTUDiscoveryEnabled")
        End Get
    End Property

    ''' <summary>
    ''' Service name of the network adapter.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>This name is usually shorter than the full product name.</remarks>
    Public ReadOnly Property ServiceName() As String
        Get
            Return GetStringProperty("ServiceName")
        End Get
    End Property

    ''' <summary>
    ''' Possible settings related to NetBIOS over TCP/IP.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Windows 2000 and Windows NT 4.0:  This property is not available.</remarks>
    Public ReadOnly Property TcpipNetbiosOptions() As Enums.TcpipNetbiosOptions
        Get
            Dim obj As Object = GetPropertyObject("TcpipNetbiosOptions")
            If obj Is Nothing Then
                Return Nothing
            Else
                Return CType(obj, Enums.TcpipNetbiosOptions)
            End If
        End Get
    End Property

    ''' <summary>
    ''' Number of times TCP attempts to retransmit a Connect Request before terminating the connection.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' The initial retransmission timeout is 3 seconds.
    ''' The retransmission timeout doubles for each attempt.
    ''' Default: 3, Valid Range: 0 - 0xFFFFFFFF.
    ''' </remarks>
    Public ReadOnly Property TcpMaxConnectRetransmissions() As UInt32
        Get
            Return GetUint32Property("TcpMaxConnectRetransmissions")
        End Get
    End Property

    ''' <summary>
    ''' Number of times TCP retransmits an individual data segment (nonconnect segment) before terminating the connection.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' The retransmission timeout doubles with each successive retransmission on a connection.
    ''' Default: 5, Valid Range: 0 - 0xFFFFFFFF.
    ''' </remarks>
    Public ReadOnly Property TcpMaxDataRetransmissions() As UInt32
        Get
            Return GetUint32Property("TcpMaxDataRetransmissions")
        End Get
    End Property

    ''' <summary>
    ''' Maximum number of connections that TCP can have open simultaneously.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Default: 0xFFFFFE, Valid Range: 0 - 0xFFFFFE.</remarks>
    Public ReadOnly Property TcpNumConnections() As UInt32
        Get
            Return GetUint32Property("TcpNumConnections")
        End Get
    End Property

    ''' <summary>
    ''' Indicates whether TCP uses the RFC 1122 specification for urgent data.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>If FALSE (default), TCP uses the mode used by Berkeley Software Design (BSD) derived systems.
    ''' The two mechanisms interpret the urgent pointer differently and are not interoperable.
    ''' </remarks>
    Public ReadOnly Property TcpUseRFC1122UrgentPointer() As Boolean
        Get
            Return GetBooleanProperty("TcpUseRFC1122UrgentPointer")
        End Get
    End Property

    ''' <summary>
    ''' Maximum TCP Receive Window size offered by the system.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' The Receive Window specifies the number of bytes a sender may transmit without receiving an acknowledgment.
    ''' In general, larger receiving windows will improve performance over high-delay and high-bandwidth networks.
    ''' For efficiency, the receiving window should be an even multiple of the TCP Maximum Segment Size (MSS).
    ''' Default: Four times the maximum TCP data size or an even multiple of TCP data size rounded up to the nearest multiple of 8192.
    ''' Ethernet networks default to 8760.
    ''' Valid range: 0 - 65535.
    ''' </remarks>
    Public ReadOnly Property TcpWindowSize() As UInt16
        Get
            Return GetUint16Property("TcpWindowSize")
        End Get
    End Property

    ''' <summary>
    ''' Indicates whether local lookup files are used.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' Lookup files will contain a map of IP addresses to host names.
    ''' If they exist on the local system, they will be found in %SystemRoot%\system32\drivers\etc.
    ''' </remarks>
    Public ReadOnly Property WINSEnableLMHostsLookup() As Boolean
        Get
            Return GetBooleanProperty("WINSEnableLMHostsLookup")
        End Get
    End Property

    ''' <summary>
    ''' Path to a WINS lookup file on the local system.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>This file will contain a map of IP addresses to host names.
    ''' If the file specified in this property is found, it will be copied to the %SystemRoot%\system32\drivers\etc folder of the local system.
    ''' Valid only if the <see cref="P:WMIwrapper.Win32_NetworkAdapterConfiguration.WINSEnableLMHostsLookup"/> property is <c>TRUE</c>.
    ''' </remarks>
    Public ReadOnly Property WINSHostLookupFile() As String
        Get
            Return GetStringProperty("WINSHostLookupFile")
        End Get
    End Property

    ''' <summary>
    ''' IP address for the primary WINS server.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property WINSPrimaryServer() As String
        Get
            Return GetStringProperty("WINSPrimaryServer")
        End Get
    End Property

    ''' <summary>
    ''' Value appended to the end of the NetBIOS name that isolates a group of computer systems communicating with only each other.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>It is used for all NetBIOS transactions over TCP/IP communications from that computer system.
    ''' Computers configured with identical scope identifiers are able to communicate with this computer.
    ''' TCP/IP clients with different scope identifiers disregard packets from computers with this scope identifier.
    ''' Valid only when the <see cref="M:WMIwrapper.Win32_NetworkAdapterConfiguration.EnableWINS"></see> method executes successfully.
    ''' </remarks>
    Public ReadOnly Property WINSScopeID() As String
        Get
            Return GetStringProperty("WINSScopeID")
        End Get
    End Property

    ''' <summary>
    ''' IP address for the secondary WINS server.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property WINSSecondaryServer() As String
        Get
            Return GetStringProperty("WINSSecondaryServer")
        End Get
    End Property

#End Region

#Region "Methods"

    ''' <summary>
    ''' Disables IP security on this TCP/IP-enabled network adapter.
    ''' </summary>
    ''' <remarks></remarks>
    Public Function DisableIPSec() As InvokeError

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("DisableIPSec")
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Enables the Dynamic Host Configuration Protocol (DHCP) for service with this network adapter.
    ''' </summary>
    ''' <remarks></remarks>
    Public Function EnableDHCP() As InvokeError

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("EnableDHCP")
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Enables the Domain Name System (DNS) for service on this TCP/IP-bound network adapter. 
    ''' </summary>
    ''' <param name="DNSHostName">Name of the DNS host that this method enables.</param>
    ''' <param name="DNSDomain">Represents an organization name followed by a period and an extension that indicates the type of organization.</param>
    ''' <param name="DNSServerSearchOrder">List of server IP addresses to query for DNS servers.</param>
    ''' <param name="DNSDomainSuffixSearchOrder">
    ''' DNS domain suffix that is appended to a host name during name resolution.
    ''' When resolving a fully qualified domain name (FQDN) from a host-only name, the system appends the local domain name.
    ''' If the name resolution is not successful, the system uses the domain suffix list to create additional FQDNs in the order listed, and then queries DNS servers for each one.
    ''' </param>
    ''' <remarks></remarks>
    Public Function EnableDNS(Optional ByVal DNSHostName As String = Nothing, Optional ByVal DNSDomain As String = Nothing, Optional ByVal DNSServerSearchOrder As String() = Nothing, Optional ByVal DNSDomainSuffixSearchOrder As String() = Nothing) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_NetworkAdapterConfiguration"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("EnableDNS")
        inParams("DNSHostName") = DNSHostName
        inParams("DNSDomain") = DNSDomain
        inParams("DNSServerSearchOrder") = DNSServerSearchOrder
        inParams("DNSDomainSuffixSearchOrder") = DNSDomainSuffixSearchOrder

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("EnableDNS", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Enables IP security globally across all IP-bound network adapters.
    ''' </summary>
    ''' <param name="IPFilterSecurityEnabled">
    ''' If true, IP security is enabled globally across all IP-bound network adapters.
    ''' If false, all port and protocol traffic is allowed to flow unfiltered.
    ''' </param>
    ''' <remarks></remarks>
    Public Function EnableIPFilterSec(ByVal IPFilterSecurityEnabled As Boolean) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_NetworkAdapterConfiguration"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("EnableIPFilterSec")
        inParams("IPFilterSecurityEnabled") = IPFilterSecurityEnabled

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("EnableIPFilterSec", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    '''  Enables IP security on this specific TCP/IP-enabled network adapter.
    ''' </summary>
    ''' <param name="IPSecPermitTCPPorts">
    ''' List of ports to be granted access permission for TCP.
    ''' A numeric value of 0 (zero) indicates access permission is granted for all ports.
    ''' An empty array indicates that no ports are to be granted access permission.
    ''' </param>
    ''' <param name="IPSecPermitUDPPorts">
    ''' List of ports to be granted access permission for UDP.
    ''' A numeric value of 0 (zero) indicates access permission is granted for all ports.
    ''' An empty array indicates that no ports are to be granted access permission.</param>
    ''' <param name="IPSecPermitIPProtocols">
    ''' List of protocols permitted to run over the IP.
    ''' A numeric value of 0 (zero) indicates access permission is granted for all protocols.
    ''' An empty array indicates that no protocols are granted access permission.</param>
    ''' <remarks>Ports are secured only when the <see cref="P:WMIwrapper.Win32_NetworkAdapterConfiguration.IPFilterSecurityEnabled"></see> property in <see cref="T:WMIwrapper.Win32_NetworkAdapterConfiguration"></see> is true.</remarks>
    Public Function EnableIPSec(ByVal IPSecPermitTCPPorts As String(), ByVal IPSecPermitUDPPorts As String(), ByVal IPSecPermitIPProtocols As String()) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_NetworkAdapterConfiguration"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("EnableIPSec")
        inParams("IPFilterSecurityEnabled") = IPFilterSecurityEnabled

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("EnableIPSec", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Enables static TCP/IP addressing for the target network adapter.
    ''' </summary>
    ''' <param name="IPAddress">Lists all of the static IP addresses for the current network adapter.</param>
    ''' <param name="SubnetMask">Subnet masks that complement the values in the IPAddress parameter.</param>
    ''' <remarks> As a result, DHCP for this network adapter is disabled.</remarks>
    Public Function EnableStatic(ByVal IPAddress As String(), ByVal SubnetMask As String()) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_NetworkAdapterConfiguration"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("EnableStatic")
        inParams("IPAddress") = IPAddress
        inParams("SubnetMask") = SubnetMask

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("EnableStatic", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Enables WINS settings specific to TCP/IP, but independent of the network adapter.
    ''' </summary>
    ''' <param name="DNSEnabledForWINSResolution">
    ''' If true, the Domain Name System (DNS) is enabled for name resolution over WINS resolution.
    ''' </param>
    ''' <param name="WINSEnableLMHostsLookup">
    ''' If true, local lookup files are used.
    ''' Lookup files will contain mappings of IP addresses to host names.
    ''' </param>
    ''' <param name="WINSHostLookupFile">
    ''' Lookup files that contain mappings of IP addresses to host names.
    ''' If available, the files will be found in %SystemRoot%\system32\drivers\etc.
    ''' </param>
    ''' <param name="WINSScopeID">
    ''' Scope identifier value that will be appended to the end of the computer's NetBIOS name.
    ''' Systems that use the same scope identifier can communicate with this computer.
    ''' </param>
    ''' <remarks></remarks>
    Public Function EnableWINS(ByVal DNSEnabledForWINSResolution As Boolean, ByVal WINSEnableLMHostsLookup As Boolean, ByVal WINSHostLookupFile As String, ByVal WINSScopeID As String) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_NetworkAdapterConfiguration"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("EnableWINS")
        inParams("DNSEnabledForWINSResolution") = DNSEnabledForWINSResolution
        inParams("WINSEnableLMHostsLookup") = WINSEnableLMHostsLookup
        inParams("WINSHostLookupFile") = WINSHostLookupFile
        inParams("WINSScopeID") = WINSScopeID

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("EnableWINS", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Releases the IP address bound to a specific DHCP-enabled network adapter.
    ''' </summary>
    ''' <remarks>
    ''' Warning  If DHCP is enabled on the local computer system, the option disables TCP/IP on this specific network adapter.
    ''' Unless you have an alternate path to the target system, that is, another TCP/IP bound network adapter, all TCP/IP communications will be lost.
    ''' </remarks>
    Public Function ReleaseDHCPLease() As InvokeError

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("ReleaseDHCPLease")
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Releases the IP addresses bound to all DHCP-enabled network adapters.
    ''' </summary>
    ''' <remarks>
    ''' Note  Warning  If DHCP is enabled on the local computer system, the option will terminate all DHCP TCP/IP connections.
    ''' </remarks>
    Public Function ReleaseDHCPLeaseAll() As InvokeError

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("ReleaseDHCPLeaseAll")
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Renews the IP address on specific DHCP-enabled network adapters.
    ''' </summary>
    ''' <remarks>
    ''' The lease for the IP address assigned by a DHCP server has an expiration date that the client must renew if it intends to continue use of the assigned IP address.
    ''' </remarks>
    Public Function RenewDHCPLease() As InvokeError

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("RenewDHCPLease")
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Renews the IP addresses on all DHCP-enabled network adapters.
    ''' </summary>
    ''' <remarks>
    ''' The lease for the IP address assigned by a DHCP server has an expiration date that the client must renew if it intends to continue use of the assigned IP address.
    ''' </remarks>
    Public Function RenewDHCPLeaseAll() As InvokeError

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("RenewDHCPLeaseAll")
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Sets the transmission of ARP queries by the TCP/IP.
    ''' </summary>
    ''' <param name="ArpAlwaysSourceRoute">
    ''' If true, TCP/IP is forced to transmit ARP queries with source routing enabled on Token Ring networks.
    ''' By default, the stack transmits ARP queries without source routing first, then retries with source routing enabled if no reply is received.
    ''' </param>
    ''' <remarks></remarks>
    Public Function SetArpAlwaysSourceRoute(ByVal ArpAlwaysSourceRoute As Boolean) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_NetworkAdapterConfiguration"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("SetArpAlwaysSourceRoute")
        inParams("ArpAlwaysSourceRoute") = ArpAlwaysSourceRoute

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("SetArpAlwaysSourceRoute", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Enables Ethernet packets to use 802.3 SNAP encoding.
    ''' </summary>
    ''' <param name="ArpUseEtherSNAP">
    ''' If true enables TCP/IP to transmit Ethernet packets using 802.3 SNAP encoding.
    ''' </param>
    ''' <remarks>By default, the stack transmits packets in Digital, Intel, Xerox (DIX) Ethernet format.
    ''' It always receives both formats.
    ''' </remarks>
    Public Function SetArpUseEtherSNAP(ByVal ArpUseEtherSNAP As Boolean) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_NetworkAdapterConfiguration"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("SetArpUseEtherSNAP")
        inParams("ArpUseEtherSNAP") = ArpUseEtherSNAP

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("SetArpUseEtherSNAP", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Sets the path to the standard Internet database files (HOSTS, LMHOSTS, NETWORKS, and PROTOCOLS).
    ''' </summary>
    ''' <param name="DatabasePath">
    ''' Valid file path to standard Internet database files (HOSTS, LMHOSTS, NETWORKS, and PROTOCOLS) used by the Windows Sockets interface.
    ''' </param>
    ''' <remarks>It is used by the Windows Sockets interface. The default path is %SystemRoot%\system32\drivers\etc.</remarks>
    Public Function SetDatabasePath(ByVal DatabasePath As String) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_NetworkAdapterConfiguration"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("SetDatabasePath")
        inParams("DatabasePath") = DatabasePath

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("SetDatabasePath", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Enables dead gateway detection.
    ''' </summary>
    ''' <param name="DeadGWDetectEnabled">If true, dead gateway detection should be enabled.</param>
    ''' <remarks>
    ''' With this feature enabled, TCP asks IP to change to a backup gateway if it retransmits a segment several times without receiving a response.
    ''' </remarks>
    Public Function SetDeadGWDetect(ByVal DeadGWDetectEnabled As Boolean) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_NetworkAdapterConfiguration"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("SetDeadGWDetect")
        inParams("DeadGWDetectEnabled") = DeadGWDetectEnabled

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("SetDeadGWDetect", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Sets the default Time to Live (TTL) value in the header of outgoing IP packets.
    ''' </summary>
    ''' <param name="DefaultTTL">
    ''' Time to Live value set in the header of outgoing IP packets.
    ''' Default: 32; Valid range: 1 - 255
    ''' </param>
    ''' <remarks>
    ''' The TTL specifies the number of routers an IP packet may pass through to reach its destination before being discarded.
    ''' Each router decrements the TTL count of a packet by one and discards the packets with a TTL of 0 (zero).
    ''' </remarks>
    Public Function SetDefaultTTL(ByVal DefaultTTL As Byte) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_NetworkAdapterConfiguration"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("SetDefaultTTL")
        inParams("DefaultTTL") = DefaultTTL

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("SetDefaultTTL", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Sets the DNS domain.
    ''' </summary>
    ''' <param name="DNSDomain">
    ''' Domain with which the DNS is associated, represented by an organization name followed by a period and an extension that indicates the type of organization.
    ''' </param>
    ''' <remarks>
    ''' <para>This is an instance-dependent method call that applies on a per-adapter basis. The setting applies to the targeted adapter.</para>
    ''' <para>Windows NT 4.0:  The setting is global.</para>
    ''' </remarks>
    Public Function SetDNSDomain(ByVal DNSDomain As String) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_NetworkAdapterConfiguration"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("SetDNSDomain")
        inParams("DNSDomain") = DNSDomain

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("SetDNSDomain", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Sets the server search order as an array of elements.
    ''' </summary>
    ''' <param name="DNSServerSearchOrder">List of server IP addresses to query for DNS servers.</param>
    ''' <remarks>
    ''' This is an instance-dependent method call that applies on a per-adapter basis.
    ''' After static DNS servers are specified to start using Dynamic Host Configuration Protocol (DHCP) instead of static DNS servers, you can call the method without supplying "in" parameters.
    ''' In Windows 2000, the setting applies to the targeted adapter. In Windows NT, the setting is global.
    ''' </remarks>
    Public Function SetDNSServerSearchOrder(ByVal DNSServerSearchOrder As String()) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_NetworkAdapterConfiguration"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("SetDNSServerSearchOrder")
        inParams("DNSServerSearchOrder") = DNSServerSearchOrder

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("SetDNSServerSearchOrder", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Sets the suffix search order as an array of elements. 
    ''' </summary>
    ''' <param name="DNSDomainSuffixSearchOrder">
    ''' List of server suffixes to query for DNS servers.
    ''' The registry location of the DNS suffix is HKEY_LOCAL_MACHINE\System\CurrentControlSet\Services\Tcpip|NameServer
    ''' </param>
    ''' <remarks>
    ''' This is an instance-independent call that applies to all adapters but only for Windows NT.
    ''' </remarks>
    Public Function SetDNSSuffixSearchOrder(ByVal DNSDomainSuffixSearchOrder As String()) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_NetworkAdapterConfiguration"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("SetDNSSuffixSearchOrder")
        inParams("DNSDomainSuffixSearchOrder") = DNSDomainSuffixSearchOrder

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("SetDNSSuffixSearchOrder", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Indicates dynamic DNS registration of IP addresses for this IP-bound adapter.
    ''' </summary>
    ''' <param name="FullDNSRegistrationEnabled">
    ''' If true, the IP addresses for this connection is registered in DNS under the computer's full DNS name.
    ''' The full DNS name of the computer is displayed on the Network Identification tab of the system Control Panel.
    ''' </param>
    ''' <param name="DomainDNSRegistrationEnabled">
    ''' If true, the IP addresses for this connection are registered under the domain name of this connection, in addition to being registered under the computer's full DNS name.
    ''' The domain name of this connection is either set using the method SetDNSDomain or assigned by DHCP.
    ''' The registered name is the host name of the computer with the domain name appended.
    ''' This parameter has meaning only when FullDNSRegistrationEnabled is enabled.
    ''' The default value is false.
    ''' </param>
    ''' <remarks>This method is new for Windows XP.</remarks>
    Public Function SetDynamicDNSRegistration(ByVal FullDNSRegistrationEnabled As Boolean, ByVal DomainDNSRegistrationEnabled As Boolean) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_NetworkAdapterConfiguration"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("SetDynamicDNSRegistration")
        inParams("FullDNSRegistrationEnabled") = FullDNSRegistrationEnabled
        inParams("DomainDNSRegistrationEnabled") = DomainDNSRegistrationEnabled

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("SetDynamicDNSRegistration", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Specifies how much memory IP allocates to store packet data in the router packet queue.
    ''' </summary>
    ''' <param name="ForwardBufferMemory">
    ''' Size, in bytes, of the router packet queue used to store packet data.
    ''' The default value is 74240 (fifty 1480-byte packets, rounded to a multiple of 256).
    ''' </param>
    ''' <remarks>
    ''' When this buffer space is filled, the router begins discarding packets at random from its queue.
    ''' Packet queue data buffers are 256 bytes in length, so the value of the ForwardBufferMemory parameter should be a multiple of 256.
    ''' Multiple buffers are chained together for larger packets.
    ''' The IP header for a packet is stored separately.
    ''' This parameter is ignored and no buffers are allocated if the IP router is not enabled.
    ''' The buffer size can range from the network Maximum Transmission Unit (MTU) to a value smaller than 0xFFFFFFFF.
    ''' </remarks>
    Public Function SetForwardBufferMemory(ByVal ForwardBufferMemory As UInt32) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_NetworkAdapterConfiguration"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("SetForwardBufferMemory")
        inParams("ForwardBufferMemory") = ForwardBufferMemory

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("SetForwardBufferMemory", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Specifies a list of gateways for routing packets destined for a different subnet than the one this adapter is connected to.
    ''' </summary>
    ''' <param name="DefaultIPGateway">List of IP addresses to gateways where network packets are routed.</param>
    ''' <param name="GatewayCostMetric">
    ''' Assigns a value that ranges from 1 to 9999, which is used to calculate the fastest and most reliable routes.
    ''' The values of this parameter correspond with the values in the DefaultIPGateway parameter.
    ''' The default value for a gateway is 1.
    ''' This optional parameter is new for Windows 2000.
    ''' </param>
    ''' <remarks>This method only works when the Network Interface Card (NIC) is in the static IP mode.</remarks>
    Public Function SetGateways(ByVal DefaultIPGateway As String(), ByVal GatewayCostMetric As UInt16) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_NetworkAdapterConfiguration"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("SetGateways")
        inParams("DefaultIPGateway") = DefaultIPGateway
        inParams("GatewayCostMetric") = GatewayCostMetric

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("SetGateways", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Sets the extent to which the system supports IP multicasting and participates in the Internet Group Management Protocol.
    ''' </summary>
    ''' <param name="IGMPLevel">
    ''' Sets the level at which the system supports IP multicast and participates in the Internet Group Management Protocol.
    ''' At level 0, the system provides no multicast support.
    ''' At level 1, the system may only send IP multicast packets.
    ''' At level 2, the system may send IP multicast packets and fully participate in IGMP to receive multicast packets.
    ''' </param>
    ''' <remarks></remarks>
    Public Function SetIGMPLevel(ByVal IGMPLevel As Enums.IGMPLevel) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_NetworkAdapterConfiguration"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("SetIGMPLevel")
        inParams("IGMPLevel") = IGMPLevel

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("SetIGMPLevel", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Sets the routing metric associated with this IP-bound adapter.
    ''' </summary>
    ''' <param name="IPConnectionMetric">
    ''' Indicates the cost of using the configured routes for this IP-bound adapter.
    ''' The value is weighted for those routes in the IP routing table.
    ''' If there are multiple routes to a destination in the routing table, the route with the lowest metric is used.
    ''' The range of valid values is 1 through 9999.
    ''' The default value is 1.
    ''' </param>
    ''' <remarks></remarks>
    Public Function SetIPConnectionMetric(ByVal IPConnectionMetric As UInt32) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_NetworkAdapterConfiguration"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("SetIPConnectionMetric")
        inParams("IPConnectionMetric") = IPConnectionMetric

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("SetIPConnectionMetric", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Sets IP zero broadcast usage.
    ''' </summary>
    ''' <param name="IPUseZeroBroadcast">If true, IP zero broadcast is used. The default is false.</param>
    ''' <remarks>
    ''' If the IPUseZeroBroadcast parameter is set to TRUE, then IP will use zero-broadcasts (0.0.0.0) instead of one-broadcasts (255.255.255.255).
    ''' Most systems use one-broadcasts, but systems derived from BSD implementations use zero-broadcasts.
    ''' Systems that use different broadcasts will not interoperate on the same network.
    ''' </remarks>
    Public Function SetIPUseZeroBroadcast(ByVal IPUseZeroBroadcast As Boolean) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_NetworkAdapterConfiguration"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("SetIPUseZeroBroadcast")
        inParams("IPUseZeroBroadcast") = IPUseZeroBroadcast

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("SetIPUseZeroBroadcast", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ' TODO : SetIPX methods not implemented.

    ''' <summary>
    ''' Sets the interval separating Keep Alive Retransmissions until a response is received.
    ''' </summary>
    ''' <param name="KeepAliveInterval">Value, in milliseconds, for the interval separating Keep Alive Retransmissions until a response is received.</param>
    ''' <remarks>
    ''' After a response is received, the delay until the next Keep Alive Transmission is again controlled by the value of the <see cref="P:WMIwrapper.Win32_NetworkAdapterConfiguration.KeepAliveTime"></see> property.
    ''' The connection is terminated after the number of retransmissions specified by the <see cref="P:WMIwrapper.Win32_NetworkAdapterConfiguration.TcpMaxDataRetransmissions"></see> property have gone unanswered.
    ''' </remarks>
    Public Function SetKeepAliveInterval(ByVal KeepAliveInterval As UInt32) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_NetworkAdapterConfiguration"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("SetKeepAliveInterval")
        inParams("KeepAliveInterval") = KeepAliveInterval

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("SetKeepAliveInterval", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Sets how often TCP attempts to verify that an idle connection is still available by sending a Keep Alive packet.
    ''' </summary>
    ''' <param name="KeepAliveTime">Interval, in milliseconds, the TCP waits to check that an idle connection is still available.</param>
    ''' <remarks>
    ''' If the remote system is still reachable and functioning, it will acknowledge the Keep Alive transmission.
    ''' Keep Alive packets are not sent by default.
    ''' This feature may be enabled in a connection by an application.</remarks>
    Public Function SetKeepAliveTime(ByVal KeepAliveTime As UInt32) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_NetworkAdapterConfiguration"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("SetKeepAliveTime")
        inParams("KeepAliveTime") = KeepAliveTime

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("SetKeepAliveTime", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Sets the default Maximum Transmission Unit (MTU) for a network interface.
    ''' </summary>
    ''' <param name="MTU"></param>
    ''' <remarks>
    ''' <para>The MTU is the maximum packet size (in bytes) that a transport will transmit over the underlying network.
    ''' The size includes the transport header.
    ''' Note that an IP datagram can span multiple packets.
    ''' Values larger than the default for the underlying network result in the transport using the network default MTU.
    ''' Values smaller than 68 result in the transport using an MTU of 68.</para> 
    ''' <para>Windows Server 2003:  This method is not supported.
    ''' No replacement exists and the values do not correspond to the intended purpose of the method.</para>
    ''' </remarks>
    Public Function SetMTU(ByVal MTU As UInt32) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_NetworkAdapterConfiguration"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("SetMTU")
        inParams("MTU") = MTU

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("SetMTU", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Sets the number of IP packet headers allocated for the router packet queue.
    ''' </summary>
    ''' <param name="NumForwardPackets">
    ''' Number of IP packet headers allocated for the router packet queue.
    ''' This value should be at least as large as the <see cref="P:WMIwrapper.Win32_NetworkAdapterConfiguration.ForwardBufferMemory"/> value divided by the maximum IP data size of the networks connected to the router.
    ''' It should be no larger than the <see cref="P:WMIwrapper.Win32_NetworkAdapterConfiguration.ForwardBufferMemory"/> value divided by 256, since at least 256 bytes of forward buffer memory are used for each packet.
    ''' The optimal number of forward packets for a given <see cref="P:WMIwrapper.Win32_NetworkAdapterConfiguration.ForwardBufferMemory"/> size depends on the type of traffic on the network.
    ''' It will be somewhere between these two values.
    ''' If the router is not enabled, this parameter is ignored and no headers are allocated.
    ''' Default: 50, Valid Range: 1 - 0xFFFFFFFE.
    ''' </param>
    ''' <remarks>When all headers are in use, the router will begin to discard packets from the queue at random.</remarks>
    Public Function SetNumForwardPackets(ByVal NumForwardPackets As UInt32) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_NetworkAdapterConfiguration"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("SetNumForwardPackets")
        inParams("NumForwardPackets") = NumForwardPackets

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("SetNumForwardPackets", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Enables detection of Black Hole routers.
    ''' </summary>
    ''' <param name="PMTUBHDetectEnabled">If true, TCP attempts to discover Black Hole and route packets in different network paths. </param>
    ''' <remarks>
    ''' A Black Hole router does not return the Internet Control Message Protocol (ICMP) Destination Unreachable messages when it needs to fragment an IP datagram with the Don't Fragment bit set.
    ''' TCP depends on receiving these messages to perform Path MTU Discovery.
    ''' With this feature enabled, TCP will try to send segments without the Don't Fragment bit set if several retransmissions of a segment go unacknowledged.
    ''' If the segment is acknowledged as a result, the maximum segment size (MSS) will be decreased and the Don't Fragment bit will be set in future packets on the connection.
    ''' Enabling black hole detection increases the maximum number of retransmissions performed for a given segment.
    ''' </remarks>
    Public Function SetPMTUBHDetect(ByVal PMTUBHDetectEnabled As Boolean) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_NetworkAdapterConfiguration"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("SetPMTUBHDetect")
        inParams("PMTUBHDetectEnabled") = PMTUBHDetectEnabled

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("SetPMTUBHDetect", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Enables Maximum Transmission Unit (MTU) discovery.
    ''' </summary>
    ''' <param name="PMTUDiscoveryEnabled">
    ''' If true, TCP is enabled to attempt to discover the Maximum Transmission Unit (MTU) or largest packet size over the path to a remote host.
    ''' The default is true.</param>
    ''' <remarks>
    ''' By discovering the Path MTU and limiting TCP segments to this size, TCP can eliminate fragmentation at routers along the path that connect networks with different MTUs.
    ''' Fragmentation adversely affects TCP throughput and network congestion.
    ''' Setting this parameter to FALSE causes an MTU of 576 bytes to be used for all connections that are not to machines on the local subnet.
    ''' </remarks>
    Public Function SetPMTUDiscovery(ByVal PMTUDiscoveryEnabled As Boolean) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_NetworkAdapterConfiguration"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("SetPMTUDiscovery")
        inParams("PMTUDiscoveryEnabled") = PMTUDiscoveryEnabled

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("SetPMTUDiscovery", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Sets the default operation of NetBIOS over TCP/IP.
    ''' </summary>
    ''' <param name="TcpipNetbiosOptions"></param>
    ''' <remarks>Windows 2000 and Windows NT 4.0:  This property is not available.</remarks>
    Public Function SetTcpipNetbios(ByVal TcpipNetbiosOptions As Enums.TcpipNetbiosOptions) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_NetworkAdapterConfiguration"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("SetTcpipNetbios")
        inParams("TcpipNetbiosOptions") = TcpipNetbiosOptions

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("SetTcpipNetbios", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Sets the number of attempts TCP will retransmit a connect request before aborting.
    ''' </summary>
    ''' <param name="TcpMaxConnectRetransmissions">Number of attempts TCP will retransmit a connect request before aborting. The valid range for values is 0 - 0xFFFFFFFF.</param>
    ''' <remarks>The initial retransmission timeout is three seconds, and doubles for each successive attempt.</remarks>
    Public Function SetTcpMaxConnectRetransmissions(ByVal TcpMaxConnectRetransmissions As UInt32) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_NetworkAdapterConfiguration"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("SetTcpMaxConnectRetransmissions")
        inParams("TcpMaxConnectRetransmissions") = TcpMaxConnectRetransmissions

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("SetTcpMaxConnectRetransmissions", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Sets the number of times TCP will retransmit an individual data segment before aborting the connection.
    ''' </summary>
    ''' <param name="TcpMaxDataRetransmissions">Number of times TCP retransmits an individual data segment before aborting the connection. Valid range: 0 - 0xFFFFFFFF.</param>
    ''' <remarks>The retransmission timeout doubles with each successive retransmission on a connection.</remarks>
    Public Function SetTcpMaxDataRetransmissions(ByVal TcpMaxDataRetransmissions As UInt32) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_NetworkAdapterConfiguration"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("SetTcpMaxDataRetransmissions")
        inParams("TcpMaxDataRetransmissions") = TcpMaxDataRetransmissions

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("SetTcpMaxDataRetransmissions", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Sets the maximum number of connections that TCP may have open simultaneously.
    ''' </summary>
    ''' <param name="TcpNumConnections">Maximum number of connections that TCP may have open simultaneously. The valid range of values is 0 - 0xFFFFFE.</param>
    ''' <remarks></remarks>
    Public Function SetTcpNumConnections(ByVal TcpNumConnections As UInt32) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_NetworkAdapterConfiguration"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("SetTcpNumConnections")
        inParams("TcpNumConnections") = TcpNumConnections

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("SetTcpNumConnections", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Specifies whether TCP uses the RFC 1122 specification for urgent data, or the mode used by Berkeley Software Design (BSD) derived systems.
    ''' </summary>
    ''' <param name="TcpUseRFC1122UrgentPointer">If true, TCP uses the RFC 1122 specification. If false, urgent data is sent in the mode used by BSD-derived systems.</param>
    ''' <remarks>
    ''' The method is used to specify whether TCP uses the RFC 1122 specification for urgent data, or the mode used by Berkeley Software Design (BSD) derived systems.
    ''' The two mechanisms interpret the urgent pointer in the TCP header and the length of the urgent data differently.
    ''' They are not interoperable.
    ''' The default is BSD mode.
    ''' </remarks>
    Public Function SetTcpUseRFC1122UrgentPointer(ByVal TcpUseRFC1122UrgentPointer As Boolean) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_NetworkAdapterConfiguration"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("SetTcpUseRFC1122UrgentPointer")
        inParams("TcpUseRFC1122UrgentPointer") = TcpUseRFC1122UrgentPointer

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("SetTcpUseRFC1122UrgentPointer", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Sets the maximum TCP Receive Window size offered by the system.
    ''' </summary>
    ''' <param name="TcpWindowSize">Maximum TCP receive window size offered by the system. The valid range of values in bytes is 0 - 65535.</param>
    ''' <remarks>
    ''' The receive window specifies the number of bytes a sender can transmit without receiving an acknowledgment.
    ''' In general, larger receive windows improve performance over high-delay and high-bandwidth networks.
    ''' For efficiency, the receive window should be an even multiple of the TCP Maximum Segment Size (MSS).
    ''' </remarks>
    Public Function SetTcpWindowSize(ByVal TcpWindowSize As UInt16) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_NetworkAdapterConfiguration"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("SetTcpWindowSize")
        inParams("TcpWindowSize") = TcpWindowSize

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("SetTcpWindowSize", inParams)
        Return New InvokeError(InvokeReturn.ReturnValue, Me.ErrorMessage(InvokeReturn.ReturnValue))

    End Function

    ''' <summary>
    ''' Sets the primary and secondary Windows Internet Naming Service (WINS) servers on this TCP/IP-bound network adapter.
    ''' </summary>
    ''' <param name="WINSPrimaryServer">IP address of the primary WINS server.</param>
    ''' <param name="WINSSecondaryServer">IP address of the secondary WINS server.</param>
    ''' <remarks></remarks>
    Public Function SetWINSServer(ByVal WINSPrimaryServer As String, ByVal WINSSecondaryServer As String) As InvokeError

        ' Prepare in parameters
        Dim mc As New ManagementClass(New ManagementScope(_ManagementPath), New ManagementPath("Win32_NetworkAdapterConfiguration"), Nothing)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("SetWINSServer")
        inParams("WINSPrimaryServer") = WINSPrimaryServer
        inParams("WINSSecondaryServer") = WINSSecondaryServer

        ' Invoke method
        Dim InvokeReturn As InvokeReturn = Me.InvokeMethod("SetWINSServer", inParams)
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
                Return "Successful completion, no reboot required."
            Case 1
                Return "Successful completion, reboot required."
            Case 64
                Return "Method not supported on this platform."
            Case 65
                Return "Unknown failure."
            Case 66
                Return "Invalid subnet mask."
            Case 67
                Return "An error occurred while processing an instance that was returned."
            Case 68
                Return "Invalid input parameter."
            Case 69
                Return "More than five gateways specified."
            Case 70
                Return "Invalid IP address."
            Case 71
                Return "Invalid gateway IP address."
            Case 72
                Return "An error occurred while accessing the registry for the requested information."
            Case 73
                Return "Invalid domain name."
            Case 74
                Return "Invalid host name."
            Case 75
                Return "No primary or secondary WINS server defined."
            Case 76
                Return "Invalid file."
            Case 77
                Return "Invalid system path."
            Case 78
                Return "File copy failed."
            Case 79
                Return "Invalid security parameter."
            Case 80
                Return "Unable to configure TCP/IP service."
            Case 81
                Return "Unable to configure DHCP service."
            Case 82
                Return "Unable to renew DHCP lease."
            Case 83
                Return "Unable to release DHCP lease."
            Case 84
                Return "IP not enabled on adapter."
            Case 85
                Return "IPX not enabled on adapter."
            Case 86
                Return "Frame or network number bounds error."
            Case 87
                Return "Invalid frame type."
            Case 88
                Return "Invalid network number."
            Case 89
                Return "Duplicate network number."
            Case 90
                Return "Parameter out of bounds."
            Case 91
                Return " Access denied."
            Case 92
                Return "Out of memory."
            Case 93
                Return "Already exists."
            Case 94
                Return "Path, file, or object not found."
            Case 95
                Return "Unable to notify service."
            Case 96
                Return "Unable to notify DNS service."
            Case 97
                Return "Interface not configurable."
            Case 98
                Return "Not all DHCP leases can be released or renewed."
            Case 100
                Return "DHCP not enabled on adapter."
            Case Else
                Return "Unknown error."
        End Select
    End Function

#End Region

End Class



''' <summary>
''' Collection of <see cref="T:WMIwrapper.Win32_NetworkAdapterConfiguration"></see>.
''' </summary>
''' <remarks></remarks>
Public Class Win32_NetworkAdapterConfigurations
    Inherits CIM_Settings

    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <param name="Computer">The host computer.</param>
    ''' <param name="Index">If specified, only the item corresponding to this key value is returned. Ignored if <code>Condition</code> is set.</param>
    ''' <param name="Condition">WQL condition can be specified. It is not checked and sent to WMI as is.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Computer As String, Optional ByVal Index As UInteger = UInteger.MaxValue, Optional ByVal Condition As String = Nothing)

        MyBase.New(Computer, "Win32_NetworkAdapterConfiguration")
        ' Prepare condition
        If Condition Is Nothing AndAlso Index <> UInteger.MaxValue Then
            Condition = "Index =" & Index.ToString
        End If
        ' Read the collection
        For Each ManagementObjectI As ManagementObject In Me.Read(Condition)
            Me.Add(New Win32_NetworkAdapterConfiguration(ManagementObjectI))
        Next

    End Sub

    ''' <summary>
    ''' Find an item in the collection.
    ''' </summary>
    ''' <param name="index">Index of the item.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal index As Integer) As Win32_NetworkAdapterConfiguration
        Return CType(List.Item(index), Win32_NetworkAdapterConfiguration)
    End Function

    ''' <summary>
    ''' Find an item by its index.
    ''' </summary>
    ''' <param name="Index">The item's index.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Item(ByVal Index As UInteger) As Win32_NetworkAdapterConfiguration
        For intI As Integer = 0 To List.Count - 1
            If Me.Item(intI).Index = Index Then
                Return Me.Item(intI)
            End If
        Next
        Return Nothing
    End Function

End Class



Namespace Enums

    ''' <summary>
    ''' Extent to which the system supports IP multicast and participates in the Internet Group Management Protocol (IGMP).
    ''' </summary>
    ''' <remarks> At level 0 (zero), the system provides no multicast support. At level 1, the system may only send IP multicast packets. At level 2, the system may send IP multicast packets and fully participate in IGMP to receive multicast packets.</remarks>
    Public Enum IGMPLevel As Byte

        ''' <summary>
        ''' No Multicast.
        ''' </summary>
        ''' <remarks></remarks>
        NoMulticast = 0

        ''' <summary>
        ''' IP Multicast.
        ''' </summary>
        ''' <remarks></remarks>
        IPMulticast

        ''' <summary>
        ''' IP and IGMP Multicast (default).
        ''' </summary>
        ''' <remarks></remarks>
        IPandIGMPMulticast

    End Enum

    ''' <summary>
    ''' Bitmap of the possible settings related to NetBIOS over TCP/IP.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum TcpipNetbiosOptions As UInt32

        ''' <summary>
        ''' Enable Netbios via DHCP.
        ''' </summary>
        ''' <remarks></remarks>
        EnableNetbiosViaDhcp = 0

        ''' <summary>
        ''' Enable Netbios.
        ''' </summary>
        ''' <remarks></remarks>
        EnableNetbios

        ''' <summary>
        ''' Disable Netbios.
        ''' </summary>
        ''' <remarks></remarks>
        DisableNetbios
    End Enum

End Namespace
