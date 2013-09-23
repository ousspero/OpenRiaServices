﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.431
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenRiaServices.DomainServices.Server.UnitTesting {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("OpenRiaServices.DomainServices.Server.UnitTesting.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Unable to find an Custom Update operation named &apos;{0}&apos; for the DomainService of type &apos;{1}&apos;..
        /// </summary>
        internal static string NoCustomUpdateOperation {
            get {
                return ResourceManager.GetString("NoCustomUpdateOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find an Invoke operation named &apos;{0}&apos; for the DomainService of type &apos;{1}&apos;..
        /// </summary>
        internal static string NoInvokeOperation {
            get {
                return ResourceManager.GetString("NoInvokeOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to determine an operation name based on the input expression &apos;{0}&apos;..
        /// </summary>
        internal static string NoOperationName {
            get {
                return ResourceManager.GetString("NoOperationName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to determine operation parameter values based on the input expression &apos;{0}&apos;..
        /// </summary>
        internal static string NoParameterValues {
            get {
                return ResourceManager.GetString("NoParameterValues", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find a Query operation named &apos;{0}&apos; for the DomainService of type &apos;{1}&apos;..
        /// </summary>
        internal static string NoQueryOperation {
            get {
                return ResourceManager.GetString("NoQueryOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Operations of type &apos;{0}&apos; are not supported for entities of type &apos;{1}&apos; on the DomainService of type &apos;{2}&apos;..
        /// </summary>
        internal static string OperationNotSupported {
            get {
                return ResourceManager.GetString("OperationNotSupported", resourceCulture);
            }
        }
    }
}
