﻿#pragma checksum "..\..\..\Etap1_\Etap1_Sprawdzenie.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F8BAC21476CC2D0523C8B346F49A599A2C4CDD90"
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
    /// Etap1_Sprawdzenie
    /// </summary>
    public partial class Etap1_Sprawdzenie : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\Etap1_\Etap1_Sprawdzenie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BDalej;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Etap1_\Etap1_Sprawdzenie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBgratulacje;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Etap1_\Etap1_Sprawdzenie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbPoprawiona;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Etap1_\Etap1_Sprawdzenie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BJeszcze_Raz;
        
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
            System.Uri resourceLocater = new System.Uri("/Definicje;component/etap1_/etap1_sprawdzenie.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Etap1_\Etap1_Sprawdzenie.xaml"
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
            this.BDalej = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Etap1_\Etap1_Sprawdzenie.xaml"
            this.BDalej.Click += new System.Windows.RoutedEventHandler(this.BDalej_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TBgratulacje = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tbPoprawiona = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.BJeszcze_Raz = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Etap1_\Etap1_Sprawdzenie.xaml"
            this.BJeszcze_Raz.Click += new System.Windows.RoutedEventHandler(this.BJeszcze_Raz_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
