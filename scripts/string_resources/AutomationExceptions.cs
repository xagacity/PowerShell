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
internal class AutomationExceptions {
    
    private static global::System.Resources.ResourceManager resourceMan;
    
    private static global::System.Globalization.CultureInfo resourceCulture;
    
    [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
    internal AutomationExceptions() {
    }
    
    /// <summary>
    ///   Returns the cached ResourceManager instance used by this class.
    /// </summary>
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    internal static global::System.Resources.ResourceManager ResourceManager {
        get {
            if (object.ReferenceEquals(resourceMan, null)) {
                global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AutomationExceptions", typeof(AutomationExceptions).GetTypeInfo().Assembly);
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
    ///   Looks up a localized string similar to Cannot process argument because the value of argument &quot;{0}&quot; is not valid. Change the value of the &quot;{0}&quot; argument and run the operation again..
    /// </summary>
    internal static string Argument {
        get {
            return ResourceManager.GetString("Argument", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot process argument because the value of argument &quot;{0}&quot; is null. Change the value of argument &quot;{0}&quot; to a non-null value..
    /// </summary>
    internal static string ArgumentNull {
        get {
            return ResourceManager.GetString("ArgumentNull", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot process argument because the value of argument &quot;{0}&quot; is out of range. Change argument &quot;{0}&quot; to  a value that is within range..
    /// </summary>
    internal static string ArgumentOutOfRange {
        get {
            return ResourceManager.GetString("ArgumentOutOfRange", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The script block cannot be converted because it contains more than one clause. Expressions or control structures are not permitted. Verify that the script block contains exactly one pipeline or command..
    /// </summary>
    internal static string CanConvertOneClauseOnly {
        get {
            return ResourceManager.GetString("CanConvertOneClauseOnly", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The script block cannot be converted to a Windows PowerShell object because it contains forbidden redirection operators..
    /// </summary>
    internal static string CanConvertOneOutputErrorRedir {
        get {
            return ResourceManager.GetString("CanConvertOneOutputErrorRedir", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Only a script block that contains exactly one pipeline or command can be converted. Expressions or control structures are not permitted. Verify that the script block contains exactly one pipeline or command..
    /// </summary>
    internal static string CanOnlyConvertOnePipeline {
        get {
            return ResourceManager.GetString("CanOnlyConvertOnePipeline", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to An empty script block cannot be converted. Verify that the script block contains exactly one pipeline or command..
    /// </summary>
    internal static string CantConvertEmptyPipeline {
        get {
            return ResourceManager.GetString("CantConvertEmptyPipeline", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot generate a Windows PowerShell object for a ScriptBlock that starts a pipeline with an expression..
    /// </summary>
    internal static string CantConvertPipelineStartsWithExpression {
        get {
            return ResourceManager.GetString("CantConvertPipelineStartsWithExpression", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The script block cannot be converted to an open generic type. Define an appropriate closed generic type, and then retry..
    /// </summary>
    internal static string CantConvertScriptBlockToOpenGenericType {
        get {
            return ResourceManager.GetString("CantConvertScriptBlockToOpenGenericType", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot generate a Windows PowerShell object for a ScriptBlock that does not have an associated operation context..
    /// </summary>
    internal static string CantConvertScriptBlockWithNoContext {
        get {
            return ResourceManager.GetString("CantConvertScriptBlockWithNoContext", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to A script block that contains a top-level trap statement cannot be converted..
    /// </summary>
    internal static string CantConvertScriptBlockWithTrap {
        get {
            return ResourceManager.GetString("CantConvertScriptBlockWithTrap", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot generate a Windows PowerShell object for a ScriptBlock which invokes pipelines, commands or functions to evaluate arguments of the main pipeline..
    /// </summary>
    internal static string CantConvertWithCommandInvocations {
        get {
            return ResourceManager.GetString("CantConvertWithCommandInvocations", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot generate a Windows PowerShell object for a ScriptBlock that uses dot sourcing..
    /// </summary>
    internal static string CantConvertWithDotSourcing {
        get {
            return ResourceManager.GetString("CantConvertWithDotSourcing", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot generate a Windows PowerShell object for a ScriptBlock evaluating dynamic expressions. Dynamic expression: {0}..
    /// </summary>
    internal static string CantConvertWithDynamicExpression {
        get {
            return ResourceManager.GetString("CantConvertWithDynamicExpression", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot generate a Windows PowerShell object for a ScriptBlock evaluating non-constant expressions. Non-constant expression: {0}..
    /// </summary>
    internal static string CantConvertWithNonConstantExpression {
        get {
            return ResourceManager.GetString("CantConvertWithNonConstantExpression", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot generate a Windows PowerShell object for a ScriptBlock that invokes other script blocks..
    /// </summary>
    internal static string CantConvertWithScriptBlockInvocation {
        get {
            return ResourceManager.GetString("CantConvertWithScriptBlockInvocation", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot generate a Windows PowerShell object for a ScriptBlock that tries to pass other script blocks inside argument values..
    /// </summary>
    internal static string CantConvertWithScriptBlocks {
        get {
            return ResourceManager.GetString("CantConvertWithScriptBlocks", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot generate a Windows PowerShell object for a ScriptBlock dereferencing variables undeclared in the param(...) block.  Name of undeclared variable: {0}..
    /// </summary>
    internal static string CantConvertWithUndeclaredVariables {
        get {
            return ResourceManager.GetString("CantConvertWithUndeclaredVariables", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot get the value of the Using expression &apos;{0}&apos; in the specified variable dictionary. When creating a PowerShell instance from a script block, the Using expression cannot contain an indexing operation or member-accessing operation..
    /// </summary>
    internal static string CantGetUsingExpressionValueWithSpecifiedVariableDictionary {
        get {
            return ResourceManager.GetString("CantGetUsingExpressionValueWithSpecifiedVariableDictionary", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot create workflow. The type &apos;{0}&apos; from the &apos;{1}&apos; module could not be loaded..
    /// </summary>
    internal static string CantLoadWorkflowType {
        get {
            return ResourceManager.GetString("CantLoadWorkflowType", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Object &quot;{0}&quot; is the wrong type to return from the dynamicparam block. The dynamicparam block must return either $null, or an object with type [System.Management.Automation.RuntimeDefinedParameterDictionary]..
    /// </summary>
    internal static string DynamicParametersWrongType {
        get {
            return ResourceManager.GetString("DynamicParametersWrongType", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The command was stopped by the user..
    /// </summary>
    internal static string HaltCommandException {
        get {
            return ResourceManager.GetString("HaltCommandException", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot perform operation because operation &quot;{0}&quot; is not valid. Remove operation &quot;{0}&quot;, or investigate why it is not valid..
    /// </summary>
    internal static string InvalidOperation {
        get {
            return ResourceManager.GetString("InvalidOperation", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot perform operation because operation &quot;{0}&quot; is not implemented..
    /// </summary>
    internal static string NotImplemented {
        get {
            return ResourceManager.GetString("NotImplemented", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot perform operation because operation &quot;{0}&quot; is not supported..
    /// </summary>
    internal static string NotSupported {
        get {
            return ResourceManager.GetString("NotSupported", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot perform operation because object &quot;{0}&quot; has already been disposed..
    /// </summary>
    internal static string ObjectDisposed {
        get {
            return ResourceManager.GetString("ObjectDisposed", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The script block cannot be invoked because it contains more than one clause. The Invoke() method can only be used on script blocks that contain a single clause..
    /// </summary>
    internal static string ScriptBlockInvokeOnOneClauseOnly {
        get {
            return ResourceManager.GetString("ScriptBlockInvokeOnOneClauseOnly", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The value of the using variable &apos;$using:{0}&apos; cannot be retrieved because it has not been set in the local session..
    /// </summary>
    internal static string UsingVariableIsUndefined {
        get {
            return ResourceManager.GetString("UsingVariableIsUndefined", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Windows PowerShell Workflow is not supported in a Windows PowerShell x86-based console. Open a Windows PowerShell x64-based console, and then try again..
    /// </summary>
    internal static string WorkflowDoesNotSupportWOW64 {
        get {
            return ResourceManager.GetString("WorkflowDoesNotSupportWOW64", resourceCulture);
        }
    }
}
