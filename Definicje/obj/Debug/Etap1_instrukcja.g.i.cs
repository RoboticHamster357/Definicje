﻿#pragma checksum "..\..\Etap1_instrukcja.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C048947F29CDE96BDCD53293DF397EFF0FBBC52F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using Definicje;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Definicje {
    
    
    /// <summary>
    /// Etap1_instrukcja
    /// </summary>
    public partial class Etap1_instrukcja : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\Etap1_instrukcja.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBDefinicja;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Etap1_instrukcja.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBInstrukcja;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Etap1_instrukcja.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LEtap1;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Etap1_instrukcja.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BRozpocznij1;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Definicje;component/etap1_instrukcja.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Etap1_instrukcja.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TBDefinicja = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\Etap1_instrukcja.xaml"
            this.TBDefinicja.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TBInstrukcja_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TBInstrukcja = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.LEtap1 = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.BRozpocznij1 = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\Etap1_instrukcja.xaml"
            this.BRozpocznij1.Click += new System.Windows.RoutedEventHandler(this.BRozpocznij1_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

