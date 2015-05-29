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
internal class AddMember {
    
    private static global::System.Resources.ResourceManager resourceMan;
    
    private static global::System.Globalization.CultureInfo resourceCulture;
    
    [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
    internal AddMember() {
    }
    
    /// <summary>
    ///   Returns the cached ResourceManager instance used by this class.
    /// </summary>
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    internal static global::System.Resources.ResourceManager ResourceManager {
        get {
            if (object.ReferenceEquals(resourceMan, null)) {
                global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AddMember", typeof(AddMember).GetTypeInfo().Assembly);
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
    ///   Looks up a localized string similar to The member referenced by this alias should not be null or empty..
    /// </summary>
    internal static string AliasReferenceShouldNotBeNullOrEmpty {
        get {
            return ResourceManager.GetString("AliasReferenceShouldNotBeNullOrEmpty", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot add a member with type &quot;{0}&quot;. Specify a different type for the MemberTypes parameter..
    /// </summary>
    internal static string CannotAddMemberType {
        get {
            return ResourceManager.GetString("CannotAddMemberType", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot force the member with name &quot;{0}&quot; and type &quot;{1}&quot; to be added. A member with that name and type already exists, and the existing member is not an instance extension..
    /// </summary>
    internal static string CannotRemoveTypeDataMember {
        get {
            return ResourceManager.GetString("CannotRemoveTypeDataMember", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The parameter NotePropertyName cannot take values that could be converted to the type {0}. To define the name of a member with those values, use Add-Member, and specify the member type..
    /// </summary>
    internal static string InvalidValueForNotePropertyName {
        get {
            return ResourceManager.GetString("InvalidValueForNotePropertyName", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot add a member with the name &quot;{0}&quot; because a member with that name already exists. To overwrite the member anyway, add the Force parameter to your command..
    /// </summary>
    internal static string MemberAlreadyExists {
        get {
            return ResourceManager.GetString("MemberAlreadyExists", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The name for a NoteProperty member should not be null or an empty string..
    /// </summary>
    internal static string NotePropertyNameShouldNotBeNull {
        get {
            return ResourceManager.GetString("NotePropertyNameShouldNotBeNull", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The TypeName parameter should not be null, empty, or contain only white spaces..
    /// </summary>
    internal static string TypeNameShouldNotBeEmpty {
        get {
            return ResourceManager.GetString("TypeNameShouldNotBeEmpty", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Both Value and SecondValue parameters should not be null for a member of type &quot;{0}&quot;. Specify a non-null value for one of the two parameters..
    /// </summary>
    internal static string Value1AndValue2AreNotBothNull {
        get {
            return ResourceManager.GetString("Value1AndValue2AreNotBothNull", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The Value parameter is required for a member of type &quot;{0}&quot;. Specify the Value parameter when adding members of this type..
    /// </summary>
    internal static string Value1Prompt {
        get {
            return ResourceManager.GetString("Value1Prompt", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The Value parameter should not be null for a member of type &quot;{0}&quot;. Specify a non-null value for the Value parameter when adding members of this type..
    /// </summary>
    internal static string Value1ShouldNotBeNull {
        get {
            return ResourceManager.GetString("Value1ShouldNotBeNull", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The SecondValue parameter should not be null for a member of type &quot;{0}&quot;. Specify a non-null value for the SecondValue parameter when adding members of this type..
    /// </summary>
    internal static string Value2ShouldNotBeNull {
        get {
            return ResourceManager.GetString("Value2ShouldNotBeNull", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The SecondValue parameter is not necessary for a member of type &quot;{0}&quot;, and should not be specified. Do not specify the SecondValue parameter when you add members of this type..
    /// </summary>
    internal static string Value2ShouldNotBeSpecified {
        get {
            return ResourceManager.GetString("Value2ShouldNotBeSpecified", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to To add a member, only one member type can be specified. The member types specified are: &quot;{0}&quot;.
    /// </summary>
    internal static string WrongMemberCount {
        get {
            return ResourceManager.GetString("WrongMemberCount", resourceCulture);
        }
    }
}
