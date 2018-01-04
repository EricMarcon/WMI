# WMI
**A wrapper to provide WMI classes for .NET solutions**

WMI is a powerful technology widely used by programmers to manage computers.
It can be accessed in .NET through the System.Management namespace. 
Although WMI classes are highly structured, the common way to use it is through WQL requests returning variant objects. 
The purpose of this project is to provide classes equivalent to WMI ones provided in the root\CIMV2 namespace. 
It implements many classes with their properties and methods, so that the programmer will not rely on WQL strings (such as `SELECT * FROM Win32_LogicalDisk`) that cannot be verified at compilation, but will use Intellisense in the Visual Studio GUI to get objects, properties, and methods.

The demo application is a quick and dirty proof of concept. 
First, connect to a computer with the _File / Open_ menu ("." is the default value for the local computer) and navigate in the tree of objects (not all classes are included, refer to the help file for a complete reference). 
The right pane of the screen displays all the properties and their values returned by the native WMI class for the first instance found. 
The bottom of the screen displays a gridview with all the properties (arrays excluded) of the corresponding wrapper's class, one instance per line (for example, one line for each drive). 
Comparing the panels is a quick and efficient way to debug the wrapper.

## Download binaries

- [x64](https://github.com/EricMarcon/WMI/releases/download/1.0/WMI.exe): For any x64 version of Windows > XP SP3.

The installers will download .NET Framework 4.7 if needed.


## Background

The base class is `WMIobject`. It does not exist in native WMI, but is used to provide general methods, mainly used to convert WMI types to .NET types and implement WMI methods. 
Other classes inherit from it, following the WMI architecture. 
For example (":" means "inherits from"), _Win32_ComputerSystem : CIM_UnitaryComputerSystem : CIM_ComputerSystem : CIM_System : CIM_LogicalElement: CIM_ManagedSystemElement : WMIobject_. 
Each class implements a part of the properties and methods used by the final one. 
As a rule of thumb, only the Win32-prefixed classes will be used outside the project.

The huge number of classes does not allow including a diagram here. 
You may use the _Documentation.chm_ file, or create a class diagram to see the hierarchy of classes. 
The actual hierarchy of WMI classes has been respected, with minor adaptations, because WMI supports multiple inheritance, but .NET does not.

Classes go by two: each object class, say `CIM_System`, has its corresponding collection class with the same name and a final _s_ (`CIM_Systems`). 
The collections mainly provide properties to find an item: the most common way to query WMI consists of filling the collection and then enumerating the items.

I added an extra class called Computer to simplify access to the other classes. 
Its use is detailed below.

## Using the code

### Computer hardware and system

The simplest use of the wrapper is through the `Computer` class. 
Connect to a computer with this code:

    Dim ComputerName As String = "."
    Dim _Computer As New WMIwrapper.Computer(ComputerName)

Your Windows account must have the necessary privileges to connect to a remote computer: either you are an administrator in a domain, or you have an account with the same login and password on both computers in a workgroup.

Since loading and running WMI takes quite a long time (usually a second or two), queries are not run by default. 
You must use methods to to this. 
The following code queries `Win32_Processors`:

    ' GetLogicalElements method queries WMI for hardware.
    ' The parameter is an enumeration for the hardware classes to query.
    ' WMIwrapper.Computer.LogicalElements.All is for all hardware.
    _Computer.GetLogicalElements(WMIwrapper.Computer.LogicalElements.Processors)

Now, the Processors property contains a collection of Processor objects. 
Loop through it to read their properties, such as `Caption`:


    If _Computer.Processors IsNot Nothing Then
      For Each Win32_Processor As WMIwrapper.Win32_Processor In _Computer.Processors
        MsgBox(Win32_Processor.Caption)
      Next
    End If

Refer to _Documentation.chm_ to discover all the methods and properties of the `Computer` class.

### File shares

Computer methods allow managing file shares (this is not so easy with .NET):

`GetShares` fills the Shares property, a collection of `Share` objects. 
Each of them is a file or printer share on the computer, supporting properties such as `Path` or `AccessMask` and methods such as `Delete`.

`CreateFileShare`, `DeleteFileShare` allow creating or deleting file shares without calling `GetShares`.

### Computer control

`Reboot` and `Shutdown` methods are available. 
`GetOperatingSystem` must have been called before.

### Using the Win32 classes

Full WMI access is possible if you use the `Win32-prefixed` classes. 
Generally, you will fill a collection and then loop through it:

    Dim _Processors As New WMIwrapper.Win32_Processors(ComputerName)
    If _Processors IsNot Nothing Then
      For Each Win32_ProcessorI As WMIwrapper.Win32_Processor In _Processors
        MsgBox(Win32_ProcessorI.Caption)
      Next
    End If

The collection constructor allows using the key values of the classes to select a single item, or to pass a WQL condition:

    ' Pass the key value
    Dim _Shares As New WMIwrapper.Win32_Shares(ComputerName,"Admin$")
    If _Shares IsNot Nothing Then
      For Each Win32_ShareI As WMIwrapper.Win32_Share In _Shares
        MsgBox(Win32_ShareI.Path)
      Next
    End If
    ' Pass a WQL condition
    Dim _Volumes As New WMIwrapper.Win32_Volumes(ComputerName, , "Caption = 'C:\\'")
    If _Volumes IsNot Nothing Then
      For Each Win32_VolumeI As WMIwrapper.Win32_Volume In _Volumes
        MsgBox(Win32_VolumeI.DeviceID)
      Next
    End If

A few classes are used differently. 
Security classes (`Win32_ACE`, `Win32_SecurityDescriptor`, and `Win32_Trustee`) do not belong to collections, and can be created from scratch. 
See the code of the `CreateFileShare` function in _Computer.vb_ to understand how to use them.

Methods are implemented. 
They return an `InvokeError` object, with two properties: `Number` (0 for success) and `Message`.

## Acknowledgements

I used TechNet as a reference for classes. 
Microsoft's WMI tools, especially WMI CIM Studio is the most convenient way to understand inheritance.

I used Sandcastle to compile the help file, through Sandcastle help file builder GUI.