//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoAbility {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class AutoAbilityConfig : global::System.Configuration.ApplicationSettingsBase {
        
        private static AutoAbilityConfig defaultInstance = ((AutoAbilityConfig)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new AutoAbilityConfig())));
        
        public static AutoAbilityConfig Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool PaladinAutoBuff {
            get {
                return ((bool)(this["PaladinAutoBuff"]));
            }
            set {
                this["PaladinAutoBuff"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool PriestAutoHeal {
            get {
                return ((bool)(this["PriestAutoHeal"]));
            }
            set {
                this["PriestAutoHeal"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool PriestAutoBuff {
            get {
                return ((bool)(this["PriestAutoBuff"]));
            }
            set {
                this["PriestAutoBuff"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool WarriorAutoBuff {
            get {
                return ((bool)(this["WarriorAutoBuff"]));
            }
            set {
                this["WarriorAutoBuff"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool EnabledByDefault {
            get {
                return ((bool)(this["EnabledByDefault"]));
            }
            set {
                this["EnabledByDefault"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.5")]
        public float RequiredManaPercent {
            get {
                return ((float)(this["RequiredManaPercent"]));
            }
            set {
                this["RequiredManaPercent"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.6")]
        public float RequiredHealthPercent {
            get {
                return ((float)(this["RequiredHealthPercent"]));
            }
            set {
                this["RequiredHealthPercent"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowBuffNotifications {
            get {
                return ((bool)(this["ShowBuffNotifications"]));
            }
            set {
                this["ShowBuffNotifications"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("50")]
        public int RetryDelay {
            get {
                return ((int)(this["RetryDelay"]));
            }
            set {
                this["RetryDelay"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool RogueAutoCloak {
            get {
                return ((bool)(this["RogueAutoCloak"]));
            }
            set {
                this["RogueAutoCloak"] = value;
            }
        }
    }
}
