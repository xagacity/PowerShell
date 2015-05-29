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
internal class MiniShellErrors {
    
    private static global::System.Resources.ResourceManager resourceMan;
    
    private static global::System.Globalization.CultureInfo resourceCulture;
    
    [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
    internal MiniShellErrors() {
    }
    
    /// <summary>
    ///   Returns the cached ResourceManager instance used by this class.
    /// </summary>
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    internal static global::System.Resources.ResourceManager ResourceManager {
        get {
            if (object.ReferenceEquals(resourceMan, null)) {
                global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MiniShellErrors", typeof(MiniShellErrors).GetTypeInfo().Assembly);
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
    ///   Looks up a localized string similar to Cannot reflect on the entry assembly and determine the value of the RunspaceConfigurationType attribute. .
    /// </summary>
    internal static string InvalidEntryAssembly {
        get {
            return ResourceManager.GetString("InvalidEntryAssembly", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot create the RunspaceConfiguration object because there is more than one assembly attribute of the type RunspaceConfigurationType defined in the assembly {0}..
    /// </summary>
    internal static string RunspaceConfigurationAttributeDuplicate {
        get {
            return ResourceManager.GetString("RunspaceConfigurationAttributeDuplicate", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot create the RunspaceConfiguration object because an assembly attribute of type RunspaceConfigurationType is not defined in assembly {0}. .
    /// </summary>
    internal static string RunspaceConfigurationAttributeNotExist {
        get {
            return ResourceManager.GetString("RunspaceConfigurationAttributeNotExist", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The RunspaceConfiguration-derived type {1} is not defined in assembly {0}..
    /// </summary>
    internal static string UndefinedRunspaceConfigurationType {
        get {
            return ResourceManager.GetString("UndefinedRunspaceConfigurationType", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The following errors occurred when updating the assembly list for the runspace: {0}..
    /// </summary>
    internal static string UpdateAssemblyErrors {
        get {
            return ResourceManager.GetString("UpdateAssemblyErrors", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The update is not supported for the runspace configuration category {0}. .
    /// </summary>
    internal static string UpdateNotSupportedForConfigurationCategory {
        get {
            return ResourceManager.GetString("UpdateNotSupportedForConfigurationCategory", resourceCulture);
        }
    }
}
