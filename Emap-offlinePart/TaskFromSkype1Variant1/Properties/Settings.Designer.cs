﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaskFromSkype1Variant1.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.2.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("D:\\.Net-Lab10\\offlinePartNew\\.Net-Lab10.offlinePart\\Emap-offlinePart\\TaskFromSkyp" +
            "e1Variant1\\input.xlsx")]
        public string inputFile {
            get {
                return ((string)(this["inputFile"]));
            }
            set {
                this["inputFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("..D:\\.Net-Lab10\\offlinePartNew\\.Net-Lab10.offlinePart\\Emap-offlinePart\\TaskFromSk" +
            "ype1Variant1\\output.xlsx")]
        public string outputFile {
            get {
                return ((string)(this["outputFile"]));
            }
            set {
                this["outputFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\"A\"")]
        public string firstColumn {
            get {
                return ((string)(this["firstColumn"]));
            }
            set {
                this["firstColumn"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\"B\"")]
        public string secondColumn {
            get {
                return ((string)(this["secondColumn"]));
            }
            set {
                this["secondColumn"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int firstStartIndex {
            get {
                return ((int)(this["firstStartIndex"]));
            }
            set {
                this["firstStartIndex"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int secondStartIndex {
            get {
                return ((int)(this["secondStartIndex"]));
            }
            set {
                this["secondStartIndex"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Console")]
        public string outputTarget {
            get {
                return ((string)(this["outputTarget"]));
            }
            set {
                this["outputTarget"] = value;
            }
        }
    }
}
