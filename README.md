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

[More details and binaries](https://ericmarcon.github.io/WMI/)
