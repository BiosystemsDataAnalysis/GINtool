﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GINtool.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.6.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("not defined yet")]
        public string referenceFile {
            get {
                return ((string)(this["referenceFile"]));
            }
            set {
                this["referenceFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Sheet1")]
        public string referenceSheetName {
            get {
                return ((string)(this["referenceSheetName"]));
            }
            set {
                this["referenceSheetName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("locus_tag")]
        public string referenceBSU {
            get {
                return ((string)(this["referenceBSU"]));
            }
            set {
                this["referenceBSU"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("regulon")]
        public string referenceRegulon {
            get {
                return ((string)(this["referenceRegulon"]));
            }
            set {
                this["referenceRegulon"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("mode")]
        public string referenceDIR {
            get {
                return ((string)(this["referenceDIR"]));
            }
            set {
                this["referenceDIR"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection directionMapUnassigned {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["directionMapUnassigned"]));
            }
            set {
                this["directionMapUnassigned"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection directionMapUp {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["directionMapUp"]));
            }
            set {
                this["directionMapUp"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection directionMapDown {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["directionMapDown"]));
            }
            set {
                this["directionMapDown"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1.5")]
        public float fcLOW {
            get {
                return ((float)(this["fcLOW"]));
            }
            set {
                this["fcLOW"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public float fcMID {
            get {
                return ((float)(this["fcMID"]));
            }
            set {
                this["fcMID"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4")]
        public float fcHIGH {
            get {
                return ((float)(this["fcHIGH"]));
            }
            set {
                this["fcHIGH"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("gene")]
        public string referenceGene {
            get {
                return ((string)(this["referenceGene"]));
            }
            set {
                this["referenceGene"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("not defined yet")]
        public string operonFile {
            get {
                return ((string)(this["operonFile"]));
            }
            set {
                this["operonFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.05")]
        public float pvalue_cutoff {
            get {
                return ((float)(this["pvalue_cutoff"]));
            }
            set {
                this["pvalue_cutoff"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool use_pvalues {
            get {
                return ((bool)(this["use_pvalues"]));
            }
            set {
                this["use_pvalues"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Sheet1")]
        public string operonSheet {
            get {
                return ((string)(this["operonSheet"]));
            }
            set {
                this["operonSheet"] = value;
            }
        }
    }
}
