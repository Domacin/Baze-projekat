﻿#pragma checksum "..\..\..\AddAutomobil.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7EBA1520395ED4DF68C1D7ABE448770CB5360261"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AUTOPRODAVNICA;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace AUTOPRODAVNICA {
    
    
    /// <summary>
    /// AddAutomobil
    /// </summary>
    public partial class AddAutomobil : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\AddAutomobil.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image slika;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\AddAutomobil.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ModelTextBox;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\AddAutomobil.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox GodinaProizvodnjeTextBox;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\AddAutomobil.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CenovnikComboBox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\AddAutomobil.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox MarkaComboBox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\AddAutomobil.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddCarButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AUTOPRODAVNICA;component/addautomobil.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AddAutomobil.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.slika = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.ModelTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.GodinaProizvodnjeTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\..\AddAutomobil.xaml"
            this.GodinaProizvodnjeTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.GodinaProizvodnjeTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CenovnikComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.MarkaComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.AddCarButton = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\AddAutomobil.xaml"
            this.AddCarButton.Click += new System.Windows.RoutedEventHandler(this.AddCarButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

