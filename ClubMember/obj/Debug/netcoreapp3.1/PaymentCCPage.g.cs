﻿#pragma checksum "..\..\..\PaymentCCPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4DFFC155F1733BB7934E41C2D4A2CDF1E603D1FE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ClubMember;
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


namespace ClubMember {
    
    
    /// <summary>
    /// PaymentCCPage
    /// </summary>
    public partial class PaymentCCPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\PaymentCCPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreditCard;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\PaymentCCPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Paypal;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\PaymentCCPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label PricePerMonth;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\PaymentCCPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PlusSignal;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\PaymentCCPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MinusSignal;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\PaymentCCPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label QuantityMonths;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\PaymentCCPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label PricePerMonth_Copy;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\PaymentCCPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label SubTotalPrice;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\PaymentCCPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label PricePerMonth_Copy1;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\PaymentCCPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TotalPrice;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\PaymentCCPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Renew;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ClubMember;component/paymentccpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PaymentCCPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.CreditCard = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.Paypal = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\PaymentCCPage.xaml"
            this.Paypal.Click += new System.Windows.RoutedEventHandler(this.Paypal_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PricePerMonth = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.PlusSignal = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\PaymentCCPage.xaml"
            this.PlusSignal.Click += new System.Windows.RoutedEventHandler(this.Increase_Months);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MinusSignal = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\PaymentCCPage.xaml"
            this.MinusSignal.Click += new System.Windows.RoutedEventHandler(this.Decrease_Months);
            
            #line default
            #line hidden
            return;
            case 6:
            this.QuantityMonths = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.PricePerMonth_Copy = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.SubTotalPrice = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.PricePerMonth_Copy1 = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.TotalPrice = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.Renew = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\PaymentCCPage.xaml"
            this.Renew.Click += new System.Windows.RoutedEventHandler(this.Pay_check);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

