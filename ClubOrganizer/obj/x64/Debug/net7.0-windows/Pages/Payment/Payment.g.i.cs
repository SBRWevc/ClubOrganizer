﻿#pragma checksum "..\..\..\..\..\..\Pages\Payment\Payment.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "173C0E8E546DBA428925A6531E006D362388ACF0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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


namespace ClubOrganizer.Pages.Payment {
    
    
    /// <summary>
    /// Payment
    /// </summary>
    public partial class Payment : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 63 "..\..\..\..\..\..\Pages\Payment\Payment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataPayment;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\..\..\..\Pages\Payment\Payment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid BottombarSearch;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\..\..\..\Pages\Payment\Payment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ClientList;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\..\..\..\Pages\Payment\Payment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ClientSearch;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\..\..\..\..\Pages\Payment\Payment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ClientReset;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ClubOrganizer;V1.0.0.0;component/pages/payment/payment.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Pages\Payment\Payment.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.DataPayment = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.BottombarSearch = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.ClientList = ((System.Windows.Controls.ComboBox)(target));
            
            #line 108 "..\..\..\..\..\..\Pages\Payment\Payment.xaml"
            this.ClientList.GotFocus += new System.Windows.RoutedEventHandler(this.ClientList_GotFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ClientSearch = ((System.Windows.Controls.Button)(target));
            
            #line 131 "..\..\..\..\..\..\Pages\Payment\Payment.xaml"
            this.ClientSearch.Click += new System.Windows.RoutedEventHandler(this.ClientSearch_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ClientReset = ((System.Windows.Controls.Button)(target));
            
            #line 149 "..\..\..\..\..\..\Pages\Payment\Payment.xaml"
            this.ClientReset.Click += new System.Windows.RoutedEventHandler(this.ClientReset_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

