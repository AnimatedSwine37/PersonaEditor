﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersonaEditor.ApplicationSettings {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.6.0.0")]
    internal sealed partial class SPREditor : global::System.Configuration.ApplicationSettingsBase {
        
        private static SPREditor defaultInstance = ((SPREditor)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new SPREditor())));
        
        public static SPREditor Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#00000000")]
        public global::System.Windows.Media.Color BackgroundColor {
            get {
                return ((global::System.Windows.Media.Color)(this["BackgroundColor"]));
            }
            set {
                this["BackgroundColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#FF000000")]
        public global::System.Windows.Media.Color LineColor {
            get {
                return ((global::System.Windows.Media.Color)(this["LineColor"]));
            }
            set {
                this["LineColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#80FF6600")]
        public global::System.Windows.Media.Color SelectColor {
            get {
                return ((global::System.Windows.Media.Color)(this["SelectColor"]));
            }
            set {
                this["SelectColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int BorderThickness {
            get {
                return ((int)(this["BorderThickness"]));
            }
            set {
                this["BorderThickness"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("P5")]
        public string DefaultEncoding {
            get {
                return ((string)(this["DefaultEncoding"]));
            }
            set {
                this["DefaultEncoding"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int Scale {
            get {
                return ((int)(this["Scale"]));
            }
            set {
                this["Scale"] = value;
            }
        }
    }
}
