﻿#pragma checksum "..\..\..\Views\Customer.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D11A0D5DFB37B4318FC0CE256A88446B24E52D85EDADA7C3F56987BD795A08E7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using WpfApp2.Views;


namespace WpfApp2.Views {
    
    
    /// <summary>
    /// Customer
    /// </summary>
    public partial class Customer : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\..\Views\Customer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid isAddCus;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Views\Customer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMaKH;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Views\Customer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTen;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\Views\Customer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCMND;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\Views\Customer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSDT;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Views\Customer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDiaChi;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\Views\Customer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddCustomer;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\..\Views\Customer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearch;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\..\Views\Customer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearch;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\..\Views\Customer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid grvResever;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp2;component/views/customer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\Customer.xaml"
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
            this.isAddCus = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.txtMaKH = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtTen = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtCMND = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtSDT = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtDiaChi = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnAddCustomer = ((System.Windows.Controls.Button)(target));
            
            #line 103 "..\..\..\Views\Customer.xaml"
            this.btnAddCustomer.Click += new System.Windows.RoutedEventHandler(this.BtnAddCustomer_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txtSearch = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.btnSearch = ((System.Windows.Controls.Button)(target));
            return;
            case 10:
            this.grvResever = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

