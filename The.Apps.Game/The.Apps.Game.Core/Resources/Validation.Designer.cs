﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace The.Apps.Game.Core.Resources {
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
    public class Validation {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Validation() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("The.Apps.Game.Core.Resources.Validation", typeof(Validation).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid Email Address..
        /// </summary>
        public static string Input_Email_Validation {
            get {
                return ResourceManager.GetString("Input_Email_Validation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} must be same as {1}..
        /// </summary>
        public static string Input_EqualTo_Validation {
            get {
                return ResourceManager.GetString("Input_EqualTo_Validation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} contains invalid character {1} ..
        /// </summary>
        public static string Input_InvalidCharacter_Validation {
            get {
                return ResourceManager.GetString("Input_InvalidCharacter_Validation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} cannot be same as {1}..
        /// </summary>
        public static string Input_NotEqualTo_Validation {
            get {
                return ResourceManager.GetString("Input_NotEqualTo_Validation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} must be {1} at least {2} characters long..
        /// </summary>
        public static string Input_Range_Validation {
            get {
                return ResourceManager.GetString("Input_Range_Validation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The field {0} is required..
        /// </summary>
        public static string Input_Required_Validation {
            get {
                return ResourceManager.GetString("Input_Required_Validation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Displayed name.
        /// </summary>
        public static string Input_User_Display {
            get {
                return ResourceManager.GetString("Input_User_Display", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email.
        /// </summary>
        public static string Input_User_Email {
            get {
                return ResourceManager.GetString("Input_User_Email", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Login name.
        /// </summary>
        public static string Input_User_Name {
            get {
                return ResourceManager.GetString("Input_User_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password.
        /// </summary>
        public static string Input_User_Password {
            get {
                return ResourceManager.GetString("Input_User_Password", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password confirmed.
        /// </summary>
        public static string Input_User_PasswordConfirmed {
            get {
                return ResourceManager.GetString("Input_User_PasswordConfirmed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error.
        /// </summary>
        public static string Label_Error {
            get {
                return ResourceManager.GetString("Label_Error", resourceCulture);
            }
        }
    }
}
