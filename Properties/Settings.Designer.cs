﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ACH.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.1.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\ACH.mdf;Integ" +
            "rated Security=True;Connect Timeout=30")]
        public string ACHConnectionString {
            get {
                return ((string)(this["ACHConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=\"C:\\USERS\\HASAN\\DESKTOP\\ONEDRI" +
            "VE - ASIA PACIFIC UNIVERSITY\\IOOP PROGRESS\\ACH\\BIN\\DEBUG\\ACH.MDF\";Integrated Sec" +
            "urity=True")]
        public string C__USERS_HASAN_DESKTOP_ONEDRIVE___ASIA_PACIFIC_UNIVERSITY_IOOP_PROGRESS_ACH_BIN_DEBUG_ACH_MDFConnectionString {
            get {
                return ((string)(this["C__USERS_HASAN_DESKTOP_ONEDRIVE___ASIA_PACIFIC_UNIVERSITY_IOOP_PROGRESS_ACH_BIN_D" +
                    "EBUG_ACH_MDFConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(localdb)\\LocalDB;AttachDbFilename=|DataDirectory|\\bin\\Debug\\ACH.mdf;" +
            "Initial Catalog=ACHdb;Integrated Security=True")]
        public string ACHConnectionString1 {
            get {
                return ((string)(this["ACHConnectionString1"]));
            }
        }
    }
}
