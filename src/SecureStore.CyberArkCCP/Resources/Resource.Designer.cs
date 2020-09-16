﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UiPath.Orchestrator.Extensions.SecureStores.CyberArkCCP.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("UiPath.Orchestrator.Extensions.SecureStores.CyberArkCCP.Resources.Resource", typeof(Resource).Assembly);
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
        ///   Looks up a localized string similar to Invalid operation. Password change in progress..
        /// </summary>
        internal static string CyberArkPasswordChangeInProgress {
            get {
                return ResourceManager.GetString("CyberArkPasswordChangeInProgress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password for credentials stored in CyberArk is read-only..
        /// </summary>
        internal static string CyberArkReadOnly {
            get {
                return ResourceManager.GetString("CyberArkReadOnly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid Secure Store context..
        /// </summary>
        internal static string InvalidSecureStoreContext {
            get {
                return ResourceManager.GetString("InvalidSecureStoreContext", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid Configuration for secure store.
        /// </summary>
        internal static string SecureStore {
            get {
                return ResourceManager.GetString("SecureStore", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Certificate not found in user personal certificate store..
        /// </summary>
        internal static string SecureStoreCert {
            get {
                return ResourceManager.GetString("SecureStoreCert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Application ID.
        /// </summary>
        internal static string SettingNameApplicationID {
            get {
                return ResourceManager.GetString("SettingNameApplicationID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CyberArkCCP Folder.
        /// </summary>
        internal static string SettingNameFolder {
            get {
                return ResourceManager.GetString("SettingNameFolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CyberArkCCP Safe.
        /// </summary>
        internal static string SettingNameSafe {
            get {
                return ResourceManager.GetString("SettingNameSafe", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Personal Store Certificate Authority Thumbprint.
        /// </summary>
        internal static string SettingPersonalStoreCAThumbprint {
            get {
                return ResourceManager.GetString("SettingPersonalStoreCAThumbprint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CyberArkCCP Client Certificate Thumbprint.
        /// </summary>
        internal static string SettingThumbprint {
            get {
                return ResourceManager.GetString("SettingThumbprint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CCP URL.
        /// </summary>
        internal static string SettingURL {
            get {
                return ResourceManager.GetString("SettingURL", resourceCulture);
            }
        }
    }
}