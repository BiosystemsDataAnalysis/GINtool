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
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
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
        public double fcLOW {
            get {
                return ((double)(this["fcLOW"]));
            }
            set {
                this["fcLOW"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public double fcMID {
            get {
                return ((double)(this["fcMID"]));
            }
            set {
                this["fcMID"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4")]
        public double fcHIGH {
            get {
                return ((double)(this["fcHIGH"]));
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
        [global::System.Configuration.DefaultSettingValueAttribute("")]
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
        public double pvalue_cutoff {
            get {
                return ((double)(this["pvalue_cutoff"]));
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
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool sortAscending {
            get {
                return ((bool)(this["sortAscending"]));
            }
            set {
                this["sortAscending"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string categoryFile {
            get {
                return ((string)(this["categoryFile"]));
            }
            set {
                this["categoryFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Sheet1")]
        public string catSheet {
            get {
                return ((string)(this["catSheet"]));
            }
            set {
                this["catSheet"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool regPlot {
            get {
                return ((bool)(this["regPlot"]));
            }
            set {
                this["regPlot"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool tblMap {
            get {
                return ((bool)(this["tblMap"]));
            }
            set {
                this["tblMap"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool tblCombine {
            get {
                return ((bool)(this["tblCombine"]));
            }
            set {
                this["tblCombine"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool tblSummary {
            get {
                return ((bool)(this["tblSummary"]));
            }
            set {
                this["tblSummary"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool catPlot {
            get {
                return ((bool)(this["catPlot"]));
            }
            set {
                this["catPlot"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool distPlot {
            get {
                return ((bool)(this["distPlot"]));
            }
            set {
                this["distPlot"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool useCat {
            get {
                return ((bool)(this["useCat"]));
            }
            set {
                this["useCat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool tblOperon {
            get {
                return ((bool)(this["tblOperon"]));
            }
            set {
                this["tblOperon"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool useSort {
            get {
                return ((bool)(this["useSort"]));
            }
            set {
                this["useSort"] = value;
            }
        }
    }
}
