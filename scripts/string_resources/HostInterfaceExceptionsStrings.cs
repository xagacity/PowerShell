﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Reflection;



/// <summary>
///   A strongly-typed resource class, for looking up localized strings, etc.
/// </summary>
// This class was auto-generated by the StronglyTypedResourceBuilder
// class via a tool like ResGen or Visual Studio.
// To add or remove a member, edit your .ResX file then rerun ResGen
// with the /str option, or rebuild your VS project.
[global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
internal class HostInterfaceExceptionsStrings {
    
    private static global::System.Resources.ResourceManager resourceMan;
    
    private static global::System.Globalization.CultureInfo resourceCulture;
    
    [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
    internal HostInterfaceExceptionsStrings() {
    }
    
    /// <summary>
    ///   Returns the cached ResourceManager instance used by this class.
    /// </summary>
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    internal static global::System.Resources.ResourceManager ResourceManager {
        get {
            if (object.ReferenceEquals(resourceMan, null)) {
                global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("HostInterfaceExceptionsStrings", typeof(HostInterfaceExceptionsStrings).GetTypeInfo().Assembly);
                resourceMan = temp;
            }
            return resourceMan;
        }
    }
    
    /// <summary>
    ///   Overrides the current thread's CurrentUICulture property for all
    ///   resource lookups using this strongly typed resource class.
    /// </summary>
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    internal static global::System.Globalization.CultureInfo Culture {
        get {
            return resourceCulture;
        }
        set {
            resourceCulture = value;
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to An error of type &quot;{0}&quot; has occurred..
    /// </summary>
    internal static string DefaultCtorMessageTemplate {
        get {
            return ResourceManager.GetString("DefaultCtorMessageTemplate", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to A command that prompts the user failed because the host program or the command type does not support user interaction. Try a host program that supports user interaction, such as the Windows PowerShell Console or Windows PowerShell ISE, and remove prompt-related commands from command types that do not support user interaction, such as Windows PowerShell workflows..
    /// </summary>
    internal static string HostFunctionNotImplemented {
        get {
            return ResourceManager.GetString("HostFunctionNotImplemented", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to A command that prompts the user failed because the host program or the command type does not support user interaction. The host was attempting to request confirmation with the following message: {0}.
    /// </summary>
    internal static string HostFunctionPromptNotImplemented {
        get {
            return ResourceManager.GetString("HostFunctionPromptNotImplemented", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The method cannot be invoked because the pool has been closed or has failed..
    /// </summary>
    internal static string RunspacePoolNotOpened {
        get {
            return ResourceManager.GetString("RunspacePoolNotOpened", resourceCulture);
        }
    }
}
