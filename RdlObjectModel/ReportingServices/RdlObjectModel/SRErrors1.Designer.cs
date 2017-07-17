﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.ReportingServices.RdlObjectModel {
    using System;
    
    
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
    internal class SRErrors {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SRErrors() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.ReportingServices.RdlObjectModel.SRErrors", typeof(SRErrors).Assembly);
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
        ///   Looks up a localized string similar to Values should be in Default, Left, Right, Top, Bottom format..
        /// </summary>
        internal static string BorderFormatError {
            get {
                return ResourceManager.GetString("BorderFormatError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deserialization failed: {0}.
        /// </summary>
        internal static string DeserializationFailed {
            get {
                return ResourceManager.GetString("DeserializationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deserialization failed in method {0}..
        /// </summary>
        internal static string DeserializationFailedMethod {
            get {
                return ResourceManager.GetString("DeserializationFailedMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not a valid color..
        /// </summary>
        internal static string InvalidColor {
            get {
                return ResourceManager.GetString("InvalidColor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The identifier &apos;{0}&apos; is not valid..
        /// </summary>
        internal static string InvalidIdentifier {
            get {
                return ResourceManager.GetString("InvalidIdentifier", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value &apos;{1}&apos; is not valid for {0}..
        /// </summary>
        internal static string InvalidParam {
            get {
                return ResourceManager.GetString("InvalidParam", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value for {0} must be between {1} and {2}..
        /// </summary>
        internal static string InvalidParamBetween {
            get {
                return ResourceManager.GetString("InvalidParamBetween", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value for {0} must be at least {1}..
        /// </summary>
        internal static string InvalidParamGreaterThan {
            get {
                return ResourceManager.GetString("InvalidParamGreaterThan", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value for {0} must be at most {1}..
        /// </summary>
        internal static string InvalidParamLessThan {
            get {
                return ResourceManager.GetString("InvalidParamLessThan", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not a valid unit designator. Valid unit designators are in, mm, cm, pt, pc..
        /// </summary>
        internal static string InvalidUnitType {
            get {
                return ResourceManager.GetString("InvalidUnitType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not a valid value..
        /// </summary>
        internal static string InvalidValue {
            get {
                return ResourceManager.GetString("InvalidValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Report element was not found..
        /// </summary>
        internal static string NoRootElement {
            get {
                return ResourceManager.GetString("NoRootElement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to parse text {0}. Text should be in {1} format..
        /// </summary>
        internal static string TextParseFailedFormat {
            get {
                return ResourceManager.GetString("TextParseFailedFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} cannot be parsed as a unit because it does not contain numeric values. Examples of valid unit strings are &quot;1pt&quot; and &quot;.5in&quot;..
        /// </summary>
        internal static string UnitParseNoDigits {
            get {
                return ResourceManager.GetString("UnitParseNoDigits", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} does not contain a unit specification. Examples of valid unit strings are &quot;1pt&quot; and &quot;.5in&quot;..
        /// </summary>
        internal static string UnitParseNoUnit {
            get {
                return ResourceManager.GetString("UnitParseNoUnit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The numeric portion of {0} cannot be parsed as a unit of type {2}..
        /// </summary>
        internal static string UnitParseNumericPart {
            get {
                return ResourceManager.GetString("UnitParseNumericPart", resourceCulture);
            }
        }
    }
}