﻿#pragma checksum "..\..\..\RemoveAutomobil.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C4E3118A7195ABFD6804B3E5579ABA84E000E541"
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
    /// RemoveAutomobil
    /// </summary>
    public partial class RemoveAutomobil : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\RemoveAutomobil.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image slika;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\RemoveAutomobil.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid automobilaDataGrid;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\RemoveAutomobil.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn ModelNameColumn;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\RemoveAutomobil.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn YearOfProductionNameColumn;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\RemoveAutomobil.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn MarkaNameColumn;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\RemoveAutomobil.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn CenovnikNameColumn;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\RemoveAutomobil.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox autoComboBox;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\RemoveAutomobil.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Done;
        
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
            System.Uri resourceLocater = new System.Uri("/AUTOPRODAVNICA;component/removeautomobil.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\RemoveAutomobil.xaml"
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
            
            #line 8 "..\..\..\RemoveAutomobil.xaml"
            ((AUTOPRODAVNICA.RemoveAutomobil)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.slika = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.automobilaDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.ModelNameColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 5:
            this.YearOfProductionNameColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 6:
            this.MarkaNameColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 7:
            this.CenovnikNameColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 8:
            this.autoComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.Done = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\RemoveAutomobil.xaml"
            this.Done.Click += new System.Windows.RoutedEventHandler(this.Done_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

